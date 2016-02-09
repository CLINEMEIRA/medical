Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient 
 
Partial Class master_mdsrc161 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC161" 
    Private Const PROGRAM_TITLE As String = "部品在庫検索" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            If Not Page.IsPostBack Then
                If Not Request.QueryString("mode") Is Nothing Then ViewState("mode") = Request.QueryString("mode")
                lblCatalog.Text = Request.QueryString("catalog").Trim()
                If lblCatalog.Text = "undefined" Then lblCatalog.Text = ""
                txtSiji.Text = Request.QueryString("sijino").Trim()
                'MedicalLib.Common.ListSort = "INDICATE_NO"
                MedicalLib.Common.ListSort = ""
                scrManager.SetFocus(txtSiji)
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
            If ViewState("mode") = "1" Then
                oLine.Attributes("onclick") = "closeWindow2('" + oLine.Cells(1).Text + "','" + oLine.Cells(3).Text + "')"
            Else
                oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(1).Text + "','" + oLine.Cells(0).Text + "','" + oLine.Cells(5).Text + "')"
            End If
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
 
#Region " 画面関連 "

    Private Sub DisplayList()
        Dim sQuery As String = ""
        Try
            '**** 2008/12/26 START ****
            '******** 部品入庫訂正から来る場合の条件変更

            If ViewState("mode") = "1" Then

                sQuery = ""
                sQuery += "SELECT * FROM "
                sQuery += "(SELECT INDICATE_NO,COMPANY_NO,WH_DT,RSTOCK_AMT,F_STOCK_AMT,SHELF_NO "
                sQuery += " FROM PARTS_STOCK_TBL "
                sQuery += " WHERE CATALOG_NO = :K01 AND SUBSTR(INDICATE_NO,1,:K10) >= :K11 "
                sQuery += " AND RSTOCK_AMT > 0 "
                sQuery += " ORDER BY COMPANY_NO,WH_DT,INDICATE_NO"
                sQuery += ") A "
                sQuery += " UNION ALL "
                sQuery += "SELECT * FROM "
                sQuery += "(SELECT INDICATE_NO,COMPANY_NO,WH_DT,RSTOCK_AMT,F_STOCK_AMT,SHELF_NO "
                sQuery += " FROM PARTS_STOCK_TBL "
                sQuery += " WHERE CATALOG_NO = :K01 AND SUBSTR(INDICATE_NO,1,:K10) >= :K11 "
                sQuery += " AND RSTOCK_AMT = 0 "
                sQuery += " ORDER BY COMPANY_NO,WH_DT,INDICATE_NO"
                sQuery += ") B"

            Else

                sQuery = "SELECT INDICATE_NO,COMPANY_NO,WH_DT,RSTOCK_AMT,F_STOCK_AMT,SHELF_NO "
                sQuery += "FROM PARTS_STOCK_TBL "
                'sQuery += "WHERE CATALOG_NO LIKE :K01 AND SUBSTR(INDICATE_NO,1,:K10) >= :K11 "
                sQuery += "WHERE CATALOG_NO = :K01 AND SUBSTR(INDICATE_NO,1,:K10) >= :K11 "
                'If ViewState("mode") = "1" Then sQuery += "AND RSTOCK_AMT > 0 "
                sQuery += "ORDER BY COMPANY_NO,WH_DT,INDICATE_NO"

            End If

            'sQuery = "SELECT INDICATE_NO,COMPANY_NO,WH_DT,RSTOCK_AMT,F_STOCK_AMT,SHELF_NO "
            'sQuery += "FROM PARTS_STOCK_TBL "
            ''sQuery += "WHERE CATALOG_NO LIKE :K01 AND SUBSTR(INDICATE_NO,1,:K10) >= :K11 "
            'sQuery += "WHERE CATALOG_NO = :K01 AND SUBSTR(INDICATE_NO,1,:K10) >= :K11 "
            'If ViewState("mode") = "1" Then sQuery += "AND RSTOCK_AMT > 0 "
            'sQuery += "ORDER BY COMPANY_NO,WH_DT,INDICATE_NO"
            '**** 2008/12/26 END ****

            '_oDatabase.CreateParam("K01", "%" + lblCatalog.Text.Trim() + "%")
            _oDatabase.CreateParam("K01", lblCatalog.Text.Trim())
            _oDatabase.CreateParam("K10", GetKeyLength(txtSiji.Text))
            _oDatabase.CreateParam("K11", GetKey(txtSiji.Text))
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView
            If MedicalLib.Common.ListSort.Trim <> "ASC" Then
                oDataView.Sort = MedicalLib.Common.ListSort()
            End If
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
        Catch tex As Threading.ThreadAbortException
            Throw
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

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
