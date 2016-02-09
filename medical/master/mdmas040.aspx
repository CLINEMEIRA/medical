<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas040" Codebehind="mdmas040.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function showGuide(flag) 
    { 
        if(flag == true){ 
            document.getElementById('lblGuide').innerText = "[空白:ｸﾞﾗﾑ(ｺｲﾙ,板材) M:ﾐﾘﾒｰﾄﾙ(棒,六角材) ｺ:EA(個)部品等]"; 
        } else{ 
            document.getElementById('lblGuide').innerText = ""; 
        } 
    } 
    function setTani(obj) 
    { 
        if(obj.value.length > 0){ 
            switch(obj.value.substring(0,1)) 
            { 
                case "1": 
                    document.getElementById('txtTani').innerText = ""; 
                    break; 
                case "2": 
                case "3": 
                    document.getElementById('txtTani').innerText = "M"; 
                    break; 
                default: 
                    document.getElementById('txtTani').innerText = ""; 
            } 
        } else{ 
            document.getElementById('txtTani').innerText = ""; 
        } 
        getTanju(); 
    } 
    function getName(mode,control) { 
      var command = "0\t" + control.value; 
      var context = new Object(); 
      context.CommandName = "getName" + mode; 
      <%= _sCallBackScript1 %> 
    } 
    function getNameCallBack(result, context) { 
      var indexofComma = result.indexOf(","); 
      switch (context.CommandName){ 
        case "getName1": 
          document.getElementById('txtSakusei').innerText = result.substring(0,indexofComma); 
          document.getElementById('lblSakusei').innerText = result.substring(indexofComma+1, result.length); 
          break; 
        case "getName2": 
          document.getElementById('txtTenken').innerText = result.substring(0,indexofComma); 
          document.getElementById('lblTenken').innerText = result.substring(indexofComma+1, result.length); 
          break; 
        case "getName3": 
          document.getElementById('txtGijutu').innerText = result.substring(0,indexofComma); 
          document.getElementById('lblGijutu').innerText = result.substring(indexofComma+1, result.length); 
          break; 
        case "getName4": 
          document.getElementById('txtHinkan').innerText = result.substring(0,indexofComma); 
          document.getElementById('lblHinkan').innerText = result.substring(indexofComma+1, result.length); 
          break; 
        case "getName5": 
          document.getElementById('txtUpdator').innerText = result.substring(0,indexofComma); 
          document.getElementById('lblUpdator').innerText = result.substring(indexofComma+1, result.length); 
          break; 
      } 
    } 
    function getNameCallBackError(result, context) { 
    }   
    function getTanju() { 
      if(document.getElementById('txtZairyo').value.length == 0 || document.getElementById('txtSozai').value.length == 0){ 
          document.getElementById('txtTanju').innerText = ""; 
          return; 
      } 
      var command = "1\t" + document.getElementById('txtZairyo').value + "\t" + document.getElementById('txtSozai').value; 
      var context = new Object(); 
      context.CommandName = "getTanju"; 
      <%= _sCallBackScript2 %> 
    } 
    function getTanjuCallBack(result, context) { 
        document.getElementById('txtTanju').value = result; 
    } 
    function getTanjuCallBackError(result, context) { 
    }   
    
    function getKumiName() {
      var command = "2\t" + document.getElementById('txtKumiban').value
      var context = new Object(); 
      context.CommandName = "getKumiName"; 
      <%= _sCallBackScript3 %> 
    } 
    function getKumiCallBack(result, context) { 
        document.getElementById('lblKumibanName').innerText = result; 
    } 
    function getKumiCallBackError(result, context) { 
    }   
    
    // ASSY区分のｶﾞｲﾀﾞﾝｽ行の表示・非表示
    function showAssyGuide(visible) {
      var Row = document.getElementById("divAssy");
      if (visible) {
        Row.style.display="";
      } else {
        Row.style.display="none";
      }
    }
    // 原価区分のｶﾞｲﾀﾞﾝｽ行の表示・非表示
    function showCostGuide(visible) {
      var Row = document.getElementById("divCost");
      if (visible) {
        Row.style.display="";
      } else {
        Row.style.display="none";
      }
    }
    // 原価区分のｶﾞｲﾀﾞﾝｽ行の表示・非表示
    function showRoyaltiesGuide(visible) {
      var Row = document.getElementById("divRoyalties");
      if (visible) {
        Row.style.display="";
      } else {
        Row.style.display="none";
      }
    }
  // --></script> 
