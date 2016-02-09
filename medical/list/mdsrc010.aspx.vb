Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdsrc010 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC010" 
    Private Const PROGRAM_TITLE As String = "カタログ番号検索" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                If Not Request.QueryString("catalog") Is Nothing Then txtCatalog.Text = Request.QueryString("catalog")
                If Not Request.QueryString("syanai") Is Nothing Then txtSyanai.Text = Request.QueryString("syanai")
                If Request.QueryString("assy") Is Nothing Then
                    ViewState("MDSRC010assy") = ""
                Else
                    ViewState("MDSRC010assy") = Request.QueryString("assy")
                End If
                If Request.QueryString("mode") Is Nothing Then
                    ViewState("MDSRC010mode") = ""
                Else
                    ViewState("MDSRC010mode") = Request.QueryString("mode")
                End If
                MedicalLib.Common.ListSort = "CATALOG_NO"
                scrManager.SetFocus(txtCatalog)
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
            'oLine.Attributes("onclick") = "closeWindow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + HttpUtility.UrlEncode(oLine.Cells(1).Text) + "')" 
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(0).Text + "','" + oLine.Cells(2).Text + "','" + oLine.Cells(3).Text + "')"
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
 
#Region " 画面表示 "

    Private Sub DisplayList()
        Dim sQuery As String = ""
        Try
            If ViewState("MDSRC010assy") = "" And ViewState("MDSRC010mode") = "" Then
                sQuery = "SELECT CATALOG_NO,O_CATALOG_NO,COMPANY_NO,C_NO "
                sQuery += "FROM PARTS_MST "
                sQuery += "WHERE SUBSTR(CATALOG_NO,1,:K10) >= :K11 AND SUBSTR(O_CATALOG_NO,1,:K20) >= :K21 AND SUBSTR(COMPANY_NO,1,:K30) >= :K31 "

            ElseIf ViewState("MDSRC010mode") = "gen" Then    '源製品
                sQuery = "SELECT CATALOG_NO,O_CATALOG_NO,COMPANY_NO,C_NO "
                sQuery += "FROM PARTS_MST "
                sQuery += "WHERE SUBSTR(CATALOG_NO,1,:K10) >= :K11 AND SUBSTR(O_CATALOG_NO,1,:K20) >= :K21 AND SUBSTR(COMPANY_NO,1,:K30) >= :K31 "
                sQuery += "AND (C_NO = 'W1' OR C_NO BETWEEN 'W3' AND 'W9') AND ASSY_KB = '1' AND SUBSTR(CATALOG_NO,0,1) <> 'Z' "

            ElseIf ViewState("MDSRC010mode") = "ko" Then     '子部品
                sQuery = "SELECT CATALOG_NO,O_CATALOG_NO,COMPANY_NO,C_NO "
                sQuery += "FROM PARTS_MST "
                sQuery += "WHERE SUBSTR(CATALOG_NO,1,:K10) >= :K11 AND SUBSTR(O_CATALOG_NO,1,:K20) >= :K21 AND SUBSTR(COMPANY_NO,1,:K30) >= :K31 "
                sQuery += "AND (C_NO = 'Z9' OR ((C_NO = 'W1' OR C_NO BETWEEN 'W3' AND 'W9') AND SUBSTR(CATALOG_NO,0,1) = 'Z')) "

            Else
                sQuery = "SELECT CATALOG_NO,O_CATALOG_NO,COMPANY_NO,C_NO "
                sQuery += "FROM PARTS_MST "
                sQuery += "WHERE SUBSTR(CATALOG_NO,1,:K10) >= :K11 AND SUBSTR(O_CATALOG_NO,1,:K20) >= :K21 AND SUBSTR(COMPANY_NO,1,:K30) >= :K31 AND (ASSY_KB = :K01 OR C_NO = 'Z9') "
                _oDatabase.CreateParam("K01", ViewState("MDSRC010assy"))

            End If

            '**** 2010/08 組番 = Z9 追加 ST ****
            If Page.Request.QueryString("Z9") IsNot Nothing Then
                sQuery = "SELECT CATALOG_NO,O_CATALOG_NO,COMPANY_NO,C_NO "
                sQuery += "FROM PARTS_MST "
                sQuery += "WHERE SUBSTR(CATALOG_NO,1,:K10) >= :K11 AND SUBSTR(O_CATALOG_NO,1,:K20) >= :K21 AND SUBSTR(COMPANY_NO,1,:K30) >= :K31 "
                sQuery += "AND C_NO = 'Z9'"
            End If
            '**** 2010/08 組番 = Z9 追加 ED ****

            '生産停止フラグ = 0
            If Request.QueryString("teisi") Is Nothing Then
                sQuery += "AND SURPLUS_STOP_FLG = '0' "
            End If
            sQuery += "ORDER BY CATALOG_NO"

            _oDatabase.CreateParam("K10", GetKeyLength(txtCatalog.Text))
            _oDatabase.CreateParam("K11", GetKey(txtCatalog.Text))
            _oDatabase.CreateParam("K20", GetKeyLength(txtMoto.Text))
            _oDatabase.CreateParam("K21", GetKey(txtMoto.Text))
            _oDatabase.CreateParam("K30", GetKeyLength(txtSyanai.Text))
            _oDatabase.CreateParam("K31", GetKey(txtSyanai.Text))
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
