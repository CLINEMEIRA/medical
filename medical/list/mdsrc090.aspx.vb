﻿Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdsrc090 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC090" 
    Private Const PROGRAM_TITLE As String = "指示NO検索" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                ViewState("mode") = ""
                ViewState("kumi") = ""
                txtSiji.Text = Request.QueryString("sijino").Trim()
                txtBuban.Text = Request.QueryString("catalog").Trim()
                MedicalLib.Common.ListSort = "I_PARTS_NO,INDICATE_NO"
                If Not Request.QueryString("mode") Is Nothing Then ViewState("mode") = Request.QueryString("mode")
                If Not Request.QueryString("kumi") Is Nothing Then ViewState("kumi") = Request.QueryString("kumi")
                scrManager.SetFocus(txtBuban)
            Else
                If Not Request.Form("btnSearch") Is Nothing Then grdList.CurrentPageIndex = 0
            End If
            DisplayList()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

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
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(1).Text + "','" + oLine.Cells(0).Text + "','" + oLine.Cells(2).Text + "')"
        End If
    End Sub

    Protected Sub grdList_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdList.PageIndexChanged
        grdList.CurrentPageIndex = e.NewPageIndex
        DisplayList()
    End Sub

    Protected Sub grdList_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdList.SortCommand
        MedicalLib.Common.ListSortCommand(e)
        DisplayList()
    End Sub

#End Region
 
#Region " 画面関連 "

    Private Sub DisplayList()
        Dim sQuery As String = ""
        Try
            sQuery = "SELECT INDICATE_NO,COMPANY_NO,I_PARTS_NO,DELIVERY_DT,ORDER_AMT,COMP_NEED_AMT,STW_AMT,PW_AMT "
            sQuery += "FROM INDICATE_TBL "
            If ViewState("mode") = "" Then
                sQuery += "WHERE SUBSTR(I_PARTS_NO,1,:K10) >= :K11 AND SUBSTR(INDICATE_NO,1,:K20) >= :K21 AND TRIM(DEL_FLG) IS NULL "
            ElseIf ViewState("mode") = "1" Then
                sQuery += "WHERE SUBSTR(I_PARTS_NO,1,:K10) >= :K11 AND SUBSTR(INDICATE_NO,1,:K20) >= :K21 AND TRIM(DEL_FLG) IS NULL AND INDICATE_DECIDE_FLG = 'K' "
            End If
            If Not ViewState("kumi").ToString.Trim.Equals("") Then
                sQuery += " AND C_NO = :K30 "
                _oDatabase.CreateParam("K30", ViewState("kumi").ToString.Trim())
            End If
            sQuery += "ORDER BY COMPANY_NO,INDICATE_NO"
            _oDatabase.CreateParam("K10", GetKeyLength(txtBuban.Text))
            _oDatabase.CreateParam("K11", GetKey(txtBuban.Text))
            _oDatabase.CreateParam("K20", GetKeyLength(txtSiji.Text))
            _oDatabase.CreateParam("K21", GetKey(txtSiji.Text))
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView
            oDataView.Sort = MedicalLib.Common.ListSort()
            If oDataView.Count = 0 Then grdList.CurrentPageIndex = 0
            grdList.DataSource = oDataView
            grdList.DataBind()
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

#Region " その他 "

    Private Function GetKey(ByVal sValue As String) As String
        If sValue.Trim.Equals("") Then
            Return " "
        Else
            Return sValue.Trim()
        End If
    End Function

    Private Function GetKeyLength(ByVal sValue As String) As Integer
        If sValue.Trim.Equals("") Then
            Return 1
        Else
            Return sValue.Trim.Length
        End If
    End Function

#End Region
 
End Class 
