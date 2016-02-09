Imports System.Drawing
Imports System.Data
Imports System.Data.OracleClient

Partial Class master_mdmas190
    Inherits System.Web.UI.Page
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS190"
    Private Const PROGRAM_TITLE As String = "部品マスタ修正フラグ一括メンテナンス"

    Private _oDatabase As MedicalLib.DataAccess
    'CallBack 
    Public _sCallBackScript As String = ""
    Private _sCode As String = ""

    Private _iRowNo As Integer = 0

    '明細列番号
    Private Enum iCol
        NO = 0
        CATALOG = 1
        ZUMEN = 2
        UPDATOR = 3
        REASON = 4
        FLAG = 5
        UPDATOR_BK = 6
        REASON_BK = 7
        FLAG_BK = 8
    End Enum

#Region " ページ "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE

        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

        'CallBack 
        _sCallBackScript = Page.ClientScript.GetCallbackEventReference(Me, "command", "getInfoCallBack", "context", "getInfoCallBackError", False)

        If Not Page.IsPostBack Then
            '初期化
            DisplayInit()
        End If
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        Dim sReturnValue As String = ""
        Dim sValues() As String = _sCode.Split(Chr(9))
        Dim sQuery As String = ""

        Try
            Select Case sValues(0)
                Case "U"
                    '作業者名取得
                    sQuery += "SELECT WORKER_NM"
                    sQuery += "  FROM WORKER_MST"
                    sQuery += " WHERE WORKER_CD = :K01"
                    _oDatabase.CreateParam("K01", sValues(1))

                    Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)

                        If oReader.Read() Then
                            sReturnValue = GetString(oReader, 0).Trim
                        End If
                    End Using
                Case "R"
                    '修正理由取得
                    sQuery += "SELECT ITEM_NM"
                    sQuery += "  FROM GENERAL_PURPOSE_TBL"
                    sQuery += " WHERE INFO_KB = 'MS034'"
                    sQuery += "   AND TELL_CD = :K01"
                    _oDatabase.CreateParam("K01", sValues(1))

                    Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)

                        If oReader.Read() Then
                            sReturnValue = GetString(oReader, 0).Trim
                        End If
                    End Using
            End Select

        Catch ex As Exception
        End Try

        Return sReturnValue & vbTab & sValues(2)
    End Function

    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        _sCode = eventArgument
    End Sub

#End Region

#Region " ボタン "

    '検索
    Protected Sub imgSearch_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSearch.Click

        Try
            Page.Validate("input")
            If Page.IsValid = False Then
                ListShow(False)
                Exit Sub
            End If
            Page.Validate("key")
            If Page.IsValid = False Then
                ListShow(False)
                Exit Sub
            End If

            ViewState("CatalogFrom") = Me.txtCatalogFrom.Text.Trim
            ViewState("CatalogTo") = Me.txtCatalogTo.Text.Trim
            ViewState("Zumen") = Me.txtZumen.Text.Trim
            ViewState("DouZumen") = Me.chkDouZumen.Checked
            ViewState("UpOnly") = Me.chkUpOnly.Checked

            GridBind()              '明細表示
            ListInit()              '初期化
            ListShow(True)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try

    End Sub

    '訂正
    Protected Sub imgUpdate_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgUpdate.Click

        Try
            Page.Validate("update")
            If Page.IsValid = False Then Exit Sub

            UpdateList()
            ListShow(False)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '戻る
    Protected Sub imgBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgBack.Click
        ListShow(False)
    End Sub

    '一括訂正
    Protected Sub btnFullUpdate_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnFullUpdate.Click

        Try
            Page.Validate("full")
            If Page.IsValid = False Then Exit Sub

            UpdateFull()
            ListShow(False)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " グリッド "

    Protected Sub grdList_ItemCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList.ItemCreated

        Dim oLine As DataGridItem = e.Item

        Select Case oLine.ItemType

            Case ListItemType.Header

                '修正フラグヘッダ作成
                Dim oLit As New Literal
                oLit.Text = "修正フラグ"

                Dim oChk As New CheckBox
                oChk.ID = "chkAll"
                If ViewState("UpOnly") = True Then
                    oChk.Checked = True
                Else
                    oChk.Checked = False
                End If
                oChk.Attributes("onclick") = "javascript:SelectAllCheckboxes(this);"

                oLine.Cells(iCol.FLAG).Controls.Add(oLit)
                oLine.Cells(iCol.FLAG).Controls.Add(oChk)

                'ポジション指定
                oLine.Cells(iCol.NO).Style("position") = "relative"
                oLine.Cells(iCol.CATALOG).Style("position") = "relative"
                oLine.Cells(iCol.ZUMEN).Style("position") = "relative"
                oLine.Cells(iCol.UPDATOR).Style("position") = "relative"
                oLine.Cells(iCol.REASON).Style("position") = "relative"
                oLine.Cells(iCol.FLAG).Style("position") = "relative"

            Case ListItemType.Item, ListItemType.AlternatingItem

                '連番表示
                _iRowNo += 1
                oLine.Cells(iCol.NO).Text = _iRowNo.ToString

                CType(oLine.Cells(iCol.UPDATOR).Controls(3), Label).Style("display") = "inline-block"
                CType(oLine.Cells(iCol.REASON).Controls(3), Label).Style("display") = "inline-block"
        End Select
    End Sub

    Protected Sub grdList_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdList.ItemDataBound

        Dim oLine As DataGridItem = e.Item
        Select Case oLine.ItemType
            Case ListItemType.Item, ListItemType.AlternatingItem

                If CType(oLine.Cells(iCol.UPDATOR).Controls(3), Label).Text = "" Then
                    CType(oLine.Cells(iCol.UPDATOR).Controls(3), Label).Width = 0
                End If
                If CType(oLine.Cells(iCol.REASON).Controls(3), Label).Text = "" Then
                    CType(oLine.Cells(iCol.REASON).Controls(3), Label).Width = 0
                End If
        End Select
    End Sub

    Protected Sub grdList_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdList.SortCommand
        MedicalLib.Common.SortCommand(e)
        GridBind()
    End Sub

