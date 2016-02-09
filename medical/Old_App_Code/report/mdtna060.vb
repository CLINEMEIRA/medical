Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdtna060
    Inherits GrapeCity.ActiveReports.SectionReport
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTanaDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtBasho As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtShanai As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCatalog As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSiji As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKoujun As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKoutei As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtShop As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSu As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtna060))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTanaDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtBasho = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtShanai = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCatalog = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSiji = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKoujun = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKoutei = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtShop = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSu = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBasho, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtShanai, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSiji, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKoujun, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKoutei, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtShop, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtBasho, Me.txtShanai, Me.txtCatalog, Me.txtSiji, Me.txtKoujun, Me.txtKoutei, Me.txtShop, Me.txtSu})
        Me.Detail.Height = 0.1506944!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Line, Me.Label, Me.Label11, Me.lblDate, Me.Label12, Me.lblPage, Me.Label1, Me.lblTanaDate})
        Me.PageHeader.Height = 0.8854167!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'Label2
        '
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label2.Text = "場所"
        Me.Label2.Top = 0.6875!
        Me.Label2.Width = 0.375!
        '
        'Label3
        '
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.5!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label3.Text = "社内NO"
        Me.Label3.Top = 0.6875!
        Me.Label3.Width = 0.4375!
        '
        'Label4
        '
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label4.Text = "カタログ番号"
        Me.Label4.Top = 0.6875!
        Me.Label4.Width = 1.25!
        '
        'Label5
        '
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.25!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label5.Text = "指示NO"
        Me.Label5.Top = 0.6875!
        Me.Label5.Width = 0.4375!
        '
        'Label6
        '
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2.75!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label6.Text = "工順"
        Me.Label6.Top = 0.6875!
        Me.Label6.Width = 0.3125!
        '
        'Label7
        '
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.125!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label7.Text = "工程名称"
        Me.Label7.Top = 0.6875!
        Me.Label7.Width = 1.4375!
        '
        'Label8
        '
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.625!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label8.Text = "SHOP"
        Me.Label8.Top = 0.6875!
        Me.Label8.Width = 2.0625!
        '
        'Label9
        '
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 6.6875!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label9.Text = "数量"
        Me.Label9.Top = 0.6875!
        Me.Label9.Width = 0.875!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.875!
        Me.Line.Width = 7.5625!
        Me.Line.X1 = 0!
        Me.Line.X2 = 7.5625!
        Me.Line.Y1 = 0.875!
        Me.Line.Y2 = 0.875!
        '
        'Label
        '
        Me.Label.Height = 0.2666667!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.1458333!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; text-align: center; vertical-align: bot" & _
            "tom"
        Me.Label.Text = "ＨＴ仕掛品棚卸明細"
        Me.Label.Top = 0!
        Me.Label.Width = 7.333333!
        '
        'Label11
        '
        Me.Label11.Height = 0.2000001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 5.75!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label11.Text = "作成日："
        Me.Label11.Top = 0.125!
        Me.Label11.Width = 0.666666!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2000001!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.416667!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.lblDate.Text = "YYYY/MM/DD"
        Me.lblDate.Top = 0.125!
        Me.lblDate.Width = 0.8!
        '
        'Label12
        '
        Me.Label12.Height = 0.2000001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 6.55!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.Label12.Text = "PAGE."
        Me.Label12.Top = 0.3250001!
        Me.Label12.Width = 0.3999996!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2000001!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 6.95!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.lblPage.Text = "999"
        Me.lblPage.Top = 0.325!
        Me.lblPage.Width = 0.2666664!
        '
        'Label1
        '
        Me.Label1.Height = 0.2000001!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.1458333!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label1.Text = "棚卸日："
        Me.Label1.Top = 0.4041668!
        Me.Label1.Width = 0.666666!
        '
        'lblTanaDate
        '
        Me.lblTanaDate.Height = 0.2000001!
        Me.lblTanaDate.HyperLink = Nothing
        Me.lblTanaDate.Left = 0.8125!
        Me.lblTanaDate.Name = "lblTanaDate"
        Me.lblTanaDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.lblTanaDate.Text = "YYYY年MM月DD日"
        Me.lblTanaDate.Top = 0.4041668!
        Me.lblTanaDate.Width = 1.2!
        '
        'txtBasho
        '
        Me.txtBasho.DataField = "LOCATION"
        Me.txtBasho.Height = 0.15!
        Me.txtBasho.Left = 0.0625!
        Me.txtBasho.Name = "txtBasho"
        Me.txtBasho.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtBasho.Text = "99999"
        Me.txtBasho.Top = 0!
        Me.txtBasho.Width = 0.375!
        '
        'txtShanai
        '
        Me.txtShanai.DataField = "COMPANY_NO"
        Me.txtShanai.Height = 0.15!
        Me.txtShanai.Left = 0.5!
        Me.txtShanai.Name = "txtShanai"
        Me.txtShanai.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtShanai.Text = "999999"
        Me.txtShanai.Top = 0!
        Me.txtShanai.Width = 0.4375!
        '
        'txtCatalog
        '
        Me.txtCatalog.DataField = "CATALOG_NO"
        Me.txtCatalog.Height = 0.15!
        Me.txtCatalog.Left = 1!
        Me.txtCatalog.Name = "txtCatalog"
        Me.txtCatalog.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtCatalog.Text = "XXXXXXXXXXXXXXXXX"
        Me.txtCatalog.Top = 0!
        Me.txtCatalog.Width = 1.25!
        '
        'txtSiji
        '
        Me.txtSiji.DataField = "INDICATE_NO"
        Me.txtSiji.Height = 0.15!
        Me.txtSiji.Left = 2.25!
        Me.txtSiji.Name = "txtSiji"
        Me.txtSiji.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtSiji.Text = "99999"
        Me.txtSiji.Top = 0!
        Me.txtSiji.Width = 0.4375!
        '
        'txtKoujun
        '
        Me.txtKoujun.DataField = "PROCESS_ORDER"
        Me.txtKoujun.Height = 0.15!
        Me.txtKoujun.Left = 2.75!
        Me.txtKoujun.Name = "txtKoujun"
        Me.txtKoujun.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtKoujun.Text = "999"
        Me.txtKoujun.Top = 0!
        Me.txtKoujun.Width = 0.25!
        '
        'txtKoutei
        '
        Me.txtKoutei.DataField = "P_ORDER_NM"
        Me.txtKoutei.Height = 0.15!
        Me.txtKoutei.Left = 3.125!
        Me.txtKoutei.Name = "txtKoutei"
        Me.txtKoutei.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtKoutei.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txtKoutei.Top = 0!
        Me.txtKoutei.Width = 1.4375!
        '
        'txtShop
        '
        Me.txtShop.DataField = "SHOP_NM"
        Me.txtShop.Height = 0.15!
        Me.txtShop.Left = 4.625!
        Me.txtShop.Name = "txtShop"
        Me.txtShop.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtShop.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txtShop.Top = 0!
        Me.txtShop.Width = 2.0625!
        '
        'txtSu
        '
        Me.txtSu.DataField = "INVENT_AMT"
        Me.txtSu.Height = 0.15!
        Me.txtSu.Left = 6.6875!
        Me.txtSu.Name = "txtSu"
        Me.txtSu.OutputFormat = resources.GetString("txtSu.OutputFormat")
        Me.txtSu.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSu.Text = "9.999.999,99"
        Me.txtSu.Top = 0!
        Me.txtSu.Width = 0.875!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        Me.PageSettings.DefaultPaperSize = false
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.4!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69306!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.268056!
        Me.PrintWidth = 7.625!
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
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBasho, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtShanai, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSiji, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKoujun, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKoutei, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtShop, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Dim strBuff As String
    Private nPage As Integer = 1

    Private _sTanaDate As String = ""

    Public WriteOnly Property TanaDate() As String
        Set(ByVal sValue As String)
            _sTanaDate = sValue
        End Set
    End Property

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblTanaDate.Text = _sTanaDate
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblPage.Text = nPage.ToString("#").Trim.PadLeft(3, " ")
        nPage += 1
    End Sub
End Class
