Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdnyk0302
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
    Private txtWH_AMT1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_DT1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt名称1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Barcode1 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private txtBarcode1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_AMT2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_DT2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt名称2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtWH_AMT3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_DT3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt名称3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label29 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label35 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label36 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label38 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line75 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line76 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line77 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line78 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line79 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line80 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line81 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line82 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line83 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line84 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line85 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtWH_AMT4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWH_DT4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt名称4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label39 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label40 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label41 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label42 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label43 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label44 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label45 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label46 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label47 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label48 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label49 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label50 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label51 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line86 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line87 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line88 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line89 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line90 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line91 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line92 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line93 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line94 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line95 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line96 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line97 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line98 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line99 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line100 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line101 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line102 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line103 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line104 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line105 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line106 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line107 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line108 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line109 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line110 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line111 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line112 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line113 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Barcode2 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private txtBarcode2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Barcode3 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private txtBarcode3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Barcode4 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private txtBarcode4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdnyk0302))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtWH_AMT1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_DT1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt名称1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Barcode1 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.txtBarcode1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_AMT2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_DT2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt名称2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtWH_AMT3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_DT3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt名称3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label29 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label35 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label36 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label38 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line75 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line76 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line77 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line78 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line79 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line80 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line81 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line82 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line83 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line84 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line85 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtWH_AMT4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWH_DT4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt名称4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label39 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label40 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label41 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label42 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label43 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label44 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label45 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label46 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label47 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label48 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label49 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label50 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label51 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line86 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line87 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line88 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line89 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line90 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line91 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line92 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line93 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line94 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line95 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line96 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line97 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line98 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line99 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line100 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line101 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line102 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line103 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line104 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line105 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line106 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line107 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line108 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line109 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line110 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line111 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line112 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line113 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Barcode2 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.txtBarcode2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Barcode3 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.txtBarcode3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Barcode4 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.txtBarcode4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.txtWH_AMT1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_DT1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt名称1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBarcode1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_AMT2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_DT2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt名称2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_AMT3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_DT3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt名称3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_AMT4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWH_DT4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt名称4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBarcode2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBarcode3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBarcode4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtWH_AMT1, Me.txtWH_DT1, Me.txtINDICATE_NO1, Me.txtCOMPANY_NO1, Me.txt名称1, Me.txtCATALOG_NO1, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label, Me.Label1, Me.Line22, Me.Line, Me.Line1, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line2, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line23, Me.Line24, Me.Line25, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Barcode1, Me.txtBarcode1, Me.txtWH_AMT2, Me.txtWH_DT2, Me.txtINDICATE_NO2, Me.txtCOMPANY_NO2, Me.txt名称2, Me.txtCATALOG_NO2, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.Line34, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Line39, Me.Line40, Me.Line41, Me.Line42, Me.Line43, Me.Line44, Me.Line45, Me.Line46, Me.Line47, Me.Line48, Me.Line49, Me.Line50, Me.Line51, Me.Line52, Me.Line53, Me.Line54, Me.Line55, Me.Line56, Me.Line57, Me.txtWH_AMT3, Me.txtWH_DT3, Me.txtINDICATE_NO3, Me.txtCOMPANY_NO3, Me.txt名称3, Me.txtCATALOG_NO3, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.Label38, Me.Line58, Me.Line59, Me.Line60, Me.Line61, Me.Line62, Me.Line63, Me.Line64, Me.Line65, Me.Line66, Me.Line67, Me.Line68, Me.Line69, Me.Line70, Me.Line71, Me.Line72, Me.Line73, Me.Line74, Me.Line75, Me.Line76, Me.Line77, Me.Line78, Me.Line79, Me.Line80, Me.Line81, Me.Line82, Me.Line83, Me.Line84, Me.Line85, Me.txtWH_AMT4, Me.txtWH_DT4, Me.txtINDICATE_NO4, Me.txtCOMPANY_NO4, Me.txt名称4, Me.txtCATALOG_NO4, Me.Label39, Me.Label40, Me.Label41, Me.Label42, Me.Label43, Me.Label44, Me.Label45, Me.Label46, Me.Label47, Me.Label48, Me.Label49, Me.Label50, Me.Label51, Me.Line86, Me.Line87, Me.Line88, Me.Line89, Me.Line90, Me.Line91, Me.Line92, Me.Line93, Me.Line94, Me.Line95, Me.Line96, Me.Line97, Me.Line98, Me.Line99, Me.Line100, Me.Line101, Me.Line102, Me.Line103, Me.Line104, Me.Line105, Me.Line106, Me.Line107, Me.Line108, Me.Line109, Me.Line110, Me.Line111, Me.Line112, Me.Line113, Me.Barcode2, Me.txtBarcode2, Me.Barcode3, Me.txtBarcode3, Me.Barcode4, Me.txtBarcode4})
        Me.Detail.Height = 11.26944!
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
        'txtWH_AMT1
        '
        Me.txtWH_AMT1.DataField = "WH_AMT1"
        Me.txtWH_AMT1.Height = 0.313!
        Me.txtWH_AMT1.Left = 2.438!
        Me.txtWH_AMT1.Name = "txtWH_AMT1"
        Me.txtWH_AMT1.OutputFormat = resources.GetString("txtWH_AMT1.OutputFormat")
        Me.txtWH_AMT1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_AMT1.Text = "入庫数1"
        Me.txtWH_AMT1.Top = 1.656222!
        Me.txtWH_AMT1.Width = 1.187!
        '
        'txtWH_DT1
        '
        Me.txtWH_DT1.DataField = "WH_DT1"
        Me.txtWH_DT1.Height = 0.313!
        Me.txtWH_DT1.Left = 0.25!
        Me.txtWH_DT1.Name = "txtWH_DT1"
        Me.txtWH_DT1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_DT1.Text = "入庫日1"
        Me.txtWH_DT1.Top = 1.656222!
        Me.txtWH_DT1.Width = 2.1875!
        '
        'txtINDICATE_NO1
        '
        Me.txtINDICATE_NO1.DataField = "INDICATE_NO1"
        Me.txtINDICATE_NO1.Height = 0.313!
        Me.txtINDICATE_NO1.Left = 1.938!
        Me.txtINDICATE_NO1.Name = "txtINDICATE_NO1"
        Me.txtINDICATE_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO1.Text = "指示NO1"
        Me.txtINDICATE_NO1.Top = 1.177!
        Me.txtINDICATE_NO1.Width = 1.688!
        '
        'txtCOMPANY_NO1
        '
        Me.txtCOMPANY_NO1.DataField = "COMPANY_NO1"
        Me.txtCOMPANY_NO1.Height = 0.3125!
        Me.txtCOMPANY_NO1.Left = 0.25!
        Me.txtCOMPANY_NO1.Name = "txtCOMPANY_NO1"
        Me.txtCOMPANY_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO1.Text = "社内NO1"
        Me.txtCOMPANY_NO1.Top = 1.177222!
        Me.txtCOMPANY_NO1.Width = 1.6875!
        '
        'txt名称1
        '
        Me.txt名称1.DataField = "名称1"
        Me.txt名称1.Height = 0.3125!
        Me.txt名称1.Left = 1.9375!
        Me.txt名称1.Name = "txt名称1"
        Me.txt名称1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt名称1.Text = "名称1"
        Me.txt名称1.Top = 0.6972222!
        Me.txt名称1.Width = 1.6875!
        '
        'txtCATALOG_NO1
        '
        Me.txtCATALOG_NO1.DataField = "CATALOG_NO1"
        Me.txtCATALOG_NO1.Height = 0.3125!
        Me.txtCATALOG_NO1.Left = 0.25!
        Me.txtCATALOG_NO1.Name = "txtCATALOG_NO1"
        Me.txtCATALOG_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO1.Text = "カタログ番号1"
        Me.txtCATALOG_NO1.Top = 0.6972222!
        Me.txtCATALOG_NO1.Width = 1.6875!
        '
        'Label8
        '
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 1!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label8.Text = "出庫数"
        Me.Label8.Top = 1.947222!
        Me.Label8.Width = 0.5!
        '
        'Label9
        '
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 1.5!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label9.Text = "在庫数"
        Me.Label9.Top = 1.947222!
        Me.Label9.Width = 0.5!
        '
        'Label10
        '
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 2!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label10.Text = "担当"
        Me.Label10.Top = 1.947222!
        Me.Label10.Width = 0.5!
        '
        'Label11
        '
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.5!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label11.Text = "出庫P/N"
        Me.Label11.Top = 1.947222!
        Me.Label11.Width = 0.5625!
        '
        'Label12
        '
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 3.0625!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label12.Text = "指示NO"
        Me.Label12.Top = 1.947222!
        Me.Label12.Width = 0.5625!
        '
        'Label7
        '
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.25!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label7.Text = "出庫年月日"
        Me.Label7.Top = 1.947222!
        Me.Label7.Width = 0.75!
        '
        'Label6
        '
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2.4375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label6.Text = "入庫数"
        Me.Label6.Top = 1.467722!
        Me.Label6.Width = 1.1875!
        '
        'Label5
        '
        Me.Label5.Height = 0.188!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.25!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label5.Text = "入庫日"
        Me.Label5.Top = 1.468222!
        Me.Label5.Width = 2.1875!
        '
        'Label4
        '
        Me.Label4.Height = 0.188!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.938!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label4.Text = "ロット番号"
        Me.Label4.Top = 0.9892222!
        Me.Label4.Width = 1.688!
        '
        'Label3
        '
        Me.Label3.Height = 0.188!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.25!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label3.Text = "社内NO"
        Me.Label3.Top = 0.9892222!
        Me.Label3.Width = 1.688!
        '
        'Label2
        '
        Me.Label2.Height = 0.188!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.9375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label2.Text = "名称"
        Me.Label2.Top = 0.5097222!
        Me.Label2.Width = 1.688!
        '
        'Label
        '
        Me.Label.Height = 0.188!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.25!
        Me.Label.Name = "Label"
        Me.Label.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label.Text = "カタログ番号"
        Me.Label.Top = 0.5102222!
        Me.Label.Width = 1.688!
        '
        'Label1
        '
        Me.Label1.Height = 0.3125!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.25!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weig" & _
            "ht: bold; text-align: center; vertical-align: middle"
        Me.Label1.Text = "医療部品現品票"
        Me.Label1.Top = 0.1972222!
        Me.Label1.Width = 3.375!
        '
        'Line22
        '
        Me.Line22.Height = 0!
        Me.Line22.Left = 0.125!
        Me.Line22.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line22.LineWeight = 2!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 5.634722!
        Me.Line22.Width = 7.3125!
        Me.Line22.X1 = 0.125!
        Me.Line22.X2 = 7.4375!
        Me.Line22.Y1 = 5.634722!
        Me.Line22.Y2 = 5.634722!
        '
        'Line
        '
        Me.Line.Height = 11.125!
        Me.Line.Left = 3.8125!
        Me.Line.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line.LineWeight = 2!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.07222223!
        Me.Line.Width = 0!
        Me.Line.X1 = 3.8125!
        Me.Line.X2 = 3.8125!
        Me.Line.Y1 = 0.07222223!
        Me.Line.Y2 = 11.19722!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.25!
        Me.Line1.LineWeight = 3!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.5097222!
        Me.Line1.Width = 3.375!
        Me.Line1.X1 = 0.25!
        Me.Line1.X2 = 3.625!
        Me.Line1.Y1 = 0.5097222!
        Me.Line1.Y2 = 0.5097222!
        '
        'Line3
        '
        Me.Line3.Height = 0!
        Me.Line3.Left = 0.25!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 2.134722!
        Me.Line3.Width = 3.375!
        Me.Line3.X1 = 0.25!
        Me.Line3.X2 = 3.625!
        Me.Line3.Y1 = 2.134722!
        Me.Line3.Y2 = 2.134722!
        '
        'Line4
        '
        Me.Line4.Height = 0!
        Me.Line4.Left = 0.25!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 2.426389!
        Me.Line4.Width = 3.375!
        Me.Line4.X1 = 0.25!
        Me.Line4.X2 = 3.625!
        Me.Line4.Y1 = 2.426389!
        Me.Line4.Y2 = 2.426389!
        '
        'Line5
        '
        Me.Line5.Height = 0!
        Me.Line5.Left = 0.25!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 2.718055!
        Me.Line5.Width = 3.375!
        Me.Line5.X1 = 0.25!
        Me.Line5.X2 = 3.625!
        Me.Line5.Y1 = 2.718055!
        Me.Line5.Y2 = 2.718055!
        '
        'Line6
        '
        Me.Line6.Height = 0!
        Me.Line6.Left = 0.25!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 3.009722!
        Me.Line6.Width = 3.375!
        Me.Line6.X1 = 0.25!
        Me.Line6.X2 = 3.625!
        Me.Line6.Y1 = 3.009722!
        Me.Line6.Y2 = 3.009722!
        '
        'Line7
        '
        Me.Line7.Height = 0!
        Me.Line7.Left = 0.25!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 3.301389!
        Me.Line7.Width = 3.375!
        Me.Line7.X1 = 0.25!
        Me.Line7.X2 = 3.625!
        Me.Line7.Y1 = 3.301389!
        Me.Line7.Y2 = 3.301389!
        '
        'Line8
        '
        Me.Line8.Height = 0!
        Me.Line8.Left = 0.25!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 3.593055!
        Me.Line8.Width = 3.375!
        Me.Line8.X1 = 0.25!
        Me.Line8.X2 = 3.625!
        Me.Line8.Y1 = 3.593055!
        Me.Line8.Y2 = 3.593055!
        '
        'Line9
        '
        Me.Line9.Height = 0!
        Me.Line9.Left = 0.25!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 3.884722!
        Me.Line9.Width = 3.375!
        Me.Line9.X1 = 0.25!
        Me.Line9.X2 = 3.625!
        Me.Line9.Y1 = 3.884722!
        Me.Line9.Y2 = 3.884722!
        '
        'Line10
        '
        Me.Line10.Height = 0!
        Me.Line10.Left = 0.25!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 4.176389!
        Me.Line10.Width = 3.375!
        Me.Line10.X1 = 0.25!
        Me.Line10.X2 = 3.625!
        Me.Line10.Y1 = 4.176389!
        Me.Line10.Y2 = 4.176389!
        '
        'Line11
        '
        Me.Line11.Height = 0!
        Me.Line11.Left = 0.25!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 4.468056!
        Me.Line11.Width = 3.375!
        Me.Line11.X1 = 0.25!
        Me.Line11.X2 = 3.625!
        Me.Line11.Y1 = 4.468056!
        Me.Line11.Y2 = 4.468056!
        '
        'Line12
        '
        Me.Line12.Height = 0!
        Me.Line12.Left = 0.25!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 4.759722!
        Me.Line12.Width = 3.375!
        Me.Line12.X1 = 0.25!
        Me.Line12.X2 = 3.625!
        Me.Line12.Y1 = 4.759722!
        Me.Line12.Y2 = 4.759722!
        '
        'Line13
        '
        Me.Line13.Height = 5.25!
        Me.Line13.Left = 0.25!
        Me.Line13.LineWeight = 3!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.1972222!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 0.25!
        Me.Line13.X2 = 0.25!
        Me.Line13.Y1 = 0.1972222!
        Me.Line13.Y2 = 5.447222!
        '
        'Line14
        '
        Me.Line14.Height = 5.25!
        Me.Line14.Left = 3.625!
        Me.Line14.LineWeight = 3!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.1972222!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 3.625!
        Me.Line14.X2 = 3.625!
        Me.Line14.Y1 = 0.1972222!
        Me.Line14.Y2 = 5.447222!
        '
        'Line15
        '
        Me.Line15.Height = 0!
        Me.Line15.Left = 0.25!
        Me.Line15.LineWeight = 3!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 5.447222!
        Me.Line15.Width = 3.375!
        Me.Line15.X1 = 0.25!
        Me.Line15.X2 = 3.625!
        Me.Line15.Y1 = 5.447222!
        Me.Line15.Y2 = 5.447222!
        '
        'Line16
        '
        Me.Line16.Height = 0!
        Me.Line16.Left = 0.25!
        Me.Line16.LineWeight = 3!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.1972222!
        Me.Line16.Width = 3.375!
        Me.Line16.X1 = 0.25!
        Me.Line16.X2 = 3.625!
        Me.Line16.Y1 = 0.1972222!
        Me.Line16.Y2 = 0.1972222!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.25!
        Me.Line2.LineWeight = 3!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.947222!
        Me.Line2.Width = 3.375!
        Me.Line2.X1 = 0.25!
        Me.Line2.X2 = 3.625!
        Me.Line2.Y1 = 1.947222!
        Me.Line2.Y2 = 1.947222!
        '
        'Line17
        '
        Me.Line17.Height = 0!
        Me.Line17.Left = 0.25!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.9892222!
        Me.Line17.Width = 3.375!
        Me.Line17.X1 = 0.25!
        Me.Line17.X2 = 3.625!
        Me.Line17.Y1 = 0.9892222!
        Me.Line17.Y2 = 0.9892222!
        '
        'Line18
        '
        Me.Line18.Height = 0!
        Me.Line18.Left = 0.25!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 1.468056!
        Me.Line18.Width = 3.375!
        Me.Line18.X1 = 0.25!
        Me.Line18.X2 = 3.625!
        Me.Line18.Y1 = 1.468056!
        Me.Line18.Y2 = 1.468056!
        '
        'Line19
        '
        Me.Line19.Height = 0!
        Me.Line19.Left = 0.25!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.6972222!
        Me.Line19.Width = 3.375!
        Me.Line19.X1 = 0.25!
        Me.Line19.X2 = 3.625!
        Me.Line19.Y1 = 0.6972222!
        Me.Line19.Y2 = 0.6972222!
        '
        'Line20
        '
        Me.Line20.Height = 0!
        Me.Line20.Left = 0.25!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 1.176722!
        Me.Line20.Width = 3.3755!
        Me.Line20.X1 = 0.25!
        Me.Line20.X2 = 3.6255!
        Me.Line20.Y1 = 1.176722!
        Me.Line20.Y2 = 1.176722!
        '
        'Line21
        '
        Me.Line21.Height = 0!
        Me.Line21.Left = 0.25!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 1.655722!
        Me.Line21.Width = 3.3755!
        Me.Line21.X1 = 0.25!
        Me.Line21.X2 = 3.6255!
        Me.Line21.Y1 = 1.655722!
        Me.Line21.Y2 = 1.655722!
        '
        'Line23
        '
        Me.Line23.Height = 0.9579999!
        Me.Line23.Left = 1.9375!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 0.5097222!
        Me.Line23.Width = 0!
        Me.Line23.X1 = 1.9375!
        Me.Line23.X2 = 1.9375!
        Me.Line23.Y1 = 0.5097222!
        Me.Line23.Y2 = 1.467722!
        '
        'Line24
        '
        Me.Line24.Height = 0.4580001!
        Me.Line24.Left = 2.4375!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 1.467722!
        Me.Line24.Width = 0!
        Me.Line24.X1 = 2.4375!
        Me.Line24.X2 = 2.4375!
        Me.Line24.Y1 = 1.467722!
        Me.Line24.Y2 = 1.925722!
        '
        'Line25
        '
        Me.Line25.Height = 2.8125!
        Me.Line25.Left = 1.5!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 1.947222!
        Me.Line25.Width = 0!
        Me.Line25.X1 = 1.5!
        Me.Line25.X2 = 1.5!
        Me.Line25.Y1 = 1.947222!
        Me.Line25.Y2 = 4.759722!
        '
        'Line26
        '
        Me.Line26.Height = 2.8125!
        Me.Line26.Left = 2!
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 1.947222!
        Me.Line26.Width = 0!
        Me.Line26.X1 = 2!
        Me.Line26.X2 = 2!
        Me.Line26.Y1 = 1.947222!
        Me.Line26.Y2 = 4.759722!
        '
        'Line27
        '
        Me.Line27.Height = 2.8125!
        Me.Line27.Left = 2.5!
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 1.947222!
        Me.Line27.Width = 0!
        Me.Line27.X1 = 2.5!
        Me.Line27.X2 = 2.5!
        Me.Line27.Y1 = 1.947222!
        Me.Line27.Y2 = 4.759722!
        '
        'Line28
        '
        Me.Line28.Height = 2.8125!
        Me.Line28.Left = 3.0625!
        Me.Line28.LineWeight = 1!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 1.947722!
        Me.Line28.Width = 0!
        Me.Line28.X1 = 3.0625!
        Me.Line28.X2 = 3.0625!
        Me.Line28.Y1 = 1.947722!
        Me.Line28.Y2 = 4.760222!
        '
        'Line29
        '
        Me.Line29.Height = 2.8125!
        Me.Line29.Left = 1!
        Me.Line29.LineWeight = 1!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 1.947222!
        Me.Line29.Width = 0!
        Me.Line29.X1 = 1!
        Me.Line29.X2 = 1!
        Me.Line29.Y1 = 1.947222!
        Me.Line29.Y2 = 4.759722!
        '
        'Barcode1
        '
        Me.Barcode1.CheckSumEnabled = false
        Me.Barcode1.DataField = "バーコード1"
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8!)
        Me.Barcode1.Height = 0.25!
        Me.Barcode1.Left = 0.875!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.QuietZoneBottom = 0!
        Me.Barcode1.QuietZoneLeft = 0!
        Me.Barcode1.QuietZoneRight = 0!
        Me.Barcode1.QuietZoneTop = 0!
        Me.Barcode1.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode1.Text = "Barcode"
        Me.Barcode1.Top = 4.884722!
        Me.Barcode1.Width = 2.125!
        '
        'txtBarcode1
        '
        Me.txtBarcode1.DataField = "バーコード1"
        Me.txtBarcode1.Height = 0.1875!
        Me.txtBarcode1.Left = 0.875!
        Me.txtBarcode1.Name = "txtBarcode1"
        Me.txtBarcode1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtBarcode1.Text = "バーコード1"
        Me.txtBarcode1.Top = 5.134722!
        Me.txtBarcode1.Width = 2.125!
        '
        'txtWH_AMT2
        '
        Me.txtWH_AMT2.DataField = "WH_AMT2"
        Me.txtWH_AMT2.Height = 0.313!
        Me.txtWH_AMT2.Left = 6.188!
        Me.txtWH_AMT2.Name = "txtWH_AMT2"
        Me.txtWH_AMT2.OutputFormat = resources.GetString("txtWH_AMT2.OutputFormat")
        Me.txtWH_AMT2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_AMT2.Text = "入庫数2"
        Me.txtWH_AMT2.Top = 1.656222!
        Me.txtWH_AMT2.Width = 1.187!
        '
        'txtWH_DT2
        '
        Me.txtWH_DT2.DataField = "WH_DT2"
        Me.txtWH_DT2.Height = 0.313!
        Me.txtWH_DT2.Left = 4!
        Me.txtWH_DT2.Name = "txtWH_DT2"
        Me.txtWH_DT2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_DT2.Text = "入庫日2"
        Me.txtWH_DT2.Top = 1.656222!
        Me.txtWH_DT2.Width = 2.1875!
        '
        'txtINDICATE_NO2
        '
        Me.txtINDICATE_NO2.DataField = "INDICATE_NO2"
        Me.txtINDICATE_NO2.Height = 0.313!
        Me.txtINDICATE_NO2.Left = 5.688!
        Me.txtINDICATE_NO2.Name = "txtINDICATE_NO2"
        Me.txtINDICATE_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO2.Text = "指示NO2"
        Me.txtINDICATE_NO2.Top = 1.177222!
        Me.txtINDICATE_NO2.Width = 1.688!
        '
        'txtCOMPANY_NO2
        '
        Me.txtCOMPANY_NO2.DataField = "COMPANY_NO2"
        Me.txtCOMPANY_NO2.Height = 0.3125!
        Me.txtCOMPANY_NO2.Left = 4!
        Me.txtCOMPANY_NO2.Name = "txtCOMPANY_NO2"
        Me.txtCOMPANY_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO2.Text = "社内NO2"
        Me.txtCOMPANY_NO2.Top = 1.177222!
        Me.txtCOMPANY_NO2.Width = 1.6875!
        '
        'txt名称2
        '
        Me.txt名称2.DataField = "名称2"
        Me.txt名称2.Height = 0.3125!
        Me.txt名称2.Left = 5.6875!
        Me.txt名称2.Name = "txt名称2"
        Me.txt名称2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt名称2.Text = "名称2"
        Me.txt名称2.Top = 0.6972222!
        Me.txt名称2.Width = 1.6875!
        '
        'txtCATALOG_NO2
        '
        Me.txtCATALOG_NO2.DataField = "CATALOG_NO2"
        Me.txtCATALOG_NO2.Height = 0.3125!
        Me.txtCATALOG_NO2.Left = 4!
        Me.txtCATALOG_NO2.Name = "txtCATALOG_NO2"
        Me.txtCATALOG_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO2.Text = "カタログ番号2"
        Me.txtCATALOG_NO2.Top = 0.6972222!
        Me.txtCATALOG_NO2.Width = 1.6875!
        '
        'Label13
        '
        Me.Label13.Height = 0.1875!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 4.75!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label13.Text = "出庫数"
        Me.Label13.Top = 1.947222!
        Me.Label13.Width = 0.5!
        '
        'Label14
        '
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 5.25!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label14.Text = "在庫数"
        Me.Label14.Top = 1.947222!
        Me.Label14.Width = 0.5!
        '
        'Label15
        '
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 5.75!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label15.Text = "担当"
        Me.Label15.Top = 1.947222!
        Me.Label15.Width = 0.5!
        '
        'Label16
        '
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 6.25!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label16.Text = "出庫P/N"
        Me.Label16.Top = 1.947222!
        Me.Label16.Width = 0.5625!
        '
        'Label17
        '
        Me.Label17.Height = 0.1875!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 6.8125!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label17.Text = "指示NO"
        Me.Label17.Top = 1.947222!
        Me.Label17.Width = 0.5625!
        '
        'Label18
        '
        Me.Label18.Height = 0.1875!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 4!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label18.Text = "出庫年月日"
        Me.Label18.Top = 1.947222!
        Me.Label18.Width = 0.75!
        '
        'Label19
        '
        Me.Label19.Height = 0.1875!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 6.1875!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label19.Text = "入庫数"
        Me.Label19.Top = 1.467722!
        Me.Label19.Width = 1.1875!
        '
        'Label20
        '
        Me.Label20.Height = 0.188!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 4!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label20.Text = "入庫日"
        Me.Label20.Top = 1.468222!
        Me.Label20.Width = 2.1875!
        '
        'Label21
        '
        Me.Label21.Height = 0.188!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 5.688!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label21.Text = "ロット番号"
        Me.Label21.Top = 0.9892222!
        Me.Label21.Width = 1.688!
        '
        'Label22
        '
        Me.Label22.Height = 0.188!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 4!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label22.Text = "社内NO"
        Me.Label22.Top = 0.9892222!
        Me.Label22.Width = 1.688!
        '
        'Label23
        '
        Me.Label23.Height = 0.188!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 5.6875!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label23.Text = "名称"
        Me.Label23.Top = 0.5097222!
        Me.Label23.Width = 1.688!
        '
        'Label24
        '
        Me.Label24.Height = 0.188!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 4!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label24.Text = "カタログ番号"
        Me.Label24.Top = 0.5102222!
        Me.Label24.Width = 1.688!
        '
        'Label25
        '
        Me.Label25.Height = 0.3125!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 4!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weig" & _
            "ht: bold; text-align: center; vertical-align: middle"
        Me.Label25.Text = "医療部品現品票"
        Me.Label25.Top = 0.1972222!
        Me.Label25.Width = 3.375!
        '
        'Line30
        '
        Me.Line30.Height = 0!
        Me.Line30.Left = 4!
        Me.Line30.LineWeight = 3!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 0.5097222!
        Me.Line30.Width = 3.375!
        Me.Line30.X1 = 4!
        Me.Line30.X2 = 7.375!
        Me.Line30.Y1 = 0.5097222!
        Me.Line30.Y2 = 0.5097222!
        '
        'Line31
        '
        Me.Line31.Height = 0!
        Me.Line31.Left = 4!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 2.134722!
        Me.Line31.Width = 3.375!
        Me.Line31.X1 = 4!
        Me.Line31.X2 = 7.375!
        Me.Line31.Y1 = 2.134722!
        Me.Line31.Y2 = 2.134722!
        '
        'Line32
        '
        Me.Line32.Height = 0!
        Me.Line32.Left = 4!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 2.426389!
        Me.Line32.Width = 3.375!
        Me.Line32.X1 = 4!
        Me.Line32.X2 = 7.375!
        Me.Line32.Y1 = 2.426389!
        Me.Line32.Y2 = 2.426389!
        '
        'Line33
        '
        Me.Line33.Height = 0!
        Me.Line33.Left = 4!
        Me.Line33.LineWeight = 1!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 2.718055!
        Me.Line33.Width = 3.375!
        Me.Line33.X1 = 4!
        Me.Line33.X2 = 7.375!
        Me.Line33.Y1 = 2.718055!
        Me.Line33.Y2 = 2.718055!
        '
        'Line34
        '
        Me.Line34.Height = 0!
        Me.Line34.Left = 4!
        Me.Line34.LineWeight = 1!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 3.009722!
        Me.Line34.Width = 3.375!
        Me.Line34.X1 = 4!
        Me.Line34.X2 = 7.375!
        Me.Line34.Y1 = 3.009722!
        Me.Line34.Y2 = 3.009722!
        '
        'Line35
        '
        Me.Line35.Height = 0!
        Me.Line35.Left = 4!
        Me.Line35.LineWeight = 1!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 3.301389!
        Me.Line35.Width = 3.375!
        Me.Line35.X1 = 4!
        Me.Line35.X2 = 7.375!
        Me.Line35.Y1 = 3.301389!
        Me.Line35.Y2 = 3.301389!
        '
        'Line36
        '
        Me.Line36.Height = 0!
        Me.Line36.Left = 4!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 3.593055!
        Me.Line36.Width = 3.375!
        Me.Line36.X1 = 4!
        Me.Line36.X2 = 7.375!
        Me.Line36.Y1 = 3.593055!
        Me.Line36.Y2 = 3.593055!
        '
        'Line37
        '
        Me.Line37.Height = 0!
        Me.Line37.Left = 4!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 3.884722!
        Me.Line37.Width = 3.375!
        Me.Line37.X1 = 4!
        Me.Line37.X2 = 7.375!
        Me.Line37.Y1 = 3.884722!
        Me.Line37.Y2 = 3.884722!
        '
        'Line38
        '
        Me.Line38.Height = 0!
        Me.Line38.Left = 4!
        Me.Line38.LineWeight = 1!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 4.176389!
        Me.Line38.Width = 3.375!
        Me.Line38.X1 = 4!
        Me.Line38.X2 = 7.375!
        Me.Line38.Y1 = 4.176389!
        Me.Line38.Y2 = 4.176389!
        '
        'Line39
        '
        Me.Line39.Height = 0!
        Me.Line39.Left = 4!
        Me.Line39.LineWeight = 1!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 4.468056!
        Me.Line39.Width = 3.375!
        Me.Line39.X1 = 4!
        Me.Line39.X2 = 7.375!
        Me.Line39.Y1 = 4.468056!
        Me.Line39.Y2 = 4.468056!
        '
        'Line40
        '
        Me.Line40.Height = 0!
        Me.Line40.Left = 4!
        Me.Line40.LineWeight = 1!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 4.759722!
        Me.Line40.Width = 3.375!
        Me.Line40.X1 = 4!
        Me.Line40.X2 = 7.375!
        Me.Line40.Y1 = 4.759722!
        Me.Line40.Y2 = 4.759722!
        '
        'Line41
        '
        Me.Line41.Height = 5.25!
        Me.Line41.Left = 4!
        Me.Line41.LineWeight = 3!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 0.1972222!
        Me.Line41.Width = 0!
        Me.Line41.X1 = 4!
        Me.Line41.X2 = 4!
        Me.Line41.Y1 = 0.1972222!
        Me.Line41.Y2 = 5.447222!
        '
        'Line42
        '
        Me.Line42.Height = 5.25!
        Me.Line42.Left = 7.375!
        Me.Line42.LineWeight = 3!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 0.1972222!
        Me.Line42.Width = 0!
        Me.Line42.X1 = 7.375!
        Me.Line42.X2 = 7.375!
        Me.Line42.Y1 = 0.1972222!
        Me.Line42.Y2 = 5.447222!
        '
        'Line43
        '
        Me.Line43.Height = 0!
        Me.Line43.Left = 4!
        Me.Line43.LineWeight = 3!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 5.447222!
        Me.Line43.Width = 3.375!
        Me.Line43.X1 = 4!
        Me.Line43.X2 = 7.375!
        Me.Line43.Y1 = 5.447222!
        Me.Line43.Y2 = 5.447222!
        '
        'Line44
        '
        Me.Line44.Height = 0!
        Me.Line44.Left = 4!
        Me.Line44.LineWeight = 3!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 0.1972222!
        Me.Line44.Width = 3.375!
        Me.Line44.X1 = 4!
        Me.Line44.X2 = 7.375!
        Me.Line44.Y1 = 0.1972222!
        Me.Line44.Y2 = 0.1972222!
        '
        'Line45
        '
        Me.Line45.Height = 0!
        Me.Line45.Left = 4!
        Me.Line45.LineWeight = 3!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 1.947222!
        Me.Line45.Width = 3.375!
        Me.Line45.X1 = 4!
        Me.Line45.X2 = 7.375!
        Me.Line45.Y1 = 1.947222!
        Me.Line45.Y2 = 1.947222!
        '
        'Line46
        '
        Me.Line46.Height = 0!
        Me.Line46.Left = 4!
        Me.Line46.LineWeight = 1!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 0.9892222!
        Me.Line46.Width = 3.375!
        Me.Line46.X1 = 4!
        Me.Line46.X2 = 7.375!
        Me.Line46.Y1 = 0.9892222!
        Me.Line46.Y2 = 0.9892222!
        '
        'Line47
        '
        Me.Line47.Height = 0!
        Me.Line47.Left = 4!
        Me.Line47.LineWeight = 1!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 1.468056!
        Me.Line47.Width = 3.375!
        Me.Line47.X1 = 4!
        Me.Line47.X2 = 7.375!
        Me.Line47.Y1 = 1.468056!
        Me.Line47.Y2 = 1.468056!
        '
        'Line48
        '
        Me.Line48.Height = 0!
        Me.Line48.Left = 4!
        Me.Line48.LineWeight = 1!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 0.6972222!
        Me.Line48.Width = 3.375!
        Me.Line48.X1 = 4!
        Me.Line48.X2 = 7.375!
        Me.Line48.Y1 = 0.6972222!
        Me.Line48.Y2 = 0.6972222!
        '
        'Line49
        '
        Me.Line49.Height = 0!
        Me.Line49.Left = 4!
        Me.Line49.LineWeight = 1!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 1.176722!
        Me.Line49.Width = 3.3755!
        Me.Line49.X1 = 4!
        Me.Line49.X2 = 7.3755!
        Me.Line49.Y1 = 1.176722!
        Me.Line49.Y2 = 1.176722!
        '
        'Line50
        '
        Me.Line50.Height = 0!
        Me.Line50.Left = 4!
        Me.Line50.LineWeight = 1!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 1.655722!
        Me.Line50.Width = 3.3755!
        Me.Line50.X1 = 4!
        Me.Line50.X2 = 7.3755!
        Me.Line50.Y1 = 1.655722!
        Me.Line50.Y2 = 1.655722!
        '
        'Line51
        '
        Me.Line51.Height = 0.9579999!
        Me.Line51.Left = 5.6875!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 0.5097222!
        Me.Line51.Width = 0!
        Me.Line51.X1 = 5.6875!
        Me.Line51.X2 = 5.6875!
        Me.Line51.Y1 = 0.5097222!
        Me.Line51.Y2 = 1.467722!
        '
        'Line52
        '
        Me.Line52.Height = 0.4580001!
        Me.Line52.Left = 6.1875!
        Me.Line52.LineWeight = 1!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 1.467722!
        Me.Line52.Width = 0!
        Me.Line52.X1 = 6.1875!
        Me.Line52.X2 = 6.1875!
        Me.Line52.Y1 = 1.467722!
        Me.Line52.Y2 = 1.925722!
        '
        'Line53
        '
        Me.Line53.Height = 2.8125!
        Me.Line53.Left = 5.25!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 1.947222!
        Me.Line53.Width = 0!
        Me.Line53.X1 = 5.25!
        Me.Line53.X2 = 5.25!
        Me.Line53.Y1 = 1.947222!
        Me.Line53.Y2 = 4.759722!
        '
        'Line54
        '
        Me.Line54.Height = 2.8125!
        Me.Line54.Left = 5.75!
        Me.Line54.LineWeight = 1!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 1.947222!
        Me.Line54.Width = 0!
        Me.Line54.X1 = 5.75!
        Me.Line54.X2 = 5.75!
        Me.Line54.Y1 = 1.947222!
        Me.Line54.Y2 = 4.759722!
        '
        'Line55
        '
        Me.Line55.Height = 2.8125!
        Me.Line55.Left = 6.25!
        Me.Line55.LineWeight = 1!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 1.947222!
        Me.Line55.Width = 0!
        Me.Line55.X1 = 6.25!
        Me.Line55.X2 = 6.25!
        Me.Line55.Y1 = 1.947222!
        Me.Line55.Y2 = 4.759722!
        '
        'Line56
        '
        Me.Line56.Height = 2.8125!
        Me.Line56.Left = 6.8125!
        Me.Line56.LineWeight = 1!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 1.947722!
        Me.Line56.Width = 0!
        Me.Line56.X1 = 6.8125!
        Me.Line56.X2 = 6.8125!
        Me.Line56.Y1 = 1.947722!
        Me.Line56.Y2 = 4.760222!
        '
        'Line57
        '
        Me.Line57.Height = 2.8125!
        Me.Line57.Left = 4.75!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 1.947222!
        Me.Line57.Width = 0!
        Me.Line57.X1 = 4.75!
        Me.Line57.X2 = 4.75!
        Me.Line57.Y1 = 1.947222!
        Me.Line57.Y2 = 4.759722!
        '
        'txtWH_AMT3
        '
        Me.txtWH_AMT3.DataField = "WH_AMT3"
        Me.txtWH_AMT3.Height = 0.313!
        Me.txtWH_AMT3.Left = 2.4375!
        Me.txtWH_AMT3.Name = "txtWH_AMT3"
        Me.txtWH_AMT3.OutputFormat = resources.GetString("txtWH_AMT3.OutputFormat")
        Me.txtWH_AMT3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_AMT3.Text = "入庫数3"
        Me.txtWH_AMT3.Top = 7.259722!
        Me.txtWH_AMT3.Width = 1.187!
        '
        'txtWH_DT3
        '
        Me.txtWH_DT3.DataField = "WH_DT3"
        Me.txtWH_DT3.Height = 0.313!
        Me.txtWH_DT3.Left = 0.25!
        Me.txtWH_DT3.Name = "txtWH_DT3"
        Me.txtWH_DT3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_DT3.Text = "入庫日3"
        Me.txtWH_DT3.Top = 7.281222!
        Me.txtWH_DT3.Width = 2.1875!
        '
        'txtINDICATE_NO3
        '
        Me.txtINDICATE_NO3.DataField = "INDICATE_NO3"
        Me.txtINDICATE_NO3.Height = 0.313!
        Me.txtINDICATE_NO3.Left = 1.938!
        Me.txtINDICATE_NO3.Name = "txtINDICATE_NO3"
        Me.txtINDICATE_NO3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO3.Text = "指示NO3"
        Me.txtINDICATE_NO3.Top = 6.802222!
        Me.txtINDICATE_NO3.Width = 1.688!
        '
        'txtCOMPANY_NO3
        '
        Me.txtCOMPANY_NO3.DataField = "COMPANY_NO3"
        Me.txtCOMPANY_NO3.Height = 0.3125!
        Me.txtCOMPANY_NO3.Left = 0.25!
        Me.txtCOMPANY_NO3.Name = "txtCOMPANY_NO3"
        Me.txtCOMPANY_NO3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO3.Text = "社内NO3"
        Me.txtCOMPANY_NO3.Top = 6.802222!
        Me.txtCOMPANY_NO3.Width = 1.6875!
        '
        'txt名称3
        '
        Me.txt名称3.DataField = "名称3"
        Me.txt名称3.Height = 0.3125!
        Me.txt名称3.Left = 1.9375!
        Me.txt名称3.Name = "txt名称3"
        Me.txt名称3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt名称3.Text = "名称3"
        Me.txt名称3.Top = 6.322222!
        Me.txt名称3.Width = 1.6875!
        '
        'txtCATALOG_NO3
        '
        Me.txtCATALOG_NO3.DataField = "CATALOG_NO3"
        Me.txtCATALOG_NO3.Height = 0.3125!
        Me.txtCATALOG_NO3.Left = 0.25!
        Me.txtCATALOG_NO3.Name = "txtCATALOG_NO3"
        Me.txtCATALOG_NO3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO3.Text = "カタログ番号3"
        Me.txtCATALOG_NO3.Top = 6.322222!
        Me.txtCATALOG_NO3.Width = 1.6875!
        '
        'Label26
        '
        Me.Label26.Height = 0.1875!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 1!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label26.Text = "出庫数"
        Me.Label26.Top = 7.572222!
        Me.Label26.Width = 0.5!
        '
        'Label27
        '
        Me.Label27.Height = 0.1875!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 1.5!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label27.Text = "在庫数"
        Me.Label27.Top = 7.572222!
        Me.Label27.Width = 0.5!
        '
        'Label28
        '
        Me.Label28.Height = 0.1875!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 2!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label28.Text = "担当"
        Me.Label28.Top = 7.572222!
        Me.Label28.Width = 0.5!
        '
        'Label29
        '
        Me.Label29.Height = 0.1875!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 2.5!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label29.Text = "出庫P/N"
        Me.Label29.Top = 7.572222!
        Me.Label29.Width = 0.5625!
        '
        'Label30
        '
        Me.Label30.Height = 0.1875!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 3.0625!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label30.Text = "指示NO"
        Me.Label30.Top = 7.572222!
        Me.Label30.Width = 0.5625!
        '
        'Label31
        '
        Me.Label31.Height = 0.1875!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.25!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label31.Text = "出庫年月日"
        Me.Label31.Top = 7.572222!
        Me.Label31.Width = 0.75!
        '
        'Label32
        '
        Me.Label32.Height = 0.1875!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 2.4375!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label32.Text = "入庫数"
        Me.Label32.Top = 7.092722!
        Me.Label32.Width = 1.1875!
        '
        'Label33
        '
        Me.Label33.Height = 0.188!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.25!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label33.Text = "入庫日"
        Me.Label33.Top = 7.093223!
        Me.Label33.Width = 2.1875!
        '
        'Label34
        '
        Me.Label34.Height = 0.188!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 1.938!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label34.Text = "ロット番号"
        Me.Label34.Top = 6.614221!
        Me.Label34.Width = 1.688!
        '
        'Label35
        '
        Me.Label35.Height = 0.188!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 0.25!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label35.Text = "社内NO"
        Me.Label35.Top = 6.614221!
        Me.Label35.Width = 1.688!
        '
        'Label36
        '
        Me.Label36.Height = 0.188!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 1.9375!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label36.Text = "名称"
        Me.Label36.Top = 6.134722!
        Me.Label36.Width = 1.688!
        '
        'Label37
        '
        Me.Label37.Height = 0.188!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 0.25!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label37.Text = "カタログ番号"
        Me.Label37.Top = 6.135222!
        Me.Label37.Width = 1.688!
        '
        'Label38
        '
        Me.Label38.Height = 0.3125!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 0.25!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weig" & _
            "ht: bold; text-align: center; vertical-align: middle"
        Me.Label38.Text = "医療部品現品票"
        Me.Label38.Top = 5.822222!
        Me.Label38.Width = 3.375!
        '
        'Line58
        '
        Me.Line58.Height = 0!
        Me.Line58.Left = 0.25!
        Me.Line58.LineWeight = 3!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 6.134722!
        Me.Line58.Width = 3.375!
        Me.Line58.X1 = 0.25!
        Me.Line58.X2 = 3.625!
        Me.Line58.Y1 = 6.134722!
        Me.Line58.Y2 = 6.134722!
        '
        'Line59
        '
        Me.Line59.Height = 0!
        Me.Line59.Left = 0.25!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 7.759722!
        Me.Line59.Width = 3.375!
        Me.Line59.X1 = 0.25!
        Me.Line59.X2 = 3.625!
        Me.Line59.Y1 = 7.759722!
        Me.Line59.Y2 = 7.759722!
        '
        'Line60
        '
        Me.Line60.Height = 0!
        Me.Line60.Left = 0.25!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 8.051389!
        Me.Line60.Width = 3.375!
        Me.Line60.X1 = 0.25!
        Me.Line60.X2 = 3.625!
        Me.Line60.Y1 = 8.051389!
        Me.Line60.Y2 = 8.051389!
        '
        'Line61
        '
        Me.Line61.Height = 0!
        Me.Line61.Left = 0.25!
        Me.Line61.LineWeight = 1!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 8.343056!
        Me.Line61.Width = 3.375!
        Me.Line61.X1 = 0.25!
        Me.Line61.X2 = 3.625!
        Me.Line61.Y1 = 8.343056!
        Me.Line61.Y2 = 8.343056!
        '
        'Line62
        '
        Me.Line62.Height = 0!
        Me.Line62.Left = 0.25!
        Me.Line62.LineWeight = 1!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 8.634722!
        Me.Line62.Width = 3.375!
        Me.Line62.X1 = 0.25!
        Me.Line62.X2 = 3.625!
        Me.Line62.Y1 = 8.634722!
        Me.Line62.Y2 = 8.634722!
        '
        'Line63
        '
        Me.Line63.Height = 0!
        Me.Line63.Left = 0.25!
        Me.Line63.LineWeight = 1!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 8.926389!
        Me.Line63.Width = 3.375!
        Me.Line63.X1 = 0.25!
        Me.Line63.X2 = 3.625!
        Me.Line63.Y1 = 8.926389!
        Me.Line63.Y2 = 8.926389!
        '
        'Line64
        '
        Me.Line64.Height = 0!
        Me.Line64.Left = 0.25!
        Me.Line64.LineWeight = 1!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 9.218056!
        Me.Line64.Width = 3.375!
        Me.Line64.X1 = 0.25!
        Me.Line64.X2 = 3.625!
        Me.Line64.Y1 = 9.218056!
        Me.Line64.Y2 = 9.218056!
        '
        'Line65
        '
        Me.Line65.Height = 0!
        Me.Line65.Left = 0.25!
        Me.Line65.LineWeight = 1!
        Me.Line65.Name = "Line65"
        Me.Line65.Top = 9.509722!
        Me.Line65.Width = 3.375!
        Me.Line65.X1 = 0.25!
        Me.Line65.X2 = 3.625!
        Me.Line65.Y1 = 9.509722!
        Me.Line65.Y2 = 9.509722!
        '
        'Line66
        '
        Me.Line66.Height = 0!
        Me.Line66.Left = 0.25!
        Me.Line66.LineWeight = 1!
        Me.Line66.Name = "Line66"
        Me.Line66.Top = 9.801389!
        Me.Line66.Width = 3.375!
        Me.Line66.X1 = 0.25!
        Me.Line66.X2 = 3.625!
        Me.Line66.Y1 = 9.801389!
        Me.Line66.Y2 = 9.801389!
        '
        'Line67
        '
        Me.Line67.Height = 0!
        Me.Line67.Left = 0.25!
        Me.Line67.LineWeight = 1!
        Me.Line67.Name = "Line67"
        Me.Line67.Top = 10.09306!
        Me.Line67.Width = 3.375!
        Me.Line67.X1 = 0.25!
        Me.Line67.X2 = 3.625!
        Me.Line67.Y1 = 10.09306!
        Me.Line67.Y2 = 10.09306!
        '
        'Line68
        '
        Me.Line68.Height = 0!
        Me.Line68.Left = 0.25!
        Me.Line68.LineWeight = 1!
        Me.Line68.Name = "Line68"
        Me.Line68.Top = 10.38472!
        Me.Line68.Width = 3.375!
        Me.Line68.X1 = 0.25!
        Me.Line68.X2 = 3.625!
        Me.Line68.Y1 = 10.38472!
        Me.Line68.Y2 = 10.38472!
        '
        'Line69
        '
        Me.Line69.Height = 5.25!
        Me.Line69.Left = 0.25!
        Me.Line69.LineWeight = 3!
        Me.Line69.Name = "Line69"
        Me.Line69.Top = 5.822222!
        Me.Line69.Width = 0!
        Me.Line69.X1 = 0.25!
        Me.Line69.X2 = 0.25!
        Me.Line69.Y1 = 5.822222!
        Me.Line69.Y2 = 11.07222!
        '
        'Line70
        '
        Me.Line70.Height = 5.25!
        Me.Line70.Left = 3.625!
        Me.Line70.LineWeight = 3!
        Me.Line70.Name = "Line70"
        Me.Line70.Top = 5.822222!
        Me.Line70.Width = 0!
        Me.Line70.X1 = 3.625!
        Me.Line70.X2 = 3.625!
        Me.Line70.Y1 = 5.822222!
        Me.Line70.Y2 = 11.07222!
        '
        'Line71
        '
        Me.Line71.Height = 0!
        Me.Line71.Left = 0.25!
        Me.Line71.LineWeight = 3!
        Me.Line71.Name = "Line71"
        Me.Line71.Top = 11.07222!
        Me.Line71.Width = 3.375!
        Me.Line71.X1 = 0.25!
        Me.Line71.X2 = 3.625!
        Me.Line71.Y1 = 11.07222!
        Me.Line71.Y2 = 11.07222!
        '
        'Line72
        '
        Me.Line72.Height = 0!
        Me.Line72.Left = 0.25!
        Me.Line72.LineWeight = 3!
        Me.Line72.Name = "Line72"
        Me.Line72.Top = 5.822222!
        Me.Line72.Width = 3.375!
        Me.Line72.X1 = 0.25!
        Me.Line72.X2 = 3.625!
        Me.Line72.Y1 = 5.822222!
        Me.Line72.Y2 = 5.822222!
        '
        'Line73
        '
        Me.Line73.Height = 0!
        Me.Line73.Left = 0.25!
        Me.Line73.LineWeight = 3!
        Me.Line73.Name = "Line73"
        Me.Line73.Top = 7.572222!
        Me.Line73.Width = 3.375!
        Me.Line73.X1 = 0.25!
        Me.Line73.X2 = 3.625!
        Me.Line73.Y1 = 7.572222!
        Me.Line73.Y2 = 7.572222!
        '
        'Line74
        '
        Me.Line74.Height = 0!
        Me.Line74.Left = 0.25!
        Me.Line74.LineWeight = 1!
        Me.Line74.Name = "Line74"
        Me.Line74.Top = 6.614221!
        Me.Line74.Width = 3.375!
        Me.Line74.X1 = 0.25!
        Me.Line74.X2 = 3.625!
        Me.Line74.Y1 = 6.614221!
        Me.Line74.Y2 = 6.614221!
        '
        'Line75
        '
        Me.Line75.Height = 0!
        Me.Line75.Left = 0.25!
        Me.Line75.LineWeight = 1!
        Me.Line75.Name = "Line75"
        Me.Line75.Top = 7.093056!
        Me.Line75.Width = 3.375!
        Me.Line75.X1 = 0.25!
        Me.Line75.X2 = 3.625!
        Me.Line75.Y1 = 7.093056!
        Me.Line75.Y2 = 7.093056!
        '
        'Line76
        '
        Me.Line76.Height = 0!
        Me.Line76.Left = 0.25!
        Me.Line76.LineWeight = 1!
        Me.Line76.Name = "Line76"
        Me.Line76.Top = 6.322222!
        Me.Line76.Width = 3.375!
        Me.Line76.X1 = 0.25!
        Me.Line76.X2 = 3.625!
        Me.Line76.Y1 = 6.322222!
        Me.Line76.Y2 = 6.322222!
        '
        'Line77
        '
        Me.Line77.Height = 0!
        Me.Line77.Left = 0.25!
        Me.Line77.LineWeight = 1!
        Me.Line77.Name = "Line77"
        Me.Line77.Top = 6.801721!
        Me.Line77.Width = 3.3755!
        Me.Line77.X1 = 0.25!
        Me.Line77.X2 = 3.6255!
        Me.Line77.Y1 = 6.801721!
        Me.Line77.Y2 = 6.801721!
        '
        'Line78
        '
        Me.Line78.Height = 0!
        Me.Line78.Left = 0.25!
        Me.Line78.LineWeight = 1!
        Me.Line78.Name = "Line78"
        Me.Line78.Top = 7.280723!
        Me.Line78.Width = 3.3755!
        Me.Line78.X1 = 0.25!
        Me.Line78.X2 = 3.6255!
        Me.Line78.Y1 = 7.280723!
        Me.Line78.Y2 = 7.280723!
        '
        'Line79
        '
        Me.Line79.Height = 0.9579997!
        Me.Line79.Left = 1.9375!
        Me.Line79.LineWeight = 1!
        Me.Line79.Name = "Line79"
        Me.Line79.Top = 6.134722!
        Me.Line79.Width = 0!
        Me.Line79.X1 = 1.9375!
        Me.Line79.X2 = 1.9375!
        Me.Line79.Y1 = 6.134722!
        Me.Line79.Y2 = 7.092722!
        '
        'Line80
        '
        Me.Line80.Height = 0.4580002!
        Me.Line80.Left = 2.4375!
        Me.Line80.LineWeight = 1!
        Me.Line80.Name = "Line80"
        Me.Line80.Top = 7.092722!
        Me.Line80.Width = 0!
        Me.Line80.X1 = 2.4375!
        Me.Line80.X2 = 2.4375!
        Me.Line80.Y1 = 7.092722!
        Me.Line80.Y2 = 7.550722!
        '
        'Line81
        '
        Me.Line81.Height = 2.8125!
        Me.Line81.Left = 1.5!
        Me.Line81.LineWeight = 1!
        Me.Line81.Name = "Line81"
        Me.Line81.Top = 7.572222!
        Me.Line81.Width = 0!
        Me.Line81.X1 = 1.5!
        Me.Line81.X2 = 1.5!
        Me.Line81.Y1 = 7.572222!
        Me.Line81.Y2 = 10.38472!
        '
        'Line82
        '
        Me.Line82.Height = 2.8125!
        Me.Line82.Left = 2!
        Me.Line82.LineWeight = 1!
        Me.Line82.Name = "Line82"
        Me.Line82.Top = 7.572222!
        Me.Line82.Width = 0!
        Me.Line82.X1 = 2!
        Me.Line82.X2 = 2!
        Me.Line82.Y1 = 7.572222!
        Me.Line82.Y2 = 10.38472!
        '
        'Line83
        '
        Me.Line83.Height = 2.8125!
        Me.Line83.Left = 2.5!
        Me.Line83.LineWeight = 1!
        Me.Line83.Name = "Line83"
        Me.Line83.Top = 7.572222!
        Me.Line83.Width = 0!
        Me.Line83.X1 = 2.5!
        Me.Line83.X2 = 2.5!
        Me.Line83.Y1 = 7.572222!
        Me.Line83.Y2 = 10.38472!
        '
        'Line84
        '
        Me.Line84.Height = 2.8125!
        Me.Line84.Left = 3.0625!
        Me.Line84.LineWeight = 1!
        Me.Line84.Name = "Line84"
        Me.Line84.Top = 7.572722!
        Me.Line84.Width = 0!
        Me.Line84.X1 = 3.0625!
        Me.Line84.X2 = 3.0625!
        Me.Line84.Y1 = 7.572722!
        Me.Line84.Y2 = 10.38522!
        '
        'Line85
        '
        Me.Line85.Height = 2.8125!
        Me.Line85.Left = 1!
        Me.Line85.LineWeight = 1!
        Me.Line85.Name = "Line85"
        Me.Line85.Top = 7.572222!
        Me.Line85.Width = 0!
        Me.Line85.X1 = 1!
        Me.Line85.X2 = 1!
        Me.Line85.Y1 = 7.572222!
        Me.Line85.Y2 = 10.38472!
        '
        'txtWH_AMT4
        '
        Me.txtWH_AMT4.DataField = "WH_AMT4"
        Me.txtWH_AMT4.Height = 0.313!
        Me.txtWH_AMT4.Left = 6.1875!
        Me.txtWH_AMT4.Name = "txtWH_AMT4"
        Me.txtWH_AMT4.OutputFormat = resources.GetString("txtWH_AMT4.OutputFormat")
        Me.txtWH_AMT4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_AMT4.Text = "入庫数4"
        Me.txtWH_AMT4.Top = 7.259722!
        Me.txtWH_AMT4.Width = 1.187!
        '
        'txtWH_DT4
        '
        Me.txtWH_DT4.DataField = "WH_DT4"
        Me.txtWH_DT4.Height = 0.313!
        Me.txtWH_DT4.Left = 4!
        Me.txtWH_DT4.Name = "txtWH_DT4"
        Me.txtWH_DT4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtWH_DT4.Text = "入庫日4"
        Me.txtWH_DT4.Top = 7.281222!
        Me.txtWH_DT4.Width = 2.1875!
        '
        'txtINDICATE_NO4
        '
        Me.txtINDICATE_NO4.DataField = "INDICATE_NO4"
        Me.txtINDICATE_NO4.Height = 0.313!
        Me.txtINDICATE_NO4.Left = 5.688!
        Me.txtINDICATE_NO4.Name = "txtINDICATE_NO4"
        Me.txtINDICATE_NO4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO4.Text = "指示NO4"
        Me.txtINDICATE_NO4.Top = 6.802222!
        Me.txtINDICATE_NO4.Width = 1.688!
        '
        'txtCOMPANY_NO4
        '
        Me.txtCOMPANY_NO4.DataField = "COMPANY_NO4"
        Me.txtCOMPANY_NO4.Height = 0.3125!
        Me.txtCOMPANY_NO4.Left = 4!
        Me.txtCOMPANY_NO4.Name = "txtCOMPANY_NO4"
        Me.txtCOMPANY_NO4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO4.Text = "社内NO4"
        Me.txtCOMPANY_NO4.Top = 6.802222!
        Me.txtCOMPANY_NO4.Width = 1.6875!
        '
        'txt名称4
        '
        Me.txt名称4.DataField = "名称4"
        Me.txt名称4.Height = 0.3125!
        Me.txt名称4.Left = 5.6875!
        Me.txt名称4.Name = "txt名称4"
        Me.txt名称4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt名称4.Text = "名称4"
        Me.txt名称4.Top = 6.322222!
        Me.txt名称4.Width = 1.6875!
        '
        'txtCATALOG_NO4
        '
        Me.txtCATALOG_NO4.DataField = "CATALOG_NO4"
        Me.txtCATALOG_NO4.Height = 0.3125!
        Me.txtCATALOG_NO4.Left = 4!
        Me.txtCATALOG_NO4.Name = "txtCATALOG_NO4"
        Me.txtCATALOG_NO4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO4.Text = "カタログ番号4"
        Me.txtCATALOG_NO4.Top = 6.322222!
        Me.txtCATALOG_NO4.Width = 1.6875!
        '
        'Label39
        '
        Me.Label39.Height = 0.1875!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 4.75!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label39.Text = "出庫数"
        Me.Label39.Top = 7.572222!
        Me.Label39.Width = 0.5!
        '
        'Label40
        '
        Me.Label40.Height = 0.1875!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 5.25!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label40.Text = "在庫数"
        Me.Label40.Top = 7.572222!
        Me.Label40.Width = 0.5!
        '
        'Label41
        '
        Me.Label41.Height = 0.1875!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 5.75!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label41.Text = "担当"
        Me.Label41.Top = 7.572222!
        Me.Label41.Width = 0.5!
        '
        'Label42
        '
        Me.Label42.Height = 0.1875!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 6.25!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label42.Text = "出庫P/N"
        Me.Label42.Top = 7.572222!
        Me.Label42.Width = 0.5625!
        '
        'Label43
        '
        Me.Label43.Height = 0.1875!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 6.8125!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label43.Text = "指示NO"
        Me.Label43.Top = 7.572222!
        Me.Label43.Width = 0.5625!
        '
        'Label44
        '
        Me.Label44.Height = 0.1875!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 4!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle"
        Me.Label44.Text = "出庫年月日"
        Me.Label44.Top = 7.572222!
        Me.Label44.Width = 0.75!
        '
        'Label45
        '
        Me.Label45.Height = 0.1875!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 6.1875!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label45.Text = "入庫数"
        Me.Label45.Top = 7.092722!
        Me.Label45.Width = 1.1875!
        '
        'Label46
        '
        Me.Label46.Height = 0.188!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 4!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label46.Text = "入庫日"
        Me.Label46.Top = 7.093223!
        Me.Label46.Width = 2.1875!
        '
        'Label47
        '
        Me.Label47.Height = 0.188!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 5.688!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label47.Text = "ロット番号"
        Me.Label47.Top = 6.614221!
        Me.Label47.Width = 1.688!
        '
        'Label48
        '
        Me.Label48.Height = 0.188!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 4!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "background-color: WhiteSmoke; text-align: center; vertical-align: middle"
        Me.Label48.Text = "社内NO"
        Me.Label48.Top = 6.614221!
        Me.Label48.Width = 1.688!
        '
        'Label49
        '
        Me.Label49.Height = 0.188!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 5.6875!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label49.Text = "名称"
        Me.Label49.Top = 6.134722!
        Me.Label49.Width = 1.688!
        '
        'Label50
        '
        Me.Label50.Height = 0.188!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 4!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align" & _
            ": center; vertical-align: middle"
        Me.Label50.Text = "カタログ番号"
        Me.Label50.Top = 6.135222!
        Me.Label50.Width = 1.688!
        '
        'Label51
        '
        Me.Label51.Height = 0.3125!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 4!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "background-color: WhiteSmoke; font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weig" & _
            "ht: bold; text-align: center; vertical-align: middle"
        Me.Label51.Text = "医療部品現品票"
        Me.Label51.Top = 5.822222!
        Me.Label51.Width = 3.375!
        '
        'Line86
        '
        Me.Line86.Height = 0!
        Me.Line86.Left = 4!
        Me.Line86.LineWeight = 3!
        Me.Line86.Name = "Line86"
        Me.Line86.Top = 6.134722!
        Me.Line86.Width = 3.375!
        Me.Line86.X1 = 4!
        Me.Line86.X2 = 7.375!
        Me.Line86.Y1 = 6.134722!
        Me.Line86.Y2 = 6.134722!
        '
        'Line87
        '
        Me.Line87.Height = 0!
        Me.Line87.Left = 4!
        Me.Line87.LineWeight = 1!
        Me.Line87.Name = "Line87"
        Me.Line87.Top = 7.759722!
        Me.Line87.Width = 3.375!
        Me.Line87.X1 = 4!
        Me.Line87.X2 = 7.375!
        Me.Line87.Y1 = 7.759722!
        Me.Line87.Y2 = 7.759722!
        '
        'Line88
        '
        Me.Line88.Height = 0!
        Me.Line88.Left = 4!
        Me.Line88.LineWeight = 1!
        Me.Line88.Name = "Line88"
        Me.Line88.Top = 8.051389!
        Me.Line88.Width = 3.375!
        Me.Line88.X1 = 4!
        Me.Line88.X2 = 7.375!
        Me.Line88.Y1 = 8.051389!
        Me.Line88.Y2 = 8.051389!
        '
        'Line89
        '
        Me.Line89.Height = 0!
        Me.Line89.Left = 4!
        Me.Line89.LineWeight = 1!
        Me.Line89.Name = "Line89"
        Me.Line89.Top = 8.343056!
        Me.Line89.Width = 3.375!
        Me.Line89.X1 = 4!
        Me.Line89.X2 = 7.375!
        Me.Line89.Y1 = 8.343056!
        Me.Line89.Y2 = 8.343056!
        '
        'Line90
        '
        Me.Line90.Height = 0!
        Me.Line90.Left = 4!
        Me.Line90.LineWeight = 1!
        Me.Line90.Name = "Line90"
        Me.Line90.Top = 8.634722!
        Me.Line90.Width = 3.375!
        Me.Line90.X1 = 4!
        Me.Line90.X2 = 7.375!
        Me.Line90.Y1 = 8.634722!
        Me.Line90.Y2 = 8.634722!
        '
        'Line91
        '
        Me.Line91.Height = 0!
        Me.Line91.Left = 4!
        Me.Line91.LineWeight = 1!
        Me.Line91.Name = "Line91"
        Me.Line91.Top = 8.926389!
        Me.Line91.Width = 3.375!
        Me.Line91.X1 = 4!
        Me.Line91.X2 = 7.375!
        Me.Line91.Y1 = 8.926389!
        Me.Line91.Y2 = 8.926389!
        '
        'Line92
        '
        Me.Line92.Height = 0!
        Me.Line92.Left = 4!
        Me.Line92.LineWeight = 1!
        Me.Line92.Name = "Line92"
        Me.Line92.Top = 9.218056!
        Me.Line92.Width = 3.375!
        Me.Line92.X1 = 4!
        Me.Line92.X2 = 7.375!
        Me.Line92.Y1 = 9.218056!
        Me.Line92.Y2 = 9.218056!
        '
        'Line93
        '
        Me.Line93.Height = 0!
        Me.Line93.Left = 4!
        Me.Line93.LineWeight = 1!
        Me.Line93.Name = "Line93"
        Me.Line93.Top = 9.509722!
        Me.Line93.Width = 3.375!
        Me.Line93.X1 = 4!
        Me.Line93.X2 = 7.375!
        Me.Line93.Y1 = 9.509722!
        Me.Line93.Y2 = 9.509722!
        '
        'Line94
        '
        Me.Line94.Height = 0!
        Me.Line94.Left = 4!
        Me.Line94.LineWeight = 1!
        Me.Line94.Name = "Line94"
        Me.Line94.Top = 9.801389!
        Me.Line94.Width = 3.375!
        Me.Line94.X1 = 4!
        Me.Line94.X2 = 7.375!
        Me.Line94.Y1 = 9.801389!
        Me.Line94.Y2 = 9.801389!
        '
        'Line95
        '
        Me.Line95.Height = 0!
        Me.Line95.Left = 4!
        Me.Line95.LineWeight = 1!
        Me.Line95.Name = "Line95"
        Me.Line95.Top = 10.09306!
        Me.Line95.Width = 3.375!
        Me.Line95.X1 = 4!
        Me.Line95.X2 = 7.375!
        Me.Line95.Y1 = 10.09306!
        Me.Line95.Y2 = 10.09306!
        '
        'Line96
        '
        Me.Line96.Height = 0!
        Me.Line96.Left = 4!
        Me.Line96.LineWeight = 1!
        Me.Line96.Name = "Line96"
        Me.Line96.Top = 10.38472!
        Me.Line96.Width = 3.375!
        Me.Line96.X1 = 4!
        Me.Line96.X2 = 7.375!
        Me.Line96.Y1 = 10.38472!
        Me.Line96.Y2 = 10.38472!
        '
        'Line97
        '
        Me.Line97.Height = 5.25!
        Me.Line97.Left = 4!
        Me.Line97.LineWeight = 3!
        Me.Line97.Name = "Line97"
        Me.Line97.Top = 5.822222!
        Me.Line97.Width = 0!
        Me.Line97.X1 = 4!
        Me.Line97.X2 = 4!
        Me.Line97.Y1 = 5.822222!
        Me.Line97.Y2 = 11.07222!
        '
        'Line98
        '
        Me.Line98.Height = 5.25!
        Me.Line98.Left = 7.375!
        Me.Line98.LineWeight = 3!
        Me.Line98.Name = "Line98"
        Me.Line98.Top = 5.822222!
        Me.Line98.Width = 0!
        Me.Line98.X1 = 7.375!
        Me.Line98.X2 = 7.375!
        Me.Line98.Y1 = 5.822222!
        Me.Line98.Y2 = 11.07222!
        '
        'Line99
        '
        Me.Line99.Height = 0!
        Me.Line99.Left = 4!
        Me.Line99.LineWeight = 3!
        Me.Line99.Name = "Line99"
        Me.Line99.Top = 11.07222!
        Me.Line99.Width = 3.375!
        Me.Line99.X1 = 4!
        Me.Line99.X2 = 7.375!
        Me.Line99.Y1 = 11.07222!
        Me.Line99.Y2 = 11.07222!
        '
        'Line100
        '
        Me.Line100.Height = 0!
        Me.Line100.Left = 4!
        Me.Line100.LineWeight = 3!
        Me.Line100.Name = "Line100"
        Me.Line100.Top = 5.822222!
        Me.Line100.Width = 3.375!
        Me.Line100.X1 = 4!
        Me.Line100.X2 = 7.375!
        Me.Line100.Y1 = 5.822222!
        Me.Line100.Y2 = 5.822222!
        '
        'Line101
        '
        Me.Line101.Height = 0!
        Me.Line101.Left = 4!
        Me.Line101.LineWeight = 3!
        Me.Line101.Name = "Line101"
        Me.Line101.Top = 7.572222!
        Me.Line101.Width = 3.375!
        Me.Line101.X1 = 4!
        Me.Line101.X2 = 7.375!
        Me.Line101.Y1 = 7.572222!
        Me.Line101.Y2 = 7.572222!
        '
        'Line102
        '
        Me.Line102.Height = 0!
        Me.Line102.Left = 4!
        Me.Line102.LineWeight = 1!
        Me.Line102.Name = "Line102"
        Me.Line102.Top = 6.614221!
        Me.Line102.Width = 3.375!
        Me.Line102.X1 = 4!
        Me.Line102.X2 = 7.375!
        Me.Line102.Y1 = 6.614221!
        Me.Line102.Y2 = 6.614221!
        '
        'Line103
        '
        Me.Line103.Height = 0!
        Me.Line103.Left = 4!
        Me.Line103.LineWeight = 1!
        Me.Line103.Name = "Line103"
        Me.Line103.Top = 7.093056!
        Me.Line103.Width = 3.375!
        Me.Line103.X1 = 4!
        Me.Line103.X2 = 7.375!
        Me.Line103.Y1 = 7.093056!
        Me.Line103.Y2 = 7.093056!
        '
        'Line104
        '
        Me.Line104.Height = 0!
        Me.Line104.Left = 4!
        Me.Line104.LineWeight = 1!
        Me.Line104.Name = "Line104"
        Me.Line104.Top = 6.322222!
        Me.Line104.Width = 3.375!
        Me.Line104.X1 = 4!
        Me.Line104.X2 = 7.375!
        Me.Line104.Y1 = 6.322222!
        Me.Line104.Y2 = 6.322222!
        '
        'Line105
        '
        Me.Line105.Height = 0!
        Me.Line105.Left = 4!
        Me.Line105.LineWeight = 1!
        Me.Line105.Name = "Line105"
        Me.Line105.Top = 6.801721!
        Me.Line105.Width = 3.3755!
        Me.Line105.X1 = 4!
        Me.Line105.X2 = 7.3755!
        Me.Line105.Y1 = 6.801721!
        Me.Line105.Y2 = 6.801721!
        '
        'Line106
        '
        Me.Line106.Height = 0!
        Me.Line106.Left = 4!
        Me.Line106.LineWeight = 1!
        Me.Line106.Name = "Line106"
        Me.Line106.Top = 7.280723!
        Me.Line106.Width = 3.3755!
        Me.Line106.X1 = 4!
        Me.Line106.X2 = 7.3755!
        Me.Line106.Y1 = 7.280723!
        Me.Line106.Y2 = 7.280723!
        '
        'Line107
        '
        Me.Line107.Height = 0.9579997!
        Me.Line107.Left = 5.6875!
        Me.Line107.LineWeight = 1!
        Me.Line107.Name = "Line107"
        Me.Line107.Top = 6.134722!
        Me.Line107.Width = 0!
        Me.Line107.X1 = 5.6875!
        Me.Line107.X2 = 5.6875!
        Me.Line107.Y1 = 6.134722!
        Me.Line107.Y2 = 7.092722!
        '
        'Line108
        '
        Me.Line108.Height = 0.4580002!
        Me.Line108.Left = 6.1875!
        Me.Line108.LineWeight = 1!
        Me.Line108.Name = "Line108"
        Me.Line108.Top = 7.092722!
        Me.Line108.Width = 0!
        Me.Line108.X1 = 6.1875!
        Me.Line108.X2 = 6.1875!
        Me.Line108.Y1 = 7.092722!
        Me.Line108.Y2 = 7.550722!
        '
        'Line109
        '
        Me.Line109.Height = 2.8125!
        Me.Line109.Left = 5.25!
        Me.Line109.LineWeight = 1!
        Me.Line109.Name = "Line109"
        Me.Line109.Top = 7.572222!
        Me.Line109.Width = 0!
        Me.Line109.X1 = 5.25!
        Me.Line109.X2 = 5.25!
        Me.Line109.Y1 = 7.572222!
        Me.Line109.Y2 = 10.38472!
        '
        'Line110
        '
        Me.Line110.Height = 2.8125!
        Me.Line110.Left = 5.75!
        Me.Line110.LineWeight = 1!
        Me.Line110.Name = "Line110"
        Me.Line110.Top = 7.572222!
        Me.Line110.Width = 0!
        Me.Line110.X1 = 5.75!
        Me.Line110.X2 = 5.75!
        Me.Line110.Y1 = 7.572222!
        Me.Line110.Y2 = 10.38472!
        '
        'Line111
        '
        Me.Line111.Height = 2.8125!
        Me.Line111.Left = 6.25!
        Me.Line111.LineWeight = 1!
        Me.Line111.Name = "Line111"
        Me.Line111.Top = 7.572222!
        Me.Line111.Width = 0!
        Me.Line111.X1 = 6.25!
        Me.Line111.X2 = 6.25!
        Me.Line111.Y1 = 7.572222!
        Me.Line111.Y2 = 10.38472!
        '
        'Line112
        '
        Me.Line112.Height = 2.8125!
        Me.Line112.Left = 6.8125!
        Me.Line112.LineWeight = 1!
        Me.Line112.Name = "Line112"
        Me.Line112.Top = 7.572722!
        Me.Line112.Width = 0!
        Me.Line112.X1 = 6.8125!
        Me.Line112.X2 = 6.8125!
        Me.Line112.Y1 = 7.572722!
        Me.Line112.Y2 = 10.38522!
        '
        'Line113
        '
        Me.Line113.Height = 2.8125!
        Me.Line113.Left = 4.75!
        Me.Line113.LineWeight = 1!
        Me.Line113.Name = "Line113"
        Me.Line113.Top = 7.572222!
        Me.Line113.Width = 0!
        Me.Line113.X1 = 4.75!
        Me.Line113.X2 = 4.75!
        Me.Line113.Y1 = 7.572222!
        Me.Line113.Y2 = 10.38472!
        '
        'Barcode2
        '
        Me.Barcode2.CheckSumEnabled = false
        Me.Barcode2.DataField = "バーコード2"
        Me.Barcode2.Font = New System.Drawing.Font("Courier New", 8!)
        Me.Barcode2.Height = 0.25!
        Me.Barcode2.Left = 4.625!
        Me.Barcode2.Name = "Barcode2"
        Me.Barcode2.QuietZoneBottom = 0!
        Me.Barcode2.QuietZoneLeft = 0!
        Me.Barcode2.QuietZoneRight = 0!
        Me.Barcode2.QuietZoneTop = 0!
        Me.Barcode2.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode2.Text = "Barcode"
        Me.Barcode2.Top = 4.884722!
        Me.Barcode2.Width = 2.125!
        '
        'txtBarcode2
        '
        Me.txtBarcode2.DataField = "バーコード2"
        Me.txtBarcode2.Height = 0.1875!
        Me.txtBarcode2.Left = 4.625!
        Me.txtBarcode2.Name = "txtBarcode2"
        Me.txtBarcode2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtBarcode2.Text = "バーコード2"
        Me.txtBarcode2.Top = 5.134722!
        Me.txtBarcode2.Width = 2.125!
        '
        'Barcode3
        '
        Me.Barcode3.CheckSumEnabled = false
        Me.Barcode3.DataField = "バーコード3"
        Me.Barcode3.Font = New System.Drawing.Font("Courier New", 8!)
        Me.Barcode3.Height = 0.25!
        Me.Barcode3.Left = 0.875!
        Me.Barcode3.Name = "Barcode3"
        Me.Barcode3.QuietZoneBottom = 0!
        Me.Barcode3.QuietZoneLeft = 0!
        Me.Barcode3.QuietZoneRight = 0!
        Me.Barcode3.QuietZoneTop = 0!
        Me.Barcode3.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode3.Text = "Barcode"
        Me.Barcode3.Top = 10.50972!
        Me.Barcode3.Width = 2.125!
        '
        'txtBarcode3
        '
        Me.txtBarcode3.DataField = "バーコード3"
        Me.txtBarcode3.Height = 0.1875!
        Me.txtBarcode3.Left = 0.875!
        Me.txtBarcode3.Name = "txtBarcode3"
        Me.txtBarcode3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtBarcode3.Text = "バーコード3"
        Me.txtBarcode3.Top = 10.75972!
        Me.txtBarcode3.Width = 2.125!
        '
        'Barcode4
        '
        Me.Barcode4.CheckSumEnabled = false
        Me.Barcode4.DataField = "バーコード4"
        Me.Barcode4.Font = New System.Drawing.Font("Courier New", 8!)
        Me.Barcode4.Height = 0.25!
        Me.Barcode4.Left = 4.625!
        Me.Barcode4.Name = "Barcode4"
        Me.Barcode4.QuietZoneBottom = 0!
        Me.Barcode4.QuietZoneLeft = 0!
        Me.Barcode4.QuietZoneRight = 0!
        Me.Barcode4.QuietZoneTop = 0!
        Me.Barcode4.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode4.Text = "Barcode"
        Me.Barcode4.Top = 10.50972!
        Me.Barcode4.Width = 2.125!
        '
        'txtBarcode4
        '
        Me.txtBarcode4.DataField = "バーコード4"
        Me.txtBarcode4.Height = 0.1875!
        Me.txtBarcode4.Left = 4.625!
        Me.txtBarcode4.Name = "txtBarcode4"
        Me.txtBarcode4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtBarcode4.Text = "バーコード4"
        Me.txtBarcode4.Top = 10.75972!
        Me.txtBarcode4.Width = 2.125!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.3!
        Me.PageSettings.Margins.Right = 0.3!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
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
        CType(Me.txtWH_AMT1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_DT1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt名称1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBarcode1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_AMT2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_DT2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt名称2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_AMT3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_DT3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt名称3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_AMT4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWH_DT4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt名称4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBarcode2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBarcode3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBarcode4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If txtWH_DT1.Text <> "" Then txtWH_DT1.Text = txtWH_DT1.Text.Substring(0, 4) & "年  " & txtWH_DT1.Text.Substring(4, 2) & "月  " & txtWH_DT1.Text.Substring(6, 2) & "日"
        If txtWH_DT2.Text <> "" Then txtWH_DT2.Text = txtWH_DT2.Text.Substring(0, 4) & "年  " & txtWH_DT2.Text.Substring(4, 2) & "月  " & txtWH_DT2.Text.Substring(6, 2) & "日"
        If txtWH_DT3.Text <> "" Then txtWH_DT3.Text = txtWH_DT3.Text.Substring(0, 4) & "年  " & txtWH_DT3.Text.Substring(4, 2) & "月  " & txtWH_DT3.Text.Substring(6, 2) & "日"
        If txtWH_DT4.Text <> "" Then txtWH_DT4.Text = txtWH_DT4.Text.Substring(0, 4) & "年  " & txtWH_DT4.Text.Substring(4, 2) & "月  " & txtWH_DT4.Text.Substring(6, 2) & "日"
        If txtBarcode1.Text <> "" Then txtBarcode1.Text = "*" & txtBarcode1.Text & "*"
        If txtBarcode2.Text <> "" Then txtBarcode2.Text = "*" & txtBarcode2.Text & "*"
        If txtBarcode3.Text <> "" Then txtBarcode3.Text = "*" & txtBarcode3.Text & "*"
        If txtBarcode4.Text <> "" Then txtBarcode4.Text = "*" & txtBarcode4.Text & "*"
    End Sub
End Class 
