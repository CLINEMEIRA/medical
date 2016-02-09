<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas0601" Codebehind="mdmas0601.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script language="JavaScript" type="text/javascript"><!-- 
    function getName(mode,control) { 
      var command = control.value; 
      var context = new Object(); 
      context.CommandName = "getName" + mode; 
      <%= _sCallBackScript %> 
    } 
             
    function getNameCallBack(result, context) { 
      var indexofComma = result.indexOf(","); 
      switch (context.CommandName){ 
        case "getName1": 
          document.getElementById('txtHCode1').innerText = result.substring(0,indexofComma); 
          document.getElementById('lblHCode1').innerText = result.substring(indexofComma+1, result.length); 
          break; 
        case "getName2": 
          document.getElementById('txtHCode2').innerText = result.substring(0,indexofComma); 
          document.getElementById('lblHCode2').innerText = result.substring(indexofComma+1, result.length); 
          break; 
        case "getName3": 
          document.getElementById('txtHCode3').innerText = result.substring(0,indexofComma); 
          document.getElementById('lblHCode3').innerText = result.substring(indexofComma+1, result.length); 
          break; 
      } 
    } 
       
    function getNameCallBackError(result, context) { 
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
    <tr height="10"><td></td></tr> 
    <tr><td align="center"> 
        <asp:Image ID="imgProcessTitle" runat="server" /></td></tr> 
    <tr height="10"><td></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center"> 
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <table cellspacing="1" cellpadding="2" bgcolor="#f7f7f7" border="0"> 
              <tr> 
                <td align="center" width="120" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">主材料コード</td> 
                <td bgcolor="#d9ffcc" align="left" width="200"> 
                  <asp:TextBox ID="txtSCode" runat="server" BackColor="#FFFFC0" MaxLength="15" Width="180px"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator ID="valSCode1" runat="server" ControlToValidate="txtSCode" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="check"></asp:RequiredFieldValidator> 
                  <asp:RegularExpressionValidator ID="valSCode2" runat="server" ControlToValidate="txtSCode" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数記号で入力してください" ValidationExpression="^[0-9!-~]*$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator ID="valSCode3" runat="server" ControlToValidate="txtSCode" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力された主材料は<br />既に登録されています" ValidationGroup="check"></asp:CustomValidator>
                </td> 
                <td align="center" width="120" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">連NO</td>
                <td bgcolor="#d9ffcc" align="left" width="180"> 
                  <asp:Label ID="lblRen" runat="server" Style="text-align: right" Width="40px"></asp:Label>
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">主材料名称</td> 
                <td bgcolor="#d9ffcc" align="left" colspan="3" rowspan="1"> 
                  <asp:TextBox ID="txtName" CssClass="full" runat="server" BackColor="#FFFFC0" MaxLength="17" Width="200px"></asp:TextBox><br /> 
                  <asp:RequiredFieldValidator ID="valName1" runat="server" ControlToValidate="txtName" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="check"></asp:RequiredFieldValidator>
                  <asp:CustomValidator ID="valName2" runat="server" ControlToValidate="txtName" Display="Dynamic" EnableClientScript="False" ErrorMessage="17バイト以内で入力してください" ValidationGroup="check"></asp:CustomValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">材料SPEC</td> 
                <td bgcolor="#d9ffcc" align="left" colspan="3"> 
                  <asp:TextBox ID="txtSpec" runat="server" MaxLength="15" Width="180px"></asp:TextBox><br /> 
                  <asp:RegularExpressionValidator ID="valSpec1" runat="server" ControlToValidate="txtSpec" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数記号で入力してください" ValidationExpression="^[0-9!-~ ]*$" ValidationGroup="check"></asp:RegularExpressionValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">材種コード</td> 
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:DropDownList ID="ddlZCode" runat="server"> 
                  </asp:DropDownList> 
                </td> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">形状コード</td>
                <td bgcolor="#d9ffcc" align="left"> 
                  <asp:DropDownList ID="ddlKCode" runat="server"> 
                  </asp:DropDownList> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">材料仕様書No</td>
                <td bgcolor="#d9ffcc" align="left" colspan="3"> 
                  <asp:TextBox ID="txtSiyou" runat="server" MaxLength="12" Width="150px"></asp:TextBox><br /> 
                  <asp:RegularExpressionValidator ID="valSiyou1" runat="server" ControlToValidate="txtSiyou" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数記号で入力してください" ValidationExpression="^[0-9!-~]*$" ValidationGroup="check"></asp:RegularExpressionValidator>
                </td>
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">磁性</td>
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                  <asp:DropDownList ID="ddlJisei" runat="server"> 
                  </asp:DropDownList> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">ストックレベル</td>
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                  <asp:TextBox ID="txtStock" runat="server" MaxLength="13" Width="120px" style="text-align: right"></asp:TextBox><br /> 
                  <asp:RegularExpressionValidator ID="valStock" runat="server" ErrorMessage="整数10桁以内、少数2桁以内で入力してください" ControlToValidate="txtStock" Display="Dynamic" EnableClientScript="False" ValidationExpression="^[0-9]{1,10}(\.[0-9]{0,2})?" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">最低発注量</td>
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                  <asp:TextBox ID="txtMin" runat="server" MaxLength="13" Width="120px" style="text-align: right"></asp:TextBox><br /> 
                  <asp:RegularExpressionValidator ID="valMin" runat="server" ErrorMessage="整数10桁以内、少数2桁以内で入力してください" ControlToValidate="txtMin" Display="Dynamic" EnableClientScript="False" ValidationExpression="^[0-9]{1,10}(\.[0-9]{0,2})?" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">係数</td>
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                   <asp:TextBox ID="txtKeisu" runat="server" MaxLength="5" Width="40px" style="text-align: right"></asp:TextBox><br />
                   <asp:RegularExpressionValidator ID="valKeisu" runat="server" ControlToValidate="txtKeisu" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数2桁以内、少数2桁以内で入力してください" ValidationExpression="^[0-9]{1,2}(\.[0-9]{0,2})?" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">単位区分</td>
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                  <asp:DropDownList ID="ddlUnit" runat="server"> 
                  </asp:DropDownList> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">単位重量</td>
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                  <asp:TextBox ID="txtWeight" runat="server" MaxLength="7" Width="60px" style="text-align: right"></asp:TextBox><br /> 
                  <asp:RegularExpressionValidator ID="valWeight" runat="server" ControlToValidate="txtWeight" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数4桁以内、少数2桁以内で入力してください" ValidationExpression="^[0-9]{1,4}(\.[0-9]{0,2})?" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">納入期間</td>
                <td align="left" bgcolor="#d9ffcc"> 
                  <asp:TextBox ID="txtKikan" runat="server" MaxLength="2" Width="40px" style="text-align: right"></asp:TextBox><br /> 
                  <asp:RegularExpressionValidator ID="valKikan" runat="server" ControlToValidate="txtKikan" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                </td> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">専用材区分</td>
                <td align="left" bgcolor="#d9ffcc"> 
                  <asp:DropDownList ID="ddlSenzai" runat="server"> 
                  </asp:DropDownList>
                </td> 
              </tr>
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">
                  <a class="nav" href="#" onclick="listMDSRC070(document.getElementById('txtHCode1'),document.getElementById('lblHCode1'));return false">発注先コード1</a> 
                </td> 
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                  <asp:TextBox ID="txtHCode1" runat="server" MaxLength="4" Width="60px" onChange="getName('1',document.forms[0].elements['txtHCode1'])"></asp:TextBox> 
                  <asp:Label ID="lblHCode1" runat="server"></asp:Label><br /> 
                  <asp:RegularExpressionValidator ID="valHCode11" runat="server" ControlToValidate="txtHCode1" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator ID="valHCode12" runat="server" ControlToValidate="txtHCode1" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="外注コードが存在しません" ValidationGroup="check" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">
                  <a class="nav" href="#" onclick="listMDSRC070(document.getElementById('txtHCode2'),document.getElementById('lblHCode2'));return false">発注先コード2</a>
                </td> 
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                  <asp:TextBox ID="txtHCode2" runat="server" MaxLength="4" Width="60px" onChange="getName('2',document.forms[0].elements['txtHCode2'])"></asp:TextBox> 
                  <asp:Label ID="lblHCode2" runat="server"></asp:Label><br /> 
                  <asp:RegularExpressionValidator ID="valHCode21" runat="server" ControlToValidate="txtHCode2" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator ID="valHCode22" runat="server" ControlToValidate="txtHCode1" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="外注コードが存在しません" ValidationGroup="check" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
              </tr> 
              <tr> 
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7"> 
                  <a class="nav" href="#" onclick="listMDSRC070(document.getElementById('txtHCode3'),document.getElementById('lblHCode3'));return false">発注先コード3</a>
                </td> 
                <td align="left" bgcolor="#d9ffcc" colspan="3"> 
                  <asp:TextBox ID="txtHCode3" runat="server" MaxLength="4" Width="60px" onChange="getName('3',document.forms[0].elements['txtHCode3'])"></asp:TextBox> 
                  <asp:Label ID="lblHCode3" runat="server"></asp:Label><br /> 
                  <asp:RegularExpressionValidator ID="valHCode31" runat="server" ControlToValidate="txtHCode3" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                  <asp:CustomValidator ID="valHCode32" runat="server" ControlToValidate="txtHCode1" 
                    Display="Dynamic" EnableClientScript="False" ErrorMessage="外注コードが存在しません" ValidationGroup="check" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
              </tr>
              <tr>
                <td align="center" bgcolor="#4e7e4a" style="font-weight: bolder; color: #f7f7f7">出庫単価</td>
                <td align="left" bgcolor="#d9ffcc" colspan="3">
                  <asp:TextBox ID="txtSTanka" runat="server" MaxLength="12" Width="120px" style="text-align: right"></asp:TextBox><br /> 
                  <asp:RegularExpressionValidator ID="valStanka" runat="server" ControlToValidate="txtSTanka" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数9桁以内、少数2桁以内で入力してください" ValidationExpression="^[0-9]{1,9}(\.[0-9]{0,2})?" ValidationGroup="check"></asp:RegularExpressionValidator>
                </td>
              </tr>
            </table> 
            <div style="background-color:#d9ffcc;width:533px;">
              <table border="0" cellpadding="0" cellspacing="0">
                <tr bgcolor="#4e7e4a" align="center" height="20">
                  <td style="color:#f7f7f7;" width="120"></td>
                  <td style="color:#f7f7f7;" width="3"></td>
                  <td style="color:#f7f7f7; font-weight:bold;" width="92">寸法区分</td>
                  <td style="color:#f7f7f7; font-weight:bold;" width="72">寸法</td>
                  <td style="color:#f7f7f7; font-weight:bold;" width="92">単位</td>
                  <td style="color:#f7f7f7; font-weight:bold;" width="77">上限公差</td>
                  <td style="color:#f7f7f7; font-weight:bold;" width="77">下限公差</td>
                </tr>
                <tr><td colspan="7" height="1" bgcolor="#f7f7f7"></td></tr>
                <tr>
                  <td bgcolor="#4e7e4a" style="color:#f7f7f7; font-weight:bold;" rowspan="2" align="center">確認寸法1</td>
                  <td rowspan="2"></td>
                  <td><asp:DropDownList ID="ddlSunpo1" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtSunpo1" runat="server" MaxLength="8" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:DropDownList ID="ddlUnit1" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtJogen1" runat="server" MaxLength="6" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:TextBox ID="txtKagen1" runat="server" MaxLength="7" Width="60px" style="text-align: right"></asp:TextBox></td>
                </tr>
                <tr>
                  <td colspan="7" align="left">
                    <asp:CustomValidator ID="valSunpo1" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="check"></asp:CustomValidator>
                  </td>
                </tr>
                <tr><td colspan="7" height="1" bgcolor="#f7f7f7"></td></tr>
                <tr>
                  <td bgcolor="#4e7e4a" style="color:#f7f7f7; font-weight:bold;" rowspan="2" align="center">確認寸法2</td>
                  <td rowspan="2"></td>
                  <td><asp:DropDownList ID="ddlSunpo2" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtSunpo2" runat="server" MaxLength="8" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:DropDownList ID="ddlUnit2" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtJogen2" runat="server" MaxLength="6" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:TextBox ID="txtKagen2" runat="server" MaxLength="7" Width="60px" style="text-align: right"></asp:TextBox></td>
                </tr>
                <tr>
                  <td colspan="7" align="left">
                    <asp:CustomValidator ID="valSunpo2" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="check"></asp:CustomValidator>
                  </td>
                </tr>
                <tr><td colspan="7" height="1" bgcolor="#f7f7f7"></td></tr>
                <tr>
                  <td bgcolor="#4e7e4a" style="color:#f7f7f7; font-weight:bold;" rowspan="2" align="center">確認寸法3</td>
                  <td rowspan="2"></td>
                  <td><asp:DropDownList ID="ddlSunpo3" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtSunpo3" runat="server" MaxLength="8" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:DropDownList ID="ddlUnit3" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtJogen3" runat="server" MaxLength="6" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:TextBox ID="txtKagen3" runat="server" MaxLength="7" Width="60px" style="text-align: right"></asp:TextBox></td>
                </tr>
                <tr>
                  <td colspan="7" align="left">
                    <asp:CustomValidator ID="valSunpo3" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="check"></asp:CustomValidator>
                  </td>
                </tr>
                <tr><td colspan="7" height="1" bgcolor="#f7f7f7"></td></tr>
                <tr>
                  <td bgcolor="#4e7e4a" style="color:#f7f7f7; font-weight:bold;" rowspan="2" align="center">確認寸法4</td>
                  <td rowspan="2"></td>
                  <td><asp:DropDownList ID="ddlSunpo4" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtSunpo4" runat="server" MaxLength="8" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:DropDownList ID="ddlUnit4" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtJogen4" runat="server" MaxLength="6" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:TextBox ID="txtKagen4" runat="server" MaxLength="7" Width="60px" style="text-align: right"></asp:TextBox></td>
                </tr>
                <tr>
                  <td colspan="7" align="left">
                    <asp:CustomValidator ID="valSunpo4" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="check"></asp:CustomValidator>
                  </td>
                </tr>
                <tr><td colspan="7" height="1" bgcolor="#f7f7f7"></td></tr>
                <tr>
                  <td bgcolor="#4e7e4a" style="color:#f7f7f7; font-weight:bold;" rowspan="2" align="center">確認寸法5</td>
                  <td rowspan="2"></td>
                  <td><asp:DropDownList ID="ddlSunpo5" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtSunpo5" runat="server" MaxLength="8" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:DropDownList ID="ddlUnit5" runat="server" Width="80"></asp:DropDownList></td>
                  <td><asp:TextBox ID="txtJogen5" runat="server" MaxLength="6" Width="60px" 
                          style="text-align: right"></asp:TextBox></td>
                  <td><asp:TextBox ID="txtKagen5" runat="server" MaxLength="7" Width="60px" style="text-align: right"></asp:TextBox></td>
                </tr>
                <tr>
                  <td colspan="7" align="left">
                    <asp:CustomValidator ID="valSunpo5" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="check"></asp:CustomValidator>
                  </td>
                </tr>
              </table>
            </div>
            <table width="325">
              <tr> 
                <td align="center"> 
                  <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="update"></asp:CustomValidator>
                </td> 
              </tr> 
              <tr> 
                <td align="center"> 
                  <asp:ImageButton ID="cmdRun" runat="server" ImageUrl="~/image/b_update.gif" />                  
                  <asp:ImageButton ID="cmdDel" runat="server" ImageUrl="~/image/b_delete.gif" />                  
                  <asp:ImageButton ID="cmdReset1" runat="server" ImageUrl="~/image/b_clear.gif" />                  
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
