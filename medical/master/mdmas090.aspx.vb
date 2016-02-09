﻿Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdmas090 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS090" 
    Private Const PROGRAM_TITLE As String = "SHOPマスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " ページ " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
 
            If Not Page.IsPostBack Then 
                Dim sql As String = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS019' ORDER BY TELL_CD" 
                Dim oDataReader As OracleDataReader = _oDatabase.CreateReader(sql) 
                ddlCode.Items.Add(New ListItem("", "")) 
                Do While oDataReader.Read 
                    ddlCode.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.Item("TELL_CD"))) 
                Loop 
                oDataReader.Close() 
            End If 
 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
 
        Dim sKey1 As String = "" 
        Dim sKey2 As String = "" 
        Dim sPage As String = "0" 
 
        If Not Page.IsPostBack Then 
            If Request.QueryString("key1") Is Nothing And Request.QueryString("key2") Is Nothing Then 
                MedicalLib.Common.Sort = "SHOP" 
            End If 
            If Not Request.QueryString("key1") Is Nothing Then sKey1 = Request.QueryString("key1") 
            If Not Request.QueryString("key2") Is Nothing Then sKey2 = Request.QueryString("key2") 
            If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page") 
            ddlCode.SelectedValue = sKey1 
            txtName.Text = sKey2 
            grdList.CurrentPageIndex = sPage 
        End If 
        btnInsert.Visible = MedicalLib.Common.EnableInsert 
        grdList.PageSize = MedicalLib.Common.PageSize 
        GridBind() 
    End Sub 
  
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

#End Region 
 
#Region " グリッドビュー " 
 
    Protected Sub grdList_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList.ItemDataBound 
        Dim origItem As String = ColorTranslator.ToHtml(grdList.ItemStyle.BackColor) 
        Dim origAltItem As String = ColorTranslator.ToHtml(grdList.AlternatingItemStyle.BackColor) 
        Dim oLine As DataGridItem = e.Item 
        If oLine.ItemType = ListItemType.Item Or oLine.ItemType = ListItemType.AlternatingItem Then 
            oLine.Style("cursor") = "hand" 
            oLine.Attributes("onmouseover") = "this.style.backgroundColor='Gold'" 
            If oLine.ItemType = ListItemType.Item Then 
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origItem + "'" 
            Else 
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origAltItem + "'" 
            End If 
            oLine.Attributes("onclick") = "selectGridRow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + HttpUtility.UrlEncode(ddlCode.SelectedValue) + "','" + HttpUtility.UrlEncode(txtName.Text.Trim()) + "'," & grdList.CurrentPageIndex & ")" 
        End If 
        'oLine.Cells(0).Width = 50 
        'oLine.Cells(1).Width = 220 
        'oLine.Cells(2).Width = 100 
    End Sub 
 
    Protected Sub grdList_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdList.PageIndexChanged
        grdList.CurrentPageIndex = e.NewPageIndex
        GridBind() 
    End Sub 
 
    Protected Sub grdList_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdList.SortCommand 
        MedicalLib.Common.SortCommand(e) 
        GridBind() 
    End Sub

#End Region

#Region " ボタン "

    Protected Sub btnSearch_Click(sender As Object, e As ImageClickEventArgs) Handles btnSearch.Click
        Session("SortExpression") = "SHOP"
        Session("SortDirection") = "ASC"
        grdList.CurrentPageIndex = 0
        GridBind()
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub GridBind()

        Try
            Dim sQuery As String = ""
            sQuery += "SELECT A.SHOP SHOP,A.SHOP_NM SHOP_NM,"
            sQuery += "DECODE(A.ORGANIZE_CD,'','',A.ORGANIZE_CD||'：'||B.ITEM_NM) ORGANIZE_CD "
            sQuery += "FROM SHOP_MST A, (SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS019') B "
            sQuery += "WHERE A.ORGANIZE_CD = B.TELL_CD(+) AND SHOP_NM LIKE :K01"
            _oDatabase.CreateParam("K01", "%" + txtName.Text.Trim() + "%")
            If Not ddlCode.SelectedValue.Trim.Equals("") Then
                sQuery += " AND ORGANIZE_CD = :K02"
                _oDatabase.CreateParam("K02", ddlCode.SelectedValue.Trim())
            End If
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView
            oDataView.Sort = MedicalLib.Common.Sort()
            grdList.DataSource = oDataView
            Try
                grdList.DataBind()
            Catch ex As Exception
                If grdList.PageCount <= grdList.CurrentPageIndex Then
                    grdList.CurrentPageIndex = grdList.PageCount - 1
                    grdList.DataBind()
                End If
            End Try
            Dim nCountAll As Integer = oDataView.Count
            Dim nCountStart As Integer = (grdList.CurrentPageIndex * grdList.PageSize) + 1
            Dim nCountEnd As Integer = (grdList.CurrentPageIndex + 1) * grdList.PageSize
            If nCountAll < nCountEnd Then nCountEnd = nCountAll
            If nCountAll = 0 Then
                lblCount.Text = "該当データがありません"
            Else
                lblCount.Text = nCountAll & "件中、" & nCountStart & "～" & nCountEnd & "件を表示"
            End If
        Catch tex As Threading.ThreadAbortException
            Throw
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

    End Sub

#End Region

End Class 
