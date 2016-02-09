Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing

Partial Class master_mdmas1501
    Inherits System.Web.UI.Page
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS150"
    Private Const PROGRAM_TITLE As String = "加工工程マスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "P_PROCESS_MST"
    Private Const TABLE_NAME_JP As String = "加工工程マスタ"

    Public _sCallBackScript As String = ""
    Private _sGetValue As String = ""

    Private Const TABLE_SHOP As String = "T1"

    Private Enum COL
        SHOP_NM = 0
        DAIHYO = 1
        SHOP_CD = 2
    End Enum

#Region " イベント "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        _sCallBackScript = Page.ClientScript.GetCallbackEventReference(Me, "command", "getInfoCallBack", "context", "getInfoCallBackError", False)
        If Not Page.IsPostBack Then
            ComboSet(cboShop)
            ViewState("mode") = Request.QueryString("mode")
            ViewState("call") = Request.QueryString("call")
            ViewState("catalog") = Request.QueryString("catalog")
            ViewState("key1") = Request.QueryString("key1")
            ViewState("key2") = Request.QueryString("key2")

            CreateDataSet(ViewState("catalog"), ViewState("key1"), ViewState("key2"))

            If ViewState("mode").Equals("i") Then
                DisplayShow1(ViewState("catalog"))
                imgProcessTitle.ImageUrl = "../image/t_insert.gif"
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Insert())
                cmdRun.Attributes("src") = "../image/b_insert.gif"
                cmdRun.Visible = MedicalLib.Common.EnableInsert
            Else
                DisplayShow2(ViewState("catalog"), ViewState("key1"), ViewState("key2"))
                imgProcessTitle.ImageUrl = "../image/t_update.gif"
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Update())
                cmdRun.Attributes("src") = "../image/b_update.gif"
                cmdRun.Visible = MedicalLib.Common.EnableUpdate
            End If
            cmdDel.Visible = Not ViewState("mode").Trim.Equals("i") And MedicalLib.Common.EnableDelete
            cmdDel.Attributes.Add("onclick", MedicalLib.Script.Delete())
            txtTeifu.Focus()

        Else
            If Me.hidDel.Value = "1" Then
                DelDataSetRow()
            End If
        End If
        CheckPlan_chen() '20120315追加
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    '工程コード変更時処理
    Protected Sub btnKoutei_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKoutei.Click

        Try
            Dim sQuery As String = ""
            sQuery = ""
            sQuery += "SELECT A.P_ORDER_NM, A.SHOP, A.FACILITIES_G_CD, B.ITEM_NM, A.WORK_STD"
            sQuery += "     , SM.SHOP_NM"
            sQuery += "  FROM PROCESS_MST A"
            sQuery += "     , (SELECT TELL_CD, ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025') B"
            sQuery += "     , SHOP_MST SM"
            sQuery += " WHERE A.FACILITIES_G_CD = B.TELL_CD(+)"
            sQuery += "   AND A.PROCESS_CD = :K01"
            sQuery += "   AND A.SHOP = SM.SHOP(+)"
            _oDatabase.CreateParam("K01", Me.txtKoutei.Text)
            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)

                If oReader.Read() Then
                    Me.lblKoutei.Text = GetString(oReader, 0)           '工程名称
                    Me.lblSetubiCode.Text = GetString(oReader, 2)       '設備
                    Me.lblSetubiName.Text = GetString(oReader, 3)       '設備名
                    Me.lblSagyou.Text = GetString(oReader, 4)           '作業基準

                    If Not oReader.IsDBNull(5) Then

                        'SHOP名称が取れたらSHOPを選択させる
                        Dim oDataSet As DataSet = ViewState("DataSet")
                        Dim oTable As DataTable = oDataSet.Tables(TABLE_SHOP)
                        Dim IsRow As Boolean = False

                        For Each oRow As DataRow In oTable.Rows
                            If oRow(COL.SHOP_CD) = GetString(oReader, 1) Then
                                IsRow = True
                                Exit For
                            End If
                        Next

                        Me.cboShop.SelectedValue = GetString(oReader, 1)    'SHOP
                        Me.chkDaihyo.Checked = True                         '代表
                        If IsRow = True Then
                            Me.cboShori.SelectedValue = "U"                 '訂正
                        Else
                            Me.cboShori.SelectedValue = "A"                 '追加
                        End If
                        Me.udpShop.Update()

                        ''SHOP名称が取れたらデータセットにセット
                        'Dim oDataSet As DataSet = ViewState("DataSet")
                        'Dim oTable As DataTable = oDataSet.Tables(TABLE_SHOP)

                        'Dim oRow As DataRow = oTable.NewRow
                        'oRow(COL.SHOP_NM) = GetString(oReader, 1) & ":" & GetString(oReader, 5)       'SHOP名称
                        'oRow(COL.DAIHYO) = "1"
                        'oRow(COL.SHOP_CD) = GetString(oReader, 1)       'SHOP_CD
                        'oTable.Rows.Add(oRow)
                    End If
                Else
                    Me.lblKoutei.Text = ""
                    Me.lblSetubiCode.Text = ""
                    Me.lblSetubiName.Text = ""
                    Me.lblSagyou.Text = ""
                End If
            End Using

        Catch ex As Exception
        End Try
    End Sub

    '登録＆修正ボタン押下処理 
    Protected Sub cmdRun_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdRun.Click
        Try
            Page.Validate("info")
            If Page.IsValid Then

                _oDatabase.BeginTrans()

                If ViewState("mode").Equals("i") Then
                    FileInsert()
                Else
                    Page.Validate("update")
                    If Not Page.IsValid Then Exit Sub
                    FileUpdate()
                End If
                GoBack()
                _oDatabase.CommitTrans()
            End If
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '削除ボタン押下処理 
    Protected Sub cmdDel_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdDel.Click
        Page.Validate("update")
        If Not Page.IsValid Then Exit Sub
        FileDelete()
        GoBack()
    End Sub

    '戻るボタン押下処理 
    Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdBack.Click
        GoBack()
    End Sub

    'リセットボタン押下処理 
    Protected Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdClear.Click

        DisplayClearShop()

        If ViewState("mode").Equals("i") Then
            CreateDataSet(ViewState("catalog"), "", "")
            DisplayShow1(ViewState("catalog"))
        Else
            CreateDataSet(ViewState("catalog"), ViewState("key1"), ViewState("key2"))
            DisplayShow2(ViewState("catalog"), ViewState("key1"), ViewState("key2"))
        End If
        CheckPlan_chen() '20120315追加

    End Sub

    'SHOP実行       '2010/08 追加
    Protected Sub btnRun_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnRun.Click

        Page.Validate("shop")
        If Not Page.IsValid Then Exit Sub
        Try
            Dim oDataSet As DataSet = ViewState("DataSet")
            Dim oTable As DataTable = oDataSet.Tables(TABLE_SHOP)

            '代表区分がチェックされている時
            If Me.chkDaihyo.Checked = True Then
                '他のSHOPの代表区分をはずす
                For Each oRow As DataRow In oTable.Rows
                    oRow(COL.DAIHYO) = ""        '代表区分
                Next
            End If

            Select Case Me.cboShori.SelectedValue
                Case "A"    '追加
                    Dim oRow As DataRow = oTable.NewRow
                    oRow(COL.SHOP_NM) = Me.cboShop.SelectedItem       'SHOP
                    If Me.chkDaihyo.Checked = True Then     '代表区分
                        oRow(COL.DAIHYO) = "1"
                    Else
                        oRow(COL.DAIHYO) = "0"
                    End If
                    oRow(COL.SHOP_CD) = Me.cboShop.SelectedValue      'SHOP_CD

                    oTable.Rows.Add(oRow)

                Case "U"    '訂正
                    For Each oRow As DataRow In oTable.Rows

                        If oRow(COL.SHOP_CD).ToString = Me.cboShop.SelectedValue Then
                            oRow(COL.SHOP_NM) = Me.cboShop.SelectedItem       'SHOP
                            If Me.chkDaihyo.Checked = True Then     '代表区分
                                oRow(COL.DAIHYO) = "1"
                            Else
                                oRow(COL.DAIHYO) = "0"
                            End If
                            oRow(COL.SHOP_CD) = Me.cboShop.SelectedValue      'SHOP_CD
                        End If
                    Next

                Case "D"        '削除
                    For i As Integer = 0 To oTable.Rows.Count - 1
                        If oTable.Rows(i).Item(COL.SHOP_CD) = Me.cboShop.SelectedValue Then
                            oTable.Rows.RemoveAt(i)
                            Exit For
                        End If
                    Next
            End Select

            BindShop()              'SHOP表示
            SetKoutei()             '工程項目セット
            Me.udpInfo.Update()
            DisplayClearShop()      'SHOP編集クリア

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    Protected Sub grdShop_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdShop.ItemDataBound

        Dim origItem As String = ColorTranslator.ToHtml(grdShop.ItemStyle.BackColor)
        Dim origAltItem As String = ColorTranslator.ToHtml(grdShop.AlternatingItemStyle.BackColor)
        Dim oLine As DataGridItem = e.Item
        If oLine.ItemType = ListItemType.Item Or oLine.ItemType = ListItemType.AlternatingItem Then
            oLine.Style("cursor") = "hand"
            oLine.Attributes("onmouseover") = "this.style.backgroundColor='Gold'"
            If oLine.ItemType = ListItemType.Item Then
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origItem + "'"
            Else
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origAltItem + "'"
            End If

            If oLine.Cells.Item(COL.DAIHYO).Text = "1" Then
                oLine.Cells.Item(COL.DAIHYO).Text = "○"
            Else
                oLine.Cells.Item(COL.DAIHYO).Text = " "
            End If
            oLine.Attributes("onclick") = "selectGridRow('" & oLine.Cells.Item(COL.SHOP_CD).Text & _
                                                      "','" & oLine.Cells.Item(COL.DAIHYO).Text & "')"
        End If
    End Sub

