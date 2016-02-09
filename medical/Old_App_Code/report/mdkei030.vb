Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdkei030
    Inherits GrapeCity.ActiveReports.SectionReport

    Dim RowNumber As Integer = 0 ' 件数カウンタ 

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader = Nothing
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter = Nothing
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtA_YEAR1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtA_YEAR2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtタイトル As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txt四C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt五C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt六C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt七C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt八C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt九C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十一C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十二C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt一C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt二C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt三C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt上半TERM1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt下半TERM1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt四C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt五C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt六C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt七C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt八C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt九C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十一C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十二C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt一C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt二C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt三C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt上半TERM2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt下半TERM2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt名称 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt半TERM合計1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt半TERM合計2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt四C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt五C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt六C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt七C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt八C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt九C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十一C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十二C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt一C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt二C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt三C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt上半TERM3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt下半TERM3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txt半TERM合計3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt四C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt五C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt六C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt七C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt八C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt九C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十一C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt十二C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt一C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt二C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt三C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt上半TERM4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt下半TERM4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt半TERM合計4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblCode As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKei As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label29 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Sum四C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum五C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum四C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum四C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum四C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum六C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum七C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum八C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum九C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十一C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十二C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum一C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum二C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum三C_MONTH1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum上半TERM1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum下半TERM1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum五C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum六C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum七C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum八C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum九C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十一C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十二C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum一C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum二C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum三C_MONTH2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum上半TERM2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum下半TERM2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum半TERM合計1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum半TERM合計2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum五C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum六C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum七C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum八C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum九C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十一C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十二C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum一C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum二C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum三C_MONTH3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum上半TERM3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum下半TERM3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum半TERM合計3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum五C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum六C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum七C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum八C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum九C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十一C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum十二C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum一C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum二C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum三C_MONTH4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum上半TERM4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum下半TERM4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sum半TERM合計4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line75 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line76 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox61 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox12 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox13 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox14 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox16 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox17 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox18 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox19 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox20 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox21 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox22 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox23 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox24 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox25 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox26 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox27 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox28 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox29 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox30 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox31 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox32 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox33 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox34 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox35 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox36 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox37 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox38 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox39 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox40 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox41 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox42 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox43 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox44 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox45 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox46 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox47 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox48 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox49 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox50 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox51 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox52 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox53 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox54 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox55 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox56 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox57 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox58 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox59 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox60 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line77 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdkei030))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtA_YEAR1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtA_YEAR2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtタイトル = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt四C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt五C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt六C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt七C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt八C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt九C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十一C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十二C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt一C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt二C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt三C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt上半TERM1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt下半TERM1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt四C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt五C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt六C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt七C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt八C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt九C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十一C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十二C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt一C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt二C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt三C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt上半TERM2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt下半TERM2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt名称 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt半TERM合計1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt半TERM合計2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt四C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt五C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt六C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt七C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt八C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt九C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十一C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十二C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt一C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt二C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt三C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt上半TERM3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt下半TERM3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txt半TERM合計3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt四C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt五C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt六C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt七C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt八C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt九C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十一C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt十二C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt一C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt二C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt三C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt上半TERM4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt下半TERM4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt半TERM合計4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblCode = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKei = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label29 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Sum四C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum五C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum四C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum四C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum四C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum六C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum七C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum八C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum九C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十一C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十二C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum一C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum二C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum三C_MONTH1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum上半TERM1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum下半TERM1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum五C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum六C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum七C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum八C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum九C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十一C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十二C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum一C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum二C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum三C_MONTH2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum上半TERM2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum下半TERM2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum半TERM合計1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum半TERM合計2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum五C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum六C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum七C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum八C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum九C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十一C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十二C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum一C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum二C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum三C_MONTH3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum上半TERM3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum下半TERM3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum半TERM合計3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum五C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum六C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum七C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum八C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum九C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十一C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum十二C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum一C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum二C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum三C_MONTH4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum上半TERM4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum下半TERM4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Sum半TERM合計4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line75 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line76 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox61 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox16 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox17 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox18 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox19 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox20 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox21 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox22 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox23 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox24 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox25 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox26 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox27 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox28 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox29 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox30 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox31 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox32 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox33 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox34 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox35 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox36 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox37 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox38 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox39 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox40 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox41 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox42 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox43 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox44 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox45 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox46 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox47 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox48 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox49 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox50 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox51 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox52 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox53 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox54 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox55 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox56 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox57 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox58 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox59 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox60 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line77 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtA_YEAR1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtA_YEAR2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtタイトル, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt四C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt五C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt六C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt七C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt八C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt九C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十一C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十二C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt一C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt二C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt三C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt上半TERM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt下半TERM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt四C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt五C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt六C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt七C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt八C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt九C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十一C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十二C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt一C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt二C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt三C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt上半TERM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt下半TERM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt名称, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt半TERM合計1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt半TERM合計2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt四C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt五C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt六C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt七C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt八C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt九C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十一C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十二C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt一C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt二C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt三C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt上半TERM3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt下半TERM3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt半TERM合計3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt四C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt五C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt六C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt七C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt八C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt九C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十一C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt十二C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt一C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt二C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt三C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt上半TERM4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt下半TERM4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt半TERM合計4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKei, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum四C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum五C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum四C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum四C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum四C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum六C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum七C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum八C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum九C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十一C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十二C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum一C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum二C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum三C_MONTH1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum上半TERM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum下半TERM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum五C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum六C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum七C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum八C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum九C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十一C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十二C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum一C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum二C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum三C_MONTH2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum上半TERM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum下半TERM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum半TERM合計1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum半TERM合計2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum五C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum六C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum七C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum八C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum九C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十一C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十二C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum一C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum二C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum三C_MONTH3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum上半TERM3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum下半TERM3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum半TERM合計3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum五C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum六C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum七C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum八C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum九C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十一C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum十二C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum一C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum二C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum三C_MONTH4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum上半TERM4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum下半TERM4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sum半TERM合計4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox61, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox47, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox51, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox52, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox53, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox54, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox55, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox56, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox57, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox58, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox59, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox60, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line47, Me.Label22, Me.Label23, Me.txt四C_MONTH1, Me.txt五C_MONTH1, Me.txt六C_MONTH1, Me.txt七C_MONTH1, Me.txt八C_MONTH1, Me.txt九C_MONTH1, Me.txt十C_MONTH1, Me.txt十一C_MONTH1, Me.txt十二C_MONTH1, Me.txt一C_MONTH1, Me.txt二C_MONTH1, Me.txt三C_MONTH1, Me.txt上半TERM1, Me.txt下半TERM1, Me.txt四C_MONTH2, Me.txt五C_MONTH2, Me.txt六C_MONTH2, Me.txt七C_MONTH2, Me.txt八C_MONTH2, Me.txt九C_MONTH2, Me.txt十C_MONTH2, Me.txt十一C_MONTH2, Me.txt十二C_MONTH2, Me.txt一C_MONTH2, Me.txt二C_MONTH2, Me.txt三C_MONTH2, Me.txt上半TERM2, Me.txt下半TERM2, Me.txt名称, Me.txt半TERM合計1, Me.txt半TERM合計2, Me.txt四C_MONTH3, Me.txt五C_MONTH3, Me.txt六C_MONTH3, Me.txt七C_MONTH3, Me.txt八C_MONTH3, Me.txt九C_MONTH3, Me.txt十C_MONTH3, Me.txt十一C_MONTH3, Me.txt十二C_MONTH3, Me.txt一C_MONTH3, Me.txt二C_MONTH3, Me.txt三C_MONTH3, Me.txt上半TERM3, Me.txt下半TERM3, Me.Label25, Me.Label26, Me.txt半TERM合計3, Me.txt四C_MONTH4, Me.txt五C_MONTH4, Me.txt六C_MONTH4, Me.txt七C_MONTH4, Me.txt八C_MONTH4, Me.txt九C_MONTH4, Me.txt十C_MONTH4, Me.txt十一C_MONTH4, Me.txt十二C_MONTH4, Me.txt一C_MONTH4, Me.txt二C_MONTH4, Me.txt三C_MONTH4, Me.txt上半TERM4, Me.txt下半TERM4, Me.txt半TERM合計4, Me.Line27, Me.Line3, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.Line34, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Line39, Me.Line41, Me.Line42, Me.Line43, Me.TextBox, Me.lblCode, Me.Line4})
        Me.Detail.Height = 0.6027778!
        Me.Detail.Name = "Detail"
        '
        'ReportHeader
        '
        Me.ReportHeader.Height = 0!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.Visible = false
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label15, Me.Label18, Me.Label19, Me.Label20, Me.Label32, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox34, Me.TextBox35, Me.TextBox36, Me.TextBox37, Me.TextBox38, Me.TextBox39, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46, Me.TextBox47, Me.TextBox48, Me.TextBox49, Me.TextBox50, Me.TextBox51, Me.TextBox52, Me.TextBox53, Me.TextBox54, Me.TextBox55, Me.TextBox56, Me.TextBox57, Me.TextBox58, Me.TextBox59, Me.TextBox60, Me.Line2, Me.Line19, Me.Line22, Me.Line23, Me.Line24, Me.Line40, Me.Line44, Me.Line45, Me.Line46, Me.Line49, Me.Line50, Me.Line51, Me.Line52, Me.Line53, Me.Line66, Me.Line70, Me.Line71, Me.Line72, Me.Line77})
        Me.ReportFooter.Height = 0.6027778!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.CanGrow = false
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label16, Me.Label17, Me.txtA_YEAR1, Me.txtA_YEAR2, Me.txtタイトル, Me.lblDate, Me.Label, Me.lblPage, Me.Label21, Me.Label24, Me.Line48, Me.Line26, Me.Line5, Me.Line6, Me.Line1, Me.Line21, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line25, Me.Line, Me.Line20, Me.Line18})
        Me.PageHeader.Height = 1.009722!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = false
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'GroupHeader1
        '
        Me.GroupHeader1.DataField = "名称1"
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.Visible = false
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label31, Me.lblKei, Me.Label27, Me.Label30, Me.Label29, Me.Label28, Me.Sum四C_MONTH1, Me.Sum五C_MONTH1, Me.Sum四C_MONTH2, Me.Sum四C_MONTH3, Me.Sum四C_MONTH4, Me.Sum六C_MONTH1, Me.Sum七C_MONTH1, Me.Sum八C_MONTH1, Me.Sum九C_MONTH1, Me.Sum十C_MONTH1, Me.Sum十一C_MONTH1, Me.Sum十二C_MONTH1, Me.Sum一C_MONTH1, Me.Sum二C_MONTH1, Me.Sum三C_MONTH1, Me.Sum上半TERM1, Me.Sum下半TERM1, Me.Sum五C_MONTH2, Me.Sum六C_MONTH2, Me.Sum七C_MONTH2, Me.Sum八C_MONTH2, Me.Sum九C_MONTH2, Me.Sum十C_MONTH2, Me.Sum十一C_MONTH2, Me.Sum十二C_MONTH2, Me.Sum一C_MONTH2, Me.Sum二C_MONTH2, Me.Sum三C_MONTH2, Me.Sum上半TERM2, Me.Sum下半TERM2, Me.Sum半TERM合計1, Me.Sum半TERM合計2, Me.Sum五C_MONTH3, Me.Sum六C_MONTH3, Me.Sum七C_MONTH3, Me.Sum八C_MONTH3, Me.Sum九C_MONTH3, Me.Sum十C_MONTH3, Me.Sum十一C_MONTH3, Me.Sum十二C_MONTH3, Me.Sum一C_MONTH3, Me.Sum二C_MONTH3, Me.Sum三C_MONTH3, Me.Sum上半TERM3, Me.Sum下半TERM3, Me.Sum半TERM合計3, Me.Sum五C_MONTH4, Me.Sum六C_MONTH4, Me.Sum七C_MONTH4, Me.Sum八C_MONTH4, Me.Sum九C_MONTH4, Me.Sum十C_MONTH4, Me.Sum十一C_MONTH4, Me.Sum十二C_MONTH4, Me.Sum一C_MONTH4, Me.Sum二C_MONTH4, Me.Sum三C_MONTH4, Me.Sum上半TERM4, Me.Sum下半TERM4, Me.Sum半TERM合計4, Me.Line57, Me.Line69, Me.Line68, Me.Line67, Me.Line65, Me.Line64, Me.Line63, Me.Line62, Me.Line61, Me.Line60, Me.Line59, Me.Line58, Me.Line56, Me.Line55, Me.Line54, Me.Line73, Me.Line74, Me.Line75, Me.Line76, Me.TextBox61})
        Me.GroupFooter1.Height = 0.6027778!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 2.125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label1.Text = "上：当年"
        Me.Label1.Top = 0.5!
        Me.Label1.Width = 0.6875!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label2.Text = "下：前年"
        Me.Label2.Top = 0.6875!
        Me.Label2.Width = 0.6875!
        '
        'Label3
        '
        Me.Label3.Height = 0.3125!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.8125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label3.Text = "4月度"
        Me.Label3.Top = 0.6875!
        Me.Label3.Width = 0.5625!
        '
        'Label4
        '
        Me.Label4.Height = 0.3125!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label4.Text = "5月度"
        Me.Label4.Top = 0.6875!
        Me.Label4.Width = 0.5625!
        '
        'Label5
        '
        Me.Label5.Height = 0.3125!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.9375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label5.Text = "6月度"
        Me.Label5.Top = 0.6875!
        Me.Label5.Width = 0.5625!
        '
        'Label6
        '
        Me.Label6.Height = 0.3125!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.5!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label6.Text = "７月度"
        Me.Label6.Top = 0.6875!
        Me.Label6.Width = 0.5625!
        '
        'Label7
        '
        Me.Label7.Height = 0.3125!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.0625!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label7.Text = "8月度"
        Me.Label7.Top = 0.6875!
        Me.Label7.Width = 0.5625!
        '
        'Label8
        '
        Me.Label8.Height = 0.3125!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.625!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label8.Text = "9月度"
        Me.Label8.Top = 0.6875!
        Me.Label8.Width = 0.5625!
        '
        'Label9
        '
        Me.Label9.Height = 0.3125!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 6.1875!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label9.Text = "10月度"
        Me.Label9.Top = 0.6875!
        Me.Label9.Width = 0.5625!
        '
        'Label10
        '
        Me.Label10.Height = 0.3125!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 6.75!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label10.Text = "11月度"
        Me.Label10.Top = 0.6875!
        Me.Label10.Width = 0.5625!
        '
        'Label11
        '
        Me.Label11.Height = 0.3125!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 7.3125!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label11.Text = "12月度"
        Me.Label11.Top = 0.6875!
        Me.Label11.Width = 0.5625!
        '
        'Label12
        '
        Me.Label12.Height = 0.3125!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 7.875!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label12.Text = "1月度"
        Me.Label12.Top = 0.6875!
        Me.Label12.Width = 0.5625!
        '
        'Label13
        '
        Me.Label13.Height = 0.3125!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 8.4375!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label13.Text = "2月度"
        Me.Label13.Top = 0.6875!
        Me.Label13.Width = 0.5625!
        '
        'Label14
        '
        Me.Label14.Height = 0.3125!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 9!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label14.Text = "3月度"
        Me.Label14.Top = 0.6875!
        Me.Label14.Width = 0.5625!
        '
        'Label16
        '
        Me.Label16.Height = 0.3125!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 9.5625!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label16.Text = "上半期"
        Me.Label16.Top = 0.6875!
        Me.Label16.Width = 0.5625!
        '
        'Label17
        '
        Me.Label17.Height = 0.3125!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 10.125!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label17.Text = "下半期"
        Me.Label17.Top = 0.6875!
        Me.Label17.Width = 0.5625!
        '
        'txtA_YEAR1
        '
        Me.txtA_YEAR1.Height = 0.2!
        Me.txtA_YEAR1.Left = 2.875!
        Me.txtA_YEAR1.Name = "txtA_YEAR1"
        Me.txtA_YEAR1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtA_YEAR1.Text = "年度1"
        Me.txtA_YEAR1.Top = 0.4375!
        Me.txtA_YEAR1.Width = 1!
        '
        'txtA_YEAR2
        '
        Me.txtA_YEAR2.Height = 0.2!
        Me.txtA_YEAR2.Left = 9.6875!
        Me.txtA_YEAR2.Name = "txtA_YEAR2"
        Me.txtA_YEAR2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left"
        Me.txtA_YEAR2.Text = "年度2"
        Me.txtA_YEAR2.Top = 0.4375!
        Me.txtA_YEAR2.Width = 1!
        '
        'txtタイトル
        '
        Me.txtタイトル.Height = 0.2!
        Me.txtタイトル.Left = 0.125!
        Me.txtタイトル.Name = "txtタイトル"
        Me.txtタイトル.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtタイトル.Text = "タイトル"
        Me.txtタイトル.Top = 0.5625!
        Me.txtタイトル.Width = 2!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 9.6875!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: bottom"
        Me.lblDate.Text = "YY.MM.DD"
        Me.lblDate.Top = 0!
        Me.lblDate.Width = 0.5333332!
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 10.2875!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label.Text = "出力"
        Me.Label.Top = 0!
        Me.Label.Width = 0.333333!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 10.6875!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.lblPage.Text = "Page.#"
        Me.lblPage.Top = 0!
        Me.lblPage.Width = 0.4666668!
        '
        'Label21
        '
        Me.Label21.Height = 0.25!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.125!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 14pt; text-align: center"
        Me.Label21.Text = "生産計画・実績対比表"
        Me.Label21.Top = 0.0625!
        Me.Label21.Width = 11.3125!
        '
        'Label24
        '
        Me.Label24.Height = 0.3125!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 10.6875!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label24.Text = "合計"
        Me.Label24.Top = 0.6875!
        Me.Label24.Width = 0.6875!
        '
        'Line48
        '
        Me.Line48.Height = 0.3125!
        Me.Line48.Left = 3.375!
        Me.Line48.LineWeight = 1!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 0.6875!
        Me.Line48.Width = 0!
        Me.Line48.X1 = 3.375!
        Me.Line48.X2 = 3.375!
        Me.Line48.Y1 = 0.6875!
        Me.Line48.Y2 = 1!
        '
        'Line26
        '
        Me.Line26.Height = 0.63!
        Me.Line26.Left = 0.125!
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.375!
        Me.Line26.Width = 0!
        Me.Line26.X1 = 0.125!
        Me.Line26.X2 = 0.125!
        Me.Line26.Y1 = 0.375!
        Me.Line26.Y2 = 1.005!
        '
        'Line5
        '
        Me.Line5.Height = 0.63!
        Me.Line5.Left = 2.125!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.375!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 2.125!
        Me.Line5.X2 = 2.125!
        Me.Line5.Y1 = 0.375!
        Me.Line5.Y2 = 1.005!
        '
        'Line6
        '
        Me.Line6.Height = 0.63!
        Me.Line6.Left = 2.8125!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.375!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 2.8125!
        Me.Line6.X2 = 2.8125!
        Me.Line6.Y1 = 0.375!
        Me.Line6.Y2 = 1.005!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.125!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1!
        Me.Line1.Width = 11.25!
        Me.Line1.X1 = 0.125!
        Me.Line1.X2 = 11.375!
        Me.Line1.Y1 = 1!
        Me.Line1.Y2 = 1!
        '
        'Line21
        '
        Me.Line21.Height = 0.63!
        Me.Line21.Left = 11.375!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.375!
        Me.Line21.Width = 0!
        Me.Line21.X1 = 11.375!
        Me.Line21.X2 = 11.375!
        Me.Line21.Y1 = 0.375!
        Me.Line21.Y2 = 1.005!
        '
        'Line7
        '
        Me.Line7.Height = 0.3125!
        Me.Line7.Left = 3.9375!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.6875!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 3.9375!
        Me.Line7.X2 = 3.9375!
        Me.Line7.Y1 = 0.6875!
        Me.Line7.Y2 = 1!
        '
        'Line8
        '
        Me.Line8.Height = 0.3125!
        Me.Line8.Left = 4.5!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.6875!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 4.5!
        Me.Line8.X2 = 4.5!
        Me.Line8.Y1 = 0.6875!
        Me.Line8.Y2 = 1!
        '
        'Line9
        '
        Me.Line9.Height = 0.3125!
        Me.Line9.Left = 5.0625!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.6875!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 5.0625!
        Me.Line9.X2 = 5.0625!
        Me.Line9.Y1 = 0.6875!
        Me.Line9.Y2 = 1!
        '
        'Line10
        '
        Me.Line10.Height = 0.3125!
        Me.Line10.Left = 5.625!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.6875!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 5.625!
        Me.Line10.X2 = 5.625!
        Me.Line10.Y1 = 0.6875!
        Me.Line10.Y2 = 1!
        '
        'Line11
        '
        Me.Line11.Height = 0.3125!
        Me.Line11.Left = 6.1875!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.6875!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 6.1875!
        Me.Line11.X2 = 6.1875!
        Me.Line11.Y1 = 0.6875!
        Me.Line11.Y2 = 1!
        '
        'Line12
        '
        Me.Line12.Height = 0.3125!
        Me.Line12.Left = 6.75!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.6875!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 6.75!
        Me.Line12.X2 = 6.75!
        Me.Line12.Y1 = 0.6875!
        Me.Line12.Y2 = 1!
        '
        'Line13
        '
        Me.Line13.Height = 0.3125!
        Me.Line13.Left = 7.3125!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.6875!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 7.3125!
        Me.Line13.X2 = 7.3125!
        Me.Line13.Y1 = 0.6875!
        Me.Line13.Y2 = 1!
        '
        'Line14
        '
        Me.Line14.Height = 0.3125!
        Me.Line14.Left = 7.875!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.6875!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 7.875!
        Me.Line14.X2 = 7.875!
        Me.Line14.Y1 = 0.6875!
        Me.Line14.Y2 = 1!
        '
        'Line15
        '
        Me.Line15.Height = 0.3125!
        Me.Line15.Left = 8.4375!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.6875!
        Me.Line15.Width = 0!
        Me.Line15.X1 = 8.4375!
        Me.Line15.X2 = 8.4375!
        Me.Line15.Y1 = 0.6875!
        Me.Line15.Y2 = 1!
        '
        'Line16
        '
        Me.Line16.Height = 0.3125!
        Me.Line16.Left = 9!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.6875!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 9!
        Me.Line16.X2 = 9!
        Me.Line16.Y1 = 0.6875!
        Me.Line16.Y2 = 1!
        '
        'Line17
        '
        Me.Line17.Height = 0.63!
        Me.Line17.Left = 9.5625!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.375!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 9.5625!
        Me.Line17.X2 = 9.5625!
        Me.Line17.Y1 = 0.375!
        Me.Line17.Y2 = 1.005!
        '
        'Line25
        '
        Me.Line25.Height = 0!
        Me.Line25.Left = 0.125!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 0.375!
        Me.Line25.Width = 11.25!
        Me.Line25.X1 = 0.125!
        Me.Line25.X2 = 11.375!
        Me.Line25.Y1 = 0.375!
        Me.Line25.Y2 = 0.375!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 2.8125!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.6875!
        Me.Line.Width = 8.5625!
        Me.Line.X1 = 2.8125!
        Me.Line.X2 = 11.375!
        Me.Line.Y1 = 0.6875!
        Me.Line.Y2 = 0.6875!
        '
        'Line20
        '
        Me.Line20.Height = 0.3125!
        Me.Line20.Left = 10.6875!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.6875!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 10.6875!
        Me.Line20.X2 = 10.6875!
        Me.Line20.Y1 = 0.6875!
        Me.Line20.Y2 = 1!
        '
        'Line18
        '
        Me.Line18.Height = 0.3125!
        Me.Line18.Left = 10.125!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.6875!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 10.125!
        Me.Line18.X2 = 10.125!
        Me.Line18.Y1 = 0.6875!
        Me.Line18.Y2 = 1!
        '
        'Line47
        '
        Me.Line47.Height = 0.6000001!
        Me.Line47.Left = 0.125!
        Me.Line47.LineWeight = 1!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 0!
        Me.Line47.Width = 0!
        Me.Line47.X1 = 0.125!
        Me.Line47.X2 = 0.125!
        Me.Line47.Y1 = 0!
        Me.Line47.Y2 = 0.6000001!
        '
        'Label22
        '
        Me.Label22.Height = 0.15!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 2.125!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label22.Text = "計画"
        Me.Label22.Top = 0.3!
        Me.Label22.Width = 0.6884999!
        '
        'Label23
        '
        Me.Label23.Height = 0.15!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 2.125!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label23.Text = "実績"
        Me.Label23.Top = 0.15!
        Me.Label23.Width = 0.6884999!
        '
        'txt四C_MONTH1
        '
        Me.txt四C_MONTH1.DataField = "四C_MONTH1"
        Me.txt四C_MONTH1.Height = 0.15!
        Me.txt四C_MONTH1.Left = 2.8125!
        Me.txt四C_MONTH1.Name = "txt四C_MONTH1"
        Me.txt四C_MONTH1.OutputFormat = resources.GetString("txt四C_MONTH1.OutputFormat")
        Me.txt四C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt四C_MONTH1.SummaryGroup = "四月1"
        Me.txt四C_MONTH1.Text = "四月1"
        Me.txt四C_MONTH1.Top = 0!
        Me.txt四C_MONTH1.Width = 0.5625!
        '
        'txt五C_MONTH1
        '
        Me.txt五C_MONTH1.DataField = "五C_MONTH1"
        Me.txt五C_MONTH1.Height = 0.15!
        Me.txt五C_MONTH1.Left = 3.375!
        Me.txt五C_MONTH1.Name = "txt五C_MONTH1"
        Me.txt五C_MONTH1.OutputFormat = resources.GetString("txt五C_MONTH1.OutputFormat")
        Me.txt五C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt五C_MONTH1.SummaryGroup = "五月1"
        Me.txt五C_MONTH1.Text = "五月1"
        Me.txt五C_MONTH1.Top = 0!
        Me.txt五C_MONTH1.Width = 0.5625!
        '
        'txt六C_MONTH1
        '
        Me.txt六C_MONTH1.DataField = "六C_MONTH1"
        Me.txt六C_MONTH1.Height = 0.15!
        Me.txt六C_MONTH1.Left = 3.938!
        Me.txt六C_MONTH1.Name = "txt六C_MONTH1"
        Me.txt六C_MONTH1.OutputFormat = resources.GetString("txt六C_MONTH1.OutputFormat")
        Me.txt六C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt六C_MONTH1.SummaryGroup = "六月1"
        Me.txt六C_MONTH1.Text = "六月1"
        Me.txt六C_MONTH1.Top = 0!
        Me.txt六C_MONTH1.Width = 0.5625!
        '
        'txt七C_MONTH1
        '
        Me.txt七C_MONTH1.DataField = "七C_MONTH1"
        Me.txt七C_MONTH1.Height = 0.15!
        Me.txt七C_MONTH1.Left = 4.5!
        Me.txt七C_MONTH1.Name = "txt七C_MONTH1"
        Me.txt七C_MONTH1.OutputFormat = resources.GetString("txt七C_MONTH1.OutputFormat")
        Me.txt七C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt七C_MONTH1.SummaryGroup = "七月1"
        Me.txt七C_MONTH1.Text = "七月1"
        Me.txt七C_MONTH1.Top = 0!
        Me.txt七C_MONTH1.Width = 0.5625!
        '
        'txt八C_MONTH1
        '
        Me.txt八C_MONTH1.DataField = "八C_MONTH1"
        Me.txt八C_MONTH1.Height = 0.15!
        Me.txt八C_MONTH1.Left = 5.0625!
        Me.txt八C_MONTH1.Name = "txt八C_MONTH1"
        Me.txt八C_MONTH1.OutputFormat = resources.GetString("txt八C_MONTH1.OutputFormat")
        Me.txt八C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt八C_MONTH1.SummaryGroup = "八月1"
        Me.txt八C_MONTH1.Text = "八月1"
        Me.txt八C_MONTH1.Top = 0!
        Me.txt八C_MONTH1.Width = 0.5625!
        '
        'txt九C_MONTH1
        '
        Me.txt九C_MONTH1.DataField = "九C_MONTH1"
        Me.txt九C_MONTH1.Height = 0.15!
        Me.txt九C_MONTH1.Left = 5.625!
        Me.txt九C_MONTH1.Name = "txt九C_MONTH1"
        Me.txt九C_MONTH1.OutputFormat = resources.GetString("txt九C_MONTH1.OutputFormat")
        Me.txt九C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt九C_MONTH1.SummaryGroup = "九月1"
        Me.txt九C_MONTH1.Text = "九月1"
        Me.txt九C_MONTH1.Top = 0!
        Me.txt九C_MONTH1.Width = 0.5625!
        '
        'txt十C_MONTH1
        '
        Me.txt十C_MONTH1.DataField = "十C_MONTH1"
        Me.txt十C_MONTH1.Height = 0.15!
        Me.txt十C_MONTH1.Left = 6.1875!
        Me.txt十C_MONTH1.Name = "txt十C_MONTH1"
        Me.txt十C_MONTH1.OutputFormat = resources.GetString("txt十C_MONTH1.OutputFormat")
        Me.txt十C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt十C_MONTH1.SummaryGroup = "十月1"
        Me.txt十C_MONTH1.Text = "十月1"
        Me.txt十C_MONTH1.Top = 0!
        Me.txt十C_MONTH1.Width = 0.5625!
        '
        'txt十一C_MONTH1
        '
        Me.txt十一C_MONTH1.DataField = "十一C_MONTH1"
        Me.txt十一C_MONTH1.Height = 0.15!
        Me.txt十一C_MONTH1.Left = 6.75!
        Me.txt十一C_MONTH1.Name = "txt十一C_MONTH1"
        Me.txt十一C_MONTH1.OutputFormat = resources.GetString("txt十一C_MONTH1.OutputFormat")
        Me.txt十一C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt十一C_MONTH1.SummaryGroup = "十一月1"
        Me.txt十一C_MONTH1.Text = "十一月1"
        Me.txt十一C_MONTH1.Top = 0!
        Me.txt十一C_MONTH1.Width = 0.5625!
        '
        'txt十二C_MONTH1
        '
        Me.txt十二C_MONTH1.DataField = "十二C_MONTH1"
        Me.txt十二C_MONTH1.Height = 0.15!
        Me.txt十二C_MONTH1.Left = 7.3125!
        Me.txt十二C_MONTH1.Name = "txt十二C_MONTH1"
        Me.txt十二C_MONTH1.OutputFormat = resources.GetString("txt十二C_MONTH1.OutputFormat")
        Me.txt十二C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt十二C_MONTH1.SummaryGroup = "十二月1"
        Me.txt十二C_MONTH1.Text = "十二月1"
        Me.txt十二C_MONTH1.Top = 0!
        Me.txt十二C_MONTH1.Width = 0.5625!
        '
        'txt一C_MONTH1
        '
        Me.txt一C_MONTH1.DataField = "一C_MONTH1"
        Me.txt一C_MONTH1.Height = 0.15!
        Me.txt一C_MONTH1.Left = 7.875!
        Me.txt一C_MONTH1.Name = "txt一C_MONTH1"
        Me.txt一C_MONTH1.OutputFormat = resources.GetString("txt一C_MONTH1.OutputFormat")
        Me.txt一C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt一C_MONTH1.SummaryGroup = "一月1"
        Me.txt一C_MONTH1.Text = "一月1"
        Me.txt一C_MONTH1.Top = 0!
        Me.txt一C_MONTH1.Width = 0.5625!
        '
        'txt二C_MONTH1
        '
        Me.txt二C_MONTH1.DataField = "二C_MONTH1"
        Me.txt二C_MONTH1.Height = 0.15!
        Me.txt二C_MONTH1.Left = 8.4375!
        Me.txt二C_MONTH1.Name = "txt二C_MONTH1"
        Me.txt二C_MONTH1.OutputFormat = resources.GetString("txt二C_MONTH1.OutputFormat")
        Me.txt二C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt二C_MONTH1.SummaryGroup = "二月1"
        Me.txt二C_MONTH1.Text = "二月1"
        Me.txt二C_MONTH1.Top = 0!
        Me.txt二C_MONTH1.Width = 0.5625!
        '
        'txt三C_MONTH1
        '
        Me.txt三C_MONTH1.DataField = "三C_MONTH1"
        Me.txt三C_MONTH1.Height = 0.15!
        Me.txt三C_MONTH1.Left = 9!
        Me.txt三C_MONTH1.Name = "txt三C_MONTH1"
        Me.txt三C_MONTH1.OutputFormat = resources.GetString("txt三C_MONTH1.OutputFormat")
        Me.txt三C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt三C_MONTH1.SummaryGroup = "三月1"
        Me.txt三C_MONTH1.Text = "三月1"
        Me.txt三C_MONTH1.Top = 0!
        Me.txt三C_MONTH1.Width = 0.5625!
        '
        'txt上半TERM1
        '
        Me.txt上半TERM1.DataField = "上半TERM1"
        Me.txt上半TERM1.Height = 0.15!
        Me.txt上半TERM1.Left = 9.557292!
        Me.txt上半TERM1.Name = "txt上半TERM1"
        Me.txt上半TERM1.OutputFormat = resources.GetString("txt上半TERM1.OutputFormat")
        Me.txt上半TERM1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt上半TERM1.SummaryGroup = "上半期1"
        Me.txt上半TERM1.Text = "上半期1"
        Me.txt上半TERM1.Top = 0!
        Me.txt上半TERM1.Width = 0.5625!
        '
        'txt下半TERM1
        '
        Me.txt下半TERM1.DataField = "下半TERM1"
        Me.txt下半TERM1.Height = 0.15!
        Me.txt下半TERM1.Left = 10.125!
        Me.txt下半TERM1.Name = "txt下半TERM1"
        Me.txt下半TERM1.OutputFormat = resources.GetString("txt下半TERM1.OutputFormat")
        Me.txt下半TERM1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt下半TERM1.SummaryGroup = "下半期1"
        Me.txt下半TERM1.Text = "下半期1"
        Me.txt下半TERM1.Top = 0!
        Me.txt下半TERM1.Width = 0.5625!
        '
        'txt四C_MONTH2
        '
        Me.txt四C_MONTH2.DataField = "四C_MONTH2"
        Me.txt四C_MONTH2.Height = 0.15!
        Me.txt四C_MONTH2.Left = 2.8125!
        Me.txt四C_MONTH2.Name = "txt四C_MONTH2"
        Me.txt四C_MONTH2.OutputFormat = resources.GetString("txt四C_MONTH2.OutputFormat")
        Me.txt四C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt四C_MONTH2.SummaryGroup = "四月2"
        Me.txt四C_MONTH2.Text = "四月2"
        Me.txt四C_MONTH2.Top = 0.15!
        Me.txt四C_MONTH2.Width = 0.5625!
        '
        'txt五C_MONTH2
        '
        Me.txt五C_MONTH2.DataField = "五C_MONTH2"
        Me.txt五C_MONTH2.Height = 0.15!
        Me.txt五C_MONTH2.Left = 3.375!
        Me.txt五C_MONTH2.Name = "txt五C_MONTH2"
        Me.txt五C_MONTH2.OutputFormat = resources.GetString("txt五C_MONTH2.OutputFormat")
        Me.txt五C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt五C_MONTH2.SummaryGroup = "五月2"
        Me.txt五C_MONTH2.Text = "五月2"
        Me.txt五C_MONTH2.Top = 0.15!
        Me.txt五C_MONTH2.Width = 0.5625!
        '
        'txt六C_MONTH2
        '
        Me.txt六C_MONTH2.DataField = "六C_MONTH2"
        Me.txt六C_MONTH2.Height = 0.15!
        Me.txt六C_MONTH2.Left = 3.9375!
        Me.txt六C_MONTH2.Name = "txt六C_MONTH2"
        Me.txt六C_MONTH2.OutputFormat = resources.GetString("txt六C_MONTH2.OutputFormat")
        Me.txt六C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt六C_MONTH2.SummaryGroup = "六月2"
        Me.txt六C_MONTH2.Text = "六月2"
        Me.txt六C_MONTH2.Top = 0.15!
        Me.txt六C_MONTH2.Width = 0.5625!
        '
        'txt七C_MONTH2
        '
        Me.txt七C_MONTH2.DataField = "七C_MONTH2"
        Me.txt七C_MONTH2.Height = 0.15!
        Me.txt七C_MONTH2.Left = 4.5!
        Me.txt七C_MONTH2.Name = "txt七C_MONTH2"
        Me.txt七C_MONTH2.OutputFormat = resources.GetString("txt七C_MONTH2.OutputFormat")
        Me.txt七C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt七C_MONTH2.SummaryGroup = "七月2"
        Me.txt七C_MONTH2.Text = "七月2"
        Me.txt七C_MONTH2.Top = 0.15!
        Me.txt七C_MONTH2.Width = 0.5625!
        '
        'txt八C_MONTH2
        '
        Me.txt八C_MONTH2.DataField = "八C_MONTH2"
        Me.txt八C_MONTH2.Height = 0.15!
        Me.txt八C_MONTH2.Left = 5.0625!
        Me.txt八C_MONTH2.Name = "txt八C_MONTH2"
        Me.txt八C_MONTH2.OutputFormat = resources.GetString("txt八C_MONTH2.OutputFormat")
        Me.txt八C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt八C_MONTH2.SummaryGroup = "八月2"
        Me.txt八C_MONTH2.Text = "八月2"
        Me.txt八C_MONTH2.Top = 0.15!
        Me.txt八C_MONTH2.Width = 0.5625!
        '
        'txt九C_MONTH2
        '
        Me.txt九C_MONTH2.DataField = "九C_MONTH2"
        Me.txt九C_MONTH2.Height = 0.15!
        Me.txt九C_MONTH2.Left = 5.625!
        Me.txt九C_MONTH2.Name = "txt九C_MONTH2"
        Me.txt九C_MONTH2.OutputFormat = resources.GetString("txt九C_MONTH2.OutputFormat")
        Me.txt九C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt九C_MONTH2.SummaryGroup = "九月2"
        Me.txt九C_MONTH2.Text = "九月2"
        Me.txt九C_MONTH2.Top = 0.15!
        Me.txt九C_MONTH2.Width = 0.5625!
        '
        'txt十C_MONTH2
        '
        Me.txt十C_MONTH2.DataField = "十C_MONTH2"
        Me.txt十C_MONTH2.Height = 0.15!
        Me.txt十C_MONTH2.Left = 6.1875!
        Me.txt十C_MONTH2.Name = "txt十C_MONTH2"
        Me.txt十C_MONTH2.OutputFormat = resources.GetString("txt十C_MONTH2.OutputFormat")
        Me.txt十C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt十C_MONTH2.SummaryGroup = "十月2"
        Me.txt十C_MONTH2.Text = "十月2"
        Me.txt十C_MONTH2.Top = 0.15!
        Me.txt十C_MONTH2.Width = 0.5625!
        '
        'txt十一C_MONTH2
        '
        Me.txt十一C_MONTH2.DataField = "十一C_MONTH2"
        Me.txt十一C_MONTH2.Height = 0.15!
        Me.txt十一C_MONTH2.Left = 6.75!
        Me.txt十一C_MONTH2.Name = "txt十一C_MONTH2"
        Me.txt十一C_MONTH2.OutputFormat = resources.GetString("txt十一C_MONTH2.OutputFormat")
        Me.txt十一C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt十一C_MONTH2.SummaryGroup = "十一月1"
        Me.txt十一C_MONTH2.Text = "十一月2"
        Me.txt十一C_MONTH2.Top = 0.15!
        Me.txt十一C_MONTH2.Width = 0.5625!
        '
        'txt十二C_MONTH2
        '
        Me.txt十二C_MONTH2.DataField = "十二C_MONTH2"
        Me.txt十二C_MONTH2.Height = 0.15!
        Me.txt十二C_MONTH2.Left = 7.3125!
        Me.txt十二C_MONTH2.Name = "txt十二C_MONTH2"
        Me.txt十二C_MONTH2.OutputFormat = resources.GetString("txt十二C_MONTH2.OutputFormat")
        Me.txt十二C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt十二C_MONTH2.SummaryGroup = "十二月2"
        Me.txt十二C_MONTH2.Text = "十二月2"
        Me.txt十二C_MONTH2.Top = 0.15!
        Me.txt十二C_MONTH2.Width = 0.5625!
        '
        'txt一C_MONTH2
        '
        Me.txt一C_MONTH2.DataField = "一C_MONTH2"
        Me.txt一C_MONTH2.Height = 0.15!
        Me.txt一C_MONTH2.Left = 7.875!
        Me.txt一C_MONTH2.Name = "txt一C_MONTH2"
        Me.txt一C_MONTH2.OutputFormat = resources.GetString("txt一C_MONTH2.OutputFormat")
        Me.txt一C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt一C_MONTH2.SummaryGroup = "一月2"
        Me.txt一C_MONTH2.Text = "一月2"
        Me.txt一C_MONTH2.Top = 0.15!
        Me.txt一C_MONTH2.Width = 0.5625!
        '
        'txt二C_MONTH2
        '
        Me.txt二C_MONTH2.DataField = "二C_MONTH2"
        Me.txt二C_MONTH2.Height = 0.15!
        Me.txt二C_MONTH2.Left = 8.4375!
        Me.txt二C_MONTH2.Name = "txt二C_MONTH2"
        Me.txt二C_MONTH2.OutputFormat = resources.GetString("txt二C_MONTH2.OutputFormat")
        Me.txt二C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt二C_MONTH2.SummaryGroup = "二月2"
        Me.txt二C_MONTH2.Text = "二月2"
        Me.txt二C_MONTH2.Top = 0.15!
        Me.txt二C_MONTH2.Width = 0.5625!
        '
        'txt三C_MONTH2
        '
        Me.txt三C_MONTH2.DataField = "三C_MONTH2"
        Me.txt三C_MONTH2.Height = 0.15!
        Me.txt三C_MONTH2.Left = 9!
        Me.txt三C_MONTH2.Name = "txt三C_MONTH2"
        Me.txt三C_MONTH2.OutputFormat = resources.GetString("txt三C_MONTH2.OutputFormat")
        Me.txt三C_MONTH2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt三C_MONTH2.SummaryGroup = "三月2"
        Me.txt三C_MONTH2.Text = "三月2"
        Me.txt三C_MONTH2.Top = 0.15!
        Me.txt三C_MONTH2.Width = 0.5625!
        '
        'txt上半TERM2
        '
        Me.txt上半TERM2.DataField = "上半TERM2"
        Me.txt上半TERM2.Height = 0.15!
        Me.txt上半TERM2.Left = 9.5625!
        Me.txt上半TERM2.Name = "txt上半TERM2"
        Me.txt上半TERM2.OutputFormat = resources.GetString("txt上半TERM2.OutputFormat")
        Me.txt上半TERM2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt上半TERM2.SummaryGroup = "上半期2"
        Me.txt上半TERM2.Text = "上半期2"
        Me.txt上半TERM2.Top = 0.15!
        Me.txt上半TERM2.Width = 0.5625!
        '
        'txt下半TERM2
        '
        Me.txt下半TERM2.DataField = "下半TERM2"
        Me.txt下半TERM2.Height = 0.15!
        Me.txt下半TERM2.Left = 10.125!
        Me.txt下半TERM2.Name = "txt下半TERM2"
        Me.txt下半TERM2.OutputFormat = resources.GetString("txt下半TERM2.OutputFormat")
        Me.txt下半TERM2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt下半TERM2.SummaryGroup = "下半期2"
        Me.txt下半TERM2.Text = "下半期2"
        Me.txt下半TERM2.Top = 0.15!
        Me.txt下半TERM2.Width = 0.5625!
        '
        'txt名称
        '
        Me.txt名称.DataField = "名称1"
        Me.txt名称.Height = 0.2!
        Me.txt名称.Left = 0.1875!
        Me.txt名称.Name = "txt名称"
        Me.txt名称.Style = "font-family: ＭＳ ゴシック; ddo-char-set: 1"
        Me.txt名称.Text = "名称1"
        Me.txt名称.Top = 0.0625!
        Me.txt名称.Width = 1.6875!
        '
        'txt半TERM合計1
        '
        Me.txt半TERM合計1.DataField = "合計1"
        Me.txt半TERM合計1.Height = 0.15!
        Me.txt半TERM合計1.Left = 10.6875!
        Me.txt半TERM合計1.Name = "txt半TERM合計1"
        Me.txt半TERM合計1.OutputFormat = resources.GetString("txt半TERM合計1.OutputFormat")
        Me.txt半TERM合計1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt半TERM合計1.SummaryGroup = "半期合計1"
        Me.txt半TERM合計1.Text = "半期合計1"
        Me.txt半TERM合計1.Top = 0!
        Me.txt半TERM合計1.Width = 0.6875!
        '
        'txt半TERM合計2
        '
        Me.txt半TERM合計2.DataField = "合計2"
        Me.txt半TERM合計2.Height = 0.15!
        Me.txt半TERM合計2.Left = 10.6875!
        Me.txt半TERM合計2.Name = "txt半TERM合計2"
        Me.txt半TERM合計2.OutputFormat = resources.GetString("txt半TERM合計2.OutputFormat")
        Me.txt半TERM合計2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt半TERM合計2.SummaryGroup = "半期合計2"
        Me.txt半TERM合計2.Text = "半期合計2"
        Me.txt半TERM合計2.Top = 0.15!
        Me.txt半TERM合計2.Width = 0.6875!
        '
        'txt四C_MONTH3
        '
        Me.txt四C_MONTH3.DataField = "四C_MONTH3"
        Me.txt四C_MONTH3.Height = 0.15!
        Me.txt四C_MONTH3.Left = 2.8125!
        Me.txt四C_MONTH3.Name = "txt四C_MONTH3"
        Me.txt四C_MONTH3.OutputFormat = resources.GetString("txt四C_MONTH3.OutputFormat")
        Me.txt四C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt四C_MONTH3.SummaryGroup = "四月3"
        Me.txt四C_MONTH3.Text = "四月3"
        Me.txt四C_MONTH3.Top = 0.3!
        Me.txt四C_MONTH3.Width = 0.5625!
        '
        'txt五C_MONTH3
        '
        Me.txt五C_MONTH3.DataField = "五C_MONTH3"
        Me.txt五C_MONTH3.Height = 0.15!
        Me.txt五C_MONTH3.Left = 3.375!
        Me.txt五C_MONTH3.Name = "txt五C_MONTH3"
        Me.txt五C_MONTH3.OutputFormat = resources.GetString("txt五C_MONTH3.OutputFormat")
        Me.txt五C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt五C_MONTH3.SummaryGroup = "五月3"
        Me.txt五C_MONTH3.Text = "五月3"
        Me.txt五C_MONTH3.Top = 0.3!
        Me.txt五C_MONTH3.Width = 0.5625!
        '
        'txt六C_MONTH3
        '
        Me.txt六C_MONTH3.DataField = "六C_MONTH3"
        Me.txt六C_MONTH3.Height = 0.15!
        Me.txt六C_MONTH3.Left = 3.9375!
        Me.txt六C_MONTH3.Name = "txt六C_MONTH3"
        Me.txt六C_MONTH3.OutputFormat = resources.GetString("txt六C_MONTH3.OutputFormat")
        Me.txt六C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt六C_MONTH3.SummaryGroup = "六月3"
        Me.txt六C_MONTH3.Text = "六月3"
        Me.txt六C_MONTH3.Top = 0.3!
        Me.txt六C_MONTH3.Width = 0.5625!
        '
        'txt七C_MONTH3
        '
        Me.txt七C_MONTH3.DataField = "七C_MONTH3"
        Me.txt七C_MONTH3.Height = 0.15!
        Me.txt七C_MONTH3.Left = 4.5!
        Me.txt七C_MONTH3.Name = "txt七C_MONTH3"
        Me.txt七C_MONTH3.OutputFormat = resources.GetString("txt七C_MONTH3.OutputFormat")
        Me.txt七C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt七C_MONTH3.SummaryGroup = "七月3"
        Me.txt七C_MONTH3.Text = "七月3"
        Me.txt七C_MONTH3.Top = 0.3!
        Me.txt七C_MONTH3.Width = 0.5625!
        '
        'txt八C_MONTH3
        '
        Me.txt八C_MONTH3.DataField = "八C_MONTH3"
        Me.txt八C_MONTH3.Height = 0.15!
        Me.txt八C_MONTH3.Left = 5.0625!
        Me.txt八C_MONTH3.Name = "txt八C_MONTH3"
        Me.txt八C_MONTH3.OutputFormat = resources.GetString("txt八C_MONTH3.OutputFormat")
        Me.txt八C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt八C_MONTH3.SummaryGroup = "八月3"
        Me.txt八C_MONTH3.Text = "八月3"
        Me.txt八C_MONTH3.Top = 0.3!
        Me.txt八C_MONTH3.Width = 0.5625!
        '
        'txt九C_MONTH3
        '
        Me.txt九C_MONTH3.DataField = "九C_MONTH3"
        Me.txt九C_MONTH3.Height = 0.15!
        Me.txt九C_MONTH3.Left = 5.625!
        Me.txt九C_MONTH3.Name = "txt九C_MONTH3"
        Me.txt九C_MONTH3.OutputFormat = resources.GetString("txt九C_MONTH3.OutputFormat")
        Me.txt九C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt九C_MONTH3.SummaryGroup = "九月3"
        Me.txt九C_MONTH3.Text = "九月3"
        Me.txt九C_MONTH3.Top = 0.3!
        Me.txt九C_MONTH3.Width = 0.5625!
        '
        'txt十C_MONTH3
        '
        Me.txt十C_MONTH3.DataField = "十C_MONTH3"
        Me.txt十C_MONTH3.Height = 0.15!
        Me.txt十C_MONTH3.Left = 6.1875!
        Me.txt十C_MONTH3.Name = "txt十C_MONTH3"
        Me.txt十C_MONTH3.OutputFormat = resources.GetString("txt十C_MONTH3.OutputFormat")
        Me.txt十C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt十C_MONTH3.SummaryGroup = "十月3"
        Me.txt十C_MONTH3.Text = "十月3"
        Me.txt十C_MONTH3.Top = 0.3!
        Me.txt十C_MONTH3.Width = 0.5625!
        '
        'txt十一C_MONTH3
        '
        Me.txt十一C_MONTH3.DataField = "十一C_MONTH3"
        Me.txt十一C_MONTH3.Height = 0.15!
        Me.txt十一C_MONTH3.Left = 6.75!
        Me.txt十一C_MONTH3.Name = "txt十一C_MONTH3"
        Me.txt十一C_MONTH3.OutputFormat = resources.GetString("txt十一C_MONTH3.OutputFormat")
        Me.txt十一C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt十一C_MONTH3.SummaryGroup = "十一月3"
        Me.txt十一C_MONTH3.Text = "十一月3"
        Me.txt十一C_MONTH3.Top = 0.3!
        Me.txt十一C_MONTH3.Width = 0.5625!
        '
        'txt十二C_MONTH3
        '
        Me.txt十二C_MONTH3.DataField = "十二C_MONTH3"
        Me.txt十二C_MONTH3.Height = 0.15!
        Me.txt十二C_MONTH3.Left = 7.3125!
        Me.txt十二C_MONTH3.Name = "txt十二C_MONTH3"
        Me.txt十二C_MONTH3.OutputFormat = resources.GetString("txt十二C_MONTH3.OutputFormat")
        Me.txt十二C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt十二C_MONTH3.SummaryGroup = "十二月3"
        Me.txt十二C_MONTH3.Text = "十二月3"
        Me.txt十二C_MONTH3.Top = 0.3!
        Me.txt十二C_MONTH3.Width = 0.5625!
        '
        'txt一C_MONTH3
        '
        Me.txt一C_MONTH3.DataField = "一C_MONTH3"
        Me.txt一C_MONTH3.Height = 0.15!
        Me.txt一C_MONTH3.Left = 7.875!
        Me.txt一C_MONTH3.Name = "txt一C_MONTH3"
        Me.txt一C_MONTH3.OutputFormat = resources.GetString("txt一C_MONTH3.OutputFormat")
        Me.txt一C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt一C_MONTH3.SummaryGroup = "一月3"
        Me.txt一C_MONTH3.Text = "一月3"
        Me.txt一C_MONTH3.Top = 0.3!
        Me.txt一C_MONTH3.Width = 0.5625!
        '
        'txt二C_MONTH3
        '
        Me.txt二C_MONTH3.DataField = "二C_MONTH3"
        Me.txt二C_MONTH3.Height = 0.15!
        Me.txt二C_MONTH3.Left = 8.4375!
        Me.txt二C_MONTH3.Name = "txt二C_MONTH3"
        Me.txt二C_MONTH3.OutputFormat = resources.GetString("txt二C_MONTH3.OutputFormat")
        Me.txt二C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt二C_MONTH3.SummaryGroup = "二月3"
        Me.txt二C_MONTH3.Text = "二月3"
        Me.txt二C_MONTH3.Top = 0.3!
        Me.txt二C_MONTH3.Width = 0.5625!
        '
        'txt三C_MONTH3
        '
        Me.txt三C_MONTH3.DataField = "三C_MONTH3"
        Me.txt三C_MONTH3.Height = 0.15!
        Me.txt三C_MONTH3.Left = 9!
        Me.txt三C_MONTH3.Name = "txt三C_MONTH3"
        Me.txt三C_MONTH3.OutputFormat = resources.GetString("txt三C_MONTH3.OutputFormat")
        Me.txt三C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt三C_MONTH3.SummaryGroup = "三月3"
        Me.txt三C_MONTH3.Text = "三月3"
        Me.txt三C_MONTH3.Top = 0.3!
        Me.txt三C_MONTH3.Width = 0.5625!
        '
        'txt上半TERM3
        '
        Me.txt上半TERM3.DataField = "上半TERM3"
        Me.txt上半TERM3.Height = 0.15!
        Me.txt上半TERM3.Left = 9.5625!
        Me.txt上半TERM3.Name = "txt上半TERM3"
        Me.txt上半TERM3.OutputFormat = resources.GetString("txt上半TERM3.OutputFormat")
        Me.txt上半TERM3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt上半TERM3.SummaryGroup = "上半期3"
        Me.txt上半TERM3.Text = "上半期3"
        Me.txt上半TERM3.Top = 0.3!
        Me.txt上半TERM3.Width = 0.5625!
        '
        'txt下半TERM3
        '
        Me.txt下半TERM3.DataField = "下半TERM3"
        Me.txt下半TERM3.Height = 0.15!
        Me.txt下半TERM3.Left = 10.125!
        Me.txt下半TERM3.Name = "txt下半TERM3"
        Me.txt下半TERM3.OutputFormat = resources.GetString("txt下半TERM3.OutputFormat")
        Me.txt下半TERM3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt下半TERM3.SummaryGroup = "下半期3"
        Me.txt下半TERM3.Text = "下半期3"
        Me.txt下半TERM3.Top = 0.3!
        Me.txt下半TERM3.Width = 0.5625!
        '
        'Label25
        '
        Me.Label25.Height = 0.15!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 2.125!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label25.Text = "計画"
        Me.Label25.Top = 0!
        Me.Label25.Width = 0.688!
        '
        'Label26
        '
        Me.Label26.Height = 0.15!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 2.125!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label26.Text = "実績"
        Me.Label26.Top = 0.45!
        Me.Label26.Width = 0.6884999!
        '
        'txt半TERM合計3
        '
        Me.txt半TERM合計3.DataField = "合計3"
        Me.txt半TERM合計3.Height = 0.15!
        Me.txt半TERM合計3.Left = 10.6875!
        Me.txt半TERM合計3.Name = "txt半TERM合計3"
        Me.txt半TERM合計3.OutputFormat = resources.GetString("txt半TERM合計3.OutputFormat")
        Me.txt半TERM合計3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.txt半TERM合計3.SummaryGroup = "半期合計3"
        Me.txt半TERM合計3.Text = "半期合計3"
        Me.txt半TERM合計3.Top = 0.3!
        Me.txt半TERM合計3.Width = 0.6875!
        '
        'txt四C_MONTH4
        '
        Me.txt四C_MONTH4.DataField = "四C_MONTH4"
        Me.txt四C_MONTH4.Height = 0.15!
        Me.txt四C_MONTH4.Left = 2.8125!
        Me.txt四C_MONTH4.Name = "txt四C_MONTH4"
        Me.txt四C_MONTH4.OutputFormat = resources.GetString("txt四C_MONTH4.OutputFormat")
        Me.txt四C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt四C_MONTH4.SummaryGroup = "四月4"
        Me.txt四C_MONTH4.Text = "四月4"
        Me.txt四C_MONTH4.Top = 0.45!
        Me.txt四C_MONTH4.Width = 0.5625!
        '
        'txt五C_MONTH4
        '
        Me.txt五C_MONTH4.DataField = "五C_MONTH4"
        Me.txt五C_MONTH4.Height = 0.15!
        Me.txt五C_MONTH4.Left = 3.375!
        Me.txt五C_MONTH4.Name = "txt五C_MONTH4"
        Me.txt五C_MONTH4.OutputFormat = resources.GetString("txt五C_MONTH4.OutputFormat")
        Me.txt五C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt五C_MONTH4.SummaryGroup = "五月4"
        Me.txt五C_MONTH4.Text = "五月4"
        Me.txt五C_MONTH4.Top = 0.45!
        Me.txt五C_MONTH4.Width = 0.5625!
        '
        'txt六C_MONTH4
        '
        Me.txt六C_MONTH4.DataField = "六C_MONTH4"
        Me.txt六C_MONTH4.Height = 0.15!
        Me.txt六C_MONTH4.Left = 3.9375!
        Me.txt六C_MONTH4.Name = "txt六C_MONTH4"
        Me.txt六C_MONTH4.OutputFormat = resources.GetString("txt六C_MONTH4.OutputFormat")
        Me.txt六C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt六C_MONTH4.SummaryGroup = "六月4"
        Me.txt六C_MONTH4.Text = "六月4"
        Me.txt六C_MONTH4.Top = 0.45!
        Me.txt六C_MONTH4.Width = 0.5625!
        '
        'txt七C_MONTH4
        '
        Me.txt七C_MONTH4.DataField = "七C_MONTH4"
        Me.txt七C_MONTH4.Height = 0.15!
        Me.txt七C_MONTH4.Left = 4.5!
        Me.txt七C_MONTH4.Name = "txt七C_MONTH4"
        Me.txt七C_MONTH4.OutputFormat = resources.GetString("txt七C_MONTH4.OutputFormat")
        Me.txt七C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt七C_MONTH4.SummaryGroup = "七月4"
        Me.txt七C_MONTH4.Text = "七月4"
        Me.txt七C_MONTH4.Top = 0.45!
        Me.txt七C_MONTH4.Width = 0.5625!
        '
        'txt八C_MONTH4
        '
        Me.txt八C_MONTH4.DataField = "八C_MONTH4"
        Me.txt八C_MONTH4.Height = 0.15!
        Me.txt八C_MONTH4.Left = 5.0625!
        Me.txt八C_MONTH4.Name = "txt八C_MONTH4"
        Me.txt八C_MONTH4.OutputFormat = resources.GetString("txt八C_MONTH4.OutputFormat")
        Me.txt八C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt八C_MONTH4.SummaryGroup = "八月4"
        Me.txt八C_MONTH4.Text = "八月4"
        Me.txt八C_MONTH4.Top = 0.45!
        Me.txt八C_MONTH4.Width = 0.5625!
        '
        'txt九C_MONTH4
        '
        Me.txt九C_MONTH4.DataField = "九C_MONTH4"
        Me.txt九C_MONTH4.Height = 0.15!
        Me.txt九C_MONTH4.Left = 5.625!
        Me.txt九C_MONTH4.Name = "txt九C_MONTH4"
        Me.txt九C_MONTH4.OutputFormat = resources.GetString("txt九C_MONTH4.OutputFormat")
        Me.txt九C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt九C_MONTH4.SummaryGroup = "九月4"
        Me.txt九C_MONTH4.Text = "九月4"
        Me.txt九C_MONTH4.Top = 0.45!
        Me.txt九C_MONTH4.Width = 0.5625!
        '
        'txt十C_MONTH4
        '
        Me.txt十C_MONTH4.DataField = "十C_MONTH4"
        Me.txt十C_MONTH4.Height = 0.15!
        Me.txt十C_MONTH4.Left = 6.1875!
        Me.txt十C_MONTH4.Name = "txt十C_MONTH4"
        Me.txt十C_MONTH4.OutputFormat = resources.GetString("txt十C_MONTH4.OutputFormat")
        Me.txt十C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt十C_MONTH4.SummaryGroup = "十月4"
        Me.txt十C_MONTH4.Text = "十月4"
        Me.txt十C_MONTH4.Top = 0.45!
        Me.txt十C_MONTH4.Width = 0.5625!
        '
        'txt十一C_MONTH4
        '
        Me.txt十一C_MONTH4.DataField = "十一C_MONTH4"
        Me.txt十一C_MONTH4.Height = 0.15!
        Me.txt十一C_MONTH4.Left = 6.75!
        Me.txt十一C_MONTH4.Name = "txt十一C_MONTH4"
        Me.txt十一C_MONTH4.OutputFormat = resources.GetString("txt十一C_MONTH4.OutputFormat")
        Me.txt十一C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt十一C_MONTH4.SummaryGroup = "十一月4"
        Me.txt十一C_MONTH4.Text = "十一月4"
        Me.txt十一C_MONTH4.Top = 0.45!
        Me.txt十一C_MONTH4.Width = 0.5625!
        '
        'txt十二C_MONTH4
        '
        Me.txt十二C_MONTH4.DataField = "十二C_MONTH4"
        Me.txt十二C_MONTH4.Height = 0.15!
        Me.txt十二C_MONTH4.Left = 7.3125!
        Me.txt十二C_MONTH4.Name = "txt十二C_MONTH4"
        Me.txt十二C_MONTH4.OutputFormat = resources.GetString("txt十二C_MONTH4.OutputFormat")
        Me.txt十二C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt十二C_MONTH4.SummaryGroup = "十二月4"
        Me.txt十二C_MONTH4.Text = "十二月4"
        Me.txt十二C_MONTH4.Top = 0.45!
        Me.txt十二C_MONTH4.Width = 0.5625!
        '
        'txt一C_MONTH4
        '
        Me.txt一C_MONTH4.DataField = "一C_MONTH4"
        Me.txt一C_MONTH4.Height = 0.15!
        Me.txt一C_MONTH4.Left = 7.875!
        Me.txt一C_MONTH4.Name = "txt一C_MONTH4"
        Me.txt一C_MONTH4.OutputFormat = resources.GetString("txt一C_MONTH4.OutputFormat")
        Me.txt一C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt一C_MONTH4.SummaryGroup = "一月4"
        Me.txt一C_MONTH4.Text = "一月4"
        Me.txt一C_MONTH4.Top = 0.45!
        Me.txt一C_MONTH4.Width = 0.5625!
        '
        'txt二C_MONTH4
        '
        Me.txt二C_MONTH4.DataField = "二C_MONTH4"
        Me.txt二C_MONTH4.Height = 0.15!
        Me.txt二C_MONTH4.Left = 8.4375!
        Me.txt二C_MONTH4.Name = "txt二C_MONTH4"
        Me.txt二C_MONTH4.OutputFormat = resources.GetString("txt二C_MONTH4.OutputFormat")
        Me.txt二C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt二C_MONTH4.SummaryGroup = "二月4"
        Me.txt二C_MONTH4.Text = "二月4"
        Me.txt二C_MONTH4.Top = 0.45!
        Me.txt二C_MONTH4.Width = 0.5625!
        '
        'txt三C_MONTH4
        '
        Me.txt三C_MONTH4.DataField = "三C_MONTH4"
        Me.txt三C_MONTH4.Height = 0.15!
        Me.txt三C_MONTH4.Left = 9!
        Me.txt三C_MONTH4.Name = "txt三C_MONTH4"
        Me.txt三C_MONTH4.OutputFormat = resources.GetString("txt三C_MONTH4.OutputFormat")
        Me.txt三C_MONTH4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt三C_MONTH4.SummaryGroup = "三月4"
        Me.txt三C_MONTH4.Text = "三月4"
        Me.txt三C_MONTH4.Top = 0.45!
        Me.txt三C_MONTH4.Width = 0.5625!
        '
        'txt上半TERM4
        '
        Me.txt上半TERM4.DataField = "上半TERM4"
        Me.txt上半TERM4.Height = 0.15!
        Me.txt上半TERM4.Left = 9.5625!
        Me.txt上半TERM4.Name = "txt上半TERM4"
        Me.txt上半TERM4.OutputFormat = resources.GetString("txt上半TERM4.OutputFormat")
        Me.txt上半TERM4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt上半TERM4.SummaryGroup = "上半期4"
        Me.txt上半TERM4.Text = "上半期4"
        Me.txt上半TERM4.Top = 0.45!
        Me.txt上半TERM4.Width = 0.5625!
        '
        'txt下半TERM4
        '
        Me.txt下半TERM4.DataField = "下半TERM4"
        Me.txt下半TERM4.Height = 0.15!
        Me.txt下半TERM4.Left = 10.125!
        Me.txt下半TERM4.Name = "txt下半TERM4"
        Me.txt下半TERM4.OutputFormat = resources.GetString("txt下半TERM4.OutputFormat")
        Me.txt下半TERM4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt下半TERM4.SummaryGroup = "下半期4"
        Me.txt下半TERM4.Text = "下半期4"
        Me.txt下半TERM4.Top = 0.45!
        Me.txt下半TERM4.Width = 0.5625!
        '
        'txt半TERM合計4
        '
        Me.txt半TERM合計4.DataField = "合計4"
        Me.txt半TERM合計4.Height = 0.15!
        Me.txt半TERM合計4.Left = 10.6875!
        Me.txt半TERM合計4.Name = "txt半TERM合計4"
        Me.txt半TERM合計4.OutputFormat = resources.GetString("txt半TERM合計4.OutputFormat")
        Me.txt半TERM合計4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.txt半TERM合計4.SummaryGroup = "半期合計4"
        Me.txt半TERM合計4.Text = "半期合計4"
        Me.txt半TERM合計4.Top = 0.45!
        Me.txt半TERM合計4.Width = 0.6875!
        '
        'Line27
        '
        Me.Line27.Height = 0.6000001!
        Me.Line27.Left = 2.8125!
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 0!
        Me.Line27.Width = 0!
        Me.Line27.X1 = 2.8125!
        Me.Line27.X2 = 2.8125!
        Me.Line27.Y1 = 0!
        Me.Line27.Y2 = 0.6000001!
        '
        'Line3
        '
        Me.Line3.Height = 0!
        Me.Line3.Left = 0.125!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.6000001!
        Me.Line3.Width = 11.25!
        Me.Line3.X1 = 0.125!
        Me.Line3.X2 = 11.375!
        Me.Line3.Y1 = 0.6000001!
        Me.Line3.Y2 = 0.6000001!
        '
        'Line28
        '
        Me.Line28.Height = 0.6000001!
        Me.Line28.Left = 3.375!
        Me.Line28.LineWeight = 1!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 0!
        Me.Line28.Width = 0!
        Me.Line28.X1 = 3.375!
        Me.Line28.X2 = 3.375!
        Me.Line28.Y1 = 0!
        Me.Line28.Y2 = 0.6000001!
        '
        'Line29
        '
        Me.Line29.Height = 0.6000001!
        Me.Line29.Left = 3.9375!
        Me.Line29.LineWeight = 1!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 0!
        Me.Line29.Width = 0!
        Me.Line29.X1 = 3.9375!
        Me.Line29.X2 = 3.9375!
        Me.Line29.Y1 = 0!
        Me.Line29.Y2 = 0.6000001!
        '
        'Line30
        '
        Me.Line30.Height = 0.6000001!
        Me.Line30.Left = 4.5!
        Me.Line30.LineWeight = 1!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 0!
        Me.Line30.Width = 0!
        Me.Line30.X1 = 4.5!
        Me.Line30.X2 = 4.5!
        Me.Line30.Y1 = 0!
        Me.Line30.Y2 = 0.6000001!
        '
        'Line31
        '
        Me.Line31.Height = 0.6000001!
        Me.Line31.Left = 5.0625!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 0!
        Me.Line31.Width = 0!
        Me.Line31.X1 = 5.0625!
        Me.Line31.X2 = 5.0625!
        Me.Line31.Y1 = 0!
        Me.Line31.Y2 = 0.6000001!
        '
        'Line32
        '
        Me.Line32.Height = 0.6000001!
        Me.Line32.Left = 5.625!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 0!
        Me.Line32.Width = 0!
        Me.Line32.X1 = 5.625!
        Me.Line32.X2 = 5.625!
        Me.Line32.Y1 = 0!
        Me.Line32.Y2 = 0.6000001!
        '
        'Line33
        '
        Me.Line33.Height = 0.6000001!
        Me.Line33.Left = 6.1875!
        Me.Line33.LineWeight = 1!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 0!
        Me.Line33.Width = 0!
        Me.Line33.X1 = 6.1875!
        Me.Line33.X2 = 6.1875!
        Me.Line33.Y1 = 0!
        Me.Line33.Y2 = 0.6000001!
        '
        'Line34
        '
        Me.Line34.Height = 0.6000001!
        Me.Line34.Left = 6.75!
        Me.Line34.LineWeight = 1!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 0!
        Me.Line34.Width = 0!
        Me.Line34.X1 = 6.75!
        Me.Line34.X2 = 6.75!
        Me.Line34.Y1 = 0!
        Me.Line34.Y2 = 0.6000001!
        '
        'Line35
        '
        Me.Line35.Height = 0.6000001!
        Me.Line35.Left = 7.3125!
        Me.Line35.LineWeight = 1!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 0!
        Me.Line35.Width = 0!
        Me.Line35.X1 = 7.3125!
        Me.Line35.X2 = 7.3125!
        Me.Line35.Y1 = 0!
        Me.Line35.Y2 = 0.6000001!
        '
        'Line36
        '
        Me.Line36.Height = 0.6000001!
        Me.Line36.Left = 7.875!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 0!
        Me.Line36.Width = 0!
        Me.Line36.X1 = 7.875!
        Me.Line36.X2 = 7.875!
        Me.Line36.Y1 = 0!
        Me.Line36.Y2 = 0.6000001!
        '
        'Line37
        '
        Me.Line37.Height = 0.6000001!
        Me.Line37.Left = 8.4375!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 0!
        Me.Line37.Width = 0!
        Me.Line37.X1 = 8.4375!
        Me.Line37.X2 = 8.4375!
        Me.Line37.Y1 = 0!
        Me.Line37.Y2 = 0.6000001!
        '
        'Line38
        '
        Me.Line38.Height = 0.6000001!
        Me.Line38.Left = 9!
        Me.Line38.LineWeight = 1!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 0!
        Me.Line38.Width = 0!
        Me.Line38.X1 = 9!
        Me.Line38.X2 = 9!
        Me.Line38.Y1 = 0!
        Me.Line38.Y2 = 0.6000001!
        '
        'Line39
        '
        Me.Line39.Height = 0.6000001!
        Me.Line39.Left = 9.5625!
        Me.Line39.LineWeight = 1!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 0!
        Me.Line39.Width = 0!
        Me.Line39.X1 = 9.5625!
        Me.Line39.X2 = 9.5625!
        Me.Line39.Y1 = 0!
        Me.Line39.Y2 = 0.6000001!
        '
        'Line41
        '
        Me.Line41.Height = 0.6000001!
        Me.Line41.Left = 10.125!
        Me.Line41.LineWeight = 1!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 0!
        Me.Line41.Width = 0!
        Me.Line41.X1 = 10.125!
        Me.Line41.X2 = 10.125!
        Me.Line41.Y1 = 0!
        Me.Line41.Y2 = 0.6000001!
        '
        'Line42
        '
        Me.Line42.Height = 0.6000001!
        Me.Line42.Left = 10.6875!
        Me.Line42.LineWeight = 1!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 0!
        Me.Line42.Width = 0!
        Me.Line42.X1 = 10.6875!
        Me.Line42.X2 = 10.6875!
        Me.Line42.Y1 = 0!
        Me.Line42.Y2 = 0.6000001!
        '
        'Line43
        '
        Me.Line43.Height = 0.6000001!
        Me.Line43.Left = 11.375!
        Me.Line43.LineWeight = 1!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 0!
        Me.Line43.Width = 0!
        Me.Line43.X1 = 11.375!
        Me.Line43.X2 = 11.375!
        Me.Line43.Y1 = 0!
        Me.Line43.Y2 = 0.6000001!
        '
        'TextBox
        '
        Me.TextBox.DataField = "名称2"
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 0.265625!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; ddo-char-set: 128"
        Me.TextBox.Text = "名称2"
        Me.TextBox.Top = 0.25!
        Me.TextBox.Width = 1.8125!
        '
        'lblCode
        '
        Me.lblCode.DataField = "コード1"
        Me.lblCode.Height = 0.2!
        Me.lblCode.HyperLink = Nothing
        Me.lblCode.Left = 0.8125!
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Style = ""
        Me.lblCode.Text = ""
        Me.lblCode.Top = 0.375!
        Me.lblCode.Visible = false
        Me.lblCode.Width = 1!
        '
        'Line4
        '
        Me.Line4.Height = 0.6000001!
        Me.Line4.Left = 2.125!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 2.125!
        Me.Line4.X2 = 2.125!
        Me.Line4.Y1 = 0!
        Me.Line4.Y2 = 0.6000001!
        '
        'Label31
        '
        Me.Label31.Height = 0.6000001!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.125!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "background-color: LightYellow"
        Me.Label31.Text = ""
        Me.Label31.Top = 0!
        Me.Label31.Width = 11.25!
        '
        'lblKei
        '
        Me.lblKei.Height = 0.2!
        Me.lblKei.HyperLink = Nothing
        Me.lblKei.Left = 0.125!
        Me.lblKei.Name = "lblKei"
        Me.lblKei.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.lblKei.Text = "小 計"
        Me.lblKei.Top = 0.25!
        Me.lblKei.Width = 2!
        '
        'Label27
        '
        Me.Label27.Height = 0.15!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 2.125!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label27.Text = "計画"
        Me.Label27.Top = 0!
        Me.Label27.Width = 0.688!
        '
        'Label30
        '
        Me.Label30.Height = 0.15!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 2.125!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center" & _
            "; vertical-align: middle"
        Me.Label30.Text = "実績"
        Me.Label30.Top = 0.45!
        Me.Label30.Width = 0.6884999!
        '
        'Label29
        '
        Me.Label29.Height = 0.15!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 2.125!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label29.Text = "計画"
        Me.Label29.Top = 0.3!
        Me.Label29.Width = 0.6884999!
        '
        'Label28
        '
        Me.Label28.Height = 0.15!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 2.125!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center" & _
            "; vertical-align: middle"
        Me.Label28.Text = "実績"
        Me.Label28.Top = 0.15!
        Me.Label28.Width = 0.6884999!
        '
        'Sum四C_MONTH1
        '
        Me.Sum四C_MONTH1.DataField = "四C_MONTH1"
        Me.Sum四C_MONTH1.Height = 0.15!
        Me.Sum四C_MONTH1.Left = 2.8125!
        Me.Sum四C_MONTH1.Name = "Sum四C_MONTH1"
        Me.Sum四C_MONTH1.OutputFormat = resources.GetString("Sum四C_MONTH1.OutputFormat")
        Me.Sum四C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum四C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum四C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum四C_MONTH1.Text = "四月1"
        Me.Sum四C_MONTH1.Top = 0!
        Me.Sum四C_MONTH1.Width = 0.5625!
        '
        'Sum五C_MONTH1
        '
        Me.Sum五C_MONTH1.DataField = "五C_MONTH1"
        Me.Sum五C_MONTH1.Height = 0.15!
        Me.Sum五C_MONTH1.Left = 3.375!
        Me.Sum五C_MONTH1.Name = "Sum五C_MONTH1"
        Me.Sum五C_MONTH1.OutputFormat = resources.GetString("Sum五C_MONTH1.OutputFormat")
        Me.Sum五C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum五C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum五C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum五C_MONTH1.Text = "五月1"
        Me.Sum五C_MONTH1.Top = 0!
        Me.Sum五C_MONTH1.Width = 0.5625!
        '
        'Sum四C_MONTH2
        '
        Me.Sum四C_MONTH2.DataField = "四C_MONTH2"
        Me.Sum四C_MONTH2.Height = 0.15!
        Me.Sum四C_MONTH2.Left = 2.8125!
        Me.Sum四C_MONTH2.Name = "Sum四C_MONTH2"
        Me.Sum四C_MONTH2.OutputFormat = resources.GetString("Sum四C_MONTH2.OutputFormat")
        Me.Sum四C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum四C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum四C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum四C_MONTH2.Text = "四月2"
        Me.Sum四C_MONTH2.Top = 0.15!
        Me.Sum四C_MONTH2.Width = 0.5625!
        '
        'Sum四C_MONTH3
        '
        Me.Sum四C_MONTH3.DataField = "四C_MONTH3"
        Me.Sum四C_MONTH3.Height = 0.15!
        Me.Sum四C_MONTH3.Left = 2.8125!
        Me.Sum四C_MONTH3.Name = "Sum四C_MONTH3"
        Me.Sum四C_MONTH3.OutputFormat = resources.GetString("Sum四C_MONTH3.OutputFormat")
        Me.Sum四C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum四C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum四C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum四C_MONTH3.Text = "四月3"
        Me.Sum四C_MONTH3.Top = 0.3!
        Me.Sum四C_MONTH3.Width = 0.5625!
        '
        'Sum四C_MONTH4
        '
        Me.Sum四C_MONTH4.DataField = "四C_MONTH4"
        Me.Sum四C_MONTH4.Height = 0.15!
        Me.Sum四C_MONTH4.Left = 2.8125!
        Me.Sum四C_MONTH4.Name = "Sum四C_MONTH4"
        Me.Sum四C_MONTH4.OutputFormat = resources.GetString("Sum四C_MONTH4.OutputFormat")
        Me.Sum四C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum四C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum四C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum四C_MONTH4.Text = "四月4"
        Me.Sum四C_MONTH4.Top = 0.45!
        Me.Sum四C_MONTH4.Width = 0.5625!
        '
        'Sum六C_MONTH1
        '
        Me.Sum六C_MONTH1.DataField = "六C_MONTH1"
        Me.Sum六C_MONTH1.Height = 0.15!
        Me.Sum六C_MONTH1.Left = 3.9375!
        Me.Sum六C_MONTH1.Name = "Sum六C_MONTH1"
        Me.Sum六C_MONTH1.OutputFormat = resources.GetString("Sum六C_MONTH1.OutputFormat")
        Me.Sum六C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum六C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum六C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum六C_MONTH1.Text = "六月1"
        Me.Sum六C_MONTH1.Top = 0!
        Me.Sum六C_MONTH1.Width = 0.5625!
        '
        'Sum七C_MONTH1
        '
        Me.Sum七C_MONTH1.DataField = "七C_MONTH1"
        Me.Sum七C_MONTH1.Height = 0.15!
        Me.Sum七C_MONTH1.Left = 4.5!
        Me.Sum七C_MONTH1.Name = "Sum七C_MONTH1"
        Me.Sum七C_MONTH1.OutputFormat = resources.GetString("Sum七C_MONTH1.OutputFormat")
        Me.Sum七C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum七C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum七C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum七C_MONTH1.Text = "七月1"
        Me.Sum七C_MONTH1.Top = 0!
        Me.Sum七C_MONTH1.Width = 0.5625!
        '
        'Sum八C_MONTH1
        '
        Me.Sum八C_MONTH1.DataField = "八C_MONTH1"
        Me.Sum八C_MONTH1.Height = 0.15!
        Me.Sum八C_MONTH1.Left = 5.0625!
        Me.Sum八C_MONTH1.Name = "Sum八C_MONTH1"
        Me.Sum八C_MONTH1.OutputFormat = resources.GetString("Sum八C_MONTH1.OutputFormat")
        Me.Sum八C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum八C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum八C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum八C_MONTH1.Text = "八月1"
        Me.Sum八C_MONTH1.Top = 0!
        Me.Sum八C_MONTH1.Width = 0.5625!
        '
        'Sum九C_MONTH1
        '
        Me.Sum九C_MONTH1.DataField = "九C_MONTH1"
        Me.Sum九C_MONTH1.Height = 0.15!
        Me.Sum九C_MONTH1.Left = 5.625!
        Me.Sum九C_MONTH1.Name = "Sum九C_MONTH1"
        Me.Sum九C_MONTH1.OutputFormat = resources.GetString("Sum九C_MONTH1.OutputFormat")
        Me.Sum九C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum九C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum九C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum九C_MONTH1.Text = "九月1"
        Me.Sum九C_MONTH1.Top = 0!
        Me.Sum九C_MONTH1.Width = 0.5625!
        '
        'Sum十C_MONTH1
        '
        Me.Sum十C_MONTH1.DataField = "十C_MONTH1"
        Me.Sum十C_MONTH1.Height = 0.15!
        Me.Sum十C_MONTH1.Left = 6.1875!
        Me.Sum十C_MONTH1.Name = "Sum十C_MONTH1"
        Me.Sum十C_MONTH1.OutputFormat = resources.GetString("Sum十C_MONTH1.OutputFormat")
        Me.Sum十C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum十C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum十C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十C_MONTH1.Text = "十月1"
        Me.Sum十C_MONTH1.Top = 0!
        Me.Sum十C_MONTH1.Width = 0.5625!
        '
        'Sum十一C_MONTH1
        '
        Me.Sum十一C_MONTH1.DataField = "十一C_MONTH1"
        Me.Sum十一C_MONTH1.Height = 0.15!
        Me.Sum十一C_MONTH1.Left = 6.75!
        Me.Sum十一C_MONTH1.Name = "Sum十一C_MONTH1"
        Me.Sum十一C_MONTH1.OutputFormat = resources.GetString("Sum十一C_MONTH1.OutputFormat")
        Me.Sum十一C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum十一C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum十一C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十一C_MONTH1.Text = "十一月1"
        Me.Sum十一C_MONTH1.Top = 0!
        Me.Sum十一C_MONTH1.Width = 0.5625!
        '
        'Sum十二C_MONTH1
        '
        Me.Sum十二C_MONTH1.DataField = "十二C_MONTH1"
        Me.Sum十二C_MONTH1.Height = 0.15!
        Me.Sum十二C_MONTH1.Left = 7.313!
        Me.Sum十二C_MONTH1.Name = "Sum十二C_MONTH1"
        Me.Sum十二C_MONTH1.OutputFormat = resources.GetString("Sum十二C_MONTH1.OutputFormat")
        Me.Sum十二C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum十二C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum十二C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十二C_MONTH1.Text = "十二月1"
        Me.Sum十二C_MONTH1.Top = 0!
        Me.Sum十二C_MONTH1.Width = 0.5625!
        '
        'Sum一C_MONTH1
        '
        Me.Sum一C_MONTH1.DataField = "一C_MONTH1"
        Me.Sum一C_MONTH1.Height = 0.15!
        Me.Sum一C_MONTH1.Left = 7.875!
        Me.Sum一C_MONTH1.Name = "Sum一C_MONTH1"
        Me.Sum一C_MONTH1.OutputFormat = resources.GetString("Sum一C_MONTH1.OutputFormat")
        Me.Sum一C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum一C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum一C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum一C_MONTH1.Text = "一月1"
        Me.Sum一C_MONTH1.Top = 0!
        Me.Sum一C_MONTH1.Width = 0.5625!
        '
        'Sum二C_MONTH1
        '
        Me.Sum二C_MONTH1.DataField = "二C_MONTH1"
        Me.Sum二C_MONTH1.Height = 0.15!
        Me.Sum二C_MONTH1.Left = 8.4375!
        Me.Sum二C_MONTH1.Name = "Sum二C_MONTH1"
        Me.Sum二C_MONTH1.OutputFormat = resources.GetString("Sum二C_MONTH1.OutputFormat")
        Me.Sum二C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum二C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum二C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum二C_MONTH1.Text = "二月1"
        Me.Sum二C_MONTH1.Top = 0!
        Me.Sum二C_MONTH1.Width = 0.5625!
        '
        'Sum三C_MONTH1
        '
        Me.Sum三C_MONTH1.DataField = "三C_MONTH1"
        Me.Sum三C_MONTH1.Height = 0.15!
        Me.Sum三C_MONTH1.Left = 9!
        Me.Sum三C_MONTH1.Name = "Sum三C_MONTH1"
        Me.Sum三C_MONTH1.OutputFormat = resources.GetString("Sum三C_MONTH1.OutputFormat")
        Me.Sum三C_MONTH1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum三C_MONTH1.SummaryGroup = "GroupHeader1"
        Me.Sum三C_MONTH1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum三C_MONTH1.Text = "三月1"
        Me.Sum三C_MONTH1.Top = 0!
        Me.Sum三C_MONTH1.Width = 0.5625!
        '
        'Sum上半TERM1
        '
        Me.Sum上半TERM1.DataField = "上半TERM1"
        Me.Sum上半TERM1.Height = 0.15!
        Me.Sum上半TERM1.Left = 9.5625!
        Me.Sum上半TERM1.Name = "Sum上半TERM1"
        Me.Sum上半TERM1.OutputFormat = resources.GetString("Sum上半TERM1.OutputFormat")
        Me.Sum上半TERM1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum上半TERM1.SummaryGroup = "GroupHeader1"
        Me.Sum上半TERM1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum上半TERM1.Text = "上半期1"
        Me.Sum上半TERM1.Top = 0!
        Me.Sum上半TERM1.Width = 0.5625!
        '
        'Sum下半TERM1
        '
        Me.Sum下半TERM1.DataField = "下半TERM1"
        Me.Sum下半TERM1.Height = 0.15!
        Me.Sum下半TERM1.Left = 10.125!
        Me.Sum下半TERM1.Name = "Sum下半TERM1"
        Me.Sum下半TERM1.OutputFormat = resources.GetString("Sum下半TERM1.OutputFormat")
        Me.Sum下半TERM1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum下半TERM1.SummaryGroup = "GroupHeader1"
        Me.Sum下半TERM1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum下半TERM1.Text = "下半期1"
        Me.Sum下半TERM1.Top = 0!
        Me.Sum下半TERM1.Width = 0.5625!
        '
        'Sum五C_MONTH2
        '
        Me.Sum五C_MONTH2.DataField = "五C_MONTH2"
        Me.Sum五C_MONTH2.Height = 0.15!
        Me.Sum五C_MONTH2.Left = 3.375!
        Me.Sum五C_MONTH2.Name = "Sum五C_MONTH2"
        Me.Sum五C_MONTH2.OutputFormat = resources.GetString("Sum五C_MONTH2.OutputFormat")
        Me.Sum五C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum五C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum五C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum五C_MONTH2.Text = "五月2"
        Me.Sum五C_MONTH2.Top = 0.15!
        Me.Sum五C_MONTH2.Width = 0.5625!
        '
        'Sum六C_MONTH2
        '
        Me.Sum六C_MONTH2.DataField = "六C_MONTH2"
        Me.Sum六C_MONTH2.Height = 0.15!
        Me.Sum六C_MONTH2.Left = 3.9375!
        Me.Sum六C_MONTH2.Name = "Sum六C_MONTH2"
        Me.Sum六C_MONTH2.OutputFormat = resources.GetString("Sum六C_MONTH2.OutputFormat")
        Me.Sum六C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum六C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum六C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum六C_MONTH2.Text = "六月2"
        Me.Sum六C_MONTH2.Top = 0.15!
        Me.Sum六C_MONTH2.Width = 0.5625!
        '
        'Sum七C_MONTH2
        '
        Me.Sum七C_MONTH2.DataField = "七C_MONTH2"
        Me.Sum七C_MONTH2.Height = 0.15!
        Me.Sum七C_MONTH2.Left = 4.5!
        Me.Sum七C_MONTH2.Name = "Sum七C_MONTH2"
        Me.Sum七C_MONTH2.OutputFormat = resources.GetString("Sum七C_MONTH2.OutputFormat")
        Me.Sum七C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum七C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum七C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum七C_MONTH2.Text = "七月2"
        Me.Sum七C_MONTH2.Top = 0.15!
        Me.Sum七C_MONTH2.Width = 0.5625!
        '
        'Sum八C_MONTH2
        '
        Me.Sum八C_MONTH2.DataField = "八C_MONTH2"
        Me.Sum八C_MONTH2.Height = 0.15!
        Me.Sum八C_MONTH2.Left = 5.0625!
        Me.Sum八C_MONTH2.Name = "Sum八C_MONTH2"
        Me.Sum八C_MONTH2.OutputFormat = resources.GetString("Sum八C_MONTH2.OutputFormat")
        Me.Sum八C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum八C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum八C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum八C_MONTH2.Text = "八月2"
        Me.Sum八C_MONTH2.Top = 0.15!
        Me.Sum八C_MONTH2.Width = 0.5625!
        '
        'Sum九C_MONTH2
        '
        Me.Sum九C_MONTH2.DataField = "九C_MONTH2"
        Me.Sum九C_MONTH2.Height = 0.15!
        Me.Sum九C_MONTH2.Left = 5.625!
        Me.Sum九C_MONTH2.Name = "Sum九C_MONTH2"
        Me.Sum九C_MONTH2.OutputFormat = resources.GetString("Sum九C_MONTH2.OutputFormat")
        Me.Sum九C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum九C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum九C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum九C_MONTH2.Text = "九月2"
        Me.Sum九C_MONTH2.Top = 0.15!
        Me.Sum九C_MONTH2.Width = 0.5625!
        '
        'Sum十C_MONTH2
        '
        Me.Sum十C_MONTH2.DataField = "十C_MONTH2"
        Me.Sum十C_MONTH2.Height = 0.15!
        Me.Sum十C_MONTH2.Left = 6.1875!
        Me.Sum十C_MONTH2.Name = "Sum十C_MONTH2"
        Me.Sum十C_MONTH2.OutputFormat = resources.GetString("Sum十C_MONTH2.OutputFormat")
        Me.Sum十C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum十C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum十C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十C_MONTH2.Text = "十月2"
        Me.Sum十C_MONTH2.Top = 0.15!
        Me.Sum十C_MONTH2.Width = 0.5625!
        '
        'Sum十一C_MONTH2
        '
        Me.Sum十一C_MONTH2.DataField = "十一C_MONTH2"
        Me.Sum十一C_MONTH2.Height = 0.15!
        Me.Sum十一C_MONTH2.Left = 6.75!
        Me.Sum十一C_MONTH2.Name = "Sum十一C_MONTH2"
        Me.Sum十一C_MONTH2.OutputFormat = resources.GetString("Sum十一C_MONTH2.OutputFormat")
        Me.Sum十一C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum十一C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum十一C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十一C_MONTH2.Text = "十一月2"
        Me.Sum十一C_MONTH2.Top = 0.15!
        Me.Sum十一C_MONTH2.Width = 0.5625!
        '
        'Sum十二C_MONTH2
        '
        Me.Sum十二C_MONTH2.DataField = "十二C_MONTH2"
        Me.Sum十二C_MONTH2.Height = 0.15!
        Me.Sum十二C_MONTH2.Left = 7.3125!
        Me.Sum十二C_MONTH2.Name = "Sum十二C_MONTH2"
        Me.Sum十二C_MONTH2.OutputFormat = resources.GetString("Sum十二C_MONTH2.OutputFormat")
        Me.Sum十二C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum十二C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum十二C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十二C_MONTH2.Text = "十二月2"
        Me.Sum十二C_MONTH2.Top = 0.15!
        Me.Sum十二C_MONTH2.Width = 0.5625!
        '
        'Sum一C_MONTH2
        '
        Me.Sum一C_MONTH2.DataField = "一C_MONTH2"
        Me.Sum一C_MONTH2.Height = 0.15!
        Me.Sum一C_MONTH2.Left = 7.875!
        Me.Sum一C_MONTH2.Name = "Sum一C_MONTH2"
        Me.Sum一C_MONTH2.OutputFormat = resources.GetString("Sum一C_MONTH2.OutputFormat")
        Me.Sum一C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum一C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum一C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum一C_MONTH2.Text = "一月2"
        Me.Sum一C_MONTH2.Top = 0.15!
        Me.Sum一C_MONTH2.Width = 0.5625!
        '
        'Sum二C_MONTH2
        '
        Me.Sum二C_MONTH2.DataField = "二C_MONTH2"
        Me.Sum二C_MONTH2.Height = 0.15!
        Me.Sum二C_MONTH2.Left = 8.4375!
        Me.Sum二C_MONTH2.Name = "Sum二C_MONTH2"
        Me.Sum二C_MONTH2.OutputFormat = resources.GetString("Sum二C_MONTH2.OutputFormat")
        Me.Sum二C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum二C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum二C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum二C_MONTH2.Text = "二月2"
        Me.Sum二C_MONTH2.Top = 0.15!
        Me.Sum二C_MONTH2.Width = 0.5625!
        '
        'Sum三C_MONTH2
        '
        Me.Sum三C_MONTH2.DataField = "三C_MONTH2"
        Me.Sum三C_MONTH2.Height = 0.15!
        Me.Sum三C_MONTH2.Left = 9!
        Me.Sum三C_MONTH2.Name = "Sum三C_MONTH2"
        Me.Sum三C_MONTH2.OutputFormat = resources.GetString("Sum三C_MONTH2.OutputFormat")
        Me.Sum三C_MONTH2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum三C_MONTH2.SummaryGroup = "GroupHeader1"
        Me.Sum三C_MONTH2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum三C_MONTH2.Text = "三月2"
        Me.Sum三C_MONTH2.Top = 0.15!
        Me.Sum三C_MONTH2.Width = 0.5625!
        '
        'Sum上半TERM2
        '
        Me.Sum上半TERM2.DataField = "上半TERM2"
        Me.Sum上半TERM2.Height = 0.15!
        Me.Sum上半TERM2.Left = 9.5625!
        Me.Sum上半TERM2.Name = "Sum上半TERM2"
        Me.Sum上半TERM2.OutputFormat = resources.GetString("Sum上半TERM2.OutputFormat")
        Me.Sum上半TERM2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum上半TERM2.SummaryGroup = "GroupHeader1"
        Me.Sum上半TERM2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum上半TERM2.Text = "上半期2"
        Me.Sum上半TERM2.Top = 0.15!
        Me.Sum上半TERM2.Width = 0.5625!
        '
        'Sum下半TERM2
        '
        Me.Sum下半TERM2.DataField = "下半TERM2"
        Me.Sum下半TERM2.Height = 0.15!
        Me.Sum下半TERM2.Left = 10.125!
        Me.Sum下半TERM2.Name = "Sum下半TERM2"
        Me.Sum下半TERM2.OutputFormat = resources.GetString("Sum下半TERM2.OutputFormat")
        Me.Sum下半TERM2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum下半TERM2.SummaryGroup = "GroupHeader1"
        Me.Sum下半TERM2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum下半TERM2.Text = "下半期2"
        Me.Sum下半TERM2.Top = 0.15!
        Me.Sum下半TERM2.Width = 0.5625!
        '
        'Sum半TERM合計1
        '
        Me.Sum半TERM合計1.DataField = "合計1"
        Me.Sum半TERM合計1.Height = 0.15!
        Me.Sum半TERM合計1.Left = 10.6875!
        Me.Sum半TERM合計1.Name = "Sum半TERM合計1"
        Me.Sum半TERM合計1.OutputFormat = resources.GetString("Sum半TERM合計1.OutputFormat")
        Me.Sum半TERM合計1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum半TERM合計1.SummaryGroup = "GroupHeader1"
        Me.Sum半TERM合計1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum半TERM合計1.Text = "半期合計1"
        Me.Sum半TERM合計1.Top = 0!
        Me.Sum半TERM合計1.Width = 0.6875!
        '
        'Sum半TERM合計2
        '
        Me.Sum半TERM合計2.DataField = "合計2"
        Me.Sum半TERM合計2.Height = 0.15!
        Me.Sum半TERM合計2.Left = 10.6875!
        Me.Sum半TERM合計2.Name = "Sum半TERM合計2"
        Me.Sum半TERM合計2.OutputFormat = resources.GetString("Sum半TERM合計2.OutputFormat")
        Me.Sum半TERM合計2.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum半TERM合計2.SummaryGroup = "GroupHeader1"
        Me.Sum半TERM合計2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum半TERM合計2.Text = "半期合計2"
        Me.Sum半TERM合計2.Top = 0.15!
        Me.Sum半TERM合計2.Width = 0.6875!
        '
        'Sum五C_MONTH3
        '
        Me.Sum五C_MONTH3.DataField = "五C_MONTH3"
        Me.Sum五C_MONTH3.Height = 0.15!
        Me.Sum五C_MONTH3.Left = 3.375!
        Me.Sum五C_MONTH3.Name = "Sum五C_MONTH3"
        Me.Sum五C_MONTH3.OutputFormat = resources.GetString("Sum五C_MONTH3.OutputFormat")
        Me.Sum五C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum五C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum五C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum五C_MONTH3.Text = "五月3"
        Me.Sum五C_MONTH3.Top = 0.3!
        Me.Sum五C_MONTH3.Width = 0.5625!
        '
        'Sum六C_MONTH3
        '
        Me.Sum六C_MONTH3.DataField = "六C_MONTH3"
        Me.Sum六C_MONTH3.Height = 0.15!
        Me.Sum六C_MONTH3.Left = 3.9375!
        Me.Sum六C_MONTH3.Name = "Sum六C_MONTH3"
        Me.Sum六C_MONTH3.OutputFormat = resources.GetString("Sum六C_MONTH3.OutputFormat")
        Me.Sum六C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum六C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum六C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum六C_MONTH3.Text = "六月3"
        Me.Sum六C_MONTH3.Top = 0.3!
        Me.Sum六C_MONTH3.Width = 0.5625!
        '
        'Sum七C_MONTH3
        '
        Me.Sum七C_MONTH3.DataField = "七C_MONTH3"
        Me.Sum七C_MONTH3.Height = 0.15!
        Me.Sum七C_MONTH3.Left = 4.5!
        Me.Sum七C_MONTH3.Name = "Sum七C_MONTH3"
        Me.Sum七C_MONTH3.OutputFormat = resources.GetString("Sum七C_MONTH3.OutputFormat")
        Me.Sum七C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum七C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum七C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum七C_MONTH3.Text = "七月3"
        Me.Sum七C_MONTH3.Top = 0.3!
        Me.Sum七C_MONTH3.Width = 0.5625!
        '
        'Sum八C_MONTH3
        '
        Me.Sum八C_MONTH3.DataField = "八C_MONTH3"
        Me.Sum八C_MONTH3.Height = 0.15!
        Me.Sum八C_MONTH3.Left = 5.0625!
        Me.Sum八C_MONTH3.Name = "Sum八C_MONTH3"
        Me.Sum八C_MONTH3.OutputFormat = resources.GetString("Sum八C_MONTH3.OutputFormat")
        Me.Sum八C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum八C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum八C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum八C_MONTH3.Text = "八月3"
        Me.Sum八C_MONTH3.Top = 0.3!
        Me.Sum八C_MONTH3.Width = 0.5625!
        '
        'Sum九C_MONTH3
        '
        Me.Sum九C_MONTH3.DataField = "九C_MONTH3"
        Me.Sum九C_MONTH3.Height = 0.15!
        Me.Sum九C_MONTH3.Left = 5.625!
        Me.Sum九C_MONTH3.Name = "Sum九C_MONTH3"
        Me.Sum九C_MONTH3.OutputFormat = resources.GetString("Sum九C_MONTH3.OutputFormat")
        Me.Sum九C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum九C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum九C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum九C_MONTH3.Text = "九月3"
        Me.Sum九C_MONTH3.Top = 0.3!
        Me.Sum九C_MONTH3.Width = 0.5625!
        '
        'Sum十C_MONTH3
        '
        Me.Sum十C_MONTH3.DataField = "十C_MONTH3"
        Me.Sum十C_MONTH3.Height = 0.15!
        Me.Sum十C_MONTH3.Left = 6.1875!
        Me.Sum十C_MONTH3.Name = "Sum十C_MONTH3"
        Me.Sum十C_MONTH3.OutputFormat = resources.GetString("Sum十C_MONTH3.OutputFormat")
        Me.Sum十C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum十C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum十C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十C_MONTH3.Text = "十月3"
        Me.Sum十C_MONTH3.Top = 0.3!
        Me.Sum十C_MONTH3.Width = 0.5625!
        '
        'Sum十一C_MONTH3
        '
        Me.Sum十一C_MONTH3.DataField = "十一C_MONTH3"
        Me.Sum十一C_MONTH3.Height = 0.15!
        Me.Sum十一C_MONTH3.Left = 6.75!
        Me.Sum十一C_MONTH3.Name = "Sum十一C_MONTH3"
        Me.Sum十一C_MONTH3.OutputFormat = resources.GetString("Sum十一C_MONTH3.OutputFormat")
        Me.Sum十一C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum十一C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum十一C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十一C_MONTH3.Text = "十一月3"
        Me.Sum十一C_MONTH3.Top = 0.3!
        Me.Sum十一C_MONTH3.Width = 0.5625!
        '
        'Sum十二C_MONTH3
        '
        Me.Sum十二C_MONTH3.DataField = "十二C_MONTH3"
        Me.Sum十二C_MONTH3.Height = 0.15!
        Me.Sum十二C_MONTH3.Left = 7.3125!
        Me.Sum十二C_MONTH3.Name = "Sum十二C_MONTH3"
        Me.Sum十二C_MONTH3.OutputFormat = resources.GetString("Sum十二C_MONTH3.OutputFormat")
        Me.Sum十二C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum十二C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum十二C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十二C_MONTH3.Text = "十二月3"
        Me.Sum十二C_MONTH3.Top = 0.3!
        Me.Sum十二C_MONTH3.Width = 0.5625!
        '
        'Sum一C_MONTH3
        '
        Me.Sum一C_MONTH3.DataField = "一C_MONTH3"
        Me.Sum一C_MONTH3.Height = 0.15!
        Me.Sum一C_MONTH3.Left = 7.875!
        Me.Sum一C_MONTH3.Name = "Sum一C_MONTH3"
        Me.Sum一C_MONTH3.OutputFormat = resources.GetString("Sum一C_MONTH3.OutputFormat")
        Me.Sum一C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum一C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum一C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum一C_MONTH3.Text = "一月3"
        Me.Sum一C_MONTH3.Top = 0.3!
        Me.Sum一C_MONTH3.Width = 0.5625!
        '
        'Sum二C_MONTH3
        '
        Me.Sum二C_MONTH3.DataField = "二C_MONTH3"
        Me.Sum二C_MONTH3.Height = 0.15!
        Me.Sum二C_MONTH3.Left = 8.4375!
        Me.Sum二C_MONTH3.Name = "Sum二C_MONTH3"
        Me.Sum二C_MONTH3.OutputFormat = resources.GetString("Sum二C_MONTH3.OutputFormat")
        Me.Sum二C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum二C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum二C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum二C_MONTH3.Text = "二月3"
        Me.Sum二C_MONTH3.Top = 0.3!
        Me.Sum二C_MONTH3.Width = 0.5625!
        '
        'Sum三C_MONTH3
        '
        Me.Sum三C_MONTH3.DataField = "三C_MONTH3"
        Me.Sum三C_MONTH3.Height = 0.15!
        Me.Sum三C_MONTH3.Left = 9!
        Me.Sum三C_MONTH3.Name = "Sum三C_MONTH3"
        Me.Sum三C_MONTH3.OutputFormat = resources.GetString("Sum三C_MONTH3.OutputFormat")
        Me.Sum三C_MONTH3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum三C_MONTH3.SummaryGroup = "GroupHeader1"
        Me.Sum三C_MONTH3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum三C_MONTH3.Text = "三月3"
        Me.Sum三C_MONTH3.Top = 0.3!
        Me.Sum三C_MONTH3.Width = 0.5625!
        '
        'Sum上半TERM3
        '
        Me.Sum上半TERM3.DataField = "上半TERM3"
        Me.Sum上半TERM3.Height = 0.15!
        Me.Sum上半TERM3.Left = 9.5625!
        Me.Sum上半TERM3.Name = "Sum上半TERM3"
        Me.Sum上半TERM3.OutputFormat = resources.GetString("Sum上半TERM3.OutputFormat")
        Me.Sum上半TERM3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum上半TERM3.SummaryGroup = "GroupHeader1"
        Me.Sum上半TERM3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum上半TERM3.Text = "上半期3"
        Me.Sum上半TERM3.Top = 0.3!
        Me.Sum上半TERM3.Width = 0.5625!
        '
        'Sum下半TERM3
        '
        Me.Sum下半TERM3.DataField = "下半TERM3"
        Me.Sum下半TERM3.Height = 0.15!
        Me.Sum下半TERM3.Left = 10.125!
        Me.Sum下半TERM3.Name = "Sum下半TERM3"
        Me.Sum下半TERM3.OutputFormat = resources.GetString("Sum下半TERM3.OutputFormat")
        Me.Sum下半TERM3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum下半TERM3.SummaryGroup = "GroupHeader1"
        Me.Sum下半TERM3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum下半TERM3.Text = "下半期3"
        Me.Sum下半TERM3.Top = 0.3!
        Me.Sum下半TERM3.Width = 0.5625!
        '
        'Sum半TERM合計3
        '
        Me.Sum半TERM合計3.DataField = "合計3"
        Me.Sum半TERM合計3.Height = 0.15!
        Me.Sum半TERM合計3.Left = 10.6875!
        Me.Sum半TERM合計3.Name = "Sum半TERM合計3"
        Me.Sum半TERM合計3.OutputFormat = resources.GetString("Sum半TERM合計3.OutputFormat")
        Me.Sum半TERM合計3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Sum半TERM合計3.SummaryGroup = "GroupHeader1"
        Me.Sum半TERM合計3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum半TERM合計3.Text = "半期合計3"
        Me.Sum半TERM合計3.Top = 0.3!
        Me.Sum半TERM合計3.Width = 0.6875!
        '
        'Sum五C_MONTH4
        '
        Me.Sum五C_MONTH4.DataField = "五C_MONTH4"
        Me.Sum五C_MONTH4.Height = 0.15!
        Me.Sum五C_MONTH4.Left = 3.375!
        Me.Sum五C_MONTH4.Name = "Sum五C_MONTH4"
        Me.Sum五C_MONTH4.OutputFormat = resources.GetString("Sum五C_MONTH4.OutputFormat")
        Me.Sum五C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum五C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum五C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum五C_MONTH4.Text = "五月4"
        Me.Sum五C_MONTH4.Top = 0.45!
        Me.Sum五C_MONTH4.Width = 0.5625!
        '
        'Sum六C_MONTH4
        '
        Me.Sum六C_MONTH4.DataField = "六C_MONTH4"
        Me.Sum六C_MONTH4.Height = 0.15!
        Me.Sum六C_MONTH4.Left = 3.9375!
        Me.Sum六C_MONTH4.Name = "Sum六C_MONTH4"
        Me.Sum六C_MONTH4.OutputFormat = resources.GetString("Sum六C_MONTH4.OutputFormat")
        Me.Sum六C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum六C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum六C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum六C_MONTH4.Text = "六月4"
        Me.Sum六C_MONTH4.Top = 0.45!
        Me.Sum六C_MONTH4.Width = 0.5625!
        '
        'Sum七C_MONTH4
        '
        Me.Sum七C_MONTH4.DataField = "七C_MONTH4"
        Me.Sum七C_MONTH4.Height = 0.15!
        Me.Sum七C_MONTH4.Left = 4.5!
        Me.Sum七C_MONTH4.Name = "Sum七C_MONTH4"
        Me.Sum七C_MONTH4.OutputFormat = resources.GetString("Sum七C_MONTH4.OutputFormat")
        Me.Sum七C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum七C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum七C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum七C_MONTH4.Text = "七月4"
        Me.Sum七C_MONTH4.Top = 0.45!
        Me.Sum七C_MONTH4.Width = 0.5625!
        '
        'Sum八C_MONTH4
        '
        Me.Sum八C_MONTH4.DataField = "八C_MONTH4"
        Me.Sum八C_MONTH4.Height = 0.15!
        Me.Sum八C_MONTH4.Left = 5.0625!
        Me.Sum八C_MONTH4.Name = "Sum八C_MONTH4"
        Me.Sum八C_MONTH4.OutputFormat = resources.GetString("Sum八C_MONTH4.OutputFormat")
        Me.Sum八C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum八C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum八C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum八C_MONTH4.Text = "八月4"
        Me.Sum八C_MONTH4.Top = 0.45!
        Me.Sum八C_MONTH4.Width = 0.5625!
        '
        'Sum九C_MONTH4
        '
        Me.Sum九C_MONTH4.DataField = "九C_MONTH4"
        Me.Sum九C_MONTH4.Height = 0.15!
        Me.Sum九C_MONTH4.Left = 5.625!
        Me.Sum九C_MONTH4.Name = "Sum九C_MONTH4"
        Me.Sum九C_MONTH4.OutputFormat = resources.GetString("Sum九C_MONTH4.OutputFormat")
        Me.Sum九C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum九C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum九C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum九C_MONTH4.Text = "九月4"
        Me.Sum九C_MONTH4.Top = 0.45!
        Me.Sum九C_MONTH4.Width = 0.5625!
        '
        'Sum十C_MONTH4
        '
        Me.Sum十C_MONTH4.DataField = "十C_MONTH4"
        Me.Sum十C_MONTH4.Height = 0.15!
        Me.Sum十C_MONTH4.Left = 6.1875!
        Me.Sum十C_MONTH4.Name = "Sum十C_MONTH4"
        Me.Sum十C_MONTH4.OutputFormat = resources.GetString("Sum十C_MONTH4.OutputFormat")
        Me.Sum十C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum十C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum十C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十C_MONTH4.Text = "十月4"
        Me.Sum十C_MONTH4.Top = 0.45!
        Me.Sum十C_MONTH4.Width = 0.5625!
        '
        'Sum十一C_MONTH4
        '
        Me.Sum十一C_MONTH4.DataField = "十一C_MONTH4"
        Me.Sum十一C_MONTH4.Height = 0.15!
        Me.Sum十一C_MONTH4.Left = 6.75!
        Me.Sum十一C_MONTH4.Name = "Sum十一C_MONTH4"
        Me.Sum十一C_MONTH4.OutputFormat = resources.GetString("Sum十一C_MONTH4.OutputFormat")
        Me.Sum十一C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum十一C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum十一C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十一C_MONTH4.Text = "十一月4"
        Me.Sum十一C_MONTH4.Top = 0.45!
        Me.Sum十一C_MONTH4.Width = 0.5625!
        '
        'Sum十二C_MONTH4
        '
        Me.Sum十二C_MONTH4.DataField = "十二C_MONTH4"
        Me.Sum十二C_MONTH4.Height = 0.15!
        Me.Sum十二C_MONTH4.Left = 7.3125!
        Me.Sum十二C_MONTH4.Name = "Sum十二C_MONTH4"
        Me.Sum十二C_MONTH4.OutputFormat = resources.GetString("Sum十二C_MONTH4.OutputFormat")
        Me.Sum十二C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum十二C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum十二C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum十二C_MONTH4.Text = "十二月4"
        Me.Sum十二C_MONTH4.Top = 0.45!
        Me.Sum十二C_MONTH4.Width = 0.5625!
        '
        'Sum一C_MONTH4
        '
        Me.Sum一C_MONTH4.DataField = "一C_MONTH4"
        Me.Sum一C_MONTH4.Height = 0.15!
        Me.Sum一C_MONTH4.Left = 7.875!
        Me.Sum一C_MONTH4.Name = "Sum一C_MONTH4"
        Me.Sum一C_MONTH4.OutputFormat = resources.GetString("Sum一C_MONTH4.OutputFormat")
        Me.Sum一C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum一C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum一C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum一C_MONTH4.Text = "一月4"
        Me.Sum一C_MONTH4.Top = 0.45!
        Me.Sum一C_MONTH4.Width = 0.5625!
        '
        'Sum二C_MONTH4
        '
        Me.Sum二C_MONTH4.DataField = "二C_MONTH4"
        Me.Sum二C_MONTH4.Height = 0.15!
        Me.Sum二C_MONTH4.Left = 8.4375!
        Me.Sum二C_MONTH4.Name = "Sum二C_MONTH4"
        Me.Sum二C_MONTH4.OutputFormat = resources.GetString("Sum二C_MONTH4.OutputFormat")
        Me.Sum二C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum二C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum二C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum二C_MONTH4.Text = "二月4"
        Me.Sum二C_MONTH4.Top = 0.45!
        Me.Sum二C_MONTH4.Width = 0.5625!
        '
        'Sum三C_MONTH4
        '
        Me.Sum三C_MONTH4.DataField = "三C_MONTH4"
        Me.Sum三C_MONTH4.Height = 0.15!
        Me.Sum三C_MONTH4.Left = 9!
        Me.Sum三C_MONTH4.Name = "Sum三C_MONTH4"
        Me.Sum三C_MONTH4.OutputFormat = resources.GetString("Sum三C_MONTH4.OutputFormat")
        Me.Sum三C_MONTH4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum三C_MONTH4.SummaryGroup = "GroupHeader1"
        Me.Sum三C_MONTH4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum三C_MONTH4.Text = "三月4"
        Me.Sum三C_MONTH4.Top = 0.45!
        Me.Sum三C_MONTH4.Width = 0.5625!
        '
        'Sum上半TERM4
        '
        Me.Sum上半TERM4.DataField = "上半TERM4"
        Me.Sum上半TERM4.Height = 0.15!
        Me.Sum上半TERM4.Left = 9.5625!
        Me.Sum上半TERM4.Name = "Sum上半TERM4"
        Me.Sum上半TERM4.OutputFormat = resources.GetString("Sum上半TERM4.OutputFormat")
        Me.Sum上半TERM4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum上半TERM4.SummaryGroup = "GroupHeader1"
        Me.Sum上半TERM4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum上半TERM4.Text = "上半期4"
        Me.Sum上半TERM4.Top = 0.45!
        Me.Sum上半TERM4.Width = 0.5625!
        '
        'Sum下半TERM4
        '
        Me.Sum下半TERM4.DataField = "下半TERM4"
        Me.Sum下半TERM4.Height = 0.15!
        Me.Sum下半TERM4.Left = 10.125!
        Me.Sum下半TERM4.Name = "Sum下半TERM4"
        Me.Sum下半TERM4.OutputFormat = resources.GetString("Sum下半TERM4.OutputFormat")
        Me.Sum下半TERM4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum下半TERM4.SummaryGroup = "GroupHeader1"
        Me.Sum下半TERM4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum下半TERM4.Text = "下半期4"
        Me.Sum下半TERM4.Top = 0.45!
        Me.Sum下半TERM4.Width = 0.5625!
        '
        'Sum半TERM合計4
        '
        Me.Sum半TERM合計4.DataField = "合計4"
        Me.Sum半TERM合計4.Height = 0.15!
        Me.Sum半TERM合計4.Left = 10.6875!
        Me.Sum半TERM合計4.Name = "Sum半TERM合計4"
        Me.Sum半TERM合計4.OutputFormat = resources.GetString("Sum半TERM合計4.OutputFormat")
        Me.Sum半TERM合計4.Style = "background-color: Khaki; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right;" & _
            " vertical-align: middle"
        Me.Sum半TERM合計4.SummaryGroup = "GroupHeader1"
        Me.Sum半TERM合計4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.Sum半TERM合計4.Text = "半期合計4"
        Me.Sum半TERM合計4.Top = 0.45!
        Me.Sum半TERM合計4.Width = 0.6875!
        '
        'Line57
        '
        Me.Line57.Height = 0!
        Me.Line57.Left = 0.125!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 0.6000001!
        Me.Line57.Width = 11.25!
        Me.Line57.X1 = 0.125!
        Me.Line57.X2 = 11.375!
        Me.Line57.Y1 = 0.6000001!
        Me.Line57.Y2 = 0.6000001!
        '
        'Line69
        '
        Me.Line69.Height = 0.6000001!
        Me.Line69.Left = 11.375!
        Me.Line69.LineWeight = 1!
        Me.Line69.Name = "Line69"
        Me.Line69.Top = 0!
        Me.Line69.Width = 0!
        Me.Line69.X1 = 11.375!
        Me.Line69.X2 = 11.375!
        Me.Line69.Y1 = 0!
        Me.Line69.Y2 = 0.6000001!
        '
        'Line68
        '
        Me.Line68.Height = 0.6000001!
        Me.Line68.Left = 10.6875!
        Me.Line68.LineWeight = 1!
        Me.Line68.Name = "Line68"
        Me.Line68.Top = 0!
        Me.Line68.Width = 0!
        Me.Line68.X1 = 10.6875!
        Me.Line68.X2 = 10.6875!
        Me.Line68.Y1 = 0!
        Me.Line68.Y2 = 0.6000001!
        '
        'Line67
        '
        Me.Line67.Height = 0.6000001!
        Me.Line67.Left = 10.125!
        Me.Line67.LineWeight = 1!
        Me.Line67.Name = "Line67"
        Me.Line67.Top = 0!
        Me.Line67.Width = 0!
        Me.Line67.X1 = 10.125!
        Me.Line67.X2 = 10.125!
        Me.Line67.Y1 = 0!
        Me.Line67.Y2 = 0.6000001!
        '
        'Line65
        '
        Me.Line65.Height = 0.6000001!
        Me.Line65.Left = 9.5625!
        Me.Line65.LineWeight = 1!
        Me.Line65.Name = "Line65"
        Me.Line65.Top = 0!
        Me.Line65.Width = 0!
        Me.Line65.X1 = 9.5625!
        Me.Line65.X2 = 9.5625!
        Me.Line65.Y1 = 0!
        Me.Line65.Y2 = 0.6000001!
        '
        'Line64
        '
        Me.Line64.Height = 0.6000001!
        Me.Line64.Left = 9!
        Me.Line64.LineWeight = 1!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 0!
        Me.Line64.Width = 0!
        Me.Line64.X1 = 9!
        Me.Line64.X2 = 9!
        Me.Line64.Y1 = 0!
        Me.Line64.Y2 = 0.6000001!
        '
        'Line63
        '
        Me.Line63.Height = 0.6000001!
        Me.Line63.Left = 8.4375!
        Me.Line63.LineWeight = 1!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 0!
        Me.Line63.Width = 0!
        Me.Line63.X1 = 8.4375!
        Me.Line63.X2 = 8.4375!
        Me.Line63.Y1 = 0!
        Me.Line63.Y2 = 0.6000001!
        '
        'Line62
        '
        Me.Line62.Height = 0.6000001!
        Me.Line62.Left = 7.875!
        Me.Line62.LineWeight = 1!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 0!
        Me.Line62.Width = 0!
        Me.Line62.X1 = 7.875!
        Me.Line62.X2 = 7.875!
        Me.Line62.Y1 = 0!
        Me.Line62.Y2 = 0.6000001!
        '
        'Line61
        '
        Me.Line61.Height = 0.6000001!
        Me.Line61.Left = 7.3125!
        Me.Line61.LineWeight = 1!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 0!
        Me.Line61.Width = 0!
        Me.Line61.X1 = 7.3125!
        Me.Line61.X2 = 7.3125!
        Me.Line61.Y1 = 0!
        Me.Line61.Y2 = 0.6000001!
        '
        'Line60
        '
        Me.Line60.Height = 0.6000001!
        Me.Line60.Left = 6.75!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 0!
        Me.Line60.Width = 0!
        Me.Line60.X1 = 6.75!
        Me.Line60.X2 = 6.75!
        Me.Line60.Y1 = 0!
        Me.Line60.Y2 = 0.6000001!
        '
        'Line59
        '
        Me.Line59.Height = 0.6000001!
        Me.Line59.Left = 6.1875!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 0!
        Me.Line59.Width = 0!
        Me.Line59.X1 = 6.1875!
        Me.Line59.X2 = 6.1875!
        Me.Line59.Y1 = 0!
        Me.Line59.Y2 = 0.6000001!
        '
        'Line58
        '
        Me.Line58.Height = 0.6000001!
        Me.Line58.Left = 5.625!
        Me.Line58.LineWeight = 1!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 0!
        Me.Line58.Width = 0!
        Me.Line58.X1 = 5.625!
        Me.Line58.X2 = 5.625!
        Me.Line58.Y1 = 0!
        Me.Line58.Y2 = 0.6000001!
        '
        'Line56
        '
        Me.Line56.Height = 0.6000001!
        Me.Line56.Left = 5.0625!
        Me.Line56.LineWeight = 1!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 0!
        Me.Line56.Width = 0!
        Me.Line56.X1 = 5.0625!
        Me.Line56.X2 = 5.0625!
        Me.Line56.Y1 = 0!
        Me.Line56.Y2 = 0.6000001!
        '
        'Line55
        '
        Me.Line55.Height = 0.6000001!
        Me.Line55.Left = 4.5!
        Me.Line55.LineWeight = 1!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 0!
        Me.Line55.Width = 0!
        Me.Line55.X1 = 4.5!
        Me.Line55.X2 = 4.5!
        Me.Line55.Y1 = 0!
        Me.Line55.Y2 = 0.6000001!
        '
        'Line54
        '
        Me.Line54.Height = 0.6000001!
        Me.Line54.Left = 3.9375!
        Me.Line54.LineWeight = 1!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 0!
        Me.Line54.Width = 0!
        Me.Line54.X1 = 3.9375!
        Me.Line54.X2 = 3.9375!
        Me.Line54.Y1 = 0!
        Me.Line54.Y2 = 0.6000001!
        '
        'Line73
        '
        Me.Line73.Height = 0.6000001!
        Me.Line73.Left = 0.125!
        Me.Line73.LineWeight = 1!
        Me.Line73.Name = "Line73"
        Me.Line73.Top = 0!
        Me.Line73.Width = 0!
        Me.Line73.X1 = 0.125!
        Me.Line73.X2 = 0.125!
        Me.Line73.Y1 = 0!
        Me.Line73.Y2 = 0.6000001!
        '
        'Line74
        '
        Me.Line74.Height = 0.6000001!
        Me.Line74.Left = 3.375!
        Me.Line74.LineWeight = 1!
        Me.Line74.Name = "Line74"
        Me.Line74.Top = 0!
        Me.Line74.Width = 0!
        Me.Line74.X1 = 3.375!
        Me.Line74.X2 = 3.375!
        Me.Line74.Y1 = 0!
        Me.Line74.Y2 = 0.6000001!
        '
        'Line75
        '
        Me.Line75.Height = 0.6000001!
        Me.Line75.Left = 2.8125!
        Me.Line75.LineWeight = 1!
        Me.Line75.Name = "Line75"
        Me.Line75.Top = 0!
        Me.Line75.Width = 0!
        Me.Line75.X1 = 2.8125!
        Me.Line75.X2 = 2.8125!
        Me.Line75.Y1 = 0!
        Me.Line75.Y2 = 0.6000001!
        '
        'Line76
        '
        Me.Line76.Height = 0.6000001!
        Me.Line76.Left = 2.125!
        Me.Line76.LineWeight = 1!
        Me.Line76.Name = "Line76"
        Me.Line76.Top = 0!
        Me.Line76.Width = 0!
        Me.Line76.X1 = 2.125!
        Me.Line76.X2 = 2.125!
        Me.Line76.Y1 = 0!
        Me.Line76.Y2 = 0.6000001!
        '
        'TextBox61
        '
        Me.TextBox61.DataField = "名称1"
        Me.TextBox61.Height = 0.2!
        Me.TextBox61.Left = 0.1875!
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Style = "font-family: ＭＳ ゴシック; ddo-char-set: 1"
        Me.TextBox61.Text = "名称1"
        Me.TextBox61.Top = 0.0625!
        Me.TextBox61.Width = 1.6875!
        '
        'Label15
        '
        Me.Label15.Height = 0.2!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.125!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label15.Text = "合 計"
        Me.Label15.Top = 0.1875!
        Me.Label15.Width = 2!
        '
        'Label18
        '
        Me.Label18.Height = 0.15!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 2.125!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label18.Text = "計画"
        Me.Label18.Top = 0!
        Me.Label18.Width = 0.688!
        '
        'Label19
        '
        Me.Label19.Height = 0.15!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 2.1255!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label19.Text = "実績"
        Me.Label19.Top = 0.45!
        Me.Label19.Width = 0.688!
        '
        'Label20
        '
        Me.Label20.Height = 0.15!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 2.1255!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label20.Text = "計画"
        Me.Label20.Top = 0.3!
        Me.Label20.Width = 0.688!
        '
        'Label32
        '
        Me.Label32.Height = 0.15!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 2.1255!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label32.Text = "実績"
        Me.Label32.Top = 0.15!
        Me.Label32.Width = 0.688!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "四C_MONTH1"
        Me.TextBox1.Height = 0.15!
        Me.TextBox1.Left = 2.8125!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox1.SummaryGroup = "四月1"
        Me.TextBox1.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox1.Text = "四月1"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 0.5625!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "五C_MONTH1"
        Me.TextBox2.Height = 0.15!
        Me.TextBox2.Left = 3.375!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox2.SummaryGroup = "五月1"
        Me.TextBox2.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox2.Text = "五月1"
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 0.5625!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "四C_MONTH2"
        Me.TextBox3.Height = 0.15!
        Me.TextBox3.Left = 2.8125!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox3.SummaryGroup = "四月2"
        Me.TextBox3.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox3.Text = "四月2"
        Me.TextBox3.Top = 0.15!
        Me.TextBox3.Width = 0.5625!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "四C_MONTH3"
        Me.TextBox4.Height = 0.15!
        Me.TextBox4.Left = 2.8125!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox4.SummaryGroup = "四月3"
        Me.TextBox4.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox4.Text = "四月3"
        Me.TextBox4.Top = 0.3!
        Me.TextBox4.Width = 0.5625!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "四C_MONTH4"
        Me.TextBox5.Height = 0.15!
        Me.TextBox5.Left = 2.8125!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox5.SummaryGroup = "四月4"
        Me.TextBox5.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox5.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox5.Text = "四月4"
        Me.TextBox5.Top = 0.45!
        Me.TextBox5.Width = 0.5625!
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "六C_MONTH1"
        Me.TextBox6.Height = 0.15!
        Me.TextBox6.Left = 3.9375!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox6.SummaryGroup = "六月1"
        Me.TextBox6.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox6.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox6.Text = "六月1"
        Me.TextBox6.Top = 0!
        Me.TextBox6.Width = 0.5625!
        '
        'TextBox7
        '
        Me.TextBox7.DataField = "七C_MONTH1"
        Me.TextBox7.Height = 0.15!
        Me.TextBox7.Left = 4.5!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox7.SummaryGroup = "七月1"
        Me.TextBox7.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox7.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox7.Text = "七月1"
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 0.5625!
        '
        'TextBox8
        '
        Me.TextBox8.DataField = "八C_MONTH1"
        Me.TextBox8.Height = 0.15!
        Me.TextBox8.Left = 5.0625!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox8.SummaryGroup = "八月1"
        Me.TextBox8.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox8.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox8.Text = "八月1"
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 0.5625!
        '
        'TextBox9
        '
        Me.TextBox9.DataField = "九C_MONTH1"
        Me.TextBox9.Height = 0.15!
        Me.TextBox9.Left = 5.625!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox9.SummaryGroup = "九月1"
        Me.TextBox9.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox9.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox9.Text = "九月1"
        Me.TextBox9.Top = 0!
        Me.TextBox9.Width = 0.5625!
        '
        'TextBox10
        '
        Me.TextBox10.DataField = "十C_MONTH1"
        Me.TextBox10.Height = 0.15!
        Me.TextBox10.Left = 6.1875!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox10.SummaryGroup = "十月1"
        Me.TextBox10.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox10.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox10.Text = "十月1"
        Me.TextBox10.Top = 0!
        Me.TextBox10.Width = 0.5625!
        '
        'TextBox11
        '
        Me.TextBox11.DataField = "十一C_MONTH1"
        Me.TextBox11.Height = 0.15!
        Me.TextBox11.Left = 6.75!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox11.SummaryGroup = "十一月1"
        Me.TextBox11.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox11.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox11.Text = "十一月1"
        Me.TextBox11.Top = 0!
        Me.TextBox11.Width = 0.5625!
        '
        'TextBox12
        '
        Me.TextBox12.DataField = "十二C_MONTH1"
        Me.TextBox12.Height = 0.15!
        Me.TextBox12.Left = 7.322917!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.OutputFormat = resources.GetString("TextBox12.OutputFormat")
        Me.TextBox12.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox12.SummaryGroup = "十二月1"
        Me.TextBox12.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox12.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox12.Text = "十二月1"
        Me.TextBox12.Top = 0!
        Me.TextBox12.Width = 0.5625!
        '
        'TextBox13
        '
        Me.TextBox13.DataField = "一C_MONTH1"
        Me.TextBox13.Height = 0.15!
        Me.TextBox13.Left = 7.875!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox13.SummaryGroup = "一月1"
        Me.TextBox13.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox13.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox13.Text = "一月1"
        Me.TextBox13.Top = 0!
        Me.TextBox13.Width = 0.5625!
        '
        'TextBox14
        '
        Me.TextBox14.DataField = "二C_MONTH1"
        Me.TextBox14.Height = 0.15!
        Me.TextBox14.Left = 8.4375!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox14.SummaryGroup = "二月1"
        Me.TextBox14.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox14.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox14.Text = "二月1"
        Me.TextBox14.Top = 0!
        Me.TextBox14.Width = 0.5625!
        '
        'TextBox15
        '
        Me.TextBox15.DataField = "三C_MONTH1"
        Me.TextBox15.Height = 0.15!
        Me.TextBox15.Left = 9!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox15.SummaryGroup = "三月1"
        Me.TextBox15.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox15.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox15.Text = "三月1"
        Me.TextBox15.Top = 0!
        Me.TextBox15.Width = 0.5625!
        '
        'TextBox16
        '
        Me.TextBox16.DataField = "上半TERM1"
        Me.TextBox16.Height = 0.15!
        Me.TextBox16.Left = 9.5625!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox16.SummaryGroup = "上半期1"
        Me.TextBox16.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox16.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox16.Text = "上半期1"
        Me.TextBox16.Top = 0!
        Me.TextBox16.Width = 0.5625!
        '
        'TextBox17
        '
        Me.TextBox17.DataField = "下半TERM1"
        Me.TextBox17.Height = 0.15!
        Me.TextBox17.Left = 10.125!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox17.SummaryGroup = "下半期1"
        Me.TextBox17.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox17.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox17.Text = "下半期1"
        Me.TextBox17.Top = 0!
        Me.TextBox17.Width = 0.5625!
        '
        'TextBox18
        '
        Me.TextBox18.DataField = "五C_MONTH2"
        Me.TextBox18.Height = 0.15!
        Me.TextBox18.Left = 3.375!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.OutputFormat = resources.GetString("TextBox18.OutputFormat")
        Me.TextBox18.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox18.SummaryGroup = "五月2"
        Me.TextBox18.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox18.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox18.Text = "五月2"
        Me.TextBox18.Top = 0.15!
        Me.TextBox18.Width = 0.5625!
        '
        'TextBox19
        '
        Me.TextBox19.DataField = "六C_MONTH2"
        Me.TextBox19.Height = 0.15!
        Me.TextBox19.Left = 3.9375!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
        Me.TextBox19.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox19.SummaryGroup = "六月2"
        Me.TextBox19.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox19.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox19.Text = "六月2"
        Me.TextBox19.Top = 0.15!
        Me.TextBox19.Width = 0.5625!
        '
        'TextBox20
        '
        Me.TextBox20.DataField = "七C_MONTH2"
        Me.TextBox20.Height = 0.15!
        Me.TextBox20.Left = 4.5!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.OutputFormat = resources.GetString("TextBox20.OutputFormat")
        Me.TextBox20.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox20.SummaryGroup = "七月2"
        Me.TextBox20.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox20.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox20.Text = "七月2"
        Me.TextBox20.Top = 0.15!
        Me.TextBox20.Width = 0.5625!
        '
        'TextBox21
        '
        Me.TextBox21.DataField = "八C_MONTH2"
        Me.TextBox21.Height = 0.15!
        Me.TextBox21.Left = 5.0625!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.OutputFormat = resources.GetString("TextBox21.OutputFormat")
        Me.TextBox21.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox21.SummaryGroup = "八月2"
        Me.TextBox21.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox21.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox21.Text = "八月2"
        Me.TextBox21.Top = 0.15!
        Me.TextBox21.Width = 0.5625!
        '
        'TextBox22
        '
        Me.TextBox22.DataField = "九C_MONTH2"
        Me.TextBox22.Height = 0.15!
        Me.TextBox22.Left = 5.625!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.OutputFormat = resources.GetString("TextBox22.OutputFormat")
        Me.TextBox22.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox22.SummaryGroup = "九月2"
        Me.TextBox22.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox22.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox22.Text = "九月2"
        Me.TextBox22.Top = 0.15!
        Me.TextBox22.Width = 0.5625!
        '
        'TextBox23
        '
        Me.TextBox23.DataField = "十C_MONTH2"
        Me.TextBox23.Height = 0.15!
        Me.TextBox23.Left = 6.1875!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.OutputFormat = resources.GetString("TextBox23.OutputFormat")
        Me.TextBox23.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox23.SummaryGroup = "十月2"
        Me.TextBox23.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox23.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox23.Text = "十月2"
        Me.TextBox23.Top = 0.15!
        Me.TextBox23.Width = 0.5625!
        '
        'TextBox24
        '
        Me.TextBox24.DataField = "十一C_MONTH2"
        Me.TextBox24.Height = 0.15!
        Me.TextBox24.Left = 6.75!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.OutputFormat = resources.GetString("TextBox24.OutputFormat")
        Me.TextBox24.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox24.SummaryGroup = "十一月2"
        Me.TextBox24.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox24.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox24.Text = "十一月2"
        Me.TextBox24.Top = 0.15!
        Me.TextBox24.Width = 0.5625!
        '
        'TextBox25
        '
        Me.TextBox25.DataField = "十二C_MONTH2"
        Me.TextBox25.Height = 0.15!
        Me.TextBox25.Left = 7.3125!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.OutputFormat = resources.GetString("TextBox25.OutputFormat")
        Me.TextBox25.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox25.SummaryGroup = "十二月2"
        Me.TextBox25.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox25.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox25.Text = "十二月2"
        Me.TextBox25.Top = 0.15!
        Me.TextBox25.Width = 0.5625!
        '
        'TextBox26
        '
        Me.TextBox26.DataField = "一C_MONTH2"
        Me.TextBox26.Height = 0.15!
        Me.TextBox26.Left = 7.875!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.OutputFormat = resources.GetString("TextBox26.OutputFormat")
        Me.TextBox26.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox26.SummaryGroup = "一月2"
        Me.TextBox26.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox26.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox26.Text = "一月2"
        Me.TextBox26.Top = 0.15!
        Me.TextBox26.Width = 0.5625!
        '
        'TextBox27
        '
        Me.TextBox27.DataField = "二C_MONTH2"
        Me.TextBox27.Height = 0.15!
        Me.TextBox27.Left = 8.4375!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.OutputFormat = resources.GetString("TextBox27.OutputFormat")
        Me.TextBox27.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox27.SummaryGroup = "二月2"
        Me.TextBox27.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox27.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox27.Text = "二月2"
        Me.TextBox27.Top = 0.15!
        Me.TextBox27.Width = 0.5625!
        '
        'TextBox28
        '
        Me.TextBox28.DataField = "三C_MONTH2"
        Me.TextBox28.Height = 0.15!
        Me.TextBox28.Left = 9!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.OutputFormat = resources.GetString("TextBox28.OutputFormat")
        Me.TextBox28.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox28.SummaryGroup = "三月2"
        Me.TextBox28.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox28.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox28.Text = "三月2"
        Me.TextBox28.Top = 0.15!
        Me.TextBox28.Width = 0.5625!
        '
        'TextBox29
        '
        Me.TextBox29.DataField = "上半TERM2"
        Me.TextBox29.Height = 0.15!
        Me.TextBox29.Left = 9.5625!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.OutputFormat = resources.GetString("TextBox29.OutputFormat")
        Me.TextBox29.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox29.SummaryGroup = "上半期2"
        Me.TextBox29.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox29.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox29.Text = "上半期2"
        Me.TextBox29.Top = 0.15!
        Me.TextBox29.Width = 0.5625!
        '
        'TextBox30
        '
        Me.TextBox30.DataField = "下半TERM2"
        Me.TextBox30.Height = 0.15!
        Me.TextBox30.Left = 10.125!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.OutputFormat = resources.GetString("TextBox30.OutputFormat")
        Me.TextBox30.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox30.SummaryGroup = "下半期2"
        Me.TextBox30.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox30.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox30.Text = "下半期2"
        Me.TextBox30.Top = 0.15!
        Me.TextBox30.Width = 0.5625!
        '
        'TextBox31
        '
        Me.TextBox31.DataField = "合計1"
        Me.TextBox31.Height = 0.15!
        Me.TextBox31.Left = 10.6875!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.OutputFormat = resources.GetString("TextBox31.OutputFormat")
        Me.TextBox31.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox31.SummaryGroup = "半期合計1"
        Me.TextBox31.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox31.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox31.Text = "半期合計1"
        Me.TextBox31.Top = 0!
        Me.TextBox31.Width = 0.6875!
        '
        'TextBox32
        '
        Me.TextBox32.DataField = "合計2"
        Me.TextBox32.Height = 0.15!
        Me.TextBox32.Left = 10.6875!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.OutputFormat = resources.GetString("TextBox32.OutputFormat")
        Me.TextBox32.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox32.SummaryGroup = "半期合計2"
        Me.TextBox32.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox32.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox32.Text = "半期合計2"
        Me.TextBox32.Top = 0.15!
        Me.TextBox32.Width = 0.6875!
        '
        'TextBox33
        '
        Me.TextBox33.DataField = "五C_MONTH3"
        Me.TextBox33.Height = 0.15!
        Me.TextBox33.Left = 3.375!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.OutputFormat = resources.GetString("TextBox33.OutputFormat")
        Me.TextBox33.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox33.SummaryGroup = "五月3"
        Me.TextBox33.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox33.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox33.Text = "五月3"
        Me.TextBox33.Top = 0.3!
        Me.TextBox33.Width = 0.5625!
        '
        'TextBox34
        '
        Me.TextBox34.DataField = "六C_MONTH3"
        Me.TextBox34.Height = 0.15!
        Me.TextBox34.Left = 3.9375!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.OutputFormat = resources.GetString("TextBox34.OutputFormat")
        Me.TextBox34.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox34.SummaryGroup = "六月3"
        Me.TextBox34.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox34.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox34.Text = "六月3"
        Me.TextBox34.Top = 0.3!
        Me.TextBox34.Width = 0.5625!
        '
        'TextBox35
        '
        Me.TextBox35.DataField = "七C_MONTH3"
        Me.TextBox35.Height = 0.15!
        Me.TextBox35.Left = 4.5!
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.OutputFormat = resources.GetString("TextBox35.OutputFormat")
        Me.TextBox35.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox35.SummaryGroup = "七月3"
        Me.TextBox35.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox35.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox35.Text = "七月3"
        Me.TextBox35.Top = 0.3!
        Me.TextBox35.Width = 0.5625!
        '
        'TextBox36
        '
        Me.TextBox36.DataField = "八C_MONTH3"
        Me.TextBox36.Height = 0.15!
        Me.TextBox36.Left = 5.0625!
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.OutputFormat = resources.GetString("TextBox36.OutputFormat")
        Me.TextBox36.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox36.SummaryGroup = "八月3"
        Me.TextBox36.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox36.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox36.Text = "八月3"
        Me.TextBox36.Top = 0.3!
        Me.TextBox36.Width = 0.5625!
        '
        'TextBox37
        '
        Me.TextBox37.DataField = "九C_MONTH3"
        Me.TextBox37.Height = 0.15!
        Me.TextBox37.Left = 5.625!
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.OutputFormat = resources.GetString("TextBox37.OutputFormat")
        Me.TextBox37.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox37.SummaryGroup = "九月3"
        Me.TextBox37.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox37.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox37.Text = "九月3"
        Me.TextBox37.Top = 0.3!
        Me.TextBox37.Width = 0.5625!
        '
        'TextBox38
        '
        Me.TextBox38.DataField = "十C_MONTH3"
        Me.TextBox38.Height = 0.15!
        Me.TextBox38.Left = 6.1875!
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.OutputFormat = resources.GetString("TextBox38.OutputFormat")
        Me.TextBox38.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox38.SummaryGroup = "十月3"
        Me.TextBox38.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox38.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox38.Text = "十月3"
        Me.TextBox38.Top = 0.3!
        Me.TextBox38.Width = 0.5625!
        '
        'TextBox39
        '
        Me.TextBox39.DataField = "十一C_MONTH3"
        Me.TextBox39.Height = 0.15!
        Me.TextBox39.Left = 6.75!
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.OutputFormat = resources.GetString("TextBox39.OutputFormat")
        Me.TextBox39.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox39.SummaryGroup = "十一月3"
        Me.TextBox39.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox39.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox39.Text = "十一月3"
        Me.TextBox39.Top = 0.3!
        Me.TextBox39.Width = 0.5625!
        '
        'TextBox40
        '
        Me.TextBox40.DataField = "十二C_MONTH3"
        Me.TextBox40.Height = 0.15!
        Me.TextBox40.Left = 7.3125!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.OutputFormat = resources.GetString("TextBox40.OutputFormat")
        Me.TextBox40.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox40.SummaryGroup = "十二月3"
        Me.TextBox40.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox40.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox40.Text = "十二月3"
        Me.TextBox40.Top = 0.3!
        Me.TextBox40.Width = 0.5625!
        '
        'TextBox41
        '
        Me.TextBox41.DataField = "一C_MONTH3"
        Me.TextBox41.Height = 0.15!
        Me.TextBox41.Left = 7.875!
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.OutputFormat = resources.GetString("TextBox41.OutputFormat")
        Me.TextBox41.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox41.SummaryGroup = "一月3"
        Me.TextBox41.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox41.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox41.Text = "一月3"
        Me.TextBox41.Top = 0.3!
        Me.TextBox41.Width = 0.5625!
        '
        'TextBox42
        '
        Me.TextBox42.DataField = "二C_MONTH3"
        Me.TextBox42.Height = 0.15!
        Me.TextBox42.Left = 8.4375!
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.OutputFormat = resources.GetString("TextBox42.OutputFormat")
        Me.TextBox42.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox42.SummaryGroup = "二月3"
        Me.TextBox42.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox42.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox42.Text = "二月3"
        Me.TextBox42.Top = 0.3!
        Me.TextBox42.Width = 0.5625!
        '
        'TextBox43
        '
        Me.TextBox43.DataField = "三C_MONTH3"
        Me.TextBox43.Height = 0.15!
        Me.TextBox43.Left = 9!
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.OutputFormat = resources.GetString("TextBox43.OutputFormat")
        Me.TextBox43.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox43.SummaryGroup = "三月3"
        Me.TextBox43.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox43.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox43.Text = "三月3"
        Me.TextBox43.Top = 0.3!
        Me.TextBox43.Width = 0.5625!
        '
        'TextBox44
        '
        Me.TextBox44.DataField = "上半TERM3"
        Me.TextBox44.Height = 0.15!
        Me.TextBox44.Left = 9.5625!
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.OutputFormat = resources.GetString("TextBox44.OutputFormat")
        Me.TextBox44.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox44.SummaryGroup = "上半期3"
        Me.TextBox44.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox44.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox44.Text = "上半期3"
        Me.TextBox44.Top = 0.3!
        Me.TextBox44.Width = 0.5625!
        '
        'TextBox45
        '
        Me.TextBox45.DataField = "下半TERM3"
        Me.TextBox45.Height = 0.15!
        Me.TextBox45.Left = 10.125!
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.OutputFormat = resources.GetString("TextBox45.OutputFormat")
        Me.TextBox45.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox45.SummaryGroup = "下半期3"
        Me.TextBox45.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox45.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox45.Text = "下半期3"
        Me.TextBox45.Top = 0.3!
        Me.TextBox45.Width = 0.5625!
        '
        'TextBox46
        '
        Me.TextBox46.DataField = "合計3"
        Me.TextBox46.Height = 0.15!
        Me.TextBox46.Left = 10.6875!
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.OutputFormat = resources.GetString("TextBox46.OutputFormat")
        Me.TextBox46.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.TextBox46.SummaryGroup = "半期合計3"
        Me.TextBox46.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox46.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox46.Text = "半期合計3"
        Me.TextBox46.Top = 0.3!
        Me.TextBox46.Width = 0.6875!
        '
        'TextBox47
        '
        Me.TextBox47.DataField = "五C_MONTH4"
        Me.TextBox47.Height = 0.15!
        Me.TextBox47.Left = 3.375!
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.OutputFormat = resources.GetString("TextBox47.OutputFormat")
        Me.TextBox47.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox47.SummaryGroup = "五月4"
        Me.TextBox47.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox47.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox47.Text = "五月4"
        Me.TextBox47.Top = 0.45!
        Me.TextBox47.Width = 0.5625!
        '
        'TextBox48
        '
        Me.TextBox48.DataField = "六C_MONTH4"
        Me.TextBox48.Height = 0.15!
        Me.TextBox48.Left = 3.9375!
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.OutputFormat = resources.GetString("TextBox48.OutputFormat")
        Me.TextBox48.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox48.SummaryGroup = "六月4"
        Me.TextBox48.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox48.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox48.Text = "六月4"
        Me.TextBox48.Top = 0.45!
        Me.TextBox48.Width = 0.5625!
        '
        'TextBox49
        '
        Me.TextBox49.DataField = "七C_MONTH4"
        Me.TextBox49.Height = 0.15!
        Me.TextBox49.Left = 4.5!
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.OutputFormat = resources.GetString("TextBox49.OutputFormat")
        Me.TextBox49.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox49.SummaryGroup = "七月4"
        Me.TextBox49.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox49.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox49.Text = "七月4"
        Me.TextBox49.Top = 0.45!
        Me.TextBox49.Width = 0.5625!
        '
        'TextBox50
        '
        Me.TextBox50.DataField = "八C_MONTH4"
        Me.TextBox50.Height = 0.15!
        Me.TextBox50.Left = 5.0625!
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.OutputFormat = resources.GetString("TextBox50.OutputFormat")
        Me.TextBox50.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox50.SummaryGroup = "八月4"
        Me.TextBox50.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox50.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox50.Text = "八月4"
        Me.TextBox50.Top = 0.45!
        Me.TextBox50.Width = 0.5625!
        '
        'TextBox51
        '
        Me.TextBox51.DataField = "九C_MONTH4"
        Me.TextBox51.Height = 0.15!
        Me.TextBox51.Left = 5.625!
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.OutputFormat = resources.GetString("TextBox51.OutputFormat")
        Me.TextBox51.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox51.SummaryGroup = "九月4"
        Me.TextBox51.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox51.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox51.Text = "九月4"
        Me.TextBox51.Top = 0.45!
        Me.TextBox51.Width = 0.5625!
        '
        'TextBox52
        '
        Me.TextBox52.DataField = "十C_MONTH4"
        Me.TextBox52.Height = 0.15!
        Me.TextBox52.Left = 6.1875!
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.OutputFormat = resources.GetString("TextBox52.OutputFormat")
        Me.TextBox52.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox52.SummaryGroup = "十月4"
        Me.TextBox52.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox52.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox52.Text = "十月4"
        Me.TextBox52.Top = 0.45!
        Me.TextBox52.Width = 0.5625!
        '
        'TextBox53
        '
        Me.TextBox53.DataField = "十一C_MONTH4"
        Me.TextBox53.Height = 0.15!
        Me.TextBox53.Left = 6.75!
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.OutputFormat = resources.GetString("TextBox53.OutputFormat")
        Me.TextBox53.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox53.SummaryGroup = "十一月4"
        Me.TextBox53.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox53.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox53.Text = "十一月4"
        Me.TextBox53.Top = 0.45!
        Me.TextBox53.Width = 0.5625!
        '
        'TextBox54
        '
        Me.TextBox54.DataField = "十二C_MONTH4"
        Me.TextBox54.Height = 0.15!
        Me.TextBox54.Left = 7.3125!
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.OutputFormat = resources.GetString("TextBox54.OutputFormat")
        Me.TextBox54.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox54.SummaryGroup = "十二月4"
        Me.TextBox54.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox54.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox54.Text = "十二月4"
        Me.TextBox54.Top = 0.45!
        Me.TextBox54.Width = 0.5625!
        '
        'TextBox55
        '
        Me.TextBox55.DataField = "一C_MONTH4"
        Me.TextBox55.Height = 0.15!
        Me.TextBox55.Left = 7.875!
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.OutputFormat = resources.GetString("TextBox55.OutputFormat")
        Me.TextBox55.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox55.SummaryGroup = "一月4"
        Me.TextBox55.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox55.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox55.Text = "一月4"
        Me.TextBox55.Top = 0.45!
        Me.TextBox55.Width = 0.5625!
        '
        'TextBox56
        '
        Me.TextBox56.DataField = "二C_MONTH4"
        Me.TextBox56.Height = 0.15!
        Me.TextBox56.Left = 8.4375!
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.OutputFormat = resources.GetString("TextBox56.OutputFormat")
        Me.TextBox56.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox56.SummaryGroup = "二月4"
        Me.TextBox56.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox56.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox56.Text = "二月4"
        Me.TextBox56.Top = 0.45!
        Me.TextBox56.Width = 0.5625!
        '
        'TextBox57
        '
        Me.TextBox57.DataField = "三C_MONTH4"
        Me.TextBox57.Height = 0.15!
        Me.TextBox57.Left = 9!
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.OutputFormat = resources.GetString("TextBox57.OutputFormat")
        Me.TextBox57.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox57.SummaryGroup = "三月4"
        Me.TextBox57.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox57.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox57.Text = "三月4"
        Me.TextBox57.Top = 0.45!
        Me.TextBox57.Width = 0.5625!
        '
        'TextBox58
        '
        Me.TextBox58.DataField = "上半TERM4"
        Me.TextBox58.Height = 0.15!
        Me.TextBox58.Left = 9.5625!
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.OutputFormat = resources.GetString("TextBox58.OutputFormat")
        Me.TextBox58.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox58.SummaryGroup = "上半期4"
        Me.TextBox58.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox58.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox58.Text = "上半期4"
        Me.TextBox58.Top = 0.45!
        Me.TextBox58.Width = 0.5625!
        '
        'TextBox59
        '
        Me.TextBox59.DataField = "下半TERM4"
        Me.TextBox59.Height = 0.15!
        Me.TextBox59.Left = 10.125!
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.OutputFormat = resources.GetString("TextBox59.OutputFormat")
        Me.TextBox59.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox59.SummaryGroup = "下半期4"
        Me.TextBox59.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox59.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox59.Text = "下半期4"
        Me.TextBox59.Top = 0.45!
        Me.TextBox59.Width = 0.5625!
        '
        'TextBox60
        '
        Me.TextBox60.DataField = "合計4"
        Me.TextBox60.Height = 0.15!
        Me.TextBox60.Left = 10.6875!
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.OutputFormat = resources.GetString("TextBox60.OutputFormat")
        Me.TextBox60.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ri" & _
            "ght; vertical-align: middle"
        Me.TextBox60.SummaryGroup = "半期合計4"
        Me.TextBox60.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox60.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox60.Text = "半期合計4"
        Me.TextBox60.Top = 0.45!
        Me.TextBox60.Width = 0.6875!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.125!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.6000001!
        Me.Line2.Width = 11.25!
        Me.Line2.X1 = 0.125!
        Me.Line2.X2 = 11.375!
        Me.Line2.Y1 = 0.6000001!
        Me.Line2.Y2 = 0.6000001!
        '
        'Line19
        '
        Me.Line19.Height = 0.6000001!
        Me.Line19.Left = 11.375!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 11.375!
        Me.Line19.X2 = 11.375!
        Me.Line19.Y1 = 0!
        Me.Line19.Y2 = 0.6000001!
        '
        'Line22
        '
        Me.Line22.Height = 0.6000001!
        Me.Line22.Left = 10.6875!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 0!
        Me.Line22.Width = 0!
        Me.Line22.X1 = 10.6875!
        Me.Line22.X2 = 10.6875!
        Me.Line22.Y1 = 0!
        Me.Line22.Y2 = 0.6000001!
        '
        'Line23
        '
        Me.Line23.Height = 0.6000001!
        Me.Line23.Left = 10.125!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 0!
        Me.Line23.Width = 0!
        Me.Line23.X1 = 10.125!
        Me.Line23.X2 = 10.125!
        Me.Line23.Y1 = 0!
        Me.Line23.Y2 = 0.6000001!
        '
        'Line24
        '
        Me.Line24.Height = 0.6000001!
        Me.Line24.Left = 9.5625!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 0!
        Me.Line24.Width = 0!
        Me.Line24.X1 = 9.5625!
        Me.Line24.X2 = 9.5625!
        Me.Line24.Y1 = 0!
        Me.Line24.Y2 = 0.6000001!
        '
        'Line40
        '
        Me.Line40.Height = 0.6000001!
        Me.Line40.Left = 9!
        Me.Line40.LineWeight = 1!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 0!
        Me.Line40.Width = 0!
        Me.Line40.X1 = 9!
        Me.Line40.X2 = 9!
        Me.Line40.Y1 = 0!
        Me.Line40.Y2 = 0.6000001!
        '
        'Line44
        '
        Me.Line44.Height = 0.6000001!
        Me.Line44.Left = 8.4375!
        Me.Line44.LineWeight = 1!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 0!
        Me.Line44.Width = 0!
        Me.Line44.X1 = 8.4375!
        Me.Line44.X2 = 8.4375!
        Me.Line44.Y1 = 0!
        Me.Line44.Y2 = 0.6000001!
        '
        'Line45
        '
        Me.Line45.Height = 0.6000001!
        Me.Line45.Left = 7.875!
        Me.Line45.LineWeight = 1!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 0!
        Me.Line45.Width = 0!
        Me.Line45.X1 = 7.875!
        Me.Line45.X2 = 7.875!
        Me.Line45.Y1 = 0!
        Me.Line45.Y2 = 0.6000001!
        '
        'Line46
        '
        Me.Line46.Height = 0.6000001!
        Me.Line46.Left = 7.3125!
        Me.Line46.LineWeight = 1!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 0!
        Me.Line46.Width = 0!
        Me.Line46.X1 = 7.3125!
        Me.Line46.X2 = 7.3125!
        Me.Line46.Y1 = 0!
        Me.Line46.Y2 = 0.6000001!
        '
        'Line49
        '
        Me.Line49.Height = 0.6000001!
        Me.Line49.Left = 6.75!
        Me.Line49.LineWeight = 1!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 0!
        Me.Line49.Width = 0!
        Me.Line49.X1 = 6.75!
        Me.Line49.X2 = 6.75!
        Me.Line49.Y1 = 0!
        Me.Line49.Y2 = 0.6000001!
        '
        'Line50
        '
        Me.Line50.Height = 0.6000001!
        Me.Line50.Left = 6.1875!
        Me.Line50.LineWeight = 1!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 0!
        Me.Line50.Width = 0!
        Me.Line50.X1 = 6.1875!
        Me.Line50.X2 = 6.1875!
        Me.Line50.Y1 = 0!
        Me.Line50.Y2 = 0.6000001!
        '
        'Line51
        '
        Me.Line51.Height = 0.6000001!
        Me.Line51.Left = 5.625!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 0!
        Me.Line51.Width = 0!
        Me.Line51.X1 = 5.625!
        Me.Line51.X2 = 5.625!
        Me.Line51.Y1 = 0!
        Me.Line51.Y2 = 0.6000001!
        '
        'Line52
        '
        Me.Line52.Height = 0.6000001!
        Me.Line52.Left = 5.0625!
        Me.Line52.LineWeight = 1!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 0!
        Me.Line52.Width = 0!
        Me.Line52.X1 = 5.0625!
        Me.Line52.X2 = 5.0625!
        Me.Line52.Y1 = 0!
        Me.Line52.Y2 = 0.6000001!
        '
        'Line53
        '
        Me.Line53.Height = 0.6000001!
        Me.Line53.Left = 4.5!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 0!
        Me.Line53.Width = 0!
        Me.Line53.X1 = 4.5!
        Me.Line53.X2 = 4.5!
        Me.Line53.Y1 = 0!
        Me.Line53.Y2 = 0.6000001!
        '
        'Line66
        '
        Me.Line66.Height = 0.6000001!
        Me.Line66.Left = 3.9375!
        Me.Line66.LineWeight = 1!
        Me.Line66.Name = "Line66"
        Me.Line66.Top = 0!
        Me.Line66.Width = 0!
        Me.Line66.X1 = 3.9375!
        Me.Line66.X2 = 3.9375!
        Me.Line66.Y1 = 0!
        Me.Line66.Y2 = 0.6000001!
        '
        'Line70
        '
        Me.Line70.Height = 0.6000001!
        Me.Line70.Left = 0.125!
        Me.Line70.LineWeight = 1!
        Me.Line70.Name = "Line70"
        Me.Line70.Top = 0!
        Me.Line70.Width = 0!
        Me.Line70.X1 = 0.125!
        Me.Line70.X2 = 0.125!
        Me.Line70.Y1 = 0!
        Me.Line70.Y2 = 0.6000001!
        '
        'Line71
        '
        Me.Line71.Height = 0.6000001!
        Me.Line71.Left = 3.375!
        Me.Line71.LineWeight = 1!
        Me.Line71.Name = "Line71"
        Me.Line71.Top = 0!
        Me.Line71.Width = 0!
        Me.Line71.X1 = 3.375!
        Me.Line71.X2 = 3.375!
        Me.Line71.Y1 = 0!
        Me.Line71.Y2 = 0.6000001!
        '
        'Line72
        '
        Me.Line72.Height = 0.6000001!
        Me.Line72.Left = 2.8125!
        Me.Line72.LineWeight = 1!
        Me.Line72.Name = "Line72"
        Me.Line72.Top = 0!
        Me.Line72.Width = 0!
        Me.Line72.X1 = 2.8125!
        Me.Line72.X2 = 2.8125!
        Me.Line72.Y1 = 0!
        Me.Line72.Y2 = 0.6000001!
        '
        'Line77
        '
        Me.Line77.Height = 0.6000001!
        Me.Line77.Left = 2.125!
        Me.Line77.LineWeight = 1!
        Me.Line77.Name = "Line77"
        Me.Line77.Top = 0!
        Me.Line77.Width = 0!
        Me.Line77.X1 = 2.125!
        Me.Line77.X2 = 2.125!
        Me.Line77.Y1 = 0!
        Me.Line77.Y2 = 0.6000001!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.1!
        Me.PageSettings.Margins.Right = 0.1!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.48958!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtA_YEAR1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtA_YEAR2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtタイトル, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt四C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt五C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt六C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt七C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt八C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt九C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十一C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十二C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt一C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt二C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt三C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt上半TERM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt下半TERM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt四C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt五C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt六C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt七C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt八C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt九C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十一C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十二C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt一C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt二C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt三C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt上半TERM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt下半TERM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt名称, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt半TERM合計1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt半TERM合計2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt四C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt五C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt六C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt七C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt八C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt九C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十一C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十二C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt一C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt二C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt三C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt上半TERM3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt下半TERM3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt半TERM合計3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt四C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt五C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt六C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt七C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt八C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt九C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十一C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt十二C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt一C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt二C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt三C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt上半TERM4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt下半TERM4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt半TERM合計4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKei, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum四C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum五C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum四C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum四C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum四C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum六C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum七C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum八C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum九C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十一C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十二C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum一C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum二C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum三C_MONTH1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum上半TERM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum下半TERM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum五C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum六C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum七C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum八C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum九C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十一C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十二C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum一C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum二C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum三C_MONTH2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum上半TERM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum下半TERM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum半TERM合計1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum半TERM合計2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum五C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum六C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum七C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum八C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum九C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十一C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十二C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum一C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum二C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum三C_MONTH3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum上半TERM3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum下半TERM3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum半TERM合計3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum五C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum六C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum七C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum八C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum九C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十一C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum十二C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum一C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum二C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum三C_MONTH4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum上半TERM4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum下半TERM4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sum半TERM合計4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox61, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox38, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox46, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox47, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox48, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox49, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox50, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox51, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox52, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox53, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox54, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox55, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox56, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox57, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox58, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox59, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox60, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1
    Private maxRow As Integer = 11
    Private tmpCode As String = ""

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        '日付 
        lblDate.Text = DateTime.Now.Date.ToString("yy.MM.dd")
        'ページ 
        lblPage.Text = "Page." + nPage.ToString("#")
        nPage += 1
    End Sub

    Public WriteOnly Property Nendo() As String
        Set(ByVal sValue As String)
            txtA_YEAR1.Text = sValue
            txtA_YEAR2.Text = sValue
        End Set
    End Property

    Public WriteOnly Property Title() As String
        Set(ByVal sValue As String)
            txtタイトル.Text = sValue
            If sValue = "組番別" Or sValue = "グループ2別" Then
                lblKei.Text = "合 計"
                Me.ReportFooter.Visible = False
                If txtタイトル.Text = "グループ2別" Then
                    Me.GroupFooter1.Visible = False
                End If
            End If
        End Set
    End Property

    Public WriteOnly Property Sitei() As String
        Set(ByVal sValue As String)
            If sValue <> "" Then
                lblKei.Text = "合 計"
                Me.ReportFooter.Visible = False
            End If
        End Set
    End Property

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

        If tmpCode = "" Then
            tmpCode = lblCode.Text
        ElseIf Me.GroupFooter1.Visible = False And tmpCode = lblCode.Text Then
            Me.GroupFooter1.Visible = True
        End If

        If RowNumber = 0 Then
            txt名称.Visible = True
        Else
            txt名称.Visible = False
        End If

        RowNumber = RowNumber + 1
        If RowNumber < maxRow Then
            ' 件数がmaxRow件に満たない場合、改ページは行ないません。 
            Me.Detail.NewPage = NewPage.None
        Else
            ' maxRow件出力した後、改ページを行い、カウンタをリセットします。 
            Me.Detail.NewPage = NewPage.After
            RowNumber = 0
        End If
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        RowNumber = 0
    End Sub
End Class 
