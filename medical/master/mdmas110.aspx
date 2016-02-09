<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas110" Codebehind="mdmas110.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow(code,key1,key2,page) 
    { 
        var mode = 'i'; 
        if(code.length > 0) mode = 'u';       
        document.location.href = 'mdmas1101.aspx?mode=' + mode + '&code=' + code + '&key1=' + key1 + '&key2=' + key2 + '&page=' + page 
    } 
  // --></script>
</head> 
<body onload="startClock();"> 
<form id="frmList" runat="server"> 
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td><medical:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="20"><td></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center"> 
        <table cellpadding="0" cellspacing="0" border="0"> 
          <tr> 
            <td align="left"> 
              <!-- 選択 --> 
              <table cellpadding="2" cellspacing="1" border="0"> 
                <tr> 
                  <td align="center" width="100" bgcolor="#4E7E4A"><font color="#F7F7F7"><b>SHOP</b></font></td> 
                  <td align="left" width="300" bgcolor="#D9FFCC"> 
                      <asp:DropDownList ID="ddlShop" runat="server"> 
                          </asp:DropDownList></td> 
                </tr> 
                  <tr> 
                      <td align="center" bgcolor="#4e7e4a" width="100"><font color="#F7F7F7"><b>作業者名</b></font></td> 
                      <td align="left" bgcolor="#D9FFCC" width="300"> 
                          <asp:TextBox ID="txtName" CssClass="full" runat="server" MaxLength="7" Width="200px"></asp:TextBox></td> 
                  </tr> 
                <tr> 
                  <td></td> 
                  <td align="left"> 
                    <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                    <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_new.gif" OnClientClick="selectGridRow('','','',0);return false;" />
                  </td> 
                </tr> 
              </table> 
            </td> 
          </tr> 
          <tr> 
            <td> 
              <!-- 一覧 --> 
              <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" > 
                <ContentTemplate> 
                  <table border="0" width="100%" cellpadding="0" cellspacing="0"> 
                    <tr> 
                      <td align="right"><asp:Label ID="lblCount" runat="server" Text="Label" ForeColor="MidnightBlue"></asp:Label></td> 
                    </tr> 
                  </table> 
                  <asp:DataGrid id="grdList" runat="server" AllowPaging="True" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue"> 
                    <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                    <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                    <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                    <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                    <Columns> 
                        <asp:BoundColumn DataField="WORKER_CD" HeaderText="作業者番号" SortExpression="WORKER_CD"> 
                            <ItemStyle Width="80px" HorizontalAlign="Center" /> 
                            <HeaderStyle Width="80px" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="WORKER_NM" HeaderText="作業者名" SortExpression="WORKER_NM"> 
                            <ItemStyle Width="150px" HorizontalAlign="Left" /> 
                            <HeaderStyle Width="150px" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="WORKER_ABB" HeaderText="略称" SortExpression="WORKER_ABB"> 
                            <ItemStyle Width="60px" HorizontalAlign="Left" /> 
                            <HeaderStyle Width="60px" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="SHOP" HeaderText="SHOP" SortExpression="SHOP"> 
                            <ItemStyle Width="240px" HorizontalAlign="Left" /> 
                            <HeaderStyle Width="240px" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="PASSWORD" HeaderText="パスワード" SortExpression="PASSWORD"> 
                            <ItemStyle Width="80px" HorizontalAlign="Center" /> 
                            <HeaderStyle Width="80px" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="ADMIN_LV" HeaderText="管理レベル" SortExpression="ADMIN_LV"> 
                            <ItemStyle Width="150px" HorizontalAlign="Left" /> 
                            <HeaderStyle Width="150px" /> 
                        </asp:BoundColumn> 
                    </Columns> 
                      <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                          Font-Underline="False" /> 
                  </asp:DataGrid> 
                </ContentTemplate> 
                <Triggers> 
                  <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                </Triggers> 
              </asp:UpdatePanel> 
            </td> 
          </tr> 
        </table> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
