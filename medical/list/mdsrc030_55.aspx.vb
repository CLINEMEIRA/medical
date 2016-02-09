Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdsrc030_55
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDSRC030"
    Private Const PROGRAM_TITLE As String = "作業者コード検索"

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                '**** 2008/04/16 START ****
                'txtShop.Text = "88"
                'txtShop.Text = "39"
                SetShopDDL()
                '**** 2008/04/16 END ******
                txtCode.Text = Request.QueryString("sagyou").Trim()
                MedicalLib.Common.ListSort = "WORKER_CD"
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

    Protected Sub btnSearch_Click(sender As Object, e As ImageClickEventArgs) Handles btnSearch.Click
        DisplayList()
    End Sub

#End Region

#Region " 画面関連 "

    Private Sub SetShopDDL()

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Dim sSelectIndex As String = 0

        Try
            sQuery = ""
            sQuery += "SELECT GP.TELL_CD||':'||SM.SHOP_NM NAME, GP.TELL_CD "
            sQuery += "  FROM (SELECT TELL_CD, ITEM_KN"
            sQuery += "          FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS031') GP,"
            sQuery += "       SHOP_MST SM"
            sQuery += " WHERE GP.TELL_CD = SM.SHOP(+)"
            sQuery += " ORDER BY GP.ITEM_KN"

            oReader = _oDatabase.CreateReader(sQuery)

            ddlShop.Items.Add(New ListItem("", ""))
            While oReader.Read
                ddlShop.Items.Add(New ListItem(oReader.GetString(0), oReader.GetString(1)))
            End While

            ddlShop.SelectedIndex = 1
        Catch ex As Exception
            Throw
        Finally
            oReader.Close()
        End Try

    End Sub

    Private Sub DisplayList()
        Dim sQuery As String = ""
        Try
            sQuery = "SELECT WORKER_CD,WORKER_NM,WORKER_ABB,SHOP "
            sQuery += "FROM WORKER_MST "
            sQuery += "WHERE SHOP LIKE :K10 AND SUBSTR(WORKER_CD,1,:K20) >= :K21 "
            sQuery += "ORDER BY WORKER_CD"
            '_oDatabase.CreateParam("K10", txtShop.Text.Trim() + "%")
            _oDatabase.CreateParam("K10", ddlShop.SelectedValue.ToString + "%")
            _oDatabase.CreateParam("K20", GetKeyLength(txtCode.Text))
            _oDatabase.CreateParam("K21", GetKey(txtCode.Text))
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
