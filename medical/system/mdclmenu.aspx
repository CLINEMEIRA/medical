<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.mdclmenu" Codebehind="mdclmenu.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title>ログイン</title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <style type="text/css"><!--  
    a:hover { text-decoration:none ; } 
    a { text-decoration:none ; } 
  --></style> 
  <script language="javascript" type="text/javascript"><!-- 
    function showMenu2(key1) 
    { 
        document.getElementById('saveKey1').innerText = key1; 
        document.getElementById('btnLink').click(); 
    } 
    function goNext(key2,folder) 
    { 
        document.getElementById('saveKey2').innerText = key2; 
        document.getElementById('saveFolder').innerText = folder; 
        document.getElementById('btnNext').click(); 
    } 
  // --></script> 
</head> 
<body onload="startClock();" link="yellow" alink="yellow" vlink="yellow"> 
<form id="frmMenu" runat="server"> 
  <asp:ScriptManager ID="scrManager" EnablePartialRendering="true" runat="server" /> 
  <iframe src="../temp/refresh.aspx" width="0" height="0"></iframe>
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr><td><win:PageHeader id="pageheader" runat="Server" /></td></tr> 
    <tr height="20"><td></td></tr> 
    <tr> 
      <td align="center"> 
        <table border="0" cellpadding="2" cellspacing="1"> 
          <tr> 
            <td colspan=2 align=center> 
              <asp:panel ID="pnlNendo" runat=server Visible="False"> 
                <font color=red><b>年度の変更が行われていません。年度及び期の変更を行ってください</b></font> 
              </asp:panel> 
            </td> 
          </tr> 
          <tr> 
            <td width="250" rowspan="2" align="left" valign="top"> 
              <!-- メニュー1 --> 
              <asp:UpdatePanel ID="udpMenu1" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <asp:Panel ID="pnlMenu1" Height="510" ScrollBars="Auto" runat="server"> 
                    <table ID="tblMenu1" border="0" cellpadding="0" cellspacing="2" runat="server"> 
                    </table> 
                    <!-- 隠し項目 --> 
                    <input type="hidden" id="saveKey1" runat="server" />
                    <asp:Button ID="btnLink" runat="server" OnClick="btnLink_ServerClick" style="display:none" />
                  </asp:Panel> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
            <td width="700" align="left" valign="top"> 
              <!-- アラート --> 
              <asp:UpdatePanel ID="udpAlarm" runat="server" UpdateMode="Conditional" Visible="False"> 
                <ContentTemplate> 
                  <table border="0" cellpadding="0" cellspacing="2" width="680"> 
                    <tr height="35"> 
                      <td width="33%" align="center" bgcolor="#4e7e4a" style="border-style:solid;border-width:1px;border-color:#087105"> 
                        <font color="#f7f7f7"> 
                          <b> 
                            <a ID="lnkAlarm1" href="mdclalarm.aspx?kubun=1" runat="server">本社(棚在庫)安全在庫割れ</a> 
                            <asp:Label ID="lblAlarm1" Text="本社(棚在庫)安全在庫割れ" runat="server" /> 
                          </b> 
                        </font> 
                      </td> 
                      <td width="33%" align="center" bgcolor="#4e7e4a" style="border-style:solid;border-width:1px;border-color:#087105"> 
                        <font color="#f7f7f7"> 
                          <b> 
                            <a ID="lnkAlarm2" href="mdclalarm.aspx?kubun=2" runat="server">指定工程到達</a> 
                            <asp:Label ID="lblAlarm2" Text="指定工程到達" runat="server" /> 
                          </b> 
                        </font> 
                      </td> 
                      <td width="33%" align="center" bgcolor="#4e7e4a" style="border-style:solid;border-width:1px;border-color:#087105"> 
                        <font color="#f7f7f7"> 
                          <b> 
                            <a ID="lnkAlarm3" href="mdclalarm.aspx?kubun=3" runat="server">源製品・子部品・材料入庫</a> 
                            <asp:Label ID="lblAlarm3" Text="源製品・子部品・材料入庫" runat="server" /> 
                          </b> 
                        </font> 
                      </td> 
                    </tr> 
                  </table> 
                  <asp:Timer ID="timAlarm" runat="server" Interval="60000" OnTick="timAlarm_Tick" /> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
          </tr> 
          <tr> 
            <td align="left" valign="top"> 
              <!-- メニュー2 --> 
              <asp:UpdatePanel ID="udpMenu2" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <asp:Panel ID="pnlMenu2" Height="550" ScrollBars="Auto" runat="server">
                    <table ID="tblMenu2" border="0" width="680" cellpadding="0" cellspacing="2" runat="server"> 
                    </table> 
                    <!-- 隠し項目 --> 
                    <input type="hidden" id="saveKey2"    runat="server" /> 
                    <input type="hidden" id="saveFolder"  runat="server" /> 
                    <asp:Button ID="btnNext" runat="server" onclick="btnNext_ServerClick" style="display:none" />
                  </asp:Panel> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
          </tr> 
        </table> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
