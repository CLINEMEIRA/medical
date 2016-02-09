Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports System
Imports Microsoft.VisualBasic
Imports System.Data.OracleClient

Public Class mdlst010
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
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private Label40 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtCOR_MARK As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOR_ARTICLE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtDate1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCREATOR_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtRECOGNIZER_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtTuutisyo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtGenseitei As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtSakusei As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSyounin As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtTeifu As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label41 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtTekiyou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label42 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label43 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label44 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtMotoCatalog As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtO_SKETCH_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPARTS_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtITEM_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMATL_SPEC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtMATL_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtMATL_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSozai As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTani As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTanju As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtSunpouKubun1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB02 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB03 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB04 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB05 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB06 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB07 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB08 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB09 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMEASURE_KB10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSunpou10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtC_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtGRP_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt社内番号 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtテストピース As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtMekkin As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtトルクスNO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt軸荒径 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txt材料径 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtネジ外径 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label26 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label29 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtHanbaiName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSyuruiName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSyouninBangou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtIppanName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label35 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label36 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label38 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label39 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label50 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private TextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtUM_P_ORDER As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtP_ORDER_MAIN As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtP_ORDER_SUB As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtPROCESS_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txt設備 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtFACILITIES_G_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSHOP As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private txtP_ORDER_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtP_COMMENT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private SubReport As GrapeCity.ActiveReports.SectionReportModel.SubReport
    Private txtCatalog As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKakou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line

    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdlst010))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtMotoCatalog = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtO_SKETCH_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCatalog = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtKakou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtPARTS_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtITEM_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMATL_SPEC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtMATL_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtMATL_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSozai = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTani = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTanju = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSunpouKubun1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB02 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB03 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB04 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB05 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB06 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB07 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB08 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB09 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMEASURE_KB10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSunpou10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtC_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGRP_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt社内番号 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtテストピース = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtMekkin = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtトルクスNO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt軸荒径 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txt材料径 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtネジ外径 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label26 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label29 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtHanbaiName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSyuruiName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSyouninBangou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtIppanName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label35 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label36 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label38 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label39 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label50 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtUM_P_ORDER = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtP_ORDER_MAIN = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtP_ORDER_SUB = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtPROCESS_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txt設備 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtFACILITIES_G_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSHOP = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtP_ORDER_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtP_COMMENT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.SubReport = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMotoCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtO_SKETCH_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKakou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPARTS_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtITEM_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMATL_SPEC, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMATL_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMATL_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSozai, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTani, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTanju, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpouKubun1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB02, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB03, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB04, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB05, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB06, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB07, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB08, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB09, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMEASURE_KB10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSunpou10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtC_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGRP_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt社内番号, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtテストピース, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMekkin, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtトルクスNO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt軸荒径, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt材料径, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtネジ外径, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHanbaiName, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyuruiName, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyouninBangou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtIppanName, System.ComponentModel.ISupportInitialize).BeginInit
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
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtUM_P_ORDER, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtP_ORDER_MAIN, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtP_ORDER_SUB, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPROCESS_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txt設備, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtFACILITIES_G_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSHOP, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtP_ORDER_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtP_COMMENT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtUM_P_ORDER, Me.Line35, Me.Line37, Me.Line38, Me.txtP_ORDER_MAIN, Me.txtP_ORDER_SUB, Me.Line42, Me.txtPROCESS_CD, Me.Line43, Me.txt設備, Me.Line45, Me.txtFACILITIES_G_CD, Me.txtSHOP, Me.Line48, Me.Line49, Me.txtP_ORDER_NM, Me.txtP_COMMENT})
        Me.Detail.Height = 0.3333333!
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
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.txtMotoCatalog, Me.txtO_SKETCH_NO, Me.Label5, Me.Line, Me.Line1, Me.Line2, Me.txtCatalog, Me.Label6, Me.Line4, Me.txtKakou, Me.Label7, Me.txtPARTS_NM, Me.Label8, Me.Line6, Me.Label10, Me.txtITEM_NM, Me.txtMATL_SPEC, Me.Label11, Me.Line8, Me.Line9, Me.txtMATL_CD, Me.Label12, Me.Line11, Me.txtMATL_NM, Me.Label13, Me.Line12, Me.Label14, Me.Label15, Me.txtSozai, Me.txtTani, Me.txtTanju, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line23, Me.txtSunpouKubun1, Me.txtSunpou1, Me.txtMEASURE_KB02, Me.txtSunpou2, Me.txtMEASURE_KB03, Me.txtSunpou3, Me.txtSunpou4, Me.txtMEASURE_KB04, Me.txtMEASURE_KB05, Me.txtSunpou5, Me.txtMEASURE_KB06, Me.txtSunpou6, Me.txtMEASURE_KB07, Me.txtSunpou7, Me.txtMEASURE_KB08, Me.txtSunpou8, Me.txtMEASURE_KB09, Me.txtSunpou9, Me.txtMEASURE_KB10, Me.txtSunpou10, Me.Label16, Me.txtC_NO, Me.Line24, Me.Line25, Me.Label17, Me.txtGRP_CD, Me.txt社内番号, Me.Label18, Me.txtテストピース, Me.Label19, Me.txtMekkin, Me.Line27, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.txtトルクスNO, Me.txt軸荒径, Me.txt材料径, Me.txtネジ外径, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.txtHanbaiName, Me.txtSyuruiName, Me.txtSyouninBangou, Me.txtIppanName, Me.Line34, Me.Label30, Me.Line39, Me.Line40, Me.Label31, Me.Label32, Me.Label33, Me.Line41, Me.Label34, Me.Line44, Me.Line46, Me.Label35, Me.Label36, Me.Label37, Me.Line47, Me.Label38, Me.Label39, Me.Line50, Me.lblDate, Me.Label, Me.lblPage, Me.Line26, Me.Line63, Me.Line64, Me.Line3, Me.Line5, Me.Label9, Me.Label24, Me.Label25, Me.Label50, Me.Line7, Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.Line53})
        Me.GroupHeader1.DataField = "CATALOG_NO"
        Me.GroupHeader1.Height = 3.332639!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line51, Me.SubReport})
        Me.GroupFooter1.Height = 0.1354167!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
        '
        'Label1
        '
        Me.Label1.Height = 0.2666667!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.2000005!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 12pt; vertical-align: bottom"
        Me.Label1.Text = "工程品質管理表"
        Me.Label1.Top = 0.1333333!
        Me.Label1.Width = 1.266667!
        '
        'Label2
        '
        Me.Label2.Height = 0.2000001!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.533334!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 11.25pt; vertical-align: bottom"
        Me.Label2.Text = "照会印刷"
        Me.Label2.Top = 0.2!
        Me.Label2.Width = 0.7333333!
        '
        'Label3
        '
        Me.Label3.Height = 0.2000001!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.4!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 9.75pt; vertical-align: bottom"
        Me.Label3.Text = "部品番号"
        Me.Label3.Top = 0.2!
        Me.Label3.Width = 0.6000001!
        '
        'txtMotoCatalog
        '
        Me.txtMotoCatalog.DataField = "O_CATALOG_NO"
        Me.txtMotoCatalog.Height = 0.2666667!
        Me.txtMotoCatalog.Left = 3.133333!
        Me.txtMotoCatalog.Name = "txtMotoCatalog"
        Me.txtMotoCatalog.Style = "font-size: 12pt; vertical-align: bottom"
        Me.txtMotoCatalog.Text = "元カタログ番号"
        Me.txtMotoCatalog.Top = 0.1333333!
        Me.txtMotoCatalog.Width = 2.466667!
        '
        'txtO_SKETCH_NO
        '
        Me.txtO_SKETCH_NO.DataField = "O_SKETCH_NO"
        Me.txtO_SKETCH_NO.Height = 0.2!
        Me.txtO_SKETCH_NO.Left = 0.4000006!
        Me.txtO_SKETCH_NO.Name = "txtO_SKETCH_NO"
        Me.txtO_SKETCH_NO.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtO_SKETCH_NO.Text = "原図面番号"
        Me.txtO_SKETCH_NO.Top = 0.7333333!
        Me.txtO_SKETCH_NO.Width = 1.333333!
        '
        'Label5
        '
        Me.Label5.Height = 0.2000001!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.2666672!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label5.Text = "原図面番号"
        Me.Label5.Top = 0.5333334!
        Me.Label5.Width = 0.6666667!
        '
        'Line
        '
        Me.Line.Height = 2.8!
        Me.Line.Left = 0.2!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.5333334!
        Me.Line.Width = 0!
        Me.Line.X1 = 0.2!
        Me.Line.X2 = 0.2!
        Me.Line.Y1 = 0.5333334!
        Me.Line.Y2 = 3.333333!
        '
        'Line1
        '
        Me.Line1.Height = 3.576279E-07!
        Me.Line1.Left = 0.2000003!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.5333331!
        Me.Line1.Width = 7.333333!
        Me.Line1.X1 = 0.2000003!
        Me.Line1.X2 = 7.533333!
        Me.Line1.Y1 = 0.5333331!
        Me.Line1.Y2 = 0.5333334!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0.2000005!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.9333333!
        Me.Line2.Width = 7.333333!
        Me.Line2.X1 = 0.2000005!
        Me.Line2.X2 = 7.533333!
        Me.Line2.Y1 = 0.9333333!
        Me.Line2.Y2 = 0.9333333!
        '
        'txtCatalog
        '
        Me.txtCatalog.DataField = "CATALOG_NO"
        Me.txtCatalog.Height = 0.2!
        Me.txtCatalog.Left = 2.066667!
        Me.txtCatalog.Name = "txtCatalog"
        Me.txtCatalog.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtCatalog.Text = "12345678901234567"
        Me.txtCatalog.Top = 0.7333333!
        Me.txtCatalog.Width = 1.333333!
        '
        'Label6
        '
        Me.Label6.Height = 0.2000001!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.933333!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label6.Text = "マスタカタログ番号"
        Me.Label6.Top = 0.5333334!
        Me.Label6.Width = 1.266667!
        '
        'Line4
        '
        Me.Line4.Height = 0.3999999!
        Me.Line4.Left = 3.466667!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.5333334!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 3.466667!
        Me.Line4.X2 = 3.466667!
        Me.Line4.Y1 = 0.5333334!
        Me.Line4.Y2 = 0.9333333!
        '
        'txtKakou
        '
        Me.txtKakou.DataField = "WORK_STD_NO"
        Me.txtKakou.Height = 0.2!
        Me.txtKakou.Left = 3.6!
        Me.txtKakou.Name = "txtKakou"
        Me.txtKakou.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtKakou.Text = "作業標準管理NO"
        Me.txtKakou.Top = 0.7333333!
        Me.txtKakou.Width = 1.266667!
        '
        'Label7
        '
        Me.Label7.Height = 0.1999999!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.533333!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label7.Text = "加工図管理番号"
        Me.Label7.Top = 0.5333334!
        Me.Label7.Width = 1!
        '
        'txtPARTS_NM
        '
        Me.txtPARTS_NM.DataField = "PARTS_NM"
        Me.txtPARTS_NM.Height = 0.2!
        Me.txtPARTS_NM.Left = 5.066667!
        Me.txtPARTS_NM.Name = "txtPARTS_NM"
        Me.txtPARTS_NM.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtPARTS_NM.Text = "部品名称"
        Me.txtPARTS_NM.Top = 0.7333333!
        Me.txtPARTS_NM.Width = 2.4!
        '
        'Label8
        '
        Me.Label8.Height = 0.2000001!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label8.Text = "部品名称"
        Me.Label8.Top = 0.5333334!
        Me.Label8.Width = 0.6000001!
        '
        'Line6
        '
        Me.Line6.Height = 0!
        Me.Line6.Left = 0.2000005!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.333333!
        Me.Line6.Width = 7.333333!
        Me.Line6.X1 = 0.2000005!
        Me.Line6.X2 = 7.533333!
        Me.Line6.Y1 = 1.333333!
        Me.Line6.Y2 = 1.333333!
        '
        'Label10
        '
        Me.Label10.Height = 0.2000001!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 4.266667!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label10.Text = "梱包表示"
        Me.Label10.Top = 1.733333!
        Me.Label10.Width = 0.7333333!
        '
        'txtITEM_NM
        '
        Me.txtITEM_NM.DataField = "梱包表示"
        Me.txtITEM_NM.Height = 0.2!
        Me.txtITEM_NM.Left = 4.333333!
        Me.txtITEM_NM.MultiLine = false
        Me.txtITEM_NM.Name = "txtITEM_NM"
        Me.txtITEM_NM.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtITEM_NM.Text = "項目名"
        Me.txtITEM_NM.Top = 1.933333!
        Me.txtITEM_NM.Width = 2.4!
        '
        'txtMATL_SPEC
        '
        Me.txtMATL_SPEC.DataField = "MATL_SPEC"
        Me.txtMATL_SPEC.Height = 0.2!
        Me.txtMATL_SPEC.Left = 0.3333339!
        Me.txtMATL_SPEC.Name = "txtMATL_SPEC"
        Me.txtMATL_SPEC.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMATL_SPEC.Text = "材料SPEC"
        Me.txtMATL_SPEC.Top = 1.133333!
        Me.txtMATL_SPEC.Width = 1.266667!
        '
        'Label11
        '
        Me.Label11.Height = 0.2000001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.2666672!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label11.Text = "材料SPEC"
        Me.Label11.Top = 0.9333333!
        Me.Label11.Width = 0.6000001!
        '
        'Line8
        '
        Me.Line8.Height = 0.4000006!
        Me.Line8.Left = 1.733335!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.9333333!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 1.733335!
        Me.Line8.X2 = 1.733335!
        Me.Line8.Y1 = 0.9333333!
        Me.Line8.Y2 = 1.333334!
        '
        'Line9
        '
        Me.Line9.Height = 0.4000006!
        Me.Line9.Left = 3.266667!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.9333333!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 3.266667!
        Me.Line9.X2 = 3.266667!
        Me.Line9.Y1 = 0.9333333!
        Me.Line9.Y2 = 1.333334!
        '
        'txtMATL_CD
        '
        Me.txtMATL_CD.DataField = "MATL_CD"
        Me.txtMATL_CD.Height = 0.2!
        Me.txtMATL_CD.Left = 1.866667!
        Me.txtMATL_CD.Name = "txtMATL_CD"
        Me.txtMATL_CD.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMATL_CD.Text = "主材料コード"
        Me.txtMATL_CD.Top = 1.133333!
        Me.txtMATL_CD.Width = 1.266667!
        '
        'Label12
        '
        Me.Label12.Height = 0.2000001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 1.800001!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label12.Text = "材料コード"
        Me.Label12.Top = 0.9333333!
        Me.Label12.Width = 0.7333333!
        '
        'Line11
        '
        Me.Line11.Height = 0.4000013!
        Me.Line11.Left = 4.866666!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.9333333!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 4.866666!
        Me.Line11.X2 = 4.866666!
        Me.Line11.Y1 = 0.9333333!
        Me.Line11.Y2 = 1.333335!
        '
        'txtMATL_NM
        '
        Me.txtMATL_NM.DataField = "MATL_NM"
        Me.txtMATL_NM.Height = 0.2!
        Me.txtMATL_NM.Left = 3.466667!
        Me.txtMATL_NM.Name = "txtMATL_NM"
        Me.txtMATL_NM.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMATL_NM.Text = "主材料名称"
        Me.txtMATL_NM.Top = 1.133333!
        Me.txtMATL_NM.Width = 1.333333!
        '
        'Label13
        '
        Me.Label13.Height = 0.2000001!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 3.333333!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label13.Text = "材料名"
        Me.Label13.Top = 0.9333333!
        Me.Label13.Width = 0.7333333!
        '
        'Line12
        '
        Me.Line12.Height = 2.8!
        Me.Line12.Left = 7.533333!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.5333334!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 7.533333!
        Me.Line12.X2 = 7.533333!
        Me.Line12.Y1 = 0.5333334!
        Me.Line12.Y2 = 3.333333!
        '
        'Label14
        '
        Me.Label14.Height = 0.2000001!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 4.933334!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label14.Text = "単位素材"
        Me.Label14.Top = 0.9333333!
        Me.Label14.Width = 0.7333333!
        '
        'Label15
        '
        Me.Label15.Height = 0.2000001!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 6.466667!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label15.Text = "単重(g)"
        Me.Label15.Top = 0.9333333!
        Me.Label15.Width = 0.7333333!
        '
        'txtSozai
        '
        Me.txtSozai.DataField = "UNIT_MATL_WAT"
        Me.txtSozai.Height = 0.2!
        Me.txtSozai.Left = 5!
        Me.txtSozai.Name = "txtSozai"
        Me.txtSozai.OutputFormat = resources.GetString("txtSozai.OutputFormat")
        Me.txtSozai.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSozai.Text = "単位素材量"
        Me.txtSozai.Top = 1.133333!
        Me.txtSozai.Width = 0.8666667!
        '
        'txtTani
        '
        Me.txtTani.DataField = "MATL_PRICE_KB"
        Me.txtTani.Height = 0.2!
        Me.txtTani.Left = 5.933334!
        Me.txtTani.Name = "txtTani"
        Me.txtTani.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtTani.Text = "XXXX"
        Me.txtTani.Top = 1.133333!
        Me.txtTani.Width = 0.4000001!
        '
        'txtTanju
        '
        Me.txtTanju.DataField = "MATL_WAT"
        Me.txtTanju.Height = 0.2!
        Me.txtTanju.Left = 6.600001!
        Me.txtTanju.Name = "txtTanju"
        Me.txtTanju.OutputFormat = resources.GetString("txtTanju.OutputFormat")
        Me.txtTanju.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtTanju.Text = "素材単重"
        Me.txtTanju.Top = 1.133333!
        Me.txtTanju.Width = 0.8666667!
        '
        'Line13
        '
        Me.Line13.Height = 0.4000028!
        Me.Line13.Left = 6.400002!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.9333333!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 6.400002!
        Me.Line13.X2 = 6.400002!
        Me.Line13.Y1 = 0.9333333!
        Me.Line13.Y2 = 1.333336!
        '
        'Line14
        '
        Me.Line14.Height = 0.4000001!
        Me.Line14.Left = 0.933334!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 1.333334!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 0.933334!
        Me.Line14.X2 = 0.933334!
        Me.Line14.Y1 = 1.333334!
        Me.Line14.Y2 = 1.733334!
        '
        'Line15
        '
        Me.Line15.Height = 0.3999994!
        Me.Line15.Left = 1.666667!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 1.333334!
        Me.Line15.Width = 1.430511E-06!
        Me.Line15.X1 = 1.666668!
        Me.Line15.X2 = 1.666667!
        Me.Line15.Y1 = 1.333334!
        Me.Line15.Y2 = 1.733333!
        '
        'Line16
        '
        Me.Line16.Height = 0.4000007!
        Me.Line16.Left = 2.4!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 1.333333!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 2.4!
        Me.Line16.X2 = 2.4!
        Me.Line16.Y1 = 1.333333!
        Me.Line16.Y2 = 1.733334!
        '
        'Line17
        '
        Me.Line17.Height = 0.400002!
        Me.Line17.Left = 3.133333!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 1.333335!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 3.133333!
        Me.Line17.X2 = 3.133333!
        Me.Line17.Y1 = 1.333335!
        Me.Line17.Y2 = 1.733337!
        '
        'Line18
        '
        Me.Line18.Height = 0.3999972!
        Me.Line18.Left = 3.866667!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 1.333336!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 3.866667!
        Me.Line18.X2 = 3.866667!
        Me.Line18.Y1 = 1.333336!
        Me.Line18.Y2 = 1.733333!
        '
        'Line19
        '
        Me.Line19.Height = 0.8000001!
        Me.Line19.Left = 6.8!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 1.333333!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 6.8!
        Me.Line19.X2 = 6.8!
        Me.Line19.Y1 = 1.333333!
        Me.Line19.Y2 = 2.133333!
        '
        'Line20
        '
        Me.Line20.Height = 0.4000007!
        Me.Line20.Left = 4.600001!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 1.333333!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 4.600001!
        Me.Line20.X2 = 4.600001!
        Me.Line20.Y1 = 1.333333!
        Me.Line20.Y2 = 1.733334!
        '
        'Line21
        '
        Me.Line21.Height = 0.4000014!
        Me.Line21.Left = 5.333332!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 1.333338!
        Me.Line21.Width = 0!
        Me.Line21.X1 = 5.333332!
        Me.Line21.X2 = 5.333332!
        Me.Line21.Y1 = 1.333338!
        Me.Line21.Y2 = 1.73334!
        '
        'Line23
        '
        Me.Line23.Height = 7.152557E-07!
        Me.Line23.Left = 0.2000005!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 1.733333!
        Me.Line23.Width = 7.333333!
        Me.Line23.X1 = 0.2000005!
        Me.Line23.X2 = 7.533333!
        Me.Line23.Y1 = 1.733334!
        Me.Line23.Y2 = 1.733333!
        '
        'txtSunpouKubun1
        '
        Me.txtSunpouKubun1.DataField = "MEASURE_KB01"
        Me.txtSunpouKubun1.Height = 0.2!
        Me.txtSunpouKubun1.Left = 0.2666672!
        Me.txtSunpouKubun1.Name = "txtSunpouKubun1"
        Me.txtSunpouKubun1.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtSunpouKubun1.Text = "XX"
        Me.txtSunpouKubun1.Top = 1.333333!
        Me.txtSunpouKubun1.Width = 0.6000001!
        '
        'txtSunpou1
        '
        Me.txtSunpou1.DataField = "MEASURE_01"
        Me.txtSunpou1.Height = 0.2!
        Me.txtSunpou1.Left = 0.2666672!
        Me.txtSunpou1.Name = "txtSunpou1"
        Me.txtSunpou1.OutputFormat = resources.GetString("txtSunpou1.OutputFormat")
        Me.txtSunpou1.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou1.Text = "寸法１"
        Me.txtSunpou1.Top = 1.533333!
        Me.txtSunpou1.Width = 0.6000001!
        '
        'txtMEASURE_KB02
        '
        Me.txtMEASURE_KB02.DataField = "MEASURE_KB02"
        Me.txtMEASURE_KB02.Height = 0.2!
        Me.txtMEASURE_KB02.Left = 1.000001!
        Me.txtMEASURE_KB02.Name = "txtMEASURE_KB02"
        Me.txtMEASURE_KB02.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB02.Text = "XX"
        Me.txtMEASURE_KB02.Top = 1.333333!
        Me.txtMEASURE_KB02.Width = 0.6000001!
        '
        'txtSunpou2
        '
        Me.txtSunpou2.DataField = "MEASURE_02"
        Me.txtSunpou2.Height = 0.2!
        Me.txtSunpou2.Left = 1.000001!
        Me.txtSunpou2.Name = "txtSunpou2"
        Me.txtSunpou2.OutputFormat = resources.GetString("txtSunpou2.OutputFormat")
        Me.txtSunpou2.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou2.Text = "寸法２"
        Me.txtSunpou2.Top = 1.533333!
        Me.txtSunpou2.Width = 0.6000001!
        '
        'txtMEASURE_KB03
        '
        Me.txtMEASURE_KB03.DataField = "MEASURE_KB03"
        Me.txtMEASURE_KB03.Height = 0.2!
        Me.txtMEASURE_KB03.Left = 1.733334!
        Me.txtMEASURE_KB03.Name = "txtMEASURE_KB03"
        Me.txtMEASURE_KB03.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB03.Text = "XX"
        Me.txtMEASURE_KB03.Top = 1.333333!
        Me.txtMEASURE_KB03.Width = 0.6000001!
        '
        'txtSunpou3
        '
        Me.txtSunpou3.DataField = "MEASURE_03"
        Me.txtSunpou3.Height = 0.2!
        Me.txtSunpou3.Left = 1.733334!
        Me.txtSunpou3.Name = "txtSunpou3"
        Me.txtSunpou3.OutputFormat = resources.GetString("txtSunpou3.OutputFormat")
        Me.txtSunpou3.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou3.Text = "寸法３"
        Me.txtSunpou3.Top = 1.533333!
        Me.txtSunpou3.Width = 0.6000001!
        '
        'txtSunpou4
        '
        Me.txtSunpou4.DataField = "MEASURE_04"
        Me.txtSunpou4.Height = 0.2!
        Me.txtSunpou4.Left = 2.466667!
        Me.txtSunpou4.Name = "txtSunpou4"
        Me.txtSunpou4.OutputFormat = resources.GetString("txtSunpou4.OutputFormat")
        Me.txtSunpou4.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou4.Text = "寸法４"
        Me.txtSunpou4.Top = 1.533333!
        Me.txtSunpou4.Width = 0.5999999!
        '
        'txtMEASURE_KB04
        '
        Me.txtMEASURE_KB04.DataField = "MEASURE_KB04"
        Me.txtMEASURE_KB04.Height = 0.2!
        Me.txtMEASURE_KB04.Left = 2.466667!
        Me.txtMEASURE_KB04.Name = "txtMEASURE_KB04"
        Me.txtMEASURE_KB04.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB04.Text = "XX"
        Me.txtMEASURE_KB04.Top = 1.333333!
        Me.txtMEASURE_KB04.Width = 0.5999999!
        '
        'txtMEASURE_KB05
        '
        Me.txtMEASURE_KB05.DataField = "MEASURE_KB05"
        Me.txtMEASURE_KB05.Height = 0.2!
        Me.txtMEASURE_KB05.Left = 3.2!
        Me.txtMEASURE_KB05.Name = "txtMEASURE_KB05"
        Me.txtMEASURE_KB05.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB05.Text = "XX"
        Me.txtMEASURE_KB05.Top = 1.333333!
        Me.txtMEASURE_KB05.Width = 0.5999999!
        '
        'txtSunpou5
        '
        Me.txtSunpou5.DataField = "MEASURE_05"
        Me.txtSunpou5.Height = 0.2!
        Me.txtSunpou5.Left = 3.2!
        Me.txtSunpou5.Name = "txtSunpou5"
        Me.txtSunpou5.OutputFormat = resources.GetString("txtSunpou5.OutputFormat")
        Me.txtSunpou5.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou5.Text = "寸法５"
        Me.txtSunpou5.Top = 1.533333!
        Me.txtSunpou5.Width = 0.5999999!
        '
        'txtMEASURE_KB06
        '
        Me.txtMEASURE_KB06.DataField = "MEASURE_KB06"
        Me.txtMEASURE_KB06.Height = 0.2!
        Me.txtMEASURE_KB06.Left = 3.933333!
        Me.txtMEASURE_KB06.Name = "txtMEASURE_KB06"
        Me.txtMEASURE_KB06.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB06.Text = "XX"
        Me.txtMEASURE_KB06.Top = 1.333333!
        Me.txtMEASURE_KB06.Width = 0.6000003!
        '
        'txtSunpou6
        '
        Me.txtSunpou6.DataField = "MEASURE_06"
        Me.txtSunpou6.Height = 0.2!
        Me.txtSunpou6.Left = 3.933333!
        Me.txtSunpou6.Name = "txtSunpou6"
        Me.txtSunpou6.OutputFormat = resources.GetString("txtSunpou6.OutputFormat")
        Me.txtSunpou6.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou6.Text = "寸法６"
        Me.txtSunpou6.Top = 1.533333!
        Me.txtSunpou6.Width = 0.6000003!
        '
        'txtMEASURE_KB07
        '
        Me.txtMEASURE_KB07.DataField = "MEASURE_KB07"
        Me.txtMEASURE_KB07.Height = 0.2!
        Me.txtMEASURE_KB07.Left = 4.666667!
        Me.txtMEASURE_KB07.Name = "txtMEASURE_KB07"
        Me.txtMEASURE_KB07.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB07.Text = "XX"
        Me.txtMEASURE_KB07.Top = 1.333333!
        Me.txtMEASURE_KB07.Width = 0.5999999!
        '
        'txtSunpou7
        '
        Me.txtSunpou7.DataField = "MEASURE_07"
        Me.txtSunpou7.Height = 0.2!
        Me.txtSunpou7.Left = 4.666667!
        Me.txtSunpou7.Name = "txtSunpou7"
        Me.txtSunpou7.OutputFormat = resources.GetString("txtSunpou7.OutputFormat")
        Me.txtSunpou7.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou7.Text = "寸法７"
        Me.txtSunpou7.Top = 1.533333!
        Me.txtSunpou7.Width = 0.5999999!
        '
        'txtMEASURE_KB08
        '
        Me.txtMEASURE_KB08.DataField = "MEASURE_KB08"
        Me.txtMEASURE_KB08.Height = 0.2!
        Me.txtMEASURE_KB08.Left = 5.400001!
        Me.txtMEASURE_KB08.Name = "txtMEASURE_KB08"
        Me.txtMEASURE_KB08.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB08.Text = "XX"
        Me.txtMEASURE_KB08.Top = 1.333333!
        Me.txtMEASURE_KB08.Width = 0.5999999!
        '
        'txtSunpou8
        '
        Me.txtSunpou8.DataField = "MEASURE_08"
        Me.txtSunpou8.Height = 0.2!
        Me.txtSunpou8.Left = 5.400001!
        Me.txtSunpou8.Name = "txtSunpou8"
        Me.txtSunpou8.OutputFormat = resources.GetString("txtSunpou8.OutputFormat")
        Me.txtSunpou8.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou8.Text = "寸法８"
        Me.txtSunpou8.Top = 1.533333!
        Me.txtSunpou8.Width = 0.5999999!
        '
        'txtMEASURE_KB09
        '
        Me.txtMEASURE_KB09.DataField = "MEASURE_KB09"
        Me.txtMEASURE_KB09.Height = 0.2!
        Me.txtMEASURE_KB09.Left = 6.133335!
        Me.txtMEASURE_KB09.Name = "txtMEASURE_KB09"
        Me.txtMEASURE_KB09.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB09.Text = "XX"
        Me.txtMEASURE_KB09.Top = 1.333333!
        Me.txtMEASURE_KB09.Width = 0.5999999!
        '
        'txtSunpou9
        '
        Me.txtSunpou9.DataField = "MEASURE_09"
        Me.txtSunpou9.Height = 0.2!
        Me.txtSunpou9.Left = 6.133335!
        Me.txtSunpou9.Name = "txtSunpou9"
        Me.txtSunpou9.OutputFormat = resources.GetString("txtSunpou9.OutputFormat")
        Me.txtSunpou9.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou9.Text = "寸法９"
        Me.txtSunpou9.Top = 1.533333!
        Me.txtSunpou9.Width = 0.5999999!
        '
        'txtMEASURE_KB10
        '
        Me.txtMEASURE_KB10.DataField = "MEASURE_KB10"
        Me.txtMEASURE_KB10.Height = 0.2!
        Me.txtMEASURE_KB10.Left = 6.866668!
        Me.txtMEASURE_KB10.Name = "txtMEASURE_KB10"
        Me.txtMEASURE_KB10.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtMEASURE_KB10.Text = "XX"
        Me.txtMEASURE_KB10.Top = 1.333333!
        Me.txtMEASURE_KB10.Width = 0.5999999!
        '
        'txtSunpou10
        '
        Me.txtSunpou10.DataField = "MEASURE_10"
        Me.txtSunpou10.Height = 0.2!
        Me.txtSunpou10.Left = 6.866668!
        Me.txtSunpou10.Name = "txtSunpou10"
        Me.txtSunpou10.OutputFormat = resources.GetString("txtSunpou10.OutputFormat")
        Me.txtSunpou10.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtSunpou10.Text = "寸法１０"
        Me.txtSunpou10.Top = 1.533333!
        Me.txtSunpou10.Width = 0.5999999!
        '
        'Label16
        '
        Me.Label16.Height = 0.2000001!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.2666672!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label16.Text = "組番"
        Me.Label16.Top = 1.733333!
        Me.Label16.Width = 0.3333333!
        '
        'txtC_NO
        '
        Me.txtC_NO.DataField = "C_NO"
        Me.txtC_NO.Height = 0.2!
        Me.txtC_NO.Left = 0.333334!
        Me.txtC_NO.Name = "txtC_NO"
        Me.txtC_NO.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtC_NO.Text = "組番"
        Me.txtC_NO.Top = 1.933333!
        Me.txtC_NO.Width = 0.3333335!
        '
        'Line24
        '
        Me.Line24.Height = 0.3999999!
        Me.Line24.Left = 0.733334!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 1.733334!
        Me.Line24.Width = 0!
        Me.Line24.X1 = 0.733334!
        Me.Line24.X2 = 0.733334!
        Me.Line24.Y1 = 1.733334!
        Me.Line24.Y2 = 2.133334!
        '
        'Line25
        '
        Me.Line25.Height = 1.192093E-06!
        Me.Line25.Left = 0.2000005!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 2.133333!
        Me.Line25.Width = 7.333333!
        Me.Line25.X1 = 0.2000005!
        Me.Line25.X2 = 7.533333!
        Me.Line25.Y1 = 2.133335!
        Me.Line25.Y2 = 2.133333!
        '
        'Label17
        '
        Me.Label17.Height = 0.2000001!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.8000007!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label17.Text = "社内№"
        Me.Label17.Top = 1.733333!
        Me.Label17.Width = 0.4666668!
        '
        'txtGRP_CD
        '
        Me.txtGRP_CD.DataField = "GRP_CD"
        Me.txtGRP_CD.Height = 0.2!
        Me.txtGRP_CD.Left = 0.933334!
        Me.txtGRP_CD.Name = "txtGRP_CD"
        Me.txtGRP_CD.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtGRP_CD.Text = "グループコード"
        Me.txtGRP_CD.Top = 1.933333!
        Me.txtGRP_CD.Width = 0.1333335!
        '
        'txt社内番号
        '
        Me.txt社内番号.DataField = "COMPANY_NO"
        Me.txt社内番号.Height = 0.2!
        Me.txt社内番号.Left = 1.066667!
        Me.txt社内番号.Name = "txt社内番号"
        Me.txt社内番号.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txt社内番号.Text = "社内番号"
        Me.txt社内番号.Top = 1.933333!
        Me.txt社内番号.Width = 0.466667!
        '
        'Label18
        '
        Me.Label18.Height = 0.2000001!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 1.666668!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label18.Text = "テストピース"
        Me.Label18.Top = 1.733334!
        Me.Label18.Width = 0.866666!
        '
        'txtテストピース
        '
        Me.txtテストピース.DataField = "テストピース"
        Me.txtテストピース.Height = 0.2!
        Me.txtテストピース.Left = 1.733334!
        Me.txtテストピース.MultiLine = false
        Me.txtテストピース.Name = "txtテストピース"
        Me.txtテストピース.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtテストピース.Text = "テストピース"
        Me.txtテストピース.Top = 1.933333!
        Me.txtテストピース.Width = 2.399999!
        '
        'Label19
        '
        Me.Label19.Height = 0.2000001!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 6.800005!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom"
        Me.Label19.Text = "滅菌品区分"
        Me.Label19.Top = 1.733329!
        Me.Label19.Width = 0.7333326!
        '
        'txtMekkin
        '
        Me.txtMekkin.DataField = "STERILIZE_KB"
        Me.txtMekkin.Height = 0.2!
        Me.txtMekkin.Left = 6.799999!
        Me.txtMekkin.Name = "txtMekkin"
        Me.txtMekkin.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.txtMekkin.Text = "滅菌品区分"
        Me.txtMekkin.Top = 1.933333!
        Me.txtMekkin.Width = 0.733334!
        '
        'Line27
        '
        Me.Line27.Height = 0.7999995!
        Me.Line27.Left = 2.066667!
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 2.133334!
        Me.Line27.Width = 1.430511E-06!
        Me.Line27.X1 = 2.066668!
        Me.Line27.X2 = 2.066667!
        Me.Line27.Y1 = 2.133334!
        Me.Line27.Y2 = 2.933333!
        '
        'Line28
        '
        Me.Line28.Height = 0.7999973!
        Me.Line28.Left = 3.933333!
        Me.Line28.LineWeight = 1!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 2.133336!
        Me.Line28.Width = 0!
        Me.Line28.X1 = 3.933333!
        Me.Line28.X2 = 3.933333!
        Me.Line28.Y1 = 2.133336!
        Me.Line28.Y2 = 2.933333!
        '
        'Line29
        '
        Me.Line29.Height = 0.4000001!
        Me.Line29.Left = 5.733333!
        Me.Line29.LineWeight = 1!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 2.533333!
        Me.Line29.Width = 0!
        Me.Line29.X1 = 5.733333!
        Me.Line29.X2 = 5.733333!
        Me.Line29.Y1 = 2.533333!
        Me.Line29.Y2 = 2.933333!
        '
        'Line30
        '
        Me.Line30.Height = 0.3999994!
        Me.Line30.Left = 1.133334!
        Me.Line30.LineWeight = 1!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 2.133336!
        Me.Line30.Width = 0!
        Me.Line30.X1 = 1.133334!
        Me.Line30.X2 = 1.133334!
        Me.Line30.Y1 = 2.133336!
        Me.Line30.Y2 = 2.533335!
        '
        'Line31
        '
        Me.Line31.Height = 0.3999994!
        Me.Line31.Left = 3!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 2.133336!
        Me.Line31.Width = 0!
        Me.Line31.X1 = 3!
        Me.Line31.X2 = 3!
        Me.Line31.Y1 = 2.133336!
        Me.Line31.Y2 = 2.533335!
        '
        'Line32
        '
        Me.Line32.Height = 7.152557E-07!
        Me.Line32.Left = 0.2000005!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 2.533334!
        Me.Line32.Width = 7.333333!
        Me.Line32.X1 = 0.2000005!
        Me.Line32.X2 = 7.533333!
        Me.Line32.Y1 = 2.533335!
        Me.Line32.Y2 = 2.533334!
        '
        'Line33
        '
        Me.Line33.Height = 1.192093E-06!
        Me.Line33.Left = 0.2000005!
        Me.Line33.LineWeight = 1!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 2.933333!
        Me.Line33.Width = 7.333333!
        Me.Line33.X1 = 0.2000005!
        Me.Line33.X2 = 7.533333!
        Me.Line33.Y1 = 2.933335!
        Me.Line33.Y2 = 2.933333!
        '
        'txtトルクスNO
        '
        Me.txtトルクスNO.DataField = "トルクスNO"
        Me.txtトルクスNO.Height = 0.2!
        Me.txtトルクスNO.Left = 0.2666672!
        Me.txtトルクスNO.Name = "txtトルクスNO"
        Me.txtトルクスNO.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtトルクスNO.Text = "トルクスNO"
        Me.txtトルクスNO.Top = 2.333333!
        Me.txtトルクスNO.Width = 0.8!
        '
        'txt軸荒径
        '
        Me.txt軸荒径.DataField = "軸荒径"
        Me.txt軸荒径.Height = 0.2!
        Me.txt軸荒径.Left = 1.200001!
        Me.txt軸荒径.Name = "txt軸荒径"
        Me.txt軸荒径.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txt軸荒径.Text = "軸荒径"
        Me.txt軸荒径.Top = 2.333333!
        Me.txt軸荒径.Width = 0.8!
        '
        'txt材料径
        '
        Me.txt材料径.DataField = "材料径"
        Me.txt材料径.Height = 0.2!
        Me.txt材料径.Left = 2.133333!
        Me.txt材料径.Name = "txt材料径"
        Me.txt材料径.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txt材料径.Text = "材料径"
        Me.txt材料径.Top = 2.333333!
        Me.txt材料径.Width = 0.8!
        '
        'txtネジ外径
        '
        Me.txtネジ外径.DataField = "ネジ外径"
        Me.txtネジ外径.Height = 0.2!
        Me.txtネジ外径.Left = 3.066667!
        Me.txtネジ外径.Name = "txtネジ外径"
        Me.txtネジ外径.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtネジ外径.Text = "ネジ外径"
        Me.txtネジ外径.Top = 2.333333!
        Me.txtネジ外径.Width = 0.8!
        '
        'Label20
        '
        Me.Label20.Height = 0.2000001!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.2666672!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label20.Text = "トルクスNO"
        Me.Label20.Top = 2.133333!
        Me.Label20.Width = 0.7333333!
        '
        'Label21
        '
        Me.Label21.Height = 0.2000001!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 1.200001!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label21.Text = "軸荒径"
        Me.Label21.Top = 2.133333!
        Me.Label21.Width = 0.7333333!
        '
        'Label22
        '
        Me.Label22.Height = 0.2000001!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 2.133334!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label22.Text = "材料径"
        Me.Label22.Top = 2.133334!
        Me.Label22.Width = 0.7333333!
        '
        'Label23
        '
        Me.Label23.Height = 0.2000001!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 3.066667!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label23.Text = "ネジ外径"
        Me.Label23.Top = 2.133334!
        Me.Label23.Width = 0.7333333!
        '
        'Label26
        '
        Me.Label26.Height = 0.2000001!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.2666672!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label26.Text = "販売名"
        Me.Label26.Top = 2.533334!
        Me.Label26.Width = 0.8666667!
        '
        'Label27
        '
        Me.Label27.Height = 0.2000001!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 2.133333!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label27.Text = "種類名"
        Me.Label27.Top = 2.533334!
        Me.Label27.Width = 0.5333332!
        '
        'Label28
        '
        Me.Label28.Height = 0.2000001!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 4!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label28.Text = "承認番号"
        Me.Label28.Top = 2.533334!
        Me.Label28.Width = 0.7333333!
        '
        'Label29
        '
        Me.Label29.Height = 0.2000001!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 5.800001!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.Label29.Text = "一般的名称"
        Me.Label29.Top = 2.533334!
        Me.Label29.Width = 0.6666656!
        '
        'txtHanbaiName
        '
        Me.txtHanbaiName.Height = 0.2!
        Me.txtHanbaiName.Left = 0.3333338!
        Me.txtHanbaiName.MultiLine = false
        Me.txtHanbaiName.Name = "txtHanbaiName"
        Me.txtHanbaiName.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtHanbaiName.Text = "販売名"
        Me.txtHanbaiName.Top = 2.733334!
        Me.txtHanbaiName.Width = 1.666667!
        '
        'txtSyuruiName
        '
        Me.txtSyuruiName.Height = 0.2!
        Me.txtSyuruiName.Left = 2.2!
        Me.txtSyuruiName.MultiLine = false
        Me.txtSyuruiName.Name = "txtSyuruiName"
        Me.txtSyuruiName.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtSyuruiName.Text = "種類名"
        Me.txtSyuruiName.Top = 2.733334!
        Me.txtSyuruiName.Width = 1.666667!
        '
        'txtSyouninBangou
        '
        Me.txtSyouninBangou.Height = 0.2!
        Me.txtSyouninBangou.Left = 4.066667!
        Me.txtSyouninBangou.MultiLine = false
        Me.txtSyouninBangou.Name = "txtSyouninBangou"
        Me.txtSyouninBangou.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtSyouninBangou.Text = "承認番号"
        Me.txtSyouninBangou.Top = 2.733334!
        Me.txtSyouninBangou.Width = 1.599999!
        '
        'txtIppanName
        '
        Me.txtIppanName.Height = 0.2!
        Me.txtIppanName.Left = 5.866668!
        Me.txtIppanName.MultiLine = false
        Me.txtIppanName.Name = "txtIppanName"
        Me.txtIppanName.Style = "font-size: 9pt; vertical-align: bottom; white-space: nowrap"
        Me.txtIppanName.Text = "一般的名称"
        Me.txtIppanName.Top = 2.733334!
        Me.txtIppanName.Width = 1.599999!
        '
        'Line34
        '
        Me.Line34.Height = 2.145767E-06!
        Me.Line34.Left = 0.2000005!
        Me.Line34.LineWeight = 1!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 3.333333!
        Me.Line34.Width = 7.333333!
        Me.Line34.X1 = 0.2000005!
        Me.Line34.X2 = 7.533333!
        Me.Line34.Y1 = 3.333335!
        Me.Line34.Y2 = 3.333333!
        '
        'Label30
        '
        Me.Label30.Height = 0.2666667!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0.2000005!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label30.Text = "符"
        Me.Label30.Top = 3!
        Me.Label30.Width = 0.2666667!
        '
        'Line39
        '
        Me.Line39.Height = 0.4000015!
        Me.Line39.Left = 0.466667!
        Me.Line39.LineWeight = 1!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 2.933335!
        Me.Line39.Width = 0!
        Me.Line39.X1 = 0.466667!
        Me.Line39.X2 = 0.466667!
        Me.Line39.Y1 = 2.933335!
        Me.Line39.Y2 = 3.333336!
        '
        'Line40
        '
        Me.Line40.Height = 0!
        Me.Line40.Left = 0.4666672!
        Me.Line40.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dot
        Me.Line40.LineWeight = 1!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 3.133333!
        Me.Line40.Width = 0.6666669!
        Me.Line40.X1 = 0.4666672!
        Me.Line40.X2 = 1.133334!
        Me.Line40.Y1 = 3.133333!
        Me.Line40.Y2 = 3.133333!
        '
        'Label31
        '
        Me.Label31.Height = 0.2000001!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.4666672!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label31.Text = "工順"
        Me.Label31.Top = 2.933333!
        Me.Label31.Width = 0.6666667!
        '
        'Label32
        '
        Me.Label32.Height = 0.2000001!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.4666672!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label32.Text = "基本"
        Me.Label32.Top = 3.133333!
        Me.Label32.Width = 0.3333334!
        '
        'Label33
        '
        Me.Label33.Height = 0.2000001!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.8000007!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.Label33.Text = "補助"
        Me.Label33.Top = 3.133333!
        Me.Label33.Width = 0.3333334!
        '
        'Line41
        '
        Me.Line41.Height = 0.3999999!
        Me.Line41.Left = 1.133334!
        Me.Line41.LineWeight = 1!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 2.933333!
        Me.Line41.Width = 0!
        Me.Line41.X1 = 1.133334!
        Me.Line41.X2 = 1.133334!
        Me.Line41.Y1 = 2.933333!
        Me.Line41.Y2 = 3.333333!
        '
        'Label34
        '
        Me.Label34.Height = 0.2666667!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 1.133333!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label34.Text = "工程C"
        Me.Label34.Top = 3!
        Me.Label34.Width = 0.4666668!
        '
        'Line44
        '
        Me.Line44.Height = 0.3999999!
        Me.Line44.Left = 1.6!
        Me.Line44.LineWeight = 1!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 2.933333!
        Me.Line44.Width = 0!
        Me.Line44.X1 = 1.6!
        Me.Line44.X2 = 1.6!
        Me.Line44.Y1 = 2.933333!
        Me.Line44.Y2 = 3.333333!
        '
        'Line46
        '
        Me.Line46.Height = 0.3999999!
        Me.Line46.Left = 2.733334!
        Me.Line46.LineWeight = 1!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 2.933333!
        Me.Line46.Width = 0!
        Me.Line46.X1 = 2.733334!
        Me.Line46.X2 = 2.733334!
        Me.Line46.Y1 = 2.933333!
        Me.Line46.Y2 = 3.333333!
        '
        'Label35
        '
        Me.Label35.Height = 0.2666667!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 1.600001!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label35.Text = "設備"
        Me.Label35.Top = 3!
        Me.Label35.Width = 1.133333!
        '
        'Label36
        '
        Me.Label36.Height = 0.2666667!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 2.800001!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label36.Text = "設備C"
        Me.Label36.Top = 3!
        Me.Label36.Width = 0.4000001!
        '
        'Label37
        '
        Me.Label37.Height = 0.2666667!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 3.200001!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-size: 9pt; text-align: center; vertical-align: middle"
        Me.Label37.Text = "SHOP"
        Me.Label37.Top = 3!
        Me.Label37.Width = 0.3333335!
        '
        'Line47
        '
        Me.Line47.Height = 0.3999999!
        Me.Line47.Left = 3.6!
        Me.Line47.LineWeight = 1!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 2.933333!
        Me.Line47.Width = 0!
        Me.Line47.X1 = 3.6!
        Me.Line47.X2 = 3.6!
        Me.Line47.Y1 = 2.933333!
        Me.Line47.Y2 = 3.333333!
        '
        'Label38
        '
        Me.Label38.Height = 0.2666667!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 3.666667!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-size: 9pt; text-align: left; vertical-align: middle"
        Me.Label38.Text = "手順"
        Me.Label38.Top = 3!
        Me.Label38.Width = 0.4000001!
        '
        'Label39
        '
        Me.Label39.Height = 0.2666667!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 5.066667!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "font-size: 9pt; text-align: left; vertical-align: middle"
        Me.Label39.Text = "説明"
        Me.Label39.Top = 3!
        Me.Label39.Width = 0.4000001!
        '
        'Line50
        '
        Me.Line50.Height = 0.3999944!
        Me.Line50.Left = 6.066664!
        Me.Line50.LineWeight = 1!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 1.333339!
        Me.Line50.Width = 2.861023E-06!
        Me.Line50.X1 = 6.066664!
        Me.Line50.X2 = 6.066667!
        Me.Line50.Y1 = 1.333339!
        Me.Line50.Y2 = 1.733333!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 5.933331!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-size: 8.25pt; vertical-align: bottom"
        Me.lblDate.Text = "YY.MM.DD"
        Me.lblDate.Top = 0!
        Me.lblDate.Width = 0.5333332!
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 6.53333!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom"
        Me.Label.Text = "出力"
        Me.Label.Top = 0!
        Me.Label.Width = 0.333333!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 6.933329!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-size: 8.25pt; text-align: right; vertical-align: bottom"
        Me.lblPage.Text = "Page.#"
        Me.lblPage.Top = 0!
        Me.lblPage.Width = 0.4666668!
        '
        'Line26
        '
        Me.Line26.Height = 0.3999972!
        Me.Line26.Left = 4.2!
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 1.733333!
        Me.Line26.Width = 0!
        Me.Line26.X1 = 4.2!
        Me.Line26.X2 = 4.2!
        Me.Line26.Y1 = 1.733333!
        Me.Line26.Y2 = 2.133331!
        '
        'Line63
        '
        Me.Line63.Height = 0.3999972!
        Me.Line63.Left = 1.6!
        Me.Line63.LineWeight = 1!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 1.733333!
        Me.Line63.Width = 0!
        Me.Line63.X1 = 1.6!
        Me.Line63.X2 = 1.6!
        Me.Line63.Y1 = 1.733333!
        Me.Line63.Y2 = 2.133331!
        '
        'Line64
        '
        Me.Line64.Height = 0.3999965!
        Me.Line64.Left = 4.933334!
        Me.Line64.LineWeight = 1!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 0.5333334!
        Me.Line64.Width = 0!
        Me.Line64.X1 = 4.933334!
        Me.Line64.X2 = 4.933334!
        Me.Line64.Y1 = 0.5333334!
        Me.Line64.Y2 = 0.9333299!
        '
        'Line3
        '
        Me.Line3.Height = 0.3999991!
        Me.Line3.Left = 4.866667!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 2.133333!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 4.866667!
        Me.Line3.X2 = 4.866667!
        Me.Line3.Y1 = 2.133333!
        Me.Line3.Y2 = 2.533333!
        '
        'Line5
        '
        Me.Line5.Height = 0.3999991!
        Me.Line5.Left = 6.466667!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 2.133333!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 6.466667!
        Me.Line5.X2 = 6.466667!
        Me.Line5.Y1 = 2.133333!
        Me.Line5.Y2 = 2.533333!
        '
        'Label9
        '
        Me.Label9.Height = 0.2000001!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 3.933333!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom"
        Me.Label9.Text = "製品標準書 Rev"
        Me.Label9.Top = 2.133333!
        Me.Label9.Width = 0.9333333!
        '
        'Label24
        '
        Me.Label24.Height = 0.2000001!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 4.866667!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom"
        Me.Label24.Text = "製品図面 Rev"
        Me.Label24.Top = 2.133333!
        Me.Label24.Width = 0.8!
        '
        'Label25
        '
        Me.Label25.Height = 0.2000001!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 5.733333!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom"
        Me.Label25.Text = "加工図 Rev"
        Me.Label25.Top = 2.133333!
        Me.Label25.Width = 0.6666666!
        '
        'Label50
        '
        Me.Label50.Height = 0.2000001!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 6.466667!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "font-size: 8.25pt; text-align: center; vertical-align: bottom"
        Me.Label50.Text = "試験・検査表 Rev"
        Me.Label50.Top = 2.133333!
        Me.Label50.Width = 1.066667!
        '
        'Line7
        '
        Me.Line7.Height = 0.3999991!
        Me.Line7.Left = 5.666667!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 2.133333!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 5.666667!
        Me.Line7.X2 = 5.666667!
        Me.Line7.Y1 = 2.133333!
        Me.Line7.Y2 = 2.533333!
        '
        'TextBox
        '
        Me.TextBox.DataField = "COR_MARK2"
        Me.TextBox.Height = 0.2!
        Me.TextBox.Left = 3.933333!
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.TextBox.Text = "訂符2"
        Me.TextBox.Top = 2.333333!
        Me.TextBox.Width = 0.9333333!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "COR_MARK4"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 4.866667!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.TextBox1.Text = "訂符4"
        Me.TextBox1.Top = 2.333333!
        Me.TextBox1.Width = 0.8!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "COR_MARK3"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 5.733333!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.TextBox2.Text = "訂符3"
        Me.TextBox2.Top = 2.333333!
        Me.TextBox2.Width = 0.666667!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "COR_MARK5"
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 6.466667!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.TextBox3.Text = "訂符5"
        Me.TextBox3.Top = 2.333333!
        Me.TextBox3.Width = 1.066667!
        '
        'Line53
        '
        Me.Line53.Height = 0.3999999!
        Me.Line53.Left = 1.866667!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 0.5333334!
        Me.Line53.Width = 0!
        Me.Line53.X1 = 1.866667!
        Me.Line53.X2 = 1.866667!
        Me.Line53.Y1 = 0.5333334!
        Me.Line53.Y2 = 0.9333333!
        '
        'txtUM_P_ORDER
        '
        Me.txtUM_P_ORDER.DataField = "UM_P_ORDER"
        Me.txtUM_P_ORDER.Height = 0.2!
        Me.txtUM_P_ORDER.Left = 0.2666667!
        Me.txtUM_P_ORDER.Name = "txtUM_P_ORDER"
        Me.txtUM_P_ORDER.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtUM_P_ORDER.Text = "XX"
        Me.txtUM_P_ORDER.Top = 0.1333333!
        Me.txtUM_P_ORDER.Width = 0.2!
        '
        'Line35
        '
        Me.Line35.Height = 7.152556E-07!
        Me.Line35.Left = 0.2!
        Me.Line35.LineWeight = 1!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 0!
        Me.Line35.Width = 7.333333!
        Me.Line35.X1 = 0.2!
        Me.Line35.X2 = 7.533333!
        Me.Line35.Y1 = 7.152556E-07!
        Me.Line35.Y2 = 0!
        '
        'Line37
        '
        Me.Line37.Height = 0.3333333!
        Me.Line37.Left = 0.2!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 0!
        Me.Line37.Width = 0!
        Me.Line37.X1 = 0.2!
        Me.Line37.X2 = 0.2!
        Me.Line37.Y1 = 0!
        Me.Line37.Y2 = 0.3333333!
        '
        'Line38
        '
        Me.Line38.Height = 0.3333333!
        Me.Line38.Left = 0.4666668!
        Me.Line38.LineWeight = 1!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 0!
        Me.Line38.Width = 0!
        Me.Line38.X1 = 0.4666668!
        Me.Line38.X2 = 0.4666668!
        Me.Line38.Y1 = 0!
        Me.Line38.Y2 = 0.3333333!
        '
        'txtP_ORDER_MAIN
        '
        Me.txtP_ORDER_MAIN.DataField = "P_ORDER_MAIN"
        Me.txtP_ORDER_MAIN.Height = 0.2!
        Me.txtP_ORDER_MAIN.Left = 0.5333334!
        Me.txtP_ORDER_MAIN.Name = "txtP_ORDER_MAIN"
        Me.txtP_ORDER_MAIN.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtP_ORDER_MAIN.Text = "999"
        Me.txtP_ORDER_MAIN.Top = 0.1333333!
        Me.txtP_ORDER_MAIN.Width = 0.2666667!
        '
        'txtP_ORDER_SUB
        '
        Me.txtP_ORDER_SUB.DataField = "P_ORDER_SUB"
        Me.txtP_ORDER_SUB.Height = 0.2!
        Me.txtP_ORDER_SUB.Left = 0.8666667!
        Me.txtP_ORDER_SUB.Name = "txtP_ORDER_SUB"
        Me.txtP_ORDER_SUB.Style = "font-size: 9pt; text-align: right; vertical-align: bottom"
        Me.txtP_ORDER_SUB.Text = "9"
        Me.txtP_ORDER_SUB.Top = 0.1333333!
        Me.txtP_ORDER_SUB.Width = 0.1999999!
        '
        'Line42
        '
        Me.Line42.Height = 0.3333333!
        Me.Line42.Left = 1.133333!
        Me.Line42.LineWeight = 1!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 0!
        Me.Line42.Width = 0!
        Me.Line42.X1 = 1.133333!
        Me.Line42.X2 = 1.133333!
        Me.Line42.Y1 = 0!
        Me.Line42.Y2 = 0.3333333!
        '
        'txtPROCESS_CD
        '
        Me.txtPROCESS_CD.DataField = "PROCESS_CD"
        Me.txtPROCESS_CD.Height = 0.2!
        Me.txtPROCESS_CD.Left = 1.2!
        Me.txtPROCESS_CD.Name = "txtPROCESS_CD"
        Me.txtPROCESS_CD.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtPROCESS_CD.Text = "XXXXX"
        Me.txtPROCESS_CD.Top = 0.1333333!
        Me.txtPROCESS_CD.Width = 0.3999999!
        '
        'Line43
        '
        Me.Line43.Height = 0.3333333!
        Me.Line43.Left = 1.6!
        Me.Line43.LineWeight = 1!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 0!
        Me.Line43.Width = 0!
        Me.Line43.X1 = 1.6!
        Me.Line43.X2 = 1.6!
        Me.Line43.Y1 = 0!
        Me.Line43.Y2 = 0.3333333!
        '
        'txt設備
        '
        Me.txt設備.DataField = "設備"
        Me.txt設備.Height = 0.2!
        Me.txt設備.Left = 1.666667!
        Me.txt設備.Name = "txt設備"
        Me.txt設備.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txt設備.Text = "XXXXXXXXXXXXXXX"
        Me.txt設備.Top = 0.1333333!
        Me.txt設備.Width = 1!
        '
        'Line45
        '
        Me.Line45.Height = 0.3333333!
        Me.Line45.Left = 2.733334!
        Me.Line45.LineWeight = 1!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 0!
        Me.Line45.Width = 0!
        Me.Line45.X1 = 2.733334!
        Me.Line45.X2 = 2.733334!
        Me.Line45.Y1 = 0!
        Me.Line45.Y2 = 0.3333333!
        '
        'txtFACILITIES_G_CD
        '
        Me.txtFACILITIES_G_CD.DataField = "FACILITIES_G_CD"
        Me.txtFACILITIES_G_CD.Height = 0.2!
        Me.txtFACILITIES_G_CD.Left = 2.800001!
        Me.txtFACILITIES_G_CD.Name = "txtFACILITIES_G_CD"
        Me.txtFACILITIES_G_CD.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.txtFACILITIES_G_CD.Text = "XXXX"
        Me.txtFACILITIES_G_CD.Top = 0.1333333!
        Me.txtFACILITIES_G_CD.Width = 0.4000003!
        '
        'txtSHOP
        '
        Me.txtSHOP.DataField = "SHOP"
        Me.txtSHOP.Height = 0.2!
        Me.txtSHOP.Left = 3.200001!
        Me.txtSHOP.Name = "txtSHOP"
        Me.txtSHOP.Style = "font-size: 9pt; text-align: center; vertical-align: bottom"
        Me.txtSHOP.Text = "XX"
        Me.txtSHOP.Top = 0.1333333!
        Me.txtSHOP.Width = 0.333333!
        '
        'Line48
        '
        Me.Line48.Height = 0.3333333!
        Me.Line48.Left = 3.6!
        Me.Line48.LineWeight = 1!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 0!
        Me.Line48.Width = 0!
        Me.Line48.X1 = 3.6!
        Me.Line48.X2 = 3.6!
        Me.Line48.Y1 = 0!
        Me.Line48.Y2 = 0.3333333!
        '
        'Line49
        '
        Me.Line49.Height = 0.3333333!
        Me.Line49.Left = 7.533327!
        Me.Line49.LineWeight = 1!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 0!
        Me.Line49.Width = 0!
        Me.Line49.X1 = 7.533327!
        Me.Line49.X2 = 7.533327!
        Me.Line49.Y1 = 0!
        Me.Line49.Y2 = 0.3333333!
        '
        'txtP_ORDER_NM
        '
        Me.txtP_ORDER_NM.DataField = "P_ORDER_NM"
        Me.txtP_ORDER_NM.Height = 0.2!
        Me.txtP_ORDER_NM.Left = 3.666667!
        Me.txtP_ORDER_NM.Name = "txtP_ORDER_NM"
        Me.txtP_ORDER_NM.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtP_ORDER_NM.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txtP_ORDER_NM.Top = 0.1333333!
        Me.txtP_ORDER_NM.Width = 1.333333!
        '
        'txtP_COMMENT
        '
        Me.txtP_COMMENT.DataField = "P_COMMENT"
        Me.txtP_COMMENT.Height = 0.3333333!
        Me.txtP_COMMENT.Left = 5.066667!
        Me.txtP_COMMENT.Name = "txtP_COMMENT"
        Me.txtP_COMMENT.Style = "font-size: 9pt; vertical-align: bottom"
        Me.txtP_COMMENT.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txtP_COMMENT.Top = 0!
        Me.txtP_COMMENT.Width = 2.4!
        '
        'Line51
        '
        Me.Line51.Height = 0!
        Me.Line51.Left = 0.2!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 0!
        Me.Line51.Width = 7.333333!
        Me.Line51.X1 = 0.2!
        Me.Line51.X2 = 7.533333!
        Me.Line51.Y1 = 0!
        Me.Line51.Y2 = 0!
        '
        'SubReport
        '
        Me.SubReport.CloseBorder = false
        Me.SubReport.Height = 0.1333333!
        Me.SubReport.Left = 0!
        Me.SubReport.Name = "SubReport"
        Me.SubReport.Report = Nothing
        Me.SubReport.ReportName = ""
        Me.SubReport.Top = 0!
        Me.SubReport.Width = 7.933333!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=OraOLEDB.Oracle.1;Password=medical;Persist Security Info=True;User ID=me" & _
            "dical;Data Source=medical"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.4!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.572917!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: italic; font-variant: inherit; font-weight: bold; font-size: 14pt; fo" & _
                    "nt-size-adjust: inherit; font-stretch: inherit; font-family: ＭＳ ゴシック", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMotoCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtO_SKETCH_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCatalog, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKakou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPARTS_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtITEM_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMATL_SPEC, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMATL_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMATL_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSozai, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTani, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTanju, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpouKubun1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB02, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB03, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB04, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB05, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB06, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB07, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB08, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB09, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMEASURE_KB10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSunpou10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtC_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGRP_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt社内番号, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtテストピース, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMekkin, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtトルクスNO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt軸荒径, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt材料径, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtネジ外径, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHanbaiName, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyuruiName, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyouninBangou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtIppanName, System.ComponentModel.ISupportInitialize).EndInit
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
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtUM_P_ORDER, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtP_ORDER_MAIN, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtP_ORDER_SUB, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPROCESS_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txt設備, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtFACILITIES_G_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSHOP, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtP_ORDER_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtP_COMMENT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit
    End Sub

