Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient
Imports System.Text.RegularExpressions 
 
Partial Class master_mdmas040 
    Inherits System.Web.UI.Page 
    Implements System.Web.UI.ICallbackEventHandler 
 
    Private Const PROGRAM_ID As String = "MDMAS040" 
    Private Const PROGRAM_TITLE As String = "部品マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess 
    Private _oHonsya As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "PARTS_MST"
    Private Const TABLE_NAME_JP As String = "部品マスタ"
    Private Const TABLE_NAME_JP_KAKOU As String = "加工工程マスタ"

    'Friend _sCallBackScript1 As String = ""
    'Friend _sCallBackScript2 As String = ""
    'Friend _sCallBackScript3 As String = ""
    Public _sCallBackScript1 As String = ""
    Public _sCallBackScript2 As String = ""
    Public _sCallBackScript3 As String = ""
    Private _sGetValue As String = ""

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
            _oHonsya = New MedicalLib.DataAccess("HonsyaDB") 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        _sCallBackScript1 = Page.ClientScript.GetCallbackEventReference(Me, "command", "getNameCallBack", "context", "getNameCallBackError", False)
        _sCallBackScript2 = Page.ClientScript.GetCallbackEventReference(Me, "command", "getTanjuCallBack", "context", "getTanjuCallBackError", False)
        _sCallBackScript3 = Page.ClientScript.GetCallbackEventReference(Me, "command", "getKumiCallBack", "context", "getKumiCallBackError", False)
        btnInsert.Attributes.Add("onclick", MedicalLib.Script.Insert())
        btnUpdate.Attributes.Add("onclick", MedicalLib.Script.Update())
        btnDelete.Attributes.Add("onclick", MedicalLib.Script.Delete())
        btnCopy.Attributes.Add("onclick", MedicalLib.Script.Custome("複写してもよろしいですか"))
        If Not Page.IsPostBack Then 
            ComboSet("MS005", cboTest) 
            ComboSet("MS006", cboKonpou) 
            DisplayInitKey() 
            DisplayInitInfo() 
            pnlInfo.Visible = False 
            udpInfo.Update() 
            If Request.QueryString("catalog") Is Nothing Then 
                txtCatalog.Focus() 
            Else 
                txtCatalog.Text = Request.QueryString("catalog")
                Page.Validate("key")
                DisplayShow(txtCatalog.Text) 
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

    '検索ボタン押下 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        Page.Validate("key")
        If Page.IsValid Then

            '**** 2012/12 ホスト廃止対応 ST ****
            'マスタ登録済？
            If PartsMstExist(Me.txtCatalog.Text.Trim) Then
                '訂正ﾓｰﾄﾞ
                DisplayShow(Me.txtCatalog.Text.Trim)
            Else
                '登録ﾓｰﾄﾞ
                DisplayInsert()
            End If
            'DisplayShow(txtCatalog.Text)
            '**** 2012/12 ホスト廃止対応 ED ****
        End If
    End Sub

    '登録ボタン押下         2010/08/27 修正理由対応
    Protected Sub btnInsert_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnInsert.Click
        Page.Validate("info")
        If Page.IsValid Then
            If FileInsert() Then
                Response.Redirect("mdmas150.aspx?call=synchro&catalog=" + ViewState("SaveCatalog") + "&copycatalog=" + ViewState("SaveCopyCatalog"), False)
            End If
        End If
    End Sub

    '訂正ボタン押下 
    Protected Sub btnUpdate_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnUpdate.Click
        Page.Validate("info")
        If Page.IsValid Then
            Page.Validate("update")
            If Not Page.IsValid() Then Exit Sub
            If FileUpdate() Then
                If ViewState("Sakuseisya").ToString.Trim.Equals("") Then
                    Response.Redirect("mdmas150.aspx?call=synchro&catalog=" + ViewState("SaveCatalog") + "&copycatalog=" + ViewState("SaveCopyCatalog"), False)
                Else
                    '**** 2010/08 訂正後キー部をクリアしない ST ****
                    'DisplayInitKey()
                    '**** 2010/08 訂正後キー部をクリアしない ED ****
                    Me.imgProcessTitle.Visible = False
                    Me.udpKey.Update()
                    pnlInfo.Visible = False
                End If
            End If
        End If
    End Sub

    '削除ボタン押下         2010/08/27 修正理由対応
    Protected Sub btnDelete_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnDelete.Click
        If FileDelete() Then
            DisplayInitInfo()
            DisplayInitKey()
            pnlInfo.Visible = False
            udpInfo.Update()
        End If
    End Sub

    '複写ボタン押下 
    Protected Sub btnCopy_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCopy.Click
        Page.Validate("copy")
        If Page.IsValid Then
            DisplayShowCopy()
        End If
    End Sub

    'クリアボタン押下 
    Protected Sub btnClear_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnClear.Click
        '**** 2012/12 ホスト廃止対応 ST ****
        Me.txtCatalog.Text = ViewState("SaveCatalog")
        Me.udpKey.Update()
        If ViewState("mode").Equals("i") Then
            DisplayInsert()
        Else
            DisplayShow(ViewState("SaveCatalog"))
        End If
        'txtCatalog.Text = ViewState("SaveCatalog")
        'DisplayShow(ViewState("SaveCatalog"))
        '**** 2012/12 ホスト廃止対応 ED ****
    End Sub

    '戻るボタン押下 
    Protected Sub btnBack_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBack.Click
        pnlInfo.Visible = False
        Me.imgProcessTitle.Visible = False
        Me.udpKey.Update()
    End Sub

    '加工工程登録ボタン押下 
    Protected Sub btnKakouInsert_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnKakouInsert.Click
        Response.Redirect("mdmas150.aspx?call=synchro&catalog=" + ViewState("SaveCatalog") + "&copycatalog=", False)
    End Sub

    '修正理由変更処理 2010/08/27 修正理由対応
    Protected Sub cboSyusei_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSyusei.SelectedIndexChanged

        Select Case Me.cboSyusei.SelectedValue
            Case "0"
                Me.tblShusei.Rows(0).Cells(2).Visible = False
                Me.tblShusei.Rows(0).Cells(3).Visible = False
                Me.tblShusei.Rows(0).Cells(4).Visible = False
                Me.tblShusei.Rows(0).Cells(5).Visible = False
            Case "1"
                Me.tblShusei.Rows(0).Cells(2).Visible = True
                Me.tblShusei.Rows(0).Cells(3).Visible = True
                Me.tblShusei.Rows(0).Cells(4).Visible = True
                Me.tblShusei.Rows(0).Cells(5).Visible = True
        End Select

        Dim sQuery As String = ""

        '作業者名称取得
        sQuery += "SELECT WORKER_ABB"
        sQuery += "  FROM WORKER_MST"
        sQuery += " WHERE WORKER_CD = :K01"

        '修正者
        _oDatabase.CreateParam("K01", Me.txtSakusei.Text.Trim)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                Me.lblSakusei.Text = GetString(oReader, 0)
            End If
        End Using

        '作成者
        _oDatabase.CreateParam("K01", Me.txtSakusei.Text.Trim)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                Me.lblSakusei.Text = GetString(oReader, 0)
            End If
        End Using

        '点検者
        _oDatabase.CreateParam("K01", Me.txtTenken.Text.Trim)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                Me.lblTenken.Text = GetString(oReader, 0)
            End If
        End Using

        '承認者(技術)
        _oDatabase.CreateParam("K01", Me.txtGijutu.Text.Trim)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                Me.lblGijutu.Text = GetString(oReader, 0)
            End If
        End Using

        '承認者(品管)
        _oDatabase.CreateParam("K01", Me.txtHinkan.Text.Trim)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                Me.lblHinkan.Text = GetString(oReader, 0)
            End If
        End Using
    End Sub

#End Region 
 
#Region " コールバック " 
 
    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult 
        Dim sReturnValue As String = "" 
        Dim sValues() As String = _sGetValue.Split(Chr(9))
        '**** 2012/12 ホスト廃止対応 ST ****
        Select Case sValues(0)
            Case "0"
                Dim sQuery As String = "SELECT WORKER_CD,WORKER_ABB FROM WORKER_MST WHERE WORKER_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim.PadLeft(4, "0"))
                Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        sReturnValue = GetString(oReader, 0).Trim() + "," + GetString(oReader, 1).Trim()
                    Else
                        sReturnValue = sValues(1) + ","
                    End If
                End Using
            Case "1"
                sReturnValue = GetTanju(sValues(1), sValues(2))
            Case "2"
                '組番取得追加
                Dim sQuery As String = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS014' AND TELL_CD = :K01"
                _oDatabase.CreateParam("K01", sValues(1).Trim.PadLeft(2, "0"))
                Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        sReturnValue = GetString(oReader, 0)
                    End If
                End Using
        End Select
        'If sValues(0).Equals("0") Then 
        '    Dim sQuery As String = "SELECT WORKER_CD,WORKER_ABB FROM WORKER_MST WHERE WORKER_CD = :K01" 
        '    _oDatabase.CreateParam("K01", sValues(1).Trim.PadLeft(4, "0")) 
        '    Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
        '    If oReader.Read() Then 
        '        sReturnValue = oReader.GetString(0).Trim() + "," + oReader.GetString(1).Trim() 
        '    Else 
        '        sReturnValue = sValues(1) + "," 
        '    End If 
        '    oReader.Close() 
        'Else 
        '    sReturnValue = GetTanju(sValues(1), sValues(2)) 
        'End If 
        '**** 2012/12 ホスト廃止対応 ED ****
        Return sReturnValue 
    End Function 
 
    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent 
        _sGetValue = eventArgument 
    End Sub

