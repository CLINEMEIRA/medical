<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdsrc150" Codebehind="mdsrc150.aspx.vb" %> 
 
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
    function closeWindow(gcode1,gname1,gcode2,gname2,kumi2) 
    { 
        parent.window.returnValue = gcode1 + "," + gname1 + "," + gcode2 + "," + gname2 + "," + kumi2 + ","; 
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
            <td width="100" align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>グループ1名称</b></font></td> 
            <td width="520" align="left" bgcolor="#FFE7DF"> 
              <asp:TextBox ID="txtName1" runat="server" onkeyup="document.getElementById('btnSearch').click();" onfocus="moveCursorLast(this);" MaxLength="20" Width="200px"></asp:TextBox> 
            </td> 
          </tr> 
          <tr> 
            <td align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>グループ2名称</b></font></td> 
            <td align="left" bgcolor="#FFE7DF"> 
              <asp:TextBox ID="txtName2" runat="server" onkeyup="document.getElementById('btnSearch').click();" onfocus="moveCursorLast(this);" MaxLength="20" Width="200px"></asp:TextBox> 
              <asp:Button ID="btnSearch" runat="server" Text="" style="display:none"/> 
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
                <asp:BoundColumn  HeaderText="グループNO1" SortExpression="GRP_NO1" DataField="GRP_NO1" > 
                    <ItemStyle Width="85px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="85px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="グループ名称1" SortExpression="GRP_NM1" DataField="GRP_NM1" > 
                    <ItemStyle Width="200px" HorizontalAlign="Left" /> 
                    <HeaderStyle Width="200px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="グループNO2" SortExpression="GRP_NO2" DataField="GRP_NO2" > 
                    <ItemStyle Width="85px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="85px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="グループ名称2" SortExpression="GRP_NM2" DataField="GRP_NM2" > 
                    <ItemStyle Width="200px" HorizontalAlign="Left" /> 
                    <HeaderStyle Width="200px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="組番" SortExpression="C_NO" DataField="C_NO" > 
                    <ItemStyle Width="40px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="40px" /> 
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
