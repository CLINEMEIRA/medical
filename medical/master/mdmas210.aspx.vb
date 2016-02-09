Imports System.Drawing
Imports System.Data 
Imports System.Data.OracleClient 
Imports System.Text 
 
Partial Class master_mdmas210
    Inherits System.Web.UI.Page
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS210"
    Private Const PROGRAM_TITLE As String = "設備カレンダーマスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess
    Public _sCallBackScript As String = ""
    Private _sGetValue As String = ""

    Public cmbT_K As New DataTable
    Public cmbT_Z As New DataTable
    Public strT_K(1, 0) As String
    Public strT_Z(1, 0) As String
    Private Const KYUJITU As String = "1"

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            _sCallBackScript = Page.ClientScript.GetCallbackEventReference(Me, "command", "getCallBack", "context", "getCallBackError", False)
            If Not Page.IsPostBack Then
                Displayclear()
                rdoSel1.Focus()

                GetDdlItem()        'ドロップダウンリストの中身を取得
            End If
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

            '休日の時は残業を選択不可
            If CType(oLine.Cells(2).Controls(1), DropDownList).SelectedIndex = 0 Then
                CType(oLine.Cells(4).Controls(1), DropDownList).Enabled = False
                CType(oLine.Cells(6).Controls(1), DropDownList).Enabled = False
                CType(oLine.Cells(8).Controls(1), DropDownList).Enabled = False
            End If

            '計画のある日は変更をできないようにする
            If oLine.Cells(10).Text > 0 Then
                oLine.ForeColor = Color.Fuchsia
                CType(oLine.Cells(2).Controls(1), DropDownList).Enabled = False
                CType(oLine.Cells(4).Controls(1), DropDownList).Enabled = False
                CType(oLine.Cells(6).Controls(1), DropDownList).Enabled = False
                CType(oLine.Cells(8).Controls(1), DropDownList).Enabled = False
            End If
        End If
    End Sub

    '検索ボタン押下 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnSearch.Click
        lblMessage1.Text = ""
        lblMessage2.Text = ""
        Page.Validate("key1")
        Page.Validate("key2")
        If Page.IsValid Then
            If Not Page.IsValid() Then Exit Sub
            DisplayShow()
            DisplayList()

            'Key部分を検索後にさわられたときの対策
            ViewState("txtCode") = Me.txtCode.Text.Trim
            ViewState("txtDate") = Me.txtdate.Text.Trim
        Else
            ClearList()
        End If
    End Sub

    '実行ボタン押下 
    Protected Sub btnRun_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnRun.Click
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim i, j As Integer
        Dim strDates(1, 30) As String
        Dim strDate As String
        Dim strCode As String

        lblMessage1.Text = ""
        lblMessage2.Text = ""
        Page.Validate("key2")
        If Page.IsValid Then
            DisplayShow()

            'すでに設備カレンダーマスタがある場合は削除してから挿入
            _oDatabase.BeginTrans()
            Try
                If ViewState("Mode") = "DEL" Then
                    '削除 
                    sQuery = "DELETE FROM FACILITIES_CLND_MST WHERE SUBSTR(C_DATE,1,6) = :K01"
                    _oDatabase.CreateParam("K01", txtdate.Text.Trim())
                    _oDatabase.ExecuteNonQueryParam(sQuery)
                End If

                'カレンダマスタより日付を取得→配列に格納
                sQuery = "SELECT C_DAY,WORK_FLG FROM CALENDAR_MST WHERE C_YEAR = :K01 AND C_MONTH = :K02 ORDER BY C_DAY"
                '★日付の桁数
                _oDatabase.CreateParam("K01", Left(txtdate.Text.Trim(), 4))
                _oDatabase.CreateParam("K02", Right(txtdate.Text.Trim(), 2))
                oReader = _oDatabase.CreateReaderParam(sQuery)
                i = 0
                Do While oReader.Read
                    strDates(0, i) = GetString(oReader, 0)
                    strDates(1, i) = GetString(oReader, 1)
                    i = i + 1
                Loop
                oReader.Close()

                '設備マスタのスケジュール管理区分=1のものを登録
                sQuery = "SELECT FACILITIES_CD,ST_OPERATION_FORM FROM FACILITIES_MST WHERE SCHEDULE_KB = :K01 ORDER BY FACILITIES_CD"
                _oDatabase.CreateParam("K01", "1")
                oReader = _oDatabase.CreateReaderParam(sQuery)

                j = 0
                strCode = ""
                Do While oReader.Read
                    If GetString(oReader, 1) = "" Then
                        strCode = strCode & GetString(oReader, 0) & ","
                    Else
                        For j = 0 To i - 1
                            '設備カレンダーマスタ 
                            sQuery = "INSERT INTO FACILITIES_CLND_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11,:F12,:F13)"
                            _oDatabase.CreateParam("F01", GetString(oReader, 0))                    'FACILITIES_CD 
                            _oDatabase.CreateParam("F02", Me.txtdate.Text.Trim & strDates(0, j))    'C_DATE
                            If strDates(1, j) = "1" Then
                                _oDatabase.CreateParam("F03", "0")                                  'OPERATION_FORM 
                            Else
                                _oDatabase.CreateParam("F03", GetString(oReader, 1))                'OPERATION_FORM 
                            End If
                            _oDatabase.CreateParam("F04", "")                                   'OVER_WORK_FORM1 
                            _oDatabase.CreateParam("F05", "")                                   'OVER_WORK_FORM2 
                            _oDatabase.CreateParam("F06", "")                                   'OVER_WORK_FORM3 
                            _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)      'CRT_DT 
                            _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)      'CRT_TIME 
                            _oDatabase.CreateParam("F09", Session("UserID"))                    'CRT_USR 
                            _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                            _oDatabase.CreateParam("F12", Session("UserID"))                    'UPD_USR 
                            _oDatabase.CreateParam("F13", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
                            _oDatabase.ExecuteNonQueryParam(sQuery)
                        Next
                    End If
                Loop

                _oDatabase.CommitTrans()
                strDate = txtdate.Text.Trim
                Me.txtCode.Text = ""
                Me.txtdate.Text = ""
                '終了メッセージ
                lblMessage1.Text = Left(strDate, 4) & "年" & Right(strDate, 2) & "月の初期化処理が終了しました。"
                If strCode <> "" Then
                    lblMessage2.Text = "標準稼働形態が未入力だった設備コード:" & Left(strCode, Len(strCode) - 1)
                End If
                udpKey.Update()

            Catch ex As Exception
                _oDatabase.Rollback()
                MedicalLib.PageError.Show(ex.Message)
            End Try
        End If
    End Sub

    '登録
    Protected Sub btnUpdate_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnUpdate.Click

        Page.Validate("run")
        If Not Page.IsValid Then
            Return
        End If

        Dim sQuery As String = ""
        Try
            _oDatabase.BeginTrans()

            If ViewState("Mode") = "UPDATE" Then
                ViewState("Mode") = "UPDATE_D"
                btnDel_ServerClick(sender, e)
                ''ロールバックエラーの確認
                ViewState("Mode") = "UPDATE"
            End If

            For i As Integer = 0 To grdList.Items.Count - 1
                '設備カレンダーマスタ 
                sQuery = "INSERT INTO FACILITIES_CLND_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11,:F12,:F13)"
                _oDatabase.CreateParam("F01", ViewState("txtCode"))                    'FACILITIES_CD 
                _oDatabase.CreateParam("F02", ViewState("txtDate") & grdList.Items(i).Cells(0).Text.Trim)           'C_DATE 
                _oDatabase.CreateParam("F03", CType(grdList.Items(i).Cells(2).Controls(1), DropDownList).Text)      'OPERATION_FORM 
                _oDatabase.CreateParam("F04", CType(grdList.Items(i).Cells(4).Controls(1), DropDownList).Text)      'OPERATION_FORM 
                _oDatabase.CreateParam("F05", CType(grdList.Items(i).Cells(6).Controls(1), DropDownList).Text)      'OVER_WORK_FORM1 
                _oDatabase.CreateParam("F06", CType(grdList.Items(i).Cells(8).Controls(1), DropDownList).Text)      'OVER_WORK_FORM2 
                _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)      'CRT_DT 
                _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)      'CRT_TIME 
                _oDatabase.CreateParam("F09", Session("UserID"))                    'CRT_USR 
                _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                _oDatabase.CreateParam("F12", Session("UserID"))                    'UPD_USR 
                _oDatabase.CreateParam("F13", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
                _oDatabase.ExecuteNonQueryParam(sQuery)
            Next
            _oDatabase.CommitTrans()
            Displayclear()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        Finally
        End Try
    End Sub

    '削除ボタン押下処理 
    Protected Sub btnDel_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnDel.Click
        If ViewState("Mode") <> "UPDATE_D" Then
            _oDatabase.BeginTrans()
        End If
        Try
            '削除 
            Dim sQuery As String
            sQuery = "DELETE FROM FACILITIES_CLND_MST WHERE FACILITIES_CD = :K01 AND SUBSTR(C_DATE,1,6) = :K02"
            _oDatabase.CreateParam("K01", ViewState("txtCode"))
            _oDatabase.CreateParam("K02", ViewState("txtDate"))
            _oDatabase.ExecuteNonQueryParam(sQuery)
            If ViewState("Mode") <> "UPDATE_D" Then
                _oDatabase.CommitTrans()
                Displayclear()
            End If
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    'クリアボタン
    Protected Sub btnClear_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnClear.Click
        lblName1.Text = ViewState("name1")
        lblName2.Text = ViewState("name2")
        DisplayList()
    End Sub

    '戻るボタン押下 
    Protected Sub btnBack_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnBack.Click
        ClearList()
    End Sub

    'ラジオボタン押下
    Protected Sub rdoSel_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        btnSearch.Visible = rdoSel1.Checked
        btnRun.Visible = rdoSel2.Checked
        tblSelect.Rows(1).Visible = rdoSel1.Checked
        tblSelect.Rows(2).Visible = rdoSel1.Checked
        Me.btnRun.Visible = (rdoSel2.Checked And MedicalLib.Common.EnableInsert())
        Me.txtCode.Text = ""
        Me.lblName1.Text = ""
        Me.lblName2.Text = ""
        Me.txtdate.Text = ""
        Me.lblMessage1.Text = ""
        Me.lblMessage2.Text = ""
        ClearList()
    End Sub
#End Region

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        Dim sReturnValue As String = ""
        Dim sQuery As String = ""
        Dim sValues() As String = _sGetValue.Split(Chr(9))
        Dim i As Integer

        Select Case Left(sValues(0), 1)
            Case "c"
                sQuery = "SELECT FACILITIES_NM,FACILITIES_NO,ST_OPERATION_FORM FROM FACILITIES_MST WHERE FACILITIES_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    sReturnValue = GetString(oReader, 0).Trim() + Chr(9) + GetString(oReader, 1).Trim() + Chr(9)
                Else
                    sReturnValue = ""
                End If
                oReader.Close()
            Case "n"
                If sValues(1).Trim() <> "" Then
                    '設備カレンダーマスタにデータが存在する場合
                    sQuery = "SELECT FACILITIES_CD FROM FACILITIES_CLND_MST WHERE SUBSTR(C_DATE,1,6) = :K01"
                    _oDatabase.CreateParam("K01", sValues(1).Trim())
                    Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        sReturnValue = sValues(1).Trim() + Chr(9) + "DEL"
                    Else
                        sReturnValue = sValues(1).Trim() + Chr(9) + "INS"
                    End If
                    oReader.Close()
                End If
            Case "k"
                strT_K = Session("strT_K")
                For i = 0 To UBound(strT_K, 2)
                    If sValues(1) = strT_K(0, i) Then
                        sReturnValue = strT_K(1, i)
                    End If
                Next
                sReturnValue = sReturnValue & Chr(9) & sValues(2)
            Case "z"
                sReturnValue = ""
                strT_Z = Session("strT_Z")
                For i = 0 To UBound(strT_Z, 2)
                    If sValues(1) = strT_Z(0, i) Then
                        sReturnValue = strT_Z(1, i)
                    End If
                Next
                sReturnValue = sReturnValue & Chr(9) & sValues(2)
        End Select
        Return sValues(0) & Chr(9) & sReturnValue
    End Function

    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        _sGetValue = eventArgument
    End Sub

#End Region

#Region " 画面関連 "
    Private Sub Displayclear()
        Me.rdoSel1.Checked = True
        Me.rdoSel2.Checked = False
        tblSelect.Rows(1).Visible = True
        tblSelect.Rows(2).Visible = True
        Me.txtCode.Text = ""
        Me.lblName1.Text = ""
        Me.lblName2.Text = ""
        Me.txtdate.Text = ""
        lblMessage1.Text = ""
        lblMessage2.Text = ""
        btnSearch.Visible = True
        btnRun.Visible = False
        Me.pnlList1.Visible = False
        Me.pnlList2.Visible = False
        Me.udpList.Update()
        Me.udpKey.Update()
    End Sub

    Private Sub ClearList()
        Me.pnlList1.Visible = False
        Me.pnlList2.Visible = False
        Me.udpList.Update()
    End Sub

    Private Sub DisplayShow()
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT FACILITIES_NM,FACILITIES_NO FROM FACILITIES_MST WHERE FACILITIES_CD = :K01"
            _oDatabase.CreateParam("K01", txtCode.Text.Trim)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                lblName1.Text = GetString(oReader, 0)
                lblName2.Text = GetString(oReader, 1)
            Else
                lblName1.Text = ""
                lblName2.Text = ""
            End If
            oReader.Close()
            ViewState("name1") = lblName1.Text.Trim()
            ViewState("name2") = lblName2.Text.Trim()

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    Private Sub DisplayList()
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim i, j, k, l, m As Integer
        Dim intDates(31) As Integer
        Dim strJikan As String = ""

        Dim flgDelVisible As Boolean = True

        Try
            cmbT_Z = Session("cmbT_Z")
            strT_Z = Session("strT_Z")
            cmbT_K = Session("cmbT_K")
            strT_K = Session("strT_K")

            '★データ抽出
            Dim sb As New StringBuilder
            sb.AppendLine("SELECT SUBSTR(A.C_DATE,7,2) AS HIZUKE")
            sb.AppendLine("     , SUBSTR(to_char(to_date(A.C_DATE,'yyyymmdd'),'Day'),1,1) AS YOUBI")
            sb.AppendLine("     , A.OPERATION_FORM AS KEI")
            sb.AppendLine("     , B.OPE_FORM_NAM AS KEI_NM")
            sb.AppendLine("     , B.OPE_START1 AS KEI_S1, B.OPE_END1 AS KEI_E1")
            sb.AppendLine("     , B.OPE_START2 AS KEI_S2, B.OPE_END2 AS KEI_E2")
            sb.AppendLine("     , B.OPE_START3 AS KEI_S3, B.OPE_END3 AS KEI_E3")
            sb.AppendLine("     , A.OVER_WORK_FORM1 AS ZAN1, C.OPE_FORM_NAM AS ZAN1_NM, C.OPE_START1 AS ZAN1_S1, C.OPE_END1 AS ZAN1_E1")
            sb.AppendLine("     , A.OVER_WORK_FORM2 AS ZAN2, D.OPE_FORM_NAM AS ZAN2_NM, D.OPE_START1 AS ZAN2_S1, D.OPE_END1 AS ZAN2_E1")
            sb.AppendLine("     , A.OVER_WORK_FORM3 AS ZAN3, E.OPE_FORM_NAM AS ZAN3_NM, E.OPE_START1 AS ZAN3_S1, E.OPE_END1 AS ZAN3_E1")
            sb.AppendLine("     , (select count(*)")
            sb.AppendLine("          from MANUFACT_PLAN_TBL MP")
            sb.AppendLine("         where MP.FACILITIES_CD = A.FACILITIES_CD")
            sb.AppendLine("           and (MP.SCHEDULE_ST_DT = A.C_DATE")
            sb.AppendLine("                or MP.SCHEDULE_ED_DT = A.C_DATE)")
            sb.AppendLine("       ) AS PLAN_CNT")
            sb.AppendLine("  FROM FACILITIES_CLND_MST A")
            sb.AppendLine("     , ST_OPERATION_FORM_MST B")
            sb.AppendLine("     , ST_OPERATION_FORM_MST C")
            sb.AppendLine("     , ST_OPERATION_FORM_MST D")
            sb.AppendLine("     , ST_OPERATION_FORM_MST E")
            sb.AppendLine(" WHERE A.FACILITIES_CD= :K01")
            sb.AppendLine("   AND A.C_DATE LIKE :K02")
            sb.AppendLine("   AND A.OPERATION_FORM = B.OPE_FORM_CD(+)")
            sb.AppendLine("   AND A.OVER_WORK_FORM1 = C.OPE_FORM_CD(+)")
            sb.AppendLine("   AND A.OVER_WORK_FORM2 = D.OPE_FORM_CD(+)")
            sb.AppendLine("   AND A.OVER_WORK_FORM3 = E.OPE_FORM_CD(+)")
            sb.AppendLine(" ORDER BY A.C_DATE")

            _oDatabase.CreateParam("K01", txtCode.Text.Trim)
            _oDatabase.CreateParam("K02", txtdate.Text.Trim & "%")
            ''Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
            ''Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView
            ''grdList.DataSource = oDataView
            ''grdList.DataBind()

            oReader = _oDatabase.CreateReaderParam(sb.ToString)
            If oReader.HasRows = True Then
                i = 0
                Dim dt As New DataTable
                Dim zan1 As String
                Dim zan2 As String
                Dim zan3 As String
                dt.Columns.Add("HIZUKE", GetType(String))
                dt.Columns.Add("YOUBI", GetType(String))
                dt.Columns.Add("KEI", GetType(String))
                dt.Columns.Add("ZAN1", GetType(String))
                dt.Columns.Add("ZAN2", GetType(String))
                dt.Columns.Add("ZAN3", GetType(String))
                dt.Columns.Add("PLAN_CNT", GetType(Integer))

                Do While oReader.Read
                    If GetString(oReader, 10) = "" Then
                        k = 0
                    Else
                        zan1 = GetString(oReader, 10)
                        '選択するコンボのINDEX取得
                        For k = 0 To UBound(strT_Z, 2)
                            If zan1 = strT_Z(0, k) Then
                                Exit For
                            End If
                        Next
                        If k > UBound(strT_Z, 2) Then
                            k = 0
                        End If
                    End If

                    If GetString(oReader, 14) = "" Then
                        l = 0
                    Else
                        zan2 = GetString(oReader, 14)
                        '選択するコンボのINDEX取得
                        For l = 0 To UBound(strT_Z, 2)
                            If zan2 = strT_Z(0, l) Then
                                Exit For
                            End If
                        Next
                        If l > UBound(strT_Z, 2) Then
                            l = 0
                        End If
                    End If
                    If GetString(oReader, 18) = "" Then
                        m = "0"
                    Else
                        zan3 = GetString(oReader, 18)
                        '選択するコンボのINDEX取得
                        For m = 0 To UBound(strT_Z, 2)
                            If zan3 = strT_Z(0, m) Then
                                Exit For
                            End If
                        Next
                        If m > UBound(strT_Z, 2) Then
                            m = 0
                        End If
                    End If

                    '選択するコンボのINDEX取得
                    For j = 0 To UBound(strT_K, 2)
                        If GetString(oReader, 2) = strT_K(0, j) Then
                            Exit For
                        End If
                    Next
                    If j > UBound(strT_K, 2) Then
                        j = 0
                    End If

                    dt.Rows.Add(GetString(oReader, 0), GetString(oReader, 1), j, k, l, m, GetInt32(oReader, 22))
                    i = i + 1

                    '計画が既にある場合、削除できない
                    If GetInt32(oReader, 22) > 0 Then
                        flgDelVisible = False
                    End If
                Loop
                grdList.DataSource = dt
                Me.grdList.DataBind()

                'コンボ内容によるラベルの設定(BINDではラベルが有効にならないため)
                For Each oRow As DataGridItem In Me.grdList.Items
                    CType(oRow.Cells(3).Controls(1), Label).Text = strT_K(1, CType(oRow.Cells(2).Controls(1), DropDownList).SelectedIndex)
                    CType(oRow.Cells(5).Controls(1), Label).Text = strT_Z(1, CType(oRow.Cells(4).Controls(1), DropDownList).SelectedIndex)
                    CType(oRow.Cells(7).Controls(1), Label).Text = strT_Z(1, CType(oRow.Cells(6).Controls(1), DropDownList).SelectedIndex)
                    CType(oRow.Cells(9).Controls(1), Label).Text = strT_Z(1, CType(oRow.Cells(8).Controls(1), DropDownList).SelectedIndex)
                Next

                oReader.Close()

                ViewState("Mode") = "UPDATE"
                If flgDelVisible Then
                    btnDel.Visible = MedicalLib.Common.EnableDelete
                Else
                    btnDel.Visible = False
                End If
                btnUpdate.Visible = MedicalLib.Common.EnableUpdate
                btnInsert.Visible = False
                btnUpdate.Attributes.Add("onclick", MedicalLib.Script.Update)
                btnDel.Attributes.Add("onclick", MedicalLib.Script.Delete)
            Else
                '--カレンダーマスタより表をつくる
                sQuery = "SELECT C_DAY,SUBSTR(to_char(to_date(C_YEAR||C_MONTH||C_DAY,'yyyymmdd'),'Day'),1,1),WORK_FLG  FROM CALENDAR_MST WHERE C_YEAR = :K01 AND C_MONTH = :K02 ORDER BY C_DAY"
                '★日付の桁数
                _oDatabase.CreateParam("K01", Left(txtdate.Text.Trim(), 4))
                _oDatabase.CreateParam("K02", Right(txtdate.Text.Trim(), 2))
                oReader = _oDatabase.CreateReaderParam(sQuery)
                i = 0
                Dim dt As New DataTable
                dt.Columns.Add("HIZUKE", GetType(String))
                dt.Columns.Add("YOUBI", GetType(String))
                dt.Columns.Add("KEI", GetType(String))
                dt.Columns.Add("ZAN1", GetType(String))
                dt.Columns.Add("ZAN2", GetType(String))
                dt.Columns.Add("ZAN3", GetType(String))
                dt.Columns.Add("PLAN_CNT", GetType(Integer))

                'ViewState("Keitai")よりコンボのINDEX取得
                For j = 0 To UBound(strT_K, 2)
                    If ViewState("Keitai") = strT_K(0, j) Then
                        Exit For
                    End If
                Next
                If j > UBound(strT_K, 2) Then
                    j = 0
                End If

                Do While oReader.Read
                    If GetString(oReader, 2) = KYUJITU Then
                        'コンボ.Index=0→休日
                        dt.Rows.Add(GetString(oReader, 0), GetString(oReader, 1), 0, 0, 0, 0)
                    Else
                        dt.Rows.Add(GetString(oReader, 0), GetString(oReader, 1), j, 0, 0, 0)
                    End If
                    i = i + 1
                Loop
                grdList.DataSource = dt
                Me.grdList.DataBind()
                'コンボ内容によるラベルの設定(BINDではラベルが有効にならないため)
                For Each oRow As DataGridItem In Me.grdList.Items
                    CType(oRow.Cells(3).Controls(1), Label).Text = strT_K(1, CType(oRow.Cells(2).Controls(1), DropDownList).SelectedIndex)
                Next

                ViewState("Mode") = "INSERT"
                btnUpdate.Visible = False
                btnInsert.Visible = MedicalLib.Common.EnableInsert
                btnDel.Visible = False
                btnInsert.Attributes.Add("onclick", MedicalLib.Script.Insert)
            End If

            pnlList1.Visible = True
            pnlList2.Visible = True
            Me.udpList.Update()

        Catch tex As Threading.ThreadAbortException
            Throw
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " チェック関連 "

    Protected Sub valCode1_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        Dim sQuery As String = ""
        Try
            sQuery = ""
            sQuery += "select SCHEDULE_KB"
            sQuery += "     , ST_OPERATION_FORM"
            sQuery += "     , FACILITIES_NM"
            sQuery += "     , FACILITIES_NO"
            sQuery += "  from FACILITIES_MST"
            sQuery += " where FACILITIES_CD = :K01"
            _oDatabase.CreateParam("K01", args.Value.Trim())
            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    Me.lblName1.Text = GetString(oReader, 2)
                    Me.lblName2.Text = GetString(oReader, 3)
                    If GetString(oReader, 0) <> "1" Then
                        DirectCast(source, CustomValidator).ErrorMessage = "スケジュール管理対象外です"
                        args.IsValid = False
                    ElseIf GetString(oReader, 1) = "" Then
                        DirectCast(source, CustomValidator).ErrorMessage = "設備マスターの標準稼働形態が未登録です"
                        args.IsValid = False
                    Else
                        ViewState("Keitai") = GetString(oReader, 1)
                        args.IsValid = True
                    End If
                Else
                    DirectCast(source, CustomValidator).ErrorMessage = "設備マスターに未登録です"
                    Me.lblName1.Text = ""
                    Me.lblName2.Text = ""
                    args.IsValid = False
                End If
            End Using
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    Protected Sub valDate2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        Dim sQuery As String = ""
        Dim IsCLND As Boolean = False
        Dim sMode As String = ""
        Dim sdate As String

        Try
            'カレンダーマスタに存在しているか？
            sQuery = "SELECT C_DAY FROM CALENDAR_MST WHERE C_YEAR = :K01 AND C_MONTH = :K02"
            _oDatabase.CreateParam("K01", Left(args.Value.Trim(), 4))
            _oDatabase.CreateParam("K02", Right(args.Value.Trim(), 2))
            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                args.IsValid = oReader.HasRows
            End Using
            If args.IsValid = False Then
                DirectCast(source, CustomValidator).ErrorMessage = "カレンダーマスターが未登録です"
                Exit Sub
            End If

            '設備コード
            If (Me.valCode1.IsValid = True And Me.valCode2.IsValid = True) Or rdoSel2.Checked Then
                '前月算出
                If CInt(Right(args.Value.Trim, 2)) - 1 = 0 Then
                    sdate = CStr(CInt(Left(args.Value.Trim, 4)) - 1) & "12"
                Else
                    sdate = Left(args.Value.Trim, 4) & Format(CInt(Right(args.Value.Trim, 2)) - 1, "00")
                End If

                sQuery = ""
                sQuery += "select COUNT(*) AS CNT_ALL"
                sQuery += "     , SUM(CASE SUBSTR(C_DATE,1,6) WHEN :K02 THEN 1 ELSE 0 END) AS CNT_TOUGETU"
                sQuery += "     , SUM(CASE SUBSTR(C_DATE,1,6) WHEN :K03 THEN 1 ELSE 0 END) AS CNT_ZENGETU"
                sQuery += "  from FACILITIES_CLND_MST"
                If Me.rdoSel1.Checked = True Then
                    sQuery += " where FACILITIES_CD = :K01"
                    sQuery += " group by FACILITIES_CD"
                    _oDatabase.CreateParam("K01", txtCode.Text.Trim)
                End If
                _oDatabase.CreateParam("K02", args.Value.Trim())
                _oDatabase.CreateParam("K03", sdate)
                Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        If GetInt32(oReader, 0) > 0 And GetInt32(oReader, 1) = 0 And GetInt32(oReader, 2) = 0 Then
                            '既に登録があり、当月データがなく、前月データがない時
                            args.IsValid = False
                            DirectCast(source, CustomValidator).ErrorMessage = "前月度の設備カレンダーが未登録です"
                        End If
                    End If
                End Using
            End If

            If Me.rdoSel2.Checked Then
                Dim sb As New StringBuilder
                sb.AppendLine("select count(*)")
                sb.AppendLine("  from MANUFACT_PLAN_TBL")
                sb.AppendLine(" where (SCHEDULE_ST_DT between :K01 and :K02)")
                sb.AppendLine("    or (SCHEDULE_ED_DT between :K01 and :K02)")
                _oDatabase.CreateParam("K01", Me.txtdate.Text.Trim & "01")
                _oDatabase.CreateParam("K02", Me.txtdate.Text.Trim & "31")
                Using oCnt As OracleDataReader = _oDatabase.CreateReaderParam(sb.ToString)
                    If oCnt.Read Then
                        If GetInt32(oCnt, 0) > 0 Then
                            DirectCast(source, CustomValidator).ErrorMessage = "既に計画されている月のため初期化できません"
                            args.IsValid = False
                        End If
                    End If
                End Using
            End If


            'MODEの設定（設備カレンダーマスターに該当年月が存在するか？）
            If rdoSel2.Checked Then
                sQuery = "SELECT FACILITIES_CD FROM FACILITIES_CLND_MST WHERE SUBSTR(C_DATE,1,6) = :K01"
                _oDatabase.CreateParam("K01", args.Value.Trim)
                Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.HasRows = True Then
                        ViewState("Mode") = "DEL"
                    Else
                        ViewState("Mode") = "INS"
                    End If
                End Using
            End If

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '明細チェック
    Protected Sub valInput_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        '形態全行()
        '残業1＜2＜3
        Dim ddlZan1 As DropDownList
        Dim ddlZan2 As DropDownList
        Dim ddlZan3 As DropDownList
        Dim iZan1 As Integer
        Dim iZan2 As Integer
        Dim iZan3 As Integer
        Dim IsValid As Boolean = True
        Dim iRow As Integer
        Dim i As Integer

        iRow = 0
        args.IsValid = True
        For Each oRow As DataGridItem In Me.grdList.Items
            iRow = iRow + 1
            ddlZan1 = CType(oRow.Cells(4).Controls(1), DropDownList)
            ddlZan2 = CType(oRow.Cells(6).Controls(1), DropDownList)
            ddlZan3 = CType(oRow.Cells(8).Controls(1), DropDownList)
            iZan1 = ddlZan1.SelectedIndex
            iZan2 = ddlZan2.SelectedIndex
            iZan3 = ddlZan3.SelectedIndex

            '最初の一件目が見つかるまで
            If args.IsValid = True Then
                '------------------------------------------------------------------
                '大小関係,空白
                If (iZan3 > 0) AndAlso ((iZan2 = 0) Or (iZan3 <= iZan2)) Then
                    '3があるとき2がないか、2以下の時ｴﾗｰ
                    IsValid = False
                End If
                If (iZan2 > 0) AndAlso ((iZan1 = 0) Or (iZan2 <= iZan1)) Then
                    '2があるとき1がないか、1以下の時ｴﾗｰ
                    IsValid = False
                End If
                '------------------------------------------------------------------
                If IsValid = False Then
                    DirectCast(source, CustomValidator).ErrorMessage = "残業形態の選択が正しくありません(" & iRow & "行目)"
                    args.IsValid = IsValid
                End If
            End If

            'コンボIndexよりラベル再設定
            strT_Z = Session("strT_Z")
            If iZan1 > 0 Then
                For i = 0 To UBound(strT_Z, 2)
                    If ddlZan1.SelectedValue = strT_Z(0, i) Then
                        CType(oRow.Cells(5).Controls(1), Label).Text = strT_Z(1, i)
                        Exit For
                    End If
                Next
            Else
                CType(oRow.Cells(5).Controls(1), Label).Text = ""
            End If
            If iZan2 > 0 Then
                For i = 0 To UBound(strT_Z, 2)
                    If ddlZan2.SelectedValue = strT_Z(0, i) Then
                        CType(oRow.Cells(7).Controls(1), Label).Text = strT_Z(1, i)
                        Exit For
                    End If
                Next
            Else
                CType(oRow.Cells(7).Controls(1), Label).Text = ""
            End If
            If iZan3 > 0 Then
                For i = 0 To UBound(strT_Z, 2)
                    If ddlZan3.SelectedValue = strT_Z(0, i) Then
                        CType(oRow.Cells(9).Controls(1), Label).Text = strT_Z(1, i)
                        Exit For
                    End If
                Next
            Else
                CType(oRow.Cells(9).Controls(1), Label).Text = ""
            End If
        Next
    End Sub

#End Region

#Region " ユーザー関数 "

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

    Public Function GetKeitai() As DataTable
        Return Session("cmbT_K")
    End Function

    Public Function GetZangyou() As DataTable
        Return Session("cmbT_Z")
    End Function

    Public Function GetSelectedIndex(ByVal sFlag As Object) As Integer
        Dim i As Integer

        If sFlag Is DBNull.Value Then
            '0件目（スペース）表示
            Return CType(0, Integer)
        End If

        '65-90 ASCII(小文字97-122)
        If sFlag >= "A" And sFlag <= "Z" Then
            Dim code1 As Integer = Asc(sFlag)
            Return code1 - 65 + 4
        Else
            If sFlag >= "0" And sFlag <= "6" Then
                i = CType(sFlag, Integer)

            ElseIf sFlag <= "9" Then
                i = CType(sFlag, Integer) - 6
            End If
            Return i
        End If
        Return CType(sFlag, Integer)
    End Function

    'ドロップダウンリストの中身の取得
    Private Sub GetDdlItem()

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim j As Integer
        Dim strJikan As String = ""

        '形態コンボ内容取得
        j = 0
        cmbT_K.Columns.Add("CODE", GetType(System.String))
        cmbT_K.Columns.Add("NAME", GetType(System.String))
        cmbT_K.PrimaryKey = New DataColumn() {cmbT_K.Columns("CODE")}

        sQuery = "SELECT OPE_FORM_CD,OPE_FORM_NAM,OPE_START1,OPE_END1,OPE_START2,OPE_END2,OPE_START3,OPE_END3 FROM ST_OPERATION_FORM_MST WHERE OPE_FLG = :K01 ORDER BY OPE_FORM_CD"
        _oDatabase.CreateParam("K01", "0")
        oReader = _oDatabase.CreateReaderParam(sQuery)
        Do While oReader.Read
            strJikan = ""
            If GetString(oReader, 2) <> "" Then
                strJikan = Left(GetString(oReader, 2), 2) & ":" & Right(GetString(oReader, 2), 2) & "～" & Left(GetString(oReader, 3), 2) & ":" & Right(GetString(oReader, 3), 2)
                If GetString(oReader, 4) <> "" Then
                    strJikan = strJikan & " " & Left(GetString(oReader, 4), 2) & ":" & Right(GetString(oReader, 4), 2) & "～" & Left(GetString(oReader, 5), 2) & ":" & Right(GetString(oReader, 5), 2)
                    If GetString(oReader, 6) <> "" Then
                        strJikan = strJikan & " " & Left(GetString(oReader, 6), 2) & ":" & Right(GetString(oReader, 6), 2) & "～" & Left(GetString(oReader, 7), 2) & ":" & Right(GetString(oReader, 7), 2)
                    End If
                End If
            End If
            '形態
            Dim r As DataRow = cmbT_K.NewRow
            r(0) = GetString(oReader, 0)
            r(1) = GetString(oReader, 1)
            cmbT_K.Rows.Add(r)

            '配列
            ReDim Preserve strT_K(1, j)
            strT_K(0, j) = GetString(oReader, 0)
            strT_K(1, j) = strJikan
            j = j + 1
        Loop
        Session("cmbT_K") = cmbT_K
        Session("strT_K") = strT_K

        '残業コンボ内容取得
        j = 0
        cmbT_Z.Columns.Add("Z_CODE", GetType(System.String))
        cmbT_Z.Columns.Add("Z_NAME", GetType(System.String))
        cmbT_Z.PrimaryKey = New DataColumn() {cmbT_Z.Columns("Z_CODE")}

        '標準稼働形態マスタよりコンボに表示するデータ取得
        Dim r1 As DataRow = cmbT_Z.NewRow
        r1(0) = ""
        r1(1) = ""
        cmbT_Z.Rows.Add(r1)
        ReDim Preserve strT_Z(1, j)
        strT_Z(0, j) = "0"
        strT_Z(1, j) = ""
        j = j + 1

        sQuery = "SELECT OPE_FORM_CD,OPE_FORM_NAM,OPE_START1,OPE_END1 FROM ST_OPERATION_FORM_MST WHERE OPE_FLG = :K01 ORDER BY OPE_FORM_CD"
        _oDatabase.CreateParam("K01", "1")
        oReader = _oDatabase.CreateReaderParam(sQuery)
        Do While oReader.Read
            If GetString(oReader, 2) <> "" Then
                strJikan = Left(GetString(oReader, 2), 2) & ":" & Right(GetString(oReader, 2), 2) & "～" & Left(GetString(oReader, 3), 2) & ":" & Right(GetString(oReader, 3), 2)
            Else
                strJikan = ""
            End If

            '残業
            Dim r As DataRow = cmbT_Z.NewRow
            r(0) = GetString(oReader, 0)
            r(1) = GetString(oReader, 1)
            cmbT_Z.Rows.Add(r)

            '配列
            ReDim Preserve strT_Z(1, j)
            strT_Z(0, j) = GetString(oReader, 0)
            strT_Z(1, j) = strJikan
            j = j + 1
        Loop
        Session("cmbT_Z") = cmbT_Z
        Session("strT_Z") = strT_Z
    End Sub

#End Region

End Class
