Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdsrc200 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC200" 
    Private Const PROGRAM_TITLE As String = "修正工程着工指示検索" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                MedicalLib.Common.ListSort = "CATALOG_NO"
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
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(2).Text + "','" + oLine.Cells(1).Text + "','" + oLine.Cells(3).Text + "')"
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
            sQuery = "SELECT A.CATALOG_NO,A.COMPANY_NO,A.INDICATE_NO,A.UPD_CNT,A.CRT_DT,A.U_P_ORDER_MAIN || '-' || A.U_P_ORDER_SUB 修正PROCESS_ORDER,A.OLD_STW_AMT "
            sQuery += "FROM UPD_INDICATE_TBL A "
            sQuery += "WHERE NOT EXISTS (SELECT * FROM PROCESS_RESULTS_TBL WHERE INDICATE_NO = A.INDICATE_NO AND COMPANY_NO = A.COMPANY_NO AND TRIM(TO_CHAR(P_ORDER_MAIN,'000')) LIKE '9' || TRIM(TO_CHAR(A.UPD_CNT)) || '%') AND "
            sQuery += "SUBSTR(A.CATALOG_NO,1,:K10) >= :K11 AND TRIM(A.DEL_FLG) IS NULL "
            sQuery += "ORDER BY A.CATALOG_NO,A.COMPANY_NO,A.INDICATE_NO"
            _oDatabase.CreateParam("K10", GetKeyLength(txtBuban.Text))
            _oDatabase.CreateParam("K11", GetKey(txtBuban.Text))
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

    '工順編集 
    Friend Function GetKoujun(ByVal oKihon As Object) As String
        If oKihon.ToString.Equals("") Then Return ""
        Dim sKoujun() As String = CType(oKihon, String).Trim.Split("-")
        If sKoujun(1).Trim.Equals("0") Then
            Return sKoujun(0).Trim.PadLeft(3, "0")
        Else
            Return sKoujun(0).Trim.PadLeft(3, "0") + "-" + sKoujun(1).Trim()
        End If
    End Function

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
