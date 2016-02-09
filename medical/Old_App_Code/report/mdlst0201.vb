Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdlst0201
    Inherits GrapeCity.ActiveReports.SectionReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBarcode As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private txtName1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdlst0201))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBarcode = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.txtName1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtName1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblBarcode, Me.txtName1, Me.lblCode, Me.TextBox})
        Me.Detail.Height = 1.25!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTitle, Me.lblDate})
        Me.PageHeader.Height = 0.4375!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'lblTitle
        '
        Me.lblTitle.Height = 0.25!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 0.0625!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: bottom" & _
            ""
        Me.lblTitle.Text = "タイトル"
        Me.lblTitle.Top = 0.0625!
        Me.lblTitle.Width = 7.125!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.1875!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 5.625!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.lblDate.Text = "YYYY/MM/DD"
        Me.lblDate.Top = 0.125!
        Me.lblDate.Width = 1.5625!
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = false
        Me.lblBarcode.CheckSumEnabled = false
        Me.lblBarcode.DataField = "コード"
        Me.lblBarcode.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode.Height = 0.625!
        Me.lblBarcode.Left = 0.125!
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.QuietZoneBottom = 0!
        Me.lblBarcode.QuietZoneLeft = 0!
        Me.lblBarcode.QuietZoneRight = 0!
        Me.lblBarcode.QuietZoneTop = 0!
        Me.lblBarcode.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode.Text = "lblBarcode"
        Me.lblBarcode.Top = 0.125!
        Me.lblBarcode.Width = 1.75!
        '
        'txtName1
        '
        Me.txtName1.DataField = "名称1"
        Me.txtName1.Height = 0.1875!
        Me.txtName1.Left = 2!
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.txtName1.Text = "名称1"
        Me.txtName1.Top = 0.1875!
        Me.txtName1.Width = 3.0625!
        '
        'lblCode
        '
        Me.lblCode.DataField = "コード"
        Me.lblCode.Height = 0.1875!
        Me.lblCode.Left = 0.125!
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode.Text = "Code"
        Me.lblCode.Top = 0.8125!
        Me.lblCode.Width = 1.75!
        '
        'TextBox
        '
        Me.TextBox.DataField = "名称2"
        Me.TextBox.Height = 0.1875!
        Me.TextBox.Left = 5.125!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.TextBox.Text = "名称1"
        Me.TextBox.Top = 0.1875!
        Me.TextBox.Width = 2.0625!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=orcl;Persist Secu" & _
            "rity Info=True"
        OleDBDataSource1.SQL = "SELECT '*' || FACILITIES_CD || '*' AS コード,FACILITIES_NM AS 名称1,MAKER_NM AS 名称2 FR" & _
            "OM FACILITIES_MST ORDER BY FACILITIES_CD"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSource = false
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperSource = System.Drawing.Printing.PaperSourceKind.FormSource
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.25!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtName1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit
    End Sub

#End Region

    Public WriteOnly Property Title() As String
        Set(ByVal sValue As String)
            lblTitle.Text = sValue
        End Set
    End Property

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        lblCode.Text = "*" + lblCode.Text + "*"
    End Sub

End Class 
