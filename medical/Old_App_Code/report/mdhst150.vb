Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdhst150
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
    Private txtZNW As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZNK As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZSW As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtGNK As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtKSS As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdhst150))
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
        Me.txtZNW = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZNK = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZSW = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGNK = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtKSS = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        CType(Me.txtZNW, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZNK, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZSW, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGNK, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKSS, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.txtZNW, Me.txtZNK, Me.txtZSW, Me.txtGNK, Me.Label16, Me.Label17, Me.Label18, Me.Line8, Me.Label19, Me.txtKSS, Me.Label20, Me.Label21, Me.Line3, Me.Label22, Me.Label23, Me.Line4, Me.Line5, Me.Line7, Me.Line6})
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
        Me.Label7.Text = "月次伝送処理件数"
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
        Me.Label8.Left = 0.7604167!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label8.Text = "主材料入庫"
        Me.Label8.Top = 0.25!
        Me.Label8.Width = 1.0625!
        '
        'Label9
        '
        Me.Label9.Height = 0.2625001!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.7602083!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label9.Text = "主材料出庫"
        Me.Label9.Top = 0.5625!
        Me.Label9.Width = 1.0625!
        '
        'Label10
        '
        Me.Label10.Height = 0.2625001!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.7602083!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label10.Text = "外注入荷"
        Me.Label10.Top = 0.8755!
        Me.Label10.Width = 1.0625!
        '
        'Label11
        '
        Me.Label11.Height = 0.2625001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.130208!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label11.Text = "重量"
        Me.Label11.Top = 0.25!
        Me.Label11.Width = 0.7447917!
        '
        'Label12
        '
        Me.Label12.Height = 0.2625001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 2.130208!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label12.Text = "重量"
        Me.Label12.Top = 0.5625!
        Me.Label12.Width = 0.7447917!
        '
        'Label13
        '
        Me.Label13.Height = 0.2625001!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 2.130208!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label13.Text = "金額"
        Me.Label13.Top = 0.8755!
        Me.Label13.Width = 0.7447917!
        '
        'Label14
        '
        Me.Label14.Height = 0.2625001!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 4.380208!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: justify;" & _
            " vertical-align: middle"
        Me.Label14.Text = "金額"
        Me.Label14.Top = 0.25!
        Me.Label14.Width = 0.7447917!
        '
        'txtZNW
        '
        Me.txtZNW.DataField = "ZNW"
        Me.txtZNW.Height = 0.2625001!
        Me.txtZNW.Left = 3.005208!
        Me.txtZNW.Name = "txtZNW"
        Me.txtZNW.OutputFormat = resources.GetString("txtZNW.OutputFormat")
        Me.txtZNW.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtZNW.Top = 0.25!
        Me.txtZNW.Width = 1.125!
        '
        'txtZNK
        '
        Me.txtZNK.DataField = "ZNK"
        Me.txtZNK.Height = 0.2625001!
        Me.txtZNK.Left = 5.255208!
        Me.txtZNK.Name = "txtZNK"
        Me.txtZNK.OutputFormat = resources.GetString("txtZNK.OutputFormat")
        Me.txtZNK.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtZNK.Top = 0.25!
        Me.txtZNK.Width = 1.125!
        '
        'txtZSW
        '
        Me.txtZSW.DataField = "ZSW"
        Me.txtZSW.Height = 0.2625001!
        Me.txtZSW.Left = 3.005208!
        Me.txtZSW.Name = "txtZSW"
        Me.txtZSW.OutputFormat = resources.GetString("txtZSW.OutputFormat")
        Me.txtZSW.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtZSW.Top = 0.5625!
        Me.txtZSW.Width = 1.125!
        '
        'txtGNK
        '
        Me.txtGNK.DataField = "GNK"
        Me.txtGNK.Height = 0.2625001!
        Me.txtGNK.Left = 3.005208!
        Me.txtGNK.Name = "txtGNK"
        Me.txtGNK.OutputFormat = resources.GetString("txtGNK.OutputFormat")
        Me.txtGNK.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtGNK.Top = 0.8755!
        Me.txtGNK.Width = 1.125!
        '
        'Label16
        '
        Me.Label16.Height = 0.2625001!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.7552083!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label16.Text = "買入検収"
        Me.Label16.Top = 1.1875!
        Me.Label16.Width = 1.0625!
        '
        'Label17
        '
        Me.Label17.Height = 0.2625001!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.130208!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label17.Text = "検収数量"
        Me.Label17.Top = 1.1875!
        Me.Label17.Width = 0.75!
        '
        'Label18
        '
        Me.Label18.Height = 0.2625001!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 2.130208!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label18.Text = "金額"
        Me.Label18.Top = 1.5005!
        Me.Label18.Width = 0.7447917!
        '
        'Line8
        '
        Me.Line8.Height = 0!
        Me.Line8.Left = 2.067708!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 2.1005!
        Me.Line8.Width = 2.182292!
        Me.Line8.X1 = 2.067708!
        Me.Line8.X2 = 4.25!
        Me.Line8.Y1 = 2.1005!
        Me.Line8.Y2 = 2.1005!
        '
        'Label19
        '
        Me.Label19.Height = 0.2625001!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 2.130208!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label19.Text = "出庫数量"
        Me.Label19.Top = 1.8125!
        Me.Label19.Width = 0.7447917!
        '
        'txtKSS
        '
        Me.txtKSS.DataField = "KSS"
        Me.txtKSS.Height = 0.2625001!
        Me.txtKSS.Left = 3.005208!
        Me.txtKSS.Name = "txtKSS"
        Me.txtKSS.OutputFormat = resources.GetString("txtKSS.OutputFormat")
        Me.txtKSS.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom"
        Me.txtKSS.Top = 1.8125!
        Me.txtKSS.Width = 1.125!
        '
        'Label20
        '
        Me.Label20.Height = 0.2625001!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 4.380208!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 12.75pt; font-weight: bold; text-align: left; ve" & _
            "rtical-align: middle"
        Me.Label20.Text = "入荷数量"
        Me.Label20.Top = 1.1875!
        Me.Label20.Width = 0.75!
        '
        'Label21
        '
        Me.Label21.Height = 0.2625001!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 3.005208!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom; ddo-char-set: 1"
        Me.Label21.Text = "0"
        Me.Label21.Top = 1.1875!
        Me.Label21.Width = 1.125!
        '
        'Line3
        '
        Me.Line3.Height = 0!
        Me.Line3.Left = 2.067708!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.5375001!
        Me.Line3.Width = 4.375!
        Me.Line3.X1 = 2.067708!
        Me.Line3.X2 = 6.442708!
        Me.Line3.Y1 = 0.5375001!
        Me.Line3.Y2 = 0.5375001!
        '
        'Label22
        '
        Me.Label22.Height = 0.2625001!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 3.005208!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom; ddo-char-set: 1"
        Me.Label22.Text = "0"
        Me.Label22.Top = 1.5005!
        Me.Label22.Width = 1.125!
        '
        'Label23
        '
        Me.Label23.Height = 0.2625001!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 5.255208!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: normal; text-align: right;" & _
            " vertical-align: bottom; ddo-char-set: 1"
        Me.Label23.Text = "0"
        Me.Label23.Top = 1.1875!
        Me.Label23.Width = 1.125!
        '
        'Line4
        '
        Me.Line4.Height = 0!
        Me.Line4.Left = 2.072917!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.8505!
        Me.Line4.Width = 2.182292!
        Me.Line4.X1 = 2.072917!
        Me.Line4.X2 = 4.255208!
        Me.Line4.Y1 = 0.8505!
        Me.Line4.Y2 = 0.8505!
        '
        'Line5
        '
        Me.Line5.Height = 0!
        Me.Line5.Left = 2.072917!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.1625!
        Me.Line5.Width = 2.182292!
        Me.Line5.X1 = 2.072917!
        Me.Line5.X2 = 4.255208!
        Me.Line5.Y1 = 1.1625!
        Me.Line5.Y2 = 1.1625!
        '
        'Line7
        '
        Me.Line7.Height = 0!
        Me.Line7.Left = 2.0625!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 1.4755!
        Me.Line7.Width = 4.375!
        Me.Line7.X1 = 2.0625!
        Me.Line7.X2 = 6.4375!
        Me.Line7.Y1 = 1.4755!
        Me.Line7.Y2 = 1.4755!
        '
        'Line6
        '
        Me.Line6.Height = 0!
        Me.Line6.Left = 2.0625!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.7875!
        Me.Line6.Width = 2.182292!
        Me.Line6.X1 = 2.0625!
        Me.Line6.X2 = 4.244792!
        Me.Line6.Y1 = 1.7875!
        Me.Line6.Y2 = 1.7875!
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
        CType(Me.txtZNW, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZNK, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZSW, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGNK, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKSS, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
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
