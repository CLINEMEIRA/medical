Imports System.Drawing
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdmas200
    Inherits System.Web.UI.Page
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS200"
    Private Const PROGRAM_TITLE As String = "源製品構成マスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess
    'CallBack 
    Public _sCallBackScript As String = ""
    Private _sCode As String = ""

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE

        Try
            _oDatabase = New MedicalLib.DataAccess
            'CallBack 
            _sCallBackScript = Page.ClientScript.GetCallbackEventReference( _
                         Me, "command", "getKeyCallBack", "context", "getKeyCallBackError", False)

            If Not Page.IsPostBack Then
                DisplayInit()
                Me.scriptManager.SetFocus(Me.txtBuhin)
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

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult

        Dim sReturnValue As String = ""
        If _sCode = "" Then Return sReturnValue

        Dim sQuery As String = ""
        sQuery += "SELECT COMPANY_NO"
        sQuery += "  FROM PARTS_MST"
        sQuery += " WHERE CATALOG_NO = :K01 "
        _oDatabase.CreateParam("K01", _sCode.Trim)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                sReturnValue = GetString(oReader, 0).Trim
            End If
        End Using

        Return sReturnValue
    End Function

    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        _sCode = eventArgument
    End Sub

#End Region

#Region " ボタン "

    '検索
    Protected Sub imgSearch_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSearch.Click
        Try
            Page.Validate("buhin")
            If Page.IsValid Then
                GridBind()
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '隠しボタン(行選択)
    Protected Sub btnSelect_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            DisplayBottom(False)

            For Each row As DataGridItem In Me.grdList.Items
                If row.Cells(0).Text.Trim = Me.saveSeihin.Value Then
                    Me.txtGen.Text = row.Cells(0).Text.Trim
                    Me.txtJunni.Text = row.Cells(1).Text.Trim
                    Me.scriptManager.SetFocus(Me.txtJunni)
                    Me.udpBottom.Update()
                    Exit For
                End If
            Next

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '新規
    Protected Sub imgNew_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgNew.Click
        Try
            Me.txtGen.Text = ""
            Me.txtJunni.Text = ""
            Me.pnlBottom.Visible = True
            DisplayBottom(True)
            Me.scriptManager.SetFocus(Me.txtGen)
            Me.udpBottom.Update()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '登録
    Protected Sub imgInsert_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgInsert.Click
        Try
            DisplayBottom(True)
            Page.Validate("bottom")
            If Page.IsValid Then
                InsertConsist()
                GridBind()
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '訂正
    Protected Sub imgUpdate_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgUpdate.Click
        Try
            DisplayBottom(False)
            Page.Validate("bottom")
            If Page.IsValid Then
                UpdateConsist()
                GridBind()
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '削除
    Protected Sub imgDelete_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgDelete.Click
        Try
            DisplayBottom(False)
            Page.Validate("bottom")
            If Page.IsValid Then
                DeleteConsist()
                GridBind()
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " グリッド "

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
            oLine.Attributes("onclick") = "selectGridRow(this,'" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "')"
        End If
    End Sub

#End Region

