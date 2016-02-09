Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdmas060 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS060" 
    Private Const PROGRAM_TITLE As String = "主材料マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " ページ " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
 
            If Not Page.IsPostBack Then 
                Dim sql As String 
                Dim oDataReader As OracleDataReader 
 
                '材種コンボの設定 
                sql = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS002' ORDER BY TELL_CD" 
                oDataReader = _oDatabase.CreateReader(sql) 
                ddlZCode.Items.Add(New ListItem("", "")) 
                Do While oDataReader.Read 
                    ddlZCode.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.GetString(0))) 
                Loop 
                oDataReader.Close() 
 
                '形状コンボの設定 
                sql = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS003' ORDER BY TELL_CD" 
                oDataReader = _oDatabase.CreateReader(sql) 
                ddlKCode.Items.Add(New ListItem("", "")) 
                Do While oDataReader.Read 
                    ddlKCode.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.GetString(0))) 
                Loop 
                oDataReader.Close() 
            End If 
 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
 
        Dim sKey1 As String = "" 
        Dim sKey2 As String = "" 
        Dim sKey3 As String = "" 
        Dim sPage As String = "0" 
        If Not Page.IsPostBack Then 
            If Request.QueryString("key1") Is Nothing And Request.QueryString("key2") Is Nothing And Request.QueryString("key3") Is Nothing Then 
                MedicalLib.Common.Sort = "MATL_CD,REN_NO" 
            End If 
            If Not Request.QueryString("key1") Is Nothing Then sKey1 = Request.QueryString("key1") 
            If Not Request.QueryString("key2") Is Nothing Then sKey2 = Request.QueryString("key2") 
            If Not Request.QueryString("key3") Is Nothing Then sKey3 = Request.QueryString("key3") 
            If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page") 
            txtSCode.Text = sKey1 
            ddlZCode.SelectedValue = sKey2 
            ddlKCode.SelectedValue = sKey3 
            grdList.CurrentPageIndex = sPage 
        End If 

        '**** 2012/12 ホスト廃止対応
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
            oLine.Attributes("onclick") = "selectGridRow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + HttpUtility.UrlEncode(oLine.Cells(1).Text) + "','" + HttpUtility.UrlEncode(txtSCode.Text.Trim()) + "','" + HttpUtility.UrlEncode(ddlZCode.SelectedValue.Trim()) + "','" + HttpUtility.UrlEncode(ddlKCode.SelectedValue.Trim()) + "'," & grdList.CurrentPageIndex & ")" 
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
        Session("SortExpression") = "MATL_CD,REN_NO"
        Session("SortDirection") = "ASC"
        grdList.CurrentPageIndex = 0
        GridBind()
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub GridBind() 
 
        Try 
            Dim sQuery As String = "" 
            sQuery = "SELECT MATL_CD,REN_NO,MATL_NM,MATL_SPEC," 
            sQuery += "DECODE(S.MATL_TYPE_CD,'','',(S.MATL_TYPE_CD||'：'||H1.ITEM_NM)) MATL_TYPE_CD," 
            sQuery += "DECODE(S.SHAPE_CD,'','',(S.SHAPE_CD||'：'||H2.ITEM_NM)) SHAPE_CD," 
            sQuery += "MATL_SPFT_NO," 
            sQuery += "DECODE(S.MAGNETISM,'','',(S.MAGNETISM||'：'||H3.ITEM_NM)) MAGNETISM," 
            sQuery += "STOCK_LV, LOW_ORDER_WAT, COEFFICIENT, " 
            sQuery += "DECODE(S.UNIT_KB,'','',(S.UNIT_KB||'：'||H4.ITEM_NM)) UNIT_KB," 
            sQuery += "UNIT_WAT, DELIVER_TERM, " 
            sQuery += "DECODE(S.PERSONAL_MATL,'','',(S.PERSONAL_MATL||'：'||H5.ITEM_NM)) PERSONAL_MATL," 
            sQuery += "DECODE(S.ORDER_CD1,'','',(S.ORDER_CD1||'：'||G.CONTRACTOUT_NM)) ORDER_CD1 " 
            sQuery += "FROM MATL_MST S,GENERAL_PURPOSE_TBL H1,GENERAL_PURPOSE_TBL H2,GENERAL_PURPOSE_TBL H3,GENERAL_PURPOSE_TBL H4,GENERAL_PURPOSE_TBL H5,CONTRACTOUT_MST G " 
            sQuery += "WHERE " 
            sQuery += "S.MATL_TYPE_CD = H1.TELL_CD(+) AND H1.INFO_KB(+) = 'MS002' AND " 
            sQuery += "S.SHAPE_CD = H2.TELL_CD(+) AND H2.INFO_KB(+) = 'MS003' AND " 
            sQuery += "S.MAGNETISM       = H3.TELL_CD(+) AND H3.INFO_KB(+) = 'MS017' AND " 
            sQuery += "S.UNIT_KB   = H4.TELL_CD(+) AND H4.INFO_KB(+) = 'MS004' AND " 
            sQuery += "S.PERSONAL_MATL = H5.TELL_CD(+) AND H5.INFO_KB(+) = 'MS024' AND " 
            sQuery += "S.ORDER_CD1 = G.CONTRACTOUT_CD(+) " 
 
            sQuery += "AND MATL_CD LIKE :K01" 
            _oDatabase.CreateParam("K01", txtSCode.Text.Trim() + "%") 
 
            If Not ddlZCode.SelectedValue.Trim.Equals("") Then 
                sQuery += " AND MATL_TYPE_CD = :K02" 
                _oDatabase.CreateParam("K02", ddlZCode.SelectedValue.Trim()) 
            End If 
 
            If Not ddlKCode.SelectedValue.Trim.Equals("") Then 
                sQuery += " AND SHAPE_CD = :K03" 
                _oDatabase.CreateParam("K03", ddlKCode.SelectedValue.Trim()) 
            End If 
            sQuery += " ORDER BY MATL_CD,REN_NO" 
 
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
