<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas037" Codebehind="mdmas037.aspx.vb" %> 
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
    <tr><td><medical:PageHeader id="pageheader" runat="Server" /></td></tr> 
    <tr height="20"><td height="60"></td> 
    </tr> 
    <!-- 入力フォーム --> 
      <tr height="20"> 
        <td align=center> 
          <asp:UpdatePanel ID="udpButton" runat="server" UpdateMode="always"> 
              <ContentTemplate> 
                <table border="0" cellpadding="0" cellspacing="1" bgcolor="#A6EB8F"> 
                  <tr> 
                    <td width="350" height="120" bgcolor="#D9FFCC" align="center"> 
                      <asp:ImageButton ID="btnImport" runat="server" ImageUrl="~/image/b_import.gif" OnClick="btnImport_Click" /> 
                    </td> 
                  </tr> 
                  <tr> 
                    <td height="40" bgcolor="#D9FFCC" align="center"> 
                              <asp:UpdateProgress ID="UpdateProgress1" runat=server>
                                <ProgressTemplate>
                                  取り込み中・・・
                                </ProgressTemplate>
                              </asp:UpdateProgress>
                      <asp:Label ID="lblMessage" runat="server" Text="&nbsp;" Font-Size="12pt"></asp:Label> 
                    </td> 
                  </tr> 
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
