Imports System.IO 
Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdmas025 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS025" 
    Private Const PROGRAM_TITLE As String = "プログラムマスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        If Not Page.IsPostBack Then 
            DisplayInit() 
            btnDelete.Attributes.Add("onclick", MedicalLib.Script.Delete()) 
            MedicalLib.Common.Sort = "PROGRAM_ID" 
            grdList.PageSize = 20 
            DisplayGrid() 
            txtCode.Focus() 
        End If 
        btnInsert.Visible = MedicalLib.Common.EnableInsert 
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
            oLine.Attributes("onclick") = "selectGridRow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "')" 
        End If 
    End Sub 
 
    Protected Sub grdList_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdList.PageIndexChanged 
        grdList.CurrentPageIndex = e.NewPageIndex 
        DisplayGrid() 
    End Sub 
 
    Protected Sub grdList_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdList.SortCommand 
        MedicalLib.Common.SortCommand(e) 
        DisplayGrid() 
    End Sub

    '検索ボタン押下
    Protected Sub btnSearch_Click(sender As Object, e As ImageClickEventArgs) Handles btnSearch.Click
        Select Case True
            Case txtCode.Text.Trim.Equals("") And txtName.Text.Trim.Equals("")
                Session("SortExpression") = "PROGRAM_ID"
            Case Not txtCode.Text.Trim.Equals("") And txtName.Text.Trim.Equals("")
                Session("SortExpression") = "PROGRAM_ID"
            Case txtCode.Text.Trim.Equals("") And Not txtName.Text.Trim.Equals("")
                Session("SortExpression") = "PG_NM"
            Case Not txtCode.Text.Trim.Equals("") And Not txtName.Text.Trim.Equals("")
                Session("SortExpression") = "PROGRAM_ID"
        End Select
        Session("SortDirection") = "ASC" 
        DisplayClear() 
    End Sub

    '選択ボタン(隠し)押下 
    Protected Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        DisplayShow(txtSave.Value)
    End Sub
    '選択ボタン(隠し)押下 
    'Protected Sub btnSelect_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles btnSelect.Click
    '    DisplayShow(txtSave.Value)
    'End Sub

    '新規ボタン押下 
    Protected Sub btnInsert_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnInsert.Click
        txtProgramID.Enabled = True
        txtProgramID.Text = ""
        txtProgramName.Text = ""
        txtFilePath.Text = ""
        btnUpdate.Attributes.Add("onclick", MedicalLib.Script.Insert())
        btnUpdate.Attributes("src") = "../image/b_insert.gif"
        btnDelete.Visible = False
        pnlInput.Visible = True
        udpInput.Update()
    End Sub

    '登録、修正ボタン押下 
    Protected Sub btnUpdate_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnUpdate.Click
        Page.Validate("input")
        If Not Page.IsValid Then Return
        If Not FileUpdate() Then Return
        DisplayClear()
    End Sub

    '削除ボタン押下 
    Protected Sub btnDelete_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnDelete.Click
        If Not FileDelete() Then Return
        DisplayClear()
    End Sub

    '戻るボタン押下 
    Protected Sub btnBack_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBack.Click
        DisplayClear()
    End Sub

#End Region

