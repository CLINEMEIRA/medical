﻿Imports System.Data 
Imports System.Data.OracleClient 
Imports System.Drawing 
 
Partial Class master_mdmas1001
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS100"
    Private Const PROGRAM_TITLE As String = "設備マスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "FACILITIES_MST"
    Private Const TABLE_NAME_JP As String = "設備マスタ"

    'CallBack 
    Public _sCallBackScript As String = ""
    Private _sValue As String = ""

#Region " ページ "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            Dim sql As String
            Dim oDataReader As OracleDataReader

            If Not Page.IsPostBack Then
                'SHOPコンボ設定 
                ddlShop.Items.Add(New ListItem("", ""))
                sql = "SELECT SHOP,SHOP_NM FROM SHOP_MST ORDER BY SHOP"
                oDataReader = _oDatabase.CreateReader(sql)
                Do While oDataReader.Read
                    ddlShop.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.GetString(0)))
                Loop
                oDataReader.Close()

                '時間区分コンボ設定 
                ddlJikanKubun.Items.Add(New ListItem("", ""))
                sql = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS007' ORDER BY TELL_CD"
                oDataReader = _oDatabase.CreateReader(sql)
                Do While oDataReader.Read
                    ddlJikanKubun.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.GetString(0)))
                Loop
                oDataReader.Close()

                '計算単位コンボ設定 
                ddlKeisanTanni.Items.Add(New ListItem("", ""))
                sql = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS008' ORDER BY TELL_CD"
                oDataReader = _oDatabase.CreateReader(sql)
                Do While oDataReader.Read
                    ddlKeisanTanni.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.GetString(0)))
                Loop
                oDataReader.Close()

                '生産ラインコンボ設定 20120229追加
                ddlSeisanLine.Items.Add(New ListItem("", ""))
                sql = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS037' ORDER BY TELL_CD"
                oDataReader = _oDatabase.CreateReader(sql)
                Do While oDataReader.Read
                    ddlSeisanLine.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.GetString(0)))
                Loop
                oDataReader.Close()

                '標準稼動形態コンボ設定 20120229追加
                ddlKadokei.Items.Add(New ListItem("", ""))
                sql = "SELECT OPE_FORM_CD,OPE_FORM_NAM,"
                sql += "OPE_START1,OPE_END1,"
                sql += "OPE_START2,OPE_END2,"
                sql += "OPE_START3,OPE_END3 "
                sql += "FROM ST_OPERATION_FORM_MST"
                oDataReader = _oDatabase.CreateReader(sql)
                Do While oDataReader.Read
                    Dim W_item As String = ""
                    If GetString(oDataReader, 2) <> "" Then
                        W_item += Mid(oDataReader.GetString(2), 1, 2) + ":" + Mid(oDataReader.GetString(2), 3, 4) + "～" + _
                                    Mid(oDataReader.GetString(3), 1, 2) + ":" + Mid(oDataReader.GetString(3), 3, 4) + " "
                    End If
                    If GetString(oDataReader, 4) <> "" Then
                        W_item += Mid(oDataReader.GetString(4), 1, 2) + ":" + Mid(oDataReader.GetString(4), 3, 4) + "～" + _
                                    Mid(oDataReader.GetString(5), 1, 2) + ":" + Mid(oDataReader.GetString(5), 3, 4) + " "
                    End If
                    If GetString(oDataReader, 6) <> "" Then
                        W_item += Mid(oDataReader.GetString(6), 1, 2) + ":" + Mid(oDataReader.GetString(6), 3, 4) + "～" + _
                                    Mid(oDataReader.GetString(7), 1, 2) + ":" + Mid(oDataReader.GetString(7), 3, 4) + " "
                    End If
                    ddlKadokei.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1) + " " + W_item, _
                                                      oDataReader.GetString(0)))
                Loop
                oDataReader.Close()
            End If

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

        Dim sMode As String = "i"
        Dim sCode As String = ""
        Dim sKey1 As String = ""
        Dim sKey2 As String = ""
        Dim sPage As String = "0"
        If Not Page.IsPostBack Then
            If Not Request.QueryString("mode") Is Nothing Then sMode = Request.QueryString("mode")
            If Not Request.QueryString("code") Is Nothing Then sCode = Request.QueryString("code")
            If Not Request.QueryString("key1") Is Nothing Then sKey1 = Request.QueryString("key1")
            If Not Request.QueryString("key2") Is Nothing Then sKey2 = Request.QueryString("key2")
            If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page")
            ViewState("mode") = sMode
            ViewState("code") = sCode
            ViewState("key1") = sKey1
            ViewState("key2") = sKey2
            ViewState("page") = sPage
            If sMode.Equals("u") Then
                DisplayShow()
                txtName.Focus()
            Else
                txtCode.Focus()
            End If
            If sMode.Equals("i") Then
                imgProcessTitle.ImageUrl = "../image/t_insert.gif"
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Insert())
                cmdRun.Attributes("src") = "../image/b_insert.gif"
                cmdRun.Visible = MedicalLib.Common.EnableInsert
            Else
                imgProcessTitle.ImageUrl = "../image/t_update.gif"
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Update())
                cmdRun.Attributes("src") = "../image/b_update.gif"
                cmdRun.Visible = MedicalLib.Common.EnableUpdate
            End If
            cmdDel.Visible = Not sMode.Trim.Equals("i") And MedicalLib.Common.EnableDelete
            cmdDel.Attributes.Add("onclick", MedicalLib.Script.Delete())
        End If
        CheckSche_chen() '20120301 追加

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region " ボタン "

    '登録＆修正ボタン押下処理 
    Protected Sub cmdRun_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdRun.Click
        valCode3.Enabled = ViewState("mode").Equals("i")
        Page.Validate("check")
        If Page.IsValid Then
            Dim sQuery As String = ""
            Try
                _oDatabase.BeginTrans()
                '追加/更新
                '20120229追加S***********************************
                Dim sche As String
                If CheckSche.Checked = False Then
                    sche = "0"
                Else
                    sche = "1"
                End If
                '20120229追加E***********************************
                If ViewState("mode").Trim.Equals("i") Then

                    'マスタ更新履歴テーブル追加
                    InsertHistory(txtCode.Text.Trim)

                    sQuery = "INSERT INTO FACILITIES_MST VALUES (:F01,:F02,:F03,          :F06,:F07,:F08," +
                                                            ":F09,:F10,:F11,:F12,:F13,:F14,:F15,:F16,:F17,:F18,:F19,:F20)"
                    _oDatabase.CreateParam("F01", txtCode.Text.Trim())
                    _oDatabase.CreateParam("F02", txtName.Text.Trim())
                    _oDatabase.CreateParam("F03", ddlShop.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F04", txtBoka.Text.Trim()) 
                    'If txtDay.Text.Trim.Equals("") Then 
                    '    _oDatabase.CreateParam("F05", "00000000") 
                    'Else 
                    '    _oDatabase.CreateParam("F05", txtDay.Text.Trim()) 
                    'End If 
                    _oDatabase.CreateParam("F06", txtCom.Text.Trim())
                    _oDatabase.CreateParam("F07", ddlJikanKubun.SelectedValue.Trim())
                    _oDatabase.CreateParam("F08", ddlKeisanTanni.SelectedValue.Trim())
                    _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F11", Session("UserID"))
                    _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F13", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F14", Session("UserID"))
                    _oDatabase.CreateParam("F15", MedicalLib.Common.ProgramID)
                    '20120229追加S***********************************
                    _oDatabase.CreateParam("F16", sche.Trim())
                    _oDatabase.CreateParam("F17", txtSetsubi.Text.Trim())
                    _oDatabase.CreateParam("F18", ddlSeisanLine.SelectedValue.Trim())
                    _oDatabase.CreateParam("F19", ddlKadokei.SelectedValue.Trim())
                    '20120229追加E***********************************
                    If txtSeiLineN.Text = "" Then txtSeiLineN.Text = 0 '201200307追加
                    _oDatabase.CreateParam("F20", txtSeiLineN.Text) '201200307追加
                Else
                    Page.Validate("update")
                    If Not Page.IsValid Then Exit Sub

                    'マスタ更新履歴テーブル追加
                    UpdateHistory()

                    sQuery = "UPDATE FACILITIES_MST SET "
                    sQuery += "FACILITIES_NM = :F01,"
                    sQuery += "SHOP = :F02,"
                    'sQuery += "簿価 = :F03," 
                    'sQuery += "入手日付 = :F04," 
                    sQuery += "MAKER_NM = :F05,"
                    sQuery += "WORK_TIME_KB = :F06,"
                    sQuery += "WORK_RATE = :F07,"
                    sQuery += "UPD_DT = :F08,"
                    sQuery += "UPD_TIME = :F09,"
                    sQuery += "UPD_USR = :F10,"
                    sQuery += "UPD_PROGRAM_ID = :F11,"
                    '20120229追加S***********************************
                    sQuery += "SCHEDULE_KB = :F12,"
                    sQuery += "FACILITIES_NO = :F13,"
                    sQuery += "PRODUCTION_LINE = :F14,"
                    sQuery += "ST_OPERATION_FORM = :F15,"
                    '20120229追加E***********************************
                    sQuery += "PRODUCTION_LINE_NO = :F16 " '201200307追加
                    sQuery += "WHERE FACILITIES_CD = :K01"
                    _oDatabase.CreateParam("F01", txtName.Text.Trim())
                    _oDatabase.CreateParam("F02", ddlShop.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F03", txtBoka.Text.Trim()) 
                    'If txtDay.Text.Trim.Equals("") Then 
                    '    _oDatabase.CreateParam("F04", "00000000") 
                    'Else 
                    '    _oDatabase.CreateParam("F04", txtDay.Text.Trim()) 
                    'End If 
                    _oDatabase.CreateParam("F05", txtCom.Text.Trim())
                    _oDatabase.CreateParam("F06", ddlJikanKubun.SelectedValue.Trim())
                    _oDatabase.CreateParam("F07", ddlKeisanTanni.SelectedValue.Trim())
                    _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F10", Session("UserID"))
                    _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)
                    '20120229追加S***********************************
                    _oDatabase.CreateParam("F12", sche.Trim())
                    _oDatabase.CreateParam("F13", txtSetsubi.Text.Trim())
                    _oDatabase.CreateParam("F14", ddlSeisanLine.SelectedValue.Trim())
                    _oDatabase.CreateParam("F15", ddlKadokei.SelectedValue.Trim())
                    '20120229追加E***********************************
                    If txtSeiLineN.Text = "" Then txtSeiLineN.Text = 0 '201200307追加
                    _oDatabase.CreateParam("F16", txtSeiLineN.Text) '201200307追加
                    _oDatabase.CreateParam("K01", txtCode.Text.Trim())
                End If
                _oDatabase.ExecuteNonQueryParam(sQuery)
                _oDatabase.CommitTrans()
                GoBack()
            Catch ex As Exception
                _oDatabase.Rollback()
                MedicalLib.PageError.Show(ex.Message)
            End Try
        Else
        End If
    End Sub

    '削除ボタン押下処理 
    Protected Sub cmdDel_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdDel.Click
        valCode3.Enabled = False
        Page.Validate("check")
        If Page.IsValid Then
            Page.Validate("update")
            If Not Page.IsValid() Then Exit Sub
            Try         '削除 
                _oDatabase.BeginTrans()

                'マスタ更新履歴テーブル追加
                DeleteHistory()

                Dim sQuery As String = "DELETE FROM FACILITIES_MST WHERE FACILITIES_CD = :K01"

                _oDatabase.CreateParam("K01", txtCode.Text.Trim())
                _oDatabase.ExecuteNonQueryParam(sQuery)
                _oDatabase.CommitTrans()
                GoBack()
            Catch ex As Exception
                _oDatabase.Rollback()
                MedicalLib.PageError.Show(ex.Message)
            End Try
        End If
    End Sub

    '戻るボタン押下処理 
    Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdBack.Click
        GoBack()
    End Sub

    Protected Sub cmdClear_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdClear.Click
        If ViewState("mode").Equals("u") Then
            DisplayShow()
        Else
            txtCode.Text = ""
            txtName.Text = ""
            ddlShop.SelectedValue = ViewState("shop")
            txtCom.Text = ""
            ddlJikanKubun.SelectedValue = ""
            ddlKeisanTanni.SelectedValue = ""
            txtSeiLineN.Text = 0
            txtSetsubi.Text = ""
            ddlSeisanLine.SelectedValue = ""
            ddlKadokei.SelectedValue = ""
            CheckSche.Checked = False
        End If
        CheckSche_chen() '20120301 追加

    End Sub
