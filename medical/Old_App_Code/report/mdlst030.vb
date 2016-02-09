Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports GrapeCity

Public Class mdlst030
    Inherits GrapeCity.ActiveReports.SectionReport

    Private _oWorkBook As GrapeCity.SpreadBuilder.Workbook

    Private _nRow As Integer = 0
    Private _nPage As Integer = 0

    Private _sCatalog As String = ""

    Private Const MAX_ROWS As Integer = 58

    Private Enum Align
        Left
        Center
        Right
    End Enum

    Private Enum Border
        Left
        Right
        Top
        Bottom
    End Enum

    Public Sub New(ByRef oWorkBook As GrapeCity.SpreadBuilder.Workbook)
        MyBase.New()
        InitializeComponent()
        _oWorkBook = oWorkBook
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Public lblSyoriNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Public lblTuutiNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblCatalog As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblSyori As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblLot1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblLot2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdlst030))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblSyoriNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTuutiNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblCatalog = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblSyori = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblLot1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblLot2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSyoriNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTuutiNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSyori, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblLot1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblLot2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblCatalog, Me.Line7, Me.Line9, Me.Line10, Me.lblSyori, Me.Line30, Me.lblLot1, Me.Line31, Me.lblLot2, Me.Line32, Me.Line33})
        Me.Detail.Height = 0.4472222!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTitle, Me.Line, Me.Line1, Me.Label, Me.Label1, Me.Line2, Me.Line3, Me.Line4, Me.lblSyoriNo, Me.lblTuutiNo, Me.Line5, Me.Label5, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Line34, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Line39, Me.Line40, Me.Line41})
        Me.PageHeader.Height = 1.822222!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'lblTitle
        '
        Me.lblTitle.Height = 0.25!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 2.0625!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: bottom" & _
            ""
        Me.lblTitle.Text = "※※※　変更通知書　別紙　※※※"
        Me.lblTitle.Top = 0!
        Me.lblTitle.Width = 2.9375!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.25!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.5!
        Me.Line.Width = 2.0625!
        Me.Line.X1 = 0.25!
        Me.Line.X2 = 2.3125!
        Me.Line.Y1 = 0.5!
        Me.Line.Y2 = 0.5!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.25!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.8125!
        Me.Line1.Width = 2.0625!
        Me.Line1.X1 = 0.25!
        Me.Line1.X2 = 2.3125!
        Me.Line1.Y1 = 0.8125!
        Me.Line1.Y2 = 0.8125!
        '
        'Label
        '
        Me.Label.Height = 0.1875!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.3125!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label.Text = "変更処理番号"
        Me.Label.Top = 0.5625!
        Me.Label.Width = 0.875!
        '
        'Label1
        '
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.3125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label1.Text = "変更通知番号"
        Me.Label1.Top = 0.875!
        Me.Label1.Width = 0.875!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.25!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.125!
        Me.Line2.Width = 2.0625!
        Me.Line2.X1 = 0.25!
        Me.Line2.X2 = 2.3125!
        Me.Line2.Y1 = 1.125!
        Me.Line2.Y2 = 1.125!
        '
        'Line3
        '
        Me.Line3.Height = 0.625!
        Me.Line3.Left = 1.25!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.5!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 1.25!
        Me.Line3.X2 = 1.25!
        Me.Line3.Y1 = 0.5!
        Me.Line3.Y2 = 1.125!
        '
        'Line4
        '
        Me.Line4.Height = 0.625!
        Me.Line4.Left = 0.25!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.5!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 0.25!
        Me.Line4.X2 = 0.25!
        Me.Line4.Y1 = 0.5!
        Me.Line4.Y2 = 1.125!
        '
        'lblSyoriNo
        '
        Me.lblSyoriNo.Height = 0.1875!
        Me.lblSyoriNo.HyperLink = Nothing
        Me.lblSyoriNo.Left = 1.3125!
        Me.lblSyoriNo.Name = "lblSyoriNo"
        Me.lblSyoriNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.lblSyoriNo.Text = "XXXXXXXXXX"
        Me.lblSyoriNo.Top = 0.5625!
        Me.lblSyoriNo.Width = 0.9375!
        '
        'lblTuutiNo
        '
        Me.lblTuutiNo.Height = 0.1875!
        Me.lblTuutiNo.HyperLink = Nothing
        Me.lblTuutiNo.Left = 1.3125!
        Me.lblTuutiNo.Name = "lblTuutiNo"
        Me.lblTuutiNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.lblTuutiNo.Text = "XXXXXXXXXX"
        Me.lblTuutiNo.Top = 0.875!
        Me.lblTuutiNo.Width = 0.9375!
        '
        'Line5
        '
        Me.Line5.Height = 0.625!
        Me.Line5.Left = 2.3125!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.5!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 2.3125!
        Me.Line5.X2 = 2.3125!
        Me.Line5.Y1 = 0.5!
        Me.Line5.Y2 = 1.125!
        '
        'Label5
        '
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label5.Text = "カタログ番号"
        Me.Label5.Top = 1.5!
        Me.Label5.Width = 1.25!
        '
        'Label13
        '
        Me.Label13.Height = 0.1875!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 1.875!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label13.Text = "処理"
        Me.Label13.Top = 1.5!
        Me.Label13.Width = 1.3125!
        '
        'Label14
        '
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 3.4375!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label14.Text = "適用ロットNO"
        Me.Label14.Top = 1.5!
        Me.Label14.Width = 0.875!
        '
        'Label15
        '
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 4.5625!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label15.Text = "最終ロットNO"
        Me.Label15.Top = 1.5!
        Me.Label15.Width = 0.875!
        '
        'Label16
        '
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 5.6875!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label16.Text = "備考"
        Me.Label16.Top = 1.5!
        Me.Label16.Width = 1.1875!
        '
        'Line34
        '
        Me.Line34.Height = 0!
        Me.Line34.Left = 0.25!
        Me.Line34.LineWeight = 1!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 1.375!
        Me.Line34.Width = 6.75!
        Me.Line34.X1 = 0.25!
        Me.Line34.X2 = 7!
        Me.Line34.Y1 = 1.375!
        Me.Line34.Y2 = 1.375!
        '
        'Line35
        '
        Me.Line35.Height = 0.4375!
        Me.Line35.Left = 0.25!
        Me.Line35.LineWeight = 1!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 1.375!
        Me.Line35.Width = 0!
        Me.Line35.X1 = 0.25!
        Me.Line35.X2 = 0.25!
        Me.Line35.Y1 = 1.375!
        Me.Line35.Y2 = 1.8125!
        '
        'Line36
        '
        Me.Line36.Height = 0!
        Me.Line36.Left = 0.25!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 1.8125!
        Me.Line36.Width = 6.75!
        Me.Line36.X1 = 0.25!
        Me.Line36.X2 = 7!
        Me.Line36.Y1 = 1.8125!
        Me.Line36.Y2 = 1.8125!
        '
        'Line37
        '
        Me.Line37.Height = 0.4375!
        Me.Line37.Left = 1.75!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 1.375!
        Me.Line37.Width = 0!
        Me.Line37.X1 = 1.75!
        Me.Line37.X2 = 1.75!
        Me.Line37.Y1 = 1.375!
        Me.Line37.Y2 = 1.8125!
        '
        'Line38
        '
        Me.Line38.Height = 0.4375!
        Me.Line38.Left = 3.3125!
        Me.Line38.LineWeight = 1!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 1.375!
        Me.Line38.Width = 0!
        Me.Line38.X1 = 3.3125!
        Me.Line38.X2 = 3.3125!
        Me.Line38.Y1 = 1.375!
        Me.Line38.Y2 = 1.8125!
        '
        'Line39
        '
        Me.Line39.Height = 0.4375!
        Me.Line39.Left = 4.4375!
        Me.Line39.LineWeight = 1!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 1.375!
        Me.Line39.Width = 0!
        Me.Line39.X1 = 4.4375!
        Me.Line39.X2 = 4.4375!
        Me.Line39.Y1 = 1.375!
        Me.Line39.Y2 = 1.8125!
        '
        'Line40
        '
        Me.Line40.Height = 0.4375!
        Me.Line40.Left = 5.5625!
        Me.Line40.LineWeight = 1!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 1.375!
        Me.Line40.Width = 0!
        Me.Line40.X1 = 5.5625!
        Me.Line40.X2 = 5.5625!
        Me.Line40.Y1 = 1.375!
        Me.Line40.Y2 = 1.8125!
        '
        'Line41
        '
        Me.Line41.Height = 0.4375!
        Me.Line41.Left = 7!
        Me.Line41.LineWeight = 1!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 1.375!
        Me.Line41.Width = 0!
        Me.Line41.X1 = 7!
        Me.Line41.X2 = 7!
        Me.Line41.Y1 = 1.375!
        Me.Line41.Y2 = 1.8125!
        '
        'lblCatalog
        '
        Me.lblCatalog.DataField = "CATALOG_NO"
        Me.lblCatalog.Height = 0.1875!
        Me.lblCatalog.HyperLink = Nothing
        Me.lblCatalog.Left = 0.375!
        Me.lblCatalog.Name = "lblCatalog"
        Me.lblCatalog.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.lblCatalog.Text = "XXXXXXXXXXXXXXXXX"
        Me.lblCatalog.Top = 0.125!
        Me.lblCatalog.Width = 1.25!
        '
        'Line7
        '
        Me.Line7.Height = 0!
        Me.Line7.Left = 0.25!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.4375!
        Me.Line7.Width = 6.75!
        Me.Line7.X1 = 0.25!
        Me.Line7.X2 = 7!
        Me.Line7.Y1 = 0.4375!
        Me.Line7.Y2 = 0.4375!
        '
        'Line9
        '
        Me.Line9.Height = 0.4375!
        Me.Line9.Left = 0.25!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 0.25!
        Me.Line9.X2 = 0.25!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0.4375!
        '
        'Line10
        '
        Me.Line10.Height = 0.4375!
        Me.Line10.Left = 1.75!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 1.75!
        Me.Line10.X2 = 1.75!
        Me.Line10.Y1 = 0!
        Me.Line10.Y2 = 0.4375!
        '
        'lblSyori
        '
        Me.lblSyori.DataField = "TRAN"
        Me.lblSyori.Height = 0.1875!
        Me.lblSyori.HyperLink = Nothing
        Me.lblSyori.Left = 1.875!
        Me.lblSyori.Name = "lblSyori"
        Me.lblSyori.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.lblSyori.Text = "ＮＮＮＮＮＮＮＮＮ"
        Me.lblSyori.Top = 0.125!
        Me.lblSyori.Width = 1.3125!
        '
        'Line30
        '
        Me.Line30.Height = 0.4375!
        Me.Line30.Left = 3.3125!
        Me.Line30.LineWeight = 1!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 0!
        Me.Line30.Width = 0!
        Me.Line30.X1 = 3.3125!
        Me.Line30.X2 = 3.3125!
        Me.Line30.Y1 = 0!
        Me.Line30.Y2 = 0.4375!
        '
        'lblLot1
        '
        Me.lblLot1.DataField = "APPLY_LOT"
        Me.lblLot1.Height = 0.1875!
        Me.lblLot1.HyperLink = Nothing
        Me.lblLot1.Left = 3.4375!
        Me.lblLot1.Name = "lblLot1"
        Me.lblLot1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.lblLot1.Text = "99999"
        Me.lblLot1.Top = 0.125!
        Me.lblLot1.Width = 0.875!
        '
        'Line31
        '
        Me.Line31.Height = 0.4375!
        Me.Line31.Left = 4.4375!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 0!
        Me.Line31.Width = 0!
        Me.Line31.X1 = 4.4375!
        Me.Line31.X2 = 4.4375!
        Me.Line31.Y1 = 0!
        Me.Line31.Y2 = 0.4375!
        '
        'lblLot2
        '
        Me.lblLot2.DataField = "END_LOT"
        Me.lblLot2.Height = 0.1875!
        Me.lblLot2.HyperLink = Nothing
        Me.lblLot2.Left = 4.5625!
        Me.lblLot2.Name = "lblLot2"
        Me.lblLot2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.lblLot2.Text = "99999"
        Me.lblLot2.Top = 0.125!
        Me.lblLot2.Width = 0.875!
        '
        'Line32
        '
        Me.Line32.Height = 0.4375!
        Me.Line32.Left = 5.5625!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 0!
        Me.Line32.Width = 0!
        Me.Line32.X1 = 5.5625!
        Me.Line32.X2 = 5.5625!
        Me.Line32.Y1 = 0!
        Me.Line32.Y2 = 0.4375!
        '
        'Line33
        '
        Me.Line33.Height = 0.4375!
        Me.Line33.Left = 7!
        Me.Line33.LineWeight = 1!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 0!
        Me.Line33.Width = 0!
        Me.Line33.X1 = 7!
        Me.Line33.X2 = 7!
        Me.Line33.Y1 = 0!
        Me.Line33.Y2 = 0.4375!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=orcl;Persist Secu" & _
            "rity Info=True"
        OleDBDataSource1.SQL = "Select * from WK_CHANGE_NOTICE order by CATALOG_NO,APPLY_LOT,END_LOT"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.4!
        Me.PageSettings.Margins.Right = 0.4!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.25!
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
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSyoriNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTuutiNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSyori, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblLot1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblLot2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit
    End Sub