#End Region

#Region " チェック "

    'カタログ番号チェック
    Protected Sub valCatalog_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCatalog.ServerValidate

        Dim oVal As CustomValidator = DirectCast(source, CustomValidator)

        If Me.txtCatalogFrom.Text.Trim = "" And Me.txtCatalogTo.Text.Trim <> "" Then
            oVal.ErrorMessage = "カタログ番号(自)を入力してください"
            args.IsValid = False
            Exit Sub
        End If

        If Me.txtCatalogFrom.Text.Trim <> "" Then
            If Not HasPartsMST(Me.txtCatalogFrom.Text.Trim) Then
                oVal.ErrorMessage = "カタログ番号(自)が部品マスタに存在しません"
                args.IsValid = False
                Exit Sub
            End If
        End If

        If Me.txtCatalogTo.Text.Trim <> "" Then
            If Not HasPartsMST(Me.txtCatalogTo.Text.Trim) Then
                oVal.ErrorMessage = "カタログ番号(至)が部品マスタに存在しません"
                args.IsValid = False
                Exit Sub
            End If
        End If

        If Me.txtCatalogTo.Text <> "" And _
           Me.txtCatalogFrom.Text > Me.txtCatalogTo.Text Then
            oVal.ErrorMessage = "カタログ番号(自)≦カタログ番号(至)で入力して下さい"
            args.IsValid = False
        End If
    End Sub

    Private Function HasPartsMST(ByVal sCatalog As String) As Boolean
        Dim sQuery As String = ""
        sQuery += "SELECT CATALOG_NO"
        sQuery += "  FROM PARTS_MST"
        sQuery += " WHERE CATALOG_NO = :K01"
        _oDatabase.CreateParam("K01", sCatalog)
        Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            Return oReader.HasRows
        End Using
    End Function

    '入力チェック
    Protected Sub valInput_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valInput.ServerValidate
        If Me.txtCatalogFrom.Text.Trim = "" And _
           Me.txtCatalogTo.Text.Trim = "" And _
           Me.txtZumen.Text.Trim = "" Then

            args.IsValid = False
        End If
    End Sub

    '訂正チェック
    Protected Sub valUpdate_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valUpdate.ServerValidate

        Dim oVal As CustomValidator = DirectCast(source, CustomValidator)
        Dim oUpdatorTXT As TextBox = Nothing
        Dim oReasonTXT As TextBox = Nothing

        Dim sQueryUp As String = ""
        sQueryUp = "SELECT WORKER_CD FROM WORKER_MST WHERE WORKER_CD = :K01"

        Dim sQueryRe As String = ""
        sQueryRe = "SELECT TELL_CD FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS034' AND TELL_CD = :K01"

        Dim i As Integer = 0

        For i = 0 To Me.grdList.Items.Count - 1

            '修正フラグがチェックありだったら
            If CType(Me.grdList.Items(i).Cells(iCol.FLAG).Controls(1), CheckBox).Checked = True Then

                oUpdatorTXT = DirectCast(Me.grdList.Items(i).Cells(iCol.UPDATOR).Controls(1), TextBox)
                oReasonTXT = DirectCast(Me.grdList.Items(i).Cells(iCol.REASON).Controls(1), TextBox)

                '入力チェック
                If oUpdatorTXT.Text.Trim = "" Then
                    oVal.ErrorMessage = "修正者の入力がありません[" & i + 1 & "行目]"
                    args.IsValid = False
                    Exit For
                End If

                '存在チェック
                _oDatabase.CreateParam("K01", oUpdatorTXT.Text.Trim)
                Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQueryUp)
                    If Not oReader.HasRows Then
                        oVal.ErrorMessage = "修正者が作業者マスタに存在しません[" & i + 1 & "行目]"
                        args.IsValid = False
                        Exit For
                    End If
                End Using

                '入力チェック
                If oReasonTXT.Text = "" Then
                    oVal.ErrorMessage = "修正理由の入力がありません[" & i + 1 & "行目]"
                    args.IsValid = False
                    Exit For
                End If

                '存在チェック
                _oDatabase.CreateParam("K01", oReasonTXT.Text.Trim)
                Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQueryRe)
                    If Not oReader.HasRows Then
                        oVal.ErrorMessage = "修正理由が汎用マスタに存在しません[" & i + 1 & "行目]"
                        args.IsValid = False
                        Exit For
                    End If
                End Using
            End If
        Next
    End Sub

    '一括入力修正者チェック
    Protected Sub valUpdator_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valUpdator.ServerValidate

        Dim oVal As CustomValidator = DirectCast(source, CustomValidator)

        If Me.chkFullFlag.Checked = True Then

            '入力チェック
            If Me.txtFullUpdator.Text.Trim = "" Then
                oVal.ErrorMessage = "修正者を入力してください"
                args.IsValid = False
                Exit Sub
            End If

            Dim sQuery As String = ""

            sQuery += "SELECT WORKER_NM"
            sQuery += "  FROM WORKER_MST"
            sQuery += " WHERE WORKER_CD = :K01"

            _oDatabase.CreateParam("K01", Me.txtFullUpdator.Text.Trim)
            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                If oReader.Read Then
                    Me.lblFullUpdatorNM.Text = GetString(oReader, 0).Trim
                Else
                    Me.lblFullUpdatorNM.Text = ""
                    oVal.ErrorMessage = "修正者が作業者マスタに存在しません"
                    args.IsValid = False
                    Exit Sub
                End If
            End Using
        Else

            'チェックなし
            If Me.txtFullUpdator.Text <> "" Then
                oVal.ErrorMessage = "修正フラグチェックなし時は修正者の入力はできません"
                args.IsValid = False
                Exit Sub
            End If
        End If
    End Sub

    '一括入力修正理由チェック
    Protected Sub valFullReason_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valFullReason.ServerValidate
        Dim oVal As CustomValidator = DirectCast(source, CustomValidator)

        If Me.chkFullFlag.Checked = True Then

            If Me.ddlFullReason.SelectedValue = "" Then
                oVal.ErrorMessage = "修正理由を選択して下さい"
                args.IsValid = False
                Exit Sub
            End If
        Else

            'チェックなし
            If Me.ddlFullReason.SelectedValue <> "" Then

                oVal.ErrorMessage = "修正フラグチェックなし時は修正理由を選択してないで下さい"
                args.IsValid = False
                Exit Sub
            End If
        End If
    End Sub

