Imports System.Data 
Imports System.Data.OracleClient 
Imports System.Drawing

Partial Class master_mdmas160
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS160"
    Private Const PROGRAM_TITLE As String = "パスワード変更"

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        If Not Page.IsPostBack Then
            DisplayClear()
            txtPassOld.Focus()
            btnRun.Attributes.Add("onclick", MedicalLib.Script.Change())
            btnRun.Visible = MedicalLib.Common.EnableUpdate
        End If
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    '変更ボタン押下処理 
    Protected Sub btnRun_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnRun.Click
        Page.Validate("run") : If Not Page.IsValid Then Return
        If Not FileUpdate() Then Return
        'Response.Redirect("../system/mdclmenu.aspx", False)
        DisplayClear()
    End Sub

    'クリアボタン押下処理 
    Protected Sub btnClear_ServerClick(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnClear.Click
        DisplayClear()
    End Sub

#End Region

#Region " 画面関連 "

    '画面初期化 
    Private Sub DisplayClear()
        lblCode.Text = Session("UserID")
        lblName.Text = Session("UserName")
        txtPassOld.Text = ""
        txtPassNew1.Text = ""
        txtPassNew2.Text = ""
        scrManager.SetFocus(txtPassOld)
    End Sub

#End Region

#Region " チェック関連 "

    '旧パスワードチェック 
    Protected Sub valPassOld2_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs) Handles valPassOld2.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT PASSWORD FROM WORKER_MST WHERE WORKER_CD = :K01"
            _oDatabase.CreateParam("K01", Session("UserID"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.Read()
            If args.IsValid Then
                args.IsValid = GetString(oReader, 0) = txtPassOld.Text.Trim()
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    '新パスワードチェック 
    Protected Sub valPassNew1b_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs) Handles valPassNew1b.ServerValidate
        If txtPassOld.Text.Trim.Equals("") Then Return
        args.IsValid = txtPassOld.Text.Trim() <> txtPassNew1.Text.Trim()
    End Sub

    '新パスワード(確認用)チェック 
    Protected Sub valPassNew2b_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs) Handles valPassNew2b.ServerValidate
        If txtPassNew1.Text.Trim.Equals("") Then Return
        args.IsValid = txtPassNew1.Text.Trim() = txtPassNew2.Text.Trim()
    End Sub

#End Region

#Region " ファイル関連 "

    '更新 
    Private Function FileUpdate() As Boolean
        Dim sQuery As String = ""
        Try
            '更新 
            sQuery = "UPDATE WORKER_MST SET "
            sQuery += "PASSWORD = :F01,"
            sQuery += "PW_DT = :F02,"
            sQuery += "UPD_DT = :F03,"
            sQuery += "UPD_TIME = :F04,"
            sQuery += "UPD_USR = :F05,"
            sQuery += "UPD_PROGRAM_ID = :F06 "
            sQuery += "WHERE WORKER_CD = :K01"
            _oDatabase.CreateParam("F01", txtPassNew1.Text.Trim())              'PASSWORD 
            _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)      'PW_DT 
            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)      'UPD_DT 
            _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
            _oDatabase.CreateParam("F05", Session("UserID"))                    'UPD_USR 
            _oDatabase.CreateParam("F06", "MDCLMENU")                           'UPD_PROGRAM_ID 
            _oDatabase.CreateParam("K01", lblCode.Text.Trim())
            _oDatabase.ExecuteNonQueryParam(sQuery)
            Return True
        Catch ex As Exception
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

#End Region

End Class
