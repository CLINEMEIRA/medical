Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System


Imports System.Data.OracleClient

Public Class mdtna0203
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
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTanaDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtGaichuCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtGaichuName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtChumonNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtSijiNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtSyanaiNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtCatalog As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtSyukka As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtKoutei As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtKoujun As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtHacchu As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private linUnder As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtna0203))
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
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTanaDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGaichuCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGaichuName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtChumonNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSijiNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSyanaiNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCatalog = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSyukka = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtKoutei = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtKoujun = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtHacchu = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.linUnder = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGaichuCode, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGaichuName, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtChumonNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSijiNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyanaiNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyukka, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKoutei, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKoujun, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHacchu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtChumonNo, Me.Line9, Me.Line1, Me.Line2, Me.txtSijiNo, Me.Line3, Me.txtSyanaiNo, Me.Line4, Me.txtCatalog, Me.Line5, Me.txtSyukka, Me.Line6, Me.txtKoutei, Me.Line7, Me.txtKoujun, Me.Line8, Me.txtHacchu, Me.Line10, Me.linUnder})
        Me.Detail.Height = 0.25!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label, Me.Label11, Me.lblDate, Me.Label12, Me.lblPage})
        Me.PageHeader.Height = 0.55!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label16, Me.Label17, Me.Label18, Me.Label19})
        Me.PageFooter.Height = 0.9375!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label15, Me.Label14, Me.Label13, Me.Label10, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label9, Me.lblTanaDate, Me.Label1, Me.Label2, Me.txtGaichuCode, Me.txtGaichuName, Me.Label3, Me.Line, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line22})
        Me.GroupHeader1.DataField = "GaichuCode"
        Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.GroupHeader1.Height = 1.072222!
        Me.GroupHeader1.KeepTogether = true
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.Visible = false
        '
        'Label
        '
        Me.Label.Height = 0.2666667!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.06666667!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; text-align: center; vertical-align: bot" & _
            "tom"
        Me.Label.Text = "※※※　仕掛棚卸表　※※※"
        Me.Label.Top = 0.06666667!
        Me.Label.Width = 7.333333!
        '
        'Label11
        '
        Me.Label11.Height = 0.2000001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 5.933333!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label11.Text = "作成日："
        Me.Label11.Top = 0.1333333!
        Me.Label11.Width = 0.666666!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2000001!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.6!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.lblDate.Text = "YYYY/MM/DD"
        Me.lblDate.Top = 0.1333333!
        Me.lblDate.Width = 0.8!
        '
        'Label12
        '
        Me.Label12.Height = 0.2000001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 6.733333!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label12.Text = "PAGE."
        Me.Label12.Top = 0.3333334!
        Me.Label12.Width = 0.3999996!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2000001!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 7.133333!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.lblPage.Text = "999"
        Me.lblPage.Top = 0.3333333!
        Me.lblPage.Width = 0.2666664!
        '
        'Label15
        '
        Me.Label15.Height = 0.2666667!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 6.266663!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label15.Text = "発注日"
        Me.Label15.Top = 0.8!
        Me.Label15.Width = 1!
        '
        'Label14
        '
        Me.Label14.Height = 0.2666667!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 5.733331!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label14.Text = "工順"
        Me.Label14.Top = 0.8!
        Me.Label14.Width = 0.5333334!
        '
        'Label13
        '
        Me.Label13.Height = 0.2666667!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 5.199998!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label13.Text = "工程"
        Me.Label13.Top = 0.8!
        Me.Label13.Width = 0.5333334!
        '
        'Label10
        '
        Me.Label10.Height = 0.2666667!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 4.133333!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label10.Text = "出荷数"
        Me.Label10.Top = 0.8!
        Me.Label10.Width = 1.066667!
        '
        'Label8
        '
        Me.Label8.Height = 0.2666667!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.6!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label8.Text = "カタログ番号"
        Me.Label8.Top = 0.8!
        Me.Label8.Width = 1.533334!
        '
        'Label7
        '
        Me.Label7.Height = 0.2666667!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.333!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label7.Text = "社内NO"
        Me.Label7.Top = 0.813!
        Me.Label7.Width = 0.6666667!
        '
        'Label6
        '
        Me.Label6.Height = 0.2666667!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label6.Text = "指示NO"
        Me.Label6.Top = 0.8125!
        Me.Label6.Width = 0.6000001!
        '
        'Label5
        '
        Me.Label5.Height = 0.2666667!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.5333334!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label5.Text = "注文NO"
        Me.Label5.Top = 0.8!
        Me.Label5.Width = 0.8!
        '
        'Label4
        '
        Me.Label4.Height = 0.2666667!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.06666667!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label4.Text = "ﾁｪｯｸ"
        Me.Label4.Top = 0.8!
        Me.Label4.Width = 0.4666668!
        '
        'Label9
        '
        Me.Label9.Height = 0.2000001!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.06666667!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label9.Text = "棚卸日："
        Me.Label9.Top = 0.06666667!
        Me.Label9.Width = 0.666666!
        '
        'lblTanaDate
        '
        Me.lblTanaDate.Height = 0.2000001!
        Me.lblTanaDate.HyperLink = Nothing
        Me.lblTanaDate.Left = 0.7333333!
        Me.lblTanaDate.Name = "lblTanaDate"
        Me.lblTanaDate.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.lblTanaDate.Text = "YYYY年MM月DD日"
        Me.lblTanaDate.Top = 0.06666667!
        Me.lblTanaDate.Width = 1.2!
        '
        'Label1
        '
        Me.Label1.Height = 0.2000001!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 4.8!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label1.Text = "メイラ株式会社　メディカル生産部"
        Me.Label1.Top = 0.06666667!
        Me.Label1.Width = 2.599999!
        '
        'Label2
        '
        Me.Label2.Height = 0.2000001!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.06666667!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label2.Text = "コード："
        Me.Label2.Top = 0.2666667!
        Me.Label2.Width = 0.666666!
        '
        'txtGaichuCode
        '
        Me.txtGaichuCode.DataField = "CONTRACTOUT_CD"
        Me.txtGaichuCode.Height = 0.2!
        Me.txtGaichuCode.Left = 0.7333333!
        Me.txtGaichuCode.Name = "txtGaichuCode"
        Me.txtGaichuCode.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtGaichuCode.Text = "XXXX"
        Me.txtGaichuCode.Top = 0.2666667!
        Me.txtGaichuCode.Width = 0.3999999!
        '
        'txtGaichuName
        '
        Me.txtGaichuName.DataField = "CONTRACTOUT_NM"
        Me.txtGaichuName.Height = 0.2!
        Me.txtGaichuName.Left = 0.1333333!
        Me.txtGaichuName.Name = "txtGaichuName"
        Me.txtGaichuName.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtGaichuName.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
        Me.txtGaichuName.Top = 0.4666668!
        Me.txtGaichuName.Width = 2.4!
        '
        'Label3
        '
        Me.Label3.Height = 0.2000001!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.533333!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label3.Text = "御中　　社印"
        Me.Label3.Top = 0.4666668!
        Me.Label3.Width = 1!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.1333333!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.6666667!
        Me.Line.Width = 3.4!
        Me.Line.X1 = 0.1333333!
        Me.Line.X2 = 3.533333!
        Me.Line.Y1 = 0.6666667!
        Me.Line.Y2 = 0.6666667!
        '
        'Line11
        '
        Me.Line11.Height = 0.2666667!
        Me.Line11.Left = 0.06666667!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.8!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 0.06666667!
        Me.Line11.X2 = 0.06666667!
        Me.Line11.Y1 = 0.8!
        Me.Line11.Y2 = 1.066667!
        '
        'Line12
        '
        Me.Line12.Height = 0.2666667!
        Me.Line12.Left = 0.5333334!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.8!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 0.5333334!
        Me.Line12.X2 = 0.5333334!
        Me.Line12.Y1 = 0.8!
        Me.Line12.Y2 = 1.066667!
        '
        'Line13
        '
        Me.Line13.Height = 0.2666667!
        Me.Line13.Left = 1.333333!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.8!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 1.333333!
        Me.Line13.X2 = 1.333333!
        Me.Line13.Y1 = 0.8!
        Me.Line13.Y2 = 1.066667!
        '
        'Line14
        '
        Me.Line14.Height = 0.2666667!
        Me.Line14.Left = 1.995834!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.8!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 1.995834!
        Me.Line14.X2 = 1.995834!
        Me.Line14.Y1 = 0.8!
        Me.Line14.Y2 = 1.066667!
        '
        'Line15
        '
        Me.Line15.Height = 0.2666667!
        Me.Line15.Left = 2.6!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.8!
        Me.Line15.Width = 0!
        Me.Line15.X1 = 2.6!
        Me.Line15.X2 = 2.6!
        Me.Line15.Y1 = 0.8!
        Me.Line15.Y2 = 1.066667!
        '
        'Line16
        '
        Me.Line16.Height = 0.2666667!
        Me.Line16.Left = 4.133333!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.8!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 4.133333!
        Me.Line16.X2 = 4.133333!
        Me.Line16.Y1 = 0.8!
        Me.Line16.Y2 = 1.066667!
        '
        'Line17
        '
        Me.Line17.Height = 0.2666667!
        Me.Line17.Left = 5.199998!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.8!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 5.199998!
        Me.Line17.X2 = 5.199998!
        Me.Line17.Y1 = 0.8!
        Me.Line17.Y2 = 1.066667!
        '
        'Line18
        '
        Me.Line18.Height = 0.2666667!
        Me.Line18.Left = 5.733331!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.8!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 5.733331!
        Me.Line18.X2 = 5.733331!
        Me.Line18.Y1 = 0.8!
        Me.Line18.Y2 = 1.066667!
        '
        'Line19
        '
        Me.Line19.Height = 0.2666667!
        Me.Line19.Left = 6.266664!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.8!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 6.266664!
        Me.Line19.X2 = 6.266664!
        Me.Line19.Y1 = 0.8!
        Me.Line19.Y2 = 1.066667!
        '
        'Line20
        '
        Me.Line20.Height = 0.2666667!
        Me.Line20.Left = 7.266667!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.8!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 7.266667!
        Me.Line20.X2 = 7.266667!
        Me.Line20.Y1 = 0.8!
        Me.Line20.Y2 = 1.066667!
        '
        'Line21
        '
        Me.Line21.Height = 0!
        Me.Line21.Left = 0.06666667!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.8!
        Me.Line21.Width = 7.2!
        Me.Line21.X1 = 0.06666667!
        Me.Line21.X2 = 7.266667!
        Me.Line21.Y1 = 0.8!
        Me.Line21.Y2 = 0.8!
        '
        'Line22
        '
        Me.Line22.Height = 0!
        Me.Line22.Left = 0.06666667!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 1.066667!
        Me.Line22.Width = 7.2!
        Me.Line22.X1 = 0.06666667!
        Me.Line22.X2 = 7.266667!
        Me.Line22.Y1 = 1.066667!
        Me.Line22.Y2 = 1.066667!
        '
        'txtChumonNo
        '
        Me.txtChumonNo.DataField = "ORDER_NO"
        Me.txtChumonNo.Height = 0.2!
        Me.txtChumonNo.Left = 0.5999998!
        Me.txtChumonNo.Name = "txtChumonNo"
        Me.txtChumonNo.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtChumonNo.Text = "XX-XXXXX"
        Me.txtChumonNo.Top = 0.06666666!
        Me.txtChumonNo.Width = 0.6666666!
        '
        'Line9
        '
        Me.Line9.Height = 0.25!
        Me.Line9.Left = 0.06666667!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 0.06666667!
        Me.Line9.X2 = 0.06666667!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0.25!
        '
        'Line1
        '
        Me.Line1.Height = 0.25!
        Me.Line1.Left = 0.5333334!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0!
        Me.Line1.Width = 0!
        Me.Line1.X1 = 0.5333334!
        Me.Line1.X2 = 0.5333334!
        Me.Line1.Y1 = 0!
        Me.Line1.Y2 = 0.25!
        '
        'Line2
        '
        Me.Line2.Height = 0.25!
        Me.Line2.Left = 1.333333!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0!
        Me.Line2.Width = 0!
        Me.Line2.X1 = 1.333333!
        Me.Line2.X2 = 1.333333!
        Me.Line2.Y1 = 0!
        Me.Line2.Y2 = 0.25!
        '
        'txtSijiNo
        '
        Me.txtSijiNo.DataField = "INDICATE_NO"
        Me.txtSijiNo.Height = 0.2!
        Me.txtSijiNo.Left = 2.0625!
        Me.txtSijiNo.Name = "txtSijiNo"
        Me.txtSijiNo.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtSijiNo.Text = "XXXXX"
        Me.txtSijiNo.Top = 0.067!
        Me.txtSijiNo.Width = 0.4666668!
        '
        'Line3
        '
        Me.Line3.Height = 0.25!
        Me.Line3.Left = 1.995834!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 1.995834!
        Me.Line3.X2 = 1.995834!
        Me.Line3.Y1 = 0!
        Me.Line3.Y2 = 0.25!
        '
        'txtSyanaiNo
        '
        Me.txtSyanaiNo.DataField = "COMPANY_NO"
        Me.txtSyanaiNo.Height = 0.2!
        Me.txtSyanaiNo.Left = 1.4!
        Me.txtSyanaiNo.Name = "txtSyanaiNo"
        Me.txtSyanaiNo.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtSyanaiNo.Text = "XXXXXX"
        Me.txtSyanaiNo.Top = 0.067!
        Me.txtSyanaiNo.Width = 0.5333335!
        '
        'Line4
        '
        Me.Line4.Height = 0.25!
        Me.Line4.Left = 2.6!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 2.6!
        Me.Line4.X2 = 2.6!
        Me.Line4.Y1 = 0!
        Me.Line4.Y2 = 0.25!
        '
        'txtCatalog
        '
        Me.txtCatalog.DataField = "CATALOG_NO"
        Me.txtCatalog.Height = 0.2!
        Me.txtCatalog.Left = 2.666667!
        Me.txtCatalog.Name = "txtCatalog"
        Me.txtCatalog.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtCatalog.Text = "XXXXXXXXXXXXXXXXX"
        Me.txtCatalog.Top = 0.06666666!
        Me.txtCatalog.Width = 1.4!
        '
        'Line5
        '
        Me.Line5.Height = 0.2499999!
        Me.Line5.Left = 4.133333!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 7.450583E-08!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 4.133333!
        Me.Line5.X2 = 4.133333!
        Me.Line5.Y1 = 7.450583E-08!
        Me.Line5.Y2 = 0.25!
        '
        'txtSyukka
        '
        Me.txtSyukka.DataField = "STOCK_AMT"
        Me.txtSyukka.Height = 0.2!
        Me.txtSyukka.Left = 4.2!
        Me.txtSyukka.Name = "txtSyukka"
        Me.txtSyukka.OutputFormat = resources.GetString("txtSyukka.OutputFormat")
        Me.txtSyukka.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om"
        Me.txtSyukka.Text = "Z,ZZZ,ZZZ"
        Me.txtSyukka.Top = 0.06666667!
        Me.txtSyukka.Width = 0.9333333!
        '
        'Line6
        '
        Me.Line6.Height = 0.2499998!
        Me.Line6.Left = 5.199998!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.639128E-07!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 5.199998!
        Me.Line6.X2 = 5.199998!
        Me.Line6.Y1 = 1.639128E-07!
        Me.Line6.Y2 = 0.25!
        '
        'txtKoutei
        '
        Me.txtKoutei.DataField = "PROCESS"
        Me.txtKoutei.Height = 0.2!
        Me.txtKoutei.Left = 5.266667!
        Me.txtKoutei.Name = "txtKoutei"
        Me.txtKoutei.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtKoutei.Text = "XXXX"
        Me.txtKoutei.Top = 0.06666666!
        Me.txtKoutei.Width = 0.4000001!
        '
        'Line7
        '
        Me.Line7.Height = 0.25!
        Me.Line7.Left = 5.733331!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 5.733331!
        Me.Line7.X2 = 5.733331!
        Me.Line7.Y1 = 0!
        Me.Line7.Y2 = 0.25!
        '
        'txtKoujun
        '
        Me.txtKoujun.DataField = "PROCESS_ORDER"
        Me.txtKoujun.Height = 0.2!
        Me.txtKoujun.Left = 5.8!
        Me.txtKoujun.Name = "txtKoujun"
        Me.txtKoujun.OutputFormat = resources.GetString("txtKoujun.OutputFormat")
        Me.txtKoujun.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: center; vertical-align: bot" & _
            "tom"
        Me.txtKoujun.Text = "XXX"
        Me.txtKoujun.Top = 0.06666667!
        Me.txtKoujun.Width = 0.4000001!
        '
        'Line8
        '
        Me.Line8.Height = 0.2499999!
        Me.Line8.Left = 6.266663!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.043081E-07!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 6.266663!
        Me.Line8.X2 = 6.266663!
        Me.Line8.Y1 = 1.043081E-07!
        Me.Line8.Y2 = 0.25!
        '
        'txtHacchu
        '
        Me.txtHacchu.DataField = "ORDER_DT"
        Me.txtHacchu.Height = 0.2!
        Me.txtHacchu.Left = 6.333333!
        Me.txtHacchu.Name = "txtHacchu"
        Me.txtHacchu.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: center; vertical-align: bot" & _
            "tom"
        Me.txtHacchu.Text = "YYYY/MM/DD"
        Me.txtHacchu.Top = 0.06666667!
        Me.txtHacchu.Width = 0.8666667!
        '
        'Line10
        '
        Me.Line10.Height = 0.25!
        Me.Line10.Left = 7.266667!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 7.266667!
        Me.Line10.X2 = 7.266667!
        Me.Line10.Y1 = 0!
        Me.Line10.Y2 = 0.25!
        '
        'linUnder
        '
        Me.linUnder.Height = 0!
        Me.linUnder.Left = 0.06666667!
        Me.linUnder.LineWeight = 1!
        Me.linUnder.Name = "linUnder"
        Me.linUnder.Top = 0.25!
        Me.linUnder.Width = 7.2!
        Me.linUnder.X1 = 0.06666667!
        Me.linUnder.X2 = 7.266667!
        Me.linUnder.Y1 = 0.25!
        Me.linUnder.Y2 = 0.25!
        '
        'Label16
        '
        Me.Label16.Height = 0.2!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.1333333!
        Me.Label16.MultiLine = false
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label16.Text = "1.次ページ以降に記載がない場合に、使用して下さい。"
        Me.Label16.Top = 0.06666667!
        Me.Label16.Width = 5.933333!
        '
        'Label17
        '
        Me.Label17.Height = 0.2!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.1333333!
        Me.Label17.MultiLine = false
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label17.Text = "2.白紙でも全ページ返送願います。"
        Me.Label17.Top = 0.2666667!
        Me.Label17.Width = 5.933333!
        '
        'Label18
        '
        Me.Label18.Height = 0.2!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.1333333!
        Me.Label18.MultiLine = false
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label18.Text = "3.材料からの加工の場合、従来は『材料棚卸表』にて棚卸をしていただきましたが、"
        Me.Label18.Top = 0.4666668!
        Me.Label18.Width = 5.933333!
        '
        'Label19
        '
        Me.Label19.Height = 0.2!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.1333333!
        Me.Label19.MultiLine = false
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label19.Text = "  今回より他の部品と同様に『仕掛棚卸表』で仕掛品として棚卸願います。"
        Me.Label19.Top = 0.6666667!
        Me.Label19.Width = 5.933333!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.6!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
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
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGaichuCode, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGaichuName, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtChumonNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSijiNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyanaiNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyukka, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKoutei, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKoujun, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHacchu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private Const ROW_MAX_SPACE As Integer = 32
    Private Const ROW_MAX_DETAIL As Integer = 35

    Private _nPage As Integer = 1

    Private _nGroupCount As Integer = -1
    Private _nDetailCount As Integer = 1
    Private _nReaderEOF As Boolean = False
    Private _sBrakeKey As String = ""
    Private _nBrakeFlag As Boolean = False

    Private _sTanaDate As String = "00000000"
    Private _sConnect As String = "User Id=mdctest;Password=mdctest;Data Source=MEDICAL;"
    Private _sQuery As String = "SELECT A.CONTRACTOUT_CD,A.CONTRACTOUT_NM,B.ORDER_NO,B.INDICATE_NO,B.COMPANY_NO,B.CATALOG_NO,B.STOCK_AMT,B.PROCESS,B.PROCESS_ORDER,B.ORDER_DT " + _
                                "FROM (SELECT CONTRACTOUT_CD,CONTRACTOUT_NM FROM CONTRACTOUT_MST WHERE CONTRACTOUT_KB = '1') A,(SELECT * FROM CONTRACTOUT_WP_TBL WHERE INVENT_DT = '20070331') B " + _
                                "WHERE A.CONTRACTOUT_CD = B.CONTRACTOUT_CD(+) " + _
                                "ORDER BY A.CONTRACTOUT_CD,B.CATALOG_NO,B.PROCESS_ORDER"
    'Private _sQuery As String = "SELECT A.外注コード,A.外注名称,'' 注文NO,'' 指示NO,'' 社内NO,'' カタログ番号,0 在庫数,'' 工程,0 工順,'' 発注日 " + _ 
    '                            "FROM (SELECT 外注コード,外注名称 FROM 外注マスタ WHERE 加工外注区分 = '1') A " + _ 
    '                            "WHERE NOT EXISTS (SELECT * FROM 外注仕掛テーブル WHERE 棚卸日 = '20070331' AND 外注コード = A.外注コード) " + _ 
    '                            "ORDER BY A.外注コード" 


    Private _oConnection As OracleConnection = Nothing
    Private _oReader As OracleDataReader = Nothing

