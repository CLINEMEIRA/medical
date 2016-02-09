Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdsrc150 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC150" 
    Private Const PROGRAM_TITLE As String = "製品グループ検索" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                If Request.QueryString("kumi") Is Nothing Then
                    ViewState("mdsrc150kumi") = ""
                Else
                    ViewState("mdsrc150kumi") = Request.QueryString("kumi")
                End If
                MedicalLib.Common.ListSort = "GRP_NO1"
                scrManager.SetFocus(txtName1)
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
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(0).Text + "','" + oLine.Cells(1).Text + "','" + oLine.Cells(2).Text + "','" + oLine.Cells(3).Text + "','" + oLine.Cells(4).Text + "')"
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
            sQuery = "SELECT A.GRP_NO GRP_NO1,B.GRP_NM GRP_NM1,A.GRP_NO1 GRP_NO2,C.GRP_NM GRP_NM2,C.C_NO "
            sQuery += "FROM (SELECT GRP_NO,GRP_NO1 FROM PRODUCT_GRP_MST WHERE GRP_LV = '3') A,"
            sQuery += "(SELECT GRP_NO,GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = '1') B,"
            sQuery += "(SELECT GRP_NO,GRP_NM,C_NO FROM PRODUCT_GRP_MST WHERE GRP_LV = '2') C "
            sQuery += "WHERE A.GRP_NO = B.GRP_NO AND A.GRP_NO1 = C.GRP_NO AND "
            If ViewState("mdsrc150kumi") = "" Then
                sQuery += "B.GRP_NM LIKE :K01 AND C.GRP_NM LIKE :K02 "
                _oDatabase.CreateParam("K01", "%" + txtName1.Text.Trim() + "%")
                _oDatabase.CreateParam("K02", "%" + txtName2.Text.Trim() + "%")
            Else
                sQuery += "C.C_NO = :K03 AND B.GRP_NM LIKE :K01 AND C.GRP_NM LIKE :K02 "
                _oDatabase.CreateParam("K01", "%" + txtName1.Text.Trim() + "%")
                _oDatabase.CreateParam("K02", "%" + txtName2.Text.Trim() + "%")
                _oDatabase.CreateParam("K03", ViewState("mdsrc150kumi"))
            End If
            sQuery += "ORDER BY A.GRP_NO,A.GRP_NO1"
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
