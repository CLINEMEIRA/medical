 
Partial Class list_list 
    Inherits System.Web.UI.Page 
 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        If Not Page.IsPostBack Then 
            Dim sPage As String = Request.QueryString("page") 
            Select Case sPage.Substring(0, 8).ToLower() 
                Case "mdsrc000" 
                    Page.Title = "日付選択" 
                Case "mdsrc005" 
                    Page.Title = "ファイル選択" 
                Case "mdsrc010", "mdsrc011"
                    Page.Title = "カタログ番号検索"
                Case "mdsrc020", "mdsrc021", "mdsrc022"
                    Page.Title = "主材料コード検索"
                Case "mdsrc030", "mdsrc030_55"
                    Page.Title = "作業者コード検索"
                Case "mdsrc040" 
                    Page.Title = "工程コード検索" 
                Case "mdsrc050" 
                    Page.Title = "SHOPコード検索" 
                Case "mdsrc060", "mdsrc060_55"
                    Page.Title = "設備コード検索"
                Case "mdsrc070", "mdsrc071" 
                    Page.Title = "外注コード検索" 
                Case "mdsrc080", "mdsrc081", "mdsrc082"
                    Page.Title = "汎用マスタ検索"
                Case "mdsrc090", "mdsrc091", "mdsrc091_55", "mdsrc091_55"
                    Page.Title = "指示NO検索"
                Case "mdsrc100", "mdsrc1001", "mdsrc101", "mdsrc1011" 
                    Page.Title = "材料ロットNO検索" 
                Case "mdsrc120", "mdsrc121", "mdsrc122" 
                    Page.Title = "注文NO検索(主材料発注)" 
                Case "mdsrc140" 
                    Page.Title = "製品グループ検索(L1)" 
                Case "mdsrc141" 
                    Page.Title = "製品グループ検索(L2)" 
                Case "mdsrc150" 
                    Page.Title = "製品グループ検索" 
                Case "mdsrc160", "mdsrc161", "mdsrc163" 
                    Page.Title = "部品在庫検索" 
                Case "mdsrc170" 
                    Page.Title = "分割元指示NO検索"
                Case "mdsrc175"
                    Page.Title = "分割先工程順序検索"
                Case "mdsrc180", "mdsrc185"
                    Page.Title = "注文NO検索"
                Case "mdsrc190", "mdsrc191"
                    Page.Title = "工程順序検索"
                Case "mdsrc200" 
                    Page.Title = "修正工程着工指示検索" 
                Case "mdsrc210" 
                    Page.Title = "主材料引当明細検索" 
                Case "mdsrc220" 
                    Page.Title = "メニュー検索" 
                Case "mdsrc230" 
                    Page.Title = "プログラム検索" 
                Case "mdsrc240" 
                    Page.Title = "着工指示検索(工程票発行)"
                Case "mdsrc250"
                    Page.Title = "指示検索(主材料使用)"
                Case "mdsrc260"
                    Page.Title = "セット構成検索"
            End Select
            fraPage.Attributes("src") = sPage.Replace("@", "&")
        End If 
    End Sub 
 
End Class 
