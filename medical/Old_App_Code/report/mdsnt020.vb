Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports System


Public Class mdsnt020
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
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private txtINDICATE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSTW_AMT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPW_AMT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtDELIVERY_ADJUST_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtPROCESS_ORDER As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPROCESS名 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt調整DELIVERY_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtPROCESS_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTUNE_DELIVERY_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox

    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdsnt020))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.txtINDICATE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSTW_AMT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPW_AMT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDELIVERY_ADJUST_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtPROCESS_ORDER = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPROCESS_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTUNE_DELIVERY_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
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
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSTW_AMT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPW_AMT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDELIVERY_ADJUST_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPROCESS_ORDER, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPROCESS_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTUNE_DELIVERY_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.CanShrink = true
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtPROCESS_ORDER, Me.txtPROCESS_NM, Me.txtTUNE_DELIVERY_DT, Me.Line1})
        Me.Detail.Height = 0.1979167!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label, Me.lblDate, Me.lblPage, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9})
        Me.PageHeader.Height = 0.8854167!
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
        Me.GroupHeader1.CanShrink = true
        Me.GroupHeader1.ColumnLayout = false
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtINDICATE_NO, Me.txtCATALOG_NO, Me.txtCOMPANY_NO, Me.txtSTW_AMT, Me.txtPW_AMT, Me.txtDELIVERY_ADJUST_DT, Me.Line})
        Me.GroupHeader1.DataField = "ブレイク"
        Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.GroupHeader1.Height = 0.1979167!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPageIncludeNoDetail
        Me.GroupHeader1.UnderlayNext = true
        '
        'GroupFooter1
        '
        Me.GroupFooter1.CanShrink = true
        Me.GroupFooter1.Height = 0.1979167!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center"
        Me.Label.Text = "※※※　納期調製品一覧表　※※※"
        Me.Label.Top = 0.1875!
        Me.Label.Width = 7.5625!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.8125!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: bottom"
        Me.lblDate.Text = "YY.MM.DD"
        Me.lblDate.Top = 0.125!
        Me.lblDate.Width = 0.5333332!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 6.8125!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.lblPage.Text = "Page.#"
        Me.lblPage.Top = 0.3125!
        Me.lblPage.Width = 0.4666668!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label1.Text = "指示NO"
        Me.Label1.Top = 0.6875!
        Me.Label1.Width = 0.5!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.Label2.Text = "カタログ番号"
        Me.Label2.Top = 0.6875!
        Me.Label2.Width = 1.3125!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.9375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label3.Text = "社内NO"
        Me.Label3.Top = 0.6875!
        Me.Label3.Width = 0.5!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.4375!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label4.Text = "着工数"
        Me.Label4.Top = 0.6875!
        Me.Label4.Width = 0.6875!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label5.Text = "現仕掛数"
        Me.Label5.Top = 0.6875!
        Me.Label5.Width = 0.6875!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 3.875!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label6.Text = "納期調整日"
        Me.Label6.Top = 0.6875!
        Me.Label6.Width = 0.75!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.6875!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label7.Text = "工順"
        Me.Label7.Top = 0.6875!
        Me.Label7.Width = 0.4375!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.1875!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.Label8.Text = "工程名"
        Me.Label8.Top = 0.6875!
        Me.Label8.Width = 1.5!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 6.75!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label9.Text = "調整納期"
        Me.Label9.Top = 0.6875!
        Me.Label9.Width = 0.75!
        '
        'txtINDICATE_NO
        '
        Me.txtINDICATE_NO.DataField = "INDICATE_NO"
        Me.txtINDICATE_NO.Height = 0.2!
        Me.txtINDICATE_NO.Left = 0.0625!
        Me.txtINDICATE_NO.Name = "txtINDICATE_NO"
        Me.txtINDICATE_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO.Text = "指示NO"
        Me.txtINDICATE_NO.Top = 0!
        Me.txtINDICATE_NO.Width = 0.5!
        '
        'txtCATALOG_NO
        '
        Me.txtCATALOG_NO.DataField = "CATALOG_NO"
        Me.txtCATALOG_NO.Height = 0.2!
        Me.txtCATALOG_NO.Left = 0.625!
        Me.txtCATALOG_NO.Name = "txtCATALOG_NO"
        Me.txtCATALOG_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txtCATALOG_NO.Text = "XXXXXXXXXXXXXXXXX"
        Me.txtCATALOG_NO.Top = 0!
        Me.txtCATALOG_NO.Width = 1.3125!
        '
        'txtCOMPANY_NO
        '
        Me.txtCOMPANY_NO.DataField = "COMPANY_NO"
        Me.txtCOMPANY_NO.Height = 0.2!
        Me.txtCOMPANY_NO.Left = 1.9375!
        Me.txtCOMPANY_NO.Name = "txtCOMPANY_NO"
        Me.txtCOMPANY_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO.Text = "社内NO"
        Me.txtCOMPANY_NO.Top = 0!
        Me.txtCOMPANY_NO.Width = 0.5!
        '
        'txtSTW_AMT
        '
        Me.txtSTW_AMT.DataField = "STW_AMT"
        Me.txtSTW_AMT.Height = 0.2!
        Me.txtSTW_AMT.Left = 2.4375!
        Me.txtSTW_AMT.Name = "txtSTW_AMT"
        Me.txtSTW_AMT.OutputFormat = resources.GetString("txtSTW_AMT.OutputFormat")
        Me.txtSTW_AMT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSTW_AMT.Text = "着工数"
        Me.txtSTW_AMT.Top = 0!
        Me.txtSTW_AMT.Width = 0.6875!
        '
        'txtPW_AMT
        '
        Me.txtPW_AMT.DataField = "PW_AMT"
        Me.txtPW_AMT.Height = 0.2!
        Me.txtPW_AMT.Left = 3.125!
        Me.txtPW_AMT.Name = "txtPW_AMT"
        Me.txtPW_AMT.OutputFormat = resources.GetString("txtPW_AMT.OutputFormat")
        Me.txtPW_AMT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtPW_AMT.Text = "現仕掛数"
        Me.txtPW_AMT.Top = 0!
        Me.txtPW_AMT.Width = 0.6875!
        '
        'txtDELIVERY_ADJUST_DT
        '
        Me.txtDELIVERY_ADJUST_DT.DataField = "DELIVERY_ADJUST_DT"
        Me.txtDELIVERY_ADJUST_DT.Height = 0.2!
        Me.txtDELIVERY_ADJUST_DT.Left = 3.875!
        Me.txtDELIVERY_ADJUST_DT.Name = "txtDELIVERY_ADJUST_DT"
        Me.txtDELIVERY_ADJUST_DT.OutputFormat = resources.GetString("txtDELIVERY_ADJUST_DT.OutputFormat")
        Me.txtDELIVERY_ADJUST_DT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtDELIVERY_ADJUST_DT.Text = "納期調整日"
        Me.txtDELIVERY_ADJUST_DT.Top = 0!
        Me.txtDELIVERY_ADJUST_DT.Width = 0.75!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.0625!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0!
        Me.Line.Width = 7.5!
        Me.Line.X1 = 0.0625!
        Me.Line.X2 = 7.5625!
        Me.Line.Y1 = 0!
        Me.Line.Y2 = 0!
        '
        'txtPROCESS_ORDER
        '
        Me.txtPROCESS_ORDER.DataField = "PROCESS_ORDER"
        Me.txtPROCESS_ORDER.Height = 0.2!
        Me.txtPROCESS_ORDER.Left = 4.6875!
        Me.txtPROCESS_ORDER.Name = "txtPROCESS_ORDER"
        Me.txtPROCESS_ORDER.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtPROCESS_ORDER.Text = "工順"
        Me.txtPROCESS_ORDER.Top = 0!
        Me.txtPROCESS_ORDER.Width = 0.4375!
        '
        'txtPROCESS_NM
        '
        Me.txtPROCESS_NM.DataField = "PROCESS_NM"
        Me.txtPROCESS_NM.Height = 0.2!
        Me.txtPROCESS_NM.Left = 5.1875!
        Me.txtPROCESS_NM.Name = "txtPROCESS_NM"
        Me.txtPROCESS_NM.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txtPROCESS_NM.Text = "脱脂洗浄 EBZ-PL-3041"
        Me.txtPROCESS_NM.Top = 0!
        Me.txtPROCESS_NM.Width = 1.5!
        '
        'txtTUNE_DELIVERY_DT
        '
        Me.txtTUNE_DELIVERY_DT.DataField = "TUNE_DELIVERY_DT"
        Me.txtTUNE_DELIVERY_DT.Height = 0.2!
        Me.txtTUNE_DELIVERY_DT.Left = 6.75!
        Me.txtTUNE_DELIVERY_DT.Name = "txtTUNE_DELIVERY_DT"
        Me.txtTUNE_DELIVERY_DT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtTUNE_DELIVERY_DT.Text = "調整納期"
        Me.txtTUNE_DELIVERY_DT.Top = 0!
        Me.txtTUNE_DELIVERY_DT.Width = 0.75!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 4.625!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.1875!
        Me.Line1.Width = 2.9375!
        Me.Line1.X1 = 4.625!
        Me.Line1.X2 = 7.5625!
        Me.Line1.Y1 = 0.1875!
        Me.Line1.Y2 = 0.1875!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medproc;User ID=medproc;Data Source=sysdiv0;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.583333!
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
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
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
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSTW_AMT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPW_AMT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDELIVERY_ADJUST_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPROCESS_ORDER, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPROCESS_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTUNE_DELIVERY_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format

        '日付 
        lblDate.Text = DateTime.Now.Date.ToString("yy.MM.dd")
        'ページ 
        lblPage.Text = "Page." + nPage.ToString("#")
        nPage += 1
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If txtPROCESS_ORDER.Text.Substring(txtPROCESS_ORDER.Text.IndexOf("-") + 1, 1) = 0 Then
            txtPROCESS_ORDER.Text = txtPROCESS_ORDER.Text.Substring(0, txtPROCESS_ORDER.Text.IndexOf("-"))
        End If
    End Sub

End Class 
