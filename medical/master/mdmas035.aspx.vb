Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient
Imports System.IO
Imports System.Text

Partial Class master_mdmas035 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDMAS035" 
    Private Const PROGRAM_TITLE As String = "部品マスタ取込み登録" 
 
    Private _oDatabase As MedicalLib.DataAccess 
    Private FilePass As String 
 
    Private Const TEXT_BACKUP As String = "HostDataBackup"

#Region " ページ "

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE

        Try
            _oDatabase = New MedicalLib.DataAccess
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        If Not Page.IsPostBack Then
            btnImport.Attributes.Add("onclick", MedicalLib.Script.Import())
        End If
        btnImport.Visible = MedicalLib.Common.EnableInsert
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

#End Region
 
#Region " ボタン " 
 
    Protected Sub btnImport_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) 
        textImport() 
    End Sub 
 
#End Region 
 
#Region " ユーザー関数 " 
 
    Private Sub textImport() 
 
        lblMessage.ForeColor = Color.Black 
        lblMessage.Text = "" 
        If Not System.IO.File.Exists(ConfigurationManager.AppSettings("BuhinHostFile")) Then 
            lblMessage.ForeColor = Color.Red 
            lblMessage.Text = "部品マスタ取込用ファイルが存在しません" 
            Exit Sub 
        End If 
 
        lblMessage.Text = "取り込み中・・・" 
 
        If System.IO.File.Exists(ConfigurationManager.AppSettings("BuhinHostFile")) Then
            Dim sBackup As String = ConfigurationManager.AppSettings(TEXT_BACKUP) + "BUHINM.FIX." + MedicalLib.Common.GetSystemDate + MedicalLib.Common.GetSystemTime
            System.IO.File.Copy(ConfigurationManager.AppSettings("BuhinHostFile"), sBackup)
        End If

        Dim sQuery As String = ""
        Dim intWork As Integer = 0
        Dim intLine As Integer = 0
        Dim blnErr As Boolean = False

        'テキストファイルの読込み 
        Dim sr As New System.IO.StreamReader(ConfigurationManager.AppSettings("BuhinHostFile"), System.Text.Encoding.GetEncoding("Shift-JIS")) 
        Try 
            _oDatabase.BeginTrans() 
            '内容を一行ずつ読み込む 
            While sr.Peek() > -1 
                Dim s As String = sr.ReadLine()
                intLine += 1
                If System.Text.Encoding.GetEncoding(932).GetByteCount(s) <> 256 Then
                    lblMessage.Text = intLine.ToString + "行目、期末在庫数が数値ではありません"
                    blnErr = True
                    Exit While
                End If
                If ("W1" <= s.Substring(20, 2) And s.Substring(20, 2) <= "W9") Or s.Substring(20, 2) = "Z9" Then 
                    '###### 2011/10/18 数値項目チェック追加 ST ######
                    If Integer.TryParse(s.Substring(121, 9).Trim(), intWork) = False Then
                        lblMessage.Text = intLine.ToString + "行目、期末在庫数が数値ではありません"
                        blnErr = True
                        Exit While
                    End If
                    If Integer.TryParse(s.Substring(130, 9).Trim(), intWork) = False Then
                        lblMessage.Text = intLine.ToString + "行目、前月末在庫数が数値ではありません"
                        blnErr = True
                        Exit While
                    End If
                    If Integer.TryParse(s.Substring(139, 9).Trim(), intWork) = False Then
                        lblMessage.Text = intLine.ToString + "行目、在庫数が数値ではありません"
                        blnErr = True
                        Exit While
                    End If
                    If Integer.TryParse(s.Substring(148, 9).Trim(), intWork) = False Then
                        lblMessage.Text = intLine.ToString + "行目、引当済数が数値ではありません"
                        blnErr = True
                        Exit While
                    End If
                    '###### 2011/10/18 数値項目チェック追加 ED ######
                    Select Case checkBuhin(s.Substring(0, 14).Trim(), s.Substring(20, 2).Trim(), s.Substring(38, 6).Trim(), s.Substring(159, 1).Trim(), s.Substring(160, 1).Trim())
                        Case "insert"
                            'sQuery = "INSERT INTO 部品マスタ (カタログ番号,組番,製造課コード,図面番号,社内NO,主材料コード,素材単重,材料単価区分,単位素材量," + _ 
                            '                                 "期末在庫数,前月末在庫数,在庫数,引当済数,ASSY区分,グループコード,品名名称コード,承認者品管,修正区分,元カタログ番号,繰り返し区分," + _ 
                            '                                 "登録日付,登録時刻,登録ユーザID,更新日付,更新時刻,更新ユーザID,更新プログラムID,初品区分" + _ 
                            '                                 ") VALUES (" + _ 
                            '                                 ":F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _ 
                            '                                 ":F11,:F12,:F13,:F14,:F15,:F16,:F17,:F18,:F19,:F20," + _ 
                            '                                 ":F21,:F22,:F23,:F24,:F25,:F26,:F27,:F28)" 
                            sQuery = "INSERT INTO PARTS_MST (CATALOG_NO,C_NO,M_SECTION_CD,SKETCH_NO,COMPANY_NO,MATL_CD,MATL_WAT,MATL_PRICE_KB,UNIT_MATL_WAT," + _
                                                             "TERM_STOCK_AMT,LMSTOCK_AMT,STOCK_AMT,MORTGAGE_AMT,ASSY_KB,GRP_CD,PARTS_NM_CD,RECOGNIZER_QL,UPD_KB,O_CATALOG_NO,REPETITION_KB," + _
                                                             "CRT_DT,CRT_TIME,CRT_USR,UPD_DT,UPD_TIME,UPD_USR,UPD_PROGRAM_ID,SURPLUS_STOP_FLG" + _
                                                             ") VALUES (" + _
                                                             ":F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
                                                             ":F11,:F12,:F13,:F14,:F15,:F16,:F17,:F18,:F19,:F20," + _
                                                             ":F21,:F22,:F23,:F24,:F25,:F26,:F27,:F28)"         '停止区分追加 

                            _oDatabase.CreateParam("F01", s.Substring(0, 14).Trim())        'CATALOG_NO 
                            _oDatabase.CreateParam("F02", s.Substring(20, 2).Trim())        'C_NO 
                            _oDatabase.CreateParam("F03", s.Substring(22, 3).Trim())        'M_SECTION_CD 
                            _oDatabase.CreateParam("F04", s.Substring(25, 13).Trim())       'SKETCH_NO 
                            _oDatabase.CreateParam("F05", s.Substring(38, 6).Trim())        'COMPANY_NO 
                            _oDatabase.CreateParam("F06", s.Substring(66, 15).Trim())       'MATL_CD 
                            _oDatabase.CreateParam("F07", s.Substring(85, 7).Trim() / 10)   'MATL_WAT 
                            _oDatabase.CreateParam("F08", s.Substring(92, 1).Trim())        '材料UNIT_KB 
                            _oDatabase.CreateParam("F09", s.Substring(93, 7).Trim() / 10)   'UNIT_MATL_WAT 
                            _oDatabase.CreateParam("F10", s.Substring(121, 9).Trim())       'TERM_STOCK_AMT 
                            _oDatabase.CreateParam("F11", s.Substring(130, 9).Trim())       'LMSTOCK_AMT 
                            _oDatabase.CreateParam("F12", s.Substring(139, 9).Trim())       'STOCK_AMT 
                            _oDatabase.CreateParam("F13", s.Substring(148, 9).Trim())       'MORTGAGE_AMT 
                            _oDatabase.CreateParam("F14", s.Substring(159, 1).Trim())       'ASSY_KB 
                            _oDatabase.CreateParam("F15", s.Substring(160, 1).Trim())       'GRP_CD 
                            _oDatabase.CreateParam("F16", s.Substring(163, 2).Trim())       'PARTS_NM_CD 
                            If s.Substring(20, 2).Equals("Y1") Or s.Substring(20, 2).Equals("Y2") Or s.Substring(20, 2).Equals("W2") Then
                                _oDatabase.CreateParam("F17", "*")
                            Else
                                _oDatabase.CreateParam("F17", "")                           'RECOGNIZER_QL 
                            End If
                            If s.Substring(20, 2).Equals("Y1") Or s.Substring(20, 2).Equals("Y2") Or s.Substring(20, 2).Equals("W2") Then
                                _oDatabase.CreateParam("F18", "0")
                            Else
                                _oDatabase.CreateParam("F18", "1")                          'UPD_KB 
                            End If
                            _oDatabase.CreateParam("F19", s.Substring(0, 14).Trim())        'O_CATALOG_NO 
                            _oDatabase.CreateParam("F20", s.Substring(189, 1).Trim())       'REPETITION_KB 
                            _oDatabase.CreateParam("F21", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F22", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F23", Session("UserID"))
                            _oDatabase.CreateParam("F24", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F25", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F26", Session("UserID"))
                            _oDatabase.CreateParam("F27", MedicalLib.Common.ProgramID)
                            _oDatabase.CreateParam("F28", "0")                              '停止区分
                            _oDatabase.ExecuteNonQueryParam(sQuery)


                            '**** 2010/08/27 修正理由対応 ST ****
                            If s.Substring(20, 2).Equals("Y1") Or s.Substring(20, 2).Equals("Y2") Or s.Substring(20, 2).Equals("W2") Then
                            Else
                                '修正中で登録した時、修正理由も登録する

                                sQuery = ""
                                sQuery += "INSERT INTO PARTS_UPDATE_REASON_TBL"
                                sQuery += " (CATALOG_NO, UPD_DATETIME, UPDATE_REASON, UPDATOR"
                                sQuery += ", CRT_DT, CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR, UPD_PROGRAM_ID"
                                sQuery += " ) VALUES ("
                                sQuery += "  :F01, :F02, :F03, :F04"
                                sQuery += ", :F05, :F06, :F07, :F08, :F09, :F10, :F11"
                                sQuery += " )"
                                _oDatabase.CreateParam("F01", s.Substring(0, 14).Trim())
                                _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate & MedicalLib.Common.GetSystemTime)
                                _oDatabase.CreateParam("F03", "00")
                                _oDatabase.CreateParam("F04", Session("UserID"))
                                _oDatabase.CreateParam("F05", MedicalLib.Common.GetSystemDate)
                                _oDatabase.CreateParam("F06", MedicalLib.Common.GetSystemTime)
                                _oDatabase.CreateParam("F07", Session("UserID"))
                                _oDatabase.CreateParam("F08", MedicalLib.Common.GetSystemDate)
                                _oDatabase.CreateParam("F09", MedicalLib.Common.GetSystemTime)
                                _oDatabase.CreateParam("F10", Session("UserID"))
                                _oDatabase.CreateParam("F11", MedicalLib.Common.ProgramID)

                                _oDatabase.ExecuteNonQueryParam(sQuery)
                            End If
                            '**** 2010/08/27 修正理由対応 ED ****

                        Case "update"
                            sQuery = "UPDATE PARTS_MST SET C_NO=:F01,M_SECTION_CD=:F02,COMPANY_NO=:F03,TERM_STOCK_AMT=:F04,LMSTOCK_AMT=:F05," + _
                                                            "STOCK_AMT=:F06,MORTGAGE_AMT=:F07,ASSY_KB=:F08,PARTS_NM_CD=:F09,REPETITION_KB=:F10," + _
                                                            "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 " + _
                                                            "WHERE CATALOG_NO = :K01"

                            _oDatabase.CreateParam("F01", s.Substring(20, 2).Trim())
                            _oDatabase.CreateParam("F02", s.Substring(22, 3).Trim())
                            _oDatabase.CreateParam("F03", s.Substring(38, 6).Trim())
                            _oDatabase.CreateParam("F04", s.Substring(121, 9).Trim())  'TERM_STOCK_AMT
                            _oDatabase.CreateParam("F05", s.Substring(130, 9).Trim())  'LMSTOCK_AMT
                            _oDatabase.CreateParam("F06", s.Substring(139, 9).Trim())  'STOCK_AMT
                            _oDatabase.CreateParam("F07", s.Substring(148, 9).Trim())  'MORTGAGE_AMT
                            _oDatabase.CreateParam("F08", s.Substring(159, 1).Trim())
                            _oDatabase.CreateParam("F09", s.Substring(163, 2).Trim())
                            _oDatabase.CreateParam("F10", s.Substring(189, 1).Trim())
                            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
                            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
                            _oDatabase.CreateParam("F13", Session("UserID"))
                            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
                            _oDatabase.CreateParam("K01", s.Substring(0, 14).Trim())

                            _oDatabase.ExecuteNonQueryParam(sQuery)
                        Case "next"

                    End Select
                End If
            End While
            _oDatabase.CommitTrans() 
        Catch ex As Exception 
            _oDatabase.Rollback() 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            sr.Close() 
        End Try 

        If blnErr = False Then
            lblMessage.Text = "部品マスタ取込が完了しました"
        Else
            lblMessage.ForeColor = Color.Red
        End If

    End Sub 
 
    Private Function checkBuhin(ByVal key As String, ByVal kumi As String, ByVal shanai As String, ByVal assy As String, ByVal group As String) As String 
 
        Dim sQuery As String = "" 
        Dim temp As String = "" 
        sQuery += "SELECT C_NO,COMPANY_NO,ASSY_KB,GRP_CD FROM PARTS_MST " 
        sQuery += "WHERE CATALOG_NO = :K01" 
        Try 
            _oDatabase.CreateParam("K01", key) 
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery) 
            If oReader.Read() Then 
                If kumi.Equals(oReader.Item("C_NO")) And shanai.Equals(oReader.Item("COMPANY_NO")) And assy.Equals(oReader.Item("ASSY_KB")) And group.Equals(oReader.Item("GRP_CD")) Then 
                    temp = "next" 
                Else 
                    temp = "update" 
                End If 
            Else 
                temp = "insert" 
            End If 
 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        Return temp 
    End Function 
 
#End Region 
 
End Class 
