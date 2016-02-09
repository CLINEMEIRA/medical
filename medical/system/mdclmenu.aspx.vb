Imports System.Data
Imports System.Data.OracleClient
Imports System.Drawing 
 
Partial Class mdclmenu 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDCLMENU" 
    Private Const PROGRAM_TITLE As String = "システムメニュー" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント " 
 
    Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) 
        MedicalLib.Common.CheckLogin() 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        If Not Page.IsPostBack Then
            timAlarm.Enabled = Session("Level").ToString.Equals("01")
            saveKey1.Value = -1
            'pnlMenu2.Visible = False 

            'セッション変数削除処理 2010/07 追加
            DeleteSession()
        Else
            If saveKey1.Value <> -1 Then Session("MenuKey1") = saveKey1.Value
        End If
        DisplayLevel()
        DisplayMenu1()
        ' DisplayAlarm() 
        If Session("MenuKey1") <> -1 Then DisplayMenu2()
    End Sub
  
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    'リンクボタン押下（隠し） 
    Protected Sub btnLink_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) 
    End Sub 
 
    'リンクボタン押下（隠し） 
    Protected Sub btnNext_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Response.Redirect(".." + saveFolder.Value.Trim.ToLower(), False)
    End Sub
 
    'タイマー 
    Protected Sub timAlarm_Tick(ByVal sender As Object, ByVal e As System.EventArgs) 
        Try 
            If Session("login") Then 
                If SetAlarm() Then DisplayAlarm()
            End If 
        Catch ex As Exception 
        End Try 
    End Sub 
 
#End Region 
 
