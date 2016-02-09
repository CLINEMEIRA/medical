<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdsrc250" Codebehind="mdsrc250.aspx.vb" %> 
 
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
    function closeWindow(syanai,siji) 
    { 
        parent.window.returnValue = syanai + "," + siji + ","; 
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
          <tr> 
            <td width="100" align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>カタログ番号</b></font></td> 
            <td width="386" align="left" bgcolor="#FFE7DF"> 
              <asp:TextBox ID="txtCatalog" runat="server" onkeyup="document.getElementById('btnSearch').click();" onfocus="moveCursorLast(this);" MaxLength="17" Width="140px"></asp:TextBox> 
              <asp:Button ID="btnSearch" runat="server" Text="" style="display:none"/> 
            </td> 
          </tr> 
          <tr> 
            <td align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>指示NO</b></font></td> 
            <td align="left" bgcolor="#FFE7DF"> 
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
                <asp:BoundColumn  HeaderText="社内NO" SortExpression="COMPANY_NO" DataField="COMPANY_NO" > 
                    <ItemStyle Width="50px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="50px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="指示NO" SortExpression="INDICATE_NO" DataField="INDICATE_NO" > 
                    <ItemStyle Width="50px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="50px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="カタログ番号" SortExpression="I_PARTS_NO" DataField="I_PARTS_NO" > 
                    <ItemStyle Width="140px" HorizontalAlign="Left" /> 
                    <HeaderStyle Width="140px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="組番" SortExpression="C_NO" DataField="C_NO" > 
                    <ItemStyle Width="40px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="40px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="材料コード" SortExpression="MATL_CD" DataField="MATL_CD" > 
                    <ItemStyle Width="120px" HorizontalAlign="Left" /> 
                    <HeaderStyle Width="120px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="ロットNO" SortExpression="LOT_NO" DataField="LOT_NO" > 
                    <ItemStyle Width="70px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="70px" /> 
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
