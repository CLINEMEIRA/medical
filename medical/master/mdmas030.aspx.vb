Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing

Partial Class master_mdmas030
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS030"
    Private Const PROGRAM_TITLE As String = "実行権利マスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        If Not Page.IsPostBack Then
            ComboSet("MS001", cboLevel)
            DisplayInit()
            saveKey1.Value = -1
            Session("MDMAS030Key1") = -1
            btnInsert.Attributes.Add("onclick", MedicalLib.Script.Insert())
        Else
            If saveKey1.Value <> -1 Then
                Session("MDMAS030Key1") = saveKey1.Value
                DisplayMenu2()
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
        saveKey1.Value = -1
        Session("MDMAS030Key1") = -1
        DisplayMenu1()
    End Sub

    Protected Sub btnInsert_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnInsert.Click
        If Not FileUpdate() Then Exit Sub
        DisplayMenu2()
    End Sub

    Protected Sub btnBack_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBack.Click
        DisplayInit()
    End Sub

    'リンクボタン押下（隠し） 
    Protected Sub btnLink_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLink.Click
        DisplayMenu1()
        DisplayMenu2()
    End Sub

    'リンクボタン押下（隠し） 
    Protected Sub btnNext_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

#End Region

#Region " 画面関連 "

    '画面初期化 
    Private Sub DisplayInit()
        pnlMenu1.Visible = False
        pnlMenu2.Visible = False
        pnlFunc.Visible = False
        udpMenu1.Update()
        udpMenu2.Update()
        udpFunc.Update()
    End Sub

    'メニュー1表示 
    Private Sub DisplayMenu1()
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            tblMenu1.Rows.Clear()
            sQuery = "SELECT A.MENU_ID,B.PG_NM "
            sQuery += "FROM (SELECT EMPOWER_LV,MENU_ID,DSP_TURN FROM MENU_MST WHERE MENU_LEBEL = '1') A,PROGRAM_MST B "
            sQuery += "WHERE (A.MENU_ID = B.PROGRAM_ID(+)) AND A.EMPOWER_LV = :K01 "
            sQuery += "ORDER BY A.DSP_TURN"
            _oDatabase.CreateParam("K01", cboLevel.SelectedValue)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            While oReader.Read()
                Dim oRow As HtmlTableRow = New HtmlTableRow
                Dim oCell As HtmlTableCell = New HtmlTableCell
                oCell.Controls.Add(New LiteralControl("<font color='MidnightBlue'>" + GetString(oReader, 1) + "</font>"))
                oCell.Align = "center"
                oCell.Width = 230
                oCell.Height = 30
                oCell.Style("cursor") = "hand"
                oCell.Style("forecolor") = "MidnightBlue"
                oCell.Style("border-style") = "solid"
                oCell.Style("border-width") = "1px"
                oCell.Style("border-color") = "#087105"
                If Session("MDMAS030Key1") = GetString(oReader, 0) Then
                    oCell.BgColor = "#FFC0C0"
                Else
                    oCell.BgColor = "#D9FFCC"
                    oCell.Attributes("onmouseover") = "this.style.backgroundColor='Gold'"
                    oCell.Attributes("onmouseout") = "this.style.backgroundColor='#D9FFCC'"
                End If
                oCell.Attributes("onclick") = "showMenu2('" + GetString(oReader, 0).ToString() + "');"
                oRow.Cells.Add(oCell)
                tblMenu1.Rows.Add(oRow)
            End While
            oReader.Close()
            Session("MDMAS030Level") = cboLevel.SelectedValue
            pnlMenu1.Visible = True
            pnlMenu2.Visible = False
            pnlFunc.Visible = False
            'btnInsert.Visible = MedicalLib.Common.EnableUpdate 
            udpMenu1.Update()
            udpMenu2.Update()
            udpFunc.Update()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    'メニュー2表示 
    Private Sub DisplayMenu2()
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            tblMenu2.Rows.Clear()
            sQuery = "SELECT A.PROGRAM_ID,C.PG_NM,B.ENTRY,B.CORRECT,B.DEL "
            sQuery += "FROM (SELECT EMPOWER_LV,MENU_ID,PROGRAM_ID,DSP_TURN FROM MENU_MST WHERE MENU_LEBEL = '2') A,"
            sQuery += "(SELECT EMPOWER_LV,MENU_ID,PROGRAM_ID,ENTRY,CORRECT,DEL FROM RIGHTS_MST WHERE EMPOWER_LV = :K01) B,"
            sQuery += "(SELECT PROGRAM_ID,PG_NM FROM PROGRAM_MST WHERE MENU_LEBEL = '2') C "
            sQuery += "WHERE (A.EMPOWER_LV = B.EMPOWER_LV(+) AND A.MENU_ID = B.MENU_ID(+) AND A.PROGRAM_ID = B.PROGRAM_ID(+)) AND "
            sQuery += "A.PROGRAM_ID = C.PROGRAM_ID(+) AND "
            sQuery += "A.MENU_ID = :K02 "
            sQuery += "ORDER BY A.DSP_TURN"
            _oDatabase.CreateParam("K01", Session("MDMAS030Level"))
            _oDatabase.CreateParam("K02", Session("MDMAS030Key1"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            Dim i As Integer = 2
            Dim j As Integer = -1
            Dim oRow As HtmlTableRow = Nothing
            Dim oCell As HtmlTableCell = Nothing
            While oReader.Read()
                If i > 1 Then
                    oRow = New HtmlTableRow
                    i = 0
                    j += 1
                End If
                oCell = New HtmlTableCell
                If Not GetString(oReader, 0).Trim.PadRight(8, " ").Substring(0, 3).Equals("&SP") Then
                    oCell.Controls.Add(New CheckBox)
                    oCell.Controls.Add(New CheckBox)
                    oCell.Controls.Add(New CheckBox)
                    oCell.Controls.Add(New HiddenField)
                    oCell.Controls.Add(New HiddenField)
                    oCell.Controls.Add(New HiddenField)
                    oCell.Controls.Add(New HiddenField)
                    CType(oCell.Controls(0), CheckBox).ID = "chkA" & i & j
                    CType(oCell.Controls(1), CheckBox).ID = "chkB" & i & j
                    CType(oCell.Controls(2), CheckBox).ID = "chkC" & i & j
                    'CType(oCell.Controls(0), CheckBox).ToolTip = "登録" 
                    'CType(oCell.Controls(1), CheckBox).ToolTip = "訂正" 
                    'CType(oCell.Controls(2), CheckBox).ToolTip = "削除" 
                    CType(oCell.Controls(3), HiddenField).ID = "txtA" & i & j
                    CType(oCell.Controls(4), HiddenField).ID = "txtB" & i & j
                    CType(oCell.Controls(5), HiddenField).ID = "txtC" & i & j
                    CType(oCell.Controls(6), HiddenField).ID = "txtD" & i & j
                    CType(oCell.Controls(0), CheckBox).Checked = GetString(oReader, 2) = "1"
                    CType(oCell.Controls(1), CheckBox).Checked = GetString(oReader, 3) = "1"
                    CType(oCell.Controls(2), CheckBox).Checked = GetString(oReader, 4) = "1"
                    CType(oCell.Controls(3), HiddenField).Value = IIf(GetString(oReader, 2) = "1", 1, 0)
                    CType(oCell.Controls(4), HiddenField).Value = IIf(GetString(oReader, 3) = "1", 1, 0)
                    CType(oCell.Controls(5), HiddenField).Value = IIf(GetString(oReader, 4) = "1", 1, 0)
                    CType(oCell.Controls(6), HiddenField).Value = GetString(oReader, 0)
                    oCell.Controls.Add(New LiteralControl("<font color='MidnightBlue'>" + GetString(oReader, 1) + "</font>"))
                    oCell.Align = "left"
                    oCell.Width = 340
                    oCell.Height = 30
                    oCell.BgColor = "#D9FFCC"
                    oCell.Style("cursor") = "hand"
                    oCell.Style("forecolor") = "MidnightBlue"
                    oCell.Style("border-style") = "solid"
                    oCell.Style("border-width") = "1px"
                    oCell.Style("border-color") = "#087105"
                    oCell.Attributes("onmouseover") = "this.style.backgroundColor='Gold'"
                    oCell.Attributes("onmouseout") = "this.style.backgroundColor='#D9FFCC'"
                Else
                    oCell.Align = "center"
                    oCell.Width = 340
                    oCell.Height = 30
                    oCell.BgColor = "#f7f7f7"
                End If
                oRow.Cells.Add(oCell)
                If i = 1 Then tblMenu2.Rows.Add(oRow)
                i += 1
            End While
            If i = 1 Then
                oCell = New HtmlTableCell
                oCell.BgColor = "#F7F7F7"
                oCell.Width = "340"
                oRow.Cells.Add(oCell)
                tblMenu2.Rows.Add(oRow)
            End If
            oReader.Close()
            pnlMenu2.Visible = True
            pnlFunc.Visible = True
            udpMenu2.Update()
            udpFunc.Update()
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
        Try
            _oDatabase.BeginTrans()
            '実行権利マスタ削除 
            sQuery = "DELETE FROM RIGHTS_MST WHERE EMPOWER_LV = :K01 AND MENU_ID = :K02"
            _oDatabase.CreateParam("K01", Session("MDMAS030Level"))
            _oDatabase.CreateParam("K02", Session("MDMAS030Key1"))
            _oDatabase.ExecuteNonQueryParam(sQuery)
            For i As Integer = 0 To tblMenu2.Rows.Count - 1
                For j As Integer = 0 To tblMenu2.Rows(i).Cells.Count - 1
                    If tblMenu2.Rows(i).Cells(j).Controls.Count > 1 Then
                        'If CType(tblMenu2.Rows(i).Cells(j).Controls(0), CheckBox).Checked Or _ 
                        '   CType(tblMenu2.Rows(i).Cells(j).Controls(1), CheckBox).Checked Or _ 
                        '   CType(tblMenu2.Rows(i).Cells(j).Controls(2), CheckBox).Checked Then 
                        '登録 
                        sQuery = "INSERT INTO RIGHTS_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," +
                                                                    ":F11,:F12,:F13)"
                        _oDatabase.CreateParam("F01", Session("MDMAS030Level"))
                        _oDatabase.CreateParam("F02", Session("MDMAS030Key1"))
                        _oDatabase.CreateParam("F03", CType(tblMenu2.Rows(i).Cells(j).Controls(6), HiddenField).Value)
                        If CType(tblMenu2.Rows(i).Cells(j).Controls(0), CheckBox).Checked Then
                            _oDatabase.CreateParam("F04", "1")
                        Else
                            _oDatabase.CreateParam("F04", "0")
                        End If
                        If CType(tblMenu2.Rows(i).Cells(j).Controls(1), CheckBox).Checked Then
                            _oDatabase.CreateParam("F05", "1")
                        Else
                            _oDatabase.CreateParam("F05", "0")
                        End If
                        If CType(tblMenu2.Rows(i).Cells(j).Controls(2), CheckBox).Checked Then
                            _oDatabase.CreateParam("F06", "1")
                        Else
                            _oDatabase.CreateParam("F06", "0")
                        End If
                        _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F09", Session("UserID"))
                        _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F12", Session("UserID"))
                        _oDatabase.CreateParam("F13", MedicalLib.Common.ProgramID)
                        _oDatabase.ExecuteNonQueryParam(sQuery)
                    End If
                    'End If 
                Next
            Next
            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
        End Try
    End Function

#End Region

#Region " その他 "

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