#Region " チェック関数 "

    '部品
    Protected Sub valBuhin_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valBuhin.ServerValidate
        Try
            Dim oVal As CustomValidator = DirectCast(source, CustomValidator)
            Dim sQuery As String = ""

            '必須チェック
            If Me.txtBuhin.Text.Trim = "" Then
                oVal.ErrorMessage = "必須入力項目です"
                args.IsValid = False
                Exit Sub
            End If

            '部品マスタチェック
            sQuery = ""
            sQuery += "SELECT COMPANY_NO"
            sQuery += "  FROM PARTS_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", Me.txtBuhin.Text.Trim)

            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)

                If oReader.Read() Then
                    Me.lblOya.Text = GetString(oReader, 0).Trim
                Else
                    Me.lblOya.Text = ""
                    oVal.ErrorMessage = "部品マスタに登録されていません"
                    args.IsValid = False
                    Exit Sub
                End If
            End Using

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '源製品
    Protected Sub valGen_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valGen.ServerValidate
        Try
            If Me.txtGen.ReadOnly = True Then
                Exit Sub
            End If

            Dim oVal As CustomValidator = DirectCast(source, CustomValidator)
            Dim sQuery As String = ""

            '必須チェック
            If Me.txtGen.Text.Trim = "" Then
                oVal.ErrorMessage = "必須入力項目です"
                args.IsValid = False
                Exit Sub
            End If

            '親と同一チェック
            If ViewState("buhin") = Me.txtGen.Text.Trim Then
                oVal.ErrorMessage = "部品番号と同じ番号は入力できません"
                args.IsValid = False
                Exit Sub
            End If

            '部品マスタチェック
            sQuery = ""
            sQuery += "SELECT C_NO"
            sQuery += "  FROM PARTS_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", Me.txtGen.Text.Trim)
            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read Then

                    If GetString(oReader, 0).Trim <> "Z9" Then
                        oVal.ErrorMessage = "源製品以外は入力できません"
                        args.IsValid = False
                        Exit Sub
                    End If
                Else
                    oVal.ErrorMessage = "部品マスタに登録されていません"
                    args.IsValid = False
                    Exit Sub
                End If
            End Using

            '登録済チェック
            sQuery = ""
            sQuery += "SELECT PARTS_NO"
            sQuery += "  FROM O_PARTS_CONSIST_MST"
            sQuery += " WHERE PARTS_NO = :K01"
            sQuery += "   AND O_PARTS_NO = :K02"
            _oDatabase.CreateParam("K01", ViewState("buhin"))
            _oDatabase.CreateParam("K02", Me.txtGen.Text.Trim)
            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.HasRows Then
                    oVal.ErrorMessage = "既に登録されています"
                    args.IsValid = False
                    Exit Sub
                End If
            End Using

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '優先順位
    Protected Sub valJunni_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valJunni.ServerValidate
        Try
            Dim oVal As CustomValidator = DirectCast(source, CustomValidator)

            '必須チェック
            If Me.txtJunni.Text.Trim = "" Then
                oVal.ErrorMessage = "必須入力項目です"
                args.IsValid = False
                Exit Sub
            End If

            '数値入力チェック
            If Not Regex.IsMatch(Me.txtJunni.Text.Trim, "^[0-9]*$") Then
                oVal.ErrorMessage = "数値で入力してください"
                args.IsValid = False
                Exit Sub
            End If

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " ユーザ関数 "

    Private Sub GridBind()

        ViewState("buhin") = Me.txtBuhin.Text.Trim

        Dim sTable As String = "T"
        Dim sQuery As String = ""

        sQuery += "SELECT O_PARTS_NO, PRIORITY"
        sQuery += "  FROM O_PARTS_CONSIST_MST"
        sQuery += " WHERE PARTS_NO = :K01"
        sQuery += " ORDER BY PRIORITY, O_PARTS_NO"
        _oDatabase.CreateParam("K01", ViewState("buhin"))

        Using oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, sTable)

            Me.grdList.DataSource = oDataSet
            Me.grdList.DataBind()
        End Using

        Me.pnlList.Visible = True
        Me.udpList.Update()

        Me.pnlBottom.Visible = False
        Me.udpBottom.Update()

    End Sub

    '画面初期化
    Private Sub DisplayInit()
        Me.txtBuhin.Text = ""
        Me.lblOya.Text = ""
        Me.pnlList.Visible = False
        Me.udpList.Update()
        Me.saveSeihin.Value = ""
        Me.txtGen.Text = ""
        Me.txtJunni.Text = ""
        Me.pnlBottom.Visible = False
        Me.udpBottom.Update()
    End Sub

    Private Sub DisplayBottom(ByVal IsInsert As Boolean)

        If IsInsert = True Then
            Me.pnlGenLink.Visible = True
            Me.pnlGen.Visible = False
            Me.txtGen.ReadOnly = False
            Me.txtGen.BackColor = Color.FromArgb(255, 255, 192)    '黄色 
            Me.imgInsert.Visible = True
            imgInsert.Visible = MedicalLib.Common.EnableInsert
            Me.imgUpdate.Visible = False
            Me.imgDelete.Visible = False
        Else
            Me.pnlGenLink.Visible = False
            Me.pnlGen.Visible = True
            Me.txtGen.ReadOnly = True
            Me.txtGen.BackColor = Color.FromArgb(224, 224, 224)   '灰色 
            Me.imgInsert.Visible = False
            Me.imgUpdate.Visible = True
            imgUpdate.Visible = MedicalLib.Common.EnableUpdate
            Me.imgDelete.Visible = True
            imgDelete.Visible = MedicalLib.Common.EnableDelete
        End If
        Me.pnlBottom.Visible = True
        Me.udpBottom.Update()
    End Sub

