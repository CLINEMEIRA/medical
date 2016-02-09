Imports System.Data 
Imports System.Data.OracleClient 
Imports System.Text.RegularExpressions
Imports System.Drawing

Partial Class master_mdmas180
    Inherits System.Web.UI.Page
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS180"
    Private Const PROGRAM_TITLE As String = "SHOPコード一括変更"

    Private _oDatabase As MedicalLib.DataAccess

    'CallBack 
    Public _sCallBackScript As String = ""
    Private _sCode As String = ""

    Private Const MAX_ROW As Integer = 20

#Region " ページ "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess

            'CallBack 
            _sCallBackScript = Page.ClientScript.GetCallbackEventReference(Me, "command", "getInfoCallBack", "context", "getInfoCallBackError", False)

            CreateList()

            If Not Page.IsPostBack Then
                DisplayInit()
                'btnCheck.Attributes.Add("onclick", MedicalLib.Script.Custome(""))
                btnRun.Attributes.Add("onclick", MedicalLib.Script.Custome("実行しますか") &
                                                 "document.getElementById('imgProgress').style.display = '';")
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

#End Region

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        Dim sReturnValue As String = ""
        Dim sValues() As String = _sCode.Split(Chr(9))
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim i As Integer = 0

        Try
            Select Case sValues(0)

                Case 1

                    sQuery = ""
                    sQuery += "SELECT ORGANIZE_CD, SHOP_NM"
                    sQuery += "  FROM SHOP_MST"
                    sQuery += " WHERE SHOP = :K01"

                    _oDatabase.CreateParam("K01", sValues(2).Trim())
                    oReader = _oDatabase.CreateReaderParam(sQuery)

                    If oReader.Read() Then
                        sReturnValue = "lblSosikiCD" + sValues(1) + ControlChars.Tab + _
                                       GetString(oReader, 0) + ControlChars.Tab + _
                                       "lblShopName" + sValues(1) + ControlChars.Tab + _
                                       GetString(oReader, 1) + ControlChars.Tab
                    Else
                        sReturnValue = "lblSosikiCD" + sValues(1) + ControlChars.Tab + _
                                       "" + ControlChars.Tab + _
                                       "lblShopName" + sValues(1) + ControlChars.Tab + _
                                       "" + ControlChars.Tab
                    End If

                Case 2

                    sQuery = ""
                    sQuery += "SELECT ORGANIZE_CD, SHOP_NM"
                    sQuery += "  FROM SHOP_MST"
                    sQuery += " WHERE SHOP = :K01"

                    _oDatabase.CreateParam("K01", sValues(2).Trim())
                    oReader = _oDatabase.CreateReaderParam(sQuery)

                    If oReader.Read Then

                        sReturnValue = "txtSosikiCD" + sValues(1) + ControlChars.Tab + _
                                       GetString(oReader, 0) + ControlChars.Tab + _
                                       "txtShopName" + sValues(1) + ControlChars.Tab + _
                                       GetString(oReader, 1) + ControlChars.Tab + _
                                       "lblSin" & sValues(1) + ControlChars.Tab + _
                                       "新SHOPがSHOPマスタに存在します"
                    Else
                        sReturnValue = "txtSosikiCD" + sValues(1) + ControlChars.Tab + _
                                       "" + ControlChars.Tab + _
                                       "txtShopName" + sValues(1) + ControlChars.Tab + _
                                       "" + ControlChars.Tab + _
                                       "lblSin" & sValues(1) + ControlChars.Tab + _
                                       ""
                    End If

            End Select

        Catch ex As Exception
        Finally
            If oReader IsNot Nothing Then oReader.Close()
        End Try

        Return sReturnValue
    End Function

    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        _sCode = eventArgument
    End Sub

#End Region

#Region " ボタン "

    Protected Sub btnCheck_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCheck.Click

        If CheckControl() = True Then
            btnRun.Visible = True
            lblMess.Text = ""
        Else
            btnRun.Visible = False
            If lblMess.Text <> "入力がありません" Then
                lblMess.Text = "入力エラーがありました"
            End If
        End If

    End Sub

    Protected Sub btnRun_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnRun.Click

        If CheckControl() = True Then
        Else
            btnRun.Visible = False
            If lblMess.Text <> "入力がありません" Then
                lblMess.Text = "入力エラーがありました"
            End If
            Exit Sub
        End If

        Try
            'テーブル更新
            UpdateTable()

            '画面初期化
            DisplayInit()

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        imgProgress.Attributes("style") = "display:none;"

    End Sub

#End Region

