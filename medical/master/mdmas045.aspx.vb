Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing 

Partial Class master_mdmas045
    Inherits System.Web.UI.Page
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS045"
    Private Const PROGRAM_TITLE As String = "部品マスタサブメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "PARTS_MST"
    Private Const TABLE_NAME_JP As String = "部品マスタ"

    'CallBack 
    Public _sCallBackScript As String = ""
    Private _sValue As String = ""

    Private W_Series As String

#Region " イベント "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        _sCallBackScript = Page.ClientScript.GetCallbackEventReference(Me, "command", "getCallBack", "context", "getCallBackError", True) + ";"
        If Not Page.IsPostBack Then
            DisplayInit()
            cmdRun.Attributes.Add("onclick", MedicalLib.Script.Update())
            txtCatalog.Focus()
        End If
        cmdRun.Visible = MedicalLib.Common.EnableUpdate
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    '検索ボタン 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        pnlInfo.Visible = False
        udpInfo.Update()
        Page.Validate("key")
        If Not Page.IsValid Then Return
        'SeriesCode() '20120223追加 20120315仕様変更のため削除
        DisplayShow(txtCatalog.Text.Trim())
        'If txtSeries.Text = "" Then '20120328追加 20120315仕様変更のため削除
        '    txtSeries.BackColor = Color.Pink '転記した場合はテキストボックスを桃色にする
        '    txtSeries.Text = W_Series
        'Else
        '    txtSeries.BackColor = Color.White '転記していない場合はテキストボックスを白色にする
        'End If
    End Sub
    ''Protected Sub cmdSeriesCode_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) 20120315仕様変更のため削除
    '    'シリーズ
    '    If txtSeries.Text = "" Then '20120223追加
    '        'シリーズが空白の場合
    '        'カタログ番号の２つ目のハイフン前のコードを転記
    '        Dim Wi As Integer
    '        Dim Wcount As Integer = 0
    '        For Wi = 1 To txtCatalog.Text.Length
    '            If Mid(txtCatalog.Text, Wi, 1) = "-" Then
    '                If Wcount = 1 Then Exit For '２つ目のハイフンが見つかった場合実行
    '                Wcount = 1 '１つ目のハイフンが見つかった場合のみ実行
    '            End If
    '        Next
    '        W_Series = Mid(txtCatalog.Text, 1, Wi - 1)
    '        If Len(txtSeries.Text) > 10 Then
    '            '転記したコードが11バイト以上なら10バイトにする
    '            W_Series = Mid(txtSeries.Text, 1, 10)
    '        End If
    '    End If

    'End Sub



    ''シリーズボタン押下処理 
    'Protected Sub cmdSeries_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) '20120315追加
    '    Dim sQuery As String = ""
    '    Dim oReader As OracleDataReader = Nothing
    '    Try
    '        sQuery = "SELECT INFO_KB,TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = :K1 AND TELL_CD = :K02 "
    '        _oDatabase.CreateParam("K01", "MS036")
    '        _oDatabase.CreateParam("K02", txtSeries.Text)
    '        oReader = _oDatabase.CreateReaderParam(sQuery)
    '        If oReader.Read() Then
    '            lblSeries.Text = GetString(oReader, 14) '20120315追加
    '            'ViewState("update") = GetString(oReader, 15)
    '        End If
    '        oReader.Close()
    '        'ViewState("catalog") = sCatalog
    '        pnlInfo.Visible = True
    '        udpInfo.Update()
    '    Catch ex As Exception
    '        MedicalLib.PageError.Show(ex.Message)
    '    End Try

    'End Sub

    '戻るボタン押下処理 
    Protected Sub cmdBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdBack.Click
        DisplayClear()
    End Sub

    'リセットボタン押下処理 
    Protected Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdClear.Click
        Try
            DisplayShow(ViewState("catalog"))
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '訂正ボタン押下処理 
    Protected Sub cmdRun_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdRun.Click
        Page.Validate("info")
        If Not Page.IsValid Then Return
        Page.Validate("info2")
        If Not Page.IsValid Then Return
        Page.Validate("update")
        If Not Page.IsValid Then Return
        If Not FileUpdate() Then Return
        DisplayInit()
    End Sub

