

Namespace MedicalLib 
 
    Public Class Script 
 
#Region " プロパティ " 
 
        Public Shared ReadOnly Property Insert() As String 
            Get 
                Return "if (confirm('登録してもよろしいですか') == false) return false;" 
            End Get 
        End Property 
 
        Public Shared ReadOnly Property Update() As String 
            Get 
                Return "if (confirm('訂正してもよろしいですか') == false) return false;" 
            End Get 
        End Property 
 
        Public Shared ReadOnly Property Change() As String 
            Get 
                Return "if (confirm('変更してもよろしいですか') == false) return false;" 
            End Get 
        End Property 
 
        Public Shared ReadOnly Property Delete() As String 
            Get 
                Return "if (confirm('削除してもよろしいですか') == false) return false;" 
            End Get 
        End Property 
 
        Public Shared ReadOnly Property Import() As String 
            Get 
                Return "if (confirm('処理を実行してもよろしいですか') == false) return false;" 
            End Get 
        End Property 
 
        Public Shared ReadOnly Property Print() As String 
            Get 
                Return "if (confirm('印刷してもよろしいですか') == false) return false;" 
            End Get 
        End Property 
 
        Public Shared ReadOnly Property Custome(ByVal sValue As String) As String 
            Get 
                Return "if (confirm('" + sValue + "') == false) return false;" 
            End Get 
        End Property 
 
#End Region 
 
    End Class 
 
End Namespace 
