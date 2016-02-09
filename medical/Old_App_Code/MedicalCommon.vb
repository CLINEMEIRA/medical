Imports Microsoft.VisualBasic
Imports System.Data.OracleClient
Imports System.Configuration
Imports System.Web
Imports System

Namespace MedicalLib

    Public Class Common

        Private Shared _sProgramID As String = ""
        Private Shared _sProgramTitle As String = ""

        '2008/02/14 ADD Start
        Private Shared _skeySiji As String = ""
        Private Shared _skeyShanai As String = ""
        '2008/02/14 ADD End

        Private Shared _nEnableInsert As Boolean = False
        Private Shared _nEnableUpdate As Boolean = False
        Private Shared _nEnableDelete As Boolean = False

        Public Const LOCK_UPDATE As String = "<br>他の端末で更新されました(再処理してください)<br><br>"
        Public Const LOCK_DELETE As String = "<br>他の端末で削除されました(再処理してください)<br><br>"

        Public Const LOCK_UPDATE2 As String = "他の端末で更新されました(再処理してください)"
        Public Const LOCK_DELETE2 As String = "他の端末で削除されました(再処理してください)"

        Public Enum RDFType
            Read
            Write
        End Enum

#Region " プロパティ "

        'プログラムID 
        Public Shared Property ProgramID() As String
            Get
                Return _sProgramID
            End Get
            Set(ByVal sValue As String)
                '_sProgramID = sValue  2011/10/12 Add
                Dim sWork As String = sValue
                If sWork.Trim.Length > 8 Then sWork = sWork.Substring(0, 8)
                _sProgramID = sWork
            End Set
        End Property

        'プログラムタイトル 
        Public Shared Property ProgramTitle() As String
            Get
                Return _sProgramTitle
            End Get
            Set(ByVal sValue As String)
                _sProgramTitle = sValue
            End Set
        End Property

        'ページサイズ 
        Public Shared ReadOnly Property PageSize() As Integer
            Get
                Return ConfigurationManager.AppSettings("PageMaxLine")
            End Get
        End Property

        'ソート 
        Public Shared Property Sort() As String
            Get
                Return HttpContext.Current.Session("SortExpression").ToString() + " " + HttpContext.Current.Session("SortDirection").ToString()
            End Get
            Set(ByVal sValue As String)
                HttpContext.Current.Session("SortExpression") = sValue
                HttpContext.Current.Session("SortDirection") = "ASC"
            End Set
        End Property

        'ソート(一覧用) 
        Public Shared Property ListSort() As String
            Get
                Return HttpContext.Current.Session("ListSortExpression").ToString() + " " + HttpContext.Current.Session("ListSortDirection").ToString()
            End Get
            Set(ByVal sValue As String)
                HttpContext.Current.Session("ListSortExpression") = sValue
                HttpContext.Current.Session("ListSortDirection") = "ASC"
            End Set
        End Property

        '登録権限 
        Public Shared Property EnableInsert() As Boolean
            Get
                Return _nEnableInsert
            End Get
            Set(ByVal nValue As Boolean)
                _nEnableInsert = nValue
            End Set
        End Property

        '更新権限 
        Public Shared Property EnableUpdate() As Boolean
            Get
                Return _nEnableUpdate
            End Get
            Set(ByVal nValue As Boolean)
                _nEnableUpdate = nValue
            End Set
        End Property

        '削除権限 
        Public Shared Property EnableDelete() As Boolean
            Get
                Return _nEnableDelete
            End Get
            Set(ByVal nValue As Boolean)
                _nEnableDelete = nValue
            End Set
        End Property

        '帳票出力用指示 2008/02/14 ADD
        Public Shared Property KeyShiji() As String
            Get
                Return _skeySiji
            End Get
            Set(ByVal sValue As String)
                _skeySiji = sValue
            End Set
        End Property

        '帳票出力用指示 2008/02/14 ADD
        Public Shared Property KeyShanai() As String
            Get
                Return _skeyShanai
            End Get
            Set(ByVal sValue As String)
                _skeyShanai = sValue
            End Set
        End Property

#End Region

