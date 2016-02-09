Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports System.Data.OracleClient
Imports Microsoft.VisualBasic

Public Class mdtyk0204
    Inherits GrapeCity.ActiveReports.SectionReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    '**** 2010/04 材料ロットNO 追加

#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private Picture As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private txtO_CATALOG_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtINDICATE_NO As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtCOR_MARK As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtZairyouLotNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtyk0204))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Picture = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.txtO_CATALOG_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtINDICATE_NO = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCOR_MARK = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtZairyouLotNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtO_CATALOG_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCOR_MARK, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZairyouLotNo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Picture, Me.txtO_CATALOG_NO, Me.txtINDICATE_NO, Me.txtCOR_MARK, Me.Label7, Me.txtZairyouLotNo})
        Me.Detail.Height = 11.00764!
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
        'Picture
        '
        Me.Picture.Height = 10.93333!
        Me.Picture.ImageData = Nothing
        Me.Picture.Left = 0.05!
        Me.Picture.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture.Name = "Picture"
        Me.Picture.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch
        Me.Picture.Top = 0.05!
        Me.Picture.Width = 7.466667!
        '
        'txtO_CATALOG_NO
        '
        Me.txtO_CATALOG_NO.DataField = "O_CATALOG_NO"
        Me.txtO_CATALOG_NO.Height = 0.2!
        Me.txtO_CATALOG_NO.Left = 1.3045!
        Me.txtO_CATALOG_NO.Name = "txtO_CATALOG_NO"
        Me.txtO_CATALOG_NO.Style = "background-color: White; font-family: ＭＳ ゴシック; font-size: 9.75pt; font-weight: bo" & _
            "ld; vertical-align: bottom; white-space: nowrap"
        Me.txtO_CATALOG_NO.Text = "元カタログ番号"
        Me.txtO_CATALOG_NO.Top = 0.333!
        Me.txtO_CATALOG_NO.Width = 1.266667!
        '
        'txtINDICATE_NO
        '
        Me.txtINDICATE_NO.DataField = "INDICATE_NO"
        Me.txtINDICATE_NO.Height = 0.2!
        Me.txtINDICATE_NO.Left = 2.9!
        Me.txtINDICATE_NO.Name = "txtINDICATE_NO"
        Me.txtINDICATE_NO.Style = "background-color: White; font-family: ＭＳ ゴシック; font-size: 9.75pt; font-weight: bo" & _
            "ld; text-align: center; vertical-align: middle"
        Me.txtINDICATE_NO.Text = "指示NO"
        Me.txtINDICATE_NO.Top = 0.7375!
        Me.txtINDICATE_NO.Width = 0.8!
        '
        'txtCOR_MARK
        '
        Me.txtCOR_MARK.DataField = "COR_MARK"
        Me.txtCOR_MARK.Height = 0.25!
        Me.txtCOR_MARK.Left = 6.75!
        Me.txtCOR_MARK.Name = "txtCOR_MARK"
        Me.txtCOR_MARK.Style = "background-color: White; font-family: ＭＳ ゴシック; font-size: 14.25pt; text-align: ce" & _
            "nter; vertical-align: bottom"
        Me.txtCOR_MARK.Text = "訂符"
        Me.txtCOR_MARK.Top = 0.6875!
        Me.txtCOR_MARK.Width = 0.5999999!
        '
        'Label7
        '
        Me.Label7.Height = 0.1999999!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.1!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.Label7.Text = "[09-146]"
        Me.Label7.Top = 10.75!
        Me.Label7.Width = 0.6666667!
        '
        'txtZairyouLotNo
        '
        Me.txtZairyouLotNo.Height = 0.2!
        Me.txtZairyouLotNo.Left = 5!
        Me.txtZairyouLotNo.Name = "txtZairyouLotNo"
        Me.txtZairyouLotNo.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt; text-align: left; vertical-align: bottom" & _
            "; white-space: nowrap; ddo-char-set: 1"
        Me.txtZairyouLotNo.Text = "99999"
        Me.txtZairyouLotNo.Top = 1.125!
        Me.txtZairyouLotNo.Width = 0.4666668!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=medical;User ID=medical;Data Source=medical;Persist S" & _
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
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtO_CATALOG_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtINDICATE_NO, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCOR_MARK, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZairyouLotNo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit
    End Sub

