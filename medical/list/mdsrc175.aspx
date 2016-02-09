<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdsrc175" Codebehind="mdsrc175.aspx.vb" %> 
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head runat="server"> 
  <title></title> 
  <link href="../include/medicallist.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script language="JavaScript" src="../include/medicallist.js"><!-- 
  // --></script> 
  <script language="javascript" type="text/javascript"><!-- 
    function closeWindow(kihon,hojo,koutei) 
    { 
        parent.window.returnValue = kihon + "," + hojo + "," + koutei + ","; 
        parent.window.close(); 
    } 
  // --></script> 
</head> 
<body onload="window.returnValue='';"> 
<form id="frmList" runat="server"> 
  <asp:ScriptManager ID="scrManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <tr height="20"><td></td></tr> 
    <tr> 
      <td width="100%" align="center"> 
        <table border="0" cellpadding="2" cellspacing="1"> 
          <tr height="20"> 
            <td width="100" align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>ÉJÉ^ÉçÉOî‘çÜ</b></font></td> 
            <td width="250" align="left" bgcolor="#FFE7DF"> 
              <asp:Label ID="lblCatalog" runat="server"></asp:Label> 
            </td> 
          </tr> 
        </table> 
      </td> 
    </tr> 
    <tr height="5"><td></td></tr> 
    <tr height="360"> 
      <td align="center" valign="top"> 
        <!-- àÍóó --> 
        <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional" > 
          <ContentTemplate> 
            <table border="0" width="100%" cellpadding="0" cellspacing="0"> 
              <tr> 
                <td align="center"><asp:Label ID="lblCount" runat="server" Text="Label" ForeColor="MidnightBlue"></asp:Label></td> 
              </tr> 
            </table> 
            <asp:DataGrid id="grdList" runat="server" AllowPaging="True" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#FF4D04" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue"> 
              <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#FF9966" horizontalalign="Center" height="25px"></HeaderStyle> 
              <AlternatingItemStyle backcolor="#FFE7DF"></AlternatingItemStyle> 
              <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
              <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#FFFFCC" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
              <Columns> 
                <asp:TemplateColumn HeaderText="çHèá" SortExpression="PROCESS_ORDER" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Left"> 
                  <ItemTemplate> 
                    <asp:Label ID="lblKoujun" runat="server" Text='<%#GetKoujun(DataBinder.Eval(Container, "DataItem.P_ORDER_MAIN"),DataBinder.Eval(Container, "DataItem.P_ORDER_SUB"))%>'></asp:Label> 
                  </ItemTemplate> 
                </asp:TemplateColumn> 
                <asp:BoundColumn  HeaderText="äÓñ{çHèá" DataField="P_ORDER_MAIN" Visible="false"> 
                    <ItemStyle Width="10px" HorizontalAlign="Center" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="ï‚èïçHèá" DataField="P_ORDER_SUB" Visible="false"> 
                    <ItemStyle Width="10px" HorizontalAlign="Center" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="çHíˆÉRÅ[Éh" SortExpression="PROCESS_CD" DataField="PROCESS_CD" > 
                    <ItemStyle Width="90px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="90px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="çHíˆñºèÃ" DataField="P_ORDER_NM" SortExpression="P_ORDER_NM"> 
                    <ItemStyle Width="160px" HorizontalAlign="left" /> 
                    <HeaderStyle Width="160px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="SHOP" SortExpression="SHOP" DataField="SHOP" > 
                    <ItemStyle Width="40px" HorizontalAlign="center" /> 
                    <HeaderStyle Width="40px" /> 
                </asp:BoundColumn> 
              </Columns> 
              <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
            </asp:DataGrid> 
          </ContentTemplate> 
        </asp:UpdatePanel> 
      </td> 
    </tr> 
    <tr> 
      <td align="center"> 
        <asp:ImageButton ID="imgClose" runat="server" ImageUrl="~/image/b_close.gif" AlternateText="ï¬Ç∂ÇÈ" OnClientClick="window.close();return false;" ImageAlign="Top" /> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