#End Region

#Region " ユーザー関数 "

    Private Sub GridBind()

        '行番号初期化
        _iRowNo = 0

        Dim sQuery As String = ""
        Dim sQueryT1 As String = ""
        Dim sWhere As String = ""
        Dim sTable As String = "T"

        Try
            'カタログ番号
            If ViewState("CatalogFrom") <> "" And ViewState("CatalogTo") <> "" Then
                sWhere += " WHERE P.CATALOG_NO BETWEEN :K01 AND :K02"
                _oDatabase.CreateParam("K01", ViewState("CatalogFrom"))
                _oDatabase.CreateParam("K02", ViewState("CatalogTo"))
            ElseIf ViewState("CatalogFrom") <> "" And ViewState("CatalogTo") = "" Then
                sWhere += " WHERE P.CATALOG_NO = :K01"
                _oDatabase.CreateParam("K01", ViewState("CatalogFrom"))
            End If

            '図面管理番号
            If ViewState("Zumen") <> "" Then
                If sWhere = "" Then
                    sWhere += " WHERE P.WORK_STD_NO LIKE :K03"
                Else
                    sWhere += "   AND P.WORK_STD_NO LIKE :K03"
                End If
                _oDatabase.CreateParam("K03", ViewState("Zumen") & "%")
            End If

            '修正中のみ
            If ViewState("UpOnly") = True Then
                sWhere += "   AND P.UPD_KB = '1'"
            End If

            sQueryT1 += "SELECT P.CATALOG_NO"
            sQueryT1 += "     , P.WORK_STD_NO"
            sQueryT1 += "     , P.UPD_KB"
            sQueryT1 += "  FROM PARTS_MST P"

            If ViewState("DouZumen") = False Then
                sQueryT1 += sWhere
            Else
                '同一図面
                sWhere = sWhere.Replace("P.", "B.")

                sQueryT1 += " WHERE EXISTS"
                sQueryT1 += "  (SELECT *"
                sQueryT1 += "     FROM PARTS_MST B"
                sQueryT1 += sWhere
                sQueryT1 += "      AND B.WORK_STD_NO = P.WORK_STD_NO"
                sQueryT1 += "  )"

                If ViewState("UpOnly") = True Then
                    sQueryT1 += "   AND P.UPD_KB = '1'"
                End If
            End If

            sQuery += "SELECT T1.CATALOG_NO, T1.WORK_STD_NO, T1.UPD_KB"
            sQuery += "     , CASE WHEN T1.UPD_KB = '1' THEN T2.UPDATE_REASON ELSE '' END AS UPDATE_REASON"
            sQuery += "     , CASE WHEN T1.UPD_KB = '1' THEN G34.ITEM_NM ELSE '' END AS ITEM_NM"
            sQuery += "     , CASE WHEN T1.UPD_KB = '1' THEN T2.UPDATOR ELSE '' END AS UPDATOR"
            sQuery += "     , CASE WHEN T1.UPD_KB = '1' THEN W.WORKER_NM ELSE '' END AS WORKER_NM"
            sQuery += "  FROM ("
            sQuery += "       " & sQueryT1
            sQuery += "       ) T1"
            sQuery += "     , (SELECT P.CATALOG_NO, P.UPD_DATETIME, P.UPDATE_REASON, P.UPDATOR"
            sQuery += "          FROM PARTS_UPDATE_REASON_TBL P"
            sQuery += "             , (SELECT CATALOG_NO AS MAX_CATA, MAX(UPD_DATETIME) AS MAX_DT"
            sQuery += "                  FROM PARTS_UPDATE_REASON_TBL"
            sQuery += "                 GROUP BY CATALOG_NO"
            sQuery += "               ) T"
            sQuery += "         WHERE P.CATALOG_NO = T.MAX_CATA"
            sQuery += "           AND P.UPD_DATETIME = T.MAX_DT"
            sQuery += "       ) T2"
            sQuery += "     , WORKER_MST W"
            sQuery += "     , (SELECT TELL_CD, ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS034') G34"
            sQuery += " WHERE T1.CATALOG_NO = T2.CATALOG_NO(+)"
            sQuery += "   AND T2.UPDATOR = W.WORKER_CD(+)"
            sQuery += "   AND T2.UPDATE_REASON = G34.TELL_CD(+)"

            Using oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, sTable)

                Using oDataView As DataView = oDataSet.Tables(sTable).DefaultView

                    oDataView.Sort = MedicalLib.Common.Sort

                    Me.grdList.DataSource = oDataView
                    Me.grdList.DataBind()
                End Using
            End Using

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    'ドロップダウンリストセット
    Private Sub SetUpdateReason()

        Dim sQuery As String = ""
        sQuery += "SELECT TELL_CD, ITEM_NM"
        sQuery += "  FROM GENERAL_PURPOSE_TBL"
        sQuery += " WHERE INFO_KB = :K01"
        sQuery += " ORDER BY TELL_CD"

        sQuery = sQuery
        _oDatabase.CreateParam("K01", "MS034")
        Using oDataReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            Me.ddlFullReason.Items.Add(New ListItem("", ""))
            Do While oDataReader.Read
                Me.ddlFullReason.Items.Add(New ListItem(oDataReader.Item("TELL_CD") + "：" + oDataReader.Item("ITEM_NM"), oDataReader.Item("TELL_CD")))
            Loop
        End Using
    End Sub

    '画面初期化
    Private Sub DisplayInit()
        Me.txtCatalogFrom.Text = ""
        Me.txtCatalogTo.Text = ""
        Me.txtZumen.Text = ""
        Me.chkDouZumen.Checked = False
        Me.chkUpOnly.Checked = False

        SetUpdateReason()       '修正理由セット
        Me.imgUpdate.Attributes.Add("onclick", MedicalLib.Script.Update())
        Me.imgUpdate.Visible = MedicalLib.Common.EnableUpdate
        Me.btnFullUpdate.Attributes.Add("onclick", MedicalLib.Script.Update())
        Me.btnFullUpdate.Visible = MedicalLib.Common.EnableUpdate
        MedicalLib.Common.Sort = "CATALOG_NO, WORK_STD_NO"
    End Sub

    '詳細以下表示？
    Private Sub ListShow(ByVal IsShow As Boolean)
        Me.pnlList.Visible = IsShow
        Me.udpList.Update()
        Me.pnlBottom.Visible = IsShow
        Me.udpBottom.Update()
    End Sub

    '詳細以下初期化
    Private Sub ListInit()
        Me.txtFullUpdator.Text = ""
        Me.lblFullUpdatorNM.Text = ""
        Me.ddlFullReason.Text = ""
        Me.chkFullFlag.Checked = False
        If Me.grdList.Items.Count < 2 Then
            Me.pnlFull.Visible = False
        Else
            Me.pnlFull.Visible = True
        End If
        If ViewState("UpOnly") = True Then
            Me.chkFullFlag.Checked = True
        Else
            Me.chkFullFlag.Checked = False
        End If
    End Sub