#End Region

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sReturnValue As String = "" + Chr(9)
        Dim sValues() As String = _sValue.Split(Chr(9))
        If sValues(1).Trim.Equals("") Then Return sReturnValue
        Select Case sValues(0)
            Case "1"
                sQuery = "SELECT C_NO FROM PARTS_MST WHERE CATALOG_NO = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then sReturnValue = GetString(oReader, 0)
                oReader.Close()
            Case "2"
                If Not Regex.IsMatch(sValues(1), "^[0-9]*$") Then
                    sReturnValue = "" + ControlChars.Tab
                    Exit Select
                End If
                If Not IsNumeric(sValues(1)) Then Return sReturnValue
                sQuery = "SELECT GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = '1' AND GRP_NO = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then sReturnValue = GetString(oReader, 0)
                oReader.Close()
            Case "3"
                If Not Regex.IsMatch(sValues(1), "^[0-9]*$") Then
                    sReturnValue = "" + ControlChars.Tab
                    Exit Select
                End If
                If Not IsNumeric(sValues(1)) Then Return sReturnValue
                sQuery = "SELECT GRP_NM,C_NO FROM PRODUCT_GRP_MST WHERE GRP_LV = '2' AND GRP_NO = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then sReturnValue = GetString(oReader, 0) + Chr(9) + GetString(oReader, 1)
                oReader.Close()
            Case "4"
                sQuery = "SELECT * FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS020' AND TELL_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    If Not IsDBNull(oReader("ITEM_KN")) Then sReturnValue = oReader("ITEM_KN").Trim()
                End If
                oReader.Close()
            Case "5"
                sQuery = "SELECT * FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS021' AND TELL_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    If Not IsDBNull(oReader("ITEM_KN")) Then sReturnValue = oReader("ITEM_KN").Trim()
                End If
                oReader.Close()
            Case "6"
                sQuery = "SELECT * FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS022' AND TELL_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    If Not IsDBNull(oReader("ITEM_KN")) Then sReturnValue = oReader("ITEM_KN").Trim()
                End If
                oReader.Close()
            Case "7"
                sQuery = "SELECT * FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS023' AND TELL_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    If Not IsDBNull(oReader("ITEM_KN")) Then sReturnValue = oReader("ITEM_KN").Trim()
                End If
                oReader.Close()
            Case "8"
                sQuery = "SELECT * FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS036' AND TELL_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    If Not IsDBNull(oReader("ITEM_NM")) Then sReturnValue = oReader("ITEM_NM").Trim()
                End If
                oReader.Close()
        End Select
        Return sReturnValue
    End Function

    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        _sValue = eventArgument
    End Sub

#End Region

