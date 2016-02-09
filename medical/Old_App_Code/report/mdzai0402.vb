Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdzai0402
    Inherits GrapeCity.ActiveReports.SectionReport
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
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
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private linDetail1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblNouki As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTyumonNO As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblRenNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShuzaiCD As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblNounyuzan As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTani As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShukkoRyo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuSaki As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSeizouNouki As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShanaiNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSijiNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblCatalog As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSiharaiYotei As GrapeCity.ActiveReports.SectionReportModel.Label
    Private linDetail2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdzai0402))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
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
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.linDetail1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblNouki = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTyumonNO = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRenNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShuzaiCD = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNounyuzan = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTani = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShukkoRyo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuSaki = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSeizouNouki = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShanaiNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSijiNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCatalog = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSiharaiYotei = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.linDetail2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNouki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTyumonNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRenNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShuzaiCD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNounyuzan, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTani, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShukkoRyo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuSaki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSeizouNouki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShanaiNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSijiNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSiharaiYotei, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNouki, Me.lblTyumonNO, Me.lblRenNo, Me.lblShuzaiCD, Me.lblNounyuzan, Me.lblTani, Me.lblShukkoRyo, Me.lblHatyuSaki, Me.lblSeizouNouki, Me.lblShanaiNo, Me.lblSijiNo, Me.lblCatalog, Me.lblSiharaiYotei})
        Me.Detail.Height = 0.2291667!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label24, Me.Label27, Me.lblSysDate, Me.Label, Me.lblPage, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.Label2, Me.Label3, Me.Label4, Me.Label1, Me.Label5, Me.linDetail1})
        Me.PageHeader.Height = 1.083333!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'GroupHeader1
        '
        Me.GroupHeader1.DataField = "MATL_CD"
        Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.GroupHeader1.Height = 0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.linDetail2})
        Me.GroupFooter1.Height = 0.009722223!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: none;" & _
            " vertical-align: bottom"
        Me.Label24.Text = "*　*　主材料注残リスト(主材料順)　*　*"
        Me.Label24.Top = 0.3125!
        Me.Label24.Width = 11.0625!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 8.5625!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "日 付 ："
        Me.Label27.Top = 0!
        Me.Label27.Width = 0.625!
        '
        'lblSysDate
        '
        Me.lblSysDate.Height = 0.2!
        Me.lblSysDate.HyperLink = Nothing
        Me.lblSysDate.Left = 9.1875!
        Me.lblSysDate.Name = "lblSysDate"
        Me.lblSysDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblSysDate.Text = "YY/MM/DD"
        Me.lblSysDate.Top = 0!
        Me.lblSysDate.Width = 0.9375!
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 10.0625!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label.Text = "ページ ："
        Me.Label.Top = 0!
        Me.Label.Width = 0.6875!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 10.75!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblPage.Text = "1"
        Me.lblPage.Top = 0!
        Me.lblPage.Width = 0.3!
        '
        'Label30
        '
        Me.Label30.Height = 0.18!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 1.5!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label30.Text = "納期"
        Me.Label30.Top = 0.875!
        Me.Label30.Width = 0.438!
        '
        'Label31
        '
        Me.Label31.Height = 0.18!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 3.5625!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label31.Text = "注文NO"
        Me.Label31.Top = 0.875!
        Me.Label31.Width = 0.5625!
        '
        'Label32
        '
        Me.Label32.Height = 0.18!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 1.125!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label32.Text = "連NO"
        Me.Label32.Top = 0.875!
        Me.Label32.Width = 0.375!
        '
        'Label33
        '
        Me.Label33.Height = 0.18!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label33.Text = "主材料コード"
        Me.Label33.Top = 0.875!
        Me.Label33.Width = 0.9375!
        '
        'Label34
        '
        Me.Label34.Height = 0.18!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 2.625!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label34.Text = "納入残"
        Me.Label34.Top = 0.875!
        Me.Label34.Width = 0.5!
        '
        'Label35
        '
        Me.Label35.Height = 0.18!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 6.3125!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label35.Text = "社内No"
        Me.Label35.Top = 0.875!
        Me.Label35.Width = 0.4375!
        '
        'Label36
        '
        Me.Label36.Height = 0.18!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 6.8125!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label36.Text = "指示No"
        Me.Label36.Top = 0.875!
        Me.Label36.Width = 0.4375!
        '
        'Label37
        '
        Me.Label37.Height = 0.18!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 7.3125!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label37.Text = "カタログ番号"
        Me.Label37.Top = 0.875!
        Me.Label37.Width = 0.875!
        '
        'Label2
        '
        Me.Label2.Height = 0.18!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 10.25!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label2.Text = "払出予定日"
        Me.Label2.Top = 0.875!
        Me.Label2.Width = 0.75!
        '
        'Label3
        '
        Me.Label3.Height = 0.18!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 8.625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label3.Text = "出庫要求量"
        Me.Label3.Top = 0.875!
        Me.Label3.Width = 0.75!
        '
        'Label4
        '
        Me.Label4.Height = 0.18!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.1875!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label4.Text = "発注先"
        Me.Label4.Top = 0.875!
        Me.Label4.Width = 0.6245003!
        '
        'Label1
        '
        Me.Label1.Height = 0.18!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 9.4375!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label1.Text = "製造納期"
        Me.Label1.Top = 0.875!
        Me.Label1.Width = 0.75!
        '
        'Label5
        '
        Me.Label5.Height = 0.18!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label5.Text = "単位"
        Me.Label5.Top = 0.875!
        Me.Label5.Width = 0.375!
        '
        'linDetail1
        '
        Me.linDetail1.Height = 0!
        Me.linDetail1.Left = 0!
        Me.linDetail1.LineWeight = 1!
        Me.linDetail1.Name = "linDetail1"
        Me.linDetail1.Top = 1.0625!
        Me.linDetail1.Width = 11!
        Me.linDetail1.X1 = 0!
        Me.linDetail1.X2 = 11!
        Me.linDetail1.Y1 = 1.0625!
        Me.linDetail1.Y2 = 1.0625!
        '
        'lblNouki
        '
        Me.lblNouki.DataField = "DELIVERY_DT"
        Me.lblNouki.Height = 0.2!
        Me.lblNouki.HyperLink = Nothing
        Me.lblNouki.Left = 1.5!
        Me.lblNouki.Name = "lblNouki"
        Me.lblNouki.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblNouki.Text = "YY/MM/DD"
        Me.lblNouki.Top = 0.03!
        Me.lblNouki.Width = 0.75!
        '
        'lblTyumonNO
        '
        Me.lblTyumonNO.DataField = "ORDER_NO"
        Me.lblTyumonNO.Height = 0.2!
        Me.lblTyumonNO.HyperLink = Nothing
        Me.lblTyumonNO.Left = 3.5625!
        Me.lblTyumonNO.Name = "lblTyumonNO"
        Me.lblTyumonNO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblTyumonNO.Text = "XXXXXXX"
        Me.lblTyumonNO.Top = 0.03!
        Me.lblTyumonNO.Width = 0.5625!
        '
        'lblRenNo
        '
        Me.lblRenNo.DataField = "REN_NO"
        Me.lblRenNo.Height = 0.2!
        Me.lblRenNo.HyperLink = Nothing
        Me.lblRenNo.Left = 1.125!
        Me.lblRenNo.Name = "lblRenNo"
        Me.lblRenNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblRenNo.Text = "XXXXX"
        Me.lblRenNo.Top = 0.03!
        Me.lblRenNo.Width = 0.375!
        '
        'lblShuzaiCD
        '
        Me.lblShuzaiCD.DataField = "MATL_CD"
        Me.lblShuzaiCD.Height = 0.2!
        Me.lblShuzaiCD.HyperLink = Nothing
        Me.lblShuzaiCD.Left = 0!
        Me.lblShuzaiCD.Name = "lblShuzaiCD"
        Me.lblShuzaiCD.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblShuzaiCD.Text = "XXXXXXXXXXXXXXX"
        Me.lblShuzaiCD.Top = 0.03!
        Me.lblShuzaiCD.Width = 1.1!
        '
        'lblNounyuzan
        '
        Me.lblNounyuzan.DataField = "DELIVER_REST"
        Me.lblNounyuzan.Height = 0.2!
        Me.lblNounyuzan.HyperLink = Nothing
        Me.lblNounyuzan.Left = 2.25!
        Me.lblNounyuzan.Name = "lblNounyuzan"
        Me.lblNounyuzan.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.lblNounyuzan.Text = "9,999,999.99"
        Me.lblNounyuzan.Top = 0.03!
        Me.lblNounyuzan.Width = 0.875!
        '
        'lblTani
        '
        Me.lblTani.DataField = "UNIT"
        Me.lblTani.Height = 0.2!
        Me.lblTani.HyperLink = Nothing
        Me.lblTani.Left = 3.125!
        Me.lblTani.Name = "lblTani"
        Me.lblTani.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblTani.Text = "XX"
        Me.lblTani.Top = 0.03!
        Me.lblTani.Width = 0.375!
        '
        'lblShukkoRyo
        '
        Me.lblShukkoRyo.DataField = "SHIP_DM_WAT"
        Me.lblShukkoRyo.Height = 0.2!
        Me.lblShukkoRyo.HyperLink = Nothing
        Me.lblShukkoRyo.Left = 8.5!
        Me.lblShukkoRyo.Name = "lblShukkoRyo"
        Me.lblShukkoRyo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.lblShukkoRyo.Text = "9,999,999.99"
        Me.lblShukkoRyo.Top = 0.03!
        Me.lblShukkoRyo.Width = 0.875!
        '
        'lblHatyuSaki
        '
        Me.lblHatyuSaki.DataField = "ORDER_OTHER"
        Me.lblHatyuSaki.Height = 0.2!
        Me.lblHatyuSaki.HyperLink = Nothing
        Me.lblHatyuSaki.Left = 4.1875!
        Me.lblHatyuSaki.MultiLine = false
        Me.lblHatyuSaki.Name = "lblHatyuSaki"
        Me.lblHatyuSaki.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblHatyuSaki.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblHatyuSaki.Top = 0.03!
        Me.lblHatyuSaki.Width = 2.125!
        '
        'lblSeizouNouki
        '
        Me.lblSeizouNouki.DataField = "MAKE_DELIVERY"
        Me.lblSeizouNouki.Height = 0.2!
        Me.lblSeizouNouki.HyperLink = Nothing
        Me.lblSeizouNouki.Left = 9.4375!
        Me.lblSeizouNouki.Name = "lblSeizouNouki"
        Me.lblSeizouNouki.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblSeizouNouki.Text = "YY/MM/DD"
        Me.lblSeizouNouki.Top = 0.03!
        Me.lblSeizouNouki.Width = 0.75!
        '
        'lblShanaiNo
        '
        Me.lblShanaiNo.DataField = "COMPANY_NO"
        Me.lblShanaiNo.Height = 0.2!
        Me.lblShanaiNo.HyperLink = Nothing
        Me.lblShanaiNo.Left = 6.313001!
        Me.lblShanaiNo.Name = "lblShanaiNo"
        Me.lblShanaiNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblShanaiNo.Text = "XXXXXX"
        Me.lblShanaiNo.Top = 0.03!
        Me.lblShanaiNo.Width = 0.4369998!
        '
        'lblSijiNo
        '
        Me.lblSijiNo.DataField = "INDICATE_NO"
        Me.lblSijiNo.Height = 0.2!
        Me.lblSijiNo.HyperLink = Nothing
        Me.lblSijiNo.Left = 6.813001!
        Me.lblSijiNo.Name = "lblSijiNo"
        Me.lblSijiNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblSijiNo.Text = "XXXXX"
        Me.lblSijiNo.Top = 0.03!
        Me.lblSijiNo.Width = 0.4369994!
        '
        'lblCatalog
        '
        Me.lblCatalog.DataField = "PARTS_NO"
        Me.lblCatalog.Height = 0.2!
        Me.lblCatalog.HyperLink = Nothing
        Me.lblCatalog.Left = 7.3125!
        Me.lblCatalog.MultiLine = false
        Me.lblCatalog.Name = "lblCatalog"
        Me.lblCatalog.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblCatalog.Text = "XXXXXXXXXXXXXXXXX"
        Me.lblCatalog.Top = 0.03!
        Me.lblCatalog.Width = 1.1875!
        '
        'lblSiharaiYotei
        '
        Me.lblSiharaiYotei.DataField = "F_PROCESS_DELIVERY"
        Me.lblSiharaiYotei.Height = 0.2!
        Me.lblSiharaiYotei.HyperLink = Nothing
        Me.lblSiharaiYotei.Left = 10.25!
        Me.lblSiharaiYotei.Name = "lblSiharaiYotei"
        Me.lblSiharaiYotei.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblSiharaiYotei.Text = "YY/MM/DD"
        Me.lblSiharaiYotei.Top = 0.03!
        Me.lblSiharaiYotei.Width = 0.75!
        '
        'linDetail2
        '
        Me.linDetail2.Height = 0!
        Me.linDetail2.Left = 0!
        Me.linDetail2.LineWeight = 1!
        Me.linDetail2.Name = "linDetail2"
        Me.linDetail2.Top = 0!
        Me.linDetail2.Width = 11!
        Me.linDetail2.X1 = 0!
        Me.linDetail2.X2 = 11!
        Me.linDetail2.Y1 = 0!
        Me.linDetail2.Y2 = 0!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = "SELECT *  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM WK_MATL_AOG_WAIT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY DSP_TURN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.4!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.0625!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
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
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNouki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTyumonNO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRenNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShuzaiCD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNounyuzan, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTani, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShukkoRyo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuSaki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSeizouNouki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShanaiNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSijiNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSiharaiYotei, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1
    Private strKey As String = ""

    Private Sub mdzai0401_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("ShuCD")
        lblShuzaiCD.DataField = "ShuCD"

        Fields.Add("Nouki")
        lblNouki.DataField = "Nouki"

        Fields.Add("SeizouNouki")
        lblSeizouNouki.DataField = "SeizouNouki"

        Fields.Add("HaraidasiYotei")
        lblSiharaiYotei.DataField = "HaraidasiYotei"

        Fields.Add("Nounyuzan")
        lblNounyuzan.DataField = "Nounyuzan"

        Fields.Add("ShukkoRyo")
        lblShukkoRyo.DataField = "ShukkoRyo"

    End Sub

    Private Sub mdzai0401_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData

        '納期 
        Fields("Nouki").Value = ""
        If Not GetString(Fields("DELIVERY_DT").Value).Equals("") And Not GetString(Fields("DELIVERY_DT").Value).Equals("00000000") Then Fields("Nouki").Value = GetString(Fields("DELIVERY_DT").Value).Substring(0, 4) + "/" + GetString(Fields("DELIVERY_DT").Value).Substring(4, 2) + "/" + GetString(Fields("DELIVERY_DT").Value).Substring(6, 2)

        '製造納期 
        Fields("SeizouNouki").Value = ""
        If Not GetString(Fields("MAKE_DELIVERY").Value).Equals("") And Not GetString(Fields("MAKE_DELIVERY").Value).Equals("00000000") Then Fields("SeizouNouki").Value = GetString(Fields("MAKE_DELIVERY").Value).Substring(0, 4) + "/" + GetString(Fields("MAKE_DELIVERY").Value).Substring(4, 2) + "/" + GetString(Fields("MAKE_DELIVERY").Value).Substring(6, 2)

        '払出予定日 
        Fields("HaraidasiYotei").Value = ""
        If Not GetString(Fields("F_PROCESS_DELIVERY").Value).Equals("") And Not GetString(Fields("F_PROCESS_DELIVERY").Value).Equals("00000000") Then Fields("HaraidasiYotei").Value = GetString(Fields("F_PROCESS_DELIVERY").Value).Substring(0, 4) + "/" + GetString(Fields("F_PROCESS_DELIVERY").Value).Substring(4, 2) + "/" + GetString(Fields("F_PROCESS_DELIVERY").Value).Substring(6, 2)

        If Not GetString(Fields("COMPANY_NO").Value).Equals("") Then
            '出庫要求量 
            Fields("ShukkoRyo").Value = GetDouble(Fields("SHIP_DM_WAT").Value)
            'If GetDouble(Fields("SHIP_DM_WAT").Value) <> 0 Then Fields("ShukkoRyo").Value = Format(GetDouble(Fields("SHIP_DM_WAT").Value), "#,###,##0.00")
            If GetDouble(Fields("SHIP_DM_WAT").Value) <> 0 Then Fields("ShukkoRyo").Value = GetDouble(Fields("SHIP_DM_WAT").Value).ToString("#,###,##0.00")

            '主材料コード 
            Fields("ShuCD").Value = ""
            '納入残 
            Fields("Nounyuzan").Value = ""
        Else
            '主材料コード 
            Fields("ShuCD").Value = ""
            If Not GetString(Fields("MATL_CD").Value).Equals("") Then Fields("ShuCD").Value = GetString(Fields("MATL_CD").Value)
            '納入残 
            Fields("Nounyuzan").Value = GetDouble(Fields("DELIVER_REST").Value)
            'If GetDouble(Fields("DELIVER_REST").Value) <> 0 Then Fields("Nounyuzan").Value = Format(GetDouble(Fields("DELIVER_REST").Value), "#,###,##0.00")
            If GetDouble(Fields("DELIVER_REST").Value) <> 0 Then Fields("Nounyuzan").Value = GetDouble(Fields("DELIVER_REST").Value).ToString("#,###,##0.00")

            '出庫要求量 
            Fields("ShukkoRyo").Value = ""
        End If
        strKey = Fields("MATL_CD").Value
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
        'lblSysDate.Text = Format(System.DateTime.Now, "yyyy/MM/dd")
        lblSysDate.Text = System.DateTime.Now.ToString("yyyy/MM/dd")
    End Sub
End Class 
