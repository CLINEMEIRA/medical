Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdgty020
    Inherits GrapeCity.ActiveReports.SectionReport
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Private txtIrai As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label51 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtPROCESS_ORDER1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNOTE_2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNOTE_4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNOTE_3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNOTE_1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label69 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label68 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label67 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label66 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label65 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label61 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label63 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label64 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtORDER_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label60 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtORDER_AMT1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtORDER_DT1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtORDER_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt連略号 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSKETCH_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPRICE2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPRICE1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPLAN_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCONTRACTOUT_DELIVERY1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPRICE As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtORDER_AMT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPROCESS_ORDER As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCONTRACTOUT_DELIVERY As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtORDER_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtORDER_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label58 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label59 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label56 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label57 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label55 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label54 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label49 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label50 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label48 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label47 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label45 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label43 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label44 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label46 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label41 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label42 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCONTRACTOUT_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCONTRACTOUT_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label35 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label36 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label38 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label39 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label40 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label29 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label52 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label62 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label53 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Barcode1 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private Barcode2 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblCode1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblCode2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label70 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label71 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label72 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblSai1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSai2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSai3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdgty020))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtIrai = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label51 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtPROCESS_ORDER1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNOTE_2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNOTE_4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNOTE_3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNOTE_1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label69 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label68 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label67 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label66 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label65 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label61 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label63 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label64 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtORDER_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label60 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtORDER_AMT1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtORDER_DT1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtORDER_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt連略号 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSKETCH_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPRICE2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPRICE1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPLAN_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCONTRACTOUT_DELIVERY1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPRICE = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtORDER_AMT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPROCESS_ORDER = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCONTRACTOUT_DELIVERY = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtORDER_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtORDER_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label58 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label59 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label56 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label57 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label55 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label54 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label49 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label50 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label48 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label47 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label45 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label43 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label44 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label46 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label41 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label42 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCONTRACTOUT_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCONTRACTOUT_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label35 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label36 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label38 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label39 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label40 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label29 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label52 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label62 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label53 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Barcode1 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.Barcode2 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblCode1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblCode2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label70 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label71 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label72 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblSai1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSai2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSai3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.txtIrai, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPROCESS_ORDER1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNOTE_2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNOTE_4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNOTE_3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNOTE_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_AMT1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_DT1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt連略号, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSKETCH_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPRICE2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPRICE1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPLAN_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_DELIVERY1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPRICE, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_AMT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPROCESS_ORDER, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_DELIVERY, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtORDER_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCONTRACTOUT_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
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
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCode2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label71, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label72, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSai1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSai2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSai3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.CanShrink = true
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtIrai, Me.Label51, Me.txtPROCESS_ORDER1, Me.txtNOTE_2, Me.txtNOTE_4, Me.txtNOTE_3, Me.txtNOTE_1, Me.Label69, Me.Label68, Me.Label26, Me.Label27, Me.Label24, Me.Label23, Me.Label67, Me.Label66, Me.Label65, Me.Label61, Me.Label63, Me.Label64, Me.txtORDER_NO2, Me.txtCATALOG_NO2, Me.Label60, Me.txtORDER_AMT1, Me.txtORDER_DT1, Me.txtORDER_NO1, Me.txtINDICATE_NO1, Me.txtCOMPANY_NO1, Me.txt連略号, Me.txtSKETCH_NO, Me.txtPRICE2, Me.txtPRICE1, Me.txtCATALOG_NO1, Me.txtPLAN_DT, Me.txtCONTRACTOUT_DELIVERY1, Me.txtPRICE, Me.txtORDER_AMT, Me.txtPROCESS_ORDER, Me.txtCONTRACTOUT_DELIVERY, Me.txtCATALOG_NO, Me.txtCOMPANY_NO, Me.txtINDICATE_NO, Me.txtORDER_DT, Me.txtORDER_NO, Me.Label58, Me.Label59, Me.Label56, Me.Label57, Me.Label55, Me.Label54, Me.Label49, Me.Label50, Me.Label48, Me.Label47, Me.Label45, Me.Label43, Me.Label44, Me.Label46, Me.Label41, Me.Label42, Me.Label31, Me.Label25, Me.Line, Me.Line1, Me.Label2, Me.Label3, Me.txtCONTRACTOUT_CD, Me.txtCONTRACTOUT_NM, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Line4, Me.Line5, Me.Line8, Me.Line9, Me.Label10, Me.Line10, Me.Line15, Me.Line16, Me.Label11, Me.Label12, Me.Label13, Me.Line11, Me.Line12, Me.Line13, Me.Line7, Me.Line6, Me.Line14, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label28, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Label37, Me.Line23, Me.Line24, Me.Line25, Me.Label38, Me.Label39, Me.Label40, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Line17, Me.Line32, Me.Line33, Me.Line34, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Label29, Me.Label30, Me.Line39, Me.Line40, Me.Line41, Me.Line42, Me.Line43, Me.Line44, Me.Line45, Me.Label, Me.Line50, Me.Line51, Me.Line52, Me.Line53, Me.Label1, Me.Label52, Me.Line56, Me.Line57, Me.Line59, Me.Line60, Me.Line58, Me.Line61, Me.Line62, Me.Line63, Me.Line64, Me.Line65, Me.Line66, Me.Line67, Me.Label62, Me.Line68, Me.Line69, Me.Line70, Me.Line71, Me.Line72, Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.Label53, Me.Barcode1, Me.Barcode2, Me.Line2, Me.Line3, Me.Line55, Me.lblCode1, Me.lblCode2, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.Label70, Me.Label71, Me.Label72, Me.Line54, Me.Line18, Me.Line73, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.Line49, Me.Line48, Me.Line47, Me.Line46, Me.Line74, Me.lblSai1, Me.lblSai2, Me.lblSai3})
        Me.Detail.Height = 10.84375!
        Me.Detail.Name = "Detail"
        Me.Detail.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
        '
        'PageHeader
        '
        Me.PageHeader.CanGrow = false
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Visible = false
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = false
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'txtIrai
        '
        Me.txtIrai.DataField = "依頼工程名"
        Me.txtIrai.Height = 0.188!
        Me.txtIrai.Left = 0.875!
        Me.txtIrai.Name = "txtIrai"
        Me.txtIrai.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.txtIrai.Text = "依頼工程名"
        Me.txtIrai.Top = 7.25!
        Me.txtIrai.Width = 3.625!
        '
        'Label51
        '
        Me.Label51.Height = 0.25!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 3.1875!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: middle" & _
            ""
        Me.Label51.Text = "注　文　書"
        Me.Label51.Top = 0.0625!
        Me.Label51.Width = 1.3125!
        '
        'txtPROCESS_ORDER1
        '
        Me.txtPROCESS_ORDER1.DataField = "PROCESS_ORDER"
        Me.txtPROCESS_ORDER1.Height = 0.2!
        Me.txtPROCESS_ORDER1.Left = 6.25!
        Me.txtPROCESS_ORDER1.Name = "txtPROCESS_ORDER1"
        Me.txtPROCESS_ORDER1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtPROCESS_ORDER1.Text = "工順"
        Me.txtPROCESS_ORDER1.Top = 5.3125!
        Me.txtPROCESS_ORDER1.Width = 1.3125!
        '
        'txtNOTE_2
        '
        Me.txtNOTE_2.DataField = "NOTE_2"
        Me.txtNOTE_2.Height = 0.188!
        Me.txtNOTE_2.Left = 0.875!
        Me.txtNOTE_2.Name = "txtNOTE_2"
        Me.txtNOTE_2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.txtNOTE_2.Top = 2.375!
        Me.txtNOTE_2.Width = 3.0625!
        '
        'txtNOTE_4
        '
        Me.txtNOTE_4.DataField = "NOTE_4"
        Me.txtNOTE_4.Height = 0.188!
        Me.txtNOTE_4.Left = 0.875!
        Me.txtNOTE_4.Name = "txtNOTE_4"
        Me.txtNOTE_4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.txtNOTE_4.Top = 2.75!
        Me.txtNOTE_4.Width = 3.0625!
        '
        'txtNOTE_3
        '
        Me.txtNOTE_3.DataField = "NOTE_3"
        Me.txtNOTE_3.Height = 0.188!
        Me.txtNOTE_3.Left = 0.875!
        Me.txtNOTE_3.Name = "txtNOTE_3"
        Me.txtNOTE_3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.txtNOTE_3.Top = 2.5625!
        Me.txtNOTE_3.Width = 3.0625!
        '
        'txtNOTE_1
        '
        Me.txtNOTE_1.DataField = "NOTE_1"
        Me.txtNOTE_1.Height = 0.188!
        Me.txtNOTE_1.Left = 0.875!
        Me.txtNOTE_1.Name = "txtNOTE_1"
        Me.txtNOTE_1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.txtNOTE_1.Top = 2.1875!
        Me.txtNOTE_1.Width = 3.0625!
        '
        'Label69
        '
        Me.Label69.Height = 0.1875!
        Me.Label69.HyperLink = Nothing
        Me.Label69.Left = 0.25!
        Me.Label69.Name = "Label69"
        Me.Label69.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label69.Text = "備"
        Me.Label69.Top = 9.5!
        Me.Label69.Width = 0.375!
        '
        'Label68
        '
        Me.Label68.Height = 0.1875!
        Me.Label68.HyperLink = Nothing
        Me.Label68.Left = 0.25!
        Me.Label68.Name = "Label68"
        Me.Label68.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label68.Text = "考"
        Me.Label68.Top = 9.6875!
        Me.Label68.Width = 0.375!
        '
        'Label26
        '
        Me.Label26.Height = 0.1875!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.25!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label26.Text = "考"
        Me.Label26.Top = 6.8125!
        Me.Label26.Width = 0.375!
        '
        'Label27
        '
        Me.Label27.Height = 0.1875!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 0.25!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label27.Text = "備"
        Me.Label27.Top = 6.625!
        Me.Label27.Width = 0.375!
        '
        'Label24
        '
        Me.Label24.Height = 0.1875!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.25!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label24.Text = "考"
        Me.Label24.Top = 2.5625!
        Me.Label24.Width = 0.375!
        '
        'Label23
        '
        Me.Label23.Height = 0.1875!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.25!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label23.Text = "備"
        Me.Label23.Top = 2.375!
        Me.Label23.Width = 0.375!
        '
        'Label67
        '
        Me.Label67.Height = 0.166!
        Me.Label67.HyperLink = Nothing
        Me.Label67.Left = 6.78!
        Me.Label67.Name = "Label67"
        Me.Label67.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label67.Text = "  ：正式"
        Me.Label67.Top = 6.188001!
        Me.Label67.Width = 0.75!
        '
        'Label66
        '
        Me.Label66.Height = 0.166!
        Me.Label66.HyperLink = Nothing
        Me.Label66.Left = 6.78!
        Me.Label66.Name = "Label66"
        Me.Label66.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label66.Text = " 2：単価0"
        Me.Label66.Top = 6.041!
        Me.Label66.Width = 0.75!
        '
        'Label65
        '
        Me.Label65.Height = 0.166!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 6.78!
        Me.Label65.Name = "Label65"
        Me.Label65.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label65.Text = " 1：仮単価"
        Me.Label65.Top = 5.895!
        Me.Label65.Width = 0.75!
        '
        'Label61
        '
        Me.Label61.Height = 0.1659999!
        Me.Label61.HyperLink = Nothing
        Me.Label61.Left = 4.73!
        Me.Label61.Name = "Label61"
        Me.Label61.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label61.Text = " 1：(個)"
        Me.Label61.Top = 5.895!
        Me.Label61.Width = 0.875!
        '
        'Label63
        '
        Me.Label63.Height = 0.166!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 4.73!
        Me.Label63.Name = "Label63"
        Me.Label63.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: middle" & _
            ""
        Me.Label63.Text = " 3：(その他)"
        Me.Label63.Top = 6.188001!
        Me.Label63.Width = 0.875!
        '
        'Label64
        '
        Me.Label64.Height = 0.166!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 4.73!
        Me.Label64.Name = "Label64"
        Me.Label64.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label64.Text = " 2：(kg)"
        Me.Label64.Top = 6.041!
        Me.Label64.Width = 0.875!
        '
        'txtORDER_NO2
        '
        Me.txtORDER_NO2.DataField = "ORDER_NO"
        Me.txtORDER_NO2.Height = 0.2!
        Me.txtORDER_NO2.Left = 1.375!
        Me.txtORDER_NO2.Name = "txtORDER_NO2"
        Me.txtORDER_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtORDER_NO2.Text = "注文NO"
        Me.txtORDER_NO2.Top = 9!
        Me.txtORDER_NO2.Width = 1.125!
        '
        'txtCATALOG_NO2
        '
        Me.txtCATALOG_NO2.DataField = "CATALOG_NO"
        Me.txtCATALOG_NO2.Height = 0.2!
        Me.txtCATALOG_NO2.Left = 2.5!
        Me.txtCATALOG_NO2.Name = "txtCATALOG_NO2"
        Me.txtCATALOG_NO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO2.Text = "カタログ番号"
        Me.txtCATALOG_NO2.Top = 9!
        Me.txtCATALOG_NO2.Width = 2.9375!
        '
        'Label60
        '
        Me.Label60.Height = 0.3125!
        Me.Label60.HyperLink = Nothing
        Me.Label60.Left = 2.5!
        Me.Label60.Name = "Label60"
        Me.Label60.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label60.Text = "カタログ番号"
        Me.Label60.Top = 8.625!
        Me.Label60.Width = 2.9375!
        '
        'txtORDER_AMT1
        '
        Me.txtORDER_AMT1.DataField = "ORDER_AMT"
        Me.txtORDER_AMT1.Height = 0.5!
        Me.txtORDER_AMT1.Left = 2!
        Me.txtORDER_AMT1.Name = "txtORDER_AMT1"
        Me.txtORDER_AMT1.OutputFormat = resources.GetString("txtORDER_AMT1.OutputFormat")
        Me.txtORDER_AMT1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtORDER_AMT1.Text = "発注数"
        Me.txtORDER_AMT1.Top = 5.875!
        Me.txtORDER_AMT1.Width = 0.8125!
        '
        'txtORDER_DT1
        '
        Me.txtORDER_DT1.DataField = "ORDER_DT"
        Me.txtORDER_DT1.Height = 0.5!
        Me.txtORDER_DT1.Left = 1.125!
        Me.txtORDER_DT1.Name = "txtORDER_DT1"
        Me.txtORDER_DT1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtORDER_DT1.Text = "発注日"
        Me.txtORDER_DT1.Top = 5.875!
        Me.txtORDER_DT1.Width = 0.875!
        '
        'txtORDER_NO1
        '
        Me.txtORDER_NO1.DataField = "ORDER_NO"
        Me.txtORDER_NO1.Height = 0.5!
        Me.txtORDER_NO1.Left = 0.25!
        Me.txtORDER_NO1.Name = "txtORDER_NO1"
        Me.txtORDER_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtORDER_NO1.Text = "注文NO"
        Me.txtORDER_NO1.Top = 5.875!
        Me.txtORDER_NO1.Width = 0.875!
        '
        'txtINDICATE_NO1
        '
        Me.txtINDICATE_NO1.DataField = "INDICATE_NO"
        Me.txtINDICATE_NO1.Height = 0.2!
        Me.txtINDICATE_NO1.Left = 1.125!
        Me.txtINDICATE_NO1.Name = "txtINDICATE_NO1"
        Me.txtINDICATE_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO1.Text = "指示NO"
        Me.txtINDICATE_NO1.Top = 5.3125!
        Me.txtINDICATE_NO1.Width = 0.875!
        '
        'txtCOMPANY_NO1
        '
        Me.txtCOMPANY_NO1.DataField = "COMPANY_NO"
        Me.txtCOMPANY_NO1.Height = 0.2!
        Me.txtCOMPANY_NO1.Left = 0.25!
        Me.txtCOMPANY_NO1.Name = "txtCOMPANY_NO1"
        Me.txtCOMPANY_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO1.Text = "社内NO"
        Me.txtCOMPANY_NO1.Top = 5.3125!
        Me.txtCOMPANY_NO1.Width = 0.875!
        '
        'txt連略号
        '
        Me.txt連略号.DataField = "連略号"
        Me.txt連略号.Height = 0.2!
        Me.txt連略号.Left = 2!
        Me.txt連略号.Name = "txt連略号"
        Me.txt連略号.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txt連略号.Text = "連略号"
        Me.txt連略号.Top = 5.3125!
        Me.txt連略号.Width = 0.875!
        '
        'txtSKETCH_NO
        '
        Me.txtSKETCH_NO.DataField = "SKETCH_NO"
        Me.txtSKETCH_NO.Height = 0.2!
        Me.txtSKETCH_NO.Left = 2.875!
        Me.txtSKETCH_NO.Name = "txtSKETCH_NO"
        Me.txtSKETCH_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtSKETCH_NO.Text = "図面番号"
        Me.txtSKETCH_NO.Top = 5.3125!
        Me.txtSKETCH_NO.Width = 1.375!
        '
        'txtPRICE2
        '
        Me.txtPRICE2.DataField = "PRICE2"
        Me.txtPRICE2.Height = 0.5!
        Me.txtPRICE2.Left = 6.5!
        Me.txtPRICE2.Name = "txtPRICE2"
        Me.txtPRICE2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtPRICE2.Text = "単価2"
        Me.txtPRICE2.Top = 5.875!
        Me.txtPRICE2.Width = 0.23!
        '
        'txtPRICE1
        '
        Me.txtPRICE1.DataField = "PRICE1"
        Me.txtPRICE1.Height = 0.5!
        Me.txtPRICE1.Left = 5.625!
        Me.txtPRICE1.Name = "txtPRICE1"
        Me.txtPRICE1.OutputFormat = resources.GetString("txtPRICE1.OutputFormat")
        Me.txtPRICE1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtPRICE1.Text = "単価1"
        Me.txtPRICE1.Top = 5.875!
        Me.txtPRICE1.Width = 0.8125!
        '
        'txtCATALOG_NO1
        '
        Me.txtCATALOG_NO1.DataField = "CATALOG_NO"
        Me.txtCATALOG_NO1.Height = 0.2!
        Me.txtCATALOG_NO1.Left = 4.25!
        Me.txtCATALOG_NO1.Name = "txtCATALOG_NO1"
        Me.txtCATALOG_NO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO1.Text = "カタログ番号"
        Me.txtCATALOG_NO1.Top = 5.3125!
        Me.txtCATALOG_NO1.Width = 2!
        '
        'txtPLAN_DT
        '
        Me.txtPLAN_DT.DataField = "PLAN_DT"
        Me.txtPLAN_DT.Height = 0.2!
        Me.txtPLAN_DT.Left = 5.6875!
        Me.txtPLAN_DT.Name = "txtPLAN_DT"
        Me.txtPLAN_DT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtPLAN_DT.Text = "予定日"
        Me.txtPLAN_DT.Top = 4.6875!
        Me.txtPLAN_DT.Width = 1.4375!
        '
        'txtCONTRACTOUT_DELIVERY1
        '
        Me.txtCONTRACTOUT_DELIVERY1.DataField = "CONTRACTOUT_DELIVERY"
        Me.txtCONTRACTOUT_DELIVERY1.Height = 0.2!
        Me.txtCONTRACTOUT_DELIVERY1.Left = 3.4375!
        Me.txtCONTRACTOUT_DELIVERY1.Name = "txtCONTRACTOUT_DELIVERY1"
        Me.txtCONTRACTOUT_DELIVERY1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCONTRACTOUT_DELIVERY1.Text = "外注納期"
        Me.txtCONTRACTOUT_DELIVERY1.Top = 4.6875!
        Me.txtCONTRACTOUT_DELIVERY1.Width = 1.4375!
        '
        'txtPRICE
        '
        Me.txtPRICE.DataField = "PRICE"
        Me.txtPRICE.Height = 0.2!
        Me.txtPRICE.Left = 3.4375!
        Me.txtPRICE.Name = "txtPRICE"
        Me.txtPRICE.OutputFormat = resources.GetString("txtPRICE.OutputFormat")
        Me.txtPRICE.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtPRICE.Top = 1.875!
        Me.txtPRICE.Width = 1!
        '
        'txtORDER_AMT
        '
        Me.txtORDER_AMT.DataField = "ORDER_AMT"
        Me.txtORDER_AMT.Height = 0.2!
        Me.txtORDER_AMT.Left = 2.375!
        Me.txtORDER_AMT.Name = "txtORDER_AMT"
        Me.txtORDER_AMT.OutputFormat = resources.GetString("txtORDER_AMT.OutputFormat")
        Me.txtORDER_AMT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtORDER_AMT.Top = 1.875!
        Me.txtORDER_AMT.Width = 1!
        '
        'txtPROCESS_ORDER
        '
        Me.txtPROCESS_ORDER.DataField = "PROCESS_ORDER"
        Me.txtPROCESS_ORDER.Height = 0.2!
        Me.txtPROCESS_ORDER.Left = 1.3125!
        Me.txtPROCESS_ORDER.Name = "txtPROCESS_ORDER"
        Me.txtPROCESS_ORDER.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtPROCESS_ORDER.Top = 1.875!
        Me.txtPROCESS_ORDER.Width = 1.0625!
        '
        'txtCONTRACTOUT_DELIVERY
        '
        Me.txtCONTRACTOUT_DELIVERY.DataField = "CONTRACTOUT_DELIVERY"
        Me.txtCONTRACTOUT_DELIVERY.Height = 0.2!
        Me.txtCONTRACTOUT_DELIVERY.Left = 0.25!
        Me.txtCONTRACTOUT_DELIVERY.Name = "txtCONTRACTOUT_DELIVERY"
        Me.txtCONTRACTOUT_DELIVERY.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCONTRACTOUT_DELIVERY.Top = 1.875!
        Me.txtCONTRACTOUT_DELIVERY.Width = 1.0625!
        '
        'txtCATALOG_NO
        '
        Me.txtCATALOG_NO.DataField = "CATALOG_NO"
        Me.txtCATALOG_NO.Height = 0.2!
        Me.txtCATALOG_NO.Left = 4.5!
        Me.txtCATALOG_NO.Name = "txtCATALOG_NO"
        Me.txtCATALOG_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCATALOG_NO.Top = 1.25!
        Me.txtCATALOG_NO.Width = 3.0625!
        '
        'txtCOMPANY_NO
        '
        Me.txtCOMPANY_NO.DataField = "COMPANY_NO"
        Me.txtCOMPANY_NO.Height = 0.2!
        Me.txtCOMPANY_NO.Left = 2.375!
        Me.txtCOMPANY_NO.Name = "txtCOMPANY_NO"
        Me.txtCOMPANY_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtCOMPANY_NO.Top = 1.25!
        Me.txtCOMPANY_NO.Width = 1.0625!
        '
        'txtINDICATE_NO
        '
        Me.txtINDICATE_NO.DataField = "INDICATE_NO"
        Me.txtINDICATE_NO.Height = 0.2!
        Me.txtINDICATE_NO.Left = 3.4375!
        Me.txtINDICATE_NO.Name = "txtINDICATE_NO"
        Me.txtINDICATE_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtINDICATE_NO.Top = 1.25!
        Me.txtINDICATE_NO.Width = 1.0625!
        '
        'txtORDER_DT
        '
        Me.txtORDER_DT.DataField = "ORDER_DT"
        Me.txtORDER_DT.Height = 0.2!
        Me.txtORDER_DT.Left = 1.3125!
        Me.txtORDER_DT.Name = "txtORDER_DT"
        Me.txtORDER_DT.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtORDER_DT.Top = 1.25!
        Me.txtORDER_DT.Width = 1.0625!
        '
        'txtORDER_NO
        '
        Me.txtORDER_NO.DataField = "ORDER_NO"
        Me.txtORDER_NO.Height = 0.2!
        Me.txtORDER_NO.Left = 0.25!
        Me.txtORDER_NO.Name = "txtORDER_NO"
        Me.txtORDER_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.txtORDER_NO.Top = 1.25!
        Me.txtORDER_NO.Width = 1.0625!
        '
        'Label58
        '
        Me.Label58.Height = 0.3125!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 6.5!
        Me.Label58.Name = "Label58"
        Me.Label58.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label58.Text = "受領印"
        Me.Label58.Top = 8.625!
        Me.Label58.Width = 1.0625!
        '
        'Label59
        '
        Me.Label59.Height = 0.3125!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 5.4375!
        Me.Label59.Name = "Label59"
        Me.Label59.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label59.Text = "実納入数量"
        Me.Label59.Top = 8.625!
        Me.Label59.Width = 1.0625!
        '
        'Label56
        '
        Me.Label56.Height = 0.375!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 5.375!
        Me.Label56.Name = "Label56"
        Me.Label56.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label56.Text = "メイラ (株)"
        Me.Label56.Top = 10.125!
        Me.Label56.Width = 0.9375!
        '
        'Label57
        '
        Me.Label57.Height = 0.375!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 0.6875!
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label57.Text = "上記のとおり注文品を受領いたしました。"
        Me.Label57.Top = 10.125!
        Me.Label57.Width = 2.8125!
        '
        'Label55
        '
        Me.Label55.Height = 0.3125!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 1.375!
        Me.Label55.Name = "Label55"
        Me.Label55.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label55.Text = "注文NO"
        Me.Label55.Top = 8.625!
        Me.Label55.Width = 1.125!
        '
        'Label54
        '
        Me.Label54.Height = 0.3125!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 0.25!
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label54.Text = "納入年月日"
        Me.Label54.Top = 8.625!
        Me.Label54.Width = 1.125!
        '
        'Label49
        '
        Me.Label49.Height = 0.25!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 5.1875!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label49.Text = "検印"
        Me.Label49.Top = 6.375!
        Me.Label49.Width = 1.1875!
        '
        'Label50
        '
        Me.Label50.Height = 0.25!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 6.375!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label50.Text = "受領印"
        Me.Label50.Top = 6.375!
        Me.Label50.Width = 1.1875!
        '
        'Label48
        '
        Me.Label48.Height = 0.3125!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 4.875!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label48.Text = "工程納期"
        Me.Label48.Top = 4.625!
        Me.Label48.Width = 0.8125!
        '
        'Label47
        '
        Me.Label47.Height = 0.3125!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 2.875!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label47.Text = "納期"
        Me.Label47.Top = 4.625!
        Me.Label47.Width = 0.5625!
        '
        'Label45
        '
        Me.Label45.Height = 0.3125!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 6.25!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label45.Text = "工順"
        Me.Label45.Top = 4.9375!
        Me.Label45.Width = 1.3125!
        '
        'Label43
        '
        Me.Label43.Height = 0.3125!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 4.6875!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label43.Text = "単位"
        Me.Label43.Top = 5.5625!
        Me.Label43.Width = 0.9375!
        '
        'Label44
        '
        Me.Label44.Height = 0.3125!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 5.625!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label44.Text = "単価"
        Me.Label44.Top = 5.5625!
        Me.Label44.Width = 1.125!
        '
        'Label46
        '
        Me.Label46.Height = 0.3125!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 6.75!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label46.Text = "単位区分"
        Me.Label46.Top = 5.5625!
        Me.Label46.Width = 0.8125!
        '
        'Label41
        '
        Me.Label41.Height = 0.3125!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 1.875!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label41.Text = "月"
        Me.Label41.Top = 4.625!
        Me.Label41.Width = 0.4375!
        '
        'Label42
        '
        Me.Label42.Height = 0.3125!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 2.3125!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label42.Text = "日"
        Me.Label42.Top = 4.625!
        Me.Label42.Width = 0.4375!
        '
        'Label31
        '
        Me.Label31.Height = 0.3125!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 1.1875!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label31.Text = "年"
        Me.Label31.Top = 4.625!
        Me.Label31.Width = 0.6875!
        '
        'Label25
        '
        Me.Label25.Height = 0.3125!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 0.25!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label25.Text = "納入年月日"
        Me.Label25.Top = 4.625!
        Me.Label25.Width = 0.875!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.0625!
        Me.Line.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot
        Me.Line.LineWeight = 3!
        Me.Line.Name = "Line"
        Me.Line.Top = 3.25!
        Me.Line.Width = 7.5!
        Me.Line.X1 = 0.0625!
        Me.Line.X2 = 7.5625!
        Me.Line.Y1 = 3.25!
        Me.Line.Y2 = 3.25!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.0625!
        Me.Line1.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot
        Me.Line1.LineWeight = 3!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 7.625!
        Me.Line1.Width = 7.5!
        Me.Line1.X1 = 0.0625!
        Me.Line1.X2 = 7.5625!
        Me.Line1.Y1 = 7.625!
        Me.Line1.Y2 = 7.625!
        '
        'Label2
        '
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.5!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label2.Text = "メイラ株式会社"
        Me.Label2.Top = 0.375!
        Me.Label2.Width = 1.0625!
        '
        'Label3
        '
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 6.125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label3.Text = "メディカル事業部"
        Me.Label3.Top = 0.5625!
        Me.Label3.Width = 1.1875!
        '
        'txtCONTRACTOUT_CD
        '
        Me.txtCONTRACTOUT_CD.DataField = "CONTRACTOUT_CD"
        Me.txtCONTRACTOUT_CD.Height = 0.188!
        Me.txtCONTRACTOUT_CD.Left = 0.375!
        Me.txtCONTRACTOUT_CD.Name = "txtCONTRACTOUT_CD"
        Me.txtCONTRACTOUT_CD.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txtCONTRACTOUT_CD.Top = 0.375!
        Me.txtCONTRACTOUT_CD.Width = 1!
        '
        'txtCONTRACTOUT_NM
        '
        Me.txtCONTRACTOUT_NM.DataField = "CONTRACTOUT_NM"
        Me.txtCONTRACTOUT_NM.Height = 0.188!
        Me.txtCONTRACTOUT_NM.Left = 0.5625!
        Me.txtCONTRACTOUT_NM.Name = "txtCONTRACTOUT_NM"
        Me.txtCONTRACTOUT_NM.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.txtCONTRACTOUT_NM.Top = 0.5625!
        Me.txtCONTRACTOUT_NM.Width = 2.125!
        '
        'Label4
        '
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.75!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label4.Text = "御中"
        Me.Label4.Top = 0.5625!
        Me.Label4.Width = 0.375!
        '
        'Label5
        '
        Me.Label5.Height = 0.3125!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.25!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label5.Text = "注文NO"
        Me.Label5.Top = 0.875!
        Me.Label5.Width = 1.0625!
        '
        'Label6
        '
        Me.Label6.Height = 0.3125!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.3125!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label6.Text = "発注年月日"
        Me.Label6.Top = 0.875!
        Me.Label6.Width = 1.0625!
        '
        'Label7
        '
        Me.Label7.Height = 0.3125!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.4375!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label7.Text = "指示NO"
        Me.Label7.Top = 0.875!
        Me.Label7.Width = 1.0625!
        '
        'Label8
        '
        Me.Label8.Height = 0.3125!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.375!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label8.Text = "社内NO"
        Me.Label8.Top = 0.875!
        Me.Label8.Width = 1.0625!
        '
        'Label9
        '
        Me.Label9.Height = 0.3125!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 4.5!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label9.Text = "カタログ番号"
        Me.Label9.Top = 0.875!
        Me.Label9.Width = 3.0625!
        '
        'Line4
        '
        Me.Line4.Height = 0!
        Me.Line4.Left = 0.25!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.875!
        Me.Line4.Width = 7.3125!
        Me.Line4.X1 = 0.25!
        Me.Line4.X2 = 7.5625!
        Me.Line4.Y1 = 0.875!
        Me.Line4.Y2 = 0.875!
        '
        'Line5
        '
        Me.Line5.Height = 0!
        Me.Line5.Left = 0.25!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.1875!
        Me.Line5.Width = 7.3125!
        Me.Line5.X1 = 0.25!
        Me.Line5.X2 = 7.5625!
        Me.Line5.Y1 = 1.1875!
        Me.Line5.Y2 = 1.1875!
        '
        'Line8
        '
        Me.Line8.Height = 0!
        Me.Line8.Left = 0.25!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 2.125!
        Me.Line8.Width = 4.25!
        Me.Line8.X1 = 0.25!
        Me.Line8.X2 = 4.5!
        Me.Line8.Y1 = 2.125!
        Me.Line8.Y2 = 2.125!
        '
        'Line9
        '
        Me.Line9.Height = 0!
        Me.Line9.Left = 0.25!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 3!
        Me.Line9.Width = 4.25!
        Me.Line9.X1 = 0.25!
        Me.Line9.X2 = 4.5!
        Me.Line9.Y1 = 3!
        Me.Line9.Y2 = 3!
        '
        'Label10
        '
        Me.Label10.Height = 0.3125!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.25!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label10.Text = "納期"
        Me.Label10.Top = 1.5!
        Me.Label10.Width = 1.0625!
        '
        'Line10
        '
        Me.Line10.Height = 2.125!
        Me.Line10.Left = 0.25!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.875!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 0.25!
        Me.Line10.X2 = 0.25!
        Me.Line10.Y1 = 0.875!
        Me.Line10.Y2 = 3!
        '
        'Line15
        '
        Me.Line15.Height = 0.875!
        Me.Line15.Left = 0.625!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 2.125!
        Me.Line15.Width = 0!
        Me.Line15.X1 = 0.625!
        Me.Line15.X2 = 0.625!
        Me.Line15.Y1 = 2.125!
        Me.Line15.Y2 = 3!
        '
        'Line16
        '
        Me.Line16.Height = 0.625!
        Me.Line16.Left = 7.5625!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.875!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 7.5625!
        Me.Line16.X2 = 7.5625!
        Me.Line16.Y1 = 0.875!
        Me.Line16.Y2 = 1.5!
        '
        'Label11
        '
        Me.Label11.Height = 0.3125!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 1.3125!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label11.Text = "工順"
        Me.Label11.Top = 1.5!
        Me.Label11.Width = 1.0625!
        '
        'Label12
        '
        Me.Label12.Height = 0.3125!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 2.375!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label12.Text = "数量"
        Me.Label12.Top = 1.5!
        Me.Label12.Width = 1.0625!
        '
        'Label13
        '
        Me.Label13.Height = 0.3125!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 3.4375!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label13.Text = "単価"
        Me.Label13.Top = 1.5!
        Me.Label13.Width = 1.0625!
        '
        'Line11
        '
        Me.Line11.Height = 1.25!
        Me.Line11.Left = 1.3125!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.875!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 1.3125!
        Me.Line11.X2 = 1.3125!
        Me.Line11.Y1 = 0.875!
        Me.Line11.Y2 = 2.125!
        '
        'Line12
        '
        Me.Line12.Height = 1.25!
        Me.Line12.Left = 2.375!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.875!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 2.375!
        Me.Line12.X2 = 2.375!
        Me.Line12.Y1 = 0.875!
        Me.Line12.Y2 = 2.125!
        '
        'Line13
        '
        Me.Line13.Height = 1.25!
        Me.Line13.Left = 3.4375!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.875!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 3.4375!
        Me.Line13.X2 = 3.4375!
        Me.Line13.Y1 = 0.875!
        Me.Line13.Y2 = 2.125!
        '
        'Line7
        '
        Me.Line7.Height = 0!
        Me.Line7.Left = 0.25!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 1.8125!
        Me.Line7.Width = 4.25!
        Me.Line7.X1 = 0.25!
        Me.Line7.X2 = 4.5!
        Me.Line7.Y1 = 1.8125!
        Me.Line7.Y2 = 1.8125!
        '
        'Line6
        '
        Me.Line6.Height = 0!
        Me.Line6.Left = 0.25!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.5!
        Me.Line6.Width = 7.3125!
        Me.Line6.X1 = 0.25!
        Me.Line6.X2 = 7.5625!
        Me.Line6.Y1 = 1.5!
        Me.Line6.Y2 = 1.5!
        '
        'Line14
        '
        Me.Line14.Height = 2.125!
        Me.Line14.Left = 4.5!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.875!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 4.5!
        Me.Line14.X2 = 4.5!
        Me.Line14.Y1 = 0.875!
        Me.Line14.Y2 = 3!
        '
        'Label14
        '
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 4.875!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle"
        Me.Label14.Text = "・納入場所は関工場です。"
        Me.Label14.Top = 1.5625!
        Me.Label14.Width = 2.625!
        '
        'Label15
        '
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 4.875!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle"
        Me.Label15.Text = "・支払期日方法等は毎年９月１日付"
        Me.Label15.Top = 1.75!
        Me.Label15.Width = 2.625!
        '
        'Label16
        '
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 5!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle"
        Me.Label16.Text = "代金支払通知書によります。"
        Me.Label16.Top = 1.9375!
        Me.Label16.Width = 2.5!
        '
        'Label17
        '
        Me.Label17.Height = 0.1875!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 4.875!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle"
        Me.Label17.Text = "・発注単価は単価契約書によります。"
        Me.Label17.Top = 2.125!
        Me.Label17.Width = 2.625!
        '
        'Label18
        '
        Me.Label18.Height = 0.1875!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 4.875!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle"
        Me.Label18.Text = "・本単価(金額)は消費税抜で表示して "
        Me.Label18.Top = 2.3125!
        Me.Label18.Width = 2.625!
        '
        'Label19
        '
        Me.Label19.Height = 0.1875!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 5!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle"
        Me.Label19.Text = "おります。支払期日には消費税分を"
        Me.Label19.Top = 2.5!
        Me.Label19.Width = 2.5!
        '
        'Label20
        '
        Me.Label20.Height = 0.1875!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 5!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle"
        Me.Label20.Text = "加算して払います。"
        Me.Label20.Top = 2.6875!
        Me.Label20.Width = 2.5!
        '
        'Label21
        '
        Me.Label21.Height = 0.1875!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 4.875!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle"
        Me.Label21.Text = "・品質要求は、『品質保証協定書』によります。"
        Me.Label21.Top = 2.875!
        Me.Label21.Width = 2.625!
        '
        'Label22
        '
        Me.Label22.Height = 0.1875!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 4.625!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label22.Text = "注)"
        Me.Label22.Top = 1.5625!
        Me.Label22.Width = 0.25!
        '
        'Label28
        '
        Me.Label28.Height = 0.25!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 3.1875!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: middle" & _
            ""
        Me.Label28.Text = "納  品  書"
        Me.Label28.Top = 3.4375!
        Me.Label28.Width = 1.3125!
        '
        'Label32
        '
        Me.Label32.Height = 0.3125!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 1.125!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label32.Text = "指示NO"
        Me.Label32.Top = 4.9375!
        Me.Label32.Width = 0.875!
        '
        'Label33
        '
        Me.Label33.Height = 0.3125!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.25!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label33.Text = "社内NO"
        Me.Label33.Top = 4.9375!
        Me.Label33.Width = 0.875!
        '
        'Label34
        '
        Me.Label34.Height = 0.3125!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 2!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label34.Text = "連略号"
        Me.Label34.Top = 4.9375!
        Me.Label34.Width = 0.875!
        '
        'Label35
        '
        Me.Label35.Height = 0.3125!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 2.875!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label35.Text = "図面番号"
        Me.Label35.Top = 4.9375!
        Me.Label35.Width = 1.375!
        '
        'Label36
        '
        Me.Label36.Height = 0.3125!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 4.25!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label36.Text = "カタログ番号"
        Me.Label36.Top = 4.9375!
        Me.Label36.Width = 2!
        '
        'Line19
        '
        Me.Line19.Height = 0!
        Me.Line19.Left = 0.25!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 4.9375!
        Me.Line19.Width = 7.3125!
        Me.Line19.X1 = 0.25!
        Me.Line19.X2 = 7.5625!
        Me.Line19.Y1 = 4.9375!
        Me.Line19.Y2 = 4.9375!
        '
        'Line20
        '
        Me.Line20.Height = 0!
        Me.Line20.Left = 0.25!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 5.25!
        Me.Line20.Width = 7.3125!
        Me.Line20.X1 = 0.25!
        Me.Line20.X2 = 7.5625!
        Me.Line20.Y1 = 5.25!
        Me.Line20.Y2 = 5.25!
        '
        'Line21
        '
        Me.Line21.Height = 0!
        Me.Line21.Left = 0.25!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 6.375!
        Me.Line21.Width = 7.3125!
        Me.Line21.X1 = 0.25!
        Me.Line21.X2 = 7.5625!
        Me.Line21.Y1 = 6.375!
        Me.Line21.Y2 = 6.375!
        '
        'Line22
        '
        Me.Line22.Height = 0!
        Me.Line22.Left = 0.25!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 7.25!
        Me.Line22.Width = 7.3125!
        Me.Line22.X1 = 0.25!
        Me.Line22.X2 = 7.5625!
        Me.Line22.Y1 = 7.25!
        Me.Line22.Y2 = 7.25!
        '
        'Label37
        '
        Me.Label37.Height = 0.3125!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 0.25!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label37.Text = "注文NO"
        Me.Label37.Top = 5.5625!
        Me.Label37.Width = 0.875!
        '
        'Line23
        '
        Me.Line23.Height = 2.625!
        Me.Line23.Left = 0.25!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 4.625!
        Me.Line23.Width = 0!
        Me.Line23.X1 = 0.25!
        Me.Line23.X2 = 0.25!
        Me.Line23.Y1 = 4.625!
        Me.Line23.Y2 = 7.25!
        '
        'Line24
        '
        Me.Line24.Height = 0.875!
        Me.Line24.Left = 0.625!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 6.375!
        Me.Line24.Width = 0!
        Me.Line24.X1 = 0.625!
        Me.Line24.X2 = 0.625!
        Me.Line24.Y1 = 6.375!
        Me.Line24.Y2 = 7.25!
        '
        'Line25
        '
        Me.Line25.Height = 1.4375!
        Me.Line25.Left = 7.5625!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 4.9375!
        Me.Line25.Width = 0!
        Me.Line25.X1 = 7.5625!
        Me.Line25.X2 = 7.5625!
        Me.Line25.Y1 = 4.9375!
        Me.Line25.Y2 = 6.375!
        '
        'Label38
        '
        Me.Label38.Height = 0.3125!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 1.125!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label38.Text = "発注年月日"
        Me.Label38.Top = 5.5625!
        Me.Label38.Width = 0.875!
        '
        'Label39
        '
        Me.Label39.Height = 0.3125!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 2!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label39.Text = "発注数量"
        Me.Label39.Top = 5.5625!
        Me.Label39.Width = 0.875!
        '
        'Label40
        '
        Me.Label40.Height = 0.3125!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 2.875!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label40.Text = "実納入数"
        Me.Label40.Top = 5.5625!
        Me.Label40.Width = 0.875!
        '
        'Line26
        '
        Me.Line26.Height = 1.75!
        Me.Line26.Left = 1.125!
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 4.625!
        Me.Line26.Width = 0!
        Me.Line26.X1 = 1.125!
        Me.Line26.X2 = 1.125!
        Me.Line26.Y1 = 4.625!
        Me.Line26.Y2 = 6.375!
        '
        'Line27
        '
        Me.Line27.Height = 1.4375!
        Me.Line27.Left = 2!
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 4.9375!
        Me.Line27.Width = 0!
        Me.Line27.X1 = 2!
        Me.Line27.X2 = 2!
        Me.Line27.Y1 = 4.9375!
        Me.Line27.Y2 = 6.375!
        '
        'Line28
        '
        Me.Line28.Height = 1.75!
        Me.Line28.Left = 2.875!
        Me.Line28.LineWeight = 1!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 4.625!
        Me.Line28.Width = 0!
        Me.Line28.X1 = 2.875!
        Me.Line28.X2 = 2.875!
        Me.Line28.Y1 = 4.625!
        Me.Line28.Y2 = 6.375!
        '
        'Line29
        '
        Me.Line29.Height = 0!
        Me.Line29.Left = 0.25!
        Me.Line29.LineWeight = 1!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 5.875!
        Me.Line29.Width = 7.3125!
        Me.Line29.X1 = 0.25!
        Me.Line29.X2 = 7.5625!
        Me.Line29.Y1 = 5.875!
        Me.Line29.Y2 = 5.875!
        '
        'Line30
        '
        Me.Line30.Height = 0!
        Me.Line30.Left = 0.25!
        Me.Line30.LineWeight = 1!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 5.5625!
        Me.Line30.Width = 7.3125!
        Me.Line30.X1 = 0.25!
        Me.Line30.X2 = 7.5625!
        Me.Line30.Y1 = 5.5625!
        Me.Line30.Y2 = 5.5625!
        '
        'Line31
        '
        Me.Line31.Height = 0.625!
        Me.Line31.Left = 4.25!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 4.9375!
        Me.Line31.Width = 0!
        Me.Line31.X1 = 4.25!
        Me.Line31.X2 = 4.25!
        Me.Line31.Y1 = 4.9375!
        Me.Line31.Y2 = 5.5625!
        '
        'Line17
        '
        Me.Line17.Height = 0!
        Me.Line17.Left = 0.25!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 4.625!
        Me.Line17.Width = 4.625!
        Me.Line17.X1 = 0.25!
        Me.Line17.X2 = 4.875!
        Me.Line17.Y1 = 4.625!
        Me.Line17.Y2 = 4.625!
        '
        'Line32
        '
        Me.Line32.Height = 0.8125!
        Me.Line32.Left = 3.75!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 5.5625!
        Me.Line32.Width = 0!
        Me.Line32.X1 = 3.75!
        Me.Line32.X2 = 3.75!
        Me.Line32.Y1 = 5.5625!
        Me.Line32.Y2 = 6.375!
        '
        'Line33
        '
        Me.Line33.Height = 0.625!
        Me.Line33.Left = 6.25!
        Me.Line33.LineWeight = 1!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 4.9375!
        Me.Line33.Width = 0!
        Me.Line33.X1 = 6.25!
        Me.Line33.X2 = 6.25!
        Me.Line33.Y1 = 4.9375!
        Me.Line33.Y2 = 5.5625!
        '
        'Line34
        '
        Me.Line34.Height = 0.8125!
        Me.Line34.Left = 4.6875!
        Me.Line34.LineWeight = 1!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 5.5625!
        Me.Line34.Width = 0!
        Me.Line34.X1 = 4.6875!
        Me.Line34.X2 = 4.6875!
        Me.Line34.Y1 = 5.5625!
        Me.Line34.Y2 = 6.375!
        '
        'Line35
        '
        Me.Line35.Height = 0.8125!
        Me.Line35.Left = 5.625!
        Me.Line35.LineWeight = 1!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 5.5625!
        Me.Line35.Width = 0!
        Me.Line35.X1 = 5.625!
        Me.Line35.X2 = 5.625!
        Me.Line35.Y1 = 5.5625!
        Me.Line35.Y2 = 6.375!
        '
        'Line36
        '
        Me.Line36.Height = 0.8125!
        Me.Line36.Left = 6.75!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 5.5625!
        Me.Line36.Width = 0!
        Me.Line36.X1 = 6.75!
        Me.Line36.X2 = 6.75!
        Me.Line36.Y1 = 5.5625!
        Me.Line36.Y2 = 6.375!
        '
        'Line37
        '
        Me.Line37.Height = 0.3125!
        Me.Line37.Left = 7.125!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 4.625!
        Me.Line37.Width = 0!
        Me.Line37.X1 = 7.125!
        Me.Line37.X2 = 7.125!
        Me.Line37.Y1 = 4.625!
        Me.Line37.Y2 = 4.9375!
        '
        'Line38
        '
        Me.Line38.Height = 0.3125!
        Me.Line38.Left = 4.875!
        Me.Line38.LineWeight = 1!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 4.625!
        Me.Line38.Width = 0!
        Me.Line38.X1 = 4.875!
        Me.Line38.X2 = 4.875!
        Me.Line38.Y1 = 4.625!
        Me.Line38.Y2 = 4.9375!
        '
        'Label29
        '
        Me.Label29.Height = 0.1875!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 0.5!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label29.Text = "メイラ株式会社"
        Me.Label29.Top = 4.125!
        Me.Label29.Width = 1!
        '
        'Label30
        '
        Me.Label30.Height = 0.1875!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 1!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label30.Text = "メディカル事業部"
        Me.Label30.Top = 4.3125!
        Me.Label30.Width = 1.1875!
        '
        'Line39
        '
        Me.Line39.Height = 0.875!
        Me.Line39.Left = 6.375!
        Me.Line39.LineWeight = 1!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 6.375!
        Me.Line39.Width = 0!
        Me.Line39.X1 = 6.375!
        Me.Line39.X2 = 6.375!
        Me.Line39.Y1 = 6.375!
        Me.Line39.Y2 = 7.25!
        '
        'Line40
        '
        Me.Line40.Height = 0.875!
        Me.Line40.Left = 5.1875!
        Me.Line40.LineWeight = 1!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 6.375!
        Me.Line40.Width = 0!
        Me.Line40.X1 = 5.1875!
        Me.Line40.X2 = 5.1875!
        Me.Line40.Y1 = 6.375!
        Me.Line40.Y2 = 7.25!
        '
        'Line41
        '
        Me.Line41.Height = 0!
        Me.Line41.Left = 5.1875!
        Me.Line41.LineWeight = 1!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 6.625!
        Me.Line41.Width = 2.375!
        Me.Line41.X1 = 5.1875!
        Me.Line41.X2 = 7.5625!
        Me.Line41.Y1 = 6.625!
        Me.Line41.Y2 = 6.625!
        '
        'Line42
        '
        Me.Line42.Height = 0.25!
        Me.Line42.Left = 3.1875!
        Me.Line42.LineWeight = 1!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 3.4375!
        Me.Line42.Width = 0!
        Me.Line42.X1 = 3.1875!
        Me.Line42.X2 = 3.1875!
        Me.Line42.Y1 = 3.4375!
        Me.Line42.Y2 = 3.6875!
        '
        'Line43
        '
        Me.Line43.Height = 0.25!
        Me.Line43.Left = 4.5!
        Me.Line43.LineWeight = 1!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 3.4375!
        Me.Line43.Width = 0!
        Me.Line43.X1 = 4.5!
        Me.Line43.X2 = 4.5!
        Me.Line43.Y1 = 3.4375!
        Me.Line43.Y2 = 3.6875!
        '
        'Line44
        '
        Me.Line44.Height = 0!
        Me.Line44.Left = 3.1875!
        Me.Line44.LineWeight = 1!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 3.4375!
        Me.Line44.Width = 1.3125!
        Me.Line44.X1 = 3.1875!
        Me.Line44.X2 = 4.5!
        Me.Line44.Y1 = 3.4375!
        Me.Line44.Y2 = 3.4375!
        '
        'Line45
        '
        Me.Line45.Height = 0!
        Me.Line45.Left = 3.1875!
        Me.Line45.LineWeight = 1!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 3.6875!
        Me.Line45.Width = 1.3125!
        Me.Line45.X1 = 3.1875!
        Me.Line45.X2 = 4.5!
        Me.Line45.Y1 = 3.6875!
        Me.Line45.Y2 = 3.6875!
        '
        'Label
        '
        Me.Label.Height = 0.25!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 3.1875!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: middle" & _
            ""
        Me.Label.Text = "仮 受 領 書"
        Me.Label.Top = 7.8125!
        Me.Label.Width = 1.3125!
        '
        'Line50
        '
        Me.Line50.Height = 0.25!
        Me.Line50.Left = 3.1875!
        Me.Line50.LineWeight = 1!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 7.8125!
        Me.Line50.Width = 0!
        Me.Line50.X1 = 3.1875!
        Me.Line50.X2 = 3.1875!
        Me.Line50.Y1 = 7.8125!
        Me.Line50.Y2 = 8.0625!
        '
        'Line51
        '
        Me.Line51.Height = 0.25!
        Me.Line51.Left = 4.5!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 7.8125!
        Me.Line51.Width = 0!
        Me.Line51.X1 = 4.5!
        Me.Line51.X2 = 4.5!
        Me.Line51.Y1 = 7.8125!
        Me.Line51.Y2 = 8.0625!
        '
        'Line52
        '
        Me.Line52.Height = 0!
        Me.Line52.Left = 3.1875!
        Me.Line52.LineWeight = 1!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 7.8125!
        Me.Line52.Width = 1.3125!
        Me.Line52.X1 = 3.1875!
        Me.Line52.X2 = 4.5!
        Me.Line52.Y1 = 7.8125!
        Me.Line52.Y2 = 7.8125!
        '
        'Line53
        '
        Me.Line53.Height = 0!
        Me.Line53.Left = 3.1875!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 8.0625!
        Me.Line53.Width = 1.3125!
        Me.Line53.X1 = 3.1875!
        Me.Line53.X2 = 4.5!
        Me.Line53.Y1 = 8.0625!
        Me.Line53.Y2 = 8.0625!
        '
        'Label1
        '
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 2.25!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label1.Text = "御中"
        Me.Label1.Top = 4.3125!
        Me.Label1.Width = 0.375!
        '
        'Label52
        '
        Me.Label52.Height = 0.1875!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 6.875!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label52.Text = "印"
        Me.Label52.Top = 4.3125!
        Me.Label52.Width = 0.25!
        '
        'Line56
        '
        Me.Line56.Height = 0!
        Me.Line56.Left = 0.25!
        Me.Line56.LineWeight = 1!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 8.625!
        Me.Line56.Width = 7.3125!
        Me.Line56.X1 = 0.25!
        Me.Line56.X2 = 7.5625!
        Me.Line56.Y1 = 8.625!
        Me.Line56.Y2 = 8.625!
        '
        'Line57
        '
        Me.Line57.Height = 0!
        Me.Line57.Left = 0.25!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 8.9375!
        Me.Line57.Width = 7.3125!
        Me.Line57.X1 = 0.25!
        Me.Line57.X2 = 7.5625!
        Me.Line57.Y1 = 8.9375!
        Me.Line57.Y2 = 8.9375!
        '
        'Line59
        '
        Me.Line59.Height = 0!
        Me.Line59.Left = 0.25!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 10.5!
        Me.Line59.Width = 7.3125!
        Me.Line59.X1 = 0.25!
        Me.Line59.X2 = 7.5625!
        Me.Line59.Y1 = 10.5!
        Me.Line59.Y2 = 10.5!
        '
        'Line60
        '
        Me.Line60.Height = 0!
        Me.Line60.Left = 0.25!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 10.125!
        Me.Line60.Width = 7.3125!
        Me.Line60.X1 = 0.25!
        Me.Line60.X2 = 7.5625!
        Me.Line60.Y1 = 10.125!
        Me.Line60.Y2 = 10.125!
        '
        'Line58
        '
        Me.Line58.Height = 0!
        Me.Line58.Left = 0.25!
        Me.Line58.LineWeight = 1!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 9.25!
        Me.Line58.Width = 7.3125!
        Me.Line58.X1 = 0.25!
        Me.Line58.X2 = 7.5625!
        Me.Line58.Y1 = 9.25!
        Me.Line58.Y2 = 9.25!
        '
        'Line61
        '
        Me.Line61.Height = 1.875!
        Me.Line61.Left = 0.25!
        Me.Line61.LineWeight = 1!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 8.625!
        Me.Line61.Width = 0!
        Me.Line61.X1 = 0.25!
        Me.Line61.X2 = 0.25!
        Me.Line61.Y1 = 8.625!
        Me.Line61.Y2 = 10.5!
        '
        'Line62
        '
        Me.Line62.Height = 0.625!
        Me.Line62.Left = 1.375!
        Me.Line62.LineWeight = 1!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 8.625!
        Me.Line62.Width = 0!
        Me.Line62.X1 = 1.375!
        Me.Line62.X2 = 1.375!
        Me.Line62.Y1 = 8.625!
        Me.Line62.Y2 = 9.25!
        '
        'Line63
        '
        Me.Line63.Height = 0.625!
        Me.Line63.Left = 2.5!
        Me.Line63.LineWeight = 1!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 8.625!
        Me.Line63.Width = 0!
        Me.Line63.X1 = 2.5!
        Me.Line63.X2 = 2.5!
        Me.Line63.Y1 = 8.625!
        Me.Line63.Y2 = 9.25!
        '
        'Line64
        '
        Me.Line64.Height = 1.875!
        Me.Line64.Left = 7.5625!
        Me.Line64.LineWeight = 1!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 8.625!
        Me.Line64.Width = 0!
        Me.Line64.X1 = 7.5625!
        Me.Line64.X2 = 7.5625!
        Me.Line64.Y1 = 8.625!
        Me.Line64.Y2 = 10.5!
        '
        'Line65
        '
        Me.Line65.Height = 0.625!
        Me.Line65.Left = 5.4375!
        Me.Line65.LineWeight = 1!
        Me.Line65.Name = "Line65"
        Me.Line65.Top = 8.625!
        Me.Line65.Width = 0!
        Me.Line65.X1 = 5.4375!
        Me.Line65.X2 = 5.4375!
        Me.Line65.Y1 = 8.625!
        Me.Line65.Y2 = 9.25!
        '
        'Line66
        '
        Me.Line66.Height = 0.625!
        Me.Line66.Left = 6.5!
        Me.Line66.LineWeight = 1!
        Me.Line66.Name = "Line66"
        Me.Line66.Top = 8.625!
        Me.Line66.Width = 0!
        Me.Line66.X1 = 6.5!
        Me.Line66.X2 = 6.5!
        Me.Line66.Y1 = 8.625!
        Me.Line66.Y2 = 9.25!
        '
        'Line67
        '
        Me.Line67.Height = 0.875!
        Me.Line67.Left = 0.625!
        Me.Line67.LineWeight = 1!
        Me.Line67.Name = "Line67"
        Me.Line67.Top = 9.25!
        Me.Line67.Width = 0!
        Me.Line67.X1 = 0.625!
        Me.Line67.X2 = 0.625!
        Me.Line67.Y1 = 9.25!
        Me.Line67.Y2 = 10.125!
        '
        'Label62
        '
        Me.Label62.Height = 0.1875!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 0.5625!
        Me.Label62.Name = "Label62"
        Me.Label62.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label62.Text = "174-140C"
        Me.Label62.Top = 10.625!
        Me.Label62.Width = 0.6875!
        '
        'Line68
        '
        Me.Line68.Height = 0!
        Me.Line68.Left = 0.5625!
        Me.Line68.LineWeight = 1!
        Me.Line68.Name = "Line68"
        Me.Line68.Top = 10.625!
        Me.Line68.Width = 0.6875!
        Me.Line68.X1 = 0.5625!
        Me.Line68.X2 = 1.25!
        Me.Line68.Y1 = 10.625!
        Me.Line68.Y2 = 10.625!
        '
        'Line69
        '
        Me.Line69.Height = 0!
        Me.Line69.Left = 0.5625!
        Me.Line69.LineWeight = 1!
        Me.Line69.Name = "Line69"
        Me.Line69.Top = 10.8125!
        Me.Line69.Width = 0.6875!
        Me.Line69.X1 = 0.5625!
        Me.Line69.X2 = 1.25!
        Me.Line69.Y1 = 10.8125!
        Me.Line69.Y2 = 10.8125!
        '
        'Line70
        '
        Me.Line70.Height = 0.1875!
        Me.Line70.Left = 0.5625!
        Me.Line70.LineWeight = 1!
        Me.Line70.Name = "Line70"
        Me.Line70.Top = 10.625!
        Me.Line70.Width = 0!
        Me.Line70.X1 = 0.5625!
        Me.Line70.X2 = 0.5625!
        Me.Line70.Y1 = 10.625!
        Me.Line70.Y2 = 10.8125!
        '
        'Line71
        '
        Me.Line71.Height = 0.1875!
        Me.Line71.Left = 1.25!
        Me.Line71.LineWeight = 1!
        Me.Line71.Name = "Line71"
        Me.Line71.Top = 10.625!
        Me.Line71.Width = 0!
        Me.Line71.X1 = 1.25!
        Me.Line71.X2 = 1.25!
        Me.Line71.Y1 = 10.625!
        Me.Line71.Y2 = 10.8125!
        '
        'Line72
        '
        Me.Line72.Height = 0.5!
        Me.Line72.Left = 6.5!
        Me.Line72.LineWeight = 1!
        Me.Line72.Name = "Line72"
        Me.Line72.Top = 5.875!
        Me.Line72.Width = 0!
        Me.Line72.X1 = 6.5!
        Me.Line72.X2 = 6.5!
        Me.Line72.Y1 = 5.875!
        Me.Line72.Y2 = 6.375!
        '
        'TextBox
        '
        Me.TextBox.DataField = "CONTRACTOUT_CD"
        Me.TextBox.Height = 0.188!
        Me.TextBox.Left = 4.4375!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.TextBox.Text = "外注コード"
        Me.TextBox.Top = 4.1375!
        Me.TextBox.Width = 1!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "CONTRACTOUT_NM"
        Me.TextBox1.Height = 0.188!
        Me.TextBox1.Left = 4.5625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.TextBox1.Text = "外注名称"
        Me.TextBox1.Top = 4.3125!
        Me.TextBox1.Width = 2.125!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "CONTRACTOUT_CD"
        Me.TextBox2.Height = 0.188!
        Me.TextBox2.Left = 0.3125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.TextBox2.Text = "外注コード"
        Me.TextBox2.Top = 8.125!
        Me.TextBox2.Width = 1!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "CONTRACTOUT_NM"
        Me.TextBox3.Height = 0.188!
        Me.TextBox3.Left = 0.4375!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.TextBox3.Text = "外注名称"
        Me.TextBox3.Top = 8.3125!
        Me.TextBox3.Width = 2.1875!
        '
        'Label53
        '
        Me.Label53.Height = 0.1875!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 2.6875!
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label53.Text = "御中"
        Me.Label53.Top = 8.3125!
        Me.Label53.Width = 0.375!
        '
        'Barcode1
        '
        Me.Barcode1.CheckSumEnabled = false
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8!)
        Me.Barcode1.Height = 0.25!
        Me.Barcode1.Left = 0.5!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.QuietZoneBottom = 0!
        Me.Barcode1.QuietZoneLeft = 0!
        Me.Barcode1.QuietZoneRight = 0!
        Me.Barcode1.QuietZoneTop = 0!
        Me.Barcode1.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode1.Text = "Barcode"
        Me.Barcode1.Top = 3.625!
        Me.Barcode1.Width = 1.9375!
        '
        'Barcode2
        '
        Me.Barcode2.CheckSumEnabled = false
        Me.Barcode2.Font = New System.Drawing.Font("Courier New", 8!)
        Me.Barcode2.Height = 0.25!
        Me.Barcode2.Left = 5.125!
        Me.Barcode2.Name = "Barcode2"
        Me.Barcode2.QuietZoneBottom = 0!
        Me.Barcode2.QuietZoneLeft = 0!
        Me.Barcode2.QuietZoneRight = 0!
        Me.Barcode2.QuietZoneTop = 0!
        Me.Barcode2.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode2.Text = "Barcode1"
        Me.Barcode2.Top = 3.625!
        Me.Barcode2.Width = 2.1875!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.25!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.75!
        Me.Line2.Width = 3!
        Me.Line2.X1 = 0.25!
        Me.Line2.X2 = 3.25!
        Me.Line2.Y1 = 0.75!
        Me.Line2.Y2 = 0.75!
        '
        'Line3
        '
        Me.Line3.Height = 0!
        Me.Line3.Left = 5.375!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.75!
        Me.Line3.Width = 2!
        Me.Line3.X1 = 5.375!
        Me.Line3.X2 = 7.375!
        Me.Line3.Y1 = 0.75!
        Me.Line3.Y2 = 0.75!
        '
        'Line55
        '
        Me.Line55.Height = 0!
        Me.Line55.Left = 0.1875!
        Me.Line55.LineWeight = 1!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 8.5!
        Me.Line55.Width = 3!
        Me.Line55.X1 = 0.1875!
        Me.Line55.X2 = 3.1875!
        Me.Line55.Y1 = 8.5!
        Me.Line55.Y2 = 8.5!
        '
        'lblCode1
        '
        Me.lblCode1.DataField = "ORDER_NO"
        Me.lblCode1.Height = 0.1875!
        Me.lblCode1.HyperLink = Nothing
        Me.lblCode1.Left = 0.5!
        Me.lblCode1.Name = "lblCode1"
        Me.lblCode1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.lblCode1.Text = "Label68"
        Me.lblCode1.Top = 3.875!
        Me.lblCode1.Width = 1.9375!
        '
        'lblCode2
        '
        Me.lblCode2.Height = 0.1875!
        Me.lblCode2.HyperLink = Nothing
        Me.lblCode2.Left = 5.125!
        Me.lblCode2.Name = "lblCode2"
        Me.lblCode2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.lblCode2.Text = "Label68"
        Me.lblCode2.Top = 3.875!
        Me.lblCode2.Width = 2.1875!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "NOTE_2"
        Me.TextBox4.Height = 0.188!
        Me.TextBox4.Left = 0.9375!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt"
        Me.TextBox4.Text = "備考2"
        Me.TextBox4.Top = 9.5005!
        Me.TextBox4.Width = 3.0625!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "NOTE_4"
        Me.TextBox5.Height = 0.188!
        Me.TextBox5.Left = 0.9375!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ ゴシック; font-size: 9pt"
        Me.TextBox5.Text = "備考4"
        Me.TextBox5.Top = 9.8755!
        Me.TextBox5.Width = 3.0625!
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "NOTE_3"
        Me.TextBox6.Height = 0.188!
        Me.TextBox6.Left = 0.9375!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt"
        Me.TextBox6.Text = "備考3"
        Me.TextBox6.Top = 9.688!
        Me.TextBox6.Width = 3.0625!
        '
        'TextBox7
        '
        Me.TextBox7.DataField = "NOTE_1"
        Me.TextBox7.Height = 0.188!
        Me.TextBox7.Left = 0.9375!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt"
        Me.TextBox7.Text = "備考1"
        Me.TextBox7.Top = 9.313!
        Me.TextBox7.Width = 3.0625!
        '
        'Label70
        '
        Me.Label70.Height = 0.1875!
        Me.Label70.HyperLink = Nothing
        Me.Label70.Left = 4.125!
        Me.Label70.Name = "Label70"
        Me.Label70.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.Label70.Text = "納"
        Me.Label70.Top = 4.0625!
        Me.Label70.Width = 0.1875!
        '
        'Label71
        '
        Me.Label71.Height = 0.1875!
        Me.Label71.HyperLink = Nothing
        Me.Label71.Left = 4.125!
        Me.Label71.Name = "Label71"
        Me.Label71.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label71.Text = "入"
        Me.Label71.Top = 4.1875!
        Me.Label71.Width = 0.1875!
        '
        'Label72
        '
        Me.Label72.Height = 0.1875!
        Me.Label72.HyperLink = Nothing
        Me.Label72.Left = 4.125!
        Me.Label72.Name = "Label72"
        Me.Label72.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label72.Text = "者"
        Me.Label72.Top = 4.3125!
        Me.Label72.Width = 0.1875!
        '
        'Line54
        '
        Me.Line54.Height = 0!
        Me.Line54.Left = 4!
        Me.Line54.LineWeight = 1!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 4.5!
        Me.Line54.Width = 3.25!
        Me.Line54.X1 = 4!
        Me.Line54.X2 = 7.25!
        Me.Line54.Y1 = 4.5!
        Me.Line54.Y2 = 4.5!
        '
        'Line18
        '
        Me.Line18.Height = 0!
        Me.Line18.Left = 0.25!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 4.5!
        Me.Line18.Width = 2.4375!
        Me.Line18.X1 = 0.25!
        Me.Line18.X2 = 2.6875!
        Me.Line18.Y1 = 4.5!
        Me.Line18.Y2 = 4.5!
        '
        'Line73
        '
        Me.Line73.Height = 0.875!
        Me.Line73.Left = 7.5625!
        Me.Line73.LineWeight = 1!
        Me.Line73.Name = "Line73"
        Me.Line73.Top = 6.375!
        Me.Line73.Width = 0!
        Me.Line73.X1 = 7.5625!
        Me.Line73.X2 = 7.5625!
        Me.Line73.Y1 = 6.375!
        Me.Line73.Y2 = 7.25!
        '
        'TextBox8
        '
        Me.TextBox8.DataField = "NOTE_2"
        Me.TextBox8.Height = 0.188!
        Me.TextBox8.Left = 0.875!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.TextBox8.Text = "備考2"
        Me.TextBox8.Top = 6.6255!
        Me.TextBox8.Width = 3.625!
        '
        'TextBox9
        '
        Me.TextBox9.DataField = "NOTE_4"
        Me.TextBox9.Height = 0.188!
        Me.TextBox9.Left = 0.875!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.TextBox9.Text = "備考4"
        Me.TextBox9.Top = 7.0005!
        Me.TextBox9.Width = 3.625!
        '
        'TextBox10
        '
        Me.TextBox10.DataField = "NOTE_3"
        Me.TextBox10.Height = 0.188!
        Me.TextBox10.Left = 0.875!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.TextBox10.Text = "備考3"
        Me.TextBox10.Top = 6.813!
        Me.TextBox10.Width = 3.625!
        '
        'TextBox11
        '
        Me.TextBox11.DataField = "NOTE_1"
        Me.TextBox11.Height = 0.188!
        Me.TextBox11.Left = 0.875!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle"
        Me.TextBox11.Text = "備考1"
        Me.TextBox11.Top = 6.4375!
        Me.TextBox11.Width = 3.625!
        '
        'Line49
        '
        Me.Line49.Height = 0!
        Me.Line49.Left = 3.1875!
        Me.Line49.LineWeight = 1!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 0.3125!
        Me.Line49.Width = 1.3125!
        Me.Line49.X1 = 3.1875!
        Me.Line49.X2 = 4.5!
        Me.Line49.Y1 = 0.3125!
        Me.Line49.Y2 = 0.3125!
        '
        'Line48
        '
        Me.Line48.Height = 0!
        Me.Line48.Left = 3.1875!
        Me.Line48.LineWeight = 1!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 0.0625!
        Me.Line48.Width = 1.3125!
        Me.Line48.X1 = 3.1875!
        Me.Line48.X2 = 4.5!
        Me.Line48.Y1 = 0.0625!
        Me.Line48.Y2 = 0.0625!
        '
        'Line47
        '
        Me.Line47.Height = 0.25!
        Me.Line47.Left = 4.5!
        Me.Line47.LineWeight = 1!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 0.0625!
        Me.Line47.Width = 0!
        Me.Line47.X1 = 4.5!
        Me.Line47.X2 = 4.5!
        Me.Line47.Y1 = 0.0625!
        Me.Line47.Y2 = 0.3125!
        '
        'Line46
        '
        Me.Line46.Height = 0.25!
        Me.Line46.Left = 3.1875!
        Me.Line46.LineWeight = 1!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 0.0625!
        Me.Line46.Width = 0!
        Me.Line46.X1 = 3.1875!
        Me.Line46.X2 = 3.1875!
        Me.Line46.Y1 = 0.0625!
        Me.Line46.Y2 = 0.3125!
        '
        'Line74
        '
        Me.Line74.Height = 0!
        Me.Line74.Left = 4.875!
        Me.Line74.LineWeight = 1!
        Me.Line74.Name = "Line74"
        Me.Line74.Top = 4.625!
        Me.Line74.Width = 2.25!
        Me.Line74.X1 = 7.125!
        Me.Line74.X2 = 4.875!
        Me.Line74.Y1 = 4.625!
        Me.Line74.Y2 = 4.625!
        '
        'lblSai1
        '
        Me.lblSai1.Height = 0.25!
        Me.lblSai1.HyperLink = Nothing
        Me.lblSai1.Left = 6.4375!
        Me.lblSai1.Name = "lblSai1"
        Me.lblSai1.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: middle"
        Me.lblSai1.Text = ""
        Me.lblSai1.Top = 0.0625!
        Me.lblSai1.Width = 0.9375!
        '
        'lblSai2
        '
        Me.lblSai2.Height = 0.25!
        Me.lblSai2.HyperLink = Nothing
        Me.lblSai2.Left = 6.4375!
        Me.lblSai2.Name = "lblSai2"
        Me.lblSai2.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: middle"
        Me.lblSai2.Text = ""
        Me.lblSai2.Top = 3.375!
        Me.lblSai2.Width = 0.9375!
        '
        'lblSai3
        '
        Me.lblSai3.Height = 0.25!
        Me.lblSai3.HyperLink = Nothing
        Me.lblSai3.Left = 6.4375!
        Me.lblSai3.Name = "lblSai3"
        Me.lblSai3.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: middle"
        Me.lblSai3.Text = ""
        Me.lblSai3.Top = 7.8125!
        Me.lblSai3.Width = 0.9375!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.3!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.3!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.677083!
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
        CType(Me.txtIrai, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPROCESS_ORDER1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNOTE_2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNOTE_4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNOTE_3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNOTE_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_AMT1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_DT1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt連略号, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSKETCH_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPRICE2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPRICE1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPLAN_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_DELIVERY1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPRICE, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_AMT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPROCESS_ORDER, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_DELIVERY, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtORDER_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCONTRACTOUT_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
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
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCode2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label71, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label72, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSai1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSai2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSai3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Public WriteOnly Property SaiHakkou() As String
        Set(ByVal sValue As String)
            lblSai1.Text = sValue
            lblSai2.Text = sValue
            lblSai3.Text = sValue
        End Set
    End Property

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        'txtORDER_DT.Text = txtORDER_DT.Text.Substring(2, 2) + "/" + txtORDER_DT.Text.Substring(4, 2) + "/" + txtORDER_DT.Text.Substring(6, 2) 
        'txtCONTRACTOUT_DELIVERY.Text = txtCONTRACTOUT_DELIVERY.Text.Substring(2, 2) + "/" + txtCONTRACTOUT_DELIVERY.Text.Substring(4, 2) + "/" + txtCONTRACTOUT_DELIVERY.Text.Substring(6, 2) 
        'Barcode1.Text = Fields("ORDER_NO").Value 
        'lblCode1.Text = "*" + lblCode1.Text + "*" 
        'txtCONTRACTOUT_DELIVERY1.Text = txtCONTRACTOUT_DELIVERY1.Text.Substring(2, 2) + " 年 " + txtCONTRACTOUT_DELIVERY1.Text.Substring(4, 2) + " 月 " + txtCONTRACTOUT_DELIVERY1.Text.Substring(6, 2) + " 日 " 
        'If txtPLAN_DT.Text <> "" Then 
        '    txtPLAN_DT.Text = txtPLAN_DT.Text.Substring(0, 4) + " 年 " + txtPLAN_DT.Text.Substring(4, 2) + " 月 " + txtPLAN_DT.Text.Substring(6, 2) + " 日 " 
        '    txtPLAN_DT.Visible = True 
        '    Label48.Visible = True 
        '    Line74.Visible = True 
        '    Line37.Visible = True 
        'Else 
        '    txtPLAN_DT.Visible = False 
        '    Label48.Visible = False 
        '    Line74.Visible = False 
        '    Line37.Visible = False 
        'End If 
        'txtORDER_DT1.Text = txtORDER_DT1.Text.Substring(2, 2) + "/" + txtORDER_DT1.Text.Substring(4, 2) + "/" + txtORDER_DT1.Text.Substring(6, 2) 
        'Barcode2.Text = Fields("COMPANY_NO").Value + Fields("INDICATE_NO").Value 
        'lblCode2.Text = "*" + Fields("COMPANY_NO").Value + Fields("INDICATE_NO").Value + "*" 
    End Sub
End Class 
