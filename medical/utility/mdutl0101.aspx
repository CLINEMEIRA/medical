<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.mdutl0101" Async="true" Codebehind="mdutl0101.aspx.vb" %> 
 
<%@ Register Assembly="ActiveReports.Web, Version=9.2.5098.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" Namespace="GrapeCity.ActiveReports.Web" TagPrefix="ActiveReportsWeb" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head runat="server"> 
  <meta http-equiv="cache-control" content="no-cache">  
  <title></title> 
<script language="JavaScript"><!-- 
// 親画面のプログレス画像を非表示 
var objMessage = parent.document.all("lblMessage"); 
objMessage.innerText = "";
// --> </script> 
</head> 
<body> 
<form id="frmPrint" runat="server"> 
</form> 
</body> 
</html> 
<script language="JavaScript"><!-- 
// 親画面のプログレス画像を非表示 
var objFrame   = parent.document.all("imgProgress"); 
var objMessage = parent.document.all("lblMessage"); 
objFrame.style.display = "none";
objMessage.innerText = "エクスポートが完了しました";
// --> </script> 
