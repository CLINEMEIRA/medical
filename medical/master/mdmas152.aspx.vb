Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing

Partial Class master_mdmas152
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS150"
    Private Const PROGRAM_TITLE As String = "加工工程マスタメンテナンス"

    Private _oDatabase As MedicalLib.DataAccess

    Private Enum iCol
        CHECK = 0
        INDICATE_NO = 1
        COMPANY_NO = 2
        CATALOG_NO = 3
        KOUTEI = 4
        SIKAKARI = 5
    End Enum

#Region " ページ "

    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess

            ViewState("call") = Request.QueryString("call")
            ViewState("catalog") = Page.Request.QueryString("catalog")

            If Not Page.IsPostBack Then
                GridBind()
            End If

            imgUpdate.Attributes.Add("onclick", MedicalLib.Script.Update())

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

#Region " チェック "

    '更新チェック
    Protected Sub valInput_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valInput.ServerValidate

        For Each oRow As DataGridItem In Me.grdList.Items
            If CType(oRow.Cells(iCol.CHECK).Controls(1), CheckBox).Checked = True Then
                args.IsValid = True
                Exit Sub
            End If
        Next

        'チェックがひとつもない
        DirectCast(source, CustomValidator).ErrorMessage = "チェックがありません"
        args.IsValid = False
        Exit Sub

    End Sub

#End Region

#Region " コントロールイベント "

    '更新
    Protected Sub imgUpdate_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgUpdate.Click
        Try
            Page.Validate()
            If Page.IsValid Then
                UpdataProgress()
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '戻る
    Protected Sub imgBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgBack.Click
        Try
            Response.Redirect("mdmas150.aspx?call=" + ViewState("call") + "&catalog=" + ViewState("catalog"), False)
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " ユーザ関数 "

    Private Sub GridBind()

        Dim sTable As String = "T"
        Dim sQuery As String = ""

        sQuery = ""
        sQuery += "SELECT IT.INDICATE_NO, IT.COMPANY_NO, IT.I_PARTS_NO AS CATALOG_NO"
        sQuery += "     , NVL2(IT.P_P_ORDER_MAIN, LPAD(IT.P_P_ORDER_MAIN, 3, '0') ||'-'|| IT.P_P_ORDER_SUB ||':'|| PM.P_ORDER_NM, '') AS KOUTEI"
        sQuery += "     , IT.PW_AMT"
        sQuery += "  FROM (SELECT * FROM INDICATE_TBL WHERE INDICATE_DECIDE_FLG = 'K' AND TRIM(DEL_FLG) IS NULL) IT"
        sQuery += "     , PROCESS_MST PM"
        sQuery += " WHERE IT.I_PARTS_NO = :K01"
        sQuery += "   AND IT.P_PROCESS_CD = PM.PROCESS_CD(+)"
        sQuery += " ORDER BY IT.INDICATE_NO, IT.COMPANY_NO"
        _oDatabase.CreateParam("K01", ViewState("catalog"))
        Using oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, sTable)

            If oDataSet.Tables(sTable).Rows.Count = 0 Then

                Me.imgUpdate.Visible = False
            Else

                Me.grdList.DataSource = oDataSet
                Me.grdList.DataBind()
            End If
        End Using

    End Sub

#End Region

