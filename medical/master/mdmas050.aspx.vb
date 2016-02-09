Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdmas050 
    Inherits System.Web.UI.Page 
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS050"
    Private Const PROGRAM_TITLE As String = "改訂履歴メンテナンス"
    Private _oDatabase As MedicalLib.DataAccess

    'CallBack 
    Public _sCallBackScript As String = ""
    Private _sCode As String = ""

#Region " プロパティ " 
 
    Public Property SelectedIndex() As Integer 
        Get 
            Dim obj As Object = ViewState("SelectedIndex") 
            If obj Is Nothing Then 
                Return 0 
            End If 
            Return CType(obj, Integer) 
        End Get 
 
        Set(ByVal Value As Integer) 
            ViewState("SelectedIndex") = Value 
        End Set 
    End Property 
 
#End Region 
 
#Region " ページ " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 

        'CallBack 
        _sCallBackScript = Page.ClientScript.GetCallbackEventReference( _ 
                     Me, "command", "getNameCallBack", "context", "getNameCallBackError", False) 
 
        If Not Page.IsPostBack Then 
            ViewState("mode1") = "i" 
            ViewState("mode2") = "catalog" 
            Session("SortDirection") = "ASC"
            'ViewState("saverow") = -1
        ElseIf Page.IsPostBack And txtPinkRow.Value <> "" And rbtnHenkou.Checked Then
            If txtPinkRow.Value <> -1 Then
                grdList1.Items(txtPinkRow.Value).BackColor = Color.FromArgb(255, 192, 192)
                If (txtMotoPinkRow.value Mod 2) = 1 Then
                    grdList1.Items(txtMotoPinkRow.value).BackColor = Color.FromArgb(217, 255, 204)
                Else
                    grdList1.Items(txtMotoPinkRow.value).BackColor = Color.FromArgb(255, 255, 255)
                End If
                txtMotoPinkRow.Value = txtPinkRow.Value
            End If
        End If
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
 
    Protected Sub grdList1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList1.ItemDataBound 
 
        If ViewState("mode1") <> "u" Then Exit Sub 
 
        Dim origItem As String = ColorTranslator.ToHtml(grdList1.ItemStyle.BackColor) 
        Dim origAltItem As String = ColorTranslator.ToHtml(grdList1.AlternatingItemStyle.BackColor) 
        Dim oLine As DataGridItem = e.Item
        Dim sColor As String = ""
 
        If oLine.ItemType = ListItemType.Item Or oLine.ItemType = ListItemType.AlternatingItem Then 
            oLine.Style("cursor") = "hand" 
            'oLine.Attributes("onmouseover") = "this.style.backgroundColor='Gold'"
            oLine.Attributes("onmouseover") = "changeColor(" & oLine.ItemIndex & ",'Gold');"
            If oLine.ItemType = ListItemType.Item Then 
                'oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origItem + "'"
                oLine.Attributes("onmouseout") = "changeColor(" & oLine.ItemIndex & ",'" + origItem + "');"
                sColor = origItem
            Else 
                'oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origAltItem + "'"
                oLine.Attributes("onmouseout") = "changeColor(" & oLine.ItemIndex & ",'" + origAltItem + "');"
                sColor = origAltItem
            End If 
            'Dim lbtn As LinkButton = CType(e.Item.FindControl("btnLink"), LinkButton)
            'oLine.Attributes("onClick") = ClientScript.GetPostBackClientHyperlink(lbtn, "")
            oLine.Attributes("onClick") = "selectGridRow1('" + oLine.Cells(0).Text + "','" + oLine.Cells(1).Text + "','" + oLine.Cells(3).Text + "','" + oLine.Cells(5).Text + "','" + oLine.Cells(6).Text + "','" + oLine.Cells(8).Text + "','" + oLine.Cells(9).Text + "');" + _
                                          "selectRow(" & oLine.ItemIndex & ",'" + sColor + "');"

            If oLine.ItemIndex = txtPinkRow.value Then
                oLine.BackColor = Color.FromArgb(255, 192, 192)
            End If

        End If 
 
    End Sub 
 
    'Protected Sub grdList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdList1.SelectedIndexChanged

    '    Me.SelectedIndex = grdList1.SelectedIndex
    '    grdList1.SelectedItem.Attributes.Item("onmouseover") = "this.style.cursor='hand'"
    '    grdList1.SelectedItem.Attributes.Remove("onmouseout")
    '    If ViewState("saverow") <> -1 Then
    '        Dim origItem As String = ColorTranslator.ToHtml(grdList1.ItemStyle.BackColor)
    '        Dim origAltItem As String = ColorTranslator.ToHtml(grdList1.AlternatingItemStyle.BackColor)
    '        grdList1.Items(ViewState("saverow")).Attributes.Item("onmouseover") = "this.style.backgroundColor='Gold'"
    '        If grdList1.Items(ViewState("saverow")).ItemType = ListItemType.Item Then
    '            grdList1.Items(ViewState("saverow")).Attributes("onmouseout") = "this.style.backgroundColor='" + origItem + "'"
    '        Else
    '            grdList1.Items(ViewState("saverow")).Attributes("onmouseout") = "this.style.backgroundColor='" + origAltItem + "'"
    '        End If
    '    End If
    '    saveRow1.Value = grdList1.SelectedIndex
    '    saveTeifu1.Value = grdList1.SelectedItem.Cells(0).Text
    '    txtTeifu1.Text = grdList1.SelectedItem.Cells(0).Text
    '    txtDay1.Text = grdList1.SelectedItem.Cells(1).Text
    '    txtTNo1.Text = grdList1.SelectedItem.Cells(3).Text
    '    txtSakusei1.Text = grdList1.SelectedItem.Cells(5).Text
    '    lbltxtSakusei1.Text = grdList1.SelectedItem.Cells(6).Text
    '    txtShounin1.Text = grdList1.SelectedItem.Cells(8).Text
    '    lbltxtShounin1.Text = grdList1.SelectedItem.Cells(9).Text
    '    ViewState("saverow") = grdList1.SelectedIndex
    'End Sub
 
