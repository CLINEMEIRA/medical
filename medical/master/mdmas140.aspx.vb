Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdmas140 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS140" 
    Private Const PROGRAM_TITLE As String = "汎用マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " ページ " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
 
            If Not Page.IsPostBack Then 
                Dim sql As String = "SELECT ITEM_KN,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'C0001' ORDER BY ITEM_KN" 
                Dim oDataReader As OracleDataReader = _oDatabase.CreateReader(sql) 
                Do While oDataReader.Read 
                    If Not oDataReader.IsDBNull(0) Then 
                        ddlKubun.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.GetString(0))) 
                    Else 
                        ddlKubun.Items.Add(New ListItem("" + "：" + oDataReader.GetString(1), "")) 
                    End If 
 
                Loop 
                oDataReader.Close() 
            End If 
 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
 
        Dim sKey As String = "" 
        Dim sPage As String = "0" 
        If Not Page.IsPostBack Then 
            If Not Request.QueryString("key") Is Nothing Then 
                sKey = Request.QueryString("key") 
            Else 
                MedicalLib.Common.Sort = "INFO_KB,TELL_CD" 
            End If 
            If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page") 
            ddlKubun.SelectedValue = sKey 
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
            oLine.Attributes("onclick") = "selectGridRow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + HttpUtility.UrlEncode(oLine.Cells(1).Text) + "','" + HttpUtility.UrlEncode(ddlKubun.SelectedValue.Trim()) + "'," & grdList.CurrentPageIndex & ")" 
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

#End Region

#Region " ボタン "
    '検索 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        Session("SortExpression") = "INFO_KB,TELL_CD"
        Session("SortDirection") = "ASC"
        grdList.CurrentPageIndex = 0
        GridBind()
    End Sub

    '新規作成 
    Protected Sub btnInsert_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnInsert.Click
        Response.Redirect("mdmas1401.aspx?mode=i&code1=" + ddlKubun.SelectedValue.Trim() + "&code2=&key=" + ddlKubun.SelectedValue.Trim() + "&page=0")
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub GridBind() 
        Try 
            Dim sQuery As String = "SELECT * FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = :K01 "
            If ddlKubun.SelectedValue.Trim.Equals("C0001") Then
                sQuery += "AND ITEM_KN <> 'C0001' "
            End If
            _oDatabase.CreateParam("K01", ddlKubun.SelectedValue.Trim())
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
