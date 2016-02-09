Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient
Imports System.Text 
 
Partial Class master_mdmas150 
    Inherits System.Web.UI.Page 
    Implements System.Web.UI.ICallbackEventHandler

    Private Const PROGRAM_ID As String = "MDMAS150" 
    Private Const PROGRAM_TITLE As String = "加工工程マスタメンテナンス" 
 
    Private _oDatabase As MedicalLib.DataAccess
    Private Const TABLE_NAME As String = "P_PROCESS_MST"
    Private Const TABLE_NAME_JP As String = "加工工程マスタ"
 
    Private Const CALL_SINGLE As String = "single" 
    Private Const CALL_SYNCHRO As String = "synchro"

    Public _sCallBackScript As String = ""
    Private _sGetValue As String = ""

#Region " イベント "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            _sCallBackScript = Page.ClientScript.GetCallbackEventReference(Me, "command", "getCallBack", "context", "getCallBackError", False)
            If Not Page.IsPostBack Then
                btnSort.Visible = False
                btnDel.Visible = False
                btnTekiyou.Visible = False
                If Request.QueryString("call") Is Nothing Then
                    ViewState("call") = CALL_SINGLE
                    txtCatalog.Text = ""
                    txtCopyCatalog.Text = ""
                    tblSelect.Rows(1).Visible = False
                    btnInsert.Visible = False
                    btnBack.Visible = False
                    txtCatalog.Focus()
                Else
                    ViewState("call") = Request.QueryString("call")
                    ViewState("catalog") = Request.QueryString("catalog")
                    txtCatalog.Text = ViewState("catalog")
                    txtCatalog.Enabled = Request.QueryString("call").Equals(CALL_SINGLE)
                    lnkCatalog.Visible = Request.QueryString("call").Equals(CALL_SINGLE)
                    If Not lnkCatalog.Visible Then tblSelect.Rows(0).Cells(0).InnerHtml = "<font color='#f7f7f7'><b>カタログ番号</b></font>"
                    DisplayShow(txtCatalog.Text.Trim())
                    Dim sQuery As String = "SELECT CATALOG_NO FROM P_PROCESS_MST WHERE CATALOG_NO = :K01"
                    _oDatabase.CreateParam("K01", txtCatalog.Text.Trim())
                    Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                    If oReader.HasRows Then
                        DisplayList(ViewState("catalog"))
                    Else
                        txtCopyCatalog.Text = Request.QueryString("copycatalog")
                        txtCopyCatalog.Focus()
                    End If
                    oReader.Close()
                    btnSearch.Visible = ViewState("call").Equals(CALL_SINGLE)
                    btnBack.Visible = ViewState("call").Equals(CALL_SYNCHRO)
                End If
                btnInsert.Attributes("onclick") = "selectGridRow('" + ViewState("call") + "','" + ViewState("catalog") + "','','');return false;"
                btnCopy.Attributes.Add("onclick", MedicalLib.Script.Custome("複写してもよろしいですか"))
                btnSort.Attributes.Add("onclick", MedicalLib.Script.Custome("並べ替えしてもよろしいですか"))
                btnDel.Attributes.Add("onclick", MedicalLib.Script.Custome("一括削除してもよろしいですか"))
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
            oLine.Attributes("onclick") = "selectGridRow('" + HttpUtility.UrlEncode(ViewState("call")) + "','" + HttpUtility.UrlEncode(ViewState("catalog")) + "','" & HttpUtility.UrlEncode(oLine.Cells(1).Text) + "','" + HttpUtility.UrlEncode(oLine.Cells(2).Text) + "')"
        End If
    End Sub

    '複写ボタン押下 
    Protected Sub btnCopy_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCopy.Click
        If ViewState("call").Equals(CALL_SINGLE) Then
            Page.Validate("key")
            If valCatalog2.IsValid Then Page.Validate("copykey")
        End If
        Page.Validate("copy")
        If Page.IsValid Then
            If Not FileCopy() Then Return
            DisplayList(ViewState("catalog"))
        End If
    End Sub

    '検索ボタン押下 
    Protected Sub btnSearch_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        btnInsert.Visible = False
        Page.Validate("key")
        If Page.IsValid Then
            DisplayShow(txtCatalog.Text.Trim())
            DisplayList(txtCatalog.Text.Trim())
        End If
    End Sub

    '戻るボタン押下 
    Protected Sub btnBack_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnBack.Click
        Response.Redirect("mdmas040.aspx?catalog=" + ViewState("catalog"), False)
    End Sub

    '並べ替えボタン押下 
    Protected Sub btnSort_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSort.Click
        If Not FileSort() Then Return
        DisplayList(ViewState("catalog"))
    End Sub

    '一括削除ボタン押下
    Protected Sub btnDel_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnDel.Click
        If Not FileDelete() Then Return
        DisplayList(ViewState("catalog"))
    End Sub

    '着工中摘要
    Protected Sub btnTekiyou_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnTekiyou.Click
        Response.Redirect("mdmas152.aspx?call=" & ViewState("call") & "&catalog=" + ViewState("catalog"), False)
    End Sub

