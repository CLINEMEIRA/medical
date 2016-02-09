Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class mdsrc240
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDSRC240"
    Private Const PROGRAM_TITLE As String = "着工指示検索"

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                txtSiji.Text = Request.QueryString("sijino").Trim()
                MedicalLib.Common.ListSort = "CATALOG_NO"
                ViewState("MDSRC240Mode") = Request.QueryString("mode")
                scrManager.SetFocus(txtCatalog)
            Else
                If Not Request.Form("btnSearch") Is Nothing Then grdList.CurrentPageIndex = 0
            End If
            If ViewState("MDSRC240Mode").ToString.Equals("0") Then
                tblHeader.Rows(0).Cells(1).Width = 250
                tblHeader.Rows(1).Cells(1).Width = 250
            Else
                tblHeader.Rows(0).Cells(1).Width = 330
                tblHeader.Rows(1).Cells(1).Width = 330
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
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(1).Text + "','" + oLine.Cells(2).Text + "','" + oLine.Cells(3).Text + "')"
        End If
        oLine.Cells(3).Visible = Not ViewState("MDSRC240Mode").ToString.Equals("0")
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
            If ViewState("MDSRC240Mode").ToString.Equals("0") Then
                sQuery = "SELECT A.CATALOG_NO,A.COMPANY_NO,A.INDICATE_NO,'' UPD_CNT,B.DELIVERY_DT FROM PROCESS_F_TBL A,INDICATE_TBL B "
                sQuery += "WHERE A.INDICATE_NO = B.INDICATE_NO AND A.COMPANY_NO = B.COMPANY_NO AND "
            Else
                sQuery = "SELECT A.CATALOG_NO,A.COMPANY_NO,A.INDICATE_NO,A.UPD_CNT,B.DELIVERY_DT FROM U_PROCESS_F_TBL A,UPD_INDICATE_TBL B "
                sQuery += "WHERE A.INDICATE_NO = B.INDICATE_NO AND A.COMPANY_NO = B.COMPANY_NO AND A.UPD_CNT = B.UPD_CNT AND "
            End If
            sQuery += "SUBSTR(A.CATALOG_NO,1,:K10) >= :K11 AND SUBSTR(A.INDICATE_NO,1,:K20) >= :K21 AND A.END_KB = '1'"
            _oDatabase.CreateParam("K10", GetKeyLength(txtCatalog.Text))
            _oDatabase.CreateParam("K11", GetKey(txtCatalog.Text))
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