#End Region

    Private Sub mdlst030_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        _oWorkBook.Sheets.AddNew()
        '_oWorkBook.Sheets(0).PageSetup.Orientation = Printing.PagePrintOrientation.Portrait
        _oWorkBook.Sheets(0).PageSetup.Orientation = GrapeCity.SpreadBuilder.Printing.PagePrintOrientation.Portrait
        _oWorkBook.Sheets(0).PageSetup.PaperSize = System.Drawing.Printing.PaperKind.A4
        _oWorkBook.Sheets(0).PageSetup.TopMargin = 40
        _oWorkBook.Sheets(0).PageSetup.BottomMargin = 40
        _oWorkBook.Sheets(0).PageSetup.LeftMargin = 40
        _oWorkBook.Sheets(0).PageSetup.RightMargin = 10
    End Sub

    Private Sub mdlst030_PageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageStart
        _nPage += 1
        _sCatalog = ""
        For i As Integer = 0 To 50
            _oWorkBook.Sheets(0).Columns(i).Width = 275
            '_oWorkBook.Sheets(0).Columns(i).Width = 300 
        Next
        For i As Integer = (_nPage - 1) * MAX_ROWS To (_nPage - 1) * MAX_ROWS + MAX_ROWS
            _oWorkBook.Sheets(0).Rows(i).height = 272
        Next
    End Sub

    Private Sub mdlst030_PageEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageEnd
        If _nRow < 20 Then
            For i As Integer = _nRow To 19
                Dim nPos As Integer = ((_nPage - 1) * MAX_ROWS) + 15 + (i * 2)
                _oWorkBook.Sheets(0).Cell(nPos, 1).Merge(1, 7)
                SetValue(nPos, 1, Align.Center, "")
                _oWorkBook.Sheets(0).Cell(nPos, 9).Merge(1, 7)
                SetValue(nPos, 9, Align.Center, "")
                _oWorkBook.Sheets(0).Cell(nPos, 17).Merge(1, 4)
                SetValue(nPos, 17, Align.Center, "")
                _oWorkBook.Sheets(0).Cell(nPos, 22).Merge(1, 4)
                SetValue(nPos, 22, Align.Center, "")
                _oWorkBook.Sheets(0).Cell(nPos, 27).Merge(1, 8)
                SetValue(nPos, 27, Align.Center, "")
                SetBorderBox(nPos, 1)
                SetBorderBox(nPos, 9)
                SetBorderBox(nPos, 17)
                SetBorderBox(nPos, 22)
                SetBorderBox(nPos, 27)
            Next
        End If
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Dim sPos As Integer = (_nPage - 1) * MAX_ROWS
        '帳票タイトル 
        _oWorkBook.Sheets(0).Cell(sPos + 1, 1).Merge(0, 34)
        _oWorkBook.Sheets(0).Rows(sPos + 1).AutoSize = True
        SetValue(sPos + 1, 1, 14, Align.Center, lblTitle.Text)
        '変更処理番号 
        SetValue(sPos + 5, 2, "変更処理番号")
        SetValue(sPos + 5, 9, lblSyoriNo.Text)
        '変更通知番号 
        SetValue(sPos + 8, 2, "変更通知番号")
        SetValue(sPos + 8, 9, lblTuutiNo.Text)
        '発行日 
        SetValue(sPos + 4, 35, Align.Right, "発行日：" + DateTime.Now.ToString("yyyy/MM/dd"))
        '罫線 
        SetBorderLine(sPos + 3, 1, 13)
        SetBorderLine(sPos + 6, 1, 13)
        SetBorderLine(sPos + 9, 1, 13)
        SetBorderLine(sPos + 4, 1, 6, Border.Left)
        SetBorderLine(sPos + 4, 8, 6, Border.Left)
        SetBorderLine(sPos + 4, 14, 6, Border.Left)
        'ヘッダー 
        _oWorkBook.Sheets(0).Cell(sPos + 13, 1).Merge(1, 7)
        SetValue(sPos + 13, 1, Align.Center, "カタログ番号")
        _oWorkBook.Sheets(0).Cell(sPos + 13, 9).Merge(1, 7)
        SetValue(sPos + 13, 9, Align.Center, "処理")
        _oWorkBook.Sheets(0).Cell(sPos + 13, 17).Merge(1, 4)
        SetValue(sPos + 13, 17, Align.Center, "適用ロットNO")
        _oWorkBook.Sheets(0).Cell(sPos + 13, 22).Merge(1, 4)
        SetValue(sPos + 13, 22, Align.Center, "最終ロットNO")
        _oWorkBook.Sheets(0).Cell(sPos + 13, 27).Merge(1, 8)
        SetValue(sPos + 13, 27, Align.Center, "備考")
        '罫線 
        SetBorderBox(sPos + 13, 1)
        SetBorderBox(sPos + 13, 9)
        SetBorderBox(sPos + 13, 17)
        SetBorderBox(sPos + 13, 22)
        SetBorderBox(sPos + 13, 27)
        _nRow = 0
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Dim nPos As Integer = ((_nPage - 1) * MAX_ROWS) + 15 + (_nRow * 2)
        _oWorkBook.Sheets(0).Cell(nPos, 1).Merge(1, 7)
        If _sCatalog.Trim() <> lblCatalog.Text.Trim() Then
            SetValue(nPos, 1, Align.Center, lblCatalog.Text)
        Else
            SetValue(nPos, 1, Align.Center, "")
        End If
        _oWorkBook.Sheets(0).Cell(nPos, 9).Merge(1, 7)
        If lblSyori.Text.Trim.Equals("0") Then
            SetValue(nPos, 9, Align.Center, "着工中訂正")
        Else
            SetValue(nPos, 9, Align.Center, "次回着工分より訂正")
        End If
        _oWorkBook.Sheets(0).Cell(nPos, 17).Merge(1, 4)
        SetValue(nPos, 17, Align.Center, lblLot1.Text)
        _oWorkBook.Sheets(0).Cell(nPos, 22).Merge(1, 4)
        SetValue(nPos, 22, Align.Center, lblLot2.Text)
        _oWorkBook.Sheets(0).Cell(nPos, 27).Merge(1, 8)
        SetValue(nPos, 27, Align.Center, "")
        SetBorderBox(nPos, 1)
        SetBorderBox(nPos, 9)
        SetBorderBox(nPos, 17)
        SetBorderBox(nPos, 22)
        SetBorderBox(nPos, 27)
        _sCatalog = lblCatalog.Text.Trim()
        _nRow += 1
    End Sub

    Private Sub SetValue(ByVal nRow As Integer, ByVal nCol As Integer, ByVal sValue As String)
        SetValue(nRow, nCol, 11, Align.Left, sValue)
    End Sub

    Private Sub SetValue(ByVal nRow As Integer, ByVal nCol As Integer, ByVal oAlign As Align, ByVal sValue As String)
        SetValue(nRow, nCol, 11, oAlign, sValue)
    End Sub

    Private Sub SetValue(ByVal nRow As Integer, ByVal nCol As Integer, ByVal nFontSize As Integer, ByVal sValue As String)
        SetValue(nRow, nCol, nFontSize, Align.Left, sValue)
    End Sub

    Private Sub SetValue(ByVal nRow As Integer, ByVal nCol As Integer, ByVal nFontSize As Integer, ByVal oAlign As Align, ByVal sValue As String)
        _oWorkBook.Sheets(0).Cell(nRow, nCol).FontSize = nFontSize
        _oWorkBook.Sheets(0).Cell(nRow, nCol).FontName = "ＭＳ ゴシック"
        Select Case oAlign
            Case Align.Left
                _oWorkBook.Sheets(0).Cell(nRow, nCol).Alignment = SpreadBuilder.Style.HorzAlignments.Left
            Case Align.Center
                _oWorkBook.Sheets(0).Cell(nRow, nCol).Alignment = SpreadBuilder.Style.HorzAlignments.Center
            Case Align.Right
                _oWorkBook.Sheets(0).Cell(nRow, nCol).Alignment = SpreadBuilder.Style.HorzAlignments.Right
        End Select
        _oWorkBook.Sheets(0).Cell(nRow, nCol).VertAlignment = SpreadBuilder.Style.VertAlignments.Center
        _oWorkBook.Sheets(0).Cell(nRow, nCol).SetValue(sValue)
    End Sub

    Private Sub SetBorderLine(ByVal nRow As Integer, ByVal nCol As Integer)
        SetBorderLine(nRow, nCol, 1, Border.Bottom)
    End Sub

    Private Sub SetBorderLine(ByVal nRow As Integer, ByVal nCol As Integer, ByVal nColumns As Integer)
        SetBorderLine(nRow, nCol, nColumns, Border.Bottom)
    End Sub

    Private Sub SetBorderLine(ByVal nRow As Integer, ByVal nCol As Integer, ByVal oBorder As Border)
        SetBorderLine(nRow, nCol, 1, oBorder)
    End Sub

    Private Sub SetBorderLine(ByVal nRow As Integer, ByVal nCol As Integer, ByVal nColumns As Integer, ByVal oBorder As Border)
        Select Case oBorder
            Case Border.Left
                For i As Integer = 0 To nColumns - 1
                    _oWorkBook.Sheets(0).Cell(nRow + i, nCol).BorderLeftStyle = SpreadBuilder.Style.BorderLineStyle.Thin
                Next
            Case Border.Right
                For i As Integer = 0 To nColumns - 1
                    _oWorkBook.Sheets(0).Cell(nRow + i, nCol).BorderRightStyle = SpreadBuilder.Style.BorderLineStyle.Thin
                Next
            Case Border.Top
                For i As Integer = 0 To nColumns - 1
                    _oWorkBook.Sheets(0).Cell(nRow, nCol + i).BorderTopStyle = SpreadBuilder.Style.BorderLineStyle.Thin
                Next
            Case Border.Bottom
                For i As Integer = 0 To nColumns - 1
                    _oWorkBook.Sheets(0).Cell(nRow, nCol + i).BorderBottomStyle = SpreadBuilder.Style.BorderLineStyle.Thin
                Next
        End Select
    End Sub

    Private Sub SetBorderBox(ByVal nRow As Integer, ByVal nCol As Integer)
        _oWorkBook.Sheets(0).Cell(nRow, nCol).BorderBottomStyle = SpreadBuilder.Style.BorderLineStyle.Thin
        _oWorkBook.Sheets(0).Cell(nRow, nCol).BorderLeftStyle = SpreadBuilder.Style.BorderLineStyle.Thin
        _oWorkBook.Sheets(0).Cell(nRow, nCol).BorderRightStyle = SpreadBuilder.Style.BorderLineStyle.Thin
        _oWorkBook.Sheets(0).Cell(nRow, nCol).BorderTopStyle = SpreadBuilder.Style.BorderLineStyle.Thin
    End Sub

End Class 
