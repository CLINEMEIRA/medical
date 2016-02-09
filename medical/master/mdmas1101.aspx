<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas1101" Codebehind="mdmas1101.aspx.vb" %> 
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
                  <asp:Label id="Label1" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">作業者番号</asp:Label> 
                </td> 
                <td width="300" bgcolor="#D9FFCC" align="left"> 
                  <asp:TextBox id="txtCode" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="50px" MaxLength="4"></asp:TextBox> 
                    <br /> 
                  <asp:RequiredFieldValidator id="valCode1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator id="valCode2" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage='半角英数と"*"で入力して下さい' ValidationExpression="^[a-zA-Z0-9*]*$" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator id="valCode3" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="既に登録されています" EnableClientScript="False" ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label2" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">作業者名</asp:Label> 
                </td> 
                <td width="300" bgcolor="#D9FFCC" align="left"> 
                  <asp:TextBox id="txtName" CssClass="full" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="150px" MaxLength="7"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator id="valName1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtName" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator id="valName2" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtName" ErrorMessage="全角文字で入力して下さい" ValidationExpression="^[ 　]*[^ -~｡-ﾟ]*[ 　]*$" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White" Text="略称"></asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" width="300"> 
                    <asp:TextBox ID="txtRyaku" CssClass="full" runat="server" BackColor="#FFFFC0" Font-Size="10pt" MaxLength="3" 
                        Width="50px"></asp:TextBox> 
                    <br /> 
                    <asp:RequiredFieldValidator ID="valRyaku1" runat="server" ControlToValidate="txtRyaku" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="check"></asp:RequiredFieldValidator> 
                    <asp:RegularExpressionValidator ID="valRyaku2" runat="server" ControlToValidate="txtRyaku" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="全角文字で入力して下さい" Font-Size="10pt" 
                        ValidationExpression="^[ 　]*[^ -~｡-ﾟ]*[ 　]*$" ValidationGroup="check"></asp:RegularExpressionValidator></td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Text="SHOP"></asp:Label></td> 
                <td width="300" bgcolor="#D9FFCC" align="left"> 
                    <asp:DropDownList ID="ddlShop" runat="server" BackColor="#FFFFC0"> 
                    </asp:DropDownList>&nbsp;<br /> 
                    <asp:RequiredFieldValidator ID="valShop" runat="server" ControlToValidate="ddlShop" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="check"></asp:RequiredFieldValidator></td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="White" Text="パスワード"></asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" width="300"> 
                    <asp:TextBox ID="txtPass" runat="server" BackColor="#FFFFC0" Font-Size="10pt" MaxLength="8" 
                        Width="80px"></asp:TextBox> 
                    <br /> 
                    <asp:RequiredFieldValidator ID="valPass1" runat="server" ControlToValidate="txtPass" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" Font-Size="10pt" ValidationGroup="check"></asp:RequiredFieldValidator> 
                    <asp:RegularExpressionValidator ID="valPass2" runat="server" ControlToValidate="txtPass" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数文字で入力してください" ValidationExpression="^[a-zA-Z0-9]*$" ValidationGroup="check"></asp:RegularExpressionValidator></td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="White" Text="管理レベル"></asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" width="300"> 
                    <asp:DropDownList ID="ddlLv" runat="server" BackColor="#FFFFC0"> 
                    </asp:DropDownList><br /> 
                    <asp:RequiredFieldValidator ID="valLv" runat="server" ControlToValidate="ddlLv" Display="Dynamic" 
                        EnableClientScript="False" ErrorMessage="入力必須項目です" Font-Size="10pt" ValidationGroup="check"></asp:RequiredFieldValidator></td> 
              </tr> 
              <tr> 
                <td colspan="2" align="center"> 
                  <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="update"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#f7f7f7"></td> 
                <td width="300" bgcolor="#f7f7f7" align="left"> 
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
