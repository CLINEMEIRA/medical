Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports System.Data.OracleClient
Imports Microsoft.VisualBasic

Public Class mdtyk040
    Inherits GrapeCity.ActiveReports.SectionReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents GroupHeader2 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter2 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private Shape As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtBikou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSyuruiName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtBarcode1 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtIppanName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSyouninBangou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label43 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtHanbaiName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblRePrint As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label47 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtCatalog As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label48 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtSeihinBangou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox24 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox22 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox25 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox26 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox27 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox28 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox29 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox12 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox13 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox14 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtZairyouLotNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtNouki As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox19 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox20 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox21 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox23 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label29 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label35 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label36 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label38 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label39 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label41 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label42 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label44 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label45 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label40 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label51 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private TextBox30 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtKihonKoujun As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtHojoKoujun As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtBarcode2 As GrapeCity.ActiveReports.SectionReportModel.Barcode
    Private Line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox33 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox34 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox35 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox36 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox37 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label46 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtyk040))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.GroupHeader2 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter2 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Shape = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtBikou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSyuruiName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtBarcode1 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtIppanName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSyouninBangou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label43 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtHanbaiName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRePrint = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label47 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCatalog = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label48 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSeihinBangou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox24 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox22 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox25 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox26 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox27 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox28 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox29 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtZairyouLotNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtNouki = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox19 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox20 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox21 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox23 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label29 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label35 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label36 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label38 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label39 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label41 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label42 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label44 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label45 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label40 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label51 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox30 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtKihonKoujun = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHojoKoujun = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBarcode2 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
        Me.Line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox33 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox34 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox35 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox36 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox37 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label46 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBikou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyuruiName, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtIppanName, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyouninBangou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHanbaiName, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRePrint, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSeihinBangou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyouLotNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNouki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
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
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKihonKoujun, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHojoKoujun, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox30, Me.Line33, Me.Line34, Me.txtKihonKoujun, Me.txtHojoKoujun, Me.txtBarcode2, Me.Line35, Me.Line36, Me.Line37, Me.TextBox33, Me.Line39, Me.TextBox34, Me.TextBox35, Me.Line45, Me.Line46, Me.Line47, Me.TextBox36, Me.Line48, Me.Line38, Me.TextBox37, Me.Line58, Me.Line59, Me.Line61, Me.Line62})
        Me.Detail.Height = 0.5326389!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape, Me.Label1, Me.TextBox7, Me.Label, Me.TextBox3, Me.TextBox4, Me.Label2, Me.txtBikou, Me.txtSyuruiName, Me.Label12, Me.Label11, Me.txtBarcode1, Me.Label3, Me.Label10, Me.Label9, Me.txtIppanName, Me.Label8, Me.Label7, Me.txtSyouninBangou, Me.Label4, Me.Label6, Me.Label43, Me.txtHanbaiName, Me.lblRePrint, Me.lblPage, Me.Label47, Me.lblDate, Me.Line, Me.Line1, Me.Line2, Me.txtCatalog, Me.Line5, Me.Label48, Me.Line6, Me.Line7, Me.txtSeihinBangou, Me.Line8, Me.Line9, Me.TextBox5, Me.TextBox6, Me.Line10, Me.TextBox8, Me.Line11, Me.Line3, Me.Line4, Me.Line60, Me.Line71, Me.Line72, Me.Line64, Me.Line73, Me.Line74})
        Me.PageHeader.Height = 1.866667!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox24, Me.TextBox22, Me.TextBox9, Me.Label25, Me.Label5, Me.Label24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.Line12, Me.Line14, Me.Label13, Me.TextBox10, Me.Line15, Me.Label14, Me.TextBox11, Me.Line17, Me.Label17, Me.TextBox12, Me.Label18, Me.TextBox13, Me.Line20, Me.Label19, Me.TextBox14, Me.Line21, Me.Label20, Me.txtZairyouLotNo, Me.Label21, Me.txtNouki, Me.TextBox19, Me.Label22, Me.TextBox20, Me.TextBox21, Me.Line24, Me.TextBox23, Me.Line26, Me.Label23, Me.Label26, Me.Line27, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Line19, Me.Line13, Me.Line22, Me.Line16, Me.Line25, Me.Line23, Me.Line18})
        Me.GroupHeader1.Height = 1.2!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.Visible = false
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line32, Me.Line40, Me.Line41, Me.Label33, Me.Line42, Me.Line43, Me.Line44, Me.Label34, Me.Label35, Me.Label36, Me.Line49, Me.Line50, Me.Line51, Me.Label37, Me.Label38, Me.Label39, Me.Line52, Me.Line53, Me.Label41, Me.Line54, Me.Label42, Me.Label44, Me.Line56, Me.Label45, Me.Line57, Me.Label40, Me.Label51})
        Me.GroupHeader2.DataField = "CATALOG_NO"
        Me.GroupHeader2.Height = 0.3326389!
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label46, Me.Line63, Me.Line65, Me.Line66, Me.Line67, Me.Line69, Me.TextBox, Me.TextBox1, Me.TextBox2})
        Me.GroupFooter2.Height = 0.2076389!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'Shape
        '
        Me.Shape.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Shape.Height = 0.4000001!
        Me.Shape.Left = 0.2!
        Me.Shape.Name = "Shape"
        Me.Shape.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape.Top = 0.263!
        Me.Shape.Width = 0.9333333!
        '
        'Label1
        '
        Me.Label1.Height = 0.4!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.2666667!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: Black; color: White; font-family: ＭＳ ゴシック; font-size: 11.25pt; " & _
            "font-weight: bold; text-align: center; vertical-align: middle"
        Me.Label1.Text = "製品標準書工程票"
        Me.Label1.Top = 0.2666667!
        Me.Label1.Width = 0.8666667!
        '
        'TextBox7
        '
        Me.TextBox7.DataField = "INDICATE_NO"
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 3.307625!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ ゴシック; font-size: 10.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: bottom; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox7.Text = "99999"
        Me.TextBox7.Top = 1.662833!
        Me.TextBox7.Width = 0.883!
        '
        'Label
        '
        Me.Label.Height = 0.2000001!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 4.731625!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label.Text = "着工数"
        Me.Label.Top = 1.462833!
        Me.Label.Width = 0.3999999!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "STW_AMT"
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 4.755376!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox3.Text = "999"
        Me.TextBox3.Top = 1.662833!
        Me.TextBox3.Width = 0.3999999!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "COMP_NEED_AMT"
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 4.237125!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox4.Text = "999"
        Me.TextBox4.Top = 1.662833!
        Me.TextBox4.Width = 0.3999999!
        '
        'Label2
        '
        Me.Label2.Height = 0.2000001!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.223626!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label2.Text = "必要数"
        Me.Label2.Top = 1.462833!
        Me.Label2.Width = 0.3999999!
        '
        'txtBikou
        '
        Me.txtBikou.Height = 0.3333334!
        Me.txtBikou.Left = 6.085625!
        Me.txtBikou.Name = "txtBikou"
        Me.txtBikou.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle; w" & _
            "hite-space: inherit"
        Me.txtBikou.Text = "「試作品」「OEM」「滅菌品」"
        Me.txtBikou.Top = 0.7288333!
        Me.txtBikou.Width = 1.4175!
        '
        'txtSyuruiName
        '
        Me.txtSyuruiName.Height = 0.2!
        Me.txtSyuruiName.Left = 0.343125!
        Me.txtSyuruiName.MultiLine = false
        Me.txtSyuruiName.Name = "txtSyuruiName"
        Me.txtSyuruiName.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom; white-space: nowrap" & _
            ""
        Me.txtSyuruiName.Text = "１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４"
        Me.txtSyuruiName.Top = 0.8628333!
        Me.txtSyuruiName.Width = 5.541999!
        '
        'Label12
        '
        Me.Label12.Height = 0.2000001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 5.885125!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label12.Text = "備考"
        Me.Label12.Top = 0.6628333!
        Me.Label12.Width = 0.2666669!
        '
        'Label11
        '
        Me.Label11.Height = 0.2000001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.628125!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label11.Text = "組番"
        Me.Label11.Top = 0.2628333!
        Me.Label11.Width = 0.2666669!
        '
        'txtBarcode1
        '
        Me.txtBarcode1.CaptionPosition = GrapeCity.ActiveReports.SectionReportModel.BarCodeCaptionPosition.Below
        Me.txtBarcode1.CheckSumEnabled = false
        Me.txtBarcode1.Font = New System.Drawing.Font("Courier New", 6!)
        Me.txtBarcode1.Height = 0.3333334!
        Me.txtBarcode1.Left = 5.411375!
        Me.txtBarcode1.Name = "txtBarcode1"
        Me.txtBarcode1.QuietZoneBottom = 0!
        Me.txtBarcode1.QuietZoneLeft = 0!
        Me.txtBarcode1.QuietZoneRight = 0!
        Me.txtBarcode1.QuietZoneTop = 0!
        Me.txtBarcode1.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.txtBarcode1.Text = "*12345612345*"
        Me.txtBarcode1.Top = 1.528833!
        Me.txtBarcode1.Width = 1.933333!
        '
        'Label3
        '
        Me.Label3.Height = 0.2000001!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.243125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label3.Text = "種類名"
        Me.Label3.Top = 0.6628333!
        Me.Label3.Width = 0.4666668!
        '
        'Label10
        '
        Me.Label10.Height = 0.2000001!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 3.347625!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label10.Text = "製造ロットNO"
        Me.Label10.Top = 1.462833!
        Me.Label10.Width = 0.7333333!
        '
        'Label9
        '
        Me.Label9.Height = 0.2000001!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 2.643125!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label9.Text = "社内NO"
        Me.Label9.Top = 1.462833!
        Me.Label9.Width = 0.4666668!
        '
        'txtIppanName
        '
        Me.txtIppanName.Height = 0.2!
        Me.txtIppanName.Left = 3.147625!
        Me.txtIppanName.MultiLine = false
        Me.txtIppanName.Name = "txtIppanName"
        Me.txtIppanName.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom; white-space: nowrap" & _
            ""
        Me.txtIppanName.Text = "１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０"
        Me.txtIppanName.Top = 1.262833!
        Me.txtIppanName.Width = 3.83!
        '
        'Label8
        '
        Me.Label8.Height = 0.2000001!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 1.376125!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label8.Text = "図面管理番号"
        Me.Label8.Top = 1.462833!
        Me.Label8.Width = 0.7333333!
        '
        'Label7
        '
        Me.Label7.Height = 0.2000001!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.243125!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label7.Text = "製品標準書番号"
        Me.Label7.Top = 1.462833!
        Me.Label7.Width = 0.8666667!
        '
        'txtSyouninBangou
        '
        Me.txtSyouninBangou.Height = 0.2!
        Me.txtSyouninBangou.Left = 0.343125!
        Me.txtSyouninBangou.MultiLine = false
        Me.txtSyouninBangou.Name = "txtSyouninBangou"
        Me.txtSyouninBangou.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom; white-space: nowrap" & _
            ""
        Me.txtSyouninBangou.Text = "１２３４５６７８９０１２３４５６７８９０"
        Me.txtSyouninBangou.Top = 1.262833!
        Me.txtSyouninBangou.Width = 2.667!
        '
        'Label4
        '
        Me.Label4.Height = 0.2000001!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.243125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label4.Text = "承認番号"
        Me.Label4.Top = 1.062833!
        Me.Label4.Width = 0.5333334!
        '
        'Label6
        '
        Me.Label6.Height = 0.2000001!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.168125!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label6.Text = "カタログ番号"
        Me.Label6.Top = 0.2628333!
        Me.Label6.Width = 0.8!
        '
        'Label43
        '
        Me.Label43.Height = 0.2000001!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 3.047625!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label43.Text = "販売名"
        Me.Label43.Top = 0.2628333!
        Me.Label43.Width = 0.4666668!
        '
        'txtHanbaiName
        '
        Me.txtHanbaiName.Height = 0.2!
        Me.txtHanbaiName.Left = 3.147625!
        Me.txtHanbaiName.MultiLine = false
        Me.txtHanbaiName.Name = "txtHanbaiName"
        Me.txtHanbaiName.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom; white-space: nowrap" & _
            ""
        Me.txtHanbaiName.Text = "１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０"
        Me.txtHanbaiName.Top = 0.4628333!
        Me.txtHanbaiName.Width = 3.8295!
        '
        'lblRePrint
        '
        Me.lblRePrint.Height = 0.2!
        Me.lblRePrint.HyperLink = Nothing
        Me.lblRePrint.Left = 0.203125!
        Me.lblRePrint.Name = "lblRePrint"
        Me.lblRePrint.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.lblRePrint.Text = "【 再 発 行 】"
        Me.lblRePrint.Top = 0.0625!
        Me.lblRePrint.Width = 1!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 7.069792!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.lblPage.Text = "Page.#"
        Me.lblPage.Top = 0.0625!
        Me.lblPage.Width = 0.4666668!
        '
        'Label47
        '
        Me.Label47.Height = 0.2!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 5.669792!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.Label47.Text = "発行日："
        Me.Label47.Top = 0.0625!
        Me.Label47.Width = 0.5333352!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.203125!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: bottom"
        Me.lblDate.Text = "yyyy/mm/dd"
        Me.lblDate.Top = 0.06250001!
        Me.lblDate.Width = 0.6666698!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.203125!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.2625!
        Me.Line.Width = 7.333333!
        Me.Line.X1 = 0.203125!
        Me.Line.X2 = 7.536458!
        Me.Line.Y1 = 0.2625!
        Me.Line.Y2 = 0.2625!
        '
        'Line1
        '
        Me.Line1.Height = 1.6!
        Me.Line1.Left = 0.2!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.263!
        Me.Line1.Width = 0!
        Me.Line1.X1 = 0.2!
        Me.Line1.X2 = 0.2!
        Me.Line1.Y1 = 0.263!
        Me.Line1.Y2 = 1.863!
        '
        'Line2
        '
        Me.Line2.Height = 0.3999999!
        Me.Line2.Left = 1.128125!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.2628333!
        Me.Line2.Width = 0!
        Me.Line2.X1 = 1.128125!
        Me.Line2.X2 = 1.128125!
        Me.Line2.Y1 = 0.2628333!
        Me.Line2.Y2 = 0.6628333!
        '
        'txtCatalog
        '
        Me.txtCatalog.DataField = "O_CATALOG_NO"
        Me.txtCatalog.Height = 0.2!
        Me.txtCatalog.Left = 1.253125!
        Me.txtCatalog.Name = "txtCatalog"
        Me.txtCatalog.Style = "font-family: ＭＳ ゴシック; font-size: 10.25pt; font-weight: bold; vertical-align: bott" & _
            "om; ddo-char-set: 1"
        Me.txtCatalog.Text = "XXXX-XXX-XXX"
        Me.txtCatalog.Top = 0.4628333!
        Me.txtCatalog.Width = 1.170833!
        '
        'Line5
        '
        Me.Line5.Height = 0.4!
        Me.Line5.Left = 3.007625!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.2628333!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 3.007625!
        Me.Line5.X2 = 3.007625!
        Me.Line5.Y1 = 0.2628333!
        Me.Line5.Y2 = 0.6628333!
        '
        'Label48
        '
        Me.Label48.Height = 0.2000001!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 3.047625!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label48.Text = "一般的名称"
        Me.Label48.Top = 1.062833!
        Me.Label48.Width = 0.7708333!
        '
        'Line6
        '
        Me.Line6.Height = 0!
        Me.Line6.Left = 0.203125!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.0625!
        Me.Line6.Width = 7.333333!
        Me.Line6.X1 = 0.203125!
        Me.Line6.X2 = 7.536458!
        Me.Line6.Y1 = 1.0625!
        Me.Line6.Y2 = 1.0625!
        '
        'Line7
        '
        Me.Line7.Height = 1.6!
        Me.Line7.Left = 7.531!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.263!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 7.531!
        Me.Line7.X2 = 7.531!
        Me.Line7.Y1 = 0.263!
        Me.Line7.Y2 = 1.863!
        '
        'txtSeihinBangou
        '
        Me.txtSeihinBangou.Height = 0.2!
        Me.txtSeihinBangou.Left = 0.343125!
        Me.txtSeihinBangou.Name = "txtSeihinBangou"
        Me.txtSeihinBangou.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: left; vertical-align: bottom;" & _
            " white-space: nowrap; ddo-char-set: 1"
        Me.txtSeihinBangou.Text = "99-9999"
        Me.txtSeihinBangou.Top = 1.662833!
        Me.txtSeihinBangou.Width = 0.9333333!
        '
        'Line8
        '
        Me.Line8.Height = 0.4!
        Me.Line8.Left = 1.336125!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.462833!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 1.336125!
        Me.Line8.X2 = 1.336125!
        Me.Line8.Y1 = 1.462833!
        Me.Line8.Y2 = 1.862833!
        '
        'Line9
        '
        Me.Line9.Height = 0!
        Me.Line9.Left = 0.203125!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.4625!
        Me.Line9.Width = 7.333333!
        Me.Line9.X1 = 0.203125!
        Me.Line9.X2 = 7.536458!
        Me.Line9.Y1 = 1.4625!
        Me.Line9.Y2 = 1.4625!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "WORK_STD_NO"
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 1.476125!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: left; vertical-align: bottom;" & _
            " white-space: nowrap; ddo-char-set: 1"
        Me.TextBox5.Text = "9999-9999-99-99"
        Me.TextBox5.Top = 1.662833!
        Me.TextBox5.Width = 1.0895!
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "COMPANY_NO"
        Me.TextBox6.Height = 0.2!
        Me.TextBox6.Left = 2.603125!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ ゴシック; font-size: 10.25pt; font-weight: bold; text-align: center; " & _
            "vertical-align: bottom; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox6.Text = "999999"
        Me.TextBox6.Top = 1.662833!
        Me.TextBox6.Width = 0.7125!
        '
        'Line10
        '
        Me.Line10.Height = 0.4!
        Me.Line10.Left = 3.307625!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 1.462833!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 3.307625!
        Me.Line10.X2 = 3.307625!
        Me.Line10.Y1 = 1.462833!
        Me.Line10.Y2 = 1.862833!
        '
        'TextBox8
        '
        Me.TextBox8.DataField = "C_NO"
        Me.TextBox8.Height = 0.2!
        Me.TextBox8.Left = 2.743125!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: left; vertical-align: bottom;" & _
            " white-space: nowrap; ddo-char-set: 1"
        Me.TextBox8.Text = "XX"
        Me.TextBox8.Top = 0.4628333!
        Me.TextBox8.Width = 0.2000003!
        '
        'Line11
        '
        Me.Line11.Height = 0.4!
        Me.Line11.Left = 5.845126!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.6628333!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 5.845126!
        Me.Line11.X2 = 5.845126!
        Me.Line11.Y1 = 0.6628333!
        Me.Line11.Y2 = 1.062833!
        '
        'Line3
        '
        Me.Line3.Height = 0!
        Me.Line3.Left = 0.203125!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.6625001!
        Me.Line3.Width = 7.333333!
        Me.Line3.X1 = 0.203125!
        Me.Line3.X2 = 7.536458!
        Me.Line3.Y1 = 0.6625001!
        Me.Line3.Y2 = 0.6625001!
        '
        'Line4
        '
        Me.Line4.Height = 0.4000001!
        Me.Line4.Left = 2.603125!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.2625!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 2.603125!
        Me.Line4.X2 = 2.603125!
        Me.Line4.Y1 = 0.2625!
        Me.Line4.Y2 = 0.6625001!
        '
        'Line60
        '
        Me.Line60.Height = 0!
        Me.Line60.Left = 0.203125!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 1.862833!
        Me.Line60.Width = 7.333333!
        Me.Line60.X1 = 0.203125!
        Me.Line60.X2 = 7.536458!
        Me.Line60.Y1 = 1.862833!
        Me.Line60.Y2 = 1.862833!
        '
        'Line71
        '
        Me.Line71.Height = 0.4!
        Me.Line71.Left = 2.603125!
        Me.Line71.LineWeight = 1!
        Me.Line71.Name = "Line71"
        Me.Line71.Top = 1.462833!
        Me.Line71.Width = 0!
        Me.Line71.X1 = 2.603125!
        Me.Line71.X2 = 2.603125!
        Me.Line71.Y1 = 1.462833!
        Me.Line71.Y2 = 1.862833!
        '
        'Line72
        '
        Me.Line72.Height = 0.4!
        Me.Line72.Left = 4.183126!
        Me.Line72.LineWeight = 1!
        Me.Line72.Name = "Line72"
        Me.Line72.Top = 1.462833!
        Me.Line72.Width = 0!
        Me.Line72.X1 = 4.183126!
        Me.Line72.X2 = 4.183126!
        Me.Line72.Y1 = 1.462833!
        Me.Line72.Y2 = 1.862833!
        '
        'Line64
        '
        Me.Line64.Height = 0.4!
        Me.Line64.Left = 4.691126!
        Me.Line64.LineWeight = 1!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 1.462833!
        Me.Line64.Width = 0!
        Me.Line64.X1 = 4.691126!
        Me.Line64.X2 = 4.691126!
        Me.Line64.Y1 = 1.462833!
        Me.Line64.Y2 = 1.862833!
        '
        'Line73
        '
        Me.Line73.Height = 0.4!
        Me.Line73.Left = 5.219625!
        Me.Line73.LineWeight = 1!
        Me.Line73.Name = "Line73"
        Me.Line73.Top = 1.462833!
        Me.Line73.Width = 0!
        Me.Line73.X1 = 5.219625!
        Me.Line73.X2 = 5.219625!
        Me.Line73.Y1 = 1.462833!
        Me.Line73.Y2 = 1.862833!
        '
        'Line74
        '
        Me.Line74.Height = 0.4!
        Me.Line74.Left = 3.008125!
        Me.Line74.LineWeight = 1!
        Me.Line74.Name = "Line74"
        Me.Line74.Top = 1.062833!
        Me.Line74.Width = 0!
        Me.Line74.X1 = 3.008125!
        Me.Line74.X2 = 3.008125!
        Me.Line74.Y1 = 1.062833!
        Me.Line74.Y2 = 1.462833!
        '
        'TextBox24
        '
        Me.TextBox24.DataField = "点検"
        Me.TextBox24.Height = 0.2!
        Me.TextBox24.Left = 6.436126!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox24.Text = "ＮＮＮ"
        Me.TextBox24.Top = 0.6000001!
        Me.TextBox24.Width = 0.55!
        '
        'TextBox22
        '
        Me.TextBox22.DataField = "承認品管"
        Me.TextBox22.Height = 0.2!
        Me.TextBox22.Left = 5.336126!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox22.Text = "ＮＮＮ"
        Me.TextBox22.Top = 0.6000001!
        Me.TextBox22.Width = 0.55!
        '
        'TextBox9
        '
        Me.TextBox9.DataField = "梱包ラベル"
        Me.TextBox9.Height = 0.2!
        Me.TextBox9.Left = 3.810125!
        Me.TextBox9.MultiLine = false
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom; white-space: nowrap" & _
            ""
        Me.TextBox9.Text = "XXXXXXXXXXXX"
        Me.TextBox9.Top = 0.6000001!
        Me.TextBox9.Width = 0.8875!
        '
        'Label25
        '
        Me.Label25.Height = 0.2!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 5.886126!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; text-align: center; vertical-align: middle;" & _
            " ddo-char-set: 1"
        Me.Label25.Text = "承認技術"
        Me.Label25.Top = 0.4!
        Me.Label25.Width = 0.55!
        '
        'Label5
        '
        Me.Label5.Height = 0.2000001!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.710125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label5.Text = "梱包ラベル"
        Me.Label5.Top = 0.4!
        Me.Label5.Width = 0.7045!
        '
        'Label24
        '
        Me.Label24.Height = 0.2000001!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 5.336126!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; text-align: center; vertical-align: middle;" & _
            " ddo-char-set: 1"
        Me.Label24.Text = "承認品管"
        Me.Label24.Top = 0.4!
        Me.Label24.Width = 0.55!
        '
        'TextBox25
        '
        Me.TextBox25.DataField = "COR_MARK2"
        Me.TextBox25.Height = 0.2!
        Me.TextBox25.Left = 1.369792!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox25.Text = "XXX"
        Me.TextBox25.Top = 1!
        Me.TextBox25.Width = 1.066667!
        '
        'TextBox26
        '
        Me.TextBox26.DataField = "COR_MARK1"
        Me.TextBox26.Height = 0.2!
        Me.TextBox26.Left = 2.636458!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox26.Text = "XXX"
        Me.TextBox26.Top = 1!
        Me.TextBox26.Width = 1!
        '
        'TextBox27
        '
        Me.TextBox27.DataField = "COR_MARK4"
        Me.TextBox27.Height = 0.2!
        Me.TextBox27.Left = 3.836458!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox27.Text = "XXX"
        Me.TextBox27.Top = 1!
        Me.TextBox27.Width = 1.066667!
        '
        'TextBox28
        '
        Me.TextBox28.DataField = "COR_MARK3"
        Me.TextBox28.Height = 0.2!
        Me.TextBox28.Left = 5.103125!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox28.Text = "XXX"
        Me.TextBox28.Top = 1!
        Me.TextBox28.Width = 1.066667!
        '
        'TextBox29
        '
        Me.TextBox29.DataField = "COR_MARK5"
        Me.TextBox29.Height = 0.2!
        Me.TextBox29.Left = 6.369792!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox29.Text = "XXX"
        Me.TextBox29.Top = 1!
        Me.TextBox29.Width = 1.066667!
        '
        'Line12
        '
        Me.Line12.Height = 1.2!
        Me.Line12.Left = 0.2!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 0.2!
        Me.Line12.X2 = 0.2!
        Me.Line12.Y1 = 0!
        Me.Line12.Y2 = 1.2!
        '
        'Line14
        '
        Me.Line14.Height = 0!
        Me.Line14.Left = 0.203125!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 1.2!
        Me.Line14.Width = 7.333333!
        Me.Line14.X1 = 0.203125!
        Me.Line14.X2 = 7.536458!
        Me.Line14.Y1 = 1.2!
        Me.Line14.Y2 = 1.2!
        '
        'Label13
        '
        Me.Label13.Height = 0.2000001!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.243125!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label13.Text = "使用源製品番号"
        Me.Label13.Top = 0!
        Me.Label13.Width = 0.8666667!
        '
        'TextBox10
        '
        Me.TextBox10.DataField = "USE_ORG_PARTS_NO"
        Me.TextBox10.Height = 0.2!
        Me.TextBox10.Left = 0.343125!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom; ddo-char-set: 1"
        Me.TextBox10.Text = "XXXX-XXX-XXX"
        Me.TextBox10.Top = 0.2!
        Me.TextBox10.Width = 0.933!
        '
        'Line15
        '
        Me.Line15.Height = 0.8!
        Me.Line15.Left = 1.269792!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.4000001!
        Me.Line15.Width = 0!
        Me.Line15.X1 = 1.269792!
        Me.Line15.X2 = 1.269792!
        Me.Line15.Y1 = 0.4000001!
        Me.Line15.Y2 = 1.2!
        '
        'Label14
        '
        Me.Label14.Height = 0.2000001!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 1.376125!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label14.Text = "源製品ロットNO"
        Me.Label14.Top = 0!
        Me.Label14.Width = 0.8666667!
        '
        'TextBox11
        '
        Me.TextBox11.DataField = "ORIGIN_PARTS_NO"
        Me.TextBox11.Height = 0.2!
        Me.TextBox11.Left = 1.476125!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap; ddo-char-set: 1"
        Me.TextBox11.Text = "99999"
        Me.TextBox11.Top = 0.2!
        Me.TextBox11.Width = 0.5269999!
        '
        'Line17
        '
        Me.Line17.Height = 0.4!
        Me.Line17.Left = 2.315625!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 2.315625!
        Me.Line17.X2 = 2.315625!
        Me.Line17.Y1 = 0!
        Me.Line17.Y2 = 0.4!
        '
        'Label17
        '
        Me.Label17.Height = 0.2000001!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.346125!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label17.Text = "材料名"
        Me.Label17.Top = 0!
        Me.Label17.Width = 0.3999999!
        '
        'TextBox12
        '
        Me.TextBox12.DataField = "MATL_NM"
        Me.TextBox12.Height = 0.2!
        Me.TextBox12.Left = 2.446125!
        Me.TextBox12.MultiLine = false
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom; white-space: now" & _
            "rap; ddo-char-set: 1"
        Me.TextBox12.Text = "XXXXXXXXXXXXXXXXX"
        Me.TextBox12.Top = 0.2!
        Me.TextBox12.Width = 1.172!
        '
        'Label18
        '
        Me.Label18.Height = 0.2000001!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 3.710125!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label18.Text = "材料SPEC"
        Me.Label18.Top = 0!
        Me.Label18.Width = 0.5333335!
        '
        'TextBox13
        '
        Me.TextBox13.DataField = "MATL_SPEC"
        Me.TextBox13.Height = 0.2!
        Me.TextBox13.Left = 3.810125!
        Me.TextBox13.MultiLine = false
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom; white-space: now" & _
            "rap; ddo-char-set: 1"
        Me.TextBox13.Text = "XXXXXXXXXXXX"
        Me.TextBox13.Top = 0.2!
        Me.TextBox13.Width = 1.133333!
        '
        'Line20
        '
        Me.Line20.Height = 0.3999999!
        Me.Line20.Left = 5.003125!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 5.003125!
        Me.Line20.X2 = 5.003125!
        Me.Line20.Y1 = 0!
        Me.Line20.Y2 = 0.3999999!
        '
        'Label19
        '
        Me.Label19.Height = 0.2000001!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 5.043125!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label19.Text = "材料コード"
        Me.Label19.Top = 0!
        Me.Label19.Width = 0.6666666!
        '
        'TextBox14
        '
        Me.TextBox14.DataField = "MATL_CD"
        Me.TextBox14.Height = 0.2!
        Me.TextBox14.Left = 5.143125!
        Me.TextBox14.MultiLine = false
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom; white-space: now" & _
            "rap; ddo-char-set: 1"
        Me.TextBox14.Text = "XXXXXXXXXXXXXXX"
        Me.TextBox14.Top = 0.2!
        Me.TextBox14.Width = 1.133333!
        '
        'Line21
        '
        Me.Line21.Height = 0.3999999!
        Me.Line21.Left = 6.336459!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0!
        Me.Line21.Width = 0!
        Me.Line21.X1 = 6.336459!
        Me.Line21.X2 = 6.336459!
        Me.Line21.Y1 = 0!
        Me.Line21.Y2 = 0.3999999!
        '
        'Label20
        '
        Me.Label20.Height = 0.2000001!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 6.376125!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label20.Text = "材料ロットNO"
        Me.Label20.Top = 0!
        Me.Label20.Width = 0.8!
        '
        'txtZairyouLotNo
        '
        Me.txtZairyouLotNo.Height = 0.2!
        Me.txtZairyouLotNo.Left = 6.476125!
        Me.txtZairyouLotNo.Name = "txtZairyouLotNo"
        Me.txtZairyouLotNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap; ddo-char-set: 1"
        Me.txtZairyouLotNo.Text = "99999"
        Me.txtZairyouLotNo.Top = 0.2!
        Me.txtZairyouLotNo.Width = 0.4666668!
        '
        'Label21
        '
        Me.Label21.Height = 0.2000001!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.243125!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label21.Text = "納期"
        Me.Label21.Top = 0.4!
        Me.Label21.Width = 0.2666667!
        '
        'txtNouki
        '
        Me.txtNouki.Height = 0.4000001!
        Me.txtNouki.Left = 0.3364583!
        Me.txtNouki.Name = "txtNouki"
        Me.txtNouki.Style = "font-family: ＭＳ ゴシック; font-size: 24pt; text-align: center; vertical-align: middle" & _
            "; white-space: nowrap"
        Me.txtNouki.Text = "99/99"
        Me.txtNouki.Top = 0.6666667!
        Me.txtNouki.Width = 0.8666667!
        '
        'TextBox19
        '
        Me.TextBox19.DataField = "テストピース"
        Me.TextBox19.Height = 0.2!
        Me.TextBox19.Left = 1.410125!
        Me.TextBox19.MultiLine = false
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom; white-space: nowrap" & _
            ""
        Me.TextBox19.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.TextBox19.Top = 0.6000001!
        Me.TextBox19.Width = 2.220833!
        '
        'Label22
        '
        Me.Label22.Height = 0.2000001!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 1.310125!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label22.Text = "熱処理テストピース"
        Me.Label22.Top = 0.4!
        Me.Label22.Width = 1.066667!
        '
        'TextBox20
        '
        Me.TextBox20.DataField = "作成"
        Me.TextBox20.Height = 0.2!
        Me.TextBox20.Left = 6.986125!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox20.Text = "ＮＮＮ"
        Me.TextBox20.Top = 0.6000001!
        Me.TextBox20.Width = 0.55!
        '
        'TextBox21
        '
        Me.TextBox21.DataField = "承認技術"
        Me.TextBox21.Height = 0.2!
        Me.TextBox21.Left = 5.886126!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox21.Text = "ＮＮＮ"
        Me.TextBox21.Top = 0.6000001!
        Me.TextBox21.Width = 0.55!
        '
        'Line24
        '
        Me.Line24.Height = 0.4!
        Me.Line24.Left = 5.886126!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 0.4!
        Me.Line24.Width = 0!
        Me.Line24.X1 = 5.886126!
        Me.Line24.X2 = 5.886126!
        Me.Line24.Y1 = 0.4!
        Me.Line24.Y2 = 0.8!
        '
        'TextBox23
        '
        Me.TextBox23.DataField = "着工者"
        Me.TextBox23.Height = 0.2!
        Me.TextBox23.Left = 4.786126!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox23.Text = "ＮＮＮ"
        Me.TextBox23.Top = 0.6000001!
        Me.TextBox23.Width = 0.55!
        '
        'Line26
        '
        Me.Line26.Height = 0.4!
        Me.Line26.Left = 4.786126!
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.4!
        Me.Line26.Width = 0!
        Me.Line26.X1 = 4.786126!
        Me.Line26.X2 = 4.786126!
        Me.Line26.Y1 = 0.4!
        Me.Line26.Y2 = 0.8!
        '
        'Label23
        '
        Me.Label23.Height = 0.2000001!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 4.826125!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label23.Text = "着工者"
        Me.Label23.Top = 0.4!
        Me.Label23.Width = 0.3999999!
        '
        'Label26
        '
        Me.Label26.Height = 0.2000001!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 7.026125!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label26.Text = "作成"
        Me.Label26.Top = 0.4!
        Me.Label26.Width = 0.3999999!
        '
        'Line27
        '
        Me.Line27.Height = 0.4!
        Me.Line27.Left = 6.436126!
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 0.4!
        Me.Line27.Width = 0!
        Me.Line27.X1 = 6.436126!
        Me.Line27.X2 = 6.436126!
        Me.Line27.Y1 = 0.4!
        Me.Line27.Y2 = 0.8!
        '
        'Label27
        '
        Me.Label27.Height = 0.2000001!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 6.476125!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label27.Text = "点検"
        Me.Label27.Top = 0.4!
        Me.Label27.Width = 0.3999999!
        '
        'Label28
        '
        Me.Label28.Height = 0.2000001!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 1.315625!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label28.Text = "製品標準書 Rev"
        Me.Label28.Top = 0.8125!
        Me.Label28.Width = 1.066667!
        '
        'Label29
        '
        Me.Label29.Height = 0.2000001!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 2.576125!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label29.Text = "工程票 Rev"
        Me.Label29.Top = 0.8!
        Me.Label29.Width = 1.066667!
        '
        'Label30
        '
        Me.Label30.Height = 0.2000001!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 3.776125!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label30.Text = "製品図面 Rev"
        Me.Label30.Top = 0.8!
        Me.Label30.Width = 1.066667!
        '
        'Label31
        '
        Me.Label31.Height = 0.2000001!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 5.043125!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label31.Text = "加工図 Rev"
        Me.Label31.Top = 0.8!
        Me.Label31.Width = 1.066667!
        '
        'Label32
        '
        Me.Label32.Height = 0.2000001!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 6.310125!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 8pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label32.Text = "試験・検査表 Rev"
        Me.Label32.Top = 0.8!
        Me.Label32.Width = 1.066667!
        '
        'Line28
        '
        Me.Line28.Height = 0.4!
        Me.Line28.Left = 2.536458!
        Me.Line28.LineWeight = 1!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 0.8!
        Me.Line28.Width = 0!
        Me.Line28.X1 = 2.536458!
        Me.Line28.X2 = 2.536458!
        Me.Line28.Y1 = 0.8!
        Me.Line28.Y2 = 1.2!
        '
        'Line29
        '
        Me.Line29.Height = 0.4!
        Me.Line29.Left = 3.736458!
        Me.Line29.LineWeight = 1!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 0.8!
        Me.Line29.Width = 0!
        Me.Line29.X1 = 3.736458!
        Me.Line29.X2 = 3.736458!
        Me.Line29.Y1 = 0.8!
        Me.Line29.Y2 = 1.2!
        '
        'Line30
        '
        Me.Line30.Height = 0.4!
        Me.Line30.Left = 5.003125!
        Me.Line30.LineWeight = 1!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 0.8!
        Me.Line30.Width = 0!
        Me.Line30.X1 = 5.003125!
        Me.Line30.X2 = 5.003125!
        Me.Line30.Y1 = 0.8!
        Me.Line30.Y2 = 1.2!
        '
        'Line31
        '
        Me.Line31.Height = 0.4!
        Me.Line31.Left = 6.267!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 0.8!
        Me.Line31.Width = 0!
        Me.Line31.X1 = 6.267!
        Me.Line31.X2 = 6.267!
        Me.Line31.Y1 = 0.8!
        Me.Line31.Y2 = 1.2!
        '
        'Line19
        '
        Me.Line19.Height = 0.8!
        Me.Line19.Left = 3.669792!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 3.669792!
        Me.Line19.X2 = 3.669792!
        Me.Line19.Y1 = 0!
        Me.Line19.Y2 = 0.8!
        '
        'Line13
        '
        Me.Line13.Height = 0.3999999!
        Me.Line13.Left = 1.336458!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 1.336458!
        Me.Line13.X2 = 1.336458!
        Me.Line13.Y1 = 0!
        Me.Line13.Y2 = 0.3999999!
        '
        'Line22
        '
        Me.Line22.Height = 0!
        Me.Line22.Left = 1.269792!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 0.8!
        Me.Line22.Width = 6.266667!
        Me.Line22.X1 = 1.269792!
        Me.Line22.X2 = 7.536458!
        Me.Line22.Y1 = 0.8!
        Me.Line22.Y2 = 0.8!
        '
        'Line16
        '
        Me.Line16.Height = 0!
        Me.Line16.Left = 0.203125!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.4000001!
        Me.Line16.Width = 7.333333!
        Me.Line16.X1 = 0.203125!
        Me.Line16.X2 = 7.536458!
        Me.Line16.Y1 = 0.4000001!
        Me.Line16.Y2 = 0.4000001!
        '
        'Line25
        '
        Me.Line25.Height = 0.4!
        Me.Line25.Left = 5.336126!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 0.4!
        Me.Line25.Width = 0!
        Me.Line25.X1 = 5.336126!
        Me.Line25.X2 = 5.336126!
        Me.Line25.Y1 = 0.4!
        Me.Line25.Y2 = 0.8!
        '
        'Line23
        '
        Me.Line23.Height = 0.4!
        Me.Line23.Left = 6.986125!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 0.4!
        Me.Line23.Width = 0!
        Me.Line23.X1 = 6.986125!
        Me.Line23.X2 = 6.986125!
        Me.Line23.Y1 = 0.4!
        Me.Line23.Y2 = 0.8!
        '
        'Line18
        '
        Me.Line18.Height = 1.2!
        Me.Line18.Left = 7.531!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 7.531!
        Me.Line18.X2 = 7.531!
        Me.Line18.Y1 = 0!
        Me.Line18.Y2 = 1.2!
        '
        'Line32
        '
        Me.Line32.Height = 0.3333333!
        Me.Line32.Left = 0.2!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 0!
        Me.Line32.Width = 0!
        Me.Line32.X1 = 0.2!
        Me.Line32.X2 = 0.2!
        Me.Line32.Y1 = 0!
        Me.Line32.Y2 = 0.3333333!
        '
        'Line40
        '
        Me.Line40.Height = 0.3333333!
        Me.Line40.Left = 0.4666668!
        Me.Line40.LineWeight = 1!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 0!
        Me.Line40.Width = 0!
        Me.Line40.X1 = 0.4666668!
        Me.Line40.X2 = 0.4666668!
        Me.Line40.Y1 = 0!
        Me.Line40.Y2 = 0.3333333!
        '
        'Line41
        '
        Me.Line41.Height = 0!
        Me.Line41.Left = 0.2!
        Me.Line41.LineWeight = 1!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 0.3333333!
        Me.Line41.Width = 7.333333!
        Me.Line41.X1 = 0.2!
        Me.Line41.X2 = 7.533333!
        Me.Line41.Y1 = 0.3333333!
        Me.Line41.Y2 = 0.3333333!
        '
        'Label33
        '
        Me.Label33.Height = 0.2000001!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.2!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label33.Text = "符"
        Me.Label33.Top = 0.06666667!
        Me.Label33.Width = 0.2666667!
        '
        'Line42
        '
        Me.Line42.Height = 0.3333333!
        Me.Line42.Left = 0.8!
        Me.Line42.LineWeight = 1!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 0!
        Me.Line42.Width = 0!
        Me.Line42.X1 = 0.8!
        Me.Line42.X2 = 0.8!
        Me.Line42.Y1 = 0!
        Me.Line42.Y2 = 0.3333333!
        '
        'Line43
        '
        Me.Line43.Height = 0.3333333!
        Me.Line43.Left = 1.800001!
        Me.Line43.LineWeight = 1!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 0!
        Me.Line43.Width = 0!
        Me.Line43.X1 = 1.800001!
        Me.Line43.X2 = 1.800001!
        Me.Line43.Y1 = 0!
        Me.Line43.Y2 = 0.3333333!
        '
        'Line44
        '
        Me.Line44.Height = 0.3333333!
        Me.Line44.Left = 2.200001!
        Me.Line44.LineWeight = 1!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 0!
        Me.Line44.Width = 0!
        Me.Line44.X1 = 2.200001!
        Me.Line44.X2 = 2.200001!
        Me.Line44.Y1 = 0!
        Me.Line44.Y2 = 0.3333333!
        '
        'Label34
        '
        Me.Label34.Height = 0.2000001!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 0.4666668!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label34.Text = "工順"
        Me.Label34.Top = 0.06666667!
        Me.Label34.Width = 0.3333333!
        '
        'Label35
        '
        Me.Label35.Height = 0.2000001!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 0.8!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label35.Text = "バーコード"
        Me.Label35.Top = 0.06666667!
        Me.Label35.Width = 1!
        '
        'Label36
        '
        Me.Label36.Height = 0.2000001!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 1.800001!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label36.Text = "ｼｮｯﾌﾟ"
        Me.Label36.Top = 0.06666667!
        Me.Label36.Width = 0.3999994!
        '
        'Line49
        '
        Me.Line49.Height = 0.3333333!
        Me.Line49.Left = 3.066667!
        Me.Line49.LineWeight = 1!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 0!
        Me.Line49.Width = 0!
        Me.Line49.X1 = 3.066667!
        Me.Line49.X2 = 3.066667!
        Me.Line49.Y1 = 0!
        Me.Line49.Y2 = 0.3333333!
        '
        'Line50
        '
        Me.Line50.Height = 0.3333333!
        Me.Line50.Left = 4.533333!
        Me.Line50.LineWeight = 1!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 0!
        Me.Line50.Width = 0!
        Me.Line50.X1 = 4.533333!
        Me.Line50.X2 = 4.533333!
        Me.Line50.Y1 = 0!
        Me.Line50.Y2 = 0.3333333!
        '
        'Line51
        '
        Me.Line51.Height = 0.3333333!
        Me.Line51.Left = 5.4!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 0!
        Me.Line51.Width = 0!
        Me.Line51.X1 = 5.4!
        Me.Line51.X2 = 5.4!
        Me.Line51.Y1 = 0!
        Me.Line51.Y2 = 0.3333333!
        '
        'Label37
        '
        Me.Label37.Height = 0.2000001!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 2.2!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label37.Text = "設備"
        Me.Label37.Top = 0.06666667!
        Me.Label37.Width = 0.8666667!
        '
        'Label38
        '
        Me.Label38.Height = 0.2000001!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 3.066667!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label38.Text = "工程手順"
        Me.Label38.Top = 0.06666667!
        Me.Label38.Width = 1.466667!
        '
        'Label39
        '
        Me.Label39.Height = 0.2000001!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 4.533333!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label39.Text = "作業標準"
        Me.Label39.Top = 0.06666667!
        Me.Label39.Width = 0.8666667!
        '
        'Line52
        '
        Me.Line52.Height = 0.3333333!
        Me.Line52.Left = 7.53125!
        Me.Line52.LineWeight = 1!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 0!
        Me.Line52.Width = 0!
        Me.Line52.X1 = 7.53125!
        Me.Line52.X2 = 7.53125!
        Me.Line52.Y1 = 0!
        Me.Line52.Y2 = 0.3333333!
        '
        'Line53
        '
        Me.Line53.Height = 0.3333333!
        Me.Line53.Left = 5.799997!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 0!
        Me.Line53.Width = 0!
        Me.Line53.X1 = 5.799997!
        Me.Line53.X2 = 5.799997!
        Me.Line53.Y1 = 0!
        Me.Line53.Y2 = 0.3333333!
        '
        'Label41
        '
        Me.Label41.Height = 0.2000001!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 5.8!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label41.Text = "日付"
        Me.Label41.Top = 0.06666667!
        Me.Label41.Width = 0.4666668!
        '
        'Line54
        '
        Me.Line54.Height = 0.3333333!
        Me.Line54.Left = 6.266667!
        Me.Line54.LineWeight = 1!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 0!
        Me.Line54.Width = 0!
        Me.Line54.X1 = 6.266667!
        Me.Line54.X2 = 6.266667!
        Me.Line54.Y1 = 0!
        Me.Line54.Y2 = 0.3333333!
        '
        'Label42
        '
        Me.Label42.Height = 0.2000001!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 6.266667!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label42.Text = "数量"
        Me.Label42.Top = 0.06666667!
        Me.Label42.Width = 0.4000001!
        '
        'Label44
        '
        Me.Label44.Height = 0.2!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 7.066667!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label44.Text = "-数処理"
        Me.Label44.Top = 0.06666667!
        Me.Label44.Width = 0.4666666!
        '
        'Line56
        '
        Me.Line56.Height = 0.3333333!
        Me.Line56.Left = 6.6625!
        Me.Line56.LineWeight = 1!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 0!
        Me.Line56.Width = 0!
        Me.Line56.X1 = 6.6625!
        Me.Line56.X2 = 6.6625!
        Me.Line56.Y1 = 0!
        Me.Line56.Y2 = 0.3333333!
        '
        'Label45
        '
        Me.Label45.Height = 0.2000001!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 6.666667!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label45.Text = "-数"
        Me.Label45.Top = 0.06666667!
        Me.Label45.Width = 0.4000001!
        '
        'Line57
        '
        Me.Line57.Height = 0.3333333!
        Me.Line57.Left = 7.0625!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 0!
        Me.Line57.Width = 0!
        Me.Line57.X1 = 7.0625!
        Me.Line57.X2 = 7.0625!
        Me.Line57.Y1 = 0!
        Me.Line57.Y2 = 0.3333333!
        '
        'Label40
        '
        Me.Label40.Height = 0.1875!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 5.4!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label40.Text = "作業"
        Me.Label40.Top = 0!
        Me.Label40.Width = 0.4000001!
        '
        'Label51
        '
        Me.Label51.Height = 0.1666667!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 5.4!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: top"
        Me.Label51.Text = "印"
        Me.Label51.Top = 0.168!
        Me.Label51.Width = 0.4000001!
        '
        'TextBox30
        '
        Me.TextBox30.DataField = "UM_P_ORDER"
        Me.TextBox30.Height = 0.2!
        Me.TextBox30.Left = 0.2!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox30.Text = "XXX"
        Me.TextBox30.Top = 0.1333333!
        Me.TextBox30.Width = 0.2666667!
        '
        'Line33
        '
        Me.Line33.Height = 0.5333334!
        Me.Line33.Left = 0.2!
        Me.Line33.LineWeight = 1!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 0!
        Me.Line33.Width = 0!
        Me.Line33.X1 = 0.2!
        Me.Line33.X2 = 0.2!
        Me.Line33.Y1 = 0!
        Me.Line33.Y2 = 0.5333334!
        '
        'Line34
        '
        Me.Line34.Height = 0.5333334!
        Me.Line34.Left = 0.4666668!
        Me.Line34.LineWeight = 1!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 0!
        Me.Line34.Width = 0!
        Me.Line34.X1 = 0.4666668!
        Me.Line34.X2 = 0.4666668!
        Me.Line34.Y1 = 0!
        Me.Line34.Y2 = 0.5333334!
        '
        'txtKihonKoujun
        '
        Me.txtKihonKoujun.DataField = "P_ORDER_MAIN"
        Me.txtKihonKoujun.Height = 0.2!
        Me.txtKihonKoujun.Left = 0.4666668!
        Me.txtKihonKoujun.Name = "txtKihonKoujun"
        Me.txtKihonKoujun.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.txtKihonKoujun.Text = "999"
        Me.txtKihonKoujun.Top = 0.1333333!
        Me.txtKihonKoujun.Width = 0.3333334!
        '
        'txtHojoKoujun
        '
        Me.txtHojoKoujun.DataField = "P_ORDER_SUB"
        Me.txtHojoKoujun.Height = 0.2!
        Me.txtHojoKoujun.Left = 0.4666668!
        Me.txtHojoKoujun.Name = "txtHojoKoujun"
        Me.txtHojoKoujun.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.txtHojoKoujun.Text = "9"
        Me.txtHojoKoujun.Top = 0.3333333!
        Me.txtHojoKoujun.Width = 0.3333334!
        '
        'txtBarcode2
        '
        Me.txtBarcode2.CaptionPosition = GrapeCity.ActiveReports.SectionReportModel.BarCodeCaptionPosition.Below
        Me.txtBarcode2.CheckSumEnabled = false
        Me.txtBarcode2.Font = New System.Drawing.Font("Courier New", 8!)
        Me.txtBarcode2.Height = 0.4666668!
        Me.txtBarcode2.Left = 1!
        Me.txtBarcode2.Name = "txtBarcode2"
        Me.txtBarcode2.QuietZoneBottom = 0!
        Me.txtBarcode2.QuietZoneLeft = 0!
        Me.txtBarcode2.QuietZoneRight = 0!
        Me.txtBarcode2.QuietZoneTop = 0!
        Me.txtBarcode2.Style = GrapeCity.ActiveReports.SectionReportModel.BarCodeStyle.Code39
        Me.txtBarcode2.Text = "010"
        Me.txtBarcode2.Top = 0.06666667!
        Me.txtBarcode2.Width = 0.6000001!
        '
        'Line35
        '
        Me.Line35.Height = 0.5333334!
        Me.Line35.Left = 0.8!
        Me.Line35.LineWeight = 1!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 0!
        Me.Line35.Width = 0!
        Me.Line35.X1 = 0.8!
        Me.Line35.X2 = 0.8!
        Me.Line35.Y1 = 0!
        Me.Line35.Y2 = 0.5333334!
        '
        'Line36
        '
        Me.Line36.Height = 0.5333334!
        Me.Line36.Left = 1.8!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 0!
        Me.Line36.Width = 7.152557E-07!
        Me.Line36.X1 = 1.800001!
        Me.Line36.X2 = 1.8!
        Me.Line36.Y1 = 0!
        Me.Line36.Y2 = 0.5333334!
        '
        'Line37
        '
        Me.Line37.Height = 0!
        Me.Line37.Left = 0.2!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 0.5333334!
        Me.Line37.Width = 7.333333!
        Me.Line37.X1 = 0.2!
        Me.Line37.X2 = 7.533333!
        Me.Line37.Y1 = 0.5333334!
        Me.Line37.Y2 = 0.5333334!
        '
        'TextBox33
        '
        Me.TextBox33.DataField = "SHOP"
        Me.TextBox33.Height = 0.2!
        Me.TextBox33.Left = 1.866667!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox33.Text = "99"
        Me.TextBox33.Top = 0.1333333!
        Me.TextBox33.Width = 0.2666666!
        '
        'Line39
        '
        Me.Line39.Height = 0.5333334!
        Me.Line39.Left = 2.2!
        Me.Line39.LineWeight = 1!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 0!
        Me.Line39.Width = 7.152557E-07!
        Me.Line39.X1 = 2.200001!
        Me.Line39.X2 = 2.2!
        Me.Line39.Y1 = 0!
        Me.Line39.Y2 = 0.5333334!
        '
        'TextBox34
        '
        Me.TextBox34.DataField = "設備集約名称"
        Me.TextBox34.Height = 0.2!
        Me.TextBox34.Left = 2.266667!
        Me.TextBox34.MultiLine = false
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom; w" & _
            "hite-space: nowrap"
        Me.TextBox34.Text = "XXXXXXXXXX"
        Me.TextBox34.Top = 0.06666667!
        Me.TextBox34.Width = 0.7333326!
        '
        'TextBox35
        '
        Me.TextBox35.DataField = "P_ORDER_NM"
        Me.TextBox35.Height = 0.2!
        Me.TextBox35.Left = 3.133333!
        Me.TextBox35.MultiLine = false
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom; w" & _
            "hite-space: nowrap"
        Me.TextBox35.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.TextBox35.Top = 0.06666667!
        Me.TextBox35.Width = 1.333333!
        '
        'Line45
        '
        Me.Line45.Height = 0.2666667!
        Me.Line45.Left = 3.066667!
        Me.Line45.LineWeight = 1!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 0!
        Me.Line45.Width = 0!
        Me.Line45.X1 = 3.066667!
        Me.Line45.X2 = 3.066667!
        Me.Line45.Y1 = 0!
        Me.Line45.Y2 = 0.2666667!
        '
        'Line46
        '
        Me.Line46.Height = 0!
        Me.Line46.Left = 2.2!
        Me.Line46.LineWeight = 1!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 0.2666667!
        Me.Line46.Width = 3.2!
        Me.Line46.X1 = 2.2!
        Me.Line46.X2 = 5.4!
        Me.Line46.Y1 = 0.2666667!
        Me.Line46.Y2 = 0.2666667!
        '
        'Line47
        '
        Me.Line47.Height = 0.2666667!
        Me.Line47.Left = 4.533333!
        Me.Line47.LineWeight = 1!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 0!
        Me.Line47.Width = 0!
        Me.Line47.X1 = 4.533333!
        Me.Line47.X2 = 4.533333!
        Me.Line47.Y1 = 0!
        Me.Line47.Y2 = 0.2666667!
        '
        'TextBox36
        '
        Me.TextBox36.DataField = "WORK_STD"
        Me.TextBox36.Height = 0.2!
        Me.TextBox36.Left = 4.6!
        Me.TextBox36.MultiLine = false
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom; w" & _
            "hite-space: nowrap"
        Me.TextBox36.Text = "XXXXXXXXXX"
        Me.TextBox36.Top = 0.06666667!
        Me.TextBox36.Width = 0.7333326!
        '
        'Line48
        '
        Me.Line48.Height = 0.5333334!
        Me.Line48.Left = 5.4!
        Me.Line48.LineWeight = 1!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 0!
        Me.Line48.Width = 0!
        Me.Line48.X1 = 5.4!
        Me.Line48.X2 = 5.4!
        Me.Line48.Y1 = 0!
        Me.Line48.Y2 = 0.5333334!
        '
        'Line38
        '
        Me.Line38.Height = 0.5333334!
        Me.Line38.Left = 7.53125!
        Me.Line38.LineWeight = 1!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 0!
        Me.Line38.Width = 0!
        Me.Line38.X1 = 7.53125!
        Me.Line38.X2 = 7.53125!
        Me.Line38.Y1 = 0!
        Me.Line38.Y2 = 0.5333334!
        '
        'TextBox37
        '
        Me.TextBox37.DataField = "WORK_COMMENT"
        Me.TextBox37.Height = 0.2!
        Me.TextBox37.Left = 2.266667!
        Me.TextBox37.MultiLine = false
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom; w" & _
            "hite-space: nowrap"
        Me.TextBox37.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.TextBox37.Top = 0.3333333!
        Me.TextBox37.Width = 3.066667!
        '
        'Line58
        '
        Me.Line58.Height = 0.5333334!
        Me.Line58.Left = 5.8!
        Me.Line58.LineWeight = 1!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 0!
        Me.Line58.Width = 0!
        Me.Line58.X1 = 5.8!
        Me.Line58.X2 = 5.8!
        Me.Line58.Y1 = 0!
        Me.Line58.Y2 = 0.5333334!
        '
        'Line59
        '
        Me.Line59.Height = 0.5333334!
        Me.Line59.Left = 6.266667!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 0!
        Me.Line59.Width = 0!
        Me.Line59.X1 = 6.266667!
        Me.Line59.X2 = 6.266667!
        Me.Line59.Y1 = 0!
        Me.Line59.Y2 = 0.5333334!
        '
        'Line61
        '
        Me.Line61.Height = 0.5333334!
        Me.Line61.Left = 6.663!
        Me.Line61.LineWeight = 1!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 0!
        Me.Line61.Width = 0!
        Me.Line61.X1 = 6.663!
        Me.Line61.X2 = 6.663!
        Me.Line61.Y1 = 0!
        Me.Line61.Y2 = 0.5333334!
        '
        'Line62
        '
        Me.Line62.Height = 0.5333334!
        Me.Line62.Left = 7.063!
        Me.Line62.LineWeight = 1!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 0!
        Me.Line62.Width = 0!
        Me.Line62.X1 = 7.063!
        Me.Line62.X2 = 7.063!
        Me.Line62.Y1 = 0!
        Me.Line62.Y2 = 0.5333334!
        '
        'Label46
        '
        Me.Label46.Height = 0.2000001!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 0.2666667!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label46.Text = "修正元工程手順"
        Me.Label46.Top = 0!
        Me.Label46.Width = 1.066667!
        '
        'Line63
        '
        Me.Line63.Height = 0!
        Me.Line63.Left = 0.2!
        Me.Line63.LineWeight = 1!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 0.2!
        Me.Line63.Width = 3.533333!
        Me.Line63.X1 = 0.2!
        Me.Line63.X2 = 3.733333!
        Me.Line63.Y1 = 0.2!
        Me.Line63.Y2 = 0.2!
        '
        'Line65
        '
        Me.Line65.Height = 0.2000002!
        Me.Line65.Left = 0.2!
        Me.Line65.LineWeight = 1!
        Me.Line65.Name = "Line65"
        Me.Line65.Top = 0!
        Me.Line65.Width = 0!
        Me.Line65.X1 = 0.2!
        Me.Line65.X2 = 0.2!
        Me.Line65.Y1 = 0!
        Me.Line65.Y2 = 0.2000002!
        '
        'Line66
        '
        Me.Line66.Height = 0.2000002!
        Me.Line66.Left = 1.4!
        Me.Line66.LineWeight = 1!
        Me.Line66.Name = "Line66"
        Me.Line66.Top = 0!
        Me.Line66.Width = 0!
        Me.Line66.X1 = 1.4!
        Me.Line66.X2 = 1.4!
        Me.Line66.Y1 = 0!
        Me.Line66.Y2 = 0.2000002!
        '
        'Line67
        '
        Me.Line67.Height = 0.2000002!
        Me.Line67.Left = 2.2!
        Me.Line67.LineWeight = 1!
        Me.Line67.Name = "Line67"
        Me.Line67.Top = 0!
        Me.Line67.Width = 0!
        Me.Line67.X1 = 2.2!
        Me.Line67.X2 = 2.2!
        Me.Line67.Y1 = 0!
        Me.Line67.Y2 = 0.2000002!
        '
        'Line69
        '
        Me.Line69.Height = 0.2000002!
        Me.Line69.Left = 3.733334!
        Me.Line69.LineWeight = 1!
        Me.Line69.Name = "Line69"
        Me.Line69.Top = 0!
        Me.Line69.Width = 0!
        Me.Line69.X1 = 3.733334!
        Me.Line69.X2 = 3.733334!
        Me.Line69.Y1 = 0!
        Me.Line69.Y2 = 0.2000002!
        '
        'TextBox
        '
        Me.TextBox.DataField = "U_P_ORDER_MAIN"
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 1.533333!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.OutputFormat = resources.GetString("TextBox.OutputFormat")
        Me.TextBox.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox.Text = "999"
        Me.TextBox.Top = 0!
        Me.TextBox.Width = 0.3333334!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "U_P_ORDER_SUB"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 1.866667!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: bottom;" & _
            " white-space: nowrap"
        Me.TextBox1.Text = "9"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 0.2000001!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "修正P_ORDER_NM"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 2.266667!
        Me.TextBox2.MultiLine = false
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom; w" & _
            "hite-space: nowrap"
        Me.TextBox2.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 1.4!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=mdctest;User ID=mdctest;Data Source=medical;Persist S" & _
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
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBikou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyuruiName, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtIppanName, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyouninBangou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHanbaiName, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRePrint, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSeihinBangou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyouLotNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNouki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
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
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKihonKoujun, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHojoKoujun, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private _nPage As Integer = 1

    Private _nRePrint As Boolean = False

    Private _sMedicalDNS As String = "User Id=mdctest;Password=mdctest;Data Source=MEDICAL;"
    Private _sHonsyaDNS As String = "User Id=mdctest;Password=mdctest;Data Source=MEDICAL;"

    Private _oMedicalConnect As OracleConnection = Nothing
    Private _oHonsyaConnect As OracleConnection = Nothing

