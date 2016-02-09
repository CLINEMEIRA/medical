Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient
Imports System.IO 
Imports System.Text 
 
Partial Class master_mdmas037
    Inherits System.Web.UI.Page

    Private Const PROGRAM_ID As String = "MDMAS037"
    Private Const PROGRAM_TITLE As String = "部品マスタ組番更新取込"

    Private _oDatabase As MedicalLib.DataAccess
    Private _FilePass As String = "BuhinUpdHostFile"
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
        If Not System.IO.File.Exists(ConfigurationManager.AppSettings(_FilePass)) Then
            lblMessage.ForeColor = Color.Red
            lblMessage.Text = "部品マスタ取込用ファイルが存在しません"
            Exit Sub
        End If

        'lblMessage.Text = "取り込み中・・・"

        If System.IO.File.Exists(ConfigurationManager.AppSettings("BuhinUpdHostFile")) Then
            Dim sBackup As String = ConfigurationManager.AppSettings(TEXT_BACKUP) + "BUHMUPD.TXT." + MedicalLib.Common.GetSystemDate + MedicalLib.Common.GetSystemTime
            System.IO.File.Copy(ConfigurationManager.AppSettings("BuhinUpdHostFile"), sBackup)
        End If

        Dim sQuery As String = ""

        'テキストファイルの読込み 
        Dim sr As New System.IO.StreamReader(ConfigurationManager.AppSettings(_FilePass), System.Text.Encoding.GetEncoding("Shift-JIS"))
        Try
            _oDatabase.BeginTrans()
            '内容を一行ずつ読み込む 
            While sr.Peek() > -1
                Dim s As String = sr.ReadLine()
                If Not (System.Text.Encoding.GetEncoding(932).GetByteCount(s) = 64 Or System.Text.Encoding.GetEncoding(932).GetByteCount(s) = 31) Then Exit While
                If ("W1" <= s.Substring(23, 2) And s.Substring(23, 2) <= "W9") Or s.Substring(23, 2) = "Z9" Then

                    If checkUpdate(s.Substring(17, 6)) Then

                        '部品マスタ更新
                        updateBuhinM(s.Substring(17, 6), s.Substring(23, 2), s.Substring(25, 3), s.Substring(30, 1))

                        '指示テーブル更新
                        updateSiji(s.Substring(17, 6), s.Substring(23, 2), s.Substring(30, 1))

                        '部品在庫テーブル更新
                        updateBuhinZaiko(s.Substring(17, 6), s.Substring(23, 2), s.Substring(30, 1))

                        '主材料引当明細テーブル更新
                        updateZaiHikiate(s.Substring(17, 6), s.Substring(23, 2))

                        '主材料出庫明細テーブル更新
                        updateZaiShukko(s.Substring(17, 6), s.Substring(23, 2))

                        '外注発注入荷テーブル更新
                        updateGaityuHattyu(s.Substring(17, 6), s.Substring(23, 2))

                        '部品入庫明細テーブル更新
                        updateBuhinNyuko(s.Substring(17, 6), s.Substring(23, 2), s.Substring(30, 1))

                        '部品出庫明細テーブル更新
                        updateBuhinShukko(s.Substring(17, 6), s.Substring(23, 2))

                        '個別ロット累積テーブル更新
                        updateKobetuLot(s.Substring(17, 6), s.Substring(23, 2), s.Substring(30, 1), s.Substring(28, 2))

                    End If
                End If
            End While
            _oDatabase.CommitTrans()
        Catch ex As Exception
            _oDatabase.Rollback()
            MedicalLib.PageError.Show(ex.Message)
        Finally
            sr.Close()
        End Try

        lblMessage.Text = "部品マスタ取込が完了しました"
    End Sub

#End Region

