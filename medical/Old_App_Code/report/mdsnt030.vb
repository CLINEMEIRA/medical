Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports System
Imports Microsoft.VisualBasic

Public Class mdsnt030
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
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblClass As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtGroup As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblGroup As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtGroupName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCatalog As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSijiNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSikakari As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNouki As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKanou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtGenKoujun As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtGenKoutei As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtGenKouteiNM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdsnt030))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblClass = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGroup = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblGroup = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGroupName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCatalog = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSijiNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSikakari = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNouki = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKanou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGenKoujun = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGenKoutei = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGenKouteiNM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblClass, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGroup, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblGroup, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGroupName, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSijiNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSikakari, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNouki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKanou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGenKoujun, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGenKoutei, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGenKouteiNM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCatalog, Me.txtSijiNo, Me.txtSikakari, Me.txtNouki, Me.txtKanou, Me.txtGenKoujun, Me.txtGenKoutei, Me.txtGenKouteiNM})
        Me.Detail.Height = 0.2076389!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label, Me.Label11, Me.lblDate, Me.Label12, Me.lblPage})
        Me.PageHeader.Height = 0.5506945!
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
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Line, Me.lblClass, Me.txtGroup, Me.lblGroup, Me.txtGroupName, Me.Label2, Me.Label7})
        Me.GroupHeader1.DataField = "グループ"
        Me.GroupHeader1.Height = 0.625!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnColumn
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
        '
        'Label
        '
        Me.Label.Height = 0.2666667!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.06666666!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-size: 12pt; text-align: center; vertical-align: bottom"
        Me.Label.Text = "※※※　作業指示書　※※※"
        Me.Label.Top = 0.06666666!
        Me.Label.Width = 7.333333!
        '
        'Label11
        '
        Me.Label11.Height = 0.2000001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 6.2!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-size: 9pt; text-align: right; vertical-align: bottom; white-space: nowrap"
        Me.Label11.Text = "発行日："
        Me.Label11.Top = 0.1333333!
        Me.Label11.Width = 0.5333332!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2000001!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.733333!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-size: 9pt; text-align: left; vertical-align: bottom; white-space: nowrap"
        Me.lblDate.Text = "YYYY/MM/DD"
        Me.lblDate.Top = 0.1333333!
        Me.lblDate.Width = 0.6666666!
        '
        'Label12
        '
        Me.Label12.Height = 0.2000001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 6.733333!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-size: 9pt; text-align: left; vertical-align: bottom; white-space: nowrap"
        Me.Label12.Text = "PAGE."
        Me.Label12.Top = 0.3333333!
        Me.Label12.Width = 0.333333!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2000001!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 7.066667!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-size: 9pt; text-align: left; vertical-align: bottom; white-space: nowrap"
        Me.lblPage.Text = "999"
        Me.lblPage.Top = 0.3333333!
        Me.lblPage.Width = 0.2666664!
        '
        'Label1
        '
        Me.Label1.Height = 0.2000001!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.938!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 9pt; text-align: left; vertical-align: bottom; white-space: nowrap"
        Me.Label1.Text = "カタログ番号"
        Me.Label1.Top = 0.4!
        Me.Label1.Width = 1.133333!
        '
        'Label3
        '
        Me.Label3.Height = 0.2000001!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.2125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 9pt; text-align: left; vertical-align: bottom; white-space: nowrap"
        Me.Label3.Text = "指示NO"
        Me.Label3.Top = 0.4!
        Me.Label3.Width = 0.4666668!
        '
        'Label4
        '
        Me.Label4.Height = 0.2000001!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.808333!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 9pt; text-align: right; vertical-align: bottom; white-space: nowrap"
        Me.Label4.Text = "現仕掛数"
        Me.Label4.Top = 0.4!
        Me.Label4.Width = 0.6666666!
        '
        'Label5
        '
        Me.Label5.Height = 0.2000001!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.604167!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; white-space: nowrap"
        Me.Label5.Text = "最終納期"
        Me.Label5.Top = 0.4!
        Me.Label5.Width = 0.6666666!
        '
        'Label6
        '
        Me.Label6.Height = 0.2000001!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.6500001!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 9pt; text-align: left; vertical-align: bottom; white-space: nowrap"
        Me.Label6.Text = "*"
        Me.Label6.Top = 0.4!
        Me.Label6.Width = 0.2000001!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.1333333!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.5999999!
        Me.Line.Width = 7!
        Me.Line.X1 = 0.1333333!
        Me.Line.X2 = 7.133333!
        Me.Line.Y1 = 0.5999999!
        Me.Line.Y2 = 0.5999999!
        '
        'lblClass
        '
        Me.lblClass.Height = 0.2000001!
        Me.lblClass.HyperLink = Nothing
        Me.lblClass.Left = 0.2!
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Style = "font-size: 9pt; text-align: left; vertical-align: bottom; white-space: nowrap"
        Me.lblClass.Text = "ＮＮＮＮＮ"
        Me.lblClass.Top = 0!
        Me.lblClass.Width = 0.7333333!
        '
        'txtGroup
        '
        Me.txtGroup.DataField = "グループ"
        Me.txtGroup.Height = 0.2!
        Me.txtGroup.Left = 1!
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtGroup.Text = "XXXXXX"
        Me.txtGroup.Top = 0!
        Me.txtGroup.Width = 0.3999999!
        '
        'lblGroup
        '
        Me.lblGroup.Height = 0.2000001!
        Me.lblGroup.HyperLink = Nothing
        Me.lblGroup.Left = 1.4!
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; white-space: nowrap"
        Me.lblGroup.Text = "："
        Me.lblGroup.Top = 0!
        Me.lblGroup.Width = 0.1333333!
        '
        'txtGroupName
        '
        Me.txtGroupName.DataField = "名称"
        Me.txtGroupName.Height = 0.2!
        Me.txtGroupName.Left = 1.533333!
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtGroupName.Text = "XXXXXX"
        Me.txtGroupName.Top = 0!
        Me.txtGroupName.Width = 2.466667!
        '
        'Label2
        '
        Me.Label2.Height = 0.2000001!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; white-space: nowrap"
        Me.Label2.Text = "現工順"
        Me.Label2.Top = 0.4!
        Me.Label2.Width = 0.5!
        '
        'Label7
        '
        Me.Label7.Height = 0.2000001!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.0005!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; white-space: nowrap"
        Me.Label7.Text = "現工程"
        Me.Label7.Top = 0.4!
        Me.Label7.Width = 0.4369998!
        '
        'txtCatalog
        '
        Me.txtCatalog.DataField = "CATALOG_NO"
        Me.txtCatalog.Height = 0.2!
        Me.txtCatalog.Left = 0.938!
        Me.txtCatalog.Name = "txtCatalog"
        Me.txtCatalog.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtCatalog.Text = "カタログ番号"
        Me.txtCatalog.Top = 0!
        Me.txtCatalog.Width = 1.133333!
        '
        'txtSijiNo
        '
        Me.txtSijiNo.DataField = "INDICATE_NO"
        Me.txtSijiNo.Height = 0.2!
        Me.txtSijiNo.Left = 2.2125!
        Me.txtSijiNo.Name = "txtSijiNo"
        Me.txtSijiNo.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtSijiNo.Text = "指示NO"
        Me.txtSijiNo.Top = 0!
        Me.txtSijiNo.Width = 0.4666668!
        '
        'txtSikakari
        '
        Me.txtSikakari.DataField = "PW_AMT"
        Me.txtSikakari.Height = 0.2!
        Me.txtSikakari.Left = 2.808333!
        Me.txtSikakari.Name = "txtSikakari"
        Me.txtSikakari.OutputFormat = resources.GetString("txtSikakari.OutputFormat")
        Me.txtSikakari.Style = "font-size: 9pt; text-align: right; vertical-align: bottom; white-space: nowrap"
        Me.txtSikakari.Text = "現仕掛数"
        Me.txtSikakari.Top = -7.450583E-09!
        Me.txtSikakari.Width = 0.6666666!
        '
        'txtNouki
        '
        Me.txtNouki.DataField = "DELIVERY_DT"
        Me.txtNouki.Height = 0.2!
        Me.txtNouki.Left = 3.604167!
        Me.txtNouki.Name = "txtNouki"
        Me.txtNouki.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; white-space: nowrap"
        Me.txtNouki.Text = "納期"
        Me.txtNouki.Top = 0!
        Me.txtNouki.Width = 0.6666666!
        '
        'txtKanou
        '
        Me.txtKanou.DataField = "作業可能"
        Me.txtKanou.Height = 0.2!
        Me.txtKanou.Left = 0.6499999!
        Me.txtKanou.Name = "txtKanou"
        Me.txtKanou.Style = "font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.txtKanou.Text = "作業可能"
        Me.txtKanou.Top = 0!
        Me.txtKanou.Width = 0.26!
        '
        'txtGenKoujun
        '
        Me.txtGenKoujun.DataField = "現工順"
        Me.txtGenKoujun.Height = 0.2!
        Me.txtGenKoujun.Left = 4.375!
        Me.txtGenKoujun.Name = "txtGenKoujun"
        Me.txtGenKoujun.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; white-space: nowrap"
        Me.txtGenKoujun.Text = "999-9"
        Me.txtGenKoujun.Top = 0!
        Me.txtGenKoujun.Width = 0.5!
        '
        'txtGenKoutei
        '
        Me.txtGenKoutei.DataField = "P_PROCESS_CD"
        Me.txtGenKoutei.Height = 0.2!
        Me.txtGenKoutei.Left = 5!
        Me.txtGenKoutei.Name = "txtGenKoutei"
        Me.txtGenKoutei.Style = "font-size: 9pt; text-align: center; vertical-align: bottom; white-space: nowrap"
        Me.txtGenKoutei.Text = "9999"
        Me.txtGenKoutei.Top = 0!
        Me.txtGenKoutei.Width = 0.375!
        '
        'txtGenKouteiNM
        '
        Me.txtGenKouteiNM.DataField = "P_ORDER_NM"
        Me.txtGenKouteiNM.Height = 0.2!
        Me.txtGenKouteiNM.Left = 5.4375!
        Me.txtGenKouteiNM.Name = "txtGenKouteiNM"
        Me.txtGenKouteiNM.Style = "font-size: 9pt; text-align: left; vertical-align: bottom; white-space: nowrap"
        Me.txtGenKouteiNM.Text = "１２３４５６７８９０"
        Me.txtGenKouteiNM.Top = 0!
        Me.txtGenKouteiNM.Width = 1.3125!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=MEDICAL;User ID=MEDICAL;Data Source=MEDICAL;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = false
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11.69306!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.268056!
        Me.PrintWidth = 7.46875!
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
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblClass, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGroup, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblGroup, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGroupName, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSijiNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSikakari, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNouki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKanou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGenKoujun, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGenKoutei, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGenKouteiNM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1
    Private nColumn As Integer = 0

    Private sClass As String = ""

    Public WriteOnly Property SetClass() As String
        Set(ByVal sValue As String)
            sClass = sValue
        End Set
    End Property

    Private Sub mdsnt030_PageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageStart
        nColumn = 0
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        '日付 
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        'ページ 
        lblPage.Text = nPage.ToString("#").Trim.PadLeft(3, " ")
        nPage += 1
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        lblClass.Text = sClass
        txtGroup.Visible = nColumn = 0
        lblGroup.Visible = nColumn = 0
        txtGroupName.Visible = nColumn = 0
        nColumn += 1
    End Sub

    Private Sub mdlst010_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("Nouki")
        Fields.Add("Kanou")
        txtNouki.DataField = "Nouki"
        txtKanou.DataField = "Kanou"
    End Sub

    Private Sub mdlst010_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        '納期 
        If CType(Fields("DELIVERY_DT").Value, String).Equals("00000000") Then
            Fields("Nouki").Value = ""
        Else
            Fields("Nouki").Value = CType(Fields("DELIVERY_DT").Value, String).Substring(0, 4) + "/" + _
                                    CType(Fields("DELIVERY_DT").Value, String).Substring(4, 2) + "/" + _
                                    CType(Fields("DELIVERY_DT").Value, String).Substring(6, 2)
        End If
        '作業可能 
        Select Case CType(Fields("作業可能").Value, String)
            Case "0"
                Fields("Kanou").Value = "*"
            Case "1"
                Fields("Kanou").Value = "*!"
            Case "2"
                Fields("Kanou").Value = ""
        End Select
    End Sub

End Class 
