Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdsrc000 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC000" 
    Private Const PROGRAM_TITLE As String = "日付選択" 
 
    Private _oDatabase As MedicalLib.DataAccess 
     
#Region " ページ " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
 
        If Not Page.IsPostBack Then 
            ViewState("today") = MedicalLib.Common.GetSystemDate() 
            Dim sNen As String = ViewState("today").ToString.Substring(0, 4) 
            Dim sTuki As String = ViewState("today").ToString.Substring(4, 2) 
            ViewState("nen") = sNen 
            ViewState("tuki") = sTuki 
        End If 
        GridBind() 
    End Sub 
 
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub btnPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) 
        Dim nen As String = ViewState("nen") 
        Dim tuki As String = ViewState("tuki") 
        tuki = ViewState("tuki") - 1 
        If tuki = 0 Then 
            nen = ViewState("nen") - 1 
            tuki = 12 
        End If 
        ViewState("nen") = nen 
        ViewState("tuki") = tuki.PadLeft(2, "0") 
        GridBind() 
    End Sub 
 
    Protected Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) 
        Dim nen As String = ViewState("nen") 
        Dim tuki As String = ViewState("tuki") 
        tuki = ViewState("tuki") + 1 
        If tuki = 13 Then 
            nen = ViewState("nen") + 1 
            tuki = 1 
        End If 
        ViewState("nen") = nen 
        ViewState("tuki") = tuki.PadLeft(2, "0") 
        GridBind() 
    End Sub 
 
#End Region 
 