#Region " ファイル関数 "

    '部品マスタ存在 ？
    Private Function checkUpdate(ByVal sShanai As String) As Boolean

        Dim sQuery As String = ""
        Dim oReader As OracleDataReader = Nothing

        Try
            sQuery = "SELECT COMPANY_NO FROM PARTS_MST WHERE COMPANY_NO = :K01 "
            _oDatabase.CreateParam("K01", sShanai)

            oReader = _oDatabase.CreateReaderParam(sQuery)

            Return oReader.HasRows

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        Finally
            oReader.Close()
        End Try
    End Function


    '部品マスタ更新
    Private Sub updateBuhinM(ByVal sShanai As String, ByVal sKumi As String, ByVal sSeizouCD As String, ByVal sAssy As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE PARTS_MST SET C_NO = :F01,M_SECTION_CD = :F02,ASSY_KB = :F03," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE COMPANY_NO = :K01 "

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F02", sSeizouCD)
            _oDatabase.CreateParam("F03", sAssy)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '指示テーブル更新
    Private Sub updateSiji(ByVal sShanai As String, ByVal sKumi As String, ByVal sAssy As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE INDICATE_TBL SET C_NO = :F01,ASSY_KB = :F02," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE INDICATE_DECIDE_FLG = 'K' "
            sQuery += "AND TRIM(DEL_FLG) IS NULL "
            sQuery += "AND COMPANY_NO = :K01"

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F02", sAssy)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '部品在庫テーブル更新
    Private Sub updateBuhinZaiko(ByVal sShanai As String, ByVal sKumi As String, ByVal sAssy As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE PARTS_STOCK_TBL SET C_NO = :F01,ASSY_KB = :F02," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE COMPANY_NO = :K01"

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F02", sAssy)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '主材料引当明細テーブル更新
    Private Sub updateZaiHikiate(ByVal sShanai As String, ByVal sKumi As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE MATL_MORTGAGE_TBL SET C_NO = :F01," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE COMPANY_NO = :K01 "
            sQuery += "AND (((SHIP_DT >= :K02 AND SHIP_DT <= :K03) OR SHIP_DT = '00000000') OR " + _
                          "(COR_SHIP_DT >= :K04 AND COR_SHIP_DT <= :K05))"

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.CreateParam("K02", MedicalLib.Common.GetSystemDate.Substring(0, 6) + "01")
            _oDatabase.CreateParam("K03", getLastDay(MedicalLib.Common.GetSystemDate.Substring(0, 6)))
            _oDatabase.CreateParam("K04", MedicalLib.Common.GetSystemDate.Substring(0, 6) + "01")
            _oDatabase.CreateParam("K05", getLastDay(MedicalLib.Common.GetSystemDate.Substring(0, 6)))
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '主材料出庫明細テーブル更新
    Private Sub updateZaiShukko(ByVal sShanai As String, ByVal sKumi As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE MATL_SHIP_TBL SET C_NO = :F01," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE COMPANY_NO = :K01 "
            sQuery += "AND (((SHIP_DT >= :K02 AND SHIP_DT <= :K03) OR SHIP_DT = '00000000') OR " + _
                          "(COR_SHIP_DT >= :K04 AND COR_SHIP_DT <= :K05))"

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.CreateParam("K02", MedicalLib.Common.GetSystemDate.Substring(0, 6) + "01")
            _oDatabase.CreateParam("K03", getLastDay(MedicalLib.Common.GetSystemDate.Substring(0, 6)))
            _oDatabase.CreateParam("K04", MedicalLib.Common.GetSystemDate.Substring(0, 6) + "01")
            _oDatabase.CreateParam("K05", getLastDay(MedicalLib.Common.GetSystemDate.Substring(0, 6)))
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '外注発注入荷テーブル更新
    Private Sub updateGaityuHattyu(ByVal sShanai As String, ByVal sKumi As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE CONTRACTOUT_ORDER_TBL SET C_NO = :F01," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE COMPANY_NO = :K01 "
            sQuery += "AND ((AOG_DT >= :K02 AND AOG_DT <= :K03) OR AOG_DT = '00000000') "

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.CreateParam("K02", MedicalLib.Common.GetSystemDate.Substring(0, 6) + "01")
            _oDatabase.CreateParam("K03", getLastDay(MedicalLib.Common.GetSystemDate.Substring(0, 6)))
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '部品入庫明細テーブル更新
    Private Sub updateBuhinNyuko(ByVal sShanai As String, ByVal sKumi As String, ByVal sAssy As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE PARTS_WH_TBL SET C_NO = :F01,ASSY_KB = :F02," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE COMPANY_NO = :K01 "
            sQuery += "AND (WH_DT >= :K02 AND WH_DT <= :K03) "

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F02", sAssy)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.CreateParam("K02", MedicalLib.Common.GetSystemDate.Substring(0, 6) + "01")
            _oDatabase.CreateParam("K03", getLastDay(MedicalLib.Common.GetSystemDate.Substring(0, 6)))
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '部品出庫明細テーブル更新
    Private Sub updateBuhinShukko(ByVal sShanai As String, ByVal sKumi As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE PARTS_SHIP_TBL SET C_NO = :F01," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE COMPANY_NO = :K01 "
            sQuery += "AND (SHIP_DT >= :K02 AND SHIP_DT <= :K03)"

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.CreateParam("K02", MedicalLib.Common.GetSystemDate.Substring(0, 6) + "01")
            _oDatabase.CreateParam("K03", getLastDay(MedicalLib.Common.GetSystemDate.Substring(0, 6)))
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

    '個別ロット累積テーブル更新
    Private Sub updateKobetuLot(ByVal sShanai As String, ByVal sKumi As String, ByVal sAssy As String, ByVal sPartsKb As String)

        Dim sQuery As String = ""

        Try
            sQuery += "UPDATE LOT_ACCUMULATE_TBL SET C_NO = :F01,ASSY_KB = :F02,PARTS_KB = :F03," + _
                                           "UPD_DT=:F11,UPD_TIME=:F12,UPD_USR=:F13,UPD_PROGRAM_ID=:F14 "
            sQuery += "WHERE COMPANY_NO = :K01 "

            _oDatabase.CreateParam("F01", sKumi)
            _oDatabase.CreateParam("F02", sAssy)
            _oDatabase.CreateParam("F03", sPartsKb)
            _oDatabase.CreateParam("F11", MedicalLib.Common.GetSystemDate)
            _oDatabase.CreateParam("F12", MedicalLib.Common.GetSystemTime)
            _oDatabase.CreateParam("F13", Session("UserID"))
            _oDatabase.CreateParam("F14", MedicalLib.Common.ProgramID)
            _oDatabase.CreateParam("K01", sShanai)
            _oDatabase.ExecuteNonQueryParam(sQuery)

        Catch ex As Exception
            MedicalLib.PageError.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region " ユーザー関数 "

    '最終日付取得 
    Private Function getLastDay(ByVal nengetu As String) As String
        Select Case nengetu.Substring(4, 2)
            Case "02"
                If IsDate(nengetu.Substring(0, 4) & "/" & nengetu.Substring(4, 2) & "/29") Then
                    nengetu = nengetu & "29"
                Else
                    nengetu = nengetu & "28"
                End If
            Case "04", "06", "09", "11"
                nengetu = nengetu & "30"
            Case Else
                nengetu = nengetu & "31"
        End Select

        Return nengetu

    End Function

#End Region

End Class