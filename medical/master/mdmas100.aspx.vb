Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdmas100 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS100" 
    Private Const PROGRAM_TITLE As String = "設備マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " ページ " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
 
            If Not Page.IsPostBack Then 
                Dim sql As String = "SELECT SHOP,SHOP_NM FROM SHOP_MST ORDER BY SHOP" 
                Dim oDataReader As OracleDataReader = _oDatabase.CreateReader(sql) 
                ddlShop.Items.Add(New ListItem("", "")) 
                Do While oDataReader.Read 
                    ddlShop.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetOracleString(1), oDataReader.GetOracleString(0))) 
                Loop 
                oDataReader.Close() 
            End If 
 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
 
        Dim sKey1 As String = "" 
        Dim sKey2 As String = "" 
        Dim sPage As String = "0" 
 
        If Not Page.IsPostBack Then 
            If Request.QueryString("key1") Is Nothing And Request.QueryString("key2") Is Nothing Then 
                MedicalLib.Common.Sort = "FACILITIES_CD" 
            End If 
            If Not Request.QueryString("key1") Is Nothing Then sKey1 = Request.QueryString("key1") 
            If Not Request.QueryString("key2") Is Nothing Then sKey2 = Request.QueryString("key2") 
            If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page") 
            ddlShop.SelectedValue = sKey1 
            txtName.Text = sKey2 
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
            oLine.Attributes("onclick") = "selectGridRow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + HttpUtility.UrlEncode(ddlShop.SelectedValue) + "','" + HttpUtility.UrlEncode(txtName.Text.Trim()) + "'," & grdList.CurrentPageIndex & ")" 
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

    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        Session("SortExpression") = "FACILITIES_CD"
        Session("SortDirection") = "ASC"
        grdList.CurrentPageIndex = 0
        GridBind()
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub GridBind() 
        Try 
            Dim sQuery As String = "" 
            sQuery = "SELECT FACILITIES_CD,FACILITIES_NM, FACILITIES_MST.SHOP||':'||SHOP_NM SHOP,MAKER_NM" 
            sQuery += " FROM FACILITIES_MST,SHOP_MST WHERE FACILITIES_MST.SHOP = SHOP_MST.SHOP(+)" 
            sQuery += " AND FACILITIES_NM LIKE :K01" 
            _oDatabase.CreateParam("K01", "%" + txtName.Text.Trim() + "%") 
            If Not ddlShop.SelectedValue.Trim.Equals("") Then 
                sQuery += " AND FACILITIES_MST.SHOP = :K02" 
                _oDatabase.CreateParam("K02", ddlShop.SelectedValue.Trim()) 
            End If 
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
