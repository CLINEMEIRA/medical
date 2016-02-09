Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing 
 
Partial Class master_mdmas0901 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS090" 
    Private Const PROGRAM_TITLE As String = "SHOPマスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "SHOP_MST"
    Private Const TABLE_NAME_JP As String = "SHOPマスタ"
 
#Region " ページ " 
 
    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
 
 
            If Not Page.IsPostBack Then 
                Dim sql As String = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS019' ORDER BY TELL_CD" 
                Dim oDataReader As OracleDataReader = _oDatabase.CreateReader(sql) 
                ddlCode.Items.Add(New ListItem("", "")) 
                Do While oDataReader.Read 
                    ddlCode.Items.Add(New ListItem(oDataReader.GetString(0) + "：" + oDataReader.GetString(1), oDataReader.Item("TELL_CD"))) 
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
                DisplayShow(Request.QueryString("code")) 
                txtName.Focus() 
            Else 
                txtShop.Focus() 
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

#Region " ボタン "

    '登録＆修正ボタン押下処理 
    Protected Sub cmdRun_Click(sender As Object, e As ImageClickEventArgs) Handles cmdRun.Click
        valCode3.Enabled = ViewState("mode").Equals("i")
        Page.Validate("check")
        If Page.IsValid Then
            Dim sQuery As String = ""
            Try
                _oDatabase.BeginTrans()
                '追加/更新 
                If ViewState("mode").Trim.Equals("i") Then

                    'マスタ更新履歴テーブル追加
                    InsertHistory(txtShop.Text.Trim)

                    sQuery = "INSERT INTO SHOP_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10)"
                    _oDatabase.CreateParam("F01", txtShop.Text.Trim())
                    _oDatabase.CreateParam("F02", txtName.Text.Trim())
                    _oDatabase.CreateParam("F03", ddlCode.SelectedValue.Trim())
                    _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F06", Session("UserID"))
                    _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F09", Session("UserID"))
                    _oDatabase.CreateParam("F10", MedicalLib.Common.ProgramID)
                Else
                    Page.Validate("update")
                    If Not Page.IsValid Then Exit Sub

                    'マスタ更新履歴テーブル追加
                    UpdateHistory()

                    sQuery = "UPDATE SHOP_MST SET SHOP_NM = :F01," +
                                                   "ORGANIZE_CD = :F02," +
                                                   "UPD_DT = :F03," +
                                                   "UPD_TIME = :F04," +
                                                   "UPD_USR = :F05," +
                                                   "UPD_PROGRAM_ID = :F06 " +
                                               "WHERE SHOP = :K01"
                    _oDatabase.CreateParam("F01", txtName.Text.Trim())
                    _oDatabase.CreateParam("F02", ddlCode.SelectedValue.Trim())
                    _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F05", Session("UserID"))
                    _oDatabase.CreateParam("F06", MedicalLib.Common.ProgramID)
                    _oDatabase.CreateParam("K01", txtShop.Text.Trim())
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
    Protected Sub cmdDel_Click(sender As Object, e As ImageClickEventArgs) Handles cmdDel.Click

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

                Dim sQuery As String
                sQuery = "DELETE FROM SHOP_MST WHERE SHOP = :K01"

                _oDatabase.CreateParam("K01", txtShop.Text.Trim())
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
    Protected Sub cmdBack_Click(sender As Object, e As ImageClickEventArgs) Handles cmdBack.Click
        GoBack()
    End Sub

    Protected Sub cmdClear_Click(sender As Object, e As ImageClickEventArgs) Handles cmdClear.Click
        If ViewState("mode").Equals("u") Then
            DisplayShow(Request.QueryString("code"))
        Else
            txtShop.Text = ""
            txtName.Text = ""
            ddlCode.SelectedValue = ""
        End If
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub DisplayShow(ByVal sCode As String) 
 
        Try 
            Dim sQuery As String = "SELECT * FROM SHOP_MST WHERE SHOP = :K01" 
            _oDatabase.CreateParam("K01", sCode) 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                txtShop.Text = oReader.GetString(0).Trim() 
                txtShop.Enabled = False 
                txtName.Text = oReader.GetString(1).Trim() 
                If Not oReader.IsDBNull(2) Then 
                    ddlCode.SelectedValue = oReader.GetString(2).Trim() 
                Else 
                    ddlCode.SelectedValue = "" 
                End If 
                ViewState("update") = oReader.GetString(6).Trim() + oReader.GetString(7).Trim() 
            End If 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
 
    End Sub

    'バイト チェック30 
    Friend Sub CheckByte30(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valName2.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 30 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    Friend Sub CheckCode(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valCode3.ServerValidate
        Try
            Dim sQuery As String = "SELECT * FROM SHOP_MST WHERE SHOP = :K01"
            _oDatabase.CreateParam("K01", txtShop.Text.Trim.PadLeft(2, "0"))
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = Not oReader.HasRows
            oReader.Close()
            If e.IsValid Then txtShop.Text = txtShop.Text.Trim.PadLeft(2, "0")
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM SHOP_MST WHERE SHOP = :K01 "
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
        Response.Redirect("mdmas090.aspx?key1=" + ViewState("key1") + "&key2=" + ViewState("key2") + "&page=" + ViewState("page"), False) 
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
        Dim sGenValues() As String = (txtName.Text.Trim() + "," + ddlCode.SelectedValue).Split(",")

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) Then
                Select Case i
                    Case 1      '組織コード
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS019"), GetHanyouName(sGenValues(i), "MS019"))
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
                If GetString(oReader, 1) <> "SHOP" Then   '主キー以外
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
            sQuery = "SELECT * FROM SHOP_MST WHERE SHOP = :KEY1"
            _oDatabase.CreateParam("KEY1", ViewState("code"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                For i = iKeySu To iItemSu - 1 + iKeySu
                    sResult += GetString(oReader, i) + ","
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