#Region " プロパティ "

    Public WriteOnly Property TanaDate() As String
        Set(ByVal sValue As String)
            _sTanaDate = sValue.Trim.PadLeft(8, "0")
        End Set
    End Property

    Public WriteOnly Property Connect() As String
        Set(ByVal sValue As String)
            _sConnect = sValue
        End Set
    End Property

    Public WriteOnly Property Query() As String
        Set(ByVal sValue As String)
            _sQuery = sValue
        End Set
    End Property

#End Region

    Private Sub mdtna0203_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Try
            Fields.Add("GaichuCode")
            Fields.Add("GaichuName")
            Fields.Add("ChumonNo")
            Fields.Add("SijiNo")
            Fields.Add("SyanaiNo")
            Fields.Add("Catalog")
            Fields.Add("Syukka")
            Fields.Add("Koutei")
            Fields.Add("Koujun")
            Fields.Add("Hacchu")
            txtGaichuCode.DataField = "GaichuCode"
            txtGaichuName.DataField = "GaichuName"
            txtChumonNo.DataField = "ChumonNo"
            txtSijiNo.DataField = "SijiNo"
            txtSyanaiNo.DataField = "SyanaiNo"
            txtCatalog.DataField = "Catalog"
            txtSyukka.DataField = "Syukka"
            txtKoutei.DataField = "Koutei"
            txtKoujun.DataField = "Koujun"
            txtHacchu.DataField = "Hacchu"
            _oConnection = New OracleConnection(_sConnect)
            _oConnection.Open()
            Dim oCommand As OracleCommand = _oConnection.CreateCommand()
            oCommand.CommandText = _sQuery
            _oReader = oCommand.ExecuteReader
            _oReader.Read()
            SetGroup()
        Catch ex As Exception
            'MessageBox.Show(ex.Message) 
        End Try
    End Sub

    Private Sub mdtna0201_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        Try
            If Not _nReaderEOF Then
                If _nGroupCount = 0 Then
                    If _nDetailCount < ROW_MAX_SPACE Then
                        SetSpace()
                    Else
                        SetGroup()
                        SetDetail()
                    End If
                Else
                    If Not _nBrakeFlag Then
                        If _oReader.Read() Then
                            If _sBrakeKey <> GetString(_oReader, 0) Then
                                SetSpace()
                                _nBrakeFlag = True
                            Else
                                SetDetail()
                            End If
                        Else
                            SetSpace()
                            _nReaderEOF = True
                        End If
                    Else
                        If _nDetailCount < ROW_MAX_DETAIL Then
                            SetSpace()
                        Else
                            _nGroupCount = -1
                            SetGroup()
                            SetSpace()
                        End If
                    End If
                End If
                eArgs.EOF = False
            Else
                If _nDetailCount < ROW_MAX_DETAIL Then
                    SetSpace()
                    eArgs.EOF = False
                Else
                    eArgs.EOF = True
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message) 
            eArgs.EOF = True
        End Try
    End Sub

    Private Sub mdtna0203_PageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageStart
        PageFooter.Visible = _nGroupCount = 0
        If _nGroupCount = 0 Then _nPage = 1
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblPage.Text = _nPage.ToString("#").Trim.PadLeft(3, " ")
        _nPage += 1
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        'lblTanaDate.Text = _sTanaDate.Substring(0, 4) + "年" + _sTanaDate.Substring(4, 2) + "月" + _sTanaDate.Substring(6, 2) + "日" 
        lblTanaDate.Text = _sTanaDate
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Dim nMaxCount As Integer = 0
        If _nGroupCount = 0 Then
            nMaxCount = ROW_MAX_SPACE
        Else
            nMaxCount = ROW_MAX_DETAIL
        End If
        If _nDetailCount < nMaxCount Then
            linUnder.LineStyle = LineStyle.Dot
        Else
            linUnder.LineStyle = LineStyle.Solid
        End If
    End Sub

