 
Partial Class mdcllogout 
    Inherits System.Web.UI.Page 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        Session("login") = False 
        Response.Redirect("mdcllogin.aspx") 
    End Sub 
End Class 
