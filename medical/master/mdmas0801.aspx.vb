Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing

Partial Class master_mdmas0801 
    Inherits System.Web.UI.Page 
    Implements System.Web.UI.ICallbackEventHandler 
 
    Private Const PROGRAM_ID As String = "MDMAS080" 
    Private Const PROGRAM_TITLE As String = "工程マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "PROCESS_MST"
    Private Const TABLE_NAME_JP As String = "工程マスタ"
 
    'CallBack 
    Public _sCallBackScript As String = "" 
    Private _sCode As String = "" 
 
#Region " ページ " 
 
    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess

            If Not Page.IsPostBack Then

                'SHOPコンボの設定 
                Dim sql As String
                Dim oDataReader As OracleDataReader
                ddlShop.Items.Add(New ListItem("", ""))
                sql = "SELECT SHOP,SHOP_NM FROM SHOP_MST ORDER BY SHOP"
                oDataReader = _oDatabase.CreateReader(sql)
                Do While oDataReader.Read
                    ddlShop.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetOracleString(1), oDataReader.GetOracleString(0)))
                Loop
                oDataReader.Close()

                '設備集約コードコンボの設定 
                sql = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025' ORDER BY TELL_CD"
                oDataReader = _oDatabase.CreateReader(sql)
                ddlSCode.Items.Add(New ListItem("", ""))
                Do While oDataReader.Read
                    ddlSCode.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetOracleString(1), oDataReader.GetOracleString(0)))
                Loop
                oDataReader.Close()
            End If

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

        'CallBack 
        _sCallBackScript = Page.ClientScript.GetCallbackEventReference(Me, "command", "getInfoCallBack", "context", "getInfoCallBackError", False)

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
                DisplayShow(Request.QueryString("code"))
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
        Dim sReturnValue As String = "" 
        Dim sValues() As String = _sCode.Split(Chr(9)) 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader 
 
        Select Case sValues(0) 
            Case 1 
                '作業標準取得 
                sQuery = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS027' AND TELL_CD = :K01 " 
 
                _oDatabase.CreateParam("K01", sValues(1).Trim()) 
 
                oReader = _oDatabase.CreateReaderParam(sQuery) 
                If oReader.Read() Then 
                    sReturnValue = GetString(oReader, 0) + vbTab 
                Else 
                    sReturnValue = "" + vbTab 
                End If 
                oReader.Close() 
            Case 2 
                '工程名称取得 
                sQuery = "SELECT P_ORDER_NM FROM PROCESS_MST WHERE PROCESS_CD = :K01 " 
 
                _oDatabase.CreateParam("K01", sValues(1).Trim()) 
 
                oReader = _oDatabase.CreateReaderParam(sQuery) 
                If oReader.Read() Then 
                    sReturnValue = GetString(oReader, 0) + vbTab 
                Else 
                    sReturnValue = "" + vbTab 
                End If 
                oReader.Close() 
 
        End Select 
 
        Return sReturnValue 
    End Function 
 
    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent 
        _sCode = eventArgument 
    End Sub

#End Region

