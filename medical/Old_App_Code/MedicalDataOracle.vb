Imports System.Data
Imports System.Data.OracleClient
Imports System.Configuration
Imports System.Web
Imports System
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Text

Namespace MedicalLib

    Public Class DataAccess

#Region " 変数 & 定数 "

        Private _oConnection As OracleConnection = Nothing
        Private _oTransaction As OracleTransaction = Nothing
        Private _oCommandParam As OracleCommand = Nothing

        Private _nTransactionFlag As Boolean = False

        Public Enum Saiban
            AL  'ALN_REN_BAN 
            SI  '指示ＮＯ 
            ZH  'MATERIALS発注ＮＯ 
            ZL  'MATERIALSLOTＮＯ 
            ZN  'MATERIALS入庫ＮＯ 
            ZS  'MATERIALS出庫ＮＯ 
            GH  '外注発注ＮＯ 
            BN  '部品入庫ＮＯ 
            BS  '部品出庫ＮＯ 
            ZR  '主材料連ＮＯ   '2012/12 追加
            SN  '社内ＮＯ       '2012/12 追加
        End Enum

#End Region

#Region " パブリック "

        'コンストラクタ 
        Public Sub New()
            Try
                _oConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("MedicalDB").ToString())
                _oConnection.Open()
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw New ApplicationException("データベースのオープンに失敗しました" + ControlChars.NewLine + ex.Message)
            End Try
            Try
                GetAuthority()
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw New ApplicationException("権限の取得失敗しました" + ControlChars.NewLine + ex.Message)
            End Try
        End Sub

        Public Sub New(ByVal sConnect As String)
            Try
                _oConnection = New OracleConnection(ConfigurationManager.ConnectionStrings(sConnect).ToString())
                _oConnection.Open()
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw New ApplicationException("データベースのオープンに失敗しました" + vbCrLf + ex.Message)
            End Try
            Try
                'GetAuthority() 
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw New ApplicationException("権限の取得失敗しました" + vbCrLf + ex.Message)
            End Try
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        'クローズ 
        Public Sub Close()
            Try
                _oConnection.Close()
                _oConnection = Nothing
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw New ApplicationException("データベースのクローズに失敗しました" + vbCrLf + ex.Message)
            End Try
        End Sub

        'Reader作成 
        Public Function CreateReader(ByVal sQuery As String) As OracleDataReader
            Dim oCommand As OracleCommand
            Dim oReader As OracleDataReader
            Try
                oCommand = _oConnection.CreateCommand()
                If _nTransactionFlag Then oCommand.Transaction = _oTransaction
                oCommand.CommandText = sQuery
                oReader = oCommand.ExecuteReader()
                MedicalLib.Log.Trace("CREATE READER", sQuery)
                Return oReader
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message, sQuery)
                Throw New ApplicationException("クエリーの実行に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                oCommand = Nothing
            End Try
        End Function

        'Reader作成(with パラメータ) 
        Public Function CreateReaderParam(ByVal sQuery As String) As OracleDataReader
            Dim oReader As OracleDataReader
            Try
                If _oCommandParam Is Nothing Then
                    oReader = CreateReader(sQuery)
                Else
                    If _nTransactionFlag Then _oCommandParam.Transaction = _oTransaction
                    _oCommandParam.CommandText = sQuery
                    oReader = _oCommandParam.ExecuteReader()

                    MedicalLib.Log.Trace("CREATE READER PARAM", sQuery)
                End If
                Return oReader
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message, sQuery)
                MedicalLib.Log.Log(GetParam())
                Throw New ApplicationException("クエリーの実行に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                _oCommandParam = Nothing
            End Try
        End Function

        'Adapter作成 
        Public Function CreateAdapter(ByVal sQuery As String) As OracleDataAdapter
            Dim oAdapter As OracleDataAdapter
            Try
                oAdapter = New OracleDataAdapter(sQuery, _oConnection)
                MedicalLib.Log.Trace("CREATE ADAPTER", sQuery)
                Return oAdapter
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message, sQuery)
                Throw New ApplicationException("クエリーの実行に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
            End Try
        End Function

        'Adapter作成(with パラメータ) 
        Public Function CreateAdapterParam(ByVal sQuery As String) As OracleDataAdapter
            Dim oAdapter As OracleDataAdapter
            Try
                If _oCommandParam Is Nothing Then
                    oAdapter = CreateAdapterParam(sQuery)
                Else
                    If _nTransactionFlag Then _oCommandParam.Transaction = _oTransaction
                    _oCommandParam.CommandText = sQuery
                    oAdapter = New OracleDataAdapter(_oCommandParam)
                    MedicalLib.Log.Trace("CREATE ADAPTER PARAM", sQuery)
                End If
                Return oAdapter
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message, sQuery)
                MedicalLib.Log.Log(GetParam())
                Throw New ApplicationException("クエリーの実行に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                _oCommandParam = Nothing
            End Try
        End Function

        'DataSet作成 
        Public Function CreateDataSet(ByVal sQuery As String, ByVal sTableName As String) As DataSet
            Dim oAdapter As OracleDataAdapter
            Dim oDataSet As DataSet
            Try
                oAdapter = New OracleDataAdapter(sQuery, _oConnection)
                oDataSet = New DataSet(sTableName)
                oAdapter.Fill(oDataSet, sTableName)
                MedicalLib.Log.Trace("CREATE DATASET", sQuery)
                Return oDataSet
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message, sQuery)
                Throw New ApplicationException("クエリーの実行に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
            End Try
        End Function

        'DataSet作成(with パラメータ) 
        Public Function CreateDataSetParam(ByVal sQuery As String, ByVal sTableName As String) As DataSet
            Dim oAdapter As OracleDataAdapter
            Dim oDataSet As DataSet
            Try
                If _oCommandParam Is Nothing Then
                    oDataSet = CreateDataSet(sQuery, sTableName)
                Else
                    If _nTransactionFlag Then _oCommandParam.Transaction = _oTransaction
                    _oCommandParam.CommandText = sQuery
                    oAdapter = New OracleDataAdapter(_oCommandParam)
                    oDataSet = New DataSet(sTableName)
                    oAdapter.Fill(oDataSet, sTableName)
                    MedicalLib.Log.Trace("CREATE DATASET PARAM", sQuery)
                End If
                Return oDataSet
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message, sQuery)
                MedicalLib.Log.Log(GetParam())
                Throw New ApplicationException("クエリーの実行に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                _oCommandParam = Nothing
            End Try
        End Function

        'QUERY実行 
        Public Sub ExecuteNonQuery(ByVal sQuery As String)
            Dim oCommand As OracleCommand
            Try
                oCommand = _oConnection.CreateCommand
                If _nTransactionFlag Then oCommand.Transaction = _oTransaction
                oCommand.CommandText = sQuery
                oCommand.ExecuteNonQuery()
                MedicalLib.Log.Trace("EXECUTE", sQuery)
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message, sQuery)
                Throw New ApplicationException("クエリーの実行に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                oCommand = Nothing
            End Try
        End Sub

        'QUERY実行(with パラメータ) 
        Public Sub ExecuteNonQueryParam(ByVal sQuery As String)
            Try
                If _oCommandParam Is Nothing Then Throw New Exception("パラメータが作成されていません")
                If _nTransactionFlag Then _oCommandParam.Transaction = _oTransaction
                _oCommandParam.CommandText = sQuery
                _oCommandParam.ExecuteNonQuery()
                MedicalLib.Log.Trace("EXECUTE PARAM", sQuery)
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message, sQuery)
                MedicalLib.Log.Log(GetParam())
                Throw New ApplicationException("クエリーの実行に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                _oCommandParam = Nothing
            End Try
        End Sub

        'トランザクション開始 
        Public Sub BeginTrans()
            Try
                _oTransaction = _oConnection.BeginTransaction
                _nTransactionFlag = True
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message)
                Throw New ApplicationException("トランザクションの開始に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            End Try
        End Sub

        'トランザクション中断 
        Public Sub Rollback()
            Try
                _oTransaction.Rollback()
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message)
                Throw New ApplicationException("トランザクションのロールバックに失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                _nTransactionFlag = False
            End Try
        End Sub

        'トランザクション終了 
        Public Sub CommitTrans()
            Try
                _oTransaction.Commit()
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message)
                Throw New ApplicationException("トランザクションの終了に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                _nTransactionFlag = False
            End Try
        End Sub

        'ホスト変数の作成 
        Public Sub CreateParam(ByVal sParamName As String, ByVal sValue As String)
            Try
                If _oCommandParam Is Nothing Then _oCommandParam = _oConnection.CreateCommand
                _oCommandParam.Parameters.Add(sParamName, OracleType.VarChar)
                _oCommandParam.Parameters(sParamName).Value = sValue
                MedicalLib.Log.Trace("CREATE PARAM", "変数:" + sParamName + " 値:" + sValue)
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message)
                Throw New ApplicationException("ホスト変数の作成に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            End Try
        End Sub

        'ホスト変数の作成 
        Public Sub CreateParam(ByVal sParamName As String, ByVal nValue As Integer)
            Try
                If _oCommandParam Is Nothing Then _oCommandParam = _oConnection.CreateCommand
                _oCommandParam.Parameters.Add(sParamName, OracleType.Number)
                _oCommandParam.Parameters(sParamName).Value = nValue
                MedicalLib.Log.Trace("CREATE PARAM", "変数:" + sParamName + " 値:" & nValue)
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message)
                Throw New ApplicationException("ホスト変数の作成に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            End Try
        End Sub

        'ホスト変数の作成 
        Public Sub CreateParam(ByVal sParamName As String, ByVal nValue As Long)
            Try
                If _oCommandParam Is Nothing Then _oCommandParam = _oConnection.CreateCommand
                _oCommandParam.Parameters.Add(sParamName, OracleType.Number)
                _oCommandParam.Parameters(sParamName).Value = nValue
                MedicalLib.Log.Trace("CREATE PARAM", "変数:" + sParamName + " 値:" & nValue)
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message)
                Throw New ApplicationException("ホスト変数の作成に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            End Try
        End Sub

        'ホスト変数の作成 
        Public Sub CreateParam(ByVal sParamName As String, ByVal dValue As Double)
            Try
                If _oCommandParam Is Nothing Then _oCommandParam = _oConnection.CreateCommand
                _oCommandParam.Parameters.Add(sParamName, OracleType.Number)
                _oCommandParam.Parameters(sParamName).Value = dValue
                MedicalLib.Log.Trace("CREATE PARAM", "変数:" + sParamName + " 値:" & dValue)
            Catch oex As OracleException
                MedicalLib.Log.Log(oex.Message)
                Throw New ApplicationException("ホスト変数の作成に失敗しました。" & Chr(13) & Chr(10) & oex.Message)
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            End Try
        End Sub

        'システム日付取得 
        Public Function GetSysDate() As Date
            Dim oReader As OracleDataReader
            Dim sSysDate As Date
            Try
                oReader = CreateReader("SELECT TO_CHAR(SYSDATE,'yyyy/mm/dd hh24:mi:ss') FROM DUAL")
                If Not oReader.Read() Then Throw New ApplicationException("システム日付の取得に失敗しました。")
                oReader.Close()
                Return sSysDate
            Catch ex As Exception
                MedicalLib.Log.Log(ex.Message)
                Throw
            Finally
                oReader = Nothing
            End Try
        End Function

        '自動採番 
        '**** 2012/12 
        '**** 追加 ZR：主材料連NO
        '          SN：社内NO 
        Public Function GetNumber(ByVal oClass As Saiban) As Int32
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Dim nNowNo As Int32 = 0
            Dim nLastNo As Int32 = 0
            Dim sSaibanKubun() As String = {"AL", "SI", "ZH", "ZL", "ZN", "ZS", "GH", "BN", "BS", "ZR", "SN"}
            'Dim sSaibanKubun() As String = {"AL", "SI", "ZH", "ZL", "ZN", "ZS", "GH", "BN", "BS"}
            Try
                '採番マスタ取得 
                sQuery = "SELECT ST_NO,END_NO,PRESENT_NO FROM GETNO_TBL WHERE G_NO_KB = :K01"
                CreateParam("K01", sSaibanKubun(oClass))
                oReader = CreateReaderParam(sQuery)
                If oReader.Read() Then
                    If oReader.GetInt32(2) + 1 > oReader.GetInt32(1) Then
                        nNowNo = oReader.GetInt32(0)
                    Else
                        nNowNo = oReader.GetInt32(2) + 1
                    End If
                    '更新 
                    sQuery = "UPDATE GETNO_TBL SET PRESENT_NO=:F01,UPD_DT=:F02,UPD_TIME=:F03,UPD_USR=:F04,UPD_PROGRAM_ID=:F05 WHERE G_NO_KB=:K01"
                    CreateParam("F01", nNowNo)
                    CreateParam("F02", MedicalLib.Common.GetSystemDate)
                    CreateParam("F03", MedicalLib.Common.GetSystemTime)
                    CreateParam("F04", HttpContext.Current.Session("UserID"))
                    CreateParam("F05", MedicalLib.Common.ProgramID)
                    CreateParam("K01", sSaibanKubun(oClass))
                    ExecuteNonQueryParam(sQuery)
                Else
                    nNowNo = 1
                    Select Case oClass
                        Case Saiban.AL, Saiban.BN, Saiban.BS, Saiban.ZN, Saiban.ZS, Saiban.SN
                            'Case Saiban.AL, Saiban.BN, Saiban.BS, Saiban.ZN, Saiban.ZS
                            nLastNo = 999999
                        Case Saiban.GH, Saiban.ZR
                            'Case Saiban.GH
                            nLastNo = 99999
                        Case Saiban.SI, Saiban.ZH
                            nLastNo = 9999
                        Case Saiban.ZL
                            nLastNo = 999
                    End Select
                    '追加 
                    sQuery = "INSERT INTO GETNO_TBL VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10,:F11)"
                    CreateParam("F01", sSaibanKubun(oClass))
                    CreateParam("F02", 1)
                    CreateParam("F03", nLastNo)
                    CreateParam("F04", nNowNo)
                    CreateParam("F05", MedicalLib.Common.GetSystemDate)
                    CreateParam("F06", MedicalLib.Common.GetSystemTime)
                    CreateParam("F07", HttpContext.Current.Session("UserID"))
                    CreateParam("F08", MedicalLib.Common.GetSystemDate)
                    CreateParam("F09", MedicalLib.Common.GetSystemTime)
                    CreateParam("F10", HttpContext.Current.Session("UserID"))
                    CreateParam("F11", MedicalLib.Common.ProgramID)
                    ExecuteNonQueryParam(sQuery)
                End If
                oReader.Close()
                Select Case oClass
                    Case Saiban.AL, Saiban.BN, Saiban.BS, Saiban.ZS, Saiban.ZN
                        sQuery = "SELECT A_YEAR FROM ADMIN_MST WHERE ADMIN_KEY = '01'"
                        oReader = CreateReader(sQuery)
                        oReader.Read()
                        nNowNo = Int32.Parse(oReader.GetString(0).Substring(2, 2).PadLeft(2, "0") + nNowNo.ToString("000000"))
                        oReader.Close()
                    Case Saiban.ZL
                        sQuery = "SELECT A_YEAR FROM ADMIN_MST WHERE ADMIN_KEY = '01'"
                        oReader = CreateReader(sQuery)
                        oReader.Read()
                        nNowNo = Int32.Parse(oReader.GetString(0).Substring(2, 2).PadLeft(2, "0") + nNowNo.ToString("000"))
                        'Return nNowNo.ToString("00000") 
                        oReader.Close()
                    Case Saiban.SI
                        sQuery = "SELECT A_YEAR FROM ADMIN_MST WHERE ADMIN_KEY = '01'"
                        oReader = CreateReader(sQuery)
                        oReader.Read()
                        nNowNo = Int32.Parse(oReader.GetString(0).Substring(3, 1) + nNowNo.ToString("0000"))
                        'Return nNowNo.ToString("00000") 
                        oReader.Close()
                End Select
                Return nNowNo
            Catch ex As Exception
                Throw
            Finally
                oReader = Nothing
            End Try
        End Function

        '自動採番 更新なし
        Public Function GetNumberNoUpdate(ByVal oClass As Saiban) As Int32
            Dim nNowNo As Integer
            Dim sSaibanKubun() As String = {"AL", "SI", "ZH", "ZL", "ZN", "ZS", "GH", "BN", "BS", "ZR", "SN"}
            Dim sQuery As String = String.Empty
            sQuery = "SELECT ST_NO ,END_NO ,PRESENT_NO FROM GETNO_TBL WHERE G_NO_KB = :K01"
            CreateParam("K01", sSaibanKubun(oClass))
            Using oReader As OracleDataReader = CreateReaderParam(sQuery)
                If oReader.Read Then
                    If oReader.GetInt32(2) + 1 > oReader.GetInt32(1) Then
                        nNowNo = oReader.GetInt32(0)
                    Else
                        nNowNo = oReader.GetInt32(2) + 1
                    End If
                Else
                    nNowNo = 1
                End If
            End Using
            GetNumberNoUpdate = nNowNo
        End Function

        '年度取得 
        Public Function GetNendo(ByVal sKey As String) As String
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Dim sNendo As String = ""

            Try
                sQuery = "SELECT A_YEAR FROM ADMIN_MST WHERE ADMIN_KEY = :K01"
                CreateParam("K01", sKey)
                oReader = CreateReaderParam(sQuery)
                If oReader.Read() Then
                    sNendo = oReader(0).ToString
                End If
                oReader.Close()
                Return sNendo
            Catch ex As Exception
                Throw
            Finally
                oReader = Nothing
            End Try
        End Function

        'フォルダ & プログラム取得 
        Public Function GetFilePath(ByVal sProgramID As String) As String
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Dim sFolder As String = ""
            Try
                sQuery = "SELECT FILE_PATH FROM PROGRAM_MST WHERE PROGRAM_ID = :K01"
                CreateParam("K01", sProgramID.Trim.ToUpper)
                oReader = CreateReaderParam(sQuery)
                If oReader.Read() Then
                    If Not oReader.IsDBNull(0) Then
                        sFolder = oReader.GetString(0).Trim()
                    End If
                End If
                oReader.Close()
                Return sFolder
            Catch ex As Exception
                Throw
            Finally
                oReader = Nothing
            End Try
        End Function

        'Public Function GetFolder(ByVal sProgramID As String) As String 
        '    Dim sQuery As String = "" 
        '    Dim oReader As OracleDataReader = Nothing 
        '    Dim sFolder As String = "" 
        '    Try 
        '        sQuery = "SELECT ファイルパス FROM プログラムマスタ WHERE プログラムID = :K01" 
        '        CreateParam("K01", sProgramID.Trim.ToUpper) 
        '        oReader = CreateReaderParam(sQuery) 
        '        If oReader.Read() Then 
        '            If Not oReader.IsDBNull(0) Then 
        '                sFolder = oReader.GetString(0).Trim() 
        '            End If 
        '        End If 
        '        oReader.Close() 
        '        Return sFolder 
        '    Catch ex As Exception 
        '        Throw 
        '    Finally 
        '        oReader = Nothing 
        '    End Try 
        'End Function 

        '権限の取得 
        Public Function GetAuthority(ByVal sProgramID As String) As Boolean
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Dim nAuthority As Boolean = False
            Try
                If sProgramID.Trim.Equals("") Then Return False
                sQuery = "SELECT ENTRY,CORRECT,DEL FROM RIGHTS_MST WHERE EMPOWER_LV = :K01 AND MENU_ID = :K02 AND PROGRAM_ID = :K03"
                CreateParam("K01", HttpContext.Current.Session("Level").ToString())
                CreateParam("K02", HttpContext.Current.Session("MenuKey1").ToString())
                CreateParam("K03", sProgramID)
                oReader = CreateReaderParam(sQuery)
                If oReader.Read() Then
                    nAuthority = oReader.GetString(0).Trim.Equals("1") Or oReader.GetString(1).Trim.Equals("1") Or oReader.GetString(2).Trim.Equals("1")
                End If
                oReader.Close()
                Return nAuthority
            Catch ex As Exception
                Throw
            Finally
                oReader = Nothing
            End Try
        End Function

        '2008/04 追加
        '作業日報明細抽出 対象外SHOP 取得
        Public Function GetNippouShop(Optional ByVal sInfoKey As String = "MS032") As String()

            Dim sShops() As String
            Try
                sShops = GetMedicalShop(sInfoKey)
            Catch ex As Exception
                Throw
            End Try

            Return sShops

        End Function

        '2008/04 追加
        'メディカルSHOP の 先頭のみ 取得
        Public Function GetMedicalShopFirst() As String

            Dim sShops() As String
            Try
                sShops = GetMedicalShop()
            Catch ex As Exception
                Throw
            End Try

            Return sShops(0)

        End Function

        '2008/04 追加
        'メディカルSHOP の取得
        Public Function GetMedicalShop(Optional ByVal sInfoKey As String = "MS031") As String()

            Dim sReturnValues() As String = Nothing
            Dim i As Integer = 0
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing

            Try
                sQuery = ""
                sQuery += "SELECT TELL_CD"
                sQuery += "  FROM GENERAL_PURPOSE_TBL "
                sQuery += " WHERE INFO_KB = :K01"
                sQuery += " ORDER BY ITEM_KN"
                CreateParam("K01", sInfoKey)
                oReader = CreateReaderParam(sQuery)
                While oReader.Read
                    ReDim Preserve sReturnValues(i)
                    sReturnValues(i) = oReader.GetString(0)
                    i += 1
                End While

                If Not oReader.HasRows Then
                    ReDim sReturnValues(0)
                    sReturnValues(0) = ""
                End If

                Return sReturnValues

            Catch ex As Exception
                Throw
            Finally
                oReader.Close()
                oReader = Nothing
            End Try

        End Function

        '以下2つのArrayListは2次元の配列
        Dim time_P_array As New ArrayList   '親配列
        Dim time_ST_ED As New ArrayList     '└子配列_開始日時と終了日時
        Dim d_table_in As String
        Public Function mdsub010(ByVal str_FACILITIES_CD As String, ByVal str_SCHEDULE_ST_DT As String, _
                                 ByVal str_SCHEDULE_ST_TIME As String, ByVal str_TOTAL_REAL_TIME As String) As String
            Dim strSQL As String
            Dim WK_ST_DTTIME As Date
            Dim WK_TOTAL_REAL_TIME As Integer
            Dim FE_time_ST_ED As New ArrayList
            Dim idx As Integer
            Dim d_dummy As Date
            Dim strRet As String = ""

            time_P_array.Clear()

            strSQL = "select FC.FACILITIES_CD,FC.C_DATE,FC.OPERATION_FORM," & _
                     "T.OPE_START1_CAL, T.OPE_END1_CAL, T.OPE_TIME1_CAL, " & _
                     "T.OPE_START2_CAL, T.OPE_END2_CAL, T.OPE_TIME2_CAL, " & _
                     "T.OPE_START3_CAL, T.OPE_END3_CAL, T.OPE_TIME3_CAL, " & _
                     "FC.OVER_WORK_FORM1, Z1.OPE_START1_CAL, Z1.OPE_END1_CAL, Z1.OPE_TIME1_CAL, " & _
                     "FC.OVER_WORK_FORM2, Z2.OPE_START1_CAL, Z2.OPE_END1_CAL, Z2.OPE_TIME1_CAL, " & _
                     "FC.OVER_WORK_FORM3, Z3.OPE_START1_CAL, Z3.OPE_END1_CAL, Z3.OPE_TIME1_CAL  " & _
                     "from FACILITIES_CLND_MST FC, " & _
                     "(select OPE_FORM_CD, OPE_START1_CAL, OPE_END1_CAL, OPE_TIME1_CAL, OPE_START2_CAL,OPE_END2_CAL, " & _
                     "OPE_TIME2_CAL, OPE_START3_CAL, OPE_END3_CAL, OPE_TIME3_CAL from ST_OPERATION_FORM_MST) T, " & _
                     "(select OPE_FORM_CD, OPE_START1_CAL, OPE_END1_CAL, OPE_TIME1_CAL from ST_OPERATION_FORM_MST) Z1, " & _
                     "(select OPE_FORM_CD, OPE_START1_CAL, OPE_END1_CAL, OPE_TIME1_CAL from ST_OPERATION_FORM_MST) Z2, " & _
                     "(select OPE_FORM_CD, OPE_START1_CAL, OPE_END1_CAL, OPE_TIME1_CAL from ST_OPERATION_FORM_MST) Z3 " & _
                     "where FC.FACILITIES_CD = :K01 " & _
                     "and FC.C_DATE between :K02 and :K03 " & _
                     "and FC.OPERATION_FORM <> 0 " & _
                     "and FC.OPERATION_FORM = T.OPE_FORM_CD(+) " & _
                     "and FC.OVER_WORK_FORM1 = Z1.OPE_FORM_CD(+) " & _
                     "and FC.OVER_WORK_FORM2 = Z2.OPE_FORM_CD(+) " & _
                     "and FC.OVER_WORK_FORM3 = Z3.OPE_FORM_CD(+) " & _
                     "ORDER BY FC.FACILITIES_CD,FC.C_DATE"
            CreateParam("K01", str_FACILITIES_CD)
            CreateParam("K02", str_SCHEDULE_ST_DT)
            d_dummy = DateAdd(DateInterval.Day, 20, Date.ParseExact(str_SCHEDULE_ST_DT, "yyyyMMdd", Nothing))
            CreateParam("K03", d_dummy.ToString("yyyyMMdd"))

            Using oReader As OracleDataReader = CreateReaderParam(strSQL)
                If oReader.HasRows Then
                    While oReader.Read
                        '日時ﾃｰﾌﾞﾙに入れる日付保存
                        d_table_in = oReader(1)

                        'T.稼働時間1
                        add_timetable(oReader, 5)
                        'T.稼働時間2
                        add_timetable(oReader, 8)
                        'T.稼働時間3
                        add_timetable(oReader, 11)
                        'Z1.残業時間1
                        add_timetable(oReader, 15)
                        'Z2.残業時間1
                        add_timetable(oReader, 19)
                        'Z3.残業時間1
                        add_timetable(oReader, 23)
                    End While

                    '引数をﾜｰｸ変数に代入
                    WK_ST_DTTIME = Date.ParseExact(str_SCHEDULE_ST_DT & str_SCHEDULE_ST_TIME, "yyyyMMddHHmm", Nothing)
                    WK_TOTAL_REAL_TIME = CInt(str_TOTAL_REAL_TIME)

                    idx = 0
                    For Each FE_time_ST_ED In time_P_array
                        If (idx < time_P_array.Count() - 1) Then
                            '次の配列の開始日時を取得するためのｲﾝﾃﾞｯｸｽ増加
                            idx = idx + 1
                        End If
                        '開始日時 ≦ 引数.開始日時 ≦ 終了日時であれば,作業時間との比較を行う
                        If (FE_time_ST_ED(0) <= WK_ST_DTTIME) And (WK_ST_DTTIME <= FE_time_ST_ED(1)) Then
                            '作業時間計(秒数)が,開始～終了の時間(秒数)よりも長い場合,作業時間計から開始～終了の時間を引く
                            If (WK_TOTAL_REAL_TIME > DateDiff("s", WK_ST_DTTIME, FE_time_ST_ED(1))) Then
                                WK_TOTAL_REAL_TIME = WK_TOTAL_REAL_TIME - (DateDiff("s", WK_ST_DTTIME, FE_time_ST_ED(1)))
                                '次の配列の開始日時を取得
                                WK_ST_DTTIME = time_P_array(idx)(0)
                            Else
                                '作業時間計(秒数)が,開始～終了の時間(秒数)よりも短い場合,終了日時を(開始日時+作業時間計)を切り上げたものとする
                                Dim dt1 As DateTime
                                Dim ts1 As TimeSpan = New TimeSpan(0, 0, WK_TOTAL_REAL_TIME)    '作業時間計(秒)のﾀｲﾑｽﾊﾟﾝ

                                dt1 = DateTime.Parse(WK_ST_DTTIME)
                                dt1 = dt1.Add(ts1)                                              '実際の最終作業時間日時 = 開始日時 + 作業時間計(秒)
                                strRet = round_up(dt1)                                          '15分単位に切り上げる
                                Return strRet
                            End If
                        End If
                    Next
                End If
            End Using

            Return strRet
        End Function

        Sub add_timetable(ByRef oReader As OracleDataReader, ByVal i As Integer)
            Dim d_dummy As Date
            'oReader(i - 2) = 各開始
            'oReader(i - 1) = 各終了
            'oReader(i)     = 各稼働時間
            '稼働時間があれば開始・終了日時保存配列作成開始に入る
            If (oReader(i) IsNot System.DBNull.Value) Then
                '子配列(0)←開始日時
                time_ST_ED.Add(Date.ParseExact(d_table_in & oReader(i - 2), "yyyyMMddHHmm", Nothing))

                '子配列(1)←終了日時
                '  開始時刻よりも終了時刻の方が小さい場合、終了日時の日付を翌日にする
                d_dummy = Date.ParseExact(d_table_in & oReader(i - 1), "yyyyMMddHHmm", Nothing)

                If (oReader(i - 2) > oReader(i - 1)) Then
                    d_dummy = DateAdd(DateInterval.Day, 1, d_dummy)
                    time_ST_ED.Add(d_dummy)
                    d_table_in = d_dummy.ToString("yyyyMMdd")
                Else
                    time_ST_ED.Add(d_dummy)
                End If
                '日付配列に追加
                time_P_array.Add(time_ST_ED.Clone)
                time_ST_ED.Clear()
            End If
        End Sub

        Function round_up(ByVal dt1 As Date) As String
            '任意の間隔でのDate型切上げﾙｰﾁﾝ
            Const range As Integer = 900            '終了日時を切り上げる範囲(秒) …900秒=15分
            Const range_max As Integer = 95         'range*(n+1)が86400秒(=24時間)になるnの値(切上げﾙｰﾁﾝのﾙｰﾌﾟ回数上限) …86400/900-1=95
            Dim i As Integer
            Dim dt2 As DateTime
            Dim ts1 As TimeSpan                                         '検索範囲下限のﾀｲﾑｽﾊﾟﾝ
            Dim ts2 As TimeSpan                                         '検索範囲上限のﾀｲﾑｽﾊﾟﾝ

            dt2 = DateTime.Parse(Mid(dt1.ToString(), 1, 10))            '実際の最終作業時間日時(00:00:00)(比較用)

            If dt1 <> dt2 Then                                          '引数の日時が0時0分丁度の時以外、切上げを行う
                For i = 0 To range_max
                    ts1 = New TimeSpan(0, 0, range * i)                 '下限…切上単位(秒) * iのﾀｲﾑｽﾊﾟﾝ
                    ts2 = New TimeSpan(0, 0, range * (i + 1))           '上限…切上単位(秒) * (i+1)のﾀｲﾑｽﾊﾟﾝ
                    If dt2.Add(ts1) < dt1 And dt1 <= dt2.Add(ts2) Then  '切上単位の範囲のiを探す
                        Exit For
                    End If
                Next
            End If
            Return dt2.Add(ts2).ToString("yyyyMMddHHmm")                '範囲の上限を戻り値とする
        End Function

        Public Function mdsub020(ByVal I_SERIES As String, ByVal I_PLAN_NO As String, _
                                 ByVal I_PROCESS_CD As String, ByVal I_PUT_TOGETHER_FLG As String, _
                                 ByVal I_DIV_NO As String) As Boolean
            Dim strSQL As String = ""
            Dim blnRet As Boolean = False
            Dim int_TOTAL_REAL_TIME As Integer = 0
            Dim int_TOTAL_RESULTS_TIME As Integer = 0

            int_TOTAL_REAL_TIME = 0
            int_TOTAL_RESULTS_TIME = 0

            '加工計画明細取得
            strSQL = ""
            strSQL += "SELECT SUM(REAL_TIME), SUM(RESULTS_PRE_TIME), SUM(RESULTS_TIME)"
            strSQL += " FROM MANUFACT_PLAN_DETAILTBL"
            strSQL += " WHERE SERIES = :K01"
            strSQL += " AND PLAN_NO = :K02"
            strSQL += " AND PROCESS_CD = :K03"
            strSQL += " AND PUT_TOGETHER_FLG = :K04"
            strSQL += " AND DIV_NO = :K05"
            strSQL += " AND END_FLG = :K06"
            CreateParam("K01", I_SERIES)
            CreateParam("K02", I_PLAN_NO)
            CreateParam("K03", I_PROCESS_CD)
            CreateParam("K04", I_PUT_TOGETHER_FLG)
            CreateParam("K05", I_DIV_NO)
            CreateParam("K06", "1")
            Using oReader As OracleDataReader = CreateReaderParam(strSQL)
                If oReader.Read = True Then
                    int_TOTAL_REAL_TIME = GetInt32(oReader, 0)
                    'int_TOTAL_RESULTS_TIME = GetInt32(oReader, 1) * 60 + GetInt32(oReader, 2)
                    int_TOTAL_RESULTS_TIME = GetInt32(oReader, 1) + GetInt32(oReader, 2)
                End If
            End Using

            '作業履歴時間取得
            strSQL = ""
            strSQL += "SELECT SUM(LASTEND_TIME) FROM WORK_HISTORY_TBL"
            strSQL += " WHERE SERIES = :K01"
            strSQL += " AND PLAN_NO = :K02"
            strSQL += " AND PROCESS_CD = :K03"
            strSQL += " AND PUT_TOGETHER_FLG = :K04"
            strSQL += " AND DIV_NO = :K05"
            CreateParam("K01", I_SERIES)
            CreateParam("K02", I_PLAN_NO)
            CreateParam("K03", I_PROCESS_CD)
            CreateParam("K04", I_PUT_TOGETHER_FLG)
            CreateParam("K05", I_DIV_NO)
            Using oReader As OracleDataReader = CreateReaderParam(strSQL)
                If oReader.Read = True Then
                    int_TOTAL_RESULTS_TIME += GetInt32(oReader, 0)
                End If
            End Using

            '判定
            If int_TOTAL_REAL_TIME < int_TOTAL_RESULTS_TIME Then blnRet = True


            Return blnRet

        End Function

#End Region

#Region " プライベート "

        'パラメータ取得 
        Private Function GetParam() As String
            Dim sParam As New StringBuilder
            Try
                For i As Integer = 0 To _oCommandParam.Parameters.Count - 1
                    sParam.Append(_oCommandParam.Parameters(i).ParameterName & ":" & _oCommandParam.Parameters(i).Value)
                    sParam.Append(" ")
                Next
                Return sParam.ToString()
            Catch ex As Exception
                Throw
            End Try
        End Function

        '権限の取得 
        Private Sub GetAuthority()
            Dim sQuery As String = ""
            Dim oReader As OracleDataReader = Nothing
            Try
                MedicalLib.Common.EnableInsert = False
                MedicalLib.Common.EnableUpdate = False
                MedicalLib.Common.EnableDelete = False
                If MedicalLib.Common.ProgramID.Trim.Equals("") Then Return
                If HttpContext.Current.Session("Level") Is Nothing Then Return
                If HttpContext.Current.Session("MenuKey1") Is Nothing Then Return
                sQuery = "SELECT PG_NM FROM PROGRAM_MST WHERE MENU_LEBEL = '2' AND PROGRAM_ID = :K01"
                CreateParam("K01", MedicalLib.Common.ProgramID)
                oReader = CreateReaderParam(sQuery)
                If oReader.Read() Then
                    MedicalLib.Common.ProgramTitle = oReader.GetString(0).Trim()
                End If
                oReader.Close()
                oReader = Nothing
                sQuery = "SELECT ENTRY,CORRECT,DEL FROM RIGHTS_MST WHERE EMPOWER_LV = :K01 AND MENU_ID = :K02 AND PROGRAM_ID = :K03"
                CreateParam("K01", HttpContext.Current.Session("Level").ToString())
                CreateParam("K02", HttpContext.Current.Session("MenuKey1").ToString())
                CreateParam("K03", MedicalLib.Common.ProgramID)
                oReader = CreateReaderParam(sQuery)
                If oReader.Read() Then
                    MedicalLib.Common.EnableInsert = oReader.GetString(0).Trim.Equals("1")
                    MedicalLib.Common.EnableUpdate = oReader.GetString(1).Trim.Equals("1")
                    MedicalLib.Common.EnableDelete = oReader.GetString(2).Trim.Equals("1")
                Else
                    If MedicalLib.Common.ProgramID.PadRight(4, " ").Substring(0, 4).Equals("MDCL") Then
                        MedicalLib.Common.EnableInsert = True
                        MedicalLib.Common.EnableUpdate = True
                        MedicalLib.Common.EnableDelete = True
                    End If
                End If
                oReader.Close()
                If Not MedicalLib.Common.EnableInsert And Not MedicalLib.Common.EnableUpdate And Not MedicalLib.Common.EnableDelete Then
                    sQuery = "SELECT ENTRY,CORRECT,DEL FROM RIGHTS_MST WHERE EMPOWER_LV = :K01 AND PROGRAM_ID = :K02"
                    CreateParam("K01", HttpContext.Current.Session("Level").ToString())
                    CreateParam("K02", MedicalLib.Common.ProgramID)
                    oReader = CreateReaderParam(sQuery)
                    If oReader.Read() Then
                        MedicalLib.Common.EnableInsert = oReader.GetString(0).Trim.Equals("1")
                        MedicalLib.Common.EnableUpdate = oReader.GetString(1).Trim.Equals("1")
                        MedicalLib.Common.EnableDelete = oReader.GetString(2).Trim.Equals("1")
                    End If
                    oReader.Close()
                End If
            Catch ex As Exception
                Throw
            Finally
                oReader = Nothing
            End Try
        End Sub

        Private Function GetInt32(ByVal oReader As OracleDataReader, ByVal nIndex As Integer) As Int32
            If oReader.IsDBNull(nIndex) Then Return 0
            Return oReader.GetInt32(nIndex)
        End Function
#End Region

    End Class

End Namespace