</head> 
<body onload="startClock();"> 
<form id="frmList" runat="server"> 
 <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True"></asp:ScriptManager> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td><medical:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="10"><td></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="left"> 
        <table cellpadding="0" cellspacing="0" border="0"> 
          <tr> 
            <td width="20"></td> 
            <td align="left"> 
              <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <table cellpadding="2" cellspacing="1" border="0"> 
                    <tr height="27"> 
                      <!-- カタログ番号 --> 
                      <td align="center" width="100" bgcolor="#4e7e4a"> 
                        <font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC0103(document.getElementById('txtCatalog'),document.getElementById('lblSyanai'),null);return false;">カタログ番号</a></b></font> 
                      </td> 
                      <td align="left" width="230" bgcolor="#D9FFCC"> 
                        <asp:TextBox ID="txtCatalog" runat="server" MaxLength="17" Width="129px" BackColor="#FFFFC0">XXXXXXXXXXXXXXXXX</asp:TextBox><br /> 
                        <asp:RequiredFieldValidator ID="valCatalog1" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="key" EnableClientScript="False"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="valCatalog3" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数記号で入力してください" ValidationExpression="^[0-9!-~]*$" ValidationGroup="key"></asp:RegularExpressionValidator>
                        <asp:CustomValidator ID="valCatalog2" runat="server" 
                          ControlToValidate="txtCatalog" Display="Dynamic" ErrorMessage="部品マスタに未登録です（廃止）" 
                          ValidationGroup="key" EnableClientScript="False" Enabled="False"></asp:CustomValidator> 
                      </td> 
                      <!-- 社員ＮＯ --> 
                      <td align="center" width="70" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>社内ＮＯ</b></font></td> 
                      <td align="left" width="70" bgcolor="#D9FFCC"> 
                        <asp:Label ID="lblSyanai" runat="server" Width="50px"></asp:Label> 
                      </td> 
                      <td width="5"></td> 
                      <!-- 検索ボタン --> 
                      <td align="left">                        
                          <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                      </td> 
                      <td width="270" align=right>
                        <asp:Image ID="imgProcessTitle" runat="server" Visible="false" />
                      </td>
                    </tr> 
                  </table> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
          </tr> 
          <tr height="5"><td colspan="2"></td></tr> 
          <tr> 
            <td width="20"></td> 
            <td align="left"> 
              <asp:UpdatePanel ID="udpInfo" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <asp:Panel ID="pnlInfo" ScrollBars="Auto" Height="600" runat="server"> 
                  <table border="0" cellpadding="0" cellspacing="0"> 
                    <tr> 
                      <td> 
                        <!-- コピー元カタログ番号&複写ボタン --> 
                        <table ID="tblCopy" border="0" cellpadding="2" cellspacing="1" runat="server"> 
                          <tr> 
                            <td align="center" width="160" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC010(document.getElementById('txtCopyCatalog'),null);return false">コピー元カタログ番号</a></b></font> 
                            </td> 
                            <td align="left" width="230" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtCopyCatalog" runat="server" MaxLength="17" Width="130px">XXXXXXXXXXXXXXXXX</asp:TextBox><br />
                              <asp:CustomValidator ID="valCopyCatalog1" runat="server" ControlToValidate="txtCopyCatalog" Display="Dynamic" ErrorMessage="" ValidationGroup="copy" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator>
                              <asp:RegularExpressionValidator ID="valCopyCatalog2" runat="server" ControlToValidate="txtCopyCatalog" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数記号で入力してください" ValidationExpression="^[0-9!-~]*$" ValidationGroup="copy"></asp:RegularExpressionValidator>
                            </td> 
                            <td width="5"></td> 
                            <td align="left">                              
                                <asp:ImageButton ID="btnCopy" runat="server" ImageUrl="~/image/b_copy.gif" />
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td> 
                        <Table id="tblShusei" runat="server" border="0" cellpadding="2" cellspacing="1">
                          <tr height="22">
                            <td class="head" width="70" align="Center">修正区分</td>
                            <td class="detail" width="130">
                              <asp:DropDownList ID="cboSyusei" runat="server" BackColor="#FFFFC0" AutoPostBack="true">
                                <asp:ListItem Value="0">通常</asp:ListItem>
                                <asp:ListItem Value="1">修正中</asp:ListItem>
                              </asp:DropDownList><br />
                              <asp:CustomValidator ID="valSyusei" runat="server" Display="Dynamic" ValidationGroup="info" EnableClientScript="False" ErrorMessage="修正区分は<br />「修正中」<br />を選択して下さい"></asp:CustomValidator>
                            </td>
                            <td class="head" width="70"><a class="nav" href="#" onclick="listMDSRC030(document.getElementById('txtUpdator'),null,document.getElementById('lblUpdator'));document.getElementById('txtUpdator').focus();return false;">修正者</a></td>
                            <td class="detail" width="150">
                              <asp:TextBox ID="txtUpdator" runat="server" MaxLength="4" Width="40px" BackColor="#FFFFC0" onChange="getName('5',this);">XXXX</asp:TextBox>
                              <asp:Label ID="lblUpdator" runat="server">ＮＮＮＮＮ</asp:Label><br />
                              <asp:CustomValidator ID="valUpdator" runat="server" Display="Dynamic" ValidationGroup="info" EnableClientScript="False"></asp:CustomValidator>
                            </td>
                            <td class="head" width="70">修正理由</td>
                            <td class="detail" width="300">
                              <asp:DropDownList ID="cboReason" runat="server" BackColor="#FFFFC0">
                              </asp:DropDownList><br />
                              <asp:CustomValidator ID="valReason" runat="server" Display="Dynamic" ValidationGroup="info" EnableClientScript="False"></asp:CustomValidator>
                            </td>
                          </tr>
                          <tr height="5">
                            <td colspan="6"></td>
                          </tr>
                        </Table>
                        <table border="0" cellpadding="2" cellspacing="1"> 
                          <tr height="20">
                            <!-- 元カタログ番号 --> 
                            <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>元カタログ番号</b></font></td> 
                            <td align="left" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtMotoCatalog" runat="server" MaxLength="17" Width="150px" BackColor="#FFFFC0">XXXXXXXXXXXXXXXXX</asp:TextBox><br /> 
                              <asp:RequiredFieldValidator ID="valMotoCatalog1" runat="server" ControlToValidate="txtMotoCatalog" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="info" EnableClientScript="False"></asp:RequiredFieldValidator> 
                              <asp:RegularExpressionValidator ID="valMotoCatalog2" runat="server" ControlToValidate="txtMotoCatalog" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英数記号で入力してください" ValidationExpression="^[0-9!-~]*$" ValidationGroup="info"></asp:RegularExpressionValidator>
                            </td> 
                            <!-- ASSY区分 --> 
                            <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>ASSY区分</b></font></td> 
                            <td align="left" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtAssy" runat="server" MaxLength="1" Width="10px" onFocus="showAssyGuide(true);" onBlur="showAssyGuide(false);"></asp:TextBox>&nbsp;<asp:Label ID="lblAssy" runat="server" /><br />
                              <asp:CustomValidator ID="valAssy" runat="server" ControlToValidate="txtAssy" Display="Dynamic" ValidationGroup="info" EnableClientScript="False"></asp:CustomValidator> 
                              <div id="divAssy" style="color: #191970; font-size: small; display:none;">[0:製品 1:子部品 空白:その他]</div>
                            </td>
                            <!-- 原価区分 --> 
                            <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>原価区分</b></font></td> 
                            <td align="left" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtCost" runat="server" MaxLength="2" Width="20px" onFocus="showCostGuide(true);" onBlur="showCostGuide(false);"></asp:TextBox>&nbsp;<asp:Label ID="lblCost" runat="server" /><br />
                              <asp:CustomValidator ID="valCost" runat="server" ControlToValidate="txtCost" Display="Dynamic" ValidationGroup="info" EnableClientScript="False"></asp:CustomValidator> 
                              <div id="divCost" style="color: #191970; font-size: small; display:none;">[01：源部品、05：Assy 子、06：Assy 親、空白：その他]</div>
                            </td>
                          </tr>
                          <tr height="20"> 
                            <!-- 組番 --> 
                            <td align="center" width="120" bgcolor="#4e7e4a">
                              <font color="#f7f7f7"><b>
                                <asp:Panel ID="pnlKumiInput" runat="server"><a class="nav" href="#" onclick="listMDSRC080('MS014',document.getElementById('txtKumiban'),document.getElementById('lblKumibanName'));document.getElementById('txtKumiban').focus();return false;">組番</a></asp:Panel>
                                <asp:Panel ID="pnlKumi" runat="server">組番</asp:Panel>
                              </b></font>
                            </td> 
                            <td align="left" width="210" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtKumiban" runat="server" MaxLength="2" Width="20px" BackColor="#FFFFC0" onChange="getKumiName();"></asp:TextBox>&nbsp;<asp:Label ID="lblKumibanName" runat="server">ＮＮＮＮＮ</asp:Label><br />
                              <asp:RequiredFieldValidator ID="valKumiban1" runat="server" ControlToValidate="txtKumiban" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="info" EnableClientScript="False"></asp:RequiredFieldValidator>
                              <asp:CustomValidator ID="valKumiban2" runat="server" ControlToValidate="txtKumiban" Display="Dynamic" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="False" ErrorMessage="汎用マスタに未登録です"></asp:CustomValidator> 
                            </td> 
                            <!-- 製品グループ１ --> 
                            <td align="center" width="120" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>製品グループ１</b></font></td> 
                            <td align="left" width="180" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblGroup1" runat="server">9999</asp:Label>&nbsp;<asp:Label ID="lblGroupName1" runat="server">XXXXXXXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                            <!-- 製品グループ２ --> 
                            <td align="center" width="120" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>製品グループ２</b></font></td> 
                            <td align="left" width="180" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblGroup2" runat="server">9999</asp:Label>&nbsp;<asp:Label ID="lblGroupName2" runat="server">XXXXXXXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                          </tr> 
                          <tr>
                            <!-- 生産停止区分 -->
                            <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>生産停止</b></font></td> 
                            <td bgcolor="#D9FFCC"><asp:CheckBox ID=chkTeisi runat=server /></td>
                            <!-- グループコード -->
                            <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>グループコード</b></font></td> 
                            <td bgcolor="#D9FFCC"><asp:TextBox ID="txtGroupCode" runat="server" MaxLength="1" Width="10px">X</asp:TextBox></td>
                            <!-- ロイヤリティ区分 -->
                            <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>ロイヤリティ区分</b></font></td> 
                            <td bgcolor="#D9FFCC"><asp:TextBox ID="txtRoyalties" runat="server" MaxLength="1" Width="10px" onFocus="showRoyaltiesGuide(true);" onBlur="showRoyaltiesGuide(false);"></asp:TextBox>&nbsp;<asp:Label ID="lblRoyalties" runat="server" /><br />
                            <asp:CustomValidator ID="valRoyalties" runat="server" ControlToValidate="txtRoyalties" Display="Dynamic" ValidationGroup="info" EnableClientScript="False"></asp:CustomValidator>
                            <div id="divRoyalties" style="color: #191970; font-size: small; display:none;">[1：ロイヤリティ支払品、空白：その他]</div>
                            </td>
                          </tr>
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td> 
                        <table border="0" cellpadding="2" cellspacing="1"> 
                          <tr> 
                            <!-- 材料コード --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"><font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC020('',document.getElementById('txtZairyo'),null,null);document.getElementById('txtZairyo').focus();return false;">材料コード</a></b></font></td> 
                            <td align="left" width="170" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtZairyo" runat="server" MaxLength="15" Width="120px" onChange="setTani(this);">XXXXXXXXXXXXXXX</asp:TextBox><br /> 
                              <asp:CustomValidator ID="valZairyo1" runat="server" ControlToValidate="txtZairyo" Display="Dynamic" ErrorMessage="主材料マスタに未登録です" ValidationGroup="info" EnableClientScript="False" ></asp:CustomValidator> 
                            </td> 
                            <!-- 素材長 --> 
                            <td align="center" width="60" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>素材長</b></font></td> 
                            <td align="left" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSozai" runat="server" MaxLength="9" Width="70px" Style="text-align:right" onChange="getTanju();">9999999.9</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSozai1" runat="server" ControlToValidate="txtSozai" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数7桁以内、小数1桁以内で入力して下さい" ValidationExpression="^[0-9]{1,7}(\.[0-9])?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                            </td> 
                            </td> 
                            <!-- 材料単位区分 --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>材料単位区分</b></font></td> 
                            <td align="left" width="100" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtTani" runat="server" MaxLength="1" Width="10px" onFocus="showGuide(true);" onBlur="showGuide(false);">X</asp:TextBox><br /> 
                              <asp:CustomValidator ID="valTani1" runat="server" ControlToValidate="txtTani" Display="Dynamic" ErrorMessage="値が不正です" ValidationGroup="info" EnableClientScript="False" ></asp:CustomValidator> 
                            </td> 
                            <!-- 単重 --> 
                            <td align="center" width="60" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>単重</b></font></td> 
                            <td align="left" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtTanju" runat="server" MaxLength="9" Width="70px" Style="text-align:right">9999999.9</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valTanju1" runat="server" ControlToValidate="txtTanju" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数7桁以内、小数1桁以内で入力して下さい" ValidationExpression="^[0-9]{1,7}(\.[0-9])?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                            </td> 
                            <td width="100"></td> 
                          </tr> 
                          <tr height="20"> 
                            <!-- 材料スペック --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>材料SPEC</b></font></td> 
                            <td align="left" width="170" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblSpec" runat="server">XXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                            <!-- ガイド --> 
                            <td align="center" colspan="7"> 
                              <asp:Label ID="lblGuide" runat="server" ForeColor="MidnightBlue">[空白:ｸﾞﾗﾑ(ｺｲﾙ,板材) M:ﾐﾘﾒｰﾄﾙ(棒,六角材) F:ﾌｨｰﾄ(TUBE) ｺ:EA(個)部品等]</asp:Label> 
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td> 
                        <table border="0" cellpadding="2" cellspacing="1"> 
                          <tr height="20"> 
                            <!-- 寸法名：寸法 --> 
                            <td align="center" width="100" bgcolor="#4e7e4a" rowspan="2"> 
                              <font color="#f7f7f7"><b>寸法名:寸法</b></font> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName1" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou1" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou1a" runat="server" ControlToValidate="txtSunpou1" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou1b" runat="server" ControlToValidate="txtSunpouName1" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName2" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou2" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou2a" runat="server" ControlToValidate="txtSunpou2" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou2b" runat="server" ControlToValidate="txtSunpouName2" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName3" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou3" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou3a" runat="server" ControlToValidate="txtSunpou3" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou3b" runat="server" ControlToValidate="txtSunpouName3" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName4" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou4" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou4a" runat="server" ControlToValidate="txtSunpou4" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou4b" runat="server" ControlToValidate="txtSunpouName4" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName5" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou5" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou5a" runat="server" ControlToValidate="txtSunpou5" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou5b" runat="server" ControlToValidate="txtSunpouName5" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                          </tr> 
                          <tr> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName6" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou6" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou6a" runat="server" ControlToValidate="txtSunpou6" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou6b" runat="server" ControlToValidate="txtSunpouName6" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName7" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou7" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou7a" runat="server" ControlToValidate="txtSunpou7" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou7b" runat="server" ControlToValidate="txtSunpouName7" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName8" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou8" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou8a" runat="server" ControlToValidate="txtSunpou8" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou8b" runat="server" ControlToValidate="txtSunpouName8" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName9" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou9" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou9a" runat="server" ControlToValidate="txtSunpou9" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou9b" runat="server" ControlToValidate="txtSunpouName9" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                            <td align="left" valign="top" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSunpouName10" runat="server" MaxLength="2" Width="15px" >XX</asp:TextBox> 
                              <asp:TextBox ID="txtSunpou10" runat="server" MaxLength="6" Width="45px" Style="text-align:right">999.99</asp:TextBox><br /> 
                              <asp:RegularExpressionValidator ID="valSunpou10a" runat="server" ControlToValidate="txtSunpou10" Display="Dynamic" EnableClientScript="False" ErrorMessage="整数3桁以内、小数2桁以内で入力して下さい" ValidationExpression="^[0-9]{1,3}(\.[0-9]{1,2})?$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valSunpou10b" runat="server" ControlToValidate="txtSunpouName10" Display="Dynamic" ErrorMessage="" ValidationGroup="info" EnableClientScript="False" ValidateEmptyText="True"></asp:CustomValidator> 
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td> 
                        <table border="0" cellpadding="2" cellspacing="1"> 
                          <tr> 
                            <!-- 熱処理テストピース --> 
                            <td align="center" width="140" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>熱処理テストピース</b></font> 
                            </td> 
                            <td align="left" bgcolor="#D9FFCC" colspan="3"> 
                              <asp:DropDownList ID="cboTest" runat="server"></asp:DropDownList> 
                            </td> 
                          </tr> 
                          <tr> 
                            <!-- 原図面番号 --> 
                            <td align="center" width="140" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>原図面番号</b></font> 
                            </td> 
                            <td align="left" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtGenga" runat="server" MaxLength="17" Width="130px">XXXXXXXXXXXXXXXXX</asp:TextBox><br /> 
                            </td> 
                            <!-- 部品名称 --> 
                            <td align="center" width="80" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>部品名称</b></font> 
                            </td> 
                            <td align="left" width="170" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtBuhin" runat="server" MaxLength="20" Width="150px">XXXXXXXXXXXXXXXXXXXX</asp:TextBox>
                              <br />
                              <asp:CustomValidator ID="valBuhin" runat="server" ControlToValidate="txtBuhin" 
                                Display="Dynamic" EnableClientScript="False" ErrorMessage="20バイト以内で入力して下さい" 
                                ValidationGroup="info"></asp:CustomValidator>
                            </td> 
                          </tr> 
                          <tr> 
                            <!-- 図面管理NO --> 
                            <td align="center" width="140" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>図面管理NO</b></font> 
                            </td> 
                            <td align="left" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtZumen" runat="server" MaxLength="15" Width="120px" BackColor="#FFFFC0">XXXX-XXXX-XX-XX</asp:TextBox><br /> 
                              <asp:RequiredFieldValidator ID="txtZumen1" runat="server" ControlToValidate="txtZumen" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="info" EnableClientScript="False"></asp:RequiredFieldValidator> 
                              <asp:RegularExpressionValidator ID="txtZumen2" runat="server" ControlToValidate="txtZumen" Display="Dynamic" EnableClientScript="False" ErrorMessage="XXXX-XXXX-XX-XXの形式で入力して下さい" ValidationExpression="^\w{4}\-\w{4}\-\w{2}\-\w{2}$" ValidationGroup="info"></asp:RegularExpressionValidator> 
                            </td> 
                            <!-- 梱包表示 --> 
                            <td align="center" width="80" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>梱包表示</b></font> 
                            </td> 
                            <td align="left" width="170" bgcolor="#D9FFCC"> 
                              <asp:DropDownList ID="cboKonpou" runat="server"></asp:DropDownList> 
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td> 
                        <table border="0" cellpadding="2" cellspacing="1"> 
                          <tr> 
                            <!-- 作成者 --> 
                            <td align="center" width="60" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC030(document.getElementById('txtSakusei'),null,document.getElementById('lblSakusei'));document.getElementById('txtSakusei').focus();return false;">作成者</a></b></font> 
                            </td> 
                            <td align="left" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtSakusei" runat="server" MaxLength="4" Width="40px" BackColor="#FFFFC0" onChange="getName('1',this);">XXXX</asp:TextBox> 
                              <asp:Label ID="lblSakusei" runat="server">ＮＮＮＮＮ</asp:Label><br /> 
                              <asp:RequiredFieldValidator ID="valSakusei1" runat="server" ControlToValidate="txtSakusei" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="info" EnableClientScript="False"></asp:RequiredFieldValidator> 
                              <asp:CustomValidator ID="valSakusei2" runat="server" ControlToValidate="txtSakusei" Display="Dynamic" ErrorMessage="作業者マスタに未登録です" ValidationGroup="info" EnableClientScript="False" ></asp:CustomValidator> 
                            </td> 
                            <!-- 点検者 --> 
                            <td align="center" width="60" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC030(document.getElementById('txtTenken'),null,document.getElementById('lblTenken'));document.getElementById('txtTenken').focus();return false;">点検者</a></b></font> 
                            </td> 
                            <td align="left" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtTenken" runat="server" MaxLength="4" Width="40px" onChange="getName('2',this);">XXXX</asp:TextBox> 
                              <asp:Label ID="lblTenken" runat="server">ＮＮＮＮＮ</asp:Label> 
                              <asp:CustomValidator ID="valTenken2" runat="server" ControlToValidate="txtTenken" Display="Dynamic" ErrorMessage="作業者マスタに未登録です" ValidationGroup="info" EnableClientScript="False" ></asp:CustomValidator> 
                            </td> 
                            <!-- 承認者(技術) --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC030(document.getElementById('txtGijutu'),null,document.getElementById('lblGijutu'));document.getElementById('txtGijutu').focus();return false;">承認者(技術)</a></b></font> 
                            </td> 
                            <td align="left" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtGijutu" runat="server" MaxLength="4" Width="40px" onChange="getName('3',this);">XXXX</asp:TextBox> 
                              <asp:Label ID="lblGijutu" runat="server">ＮＮＮＮＮ</asp:Label> 
                              <asp:CustomValidator ID="valGijutu2" runat="server" ControlToValidate="txtGijutu" Display="Dynamic" ErrorMessage="作業者マスタに未登録です" ValidationGroup="info" EnableClientScript="False" ></asp:CustomValidator> 
                            </td> 
                            <!-- 承認者(品管) --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC030(document.getElementById('txtHinkan'),null,document.getElementById('lblHinkan'));document.getElementById('txtHinkan').focus();return false;">承認者(品管)</a></b></font> 
                            </td> 
                            <td align="left" width="150" bgcolor="#D9FFCC"> 
                              <asp:TextBox ID="txtHinkan" runat="server" MaxLength="4" Width="40px" onChange="getName('4',this);">XXXX</asp:TextBox> 
                              <asp:Label ID="lblHinkan" runat="server">ＮＮＮＮＮ</asp:Label> 
                              <asp:CustomValidator ID="valHinkan2" runat="server" ControlToValidate="txtHinkan" Display="Dynamic" ErrorMessage="作業者マスタに未登録です" ValidationGroup="info" EnableClientScript="False" ></asp:CustomValidator> 
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td> 
                        <table border="0" cellpadding="2" cellspacing="1"> 
                          <tr height="20"> 
                            <!-- 滅菌区分 --> 
                            <td align="center" width="120" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>滅菌区分</b></font> 
                            </td> 
                            <td align="left" width="200" bgcolor="#D9FFCC"> 
                              <asp:CheckBox ID="chkMekkin" runat="server" Enabled="false" /></td> 
                            <td align="left" colspan="4"> 
                            </td> 
                          </tr> 
                          <tr height="20"> 
                            <!-- 製品標準書番号 --> 
                            <td align="center" width="120" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>製品標準書番号</b></font> 
                            </td> 
                            <td align="left" width="200" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblSeihin" runat="server">XXXXXXXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                            <!-- 承認番号 --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>承認番号</b></font> 
                            </td> 
                            <td align="left" width="200" bgcolor="#D9FFCC" style="word-break:break-all"> 
                              <asp:Label ID="lblSyounin" runat="server">XXXXXXXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                            <!-- 販売名 --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>販売名</b></font> 
                            </td> 
                            <td align="left" width="200" bgcolor="#D9FFCC" style="word-break:break-all"> 
                              <asp:Label ID="lblHanbai" runat="server">XXXXXXXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                          </tr> 
                          <tr height="20"> 
                            <!-- 一般名称 --> 
                            <td align="center" width="120" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>一般名称</b></font> 
                            </td> 
                            <td align="left" width="200" bgcolor="#D9FFCC" style="word-break:break-all"> 
                              <asp:Label ID="lblIppan" runat="server">XXXXXXXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                            <!-- 種類名1 --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>種類名1</b></font> 
                            </td> 
                            <td align="left" width="200" bgcolor="#D9FFCC" style="word-break:break-all"> 
                              <asp:Label ID="lblSyurui1" runat="server">XXXXXXXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                            <!-- 種類名2 --> 
                            <td align="center" width="100" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>種類名2</b></font> 
                            </td> 
                            <td align="left" width="200" bgcolor="#D9FFCC" style="word-break:break-all"> 
                              <asp:Label ID="lblSyurui2" runat="server">XXXXXXXXXXXXXXXXXXXX</asp:Label> 
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td> 
                        <table border="0" cellpadding="2" cellspacing="1"> 
                          <tr height="20"> 
                            <!-- トルクスNO --> 
                            <td align="center" width="80" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>トルクスNO</b></font> 
                            </td> 
                            <td align="left" width="100" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblTorukus" runat="server">ＮＮＮＮＮ</asp:Label> 
                            </td> 
                            <!-- 軸荒径 --> 
                            <td align="center" width="80" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>軸荒径</b></font> 
                            </td> 
                            <td align="left" width="100" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblJiku" runat="server">ＮＮＮＮＮ</asp:Label> 
                            </td> 
                            <!-- 材料径 --> 
                            <td align="center" width="80" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>材料径</b></font> 
                            </td> 
                            <td align="left" width="100" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblZairyo" runat="server">ＮＮＮＮＮ</asp:Label> 
                            </td> 
                            <!-- ネジ外径 --> 
                            <td align="center" width="80" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>ネジ外径</b></font> 
                            </td> 
                            <td align="left" width="100" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblNeji" runat="server">ＮＮＮＮＮ</asp:Label> 
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td> 
                        <table border="0" cellpadding="2" cellspacing="1"> 
                          <tr height="20"> 
                            <td align="center" width="80" bgcolor="#4e7e4a" rowspan="2"> 
                              <font color="#f7f7f7"><b>最新訂符</b></font> 
                            </td> 
                            <td align="center" width="120" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>工程票</b></font> 
                            </td> 
                            <td align="center" width="120" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>部品標準書</b></font> 
                            </td> 
                            <td align="center" width="120" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>加工図</b></font> 
                            </td> 
                            <td align="center" width="120" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>製品図面</b></font> 
                            </td> 
                            <td align="center" width="120" bgcolor="#4e7e4a"> 
                              <font color="#f7f7f7"><b>試験・検査表</b></font> 
                            </td> 
                          </tr> 
                          <tr height="20"> 
                            <!-- 工程票 --> 
                            <td align="center" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblKoutei1" runat="server">XXX</asp:Label>&nbsp;<asp:Label ID="lblKoutei2" runat="server">YYYY/MM/DD</asp:Label> 
                            </td> 
                            <!-- 部品標準書 --> 
                            <td align="center" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblHyoujunsho1" runat="server">XXX</asp:Label>&nbsp;<asp:Label ID="lblHyoujunsho2" runat="server">YYYY/MM/DD</asp:Label> 
                            </td> 
                            <!-- 加工図 --> 
                            <td align="center" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblKakouzu1" runat="server">XXX</asp:Label>&nbsp;<asp:Label ID="lblKakouzu2" runat="server">YYYY/MM/DD</asp:Label> 
                            </td> 
                            <!-- 製品図面 --> 
                            <td align="center" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblZumen1" runat="server">XXX</asp:Label>&nbsp;<asp:Label ID="lblZumen2" runat="server">YYYY/MM/DD</asp:Label> 
                            </td> 
                            <!-- 試験・検査表 --> 
                            <td align="center" bgcolor="#D9FFCC"> 
                              <asp:Label ID="lblSiken1" runat="server">XXX</asp:Label>&nbsp;<asp:Label ID="lblSiken2" runat="server">YYYY/MM/DD</asp:Label> 
                            </td> 
                          </tr> 
                        </table> 
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td width="100%" align="center">                        
                          <asp:ImageButton ID="btnKakouInsert" runat="server" ImageUrl="~/image/b_kakou.gif" />
                      </td> 
                    </tr> 
                    <tr height="5"><td></td></tr> 
                    <tr> 
                      <td width="100%" align="center"> 
                        <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="update"></asp:CustomValidator>                        
                          <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_insert.gif" />                        
                          <asp:ImageButton ID="btnUpdate" runat="server" ImageUrl="~/image/b_update.gif" />                        
                          <asp:ImageButton ID="btnDelete" runat="server" ImageUrl="~/image/b_delete.gif" />                        
                          <asp:ImageButton ID="btnClear" runat="server" ImageUrl="~/image/b_clear.gif" />                        
                          <asp:ImageButton ID="btnBack" runat="server" ImageUrl="~/image/b_back.gif" />
                      </td> 
                    </tr> 
                  </table> 
                  </asp:Panel> 
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
