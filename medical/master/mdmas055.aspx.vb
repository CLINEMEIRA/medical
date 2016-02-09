Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient
Imports System.IO
Imports System.Text

Partial Class master_mdmas055 
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS055"
    Private Const PROGRAM_TITLE As String = "主材料マスタ取り込み登録"

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
        If Not System.IO.File.Exists(ConfigurationManager.AppSettings("ZaiHostFile")) Then 
            lblMessage.ForeColor = Color.Red 
            lblMessage.Text = "主材料マスタ取込用ファイルが存在しません" 
            Exit Sub 
        End If 
 
        lblMessage.Text = "取り込み中・・・" 
 
        If System.IO.File.Exists(ConfigurationManager.AppSettings("ZaiHostFile")) Then
            Dim sBackup As String = ConfigurationManager.AppSettings(TEXT_BACKUP) + "KLF201.TXT." + MedicalLib.Common.GetSystemDate + MedicalLib.Common.GetSystemTime
            System.IO.File.Copy(ConfigurationManager.AppSettings("ZaiHostFile"), sBackup)
        End If

        '**** 2010/05 項目追加対応 ST ****
        Dim sQueryInsert As String = ""
        sQueryInsert += "INSERT INTO MATL_MST ("
        sQueryInsert += "  MATL_CD, REN_NO, MATL_NM, MATL_SPEC, MATL_TYPE_CD"
        sQueryInsert += ", SHAPE_CD, MATL_SPFT_NO, MAGNETISM, STOCK_LV, LOW_ORDER_WAT"
        sQueryInsert += ", COEFFICIENT, UNIT_KB, UNIT_WAT, DELIVER_TERM, ORDER_CD1"
        sQueryInsert += ", ORDER_CD2, ORDER_CD3, PERSONAL_MATL, SHIP_PR, CRT_DT"
        sQueryInsert += ", CRT_TIME, CRT_USR, UPD_DT, UPD_TIME, UPD_USR"
        sQueryInsert += ", UPD_PROGRAM_ID"
        sQueryInsert += ") VALUES ("
        sQueryInsert += "  :F01, :F02, :F03, :F04, :F05"
        sQueryInsert += ", :F06, :F07, :F08, :F09, :F10"
        sQueryInsert += ", :F11, :F12, :F13, :F14, :F15"
        sQueryInsert += ", :F16, :F17, :F18, :F19, :F20"
        sQueryInsert += ", :F21, :F22, :F23, :F24, :F25"
        sQueryInsert += ", :F26"
        sQueryInsert += ")"
        'Dim sQueryInsert As String = "INSERT INTO MATL_MST VALUES (:F01,:F02,:F03,:F04,:F05,:F06,:F07,:F08,:F09,:F10," + _
        '                                                          ":F11,:F12,:F13,:F14,:F15,:F16,:F17,:F18,:F19,:F20," + _
        '                                                          ":F21,:F22,:F23,:F24,:F25,:F26)"
        '**** 2010/05 項目追加対応 ED ****
        Dim sQueryUpdate As String = "UPDATE MATL_MST SET SHIP_PR = :F01, UPD_DT = :F02,UPD_TIME = :F03,UPD_USR = :F04,UPD_PROGRAM_ID = :F05 " + _
                                                     "WHERE MATL_CD = :K01 AND REN_NO = :K02"

        'テキストファイルの読込み 
        Dim sr As New System.IO.StreamReader(ConfigurationManager.AppSettings("ZaiHostFile"), System.Text.Encoding.GetEncoding("Shift-JIS")) 
        Try 
            _oDatabase.BeginTrans() 
            '内容を一行ずつ読み込む 
            While sr.Peek() > -1 
 
                Dim s As String = sr.ReadLine() 
                If System.Text.Encoding.GetEncoding(932).GetByteCount(s) <> 64 Then Exit While 
 
                If checkShuzai(s.Substring(1, 15).Trim(), s.Substring(19, 5).Trim()) Then 
                    _oDatabase.CreateParam("F01", s.Substring(1, 15).Trim())        'MATL_CD 
                    _oDatabase.CreateParam("F02", s.Substring(19, 5).Trim())        'REN_NO 
                    _oDatabase.CreateParam("F03", "") 
                    _oDatabase.CreateParam("F04", "") 
                    _oDatabase.CreateParam("F05", "") 
                    _oDatabase.CreateParam("F06", "") 
                    _oDatabase.CreateParam("F07", "") 
                    _oDatabase.CreateParam("F08", "") 
                    _oDatabase.CreateParam("F09", 0) 
                    _oDatabase.CreateParam("F10", 0) 
                    _oDatabase.CreateParam("F11", 0) 
                    _oDatabase.CreateParam("F12", "") 
                    _oDatabase.CreateParam("F13", 0) 
                    _oDatabase.CreateParam("F14", 0) 
                    _oDatabase.CreateParam("F15", s.Substring(35, 4).Trim())        'ORDER_CD1 
                    _oDatabase.CreateParam("F16", s.Substring(39, 4).Trim())        'ORDER_CD2 
                    _oDatabase.CreateParam("F17", s.Substring(43, 4).Trim())        'ORDER_CD3 
                    _oDatabase.CreateParam("F18", "") 
                    _oDatabase.CreateParam("F19", s.Substring(24, 11).Trim() / 100) 'SHIP_PR 
                    _oDatabase.CreateParam("F20", MedicalLib.Common.GetSystemDate) 
                    _oDatabase.CreateParam("F21", MedicalLib.Common.GetSystemTime) 
                    _oDatabase.CreateParam("F22", Session("UserID")) 
                    _oDatabase.CreateParam("F23", MedicalLib.Common.GetSystemDate) 
                    _oDatabase.CreateParam("F24", MedicalLib.Common.GetSystemTime) 
                    _oDatabase.CreateParam("F25", Session("UserID")) 
                    _oDatabase.CreateParam("F26", MedicalLib.Common.ProgramID) 
                    _oDatabase.ExecuteNonQueryParam(sQueryInsert)
                Else
                    _oDatabase.CreateParam("F01", s.Substring(24, 11).Trim() / 100)
                    _oDatabase.CreateParam("F02", MedicalLib.Common.GetSystemDate)
                    _oDatabase.CreateParam("F03", MedicalLib.Common.GetSystemTime)
                    _oDatabase.CreateParam("F04", Session("UserID"))
                    _oDatabase.CreateParam("F05", MedicalLib.Common.ProgramID)
                    _oDatabase.CreateParam("K01", s.Substring(1, 15).Trim())        'MATL_CD 
                    _oDatabase.CreateParam("K02", s.Substring(19, 5).Trim())        'REN_NO 
                    _oDatabase.ExecuteNonQueryParam(sQueryUpdate)
                End If
 
            End While 
            _oDatabase.CommitTrans() 
        Catch ex As Exception 
            _oDatabase.Rollback() 
            MedicalLib.PageError.Show(ex.Message) 
        Finally 
            sr.Close() 
        End Try 
        lblMessage.Text = "主材料マスタ取込が完了しました" 
    End Sub 
 
    Private Function checkShuzai(ByVal code As String, ByVal ren As String) As Boolean

        Dim sQuery As String = ""
        Dim temp As Boolean = False
        sQuery += "SELECT MATL_CD FROM MATL_MST "
        sQuery += "WHERE MATL_CD = :K01 AND REN_NO = :K02"
        Try
            _oDatabase.CreateParam("K01", code)
            _oDatabase.CreateParam("K02", ren)
            Dim oReader As OracleDataReader = _oDatabase.CreateReaderParam(sQuery)
            temp = Not oReader.HasRows

            oReader.Close()
        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
        Return temp
    End Function
 
#End Region

End Class 
