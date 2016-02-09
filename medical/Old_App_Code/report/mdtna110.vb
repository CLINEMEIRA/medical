Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdtna110
    Inherits GrapeCity.ActiveReports.SectionReport
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtZaiRyoSuu As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZairyoKen As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtBuhinSuu As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSikakariSuu As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSikakariKen As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtBuhinKen As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtna110))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtZaiRyoSuu = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZairyoKen = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBuhinSuu = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSikakariSuu = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSikakariKen = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtBuhinKen = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZaiRyoSuu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyoKen, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBuhinSuu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSikakariSuu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSikakariKen, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBuhinKen, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.txtZaiRyoSuu, Me.txtZairyoKen, Me.txtBuhinSuu, Me.txtSikakariSuu, Me.Label19, Me.txtSikakariKen, Me.Line3, Me.Line4, Me.Line5, Me.Label16, Me.txtBuhinKen})
        Me.Detail.Height = 2.1875!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label, Me.Line, Me.Line1, Me.Line2, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label15, Me.lblDate})
        Me.PageHeader.Height = 2.416667!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'Label
        '
        Me.Label.Height = 0.3125!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.3177083!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 18pt; font-weight: bold; text-align: center; ver" & _
            "tical-align: middle"
        Me.Label.Text = "ファクシミリご案内"
        Me.Label.Top = 0.125!
        Me.Label.Width = 2.3125!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.4427083!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.125!
        Me.Line.Width = 6.3125!
        Me.Line.X1 = 0.4427083!
        Me.Line.X2 = 6.755208!
        Me.Line.Y1 = 1.125!
        Me.Line.Y2 = 1.125!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.4427083!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.75!
        Me.Line1.Width = 6.3125!
        Me.Line1.X1 = 0.4427083!
        Me.Line1.X2 = 6.755208!
        Me.Line1.Y1 = 1.75!
        Me.Line1.Y2 = 1.75!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.4427083!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.375!
        Me.Line2.Width = 6.3125!
        Me.Line2.X1 = 0.4427083!
        Me.Line2.X2 = 6.755208!
        Me.Line2.Y1 = 2.375!
        Me.Line2.Y2 = 2.375!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.5677083!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: middle" & _
            ""
        Me.Label1.Text = "＜送信先＞"
        Me.Label1.Top = 0.6875!
        Me.Label1.Width = 0.875!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.5677083!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: middle" & _
            ""
        Me.Label2.Text = "＜発信元＞"
        Me.Label2.Top = 1.3125!
        Me.Label2.Width = 0.875!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.5677083!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: middle" & _
            ""
        Me.Label3.Text = "＜件　名＞"
        Me.Label3.Top = 1.9375!
        Me.Label3.Width = 0.875!
        '
        'Label4
        '
        Me.Label4.Height = 0.2625001!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.4375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 15.75pt; font-weight: bold; text-align: center; " & _
            "vertical-align: middle"
        Me.Label4.Text = "情報システム部　北村様"
        Me.Label4.Top = 0.8125!
        Me.Label4.Width = 3.4375!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 5.1875!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-align: center; v" & _
            "ertical-align: middle"
        Me.Label5.Text = "FAX １９２０"
        Me.Label5.Top = 0.875!
        Me.Label5.Width = 1.125!
        '
        'Label6
        '
        Me.Label6.Height = 0.2624999!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.4375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 15.75pt; font-weight: bold; text-align: center; " & _
            "vertical-align: middle"
        Me.Label6.Text = "メディカル事業部"
        Me.Label6.Top = 1.4375!
        Me.Label6.Width = 3.4375!
        '
        'Label7
        '
        Me.Label7.Height = 0.2625001!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.4375!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 15.75pt; font-weight: bold; text-align: center; " & _
            "vertical-align: middle"
        Me.Label7.Text = "棚卸伝送処理件数"
        Me.Label7.Top = 2.0625!
        Me.Label7.Width = 3.4375!
        '
        'Label15
        '
        Me.Label15.Height = 0.2!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 4.4375!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-align: center; v" & _
            "ertical-align: middle"
        Me.Label15.Text = "発信"
        Me.Label15.Top = 0.1875!
        Me.Label15.Width = 0.5625!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 5.0625!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-align: center; v" & _
            "ertical-align: middle"
        Me.lblDate.Text = ""
        Me.lblDate.Top = 0.1875!
        Me.lblDate.Width = 1.8125!
        '
        'Label8
        '
        Me.Label8.Height = 0.2625001!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 1.000208!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label8.Text = "主材料"
        Me.Label8.Top = 0.25!
        Me.Label8.Width = 1.0625!
        '
        'Label9
        '
        Me.Label9.Height = 0.2625001!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 1!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label9.Text = "源製品・子部品"
        Me.Label9.Top = 0.5625!
        Me.Label9.Width = 1.5!
        '
        'Label10
        '
        Me.Label10.Height = 0.2625001!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 1!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label10.Text = "仕掛"
        Me.Label10.Top = 0.8755!
        Me.Label10.Width = 1.0625!
        '
        'Label11
        '
        Me.Label11.Height = 0.2625001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.6875!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label11.Text = "重量"
        Me.Label11.Top = 0.25!
        Me.Label11.Width = 0.6197917!
        '
        'Label12
        '
        Me.Label12.Height = 0.2625001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 2.6875!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label12.Text = "数量"
        Me.Label12.Top = 0.5625!
        Me.Label12.Width = 0.6197917!
        '
        'Label13
        '
        Me.Label13.Height = 0.2625001!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 2.6875!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label13.Text = "数量"
        Me.Label13.Top = 0.8755!
        Me.Label13.Width = 0.6197917!
        '
        'Label14
        '
        Me.Label14.Height = 0.2625001!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 4.75!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: justify;" & _
            " vertical-align: middle"
        Me.Label14.Text = "件数"
        Me.Label14.Top = 0.25!
        Me.Label14.Width = 0.5572916!
        '
        'txtZaiRyoSuu
        '
        Me.txtZaiRyoSuu.DataField = "ZSU"
        Me.txtZaiRyoSuu.Height = 0.2625001!
        Me.txtZaiRyoSuu.Left = 3.369792!
        Me.txtZaiRyoSuu.Name = "txtZaiRyoSuu"
        Me.txtZaiRyoSuu.OutputFormat = resources.GetString("txtZaiRyoSuu.OutputFormat")
        Me.txtZaiRyoSuu.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtZaiRyoSuu.Top = 0.25!
        Me.txtZaiRyoSuu.Width = 1.125!
        '
        'txtZairyoKen
        '
        Me.txtZairyoKen.DataField = "ZCT"
        Me.txtZairyoKen.Height = 0.2625001!
        Me.txtZairyoKen.Left = 5.369792!
        Me.txtZairyoKen.Name = "txtZairyoKen"
        Me.txtZairyoKen.OutputFormat = resources.GetString("txtZairyoKen.OutputFormat")
        Me.txtZairyoKen.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtZairyoKen.Top = 0.25!
        Me.txtZairyoKen.Width = 0.9947917!
        '
        'txtBuhinSuu
        '
        Me.txtBuhinSuu.DataField = "BSU"
        Me.txtBuhinSuu.Height = 0.2625001!
        Me.txtBuhinSuu.Left = 3.369792!
        Me.txtBuhinSuu.Name = "txtBuhinSuu"
        Me.txtBuhinSuu.OutputFormat = resources.GetString("txtBuhinSuu.OutputFormat")
        Me.txtBuhinSuu.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtBuhinSuu.Top = 0.5625!
        Me.txtBuhinSuu.Width = 1.125!
        '
        'txtSikakariSuu
        '
        Me.txtSikakariSuu.DataField = "SSU"
        Me.txtSikakariSuu.Height = 0.2625001!
        Me.txtSikakariSuu.Left = 3.369792!
        Me.txtSikakariSuu.Name = "txtSikakariSuu"
        Me.txtSikakariSuu.OutputFormat = resources.GetString("txtSikakariSuu.OutputFormat")
        Me.txtSikakariSuu.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtSikakariSuu.Top = 0.8755!
        Me.txtSikakariSuu.Width = 1.125!
        '
        'Label19
        '
        Me.Label19.Height = 0.2625001!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 4.75!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label19.Text = "件数"
        Me.Label19.Top = 0.875!
        Me.Label19.Width = 0.5572916!
        '
        'txtSikakariKen
        '
        Me.txtSikakariKen.DataField = "SCT"
        Me.txtSikakariKen.Height = 0.2625001!
        Me.txtSikakariKen.Left = 5.364583!
        Me.txtSikakariKen.Name = "txtSikakariKen"
        Me.txtSikakariKen.OutputFormat = resources.GetString("txtSikakariKen.OutputFormat")
        Me.txtSikakariKen.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtSikakariKen.Top = 0.875!
        Me.txtSikakariKen.Width = 1!
        '
        'Line3
        '
        Me.Line3.Height = 0.0004999042!
        Me.Line3.Left = 2.625!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.5375001!
        Me.Line3.Width = 3.817708!
        Me.Line3.X1 = 2.625!
        Me.Line3.X2 = 6.442708!
        Me.Line3.Y1 = 0.538!
        Me.Line3.Y2 = 0.5375001!
        '
        'Line4
        '
        Me.Line4.Height = 0!
        Me.Line4.Left = 2.625!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.8505!
        Me.Line4.Width = 3.817708!
        Me.Line4.X1 = 2.625!
        Me.Line4.X2 = 6.442708!
        Me.Line4.Y1 = 0.8505!
        Me.Line4.Y2 = 0.8505!
        '
        'Line5
        '
        Me.Line5.Height = 0!
        Me.Line5.Left = 2.625!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.1625!
        Me.Line5.Width = 3.817708!
        Me.Line5.X1 = 2.625!
        Me.Line5.X2 = 6.442708!
        Me.Line5.Y1 = 1.1625!
        Me.Line5.Y2 = 1.1625!
        '
        'Label16
        '
        Me.Label16.Height = 0.2625001!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 4.75!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label16.Text = "件数"
        Me.Label16.Top = 0.5625!
        Me.Label16.Width = 0.5572916!
        '
        'txtBuhinKen
        '
        Me.txtBuhinKen.DataField = "BCT"
        Me.txtBuhinKen.Height = 0.2625001!
        Me.txtBuhinKen.Left = 5.364583!
        Me.txtBuhinKen.Name = "txtBuhinKen"
        Me.txtBuhinKen.OutputFormat = resources.GetString("txtBuhinKen.OutputFormat")
        Me.txtBuhinKen.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtBuhinKen.Top = 0.5625!
        Me.txtBuhinKen.Width = 1!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        Me.PageSettings.DefaultPaperSize = false
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.6!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.6!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 8.268056!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A5
        Me.PageSettings.PaperWidth = 5.827083!
        Me.PrintWidth = 7.197917!
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
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZaiRyoSuu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyoKen, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBuhinSuu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSikakariSuu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSikakariKen, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBuhinKen, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private _sDate As String = ""

#Region " プロパティ "

    Public WriteOnly Property HassinDate() As String
        Set(ByVal sValue As String)
            _sDate = sValue
        End Set
    End Property

#End Region

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblDate.Text = _sDate.Substring(0, 4) + "年　" + CInt(_sDate.Substring(4, 2)).ToString.PadLeft(2) + "月　" + CInt(_sDate.Substring(6, 2)).ToString.PadLeft(2) + "日"
    End Sub

End Class
