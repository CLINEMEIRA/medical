Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdnyk0301
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
    Private txtCOMPANY_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSHELF_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_AMT2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMATERIALSLOT2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_DT2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMATERIALSLOT1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_AMT1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSHELF_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_DT1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private Barcode2 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtBarcode2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Barcode1 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private txtBarcode1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt主材料LOT2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt主材料LOT1 As GrapeCity.ActiveReports.SectionReportModel.TextBox

    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdnyk0301))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtCOMPANY_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSHELF_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_AMT2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt主材料LOT2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_DT2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt主材料LOT1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_AMT1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSHELF_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_DT1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.Barcode2 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtBarcode2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Barcode1 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.txtBarcode1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.txtCOMPANY_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSHELF_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_AMT2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt主材料LOT2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_DT2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt主材料LOT1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_AMT1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSHELF_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_DT1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBarcode2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBarcode1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCOMPANY_NO2, Me.txtSHELF_NO2, Me.txtWH_AMT2, Me.txtINDICATE_NO2, Me.txt主材料LOT2, Me.txtWH_DT2, Me.txtCATALOG_NO2, Me.txt主材料LOT1, Me.txtWH_AMT1, Me.txtSHELF_NO1, Me.txtCOMPANY_NO1, Me.txtCATALOG_NO1, Me.txtINDICATE_NO1, Me.txtWH_DT1, Me.Label9, Me.Shape1, Me.Label, Me.Shape, Me.Label2, Me.Label4, Me.Label6, Me.Label7, Me.Label8, Me.Label5, Me.Label3, Me.Label1, Me.Line, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Barcode2, Me.Line22, Me.txtBarcode2, Me.Barcode1, Me.txtBarcode1})
        Me.Detail.Height = 11.5625!
        Me.Detail.Name = "Detail"
        Me.Detail.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Visible = false
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'txtCOMPANY_NO2
        '
        Me.txtCOMPANY_NO2.DataField = "COMPANY_NO2"
        Me.txtCOMPANY_NO2.Height = 0.2!
        Me.txtCOMPANY_NO2.Left = 1.692708!
        Me.txtCOMPANY_NO2.Name = "txtCOMPANY_NO2"
        Me.txtCOMPANY_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO2.Text = "社内NO2"
        Me.txtCOMPANY_NO2.Top = 8.686459!
        Me.txtCOMPANY_NO2.Width = 1!
        '
        'txtSHELF_NO2
        '
        Me.txtSHELF_NO2.DataField = "SHELF_NO2"
        Me.txtSHELF_NO2.Height = 0.2!
        Me.txtSHELF_NO2.Left = 1.692708!
        Me.txtSHELF_NO2.Name = "txtSHELF_NO2"
        Me.txtSHELF_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtSHELF_NO2.Text = "棚番2"
        Me.txtSHELF_NO2.Top = 9.498959!
        Me.txtSHELF_NO2.Width = 1!
        '
        'txtWH_AMT2
        '
        Me.txtWH_AMT2.DataField = "WH_AMT2"
        Me.txtWH_AMT2.Height = 0.2!
        Me.txtWH_AMT2.Left = 3.692708!
        Me.txtWH_AMT2.Name = "txtWH_AMT2"
        Me.txtWH_AMT2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_AMT2.Text = "入庫数2"
        Me.txtWH_AMT2.Top = 9.498959!
        Me.txtWH_AMT2.Width = 1!
        '
        'txtINDICATE_NO2
        '
        Me.txtINDICATE_NO2.DataField = "INDICATE_NO2"
        Me.txtINDICATE_NO2.Height = 0.2!
        Me.txtINDICATE_NO2.Left = 3.692708!
        Me.txtINDICATE_NO2.Name = "txtINDICATE_NO2"
        Me.txtINDICATE_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO2.Text = "指示NO2"
        Me.txtINDICATE_NO2.Top = 8.686459!
        Me.txtINDICATE_NO2.Width = 1!
        '
        'txt主材料LOT2
        '
        Me.txt主材料LOT2.DataField = "MATERIALSLOT2"
        Me.txt主材料LOT2.Height = 0.2!
        Me.txt主材料LOT2.Left = 5.692708!
        Me.txt主材料LOT2.Name = "txt主材料LOT2"
        Me.txt主材料LOT2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt主材料LOT2.Text = "主材料ロット2"
        Me.txt主材料LOT2.Top = 8.686459!
        Me.txt主材料LOT2.Width = 1!
        '
        'txtWH_DT2
        '
        Me.txtWH_DT2.DataField = "WH_DT2"
        Me.txtWH_DT2.Height = 0.2!
        Me.txtWH_DT2.Left = 5.692708!
        Me.txtWH_DT2.Name = "txtWH_DT2"
        Me.txtWH_DT2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_DT2.Text = "入庫日2"
        Me.txtWH_DT2.Top = 7.873958!
        Me.txtWH_DT2.Width = 1!
        '
        'txtCATALOG_NO2
        '
        Me.txtCATALOG_NO2.DataField = "CATALOG_NO2"
        Me.txtCATALOG_NO2.Height = 0.2!
        Me.txtCATALOG_NO2.Left = 1.692708!
        Me.txtCATALOG_NO2.Name = "txtCATALOG_NO2"
        Me.txtCATALOG_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO2.Text = "カタログ番号2"
        Me.txtCATALOG_NO2.Top = 7.873958!
        Me.txtCATALOG_NO2.Width = 3!
        '
        'txt主材料LOT1
        '
        Me.txt主材料LOT1.DataField = "MATERIALSLOT1"
        Me.txt主材料LOT1.Height = 0.2!
        Me.txt主材料LOT1.Left = 5.692708!
        Me.txt主材料LOT1.Name = "txt主材料LOT1"
        Me.txt主材料LOT1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt主材料LOT1.Text = "主材料ロット1"
        Me.txt主材料LOT1.Top = 2.748958!
        Me.txt主材料LOT1.Width = 1!
        '
        'txtWH_AMT1
        '
        Me.txtWH_AMT1.DataField = "WH_AMT1"
        Me.txtWH_AMT1.Height = 0.2!
        Me.txtWH_AMT1.Left = 3.692708!
        Me.txtWH_AMT1.Name = "txtWH_AMT1"
        Me.txtWH_AMT1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_AMT1.Text = "入庫数1"
        Me.txtWH_AMT1.Top = 3.561458!
        Me.txtWH_AMT1.Width = 1!
        '
        'txtSHELF_NO1
        '
        Me.txtSHELF_NO1.DataField = "SHELF_NO1"
        Me.txtSHELF_NO1.Height = 0.2!
        Me.txtSHELF_NO1.Left = 1.692708!
        Me.txtSHELF_NO1.Name = "txtSHELF_NO1"
        Me.txtSHELF_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtSHELF_NO1.Text = "棚番1"
        Me.txtSHELF_NO1.Top = 3.561458!
        Me.txtSHELF_NO1.Width = 1!
        '
        'txtCOMPANY_NO1
        '
        Me.txtCOMPANY_NO1.DataField = "COMPANY_NO1"
        Me.txtCOMPANY_NO1.Height = 0.2!
        Me.txtCOMPANY_NO1.Left = 1.692708!
        Me.txtCOMPANY_NO1.Name = "txtCOMPANY_NO1"
        Me.txtCOMPANY_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO1.Text = "社内NO1"
        Me.txtCOMPANY_NO1.Top = 2.748958!
        Me.txtCOMPANY_NO1.Width = 1!
        '
        'txtCATALOG_NO1
        '
        Me.txtCATALOG_NO1.DataField = "CATALOG_NO1"
        Me.txtCATALOG_NO1.Height = 0.2!
        Me.txtCATALOG_NO1.Left = 1.692708!
        Me.txtCATALOG_NO1.Name = "txtCATALOG_NO1"
        Me.txtCATALOG_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO1.Text = "カタログ番号1"
        Me.txtCATALOG_NO1.Top = 1.936458!
        Me.txtCATALOG_NO1.Width = 3!
        '
        'txtINDICATE_NO1
        '
        Me.txtINDICATE_NO1.DataField = "INDICATE_NO1"
        Me.txtINDICATE_NO1.Height = 0.2!
        Me.txtINDICATE_NO1.Left = 3.692708!
        Me.txtINDICATE_NO1.Name = "txtINDICATE_NO1"
        Me.txtINDICATE_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO1.Text = "指示NO1"
        Me.txtINDICATE_NO1.Top = 2.748958!
        Me.txtINDICATE_NO1.Width = 1!
        '
        'txtWH_DT1
        '
        Me.txtWH_DT1.DataField = "WH_DT1"
        Me.txtWH_DT1.Height = 0.2!
        Me.txtWH_DT1.Left = 5.692708!
        Me.txtWH_DT1.Name = "txtWH_DT1"
        Me.txtWH_DT1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_DT1.Text = "入庫日1"
        Me.txtWH_DT1.Top = 1.936458!
        Me.txtWH_DT1.Width = 1!
        '
        'Label9
        '
        Me.Label9.Height = 0.375!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 2.692708!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: middle"
        Me.Label9.Text = "源 製 品 履 歴 書"
        Me.Label9.Top = 6.683334!
        Me.Label9.Width = 1.8125!
        '
        'Shape1
        '
        Me.Shape1.Height = 0.375!
        Me.Shape1.Left = 2.380208!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape1.Tag = ""
        Me.Shape1.Top = 6.686458!
        Me.Shape1.Width = 2.4375!
        '
        'Label
        '
        Me.Label.Height = 0.375!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 2.692708!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: middle"
        Me.Label.Text = "源 製 品 履 歴 書"
        Me.Label.Top = 0.7489583!
        Me.Label.Width = 1.8125!
        '
        'Shape
        '
        Me.Shape.Height = 0.375!
        Me.Shape.Left = 2.380208!
        Me.Shape.Name = "Shape"
        Me.Shape.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape.Tag = ""
        Me.Shape.Top = 0.7489583!
        Me.Shape.Width = 2.4375!
        '
        'Label2
        '
        Me.Label2.Height = 0.3125!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.6927083!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label2.Text = "社内NO"
        Me.Label2.Top = 2.686458!
        Me.Label2.Width = 1!
        '
        'Label4
        '
        Me.Label4.Height = 0.3125!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.692708!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label4.Text = "ロット番号"
        Me.Label4.Top = 2.686458!
        Me.Label4.Width = 1!
        '
        'Label6
        '
        Me.Label6.Height = 0.3125!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.692708!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label6.Text = "入庫日"
        Me.Label6.Top = 1.873958!
        Me.Label6.Width = 1!
        '
        'Label7
        '
        Me.Label7.Height = 0.3125!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.692708!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label7.Text = "主材料ロット"
        Me.Label7.Top = 2.686458!
        Me.Label7.Width = 1!
        '
        'Label8
        '
        Me.Label8.Height = 0.3125!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.692708!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label8.Text = "入庫者"
        Me.Label8.Top = 3.498958!
        Me.Label8.Width = 1!
        '
        'Label5
        '
        Me.Label5.Height = 0.3125!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.692708!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label5.Text = "入庫数"
        Me.Label5.Top = 3.498958!
        Me.Label5.Width = 1!
        '
        'Label3
        '
        Me.Label3.Height = 0.3125!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.6927083!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label3.Text = "棚番"
        Me.Label3.Top = 3.498958!
        Me.Label3.Width = 1!
        '
        'Label1
        '
        Me.Label1.Height = 0.3125!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.6927083!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label1.Text = "カタログ番号"
        Me.Label1.Top = 1.873958!
        Me.Label1.Width = 1!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.6927083!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.623958!
        Me.Line.Width = 6!
        Me.Line.X1 = 0.6927083!
        Me.Line.X2 = 6.692708!
        Me.Line.Y1 = 1.623958!
        Me.Line.Y2 = 1.623958!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.6927083!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 2.436458!
        Me.Line1.Width = 6!
        Me.Line1.X1 = 0.6927083!
        Me.Line1.X2 = 6.692708!
        Me.Line1.Y1 = 2.436458!
        Me.Line1.Y2 = 2.436458!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.6927083!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 3.248958!
        Me.Line2.Width = 6!
        Me.Line2.X1 = 0.6927083!
        Me.Line2.X2 = 6.692708!
        Me.Line2.Y1 = 3.248958!
        Me.Line2.Y2 = 3.248958!
        '
        'Line3
        '
        Me.Line3.Height = 0!
        Me.Line3.Left = 0.6927083!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 4.061458!
        Me.Line3.Width = 6!
        Me.Line3.X1 = 0.6927083!
        Me.Line3.X2 = 6.692708!
        Me.Line3.Y1 = 4.061458!
        Me.Line3.Y2 = 4.061458!
        '
        'Line4
        '
        Me.Line4.Height = 2.4375!
        Me.Line4.Left = 0.6927083!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.623958!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 0.6927083!
        Me.Line4.X2 = 0.6927083!
        Me.Line4.Y1 = 1.623958!
        Me.Line4.Y2 = 4.061458!
        '
        'Line5
        '
        Me.Line5.Height = 2.4375!
        Me.Line5.Left = 1.692708!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.623958!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 1.692708!
        Me.Line5.X2 = 1.692708!
        Me.Line5.Y1 = 1.623958!
        Me.Line5.Y2 = 4.061458!
        '
        'Line6
        '
        Me.Line6.Height = 1.625!
        Me.Line6.Left = 2.692708!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 2.436458!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 2.692708!
        Me.Line6.X2 = 2.692708!
        Me.Line6.Y1 = 2.436458!
        Me.Line6.Y2 = 4.061458!
        '
        'Line7
        '
        Me.Line7.Height = 1.625!
        Me.Line7.Left = 3.692708!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 2.436458!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 3.692708!
        Me.Line7.X2 = 3.692708!
        Me.Line7.Y1 = 2.436458!
        Me.Line7.Y2 = 4.061458!
        '
        'Line8
        '
        Me.Line8.Height = 2.4375!
        Me.Line8.Left = 4.692708!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.623958!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 4.692708!
        Me.Line8.X2 = 4.692708!
        Me.Line8.Y1 = 1.623958!
        Me.Line8.Y2 = 4.061458!
        '
        'Line9
        '
        Me.Line9.Height = 2.4375!
        Me.Line9.Left = 5.692708!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.623958!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 5.692708!
        Me.Line9.X2 = 5.692708!
        Me.Line9.Y1 = 1.623958!
        Me.Line9.Y2 = 4.061458!
        '
        'Line10
        '
        Me.Line10.Height = 2.4375!
        Me.Line10.Left = 6.692708!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 1.623958!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 6.692708!
        Me.Line10.X2 = 6.692708!
        Me.Line10.Y1 = 1.623958!
        Me.Line10.Y2 = 4.061458!
        '
        'Label10
        '
        Me.Label10.Height = 0.3125!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.6927083!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label10.Text = "社内NO"
        Me.Label10.Top = 8.620833!
        Me.Label10.Width = 1!
        '
        'Label11
        '
        Me.Label11.Height = 0.3125!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.692708!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label11.Text = "ロット番号"
        Me.Label11.Top = 8.620833!
        Me.Label11.Width = 1!
        '
        'Label12
        '
        Me.Label12.Height = 0.3125!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 4.6875!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label12.Text = "入庫日"
        Me.Label12.Top = 7.808333!
        Me.Label12.Width = 1!
        '
        'Label13
        '
        Me.Label13.Height = 0.3125!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 4.6875!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label13.Text = "主材料ロット"
        Me.Label13.Top = 8.620833!
        Me.Label13.Width = 1!
        '
        'Label14
        '
        Me.Label14.Height = 0.3125!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 4.6875!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label14.Text = "入庫者"
        Me.Label14.Top = 9.433333!
        Me.Label14.Width = 1!
        '
        'Label15
        '
        Me.Label15.Height = 0.3125!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 2.6875!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label15.Text = "入庫数"
        Me.Label15.Top = 9.433333!
        Me.Label15.Width = 1!
        '
        'Label16
        '
        Me.Label16.Height = 0.3125!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.6875!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label16.Text = "棚番"
        Me.Label16.Top = 9.433333!
        Me.Label16.Width = 1!
        '
        'Label17
        '
        Me.Label17.Height = 0.3125!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.6875!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label17.Text = "カタログ番号"
        Me.Label17.Top = 7.808333!
        Me.Label17.Width = 1!
        '
        'Line11
        '
        Me.Line11.Height = 0!
        Me.Line11.Left = 0.6875!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 7.558333!
        Me.Line11.Width = 6!
        Me.Line11.X1 = 0.6875!
        Me.Line11.X2 = 6.6875!
        Me.Line11.Y1 = 7.558333!
        Me.Line11.Y2 = 7.558333!
        '
        'Line12
        '
        Me.Line12.Height = 0!
        Me.Line12.Left = 0.6875!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 8.370833!
        Me.Line12.Width = 6!
        Me.Line12.X1 = 0.6875!
        Me.Line12.X2 = 6.6875!
        Me.Line12.Y1 = 8.370833!
        Me.Line12.Y2 = 8.370833!
        '
        'Line13
        '
        Me.Line13.Height = 0!
        Me.Line13.Left = 0.6875!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 9.183333!
        Me.Line13.Width = 6!
        Me.Line13.X1 = 0.6875!
        Me.Line13.X2 = 6.6875!
        Me.Line13.Y1 = 9.183333!
        Me.Line13.Y2 = 9.183333!
        '
        'Line14
        '
        Me.Line14.Height = 0!
        Me.Line14.Left = 0.6875!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 9.995833!
        Me.Line14.Width = 6!
        Me.Line14.X1 = 0.6875!
        Me.Line14.X2 = 6.6875!
        Me.Line14.Y1 = 9.995833!
        Me.Line14.Y2 = 9.995833!
        '
        'Line15
        '
        Me.Line15.Height = 2.4375!
        Me.Line15.Left = 0.6875!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 7.558333!
        Me.Line15.Width = 0!
        Me.Line15.X1 = 0.6875!
        Me.Line15.X2 = 0.6875!
        Me.Line15.Y1 = 7.558333!
        Me.Line15.Y2 = 9.995833!
        '
        'Line16
        '
        Me.Line16.Height = 2.4375!
        Me.Line16.Left = 1.6875!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 7.558333!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 1.6875!
        Me.Line16.X2 = 1.6875!
        Me.Line16.Y1 = 7.558333!
        Me.Line16.Y2 = 9.995833!
        '
        'Line17
        '
        Me.Line17.Height = 1.625!
        Me.Line17.Left = 2.6875!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 8.370833!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 2.6875!
        Me.Line17.X2 = 2.6875!
        Me.Line17.Y1 = 8.370833!
        Me.Line17.Y2 = 9.995833!
        '
        'Line18
        '
        Me.Line18.Height = 1.625!
        Me.Line18.Left = 3.6875!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 8.370833!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 3.6875!
        Me.Line18.X2 = 3.6875!
        Me.Line18.Y1 = 8.370833!
        Me.Line18.Y2 = 9.995833!
        '
        'Line19
        '
        Me.Line19.Height = 2.4375!
        Me.Line19.Left = 4.6875!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 7.558333!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 4.6875!
        Me.Line19.X2 = 4.6875!
        Me.Line19.Y1 = 7.558333!
        Me.Line19.Y2 = 9.995833!
        '
        'Line20
        '
        Me.Line20.Height = 2.4375!
        Me.Line20.Left = 5.6875!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 7.558333!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 5.6875!
        Me.Line20.X2 = 5.6875!
        Me.Line20.Y1 = 7.558333!
        Me.Line20.Y2 = 9.995833!
        '
        'Line21
        '
        Me.Line21.Height = 2.4375!
        Me.Line21.Left = 6.6875!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 7.558333!
        Me.Line21.Width = 0!
        Me.Line21.X1 = 6.6875!
        Me.Line21.X2 = 6.6875!
        Me.Line21.Y1 = 7.558333!
        Me.Line21.Y2 = 9.995833!
        '
        'Barcode2
        '
        Me.Barcode2.CheckSumEnabled = false
        Me.Barcode2.DataField = "バーコード2"
        Me.Barcode2.Font = New System.Drawing.Font("Courier New", 8!)
        Me.Barcode2.Height = 0.25!
        Me.Barcode2.Left = 1.5625!
        Me.Barcode2.Name = "Barcode2"
        Me.Barcode2.QuietZoneBottom = 0!
        Me.Barcode2.QuietZoneLeft = 0!
        Me.Barcode2.QuietZoneRight = 0!
        Me.Barcode2.QuietZoneTop = 0!
        Me.Barcode2.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode2.Text = "Barcode"
        Me.Barcode2.Top = 10.31146!
        Me.Barcode2.Width = 2!
        '
        'Line22
        '
        Me.Line22.Height = 0!
        Me.Line22.Left = 0.125!
        Me.Line22.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line22.LineWeight = 2!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 5.807292!
        Me.Line22.Width = 7!
        Me.Line22.X1 = 0.125!
        Me.Line22.X2 = 7.125!
        Me.Line22.Y1 = 5.807292!
        Me.Line22.Y2 = 5.807292!
        '
        'txtBarcode2
        '
        Me.txtBarcode2.DataField = "バーコード2"
        Me.txtBarcode2.Height = 0.2!
        Me.txtBarcode2.Left = 1.5625!
        Me.txtBarcode2.Name = "txtBarcode2"
        Me.txtBarcode2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtBarcode2.Text = "バーコード2"
        Me.txtBarcode2.Top = 10.5625!
        Me.txtBarcode2.Width = 2!
        '
        'Barcode1
        '
        Me.Barcode1.CheckSumEnabled = false
        Me.Barcode1.DataField = "バーコード1"
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8!)
        Me.Barcode1.Height = 0.25!
        Me.Barcode1.Left = 1.5625!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.QuietZoneBottom = 0!
        Me.Barcode1.QuietZoneLeft = 0!
        Me.Barcode1.QuietZoneRight = 0!
        Me.Barcode1.QuietZoneTop = 0!
        Me.Barcode1.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode1.Text = "Barcode"
        Me.Barcode1.Top = 4.371875!
        Me.Barcode1.Width = 2!
        '
        'txtBarcode1
        '
        Me.txtBarcode1.DataField = "バーコード1"
        Me.txtBarcode1.Height = 0.2!
        Me.txtBarcode1.Left = 1.5625!
        Me.txtBarcode1.Name = "txtBarcode1"
        Me.txtBarcode1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtBarcode1.Text = "バーコード1"
        Me.txtBarcode1.Top = 4.622917!
        Me.txtBarcode1.Width = 2!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0!
        Me.PageSettings.Margins.Left = 0.3!
        Me.PageSettings.Margins.Right = 0.3!
        Me.PageSettings.Margins.Top = 0!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.260417!
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
        CType(Me.txtCOMPANY_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSHELF_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_AMT2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt主材料LOT2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_DT2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt主材料LOT1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_AMT1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSHELF_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_DT1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBarcode2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBarcode1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If txtWH_DT1.Text <> "" Then txtWH_DT1.Text = txtWH_DT1.Text.Substring(0, 4) & "/" & txtWH_DT1.Text.Substring(4, 2) & "/" & txtWH_DT1.Text.Substring(6, 2)
        If txtWH_DT2.Text <> "" Then txtWH_DT2.Text = txtWH_DT2.Text.Substring(0, 4) & "/" & txtWH_DT2.Text.Substring(4, 2) & "/" & txtWH_DT2.Text.Substring(6, 2)
        If txtBarcode1.Text <> "" Then txtBarcode1.Text = "*" & txtBarcode1.Text & "*"
        If txtBarcode2.Text <> "" Then txtBarcode2.Text = "*" & txtBarcode2.Text & "*"
    End Sub
End Class 