#End Region

#Region " データ更新 "

    Private Sub UpdateList()

        Dim sQueryParts As String = ""
        Dim sQueryReason As String = ""

        _oDatabase.BeginTrans()

        Try
            '部品マスタ更新SQL
            sQueryParts += "UPDATE PARTS_MST SET"
            sQueryParts += "   UPD_KB = :F01"
            sQueryParts += " , UPD_DT = :F02"
            sQueryParts += " , UPD_TIME = :F03"
            sQueryParts += " , UPD_USR = :F04"
            sQueryParts += " , UPD_PROGRAM_ID = :F05"
            sQueryParts += " WHERE CATALOG_NO = :K01"

            '部品マスタ修正理由テーブル挿入SQL
            sQueryReason += "INSERT INTO PARTS_UPDATE_REASON_TBL"
            sQueryReason += " (CATALOG_NO, UPD_DATETIME, UPDATE_REASON, UPDATOR"
            sQueryReason += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
            sQueryReason += " ) VALUES ("
            sQueryReason += "  :F01, :F02, :F03, :F04"
            sQueryReason += ", :F05, :F06, :F07, :F08, :F09, :F10, :F11"
            sQueryReason += " )"

            For i As Integer = 0 To Me.grdList.Items.Count - 1

                'チェックボックスに変更があったら
                If CType(Me.grdList.Items(i).Cells(iCol.FLAG).Controls(1), CheckBox).Checked _
                 = Me.grdList.Items(i).Cells(iCol.FLAG_BK).Text.Trim.Equals("0") Then

                    '部品マスタ更新
                    If CType(Me.grdList.Items(i).Cells(iCol.FLAG).Controls(1), CheckBox).Checked Then
                        _oDatabase.CreateParam("F01", "1")
                    Else
                        _oDatabase.CreateParam("F01", "0")
                    End If
                    _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F04", Session("UserID"))
                    _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                    _oDatabase.CreateParam("K01", Me.grdList.Items(i).Cells(iCol.CATALOG).Text.Trim)

                    _oDatabase.ExecuteNonQueryParam(sQueryParts)
                End If

                '修正フラグチェック時 修正者及び修正理由が変更された時
                If CType(Me.grdList.Items(i).Cells(iCol.FLAG).Controls(1), CheckBox).Checked And _
                  ((CType(Me.grdList.Items(i).Cells(iCol.UPDATOR).Controls(1), TextBox).Text.Trim <> Me.grdList.Items(i).Cells(iCol.UPDATOR_BK).Text.Trim) Or _
                   (CType(Me.grdList.Items(i).Cells(iCol.REASON).Controls(1), TextBox).Text.Trim <> Me.grdList.Items(i).Cells(iCol.REASON_BK).Text.Trim)) Then

                    '部品マスタ修正理由テーブル挿入
                    _oDatabase.CreateParam("F01", Me.grdList.Items(i).Cells(iCol.CATALOG).Text.Trim)
                    _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate & MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F03", CType(Me.grdList.Items(i).Cells(iCol.REASON).Controls(1), TextBox).Text.Trim)
                    _oDatabase.CreateParam("F04", CType(Me.grdList.Items(i).Cells(iCol.UPDATOR).Controls(1), TextBox).Text.Trim)
                    _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F07", Session("UserID"))
                    _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F10", Session("UserID"))
                    _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)

                    _oDatabase.ExecuteNonQueryParam(sQueryReason)
                End If
            Next

            _oDatabase.CommitTrans()

        Catch ex As Exception
            _oDatabase.Rollback()
            Throw
        End Try
    End Sub

    '一括訂正
    Private Sub UpdateFull()

        Dim sQuery As String = ""
        Dim sCatalogIn As String = ""

        _oDatabase.BeginTrans()

        Try
            '部品マスタ修正理由テーブル挿入SQL
            sQuery += "INSERT INTO PARTS_UPDATE_REASON_TBL"
            sQuery += " (CATALOG_NO, UPD_DATETIME, UPDATE_REASON, UPDATOR"
            sQuery += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
            sQuery += " ) VALUES ("
            sQuery += "  :F01, :F02, :F03, :F04"
            sQuery += ", :F05, :F06, :F07, :F08, :F09, :F10, :F11"
            sQuery += " )"

            For i As Integer = 0 To Me.grdList.Items.Count - 1

                'カタログ番号取得
                sCatalogIn += "'" & Me.grdList.Items(i).Cells(iCol.CATALOG).Text.Trim & "',"

                '修正フラグチェック時 部品マスタ修正理由テーブル挿入
                If Me.chkFullFlag.Checked = True Then

                    _oDatabase.CreateParam("F01", Me.grdList.Items(i).Cells(iCol.CATALOG).Text.Trim)
                    _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate & MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F03", Me.ddlFullReason.SelectedValue.Trim)
                    _oDatabase.CreateParam("F04", Me.txtFullUpdator.Text.Trim)
                    _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F07", Session("UserID"))
                    _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F10", Session("UserID"))
                    _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)

                    _oDatabase.ExecuteNonQueryParam(sQuery)
                End If
            Next

            '部品マスタ更新
            sQuery = ""
            sQuery += "UPDATE PARTS_MST SET"
            sQuery += "   UPD_KB = :F01"
            sQuery += " , UPD_DT = :F02"
            sQuery += " , UPD_TIME = :F03"
            sQuery += " , UPD_USR = :F04"
            sQuery += " , UPD_PROGRAM_ID = :F05"
            sQuery += " WHERE CATALOG_NO IN (" & sCatalogIn.Substring(0, sCatalogIn.Length - 1) & ")"

            If Me.chkFullFlag.Checked Then
                _oDatabase.CreateParam("F01", "1")
            Else
                _oDatabase.CreateParam("F01", "0")
            End If
            _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F04", Session("UserID"))
            _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)

            _oDatabase.ExecuteNonQueryParam(sQuery)

            _oDatabase.CommitTrans()

        Catch ex As Exception
            _oDatabase.Rollback()
            Throw
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

#End Region

End Class