#End Region

#Region " チェック関連 "

    'カタログ番号チェック 
    Protected Sub valCatalog2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCatalog2.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            '部品マスタ存在チェック 
            sQuery = "SELECT COMPANY_NO FROM PARTS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", args.Value.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                lblSyanai.Text = oReader.GetString(0).Trim()
                args.IsValid = True
            Else
                args.IsValid = False
            End If
            oReader.Close()
            If Not args.IsValid Then Return
            '本社・カタログマスタ存在チェック 
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '修正区分チェック   2012/12 ホスト廃止対応
    Protected Sub valSyusei_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valSyusei.ServerValidate
        If ViewState("mode").ToString.Equals("i") And Me.txtAssy.Text = "0" And Me.cboSyusei.SelectedValue = 0 Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    '修正者チェック     2010/08/27 修正理由対応
    Protected Sub valUpdator_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valUpdator.ServerValidate

        Dim oVal As CustomValidator = DirectCast(source, CustomValidator)
        Me.lblUpdator.Text = ""

        '入力チェック
        If Me.txtUpdator.Text.Trim = "" Then
            oVal.ErrorMessage = "必須入力項目です"
            args.IsValid = False
            Exit Sub
        End If

        '作業者マスタチェック
        Dim sQuery As String = ""
        sQuery += "SELECT WORKER_ABB"
        sQuery += "  FROM WORKER_MST"
        sQuery += " WHERE WORKER_CD = :K01"
        _oDatabase.CreateParam("K01", Me.txtUpdator.Text.Trim)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                Me.lblUpdator.Text = GetString(oReader, 0)
            Else
                oVal.ErrorMessage = "作業者マスタに未登録です"
                args.IsValid = False
                Exit Sub
            End If
        End Using
    End Sub

    '修正理由チェック   2010/08/27 修正理由対応
    Protected Sub valReason_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valReason.ServerValidate
        Dim oVal As CustomValidator = DirectCast(source, CustomValidator)
        '入力チェック
        If Me.txtUpdator.Text.Trim = "" Then
            oVal.ErrorMessage = "必須入力項目です"
            args.IsValid = False
            Exit Sub
        End If
    End Sub

    'コピー元カタログチェック 
    Protected Sub valCopyCatalog1_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCopyCatalog1.ServerValidate 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            args.IsValid = False 
            If args.Value.Trim.Equals("") Then 
                CType(source, CustomValidator).ErrorMessage = "入力して下さい" 
                Return 
            End If 
            '部品マスタ存在チェック 
            sQuery = "SELECT CREATOR FROM PARTS_MST WHERE CATALOG_NO = :K01" 
            _oDatabase.CreateParam("K01", args.Value.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                If Not CheckDBNull(oReader, 0) Then 
                    CType(source, CustomValidator).ErrorMessage = "コピー元にデータがありません" 
                Else 
                    args.IsValid = True 
                End If 
            Else 
                CType(source, CustomValidator).ErrorMessage = "部品マスタに未登録です" 
            End If 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 

    'ASSY区分チェック   2012/12 ホスト廃止対応
    Protected Sub valAssy2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valAssy.ServerValidate
        Dim val As CustomValidator = DirectCast(source, CustomValidator)
        val.ErrorMessage = "0、1、空白で<br />入力して下さい"
        args.IsValid = "01".IndexOf(args.Value) > -1
    End Sub

    '原価区分チェック   2013/08 ホスト廃止対応
    Protected Sub valCost2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCost.ServerValidate
        Dim val As CustomValidator = DirectCast(source, CustomValidator)
        val.ErrorMessage = "01、05、06、空白で<br />入力して下さい"
        'args.IsValid = "01".IndexOf(args.Value) > -1
        If Not (args.Value = "01" Or args.Value = "05" Or args.Value = "06" Or args.Value = "") Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    '原価区分チェック   2013/08 ホスト廃止対応
    Protected Sub valRoyalties2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valRoyalties.ServerValidate
        Dim val As CustomValidator = DirectCast(source, CustomValidator)
        val.ErrorMessage = "1、空白で<br />入力して下さい"
        args.IsValid = "1".IndexOf(args.Value) > -1
    End Sub

    '組番チェック       2012/12 ホスト廃止対応
    Protected Sub valKumiban2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valKumiban2.ServerValidate
        Dim sQuery As String = "SELECT ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS014' AND TELL_CD = :K01"
        Try
            _oDatabase.CreateParam("K01", Me.txtKumiban.Text.Trim)
            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    args.IsValid = True
                    Me.lblKumibanName.Text = GetString(oReader, 0)
                Else
                    args.IsValid = False
                    Me.lblKumibanName.Text = ""
                End If
            End Using
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '材料コード 
    Protected Sub valZairyo1_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valZairyo1.ServerValidate 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery = "SELECT MATL_SPEC FROM MATL_MST WHERE MATL_CD = :K01" 
            _oDatabase.CreateParam("K01", args.Value.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                lblSpec.Text = GetString(oReader, 0) 
                args.IsValid = True 
            Else 
                args.IsValid = False 
            End If 
            args.IsValid = oReader.HasRows 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
    '単位 
    Protected Sub valTani1_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valTani1.ServerValidate 
        args.IsValid = "Mｺ".IndexOf(args.Value) > -1 
    End Sub 
 
    '寸法 
    Protected Sub valSunpou_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valSunpou1b.ServerValidate, valSunpou2b.ServerValidate, valSunpou3b.ServerValidate, valSunpou4b.ServerValidate, valSunpou5b.ServerValidate, _ 
                                                                                                                                            valSunpou6b.ServerValidate, valSunpou7b.ServerValidate, valSunpou8b.ServerValidate, valSunpou9b.ServerValidate, valSunpou10b.ServerValidate 
        Dim oControl1 As System.Web.UI.WebControls.TextBox = Nothing 
        Dim oControl2 As System.Web.UI.WebControls.TextBox = Nothing 
        Select Case True 
            Case source Is valSunpou1b 
                If Not valSunpou1a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName1 
                oControl2 = txtSunpou1 
            Case source Is valSunpou2b 
                If Not valSunpou2a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName2 
                oControl2 = txtSunpou2 
            Case source Is valSunpou3b 
                If Not valSunpou3a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName3 
                oControl2 = txtSunpou3 
            Case source Is valSunpou4b 
                If Not valSunpou4a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName4 
                oControl2 = txtSunpou4 
            Case source Is valSunpou5b 
                If Not valSunpou5a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName5 
                oControl2 = txtSunpou5 
            Case source Is valSunpou6b 
                If Not valSunpou6a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName6 
                oControl2 = txtSunpou6 
            Case source Is valSunpou7b 
                If Not valSunpou7a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName7 
                oControl2 = txtSunpou7 
            Case source Is valSunpou8b 
                If Not valSunpou8a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName8 
                oControl2 = txtSunpou8 
            Case source Is valSunpou9b 
                If Not valSunpou9a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName9 
                oControl2 = txtSunpou9 
            Case source Is valSunpou10b 
                If Not valSunpou10a.IsValid Then Exit Sub 
                oControl1 = txtSunpouName10 
                oControl2 = txtSunpou10 
        End Select 
        Select Case True 
            Case oControl1.Text.Trim.Equals("") And Not oControl2.Text.Trim.Equals("") 
                CType(source, CustomValidator).ErrorMessage = "寸法名を入力して下さい" 
                args.IsValid = False 
            Case Not oControl1.Text.Trim.Equals("") And oControl2.Text.Trim.Equals("") 
                CType(source, CustomValidator).ErrorMessage = "寸法を入力して下さい" 
                args.IsValid = False 
            Case Else 
                args.IsValid = True 
        End Select 
    End Sub 
 
    '作成、点検、技術、品管 
    Protected Sub valSagyousya_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valSakusei2.ServerValidate, valTenken2.ServerValidate, valGijutu2.ServerValidate, valHinkan2.ServerValidate 
        Dim oCode As System.Web.UI.WebControls.TextBox = Nothing 
        Dim oName As System.Web.UI.WebControls.Label = Nothing 
        Select Case True 
            Case source Is valSakusei2 
                oCode = txtSakusei 
                oName = lblSakusei 
            Case source Is valTenken2 
                oCode = txtTenken 
                oName = lblTenken 
            Case source Is valGijutu2 
                oCode = txtGijutu 
                oName = lblGijutu 
            Case source Is valHinkan2 
                oCode = txtHinkan 
                oName = lblHinkan 
        End Select 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery = "SELECT WORKER_ABB FROM WORKER_MST WHERE WORKER_CD = :K01" 
            _oDatabase.CreateParam("K01", args.Value.Trim.PadLeft(4, "0")) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                oCode.Text = args.Value.Trim.PadLeft(4, "0") 
                oName.Text = oReader.GetString(0).Trim() 
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

    '部品名称 2011/10/12 Add
    Protected Sub valBuhin_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valBuhin.ServerValidate
        If System.Text.Encoding.GetEncoding(932).GetByteCount(txtBuhin.Text.Trim) > 20 Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM PARTS_MST WHERE CATALOG_NO = :K01"
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", txtCatalog.Text.Trim())
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

    'NULL or SPACE 
    Private Function CheckDBNull(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Boolean 
        If oReader.IsDBNull(nIndex) Then Return False 
        Return Not oReader.GetString(nIndex).Trim.Equals("") 
    End Function 

#End Region 
 
#Region " 画面関連 " 
 
    '画面初期化(キー項目) 
    Private Sub DisplayInitKey() 
        txtCatalog.Text = "" 
        lblSyanai.Text = ""
        Me.imgProcessTitle.Visible = False
        udpKey.Update() 
    End Sub 
 
    '画面初期化(情報項目) 
    Private Sub DisplayInitInfo() 
        tblCopy.Visible = False 
        'txtCatalog.Text = "" 
        'lblSyanai.Text = "" 
        txtCopyCatalog.Text = "" 
        cboSyusei.SelectedIndex = -1 
        txtMotoCatalog.Text = "" 
        lblAssy.Text = "" 
        txtKumiban.Text = ""
        lblKumibanName.Text = ""
        lblGroup1.Text = ""
        lblGroupName1.Text = ""
        lblGroup2.Text = ""
        lblGroupName2.Text = ""
        txtZairyo.Text = ""
        txtSozai.Text = ""
        txtTani.Text = ""
        txtTanju.Text = ""
        lblSpec.Text = ""
        lblGuide.Text = ""
        txtSunpouName1.Text = ""
        txtSunpouName2.Text = ""
        txtSunpouName3.Text = ""
        txtSunpouName4.Text = ""
        txtSunpouName5.Text = ""
        txtSunpouName6.Text = ""
        txtSunpouName7.Text = ""
        txtSunpouName8.Text = ""
        txtSunpouName9.Text = ""
        txtSunpouName10.Text = ""
        txtSunpou1.Text = ""
        txtSunpou2.Text = ""
        txtSunpou3.Text = ""
        txtSunpou4.Text = ""
        txtSunpou5.Text = ""
        txtSunpou6.Text = ""
        txtSunpou7.Text = ""
        txtSunpou8.Text = ""
        txtSunpou9.Text = ""
        txtSunpou10.Text = ""
        cboTest.SelectedIndex = -1
        txtGenga.Text = ""
        txtBuhin.Text = ""
        txtZumen.Text = ""
        cboKonpou.SelectedIndex = -1
        txtSakusei.Text = ""
        lblSakusei.Text = ""
        txtTenken.Text = ""
        lblTenken.Text = ""
        txtGijutu.Text = ""
        lblGijutu.Text = ""
        txtHinkan.Text = ""
        lblHinkan.Text = ""
        chkMekkin.Checked = False
        lblSeihin.Text = ""
        lblSyounin.Text = ""
        lblHanbai.Text = ""
        lblIppan.Text = ""
        lblSyurui1.Text = ""
        lblSyurui2.Text = ""
        lblTorukus.Text = ""
        lblJiku.Text = ""
        lblZairyo.Text = ""
        lblNeji.Text = ""
        lblKoutei1.Text = ""
        lblKoutei2.Text = ""
        lblHyoujunsho1.Text = ""
        lblHyoujunsho2.Text = ""
        lblKakouzu1.Text = ""
        lblKakouzu2.Text = ""
        lblZumen1.Text = ""
        lblZumen2.Text = ""
        lblSiken1.Text = ""
        lblSiken2.Text = ""

        Me.txtUpdator.Text = ""
        Me.lblUpdator.Text = ""
        Me.txtAssy.Text = ""
        Me.txtKumiban.Text = ""
        Me.txtGroupCode.Text = ""
        Me.txtCost.Text = ""       '2013/08/26 Add
        Me.txtRoyalties.Text = ""  '2013/08/26 Add

        ViewState("MotoUpdator") = ""
        ViewState("MotoReason") = ""

        udpInfo.Update()
    End Sub

    '画面表示(登録)     2012/12 ホスト廃止対応
    Private Sub DisplayInsert()

        ViewState("mode") = "i"
        ViewState("SaveCatalog") = txtCatalog.Text.Trim()
        Me.imgProcessTitle.ImageUrl = "../image/t_insert.gif"
        Me.imgProcessTitle.Visible = True

        DisplayInitInfo()

        '社内NO取得
        Me.lblSyanai.Text = _oDatabase.GetNumberNoUpdate(MedicalLib.DataAccess.Saiban.SN).ToString("000000")

        tblCopy.Visible = True
        Me.pnlKumiInput.Visible = True
        Me.pnlKumi.Visible = False

        '修正理由コンボセット
        ComboSet("MS034", Me.cboReason)
        Me.tblShusei.Rows(0).Cells(2).Visible = False
        Me.tblShusei.Rows(0).Cells(3).Visible = False
        Me.tblShusei.Rows(0).Cells(4).Visible = False
        Me.tblShusei.Rows(0).Cells(5).Visible = False

        Me.txtUpdator.Text = Session("UserID")
        Me.lblUpdator.Text = ""
        Me.cboSyusei.SelectedValue = "1"
        'Me.txts Session("UserID")
        Me.tblShusei.Rows(0).Cells(2).Visible = True
        Me.tblShusei.Rows(0).Cells(3).Visible = True
        Me.tblShusei.Rows(0).Cells(4).Visible = True
        Me.tblShusei.Rows(0).Cells(5).Visible = True
        SetShusei()
        Me.cboReason.SelectedValue = "00"

        Me.btnKakouInsert.Visible = False
        Me.btnInsert.Visible = MedicalLib.Common.EnableInsert
        Me.btnUpdate.Visible = False
        Me.btnDelete.Visible = False
        Me.pnlInfo.Visible = True
        Me.txtZumen1.Enabled = False    '2013/08/26 Add
        Me.valSakusei1.Enabled = False  '2013/08/26 Add
        Me.txtZumen.BackColor = Color.Empty    '2013/08/26 Add
        Me.txtSakusei.BackColor = Color.Empty  '2013/08/26 Add
        Me.txtKumiban.ReadOnly = False

        udpInfo.Update()
    End Sub

    '画面表示(更新)
    Private Sub DisplayShow(ByVal sCatalog As String)

        ViewState("mode") = "u"
        ViewState("SaveCatalog") = txtCatalog.Text.Trim()
        Me.imgProcessTitle.ImageUrl = "../image/t_update.gif"
        Me.imgProcessTitle.Visible = True

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim oDummy As OracleDataReader = Nothing
        Try
            sQuery += "SELECT A.CREATOR,A.C_NO,A.UPD_KB,A.O_CATALOG_NO,B.ITEM_NM,A.PRODUCT_GRPNO1,D.GRP_NM,A.PRODUCT_GRPNO2,C.GRP_NM,A.MATL_CD,A.UNIT_MATL_WAT,A.MATL_PRICE_KB,A.MATL_WAT,E.MATL_SPEC,"
            sQuery += "A.MEASURE_KB01,A.MEASURE_01,A.MEASURE_KB02,A.MEASURE_02,A.MEASURE_KB03,A.MEASURE_03,A.MEASURE_KB04,A.MEASURE_04,A.MEASURE_KB05,A.MEASURE_05,A.MEASURE_KB06,A.MEASURE_06,A.MEASURE_KB07,A.MEASURE_07,A.MEASURE_KB08,A.MEASURE_08,A.MEASURE_KB09,A.MEASURE_09,A.MEASURE_KB10,A.MEASURE_10,"
            sQuery += "A.TPERS_AMT,A.O_SKETCH_NO,A.PARTS_NM,A.WORK_STD_NO,A.PACKUP_KB,A.CREATOR,F.WORKER_ABB,A.CHECKER,G.WORKER_ABB,A.RECOGNIZER_SK,H.WORKER_ABB,A.RECOGNIZER_QL,I.WORKER_ABB,J.ITEM_NM,K.ITEM_NM,L.ITEM_NM,M.ITEM_NM,"
            sQuery += "N.COR_MARK,N.APPLY_DT,O.COR_MARK,O.APPLY_DT,P.COR_MARK,P.APPLY_DT,Q.COR_MARK,Q.APPLY_DT,R.COR_MARK,R.APPLY_DT,A.UPD_DT,A.UPD_TIME,A.ASSY_KB"
            sQuery += ",A.SURPLUS_STOP_FLG "        '生産停止区分追加
            sQuery += ",A.GRP_CD "                  '2012/12 グループコード追加
            sQuery += ",A.COMPANY_NO "              '2012/12 社内NO追加
            sQuery += ",A.COST_KBN "                '2013/08 原価区分追加
            sQuery += ",A.ROYALTIES_KBN "           '2013/08 ロイヤリティ区分追加
            sQuery += "FROM PARTS_MST A,(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS014') B,"
            sQuery += "(SELECT GRP_NO,GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = '2') C,"
            sQuery += "(SELECT GRP_NO,GRP_NM FROM PRODUCT_GRP_MST WHERE GRP_LV = '1') D,"
            sQuery += "MATL_MST E,WORKER_MST F,WORKER_MST G,WORKER_MST H,WORKER_MST I,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS020') J,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS021') K,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS022') L,"
            sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS023') M,"
            sQuery += "(SELECT CATALOG_NO,COR_MARK,APPLY_DT FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '1') N,"
            sQuery += "(SELECT CATALOG_NO,COR_MARK,APPLY_DT FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '2') O,"
            sQuery += "(SELECT PROSTD_NO,COR_MARK,APPLY_DT FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '3') P,"
            sQuery += "(SELECT PROSTD_NO,COR_MARK,APPLY_DT FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4') Q,"
            sQuery += "(SELECT PROSTD_NO,COR_MARK,APPLY_DT FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '5') R "
            sQuery += "WHERE A.C_NO = B.TELL_CD(+) AND "
            sQuery += "A.PRODUCT_GRPNO2 = C.GRP_NO(+) AND A.PRODUCT_GRPNO1 = D.GRP_NO(+) AND A.MATL_CD = E.MATL_CD(+) AND "
            sQuery += "A.CREATOR = F.WORKER_CD(+) AND A.CHECKER = G.WORKER_CD(+) AND A.RECOGNIZER_SK = H.WORKER_CD(+) AND A.RECOGNIZER_QL = I.WORKER_CD(+) AND "
            sQuery += "A.TORQUES_NO = J.TELL_CD(+) AND A.SHAFT_SIZE_NO = K.TELL_CD(+) AND A.MATL_SIZE_NO = L.TELL_CD(+) AND A.SIZE_NO = M.TELL_CD(+) AND "
            sQuery += "A.CATALOG_NO = N.CATALOG_NO(+) AND A.CATALOG_NO = O.CATALOG_NO(+) AND A.WORK_STD_NO = P.PROSTD_NO(+) AND A.WORK_STD_NO = Q.PROSTD_NO(+) AND A.WORK_STD_NO = R.PROSTD_NO(+) AND "
            sQuery += "A.CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", sCatalog.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                tblCopy.Visible = GetString(oReader, 0).Trim.Equals("") Or GetString(oReader, 1).Trim.Equals("W2")
                txtCopyCatalog.Text = ""
                cboSyusei.SelectedValue = GetString(oReader, 2).PadLeft(1, "0")
                txtMotoCatalog.Text = GetString(oReader, 3)
                '**** 2012/12 ホスト廃止対応 ST ****
                Me.txtKumiban.Text = GetString(oReader, 1)      '組番
                Me.txtAssy.Text = GetString(oReader, 63)        'ASSY区分
                Me.txtGroupCode.Text = GetString(oReader, 65)   'グループコード
                Me.lblSyanai.Text = GetString(oReader, 66)      '社内NO
                'Select Case GetString(oReader, 63)
                '    Case "0"
                '        lblAssy.Text = "製品"
                '    Case "1"
                '        lblAssy.Text = "子部品"
                '    Case Else
                '        lblAssy.Text = "その他"
                'End Select
                '**** 2012/12 ホスト廃止対応 ED ****
                '**** 2013/08/26 原価,ロイヤリティ追加 ST ****
                Me.txtCost.Text = GetString(oReader, 67)
                Me.txtRoyalties.Text = GetString(oReader, 68)
                '**** 2013/08/26 原価,ロイヤリティ追加 ED ****
                txtKumiban.Text = GetString(oReader, 1)
                lblKumibanName.Text = GetString(oReader, 4)
                lblGroup1.Text = GetInt32(oReader, 5).ToString("####")
                lblGroupName1.Text = GetString(oReader, 6)
                lblGroup2.Text = GetInt32(oReader, 7).ToString("####")
                lblGroupName2.Text = GetString(oReader, 8)
                txtZairyo.Text = GetString(oReader, 9)
                txtSozai.Text = GetDouble(oReader, 10).ToString("######.#")
                txtTani.Text = GetString(oReader, 11)
                txtTanju.Text = GetDouble(oReader, 12).ToString("######.#")
                lblSpec.Text = GetString(oReader, 13)
                txtSunpouName1.Text = GetString(oReader, 14)
                txtSunpou1.Text = GetDouble(oReader, 15).ToString("###.##")
                txtSunpouName2.Text = GetString(oReader, 16)
                txtSunpou2.Text = GetDouble(oReader, 17).ToString("###.##")
                txtSunpouName3.Text = GetString(oReader, 18)
                txtSunpou3.Text = GetDouble(oReader, 19).ToString("###.##")
                txtSunpouName4.Text = GetString(oReader, 20)
                txtSunpou4.Text = GetDouble(oReader, 21).ToString("###.##")
                txtSunpouName5.Text = GetString(oReader, 22)
                txtSunpou5.Text = GetDouble(oReader, 23).ToString("###.##")
                txtSunpouName6.Text = GetString(oReader, 24)
                txtSunpou6.Text = GetDouble(oReader, 25).ToString("###.##")
                txtSunpouName7.Text = GetString(oReader, 26)
                txtSunpou7.Text = GetDouble(oReader, 27).ToString("###.##")
                txtSunpouName8.Text = GetString(oReader, 28)
                txtSunpou8.Text = GetDouble(oReader, 29).ToString("###.##")
                txtSunpouName9.Text = GetString(oReader, 30)
                txtSunpou9.Text = GetDouble(oReader, 31).ToString("###.##")
                txtSunpouName10.Text = GetString(oReader, 32)
                txtSunpou10.Text = GetDouble(oReader, 33).ToString("###.##")
                cboTest.SelectedValue = GetString(oReader, 34)
                txtGenga.Text = GetString(oReader, 35)
                txtBuhin.Text = GetString(oReader, 36)
                txtZumen.Text = GetString(oReader, 37)
                cboKonpou.SelectedValue = GetString(oReader, 38)
                txtSakusei.Text = GetString(oReader, 39)
                lblSakusei.Text = GetString(oReader, 40)
                txtTenken.Text = GetString(oReader, 41)
                lblTenken.Text = GetString(oReader, 42)
                txtGijutu.Text = GetString(oReader, 43)
                lblGijutu.Text = GetString(oReader, 44)
                txtHinkan.Text = GetString(oReader, 45)
                lblHinkan.Text = GetString(oReader, 46)
                '滅菌～種類名2は本社：カタログマスタより 
                sQuery = "SELECT BAC_KB,PROSTD_NO,APPROV_NO,YAKUJI_NM,GENER_NM,PARTS_NM1,PARTS_NM2 FROM CATALOG_MST WHERE COMPANY_NO = :K01"
                _oHonsya.CreateParam("K01", lblSyanai.Text.Trim())
                oDummy = _oHonsya.CreateReaderParam(sQuery)
                If oDummy.Read() Then
                    cboSyusei.Enabled = True
                    chkMekkin.Checked = GetString(oDummy, 0).Equals("1")
                    lblSeihin.Text = GetString(oDummy, 1)
                    lblSyounin.Text = GetString(oDummy, 2)
                    lblHanbai.Text = GetString(oDummy, 3)
                    lblIppan.Text = GetString(oDummy, 4)
                    lblSyurui1.Text = GetString(oDummy, 5)
                    lblSyurui2.Text = GetString(oDummy, 6)
                Else
                    'ASSY区分=0 AND 修正中のとき 
                    cboSyusei.Enabled = Not (GetString(oReader, 63).Equals("0") And GetString(oReader, 2).PadLeft(1, "0").Equals("1"))
                    chkMekkin.Checked = False
                    lblSeihin.Text = ""
                    lblSyounin.Text = ""
                    lblHanbai.Text = ""
                    lblIppan.Text = ""
                    lblSyurui1.Text = ""
                    lblSyurui2.Text = ""
                End If
                oDummy.Close()
                lblTorukus.Text = GetString(oReader, 47)
                lblJiku.Text = GetString(oReader, 48)
                lblZairyo.Text = GetString(oReader, 49)
                lblNeji.Text = GetString(oReader, 50)
                lblKoutei1.Text = GetString(oReader, 51)
                '2009/01/18 日付以外文字対策
                If GetString(oReader, 52).Length = 8 Then
                    lblKoutei2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 52))
                Else
                    lblKoutei2.Text = ""
                End If
                lblHyoujunsho1.Text = GetString(oReader, 53)
                '2009/01/18 日付以外文字対策
                'lblHyoujunsho2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 54)) 
                If GetString(oReader, 54).Length = 8 Then
                    lblHyoujunsho2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 54))
                Else
                    lblHyoujunsho2.Text = ""
                End If
                lblKakouzu1.Text = GetString(oReader, 55)
                '2009/01/18 日付以外文字対策
                'lblKakouzu2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 56)) 
                If GetString(oReader, 56).Length = 8 Then
                    lblKakouzu2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 56))
                Else
                    lblKakouzu2.Text = ""
                End If
                lblZumen1.Text = GetString(oReader, 57)
                '2009/01/18 日付以外文字対策
                'lblZumen2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 58)) 
                If GetString(oReader, 58).Length = 8 Then
                    lblZumen2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 58))
                Else
                    lblZumen2.Text = ""
                End If
                lblSiken1.Text = GetString(oReader, 59)
                '2009/01/18 日付以外文字対策
                'lblSiken2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 60))
                If GetString(oReader, 60).Length = 8 Then
                    lblSiken2.Text = MedicalLib.Common.DateFormat(GetString(oReader, 60))
                Else
                    lblSiken2.Text = ""
                End If
                ViewState("update") = oReader.GetString(61).Trim() + oReader.GetString(62).Trim()
                '生産停止区分追加
                chkTeisi.Checked = GetString(oReader, 64).Equals("1")
                btnKakouInsert.Visible = Not GetString(oReader, 0).Trim.Equals("")
            End If
            oReader.Close()

            '**** 2010/08/27 修正理由対応 ST ****
            '修正理由コンボセット
            ComboSet("MS034", Me.cboReason)

            '修正中のときは修正理由を検索
            Select Case Me.cboSyusei.SelectedValue
                Case "0"
                    Me.tblShusei.Rows(0).Cells(2).Visible = False
                    Me.tblShusei.Rows(0).Cells(3).Visible = False
                    Me.tblShusei.Rows(0).Cells(4).Visible = False
                    Me.tblShusei.Rows(0).Cells(5).Visible = False
                    Me.txtUpdator.Text = ""
                    Me.lblUpdator.Text = ""
                    Me.cboReason.SelectedValue = ""
                Case "1"
                    Me.tblShusei.Rows(0).Cells(2).Visible = True
                    Me.tblShusei.Rows(0).Cells(3).Visible = True
                    Me.tblShusei.Rows(0).Cells(4).Visible = True
                    Me.tblShusei.Rows(0).Cells(5).Visible = True
                    SetShusei()
            End Select
            '**** 2010/08/27 修正理由対応 ED ****

            '**** 2012/12 ホスト廃止対応 ST ****
            Me.btnInsert.Visible = False
            '着工済みのとき組番変更を不可
            Dim SijiExist As Boolean = IndicateTblExist(Me.txtCatalog.Text.Trim)
            Me.pnlKumiInput.Visible = Not SijiExist
            Me.pnlKumi.Visible = SijiExist
            Me.txtKumiban.ReadOnly = SijiExist
            '着工済みのとき削除を不可
            Me.btnDelete.Visible = Not SijiExist
            If Not SijiExist Then
                btnDelete.Visible = MedicalLib.Common.EnableDelete
            End If
            '**** 2012/12 ホスト廃止対応 ED ****

            ViewState("Sakuseisya") = txtSakusei.Text.Trim()
            btnUpdate.Visible = MedicalLib.Common.EnableUpdate
            pnlInfo.Visible = True

            Me.txtZumen1.Enabled = True    '2013/08/26 Add
            Me.txtZumen.BackColor = Color.FromArgb(255, 255, 192)    '2013/08/26 Add 'Color.Empty 'FFFFC0
            Me.valSakusei1.Enabled = True  '2013/08/26 Add
            Me.txtSakusei.BackColor = Color.FromArgb(255, 255, 192)  '2013/08/26 Add 'Color.Empty 'FFFFC0

            udpInfo.Update()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '修正理由表示       2010/08/27 修正理由対応
    Private Sub SetShusei()

        Dim sQuery As String = ""
        sQuery = ""
        sQuery += "SELECT P.UPDATOR, W.WORKER_ABB"
        sQuery += "     , P.UPDATE_REASON"
        sQuery += "  FROM PARTS_UPDATE_REASON_TBL P"
        sQuery += "     , WORKER_MST W"
        sQuery += " WHERE P.UPD_DATETIME = (SELECT MAX(PM.UPD_DATETIME)"
        sQuery += "                           FROM PARTS_UPDATE_REASON_TBL PM"
        sQuery += "                          WHERE PM.CATALOG_NO = :K01"
        sQuery += "                          GROUP BY PM.CATALOG_NO"
        sQuery += "                        )"
        sQuery += "   AND P.CATALOG_NO = :K01"
        sQuery += "   AND P.UPDATOR = W.WORKER_CD(+)"

        _oDatabase.CreateParam("K01", Me.txtCatalog.Text)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read Then
                Me.txtUpdator.Text = GetString(oReader, 0).Trim
                ViewState("MotoUpdator") = GetString(oReader, 0).Trim
                Me.lblUpdator.Text = GetString(oReader, 1).Trim
                Me.cboReason.SelectedValue = GetString(oReader, 2)
                ViewState("MotoReason") = GetString(oReader, 2)
            End If
        End Using
    End Sub

    '画面表示(複写) 
    Private Sub DisplayShowCopy() 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery += "SELECT A.MEASURE_KB01,A.MEASURE_01,A.MEASURE_KB02,A.MEASURE_02,A.MEASURE_KB03,A.MEASURE_03,A.MEASURE_KB04,A.MEASURE_04,A.MEASURE_KB05,A.MEASURE_05,A.MEASURE_KB06,A.MEASURE_06,A.MEASURE_KB07,A.MEASURE_07,A.MEASURE_KB08,A.MEASURE_08,A.MEASURE_KB09,A.MEASURE_09,A.MEASURE_KB10,A.MEASURE_10," 
            sQuery += "A.TPERS_AMT,A.O_SKETCH_NO,A.PARTS_NM,A.WORK_STD_NO,A.PACKUP_KB " 
            sQuery += "FROM PARTS_MST A " 
            sQuery += "WHERE A.CATALOG_NO = :K01" 
            _oDatabase.CreateParam("K01", txtCopyCatalog.Text.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                txtSunpouName1.Text = GetString(oReader, 0) 
                txtSunpou1.Text = GetDouble(oReader, 1).ToString("###.##") 
                txtSunpouName2.Text = GetString(oReader, 2) 
                txtSunpou2.Text = GetDouble(oReader, 3).ToString("###.##") 
                txtSunpouName3.Text = GetString(oReader, 4) 
                txtSunpou3.Text = GetDouble(oReader, 5).ToString("###.##") 
                txtSunpouName4.Text = GetString(oReader, 6) 
                txtSunpou4.Text = GetDouble(oReader, 7).ToString("###.##") 
                txtSunpouName5.Text = GetString(oReader, 8) 
                txtSunpou5.Text = GetDouble(oReader, 9).ToString("###.##") 
                txtSunpouName6.Text = GetString(oReader, 10) 
                txtSunpou6.Text = GetDouble(oReader, 11).ToString("###.##") 
                txtSunpouName7.Text = GetString(oReader, 12) 
                txtSunpou7.Text = GetDouble(oReader, 13).ToString("###.##") 
                txtSunpouName8.Text = GetString(oReader, 14) 
                txtSunpou8.Text = GetDouble(oReader, 15).ToString("###.##") 
                txtSunpouName9.Text = GetString(oReader, 16) 
                txtSunpou9.Text = GetDouble(oReader, 17).ToString("###.##") 
                txtSunpouName10.Text = GetString(oReader, 18) 
                txtSunpou10.Text = GetDouble(oReader, 19).ToString("###.##") 
                cboTest.SelectedValue = GetString(oReader, 20) 
                txtGenga.Text = GetString(oReader, 21) 
                txtBuhin.Text = GetString(oReader, 22) 
                txtZumen.Text = GetString(oReader, 23) 
                cboKonpou.SelectedValue = GetString(oReader, 24) 
            End If 
            oReader.Close() 
            ViewState("SaveCopyCatalog") = txtCopyCatalog.Text.Trim() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
#End Region 
 
#Region " ファイル関連 " 

    '登録
    Private Function FileInsert() As Boolean
        Dim sQuery As String = String.Empty
        Try
            _oDatabase.BeginTrans()

            '社内NO取得
            Me.lblSyanai.Text = _oDatabase.GetNumber(MedicalLib.DataAccess.Saiban.SN).ToString("000000")

            'マスタ更新履歴テーブル追加
            InsertHistory(ViewState("SaveCatalog").ToString)

            sQuery += "INSERT INTO PARTS_MST("
            sQuery += "  CATALOG_NO, COMPANY_NO, C_NO, ASSY_KB, GRP_CD"
            sQuery += ", O_CATALOG_NO, UPD_KB, MATL_CD, MATL_SPEC, UNIT_MATL_WAT"
            sQuery += ", MATL_PRICE_KB, MATL_WAT, O_SKETCH_NO, WORK_STD_NO, CREATOR"
            sQuery += ", CHECKER, RECOGNIZER_SK, RECOGNIZER_QL, TPERS_AMT, PACKUP_KB"
            sQuery += ", MEASURE_KB01, MEASURE_01, MEASURE_KB02, MEASURE_02, MEASURE_KB03, MEASURE_03"
            sQuery += ", MEASURE_KB04, MEASURE_04, MEASURE_KB05, MEASURE_05, MEASURE_KB06, MEASURE_06"
            sQuery += ", MEASURE_KB07, MEASURE_07, MEASURE_KB08, MEASURE_08, MEASURE_KB09, MEASURE_09"
            sQuery += ", MEASURE_KB10, MEASURE_10"
            sQuery += ", PROSTD_NO, RECOGNIZER_NO, SALE_NM, GENERAL_NM"
            sQuery += ", TYPE_1, TYPE_2, STERILIZE_KB, PARTS_NM, SURPLUS_STOP_FLG"
            sQuery += ", COST_KBN, ROYALTIES_KBN"  '2013/08/26 Add
            sQuery += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
            sQuery += ") VALUES ("
            sQuery += "  :F01, :F02, :F03, :F04, :F05"
            sQuery += ", :F06, :F07, :F08, :F09, :F10"
            sQuery += ", :F11, :F12, :F13, :F14, :F15"
            sQuery += ", :F16, :F17, :F18, :F19, :F20"
            sQuery += ", :F21, :F22, :F23, :F24, :F25, :F26"
            sQuery += ", :F27, :F28, :F29, :F30, :F31, :F32"
            sQuery += ", :F33, :F34, :F35, :F36, :F37, :F38"
            sQuery += ", :F39, :F40"
            sQuery += ", :F41, :F42, :F43, :F44"
            sQuery += ", :F45, :F46, :F47, :F48, :F49"
            sQuery += ", :F57, :F58"  '2013/08/26 Add
            sQuery += ", :F50, :F51, :F52, :F53, :F54, :F55, :F56"
            sQuery += ")"
            _oDatabase.CreateParam("F01", ViewState("SaveCatalog").ToString)
            _oDatabase.CreateParam("F02", Me.lblSyanai.Text.Trim)
            _oDatabase.CreateParam("F03", Me.txtKumiban.Text.Trim)
            _oDatabase.CreateParam("F04", Me.txtAssy.Text.Trim)
            _oDatabase.CreateParam("F05", Me.txtGroupCode.Text.Trim)
            _oDatabase.CreateParam("F06", txtMotoCatalog.Text.Trim())
            _oDatabase.CreateParam("F07", cboSyusei.SelectedValue())
            _oDatabase.CreateParam("F08", txtZairyo.Text.Trim())
            _oDatabase.CreateParam("F09", lblSpec.Text.Trim())
            _oDatabase.CreateParam("F10", txtSozai.Text.Trim.PadRight(1, "0"))
            _oDatabase.CreateParam("F11", txtTani.Text.Trim())
            _oDatabase.CreateParam("F12", txtTanju.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F13", txtGenga.Text.Trim())
            _oDatabase.CreateParam("F14", txtZumen.Text.Trim())
            _oDatabase.CreateParam("F15", txtSakusei.Text.Trim())
            _oDatabase.CreateParam("F16", txtTenken.Text.Trim())
            _oDatabase.CreateParam("F17", txtGijutu.Text.Trim())
            _oDatabase.CreateParam("F18", txtHinkan.Text.Trim())
            _oDatabase.CreateParam("F19", cboTest.SelectedValue())
            _oDatabase.CreateParam("F20", cboKonpou.SelectedValue())
            _oDatabase.CreateParam("F21", txtSunpouName1.Text.Trim())
            _oDatabase.CreateParam("F22", txtSunpou1.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F23", txtSunpouName2.Text.Trim())
            _oDatabase.CreateParam("F24", txtSunpou2.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F25", txtSunpouName3.Text.Trim())
            _oDatabase.CreateParam("F26", txtSunpou3.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F27", txtSunpouName4.Text.Trim())
            _oDatabase.CreateParam("F28", txtSunpou4.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F29", txtSunpouName5.Text.Trim())
            _oDatabase.CreateParam("F30", txtSunpou5.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F31", txtSunpouName6.Text.Trim())
            _oDatabase.CreateParam("F32", txtSunpou6.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F33", txtSunpouName7.Text.Trim())
            _oDatabase.CreateParam("F34", txtSunpou7.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F35", txtSunpouName8.Text.Trim())
            _oDatabase.CreateParam("F36", txtSunpou8.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F37", txtSunpouName9.Text.Trim())
            _oDatabase.CreateParam("F38", txtSunpou9.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F39", txtSunpouName10.Text.Trim())
            _oDatabase.CreateParam("F40", txtSunpou10.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F41", lblSeihin.Text.Trim())
            _oDatabase.CreateParam("F42", lblSyounin.Text.Trim())
            _oDatabase.CreateParam("F43", lblHanbai.Text.Trim())
            _oDatabase.CreateParam("F44", lblIppan.Text.Trim())
            _oDatabase.CreateParam("F45", lblSyurui1.Text.Trim())
            _oDatabase.CreateParam("F46", lblSyurui2.Text.Trim())
            If chkMekkin.Checked Then
                _oDatabase.CreateParam("F47", "1")
            Else
                _oDatabase.CreateParam("F47", "0")
            End If
            _oDatabase.CreateParam("F48", txtBuhin.Text.Trim())
            If chkTeisi.Checked Then
                _oDatabase.CreateParam("F49", "1")
            Else
                _oDatabase.CreateParam("F49", "0")
            End If
            _oDatabase.CreateParam("F50", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F51", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F52", Session("UserID"))
            _oDatabase.CreateParam("F53", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F54", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F55", Session("UserID"))
            _oDatabase.CreateParam("F56", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("F57", txtCost.Text.Trim())       '2013/08/26 Add
            _oDatabase.CreateParam("F58", txtRoyalties.Text.Trim())  '2013/08/26 Add

            _oDatabase.ExecuteNonQueryParam(sQuery)

            If Me.cboSyusei.SelectedValue = "1" Then
                '修正中で

                sQuery = ""
                sQuery += "INSERT INTO PARTS_UPDATE_REASON_TBL"
                sQuery += " (CATALOG_NO, UPD_DATETIME, UPDATE_REASON, UPDATOR"
                sQuery += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                sQuery += " ) VALUES ("
                sQuery += "  :F01, :F02, :F03, :F04"
                sQuery += ", :F05, :F06, :F07, :F08, :F09, :F10, :F11"
                sQuery += " )"
                _oDatabase.CreateParam("F01", ViewState("SaveCatalog"))
                _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate & MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F03", Me.cboReason.SelectedValue.Trim)
                _oDatabase.CreateParam("F04", Me.txtUpdator.Text.Trim)
                _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F07", Session("UserID"))
                _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F10", Session("UserID"))
                _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)

                _oDatabase.ExecuteNonQueryParam(sQuery)
            End If

            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Function

    '更新 
    Private Function FileUpdate() As Boolean 
        Dim sQuery As String = "" 
        Try
            _oDatabase.BeginTrans()

            'マスタ更新履歴テーブル追加
            TableUpdateHistory()

            sQuery = "UPDATE PARTS_MST SET O_CATALOG_NO=:F01,UPD_KB=:F02,MATL_CD=:F03,MATL_SPEC=:F04,UNIT_MATL_WAT=:F05," + _
                                           "MATL_PRICE_KB=:F06,MATL_WAT=:F07,O_SKETCH_NO=:F08,WORK_STD_NO=:F09,CREATOR=:F10," + _
                                           "CHECKER=:F11,RECOGNIZER_SK=:F12,RECOGNIZER_QL=:F13,TPERS_AMT=:F14,PACKUP_KB=:F15," + _
                                           "MEASURE_KB01=:F16,MEASURE_01=:F17,MEASURE_KB02=:F18,MEASURE_02=:F19,MEASURE_KB03=:F20," + _
                                           "MEASURE_03=:F21,MEASURE_KB04=:F22,MEASURE_04=:F23,MEASURE_KB05=:F24,MEASURE_05=:F25," + _
                                           "MEASURE_KB06=:F26,MEASURE_06=:F27,MEASURE_KB07=:F28,MEASURE_07=:F29,MEASURE_KB08=:F30," + _
                                           "MEASURE_08=:F31,MEASURE_KB09=:F32,MEASURE_09=:F33,MEASURE_KB10=:F34,MEASURE_10=:F35," + _
                                           "PROSTD_NO=:F36,RECOGNIZER_NO=:F37,SALE_NM=:F38,GENERAL_NM=:F39,TYPE_1=:F40," + _
                                           "TYPE_2=:F41,STERILIZE_KB=:F42,PARTS_NM=:F47,UPD_DT=:F43,UPD_TIME=:F44,UPD_USR=:F45," + _
                                           "UPD_PROGRAM_ID=:F46," + _
                                           "SURPLUS_STOP_FLG=:F48 "
            sQuery += ", C_NO = :F49"       '組番       2012/12 追加
            sQuery += ", ASSY_KB = :F50"    'ASSY区分   2012/12 追加
            sQuery += ", GRP_CD = :F51"     'ｸﾞﾙｰﾌﾟｺｰﾄﾞ 2012/12 追加
            sQuery += ", COST_KBN = :F52"       '原価区分         2013/08/26 追加
            sQuery += ", ROYALTIES_KBN = :F53"  'ロイヤリティ区分 2013/08/26 追加
            sQuery += " WHERE CATALOG_NO=:K01"
            _oDatabase.CreateParam("F01", txtMotoCatalog.Text.Trim())
            _oDatabase.CreateParam("F02", cboSyusei.SelectedValue())
            _oDatabase.CreateParam("F03", txtZairyo.Text.Trim())
            _oDatabase.CreateParam("F04", lblSpec.Text.Trim())
            _oDatabase.CreateParam("F05", txtSozai.Text.Trim.PadRight(1, "0"))
            _oDatabase.CreateParam("F06", txtTani.Text.Trim())
            _oDatabase.CreateParam("F07", txtTanju.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F08", txtGenga.Text.Trim())
            _oDatabase.CreateParam("F09", txtZumen.Text.Trim())
            _oDatabase.CreateParam("F10", txtSakusei.Text.Trim())
            _oDatabase.CreateParam("F11", txtTenken.Text.Trim())
            _oDatabase.CreateParam("F12", txtGijutu.Text.Trim())
            _oDatabase.CreateParam("F13", txtHinkan.Text.Trim())
            _oDatabase.CreateParam("F14", cboTest.SelectedValue())
            _oDatabase.CreateParam("F15", cboKonpou.SelectedValue())
            _oDatabase.CreateParam("F16", txtSunpouName1.Text.Trim())
            _oDatabase.CreateParam("F17", txtSunpou1.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F18", txtSunpouName2.Text.Trim())
            _oDatabase.CreateParam("F19", txtSunpou2.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F20", txtSunpouName3.Text.Trim())
            _oDatabase.CreateParam("F21", txtSunpou3.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F22", txtSunpouName4.Text.Trim())
            _oDatabase.CreateParam("F23", txtSunpou4.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F24", txtSunpouName5.Text.Trim())
            _oDatabase.CreateParam("F25", txtSunpou5.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F26", txtSunpouName6.Text.Trim())
            _oDatabase.CreateParam("F27", txtSunpou6.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F28", txtSunpouName7.Text.Trim())
            _oDatabase.CreateParam("F29", txtSunpou7.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F30", txtSunpouName8.Text.Trim())
            _oDatabase.CreateParam("F31", txtSunpou8.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F32", txtSunpouName9.Text.Trim())
            _oDatabase.CreateParam("F33", txtSunpou9.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F34", txtSunpouName10.Text.Trim())
            _oDatabase.CreateParam("F35", txtSunpou10.Text.Trim.PadLeft(1, "0"))
            _oDatabase.CreateParam("F36", lblSeihin.Text.Trim())
            _oDatabase.CreateParam("F37", lblSyounin.Text.Trim())
            _oDatabase.CreateParam("F38", lblHanbai.Text.Trim())
            _oDatabase.CreateParam("F39", lblIppan.Text.Trim())
            _oDatabase.CreateParam("F40", lblSyurui1.Text.Trim())
            _oDatabase.CreateParam("F41", lblSyurui2.Text.Trim())
            If chkMekkin.Checked Then
                _oDatabase.CreateParam("F42", "1")
            Else
                _oDatabase.CreateParam("F42", "0")
            End If
            _oDatabase.CreateParam("F47", txtBuhin.Text.Trim())
            _oDatabase.CreateParam("F43", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F44", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F45", Session("UserID"))
            _oDatabase.CreateParam("F46", MedicalLib.Common.ProgramID)
            '生産停止区分追加
            If chkTeisi.Checked Then
                _oDatabase.CreateParam("F48", "1")
            Else
                _oDatabase.CreateParam("F48", "0")
            End If

            '**** 2012/12 ホスト廃止対応 ST ****
            _oDatabase.CreateParam("F49", Me.txtKumiban.Text.Trim)
            _oDatabase.CreateParam("F50", Me.txtAssy.Text.Trim)
            _oDatabase.CreateParam("F51", Me.txtGroupCode.Text.Trim)
            '**** 2012/12 ホスト廃止対応 ED ****
            _oDatabase.CreateParam("F52", txtCost.Text.Trim())       '2013/08/26 Add
            _oDatabase.CreateParam("F53", txtRoyalties.Text.Trim())  '2013/08/26 Add

            _oDatabase.CreateParam("K01", ViewState("SaveCatalog"))
            _oDatabase.ExecuteNonQueryParam(sQuery)

            '**** 2010/08/27 修正理由対応 ST ****
            If Me.cboSyusei.SelectedValue = "1" Then
                '修正中で
                If Me.txtUpdator.Text.Trim <> ViewState("MotoUpdator") Or _
                   Me.cboReason.SelectedValue <> ViewState("MotoReason") Then
                    '修正者か修正理由が変更されたら

                    sQuery = ""
                    sQuery += "INSERT INTO PARTS_UPDATE_REASON_TBL"
                    sQuery += " (CATALOG_NO, UPD_DATETIME, UPDATE_REASON, UPDATOR"
                    sQuery += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                    sQuery += " ) VALUES ("
                    sQuery += "  :F01, :F02, :F03, :F04"
                    sQuery += ", :F05, :F06, :F07, :F08, :F09, :F10, :F11"
                    sQuery += " )"
                    _oDatabase.CreateParam("F01", ViewState("SaveCatalog"))
                    _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate & MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F03", Me.cboReason.SelectedValue.Trim)
                    _oDatabase.CreateParam("F04", Me.txtUpdator.Text.Trim)
                    _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F07", Session("UserID"))
                    _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F10", Session("UserID"))
                    _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)

                    _oDatabase.ExecuteNonQueryParam(sQuery)
                End If
            End If
            '**** 2010/08/27 修正理由対応 ED ****

            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Function 

    '削除
    Private Function FileDelete() As Boolean
        Dim sQuery As String = String.Empty
        Try
            _oDatabase.BeginTrans()

            '部品マスタ マスタ更新履歴テーブル追加
            DeleteHistory(ViewState("SaveCatalog").ToString, True)

            '部品マスタ削除
            sQuery += "DELETE FROM PARTS_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", ViewState("SaveCatalog").ToString)
            _oDatabase.ExecuteNonQueryParam(sQuery)

            '加工工程マスタ マスタ更新履歴テーブル追加
            sQuery = ""
            sQuery += "SELECT CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB"
            sQuery += "  FROM P_PROCESS_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            sQuery += " ORDER BY CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB"
            _oDatabase.CreateParam("K01", ViewState("SaveCatalog").ToString)
            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                While oReader.Read
                    DeleteHistory(GetString(oReader, 0) & ":" & GetInt32(oReader, 1) & ":" & GetInt32(oReader, 2), False)
                End While
            End Using

            '加工工程マスタ削除
            sQuery = ""
            sQuery += "DELETE FROM P_PROCESS_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", ViewState("SaveCatalog").ToString)
            _oDatabase.ExecuteNonQueryParam(sQuery)

            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
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
 
    'コンボボックス設定 
    Private Sub ComboSet(ByVal sKey As String, ByRef oCombo As Web.UI.WebControls.DropDownList) 
        Dim sQuery As String = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = :K01"
        _oDatabase.CreateParam("K01", sKey)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            oCombo.Items.Clear()
            oCombo.Items.Add(New ListItem("", ""))
            While oReader.Read()
                oCombo.Items.Add(New ListItem(oReader.GetString(0) + ":" + oReader.GetString(1), oReader.GetString(0)))
            End While
        End Using
    End Sub

    '単重算出 
    Private Function GetTanju(ByVal sZairyo As String, ByVal sSozai As String) As String
        Dim sReturnValue As String = ""
        If Not sZairyo.Trim.Equals("") And Not sSozai.Trim.Equals("") Then
            If Not Regex.IsMatch(sSozai, "^[0-9]{1,7}(\.[0-9])?$") Then Return ""
            Dim sCode As String = sZairyo.Trim.PadRight(15, " ")
            '材料比重設定 
            Dim nGravity As Double = 7.85
            Select Case sCode.Substring(1, 1)
                Case "9"
                    nGravity = 9
                Case "8"
                    nGravity = 2.77
                Case "7"
                    nGravity = 4.43
                Case "6"
                    nGravity = 8.2
            End Select
            '単重算出 
            Dim nDummy As Double = 0
            Select Case sCode.Substring(0, 1)
                Case "1"
                    sReturnValue = sSozai
                Case "2"
                    Try
                        If Not sCode.Substring(13, 1).Equals("0") Then
                            nDummy = (sCode.Substring(9, 4) / 100) ^ 2 * sSozai * 3.14159 * (nGravity / 4000)
                        Else
                            nDummy = (sCode.Substring(9, 5) / 100) ^ 2 * sSozai * 3.14159 * (nGravity / 4000)
                        End If
                        sReturnValue = Math.Round(nDummy, 1)
                    Catch ex As Exception
                        sReturnValue = ""
                    End Try
                Case "3"
                    Try
                        nDummy = (sCode.Substring(9, 4) / 100) ^ 2 * sSozai * 0.8660254 * (nGravity / 1000)
                        sReturnValue = Math.Round(nDummy, 1)
                    Catch ex As Exception
                        sReturnValue = ""
                    End Try
            End Select
        End If
        Return sReturnValue
    End Function

    '部品マスタ登録済み？       2012/12 ホスト廃止対応
    Private Function PartsMstExist(ByVal sCatalog As String) As Boolean
        Dim sQuery As String = String.Empty
        sQuery = "SELECT CATALOG_NO FROM PARTS_MST WHERE CATALOG_NO = :K01"
        _oDatabase.CreateParam("K01", sCatalog)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            PartsMstExist = oReader.HasRows
        End Using
    End Function

    '着工済み？                 2012/12 ホスト廃止対応
    Private Function IndicateTblExist(ByVal sCatalog As String) As Boolean
        Dim sQuery As String = String.Empty
        sQuery += "SELECT P.CATALOG_NO"
        sQuery += "  FROM PARTS_MST P"
        sQuery += " WHERE CATALOG_NO = :K01"
        sQuery += "   AND EXISTS (SELECT * FROM INDICATE_TBL I WHERE I.COMPANY_NO = P.COMPANY_NO)"
        _oDatabase.CreateParam("K01", sCatalog)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            IndicateTblExist = oReader.HasRows
        End Using
    End Function

#End Region

#Region " 更新履歴用 "

    Private Sub InsertHistory(ByVal sKey As String)
        InsertMH(sKey, "追加", "", "")
    End Sub

    Private Sub DeleteHistory(ByVal sKey As String, ByVal IsBuhin As Boolean)
        InsertMH(sKey, "削除", "", "", IsBuhin)
    End Sub

    Private Sub TableUpdateHistory()
        Dim sItemNames() As String = GetItemName().Split(",")
        Dim sMotoValues() As String = GetMotoValue(sItemNames.Length()).Split(",")
        Dim teisi As String = "0"
        If chkTeisi.Checked Then teisi = "1"
        Dim sGenValue As String = ""
        '**** 2012/12 ホスト廃止対応 ST ****
        '**** 組番,ASSY区分,ｸﾞﾙｰﾌﾟｺｰﾄﾞ追加
        sGenValue += Me.txtKumiban.Text.Trim + "," + vbTab + "," + txtMotoCatalog.Text.Trim + "," + cboSyusei.SelectedValue + "," + txtZairyo.Text.Trim + "," + vbTab + "," + txtSozai.Text.Trim.PadLeft(1, "0") + "," + txtTani.Text.Trim + "," + txtTanju.Text.Trim.PadLeft(1, "0") + ","
        sGenValue += txtGenga.Text.Trim + "," + txtZumen.Text.Trim + "," + txtSakusei.Text.Trim + "," + txtTenken.Text.Trim + "," + txtGijutu.Text.Trim + "," + txtHinkan.Text.Trim + "," + cboTest.SelectedValue + "," + cboKonpou.SelectedValue + "," + Me.txtAssy.Text.Trim + "," + vbTab + ","
        sGenValue += txtSunpouName1.Text.Trim + "," + txtSunpou1.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName2.Text.Trim + "," + txtSunpou2.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName3.Text.Trim + "," + txtSunpou3.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName4.Text.Trim + "," + txtSunpou4.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName5.Text.Trim + "," + txtSunpou5.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName6.Text.Trim + "," + txtSunpou6.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName7.Text.Trim + "," + txtSunpou7.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName8.Text.Trim + "," + txtSunpou8.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName9.Text.Trim + "," + txtSunpou9.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName10.Text.Trim + "," + txtSunpou10.Text.Trim.PadLeft(1, "0") + ","
        sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + ","
        sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + txtBuhin.Text.Trim + ","
        sGenValue += Me.txtGroupCode.Text.Trim + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + teisi
        sGenValue += "," + Me.txtCost.Text.Trim + "," + Me.txtRoyalties.Text.Trim  '2013/08/26 原価、ロイヤリティ追加 ST ****
        sGenValue += "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab '不具合対応
        'sGenValue += "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab '不具合対応
        'sGenValue += "," + Me.txtCost.Text.Trim + "," + Me.txtRoyalties.Text.Trim + "," + vbTab  '2013/08/26 原価、ロイヤリティ追加 ST ****
        'sGenValue += vbTab + "," + vbTab + "," + txtMotoCatalog.Text.Trim + "," + cboSyusei.SelectedValue + "," + txtZairyo.Text.Trim + "," + vbTab + "," + txtSozai.Text.Trim.PadLeft(1, "0") + "," + txtTani.Text.Trim + "," + txtTanju.Text.Trim.PadLeft(1, "0") + ","
        'sGenValue += txtGenga.Text.Trim + "," + txtZumen.Text.Trim + "," + txtSakusei.Text.Trim + "," + txtTenken.Text.Trim + "," + txtGijutu.Text.Trim + "," + txtHinkan.Text.Trim + "," + cboTest.SelectedValue + "," + cboKonpou.SelectedValue + "," + vbTab + "," + vbTab + ","
        'sGenValue += txtSunpouName1.Text.Trim + "," + txtSunpou1.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName2.Text.Trim + "," + txtSunpou2.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName3.Text.Trim + "," + txtSunpou3.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName4.Text.Trim + "," + txtSunpou4.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName5.Text.Trim + "," + txtSunpou5.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName6.Text.Trim + "," + txtSunpou6.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName7.Text.Trim + "," + txtSunpou7.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName8.Text.Trim + "," + txtSunpou8.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName9.Text.Trim + "," + txtSunpou9.Text.Trim.PadLeft(1, "0") + "," + txtSunpouName10.Text.Trim + "," + txtSunpou10.Text.Trim.PadLeft(1, "0") + ","
        'sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + ","
        'sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + txtBuhin.Text.Trim + ","
        'sGenValue += vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + vbTab + "," + teisi
        '**** 2012/12 ホスト廃止対応 ED ****

        Dim sGenValues() As String = sGenValue.Split(",")

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            Select Case i
                Case 19 To 38       '寸法
                    'If sMotoValues(i) + ":" + sMotoValues(i + 1) <> sGenValues(i) + ":" + sGenValues(i + 1) Then
                    If sMotoValues(i) <> sGenValues(i) Or (Not (sMotoValues(i + 1) = "" And sGenValues(i + 1) = "0") And sMotoValues(i + 1) <> sGenValues(i + 1)) Then
                        InsertMH("寸法名:" + sItemNames(i + 1), sMotoValues(i) + ":" + sMotoValues(i + 1), sGenValues(i) + ":" + sGenValues(i + 1))
                    End If
                    i += 1
                Case Else
                    If sMotoValues(i) <> sGenValues(i) And Not sGenValues(i).Equals(vbTab) Then
                        Select Case i
                            Case 0          '組番
                                InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS014"), GetHanyouName(sGenValues(i), "MS014"))
                            Case 11 To 14   '作業者～品管
                                InsertMH(sItemNames(i), GetSagyoName(sMotoValues(i)), GetSagyoName(sGenValues(i)))
                            Case 15      'テストピース
                                InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS005"), GetHanyouName(sGenValues(i), "MS005"))
                            Case 16      '梱包区分
                                InsertMH(sItemNames(i), GetHanyouName(sMotoValues(i), "MS006"), GetHanyouName(sGenValues(i), "MS006"))
                            Case Else
                                InsertMH(sItemNames(i), sMotoValues(i), sGenValues(i))
                        End Select
                    End If
            End Select
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
                    'If GetString(oReader, 1) = "登録日付" Then
                    '    Exit While
                    'Else
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
            sQuery = "SELECT * FROM PARTS_MST WHERE CATALOG_NO = :KEY1 "
            _oDatabase.CreateParam("KEY1", ViewState("SaveCatalog"))
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
        InsertMH(ViewState("SaveCatalog"), sItemName, sMae, sAto)
    End Sub

    Private Sub InsertMH(ByVal sKey As String, ByVal sItemName As String, ByVal sMae As String, ByVal sAto As String, Optional ByVal IsBuhin As Boolean = True)
        Dim sQuery As String = ""

        sQuery = "INSERT INTO MASTER_HIS_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
                                                    ":F11,:F12,:F13,:F14)"
        _oDatabase.CreateParam("F01", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemTime)
        If IsBuhin Then
            _oDatabase.CreateParam("F03", TABLE_NAME_JP)
        Else
            _oDatabase.CreateParam("F03", TABLE_NAME_JP_KAKOU)
        End If
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

    '作業者 名付き
    Private Function GetSagyoName(ByVal sKey As String) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sResult As String = ""
        Try
            sQuery += "SELECT WORKER_CD,WORKER_NM FROM WORKER_MST WHERE WORKER_CD = :K01"
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