#Region " データ更新 "

    '工程進捗テーブル更新
    Private Sub UpdataProgress()

        Dim sQuery As String = ""

        _oDatabase.BeginTrans()

        Try
            For Each oRow As DataGridItem In Me.grdList.Items

                If CType(oRow.Cells(iCol.CHECK).Controls(1), CheckBox).Checked = True Then

                    Dim sTable As String = "T"
                    Dim oTable As DataTable = Nothing

                    Dim sSiji As String = oRow.Cells(iCol.INDICATE_NO).Text.Trim
                    Dim sShanai As String = oRow.Cells(iCol.COMPANY_NO).Text.Trim

                    Dim sStMain As String = "000"
                    Dim sStSub As String = "0"

                    '最終工程取得
                    sQuery = ""
                    sQuery += "SELECT MAX(P_ORDER_MAIN) AS MAIN"
                    sQuery += "     , MAX(P_ORDER_SUB) AS SUB"
                    sQuery += "  FROM PROCESS_RESULTS_TBL"
                    sQuery += " WHERE INDICATE_NO = :K01"
                    sQuery += "   AND COMPANY_NO = :K02"
                    sQuery += "   AND P_ORDER_MAIN < 900"
                    sQuery += " GROUP BY INDICATE_NO, COMPANY_NO"
                    _oDatabase.CreateParam("K01", sSiji)
                    _oDatabase.CreateParam("K02", sShanai)

                    Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                        If oReader.Read Then
                            sStMain = GetInt32(oReader, 0).ToString.PadLeft(3, "0"c)
                            sStSub = GetInt32(oReader, 1)
                        End If
                    End Using


                    '最終工程以降の工程進捗を削除する前に予定日を取得
                    sQuery = ""
                    sQuery += "SELECT P_ORDER_MAIN, P_ORDER_SUB, PROCESS_CD"
                    sQuery += "     , PLAN_DT"
                    sQuery += "  FROM PROCESS_PROGRESS_TBL"
                    sQuery += " WHERE INDICATE_NO = :K01"
                    sQuery += "   AND COMPANY_NO = :K02"
                    sQuery += "   AND LPAD(P_ORDER_MAIN, 3, '0') || P_ORDER_SUB > :K03"
                    sQuery += "   AND PLAN_DT <> '00000000'"
                    _oDatabase.CreateParam("K01", sSiji)
                    _oDatabase.CreateParam("K02", sShanai)
                    _oDatabase.CreateParam("K03", sStMain & sStSub)

                    Using oDataSet As DataSet = _oDatabase.CreateDataSetParam(sQuery, sTable)
                        oTable = oDataSet.Tables(sTable)
                    End Using

                    '最終工程以降の工程進捗を削除
                    sQuery = ""
                    sQuery += "DELETE FROM PROCESS_PROGRESS_TBL"
                    sQuery += " WHERE INDICATE_NO = :K01"
                    sQuery += "   AND COMPANY_NO = :K02"
                    sQuery += "   AND (LPAD(P_ORDER_MAIN, 3, '0') || P_ORDER_SUB > :K03"
                    sQuery += "    AND P_ORDER_MAIN < 900)"
                    _oDatabase.CreateParam("K01", sSiji)
                    _oDatabase.CreateParam("K02", sShanai)
                    _oDatabase.CreateParam("K03", sStMain & sStSub)

                    _oDatabase.ExecuteNonQueryParam(sQuery)


                    '加工工程マスタより新しい工程進捗を作る
                    Dim sPlanDT As String = ""

                    sQuery = ""
                    sQuery += "SELECT KK.P_ORDER_MAIN, KK.P_ORDER_SUB"
                    sQuery += "     , KK.PROCESS_CD, KM.FACILITIES_G_CD"
                    sQuery += "     , KK.SHOP, KK.UM_P_ORDER"
                    sQuery += "  FROM P_PROCESS_MST KK"
                    sQuery += "     , PROCESS_MST KM"
                    sQuery += " WHERE KK.CATALOG_NO = :K01"
                    sQuery += "   AND LPAD(KK.P_ORDER_MAIN, 3, '0') || KK.P_ORDER_SUB > :K02"
                    sQuery += "   AND KK.PROCESS_CD = KM.PROCESS_CD(+)"
                    _oDatabase.CreateParam("K01", ViewState("catalog"))
                    _oDatabase.CreateParam("K02", sStMain & sStSub)

                    Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)

                        While oReader.Read

                            '予定日取得
                            sPlanDT = "00000000"
                            For Each oDataRow As DataRow In oTable.Rows
                                If oDataRow("P_ORDER_MAIN") = GetInt32(oReader, 0) And _
                                   oDataRow("P_ORDER_SUB") = GetInt32(oReader, 1) And _
                                   oDataRow("PROCESS_CD") = GetString(oReader, 2) Then

                                    sPlanDT = oDataRow("PLAN_DT")
                                End If
                            Next

                            sQuery = ""
                            sQuery += "INSERT INTO PROCESS_PROGRESS_TBL"
                            sQuery += " ( INDICATE_NO, COMPANY_NO, P_ORDER_MAIN, P_ORDER_SUB"
                            sQuery += " , CATALOG_NO, PROCESS_CD, FACILITIES_G_CD, SHOP"
                            sQuery += " , PLAN_DT, RESULTS_DT, UM_P_ORDER, P_PROGRESS_CD, MACHINE_NO"
                            sQuery += " , PREPARATION_TIME, PROCESSING_TIME, WORK_COMMENT, UPD_CNT"
                            sQuery += " , CRT_DT, CRT_TIME, CRT_USR"
                            sQuery += " , UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                            sQuery += " ) VALUES ("
                            sQuery += "   :F01, :F02, :F03, :F04"
                            sQuery += " , :F05, :F06, :F07, :F08"
                            sQuery += " , :F09, :F10, :F11, :F12, :F13"
                            sQuery += " , :F14, :F15, :F16, :F17"
                            sQuery += " , :F18, :F19, :F20"
                            sQuery += " , :F21, :F22, :F23, :F24"
                            sQuery += " )"

                            _oDatabase.CreateParam("F01", sSiji)
                            _oDatabase.CreateParam("F02", sShanai)
                            _oDatabase.CreateParam("F03", GetInt32(oReader, 0))
                            _oDatabase.CreateParam("F04", GetInt32(oReader, 1))
                            _oDatabase.CreateParam("F05", ViewState("catalog"))
                            _oDatabase.CreateParam("F06", GetString(oReader, 2))
                            _oDatabase.CreateParam("F07", GetString(oReader, 3))
                            _oDatabase.CreateParam("F08", GetString(oReader, 4))
                            _oDatabase.CreateParam("F09", sPlanDT)
                            _oDatabase.CreateParam("F10", "00000000")
                            _oDatabase.CreateParam("F11", GetString(oReader, 5))
                            _oDatabase.CreateParam("F12", "")
                            _oDatabase.CreateParam("F13", "")
                            _oDatabase.CreateParam("F14", 0)
                            _oDatabase.CreateParam("F15", 0)
                            _oDatabase.CreateParam("F16", "")
                            _oDatabase.CreateParam("F17", 0)
                            _oDatabase.CreateParam("F18", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F19", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F20", Session("UserID"))
                            _oDatabase.CreateParam("F21", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F22", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F23", Session("UserID"))
                            _oDatabase.CreateParam("F24", MedicalLib.Common.ProgramID)

                            _oDatabase.ExecuteNonQueryParam(sQuery)
                        End While
                    End Using

                End If
            Next

            _oDatabase.CommitTrans()

            Response.Redirect("mdmas150.aspx?call=" + ViewState("call") + "&catalog=" + ViewState("catalog"), False)

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
