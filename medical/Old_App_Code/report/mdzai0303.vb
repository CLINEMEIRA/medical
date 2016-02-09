Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdzai0303
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
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label56 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label60 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label62 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label61 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label64 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label57 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label45 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label46 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label48 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label50 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label47 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKanriNM1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHakkouYMD1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuCD1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuNM1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label35 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label36 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblKeikakuNouki1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKeikakuRyo1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKbn1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblRenNO1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZaiCD1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShuZaiNM1_1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZaiNM1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label49 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou1_1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou1_2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou1_3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label54 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label55 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label59 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label63 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label65 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblNounyuRyo1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKenshuRyo1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblKanriNM2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHakkouYMD2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuCD2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblHatyuNM2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblKeikakuNouki2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKeikakuRyo2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKbn2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblRenNO2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZaiCD2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblShuZaiNM2_1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZaiNM2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou2_1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou2_2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou2_3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSenzai2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label41 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label42 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label43 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label44 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label51 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label52 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblNounyuRyo2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblKenshuRyo2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label67 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label68 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private lblBikou1_4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSenzai1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblBikou2_4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdzai0303))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label56 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label60 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label62 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label61 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label64 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label57 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label45 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label46 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label48 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label50 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label47 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKanriNM1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHakkouYMD1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuCD1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuNM1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label35 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label36 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblKeikakuNouki1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKeikakuRyo1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKbn1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRenNO1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZaiCD1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShuZaiNM1_1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZaiNM1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label49 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou1_1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou1_2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou1_3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label54 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label55 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label59 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label63 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label65 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNounyuRyo1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKenshuRyo1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblKanriNM2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHakkouYMD2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuCD2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHatyuNM2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblKeikakuNouki2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKeikakuRyo2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKbn2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblRenNO2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZaiCD2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShuZaiNM2_1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZaiNM2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou2_1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou2_2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou2_3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSenzai2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label41 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label42 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label43 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label44 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label51 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label52 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNounyuRyo2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblKenshuRyo2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label67 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label68 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.lblBikou1_4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSenzai1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBikou2_4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKanriNM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHakkouYMD1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuCD1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuNM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKeikakuNouki1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKeikakuRyo1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKbn1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRenNO1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZaiCD1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShuZaiNM1_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZaiNM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou1_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou1_2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou1_3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNounyuRyo1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKenshuRyo1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKanriNM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHakkouYMD2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuCD2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblHatyuNM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKeikakuNouki2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKeikakuRyo2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKbn2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRenNO2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZaiCD2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblShuZaiNM2_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZaiNM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou2_1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou2_2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou2_3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSenzai2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblNounyuRyo2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblKenshuRyo2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou1_4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSenzai1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblBikou2_4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line3, Me.Label56, Me.Label60, Me.Label62, Me.Label61, Me.Label64, Me.Label57, Me.Label45, Me.Label46, Me.Label48, Me.Label50, Me.Label47, Me.lblKanriNM1, Me.lblHakkouYMD1, Me.Line10, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Label24, Me.lblHatyuCD1, Me.Label27, Me.lblHatyuNM1, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.Line23, Me.Line25, Me.lblKeikakuNouki1, Me.lblKeikakuRyo1, Me.lblKbn1, Me.lblRenNO1, Me.lblZaiCD1, Me.lblShuZaiNM1_1, Me.lblZaiNM1, Me.Label49, Me.lblBikou1_1, Me.lblBikou1_2, Me.lblBikou1_3, Me.Label54, Me.Shape1, Me.Label55, Me.Label59, Me.Line31, Me.Line32, Me.Line33, Me.Line34, Me.Line35, Me.Line37, Me.Line38, Me.Line39, Me.Label63, Me.Label65, Me.lblNounyuRyo1, Me.lblKenshuRyo1, Me.Line40, Me.Line8, Me.Line, Me.Line1, Me.Line2, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line9, Me.Label, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Line16, Me.lblKanriNM2, Me.lblHakkouYMD2, Me.Line17, Me.Line22, Me.Line24, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Line30, Me.Line36, Me.Line41, Me.Label7, Me.lblHatyuCD2, Me.Label9, Me.lblHatyuNM2, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Line42, Me.Line43, Me.lblKeikakuNouki2, Me.lblKeikakuRyo2, Me.lblKbn2, Me.lblRenNO2, Me.lblZaiCD2, Me.lblShuZaiNM2_1, Me.lblZaiNM2, Me.Label28, Me.lblBikou2_1, Me.lblBikou2_2, Me.lblBikou2_3, Me.lblSenzai2, Me.Label41, Me.Label42, Me.Label43, Me.Label44, Me.Line44, Me.Line45, Me.Line46, Me.Line47, Me.Line48, Me.Line49, Me.Line50, Me.Line51, Me.Label51, Me.Label52, Me.lblNounyuRyo2, Me.lblKenshuRyo2, Me.Line52, Me.Line53, Me.Line54, Me.Line55, Me.Line62, Me.Line56, Me.Line57, Me.Line58, Me.Line59, Me.Line60, Me.Line61, Me.Label67, Me.Label68, Me.Shape, Me.lblBikou1_4, Me.lblSenzai1, Me.lblBikou2_4})
        Me.Detail.Height = 10.67569!
        Me.Detail.Name = "Detail"
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
        'Line3
        '
        Me.Line3.Height = 0.0002491474!
        Me.Line3.Left = 0.25!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 3.7945!
        Me.Line3.Width = 5.625!
        Me.Line3.X1 = 0.25!
        Me.Line3.X2 = 5.875!
        Me.Line3.Y1 = 3.794749!
        Me.Line3.Y2 = 3.7945!
        '
        'Label56
        '
        Me.Label56.Height = 0.18!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 0.25!
        Me.Label56.Name = "Label56"
        Me.Label56.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.Label56.Text = "納入量"
        Me.Label56.Top = 2.892916!
        Me.Label56.Width = 0.9375!
        '
        'Label60
        '
        Me.Label60.Height = 0.18!
        Me.Label60.HyperLink = Nothing
        Me.Label60.Left = 0.25!
        Me.Label60.Name = "Label60"
        Me.Label60.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label60.Text = "材料ロットNo"
        Me.Label60.Top = 3.547917!
        Me.Label60.Width = 0.9375!
        '
        'Label62
        '
        Me.Label62.Height = 0.18!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 0.25!
        Me.Label62.Name = "Label62"
        Me.Label62.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label62.Text = "検収年月日"
        Me.Label62.Top = 4.1875!
        Me.Label62.Width = 0.9375!
        '
        'Label61
        '
        Me.Label61.Height = 0.18!
        Me.Label61.HyperLink = Nothing
        Me.Label61.Left = 0.25!
        Me.Label61.Name = "Label61"
        Me.Label61.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.Label61.Text = "検収量"
        Me.Label61.Top = 3.867917!
        Me.Label61.Width = 0.9375!
        '
        'Label64
        '
        Me.Label64.Height = 0.18!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 0.25!
        Me.Label64.Name = "Label64"
        Me.Label64.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.Label64.Text = "納入年月日"
        Me.Label64.Top = 2.5775!
        Me.Label64.Width = 0.9375!
        '
        'Label57
        '
        Me.Label57.Height = 0.18!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 0.25!
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: top"
        Me.Label57.Text = "溶　解"
        Me.Label57.Top = 3.2225!
        Me.Label57.Width = 0.9375!
        '
        'Label45
        '
        Me.Label45.Height = 0.18!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 0.25!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label45.Text = "納入量"
        Me.Label45.Top = 8.445!
        Me.Label45.Width = 0.9375!
        '
        'Label46
        '
        Me.Label46.Height = 0.18!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 0.25!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label46.Text = "溶　解"
        Me.Label46.Top = 8.774584!
        Me.Label46.Width = 0.9375!
        '
        'Label48
        '
        Me.Label48.Height = 0.18!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 0.25!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label48.Text = "検収量"
        Me.Label48.Top = 9.42!
        Me.Label48.Width = 0.9375!
        '
        'Label50
        '
        Me.Label50.Height = 0.18!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 0.25!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label50.Text = "検収年月日"
        Me.Label50.Top = 9.75!
        Me.Label50.Width = 0.9375!
        '
        'Label47
        '
        Me.Label47.Height = 0.18!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 0.25!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label47.Text = "材料ロットNo"
        Me.Label47.Top = 9.1!
        Me.Label47.Width = 0.9375!
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
        Me.lblKanriNM1.Top = 0.7604167!
        Me.lblKanriNM1.Width = 0.6875!
        '
        'lblHakkouYMD1
        '
        Me.lblHakkouYMD1.DataField = "ORDER_DT"
        Me.lblHakkouYMD1.Height = 0.2!
        Me.lblHakkouYMD1.HyperLink = Nothing
        Me.lblHakkouYMD1.Left = 0.875!
        Me.lblHakkouYMD1.Name = "lblHakkouYMD1"
        Me.lblHakkouYMD1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHakkouYMD1.Text = "YY/MM/DD"
        Me.lblHakkouYMD1.Top = 0.7604167!
        Me.lblHakkouYMD1.Width = 0.8125!
        '
        'Line10
        '
        Me.Line10.Height = 0!
        Me.Line10.Left = 0!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.3854167!
        Me.Line10.Width = 1.721!
        Me.Line10.X1 = 0!
        Me.Line10.X2 = 1.721!
        Me.Line10.Y1 = 0.3854167!
        Me.Line10.Y2 = 0.3854167!
        '
        'Line11
        '
        Me.Line11.Height = 2.1255!
        Me.Line11.Left = 0!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.3854167!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 0!
        Me.Line11.X2 = 0!
        Me.Line11.Y1 = 0.3854167!
        Me.Line11.Y2 = 2.510917!
        '
        'Line12
        '
        Me.Line12.Height = 0!
        Me.Line12.Left = 0!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.6354167!
        Me.Line12.Width = 1.721!
        Me.Line12.X1 = 0!
        Me.Line12.X2 = 1.721!
        Me.Line12.Y1 = 0.6354167!
        Me.Line12.Y2 = 0.6354167!
        '
        'Line13
        '
        Me.Line13.Height = 0!
        Me.Line13.Left = 0!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.98125!
        Me.Line13.Width = 7.333333!
        Me.Line13.X1 = 0!
        Me.Line13.X2 = 7.333333!
        Me.Line13.Y1 = 0.98125!
        Me.Line13.Y2 = 0.98125!
        '
        'Line14
        '
        Me.Line14.Height = 0!
        Me.Line14.Left = 0!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 1.252083!
        Me.Line14.Width = 7.333333!
        Me.Line14.X1 = 0!
        Me.Line14.X2 = 7.333333!
        Me.Line14.Y1 = 1.252083!
        Me.Line14.Y2 = 1.252083!
        '
        'Line15
        '
        Me.Line15.Height = 0!
        Me.Line15.Left = 0!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 1.585417!
        Me.Line15.Width = 7.333333!
        Me.Line15.X1 = 0!
        Me.Line15.X2 = 7.333333!
        Me.Line15.Y1 = 1.585417!
        Me.Line15.Y2 = 1.585417!
        '
        'Line18
        '
        Me.Line18.Height = 1.2005!
        Me.Line18.Left = 1.720834!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.3854167!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 1.720834!
        Me.Line18.X2 = 1.720834!
        Me.Line18.Y1 = 0.3854167!
        Me.Line18.Y2 = 1.585917!
        '
        'Line19
        '
        Me.Line19.Height = 1.530001!
        Me.Line19.Left = 2.524999!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.980916!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 2.524999!
        Me.Line19.X2 = 2.524999!
        Me.Line19.Y1 = 0.980916!
        Me.Line19.Y2 = 2.510917!
        '
        'Line20
        '
        Me.Line20.Height = 0.6050006!
        Me.Line20.Left = 3.479167!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.980916!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 3.479167!
        Me.Line20.X2 = 3.479167!
        Me.Line20.Y1 = 0.980916!
        Me.Line20.Y2 = 1.585917!
        '
        'Line21
        '
        Me.Line21.Height = 0.6050006!
        Me.Line21.Left = 5.077083!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.980916!
        Me.Line21.Width = 0!
        Me.Line21.X1 = 5.077083!
        Me.Line21.X2 = 5.077083!
        Me.Line21.Y1 = 0.980916!
        Me.Line21.Y2 = 1.585917!
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.1875!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: under" & _
            "line; vertical-align: bottom"
        Me.Label24.Text = "受入検査票"
        Me.Label24.Top = 0.01041667!
        Me.Label24.Width = 7.083333!
        '
        'lblHatyuCD1
        '
        Me.lblHatyuCD1.DataField = "ORDER_CD"
        Me.lblHatyuCD1.Height = 0.2!
        Me.lblHatyuCD1.HyperLink = Nothing
        Me.lblHatyuCD1.Left = 4.375!
        Me.lblHatyuCD1.Name = "lblHatyuCD1"
        Me.lblHatyuCD1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuCD1.Text = "XXXX"
        Me.lblHatyuCD1.Top = 0.4479167!
        Me.lblHatyuCD1.Width = 0.5625!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 3.75!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "発注先："
        Me.Label27.Top = 0.6354167!
        Me.Label27.Width = 0.625!
        '
        'lblHatyuNM1
        '
        Me.lblHatyuNM1.DataField = "CONTRACTOUT_NM"
        Me.lblHatyuNM1.Height = 0.2!
        Me.lblHatyuNM1.HyperLink = Nothing
        Me.lblHatyuNM1.Left = 4.375!
        Me.lblHatyuNM1.Name = "lblHatyuNM1"
        Me.lblHatyuNM1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuNM1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblHatyuNM1.Top = 0.6354167!
        Me.lblHatyuNM1.Width = 2.25!
        '
        'Label30
        '
        Me.Label30.Height = 0.18!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0.125!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label30.Text = "管理番号"
        Me.Label30.Top = 0.4479167!
        Me.Label30.Width = 0.625!
        '
        'Label31
        '
        Me.Label31.Height = 0.18!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.938!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label31.Text = "発行年月日"
        Me.Label31.Top = 0.4479167!
        Me.Label31.Width = 0.75!
        '
        'Label32
        '
        Me.Label32.Height = 0.18!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.125!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label32.Text = "計画納期"
        Me.Label32.Top = 1.047917!
        Me.Label32.Width = 0.625!
        '
        'Label33
        '
        Me.Label33.Height = 0.18!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 1.125!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label33.Text = "計画量"
        Me.Label33.Top = 1.048!
        Me.Label33.Width = 0.5!
        '
        'Label34
        '
        Me.Label34.Height = 0.18!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 1.938!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label34.Text = "区分"
        Me.Label34.Top = 1.047917!
        Me.Label34.Width = 0.375!
        '
        'Label35
        '
        Me.Label35.Height = 0.18!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 2.7505!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label35.Text = "連No．"
        Me.Label35.Top = 1.047917!
        Me.Label35.Width = 0.438!
        '
        'Label36
        '
        Me.Label36.Height = 0.18!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 3.8755!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label36.Text = "材料コード"
        Me.Label36.Top = 1.047917!
        Me.Label36.Width = 0.7495!
        '
        'Label37
        '
        Me.Label37.Height = 0.18!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 5.625501!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label37.Text = "主材料標準番号"
        Me.Label37.Top = 1.047917!
        Me.Label37.Width = 1!
        '
        'Line23
        '
        Me.Line23.Height = 1.530001!
        Me.Line23.Left = 7.333!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 0.980916!
        Me.Line23.Width = 0!
        Me.Line23.X1 = 7.333!
        Me.Line23.X2 = 7.333!
        Me.Line23.Y1 = 0.980916!
        Me.Line23.Y2 = 2.510917!
        '
        'Line25
        '
        Me.Line25.Height = 0!
        Me.Line25.Left = 0!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 2.510417!
        Me.Line25.Width = 7.333333!
        Me.Line25.X1 = 0!
        Me.Line25.X2 = 7.333333!
        Me.Line25.Y1 = 2.510417!
        Me.Line25.Y2 = 2.510417!
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
        Me.lblKeikakuNouki1.Top = 1.322917!
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
        Me.lblKeikakuRyo1.Top = 1.322917!
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
        Me.lblKbn1.Top = 1.3125!
        Me.lblKbn1.Width = 0.3125!
        '
        'lblRenNO1
        '
        Me.lblRenNO1.DataField = "REN_NO"
        Me.lblRenNO1.Height = 0.2!
        Me.lblRenNO1.HyperLink = Nothing
        Me.lblRenNO1.Left = 2.8125!
        Me.lblRenNO1.Name = "lblRenNO1"
        Me.lblRenNO1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblRenNO1.Text = "99999"
        Me.lblRenNO1.Top = 1.3125!
        Me.lblRenNO1.Width = 0.5!
        '
        'lblZaiCD1
        '
        Me.lblZaiCD1.DataField = "MATL_CD"
        Me.lblZaiCD1.Height = 0.2!
        Me.lblZaiCD1.HyperLink = Nothing
        Me.lblZaiCD1.Left = 3.625!
        Me.lblZaiCD1.Name = "lblZaiCD1"
        Me.lblZaiCD1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblZaiCD1.Text = "XXXXXXXXXXXXXXX"
        Me.lblZaiCD1.Top = 1.322917!
        Me.lblZaiCD1.Width = 1.3125!
        '
        'lblShuZaiNM1_1
        '
        Me.lblShuZaiNM1_1.DataField = "MATL_SPFT_NO"
        Me.lblShuZaiNM1_1.Height = 0.2!
        Me.lblShuZaiNM1_1.HyperLink = Nothing
        Me.lblShuZaiNM1_1.Left = 5.5625!
        Me.lblShuZaiNM1_1.Name = "lblShuZaiNM1_1"
        Me.lblShuZaiNM1_1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblShuZaiNM1_1.Text = "XXXXXXXXXXXX"
        Me.lblShuZaiNM1_1.Top = 1.3125!
        Me.lblShuZaiNM1_1.Width = 1.0625!
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
        Me.lblZaiNM1.Top = 1.635417!
        Me.lblZaiNM1.Width = 1.6875!
        '
        'Label49
        '
        Me.Label49.Height = 0.18!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 2.8125!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label49.Text = "備考（SPEC TYPE 等）"
        Me.Label49.Top = 1.635417!
        Me.Label49.Width = 1.438!
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
        Me.lblBikou1_1.Top = 1.822917!
        Me.lblBikou1_1.Width = 4.188!
        '
        'lblBikou1_2
        '
        Me.lblBikou1_2.DataField = "NOTE_2"
        Me.lblBikou1_2.Height = 0.15!
        Me.lblBikou1_2.HyperLink = Nothing
        Me.lblBikou1_2.Left = 2.8135!
        Me.lblBikou1_2.Name = "lblBikou1_2"
        Me.lblBikou1_2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblBikou1_2.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblBikou1_2.Top = 1.983!
        Me.lblBikou1_2.Width = 4.188!
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
        Me.lblBikou1_3.Top = 2.14!
        Me.lblBikou1_3.Width = 4.188!
        '
        'Label54
        '
        Me.Label54.Height = 0.1875!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 0.5!
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; text-decoration: non" & _
            "e; vertical-align: middle"
        Me.Label54.Text = "174-136E"
        Me.Label54.Top = 5.072917!
        Me.Label54.Width = 0.6875!
        '
        'Shape1
        '
        Me.Shape1.Height = 0.1875!
        Me.Shape1.Left = 0.4375!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape1.Top = 5.072917!
        Me.Shape1.Width = 0.8125!
        '
        'Label55
        '
        Me.Label55.Height = 0.2!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 6.6875!
        Me.Label55.Name = "Label55"
        Me.Label55.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label55.Text = "御中"
        Me.Label55.Top = 0.6354167!
        Me.Label55.Width = 0.5625!
        '
        'Label59
        '
        Me.Label59.Height = 0.1875!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 4.4375!
        Me.Label59.Name = "Label59"
        Me.Label59.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label59.Text = "メ生管→購買→発注先→メ生管→品管(保管)"
        Me.Label59.Top = 5.183!
        Me.Label59.Width = 2.8125!
        '
        'Line31
        '
        Me.Line31.Height = 0!
        Me.Line31.Left = 0.25!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 2.814917!
        Me.Line31.Width = 2.6!
        Me.Line31.X1 = 0.25!
        Me.Line31.X2 = 2.85!
        Me.Line31.Y1 = 2.814917!
        Me.Line31.Y2 = 2.814917!
        '
        'Line32
        '
        Me.Line32.Height = 0!
        Me.Line32.Left = 0.25!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 3.148583!
        Me.Line32.Width = 2.6!
        Me.Line32.X1 = 0.25!
        Me.Line32.X2 = 2.85!
        Me.Line32.Y1 = 3.148583!
        Me.Line32.Y2 = 3.148583!
        '
        'Line33
        '
        Me.Line33.Height = 0!
        Me.Line33.Left = 0.25!
        Me.Line33.LineWeight = 1!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 3.461083!
        Me.Line33.Width = 2.6!
        Me.Line33.X1 = 0.25!
        Me.Line33.X2 = 2.85!
        Me.Line33.Y1 = 3.461083!
        Me.Line33.Y2 = 3.461083!
        '
        'Line34
        '
        Me.Line34.Height = 0!
        Me.Line34.Left = 0.25!
        Me.Line34.LineWeight = 3!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 3.79475!
        Me.Line34.Width = 2.6!
        Me.Line34.X1 = 0.25!
        Me.Line34.X2 = 2.85!
        Me.Line34.Y1 = 3.79475!
        Me.Line34.Y2 = 3.79475!
        '
        'Line35
        '
        Me.Line35.Height = 0!
        Me.Line35.Left = 0.25!
        Me.Line35.LineWeight = 1!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 4.107249!
        Me.Line35.Width = 5.625!
        Me.Line35.X1 = 0.25!
        Me.Line35.X2 = 5.875!
        Me.Line35.Y1 = 4.107249!
        Me.Line35.Y2 = 4.107249!
        '
        'Line37
        '
        Me.Line37.Height = 0.0004172325!
        Me.Line37.Left = 0.25!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 4.447499!
        Me.Line37.Width = 4.75!
        Me.Line37.X1 = 0.25!
        Me.Line37.X2 = 5!
        Me.Line37.Y1 = 4.447499!
        Me.Line37.Y2 = 4.447917!
        '
        'Line38
        '
        Me.Line38.Height = 1.937!
        Me.Line38.Left = 0.25!
        Me.Line38.LineWeight = 1!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 2.510917!
        Me.Line38.Width = 0!
        Me.Line38.X1 = 0.25!
        Me.Line38.X2 = 0.25!
        Me.Line38.Y1 = 2.510917!
        Me.Line38.Y2 = 4.447917!
        '
        'Line39
        '
        Me.Line39.Height = 1.936999!
        Me.Line39.Left = 1.1875!
        Me.Line39.LineWeight = 1!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 2.510417!
        Me.Line39.Width = 0!
        Me.Line39.X1 = 1.1875!
        Me.Line39.X2 = 1.1875!
        Me.Line39.Y1 = 2.510417!
        Me.Line39.Y2 = 4.447416!
        '
        'Label63
        '
        Me.Label63.Height = 0.18!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 1.6875!
        Me.Label63.Name = "Label63"
        Me.Label63.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label63.Text = "年     月     日"
        Me.Label63.Top = 2.572917!
        Me.Label63.Width = 1.125!
        '
        'Label65
        '
        Me.Label65.Height = 0.18!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 1.5!
        Me.Label65.Name = "Label65"
        Me.Label65.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label65.Text = "年    月    日"
        Me.Label65.Top = 4.191667!
        Me.Label65.Width = 1!
        '
        'lblNounyuRyo1
        '
        Me.lblNounyuRyo1.DataField = "ITEM_NM"
        Me.lblNounyuRyo1.Height = 0.2!
        Me.lblNounyuRyo1.HyperLink = Nothing
        Me.lblNounyuRyo1.Left = 2.375!
        Me.lblNounyuRyo1.Name = "lblNounyuRyo1"
        Me.lblNounyuRyo1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblNounyuRyo1.Text = "XX"
        Me.lblNounyuRyo1.Top = 2.885417!
        Me.lblNounyuRyo1.Width = 0.3125!
        '
        'lblKenshuRyo1
        '
        Me.lblKenshuRyo1.DataField = "ITEM_NM"
        Me.lblKenshuRyo1.Height = 0.2!
        Me.lblKenshuRyo1.HyperLink = Nothing
        Me.lblKenshuRyo1.Left = 2.125!
        Me.lblKenshuRyo1.Name = "lblKenshuRyo1"
        Me.lblKenshuRyo1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblKenshuRyo1.Text = "XX"
        Me.lblKenshuRyo1.Top = 3.875!
        Me.lblKenshuRyo1.Width = 0.3125!
        '
        'Line40
        '
        Me.Line40.Height = 1.284583!
        Me.Line40.Left = 2.8375!
        Me.Line40.LineWeight = 3!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 2.509917!
        Me.Line40.Width = 0!
        Me.Line40.X1 = 2.8375!
        Me.Line40.X2 = 2.8375!
        Me.Line40.Y1 = 2.509917!
        Me.Line40.Y2 = 3.7945!
        '
        'Line8
        '
        Me.Line8.Height = 0!
        Me.Line8.Left = 0!
        Me.Line8.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 5.4375!
        Me.Line8.Width = 7.333333!
        Me.Line8.X1 = 0!
        Me.Line8.X2 = 7.333333!
        Me.Line8.Y1 = 5.4375!
        Me.Line8.Y2 = 5.4375!
        '
        'Line
        '
        Me.Line.Height = 1.2685!
        Me.Line.Left = 2.5!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 3.7945!
        Me.Line.Width = 0!
        Me.Line.X1 = 2.5!
        Me.Line.X2 = 2.5!
        Me.Line.Y1 = 3.7945!
        Me.Line.Y2 = 5.063!
        '
        'Line1
        '
        Me.Line1.Height = 1.284583!
        Me.Line1.Left = 0.25!
        Me.Line1.LineWeight = 3!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 2.5095!
        Me.Line1.Width = 0!
        Me.Line1.X1 = 0.25!
        Me.Line1.X2 = 0.25!
        Me.Line1.Y1 = 2.5095!
        Me.Line1.Y2 = 3.794083!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.25!
        Me.Line2.LineWeight = 3!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.5105!
        Me.Line2.Width = 2.6!
        Me.Line2.X1 = 0.25!
        Me.Line2.X2 = 2.85!
        Me.Line2.Y1 = 2.5105!
        Me.Line2.Y2 = 2.5105!
        '
        'Line4
        '
        Me.Line4.Height = 0!
        Me.Line4.Left = 2.5!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 5.0625!
        Me.Line4.Width = 3.375!
        Me.Line4.X1 = 2.5!
        Me.Line4.X2 = 5.875!
        Me.Line4.Y1 = 5.0625!
        Me.Line4.Y2 = 5.0625!
        '
        'Line5
        '
        Me.Line5.Height = 1.2685!
        Me.Line5.Left = 5.875!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 3.7945!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 5.875!
        Me.Line5.X2 = 5.875!
        Me.Line5.Y1 = 3.7945!
        Me.Line5.Y2 = 5.063!
        '
        'Line6
        '
        Me.Line6.Height = 0.9555001!
        Me.Line6.Left = 3.375!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 4.1075!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 3.375!
        Me.Line6.X2 = 3.375!
        Me.Line6.Y1 = 4.1075!
        Me.Line6.Y2 = 5.063!
        '
        'Line7
        '
        Me.Line7.Height = 0.9555001!
        Me.Line7.Left = 4.1875!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 4.1075!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 4.1875!
        Me.Line7.X2 = 4.1875!
        Me.Line7.Y1 = 4.1075!
        Me.Line7.Y2 = 5.063!
        '
        'Line9
        '
        Me.Line9.Height = 1.2685!
        Me.Line9.Left = 5!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 3.7945!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 5!
        Me.Line9.X2 = 5!
        Me.Line9.Y1 = 3.7945!
        Me.Line9.Y2 = 5.063!
        '
        'Label
        '
        Me.Label.Height = 0.18!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 2.8125!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label.Text = "外径"
        Me.Label.Top = 4.1875!
        Me.Label.Width = 0.313!
        '
        'Label1
        '
        Me.Label1.Height = 0.18!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label1.Text = "肉厚"
        Me.Label1.Top = 4.1875!
        Me.Label1.Width = 0.375!
        '
        'Label2
        '
        Me.Label2.Height = 0.18!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.4375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label2.Text = "長さ"
        Me.Label2.Top = 4.1875!
        Me.Label2.Width = 0.313!
        '
        'Label3
        '
        Me.Label3.Height = 0.18!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.4375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label3.Text = "寸法記入欄"
        Me.Label3.Top = 3.875!
        Me.Label3.Width = 0.813!
        '
        'Label4
        '
        Me.Label4.Height = 0.18!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 5.25!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label4.Text = "品　質"
        Me.Label4.Top = 3.875!
        Me.Label4.Width = 0.5!
        '
        'Line16
        '
        Me.Line16.Height = 1.201!
        Me.Line16.Left = 0.845834!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.385!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 0.845834!
        Me.Line16.X2 = 0.845834!
        Me.Line16.Y1 = 0.385!
        Me.Line16.Y2 = 1.586!
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
        Me.lblKanriNM2.Top = 6.3125!
        Me.lblKanriNM2.Width = 0.6875!
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
        Me.lblHakkouYMD2.Top = 6.3125!
        Me.lblHakkouYMD2.Width = 0.75!
        '
        'Line17
        '
        Me.Line17.Height = 0!
        Me.Line17.Left = 0!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 5.9375!
        Me.Line17.Width = 1.721!
        Me.Line17.X1 = 0!
        Me.Line17.X2 = 1.721!
        Me.Line17.Y1 = 5.9375!
        Me.Line17.Y2 = 5.9375!
        '
        'Line22
        '
        Me.Line22.Height = 2.1255!
        Me.Line22.Left = 0!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 5.9375!
        Me.Line22.Width = 0!
        Me.Line22.X1 = 0!
        Me.Line22.X2 = 0!
        Me.Line22.Y1 = 5.9375!
        Me.Line22.Y2 = 8.063!
        '
        'Line24
        '
        Me.Line24.Height = 0!
        Me.Line24.Left = 0!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 6.1875!
        Me.Line24.Width = 1.721!
        Me.Line24.X1 = 0!
        Me.Line24.X2 = 1.721!
        Me.Line24.Y1 = 6.1875!
        Me.Line24.Y2 = 6.1875!
        '
        'Line26
        '
        Me.Line26.Height = 0!
        Me.Line26.Left = 0!
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 6.533333!
        Me.Line26.Width = 7.333333!
        Me.Line26.X1 = 0!
        Me.Line26.X2 = 7.333333!
        Me.Line26.Y1 = 6.533333!
        Me.Line26.Y2 = 6.533333!
        '
        'Line27
        '
        Me.Line27.Height = 0!
        Me.Line27.Left = 0!
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 6.804167!
        Me.Line27.Width = 7.333333!
        Me.Line27.X1 = 0!
        Me.Line27.X2 = 7.333333!
        Me.Line27.Y1 = 6.804167!
        Me.Line27.Y2 = 6.804167!
        '
        'Line28
        '
        Me.Line28.Height = 0!
        Me.Line28.Left = 0!
        Me.Line28.LineWeight = 1!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 7.1375!
        Me.Line28.Width = 7.333333!
        Me.Line28.X1 = 0!
        Me.Line28.X2 = 7.333333!
        Me.Line28.Y1 = 7.1375!
        Me.Line28.Y2 = 7.1375!
        '
        'Line29
        '
        Me.Line29.Height = 1.2005!
        Me.Line29.Left = 1.720834!
        Me.Line29.LineWeight = 1!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 5.9375!
        Me.Line29.Width = 0!
        Me.Line29.X1 = 1.720834!
        Me.Line29.X2 = 1.720834!
        Me.Line29.Y1 = 5.9375!
        Me.Line29.Y2 = 7.138!
        '
        'Line30
        '
        Me.Line30.Height = 1.53!
        Me.Line30.Left = 2.524999!
        Me.Line30.LineWeight = 1!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 6.533!
        Me.Line30.Width = 0!
        Me.Line30.X1 = 2.524999!
        Me.Line30.X2 = 2.524999!
        Me.Line30.Y1 = 6.533!
        Me.Line30.Y2 = 8.063!
        '
        'Line36
        '
        Me.Line36.Height = 0.6050005!
        Me.Line36.Left = 3.479167!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 6.533!
        Me.Line36.Width = 0!
        Me.Line36.X1 = 3.479167!
        Me.Line36.X2 = 3.479167!
        Me.Line36.Y1 = 6.533!
        Me.Line36.Y2 = 7.138!
        '
        'Line41
        '
        Me.Line41.Height = 0.6050005!
        Me.Line41.Left = 5.077083!
        Me.Line41.LineWeight = 1!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 6.533!
        Me.Line41.Width = 0!
        Me.Line41.X1 = 5.077083!
        Me.Line41.X2 = 5.077083!
        Me.Line41.Y1 = 6.533!
        Me.Line41.Y2 = 7.138!
        '
        'Label7
        '
        Me.Label7.Height = 0.25!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.1875!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: under" & _
            "line; vertical-align: bottom"
        Me.Label7.Text = "受入検査票"
        Me.Label7.Top = 5.625!
        Me.Label7.Width = 7.083333!
        '
        'lblHatyuCD2
        '
        Me.lblHatyuCD2.DataField = "ORDER_CD"
        Me.lblHatyuCD2.Height = 0.2!
        Me.lblHatyuCD2.HyperLink = Nothing
        Me.lblHatyuCD2.Left = 4.375!
        Me.lblHatyuCD2.Name = "lblHatyuCD2"
        Me.lblHatyuCD2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuCD2.Text = "XXXX"
        Me.lblHatyuCD2.Top = 6!
        Me.lblHatyuCD2.Width = 0.5625!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 3.75!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label9.Text = "発注先："
        Me.Label9.Top = 6.1875!
        Me.Label9.Width = 0.625!
        '
        'lblHatyuNM2
        '
        Me.lblHatyuNM2.DataField = "CONTRACTOUT_NM"
        Me.lblHatyuNM2.Height = 0.2!
        Me.lblHatyuNM2.HyperLink = Nothing
        Me.lblHatyuNM2.Left = 4.375!
        Me.lblHatyuNM2.Name = "lblHatyuNM2"
        Me.lblHatyuNM2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblHatyuNM2.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblHatyuNM2.Top = 6.1875!
        Me.lblHatyuNM2.Width = 2.25!
        '
        'Label11
        '
        Me.Label11.Height = 0.18!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.125!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label11.Text = "管理番号"
        Me.Label11.Top = 6!
        Me.Label11.Width = 0.625!
        '
        'Label12
        '
        Me.Label12.Height = 0.18!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.938!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label12.Text = "発行年月日"
        Me.Label12.Top = 6!
        Me.Label12.Width = 0.75!
        '
        'Label13
        '
        Me.Label13.Height = 0.18!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.125!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label13.Text = "計画納期"
        Me.Label13.Top = 6.6!
        Me.Label13.Width = 0.625!
        '
        'Label14
        '
        Me.Label14.Height = 0.18!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 1.0625!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label14.Text = "計画量"
        Me.Label14.Top = 6.6!
        Me.Label14.Width = 0.5!
        '
        'Label15
        '
        Me.Label15.Height = 0.18!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 1.938!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label15.Text = "区分"
        Me.Label15.Top = 6.6!
        Me.Label15.Width = 0.375!
        '
        'Label16
        '
        Me.Label16.Height = 0.18!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.7505!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label16.Text = "連No．"
        Me.Label16.Top = 6.6!
        Me.Label16.Width = 0.438!
        '
        'Label17
        '
        Me.Label17.Height = 0.18!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 3.813!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label17.Text = "材料コード"
        Me.Label17.Top = 6.6!
        Me.Label17.Width = 0.7495!
        '
        'Label18
        '
        Me.Label18.Height = 0.18!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 5.625501!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label18.Text = "主材料標準番号"
        Me.Label18.Top = 6.6!
        Me.Label18.Width = 1!
        '
        'Line42
        '
        Me.Line42.Height = 1.53!
        Me.Line42.Left = 7.333!
        Me.Line42.LineWeight = 1!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 6.533!
        Me.Line42.Width = 0!
        Me.Line42.X1 = 7.333!
        Me.Line42.X2 = 7.333!
        Me.Line42.Y1 = 6.533!
        Me.Line42.Y2 = 8.063!
        '
        'Line43
        '
        Me.Line43.Height = 0!
        Me.Line43.Left = 0!
        Me.Line43.LineWeight = 1!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 8.0625!
        Me.Line43.Width = 7.333333!
        Me.Line43.X1 = 0!
        Me.Line43.X2 = 7.333333!
        Me.Line43.Y1 = 8.0625!
        Me.Line43.Y2 = 8.0625!
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
        Me.lblKeikakuNouki2.Top = 6.875!
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
        Me.lblKeikakuRyo2.Top = 6.875!
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
        Me.lblKbn2.Top = 6.864583!
        Me.lblKbn2.Width = 0.3125!
        '
        'lblRenNO2
        '
        Me.lblRenNO2.DataField = "REN_NO"
        Me.lblRenNO2.Height = 0.2!
        Me.lblRenNO2.HyperLink = Nothing
        Me.lblRenNO2.Left = 2.8125!
        Me.lblRenNO2.Name = "lblRenNO2"
        Me.lblRenNO2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblRenNO2.Text = "99999"
        Me.lblRenNO2.Top = 6.864583!
        Me.lblRenNO2.Width = 0.5!
        '
        'lblZaiCD2
        '
        Me.lblZaiCD2.DataField = "MATL_CD"
        Me.lblZaiCD2.Height = 0.2!
        Me.lblZaiCD2.HyperLink = Nothing
        Me.lblZaiCD2.Left = 3.625!
        Me.lblZaiCD2.Name = "lblZaiCD2"
        Me.lblZaiCD2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblZaiCD2.Text = "XXXXXXXXXXXXXXX"
        Me.lblZaiCD2.Top = 6.875!
        Me.lblZaiCD2.Width = 1.3125!
        '
        'lblShuZaiNM2_1
        '
        Me.lblShuZaiNM2_1.DataField = "MATL_SPFT_NO"
        Me.lblShuZaiNM2_1.Height = 0.2!
        Me.lblShuZaiNM2_1.HyperLink = Nothing
        Me.lblShuZaiNM2_1.Left = 5.5625!
        Me.lblShuZaiNM2_1.Name = "lblShuZaiNM2_1"
        Me.lblShuZaiNM2_1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblShuZaiNM2_1.Text = "XXXXXXXXXXXX"
        Me.lblShuZaiNM2_1.Top = 6.864583!
        Me.lblShuZaiNM2_1.Width = 1.0625!
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
        Me.lblZaiNM2.Top = 7.1875!
        Me.lblZaiNM2.Width = 1.6875!
        '
        'Label28
        '
        Me.Label28.Height = 0.18!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 2.8125!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label28.Text = "備考（SPEC TYPE 等）"
        Me.Label28.Top = 7.1875!
        Me.Label28.Width = 1.438!
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
        Me.lblBikou2_1.Top = 7.375!
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
        Me.lblBikou2_2.Top = 7.535!
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
        Me.lblBikou2_3.Top = 7.692!
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
        Me.lblSenzai2.Top = 7.905!
        Me.lblSenzai2.Width = 1.125!
        '
        'Label41
        '
        Me.Label41.Height = 0.1875!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 0.5!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; text-decoration: non" & _
            "e; vertical-align: middle"
        Me.Label41.Text = "174-136E"
        Me.Label41.Top = 10.4375!
        Me.Label41.Width = 0.6875!
        '
        'Label42
        '
        Me.Label42.Height = 0.2!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 6.6875!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label42.Text = "御中"
        Me.Label42.Top = 6.1875!
        Me.Label42.Width = 0.5625!
        '
        'Label43
        '
        Me.Label43.Height = 0.18!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 0.25!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center"
        Me.Label43.Text = "納入年月日"
        Me.Label43.Top = 8.125!
        Me.Label43.Width = 0.9375!
        '
        'Label44
        '
        Me.Label44.Height = 0.1875!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 3.9375!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label44.Text = "メ生管→購買→発注先→メ生管→品管→メ生管(保管)"
        Me.Label44.Top = 10.4375!
        Me.Label44.Width = 3.375!
        '
        'Line44
        '
        Me.Line44.Height = 0!
        Me.Line44.Left = 0.25!
        Me.Line44.LineWeight = 1!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 8.367001!
        Me.Line44.Width = 2.6!
        Me.Line44.X1 = 0.25!
        Me.Line44.X2 = 2.85!
        Me.Line44.Y1 = 8.367001!
        Me.Line44.Y2 = 8.367001!
        '
        'Line45
        '
        Me.Line45.Height = 0!
        Me.Line45.Left = 0.25!
        Me.Line45.LineWeight = 1!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 8.700666!
        Me.Line45.Width = 2.6!
        Me.Line45.X1 = 0.25!
        Me.Line45.X2 = 2.85!
        Me.Line45.Y1 = 8.700666!
        Me.Line45.Y2 = 8.700666!
        '
        'Line46
        '
        Me.Line46.Height = 0!
        Me.Line46.Left = 0.25!
        Me.Line46.LineWeight = 1!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 9.013166!
        Me.Line46.Width = 2.6!
        Me.Line46.X1 = 0.25!
        Me.Line46.X2 = 2.85!
        Me.Line46.Y1 = 9.013166!
        Me.Line46.Y2 = 9.013166!
        '
        'Line47
        '
        Me.Line47.Height = 0!
        Me.Line47.Left = 0.25!
        Me.Line47.LineWeight = 3!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 9.346833!
        Me.Line47.Width = 2.6!
        Me.Line47.X1 = 0.25!
        Me.Line47.X2 = 2.85!
        Me.Line47.Y1 = 9.346833!
        Me.Line47.Y2 = 9.346833!
        '
        'Line48
        '
        Me.Line48.Height = 0!
        Me.Line48.Left = 0.25!
        Me.Line48.LineWeight = 1!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 9.659333!
        Me.Line48.Width = 2.25!
        Me.Line48.X1 = 0.25!
        Me.Line48.X2 = 2.5!
        Me.Line48.Y1 = 9.659333!
        Me.Line48.Y2 = 9.659333!
        '
        'Line49
        '
        Me.Line49.Height = 0.0004167557!
        Me.Line49.Left = 0.25!
        Me.Line49.LineWeight = 1!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 9.999583!
        Me.Line49.Width = 2.25!
        Me.Line49.X1 = 0.25!
        Me.Line49.X2 = 2.5!
        Me.Line49.Y1 = 9.999583!
        Me.Line49.Y2 = 10!
        '
        'Line50
        '
        Me.Line50.Height = 1.937!
        Me.Line50.Left = 0.25!
        Me.Line50.LineWeight = 1!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 8.063!
        Me.Line50.Width = 0!
        Me.Line50.X1 = 0.25!
        Me.Line50.X2 = 0.25!
        Me.Line50.Y1 = 8.063!
        Me.Line50.Y2 = 10!
        '
        'Line51
        '
        Me.Line51.Height = 1.937!
        Me.Line51.Left = 1.1875!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 8.0625!
        Me.Line51.Width = 0!
        Me.Line51.X1 = 1.1875!
        Me.Line51.X2 = 1.1875!
        Me.Line51.Y1 = 8.0625!
        Me.Line51.Y2 = 9.9995!
        '
        'Label51
        '
        Me.Label51.Height = 0.18!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 1.6875!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label51.Text = "年     月     日"
        Me.Label51.Top = 8.125!
        Me.Label51.Width = 1.125!
        '
        'Label52
        '
        Me.Label52.Height = 0.18!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 1.5!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.Label52.Text = "年    月    日"
        Me.Label52.Top = 9.75!
        Me.Label52.Width = 1!
        '
        'lblNounyuRyo2
        '
        Me.lblNounyuRyo2.DataField = "ITEM_NM"
        Me.lblNounyuRyo2.Height = 0.2!
        Me.lblNounyuRyo2.HyperLink = Nothing
        Me.lblNounyuRyo2.Left = 2.375!
        Me.lblNounyuRyo2.Name = "lblNounyuRyo2"
        Me.lblNounyuRyo2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblNounyuRyo2.Text = "XX"
        Me.lblNounyuRyo2.Top = 8.4375!
        Me.lblNounyuRyo2.Width = 0.3125!
        '
        'lblKenshuRyo2
        '
        Me.lblKenshuRyo2.DataField = "ITEM_NM"
        Me.lblKenshuRyo2.Height = 0.2!
        Me.lblKenshuRyo2.HyperLink = Nothing
        Me.lblKenshuRyo2.Left = 2.125!
        Me.lblKenshuRyo2.Name = "lblKenshuRyo2"
        Me.lblKenshuRyo2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblKenshuRyo2.Text = "XX"
        Me.lblKenshuRyo2.Top = 9.427083!
        Me.lblKenshuRyo2.Width = 0.3125!
        '
        'Line52
        '
        Me.Line52.Height = 1.284583!
        Me.Line52.Left = 2.8375!
        Me.Line52.LineWeight = 3!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 8.062!
        Me.Line52.Width = 0!
        Me.Line52.X1 = 2.8375!
        Me.Line52.X2 = 2.8375!
        Me.Line52.Y1 = 8.062!
        Me.Line52.Y2 = 9.346583!
        '
        'Line53
        '
        Me.Line53.Height = 0.6534166!
        Me.Line53.Left = 2.5!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 9.346583!
        Me.Line53.Width = 0!
        Me.Line53.X1 = 2.5!
        Me.Line53.X2 = 2.5!
        Me.Line53.Y1 = 9.346583!
        Me.Line53.Y2 = 10!
        '
        'Line54
        '
        Me.Line54.Height = 1.284583!
        Me.Line54.Left = 0.25!
        Me.Line54.LineWeight = 3!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 8.061584!
        Me.Line54.Width = 0!
        Me.Line54.X1 = 0.25!
        Me.Line54.X2 = 0.25!
        Me.Line54.Y1 = 8.061584!
        Me.Line54.Y2 = 9.346167!
        '
        'Line55
        '
        Me.Line55.Height = 0!
        Me.Line55.Left = 0.25!
        Me.Line55.LineWeight = 3!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 8.062583!
        Me.Line55.Width = 2.6!
        Me.Line55.X1 = 0.25!
        Me.Line55.X2 = 2.85!
        Me.Line55.Y1 = 8.062583!
        Me.Line55.Y2 = 8.062583!
        '
        'Line62
        '
        Me.Line62.Height = 1.201001!
        Me.Line62.Left = 0.845834!
        Me.Line62.LineWeight = 1!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 5.937083!
        Me.Line62.Width = 0!
        Me.Line62.X1 = 0.845834!
        Me.Line62.X2 = 0.845834!
        Me.Line62.Y1 = 5.937083!
        Me.Line62.Y2 = 7.138083!
        '
        'Line56
        '
        Me.Line56.Height = 0!
        Me.Line56.Left = 5.375!
        Me.Line56.LineWeight = 1!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 9!
        Me.Line56.Width = 1.6!
        Me.Line56.X1 = 5.375!
        Me.Line56.X2 = 6.975!
        Me.Line56.Y1 = 9!
        Me.Line56.Y2 = 9!
        '
        'Line57
        '
        Me.Line57.Height = 0!
        Me.Line57.Left = 5.375!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 9.25!
        Me.Line57.Width = 1.6!
        Me.Line57.X1 = 5.375!
        Me.Line57.X2 = 6.975!
        Me.Line57.Y1 = 9.25!
        Me.Line57.Y2 = 9.25!
        '
        'Line58
        '
        Me.Line58.Height = 0!
        Me.Line58.Left = 5.375!
        Me.Line58.LineWeight = 1!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 10!
        Me.Line58.Width = 1.6!
        Me.Line58.X1 = 5.375!
        Me.Line58.X2 = 6.975!
        Me.Line58.Y1 = 10!
        Me.Line58.Y2 = 10!
        '
        'Line59
        '
        Me.Line59.Height = 1!
        Me.Line59.Left = 5.375!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 9!
        Me.Line59.Width = 0!
        Me.Line59.X1 = 5.375!
        Me.Line59.X2 = 5.375!
        Me.Line59.Y1 = 9!
        Me.Line59.Y2 = 10!
        '
        'Line60
        '
        Me.Line60.Height = 1!
        Me.Line60.Left = 6.1875!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 9!
        Me.Line60.Width = 0!
        Me.Line60.X1 = 6.1875!
        Me.Line60.X2 = 6.1875!
        Me.Line60.Y1 = 9!
        Me.Line60.Y2 = 10!
        '
        'Line61
        '
        Me.Line61.Height = 1!
        Me.Line61.Left = 6.9755!
        Me.Line61.LineWeight = 1!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 9!
        Me.Line61.Width = 0!
        Me.Line61.X1 = 6.9755!
        Me.Line61.X2 = 6.9755!
        Me.Line61.Y1 = 9!
        Me.Line61.Y2 = 10!
        '
        'Label67
        '
        Me.Label67.Height = 0.18!
        Me.Label67.HyperLink = Nothing
        Me.Label67.Left = 5.5625!
        Me.Label67.Name = "Label67"
        Me.Label67.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label67.Text = "品　質"
        Me.Label67.Top = 9.0625!
        Me.Label67.Width = 0.438!
        '
        'Label68
        '
        Me.Label68.Height = 0.18!
        Me.Label68.HyperLink = Nothing
        Me.Label68.Left = 6.375!
        Me.Label68.Name = "Label68"
        Me.Label68.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label68.Text = "生　管"
        Me.Label68.Top = 9.055!
        Me.Label68.Width = 0.438!
        '
        'Shape
        '
        Me.Shape.Height = 0.1875!
        Me.Shape.Left = 0.4375!
        Me.Shape.Name = "Shape"
        Me.Shape.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape.Top = 10.4375!
        Me.Shape.Width = 0.8125!
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
        Me.lblBikou1_4.Top = 2.29!
        Me.lblBikou1_4.Width = 4.188!
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
        Me.lblSenzai1.Top = 2.352917!
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
        Me.lblBikou2_4.Top = 7.842!
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
        Me.PrintWidth = 7.385417!
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
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKanriNM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHakkouYMD1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuCD1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuNM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKeikakuNouki1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKeikakuRyo1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKbn1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRenNO1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZaiCD1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShuZaiNM1_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZaiNM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou1_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou1_2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou1_3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNounyuRyo1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKenshuRyo1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKanriNM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHakkouYMD2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuCD2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblHatyuNM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKeikakuNouki2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKeikakuRyo2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKbn2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRenNO2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZaiCD2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblShuZaiNM2_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZaiNM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou2_1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou2_2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou2_3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSenzai2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblNounyuRyo2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblKenshuRyo2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou1_4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSenzai1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblBikou2_4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private Sub mdzai0303_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("HatyuDate")
        lblHakkouYMD1.DataField = "HatyuDate"
        lblHakkouYMD2.DataField = "HatyuDate"

        Fields.Add("KeikakuDate")
        lblKeikakuNouki1.DataField = "KeikakuDate"
        lblKeikakuNouki2.DataField = "KeikakuDate"

        Fields.Add("KeikakuRyo")
        lblKeikakuRyo1.DataField = "KeikakuRyo"
        lblKeikakuRyo2.DataField = "KeikakuRyo"
    End Sub

    Private Sub mdzai0303_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
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