#End Region 
 
#Region " コールバック " 
 
    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult 
        Dim sReturnValue As String 
        Dim sQuery As String = "SELECT WORKER_CD,WORKER_ABB FROM WORKER_MST WHERE WORKER_CD = :K01" 
        _oDatabase.CreateParam("K01", _sCode.Trim.PadLeft(4, "0")) 
        Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
        If oReader.Read() Then 
            sReturnValue = oReader.GetString(0).Trim() + "," + oReader.GetString(1).Trim() 
        Else 
            sReturnValue = _sCode + "," 
        End If 
        oReader.Close() 
        Return sReturnValue 
    End Function 
 
    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent 
        _sCode = eventArgument 
    End Sub

#End Region

#Region " ボタン "

    '検索ボタン 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click

        PanelInvisible()
        BottomClear()

        If ViewState("mode2").Equals("catalog") Then
            Page.Validate("top1")
        Else
            Page.Validate("top2")
        End If

        If Page.IsValid() Then
            If rbtnKoutei.Checked = True Then
                ViewState("shubetu") = "1"
                ViewState("catalog") = txtCatalog.Text.Trim()
            ElseIf rbtnHyoujun.Checked = True Then
                ViewState("shubetu") = "2"
                ViewState("catalog") = txtCatalog.Text.Trim()
            ElseIf rbtnKakouzu.Checked = True Then
                ViewState("shubetu") = "3"
                ViewState("seikan") = txtSeikan.Text.Trim()
            ElseIf rbtnZumen.Checked = True Then
                ViewState("shubetu") = "4"
                ViewState("seikan") = txtSeikan.Text.Trim()
            ElseIf rbtnSiken.Checked = True Then
                ViewState("shubetu") = "5"
                ViewState("seikan") = txtSeikan.Text.Trim()
            End If
            GridBind_Middle1()
        End If
    End Sub

    '戻るボタン 
    Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdBack1.Click
        PanelInvisible()
    End Sub

    '登録、削除 
    Protected Sub cmdRun1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdRun1.Click
        Dim sQuery As String = ""
        valDay13.Enabled = ViewState("mode1").Equals("i")
        Page.Validate("bottom1")
        If Page.IsValid() Then
            '登録 
            If ViewState("mode1").Trim.Equals("i") Then
                sQuery += "INSERT INTO REVISION_HIS_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," +
                                                               ":F11,:F12,:F13,:F14,:F15)"
                _oDatabase.CreateParam("F01", ViewState("shubetu").trim())
                If ViewState("mode2") = "catalog" Then
                    _oDatabase.CreateParam("F02", ViewState("catalog").trim())
                    _oDatabase.CreateParam("F03", "999999999999999")
                Else
                    _oDatabase.CreateParam("F02", "99999999999999999999")
                    _oDatabase.CreateParam("F03", ViewState("seikan").trim())
                End If
                _oDatabase.CreateParam("F04", txtTeifu1.Text.Trim())
                _oDatabase.CreateParam("F05", txtTNo1.Text.Trim())
                _oDatabase.CreateParam("F06", txtDay1.Text.Trim())
                _oDatabase.CreateParam("F07", txtSakusei1.Text.Trim())
                _oDatabase.CreateParam("F08", txtShounin1.Text.Trim())
                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F11", Session("UserID"))
                _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F13", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F14", Session("UserID"))
                _oDatabase.CreateParam("F15", MedicalLib.Common.ProgramID)

            ElseIf ViewState("mode1").Trim.Equals("u") Then
                sQuery += "UPDATE REVISION_HIS_TBL SET COR_MARK =:F01," +
                                                      "APPLY_DT = :F02," +
                                                      "COR_ARTICLE_NO = :F03," +
                                                      "CREATOR = :F04," +
                                                      "RECOGNIZER = :F05," +
                                                      "UPD_DT = :F06," +
                                                      "UPD_TIME = :F07," +
                                                      "UPD_USR = :F08," +
                                                      "UPD_PROGRAM_ID = :F09 "
                sQuery += "WHERE REVISION_TYPE = :K01 AND CATALOG_NO = :K02 AND PROSTD_NO = :K03 AND COR_MARK = :K04"

                _oDatabase.CreateParam("F01", txtTeifu1.Text.Trim())
                _oDatabase.CreateParam("F02", txtDay1.Text.Trim())
                _oDatabase.CreateParam("F03", txtTNo1.Text.Trim())
                _oDatabase.CreateParam("F04", txtSakusei1.Text.Trim())
                _oDatabase.CreateParam("F05", txtShounin1.Text.Trim())
                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F08", Session("UserID"))
                _oDatabase.CreateParam("F09", MedicalLib.Common.ProgramID)
                _oDatabase.CreateParam("K01", ViewState("shubetu").trim())
                If ViewState("mode2") = "catalog" Then
                    _oDatabase.CreateParam("K02", ViewState("catalog").trim())
                    _oDatabase.CreateParam("K03", "999999999999999")
                Else
                    _oDatabase.CreateParam("K02", "99999999999999999999")
                    _oDatabase.CreateParam("K03", ViewState("seikan").trim())
                End If
                _oDatabase.CreateParam("K04", saveTeifu1.Value)

            ElseIf ViewState("mode1").Trim.Equals("d") Then
                '削除 
                sQuery += "DELETE FROM  REVISION_HIS_TBL "
                If ViewState("mode2") = "catalog" Then
                    sQuery += "WHERE CATALOG_NO = :K01 "
                    _oDatabase.CreateParam("K01", ViewState("catalog"))
                Else
                    sQuery += "WHERE PROSTD_NO = :K01 "
                    _oDatabase.CreateParam("K01", ViewState("seikan"))
                End If
                sQuery += "AND REVISION_TYPE = :F02 "
                sQuery += "AND COR_MARK = :F03"
                _oDatabase.CreateParam("F02", ViewState("shubetu"))
                _oDatabase.CreateParam("F03", txtTeifu1.Text.Trim())
            End If

            Try
                _oDatabase.ExecuteNonQueryParam(sQuery)
            Catch ex As Exception
                MedicalLib.PageError.Show(ex.Message)
            End Try
            PanelInvisible()
        End If
    End Sub

    'クリアボタン１ 
    Protected Sub cmdClear1_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdClear1.Click
        BottomClear()
        GridBind_Middle1()
    End Sub

