Imports System.IO 
Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdmas020
    Inherits System.Web.UI.Page
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS020"
    Private Const PROGRAM_TITLE As String = "メニューマスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess

    'Friend _sCallBackScript As String = ""
    Public _sCallBackScript As String = ""
    Private _sGetValue As String = ""

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        _sCallBackScript = Page.ClientScript.GetCallbackEventReference(Me, "command", "getCallBack", "context", "getCallBackError", False)
        If Not Page.IsPostBack Then
            txtRow.Value = -1
            Dim sScript As New System.Text.StringBuilder
            sScript.Append("<script language=""JavaScript"">")
            sScript.Append("backRow=-1;backColor='';")
            sScript.Append("</script>")
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "authenticated", sScript.ToString())
            ComboSet("MS001", cboLevel)
            DisplayInit()
            btnDelete1.Attributes.Add("onclick", MedicalLib.Script.Delete())
            btnDelete2.Attributes.Add("onclick", MedicalLib.Script.Delete())
            cboLevel.Focus()
        End If
        btnNew1.Visible = MedicalLib.Common.EnableInsert
        btnNew2.Visible = MedicalLib.Common.EnableInsert
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub grdList1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList1.ItemDataBound
        Dim origItem As String = ColorTranslator.ToHtml(grdList1.ItemStyle.BackColor)
        Dim origAltItem As String = ColorTranslator.ToHtml(grdList1.AlternatingItemStyle.BackColor)
        Dim oLine As DataGridItem = e.Item
        Dim sColor As String = ""
        If oLine.ItemType = ListItemType.Item Or oLine.ItemType = ListItemType.AlternatingItem Then
            oLine.Style("cursor") = "hand"
            oLine.Attributes("onmouseover") = "changeColor(" & oLine.ItemIndex & ",'Gold');"
            If oLine.ItemType = ListItemType.Item Then
                oLine.Attributes("onmouseout") = "changeColor(" & oLine.ItemIndex & ",'" + origItem + "');"
                sColor = origItem
            Else
                oLine.Attributes("onmouseout") = "changeColor(" & oLine.ItemIndex & ",'" + origAltItem + "');"
                sColor = origAltItem
            End If
            oLine.Attributes("onclick") = "selectGridRow1(" & oLine.ItemIndex & ",'" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + sColor + "')"
        End If
    End Sub

    Protected Sub grdList2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList2.ItemDataBound
        Dim origItem As String = ColorTranslator.ToHtml(grdList2.ItemStyle.BackColor)
        Dim origAltItem As String = ColorTranslator.ToHtml(grdList2.AlternatingItemStyle.BackColor)
        Dim oLine As DataGridItem = e.Item
        If oLine.ItemType = ListItemType.Item Or oLine.ItemType = ListItemType.AlternatingItem Then
            oLine.Style("cursor") = "hand"
            oLine.Attributes("onmouseover") = "this.style.backgroundColor='Gold'"
            If oLine.ItemType = ListItemType.Item Then
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origItem + "'"
            Else
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origAltItem + "'"
            End If
            'oLine.Attributes("onclick") = "selectGridRow2('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "')" 
            oLine.Attributes("onclick") = "selectGridRow2('" + oLine.Cells(0).Text + "')"
        End If
    End Sub

    '検索ボタン押下 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        ViewState("level") = cboLevel.SelectedValue
        pnlList1.Visible = False
        udpList1.Update()
        pnlInput1.Visible = False
        udpInput1.Update()
        pnlList2.Visible = False
        udpList2.Update()
        pnlInput2.Visible = False
        udpInput2.Update()
        DisplayGrid1()
    End Sub

    '選択ボタン(隠し)押下 
    Protected Sub btnSelect1_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelect1.Click
        DisplayShow1(txtMenuID.Value)
    End Sub

    Protected Sub btnSelect2_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelect2.Click
        DisplayShow2(txtSaveID.Value)
    End Sub

    '新規ボタン押下 
    Protected Sub btnNew1_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnNew1.Click
        txtRow.Value = -1
        txtMenuID.Value = ""
        ViewState("menuid") = ""
        txtMenuName.Text = ""
        txtMenuNumber.Text = ""
        MenuNameEnabled(True)
        btnUpdate1.Attributes.Add("onclick", MedicalLib.Script.Insert())
        btnUpdate1.Attributes("src") = "../image/b_insert.gif"
        btnDelete1.Visible = False
        pnlInput1.Visible = True
        udpInput1.Update()
        pnlList2.Visible = False
        udpList2.Update()
        pnlInput2.Visible = False
        udpInput2.Update()
    End Sub

    Protected Sub btnNew2_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnNew2.Click
        txtSaveID.Value = ""
        txtProgramID.Text = ""
        lblProgramName.Text = ""
        txtProgramNumber.Text = ""
        ProgramIDEnabled(True)
        btnUpdate2.Attributes.Add("onclick", MedicalLib.Script.Insert())
        btnUpdate2.Attributes("src") = "../image/b_insert.gif"
        btnDelete2.Visible = False
        pnlInput2.Visible = True
        udpInput2.Update()
    End Sub

    '登録、修正ボタン押下 
    Protected Sub btnUpdate1_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnUpdate1.Click
        Page.Validate("input1")
        If Not Page.IsValid Then Return
        If Not FileUpdate1() Then Return
        DisplayGrid1()
        pnlInput1.Visible = False
        udpInput1.Update()
    End Sub

    Protected Sub btnUpdate2_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnUpdate2.Click
        Page.Validate("input2")
        If Not Page.IsValid Then
            If Not valProgramID2.IsValid Then valProgramID3.IsValid = True
            Return
        End If
        If Not FileUpdate2() Then Return
        DisplayGrid2(txtMenuID.Value)
        pnlInput2.Visible = False
        udpInput2.Update()
    End Sub

    '削除ボタン押下 
    Protected Sub btnDelete1_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnDelete1.Click
        If Not FileDelete1() Then Return
        DisplayGrid1()
        pnlInput1.Visible = False
        udpInput1.Update()
        pnlList2.Visible = False
        udpList2.Update()
        pnlInput2.Visible = False
        udpInput2.Update()
    End Sub

    Protected Sub btnDelete2_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnDelete2.Click
        If Not FileDelete2() Then Return
        DisplayGrid2(txtMenuID.Value)
        pnlInput2.Visible = False
        udpInput2.Update()
    End Sub

    '戻るボタン押下 
    Protected Sub btnBack1_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBack1.Click
        DisplayClear2()
        DisplayClear1()
    End Sub

    Protected Sub btnBack2_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBack2.Click
        DisplayClear2()
    End Sub

