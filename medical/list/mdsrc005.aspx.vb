Imports System.IO 
Imports System.Drawing 
Imports System.Data
Imports System.Data.OracleClient

Partial Class mdsrc005 
    Inherits System.Web.UI.Page 
 
    Private Const PROGRAM_ID As String = "MDSRC005" 
    Private Const PROGRAM_TITLE As String = "ファイル選択" 
 
    Private _oDatabase As MedicalLib.DataAccess 
 
#Region " イベント " 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        MedicalLib.Common.ProgramID = PROGRAM_ID 
        MedicalLib.Common.ProgramTitle = PROGRAM_TITLE 
        Try 
            _oDatabase = New MedicalLib.DataAccess 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
        If Not Page.IsPostBack Then 
            DisplayInit() 
            pnlFolder.Attributes("scrollTop") = 206 
        Else 
            Dim sScript As New System.Text.StringBuilder 
            sScript.Append("<script language=""JavaScript"">") 
            sScript.Append("document.getElementById('pnlFolder').scrollTop = " & savePos.Value) 
            sScript.Append("</script>") 
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "authenticated", sScript.ToString()) 
            'pnlFolder.Attributes("scrollTop") = savePos.Value 
            'udpFolder.Update() 
        End If 
    End Sub 
  
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Try
            _oDatabase.Close()
            _oDatabase = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub trvFolder_SelectedNodeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trvFolder.SelectedNodeChanged 
        GridBind(CType(sender, TreeView).SelectedNode.Value) 
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
            'oLine.Attributes("onclick") = "closeWindow('" + HttpUtility.UrlEncode(oLine.Cells(0).Text) + "','" + HttpUtility.UrlEncode(oLine.Cells(1).Text) + "')" 
            oLine.Attributes("onclick") = "closeWindow('" + oLine.Cells(1).Text + "')" 
        End If 
    End Sub 
 
#End Region 
 
#Region " 画面表示 " 
 
    '画面初期化 
    Private Sub DisplayInit() 
        Dim sRoot As String = Server.MapPath("~/") 
        SetShowNode(sRoot, trvFolder.Nodes) 
        trvFolder.CollapseAll() 
    End Sub 
 
    Sub SetShowNode(ByVal sPath As String, ByVal oNodes As TreeNodeCollection) 
        Dim aryDir() As String = Directory.GetDirectories(sPath) 
        For Each strDir As String In aryDir 
            Dim sFile As String = strDir.Substring(sPath.Length) 
            Dim oNode As New TreeNode() 
            oNode.Text = sFile 
            oNode.Value = strDir 
            oNode.ImageUrl = "../image/folder.gif" 
            oNode.SelectAction = TreeNodeSelectAction.Select 
            SetShowNode(strDir + "\", oNode.ChildNodes) 
            oNodes.Add(oNode) 
        Next 
        'Dim aryFle() As String = Directory.GetFiles(sPath, "*.aspx") 
        'For Each strFle As String In aryFle 
        '    Dim sFile As String = strFle.Substring(sPath.Length + 1) 
        '    Dim oNode As New TreeNode() 
        '    oNode.Text = sFile 
        '    oNode.Value = strFle 
        '    oNode.ImageUrl = "../image/aspx_file.gif" 
        '    oNode.SelectAction = TreeNodeSelectAction.Select 
        '    oNodes.Add(oNode) 
        'Next 
    End Sub 
 
    Private Sub GridBind(ByVal sFolder As String) 
        Try 
            grdList.DataSource = CreateDataSource(sFolder) 
            grdList.DataBind() 
        Catch tex As Threading.ThreadAbortException 
            Throw 
        Catch ex As Exception 
            MedicalLib.PageError.Show(ex.Message) 
        End Try 
    End Sub 
 
#End Region 
 
    Private Function CreateDataSource(ByVal sFolder As String) As ICollection 
        Dim sValue As String 
        Dim oDInfo As DirectoryInfo = New DirectoryInfo(sFolder) 
        Dim oFInfo As FileInfo() = oDInfo.GetFiles("*.aspx") 
        Dim oTable As DataTable = New DataTable() 
        Dim oRow As DataRow 
        oTable.Columns.Add(New DataColumn("filename", System.Type.GetType("System.String"))) 
        oTable.Columns.Add(New DataColumn("dummy", System.Type.GetType("System.String"))) 
        For i As Integer = 0 To oFInfo.Length - 1 
            oRow = oTable.NewRow() 
            oRow(0) = oFInfo(i).Name 
            sValue = oFInfo(i).Directory.ToString & "\" & oFInfo(i).Name 
            sValue = sValue.Replace(Server.MapPath("~/"), "") 
            sValue = "/" + sValue.Replace("\", "/") 
            oRow(1) = sValue 
            oTable.Rows.Add(oRow) 
        Next 
        Dim oView As DataView = New DataView(oTable) 
        'oView.RowFilter = "filename LIKE '*.aspx'" 
        Return oView 
    End Function 
 
End Class 