#Region " 画面関連 "

    '画面初期化 
    Private Sub DisplayInit() 
        txtCode.Text = "" 
        txtName.Text = "" 
        txtProgramID.Text = "" 
        txtProgramName.Text = "" 
        txtFilePath.Text = "" 
        pnlInput.Visible = False 
        udpInput.Update() 
    End Sub 
 
    '画面クリア 
    Private Sub DisplayClear() 
        txtProgramID.Text = "" 
        txtProgramName.Text = "" 
        txtFilePath.Text = "" 
        pnlInput.Visible = False 
        udpInput.Update() 
        DisplayGrid() 
    End Sub 
 
    '画面表示 
    Private Sub DisplayShow(ByVal sCode As String) 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery = "SELECT PG_NM,FILE_PATH FROM PROGRAM_MST WHERE MENU_LEBEL = '2' AND PROGRAM_ID = :K01" 
            _oDatabase.CreateParam("K01", sCode.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                txtProgramID.Text = sCode.Trim() 
                txtProgramName.Text = GetString(oReader, 0) 
                txtFilePath.Text = GetString(oReader, 1) 
            End If 
            oReader.Close() 
            txtProgramID.Enabled = False 
            btnUpdate.Attributes.Add("onclick", MedicalLib.Script.Update()) 
            btnUpdate.Attributes("src") = "../image/b_update.gif" 
            btnUpdate.Visible = MedicalLib.Common.EnableUpdate 
            btnDelete.Visible = MedicalLib.Common.EnableDelete 
            pnlInput.Visible = True 
            udpInput.Update() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
    'リスト表示 
    Private Sub DisplayGrid() 
        Dim sQuery As String = "" 
        Try 
            sQuery = "SELECT PROGRAM_ID,PG_NM FROM PROGRAM_MST " 
            sQuery += "WHERE MENU_LEBEL = '2' AND PROGRAM_ID LIKE :K01 AND PG_NM LIKE :K02" 
            _oDatabase.CreateParam("K01", txtCode.Text.Trim() + "%") 
            _oDatabase.CreateParam("K02", "%" + txtName.Text.Trim() + "%") 
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1") 
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView 
            oDataView.Sort = MedicalLib.Common.Sort() 
            grdList.DataSource = oDataView 
            Try 
                grdList.DataBind() 
            Catch ex As Exception 
                If grdList.PageCount <= grdList.CurrentPageIndex Then 
                    grdList.CurrentPageIndex = grdList.PageCount - 1 
                    grdList.DataBind() 
                End If 
            End Try 
 
            Dim nCountAll As Integer = oDataView.Count 
            Dim nCountStart As Integer = (grdList.CurrentPageIndex * grdList.PageSize) + 1 
            Dim nCountEnd As Integer = (grdList.CurrentPageIndex + 1) * grdList.PageSize 
            If nCountAll < nCountEnd Then nCountEnd = nCountAll 
            If nCountAll = 0 Then 
                lblCount.Text = "該当データがありません" 
            Else 
                lblCount.Text = nCountAll & "件中、" & nCountStart & "～" & nCountEnd & "件を表示" 
            End If 
            udpList.Update() 
        Catch tex As Threading.ThreadAbortException 
            Throw 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
#End Region 
 
#Region " チェック関連 " 
 
    'ファイル存在 
    Protected Sub valProgramID3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valProgramID3.ServerValidate 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            If txtProgramID.Enabled Then 
                sQuery = "SELECT PROGRAM_ID FROM PROGRAM_MST WHERE MENU_LEBEL = '2' AND PROGRAM_ID = :K01" 
                _oDatabase.CreateParam("K01", args.Value.Trim()) 
                oReader = _oDatabase.CreateReaderParam(sQuery) 
                args.IsValid = Not oReader.Read() 
                oReader.Close() 
            End If 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
    'ファイル存在 
    Protected Sub valFilePath3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valFilePath3.ServerValidate 
        Dim sFile As String = Server.MapPath("~" + args.Value.Trim()) 
        args.IsValid = File.Exists(sFile) 
    End Sub 
 
#End Region 
 
#Region " ファイル関連 " 
 
    Private Function FileUpdate() As Boolean 
        Dim sQuery As String = "" 
        Try 
            If txtProgramID.Enabled Then 
                '登録 
                sQuery = "INSERT INTO PROGRAM_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11)" 
                _oDatabase.CreateParam("F01", "2")                                  'MENU_LEBEL 
                _oDatabase.CreateParam("F02", txtProgramID.Text.Trim())             'PROGRAM_ID 
                _oDatabase.CreateParam("F03", txtProgramName.Text.Trim())           'PG_NM 
                _oDatabase.CreateParam("F04", txtFilePath.Text.Trim())              'FILE_PATH 
                _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)      'CRT_DT 
                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)      'CRT_TIME 
                _oDatabase.CreateParam("F07", Session("UserID"))                    'CRT_USR 
                _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                _oDatabase.CreateParam("F10", Session("UserID"))                    'UPD_USR 
                _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
            Else 
                '更新 
                sQuery = "UPDATE PROGRAM_MST SET " 
                sQuery += "PG_NM = :F01," 
                sQuery += "FILE_PATH = :F02," 
                sQuery += "UPD_DT = :F03," 
                sQuery += "UPD_TIME = :F04," 
                sQuery += "UPD_USR = :F05," 
                sQuery += "UPD_PROGRAM_ID = :F06 " 
                sQuery += "WHERE MENU_LEBEL = '2' AND PROGRAM_ID = :K01" 
                _oDatabase.CreateParam("F01", txtProgramName.Text.Trim())           'PG_NM 
                _oDatabase.CreateParam("F02", txtFilePath.Text.Trim())              'FILE_PATH 
                _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)      'UPD_DT 
                _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
                _oDatabase.CreateParam("F05", Session("UserID"))                    'UPD_USR 
                _oDatabase.CreateParam("F06", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
                _oDatabase.CreateParam("K01", txtProgramID.Text.Trim())             'PROGRAM_ID 
            End If 
            _oDatabase.ExecuteNonQueryParam(sQuery) 
            Return True 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Function 
 
    '削除 
    Private Function FileDelete() As Boolean 
        Dim sQuery As String = "" 
        Try 
            sQuery = "DELETE FROM PROGRAM_MST WHERE MENU_LEBEL = '2' AND PROGRAM_ID = :K01" 
            _oDatabase.CreateParam("K01", txtProgramID.Text.Trim()) 
            _oDatabase.ExecuteNonQueryParam(sQuery) 
            Return True 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Function 
 
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


#End Region

End Class 
