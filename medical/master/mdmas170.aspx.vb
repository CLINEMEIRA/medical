Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdmas170
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS170"
    Private Const PROGRAM_TITLE As String = "マスタ更新履歴参照・印刷"

    Private _oDatabase As MedicalLib.DataAccess
    Private _nCount As Integer = 0

#Region " ページ "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE

        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

        If Not Page.IsPostBack Then
            pnlInfo.Visible = False
            grdList.Visible = False
            lblCount.Visible = False
            btnPrint.Visible = False
            imgProgress.Visible = False
            grdList.PageSize = MedicalLib.Common.PageSize
            Session("SortExpression") = "CHANGE_DT,CHANGE_TIME,MASTER_NM,UPD_KEY,UPD_FIELD_NM"
        End If

        fraPrint.Attributes("src") = "../temp/dummy.html"
        _nCount = 0
        txtFrom.Focus()
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
        End If
    End Sub

    Protected Sub grdList_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList.ItemCreated
        If e.Item.ItemType = ListItemType.Pager Then
            If _nCount = 0 Then
                e.Item.Cells(0).HorizontalAlign = HorizontalAlign.Left
                _nCount += 1
            Else
                e.Item.Cells(0).HorizontalAlign = HorizontalAlign.Right
            End If
        End If
    End Sub

    Protected Sub grdList_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdList.PageIndexChanged
        Page.Validate("check")
        If Page.IsValid Then
            grdList.CurrentPageIndex = e.NewPageIndex
            GridBind()
        Else
            pnlInfo.Visible = True
            grdList.Visible = False
            lblCount.Visible = False
            btnPrint.Visible = False
            imgProgress.Visible = False
        End If
        udpKey.Update()
    End Sub

    Protected Sub grdList_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdList.SortCommand
        Page.Validate("check")
        If Page.IsValid Then
            MedicalLib.Common.SortCommand(e)
            GridBind()
        Else
            pnlInfo.Visible = True
            grdList.Visible = False
            lblCount.Visible = False
            btnPrint.Visible = False
            imgProgress.Visible = False
        End If
        udpKey.Update()
    End Sub

#End Region

#Region " ボタン "

    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        Page.Validate("check")
        If Page.IsValid Then
            pnlInfo.Visible = True
            grdList.Visible = True
            lblCount.Visible = True
            btnPrint.Visible = True
            ViewState("table") = ""
            If chkBuhin.Checked Then ViewState("table") += "a"
            If chkKakou.Checked Then ViewState("table") += "b"
            If chkKousei.Checked Then ViewState("table") += "c"
            If chkShuzai.Checked Then ViewState("table") += "d"
            If chkShop.Checked Then ViewState("table") += "e"
            If chkKoutei.Checked Then ViewState("table") += "f"
            If chkSetubi.Checked Then ViewState("table") += "g"
            If chkSagyo.Checked Then ViewState("table") += "h"
            If chkGaityu.Checked Then ViewState("table") += "i"
            If chkHanyou.Checked Then ViewState("table") += "j"
            ViewState("txtFrom") = txtFrom.Text.Trim()
            ViewState("txtTo") = txtTo.Text.Trim()
            Session("SortExpression") = "CHANGE_DT,CHANGE_TIME,MASTER_NM,UPD_KEY,UPD_FIELD_NM"
            Session("SortDirection") = "ASC"
            GridBind()
        Else
            pnlInfo.Visible = False
            grdList.Visible = False
            lblCount.Visible = False
            btnPrint.Visible = False
            imgProgress.Visible = False
        End If
    End Sub

    'テキスト出力
    Protected Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrint.Click
        imgProgress.Visible = True
        fraPrint.Attributes("src") = "../temp/dummy.html"
        fraPrint.Attributes("src") = "mdmas1701.aspx?table=" + HttpUtility.UrlEncode(ViewState("table")) +
                                                    "&from=" + HttpUtility.UrlEncode(ViewState("txtFrom")) +
                                                    "&to=" + HttpUtility.UrlEncode(ViewState("txtTo"))
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub GridBind()

        Try
            Dim sQuery As String = ""
            sQuery += "SELECT * FROM MASTER_HIS_TBL WHERE MASTER_NM IN ("
            If ViewState("table").ToString.IndexOf("a") > -1 Then sQuery += "'部品マスタ',"
            If ViewState("table").ToString.IndexOf("b") > -1 Then sQuery += "'加工工程マスタ',"
            If ViewState("table").ToString.IndexOf("c") > -1 Then sQuery += "'部品構成マスタ',"
            If ViewState("table").ToString.IndexOf("d") > -1 Then sQuery += "'主材料マスタ',"
            If ViewState("table").ToString.IndexOf("e") > -1 Then sQuery += "'SHOPマスタ',"
            If ViewState("table").ToString.IndexOf("f") > -1 Then sQuery += "'工程マスタ',"
            If ViewState("table").ToString.IndexOf("g") > -1 Then sQuery += "'設備マスタ',"
            If ViewState("table").ToString.IndexOf("h") > -1 Then sQuery += "'作業者マスタ',"
            If ViewState("table").ToString.IndexOf("i") > -1 Then sQuery += "'外注マスタ',"
            If ViewState("table").ToString.IndexOf("j") > -1 Then sQuery += "'汎用マスタ',"
            sQuery = sQuery.Substring(0, sQuery.Length - 1)
            sQuery += ") "

            If txtFrom.Text <> "" Then
                sQuery += "AND CHANGE_DT >= :K01 "
                _oDatabase.CreateParam("K01", txtFrom.Text.Trim())
            End If
            If txtTo.Text <> "" Then
                sQuery += "AND CHANGE_DT <= :K02 "
                _oDatabase.CreateParam("K02", txtTo.Text.Trim())
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
                grdList.Visible = False
                btnPrint.Visible = False
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

#Region " チェック関数 "

    Protected Sub checkFromTo(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valFromTo.ServerValidate
        If txtFrom.Text <> "" And txtTo.Text <> "" Then
            If valFrom.IsValid And valTo.IsValid Then
                If txtFrom.Text > txtTo.Text Then
                    args.IsValid = False
                End If
            End If
        End If
    End Sub

    Protected Sub valCheck_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCheck.ServerValidate
        If chkBuhin.Checked Then Exit Sub
        If chkKakou.Checked Then Exit Sub
        If chkKousei.Checked Then Exit Sub
        If chkShuzai.Checked Then Exit Sub
        If chkShop.Checked Then Exit Sub
        If chkKoutei.Checked Then Exit Sub
        If chkSetubi.Checked Then Exit Sub
        If chkSagyo.Checked Then Exit Sub
        If chkGaityu.Checked Then Exit Sub
        If chkHanyou.Checked Then Exit Sub
        args.IsValid = False
    End Sub

#End Region

End Class