#End Region

#Region " ラジオボタン "

    '新規 
    Protected Sub rbtnSinki_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) 
        txtTeifu1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtDay1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtTNo1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtSakusei1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtShounin1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtPinkRow.Value = ""
        txtMotoPinkRow.Value = ""
 
        ViewState("mode1") = "i" 
        PanelInvisible() 
    End Sub 
 
    '削除 
    Protected Sub rbtnSakujo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) 
        txtTeifu1.BackColor = Color.FromArgb(224, 224, 224) '灰色 
        txtDay1.BackColor = Color.FromArgb(224, 224, 224) '灰色 
        txtTNo1.BackColor = Color.FromArgb(224, 224, 224) '灰色 
        txtSakusei1.BackColor = Color.FromArgb(224, 224, 224) '灰色 
        txtShounin1.BackColor = Color.FromArgb(224, 224, 224) '灰色 
        txtPinkRow.Value = ""
        txtMotoPinkRow.Value = ""

        ViewState("mode1") = "d" 
        PanelInvisible() 
    End Sub 
 
    '変更 
    Protected Sub rbtnHenkou_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) 
        txtTeifu1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtDay1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtTNo1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtSakusei1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtShounin1.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtPinkRow.Value = ""
        txtMotoPinkRow.Value = ""

        ViewState("mode1") = "u" 
        PanelInvisible() 
    End Sub 
 
    Protected Sub Catalog_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) 
 
        lblHedCatalog1.Visible = False 
        lblHedCatalog2.Visible = True
        lblHedSeikan1.Visible = True
        lblHedSeikan2.Visible = False
        txtPinkRow.Value = ""
        txtMotoPinkRow.Value = ""

        txtCatalog.Enabled = True 
        txtCatalog.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        txtSeikan.Enabled = False 
        txtSeikan.BackColor = Color.FromArgb(224, 224, 224) '灰色 
        ViewState("mode2") = "catalog" 
        PanelInvisible() 
    End Sub 
 
    Protected Sub Seikan_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) 
 
        lblHedCatalog1.Visible = True 
        lblHedCatalog2.Visible = False
        lblHedSeikan1.Visible = False
        lblHedSeikan2.Visible = True
        txtPinkRow.Value = ""
        txtMotoPinkRow.Value = ""

        txtCatalog.Enabled = False 
        txtCatalog.BackColor = Color.FromArgb(224, 224, 224) '灰色 
        txtSeikan.Enabled = True 
        txtSeikan.BackColor = Color.FromArgb(255, 255, 192) '黄色 
        ViewState("mode2") = "seikan" 
        PanelInvisible() 
    End Sub 
 
