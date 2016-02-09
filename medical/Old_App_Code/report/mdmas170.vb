Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls

Public Class mdmas170
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
    Private Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label27 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblSysDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label30 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtTime As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMaster As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtKey As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtMae As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtAto As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdmas170))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label27 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSysDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label30 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTime = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMaster = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtKey = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtMae = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAto = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMaster, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtKey, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtValue, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMae, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtAto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtDate, Me.txtTime, Me.txtMaster, Me.txtKey, Me.txtValue, Me.txtMae, Me.txtAto, Me.Line1, Me.Line2})
        Me.Detail.Height = 0.3270833!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label24, Me.Label27, Me.lblSysDate, Me.Label, Me.lblPage, Me.Label30, Me.Label31, Me.Line, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5})
        Me.PageHeader.Height = 1.083333!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.03125!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Visible = false
        '
        'Label24
        '
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; text-align: center; text-decoration: none;" & _
            " vertical-align: bottom"
        Me.Label24.Text = "*　*　マスタ更新履歴　*　*"
        Me.Label24.Top = 0.3125!
        Me.Label24.Width = 9.9375!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 7!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "日 付 ："
        Me.Label27.Top = 0.0625!
        Me.Label27.Width = 0.625!
        '
        'lblSysDate
        '
        Me.lblSysDate.Height = 0.2!
        Me.lblSysDate.HyperLink = Nothing
        Me.lblSysDate.Left = 7.625!
        Me.lblSysDate.Name = "lblSysDate"
        Me.lblSysDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblSysDate.Text = "YYYY/MM/DD"
        Me.lblSysDate.Top = 0.0625!
        Me.lblSysDate.Width = 0.9375!
        '
        'Label
        '
        Me.Label.Height = 0.2!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 8.625!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label.Text = "ページ ："
        Me.Label.Top = 0.0625!
        Me.Label.Width = 0.6875!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 9.3125!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.lblPage.Text = "1"
        Me.lblPage.Top = 0.0625!
        Me.lblPage.Width = 0.5!
        '
        'Label30
        '
        Me.Label30.Height = 0.18!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label30.Text = "更新年月日"
        Me.Label30.Top = 0.875!
        Me.Label30.Width = 0.75!
        '
        'Label31
        '
        Me.Label31.Height = 0.18!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.8125!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label31.Text = "更新時刻"
        Me.Label31.Top = 0.875!
        Me.Label31.Width = 0.6455!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.0625!
        Me.Line.Width = 10.0625!
        Me.Line.X1 = 0!
        Me.Line.X2 = 10.0625!
        Me.Line.Y1 = 1.0625!
        Me.Line.Y2 = 1.0625!
        '
        'Label1
        '
        Me.Label1.Height = 0.18!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 1.5!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label1.Text = "マスタ名"
        Me.Label1.Top = 0.875!
        Me.Label1.Width = 0.6455!
        '
        'Label2
        '
        Me.Label2.Height = 0.18!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.5625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label2.Text = "更新キー"
        Me.Label2.Top = 0.875!
        Me.Label2.Width = 0.6455!
        '
        'Label3
        '
        Me.Label3.Height = 0.18!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.0625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label3.Text = "更新項目名"
        Me.Label3.Top = 0.875!
        Me.Label3.Width = 0.8125!
        '
        'Label4
        '
        Me.Label4.Height = 0.18!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 6.5!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label4.Text = "更新前値"
        Me.Label4.Top = 0.6875!
        Me.Label4.Width = 0.8125!
        '
        'Label5
        '
        Me.Label5.Height = 0.18!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 6.5!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label5.Text = "更新後値"
        Me.Label5.Top = 0.875!
        Me.Label5.Width = 0.8125!
        '
        'txtDate
        '
        Me.txtDate.DataField = "CHANGE_DT"
        Me.txtDate.Height = 0.16!
        Me.txtDate.Left = 0!
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 1"
        Me.txtDate.Text = "YYYY/MM/DD"
        Me.txtDate.Top = 0!
        Me.txtDate.Width = 0.75!
        '
        'txtTime
        '
        Me.txtTime.DataField = "CHANGE_TIME"
        Me.txtTime.Height = 0.16!
        Me.txtTime.Left = 0.8125!
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 1"
        Me.txtTime.Text = "HH:MM:SS"
        Me.txtTime.Top = 0!
        Me.txtTime.Width = 0.625!
        '
        'txtMaster
        '
        Me.txtMaster.DataField = "NM"
        Me.txtMaster.Height = 0.16!
        Me.txtMaster.Left = 1.5!
        Me.txtMaster.Name = "txtMaster"
        Me.txtMaster.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 1"
        Me.txtMaster.Text = "ＮＮＮＮＮＮＮ"
        Me.txtMaster.Top = 0!
        Me.txtMaster.Width = 1!
        '
        'txtKey
        '
        Me.txtKey.DataField = "UPD_KEY"
        Me.txtKey.Height = 0.16!
        Me.txtKey.Left = 2.5625!
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 1"
        Me.txtKey.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txtKey.Top = 0!
        Me.txtKey.Width = 2.5!
        '
        'txtValue
        '
        Me.txtValue.DataField = "UPD_FIELD_NM"
        Me.txtValue.Height = 0.16!
        Me.txtValue.Left = 5.0625!
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 1"
        Me.txtValue.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txtValue.Top = 0!
        Me.txtValue.Width = 1.4375!
        '
        'txtMae
        '
        Me.txtMae.DataField = "BEFORE_VALUE"
        Me.txtMae.Height = 0.16!
        Me.txtMae.Left = 6.5!
        Me.txtMae.Name = "txtMae"
        Me.txtMae.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 1"
        Me.txtMae.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txtMae.Top = 0!
        Me.txtMae.Width = 3.5625!
        '
        'txtAto
        '
        Me.txtAto.DataField = "AFTER_VALUE"
        Me.txtAto.Height = 0.16!
        Me.txtAto.Left = 6.500999!
        Me.txtAto.Name = "txtAto"
        Me.txtAto.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 1"
        Me.txtAto.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txtAto.Top = 0.164!
        Me.txtAto.Width = 3.562!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.162!
        Me.Line1.Width = 10.0625!
        Me.Line1.X1 = 0!
        Me.Line1.X2 = 10.0625!
        Me.Line1.Y1 = 0.162!
        Me.Line1.Y2 = 0.162!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 0!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.326!
        Me.Line2.Width = 10.0625!
        Me.Line2.X1 = 0!
        Me.Line2.X2 = 10.0625!
        Me.Line2.Y1 = 0.326!
        Me.Line2.Y2 = 0.326!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=mdctest;User ID=mdctest;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = "SELECT * FROM HIS_TBL"
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.8!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.14583!
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
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblSysDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMaster, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtKey, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtValue, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMae, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtAto, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private nPage As Integer = 1
    Private nRow As Integer = 0
    Private maxRow As Integer = 36

    Private Sub mdmas170_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Fields.Add("ChangeDate")
        txtDate.DataField = "ChangeDate"

        Fields.Add("ChangeTime")
        txtTime.DataField = "ChangeTime"
    End Sub

    Private Sub mdmas170_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
        '更新年月日
        Fields("ChangeDate").Value = ""
        If Not GetString(Fields("CHANGE_DT").Value).Equals("") And Not GetString(Fields("CHANGE_DT").Value).Equals("00000000") Then Fields("ChangeDate").Value = GetString(Fields("CHANGE_DT").Value).Substring(0, 4) + "/" + GetString(Fields("CHANGE_DT").Value).Substring(4, 2) + "/" + GetString(Fields("CHANGE_DT").Value).Substring(6, 2)

        '更新時刻
        Fields("ChangeTime").Value = ""
        If Not GetString(Fields("CHANGE_TIME").Value).Equals("") And Not GetString(Fields("CHANGE_TIME").Value).Equals("000000") Then Fields("ChangeTime").Value = GetString(Fields("CHANGE_TIME").Value).Substring(0, 2) + ":" + GetString(Fields("CHANGE_TIME").Value).Substring(2, 2) + ":" + GetString(Fields("CHANGE_TIME").Value).Substring(4, 2)

    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If GetString(Fields("UPD_FIELD_NM").Value).Equals("追加") Or GetString(Fields("UPD_FIELD_NM").Value).Equals("削除") Or GetString(Fields("UPD_FIELD_NM").Value).Equals("一括削除") Then
            Line1.Visible = True
            txtAto.Visible = False
            Line2.Visible = False
            Me.Detail.Height = 0.184
            nRow += 1
        Else
            Line1.Visible = False
            txtAto.Visible = True
            Line2.Visible = True
            Me.Detail.Height = 0.348
            nRow += 2
        End If

        If nRow < maxRow Then
            ' 件数がmaxRow件に満たない場合、改ページは行ないません。 
            Me.Detail.NewPage = NewPage.None
        Else
            ' maxRow件出力した後、改ページを行い、カウンタをリセットします。 
            Me.Detail.NewPage = NewPage.After
            nRow = 0
        End If
    End Sub

    Private Function GetString(ByVal oValue As Object) As String
        If IsDBNull(oValue) Then Return ""
        Return CType(oValue, String).Trim()
    End Function

    Private Function GetDouble(ByVal oValue As Object) As Double
        If IsDBNull(oValue) Then Return 0
        Return CType(oValue, Double)
    End Function

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblPage.Text = nPage
        nPage += 1
        lblSysDate.Text = System.DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

End Class
