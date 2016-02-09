<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdsrc000" Codebehind="mdsrc000.aspx.vb" %> 
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head runat="server"> 
  <title></title> 
  <link href="../include/medicallist.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script language="javascript" type="text/javascript"><!-- 
    function closeWindow(day) 
    { 
        parent.window.returnValue = day + ","; 
        parent.window.close(); 
    } 
  // --></script> 
  <style type="text/css"><!--  
    a { text-decoration:none ; } 
  --></style> 
</head> 
<body onload="window.returnValue='';"> 
<form id="frmList" runat="server"> 
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
  <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional" > 
  <ContentTemplate> 
  <table id="tblCalen" runat=server border="0" cellpadding="2" cellspacing="1" bgcolor="#ffab00"> 
    <tr> 
        <td bgcolor="#990000" bordercolor="#ffcc66" colspan="7" height="25"> 
            <table id="tblTitle" runat=server border=0 width=100% height=100%> 
                <tr> 
                    <td align="left" style="font-size: 10pt; width: 30px;"></td> 
                    <td align="center" style="font-weight: bold; font-size: 10pt; color: #ffffcc"></td> 
                    <td align="right" style="font-size: 10pt; width: 30px;"></td> 
                </tr> 
            </table> 
            <asp:Button ID="btnPrev" runat="server" Text="" style="display:none" OnClick="btnPrev_Click" /> 
            <asp:Button ID="btnNext" runat="server" Text="" style="display:none" OnClick="btnNext_Click" /> 
        </td> 
    </tr> 
    <tr> 
      <td bgcolor="#ffcc66" height="25" width="35" align="center" valign="middle" style="font-size: 10pt; font-weight: bold; color: #FF0000" bordercolor="#ffcc66"> 
          日</td> 
      <td bgcolor="#ffcc66" height="25" width="35" align="center" valign="middle" style="font-size: 10pt; font-weight: bold; color: #663399" bordercolor="#ffcc66"> 
          月</td> 
      <td bgcolor="#ffcc66" height="25" width="35" align="center" valign="middle" style="font-size: 10pt; font-weight: bold; color: #663399" bordercolor="#ffcc66"> 
          火</td> 
      <td bgcolor="#ffcc66" height="25" width="35" align="center" valign="middle" style="font-size: 10pt; font-weight: bold; color: #663399" bordercolor="#ffcc66"> 
          水</td> 
      <td bgcolor="#ffcc66" height="25" width="35" align="center" valign="middle" style="font-size: 10pt; font-weight: bold; color: #663399" bordercolor="#ffcc66"> 
          木</td> 
      <td bgcolor="#ffcc66" height="25" width="35" align="center" valign="middle" style="font-size: 10pt; font-weight: bold; color: #663399" bordercolor="#ffcc66"> 
          金</td> 
      <td bgcolor="#ffcc66" height="25" width="35" align="center" valign="middle" style="font-size: 10pt; font-weight: bold; color: #0000FF" bordercolor="#ffcc66"> 
          土</td> 
    </tr> 
    <tr> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
    </tr> 
    <tr> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
    </tr> 
    <tr> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
    </tr> 
    <tr> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
    </tr> 
    <tr> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" bgcolor="#ffffcc" bordercolor="#ffcc66" style="font-size: 10pt; "> 
      </td> 
    </tr> 
    <tr> 
      <td height="25" width="35" align="center" valign="middle" style="font-size: 10pt; ;" bgcolor="#ffffcc" bordercolor="#ffcc66"> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" style="font-size: 10pt; ;" bgcolor="#ffffcc" bordercolor="#ffcc66"> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" style="font-size: 10pt; ;" bgcolor="#ffffcc" bordercolor="#ffcc66"> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" style="font-size: 10pt; ;" bgcolor="#ffffcc" bordercolor="#ffcc66"> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" style="font-size: 10pt; ;" bgcolor="#ffffcc" bordercolor="#ffcc66"> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" style="font-size: 10pt; ;" bgcolor="#ffffcc" bordercolor="#ffcc66"> 
      </td> 
      <td height="25" width="35" align="center" valign="middle" style="font-size: 10pt; ;" bgcolor="#ffffcc" bordercolor="#ffcc66"> 
      </td> 
    </tr> 
  </table> 
  <br /> 
  <center> 
    <asp:ImageButton ID="imgClose" runat="server" ImageUrl="~/image/b_close.gif" AlternateText="閉じる" OnClientClick="window.close();return false;" ImageAlign="Top" /> 
  </center> 
  </ContentTemplate> 
  <Triggers> 
    <asp:AsyncPostBackTrigger ControlID="btnPrev" EventName="Click" /> 
    <asp:AsyncPostBackTrigger ControlID="btnNext" EventName="Click" /> 
  </Triggers> 
  </asp:UpdatePanel> 
</form> 
</body> 
</html> 
