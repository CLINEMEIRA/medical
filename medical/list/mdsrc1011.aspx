﻿<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdsrc1011" Codebehind="mdsrc1011.aspx.vb" %> 
 
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
    function closeWindow(zairyo,lotno,renno) 
    { 
        parent.window.returnValue = zairyo + "," + lotno + "," + renno + ","; 
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
            <td width="100" align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>主材料コード</b></font></td> 
            <td width="440" align="left" bgcolor="#FFE7DF"> 
              <asp:TextBox ID="txtCode" runat="server" onkeyup="document.getElementById('btnSearch').click();" onfocus="moveCursorLast(this);" MaxLength="15" Width="120px"></asp:TextBox> 
              <asp:Button ID="btnSearch" runat="server" Text="" style="display:none"/> 
            </td> 
          </tr> 
          <tr> 
            <td align="center" bgcolor="#FF9966"><font color="#F7F7F7"><b>材料ロットNO</b></font></td> 
            <td align="left" bgcolor="#FFE7DF"> 
              <asp:TextBox ID="txtLotNo" runat="server" onkeyup="document.getElementById('btnSearch').click();" onfocus="moveCursorLast(this);" MaxLength="6" Width="50px"></asp:TextBox> 
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
                <asp:BoundColumn  HeaderText="主材料コード" SortExpression="MATL_CD" DataField="MATL_CD" > 
                    <ItemStyle Width="120px" HorizontalAlign="Left" /> 
                    <HeaderStyle Width="120px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="材料ロットNO" SortExpression="LOT_NO" DataField="LOT_NO" > 
                    <ItemStyle Width="100px" HorizontalAlign="Center" /> 
                    <HeaderStyle Width="100px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn  HeaderText="連NO" SortExpression="REN_NO" DataField="REN_NO" > 
                    <ItemStyle Width="40px" HorizontalAlign="Right" /> 
                    <HeaderStyle Width="40px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="在庫量" SortExpression="STOCK_WAT" DataField="STOCK_WAT" DataFormatString="{0:###,###,##0.00}"> 
                    <ItemStyle Width="90px" HorizontalAlign="Right" /> 
                    <HeaderStyle Width="90px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="フリー在庫量" SortExpression="F_STOCK_WAT" DataField="F_STOCK_WAT" DataFormatString="{0:###,###,##0.00}"> 
                    <ItemStyle Width="90px" HorizontalAlign="Right" /> 
                    <HeaderStyle Width="90px" /> 
                </asp:BoundColumn> 
                <asp:BoundColumn HeaderText="引当済数" SortExpression="MORTGAGE_AMT" DataField="MORTGAGE_AMT" DataFormatString="{0:###,###,##0.00}"> 
                    <ItemStyle Width="90px" HorizontalAlign="Right" /> 
                    <HeaderStyle Width="90px" /> 
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
