Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System

Public Class mdtyk0205
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
    Public ds As GrapeCity.ActiveReports.Data.SqlDBDataSource
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCatalog As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim SqlDBDataSource1 As GrapeCity.ActiveReports.Data.SqlDBDataSource = New GrapeCity.ActiveReports.Data.SqlDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtyk0205))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCatalog = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.Line1, Me.Line5, Me.Line6, Me.TextBox2, Me.TextBox3, Me.Line9, Me.Line10, Me.TextBox4, Me.TextBox5, Me.Line12, Me.Line14})
        Me.Detail.Height = 0.2076389!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label, Me.txtCatalog, Me.Label1, Me.lblDate, Me.lblPage, Me.Label2})
        Me.PageHeader.Height = 0.8006945!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox, Me.Label3, Me.Line, Me.Line2, Me.Line3, Me.Line4, Me.Label4, Me.Label5, Me.Line7, Me.Line8, Me.Label6, Me.Label7, Me.Line11, Me.Line13})
        Me.GroupHeader1.DataField = "MACINING_NM"
        Me.GroupHeader1.Height = 0.5506945!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.15625!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label
        '
        Me.Label.Height = 0.25!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.05!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: bottom"
        Me.Label.Text = "プログラム管理表"
        Me.Label.Top = 0.05!
        Me.Label.Width = 7.5!
        '
        'txtCatalog
        '
        Me.txtCatalog.DataField = "CATALOG_NO"
        Me.txtCatalog.Height = 0.2!
        Me.txtCatalog.Left = 1.25!
        Me.txtCatalog.Name = "txtCatalog"
        Me.txtCatalog.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom; white-space: no" & _
            "wrap"
        Me.txtCatalog.Text = "XXXXXXXXXXXXXXXXX"
        Me.txtCatalog.Top = 0.45!
        Me.txtCatalog.Width = 1.4!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.1500001!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom; white-space: no" & _
            "wrap"
        Me.Label1.Text = "カタログ番号："
        Me.Label1.Top = 0.45!
        Me.Label1.Width = 1.1!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.75!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.lblDate.Text = "yyyy/mm/dd"
        Me.lblDate.Top = 0.1!
        Me.lblDate.Width = 0.75!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 7!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.lblPage.Text = "P.999"
        Me.lblPage.Top = 0.35!
        Me.lblPage.Width = 0.5!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 6.149999!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.Label2.Text = "発行日："
        Me.Label2.Top = 0.1!
        Me.Label2.Width = 0.6000003!
        '
        'TextBox
        '
        Me.TextBox.DataField = "MACINING_NM"
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 0.15!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom; white-space: no" & _
            "wrap"
        Me.TextBox.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.TextBox.Top = 0.05!
        Me.TextBox.Width = 3.25!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.2!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label3.Text = "工程名称"
        Me.Label3.Top = 0.35!
        Me.Label3.Width = 2.15!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.1500002!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.35!
        Me.Line.Width = 7.35!
        Me.Line.X1 = 0.1500002!
        Me.Line.X2 = 7.5!
        Me.Line.Y1 = 0.35!
        Me.Line.Y2 = 0.35!
        '
        'Line2
        '
        Me.Line2.Height = 0.2!
        Me.Line2.Left = 0.1500001!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.3499999!
        Me.Line2.Width = 0!
        Me.Line2.X1 = 0.1500001!
        Me.Line2.X2 = 0.1500001!
        Me.Line2.Y1 = 0.3499999!
        Me.Line2.Y2 = 0.5499999!
        '
        'Line3
        '
        Me.Line3.Height = 0!
        Me.Line3.Left = 0.15!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.5500001!
        Me.Line3.Width = 7.35!
        Me.Line3.X1 = 0.15!
        Me.Line3.X2 = 7.5!
        Me.Line3.Y1 = 0.5500001!
        Me.Line3.Y2 = 0.5500001!
        '
        'Line4
        '
        Me.Line4.Height = 0.1999999!
        Me.Line4.Left = 2.399999!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.35!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 2.399999!
        Me.Line4.X2 = 2.399999!
        Me.Line4.Y1 = 0.35!
        Me.Line4.Y2 = 0.5499999!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.449999!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label4.Text = "プログラムNO"
        Me.Label4.Top = 0.35!
        Me.Label4.Width = 0.9000007!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.449998!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label5.Text = "プログラム名"
        Me.Label5.Top = 0.35!
        Me.Label5.Width = 2.100001!
        '
        'Line7
        '
        Me.Line7.Height = 0.1999999!
        Me.Line7.Left = 3.399998!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.35!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 3.399998!
        Me.Line7.X2 = 3.399998!
        Me.Line7.Y1 = 0.35!
        Me.Line7.Y2 = 0.5499999!
        '
        'Line8
        '
        Me.Line8.Height = 0.1999999!
        Me.Line8.Left = 5.600003!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.35!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 5.600003!
        Me.Line8.X2 = 5.600003!
        Me.Line8.Y1 = 0.35!
        Me.Line8.Y2 = 0.5499999!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 5.650003!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label6.Text = "最新Ver."
        Me.Label6.Top = 0.35!
        Me.Label6.Width = 0.7999993!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.550003!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label7.Text = "更新日"
        Me.Label7.Top = 0.35!
        Me.Label7.Width = 0.9!
        '
        'Line11
        '
        Me.Line11.Height = 0.1999999!
        Me.Line11.Left = 7.500007!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.35!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 7.500007!
        Me.Line11.X2 = 7.500007!
        Me.Line11.Y1 = 0.35!
        Me.Line11.Y2 = 0.5499999!
        '
        'Line13
        '
        Me.Line13.Height = 0.1999999!
        Me.Line13.Left = 6.500007!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.35!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 6.500007!
        Me.Line13.X2 = 6.500007!
        Me.Line13.Y1 = 0.35!
        Me.Line13.Y2 = 0.5499999!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "PROC_NM"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 0.2104167!
        Me.TextBox1.MultiLine = false
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom; white-space: now" & _
            "rap"
        Me.TextBox1.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 2.139583!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.15!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.2!
        Me.Line1.Width = 7.35!
        Me.Line1.X1 = 0.15!
        Me.Line1.X2 = 7.5!
        Me.Line1.Y1 = 0.2!
        Me.Line1.Y2 = 0.2!
        '
        'Line5
        '
        Me.Line5.Height = 0.1999999!
        Me.Line5.Left = 0.15!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 0.15!
        Me.Line5.X2 = 0.15!
        Me.Line5.Y1 = 0!
        Me.Line5.Y2 = 0.1999999!
        '
        'Line6
        '
        Me.Line6.Height = 0.1999999!
        Me.Line6.Left = 2.399999!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 2.399999!
        Me.Line6.X2 = 2.399999!
        Me.Line6.Y1 = 0!
        Me.Line6.Y2 = 0.1999999!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "PG_NO"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 2.45!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox2.Text = "XXXX"
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 0.9!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "PG_NM"
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 3.449998!
        Me.TextBox3.MultiLine = false
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom; white-space: now" & _
            "rap"
        Me.TextBox3.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 2.100001!
        '
        'Line9
        '
        Me.Line9.Height = 0.1999999!
        Me.Line9.Left = 3.399998!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 3.399998!
        Me.Line9.X2 = 3.399998!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0.1999999!
        '
        'Line10
        '
        Me.Line10.Height = 0.1999999!
        Me.Line10.Left = 5.600003!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 5.600003!
        Me.Line10.X2 = 5.600003!
        Me.Line10.Y1 = 0!
        Me.Line10.Y2 = 0.1999999!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "L_VER"
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 5.650003!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox4.Text = "XXXXXXXXXX"
        Me.TextBox4.Top = 0!
        Me.TextBox4.Width = 0.7999993!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "UPD_DT"
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 6.550003!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox5.Text = "yyyy/mm/dd"
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 0.9!
        '
        'Line12
        '
        Me.Line12.Height = 0.1999999!
        Me.Line12.Left = 7.500007!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 7.500007!
        Me.Line12.X2 = 7.500007!
        Me.Line12.Y1 = 0!
        Me.Line12.Y2 = 0.1999999!
        '
        'Line14
        '
        Me.Line14.Height = 0.1999999!
        Me.Line14.Left = 6.500007!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 6.500007!
        Me.Line14.X2 = 6.500007!
        Me.Line14.Y1 = 0!
        Me.Line14.Y2 = 0.1999999!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        SqlDBDataSource1.ConnectionString = "data source=C-LINE_SYS_DIV3;initial catalog=MEDICAL;password=password;persist sec" & _
            "urity info=True;user id=sa"
        SqlDBDataSource1.SQL = "SELECT * FROM PG_MST WHERE COMPANY_NO = '888880' ORDER BY MACINING_NM,PROC_ORD"
        Me.DataSource = SqlDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.4!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.573!
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
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private _nPage As Integer = 1

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblPage.Text = "P." + _nPage.ToString("#")
        _nPage += 1
    End Sub

End Class 