#End Region

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        Dim sReturnValue As String = ""
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        sQuery = "SELECT PG_NM FROM PROGRAM_MST WHERE MENU_LEBEL = '2' AND PROGRAM_ID = :K01"
        _oDatabase.CreateParam("K01", _sGetValue)
        oReader = _oDatabase.CreateReaderParam(sQuery)
        If oReader.Read() Then
            sReturnValue = GetString(oReader, 0)
        End If
        oReader.Close()
        Return sReturnValue
    End Function

    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        _sGetValue = eventArgument
    End Sub

#End Region

#Region " 画面関連 "

    '画面初期化 
    Private Sub DisplayInit()
        MenuNameEnabled(True)
        ProgramIDEnabled(True)
        cboLevel.SelectedIndex = 0
        pnlList1.Visible = False
        udpList1.Update()
        pnlInput1.Visible = False
        udpInput1.Update()
        pnlList2.Visible = False
        udpList2.Update()
        pnlInput2.Visible = False
        udpInput2.Update()
    End Sub

    '画面クリア 
    Private Sub DisplayClear1()
        txtMenuID.Value = ""
        ViewState("menuid") = ""
        txtMenuName.Text = ""
        txtMenuNumber.Text = ""
        pnlList1.Visible = False
        udpList1.Update()
        pnlInput1.Visible = False
        udpInput1.Update()
    End Sub

    Private Sub DisplayClear2()
        txtSaveID.Value = ""
        txtProgramID.Text = ""
        lblProgramName.Text = ""
        txtProgramNumber.Text = ""
        pnlList2.Visible = False
        udpList2.Update()
        pnlInput2.Visible = False
        udpInput2.Update()
    End Sub

    '画面表示 
    Private Sub DisplayShow1(ByVal sCode As String)
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT B.PG_NM,A.DSP_TURN "
            sQuery += "FROM (SELECT EMPOWER_LV,MENU_ID,DSP_TURN FROM MENU_MST WHERE MENU_LEBEL = '1') A,PROGRAM_MST B "
            sQuery += "WHERE A.MENU_ID = B.PROGRAM_ID(+) AND A.EMPOWER_LV = :K01 AND B.PROGRAM_ID = :K02"
            _oDatabase.CreateParam("K01", ViewState("level"))
            _oDatabase.CreateParam("K02", sCode.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                txtMenuName.Text = GetString(oReader, 0)
                txtMenuNumber.Text = GetInt32(oReader, 1)
            End If
            oReader.Close()
            ViewState("menuid") = sCode
            MenuNameEnabled(False)
            btnUpdate1.Attributes.Add("onclick", MedicalLib.Script.Update())
            btnUpdate1.Attributes("src") = "../image/b_update.gif"
            btnUpdate1.Visible = MedicalLib.Common.EnableUpdate
            btnDelete1.Visible = MedicalLib.Common.EnableDelete
            pnlInput1.Visible = True
            udpInput1.Update()
            DisplayGrid2(txtMenuID.Value.Trim())
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '画面表示 
    Private Sub DisplayShow2(ByVal sCode As String)
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT A.PROGRAM_ID,B.PG_NM,A.DSP_TURN "
            sQuery += "FROM (SELECT EMPOWER_LV,MENU_ID,PROGRAM_ID,DSP_TURN FROM MENU_MST WHERE MENU_LEBEL = '2') A,PROGRAM_MST B "
            sQuery += "WHERE A.PROGRAM_ID = B.PROGRAM_ID(+) AND A.EMPOWER_LV = :K01 AND A.MENU_ID = :K02 AND A.PROGRAM_ID = :K03"
            _oDatabase.CreateParam("K01", ViewState("level"))
            _oDatabase.CreateParam("K02", txtMenuID.Value.Trim())
            _oDatabase.CreateParam("K03", sCode.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                txtProgramID.Text = GetString(oReader, 0)
                lblProgramName.Text = GetString(oReader, 1)
                txtProgramNumber.Text = GetInt32(oReader, 2)
            End If
            oReader.Close()
            ProgramIDEnabled(False)
            btnUpdate2.Attributes.Add("onclick", MedicalLib.Script.Update())
            btnUpdate2.Attributes("src") = "../image/b_update.gif"
            btnUpdate2.Visible = MedicalLib.Common.EnableUpdate
            btnDelete2.Visible = MedicalLib.Common.EnableDelete
            pnlInput2.Visible = True
            udpInput2.Update()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    'リスト表示 
    Private Sub DisplayGrid1()
        Dim sQuery As String = ""
        Try
            sQuery = "SELECT A.MENU_ID,B.PG_NM,A.DSP_TURN "
            sQuery += "FROM (SELECT EMPOWER_LV,MENU_ID,DSP_TURN FROM MENU_MST WHERE MENU_LEBEL = '1') A,PROGRAM_MST B "
            sQuery += "WHERE A.MENU_ID = B.PROGRAM_ID(+) AND A.EMPOWER_LV = :K01 "
            sQuery += "ORDER BY A.DSP_TURN,B.PG_NM"
            _oDatabase.CreateParam("K01", ViewState("level"))
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView
            grdList1.DataSource = oDataView
            grdList1.DataBind()
            txtRow.Value = -1
            pnlList1.Visible = True
            udpList1.Update()
        Catch tex As Threading.ThreadAbortException
            Throw
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    'リスト表示 
    Private Sub DisplayGrid2(ByVal sMenuID As String)
        Dim sQuery As String = ""
        Try
            sQuery = "SELECT A.PROGRAM_ID,B.PG_NM,A.DSP_TURN "
            sQuery += "FROM (SELECT EMPOWER_LV,MENU_ID,PROGRAM_ID,DSP_TURN FROM MENU_MST WHERE MENU_LEBEL = '2') A,PROGRAM_MST B "
            sQuery += "WHERE A.PROGRAM_ID = B.PROGRAM_ID(+) AND A.EMPOWER_LV = :K01 AND MENU_ID = :K02 "
            sQuery += "ORDER BY A.DSP_TURN,A.PROGRAM_ID"
            _oDatabase.CreateParam("K01", ViewState("level"))
            _oDatabase.CreateParam("K02", sMenuID)
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView
            grdList2.DataSource = oDataView
            grdList2.DataBind()
            pnlList2.Visible = True
            udpList2.Update()
        Catch tex As Threading.ThreadAbortException
            Throw
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " チェック関連 "

    'メニュー 
    Protected Sub valMenuName3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valMenuName3.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            'If txtMenuName.Enabled Then 
            If txtMenuID.Value.Trim.Equals("") Then
                sQuery = "SELECT PROGRAM_ID FROM PROGRAM_MST WHERE MENU_LEBEL = '1' AND PG_NM = :K01"
                _oDatabase.CreateParam("K01", txtMenuName.Text.Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    txtMenuID.Value = GetString(oReader, 0)
                Else
                    txtMenuID.Value = ""
                End If
                oReader.Close()
                If Not txtMenuID.Value.Trim.Equals("") Then
                    CType(source, CustomValidator).ErrorMessage = "既に登録されています"
                    sQuery = "SELECT MENU_ID FROM MENU_MST WHERE EMPOWER_LV = :K01 AND MENU_LEBEL = '1' AND MENU_ID = :K02"
                    _oDatabase.CreateParam("K01", ViewState("level"))
                    _oDatabase.CreateParam("K02", txtMenuID.Value.Trim())
                    oReader = _oDatabase.CreateReaderParam(sQuery)
                    args.IsValid = Not oReader.Read()
                    oReader.Close()
                End If
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    'プログラム 
    Protected Sub valProgramID3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valProgramID3.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            If txtProgramID.Enabled Then
                CType(source, CustomValidator).ErrorMessage = "プログラムマスタに登録されていません"
                If Not txtProgramID.Text.Trim.PadRight(8, " ").Substring(0, 3).Equals("&SP") Then
                    sQuery = "SELECT PG_NM FROM PROGRAM_MST WHERE PROGRAM_ID = :K01"
                    _oDatabase.CreateParam("K01", txtProgramID.Text.Trim())
                    oReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        lblProgramName.Text = GetString(oReader, 0)
                        args.IsValid = True
                    Else
                        lblProgramName.Text = ""
                        args.IsValid = False
                    End If
                    oReader.Close()
                    If Not args.IsValid Then Return
                End If
                CType(source, CustomValidator).ErrorMessage = "既に登録されています"
                sQuery = "SELECT MENU_ID FROM MENU_MST WHERE EMPOWER_LV = :K01 AND MENU_LEBEL = '2' AND MENU_ID = :K02 AND PROGRAM_ID = :K03"
                _oDatabase.CreateParam("K01", ViewState("level"))
                _oDatabase.CreateParam("K02", txtMenuID.Value.Trim())
                _oDatabase.CreateParam("K03", txtProgramID.Text.Trim())
                oReader = _oDatabase.CreateReaderParam(sQuery)
                args.IsValid = Not oReader.Read()
                oReader.Close()
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub


#End Region

#Region " ファイル関連 "

    '登録、訂正 
    Private Function FileUpdate1() As Boolean
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.BeginTrans()
            'プログラムマスタ 
            Dim sNumber As String
            Dim sName As String = ""
            'If txtMenuID.Value.Trim.Equals("") Then 
            If ViewState("menuid").ToString.Equals("") Then
                'ID取得 
                sQuery = "SELECT NVL(MAX(TO_NUMBER(PROGRAM_ID)),0) + 1 FROM PROGRAM_MST WHERE MENU_LEBEL = '1'"
                oReader = _oDatabase.CreateReader(sQuery)
                oReader.Read()
                sNumber = GetInt32(oReader, 0).ToString("00000000")
                oReader.Close()
                '追加 
                sQuery = "INSERT INTO PROGRAM_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11)"
                _oDatabase.CreateParam("F01", "1")                                  'MENU_LEBEL 
                _oDatabase.CreateParam("F02", sNumber)                              'PROGRAM_ID 
                _oDatabase.CreateParam("F03", txtMenuName.Text.Trim())              'PG_NM 
                _oDatabase.CreateParam("F04", "")                                   'FILE_PATH 
                _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)      'CRT_DT 
                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)      'CRT_TIME 
                _oDatabase.CreateParam("F07", Session("UserID"))                    'CRT_USR 
                _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                _oDatabase.CreateParam("F10", Session("UserID"))                    'UPD_USR 
                _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
                _oDatabase.ExecuteNonQueryParam(sQuery)
            Else
                'sNumber = txtMenuID.Value 
                sNumber = ViewState("menuid")
                '名称取得 
                sQuery = "SELECT PG_NM FROM PROGRAM_MST WHERE MENU_LEBEL = '1' AND PROGRAM_ID = :K01"
                '_oDatabase.CreateParam("K01", txtMenuID.Value.Trim()) 
                _oDatabase.CreateParam("K01", sNumber)
                oReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then sName = GetString(oReader, 0)
                oReader.Close()
                '更新 
                If sName.Trim() <> txtMenuName.Text.Trim() Then
                    sQuery = "UPDATE PROGRAM_MST SET "
                    sQuery += "PG_NM = :F01,"
                    sQuery += "UPD_DT = :F02,"
                    sQuery += "UPD_TIME = :F03,"
                    sQuery += "UPD_USR = :F04,"
                    sQuery += "UPD_PROGRAM_ID = :F05 "
                    sQuery += "WHERE MENU_LEBEL = '1' AND PROGRAM_ID = :K01"
                    _oDatabase.CreateParam("F01", txtMenuName.Text.Trim())              'PG_NM 
                    _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                    _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                    _oDatabase.CreateParam("F04", Session("UserID"))                    'UPD_USR 
                    _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
                    '_oDatabase.CreateParam("K01", txtMenuID.Value.Trim())               'プログラムID 
                    _oDatabase.CreateParam("K01", sNumber)                              'PROGRAM_ID 
                    _oDatabase.ExecuteNonQueryParam(sQuery)
                End If
            End If
            'メニューマスタ 
            'If txtMenuName.Enabled Then 
            If ViewState("menuid").ToString.Equals("") Then
                '追加 
                sQuery = "INSERT INTO MENU_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11,:F12)"
                _oDatabase.CreateParam("F01", ViewState("level"))                   'MENU_LEBEL 
                _oDatabase.CreateParam("F02", "1")                                  'MENU_LEBEL 
                _oDatabase.CreateParam("F03", sNumber)                              'MENU_ID 
                _oDatabase.CreateParam("F04", "********")                           'PROGRAM_ID 
                If txtMenuNumber.Text.Trim.Equals("") Then
                    _oDatabase.CreateParam("F05", 0)                                'DSP_TURN 
                Else
                    _oDatabase.CreateParam("F05", txtMenuNumber.Text.Trim())        'DSP_TURN 
                End If
                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemDate)      'CRT_DT 
                _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemTime)      'CRT_TIME 
                _oDatabase.CreateParam("F08", Session("UserID"))                    'CRT_USR 
                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                _oDatabase.CreateParam("F11", Session("UserID"))                    'UPD_USR 
                _oDatabase.CreateParam("F12", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
            Else
                '更新 
                sQuery = "UPDATE MENU_MST SET "
                sQuery += "DSP_TURN = :F01,"
                sQuery += "UPD_DT = :F02,"
                sQuery += "UPD_TIME = :F03,"
                sQuery += "UPD_USR = :F04,"
                sQuery += "UPD_PROGRAM_ID = :F05 "
                sQuery += "WHERE EMPOWER_LV = :K01 AND MENU_LEBEL = '1' AND MENU_ID = :K02"
                If txtMenuNumber.Text.Trim.Equals("") Then
                    _oDatabase.CreateParam("F01", 0)                                'DSP_TURN 
                Else
                    _oDatabase.CreateParam("F01", txtMenuNumber.Text.Trim())        'DSP_TURN 
                End If
                _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                _oDatabase.CreateParam("F04", Session("UserID"))                    'UPD_USR 
                _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
                _oDatabase.CreateParam("K01", ViewState("level"))                   'EMPOWER_LV 
                '_oDatabase.CreateParam("K02", txtMenuID.Value.Trim())               'メニューID 
                _oDatabase.CreateParam("K02", sNumber)                              'MENU_ID 
            End If
            _oDatabase.ExecuteNonQueryParam(sQuery)
            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Function

    '削除 
    Private Function FileDelete1() As Boolean
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.BeginTrans()
            'メニューマスタ 
            sQuery = "DELETE FROM MENU_MST WHERE EMPOWER_LV = :K01 AND MENU_ID = :K02"
            _oDatabase.CreateParam("K01", ViewState("level"))
            _oDatabase.CreateParam("K02", txtMenuID.Value.Trim())
            _oDatabase.ExecuteNonQueryParam(sQuery)
            'プログラムマスタ 
            sQuery = "SELECT MENU_ID FROM MENU_MST WHERE MENU_ID = :K01"
            _oDatabase.CreateParam("K01", txtMenuID.Value.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If Not oReader.Read() Then
                sQuery = "DELETE FROM PROGRAM_MST WHERE MENU_LEBEL = '1' AND PROGRAM_ID = :K01"
                _oDatabase.CreateParam("K01", txtMenuID.Value.Trim())
                _oDatabase.ExecuteNonQueryParam(sQuery)
            End If
            oReader.Close()
            '権限マスタ
            sQuery = "DELETE FROM RIGHTS_MST WHERE EMPOWER_LV = :K01 AND MENU_ID = :K02"
            _oDatabase.CreateParam("K01", ViewState("level"))
            _oDatabase.CreateParam("K02", txtMenuID.Value.Trim())
            _oDatabase.ExecuteNonQueryParam(sQuery)
            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Function

    '登録、訂正 
    Private Function FileUpdate2() As Boolean
        Dim sQuery As String = ""
        Try
            _oDatabase.BeginTrans()
            'メニューマスタ 
            If txtProgramID.Enabled Then
                '追加 
                sQuery = "INSERT INTO MENU_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11,:F12)"
                _oDatabase.CreateParam("F01", ViewState("level"))                   'MENU_LEBEL 
                _oDatabase.CreateParam("F02", "2")                                  'MENU_LEBEL 
                _oDatabase.CreateParam("F03", txtMenuID.Value.Trim())               'MENU_ID 
                _oDatabase.CreateParam("F04", txtProgramID.Text.Trim())             'PROGRAM_ID 
                If txtProgramNumber.Text.Trim.Equals("") Then
                    _oDatabase.CreateParam("F05", 0)                                'DSP_TURN 
                Else
                    _oDatabase.CreateParam("F05", txtProgramNumber.Text.Trim())     'DSP_TURN 
                End If
                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemDate)      'CRT_DT 
                _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemTime)      'CRT_TIME 
                _oDatabase.CreateParam("F08", Session("UserID"))                    'CRT_USR 
                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                _oDatabase.CreateParam("F11", Session("UserID"))                    'UPD_USR 
                _oDatabase.CreateParam("F12", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
            Else
                '更新 
                sQuery = "UPDATE MENU_MST SET "
                sQuery += "PROGRAM_ID = :F01,"
                sQuery += "DSP_TURN = :F02,"
                sQuery += "UPD_DT = :F03,"
                sQuery += "UPD_TIME = :F04,"
                sQuery += "UPD_USR = :F05,"
                sQuery += "UPD_PROGRAM_ID = :F06 "
                sQuery += "WHERE EMPOWER_LV = :K01 AND MENU_LEBEL = '2' AND MENU_ID = :K02 AND PROGRAM_ID = :K03"
                _oDatabase.CreateParam("F01", txtProgramID.Text.Trim())             'PROGRAM_ID 
                If txtProgramNumber.Text.Trim.Equals("") Then
                    _oDatabase.CreateParam("F02", 0)                                'DSP_TURN 
                Else
                    _oDatabase.CreateParam("F02", txtProgramNumber.Text.Trim())     'DSP_TURN 
                End If
                _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                _oDatabase.CreateParam("F05", Session("UserID"))                    'UPD_USR 
                _oDatabase.CreateParam("F06", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
                _oDatabase.CreateParam("K01", ViewState("level"))                   'EMPOWER_LV 
                _oDatabase.CreateParam("K02", txtMenuID.Value.Trim())               'MENU_ID 
                _oDatabase.CreateParam("K03", txtProgramID.Text.Trim())             'PROGRAM_ID 
            End If
            _oDatabase.ExecuteNonQueryParam(sQuery)
            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Function

    '削除 
    Private Function FileDelete2() As Boolean
        Dim sQuery As String = ""
        Try
            _oDatabase.BeginTrans()
            sQuery = "DELETE FROM MENU_MST WHERE EMPOWER_LV = :K01 AND MENU_LEBEL = '2' AND MENU_ID = :K02 AND PROGRAM_ID = :K03"
            _oDatabase.CreateParam("K01", ViewState("level"))
            _oDatabase.CreateParam("K02", txtMenuID.Value.Trim())
            _oDatabase.CreateParam("K03", txtProgramID.Text.Trim())
            _oDatabase.ExecuteNonQueryParam(sQuery)
            '権限マスタ
            sQuery = "DELETE FROM RIGHTS_MST WHERE EMPOWER_LV = :K01 AND MENU_ID = :K02 AND PROGRAM_ID = :K03"
            _oDatabase.CreateParam("K01", ViewState("level"))
            _oDatabase.CreateParam("K02", txtMenuID.Value.Trim())
            _oDatabase.CreateParam("K03", txtProgramID.Text.Trim())
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

    Private Sub MenuNameEnabled(ByVal nBool As Boolean)
        'txtMenuName.Enabled = nBool 
        txtMenuName.Enabled = True
        lnkMenuName.Visible = nBool
        lblMenuName.Visible = Not nBool
    End Sub

    Private Sub ProgramIDEnabled(ByVal nBool As Boolean)
        txtProgramID.Enabled = nBool
        lnkProgramID.Visible = nBool
        lblProgramID.Visible = Not nBool
    End Sub

    'コンボボックス設定 
    Private Sub ComboSet(ByVal sKey As String, ByRef oCombo As Web.UI.WebControls.DropDownList)
        Try
            Dim sQuery As String = "SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = '" + sKey + "'"
            Dim oReader As OracleDataReader = _oDatabase.CreateReader(sQuery)
            oCombo.Items.Clear()
            While oReader.Read()
                oCombo.Items.Add(New ListItem(oReader.GetString(0) + ":" + oReader.GetString(1), oReader.GetString(0)))
            End While
            oReader.Close()
        Catch ex As Exception
            Throw
        End Try
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

End Class