#End Region

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        Dim sReturnValue As String = ""
        Dim sValues() As String = _sGetValue.Split(Chr(9))
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Select Case sValues(0)
            Case 1
                sQuery = ""
                sQuery += "SELECT A.P_ORDER_NM, A.SHOP, A.FACILITIES_G_CD, B.ITEM_NM, A.WORK_STD"
                sQuery += "  FROM PROCESS_MST A"
                sQuery += "     , (SELECT TELL_CD, ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025') B"
                sQuery += " WHERE A.FACILITIES_G_CD = B.TELL_CD(+)"
                sQuery += "   AND A.PROCESS_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim.PadLeft(5, "0"))
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    sReturnValue = sValues(1).Trim.PadLeft(5, "0") + Chr(9) + _
                                   GetString(oReader, 0) + Chr(9) + _
                                   GetString(oReader, 1) + Chr(9) + _
                                   GetString(oReader, 2) + Chr(9) + _
                                   GetString(oReader, 3) + Chr(9) + _
                                   GetString(oReader, 4) + Chr(9)
                Else
                    sReturnValue = sValues(1) + Chr(9) + "" + Chr(9) + "" + Chr(9) + "" + Chr(9) + "" + Chr(9) + "" + Chr(9)
                End If
                
            Case 2
                sQuery = "SELECT P_ORDER_NM FROM PROCESS_MST WHERE PROCESS_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim.PadLeft(5, "0"))
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    sReturnValue = sValues(1).Trim.PadLeft(5, "0") + Chr(9) + _
                                   GetString(oReader, 0) + Chr(9)
                Else
                    sReturnValue = sValues(1) + Chr(9) + "" + Chr(9)
                End If
        End Select
        oReader.Close()
        Return sReturnValue
    End Function

    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        _sGetValue = eventArgument
    End Sub

#End Region