#End Region

#Region " ユーザー関数 "

    Private Sub DisplayShow()
        Try
            Dim sQuery As String = ""
            sQuery += "SELECT FACILITIES_CD,FACILITIES_NM,SHOP,MAKER_NM,WORK_TIME_KB,WORK_RATE,SCHEDULE_KB,FACILITIES_NO,PRODUCTION_LINE,ST_OPERATION_FORM,PRODUCTION_LINE_NO,UPD_DT||UPD_TIME "
            sQuery += "FROM FACILITIES_MST WHERE FACILITIES_CD = :K01"
            _oDatabase.CreateParam("K01", ViewState("code"))
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                txtCode.Text = oReader.GetString(0).Trim()
                txtCode.Enabled = False
                txtName.Text = oReader.GetString(1).Trim()
                If Not oReader.IsDBNull(2) Then
                    ddlShop.SelectedValue = oReader.GetString(2).Trim()
                    ViewState("shop") = oReader.GetString(2).Trim()
                End If
                If Not oReader.IsDBNull(3) Then txtCom.Text = oReader.GetString(3).Trim()
                If Not oReader.IsDBNull(4) Then
                    ddlJikanKubun.SelectedValue = oReader.GetString(4).Trim()
                    ViewState("kubun") = oReader.GetString(4).Trim()
                End If
                If Not oReader.IsDBNull(5) Then
                    ddlKeisanTanni.SelectedValue = oReader.GetString(5).Trim()
                    ViewState("tanni") = oReader.GetString(5).Trim()
                End If

                '20120229 追加S*****************
                If Not oReader.IsDBNull(6) Then
                    If oReader.GetString(6) = "1" Then
                        CheckSche.Checked = True
                    Else
                        CheckSche.Checked = False
                    End If
                    ViewState("sche") = oReader.GetString(6).Trim()
                End If
                If Not oReader.IsDBNull(7) Then
                    txtSetsubi.Text = oReader.GetString(7).Trim()
                    ViewState("faci") = oReader.GetString(7).Trim()
                Else
                    txtSetsubi.Text = ""
                    ViewState("faci") = ""
                End If
                If Not oReader.IsDBNull(8) Then
                    ddlSeisanLine.SelectedValue = oReader.GetString(8).Trim()
                    ViewState("prod") = oReader.GetString(8).Trim()
                End If
                If Not oReader.IsDBNull(9) Then
                    ddlKadokei.SelectedValue = oReader.GetString(9).Trim()
                    ViewState("oper") = oReader.GetString(9).Trim()
                End If
                '20120229 追加E*****************
                If Not oReader.IsDBNull(10) Then
                    txtSeiLineN.Text = oReader.GetInt32(10)
                    ViewState("prodn") = oReader.GetInt32(10)
                End If

                ViewState("update") = oReader.GetString(11).Trim()
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub
    'ゼロ入力 チェック2  20123007追加
    Friend Sub CheckZero(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valSeiLineN4.ServerValidate
        If IsNumeric(txtSeiLineN.Text) Then
            If txtSeiLineN.Text = 0 Then
                e.IsValid = False
            Else
                e.IsValid = True
            End If
        End If
    End Sub

    'バイト チェック2  20123007追加
    Friend Sub CheckByte2(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valSeiLineN1.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 2 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    'バイト チェック20 
    Friend Sub CheckByte20(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valCom.ServerValidate, valSetsubi2.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 20 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    'バイト チェック24 
    Friend Sub CheckByte24(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valName2.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 24 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    'バイト チェック24_2 20120229追加
    Friend Sub CheckByte24_2(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valSetsubi2.ServerValidate
        '設備No.の文字数チェック
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 24 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    '設備コード 存在チェック 
    Friend Sub CheckCode(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valCode3.ServerValidate
        Try
            Dim sQuery As String = "SELECT * FROM FACILITIES_MST WHERE FACILITIES_CD = :K01"
            _oDatabase.CreateParam("K01", txtCode.Text.Trim)
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = Not oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM FACILITIES_MST WHERE FACILITIES_CD = :K01 "
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", ViewState("code"))
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

    Private Sub GoBack()
        Response.Redirect("mdmas100.aspx?key1=" + ViewState("key1") + "&key2=" + ViewState("key2") + "&page=" + ViewState("page"), False)
    End Sub

    Private Sub CheckSche_chen()
        'スケジュール管理チェックボックス  20120229追加
        If CheckSche.Checked = True Then
            'チェックの場合
            valSeisanLine.Enabled = True
            valSetsubi1.Enabled = True
            valSetsubi2.Enabled = True
            valKadokei.Enabled = True
            valSeiLineN3.Enabled = True
            valSeiLineN4.Enabled = True
            txtSetsubi.BackColor = Color.FromArgb(255, 255, 192)
            ddlSeisanLine.BackColor = Color.FromArgb(255, 255, 192)
            ddlKadokei.BackColor = Color.FromArgb(255, 255, 192)
            txtSeiLineN.BackColor = Color.FromArgb(255, 255, 192)
            UpdatePanel1.Update()
        Else
            '非チェックの場合
            valSeisanLine.Enabled = False
            valSetsubi1.Enabled = False
            valSetsubi2.Enabled = False
            valKadokei.Enabled = False
            valSeiLineN3.Enabled = False
            valSeiLineN4.Enabled = False
            txtSetsubi.BackColor = Color.White
            ddlSeisanLine.BackColor = Color.White
            ddlKadokei.BackColor = Color.White
            txtSeiLineN.BackColor = Color.White
            UpdatePanel1.Update()
        End If
    End Sub

#End Region

#Region " その他 "

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
        '20120229追加S***********************************
        Dim sche As String
        If CheckSche.Checked = False Then
            sche = "0"
        Else
            sche = "1"
        End If
        '20120229追加E***********************************
        Dim sGenValues() As String = (txtName.Text.Trim() + "," + ddlShop.SelectedValue + "," + txtCom.Text.Trim() + "," + ddlJikanKubun.SelectedValue + "," + ddlKeisanTanni.SelectedValue + "," + _
                                        vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + _
                                        sche + "," + txtSetsubi.Text.Trim() + "," + ddlSeisanLine.SelectedValue + "," + ddlKadokei.SelectedValue + "," + txtSeiLineN.Text).Split(",")
        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) Then
                Select Case i
                    Case 0      '設備名称
                        InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i))
                    Case 1      'SHOP
                        InsertMH(sItemNames(i), GetShopName(sMotoValues(i)), GetShopName(sGenValues(i)))
                    Case 2      '製造会社名
                        InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i))
                    Case 3      '稼働時間区分
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS007"), GetHanyouName(sGenValues(i), "MS007"))
                    Case 4      '稼動計算単位
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS008"), GetHanyouName(sGenValues(i), "MS008"))
                        '20120229追加S***********************************
                    Case 12     'スケジュール管理区分
                        InsertMH(sItemNames(i), GetScheName(sMotoValues(i)), GetScheName(sGenValues(i)))
                    Case 13     '設備No
                        InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i))
                    Case 14     '生産ライン
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS037"), GetHanyouName(sGenValues(i), "MS037"))
                    Case 15     '標準稼働形態
                        InsertMH(sItemNames(i), GetOpeName(sMotoValues(i)), GetOpeName(sGenValues(i)))
                        '20120229追加E***********************************
                    Case 16     '生産ライン順序
                        InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i)) '20120307追加
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
                If GetString(oReader, 1) <> "設備コード" Then   '主キー以外
                    'If GetString(oReader, 1) = "登録日付" Then
                    '    Exit While
                    'Else
                    '項目追加により全項目対象 20120229
                    sResult += GetString(oReader, 1) + ","
                    'End If
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
        Dim iKeySu As Integer = 1       '主キー項目数
        Dim sResult As String = ""
        Try
            sQuery = "SELECT * FROM FACILITIES_MST WHERE FACILITIES_CD = :KEY1"
            _oDatabase.CreateParam("KEY1", ViewState("code"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                For i = iKeySu To iItemSu - 1 + iKeySu
                    If i = 17 Then
                        sResult += GetInt32(oReader, i).ToString + ","
                    Else
                        sResult += GetString(oReader, i) + ","
                    End If
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
        InsertMH(ViewState("code"), sItemName, sMae, sAto)
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

    '汎用 名付き
    Private Function GetHanyouName(ByVal sKey As String, ByVal sInfo As String) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sResult As String = ""
        Try
            sQuery += "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE TELL_CD = :K01 AND INFO_KB = :K02 "
            _oDatabase.CreateParam("K01", sKey)
            _oDatabase.CreateParam("K02", sInfo)

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

    'スケジュール管理区分名付き 20120229追加
    Private Function GetScheName(ByVal sKey As String) As String
        Dim sResult As String = ""
        If sKey = "0" Then
            sResult = sKey + ":しない"
        Else
            sResult = sKey + ":する"
        End If
        Return sResult
    End Function

    '稼動形態名付き 20120229追加
    Private Function GetOpeName(ByVal sKey As String) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sResult As String = ""
        Try
            sQuery += "SELECT OPE_FORM_CD, OPE_FORM_NAM FROM ST_OPERATION_FORM_MST WHERE OPE_FORM_CD = :K01"
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
 
