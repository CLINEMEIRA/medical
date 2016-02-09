Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdsrc170 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC170" 
    Private Const PROGRAM_TITLE As String = "分割元指示NO検索" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                txtCatalog.Text = Request.QueryString("catalog").Trim()
                txtSiji.Text = Request.QueryString("sijino").Trim()
                MedicalLib.Common.ListSort = "I_PARTS_NO,INDICATE_NO"
                scrManager.SetFocus(txtCatalog)
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
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(0).Text.Trim() + "','" + oLine.Cells(1).Text.Trim() + "','" + oLine.Cells(10).Text.Trim() + "','" + oLine.Cells(11).Text.Trim() + "','" + oLine.Cells(2).Text.Trim() + "','" + oLine.Cells(12).Text.Trim() + "')"
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
            sQuery = "SELECT A.COMPANY_NO,A.INDICATE_NO,A.I_PARTS_NO,A.COMP_NEED_AMT,A.STW_AMT,A.PW_AMT,A.DELIVERY_DT,TO_CHAR(A.E_P_ORDER_MAIN,'000') || DECODE(A.E_P_ORDER_SUB,0,'','-' || TO_CHAR(A.E_P_ORDER_SUB,'0')) PROCESS_ORDER,D.P_ORDER_NM,B.RESULTS_DT,TO_CHAR(A.P_P_ORDER_MAIN,'000') || DECODE(A.P_P_ORDER_SUB,0,'','-' || TO_CHAR(A.P_P_ORDER_SUB,'0')) 対象PROCESS_ORDER,E.P_ORDER_NM 対象P_ORDER_NM,A.M_PARTS_NO "
            sQuery += "FROM INDICATE_TBL A,PROCESS_PROGRESS_TBL B,PROCESS_MST D,PROCESS_MST E "
            sQuery += "WHERE (A.INDICATE_NO = B.INDICATE_NO AND A.COMPANY_NO = B.COMPANY_NO AND A.E_P_ORDER_MAIN = B.P_ORDER_MAIN AND A.E_P_ORDER_SUB = B.P_ORDER_SUB) AND "
            sQuery += "B.PROCESS_CD = D.PROCESS_CD(+) AND A.P_PROCESS_CD = E.PROCESS_CD(+) AND TRIM(A.DEL_FLG) IS NULL AND A.P_P_ORDER_MAIN <> 0 AND A.E_P_ORDER_MAIN <> 0 AND "
            sQuery += "SUBSTR(A.I_PARTS_NO,1,:K10) >= :K11 AND SUBSTR(A.INDICATE_NO,1,:K20) >= :K21 "
            sQuery += "ORDER BY A.INDICATE_NO"
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