#Region " 画面関連 "

    '画面表示(新規) 
    Private Sub DisplayShow1(ByVal sCatalog As String)
        Dim sQuery As String = "SELECT NVL(MAX(P_ORDER_MAIN),0) + 10 FROM P_PROCESS_MST WHERE CATALOG_NO = :K01"
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", sCatalog)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            oReader.Read()
            txtTeifu.Text = ""
            txtKihon.Text = oReader.GetInt32(0)
            txtHojo.Text = "0"
            txtKoutei.Text = ""
            lblKoutei.Text = ""
            txtOya.Text = ""
            lblOya.Text = ""
            cboShop.SelectedIndex = -1
            lblSetubiCode.Text = ""
            lblSetubiName.Text = ""
            lblSagyou.Text = ""
            txtComment.Text = ""
            txtCycleTime.Text = ""  '2010/03/16
            txtTactTime.Text = ""   '2010/03/16
            txtPutTogether.Text = "" '20120302追加
            CheckPlan.Checked = False '20120302追加
            ViewState("koujun") = ""

            oReader.Close()

            BindShop()

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '画面表示(訂正) 
    Private Sub DisplayShow2(ByVal sCatalog As String, ByVal sKihon As String, ByVal sHojo As String)
        Dim sQuery As String = "SELECT A.UM_P_ORDER,A.P_ORDER_MAIN,A.P_ORDER_SUB,A.PROCESS_CD,B.P_ORDER_NM,A.PER_PROCESS_CD,D.P_ORDER_NM,A.SHOP,B.FACILITIES_G_CD,C.ITEM_NM,B.WORK_STD,A.P_COMMENT,A.UPD_DT,A.UPD_TIME,A.CYCLE_TIME,A.TACT_TIME,A.PUT_TOGETHER_FLG,A.PLAN_TARGET_FLG " + _
                               "FROM P_PROCESS_MST A,PROCESS_MST B,(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025') C,PROCESS_MST D " + _
                               "WHERE A.PROCESS_CD = B.PROCESS_CD(+) AND A.PER_PROCESS_CD = D.PROCESS_CD(+) AND B.FACILITIES_G_CD = C.TELL_CD(+) AND A.CATALOG_NO = :K01 AND A.P_ORDER_MAIN = :K02 AND A.P_ORDER_SUB = :K03"
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", sCatalog)
            _oDatabase.CreateParam("K02", sKihon)
            _oDatabase.CreateParam("K03", sHojo)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                txtTeifu.Text = GetString(oReader, 0)
                txtKihon.Text = GetInt32(oReader, 1)
                txtHojo.Text = GetInt32(oReader, 2)
                txtKoutei.Text = GetString(oReader, 3)
                lblKoutei.Text = GetString(oReader, 4)
                txtOya.Text = GetString(oReader, 5)
                lblOya.Text = GetString(oReader, 6)
                'cboShop.SelectedValue = GetString(oReader, 7)
                lblSetubiCode.Text = GetString(oReader, 8)
                lblSetubiName.Text = GetString(oReader, 9)
                lblSagyou.Text = GetString(oReader, 10)
                txtComment.Text = GetString(oReader, 11)
                txtCycleTime.Text = GetInt32(oReader, 14)  '2010/03/16
                txtTactTime.Text = GetInt32(oReader, 15)   '2010/03/16
                txtPutTogether.Text = GetString(oReader, 16) '20120302 追加
                If GetString(oReader, 17) = "1" Then '20120302 追加
                    CheckPlan.Checked = True
                Else
                    CheckPlan.Checked = False
                End If
                ViewState("kihon") = oReader.GetInt32(1)
                ViewState("hojo") = oReader.GetInt32(2)
                ViewState("update") = oReader.GetString(12).Trim() + oReader.GetString(13).Trim()
            End If
            oReader.Close()

            BindShop()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    'SHOP表示           '2010/08 追加
    Private Sub BindShop()

        Dim oDataSet As DataSet = ViewState("DataSet")
        Dim oDataView As DataView = oDataSet.Tables(TABLE_SHOP).DefaultView
        oDataView.Sort = "SHOP"

        Select Case oDataView.Count
            Case 0
                Me.pnlShop.Height = 0
            Case 1 To 6
                Me.pnlShop.Height = Me.grdShop.CellSpacing _
                                  + (Me.grdShop.CellPadding + _
                                     Me.grdShop.Columns(0).ItemStyle.Height.Value + _
                                     Me.grdShop.CellPadding + _
                                     Me.grdShop.CellSpacing _
                                    ) * oDataView.Count
            Case Else       '7以上 
                Me.pnlShop.Height = Me.grdShop.CellSpacing _
                                  + (Me.grdShop.CellPadding + _
                                     Me.grdShop.Columns(0).ItemStyle.Height.Value + _
                                     Me.grdShop.CellPadding + _
                                     Me.grdShop.CellSpacing _
                                    ) * 6
        End Select

        grdShop.DataSource = oDataView
        grdShop.DataBind()
    End Sub

    'SHOP編集クリア     '2010/08 追加
    Private Sub DisplayClearShop()
        Me.cboShop.SelectedIndex = 0
        Me.chkDaihyo.Checked = False
        Me.cboShori.SelectedIndex = 0
        Me.udpShop.Update()
    End Sub

    '工程セット     '2010/08 追加
    Private Sub SetKoutei()
        Dim sQuery As String = ""
        sQuery += "SELECT A.P_ORDER_NM, A.WORK_STD, A.FACILITIES_G_CD, B.ITEM_NM"
        sQuery += "  FROM PROCESS_MST A"
        sQuery += "     , (SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025') B"
        sQuery += " WHERE A.FACILITIES_G_CD = B.TELL_CD(+) AND A.PROCESS_CD = :K01"
        _oDatabase.CreateParam("K01", Me.txtKoutei.Text.Trim.PadLeft(5, "0"))
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                lblKoutei.Text = GetString(oReader, 0)
                lblSagyou.Text = GetString(oReader, 1)
                lblSetubiCode.Text = GetString(oReader, 2)
                lblSetubiName.Text = GetString(oReader, 3)
            Else
                lblKoutei.Text = ""
                lblSagyou.Text = ""
                lblSetubiCode.Text = ""
                lblSetubiName.Text = ""
            End If
        End Using

        '親工程分
        sQuery = ""
        sQuery += "SELECT P_ORDER_NM"
        sQuery += "  FROM PROCESS_MST"
        sQuery += " WHERE PROCESS_CD = :K01"
        _oDatabase.CreateParam("K01", Me.txtOya.Text.Trim.PadLeft(5, "0"))
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                lblOya.Text = GetString(oReader, 0).Trim
            Else
                lblOya.Text = ""
            End If
        End Using
    End Sub