#End Region

    Private _sImageFile As String = "D:\Users\メイラメディカル\Report\I88880101010001.tif"

    Private _sMedicalDNS As String = "User Id=mdctest;Password=mdctest;Data Source=MEDICAL;"
    'Private _oMedicalConnect As OracleConnection = Nothing

#Region " プロパティ "

    Public WriteOnly Property MedicalDNS() As String
        Set(ByVal sValue As String)
            _sMedicalDNS = sValue
        End Set
    End Property

    Public WriteOnly Property ImageFile() As String
        Set(ByVal sValue As String)
            _sImageFile = sValue
        End Set
    End Property

#End Region

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

        '**** 2010/08/05 元のファイルがロックされてしまうのでメモリに読み込む ST ****
        Dim ms As IO.MemoryStream
        Using fs As System.IO.FileStream = New System.IO.FileStream(_sImageFile, _
                                                        IO.FileMode.Open, IO.FileAccess.Read)
            Using br As New IO.BinaryReader(fs)
                ms = New IO.MemoryStream(br.ReadBytes(CInt(fs.Length)))
            End Using
        End Using

        Picture.Image = System.Drawing.Image.FromStream(ms)
        'Picture.Image = System.Drawing.Image.FromFile(_sImageFile) 
        '**** 2010/08/05 元のファイルがロックされてしまうのでメモリに読み込む ED ****

        '材料ロットNO 
        Dim sQuery As String = ""

        Using _oMedicalConnect As OracleConnection = New OracleConnection(_sMedicalDNS)

            _oMedicalConnect.Open()

            txtZairyouLotNo.Text = ""
            If Not GetString(Fields("MATL_CD").Value).Trim.Equals("") Then
                sQuery = "SELECT LOT_NO FROM MATL_MORTGAGE_TBL WHERE REN_NO = " + GetString(Fields("REN_NO").Value) + " AND MATL_CD = '" + GetString(Fields("MATL_CD").Value) + "' AND INDICATE_NO = '" + GetString(Fields("INDICATE_NO").Value) + "' AND COMPANY_NO = '" + GetString(Fields("COMPANY_NO").Value) + "'"
                Using oCommand As OracleCommand = _oMedicalConnect.CreateCommand()
                    oCommand.CommandText = sQuery
                    Using oReader As OracleDataReader = oCommand.ExecuteReader
                        If oReader.Read() Then
                            txtZairyouLotNo.Text = GetString(oReader(0))
                        End If
                    End Using
                End Using
            Else
                If Not GetString(Fields("ORIGIN_PARTS_NO").Value).Trim.Equals("") Then
                    sQuery = "SELECT C.LOT_NO FROM PARTS_MST A,(SELECT INDICATE_NO,COMPANY_NO,MAX(SHIP_NO) SHIP_NO FROM MATL_SHIP_TBL GROUP BY INDICATE_NO,COMPANY_NO) B,MATL_SHIP_TBL C "
                    sQuery += "WHERE A.COMPANY_NO = B.COMPANY_NO AND (B.INDICATE_NO = C.INDICATE_NO AND B.COMPANY_NO = C.COMPANY_NO AND B.SHIP_NO = C.SHIP_NO) AND "
                    sQuery += "A.CATALOG_NO = '" + GetString(Fields("USE_ORG_PARTS_NO").Value) + "' AND B.INDICATE_NO = '" + GetString(Fields("ORIGIN_PARTS_NO").Value) + "'"
                    Using oCommand As OracleCommand = _oMedicalConnect.CreateCommand()
                        oCommand.CommandText = sQuery
                        Using oReader As OracleDataReader = oCommand.ExecuteReader
                            If oReader.Read() Then
                                txtZairyouLotNo.Text = GetString(oReader(0))
                            End If
                        End Using
                    End Using
                End If
            End If
        End Using
    End Sub

    Private Function GetString(ByVal oValue As Object) As String
        If oValue Is Nothing Then Return ""
        If IsDBNull(oValue) Then Return ""
        Return CType(oValue, String).Trim()
    End Function
End Class 
