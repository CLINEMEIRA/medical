Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient

Partial Class master_mdmas130
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS130"
    Private Const PROGRAM_TITLE As String = "カレンダーマスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess

#Region " ページ "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE

        Try
            _oDatabase = New MedicalLib.DataAccess

            'コンボの設定 
            If Not Page.IsPostBack Then
                Dim nen As Integer = 2000
                For nen = 2000 To 2099
                    ddlNendo.Items.Add(New ListItem(nen, nen))
                Next

                Dim sql As String = "SELECT A_YEAR FROM ADMIN_MST WHERE ADMIN_KEY = '01'"
                Dim oDataReader As OracleDataReader = _oDatabase.CreateReader(sql)
                oDataReader.Read()
                ddlNendo.SelectedValue = oDataReader.GetString(0).Trim()
                oDataReader.Close()
            End If

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

        cmdRun.Visible = MedicalLib.Common.EnableInsert

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

    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnSearch.Click
        'テーブルの表示 
        Panel1.Visible = True
        ViewState("nendo") = ddlNendo.SelectedValue.Trim()
        lbl04.Text = ddlNendo.SelectedValue.Trim()
        lbl01.Text = Int(ddlNendo.SelectedValue.Trim()) + 1

        'うるう年の判定 
        If IsDate(lbl01.Text & "/02/29") Then
            ViewState("leap") = 29
            chk0229.Visible = True
        Else
            ViewState("leap") = 28
            chk0229.Visible = False
        End If
        'If ddlNendo.SelectedValue.Trim().Equals("2099") Then 
        '    ViewState("leap") = 28 
        'Else 
        '    If Int(ddlNendo.SelectedValue.Trim()) Mod 4 = 3 Then 
        '        ViewState("leap") = 29 
        '        chk0229.Visible = True 
        '    Else 
        '        ViewState("leap") = 28 
        '        chk0229.Visible = False 
        '    End If 
        'End If 

        'テーブルのチェック 
        Dim sQuery As String = ""
        Dim oCheck As Object = ""
        sQuery += "SELECT C_MONTH||C_DAY,WORK_FLG FROM CALENDAR_MST "
        sQuery += "WHERE C_YEAR = :K01 AND (C_MONTH BETWEEN 4 AND 12) "
        sQuery += "OR C_YEAR = :K02 AND (C_MONTH BETWEEN 1 AND 3)"
        _oDatabase.CreateParam("K01", ddlNendo.SelectedValue.Trim())
        _oDatabase.CreateParam("K02", (Int(ddlNendo.SelectedValue.Trim()) + 1).ToString)
        Dim oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
        If oDataReader.HasRows Then
            ViewState("mode") = "u"
            Do While oDataReader.Read()
                oCheck = Me.FindControl("chk" + oDataReader.GetString(0))
                If oDataReader.GetString(1) = 0 Then
                    oCheck.checked = False
                Else
                    oCheck.checked = True
                End If
            Loop
            cmdRun.Attributes("src") = "../image/b_update.gif"
            cmdRun.Attributes.Add("onclick", MedicalLib.Script.Update())
        Else
            ViewState("mode") = "i"
            CheckClear(401, 430)
            CheckClear(501, 531)
            CheckClear(601, 630)
            CheckClear(701, 731)
            CheckClear(801, 831)
            CheckClear(901, 930)
            CheckClear(1001, 1031)
            CheckClear(1101, 1130)
            CheckClear(1201, 1231)
            CheckClear(101, 131)
            CheckClear(201, 200 + ViewState("leap"))
            CheckClear(301, 331)

            cmdRun.Attributes("src") = "../image/b_insert.gif"
            cmdRun.Attributes.Add("onclick", MedicalLib.Script.Insert())
        End If
        oDataReader.Close()
    End Sub

    Protected Sub cmdRun_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles cmdRun.Click
        If ViewState("mode").Equals("i") Then
            InsertCalendar(401, 430)
            InsertCalendar(501, 531)
            InsertCalendar(601, 630)
            InsertCalendar(701, 731)
            InsertCalendar(801, 831)
            InsertCalendar(901, 930)
            InsertCalendar(1001, 1031)
            InsertCalendar(1101, 1130)
            InsertCalendar(1201, 1231)
            InsertCalendar(101, 131)
            InsertCalendar(201, 200 + ViewState("leap"))
            InsertCalendar(301, 331)
        Else
            UpdateCalendar(401, 430)
            UpdateCalendar(501, 531)
            UpdateCalendar(601, 630)
            UpdateCalendar(701, 731)
            UpdateCalendar(801, 831)
            UpdateCalendar(901, 930)
            UpdateCalendar(1001, 1031)
            UpdateCalendar(1101, 1130)
            UpdateCalendar(1201, 1231)
            UpdateCalendar(101, 131)
            UpdateCalendar(201, 200 + ViewState("leap"))
            UpdateCalendar(301, 331)
        End If

        Panel1.Visible = False
    End Sub

    Protected Sub cmdClear_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles cmdClear.Click
        CheckClear(401, 430)
        CheckClear(501, 531)
        CheckClear(601, 630)
        CheckClear(701, 731)
        CheckClear(801, 831)
        CheckClear(901, 930)
        CheckClear(1001, 1031)
        CheckClear(1101, 1130)
        CheckClear(1201, 1231)
        CheckClear(101, 131)
        CheckClear(201, 200 + ViewState("leap"))
        CheckClear(301, 331)
        If ViewState("mode").Equals("u") Then
            Dim sQuery As String = ""
            Dim oCheck As Object = ""
            sQuery += "SELECT C_MONTH||C_DAY,WORK_FLG FROM CALENDAR_MST "
            sQuery += "WHERE C_YEAR = :K01 AND (C_MONTH BETWEEN 4 AND 12) "
            sQuery += "OR C_YEAR = :K02 AND (C_MONTH BETWEEN 1 AND 3)"
            _oDatabase.CreateParam("K01", ViewState("nendo"))
            _oDatabase.CreateParam("K02", (ViewState("nendo") + 1).ToString)
            Dim oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oDataReader.HasRows Then
                Do While oDataReader.Read()
                    oCheck = Me.FindControl("chk" + oDataReader.GetString(0))
                    If oDataReader.GetString(1) = 0 Then
                        oCheck.checked = False
                    Else
                        oCheck.checked = True
                    End If
                Loop
            End If
        End If

    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub InsertCalendar(ByVal a As Integer, ByVal b As Integer)
        Dim sQuery As String = ""
        Dim i As Integer = 0
        Dim oCheck As Object = ""
        Dim nendo As Integer = ViewState("nendo")
        If "01" <= a.ToString("0000").Substring(0, 2) And a.ToString("0000").Substring(0, 2) <= "03" Then
            nendo = nendo + 1
        End If
        Try
            _oDatabase.BeginTrans()
            For i = a To b
                sQuery = "INSERT INTO CALENDAR_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," +
                                                              ":F11,:F12)"
                _oDatabase.CreateParam("F01", nendo.ToString("0000"))
                _oDatabase.CreateParam("F02", i.ToString("0000").Substring(0, 2))
                _oDatabase.CreateParam("F03", i.ToString("0000").Substring(2, 2))
                _oDatabase.CreateParam("F04", nendo.ToString("0000") + i.ToString("0000").Substring(0, 2) + i.ToString("0000").Substring(2, 2))
                oCheck = Me.FindControl("chk" + i.ToString("0000").Substring(0, 4))
                If oCheck.checked Then
                    _oDatabase.CreateParam("F05", "1")
                Else
                    _oDatabase.CreateParam("F05", "0")
                End If
                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F08", Session("UserID"))
                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F11", Session("UserID"))
                _oDatabase.CreateParam("F12", MedicalLib.Common.ProgramID)
                _oDatabase.ExecuteNonQueryParam(sQuery)
            Next
            _oDatabase.CommitTrans()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdateCalendar(ByVal a As Integer, ByVal b As Integer)
        Dim sQuery As String = ""
        Dim i As Integer = 0
        Dim oCheck As Object = ""
        Dim nendo As Integer = ViewState("nendo")
        If "01" <= a.ToString("0000").Substring(0, 2) And a.ToString("0000").Substring(0, 2) <= "03" Then
            nendo = nendo + 1
        End If

        Try
            _oDatabase.BeginTrans()
            For i = a To b
                sQuery = "UPDATE CALENDAR_MST SET "
                sQuery += "WORK_FLG = :F01,"
                sQuery += "UPD_DT = :F02,"
                sQuery += "UPD_TIME = :F03,"
                sQuery += "UPD_USR = :F04,"
                sQuery += "UPD_PROGRAM_ID = :F05 "
                sQuery += "WHERE C_YEAR = :K01 "
                sQuery += "AND C_MONTH = :K02 "
                sQuery += "AND C_DAY = :K03"

                oCheck = Me.FindControl("chk" + i.ToString("0000").Substring(0, 4))
                If oCheck.checked Then
                    _oDatabase.CreateParam("F01", "1")
                Else
                    _oDatabase.CreateParam("F01", "0")
                End If
                _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F04", Session("UserID"))
                _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                _oDatabase.CreateParam("K01", nendo.ToString("0000"))
                _oDatabase.CreateParam("K02", i.ToString("0000").Substring(0, 2))
                _oDatabase.CreateParam("K03", i.ToString("0000").Substring(2, 2))
                _oDatabase.ExecuteNonQueryParam(sQuery)
            Next
            _oDatabase.CommitTrans()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckClear(ByVal a As Integer, ByVal b As Integer)
        Dim i As Integer
        Dim oCheck As Object
        For i = a To b
            oCheck = Me.FindControl("chk" + i.ToString("0000"))
            oCheck.checked = False
        Next
    End Sub

#End Region

End Class
