Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdtyk0206
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
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblRePrint1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Barcode As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private txtBarcode1 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTaniSozai1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtZairyoKubun1a As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKeisan1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZairyoKubun1b As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Shape As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtColor1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtJisei1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private linCoil1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
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
    Private TextBox12 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTanaban1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCoilNo1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSyukkoryo1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtHaraidasiryo1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtTani1a As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCoil1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSyukko1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtHaraidasi1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtHenkyaku1a As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtHenkyaku1b As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label35 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label36 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtTani1b As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label39 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label40 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblRePrint2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label29 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Barcode1 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private txtBarcode2 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox13 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox14 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label38 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label41 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox16 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label42 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label43 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label44 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label45 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox17 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTaniSozai2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label46 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label47 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label48 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtZairyoKubun2a As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKeisan2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZairyoKubun2b As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label49 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label50 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label51 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label52 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Shape3 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label53 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape4 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label54 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtColor2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtJisei2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape5 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label57 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private linCoil2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line79 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox22 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTanaban2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCoilNo2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSyukkoHaraidasiHead As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtTani2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCoil2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSyukkoHaraidasi As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtHenkyakuryo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSiyouHenkyaku As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label74 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line84 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line85 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line78 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private linSyukkoHaraidasi As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtHenkyaku2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSiyouHenkyakuHead As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label55 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label56 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSeisanKeikaku As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtYear As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMonthDay As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape6 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label58 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line75 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line76 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line77 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblZairyoKei1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblZairyoKei2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtyk0206))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRePrint1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Barcode = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.txtBarcode1 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTaniSozai1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtZairyoKubun1a = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKeisan1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZairyoKubun1b = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Shape = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtColor1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtJisei1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.linCoil1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
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
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTanaban1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCoilNo1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSyukkoryo1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtHaraidasiryo1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTani1a = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCoil1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSyukko1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtHaraidasi1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtHenkyaku1a = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtHenkyaku1b = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label35 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label36 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTani1b = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label39 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label40 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRePrint2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label29 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Barcode1 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.txtBarcode2 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label38 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label41 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox16 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label42 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label43 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label44 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label45 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox17 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTaniSozai2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label46 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label47 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label48 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtZairyoKubun2a = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKeisan2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZairyoKubun2b = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label49 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label50 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label51 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label52 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Shape3 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label53 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape4 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label54 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtColor2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtJisei2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape5 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label57 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.linCoil2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line79 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox22 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTanaban2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCoilNo2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSyukkoHaraidasiHead = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTani2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCoil2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSyukkoHaraidasi = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtHenkyakuryo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSiyouHenkyaku = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label74 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line84 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line85 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line78 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.linSyukkoHaraidasi = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtHenkyaku2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSiyouHenkyakuHead = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label55 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label56 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSeisanKeikaku = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtYear = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMonthDay = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape6 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label58 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line75 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line76 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line77 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblZairyoKei1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblZairyoKei2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRePrint1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTaniSozai1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyoKubun1a, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKeisan1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyoKubun1b, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtColor1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtJisei1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTanaban1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCoilNo1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyukkoryo1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHaraidasiryo1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTani1a, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCoil1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyukko1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHaraidasi1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHenkyaku1a, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHenkyaku1b, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTani1b, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRePrint2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTaniSozai2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyoKubun2a, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKeisan2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyoKubun2b, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtColor2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtJisei2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTanaban2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCoilNo2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyukkoHaraidasiHead, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTani2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCoil2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyukkoHaraidasi, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHenkyakuryo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSiyouHenkyaku, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHenkyaku2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSiyouHenkyakuHead, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSeisanKeikaku, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMonthDay, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZairyoKei1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblZairyoKei2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label2, Me.TextBox7, Me.lblRePrint1, Me.Label, Me.lblDate1, Me.TextBox, Me.Label3, Me.Label4, Me.TextBox1, Me.Barcode, Me.txtBarcode1, Me.Label5, Me.TextBox2, Me.Line, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Label6, Me.Line5, Me.TextBox3, Me.Label7, Me.TextBox4, Me.Label8, Me.Line7, Me.TextBox5, Me.Line8, Me.Label9, Me.Line9, Me.Line10, Me.Label10, Me.Line11, Me.Label11, Me.Line12, Me.Label12, Me.Line13, Me.TextBox6, Me.txtTaniSozai1, Me.Label13, Me.Label14, Me.Label15, Me.Line14, Me.Line15, Me.Line6, Me.Line16, Me.Line17, Me.txtZairyoKubun1a, Me.txtKeisan1, Me.txtZairyoKubun1b, Me.Line18, Me.Line19, Me.Label16, Me.Line20, Me.Label17, Me.Label18, Me.Line21, Me.Line22, Me.Line23, Me.Label19, Me.Line24, Me.Line25, Me.Shape, Me.Label20, Me.Shape1, Me.Label21, Me.txtColor1, Me.txtJisei1, Me.Shape2, Me.Label24, Me.Line26, Me.linCoil1, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.Line34, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Line39, Me.Line40, Me.Line41, Me.TextBox12, Me.txtTanaban1, Me.txtCoilNo1, Me.txtSyukkoryo1, Me.txtHaraidasiryo1, Me.txtTani1a, Me.txtCoil1, Me.txtSyukko1, Me.txtHaraidasi1, Me.Label28, Me.txtHenkyaku1a, Me.txtHenkyaku1b, Me.Label35, Me.Label36, Me.Label37, Me.txtTani1b, Me.Label39, Me.Label40, Me.Label25, Me.Label26, Me.Line27, Me.Label22, Me.Label23, Me.TextBox9, Me.lblRePrint2, Me.Label29, Me.lblDate2, Me.TextBox10, Me.Label31, Me.Label32, Me.TextBox11, Me.Barcode1, Me.txtBarcode2, Me.Label33, Me.TextBox13, Me.Line42, Me.Line43, Me.Line44, Me.Line45, Me.Line46, Me.Label34, Me.Line47, Me.TextBox14, Me.Label38, Me.TextBox15, Me.Label41, Me.Line48, Me.TextBox16, Me.Line49, Me.Label42, Me.Line50, Me.Line51, Me.Label43, Me.Line52, Me.Label44, Me.Line53, Me.Label45, Me.Line54, Me.TextBox17, Me.txtTaniSozai2, Me.Label46, Me.Label47, Me.Label48, Me.Line55, Me.Line56, Me.Line57, Me.Line59, Me.txtZairyoKubun2a, Me.txtKeisan2, Me.txtZairyoKubun2b, Me.Line60, Me.Line61, Me.Label49, Me.Line62, Me.Label50, Me.Label51, Me.Line63, Me.Line64, Me.Line65, Me.Label52, Me.Line66, Me.Line67, Me.Shape3, Me.Label53, Me.Shape4, Me.Label54, Me.txtColor2, Me.txtJisei2, Me.Shape5, Me.Label57, Me.Line68, Me.linCoil2, Me.Line70, Me.Line79, Me.TextBox22, Me.txtTanaban2, Me.txtCoilNo2, Me.txtSyukkoHaraidasiHead, Me.txtTani2, Me.txtCoil2, Me.txtSyukkoHaraidasi, Me.txtHenkyakuryo, Me.txtSiyouHenkyaku, Me.Label74, Me.Line84, Me.Line85, Me.Line78, Me.linSyukkoHaraidasi, Me.txtHenkyaku2, Me.txtSiyouHenkyakuHead, Me.Line58, Me.Label30, Me.Line71, Me.Label55, Me.Line72, Me.Label56, Me.txtSeisanKeikaku, Me.txtYear, Me.txtMonthDay, Me.Label27, Me.Shape6, Me.Line69, Me.Label58, Me.Line73, Me.Line74, Me.Line75, Me.Line76, Me.Line77, Me.lblZairyoKei1, Me.lblZairyoKei2})
        Me.Detail.Height = 11.19792!
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
        'Label1
        '
        Me.Label1.Height = 0.2666667!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.06666672!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center; ver" & _
            "tical-align: bottom"
        Me.Label1.Text = "主材料出庫表（受領票兼返却票）"
        Me.Label1.Top = -7.450583E-09!
        Me.Label1.Width = 7.466667!
        '
        'Label2
        '
        Me.Label2.Height = 0.2000001!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.2!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.Label2.Text = "指示NO"
        Me.Label2.Top = 0!
        Me.Label2.Width = 0.4666668!
        '
        'TextBox7
        '
        Me.TextBox7.DataField = "INDICATE_NO1"
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 0.6666667!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.TextBox7.Text = "99999"
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 0.3999999!
        '
        'lblRePrint1
        '
        Me.lblRePrint1.Height = 0.2!
        Me.lblRePrint1.HyperLink = Nothing
        Me.lblRePrint1.Left = 5.733331!
        Me.lblRePrint1.Name = "lblRePrint1"
        Me.lblRePrint1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.lblRePrint1.Text = "再発行"
        Me.lblRePrint1.Top = 0!
        Me.lblRePrint1.Width = 0.4666691!
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 5.400001!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.Label.Text = "発行日"
        Me.Label.Top = 0.2666667!
        Me.Label.Width = 0.4666663!
        '
        'lblDate1
        '
        Me.lblDate1.Height = 0.2!
        Me.lblDate1.HyperLink = Nothing
        Me.lblDate1.Left = 5.933334!
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom"
        Me.lblDate1.Text = "yyyy/mm/dd"
        Me.lblDate1.Top = 0.2666667!
        Me.lblDate1.Width = 0.6666666!
        '
        'TextBox
        '
        Me.TextBox.DataField = "O_CATALOG_NO"
        Me.TextBox.Height = 0.2000001!
        Me.TextBox.Left = 1.533333!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: left; verti" & _
            "cal-align: bottom; white-space: nowrap"
        Me.TextBox.Text = "XXXXXXXXXXXXXXXXX"
        Me.TextBox.Top = 0.4000001!
        Me.TextBox.Width = 1.6!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.3333334!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: right; vert" & _
            "ical-align: bottom"
        Me.Label3.Text = "カタログ番号："
        Me.Label3.Top = 0.4000001!
        Me.Label3.Width = 1.2!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.3333333!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: right; vert" & _
            "ical-align: bottom"
        Me.Label4.Text = "材料コード："
        Me.Label4.Top = 0.7333333!
        Me.Label4.Width = 1.2!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "MATL_CD"
        Me.TextBox1.Height = 0.2000001!
        Me.TextBox1.Left = 1.533334!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: left; verti" & _
            "cal-align: bottom; white-space: nowrap"
        Me.TextBox1.Text = "XXXXXXXXXXXXXXXXX"
        Me.TextBox1.Top = 0.7333333!
        Me.TextBox1.Width = 1.6!
        '
        'Barcode
        '
        Me.Barcode.CaptionPosition = GrapeCity.ActiveReports.SectionReportModel.BarCodeCaptionPosition.Below
        Me.Barcode.CheckSumEnabled = false
        Me.Barcode.DataField = "REN_NO"
        Me.Barcode.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.Barcode.Height = 0.3999999!
        Me.Barcode.Left = 1.8125!
        Me.Barcode.Name = "Barcode"
        Me.Barcode.QuietZoneBottom = 0!
        Me.Barcode.QuietZoneLeft = 0!
        Me.Barcode.QuietZoneRight = 0!
        Me.Barcode.QuietZoneTop = 0!
        Me.Barcode.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode.Text = "99999"
        Me.Barcode.Top = 1!
        Me.Barcode.Width = 1.375!
        '
        'txtBarcode1
        '
        Me.txtBarcode1.CaptionPosition = GrapeCity.ActiveReports.SectionReportModel.BarCodeCaptionPosition.Below
        Me.txtBarcode1.CheckSumEnabled = false
        Me.txtBarcode1.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.txtBarcode1.Height = 0.3999999!
        Me.txtBarcode1.Left = 3.933333!
        Me.txtBarcode1.Name = "txtBarcode1"
        Me.txtBarcode1.QuietZoneBottom = 0!
        Me.txtBarcode1.QuietZoneLeft = 0!
        Me.txtBarcode1.QuietZoneRight = 0!
        Me.txtBarcode1.QuietZoneTop = 0!
        Me.txtBarcode1.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.txtBarcode1.Text = "99999999999"
        Me.txtBarcode1.Top = 1.004167!
        Me.txtBarcode1.Width = 2.466667!
        '
        'Label5
        '
        Me.Label5.Height = 0.2000001!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.3333333!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label5.Text = "連NO"
        Me.Label5.Top = 1.4!
        Me.Label5.Width = 0.4000001!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "REN_NO"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 1!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.TextBox2.Text = "99999"
        Me.TextBox2.Top = 1.4!
        Me.TextBox2.Width = 0.3999999!
        '
        'Line
        '
        Me.Line.Height = 3.666667!
        Me.Line.Left = 0.2!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.266667!
        Me.Line.Width = 0!
        Me.Line.X1 = 0.2!
        Me.Line.X2 = 0.2!
        Me.Line.Y1 = 1.266667!
        Me.Line.Y2 = 4.933333!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0.2!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.266667!
        Me.Line1.Width = 1.333333!
        Me.Line1.X1 = 0.2!
        Me.Line1.X2 = 1.533333!
        Me.Line1.Y1 = 1.266667!
        Me.Line1.Y2 = 1.266667!
        '
        'Line2
        '
        Me.Line2.Height = 1.4!
        Me.Line2.Left = 0.8666667!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.266667!
        Me.Line2.Width = 0!
        Me.Line2.X1 = 0.8666667!
        Me.Line2.X2 = 0.8666667!
        Me.Line2.Y1 = 1.266667!
        Me.Line2.Y2 = 2.666667!
        '
        'Line3
        '
        Me.Line3.Height = 0.4666667!
        Me.Line3.Left = 1.533333!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 1.266667!
        Me.Line3.Width = 7.152557E-07!
        Me.Line3.X1 = 1.533334!
        Me.Line3.X2 = 1.533333!
        Me.Line3.Y1 = 1.266667!
        Me.Line3.Y2 = 1.733333!
        '
        'Line4
        '
        Me.Line4.Height = 7.152557E-07!
        Me.Line4.Left = 0.2!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.733333!
        Me.Line4.Width = 2.8!
        Me.Line4.X1 = 0.2!
        Me.Line4.X2 = 3!
        Me.Line4.Y1 = 1.733334!
        Me.Line4.Y2 = 1.733333!
        '
        'Label6
        '
        Me.Label6.Height = 0.2000001!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.3333333!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label6.Text = "組番"
        Me.Label6.Top = 1.866667!
        Me.Label6.Width = 0.4000001!
        '
        'Line5
        '
        Me.Line5.Height = 7.152557E-07!
        Me.Line5.Left = 0.2!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 2.2!
        Me.Line5.Width = 2.8!
        Me.Line5.X1 = 0.2!
        Me.Line5.X2 = 3!
        Me.Line5.Y1 = 2.200001!
        Me.Line5.Y2 = 2.2!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "C_NO"
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 0.3333333!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox3.Text = "XX"
        Me.TextBox3.Top = 2.333333!
        Me.TextBox3.Width = 0.4!
        '
        'Label7
        '
        Me.Label7.Height = 0.2000001!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.9333333!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label7.Text = "社内NO"
        Me.Label7.Top = 1.866667!
        Me.Label7.Width = 0.9333333!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "COMPANY_NO"
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 0.9333333!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox4.Text = "999999"
        Me.TextBox4.Top = 2.333333!
        Me.TextBox4.Width = 0.9333333!
        '
        'Label8
        '
        Me.Label8.Height = 0.2000001!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label8.Text = "指示NO"
        Me.Label8.Top = 1.866667!
        Me.Label8.Width = 0.9333333!
        '
        'Line7
        '
        Me.Line7.Height = 1.933333!
        Me.Line7.Left = 3!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 1.733333!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 3!
        Me.Line7.X2 = 3!
        Me.Line7.Y1 = 1.733333!
        Me.Line7.Y2 = 3.666667!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "INDICATE_NO2"
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 2!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox5.Text = "99999"
        Me.TextBox5.Top = 2.333333!
        Me.TextBox5.Width = 0.9333333!
        '
        'Line8
        '
        Me.Line8.Height = 7.152557E-07!
        Me.Line8.Left = 0.2!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 2.666667!
        Me.Line8.Width = 2.8!
        Me.Line8.X1 = 0.2!
        Me.Line8.X2 = 3!
        Me.Line8.Y1 = 2.666667!
        Me.Line8.Y2 = 2.666667!
        '
        'Label9
        '
        Me.Label9.Height = 0.2000001!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.2666667!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label9.Text = "着 工 数"
        Me.Label9.Top = 2.733333!
        Me.Label9.Width = 1!
        '
        'Line9
        '
        Me.Line9.Height = 1.333333!
        Me.Line9.Left = 1.333333!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 2.666667!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 1.333333!
        Me.Line9.X2 = 1.333333!
        Me.Line9.Y1 = 2.666667!
        Me.Line9.Y2 = 4!
        '
        'Line10
        '
        Me.Line10.Height = 0!
        Me.Line10.Left = 0.2!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 3!
        Me.Line10.Width = 2.8!
        Me.Line10.X1 = 0.2!
        Me.Line10.X2 = 3!
        Me.Line10.Y1 = 3!
        Me.Line10.Y2 = 3!
        '
        'Label10
        '
        Me.Label10.Height = 0.2000001!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.2666667!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label10.Text = "単位素材"
        Me.Label10.Top = 3.066667!
        Me.Label10.Width = 1!
        '
        'Line11
        '
        Me.Line11.Height = 0!
        Me.Line11.Left = 0.2!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 3.333333!
        Me.Line11.Width = 2.8!
        Me.Line11.X1 = 0.2!
        Me.Line11.X2 = 3!
        Me.Line11.Y1 = 3.333333!
        Me.Line11.Y2 = 3.333333!
        '
        'Label11
        '
        Me.Label11.Height = 0.2000001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.2666667!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label11.Text = "計算使用量"
        Me.Label11.Top = 3.399999!
        Me.Label11.Width = 1!
        '
        'Line12
        '
        Me.Line12.Height = 0!
        Me.Line12.Left = 0.2!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 3.666667!
        Me.Line12.Width = 2.8!
        Me.Line12.X1 = 0.2!
        Me.Line12.X2 = 3!
        Me.Line12.Y1 = 3.666667!
        Me.Line12.Y2 = 3.666667!
        '
        'Label12
        '
        Me.Label12.Height = 0.2000001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.2666667!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label12.Text = "出庫要求量"
        Me.Label12.Top = 3.733333!
        Me.Label12.Width = 1!
        '
        'Line13
        '
        Me.Line13.Height = 1.430511E-06!
        Me.Line13.Left = 0.2!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 3.999999!
        Me.Line13.Width = 1.866667!
        Me.Line13.X1 = 0.2!
        Me.Line13.X2 = 2.066667!
        Me.Line13.Y1 = 3.999999!
        Me.Line13.Y2 = 4!
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "STW_AMT"
        Me.TextBox6.Height = 0.2!
        Me.TextBox6.Left = 1.466667!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.TextBox6.Text = "99999"
        Me.TextBox6.Top = 2.733333!
        Me.TextBox6.Width = 1!
        '
        'txtTaniSozai1
        '
        Me.txtTaniSozai1.Height = 0.2!
        Me.txtTaniSozai1.Left = 1.466667!
        Me.txtTaniSozai1.Name = "txtTaniSozai1"
        Me.txtTaniSozai1.OutputFormat = resources.GetString("txtTaniSozai1.OutputFormat")
        Me.txtTaniSozai1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.txtTaniSozai1.Text = "99999"
        Me.txtTaniSozai1.Top = 3.066667!
        Me.txtTaniSozai1.Width = 1!
        '
        'Label13
        '
        Me.Label13.Height = 0.2000001!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.2666667!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label13.Text = "出庫者"
        Me.Label13.Top = 4.066667!
        Me.Label13.Width = 0.8!
        '
        'Label14
        '
        Me.Label14.Height = 0.2000001!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 1.2!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label14.Text = "出庫先"
        Me.Label14.Top = 4.066667!
        Me.Label14.Width = 0.8!
        '
        'Label15
        '
        Me.Label15.Height = 0.2000001!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 2.133333!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label15.Text = "出庫先受領"
        Me.Label15.Top = 4.066667!
        Me.Label15.Width = 0.8!
        '
        'Line14
        '
        Me.Line14.Height = 1.430511E-06!
        Me.Line14.Left = 0.2!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 4.333332!
        Me.Line14.Width = 2.8!
        Me.Line14.X1 = 0.2!
        Me.Line14.X2 = 3!
        Me.Line14.Y1 = 4.333332!
        Me.Line14.Y2 = 4.333333!
        '
        'Line15
        '
        Me.Line15.Height = 1.430511E-06!
        Me.Line15.Left = 0.2!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 4.933332!
        Me.Line15.Width = 1.866667!
        Me.Line15.X1 = 0.2!
        Me.Line15.X2 = 2.066667!
        Me.Line15.Y1 = 4.933332!
        Me.Line15.Y2 = 4.933333!
        '
        'Line6
        '
        Me.Line6.Height = 0.9333334!
        Me.Line6.Left = 1.933333!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.733333!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 1.933333!
        Me.Line6.X2 = 1.933333!
        Me.Line6.Y1 = 1.733333!
        Me.Line6.Y2 = 2.666667!
        '
        'Line16
        '
        Me.Line16.Height = 0.9333348!
        Me.Line16.Left = 2.066667!
        Me.Line16.LineWeight = 3!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 3.999999!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 2.066667!
        Me.Line16.X2 = 2.066667!
        Me.Line16.Y1 = 3.999999!
        Me.Line16.Y2 = 4.933333!
        '
        'Line17
        '
        Me.Line17.Height = 0.9333348!
        Me.Line17.Left = 1.133333!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 3.999999!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 1.133333!
        Me.Line17.X2 = 1.133333!
        Me.Line17.Y1 = 3.999999!
        Me.Line17.Y2 = 4.933333!
        '
        'txtZairyoKubun1a
        '
        Me.txtZairyoKubun1a.Height = 0.2!
        Me.txtZairyoKubun1a.Left = 2.6!
        Me.txtZairyoKubun1a.Name = "txtZairyoKubun1a"
        Me.txtZairyoKubun1a.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.txtZairyoKubun1a.Text = "XX"
        Me.txtZairyoKubun1a.Top = 3.066667!
        Me.txtZairyoKubun1a.Width = 0.2666667!
        '
        'txtKeisan1
        '
        Me.txtKeisan1.Height = 0.2!
        Me.txtKeisan1.Left = 1.466667!
        Me.txtKeisan1.Name = "txtKeisan1"
        Me.txtKeisan1.OutputFormat = resources.GetString("txtKeisan1.OutputFormat")
        Me.txtKeisan1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.txtKeisan1.Text = "99999"
        Me.txtKeisan1.Top = 3.4!
        Me.txtKeisan1.Width = 1!
        '
        'txtZairyoKubun1b
        '
        Me.txtZairyoKubun1b.Height = 0.2!
        Me.txtZairyoKubun1b.Left = 2.6!
        Me.txtZairyoKubun1b.Name = "txtZairyoKubun1b"
        Me.txtZairyoKubun1b.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.txtZairyoKubun1b.Text = "XX"
        Me.txtZairyoKubun1b.Top = 3.4!
        Me.txtZairyoKubun1b.Width = 0.2666667!
        '
        'Line18
        '
        Me.Line18.Height = 1.311302E-06!
        Me.Line18.Left = 3!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 1.866667!
        Me.Line18.Width = 4.466667!
        Me.Line18.X1 = 3!
        Me.Line18.X2 = 7.466667!
        Me.Line18.Y1 = 1.866668!
        Me.Line18.Y2 = 1.866667!
        '
        'Line19
        '
        Me.Line19.Height = 1.799999!
        Me.Line19.Left = 3.533333!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 1.866667!
        Me.Line19.Width = 7.152557E-07!
        Me.Line19.X1 = 3.533333!
        Me.Line19.X2 = 3.533333!
        Me.Line19.Y1 = 1.866667!
        Me.Line19.Y2 = 3.666667!
        '
        'Label16
        '
        Me.Label16.Height = 1.533333!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 3.2!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label16.Text = "出　庫　内　訳"
        Me.Label16.Top = 2!
        Me.Label16.Width = 0.1333347!
        '
        'Line20
        '
        Me.Line20.Height = 2.466666!
        Me.Line20.Left = 4.466665!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 1.866667!
        Me.Line20.Width = 1.430511E-06!
        Me.Line20.X1 = 4.466665!
        Me.Line20.X2 = 4.466667!
        Me.Line20.Y1 = 1.866667!
        Me.Line20.Y2 = 4.333333!
        '
        'Label17
        '
        Me.Label17.Height = 0.2000001!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 3.6!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label17.Text = "材料ロットNO"
        Me.Label17.Top = 2!
        Me.Label17.Width = 0.8!
        '
        'Label18
        '
        Me.Label18.Height = 0.2000001!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 3.599999!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label18.Text = "棚　　番"
        Me.Label18.Top = 2.4!
        Me.Label18.Width = 0.8!
        '
        'Line21
        '
        Me.Line21.Height = 0!
        Me.Line21.Left = 3.533333!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 2.333333!
        Me.Line21.Width = 3.933333!
        Me.Line21.X1 = 3.533333!
        Me.Line21.X2 = 7.466667!
        Me.Line21.Y1 = 2.333333!
        Me.Line21.Y2 = 2.333333!
        '
        'Line22
        '
        Me.Line22.Height = 0!
        Me.Line22.Left = 3.533333!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 2.666667!
        Me.Line22.Width = 3.933333!
        Me.Line22.X1 = 3.533333!
        Me.Line22.X2 = 7.466667!
        Me.Line22.Y1 = 2.666667!
        Me.Line22.Y2 = 2.666667!
        '
        'Line23
        '
        Me.Line23.Height = 2.133333!
        Me.Line23.Left = 7.46666!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 1.533333!
        Me.Line23.Width = 6.67572E-06!
        Me.Line23.X1 = 7.466667!
        Me.Line23.X2 = 7.46666!
        Me.Line23.Y1 = 1.533333!
        Me.Line23.Y2 = 3.666667!
        '
        'Label19
        '
        Me.Label19.Height = 0.2000001!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 6.733333!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label19.Text = "返却確認"
        Me.Label19.Top = 1.600001!
        Me.Label19.Width = 0.6666632!
        '
        'Line24
        '
        Me.Line24.Height = 0!
        Me.Line24.Left = 6.666667!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 1.533333!
        Me.Line24.Width = 0.7999935!
        Me.Line24.X1 = 6.666667!
        Me.Line24.X2 = 7.46666!
        Me.Line24.Y1 = 1.533333!
        Me.Line24.Y2 = 1.533333!
        '
        'Line25
        '
        Me.Line25.Height = 0.3333292!
        Me.Line25.Left = 6.666663!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 1.533334!
        Me.Line25.Width = 0!
        Me.Line25.X1 = 6.666663!
        Me.Line25.X2 = 6.666663!
        Me.Line25.Y1 = 1.533334!
        Me.Line25.Y2 = 1.866663!
        '
        'Shape
        '
        Me.Shape.Height = 0.1333333!
        Me.Shape.Left = 3.3125!
        Me.Shape.Name = "Shape"
        Me.Shape.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape.Top = 1.5625!
        Me.Shape.Width = 0.1333333!
        '
        'Label20
        '
        Me.Label20.Height = 0.15!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 3.5!
        Me.Label20.MultiLine = false
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.Label20.Text = "色識別"
        Me.Label20.Top = 1.5!
        Me.Label20.Width = 0.4000001!
        '
        'Shape1
        '
        Me.Shape1.Height = 0.1333333!
        Me.Shape1.Left = 4.625!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape1.Top = 1.5625!
        Me.Shape1.Width = 0.1333333!
        '
        'Label21
        '
        Me.Label21.Height = 0.15!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 4.8125!
        Me.Label21.MultiLine = false
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.Label21.Text = "磁性"
        Me.Label21.Top = 1.5!
        Me.Label21.Width = 0.267!
        '
        'txtColor1
        '
        Me.txtColor1.Height = 0.15!
        Me.txtColor1.HyperLink = Nothing
        Me.txtColor1.Left = 3.625!
        Me.txtColor1.MultiLine = false
        Me.txtColor1.Name = "txtColor1"
        Me.txtColor1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.txtColor1.Text = "XXXXXXXX"
        Me.txtColor1.Top = 1.6875!
        Me.txtColor1.Width = 0.6000001!
        '
        'txtJisei1
        '
        Me.txtJisei1.Height = 0.15!
        Me.txtJisei1.HyperLink = Nothing
        Me.txtJisei1.Left = 4.9375!
        Me.txtJisei1.MultiLine = false
        Me.txtJisei1.Name = "txtJisei1"
        Me.txtJisei1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.txtJisei1.Text = "XXXX"
        Me.txtJisei1.Top = 1.6875!
        Me.txtJisei1.Width = 0.333!
        '
        'Shape2
        '
        Me.Shape2.Height = 0.1333333!
        Me.Shape2.Left = 5.6875!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape2.Top = 1.5625!
        Me.Shape2.Width = 0.1333333!
        '
        'Label24
        '
        Me.Label24.Height = 0.1499994!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 5.875!
        Me.Label24.MultiLine = false
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.Label24.Text = "材料径"
        Me.Label24.Top = 1.5!
        Me.Label24.Width = 0.4000039!
        '
        'Line26
        '
        Me.Line26.Height = 0.7999994!
        Me.Line26.Left = 6.666663!
        Me.Line26.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 1.866667!
        Me.Line26.Width = 0!
        Me.Line26.X1 = 6.666663!
        Me.Line26.X2 = 6.666663!
        Me.Line26.Y1 = 1.866667!
        Me.Line26.Y2 = 2.666667!
        '
        'linCoil1
        '
        Me.linCoil1.Height = 0!
        Me.linCoil1.Left = 3.533333!
        Me.linCoil1.LineWeight = 1!
        Me.linCoil1.Name = "linCoil1"
        Me.linCoil1.Top = 2.933333!
        Me.linCoil1.Width = 3.933333!
        Me.linCoil1.X1 = 3.533333!
        Me.linCoil1.X2 = 7.466667!
        Me.linCoil1.Y1 = 2.933333!
        Me.linCoil1.Y2 = 2.933333!
        '
        'Line28
        '
        Me.Line28.Height = 7.152557E-07!
        Me.Line28.Left = 3!
        Me.Line28.LineWeight = 3!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 3.666666!
        Me.Line28.Width = 4.466667!
        Me.Line28.X1 = 3!
        Me.Line28.X2 = 7.466667!
        Me.Line28.Y1 = 3.666667!
        Me.Line28.Y2 = 3.666666!
        '
        'Line29
        '
        Me.Line29.Height = 1.266666!
        Me.Line29.Left = 2.999999!
        Me.Line29.LineWeight = 3!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 3.666666!
        Me.Line29.Width = 0!
        Me.Line29.X1 = 2.999999!
        Me.Line29.X2 = 2.999999!
        Me.Line29.Y1 = 3.666666!
        Me.Line29.Y2 = 4.933332!
        '
        'Line30
        '
        Me.Line30.Height = 0!
        Me.Line30.Left = 2.066667!
        Me.Line30.LineWeight = 3!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 4!
        Me.Line30.Width = 0.9333327!
        Me.Line30.X1 = 2.066667!
        Me.Line30.X2 = 3!
        Me.Line30.Y1 = 4!
        Me.Line30.Y2 = 4!
        '
        'Line31
        '
        Me.Line31.Height = 4.768372E-07!
        Me.Line31.Left = 2.066667!
        Me.Line31.LineWeight = 3!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 4.933333!
        Me.Line31.Width = 0.9333327!
        Me.Line31.X1 = 2.066667!
        Me.Line31.X2 = 3!
        Me.Line31.Y1 = 4.933333!
        Me.Line31.Y2 = 4.933334!
        '
        'Line32
        '
        Me.Line32.Height = 1.430511E-06!
        Me.Line32.Left = 3.533333!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 4.333333!
        Me.Line32.Width = 0.9333327!
        Me.Line32.X1 = 3.533333!
        Me.Line32.X2 = 4.466665!
        Me.Line32.Y1 = 4.333333!
        Me.Line32.Y2 = 4.333335!
        '
        'Line33
        '
        Me.Line33.Height = 9.536743E-07!
        Me.Line33.Left = 3!
        Me.Line33.LineWeight = 3!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 4.333334!
        Me.Line33.Width = 0.5333326!
        Me.Line33.X1 = 3!
        Me.Line33.X2 = 3.533333!
        Me.Line33.Y1 = 4.333334!
        Me.Line33.Y2 = 4.333335!
        '
        'Line34
        '
        Me.Line34.Height = 0.7333345!
        Me.Line34.Left = 3.533333!
        Me.Line34.LineWeight = 3!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 4.333332!
        Me.Line34.Width = 7.152557E-07!
        Me.Line34.X1 = 3.533333!
        Me.Line34.X2 = 3.533333!
        Me.Line34.Y1 = 4.333332!
        Me.Line34.Y2 = 5.066667!
        '
        'Line35
        '
        Me.Line35.Height = 9.536743E-07!
        Me.Line35.Left = 4.466665!
        Me.Line35.LineWeight = 3!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 4.333335!
        Me.Line35.Width = 2.999995!
        Me.Line35.X1 = 4.466665!
        Me.Line35.X2 = 7.46666!
        Me.Line35.Y1 = 4.333335!
        Me.Line35.Y2 = 4.333336!
        '
        'Line36
        '
        Me.Line36.Height = 0.6666675!
        Me.Line36.Left = 7.46666!
        Me.Line36.LineWeight = 3!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 3.666666!
        Me.Line36.Width = 0!
        Me.Line36.X1 = 7.46666!
        Me.Line36.X2 = 7.46666!
        Me.Line36.Y1 = 3.666666!
        Me.Line36.Y2 = 4.333333!
        '
        'Line37
        '
        Me.Line37.Height = 0.7333341!
        Me.Line37.Left = 7.46666!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 4.333332!
        Me.Line37.Width = 0!
        Me.Line37.X1 = 7.46666!
        Me.Line37.X2 = 7.46666!
        Me.Line37.Y1 = 4.333332!
        Me.Line37.Y2 = 5.066666!
        '
        'Line38
        '
        Me.Line38.Height = 0.7333341!
        Me.Line38.Left = 4.466665!
        Me.Line38.LineWeight = 3!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 4.333332!
        Me.Line38.Width = 1.430511E-06!
        Me.Line38.X1 = 4.466665!
        Me.Line38.X2 = 4.466667!
        Me.Line38.Y1 = 4.333332!
        Me.Line38.Y2 = 5.066666!
        '
        'Line39
        '
        Me.Line39.Height = 4.768372E-07!
        Me.Line39.Left = 3.533333!
        Me.Line39.LineWeight = 3!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 5.066668!
        Me.Line39.Width = 0.9333322!
        Me.Line39.X1 = 3.533333!
        Me.Line39.X2 = 4.466665!
        Me.Line39.Y1 = 5.066668!
        Me.Line39.Y2 = 5.066668!
        '
        'Line40
        '
        Me.Line40.Height = 0!
        Me.Line40.Left = 4.466667!
        Me.Line40.LineWeight = 1!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 5.066665!
        Me.Line40.Width = 3!
        Me.Line40.X1 = 4.466667!
        Me.Line40.X2 = 7.466667!
        Me.Line40.Y1 = 5.066665!
        Me.Line40.Y2 = 5.066665!
        '
        'Line41
        '
        Me.Line41.Height = 0.7333331!
        Me.Line41.Left = 6.266663!
        Me.Line41.LineWeight = 1!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 4.333332!
        Me.Line41.Width = 0!
        Me.Line41.X1 = 6.266663!
        Me.Line41.X2 = 6.266663!
        Me.Line41.Y1 = 4.333332!
        Me.Line41.Y2 = 5.066665!
        '
        'TextBox12
        '
        Me.TextBox12.DataField = "LOT_NO"
        Me.TextBox12.Height = 0.1999992!
        Me.TextBox12.Left = 4.599998!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: bottom; white-space: nowrap"
        Me.TextBox12.Text = "XXXXXXXXXXXXXXXXX"
        Me.TextBox12.Top = 2.000001!
        Me.TextBox12.Width = 1.933335!
        '
        'txtTanaban1
        '
        Me.txtTanaban1.Height = 0.1999992!
        Me.txtTanaban1.Left = 4.599998!
        Me.txtTanaban1.Name = "txtTanaban1"
        Me.txtTanaban1.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: bottom; white-space: nowrap"
        Me.txtTanaban1.Text = "XXXXX(XXXXX)"
        Me.txtTanaban1.Top = 2.4!
        Me.txtTanaban1.Width = 1.933335!
        '
        'txtCoilNo1
        '
        Me.txtCoilNo1.Height = 0.1333334!
        Me.txtCoilNo1.HyperLink = Nothing
        Me.txtCoilNo1.Left = 3.599999!
        Me.txtCoilNo1.Name = "txtCoilNo1"
        Me.txtCoilNo1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: top"
        Me.txtCoilNo1.Text = "コイルNO"
        Me.txtCoilNo1.Top = 2.733333!
        Me.txtCoilNo1.Width = 0.8!
        '
        'txtSyukkoryo1
        '
        Me.txtSyukkoryo1.Height = 0.1333334!
        Me.txtSyukkoryo1.HyperLink = Nothing
        Me.txtSyukkoryo1.Left = 3.6!
        Me.txtSyukkoryo1.Name = "txtSyukkoryo1"
        Me.txtSyukkoryo1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: top"
        Me.txtSyukkoryo1.Text = "出 庫 量"
        Me.txtSyukkoryo1.Top = 3!
        Me.txtSyukkoryo1.Width = 0.8!
        '
        'txtHaraidasiryo1
        '
        Me.txtHaraidasiryo1.Height = 0.1333334!
        Me.txtHaraidasiryo1.HyperLink = Nothing
        Me.txtHaraidasiryo1.Left = 3.6!
        Me.txtHaraidasiryo1.Name = "txtHaraidasiryo1"
        Me.txtHaraidasiryo1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: top"
        Me.txtHaraidasiryo1.Text = "払 出 量"
        Me.txtHaraidasiryo1.Top = 3.266667!
        Me.txtHaraidasiryo1.Width = 0.8!
        '
        'txtTani1a
        '
        Me.txtTani1a.Height = 0.1333334!
        Me.txtTani1a.HyperLink = Nothing
        Me.txtTani1a.Left = 6.266663!
        Me.txtTani1a.Name = "txtTani1a"
        Me.txtTani1a.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: top"
        Me.txtTani1a.Text = "単位  全数払出"
        Me.txtTani1a.Top = 3.466666!
        Me.txtTani1a.Width = 1.133333!
        '
        'txtCoil1
        '
        Me.txtCoil1.Height = 0.1333334!
        Me.txtCoil1.HyperLink = Nothing
        Me.txtCoil1.Left = 4.6!
        Me.txtCoil1.Name = "txtCoil1"
        Me.txtCoil1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.txtCoil1.Text = "L=       X       本     L=       X       本"
        Me.txtCoil1.Top = 2.733333!
        Me.txtCoil1.Width = 2.733333!
        '
        'txtSyukko1
        '
        Me.txtSyukko1.Height = 0.1333334!
        Me.txtSyukko1.HyperLink = Nothing
        Me.txtSyukko1.Left = 4.599998!
        Me.txtSyukko1.Name = "txtSyukko1"
        Me.txtSyukko1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.txtSyukko1.Text = "L=       X       本     L=       X       本"
        Me.txtSyukko1.Top = 3!
        Me.txtSyukko1.Width = 2.733333!
        '
        'txtHaraidasi1
        '
        Me.txtHaraidasi1.Height = 0.1333334!
        Me.txtHaraidasi1.HyperLink = Nothing
        Me.txtHaraidasi1.Left = 4.599998!
        Me.txtHaraidasi1.Name = "txtHaraidasi1"
        Me.txtHaraidasi1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.txtHaraidasi1.Text = "L=       X       本"
        Me.txtHaraidasi1.Top = 3.266667!
        Me.txtHaraidasi1.Width = 2.133335!
        '
        'Label28
        '
        Me.Label28.Height = 0.2666664!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 3.133333!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label28.Text = "返　却　量"
        Me.Label28.Top = 3.866667!
        Me.Label28.Width = 1.2!
        '
        'txtHenkyaku1a
        '
        Me.txtHenkyaku1a.Height = 0.1333334!
        Me.txtHenkyaku1a.HyperLink = Nothing
        Me.txtHenkyaku1a.Left = 4.599998!
        Me.txtHenkyaku1a.Name = "txtHenkyaku1a"
        Me.txtHenkyaku1a.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.txtHenkyaku1a.Text = "L=       X       本"
        Me.txtHenkyaku1a.Top = 3.799999!
        Me.txtHenkyaku1a.Width = 2.133335!
        '
        'txtHenkyaku1b
        '
        Me.txtHenkyaku1b.Height = 0.1333334!
        Me.txtHenkyaku1b.HyperLink = Nothing
        Me.txtHenkyaku1b.Left = 4.599998!
        Me.txtHenkyaku1b.Name = "txtHenkyaku1b"
        Me.txtHenkyaku1b.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.txtHenkyaku1b.Text = "L=       X       本          単位"
        Me.txtHenkyaku1b.Top = 4.066666!
        Me.txtHenkyaku1b.Width = 2.133335!
        '
        'Label35
        '
        Me.Label35.Height = 0.2000001!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 3.599999!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label35.Text = "返却印"
        Me.Label35.Top = 4.399999!
        Me.Label35.Width = 0.5333334!
        '
        'Label36
        '
        Me.Label36.Height = 0.2000001!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 4.533332!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label36.Text = "差引量"
        Me.Label36.Top = 4.399999!
        Me.Label36.Width = 0.5333334!
        '
        'Label37
        '
        Me.Label37.Height = 0.2000001!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 6.33333!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label37.Text = "返品入力"
        Me.Label37.Top = 4.4!
        Me.Label37.Width = 0.5333334!
        '
        'txtTani1b
        '
        Me.txtTani1b.Height = 0.2000001!
        Me.txtTani1b.HyperLink = Nothing
        Me.txtTani1b.Left = 5.133331!
        Me.txtTani1b.Name = "txtTani1b"
        Me.txtTani1b.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtTani1b.Text = "単位"
        Me.txtTani1b.Top = 4.799999!
        Me.txtTani1b.Width = 0.3333354!
        '
        'Label39
        '
        Me.Label39.Height = 0.2000001!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 5.466667!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label39.Text = "(    /    )"
        Me.Label39.Top = 4.799999!
        Me.Label39.Width = 0.7333305!
        '
        'Label40
        '
        Me.Label40.Height = 0.2000001!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 3.600001!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label40.Text = ".    ."
        Me.Label40.Top = 4.8!
        Me.Label40.Width = 0.7999986!
        '
        'Label25
        '
        Me.Label25.Height = 0.1999998!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 0.2!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-align: center; ve" & _
            "rtical-align: middle"
        Me.Label25.Text = "生管→材料倉庫→出庫先→生管(保管)"
        Me.Label25.Top = 5!
        Me.Label25.Width = 2.8!
        '
        'Label26
        '
        Me.Label26.Height = 0.1333334!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.4!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: MS UI Gothic; font-size: 8.25pt; text-align: left; vertical-align: t" & _
            "op"
        Me.Label26.Text = "外注先御中：上記太枠欄に記入し、返却材に添付して減却願います。返却材がない場合は「0kg」として工程票の袋に入れて返却して下さい。"
        Me.Label26.Top = 5.266665!
        Me.Label26.Width = 7.133333!
        '
        'Line27
        '
        Me.Line27.Height = 0!
        Me.Line27.Left = 0.06666669!
        Me.Line27.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 5.599998!
        Me.Line27.Width = 7.46666!
        Me.Line27.X1 = 0.06666669!
        Me.Line27.X2 = 7.533327!
        Me.Line27.Y1 = 5.599998!
        Me.Line27.Y2 = 5.599998!
        '
        'Label22
        '
        Me.Label22.Height = 0.2666667!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.06666667!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center; ver" & _
            "tical-align: bottom"
        Me.Label22.Text = "主材料出庫表（処理票）"
        Me.Label22.Top = 5.799997!
        Me.Label22.Width = 7.466667!
        '
        'Label23
        '
        Me.Label23.Height = 0.2000001!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.1999999!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.Label23.Text = "指示NO"
        Me.Label23.Top = 5.799997!
        Me.Label23.Width = 0.4666668!
        '
        'TextBox9
        '
        Me.TextBox9.DataField = "INDICATE_NO1"
        Me.TextBox9.Height = 0.2!
        Me.TextBox9.Left = 0.6666667!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.TextBox9.Text = "99999"
        Me.TextBox9.Top = 5.799997!
        Me.TextBox9.Width = 0.3999999!
        '
        'lblRePrint2
        '
        Me.lblRePrint2.Height = 0.2!
        Me.lblRePrint2.HyperLink = Nothing
        Me.lblRePrint2.Left = 5.733331!
        Me.lblRePrint2.Name = "lblRePrint2"
        Me.lblRePrint2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.lblRePrint2.Text = "再発行"
        Me.lblRePrint2.Top = 5.799997!
        Me.lblRePrint2.Width = 0.4666691!
        '
        'Label29
        '
        Me.Label29.Height = 0.2!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 5.400001!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.Label29.Text = "発行日"
        Me.Label29.Top = 6.066664!
        Me.Label29.Width = 0.4666663!
        '
        'lblDate2
        '
        Me.lblDate2.Height = 0.2!
        Me.lblDate2.HyperLink = Nothing
        Me.lblDate2.Left = 5.933334!
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom"
        Me.lblDate2.Text = "yyyy/mm/dd"
        Me.lblDate2.Top = 6.066664!
        Me.lblDate2.Width = 0.6666666!
        '
        'TextBox10
        '
        Me.TextBox10.DataField = "O_CATALOG_NO"
        Me.TextBox10.Height = 0.2000001!
        Me.TextBox10.Left = 1.533333!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: left; verti" & _
            "cal-align: bottom; white-space: nowrap"
        Me.TextBox10.Text = "XXXXXXXXXXXXXXXXX"
        Me.TextBox10.Top = 6.199997!
        Me.TextBox10.Width = 1.6!
        '
        'Label31
        '
        Me.Label31.Height = 0.2!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.3333333!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: right; vert" & _
            "ical-align: bottom"
        Me.Label31.Text = "カタログ番号："
        Me.Label31.Top = 6.199997!
        Me.Label31.Width = 1.2!
        '
        'Label32
        '
        Me.Label32.Height = 0.2!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.3333333!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: right; vert" & _
            "ical-align: bottom"
        Me.Label32.Text = "材料コード："
        Me.Label32.Top = 6.53333!
        Me.Label32.Width = 1.2!
        '
        'TextBox11
        '
        Me.TextBox11.DataField = "MATL_CD"
        Me.TextBox11.Height = 0.2000001!
        Me.TextBox11.Left = 1.533334!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: left; verti" & _
            "cal-align: bottom; white-space: nowrap"
        Me.TextBox11.Text = "XXXXXXXXXXXXXXXXX"
        Me.TextBox11.Top = 6.53333!
        Me.TextBox11.Width = 1.6!
        '
        'Barcode1
        '
        Me.Barcode1.CaptionPosition = GrapeCity.ActiveReports.SectionReportModel.BarCodeCaptionPosition.Below
        Me.Barcode1.CheckSumEnabled = false
        Me.Barcode1.DataField = "REN_NO"
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.Barcode1.Height = 0.3999999!
        Me.Barcode1.Left = 1.8125!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.QuietZoneBottom = 0!
        Me.Barcode1.QuietZoneLeft = 0!
        Me.Barcode1.QuietZoneRight = 0!
        Me.Barcode1.QuietZoneTop = 0!
        Me.Barcode1.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.Barcode1.Text = "99999"
        Me.Barcode1.Top = 6.8125!
        Me.Barcode1.Width = 1.4!
        '
        'txtBarcode2
        '
        Me.txtBarcode2.CaptionPosition = GrapeCity.ActiveReports.SectionReportModel.BarCodeCaptionPosition.Below
        Me.txtBarcode2.CheckSumEnabled = false
        Me.txtBarcode2.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.txtBarcode2.Height = 0.3999999!
        Me.txtBarcode2.Left = 3.933333!
        Me.txtBarcode2.Name = "txtBarcode2"
        Me.txtBarcode2.QuietZoneBottom = 0!
        Me.txtBarcode2.QuietZoneLeft = 0!
        Me.txtBarcode2.QuietZoneRight = 0!
        Me.txtBarcode2.QuietZoneTop = 0!
        Me.txtBarcode2.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.txtBarcode2.Text = "99999999999"
        Me.txtBarcode2.Top = 6.804163!
        Me.txtBarcode2.Width = 2.466667!
        '
        'Label33
        '
        Me.Label33.Height = 0.2000001!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.3333333!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label33.Text = "連NO"
        Me.Label33.Top = 7.199993!
        Me.Label33.Width = 0.4000001!
        '
        'TextBox13
        '
        Me.TextBox13.DataField = "REN_NO"
        Me.TextBox13.Height = 0.2!
        Me.TextBox13.Left = 1!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.TextBox13.Text = "99999"
        Me.TextBox13.Top = 7.199993!
        Me.TextBox13.Width = 0.3999999!
        '
        'Line42
        '
        Me.Line42.Height = 3.666667!
        Me.Line42.Left = 0.1999999!
        Me.Line42.LineWeight = 1!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 7.06666!
        Me.Line42.Width = 0!
        Me.Line42.X1 = 0.1999999!
        Me.Line42.X2 = 0.1999999!
        Me.Line42.Y1 = 7.06666!
        Me.Line42.Y2 = 10.73333!
        '
        'Line43
        '
        Me.Line43.Height = 0!
        Me.Line43.Left = 0.1999999!
        Me.Line43.LineWeight = 1!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 7.06666!
        Me.Line43.Width = 1.333333!
        Me.Line43.X1 = 0.1999999!
        Me.Line43.X2 = 1.533333!
        Me.Line43.Y1 = 7.06666!
        Me.Line43.Y2 = 7.06666!
        '
        'Line44
        '
        Me.Line44.Height = 1.4!
        Me.Line44.Left = 0.8666667!
        Me.Line44.LineWeight = 1!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 7.06666!
        Me.Line44.Width = 0!
        Me.Line44.X1 = 0.8666667!
        Me.Line44.X2 = 0.8666667!
        Me.Line44.Y1 = 7.06666!
        Me.Line44.Y2 = 8.46666!
        '
        'Line45
        '
        Me.Line45.Height = 0.4666667!
        Me.Line45.Left = 1.533333!
        Me.Line45.LineWeight = 1!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 7.06666!
        Me.Line45.Width = 7.152557E-07!
        Me.Line45.X1 = 1.533334!
        Me.Line45.X2 = 1.533333!
        Me.Line45.Y1 = 7.06666!
        Me.Line45.Y2 = 7.533327!
        '
        'Line46
        '
        Me.Line46.Height = 0!
        Me.Line46.Left = 0.1999999!
        Me.Line46.LineWeight = 1!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 7.533327!
        Me.Line46.Width = 2.8!
        Me.Line46.X1 = 0.1999999!
        Me.Line46.X2 = 3!
        Me.Line46.Y1 = 7.533327!
        Me.Line46.Y2 = 7.533327!
        '
        'Label34
        '
        Me.Label34.Height = 0.2000001!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 0.3333333!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label34.Text = "組番"
        Me.Label34.Top = 7.66666!
        Me.Label34.Width = 0.4000001!
        '
        'Line47
        '
        Me.Line47.Height = 0!
        Me.Line47.Left = 0.1999999!
        Me.Line47.LineWeight = 1!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 7.999993!
        Me.Line47.Width = 2.8!
        Me.Line47.X1 = 0.1999999!
        Me.Line47.X2 = 3!
        Me.Line47.Y1 = 7.999993!
        Me.Line47.Y2 = 7.999993!
        '
        'TextBox14
        '
        Me.TextBox14.DataField = "C_NO"
        Me.TextBox14.Height = 0.2!
        Me.TextBox14.Left = 0.3333333!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox14.Text = "XX"
        Me.TextBox14.Top = 8.133327!
        Me.TextBox14.Width = 0.4!
        '
        'Label38
        '
        Me.Label38.Height = 0.2000001!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 0.9333333!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label38.Text = "社内NO"
        Me.Label38.Top = 7.66666!
        Me.Label38.Width = 0.9333333!
        '
        'TextBox15
        '
        Me.TextBox15.DataField = "COMPANY_NO"
        Me.TextBox15.Height = 0.2!
        Me.TextBox15.Left = 0.9333333!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox15.Text = "999999"
        Me.TextBox15.Top = 8.133327!
        Me.TextBox15.Width = 0.9333333!
        '
        'Label41
        '
        Me.Label41.Height = 0.2000001!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 2!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label41.Text = "指示NO"
        Me.Label41.Top = 7.66666!
        Me.Label41.Width = 0.9333333!
        '
        'Line48
        '
        Me.Line48.Height = 3.2!
        Me.Line48.Left = 3!
        Me.Line48.LineWeight = 1!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 7.533327!
        Me.Line48.Width = 0!
        Me.Line48.X1 = 3!
        Me.Line48.X2 = 3!
        Me.Line48.Y1 = 7.533327!
        Me.Line48.Y2 = 10.73333!
        '
        'TextBox16
        '
        Me.TextBox16.DataField = "INDICATE_NO2"
        Me.TextBox16.Height = 0.2!
        Me.TextBox16.Left = 2!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.TextBox16.Text = "99999"
        Me.TextBox16.Top = 8.133327!
        Me.TextBox16.Width = 0.9333333!
        '
        'Line49
        '
        Me.Line49.Height = 0!
        Me.Line49.Left = 0.1999999!
        Me.Line49.LineWeight = 1!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 8.46666!
        Me.Line49.Width = 2.8!
        Me.Line49.X1 = 0.1999999!
        Me.Line49.X2 = 3!
        Me.Line49.Y1 = 8.46666!
        Me.Line49.Y2 = 8.46666!
        '
        'Label42
        '
        Me.Label42.Height = 0.2000001!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 0.2666666!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label42.Text = "着 工 数"
        Me.Label42.Top = 8.533326!
        Me.Label42.Width = 1!
        '
        'Line50
        '
        Me.Line50.Height = 1.333334!
        Me.Line50.Left = 1.333333!
        Me.Line50.LineWeight = 1!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 8.46666!
        Me.Line50.Width = 0!
        Me.Line50.X1 = 1.333333!
        Me.Line50.X2 = 1.333333!
        Me.Line50.Y1 = 8.46666!
        Me.Line50.Y2 = 9.799994!
        '
        'Line51
        '
        Me.Line51.Height = 0!
        Me.Line51.Left = 0.1999999!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 8.799994!
        Me.Line51.Width = 2.8!
        Me.Line51.X1 = 0.1999999!
        Me.Line51.X2 = 3!
        Me.Line51.Y1 = 8.799994!
        Me.Line51.Y2 = 8.799994!
        '
        'Label43
        '
        Me.Label43.Height = 0.2000001!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 0.2666666!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label43.Text = "単位素材"
        Me.Label43.Top = 8.86666!
        Me.Label43.Width = 1!
        '
        'Line52
        '
        Me.Line52.Height = 0!
        Me.Line52.Left = 0.1999999!
        Me.Line52.LineWeight = 1!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 9.133327!
        Me.Line52.Width = 2.8!
        Me.Line52.X1 = 0.1999999!
        Me.Line52.X2 = 3!
        Me.Line52.Y1 = 9.133327!
        Me.Line52.Y2 = 9.133327!
        '
        'Label44
        '
        Me.Label44.Height = 0.2000001!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 0.2666666!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label44.Text = "計算使用量"
        Me.Label44.Top = 9.199993!
        Me.Label44.Width = 1!
        '
        'Line53
        '
        Me.Line53.Height = 0!
        Me.Line53.Left = 0.1999999!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 9.46666!
        Me.Line53.Width = 2.8!
        Me.Line53.X1 = 0.1999999!
        Me.Line53.X2 = 3!
        Me.Line53.Y1 = 9.46666!
        Me.Line53.Y2 = 9.46666!
        '
        'Label45
        '
        Me.Label45.Height = 0.2000001!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 0.2666666!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label45.Text = "出庫要求量"
        Me.Label45.Top = 9.533326!
        Me.Label45.Width = 1!
        '
        'Line54
        '
        Me.Line54.Height = 0!
        Me.Line54.Left = 0.1999999!
        Me.Line54.LineWeight = 1!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 9.799994!
        Me.Line54.Width = 7.26666!
        Me.Line54.X1 = 0.1999999!
        Me.Line54.X2 = 7.46666!
        Me.Line54.Y1 = 9.799994!
        Me.Line54.Y2 = 9.799994!
        '
        'TextBox17
        '
        Me.TextBox17.DataField = "STW_AMT"
        Me.TextBox17.Height = 0.2!
        Me.TextBox17.Left = 1.466667!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.TextBox17.Text = "99999"
        Me.TextBox17.Top = 8.533326!
        Me.TextBox17.Width = 1!
        '
        'txtTaniSozai2
        '
        Me.txtTaniSozai2.Height = 0.2!
        Me.txtTaniSozai2.Left = 1.466667!
        Me.txtTaniSozai2.Name = "txtTaniSozai2"
        Me.txtTaniSozai2.OutputFormat = resources.GetString("txtTaniSozai2.OutputFormat")
        Me.txtTaniSozai2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.txtTaniSozai2.Text = "99999"
        Me.txtTaniSozai2.Top = 8.86666!
        Me.txtTaniSozai2.Width = 1!
        '
        'Label46
        '
        Me.Label46.Height = 0.2000001!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 0.2666666!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label46.Text = "出庫計画"
        Me.Label46.Top = 9.86666!
        Me.Label46.Width = 0.8!
        '
        'Label47
        '
        Me.Label47.Height = 0.2000001!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 1.2!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label47.Text = "作業者"
        Me.Label47.Top = 9.866667!
        Me.Label47.Width = 0.8!
        '
        'Label48
        '
        Me.Label48.Height = 0.2000001!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 2.133334!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label48.Text = "出庫予定日"
        Me.Label48.Top = 9.866667!
        Me.Label48.Width = 0.8!
        '
        'Line55
        '
        Me.Line55.Height = 0!
        Me.Line55.Left = 0.1999999!
        Me.Line55.LineWeight = 1!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 10.13333!
        Me.Line55.Width = 7.26666!
        Me.Line55.X1 = 0.1999999!
        Me.Line55.X2 = 7.46666!
        Me.Line55.Y1 = 10.13333!
        Me.Line55.Y2 = 10.13333!
        '
        'Line56
        '
        Me.Line56.Height = 0!
        Me.Line56.Left = 0.1999999!
        Me.Line56.LineWeight = 1!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 10.73333!
        Me.Line56.Width = 7.26666!
        Me.Line56.X1 = 0.1999999!
        Me.Line56.X2 = 7.46666!
        Me.Line56.Y1 = 10.73333!
        Me.Line56.Y2 = 10.73333!
        '
        'Line57
        '
        Me.Line57.Height = 0.9333329!
        Me.Line57.Left = 1.933333!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 7.533327!
        Me.Line57.Width = 0!
        Me.Line57.X1 = 1.933333!
        Me.Line57.X2 = 1.933333!
        Me.Line57.Y1 = 7.533327!
        Me.Line57.Y2 = 8.46666!
        '
        'Line59
        '
        Me.Line59.Height = 0.9333334!
        Me.Line59.Left = 1.133333!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 9.8!
        Me.Line59.Width = 0!
        Me.Line59.X1 = 1.133333!
        Me.Line59.X2 = 1.133333!
        Me.Line59.Y1 = 9.8!
        Me.Line59.Y2 = 10.73333!
        '
        'txtZairyoKubun2a
        '
        Me.txtZairyoKubun2a.Height = 0.2!
        Me.txtZairyoKubun2a.Left = 2.6!
        Me.txtZairyoKubun2a.Name = "txtZairyoKubun2a"
        Me.txtZairyoKubun2a.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.txtZairyoKubun2a.Text = "XX"
        Me.txtZairyoKubun2a.Top = 8.86666!
        Me.txtZairyoKubun2a.Width = 0.2666667!
        '
        'txtKeisan2
        '
        Me.txtKeisan2.Height = 0.2!
        Me.txtKeisan2.Left = 1.466667!
        Me.txtKeisan2.Name = "txtKeisan2"
        Me.txtKeisan2.OutputFormat = resources.GetString("txtKeisan2.OutputFormat")
        Me.txtKeisan2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.txtKeisan2.Text = "99999"
        Me.txtKeisan2.Top = 9.199993!
        Me.txtKeisan2.Width = 1!
        '
        'txtZairyoKubun2b
        '
        Me.txtZairyoKubun2b.Height = 0.2!
        Me.txtZairyoKubun2b.Left = 2.6!
        Me.txtZairyoKubun2b.Name = "txtZairyoKubun2b"
        Me.txtZairyoKubun2b.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.txtZairyoKubun2b.Text = "XX"
        Me.txtZairyoKubun2b.Top = 9.199993!
        Me.txtZairyoKubun2b.Width = 0.2666667!
        '
        'Line60
        '
        Me.Line60.Height = 0!
        Me.Line60.Left = 3!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 7.66666!
        Me.Line60.Width = 0.5333366!
        Me.Line60.X1 = 3!
        Me.Line60.X2 = 3.533337!
        Me.Line60.Y1 = 7.66666!
        Me.Line60.Y2 = 7.66666!
        '
        'Line61
        '
        Me.Line61.Height = 0.7999997!
        Me.Line61.Left = 3.533333!
        Me.Line61.LineWeight = 3!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 7.66666!
        Me.Line61.Width = 7.152557E-07!
        Me.Line61.X1 = 3.533333!
        Me.Line61.X2 = 3.533333!
        Me.Line61.Y1 = 7.66666!
        Me.Line61.Y2 = 8.46666!
        '
        'Label49
        '
        Me.Label49.Height = 1.866672!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 3.2!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label49.Text = "出　庫　内　訳"
        Me.Label49.Top = 7.799993!
        Me.Label49.Width = 0.1333347!
        '
        'Line62
        '
        Me.Line62.Height = 2.133334!
        Me.Line62.Left = 4.466665!
        Me.Line62.LineWeight = 1!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 7.66666!
        Me.Line62.Width = 1.430511E-06!
        Me.Line62.X1 = 4.466665!
        Me.Line62.X2 = 4.466667!
        Me.Line62.Y1 = 7.66666!
        Me.Line62.Y2 = 9.799994!
        '
        'Label50
        '
        Me.Label50.Height = 0.2000001!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 3.6!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label50.Text = "材料ロットNO"
        Me.Label50.Top = 7.799993!
        Me.Label50.Width = 0.8!
        '
        'Label51
        '
        Me.Label51.Height = 0.2000001!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 3.599999!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label51.Text = "棚　　番"
        Me.Label51.Top = 8.199993!
        Me.Label51.Width = 0.8!
        '
        'Line63
        '
        Me.Line63.Height = 0!
        Me.Line63.Left = 3.533333!
        Me.Line63.LineWeight = 1!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 8.133327!
        Me.Line63.Width = 3.933333!
        Me.Line63.X1 = 3.533333!
        Me.Line63.X2 = 7.466667!
        Me.Line63.Y1 = 8.133327!
        Me.Line63.Y2 = 8.133327!
        '
        'Line64
        '
        Me.Line64.Height = 0!
        Me.Line64.Left = 3.533333!
        Me.Line64.LineWeight = 3!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 8.46666!
        Me.Line64.Width = 3.933333!
        Me.Line64.X1 = 3.533333!
        Me.Line64.X2 = 7.466667!
        Me.Line64.Y1 = 8.46666!
        Me.Line64.Y2 = 8.46666!
        '
        'Line65
        '
        Me.Line65.Height = 1.133333!
        Me.Line65.Left = 7.46666!
        Me.Line65.LineWeight = 3!
        Me.Line65.Name = "Line65"
        Me.Line65.Top = 7.333326!
        Me.Line65.Width = 6.67572E-06!
        Me.Line65.X1 = 7.466667!
        Me.Line65.X2 = 7.46666!
        Me.Line65.Y1 = 7.333326!
        Me.Line65.Y2 = 8.46666!
        '
        'Label52
        '
        Me.Label52.Height = 0.2000001!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 6.733333!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label52.Text = "出庫確認"
        Me.Label52.Top = 7.399993!
        Me.Label52.Width = 0.6666632!
        '
        'Line66
        '
        Me.Line66.Height = 0!
        Me.Line66.Left = 6.666667!
        Me.Line66.LineWeight = 3!
        Me.Line66.Name = "Line66"
        Me.Line66.Top = 7.333326!
        Me.Line66.Width = 0.7999935!
        Me.Line66.X1 = 6.666667!
        Me.Line66.X2 = 7.46666!
        Me.Line66.Y1 = 7.333326!
        Me.Line66.Y2 = 7.333326!
        '
        'Line67
        '
        Me.Line67.Height = 0.3333335!
        Me.Line67.Left = 6.666663!
        Me.Line67.LineWeight = 3!
        Me.Line67.Name = "Line67"
        Me.Line67.Top = 7.333326!
        Me.Line67.Width = 0!
        Me.Line67.X1 = 6.666663!
        Me.Line67.X2 = 6.666663!
        Me.Line67.Y1 = 7.333326!
        Me.Line67.Y2 = 7.66666!
        '
        'Shape3
        '
        Me.Shape3.Height = 0.1333333!
        Me.Shape3.Left = 3.3125!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape3.Top = 7.375!
        Me.Shape3.Width = 0.1333333!
        '
        'Label53
        '
        Me.Label53.Height = 0.15!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 3.5!
        Me.Label53.MultiLine = false
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.Label53.Text = "色識別"
        Me.Label53.Top = 7.3125!
        Me.Label53.Width = 0.438!
        '
        'Shape4
        '
        Me.Shape4.Height = 0.1333333!
        Me.Shape4.Left = 4.625!
        Me.Shape4.Name = "Shape4"
        Me.Shape4.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape4.Top = 7.375!
        Me.Shape4.Width = 0.1333333!
        '
        'Label54
        '
        Me.Label54.Height = 0.15!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 4.8125!
        Me.Label54.MultiLine = false
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.Label54.Text = "磁性"
        Me.Label54.Top = 7.3125!
        Me.Label54.Width = 0.267!
        '
        'txtColor2
        '
        Me.txtColor2.Height = 0.15!
        Me.txtColor2.HyperLink = Nothing
        Me.txtColor2.Left = 3.625!
        Me.txtColor2.MultiLine = false
        Me.txtColor2.Name = "txtColor2"
        Me.txtColor2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.txtColor2.Text = "XXXXXXXX"
        Me.txtColor2.Top = 7.5!
        Me.txtColor2.Width = 0.6000001!
        '
        'txtJisei2
        '
        Me.txtJisei2.Height = 0.15!
        Me.txtJisei2.HyperLink = Nothing
        Me.txtJisei2.Left = 4.9375!
        Me.txtJisei2.MultiLine = false
        Me.txtJisei2.Name = "txtJisei2"
        Me.txtJisei2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.txtJisei2.Text = "XXXX"
        Me.txtJisei2.Top = 7.5!
        Me.txtJisei2.Width = 0.333!
        '
        'Shape5
        '
        Me.Shape5.Height = 0.1333333!
        Me.Shape5.Left = 5.6875!
        Me.Shape5.Name = "Shape5"
        Me.Shape5.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape5.Top = 7.375!
        Me.Shape5.Width = 0.1333333!
        '
        'Label57
        '
        Me.Label57.Height = 0.15!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 5.875!
        Me.Label57.MultiLine = false
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap"
        Me.Label57.Text = "材料径"
        Me.Label57.Top = 7.3125!
        Me.Label57.Width = 0.4!
        '
        'Line68
        '
        Me.Line68.Height = 0.7999997!
        Me.Line68.Left = 6.666663!
        Me.Line68.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot
        Me.Line68.LineWeight = 1!
        Me.Line68.Name = "Line68"
        Me.Line68.Top = 7.66666!
        Me.Line68.Width = 0!
        Me.Line68.X1 = 6.666663!
        Me.Line68.X2 = 6.666663!
        Me.Line68.Y1 = 7.66666!
        Me.Line68.Y2 = 8.46666!
        '
        'linCoil2
        '
        Me.linCoil2.Height = 0!
        Me.linCoil2.Left = 3.533333!
        Me.linCoil2.LineWeight = 1!
        Me.linCoil2.Name = "linCoil2"
        Me.linCoil2.Top = 8.733327!
        Me.linCoil2.Width = 3.933333!
        Me.linCoil2.X1 = 3.533333!
        Me.linCoil2.X2 = 7.466667!
        Me.linCoil2.Y1 = 8.733327!
        Me.linCoil2.Y2 = 8.733327!
        '
        'Line70
        '
        Me.Line70.Height = 0!
        Me.Line70.Left = 3.533333!
        Me.Line70.LineWeight = 1!
        Me.Line70.Name = "Line70"
        Me.Line70.Top = 9.46666!
        Me.Line70.Width = 3.933334!
        Me.Line70.X1 = 3.533333!
        Me.Line70.X2 = 7.466667!
        Me.Line70.Y1 = 9.46666!
        Me.Line70.Y2 = 9.46666!
        '
        'Line79
        '
        Me.Line79.Height = 2.266674!
        Me.Line79.Left = 7.46666!
        Me.Line79.LineWeight = 1!
        Me.Line79.Name = "Line79"
        Me.Line79.Top = 8.46666!
        Me.Line79.Width = 6.67572E-06!
        Me.Line79.X1 = 7.46666!
        Me.Line79.X2 = 7.466667!
        Me.Line79.Y1 = 8.46666!
        Me.Line79.Y2 = 10.73333!
        '
        'TextBox22
        '
        Me.TextBox22.DataField = "LOT_NO"
        Me.TextBox22.Height = 0.1999992!
        Me.TextBox22.Left = 4.599998!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: bottom; white-space: nowrap"
        Me.TextBox22.Text = "XXXXXXXXXXXXXXXXX"
        Me.TextBox22.Top = 7.799993!
        Me.TextBox22.Width = 1.933335!
        '
        'txtTanaban2
        '
        Me.txtTanaban2.Height = 0.1999992!
        Me.txtTanaban2.Left = 4.599998!
        Me.txtTanaban2.Name = "txtTanaban2"
        Me.txtTanaban2.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: bottom; white-space: nowrap"
        Me.txtTanaban2.Text = "XXXXX(XXXXX)"
        Me.txtTanaban2.Top = 8.199993!
        Me.txtTanaban2.Width = 1.933335!
        '
        'txtCoilNo2
        '
        Me.txtCoilNo2.Height = 0.1333334!
        Me.txtCoilNo2.HyperLink = Nothing
        Me.txtCoilNo2.Left = 3.599999!
        Me.txtCoilNo2.Name = "txtCoilNo2"
        Me.txtCoilNo2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: top"
        Me.txtCoilNo2.Text = "コイルNO"
        Me.txtCoilNo2.Top = 8.533326!
        Me.txtCoilNo2.Width = 0.8!
        '
        'txtSyukkoHaraidasiHead
        '
        Me.txtSyukkoHaraidasiHead.Height = 0.1333334!
        Me.txtSyukkoHaraidasiHead.HyperLink = Nothing
        Me.txtSyukkoHaraidasiHead.Left = 3.6!
        Me.txtSyukkoHaraidasiHead.Name = "txtSyukkoHaraidasiHead"
        Me.txtSyukkoHaraidasiHead.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: top"
        Me.txtSyukkoHaraidasiHead.Text = "出 庫 量"
        Me.txtSyukkoHaraidasiHead.Top = 8.799994!
        Me.txtSyukkoHaraidasiHead.Width = 0.8!
        '
        'txtTani2
        '
        Me.txtTani2.Height = 0.1333334!
        Me.txtTani2.HyperLink = Nothing
        Me.txtTani2.Left = 6.266663!
        Me.txtTani2.Name = "txtTani2"
        Me.txtTani2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: top"
        Me.txtTani2.Text = "単位  全数払出"
        Me.txtTani2.Top = 9.26666!
        Me.txtTani2.Width = 1.133333!
        '
        'txtCoil2
        '
        Me.txtCoil2.Height = 0.1333334!
        Me.txtCoil2.HyperLink = Nothing
        Me.txtCoil2.Left = 4.6!
        Me.txtCoil2.Name = "txtCoil2"
        Me.txtCoil2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.txtCoil2.Text = "L=       X       本     L=       X       本"
        Me.txtCoil2.Top = 8.533326!
        Me.txtCoil2.Width = 2.733333!
        '
        'txtSyukkoHaraidasi
        '
        Me.txtSyukkoHaraidasi.Height = 0.1333334!
        Me.txtSyukkoHaraidasi.HyperLink = Nothing
        Me.txtSyukkoHaraidasi.Left = 4.599998!
        Me.txtSyukkoHaraidasi.Name = "txtSyukkoHaraidasi"
        Me.txtSyukkoHaraidasi.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.txtSyukkoHaraidasi.Text = "L=       X       本"
        Me.txtSyukkoHaraidasi.Top = 8.799994!
        Me.txtSyukkoHaraidasi.Width = 2.733335!
        '
        'txtHenkyakuryo
        '
        Me.txtHenkyakuryo.Height = 0.2000055!
        Me.txtHenkyakuryo.HyperLink = Nothing
        Me.txtHenkyakuryo.Left = 3.6!
        Me.txtHenkyakuryo.Name = "txtHenkyakuryo"
        Me.txtHenkyakuryo.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.txtHenkyakuryo.Text = "返 却 量"
        Me.txtHenkyakuryo.Top = 9.133327!
        Me.txtHenkyakuryo.Width = 0.7999993!
        '
        'txtSiyouHenkyaku
        '
        Me.txtSiyouHenkyaku.Height = 0.1999941!
        Me.txtSiyouHenkyaku.HyperLink = Nothing
        Me.txtSiyouHenkyaku.Left = 4.599998!
        Me.txtSiyouHenkyaku.Name = "txtSiyouHenkyaku"
        Me.txtSiyouHenkyaku.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.txtSiyouHenkyaku.Text = "L=       X       本            kg"
        Me.txtSiyouHenkyaku.Top = 9.533334!
        Me.txtSiyouHenkyaku.Width = 2.133335!
        '
        'Label74
        '
        Me.Label74.Height = 0.1999998!
        Me.Label74.HyperLink = Nothing
        Me.Label74.Left = 0.2!
        Me.Label74.Name = "Label74"
        Me.Label74.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-align: center; ve" & _
            "rtical-align: middle"
        Me.Label74.Text = "生管→材料倉庫→生管(保管)"
        Me.Label74.Top = 10.86667!
        Me.Label74.Width = 7.266667!
        '
        'Line84
        '
        Me.Line84.Height = 0!
        Me.Line84.Left = 3.533333!
        Me.Line84.LineWeight = 3!
        Me.Line84.Name = "Line84"
        Me.Line84.Top = 7.66666!
        Me.Line84.Width = 3.133334!
        Me.Line84.X1 = 3.533333!
        Me.Line84.X2 = 6.666667!
        Me.Line84.Y1 = 7.66666!
        Me.Line84.Y2 = 7.66666!
        '
        'Line85
        '
        Me.Line85.Height = 1.333334!
        Me.Line85.Left = 3.533333!
        Me.Line85.LineWeight = 1!
        Me.Line85.Name = "Line85"
        Me.Line85.Top = 8.46666!
        Me.Line85.Width = 7.152557E-07!
        Me.Line85.X1 = 3.533333!
        Me.Line85.X2 = 3.533333!
        Me.Line85.Y1 = 8.46666!
        Me.Line85.Y2 = 9.799994!
        '
        'Line78
        '
        Me.Line78.Height = 0!
        Me.Line78.Left = 6.666663!
        Me.Line78.LineWeight = 1!
        Me.Line78.Name = "Line78"
        Me.Line78.Top = 7.66666!
        Me.Line78.Width = 0.8000035!
        Me.Line78.X1 = 6.666663!
        Me.Line78.X2 = 7.466667!
        Me.Line78.Y1 = 7.66666!
        Me.Line78.Y2 = 7.66666!
        '
        'linSyukkoHaraidasi
        '
        Me.linSyukkoHaraidasi.Height = 0!
        Me.linSyukkoHaraidasi.Left = 3.533333!
        Me.linSyukkoHaraidasi.LineWeight = 1!
        Me.linSyukkoHaraidasi.Name = "linSyukkoHaraidasi"
        Me.linSyukkoHaraidasi.Top = 8.999993!
        Me.linSyukkoHaraidasi.Width = 3.933333!
        Me.linSyukkoHaraidasi.X1 = 3.533333!
        Me.linSyukkoHaraidasi.X2 = 7.466667!
        Me.linSyukkoHaraidasi.Y1 = 8.999993!
        Me.linSyukkoHaraidasi.Y2 = 8.999993!
        '
        'txtHenkyaku2
        '
        Me.txtHenkyaku2.Height = 0.1333334!
        Me.txtHenkyaku2.HyperLink = Nothing
        Me.txtHenkyaku2.Left = 4.599998!
        Me.txtHenkyaku2.Name = "txtHenkyaku2"
        Me.txtHenkyaku2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.txtHenkyaku2.Text = "L=       X       本"
        Me.txtHenkyaku2.Top = 9.06666!
        Me.txtHenkyaku2.Width = 2.133335!
        '
        'txtSiyouHenkyakuHead
        '
        Me.txtSiyouHenkyakuHead.Height = 0.2000008!
        Me.txtSiyouHenkyakuHead.HyperLink = Nothing
        Me.txtSiyouHenkyakuHead.Left = 3.6!
        Me.txtSiyouHenkyakuHead.Name = "txtSiyouHenkyakuHead"
        Me.txtSiyouHenkyakuHead.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.txtSiyouHenkyakuHead.Text = "使 用 量"
        Me.txtSiyouHenkyakuHead.Top = 9.533334!
        Me.txtSiyouHenkyakuHead.Width = 0.7999993!
        '
        'Line58
        '
        Me.Line58.Height = 0.9333334!
        Me.Line58.Left = 2.066667!
        Me.Line58.LineWeight = 1!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 9.8!
        Me.Line58.Width = 0!
        Me.Line58.X1 = 2.066667!
        Me.Line58.X2 = 2.066667!
        Me.Line58.Y1 = 9.8!
        Me.Line58.Y2 = 10.73333!
        '
        'Label30
        '
        Me.Label30.Height = 0.2000001!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 3.066667!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label30.Text = "出庫日"
        Me.Label30.Top = 9.866667!
        Me.Label30.Width = 0.8!
        '
        'Line71
        '
        Me.Line71.Height = 0.9333334!
        Me.Line71.Left = 3.933332!
        Me.Line71.LineWeight = 1!
        Me.Line71.Name = "Line71"
        Me.Line71.Top = 9.799994!
        Me.Line71.Width = 0!
        Me.Line71.X1 = 3.933332!
        Me.Line71.X2 = 3.933332!
        Me.Line71.Y1 = 9.799994!
        Me.Line71.Y2 = 10.73333!
        '
        'Label55
        '
        Me.Label55.Height = 0.2000001!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 6.599997!
        Me.Label55.Name = "Label55"
        Me.Label55.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label55.Text = "出庫入力"
        Me.Label55.Top = 9.866667!
        Me.Label55.Width = 0.8!
        '
        'Line72
        '
        Me.Line72.Height = 0.9333334!
        Me.Line72.Left = 6.533329!
        Me.Line72.LineWeight = 1!
        Me.Line72.Name = "Line72"
        Me.Line72.Top = 9.799994!
        Me.Line72.Width = 0!
        Me.Line72.X1 = 6.533329!
        Me.Line72.X2 = 6.533329!
        Me.Line72.Y1 = 9.799994!
        Me.Line72.Y2 = 10.73333!
        '
        'Label56
        '
        Me.Label56.Height = 0.2000001!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 3.999999!
        Me.Label56.Name = "Label56"
        Me.Label56.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label56.Text = "出　庫　先"
        Me.Label56.Top = 9.866667!
        Me.Label56.Width = 2.466667!
        '
        'txtSeisanKeikaku
        '
        Me.txtSeisanKeikaku.Height = 0.2!
        Me.txtSeisanKeikaku.Left = 0.3333333!
        Me.txtSeisanKeikaku.Name = "txtSeisanKeikaku"
        Me.txtSeisanKeikaku.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.txtSeisanKeikaku.Text = "999999"
        Me.txtSeisanKeikaku.Top = 10.33333!
        Me.txtSeisanKeikaku.Width = 0.6666667!
        '
        'txtYear
        '
        Me.txtYear.Height = 0.2!
        Me.txtYear.Left = 2.200001!
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.txtYear.Text = "yyyy"
        Me.txtYear.Top = 10.19999!
        Me.txtYear.Width = 0.6666667!
        '
        'txtMonthDay
        '
        Me.txtMonthDay.Height = 0.2666597!
        Me.txtMonthDay.Left = 2.200001!
        Me.txtMonthDay.Name = "txtMonthDay"
        Me.txtMonthDay.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center; ver" & _
            "tical-align: bottom; white-space: nowrap"
        Me.txtMonthDay.Text = "mm/dd"
        Me.txtMonthDay.Top = 10.4!
        Me.txtMonthDay.Width = 0.6666667!
        '
        'Label27
        '
        Me.Label27.Height = 0.1999999!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 0.3333333!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label27.Text = "175-523G"
        Me.Label27.Top = 10.86666!
        Me.Label27.Width = 0.6000001!
        '
        'Shape6
        '
        Me.Shape6.Height = 0.1999998!
        Me.Shape6.Left = 0.3333333!
        Me.Shape6.Name = "Shape6"
        Me.Shape6.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape6.Top = 10.86667!
        Me.Shape6.Width = 0.6000001!
        '
        'Line69
        '
        Me.Line69.Height = 0.8000002!
        Me.Line69.Left = 6.666667!
        Me.Line69.LineWeight = 1!
        Me.Line69.Name = "Line69"
        Me.Line69.Top = 6.2!
        Me.Line69.Width = 0!
        Me.Line69.X1 = 6.666667!
        Me.Line69.X2 = 6.666667!
        Me.Line69.Y1 = 6.2!
        Me.Line69.Y2 = 7!
        '
        'Label58
        '
        Me.Label58.Height = 0.2000003!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 6.733333!
        Me.Label58.Name = "Label58"
        Me.Label58.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label58.Text = "出庫確認"
        Me.Label58.Top = 6.2!
        Me.Label58.Width = 0.6666666!
        '
        'Line73
        '
        Me.Line73.Height = 0!
        Me.Line73.Left = 6.666667!
        Me.Line73.LineWeight = 1!
        Me.Line73.Name = "Line73"
        Me.Line73.Top = 6.2!
        Me.Line73.Width = 0.8000002!
        Me.Line73.X1 = 6.666667!
        Me.Line73.X2 = 7.466667!
        Me.Line73.Y1 = 6.2!
        Me.Line73.Y2 = 6.2!
        '
        'Line74
        '
        Me.Line74.Height = 0.7999992!
        Me.Line74.Left = 7.466667!
        Me.Line74.LineWeight = 1!
        Me.Line74.Name = "Line74"
        Me.Line74.Top = 6.200001!
        Me.Line74.Width = 0!
        Me.Line74.X1 = 7.466667!
        Me.Line74.X2 = 7.466667!
        Me.Line74.Y1 = 6.200001!
        Me.Line74.Y2 = 7!
        '
        'Line75
        '
        Me.Line75.Height = 0!
        Me.Line75.Left = 6.666667!
        Me.Line75.LineWeight = 1!
        Me.Line75.Name = "Line75"
        Me.Line75.Top = 6.399999!
        Me.Line75.Width = 0.8000002!
        Me.Line75.X1 = 6.666667!
        Me.Line75.X2 = 7.466667!
        Me.Line75.Y1 = 6.399999!
        Me.Line75.Y2 = 6.399999!
        '
        'Line76
        '
        Me.Line76.Height = 0!
        Me.Line76.Left = 6.666667!
        Me.Line76.LineWeight = 1!
        Me.Line76.Name = "Line76"
        Me.Line76.Top = 7!
        Me.Line76.Width = 0.8000002!
        Me.Line76.X1 = 6.666667!
        Me.Line76.X2 = 7.466667!
        Me.Line76.Y1 = 7!
        Me.Line76.Y2 = 7!
        '
        'Line77
        '
        Me.Line77.Height = 0!
        Me.Line77.Left = 6.666667!
        Me.Line77.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot
        Me.Line77.LineWeight = 1!
        Me.Line77.Name = "Line77"
        Me.Line77.Top = 6.733333!
        Me.Line77.Width = 0.8000002!
        Me.Line77.X1 = 6.666667!
        Me.Line77.X2 = 7.466667!
        Me.Line77.Y1 = 6.733333!
        Me.Line77.Y2 = 6.733333!
        '
        'lblZairyoKei1
        '
        Me.lblZairyoKei1.Height = 0.15!
        Me.lblZairyoKei1.HyperLink = Nothing
        Me.lblZairyoKei1.Left = 5.875!
        Me.lblZairyoKei1.MultiLine = false
        Me.lblZairyoKei1.Name = "lblZairyoKei1"
        Me.lblZairyoKei1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: top; whi" & _
            "te-space: nowrap"
        Me.lblZairyoKei1.Text = "9,999,999"
        Me.lblZairyoKei1.Top = 1.6875!
        Me.lblZairyoKei1.Width = 0.625!
        '
        'lblZairyoKei2
        '
        Me.lblZairyoKei2.Height = 0.15!
        Me.lblZairyoKei2.HyperLink = Nothing
        Me.lblZairyoKei2.Left = 5.875!
        Me.lblZairyoKei2.MultiLine = false
        Me.lblZairyoKei2.Name = "lblZairyoKei2"
        Me.lblZairyoKei2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right; vertical-align: top; whi" & _
            "te-space: nowrap"
        Me.lblZairyoKei2.Text = "9,999.999"
        Me.lblZairyoKei2.Top = 7.5!
        Me.lblZairyoKei2.Width = 0.625!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medproc;User ID=medproc;Data Source=medical;Persist S" & _
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
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRePrint1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTaniSozai1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyoKubun1a, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKeisan1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyoKubun1b, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtColor1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtJisei1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTanaban1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCoilNo1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyukkoryo1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHaraidasiryo1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTani1a, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCoil1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyukko1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHaraidasi1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHenkyaku1a, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHenkyaku1b, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTani1b, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRePrint2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTaniSozai2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyoKubun2a, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKeisan2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyoKubun2b, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtColor2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtJisei2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTanaban2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCoilNo2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyukkoHaraidasiHead, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTani2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCoil2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyukkoHaraidasi, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHenkyakuryo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSiyouHenkyaku, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHenkyaku2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSiyouHenkyakuHead, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSeisanKeikaku, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMonthDay, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZairyoKei1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblZairyoKei2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

