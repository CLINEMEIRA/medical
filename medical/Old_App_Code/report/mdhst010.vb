Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports Microsoft.VisualBasic

Public Class mdhst010
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
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Shape As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblMonth As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtNyukoNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtRenNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZairyoCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtChumonNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNyukoMotoCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtZairyoLotNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNyukoRyo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtNyukoDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private lblLast1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTextFile As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdhst010))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblMonth = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtNyukoNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRenNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZairyoCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtChumonNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNyukoMotoCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtZairyoLotNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNyukoRyo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNyukoDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblLast1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTextFile = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNyukoNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRenNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyoCode, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtChumonNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNyukoMotoCode, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyoLotNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNyukoRyo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNyukoDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblLast1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTextFile, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtNyukoNo, Me.txtRenNo, Me.txtZairyoCode, Me.txtChumonNo, Me.txtNyukoMotoCode, Me.txtZairyoLotNo, Me.txtNyukoRyo, Me.txtNyukoDate})
        Me.Detail.Height = 0.2076389!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label, Me.lblDate, Me.Label12, Me.lblPage, Me.Shape, Me.Line, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.lblMonth})
        Me.PageHeader.Height = 0.9395834!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblLast1, Me.lblTextFile})
        Me.PageFooter.Height = 0.5!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.06666667!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; vertical-align: bottom" & _
            ""
        Me.Label.Text = "材料入庫実績チェックリスト"
        Me.Label.Top = 0.06666667!
        Me.Label.Width = 7.333333!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2000001!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.lblDate.Text = "YYYY/MM/DD"
        Me.lblDate.Top = 0.06666667!
        Me.lblDate.Width = 0.7333333!
        '
        'Label12
        '
        Me.Label12.Height = 0.2000001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 6.8!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.Label12.Text = "PAGE."
        Me.Label12.Top = 0.06666674!
        Me.Label12.Width = 0.3333335!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2000001!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 7.133333!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap"
        Me.lblPage.Text = "999"
        Me.lblPage.Top = 0.06666669!
        Me.lblPage.Width = 0.2666669!
        '
        'Shape
        '
        Me.Shape.Height = 0.2!
        Me.Shape.Left = 2.533333!
        Me.Shape.Name = "Shape"
        Me.Shape.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape.Top = 0.06666667!
        Me.Shape.Width = 2.4!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.06666667!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.9333333!
        Me.Line.Width = 7.2!
        Me.Line.X1 = 0.06666667!
        Me.Line.X2 = 7.266667!
        Me.Line.Y1 = 0.9333333!
        Me.Line.Y2 = 0.9333333!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.1333333!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            ""
        Me.Label1.Text = "入庫No"
        Me.Label1.Top = 0.7333333!
        Me.Label1.Width = 0.6000001!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.8666667!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label2.Text = "連No"
        Me.Label2.Top = 0.7333333!
        Me.Label2.Width = 0.5333332!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.533333!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            ""
        Me.Label3.Text = "材料コード"
        Me.Label3.Top = 0.7333333!
        Me.Label3.Width = 0.7333333!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.733333!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            ""
        Me.Label4.Text = "注文No"
        Me.Label4.Top = 0.7333333!
        Me.Label4.Width = 0.5333332!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.399999!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            ""
        Me.Label5.Text = "入庫元コード"
        Me.Label5.Top = 0.7333333!
        Me.Label5.Width = 0.8666673!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.399999!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            ""
        Me.Label6.Text = "材料ロットNo"
        Me.Label6.Top = 0.7333333!
        Me.Label6.Width = 0.8666673!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.8!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.Label7.Text = "入庫量"
        Me.Label7.Top = 0.7333333!
        Me.Label7.Width = 0.5333332!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 6.466667!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.Label8.Text = "入庫日付"
        Me.Label8.Top = 0.7333333!
        Me.Label8.Width = 0.7333333!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.1333333!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            ""
        Me.Label9.Text = "データ抽出年月："
        Me.Label9.Top = 0.4!
        Me.Label9.Width = 1.133333!
        '
        'lblMonth
        '
        Me.lblMonth.Height = 0.2!
        Me.lblMonth.HyperLink = Nothing
        Me.lblMonth.Left = 1.2!
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            ""
        Me.lblMonth.Text = "YYYY/MM"
        Me.lblMonth.Top = 0.4!
        Me.lblMonth.Width = 0.5333332!
        '
        'txtNyukoNo
        '
        Me.txtNyukoNo.DataField = "WH_NO"
        Me.txtNyukoNo.Height = 0.2!
        Me.txtNyukoNo.Left = 0.1333333!
        Me.txtNyukoNo.Name = "txtNyukoNo"
        Me.txtNyukoNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.txtNyukoNo.Text = "XXXXXXXX"
        Me.txtNyukoNo.Top = 0!
        Me.txtNyukoNo.Width = 0.6000001!
        '
        'txtRenNo
        '
        Me.txtRenNo.DataField = "REN_NO"
        Me.txtRenNo.Height = 0.2!
        Me.txtRenNo.Left = 0.9333333!
        Me.txtRenNo.Name = "txtRenNo"
        Me.txtRenNo.OutputFormat = resources.GetString("txtRenNo.OutputFormat")
        Me.txtRenNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.txtRenNo.Text = "#####"
        Me.txtRenNo.Top = 0!
        Me.txtRenNo.Width = 0.3999999!
        '
        'txtZairyoCode
        '
        Me.txtZairyoCode.DataField = "MATL_CD"
        Me.txtZairyoCode.Height = 0.2!
        Me.txtZairyoCode.Left = 1.533333!
        Me.txtZairyoCode.Name = "txtZairyoCode"
        Me.txtZairyoCode.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.txtZairyoCode.Text = "XXXXXXXXXXXXXXX"
        Me.txtZairyoCode.Top = 0!
        Me.txtZairyoCode.Width = 1.066667!
        '
        'txtChumonNo
        '
        Me.txtChumonNo.DataField = "M_ORDER_NO"
        Me.txtChumonNo.Height = 0.2!
        Me.txtChumonNo.Left = 2.733333!
        Me.txtChumonNo.Name = "txtChumonNo"
        Me.txtChumonNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.txtChumonNo.Text = "XXXXXXX"
        Me.txtChumonNo.Top = 0!
        Me.txtChumonNo.Width = 0.5333332!
        '
        'txtNyukoMotoCode
        '
        Me.txtNyukoMotoCode.DataField = "WH_O_CD"
        Me.txtNyukoMotoCode.Height = 0.2!
        Me.txtNyukoMotoCode.Left = 3.666667!
        Me.txtNyukoMotoCode.Name = "txtNyukoMotoCode"
        Me.txtNyukoMotoCode.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.txtNyukoMotoCode.Text = "XXXX"
        Me.txtNyukoMotoCode.Top = 0!
        Me.txtNyukoMotoCode.Width = 0.3333335!
        '
        'txtZairyoLotNo
        '
        Me.txtZairyoLotNo.DataField = "LOT_NO"
        Me.txtZairyoLotNo.Height = 0.2!
        Me.txtZairyoLotNo.Left = 4.6!
        Me.txtZairyoLotNo.Name = "txtZairyoLotNo"
        Me.txtZairyoLotNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: bottom"
        Me.txtZairyoLotNo.Text = "XXXXXX"
        Me.txtZairyoLotNo.Top = 0!
        Me.txtZairyoLotNo.Width = 0.4666668!
        '
        'txtNyukoRyo
        '
        Me.txtNyukoRyo.DataField = "WH_WAT"
        Me.txtNyukoRyo.Height = 0.2!
        Me.txtNyukoRyo.Left = 5.4!
        Me.txtNyukoRyo.Name = "txtNyukoRyo"
        Me.txtNyukoRyo.OutputFormat = resources.GetString("txtNyukoRyo.OutputFormat")
        Me.txtNyukoRyo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: right; vertical-align: botto" & _
            "m"
        Me.txtNyukoRyo.Text = "-#,###,###.##"
        Me.txtNyukoRyo.Top = 0!
        Me.txtNyukoRyo.Width = 0.9333333!
        '
        'txtNyukoDate
        '
        Me.txtNyukoDate.DataField = "WH_DT"
        Me.txtNyukoDate.Height = 0.2!
        Me.txtNyukoDate.Left = 6.466667!
        Me.txtNyukoDate.Name = "txtNyukoDate"
        Me.txtNyukoDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.txtNyukoDate.Text = "YYYY/MM/DD"
        Me.txtNyukoDate.Top = 0!
        Me.txtNyukoDate.Width = 0.7333333!
        '
        'lblLast1
        '
        Me.lblLast1.Height = 0.2!
        Me.lblLast1.HyperLink = Nothing
        Me.lblLast1.Left = 0.06666667!
        Me.lblLast1.Name = "lblLast1"
        Me.lblLast1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.lblLast1.Text = "入庫元コードなしか、入庫日が抽出範囲ではないもの"
        Me.lblLast1.Top = 0.06666667!
        Me.lblLast1.Width = 7.333333!
        '
        'lblTextFile
        '
        Me.lblTextFile.Height = 0.2!
        Me.lblTextFile.HyperLink = Nothing
        Me.lblTextFile.Left = 0.06666667!
        Me.lblTextFile.Name = "lblTextFile"
        Me.lblTextFile.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: center; vertical-align: bott" & _
            "om"
        Me.lblTextFile.Text = "(\\XXX.XXX.XXX.XXX\生産部\NRS\MAGIC2\TRANS\KLF202.TXT)"
        Me.lblTextFile.Top = 0.2666667!
        Me.lblTextFile.Width = 7.333333!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = "SELECT WH_NO,REN_NO,MATL_CD,M_ORDER_NO,WH_O_CD,LOT_NO,WH_WAT,WH_DT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM MATL_WH_" & _
            "TBL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY WH_NO,REN_NO"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.DefaultPaperSize = false
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11.69306!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.268056!
        Me.PrintWidth = 7.46875!
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
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNyukoNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRenNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyoCode, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtChumonNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNyukoMotoCode, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyoLotNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNyukoRyo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNyukoDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblLast1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTextFile, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit
    End Sub

