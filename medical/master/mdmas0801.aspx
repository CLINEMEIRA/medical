<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas0801" Codebehind="mdmas0801.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!--
  // --></script> 
  <script type="text/javascript"><!-- 
        function getInfo1(control1) { 
          var command = "1\t" + control1.value; 
          var context = new Object(); 
          context.CommandName = "getInfo1"; 
          <%= _sCallBackScript %> 
        } 
        function getInfo2(control2) { 
          var command = "2\t" + control2.value; 
          var context = new Object(); 
          context.CommandName = "getInfo2"; 
          <%= _sCallBackScript %> 
        } 
         
        function getInfoCallBack(result, context) { 
          if (result=="") return; 
          var TAB = String.fromCharCode(9); 
          var results =result.split(TAB); 
          switch (context.CommandName){ 
            case "getInfo1": 
              document.getElementById('lblHyoujun').innerText = results[0]; 
              break; 
            case "getInfo2": 
              document.getElementById('lblOyaName').innerText = results[0]; 
              break; 
          } 
        } 
         
        function getInfoCallBackError(result, context) { 
        }   
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
                  <asp:Label id="Label1" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">工程コード</asp:Label> 
                </td> 
                <td width="300" bgcolor="#D9FFCC" align="left"> 
                  <asp:TextBox id="txtCode" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="50px" MaxLength="5"></asp:TextBox> 
                    <br /> 
                  <asp:RequiredFieldValidator id="valCode1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator id="valCode2" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="半角英数で入力して下さい" ValidationExpression="^[0-9a-zA-Z]+$" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator id="valCode3" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="既に登録されています" EnableClientScript="False" ValidationGroup="check"></asp:CustomValidator> 
                    <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" 
                        EnableClientScript="False" ErrorMessage="" 
                        ValidationGroup="update"></asp:CustomValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label2" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">工程名称</asp:Label> 
                </td> 
                <td width="300" bgcolor="#D9FFCC" align="left"> 
                  <asp:TextBox id="txtName" CssClass="full" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="230px" MaxLength="20"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator id="valName1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtName" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator><asp:CustomValidator 
                    ID="valName2" runat="server" ControlToValidate="txtName" Display="Dynamic" 
                    EnableClientScript="False" ErrorMessage="20バイト以内で入力して下さい" Font-Size="10pt" 
                    ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" width="150" bgcolor="#4e7e4a"> 
                  <asp:Label id="Label7" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">SHOP</asp:Label> 
                </td> 
                <td width="300" bgcolor="#D9FFCC" align="left"> 
                  <asp:DropDownList ID="ddlShop" runat="server" BackColor="#FFFFC0"> 
                  </asp:DropDownList>&nbsp;<br /> 
                  <asp:RequiredFieldValidator ID="valShop1" runat="server" ControlToValidate="ddlShop" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="check"></asp:RequiredFieldValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                  <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#F7F7F7">単位所要時間</asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" width="300"> 
                  <asp:TextBox ID="txtMinute" runat="server" MaxLength="4" Style="text-align: right" 
                    Width="40px"></asp:TextBox> 
                    &nbsp;分<br />
                  <asp:RegularExpressionValidator ID="valMinute1" runat="server" ControlToValidate="txtMinute" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力して下さい" Font-Size="10pt" 
                    ValidationExpression="^[0-9]+$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                  <a href="#" onclick="listMDSRC082('MS027',document.getElementById('txtHyoujun'),document.getElementById('lblHyoujun'));document.getElementById('txtHyoujun').focus();return false;"><font color="#f7f7f7"><b>作業標準</b></font></a> 
                </td> 
                <td align="left" bgcolor="#D9FFCC" width="300"> 
                  <asp:TextBox ID="txtHyoujun" runat="server" MaxLength="2" Width="30px" onChange="getInfo1(this)"></asp:TextBox> 
                  <asp:Label ID="lblHyoujun" runat="server"></asp:Label> 
                  <br /> 
                  <asp:RegularExpressionValidator ID="valHyoujun1" runat="server" ControlToValidate="txtHyoujun" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数で入力して下さい" Font-Size="10pt" 
                    ValidationExpression="^[a-zA-Z0-9]*$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator ID="valHyoujun2" runat="server" ControlToValidate="txtCode" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="汎用マスタに存在しません" Font-Size="10pt" 
                    ValidationGroup="check" ValidateEmptyText="True"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                  <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#F7F7F7">工程集約コード</asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" width="300"> 
                  <asp:DropDownList ID="ddlSCode" runat="server" BackColor="#FFFFC0"> 
                  </asp:DropDownList><br /> 
                  <asp:RequiredFieldValidator ID="valScode" runat="server" ControlToValidate="ddlSCode" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" Font-Size="10pt" 
                    ValidationGroup="check"></asp:RequiredFieldValidator> 
                  </td> 
              </tr> 
              <tr>
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                  <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#F7F7F7">親子区分</asp:Label>
                </td>
                <td align="left" bgcolor="#d9ffcc" width="300"> 
                  <asp:RadioButton ID=rbtnOya Text="親" runat=server GroupName=oyako />&emsp;&emsp;
                  <asp:RadioButton ID=rbtnKo Text="子" runat=server GroupName=oyako Checked=true/>
                </td>
              </tr>
              <tr> 
                <td align="center" bgcolor="#4e7e4a" width="150"> 
                  <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#F7F7F7">標準段取時間</asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" width="300"> 
                    <asp:TextBox ID="txtSetuptime" runat="server" MaxLength="3" 
                        Style="text-align: right" Width="40px"></asp:TextBox>
                    &nbsp;分<br />
                    <asp:RegularExpressionValidator ID="valSetuptime" runat="server" 
                        ControlToValidate="txtSetuptime" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+$" 
                        ValidationGroup="check"></asp:RegularExpressionValidator>
                </td> 
              </tr> 
              <tr> 
                <td colspan="2" align="center"> 
                    &nbsp;</td> 
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
