Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing

Partial Class master_mdmas0601 
    Inherits System.Web.UI.Page 
    Implements System.Web.UI.ICallbackEventHandler 
 
    Private Const PROGRAM_ID As String = "MDMAS060" 
    Private Const PROGRAM_TITLE As String = "主材料マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "MATL_MST"
    Private Const TABLE_NAME_JP As String = "主材料マスタ"
 
    'CallBack 
    Public _sCallBackScript As String = "" 
    Private _sCode As String = "" 
 
#Region " ページ " 
 
    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
 
            'CallBack 
            _sCallBackScript = Page.ClientScript.GetCallbackEventReference( _ 
                         Me, "command", "getNameCallBack", "context", "getNameCallBackError", False) 
 
            If Not Page.IsPostBack Then

                'ドロップダウンリストセット
                SetDropDownList()
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

        Dim sMode As String = "i"
        Dim sCode1 As String = ""
        Dim sCode2 As String = ""
        Dim sKey1 As String = ""
        Dim sKey2 As String = ""
        Dim sKey3 As String = ""
        Dim sPage As String = "0"
        If Not Page.IsPostBack Then
            If Not Request.QueryString("mode") Is Nothing Then sMode = Request.QueryString("mode")
            If Not Request.QueryString("code1") Is Nothing Then sCode1 = Request.QueryString("code1")
            If Not Request.QueryString("code2") Is Nothing Then sCode2 = Request.QueryString("code2")
            If Not Request.QueryString("key1") Is Nothing Then sKey1 = Request.QueryString("key1")
            If Not Request.QueryString("key2") Is Nothing Then sKey2 = Request.QueryString("key2")
            If Not Request.QueryString("key3") Is Nothing Then sKey3 = Request.QueryString("key3")
            If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page")
            ViewState("mode") = sMode
            ViewState("code1") = sCode1
            ViewState("code2") = sCode2
            ViewState("key1") = sKey1
            ViewState("key2") = sKey2
            ViewState("key3") = sKey3
            ViewState("page") = sPage
            If sMode.Equals("u") Then
                DisplayShow(ViewState("code1"), ViewState("code2"))
                lblRen.Focus()
            Else
                txtSCode.Focus()
            End If
            If sMode.Equals("i") Then
                imgProcessTitle.ImageUrl = "../image/t_insert.gif"
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Insert())
                cmdRun.Attributes("src") = "../image/b_insert.gif"
                cmdRun.Visible = MedicalLib.Common.EnableInsert

                '**** 2012/12 連NOを取得(取得のみでカウントアップしない)
                Me.lblRen.Text = _oDatabase.GetNumberNoUpdate(MedicalLib.DataAccess.Saiban.ZR).ToString
            Else
                imgProcessTitle.ImageUrl = "../image/t_update.gif"
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Update())
                cmdRun.Attributes("src") = "../image/b_update.gif"
                cmdRun.Visible = MedicalLib.Common.EnableUpdate
            End If
            cmdDel.Visible = Not sMode.Trim.Equals("i") And MedicalLib.Common.EnableDelete
            cmdDel.Attributes.Add("onclick", MedicalLib.Script.Delete())
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

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        Dim sReturnValue As String
        Dim sQuery As String = "SELECT CONTRACTOUT_CD,CONTRACTOUT_NM FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :K01"
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

    '登録＆修正ボタン押下処理 
    Protected Sub cmdRun_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdRun.Click
        Dim sQuery As String = ""
        'valRen3.Enabled = ViewState("mode").Equals("i") 
        Page.Validate("check")
        If Page.IsValid Then
            '追加/更新 
            Try
                _oDatabase.BeginTrans()
                If ViewState("mode").Trim.Equals("i") Then

                    '**** 2012/12 ホスト廃止対応
                    '**** 改めて連NOを取得してカウントアップ
                    Me.lblRen.Text = _oDatabase.GetNumber(MedicalLib.DataAccess.Saiban.ZR)

                    'マスタ更新履歴テーブル追加
                    InsertHistory(txtSCode.Text.Trim + ":" + Me.lblRen.Text.Trim)

                    '**** 2012/12 ホスト廃止対応 ST ****
                    sQuery += "INSERT INTO MEDPROC.MATL_MST("
                    sQuery += "  MATL_CD, REN_NO, MATL_NM, MATL_SPEC, MATL_TYPE_CD"
                    sQuery += ", SHAPE_CD, MATL_SPFT_NO, MAGNETISM, STOCK_LV, LOW_ORDER_WAT"
                    sQuery += ", COEFFICIENT, UNIT_KB, UNIT_WAT, DELIVER_TERM"
                    sQuery += ", ORDER_CD1, ORDER_CD2, ORDER_CD3, PERSONAL_MATL, SHIP_PR"
                    sQuery += ", CONFIRM_SIZE_KB1, CONFIRM_SIZE1, CONFIRM_UNIT1, CONFIRM_UP_DIFF1, CONFIRM_LOW_DIFF1"
                    sQuery += ", CONFIRM_SIZE_KB2, CONFIRM_SIZE2, CONFIRM_UNIT2, CONFIRM_UP_DIFF2, CONFIRM_LOW_DIFF2"
                    sQuery += ", CONFIRM_SIZE_KB3, CONFIRM_SIZE3, CONFIRM_UNIT3, CONFIRM_UP_DIFF3, CONFIRM_LOW_DIFF3"
                    sQuery += ", CONFIRM_SIZE_KB4, CONFIRM_SIZE4, CONFIRM_UNIT4, CONFIRM_UP_DIFF4, CONFIRM_LOW_DIFF4"
                    sQuery += ", CONFIRM_SIZE_KB5, CONFIRM_SIZE5, CONFIRM_UNIT5, CONFIRM_UP_DIFF5, CONFIRM_LOW_DIFF5"
                    sQuery += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                    sQuery += ") VALUES ("
                    sQuery += "  :F01, :F02, :F03, :F04, :F05"
                    sQuery += ", :F06, :F07, :F08, :F09, :F10"
                    sQuery += ", :F11, :F12, :F13, :F14"
                    sQuery += ", :F15, :F16, :F17, :F18, :F19"
                    sQuery += ", :F20, :F21, :F22, :F23, :F24"
                    sQuery += ", :F25, :F26, :F27, :F28, :F29"
                    sQuery += ", :F30, :F31, :F32, :F33, :F34"
                    sQuery += ", :F35, :F36, :F37, :F38, :F39"
                    sQuery += ", :F40, :F41, :F42, :F43, :F44"
                    sQuery += ", :F45, :F46, :F47, :F48, :F49, :F50, :F51"
                    sQuery += ")"

                    _oDatabase.CreateParam("F01", txtSCode.Text.Trim())
                    _oDatabase.CreateParam("F02", lblRen.Text.Trim())
                    _oDatabase.CreateParam("F03", txtName.Text.Trim())
                    _oDatabase.CreateParam("F04", txtSpec.Text.Trim())
                    _oDatabase.CreateParam("F05", ddlZCode.SelectedValue.Trim())
                    _oDatabase.CreateParam("F06", ddlKCode.SelectedValue.Trim())
                    _oDatabase.CreateParam("F07", txtSiyou.Text.Trim())
                    _oDatabase.CreateParam("F08", ddlJisei.SelectedValue.Trim())
                    _oDatabase.CreateParam("F09", txtStock.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F10", txtMin.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F11", txtKeisu.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F12", ddlUnit.SelectedValue.Trim())
                    _oDatabase.CreateParam("F13", txtWeight.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F14", txtKikan.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F15", txtHCode1.Text.Trim())
                    _oDatabase.CreateParam("F16", txtHCode2.Text.Trim())
                    _oDatabase.CreateParam("F17", txtHCode3.Text.Trim())
                    _oDatabase.CreateParam("F18", ddlSenzai.SelectedValue.Trim())
                    _oDatabase.CreateParam("F19", txtSTanka.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F20", ddlSunpo1.SelectedValue.Trim)
                    _oDatabase.CreateParam("F21", txtSunpo1.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F22", ddlUnit1.SelectedValue.Trim)
                    _oDatabase.CreateParam("F23", txtJogen1.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F24", txtKagen1.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F25", ddlSunpo2.SelectedValue.Trim)
                    _oDatabase.CreateParam("F26", txtSunpo2.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F27", ddlUnit2.SelectedValue.Trim)
                    _oDatabase.CreateParam("F28", txtJogen2.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F29", txtKagen2.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F30", ddlSunpo3.SelectedValue.Trim)
                    _oDatabase.CreateParam("F31", txtSunpo3.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F32", ddlUnit3.SelectedValue.Trim)
                    _oDatabase.CreateParam("F33", txtJogen3.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F34", txtKagen3.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F35", ddlSunpo4.SelectedValue.Trim)
                    _oDatabase.CreateParam("F36", txtSunpo4.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F37", ddlUnit4.SelectedValue.Trim)
                    _oDatabase.CreateParam("F38", txtJogen4.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F39", txtKagen4.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F40", ddlSunpo5.SelectedValue.Trim)
                    _oDatabase.CreateParam("F41", txtSunpo5.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F42", ddlUnit5.SelectedValue.Trim)
                    _oDatabase.CreateParam("F43", txtJogen5.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F44", txtKagen5.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F45", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F46", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F47", Session("UserID"))
                    _oDatabase.CreateParam("F48", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F49", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F50", Session("UserID"))
                    _oDatabase.CreateParam("F51", MedicalLib.Common.ProgramID)
                    'sQuery = "INSERT INTO MATL_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
                    '                                      ":F11,:F12,:F13,:F14,:F15,:F16,:F17,:F25,:F18,:F19,:F20," + _
                    '                                      ":F21,:F22,:F23,:F24)"
                    '_oDatabase.CreateParam("F01", txtSCode.Text.Trim())
                    '_oDatabase.CreateParam("F02", lblRen.Text.Trim())
                    '_oDatabase.CreateParam("F03", txtName.Text.Trim())
                    '_oDatabase.CreateParam("F04", txtSpec.Text.Trim())
                    '_oDatabase.CreateParam("F05", ddlZCode.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F06", ddlKCode.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F07", txtSiyou.Text.Trim())
                    '_oDatabase.CreateParam("F08", ddlJisei.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F09", txtStock.Text.Trim())
                    '_oDatabase.CreateParam("F10", txtMin.Text.Trim())
                    '_oDatabase.CreateParam("F11", txtKeisu.Text.Trim())
                    '_oDatabase.CreateParam("F12", ddlUnit.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F13", txtWeight.Text.Trim())
                    '_oDatabase.CreateParam("F14", txtKikan.Text.Trim())
                    '_oDatabase.CreateParam("F15", txtHCode1.Text.Trim())
                    '_oDatabase.CreateParam("F16", txtHCode2.Text.Trim())
                    '_oDatabase.CreateParam("F17", txtHCode3.Text.Trim())
                    '_oDatabase.CreateParam("F25", ddlSenzai.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F18", MedicalLib.Common.GetSystemDate)
                    '_oDatabase.CreateParam("F19", MedicalLib.Common.GetSystemTime)
                    '_oDatabase.CreateParam("F20", Session("UserID"))
                    '_oDatabase.CreateParam("F21", MedicalLib.Common.GetSystemDate)
                    '_oDatabase.CreateParam("F22", MedicalLib.Common.GetSystemTime)
                    '_oDatabase.CreateParam("F23", Session("UserID"))
                    '_oDatabase.CreateParam("F24", MedicalLib.Common.ProgramID)
                    '**** 2012/12 ホスト廃止対応 ED ****
                Else
                    Page.Validate("update")
                    If Not Page.IsValid Then Exit Sub

                    'マスタ更新履歴テーブル追加
                    UpdateHistory()
                    '**** 2010/05 項目追加 ST ****
                    sQuery = ""
                    sQuery += "UPDATE MATL_MST SET"
                    sQuery += "  REN_NO = :F01"
                    sQuery += ", MATL_NM = :F02"
                    sQuery += ", MATL_SPEC = :F03"
                    sQuery += ", MATL_TYPE_CD = :F04"
                    sQuery += ", SHAPE_CD = :F05"
                    sQuery += ", MATL_SPFT_NO = :F06"
                    sQuery += ", MAGNETISM = :F07"
                    sQuery += ", STOCK_LV = :F08"
                    sQuery += ", LOW_ORDER_WAT = :F09"
                    sQuery += ", COEFFICIENT = :F10"
                    sQuery += ", UNIT_KB = :F11"
                    sQuery += ", UNIT_WAT = :F12"
                    sQuery += ", DELIVER_TERM = :F13"
                    sQuery += ", ORDER_CD1 = :F14"
                    sQuery += ", ORDER_CD2 = :F15"
                    sQuery += ", ORDER_CD3 = :F16"
                    sQuery += ", PERSONAL_MATL = :F17"
                    sQuery += ", CONFIRM_SIZE_KB1 = :F18"
                    sQuery += ", CONFIRM_SIZE1 = :F19"
                    sQuery += ", CONFIRM_UNIT1 = :F20"
                    sQuery += ", CONFIRM_UP_DIFF1 = :F21"
                    sQuery += ", CONFIRM_LOW_DIFF1 = :F22"
                    sQuery += ", CONFIRM_SIZE_KB2 = :F23"
                    sQuery += ", CONFIRM_SIZE2 = :F24"
                    sQuery += ", CONFIRM_UNIT2 = :F25"
                    sQuery += ", CONFIRM_UP_DIFF2 = :F26"
                    sQuery += ", CONFIRM_LOW_DIFF2 = :F27"
                    sQuery += ", CONFIRM_SIZE_KB3 = :F28"
                    sQuery += ", CONFIRM_SIZE3 = :F29"
                    sQuery += ", CONFIRM_UNIT3 = :F30"
                    sQuery += ", CONFIRM_UP_DIFF3 = :F31"
                    sQuery += ", CONFIRM_LOW_DIFF3 = :F32"
                    sQuery += ", CONFIRM_SIZE_KB4 = :F33"
                    sQuery += ", CONFIRM_SIZE4 = :F34"
                    sQuery += ", CONFIRM_UNIT4 = :F35"
                    sQuery += ", CONFIRM_UP_DIFF4 = :F36"
                    sQuery += ", CONFIRM_LOW_DIFF4 = :F37"
                    sQuery += ", CONFIRM_SIZE_KB5 = :F38"
                    sQuery += ", CONFIRM_SIZE5 = :F39"
                    sQuery += ", CONFIRM_UNIT5 = :F40"
                    sQuery += ", CONFIRM_UP_DIFF5 = :F41"
                    sQuery += ", CONFIRM_LOW_DIFF5 = :F42"
                    sQuery += ", UPD_DT = :F43"
                    sQuery += ", UPD_TIME = :F44"
                    sQuery += ", UPD_USR = :F45"
                    sQuery += ", UPD_PROGRAM_ID  = :F46"
                    sQuery += ", SHIP_PR = :F47"            '2012/12 出庫単価追加
                    sQuery += " WHERE MATL_CD = :K01"
                    sQuery += "   AND REN_NO = :K02"
                    _oDatabase.CreateParam("F01", lblRen.Text.Trim())
                    _oDatabase.CreateParam("F02", txtName.Text.Trim())
                    _oDatabase.CreateParam("F03", txtSpec.Text.Trim())
                    _oDatabase.CreateParam("F04", ddlZCode.SelectedValue.Trim())
                    _oDatabase.CreateParam("F05", ddlKCode.SelectedValue.Trim())
                    _oDatabase.CreateParam("F06", txtSiyou.Text.Trim())
                    _oDatabase.CreateParam("F07", ddlJisei.SelectedValue.Trim())
                    _oDatabase.CreateParam("F08", txtStock.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F09", txtMin.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F10", txtKeisu.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F11", ddlUnit.SelectedValue.Trim())
                    _oDatabase.CreateParam("F12", txtWeight.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F13", txtKikan.Text.Trim().PadLeft(1, "0"))
                    _oDatabase.CreateParam("F14", txtHCode1.Text.Trim())
                    _oDatabase.CreateParam("F15", txtHCode2.Text.Trim())
                    _oDatabase.CreateParam("F16", txtHCode3.Text.Trim())
                    _oDatabase.CreateParam("F17", ddlSenzai.SelectedValue.Trim())
                    _oDatabase.CreateParam("F18", ddlSunpo1.SelectedValue.Trim)
                    _oDatabase.CreateParam("F19", txtSunpo1.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F20", ddlUnit1.SelectedValue.Trim)
                    _oDatabase.CreateParam("F21", txtJogen1.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F22", txtKagen1.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F23", ddlSunpo2.SelectedValue.Trim)
                    _oDatabase.CreateParam("F24", txtSunpo2.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F25", ddlUnit2.SelectedValue.Trim)
                    _oDatabase.CreateParam("F26", txtJogen2.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F27", txtKagen2.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F28", ddlSunpo3.SelectedValue.Trim)
                    _oDatabase.CreateParam("F29", txtSunpo3.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F30", ddlUnit3.SelectedValue.Trim)
                    _oDatabase.CreateParam("F31", txtJogen3.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F32", txtKagen3.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F33", ddlSunpo4.SelectedValue.Trim)
                    _oDatabase.CreateParam("F34", txtSunpo4.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F35", ddlUnit4.SelectedValue.Trim)
                    _oDatabase.CreateParam("F36", txtJogen4.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F37", txtKagen4.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F38", ddlSunpo5.SelectedValue.Trim)
                    _oDatabase.CreateParam("F39", txtSunpo5.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F40", ddlUnit5.SelectedValue.Trim)
                    _oDatabase.CreateParam("F41", txtJogen5.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F42", txtKagen5.Text.Trim.PadLeft(1, "0"))
                    _oDatabase.CreateParam("F43", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F44", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F45", Session("UserID"))
                    _oDatabase.CreateParam("F46", MedicalLib.Common.ProgramID)
                    _oDatabase.CreateParam("F47", txtSTanka.Text.Trim.PadLeft(1, "0"))              '2012/12 出庫単価追加
                    _oDatabase.CreateParam("K01", txtSCode.Text.Trim())
                    _oDatabase.CreateParam("K02", Request.QueryString("code2"))

                    'sQuery = "UPDATE MATL_MST SET "
                    'sQuery += "REN_NO = :F01,"
                    'sQuery += "MATL_NM = :F02,"
                    'sQuery += "MATL_SPEC = :F03,"
                    'sQuery += "MATL_TYPE_CD = :F04,"
                    'sQuery += "SHAPE_CD = :F05,"
                    'sQuery += "MATL_SPFT_NO = :F06,"
                    'sQuery += "MAGNETISM = :F07,"
                    'sQuery += "STOCK_LV = :F08,"
                    'sQuery += "LOW_ORDER_WAT = :F09,"
                    'sQuery += "COEFFICIENT = :F10,"
                    'sQuery += "UNIT_KB = :F11,"
                    'sQuery += "UNIT_WAT = :F12,"
                    'sQuery += "DELIVER_TERM = :F13,"
                    'sQuery += "PERSONAL_MATL = :F21,"
                    'sQuery += "ORDER_CD1 = :F14,"
                    'sQuery += "ORDER_CD2 = :F15,"
                    'sQuery += "ORDER_CD3 = :F16,"
                    'sQuery += "UPD_DT = :F17,"
                    'sQuery += "UPD_TIME = :F18,"
                    'sQuery += "UPD_USR = :F19,"
                    'sQuery += "UPD_PROGRAM_ID  = :F20 "
                    'sQuery += "WHERE MATL_CD = :K01 AND REN_NO = :K02"
                    '_oDatabase.CreateParam("F01", lblRen.Text.Trim())
                    '_oDatabase.CreateParam("F02", txtName.Text.Trim())
                    '_oDatabase.CreateParam("F03", txtSpec.Text.Trim())
                    '_oDatabase.CreateParam("F04", ddlZCode.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F05", ddlKCode.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F06", txtSiyou.Text.Trim())
                    '_oDatabase.CreateParam("F07", ddlJisei.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F08", txtStock.Text.Trim())
                    '_oDatabase.CreateParam("F09", txtMin.Text.Trim())
                    '_oDatabase.CreateParam("F10", txtKeisu.Text.Trim())
                    '_oDatabase.CreateParam("F11", ddlUnit.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F12", txtWeight.Text.Trim())
                    '_oDatabase.CreateParam("F13", txtKikan.Text.Trim())
                    '_oDatabase.CreateParam("F21", ddlSenzai.SelectedValue.Trim())
                    '_oDatabase.CreateParam("F14", txtHCode1.Text.Trim())
                    '_oDatabase.CreateParam("F15", txtHCode2.Text.Trim())
                    '_oDatabase.CreateParam("F16", txtHCode3.Text.Trim())
                    '_oDatabase.CreateParam("F17", MedicalLib.Common.GetSystemDate)
                    '_oDatabase.CreateParam("F18", MedicalLib.Common.GetSystemTime)
                    '_oDatabase.CreateParam("F19", Session("UserID"))
                    '_oDatabase.CreateParam("F20", MedicalLib.Common.ProgramID)
                    '_oDatabase.CreateParam("K01", txtSCode.Text.Trim())
                    '_oDatabase.CreateParam("K02", Request.QueryString("code2"))
                    '**** 2010/05 項目追加 ED ****
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
        'valRen3.Enabled = False 
        Page.Validate("check")
        If Page.IsValid Then
            Page.Validate("update")
            If Not Page.IsValid() Then Exit Sub
            '削除 
            Try
                _oDatabase.BeginTrans()

                'マスタ更新履歴テーブル追加
                DeleteHistory()

                Dim sQuery As String
                sQuery = "DELETE FROM MATL_MST WHERE MATL_CD = :K01 AND REN_NO = :K02"

                _oDatabase.CreateParam("K01", txtSCode.Text.Trim())
                _oDatabase.CreateParam("K02", lblRen.Text.Trim())
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

    'クリアボタン 
    Protected Sub cmdReset1_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdReset1.Click
        txtSCode.Text = ""
        lblRen.Text = ""
        txtName.Text = ""
        txtSpec.Text = ""
        ddlZCode.SelectedValue = ""
        ddlKCode.SelectedValue = ""
        txtSiyou.Text = ""
        ddlJisei.SelectedValue = ""
        txtStock.Text = ""
        txtMin.Text = ""
        txtKeisu.Text = ""
        ddlUnit.SelectedValue = ""
        txtWeight.Text = ""
        txtKikan.Text = ""
        ddlSenzai.SelectedValue = ""
        txtHCode1.Text = ""
        lblHCode1.Text = ""
        txtHCode2.Text = ""
        lblHCode2.Text = ""
        txtHCode3.Text = ""
        lblHCode3.Text = ""
        Me.txtSTanka.Text = ""          '2012/12 ホスト廃止対応
        '**** 2010/05 追加 ST ****
        ddlSunpo1.SelectedValue = ""
        txtSunpo1.Text = ""
        ddlSunpo1.SelectedValue = ""
        txtJogen1.Text = ""
        txtKagen1.Text = ""
        ddlSunpo2.SelectedValue = ""
        txtSunpo2.Text = ""
        ddlSunpo2.SelectedValue = ""
        txtJogen2.Text = ""
        txtKagen2.Text = ""
        ddlSunpo3.SelectedValue = ""
        txtSunpo3.Text = ""
        ddlSunpo3.SelectedValue = ""
        txtJogen3.Text = ""
        txtKagen3.Text = ""
        ddlSunpo4.SelectedValue = ""
        txtSunpo4.Text = ""
        ddlSunpo4.SelectedValue = ""
        txtJogen4.Text = ""
        txtKagen4.Text = ""
        ddlSunpo5.SelectedValue = ""
        txtSunpo5.Text = ""
        ddlSunpo5.SelectedValue = ""
        txtJogen5.Text = ""
        txtKagen5.Text = ""
        '**** 2010/05 追加 ED ****
        If ViewState("mode").Equals("u") Then
            DisplayShow(ViewState("code1"), ViewState("code2"))
        End If
    End Sub

#End Region

#Region " ユーザー関数 "

    'ドロップダウンリストセット
    Private Sub SetDropDownList()

        Dim sQuery As String = ""
        sQuery += "SELECT TELL_CD, ITEM_NM"
        sQuery += "  FROM GENERAL_PURPOSE_TBL"
        sQuery += " WHERE INFO_KB = :K01"
        sQuery += " ORDER BY TELL_CD"

        '材種の設定
        sQuery = sQuery
        _oDatabase.CreateParam("K01", "MS002")
        Using oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            ddlZCode.Items.Add(New ListItem("", ""))
            Do While oDataReader.Read
                ddlZCode.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
            Loop
        End Using

        '形状の設定
        sQuery = sQuery
        _oDatabase.CreateParam("K01", "MS003")
        Using oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            ddlKCode.Items.Add(New ListItem("", ""))
            Do While oDataReader.Read
                ddlKCode.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
            Loop
        End Using

        '磁性の設定
        sQuery = sQuery
        _oDatabase.CreateParam("K01", "MS017")
        Using oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            ddlJisei.Items.Add(New ListItem("", ""))
            Do While oDataReader.Read
                ddlJisei.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
            Loop
        End Using

        '単位区分の設定
        sQuery = sQuery
        _oDatabase.CreateParam("K01", "MS004")
        Using oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            ddlUnit.Items.Add(New ListItem("", ""))
            Do While oDataReader.Read
                ddlUnit.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
            Loop
        End Using

        '専用区分の設定
        sQuery = sQuery
        _oDatabase.CreateParam("K01", "MS024")
        Using oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            ddlSenzai.Items.Add(New ListItem("", ""))
            Do While oDataReader.Read
                ddlSenzai.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
            Loop
        End Using

        '確認寸法区分
        sQuery = sQuery
        _oDatabase.CreateParam("K01", "MS033")
        Using oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            ddlSunpo1.Items.Add(New ListItem("", ""))
            ddlSunpo2.Items.Add(New ListItem("", ""))
            ddlSunpo3.Items.Add(New ListItem("", ""))
            ddlSunpo4.Items.Add(New ListItem("", ""))
            ddlSunpo5.Items.Add(New ListItem("", ""))
            Do While oDataReader.Read
                ddlSunpo1.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
                ddlSunpo2.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
                ddlSunpo3.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
                ddlSunpo4.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
                ddlSunpo5.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
            Loop
        End Using

        '確認単位
        sQuery = sQuery
        _oDatabase.CreateParam("K01", "MS004")
        Using oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            ddlUnit1.Items.Add(New ListItem("", ""))
            ddlUnit2.Items.Add(New ListItem("", ""))
            ddlUnit3.Items.Add(New ListItem("", ""))
            ddlUnit4.Items.Add(New ListItem("", ""))
            ddlUnit5.Items.Add(New ListItem("", ""))
            Do While oDataReader.Read
                ddlUnit1.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
                ddlUnit2.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
                ddlUnit3.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
                ddlUnit4.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
                ddlUnit5.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
            Loop
        End Using

    End Sub

    Private Sub DisplayShow(ByVal sCode1 As String, ByVal sCode2 As String)
        Try
            Dim sQuery As String = ""
            '**** 2010/05 確認寸法追加 ST ****
            sQuery += "SELECT M.MATL_CD, M.REN_NO, M.MATL_NM, M.MATL_SPEC, M.MATL_TYPE_CD"
            sQuery += "     , M.SHAPE_CD, M.MATL_SPFT_NO, M.MAGNETISM, M.STOCK_LV, M.LOW_ORDER_WAT"
            sQuery += "     , M.COEFFICIENT, M.UNIT_KB, M.UNIT_WAT, M.DELIVER_TERM"
            sQuery += "     , M.PERSONAL_MATL"
            sQuery += "     , M.ORDER_CD1, C1.CONTRACTOUT_NM AS C_NM1, M.ORDER_CD2, C2.CONTRACTOUT_NM AS C_NM2, M.ORDER_CD3, C3.CONTRACTOUT_NM AS C_NM3"
            sQuery += "     , M.CONFIRM_SIZE_KB1, M.CONFIRM_SIZE1, M.CONFIRM_UNIT1, M.CONFIRM_UP_DIFF1, M.CONFIRM_LOW_DIFF1"
            sQuery += "     , M.CONFIRM_SIZE_KB2, M.CONFIRM_SIZE2, M.CONFIRM_UNIT2, M.CONFIRM_UP_DIFF2, M.CONFIRM_LOW_DIFF2"
            sQuery += "     , M.CONFIRM_SIZE_KB3, M.CONFIRM_SIZE3, M.CONFIRM_UNIT3, M.CONFIRM_UP_DIFF3, M.CONFIRM_LOW_DIFF3"
            sQuery += "     , M.CONFIRM_SIZE_KB4, M.CONFIRM_SIZE4, M.CONFIRM_UNIT4, M.CONFIRM_UP_DIFF4, M.CONFIRM_LOW_DIFF4"
            sQuery += "     , M.CONFIRM_SIZE_KB5, M.CONFIRM_SIZE5, M.CONFIRM_UNIT5, M.CONFIRM_UP_DIFF5, M.CONFIRM_LOW_DIFF5"
            sQuery += "     , M.UPD_DT, M.UPD_TIME"
            sQuery += "     , M.SHIP_PR"            '2012/12 出庫単価 追加
            sQuery += "  FROM MATL_MST M"
            sQuery += "     , CONTRACTOUT_MST C1"
            sQuery += "     , CONTRACTOUT_MST C2"
            sQuery += "     , CONTRACTOUT_MST C3"
            sQuery += " WHERE M.ORDER_CD1 = C1.CONTRACTOUT_CD(+)"
            sQuery += "   AND M.ORDER_CD2 = C2.CONTRACTOUT_CD(+)"
            sQuery += "   AND M.ORDER_CD3 = C3.CONTRACTOUT_CD(+)"
            sQuery += "   AND M.MATL_CD = :K01 AND M.REN_NO = :K02"
            _oDatabase.CreateParam("K01", sCode1)
            _oDatabase.CreateParam("K02", sCode2)

            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read Then
                    txtSCode.Text = GetString(oReader, 0).Trim()            '主材料コード
                    txtSCode.Enabled = False
                    lblRen.Text = GetInt32(oReader, 1)                      '連No
                    txtName.Text = GetString(oReader, 2).Trim               '主材料名
                    txtSpec.Text = GetString(oReader, 3).Trim               '材料SPEC
                    ddlZCode.SelectedValue = GetString(oReader, 4).Trim()   '材種コード
                    ddlKCode.SelectedValue = GetString(oReader, 5).Trim()   '形状コード
                    txtSiyou.Text = GetString(oReader, 6).Trim()            '材料仕様書No
                    ddlJisei.SelectedValue = GetString(oReader, 7).Trim()   '磁性
                    txtStock.Text = GetDouble(oReader, 8)                   'ストックレベル
                    txtMin.Text = GetDouble(oReader, 9)                     '最低発注量
                    txtKeisu.Text = GetDouble(oReader, 10)                  '係数
                    ddlUnit.Text = GetString(oReader, 11).Trim()            '単位区分
                    txtWeight.Text = GetDouble(oReader, 12)                 '単位重量
                    txtKikan.Text = GetInt32(oReader, 13)                   '納入期間
                    ddlSenzai.SelectedValue = GetString(oReader, 14).Trim   '専用材区分
                    txtHCode1.Text = GetString(oReader, 15).Trim()          '発注先コード１
                    lblHCode1.Text = GetString(oReader, 16).Trim()          '発注先名１
                    txtHCode2.Text = GetString(oReader, 17).Trim()          '発注先コード２
                    lblHCode2.Text = GetString(oReader, 18).Trim()          '発注先２
                    txtHCode3.Text = GetString(oReader, 19).Trim()          '発注先コード３
                    lblHCode3.Text = GetString(oReader, 20).Trim()          '発注先３

                    ddlSunpo1.SelectedValue = GetString(oReader, 21).Trim   '寸法区分１
                    ddlUnit1.SelectedValue = GetString(oReader, 23).Trim    '単位１
                    If GetString(oReader, 21).Trim <> "" Then
                        txtSunpo1.Text = GetDouble(oReader, 22)             '寸法１
                        txtJogen1.Text = GetDouble(oReader, 24)             '上限交差１
                        txtKagen1.Text = GetDouble(oReader, 25)             '下限交差１
                    Else
                        txtSunpo1.Text = ""
                        txtJogen1.Text = ""
                        txtKagen1.Text = ""
                    End If
                    ddlSunpo2.SelectedValue = GetString(oReader, 26).Trim   '寸法区分２
                    ddlUnit2.SelectedValue = GetString(oReader, 28).Trim    '単位２
                    If GetString(oReader, 26).Trim <> "" Then
                        txtSunpo2.Text = GetDouble(oReader, 27)             '寸法２
                        txtJogen2.Text = GetDouble(oReader, 29)             '上限交差２
                        txtKagen2.Text = GetDouble(oReader, 30)             '下限交差２
                    Else
                        txtSunpo2.Text = ""
                        txtJogen2.Text = ""
                        txtKagen2.Text = ""
                    End If
                    ddlSunpo3.SelectedValue = GetString(oReader, 31).Trim   '寸法区分３
                    ddlUnit3.SelectedValue = GetString(oReader, 33).Trim    '単位３
                    If GetString(oReader, 31).Trim <> "" Then
                        txtSunpo3.Text = GetDouble(oReader, 32)             '寸法３
                        txtJogen3.Text = GetDouble(oReader, 34)             '上限交差３
                        txtKagen3.Text = GetDouble(oReader, 35)             '下限交差３
                    Else
                        txtSunpo3.Text = ""
                        txtJogen3.Text = ""
                        txtKagen3.Text = ""
                    End If
                    ddlSunpo4.SelectedValue = GetString(oReader, 36).Trim   '寸法区分４
                    ddlUnit4.SelectedValue = GetString(oReader, 38).Trim    '単位４
                    If GetString(oReader, 36).Trim <> "" Then
                        txtSunpo4.Text = GetDouble(oReader, 37)             '寸法４
                        txtJogen4.Text = GetDouble(oReader, 39)             '上限交差４
                        txtKagen4.Text = GetDouble(oReader, 40)             '下限交差４
                    Else
                        txtSunpo4.Text = ""
                        txtJogen4.Text = ""
                        txtKagen4.Text = ""
                    End If
                    ddlSunpo5.SelectedValue = GetString(oReader, 41).Trim   '寸法区分５
                    ddlUnit5.SelectedValue = GetString(oReader, 43).Trim    '単位５
                    If GetString(oReader, 41).Trim <> "" Then
                        txtSunpo5.Text = GetDouble(oReader, 42)             '寸法５
                        txtJogen5.Text = GetDouble(oReader, 44)             '上限交差５
                        txtKagen5.Text = GetDouble(oReader, 45)             '下限交差５
                    Else
                        txtSunpo5.Text = ""
                        txtJogen5.Text = ""
                        txtKagen5.Text = ""
                    End If

                    '2012/12 出庫単価追加
                    Me.txtSTanka.Text = GetDouble(oReader, 48)

                    ViewState("update") = oReader.GetString(46).Trim() + oReader.GetString(47).Trim()   '更新日時
                End If
            End Using

            'sQuery += "SELECT S1.*,G1.CONTRACTOUT_NM,G2.CONTRACTOUT_NM,G3.CONTRACTOUT_NM "
            'sQuery += "FROM MATL_MST S1,CONTRACTOUT_MST G1,CONTRACTOUT_MST G2,CONTRACTOUT_MST G3 "
            'sQuery += "WHERE S1.ORDER_CD1 = G1.CONTRACTOUT_CD(+) AND S1.ORDER_CD2 = G2.CONTRACTOUT_CD(+) AND S1.ORDER_CD3 = G3.CONTRACTOUT_CD(+) "
            'sQuery += "AND MATL_CD = :K01 AND REN_NO = :K02"
            '_oDatabase.CreateParam("K01", sCode1) 
            '_oDatabase.CreateParam("K02", sCode2) 
            'Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 

            'If oReader.Read() Then 
            '    txtSCode.Text = oReader.GetString(0).Trim() 
            '    txtSCode.Enabled = False 
            '    lblRen.Text = oReader.GetInt32(1) 
            '    If Not oReader.IsDBNull(2) Then txtName.Text = oReader.GetString(2).Trim() 
            '    If Not oReader.IsDBNull(3) Then txtSpec.Text = oReader.GetString(3).Trim() 
            '    If Not oReader.IsDBNull(4) Then ddlZCode.SelectedValue = oReader.GetString(4).Trim() 
            '    If Not oReader.IsDBNull(5) Then ddlKCode.SelectedValue = oReader.GetString(5).Trim() 
            '    If Not oReader.IsDBNull(6) Then txtSiyou.Text = oReader.GetString(6).Trim() 
            '    If Not oReader.IsDBNull(7) Then ddlJisei.SelectedValue = oReader.GetString(7).Trim() 
            '    If Not oReader.IsDBNull(8) Then txtStock.Text = oReader.GetDouble(8) 
            '    If Not oReader.IsDBNull(9) Then txtMin.Text = oReader.GetDouble(9) 
            '    If Not oReader.IsDBNull(10) Then txtKeisu.Text = oReader.GetDouble(10) 
            '    If Not oReader.IsDBNull(11) Then ddlUnit.Text = oReader.GetString(11).Trim() 
            '    If Not oReader.IsDBNull(12) Then txtWeight.Text = oReader.GetDouble(12) 
            '    If Not oReader.IsDBNull(13) Then txtKikan.Text = oReader.GetInt32(13) 
            '    If Not oReader.IsDBNull(17) Then ddlSenzai.SelectedValue = oReader.GetString(17) 
            '    If Not oReader.IsDBNull(14) Then txtHCode1.Text = oReader.GetString(14).Trim() 
            '    If Not oReader.IsDBNull(15) Then txtHCode2.Text = oReader.GetString(15).Trim() 
            '    If Not oReader.IsDBNull(16) Then txtHCode3.Text = oReader.GetString(16).Trim() 
            '    If Not oReader.IsDBNull(26) Then lblHCode1.Text = oReader.GetString(26).Trim() 
            '    If Not oReader.IsDBNull(27) Then lblHCode2.Text = oReader.GetString(27).Trim() 
            '    If Not oReader.IsDBNull(28) Then lblHCode3.Text = oReader.GetString(28).Trim() 
            '    ViewState("update") = oReader.GetString(22).Trim() + oReader.GetString(23).Trim() 
            'End If 
            'oReader.Close()
            '**** 2010/05 確認寸法追加 ED ****
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    Private Sub GoBack()
        Response.Redirect("mdmas060.aspx?key1=" + ViewState("key1") + "&key2=" + ViewState("key2") + "&key3=" + ViewState("key3") + "&page=" + ViewState("page"), False)
    End Sub

#End Region

#Region " チェック関数 "

    '主材料コード登録済みチェック   '2012/12 ホスト廃止対応
    Friend Sub valSCode3_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valSCode3.ServerValidate

        '更新ﾓｰﾄﾞのときはスルー
        If Request.QueryString("mode").Equals("u") Then
            e.IsValid = True
            Exit Sub
        End If

        Dim sQuery As String = String.Empty
        If Me.valSCode1.IsValid And Me.valSCode2.IsValid Then

            sQuery += "SELECT MATL_CD"
            sQuery += "  FROM MATL_MST"
            sQuery += " WHERE MATL_CD = :K01"
            _oDatabase.CreateParam("K01", Me.txtSCode.Text)
            Try
                Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                    e.IsValid = Not oReader.HasRows
                End Using
            Catch ex As Exception
                MedicalLib.PageError.Show(ex.Message)
            End Try
        End If
    End Sub

    '主材料名称バイト数チェック 
    Friend Sub CheckName(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valName2.ServerValidate
        Dim curCnt As Integer = 1
        Dim chkByt As Integer = 0
        Dim tmpStr As String = ""
        For curCnt = 1 To Len(txtName.Text)
            tmpStr = Asc(Mid(txtName.Text, curCnt, 1))
            If 0 <= tmpStr And tmpStr <= 255 Then
                chkByt = chkByt + 1
            Else
                chkByt = chkByt + 2
            End If
        Next
        If chkByt <= 17 Then
            e.IsValid = True
        Else
            e.IsValid = False
        End If

    End Sub

    '連NO存在チェック 
    Friend Sub CheckRen(ByVal sender As Object, ByVal e As ServerValidateEventArgs)
        Try
            Dim sQuery As String = "SELECT * FROM MATL_MST WHERE MATL_CD = :K01 AND REN_NO = :K02"
            _oDatabase.CreateParam("K01", txtSCode.Text.Trim())
            _oDatabase.CreateParam("K02", lblRen.Text.Trim())
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = Not oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '発注先コード１チェック 
    Friend Sub CheckHCode1(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valHCode12.ServerValidate
        If valHCode11.IsValid Then
            If txtHCode1.Text.Equals("") Then
                lblHCode1.Text = ""
                Exit Sub
            End If
            Try
                Dim sQuery As String = "SELECT CONTRACTOUT_NM FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :K01"
                _oDatabase.CreateParam("K01", txtHCode1.Text.PadLeft(4, "0"))
                Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                e.IsValid = oReader.Read

                If e.IsValid Then
                    txtHCode1.Text = txtHCode1.Text.Trim.PadLeft(4, "0")
                    lblHCode1.Text = oReader.GetString(0).Trim()
                Else
                    lblHCode1.Text = ""
                End If
                oReader.Close()
            Catch ex As Exception
                MedicalLib.PageError.Show(ex.Message)
            End Try
        Else
            lblHCode1.Text = ""
        End If
    End Sub

    '発注先コード２チェック 
    Friend Sub CheckHCode2(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valHCode22.ServerValidate
        If valHCode21.IsValid Then
            If txtHCode2.Text.Equals("") Then
                lblHCode2.Text = ""
                Exit Sub
            End If
            Try
                Dim sQuery As String = "SELECT CONTRACTOUT_NM FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :K01"
                _oDatabase.CreateParam("K01", txtHCode2.Text.PadLeft(4, "0"))
                Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                e.IsValid = oReader.Read

                If e.IsValid Then
                    txtHCode2.Text = txtHCode2.Text.Trim.PadLeft(4, "0")
                    lblHCode2.Text = oReader.GetString(0).Trim()
                Else
                    lblHCode2.Text = ""
                End If
                oReader.Close()
            Catch ex As Exception
                MedicalLib.PageError.Show(ex.Message)
            End Try
        Else
            lblHCode2.Text = ""
        End If
    End Sub

    '発注先コード３チェック 
    Friend Sub CheckHCode3(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valHCode32.ServerValidate
        If valHCode31.IsValid Then
            If txtHCode3.Text.Equals("") Then
                lblHCode3.Text = ""
                Exit Sub
            End If
            Try
                Dim sQuery As String = "SELECT CONTRACTOUT_NM FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :K01"
                _oDatabase.CreateParam("K01", txtHCode3.Text.PadLeft(4, "0"))
                Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                e.IsValid = oReader.Read

                If e.IsValid Then
                    txtHCode3.Text = txtHCode3.Text.Trim.PadLeft(4, "0")
                    lblHCode3.Text = oReader.GetString(0).Trim()
                Else
                    lblHCode3.Text = ""
                End If
                oReader.Close()
            Catch ex As Exception
                MedicalLib.PageError.Show(ex.Message)
            End Try
        Else
            lblHCode3.Text = ""
        End If
    End Sub

    '確認寸法チェック   2010/05 追加
    Protected Sub valSunpo_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valSunpo1.ServerValidate, valSunpo2.ServerValidate,
                                                                                                                                           valSunpo3.ServerValidate, valSunpo4.ServerValidate,
                                                                                                                                           valSunpo5.ServerValidate

        Dim oValSunpo As CustomValidator = DirectCast(source, CustomValidator)
        Dim oSunpoKB As DropDownList = Nothing
        Dim oSunpo As TextBox = Nothing
        Dim oUnit As DropDownList = Nothing
        Dim oJogen As TextBox = Nothing
        Dim oKagen As TextBox = Nothing

        Select Case oValSunpo.ID
            Case "valSunpo1"
                oSunpoKB = Me.ddlSunpo1
                oSunpo = Me.txtSunpo1
                oUnit = Me.ddlUnit1
                oJogen = Me.txtJogen1
                oKagen = Me.txtKagen1
            Case "valSunpo2"
                oSunpoKB = Me.ddlSunpo2
                oSunpo = Me.txtSunpo2
                oUnit = Me.ddlUnit2
                oJogen = Me.txtJogen2
                oKagen = Me.txtKagen2
            Case "valSunpo3"
                oSunpoKB = Me.ddlSunpo3
                oSunpo = Me.txtSunpo3
                oUnit = Me.ddlUnit3
                oJogen = Me.txtJogen3
                oKagen = Me.txtKagen3
            Case "valSunpo4"
                oSunpoKB = Me.ddlSunpo4
                oSunpo = Me.txtSunpo4
                oUnit = Me.ddlUnit4
                oJogen = Me.txtJogen4
                oKagen = Me.txtKagen4
            Case "valSunpo5"
                oSunpoKB = Me.ddlSunpo5
                oSunpo = Me.txtSunpo5
                oUnit = Me.ddlUnit5
                oJogen = Me.txtJogen5
                oKagen = Me.txtKagen5
        End Select

        '入力チェック
        If oSunpoKB.SelectedValue <> "" Or
           oSunpo.Text.Trim <> "" Or
           oUnit.SelectedValue <> "" Or
           oJogen.Text.Trim <> "" Or
           oKagen.Text.Trim <> "" Then

            If oSunpoKB.SelectedValue = "" Then
                oValSunpo.ErrorMessage = "寸法区分を入力してください"
                args.IsValid = False
                Exit Sub
            End If
            If oSunpo.Text.Trim = "" Then
                oValSunpo.ErrorMessage = "寸法を入力してください"
                args.IsValid = False
                Exit Sub
            End If
            If oUnit.SelectedValue = "" Then
                oValSunpo.ErrorMessage = "単位を入力してください"
                args.IsValid = False
                Exit Sub
            End If
            If oJogen.Text.Trim = "" Then
                oValSunpo.ErrorMessage = "上限交差を入力してください"
                args.IsValid = False
                Exit Sub
            End If
            If oKagen.Text.Trim = "" Then
                oValSunpo.ErrorMessage = "下限交差を入力してください"
                args.IsValid = False
                Exit Sub
            End If

            '入力妥当性チェック
            If Not Regex.IsMatch(oSunpo.Text.Trim, "^[0-9]{1,4}(\.[0-9]{0,3})?$") Then
                oValSunpo.ErrorMessage = "寸法は整数4桁以内、少数3桁以内で入力してください"
                args.IsValid = False
                Exit Sub
            End If
            If Not Regex.IsMatch(oJogen.Text.Trim, "^[0-9]{1,2}(\.[0-9]{0,3})?$") Then
                oValSunpo.ErrorMessage = "上限公差は整数2桁以内、少数3桁以内で入力してください"
                args.IsValid = False
                Exit Sub
            End If
            If Not Regex.IsMatch(oKagen.Text.Trim, "^-[0-9]{1,2}(\.[0-9]{0,3})?$") Then
                oValSunpo.ErrorMessage = "下限公差は整数2桁以内、少数3桁以内の負数で入力してください"
                args.IsValid = False
                Exit Sub
            End If
        End If

    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM MATL_MST WHERE MATL_CD = :K01 AND REN_NO = :K02 "
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", ViewState("code1"))
            _oDatabase.CreateParam("K02", ViewState("code2"))
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
        '**** 2012/12 ホスト廃止対応 ST ****
        '**** 出庫単価を追加
        Dim sGenValues() As String = (txtName.Text.Trim() & "," & txtSpec.Text.Trim() & "," & ddlZCode.SelectedValue & "," & ddlKCode.SelectedValue & "," & txtSiyou.Text.Trim() & "," & ddlJisei.SelectedValue & "," & txtStock.Text.Trim.PadLeft(1, "0") & "," & txtMin.Text.Trim.PadLeft(1, "0") & "," & txtKeisu.Text.Trim.PadLeft(1, "0") & "," & ddlUnit.SelectedValue & "," & txtWeight.Text.Trim.PadLeft(1, "0") & "," & txtKikan.Text.Trim.PadLeft(1, "0") & "," & txtHCode1.Text.Trim() & "," & txtHCode2.Text.Trim() & "," & txtHCode3.Text.Trim() & "," & ddlSenzai.SelectedValue & "," & Me.txtSTanka.Text.Trim.PadLeft(1, "0") _
                              & "," & ddlSunpo1.SelectedValue.Trim & "," & txtSunpo1.Text.Trim.PadLeft(1, "0") & "," & ddlUnit1.SelectedValue.Trim & "," & txtJogen1.Text.Trim.PadLeft(1, "0") & "," & txtKagen1.Text.Trim.PadLeft(1, "0") _
                              & "," & ddlSunpo2.SelectedValue.Trim & "," & txtSunpo2.Text.Trim.PadLeft(1, "0") & "," & ddlUnit2.SelectedValue.Trim & "," & txtJogen2.Text.Trim.PadLeft(1, "0") & "," & txtKagen2.Text.Trim.PadLeft(1, "0") _
                              & "," & ddlSunpo3.SelectedValue.Trim & "," & txtSunpo3.Text.Trim.PadLeft(1, "0") & "," & ddlUnit3.SelectedValue.Trim & "," & txtJogen3.Text.Trim.PadLeft(1, "0") & "," & txtKagen3.Text.Trim.PadLeft(1, "0") _
                              & "," & ddlSunpo4.SelectedValue.Trim & "," & txtSunpo4.Text.Trim.PadLeft(1, "0") & "," & ddlUnit4.SelectedValue.Trim & "," & txtJogen4.Text.Trim.PadLeft(1, "0") & "," & txtKagen4.Text.Trim.PadLeft(1, "0") _
                              & "," & ddlSunpo5.SelectedValue.Trim & "," & txtSunpo5.Text.Trim.PadLeft(1, "0") & "," & ddlUnit5.SelectedValue.Trim & "," & txtJogen5.Text.Trim.PadLeft(1, "0") & "," & txtKagen5.Text.Trim.PadLeft(1, "0") _
                                     ).Split(",")
        ' ''**** 2010/05 項目追加 ST ****
        ''Dim sGenValues() As String = (txtName.Text.Trim() & "," & txtSpec.Text.Trim() & "," & ddlZCode.SelectedValue & "," & ddlKCode.SelectedValue & "," & txtSiyou.Text.Trim() & "," & ddlJisei.SelectedValue & "," & txtStock.Text.Trim.PadLeft(1, "0") & "," & txtMin.Text.Trim.PadLeft(1, "0") & "," & txtKeisu.Text.Trim.PadLeft(1, "0") & "," & ddlUnit.SelectedValue & "," & txtWeight.Text.Trim.PadLeft(1, "0") & "," & txtKikan.Text.Trim.PadLeft(1, "0") & "," & txtHCode1.Text.Trim() & "," & txtHCode2.Text.Trim() & "," & txtHCode3.Text.Trim() & "," & ddlSenzai.SelectedValue _
        ''                      & "," & ddlSunpo1.SelectedValue.Trim & "," & txtSunpo1.Text.Trim.PadLeft(1, "0") & "," & ddlUnit1.SelectedValue.Trim & "," & txtJogen1.Text.Trim.PadLeft(1, "0") & "," & txtKagen1.Text.Trim.PadLeft(1, "0") _
        ''                      & "," & ddlSunpo2.SelectedValue.Trim & "," & txtSunpo2.Text.Trim.PadLeft(1, "0") & "," & ddlUnit2.SelectedValue.Trim & "," & txtJogen2.Text.Trim.PadLeft(1, "0") & "," & txtKagen2.Text.Trim.PadLeft(1, "0") _
        ''                      & "," & ddlSunpo3.SelectedValue.Trim & "," & txtSunpo3.Text.Trim.PadLeft(1, "0") & "," & ddlUnit3.SelectedValue.Trim & "," & txtJogen3.Text.Trim.PadLeft(1, "0") & "," & txtKagen3.Text.Trim.PadLeft(1, "0") _
        ''                      & "," & ddlSunpo4.SelectedValue.Trim & "," & txtSunpo4.Text.Trim.PadLeft(1, "0") & "," & ddlUnit4.SelectedValue.Trim & "," & txtJogen4.Text.Trim.PadLeft(1, "0") & "," & txtKagen4.Text.Trim.PadLeft(1, "0") _
        ''                      & "," & ddlSunpo5.SelectedValue.Trim & "," & txtSunpo5.Text.Trim.PadLeft(1, "0") & "," & ddlUnit5.SelectedValue.Trim & "," & txtJogen5.Text.Trim.PadLeft(1, "0") & "," & txtKagen5.Text.Trim.PadLeft(1, "0") _
        ''                             ).Split(",")
        ' ''Dim sGenValues() As String = (txtName.Text.Trim() + "," + txtSpec.Text.Trim() + "," + ddlZCode.SelectedValue + "," + ddlKCode.SelectedValue + "," + txtSiyou.Text.Trim() + "," + ddlJisei.SelectedValue + "," + txtStock.Text.Trim.PadLeft(1, "0") + "," + txtMin.Text.Trim.PadLeft(1, "0") + "," + txtKeisu.Text.Trim.PadLeft(1, "0") + "," + ddlUnit.SelectedValue + "," + txtWeight.Text.Trim.PadLeft(1, "0") + "," + txtKikan.Text.Trim.PadLeft(1, "0") + "," + txtHCode1.Text.Trim() + "," + txtHCode2.Text.Trim() + "," + txtHCode3.Text.Trim() + "," + ddlSenzai.SelectedValue).Split(",")
        ' ''**** 2010/05 項目追加 ED ****
        '**** 2012/12 ホスト廃止対応 ED ****

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) Then
                Select Case i
                    Case 2      '材種コード
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS002"), GetHanyouName(sGenValues(i), "MS002"))
                    Case 3      '形状コード
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS003"), GetHanyouName(sGenValues(i), "MS003"))
                    Case 5      '磁性
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS017"), GetHanyouName(sGenValues(i), "MS017"))
                    Case 9      '単位区分
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS004"), GetHanyouName(sGenValues(i), "MS004"))
                    Case 12, 13, 14     '発注先
                        InsertMH(sItemNames(i), GetGaityuName(sMotoValues(i)), GetGaityuName(sGenValues(i)))
                    Case 15     '専用材区分
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS024"), GetHanyouName(sGenValues(i), "MS024"))
                    Case 17, 22, 27, 32, 37    '確認寸法区分
                        'Case 16, 21, 26, 31, 36    '確認寸法区分       2012/12 ホスト廃止対応
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS004"), GetHanyouName(sGenValues(i), "MS004"))
                    Case 19, 24, 29, 34, 39    '確認単位
                        'Case 18, 23, 28, 33, 38    '確認単位           2012/12 ホスト廃止対応
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS004"), GetHanyouName(sGenValues(i), "MS004"))
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
                If GetString(oReader, 1) <> "主材料コード" And GetString(oReader, 1) <> "連NO" Then   '主キー以外
                    If GetString(oReader, 1) = "登録日付" Then
                        Exit While
                    Else
                        '**** 2012/12 ホスト廃止対応 ST ****
                        '**** 出庫単価を含める
                        sResult += GetString(oReader, 1) + ","
                        ' ''**** 2010/05 出庫単価をはずす ST ****
                        ''If GetString(oReader, 1) <> "出庫単価" Then
                        ''    sResult += GetString(oReader, 1) + ","
                        ''End If
                        ' ''sResult += GetString(oReader, 1) + ","
                        ' ''**** 2010/05 出庫単価をはずす ED ****
                        '**** 2012/12 ホスト廃止対応 ED ****
                    End If
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
        Dim iKeySu As Integer = 2       '主キー項目数
        Dim sResult As String = ""
        Try
            '**** 2012/12 ホスト廃止対応 ST ****
            '**** 出庫単価を含める
            sQuery = "SELECT * FROM MATL_MST WHERE MATL_CD = :KEY1 AND REN_NO = :KEY2"
            ' ''**** 2010/05 出庫単価をはずす ST ****
            ''sQuery = ""
            ''sQuery += "SELECT MATL_CD, REN_NO, MATL_NM, MATL_SPEC ,MATL_TYPE_CD"
            ''sQuery += "     , SHAPE_CD, MATL_SPFT_NO, MAGNETISM, STOCK_LV, LOW_ORDER_WAT"
            ''sQuery += "     , COEFFICIENT, UNIT_KB, UNIT_WAT, DELIVER_TERM, ORDER_CD1"
            ''sQuery += "     , ORDER_CD2, ORDER_CD3, PERSONAL_MATL"
            ''sQuery += "     , CONFIRM_SIZE_KB1, CONFIRM_SIZE1, CONFIRM_UNIT1, CONFIRM_UP_DIFF1, CONFIRM_LOW_DIFF1"
            ''sQuery += "     , CONFIRM_SIZE_KB2, CONFIRM_SIZE2, CONFIRM_UNIT2, CONFIRM_UP_DIFF2, CONFIRM_LOW_DIFF2"
            ''sQuery += "     , CONFIRM_SIZE_KB3, CONFIRM_SIZE3, CONFIRM_UNIT3, CONFIRM_UP_DIFF3, CONFIRM_LOW_DIFF3"
            ''sQuery += "     , CONFIRM_SIZE_KB4, CONFIRM_SIZE4, CONFIRM_UNIT4, CONFIRM_UP_DIFF4, CONFIRM_LOW_DIFF4"
            ''sQuery += "     , CONFIRM_SIZE_KB5, CONFIRM_SIZE5, CONFIRM_UNIT5, CONFIRM_UP_DIFF5, CONFIRM_LOW_DIFF5"
            ''sQuery += "     , CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
            ''sQuery += "  FROM MATL_MST"
            ''sQuery += " WHERE MATL_CD = :KEY1 AND REN_NO = :KEY2"
            ' ''sQuery = "SELECT * FROM MATL_MST WHERE MATL_CD = :KEY1 AND REN_NO = :KEY2"
            ' ''**** 2010/05 出庫単価をはずす ED ****
            '**** 2012/12 ホスト廃止対応 ED ****
            _oDatabase.CreateParam("KEY1", ViewState("code1"))
            _oDatabase.CreateParam("KEY2", ViewState("code2"))
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
        InsertMH(ViewState("code1") + ":" + ViewState("code2"), sItemName, sMae, sAto)
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

    '外注 名付き
    Private Function GetGaityuName(ByVal sKey As String) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sResult As String = ""
        Try
            sQuery += "SELECT CONTRACTOUT_CD,CONTRACTOUT_NM FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :K01"
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

#End Region

End Class
