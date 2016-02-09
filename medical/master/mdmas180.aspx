<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas180" Codebehind="mdmas180.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
        function getInfo1(control, name) { 
          var command = "1\t" + name + "\t" + control.value; 
          var context = new Object(); 
          context.CommandName = "getInfo1"; 
          <%= _sCallBackScript %> 
        } 
        function getInfo2(control, name) { 
          var command = "2\t" + name + "\t" + control.value; 
          var context = new Object(); 
          context.CommandName = "getInfo2"; 
          <%= _sCallBackScript %> 
        } 
        function getInfoCallBack(result, context) { 
          if (result=="") return; 
          var TAB = String.fromCharCode(9); 
          var results =result.split(TAB) ;
          switch (context.CommandName){ 
            case "getInfo1": 
              document.getElementById(results[0]).innerText = results[1]; 
              document.getElementById(results[2]).innerText = results[3]; 
              break; 
            case "getInfo2": 
              document.getElementById(results[0]).innerText = results[1]; 
              document.getElementById(results[2]).innerText = results[3]; 
              document.getElementById(results[4]).innerText = results[5]; 
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
    <tr height="15"><td></td></tr> 
    <!-- 入力フォーム --> 
    <tr>
      <td>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <table border="0" cellpadding="2" cellspacing="1">
              <tr align=center>
                <td width=100></td>
                <td width="100" bgcolor="#4e7e4a"><font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC000(document.getElementById('txtNengetu'));document.getElementById('txtNengetu').focus();return false;">変更対象年月</a></b></font></td> 
                <td width="150" bgcolor="#d9ffcc" align="left">
                  <asp:TextBox ID="txtNengetu" runat=server Width=50 MaxLength=6 BackColor="#FFFFC0" ></asp:TextBox><br />
                  <asp:RequiredFieldValidator ID="valNengetu1" runat="server" ControlToValidate="txtNengetu" Display="Dynamic" ErrorMessage="入力必須項目です" ValidationGroup="Nengetu" EnableClientScript="False"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator ID="valNengetu2" runat="server" ControlToValidate="txtNengetu" Display="Dynamic" ErrorMessage="年月で入力して下さい" ValidationExpression="^[0-9]{4}((0[1-9]{1})|(1[0-2]{1}))$" EnableClientScript="False" ValidationGroup="Nengetu"></asp:RegularExpressionValidator>
               </td>
              </tr>
            </table>
          </ContentTemplate>
          <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnCheck" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="btnRun" EventName="Click" />
          </Triggers>
        </asp:UpdatePanel>
      </td>
    </tr>
    <tr height="15"><td></td></tr> 
    <tr> 
      <td align="center"> 
        <table cellpadding=0 cellspacing=0 border=0>
          <tr align=left>
            <td>
              <asp:UpdatePanel ID="updPnlList" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <table border="0" cellpadding="2" cellspacing="1" > 
                    <!-- ヘッダ -->
                    <tr height="20" align=left> 
                      <td width="50"  align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>旧SHOP</b></font></td> 
                      <td width="100" align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>旧組織コード</b></font></td> 
                      <td width="280" align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>旧SHOP名称</b></font></td> 
                      <td width="0" ></td>
                      <td width="50"  align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>新SHOP</b></font></td> 
                      <td width="100" align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>新組織コード</b></font></td> 
                      <td width="280" align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>新SHOP名称</b></font></td>
                    </tr>
                    <tr>
                      <td colspan=7></td>
                    </tr>
                  </table>
                  <asp:Panel ID=pnlList runat=server ScrollBars=Vertical width="913" Height=496>
                    <table id="tblList" runat=server border="0" cellpadding="2" cellspacing="1"> 
                    </table>
                  </asp:Panel>
                  <br />
                  <table cellpadding=0 cellspacing=0 border=0 align=center>
                    <tr align=center>
                      <td width=200>                        
                          <asp:ImageButton ID="btnCheck" runat="server" ImageUrl="~/image/b_confirm.gif" />
                      </td>
                      <td width=40>
                      </td>
                      <td width=200>                        
                          <asp:ImageButton ID="btnRun" runat="server" ImageUrl="~/image/b_run.gif" />
                      </td>
                    </tr>
                    <tr align=center>
                      <td colspan=3>
                        <asp:Label ID=lblMess runat=server ForeColor=red></asp:Label><br />
                        <img id="imgProgress" name="imgProgress" src="../image/loader.gif" runat="server" style="display:none;"/>
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
