Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports System
Imports Microsoft.VisualBasic

Public Class mdtna0201
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
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTanaDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtTanni As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTanaban As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZairyoCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtRenban As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtLotNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtFukuTanaban As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZaikoJuryo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private linUnder As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtna0201))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTanaDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTanni = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTanaban = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZairyoCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRenban = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtLotNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFukuTanaban = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZaikoJuryo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.linUnder = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTanni, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTanaban, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyoCode, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRenban, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtLotNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtFukuTanaban, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZaikoJuryo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtTanni, Me.txtTanaban, Me.txtZairyoCode, Me.txtRenban, Me.txtLotNo, Me.txtFukuTanaban, Me.txtZaikoJuryo, Me.linUnder, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10})
        Me.Detail.Height = 0.2597222!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label7, Me.Label8, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.Label, Me.Label11, Me.lblDate, Me.Label12, Me.lblPage, Me.Line1, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Label9, Me.lblTanaDate})
        Me.PageHeader.Height = 1.2!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'Label7
        '
        Me.Label7.Height = 0.2666668!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.173!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label7.Text = "単位"
        Me.Label7.Top = 0.933!
        Me.Label7.Width = 0.625!
        '
        'Label8
        '
        Me.Label8.Height = 0.267!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.931!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label8.Text = "実棚_在庫量"
        Me.Label8.Top = 0.933!
        Me.Label8.Width = 1.246!
        '
        'Label6
        '
        Me.Label6.Height = 0.2666668!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.798!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label6.Text = "在庫量"
        Me.Label6.Top = 0.933!
        Me.Label6.Width = 1.133333!
        '
        'Label5
        '
        Me.Label5.Height = 0.2666668!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.572917!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label5.Text = "副棚番"
        Me.Label5.Top = 0.933!
        Me.Label5.Width = 0.6000001!
        '
        'Label4
        '
        Me.Label4.Height = 0.2666668!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.90625!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label4.Text = "ﾛｯﾄNO"
        Me.Label4.Top = 0.933!
        Me.Label4.Width = 0.6666666!
        '
        'Label3
        '
        Me.Label3.Height = 0.2666668!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.30625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label3.Text = "連番"
        Me.Label3.Top = 0.933!
        Me.Label3.Width = 0.6000001!
        '
        'Label2
        '
        Me.Label2.Height = 0.2666668!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.90625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label2.Text = "材料コード"
        Me.Label2.Top = 0.933!
        Me.Label2.Width = 1.4!
        '
        'Label1
        '
        Me.Label1.Height = 0.2666667!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.3062499!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label1.Text = "棚番"
        Me.Label1.Top = 0.933!
        Me.Label1.Width = 0.6000001!
        '
        'Label
        '
        Me.Label.Height = 0.2666667!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.06666667!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; text-align: center; vertical-align: bot" & _
            "tom"
        Me.Label.Text = "※※※　棚卸表（主材料）　※※※"
        Me.Label.Top = 0.06666667!
        Me.Label.Width = 7.333333!
        '
        'Label11
        '
        Me.Label11.Height = 0.2000001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 5.933001!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label11.Text = "作成日："
        Me.Label11.Top = 0.133!
        Me.Label11.Width = 0.666666!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.6!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.lblDate.Text = "YYYY/MM/DD"
        Me.lblDate.Top = 0.133!
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
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.3062499!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.933!
        Me.Line1.Width = 6.870833!
        Me.Line1.X1 = 0.3062499!
        Me.Line1.X2 = 7.177083!
        Me.Line1.Y1 = 0.933!
        Me.Line1.Y2 = 0.933!
        '
        'Line12
        '
        Me.Line12.Height = 0.2666667!
        Me.Line12.Left = 0.3062499!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.933!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 0.3062499!
        Me.Line12.X2 = 0.3062499!
        Me.Line12.Y1 = 0.933!
        Me.Line12.Y2 = 1.199667!
        '
        'Line13
        '
        Me.Line13.Height = 0.2666667!
        Me.Line13.Left = 0.90625!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.933!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 0.90625!
        Me.Line13.X2 = 0.90625!
        Me.Line13.Y1 = 0.933!
        Me.Line13.Y2 = 1.199667!
        '
        'Line14
        '
        Me.Line14.Height = 0.2666667!
        Me.Line14.Left = 2.306251!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.933!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 2.306251!
        Me.Line14.X2 = 2.306251!
        Me.Line14.Y1 = 0.933!
        Me.Line14.Y2 = 1.199667!
        '
        'Line15
        '
        Me.Line15.Height = 0.2666667!
        Me.Line15.Left = 2.90625!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.933!
        Me.Line15.Width = 0!
        Me.Line15.X1 = 2.90625!
        Me.Line15.X2 = 2.90625!
        Me.Line15.Y1 = 0.933!
        Me.Line15.Y2 = 1.199667!
        '
        'Line16
        '
        Me.Line16.Height = 0.2666667!
        Me.Line16.Left = 3.572916!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.933!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 3.572916!
        Me.Line16.X2 = 3.572916!
        Me.Line16.Y1 = 0.933!
        Me.Line16.Y2 = 1.199667!
        '
        'Line17
        '
        Me.Line17.Height = 0.2666667!
        Me.Line17.Left = 4.172916!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.933!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 4.172916!
        Me.Line17.X2 = 4.172916!
        Me.Line17.Y1 = 0.933!
        Me.Line17.Y2 = 1.199667!
        '
        'Line18
        '
        Me.Line18.Height = 0.2666667!
        Me.Line18.Left = 4.798!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.933!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 4.798!
        Me.Line18.X2 = 4.798!
        Me.Line18.Y1 = 0.933!
        Me.Line18.Y2 = 1.199667!
        '
        'Line19
        '
        Me.Line19.Height = 0.2666667!
        Me.Line19.Left = 5.931!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.933!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 5.931!
        Me.Line19.X2 = 5.931!
        Me.Line19.Y1 = 0.933!
        Me.Line19.Y2 = 1.199667!
        '
        'Line20
        '
        Me.Line20.Height = 0.2666667!
        Me.Line20.Left = 7.177!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.933!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 7.177!
        Me.Line20.X2 = 7.177!
        Me.Line20.Y1 = 0.933!
        Me.Line20.Y2 = 1.199667!
        '
        'Line21
        '
        Me.Line21.Height = 0!
        Me.Line21.Left = 0.306!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 1.2!
        Me.Line21.Width = 6.871!
        Me.Line21.X1 = 0.306!
        Me.Line21.X2 = 7.177!
        Me.Line21.Y1 = 1.2!
        Me.Line21.Y2 = 1.2!
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
        'txtTanni
        '
        Me.txtTanni.DataField = "ITEM_NM"
        Me.txtTanni.Height = 0.2!
        Me.txtTanni.Left = 4.252083!
        Me.txtTanni.Name = "txtTanni"
        Me.txtTanni.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: center; vertical-align: top" & _
            ""
        Me.txtTanni.Text = "XX"
        Me.txtTanni.Top = 0.06299999!
        Me.txtTanni.Width = 0.4666668!
        '
        'txtTanaban
        '
        Me.txtTanaban.DataField = "SHELF_NO"
        Me.txtTanaban.Height = 0.2!
        Me.txtTanaban.Left = 0.3690833!
        Me.txtTanaban.Name = "txtTanaban"
        Me.txtTanaban.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtTanaban.Text = "XXXXX"
        Me.txtTanaban.Top = 0.06299999!
        Me.txtTanaban.Width = 0.4666668!
        '
        'txtZairyoCode
        '
        Me.txtZairyoCode.DataField = "MATL_CD"
        Me.txtZairyoCode.Height = 0.2!
        Me.txtZairyoCode.Left = 0.9690833!
        Me.txtZairyoCode.Name = "txtZairyoCode"
        Me.txtZairyoCode.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtZairyoCode.Text = "XXXXXXXXXXXXXXX"
        Me.txtZairyoCode.Top = 0.06299999!
        Me.txtZairyoCode.Width = 1.266667!
        '
        'txtRenban
        '
        Me.txtRenban.DataField = "REN_NO"
        Me.txtRenban.Height = 0.2!
        Me.txtRenban.Left = 2.369083!
        Me.txtRenban.Name = "txtRenban"
        Me.txtRenban.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtRenban.Text = "XXXXX"
        Me.txtRenban.Top = 0.06299999!
        Me.txtRenban.Width = 0.4666668!
        '
        'txtLotNo
        '
        Me.txtLotNo.DataField = "LOT_NO"
        Me.txtLotNo.Height = 0.2!
        Me.txtLotNo.Left = 2.969083!
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtLotNo.Text = "XXXXXX"
        Me.txtLotNo.Top = 0.06299999!
        Me.txtLotNo.Width = 0.5333332!
        '
        'txtFukuTanaban
        '
        Me.txtFukuTanaban.DataField = "S_SHELF_NO"
        Me.txtFukuTanaban.Height = 0.2!
        Me.txtFukuTanaban.Left = 3.636083!
        Me.txtFukuTanaban.Name = "txtFukuTanaban"
        Me.txtFukuTanaban.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtFukuTanaban.Text = "XXXXX"
        Me.txtFukuTanaban.Top = 0.06299999!
        Me.txtFukuTanaban.Width = 0.4666668!
        '
        'txtZaikoJuryo
        '
        Me.txtZaikoJuryo.DataField = "STOCK_WAT"
        Me.txtZaikoJuryo.Height = 0.2!
        Me.txtZaikoJuryo.Left = 4.875!
        Me.txtZaikoJuryo.Name = "txtZaikoJuryo"
        Me.txtZaikoJuryo.OutputFormat = resources.GetString("txtZaikoJuryo.OutputFormat")
        Me.txtZaikoJuryo.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om"
        Me.txtZaikoJuryo.Text = "Z,ZZZ,ZZZ.ZZ"
        Me.txtZaikoJuryo.Top = 0.0625!
        Me.txtZaikoJuryo.Width = 1!
        '
        'linUnder
        '
        Me.linUnder.Height = 0!
        Me.linUnder.Left = 0.306!
        Me.linUnder.LineWeight = 1!
        Me.linUnder.Name = "linUnder"
        Me.linUnder.Top = 0.265!
        Me.linUnder.Width = 6.871!
        Me.linUnder.X1 = 0.306!
        Me.linUnder.X2 = 7.177!
        Me.linUnder.Y1 = 0.265!
        Me.linUnder.Y2 = 0.265!
        '
        'Line2
        '
        Me.Line2.Height = 0.2666667!
        Me.Line2.Left = 0.906!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0!
        Me.Line2.Width = 0!
        Me.Line2.X1 = 0.906!
        Me.Line2.X2 = 0.906!
        Me.Line2.Y1 = 0!
        Me.Line2.Y2 = 0.2666667!
        '
        'Line3
        '
        Me.Line3.Height = 0.2666667!
        Me.Line3.Left = 0.306!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 0.306!
        Me.Line3.X2 = 0.306!
        Me.Line3.Y1 = 0!
        Me.Line3.Y2 = 0.2666667!
        '
        'Line4
        '
        Me.Line4.Height = 0.2666667!
        Me.Line4.Left = 2.306!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 2.306!
        Me.Line4.X2 = 2.306!
        Me.Line4.Y1 = 0!
        Me.Line4.Y2 = 0.2666667!
        '
        'Line5
        '
        Me.Line5.Height = 0.2666667!
        Me.Line5.Left = 2.906!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 2.906!
        Me.Line5.X2 = 2.906!
        Me.Line5.Y1 = 0!
        Me.Line5.Y2 = 0.2666667!
        '
        'Line6
        '
        Me.Line6.Height = 0.2666667!
        Me.Line6.Left = 3.573!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 3.573!
        Me.Line6.X2 = 3.573!
        Me.Line6.Y1 = 0!
        Me.Line6.Y2 = 0.2666667!
        '
        'Line7
        '
        Me.Line7.Height = 0.2666667!
        Me.Line7.Left = 4.173!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 4.173!
        Me.Line7.X2 = 4.173!
        Me.Line7.Y1 = 0!
        Me.Line7.Y2 = 0.2666667!
        '
        'Line8
        '
        Me.Line8.Height = 0.2666667!
        Me.Line8.Left = 4.798!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 4.798!
        Me.Line8.X2 = 4.798!
        Me.Line8.Y1 = 0!
        Me.Line8.Y2 = 0.2666667!
        '
        'Line9
        '
        Me.Line9.Height = 0.2666667!
        Me.Line9.Left = 5.931!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 5.931!
        Me.Line9.X2 = 5.931!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0.2666667!
        '
        'Line10
        '
        Me.Line10.Height = 0.2666667!
        Me.Line10.Left = 7.177!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 7.177!
        Me.Line10.X2 = 7.177!
        Me.Line10.Y1 = 0!
        Me.Line10.Y2 = 0.2666667!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=mdctest;User ID=mdctest;Data Source=medical;Persist S" & _
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
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTanni, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTanaban, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyoCode, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRenban, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtLotNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtFukuTanaban, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZaikoJuryo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private Const MAX_ROW As Integer = 37

    Private _nPage As Integer = 1
    Private _nRow As Integer = 1

    Private _sTanaban As String = ""

    Private _sTanaDate As String = ""

    Public WriteOnly Property TanaDate() As String
        Set(ByVal sValue As String)
            _sTanaDate = sValue
        End Set
    End Property

    Private Sub mdtna0201_PageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageStart
        '_sTanaban = "" 
        _nRow = 1
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblTanaDate.Text = _sTanaDate
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblPage.Text = _nPage.ToString("#").Trim.PadLeft(3, " ")
        _nPage += 1
    End Sub

    Private Sub mdtna0201_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        _nRow += 1
        If eArgs.EOF Then
            txtTanaban.Visible = False
            txtZairyoCode.Visible = False
            txtRenban.Visible = False
            txtLotNo.Visible = False
            txtFukuTanaban.Visible = False
            txtTanni.Visible = False
            txtZaikoJuryo.Visible = False
            eArgs.EOF = MAX_ROW <= _nRow
        End If
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If _sTanaban <> txtTanaban.Text Then
            txtTanaban.Visible = True
            _sTanaban = txtTanaban.Text
        Else
            txtTanaban.Visible = False
        End If
        If _nPage - 1 = 1 Then
            If _nRow = MAX_ROW Then
                linUnder.LineStyle = LineStyle.Solid
                _sTanaban = ""
            Else
                linUnder.LineStyle = LineStyle.Dash
            End If
        Else
            If _nRow = MAX_ROW - 1 Then
                linUnder.LineStyle = LineStyle.Solid
                _sTanaban = ""
            Else
                linUnder.LineStyle = LineStyle.Dash
            End If
        End If
    End Sub

    Private Function GetDouble(ByVal oValue As Object) As Double
        If IsDBNull(oValue) Then Return 0
        Return CType(oValue, Double)
    End Function

End Class
