<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.mdsrc005" Codebehind="mdsrc005.aspx.vb" %> 
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head runat="server"> 
  <title></title> 
  <link href="../include/medicallist.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script language="javascript" type="text/javascript"><!-- 
    function closeWindow(catalog,syanai) 
    { 
        if(syanai == "&nbsp;") syanai = ""; 
        parent.window.returnValue = catalog + "," + syanai + ","; 
        parent.window.close(); 
    } 
    function savePosition() 
    { 
        document.frmList.savePos.value = document.getElementById('pnlFolder').scrollTop; 
    } 
  // --></script> 
</head> 
<body onload="window.returnValue='';"> 
<form id="frmList" runat="server"> 
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="false" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="420"> 
    <tr height="20"><td colspan="2"></td></tr> 
    <tr> 
      <td width="200" bgcolor="#FFFFFF"> 
        <asp:UpdatePanel ID="udpFolder" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <asp:Panel ID="pnlFolder" height="300" ScrollBars="Vertical" runat="server" EnableViewState="true"> 
              <asp:TreeView id="trvFolder" runat="server" ImageSet="XPFileExplorer" NodeIndent="15" onClick="savePosition();"> 
                  <ParentNodeStyle Font-Bold="False" /> 
                  <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" /> 
                  <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px" 
                      VerticalPadding="0px" /> 
                  <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="2px" 
                      NodeSpacing="0px" VerticalPadding="2px" /> 
              </asp:TreeView> 
              <input type="hidden" id="savePos" name="savePos" runat="server"/> 
            </asp:Panel> 
          </ContentTemplate> 
        </asp:UpdatePanel> 
      </td> 
      <td width="200" valign="top" bgcolor="#ffffff"> 
        <asp:UpdatePanel ID="udpFile" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <asp:Panel ID="pnlFile" height="300" ScrollBars="Vertical" runat="server"> 
              <asp:DataGrid id="grdList" runat="server" AllowPaging="false" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#FF4D04" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False" Width="190"> 
                <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#FF9966" horizontalalign="Center" height="25px"></HeaderStyle> 
                <AlternatingItemStyle backcolor="#FFE7DF"></AlternatingItemStyle> 
                <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#FFFFCC" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                <Columns> 
                  <asp:BoundColumn DataField="filename"> 
                    <ItemStyle Width="190" HorizontalAlign="Left" /> 
                  </asp:BoundColumn> 
                  <asp:BoundColumn DataField="dummy" Visible="false"> 
                    <ItemStyle Width="10" HorizontalAlign="Left" /> 
                  </asp:BoundColumn> 
                </Columns> 
                <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
              </asp:DataGrid> 
            </asp:Panel> 
          </ContentTemplate> 
          <Triggers> 
            <asp:AsyncPostBackTrigger ControlID="trvFolder" EventName="SelectedNodeChanged" /> 
          </Triggers> 
        </asp:UpdatePanel> 
      </td> 
    </tr> 
    <tr height="20"><td colspan="2"></td></tr> 
    <tr> 
      <td align="center" colspan="2"> 
        <asp:ImageButton ID="imgClose" runat="server" ImageUrl="~/image/b_close.gif" AlternateText="閉じる" OnClientClick="window.close();return false;" ImageAlign="Top" /> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
