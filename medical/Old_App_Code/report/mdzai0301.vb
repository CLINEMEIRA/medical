Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdzai0301
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
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKanriNM1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHakkouYMD1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblTitle1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuCD1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuNM1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKeikakuNouki1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKeikakuRyo1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKbn1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblRenNO1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZaiCD1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTanka1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKingaku1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZaiNM1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou1_1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou1_2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou1_3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private LabelY As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKanriNM2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHakkouYMD2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuCD2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuNM2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKeikakuNouki2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKeikakuRyo2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKbn2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblRenNO2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZaiCD2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShuZaiNM2_1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTanka2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKingaku2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZaiNM2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label45 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou2_1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou2_2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou2_3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSenzai2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label50 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label51 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label52 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShuZaiNM1_1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou1_4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSenzai1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou2_4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdzai0301))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKanriNM1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHakkouYMD1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblTitle1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuCD1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuNM1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKeikakuNouki1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKeikakuRyo1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKbn1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRenNO1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZaiCD1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTanka1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKingaku1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZaiNM1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou1_1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou1_2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou1_3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.LabelY = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKanriNM2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHakkouYMD2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuCD2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuNM2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKeikakuNouki2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKeikakuRyo2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKbn2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRenNO2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZaiCD2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShuZaiNM2_1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTanka2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKingaku2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZaiNM2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label45 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou2_1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou2_2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou2_3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSenzai2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label50 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label51 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label52 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShuZaiNM1_1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou1_4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSenzai1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou2_4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKanriNM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHakkouYMD1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTitle1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuCD1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuNM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKeikakuNouki1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKeikakuRyo1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKbn1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRenNO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZaiCD1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTanka1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKingaku1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZaiNM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou1_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou1_2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou1_3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LabelY, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKanriNM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHakkouYMD2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuCD2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuNM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKeikakuNouki2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKeikakuRyo2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKbn2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRenNO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZaiCD2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShuZaiNM2_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTanka2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKingaku2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZaiNM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou2_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou2_2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou2_3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSenzai2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShuZaiNM1_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou1_4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSenzai1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou2_4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label31, Me.Label28, Me.Label11, Me.lblKanriNM1, Me.lblHakkouYMD1, Me.Line36, Me.Line22, Me.Line51, Me.Line52, Me.Line53, Me.Line54, Me.Line55, Me.Line57, Me.Line59, Me.Line60, Me.Line61, Me.Line62, Me.lblTitle1, Me.lblHatyuCD1, Me.Label1, Me.lblHatyuNM1, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Label12, Me.Line6, Me.Line7, Me.Line8, Me.Line, Me.Line9, Me.Label13, Me.Label14, Me.lblKeikakuNouki1, Me.lblKeikakuRyo1, Me.lblKbn1, Me.lblRenNO1, Me.lblZaiCD1, Me.lblTanka1, Me.lblKingaku1, Me.lblZaiNM1, Me.Label25, Me.lblBikou1_1, Me.lblBikou1_2, Me.lblBikou1_3, Me.LabelY, Me.Shape, Me.Label2, Me.lblKanriNM2, Me.lblHakkouYMD2, Me.Line10, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Label17, Me.lblHatyuCD2, Me.Label19, Me.lblHatyuNM2, Me.label, Me.Label22, Me.Label23, Me.Label24, Me.Label26, Me.Label27, Me.Label30, Me.Line23, Me.Line24, Me.Line25, Me.Line26, Me.Line27, Me.Label32, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Label33, Me.Label34, Me.lblKeikakuNouki2, Me.lblKeikakuRyo2, Me.lblKbn2, Me.lblRenNO2, Me.lblZaiCD2, Me.lblShuZaiNM2_1, Me.lblTanka2, Me.lblKingaku2, Me.lblZaiNM2, Me.Label45, Me.lblBikou2_1, Me.lblBikou2_2, Me.lblBikou2_3, Me.lblSenzai2, Me.Label50, Me.Shape1, Me.Label51, Me.Line32, Me.Label52, Me.lblShuZaiNM1_1, Me.lblBikou1_4, Me.lblSenzai1, Me.lblBikou2_4})
        Me.Detail.Height = 10.63542!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.1354167!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Visible = false
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'Label31
        '
        Me.Label31.Height = 0.18!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 5.25!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label31.Text = "グループ長"
        Me.Label31.Top = 9.053!
        Me.Label31.Width = 0.8125!
        '
        'Label28
        '
        Me.Label28.Height = 0.18!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 3.9375!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label28.Text = "材料コード"
        Me.Label28.Top = 6.9375!
        Me.Label28.Width = 0.75!
        '
        'Label11
        '
        Me.Label11.Height = 0.18!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 5.3125!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label11.Text = "グループ長"
        Me.Label11.Top = 3.37!
        Me.Label11.Width = 0.75!
        '
        'lblKanriNM1
        '
        Me.lblKanriNM1.DataField = "ORDER_NO"
        Me.lblKanriNM1.Height = 0.2!
        Me.lblKanriNM1.HyperLink = Nothing
        Me.lblKanriNM1.Left = 0.125!
        Me.lblKanriNM1.Name = "lblKanriNM1"
        Me.lblKanriNM1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblKanriNM1.Text = "XXXXXXX"
        Me.lblKanriNM1.Top = 0.9375!
        Me.lblKanriNM1.Width = 0.625!
        '
        'lblHakkouYMD1
        '
        Me.lblHakkouYMD1.DataField = "ORDER_DT"
        Me.lblHakkouYMD1.Height = 0.2!
        Me.lblHakkouYMD1.HyperLink = Nothing
        Me.lblHakkouYMD1.Left = 0.9375!
        Me.lblHakkouYMD1.Name = "lblHakkouYMD1"
        Me.lblHakkouYMD1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHakkouYMD1.Text = "YY/MM/DD"
        Me.lblHakkouYMD1.Top = 0.9375!
        Me.lblHakkouYMD1.Width = 0.75!
        '
        'Line36
        '
        Me.Line36.Height = 5.960464E-08!
        Me.Line36.Left = 0!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 0.5625!
        Me.Line36.Width = 1.721!
        Me.Line36.X1 = 0!
        Me.Line36.X2 = 1.721!
        Me.Line36.Y1 = 0.5625!
        Me.Line36.Y2 = 0.5625001!
        '
        'Line22
        '
        Me.Line22.Height = 2.1255!
        Me.Line22.Left = 0!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 0.5625!
        Me.Line22.Width = 0!
        Me.Line22.X1 = 0!
        Me.Line22.X2 = 0!
        Me.Line22.Y1 = 0.5625!
        Me.Line22.Y2 = 2.688!
        '
        'Line51
        '
        Me.Line51.Height = 0!
        Me.Line51.Left = 0!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 0.8125!
        Me.Line51.Width = 1.721!
        Me.Line51.X1 = 0!
        Me.Line51.X2 = 1.721!
        Me.Line51.Y1 = 0.8125!
        Me.Line51.Y2 = 0.8125!
        '
        'Line52
        '
        Me.Line52.Height = 0!
        Me.Line52.Left = 0!
        Me.Line52.LineWeight = 1!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 1.158333!
        Me.Line52.Width = 7.333333!
        Me.Line52.X1 = 0!
        Me.Line52.X2 = 7.333333!
        Me.Line52.Y1 = 1.158333!
        Me.Line52.Y2 = 1.158333!
        '
        'Line53
        '
        Me.Line53.Height = 0!
        Me.Line53.Left = 0!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 1.429167!
        Me.Line53.Width = 7.333333!
        Me.Line53.X1 = 0!
        Me.Line53.X2 = 7.333333!
        Me.Line53.Y1 = 1.429167!
        Me.Line53.Y2 = 1.429167!
        '
        'Line54
        '
        Me.Line54.Height = 0!
        Me.Line54.Left = 0!
        Me.Line54.LineWeight = 1!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 1.7625!
        Me.Line54.Width = 7.333333!
        Me.Line54.X1 = 0!
        Me.Line54.X2 = 7.333333!
        Me.Line54.Y1 = 1.7625!
        Me.Line54.Y2 = 1.7625!
        '
        'Line55
        '
        Me.Line55.Height = 0!
        Me.Line55.Left = 0!
        Me.Line55.LineWeight = 1!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 2.095834!
        Me.Line55.Width = 2.525!
        Me.Line55.X1 = 0!
        Me.Line55.X2 = 2.525!
        Me.Line55.Y1 = 2.095834!
        Me.Line55.Y2 = 2.095834!
        '
        'Line57
        '
        Me.Line57.Height = 1.8675!
        Me.Line57.Left = 0.8625!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 0.5625!
        Me.Line57.Width = 0!
        Me.Line57.X1 = 0.8625!
        Me.Line57.X2 = 0.8625!
        Me.Line57.Y1 = 0.5625!
        Me.Line57.Y2 = 2.43!
        '
        'Line59
        '
        Me.Line59.Height = 1.2005!
        Me.Line59.Left = 1.720834!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 0.5625!
        Me.Line59.Width = 0!
        Me.Line59.X1 = 1.720834!
        Me.Line59.X2 = 1.720834!
        Me.Line59.Y1 = 0.5625!
        Me.Line59.Y2 = 1.763!
        '
        'Line60
        '
        Me.Line60.Height = 1.53!
        Me.Line60.Left = 2.524999!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 1.158!
        Me.Line60.Width = 0!
        Me.Line60.X1 = 2.524999!
        Me.Line60.X2 = 2.524999!
        Me.Line60.Y1 = 1.158!
        Me.Line60.Y2 = 2.688!
        '
        'Line61
        '
        Me.Line61.Height = 0.605!
        Me.Line61.Left = 3.479167!
        Me.Line61.LineWeight = 1!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 1.158!
        Me.Line61.Width = 0!
        Me.Line61.X1 = 3.479167!
        Me.Line61.X2 = 3.479167!
        Me.Line61.Y1 = 1.158!
        Me.Line61.Y2 = 1.763!
        '
        'Line62
        '
        Me.Line62.Height = 0.605!
        Me.Line62.Left = 5.202083!
        Me.Line62.LineWeight = 1!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 1.158!
        Me.Line62.Width = 0!
        Me.Line62.X1 = 5.202083!
        Me.Line62.X2 = 5.202083!
        Me.Line62.Y1 = 1.158!
        Me.Line62.Y2 = 1.763!
        '
        'lblTitle1
        '
        Me.lblTitle1.Height = 0.25!
        Me.lblTitle1.HyperLink = Nothing
        Me.lblTitle1.Left = 0.1875!
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: under" & _
            "line; vertical-align: bottom"
        Me.lblTitle1.Text = "主材料計画書"
        Me.lblTitle1.Top = 0.125!
        Me.lblTitle1.Width = 7.083333!
        '
        'lblHatyuCD1
        '
        Me.lblHatyuCD1.DataField = "ORDER_CD"
        Me.lblHatyuCD1.Height = 0.2!
        Me.lblHatyuCD1.HyperLink = Nothing
        Me.lblHatyuCD1.Left = 3.6875!
        Me.lblHatyuCD1.Name = "lblHatyuCD1"
        Me.lblHatyuCD1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuCD1.Text = "XXXX"
        Me.lblHatyuCD1.Top = 0.625!
        Me.lblHatyuCD1.Width = 0.5625!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.0625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label1.Text = "発注先："
        Me.Label1.Top = 0.8125!
        Me.Label1.Width = 0.625!
        '
        'lblHatyuNM1
        '
        Me.lblHatyuNM1.DataField = "CONTRACTOUT_NM"
        Me.lblHatyuNM1.Height = 0.2!
        Me.lblHatyuNM1.HyperLink = Nothing
        Me.lblHatyuNM1.Left = 3.6875!
        Me.lblHatyuNM1.Name = "lblHatyuNM1"
        Me.lblHatyuNM1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuNM1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblHatyuNM1.Top = 0.8125!
        Me.lblHatyuNM1.Width = 2.4375!
        '
        'Label3
        '
        Me.Label3.Height = 0.18!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label3.Text = "管理番号"
        Me.Label3.Top = 0.625!
        Me.Label3.Width = 0.625!
        '
        'Label4
        '
        Me.Label4.Height = 0.18!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.938!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label4.Text = "発行年月日"
        Me.Label4.Top = 0.625!
        Me.Label4.Width = 0.75!
        '
        'Label5
        '
        Me.Label5.Height = 0.18!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label5.Text = "計画納期"
        Me.Label5.Top = 1.225!
        Me.Label5.Width = 0.625!
        '
        'Label6
        '
        Me.Label6.Height = 0.18!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.125!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label6.Text = "計画量"
        Me.Label6.Top = 1.225!
        Me.Label6.Width = 0.5!
        '
        'Label7
        '
        Me.Label7.Height = 0.17!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.938!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label7.Text = "区分"
        Me.Label7.Top = 1.225!
        Me.Label7.Width = 0.375!
        '
        'Label8
        '
        Me.Label8.Height = 0.18!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.8125!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label8.Text = "連No．"
        Me.Label8.Top = 1.225!
        Me.Label8.Width = 0.438!
        '
        'Label9
        '
        Me.Label9.Height = 0.18!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 3.938!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label9.Text = "材料コード"
        Me.Label9.Top = 1.225!
        Me.Label9.Width = 0.7495!
        '
        'Label10
        '
        Me.Label10.Height = 0.18!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 5.750501!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label10.Text = "主材料標準番号"
        Me.Label10.Top = 1.225!
        Me.Label10.Width = 1!
        '
        'Line1
        '
        Me.Line1.Height = 1.53!
        Me.Line1.Left = 7.333!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.158!
        Me.Line1.Width = 0!
        Me.Line1.X1 = 7.333!
        Me.Line1.X2 = 7.333!
        Me.Line1.Y1 = 1.158!
        Me.Line1.Y2 = 2.688!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 5.25!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 3.3125!
        Me.Line2.Width = 2.0625!
        Me.Line2.X1 = 5.25!
        Me.Line2.X2 = 7.3125!
        Me.Line2.Y1 = 3.3125!
        Me.Line2.Y2 = 3.3125!
        '
        'Line3
        '
        Me.Line3.Height = 0!
        Me.Line3.Left = 5.25!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 3.5625!
        Me.Line3.Width = 2.0625!
        Me.Line3.X1 = 5.25!
        Me.Line3.X2 = 7.3125!
        Me.Line3.Y1 = 3.5625!
        Me.Line3.Y2 = 3.5625!
        '
        'Line4
        '
        Me.Line4.Height = 0!
        Me.Line4.Left = 5.25!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 4.25!
        Me.Line4.Width = 2.0625!
        Me.Line4.X1 = 5.25!
        Me.Line4.X2 = 7.3125!
        Me.Line4.Y1 = 4.25!
        Me.Line4.Y2 = 4.25!
        '
        'Line5
        '
        Me.Line5.Height = 0.9375!
        Me.Line5.Left = 6.0625!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 3.3125!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 6.0625!
        Me.Line5.X2 = 6.0625!
        Me.Line5.Y1 = 3.3125!
        Me.Line5.Y2 = 4.25!
        '
        'Label12
        '
        Me.Label12.Height = 0.18!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 6.4375!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label12.Text = "担　当"
        Me.Label12.Top = 3.37!
        Me.Label12.Width = 0.5!
        '
        'Line6
        '
        Me.Line6.Height = 0.9375!
        Me.Line6.Left = 5.25!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 3.3125!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 5.25!
        Me.Line6.X2 = 5.25!
        Me.Line6.Y1 = 3.3125!
        Me.Line6.Y2 = 4.25!
        '
        'Line7
        '
        Me.Line7.Height = 0.9375!
        Me.Line7.Left = 7.3125!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 3.3125!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 7.3125!
        Me.Line7.X2 = 7.3125!
        Me.Line7.Y1 = 3.3125!
        Me.Line7.Y2 = 4.25!
        '
        'Line8
        '
        Me.Line8.Height = 0!
        Me.Line8.Left = 0!
        Me.Line8.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 5.242!
        Me.Line8.Width = 7.333333!
        Me.Line8.X1 = 0!
        Me.Line8.X2 = 7.333333!
        Me.Line8.Y1 = 5.242!
        Me.Line8.Y2 = 5.242!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 2.4295!
        Me.Line.Width = 2.525!
        Me.Line.X1 = 0!
        Me.Line.X2 = 2.525!
        Me.Line.Y1 = 2.4295!
        Me.Line.Y2 = 2.4295!
        '
        'Line9
        '
        Me.Line9.Height = 0!
        Me.Line9.Left = 0!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 2.6875!
        Me.Line9.Width = 7.333333!
        Me.Line9.X1 = 0!
        Me.Line9.X2 = 7.333333!
        Me.Line9.Y1 = 2.6875!
        Me.Line9.Y2 = 2.6875!
        '
        'Label13
        '
        Me.Label13.Height = 0.18!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.25!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label13.Text = "単価"
        Me.Label13.Top = 1.875!
        Me.Label13.Width = 0.375!
        '
        'Label14
        '
        Me.Label14.Height = 0.18!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.25!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label14.Text = "金額"
        Me.Label14.Top = 2.1875!
        Me.Label14.Width = 0.375!
        '
        'lblKeikakuNouki1
        '
        Me.lblKeikakuNouki1.DataField = "DELIVERY_DT"
        Me.lblKeikakuNouki1.Height = 0.2!
        Me.lblKeikakuNouki1.HyperLink = Nothing
        Me.lblKeikakuNouki1.Left = 0.0625!
        Me.lblKeikakuNouki1.Name = "lblKeikakuNouki1"
        Me.lblKeikakuNouki1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblKeikakuNouki1.Text = "YY/MM/DD"
        Me.lblKeikakuNouki1.Top = 1.5!
        Me.lblKeikakuNouki1.Width = 0.75!
        '
        'lblKeikakuRyo1
        '
        Me.lblKeikakuRyo1.DataField = "ORDER_WAT"
        Me.lblKeikakuRyo1.Height = 0.2!
        Me.lblKeikakuRyo1.HyperLink = Nothing
        Me.lblKeikakuRyo1.Left = 0.875!
        Me.lblKeikakuRyo1.Name = "lblKeikakuRyo1"
        Me.lblKeikakuRyo1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.lblKeikakuRyo1.Text = "999,999.99"
        Me.lblKeikakuRyo1.Top = 1.5!
        Me.lblKeikakuRyo1.Width = 0.8125!
        '
        'lblKbn1
        '
        Me.lblKbn1.DataField = "ITEM_NM"
        Me.lblKbn1.Height = 0.2!
        Me.lblKbn1.HyperLink = Nothing
        Me.lblKbn1.Left = 2!
        Me.lblKbn1.Name = "lblKbn1"
        Me.lblKbn1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblKbn1.Text = "XX"
        Me.lblKbn1.Top = 1.5!
        Me.lblKbn1.Width = 0.3125!
        '
        'lblRenNO1
        '
        Me.lblRenNO1.DataField = "REN_NO"
        Me.lblRenNO1.Height = 0.2!
        Me.lblRenNO1.HyperLink = Nothing
        Me.lblRenNO1.Left = 2.875!
        Me.lblRenNO1.Name = "lblRenNO1"
        Me.lblRenNO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblRenNO1.Text = "99999"
        Me.lblRenNO1.Top = 1.5!
        Me.lblRenNO1.Width = 0.4375!
        '
        'lblZaiCD1
        '
        Me.lblZaiCD1.DataField = "MATL_CD"
        Me.lblZaiCD1.Height = 0.2!
        Me.lblZaiCD1.HyperLink = Nothing
        Me.lblZaiCD1.Left = 3.6875!
        Me.lblZaiCD1.Name = "lblZaiCD1"
        Me.lblZaiCD1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblZaiCD1.Text = "XXXXXXXXXXXXXXX"
        Me.lblZaiCD1.Top = 1.5!
        Me.lblZaiCD1.Width = 1.3125!
        '
        'lblTanka1
        '
        Me.lblTanka1.DataField = "ORDER_PR"
        Me.lblTanka1.Height = 0.2!
        Me.lblTanka1.HyperLink = Nothing
        Me.lblTanka1.Left = 1.125!
        Me.lblTanka1.Name = "lblTanka1"
        Me.lblTanka1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.lblTanka1.Text = "9,999,999.99"
        Me.lblTanka1.Top = 1.875!
        Me.lblTanka1.Width = 1.25!
        '
        'lblKingaku1
        '
        Me.lblKingaku1.DataField = "ORDER_AM"
        Me.lblKingaku1.Height = 0.2!
        Me.lblKingaku1.HyperLink = Nothing
        Me.lblKingaku1.Left = 1.125!
        Me.lblKingaku1.Name = "lblKingaku1"
        Me.lblKingaku1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.lblKingaku1.Text = "999,999.99"
        Me.lblKingaku1.Top = 2.1875!
        Me.lblKingaku1.Width = 1.25!
        '
        'lblZaiNM1
        '
        Me.lblZaiNM1.DataField = "MATL_NM"
        Me.lblZaiNM1.Height = 0.2!
        Me.lblZaiNM1.HyperLink = Nothing
        Me.lblZaiNM1.Left = 5.375!
        Me.lblZaiNM1.Name = "lblZaiNM1"
        Me.lblZaiNM1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblZaiNM1.Text = "XXXXXXXXXXXXXXXXX"
        Me.lblZaiNM1.Top = 1.8125!
        Me.lblZaiNM1.Width = 1.5!
        '
        'Label25
        '
        Me.Label25.Height = 0.18!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 2.8125!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label25.Text = "備考（SPEC TYPE 等）"
        Me.Label25.Top = 1.8125!
        Me.Label25.Width = 1.438!
        '
        'lblBikou1_1
        '
        Me.lblBikou1_1.DataField = "NOTE_1"
        Me.lblBikou1_1.Height = 0.15!
        Me.lblBikou1_1.HyperLink = Nothing
        Me.lblBikou1_1.Left = 2.6875!
        Me.lblBikou1_1.Name = "lblBikou1_1"
        Me.lblBikou1_1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou1_1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou1_1.Top = 2!
        Me.lblBikou1_1.Width = 4.1875!
        '
        'lblBikou1_2
        '
        Me.lblBikou1_2.DataField = "NOTE_2"
        Me.lblBikou1_2.Height = 0.15!
        Me.lblBikou1_2.HyperLink = Nothing
        Me.lblBikou1_2.Left = 2.813!
        Me.lblBikou1_2.Name = "lblBikou1_2"
        Me.lblBikou1_2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou1_2.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou1_2.Top = 2.16!
        Me.lblBikou1_2.Width = 4.1875!
        '
        'lblBikou1_3
        '
        Me.lblBikou1_3.DataField = "NOTE_3"
        Me.lblBikou1_3.Height = 0.15!
        Me.lblBikou1_3.HyperLink = Nothing
        Me.lblBikou1_3.Left = 2.688!
        Me.lblBikou1_3.Name = "lblBikou1_3"
        Me.lblBikou1_3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou1_3.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou1_3.Top = 2.31!
        Me.lblBikou1_3.Width = 4.1875!
        '
        'LabelY
        '
        Me.LabelY.Height = 0.1875!
        Me.LabelY.HyperLink = Nothing
        Me.LabelY.Left = 0.5!
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; text-decoration: non" & _
            "e; vertical-align: middle"
        Me.LabelY.Text = "174-138F"
        Me.LabelY.Top = 4.625!
        Me.LabelY.Width = 0.6875!
        '
        'Shape
        '
        Me.Shape.Height = 0.1875!
        Me.Shape.Left = 0.4375!
        Me.Shape.Name = "Shape"
        Me.Shape.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape.Top = 4.625!
        Me.Shape.Width = 0.8125!
        '
        'Label2
        '
        Me.Label2.Height = 0.2124997!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 6.25!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label2.Text = "メ生管（保管）"
        Me.Label2.Top = 4.625!
        Me.Label2.Width = 1!
        '
        'lblKanriNM2
        '
        Me.lblKanriNM2.DataField = "ORDER_NO"
        Me.lblKanriNM2.Height = 0.2!
        Me.lblKanriNM2.HyperLink = Nothing
        Me.lblKanriNM2.Left = 0.125!
        Me.lblKanriNM2.Name = "lblKanriNM2"
        Me.lblKanriNM2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblKanriNM2.Text = "XXXXXXX"
        Me.lblKanriNM2.Top = 6.575!
        Me.lblKanriNM2.Width = 0.625!
        '
        'lblHakkouYMD2
        '
        Me.lblHakkouYMD2.DataField = "ORDER_DT"
        Me.lblHakkouYMD2.Height = 0.2!
        Me.lblHakkouYMD2.HyperLink = Nothing
        Me.lblHakkouYMD2.Left = 0.9375!
        Me.lblHakkouYMD2.Name = "lblHakkouYMD2"
        Me.lblHakkouYMD2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHakkouYMD2.Text = "YY/MM/DD"
        Me.lblHakkouYMD2.Top = 6.575!
        Me.lblHakkouYMD2.Width = 0.75!
        '
        'Line10
        '
        Me.Line10.Height = 0!
        Me.Line10.Left = 0!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 6.25!
        Me.Line10.Width = 1.721!
        Me.Line10.X1 = 0!
        Me.Line10.X2 = 1.721!
        Me.Line10.Y1 = 6.25!
        Me.Line10.Y2 = 6.25!
        '
        'Line11
        '
        Me.Line11.Height = 2.1255!
        Me.Line11.Left = 0!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 6.25!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 0!
        Me.Line11.X2 = 0!
        Me.Line11.Y1 = 6.25!
        Me.Line11.Y2 = 8.3755!
        '
        'Line12
        '
        Me.Line12.Height = 0!
        Me.Line12.Left = 0!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 6.5!
        Me.Line12.Width = 1.721!
        Me.Line12.X1 = 0!
        Me.Line12.X2 = 1.721!
        Me.Line12.Y1 = 6.5!
        Me.Line12.Y2 = 6.5!
        '
        'Line13
        '
        Me.Line13.Height = 0!
        Me.Line13.Left = 0!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 6.845833!
        Me.Line13.Width = 7.333333!
        Me.Line13.X1 = 0!
        Me.Line13.X2 = 7.333333!
        Me.Line13.Y1 = 6.845833!
        Me.Line13.Y2 = 6.845833!
        '
        'Line14
        '
        Me.Line14.Height = 0!
        Me.Line14.Left = 0!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 7.116667!
        Me.Line14.Width = 7.333333!
        Me.Line14.X1 = 0!
        Me.Line14.X2 = 7.333333!
        Me.Line14.Y1 = 7.116667!
        Me.Line14.Y2 = 7.116667!
        '
        'Line15
        '
        Me.Line15.Height = 0!
        Me.Line15.Left = 0!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 7.45!
        Me.Line15.Width = 7.333333!
        Me.Line15.X1 = 0!
        Me.Line15.X2 = 7.333333!
        Me.Line15.Y1 = 7.45!
        Me.Line15.Y2 = 7.45!
        '
        'Line16
        '
        Me.Line16.Height = 0!
        Me.Line16.Left = 0!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 7.783333!
        Me.Line16.Width = 2.525!
        Me.Line16.X1 = 0!
        Me.Line16.X2 = 2.525!
        Me.Line16.Y1 = 7.783333!
        Me.Line16.Y2 = 7.783333!
        '
        'Line17
        '
        Me.Line17.Height = 1.8675!
        Me.Line17.Left = 0.8625!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 6.25!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 0.8625!
        Me.Line17.X2 = 0.8625!
        Me.Line17.Y1 = 6.25!
        Me.Line17.Y2 = 8.1175!
        '
        'Line18
        '
        Me.Line18.Height = 1.2005!
        Me.Line18.Left = 1.720834!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 6.25!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 1.720834!
        Me.Line18.X2 = 1.720834!
        Me.Line18.Y1 = 6.25!
        Me.Line18.Y2 = 7.4505!
        '
        'Line19
        '
        Me.Line19.Height = 1.53!
        Me.Line19.Left = 2.524999!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 6.8455!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 2.524999!
        Me.Line19.X2 = 2.524999!
        Me.Line19.Y1 = 6.8455!
        Me.Line19.Y2 = 8.3755!
        '
        'Line20
        '
        Me.Line20.Height = 0.6050005!
        Me.Line20.Left = 3.479167!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 6.8455!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 3.479167!
        Me.Line20.X2 = 3.479167!
        Me.Line20.Y1 = 6.8455!
        Me.Line20.Y2 = 7.4505!
        '
        'Line21
        '
        Me.Line21.Height = 0.6050005!
        Me.Line21.Left = 5.202083!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 6.8455!
        Me.Line21.Width = 0!
        Me.Line21.X1 = 5.202083!
        Me.Line21.X2 = 5.202083!
        Me.Line21.Y1 = 6.8455!
        Me.Line21.Y2 = 7.4505!
        '
        'Label17
        '
        Me.Label17.Height = 0.25!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.1875!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: under" & _
            "line; vertical-align: bottom"
        Me.Label17.Text = "主材料購入依頼書"
        Me.Label17.Top = 5.8125!
        Me.Label17.Width = 7.083333!
        '
        'lblHatyuCD2
        '
        Me.lblHatyuCD2.DataField = "ORDER_CD"
        Me.lblHatyuCD2.Height = 0.2!
        Me.lblHatyuCD2.HyperLink = Nothing
        Me.lblHatyuCD2.Left = 3.6875!
        Me.lblHatyuCD2.Name = "lblHatyuCD2"
        Me.lblHatyuCD2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuCD2.Text = "XXXX"
        Me.lblHatyuCD2.Top = 6.3125!
        Me.lblHatyuCD2.Width = 0.5625!
        '
        'Label19
        '
        Me.Label19.Height = 0.2!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 3.0625!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label19.Text = "発注先："
        Me.Label19.Top = 6.5!
        Me.Label19.Width = 0.625!
        '
        'lblHatyuNM2
        '
        Me.lblHatyuNM2.DataField = "CONTRACTOUT_NM"
        Me.lblHatyuNM2.Height = 0.2!
        Me.lblHatyuNM2.HyperLink = Nothing
        Me.lblHatyuNM2.Left = 3.6875!
        Me.lblHatyuNM2.Name = "lblHatyuNM2"
        Me.lblHatyuNM2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuNM2.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblHatyuNM2.Top = 6.5!
        Me.lblHatyuNM2.Width = 2.4375!
        '
        'label
        '
        Me.label.Height = 0.18!
        Me.label.HyperLink = Nothing
        Me.label.Left = 0.125!
        Me.label.Name = "label"
        Me.label.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.label.Text = "管理番号"
        Me.label.Top = 6.3125!
        Me.label.Width = 0.625!
        '
        'Label22
        '
        Me.Label22.Height = 0.18!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.938!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label22.Text = "発行年月日"
        Me.Label22.Top = 6.3125!
        Me.Label22.Width = 0.75!
        '
        'Label23
        '
        Me.Label23.Height = 0.18!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.125!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label23.Text = "計画納期"
        Me.Label23.Top = 6.9375!
        Me.Label23.Width = 0.625!
        '
        'Label24
        '
        Me.Label24.Height = 0.18!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 1.0625!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label24.Text = "計画量"
        Me.Label24.Top = 6.9375!
        Me.Label24.Width = 0.5!
        '
        'Label26
        '
        Me.Label26.Height = 0.18!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 1.938!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label26.Text = "区分"
        Me.Label26.Top = 6.925!
        Me.Label26.Width = 0.375!
        '
        'Label27
        '
        Me.Label27.Height = 0.18!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 2.8125!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "連No．"
        Me.Label27.Top = 6.925!
        Me.Label27.Width = 0.438!
        '
        'Label30
        '
        Me.Label30.Height = 0.18!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 5.750501!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label30.Text = "主材料標準番号"
        Me.Label30.Top = 6.925!
        Me.Label30.Width = 1!
        '
        'Line23
        '
        Me.Line23.Height = 1.53!
        Me.Line23.Left = 7.333!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 6.8455!
        Me.Line23.Width = 0!
        Me.Line23.X1 = 7.333!
        Me.Line23.X2 = 7.333!
        Me.Line23.Y1 = 6.8455!
        Me.Line23.Y2 = 8.3755!
        '
        'Line24
        '
        Me.Line24.Height = 0!
        Me.Line24.Left = 4.438!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 9!
        Me.Line24.Width = 2.8745!
        Me.Line24.X1 = 4.438!
        Me.Line24.X2 = 7.3125!
        Me.Line24.Y1 = 9!
        Me.Line24.Y2 = 9!
        '
        'Line25
        '
        Me.Line25.Height = 0!
        Me.Line25.Left = 4.438!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 9.25!
        Me.Line25.Width = 2.8745!
        Me.Line25.X1 = 4.438!
        Me.Line25.X2 = 7.3125!
        Me.Line25.Y1 = 9.25!
        Me.Line25.Y2 = 9.25!
        '
        'Line26
        '
        Me.Line26.Height = 0!
        Me.Line26.Left = 4.438!
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 9.9375!
        Me.Line26.Width = 2.8745!
        Me.Line26.X1 = 4.438!
        Me.Line26.X2 = 7.3125!
        Me.Line26.Y1 = 9.9375!
        Me.Line26.Y2 = 9.9375!
        '
        'Line27
        '
        Me.Line27.Height = 0.9375!
        Me.Line27.Left = 6.0625!
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 9!
        Me.Line27.Width = 0!
        Me.Line27.X1 = 6.0625!
        Me.Line27.X2 = 6.0625!
        Me.Line27.Y1 = 9!
        Me.Line27.Y2 = 9.9375!
        '
        'Label32
        '
        Me.Label32.Height = 0.18!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 6.4375!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label32.Text = "担　当"
        Me.Label32.Top = 9.053!
        Me.Label32.Width = 0.5!
        '
        'Line28
        '
        Me.Line28.Height = 0.9375!
        Me.Line28.Left = 5.25!
        Me.Line28.LineWeight = 1!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 9!
        Me.Line28.Width = 0!
        Me.Line28.X1 = 5.25!
        Me.Line28.X2 = 5.25!
        Me.Line28.Y1 = 9!
        Me.Line28.Y2 = 9.9375!
        '
        'Line29
        '
        Me.Line29.Height = 0.9375!
        Me.Line29.Left = 7.3125!
        Me.Line29.LineWeight = 1!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 9!
        Me.Line29.Width = 0!
        Me.Line29.X1 = 7.3125!
        Me.Line29.X2 = 7.3125!
        Me.Line29.Y1 = 9!
        Me.Line29.Y2 = 9.9375!
        '
        'Line30
        '
        Me.Line30.Height = 0!
        Me.Line30.Left = 0!
        Me.Line30.LineWeight = 1!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 8.117001!
        Me.Line30.Width = 2.525!
        Me.Line30.X1 = 0!
        Me.Line30.X2 = 2.525!
        Me.Line30.Y1 = 8.117001!
        Me.Line30.Y2 = 8.117001!
        '
        'Line31
        '
        Me.Line31.Height = 0!
        Me.Line31.Left = 0!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 8.375!
        Me.Line31.Width = 7.333333!
        Me.Line31.X1 = 0!
        Me.Line31.X2 = 7.333333!
        Me.Line31.Y1 = 8.375!
        Me.Line31.Y2 = 8.375!
        '
        'Label33
        '
        Me.Label33.Height = 0.18!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.25!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label33.Text = "単価"
        Me.Label33.Top = 7.5625!
        Me.Label33.Width = 0.375!
        '
        'Label34
        '
        Me.Label34.Height = 0.18!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 0.25!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label34.Text = "金額"
        Me.Label34.Top = 7.875!
        Me.Label34.Width = 0.375!
        '
        'lblKeikakuNouki2
        '
        Me.lblKeikakuNouki2.DataField = "DELIVERY_DT"
        Me.lblKeikakuNouki2.Height = 0.2!
        Me.lblKeikakuNouki2.HyperLink = Nothing
        Me.lblKeikakuNouki2.Left = 0.0625!
        Me.lblKeikakuNouki2.Name = "lblKeikakuNouki2"
        Me.lblKeikakuNouki2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblKeikakuNouki2.Text = "YY/MM/DD"
        Me.lblKeikakuNouki2.Top = 7.2!
        Me.lblKeikakuNouki2.Width = 0.75!
        '
        'lblKeikakuRyo2
        '
        Me.lblKeikakuRyo2.DataField = "ORDER_WAT"
        Me.lblKeikakuRyo2.Height = 0.2!
        Me.lblKeikakuRyo2.HyperLink = Nothing
        Me.lblKeikakuRyo2.Left = 0.875!
        Me.lblKeikakuRyo2.Name = "lblKeikakuRyo2"
        Me.lblKeikakuRyo2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.lblKeikakuRyo2.Text = "999,999.99"
        Me.lblKeikakuRyo2.Top = 7.1875!
        Me.lblKeikakuRyo2.Width = 0.8125!
        '
        'lblKbn2
        '
        Me.lblKbn2.DataField = "ITEM_NM"
        Me.lblKbn2.Height = 0.2!
        Me.lblKbn2.HyperLink = Nothing
        Me.lblKbn2.Left = 2!
        Me.lblKbn2.Name = "lblKbn2"
        Me.lblKbn2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblKbn2.Text = "XX"
        Me.lblKbn2.Top = 7.1875!
        Me.lblKbn2.Width = 0.3125!
        '
        'lblRenNO2
        '
        Me.lblRenNO2.DataField = "REN_NO"
        Me.lblRenNO2.Height = 0.2!
        Me.lblRenNO2.HyperLink = Nothing
        Me.lblRenNO2.Left = 2.875!
        Me.lblRenNO2.Name = "lblRenNO2"
        Me.lblRenNO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblRenNO2.Text = "99999"
        Me.lblRenNO2.Top = 7.1875!
        Me.lblRenNO2.Width = 0.4375!
        '
        'lblZaiCD2
        '
        Me.lblZaiCD2.DataField = "MATL_CD"
        Me.lblZaiCD2.Height = 0.2!
        Me.lblZaiCD2.HyperLink = Nothing
        Me.lblZaiCD2.Left = 3.6875!
        Me.lblZaiCD2.Name = "lblZaiCD2"
        Me.lblZaiCD2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblZaiCD2.Text = "XXXXXXXXXXXXXXX"
        Me.lblZaiCD2.Top = 7.1875!
        Me.lblZaiCD2.Width = 1.3125!
        '
        'lblShuZaiNM2_1
        '
        Me.lblShuZaiNM2_1.DataField = "MATL_SPFT_NO"
        Me.lblShuZaiNM2_1.Height = 0.2!
        Me.lblShuZaiNM2_1.HyperLink = Nothing
        Me.lblShuZaiNM2_1.Left = 5.6875!
        Me.lblShuZaiNM2_1.Name = "lblShuZaiNM2_1"
        Me.lblShuZaiNM2_1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblShuZaiNM2_1.Text = "XXXXXXXXXXXX"
        Me.lblShuZaiNM2_1.Top = 7.1875!
        Me.lblShuZaiNM2_1.Width = 1.0625!
        '
        'lblTanka2
        '
        Me.lblTanka2.DataField = "ORDER_PR"
        Me.lblTanka2.Height = 0.2!
        Me.lblTanka2.HyperLink = Nothing
        Me.lblTanka2.Left = 1.125!
        Me.lblTanka2.Name = "lblTanka2"
        Me.lblTanka2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.lblTanka2.Text = "9,999,999.99"
        Me.lblTanka2.Top = 7.5625!
        Me.lblTanka2.Width = 1.25!
        '
        'lblKingaku2
        '
        Me.lblKingaku2.DataField = "ORDER_AM"
        Me.lblKingaku2.Height = 0.2!
        Me.lblKingaku2.HyperLink = Nothing
        Me.lblKingaku2.Left = 1.125!
        Me.lblKingaku2.Name = "lblKingaku2"
        Me.lblKingaku2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right"
        Me.lblKingaku2.Text = "999,999.99"
        Me.lblKingaku2.Top = 7.875!
        Me.lblKingaku2.Width = 1.25!
        '
        'lblZaiNM2
        '
        Me.lblZaiNM2.DataField = "MATL_NM"
        Me.lblZaiNM2.Height = 0.2!
        Me.lblZaiNM2.HyperLink = Nothing
        Me.lblZaiNM2.Left = 5.375!
        Me.lblZaiNM2.Name = "lblZaiNM2"
        Me.lblZaiNM2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblZaiNM2.Text = "XXXXXXXXXXXXXXXXX"
        Me.lblZaiNM2.Top = 7.5!
        Me.lblZaiNM2.Width = 1.5!
        '
        'Label45
        '
        Me.Label45.Height = 0.18!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 2.8125!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label45.Text = "備考（SPEC TYPE 等）"
        Me.Label45.Top = 7.5!
        Me.Label45.Width = 1.438!
        '
        'lblBikou2_1
        '
        Me.lblBikou2_1.DataField = "NOTE_1"
        Me.lblBikou2_1.Height = 0.15!
        Me.lblBikou2_1.HyperLink = Nothing
        Me.lblBikou2_1.Left = 2.6875!
        Me.lblBikou2_1.Name = "lblBikou2_1"
        Me.lblBikou2_1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou2_1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou2_1.Top = 7.6875!
        Me.lblBikou2_1.Width = 4.188!
        '
        'lblBikou2_2
        '
        Me.lblBikou2_2.DataField = "NOTE_2"
        Me.lblBikou2_2.Height = 0.15!
        Me.lblBikou2_2.HyperLink = Nothing
        Me.lblBikou2_2.Left = 2.813!
        Me.lblBikou2_2.Name = "lblBikou2_2"
        Me.lblBikou2_2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou2_2.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou2_2.Top = 7.848!
        Me.lblBikou2_2.Width = 4.188!
        '
        'lblBikou2_3
        '
        Me.lblBikou2_3.DataField = "NOTE_3"
        Me.lblBikou2_3.Height = 0.15!
        Me.lblBikou2_3.HyperLink = Nothing
        Me.lblBikou2_3.Left = 2.688!
        Me.lblBikou2_3.Name = "lblBikou2_3"
        Me.lblBikou2_3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou2_3.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou2_3.Top = 7.998!
        Me.lblBikou2_3.Width = 4.188!
        '
        'lblSenzai2
        '
        Me.lblSenzai2.DataField = "LBLSENZAI"
        Me.lblSenzai2.Height = 0.18!
        Me.lblSenzai2.HyperLink = Nothing
        Me.lblSenzai2.Left = 6.1875!
        Me.lblSenzai2.Name = "lblSenzai2"
        Me.lblSenzai2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblSenzai2.Text = "メディカル専用材"
        Me.lblSenzai2.Top = 8.1875!
        Me.lblSenzai2.Width = 1.125!
        '
        'Label50
        '
        Me.Label50.Height = 0.1875!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 0.5!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; text-decoration: non" & _
            "e; vertical-align: middle"
        Me.Label50.Text = "174-138F"
        Me.Label50.Top = 10.3125!
        Me.Label50.Width = 0.6875!
        '
        'Shape1
        '
        Me.Shape1.Height = 0.1875!
        Me.Shape1.Left = 0.4375!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape1.Top = 10.3125!
        Me.Shape1.Width = 0.8125!
        '
        'Label51
        '
        Me.Label51.Height = 0.2124997!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 6.25!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label51.Text = "メ生管→購買"
        Me.Label51.Top = 10.3125!
        Me.Label51.Width = 1!
        '
        'Line32
        '
        Me.Line32.Height = 0.9375!
        Me.Line32.Left = 4.4375!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 9!
        Me.Line32.Width = 0!
        Me.Line32.X1 = 4.4375!
        Me.Line32.X2 = 4.4375!
        Me.Line32.Y1 = 9!
        Me.Line32.Y2 = 9.9375!
        '
        'Label52
        '
        Me.Label52.Height = 0.18!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 4.5625!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label52.Text = "事業部長"
        Me.Label52.Top = 9.053!
        Me.Label52.Width = 0.625!
        '
        'lblShuZaiNM1_1
        '
        Me.lblShuZaiNM1_1.DataField = "MATL_SPFT_NO"
        Me.lblShuZaiNM1_1.Height = 0.2!
        Me.lblShuZaiNM1_1.HyperLink = Nothing
        Me.lblShuZaiNM1_1.Left = 5.6875!
        Me.lblShuZaiNM1_1.Name = "lblShuZaiNM1_1"
        Me.lblShuZaiNM1_1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblShuZaiNM1_1.Text = "XXXXXXXXXXXX"
        Me.lblShuZaiNM1_1.Top = 1.5!
        Me.lblShuZaiNM1_1.Width = 1.0625!
        '
        'lblBikou1_4
        '
        Me.lblBikou1_4.DataField = "NOTE_4"
        Me.lblBikou1_4.Height = 0.15!
        Me.lblBikou1_4.HyperLink = Nothing
        Me.lblBikou1_4.Left = 2.813!
        Me.lblBikou1_4.Name = "lblBikou1_4"
        Me.lblBikou1_4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou1_4.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou1_4.Top = 2.47!
        Me.lblBikou1_4.Width = 4.1875!
        '
        'lblSenzai1
        '
        Me.lblSenzai1.DataField = "LBLSENZAI"
        Me.lblSenzai1.Height = 0.18!
        Me.lblSenzai1.HyperLink = Nothing
        Me.lblSenzai1.Left = 6.1875!
        Me.lblSenzai1.Name = "lblSenzai1"
        Me.lblSenzai1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblSenzai1.Text = "メディカル専用材"
        Me.lblSenzai1.Top = 2.53!
        Me.lblSenzai1.Width = 1.125!
        '
        'lblBikou2_4
        '
        Me.lblBikou2_4.DataField = "NOTE_4"
        Me.lblBikou2_4.Height = 0.15!
        Me.lblBikou2_4.HyperLink = Nothing
        Me.lblBikou2_4.Left = 2.813!
        Me.lblBikou2_4.Name = "lblBikou2_4"
        Me.lblBikou2_4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou2_4.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou2_4.Top = 8.158!
        Me.lblBikou2_4.Width = 4.188!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medproc;User ID=medproc;Data Source=medproc;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.3!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.375!
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
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKanriNM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHakkouYMD1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTitle1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuCD1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuNM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKeikakuNouki1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKeikakuRyo1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKbn1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRenNO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZaiCD1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTanka1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKingaku1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZaiNM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou1_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou1_2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou1_3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LabelY, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKanriNM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHakkouYMD2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuCD2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuNM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKeikakuNouki2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKeikakuRyo2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKbn2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRenNO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZaiCD2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShuZaiNM2_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTanka2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKingaku2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZaiNM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou2_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou2_2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou2_3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSenzai2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShuZaiNM1_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou1_4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSenzai1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou2_4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region


    Private Sub mdzai0301_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("HatyuDate")
        lblHakkouYMD1.DataField = "HatyuDate"
        lblHakkouYMD2.DataField = "HatyuDate"

        Fields.Add("KeikakuDate")
        lblKeikakuNouki1.DataField = "KeikakuDate"
        lblKeikakuNouki2.DataField = "KeikakuDate"

        Fields.Add("KeikakuRyo")
        lblKeikakuRyo1.DataField = "KeikakuRyo"
        lblKeikakuRyo2.DataField = "KeikakuRyo"

        Fields.Add("Tanka")
        lblTanka1.DataField = "Tanka"
        lblTanka2.DataField = "Tanka"

        Fields.Add("Kingaku")
        lblKingaku1.DataField = "Kingaku"
        lblKingaku2.DataField = "Kingaku"

    End Sub

    Private Sub mdzai0301_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        '適用日付 
        Fields("HatyuDate").Value = ""
        If Not GetString(Fields("ORDER_DT").Value).Equals("") And Not GetString(Fields("ORDER_DT").Value).Equals("00000000") Then Fields("HatyuDate").Value = GetString(Fields("ORDER_DT").Value).Substring(0, 4) + "/" + GetString(Fields("ORDER_DT").Value).Substring(4, 2) + "/" + GetString(Fields("ORDER_DT").Value).Substring(6, 2)

        '計画納期 
        Fields("KeikakuDate").Value = ""
        If Not GetString(Fields("DELIVERY_DT").Value).Equals("") And Not GetString(Fields("DELIVERY_DT").Value).Equals("00000000") Then Fields("KeikakuDate").Value = GetString(Fields("DELIVERY_DT").Value).Substring(0, 4) + "/" + GetString(Fields("DELIVERY_DT").Value).Substring(4, 2) + "/" + GetString(Fields("DELIVERY_DT").Value).Substring(6, 2)

        '計画量 
        Fields("KeikakuRyo").Value = GetDouble(Fields("ORDER_WAT").Value)
        'If GetDouble(Fields("ORDER_WAT").Value) <> 0 Then Fields("KeikakuRyo").Value = Format(GetDouble(Fields("ORDER_WAT").Value), "###,###,##0.00")
        If GetDouble(Fields("ORDER_WAT").Value) <> 0 Then Fields("KeikakuRyo").Value = GetDouble(Fields("ORDER_WAT").Value).ToString("###,###,##0.00")

        '単価 
        Fields("Tanka").Value = GetDouble(Fields("ORDER_PR").Value)
        'If GetDouble(Fields("ORDER_PR").Value) <> 0 Then Fields("Tanka").Value = Format(GetDouble(Fields("ORDER_PR").Value), "#,###,###,##0.00")
        If GetDouble(Fields("ORDER_PR").Value) <> 0 Then Fields("Tanka").Value = GetDouble(Fields("ORDER_PR").Value).ToString("#,###,###,##0.00")

        '金額 
        Fields("Kingaku").Value = GetDouble(Fields("ORDER_AM").Value)
        'If GetDouble(Fields("ORDER_AM").Value) <> 0 Then Fields("Kingaku").Value = Format(GetDouble(Fields("ORDER_AM").Value), "###,###,##0")
        If GetDouble(Fields("ORDER_AM").Value) <> 0 Then Fields("Kingaku").Value = GetDouble(Fields("ORDER_AM").Value).ToString("###,###,##0")

    End Sub

    Private Function GetString(ByVal oValue As Object) As String
        If IsDBNull(oValue) Then Return ""
        Return CType(oValue, String).Trim()
    End Function

    Private Function GetDouble(ByVal oValue As Object) As Double
        If IsDBNull(oValue) Then Return 0
        Return CType(oValue, Double)
    End Function

End Class 
