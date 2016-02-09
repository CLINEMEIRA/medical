Imports System.Data 
Imports System.Data.OracleClient 
Imports System.Drawing 
 
Partial Class master_mdmas1401 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS140" 
    Private Const PROGRAM_TITLE As String = "汎用マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "GENERAL_PURPOSE_TBL"
    Private Const TABLE_NAME_JP As String = "汎用マスタ"

#Region " ページ "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Dim sMode As String = "i"
        Dim sCode1 As String = ""
        Dim sCode2 As String = ""
        Dim sKey As String = ""
        Dim sPage As String = "0"
        If Not Page.IsPostBack Then
            If Not Request.QueryString("mode") Is Nothing Then sMode = Request.QueryString("mode")
            If Not Request.QueryString("code1") Is Nothing Then sCode1 = Request.QueryString("code1")
            If Not Request.QueryString("code2") Is Nothing Then sCode2 = Request.QueryString("code2")
            If Not Request.QueryString("key") Is Nothing Then sKey = Request.QueryString("key")
            If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page")
            ViewState("mode") = sMode
            ViewState("code1") = sCode1
            ViewState("code2") = sCode2
            ViewState("key") = sKey
            ViewState("page") = sPage
            If sMode.Equals("u") Then
                DisplayShow1()
                imgProcessTitle.ImageUrl = "../image/t_update.gif"
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Update())
                cmdRun.Attributes("src") = "../image/b_update.gif"
                cmdRun.Visible = MedicalLib.Common.EnableUpdate
                txtKanji.Focus()
            Else
                DisplayShow2()
                imgProcessTitle.ImageUrl = "../image/t_insert.gif"
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Insert())
                cmdRun.Attributes("src") = "../image/b_insert.gif"
                cmdRun.Visible = MedicalLib.Common.EnableInsert
                txtCode.Focus()
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

#Region " ボタン "

    '登録＆修正ボタン押下処理 
    Protected Sub cmdRun_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdRun.Click
        Dim sQuery As String = ""
        valCode3.Enabled = ViewState("mode").Equals("i")
        Page.Validate("check")
        If Page.IsValid Then
            Try
                _oDatabase.BeginTrans()
                '追加/更新 
                If ViewState("mode").Trim.Equals("i") Then

                    'マスタ更新履歴テーブル追加
                    InsertHistory(txtKubun.Text.Trim + ":" + txtCode.Text.Trim)

                    sQuery = "INSERT INTO GENERAL_PURPOSE_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," +
                                                            ":F11,:F12)"
                    _oDatabase.CreateParam("F01", txtKubun.Text.Trim())
                    _oDatabase.CreateParam("F02", txtCode.Text.Trim())
                    _oDatabase.CreateParam("F03", lblName.Text.Trim())
                    _oDatabase.CreateParam("F04", txtKanji.Text.Trim())
                    _oDatabase.CreateParam("F05", txtKana.Text.Trim())
                    _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F08", Session("UserID"))
                    _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F11", Session("UserID"))
                    _oDatabase.CreateParam("F12", MedicalLib.Common.ProgramID)
                Else
                    Page.Validate("update")
                    If Not Page.IsValid Then Exit Sub

                    'マスタ更新履歴テーブル追加
                    UpdateHistory()

                    sQuery = "UPDATE GENERAL_PURPOSE_TBL SET "
                    sQuery += "INFO_KB_NM = :F01,"
                    sQuery += "ITEM_NM = :F02,"
                    sQuery += "ITEM_KN = :F03,"
                    sQuery += "UPD_DT = :F04,"
                    sQuery += "UPD_TIME = :F05,"
                    sQuery += "UPD_USR = :F06,"
                    sQuery += "UPD_PROGRAM_ID  = :F07 "
                    sQuery += "WHERE INFO_KB = :K01 AND TELL_CD = :K02"
                    _oDatabase.CreateParam("F01", lblName.Text.Trim())
                    _oDatabase.CreateParam("F02", txtKanji.Text.Trim())
                    _oDatabase.CreateParam("F03", txtKana.Text.Trim())
                    _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F06", Session("UserID"))
                    _oDatabase.CreateParam("F07", MedicalLib.Common.ProgramID)
                    _oDatabase.CreateParam("K01", txtKubun.Text.Trim())
                    _oDatabase.CreateParam("K02", txtCode.Text.Trim())
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
            '削除 
            Try
                _oDatabase.BeginTrans()

                'マスタ更新履歴テーブル追加
                DeleteHistory()

                Dim sQuery As String = "DELETE FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = :K01 AND TELL_CD = :K02"

                _oDatabase.CreateParam("K01", txtKubun.Text.Trim())
                _oDatabase.CreateParam("K02", txtCode.Text.Trim())
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
        txtKubun.Text = ""
        txtCode.Text = ""
        lblName.Text = ""
        txtKanji.Text = ""
        txtKana.Text = ""
        If ViewState("mode").Equals("u") Then
            DisplayShow1()
        Else
            DisplayShow2()
        End If
    End Sub

