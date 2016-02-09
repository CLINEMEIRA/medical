<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas045" Codebehind="mdmas045.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function callBack(mode,control) { 
        var command = mode + "\t" + control.value; 
        var context = new Object(); 
        context.CommandName = mode; 
        <%= _sCallBackScript %> 
    } 
    function getCallBack(result, context) { 
        var results = result.split("\t"); 
        switch (context.CommandName){
            case "1":
                document.getElementById('lblKumi1').innerText = results[0]; 
                break; 
            case "2": 
                document.getElementById('lblSeihin1').innerText = results[0]; 
                break; 
            case "3": 
                document.getElementById('lblSeihin2').innerText = results[0]; 
                document.getElementById('lblKumi2').innerText = results[1]; 
                break; 
            case "4": 
                document.getElementById('lblTorukus').innerText = results[0]; 
                break; 
            case "5": 
                document.getElementById('lblJikuKou').innerText = results[0]; 
                break; 
            case "6": 
                document.getElementById('lblZairyou').innerText = results[0]; 
                break; 
            case "7": 
                document.getElementById('lblNeji').innerText = results[0]; 
                break;
            case "8":                
                document.getElementById('lblSeries').innerText = results[0]; 
                break;                               
        }             
    } 
           
    function getCallBackError(result, context) { 
    }   
    function clickSearch()
    {
//        if(document.getElementById('txtCatalog').value != ""){
//            document.getElementById('btnSearch').click();
//        }
    }

function cmdSeriesCode_onclick() {
    //カタログ番号の２つ目のハイフンより前の文字列をシリーズに転記
    var W_column ;
    document.getElementById('txtSeries').style.backgroundColor = '#FF99CC';
    W_column = document.getElementById('txtCatalog').value.indexOf("-",0) ;                 //最初のハイフンの位置
    if (W_column == -1 ){
        //ハイフンが存在しない場合、先頭より１０文字
        document.getElementById('txtSeries').value = document.getElementById('txtCatalog').value.substring(0, 10);
        return
    }
    W_column = document.getElementById('txtCatalog').value.indexOf("-", W_column + 1 ) ;    //２つめのハイフンの位置
    if (W_column == -1 ){
        //２つめのハイフンが存在しない場合、先頭より１０文字
        document.getElementById('txtSeries').value = document.getElementById('txtCatalog').value.substring(0, 10);
        return
    }
    //２つめのハイフンが存在する場合、先頭より２つ目のハイフン手前までの文字列
    document.getElementById('txtSeries').value = document.getElementById('txtCatalog').value.substring(0, W_column);
    callBack('8', document.getElementById('txtSeries')) ; //コールバックで名称取得
}

  // --></script>   
