Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdtyk0203
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
    Private Picture As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private txtO_CATALOG_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOR_MARK As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtKubun1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKubun10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblSep10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private linSunpou As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtyk0203))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Picture = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.txtO_CATALOG_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOR_MARK = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtKubun1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKubun10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSep10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.linSunpou = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtO_CATALOG_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOR_MARK, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKubun10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSep10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Picture, Me.txtO_CATALOG_NO, Me.txtINDICATE_NO, Me.txtCOR_MARK, Me.Label7, Me.txtKubun1, Me.txtKubun2, Me.txtKubun3, Me.txtKubun4, Me.txtKubun5, Me.lblSep1, Me.lblSep2, Me.lblSep3, Me.lblSep4, Me.lblSep5, Me.txtSunpou1, Me.txtSunpou2, Me.txtSunpou3, Me.txtSunpou4, Me.txtSunpou5, Me.txtKubun6, Me.lblSep6, Me.txtSunpou6, Me.txtSunpou7, Me.lblSep7, Me.txtKubun7, Me.txtKubun8, Me.lblSep8, Me.txtSunpou8, Me.txtSunpou9, Me.lblSep9, Me.txtKubun9, Me.txtKubun10, Me.lblSep10, Me.txtSunpou10, Me.linSunpou})
        Me.Detail.Height = 11.00833!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Visible = false
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'Picture
        '
        Me.Picture.Height = 10.93333!
        Me.Picture.ImageData = Nothing
        Me.Picture.Left = 0.05!
        Me.Picture.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture.Name = "Picture"
        Me.Picture.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch
        Me.Picture.Top = 0.05!
        Me.Picture.Width = 7.466667!
        '
        'txtO_CATALOG_NO
        '
        Me.txtO_CATALOG_NO.DataField = "O_CATALOG_NO"
        Me.txtO_CATALOG_NO.Height = 0.2!
        Me.txtO_CATALOG_NO.Left = 1.3045!
        Me.txtO_CATALOG_NO.Name = "txtO_CATALOG_NO"
        Me.txtO_CATALOG_NO.Style = "background-color: White; font-family: ＭＳ ゴシック; font-size: 9.75pt; font-weight: bo" & _
            "ld; vertical-align: bottom; white-space: nowrap"
        Me.txtO_CATALOG_NO.Text = "元カタログ番号"
        Me.txtO_CATALOG_NO.Top = 0.333!
        Me.txtO_CATALOG_NO.Width = 1.266667!
        '
        'txtINDICATE_NO
        '
        Me.txtINDICATE_NO.DataField = "INDICATE_NO"
        Me.txtINDICATE_NO.Height = 0.2!
        Me.txtINDICATE_NO.Left = 2.9!
        Me.txtINDICATE_NO.Name = "txtINDICATE_NO"
        Me.txtINDICATE_NO.Style = "background-color: White; font-family: ＭＳ ゴシック; font-size: 9.75pt; font-weight: bo" & _
            "ld; text-align: center; vertical-align: middle"
        Me.txtINDICATE_NO.Text = "指示NO"
        Me.txtINDICATE_NO.Top = 0.7375!
        Me.txtINDICATE_NO.Width = 0.8!
        '
        'txtCOR_MARK
        '
        Me.txtCOR_MARK.DataField = "COR_MARK"
        Me.txtCOR_MARK.Height = 0.25!
        Me.txtCOR_MARK.Left = 6.75!
        Me.txtCOR_MARK.Name = "txtCOR_MARK"
        Me.txtCOR_MARK.Style = "background-color: White; font-family: ＭＳ ゴシック; font-size: 14.25pt; text-align: ce" & _
            "nter; vertical-align: bottom"
        Me.txtCOR_MARK.Text = "訂符"
        Me.txtCOR_MARK.Top = 0.6875!
        Me.txtCOR_MARK.Width = 0.5999999!
        '
        'Label7
        '
        Me.Label7.Height = 0.1999999!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.1!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.Label7.Text = "[09-146]"
        Me.Label7.Top = 10.7!
        Me.Label7.Width = 0.6666667!
        '
        'txtKubun1
        '
        Me.txtKubun1.DataField = "MEASURE_KB01"
        Me.txtKubun1.Height = 0.15!
        Me.txtKubun1.Left = 5.550001!
        Me.txtKubun1.Name = "txtKubun1"
        Me.txtKubun1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun1.Text = "XX"
        Me.txtKubun1.Top = 1.8!
        Me.txtKubun1.Width = 0.2000013!
        '
        'txtKubun2
        '
        Me.txtKubun2.DataField = "MEASURE_KB02"
        Me.txtKubun2.Height = 0.15!
        Me.txtKubun2.Left = 5.550001!
        Me.txtKubun2.Name = "txtKubun2"
        Me.txtKubun2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun2.Text = "XX"
        Me.txtKubun2.Top = 1.95!
        Me.txtKubun2.Width = 0.2000013!
        '
        'txtKubun3
        '
        Me.txtKubun3.DataField = "MEASURE_KB03"
        Me.txtKubun3.Height = 0.15!
        Me.txtKubun3.Left = 5.550001!
        Me.txtKubun3.Name = "txtKubun3"
        Me.txtKubun3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun3.Text = "XX"
        Me.txtKubun3.Top = 2.1!
        Me.txtKubun3.Width = 0.2000013!
        '
        'txtKubun4
        '
        Me.txtKubun4.DataField = "MEASURE_KB04"
        Me.txtKubun4.Height = 0.15!
        Me.txtKubun4.Left = 5.55!
        Me.txtKubun4.Name = "txtKubun4"
        Me.txtKubun4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun4.Text = "XX"
        Me.txtKubun4.Top = 2.25!
        Me.txtKubun4.Width = 0.2000013!
        '
        'txtKubun5
        '
        Me.txtKubun5.DataField = "MEASURE_KB05"
        Me.txtKubun5.Height = 0.15!
        Me.txtKubun5.Left = 5.55!
        Me.txtKubun5.Name = "txtKubun5"
        Me.txtKubun5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun5.Text = "XX"
        Me.txtKubun5.Top = 2.4!
        Me.txtKubun5.Width = 0.2000013!
        '
        'lblSep1
        '
        Me.lblSep1.Height = 0.15!
        Me.lblSep1.Left = 5.750003!
        Me.lblSep1.Name = "lblSep1"
        Me.lblSep1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep1.Text = "："
        Me.lblSep1.Top = 1.8!
        Me.lblSep1.Width = 0.1500001!
        '
        'lblSep2
        '
        Me.lblSep2.Height = 0.15!
        Me.lblSep2.Left = 5.750003!
        Me.lblSep2.Name = "lblSep2"
        Me.lblSep2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep2.Text = "："
        Me.lblSep2.Top = 1.95!
        Me.lblSep2.Width = 0.1500001!
        '
        'lblSep3
        '
        Me.lblSep3.Height = 0.15!
        Me.lblSep3.Left = 5.750003!
        Me.lblSep3.Name = "lblSep3"
        Me.lblSep3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep3.Text = "："
        Me.lblSep3.Top = 2.1!
        Me.lblSep3.Width = 0.1500001!
        '
        'lblSep4
        '
        Me.lblSep4.Height = 0.15!
        Me.lblSep4.Left = 5.750001!
        Me.lblSep4.Name = "lblSep4"
        Me.lblSep4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep4.Text = "："
        Me.lblSep4.Top = 2.25!
        Me.lblSep4.Width = 0.1500001!
        '
        'lblSep5
        '
        Me.lblSep5.Height = 0.15!
        Me.lblSep5.Left = 5.750001!
        Me.lblSep5.Name = "lblSep5"
        Me.lblSep5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep5.Text = "："
        Me.lblSep5.Top = 2.4!
        Me.lblSep5.Width = 0.1500001!
        '
        'txtSunpou1
        '
        Me.txtSunpou1.DataField = "MEASURE_01"
        Me.txtSunpou1.Height = 0.15!
        Me.txtSunpou1.Left = 5.900002!
        Me.txtSunpou1.Name = "txtSunpou1"
        Me.txtSunpou1.OutputFormat = resources.GetString("txtSunpou1.OutputFormat")
        Me.txtSunpou1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou1.Text = "999.99"
        Me.txtSunpou1.Top = 1.8!
        Me.txtSunpou1.Width = 0.4499999!
        '
        'txtSunpou2
        '
        Me.txtSunpou2.DataField = "MEASURE_02"
        Me.txtSunpou2.Height = 0.15!
        Me.txtSunpou2.Left = 5.900002!
        Me.txtSunpou2.Name = "txtSunpou2"
        Me.txtSunpou2.OutputFormat = resources.GetString("txtSunpou2.OutputFormat")
        Me.txtSunpou2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou2.Text = "999.99"
        Me.txtSunpou2.Top = 1.95!
        Me.txtSunpou2.Width = 0.4499999!
        '
        'txtSunpou3
        '
        Me.txtSunpou3.DataField = "MEASURE_03"
        Me.txtSunpou3.Height = 0.15!
        Me.txtSunpou3.Left = 5.900002!
        Me.txtSunpou3.Name = "txtSunpou3"
        Me.txtSunpou3.OutputFormat = resources.GetString("txtSunpou3.OutputFormat")
        Me.txtSunpou3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou3.Text = "999.99"
        Me.txtSunpou3.Top = 2.1!
        Me.txtSunpou3.Width = 0.4499999!
        '
        'txtSunpou4
        '
        Me.txtSunpou4.DataField = "MEASURE_04"
        Me.txtSunpou4.Height = 0.15!
        Me.txtSunpou4.Left = 5.900002!
        Me.txtSunpou4.Name = "txtSunpou4"
        Me.txtSunpou4.OutputFormat = resources.GetString("txtSunpou4.OutputFormat")
        Me.txtSunpou4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou4.Text = "999.99"
        Me.txtSunpou4.Top = 2.25!
        Me.txtSunpou4.Width = 0.4499999!
        '
        'txtSunpou5
        '
        Me.txtSunpou5.DataField = "MEASURE_05"
        Me.txtSunpou5.Height = 0.15!
        Me.txtSunpou5.Left = 5.900002!
        Me.txtSunpou5.Name = "txtSunpou5"
        Me.txtSunpou5.OutputFormat = resources.GetString("txtSunpou5.OutputFormat")
        Me.txtSunpou5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou5.Text = "999.99"
        Me.txtSunpou5.Top = 2.4!
        Me.txtSunpou5.Width = 0.4499999!
        '
        'txtKubun6
        '
        Me.txtKubun6.DataField = "MEASURE_KB06"
        Me.txtKubun6.Height = 0.15!
        Me.txtKubun6.Left = 6.550001!
        Me.txtKubun6.Name = "txtKubun6"
        Me.txtKubun6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun6.Text = "XX"
        Me.txtKubun6.Top = 1.8!
        Me.txtKubun6.Width = 0.2000013!
        '
        'lblSep6
        '
        Me.lblSep6.Height = 0.15!
        Me.lblSep6.Left = 6.750003!
        Me.lblSep6.Name = "lblSep6"
        Me.lblSep6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep6.Text = "："
        Me.lblSep6.Top = 1.8!
        Me.lblSep6.Width = 0.1500001!
        '
        'txtSunpou6
        '
        Me.txtSunpou6.DataField = "MEASURE_06"
        Me.txtSunpou6.Height = 0.15!
        Me.txtSunpou6.Left = 6.900002!
        Me.txtSunpou6.Name = "txtSunpou6"
        Me.txtSunpou6.OutputFormat = resources.GetString("txtSunpou6.OutputFormat")
        Me.txtSunpou6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou6.Text = "999.99"
        Me.txtSunpou6.Top = 1.8!
        Me.txtSunpou6.Width = 0.4499999!
        '
        'txtSunpou7
        '
        Me.txtSunpou7.DataField = "MEASURE_07"
        Me.txtSunpou7.Height = 0.15!
        Me.txtSunpou7.Left = 6.900002!
        Me.txtSunpou7.Name = "txtSunpou7"
        Me.txtSunpou7.OutputFormat = resources.GetString("txtSunpou7.OutputFormat")
        Me.txtSunpou7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou7.Text = "999.99"
        Me.txtSunpou7.Top = 1.95!
        Me.txtSunpou7.Width = 0.4499999!
        '
        'lblSep7
        '
        Me.lblSep7.Height = 0.15!
        Me.lblSep7.Left = 6.750003!
        Me.lblSep7.Name = "lblSep7"
        Me.lblSep7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep7.Text = "："
        Me.lblSep7.Top = 1.95!
        Me.lblSep7.Width = 0.1500001!
        '
        'txtKubun7
        '
        Me.txtKubun7.DataField = "MEASURE_KB07"
        Me.txtKubun7.Height = 0.15!
        Me.txtKubun7.Left = 6.550001!
        Me.txtKubun7.Name = "txtKubun7"
        Me.txtKubun7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun7.Text = "XX"
        Me.txtKubun7.Top = 1.95!
        Me.txtKubun7.Width = 0.2000013!
        '
        'txtKubun8
        '
        Me.txtKubun8.DataField = "MEASURE_KB08"
        Me.txtKubun8.Height = 0.15!
        Me.txtKubun8.Left = 6.550001!
        Me.txtKubun8.Name = "txtKubun8"
        Me.txtKubun8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun8.Text = "XX"
        Me.txtKubun8.Top = 2.1!
        Me.txtKubun8.Width = 0.2000013!
        '
        'lblSep8
        '
        Me.lblSep8.Height = 0.15!
        Me.lblSep8.Left = 6.750003!
        Me.lblSep8.Name = "lblSep8"
        Me.lblSep8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep8.Text = "："
        Me.lblSep8.Top = 2.1!
        Me.lblSep8.Width = 0.1500001!
        '
        'txtSunpou8
        '
        Me.txtSunpou8.DataField = "MEASURE_08"
        Me.txtSunpou8.Height = 0.15!
        Me.txtSunpou8.Left = 6.900002!
        Me.txtSunpou8.Name = "txtSunpou8"
        Me.txtSunpou8.OutputFormat = resources.GetString("txtSunpou8.OutputFormat")
        Me.txtSunpou8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou8.Text = "999.99"
        Me.txtSunpou8.Top = 2.1!
        Me.txtSunpou8.Width = 0.4499999!
        '
        'txtSunpou9
        '
        Me.txtSunpou9.DataField = "MEASURE_09"
        Me.txtSunpou9.Height = 0.15!
        Me.txtSunpou9.Left = 6.900002!
        Me.txtSunpou9.Name = "txtSunpou9"
        Me.txtSunpou9.OutputFormat = resources.GetString("txtSunpou9.OutputFormat")
        Me.txtSunpou9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou9.Text = "999.99"
        Me.txtSunpou9.Top = 2.25!
        Me.txtSunpou9.Width = 0.4499999!
        '
        'lblSep9
        '
        Me.lblSep9.Height = 0.15!
        Me.lblSep9.Left = 6.75!
        Me.lblSep9.Name = "lblSep9"
        Me.lblSep9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep9.Text = "："
        Me.lblSep9.Top = 2.25!
        Me.lblSep9.Width = 0.1500001!
        '
        'txtKubun9
        '
        Me.txtKubun9.DataField = "MEASURE_KB09"
        Me.txtKubun9.Height = 0.15!
        Me.txtKubun9.Left = 6.55!
        Me.txtKubun9.Name = "txtKubun9"
        Me.txtKubun9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun9.Text = "XX"
        Me.txtKubun9.Top = 2.25!
        Me.txtKubun9.Width = 0.2000013!
        '
        'txtKubun10
        '
        Me.txtKubun10.DataField = "MEASURE_KB10"
        Me.txtKubun10.Height = 0.15!
        Me.txtKubun10.Left = 6.55!
        Me.txtKubun10.Name = "txtKubun10"
        Me.txtKubun10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.txtKubun10.Text = "XX"
        Me.txtKubun10.Top = 2.4!
        Me.txtKubun10.Width = 0.2000013!
        '
        'lblSep10
        '
        Me.lblSep10.Height = 0.15!
        Me.lblSep10.Left = 6.75!
        Me.lblSep10.Name = "lblSep10"
        Me.lblSep10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.lblSep10.Text = "："
        Me.lblSep10.Top = 2.4!
        Me.lblSep10.Width = 0.1500001!
        '
        'txtSunpou10
        '
        Me.txtSunpou10.DataField = "MEASURE_10"
        Me.txtSunpou10.Height = 0.15!
        Me.txtSunpou10.Left = 6.900002!
        Me.txtSunpou10.Name = "txtSunpou10"
        Me.txtSunpou10.OutputFormat = resources.GetString("txtSunpou10.OutputFormat")
        Me.txtSunpou10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.txtSunpou10.Text = "999.99"
        Me.txtSunpou10.Top = 2.4!
        Me.txtSunpou10.Width = 0.4499999!
        '
        'linSunpou
        '
        Me.linSunpou.Height = 0.75!
        Me.linSunpou.Left = 6.45!
        Me.linSunpou.LineWeight = 1!
        Me.linSunpou.Name = "linSunpou"
        Me.linSunpou.Top = 1.8!
        Me.linSunpou.Width = 0!
        Me.linSunpou.X1 = 6.45!
        Me.linSunpou.X2 = 6.45!
        Me.linSunpou.Y1 = 1.8!
        Me.linSunpou.Y2 = 2.55!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.4!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.573!
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
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtO_CATALOG_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOR_MARK, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKubun10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSep10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private _sImageFile As String = "D:\Users\メイラメディカル\Report\K88880101010001.tif"

    Private _nShowSunpou As Boolean = False

    Public WriteOnly Property ImageFile() As String
        Set(ByVal sValue As String)
            _sImageFile = sValue
        End Set
    End Property

    Public WriteOnly Property ShowSunpou() As Boolean
        Set(ByVal nValue As Boolean)
            _nShowSunpou = nValue
        End Set
    End Property

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtKubun1.Visible = _nShowSunpou
        txtKubun2.Visible = _nShowSunpou
        txtKubun3.Visible = _nShowSunpou
        txtKubun4.Visible = _nShowSunpou
        txtKubun5.Visible = _nShowSunpou
        txtKubun6.Visible = _nShowSunpou
        txtKubun7.Visible = _nShowSunpou
        txtKubun8.Visible = _nShowSunpou
        txtKubun9.Visible = _nShowSunpou
        txtKubun10.Visible = _nShowSunpou
        lblSep1.Visible = _nShowSunpou And Not txtKubun1.Text.Trim.Equals("")
        lblSep2.Visible = _nShowSunpou And Not txtKubun2.Text.Trim.Equals("")
        lblSep3.Visible = _nShowSunpou And Not txtKubun3.Text.Trim.Equals("")
        lblSep4.Visible = _nShowSunpou And Not txtKubun4.Text.Trim.Equals("")
        lblSep5.Visible = _nShowSunpou And Not txtKubun5.Text.Trim.Equals("")
        lblSep6.Visible = _nShowSunpou And Not txtKubun6.Text.Trim.Equals("")
        lblSep7.Visible = _nShowSunpou And Not txtKubun7.Text.Trim.Equals("")
        lblSep8.Visible = _nShowSunpou And Not txtKubun8.Text.Trim.Equals("")
        lblSep9.Visible = _nShowSunpou And Not txtKubun9.Text.Trim.Equals("")
        lblSep10.Visible = _nShowSunpou And Not txtKubun10.Text.Trim.Equals("")
        txtSunpou1.Visible = _nShowSunpou And Not txtKubun1.Text.Trim.Equals("")
        txtSunpou2.Visible = _nShowSunpou And Not txtKubun2.Text.Trim.Equals("")
        txtSunpou3.Visible = _nShowSunpou And Not txtKubun3.Text.Trim.Equals("")
        txtSunpou4.Visible = _nShowSunpou And Not txtKubun4.Text.Trim.Equals("")
        txtSunpou5.Visible = _nShowSunpou And Not txtKubun5.Text.Trim.Equals("")
        txtSunpou6.Visible = _nShowSunpou And Not txtKubun6.Text.Trim.Equals("")
        txtSunpou7.Visible = _nShowSunpou And Not txtKubun7.Text.Trim.Equals("")
        txtSunpou8.Visible = _nShowSunpou And Not txtKubun8.Text.Trim.Equals("")
        txtSunpou9.Visible = _nShowSunpou And Not txtKubun9.Text.Trim.Equals("")
        txtSunpou10.Visible = _nShowSunpou And Not txtKubun10.Text.Trim.Equals("")
        linSunpou.Visible = _nShowSunpou And _
                            (Not txtKubun6.Text.Trim.Equals("") Or _
                             Not txtKubun7.Text.Trim.Equals("") Or _
                             Not txtKubun8.Text.Trim.Equals("") Or _
                             Not txtKubun9.Text.Trim.Equals("") Or _
                             Not txtKubun10.Text.Trim.Equals(""))
        Picture.Image = System.Drawing.Image.FromFile(_sImageFile)
    End Sub


End Class 
