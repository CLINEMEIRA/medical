<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.mdutl010" Codebehind="mdutl010.aspx.vb" %> 
 
<%@ Register Assembly="ActiveReports.Web, Version=9.2.5098.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" 
    Namespace="GrapeCity.ActiveReports.Web" TagPrefix="ActiveReportsWeb" %> 
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
    <!-- ƒwƒbƒ_[ --> 
    <tr> 
      <td><medical:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height=60><td></td></tr> 
    <tr> 
      <td align="center"> 
        <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="always"> 
          <ContentTemplate> 
            <table border="0" width="320" cellpadding="2" cellspacing="1" bgcolor="#A6EB8F"> 
              <tr height="200"> 
                <td bgcolor="#D9FFCC" align="center" valign="middle"> 
                  <table border="0" cellpadding="0" cellspacing="0"> 
                    <tr> 
                      <td> 
                        <asp:ImageButton ID="imgExp" ImageUrl="~/image/b_mdutl010.gif" runat="server" /> 
                      </td> 
                    </tr> 
                  </table>                      
                </td> 
              </tr>    
              <tr height="40"> 
                <td bgcolor="#D9FFCC" align="center" valign="middle"> 
                  <img id="imgProgress" name="imgProgress" src="../image/loader.gif" visible="false" align="absbottom" runat="server" />
                  <asp:Label ID="lblMessage" Font-Size="12" Text="&nbsp;" ForeColor="#000000" runat="server" />
                </td> 
              </tr> 
            </table> 
            <iframe id="fraPrint" width="100" height="0" runat="server"></iframe>
          </ContentTemplate> 
        </asp:UpdatePanel> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