#Region " パブリック "

        'ソート設定 
        Public Shared Sub SortCommand(ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs)
            If HttpContext.Current.Session("SortExpression") <> e.SortExpression Then
                HttpContext.Current.Session("SortExpression") = e.SortExpression
                HttpContext.Current.Session("SortDirection") = "ASC"
            Else
                If HttpContext.Current.Session("SortDirection").ToString.Equals("ASC") Then
                    HttpContext.Current.Session("SortDirection") = "DESC"
                Else
                    HttpContext.Current.Session("SortDirection") = "ASC"
                End If
            End If
        End Sub

        'ソート設定(一覧用) 
        Public Shared Sub ListSortCommand(ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs)
            If HttpContext.Current.Session("ListSortExpression") <> e.SortExpression Then
                HttpContext.Current.Session("ListSortExpression") = e.SortExpression
                HttpContext.Current.Session("ListSortDirection") = "ASC"
            Else
                If HttpContext.Current.Session("ListSortDirection").ToString.Equals("ASC") Then
                    HttpContext.Current.Session("ListSortDirection") = "DESC"
                Else
                    HttpContext.Current.Session("ListSortDirection") = "ASC"
                End If
            End If
        End Sub

        'ソート設定 (直接)
        Public Shared Sub SortCommand(ByVal sValue As String, ByVal isASC As Boolean)

            HttpContext.Current.Session("SortExpression") = sValue
            If isASC = True Then
                HttpContext.Current.Session("SortDirection") = "ASC"
            Else
                HttpContext.Current.Session("SortDirection") = "DESC"
            End If

        End Sub

        Public Shared Function ChangeSingleQuotation(ByVal val As String) As String
            Dim sin As String = ""
            Dim curCnt As Integer = 1
            Dim tmpStr As String = ""
            For curCnt = 1 To Len(val)
                tmpStr = Mid(val, curCnt, 1)
                If tmpStr.Equals("'") Then
                    sin += "''"
                Else
                    sin += tmpStr
                End If
            Next
            Return sin
        End Function

        '環境変数取得 
        Public Shared Function GetEnv(ByVal sKey As String) As String
            Try
                Return ConfigurationManager.AppSettings(sKey).ToString()
            Catch ex As Exception
                Return ""
            End Try
        End Function

        'システム日付 
        Public Shared Function GetSystemDate() As String
            Return Date.Now.ToString("yyyyMMdd")
        End Function

        'システム時刻 
        Public Shared Function GetSystemTime() As String
            Return Date.Now.ToString("HHmmss")
        End Function

        Public Shared Function DateFormat(ByVal sValue As String) As String
            If String.IsNullOrEmpty(sValue) = True Then Return ""
            If sValue.Trim.Equals("00000000") Then Return ""
            Return sValue.Substring(0, 4) + "/" + sValue.Substring(4, 2) + "/" + sValue.Substring(6, 2)
        End Function

        Public Shared Function DateFormat(ByVal sValue As DBNull) As String
            Return ""
        End Function

        Public Shared Function TimeFormat(ByVal sValue As String) As String
            If String.IsNullOrEmpty(sValue) = True Then Return ""
            If sValue.Trim.Equals("000000") Then Return ""
            If sValue.Trim.Equals("0000") Then Return ""
            If sValue.Trim.Length = 4 Then
                Return sValue.Substring(0, 2) + ":" + sValue.Substring(2, 2)
            Else
                Return sValue.Substring(0, 2) + ":" + sValue.Substring(2, 2) + ":" + sValue.Substring(4, 2)
            End If
        End Function

        Public Shared Function TimeFormat(ByVal sValue As DBNull) As String
            Return ""
        End Function

        '日付が入っていて時間が'0000'の時'00:00'を返す  2010/04 追加 
        Public Shared Function TimeFormat(ByVal oDate As Object, ByVal oTime As Object) As String
            If oDate Is DBNull.Value Then Return ""
            If oTime Is DBNull.Value Then Return ""

            If oDate.ToString = String.Empty Then Return ""
            If oTime.ToString = String.Empty Then Return ""

            If oDate.ToString = "00000000" And oTime.ToString = "0000" Then
                '日付も入っていなかったら空白を返す
                Return ""
            Else
                Return oTime.ToString.Substring(0, 2) + ":" + oTime.ToString.Substring(2, 2)
            End If
        End Function

        Public Shared Function TimeFormatHM(ByVal sValue As String) As String
            If String.IsNullOrEmpty(sValue) = True Then Return ""
            If sValue.Trim.Equals("000000") Then Return ""
            Return sValue.Substring(0, 2) + ":" + sValue.Substring(2, 2)
        End Function

        Public Shared Function TimeFormatHM(ByVal sValue As DBNull) As String
            Return ""
        End Function

        Public Shared Function RDF(ByVal oType As RDFType) As String
            If oType = RDFType.Read Then
                Return "../temp/" + HttpContext.Current.Request.ServerVariables("REMOTE_ADDR") + ".rdf"
            Else
                Return HttpContext.Current.Server.MapPath("~/") + "\temp\" + HttpContext.Current.Request.ServerVariables("REMOTE_ADDR") + ".rdf"
            End If
        End Function

        Public Shared Sub CheckLogin()
            Try
                If Not HttpContext.Current.Session("login") Then
                    Throw New ApplicationException("セッションが無効です。再度、ログインして下さい")
                End If
            Catch ex As Exception
                MedicalLib.PageError.Show(ex.Message)
            End Try
        End Sub

#End Region

    End Class

End Namespace

