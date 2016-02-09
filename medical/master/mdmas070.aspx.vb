Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdmas070 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS070" 
    Private Const PROGRAM_TITLE As String = "部品構成マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "PARTS_CONSIST_MST"
    Private Const TABLE_NAME_JP As String = "部品構成マスタ"
 
    Private Const BUTTON_INSERT As Integer = 0 
    Private Const BUTTON_UPDATE As Integer = 1 
 
#Region " プロパティ " 
 
    Public Property SelectedIndex() As Integer 
        Get 
            Dim obj As Object = ViewState("SelectedIndex") 
            If obj Is Nothing Then 
                Return 0 
            End If 
            Return CType(obj, Integer) 
        End Get 
 
        Set(ByVal Value As Integer) 
            ViewState("SelectedIndex") = Value 
        End Set 
    End Property 
 
#End Region 
 
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
            txtCatalog.Text = "" 
            trvList.Nodes.Clear() 
            pnlInfo.Visible = False
            btnDel.Visible = False 
            btnDel.Attributes.Add("onclick", MedicalLib.Script.Delete()) 
            btnSelDel.Attributes.Add("onclick", MedicalLib.Script.Delete()) 
            ViewState("saverow") = -1 
            txtCatalog.Focus() 
        End If 
    End Sub 
  
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    '検索ボタン 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        pnlInfo.Visible = False
        udpInfo.Update()
        Page.Validate("key")
        If Page.IsValid Then
            Try
                Dim sQuery As String = "SELECT COMPANY_NO FROM PARTS_MST WHERE CATALOG_NO = :KEY1"
                _oDatabase.CreateParam("KEY1", txtCatalog.Text.Trim())
                Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read() Then
                    If Not oReader.IsDBNull(0) Then lblSyanai.Text = oReader.GetString(0).Trim()
                End If
                oReader.Close()
            Catch ex As Exception
                MedicalLib.PageError.Show(ex.Message)
            End Try
            ViewState("code1") = txtCatalog.Text.Trim
            SetNewNode(txtCatalog.Text.Trim())
        End If
    End Sub

    '新規ボタン 
    Protected Sub btnNew_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnNew.Click
        grdList.SelectedIndex = -1
        Me.SelectedIndex = grdList.SelectedIndex
        ClearInput()
        ButtonChange(BUTTON_INSERT)
        btnDel.Visible = False
    End Sub

    '選択削除ボタン 
    Protected Sub btnSelDel_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSelDel.Click
        Page.Validate("seldel")
        If Page.IsValid Then
            FileDeletes()
            SetNewNode(txtCatalog.Text.Trim())
            GridBind()
            ClearInput()
            ButtonChange(BUTTON_INSERT)
        End If
    End Sub

    '実行ボタン(登録・更新) 
    Protected Sub btnRun_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnRun.Click
        valKo1.Enabled = txtKo.Enabled
        valKo2.Enabled = txtKo.Enabled
        Page.Validate("run")
        If Page.IsValid Then
            If txtKo.Enabled Then
                FileInsert()
            Else
                Page.Validate("update")
                If Not Page.IsValid Then Exit Sub
                FileUpdate()
            End If
            SetNewNode(txtCatalog.Text.Trim())
            GridBind()
            ClearInput()
            ButtonChange(BUTTON_INSERT)
        End If
    End Sub

    '削除 
    Protected Sub btnDel_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnDel.Click
        Page.Validate("del")
        If Page.IsValid Then
            Page.Validate("update")
            If Not Page.IsValid Then Exit Sub
            FileDelete()
            SetNewNode(txtCatalog.Text.Trim())
            GridBind()
            ClearInput()
            ButtonChange(BUTTON_INSERT)
        End If
    End Sub

    'ノードセレクト 
    Protected Sub trvList_SelectedNodeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trvList.SelectedNodeChanged 
        lblOya.Text = CType(sender, TreeView).SelectedNode.Value 
        GridBind() 
        pnlInfo.Visible = True
        ClearInput() 
        ButtonChange(BUTTON_INSERT) 
        btnNew.Visible = MedicalLib.Common.EnableInsert 
        btnSelDel.Visible = MedicalLib.Common.EnableDelete 
        udpInfo.Update() 
    End Sub 
 
    Protected Sub grdList_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdList.ItemCommand 
        If e.CommandName.ToUpper.Equals("SELECT") Then 
            chkAll.Checked = False 
            grdList.SelectedIndex = e.Item.ItemIndex 
            ButtonChange(BUTTON_UPDATE) 
        End If 
    End Sub 
 
    Protected Sub grdList_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList.ItemDataBound 
        Dim origItem As String = ColorTranslator.ToHtml(grdList.ItemStyle.BackColor) 
        Dim origAltItem As String = ColorTranslator.ToHtml(grdList.AlternatingItemStyle.BackColor) 
        Dim oLine As DataGridItem = e.Item 
        If oLine.ItemType = ListItemType.Item Or oLine.ItemType = ListItemType.AlternatingItem Or oLine.ItemType = ListItemType.SelectedItem Then 
            oLine.Style("cursor") = "hand" 
            oLine.Attributes("onmouseover") = "this.style.backgroundColor='Gold'" 
            If oLine.ItemType = ListItemType.Item Then 
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origItem + "'" 
            Else 
                oLine.Attributes("onmouseout") = "this.style.backgroundColor='" + origAltItem + "'" 
            End If 
            Dim lbtn As LinkButton = CType(e.Item.FindControl("btnLink"), LinkButton) 
            e.Item.Cells(2).Attributes("onClick") = ClientScript.GetPostBackClientHyperlink(lbtn, "") 
            e.Item.Cells(3).Attributes("onClick") = ClientScript.GetPostBackClientHyperlink(lbtn, "") 
        End If 
    End Sub 
 
    Protected Sub grdList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdList.SelectedIndexChanged 
        Me.SelectedIndex = grdList.SelectedIndex 
        grdList.SelectedItem.Attributes.Item("onmouseover") = "this.style.cursor='hand'" 
        grdList.SelectedItem.Attributes.Remove("onmouseout") 
        If ViewState("saverow") <> -1 Then 
            Dim origItem As String = ColorTranslator.ToHtml(grdList.ItemStyle.BackColor) 
            Dim origAltItem As String = ColorTranslator.ToHtml(grdList.AlternatingItemStyle.BackColor) 
            grdList.Items(ViewState("saverow")).Attributes.Item("onmouseover") = "this.style.backgroundColor='Gold'" 
            If grdList.Items(ViewState("saverow")).ItemType = ListItemType.Item Then 
                grdList.Items(ViewState("saverow")).Attributes("onmouseout") = "this.style.backgroundColor='" + origItem + "'" 
            Else 
                grdList.Items(ViewState("saverow")).Attributes("onmouseout") = "this.style.backgroundColor='" + origAltItem + "'" 
            End If 
        End If 
        txtKo.Text = grdList.SelectedItem.Cells(2).Text 
        txtSu.Text = grdList.SelectedItem.Cells(3).Text 
        ViewState("update") = grdList.SelectedItem.Cells(4).Text 
        txtKo.Enabled = False 
        lnkKo.Visible = False 
        lblKo.Visible = True 
        ViewState("saverow") = grdList.SelectedIndex 
    End Sub

