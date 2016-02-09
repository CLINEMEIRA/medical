Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdjsk030
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
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSysDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtKadou1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKadou2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtJikan24 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtJikan16 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtHun24 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtHun16 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMACHINE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt機械名 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSHOP As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtLOT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWORK_TIME As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtOUT_PUT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt時間KB As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtUNIT_KB As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt稼働率 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdjsk030))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSysDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtKadou1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKadou2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtJikan24 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtJikan16 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHun24 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHun16 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMACHINE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt機械名 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSHOP = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtLOT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWORK_TIME = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtOUT_PUT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt時間KB = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtUNIT_KB = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt稼働率 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKadou1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKadou2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtJikan24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtJikan16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHun24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHun16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMACHINE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt機械名, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSHOP, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtLOT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWORK_TIME, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtOUT_PUT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt時間KB, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtUNIT_KB, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt稼働率, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtMACHINE_NO, Me.txt機械名, Me.txtSHOP, Me.txtLOT, Me.txtWORK_TIME, Me.txtOUT_PUT, Me.txt時間KB, Me.txtUNIT_KB, Me.txt稼働率})
        Me.Detail.Height = 0.15625!
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
        Me.ReportFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox, Me.TextBox1, Me.Line1})
        Me.ReportFooter.Height = 0.1666667!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label10, Me.Label14, Me.Label13, Me.Label12, Me.Label24, Me.Label27, Me.lblSysDate, Me.Label, Me.lblPage, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label11, Me.txtKadou1, Me.txtKadou2, Me.txtJikan24, Me.txtJikan16, Me.Line, Me.lblFrom, Me.lblTo, Me.Label15, Me.Label16, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.txtHun24, Me.Label17, Me.TextBox7, Me.txtHun16, Me.Label18, Me.TextBox8})
        Me.PageHeader.Height = 1.458333!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'Label10
        '
        Me.Label10.Height = 0.2!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.3125!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label10.Text = " 24時間稼動    ×    稼働日： "
        Me.Label10.Top = 0.765625!
        Me.Label10.Width = 2!
        '
        'Label14
        '
        Me.Label14.Height = 0.2!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 1.1875!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label14.Text = "～"
        Me.Label14.Top = 0.5625!
        Me.Label14.Width = 0.25!
        '
        'Label13
        '
        Me.Label13.Height = 0.2!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 2.9375!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label13.Text = "→"
        Me.Label13.Top = 0.96875!
        Me.Label13.Width = 0.1875!
        '
        'Label12
        '
        Me.Label12.Height = 0.2!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 2.9375!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label12.Text = "→"
        Me.Label12.Top = 0.765625!
        Me.Label12.Width = 0.1875!
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: none;" & _
            " vertical-align: bottom"
        Me.Label24.Text = "*　*　機械別稼働時間　*　*"
        Me.Label24.Top = 0.3125!
        Me.Label24.Width = 7.4375!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 4.625!
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
        Me.lblSysDate.Left = 5.25!
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
        Me.Label.Left = 6.25!
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
        Me.lblPage.Left = 6.9375!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblPage.Text = "1"
        Me.lblPage.Top = 0!
        Me.lblPage.Width = 0.45!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label1.Text = "機械NO"
        Me.Label1.Top = 1.25!
        Me.Label1.Width = 0.5625!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.6875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label2.Text = "機械名"
        Me.Label2.Top = 1.25!
        Me.Label2.Width = 0.5625!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.5625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label3.Text = "SHOP"
        Me.Label3.Top = 1.25!
        Me.Label3.Width = 0.3125!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label4.Text = "ロット"
        Me.Label4.Top = 1.25!
        Me.Label4.Width = 0.4375!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.8125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label5.Text = "稼働時間"
        Me.Label5.Top = 1.25!
        Me.Label5.Width = 0.625!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.75!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label6.Text = "出来高"
        Me.Label6.Top = 1.25!
        Me.Label6.Width = 0.5!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.4375!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label7.Text = "時間区分"
        Me.Label7.Top = 1.25!
        Me.Label7.Width = 0.625!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 6.125!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label8.Text = "単位区分"
        Me.Label8.Top = 1.25!
        Me.Label8.Width = 0.625!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 6.8125!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label9.Text = "稼働率"
        Me.Label9.Top = 1.25!
        Me.Label9.Width = 0.5!
        '
        'Label11
        '
        Me.Label11.Height = 0.2!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.3125!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label11.Text = " 16時間稼動    ×    稼働日："
        Me.Label11.Top = 0.96875!
        Me.Label11.Width = 2!
        '
        'txtKadou1
        '
        Me.txtKadou1.Height = 0.2!
        Me.txtKadou1.Left = 2.3125!
        Me.txtKadou1.Name = "txtKadou1"
        Me.txtKadou1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtKadou1.Text = "99"
        Me.txtKadou1.Top = 0.765625!
        Me.txtKadou1.Width = 0.3125!
        '
        'txtKadou2
        '
        Me.txtKadou2.Height = 0.2!
        Me.txtKadou2.Left = 2.3125!
        Me.txtKadou2.Name = "txtKadou2"
        Me.txtKadou2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtKadou2.Text = "99"
        Me.txtKadou2.Top = 0.96875!
        Me.txtKadou2.Width = 0.3125!
        '
        'txtJikan24
        '
        Me.txtJikan24.Height = 0.2!
        Me.txtJikan24.Left = 3.25!
        Me.txtJikan24.Name = "txtJikan24"
        Me.txtJikan24.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtJikan24.Text = "9999"
        Me.txtJikan24.Top = 0.765625!
        Me.txtJikan24.Width = 0.5!
        '
        'txtJikan16
        '
        Me.txtJikan16.Height = 0.2!
        Me.txtJikan16.Left = 3.25!
        Me.txtJikan16.Name = "txtJikan16"
        Me.txtJikan16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtJikan16.Text = "9999"
        Me.txtJikan16.Top = 0.96875!
        Me.txtJikan16.Width = 0.5!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.4375!
        Me.Line.Width = 7.5!
        Me.Line.X1 = 0!
        Me.Line.X2 = 7.5!
        Me.Line.Y1 = 1.4375!
        Me.Line.Y2 = 1.4375!
        '
        'lblFrom
        '
        Me.lblFrom.Height = 0.2!
        Me.lblFrom.HyperLink = Nothing
        Me.lblFrom.Left = 0.4375!
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblFrom.Text = "YYYY/MM/DD"
        Me.lblFrom.Top = 0.5625!
        Me.lblFrom.Width = 0.75!
        '
        'lblTo
        '
        Me.lblTo.Height = 0.2!
        Me.lblTo.HyperLink = Nothing
        Me.lblTo.Left = 1.4375!
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.lblTo.Text = "YYYY/MM/DD"
        Me.lblTo.Top = 0.5625!
        Me.lblTo.Width = 0.75!
        '
        'Label15
        '
        Me.Label15.Height = 0.2!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.3125!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label15.Text = "("
        Me.Label15.Top = 0.5625!
        Me.Label15.Width = 0.125!
        '
        'Label16
        '
        Me.Label16.Height = 0.2!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.1875!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label16.Text = ")"
        Me.Label16.Top = 0.5625!
        Me.Label16.Width = 0.125!
        '
        'TextBox2
        '
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 3.75!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.TextBox2.Text = "時間"
        Me.TextBox2.Top = 0.765625!
        Me.TextBox2.Width = 0.375!
        '
        'TextBox3
        '
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 3.75!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.TextBox3.Text = "時間"
        Me.TextBox3.Top = 0.96875!
        Me.TextBox3.Width = 0.375!
        '
        'TextBox4
        '
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 2.625!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.TextBox4.Text = "日"
        Me.TextBox4.Top = 0.765625!
        Me.TextBox4.Width = 0.1875!
        '
        'TextBox5
        '
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 2.625!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.TextBox5.Text = "日"
        Me.TextBox5.Top = 0.965625!
        Me.TextBox5.Width = 0.1875!
        '
        'txtHun24
        '
        Me.txtHun24.Height = 0.2!
        Me.txtHun24.Left = 4.5625!
        Me.txtHun24.Name = "txtHun24"
        Me.txtHun24.OutputFormat = resources.GetString("txtHun24.OutputFormat")
        Me.txtHun24.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtHun24.Text = "999999"
        Me.txtHun24.Top = 0.765625!
        Me.txtHun24.Width = 0.6875!
        '
        'Label17
        '
        Me.Label17.Height = 0.2!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 4.25!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label17.Text = "→"
        Me.Label17.Top = 0.765625!
        Me.Label17.Width = 0.1875!
        '
        'TextBox7
        '
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 5.25!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.TextBox7.Text = "分"
        Me.TextBox7.Top = 0.765625!
        Me.TextBox7.Width = 0.25!
        '
        'txtHun16
        '
        Me.txtHun16.Height = 0.2!
        Me.txtHun16.Left = 4.5625!
        Me.txtHun16.Name = "txtHun16"
        Me.txtHun16.OutputFormat = resources.GetString("txtHun16.OutputFormat")
        Me.txtHun16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtHun16.Text = "999999"
        Me.txtHun16.Top = 0.96875!
        Me.txtHun16.Width = 0.6875!
        '
        'Label18
        '
        Me.Label18.Height = 0.2!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 4.25!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label18.Text = "→"
        Me.Label18.Top = 0.96875!
        Me.Label18.Width = 0.1875!
        '
        'TextBox8
        '
        Me.TextBox8.Height = 0.2!
        Me.TextBox8.Left = 5.25!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.TextBox8.Text = "分"
        Me.TextBox8.Top = 0.96875!
        Me.TextBox8.Width = 0.25!
        '
        'txtMACHINE_NO
        '
        Me.txtMACHINE_NO.DataField = "MACHINE_NO"
        Me.txtMACHINE_NO.Height = 0.15!
        Me.txtMACHINE_NO.Left = 0.125!
        Me.txtMACHINE_NO.Name = "txtMACHINE_NO"
        Me.txtMACHINE_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txtMACHINE_NO.Text = "XXXX"
        Me.txtMACHINE_NO.Top = 0!
        Me.txtMACHINE_NO.Width = 0.438!
        '
        'txt機械名
        '
        Me.txt機械名.DataField = "機械名"
        Me.txt機械名.Height = 0.15!
        Me.txt機械名.Left = 0.6875!
        Me.txt機械名.Name = "txt機械名"
        Me.txt機械名.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txt機械名.Text = "ああああああああああああ"
        Me.txt機械名.Top = 0!
        Me.txt機械名.Width = 1.75!
        '
        'txtSHOP
        '
        Me.txtSHOP.DataField = "SHOP"
        Me.txtSHOP.Height = 0.15!
        Me.txtSHOP.Left = 2.5625!
        Me.txtSHOP.Name = "txtSHOP"
        Me.txtSHOP.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtSHOP.Text = "XX"
        Me.txtSHOP.Top = 0!
        Me.txtSHOP.Width = 0.3125!
        '
        'txtLOT
        '
        Me.txtLOT.DataField = "LOT"
        Me.txtLOT.Height = 0.15!
        Me.txtLOT.Left = 3.0625!
        Me.txtLOT.Name = "txtLOT"
        Me.txtLOT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtLOT.Text = "999"
        Me.txtLOT.Top = 0!
        Me.txtLOT.Width = 0.375!
        '
        'txtWORK_TIME
        '
        Me.txtWORK_TIME.DataField = "WORK_TIME"
        Me.txtWORK_TIME.Height = 0.15!
        Me.txtWORK_TIME.Left = 3.625!
        Me.txtWORK_TIME.Name = "txtWORK_TIME"
        Me.txtWORK_TIME.OutputFormat = resources.GetString("txtWORK_TIME.OutputFormat")
        Me.txtWORK_TIME.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtWORK_TIME.Text = "999,999.99"
        Me.txtWORK_TIME.Top = 0!
        Me.txtWORK_TIME.Width = 0.8020833!
        '
        'txtOUT_PUT
        '
        Me.txtOUT_PUT.DataField = "OUT_PUT"
        Me.txtOUT_PUT.Height = 0.15!
        Me.txtOUT_PUT.Left = 4.5625!
        Me.txtOUT_PUT.Name = "txtOUT_PUT"
        Me.txtOUT_PUT.OutputFormat = resources.GetString("txtOUT_PUT.OutputFormat")
        Me.txtOUT_PUT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtOUT_PUT.Text = "9,999,999"
        Me.txtOUT_PUT.Top = 0!
        Me.txtOUT_PUT.Width = 0.6875!
        '
        'txt時間KB
        '
        Me.txt時間KB.DataField = "時間KB"
        Me.txt時間KB.Height = 0.15!
        Me.txt時間KB.Left = 5.4375!
        Me.txt時間KB.Name = "txt時間KB"
        Me.txt時間KB.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt時間KB.Text = "24時間"
        Me.txt時間KB.Top = 0!
        Me.txt時間KB.Width = 0.5625!
        '
        'txtUNIT_KB
        '
        Me.txtUNIT_KB.DataField = "UNIT_KB"
        Me.txtUNIT_KB.Height = 0.15!
        Me.txtUNIT_KB.Left = 6.25!
        Me.txtUNIT_KB.Name = "txtUNIT_KB"
        Me.txtUNIT_KB.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtUNIT_KB.Text = "時間"
        Me.txtUNIT_KB.Top = 0!
        Me.txtUNIT_KB.Width = 0.375!
        '
        'txt稼働率
        '
        Me.txt稼働率.Height = 0.15!
        Me.txt稼働率.Left = 6.8125!
        Me.txt稼働率.Name = "txt稼働率"
        Me.txt稼働率.OutputFormat = resources.GetString("txt稼働率.OutputFormat")
        Me.txt稼働率.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txt稼働率.Text = "999.9"
        Me.txt稼働率.Top = 0!
        Me.txt稼働率.Width = 0.4479165!
        '
        'TextBox
        '
        Me.TextBox.DataField = "WORK_TIME"
        Me.TextBox.Height = 0.15!
        Me.TextBox.Left = 3.625!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.OutputFormat = resources.GetString("TextBox.OutputFormat")
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.TextBox.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox.Text = "999,999.99"
        Me.TextBox.Top = 0.015625!
        Me.TextBox.Width = 0.8020833!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "OUT_PUT"
        Me.TextBox1.Height = 0.15!
        Me.TextBox1.Left = 4.5625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.TextBox1.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox1.Text = "9,999,999"
        Me.TextBox1.Top = 0.015625!
        Me.TextBox1.Width = 0.6875!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.015625!
        Me.Line1.Width = 7.5!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 7.5!
        Me.Line1.Y1 = 0.015625!
        Me.Line1.Y2 = 0.015625!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = "SELECT K.MACHINE_NO,S.FACILITIES_NM 機械名,S.SHOP,K.LOT,K.WORK_TIME," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "K.OUT_PUT,S.WO" & _
            "RK_TIME_KB 時間KB,S.WORK_RATE UNIT_KB " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM WK_MC_WORKTIME K,FACILITIES_MST S " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W" & _
            "HERE K.MACHINE_NO = S.FACILITIES_CD "
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.1!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.479167!
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
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKadou1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKadou2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtJikan24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtJikan16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHun24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHun16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMACHINE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt機械名, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSHOP, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtLOT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWORK_TIME, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtOUT_PUT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt時間KB, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtUNIT_KB, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt稼働率, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1

    Public WriteOnly Property kadou() As String
        Set(ByVal sValue As String)
            txtKadou1.Text = sValue
            txtKadou2.Text = sValue
        End Set
    End Property

    Public WriteOnly Property fromYMD() As String
        Set(ByVal sValue As String)
            lblFrom.Text = sValue.Substring(0, 4) & "/" & sValue.Substring(4, 2) & "/" & sValue.Substring(6, 2)
        End Set
    End Property

    Public WriteOnly Property toYMD() As String
        Set(ByVal sValue As String)
            lblTo.Text = sValue.Substring(0, 4) & "/" & sValue.Substring(4, 2) & "/" & sValue.Substring(6, 2)
        End Set
    End Property

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

        txtJikan24.Text = txtKadou1.Text * 24
        txtJikan16.Text = txtKadou2.Text * 16
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If txt時間KB.Text = "01" Then
            txt時間KB.Text = "16時間"
        ElseIf txt時間KB.Text = "02" Then
            txt時間KB.Text = "24時間"
        End If

        If txtUNIT_KB.Text = "01" Then
            txtUNIT_KB.Text = "時間"
            If txt時間KB.Text = "16時間" Then
                txt稼働率.Text = Format(txtWORK_TIME.Text / txtJikan16.Text * 100, "0.0")
            ElseIf txt時間KB.Text = "24時間" Then
                txt稼働率.Text = Format(txtWORK_TIME.Text / txtJikan24.Text * 100, "0.0")
            End If

        ElseIf txtUNIT_KB.Text = "02" Then
            txtUNIT_KB.Text = "個"
            txtWORK_TIME.Text = ""
            txt稼働率.Text = ""
        End If

    End Sub
End Class 