#Region " チェック "

    'チェック制御
    Private Function CheckControl() As Boolean

        lblMess.Text = ""
        Try
            'コールバック定着処理
            SetCallBack()

            '入力チェック
            If CheckInput() = False Then
                Return False
            End If

            If (CheckKyuShop() And CheckSinShop()) = False Then
                Return False
            End If

            Return True

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

    End Function

    '入力チェック
    Private Function CheckInput() As Boolean

        Dim bReturn As Boolean = True
        Dim IsInput As Boolean = False

        '変更対象年月チェック
        Page.Validate("Nengetu")
        If Page.IsValid = True Then

            For i As Integer = 1 To MAX_ROW

                If txtKyuShop(i).Text.Trim <> "" Then

                    IsInput = True

                    '旧SHOP 入力チェック
                    If CheckShopInput("Kyu", txtKyuShop(i).Text.Trim, valKyu(i)) = False Then
                        bReturn = False
                    End If
                    '新SHOP 入力チェック
                    If CheckShopInput("Sin", txtSinShop(i).Text.Trim, valSin(i)) = False Then
                        bReturn = False
                    Else
                        '新組織コード 入力チェック
                        If Not Regex.IsMatch(txtSosikiCD(i).Text.Trim, "^[0-9]*$") Then

                            valSin(i).ErrorMessage = "新組織コードは半角数字で入力して下さい<br />"
                            valSin(i).IsValid = False
                            bReturn = False
                        Else
                            '新組織コード 入力チェック
                            If (txtSosikiCD(i).Text.Trim <> "") And (txtSosikiCD(i).Text.Trim.Length <> 5) Then

                                valSin(i).ErrorMessage = "新組織コードは5桁で入力して下さい<br />"
                                valSin(i).IsValid = False
                                bReturn = False
                            Else
                                '新SHOP名称 必須チェック
                                If txtShopName(i).Text.Trim = "" Then
                                    valSin(i).ErrorMessage = "新SHOP名称は入力必須項目です<br />"
                                    valSin(i).IsValid = False
                                    bReturn = False
                                Else
                                    '新SHOP名称 入力チェック
                                    If System.Text.Encoding.GetEncoding(932).GetByteCount(txtShopName(i).Text.Trim) > 30 Then
                                        valSin(i).ErrorMessage = "新SHOP名称は30バイト以内で入力して下さい<br />"
                                        valSin(i).IsValid = False
                                        bReturn = False
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        Else
            Return False
        End If

        If IsInput = False Then
            lblMess.Text = "入力がありません"
            Return False
        End If

        Return bReturn

    End Function

    Private Function CheckShopInput(ByVal sMode As String, ByVal sShop As String, ByVal oVal As CustomValidator) As Boolean

        If sMode = "Sin" Then
            If sShop = "" Then
                oVal.ErrorMessage = "新SHOPは入力必須項目です<br />"
                oVal.IsValid = False
                Return False
            End If
        End If

        If Not Regex.IsMatch(sShop, "^[a-zA-Z0-9]*$") Then
            If sMode = "Sin" Then
                oVal.ErrorMessage = "新SHOPは半角英数で入力して下さい<br />"
            Else
                oVal.ErrorMessage = "半角英数で入力して下さい<br />"
            End If
            oVal.IsValid = False
            Return False
        End If

        Return True

    End Function

    '入力チェック 旧SHOP
    Private Function CheckKyuShop() As Boolean

        Dim bReturnValue As Boolean = True
        Dim sShopText As String = ""

        For i As Integer = 1 To MAX_ROW

            sShopText = txtKyuShop(i).Text.Trim

            If sShopText <> "" Or valKyu(i).IsValid = False Then

                '重複チェック
                If i <> MAX_ROW Then
                    For j As Integer = i + 1 To MAX_ROW
                        If sShopText = txtKyuShop(j).Text.Trim Then
                            valKyu(i).ErrorMessage = "SHOPが重複してます"
                            valKyu(i).IsValid = False
                            valKyu(j).ErrorMessage = "SHOPが重複してます"
                            valKyu(j).IsValid = False
                            bReturnValue = False
                        End If
                    Next
                End If

                'マスタ存在チェック
                If valKyu(i).IsValid = True And lblShopName(i).Text.Trim = "" Then
                    valKyu(i).ErrorMessage = "SHOPマスタに存在しません"
                    valKyu(i).IsValid = False
                    bReturnValue = False
                End If
            End If
        Next

        Return bReturnValue

    End Function

    '入力チェック 新SHOP
    Private Function CheckSinShop() As Boolean

        Dim bReturnValue As Boolean = True
        Dim sKyuShopText As String = ""
        Dim sSinShopText As String = ""

        For i As Integer = 1 To MAX_ROW

            sKyuShopText = txtKyuShop(i).Text.Trim
            sSinShopText = txtSinShop(i).Text.Trim

            If sKyuShopText <> "" Or valSin(i).IsValid = False Then

                ''新SHOP マスタ非存在時 名称必須チェック
                'If lblSin(i).Text.Trim = "" Then
                '    If txtShopName(i).Text.Trim = "" Then
                '        valSin(i).ErrorMessage = "新SHOP名称は入力必須項目です<br />"
                '        valSin(i).IsValid = False
                '        bReturnValue = False
                '    End If
                'End If

                'マスタ存在チェック
                If i <> MAX_ROW Then
                    For j As Integer = i + 1 To MAX_ROW
                        If sSinShopText = txtKyuShop(j).Text.Trim Then
                            valSin(i).ErrorMessage = "新SHOPに変更対象となるSHOPを選択できません<br />"
                            valSin(i).IsValid = False
                            bReturnValue = False
                        End If
                    Next
                End If
            End If
        Next

        Return bReturnValue

    End Function

#End Region

