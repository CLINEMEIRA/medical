Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports System
Imports Microsoft.VisualBasic
Imports System.Data.OracleClient

Public Class mdjsk1704
    Inherits GrapeCity.ActiveReports.SectionReport
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader = Nothing
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter = Nothing
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSysDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private lblFrom As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
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
    Private Label41 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label42 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label44 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label45 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label46 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtGRP_NM1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCATALOG_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOMPANY_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtP_ORDER As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPROCESS_C As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtP_ORDER_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtFACILITIES_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtFACILITIES_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtFACILITIES_G_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtFACILITIES_G_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWORKER_CD As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWORKER_NM As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPW_AMT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtARTICLE_ANT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSS_ARTICLE_ANT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtPREPARATION_AMT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWORK_ST_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWORK_ED_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWORK_ST_TIME As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtWORK_ED_TIME As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtDIFF2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCYCLE_TIME As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtJitsuKadouRitsu As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtJitsuKadouTime As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTACT_TIME As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtJinteki As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtGRP_NM2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtC_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private hdnP_ORDER As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private hdnWORK_TIME_KB As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private hdnDIFF2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private hdnWORK_ST_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private hdnWORK_ST_TIME As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private hdnWORK_ED_DT As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private hdnWORK_ED_TIME As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtJintekiTime As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSumJintekiTime As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSumJinteki As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label38 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSumJitsuKadou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSumKadou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTitel As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private hdnTitel As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label40 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSouSumJinteki As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSouSumJitsuKadou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtSouSumKadou As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label39 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtSouSumJintekiTime As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdjsk1704))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSysDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblFrom = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
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
        Me.Label41 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label42 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label44 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label45 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label46 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGRP_NM1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCATALOG_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOMPANY_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtP_ORDER = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPROCESS_C = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtP_ORDER_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFACILITIES_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFACILITIES_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFACILITIES_G_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFACILITIES_G_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWORKER_CD = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWORKER_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPW_AMT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtARTICLE_ANT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSS_ARTICLE_ANT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPREPARATION_AMT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWORK_ST_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWORK_ED_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWORK_ST_TIME = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWORK_ED_TIME = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDIFF2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCYCLE_TIME = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtJitsuKadouRitsu = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtJitsuKadouTime = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTACT_TIME = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtJinteki = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGRP_NM2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtC_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.hdnP_ORDER = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.hdnWORK_TIME_KB = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.hdnDIFF2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.hdnWORK_ST_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.hdnWORK_ST_TIME = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.hdnWORK_ED_DT = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.hdnWORK_ED_TIME = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtJintekiTime = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSumJintekiTime = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSumJinteki = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label38 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSumJitsuKadou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSumKadou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTitel = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.hdnTitel = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label40 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSouSumJinteki = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSouSumJitsuKadou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSouSumKadou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label39 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSouSumJintekiTime = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit
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
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGRP_NM1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtP_ORDER, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPROCESS_C, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtP_ORDER_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtFACILITIES_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtFACILITIES_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtFACILITIES_G_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtFACILITIES_G_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWORKER_CD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWORKER_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPW_AMT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtARTICLE_ANT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSS_ARTICLE_ANT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPREPARATION_AMT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWORK_ST_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWORK_ED_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWORK_ST_TIME, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtWORK_ED_TIME, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDIFF2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCYCLE_TIME, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtJitsuKadouRitsu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtJitsuKadouTime, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTACT_TIME, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtJinteki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGRP_NM2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtC_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.hdnP_ORDER, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.hdnWORK_TIME_KB, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.hdnDIFF2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.hdnWORK_ST_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.hdnWORK_ST_TIME, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.hdnWORK_ED_DT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.hdnWORK_ED_TIME, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtJintekiTime, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSumJintekiTime, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSumJinteki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSumJitsuKadou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSumKadou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTitel, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.hdnTitel, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSouSumJinteki, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSouSumJitsuKadou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSouSumKadou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSouSumJintekiTime, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtGRP_NM1, Me.txtCATALOG_NO, Me.txtCOMPANY_NO, Me.txtINDICATE_NO, Me.txtP_ORDER, Me.txtPROCESS_C, Me.txtP_ORDER_NM, Me.txtFACILITIES_CD, Me.txtFACILITIES_NM, Me.txtFACILITIES_G_CD, Me.txtFACILITIES_G_NM, Me.txtWORKER_CD, Me.txtWORKER_NM, Me.txtPW_AMT, Me.txtARTICLE_ANT, Me.txtSS_ARTICLE_ANT, Me.txtPREPARATION_AMT, Me.txtWORK_ST_DT, Me.txtWORK_ED_DT, Me.txtWORK_ST_TIME, Me.txtWORK_ED_TIME, Me.txtDIFF2, Me.txtCYCLE_TIME, Me.txtJitsuKadouRitsu, Me.txtJitsuKadouTime, Me.txtTACT_TIME, Me.Label11, Me.txtJinteki, Me.Label12, Me.txtGRP_NM2, Me.txtC_NO, Me.hdnP_ORDER, Me.hdnWORK_TIME_KB, Me.hdnDIFF2, Me.hdnWORK_ST_DT, Me.hdnWORK_ST_TIME, Me.hdnWORK_ED_DT, Me.hdnWORK_ED_TIME, Me.txtJintekiTime})
        Me.Detail.Height = 0.26875!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        '
        'ReportHeader
        '
        Me.ReportHeader.Height = 0!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.Visible = false
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label40, Me.txtSouSumJinteki, Me.txtSouSumJitsuKadou, Me.txtSouSumKadou, Me.Label39, Me.txtSouSumJintekiTime})
        Me.ReportFooter.Height = 0.1555556!
        Me.ReportFooter.KeepTogether = true
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label14, Me.Label24, Me.Label27, Me.lblSysDate, Me.Label, Me.lblPage, Me.Label1, Me.Line, Me.lblFrom, Me.lblTo, Me.Label15, Me.Label16, Me.Label10, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label13, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label25, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.Label41, Me.Label42, Me.Label44, Me.Label45, Me.Label46})
        Me.PageHeader.Height = 1.134722!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'GroupHeader1
        '
        Me.GroupHeader1.DataField = "C_NO"
        Me.GroupHeader1.Height = 0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.Visible = false
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtSumJintekiTime, Me.txtSumJinteki, Me.Label38, Me.txtSumJitsuKadou, Me.txtSumKadou, Me.txtTitel, Me.Line2, Me.hdnTitel})
        Me.GroupFooter1.Height = 0.1340278!
        Me.GroupFooter1.KeepTogether = true
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label14
        '
        Me.Label14.Height = 0.2!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 1.1875!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label14.Text = "～"
        Me.Label14.Top = 0.5!
        Me.Label14.Width = 0.25!
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: none;" & _
            " vertical-align: bottom"
        Me.Label24.Text = "*　*　出来高 （組番順）　*　*"
        Me.Label24.Top = 0.25!
        Me.Label24.Width = 15.9375!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 13.13542!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "日 付 ："
        Me.Label27.Top = 0!
        Me.Label27.Width = 0.625!
        '
        'lblSysDate
        '
        Me.lblSysDate.Height = 0.2!
        Me.lblSysDate.HyperLink = Nothing
        Me.lblSysDate.Left = 13.76042!
        Me.lblSysDate.Name = "lblSysDate"
        Me.lblSysDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblSysDate.Text = "YYYY/MM/DD"
        Me.lblSysDate.Top = 0!
        Me.lblSysDate.Width = 0.9375!
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 14.76042!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label.Text = "ページ ："
        Me.Label.Top = 0!
        Me.Label.Width = 0.6875!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 15.44792!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblPage.Text = "1"
        Me.lblPage.Top = 0!
        Me.lblPage.Width = 0.45!
        '
        'Label1
        '
        Me.Label1.Height = 0.15!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label1.Text = "グループ名１"
        Me.Label1.Top = 0.8125!
        Me.Label1.Width = 0.75!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.125!
        Me.Line.Width = 15.9!
        Me.Line.X1 = 0!
        Me.Line.X2 = 15.9!
        Me.Line.Y1 = 1.125!
        Me.Line.Y2 = 1.125!
        '
        'lblFrom
        '
        Me.lblFrom.Height = 0.2!
        Me.lblFrom.HyperLink = Nothing
        Me.lblFrom.Left = 0.4375!
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle"
        Me.lblFrom.Text = "YYYY/MM/DD"
        Me.lblFrom.Top = 0.5!
        Me.lblFrom.Width = 0.75!
        '
        'lblTo
        '
        Me.lblTo.Height = 0.2!
        Me.lblTo.HyperLink = Nothing
        Me.lblTo.Left = 1.4375!
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.lblTo.Text = "YYYY/MM/DD"
        Me.lblTo.Top = 0.5!
        Me.lblTo.Width = 0.75!
        '
        'Label15
        '
        Me.Label15.Height = 0.2!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.3125!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label15.Text = "("
        Me.Label15.Top = 0.5!
        Me.Label15.Width = 0.125!
        '
        'Label16
        '
        Me.Label16.Height = 0.2!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.1875!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: midd" & _
            "le"
        Me.Label16.Text = ")"
        Me.Label16.Top = 0.5!
        Me.Label16.Width = 0.125!
        '
        'Label10
        '
        Me.Label10.Height = 0.15!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.06299999!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label10.Text = "グループ名２"
        Me.Label10.Top = 0.9705!
        Me.Label10.Width = 0.75!
        '
        'Label2
        '
        Me.Label2.Height = 0.15!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.25!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label2.Text = "カタログ番号"
        Me.Label2.Top = 0.8125!
        Me.Label2.Width = 0.75!
        '
        'Label3
        '
        Me.Label3.Height = 0.15!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label3.Text = "指示NO"
        Me.Label3.Top = 0.8125!
        Me.Label3.Width = 0.375!
        '
        'Label4
        '
        Me.Label4.Height = 0.15!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.8125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label4.Text = "社内NO"
        Me.Label4.Top = 0.8125!
        Me.Label4.Width = 0.375!
        '
        'Label5
        '
        Me.Label5.Height = 0.15!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.3755!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label5.Text = "工程順序"
        Me.Label5.Top = 0.9705!
        Me.Label5.Width = 0.5!
        '
        'Label6
        '
        Me.Label6.Height = 0.15!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2.9375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label6.Text = "組番"
        Me.Label6.Top = 0.9705!
        Me.Label6.Width = 0.3125!
        '
        'Label7
        '
        Me.Label7.Height = 0.15!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.25!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label7.Text = "工程"
        Me.Label7.Top = 0.8125!
        Me.Label7.Width = 0.3125!
        '
        'Label8
        '
        Me.Label8.Height = 0.15!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 3.2505!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label8.Text = "工程名"
        Me.Label8.Top = 0.9705!
        Me.Label8.Width = 0.437!
        '
        'Label9
        '
        Me.Label9.Height = 0.15!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 4.4375!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label9.Text = "設備"
        Me.Label9.Top = 0.8125!
        Me.Label9.Width = 0.3125!
        '
        'Label13
        '
        Me.Label13.Height = 0.15!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 4.438!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label13.Text = "設備名"
        Me.Label13.Top = 0.9705!
        Me.Label13.Width = 0.4369998!
        '
        'Label17
        '
        Me.Label17.Height = 0.15!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 5.875!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label17.Text = "設備集約"
        Me.Label17.Top = 0.8125!
        Me.Label17.Width = 0.5!
        '
        'Label18
        '
        Me.Label18.Height = 0.15!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 5.875501!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label18.Text = "設備集約名"
        Me.Label18.Top = 0.9705!
        Me.Label18.Width = 0.6244998!
        '
        'Label19
        '
        Me.Label19.Height = 0.15!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 7.0625!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label19.Text = "作業者"
        Me.Label19.Top = 0.8125!
        Me.Label19.Width = 0.4375!
        '
        'Label20
        '
        Me.Label20.Height = 0.15!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 7.063!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label20.Text = "作業者名"
        Me.Label20.Top = 0.9705!
        Me.Label20.Width = 0.6244998!
        '
        'Label21
        '
        Me.Label21.Height = 0.15!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 8!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label21.Text = "仕掛数"
        Me.Label21.Top = 0.8125!
        Me.Label21.Width = 0.4375!
        '
        'Label22
        '
        Me.Label22.Height = 0.15!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 8!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label22.Text = "良品数"
        Me.Label22.Top = 0.9705!
        Me.Label22.Width = 0.4375!
        '
        'Label23
        '
        Me.Label23.Height = 0.15!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 8.5625!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label23.Text = "不良品数"
        Me.Label23.Top = 0.8125!
        Me.Label23.Width = 0.5!
        '
        'Label25
        '
        Me.Label25.Height = 0.15!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 8.625!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label25.Text = "段取数"
        Me.Label25.Top = 0.9705!
        Me.Label25.Width = 0.4375!
        '
        'Label28
        '
        Me.Label28.Height = 0.15!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 9.125!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label28.Text = "作業開始日付"
        Me.Label28.Top = 0.8125!
        Me.Label28.Width = 0.75!
        '
        'Label29
        '
        Me.Label29.Height = 0.15!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 9.125!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label29.Text = "作業開始時刻"
        Me.Label29.Top = 0.9705!
        Me.Label29.Width = 0.75!
        '
        'Label30
        '
        Me.Label30.Height = 0.15!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 9.9375!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label30.Text = "作業終了日付"
        Me.Label30.Top = 0.8125!
        Me.Label30.Width = 0.75!
        '
        'Label31
        '
        Me.Label31.Height = 0.15!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 9.9375!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label31.Text = "作業終了時刻"
        Me.Label31.Top = 0.9705!
        Me.Label31.Width = 0.75!
        '
        'Label32
        '
        Me.Label32.Height = 0.15!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 10.8125!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label32.Text = "稼動時間"
        Me.Label32.Top = 0.8125!
        Me.Label32.Width = 0.5!
        '
        'Label33
        '
        Me.Label33.Height = 0.15!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 11.375!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label33.Text = "ｻｲｸﾙﾀｲﾑ"
        Me.Label33.Top = 0.8125!
        Me.Label33.Width = 0.5!
        '
        'Label34
        '
        Me.Label34.Height = 0.15!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 12.0625!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label34.Text = "実稼動率"
        Me.Label34.Top = 0.8125!
        Me.Label34.Width = 0.5!
        '
        'Label35
        '
        Me.Label35.Height = 0.15!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 12.625!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label35.Text = "実稼動時間"
        Me.Label35.Top = 0.8125!
        Me.Label35.Width = 0.625!
        '
        'Label36
        '
        Me.Label36.Height = 0.15!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 13.375!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label36.Text = "ﾀｸﾄﾀｲﾑ"
        Me.Label36.Top = 0.8125!
        Me.Label36.Width = 0.4375!
        '
        'Label37
        '
        Me.Label37.Height = 0.15!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 13.875!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label37.Text = "人的稼動率"
        Me.Label37.Top = 0.8125!
        Me.Label37.Width = 0.625!
        '
        'Label41
        '
        Me.Label41.Height = 0.15!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 11!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label41.Text = "(分)"
        Me.Label41.Top = 0.9705!
        Me.Label41.Width = 0.3125!
        '
        'Label42
        '
        Me.Label42.Height = 0.15!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 11.5625!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label42.Text = "(分)"
        Me.Label42.Top = 0.9705!
        Me.Label42.Width = 0.3125!
        '
        'Label44
        '
        Me.Label44.Height = 0.15!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 14.9375!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label44.Text = "(分)"
        Me.Label44.Top = 0.9705!
        Me.Label44.Width = 0.3125!
        '
        'Label45
        '
        Me.Label45.Height = 0.15!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 12.9375!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label45.Text = "(分)"
        Me.Label45.Top = 0.9705!
        Me.Label45.Width = 0.3125!
        '
        'Label46
        '
        Me.Label46.Height = 0.15!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 14.5!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.Label46.Text = "人的稼動時間"
        Me.Label46.Top = 0.8125!
        Me.Label46.Width = 0.75!
        '
        'txtGRP_NM1
        '
        Me.txtGRP_NM1.DataField = "GRP_NM1"
        Me.txtGRP_NM1.Height = 0.125!
        Me.txtGRP_NM1.Left = 0.0625!
        Me.txtGRP_NM1.MultiLine = false
        Me.txtGRP_NM1.Name = "txtGRP_NM1"
        Me.txtGRP_NM1.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle; white-space: now" & _
            "rap"
        Me.txtGRP_NM1.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txtGRP_NM1.Top = 0!
        Me.txtGRP_NM1.Width = 1.125!
        '
        'txtCATALOG_NO
        '
        Me.txtCATALOG_NO.DataField = "CATALOG_NO"
        Me.txtCATALOG_NO.Height = 0.125!
        Me.txtCATALOG_NO.Left = 1.25!
        Me.txtCATALOG_NO.Name = "txtCATALOG_NO"
        Me.txtCATALOG_NO.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtCATALOG_NO.Text = "XXXXXXXXXXXXXXXXX"
        Me.txtCATALOG_NO.Top = 0!
        Me.txtCATALOG_NO.Width = 1.0625!
        '
        'txtCOMPANY_NO
        '
        Me.txtCOMPANY_NO.DataField = "COMPANY_NO"
        Me.txtCOMPANY_NO.Height = 0.125!
        Me.txtCOMPANY_NO.Left = 2.375!
        Me.txtCOMPANY_NO.Name = "txtCOMPANY_NO"
        Me.txtCOMPANY_NO.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtCOMPANY_NO.Text = "XXXXXX"
        Me.txtCOMPANY_NO.Top = 0!
        Me.txtCOMPANY_NO.Width = 0.375!
        '
        'txtINDICATE_NO
        '
        Me.txtINDICATE_NO.DataField = "INDICATE_NO"
        Me.txtINDICATE_NO.Height = 0.125!
        Me.txtINDICATE_NO.Left = 2.8125!
        Me.txtINDICATE_NO.Name = "txtINDICATE_NO"
        Me.txtINDICATE_NO.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtINDICATE_NO.Text = "XXXXX"
        Me.txtINDICATE_NO.Top = 0!
        Me.txtINDICATE_NO.Width = 0.375!
        '
        'txtP_ORDER
        '
        Me.txtP_ORDER.Height = 0.125!
        Me.txtP_ORDER.Left = 2.3755!
        Me.txtP_ORDER.Name = "txtP_ORDER"
        Me.txtP_ORDER.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtP_ORDER.Text = "999-9"
        Me.txtP_ORDER.Top = 0.13!
        Me.txtP_ORDER.Width = 0.375!
        '
        'txtPROCESS_C
        '
        Me.txtPROCESS_C.DataField = "PROCESS_CD"
        Me.txtPROCESS_C.Height = 0.125!
        Me.txtPROCESS_C.Left = 3.25!
        Me.txtPROCESS_C.Name = "txtPROCESS_C"
        Me.txtPROCESS_C.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtPROCESS_C.Text = "XXXXX"
        Me.txtPROCESS_C.Top = 0!
        Me.txtPROCESS_C.Width = 0.375!
        '
        'txtP_ORDER_NM
        '
        Me.txtP_ORDER_NM.DataField = "P_ORDER_NM"
        Me.txtP_ORDER_NM.Height = 0.125!
        Me.txtP_ORDER_NM.Left = 3.25!
        Me.txtP_ORDER_NM.MultiLine = false
        Me.txtP_ORDER_NM.Name = "txtP_ORDER_NM"
        Me.txtP_ORDER_NM.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: left; vertical-align: middle" & _
            "; white-space: nowrap"
        Me.txtP_ORDER_NM.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txtP_ORDER_NM.Top = 0.13!
        Me.txtP_ORDER_NM.Width = 1.125!
        '
        'txtFACILITIES_CD
        '
        Me.txtFACILITIES_CD.DataField = "FACILITIES_CD"
        Me.txtFACILITIES_CD.Height = 0.125!
        Me.txtFACILITIES_CD.Left = 4.4375!
        Me.txtFACILITIES_CD.Name = "txtFACILITIES_CD"
        Me.txtFACILITIES_CD.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtFACILITIES_CD.Text = "XXXX"
        Me.txtFACILITIES_CD.Top = 0!
        Me.txtFACILITIES_CD.Width = 0.3125!
        '
        'txtFACILITIES_NM
        '
        Me.txtFACILITIES_NM.DataField = "FACILITIES_NM"
        Me.txtFACILITIES_NM.Height = 0.125!
        Me.txtFACILITIES_NM.Left = 4.4375!
        Me.txtFACILITIES_NM.MultiLine = false
        Me.txtFACILITIES_NM.Name = "txtFACILITIES_NM"
        Me.txtFACILITIES_NM.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: left; vertical-align: middle" & _
            "; white-space: nowrap"
        Me.txtFACILITIES_NM.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txtFACILITIES_NM.Top = 0.125!
        Me.txtFACILITIES_NM.Width = 1.375!
        '
        'txtFACILITIES_G_CD
        '
        Me.txtFACILITIES_G_CD.DataField = "FACILITIES_G_CD"
        Me.txtFACILITIES_G_CD.Height = 0.125!
        Me.txtFACILITIES_G_CD.Left = 5.875!
        Me.txtFACILITIES_G_CD.Name = "txtFACILITIES_G_CD"
        Me.txtFACILITIES_G_CD.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtFACILITIES_G_CD.Text = "XXXX"
        Me.txtFACILITIES_G_CD.Top = 0!
        Me.txtFACILITIES_G_CD.Width = 0.3125!
        '
        'txtFACILITIES_G_NM
        '
        Me.txtFACILITIES_G_NM.DataField = "FACILITIES_G_NM"
        Me.txtFACILITIES_G_NM.Height = 0.125!
        Me.txtFACILITIES_G_NM.Left = 5.875!
        Me.txtFACILITIES_G_NM.MultiLine = false
        Me.txtFACILITIES_G_NM.Name = "txtFACILITIES_G_NM"
        Me.txtFACILITIES_G_NM.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: left; vertical-align: middle" & _
            "; white-space: nowrap"
        Me.txtFACILITIES_G_NM.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txtFACILITIES_G_NM.Top = 0.13!
        Me.txtFACILITIES_G_NM.Width = 1.125!
        '
        'txtWORKER_CD
        '
        Me.txtWORKER_CD.DataField = "WORKER_CD"
        Me.txtWORKER_CD.Height = 0.125!
        Me.txtWORKER_CD.Left = 7.0625!
        Me.txtWORKER_CD.Name = "txtWORKER_CD"
        Me.txtWORKER_CD.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtWORKER_CD.Text = "XXXX"
        Me.txtWORKER_CD.Top = 0!
        Me.txtWORKER_CD.Width = 0.3016672!
        '
        'txtWORKER_NM
        '
        Me.txtWORKER_NM.DataField = "WORKER_NM"
        Me.txtWORKER_NM.Height = 0.125!
        Me.txtWORKER_NM.Left = 7.0625!
        Me.txtWORKER_NM.MultiLine = false
        Me.txtWORKER_NM.Name = "txtWORKER_NM"
        Me.txtWORKER_NM.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: left; vertical-align: middle" & _
            "; white-space: nowrap"
        Me.txtWORKER_NM.Text = "XXXXXXXXXXXXXX"
        Me.txtWORKER_NM.Top = 0.13!
        Me.txtWORKER_NM.Width = 0.75!
        '
        'txtPW_AMT
        '
        Me.txtPW_AMT.DataField = "PW_AMT"
        Me.txtPW_AMT.Height = 0.125!
        Me.txtPW_AMT.Left = 7.875!
        Me.txtPW_AMT.Name = "txtPW_AMT"
        Me.txtPW_AMT.OutputFormat = resources.GetString("txtPW_AMT.OutputFormat")
        Me.txtPW_AMT.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtPW_AMT.Text = "9,999,999"
        Me.txtPW_AMT.Top = 0!
        Me.txtPW_AMT.Width = 0.5625!
        '
        'txtARTICLE_ANT
        '
        Me.txtARTICLE_ANT.DataField = "ARTICLE_ANT"
        Me.txtARTICLE_ANT.Height = 0.125!
        Me.txtARTICLE_ANT.Left = 7.8755!
        Me.txtARTICLE_ANT.Name = "txtARTICLE_ANT"
        Me.txtARTICLE_ANT.OutputFormat = resources.GetString("txtARTICLE_ANT.OutputFormat")
        Me.txtARTICLE_ANT.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtARTICLE_ANT.Text = "9,999,999"
        Me.txtARTICLE_ANT.Top = 0.13!
        Me.txtARTICLE_ANT.Width = 0.5625!
        '
        'txtSS_ARTICLE_ANT
        '
        Me.txtSS_ARTICLE_ANT.DataField = "SS_ARTICLE_ANT"
        Me.txtSS_ARTICLE_ANT.Height = 0.125!
        Me.txtSS_ARTICLE_ANT.Left = 8.5!
        Me.txtSS_ARTICLE_ANT.Name = "txtSS_ARTICLE_ANT"
        Me.txtSS_ARTICLE_ANT.OutputFormat = resources.GetString("txtSS_ARTICLE_ANT.OutputFormat")
        Me.txtSS_ARTICLE_ANT.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSS_ARTICLE_ANT.Text = "9,999,999"
        Me.txtSS_ARTICLE_ANT.Top = 0!
        Me.txtSS_ARTICLE_ANT.Width = 0.5625!
        '
        'txtPREPARATION_AMT
        '
        Me.txtPREPARATION_AMT.DataField = "PREPARATION_AMT"
        Me.txtPREPARATION_AMT.Height = 0.125!
        Me.txtPREPARATION_AMT.Left = 8.5005!
        Me.txtPREPARATION_AMT.Name = "txtPREPARATION_AMT"
        Me.txtPREPARATION_AMT.OutputFormat = resources.GetString("txtPREPARATION_AMT.OutputFormat")
        Me.txtPREPARATION_AMT.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtPREPARATION_AMT.Text = "9,999,999"
        Me.txtPREPARATION_AMT.Top = 0.13!
        Me.txtPREPARATION_AMT.Width = 0.5625!
        '
        'txtWORK_ST_DT
        '
        Me.txtWORK_ST_DT.Height = 0.125!
        Me.txtWORK_ST_DT.Left = 9.125!
        Me.txtWORK_ST_DT.Name = "txtWORK_ST_DT"
        Me.txtWORK_ST_DT.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtWORK_ST_DT.Text = "YYYY/MM/DD"
        Me.txtWORK_ST_DT.Top = 0!
        Me.txtWORK_ST_DT.Width = 0.625!
        '
        'txtWORK_ED_DT
        '
        Me.txtWORK_ED_DT.Height = 0.125!
        Me.txtWORK_ED_DT.Left = 9.9375!
        Me.txtWORK_ED_DT.Name = "txtWORK_ED_DT"
        Me.txtWORK_ED_DT.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtWORK_ED_DT.Text = "YYYY/MM/DD"
        Me.txtWORK_ED_DT.Top = 0!
        Me.txtWORK_ED_DT.Width = 0.625!
        '
        'txtWORK_ST_TIME
        '
        Me.txtWORK_ST_TIME.Height = 0.125!
        Me.txtWORK_ST_TIME.Left = 9.1255!
        Me.txtWORK_ST_TIME.Name = "txtWORK_ST_TIME"
        Me.txtWORK_ST_TIME.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtWORK_ST_TIME.Text = "HH:MM"
        Me.txtWORK_ST_TIME.Top = 0.13!
        Me.txtWORK_ST_TIME.Width = 0.3745003!
        '
        'txtWORK_ED_TIME
        '
        Me.txtWORK_ED_TIME.Height = 0.125!
        Me.txtWORK_ED_TIME.Left = 9.9375!
        Me.txtWORK_ED_TIME.Name = "txtWORK_ED_TIME"
        Me.txtWORK_ED_TIME.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.txtWORK_ED_TIME.Text = "HH:MM"
        Me.txtWORK_ED_TIME.Top = 0.13!
        Me.txtWORK_ED_TIME.Width = 0.3745003!
        '
        'txtDIFF2
        '
        Me.txtDIFF2.Height = 0.125!
        Me.txtDIFF2.Left = 10.75!
        Me.txtDIFF2.Name = "txtDIFF2"
        Me.txtDIFF2.OutputFormat = resources.GetString("txtDIFF2.OutputFormat")
        Me.txtDIFF2.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtDIFF2.Text = "9,999,999"
        Me.txtDIFF2.Top = 0!
        Me.txtDIFF2.Width = 0.5625!
        '
        'txtCYCLE_TIME
        '
        Me.txtCYCLE_TIME.DataField = "CYCLE_TIME"
        Me.txtCYCLE_TIME.Height = 0.125!
        Me.txtCYCLE_TIME.Left = 11.375!
        Me.txtCYCLE_TIME.Name = "txtCYCLE_TIME"
        Me.txtCYCLE_TIME.OutputFormat = resources.GetString("txtCYCLE_TIME.OutputFormat")
        Me.txtCYCLE_TIME.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtCYCLE_TIME.Text = "9,999.99"
        Me.txtCYCLE_TIME.Top = 0!
        Me.txtCYCLE_TIME.Width = 0.5!
        '
        'txtJitsuKadouRitsu
        '
        Me.txtJitsuKadouRitsu.Height = 0.125!
        Me.txtJitsuKadouRitsu.Left = 11.9375!
        Me.txtJitsuKadouRitsu.Name = "txtJitsuKadouRitsu"
        Me.txtJitsuKadouRitsu.OutputFormat = resources.GetString("txtJitsuKadouRitsu.OutputFormat")
        Me.txtJitsuKadouRitsu.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtJitsuKadouRitsu.Text = "9999.99"
        Me.txtJitsuKadouRitsu.Top = 0!
        Me.txtJitsuKadouRitsu.Width = 0.5!
        '
        'txtJitsuKadouTime
        '
        Me.txtJitsuKadouTime.Height = 0.125!
        Me.txtJitsuKadouTime.Left = 12.625!
        Me.txtJitsuKadouTime.Name = "txtJitsuKadouTime"
        Me.txtJitsuKadouTime.OutputFormat = resources.GetString("txtJitsuKadouTime.OutputFormat")
        Me.txtJitsuKadouTime.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtJitsuKadouTime.Text = "999,999.99"
        Me.txtJitsuKadouTime.Top = 0!
        Me.txtJitsuKadouTime.Width = 0.625!
        '
        'txtTACT_TIME
        '
        Me.txtTACT_TIME.DataField = "TACT_TIME"
        Me.txtTACT_TIME.Height = 0.125!
        Me.txtTACT_TIME.Left = 13.3125!
        Me.txtTACT_TIME.Name = "txtTACT_TIME"
        Me.txtTACT_TIME.OutputFormat = resources.GetString("txtTACT_TIME.OutputFormat")
        Me.txtTACT_TIME.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtTACT_TIME.Text = "9,999.99"
        Me.txtTACT_TIME.Top = 0!
        Me.txtTACT_TIME.Width = 0.5!
        '
        'Label11
        '
        Me.Label11.Height = 0.125!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 12.4375!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt"
        Me.Label11.Text = "%"
        Me.Label11.Top = 0!
        Me.Label11.Width = 0.125!
        '
        'txtJinteki
        '
        Me.txtJinteki.Height = 0.125!
        Me.txtJinteki.Left = 13.875!
        Me.txtJinteki.Name = "txtJinteki"
        Me.txtJinteki.OutputFormat = resources.GetString("txtJinteki.OutputFormat")
        Me.txtJinteki.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtJinteki.Text = "9999.99"
        Me.txtJinteki.Top = 0!
        Me.txtJinteki.Width = 0.5!
        '
        'Label12
        '
        Me.Label12.Height = 0.125!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 14.375!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt"
        Me.Label12.Text = "%"
        Me.Label12.Top = 0!
        Me.Label12.Width = 0.125!
        '
        'txtGRP_NM2
        '
        Me.txtGRP_NM2.DataField = "GRP_NM2"
        Me.txtGRP_NM2.Height = 0.125!
        Me.txtGRP_NM2.Left = 0.063!
        Me.txtGRP_NM2.MultiLine = false
        Me.txtGRP_NM2.Name = "txtGRP_NM2"
        Me.txtGRP_NM2.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: left; vertical-align: middle" & _
            "; white-space: nowrap"
        Me.txtGRP_NM2.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txtGRP_NM2.Top = 0.13!
        Me.txtGRP_NM2.Width = 1.1245!
        '
        'txtC_NO
        '
        Me.txtC_NO.DataField = "C_NO"
        Me.txtC_NO.Height = 0.125!
        Me.txtC_NO.Left = 2.9375!
        Me.txtC_NO.Name = "txtC_NO"
        Me.txtC_NO.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtC_NO.Text = "WX"
        Me.txtC_NO.Top = 0.125!
        Me.txtC_NO.Width = 0.1875!
        '
        'hdnP_ORDER
        '
        Me.hdnP_ORDER.DataField = "P_ORDER"
        Me.hdnP_ORDER.Height = 0.125!
        Me.hdnP_ORDER.Left = 1.25!
        Me.hdnP_ORDER.Name = "hdnP_ORDER"
        Me.hdnP_ORDER.Style = "color: Red; font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.hdnP_ORDER.Text = "999-9"
        Me.hdnP_ORDER.Top = 0.13!
        Me.hdnP_ORDER.Visible = false
        Me.hdnP_ORDER.Width = 0.375!
        '
        'hdnWORK_TIME_KB
        '
        Me.hdnWORK_TIME_KB.DataField = "WORK_TIME_KB"
        Me.hdnWORK_TIME_KB.Height = 0.125!
        Me.hdnWORK_TIME_KB.Left = 11.5!
        Me.hdnWORK_TIME_KB.Name = "hdnWORK_TIME_KB"
        Me.hdnWORK_TIME_KB.Style = "color: Red; font-family: ＭＳ ゴシック; font-size: 8.25pt"
        Me.hdnWORK_TIME_KB.Text = "WORK_TIME_KB"
        Me.hdnWORK_TIME_KB.Top = 0.13!
        Me.hdnWORK_TIME_KB.Visible = false
        Me.hdnWORK_TIME_KB.Width = 0.3745003!
        '
        'hdnDIFF2
        '
        Me.hdnDIFF2.DataField = "DIFF2"
        Me.hdnDIFF2.Height = 0.125!
        Me.hdnDIFF2.Left = 10.7505!
        Me.hdnDIFF2.Name = "hdnDIFF2"
        Me.hdnDIFF2.Style = "color: Red; font-family: ＭＳ ゴシック; font-size: 8.25pt"
        Me.hdnDIFF2.Text = "DIFF2"
        Me.hdnDIFF2.Top = 0.13!
        Me.hdnDIFF2.Visible = false
        Me.hdnDIFF2.Width = 0.3745003!
        '
        'hdnWORK_ST_DT
        '
        Me.hdnWORK_ST_DT.DataField = "WORK_ST_DT"
        Me.hdnWORK_ST_DT.Height = 0.125!
        Me.hdnWORK_ST_DT.Left = 12!
        Me.hdnWORK_ST_DT.Name = "hdnWORK_ST_DT"
        Me.hdnWORK_ST_DT.Style = "color: Red"
        Me.hdnWORK_ST_DT.Text = "WORK_ST_DT"
        Me.hdnWORK_ST_DT.Top = 0.125!
        Me.hdnWORK_ST_DT.Visible = false
        Me.hdnWORK_ST_DT.Width = 0.563!
        '
        'hdnWORK_ST_TIME
        '
        Me.hdnWORK_ST_TIME.DataField = "WORK_ST_TIME"
        Me.hdnWORK_ST_TIME.Height = 0.125!
        Me.hdnWORK_ST_TIME.Left = 12.625!
        Me.hdnWORK_ST_TIME.Name = "hdnWORK_ST_TIME"
        Me.hdnWORK_ST_TIME.Style = "color: Red"
        Me.hdnWORK_ST_TIME.Text = "WORK_ST_TIME"
        Me.hdnWORK_ST_TIME.Top = 0.125!
        Me.hdnWORK_ST_TIME.Visible = false
        Me.hdnWORK_ST_TIME.Width = 0.625!
        '
        'hdnWORK_ED_DT
        '
        Me.hdnWORK_ED_DT.DataField = "WORK_ED_DT"
        Me.hdnWORK_ED_DT.Height = 0.125!
        Me.hdnWORK_ED_DT.Left = 13.3125!
        Me.hdnWORK_ED_DT.Name = "hdnWORK_ED_DT"
        Me.hdnWORK_ED_DT.Style = "color: Red"
        Me.hdnWORK_ED_DT.Text = "WORK_ED_DT"
        Me.hdnWORK_ED_DT.Top = 0.125!
        Me.hdnWORK_ED_DT.Visible = false
        Me.hdnWORK_ED_DT.Width = 0.5!
        '
        'hdnWORK_ED_TIME
        '
        Me.hdnWORK_ED_TIME.DataField = "WORK_ED_TIME"
        Me.hdnWORK_ED_TIME.Height = 0.125!
        Me.hdnWORK_ED_TIME.Left = 13.875!
        Me.hdnWORK_ED_TIME.Name = "hdnWORK_ED_TIME"
        Me.hdnWORK_ED_TIME.Style = "color: Red"
        Me.hdnWORK_ED_TIME.Text = "WORK_ED_TIME"
        Me.hdnWORK_ED_TIME.Top = 0.125!
        Me.hdnWORK_ED_TIME.Visible = false
        Me.hdnWORK_ED_TIME.Width = 0.625!
        '
        'txtJintekiTime
        '
        Me.txtJintekiTime.Height = 0.125!
        Me.txtJintekiTime.Left = 14.625!
        Me.txtJintekiTime.Name = "txtJintekiTime"
        Me.txtJintekiTime.OutputFormat = resources.GetString("txtJintekiTime.OutputFormat")
        Me.txtJintekiTime.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtJintekiTime.Text = "999,999.99"
        Me.txtJintekiTime.Top = 0!
        Me.txtJintekiTime.Width = 0.625!
        '
        'txtSumJintekiTime
        '
        Me.txtSumJintekiTime.Height = 0.125!
        Me.txtSumJintekiTime.Left = 14.625!
        Me.txtSumJintekiTime.Name = "txtSumJintekiTime"
        Me.txtSumJintekiTime.OutputFormat = resources.GetString("txtSumJintekiTime.OutputFormat")
        Me.txtSumJintekiTime.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSumJintekiTime.Text = "999,999.99"
        Me.txtSumJintekiTime.Top = 0!
        Me.txtSumJintekiTime.Width = 0.625!
        '
        'txtSumJinteki
        '
        Me.txtSumJinteki.Height = 0.125!
        Me.txtSumJinteki.Left = 13.875!
        Me.txtSumJinteki.Name = "txtSumJinteki"
        Me.txtSumJinteki.OutputFormat = resources.GetString("txtSumJinteki.OutputFormat")
        Me.txtSumJinteki.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSumJinteki.Text = "9999.99"
        Me.txtSumJinteki.Top = 0!
        Me.txtSumJinteki.Width = 0.5!
        '
        'Label38
        '
        Me.Label38.Height = 0.125!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 14.375!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt"
        Me.Label38.Text = "%"
        Me.Label38.Top = 0!
        Me.Label38.Width = 0.125!
        '
        'txtSumJitsuKadou
        '
        Me.txtSumJitsuKadou.Height = 0.125!
        Me.txtSumJitsuKadou.Left = 12.625!
        Me.txtSumJitsuKadou.Name = "txtSumJitsuKadou"
        Me.txtSumJitsuKadou.OutputFormat = resources.GetString("txtSumJitsuKadou.OutputFormat")
        Me.txtSumJitsuKadou.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSumJitsuKadou.Text = "999,999.99"
        Me.txtSumJitsuKadou.Top = 0!
        Me.txtSumJitsuKadou.Width = 0.625!
        '
        'txtSumKadou
        '
        Me.txtSumKadou.Height = 0.125!
        Me.txtSumKadou.Left = 10.75!
        Me.txtSumKadou.Name = "txtSumKadou"
        Me.txtSumKadou.OutputFormat = resources.GetString("txtSumKadou.OutputFormat")
        Me.txtSumKadou.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSumKadou.Text = "9,999,999"
        Me.txtSumKadou.Top = 0!
        Me.txtSumKadou.Width = 0.5625!
        '
        'txtTitel
        '
        Me.txtTitel.Height = 0.125!
        Me.txtTitel.Left = 2.938!
        Me.txtTitel.Name = "txtTitel"
        Me.txtTitel.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: left; vertical-align: middle" & _
            ""
        Me.txtTitel.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txtTitel.Top = 0!
        Me.txtTitel.Width = 1.562!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.13!
        Me.Line2.Width = 15.9!
        Me.Line2.X1 = 0!
        Me.Line2.X2 = 15.9!
        Me.Line2.Y1 = 0.13!
        Me.Line2.Y2 = 0.13!
        '
        'hdnTitel
        '
        Me.hdnTitel.DataField = "C_NO"
        Me.hdnTitel.Height = 0.125!
        Me.hdnTitel.Left = 7.5!
        Me.hdnTitel.Name = "hdnTitel"
        Me.hdnTitel.Style = "color: Red"
        Me.hdnTitel.Text = "hdnTitel"
        Me.hdnTitel.Top = 0!
        Me.hdnTitel.Visible = false
        Me.hdnTitel.Width = 0.5625!
        '
        'Label40
        '
        Me.Label40.Height = 0.125!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 14.3755!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt"
        Me.Label40.Text = "%"
        Me.Label40.Top = 0.01!
        Me.Label40.Width = 0.125!
        '
        'txtSouSumJinteki
        '
        Me.txtSouSumJinteki.Height = 0.125!
        Me.txtSouSumJinteki.Left = 13.8755!
        Me.txtSouSumJinteki.Name = "txtSouSumJinteki"
        Me.txtSouSumJinteki.OutputFormat = resources.GetString("txtSouSumJinteki.OutputFormat")
        Me.txtSouSumJinteki.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSouSumJinteki.Text = "9999.99"
        Me.txtSouSumJinteki.Top = 0.01!
        Me.txtSouSumJinteki.Width = 0.5!
        '
        'txtSouSumJitsuKadou
        '
        Me.txtSouSumJitsuKadou.Height = 0.125!
        Me.txtSouSumJitsuKadou.Left = 12.625!
        Me.txtSouSumJitsuKadou.Name = "txtSouSumJitsuKadou"
        Me.txtSouSumJitsuKadou.OutputFormat = resources.GetString("txtSouSumJitsuKadou.OutputFormat")
        Me.txtSouSumJitsuKadou.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSouSumJitsuKadou.Text = "999,999.99"
        Me.txtSouSumJitsuKadou.Top = 0.01!
        Me.txtSouSumJitsuKadou.Width = 0.625!
        '
        'txtSouSumKadou
        '
        Me.txtSouSumKadou.Height = 0.125!
        Me.txtSouSumKadou.Left = 10.75!
        Me.txtSouSumKadou.Name = "txtSouSumKadou"
        Me.txtSouSumKadou.OutputFormat = resources.GetString("txtSouSumKadou.OutputFormat")
        Me.txtSouSumKadou.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSouSumKadou.Text = "9,999,999"
        Me.txtSouSumKadou.Top = 0.01!
        Me.txtSouSumKadou.Width = 0.5625!
        '
        'Label39
        '
        Me.Label39.Height = 0.15!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 4.563!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; vertical-align: middle"
        Me.Label39.Text = "合計"
        Me.Label39.Top = 0.01!
        Me.Label39.Width = 0.313!
        '
        'txtSouSumJintekiTime
        '
        Me.txtSouSumJintekiTime.Height = 0.125!
        Me.txtSouSumJintekiTime.Left = 14.625!
        Me.txtSouSumJintekiTime.Name = "txtSouSumJintekiTime"
        Me.txtSouSumJintekiTime.OutputFormat = resources.GetString("txtSouSumJintekiTime.OutputFormat")
        Me.txtSouSumJintekiTime.Style = "font-family: ＭＳ ゴシック; font-size: 8.25pt; text-align: right; vertical-align: middl" & _
            "e"
        Me.txtSouSumJintekiTime.Text = "999,999.99"
        Me.txtSouSumJintekiTime.Top = 0.01!
        Me.txtSouSumJintekiTime.Width = 0.625!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medproc;User ID=medproc;Data Source=medproc;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = false
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.1!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 16.53542!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A3
        Me.PageSettings.PaperWidth = 11.69306!
        Me.PrintWidth = 15.92708!
        Me.Sections.Add(Me.ReportHeader)
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.Sections.Add(Me.ReportFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit
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
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGRP_NM1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCATALOG_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOMPANY_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtP_ORDER, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPROCESS_C, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtP_ORDER_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtFACILITIES_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtFACILITIES_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtFACILITIES_G_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtFACILITIES_G_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWORKER_CD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWORKER_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPW_AMT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtARTICLE_ANT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSS_ARTICLE_ANT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPREPARATION_AMT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWORK_ST_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWORK_ED_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWORK_ST_TIME, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtWORK_ED_TIME, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDIFF2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCYCLE_TIME, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtJitsuKadouRitsu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtJitsuKadouTime, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTACT_TIME, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtJinteki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGRP_NM2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtC_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hdnP_ORDER, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hdnWORK_TIME_KB, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hdnDIFF2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hdnWORK_ST_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hdnWORK_ST_TIME, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hdnWORK_ED_DT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hdnWORK_ED_TIME, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtJintekiTime, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSumJintekiTime, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSumJinteki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSumJitsuKadou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSumKadou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTitel, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.hdnTitel, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSouSumJinteki, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSouSumJitsuKadou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSouSumKadou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSouSumJintekiTime, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1
    Private _sMedicalDNS As String = "User Id=medproc;Password=medproc;Data Source=medproc;"

    Private _oConnection As OracleConnection = Nothing
    'Private nDandoriKei As Integer = 0  '###### 2010/05/19 DEL
    Private nKadouKei As Integer = 0
    Private nJitsuKadouKei As Double = 0
    Private nJinKadouKei As Double = 0
    'Private nDandoriSouKei As Integer = 0  '###### 2010/05/19 DEL
    Private nKadouSouKei As Integer = 0
    Private nJitsuKadouSouKei As Double = 0
    Private nJinKadouSouKei As Double = 0

#Region " プロパティ "

    Public WriteOnly Property Connect() As String
        Set(ByVal sValue As String)
            _sMedicalDNS = sValue
        End Set
    End Property

    Public WriteOnly Property fromYMD() As String
        Set(ByVal sValue As String)
            lblFrom.Text = sValue.Substring(0, 4) & "/" & sValue.Substring(4, 2) & "/" & sValue.Substring(6, 2)
        End Set
    End Property

    Public WriteOnly Property toYMD() As String
        Set(ByVal sValue As String)
            lblTo.Text = sValue.Substring(0, 4) & "/" & sValue.Substring(4, 2) & "/" & sValue.Substring(6, 2)
        End Set
    End Property

#End Region

    Private Sub mdjsk1701_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        _oConnection = New OracleConnection(_sMedicalDNS)
        _oConnection.Open()
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblPage.Text = nPage
        nPage += 1
        'lblSysDate.Text = Format(System.DateTime.Now, "yyyy/MM/dd")
        lblSysDate.Text = System.DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        'nDandoriKei = 0  '###### 2010/05/19 DEL
        nKadouKei = 0
        nJitsuKadouKei = 0
        nJinKadouKei = 0
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Dim nDandori As Integer = 0
        Dim nKadou As Integer = 0
        Dim nJitsuKadouRitsu As Double = 0
        Dim nJitsuKadou As Double = 0
        Dim nJinKadou As Double = 0
        Dim nJinKadouRitsu As Double = 0

        '工程順序
        Dim sValues() As String = Me.hdnP_ORDER.Value.Split(",")
        Me.txtP_ORDER.Value = GetKoujun(sValues(0), sValues(1))
        '###### 2010/05/19 DEL
        '段取り時間
        'sValues = Me.hdnDIFF1.Value.split(",")
        'nDandori = GetOperatingTime(Me.hdnWORK_TIME_KB.Value, sValues(0), sValues(1), sValues(2), sValues(3))
        'Me.txtDIFF1.Value = nDandori
        'nDandoriKei += nDandori
        '###### 2010/05/19 DEL
        '作業開始日付
        Me.txtWORK_ST_DT.Value = hdnWORK_ST_DT.Value.Substring(0, 4) & "/" & hdnWORK_ST_DT.Value.Substring(4, 2) & "/" & hdnWORK_ST_DT.Value.Substring(6, 2)
        '作業開始時刻
        Me.txtWORK_ST_TIME.Value = hdnWORK_ST_TIME.Value.Substring(0, 2) & ":" & hdnWORK_ST_TIME.Value.Substring(2, 2)
        '作業終了日付
        Me.txtWORK_ED_DT.Value = hdnWORK_ED_DT.Value.Substring(0, 4) & "/" & hdnWORK_ED_DT.Value.Substring(4, 2) & "/" & hdnWORK_ED_DT.Value.Substring(6, 2)
        '作業終了時刻
        Me.txtWORK_ED_TIME.Value = hdnWORK_ED_TIME.Value.Substring(0, 2) & ":" & hdnWORK_ED_TIME.Value.Substring(2, 2)
        '稼働時間
        sValues = Me.hdnDIFF2.Value.split(",")
        nKadou = GetOperatingTime(Me.hdnWORK_TIME_KB.Value, sValues(0), sValues(1), sValues(2), sValues(3))
        Me.txtDIFF2.Value = nKadou
        nKadouKei += nKadou
        '実稼働時間
        nJitsuKadou = (Me.txtARTICLE_ANT.Value + Me.txtSS_ARTICLE_ANT.Value + Me.txtPREPARATION_AMT.Value) * Me.txtCYCLE_TIME.Value
        Me.txtJitsuKadouTime.Value = nJitsuKadou
        nJitsuKadouKei += nJitsuKadou
        '実稼働率
        If nKadou <> 0 And nJitsuKadou <> 0 Then
            nJitsuKadouRitsu = (nJitsuKadou / nKadou) * 100
        Else
            nJitsuKadouRitsu = 0
        End If
        Me.txtJitsuKadouRitsu.Value = nJitsuKadouRitsu
        '人的可動率
        nJinKadou = (Me.txtARTICLE_ANT.Value + Me.txtSS_ARTICLE_ANT.Value + Me.txtPREPARATION_AMT.Value) * Me.txtTACT_TIME.Value
        nJinKadouKei += nJinKadou
        If nKadou <> 0 And nJinKadou <> 0 Then
            nJinKadouRitsu = (nJinKadou / nKadou) * 100
        Else
            nJinKadouRitsu = 0
        End If
        Me.txtJinteki.Value = nJinKadouRitsu
        '人的稼働時間
        Me.txtJintekiTime.Value = nJinKadou
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        Me.txtTitel.Value = Me.hdnTitel.Value.ToString.Trim + " 計"
        '###### 2010/05/19 DEL
        'Me.txtSumDandori.Value = nDandoriKei
        'nDandoriSouKei += nDandoriKei
        '###### 2010/05/19 DEL
        Me.txtSumKadou.Value = nKadouKei
        nKadouSouKei += nKadouKei
        Me.txtSumJitsuKadou.Value = nJitsuKadouKei
        nJitsuKadouSouKei += nJitsuKadouKei
        If nKadouKei <> 0 And nJinKadouKei <> 0 Then
            Me.txtSumJinteki.Value = (nJinKadouKei / nKadouKei) * 100
        Else
            Me.txtSumJinteki.Value = 0
        End If
        nJinKadouSouKei += nJinKadouKei
        Me.txtSumJintekiTime.Value = nJinKadouKei
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        'Me.txtSouSumDandori.Value = nDandoriSouKei  '###### 2010/05/19 DEL
        Me.txtSouSumKadou.Value = nKadouSouKei
        Me.txtSouSumJitsuKadou.Value = nJitsuKadouSouKei
        If nKadouSouKei <> 0 And nJinKadouSouKei <> 0 Then
            Me.txtSouSumJinteki.Value = (nJinKadouSouKei / nKadouSouKei) * 100
        Else
            Me.txtSouSumJinteki.Value = 0
        End If
        Me.txtSouSumJintekiTime.Value = nJinKadouSouKei
    End Sub

#Region " その他 "

    '工順編集 
    Private Function GetKoujun(ByVal oKihon As Object, ByVal oHojo As Object) As String
        If oKihon.ToString.Equals("") Then Return ""
        Dim sKoujun As String = CType(oKihon, Integer).ToString("000")
        If oHojo.ToString.Equals("") Then Return sKoujun
        If CType(oHojo, Integer) <> 0 Then sKoujun += "-" + oHojo.ToString()
        Return sKoujun
    End Function

    '稼動時間算出
    Private Function GetOperatingTime(ByVal sWorkKubun As String, ByVal sStartDate As String, ByVal sStartTime As String, ByVal sEndDate As String, ByVal sEndTime As String) As Double
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim nHolidayCount As Integer = 0
        Dim nOpeartingTime As Double = 0
        Dim nOperatingMinute As Double = 0
        Try
            If sStartDate.Trim.Equals("") Or sStartTime.Trim.Equals("") Or sEndDate.Trim.Equals("") Or sEndTime.Trim.Equals("") Or
               sStartDate.Trim.Equals("00000000") Or sEndDate.Trim.Equals("00000000") Then Return 0
            '稼動時間算出(分指定)
            nOperatingMinute = DateDiff("n", Date.ParseExact(sStartDate & sStartTime, "yyyyMMddHHmm", Nothing), Date.ParseExact(sEndDate & sEndTime, "yyyyMMddHHmm", Nothing))
            '公休日回数 
            If sStartDate < sEndDate Then
                sQuery = "SELECT COUNT(C_DATE) FROM CALENDAR_MST WHERE C_DATE > '" + sStartDate + "' AND C_DATE < '" + sEndDate + "' AND WORK_FLG = '1'"
                Dim oCommand As OracleCommand = _oConnection.CreateCommand()
                oCommand.CommandText = sQuery
                oReader = oCommand.ExecuteReader
                oReader.Read()
                nOperatingMinute -= oReader.GetInt32(0).ToString * 24 * 60
                nHolidayCount = oReader.GetInt32(0)
                oReader.Close()
            End If
            If (sStartDate = sEndDate) Or (sStartDate < sEndDate And sStartTime <= sEndTime) Then
                If sStartTime < "120000" And sEndTime > "124500" Then nOperatingMinute -= 45
                '###### 2010/01/15 休憩時間変更(18:30～19:15→19:30～20:15) Mod ######
                If sEndDate <= "20091231" Then
                    If sStartTime < "183000" And sEndTime > "191500" Then nOperatingMinute -= 45
                Else
                    If sStartTime < "193000" And sEndTime > "201500" Then nOperatingMinute -= 45
                End If
                '###### 2010/01/15 休憩時間変更(18:30～19:15→19:30～20:15) Mod ######
                If CDbl(DateDiff("n", Date.ParseExact(sStartDate & sStartTime, "yyyyMMddHHmm", Nothing), Date.ParseExact(sEndDate & sEndTime, "yyyyMMddHHmm", Nothing))) >= 1440 Then
                    If sWorkKubun.Trim.Equals("01") Then
                        nOperatingMinute -= ((DateDiff("d", sStartDate.Substring(0, 4) + "/" + sStartDate.Substring(4, 2) + "/" + sStartDate.Substring(6, 2), sEndDate.Substring(0, 4) + "/" + sEndDate.Substring(4, 2) + "/" + sEndDate.Substring(6, 2)) - nHolidayCount) * 9.5 * 60)
                    ElseIf sWorkKubun.Trim.Equals("02") Then
                        nOperatingMinute -= ((DateDiff("d", sStartDate.Substring(0, 4) + "/" + sStartDate.Substring(4, 2) + "/" + sStartDate.Substring(6, 2), sEndDate.Substring(0, 4) + "/" + sEndDate.Substring(4, 2) + "/" + sEndDate.Substring(6, 2)) - nHolidayCount) * 1.5 * 60)
                    End If
                End If
            ElseIf (sStartDate < sEndDate) And (sStartTime > sEndTime) Then
                If sStartTime < "120000" Then nOperatingMinute -= 45
                If sEndTime > "124500" Then nOperatingMinute -= 45
                '###### 2010/01/15 休憩時間変更(18:30～19:15→19:30～20:15) Mod ######
                If sEndDate <= "20091231" Then
                    If sStartTime < "183000" Then nOperatingMinute -= 45
                    If sEndTime > "191500" Then nOperatingMinute -= 45
                Else
                    If sStartTime < "193000" Then nOperatingMinute -= 45
                    If sEndTime > "201500" Then nOperatingMinute -= 45
                End If
                '###### 2010/01/15 休憩時間変更(18:30～19:15→19:30～20:15) Mod ######
                If sWorkKubun.Trim.Equals("01") Then
                    nOperatingMinute -= ((DateDiff("d", sStartDate.Substring(0, 4) + "/" + sStartDate.Substring(4, 2) + "/" + sStartDate.Substring(6, 2), sEndDate.Substring(0, 4) + "/" + sEndDate.Substring(4, 2) + "/" + sEndDate.Substring(6, 2)) - nHolidayCount - 1) * 9.5 * 60)
                ElseIf sWorkKubun.Trim.Equals("02") Then
                    nOperatingMinute -= ((DateDiff("d", sStartDate.Substring(0, 4) + "/" + sStartDate.Substring(4, 2) + "/" + sStartDate.Substring(6, 2), sEndDate.Substring(0, 4) + "/" + sEndDate.Substring(4, 2) + "/" + sEndDate.Substring(6, 2)) - nHolidayCount - 1) * 1.5 * 60)
                End If
            End If
            nOpeartingTime = nOperatingMinute

        Catch ex As Exception
            'MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
        Return nOpeartingTime
    End Function

#End Region

End Class
