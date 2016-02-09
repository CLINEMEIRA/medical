Imports System.Drawing

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Label1.Text = "aaa"
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        Page.Validate("check")
        If Page.IsValid Then
            Me.Label1.Text = Me.TextBox1.Text
        End If
    End Sub
End Class