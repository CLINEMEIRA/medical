<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdsrc270" Codebehind="mdsrc270.aspx.vb" %> 
 
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
    function closeWindow(siji,syanai,catalog) 
    { 
        parent.window.returnValue = siji + "," + syanai + "," + catalog + ","; 
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
          <tr height="23"> 
            <td width="100" align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>部品番号</b></font></td> 
            <td width="310" align="left" bgcolor="#FFE7DF"> 
              <asp:Label ID="lblBuhin" runat="server"></asp:Label>
            </td> 
          </tr> 
          <tr> 
            <td width="100" align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>源製品番号</b></font></td> 
            <td width="310" align="left" bgcolor="#FFE7DF"> 
              <asp:TextBox ID="txtCatalog" runat="server" onkeyup="document.getElementById('btnSearch').click();" onfocus="moveCursorLast(this);" MaxLength="17" Width="140px"></asp:TextBox> 
              <asp:Button ID="btnSearch" runat="server" Text="" style="display:none"/> 
            </td> 
          </tr> 
          <tr> 
            <td width="100" align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>指示NO</b></font></td> 
            <td width="310" align="left" bgcolor="#FFE7DF"> 
              <asp:TextBox ID="txtSiji" runat="server" onkeyup="document.getElementById('btnSearch').click();" onfocus="moveCursorLast(this);" MaxLength="5" Width="40px"></asp:TextBox> 
            </td> 
          </tr> 
        </table> 
      </td> 
    </tr> 
    <tr height="5"><td></td></tr> 
    <tr height="360"> 
      <td align="center" valign="top"> 
        <!-- 一覧 --> 
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
                <asp:BoundColumn HeaderText="指示NO" SortExpression="INDICATE_NO" DataField="INDICATE_NO" > 
                    <ItemStyle Width="50px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="50px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="社内NO" SortExpression="COMPANY_NO" DataField="COMPANY_NO" > 
                    <ItemStyle Width="50px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="50px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="源製品番号" SortExpression="CATALOG_NO" DataField="CATALOG_NO" > 
                    <ItemStyle Width="140px" HorizontalAlign="Left" /> 
                    <HeaderStyle Width="140px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="フリー在庫" SortExpression="F_STOCK_AMT" DataField="F_STOCK_AMT" DataFormatString="{0:#,###,##0}"> 
                    <ItemStyle Width="80px" HorizontalAlign="Right" /> 
                    <HeaderStyle Width="80px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="実在庫" SortExpression="RSTOCK_AMT" DataField="RSTOCK_AMT" DataFormatString="{0:#,###,##0}"> 
                    <ItemStyle Width="80px" HorizontalAlign="Right" /> 
                    <HeaderStyle Width="80px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="優先順位" SortExpression="PRIORITY_SORT" DataField="PRIORITY_SHOW"> 
                    <ItemStyle Width="80px" HorizontalAlign="Right" /> 
                    <HeaderStyle Width="80px" /> 
                </asp:BoundColumn> 
              </Columns> 
              <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
            </asp:DataGrid> 
          </ContentTemplate> 
          <Triggers> 
              <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" /> 
          </Triggers> 
        </asp:UpdatePanel> 
      </td> 
    </tr> 
    <tr> 
      <td align="center"> 
        <asp:ImageButton ID="imgClose" runat="server" ImageUrl="~/image/b_close.gif" AlternateText="閉じる" OnClientClick="window.close();return false;" ImageAlign="Top" /> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