#Region " ユーザー関数 " 
 
    Private Sub GridBind() 
        Try 
            Dim sQuery As String = "SELECT * FROM CALENDAR_MST WHERE C_YEAR = :K01 AND C_MONTH = :K02 " 
            _oDatabase.CreateParam("K01", ViewState("nen")) 
            _oDatabase.CreateParam("K02", ViewState("tuki")) 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
            Dim sBgColor As String = "" 
            Dim sOnClick As String = "" 
 
            If oReader.HasRows Then 
 
                Clear() 
                getTitle() 
 
                Dim i As Integer = 1 
                Dim rows As Integer = 2 
                Dim cells As Integer 
                Dim html As String = "" 
                Do While oReader.Read() 
                    If i = 1 Then cells = getWeek((oReader.GetString(0) + "/" + oReader.GetString(1) + "/" + oReader.GetString(2))) 
 
                    html = "" 
                    'html += "<a href=""#"" onclick=""closeWindow('" + oReader.GetString(3) + "');return false;"" " 
                    html += "<div " 
                    sOnClick = "closeWindow('" + oReader.GetString(3) + "');return false;" 
 
                    If ViewState("today") = oReader.GetString(3) Then 
                        html += "style=""color:#FFFFCC;"" " 
                        tblCalen.Rows(rows).Cells(cells).BgColor = "#FFCC66" 
                        sBGColor = "#FFCC66" 
                    ElseIf oReader.GetString(4) = 1 Then 
                        html += "style=""color:#FF0000;"" " 
                        tblCalen.Rows(rows).Cells(cells).BgColor = "#ffffcc" 
                        sBGColor = "#ffffcc" 
                    ElseIf cells = 0 Then 
                        html += "style=""color:#FF0000;"" " 
                        tblCalen.Rows(rows).Cells(cells).BgColor = "#ffffcc" 
                        sBGColor = "#ffffcc" 
                    ElseIf cells = 6 Then 
                        html += "style=""color:#0000FF;"" " 
                        tblCalen.Rows(rows).Cells(cells).BgColor = "#ffffcc" 
                        sBGColor = "#ffffcc" 
                    Else 
                        html += "style=""color:#663399;"" " 
                        tblCalen.Rows(rows).Cells(cells).BgColor = "#ffffcc" 
                        sBGColor = "#ffffcc" 
                    End If 
 
                    'html += ">" + i.ToString + "</a>" 
                    html += ">" + i.ToString + "</div>" 
 
                    tblCalen.Rows(rows).Cells(cells).InnerHtml = html 
                    tblCalen.Rows(rows).Cells(cells).Style("cursor") = "hand" 
                    tblCalen.Rows(rows).Cells(cells).Attributes("onmouseover") = "this.style.backgroundColor='Gold'" 
                    tblCalen.Rows(rows).Cells(cells).Attributes("onmouseout") = "this.style.backgroundColor='" + sBGColor + "'" 
                    tblCalen.Rows(rows).Cells(cells).Attributes("onclick") = sOnClick 
                    If cells = 6 Then 
                        rows += 1 
                        cells = 0 
                    Else 
                        cells += 1 
                    End If 
                    i += 1 
                Loop 
            Else 
 
                tblCalen.Visible = False 
 
            End If 
 
        Catch tex As Threading.ThreadAbortException 
            Throw 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
    Private Function getWeek(ByVal day As DateTime) As Integer 
        Dim row As Integer = 0 
        Select Case CType(day, DateTime).DayOfWeek 
            Case DayOfWeek.Sunday 
                row = 0 
            Case DayOfWeek.Monday 
                row = 1 
            Case DayOfWeek.Tuesday 
                row = 2 
            Case DayOfWeek.Wednesday 
                row = 3 
            Case DayOfWeek.Thursday 
                row = 4 
            Case DayOfWeek.Friday 
                row = 5 
            Case DayOfWeek.Saturday 
                row = 6 
        End Select 
        Return row 
    End Function 
 
    Private Sub getTitle() 
 
        Dim nen As String = ViewState("nen") 
        Dim tuki As String = ViewState("tuki") 
 
        tuki = ViewState("tuki") - 1 
        If tuki = 0 Then 
            nen = ViewState("nen") - 1 
            tuki = 12 
        End If 
 
        If getLink(nen, tuki.PadLeft(2, "0")) Then 
            'tblTitle.Rows(0).Cells(0).InnerHtml = "<a href=""mdsrc000.aspx?nen=" + nen + "&tuki=" + tuki.PadLeft(2, "0") + """ style=""color:#FFFFCC;"">＜</a>" 
            tblTitle.Rows(0).Cells(0).InnerHtml = "<a href=""#"" onclick=""document.getElementById('btnPrev').click();return false;"" style=""color:#FFFFCC;"">＜</a>" 
        End If 
 
        Dim sTitle As String = ViewState("nen") + "年" + Int(ViewState("tuki")).ToString + "月" 
        Dim sClick As String = ViewState("nen").ToString() + ViewState("tuki").ToString() 
        'tblTitle.Rows(0).Cells(1).InnerHtml = ViewState("nen") + "年" + Int(ViewState("tuki")).ToString + "月" 
        tblTitle.Rows(0).Cells(1).InnerHtml = "<a href=""#"" onclick=""closeWindow('" + sClick + "');return false;"" style=""color:#FFFFCC;"">" + sTitle + "</a>" 
 
        nen = ViewState("nen") 
        tuki = ViewState("tuki") + 1 
        If tuki = 13 Then 
            nen = ViewState("nen") + 1 
            tuki = 1 
        End If 
 
        If getLink(nen, tuki.PadLeft(2, "0")) Then 
            'tblTitle.Rows(0).Cells(2).InnerHtml = "<a href=""mdsrc000.aspx?nen=" + nen + "&tuki=" + tuki.PadLeft(2, "0") + """ style=""color:#FFFFCC;"">＞</a>" 
            tblTitle.Rows(0).Cells(2).InnerHtml = "<a href=""#"" onclick=""document.getElementById('btnNext').click();return false;"" style=""color:#FFFFCC;"">＞</a>" 
        End If 
    End Sub 
 
    Private Function getLink(ByVal nen As String, ByVal tuki As String) As Boolean 
        Dim temp As Boolean 
        Try 
            Dim sQuery As String = "SELECT * FROM CALENDAR_MST WHERE C_YEAR = :K01 AND C_MONTH = :K02 " 
            _oDatabase.CreateParam("K01", nen) 
            _oDatabase.CreateParam("K02", tuki) 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
 
            temp = oReader.HasRows 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        Return temp 
    End Function 
 
    Private Sub Clear() 
        Dim i As Integer 
        Dim j As Integer 
        tblTitle.Rows(0).Cells(0).InnerHtml = "" 
        tblTitle.Rows(0).Cells(2).InnerHtml = "" 
        For i = 2 To 7 
            For j = 0 To 6 
                tblCalen.Rows(i).Cells(j).InnerHtml() = "&ensp;" 
                tblCalen.Rows(i).Cells(j).BgColor = "#ffffcc" 
                tblCalen.Rows(i).Cells(j).Style("cursor") = Nothing 
                tblCalen.Rows(i).Cells(j).Attributes("onmouseover") = Nothing 
                tblCalen.Rows(i).Cells(j).Attributes("onmouseout") = Nothing 
                tblCalen.Rows(i).Cells(j).Attributes("onclick") = Nothing 
            Next 
        Next 
    End Sub 
 
#End Region 
 
End Class 