#End Region

#Region " コールバック "

    Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
        Dim sReturnValue As String = ""
        Dim sQuery As String = "SELECT C_NO FROM PARTS_MST WHERE CATALOG_NO = :K01"
        _oDatabase.CreateParam("K01", _sGetValue.Trim())
        Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
        If oReader.Read() Then
            sReturnValue = oReader.GetString(0).Trim()
        Else
            sReturnValue = ""
        End If
        oReader.Close()
        Return sReturnValue
    End Function

    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
        _sGetValue = eventArgument
    End Sub

#End Region
 
#Region " 画面関連 "

    Private Sub DisplayShow(ByVal sCatalog As String)
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT C_NO FROM PARTS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", sCatalog)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            If oReader.Read() Then
                lblKumi.Text = GetString(oReader, 0)
            Else
                lblKumi.Text = ""
            End If
            oReader.Close()
            ViewState("catalog") = txtCatalog.Text.Trim()
            ViewState("kumi") = lblKumi.Text.Trim()

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

    Private Sub DisplayList(ByVal sCatalog As String)
        Try
            'tblHeader.visible = False
            Dim sQuery As String = "SELECT A.UM_P_ORDER COR_MARK,A.P_ORDER_MAIN,A.P_ORDER_SUB,A.PROCESS_CD || '<br/>' || B.P_ORDER_NM PROCESS,A.PER_PROCESS_CD || '<br/>' || E.P_ORDER_NM PER_PROCESS,A.SHOP || '<br/>' || C.SHOP_NM SHOP,B.FACILITIES_G_CD || '<br/>' || D.ITEM_NM 設備,B.WORK_STD,A.P_COMMENT,A.CYCLE_TIME,A.TACT_TIME,A.PUT_TOGETHER_FLG,A.PLAN_TARGET_FLG " + _
                                   "FROM P_PROCESS_MST A,PROCESS_MST B,SHOP_MST C,(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025') D,PROCESS_MST E " + _
                                   "WHERE A.PROCESS_CD = B.PROCESS_CD(+) AND A.PER_PROCESS_CD = E.PROCESS_CD(+) AND A.SHOP = C.SHOP(+) AND B.FACILITIES_G_CD = D.TELL_CD(+) AND A.CATALOG_NO = :K01 ORDER BY A.P_ORDER_MAIN,A.P_ORDER_SUB"
            _oDatabase.CreateParam("K01", sCatalog)
            Dim oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
            Dim oDataView As DataView = oDataSet.Tables("TB1").DefaultView
            grdList.DataSource = oDataView
            grdList.DataBind()
            tblSelect.Rows(1).Visible = oDataView.Count = 0 And MedicalLib.Common.EnableInsert
            btnSort.Visible = oDataView.Count <> 0 And MedicalLib.Common.EnableUpdate

            '**** 2010/08 一括削除ボタン条件変更 ST ****
            btnDel.Visible = oDataView.Count <> 0 And MedicalLib.Common.EnableDelete
            'btnDel.Visible = oDataView.Count <> 0 And ViewState("kumi").Equals("W2") And MedicalLib.Common.EnableDelete
            '**** 2010/08 一括削除ボタン条件変更 ED ****
            btnInsert.Visible = MedicalLib.Common.EnableInsert
            btnInsert.Attributes("onclick") = "selectGridRow('" + ViewState("call") + "','" + ViewState("catalog") + "','','');return false;"

            '**** 2010/08 着工適用ボタン追加 ST **** 
            btnTekiyou.Visible = (oDataView.Count <> 0 And MedicalLib.Common.EnableUpdate)
            '**** 2010/08 着工適用ボタン追加 ED **** 

            'If oDataView.Count = 0 Then pnlList.Visible = False
            udpList.Update()
        Catch tex As Threading.ThreadAbortException
            Throw
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region
 