</head> 
<body onload="startClock();"> 
<form id="frmInput" runat="server"> 
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td width="100%"><win:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="20"><td width="100%"></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center" width="100%"> 
        <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <table cellspacing="1" cellpadding="0" bgcolor="#f7f7f7" border="0"> 
              <tr height="25"> 
                <!-- カタログ番号 --> 
                <td align="center" bgcolor="#4e7e4a" width="120"><a class="nav" href="#" onclick="listMDSRC010(document.getElementById('txtCatalog'),null,document.getElementById('lblKumi1'));clickSearch();return false"><font color="#f7f7f7"><b>カタログ番号</b></font></a></td> 
                <td bgcolor="#D9FFCC" align="left" width="250"> 
                  <asp:TextBox ID="txtCatalog" runat="server" BackColor="#FFFFC0" MaxLength="17" Width="130px" onChange="callBack('1',this)" /><br /> 
                  <asp:RequiredFieldValidator ID="valCatalog1" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="key"></asp:RequiredFieldValidator> 
                  <asp:CustomValidator ID="valCatalog2" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" EnableClientScript="False" ErrorMessage="部品マスタに登録されていません" ValidationGroup="key"></asp:CustomValidator> 
                </td> 
                <!-- 組番 --> 
                <td align="center" bgcolor="#4e7e4a" width="40"><font color="#f7f7f7"><b>組番</b></font></td> 
                <td bgcolor="#D9FFCC" align="left" width="40"> 
                  <asp:Label ID="lblKumi1" runat="server" /> 
                </td> 
              </tr> 
              <tr> 
                <td align="center" bgcolor="#f7f7f7"></td> 
                <td bgcolor="#f7f7f7" align="left" colspan="3"> 
                  <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                </td> 
              </tr> 
            </table> 
          </ContentTemplate> 
        </asp:UpdatePanel> 
      </td> 
    </tr> 
    <tr height="20"><td></td></tr> 
    <tr> 
      <td align="center" width="100%"> 
        <asp:UpdatePanel ID="udpInfo" runat="server" UpdateMode="Conditional"> 
          <ContentTemplate> 
            <asp:Panel ID="pnlInfo" runat="server"> 
               <table cellspacing="1" cellpadding="0" bgcolor="#f7f7f7" border="0"> 
                  <tr height="25"> 
                    <!-- 製品グループ１ --> 
                    <td align="center" bgcolor="#4e7e4a" width="120"><a class="nav" href="#" onclick="listMDSRC140('1','',document.getElementById('txtSeihin1'),document.getElementById('lblSeihin1'));return false"><font color="#f7f7f7"><b>製品グループ1</b></font></a></td> 
                    <td bgcolor="#D9FFCC" align="left" colspan="3"> 
                      <asp:TextBox id="txtSeihin1" runat="server" Width="40px" MaxLength="4" onChange="callBack('2',this)">1234</asp:TextBox> 
                      <asp:Label ID="lblSeihin1" runat="server" Text="12345678901234567890"></asp:Label><br /> 
                      <asp:RegularExpressionValidator ID="valSeihin1b" runat="server" ControlToValidate="txtSeihin1" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角数字で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="info" /> 
                      <asp:CustomValidator ID="valSeihin1c" runat="server" ControlToValidate="txtSeihin1" Display="Dynamic" EnableClientScript="False" ErrorMessage="製品グループマスタに登録されていません" ValidationGroup="info"></asp:CustomValidator> 
                    </td> 
                  </tr> 
                  <tr height="25"> 
                    <!-- 製品グループ２ --> 
                    <td align="center" bgcolor="#4e7e4a"><a class="nav" href="#" onclick="listMDSRC150(document.getElementById('lblKumi1').innerText,document.getElementById('txtSeihin1'),document.getElementById('lblSeihin1'),document.getElementById('txtSeihin2'),document.getElementById('lblSeihin2'),document.getElementById('lblKumi2'));return false"><font color="#f7f7f7"><b>製品グループ2</b></font></a></td> 
                    <td bgcolor="#D9FFCC" align="left" width="250"> 
                      <asp:TextBox id="txtSeihin2" runat="server" Width="40px" MaxLength="4" onChange="callBack('3',this)">1234</asp:TextBox> 
                      <asp:Label ID="lblSeihin2" runat="server" Text="12345678901234567890"></asp:Label><br /> 
                      <asp:RegularExpressionValidator ID="valSeihin2b" runat="server" ControlToValidate="txtSeihin2" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角数字で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="info" /> 
                      <asp:CustomValidator ID="valSeihin2c" runat="server" ControlToValidate="txtSeihin2" Display="Dynamic" EnableClientScript="False" ErrorMessage="製品グループマスタに登録されていません" ValidationGroup="info"></asp:CustomValidator> 
                    </td> 
                    <!-- 組番 --> 
                    <td align="center" bgcolor="#4e7e4a" width="40"><font color="#f7f7f7"><b>組番</b></font></td> 
                    <td bgcolor="#D9FFCC" align="left" width="40"> 
                      <asp:Label ID="lblKumi2" runat="server" /> 
                    </td> 
                  </tr> 
                  <tr height="25"> 
                    <!-- トルクスNO --> 
                    <td align="center" bgcolor="#4e7e4a"><a class="nav" href="#" onclick="listMDSRC080('MS020',document.getElementById('txtTorukus'),document.getElementById('lblTorukus'));return false"><font color="#f7f7f7"><b>トルクスNO</b></font></a></td> 
                    <td bgcolor="#D9FFCC" align="left" colspan="3"> 
                      <asp:TextBox id="txtTorukus" runat="server" Width="30px" MaxLength="3" onChange="callBack('4',this)"></asp:TextBox> 
                      <asp:Label ID="lblTorukus" runat="server" Text="12345678901234567890" 
                            EnableTheming="True"></asp:Label><br /> 
                      <asp:RegularExpressionValidator ID="valTorukus2" runat="server" ControlToValidate="txtTorukus" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角数字で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="info" /> 
                      <asp:CustomValidator ID="valTorukus3" runat="server" ControlToValidate="txtTorukus" Display="Dynamic" EnableClientScript="False" ErrorMessage="汎用マスタに登録されていません" ValidationGroup="info"></asp:CustomValidator> 
                    </td> 
                  </tr> 
                  <tr height="25"> 
                    <!-- 軸荒径NO --> 
                    <td align="center" bgcolor="#4e7e4a"><a class="nav" href="#" onclick="listMDSRC080('MS021',document.getElementById('txtJikuKou'),document.getElementById('lblJikuKou'));return false"><font color="#f7f7f7"><b>軸荒径NO</b></font></a></td> 
                    <td bgcolor="#D9FFCC" align="left" colspan="3"> 
                      <asp:TextBox id="txtJikuKou" runat="server" Width="30px" MaxLength="3" onChange="callBack('5',this)"></asp:TextBox> 
                      <asp:Label ID="lblJikuKou" runat="server" Text="12345678901234567890"></asp:Label><br /> 
                      <asp:RegularExpressionValidator ID="valJikuKou2" runat="server" ControlToValidate="txtJikuKou" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角数字で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="info" /> 
                      <asp:CustomValidator ID="valJikuKou3" runat="server" ControlToValidate="txtJikuKou" Display="Dynamic" EnableClientScript="False" ErrorMessage="汎用マスタに登録されていません" ValidationGroup="info"></asp:CustomValidator> 
                    </td> 
                  </tr> 
                  <tr height="25"> 
                    <!-- 材料径NO --> 
                    <td align="center" bgcolor="#4e7e4a"><a class="nav" href="#" onclick="listMDSRC080('MS022',document.getElementById('txtZairyou'),document.getElementById('lblZairyou'));return false"><font color="#f7f7f7"><b>材料径NO</b></font></a></td> 
                    <td bgcolor="#D9FFCC" align="left" colspan="3"> 
                      <asp:TextBox id="txtZairyou" runat="server" Width="30px" MaxLength="3" onChange="callBack('6',this)"></asp:TextBox> 
                      <asp:Label ID="lblZairyou" runat="server" Text="12345678901234567890"></asp:Label><br /> 
                      <asp:RegularExpressionValidator ID="valZairyou2" runat="server" ControlToValidate="txtZairyou" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角数字で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="info" /> 
                      <asp:CustomValidator ID="valZairyou3" runat="server" ControlToValidate="txtZairyou" Display="Dynamic" EnableClientScript="False" ErrorMessage="汎用マスタに登録されていません" ValidationGroup="info"></asp:CustomValidator> 
                    </td> 
                  </tr> 
                  <tr height="25"> 
                    <!-- ネジ外径NO --> 
                    <td align="center" bgcolor="#4e7e4a"><a class="nav" href="#" onclick="listMDSRC080('MS023',document.getElementById('txtNeji'),document.getElementById('lblNeji'));return false"><font color="#f7f7f7"><b>ネジ外径NO</b></font></a></td> 
                    <td bgcolor="#D9FFCC" align="left" colspan="3"> 
                      <asp:TextBox id="txtNeji" runat="server" Width="30px" MaxLength="3" onChange="callBack('7',this)"></asp:TextBox> 
                      <asp:Label ID="lblNeji" runat="server" Text="12345678901234567890"></asp:Label><br /> 
                      <asp:RegularExpressionValidator ID="valNeji2" runat="server" ControlToValidate="txtNeji" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角数字で入力してください" ValidationExpression="^[0-9]*$" ValidationGroup="info" /> 
                      <asp:CustomValidator ID="valNeji3" runat="server" ControlToValidate="txtNeji" Display="Dynamic" EnableClientScript="False" ErrorMessage="汎用マスタに登録されていません" ValidationGroup="info"></asp:CustomValidator> 
                    </td> 
                  </tr> 
                   <tr height="25">
                    <!-- シリーズ --> 
                    <td align="center" bgcolor="#4e7e4a"><a class="nav" href="#" onclick="listMDSRC081('MS036',document.getElementById('txtSeries'),document.getElementById('lblSeries'));return false"><font color="#f7f7f7"><b>シリーズ</b></font></a></td> 
                    <td bgcolor="#D9FFCC" align="left" colspan="3"> 
                      <asp:TextBox id="txtSeries" runat="server" Width="81px" MaxLength="10" 
                            onChange="callBack('8', this )"></asp:TextBox>
                      <asp:ImageButton id="cmdSeriesCode" type="image" src="../image/b_seisei.gif" 
                            runat="server" OnClientClick="cmdSeriesCode_onclick();return false;" ImageAlign="Top"  /> 
                      <asp:Label 
                            ID="lblSeries" runat="server" Text="123456789012345678901234567890"></asp:Label><br /> 
                      <asp:CustomValidator ID="valSeries3" runat="server" ControlToValidate="txtSeries" 
                            Display="Dynamic" EnableClientScript="False" ErrorMessage="汎用マスタに登録されていません" 
                            ValidationGroup="info"></asp:CustomValidator> 
                    </td> 
                   </tr>
                  <tr> 
                    <td colspan="4" align="center"> 
                      <asp:CustomValidator ID="valSeihin" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="グループ１、２の関係が未登録です" ValidationGroup="info2" /> 
                      <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="update" /> 
                    </td> 
                  </tr> 
                  <tr> 
                    <td align="center" bgcolor="#f7f7f7"></td> 
                    <td bgcolor="#f7f7f7" align="left" colspan="3"> 
                      <asp:ImageButton ID="cmdRun" runat="server" ImageUrl="~/image/b_update.gif" />                        
                      <asp:ImageButton ID="cmdClear" runat="server" ImageUrl="~/image/b_clear.gif" />                        
                      <asp:ImageButton ID="cmdBack" runat="server" ImageUrl="~/image/b_back.gif" />
                   </td> 
                 </tr> 
               </table> 
              </asp:Panel> 
            </ContentTemplate> 
          </asp:UpdatePanel> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
