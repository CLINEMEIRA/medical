<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.list_list" Codebehind="list.aspx.vb" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head runat="server"> 
    <title></title>
</head>
<body onload = "fraPage.height = frmList.height;">
  <form id="frmList" runat="server">
    <iframe id="fraPage" scrolling="no" runat="server" height="580px" width="100%"></iframe>
  </form>
</body>
</html>
