
Partial Class header 
    Inherits System.Web.UI.UserControl 
 
#Region " ページ関連 " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not Session("login") And Not MedicalLib.Common.ProgramID.Equals("MDCLERROR") Then   '2012/02/27
        If Not Session("login") And Not MedicalLib.Common.ProgramID.Equals("MDCLERRO") Then
            Response.Redirect("../system/mdclerror.aspx")
            Return
        End If
        Page.Title = ConfigurationManager.AppSettings("SiteTitle").ToString() + " - " + MedicalLib.Common.ProgramTitle
        lblTitle.Text = MedicalLib.Common.ProgramTitle.Trim()
        If MedicalLib.Common.EnableInsert And MedicalLib.Common.EnableUpdate And MedicalLib.Common.EnableDelete Then
            lblTitle.ForeColor = Drawing.Color.Yellow
        Else
            If Not MedicalLib.Common.ProgramID.Trim.PadRight(4, " ").Substring(0, 4).Equals("MDCL") Then
                lblTitle.ForeColor = Drawing.Color.White
                lblTitle.ToolTip = "登録："
                If MedicalLib.Common.EnableInsert Then
                    lblTitle.ToolTip += "○ "
                Else
                    lblTitle.ToolTip += "× "
                End If
                lblTitle.ToolTip += "訂正："
                If MedicalLib.Common.EnableUpdate Then
                    lblTitle.ToolTip += "○ "
                Else
                    lblTitle.ToolTip += "× "
                End If
                lblTitle.ToolTip += "削除："
                If MedicalLib.Common.EnableDelete Then
                    lblTitle.ToolTip += "○ "
                Else
                    lblTitle.ToolTip += "× "
                End If
            End If
        End If
        lblUserID.Text = Session("UserID")
        lblUserID.Visible = False
        lblUserName.Text = Session("UserName")
        'If MedicalLib.Common.ProgramID.ToUpper.Equals("MDCLERROR") Then lblTitle.ForeColor = Drawing.Color.Red  '2012/02/27
        If MedicalLib.Common.ProgramID.ToUpper.Equals("MDCLERRO") Then lblTitle.ForeColor = Drawing.Color.Red
        'imgMenu.Visible = Not (MedicalLib.Common.ProgramID.ToUpper.Equals("MDCLERROR") Or MedicalLib.Common.ProgramID.ToUpper.Equals("MDCLPASS"))  '2012/02/27
        imgMenu.Visible = Not (MedicalLib.Common.ProgramID.ToUpper.Equals("MDCLERRO") Or MedicalLib.Common.ProgramID.ToUpper.Equals("MDCLPASS"))
        Parent.Page.Form.Attributes("onkeydown") = "return checkEnter();"
    End Sub 
 
#End Region 
 
End Class 
