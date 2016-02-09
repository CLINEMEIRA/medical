Imports System.Drawing 
Imports System.Data 
Imports System.Data.OracleClient
Imports System.IO
 
Partial Class master_mdmas155
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS155"
    Private Const PROGRAM_TITLE As String = "加工工程マスタ修正取込"

    Private _oDatabase As MedicalLib.DataAccess 'オラクル接続用
    Private permitDB As Boolean  'DBへの書き込みを許可するかどうか判定する変数
    '**************************************************************
    ' クラス名：master_mdmas155
    ' プログラムID：MDMAS155
    ' プログラムタイトル：加工工程マスタ修正取込
    '
    '  任意のファイル（CSV形式）を選択し、その内容を
    '  データベース（加工工程マスタ）に取り込む。
    '***************************************************************

#Region "開始・終了イベント"

    '開始イベント
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '*****************************************
        ' ①プログラムIDと、タイトルを設定する。
        ' ②データベースとの接続を開始する。
        '*****************************************
        MedicalLib.Common.ProgramID = PROGRAM_ID
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE
        Try
            _oDatabase = New MedicalLib.DataAccess
            '**** ？↓ *******
            If Not Page.IsPostBack Then
                filZaiko.Focus()
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '終了イベント
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        '*****************************************
        ' 終了時にデータベースとの接続を切断する。
        '*****************************************
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "btnStartイベント"

    '「取り込み開始ボタン」を押したとき
    ' Protected Sub Image1_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Image1.ServerClick
    Protected Sub Image1_ServerClick(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Image1.Click
        '************************************************************************
        ' データベースに取り込むファイルに対し、以下のチェックを行う。
        '   ①取り込むファイルが指定されているかどうか。
        '   ②取り込むファイルが実在するかどうか。
        ' チェックが通った場合は、サーバー上に同じ内容のファイル
        '（一時ファイル）を作る。
        ' 
        ' 一時ファイルのデータがデータベースに書き込むための条件を
        ' 満たしているかチェックする。
        '
        ' チェックが通った場合は、データベースに書き込む。
        ' 最後に一時ファイルを削除する。
        '
        ' ※取込用ファイルの1行目はタイトルのため、チェック・書き込みを行わない。
        '************************************************************************

        Dim FilePass As String = "" '一時的ファイルのパス
        Dim stReader As System.IO.StreamReader = Nothing '読み取り用に開いた一時ファイル
        permitDB = True
        lblCSVError.Text = ""
        'lblCSVError.ForeColor = Color.Red
        lblCom.Visible = False

        Page.Validate("Group1")
        If Not Page.IsValid Then Return

        Try
            FilePass = MedicalLib.Common.GetEnv("SystemTempPath") + Session.SessionID + ".txt"
            filZaiko.SaveAs(FilePass)
            stReader = New StreamReader(FilePass, System.Text.Encoding.GetEncoding("Shift-JIS"))
            Dim strLine As String = stReader.ReadLine '一時ファイルから取得した１行分のデータ
            Dim i2 As Short = 1 '一時ファイルから、読み込んだ行数を数えるカウンタ

            Do Until strLine Is Nothing
                If i2 > 1 Then
                    Dim strCell() As String = strLine.Split(",")
                    Dim countCell As Short = strCell.Length
                    '###### 2010/03/22 サイクル、タクトタイム対応 ######
                    'If countCell <> 8 Then
                    'If countCell <> 11 Then
                    If countCell <> 13 Then
                        'lblCSVError.Text += "<br>" & i2 & "行目：項目数が８個ではありません。"
                        'lblCSVError.Text += "<br>" & i2 & "行目：項目数が１１個ではありません。"
                        lblCSVError.Text += "<br>" & i2 & "行目：項目数が１３個ではありません。"
                        permitDB = False
                    ElseIf checkHalf(strCell(0), strCell(1), strCell(2), strCell(3), strCell(4), strCell(5)) = False Then
                        lblCSVError.Text += "<br>" & i2 & "行目：コメント以外に全角文字が含まれています。"
                        permitDB = False
                    Else
                        masterCheck(strCell(0), strCell(1), strCell(2), i2)
                        checkProcessCode(strCell(3), i2)
                        checkParentCode(strCell(4), i2)
                        checkShop(strCell(5), i2)
                        checkByte(strCell(6), strCell(7), i2)
                        checkNum(strCell(8), strCell(9), i2)  '2010/03/22 Add
                        checkSyuyaku(strCell(11), i2)  '2012/03/26 Add
                        checkKeikaku(strCell(12), i2)  '2012/03/26 Add
                    End If
                    '###### 2010/03/22 サイクル、タクトタイム対応 ######
                End If
                strLine = stReader.ReadLine()
                i2 = i2 + 1
            Loop
            If i2 <= 2 Then 'タイトル以外の行が、取込用ファイルに存在するかどうか
                lblCSVError.Text = "タイトル以下の行が存在しません。"
                permitDB = False
            End If

            If permitDB = True Then
                updDB(FilePass)
            End If
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            stReader.Close()
            System.IO.File.Delete(FilePass)
        End Try
        imgProgress.Attributes("style") = "display:none;"
        lblCom.Attributes("style") = ""
    End Sub

#End Region

#Region "バリデータチェック"

    Protected Sub valCheck02_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles valCheck02.ServerValidate
        '******************************************************
        ' 選択したファイルが実在するかどうかチェックする。
        '*******************************************************
        If filZaiko.HasFile = False Then
            args.IsValid = False
            valCheck02.Text = "加工工程マスタ取込用ファイルが存在しません"
            lblCom.Visible = False
        End If

        '******************************************************
        ' ①選択したファイルが実在する 
        ' ②選択したファイルの拡張子が".txt"か".csv"である。
        ' 以上の条件を満たさない場合は、エラーとなる。
        '*******************************************************

        'Dim fName As String '取り込むファイルのファイル名
        'Dim exetention As String '取り込むファイルの拡張子
        'fName = filZaiko.FileName
        'exetention = System.IO.Path.GetExtension(fName)

        'If filZaiko.HasFile = False Then
        '    args.IsValid = False
        '    valCheck02.Text = "加工工程マスタ取込用ファイルが存在しません"
        'ElseIf Not (exetention = ".txt" Or exetention = ".csv") Then
        '    args.IsValid = False
        '    valCheck02.Text = "取込用ファイルのファイル形式が違います。"
        'End If

    End Sub

#End Region

#Region "DBのデータと照合　入力形式のチェック"

    '加工工程マスタのチェック
    Private Sub masterCheck(ByVal e1 As String, ByVal e2 As String, ByVal e3 As String, ByVal i As Short)
        '**********************************************************************
        ' ①取込用ファイルのカタログ番号が、マスタに存在する。
        ' ②取込用ファイルの基本工順が、マスタに存在する。
        ' ③取込用ファイルの補助工順が、マスタに存在する。
        ' ④基本工順、補助工順が数字のみである。
        ' 以上の条件を一つでも満たさない場合は、DBへの取り込みができない。
        '***********************************************************************
        Dim sql As String
        Dim result As Boolean = True
        If (IsNumeric(e2) = True) And (IsNumeric(e3) = True) Then
            sql = "select * from P_PROCESS_MST where CATALOG_NO = :p1 " _
                & "and P_ORDER_MAIN = :p2 and P_ORDER_SUB = :p3"
            _oDatabase.CreateParam("p1", e1)
            _oDatabase.CreateParam("p2", e2)
            _oDatabase.CreateParam("p3", e3)
            result = sqlRows(sql)
        Else
            result = False
        End If
        If result = False Then
            lblCSVError.Text += "<br>" & i & "行目：加工工程マスタに存在しないデータが含まれています。"
            permitDB = False
        End If
    End Sub

    '工程マスタのチェック
    Private Sub checkProcessCode(ByVal e As String, ByVal i As Short)
        '*********************************************************
        ' ①取込用ファイルの工程コードが、マスタに存在する。
        ' 以上の条件を満たさない場合は、DBへの取り込みができない。
        '*********************************************************
        Dim sql As String
        Dim result As Boolean = True
        sql = "select PROCESS_CD from PROCESS_MST where  PROCESS_CD = :p1 and FAMILY_KB = '1'"
        _oDatabase.CreateParam("p1", e)
        result = sqlRows(sql)
        If result = False Then
            lblCSVError.Text += "<br>" & i & "行目：工程マスタに存在しない工程コードです。"
            permitDB = False
        End If
    End Sub

    '親工程コードのチェック
    Private Sub checkParentCode(ByVal e As String, ByVal i As Short)
        '*********************************************************
        '…親工程コードが入力されている場合のみのチェック… 
        ' ①取込用ファイルの親工程コードが、マスタに存在する。
        ' 以上の条件を満たさない場合は、DBへの取り込みができない。
        '*********************************************************
        Dim sql As String
        Dim result As Boolean = True
        If e <> "" Then
            sql = "select PROCESS_CD from PROCESS_MST where PROCESS_CD = :p1 and FAMILY_KB = '0'"
            _oDatabase.CreateParam("p1", e)
            result = sqlRows(sql)
            If result = False Then
                lblCSVError.Text += "<br>" & i & "行目：工程マスタに存在しない親工程コードです。"
                permitDB = False
            End If
        End If
    End Sub

    'SHOPマスタのチェック
    Private Sub checkShop(ByVal e As String, ByVal i As Short)
        '*********************************************************
        ' ①取込用ファイルのSHOPが、マスタに存在する。
        ' 以上の条件を満たさない場合は、DBへの取り込みができない。
        '*********************************************************
        Dim sql As String
        Dim result As Boolean = True
        sql = "select SHOP from SHOP_MST where SHOP = :p1"
        _oDatabase.CreateParam("p1", e)
        result = sqlRows(sql)
        If result = False Then
            lblCSVError.Text += "<br>" & i & "行目：SHOPマスタに存在しないSHOPです。"
            permitDB = False
        End If
    End Sub

    '訂符、コメントのチェック
    Private Sub checkByte(ByVal e1 As String, ByVal e2 As String, ByVal i As Short)
        If System.Text.Encoding.GetEncoding("shift-jis").GetByteCount(e1) > 2 Then
            lblCSVError.Text += "<br>" & i & "行目：訂符が書き込み可能文字数を超えています。"
            permitDB = False
        End If
        If System.Text.Encoding.GetEncoding("shift-jis").GetByteCount(e2) > 50 Then
            lblCSVError.Text += "<br>" & i & "行目：コメントが書き込み可能文字数を超えています。"
            permitDB = False
        End If
    End Sub

    'サイクルタイム、タクトタイムのチェック
    Private Sub checkNum(ByVal e1 As String, ByVal e2 As String, ByVal i As Short)
        If IsNumeric(e1) = False Then
            lblCSVError.Text += "<br>" & i & "行目：サイクルタイムが数値ではありません。"
            permitDB = False
        End If
        If IsNumeric(e2) = False Then
            lblCSVError.Text += "<br>" & i & "行目：タクトタイムが数値ではありません。"
            permitDB = False
        End If
    End Sub

    '半角以外の文字が入っているかチェック
    Private Function checkHalf(ByVal e1 As String, ByVal e2 As String, ByVal e3 As String, ByVal e4 As String, ByVal e5 As String, ByVal e6 As String) As Boolean
        Dim chr() As String = {e1, e2, e3, e4, e5, e6}
        Dim i As Short = 0
        Dim yn As Boolean = True
        For i = 0 To 5
            If chr(i) = Nothing Then
            ElseIf System.Text.Encoding.GetEncoding("shift-jis").GetByteCount(chr(i)) <> chr(i).Length Then
                yn = False
            End If
        Next
        Return yn
    End Function

    '集約区分チェック
    Private Sub checkSyuyaku(ByVal e12 As String, ByVal i As Short)
        Dim blnRet As Boolean = False
        If e12 <> Nothing Then
            If e12.Trim <> "" Then
                If ("0" <= e12.Trim And e12.Trim <= "9") Or ("A" <= e12.Trim And e12.Trim <= "Z") Then
                    blnRet = True
                End If
            End If
        End If
        If blnRet = False Then
            lblCSVError.Text += "<br>" & i & "行目：集約区分が0～9、A～Zではありません。"
            permitDB = False
        End If
    End Sub

    '計画対象区分チェック
    Private Sub checkKeikaku(ByVal e13 As String, ByVal i As Short)
        Dim blnRet As Boolean = False
        If e13 <> Nothing Then
            If e13.Trim <> "" Then
                If e13.Trim = "0" Or e13.Trim = "1" Then
                    blnRet = True
                End If
            End If
        End If
        If blnRet = False Then
            lblCSVError.Text += "<br>" & i & "行目：計画対象外区分が""1""or""0""ではありません。"
            permitDB = False
        End If
    End Sub

    Private Function sqlRows(ByVal sql As String) As Boolean
        '***************************************************
        ' SQL文を引数とする。データの選択を実行した結果、
        ' 行が１行以上存在すればYESを、
        ' 行が存在しない場合はNOを戻り値とする。
        '***************************************************
        Dim yn As Boolean = True
        Dim oReader As OracleDataReader = Nothing
        oReader = _oDatabase.CreateReaderParam(sql)
        oReader.Read()
        yn = oReader.HasRows
        oReader.Close()
        Return yn
    End Function

#End Region

#Region "DBへ書き込み"

    Private Sub updDB(ByVal pass As String)
        '***************************************
        ' 取込用ファイルのパスを引数とする。
        ' DBにデータの書き込みを行う。
        '***************************************
        Dim wrReader As System.IO.StreamReader = Nothing '書き込み用のデータ１行分
        Dim i2 As Short = 1 '行数用カウンタ
        Dim result As Boolean = False
        Try
            wrReader = New StreamReader(pass, System.Text.Encoding.GetEncoding("Shift-JIS"))
            Dim wrLine As String = wrReader.ReadLine
            _oDatabase.BeginTrans()
            Do Until wrLine Is Nothing
                If i2 > 1 Then '2行目以降のデータのみ書き込み
                    Dim wrCell() As String = wrLine.Split(",")
                    Dim sql As String = ""

                    sql += "update P_PROCESS_MST set"
                    sql += " PROCESS_CD = :P01 ,"
                    sql += " PER_PROCESS_CD = :P02 ,"
                    sql += " UM_P_ORDER = :P03 ,"
                    '##### 2010/08/26 加工工程SHOPマスタ追加 ST #####
                    If wrCell(10).Trim = "1" Then
                        sql += " SHOP = :P04 ,"
                    End If
                    '##### 2010/08/26 加工工程SHOPマスタ追加 ED #####
                    sql += " P_COMMENT = :P05 ,"
                    sql += " CYCLE_TIME = :P06 ,"
                    sql += " TACT_TIME = :P07 ,"
                    sql += " PUT_TOGETHER_FLG = :P12 ,"   '2012/03/26 Add
                    sql += " PLAN_TARGET_FLG = :P13 ,"    '2012/03/26 Add
                    sql += " UPD_DT = :P08 ,"
                    sql += " UPD_TIME = :P09 ,"
                    sql += " UPD_USR = :P10 ,"
                    sql += " UPD_PROGRAM_ID = :P11 "
                    sql += " where CATALOG_NO = :K01 and P_ORDER_MAIN = :K02 and P_ORDER_SUB = :K03"

                    _oDatabase.CreateParam("P01", wrCell(3))                        '（工程コード）
                    _oDatabase.CreateParam("P02", wrCell(4))                        '（親工程コード）
                    _oDatabase.CreateParam("P03", wrCell(6))                        '（工程順序訂符）
                    '##### 2010/08/26 加工工程SHOPマスタ追加 ST #####
                    If wrCell(10).Trim = "1" Then                                   '（SHOP）
                        _oDatabase.CreateParam("P04", wrCell(5))
                    End If
                    '##### 2010/08/26 加工工程SHOPマスタ追加 ED #####
                    _oDatabase.CreateParam("P05", wrCell(7))                        '（コメント）
                    _oDatabase.CreateParam("P06", wrCell(8))                        '（サイクルタイム）
                    _oDatabase.CreateParam("P07", wrCell(9))                        '（タクトタイム）
                    _oDatabase.CreateParam("P08", MedicalLib.Common.GetSystemDate)  '（更新月日）
                    _oDatabase.CreateParam("P09", MedicalLib.Common.GetSystemTime)  '（更新時刻）
                    _oDatabase.CreateParam("P10", Session("UserID"))                '（ユーザーID）
                    _oDatabase.CreateParam("P11", MedicalLib.Common.ProgramID)      '（プログラムID）
                    _oDatabase.CreateParam("P12", wrCell(11))                       '（集約区分）
                    _oDatabase.CreateParam("P13", wrCell(12))                       '（計画対象区分）
                    _oDatabase.CreateParam("K01", wrCell(0))                        '（カタログ番号）
                    _oDatabase.CreateParam("K02", wrCell(1))                        '（基本工順）
                    _oDatabase.CreateParam("K03", wrCell(2))                        '（補助工順）

                    _oDatabase.ExecuteNonQueryParam(sql)

                    '##### 2010/08/26 加工工程SHOPマスタ追加 ST #####
                    If wrCell(10).Trim = "1" Then
                        sql = ""
                        sql += "update P_PROCESS_SHOP_MST set"
                        sql += " TYPICAL_KB = :P01 ,"
                        sql += " UPD_DT = :P02 ,"
                        sql += " UPD_TIME = :P03 ,"
                        sql += " UPD_USR = :P04 ,"
                        sql += " UPD_PROGRAM_ID = :P05 "
                        sql += " where CATALOG_NO = :K01 and P_ORDER_MAIN = :K02 and P_ORDER_SUB = :K03"

                        _oDatabase.CreateParam("P01", "0")                              '（代表区分）
                        _oDatabase.CreateParam("P02", MedicalLib.Common.GetSystemDate)  '（更新月日）
                        _oDatabase.CreateParam("P03", MedicalLib.Common.GetSystemTime)  '（更新時刻）
                        _oDatabase.CreateParam("P04", Session("UserID"))                '（ユーザーID）
                        _oDatabase.CreateParam("P05", MedicalLib.Common.ProgramID)      '（プログラムID）
                        _oDatabase.CreateParam("K01", wrCell(0))                        '（カタログ番号）
                        _oDatabase.CreateParam("K02", wrCell(1))                        '（基本工順）
                        _oDatabase.CreateParam("K03", wrCell(2))                        '（補助工順）
                        _oDatabase.ExecuteNonQueryParam(sql)
                    End If

                    sql = ""
                    sql += "select * from P_PROCESS_SHOP_MST where CATALOG_NO = :K01 "
                    sql += "and P_ORDER_MAIN = :K02 and P_ORDER_SUB = :K03 and SHOP = :K04"
                    _oDatabase.CreateParam("K01", wrCell(0))              '（カタログ番号）
                    _oDatabase.CreateParam("K02", wrCell(1))              '（基本工順）
                    _oDatabase.CreateParam("K03", wrCell(2))              '（補助工順）
                    _oDatabase.CreateParam("K04", wrCell(5))              '（SHOP）
                    result = sqlRows(sql)

                    If result = True Then
                        sql = ""
                        sql += "UPDATE P_PROCESS_SHOP_MST SET "
                        sql += "TYPICAL_KB = :P01 ,"
                        sql += " UPD_DT = :P02 ,"
                        sql += " UPD_TIME = :P03 ,"
                        sql += " UPD_USR = :P04 ,"
                        sql += " UPD_PROGRAM_ID = :P05 "
                        sql += "where CATALOG_NO = :K01 "
                        sql += "and P_ORDER_MAIN = :K02 "
                        sql += "and P_ORDER_SUB = :K03 "
                        sql += "and SHOP = :K04"
                        If wrCell(10).Trim = "1" Then                         '（代表区分）
                            _oDatabase.CreateParam("P01", "1")
                        Else
                            _oDatabase.CreateParam("P01", "0")
                        End If
                        _oDatabase.CreateParam("P02", MedicalLib.Common.GetSystemDate)  '（更新月日）
                        _oDatabase.CreateParam("P03", MedicalLib.Common.GetSystemTime)  '（更新時刻）
                        _oDatabase.CreateParam("P04", Session("UserID"))                '（ユーザーID）
                        _oDatabase.CreateParam("P05", MedicalLib.Common.ProgramID)      '（プログラムID）
                        _oDatabase.CreateParam("K01", wrCell(0))                        '（カタログ番号）
                        _oDatabase.CreateParam("K02", wrCell(1))                        '（基本工順）
                        _oDatabase.CreateParam("K03", wrCell(2))                        '（補助工順）
                        _oDatabase.CreateParam("K04", wrCell(5))                        '（SHOP）
                    Else
                        sql = ""
                        sql += "INSERT INTO P_PROCESS_SHOP_MST VALUES ("
                        sql += ":P01,:P02,:P03,:P04,:P05,:P06,:P07,:P08,:P09,:P10,:P11,:P12)"
                        _oDatabase.CreateParam("P01", wrCell(0))              '（カタログ番号）
                        _oDatabase.CreateParam("P02", wrCell(1))              '（基本工順）
                        _oDatabase.CreateParam("P03", wrCell(2))              '（補助工順）
                        _oDatabase.CreateParam("P04", wrCell(5))              '（SHOP）
                        If wrCell(10).Trim = "1" Then                         '（代表区分）
                            _oDatabase.CreateParam("P05", "1")
                        Else
                            _oDatabase.CreateParam("P05", "0")
                        End If
                        _oDatabase.CreateParam("P06", MedicalLib.Common.GetSystemDate)  '（登録月日）
                        _oDatabase.CreateParam("P07", MedicalLib.Common.GetSystemTime)  '（登録時刻）
                        _oDatabase.CreateParam("P08", Session("UserID"))                '（ユーザーID）
                        _oDatabase.CreateParam("P09", MedicalLib.Common.GetSystemDate)  '（更新月日）
                        _oDatabase.CreateParam("P10", MedicalLib.Common.GetSystemTime)  '（更新時刻）
                        _oDatabase.CreateParam("P11", Session("UserID"))                '（ユーザーID）
                        _oDatabase.CreateParam("P12", MedicalLib.Common.ProgramID)      '（プログラムID）
                    End If
                    _oDatabase.ExecuteNonQueryParam(sql)
                    '##### 2010/08/26 加工工程SHOPマスタ追加 ED #####

                End If
                wrLine = wrReader.ReadLine
                i2 = i2 + 1
            Loop
            _oDatabase.CommitTrans()
            lblCom.Visible = True
            'lblCSVError.Text = "データの取り込みが完了しました。"
            'lblCSVError.ForeColor = Color.Black
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
            _oDatabase.Rollback()
        Finally
            wrReader.Close()
        End Try

    End Sub

#End Region

End Class