#Region " ボタン "

    '登録＆修正ボタン押下処理 
    Protected Sub cmdRun_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles cmdRun.Click
        valCode3.Enabled = ViewState("mode").Equals("i")
        Page.Validate("check")
        If Page.IsValid Then
            Dim sQuery As String = ""
            Try
                _oDatabase.BeginTrans()
                '追加/更新 
                If ViewState("mode").Trim.Equals("i") Then

                    'マスタ更新履歴テーブル追加
                    InsertHistory(txtCode.Text.Trim)

                    sQuery = "INSERT INTO PROCESS_MST VALUES(:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11,:F12,:F13,:F14,:F15)"
                    _oDatabase.CreateParam("F01", txtCode.Text.Trim())
                    _oDatabase.CreateParam("F02", txtName.Text.Trim())
                    _oDatabase.CreateParam("F03", ddlShop.SelectedValue.Trim())
                    _oDatabase.CreateParam("F04", txtMinute.Text.Trim())
                    _oDatabase.CreateParam("F05", txtHyoujun.Text.Trim())
                    _oDatabase.CreateParam("F06", ddlSCode.SelectedValue.Trim())

                    If rbtnOya.Checked Then
                        _oDatabase.CreateParam("F07", "0")
                    ElseIf rbtnKo.Checked Then
                        _oDatabase.CreateParam("F07", "1")
                    End If
                    '_oDatabase.CreateParam("F07", txtOyaCode.Text.Trim()) 
                    _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F10", Session("UserID"))
                    _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F13", Session("UserID"))
                    _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
                    If txtSetuptime.Text.Trim() = "" Then '20120212追加
                        _oDatabase.CreateParam("F15", 0)
                    Else
                        _oDatabase.CreateParam("F15", txtSetuptime.Text.Trim())
                    End If
                Else
                    Page.Validate("update")
                    If Not Page.IsValid Then Exit Sub

                    'マスタ更新履歴テーブル追加
                    UpdateHistory()

                    sQuery = "UPDATE PROCESS_MST SET "
                    sQuery += "P_ORDER_NM = :F01,"
                    sQuery += "SHOP = :F02,"
                    sQuery += "UNIT_TIME_REQUIRED = :F03,"
                    sQuery += "WORK_STD = :F04,"
                    sQuery += "FACILITIES_G_CD = :F20,"
                    sQuery += "FAMILY_KB = :F21,"
                    sQuery += "UPD_DT = :F06,"
                    sQuery += "UPD_TIME = :F07,"
                    sQuery += "UPD_USR = :F08,"
                    sQuery += "UPD_PROGRAM_ID = :F09,"
                    sQuery += "STD_SETUP_TIME = :F15 " '20120222追加
                    sQuery += "WHERE PROCESS_CD = :K01"
                    _oDatabase.CreateParam("F01", txtName.Text.Trim())
                    _oDatabase.CreateParam("F02", ddlShop.SelectedValue.Trim())
                    _oDatabase.CreateParam("F03", txtMinute.Text.Trim())
                    _oDatabase.CreateParam("F04", txtHyoujun.Text.Trim())
                    _oDatabase.CreateParam("F20", ddlSCode.SelectedValue.Trim())
                    If txtSetuptime.Text.Trim() = "" Then '20120212追加
                        _oDatabase.CreateParam("F15", 0)
                    Else
                        _oDatabase.CreateParam("F15", txtSetuptime.Text.Trim())
                    End If
                    If rbtnOya.Checked Then
                        _oDatabase.CreateParam("F21", "0")
                    ElseIf rbtnKo.Checked Then
                        _oDatabase.CreateParam("F21", "1")
                    End If
                    '_oDatabase.CreateParam("F21", txtOyaCode.Text.Trim()) 
                    _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F08", Session("UserID"))
                    _oDatabase.CreateParam("F09", MedicalLib.Common.ProgramID)
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
    Protected Sub cmdDel_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles cmdDel.Click
        valCode3.Enabled = False
        Page.Validate("check")
        If Page.IsValid Then
            Page.Validate("update")
            If Not Page.IsValid() Then Exit Sub
            Try
                '削除 
                _oDatabase.BeginTrans()

                'マスタ更新履歴テーブル追加
                DeleteHistory()

                Dim sQuery As String = "DELETE FROM PROCESS_MST WHERE PROCESS_CD = :K01"

                _oDatabase.CreateParam("K01", txtCode.Text.Trim())
                _oDatabase.ExecuteNonQueryParam(sQuery)
                _oDatabase.CommitTrans()
                GoBack()
            Catch ex As Exception
                _oDatabase.Rollback()
                Response.Write(ex.Message)
            End Try
        End If
    End Sub

    '戻るボタン押下処理 
    Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles cmdBack.Click
        GoBack()
    End Sub

    Protected Sub cmdClear_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles cmdClear.Click
        If ViewState("mode").Equals("u") Then
            DisplayShow(Request.QueryString("code"))
        Else
            txtCode.Text = ""
            txtName.Text = ""
            ddlShop.SelectedValue = ""
            txtMinute.Text = ""
            txtHyoujun.Text = ""
            ddlSCode.SelectedValue = ""
            'txtOyaCode.Text = "" 
            'lblOyaName.Text = "" 
            txtSetuptime.Text = ""

        End If
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub DisplayShow(ByVal sCode As String) 
 
        Try 
            Dim sQuery As String = "" 
            sQuery += "SELECT PROCESS_CD,P_ORDER_NM,SHOP,UNIT_TIME_REQUIRED,WORK_STD,FACILITIES_G_CD,FAMILY_KB,UPD_DT||UPD_TIME,STD_SETUP_TIME "
            sQuery += "FROM PROCESS_MST WHERE PROCESS_CD = :K01" 
 
            _oDatabase.CreateParam("K01", sCode) 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                txtCode.Text = GetString(oReader, 0) 
                txtCode.Enabled = False 
                txtName.Text = GetString(oReader, 1) 
                ddlShop.SelectedValue = GetString(oReader, 2) 
                txtMinute.Text = GetInt32(oReader, 3) 
                txtHyoujun.Text = GetString(oReader, 4) 
                ddlSCode.SelectedValue = GetString(oReader, 5) 
                'txtOyaCode.Text = GetString(oReader, 6) 
                If GetString(oReader, 6) = "0" Then
                    rbtnOya.Checked = True
                    rbtnKo.Checked = False
                Else
                    rbtnOya.Checked = False
                    rbtnKo.Checked = True
                End If
                txtSetuptime.Text = GetDouble(oReader, 8) '20120212追加
                ViewState("update") = GetString(oReader, 7)
            End If 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
 
        getLabel() 
 
    End Sub 
 
    Private Sub getLabel() 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
 
        Try 
            lblHyoujun.Text = "" 
            If txtHyoujun.Text <> "" Then 
                sQuery = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL " 
                sQuery += "WHERE INFO_KB = 'MS027' AND TELL_CD = :K01 " 
 
                _oDatabase.CreateParam("K01", txtHyoujun.Text) 
                oReader = _oDatabase.CreateReaderParam(sQuery) 
 
                If oReader.Read() Then 
                    lblHyoujun.Text = GetString(oReader, 0) 
                End If 
                oReader.Close() 
            End If 
 
            'lblOyaName.Text = "" 
            'If txtOyaCode.Text <> "" Then 
            '    sQuery = "SELECT P_ORDER_NM FROM PROCESS_MST " 
            '    sQuery += "WHERE PROCESS_CD = :K01 " 

            '    _oDatabase.CreateParam("K01", txtOyaCode.Text) 
            '    oReader = _oDatabase.CreateReaderParam(sQuery) 

            '    If oReader.Read() Then 
            '        lblOyaName.Text = GetString(oReader, 0) 
            '    End If 
            '    oReader.Close() 
            'End If 
 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub

