<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas1401" Codebehind="mdmas1401.aspx.vb" %> 
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
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td><win:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="20"><td></td></tr> 
    <tr><td align="center"> 
        <asp:Image ID="imgProcessTitle" runat="server" /></td></tr> 
    <tr height="20"><td></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center"> 
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <table cellspacing="1" cellpadding="2" bgcolor="#f7f7f7" border="0"> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label1" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">情報区分</asp:Label> 
                </td> 
                <td bgcolor="#d9ffcc" align="left" style="width: 380px"> 
                  <asp:TextBox id="txtKubun" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="60px" MaxLength="5"></asp:TextBox> 
                    <br /> 
                  <asp:RequiredFieldValidator id="valKubun1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtKubun" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator id="valKubun2" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtKubun" ErrorMessage="半角英数で入力して下さい" ValidationExpression="^[0-9a-zA-Z]+$" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator id="valKubun3" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtKubun" ErrorMessage="登録されていません" EnableClientScript="False" ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label2" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">識別コード</asp:Label> 
                </td> 
                <td bgcolor="#d9ffcc" align="left" style="width: 380px"> 
                  <asp:TextBox id="txtCode" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="100px" MaxLength="10"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator id="valCode1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:CustomValidator ID="valCode3" runat="server" ControlToValidate="txtCode" Display="Dynamic" EnableClientScript="False" ValidationGroup="check"></asp:CustomValidator></td>
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label3" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">情報区分名</asp:Label> 
                </td> 
                <td bgcolor="#d9ffcc" align="left" style="width: 380px"> 
                  <asp:Label ID="lblName" runat="server" Height="20px" style="vertical-align: middle"></asp:Label> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label4" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">項目名漢字</asp:Label> 
                </td> 
                <td bgcolor="#d9ffcc" align="left" style="width: 380px"> 
                  <asp:TextBox id="txtKanji" CssClass="full" runat="server" Font-Size="10pt" Width="360px" MaxLength="50" BackColor="#FFFFC0"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator ID="valKanji1" runat="server" ControlToValidate="txtKanji" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:CustomValidator ID="valKanji2" runat="server" ControlToValidate="txtKanji" Display="Dynamic" 
                      EnableClientScript="False" ErrorMessage="50バイト以内で入力してください" 
                      ValidationGroup="check"></asp:CustomValidator> 
                  <asp:CustomValidator ID="valKanjiC0001" runat="server" ControlToValidate="txtKanji" 
                      Display="Dynamic" EnableClientScript="False" ValidateEmptyText="True" 
                      ValidationGroup="check" Enabled="False"></asp:CustomValidator></td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label5" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">項目名カナ</asp:Label> 
                </td> 
                <td bgcolor="#d9ffcc" align="left" style="width: 380px"> 
                  <asp:TextBox id="txtKana" CssClass="full" runat="server" Font-Size="10pt" Width="360px" MaxLength="50"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator ID="valKana1" runat="server" ControlToValidate="txtKana" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:CustomValidator ID="valKana2" runat="server" ControlToValidate="txtKana" Display="Dynamic" 
                    EnableClientScript="False" ErrorMessage="50バイト以内で入力してください" 
                    ValidationGroup="check"></asp:CustomValidator> 
                  <asp:CustomValidator ID="valKanaC0001" runat="server" ControlToValidate="txtKana" Display="Dynamic" 
                      EnableClientScript="False" ValidationGroup="check" ValidateEmptyText="True" Enabled="False"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td colspan="2" align="center"> 
                  <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="update"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#f7f7f7"></td> 
                <td bgcolor="#f7f7f7" align="left" style="width: 380px"> 
                   <asp:ImageButton ID="cmdRun" runat="server" ImageUrl="~/image/b_update.gif" />
                   <asp:ImageButton ID="cmdDel" runat="server" ImageUrl="~/image/b_delete.gif" />
                   <asp:ImageButton ID="cmdClear" runat="server" ImageUrl="~/image/b_clear.gif" />
                   <asp:ImageButton ID="cmdBack" runat="server" ImageUrl="~/image/b_back.gif" />
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
