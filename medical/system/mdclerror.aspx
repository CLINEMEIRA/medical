<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.mdclerror" Codebehind="mdclerror.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
    <title>ログイン</title> 
    <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
    <script language="JavaScript" src="../include/medical.js"><!-- 
    // --></script> 
    <script language="javascript" type="text/jscript"><!-- 
        location.target = "_top"; 
    // --></script> 
</head> 
<body onload="if(top.frames.length>0){top.location.href=location.href};startClock();"> 
<form id="iform" runat="server"> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td><win:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="20"><td></td></tr> 
    <!-- エラー表示 --> 
    <tr> 
      <td align="center"> 
          <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Size="15pt" ForeColor="Red" 
              Text="Label"></asp:Label></td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
