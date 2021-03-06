﻿Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdsrc190 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC190" 
    Private Const PROGRAM_TITLE As String = "工訂順序検索" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                ViewState("mode") = Request.QueryString("mode")
                lblSiji.Text = Request.QueryString("siji")
                lblShanai.Text = Request.QueryString("syanai")
                lblCatalog.Text = Request.QueryString("catalog")
                MedicalLib.Common.ListSort = "P_ORDER_MAIN,P_ORDER_SUB"
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
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(1).Text.PadLeft(3, "0") + "','" + oLine.Cells(2).Text + "')"
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
        Try
            Dim sQuery As String = ""
            sQuery = "SELECT TO_CHAR(B.P_ORDER_MAIN,'000') || '-' || TO_CHAR(B.P_ORDER_SUB,'0') PROCESS_ORDER,B.P_ORDER_MAIN,B.P_ORDER_SUB,B.PROCESS_CD,C.P_ORDER_NM,B.SHOP "
            sQuery += "FROM INDICATE_TBL A,"
            If ViewState("mode").Equals("0") Or ViewState("mode").Equals("2") Then
                sQuery += "(SELECT INDICATE_NO,COMPANY_NO,P_ORDER_MAIN,P_ORDER_SUB,PROCESS_CD,SHOP FROM PROCESS_PROGRESS_TBL WHERE UPD_CNT = 0 AND RESULTS_DT = '00000000') B,"
            ElseIf ViewState("mode").Equals("1") Or ViewState("mode").Equals("3") Then
                sQuery += "(SELECT INDICATE_NO,COMPANY_NO,P_ORDER_MAIN,P_ORDER_SUB,PROCESS_CD,SHOP FROM PROCESS_PROGRESS_TBL WHERE UPD_CNT = 0 AND RESULTS_DT <> '00000000') B,"
            Else
                sQuery += "PROCESS_PROGRESS_TBL B,"
            End If
            sQuery += "PROCESS_MST C "
            sQuery += "WHERE (A.INDICATE_NO = B.INDICATE_NO(+) AND A.COMPANY_NO = B.COMPANY_NO(+)) AND "
            sQuery += "B.PROCESS_CD = C.PROCESS_CD(+) AND "
            sQuery += "A.INDICATE_DECIDE_FLG = 'K' AND TRIM(A.DEL_FLG) IS NULL AND "
            If ViewState("mode").Equals("2") Or ViewState("mode").Equals("3") Or ViewState("mode").Equals("4") Then sQuery += "B.P_ORDER_SUB = 0 AND "
            sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
            _oDatabase.CreateParam("K01", lblSiji.Text.Trim())
            _oDatabase.CreateParam("K02", lblShanai.Text.Trim())
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
    Friend Function GetKoujun(ByVal oKihon As Object, ByVal oHojo As Object) As String
        If oKihon.ToString.Equals("") Then Return ""
        Dim sKoujun As String = CType(oKihon, Integer).ToString("000")
        If oHojo.ToString.Equals("") Then Return sKoujun
        If CType(oHojo, Integer) <> 0 Then sKoujun += "-" + oHojo.ToString()
        Return sKoujun
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
