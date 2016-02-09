Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdgty0602
    Inherits GrapeCity.ActiveReports.SectionReport
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents GroupHeader2 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter2 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSysDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCONTRACTOUT_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCONTRACTOUT_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtC_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtAOG_AMT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPRICE As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtAMOUNT_MONEY As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdgty0602))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.GroupHeader2 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter2 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSysDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCONTRACTOUT_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCONTRACTOUT_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtC_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAOG_AMT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPRICE = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAMOUNT_MONEY = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtC_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtAOG_AMT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPRICE, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtAMOUNT_MONEY, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtC_NO, Me.txtCATALOG_NO, Me.txtAOG_AMT, Me.txtPRICE, Me.txtAMOUNT_MONEY, Me.TextBox5})
        Me.Detail.Height = 0.1555556!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label24, Me.Label27, Me.lblSysDate, Me.Label, Me.lblPage, Me.lblFrom, Me.lblTo, Me.Label8, Me.Label9})
        Me.PageHeader.Height = 0.75!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.2076389!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label37, Me.Label2, Me.Label3, Me.Label4, Me.Line, Me.Label1, Me.Label6, Me.txtCONTRACTOUT_NM, Me.txtCONTRACTOUT_CD, Me.Label5})
        Me.GroupHeader1.DataField = "CONTRACTOUT_CD"
        Me.GroupHeader1.Height = 0.5194445!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox4, Me.TextBox3, Me.Label10, Me.Line1})
        Me.GroupFooter1.Height = 0.2076389!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
        '
        'GroupHeader2
        '
        Me.GroupHeader2.DataField = "C_NO"
        Me.GroupHeader2.Height = 0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox2, Me.TextBox1, Me.Label7, Me.TextBox, Me.Line2})
        Me.GroupFooter2.Height = 0.3111111!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: none;" & _
            " vertical-align: bottom"
        Me.Label24.Text = "*　*　外注入荷明細 (外注別)　*　*"
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
        'lblFrom
        '
        Me.lblFrom.DataField = "AOG_DTFROM"
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
        Me.lblTo.DataField = "AOG_DTTO"
        Me.lblTo.Height = 0.2!
        Me.lblTo.HyperLink = Nothing
        Me.lblTo.Left = 2.4375!
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
        Me.Label9.Text = "入荷日付："
        Me.Label9.Top = 0.5625!
        Me.Label9.Width = 0.75!
        '
        'Label37
        '
        Me.Label37.Height = 0.18!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 4.4375!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label37.Text = "単価"
        Me.Label37.Top = 0.3125!
        Me.Label37.Width = 0.9375!
        '
        'Label2
        '
        Me.Label2.Height = 0.18!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.3125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label2.Text = "カタログ番号"
        Me.Label2.Top = 0.3125!
        Me.Label2.Width = 1.25!
        '
        'Label3
        '
        Me.Label3.Height = 0.18!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label3.Text = "入荷数"
        Me.Label3.Top = 0.3125!
        Me.Label3.Width = 0.75!
        '
        'Label4
        '
        Me.Label4.Height = 0.18!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 5.4375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.Label4.Text = "金額"
        Me.Label4.Top = 0.3125!
        Me.Label4.Width = 0.937!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.9479167!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.5!
        Me.Line.Width = 5.583333!
        Me.Line.X1 = 0.9479167!
        Me.Line.X2 = 6.53125!
        Me.Line.Y1 = 0.5!
        Me.Line.Y2 = 0.5!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.4375!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left"
        Me.Label1.Text = "外注先　："
        Me.Label1.Top = 0!
        Me.Label1.Width = 0.75!
        '
        'Label6
        '
        Me.Label6.Height = 0.18!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.875!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label6.Text = "組番"
        Me.Label6.Top = 0.3125!
        Me.Label6.Width = 0.375!
        '
        'txtCONTRACTOUT_NM
        '
        Me.txtCONTRACTOUT_NM.DataField = "CONTRACTOUT_NM"
        Me.txtCONTRACTOUT_NM.Height = 0.2!
        Me.txtCONTRACTOUT_NM.Left = 1.625!
        Me.txtCONTRACTOUT_NM.Name = "txtCONTRACTOUT_NM"
        Me.txtCONTRACTOUT_NM.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txtCONTRACTOUT_NM.Text = "あああああああああああああああ"
        Me.txtCONTRACTOUT_NM.Top = 0!
        Me.txtCONTRACTOUT_NM.Width = 2.1875!
        '
        'txtCONTRACTOUT_CD
        '
        Me.txtCONTRACTOUT_CD.DataField = "CONTRACTOUT_CD"
        Me.txtCONTRACTOUT_CD.Height = 0.2!
        Me.txtCONTRACTOUT_CD.Left = 1.1875!
        Me.txtCONTRACTOUT_CD.Name = "txtCONTRACTOUT_CD"
        Me.txtCONTRACTOUT_CD.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtCONTRACTOUT_CD.Text = "XXXX"
        Me.txtCONTRACTOUT_CD.Top = 0!
        Me.txtCONTRACTOUT_CD.Width = 0.375!
        '
        'Label5
        '
        Me.Label5.Height = 0.18!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 1.125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label5.Text = "注文NO"
        Me.Label5.Top = 0.3125!
        Me.Label5.Width = 0.6875!
        '
        'txtC_NO
        '
        Me.txtC_NO.DataField = "C_NO"
        Me.txtC_NO.Height = 0.15!
        Me.txtC_NO.Left = 1.875!
        Me.txtC_NO.Name = "txtC_NO"
        Me.txtC_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtC_NO.Text = "XX"
        Me.txtC_NO.Top = 0!
        Me.txtC_NO.Width = 0.375!
        '
        'txtCATALOG_NO
        '
        Me.txtCATALOG_NO.DataField = "CATALOG_NO"
        Me.txtCATALOG_NO.Height = 0.15!
        Me.txtCATALOG_NO.Left = 2.3125!
        Me.txtCATALOG_NO.Name = "txtCATALOG_NO"
        Me.txtCATALOG_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txtCATALOG_NO.Text = "XXXXXXXXXXXXXXXXX"
        Me.txtCATALOG_NO.Top = 0!
        Me.txtCATALOG_NO.Width = 1.25!
        '
        'txtAOG_AMT
        '
        Me.txtAOG_AMT.DataField = "AOG_AMT"
        Me.txtAOG_AMT.Height = 0.15!
        Me.txtAOG_AMT.Left = 3.625!
        Me.txtAOG_AMT.Name = "txtAOG_AMT"
        Me.txtAOG_AMT.OutputFormat = resources.GetString("txtAOG_AMT.OutputFormat")
        Me.txtAOG_AMT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtAOG_AMT.SummaryGroup = "GroupHeader1"
        Me.txtAOG_AMT.Text = "-9,999,999"
        Me.txtAOG_AMT.Top = 0!
        Me.txtAOG_AMT.Width = 0.75!
        '
        'txtPRICE
        '
        Me.txtPRICE.DataField = "PRICE"
        Me.txtPRICE.Height = 0.15!
        Me.txtPRICE.Left = 4.438!
        Me.txtPRICE.Name = "txtPRICE"
        Me.txtPRICE.OutputFormat = resources.GetString("txtPRICE.OutputFormat")
        Me.txtPRICE.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtPRICE.Text = "-9,999,999.99"
        Me.txtPRICE.Top = 0!
        Me.txtPRICE.Width = 0.9375!
        '
        'txtAMOUNT_MONEY
        '
        Me.txtAMOUNT_MONEY.DataField = "AMOUNT_MONEY"
        Me.txtAMOUNT_MONEY.Height = 0.15!
        Me.txtAMOUNT_MONEY.Left = 5.438!
        Me.txtAMOUNT_MONEY.Name = "txtAMOUNT_MONEY"
        Me.txtAMOUNT_MONEY.OutputFormat = resources.GetString("txtAMOUNT_MONEY.OutputFormat")
        Me.txtAMOUNT_MONEY.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtAMOUNT_MONEY.Text = "-9,999,999,99"
        Me.txtAMOUNT_MONEY.Top = 0!
        Me.txtAMOUNT_MONEY.Width = 0.9479167!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "ORDER_NO"
        Me.TextBox5.Height = 0.15!
        Me.TextBox5.Left = 1.125!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.TextBox5.Text = "XXXXXXXX"
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 0.6875!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "AMOUNT_MONEY"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 5.438001!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.TextBox2.SummaryGroup = "GroupHeader2"
        Me.TextBox2.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 0.948!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "AOG_AMT"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 3.625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.TextBox1.SummaryGroup = "GroupHeader2"
        Me.TextBox1.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox1.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 0.75!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 2.1875!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label7.Text = "集計"
        Me.Label7.Top = 0!
        Me.Label7.Width = 0.375!
        '
        'TextBox
        '
        Me.TextBox.DataField = "C_NO"
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 1.875!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.TextBox.Text = "XX"
        Me.TextBox.Top = 0!
        Me.TextBox.Width = 0.375!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.9375!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0!
        Me.Line2.Width = 5.583001!
        Me.Line2.X1 = 0.9375!
        Me.Line2.X2 = 6.520501!
        Me.Line2.Y1 = 0!
        Me.Line2.Y2 = 0!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "AOG_AMT"
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 3.625!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.TextBox4.SummaryGroup = "GroupHeader1"
        Me.TextBox4.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox4.Top = 0!
        Me.TextBox4.Width = 0.75!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "AMOUNT_MONEY"
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 5.4375!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.TextBox3.SummaryGroup = "GroupHeader1"
        Me.TextBox3.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 0.948!
        '
        'Label10
        '
        Me.Label10.Height = 0.2!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 1.875!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label10.Text = "外注別合計"
        Me.Label10.Top = 0!
        Me.Label10.Width = 0.75!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.948!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0!
        Me.Line1.Width = 5.583001!
        Me.Line1.X1 = 0.948!
        Me.Line1.X2 = 6.531001!
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
        Me.PageSettings.Margins.Left = 0.3!
        Me.PageSettings.Margins.Right = 0.3!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.479167!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter2)
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
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtC_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtAOG_AMT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPRICE, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtAMOUNT_MONEY, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1

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

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

    End Sub
End Class 