#Region " その他 "

    Private Sub SetGroup()
        Fields("GaichuCode").Value = GetString(_oReader, 0)
        Fields("GaichuName").Value = GetString(_oReader, 1)
        _sBrakeKey = GetString(_oReader, 0)
        _nGroupCount += 1
        _nDetailCount = 0
    End Sub

    Private Sub SetDetail()
        If Not _oReader.IsDBNull(2) Then
            Fields("ChumonNo").Value = GetString(_oReader, 2)
            Fields("SijiNo").Value = GetString(_oReader, 3)
            Fields("SyanaiNo").Value = GetString(_oReader, 4)
            Fields("Catalog").Value = GetString(_oReader, 5)
            Fields("Syukka").Value = GetInt32(_oReader, 6)
            Fields("Koutei").Value = GetString(_oReader, 7)
            Fields("Koujun").Value = GetInt32(_oReader, 8)
            Fields("Hacchu").Value = DateFormat(GetString(_oReader, 9))
            _nDetailCount += 1
        Else
            SetSpace()
        End If
        If _nDetailCount >= ROW_MAX_DETAIL Then _nDetailCount = 0
        _nBrakeFlag = False
    End Sub

    Private Sub SetSpace()
        Fields("ChumonNo").Value = ""
        Fields("SijiNo").Value = ""
        Fields("SyanaiNo").Value = ""
        Fields("Catalog").Value = ""
        Fields("Syukka").Value = ""
        Fields("Koutei").Value = ""
        Fields("Koujun").Value = ""
        Fields("Hacchu").Value = ""
        _nDetailCount += 1
    End Sub

    Private Function GetString(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As String
        If oReader.IsDBNull(nIndex) Then Return ""
        Return oReader.GetString(nIndex).Trim()
    End Function

    Private Function GetInt32(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Int32
        If oReader.IsDBNull(nIndex) Then Return 0
        Return oReader.GetInt32(nIndex)
    End Function

    Private Function GetDouble(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Double
        If oReader.IsDBNull(nIndex) Then Return 0.0
        Return oReader.GetDouble(nIndex)
    End Function

    Private Function DateFormat(ByVal sValue As String) As String
        If sValue.Trim.Equals("00000000") Then Return ""
        Return sValue.Substring(0, 4) + "/" + sValue.Substring(4, 2) + "/" + sValue.Substring(6, 2)
    End Function

#End Region

End Class 
