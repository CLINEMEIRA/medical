Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System

Public Class mdgty0301
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
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCONTRACTOUT_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCONTRACTOUT_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtORDER_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtC_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt出荷数 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPROCESS_ORDER As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNEXT_P_ORDER As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt緊急品 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtDELIVERY_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtORDER_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCONTRACTOUT_DELIVERY As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtR_PROCESS As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtR_PROCESS名 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdgty0301))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCONTRACTOUT_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCONTRACTOUT_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtORDER_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtC_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt出荷数 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPROCESS_ORDER = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNEXT_P_ORDER = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt緊急品 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDELIVERY_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtORDER_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCONTRACTOUT_DELIVERY = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtR_PROCESS = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtR_PROCESS名 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtC_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt出荷数, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPROCESS_ORDER, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNEXT_P_ORDER, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt緊急品, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDELIVERY_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_DELIVERY, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtR_PROCESS, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtR_PROCESS名, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.CanShrink = true
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtORDER_NO, Me.txtINDICATE_NO, Me.txtCOMPANY_NO, Me.txtC_NO, Me.txtCATALOG_NO, Me.txt出荷数, Me.txtPROCESS_ORDER, Me.txtNEXT_P_ORDER, Me.txt緊急品, Me.txtDELIVERY_DT, Me.txtORDER_DT, Me.txtCONTRACTOUT_DELIVERY, Me.txtR_PROCESS, Me.txtR_PROCESS名})
        Me.Detail.Height = 0.1506944!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.CanShrink = true
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label24, Me.Label27, Me.lblDate, Me.lblPage})
        Me.PageHeader.Height = 0.5729167!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCONTRACTOUT_NM, Me.Label13, Me.txtCONTRACTOUT_CD, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.Line})
        Me.GroupHeader1.DataField = "CONTRACTOUT_CD"
        Me.GroupHeader1.Height = 0.6131945!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: none;" & _
            " vertical-align: bottom"
        Me.Label24.Text = "*　*　外注発注残リスト(外注別)　*　*"
        Me.Label24.Top = 0.25!
        Me.Label24.Width = 10.75!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 8.3125!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "日 付 ："
        Me.Label27.Top = 0!
        Me.Label27.Width = 0.625!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 8.875!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblDate.Text = "YY/MM/DD"
        Me.lblDate.Top = 0!
        Me.lblDate.Width = 0.9375!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 9.875!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblPage.Text = "ページ ："
        Me.lblPage.Top = 0!
        Me.lblPage.Width = 0.875!
        '
        'txtCONTRACTOUT_NM
        '
        Me.txtCONTRACTOUT_NM.DataField = "CONTRACTOUT_NM"
        Me.txtCONTRACTOUT_NM.Height = 0.2!
        Me.txtCONTRACTOUT_NM.Left = 1.875!
        Me.txtCONTRACTOUT_NM.Name = "txtCONTRACTOUT_NM"
        Me.txtCONTRACTOUT_NM.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtCONTRACTOUT_NM.Text = "外注名称"
        Me.txtCONTRACTOUT_NM.Top = 0.0625!
        Me.txtCONTRACTOUT_NM.Width = 2.4375!
        '
        'Label13
        '
        Me.Label13.Height = 0.2!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.75!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label13.Text = "外注先 ："
        Me.Label13.Top = 0.0625!
        Me.Label13.Width = 0.6875!
        '
        'txtCONTRACTOUT_CD
        '
        Me.txtCONTRACTOUT_CD.DataField = "CONTRACTOUT_CD"
        Me.txtCONTRACTOUT_CD.Height = 0.2!
        Me.txtCONTRACTOUT_CD.Left = 1.4375!
        Me.txtCONTRACTOUT_CD.Name = "txtCONTRACTOUT_CD"
        Me.txtCONTRACTOUT_CD.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtCONTRACTOUT_CD.Text = "XXXX"
        Me.txtCONTRACTOUT_CD.Top = 0.0625!
        Me.txtCONTRACTOUT_CD.Width = 0.4375!
        '
        'Label12
        '
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 9.1875!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label12.Text = "外注納期"
        Me.Label12.Top = 0.3125!
        Me.Label12.Width = 0.875!
        '
        'Label11
        '
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 8.25!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label11.Text = "発注日"
        Me.Label11.Top = 0.3125!
        Me.Label11.Width = 0.875!
        '
        'Label10
        '
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 7.3125!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label10.Text = "製造納期"
        Me.Label10.Top = 0.3125!
        Me.Label10.Width = 0.875!
        '
        'Label9
        '
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 5.3125!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label9.Text = "緊急品"
        Me.Label9.Top = 0.3125!
        Me.Label9.Width = 0.4375!
        '
        'Label8
        '
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 6.5625!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label8.Text = "次工順"
        Me.Label8.Top = 0.3125!
        Me.Label8.Width = 0.6875!
        '
        'Label7
        '
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.8125!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label7.Text = "工順"
        Me.Label7.Top = 0.3125!
        Me.Label7.Width = 0.6875!
        '
        'Label6
        '
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.5625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label6.Text = "発注数"
        Me.Label6.Top = 0.3125!
        Me.Label6.Width = 0.6875!
        '
        'Label5
        '
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.1875!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label5.Text = "カタログ番号"
        Me.Label5.Top = 0.3125!
        Me.Label5.Width = 1.3125!
        '
        'Label4
        '
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.75!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label4.Text = "組番"
        Me.Label4.Top = 0.3125!
        Me.Label4.Width = 0.375!
        '
        'Label3
        '
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.5!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label3.Text = "社内NO"
        Me.Label3.Top = 0.3125!
        Me.Label3.Width = 0.5625!
        '
        'Label2
        '
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label2.Text = "指示NO"
        Me.Label2.Top = 0.3125!
        Me.Label2.Width = 0.5625!
        '
        'Label1
        '
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label1.Text = "注文NO"
        Me.Label1.Top = 0.3125!
        Me.Label1.Width = 0.8125!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.625!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.5625!
        Me.Line.Width = 9.5!
        Me.Line.X1 = 0.625!
        Me.Line.X2 = 10.125!
        Me.Line.Y1 = 0.5625!
        Me.Line.Y2 = 0.5625!
        '
        'txtORDER_NO
        '
        Me.txtORDER_NO.DataField = "ORDER_NO"
        Me.txtORDER_NO.Height = 0.15!
        Me.txtORDER_NO.Left = 0.625!
        Me.txtORDER_NO.Name = "txtORDER_NO"
        Me.txtORDER_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtORDER_NO.Text = "XX-XXXXX"
        Me.txtORDER_NO.Top = 0!
        Me.txtORDER_NO.Width = 0.813!
        '
        'txtINDICATE_NO
        '
        Me.txtINDICATE_NO.DataField = "INDICATE_NO"
        Me.txtINDICATE_NO.Height = 0.15!
        Me.txtINDICATE_NO.Left = 2.125!
        Me.txtINDICATE_NO.Name = "txtINDICATE_NO"
        Me.txtINDICATE_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO.Text = "XXXXXX"
        Me.txtINDICATE_NO.Top = 0!
        Me.txtINDICATE_NO.Width = 0.5625!
        '
        'txtCOMPANY_NO
        '
        Me.txtCOMPANY_NO.DataField = "COMPANY_NO"
        Me.txtCOMPANY_NO.Height = 0.15!
        Me.txtCOMPANY_NO.Left = 1.5!
        Me.txtCOMPANY_NO.Name = "txtCOMPANY_NO"
        Me.txtCOMPANY_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO.Text = "XXXXX"
        Me.txtCOMPANY_NO.Top = 0!
        Me.txtCOMPANY_NO.Width = 0.5625!
        '
        'txtC_NO
        '
        Me.txtC_NO.DataField = "C_NO"
        Me.txtC_NO.Height = 0.15!
        Me.txtC_NO.Left = 2.75!
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
        Me.txtCATALOG_NO.Left = 3.1875!
        Me.txtCATALOG_NO.Name = "txtCATALOG_NO"
        Me.txtCATALOG_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtCATALOG_NO.Text = "WWWWWWWWWWWWWWWWW"
        Me.txtCATALOG_NO.Top = 0!
        Me.txtCATALOG_NO.Width = 1.3125!
        '
        'txt出荷数
        '
        Me.txt出荷数.DataField = "ORDER_AMT"
        Me.txt出荷数.Height = 0.15!
        Me.txt出荷数.Left = 4.5625!
        Me.txt出荷数.Name = "txt出荷数"
        Me.txt出荷数.OutputFormat = resources.GetString("txt出荷数.OutputFormat")
        Me.txt出荷数.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txt出荷数.Text = "9,999,999"
        Me.txt出荷数.Top = 0!
        Me.txt出荷数.Width = 0.6875!
        '
        'txtPROCESS_ORDER
        '
        Me.txtPROCESS_ORDER.DataField = "PROCESS_ORDER"
        Me.txtPROCESS_ORDER.Height = 0.15!
        Me.txtPROCESS_ORDER.Left = 5.8125!
        Me.txtPROCESS_ORDER.Name = "txtPROCESS_ORDER"
        Me.txtPROCESS_ORDER.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtPROCESS_ORDER.Text = "XXX - XXX"
        Me.txtPROCESS_ORDER.Top = 0!
        Me.txtPROCESS_ORDER.Width = 0.6875!
        '
        'txtNEXT_P_ORDER
        '
        Me.txtNEXT_P_ORDER.DataField = "NEXT_P_ORDER"
        Me.txtNEXT_P_ORDER.Height = 0.15!
        Me.txtNEXT_P_ORDER.Left = 6.5625!
        Me.txtNEXT_P_ORDER.Name = "txtNEXT_P_ORDER"
        Me.txtNEXT_P_ORDER.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtNEXT_P_ORDER.Text = "XXX - XXX"
        Me.txtNEXT_P_ORDER.Top = 0!
        Me.txtNEXT_P_ORDER.Width = 0.6875!
        '
        'txt緊急品
        '
        Me.txt緊急品.DataField = "緊急品"
        Me.txt緊急品.Height = 0.15!
        Me.txt緊急品.Left = 5.3125!
        Me.txt緊急品.Name = "txt緊急品"
        Me.txt緊急品.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt緊急品.Text = "X"
        Me.txt緊急品.Top = 0!
        Me.txt緊急品.Width = 0.4375!
        '
        'txtDELIVERY_DT
        '
        Me.txtDELIVERY_DT.DataField = "DELIVERY_DT"
        Me.txtDELIVERY_DT.Height = 0.15!
        Me.txtDELIVERY_DT.Left = 7.3125!
        Me.txtDELIVERY_DT.Name = "txtDELIVERY_DT"
        Me.txtDELIVERY_DT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtDELIVERY_DT.Text = "9999/99/99"
        Me.txtDELIVERY_DT.Top = 0!
        Me.txtDELIVERY_DT.Width = 0.875!
        '
        'txtORDER_DT
        '
        Me.txtORDER_DT.DataField = "ORDER_DT"
        Me.txtORDER_DT.Height = 0.15!
        Me.txtORDER_DT.Left = 8.25!
        Me.txtORDER_DT.Name = "txtORDER_DT"
        Me.txtORDER_DT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtORDER_DT.Text = "9999/99/99"
        Me.txtORDER_DT.Top = 0!
        Me.txtORDER_DT.Width = 0.875!
        '
        'txtCONTRACTOUT_DELIVERY
        '
        Me.txtCONTRACTOUT_DELIVERY.DataField = "CONTRACTOUT_DELIVERY"
        Me.txtCONTRACTOUT_DELIVERY.Height = 0.15!
        Me.txtCONTRACTOUT_DELIVERY.Left = 9.1875!
        Me.txtCONTRACTOUT_DELIVERY.Name = "txtCONTRACTOUT_DELIVERY"
        Me.txtCONTRACTOUT_DELIVERY.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCONTRACTOUT_DELIVERY.Text = "9999/99/99"
        Me.txtCONTRACTOUT_DELIVERY.Top = 0!
        Me.txtCONTRACTOUT_DELIVERY.Width = 0.875!
        '
        'txtR_PROCESS
        '
        Me.txtR_PROCESS.DataField = "R_PROCESS"
        Me.txtR_PROCESS.Height = 0.15!
        Me.txtR_PROCESS.Left = 5.875!
        Me.txtR_PROCESS.Name = "txtR_PROCESS"
        Me.txtR_PROCESS.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtR_PROCESS.Top = 0!
        Me.txtR_PROCESS.Width = 0.25!
        '
        'txtR_PROCESS名
        '
        Me.txtR_PROCESS名.DataField = "R_PROCESS名"
        Me.txtR_PROCESS名.Height = 0.15!
        Me.txtR_PROCESS名.Left = 6.1875!
        Me.txtR_PROCESS名.Name = "txtR_PROCESS名"
        Me.txtR_PROCESS名.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtR_PROCESS名.Text = "依頼工程名"
        Me.txtR_PROCESS名.Top = 0!
        Me.txtR_PROCESS名.Width = 2!
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
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.76042!
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
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtC_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt出荷数, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPROCESS_ORDER, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNEXT_P_ORDER, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt緊急品, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDELIVERY_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_DELIVERY, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtR_PROCESS, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtR_PROCESS名, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Dim strBuff As String
    Private nPage As Integer = 1

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        '日付 
        lblDate.Text = DateTime.Now.Date.ToString("yy.MM.dd")
        'ページ 
        lblPage.Text = "Page." + nPage.ToString("#")
        nPage += 1
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '製造納期 
        If Not txtDELIVERY_DT.Text = "" Then txtDELIVERY_DT.Text = txtDELIVERY_DT.Text.Substring(0, 4) + "/" + txtDELIVERY_DT.Text.Substring(4, 2) + "/" + txtDELIVERY_DT.Text.Substring(6, 2)

        '発注日 
        If Not txtORDER_DT.Text = "" Then txtORDER_DT.Text = txtORDER_DT.Text.Substring(0, 4) + "/" + txtORDER_DT.Text.Substring(4, 2) + "/" + txtORDER_DT.Text.Substring(6, 2)

        '外注納期 
        If Not txtCONTRACTOUT_DELIVERY.Text = "" Then txtCONTRACTOUT_DELIVERY.Text = txtCONTRACTOUT_DELIVERY.Text.Substring(0, 4) + "/" + txtCONTRACTOUT_DELIVERY.Text.Substring(4, 2) + "/" + txtCONTRACTOUT_DELIVERY.Text.Substring(6, 2)

        '工順 or 依頼工程？ 
        If txtR_PROCESS.Text = "" Then
            txtR_PROCESS.Visible = False
            txtPROCESS_ORDER.Visible = True
            txtNEXT_P_ORDER.Visible = True
            txtDELIVERY_DT.Visible = True
        Else
            txtR_PROCESS.Visible = True
            txtPROCESS_ORDER.Visible = False
            txtNEXT_P_ORDER.Visible = False
            txtDELIVERY_DT.Visible = False
        End If
    End Sub
End Class 