#End Region

#Region " ファイル関数 "

    '登録
    Private Sub InsertConsist()

        Dim sQuery As String = ""

        sQuery += "INSERT INTO O_PARTS_CONSIST_MST"
        sQuery += "( PARTS_NO, O_PARTS_NO, PRIORITY"
        sQuery += ", CRT_DT, CRT_TIME, CRT_USR"
        sQuery += ", UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
        sQuery += ") VALUES ("
        sQuery += "  :F01, :F02, :F03"
        sQuery += ", :F04, :F05, :F06"
        sQuery += ", :F07, :F08, :F09, :F10"
        sQuery += ")"

        _oDatabase.CreateParam("F01", ViewState("buhin"))
        _oDatabase.CreateParam("F02", Me.txtGen.Text.Trim)
        _oDatabase.CreateParam("F03", Me.txtJunni.Text.Trim)
        _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F06", Session("UserID"))
        _oDatabase.CreateParam("F07", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F09", Session("UserID"))
        _oDatabase.CreateParam("F10", MedicalLib.Common.ProgramID)

        _oDatabase.ExecuteNonQueryParam(sQuery)
    End Sub

    '訂正
    Private Sub UpdateConsist()

        Dim sQuery As String = ""

        sQuery += "UPDATE O_PARTS_CONSIST_MST"
        sQuery += "   SET PRIORITY = :F01"
        sQuery += "     , UPD_DT = :F02"
        sQuery += "     , UPD_TIME = :F03"
        sQuery += "     , UPD_USR = :F04"
        sQuery += "     , UPD_PROGRAM_ID = :F05"
        sQuery += " WHERE PARTS_NO = :K01"
        sQuery += "   AND O_PARTS_NO = :K02"

        _oDatabase.CreateParam("F01", Me.txtJunni.Text.Trim)
        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
        _oDatabase.CreateParam("F04", Session("UserID"))
        _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
        _oDatabase.CreateParam("K01", ViewState("buhin"))
        _oDatabase.CreateParam("K02", Me.txtGen.Text.Trim)

        _oDatabase.ExecuteNonQueryParam(sQuery)
    End Sub

    '削除
    Private Sub DeleteConsist()

        Dim sQuery As String = ""

        sQuery += "DELETE FROM O_PARTS_CONSIST_MST"
        sQuery += " WHERE PARTS_NO = :K01"
        sQuery += "   AND O_PARTS_NO = :K02"

        _oDatabase.CreateParam("K01", ViewState("buhin"))
        _oDatabase.CreateParam("K02", Me.txtGen.Text.Trim)

        _oDatabase.ExecuteNonQueryParam(sQuery)
    End Sub

#End Region

#Region " その他 "

    Private Function GetString(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As String
        If oReader.IsDBNull(nIndex) Then Return ""
        Return oReader.GetString(nIndex).Trim()
    End Function

#End Region

End Class
