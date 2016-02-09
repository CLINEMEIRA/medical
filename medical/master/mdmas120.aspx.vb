Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient

Partial Class master_mdmas120
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS120"
    Private Const PROGRAM_TITLE As String = "外注マスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            Dim sKey As String = ""
            Dim sPage As String = "0"
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                If Not Request.QueryString("key") Is Nothing Then
                    sKey = Request.QueryString("key")
                Else
                    MedicalLib.Common.Sort = "CONTRACTOUT_CD"
                End If
                If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page")
                txtName.Text = sKey
                grdList.CurrentPageIndex = sPage
            End If
            btnInsert.Visible = MedicalLib.Common.EnableInsert
            grdList.PageSize = MedicalLib.Common.PageSize
            GridBind()
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
            If oLine.Cells.Item(8).Text = "1" Then
                oLine.Cells.Item(8).Text = "M"
            Else
                oLine.Cells.Item(8).Text = ""
            End If
            oLine.Attributes("onclick") = "selectGridRow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + HttpUtility.UrlEncode(txtName.Text.Trim()) + "'," & grdList.CurrentPageIndex & ")"
        End If
    End Sub

    Protected Sub grdList_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdList.PageIndexChanged
        grdList.CurrentPageIndex = e.NewPageIndex
        GridBind()
    End Sub

    Protected Sub grdList_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdList.SortCommand
        MedicalLib.Common.SortCommand(e)
        GridBind()
    End Sub

    '検索ボタン押下 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        Session("SortExpression") = "CONTRACTOUT_CD"
        Session("SortDirection") = "ASC"
        GridBind()
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub GridBind()
        Try
            Dim sQuery As String = ""
            sQuery = "SELECT * FROM CONTRACTOUT_MST WHERE CONTRACTOUT_NM LIKE :KEY1"
            _oDatabase.CreateParam("KEY1", "%" + txtName.Text.Trim() + "%")
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