#End Region

#Region " ユーザー関数 "

    '訂正モード 
    Private Sub DisplayShow1() 
        Try 
            Dim sQuery As String = "SELECT INFO_KB,TELL_CD,INFO_KB_NM,ITEM_NM,ITEM_KN,UPD_DT||UPD_TIME FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = :K01 AND TELL_CD = :K02" 
            _oDatabase.CreateParam("K01", ViewState("code1")) 
            _oDatabase.CreateParam("K02", ViewState("code2")) 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                txtKubun.Text = oReader.GetString(0).Trim() 
                If txtKubun.Text.Equals("C0001") Then 
                    valKanji1.Enabled = False 
                    valKanji2.Enabled = False 
                    valKanjiC0001.Enabled = True 
                    valKana1.Enabled = False 
                    valKana2.Enabled = False 
                    valKanaC0001.Enabled = True 
                    txtKana.BackColor = Color.FromArgb(255, 255, 192) '黄色 
                ElseIf txtKubun.Text.Equals("MS002") Then 
                    valKana1.Enabled = True 
                    txtKana.BackColor = Color.FromArgb(255, 255, 192) '黄色 
                Else 
                    valKana1.Enabled = False 
                    txtKana.BackColor = Nothing 
                End If 
                txtKubun.Enabled = False 
                If Not oReader.IsDBNull(1) Then txtCode.Text = oReader.GetString(1).Trim() 
                txtCode.Enabled = False 
                If Not oReader.IsDBNull(2) Then lblName.Text = oReader.GetString(2).Trim() 
                If Not oReader.IsDBNull(3) Then txtKanji.Text = oReader.GetString(3).Trim() 
                If Not oReader.IsDBNull(4) Then 
                    txtKana.Text = oReader.GetString(4).Trim() 
                    ViewState("kana") = oReader.GetString(4).Trim() 
                End If 
                ViewState("update") = oReader.GetString(5).Trim() 
            End If 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
    '登録モード 
    Private Sub DisplayShow2() 
        Try 
            Dim sQuery As String = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'C0001' AND ITEM_KN = :K01" 
            _oDatabase.CreateParam("K01", ViewState("code1")) 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                txtKubun.Text = ViewState("code1") 
                txtKubun.Enabled = False 
                If txtKubun.Text.Equals("C0001") Then 
                    valKanji1.Enabled = False 
                    valKanji2.Enabled = False 
                    valKanjiC0001.Enabled = True 
                    valKana1.Enabled = False 
                    valKana2.Enabled = False 
                    valKanaC0001.Enabled = True 
                    txtKana.BackColor = Color.FromArgb(255, 255, 192) '黄色 
                ElseIf txtKubun.Text.Equals("MS002") Then 
                    valKana1.Enabled = True 
                    txtKana.BackColor = Color.FromArgb(255, 255, 192) '黄色 
                Else 
                    valKana1.Enabled = False 
                    txtKana.BackColor = Nothing 
                End If 
                If Not oReader.IsDBNull(0) Then lblName.Text = oReader.GetString(0).Trim() 
            End If 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub

    '情報区分存在チェック 
    Friend Sub CheckKubun(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valKubun3.ServerValidate
        Try
            Dim sQuery As String = "SELECT INFO_KB FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'C0001' AND ITEM_KN = :K01"
            _oDatabase.CreateParam("K01", txtKubun.Text.Trim())
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '識別コード チェック 
    Friend Sub CheckCode(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valCode3.ServerValidate
        Try
            'If Not valCode2.IsValid Then Return
            Select txtKubun.Text.Trim
                Case "MS036" '20120224追加
                    'MS036 シリーズの場合のみ'-'を許可する
                    CType(sender, CustomValidator).ErrorMessage = "半角数字及びハイフンで入力してください"
                    If Not Regex.IsMatch(txtCode.Text, "^[a-zA-Z0-9-]*$") Then
                        e.IsValid = False
                        Return
                        Exit Sub
                    End If
                Case Else '20120224追加
                    'MS036 シリーズ以外の場合
                    CType(sender, CustomValidator).ErrorMessage = "半角数字で入力してください"
                    If Not Regex.IsMatch(txtCode.Text, "^[a-zA-Z0-9]*$") Then
                        e.IsValid = False
                        Return
                        Exit Sub
                    End If
                    Select Case txtKubun.Text.Trim
                        Case "MS020", "MS021", "MS022", "MS023"
                            CType(sender, CustomValidator).ErrorMessage = "整数3桁で入力してください"
                            If Not Regex.IsMatch(txtCode.Text.Trim, "^[1-9][0-9]{0,2}$") Then
                                e.IsValid = False
                                Return
                            End If
                        Case "MS031", "MS032"
                            CType(sender, CustomValidator).ErrorMessage = "SHOPマスタに存在しません"
                            If CheckShop(txtCode.Text.Trim()) = False Then
                                e.IsValid = False
                                Return
                            End If
                    End Select
            End Select
            CType(sender, CustomValidator).ErrorMessage = "既に登録されています"
            Dim sQuery As String = "SELECT INFO_KB FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = :K01 AND TELL_CD = :K02"
            _oDatabase.CreateParam("K01", txtKubun.Text.Trim())
            _oDatabase.CreateParam("K02", txtCode.Text.Trim())
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = Not oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    'SHOP存在チェック
    Friend Function CheckShop(ByVal sShop As String) As Boolean

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Try
            sQuery = ""
            sQuery += "SELECT SHOP"
            sQuery += "  FROM SHOP_MST"
            sQuery += " WHERE SHOP = : K01 "

            _oDatabase.CreateParam("K01", sShop)
            oReader = _oDatabase.CreateReaderParam(sQuery)

            CheckShop = oReader.HasRows

        Catch ex As Exception
            Throw
        Finally
            oReader.Close()
        End Try

    End Function

    '項目名カナ バイト チェック 
    Friend Sub CheckKana(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valKanji2.ServerValidate, valKana2.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 50 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    'C0001時 項目名漢字チェック 
    Protected Sub CheckKanjiC0001(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valKanjiC0001.ServerValidate

        Dim val As CustomValidator = CType(source, CustomValidator)

        '必須 
        If args.Value = "" Then
            val.ErrorMessage = "必須入力項目です"
            args.IsValid = False
            Exit Sub
        End If

        '20バイト以内 
        If System.Text.Encoding.GetEncoding(932).GetByteCount(args.Value.Trim) > 20 Then
            val.ErrorMessage = "20バイト以内で入力して下さい"
            args.IsValid = False
        End If

    End Sub
 
    'C0001時 項目名カナチェック 
    Protected Sub CheckKanaC0001(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valKanaC0001.ServerValidate

        Dim val As CustomValidator = CType(source, CustomValidator)

        '必須 
        If args.Value = "" Then
            val.ErrorMessage = "必須入力項目です"
            args.IsValid = False
            Exit Sub
        End If

        '入力規則 
        If Not Regex.IsMatch(args.Value, "^[a-zA-Z0-9]*$") Then
            val.ErrorMessage = "半角数字記号で入力してください"
            args.IsValid = False
            Exit Sub
        End If

        '５文字以内 
        If args.Value.Length > 5 Then
            val.ErrorMessage = "５文字以内で入力してください"
            args.IsValid = False
            Exit Sub
        End If

        '存在チェック 
        Try
            If txtKana.Text = ViewState("kana") Then Exit Sub
            Dim sQuery As String = ""
            sQuery += "SELECT INFO_KB FROM GENERAL_PURPOSE_TBL "
            sQuery += "WHERE INFO_KB = 'C0001' AND ITEM_KN = :K01 "

            _oDatabase.CreateParam("K01", txtKana.Text.Trim())

            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            val.ErrorMessage = "入力された情報区分は既に登録されています"
            args.IsValid = Not oReader.HasRows

            oReader.Close()

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = :K01 AND TELL_CD = :K02 "
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

    Private Sub GoBack() 
        Response.Redirect("mdmas140.aspx?key=" + ViewState("key") + "&page=" + ViewState("page"), False) 
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
        Dim sGenValues() As String = (lblName.Text.Trim() + "," + txtKanji.Text.Trim() + "," + txtKana.Text.Trim()).Split(",")

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) Then
                InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i))
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
                If GetString(oReader, 1) <> "情報区分" And GetString(oReader, 1) <> "識別コード" Then   '主キー以外
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
        Dim iKeySu As Integer = 2       '主キー項目数
        Dim sResult As String = ""
        Try
            sQuery = "SELECT * FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = :KEY1 AND TELL_CD = :KEY2"
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

#End Region

End Class 
