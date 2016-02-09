<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas055" Codebehind="mdmas055.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
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
    <tr height="20"> 
        <td style="height: 60px"> 
        </td> 
    </tr> 
    <!-- 入力フォーム --> 
      <tr height="20"> 
        <td align=center> 
          <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="always"> 
              <ContentTemplate> 
                <table border="0" cellpadding="1" cellspacing="0" bgcolor="#a6eb8f"> 
                  <tr><td style="width: 345px; height: 198px;"> 
                    <table border="0" cellpadding="10" cellspacing="1"> 
                      <tr> 
                          <td style="width: 344px; height: 120px" bgcolor="#D9FFCC"> 
                            <asp:ImageButton ID="btnImport" runat="server" ImageUrl="~/image/b_import.gif" OnClick="btnImport_Click" /> 
                          </td> 
                      </tr> 
                      <tr> 
                          <td style="width: 370px; height: 40px" bgcolor="#D9FFCC"> 
                            <asp:Label ID="lblMessage" runat="server" Text="&nbsp;" Font-Size="12pt"></asp:Label> 
                          </td> 
                      </tr> 
                    </table> 
                  </td></tr> 
                </table> 
              </ContentTemplate> 
          </asp:UpdatePanel> 
        </td> 
      </tr> 
    <tr> 
</table> 
</form> 
</body> 
</html> 