#Region " 画面関連 "

    'リスト作成
    Private Sub CreateList()

        Dim oRow As HtmlTableRow = Nothing
        Dim oCell As HtmlTableCell = Nothing
        Dim oText As TextBox = Nothing
        Dim oLabel As Label = Nothing
        Dim oImageButton As ImageButton = Nothing
        Dim oValid As CustomValidator = Nothing

        Dim bEven As Boolean = False

        For i As Integer = 1 To MAX_ROW

            oRow = New HtmlTableRow
            oRow.Height = 20
            oRow.Align = "Left"
            If bEven = True Then
                oRow.BgColor = "#d9ffcc"
            Else
                oRow.BgColor = "#FFFFFF"
            End If

            '旧SHOP
            oCell = New HtmlTableCell
            oCell.Align = "center"
            oCell.Width = 50
            '<asp:TextBox ID="txtKyuShop1" MaxLength="2" Width="20px" Text='XX' runat="server" BackColor="#FFFFC0" onChange="getInfo1(this, '1');" />
            oText = New TextBox
            oText.ID = "txtKyuShop" & i.ToString
            oText.MaxLength = 2
            oText.Width = 20
            oText.BackColor = Color.FromArgb(255, 255, 192) '黄色 
            oText.Attributes("onChange") = "getInfo1(this, '" & i.ToString & "');"
            oCell.Controls.Add(oText)

            '<asp:ImageButton ID="btnKyuShop1" runat="server" ImageUrl="~/image/i_list.gif" ImageAlign="Middle" onclientclick="listMDSRC050(document.getElementById('txtKyuShop1'),document.getElementById('lblShopName1'),document.getElementById('lblSosikiCD1'));document.getElementById('txtKyuShop1').focus();return false;" /> 
            oImageButton = New ImageButton
            oImageButton.ID = "btnKyuShop" & i.ToString
            oImageButton.ImageUrl = "~/image/i_list.gif"
            oImageButton.ImageAlign = ImageAlign.Middle
            oImageButton.Attributes("onclick") = "listMDSRC050(document.getElementById('txtKyuShop" & i.ToString & "'),document.getElementById('lblShopName" & i.ToString & "'),document.getElementById('lblSosikiCD" & i.ToString & "'));document.getElementById('txtKyuShop" & i.ToString & "').focus();return false;"
            oCell.Controls.Add(oImageButton)

            oRow.Cells.Add(oCell)

            '旧組織コード
            oCell = New HtmlTableCell
            oCell.Width = 100
            '<asp:Label ID="lblSosikiCD1" runat=server></asp:Label>
            oLabel = New Label
            oLabel.ID = "lblSosikiCD" & i.ToString
            oCell.Controls.Add(oLabel)

            oRow.Cells.Add(oCell)

            '旧SHOP名称
            oCell = New HtmlTableCell
            oCell.Width = 280
            '<asp:Label ID="lblShopName1" runat=server></asp:Label>
            oLabel = New Label
            oLabel.ID = "lblShopName" & i.ToString
            oCell.Controls.Add(oLabel)

            oRow.Cells.Add(oCell)

            'スペース
            oCell = New HtmlTableCell
            oCell.Width = 0
            oCell.BgColor = "#f7f7f7"

            oRow.Cells.Add(oCell)

            '新SHOP
            oCell = New HtmlTableCell
            oCell.Align = "center"
            oCell.Width = 50
            '<asp:TextBox ID="txtSinShop1" MaxLength="2" Width="20px" Text='XX' runat="server" BackColor="#FFFFC0" onChange="getInfo2(this, '1');"/> 
            oText = New TextBox
            oText.ID = "txtSinShop" & i.ToString
            oText.MaxLength = 2
            oText.Width = 20
            oText.BackColor = Color.FromArgb(255, 255, 192) '黄色 
            oText.Attributes("onChange") = "getInfo2(this, '" & i.ToString & "');"
            oCell.Controls.Add(oText)

            '<asp:ImageButton ID="btnSinShop1" runat="server" ImageUrl="~/image/i_list.gif" ImageAlign="Middle" onclientclick="listMDSRC050(document.getElementById('txtSinShop1'),document.getElementById('txtShopName1'),document.getElementById('txtSosikiCD1'));document.getElementById('txtSinShop1').focus();return false;" /> 
            oImageButton = New ImageButton
            oImageButton.ID = "btnSinShop" & i.ToString
            oImageButton.ImageUrl = "~/image/i_list.gif"
            oImageButton.ImageAlign = ImageAlign.Middle
            oImageButton.Attributes("onclick") = "listMDSRC050(document.getElementById('txtSinShop" & i.ToString & "'),document.getElementById('txtShopName" & i.ToString & "'),document.getElementById('txtSosikiCD" & i.ToString & "'));document.getElementById('txtSinShop" & i.ToString & "').focus();return false;"
            oCell.Controls.Add(oImageButton)

            oRow.Cells.Add(oCell)

            '新組織コード
            oCell = New HtmlTableCell
            oCell.Width = 100
            '<asp:TextBox ID="txtSosikiCD1" MaxLength="5" Width="50px" Text='XXXXX' runat="server" /> 
            oText = New TextBox
            oText.ID = "txtSosikiCD" & i.ToString
            oText.MaxLength = 5
            oText.Width = 50
            oCell.Controls.Add(oText)

            oRow.Cells.Add(oCell)

            '新SHOP名称
            oCell = New HtmlTableCell
            oCell.Width = 280
            '<asp:TextBox ID="txtShopName1" cssClass="full" MaxLength="30" Width="250px" Text='XXXXX' BackColor="#FFFFC0"  runat="server" /> 
            oText = New TextBox
            oText.ID = "txtShopName" & i.ToString
            oText.MaxLength = 30
            oText.Width = 250
            oText.BackColor = Color.FromArgb(255, 255, 192) '黄色 
            oText.CssClass = "full"
            oCell.Controls.Add(oText)

            oRow.Cells.Add(oCell)

            tblList.Rows.Add(oRow)
            oRow.Dispose()

            'コメント
            oRow = New HtmlTableRow
            oRow.Align = "Left"
            oCell = New HtmlTableCell
            oCell.ColSpan = 3
            '旧検証
            '<asp:CustomValidator ID="valKyu1" runat="server" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False"></asp:CustomValidator>
            oValid = New CustomValidator
            oValid.ID = "valKyu" + i.ToString
            oValid.Display = ValidatorDisplay.Dynamic
            oValid.ValidationGroup = "info"
            oValid.EnableClientScript = False
            oCell.Controls.Add(oValid)

            oRow.Cells.Add(oCell)

            'スペース
            oCell = New HtmlTableCell
            oCell.BgColor = "#f7f7f7"

            oRow.Cells.Add(oCell)

            oCell = New HtmlTableCell
            oCell.ColSpan = 3
            '新検証
            '<asp:CustomValidator ID="valSin1" runat="server" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False"></asp:CustomValidator>
            oValid = New CustomValidator
            oValid.ID = "valSin" + i.ToString
            oValid.Display = ValidatorDisplay.Dynamic
            oValid.ValidationGroup = "info"
            oValid.EnableClientScript = False
            oCell.Controls.Add(oValid)

            '新警告
            '<asp:Label ID="lblSin1" runat=server></asp:Label>
            oLabel = New Label
            oLabel.ID = "lblSin" & i.ToString
            oCell.Controls.Add(oLabel)

            oRow.Cells.Add(oCell)

            tblList.Rows.Add(oRow)

            bEven = Not bEven
        Next

    End Sub

    '初期化
    Private Sub DisplayInit()

        txtNengetu.Text = MedicalLib.Common.GetSystemDate.Substring(0, 6)

        For i As Integer = 1 To MAX_ROW
            txtKyuShop(i).Text = ""
            lblSosikiCD(i).Text = ""
            lblShopName(i).Text = ""
            txtSinShop(i).Text = ""
            txtSosikiCD(i).Text = ""
            txtShopName(i).Text = ""
            lblSin(i).Text = ""

            txtKyuShop(i).ReadOnly = False
            btnKyuShop(i).Enabled = True
            txtSinShop(i).ReadOnly = False
            btnSinShop(i).Enabled = True
            txtSosikiCD(i).ReadOnly = False
            txtShopName(i).ReadOnly = False
        Next

        btnRun.Visible = False

    End Sub

    'コールバック定着
    Private Sub SetCallBack()

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        sQuery = ""
        sQuery += "SELECT ORGANIZE_CD, SHOP_NM"
        sQuery += "  FROM SHOP_MST"
        sQuery += " WHERE SHOP = :K01"

        Try
            For i As Integer = 1 To MAX_ROW

                If txtKyuShop(i).Text <> "" Then
                    _oDatabase.CreateParam("K01", txtKyuShop(i).Text)
                    oReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read Then
                        lblSosikiCD(i).Text = GetString(oReader, 0)
                        lblShopName(i).Text = GetString(oReader, 1)
                    Else
                        lblSosikiCD(i).Text = ""
                        lblShopName(i).Text = ""
                    End If
                    oReader.Close()
                Else
                    lblSosikiCD(i).Text = ""
                    lblShopName(i).Text = ""
                End If

                If txtSinShop(i).Text <> "" Then
                    _oDatabase.CreateParam("K01", txtSinShop(i).Text)
                    oReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.HasRows Then
                        lblSin(i).Text = "新SHOPがSHOPマスタに存在します"
                    Else
                        lblSin(i).Text = ""
                    End If
                    oReader.Close()
                Else
                    lblSin(i).Text = ""
                End If

            Next
        Catch ex As Exception
            Throw
        Finally
            If oReader IsNot Nothing Then oReader.Close()
        End Try

    End Sub

