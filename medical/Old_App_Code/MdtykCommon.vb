Imports System.Data
Imports System.Data.OracleClient
Imports System.IO
Imports System.Text
Imports GrapeCity.ActiveReports
Imports System.Web
Imports System
Imports System.Configuration
Imports Microsoft.VisualBasic

Public Class mdtyk

    Private Shared sProgramID As String = ""

    Public Class mdtyk020common

        Private _oDatabase As MedicalLib.DataAccess
        'Private _oSQLServer As MedicalLib.DataSQLserver

        '**** 2010/03 着工者追加 ST ****
        Private _Tyakkousha As String = ""
        Public WriteOnly Property Tyakkousha() As String
            Set(ByVal value As String)
                _Tyakkousha = value
            End Set
        End Property
        '**** 2010/03 着工者追加 ED ****

        '**** 2010/08/05 セッションID追加 ST ****
        Private _sessionID As String = ""
        Public WriteOnly Property SessionID() As String
            Set(ByVal value As String)
                _sessionID = value
            End Set
        End Property
        '**** 2010/08/05 セッションID追加 ED ****

        Public Sub New(ByVal oDatabase As MedicalLib.DataAccess)
            _oDatabase = oDatabase
            '_oSQLServer = New MedicalLib.DataSQLserver
        End Sub

        Public Function PrintList() As Boolean
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Dim nPrint As Boolean = False
            Dim sKey As New StringBuilder
            Try

                sProgramID = MedicalLib.Common.ProgramID
                sQuery = "SELECT A.INDICATE_NO,A.COMPANY_NO,B.WORK_STD_NO,C.C_NO,C.MATL_CD "
                sQuery += "FROM PROCESS_F_TBL A,PARTS_MST B,INDICATE_TBL C "
                sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO AND (A.INDICATE_NO = C.INDICATE_NO AND A.COMPANY_NO = C.COMPANY_NO) AND A.END_KB = '0' "

                '**** 2010/03 着工者追加 ST ****
                If _Tyakkousha <> "" Then
                    sQuery += " AND A.CRT_USR = :K01 "
                End If
                sQuery += "ORDER BY A.CRT_USR, A.CATALOG_NO, A.INDICATE_NO"
                If _Tyakkousha <> "" Then
                    _oDatabase.CreateParam("K01", _Tyakkousha)
                    oReader = _oDatabase.CreateReaderParam(sQuery)
                Else
                    oReader = _oDatabase.CreateReader(sQuery)
                End If
                'sQuery += "ORDER BY A.COMPANY_NO,A.INDICATE_NO"
                'oReader = _oDatabase.CreateReader(sQuery)
                '**** 2010/03 着工者追加 ED ****
                While oReader.Read()
                    PrintList(False, GetString(oReader, 0), GetString(oReader, 1), GetString(oReader, 2), GetString(oReader, 3), GetString(oReader, 4))
                    '###### 2015/08/28 工程票重複対応 ST #####
                    'sKey.Append(GetString(oReader, 0) + "," + GetString(oReader, 1) + Chr(9))
                    'sKey.Append(GetString(oReader, 0) + "," + GetString(oReader, 1) + ControlChars.Tab)
                    'nPrint = True
                    sQuery = "UPDATE PROCESS_F_TBL SET "
                    sQuery += "END_KB = :F01,"
                    sQuery += "UPD_DT = :F02,"
                    sQuery += "UPD_TIME = :F03,"
                    sQuery += "UPD_USR = :F04,"
                    sQuery += "UPD_PROGRAM_ID = :F05 "
                    sQuery += "WHERE INDICATE_NO = :K01 AND COMPANY_NO = :K02"
                    _oDatabase.CreateParam("F01", "1")
                    _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F04", HttpContext.Current.Session("UserID"))
                    '_oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                    _oDatabase.CreateParam("F05", sProgramID)
                    _oDatabase.CreateParam("K01", GetString(oReader, 0))
                    _oDatabase.CreateParam("K02", GetString(oReader, 1))
                    _oDatabase.ExecuteNonQueryParam(sQuery)
                    '###### 2015/08/28 工程票重複対応 ED #####
                End While
                oReader.Close()
                '###### 2015/08/28 工程票重複対応 ST #####
                'Try
                '    _oDatabase.BeginTrans()
                '    Dim sRow() As String = sKey.ToString.Split(Chr(9))
                '    For i As Integer = 0 To sRow.Length - 2
                '        Dim sCode() As String = sRow(i).Split(",")
                '        sQuery = "UPDATE PROCESS_F_TBL SET "
                '        sQuery += "END_KB = :F01,"
                '        sQuery += "UPD_DT = :F02,"
                '        sQuery += "UPD_TIME = :F03,"
                '        sQuery += "UPD_USR = :F04,"
                '        sQuery += "UPD_PROGRAM_ID = :F05 "
                '        sQuery += "WHERE INDICATE_NO = :K01 AND COMPANY_NO = :K02"
                '        _oDatabase.CreateParam("F01", "1")
                '        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                '        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                '        _oDatabase.CreateParam("F04", HttpContext.Current.Session("UserID"))
                '        '_oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                '        _oDatabase.CreateParam("F05", sProgramID)
                '        _oDatabase.CreateParam("K01", sCode(0))
                '        _oDatabase.CreateParam("K02", sCode(1))
                '        _oDatabase.ExecuteNonQueryParam(sQuery)
                '    Next
                '    _oDatabase.CommitTrans()
                'Catch ex As Exception
                '    _oDatabase.Rollback()
                '    Throw
                'End Try
                'Return nPrint
                nPrint = True
                '###### 2015/08/28 工程票重複対応 ED #####
            Catch ex As Exception
                Throw
            Finally
                oReader = Nothing
                '' ガベージコレクションを実行します。
                System.GC.Collect()
                '' ファイナライゼーションが終わるまでスレッド待機します。
                System.GC.WaitForPendingFinalizers()
            End Try
            Return nPrint
        End Function

        Public Sub PrintList(ByVal nRePrint As Boolean, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal sKanriNo As String, ByVal sKumiban As String, ByVal sSyuzairyo As String)
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Dim oReport As New mdtyk0201
            Dim iPages As Integer = 0

            Try
                '工程票 
                mdtyk0201(oReport, nRePrint, sSijiNo, sSyanaiNo)
                If Not sKumiban.Trim.Equals("W2") Then
                    '製品図面 
                    mdtyk0202(oReport, sSijiNo, sSyanaiNo, sKanriNo)
                    '加工図面 
                    mdtyk0203(oReport, sSijiNo, sSyanaiNo, sKanriNo)
                    '試験・検査表 
                    mdtyk0204(oReport, sSijiNo, sSyanaiNo, sKanriNo)
                    'プログラム管理表 
                    mdtyk0205(oReport, sSyanaiNo)
                End If
                If Not sSyuzairyo.Trim.Equals("") Then

                    '**** 2009/04/14 START ****
                    '****** 自動引当を削除したデータだと主材料出庫票が 0件になりエラーが発生するので
                    '****** チェック処理追加
                    If checkHikisate(sSijiNo, sSyanaiNo) Then

                        '主材料出庫票 
                        mdtyk0206(oReport, nRePrint, sSijiNo, sSyanaiNo)
                    End If
                    '**** 2009/04/14 END ******

                End If
                iPages = oReport.Document.Pages.Count
                Call KouteihyoLog(nRePrint, sSijiNo, sSyanaiNo, sKanriNo, iPages)
                oReport.Document.Print(False, False, False)
            Catch ex As Exception
                Throw
            Finally
                '' レポートインスタンスをDisposeします。
                'oReport.Document.Dispose()
                'oReport.Dispose()
                oReport = Nothing
                '' ガベージコレクションを実行します。
                'System.GC.Collect()
                '' ファイナライゼーションが終わるまでスレッド待機します。
                'System.GC.WaitForPendingFinalizers()
            End Try
        End Sub

        '**** 2010/03 ページ指定 ST ****
        Public Sub PrintList(ByVal nRePrint As Boolean, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal sKanriNo As String, ByVal sKumiban As String, ByVal sSyuzairyo As String,
                             ByVal sSeihin As String, ByVal sKakou As String, ByVal sSiken As String)

            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Dim oReport As New mdtyk0201
            Dim iPages As Integer = 0

            Try
                '製品図面 
                If sSeihin.Replace("0", "") <> "" Then
                    mdtyk0202(oReport, sSijiNo, sSyanaiNo, sKanriNo,
                              sSeihin)
                End If

                '加工図面 
                If sKakou.Replace("0", "") <> "" Then
                    mdtyk0203(oReport, sSijiNo, sSyanaiNo, sKanriNo,
                              sKakou)
                End If

                '試験・検査表 
                If sSiken.Replace("0", "") <> "" Then
                    mdtyk0204(oReport, sSijiNo, sSyanaiNo, sKanriNo,
                              sSiken)
                End If
                iPages = oReport.Document.Pages.Count
                Call KouteihyoLog(nRePrint, sSijiNo, sSyanaiNo, sKanriNo, iPages)
                'oReport.
            Catch ex As Exception
                Throw
            Finally
                '' レポートインスタンスをDisposeします。
                'oReport.Document.Dispose()
                'oReport.Dispose()
                oReport = Nothing
                '' ガベージコレクションを実行します。
                'System.GC.Collect()
                '' ファイナライゼーションが終わるまでスレッド待機します。
                'System.GC.WaitForPendingFinalizers()
            End Try
        End Sub
        '**** 2010/03 ページ指定 ED ****


