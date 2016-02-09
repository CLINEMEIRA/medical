<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas160" Codebehind="mdmas160.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script>
</head> 
<body onload="startClock();"> 
<form id="frmInput" runat="server"> 
  <asp:ScriptManager ID="scrManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr><td><win:PageHeader id="pageheader" runat="Server" /></td></tr> 
    <tr height="20"><td></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center"> 
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <table cellspacing="1" cellpadding="2" bgcolor="#f7f7f7" border="0"> 
              <tr height="20"> 
                <!-- 作業者番号 --> 
                <td align="center" width="180" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>作業者番号</b></font></td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:Label ID="lblCode" Text="XXXX" runat="server" /> 
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 作業者名 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>作業者名</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:Label ID="lblName" Text="ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ" runat="server" /> 
                </td> 
              </tr> 
              <tr> 
                <!-- 旧パスワード --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>旧パスワード</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtPassOld" runat="server" BackColor="#FFFFC0" Width="120px" TextMode=Password MaxLength="8" /><br /> 
                  <asp:RequiredFieldValidator id="valPassOld1" runat="server" Display="Dynamic" ControlToValidate="txtPassOld" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="run" /> 
                  <asp:CustomValidator id="valPassOld2" runat="server" Display="Dynamic" ControlToValidate="txtPassOld" ErrorMessage="パスワードが間違っています" EnableClientScript="False" ValidationGroup="run" /> 
                </td> 
              </tr> 
              <tr> 
                <!-- 新パスワード --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>新パスワード</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtPassNew1" runat="server" BackColor="#FFFFC0" Width="120px" TextMode=Password MaxLength="8" /><br /> 
                  <asp:RequiredFieldValidator id="valPassNew1a" runat="server" Display="Dynamic" ControlToValidate="txtPassNew1" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="run" /> 
                  <asp:CustomValidator id="valPassNew1b" runat="server" Display="Dynamic" ControlToValidate="txtPassNew1" ErrorMessage="パスワードは必ず変更して下さい" EnableClientScript="False" ValidationGroup="run" />
                </td> 
              </tr> 
              <tr> 
                <!-- 新パスワード(確認用) --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>新パスワード(確認用)</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtPassNew2" runat="server" BackColor="#FFFFC0" Width="120px" TextMode=Password MaxLength="8" /><br /> 
                  <asp:RequiredFieldValidator id="valPassNew2a" runat="server" Display="Dynamic" ControlToValidate="txtPassNew2" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="run" /> 
                  <asp:CustomValidator id="valPassNew2b" runat="server" Display="Dynamic" ControlToValidate="txtPassNew2" ErrorMessage="新パスワードと一致しません" EnableClientScript="False" ValidationGroup="run" /> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#f7f7f7"></td> 
                <td bgcolor="#f7f7f7" align="left">                  
                    <asp:ImageButton ID="btnRun" runat="server" ImageUrl="~/image/b_change.gif" />
                    <asp:ImageButton ID="btnClear" runat="server" ImageUrl="~/image/b_clear.gif" />
                </td>
              </tr> 
            </table> 
          </ContentTemplate> 
        </asp:UpdatePanel> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