#End Region

#Region " テーブル更新 "

    Private Sub UpdateTable()

        Dim sQuery As String = ""

        Dim sKyuShop As String = ""
        Dim sKyuSosikiCD As String = ""
        Dim sKyuShopName As String = ""
        Dim sSinShop As String = ""
        Dim sSinSosikiCD As String = ""
        Dim sSinShopName As String = ""

        Dim sMotoSosikiCD As String = ""
        Dim sMotoShopName As String = ""
        Dim bGPHasRows As Boolean = False
        Dim sItemName As String = ""

        Try
            _oDatabase.BeginTrans()

            For i As Integer = 1 To MAX_ROW

                If txtKyuShop(i).Text.Trim <> "" Then

                    sKyuShop = txtKyuShop(i).Text.Trim
                    sKyuSosikiCD = lblSosikiCD(i).Text.Trim
                    sKyuShopName = lblShopName(i).Text.Trim
                    sSinShop = txtSinShop(i).Text.Trim
                    sSinSosikiCD = txtSosikiCD(i).Text.Trim
                    sSinShopName = txtShopName(i).Text.Trim

                    If sKyuShop <> sSinShop Then

                        '/* 工程マスタ */
                        UpdateHistory("工程マスタ", sKyuShop, sSinShop)

                        sQuery = ""
                        sQuery += "UPDATE PROCESS_MST SET "
                        sQuery += "SHOP = :F01,"
                        sQuery += "UPD_DT = :F02, "
                        sQuery += "UPD_TIME = :F03, "
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE SHOP = :K01"

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", Session("UserID"))
                        _oDatabase.CreateParam("F05", PROGRAM_ID)
                        _oDatabase.CreateParam("K01", sKyuShop)
                        _oDatabase.ExecuteNonQueryParam(sQuery)

                        '/* 設備マスタ */
                        UpdateHistory("設備マスタ", sKyuShop, sSinShop)

                        sQuery = ""
                        sQuery += "UPDATE FACILITIES_MST SET "
                        sQuery += "SHOP = :F01,"
                        sQuery += "UPD_DT = :F02,"
                        sQuery += "UPD_TIME = :F03,"
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE SHOP = :K01 "

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", Session("UserID"))
                        _oDatabase.CreateParam("F05", PROGRAM_ID)
                        _oDatabase.CreateParam("K01", sKyuShop)
                        _oDatabase.ExecuteNonQueryParam(sQuery)

                        '/* 加工工程マスタ */
                        UpdateHistory("加工工程マスタ", sKyuShop, sSinShop)

                        sQuery = ""
                        sQuery += "UPDATE P_PROCESS_MST SET "
                        sQuery += "SHOP = :F01,"
                        sQuery += "UPD_DT = :F02,"
                        sQuery += "UPD_TIME = :F03,"
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE SHOP = :K01"

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", Session("UserID"))
                        _oDatabase.CreateParam("F05", PROGRAM_ID)
                        _oDatabase.CreateParam("K01", sKyuShop)
                        _oDatabase.ExecuteNonQueryParam(sQuery)

                        '/* 加工工程SHOPマスタ 20120412追記*/
                        UpdateHistory("加工工程SHOPマス", sKyuShop, sSinShop)

                        sQuery = ""
                        sQuery += "UPDATE P_PROCESS_SHOP_MST SET "
                        sQuery += "SHOP = :F01,"
                        sQuery += "UPD_DT = :F02,"
                        sQuery += "UPD_TIME = :F03,"
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE SHOP = :K01"

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", Session("UserID"))
                        _oDatabase.CreateParam("F05", PROGRAM_ID)
                        _oDatabase.CreateParam("K01", sKyuShop)
                        _oDatabase.ExecuteNonQueryParam(sQuery)

                        '/* 作業者マスタ */
                        UpdateHistory("作業者マスタ", sKyuShop, sSinShop)

                        sQuery = ""
                        sQuery += "UPDATE WORKER_MST SET "
                        sQuery += "SHOP = :F01,"
                        sQuery += "UPD_DT = :F02,"
                        sQuery += "UPD_TIME = :F03,"
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE SHOP = :K01"

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", Session("UserID"))
                        _oDatabase.CreateParam("F05", PROGRAM_ID)
                        _oDatabase.CreateParam("K01", sKyuShop)
                        _oDatabase.ExecuteNonQueryParam(sQuery)

                        '/* 工程進捗管理テーブル */
                        sQuery = ""
                        sQuery += "UPDATE PROCESS_PROGRESS_TBL SET "
                        sQuery += "SHOP = :F01,"
                        sQuery += "UPD_DT = :F02, "
                        sQuery += "UPD_TIME = :F03, "
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE (INDICATE_NO, COMPANY_NO) IN (SELECT INDICATE_NO, COMPANY_NO FROM INDICATE_TBL WHERE INDICATE_DECIDE_FLG = 'K' AND (DEL_FLG is null OR DEL_FLG = ' ')) "
                        sQuery += "AND (RESULTS_DT = '00000000' OR RESULTS_DT >= :K02) "
                        sQuery += "AND SHOP = :K01 "

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", Session("UserID"))
                        _oDatabase.CreateParam("F05", PROGRAM_ID)
                        _oDatabase.CreateParam("K01", sKyuShop)
                        _oDatabase.CreateParam("K02", txtNengetu.Text.Trim + "01")
                        _oDatabase.ExecuteNonQueryParam(sQuery)

                        '/* 主材料引当テーブル */
                        sQuery = ""
                        sQuery += "UPDATE MATL_MORTGAGE_TBL SET "
                        sQuery += "SHIP = :F01,"
                        sQuery += "UPD_DT = :F02, "
                        sQuery += "UPD_TIME = :F03, "
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE (INDICATE_NO, COMPANY_NO) IN (SELECT INDICATE_NO, COMPANY_NO FROM INDICATE_TBL WHERE INDICATE_DECIDE_FLG = 'K' AND (DEL_FLG is null OR DEL_FLG = ' ')) "
                        sQuery += "AND (SHIP_DT = '00000000' OR SHIP_DT >= :K02) "
                        sQuery += "AND SHIP = :K01"

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", Session("UserID"))
                        _oDatabase.CreateParam("F05", PROGRAM_ID)
                        _oDatabase.CreateParam("K01", sKyuShop)
                        _oDatabase.CreateParam("K02", txtNengetu.Text.Trim + "01")
                        _oDatabase.ExecuteNonQueryParam(sQuery)

                        '/* 主材料出庫テーブル */
                        sQuery = ""
                        sQuery += "UPDATE MATL_SHIP_TBL SET "
                        sQuery += "SHIP = :F01,"
                        sQuery += "UPD_DT = :F02, "
                        sQuery += "UPD_TIME = :F03, "
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE (INDICATE_NO, COMPANY_NO) IN (SELECT INDICATE_NO, COMPANY_NO FROM INDICATE_TBL WHERE INDICATE_DECIDE_FLG = 'K' AND (DEL_FLG is null OR DEL_FLG = ' ')) "
                        sQuery += "AND (SHIP_DT = '00000000' OR SHIP_DT >= :K02) "
                        sQuery += "AND SHIP = :K01"

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", Session("UserID"))
                        _oDatabase.CreateParam("F05", PROGRAM_ID)
                        _oDatabase.CreateParam("K01", sKyuShop)
                        _oDatabase.CreateParam("K02", txtNengetu.Text.Trim + "01")
                        _oDatabase.ExecuteNonQueryParam(sQuery)

                    End If

                    '/* SHOPマスタ */
                    sQuery = ""
                    If lblSin(i).Text.Trim() = "" Then

                        InsertMH("SHOPマスタ", sSinShop, "追加", "", "")

                        sQuery += "INSERT INTO SHOP_MST VALUES"
                        sQuery += "( :F01"        'SHOP
                        sQuery += ", :F02"        'SHOP名称
                        sQuery += ", :F03"        '組織コード
                        sQuery += ", :F04"        '登録日付
                        sQuery += ", :F05"        '登録時刻
                        sQuery += ", :F06"        '登録ユーザID
                        sQuery += ", :F07"        '更新日付
                        sQuery += ", :F08"        '更新時刻
                        sQuery += ", :F09"        '更新ユーザID
                        sQuery += ", :F10"        '更新プログラムID
                        sQuery += ")"

                        _oDatabase.CreateParam("F01", sSinShop)
                        _oDatabase.CreateParam("F02", sSinShopName)
                        _oDatabase.CreateParam("F03", sSinSosikiCD)
                        _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F06", Session("UserID"))
                        _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F09", Session("UserID"))
                        _oDatabase.CreateParam("F10", PROGRAM_ID)

                        _oDatabase.ExecuteNonQueryParam(sQuery)
                    Else

                        GetShopMst(sSinShop, sMotoSosikiCD, sMotoShopName)

                        If (sMotoSosikiCD <> sSinSosikiCD) Or (sMotoShopName <> sSinShopName) Then

                            UpdateHistoryShopMst(sSinShop, sMotoSosikiCD, sSinSosikiCD, sMotoShopName, sSinShopName)

                            sQuery += "UPDATE SHOP_MST SET "
                            If (sMotoShopName <> sSinShopName) Then
                                sQuery += "SHOP_NM = :F01,"
                                _oDatabase.CreateParam("F01", sSinShopName)
                            End If
                            If (sMotoSosikiCD <> sSinSosikiCD) Then
                                sQuery += "ORGANIZE_CD = :F02,"
                                _oDatabase.CreateParam("F02", sSinSosikiCD)
                            End If
                            sQuery += "UPD_DT = :F03,"
                            sQuery += "UPD_TIME = :F04,"
                            sQuery += "UPD_USR = :F05,"
                            sQuery += "UPD_PROGRAM_ID = :F06 "
                            sQuery += "WHERE SHOP = :K01"

                            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F05", Session("UserID"))
                            _oDatabase.CreateParam("F06", PROGRAM_ID)
                            _oDatabase.CreateParam("K01", sSinShop)

                            _oDatabase.ExecuteNonQueryParam(sQuery)
                        End If
                    End If

                    '/* 汎用マスタ 組織コード */
                    sItemName = ""
                    If sSinSosikiCD <> "" Then

                        sQuery = ""
                        GetItemNM(sSinSosikiCD, bGPHasRows, sItemName)

                        If Not bGPHasRows Then

                            InsertMH("汎用マスタ", "MS019:" & sSinSosikiCD, "追加", "", "")

                            sQuery += "INSERT INTO GENERAL_PURPOSE_TBL VALUES "
                            sQuery += "('MS019'"               '情報区分
                            sQuery += ", :F01"                 '識別コード
                            sQuery += ", '組織コード'"         '情報区分名
                            sQuery += ", :F02"                 '項目名
                            sQuery += ", :F03"                 '項目名カナ
                            sQuery += ", :F04"                 '登録日付
                            sQuery += ", :F05"                 '登録時刻
                            sQuery += ", :F06"                 '登録ユーザID
                            sQuery += ", :F07"                 '更新日付
                            sQuery += ", :F08"                 '更新時刻
                            sQuery += ", :F09"                 '更新ユーザID
                            sQuery += ", :F10"                 '更新プログラムID
                            sQuery += ")"

                            _oDatabase.CreateParam("F01", sSinSosikiCD)
                            _oDatabase.CreateParam("F02", sSinShopName)
                            _oDatabase.CreateParam("F03", "")
                            _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F06", Session("UserID"))
                            _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F09", Session("UserID"))
                            _oDatabase.CreateParam("F10", PROGRAM_ID)

                            _oDatabase.ExecuteNonQueryParam(sQuery)
                        Else

                            If sItemName <> sSinShopName Then

                                UpdateHistoryGPMst(sSinSosikiCD, sSinShopName)

                                sQuery += "UPDATE GENERAL_PURPOSE_TBL SET "
                                sQuery += "ITEM_NM = :F01,"
                                sQuery += "ITEM_KN = :F02,"
                                sQuery += "UPD_DT = :F03,"
                                sQuery += "UPD_TIME = :F04,"
                                sQuery += "UPD_USR = :F05,"
                                sQuery += "UPD_PROGRAM_ID = :F06 "
                                sQuery += "WHERE INFO_KB = 'MS019'"
                                sQuery += "  AND TELL_CD = :K01"

                                _oDatabase.CreateParam("F01", sSinShopName)
                                _oDatabase.CreateParam("F02", "")
                                _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)
                                _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)
                                _oDatabase.CreateParam("F05", Session("UserID"))
                                _oDatabase.CreateParam("F06", PROGRAM_ID)
                                _oDatabase.CreateParam("K01", sSinSosikiCD)

                                _oDatabase.ExecuteNonQueryParam(sQuery)
                            End If
                        End If
                    End If
                End If
            Next

            _oDatabase.CommitTrans()

        Catch ex As Exception
            _oDatabase.Rollback()
            Throw
        End Try
    End Sub

    '汎用マスタに存在？
    Private Sub GetItemNM(ByVal sSosiki As String, _
                          ByRef bHasRows As Boolean, ByRef sItemName As String)

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Try
            sQuery = ""
            sQuery += "SELECT ITEM_NM, ITEM_KN"
            sQuery += "  FROM GENERAL_PURPOSE_TBL"
            sQuery += " WHERE INFO_KB = 'MS019'"
            sQuery += "   AND TELL_CD = :K01"

            _oDatabase.CreateParam("K01", sSosiki)
            oReader = _oDatabase.CreateReaderParam(sQuery)

            If oReader.Read Then
                bHasRows = True
                sItemName = GetString(oReader, 0)
            Else
                bHasRows = False
                sItemName = ""
            End If

        Catch ex As Exception
            Throw
        Finally
            If oReader IsNot Nothing Then oReader.Close()
        End Try

    End Sub

    'SHOPマスタ　元の値取得
    Private Sub GetShopMst(ByVal sShop As String, _
                           ByRef sMotoSosikiCD As String, ByRef sMotoShopName As String)

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Try
            sQuery = ""
            sQuery += "SELECT ORGANIZE_CD, SHOP_NM"
            sQuery += "  FROM SHOP_MST"
            sQuery += " WHERE SHOP = :K01"

            _oDatabase.CreateParam("K01", sShop)
            oReader = _oDatabase.CreateReaderParam(sQuery)

            If oReader.Read Then
                sMotoSosikiCD = GetString(oReader, 0)
                sMotoShopName = GetString(oReader, 1)
            Else
                sMotoSosikiCD = ""
                sMotoShopName = ""
            End If

        Catch ex As Exception
            Throw
        Finally
            If oReader IsNot Nothing Then oReader.Close()
        End Try

    End Sub