#Region " チェック関連 " 
 
    Protected Sub valCatalog2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCatalog2.ServerValidate 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery = "SELECT CATALOG_NO FROM PARTS_MST WHERE CATALOG_NO = :K01" 
            _oDatabase.CreateParam("K01", args.Value.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            args.IsValid = oReader.HasRows 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
    Protected Sub valCatalog3_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCatalog3.ServerValidate 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery = "SELECT CATALOG_NO FROM P_PROCESS_MST WHERE CATALOG_NO = :K01" 
            _oDatabase.CreateParam("K01", args.Value.Trim()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            args.IsValid = Not oReader.HasRows 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub

    Protected Sub valCopyCatalog2_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCopyCatalog2.ServerValidate
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            sQuery = "SELECT CATALOG_NO FROM P_PROCESS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", args.Value.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            args.IsValid = oReader.HasRows
            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Sub

#End Region

#Region " ファイル関連 "

    '複写 
    Private Function FileCopy() As Boolean
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Try
            _oDatabase.BeginTrans()

            '**** 2010/05/06 サイクルタイム、タクトタイム追加対応 ST ****
            sQuery = ""
            sQuery += "INSERT INTO P_PROCESS_MST ("
            sQuery += "  CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB, PROCESS_CD, PER_PROCESS_CD"
            sQuery += ", UM_P_ORDER, SHOP, P_COMMENT, CRT_DT, CRT_TIME"
            sQuery += ", CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
            sQuery += ", CYCLE_TIME, TACT_TIME"
            sQuery += ", PUT_TOGETHER_FLG, PLAN_TARGET_FLG" '20120323 追加
            sQuery += ") "
            sQuery += "SELECT :F01, P_ORDER_MAIN, P_ORDER_SUB, PROCESS_CD, PER_PROCESS_CD"
            sQuery += "     , UM_P_ORDER, SHOP, P_COMMENT, :F02, :F03"
            sQuery += "     , :F04, :F05, :F06, :F07, :F08"
            '**** '2010/08/27 サイクルタイムとタクトタイムはコピーしない ST ****
            sQuery += "     , 0 AS CYCLE_TIME, 0 AS TACT_TIME"
            'sQuery += "     , CYCLE_TIME, TACT_TIME"
            '**** '2010/08/27 サイクルタイムとタクトタイムはコピーしない ED ****
            sQuery += "     , PUT_TOGETHER_FLG, PLAN_TARGET_FLG" '20120327 追加
            sQuery += "  FROM P_PROCESS_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            'sQuery = "INSERT INTO P_PROCESS_MST SELECT :F01,P_ORDER_MAIN,P_ORDER_SUB,PROCESS_CD,PER_PROCESS_CD,UM_P_ORDER,SHOP,P_COMMENT,:F02,:F03,:F04,:F05,:F06,:F07,:F08 FROM P_PROCESS_MST WHERE CATALOG_NO = :K01"
            '**** 2010/05/06 サイクルタイム、タクトタイム追加対応 ED ****
            _oDatabase.CreateParam("F01", ViewState("catalog"))
            _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F04", Session("UserID"))
            _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F07", Session("UserID"))
            _oDatabase.CreateParam("F08", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", txtCopyCatalog.Text.Trim())
            _oDatabase.ExecuteNonQueryParam(sQuery)

            sQuery = "SELECT P_ORDER_MAIN,P_ORDER_SUB FROM P_PROCESS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam(":K01", txtCopyCatalog.Text.Trim())
            oReader = _oDatabase.CreateReaderParam(sQuery)
            While oReader.Read

                'マスタ更新履歴テーブル追加
                InsertHistory(ViewState("catalog") + "：" + GetInt32(oReader, 0).ToString + "：" + GetInt32(oReader, 1).ToString)

            End While

            '**** 2010/08 加工工程SHOPマスタ追加 ST ****
            sQuery = ""
            sQuery += "INSERT INTO P_PROCESS_SHOP_MST "
            sQuery += "SELECT :F01 AS CATALOG_NO"
            sQuery += "     , P_ORDER_MAIN, P_ORDER_SUB, SHOP, TYPICAL_KB"
            sQuery += "     , :F02 AS CRT_DT"
            sQuery += "     , :F03 AS CRT_TIME"
            sQuery += "     , :F04 AS CRT_USR"
            sQuery += "     , :F05 AS UPD_DT"
            sQuery += "     , :F06 AS UPD_TIME"
            sQuery += "     , :F07 AS UPD_USR"
            sQuery += "     , :F08 AS UPD_PROGRAM_ID"
            sQuery += "  FROM P_PROCESS_SHOP_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("F01", ViewState("catalog"))
            _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F04", Session("UserID"))
            _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F07", Session("UserID"))
            _oDatabase.CreateParam("F08", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", Me.txtCopyCatalog.Text.Trim)

            _oDatabase.ExecuteNonQueryParam(sQuery)
            '**** 2010/08 加工工程SHOPマスタ追加 ED ****

            _oDatabase.CommitTrans()
            oReader.Close()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Function
 
    '並べ替え 
    Private Function FileSort() As Boolean
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim nKoujun As Integer = 0
        Dim sDummy As String = ""
        Dim sDummies As New StringBuilder
        Dim nSaveKoujun As Integer = 0
        Try
            _oDatabase.BeginTrans()
            sQuery = "SELECT * FROM P_PROCESS_MST WHERE CATALOG_NO = :K01 ORDER BY P_ORDER_MAIN,P_ORDER_SUB"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            oReader = _oDatabase.CreateReaderParam(sQuery)
            While oReader.Read()
                '###### 2012/03/27 集約区分、計画対象区分追加対応 ST ######
                '**** 2010/05/06 サイクルタイム、タクトタイム追加対応 ST ****
                sDummy = GetString(oReader, 0) & Chr(9) & _
                         GetInt32(oReader, 1).ToString & Chr(9) & _
                         GetInt32(oReader, 2).ToString & Chr(9) & _
                         GetString(oReader, 3) & Chr(9) & _
                         GetString(oReader, 4) & Chr(9) & _
                         GetString(oReader, 5) & Chr(9) & _
                         GetString(oReader, 6) & Chr(9) & _
                         GetString(oReader, 7) & Chr(9) & _
                         GetString(oReader, 8) & Chr(9) & _
                         GetString(oReader, 9) & Chr(9) & _
                         GetString(oReader, 10) & Chr(9) & _
                         GetDouble(oReader, 15).ToString & Chr(9) & _
                         GetDouble(oReader, 16).ToString & Chr(9) & _
                         GetString(oReader, 17).ToString & Chr(9) & _
                         GetString(oReader, 18).ToString

                'sDummy = GetString(oReader, 0) & Chr(9) & _
                '         GetInt32(oReader, 1).ToString & Chr(9) & _
                '         GetInt32(oReader, 2).ToString & Chr(9) & _
                '         GetString(oReader, 3) & Chr(9) & _
                '         GetString(oReader, 4) & Chr(9) & _
                '         GetString(oReader, 5) & Chr(9) & _
                '         GetString(oReader, 6) & Chr(9) & _
                '         GetString(oReader, 7) & Chr(9) & _
                '         GetString(oReader, 8) & Chr(9) & _
                '         GetString(oReader, 9) & Chr(9) & _
                '         GetString(oReader, 10) & Chr(9) & _
                '         GetDouble(oReader, 15).ToString & Chr(9) & _
                '         GetDouble(oReader, 16).ToString
                '###### 2012/03/27 集約区分、計画対象区分追加対応 ED ######

                'sDummy = GetString(oReader, 0) + Chr(9) & _
                '         GetInt32(oReader, 1) & Chr(9) & _
                '         GetInt32(oReader, 2) & Chr(9) & _
                '         GetString(oReader, 3) + Chr(9) + _
                '         GetString(oReader, 4) + Chr(9) + _
                '         GetString(oReader, 5) + Chr(9) + _
                '         GetString(oReader, 6) + Chr(9) + _
                '         GetString(oReader, 7) + Chr(9) + _
                '         GetString(oReader, 8) + Chr(9) + _
                '         GetString(oReader, 9) + Chr(9) + _
                '         GetString(oReader, 10)
                '**** 2010/05/06 サイクルタイム、タクトタイム追加対応 ED ****
                sDummies.Append(sDummy + Chr(10))
            End While
            oReader.Close()

            '**** 2010/08 加工工程SHOPマスタ追加 ST ****
            Dim oTableShop As DataTable
            sQuery = ""
            sQuery += "SELECT *"
            sQuery += "  FROM P_PROCESS_SHOP_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            sQuery += " ORDER BY P_ORDER_MAIN"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            oTableShop = _oDatabase.CreateDataSetParam(sQuery, "T").Tables("T")

            sQuery = "DELETE FROM P_PROCESS_SHOP_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.ExecuteNonQueryParam(sQuery)
            '**** 2010/08 加工工程SHOPマスタ追加 ED ****

            sQuery = "DELETE FROM P_PROCESS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.ExecuteNonQueryParam(sQuery)
            Dim sRecords() As String = sDummies.ToString.Split(Chr(10))

            For i As Integer = 0 To sRecords.Length - 2
                Dim sFields() As String = sRecords(i).Split(Chr(9))
                If nSaveKoujun <> CType(sFields(1), Integer) Then
                    nKoujun += 10
                    nSaveKoujun = CType(sFields(1), Integer)
                End If

                'マスタ更新履歴テーブル追加
                UpdateHistory(sFields(0), CType(sFields(1), Integer), nKoujun, CType(sFields(2), Integer))

                '**** 2010/05/06 サイクルタイム、タクトタイム追加対応 ST ****
                sQuery = ""
                sQuery += "INSERT INTO P_PROCESS_MST ("
                sQuery += "  CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB, PROCESS_CD, PER_PROCESS_CD"
                sQuery += ", UM_P_ORDER, SHOP, P_COMMENT, CRT_DT, CRT_TIME"
                sQuery += ", CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                sQuery += ", CYCLE_TIME, TACT_TIME"
                sQuery += ", PUT_TOGETHER_FLG, PLAN_TARGET_FLG" '20120327 追加
                sQuery += ") VALUES ("
                sQuery += "  :F01, :F02, :F03, :F04, :F05"
                sQuery += ", :F06, :F07, :F08, :F09, :F10"
                sQuery += ", :F11, :F12, :F13, :F14, :F15"
                'sQuery += ", :F16, :F17"  '2012/03/27 MOD
                sQuery += ", :F16, :F17, :F18, :F19"
                sQuery += ")"
                _oDatabase.CreateParam("F01", sFields(0))
                _oDatabase.CreateParam("F02", nKoujun)
                _oDatabase.CreateParam("F03", CType(sFields(2), Integer))
                _oDatabase.CreateParam("F04", sFields(3))
                _oDatabase.CreateParam("F05", sFields(4))
                _oDatabase.CreateParam("F06", sFields(5))
                _oDatabase.CreateParam("F07", sFields(6))
                _oDatabase.CreateParam("F08", sFields(7))
                _oDatabase.CreateParam("F09", sFields(8))
                _oDatabase.CreateParam("F10", sFields(9))
                _oDatabase.CreateParam("F11", sFields(10))
                _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemDate)
                _oDatabase.CreateParam("F13", MedicalLib.Common.GetSystemTime)
                _oDatabase.CreateParam("F14", Session("UserID"))
                _oDatabase.CreateParam("F15", MedicalLib.Common.ProgramID)
                _oDatabase.CreateParam("F16", sFields(11))
                _oDatabase.CreateParam("F17", sFields(12))
                _oDatabase.CreateParam("F18", sFields(13)) '2012/03/27 MOD
                _oDatabase.CreateParam("F19", sFields(14)) '2012/03/27 MOD
                'sQuery = "INSERT INTO P_PROCESS_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11,:F12,:F13,:F14,:F15)"
                '_oDatabase.CreateParam("F01", sFields(0))
                '_oDatabase.CreateParam("F02", nKoujun)
                '_oDatabase.CreateParam("F03", CType(sFields(2), Integer))
                '_oDatabase.CreateParam("F04", sFields(3))
                '_oDatabase.CreateParam("F05", sFields(4))
                '_oDatabase.CreateParam("F06", sFields(5))
                '_oDatabase.CreateParam("F07", sFields(6))
                '_oDatabase.CreateParam("F08", sFields(7))
                '_oDatabase.CreateParam("F09", sFields(8))
                '_oDatabase.CreateParam("F10", sFields(9))
                '_oDatabase.CreateParam("F11", sFields(10))
                '_oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemDate)
                '_oDatabase.CreateParam("F13", MedicalLib.Common.GetSystemTime)
                '_oDatabase.CreateParam("F14", Session("UserID"))
                '_oDatabase.CreateParam("F15", MedicalLib.Common.ProgramID)
                '**** 2010/05/06 サイクルタイム、タクトタイム追加対応 ED ****
                _oDatabase.ExecuteNonQueryParam(sQuery)


                '**** 2010/08 加工工程SHOPマスタ追加 ST ****
                For Each oRow As DataRow In oTableShop.Select("P_ORDER_MAIN = " & sFields(1))

                    sQuery = ""
                    sQuery += "INSERT INTO P_PROCESS_SHOP_MST"
                    sQuery += "( CATALOG_NO, P_ORDER_MAIN, P_ORDER_SUB, SHOP, TYPICAL_KB"
                    sQuery += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                    sQuery += ") VALUES ("
                    sQuery += "  :F01, :F02, :F03, :F04, :F05"
                    sQuery += ", :F06, :F07, :F08, :F09, :F10, :F11, :F12"
                    sQuery += ")"

                    _oDatabase.CreateParam("F01", sFields(0))
                    _oDatabase.CreateParam("F02", nKoujun)
                    _oDatabase.CreateParam("F03", CType(sFields(2), Integer))
                    _oDatabase.CreateParam("F04", oRow("SHOP").ToString)
                    _oDatabase.CreateParam("F05", oRow("TYPICAL_KB").ToString)
                    _oDatabase.CreateParam("F06", oRow("CRT_DT").ToString)
                    _oDatabase.CreateParam("F07", oRow("CRT_TIME").ToString)
                    _oDatabase.CreateParam("F08", oRow("CRT_USR").ToString)
                    _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F11", Session("UserID"))
                    _oDatabase.CreateParam("F12", MedicalLib.Common.ProgramID)

                    _oDatabase.ExecuteNonQueryParam(sQuery)
                Next
                '**** 2010/08 加工工程SHOPマスタ追加 ED ****
            Next
            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader = Nothing
        End Try
    End Function

    '一括削除
    Private Function FileDelete() As Boolean
        Dim sQuery As String = ""
        Try
            _oDatabase.BeginTrans()

            'マスタ更新履歴テーブル追加
            DeleteHistory(ViewState("catalog"))

            sQuery = "DELETE FROM P_PROCESS_MST WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.ExecuteNonQueryParam(sQuery)


            '**** 2010/08 加工工程SHOPマスタ削除処理追加 ST ****
            sQuery = ""
            sQuery += "DELETE FROM P_PROCESS_SHOP_MST"
            sQuery += " WHERE CATALOG_NO = :K01"
            _oDatabase.CreateParam("K01", ViewState("catalog"))
            _oDatabase.ExecuteNonQueryParam(sQuery)
            '**** 2010/08 加工工程SHOPマスタ削除処理追加 ED ****

            _oDatabase.CommitTrans()
            Return True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Function
 
#End Region 
 
#Region " ユーザー関数 " 
 
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
        InsertMH(sKey, "一括削除", "", "")
    End Sub

    Private Sub UpdateHistory(ByVal sCatalog As String, ByVal maeKihon As Integer, ByVal atoKihon As Integer, ByVal iHojo As Integer)
        If maeKihon <> atoKihon Then
            InsertMH(sCatalog + "：" + maeKihon.ToString + "：" + iHojo.ToString, "基本工順", maeKihon.ToString, atoKihon.ToString)
        End If
    End Sub

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