#Region " 各種帳票 "

        '工程票 
        Private Sub mdtyk0201(ByRef oReport As mdtyk0201, ByVal nRePrint As Boolean, ByVal sSijiNo As String, ByVal sSyanaiNo As String)
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Try
                sQuery = "SELECT B.O_CATALOG_NO,B.CATALOG_NO,B.WORK_STD_NO,A.COMPANY_NO,A.INDICATE_NO,C.C_NO,C.OEM_FLG,C.FIRST_KB,C.USE_ORG_PARTS_NO,C.ORIGIN_PARTS_NO,D.REN_NO,D.MATL_NM,D.MATL_SPEC,C.MATL_CD,C.DELIVERY_DT,C.COMP_NEED_AMT,C.STW_AMT,E.ITEM_NM テストピース,T.ITEM_NM 梱包ラベル,F.WORKER_ABB 着工者,G.WORKER_ABB 承認品管,H.WORKER_ABB 承認技術,I.WORKER_ABB 点検,J.WORKER_ABB 作成,K.COR_MARK COR_MARK2,L.COR_MARK COR_MARK1,M.COR_MARK COR_MARK4,N.COR_MARK COR_MARK3,O.COR_MARK COR_MARK5,P.UM_P_ORDER,P.P_ORDER_MAIN,P.P_ORDER_SUB,P.SHOP,Q.ITEM_NM 設備集約名称,R.P_ORDER_NM,S.ITEM_KN WORK_STD,P.WORK_COMMENT,L.COR_ARTICLE_NO,L.APPLY_DT,L.CREATOR_NM,L.RECOGNIZER_NM "
                sQuery += "FROM PROCESS_F_TBL A,PARTS_MST B,INDICATE_TBL C,MATL_MST D,"
                sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS005') E,"
                sQuery += "WORKER_MST F,WORKER_MST G,WORKER_MST H,WORKER_MST I,WORKER_MST J,"
                sQuery += "(SELECT CATALOG_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '2' ) K,"
                sQuery += "(SELECT CATALOG_NO,COR_MARK,COR_ARTICLE_NO,APPLY_DT,CREATOR_NM,RECOGNIZER_NM FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '1' ) L,"
                sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4' ) M,"
                sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '3' ) N,"
                sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '5' ) O,"
                sQuery += "(SELECT * FROM PROCESS_PROGRESS_TBL WHERE P_ORDER_MAIN < 900) P,"
                sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025') Q,"
                sQuery += "PROCESS_MST R,"
                sQuery += "(SELECT TELL_CD,ITEM_KN FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS027') S,"
                sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS006') T "
                sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO AND "
                sQuery += "(A.INDICATE_NO = C.INDICATE_NO AND A.COMPANY_NO = C.COMPANY_NO) AND "
                sQuery += "C.MATL_CD = D.MATL_CD(+) AND "
                sQuery += "B.TPERS_AMT = E.TELL_CD(+) AND "
                sQuery += "C.CRT_USR = F.WORKER_CD(+) AND "
                sQuery += "B.RECOGNIZER_QL = G.WORKER_CD(+) AND "
                sQuery += "B.RECOGNIZER_SK = H.WORKER_CD(+) AND "
                sQuery += "B.CHECKER = I.WORKER_CD(+) AND "
                sQuery += "B.CREATOR = J.WORKER_CD(+) AND "
                sQuery += "A.CATALOG_NO = K.CATALOG_NO(+) AND "
                sQuery += "A.CATALOG_NO = L.CATALOG_NO(+) AND "
                sQuery += "A.PROSTD_NO = M.PROSTD_NO(+) AND "
                sQuery += "A.PROSTD_NO = N.PROSTD_NO(+) AND "
                sQuery += "A.PROSTD_NO = O.PROSTD_NO(+) AND "
                sQuery += "(A.INDICATE_NO = P.INDICATE_NO AND A.COMPANY_NO = P.COMPANY_NO) AND "
                sQuery += "P.FACILITIES_G_CD = Q.TELL_CD(+) AND "
                sQuery += "P.PROCESS_CD = R.PROCESS_CD(+) AND "
                sQuery += "R.WORK_STD = S.TELL_CD(+) AND "
                sQuery += "B.PACKUP_KB = T.TELL_CD(+) AND "
                sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02 "
                sQuery += "ORDER BY P.P_ORDER_MAIN,P.P_ORDER_SUB"
                _oDatabase.CreateParam("K01", sSijiNo)
                _oDatabase.CreateParam("K02", sSyanaiNo)
                Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
                oReport.DataSource = oDataSet1
                oReport.DataMember = "TB1"
                oReport.MedicalDNS = ConfigurationManager.ConnectionStrings("MedicalDB").ToString()
                oReport.HonsyaDNS = ConfigurationManager.ConnectionStrings("HonsyaDB").ToString()
                oReport.RePrint = nRePrint
                oReport.Run(True)
                'oReport.Document.Print(False, False) 
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '製品図面 
        Private Sub mdtyk0202(ByRef oMReport As mdtyk0201, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal sKanriNo As String)
            Dim sQuery As String = ""
            Try
                Dim sFileName As String = "S" + sKanriNo.Replace("-", "") + "*.tif"
                Dim oDirectory As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(MedicalLib.Common.GetEnv("SeihinZumen"))
                Dim oFile As System.IO.FileInfo() = oDirectory.GetFiles(sFileName)
                '**** 2010/08/05 TIFをワークにコピー ST ****
                'コピー先フォルダ作成
                Dim sWorkDir As String = PrepareWork(oDirectory.FullName)
                '**** 2010/08/05 TIFをワークにコピー ED ****
                For i As Integer = 0 To oFile.Length - 1
                    sQuery = "SELECT B.O_CATALOG_NO,A.INDICATE_NO,C.COR_MARK "
                    sQuery += "FROM PROCESS_F_TBL A,PARTS_MST B,"
                    sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '3' ) C "
                    sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO(+) AND "
                    sQuery += "A.PROSTD_NO = C.PROSTD_NO(+) AND "
                    sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                    _oDatabase.CreateParam("K01", sSijiNo)
                    _oDatabase.CreateParam("K02", sSyanaiNo)
                    Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")

                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    IO.File.Copy(oFile(i).FullName,
                                 sWorkDir & IO.Path.GetFileName(oFile(i).FullName))
                    oFile(i) = New IO.FileInfo(sWorkDir & IO.Path.GetFileName(oFile(i).FullName))
                    '**** 2010/08/05 TIFをワークにコピー ED ****

                    Dim oReport As New mdtyk0202
                    oReport.DataSource = oDataSet1
                    oReport.DataMember = "TB1"
                    oReport.ImageFile = oFile(i).FullName
                    oReport.Run(True)
                    'oReport.Document.Print(False, False) 
                    Dim nPage As Integer = oMReport.Document.Pages.Count
                    For j As Integer = 0 To oReport.Document.Pages.Count - 1
                        oMReport.Document.Pages.Insert(nPage, oReport.Document.Pages(j))
                        nPage += 1
                    Next
                Next
                '**** 2010/08/05 TIFをワークにコピー ST ****
                'ワークフォルダを削除
                Try
                    IO.Directory.Delete(sWorkDir, True)
                Catch ex As Exception
                End Try
                '**** 2010/08/05 TIFをワークにコピー ED ****
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '製品図面  ページ指定
        Private Sub mdtyk0202(ByRef oMReport As mdtyk0201, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal sKanriNo As String,
                              ByVal sSeihin As String)
            Dim sQuery As String = ""
            Try
                Dim sFileName As String = ""
                Dim oDirectory As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(MedicalLib.Common.GetEnv("SeihinZumen"))
                Dim iPage As Integer = 1

                If sSeihin <> "" Then

                    sQuery = "SELECT B.O_CATALOG_NO,A.INDICATE_NO,C.COR_MARK "
                    sQuery += "FROM PROCESS_F_TBL A,PARTS_MST B,"
                    sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '3' ) C "
                    sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO(+) AND "
                    sQuery += "A.PROSTD_NO = C.PROSTD_NO(+) AND "
                    sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                    _oDatabase.CreateParam("K01", sSijiNo)
                    _oDatabase.CreateParam("K02", sSyanaiNo)
                    Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")

                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    'コピー先フォルダ作成
                    Dim sWorkDir As String = PrepareWork(oDirectory.FullName)
                    '**** 2010/08/05 TIFをワークにコピー ED ****
                    For Each c As Char In sSeihin
                        If c = "1" Then
                            sFileName = "S" & sKanriNo.Replace("-", "") & iPage.ToString.PadLeft(2, "0"c) & ".tif"

                            '**** 2010/08/05 TIFをワークにコピー ST ****
                            IO.File.Copy(oDirectory.FullName & sFileName,
                                         sWorkDir & sFileName)
                            '**** 2010/08/05 TIFをワークにコピー ED ****

                            Dim oReport As New mdtyk0202
                            oReport.DataSource = oDataSet1
                            oReport.DataMember = "TB1"
                            oReport.ImageFile = sWorkDir & sFileName
                            'oReport.ImageFile = oDirectory.FullName & sFileName
                            oReport.Run(True)
                            'oReport.Document.Print(False, False) 
                            Dim nPage As Integer = oMReport.Document.Pages.Count
                            For j As Integer = 0 To oReport.Document.Pages.Count - 1
                                oMReport.Document.Pages.Insert(nPage, oReport.Document.Pages(j))
                                nPage += 1
                            Next
                        End If
                        iPage += 1
                    Next
                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    'ワークフォルダを削除
                    Try
                        IO.Directory.Delete(sWorkDir, True)
                    Catch ex As Exception
                    End Try
                    '**** 2010/08/05 TIFをワークにコピー ED ****
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '加工図面 
        Private Sub mdtyk0203(ByRef oMReport As mdtyk0201, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal sKanriNo As String)

            Dim sQuery As String = ""
            Try
                Dim sFileName As String = "K" + sKanriNo.Replace("-", "") + "*.tif"
                Dim oDirectory As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(MedicalLib.Common.GetEnv("KakoZu"))
                Dim oFile As System.IO.FileInfo() = oDirectory.GetFiles(sFileName)
                '**** 2010/08/05 TIFをワークにコピー ST ****
                'コピー先フォルダ作成
                Dim sWorkDir As String = PrepareWork(oDirectory.FullName)
                '**** 2010/08/05 TIFをワークにコピー ED ****
                For i As Integer = 0 To oFile.Length - 1
                    sQuery = "SELECT B.O_CATALOG_NO,A.INDICATE_NO,C.COR_MARK,B.MEASURE_KB01,B.MEASURE_01,B.MEASURE_KB02,B.MEASURE_02,B.MEASURE_KB03,B.MEASURE_03,B.MEASURE_KB04,B.MEASURE_04,B.MEASURE_KB05,B.MEASURE_05,B.MEASURE_KB06,B.MEASURE_06,B.MEASURE_KB07,B.MEASURE_07,B.MEASURE_KB08,B.MEASURE_08,B.MEASURE_KB09,B.MEASURE_09,B.MEASURE_KB10,B.MEASURE_10 "
                    sQuery += "FROM PROCESS_F_TBL A,PARTS_MST B,"
                    sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4' ) C "
                    sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO(+) AND "
                    sQuery += "A.PROSTD_NO = C.PROSTD_NO(+) AND "
                    sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                    _oDatabase.CreateParam("K01", sSijiNo)
                    _oDatabase.CreateParam("K02", sSyanaiNo)
                    Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")

                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    IO.File.Copy(oFile(i).FullName,
                                 sWorkDir & IO.Path.GetFileName(oFile(i).FullName))
                    oFile(i) = New IO.FileInfo(sWorkDir & IO.Path.GetFileName(oFile(i).FullName))
                    '**** 2010/08/05 TIFをワークにコピー ED ****

                    Dim oReport As New mdtyk0203
                    oReport.DataSource = oDataSet1
                    oReport.DataMember = "TB1"
                    oReport.ImageFile = oFile(i).FullName
                    oReport.ShowSunpou = (i = 0)
                    oReport.Run(True)
                    'oReport.Document.Print(False, False) 
                    Dim nPage As Integer = oMReport.Document.Pages.Count
                    For j As Integer = 0 To oReport.Document.Pages.Count - 1
                        oMReport.Document.Pages.Insert(nPage, oReport.Document.Pages(j))
                        nPage += 1
                    Next
                Next
                '**** 2010/08/05 TIFをワークにコピー ST ****
                'ワークフォルダを削除
                Try
                    IO.Directory.Delete(sWorkDir, True)
                Catch ex As Exception
                End Try
                '**** 2010/08/05 TIFをワークにコピー ED ****
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '加工図面 ページ指定
        Private Sub mdtyk0203(ByRef oMReport As mdtyk0201, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal sKanriNo As String,
                              ByVal sKakou As String)
            Dim sQuery As String = ""
            Try
                Dim sFileName As String = ""
                Dim oDirectory As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(MedicalLib.Common.GetEnv("KakoZu"))
                Dim iPage As Integer = 1

                If sKakou <> "" Then

                    sQuery = "SELECT B.O_CATALOG_NO,A.INDICATE_NO,C.COR_MARK,B.MEASURE_KB01,B.MEASURE_01,B.MEASURE_KB02,B.MEASURE_02,B.MEASURE_KB03,B.MEASURE_03,B.MEASURE_KB04,B.MEASURE_04,B.MEASURE_KB05,B.MEASURE_05,B.MEASURE_KB06,B.MEASURE_06,B.MEASURE_KB07,B.MEASURE_07,B.MEASURE_KB08,B.MEASURE_08,B.MEASURE_KB09,B.MEASURE_09,B.MEASURE_KB10,B.MEASURE_10 "
                    sQuery += "FROM PROCESS_F_TBL A,PARTS_MST B,"
                    sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4' ) C "
                    sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO(+) AND "
                    sQuery += "A.PROSTD_NO = C.PROSTD_NO(+) AND "
                    sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                    _oDatabase.CreateParam("K01", sSijiNo)
                    _oDatabase.CreateParam("K02", sSyanaiNo)
                    Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")

                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    'コピー先フォルダ作成
                    Dim sWorkDir As String = PrepareWork(oDirectory.FullName)
                    '**** 2010/08/05 TIFをワークにコピー ED ****

                    For Each c As Char In sKakou
                        If c = "1" Then
                            sFileName = "K" & sKanriNo.Replace("-", "") & iPage.ToString.PadLeft(2, "0"c) & ".tif"

                            '**** 2010/08/05 TIFをワークにコピー ST ****
                            IO.File.Copy(oDirectory.FullName & sFileName,
                                         sWorkDir & sFileName)
                            '**** 2010/08/05 TIFをワークにコピー ED ****

                            Dim oReport As New mdtyk0203
                            oReport.DataSource = oDataSet1
                            oReport.DataMember = "TB1"
                            oReport.ImageFile = sWorkDir & sFileName
                            'oReport.ImageFile = oDirectory.FullName & sFileName
                            oReport.ShowSunpou = (iPage = 1)
                            oReport.Run(True)
                            'oReport.Document.Print(False, False) 
                            Dim nPage As Integer = oMReport.Document.Pages.Count
                            For j As Integer = 0 To oReport.Document.Pages.Count - 1
                                oMReport.Document.Pages.Insert(nPage, oReport.Document.Pages(j))
                                nPage += 1
                            Next
                        End If
                        iPage += 1
                    Next
                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    'ワークフォルダを削除
                    Try
                        IO.Directory.Delete(sWorkDir, True)
                    Catch ex As Exception
                    End Try
                    '**** 2010/08/05 TIFをワークにコピー ED ****
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '試験・検査表 
        Private Sub mdtyk0204(ByRef oMReport As mdtyk0201, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal sKanriNo As String)
            Dim sQuery As String = ""
            Try
                Dim sFileName As String = "I" + sKanriNo.Replace("-", "") + "*.tif"
                Dim oDirectory As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(MedicalLib.Common.GetEnv("SikenKensaHyo"))
                Dim oFile As System.IO.FileInfo() = oDirectory.GetFiles(sFileName)

                '**** 2010/08/05 TIFをワークにコピー ST ****
                'コピー先フォルダ作成
                Dim sWorkDir As String = PrepareWork(oDirectory.FullName)
                '**** 2010/08/05 TIFをワークにコピー ED ****

                For i As Integer = 0 To oFile.Length - 1
                    '**** 2010/04 材料ロットNO 追加 ST ****
                    sQuery = ""
                    sQuery += "SELECT B.O_CATALOG_NO, A.INDICATE_NO, C.COR_MARK"
                    sQuery += "     , IT.USE_ORG_PARTS_NO, IT.ORIGIN_PARTS_NO, MM.REN_NO, IT.MATL_CD"
                    sQuery += "     , IT.INDICATE_NO, IT.COMPANY_NO"
                    sQuery += "  FROM PROCESS_F_TBL A"
                    sQuery += "     , PARTS_MST B"
                    sQuery += "     , (SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4' ) C"
                    sQuery += "     , INDICATE_TBL IT"
                    sQuery += "     , MATL_MST MM"
                    sQuery += " WHERE A.CATALOG_NO = B.CATALOG_NO(+)"
                    sQuery += "   AND A.PROSTD_NO = C.PROSTD_NO(+)"
                    sQuery += "   AND A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                    sQuery += "   AND A.INDICATE_NO = IT.INDICATE_NO AND A.COMPANY_NO = IT.COMPANY_NO"
                    sQuery += "   AND IT.MATL_CD = MM.MATL_CD(+)"

                    'sQuery = "SELECT B.O_CATALOG_NO,A.INDICATE_NO,C.COR_MARK "
                    'sQuery += "FROM PROCESS_F_TBL A,PARTS_MST B,"
                    'sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4' ) C "
                    'sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO(+) AND "
                    'sQuery += "A.PROSTD_NO = C.PROSTD_NO(+) AND "
                    'sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                    '**** 2010/04 材料ロットNO 追加 ED ****
                    _oDatabase.CreateParam("K01", sSijiNo)
                    _oDatabase.CreateParam("K02", sSyanaiNo)
                    Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")

                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    IO.File.Copy(oFile(i).FullName,
                                 sWorkDir & IO.Path.GetFileName(oFile(i).FullName))
                    oFile(i) = New IO.FileInfo(sWorkDir & IO.Path.GetFileName(oFile(i).FullName))
                    '**** 2010/08/05 TIFをワークにコピー ED ****

                    Dim oReport As New mdtyk0204
                    oReport.MedicalDNS = ConfigurationManager.ConnectionStrings("MedicalDB").ToString()
                    oReport.DataSource = oDataSet1
                    oReport.DataMember = "TB1"
                    oReport.ImageFile = oFile(i).FullName
                    oReport.Run(True)
                    'oReport.Document.Print(False, False) 
                    Dim nPage As Integer = oMReport.Document.Pages.Count
                    For j As Integer = 0 To oReport.Document.Pages.Count - 1
                        oMReport.Document.Pages.Insert(nPage, oReport.Document.Pages(j))
                        nPage += 1
                    Next
                Next
                '**** 2010/08/05 TIFをワークにコピー ST ****
                'ワークフォルダを削除
                Try
                    IO.Directory.Delete(sWorkDir, True)
                Catch ex As Exception
                End Try
                '**** 2010/08/05 TIFをワークにコピー ED ****
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '試験・検査表 ページ指定
        Private Sub mdtyk0204(ByRef oMReport As mdtyk0201, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal sKanriNo As String,
                              ByVal sSiken As String)
            Dim sQuery As String = ""
            Try

                Dim sFileName As String = ""
                Dim oDirectory As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(MedicalLib.Common.GetEnv("SikenKensaHyo"))
                Dim iPage As Integer = 1

                If sSiken <> "" Then

                    '**** 2010/04 材料ロットNO 追加 ST ****
                    sQuery = ""
                    sQuery += "SELECT B.O_CATALOG_NO, A.INDICATE_NO, C.COR_MARK"
                    sQuery += "     , IT.USE_ORG_PARTS_NO, IT.ORIGIN_PARTS_NO, MM.REN_NO, IT.MATL_CD"
                    sQuery += "     , IT.INDICATE_NO, IT.COMPANY_NO"
                    sQuery += "  FROM PROCESS_F_TBL A"
                    sQuery += "     , PARTS_MST B"
                    sQuery += "     , (SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4' ) C"
                    sQuery += "     , INDICATE_TBL IT"
                    sQuery += "     , MATL_MST MM"
                    sQuery += " WHERE A.CATALOG_NO = B.CATALOG_NO(+)"
                    sQuery += "   AND A.PROSTD_NO = C.PROSTD_NO(+)"
                    sQuery += "   AND A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                    sQuery += "   AND A.INDICATE_NO = IT.INDICATE_NO AND A.COMPANY_NO = IT.COMPANY_NO"
                    sQuery += "   AND IT.MATL_CD = MM.MATL_CD(+)"

                    'sQuery = "SELECT B.O_CATALOG_NO,A.INDICATE_NO,C.COR_MARK "
                    'sQuery += "FROM PROCESS_F_TBL A,PARTS_MST B,"
                    'sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4' ) C "
                    'sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO(+) AND "
                    'sQuery += "A.PROSTD_NO = C.PROSTD_NO(+) AND "
                    'sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                    '**** 2010/04 材料ロットNO 追加 ED ****
                    _oDatabase.CreateParam("K01", sSijiNo)
                    _oDatabase.CreateParam("K02", sSyanaiNo)
                    Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")

                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    'コピー先フォルダ作成
                    Dim sWorkDir As String = PrepareWork(oDirectory.FullName)
                    '**** 2010/08/05 TIFをワークにコピー ED ****

                    For Each c As Char In sSiken
                        If c = "1" Then
                            sFileName = "I" & sKanriNo.Replace("-", "") & iPage.ToString.PadLeft(2, "0"c) & ".tif"

                            '**** 2010/08/05 TIFをワークにコピー ST ****
                            IO.File.Copy(oDirectory.FullName & sFileName,
                                         sWorkDir & sFileName)
                            '**** 2010/08/05 TIFをワークにコピー ED ****

                            Dim oReport As New mdtyk0204
                            oReport.MedicalDNS = ConfigurationManager.ConnectionStrings("MedicalDB").ToString()
                            oReport.DataSource = oDataSet1
                            oReport.DataMember = "TB1"
                            oReport.ImageFile = sWorkDir & sFileName
                            'oReport.ImageFile = oDirectory.FullName & sFileName
                            oReport.Run(True)
                            'oReport.Document.Print(False, False) 
                            Dim nPage As Integer = oMReport.Document.Pages.Count
                            For j As Integer = 0 To oReport.Document.Pages.Count - 1
                                oMReport.Document.Pages.Insert(nPage, oReport.Document.Pages(j))
                                nPage += 1
                            Next
                        End If
                        iPage += 1
                    Next
                    '**** 2010/08/05 TIFをワークにコピー ST ****
                    'ワークフォルダを削除
                    Try
                        IO.Directory.Delete(sWorkDir, True)
                    Catch ex As Exception
                    End Try
                    '**** 2010/08/05 TIFをワークにコピー ED ****
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        'プログラム管理表 
        Private Sub mdtyk0205(ByRef oMReport As mdtyk0201, ByVal sSyanaiNo As String)
            Dim sQuery As String = ""
            Try
                sQuery = "SELECT CATALOG_NO,MACINING_NM,PROC_NM,PG_NO,PG_NM,L_VER,UPD_DT "
                sQuery += "FROM PG_MST "
                sQuery += "WHERE COMPANY_NO = '" + sSyanaiNo + "'"
                sQuery += "ORDER BY COMPANY_NO,MACINING_NM,PROC_ORD"
                Dim oDataSet1 As DataSet = _oDatabase.CreateDataSet(sQuery, "TB1")
                If oDataSet1.Tables("TB1").Rows.Count > 0 Then
                    Dim oReport As New mdtyk0205
                    oReport.DataSource = oDataSet1
                    oReport.DataMember = "TB1"
                    oReport.Run(True)
                    'oReport.Document.Print(False, False) 
                    Dim nPage As Integer = oMReport.Document.Pages.Count
                    For j As Integer = 0 To oReport.Document.Pages.Count - 1
                        oMReport.Document.Pages.Insert(nPage, oReport.Document.Pages(j))
                        nPage += 1
                    Next
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '主材料出庫票 
        Private Sub mdtyk0206(ByRef oMReport As mdtyk0201, ByVal nRePrint As Boolean, ByVal sSijiNo As String, ByVal sSyanaiNo As String)
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Try
                '###### 2010/10/05 材料計算修正 ######
                'sQuery = "SELECT A.INDICATE_NO INDICATE_NO1,D.O_CATALOG_NO,D.MATL_CD,D.REN_NO,D.C_NO,D.COMPANY_NO,D.INDICATE_NO INDICATE_NO2,B.STW_AMT,B.UNIT_MATL_WAT,B.MATL_KB,E.ITEM_KN 色識別,C.MAGNETISM,D.LOT_NO,D.SHELF_NO,D.S_SHELF_NO,F.ITEM_NM UNIT,G.WORKER_ABB 着工者,D.EXPEND_PLAN_DT "
                sQuery = "SELECT A.INDICATE_NO INDICATE_NO1,D.O_CATALOG_NO,D.MATL_CD,D.REN_NO,D.C_NO,D.COMPANY_NO,D.INDICATE_NO INDICATE_NO2,B.STW_AMT,B.MATL_KB,E.ITEM_KN 色識別,C.MAGNETISM,D.LOT_NO,D.SHELF_NO,D.S_SHELF_NO,F.ITEM_NM UNIT,G.WORKER_ABB 着工者,D.EXPEND_PLAN_DT "
                '**** 2010/06/16 材料径追加 ST ****
                sQuery += "    , CASE WHEN C.CONFIRM_SIZE_KB1 = '01' THEN C.CONFIRM_SIZE1"
                sQuery += "           WHEN C.CONFIRM_SIZE_KB2 = '01' THEN C.CONFIRM_SIZE2"
                sQuery += "           WHEN C.CONFIRM_SIZE_KB3 = '01' THEN C.CONFIRM_SIZE3"
                sQuery += "           WHEN C.CONFIRM_SIZE_KB4 = '01' THEN C.CONFIRM_SIZE4"
                sQuery += "           WHEN C.CONFIRM_SIZE_KB5 = '01' THEN C.CONFIRM_SIZE5"
                sQuery += "           ELSE 0"
                sQuery += "      END AS 材料径 "
                '**** 2010/06/16 材料径追加 ED ****
                sQuery += ", H.MATL_WAT ,H.UNIT_MATL_WAT "
                sQuery += "FROM PROCESS_F_TBL A,INDICATE_TBL B,MATL_MST C,MATL_MORTGAGE_TBL D,"
                sQuery += "(SELECT TELL_CD,ITEM_KN FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS002') E,"
                sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS004') F,"
                sQuery += "WORKER_MST G, PARTS_MST H "
                sQuery += "WHERE (A.INDICATE_NO = B.INDICATE_NO AND A.COMPANY_NO = B.COMPANY_NO) AND "
                sQuery += "B.MATL_CD = C.MATL_CD AND "
                sQuery += "(C.REN_NO = D.REN_NO AND B.MATL_CD = D.MATL_CD AND B.INDICATE_NO = D.INDICATE_NO AND B.COMPANY_NO = D.COMPANY_NO) AND "
                sQuery += "C.MATL_TYPE_CD = E.TELL_CD(+) AND "
                sQuery += "C.UNIT_KB = F.TELL_CD(+) AND "
                sQuery += "B.CRT_USR = G.WORKER_CD(+) AND "
                sQuery += "B.M_PARTS_NO = H.CATALOG_NO(+) AND "
                sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02"
                '###### 2010/10/05 材料計算修正 ######
                _oDatabase.CreateParam("K01", sSijiNo)
                _oDatabase.CreateParam("K02", sSyanaiNo)
                Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
                Dim oReport As New mdtyk0206
                oReport.DataSource = oDataSet1
                oReport.DataMember = "TB1"
                oReport.RePrint = nRePrint
                oReport.Run(True)
                'oReport.Document.Print(False, False) 
                Dim nPage As Integer = oMReport.Document.Pages.Count
                For j As Integer = 0 To oReport.Document.Pages.Count - 1
                    oMReport.Document.Pages.Insert(nPage, oReport.Document.Pages(j))
                    nPage += 1
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        'ワークフォルダ準備
        Private Function PrepareWork(ByVal sPath As String) As String

            Dim sWorkDir As String
            If sPath.Substring(sPath.Length - 1, 1) = "\" Then
                sWorkDir = sPath & _sessionID & "\"
            Else
                sWorkDir = sPath & "\" & _sessionID & "\"
            End If

            'ワークフォルダ作成
            If Not IO.Directory.Exists(sWorkDir) Then
                IO.Directory.CreateDirectory(sWorkDir)
            End If

            Return sWorkDir
        End Function

        'ログ 
        Private Sub KouteihyoLog(ByVal nRePrint As Boolean, ByVal sSijiNo As String,
                                        ByVal sSyanaiNo As String, ByVal sKanriNo As String,
                                        ByVal iPages As Integer)

            Dim oSWrite As StreamWriter = Nothing
            Dim strPath As String = ""
            Dim strSai As String = ""

            Try
                strPath = HttpContext.Current.Server.MapPath("~/log/Kouteihyo.Log")
                If nRePrint = True Then strSai = "再"
                oSWrite = New StreamWriter(strPath, True, Encoding.GetEncoding("Shift_JIS"))
                oSWrite.WriteLine(_oDatabase.GetSysDate.ToString("yyyy/MM/dd HH:mm:ss") + "," + sSijiNo + "," + sSyanaiNo + "," + sKanriNo + "," + iPages.ToString + "," + strSai)
            Catch ex As Exception
                Throw ex
            Finally
                If Not oSWrite Is Nothing Then oSWrite.Close()
            End Try
        End Sub

