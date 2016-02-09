<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.mdcllogin" Codebehind="mdcllogin.aspx.vb" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ログイン</title> 
    <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
    <script type="text/javascript" src="../include/medical.js"><!-- 
    // --></script> 
</head> 
<body onload="startClock();"> 
<form id="iform" runat="server" onkeydown="return checkEnter();"> 
 <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True" /> 
  <iframe src="../temp/refresh.aspx" width="0" height="0" ></iframe> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td> 
        <table cellspacing="0" cellpadding="0" width="100%" border="0"> 
          <tr height="45"> 
            <td width="50%" valign="bottom" align="left"> 
              <img src="../image/title.gif" border="0" />  
            </td> 
            <td align="right" valign="middle"> 
              <asp:Label ID="pageheader_lblClock" runat="server" Text="" Font-Size="10pt" ForeColor="MidnightBlue"></asp:Label>&nbsp;<br /> 
              <asp:Label ID="lblLogin" runat="server" Text=" " Font-Size="10pt" ForeColor="MidnightBlue"></asp:Label>&nbsp; 
            </td> 
          </tr> 
          <tr height="25"> 
            <td valign="top" align="left" background="../image/line.gif"> 
            </td> 
            <td align="right" background="../image/line.gif"> 
              <asp:ImageButton ID="imgEnd" runat="server" ImageUrl="~/image/m_end.gif" AlternateText="終了" OnClientClick="window.close();return false;" ImageAlign="Top" />&nbsp; 
            </td> 
          </tr> 
        </table> 
      </td> 
    </tr> 
    <tr height="20"><td></td></tr> 
    <!-- エラー表示 --> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center"> 
        <table border="0" cellpadding="1" cellspacing="0" bgcolor="#087105"> 
          <tr> 
            <td> 
              <asp:UpdatePanel ID="udpInput" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <table border="0" cellpadding="10" cellspacing="0" bgcolor="#d9ffcc"> 
                    <tr> 
                      <td> 
                        <table border="0" cellpadding="0" cellspacing="5"> 
                          <tr height="20"> 
                            <td colspan="2" align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>ログイン</b></font></td> 
                          </tr> 
                          <tr height="5"> 
                            <td colspan="2"></td> 
                          </tr> 
                          <tr> 
                            <td width="80" align="center">作業者番号</td> 
                            <td width="120" align="left"> 
                              <asp:TextBox ID="txtUser" runat="server" MaxLength="4" Width="60px" BackColor="#FFFFC0" /><br /> 
                              <asp:RequiredFieldValidator ID="valUser1" runat="server" ControlToValidate="txtUser" ErrorMessage="入力必須項目です" Display="Dynamic" EnableClientScript="False" ValidationGroup="run1" /> 
                            </td> 
                          </tr> 
                          <tr> 
                            <td align="center">パスワード</td> 
                            <td align="left"> 
                              <asp:TextBox ID="txtPass" runat="server" MaxLength="8" Width="120px" TextMode="Password" BackColor="#FFFFC0" /><br /> 
                              <asp:RequiredFieldValidator ID="valPass1" runat="server" ControlToValidate="txtPass" ErrorMessage="入力必須項目です" Display="Dynamic" EnableClientScript="False" ValidationGroup="run1" /> 
                            </td> 
                          </tr> 
                          <tr> 
                            <td colspan="2" align="center"> 
                              <asp:CustomValidator ID="valChack" runat="server" ControlToValidate="" Display="Dynamic" ErrorMessage="" ValidationGroup="run2" EnableClientScript="False" OnServerValidate="valCheck_ServerValidate" />
                            </td> 
                          </tr> 
                          <tr> 
                            <td colspan="2" align="center"> 
                              <br /> 
                                <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="../image/b_login.gif" />
                                <asp:ImageButton ID="btnClear" runat="server" ImageUrl="../image/b_clear.gif" />
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                  </table> 
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
