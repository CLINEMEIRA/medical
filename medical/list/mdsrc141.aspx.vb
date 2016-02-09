Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient

Partial Class master_mdsrc141
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDSRC141"
    Private Const PROGRAM_TITLE As String = "製品グループ検索(L2)"

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                If Request.QueryString("kumi") Is Nothing Then
                    ViewState("mdsrc141kumi") = ""
                Else
                    ViewState("mdsrc141kumi") = Request.QueryString("kumi")
                End If
                If Request.QueryString("g1") Is Nothing Then
                    tblHeader.Rows(0).Visible = False
                    ViewState("mdsrc141search") = 0
                Else
                    tblHeader.Rows(0).Visible = True
                    lblGCode1.Text = Request.QueryString("g1").Trim()
                    Dim sQuery As String = "SELECT GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = '1' AND GRP_NO = " + Request.QueryString("g1").Trim()
                    Dim oReader As OracleDataReader = _oDatabase.CreateReader(sQuery)
                    If oReader.Read() Then lblGName1.Text = oReader.GetString(0)
                    oReader.Close()
                    ViewState("mdsrc141search") = 1
                End If
                MedicalLib.Common.ListSort = "GRP_NO"
                scrManager.SetFocus(txtName)
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
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(0).Text + "','" + oLine.Cells(1).Text + "','" + oLine.Cells(2).Text + "')"
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
            If ViewState("mdsrc141search") = 0 Then
                sQuery = "SELECT GRP_NO,GRP_NM,C_NO FROM PRODUCT_GRP_MST "
                If ViewState("mdsrc141kumi") = "" Then
                    sQuery += "WHERE GRP_LV = '2' AND GRP_NM LIKE :K01 ORDER BY GRP_NO"
                    _oDatabase.CreateParam("K01", "%" + txtName.Text.Trim() + "%")
                Else
                    sQuery += "WHERE GRP_LV = '2' AND C_NO = :K02 AND GRP_NM LIKE :K01 ORDER BY GRP_NO"
                    _oDatabase.CreateParam("K01", "%" + txtName.Text.Trim() + "%")
                    _oDatabase.CreateParam("K02", ViewState("mdsrc141kumi"))
                End If
            Else
                sQuery = "SELECT B.GRP_NO,B.GRP_NM,B.C_NO "
                sQuery += "FROM (SELECT GRP_NO1 FROM PRODUCT_GRP_MST WHERE GRP_LV = '3' AND GRP_NO = :K01) A,"
                sQuery += "(SELECT GRP_NO,GRP_NM,C_NO FROM PRODUCT_GRP_MST WHERE GRP_LV = '2') B "
                If ViewState("mdsrc141kumi") = "" Then
                    sQuery += "WHERE A.GRP_NO1 = B.GRP_NO AND B.GRP_NM LIKE :K02 ORDER BY B.GRP_NO"
                    _oDatabase.CreateParam("K01", lblGCode1.Text)
                    _oDatabase.CreateParam("K02", "%" + txtName.Text.Trim() + "%")
                Else
                    sQuery += "WHERE A.GRP_NO1 = B.GRP_NO AND B.C_NO = :K03 AND B.GRP_NM LIKE :K02 ORDER BY B.GRP_NO"
                    _oDatabase.CreateParam("K01", lblGCode1.Text)
                    _oDatabase.CreateParam("K02", "%" + txtName.Text.Trim() + "%")
                    _oDatabase.CreateParam("K03", ViewState("mdsrc141kumi"))
                End If
            End If
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