#End Region 
 
#Region " ユーザー関数 " 
 
    Private Sub GridBind_Middle1() 
 
        Session("SortExpression") = "APPLY_DT" 
 
        pnlMiddle1.Visible = True 
 
        Try 
            Dim sQuery As String = "" 
            sQuery += "SELECT COR_MARK,APPLY_DT,COR_ARTICLE_NO," 
            sQuery += "DECODE(K1.CREATOR,'','',(K1.CREATOR||'：'||S1.WORKER_NM)) CREATOR," 
            sQuery += "DECODE(K1.RECOGNIZER,'','',(K1.RECOGNIZER||'：'||S2.WORKER_NM)) RECOGNIZER," 
            sQuery += "K1.CREATOR CREATORコード,S1.WORKER_ABB CREATOR_NM," 
            sQuery += "K1.RECOGNIZER RECOGNIZERコード,S2.WORKER_ABB RECOGNIZER_NM "
            sQuery += "FROM REVISION_HIS_TBL K1,WORKER_MST S1,WORKER_MST S2 " 
            If ViewState("mode2") = "catalog" Then 
                sQuery += "WHERE K1.CATALOG_NO = :K01 " 
                _oDatabase.CreateParam("K01", ViewState("catalog")) 
            Else 
                sQuery += "WHERE K1.PROSTD_NO = :K01 " 
                _oDatabase.CreateParam("K01", ViewState("seikan")) 
            End If 
            sQuery += "AND K1.REVISION_TYPE = :K02 " 
            sQuery += "AND K1.CREATOR = S1.WORKER_CD(+) " 
            sQuery += "AND K1.RECOGNIZER = S2.WORKER_CD(+)" 
 
            _oDatabase.CreateParam("K02", ViewState("shubetu")) 
 
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1") 
 
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView 
            oDataView.Sort = MedicalLib.Common.Sort()
            If txtPinkRow.Value = "" And ViewState("mode1") = "u" Then
                txtPinkRow.Value = oDataView.Count - 1
                ViewState("MAX_ROW") = txtPinkRow.Value
                txtMotoPinkRow.Value = txtPinkRow.Value
            End If

            grdList1.DataSource = oDataView
            grdList1.DataBind()

            'If ViewState("mode1") = "u" And ViewState("MAX_ROW") > 0 Then
            '    'grdList1.SelectedIndex = ViewState("MAX_ROW")
            '    'grdList1.Items(ViewState("MAX_ROW")).Attributes("onmouseout") = "this.style.backgroundColor='#FFC0C0'"
            '    'ViewState("saverow") = ViewState("MAX_ROW")
            '    txtSelect.Value = ViewState("MAX_ROW")
            'End If

            If ViewState("mode1").Equals("d") Or ViewState("mode1").Equals("u") Then
                If oDataView.Count = 0 Then
                    lblZero.Visible = True
                    pnlMiddle1.Visible = False
                    pnlBottom1.Visible = False
                    Exit Sub
                End If
            End If

        Catch tex As Threading.ThreadAbortException
            Throw
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
 
        pnlBottom1.Visible = True 

        If ViewState("mode1").Equals("i") Then
            Gridbind_bottom1_i()
        Else
            Gridbind_bottom1_d_u()
        End If
    End Sub 


    Private Sub Gridbind_bottom1_i() 
 
        lblHedDay11.Visible = False 
        lblHedSakusei11.Visible = False 
        lblHedShounin11.Visible = False 
 
        valDay14.Enabled = False 
 
        cmdRun1.Attributes("src") = "../image/b_insert.gif" 
        cmdRun1.Attributes.Add("onclick", MedicalLib.Script.Insert()) 
        cmdRun1.Visible = MedicalLib.Common.EnableInsert 
        txtDay1.Text = MedicalLib.Common.GetSystemDate 
 
    End Sub 
 
    Private Sub Gridbind_bottom1_d_u() 
 
        cmdClear1.Visible = False 
 
        If ViewState("mode1") = "d" Then 
            lblHedDay12.Visible = False 
            lblHedSakusei12.Visible = False 
            lblHedShounin12.Visible = False 
 
            txtTeifu1.ReadOnly = True 
            txtDay1.ReadOnly = True 
            txtTNo1.ReadOnly = True 
            txtSakusei1.ReadOnly = True 
            txtShounin1.ReadOnly = True 

            valTeifu13.Enabled = False
            valDay14.Enabled = False 
 
            cmdRun1.Attributes("src") = "../image/b_delete.gif" 
            cmdRun1.Attributes.Add("onclick", MedicalLib.Script.Delete()) 
            cmdRun1.Visible = MedicalLib.Common.EnableDelete 
            txtDay1.Text = MedicalLib.Common.GetSystemDate 
        ElseIf ViewState("mode1") = "u" Then 
            lblHedDay11.Visible = False 
            lblHedSakusei11.Visible = False 
            lblHedShounin11.Visible = False 
 
            valDay14.Enabled = True 
 
            cmdRun1.Attributes("src") = "../image/b_update.gif" 
            cmdRun1.Attributes.Add("onclick", MedicalLib.Script.Update()) 
            cmdRun1.Visible = MedicalLib.Common.EnableUpdate 
        End If 
 
        Try 
            Dim sQuery As String = "" 
            sQuery += "SELECT COR_MARK,PROSTD_NO,APPLY_DT,COR_ARTICLE_NO,CREATOR,CREATOR_NM,RECOGNIZER,RECOGNIZER_NM " 
            sQuery += "FROM V_N_REVISION_HIS " 
            If ViewState("mode2") = "catalog" Then 
                sQuery += "WHERE CATALOG_NO = :K01 " 
                _oDatabase.CreateParam("K01", ViewState("catalog")) 
            Else 
                sQuery += "WHERE PROSTD_NO = :K01 " 
                _oDatabase.CreateParam("K01", ViewState("seikan")) 
            End If 
            sQuery += "AND REVISION_TYPE = :K02 " 
 
            _oDatabase.CreateParam("K02", ViewState("shubetu")) 
 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
 
            If oReader.Read() Then 
                txtTeifu1.Text = oReader.GetString(0).Trim() 
                saveTeifu1.Value = oReader.GetString(0).Trim() 
                'If Not oReader.IsDBNull(1) Then lblSNo.Text = oReader.GetString(1).Trim() 
                If Not oReader.IsDBNull(2) Then txtDay1.Text = oReader.GetString(2).Trim() 
                If Not oReader.IsDBNull(3) Then txtTNo1.Text = oReader.GetString(3).Trim() 
                If Not oReader.IsDBNull(4) Then txtSakusei1.Text = oReader.GetString(4).Trim() 
                If Not oReader.IsDBNull(5) Then lbltxtSakusei1.Text = oReader.GetString(5).Trim() 
                If Not oReader.IsDBNull(6) Then txtShounin1.Text = oReader.GetString(6).Trim() 
                If Not oReader.IsDBNull(7) Then lbltxtShounin1.Text = oReader.GetString(7).Trim() 
            End If 
            oReader.Close() 
 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
    'パネル消去 
    Private Sub PanelInvisible() 
        lblZero.Visible = False 
        pnlMiddle1.Visible = False 
        pnlBottom1.Visible = False
        txtPinkRow.Value = ""
        txtMotoPinkRow.Value = ""
    End Sub 
 
    '下段プロパティクリアー 
    Private Sub BottomClear() 
 
        lblHedDay11.Visible = True 
        lblHedSakusei11.Visible = True 
        lblHedShounin11.Visible = True 
        lblHedDay12.Visible = True 
        lblHedSakusei12.Visible = True 
        lblHedShounin12.Visible = True 
 
        txtTeifu1.Text = "" 
        txtTeifu1.ReadOnly = False 
        valTeifu13.Enabled = True 
        'lblSNo.Text = "" 
        txtDay1.Text = "" 
        txtDay1.ReadOnly = False 
        txtTNo1.Text = "" 
        txtTNo1.ReadOnly = False 
        txtSakusei1.Text = "" 
        txtSakusei1.ReadOnly = False 
        lbltxtSakusei1.Text = "" 
        txtShounin1.Text = "" 
        txtShounin1.ReadOnly = False 
        lbltxtShounin1.Text = "" 
        txtPinkRow.Value = ""
        txtMotoPinkRow.Value = ""
    End Sub 
 
    '作業標準管理NO 取得 
    Private Function getSeihinkanri(ByVal catalog As String) As String 
        Dim temp As String = "" 
        Try 
            Dim sQuery As String = "" 
            sQuery += "SELECT WORK_STD_NO FROM PARTS_MST WHERE CATALOG_NO = :K01" 
            _oDatabase.CreateParam("K01", catalog) 
 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
 
            If oReader.Read() Then 
                temp = oReader.GetString(0).Trim() 
            End If 
 
            oReader.Close() 
 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        Return temp 
    End Function

