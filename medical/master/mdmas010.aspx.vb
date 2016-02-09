Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing 
 
Partial Class master_mdmas010 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS010" 
    Private Const PROGRAM_TITLE As String = "管理マスターメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " ページ " 
 
    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        If Not Page.IsPostBack Then 
            DisplayShow() 
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

#End Region

#Region " ボタン "

    '登録＆修正ボタン押下処理 
    Protected Sub cmdRun_Click(sender As Object, e As ImageClickEventArgs) Handles cmdRun.Click
        Page.Validate("check")
        If Page.IsValid Then
            '追加/更新 
            If ViewState("mode").Trim.Equals("i") Then
                InsertKanri()
            Else
                Page.Validate("update")
                If Not Page.IsValid Then Exit Sub
                UpdateKanri()
                If ViewState("nendo") <> txtNendo.Text.Trim() Then SaibanReset()
            End If
            DisplayShow()
        End If
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub InsertKanri() 
 
        Dim sQuery As String = "INSERT INTO ADMIN_MST VALUES (:F01,:F02,:F03,:F04,:F05," + _ 
                                                              ":F06,:F07,:F08,:F09,:F10,:F11,:F12)" 
        Try 
            _oDatabase.CreateParam("F01", "01") 
            _oDatabase.CreateParam("F02", txtNendo.Text.Trim()) 
            _oDatabase.CreateParam("F03", txtKi.Text.Trim()) 
            _oDatabase.CreateParam("F04", "0") 
            _oDatabase.CreateParam("F05", txtPass.Text.Trim()) 
            _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemDate) 
            _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemTime) 
            _oDatabase.CreateParam("F08", Session("UserID")) 
            _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate) 
            _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime) 
            _oDatabase.CreateParam("F11", Session("UserID")) 
            _oDatabase.CreateParam("F12", MedicalLib.Common.ProgramID) 
            _oDatabase.ExecuteNonQueryParam(sQuery) 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
    Private Sub UpdateKanri() 
        Dim sQuery As String = "" 
        sQuery = "UPDATE ADMIN_MST SET A_YEAR=:F01,TERM=:F02,G_NO=:F03,PW_EX_DT=:F04,UPD_DT=:F05," + _ 
                                       "UPD_TIME=:F06,UPD_USR=:F07,UPD_PROGRAM_ID =:F08 " + _ 
                                   "WHERE ADMIN_KEY=:K01" 
        Try 
            _oDatabase.CreateParam("F01", txtNendo.Text.Trim()) 
            _oDatabase.CreateParam("F02", txtKi.Text.Trim()) 
            _oDatabase.CreateParam("F03", "0") 
            _oDatabase.CreateParam("F04", txtPass.Text.Trim()) 
            _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate) 
            _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime) 
            _oDatabase.CreateParam("F07", Session("UserID")) 
            _oDatabase.CreateParam("F08", MedicalLib.Common.ProgramID) 
            _oDatabase.CreateParam("K01", "01") 
            _oDatabase.ExecuteNonQueryParam(sQuery) 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
    Private Sub DisplayShow() 
        Try 
            Dim sQuery As String = "" 
            sQuery += "SELECT A_YEAR,TERM,PW_EX_DT,UPD_DT || UPD_TIME " 
            sQuery += "FROM ADMIN_MST " 
            sQuery += "WHERE ADMIN_KEY='01'" 
            Dim oReader As OracleDataReader = _oDatabase.CreateReader(sQuery) 
 
            If oReader.Read() Then 
                ViewState("mode") = "u" 
                txtNendo.Text = oReader.GetString(0).Trim()
                ViewState("nendo") = oReader.GetString(0).Trim()
                txtKi.Text = oReader.GetInt32(1) 
                txtPass.Text = oReader.GetInt32(2) 
                ViewState("update") = oReader.GetString(3).Trim() 
                imgProcessTitle.ImageUrl = "../image/t_update2.gif" 
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Update()) 
                cmdRun.Attributes("src") = "../image/b_update.gif" 
            Else 
                ViewState("mode") = "i" 
                txtNendo.Text = Date.Now.ToString("yyyy") 
                imgProcessTitle.ImageUrl = "../image/t_insert.gif" 
                cmdRun.Attributes.Add("onclick", MedicalLib.Script.Insert()) 
                cmdRun.Attributes("src") = "../image/b_insert.gif" 
            End If 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 

    Private Sub SaibanReset()
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT G_NO_KB,ST_NO FROM GETNO_TBL"
            sQuery += " WHERE G_NO_KB != 'SN' AND G_NO_KB != 'ZR' "
            oReader = _oDatabase.CreateReader(sQuery)

            _oDatabase.BeginTrans()

            sQuery = "UPDATE GETNO_TBL SET PRESENT_NO = :F01, UPD_DT = :F02, UPD_TIME = :F03, UPD_USR= :F04, UPD_PROGRAM_ID = :F05 " + _
                                          "WHERE G_NO_KB = :K01"
            Do While oReader.Read()
                If oReader.GetInt32(1) < 0 Then
                    _oDatabase.CreateParam("F01", "0")
                Else
                    _oDatabase.CreateParam("F01", oReader.GetInt32(1) - 1)
                End If
                _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F04", Session("UserID"))
                _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                _oDatabase.CreateParam("K01", oReader.GetString(0).Trim())

                _oDatabase.ExecuteNonQueryParam(sQuery)
            Loop

            _oDatabase.CommitTrans()
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
            _oDatabase.Rollback()
        End Try
    End Sub

    '期 論理チェック 
    Protected Sub CheckKi(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) 
        If valNendo1.IsValid And valNendo2.IsValid And valKi1.IsValid And valKi2.IsValid Then 
            If txtKi.Text = "1" & txtNendo.Text.Substring(2, 2) Then 
                args.IsValid = True 
            Else 
                args.IsValid = False 
            End If 
        End If 
    End Sub

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM ADMIN_MST WHERE ADMIN_KEY = :K01"
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", "01")
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

End Class 
