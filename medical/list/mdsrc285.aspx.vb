Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient

 
Partial Class master_mdsrc285
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDSRC285"
    Private Const PROGRAM_TITLE As String = "セットID検索"

    Private _oDatabase As MedicalLib.DataAccess

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess("HonsyaDB")
            If Not Page.IsPostBack Then
                Me.txtID.Text = Request.QueryString("setid").Trim
                Me.txtCatalog.Text = Request.QueryString("catalog").Trim
                If Me.txtID.Text.Trim <> "" Then
                    Me.txtID.Enabled = False
                    scrManager.SetFocus(Me.txtCatalog)
                Else
                    scrManager.SetFocus(Me.txtID)

                End If
                MedicalLib.Common.ListSort = "SET_ID, CATALOG_NO"
            Else
                If Not Request.Form("btnSearch") Is Nothing Then grdList.CurrentPageIndex = 0
            End If
            DisplayList()
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

    Protected Sub grdList_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList.ItemDataBound
        Dim origItem As String = ColorTranslator.ToHtml(grdList.ItemStyle.BackColor)
        Dim origAltItem As String = ColorTranslator.ToHtml(grdList.AlternatingItemStyle.BackColor)
        Dim oLine As DataGridItem = e.Item
        If oLine.ItemType = ListItemType.Item Or oLine.ItemType = ListItemType.AlternatingItem Then
            oLine.Style("cursor") = "hand"
            oLine.Attributes("onmouseover") = "this.style.backgroundColor='Gold'"
            If oLine.ItemType = ListItemType.Item Then
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origItem + "'"
            Else
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origAltItem + "'"
            End If
            'oLine.Attributes("onclick") = "closeWindow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + HttpUtility.UrlEncode(oLine.Cells(1).Text) + "')" 
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(2).Text + "')"
        End If
    End Sub

    Protected Sub grdList_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdList.PageIndexChanged
        grdList.CurrentPageIndex = e.NewPageIndex
        DisplayList()
    End Sub

    Protected Sub grdList_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdList.SortCommand
        MedicalLib.Common.ListSortCommand(e)
        DisplayList()
    End Sub

#End Region

#Region " 画面表示 "

    Private Sub DisplayList()

        Dim sTable As String = "T"
        Dim sQuery As String = ""

        sQuery += "SELECT SET_ID, SET_NAME, CATALOG_NO"
        sQuery += "  FROM SETCOMP_MST"
        sQuery += " WHERE SUBSTR(CATALOG_NO,1,:K10) >= :K11"
        If Me.txtID.Text.Trim <> "" Then
            sQuery += "   AND SET_ID = :K01"
            _oDatabase.CreateParam("K01", Me.txtID.Text)
        End If
        sQuery += " ORDER BY SET_ID"

        _oDatabase.CreateParam("K10", GetKeyLength(Me.txtCatalog.Text))
        _oDatabase.CreateParam("K11", GetKey(Me.txtCatalog.Text))

        Using oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, sTable)
            Dim oDataView As DataView = oDataSet.Tables(sTable).DefaultView
            oDataView.Sort = MedicalLib.Common.ListSort()
            If oDataView.Count = 0 Then grdList.CurrentPageIndex = 0
            grdList.DataSource = oDataView
            grdList.DataBind()
            Dim nCountAll As Integer = oDataView.Count
            Dim nCountStart As Integer = (grdList.CurrentPageIndex * grdList.PageSize) + 1
            Dim nCountEnd As Integer = (grdList.CurrentPageIndex + 1) * grdList.PageSize
            If nCountAll < nCountEnd Then nCountEnd = nCountAll
            If nCountAll = 0 Then
                lblCount.Text = "該当データがありません"
            Else
                lblCount.Text = nCountAll & "件中、" & nCountStart & "～" & nCountEnd & "件を表示"
            End If
        End Using
    End Sub

    '組番取得
    Friend Function GetKumi(ByVal sCatalog As String) As String

        Dim sReturn As String = ""

        Dim con As MedicalLib.DataAccess = New MedicalLib.DataAccess
        Try
            Dim sQuery As String = ""
            sQuery = "SELECT C_NO FROM PARTS_MST WHERE CATALOG_NO = :K01"
            con.CreateParam("K01", sCatalog)
            Using oReader As OracleDataReader = con.CreateReaderParam(sQuery)
                If oReader.Read Then
                    sReturn = oReader(0).ToString
                End If
            End Using
        Finally
            con.Close()
        End Try

        Return sReturn

    End Function

#End Region

#Region " その他 "

    Private Function GetKey(ByVal sValue As String) As String
        If sValue.Trim.Equals("") Then
            Return " "
        Else
            Return sValue.Trim()
        End If
    End Function

    Private Function GetKeyLength(ByVal sValue As String) As Integer
        If sValue.Trim.Equals("") Then
            Return 1
        Else
            Return sValue.Trim.Length
        End If
    End Function

#End Region

End Class