#Region " プロパティ "

    Private _nRePrint As Boolean = False

    Public WriteOnly Property RePrint() As Boolean
        Set(ByVal nValue As Boolean)
            _nRePrint = nValue
        End Set
    End Property

#End Region

    Private Sub mdtyk0206_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        '項目の作成 
        Fields.Add("Barcode")
        Fields.Add("ZairyoKubun1")
        Fields.Add("ZairyoKubun2")
        Fields.Add("Keisan")
        Fields.Add("Color")
        Fields.Add("Jisei")
        Fields.Add("Tanaban")
        Fields.Add("Coil")
        Fields.Add("Syukko")
        Fields.Add("Haraidasi")
        Fields.Add("Tani1")
        Fields.Add("Tani2")
        Fields.Add("Henkyaku1a")
        Fields.Add("Henkyaku1b")
        Fields.Add("SHHead")
        Fields.Add("SyukkoHaraidasi")
        Fields.Add("Henkyaku2")
        Fields.Add("SiyouHenkyakuHead")
        Fields.Add("SiyouHenkyaku")
        Fields.Add("SeisanKeikaku")
        Fields.Add("Year")
        Fields.Add("MonthDay")
        '項目とコントロールの関連付け 
        txtBarcode1.DataField = "Barcode"
        txtBarcode2.DataField = "Barcode"
        txtZairyoKubun1a.DataField = "ZairyoKubun1"
        txtZairyoKubun1b.DataField = "ZairyoKubun2"
        txtZairyoKubun2a.DataField = "ZairyoKubun1"
        txtZairyoKubun2b.DataField = "ZairyoKubun2"
        txtKeisan1.DataField = "Keisan"
        txtKeisan2.DataField = "Keisan"
        txtColor1.DataField = "Color"
        txtColor2.DataField = "Color"
        txtJisei1.DataField = "Jisei"
        txtJisei2.DataField = "Jisei"
        txtTanaban1.DataField = "Tanaban"
        txtTanaban2.DataField = "Tanaban"
        txtCoil1.DataField = "Coil"
        txtCoil2.DataField = "Coil"
        txtSyukko1.DataField = "Syukko"
        txtHaraidasi1.DataField = "Haraidasi"
        txtTani1a.DataField = "Tani1"
        txtTani1b.DataField = "Tani2"
        txtTani2.DataField = "Tani1"
        txtHenkyaku1a.DataField = "Henkyaku1a"
        txtHenkyaku1b.DataField = "Henkyaku1b"
        txtSyukkoHaraidasiHead.DataField = "SHHead"
        txtSyukkoHaraidasi.DataField = "SyukkoHaraidasi"
        txtHenkyaku2.DataField = "Henkyaku2"
        txtSiyouHenkyakuHead.DataField = "SiyouHenkyakuHead"
        txtSiyouHenkyaku.DataField = "SiyouHenkyaku"
        txtSeisanKeikaku.DataField = "SeisanKeikaku"
        txtYear.DataField = "Year"
        txtMonthDay.DataField = "MonthDay"

        '**** 2010/06/16 材料径追加 ST ****
        Fields.Add("材料径")
        Me.lblZairyoKei1.DataField = "材料径"
        Me.lblZairyoKei2.DataField = "材料径"
        '**** 2010/06/16 材料径追加 ED ****

        '###### 2010/11/09 単位素材表示値修正 ######
        Fields.Add("TaniSozai")
        txtTaniSozai1.DataField = "TaniSozai"
        txtTaniSozai2.DataField = "TaniSozai"
        '###### 2010/11/09 単位素材表示値修正 ######

    End Sub

    Private Sub mdtyk0206_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        Dim sCode As String = GetString(Fields("MATL_CD").Value)
        Dim sLotNo As String = (GetString(Fields("LOT_NO").Value) + "".PadRight(6, " ")).Substring(0, 6)
        Dim sKumi As String = GetString(Fields("C_NO").Value)
        'バーコード 
        Fields("Barcode").Value = GetString(Fields("COMPANY_NO").Value) + GetString(Fields("INDICATE_NO2").Value)
        '材料単位 
        Select Case GetString(Fields("MATL_KB").Value)
            Case "M"
                Fields("ZairyoKubun1").Value = "mm"
                Fields("ZairyoKubun2").Value = "m"
            Case "F"
                Fields("ZairyoKubun1").Value = "ft"
                Fields("ZairyoKubun2").Value = "ft"
            Case "ｺ"
                Fields("ZairyoKubun1").Value = "EA"
                Fields("ZairyoKubun2").Value = "EA"
            Case ""
                Fields("ZairyoKubun1").Value = "g"
                Fields("ZairyoKubun2").Value = "kg"
            Case Else
                Fields("ZairyoKubun1").Value = ""
                Fields("ZairyoKubun2").Value = ""
        End Select
        '計算使用量
        '###### 2010/10/05 計算式修正 ######
        'If GetString(Fields("MATL_KB").Value) = "M" Or GetString(Fields("MATL_KB").Value) = "" Then 
        '    Fields("Keisan").Value = Math.Round((GetInt32(Fields("STW_AMT").Value) * GetDouble(Fields("UNIT_MATL_WAT").Value)) / 1000 + 0.04, 1) 
        'Else 
        '    Fields("Keisan").Value = Math.Round((GetInt32(Fields("STW_AMT").Value) * GetDouble(Fields("UNIT_MATL_WAT").Value)) + 0.04, 1) 
        'End If
        Select Case GetString(Fields("MATL_KB").Value).Trim
            Case "M"
                Fields("Keisan").Value = Math.Round((GetInt32(Fields("STW_AMT").Value) * GetDouble(Fields("MATL_WAT").Value)) / 1000 + 0.0049999999, 2, MidpointRounding.AwayFromZero)
                Fields("TaniSozai").Value = GetDouble(Fields("MATL_WAT").Value)
            Case ""
                Fields("Keisan").Value = Math.Round((GetInt32(Fields("STW_AMT").Value) * GetDouble(Fields("UNIT_MATL_WAT").Value)) / 1000 + 0.0049999999, 2, MidpointRounding.AwayFromZero)
                Fields("TaniSozai").Value = GetDouble(Fields("UNIT_MATL_WAT").Value)
            Case Else
                Fields("Keisan").Value = Math.Round((GetInt32(Fields("STW_AMT").Value) * GetDouble(Fields("UNIT_MATL_WAT").Value)), 2)
                Fields("TaniSozai").Value = GetDouble(Fields("UNIT_MATL_WAT").Value)
        End Select
        '###### 2010/10/05 計算式修正 ######
        '色識別 
        If (sCode.Substring(0, 2) >= 20 And sCode.Substring(0, 2) <= "39") And _
           Not GetString(Fields("色識別").Value).Equals("") And Not sLotNo.Substring(0, 1).Equals("C") Then
            Fields("Color").Value = GetString(Fields("色識別").Value)
        Else
            Fields("Color").Value = "なし"
        End If
        '磁性 
        Select Case GetString(Fields("MAGNETISM").Value)
            Case "A"
                Fields("Jisei").Value = "有り"
            Case "B"
                Fields("Jisei").Value = "なし"
            Case Else
                Fields("Jisei").Value = ""
        End Select
        '棚番 
        If GetString(Fields("S_SHELF_NO").Value).Equals("") Then
            Fields("Tanaban").Value = GetString(Fields("SHELF_NO").Value)
        Else
            Fields("Tanaban").Value = GetString(Fields("SHELF_NO").Value) + "(" + GetString(Fields("S_SHELF_NO").Value) + ")"
        End If
        '出庫内訳 
        If sCode.Substring(0, 1).Equals("1") Then
            'コイル 
            txtCoilNo1.Visible = True
            linCoil1.Visible = True
            Fields("Coil").Value = ""
            '出庫量 
            txtSyukkoryo1.Visible = False
            Fields("Syukko").Value = ""
            '払出量 
            txtHaraidasiryo1.Visible = True
            txtHaraidasi1.Alignment = TextAlignment.Right
            Fields("Haraidasi").Value = "kg"
            '単位 
            Fields("Tani1").Value = ""
        Else
            'コイル 
            txtCoilNo1.Visible = False
            linCoil1.Visible = False
            Fields("Coil").Value = "L=       X       本     L=       X       本"
            '出庫量 
            txtSyukkoryo1.Visible = True
            Fields("Syukko").Value = "L=       X       本     L=       X       本"
            '払出量 
            txtHaraidasiryo1.Visible = False
            txtHaraidasi1.Alignment = TextAlignment.Left
            Fields("Haraidasi").Value = "L=       X       本"
            '単位 
            Fields("Tani1").Value = GetString(Fields("UNIT").Value) + "  全数払出"
        End If
        '返却量 
        If sCode.Substring(0, 1).Equals("1") Then
            txtHenkyaku1a.Alignment = TextAlignment.Right
            Fields("Henkyaku1a").Value = "kg"
            Fields("Henkyaku1b").Value = ""
        Else
            txtHenkyaku1a.Alignment = TextAlignment.Left
            Fields("Henkyaku1a").Value = "L=       X       本"
            Fields("Henkyaku1b").Value = "L=       X       本          " + GetString(Fields("UNIT").Value)
        End If
        '単位 
        Fields("Tani2").Value = GetString(Fields("UNIT").Value)
        '処理票 - 出庫内訳 
        If sCode.Substring(0, 1).Equals("1") Then
            'コイル 
            txtCoilNo2.Visible = True
            linCoil2.Visible = True
            '出庫量 or 払出量 
            Fields("SHHead").Value = "払 出 量"
            txtSyukkoHaraidasi.Alignment = TextAlignment.Right
            Fields("SyukkoHaraidasi").Value = "kg"
            linSyukkoHaraidasi.Visible = True
            '返却量 
            txtHenkyakuryo.Visible = True
            txtHenkyakuryo.Alignment = TextAlignment.Right
            Fields("Henkyaku2").Value = "kg"
            '単位 
            txtTani2.Visible = False
            '使用量 or 返却量 
            Fields("SiyouHenkyakuHead").Value = "使 用 量"
            Fields("SiyouHenkyaku").Value = "                               kg"
        Else
            'コイル 
            txtCoilNo2.Visible = False
            linCoil2.Visible = False
            '出庫量 or 払出量 
            Fields("SHHead").Value = "出 庫 量"
            txtSyukkoHaraidasi.Alignment = TextAlignment.Left
            Fields("SyukkoHaraidasi").Value = "L=       X       本     L=       X       本"
            linSyukkoHaraidasi.Visible = False
            '返却量 
            txtHenkyakuryo.Visible = False
            txtHenkyakuryo.Alignment = TextAlignment.Left
            Fields("Henkyaku2").Value = "L=       X       本"
            '単位 
            txtTani2.Visible = True
            '使用量 or 返却量 
            Fields("SiyouHenkyakuHead").Value = "返 却 量"
            Fields("SiyouHenkyaku").Value = "L=       X       本            kg"
        End If
        '出庫計画 
        If Not sLotNo.Equals("") And Not sKumi.Substring(0, 1).Equals("W") And sKumi <> "Z9" Then
            Fields("SeisanKeikaku").Value = "長崎"
        Else
            Fields("SeisanKeikaku").Value = GetString(Fields("着工者").Value)
        End If
        '出庫予定日 
        If Not GetString(Fields("EXPEND_PLAN_DT").Value).Equals("") Then
            Dim sDate As String = GetString(Fields("EXPEND_PLAN_DT").Value)
            Fields("Year").Value = sDate.Substring(0, 4)
            Fields("MonthDay").Value = sDate.Substring(4, 2) + "/" + sDate.Substring(6, 2)
        End If
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        lblDate1.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblDate2.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblRePrint1.Visible = _nRePrint
        lblRePrint2.Visible = _nRePrint

        '**** 2010/06/16 材料径追加 ST ****
        If Me.Fields("材料径").Value = 0 Then
            Me.lblZairyoKei1.Text = ""
            Me.lblZairyoKei2.Text = ""
        Else
            'Me.lblZairyoKei1.Text = Format(Fields("材料径").Value, "#,##0.000")
            'Me.lblZairyoKei2.Text = Format(Fields("材料径").Value, "#,##0.000")
            Me.lblZairyoKei1.Text = Fields("材料径").Value.ToString("#,##0.000")
            Me.lblZairyoKei2.Text = Fields("材料径").Value.ToString("#,##0.000")
        End If
        '**** 2010/06/16 材料径追加 ED ****
    End Sub

#Region " その他 "

    Private Function GetString(ByVal oValue As Object) As String
        If oValue Is Nothing Then Return ""
        If IsDBNull(oValue) Then Return ""
        Return CType(oValue, String).Trim()
    End Function

    Private Function GetInt32(ByVal oValue As Object) As Int32
        If oValue Is Nothing Then Return 0
        If IsDBNull(oValue) Then Return 0
        Return CType(oValue, Int32)
    End Function

    Private Function GetDouble(ByVal oValue As Object) As Double
        If oValue Is Nothing Then Return 0
        If IsDBNull(oValue) Then Return 0
        Return CType(oValue, Double)
    End Function

    Private Function GetDate(ByVal oValue As Object) As String
        If oValue Is Nothing Then Return ""
        If IsDBNull(oValue) Then Return ""
        Return CType(oValue, String).Trim()
    End Function

#End Region


    Private Sub mdtyk0206_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub
End Class 
