Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdlst0202
    Inherits GrapeCity.ActiveReports.SectionReport
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Private lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBarcode1 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private lblCode1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblBarcode2 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private lblCode2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblBarcode3 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private lblCode3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblBarcode4 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private lblCode4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblBarcode5 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private lblCode5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblBarcode6 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private lblCode6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblBarcode7 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private lblCode7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblBarcode8 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private lblCode8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdlst0202))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBarcode1 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.lblCode1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblBarcode2 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.lblCode2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblBarcode3 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.lblCode3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblBarcode4 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.lblCode4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblBarcode5 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.lblCode5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblBarcode6 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.lblCode6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblBarcode7 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.lblCode7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblBarcode8 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.lblCode8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblBarcode1, Me.lblCode1, Me.lblBarcode2, Me.lblCode2, Me.lblBarcode3, Me.lblCode3, Me.lblBarcode4, Me.lblCode4, Me.lblBarcode5, Me.lblCode5, Me.lblBarcode6, Me.lblCode6, Me.lblBarcode7, Me.lblCode7, Me.lblBarcode8, Me.lblCode8})
        Me.Detail.Height = 10!
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
        Me.lblTitle.Text = "フリー入力　バーコード"
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
        'lblBarcode1
        '
        Me.lblBarcode1.AutoSize = false
        Me.lblBarcode1.CheckSumEnabled = false
        Me.lblBarcode1.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode1.Height = 0.625!
        Me.lblBarcode1.Left = 0.125!
        Me.lblBarcode1.Name = "lblBarcode1"
        Me.lblBarcode1.QuietZoneBottom = 0!
        Me.lblBarcode1.QuietZoneLeft = 0!
        Me.lblBarcode1.QuietZoneRight = 0!
        Me.lblBarcode1.QuietZoneTop = 0!
        Me.lblBarcode1.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode1.Text = "lblBarcode"
        Me.lblBarcode1.Top = 0.125!
        Me.lblBarcode1.Width = 4.875!
        '
        'lblCode1
        '
        Me.lblCode1.Height = 0.1875!
        Me.lblCode1.Left = 0.125!
        Me.lblCode1.Name = "lblCode1"
        Me.lblCode1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode1.Text = "Code"
        Me.lblCode1.Top = 0.8125!
        Me.lblCode1.Width = 4.875!
        '
        'lblBarcode2
        '
        Me.lblBarcode2.AutoSize = false
        Me.lblBarcode2.CheckSumEnabled = false
        Me.lblBarcode2.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode2.Height = 0.625!
        Me.lblBarcode2.Left = 0.125!
        Me.lblBarcode2.Name = "lblBarcode2"
        Me.lblBarcode2.QuietZoneBottom = 0!
        Me.lblBarcode2.QuietZoneLeft = 0!
        Me.lblBarcode2.QuietZoneRight = 0!
        Me.lblBarcode2.QuietZoneTop = 0!
        Me.lblBarcode2.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode2.Text = "lblBarcode"
        Me.lblBarcode2.Top = 1.375!
        Me.lblBarcode2.Width = 4.875!
        '
        'lblCode2
        '
        Me.lblCode2.Height = 0.1875!
        Me.lblCode2.Left = 0.125!
        Me.lblCode2.Name = "lblCode2"
        Me.lblCode2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode2.Text = "Code"
        Me.lblCode2.Top = 2.0625!
        Me.lblCode2.Width = 4.875!
        '
        'lblBarcode3
        '
        Me.lblBarcode3.AutoSize = false
        Me.lblBarcode3.CheckSumEnabled = false
        Me.lblBarcode3.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode3.Height = 0.625!
        Me.lblBarcode3.Left = 0.125!
        Me.lblBarcode3.Name = "lblBarcode3"
        Me.lblBarcode3.QuietZoneBottom = 0!
        Me.lblBarcode3.QuietZoneLeft = 0!
        Me.lblBarcode3.QuietZoneRight = 0!
        Me.lblBarcode3.QuietZoneTop = 0!
        Me.lblBarcode3.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode3.Text = "lblBarcode"
        Me.lblBarcode3.Top = 2.625!
        Me.lblBarcode3.Width = 4.875!
        '
        'lblCode3
        '
        Me.lblCode3.Height = 0.1875!
        Me.lblCode3.Left = 0.125!
        Me.lblCode3.Name = "lblCode3"
        Me.lblCode3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode3.Text = "Code"
        Me.lblCode3.Top = 3.3125!
        Me.lblCode3.Width = 4.875!
        '
        'lblBarcode4
        '
        Me.lblBarcode4.AutoSize = false
        Me.lblBarcode4.CheckSumEnabled = false
        Me.lblBarcode4.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode4.Height = 0.625!
        Me.lblBarcode4.Left = 0.125!
        Me.lblBarcode4.Name = "lblBarcode4"
        Me.lblBarcode4.QuietZoneBottom = 0!
        Me.lblBarcode4.QuietZoneLeft = 0!
        Me.lblBarcode4.QuietZoneRight = 0!
        Me.lblBarcode4.QuietZoneTop = 0!
        Me.lblBarcode4.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode4.Text = "lblBarcode"
        Me.lblBarcode4.Top = 3.875!
        Me.lblBarcode4.Width = 4.875!
        '
        'lblCode4
        '
        Me.lblCode4.Height = 0.1875!
        Me.lblCode4.Left = 0.125!
        Me.lblCode4.Name = "lblCode4"
        Me.lblCode4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode4.Text = "Code"
        Me.lblCode4.Top = 4.5625!
        Me.lblCode4.Width = 4.875!
        '
        'lblBarcode5
        '
        Me.lblBarcode5.AutoSize = false
        Me.lblBarcode5.CheckSumEnabled = false
        Me.lblBarcode5.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode5.Height = 0.625!
        Me.lblBarcode5.Left = 0.125!
        Me.lblBarcode5.Name = "lblBarcode5"
        Me.lblBarcode5.QuietZoneBottom = 0!
        Me.lblBarcode5.QuietZoneLeft = 0!
        Me.lblBarcode5.QuietZoneRight = 0!
        Me.lblBarcode5.QuietZoneTop = 0!
        Me.lblBarcode5.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode5.Text = "lblBarcode"
        Me.lblBarcode5.Top = 5.125!
        Me.lblBarcode5.Width = 4.875!
        '
        'lblCode5
        '
        Me.lblCode5.Height = 0.1875!
        Me.lblCode5.Left = 0.125!
        Me.lblCode5.Name = "lblCode5"
        Me.lblCode5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode5.Text = "Code"
        Me.lblCode5.Top = 5.8125!
        Me.lblCode5.Width = 4.875!
        '
        'lblBarcode6
        '
        Me.lblBarcode6.AutoSize = false
        Me.lblBarcode6.CheckSumEnabled = false
        Me.lblBarcode6.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode6.Height = 0.625!
        Me.lblBarcode6.Left = 0.125!
        Me.lblBarcode6.Name = "lblBarcode6"
        Me.lblBarcode6.QuietZoneBottom = 0!
        Me.lblBarcode6.QuietZoneLeft = 0!
        Me.lblBarcode6.QuietZoneRight = 0!
        Me.lblBarcode6.QuietZoneTop = 0!
        Me.lblBarcode6.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode6.Text = "lblBarcode"
        Me.lblBarcode6.Top = 6.375!
        Me.lblBarcode6.Width = 4.875!
        '
        'lblCode6
        '
        Me.lblCode6.Height = 0.1875!
        Me.lblCode6.Left = 0.125!
        Me.lblCode6.Name = "lblCode6"
        Me.lblCode6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode6.Text = "Code"
        Me.lblCode6.Top = 7.0625!
        Me.lblCode6.Width = 4.875!
        '
        'lblBarcode7
        '
        Me.lblBarcode7.AutoSize = false
        Me.lblBarcode7.CheckSumEnabled = false
        Me.lblBarcode7.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode7.Height = 0.625!
        Me.lblBarcode7.Left = 0.125!
        Me.lblBarcode7.Name = "lblBarcode7"
        Me.lblBarcode7.QuietZoneBottom = 0!
        Me.lblBarcode7.QuietZoneLeft = 0!
        Me.lblBarcode7.QuietZoneRight = 0!
        Me.lblBarcode7.QuietZoneTop = 0!
        Me.lblBarcode7.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode7.Text = "lblBarcode"
        Me.lblBarcode7.Top = 7.625!
        Me.lblBarcode7.Width = 4.875!
        '
        'lblCode7
        '
        Me.lblCode7.Height = 0.1875!
        Me.lblCode7.Left = 0.125!
        Me.lblCode7.Name = "lblCode7"
        Me.lblCode7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode7.Text = "Code"
        Me.lblCode7.Top = 8.3125!
        Me.lblCode7.Width = 4.875!
        '
        'lblBarcode8
        '
        Me.lblBarcode8.AutoSize = false
        Me.lblBarcode8.CheckSumEnabled = false
        Me.lblBarcode8.Font = New System.Drawing.Font("Courier New", 8!)
        Me.lblBarcode8.Height = 0.625!
        Me.lblBarcode8.Left = 0.125!
        Me.lblBarcode8.Name = "lblBarcode8"
        Me.lblBarcode8.QuietZoneBottom = 0!
        Me.lblBarcode8.QuietZoneLeft = 0!
        Me.lblBarcode8.QuietZoneRight = 0!
        Me.lblBarcode8.QuietZoneTop = 0!
        Me.lblBarcode8.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.lblBarcode8.Text = "lblBarcode"
        Me.lblBarcode8.Top = 8.875!
        Me.lblBarcode8.Width = 4.875!
        '
        'lblCode8
        '
        Me.lblCode8.Height = 0.1875!
        Me.lblCode8.Left = 0.125!
        Me.lblCode8.Name = "lblCode8"
        Me.lblCode8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.lblCode8.Text = "Code"
        Me.lblCode8.Top = 9.5625!
        Me.lblCode8.Width = 4.875!
        '
        'SectionReport1
        '
        Me.MasterReport = false
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
        CType(Me.lblCode1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit
    End Sub

#End Region

    Private oBarcode(8) As GrapeCity.ActiveReports.SectionReportModel.Barcode

    Private oCode(8) As GrapeCity.ActiveReports.SectionReportModel.TextBox

    Public WriteOnly Property Barcode(ByVal nIndex As Integer) As String
        Set(ByVal sValue As String)
            oBarcode(nIndex).Text = sValue
            oBarcode(nIndex).Visible = True
        End Set
    End Property

    Public WriteOnly Property Code(ByVal nIndex As Integer) As String
        Set(ByVal sValue As String)
            oCode(nIndex).Text = "*" + sValue + "*"
            oCode(nIndex).Visible = True
        End Set
    End Property

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

End Class 