#End Region

    Private _sGenseitei As String = "00000000"
    Private _sTeifu As String = ""
    Private _sTuutisyo As String = ""
    Private _sTekiyou As String = "00000000"
    Private _sSakusei As String = ""
    Private _sSyounin As String = ""

    Public WriteOnly Property Genseitei() As String
        Set(ByVal sValue As String)
            _sGenseitei = sValue
        End Set
    End Property

    Public WriteOnly Property Teifu() As String
        Set(ByVal sValue As String)
            _sTeifu = sValue
        End Set
    End Property

    Public WriteOnly Property Tuutisyo() As String
        Set(ByVal sValue As String)
            _sTuutisyo = sValue
        End Set
    End Property

    Public WriteOnly Property Tekiyou() As String
        Set(ByVal sValue As String)
            _sTekiyou = sValue
        End Set
    End Property

    Public WriteOnly Property Sakusei() As String
        Set(ByVal sValue As String)
            _sSakusei = sValue
        End Set
    End Property

    Public WriteOnly Property Syounin() As String
        Set(ByVal sValue As String)
            _sSyounin = sValue
        End Set
    End Property

    Private Sub mdlst0101_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("Date1")
        txtDate1.DataField = "Date1"
    End Sub

    Private Sub mdlst0101_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        '適用日付 
        Fields("Date1").Value = ""
        If Not GetString(Fields("APPLY_DT").Value).Equals("") And Not GetString(Fields("APPLY_DT").Value).Equals("00000000") Then Fields("Date1").Value = GetString(Fields("APPLY_DT").Value).Substring(0, 4) + "." + GetString(Fields("APPLY_DT").Value).Substring(4, 2) + "." + GetString(Fields("APPLY_DT").Value).Substring(6, 2)
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        '原制定 
        If Not _sGenseitei.Trim.Equals("") And Not _sGenseitei.Trim.Equals("00000000") Then
            txtGenseitei.Text = _sGenseitei.Trim.Substring(0, 4) + "." + _sGenseitei.Trim.Substring(4, 2) + "." + _sGenseitei.Trim.Substring(6, 2)
        Else
            txtGenseitei.Text = ""
        End If
        '訂符 
        txtTeifu.Text = _sTeifu
        '変更通知書№ 
        txtTuutisyo.Text = _sTuutisyo
        '適用 
        If Not _sTekiyou.Trim.Equals("") And Not _sTekiyou.Trim.Equals("00000000") Then
            txtTekiyou.Text = _sTekiyou.Trim.Substring(0, 4) + "." + _sTekiyou.Trim.Substring(4, 2) + "." + _sTekiyou.Trim.Substring(6, 2)
        Else
            txtTekiyou.Text = ""
        End If
        '作成 
        txtSakusei.Text = _sSakusei
        '承認 
        txtSyounin.Text = _sSyounin
    End Sub

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

End Class
