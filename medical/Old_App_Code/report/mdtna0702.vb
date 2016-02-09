Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdtna0702
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
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTanaDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtBIKOU As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTBL_KB As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCatalog As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKumi As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSyanaiNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSijiNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZaiko As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private linUnder As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtSyusyu As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtMemo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtna0702))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTanaDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtBIKOU = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTBL_KB = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCatalog = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKumi = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSyanaiNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSijiNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZaiko = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.linUnder = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSyusyu = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtMemo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBIKOU, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTBL_KB, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKumi, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyanaiNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSijiNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZaiko, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyusyu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtBIKOU, Me.txtTBL_KB, Me.txtCatalog, Me.txtKumi, Me.txtSyanaiNo, Me.txtSijiNo, Me.txtZaiko, Me.linUnder, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.txtSyusyu, Me.Line9, Me.txtMemo})
        Me.Detail.Height = 0.2597222!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label2, Me.Label, Me.lblTitle, Me.Label11, Me.lblDate, Me.Label12, Me.lblPage, Me.Label9, Me.lblTanaDate, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label1, Me.Line1, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line18, Me.Line19, Me.Line21, Me.Line})
        Me.PageHeader.Height = 1.197222!
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
        Me.Label2.Height = 0.267!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.385999!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label2.Text = "収集方法"
        Me.Label2.Top = 0.933!
        Me.Label2.Width = 1.114!
        '
        'Label
        '
        Me.Label.Height = 0.267!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 5.5!
        Me.Label.Name = "Label"
        Me.Label.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label.Text = "備考"
        Me.Label.Top = 0.933!
        Me.Label.Width = 1.875!
        '
        'lblTitle
        '
        Me.lblTitle.Height = 0.2666667!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 0.06666667!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; text-align: center; vertical-align: bot" & _
            "tom"
        Me.lblTitle.Text = "※※※　棚卸表（実棚重複リスト）　※※※"
        Me.lblTitle.Top = 0.06666667!
        Me.lblTitle.Width = 7.333333!
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
        Me.lblDate.Width = 0.8375!
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
        'Label9
        '
        Me.Label9.Height = 0.2000001!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.06666667!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label9.Text = "棚卸日："
        Me.Label9.Top = 0.5333334!
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
        Me.lblTanaDate.Top = 0.5333334!
        Me.lblTanaDate.Width = 1.2!
        '
        'Label6
        '
        Me.Label6.Height = 0.267!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 3.425!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label6.Text = "実棚数"
        Me.Label6.Top = 0.933!
        Me.Label6.Width = 0.9604167!
        '
        'Label5
        '
        Me.Label5.Height = 0.267!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.755!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label5.Text = "指示NO"
        Me.Label5.Top = 0.933!
        Me.Label5.Width = 0.681!
        '
        'Label4
        '
        Me.Label4.Height = 0.267!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.0695!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label4.Text = "社内NO"
        Me.Label4.Top = 0.933!
        Me.Label4.Width = 0.6805!
        '
        'Label3
        '
        Me.Label3.Height = 0.267!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.602083!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label3.Text = "組番"
        Me.Label3.Top = 0.9333333!
        Me.Label3.Width = 0.4666668!
        '
        'Label1
        '
        Me.Label1.Height = 0.267!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.06041655!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label1.Text = "カタログ番号"
        Me.Label1.Top = 0.9333333!
        Me.Label1.Width = 1.54!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.0605!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.2!
        Me.Line1.Width = 7.315!
        Me.Line1.X1 = 0.0605!
        Me.Line1.X2 = 7.3755!
        Me.Line1.Y1 = 1.2!
        Me.Line1.Y2 = 1.2!
        '
        'Line12
        '
        Me.Line12.Height = 0.2666667!
        Me.Line12.Left = 0.06041655!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.9333333!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 0.06041655!
        Me.Line12.X2 = 0.06041655!
        Me.Line12.Y1 = 0.9333333!
        Me.Line12.Y2 = 1.2!
        '
        'Line13
        '
        Me.Line13.Height = 0.2666667!
        Me.Line13.Left = 1.602084!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.9333333!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 1.602084!
        Me.Line13.X2 = 1.602084!
        Me.Line13.Y1 = 0.9333333!
        Me.Line13.Y2 = 1.2!
        '
        'Line14
        '
        Me.Line14.Height = 0.2666667!
        Me.Line14.Left = 2.0695!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.933!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 2.0695!
        Me.Line14.X2 = 2.0695!
        Me.Line14.Y1 = 0.933!
        Me.Line14.Y2 = 1.199667!
        '
        'Line15
        '
        Me.Line15.Height = 0.2666667!
        Me.Line15.Left = 2.755!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.933!
        Me.Line15.Width = 0!
        Me.Line15.X1 = 2.755!
        Me.Line15.X2 = 2.755!
        Me.Line15.Y1 = 0.933!
        Me.Line15.Y2 = 1.199667!
        '
        'Line16
        '
        Me.Line16.Height = 0.2666667!
        Me.Line16.Left = 3.425!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.933!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 3.425!
        Me.Line16.X2 = 3.425!
        Me.Line16.Y1 = 0.933!
        Me.Line16.Y2 = 1.199667!
        '
        'Line18
        '
        Me.Line18.Height = 0.2666667!
        Me.Line18.Left = 4.3855!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.933!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 4.3855!
        Me.Line18.X2 = 4.3855!
        Me.Line18.Y1 = 0.933!
        Me.Line18.Y2 = 1.199667!
        '
        'Line19
        '
        Me.Line19.Height = 0.2666667!
        Me.Line19.Left = 7.375!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.9375!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 7.375!
        Me.Line19.X2 = 7.375!
        Me.Line19.Y1 = 0.9375!
        Me.Line19.Y2 = 1.204167!
        '
        'Line21
        '
        Me.Line21.Height = 0!
        Me.Line21.Left = 0.06041655!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.9333333!
        Me.Line21.Width = 7.315!
        Me.Line21.X1 = 0.06041655!
        Me.Line21.X2 = 7.375416!
        Me.Line21.Y1 = 0.9333333!
        Me.Line21.Y2 = 0.9333333!
        '
        'Line
        '
        Me.Line.Height = 0.2666667!
        Me.Line.Left = 5.5!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.9375!
        Me.Line.Width = 0!
        Me.Line.X1 = 5.5!
        Me.Line.X2 = 5.5!
        Me.Line.Y1 = 0.9375!
        Me.Line.Y2 = 1.204167!
        '
        'txtBIKOU
        '
        Me.txtBIKOU.DataField = "BIKOU"
        Me.txtBIKOU.Height = 0.1!
        Me.txtBIKOU.Left = 5.5625!
        Me.txtBIKOU.Name = "txtBIKOU"
        Me.txtBIKOU.Text = "BIKOU"
        Me.txtBIKOU.Top = 0!
        Me.txtBIKOU.Visible = false
        Me.txtBIKOU.Width = 0.1!
        '
        'txtTBL_KB
        '
        Me.txtTBL_KB.DataField = "TBL_KB"
        Me.txtTBL_KB.Height = 0.1!
        Me.txtTBL_KB.Left = 4.4375!
        Me.txtTBL_KB.Name = "txtTBL_KB"
        Me.txtTBL_KB.Text = "TBL_KB"
        Me.txtTBL_KB.Top = 0!
        Me.txtTBL_KB.Visible = false
        Me.txtTBL_KB.Width = 0.1!
        '
        'txtCatalog
        '
        Me.txtCatalog.DataField = "CATALOG_NO"
        Me.txtCatalog.Height = 0.2!
        Me.txtCatalog.Left = 0.131!
        Me.txtCatalog.Name = "txtCatalog"
        Me.txtCatalog.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtCatalog.Text = "XXXXXXXXXXXXXXXXX"
        Me.txtCatalog.Top = 0.05!
        Me.txtCatalog.Width = 1.4!
        '
        'txtKumi
        '
        Me.txtKumi.DataField = "C_NO"
        Me.txtKumi.Height = 0.2!
        Me.txtKumi.Left = 1.735583!
        Me.txtKumi.Name = "txtKumi"
        Me.txtKumi.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtKumi.Text = "XX"
        Me.txtKumi.Top = 0.05!
        Me.txtKumi.Width = 0.1999999!
        '
        'txtSyanaiNo
        '
        Me.txtSyanaiNo.DataField = "COMPANY_NO"
        Me.txtSyanaiNo.Height = 0.2!
        Me.txtSyanaiNo.Left = 2.139083!
        Me.txtSyanaiNo.Name = "txtSyanaiNo"
        Me.txtSyanaiNo.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtSyanaiNo.Text = "XXXXXX"
        Me.txtSyanaiNo.Top = 0.05!
        Me.txtSyanaiNo.Width = 0.5333332!
        '
        'txtSijiNo
        '
        Me.txtSijiNo.DataField = "INDICATE_NO"
        Me.txtSijiNo.Height = 0.2!
        Me.txtSijiNo.Left = 2.854!
        Me.txtSijiNo.Name = "txtSijiNo"
        Me.txtSijiNo.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtSijiNo.Text = "XXXXX"
        Me.txtSijiNo.Top = 0.05!
        Me.txtSijiNo.Width = 0.4666665!
        '
        'txtZaiko
        '
        Me.txtZaiko.DataField = "INVENT_AMT"
        Me.txtZaiko.Height = 0.2!
        Me.txtZaiko.Left = 3.485584!
        Me.txtZaiko.Name = "txtZaiko"
        Me.txtZaiko.OutputFormat = resources.GetString("txtZaiko.OutputFormat")
        Me.txtZaiko.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om"
        Me.txtZaiko.Text = "#,###,###"
        Me.txtZaiko.Top = 0.05!
        Me.txtZaiko.Width = 0.8269167!
        '
        'linUnder
        '
        Me.linUnder.Height = 0!
        Me.linUnder.Left = 0.061!
        Me.linUnder.LineWeight = 1!
        Me.linUnder.Name = "linUnder"
        Me.linUnder.Top = 0.26!
        Me.linUnder.Width = 7.315001!
        Me.linUnder.X1 = 0.061!
        Me.linUnder.X2 = 7.376!
        Me.linUnder.Y1 = 0.26!
        Me.linUnder.Y2 = 0.26!
        '
        'Line2
        '
        Me.Line2.Height = 0.26!
        Me.Line2.Left = 0.06024987!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 3.427267E-07!
        Me.Line2.Width = 0!
        Me.Line2.X1 = 0.06024987!
        Me.Line2.X2 = 0.06024987!
        Me.Line2.Y1 = 3.427267E-07!
        Me.Line2.Y2 = 0.2600003!
        '
        'Line3
        '
        Me.Line3.Height = 0.26!
        Me.Line3.Left = 1.601917!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 3.427267E-07!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 1.601917!
        Me.Line3.X2 = 1.601917!
        Me.Line3.Y1 = 3.427267E-07!
        Me.Line3.Y2 = 0.2600003!
        '
        'Line4
        '
        Me.Line4.Height = 0.26!
        Me.Line4.Left = 2.0695!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 2.0695!
        Me.Line4.X2 = 2.0695!
        Me.Line4.Y1 = 0!
        Me.Line4.Y2 = 0.26!
        '
        'Line5
        '
        Me.Line5.Height = 0.26!
        Me.Line5.Left = 2.755!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 2.755!
        Me.Line5.X2 = 2.755!
        Me.Line5.Y1 = 0!
        Me.Line5.Y2 = 0.26!
        '
        'Line6
        '
        Me.Line6.Height = 0.26!
        Me.Line6.Left = 3.425!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 3.425!
        Me.Line6.X2 = 3.425!
        Me.Line6.Y1 = 0!
        Me.Line6.Y2 = 0.26!
        '
        'Line7
        '
        Me.Line7.Height = 0.26!
        Me.Line7.Left = 4.385248!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 3.427267E-07!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 4.385248!
        Me.Line7.X2 = 4.385248!
        Me.Line7.Y1 = 3.427267E-07!
        Me.Line7.Y2 = 0.2600003!
        '
        'Line8
        '
        Me.Line8.Height = 0.26!
        Me.Line8.Left = 7.375!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 7.375!
        Me.Line8.X2 = 7.375!
        Me.Line8.Y1 = 0!
        Me.Line8.Y2 = 0.26!
        '
        'txtSyusyu
        '
        Me.txtSyusyu.Height = 0.2!
        Me.txtSyusyu.Left = 4.4375!
        Me.txtSyusyu.MultiLine = false
        Me.txtSyusyu.Name = "txtSyusyu"
        Me.txtSyusyu.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; ddo-char-set: 128"
        Me.txtSyusyu.Text = "XXXXXXXXXXXX"
        Me.txtSyusyu.Top = 0.05!
        Me.txtSyusyu.Width = 1!
        '
        'Line9
        '
        Me.Line9.Height = 0.26!
        Me.Line9.Left = 5.5!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 5.5!
        Me.Line9.X2 = 5.5!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0.26!
        '
        'txtMemo
        '
        Me.txtMemo.Height = 0.2!
        Me.txtMemo.Left = 5.5625!
        Me.txtMemo.MultiLine = false
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; white-space: nowrap"
        Me.txtMemo.Text = "TextBox1"
        Me.txtMemo.Top = 0.05!
        Me.txtMemo.Width = 1.75!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=MEDPROC;User ID=MEDPROC;Data Source=MEDICAL;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.479167!
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
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBIKOU, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTBL_KB, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKumi, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyanaiNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSijiNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZaiko, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyusyu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private Const MAX_ROW As Integer = 38

    Private _nPage As Integer = 1
    Private _nRow As Integer = 1

    Private _sCatalog As String = ""

    Private _sTanaDate As String = ""

    Public WriteOnly Property TanaDate() As String
        Set(ByVal sValue As String)
            _sTanaDate = sValue
        End Set
    End Property

    Private Sub mdtna0702_PageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageStart
        _nRow = 1
    End Sub

    Private Sub mdtna0702_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblTanaDate.Text = _sTanaDate
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblPage.Text = _nPage.ToString("#").Trim.PadLeft(3, " ")
        _nPage += 1
    End Sub

    Private Sub mdtna0702_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        _nRow += 1
        If eArgs.EOF Then
            txtCatalog.Visible = False
            txtKumi.Visible = False
            txtSyanaiNo.Visible = False
            txtSijiNo.Visible = False
            txtZaiko.Visible = False
            txtSyusyu.Visible = False
            txtMemo.Visible = False
            If _nPage - 1 = 1 Then
                eArgs.EOF = MAX_ROW <= _nRow - 1
            Else
                eArgs.EOF = MAX_ROW <= _nRow
            End If
        End If
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If _sCatalog <> txtCatalog.Text Then
            txtCatalog.Visible = True
            _sCatalog = txtCatalog.Text
        Else
            txtCatalog.Visible = False
        End If

        Select Case txtTBL_KB.Text
            Case "K"
                txtSyusyu.Text = "工程票のみ"
                txtMemo.Text = ""
            Case "G"
                txtSyusyu.Text = "外注"
                txtMemo.Text = "外注名称：" + txtBIKOU.Text
            Case "H"
                txtSyusyu.Text = "ＨＴ"
                txtMemo.Text = "工順：" + txtBIKOU.Text
            Case "M"
                txtSyusyu.Text = "漏れ入力"
                txtMemo.Text = ""
            Case Else
                txtSyusyu.Text = ""
                txtMemo.Text = ""
        End Select

        If _nPage - 1 = 1 Then
            If _nRow = MAX_ROW Then
                linUnder.LineStyle = LineStyle.Solid
                _sCatalog = ""
            Else
                linUnder.LineStyle = LineStyle.Dash
            End If
        Else
            If _nRow = MAX_ROW - 1 Then
                linUnder.LineStyle = LineStyle.Solid
                _sCatalog = ""
            Else
                linUnder.LineStyle = LineStyle.Dash
            End If
        End If
    End Sub

End Class