#End Region

#Region " チェック処理 "

        '引当チェック   2009/04/14 追加
        Private Function checkHikisate(ByVal sSijiNo As String, ByVal sSyanaiNo As String) As Boolean

            checkHikisate = False

            Dim sQuery As String = ""
            sQuery += "SELECT IT.MATL_CD"
            sQuery += "  FROM INDICATE_TBL IT , MATL_MST MM , MATL_MORTGAGE_TBL MT"
            sQuery += " WHERE IT.MATL_CD = MM.MATL_CD "
            sQuery += "   AND (MM.REN_NO = MT.REN_NO AND IT.MATL_CD = MT.MATL_CD AND IT.INDICATE_NO = MT.INDICATE_NO AND IT.COMPANY_NO = MT.COMPANY_NO)"
            sQuery += "   AND IT.INDICATE_NO = :K01 AND IT.COMPANY_NO = :K02"
            _oDatabase.CreateParam("K01", sSijiNo)
            _oDatabase.CreateParam("K02", sSyanaiNo)

            Using oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
                checkHikisate = oReader.HasRows
            End Using

        End Function

#End Region

#Region " その他 "

        Private Function GetString(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As String
            If oReader.IsDBNull(nIndex) Then Return ""
            Return oReader.GetString(nIndex).Trim()
        End Function

        Private Function GetInt32(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Long
            If oReader.IsDBNull(nIndex) Then Return 0
            Return oReader.GetInt32(nIndex)
        End Function

        Private Function GetDouble(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Double
            If oReader.IsDBNull(nIndex) Then Return 0.0
            Return oReader.GetDouble(nIndex)
        End Function

#End Region

    End Class

    Public Class mdtyk040common

        Private _oDatabase As MedicalLib.DataAccess
        'Private _oSQLServer As MedicalLib.DataSQLserver

        Public Sub New(ByVal oDatabase As MedicalLib.DataAccess)
            _oDatabase = oDatabase
            '_oSQLServer = New MedicalLib.DataSQLserver
        End Sub

        Public Function PrintList() As Boolean
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Try
                Dim nPrint As Boolean = False
                Dim sKey As New StringBuilder
                sProgramID = MedicalLib.Common.ProgramID
                sQuery = "SELECT INDICATE_NO,COMPANY_NO,UPD_CNT FROM U_PROCESS_F_TBL WHERE END_KB = '0' ORDER BY COMPANY_NO,INDICATE_NO"
                oReader = _oDatabase.CreateReader(sQuery)
                While oReader.Read()
                    PrintList(False, GetString(oReader, 0), GetString(oReader, 1), GetInt32(oReader, 2))
                    'sKey.Append(GetString(oReader, 0) + "," + GetString(oReader, 1) + "," & GetInt32(oReader, 2) + Chr(9))
                    sKey.Append(GetString(oReader, 0) + "," + GetString(oReader, 1) + "," & GetInt32(oReader, 2).ToString + ControlChars.Tab)
                    nPrint = True
                End While
                oReader.Close()
                Try
                    _oDatabase.BeginTrans()
                    Dim sRow() As String = sKey.ToString.Split(Chr(9))
                    For i As Integer = 0 To sRow.Length - 2
                        Dim sCode() As String = sRow(i).Split(",")
                        sQuery = "UPDATE U_PROCESS_F_TBL SET "
                        sQuery += "END_KB = :F01,"
                        sQuery += "UPD_DT = :F02,"
                        sQuery += "UPD_TIME = :F03,"
                        sQuery += "UPD_USR = :F04,"
                        sQuery += "UPD_PROGRAM_ID = :F05 "
                        sQuery += "WHERE INDICATE_NO = :K01 AND COMPANY_NO = :K02 AND UPD_CNT = :K03"
                        _oDatabase.CreateParam("F01", "1")
                        _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                        _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                        _oDatabase.CreateParam("F04", HttpContext.Current.Session("UserID"))
                        '_oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                        _oDatabase.CreateParam("F05", sProgramID)
                        _oDatabase.CreateParam("K01", sCode(0))
                        _oDatabase.CreateParam("K02", sCode(1))
                        _oDatabase.CreateParam("K03", sCode(2))
                        _oDatabase.ExecuteNonQueryParam(sQuery)
                    Next
                    _oDatabase.CommitTrans()
                Catch ex As Exception
                    _oDatabase.Rollback()
                    Throw
                End Try
                Return nPrint
            Catch ex As Exception
                Throw
            Finally
                oReader = Nothing
            End Try
        End Function

        Public Sub PrintList(ByVal nRePrint As Boolean, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal nSyuseiKaisu As Integer)
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Try
                '修正工程票 
                mdtyk040(nRePrint, sSijiNo, sSyanaiNo, nSyuseiKaisu)
            Catch ex As Exception
                Throw
            End Try
        End Sub

#Region " 各種帳票 "

        '工程票 
        Private Sub mdtyk040(ByVal nRePrint As Boolean, ByVal sSijiNo As String, ByVal sSyanaiNo As String, ByVal nSyuseiKaisu As Integer)
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Try
                sQuery = "SELECT B.O_CATALOG_NO,B.CATALOG_NO,B.WORK_STD_NO,A.COMPANY_NO,A.INDICATE_NO,S.C_NO,S.OEM_FLG,S.FIRST_KB,S.USE_ORG_PARTS_NO,S.ORIGIN_PARTS_NO,D.REN_NO,D.MATL_NM,D.MATL_SPEC,S.MATL_CD,C.DELIVERY_DT,S.COMP_NEED_AMT,S.STW_AMT,C.OLD_STW_AMT,E.ITEM_NM テストピース,V.ITEM_NM 梱包ラベル,F.WORKER_ABB 着工者,G.WORKER_ABB 承認品管,H.WORKER_ABB 承認技術,I.WORKER_ABB 点検,J.WORKER_ABB 作成,K.COR_MARK COR_MARK2,L.COR_MARK COR_MARK1,M.COR_MARK COR_MARK4,N.COR_MARK COR_MARK3,O.COR_MARK COR_MARK5,P.UM_P_ORDER,P.P_ORDER_MAIN,P.P_ORDER_SUB,P.SHOP,Q.ITEM_NM 設備集約名称,R.P_ORDER_NM,U.ITEM_KN WORK_STD,P.WORK_COMMENT,L.COR_ARTICLE_NO,L.APPLY_DT,L.CREATOR_NM,L.RECOGNIZER_NM,C.U_P_ORDER_MAIN,C.U_P_ORDER_SUB,T.P_ORDER_NM 修正P_ORDER_NM "

                '**** 2010/04 修正数 追加 ST ****
                sQuery += " ,C.OLD_STW_AMT AS 修正数 "
                '**** 2010/04 修正数 追加 ED ****

                sQuery += "FROM U_PROCESS_F_TBL A,PARTS_MST B,UPD_INDICATE_TBL C,INDICATE_TBL S,MATL_MST D,"
                sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS005') E,"
                sQuery += "WORKER_MST F,WORKER_MST G,WORKER_MST H,WORKER_MST I,WORKER_MST J,"
                sQuery += "(SELECT CATALOG_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '2' ) K,"
                sQuery += "(SELECT CATALOG_NO,COR_MARK,COR_ARTICLE_NO,APPLY_DT,CREATOR_NM,RECOGNIZER_NM FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '1' ) L,"
                sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '4' ) M,"
                sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '3' ) N,"
                sQuery += "(SELECT PROSTD_NO,COR_MARK FROM V_N_REVISION_HIS WHERE REVISION_TYPE = '5' ) O,"
                sQuery += "(SELECT * FROM PROCESS_PROGRESS_TBL WHERE P_ORDER_MAIN >= 900) P,"
                sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS025') Q,"
                sQuery += "PROCESS_MST R,PROCESS_MST T,"
                sQuery += "(SELECT TELL_CD,ITEM_KN FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS027') U,"
                sQuery += "(SELECT TELL_CD,ITEM_NM FROM GENERAL_PURPOSE_TBL WHERE INFO_KB = 'MS006') V "
                sQuery += "WHERE A.CATALOG_NO = B.CATALOG_NO AND "
                sQuery += "(A.INDICATE_NO = C.INDICATE_NO AND A.COMPANY_NO = C.COMPANY_NO AND A.UPD_CNT = C.UPD_CNT) AND "
                sQuery += "(A.INDICATE_NO = S.INDICATE_NO AND A.COMPANY_NO = S.COMPANY_NO) AND "
                sQuery += "S.MATL_CD = D.MATL_CD(+) AND "
                sQuery += "B.TPERS_AMT = E.TELL_CD(+) AND "
                sQuery += "C.CRT_USR = F.WORKER_CD(+) AND "
                sQuery += "B.RECOGNIZER_QL = G.WORKER_CD(+) AND "
                sQuery += "B.RECOGNIZER_SK = H.WORKER_CD(+) AND "
                sQuery += "B.CHECKER = I.WORKER_CD(+) AND "
                sQuery += "B.CREATOR = J.WORKER_CD(+) AND "
                sQuery += "A.CATALOG_NO = K.CATALOG_NO(+) AND "
                sQuery += "A.CATALOG_NO = L.CATALOG_NO(+) AND "
                sQuery += "B.WORK_STD_NO = M.PROSTD_NO(+) AND "
                sQuery += "B.WORK_STD_NO = N.PROSTD_NO(+) AND "
                sQuery += "B.WORK_STD_NO = O.PROSTD_NO(+) AND "
                sQuery += "(A.INDICATE_NO = P.INDICATE_NO AND A.COMPANY_NO = P.COMPANY_NO AND A.UPD_CNT = P.UPD_CNT) AND "
                sQuery += "P.FACILITIES_G_CD = Q.TELL_CD(+) AND "
                sQuery += "P.PROCESS_CD = R.PROCESS_CD(+) AND "
                sQuery += "C.UPD_PROCESS_CD = T.PROCESS_CD(+) AND "
                sQuery += "R.WORK_STD = U.TELL_CD(+) AND "
                sQuery += "B.PACKUP_KB = V.TELL_CD(+) AND "
                sQuery += "A.INDICATE_NO = :K01 AND A.COMPANY_NO = :K02 AND A.UPD_CNT = :K03 "
                sQuery += "ORDER BY P.P_ORDER_MAIN,P.P_ORDER_SUB"
                _oDatabase.CreateParam("K01", sSijiNo)
                _oDatabase.CreateParam("K02", sSyanaiNo)
                _oDatabase.CreateParam("K03", nSyuseiKaisu)
                Dim oDataSet1 As DataSet = _oDatabase.CreateDataSetParam(sQuery, "TB1")
                Dim oReport As New mdtyk040
                oReport.DataSource = oDataSet1
                oReport.DataMember = "TB1"
                oReport.MedicalDNS = ConfigurationManager.ConnectionStrings("MedicalDB").ToString()
                oReport.HonsyaDNS = ConfigurationManager.ConnectionStrings("HonsyaDB").ToString()
                oReport.RePrint = nRePrint
                oReport.Run(True)
                oReport.Document.Print(False, False)
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

        Private Function GetInt32(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Long
            If oReader.IsDBNull(nIndex) Then Return 0
            Return oReader.GetInt32(nIndex)
        End Function

        Private Function GetDouble(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Double
            If oReader.IsDBNull(nIndex) Then Return 0.0
            Return oReader.GetDouble(nIndex)
        End Function

#End Region

    End Class

End Class
