Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class mdcllogin 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDCLIN" 
    Private Const PROGRAM_TITLE As String = "ログイン" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
            If Not Page.IsPostBack Then 
                Session("MenuKey1") = -1 
                DisplayClear() 
                txtUser.Focus() 
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

    Protected Sub btnLogin_Click(sender As Object, e As ImageClickEventArgs) Handles btnLogin.Click
        Page.Validate("run1") : If Not Page.IsValid Then Return
        Page.Validate("run2") : If Not Page.IsValid Then Return
        Session("login") = True
        If Not ViewState("update").Equals("00000000") Then
            If DateAdd(DateInterval.Day, ViewState("kigen"), CType(MedicalLib.Common.DateFormat(ViewState("update")), Date)) < Date.Now Then
                Response.Redirect("mdclpassword.aspx", False)
            Else
                Response.Redirect("mdclmenu.aspx", False)
            End If
        Else
            Response.Redirect("mdclpassword.aspx", False)
        End If
    End Sub

    'ログインボタン押下 
    Protected Sub btnClear_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnClear.Click
        DisplayClear()
    End Sub

#End Region

#Region " 画面関連 "

    '画面初期化 
    Private Sub DisplayClear() 
        txtUser.Text = "" 
        txtPass.Text = "" 
    End Sub 
 
#End Region 
 
#Region " チェック関連 " 
 
    Protected Sub valCheck_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            CType(source, CustomValidator).ErrorMessage = "作業者マスタに登録されていません" 
            sQuery = "SELECT WORKER_NM,PASSWORD,ADMIN_LV,PW_DT FROM WORKER_MST "
            sQuery += "WHERE WORKER_CD = :K01" 
            _oDatabase.CreateParam("K01", txtUser.Text.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            args.IsValid = oReader.Read() 
            If args.IsValid Then 
                Session("UserID") = txtUser.Text.Trim() 
                Session("UserName") = GetString(oReader, 0) 
                ViewState("password") = GetString(oReader, 1) 
                Session("Level") = GetString(oReader, 2) 
                ViewState("update") = GetString(oReader, 3) 
            End If 
            oReader.Close() 
            If Not args.IsValid Then Return 
            CType(source, CustomValidator).ErrorMessage = "パスワードが間違っています" 
            args.IsValid = ViewState("password") = txtPass.Text.Trim() 
            If Not args.IsValid Then Return 
            sQuery = "SELECT PW_EX_DT FROM ADMIN_MST WHERE ADMIN_KEY = '01'" 
            oReader = _oDatabase.CreateReader(sQuery) 
            If oReader.Read() Then 
                ViewState("kigen") = GetInt32(oReader, 0) 
            Else 
                ViewState("kigen") = 0 
            End If 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
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

End Class 
