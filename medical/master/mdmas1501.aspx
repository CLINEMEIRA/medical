<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas1501" Codebehind="mdmas1501.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
function cmdRun_onclick() {

}

  // --></script> 
  <script type="text/jscript"><!-- 
    function getInfo1(control) { 
    
      document.getElementById('btnKoutei').click();
      return;
    
//      var command = "1\t" + control.value; 
//      var context = new Object(); 
//      context.CommandName = "getInfo1"; 
//      <%= _sCallBackScript %> 
    } 
    function getInfo2(control) { 
      var command = "2\t" + control.value; 
      var context = new Object(); 
      context.CommandName = "getInfo2"; 
      <%= _sCallBackScript %> 
    } 
    
    function getInfoCallBack(result, context) { 
      var results = result.split(String.fromCharCode(9)); 
      switch (context.CommandName) {
        case "getInfo1":
//          document.getElementById('txtKoutei').innerText = results[0]; 
//          document.getElementById('lblKoutei').innerText = results[1]; 
//          document.getElementById('lblSetubiCode').innerText = results[3]; 
//          document.getElementById('lblSetubiName').innerText = results[4]; 
//          document.getElementById('lblSagyou').innerText = results[5]; 
//          // SHOP明細の削除
//          var shopList = document.getElementById('grdShop');
//          for (var i=1; i<shopList.rows.length; i++) {
//            shopList.rows[i].style.display = 'none';
//          }
//          // 下のSHOPの選択
//          var cboShop = document.getElementById('cboShop');
//          for (var i=0; i<cboShop.length; i++) {
//            if (cboShop(i).value == results[2]) {
//              cboShop.selectedIndex = i;
//              if (results[2] != "") {
//                document.getElementById('cboShori').selectedIndex = 1;
//              }
//            }
//          }
//          
//          // データセット削除フラグ
//          document.getElementById('hidDel').value = "1";
//          break;
          
        case "getInfo2":
          document.getElementById('txtOya').innerText = results[0]; 
          document.getElementById('lblOya').innerText = results[1]; 
          break;
      }
    } 
    function getInfoCallBackError(result, context) { 
    }
    
    // SHOP選択
    function selectGridRow(shop, daihyo) {
      var cboShop   = document.getElementById('cboShop');
      var chkDaihyo = document.getElementById('chkDaihyo');
      var cboShori  = document.getElementById('cboShori');
      
      for (var i=0; i<cboShop.length; i++) {
        if (cboShop(i).value == shop) {
          cboShop.selectedIndex = i;
          if (daihyo == '○') {
            chkDaihyo.checked = true;
          } else {
            chkDaihyo.checked = false;
          }
          cboShori.selectedIndex = 2;
          
          break;
        }
      }
    }
    function changecolor() {
    //チェックボックスのON/OFFで入力エリアの背景色を変える
    if(document.getElementById('CheckPlan').checked == true  ){
        document.getElementById('txtCycleTime').style.backgroundColor = '#FFFFC0';
        document.getElementById('txtTactTime').style.backgroundColor = '#FFFFC0';
        document.getElementById('txtPutTogether').style.backgroundColor = '#FFFFC0';
        }
        else{
        document.getElementById('txtCycleTime').style.backgroundColor = '#FFFFFF';
        document.getElementById('txtTactTime').style.backgroundColor = '#FFFFFF';
        document.getElementById('txtPutTogether').style.backgroundColor = '#FFFFFF';
        }
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
        <asp:UpdatePanel ID="udpInfo" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <table cellspacing="1" cellpadding="2" bgcolor="#f7f7f7" border="0"> 
              <tr height="20"> 
                <!-- 訂符 --> 
                <td align="center" width="120" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>訂符</b></font></td> 
                <td width="400" bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtTeifu" runat="server" Width="30px" MaxLength="2"></asp:TextBox><br /> 
                  <asp:RegularExpressionValidator ID="valTeifu1" runat="server" ControlToValidate="txtTeifu" Display="Dynamic" EnableClientScript="False" ErrorMessage="数字で入力して下さい" ValidationExpression="^[0-9]+" ValidationGroup="info"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 基本工順 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>基本工順</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtKihon" runat="server" BackColor="#FFFFC0" Width="30px" MaxLength="3" style="text-align:right"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator ID="valKihon1" runat="server" ControlToValidate="txtKihon" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="info" EnableClientScript="False"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator ID="valKihon2" runat="server" ControlToValidate="txtKihon" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+" ValidationGroup="info"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 補助工順 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>補助工順</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtHojo" runat="server" Font-Size="10pt" Width="15px" MaxLength="1" style="text-align:right" BackColor="#FFFFC0"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator ID="valHojo1" runat="server" ControlToValidate="txtHojo" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="info" EnableClientScript="False"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator ID="valHojo2" runat="server" ControlToValidate="txtHojo" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+" ValidationGroup="info"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 工程コード --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC040(document.getElementById('txtKoutei'),document.getElementById('lblKoutei'),null,null,null);getInfo1(document.getElementById('txtKoutei'));document.getElementById('txtKoutei').focus();return false;">工程コード</a></b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtKoutei" runat="server" Width="50px" MaxLength="5" BackColor="#FFFFC0" onChange="getInfo1(this);"></asp:TextBox> 
                  <asp:Label ID="lblKoutei" runat="server" Text="ＮＮＮＮＮＮＮＮＮＮ"></asp:Label>
                  <br /> 
                  <asp:RequiredFieldValidator ID="valKoutei1" runat="server" ControlToValidate="txtKoutei" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="info" EnableClientScript="False"></asp:RequiredFieldValidator> 
                  <asp:CustomValidator ID="valKoutei2" runat="server" ControlToValidate="txtKoutei" Display="Dynamic" ErrorMessage="工程マスタに未登録です" ValidationGroup="info" EnableClientScript="False" OnServerValidate="valKoutei2_ServerValidate"></asp:CustomValidator> 
                  <asp:Button ID="btnKoutei" runat="server" style="display:none;" />
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 親工程コード --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC041(document.getElementById('txtOya'),document.getElementById('lblOya'),null,null,null);document.getElementById('txtOya').focus();return false;">親工程コード</a></b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtOya" runat="server" Width="50px" MaxLength="5" onChange="getInfo2(this);"></asp:TextBox> 
                  <asp:Label ID="lblOya" runat="server" Text="ＮＮＮＮＮＮＮＮＮＮ"></asp:Label><br /> 
                  <asp:CustomValidator ID="valOya" runat="server" ControlToValidate="txtOya" Display="Dynamic" ValidationGroup="info" EnableClientScript="False" OnServerValidate="valOya_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- SHOP --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>SHOP</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <table border="0" cellpadding="2" cellspacing="1">
                    <tr align="center" bgcolor="#2266BB" style="color:#F7F7F7; font-weight:bold;">
                      <td Width="250px">SHOP</td>
                      <td Width="75px">代表区分</td>
                    </tr>
                  </table>
                  <asp:Panel ID="pnlShop" runat="server" Width="355" ScrollBars="Auto">
                    <asp:DataGrid ID="grdShop" runat="server" AutoGenerateColumns="False" 
                      BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" 
                      CellSpacing="1" ForeColor="MidnightBlue" GridLines="Horizontal" 
                      ShowHeader="False">
                      <AlternatingItemStyle ForeColor="#4A3C8C" BackColor="white" />
                      <ItemStyle BackColor="White" ForeColor="#4A3C8C" />
                      <Columns>
                        <asp:BoundColumn DataField="SHOP" HeaderText="SHOP">
                          <HeaderStyle Width="250px" BackColor="#2266BB" Font-Bold="True" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False" ForeColor="#F7F7F7" HorizontalAlign="Center" />
                          <ItemStyle Width="250px" Height="15px" HorizontalAlign="Left" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="代表区分" HeaderText="代表区分" ItemStyle-HorizontalAlign="Center">
                          <HeaderStyle Width="75px" BackColor="#2266BB" Font-Bold="True" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False" ForeColor="#F7F7F7" HorizontalAlign="Center" />
                          <ItemStyle Width="75px" Height="15px" HorizontalAlign="Center" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="SHOP_CD" Visible="false">
                        </asp:BoundColumn>
                      </Columns>
                    </asp:DataGrid>
                  </asp:Panel>
                  <asp:CustomValidator ID="valShop" runat="server" Display="Dynamic" ValidationGroup="info" EnableClientScript="False"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 設備 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>設備</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:Label ID="lblSetubiCode" runat="server" Text="XXXX"></asp:Label> 
                  <asp:Label ID="lblSetubiName" runat="server" Text="ＮＮＮＮＮＮＮＮＮＮ"></asp:Label> 
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 作業基準 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>作業基準</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:Label ID="lblSagyou" runat="server" Text="XXXXXXXXXXXXXXX"></asp:Label> 
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- コメント --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>コメント</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtComment" CssClass="full" runat="server" Width="350px" MaxLength="50"></asp:TextBox><br /> 
                  <asp:CustomValidator ID="valComment1" runat="server" ControlToValidate="txtComment" Display="Dynamic" ErrorMessage="50バイト以内で入力して下さい" ValidationGroup="info" EnableClientScript="False" OnServerValidate="valComment1_ServerValidate"></asp:CustomValidator>
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- サイクルタイム --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>サイクルタイム</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtCycleTime" runat="server" Width="40px" MaxLength="4" 
                        Style="text-align: right"></asp:TextBox>&nbsp;秒<br />                  
                  <asp:RegularExpressionValidator ID="valCycleTime2" runat="server" 
                        ControlToValidate="txtCycleTime" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="整数4桁以内で入力して下さい" ValidationExpression="^[0-9]{1,4}$" 
                        ValidationGroup="info"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="valCycleTime3" runat="server" 
                        ControlToValidate="txtCycleTime" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="必須入力項目です" ValidationGroup="info"></asp:RequiredFieldValidator>
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- タクトタイム --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>タクトタイム加算</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtTactTime" runat="server" Width="40px" MaxLength="4" 
                        Style="text-align: right"></asp:TextBox>&nbsp;秒<br />                  
                  <asp:RegularExpressionValidator ID="valTactTime2" runat="server" 
                        ControlToValidate="txtTactTime" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="整数4桁以内で入力して下さい" ValidationExpression="^[0-9]{1,4}$" 
                        ValidationGroup="info"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="valTactTime3" runat="server" 
                        ControlToValidate="txtTactTime" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="必須入力項目です" ValidationGroup="info"></asp:RequiredFieldValidator>
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 集約区分 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>集約区分</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:TextBox id="txtPutTogether" runat="server" Width="20px" MaxLength="9" 
                        Style="text-align: right">X</asp:TextBox><br />                  
                  <asp:RegularExpressionValidator ID="valPutTogether" runat="server" 
                        ControlToValidate="txtPutTogether" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="半角英大文字もしくは数字1桁で入力して下さい" ValidationExpression="^[0-9A-Z]{1}$" 
                        ValidationGroup="info"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="valPutTogether3" runat="server" 
                        ControlToValidate="txtPutTogether" Display="Dynamic" EnableClientScript="False" 
                        ErrorMessage="必須入力項目です" ValidationGroup="info"></asp:RequiredFieldValidator>
                </td> 
              </tr> 
              <tr height="20"> 
                <!-- 計画対象区分 --> 
                <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>計画対象区分</b></font></td> 
                <td bgcolor="#d9ffcc" align="left"> 
                    <asp:CheckBox ID="CheckPlan" runat="server" onClick="changecolor()" />
                    <br />                  
                </td> 
              </tr> 
              <tr> 
                <td colspan="2" align="center"> 
                  <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" OnServerValidate="valDate_ServerValidate" ValidationGroup="update"></asp:CustomValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#f7f7f7"></td> 
                <td bgcolor="#f7f7f7" align="left"> 
                    <p>
                        <asp:CustomValidator ID="valKoujun" runat="server" Display="Dynamic" 
                            EnableClientScript="False" ErrorMessage="加工工程マスタに未登録です&lt;br /&gt;" 
                            OnServerValidate="valKoujun_ServerValidate" ValidationGroup="info"></asp:CustomValidator>
                        <asp:ImageButton ID="cmdRun" runat="server" ImageUrl="~/image/b_update.gif" OnClientClick="return cmdRun_onclick()" />
                        <asp:ImageButton ID="cmdDel" runat="server" ImageUrl="~/image/b_update.gif" />
                        <asp:ImageButton ID="cmdClear" runat="server" ImageUrl="~/image/b_update.gif" />
                        <asp:ImageButton ID="cmdBack" runat="server" ImageUrl="~/image/b_update.gif" />
                        <asp:HiddenField ID="hidDel" runat="server" Value="" />
                    </p>
                </td> 
              </tr> 
            </table> 
          </ContentTemplate> 
        </asp:UpdatePanel> 
        
        <div style="height:25px;"></div>
        
        <asp:UpdatePanel ID="udpShop" runat="server" UpdateMode="Conditional">
          <ContentTemplate>
            
            <table cellspacing="1" cellpadding="2" border="0"> 
              <tr class="head" height="20">
                <td width="250">SHOP</td>
                <td width="100">代表区分</td>
                <td width="100">処理</td>
              </tr>
              <tr class="detail" height="20">
                <td>
                  <asp:DropDownList ID="cboShop" runat="server" BackColor="#FFFFC0">
                  </asp:DropDownList>
                </td>
                <td align="center">
                  <asp:CheckBox ID="chkDaihyo" runat="server" />
                </td>
                <td align="center">
                  <asp:DropDownList ID="cboShori" runat="server" BackColor="#FFFFC0"> 
                    <asp:ListItem></asp:ListItem> 
                    <asp:ListItem Value="A">追加</asp:ListItem> 
                    <asp:ListItem Value="U">訂正</asp:ListItem> 
                    <asp:ListItem Value="D">削除</asp:ListItem> 
                  </asp:DropDownList> 
                </td>
              </tr>
              <tr>
                <td colspan="3">
                  <asp:CustomValidator ID="valShopEdit" runat="server" Display="Dynamic" 
                    EnableClientScript="False" ValidationGroup="shop"></asp:CustomValidator>
                </td>
              </tr>
              <tr bgcolor="#f7f7f7">
                <td align="right" colspan="3">
                  <asp:ImageButton ID="btnRun" runat="server" ImageUrl="../image/b_run.gif"/> 
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
