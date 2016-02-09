Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdzai0701
    Inherits GrapeCity.ActiveReports.SectionReport
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader = Nothing
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter = Nothing
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
    Private lblFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblNyukobi As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblRenNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShuzaiCD As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblLotNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblYouban As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTyumonNO As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuRyo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblNyukoRyo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblNyukoTanka As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblNyukoKin As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuSaki As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtSumNyukoRyo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSumNyukoKin As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdzai0701))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
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
        Me.lblFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNyukobi = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRenNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShuzaiCD = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblLotNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblYouban = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTyumonNO = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuRyo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNyukoRyo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNyukoTanka = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNyukoKin = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuSaki = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSumNyukoRyo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSumNyukoKin = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
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
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNyukobi, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRenNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShuzaiCD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblLotNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblYouban, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTyumonNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuRyo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNyukoRyo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNyukoTanka, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNyukoKin, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuSaki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSumNyukoRyo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSumNyukoKin, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNyukobi, Me.lblRenNo, Me.lblShuzaiCD, Me.lblLotNo, Me.lblYouban, Me.lblTyumonNO, Me.lblHatyuRyo, Me.lblNyukoRyo, Me.lblNyukoTanka, Me.lblNyukoKin, Me.Label1, Me.lblHatyuSaki})
        Me.Detail.Height = 0.2388889!
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
        Me.ReportFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line1, Me.txtSumNyukoRyo, Me.txtSumNyukoKin})
        Me.ReportFooter.Height = 0.2597222!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label24, Me.Label27, Me.lblSysDate, Me.Label, Me.lblPage, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.Label2, Me.Label3, Me.Label4, Me.Line, Me.lblFrom, Me.lblTo, Me.Label8, Me.Label9})
        Me.PageHeader.Height = 1.09375!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: none;" & _
            " vertical-align: bottom"
        Me.Label24.Text = "*　*　主材料入庫明細　*　*"
        Me.Label24.Top = 0.3125!
        Me.Label24.Width = 10.375!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 7.5625!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "日 付 ："
        Me.Label27.Top = 0!
        Me.Label27.Width = 0.6875!
        '
        'lblSysDate
        '
        Me.lblSysDate.Height = 0.2!
        Me.lblSysDate.HyperLink = Nothing
        Me.lblSysDate.Left = 8.25!
        Me.lblSysDate.Name = "lblSysDate"
        Me.lblSysDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblSysDate.Text = "YYYY/MM/DD"
        Me.lblSysDate.Top = 0!
        Me.lblSysDate.Width = 0.9375!
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 9.1875!
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
        Me.lblPage.Left = 9.875!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblPage.Text = "1"
        Me.lblPage.Top = 0!
        Me.lblPage.Width = 0.45!
        '
        'Label30
        '
        Me.Label30.Height = 0.18!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0.125!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label30.Text = "入庫日"
        Me.Label30.Top = 0.875!
        Me.Label30.Width = 0.5!
        '
        'Label31
        '
        Me.Label31.Height = 0.18!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 3.979499!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label31.Text = "注文NO"
        Me.Label31.Top = 0.875!
        Me.Label31.Width = 0.5205006!
        '
        'Label32
        '
        Me.Label32.Height = 0.18!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.792!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label32.Text = "連NO"
        Me.Label32.Top = 0.9!
        Me.Label32.Width = 0.375!
        '
        'Label33
        '
        Me.Label33.Height = 0.18!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 1.3125!
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
        Me.Label34.Left = 2.3125!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label34.Text = "主材料ﾛｯﾄNo"
        Me.Label34.Top = 0.875!
        Me.Label34.Width = 0.8125!
        '
        'Label35
        '
        Me.Label35.Height = 0.18!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 4.813!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label35.Text = "発注量"
        Me.Label35.Top = 0.875!
        Me.Label35.Width = 0.5619998!
        '
        'Label36
        '
        Me.Label36.Height = 0.18!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 3.25!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label36.Text = "溶番"
        Me.Label36.Top = 0.875!
        Me.Label36.Width = 0.3744998!
        '
        'Label37
        '
        Me.Label37.Height = 0.18!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 6.5!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label37.Text = "入庫単価"
        Me.Label37.Top = 0.875!
        Me.Label37.Width = 0.6875!
        '
        'Label2
        '
        Me.Label2.Height = 0.18!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 8.375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label2.Text = "発注先名"
        Me.Label2.Top = 0.875!
        Me.Label2.Width = 0.6870003!
        '
        'Label3
        '
        Me.Label3.Height = 0.18!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.75!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label3.Text = "入庫量"
        Me.Label3.Top = 0.875!
        Me.Label3.Width = 0.5!
        '
        'Label4
        '
        Me.Label4.Height = 0.18!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 7.3755!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label4.Text = "入庫金額"
        Me.Label4.Top = 0.875!
        Me.Label4.Width = 0.6245003!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.0625!
        Me.Line.Width = 10.375!
        Me.Line.X1 = 0!
        Me.Line.X2 = 10.375!
        Me.Line.Y1 = 1.0625!
        Me.Line.Y2 = 1.0625!
        '
        'lblFrom
        '
        Me.lblFrom.DataField = "YMDFROM"
        Me.lblFrom.Height = 0.2!
        Me.lblFrom.HyperLink = Nothing
        Me.lblFrom.Left = 1.1875!
        Me.lblFrom.MultiLine = false
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblFrom.Text = "YY/MM/DD"
        Me.lblFrom.Top = 0.5625!
        Me.lblFrom.Width = 0.75!
        '
        'lblTo
        '
        Me.lblTo.DataField = "YMDTO"
        Me.lblTo.Height = 0.2!
        Me.lblTo.HyperLink = Nothing
        Me.lblTo.Left = 2.375!
        Me.lblTo.MultiLine = false
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblTo.Text = "YY/MM/DD"
        Me.lblTo.Top = 0.5625!
        Me.lblTo.Width = 0.75!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.0625!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label8.Text = "～"
        Me.Label8.Top = 0.5625!
        Me.Label8.Width = 0.1875!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.4375!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label9.Text = "入庫日付："
        Me.Label9.Top = 0.5625!
        Me.Label9.Width = 0.75!
        '
        'lblNyukobi
        '
        Me.lblNyukobi.DataField = "WH_DT"
        Me.lblNyukobi.Height = 0.2!
        Me.lblNyukobi.HyperLink = Nothing
        Me.lblNyukobi.Left = 0!
        Me.lblNyukobi.MultiLine = false
        Me.lblNyukobi.Name = "lblNyukobi"
        Me.lblNyukobi.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblNyukobi.Text = "YYYY/MM/DD"
        Me.lblNyukobi.Top = 0!
        Me.lblNyukobi.Width = 0.75!
        '
        'lblRenNo
        '
        Me.lblRenNo.DataField = "REN_NO"
        Me.lblRenNo.Height = 0.2!
        Me.lblRenNo.HyperLink = Nothing
        Me.lblRenNo.Left = 0.8!
        Me.lblRenNo.MultiLine = false
        Me.lblRenNo.Name = "lblRenNo"
        Me.lblRenNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblRenNo.Text = "XXXXX"
        Me.lblRenNo.Top = 0!
        Me.lblRenNo.Width = 0.45!
        '
        'lblShuzaiCD
        '
        Me.lblShuzaiCD.DataField = "MATL_CD"
        Me.lblShuzaiCD.Height = 0.2!
        Me.lblShuzaiCD.HyperLink = Nothing
        Me.lblShuzaiCD.Left = 1.28!
        Me.lblShuzaiCD.MultiLine = false
        Me.lblShuzaiCD.Name = "lblShuzaiCD"
        Me.lblShuzaiCD.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblShuzaiCD.Text = "XXXXXXXXXXXXXXX"
        Me.lblShuzaiCD.Top = 0!
        Me.lblShuzaiCD.Width = 1.095!
        '
        'lblLotNo
        '
        Me.lblLotNo.DataField = "LOT_NO"
        Me.lblLotNo.Height = 0.2!
        Me.lblLotNo.HyperLink = Nothing
        Me.lblLotNo.Left = 2.4375!
        Me.lblLotNo.MultiLine = false
        Me.lblLotNo.Name = "lblLotNo"
        Me.lblLotNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblLotNo.Text = "XXXXXX"
        Me.lblLotNo.Top = 0!
        Me.lblLotNo.Width = 0.5!
        '
        'lblYouban
        '
        Me.lblYouban.DataField = "YOUBAN"
        Me.lblYouban.Height = 0.2!
        Me.lblYouban.HyperLink = Nothing
        Me.lblYouban.Left = 3!
        Me.lblYouban.MultiLine = false
        Me.lblYouban.Name = "lblYouban"
        Me.lblYouban.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblYouban.Text = "XXXXXXXXXXXX"
        Me.lblYouban.Top = 0!
        Me.lblYouban.Width = 0.875!
        '
        'lblTyumonNO
        '
        Me.lblTyumonNO.DataField = "M_ORDER_NO"
        Me.lblTyumonNO.Height = 0.2!
        Me.lblTyumonNO.HyperLink = Nothing
        Me.lblTyumonNO.Left = 3.9375!
        Me.lblTyumonNO.MultiLine = false
        Me.lblTyumonNO.Name = "lblTyumonNO"
        Me.lblTyumonNO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblTyumonNO.Text = "XXXXXXX"
        Me.lblTyumonNO.Top = 0!
        Me.lblTyumonNO.Width = 0.5625!
        '
        'lblHatyuRyo
        '
        Me.lblHatyuRyo.DataField = "ORDER_WAT"
        Me.lblHatyuRyo.Height = 0.2!
        Me.lblHatyuRyo.HyperLink = Nothing
        Me.lblHatyuRyo.Left = 4.5!
        Me.lblHatyuRyo.MultiLine = false
        Me.lblHatyuRyo.Name = "lblHatyuRyo"
        Me.lblHatyuRyo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.lblHatyuRyo.Text = "-9,999,999.99"
        Me.lblHatyuRyo.Top = 0!
        Me.lblHatyuRyo.Width = 0.9375!
        '
        'lblNyukoRyo
        '
        Me.lblNyukoRyo.DataField = "WH_WAT"
        Me.lblNyukoRyo.Height = 0.2!
        Me.lblNyukoRyo.HyperLink = Nothing
        Me.lblNyukoRyo.Left = 5.447917!
        Me.lblNyukoRyo.MultiLine = false
        Me.lblNyukoRyo.Name = "lblNyukoRyo"
        Me.lblNyukoRyo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.lblNyukoRyo.Text = "-9,999,999.99"
        Me.lblNyukoRyo.Top = 0!
        Me.lblNyukoRyo.Width = 0.9375!
        '
        'lblNyukoTanka
        '
        Me.lblNyukoTanka.DataField = "WH_PR"
        Me.lblNyukoTanka.Height = 0.2!
        Me.lblNyukoTanka.HyperLink = Nothing
        Me.lblNyukoTanka.Left = 6.375!
        Me.lblNyukoTanka.MultiLine = false
        Me.lblNyukoTanka.Name = "lblNyukoTanka"
        Me.lblNyukoTanka.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.lblNyukoTanka.Text = "9,999,999.99"
        Me.lblNyukoTanka.Top = 0!
        Me.lblNyukoTanka.Width = 0.875!
        '
        'lblNyukoKin
        '
        Me.lblNyukoKin.DataField = "WH_MY"
        Me.lblNyukoKin.Height = 0.2!
        Me.lblNyukoKin.HyperLink = Nothing
        Me.lblNyukoKin.Left = 7.25!
        Me.lblNyukoKin.MultiLine = false
        Me.lblNyukoKin.Name = "lblNyukoKin"
        Me.lblNyukoKin.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.lblNyukoKin.Text = "-9,999,999"
        Me.lblNyukoKin.Top = 0!
        Me.lblNyukoKin.Width = 0.8125!
        '
        'Label1
        '
        Me.Label1.DataField = "WH_CD"
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 8.125!
        Me.Label1.MultiLine = false
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label1.Text = "XXXX"
        Me.Label1.Top = 0!
        Me.Label1.Width = 0.3125!
        '
        'lblHatyuSaki
        '
        Me.lblHatyuSaki.DataField = "CONTRACTOUT_NM"
        Me.lblHatyuSaki.Height = 0.2!
        Me.lblHatyuSaki.HyperLink = Nothing
        Me.lblHatyuSaki.Left = 8.4375!
        Me.lblHatyuSaki.MultiLine = false
        Me.lblHatyuSaki.Name = "lblHatyuSaki"
        Me.lblHatyuSaki.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.lblHatyuSaki.Text = "あああああああああああああああ"
        Me.lblHatyuSaki.Top = 0!
        Me.lblHatyuSaki.Width = 1.9375!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0!
        Me.Line1.Width = 10.375!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 10.375!
        Me.Line1.Y1 = 0!
        Me.Line1.Y2 = 0!
        '
        'txtSumNyukoRyo
        '
        Me.txtSumNyukoRyo.DataField = "WH_WAT"
        Me.txtSumNyukoRyo.DistinctField = "入庫量"
        Me.txtSumNyukoRyo.Height = 0.2!
        Me.txtSumNyukoRyo.Left = 5.438!
        Me.txtSumNyukoRyo.Name = "txtSumNyukoRyo"
        Me.txtSumNyukoRyo.OutputFormat = resources.GetString("txtSumNyukoRyo.OutputFormat")
        Me.txtSumNyukoRyo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSumNyukoRyo.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.txtSumNyukoRyo.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.txtSumNyukoRyo.Text = "TextBox"
        Me.txtSumNyukoRyo.Top = 0.063!
        Me.txtSumNyukoRyo.Width = 0.9375!
        '
        'txtSumNyukoKin
        '
        Me.txtSumNyukoKin.DataField = "WH_MY"
        Me.txtSumNyukoKin.DistinctField = "入庫金額"
        Me.txtSumNyukoKin.Height = 0.2!
        Me.txtSumNyukoKin.Left = 7.1875!
        Me.txtSumNyukoKin.Name = "txtSumNyukoKin"
        Me.txtSumNyukoKin.OutputFormat = resources.GetString("txtSumNyukoKin.OutputFormat")
        Me.txtSumNyukoKin.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSumNyukoKin.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.txtSumNyukoKin.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.txtSumNyukoKin.Text = "TextBox"
        Me.txtSumNyukoKin.Top = 0.063!
        Me.txtSumNyukoKin.Width = 0.8125!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Left = 0.2!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.38542!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
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
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNyukobi, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRenNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShuzaiCD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblLotNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblYouban, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTyumonNO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuRyo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNyukoRyo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNyukoTanka, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNyukoKin, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuSaki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSumNyukoRyo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSumNyukoKin, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1

    Private Sub mdzai0701_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("Nyukobi")
        lblNyukobi.DataField = "Nyukobi"

        Fields.Add("HatyuRyo")
        lblHatyuRyo.DataField = "HatyuRyo"

        Fields.Add("NyukoRyo")
        lblNyukoRyo.DataField = "NyukoRyo"

        Fields.Add("NyukoTanka")
        lblNyukoTanka.DataField = "NyukoTanka"

        Fields.Add("NyukoKin")
        lblNyukoKin.DataField = "NyukoKin"
    End Sub

    Private Sub mdzai0701_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        '入庫日 
        Fields("Nyukobi").Value = ""
        If Not GetString(Fields("WH_DT").Value).Equals("") And Not GetString(Fields("WH_DT").Value).Equals("00000000") Then Fields("Nyukobi").Value = GetString(Fields("WH_DT").Value).Substring(0, 4) + "/" + GetString(Fields("WH_DT").Value).Substring(4, 2) + "/" + GetString(Fields("WH_DT").Value).Substring(6, 2)

        '発注量 
        Fields("HatyuRyo").Value = GetDouble(Fields("ORDER_WAT").Value)
        'If GetDouble(Fields("ORDER_WAT").Value) <> 0 Then Fields("HatyuRyo").Value = Format(GetDouble(Fields("ORDER_WAT").Value), "#,###,##0.00")
        If GetDouble(Fields("ORDER_WAT").Value) <> 0 Then Fields("HatyuRyo").Value = GetDouble(Fields("ORDER_WAT").Value).ToString("#,###,##0.00")

        '入庫量 
        Fields("NyukoRyo").Value = GetDouble(Fields("WH_WAT").Value)
        'If GetDouble(Fields("WH_WAT").Value) <> 0 Then Fields("NyukoRyo").Value = Format(GetDouble(Fields("WH_WAT").Value), "#,###,##0.00")
        If GetDouble(Fields("WH_WAT").Value) <> 0 Then Fields("NyukoRyo").Value = GetDouble(Fields("WH_WAT").Value).ToString("#,###,##0.00")

        '入庫単価 
        Fields("NyukoTanka").Value = GetDouble(Fields("WH_PR").Value)
        'If GetDouble(Fields("WH_PR").Value) <> 0 Then Fields("NyukoTanka").Value = Format(GetDouble(Fields("WH_PR").Value), "#,###,##0.00")
        If GetDouble(Fields("WH_PR").Value) <> 0 Then Fields("NyukoTanka").Value = GetDouble(Fields("WH_PR").Value).ToString("#,###,##0.00")

        '入庫金額 
        Fields("NyukoKin").Value = GetDouble(Fields("WH_MY").Value)
        'If GetDouble(Fields("WH_MY").Value) <> 0 Then Fields("NyukoKin").Value = Format(GetDouble(Fields("WH_MY").Value), "#,###,##0")
        If GetDouble(Fields("WH_MY").Value) <> 0 Then Fields("NyukoKin").Value = GetDouble(Fields("WH_MY").Value).ToString("#,###,##0")

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
        lblSysDate.Text = Format(System.DateTime.Now, "yyyy/MM/dd")

        If lblFrom.Text = "" And lblTo.Text = "" Then
            Label8.Visible = False
            Label9.Visible = False
        End If
    End Sub
End Class 
