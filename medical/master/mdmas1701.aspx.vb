Imports System.Data 
Imports System.Data.OracleClient
Imports GrapeCity.ActiveReports.Web.Controls

Partial Class master_mdmas1701
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS170"
    Private Const PROGRAM_TITLE As String = "マスタ更新履歴参照・印刷"

    'Public _sRDF As String = MedicalLib.Common.RDF(MedicalLib.Common.RDFType.Read)

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            printMDMAS170()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region " 印刷 "

    Private Sub printMDMAS170()
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery += "SELECT * FROM MASTER_HIS_TBL WHERE MASTER_NM IN ("
            If Request.QueryString("table").ToString.IndexOf("a") > -1 Then sQuery += "'部品マスタ',"
            If Request.QueryString("table").ToString.IndexOf("b") > -1 Then sQuery += "'加工工程マスタ',"
            If Request.QueryString("table").ToString.IndexOf("c") > -1 Then sQuery += "'部品構成マスタ',"
            If Request.QueryString("table").ToString.IndexOf("d") > -1 Then sQuery += "'主材料マスタ',"
            If Request.QueryString("table").ToString.IndexOf("e") > -1 Then sQuery += "'SHOPマスタ',"
            If Request.QueryString("table").ToString.IndexOf("f") > -1 Then sQuery += "'工程マスタ',"
            If Request.QueryString("table").ToString.IndexOf("g") > -1 Then sQuery += "'設備マスタ',"
            If Request.QueryString("table").ToString.IndexOf("h") > -1 Then sQuery += "'作業者マスタ',"
            If Request.QueryString("table").ToString.IndexOf("i") > -1 Then sQuery += "'外注マスタ',"
            If Request.QueryString("table").ToString.IndexOf("j") > -1 Then sQuery += "'汎用マスタ',"
            sQuery = sQuery.Substring(0, sQuery.Length - 1)
            sQuery += ") "

            If Request.QueryString("from") <> "" Then
                sQuery += "AND CHANGE_DT >= :K01 "
                _oDatabase.CreateParam("K01", Request.QueryString("from"))
            End If
            If Request.QueryString("to") <> "" Then
                sQuery += "AND CHANGE_DT <= :K02 "
                _oDatabase.CreateParam("K02", Request.QueryString("to"))
            End If
            sQuery += "ORDER BY CHANGE_DT,CHANGE_TIME,MASTER_NM,UPD_KEY,UPD_FIELD_NM"

            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")

            Dim oReport As New mdmas170
            oReport.DataSource = oDataSet
            oReport.DataMember = "TB1"
            oReport.Run(True)
            'oReport.Document.Save(MedicalLib.Common.RDF(MedicalLib.Common.RDFType.Write), DataDynamics.ActiveReports.Document.RdfFormat.AR20)
            WebViewer1.Report = oReport
            WebViewer1.Height = 0
            WebViewer1.Width = 0
            WebViewer1.FlashViewerOptions.PrintOptions.StartPrint = True
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " その他 "

    Private Function GetString(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As String
        If oReader.IsDBNull(nIndex) Then Return ""
        Return oReader.GetString(nIndex).Trim()
    End Function

    Private Function GetInt32(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Int32
        If oReader.IsDBNull(nIndex) Then Return 0
        Return oReader.GetInt32(nIndex)
    End Function

    Private Function GetDouble(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Double
        If oReader.IsDBNull(nIndex) Then Return 0.0
        Return oReader.GetDouble(nIndex)
    End Function

    Public Function GetDate(ByVal sValue As Object) As String
        If sValue.ToString.Equals("") Then Return ""
        If sValue.ToString.Equals("00000000") Then Return ""
        Return sValue.ToString()
    End Function

    Public Function GetTime(ByVal sValue As Object) As String
        If sValue.ToString.Equals("") Then Return ""
        If sValue.ToString.Equals("000000") Then Return ""
        Return sValue.ToString()
    End Function

#End Region

End Class
