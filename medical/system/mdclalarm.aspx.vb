Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class mdclalarm 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDCLALM" 
    Private Const PROGRAM_TITLE As String = "アラートメッセージ" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        If Request.QueryString("kubun") Is Nothing Then 
            MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
            ViewState("kubun") = "0" 
        Else 
            Select Case Request.QueryString("kubun") 
                Case "1" 
                    MedicalLib.Common.ProgramTitle = "本社(棚在庫)安全在庫在庫割れ" + PROGRAM_TITLE 
                Case "2" 
                    MedicalLib.Common.ProgramTitle = "指定工程到達" + PROGRAM_TITLE 
                Case "3" 
                    MedicalLib.Common.ProgramTitle = "源製品・子部品・材料入庫" + PROGRAM_TITLE 
            End Select 
            ViewState("kubun") = Request.QueryString("kubun") 
        End If 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
            If Not Page.IsPostBack Then 
                GridBind() 
                btnConfirm.Attributes.Add("onclick", MedicalLib.Script.Update()) 
            End If 
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

    '確認ボタン押下 
    Protected Sub btnConfirm_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) 
        Page.Validate("run") : If Not Page.IsValid Then Return 
        If FileUpdate() Then GoWhitch() 
    End Sub 
 
    '戻るボタン押下 
    Protected Sub btnBack_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) 
        GoBack() 
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
        End If 
    End Sub 
 
#End Region 
 
#Region " 画面関連 " 
 
    Private Sub GridBind() 
        Dim sQuery As String = "" 
        Try 
            sQuery = "SELECT OCCUR_DT,OCCUR_TIME,MESSAGE,ALN_REN_BAN FROM ALARM_TBL " 
            sQuery += "WHERE ALM_KB = :K01 AND CONFIRM_FLG = '0' " 
            sQuery += "ORDER BY OCCUR_DT DESC,OCCUR_TIME DESC" 
            _oDatabase.CreateParam("K01", ViewState("kubun")) 
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1") 
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView 
            grdList.DataSource = oDataView 
            Try 
                grdList.DataBind() 
            Catch ex As Exception 
                If grdList.PageCount <= grdList.CurrentPageIndex Then 
                    grdList.CurrentPageIndex = grdList.PageCount - 1 
                    grdList.DataBind() 
                End If 
            End Try 
            udpList.Update() 
        Catch tex As Threading.ThreadAbortException 
            Throw 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
#End Region 
 
#Region " チェック関連 " 
 
    '実行時チェック 
    Protected Sub valRun_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) 
        Dim nCheck As Boolean = False 
        Dim oItem As DataGridItem 
        CType(source, CustomValidator).ErrorMessage = "行が選択されていません" 
        For Each oItem In grdList.Items 
            If CType(oItem.Cells(0).Controls(1), CheckBox).Checked Then 
                nCheck = True 
                Exit For 
            End If 
        Next 
        args.IsValid = nCheck 
    End Sub 
 
#End Region 
 
#Region " ファイル関連 " 
 
    Private Function FileUpdate() As Boolean 
        Dim sQuery As String = ""
        Try
            _oDatabase.BeginTrans()
            For i As Integer = 0 To grdList.Items.Count - 1
                If CType(grdList.Items(i).Cells(0).Controls(1), CheckBox).Checked Then
                    sQuery = "UPDATE ALARM_TBL SET "
                    sQuery += "CONFIRM_FLG = :F01,"
                    sQuery += "UPD_DT = :F02,"
                    sQuery += "UPD_TIME = :F03,"
                    sQuery += "UPD_USR = :F04,"
                    sQuery += "UPD_PROGRAM_ID = :F05 "
                    sQuery += "WHERE ALM_KB = :K01 AND ALN_REN_BAN = :K02"
                    _oDatabase.CreateParam("F01", "1")
                    _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F04", Session("UserID"))
                    _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                    _oDatabase.CreateParam("K01", ViewState("kubun"))
                    _oDatabase.CreateParam("K02", grdList.Items(i).Cells(3).Text.Trim())
                    _oDatabase.ExecuteNonQueryParam(sQuery)
                End If
            Next
            _oDatabase.CommitTrans()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return True
    End Function 
 
#End Region 
 
#Region " その他 " 
 
    Private Sub GoWhitch() 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery = "SELECT COUNT(ALN_REN_BAN) FROM ALARM_TBL WHERE ALM_KB = '1' AND CONFIRM_FLG = '0'" 
            oReader = _oDatabase.CreateReader(sQuery) 
            oReader.Read() 
            Dim nCount As Integer = GetInt32(oReader, 0) 
            oReader.Close() 
            If nCount > 0 Then 
                GridBind() 
            Else 
                GoBack() 
            End If 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
    Private Sub GoBack() 
        Response.Redirect("mdclmenu.aspx", False) 
    End Sub 
 
    Friend Function GetHasseibi(ByVal sValue1 As String, ByVal sValue2 As String) As String 
        If sValue1.Trim.Equals("00000000") Then Return "" 
        Return (MedicalLib.Common.DateFormat(sValue1) + " " + MedicalLib.Common.TimeFormat(sValue2)).PadRight(19, " ") 
    End Function 
 
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