#Region " 画面関連 " 
 
    Private Sub DisplayLevel()
        Dim sQuery As String = ""
        Dim oReader1 As OracleDataReader = Nothing
        Dim oReader2 As OracleDataReader = Nothing
        Try
            sQuery = ""
            sQuery += "SELECT G.ITEM_KN "
            sQuery += "FROM WORKER_MST W,(SELECT ITEM_KN,TELL_CD FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS001') G "
            sQuery += "WHERE W.ADMIN_LV = G.TELL_CD(+) "
            sQuery += "AND W.WORKER_CD = :K01"
            _oDatabase.CreateParam("K01", Session("UserID").ToString())
            oReader1 = _oDatabase.CreateReaderParam(sQuery)
            oReader1.Read()
            If oReader1.GetString(0).IndexOf("*") <> -1 Then

                '**** 2009/01/20 START ****
                '******** アラーム表示時にはタイマーを活性化して
                '******** アラームテーブルの更新を行うようにする
                timAlarm.Enabled = True
                '**** 2009/01/20 END ****

                udpAlarm.Visible = True

                sQuery = "SELECT A_YEAR FROM ADMIN_MST WHERE ADMIN_KEY = '01' "
                oReader2 = _oDatabase.CreateReader(sQuery)
                oReader2.Read()
                If MedicalLib.Common.GetSystemDate > (CInt(oReader2.GetString(0)) + 1).ToString & "0401" Then
                    pnlNendo.Visible = True
                End If
                oReader2.Close()

                DisplayAlarm()

            Else
                timAlarm.Enabled = False
            End If
            oReader1.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader1 = Nothing
            oReader2 = Nothing
        End Try
    End Sub
 
    'メニュー1表示 
    Private Sub DisplayMenu1() 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery = "SELECT A.MENU_ID,B.PG_NM " 
            sQuery += "FROM (SELECT EMPOWER_LV,MENU_ID,DSP_TURN FROM MENU_MST WHERE MENU_LEBEL = '1') A," 
            sQuery += "(SELECT PROGRAM_ID,PG_NM FROM PROGRAM_MST WHERE MENU_LEBEL = '1') B " 
            sQuery += "WHERE A.MENU_ID = B.PROGRAM_ID(+) AND A.EMPOWER_LV = :K01 " 
            sQuery += "ORDER BY A.DSP_TURN" 
            _oDatabase.CreateParam("K01", Session("Level").ToString()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            While oReader.Read() 
                Dim oRow As HtmlTableRow = New HtmlTableRow 
                Dim oCell As HtmlTableCell = New HtmlTableCell 
                oCell.Controls.Add(New LiteralControl("<font color='MidnightBlue'>" + GetString(oReader, 1) + "</font>")) 
                'oCell.Controls.Add(New LiteralControl("<table border='0' cellpadding='0' cellspacing='0'><tr><td><img src='../image/spacer.gif' width='1' height='25' alt=''></td><td><font color='MidnightBlue'>" + GetString(oReader, 1) + "</font></td></tr></table>")) 
                oCell.Align = "center" 
                oCell.VAlign = "middle" 
                oCell.Width = 230 
                oCell.Height = 30 
                oCell.Style("cursor") = "hand" 
                oCell.Style("forecolor") = "MidnightBlue" 
                oCell.Style("border-style") = "solid" 
                oCell.Style("border-width") = "1px" 
                oCell.Style("border-color") = "#087105" 
                If Session("MenuKey1") = GetString(oReader, 0) Then 
                    oCell.BgColor = "#FFC0C0" 
                Else 
                    oCell.BgColor = "#d9ffcc" 
                    oCell.Attributes("onmouseover") = "this.style.backgroundColor='Gold'" 
                    oCell.Attributes("onmouseout") = "this.style.backgroundColor='#d9ffcc'" 
                End If 
                oCell.Attributes("onclick") = "showMenu2('" + GetString(oReader, 0).ToString() + "');" 
                oRow.Cells.Add(oCell) 
                tblMenu1.Rows.Add(oRow) 
            End While 
            oReader.Close() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
    'アラーム表示 
    Private Sub DisplayAlarm() 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            '本社(棚在庫)安全在庫割れ 
            sQuery = "SELECT COUNT(ALN_REN_BAN) FROM ALARM_TBL WHERE ALM_KB = '1' AND CONFIRM_FLG = '0'" 
            oReader = _oDatabase.CreateReader(sQuery) 
            oReader.Read() 
            If GetInt32(oReader, 0) > 0 Then 
                lblAlarm1.Visible = False 
                lnkAlarm1.Visible = True 
            Else 
                lblAlarm1.Visible = True 
                lnkAlarm1.Visible = False 
            End If 
            oReader.Close() 
            '指定工程到達 
            sQuery = "SELECT COUNT(ALN_REN_BAN) FROM ALARM_TBL WHERE ALM_KB = '2' AND CONFIRM_FLG = '0'" 
            oReader = _oDatabase.CreateReader(sQuery) 
            oReader.Read() 
            If GetInt32(oReader, 0) > 0 Then 
                lblAlarm2.Visible = False 
                lnkAlarm2.Visible = True 
            Else 
                lblAlarm2.Visible = True 
                lnkAlarm2.Visible = False 
            End If 
            oReader.Close() 
            '源製品・子部品・材料入庫 
            sQuery = "SELECT COUNT(ALN_REN_BAN) FROM ALARM_TBL WHERE ALM_KB = '3' AND CONFIRM_FLG = '0'" 
            oReader = _oDatabase.CreateReader(sQuery) 
            oReader.Read() 
            If GetInt32(oReader, 0) > 0 Then 
                lblAlarm3.Visible = False 
                lnkAlarm3.Visible = True 
            Else 
                lblAlarm3.Visible = True 
                lnkAlarm3.Visible = False 
            End If 
            oReader.Close() 
            udpAlarm.Update() 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
    'メニュー2表示 
    Private Sub DisplayMenu2() 
        Dim sQuery As String = "" 
        Dim oReader As OracleDataReader = Nothing 
        Try 
            sQuery = "SELECT A.PROGRAM_ID,B.PG_NM,B.FILE_PATH " 
            sQuery += "FROM (SELECT EMPOWER_LV,MENU_ID,PROGRAM_ID,DSP_TURN FROM MENU_MST WHERE MENU_LEBEL = '2') A,PROGRAM_MST B " 
            sQuery += "WHERE A.PROGRAM_ID = B.PROGRAM_ID(+) AND A.EMPOWER_LV = :K01 AND A.MENU_ID = :K02 " 
            sQuery += "ORDER BY A.DSP_TURN" 
            _oDatabase.CreateParam("K01", Session("Level").ToString()) 
            _oDatabase.CreateParam("K02", Session("MenuKey1").ToString()) 
            oReader = _oDatabase.CreateReaderParam(sQuery) 
            Dim i As Integer = 2 
            Dim oRow As HtmlTableRow = Nothing 
            Dim oCell As HtmlTableCell = Nothing 
            While oReader.Read() 
                If i > 1 Then 
                    oRow = New HtmlTableRow 
                    i = 0 
                End If 
                oCell = New HtmlTableCell 
                If Not GetString(oReader, 0).Trim.PadRight(8, " ").Substring(0, 3).Equals("&SP") Then 
                    oCell.Controls.Add(New LiteralControl("<font color='MidnightBlue'>" + GetString(oReader, 1) + "</font>")) 
                    'oCell.Controls.Add(New LiteralControl("<table border='0' cellpadding='0' cellspacing='0'><tr><td><img src='../image/spacer.gif' width='1' height='25' alt=''></td><td><font color='MidnightBlue'>" + GetString(oReader, 1) + "</font></td></tr></table>")) 
                    oCell.Align = "center" 
                    oCell.VAlign = "middle" 
                    oCell.Width = 340 
                    oCell.Height = 30 
                    oCell.BgColor = "#d9ffcc" 
                    oCell.Style("cursor") = "hand" 
                    oCell.Style("forecolor") = "MidnightBlue" 
                    oCell.Style("border-style") = "solid" 
                    oCell.Style("border-width") = "1px" 
                    oCell.Style("border-color") = "#087105" 
                    oCell.Attributes("onmouseover") = "this.style.backgroundColor='Gold'" 
                    oCell.Attributes("onmouseout") = "this.style.backgroundColor='#d9ffcc'" 
                    oCell.Attributes("onclick") = "goNext('" + GetString(oReader, 0) + "','" + GetString(oReader, 2) + "');" 
                Else 
                    'oCell.Controls.Add(New LiteralControl("<img src='../image/spacer.gif' width='1' height='25' alt=''>")) 
                    oCell.Align = "center" 
                    oCell.VAlign = "middle" 
                    oCell.Width = 340 
                    oCell.Height = 30 
                    oCell.BgColor = "#f7f7f7" 
                End If 
                oRow.Cells.Add(oCell) 
                If i = 1 Then 
                    tblMenu2.Rows.Add(oRow) 
                End If 
                i += 1 
            End While 
            If i = 1 Then 
                oCell = New HtmlTableCell 
                oCell.Controls.Add(New LiteralControl("<img src='../image/spacer.gif' width='1' height='25' alt=''>")) 
                oCell.BgColor = "#F7F7F7" 
                oCell.Width = "340" 
                oRow.Cells.Add(oCell) 
                tblMenu2.Rows.Add(oRow) 
            End If 
            oReader.Close() 
            pnlMenu2.Visible = True 
            udpMenu2.Update()
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            oReader = Nothing 
        End Try 
    End Sub 
 
#End Region

#Region " チェック関連 "

    Private Function CheckAlarm(ByVal sCompanyNo As String, ByVal sOccurDate As String, ByRef nSupplyAmt As Integer) As Boolean
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim nReturn As Boolean = False
        Try
            '**** 2009/01/07 START ****
            '******** 在庫補充数を全て取得するように変更
            '指示テーブル(納期調整)
            sQuery = "SELECT PW_AMT FROM INDICATE_TBL WHERE COMPANY_NO = :K01 AND DELIVERY_ADJUST_DT >= :K02 AND INDICATE_DECIDE_FLG = 'K' AND TRIM(DEL_FLG) IS NULL"
            _oDatabase.CreateParam("K01", sCompanyNo)
            _oDatabase.CreateParam("K02", sOccurDate)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            'nReturn = oReader.Read()
            Do While oReader.Read
                nSupplyAmt += GetInt32(oReader, 0)
            Loop
            'If nReturn Then nSupplyAmt = GetInt32(oReader, 0)
            oReader.Close()
            'If nReturn Then Return True
            '積送テーブル
            sQuery = "SELECT AMT FROM LOAD_TBL WHERE COMPANY_NO = :K01 AND WH_DT >= :K02"
            _oDatabase.CreateParam("K01", sCompanyNo)
            _oDatabase.CreateParam("K02", sOccurDate)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            'nReturn = oReader.Read()
            Do While oReader.Read
                nSupplyAmt += GetInt32(oReader, 0)
            Loop
            'If nReturn Then nSupplyAmt = GetInt32(oReader, 0)
            oReader.Close()
            'If nReturn Then Return True
            '指示テーブル(登録日付)
            sQuery = "SELECT PW_AMT FROM INDICATE_TBL WHERE COMPANY_NO = :K01 AND CRT_DT >= :K02 AND INDICATE_DECIDE_FLG = 'K' AND TRIM(DEL_FLG) IS NULL"
            _oDatabase.CreateParam("K01", sCompanyNo)
            _oDatabase.CreateParam("K02", sOccurDate)
            oReader = _oDatabase.CreateReaderParam(sQuery)
            'nReturn = oReader.Read()
            Do While oReader.Read
                nSupplyAmt += GetInt32(oReader, 0)
            Loop
            'If nReturn Then nSupplyAmt = GetInt32(oReader, 0)
            oReader.Close()
            'Return nReturn
            If nSupplyAmt > 0 Then
                nReturn = True
            End If
            '**** 2009/01/27 END ******
        Catch ex As Exception
            Throw
        Finally
            oReader = Nothing
        End Try
        Return nReturn
    End Function

#End Region
 
#Region " ファイル関連 " 
 
    Private Function SetAlarm() As Boolean
        Dim oHonsya As MedicalLib.DataAccess = Nothing
        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing
        Dim bReturn As Boolean = False

        Try
            _oDatabase.BeginTrans()
            oHonsya = New MedicalLib.DataAccess("HonsyaDB")
            '本社メディカルシステムの在庫テーブルの安全在庫 <> 0 AND 棚在庫 < 安全在庫の時作成
            oReader = oHonsya.CreateReader("SELECT CATALOG_NO,COMPANY_NO,STOCK_AMT,SAFTY_STK_AMT FROM CATALOG_MST WHERE SAFTY_STK_AMT <> 0 AND STOCK_AMT < SAFTY_STK_AMT ORDER BY COMPANY_NO")
            While oReader.Read()
                'アラーム区分 = '1' AND 社内NO = 在庫割れした社内NO
                sQuery = "SELECT ALN_REN_BAN,CONFIRM_FLG,OCCUR_DT,SUPPLY_AMT FROM ALARM_TBL WHERE ALM_KB = '1' AND COMPANY_NO = :K01"
                _oDatabase.CreateParam("K01", GetString(oReader, 1))
                Dim oDummy As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                Dim nSupplyAmt As Integer = 0
                If oDummy.Read() Then
                    Select Case GetString(oDummy, 1)
                        Case "0"
                        Case "1"
                            If GetString(oDummy, 2) < MedicalLib.Common.GetSystemDate() Then
                                If CheckAlarm(GetString(oReader, 1), GetString(oDummy, 2), nSupplyAmt) Then
                                    FileUpdate1(GetString(oDummy, 0), nSupplyAmt)
                                Else
                                    FileUpdate2(GetString(oDummy, 0))
                                End If
                            End If
                        Case "2"
                            '本社.在庫数 + 在庫補充数 < 本社.安全在庫
                            If GetInt32(oReader, 2) + GetInt32(oDummy, 3) < GetInt32(oReader, 3) Then
                                FileUpdate2(GetString(oDummy, 0))
                            End If
                    End Select
                Else
                    FileInsert(GetString(oReader, 0), GetString(oReader, 1))
                End If
                oDummy.Close()
            End While
            oReader.Close()
            'アラーム削除
            '**** 2009/01/27 START ****
            sQuery = "SELECT ALN_REN_BAN,COMPANY_NO FROM ALARM_TBL WHERE ALM_KB = '1'"
            'sQuery = "SELECT ALN_REN_BAN,COMPANY_NO FROM ALARM_TBL WHERE ALM_KB = '1' AND CONFIRM_FLG = '2'"
            '**** 2009/01/27 END ******
            oReader = _oDatabase.CreateReaderParam(sQuery)
            While oReader.Read()
                sQuery = "SELECT STOCK_AMT,SAFTY_STK_AMT FROM CATALOG_MST WHERE COMPANY_NO = :K01 AND SAFTY_STK_AMT <> 0 AND STOCK_AMT >= SAFTY_STK_AMT"
                oHonsya.CreateParam("K01", GetString(oReader, 1))
                Dim oDummy As OracleDataReader = oHonsya.CreateReaderParam(sQuery)
                If oDummy.Read() Then
                    FileDelete(GetString(oReader, 0))
                End If
                oDummy.Close()
            End While
            oReader.Close()
            _oDatabase.CommitTrans()
            'Return True
            bReturn = True
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.Log.Log(ex.Message)
        Finally
            If Not oHonsya Is Nothing Then oHonsya.Close()
            oReader = Nothing
        End Try
        Return bReturn
    End Function

    Public Sub FileInsert(ByVal sCatalogNo As String, ByVal sCompanyNo As String)
        Dim sQuery As String = ""
        Const ALARM_MSG As String = "カタログ番号:$1 の在庫が安全在庫割れになりました"
        Try
            Dim sRenban As String = _oDatabase.GetNumber(MedicalLib.DataAccess.Saiban.AL).ToString("00000000")
            sQuery = "INSERT INTO ALARM_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
                                                          ":F11,:F12,:F13,:F14,:F15)"
            _oDatabase.CreateParam("F01", "1")                                  'ALM_KB 
            _oDatabase.CreateParam("F02", sRenban)                              'ALN_REN_BAN 
            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate)      'OCCUR_DT 
            _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime)      'OCCUR_TIME 
            _oDatabase.CreateParam("F05", ALARM_MSG.Replace("$1", sCatalogNo))  'MESSAGE 
            _oDatabase.CreateParam("F06", "0")                                  'CONFIRM_FLG
            _oDatabase.CreateParam("F07", sCompanyNo)                           'COMPANY_NO
            _oDatabase.CreateParam("F08", 0)                                    'SUPPLY_AMT
            _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemDate)      'CRT_DT 
            _oDatabase.CreateParam("F10", MedicalLib.Common.GetSystemTime)      'CRT_TIME 
            _oDatabase.CreateParam("F11", Session("UserID"))                    'CRT_USR 
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemDate)      'UPD_DT 
            _oDatabase.CreateParam("F13", MedicalLib.Common.GetSystemTime)      'UPD_TIME 
            _oDatabase.CreateParam("F14", Session("UserID"))                    'CRT_USR 
            _oDatabase.CreateParam("F15", MedicalLib.Common.ProgramID)          'UPD_PROGRAM_ID 
            _oDatabase.ExecuteNonQueryParam(sQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub FileUpdate1(ByVal sRenban As String, ByVal nSupplyAmt As Integer)
        Dim sQuery As String = ""
        Try
            sQuery = "UPDATE ALARM_TBL SET "
            sQuery += "CONFIRM_FLG = :F01,"
            sQuery += "SUPPLY_AMT = SUPPLY_AMT + :F02,"
            sQuery += "UPD_DT = :F03,"
            sQuery += "UPD_TIME = :F04,"
            sQuery += "UPD_USR = :F05,"
            sQuery += "UPD_PROGRAM_ID = :F06 "
            sQuery += "WHERE ALM_KB = '1' AND ALN_REN_BAN = :K01"
            _oDatabase.CreateParam("F01", "2")
            _oDatabase.CreateParam("F02", nSupplyAmt)
            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemDate())
            _oDatabase.CreateParam("F04", MedicalLib.Common.GetSystemTime())
            _oDatabase.CreateParam("F05", Session("UserID"))
            _oDatabase.CreateParam("F06", MedicalLib.Common.ProgramID())
            _oDatabase.CreateParam("K01", sRenban)
            _oDatabase.ExecuteNonQueryParam(sQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub FileUpdate2(ByVal sRenban As String)
        Dim sQuery As String = ""
        Try
            sQuery = "UPDATE ALARM_TBL SET "
            sQuery += "CONFIRM_FLG = :F01,"
            sQuery += "UPD_DT = :F02,"
            sQuery += "UPD_TIME = :F03,"
            sQuery += "UPD_USR = :F04,"
            sQuery += "UPD_PROGRAM_ID = :F05 "
            sQuery += "WHERE ALM_KB = '1' AND ALN_REN_BAN = :K01"
            _oDatabase.CreateParam("F01", "0")
            _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate())
            _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime())
            _oDatabase.CreateParam("F04", Session("UserID"))
            _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID())
            _oDatabase.CreateParam("K01", sRenban)
            _oDatabase.ExecuteNonQueryParam(sQuery)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub FileDelete(ByVal sRenban As String)
        Dim sQuery As String = ""
        Try
            sQuery = "DELETE FROM ALARM_TBL "
            sQuery += "WHERE ALM_KB = '1' AND ALN_REN_BAN = :K01"
            _oDatabase.CreateParam("K01", sRenban)
            _oDatabase.ExecuteNonQueryParam(sQuery)
        Catch ex As Exception
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

    Private Function GetDouble(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Double
        If oReader.IsDBNull(nIndex) Then Return 0.0
        Return oReader.GetDouble(nIndex)
    End Function

    'セッション変数の削除
    Private Sub DeleteSession()
        Try
            If Session("tblLst080" & Session("UserID")) IsNot Nothing Then
                Session.Remove("tblLst080" & Session("UserID"))
            End If
            If Session("headLst080" & Session("UserID")) IsNot Nothing Then
                Session.Remove("headLst080" & Session("UserID"))
            End If
            If Session("mdkei030db") IsNot Nothing Then
                Session.Remove("mdkei030db")
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

End Class
