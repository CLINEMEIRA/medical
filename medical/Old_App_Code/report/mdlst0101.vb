Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports System
Imports Microsoft.VisualBasic
Imports System.Data.OracleClient

Public Class mdlst0101
    Inherits GrapeCity.ActiveReports.SectionReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
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
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdlst0101))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label40 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCOR_MARK = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOR_ARTICLE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDate1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCREATOR_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtRECOGNIZER_NM = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtTuutisyo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtGenseitei = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSakusei = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSyounin = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTeifu = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label41 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTekiyou = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label42 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label43 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label44 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOR_MARK, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOR_ARTICLE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDate1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCREATOR_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRECOGNIZER_NM, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTuutisyo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGenseitei, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSakusei, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtSyounin, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTeifu, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTekiyou, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.CanGrow = false
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCOR_MARK, Me.txtCOR_ARTICLE_NO, Me.txtDate1, Me.txtCREATOR_NM, Me.txtRECOGNIZER_NM, Me.Line22, Me.Line})
        Me.Detail.Height = 0.1666667!
        Me.Detail.Name = "Detail"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.CanGrow = false
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label40, Me.Line1, Me.Line2, Me.Label1, Me.Label2, Me.Label3, Me.Label5, Me.Label6})
        Me.GroupHeader1.Height = 0.2076389!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line36, Me.Line3, Me.Line52, Me.Line57, Me.Line58, Me.Line59, Me.txtTuutisyo, Me.Line60, Me.txtGenseitei, Me.Line61, Me.txtSakusei, Me.txtSyounin, Me.Label, Me.txtTeifu, Me.Line10, Me.Label4, Me.Label41, Me.txtTekiyou, Me.Label42, Me.Label43, Me.Label44, Me.Label7})
        Me.GroupFooter1.Height = 0.5625!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label40
        '
        Me.Label40.Height = 0.1999999!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 0.3333333!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label40.Text = "<改定履歴>"
        Me.Label40.Top = 0!
        Me.Label40.Width = 0.6666667!
        '
        'Line1
        '
        Me.Line1.Height = 0.2666667!
        Me.Line1.Left = 0.2!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0!
        Me.Line1.Width = 0!
        Me.Line1.X1 = 0.2!
        Me.Line1.X2 = 0.2!
        Me.Line1.Y1 = 0!
        Me.Line1.Y2 = 0.2666667!
        '
        'Line2
        '
        Me.Line2.Height = 0.2666667!
        Me.Line2.Left = 7.533327!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0!
        Me.Line2.Width = 6.67572E-06!
        Me.Line2.X1 = 7.533327!
        Me.Line2.X2 = 7.533333!
        Me.Line2.Y1 = 0!
        Me.Line2.Y2 = 0.2666667!
        '
        'Label1
        '
        Me.Label1.Height = 0.1999999!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 1.600001!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label1.Text = "訂符"
        Me.Label1.Top = 0!
        Me.Label1.Width = 0.3333333!
        '
        'Label2
        '
        Me.Label2.Height = 0.1999999!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.333333!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label2.Text = "変更通知書№"
        Me.Label2.Top = 0!
        Me.Label2.Width = 0.8!
        '
        'Label3
        '
        Me.Label3.Height = 0.1999999!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 4.666665!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label3.Text = "適用"
        Me.Label3.Top = 0!
        Me.Label3.Width = 0.3333333!
        '
        'Label5
        '
        Me.Label5.Height = 0.1999999!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 5.866664!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label5.Text = "作成"
        Me.Label5.Top = 7.450583E-08!
        Me.Label5.Width = 0.3333333!
        '
        'Label6
        '
        Me.Label6.Height = 0.1999999!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 6.733331!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label6.Text = "承認"
        Me.Label6.Top = 7.450583E-08!
        Me.Label6.Width = 0.3333333!
        '
        'txtCOR_MARK
        '
        Me.txtCOR_MARK.DataField = "COR_MARK"
        Me.txtCOR_MARK.Height = 0.2!
        Me.txtCOR_MARK.Left = 1.933333!
        Me.txtCOR_MARK.Name = "txtCOR_MARK"
        Me.txtCOR_MARK.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top"
        Me.txtCOR_MARK.Text = "訂符"
        Me.txtCOR_MARK.Top = 0!
        Me.txtCOR_MARK.Width = 0.2666667!
        '
        'txtCOR_ARTICLE_NO
        '
        Me.txtCOR_ARTICLE_NO.DataField = "COR_ARTICLE_NO"
        Me.txtCOR_ARTICLE_NO.Height = 0.2!
        Me.txtCOR_ARTICLE_NO.Left = 3.2!
        Me.txtCOR_ARTICLE_NO.Name = "txtCOR_ARTICLE_NO"
        Me.txtCOR_ARTICLE_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top"
        Me.txtCOR_ARTICLE_NO.Text = "訂正記事番号"
        Me.txtCOR_ARTICLE_NO.Top = 0!
        Me.txtCOR_ARTICLE_NO.Width = 1.333333!
        '
        'txtDate1
        '
        Me.txtDate1.DataField = "APPLY_DT"
        Me.txtDate1.Height = 0.2!
        Me.txtDate1.Left = 5!
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top"
        Me.txtDate1.Text = "適用日付"
        Me.txtDate1.Top = 0!
        Me.txtDate1.Width = 0.7333333!
        '
        'txtCREATOR_NM
        '
        Me.txtCREATOR_NM.DataField = "CREATOR_NM"
        Me.txtCREATOR_NM.Height = 0.2!
        Me.txtCREATOR_NM.Left = 6.2!
        Me.txtCREATOR_NM.Name = "txtCREATOR_NM"
        Me.txtCREATOR_NM.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top"
        Me.txtCREATOR_NM.Text = "作成者名"
        Me.txtCREATOR_NM.Top = 0!
        Me.txtCREATOR_NM.Width = 0.4666668!
        '
        'txtRECOGNIZER_NM
        '
        Me.txtRECOGNIZER_NM.DataField = "RECOGNIZER_NM"
        Me.txtRECOGNIZER_NM.Height = 0.2!
        Me.txtRECOGNIZER_NM.Left = 7.066667!
        Me.txtRECOGNIZER_NM.Name = "txtRECOGNIZER_NM"
        Me.txtRECOGNIZER_NM.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top"
        Me.txtRECOGNIZER_NM.Text = "承認者名"
        Me.txtRECOGNIZER_NM.Top = 0!
        Me.txtRECOGNIZER_NM.Width = 0.4666658!
        '
        'Line22
        '
        Me.Line22.Height = 0.2666667!
        Me.Line22.Left = 0.2!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 0!
        Me.Line22.Width = 0!
        Me.Line22.X1 = 0.2!
        Me.Line22.X2 = 0.2!
        Me.Line22.Y1 = 0!
        Me.Line22.Y2 = 0.2666667!
        '
        'Line
        '
        Me.Line.Height = 0.2666667!
        Me.Line.Left = 7.533327!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0!
        Me.Line.Width = 6.67572E-06!
        Me.Line.X1 = 7.533327!
        Me.Line.X2 = 7.533333!
        Me.Line.Y1 = 0!
        Me.Line.Y2 = 0.2666667!
        '
        'Line36
        '
        Me.Line36.Height = 0!
        Me.Line36.Left = 0.2!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 5.960464E-08!
        Me.Line36.Width = 7.333333!
        Me.Line36.X1 = 0.2!
        Me.Line36.X2 = 7.533333!
        Me.Line36.Y1 = 5.960464E-08!
        Me.Line36.Y2 = 5.960464E-08!
        '
        'Line3
        '
        Me.Line3.Height = 0.3333333!
        Me.Line3.Left = 0.2!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 0.2!
        Me.Line3.X2 = 0.2!
        Me.Line3.Y1 = 0!
        Me.Line3.Y2 = 0.3333333!
        '
        'Line52
        '
        Me.Line52.Height = 0!
        Me.Line52.Left = 0.2!
        Me.Line52.LineWeight = 1!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 0.3333333!
        Me.Line52.Width = 7.333333!
        Me.Line52.X1 = 0.2!
        Me.Line52.X2 = 7.533333!
        Me.Line52.Y1 = 0.3333333!
        Me.Line52.Y2 = 0.3333333!
        '
        'Line57
        '
        Me.Line57.Height = 0.3333333!
        Me.Line57.Left = 2.266667!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 0!
        Me.Line57.Width = 7.152557E-07!
        Me.Line57.X1 = 2.266667!
        Me.Line57.X2 = 2.266667!
        Me.Line57.Y1 = 0!
        Me.Line57.Y2 = 0.3333333!
        '
        'Line58
        '
        Me.Line58.Height = 0.3333333!
        Me.Line58.Left = 7.533333!
        Me.Line58.LineWeight = 1!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 0!
        Me.Line58.Width = 0!
        Me.Line58.X1 = 7.533333!
        Me.Line58.X2 = 7.533333!
        Me.Line58.Y1 = 0!
        Me.Line58.Y2 = 0.3333333!
        '
        'Line59
        '
        Me.Line59.Height = 0.3333333!
        Me.Line59.Left = 1.533333!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 5.960464E-08!
        Me.Line59.Width = 7.152557E-07!
        Me.Line59.X1 = 1.533334!
        Me.Line59.X2 = 1.533333!
        Me.Line59.Y1 = 5.960464E-08!
        Me.Line59.Y2 = 0.3333333!
        '
        'txtTuutisyo
        '
        Me.txtTuutisyo.DataField = "最新COR_ARTICLE_NO"
        Me.txtTuutisyo.Height = 0.2!
        Me.txtTuutisyo.Left = 3.2!
        Me.txtTuutisyo.Name = "txtTuutisyo"
        Me.txtTuutisyo.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom"
        Me.txtTuutisyo.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txtTuutisyo.Top = 0.06666667!
        Me.txtTuutisyo.Width = 1.333333!
        '
        'Line60
        '
        Me.Line60.Height = 0.3333333!
        Me.Line60.Left = 4.6!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 0!
        Me.Line60.Width = 0!
        Me.Line60.X1 = 4.6!
        Me.Line60.X2 = 4.6!
        Me.Line60.Y1 = 0!
        Me.Line60.Y2 = 0.3333333!
        '
        'txtGenseitei
        '
        Me.txtGenseitei.DataField = "最古APPLY_DT"
        Me.txtGenseitei.Height = 0.2!
        Me.txtGenseitei.Left = 0.7333333!
        Me.txtGenseitei.Name = "txtGenseitei"
        Me.txtGenseitei.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.txtGenseitei.Text = "YYYY.MM.DD"
        Me.txtGenseitei.Top = 0.06666667!
        Me.txtGenseitei.Width = 0.7333333!
        '
        'Line61
        '
        Me.Line61.Height = 0.3333333!
        Me.Line61.Left = 5.8!
        Me.Line61.LineWeight = 1!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 0!
        Me.Line61.Width = 0!
        Me.Line61.X1 = 5.8!
        Me.Line61.X2 = 5.8!
        Me.Line61.Y1 = 0!
        Me.Line61.Y2 = 0.3333333!
        '
        'txtSakusei
        '
        Me.txtSakusei.DataField = "最新CREATOR_NM"
        Me.txtSakusei.Height = 0.2!
        Me.txtSakusei.Left = 6.2!
        Me.txtSakusei.Name = "txtSakusei"
        Me.txtSakusei.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom"
        Me.txtSakusei.Text = "ＮＮＮ"
        Me.txtSakusei.Top = 0.06666674!
        Me.txtSakusei.Width = 0.4666668!
        '
        'txtSyounin
        '
        Me.txtSyounin.DataField = "最新RECOGNIZER_NM"
        Me.txtSyounin.Height = 0.2!
        Me.txtSyounin.Left = 7.066667!
        Me.txtSyounin.Name = "txtSyounin"
        Me.txtSyounin.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom"
        Me.txtSyounin.Text = "ＮＮＮ"
        Me.txtSyounin.Top = 0.06666674!
        Me.txtSyounin.Width = 0.4666663!
        '
        'Label
        '
        Me.Label.Height = 0.1999999!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0.2666667!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label.Text = "原制定"
        Me.Label.Top = 0.06666667!
        Me.Label.Width = 0.4666667!
        '
        'txtTeifu
        '
        Me.txtTeifu.DataField = "最新COR_MARK"
        Me.txtTeifu.Height = 0.2!
        Me.txtTeifu.Left = 1.933333!
        Me.txtTeifu.Name = "txtTeifu"
        Me.txtTeifu.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: bottom"
        Me.txtTeifu.Text = "XXX"
        Me.txtTeifu.Top = 0.06666667!
        Me.txtTeifu.Width = 0.2666667!
        '
        'Line10
        '
        Me.Line10.Height = 0.3333333!
        Me.Line10.Left = 6.666666!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 5.960464E-08!
        Me.Line10.Width = 4.768372E-07!
        Me.Line10.X1 = 6.666666!
        Me.Line10.X2 = 6.666667!
        Me.Line10.Y1 = 5.960464E-08!
        Me.Line10.Y2 = 0.3333333!
        '
        'Label4
        '
        Me.Label4.Height = 0.1999999!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.6!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label4.Text = "訂符"
        Me.Label4.Top = 0.06666667!
        Me.Label4.Width = 0.3333333!
        '
        'Label41
        '
        Me.Label41.Height = 0.1999999!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 2.333333!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label41.Text = "変更通知書№"
        Me.Label41.Top = 0.06666667!
        Me.Label41.Width = 0.8!
        '
        'txtTekiyou
        '
        Me.txtTekiyou.DataField = "最新APPLY_DT"
        Me.txtTekiyou.Height = 0.2!
        Me.txtTekiyou.Left = 5!
        Me.txtTekiyou.Name = "txtTekiyou"
        Me.txtTekiyou.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.txtTekiyou.Text = "YYYY.MM.DD"
        Me.txtTekiyou.Top = 0.06666674!
        Me.txtTekiyou.Width = 0.7333333!
        '
        'Label42
        '
        Me.Label42.Height = 0.1999999!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 4.666667!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label42.Text = "適用"
        Me.Label42.Top = 0.06666667!
        Me.Label42.Width = 0.3333333!
        '
        'Label43
        '
        Me.Label43.Height = 0.1999999!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 5.866667!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label43.Text = "作成"
        Me.Label43.Top = 0.06666674!
        Me.Label43.Width = 0.3333333!
        '
        'Label44
        '
        Me.Label44.Height = 0.1999999!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 6.733333!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label44.Text = "承認"
        Me.Label44.Top = 0.06666674!
        Me.Label44.Width = 0.3333333!
        '
        'Label7
        '
        Me.Label7.Height = 0.1999999!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.2!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: bottom"
        Me.Label7.Text = "[175-134D]"
        Me.Label7.Top = 0.3333335!
        Me.Label7.Width = 0.6666667!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.573!
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOR_MARK, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOR_ARTICLE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDate1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCREATOR_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRECOGNIZER_NM, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTuutisyo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGenseitei, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSakusei, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtSyounin, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTeifu, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTekiyou, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
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
