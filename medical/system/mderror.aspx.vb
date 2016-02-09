
Partial Class system_pageerror
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDERROR"
    Private Const PROGRAM_TITLE As String = "システムエラー"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        If Request.QueryString("msg") Is Nothing Then
            lblMessage.Text = "ログインされていないか、有効時間が過ぎました。"
        Else
            lblMessage.Text = Request.QueryString("msg")
        End If
    End Sub

End Class
