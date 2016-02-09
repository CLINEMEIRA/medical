Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdjsk040
    Inherits GrapeCity.ActiveReports.SectionReport

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
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtINDICATE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtWORK_TIME As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtFACILITIES_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtFACILITIES_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdjsk040))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtINDICATE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtWORK_TIME = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFACILITIES_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFACILITIES_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWORK_TIME, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtFACILITIES_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtFACILITIES_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.CanShrink = true
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtWORK_TIME, Me.txtFACILITIES_NM, Me.txtFACILITIES_CD})
        Me.Detail.Height = 0.1979167!
        Me.Detail.Name = "Detail"
        '
        'ReportHeader
        '
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.Visible = false
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox, Me.Line2})
        Me.ReportFooter.Height = 0.2!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label, Me.lblDate, Me.lblPage, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.lblFrom, Me.Label8, Me.lblTo})
        Me.PageHeader.Height = 1.020833!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.2388889!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'GroupHeader1
        '
        Me.GroupHeader1.CanShrink = true
        Me.GroupHeader1.ColumnLayout = false
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtINDICATE_NO, Me.txtCATALOG_NO, Me.txtCOMPANY_NO, Me.Line})
        Me.GroupHeader1.DataField = "INDICATE_NO"
        Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.GroupHeader1.Height = 0.2!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPageIncludeNoDetail
        Me.GroupHeader1.UnderlayNext = true
        '
        'GroupFooter1
        '
        Me.GroupFooter1.CanShrink = true
        Me.GroupFooter1.Height = 0.1979167!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center"
        Me.Label.Text = "※※※　修正工程稼動時間表　※※※"
        Me.Label.Top = 0.1875!
        Me.Label.Width = 7.5!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.8125!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: bottom"
        Me.lblDate.Text = "YY.MM.DD"
        Me.lblDate.Top = 0.125!
        Me.lblDate.Width = 0.5333332!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 6.8125!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.lblPage.Text = "Page.#"
        Me.lblPage.Top = 0.3125!
        Me.lblPage.Width = 0.4666668!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 2.6875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label1.Text = "指示NO"
        Me.Label1.Top = 0.8125!
        Me.Label1.Width = 0.5!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.75!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label2.Text = "カタログ番号"
        Me.Label2.Top = 0.8125!
        Me.Label2.Width = 1.3125!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label3.Text = "社内NO"
        Me.Label3.Top = 0.8125!
        Me.Label3.Width = 0.5!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.3125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label4.Text = "設備コード"
        Me.Label4.Top = 0.8125!
        Me.Label4.Width = 0.75!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 4.125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label5.Text = "設備名称"
        Me.Label5.Top = 0.8125!
        Me.Label5.Width = 1.6875!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 5.875!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: middle"
        Me.Label6.Text = "稼働時間"
        Me.Label6.Top = 0.8125!
        Me.Label6.Width = 0.8125!
        '
        'lblFrom
        '
        Me.lblFrom.Height = 0.2!
        Me.lblFrom.HyperLink = Nothing
        Me.lblFrom.Left = 0.375!
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.lblFrom.Text = "YYYY/MM/DD"
        Me.lblFrom.Top = 0.5!
        Me.lblFrom.Width = 0.875!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 1.25!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label8.Text = "～"
        Me.Label8.Top = 0.5!
        Me.Label8.Width = 0.25!
        '
        'lblTo
        '
        Me.lblTo.Height = 0.2!
        Me.lblTo.HyperLink = Nothing
        Me.lblTo.Left = 1.5!
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.lblTo.Text = "YYYY/MM/DD"
        Me.lblTo.Top = 0.5!
        Me.lblTo.Width = 0.875!
        '
        'txtINDICATE_NO
        '
        Me.txtINDICATE_NO.DataField = "INDICATE_NO"
        Me.txtINDICATE_NO.Height = 0.2!
        Me.txtINDICATE_NO.Left = 2.6875!
        Me.txtINDICATE_NO.Name = "txtINDICATE_NO"
        Me.txtINDICATE_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO.Text = "指示NO"
        Me.txtINDICATE_NO.Top = 0!
        Me.txtINDICATE_NO.Width = 0.5!
        '
        'txtCATALOG_NO
        '
        Me.txtCATALOG_NO.DataField = "CATALOG_NO"
        Me.txtCATALOG_NO.Height = 0.2!
        Me.txtCATALOG_NO.Left = 0.75!
        Me.txtCATALOG_NO.Name = "txtCATALOG_NO"
        Me.txtCATALOG_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txtCATALOG_NO.Text = "XXXXXXXXXXXXXXXXX"
        Me.txtCATALOG_NO.Top = 0!
        Me.txtCATALOG_NO.Width = 1.3125!
        '
        'txtCOMPANY_NO
        '
        Me.txtCOMPANY_NO.DataField = "COMPANY_NO"
        Me.txtCOMPANY_NO.Height = 0.2!
        Me.txtCOMPANY_NO.Left = 2.125!
        Me.txtCOMPANY_NO.Name = "txtCOMPANY_NO"
        Me.txtCOMPANY_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO.Text = "社内NO"
        Me.txtCOMPANY_NO.Top = 0!
        Me.txtCOMPANY_NO.Width = 0.5!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.625!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0!
        Me.Line.Width = 6.1875!
        Me.Line.X1 = 0.625!
        Me.Line.X2 = 6.8125!
        Me.Line.Y1 = 0!
        Me.Line.Y2 = 0!
        '
        'txtWORK_TIME
        '
        Me.txtWORK_TIME.DataField = "WORK_TIME"
        Me.txtWORK_TIME.Height = 0.2!
        Me.txtWORK_TIME.Left = 5.875!
        Me.txtWORK_TIME.Name = "txtWORK_TIME"
        Me.txtWORK_TIME.OutputFormat = resources.GetString("txtWORK_TIME.OutputFormat")
        Me.txtWORK_TIME.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtWORK_TIME.SummaryGroup = "kadouTime"
        Me.txtWORK_TIME.Text = "999,999.99"
        Me.txtWORK_TIME.Top = 0!
        Me.txtWORK_TIME.Width = 0.8125!
        '
        'txtFACILITIES_NM
        '
        Me.txtFACILITIES_NM.DataField = "FACILITIES_NM"
        Me.txtFACILITIES_NM.Height = 0.2!
        Me.txtFACILITIES_NM.Left = 4.125!
        Me.txtFACILITIES_NM.Name = "txtFACILITIES_NM"
        Me.txtFACILITIES_NM.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtFACILITIES_NM.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮ"
        Me.txtFACILITIES_NM.Top = 0!
        Me.txtFACILITIES_NM.Width = 1.6875!
        '
        'txtFACILITIES_CD
        '
        Me.txtFACILITIES_CD.DataField = "FACILITIES_CD"
        Me.txtFACILITIES_CD.Height = 0.2!
        Me.txtFACILITIES_CD.Left = 3.3125!
        Me.txtFACILITIES_CD.Name = "txtFACILITIES_CD"
        Me.txtFACILITIES_CD.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtFACILITIES_CD.Text = "設備コード"
        Me.txtFACILITIES_CD.Top = 0!
        Me.txtFACILITIES_CD.Width = 0.75!
        '
        'TextBox
        '
        Me.TextBox.DataField = "WORK_TIME"
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 5.875!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.OutputFormat = resources.GetString("TextBox.OutputFormat")
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.TextBox.SummaryGroup = "kadouTime"
        Me.TextBox.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox.Text = "999,999.99"
        Me.TextBox.Top = 0!
        Me.TextBox.Width = 0.8125!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.625!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0!
        Me.Line2.Width = 6.188001!
        Me.Line2.X1 = 0.625!
        Me.Line2.X2 = 6.813001!
        Me.Line2.Y1 = 0!
        Me.Line2.Y2 = 0!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = "SELECT * FROM WK_UPD_WORKTIME"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.583333!
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
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWORK_TIME, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtFACILITIES_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtFACILITIES_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1

    Public WriteOnly Property FromYMD() As String
        Set(ByVal sValue As String)
            lblFrom.Text = sValue.Substring(0, 4) & "/" & sValue.Substring(4, 2) & "/" & sValue.Substring(6, 2)
        End Set
    End Property

    Public WriteOnly Property ToYMD() As String
        Set(ByVal sValue As String)
            lblTo.Text = sValue.Substring(0, 4) & "/" & sValue.Substring(4, 2) & "/" & sValue.Substring(6, 2)
        End Set
    End Property

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format

        '日付 
        lblDate.Text = DateTime.Now.Date.ToString("yy.MM.dd")
        'ページ 
        lblPage.Text = "Page." + nPage.ToString("#")
        nPage += 1
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

    End Sub

End Class 