#Region " プロパティ "

    Public WriteOnly Property RePrint() As Boolean
        Set(ByVal nValue As Boolean)
            _nRePrint = nValue
        End Set
    End Property

    Public WriteOnly Property MedicalDNS() As String
        Set(ByVal sValue As String)
            _sMedicalDNS = sValue
        End Set
    End Property

    Public WriteOnly Property HonsyaDNS() As String
        Set(ByVal sValue As String)
            _sHonsyaDNS = sValue
        End Set
    End Property

#End Region

    Private Sub mdtyk040_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        'メディカルDB接続 
        _oMedicalConnect = New OracleConnection(_sMedicalDNS)
        _oMedicalConnect.Open()
        '本社DB接続 
        _oHonsyaConnect = New OracleConnection(_sHonsyaDNS)
        _oHonsyaConnect.Open()
        '項目の作成 
        Fields.Add("KihonKoujun")
        Fields.Add("HojoKoujun")
        Fields.Add("Barcode")
        'テキストフィールドと関連付け 
        txtKihonKoujun.DataField = "KihonKoujun"
        txtHojoKoujun.DataField = "HojoKoujun"
        txtBarcode2.DataField = "Barcode"
    End Sub

    Private Sub mdtyk040_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        _oMedicalConnect.Close()
        _oHonsyaConnect.Close()
    End Sub

    Private Sub mdtyk040_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        Fields("KihonKoujun").Value = CType(Fields("P_ORDER_MAIN").Value, Integer).ToString("000")
        If CType(Fields("P_ORDER_SUB").Value, Integer) <> 0 Then
            Fields("HojoKoujun").Value = Fields("P_ORDER_SUB").Value
        Else
            Fields("HojoKoujun").Value = ""
        End If
        Fields("Barcode").Value = Fields("KihonKoujun").Value
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Dim sMekkin As String = ""
        Dim sQuery As String = ""
        Dim oCommand As OracleCommand = Nothing
        Dim oReader As OracleDataReader = Nothing
        '日付 
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        'ページ 
        lblPage.Text = "Page." + _nPage.ToString("#")
        '再発行 
        lblRePrint.Visible = _nRePrint
        '本社カタログマスタ 
        oCommand = _oHonsyaConnect.CreateCommand()
        oCommand.CommandText = "SELECT BAC_KB,TRIM(YAKUJI_NM),TRIM(PARTS_NM1) || TRIM(PARTS_NM2),TRIM(APPROV_NO),TRIM(GENER_NM),TRIM(PROSTD_NO) FROM CATALOG_MST WHERE COMPANY_NO = '" + Fields("COMPANY_NO").Value + "'"
        oReader = oCommand.ExecuteReader
        If oReader.Read() Then
            sMekkin = GetString(oReader(0))
            txtHanbaiName.Text = GetString(oReader(1))
            txtSyuruiName.Text = GetString(oReader(2))
            txtSyouninBangou.Text = GetString(oReader(3))
            txtIppanName.Text = GetString(oReader(4))
            txtSeihinBangou.Text = GetString(oReader(5))
        Else
            sMekkin = ""
            txtHanbaiName.Text = ""
            txtSyuruiName.Text = ""
            txtSyouninBangou.Text = ""
            txtIppanName.Text = ""
            txtSeihinBangou.Text = ""
        End If
        oReader.Close()
        'バーコード 
        txtBarcode1.Text = Fields("COMPANY_NO").Value + Fields("INDICATE_NO").Value
        Dim iCnt As Integer = 0
        '備考 
        txtBikou.Text = ""
        If GetString(Fields("C_NO").Value) = "W2" Then
            txtBikou.Text += "「試作」"
            iCnt += 1
        End If
        If GetString(Fields("OEM_FLG").Value) = "1" Then
            txtBikou.Text += "「OEM」"
            iCnt += 1
        End If
        If GetString(Fields("FIRST_KB").Value) = "1" Then
            If iCnt = 2 Then txtBikou.Text += ControlChars.NewLine
            txtBikou.Text += "「初品」"
            iCnt += 1
        ElseIf GetString(Fields("FIRST_KB").Value) = "2" Then
            If iCnt = 2 Then txtBikou.Text += ControlChars.NewLine
            txtBikou.Text += "「設変初品」"
            iCnt += 1
        End If
        If sMekkin = "1" Then
            If iCnt = 2 Then txtBikou.Text += ControlChars.NewLine
            txtBikou.Text += "「滅菌品」"
            iCnt += 1
        End If
        'ヘッダー2 
        GroupHeader1.Visible = _nPage = 1
        If GroupHeader1.Visible Then
            '材料ロットNO 
            txtZairyouLotNo.Text = ""
            If Not GetString(Fields("MATL_CD").Value).Trim.Equals("") Then
                sQuery = "SELECT LOT_NO FROM MATL_MORTGAGE_TBL WHERE REN_NO = " + GetString(Fields("REN_NO").Value) + " AND MATL_CD = '" + GetString(Fields("MATL_CD").Value) + "' AND INDICATE_NO = '" + GetString(Fields("INDICATE_NO").Value) + "' AND COMPANY_NO = '" + GetString(Fields("COMPANY_NO").Value) + "'"
                oCommand = _oMedicalConnect.CreateCommand()
                oCommand.CommandText = sQuery
                oReader = oCommand.ExecuteReader
                If oReader.Read() Then
                    txtZairyouLotNo.Text = GetString(oReader(0))
                End If
                oReader.Close()
            Else
                If Not GetString(Fields("ORIGIN_PARTS_NO").Value).Trim.Equals("") Then
                    sQuery = "SELECT C.LOT_NO FROM PARTS_MST A,(SELECT INDICATE_NO,COMPANY_NO,MAX(SHIP_NO) SHIP_NO FROM MATL_SHIP_TBL GROUP BY INDICATE_NO,COMPANY_NO) B,MATL_SHIP_TBL C "
                    sQuery += "WHERE A.COMPANY_NO = B.COMPANY_NO AND (B.INDICATE_NO = C.INDICATE_NO AND B.COMPANY_NO = C.COMPANY_NO AND B.SHIP_NO = C.SHIP_NO) AND "
                    sQuery += "A.CATALOG_NO = '" + GetString(Fields("USE_ORG_PARTS_NO").Value) + "' AND B.INDICATE_NO = '" + GetString(Fields("ORIGIN_PARTS_NO").Value) + "'"
                    oCommand = _oMedicalConnect.CreateCommand()
                    oCommand.CommandText = sQuery
                    oReader = oCommand.ExecuteReader
                    If oReader.Read() Then
                        txtZairyouLotNo.Text = GetString(oReader(0))
                    End If
                    oReader.Close()
                End If
            End If
            '納期 
            If GetDate(Fields("DELIVERY_DT").Value) <> "" Then
                txtNouki.Text = GetDate(Fields("DELIVERY_DT").Value).Substring(4, 2) + "/" + GetDate(Fields("DELIVERY_DT").Value).Substring(6, 2)
            Else
                txtNouki.Text = ""
            End If
        End If
        _nPage += 1
    End Sub

    'ディテール　親工程存在時　コメント欄に親工程追加
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

        If GetString(Fields("WORK_COMMENT").Value) <> "" Then
            TextBox37.Text = "ｺﾒﾝﾄ:" + GetString(Fields("WORK_COMMENT").Value)
        End If

        Dim sQuery As String = ""
        Dim oCommand As OracleCommand = Nothing
        Dim oReader As OracleDataReader = Nothing

        sQuery = "SELECT P.PER_PROCESS_CD,P_ORDER_NM FROM P_PROCESS_MST P , PROCESS_MST M "
        sQuery += "WHERE P.CATALOG_NO = '" + GetString(Fields("CATALOG_NO").Value) + "'"
        sQuery += " AND P.P_ORDER_MAIN = '" + GetString(Fields("P_ORDER_MAIN").Value) + "'"
        sQuery += " AND P.P_ORDER_SUB = '" + GetString(Fields("P_ORDER_SUB").Value) + "'"
        sQuery += " AND P.PER_PROCESS_CD = M.PROCESS_CD(+) "

        oCommand = _oMedicalConnect.CreateCommand()
        oCommand.CommandText = sQuery
        oReader = oCommand.ExecuteReader
        If oReader.Read() Then
            If GetString(oReader(0)) <> "" Then
                TextBox37.Text = GetString(oReader(1)) + "　"
                If GetString(Fields("WORK_COMMENT").Value) <> "" Then
                    TextBox37.Text += "ｺﾒﾝﾄ:" + GetString(Fields("WORK_COMMENT").Value)
                End If
            End If
        End If

        oReader.Close()

    End Sub

#Region " その他 "

    Private Function GetString(ByVal oValue As Object) As String
        If oValue Is Nothing Then Return ""
        If IsDBNull(oValue) Then Return ""
        Return CType(oValue, String).Trim()
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

End Class 
