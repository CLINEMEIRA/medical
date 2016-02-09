<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas1001" Codebehind="mdmas1001.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript"><!-- 
    function changecolor() {
    //チェックボックスのON/OFFで入力エリアの背景色を変える
    if(document.getElementById('CheckSche').checked == true  ){
        document.getElementById('txtSetsubi').style.backgroundColor = '#FFFFC0';
        document.getElementById('ddlSeisanLine').style.backgroundColor = '#FFFFC0';
        document.getElementById('txtSeiLineN').style.backgroundColor = '#FFFFC0';
        document.getElementById('ddlKadokei').style.backgroundColor = '#FFFFC0';
        }
        else{
        document.getElementById('txtSetsubi').style.backgroundColor = '#FFFFFF';
        document.getElementById('ddlSeisanLine').style.backgroundColor = '#FFFFFF';
        document.getElementById('txtSeiLineN').style.backgroundColor = '#FFFFFF';
        document.getElementById('ddlKadokei').style.backgroundColor = '#FFFFFF';
        }
    } 
  // --></script>   
  <script  type="text/javascript"src="../include/medical.js"><!-- 
  // --></script> 
    <style type="text/css">
        .style1
        {
            width: 372px;
        }
    </style>
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
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label id="Label1" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">設備コード</asp:Label> 
                </td> 
                <td bgcolor="#D9FFCC" align="left" class="style1"> 
                  <asp:TextBox id="txtCode" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="50px" MaxLength="4"></asp:TextBox> 
                    <br /> 
                  <asp:RequiredFieldValidator id="valCode1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator id="valCode2" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage='半角英数,"*"及び、"_(ｱﾝﾀﾞｰﾊﾞｰ)"で入力してください' ValidationExpression="^[a-zA-Z0-9\*_]*$" EnableClientScript="False" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator id="valCode3" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtCode" ErrorMessage="既に登録されています" EnableClientScript="False" ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label id="Label2" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">設備名称</asp:Label> 
                </td> 
                <td bgcolor="#D9FFCC" align="left" class="style1"> 
                  <asp:TextBox id="txtName" CssClass="full" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="200px" MaxLength="24"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator id="valName1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="txtName" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:CustomValidator ID="valName2" runat="server" ControlToValidate="txtName" Display="Dynamic" EnableClientScript="False" 
                      ErrorMessage="24バイト以内で入力して下さい" Font-Size="10pt" ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="White" Text="SHOP"></asp:Label></td> 
                <td bgcolor="#D9FFCC" align="left" class="style1"> 
                  <asp:DropDownList ID="ddlShop" runat="server" BackColor="#FFFFC0"> 
                  </asp:DropDownList>&nbsp;<br /> 
                  <asp:RequiredFieldValidator ID="valShop" runat="server" 
                      ControlToValidate="ddlShop" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" 
                      Font-Size="10pt" ValidationGroup="check"></asp:RequiredFieldValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label ID="Label3" CssClass="full" runat="server" Font-Bold="True" ForeColor="White" Text="製造会社名"></asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" class="style1"> 
                  <asp:TextBox ID="txtCom" runat="server" MaxLength="20" Width="180px"></asp:TextBox> 
                  <br /> 
                  <asp:CustomValidator ID="valCom" runat="server" ControlToValidate="txtCom" Display="Dynamic" 
                      EnableClientScript="False" ErrorMessage="20バイト以内で入力して下さい" Font-Size="10pt" 
                      ValidationGroup="check"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="White" Text="稼働時間区分"></asp:Label></td> 
                  <td align="left" bgcolor="#D9FFCC" class="style1"> 
                  <asp:DropDownList ID="ddlJikanKubun" runat="server" BackColor="#FFFFC0"> 
                  </asp:DropDownList> 
                  <br /> 
                  <asp:RequiredFieldValidator ID="valJikanKubun" runat="server" ControlToValidate="ddlJikanKubun" 
                      Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" Font-Size="10pt" 
                      ValidationGroup="check"></asp:RequiredFieldValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="White" Text="稼働率計算単位"></asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" class="style1"> 
                  <asp:DropDownList ID="ddlKeisanTanni" runat="server" BackColor="#FFFFC0"> 
                  </asp:DropDownList><br /> 
                  <asp:RequiredFieldValidator ID="valKeisanTanni" runat="server" ControlToValidate="ddlKeisanTanni" 
                      Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" Font-Size="10pt" 
                      ValidationGroup="check"></asp:RequiredFieldValidator> 
                </td> 
              </tr> 
                <tr>
                    <td align="center" bgcolor="#4e7e4a" style="width: 150px">
                        <asp:Label ID="Label10" CssClass="full" runat="server" Font-Bold="True" ForeColor="White" Text="スケジュール管理"></asp:Label></td> 
                    <td align="left" bgcolor="#D9FFCC" class="style1">
                        <asp:CheckBox ID="CheckSche" runat="server" onClick="changecolor()" />
                        &nbsp;管理する
                    </td>
                </tr>
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label ID="Label5" CssClass="full" runat="server" Font-Bold="True" ForeColor="White" Text="設備No."></asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" class="style1"> 
                  <asp:TextBox ID="txtSetsubi" runat="server" MaxLength="24" Width="180px"></asp:TextBox> 
                  <br /> 
                  <asp:CustomValidator ID="valSetsubi2" runat="server" 
                        ControlToValidate="txtSetsubi" Display="Dynamic" 
                      EnableClientScript="False" ErrorMessage="24バイト以内で入力して下さい" Font-Size="10pt" 
                      ValidationGroup="check" Enabled="False"></asp:CustomValidator> 
                    <asp:RequiredFieldValidator ID="valSetsubi1" runat="server" 
                        ControlToValidate="txtSetsubi" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="入力必須項目です" Font-Size="10pt" ValidationGroup="check" 
                        Enabled="False"></asp:RequiredFieldValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="White" Text="生産ライン"></asp:Label></td> 
                  <td align="left" bgcolor="#D9FFCC" class="style1"> 
                  <asp:DropDownList ID="ddlSeisanLine" runat="server" Height="16px" Width="350px" > 
                  </asp:DropDownList>
                      <br>
                      <asp:RequiredFieldValidator ID="valSeisanLine" runat="server" 
                          ControlToValidate="ddlSeisanLine" Display="Dynamic" EnableClientScript="False" 
                          Enabled="False" ErrorMessage="入力必須項目です" Font-Size="10pt" 
                          ValidationGroup="check"></asp:RequiredFieldValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label ID="lblSeiLineN" CssClass="full" runat="server" Font-Bold="True"  
                        ForeColor="White" Text="生産ライン順序"></asp:Label></td> 
                <td align="left" bgcolor="#D9FFCC" class="style1"> 
                
                    <asp:TextBox ID="txtSeiLineN" runat="server" MaxLength="2" Width="25px" style="text-align: right; "></asp:TextBox>
                  <br /> 
                  <asp:CustomValidator ID="valSeiLineN1" runat="server" 
                        ControlToValidate="txtSeiLineN" Display="Dynamic" 
                      EnableClientScript="False" ErrorMessage="2バイト以内で入力して下さい" Font-Size="10pt" 
                      ValidationGroup="check"></asp:CustomValidator> 
                    <asp:RegularExpressionValidator ID="valSeiLineN2" runat="server" 
                        ControlToValidate="txtSeiLineN" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="数字で入力してください" Font-Size="10pt" ValidationExpression="^[0-9]*$" 
                        ValidationGroup="check"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="valSeiLineN3" runat="server" 
                        ControlToValidate="txtSeiLineN" Display="Dynamic" EnableClientScript="False" 
                        Enabled="False" ErrorMessage="入力必須項目です" Font-Size="10pt" 
                        ValidationGroup="check"></asp:RequiredFieldValidator>
                  <asp:CustomValidator ID="valSeiLineN4" runat="server" 
                        ControlToValidate="txtSeiLineN" Display="Dynamic" 
                      EnableClientScript="False" ErrorMessage="1～99の範囲で入力して下さい" Font-Size="10pt" 
                      ValidationGroup="check" Enabled="False"></asp:CustomValidator> 
                    <asp:RequiredFieldValidator ID="valSeiLineN5" runat="server" 
                        ControlToValidate="txtSeiLineN" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="数字で入力して下さい" Font-Size="10pt" ValidationGroup="check" 
                        Enabled="False"></asp:RequiredFieldValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="width: 150px"> 
                  <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="White" Text="標準稼動形態"></asp:Label></td> 
                  <td align="left" bgcolor="#D9FFCC" class="style1"> 
                  <asp:DropDownList ID="ddlKadokei" runat="server" Height="16px" Width="350px" > 
                  </asp:DropDownList><br /> 
                  <asp:RequiredFieldValidator ID="valKadokei" runat="server" ControlToValidate="ddlKadokei" 
                      Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" Font-Size="10pt" 
                      ValidationGroup="check" Enabled="False"></asp:RequiredFieldValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" colspan="2">
                    <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" 
                        EnableClientScript="False" ErrorMessage="" 
                        ValidationGroup="update"></asp:CustomValidator>
                  </td> 
                  <tr>
                      <td align="center" bgcolor="#f7f7f7" style="width: 150px">
                      </td>
                      <td align="left" bgcolor="#f7f7f7" class="style1">
                        <asp:ImageButton ID="cmdRun" runat="server" ImageUrl="~/image/b_update.gif" />
                        <asp:ImageButton ID="cmdDel" runat="server" ImageUrl="~/image/b_delete.gif" />
                        <asp:ImageButton ID="cmdClear" runat="server" ImageUrl="~/image/b_clear.gif" />
                        <asp:ImageButton ID="cmdBack" runat="server" ImageUrl="~/image/b_back.gif" />
                      </td>
                  </tr>
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