#End Region

#Region " チェック関数 "

    'カタログ番号存在チェック 
    Friend Sub CheckCatalog(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valCatalog2.ServerValidate
        Try
            Dim sQuery As String = "SELECT * FROM PARTS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", txtCatalog.Text.Trim())

            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '製品管理番号存在チェック 
    Friend Sub CheckSeikan(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valSeikan3.ServerValidate
        If valSeikan2.IsValid = False Then Exit Sub
        Try
            Dim sQuery As String = "SELECT CATALOG_NO FROM PARTS_MST WHERE WORK_STD_NO = :K01"
            _oDatabase.CreateParam("K01", txtSeikan.Text.Trim())
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '訂符存在チェック1 
    Friend Sub CheckTeifu1(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valTeifu13.ServerValidate
        Try
            If txtTeifu1.Text = saveTeifu1.Value And ViewState("mode1") <> "i" Then
                Exit Sub
            End If

            Dim sQuery As String = "SELECT COR_MARK FROM REVISION_HIS_TBL "
            If ViewState("mode2") = "catalog" Then
                sQuery += "WHERE CATALOG_NO = :K01 "
                sQuery += "AND PROSTD_NO = '999999999999999' "
                _oDatabase.CreateParam("K01", ViewState("catalog"))
            Else
                sQuery += "WHERE PROSTD_NO = :K01 "
                sQuery += "AND CATALOG_NO = '99999999999999999999' "
                _oDatabase.CreateParam("K01", ViewState("seikan"))
            End If
            sQuery += "AND REVISION_TYPE = :K02 "
            sQuery += "AND COR_MARK = :K03 "

            _oDatabase.CreateParam("K02", ViewState("shubetu"))
            _oDatabase.CreateParam("K03", txtTeifu1.Text)

            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)

            e.IsValid = Not oReader.HasRows

            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '適用日付チェック１ 
    Friend Sub CheckDay1(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDay13.ServerValidate
        Try
            Dim sQuery As String = "SELECT APPLY_DT FROM V_N_REVISION_HIS "
            If ViewState("mode2") = "catalog" Then
                sQuery += "WHERE CATALOG_NO = :K01 "
                sQuery += "AND PROSTD_NO = '999999999999999' "
                _oDatabase.CreateParam("K01", ViewState("catalog"))
            Else
                sQuery += "WHERE PROSTD_NO = :K01 "
                sQuery += "AND CATALOG_NO = '99999999999999999999' "
                _oDatabase.CreateParam("K01", ViewState("seikan"))
            End If
            sQuery += "AND REVISION_TYPE = :K02 "

            _oDatabase.CreateParam("K02", ViewState("shubetu"))

            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)

            If oReader.Read() Then
                If txtDay1.Text > oReader.GetString(0) Then
                    e.IsValid = True
                Else
                    e.IsValid = False
                End If
            Else
                Exit Sub
            End If

            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '作業者マスタ 存在チェック 
    Friend Sub CheckSaGyo(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valSakusei1.ServerValidate

        Dim val As CustomValidator = CType(sender, CustomValidator)
        Dim labelID As String = "lbl" + val.ControlToValidate

        CType(Me.FindControl(labelID), Label).Text = ""

        '必須 
        If e.Value = "" Then
            val.ErrorMessage = "必須入力項目です"
            e.IsValid = False
            Exit Sub
        End If

        Try
            Dim sQuery As String = "SELECT WORKER_ABB FROM WORKER_MST WHERE WORKER_CD = :K01"
            _oDatabase.CreateParam("K01", e.Value)
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                e.IsValid = True
                CType(Me.FindControl(labelID), Label).Text = oReader.GetString(0).Trim()
            Else
                val.ErrorMessage = "作業者マスタに存在しません"
                e.IsValid = False
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    Protected Sub CheckDay1_u(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valDay14.ServerValidate
        Dim mae As String = "00000000"
        Dim ato As String = "99999999"

        If txtPinkRow.Value <> "0" Then
            mae = grdList1.Items(txtPinkRow.Value - 1).Cells(1).Text
        End If
        If txtPinkRow.Value <> ViewState("MAX_ROW") Then
            ato = grdList1.Items(txtPinkRow.Value + 1).Cells(1).Text
        End If

        If args.Value <= mae Or args.Value >= ato Then
            args.IsValid = False
        End If
    End Sub

#End Region

End Class 
