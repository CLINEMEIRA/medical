<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas0901" Codebehind="mdmas0901.aspx.vb" %> 
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
                  <asp:Label id="Label1" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">SHOP</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtShop" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="50px" MaxLength="2"></asp:TextBox> 
                    <br /> 
                  <asp:RequiredFieldValidator id="valCode1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtShop" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check" ForeColor="Red"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator id="valCode2" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtShop" ErrorMessage="半角英数で入力して下さい" ValidationExpression="^[a-zA-Z0-9]+$" EnableClientScript="False" ValidationGroup="check" ForeColor="Red"></asp:RegularExpressionValidator>                  
                    <asp:CustomValidator ID="valCode3" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtShop" ErrorMessage="既に登録されています" EnableClientScript="False" ValidationGroup="check" ForeColor="Red"></asp:CustomValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label2" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">SHOP名称</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtName" CssClass="full" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="250px" MaxLength="30"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator id="valName1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtName" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check" ForeColor="Red"></asp:RequiredFieldValidator> 
                  <asp:CustomValidator 
                      ID="valName2" CssClass="full" runat="server" ControlToValidate="txtName" Display="Dynamic" EnableClientScript="False" 
                      ErrorMessage="30バイト以内で入力して下さい" Font-Size="10pt" 
                      ValidationGroup="check" ForeColor="Red"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label7" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">組織コード</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                    <asp:DropDownList ID="ddlCode" runat="server"> 
                    </asp:DropDownList></td> 
              </tr> 
              <tr> 
                <td colspan="2" align="center"> 
                  <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="update" ForeColor="Red"></asp:CustomValidator> 
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
