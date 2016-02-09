Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdzai0401
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
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSysDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label35 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label36 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblNouki As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTyumonNO As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShuzaiCD As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHanane As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuSuu As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZanSuu As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTani As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuSaki As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuBi As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdzai0401))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSysDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label35 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label36 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblNouki = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTyumonNO = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShuzaiCD = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHanane = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuSuu = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZanSuu = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTani = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuSaki = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuBi = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNouki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTyumonNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShuzaiCD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHanane, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuSuu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZanSuu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTani, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuSaki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuBi, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNouki, Me.lblTyumonNO, Me.Label5, Me.lblShuzaiCD, Me.lblHanane, Me.lblHatyuSuu, Me.lblZanSuu, Me.lblTani, Me.lblHatyuSaki, Me.lblHatyuBi})
        Me.Detail.Height = 0.1979167!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label24, Me.Label27, Me.lblSysDate, Me.Label, Me.lblPage, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.Label2, Me.Label3, Me.Label4, Me.Line})
        Me.PageHeader.Height = 1.228472!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line1})
        Me.PageFooter.Height = 0.03125!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: none;" & _
            " vertical-align: bottom"
        Me.Label24.Text = "*　*　主材料注残リスト(納期順)　*　*"
        Me.Label24.Top = 0.375!
        Me.Label24.Width = 9.5!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 6.6875!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "日 付 ："
        Me.Label27.Top = 0.0625!
        Me.Label27.Width = 0.625!
        '
        'lblSysDate
        '
        Me.lblSysDate.Height = 0.2!
        Me.lblSysDate.HyperLink = Nothing
        Me.lblSysDate.Left = 7.3125!
        Me.lblSysDate.Name = "lblSysDate"
        Me.lblSysDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblSysDate.Text = "YYYY/MM/DD"
        Me.lblSysDate.Top = 0.0625!
        Me.lblSysDate.Width = 0.9375!
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 8.3125!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label.Text = "ページ ："
        Me.Label.Top = 0.0625!
        Me.Label.Width = 0.6875!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 9!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblPage.Text = "1"
        Me.lblPage.Top = 0.0625!
        Me.lblPage.Width = 0.5!
        '
        'Label30
        '
        Me.Label30.Height = 0.18!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label30.Text = "納期"
        Me.Label30.Top = 0.9375!
        Me.Label30.Width = 0.375!
        '
        'Label31
        '
        Me.Label31.Height = 0.18!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.792!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label31.Text = "注文NO"
        Me.Label31.Top = 0.9375!
        Me.Label31.Width = 0.562!
        '
        'Label32
        '
        Me.Label32.Height = 0.18!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 1.417!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label32.Text = "連NO"
        Me.Label32.Top = 0.946875!
        Me.Label32.Width = 0.375!
        '
        'Label33
        '
        Me.Label33.Height = 0.18!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 1.875!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label33.Text = "主材料コード"
        Me.Label33.Top = 0.9375!
        Me.Label33.Width = 0.875!
        '
        'Label34
        '
        Me.Label34.Height = 0.18!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 3!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label34.Text = "鋼種"
        Me.Label34.Top = 0.9375!
        Me.Label34.Width = 0.375!
        '
        'Label35
        '
        Me.Label35.Height = 0.18!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 4.6255!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label35.Text = "発注量"
        Me.Label35.Top = 0.9375!
        Me.Label35.Width = 0.5619998!
        '
        'Label36
        '
        Me.Label36.Height = 0.18!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 5.1875!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label36.Text = "単位"
        Me.Label36.Top = 0.9375!
        Me.Label36.Width = 0.3744998!
        '
        'Label37
        '
        Me.Label37.Height = 0.18!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 5.8125!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label37.Text = "分割納入"
        Me.Label37.Top = 0.75!
        Me.Label37.Width = 0.6875!
        '
        'Label2
        '
        Me.Label2.Height = 0.18!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 8.7505!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label2.Text = "発注日"
        Me.Label2.Top = 0.9375!
        Me.Label2.Width = 0.5!
        '
        'Label3
        '
        Me.Label3.Height = 0.18!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.875!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label3.Text = "残  数"
        Me.Label3.Top = 0.9375!
        Me.Label3.Width = 0.4375!
        '
        'Label4
        '
        Me.Label4.Height = 0.18!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 6.6255!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label4.Text = "発注先"
        Me.Label4.Top = 0.9375!
        Me.Label4.Width = 0.6245003!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.125!
        Me.Line.Width = 9.5!
        Me.Line.X1 = 0!
        Me.Line.X2 = 9.5!
        Me.Line.Y1 = 1.125!
        Me.Line.Y2 = 1.125!
        '
        'lblNouki
        '
        Me.lblNouki.DataField = "DELIVERY_DT"
        Me.lblNouki.Height = 0.2!
        Me.lblNouki.HyperLink = Nothing
        Me.lblNouki.Left = 0!
        Me.lblNouki.Name = "lblNouki"
        Me.lblNouki.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblNouki.Text = "YYYY/MM/DD"
        Me.lblNouki.Top = 0!
        Me.lblNouki.Width = 0.75!
        '
        'lblTyumonNO
        '
        Me.lblTyumonNO.DataField = "ORDER_NO"
        Me.lblTyumonNO.Height = 0.2!
        Me.lblTyumonNO.HyperLink = Nothing
        Me.lblTyumonNO.Left = 0.7916667!
        Me.lblTyumonNO.Name = "lblTyumonNO"
        Me.lblTyumonNO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblTyumonNO.Text = "XXXXXXX"
        Me.lblTyumonNO.Top = 0!
        Me.lblTyumonNO.Width = 0.5833334!
        '
        'Label5
        '
        Me.Label5.DataField = "REN_NO"
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 1.416667!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label5.Text = "XXXXX"
        Me.Label5.Top = 0!
        Me.Label5.Width = 0.3958334!
        '
        'lblShuzaiCD
        '
        Me.lblShuzaiCD.DataField = "MATL_CD"
        Me.lblShuzaiCD.Height = 0.2!
        Me.lblShuzaiCD.HyperLink = Nothing
        Me.lblShuzaiCD.Left = 1.875!
        Me.lblShuzaiCD.Name = "lblShuzaiCD"
        Me.lblShuzaiCD.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblShuzaiCD.Text = "XXXXXXXXXXXXXXX"
        Me.lblShuzaiCD.Top = 0!
        Me.lblShuzaiCD.Width = 1.0625!
        '
        'lblHanane
        '
        Me.lblHanane.DataField = "MATL_NM"
        Me.lblHanane.Height = 0.2!
        Me.lblHanane.HyperLink = Nothing
        Me.lblHanane.Left = 3!
        Me.lblHanane.MultiLine = false
        Me.lblHanane.Name = "lblHanane"
        Me.lblHanane.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHanane.Text = "XXXXXXXXXXXXXXXXX"
        Me.lblHanane.Top = 0!
        Me.lblHanane.Width = 1.25!
        '
        'lblHatyuSuu
        '
        Me.lblHatyuSuu.DataField = "ORDER_WAT"
        Me.lblHatyuSuu.Height = 0.2!
        Me.lblHatyuSuu.HyperLink = Nothing
        Me.lblHatyuSuu.Left = 4.3125!
        Me.lblHatyuSuu.Name = "lblHatyuSuu"
        Me.lblHatyuSuu.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.lblHatyuSuu.Text = "9,999,999.99"
        Me.lblHatyuSuu.Top = 0!
        Me.lblHatyuSuu.Width = 0.875!
        '
        'lblZanSuu
        '
        Me.lblZanSuu.DataField = "DELIVER_REST_WAT"
        Me.lblZanSuu.Height = 0.2!
        Me.lblZanSuu.HyperLink = Nothing
        Me.lblZanSuu.Left = 5.625!
        Me.lblZanSuu.Name = "lblZanSuu"
        Me.lblZanSuu.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.lblZanSuu.Text = "9,999,999.99"
        Me.lblZanSuu.Top = 0!
        Me.lblZanSuu.Width = 0.875!
        '
        'lblTani
        '
        Me.lblTani.DataField = "ITEM_NM"
        Me.lblTani.Height = 0.2!
        Me.lblTani.HyperLink = Nothing
        Me.lblTani.Left = 5.1875!
        Me.lblTani.Name = "lblTani"
        Me.lblTani.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblTani.Text = "XX"
        Me.lblTani.Top = 0!
        Me.lblTani.Width = 0.3125!
        '
        'lblHatyuSaki
        '
        Me.lblHatyuSaki.DataField = "CONTRACTOUT_NM"
        Me.lblHatyuSaki.Height = 0.2!
        Me.lblHatyuSaki.HyperLink = Nothing
        Me.lblHatyuSaki.Left = 6.5625!
        Me.lblHatyuSaki.MultiLine = false
        Me.lblHatyuSaki.Name = "lblHatyuSaki"
        Me.lblHatyuSaki.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuSaki.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblHatyuSaki.Top = 0!
        Me.lblHatyuSaki.Width = 2.125!
        '
        'lblHatyuBi
        '
        Me.lblHatyuBi.DataField = "ORDER_DT"
        Me.lblHatyuBi.Height = 0.2!
        Me.lblHatyuBi.HyperLink = Nothing
        Me.lblHatyuBi.Left = 8.75!
        Me.lblHatyuBi.Name = "lblHatyuBi"
        Me.lblHatyuBi.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuBi.Text = "YYYY/MM/DD"
        Me.lblHatyuBi.Top = 0!
        Me.lblHatyuBi.Width = 0.75!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0!
        Me.Line1.Width = 9.5!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 9.5!
        Me.Line1.Y1 = 0!
        Me.Line1.Y2 = 0!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 9.520833!
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
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNouki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTyumonNO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShuzaiCD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHanane, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuSuu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZanSuu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTani, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuSaki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuBi, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1

    Private Sub mdzai0401_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("Nouki")
        lblNouki.DataField = "Nouki"

        Fields.Add("HatyuDate")
        lblHatyuBi.DataField = "HatyuDate"

        Fields.Add("HatyuRyo")
        lblHatyuSuu.DataField = "HatyuRyo"

        Fields.Add("BunkakuZan")
        lblZanSuu.DataField = "BunkakuZan"
    End Sub

    Private Sub mdzai0401_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        '納期 
        Fields("Nouki").Value = ""
        If Not GetString(Fields("DELIVERY_DT").Value).Equals("") And Not GetString(Fields("DELIVERY_DT").Value).Equals("00000000") Then Fields("Nouki").Value = GetString(Fields("DELIVERY_DT").Value).Substring(0, 4) + "/" + GetString(Fields("DELIVERY_DT").Value).Substring(4, 2) + "/" + GetString(Fields("DELIVERY_DT").Value).Substring(6, 2)

        '発注日 
        Fields("HatyuDate").Value = ""
        If Not GetString(Fields("ORDER_DT").Value).Equals("") And Not GetString(Fields("ORDER_DT").Value).Equals("00000000") Then Fields("HatyuDate").Value = GetString(Fields("ORDER_DT").Value).Substring(0, 4) + "/" + GetString(Fields("ORDER_DT").Value).Substring(4, 2) + "/" + GetString(Fields("ORDER_DT").Value).Substring(6, 2)

        '発注量 
        Fields("HatyuRyo").Value = GetDouble(Fields("ORDER_WAT").Value)
        'If GetDouble(Fields("ORDER_WAT").Value) <> 0 Then Fields("HatyuRyo").Value = Format(GetDouble(Fields("ORDER_WAT").Value), "#,###,##0.00")
        If GetDouble(Fields("ORDER_WAT").Value) <> 0 Then Fields("HatyuRyo").Value = GetDouble(Fields("ORDER_WAT").Value).ToString("#,###,##0.00")

        '分割納入残数 
        Fields("BunkakuZan").Value = GetDouble(Fields("DELIVER_REST_WAT").Value)
        'If GetDouble(Fields("DELIVER_REST_WAT").Value) <> 0 Then Fields("BunkakuZan").Value = Format(GetDouble(Fields("DELIVER_REST_WAT").Value), "#,###,##0.00")
        If GetDouble(Fields("DELIVER_REST_WAT").Value) <> 0 Then Fields("BunkakuZan").Value = GetDouble(Fields("DELIVER_REST_WAT").Value).ToString("#,###,##0.00")
    End Sub

    Private Function GetString(ByVal oValue As Object) As String
        If IsDBNull(oValue) Then Return ""
        Return CType(oValue, String).Trim()
    End Function

    Private Function GetDouble(ByVal oValue As Object) As Double
        If IsDBNull(oValue) Then Return 0
        Return CType(oValue, Double)
    End Function

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblPage.Text = nPage
        nPage += 1
        lblSysDate.Text = System.DateTime.Now.ToString("yyyy/MM/dd")
    End Sub
End Class 