#Region " 画面関連 "

    '画面初期化 
    Private Sub DisplayInit()
        'txtCatalog.Text = "" 
        lblKumi1.Text = ""
        DisplayClear()
        udpKey.Update()
    End Sub

    '画面クリア 
    Friend Sub DisplayClear()
        txtSeihin1.Text = ""
        lblSeihin1.Text = ""
        txtSeihin2.Text = ""
        lblSeihin2.Text = ""
        txtTorukus.Text = ""
        lblTorukus.Text = ""
        txtJikuKou.Text = ""
        lblJikuKou.Text = ""
        txtZairyou.Text = ""
        lblZairyou.Text = ""
        txtNeji.Text = ""
        lblNeji.Text = ""
        txtSeries.Text = "" '20120223追加
        lblSeries.Text = "" '20120223追加
        pnlInfo.Visible = False
        udpInfo.Update()
    End Sub

    '画面表示 
    Friend Sub DisplayShow(ByVal sCatalog As String)
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT A.PRODUCT_GRPNO1,B.GRP_NM,A.PRODUCT_GRPNO2,C.GRP_NM,C.C_NO,A.TORQUES_NO,D.ITEM_NM,A.SHAFT_SIZE_NO,E.ITEM_NM,A.MATL_SIZE_NO,F.ITEM_NM,A.SIZE_NO,G.ITEM_NM,A.SERIES,H.ITEM_NM,A.UPD_DT || A.UPD_TIME 更新情報 "
            sQuery += "FROM PARTS_MST A,"
            sQuery += "(SELECT GRP_NO,GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = '1') B,"
            sQuery += "(SELECT GRP_NO,GRP_NM,C_NO FROM PRODUCT_GRP_MST WHERE GRP_LV = '2') C,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS020') D,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS021') E,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS022') F,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS023') G,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS036') H " '20120224追加
            sQuery += "WHERE A.PRODUCT_GRPNO1 = B.GRP_NO(+) AND "
            sQuery += "A.PRODUCT_GRPNO2 = C.GRP_NO(+) AND "
            sQuery += "A.TORQUES_NO = D.TELL_CD(+) AND "
            sQuery += "A.SHAFT_SIZE_NO = E.TELL_CD(+) AND "
            sQuery += "A.MATL_SIZE_NO = F.TELL_CD(+) AND "
            sQuery += "A.SIZE_NO = G.TELL_CD(+) AND "
            'If txtSeries.Text = "" Then '20120224追加 20120315仕様変更のため削除
            '    sQuery += "'" + W_Series + "'" + " = H.TELL_CD(+) AND "
            'Else
            sQuery += "A.SERIES = H.TELL_CD(+) AND "
            'End If
            sQuery += "A.CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", sCatalog)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                txtSeihin1.Text = GetInt32(oReader, 0).ToString("#")
                lblSeihin1.Text = GetString(oReader, 1)
                txtSeihin2.Text = GetInt32(oReader, 2).ToString("#")
                lblSeihin2.Text = GetString(oReader, 3)
                lblKumi2.Text = GetString(oReader, 4)
                txtTorukus.Text = GetInt32(oReader, 5).ToString("#")
                lblTorukus.Text = GetString(oReader, 6)
                txtJikuKou.Text = GetInt32(oReader, 7).ToString("#")
                lblJikuKou.Text = GetString(oReader, 8)
                txtZairyou.Text = GetInt32(oReader, 9).ToString("#")
                lblZairyou.Text = GetString(oReader, 10)
                txtNeji.Text = GetInt32(oReader, 11).ToString("#")
                lblNeji.Text = GetString(oReader, 12)
                txtSeries.Text = GetString(oReader, 13) '20120224追加
                lblSeries.Text = GetString(oReader, 14) '20120224追加
                ViewState("update") = GetString(oReader, 15)
            End If
            oReader.Close()
            ViewState("catalog") = sCatalog
            pnlInfo.Visible = True
            udpInfo.Update()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " チェック関連 "

    'カタログ番号 
    Protected Sub valCatalog2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCatalog2.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            lblKumi1.Text = ""
            sQuery = "SELECT C_NO FROM PARTS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", txtCatalog.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                lblKumi1.Text = GetString(oReader, 0)
                args.IsValid = True
            Else
                args.IsValid = False
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '製品グループ1 
    Protected Sub valSeihin1c_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valSeihin1c.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            lblSeihin1.Text = ""
            If Not valSeihin1b.IsValid Then Return
            If txtSeihin1.Text.Trim.Equals("") Then Return
            If CType(txtSeihin1.Text.Trim(), Integer) = 0 Then Return
            sQuery = "SELECT GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = '1' AND GRP_NO = :K01"
            _oDatabase.CreateParam("K01", txtSeihin1.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            If args.IsValid Then lblSeihin1.Text = GetString(oReader, 0)
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '製品グループ2 
    Protected Sub valSeihin2c_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valSeihin2c.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            lblSeihin2.Text = ""
            lblKumi2.Text = ""
            If Not valSeihin2b.IsValid Then Return
            If txtSeihin2.Text.Trim.Equals("") Then Return
            If CType(txtSeihin2.Text.Trim(), Integer) = 0 Then Return
            CType(source, CustomValidator).ErrorMessage = "製品グループマスタに未登録です"
            sQuery = "SELECT GRP_NM,C_NO FROM PRODUCT_GRP_MST WHERE GRP_LV = '2' AND GRP_NO = :K01"
            _oDatabase.CreateParam("K01", txtSeihin2.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            If args.IsValid Then
                lblSeihin2.Text = GetString(oReader, 0)
                lblKumi2.Text = GetString(oReader, 1)
            End If
            oReader.Close()
            If Not args.IsValid Then Return
            CType(source, CustomValidator).ErrorMessage = "組番が異なるグループ２は選択出来ません"
            args.IsValid = lblKumi1.Text = lblKumi2.Text
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '汎用マスタ存在チェック(トルクス) 
    Protected Sub valTorukus3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valTorukus3.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            lblTorukus.Text = ""
            If Not valTorukus2.IsValid Then Return
            If txtTorukus.Text.Trim.Equals("") Then Return
            If CType(txtTorukus.Text.Trim(), Integer) = 0 Then Return
            sQuery = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS020' AND TELL_CD = :K01"
            _oDatabase.CreateParam("K01", txtTorukus.Text())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            If args.IsValid = True Then lblTorukus.Text = GetString(oReader, 0)
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '汎用マスタ存在チェック(軸荒径) 
    Protected Sub valJikuKou3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valJikuKou3.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            lblJikuKou.Text = ""
            If Not valJikuKou2.IsValid Then Return
            If txtJikuKou.Text.Trim.Equals("") Then Return
            If CType(txtJikuKou.Text.Trim(), Integer) = 0 Then Return
            sQuery = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS021' AND TELL_CD = :K01"
            _oDatabase.CreateParam("K01", txtJikuKou.Text())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            If args.IsValid = True Then lblJikuKou.Text = GetString(oReader, 0)
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '汎用マスタ存在チェック(材料) 
    Protected Sub valZairyou3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valZairyou3.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            lblZairyou.Text = ""
            If Not valZairyou2.IsValid Then Return
            If txtZairyou.Text.Trim.Equals("") Then Return
            If CType(txtZairyou.Text.Trim(), Integer) = 0 Then Return
            sQuery = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS022' AND TELL_CD = :K01"
            _oDatabase.CreateParam("K01", txtZairyou.Text())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            If args.IsValid = True Then lblZairyou.Text = GetString(oReader, 0)
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '汎用マスタ存在チェック(ネジ外径) 
    Protected Sub valNeji3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valNeji3.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            lblNeji.Text = ""
            If Not valNeji2.IsValid Then Return
            If txtNeji.Text.Trim.Equals("") Then Return
            If CType(txtNeji.Text.Trim(), Integer) = 0 Then Return
            sQuery = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS023' AND TELL_CD = :K01"
            _oDatabase.CreateParam("K01", txtNeji.Text())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            If args.IsValid = True Then lblNeji.Text = GetString(oReader, 0)
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '汎用 シリーズ
    Protected Sub valSeries3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valSeries3.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            lblSeries.Text = ""
            If txtSeries.Text.Trim.Equals("") Then Return 'テキストボックスが空白の場合終了

            sQuery = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS036' AND TELL_CD = :K01"

            _oDatabase.CreateParam("K01", txtSeries.Text())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            If args.IsValid = True Then lblSeries.Text = GetString(oReader, 0)
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '製品グループ1、2 
    Protected Sub valSeihin_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valSeihin.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            If txtSeihin1.Text.Trim.Equals("") Or txtSeihin2.Text.Trim.Equals("") Then Return
            If CType(txtSeihin1.Text.Trim(), Integer) = 0 Or CType(txtSeihin2.Text.Trim(), Integer) = 0 Then Return
            sQuery = "SELECT GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = '3' AND GRP_NO = :K01 AND GRP_NO1 = :K02"
            _oDatabase.CreateParam("K01", txtSeihin1.Text.Trim())
            _oDatabase.CreateParam("K02", txtSeihin2.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '更新チェック 
    Protected Sub valDate_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT UPD_DT || UPD_TIME FROM PARTS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                CType(source, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_UPDATE
                args.IsValid = ViewState("update") = GetString(oReader, 0)
            Else
                CType(source, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_DELETE
                args.IsValid = False
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

#End Region

#Region " ファイル関連 "

    Private Function FileUpdate() As Boolean
        Dim sQuery As String = ""
        Dim blnRet As Boolean = False
        Try
            _oDatabase.BeginTrans()

            'マスタ更新履歴テーブル追加
            TableUpdateHistory()

            sQuery = "UPDATE PARTS_MST SET "
            sQuery += "PRODUCT_GRPNO1 = :F01,"
            sQuery += "PRODUCT_GRPNO2 = :F02,"
            sQuery += "TORQUES_NO = :F03,"
            sQuery += "SHAFT_SIZE_NO = :F04,"
            sQuery += "MATL_SIZE_NO = :F05,"
            sQuery += "SIZE_NO = :F06,"
            sQuery += "UPD_DT = :F07,"
            sQuery += "UPD_TIME = :F08,"
            sQuery += "UPD_USR = :F09,"
            sQuery += "UPD_PROGRAM_ID = :F10,"
            sQuery += "SERIES = :F21 " '20120224追加
            sQuery += "WHERE CATALOG_NO = :K01"
            If txtSeihin1.Text.Trim.Equals("") Then
                _oDatabase.CreateParam("F01", 0)
            Else
                _oDatabase.CreateParam("F01", txtSeihin1.Text.Trim())
            End If
            If txtSeihin2.Text.Trim.Equals("") Then
                _oDatabase.CreateParam("F02", 0)
            Else
                _oDatabase.CreateParam("F02", txtSeihin2.Text.Trim())
            End If
            If txtTorukus.Text.Trim.Equals("") Then
                _oDatabase.CreateParam("F03", 0)
            Else
                _oDatabase.CreateParam("F03", txtTorukus.Text.Trim())
            End If
            If txtJikuKou.Text.Trim.Equals("") Then
                _oDatabase.CreateParam("F04", 0)
            Else
                _oDatabase.CreateParam("F04", txtJikuKou.Text.Trim())
            End If
            If txtZairyou.Text.Trim.Equals("") Then
                _oDatabase.CreateParam("F05", 0)
            Else
                _oDatabase.CreateParam("F05", txtZairyou.Text.Trim())
            End If
            If txtNeji.Text.Trim.Equals("") Then
                _oDatabase.CreateParam("F06", 0)
            Else
                _oDatabase.CreateParam("F06", txtNeji.Text.Trim())
            End If
            If txtSeries.Text.Trim.Equals("") Then '20120224追加
                _oDatabase.CreateParam("F21", "")
            Else
                _oDatabase.CreateParam("F21", txtSeries.Text.Trim())
            End If
            _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F09", Session("UserID"))
            _oDatabase.CreateParam("F10", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.ExecuteNonQueryParam(sQuery)
            _oDatabase.CommitTrans()
            blnRet = True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return blnRet
    End Function

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


    '全角、半角混在の文字列をバイト数で切り出し　20120417追加
    Public Function MidB(ByVal str As String, ByVal Start As Integer, Optional ByVal Length As Integer = 0) As String
        'コピー元：http://homepage1.nifty.com/rucio/main/dotnet/Samples/Sample068MidB.htm
        '各引数
        'str    = 対象の文字列
        'Start  = 切り出し開始位置
        'Length = 切り出すバイト数
        '▼空文字に対しては常に空文字を返す
        If str = "" Then
            Return ""
        End If
        '▼Lengthのチェック
        'Lengthが0か、Start以降のバイト数をオーバーする場合はStart以降の全バイトが指定されたものとみなす。
        Dim RestLength As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(str) - Start + 1
        If Length = 0 OrElse Length > RestLength Then
            Length = RestLength
        End If
        '▼切り抜き
        Dim SJIS As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift-JIS")
        Dim B() As Byte = CType(Array.CreateInstance(GetType(Byte), Length), Byte())
        Array.Copy(SJIS.GetBytes(str), Start - 1, B, 0, Length)
        Dim st1 As String = SJIS.GetString(B)
        '▼切り抜いた結果、最後の１バイトが全角文字の半分だった場合、その半分は切り捨てる。
        Dim ResultLength As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(st1) - Start + 1
        If Asc(Strings.Right(st1, 1)) = 0 Then
            'VB.NET2002,2003の場合、最後の１バイトが全角の半分の時
            Return st1.Substring(0, st1.Length - 1)
        ElseIf Length = ResultLength - 1 Then
            'VB2005の場合で最後の１バイトが全角の半分の時
            Return st1.Substring(0, st1.Length - 1)
        Else
            'その他の場合
            Return st1
        End If
    End Function
#End Region

#Region " 更新履歴用 "

    Private Sub TableUpdateHistory()
        Dim sItemNames() As String = GetItemName().Split(",")
        Dim sMotoValues() As String = GetMotoValue(sItemNames.Length()).Split(",")
        Dim sGenValue As String = ""
        sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + ","
        sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + ","
        sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + ","
        sGenValue += txtSeihin1.Text.Trim.PadLeft(1, "0") + "," + txtSeihin2.Text.Trim.PadLeft(1, "0") + "," + txtTorukus.Text.Trim.PadLeft(1, "0") + "," + txtJikuKou.Text.Trim.PadLeft(1, "0") + "," + txtZairyou.Text.Trim.PadLeft(1, "0") + "," + txtNeji.Text.Trim.PadLeft(1, "0") + ","
        sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + ","
        sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + ","
        sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + txtSeries.Text.Trim.PadLeft(1, "0")

        Dim sGenValues() As String = sGenValue.Split(",")

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) And Not (sMotoValues(i) = "" And sGenValues(i) = "0") And Not sGenValues(i).Equals(vbTab) Then
                Select Case i
                    Case 39      'G1
                        InsertMH(sItemNames(i), GetGroupName(sMotoValues(i), "1"), GetGroupName(sGenValues(i), "1"))
                    Case 40      'G2
                        InsertMH(sItemNames(i), GetGroupName(sMotoValues(i), "2"), GetGroupName(sGenValues(i), "2"))
                    Case 41      'トルクス
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS020"), GetHanyouName(sGenValues(i), "MS020"))
                    Case 42      '軸
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS021"), GetHanyouName(sGenValues(i), "MS021"))
                    Case 43      '材料径
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS022"), GetHanyouName(sGenValues(i), "MS022"))
                    Case 44      'ネジ
                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS023"), GetHanyouName(sGenValues(i), "MS023"))
                    'Case 69      'シリーズ
                    Case 71      'シリーズ
                        Dim aaaa As String = GetHanyouName(sMotoValues(i), "MS036")
                        Dim bbbb As String = GetHanyouName(sGenValues(i), "MS036")

                        InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS036"), GetHanyouName(sGenValues(i), "MS036"))
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
                If GetString(oReader, 1) <> "カタログ番号" Then   '主キー以外
                    '20120228削除 末尾にシリーズ項目を追加したため
                    'If GetString(oReader, 1) = "登録日付" Then 
                    '    Exit While
                    'Else
                    '    sResult += GetString(oReader, 1) + ","
                    'End If

                    sResult += GetString(oReader, 1) + ","
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
            sQuery = "SELECT * FROM PARTS_MST WHERE CATALOG_NO = :KEY1 "
            _oDatabase.CreateParam("KEY1", ViewState("catalog"))
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
        InsertMH(ViewState("catalog"), sItemName, sMae, sAto)
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

    'グループ 名付き
    Private Function GetGroupName(ByVal sKey As String, ByVal sLv As String) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sResult As String = ""
        Try
            sQuery += "SELECT GRP_NO,GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = :K02 AND GRP_NO = :K01"
            _oDatabase.CreateParam("K01", sKey)
            _oDatabase.CreateParam("K02", sLv)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                sResult = GetInt32(oReader, 0).ToString + ":" + GetString(oReader, 1)
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
                sResult = MidB(sResult, 1, 50) '20120417追加
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult
    End Function

#End Region

End Class
