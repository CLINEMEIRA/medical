<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas1201" Codebehind="mdmas1201.aspx.vb" %> 
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
                  <asp:Label id="Label1" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">外注コード</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtCode" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="50px" MaxLength="4"></asp:TextBox> 
                    <br /> 
                  <asp:RequiredFieldValidator id="valCode1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator id="valCode2" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+$" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator id="valCode3" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="既に登録されています" EnableClientScript="False" ValidationGroup="check"></asp:CustomValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label2" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">外注名称</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtName" CssClass="full" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="250px" MaxLength="30"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator id="valName1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtName" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator><asp:CustomValidator ID="valName2" runat="server" ControlToValidate="txtName" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="30バイト以内で入力して下さい" Font-Size="10pt" 
                        ValidationGroup="check"></asp:CustomValidator></td>
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                  <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#F7F7F7">外注略称</asp:Label></td> 
                <td align="left" bgcolor="#d9ffcc" width="300"> 
                  <asp:TextBox ID="txtRyaku" runat="server" BackColor="#FFFFC0" MaxLength="2" Width="30px"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator ID="valRyaku1" runat="server" ControlToValidate="txtRyaku" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" Font-Size="10pt" 
                    ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator ID="valRyaku2" runat="server" ControlToValidate="txtRyaku" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数で入力して下さい" Font-Size="10pt" 
                    ValidationExpression="^[a-zA-Z0-9]*$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator ID="valRyaku3" runat="server" ControlToValidate="txtRyaku" Display="Dynamic" 
                    EnableClientScript="False" ErrorMessage="既に登録されています" Font-Size="10pt" 
                    ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label3" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">郵便番号</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtZip" runat="server" Font-Size="10pt" Width="80px" MaxLength="8"></asp:TextBox> 
                    <br /> 
                  <asp:RegularExpressionValidator id="valZip" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtZip" ErrorMessage="入力値に誤りがあります" ValidationExpression="\d{3}(-(\d{4}|\d{2}))?" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label4" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">住所</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtAddress1" CssClass="full" runat="server" Font-Size="10pt" Width="250px" MaxLength="30"></asp:TextBox><br /> 
                    <asp:CustomValidator ID="valAddress11" runat="server" ControlToValidate="txtAddress1" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="30バイト以内で入力して下さい" Font-Size="10pt" 
                        ValidationGroup="check"></asp:CustomValidator> 
                    <asp:CustomValidator ID="valAddress12" runat="server" ControlToValidate="txtAddress1" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力して下さい" Font-Size="10pt" ValidateEmptyText="True" ValidationGroup="check"></asp:CustomValidator>
                  <asp:TextBox id="txtAddress2" CssClass="full" runat="server" Font-Size="10pt" Width="250px" MaxLength="30"></asp:TextBox><br /> 
                    <asp:CustomValidator ID="valAddress21" runat="server" ControlToValidate="txtAddress2" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="30バイト以内で入力して下さい" Font-Size="10pt" 
                        ValidationGroup="check"></asp:CustomValidator>
                    <asp:CustomValidator ID="valAddress22" runat="server" ControlToValidate="txtAddress2" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力して下さい" Font-Size="10pt" ValidateEmptyText="True" ValidationGroup="check"></asp:CustomValidator>
                  <asp:TextBox id="txtAddress3" CssClass="full" runat="server" Font-Size="10pt" Width="250px" MaxLength="30"></asp:TextBox><br /> 
                    <asp:CustomValidator ID="valAddress31" runat="server" ControlToValidate="txtAddress3" 
                        Display="Dynamic" EnableClientScript="False" ErrorMessage="30バイト以内で入力して下さい" Font-Size="10pt" 
                        ValidationGroup="check"></asp:CustomValidator></td>
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label5" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">電話番号</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtTel" runat="server" Font-Size="10pt" Width="120px" MaxLength="15"></asp:TextBox> 
                    <br /> 
                  <asp:RegularExpressionValidator id="valTel" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtTel" ErrorMessage="入力値に誤りがあります" ValidationExpression="\d{1,4}?-\d{1,4}?-\d{1,4}" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label6" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">ＦＡＸ番号</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtFax" runat="server" Font-Size="10pt" Width="120px" MaxLength="15"></asp:TextBox> 
                    <br /> 
                  <asp:RegularExpressionValidator id="valFax" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtFax" ErrorMessage="入力値に誤りがあります" ValidationExpression="\d{1,4}?-\d{1,4}?-\d{1,4}" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label7" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">担当者</asp:Label> 
                </td> 
                <td width="300" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtTanto" CssClass="full" runat="server" Font-Size="10pt" Width="120px" MaxLength="12"></asp:TextBox>&nbsp;<br /> 
                    <asp:CustomValidator ID="valTanto" runat="server" ControlToValidate="txtTanto" Display="Dynamic" 
                        EnableClientScript="False" ErrorMessage="12バイト以内で入力して下さい" Font-Size="10pt" 
                        ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
                <tr> 
                  <td align="center" bgcolor="#4e7e4a" width="150"> 
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#F7F7F7">加工外注区分</asp:Label> 
                  </td> 
                  <td align="left" bgcolor="#d9ffcc" width="300"> 
                    <asp:CheckBox ID="chkKubun" runat="server" /> 
                  </td> 
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
