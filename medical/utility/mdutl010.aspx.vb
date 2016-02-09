Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
Imports GrapeCity 
Imports GrapeCity.ActiveReports 
Imports GrapeCity.SpreadBuilder 
Imports System.Text 
 
Partial Class mdutl010
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
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        imgExp.Attributes.Add("onclick", MedicalLib.Script.Custome("エクスポートをしてもよろしいですか？"))
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    '工程票発行押下 
    Protected Sub imgExp_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgExp.Click
        lblMessage.Text = "&nbsp;"
        imgProgress.Visible = False
        fraPrint.Attributes("src") = "../temp/dummy.html"
        imgProgress.Visible = True
        fraPrint.Attributes("src") = "mdutl0101.aspx"
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
 
