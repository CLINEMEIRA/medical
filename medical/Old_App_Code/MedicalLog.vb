Imports Microsoft.VisualBasic
Imports System.Configuration
Imports System.IO
Imports System.Text
Imports System.Web
Imports System

Namespace MedicalLib

    Public Class Log

#Region " プロパティ "

        'トレース 
        Private Shared ReadOnly Property LogOn() As Boolean
            Get
                Return ConfigurationManager.AppSettings("LogOn")
            End Get
        End Property

        'ログファイル 
        Private Shared ReadOnly Property LogFile() As String
            Get
                Return HttpContext.Current.Server.MapPath("~/log/" + ConfigurationManager.AppSettings("LogFile"))
            End Get
        End Property

        'ログサイズ 
        Private Shared ReadOnly Property LogSize() As Long
            Get
                Return ConfigurationManager.AppSettings("LogSize")
            End Get
        End Property

        'トレース 
        Private Shared ReadOnly Property TraceOn() As Boolean
            Get
                Return ConfigurationManager.AppSettings("TraceOn")
            End Get
        End Property

        'トレースファイル 
        Private Shared ReadOnly Property TraceFile() As String
            Get
                Return HttpContext.Current.Server.MapPath("~/log/" + ConfigurationManager.AppSettings("TraceFile"))
            End Get
        End Property

        'トレースサイズ 
        Private Shared ReadOnly Property TraceSize() As Long
            Get
                Return ConfigurationManager.AppSettings("TraceSize")
            End Get
        End Property

#End Region

#Region " パブリック "

        'トレース 
        Public Shared Sub Trace(ByVal sMessage As String, ByVal sQuery As String)
            If Not TraceOn Then Return
            Dim oSWrite As StreamWriter = Nothing
            Try
                SelectFile(TraceFile, TraceSize)
                oSWrite = New StreamWriter(TraceFile, True, Encoding.GetEncoding("Shift_JIS"))
                oSWrite.WriteLine("[PROGRAM] " + MedicalLib.Common.ProgramID + " [TIME] " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & " [MESSAGE] " & sMessage.Replace(Chr(10), "") & " [SQL] " & sQuery)
            Catch ex As Exception
                Throw ex
            Finally
                If Not oSWrite Is Nothing Then oSWrite.Close()
            End Try
        End Sub

        'ログ 
        Public Shared Sub Log(ByVal sMessage As String)
            If Not LogOn Then Return
            Dim oSWrite As StreamWriter = Nothing
            Try
                SelectFile(LogFile, LogSize)
                oSWrite = New StreamWriter(LogFile, True, Encoding.GetEncoding("Shift_JIS"))
                oSWrite.WriteLine("[PROGRAM] " + MedicalLib.Common.ProgramID + " [TIME] " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & " [MESSAGE] " & sMessage.Replace(Chr(10), ""))
            Catch ex As Exception
                Throw ex
            Finally
                If Not oSWrite Is Nothing Then oSWrite.Close()
            End Try
        End Sub

        'ログ 
        Public Shared Sub Log(ByVal sMessage As String, ByVal sQuery As String)
            If Not LogOn Then Return
            Dim oSWrite As StreamWriter = Nothing
            Try
                SelectFile(LogFile, LogSize)
                oSWrite = New StreamWriter(LogFile, True, Encoding.GetEncoding("Shift_JIS"))
                oSWrite.WriteLine("[PROGRAM] " & MedicalLib.Common.ProgramID & " [TIME] " & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & " [MESSAGE] " & sMessage.Replace(Chr(10), "") & " [SQL] " & sQuery)
            Catch ex As Exception
                Throw ex
            Finally
                If Not oSWrite Is Nothing Then oSWrite.Close()
            End Try
        End Sub

#End Region

#Region " プライベート "

        'ファイル選択 
        Private Shared Sub SelectFile(ByVal sFile As String, ByVal nSize As Long)
            Dim oFileInfo As System.IO.FileInfo
            Try
                If Not File.Exists(sFile) Then Return
                oFileInfo = New System.IO.FileInfo(sFile)
                If oFileInfo.Length > nSize Then
                    File.Copy(sFile, sFile + ".back", True)
                    File.Delete(sFile)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region

    End Class

End Namespace

