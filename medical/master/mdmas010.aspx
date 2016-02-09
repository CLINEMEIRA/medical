<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas010" Codebehind="mdmas010.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
</head> 
<body onload="startClock();"> 
<form id="frmInput" runat="server"> 
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td><win:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="20"> 
      <td></td> 
    </tr> 
    <tr> 
      <td align="center"> 
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <table> 
              <tr> 
                <td> 
                  <asp:Image ID="imgProcessTitle" runat="server" /> 
                </td> 
              </tr> 
            </table> 
          </ContentTemplate> 
          <Triggers> 
            <asp:AsyncPostBackTrigger ControlID="cmdRun" EventName="Click" />
          </Triggers> 
        </asp:UpdatePanel> 
      </td> 
    </tr><tr height="20"><td></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center"> 
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <table cellspacing="1" cellpadding="0" bgcolor="#f7f7f7" border="0"> 
              <tr height="25"> 
                <!-- 年度 --> 
                <td align="center" bgcolor="#4e7e4a" width="150"><font color="#f7f7f7"><b>年度</b></font></td> 
                <td bgcolor="#d9ffcc" align="left" width="200"> 
                    <asp:TextBox id="txtNendo" runat="server" BackColor="#FFFFC0" Width="80px" MaxLength="4"></asp:TextBox><br /> 
                    <asp:RequiredFieldValidator id="valNendo1" runat="server" Display="Dynamic" ErrorMessage="入力必須項目です" EnableClientScript="False" ControlToValidate="txtNendo" ValidationGroup="check"></asp:RequiredFieldValidator> 
                    <asp:RegularExpressionValidator id="valNendo2" runat="server" Display="Dynamic" ErrorMessage="数値4桁で入力して下さい" ValidationExpression="^[0-9]{4}" EnableClientScript="False" ControlToValidate="txtNendo" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr height="25"> 
                <!-- 期 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>期</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                    <asp:TextBox id="txtKi" runat="server" BackColor="#FFFFC0" Width="80px" MaxLength="3" style="text-align: right"></asp:TextBox><br /> 
                    <asp:RequiredFieldValidator ID="valKi1" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ControlToValidate="txtKi" ValidationGroup="check"></asp:RequiredFieldValidator> 
                    <asp:RegularExpressionValidator ID="valKi2" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+$" ControlToValidate="txtKi" ValidationGroup="check"></asp:RegularExpressionValidator> 
                    <asp:CustomValidator ID="valKi3" runat="server" ControlToValidate="txtKi" Display="Dynamic" 
                        EnableClientScript="False" ErrorMessage="年度と期があっていません" Font-Size="10pt" OnServerValidate="CheckKi" 
                        ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr height="25"> 
                <!-- パスワード有効日数 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>パスワード有効日数</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                    <asp:TextBox id="txtPass" runat="server" Width="80px" MaxLength="3" style="text-align: right" BackColor="#FFFFC0"></asp:TextBox><br /> 
                    <asp:RequiredFieldValidator ID="valPass1" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ControlToValidate="txtPass" ValidationGroup="check"></asp:RequiredFieldValidator> 
                    <asp:RegularExpressionValidator ID="valPass2" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+$" ControlToValidate="txtPass" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td colspan="2" align="center"> 
                  
                    <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="valDate" ValidationGroup="update"></asp:CustomValidator>
                  
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#f7f7f7"></td> 
                <td bgcolor="#f7f7f7" align="left">                  
                    <asp:ImageButton ID="cmdRun" runat="server" ImageUrl="~/image/b_update.gif" />
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
<script type="text/javascript"> 
var valSum = document.getElementById("valSum"); 
if(valSum){ 
    if(valSum.innerText != ''){ alert(valSum.innerText);} 
} 
</script> 