#End Region

#Region " チェック関数 "

    '工程コードチェック 
    Friend Sub CheckCode(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valCode3.ServerValidate
        If valCode2.IsValid Then
            Try
                Dim sQuery As String = "SELECT PROCESS_CD FROM PROCESS_MST WHERE PROCESS_CD = :K01"
                _oDatabase.CreateParam("K01", txtCode.Text.Trim)
                Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                e.IsValid = Not oReader.HasRows
                oReader.Close()
                If e.IsValid Then txtCode.Text = txtCode.Text.Trim.PadLeft(5, "0")
            Catch ex As Exception
                MedicalLib.PageError.Show(ex.Message)
            End Try
        End If
    End Sub

    ''親工程コードチェック 
    'Friend Sub CheckOyaCode(ByVal sender As Object, ByVal e As ServerValidateEventArgs) 

    '    Dim oReader As OracleDataReader = Nothing 
    '    Dim sQuery As String = "" 

    '    If valOya1.IsValid Then 

    '        If txtOyaCode.Text = "" Then 
    '            lblOyaName.Text = "" 
    '            Exit Sub 
    '        End If 

    '        Try 
    '            lblOyaName.Text = "" 
    '            sQuery += "SELECT P_ORDER_NM FROM PROCESS_MST WHERE PROCESS_CD = :K01 " 

    '            _oDatabase.CreateParam("K01", txtOyaCode.Text) 
    '            oReader = _oDatabase.CreateReaderParam(sQuery) 
    '            If oReader.Read() Then 
    '                lblOyaName.Text = GetString(oReader, 0) 
    '            End If 
    '            oReader.Close() 

    '            sQuery = "SELECT P_ORDER_NM FROM PROCESS_MST WHERE PROCESS_CD = :K01 " 
    '            sQuery += "AND TRIM(PER_PROCESS_CD) IS NULL " 

    '            _oDatabase.CreateParam("K01", txtOyaCode.Text) 
    '            oReader = _oDatabase.CreateReaderParam(sQuery) 
    '            If Not oReader.HasRows Then 
    '                CType(sender, CustomValidator).ErrorMessage = "工程マスタに存在しません" 
    '                e.IsValid = False 
    '                oReader.Close() 
    '                Exit Sub 
    '            End If 
    '            oReader.Close() 

    '        Catch ex As Exception 
    '            MedicalLib.PageError.Show(ex.Message) 
    '        End Try 

    '        If txtCode.Text = txtOyaCode.Text Then 
    '            CType(sender, CustomValidator).ErrorMessage = "自工程コードは入力できません" 
    '            e.IsValid = False 
    '        End If 

    '    End If 
    'End Sub 

    '工程名称 バイト チェック 
    Friend Sub CheckByte20(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valName2.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 20 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    '作業標準チェック 
    Protected Sub CheckHanyou(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valHyoujun2.ServerValidate

        If txtHyoujun.Text = "" Then
            lblHyoujun.Text = ""
            Exit Sub
        End If

        Dim sQuery As String = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS027' AND TELL_CD = :K01 "
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", txtHyoujun.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                lblHyoujun.Text = GetString(oReader, 0)
                args.IsValid = True
            Else
                args.IsValid = False
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader.Close()
        End Try
    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM PROCESS_MST WHERE PROCESS_CD = :K01 "
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", ViewState("code"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                CType(sender, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_UPDATE
                e.IsValid = ViewState("update") = GetString(oReader, 0)
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

    Private Sub GoBack()
        Response.Redirect("mdmas080.aspx?key1=" + ViewState("key1") + "&key2=" + ViewState("key2") + "&page=" + ViewState("page"), False)
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
        Dim sKubun As String = "0"
        If rbtnKo.Checked Then sKubun = "1"
        Dim sGenValues() As String = (txtName.Text.Trim() + "," + ddlShop.SelectedValue + "," + txtMinute.Text.Trim() + "," + txtHyoujun.Text.Trim() + "," + ddlSCode.SelectedValue + "," + sKubun).Split(",")

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) Then
                Select Case i
                    Case 1      'SHOP
                        InsertMH(sItemNames(i), GetShopName(sMotoValues(i)), GetShopName(sGenValues(i)))
                    Case 3      '作業標準
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS027"), GetHanyouName(sGenValues(i), "MS027"))
                    Case 4      '工程集約コード
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS025"), GetHanyouName(sGenValues(i), "MS025"))
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
                If GetString(oReader, 1) <> "工程コード" Then   '主キー以外
                    If GetString(oReader, 1) = "登録日付" Then
                        Exit While
                    Else
                        sResult += GetString(oReader, 1) + ","
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
        Dim iKeySu As Integer = 1       '主キー項目数
        Dim sResult As String = ""
        Try
            sQuery = "SELECT * FROM PROCESS_MST WHERE PROCESS_CD = :KEY1"
            _oDatabase.CreateParam("KEY1", ViewState("code"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                For i = iKeySu To iItemSu - 1 + iKeySu
                    Try
                        sResult += GetString(oReader, i) + ","
                    Catch ex As Exception
                        sResult += GetInt32(oReader, i).ToString + ","
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
            sQuery += "SELECT SHOP||':'||SHOP_NM FROM SHOP_MST WHERE SHOP = :K01"
            _oDatabase.CreateParam("K01", sKey)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            oReader.Read()
            sResult = GetString(oReader, 0)
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
 
