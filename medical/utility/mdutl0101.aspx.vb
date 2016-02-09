Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class mdutl0101
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDUTL010"
    Private Const PROGRAM_TITLE As String = "データベースエクスポート"

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            DatabaseExport()
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

#Region " その他 "

    Private Sub DatabaseExport()
        Try
            Dim sCommand As String = MedicalLib.Common.GetEnv("ExportCommand")
            Dim sConnect As String = MedicalLib.Common.GetEnv("ExportConnect")
            Dim sOutPath As String = MedicalLib.Common.GetEnv("ExportOutPath")
            Dim sTimeStamp As String = MedicalLib.Common.GetSystemDate + MedicalLib.Common.GetSystemTime
            Dim sDumpFile As String = sOutPath + "DB_" + sTimeStamp + ".dmp"
            Dim sLogFile As String = sOutPath + "DB_" + sTimeStamp + ".log"
            If sCommand.Trim.Equals("") Or sConnect.Trim.Equals("") Or sOutPath.Trim.Equals("") Then Return
            Shell(sCommand + " " + sConnect + " file=" + sDumpFile + " log=" + sLogFile, AppWinStyle.NormalFocus, True)
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

End Class
