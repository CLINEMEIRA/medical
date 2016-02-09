Imports System.Data 
Imports System.Data.OracleClient 
Imports System.Drawing

Partial Class master_mdmas1201
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS120"
    Private Const PROGRAM_TITLE As String = "外注マスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess
    Private Const CON_MST As String = "CONTRACTOUT_MST"
    Private Const CON_NAME_JP As String = "外注マスタ"
    Private Const SHOP_MST As String = "SHOP_MST"
    Private Const SHOP_NAME_JP As String = "SHOPマスタ"

#Region " イベント "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Dim sMode As String = "i"
        Dim sCode As String = ""
        Dim sKey As String = ""
        Dim sPage As String = "0"
        If Not Page.IsPostBack Then
            If Not Request.QueryString("mode") Is Nothing Then sMode = Request.QueryString("mode")
            If Not Request.QueryString("code") Is Nothing Then sCode = Request.QueryString("code")
            If Not Request.QueryString("key") Is Nothing Then sKey = Request.QueryString("key")
            If Not Request.QueryString("page") Is Nothing Then sPage = Request.QueryString("page")
            ViewState("mode") = sMode
            ViewState("code") = sCode
            ViewState("key") = sKey
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
            'chkKubun.Checked = True 
        End If
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    '登録＆修正ボタン押下処理 
    Protected Sub cmdRun_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdRun.Click
        Dim sQuery As String = ""
        Dim sShopNM As String = ""

        valCode3.Enabled = ViewState("mode").Equals("i")
        Page.Validate("check")
        If Page.IsValid Then
            _oDatabase.BeginTrans()

            Try
                '追加/更新 
                If ViewState("mode").Trim.Equals("i") Then

                    'マスタ更新履歴テーブル追加
                    InsertHistory(txtCode.Text.Trim, CON_MST)

                    sQuery = "INSERT INTO CONTRACTOUT_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," +
                                                            ":F11,:F12,:F13,:F14,:F15,:F16,:F17,:F18)"
                    _oDatabase.CreateParam("F01", txtCode.Text.Trim())
                    _oDatabase.CreateParam("F02", txtName.Text.Trim())
                    _oDatabase.CreateParam("F03", txtRyaku.Text.Trim())
                    _oDatabase.CreateParam("F04", txtZip.Text.Trim())
                    _oDatabase.CreateParam("F05", txtAddress1.Text.Trim())
                    _oDatabase.CreateParam("F06", txtAddress2.Text.Trim())
                    _oDatabase.CreateParam("F07", txtAddress3.Text.Trim())
                    _oDatabase.CreateParam("F08", txtTel.Text.Trim())
                    _oDatabase.CreateParam("F09", txtFax.Text.Trim())
                    _oDatabase.CreateParam("F10", txtTanto.Text.Trim())
                    If chkKubun.Checked Then
                        _oDatabase.CreateParam("F11", "1")
                    Else
                        _oDatabase.CreateParam("F11", "0")
                    End If
                    _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F13", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F14", Session("UserID"))
                    _oDatabase.CreateParam("F15", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F16", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F17", Session("UserID"))
                    _oDatabase.CreateParam("F18", MedicalLib.Common.ProgramID)

                    _oDatabase.ExecuteNonQueryParam(sQuery)

                    '**** 2010/08 SHOPマスタ更新処理 追加 ST ****
                    sShopNM = GetShopNM(Me.txtRyaku.Text.Trim)
                    If sShopNM <> "" Then
                        'SHOPマスタに存在して

                        If sShopNM <> Me.txtName.Text.Trim Then
                            '名称が違う時
                            ViewState("ryaku") = Me.txtRyaku.Text.Trim

                            UpdateHistory(SHOP_MST)

                            sQuery = ""
                            sQuery += "UPDATE SHOP_MST"
                            sQuery += "   SET SHOP = :F01"
                            sQuery += "     , SHOP_NM = :F02"
                            sQuery += "     , UPD_DT = :F03"
                            sQuery += "     , UPD_TIME = :F04"
                            sQuery += "     , UPD_USR = :F05"
                            sQuery += "     , UPD_PROGRAM_ID = :F06"
                            sQuery += " WHERE SHOP = :K01"

                            _oDatabase.CreateParam("F01", Me.txtRyaku.Text.Trim())
                            _oDatabase.CreateParam("F02", Me.txtName.Text.Trim())
                            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F05", Session("UserID"))
                            _oDatabase.CreateParam("F06", MedicalLib.Common.ProgramID)
                            _oDatabase.CreateParam("K01", Me.txtRyaku.Text.Trim)

                            _oDatabase.ExecuteNonQueryParam(sQuery)
                        End If

                    Else
                        'SHOPマスタに存在しなかったら

                        InsertHistory(Me.txtRyaku.Text.Trim, SHOP_MST)

                        sQuery = ""
                        sQuery += "INSERT INTO SHOP_MST"
                        sQuery += " (SHOP, SHOP_NM, ORGANIZE_CD"
                        sQuery += ", CRT_DT, CRT_TIME, CRT_USR"
                        sQuery += ", UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                        sQuery += " ) VALUES ("
                        sQuery += "  :F01, :F02, :F03"
                        sQuery += ", :F04, :F05, :F06"
                        sQuery += ", :F07, :F08, :F09, :F10"
                        sQuery += " )"

                        _oDatabase.CreateParam("F01", txtRyaku.Text.Trim)
                        _oDatabase.CreateParam("F02", txtName.Text.Trim)
                        _oDatabase.CreateParam("F03", "")
                        _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F06", Session("UserID"))
                        _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F09", Session("UserID"))
                        _oDatabase.CreateParam("F10", MedicalLib.Common.ProgramID)

                        _oDatabase.ExecuteNonQueryParam(sQuery)
                    End If
                    '**** 2010/08 SHOPマスタ更新処理 追加 ED ****
                Else
                    Page.Validate("update")
                    If Not Page.IsValid Then Exit Sub

                    'マスタ更新履歴テーブル追加
                    UpdateHistory(CON_MST)

                    sQuery = "UPDATE CONTRACTOUT_MST SET CONTRACTOUT_NM=:F01,CONTRACTOUT_OMIS=:F02,POST_NO=:F03,ADDR1=:F04,ADDR2=:F05,ADDR3=:F06," +
                                                   "TEL=:F07,FAX_NO=:F08,PERSON_CHARGE=:F09,CONTRACTOUT_KB=:F10," +
                                                   "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 " +
                                                   "WHERE CONTRACTOUT_CD=:K01"
                    _oDatabase.CreateParam("F01", txtName.Text.Trim())
                    _oDatabase.CreateParam("F02", txtRyaku.Text.Trim())
                    _oDatabase.CreateParam("F03", txtZip.Text.Trim())
                    _oDatabase.CreateParam("F04", txtAddress1.Text.Trim())
                    _oDatabase.CreateParam("F05", txtAddress2.Text.Trim())
                    _oDatabase.CreateParam("F06", txtAddress3.Text.Trim())
                    _oDatabase.CreateParam("F07", txtTel.Text.Trim())
                    _oDatabase.CreateParam("F08", txtFax.Text.Trim())
                    _oDatabase.CreateParam("F09", txtTanto.Text.Trim())
                    If chkKubun.Checked Then
                        _oDatabase.CreateParam("F10", "1")
                    Else
                        _oDatabase.CreateParam("F10", "0")
                    End If
                    _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F13", Session("UserID"))
                    _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
                    _oDatabase.CreateParam("K01", txtCode.Text.Trim())

                    _oDatabase.ExecuteNonQueryParam(sQuery)

                    '**** 2010/08 SHOPマスタ更新処理 追加 ST ****
                    If ViewState("ryaku") <> Me.txtRyaku.Text.Trim Then
                        ''略号を変更した時
                        '###### 2014/03/21 SHOPマスタ未登録時対応 ST ######
                        'UpdateHistory(SHOP_MST)

                        'sQuery = ""
                        'sQuery += "UPDATE SHOP_MST"
                        'sQuery += "   SET SHOP = :F01"
                        'sQuery += "     , SHOP_NM = :F02"
                        'sQuery += "     , UPD_DT = :F03"
                        'sQuery += "     , UPD_TIME = :F04"
                        'sQuery += "     , UPD_USR = :F05"
                        'sQuery += "     , UPD_PROGRAM_ID = :F06"
                        'sQuery += " WHERE SHOP = :K01"

                        '_oDatabase.CreateParam("F01", Me.txtRyaku.Text.Trim())
                        '_oDatabase.CreateParam("F02", Me.txtName.Text.Trim())
                        '_oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)
                        '_oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)
                        '_oDatabase.CreateParam("F05", Session("UserID"))
                        '_oDatabase.CreateParam("F06", MedicalLib.Common.ProgramID)
                        '_oDatabase.CreateParam("K01", Me.txtRyaku.Text.Trim)

                        '_oDatabase.ExecuteNonQueryParam(sQuery)
                        sShopNM = GetShopNM(Me.txtRyaku.Text.Trim)
                        If sShopNM <> "" Then
                            'SHOPマスタに存在して
                            If sShopNM <> Me.txtName.Text.Trim Then
                                '名称が違う時
                                ViewState("ryaku") = Me.txtRyaku.Text.Trim

                                UpdateHistory(SHOP_MST)

                                sQuery = ""
                                sQuery += "UPDATE SHOP_MST"
                                sQuery += "   SET SHOP = :F01"
                                sQuery += "     , SHOP_NM = :F02"
                                sQuery += "     , UPD_DT = :F03"
                                sQuery += "     , UPD_TIME = :F04"
                                sQuery += "     , UPD_USR = :F05"
                                sQuery += "     , UPD_PROGRAM_ID = :F06"
                                sQuery += " WHERE SHOP = :K01"

                                _oDatabase.CreateParam("F01", Me.txtRyaku.Text.Trim())
                                _oDatabase.CreateParam("F02", Me.txtName.Text.Trim())
                                _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)
                                _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)
                                _oDatabase.CreateParam("F05", Session("UserID"))
                                _oDatabase.CreateParam("F06", MedicalLib.Common.ProgramID)
                                _oDatabase.CreateParam("K01", Me.txtRyaku.Text.Trim)

                                _oDatabase.ExecuteNonQueryParam(sQuery)
                            End If

                        Else
                            'SHOPマスタに存在しなかったら

                            InsertHistory(Me.txtRyaku.Text.Trim, SHOP_MST)

                            sQuery = ""
                            sQuery += "INSERT INTO SHOP_MST"
                            sQuery += " (SHOP, SHOP_NM, ORGANIZE_CD"
                            sQuery += ", CRT_DT, CRT_TIME, CRT_USR"
                            sQuery += ", UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                            sQuery += " ) VALUES ("
                            sQuery += "  :F01, :F02, :F03"
                            sQuery += ", :F04, :F05, :F06"
                            sQuery += ", :F07, :F08, :F09, :F10"
                            sQuery += " )"

                            _oDatabase.CreateParam("F01", txtRyaku.Text.Trim)
                            _oDatabase.CreateParam("F02", txtName.Text.Trim)
                            _oDatabase.CreateParam("F03", "")
                            _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F06", Session("UserID"))
                            _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F09", Session("UserID"))
                            _oDatabase.CreateParam("F10", MedicalLib.Common.ProgramID)

                            _oDatabase.ExecuteNonQueryParam(sQuery)
                        End If
                        '###### 2014/03/21 SHOPマスタ未登録時対応 ED ######
                    End If
                    '**** 2010/08 SHOPマスタ更新処理 追加 ED ****
                End If
                _oDatabase.CommitTrans()
            Catch ex As Exception
                _oDatabase.Rollback()
                MedicalLib.PageError.Show(ex.Message)
            End Try
            GoBack()
        End If
    End Sub

    '削除ボタン押下処理 
    Protected Sub cmdDel_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdDel.Click
        valCode3.Enabled = False
        Page.Validate("check")
        If Page.IsValid Then
            Page.Validate("update")
            If Not Page.IsValid() Then Exit Sub

            _oDatabase.BeginTrans()
            Try
                'マスタ更新履歴テーブル追加
                DeleteHistory(CON_MST)

                '削除 
                Dim sQuery As String
                sQuery = "DELETE FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :KEY1"
                _oDatabase.CreateParam("KEY1", txtCode.Text.Trim())
                _oDatabase.ExecuteNonQueryParam(sQuery)


                '**** 2010/08 SHOPマスタ更新処理 追加 ST ****
                DeleteHistory(SHOP_MST)

                sQuery = ""
                sQuery += "DELETE FROM SHOP_MST"
                sQuery += " WHERE SHOP = :K01"

                _oDatabase.CreateParam("K01", txtRyaku.Text.Trim())
                _oDatabase.ExecuteNonQueryParam(sQuery)
                '**** 2010/08 SHOPマスタ更新処理 追加 ED ****

                _oDatabase.CommitTrans()
                GoBack()
            Catch ex As Exception
                _oDatabase.Rollback()
                MedicalLib.PageError.Show(ex.Message)
            End Try
        End If
    End Sub

    'クリアボタン押下処理 
    Protected Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdClear.Click
        If ViewState("mode").Equals("i") Then
            DisplayInit()
        Else
            DisplayShow()
        End If
    End Sub

    '戻るボタン押下処理 
    Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdBack.Click
        GoBack()
    End Sub

#End Region

#Region " 画面関連 "

    '画面初期化 
    Private Sub DisplayInit()
        txtCode.Text = ""
        txtName.Text = ""
        txtRyaku.Text = ""
        txtZip.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtAddress3.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
        txtTanto.Text = ""
        chkKubun.Checked = True
    End Sub

    '画面表示 
    Private Sub DisplayShow()
        Try
            Dim sQuery As String = "SELECT * FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :KEY1"
            _oDatabase.CreateParam("KEY1", ViewState("code"))
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                txtCode.Text = GetString(oReader, 0)
                txtCode.Enabled = False
                txtName.Text = GetString(oReader, 1)
                txtRyaku.Text = GetString(oReader, 2)
                ViewState("ryaku") = GetString(oReader, 2)
                If Not oReader.IsDBNull(3) Then txtZip.Text = oReader.GetString(3).Trim()
                If Not oReader.IsDBNull(4) Then txtAddress1.Text = oReader.GetString(4).Trim()
                If Not oReader.IsDBNull(5) Then txtAddress2.Text = oReader.GetString(5).Trim()
                If Not oReader.IsDBNull(6) Then txtAddress3.Text = oReader.GetString(6).Trim()
                If Not oReader.IsDBNull(7) Then txtTel.Text = oReader.GetString(7).Trim()
                If Not oReader.IsDBNull(8) Then txtFax.Text = oReader.GetString(8).Trim()
                If Not oReader.IsDBNull(9) Then txtTanto.Text = oReader.GetString(9).Trim()
                If Not oReader.IsDBNull(10) Then
                    If oReader.GetString(10).Trim() = "1" Then
                        chkKubun.Checked = True
                    Else
                        chkKubun.Checked = False
                    End If
                Else
                    chkKubun.Checked = False
                End If
                ViewState("update") = oReader.GetString(14) + oReader.GetString(15)
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " チェック関連 "

    '外注コード存在チェック 
    Friend Sub CheckCode(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valCode3.ServerValidate
        Try
            Dim sQuery As String = "SELECT * FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :KEY1"
            _oDatabase.CreateParam("KEY1", txtCode.Text.Trim.PadLeft(4, "0"))
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = Not oReader.HasRows
            oReader.Close()
            If e.IsValid Then txtCode.Text = txtCode.Text.Trim.PadLeft(4, "0")
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '外注略号存在チェック 
    Friend Sub CheckRyaku(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valRyaku3.ServerValidate
        If ViewState("mode") = "u" Then
            If txtRyaku.Text.Equals(ViewState("ryaku")) Then
                e.IsValid = True
                Exit Sub
            End If
        End If
        Try
            Dim sQuery As String = "SELECT * FROM CONTRACTOUT_MST WHERE CONTRACTOUT_OMIS = :KEY1"
            _oDatabase.CreateParam("KEY1", txtRyaku.Text.Trim())
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            e.IsValid = Not oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    'バイト チェック30 
    Friend Sub CheckByte30(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valAddress11.ServerValidate,
                                                                                               valAddress21.ServerValidate,
                                                                                               valAddress31.ServerValidate,
                                                                                               valName2.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 30 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    'バイト チェック12 
    Friend Sub CheckByte12(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valTanto.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(e.Value.Trim) > 12 Then
            e.IsValid = False
        Else
            e.IsValid = True
        End If
    End Sub

    '住所１チェック 
    Friend Sub CheckAddress1(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valAddress12.ServerValidate
        e.IsValid = Not (txtAddress1.Text.Trim.Equals("") And (Not txtAddress2.Text.Trim.Equals("") Or Not txtAddress3.Text.Trim.Equals("")))
    End Sub

    '住所２チェック 
    Friend Sub CheckAddress2(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valAddress22.ServerValidate
        e.IsValid = Not (txtAddress2.Text.Trim.Equals("") And Not txtAddress3.Text.Trim.Equals(""))
    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :K01 "
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

#End Region

#Region " ユーザ関数 "

    'SHOP名取得        2010/08 追加
    Private Function GetShopNM(ByVal sShop As String) As String

        Dim sQuery As String = ""
        Dim sShopNM As String = ""

        sQuery += "SELECT SHOP_NM"
        sQuery += "  FROM SHOP_MST"
        sQuery += " WHERE SHOP = :K01"

        _oDatabase.CreateParam("K01", sShop)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                sShopNM = GetString(oReader, 0).Trim
            End If
        End Using

        Return sShopNM

    End Function

#End Region

#Region " その他 "

    Private Sub GoBack()
        Response.Redirect("mdmas120.aspx?key=" + ViewState("key") + "&page=" + ViewState("page"), False)
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

    Private Sub InsertHistory(ByVal sKey As String, ByVal sTable As String)
        Select Case sTable
            Case CON_MST
                InsertMH(sKey, "追加", "", "", CON_NAME_JP)
            Case SHOP_MST
                InsertMH(sKey, "追加", "", "", SHOP_NAME_JP)
        End Select
    End Sub

    Private Sub DeleteHistory(ByVal sTable As String)
        Select Case sTable
            Case CON_MST
                InsertMH("削除", "", "", CON_NAME_JP)
            Case SHOP_MST
                InsertMH("削除", "", "", SHOP_NAME_JP)
        End Select
    End Sub

    Private Sub UpdateHistory(ByVal sTable As String)
        Dim sItemNames() As String = GetItemName(sTable).Split(",")
        Dim sMotoValues() As String = GetMotoValue(sItemNames.Length(), sTable).Split(",")
        Dim sKubun As String = "0"
        If chkKubun.Checked Then sKubun = "1"

        Dim sGenValues() As String = Nothing
        Select Case sTable
            Case CON_MST
                sGenValues = (txtName.Text.Trim() + "," + txtRyaku.Text.Trim() + "," + txtZip.Text.Trim() + "," + txtAddress1.Text.Trim() + "," + txtAddress2.Text.Trim() + "," + txtAddress3.Text.Trim() + "," + txtTel.Text.Trim() + "," + txtFax.Text.Trim() + "," + txtTanto.Text.Trim() + "," + sKubun).Split(",")
            Case SHOP_MST
                sGenValues = (Me.txtRyaku.Text.Trim & "," & Me.txtName.Text.Trim).Split(",")
        End Select

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) Then
                Select Case sTable
                    Case CON_MST
                        InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i), CON_NAME_JP)
                    Case SHOP_MST
                        InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i), SHOP_NAME_JP)
                End Select
            End If
        Next
    End Sub

    '項目名をコンマ区切りで返す
    Private Function GetItemName(ByVal sTable As String) As String
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
            _oDatabase.CreateParam("K02", sTable)
            oReader = _oDatabase.CreateReaderParam(sQuery)

            Select Case sTable
                Case CON_MST
                    While oReader.Read
                        If GetString(oReader, 1) <> "外注コード" Then   '主キー以外
                            If GetString(oReader, 1) = "登録日付" Then
                                Exit While
                            Else
                                sResult += GetString(oReader, 1) + ","
                            End If
                        End If
                    End While

                Case SHOP_MST
                    While oReader.Read
                        If GetString(oReader, 1) <> "SHOP" Then   '主キー以外
                            If GetString(oReader, 1) = "登録日付" Then
                                Exit While
                            Else
                                sResult += GetString(oReader, 1) + ","
                            End If
                        End If
                    End While

            End Select

            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult.Substring(0, sResult.Length - 1)
    End Function

    '更新前項目をコンマ区切りで返す
    Private Function GetMotoValue(ByVal iItemSu As Integer, ByVal sTable As String) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Dim i As Integer = 0
        Dim iKeySu As Integer = 1       '主キー項目数
        Dim sResult As String = ""
        Try
            Select Case sTable
                Case CON_MST
                    sQuery = "SELECT * FROM CONTRACTOUT_MST WHERE CONTRACTOUT_CD = :KEY1"
                    _oDatabase.CreateParam("KEY1", ViewState("code"))
                    oReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        For i = iKeySu To iItemSu - 1 + iKeySu
                            sResult += GetString(oReader, i) + ","
                        Next
                    End If

                Case SHOP_MST
                    sQuery = "SELECT SHOP, SHOP_NM FROM SHOP_MST WHERE SHOP = :KEY1"
                    _oDatabase.CreateParam("KEY1", ViewState("ryaku"))
                    oReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        For i = 0 To oReader.FieldCount - 1
                            sResult += GetString(oReader, i) + ","
                        Next

                    End If

            End Select

            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult.Substring(0, sResult.Length - 1)
    End Function

    'マスタ更新履歴テーブル追加
    Private Sub InsertMH(ByVal sItemName As String, ByVal sMae As String, ByVal sAto As String, ByVal sTable_JP As String)
        Select Case sTable_JP
            Case CON_NAME_JP
                InsertMH(ViewState("code"), sItemName, sMae, sAto, sTable_JP)
            Case SHOP_NAME_JP
                InsertMH(ViewState("ryaku"), sItemName, sMae, sAto, sTable_JP)
        End Select
    End Sub

    Private Sub InsertMH(ByVal sKey As String, ByVal sItemName As String, ByVal sMae As String, ByVal sAto As String, ByVal sTable_JP As String)
        Dim sQuery As String = ""

        sQuery = "INSERT INTO MASTER_HIS_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," +
                                                    ":F11,:F12,:F13,:F14)"
        _oDatabase.CreateParam("F01", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F03", sTable_JP)
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