#End Region

#Region " チェック関連 "

    'カタログ番号 
    Public Sub CheckCatalog(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valCatalog2.ServerValidate
        e.IsValid = CheckBuhin(txtCatalog.Text)
    End Sub

    '子部品番号 
    Public Sub CheckKo(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valKo2.ServerValidate
        e.IsValid = CheckKo()
    End Sub

    Private Function CheckKo() As Boolean 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            '部品存在 
            If Not CheckBuhin(txtKo.Text) Then 
                valKo2.ErrorMessage = "部品マスタに登録されていません" 
                Return False 
            End If 
            '親部品比較 
            If lblOya.Text.Trim() = txtKo.Text.Trim() Then 
                valKo2.ErrorMessage = "親部品番号と同じ番号は入力できません" 
                Return False 
            End If 
            '重複 
            _oDatabase.CreateParam("K01", lblOya.Text.Trim()) 
            _oDatabase.CreateParam("K02", txtKo.Text.Trim()) 
            sQuery = "SELECT PER_CATALOG_NO FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO=:K01 AND CHD_CATALOG_NO=:K02" 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.HasRows Then 
                valKo2.ErrorMessage = "既に登録されています" 
                Return False 
            End If 
            oReader.Close() 
            '階層同一存在 
            _oDatabase.CreateParam("K01", txtKo.Text.Trim()) 
            _oDatabase.CreateParam("K02", lblOya.Text.Trim()) 
            sQuery = "SELECT LEVEL FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO=:K01 START WITH CHD_CATALOG_NO=:K02 CONNECT BY PRIOR PER_CATALOG_NO = CHD_CATALOG_NO" 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.HasRows Then 
                valKo2.ErrorMessage = "この位置には登録できません" 
                Return False 
            End If 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        Return True 
    End Function 
 
    '部品マスタ存在 
    Private Function CheckBuhin(ByVal sCode As String) As Boolean 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            Dim sQuery As String = "SELECT * FROM PARTS_MST WHERE CATALOG_NO = :KEY1" 
            _oDatabase.CreateParam("KEY1", sCode.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            Return oReader.HasRows 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader.Close() 
        End Try 
    End Function

    '削除 
    Public Sub CheckDelete(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDel.ServerValidate
        '自分より上位の部品の指示が出てたら消せないチェックを入れる 
        e.IsValid = Not CheckOya()
    End Sub

    '選択削除 
    Public Sub CheckSelDel(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valSelDel.ServerValidate
        Dim nCheck As Boolean = False
        Dim oItem As DataGridItem
        For Each oItem In grdList.Items
            Dim oCheck As CheckBox = CType(oItem.Cells(1).Controls(1), CheckBox)
            If oCheck.Checked Then
                nCheck = True
                Exit For
            End If
        Next
        e.IsValid = nCheck
        If Not nCheck Then Exit Sub
        '親チェック 
        valSelDel.ErrorMessage = "親部品が作業指示中です"
        e.IsValid = Not CheckOya()
        If Not e.IsValid Then Exit Sub
        '更新チェック 
        For Each oItem In grdList.Items
            Dim oCheck As CheckBox = CType(oItem.Cells(1).Controls(1), CheckBox)
            If oCheck.Checked Then
                Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO = :K01 AND CHD_CATALOG_NO = :K02"
                Dim oReader As OracleDataReader = Nothing
                Try
                    _oDatabase.CreateParam("K01", lblOya.Text.Trim())
                    _oDatabase.CreateParam("K02", oItem.Cells(2).Text)
                    oReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        CType(sender, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_UPDATE2
                        e.IsValid = oItem.Cells(4).Text = oReader.GetString(0).Trim()
                    Else
                        CType(sender, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_DELETE2
                        e.IsValid = False
                    End If
                    oReader.Close()
                Catch ex As Exception
                    MedicalLib.PageError.Show(ex.Message)
                Finally
                    oReader = Nothing
                End Try
            End If
        Next
    End Sub

    Private Function CheckOya() As Boolean 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            Dim sQuery As String = "SELECT INDICATE_NO FROM INDICATE_TBL WHERE I_PARTS_NO = :K01 AND TRIM(DEL_FLG) IS NULL" 
            _oDatabase.CreateParam("K01", lblOya.Text.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            Dim nHasRow As Boolean = oReader.HasRows 
            oReader.Close() 
            Return nHasRow 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader.Close() 
        End Try 
    End Function

    '更新チェック 
    Friend Sub valDate_ServerValidate(ByVal sender As Object, ByVal e As ServerValidateEventArgs) Handles valDate.ServerValidate
        Dim sQuery As String = "SELECT UPD_DT || UPD_TIME FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO = :K01 AND CHD_CATALOG_NO = :K02"
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.CreateParam("K01", lblOya.Text.Trim())
            _oDatabase.CreateParam("K02", txtKo.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                CType(sender, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_UPDATE
                e.IsValid = ViewState("update") = oReader.GetString(0).Trim()
            Else
                CType(sender, CustomValidator).ErrorMessage = MedicalLib.Common.LOCK_DELETE
                e.IsValid = False
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

#End Region

#Region " ファイル関連 "

    '登録処理 
    Private Sub FileInsert()
        Try
            _oDatabase.BeginTrans()

            'マスタ更新履歴テーブル追加
            InsertHistory(lblOya.Text.Trim() + ":" + txtKo.Text.Trim())

            _oDatabase.CreateParam("F01", lblOya.Text.Trim())
            _oDatabase.CreateParam("F02", txtKo.Text.Trim())
            _oDatabase.CreateParam("F03", txtSu.Text.Trim())
            _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F06", Session("UserID"))
            _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F09", Session("UserID"))
            _oDatabase.CreateParam("F10", MedicalLib.Common.ProgramID)
            Dim sQuery As String = "INSERT INTO PARTS_CONSIST_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10)"
            _oDatabase.ExecuteNonQueryParam(sQuery)
            _oDatabase.CommitTrans()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub
 
    '更新処理 
    Private Sub FileUpdate() 
        Try
            _oDatabase.BeginTrans()

            'マスタ更新履歴テーブル追加
            UpdateHistory(lblOya.Text.Trim(), txtKo.Text.Trim())

            _oDatabase.CreateParam("F01", txtSu.Text.Trim())
            _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F04", Session("UserID"))
            _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", lblOya.Text.Trim())
            _oDatabase.CreateParam("K02", txtKo.Text.Trim())
            Dim sQuery As String = "UPDATE PARTS_CONSIST_MST SET USE_AMT=:F01,UPD_DT=:F02,UPD_TIME=:F03,UPD_USR=:F04,UPD_PROGRAM_ID=:F05 " & _
                                   "WHERE PER_CATALOG_NO=:K01 AND CHD_CATALOG_NO=:K02"
            _oDatabase.ExecuteNonQueryParam(sQuery)
            _oDatabase.CommitTrans()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub 
 
    '削除処理 
    Private Sub FileDelete() 
        Try
            _oDatabase.BeginTrans()

            'マスタ更新履歴テーブル追加
            DeleteHistory(lblOya.Text.Trim() + ":" + txtKo.Text.Trim)

            _oDatabase.CreateParam("K01", lblOya.Text.Trim())
            _oDatabase.CreateParam("K02", txtKo.Text.Trim())
            Dim sQuery As String = "DELETE FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO=:K01 AND CHD_CATALOG_NO=:K02"
            _oDatabase.ExecuteNonQueryParam(sQuery)
            _oDatabase.CommitTrans()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub 
 
    '選択削除処理 
    Private Sub FileDeletes() 
        Try 
            _oDatabase.BeginTrans() 
            Dim sQuery As String = "DELETE FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO=:K01 AND CHD_CATALOG_NO=:K02" 
            Dim oItem As DataGridItem 
            For Each oItem In grdList.Items

                'マスタ更新履歴テーブル追加
                DeleteHistory(lblOya.Text.Trim() + ":" + oItem.Cells(2).Text.Trim())

                Dim oCheck As CheckBox = CType(oItem.Cells(1).Controls(1), CheckBox)
                If oCheck.Checked Then
                    _oDatabase.CreateParam("K01", lblOya.Text.Trim())
                    _oDatabase.CreateParam("K02", oItem.Cells(2).Text.Trim())
                    _oDatabase.ExecuteNonQueryParam(sQuery)
                End If
            Next
            _oDatabase.CommitTrans() 
        Catch ex As Exception 
            _oDatabase.Rollback() 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
#End Region 
 
#Region " ユーザー関数 " 
 
    Private Sub SetNewNode(ByVal parent As String) 
        trvList.Nodes.Clear() 
        Dim oNode As New TreeNode() 
        oNode.NavigateUrl = "" 
        oNode.Target = "" 
        oNode.Text = txtCatalog.Text.Trim() 
        oNode.Value = txtCatalog.Text.Trim() 
        SetNewNode(txtCatalog.Text.Trim(), oNode.ChildNodes) 
        trvList.Nodes.Add(oNode) 
        trvList.ExpandAll() 
    End Sub 
 
    Private Function SetNewNode(ByVal parent As String, ByVal oNodes As TreeNodeCollection) As Boolean 
        Dim nFlag As Boolean = False 
        Dim sQuery As String = "SELECT CHD_CATALOG_NO,USE_AMT FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO = :KEY1" 
        _oDatabase.CreateParam("KEY1", parent) 
        Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
        Do While oReader.Read() 
            Dim oNode As New TreeNode() 
            oNode.NavigateUrl = "" 
            oNode.Target = "" 
            oNode.Text = oReader.GetString(0).Trim() + " * " + oReader.GetInt32(1).ToString("#,##0") 
            oNode.Value = oReader.GetString(0).Trim() 
            SetNewNode(oReader.GetString(0).Trim(), oNode.ChildNodes) 
            oNodes.Add(oNode) 
            nFlag = True 
        Loop 
        oReader.Close() 
        Return nFlag 
    End Function 
 
    Private Sub GridBind() 
        Try 
            Dim sQuery As String = "SELECT CHD_CATALOG_NO,USE_AMT,UPD_DT || UPD_TIME 更新 FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO = :KEY1" 
            _oDatabase.CreateParam("KEY1", lblOya.Text.Trim()) 
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1") 
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView 
            grdList.SelectedIndex = -1 
            grdList.DataSource = oDataView 
            grdList.DataBind() 
        Catch tex As Threading.ThreadAbortException 
            Throw 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
    'ボタン変更 
    Private Sub ButtonChange(ByVal nButton As Integer) 
        If nButton = BUTTON_INSERT Then 
            btnRun.Attributes("src") = "../image/b_insert.gif" 
            btnRun.Attributes.Add("onclick", MedicalLib.Script.Insert()) 
            btnRun.Visible = MedicalLib.Common.EnableInsert 
            btnDel.Visible = False 
        Else 
            btnRun.Attributes("src") = "../image/b_update.gif" 
            btnRun.Attributes.Add("onclick", MedicalLib.Script.Update()) 
            btnRun.Visible = MedicalLib.Common.EnableUpdate 
            btnDel.Visible = MedicalLib.Common.EnableDelete 
        End If 
    End Sub 
 
    '入力項目クリア 
    Private Sub ClearInput() 
        txtKo.Text = "" 
        txtSu.Text = "" 
        txtKo.Enabled = True 
        lnkKo.Visible = True 
        lblKo.visible = False 
        chkAll.Checked = False 
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

#End Region

#Region " 更新履歴用 "

    Private Sub InsertHistory(ByVal sKey As String)
        InsertMH(sKey, "追加", "", "")
    End Sub

    Private Sub DeleteHistory(ByVal sKey As String)
        InsertMH(sKey, "削除", "", "")
    End Sub

    Private Sub UpdateHistory(ByVal sOya As String, ByVal sKo As String)
        Dim sItemNames() As String = GetItemName().Split(",")
        Dim sMotoValues() As String = GetMotoValue(sOya, sKo, sItemNames.Length()).Split(",")
        Dim sGenValues() As String = (txtSu.Text.Trim).Split(",")

        Dim i As Integer
        For i = 0 To sItemNames.Length - 1
            If sMotoValues(i) <> sGenValues(i) Then
                InsertMH(sOya + ":" + sKo, sItemNames(i), sMotoValues(i), sGenValues(i))
            End If
        Next
    End Sub

    '項目名をコンマ区切りで返す
    Private Function GetItemName() As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim sConnectString As String = ConfigurationManager.ConnectionStrings("MedicalDB").ToString()
        Dim sStartPos As Integer = sConnectString.IndexOf("User Id=")
        Dim sEndPos As Integer = sConnectString.IndexOf(";", sStartPos + 1)
        Dim sUserID As String = sConnectString.Substring(sStartPos, sEndPos - sStartPos).Replace("User Id=", "")
        Dim sResult As String = ""
        Try
            sQuery = "SELECT A.COLUMN_NAME,B.DOUBLE_BYTE,A.DATA_TYPE "
            sQuery += "FROM DBA_TAB_COLUMNS A,FIELD_NAME_TBL B "
            sQuery += "WHERE A.COLUMN_NAME = B.SINGLE_BYTE(+) AND A.OWNER = :K01 AND A.TABLE_NAME = :K02 "
            sQuery += "ORDER BY A.COLUMN_ID"
            _oDatabase.CreateParam("K01", sUserID.ToUpper())
            _oDatabase.CreateParam("K02", TABLE_NAME)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            While oReader.Read
                If GetString(oReader, 1) <> "親カタログ番号" And GetString(oReader, 1) <> "子カタログ番号" Then   '主キー以外
                    If GetString(oReader, 1) = "登録日付" Then
                        Exit While
                    Else
                        sResult += GetString(oReader, 1) + ","
                    End If
                End If
            End While
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult.Substring(0, sResult.Length - 1)
    End Function

    '更新前項目をコンマ区切りで返す
    Private Function GetMotoValue(ByVal sOya As String, ByVal sKo As String, ByVal iItemSu As Integer) As String
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Dim i As Integer = 0
        Dim iKeySu As Integer = 2       '主キー項目数
        Dim sResult As String = ""
        Try
            sQuery = "SELECT * FROM PARTS_CONSIST_MST WHERE PER_CATALOG_NO = :KEY1 AND CHD_CATALOG_NO = :KEY2"
            _oDatabase.CreateParam("KEY1", sOya)
            _oDatabase.CreateParam("KEY2", sKo)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                For i = iKeySu To iItemSu - 1 + iKeySu
                    sResult += GetInt32(oReader, i).ToString + ","
                Next
            End If
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return sResult.Substring(0, sResult.Length - 1)
    End Function

    'マスタ更新履歴テーブル追加
    Private Sub InsertMH(ByVal sKey As String, ByVal sItemName As String, ByVal sMae As String, ByVal sAto As String)
        Dim sQuery As String = ""

        sQuery = "INSERT INTO MASTER_HIS_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
                                                    ":F11,:F12,:F13,:F14)"
        _oDatabase.CreateParam("F01", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F03", TABLE_NAME_JP)
        _oDatabase.CreateParam("F04", sKey)
        _oDatabase.CreateParam("F05", sItemName)
        _oDatabase.CreateParam("F06", sMae)
        _oDatabase.CreateParam("F07", sAto)
        _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F10", Session("UserID"))
        _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F13", Session("UserID"))
        _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)

        _oDatabase.ExecuteNonQueryParam(sQuery)

    End Sub

#End Region

End Class 