#End Region

#Region " マスタ更新履歴 "

    Private Sub UpdateHistory(ByVal sTableName As String, _
                              ByVal sKyuShop As String, ByVal sSinShop As String)
        '20120412修正
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Dim sKey As String = ""

        Try
            Select Case sTableName

                Case "工程マスタ"
                    sQuery += "SELECT PROCESS_CD"
                    sQuery += "  FROM PROCESS_MST"
                    sQuery += " WHERE SHOP = :K01"

                Case "設備マスタ"
                    sQuery += "SELECT FACILITIES_CD"
                    sQuery += "  FROM FACILITIES_MST"
                    sQuery += " WHERE SHOP = :K01"

                Case "加工工程マスタ"
                    sQuery += "SELECT CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB"
                    sQuery += "  FROM P_PROCESS_MST"
                    sQuery += " WHERE SHOP = :K01"

                Case "加工工程SHOPマス"
                    sQuery += "SELECT CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB"
                    sQuery += "  FROM P_PROCESS_SHOP_MST"
                    sQuery += " WHERE SHOP = :K01"

                Case "作業者マスタ"
                    sQuery += "SELECT WORKER_CD"
                    sQuery += "  FROM WORKER_MST"
                    sQuery += " WHERE SHOP = :K01"

            End Select

            _oDatabase.CreateParam("K01", sKyuShop)
            oReader = _oDatabase.CreateReaderParam(sQuery)

            While oReader.Read
                sKey = ""

                For i As Integer = 0 To oReader.FieldCount - 1
                    sKey += oReader.Item(i).ToString.Trim & ":"
                Next
                sKey = sKey.Substring(0, sKey.Length - 1)
                InsertMH(sTableName, sKey, "SHOP", sKyuShop, sSinShop)
            End While

        Catch ex As Exception
            Throw
        Finally
            If oReader IsNot Nothing Then oReader.Close()
        End Try

    End Sub

    Private Sub UpdateHistoryShopMst(ByVal sShop As String, _
                                     ByVal sMotoSosikiCD As String, ByVal sSinSosikiCD As String, _
                                     ByVal sMotoShopName As String, ByVal sSinShopName As String)

        Try
            If sSinSosikiCD <> "" Then
                If sMotoSosikiCD <> sSinSosikiCD Then
                    InsertMH("SHOPマスタ", sShop, "組織コード", sMotoSosikiCD, sSinSosikiCD)
                End If
            End If

            If sSinShopName <> "" Then
                If sMotoShopName <> sSinShopName Then
                    InsertMH("SHOPマスタ", sShop, "SHOP名称", sMotoShopName, sSinShopName)
                End If
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub UpdateHistoryGPMst(ByVal sSinSosikiCD As String, _
                                   ByVal sSinShopName As String)

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Try
            sQuery += "SELECT ITEM_NM, ITEM_KN"
            sQuery += "  FROM GENERAL_PURPOSE_TBL"
            sQuery += " WHERE INFO_KB = 'MS019'"
            sQuery += "   AND TELL_CD = :K01"

            _oDatabase.CreateParam("K01", sSinSosikiCD)
            oReader = _oDatabase.CreateReaderParam(sQuery)

            If oReader.Read Then
                InsertMH("汎用マスタ", "MS019:" & sSinSosikiCD, "項目名", GetString(oReader, 0), sSinShopName)
                InsertMH("汎用マスタ", "MS019:" & sSinSosikiCD, "項目名カナ", GetString(oReader, 1), "")
            End If

        Catch ex As Exception
            Throw
        Finally
            If oReader IsNot Nothing Then oReader.Close()
        End Try

    End Sub

    Private Sub InsertMH(ByVal sTableName As String, ByVal sKey As String, ByVal sItemName As String, ByVal sMae As String, ByVal sAto As String)

        Try
            Dim sQuery As String = ""

            sQuery = "INSERT INTO MASTER_HIS_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
                                                        ":F11,:F12,:F13,:F14)"
            _oDatabase.CreateParam("F01", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F03", sTableName)
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

        Catch ex As Exception
            Throw
        End Try
    End Sub

#End Region

#Region " その他 "

#Region " 引数indexに番号を受け取って、その番号が付いたコントロールを返す "

    Private Function txtKyuShop(ByVal index As Integer) As TextBox
        Return DirectCast(Page.Form.FindControl("txtKyuShop" & index.ToString), TextBox)
    End Function

    Private Function btnKyuShop(ByVal index As Integer) As ImageButton
        Return DirectCast(Page.Form.FindControl("btnKyuShop" & index.ToString), ImageButton)
    End Function

    Private Function lblSosikiCD(ByVal index As Integer) As Label
        Return DirectCast(Page.Form.FindControl("lblSosikiCD" & index.ToString), Label)
    End Function

    Private Function lblShopName(ByVal index As Integer) As Label
        Return DirectCast(Page.Form.FindControl("lblShopName" & index.ToString), Label)
    End Function

    Private Function valKyu(ByVal index As Integer) As CustomValidator
        Return DirectCast(Page.Form.FindControl("valKyu" & index.ToString), CustomValidator)
    End Function

    Private Function txtSinShop(ByVal index As Integer) As TextBox
        Return DirectCast(Page.Form.FindControl("txtSinShop" & index.ToString), TextBox)
    End Function

    Private Function btnSinShop(ByVal index As Integer) As ImageButton
        Return DirectCast(Page.Form.FindControl("btnSinShop" & index.ToString), ImageButton)
    End Function

    Private Function txtSosikiCD(ByVal index As Integer) As TextBox
        Return DirectCast(Page.Form.FindControl("txtSosikiCD" & index.ToString), TextBox)
    End Function

    Private Function txtShopName(ByVal index As Integer) As TextBox
        Return DirectCast(Page.Form.FindControl("txtShopName" & index.ToString), TextBox)
    End Function

    Private Function lblSin(ByVal index As Integer) As Label
        Return DirectCast(Page.Form.FindControl("lblSin" & index.ToString), Label)
    End Function

    Private Function valSin(ByVal index As Integer) As CustomValidator
        Return DirectCast(Page.Form.FindControl("valSin" & index.ToString), CustomValidator)
    End Function

#End Region

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

    Private Function GetDoubleAbs(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Double
        If oReader.IsDBNull(nIndex) Then Return 0.0
        Return Math.Abs(oReader.GetDouble(nIndex))
    End Function

#End Region

End Class