#End Region

    Private _nPage As Integer = 0

    Private _sMonth As String = ""
    Private _sTextFile As String = ""

#Region " プロパティ "

    Public WriteOnly Property Month() As String
        Set(ByVal sValue As String)
            _sMonth = sValue
        End Set
    End Property

    Public WriteOnly Property TextFile() As String
        Set(ByVal sValue As String)
            _sTextFile = sValue
        End Set
    End Property

#End Region

    Private Sub mdhst010_PageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageStart
        _nPage += 1
    End Sub

    Private Sub mdhst010_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportEnd
    End Sub

    Private Sub mdhst010_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("NyukoDate")
        txtNyukoDate.DataField = "NyukoDate"
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblPage.Text = _nPage.ToString("#").Trim.PadLeft(3, " ")
        lblMonth.Text = _sMonth
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Fields("NyukoDate").Value = DateFormat(GetString(Fields("WH_DT").Value))
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        lblTextFile.Text = "(" + _sTextFile + ")"
    End Sub

#Region " その他 "

    Private Function GetString(ByVal oValue As Object) As String
        If IsDBNull(oValue) Then Return ""
        Return CType(oValue, String).Trim()
    End Function

    Private Function DateFormat(ByVal sValue As String) As String
        If sValue.Trim.Equals("") Then Return ""
        If sValue.Trim.Equals("00000000") Then Return ""
        Return sValue.Substring(0, 4) + "/" + sValue.Substring(4, 2) + "/" + sValue.Substring(6, 2)
    End Function

#End Region

End Class 