#End Region

#Region " チェック関連 "

    '工程コード 
    Protected Sub valKoutei2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT A.P_ORDER_NM,A.WORK_STD,A.FACILITIES_G_CD,B.ITEM_NM FROM PROCESS_MST A,(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025') B WHERE A.FACILITIES_G_CD = B.TELL_CD(+) AND A.PROCESS_CD = :K01"
            _oDatabase.CreateParam("K01", args.Value.Trim.PadLeft(5, "0"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                txtKoutei.Text = args.Value.Trim.PadLeft(5, "0")
                lblKoutei.Text = GetString(oReader, 0)
                lblSagyou.Text = GetString(oReader, 1)
                lblSetubiCode.Text = GetString(oReader, 2)
                lblSetubiName.Text = GetString(oReader, 3)
                args.IsValid = True
            Else
                lblKoutei.Text = ""
                lblSagyou.Text = ""
                lblSetubiCode.Text = ""
                lblSetubiName.Text = ""
                args.IsValid = False
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '親工程 工程マスタチェック
    Protected Sub valOya_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        lblOya.Text = ""
        If txtOya.Text = "" Then Exit Sub
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT P_ORDER_NM,FAMILY_KB FROM PROCESS_MST WHERE PROCESS_CD = :K01 "
            _oDatabase.CreateParam("K01", txtOya.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                lblOya.Text = GetString(oReader, 0)
                If Not GetString(oReader, 1).Equals("0") Then
                    CType(source, CustomValidator).ErrorMessage = "親の工程コードを入力して下さい"
                    args.IsValid = False
                End If
            Else
                CType(source, CustomValidator).ErrorMessage = "工程マスタに未登録です"
                args.IsValid = False
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    'SHOP チェック      2010/08追加
    Protected Sub valShop_ServerValidate1(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valShop.ServerValidate

        Dim oVal As CustomValidator = DirectCast(source, CustomValidator)
        Dim oDataSet As DataSet = ViewState("DataSet")
        Dim oTable As DataTable = oDataSet.Tables(TABLE_SHOP)

        'SHOP 存在チェック
        If oTable.Rows.Count = 0 Then
            oVal.ErrorMessage = "SHOPを登録してください"
            args.IsValid = False
            Exit Sub
        End If

        '代表区分チェック
        args.IsValid = False
        For Each oRow As DataRow In oTable.Rows
            If oRow(COL.DAIHYO).ToString = "1" Then
                args.IsValid = True
                Exit For
            End If
        Next
        If args.IsValid = False Then
            oVal.ErrorMessage = "どれかひとつのSHOPを代表にしてください"
            Exit Sub
        End If
    End Sub

    'SHOP 
    Protected Sub valShop2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT SHOP FROM SHOP_MST WHERE SHOP = :K01"
            _oDatabase.CreateParam("K01", args.Value)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    'コメント 
    Protected Sub valComment1_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        args.IsValid = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(args.Value.Trim()) <= 50
    End Sub

    '基本工順+補助工順 
    Protected Sub valKoujun_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)

        If ViewState("mode").Equals("u") Then
            If ViewState("kihon").ToString = txtKihon.Text.Trim() And ViewState("hojo").ToString = txtHojo.Text.Trim() Then Return
        End If
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT CATALOG_NO FROM P_PROCESS_MST WHERE CATALOG_NO = :K01 AND P_ORDER_MAIN = :K02 AND P_ORDER_SUB = :K03"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.CreateParam("K02", txtKihon.Text.Trim())
            _oDatabase.CreateParam("K03", txtHojo.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = Not oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM P_PROCESS_MST WHERE CATALOG_NO = :K01 AND P_ORDER_MAIN = :K02 AND P_ORDER_SUB = :K03"
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.CreateParam("K02", ViewState("key1"))
            _oDatabase.CreateParam("K03", ViewState("key2"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                CType(sender, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_UPDATE
                e.IsValid = ViewState("update") = oReader.GetString(0).Trim()
            Else
                CType(sender, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_DELETE
                e.IsValid = False
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    'SHOP編集チェック       '2010/08 追加
    Protected Sub valShop_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valShopEdit.ServerValidate

        Dim oVal As CustomValidator = DirectCast(source, CustomValidator)

        'SHOP入力チェック
        If Me.cboShop.SelectedValue = "" Then
            oVal.ErrorMessage = "SHOPを選択して下さい"
            args.IsValid = False
            Exit Sub
        End If

        '処理入力チェック
        If Me.cboShori.SelectedValue = "" Then
            oVal.ErrorMessage = "処理を選択して下さい"
            args.IsValid = False
            Exit Sub
        End If

        'SHOP登録チェック
        Dim oDataSet As DataSet = ViewState("DataSet")
        Dim oTable As DataTable = oDataSet.Tables(TABLE_SHOP)
        Dim oRow As DataRow = Nothing

        If oTable.Rows.Count > 0 Then
            For i As Integer = 0 To oTable.Rows.Count - 1
                If oTable.Rows(i).Item(COL.SHOP_CD).ToString = Me.cboShop.SelectedValue Then
                    oRow = oTable.Rows(i)
                End If
            Next
        End If

        Select Case Me.cboShori.SelectedValue
            Case "A"        '追加
                If oRow IsNot Nothing Then
                    oVal.ErrorMessage = "SHOPが既に登録されています"
                    args.IsValid = False
                    Exit Sub
                End If
            Case "U", "D"   '訂正,削除
                If oRow Is Nothing Then
                    oVal.ErrorMessage = "SHOPが登録されていません"
                    args.IsValid = False
                    Exit Sub
                End If
        End Select
    End Sub

#End Region

#Region " ファイル関連 "

    '追加 
    Private Sub FileInsert()

        Dim sShop As String = "0"
        Dim oDataSet As DataSet = ViewState("DataSet")

        '代表SHOP取得
        For Each oRow As DataRow In oDataSet.Tables(TABLE_SHOP).Rows
            If oRow(COL.DAIHYO).ToString = "1" Then
                sShop = oRow(COL.SHOP_CD).ToString
            End If
        Next

        'マスタ更新履歴テーブル追加
        InsertHistory(ViewState("catalog") + ":" + txtKihon.Text.Trim() + ":" + txtHojo.Text.Trim())

        Dim sQuery As String = "INSERT INTO P_PROCESS_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
                                                                 ":F11,:F12,:F13,:F14,:F15,:F16,:F17,:F18,:F19)"
        _oDatabase.CreateParam("F01", ViewState("catalog"))
        _oDatabase.CreateParam("F02", txtKihon.Text.Trim())
        _oDatabase.CreateParam("F03", txtHojo.Text.Trim())
        _oDatabase.CreateParam("F04", txtKoutei.Text.Trim())
        _oDatabase.CreateParam("F05", txtOya.Text.Trim())
        _oDatabase.CreateParam("F06", txtTeifu.Text.Trim())
        _oDatabase.CreateParam("F07", sShop)                        '2010/08
        '_oDatabase.CreateParam("F07", cboShop.SelectedValue())
        _oDatabase.CreateParam("F08", txtComment.Text.Trim())
        _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F11", Session("UserID"))
        _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F13", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F14", Session("UserID"))
        _oDatabase.CreateParam("F15", MedicalLib.Common.ProgramID)
        '###### 2012/03/27 サイクルタクト更新仕様変更 ST ######
        If txtCycleTime.Text.Trim() <> "" Then
            _oDatabase.CreateParam("F16", txtCycleTime.Text.Trim())  '2010/03/16
        Else
            _oDatabase.CreateParam("F16", "0")
        End If
        If txtTactTime.Text.Trim() <> "" Then
            _oDatabase.CreateParam("F17", txtTactTime.Text.Trim())  '2010/03/16
        Else
            _oDatabase.CreateParam("F17", "0")
        End If
        '###### 2012/03/27 サイクルタクト更新仕様変更 ED ######
        _oDatabase.CreateParam("F18", txtPutTogether.Text.Trim())  '20120302 追加
        Dim W_CheckPlan As String '20120302 追加
        If CheckPlan.Checked = True Then '20120302 追加
            W_CheckPlan = "1"
        Else
            W_CheckPlan = "0"
        End If
        _oDatabase.CreateParam("F19", W_CheckPlan)  '20120302 追加
        _oDatabase.ExecuteNonQueryParam(sQuery)

        '加工工程SHOPマスタ更新
        If ViewState("kihon") Is Nothing And _
           ViewState("hojo") Is Nothing Then
        Else
            '訂正できた時は削除処理
            DeleteProcessShop()
        End If
        InsertProcessShop()
    End Sub

    '更新 
    Private Sub FileUpdate()

        Dim sShop As String = ""
        Dim oDataSet As DataSet = ViewState("DataSet")

        '代表SHOP取得
        For Each oRow As DataRow In oDataSet.Tables(TABLE_SHOP).Rows
            If oRow(COL.DAIHYO).ToString = "1" Then
                sShop = oRow(COL.SHOP_CD).ToString
            End If
        Next

        'マスタ更新履歴テーブル追加
        UpdateHistory()

        Dim sQuery As String = "UPDATE P_PROCESS_MST SET P_ORDER_MAIN=:F01,P_ORDER_SUB=:F02,PROCESS_CD=:F03,PER_PROCESS_CD=:F04,UM_P_ORDER=:F05,SHOP=:F06," + _
                                                         "P_COMMENT=:F07,UPD_DT=:F08,UPD_TIME=:F09,UPD_USR=:F10,UPD_PROGRAM_ID=:F11,CYCLE_TIME=:F12,TACT_TIME=:F13,PUT_TOGETHER_FLG=:F14,PLAN_TARGET_FLG=:F15 " + _
                                                         "WHERE CATALOG_NO = :K01 AND P_ORDER_MAIN = :K02 AND P_ORDER_SUB = :K03"
        _oDatabase.CreateParam("F01", txtKihon.Text.Trim())
        _oDatabase.CreateParam("F02", txtHojo.Text.Trim())
        _oDatabase.CreateParam("F03", txtKoutei.Text.Trim())
        _oDatabase.CreateParam("F04", txtOya.Text.Trim())
        _oDatabase.CreateParam("F05", txtTeifu.Text.Trim())
        _oDatabase.CreateParam("F06", sShop)                        '2010/08
        '_oDatabase.CreateParam("F06", cboShop.SelectedValue())
        _oDatabase.CreateParam("F07", txtComment.Text.Trim())
        _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F10", Session("UserID"))
        _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)
        '###### 2012/03/27 サイクルタクト更新仕様変更 ST ######
        If txtCycleTime.Text.Trim() <> "" Then
            _oDatabase.CreateParam("F12", txtCycleTime.Text.Trim())  '2010/03/16
        Else
            _oDatabase.CreateParam("F12", "0")
        End If
        If txtTactTime.Text.Trim() <> "" Then
            _oDatabase.CreateParam("F13", txtTactTime.Text.Trim())  '2010/03/16
        Else
            _oDatabase.CreateParam("F13", "0")
        End If
        '###### 2012/03/27 サイクルタクト更新仕様変更 ED ######
        _oDatabase.CreateParam("F14", txtPutTogether.Text.Trim())  '20120302 追加
        Dim W_CheckPlan As String '20120302 追加
        If CheckPlan.Checked = True Then '20120302 追加
            W_CheckPlan = "1"
        Else
            W_CheckPlan = "0"
        End If
        _oDatabase.CreateParam("F15", W_CheckPlan)  '20120302 追加
        _oDatabase.CreateParam("K01", ViewState("catalog"))
        _oDatabase.CreateParam("K02", ViewState("kihon"))
        _oDatabase.CreateParam("K03", ViewState("hojo"))
        _oDatabase.ExecuteNonQueryParam(sQuery)

        '加工工程SHOPマスタ追加
        DeleteProcessShop()
        InsertProcessShop()
    End Sub

    '削除 
    Private Sub FileDelete()
        Try
            _oDatabase.BeginTrans()

            'マスタ更新履歴テーブル追加
            DeleteHistory()

            Dim sQuery As String = "DELETE FROM P_PROCESS_MST WHERE CATALOG_NO = :K01 AND P_ORDER_MAIN = :K02 AND P_ORDER_SUB = :K03"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.CreateParam("K02", ViewState("kihon"))
            _oDatabase.CreateParam("K03", ViewState("hojo"))
            _oDatabase.ExecuteNonQueryParam(sQuery)

            '加工工程SHOPマスタ削除
            DeleteProcessShop()

            _oDatabase.CommitTrans()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '加工工程SHOPマスタ削除     2010/08 追加
    Private Sub DeleteProcessShop()

        Dim sQuery As String = ""

        sQuery += "DELETE FROM P_PROCESS_SHOP_MST"
        sQuery += " WHERE CATALOG_NO = :K01"
        sQuery += "   AND P_ORDER_MAIN = :K02"
        sQuery += "   AND P_ORDER_SUB = :K03"
        _oDatabase.CreateParam("K01", ViewState("catalog"))
        _oDatabase.CreateParam("K02", ViewState("kihon"))
        _oDatabase.CreateParam("K03", ViewState("hojo"))
        _oDatabase.ExecuteNonQueryParam(sQuery)
    End Sub

    '加工工程SHOPマスタ追加     2010/08 追加
    Private Sub InsertProcessShop()

        Dim oDataSet As DataSet = ViewState("DataSet")
        Dim sQuery As String = ""
        Dim sQuery2 As String = ""                  '2011/10/17
        Dim oReader As OracleDataReader = Nothing   '2011/10/17
        Dim blnUpdate As Boolean = False             '2011/10/17

        '###### 2011/10/17 ADD エラー対策 ######
        sQuery2 = ""
        sQuery2 += "SELECT CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB, SHOP FROM P_PROCESS_SHOP_MST"
        sQuery2 += " WHERE CATALOG_NO = :K01"
        sQuery2 += " AND P_ORDER_MAIN = :K02"
        sQuery2 += " AND P_ORDER_SUB = :K03"
        sQuery2 += " AND SHOP = :K04"
        '###### 2011/10/17 ADD エラー対策 ######

        For Each oRow As DataRow In oDataSet.Tables(TABLE_SHOP).Rows
            blnUpdate = False
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.CreateParam("K02", Me.txtKihon.Text.Trim())
            _oDatabase.CreateParam("K03", Me.txtHojo.Text.Trim())
            _oDatabase.CreateParam("K04", oRow(COL.SHOP_CD).ToString)
            oReader = _oDatabase.CreateReaderParam(sQuery2)
            If oReader.Read Then
                blnUpdate = True
            End If
            oReader.Close()
            If blnUpdate = True Then
                sQuery = ""
                sQuery += "UPDATE P_PROCESS_SHOP_MST SET"
                sQuery += " TYPICAL_KB = :F01,"
                sQuery += " UPD_DT = :F02,"
                sQuery += " UPD_TIME = :F03,"
                sQuery += " UPD_USR = :F04,"
                sQuery += " UPD_PROGRAM_ID = :F05"
                sQuery += " WHERE CATALOG_NO = :K01"
                sQuery += " AND P_ORDER_MAIN = :K02"
                sQuery += " AND P_ORDER_SUB = :K03"
                sQuery += " AND SHOP = :K04"
                _oDatabase.CreateParam("F01", oRow(COL.DAIHYO).ToString)
                _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F04", Session("UserID"))
                _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                _oDatabase.CreateParam("K01", ViewState("catalog"))
                _oDatabase.CreateParam("K02", Me.txtKihon.Text.Trim())
                _oDatabase.CreateParam("K03", Me.txtHojo.Text.Trim())
                _oDatabase.CreateParam("K04", oRow(COL.SHOP_CD).ToString)
            Else
                sQuery = ""
                sQuery += "INSERT INTO P_PROCESS_SHOP_MST "
                sQuery += "( CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB, SHOP, TYPICAL_KB"
                sQuery += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                sQuery += ") VALUES ("
                sQuery += "  :F01, :F02, :F03, :F04, :F05"
                sQuery += ", :F06, :F07, :F08, :F09, :F10, :F11, :F12"
                sQuery += ")"
                _oDatabase.CreateParam("F01", ViewState("catalog"))
                _oDatabase.CreateParam("F02", Me.txtKihon.Text.Trim())
                _oDatabase.CreateParam("F03", Me.txtHojo.Text.Trim())
                _oDatabase.CreateParam("F04", oRow(COL.SHOP_CD).ToString)
                _oDatabase.CreateParam("F05", oRow(COL.DAIHYO).ToString)
                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F08", Session("UserID"))
                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F11", Session("UserID"))
                _oDatabase.CreateParam("F12", MedicalLib.Common.ProgramID)
            End If
            _oDatabase.ExecuteNonQueryParam(sQuery)
        Next
    End Sub

#End Region

#Region " その他 "

    'コンボボックス設定 
    Private Sub ComboSet(ByRef oCombo As Web.UI.WebControls.DropDownList)
        Try
            Dim sQuery As String = "SELECT SHOP,SHOP_NM FROM SHOP_MST ORDER BY SHOP"
            Dim oReader As OracleDataReader = _oDatabase.CreateReader(sQuery)
            oCombo.Items.Clear()
            oCombo.Items.Add(New ListItem("", ""))
            While oReader.Read()
                oCombo.Items.Add(New ListItem(oReader.GetString(0) + ":" + oReader.GetString(1), oReader.GetString(0)))
            End While
            oReader.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    'データセット作成       '2010/08 追加
    Private Sub CreateDataSet(ByVal sCatalog As String, ByVal sMain As String, ByVal sSub As String)

        Dim sQuery As String = ""

        sQuery += "SELECT P.SHOP || ':' || S.SHOP_NM AS SHOP"
        sQuery += "     , P.TYPICAL_KB AS 代表区分"
        sQuery += "     , P.SHOP AS SHOP_CD"
        sQuery += "  FROM P_PROCESS_SHOP_MST P"
        sQuery += "     , SHOP_MST S"
        sQuery += " WHERE P.CATALOG_NO = :K01"
        sQuery += "   AND P.P_ORDER_MAIN = :K02"
        sQuery += "   AND P.P_ORDER_SUB = :K03"
        sQuery += "   AND P.SHOP = S.SHOP(+)"
        sQuery += " ORDER BY P.SHOP"

        _oDatabase.CreateParam("K01", sCatalog)
        _oDatabase.CreateParam("K02", sMain)
        _oDatabase.CreateParam("K03", sSub)
        Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, TABLE_SHOP)

        ViewState("DataSet") = oDataSet
    End Sub

    'データセットの行削除
    Private Sub DelDataSetRow()
        Dim oDataSet As DataSet = ViewState("DataSet")
        Dim oTable As DataTable = oDataSet.Tables(TABLE_SHOP)

        For i As Integer = oTable.Rows.Count - 1 To 0 Step -1
            oTable.Rows.RemoveAt(i)
        Next
        BindShop()
        Me.hidDel.Value = ""
    End Sub

    Private Function GetString(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As String
        If oReader.IsDBNull(nIndex) Then Return ""
        Return oReader.GetString(nIndex).Trim()
    End Function

    Private Function GetInt32(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Int32
        If oReader.IsDBNull(nIndex) Then Return 0
        Return oReader.GetInt32(nIndex)
    End Function

    Private Function GetDouble(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Double
        If oReader.IsDBNull(nIndex) Then Return 0.0
        Return oReader.GetDouble(nIndex)
    End Function

    Private Sub GoBack()
        Response.Redirect("mdmas150.aspx?call=" + ViewState("call") + "&catalog=" + ViewState("catalog"), False)
    End Sub

    Private Sub CheckPlan_chen()
        'スケジュール管理チェックボックス  20120315追加
        If CheckPlan.Checked = True Then
            'チェックの場合
            'valCycleTime2.Enabled = True
            valCycleTime3.Enabled = True
            'valTactTime2.Enabled = True
            valTactTime3.Enabled = True
            'valPutTogether.Enabled = True
            valPutTogether3.Enabled = True
            txtCycleTime.BackColor = Color.FromArgb(255, 255, 192)
            txtTactTime.BackColor = Color.FromArgb(255, 255, 192)
            txtPutTogether.BackColor = Color.FromArgb(255, 255, 192)
            udpInfo.Update()
        Else
            '非チェックの場合
            'valCycleTime2.Enabled = False
            valCycleTime3.Enabled = False
            'valTactTime2.Enabled = False
            valTactTime3.Enabled = False
            'valPutTogether.Enabled = False
            valPutTogether3.Enabled = False
            txtCycleTime.BackColor = Color.White
            txtTactTime.BackColor = Color.White
            txtPutTogether.BackColor = Color.White
            udpInfo.Update()
        End If
    End Sub

#End Region

#Region " 更新履歴用 "

    Private Sub InsertHistory(ByVal sKey As String)
        InsertMH(sKey, "追加", "", "")
    End Sub

    Private Sub DeleteHistory()
        InsertMH("削除", "", "")
    End Sub

    Private Sub UpdateHistory()
        Dim sItemNames() As String = GetItemName().Split(",")
        Dim sMotoValues() As String = GetMotoValue(sItemNames.Length()).Split(",")
        '**** 2010/05 項目追加対応 ST ****

        Dim W_CheckPlan As String '20120302 追加
        If CheckPlan.Checked = True Then '20120302 追加
            W_CheckPlan = "1"
        Else
            W_CheckPlan = "0"
        End If
        Dim sGenValues() As String = (txtKihon.Text.Trim + "," + txtHojo.Text.Trim + "," + txtKoutei.Text.Trim() + "," + txtOya.Text.Trim() + "," + txtTeifu.Text.Trim() + "," + cboShop.SelectedValue + "," + txtComment.Text.Trim() + "," + txtCycleTime.Text.Trim() + "," + txtTactTime.Text.Trim() + "," + _
                                      txtPutTogether.Text.Trim + "," + W_CheckPlan).Split(",")
        'Dim sGenValues() As String = (txtKihon.Text.Trim + "," + txtHojo.Text.Trim + "," + txtKoutei.Text.Trim() + "," + txtOya.Text.Trim() + "," + txtTeifu.Text.Trim() + "," + cboShop.SelectedValue + "," + txtComment.Text.Trim()).Split(",")
        '**** 2010/05 項目追加対応 ED ****

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) Then
                Select Case i
                    Case 2, 3   '工程
                        InsertMH(sItemNames(i), GetKouteiName(sMotoValues(i)), GetKouteiName(sGenValues(i)))
                    Case 5      'SHOP
                        InsertMH(sItemNames(i), GetShopName(sMotoValues(i)), GetShopName(sGenValues(i)))
                    Case Else
                        InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i))
                End Select
            End If
        Next
    End Sub

    '項目名をコンマ区切りで返す
    Private Function GetItemName() As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sConnectString As String = ConfigurationManager.ConnectionStrings("MedicalDB").ToString()
        Dim sStartPos As Integer = sConnectString.IndexOf("User Id=")
        Dim sEndPos As Integer = sConnectString.IndexOf(";", sStartPos + 1)
        Dim sUserID As String = sConnectString.Substring(sStartPos, sEndPos - sStartPos).Replace("User Id=", "")
        Dim sResult As String = ""
        Try
            sQuery = "SELECT A.COLUMN_NAME,B.DOUBLE_BYTE,A.DATA_TYPE "
            sQuery += "FROM DBA_TAB_COLUMNS A,FIELD_NAME_TBL B "
            sQuery += "WHERE A.COLUMN_NAME = B.SINGLE_BYTE(+) AND A.OWNER = :K01 AND A.TABLE_NAME = :K02 "
            sQuery += "ORDER BY A.COLUMN_ID"
            _oDatabase.CreateParam("K01", sUserID.ToUpper())
            _oDatabase.CreateParam("K02", TABLE_NAME)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            While oReader.Read
                If GetString(oReader, 1) <> "カタログ番号" Then   '主キー以外 (基本工順,補助工順を除く)

                    '**** 2010/05 項目追加対応 ST ****
                    If Not (GetString(oReader, 1) = "登録日付" Or _
                            GetString(oReader, 1) = "登録時刻" Or _
                            GetString(oReader, 1) = "登録ユーザID" Or _
                            GetString(oReader, 1) = "更新日付" Or _
                            GetString(oReader, 1) = "更新時刻" Or _
                            GetString(oReader, 1) = "更新ユーザID" Or _
                            GetString(oReader, 1) = "更新プログラムID") Then

                        sResult += GetString(oReader, 1) + ","
                    End If
                    'If GetString(oReader, 1) = "登録日付" Then
                    '    Exit While
                    'Else
                    '    sResult += GetString(oReader, 1) + ","
                    'End If
                    '**** 2010/05 項目追加対応 ED ****
                End If
            End While
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult.Substring(0, sResult.Length - 1)
    End Function

    '更新前項目をコンマ区切りで返す
    Private Function GetMotoValue(ByVal iItemSu As Integer) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Dim i As Integer = 0
        Dim iKeySu As Integer = 1       '主キー項目数 (基本工順,補助工順を除く)
        Dim sResult As String = ""
        Try
            '**** 2010/05 項目追加対応 ST ****
            sQuery = ""
            sQuery += "SELECT CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB, PROCESS_CD, PER_PROCESS_CD"
            sQuery += "     , UM_P_ORDER, SHOP, P_COMMENT, CYCLE_TIME, TACT_TIME, PUT_TOGETHER_FLG, PLAN_TARGET_FLG"
            sQuery += "     , CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
            sQuery += "  FROM P_PROCESS_MST"
            sQuery += " WHERE CATALOG_NO = :KEY1"
            sQuery += "   AND P_ORDER_MAIN = :KEY2"
            sQuery += "   AND P_ORDER_SUB = :KEY3"
            'sQuery = "SELECT * FROM P_PROCESS_MST WHERE CATALOG_NO = :KEY1 AND P_ORDER_MAIN = :KEY2 AND P_ORDER_SUB = :KEY3 "
            '**** 2010/05 項目追加対応 ED ****
            _oDatabase.CreateParam("KEY1", ViewState("catalog"))
            _oDatabase.CreateParam("KEY2", ViewState("key1"))
            _oDatabase.CreateParam("KEY3", ViewState("key2"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                For i = iKeySu To iItemSu - 1 + iKeySu
                    Try
                        sResult += GetString(oReader, i) + ","
                    Catch ex As Exception
                        sResult += GetDouble(oReader, i).ToString + ","
                    End Try
                Next
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult.Substring(0, sResult.Length - 1)
    End Function

    'マスタ更新履歴テーブル追加
    Private Sub InsertMH(ByVal sItemName As String, ByVal sMae As String, ByVal sAto As String)
        InsertMH(ViewState("catalog") + ":" + ViewState("key1") + ":" + ViewState("key2"), sItemName, sMae, sAto)
    End Sub

    Private Sub InsertMH(ByVal sKey As String, ByVal sItemName As String, ByVal sMae As String, ByVal sAto As String)
        Dim sQuery As String = ""

        sQuery = "INSERT INTO MASTER_HIS_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
                                                    ":F11,:F12,:F13,:F14)"
        _oDatabase.CreateParam("F01", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F03", TABLE_NAME_JP)
        _oDatabase.CreateParam("F04", sKey)
        _oDatabase.CreateParam("F05", sItemName)
        _oDatabase.CreateParam("F06", sMae)
        _oDatabase.CreateParam("F07", sAto)
        _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F10", Session("UserID"))
        _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F13", Session("UserID"))
        _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)

        _oDatabase.ExecuteNonQueryParam(sQuery)

    End Sub

    'SHOP名付き
    Private Function GetShopName(ByVal sKey As String) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sResult As String = ""
        Try
            sQuery += "SELECT SHOP,SHOP_NM FROM SHOP_MST WHERE SHOP = :K01"
            _oDatabase.CreateParam("K01", sKey)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                sResult = GetString(oReader, 0) + ":" + GetString(oReader, 1)
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult
    End Function

    '工程 名付き
    Private Function GetKouteiName(ByVal sKey As String) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sResult As String = ""
        Try
            sQuery += "SELECT PROCESS_CD,P_ORDER_NM FROM PROCESS_MST WHERE PROCESS_CD = :K01 "
            _oDatabase.CreateParam("K01", sKey)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                sResult = GetString(oReader, 0) + ":" + GetString(oReader, 1)
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult
    End Function

#End Region

End Class
