
Imports System
Imports System.Web
Imports Microsoft.VisualBasic

Namespace MedicalLib

    Public Class PageError

#Region " パブリック "

        'エラー表示 
        Public Shared Sub Show(ByVal sMessage As String)
            Try
                sMessage = sMessage.Replace(ControlChars.Cr, "")
                sMessage = sMessage.Replace(ControlChars.Lf, "")
                MedicalLib.Log.Log(sMessage)
                HttpContext.Current.Response.Redirect("../system/mdclerror.aspx?msg=" + sMessage)
            Catch ex As Exception
            End Try
        End Sub

#End Region

    End Class

End Namespace

