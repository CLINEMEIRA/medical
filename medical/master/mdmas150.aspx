<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas150" Codebehind="mdmas150.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow(call,catalog,key1,key2) 
    { 
        var mode = 'i'; 
        if(key1.length > 0) mode = 'u';       
        document.location.href = 'mdmas1501.aspx?mode=' + mode + '&call=' + call + '&catalog=' + catalog + '&key1=' + key1 + '&key2=' + key2; 
    } 
    function callBack(catalog) {
        var command = catalog.value; 
        var context = new Object(); 
        context.CommandName = "0"; 
        <%= _sCallBackScript %> 
    } 
    function getCallBack(result, context) { 
        document.getElementById('lblKumi').innerText = result; 
    } 
    function getCallBackError(result, context) { 
    }   
  // --></script> 
</head> 
<body onload="startClock();"> 
<form id="frmList" runat="server"> 
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td><medical:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="20"><td></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center"> 
        <table cellpadding="0" cellspacing="0" border="0" width="1002"> 
          <tr> 
            <td align="left"> 
              <!-- カタログ番号 & コピー元カタログ番号--> 
              <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional" > 
                <ContentTemplate> 
                  <table id="tblSelect" cellpadding="2" cellspacing="1" border="0" runat="server"> 
                    <tr> 
                      <td align="center" width="160" bgcolor="#4e7e4a"> 
                        <font color="#f7f7f7"><b><a id="lnkCatalog" class="nav" href="#" onclick="listMDSRC010(document.getElementById('txtCatalog'),null);return false;" runat="server">カタログ番号</a></b></font> 
                      </td> 
                      <td align="left" width="250" bgcolor="#D9FFCC"> 
                        <asp:TextBox ID="txtCatalog" runat="server" MaxLength="17" Width="129px" BackColor="#FFFFC0" onchange="callBack(this);this.focus();" >XXXXXXXXXXXXXXXXX</asp:TextBox><br /> 
                        <asp:RequiredFieldValidator ID="valCatalog1" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="key" EnableClientScript="False"></asp:RequiredFieldValidator> 
                        <asp:CustomValidator ID="valCatalog2" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" ErrorMessage="部品マスタに未登録です" ValidationGroup="key" EnableClientScript="False" ></asp:CustomValidator>
                        <asp:CustomValidator ID="valCatalog3" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" ErrorMessage="加工工程マスタに登録済です" ValidationGroup="copykey" EnableClientScript="False" ></asp:CustomValidator>
                      </td> 
                      <td align="center" width="100" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>組番</b></font></td> 
                      <td align="left" width="100" bgcolor="#D9FFCC">
                        <asp:Label ID="lblKumi" Text="" runat="server" />
                      </td> 
                    </tr> 
                    <tr> 
                      <td align="center" width="160" bgcolor="#4e7e4a"> 
                        <font color="#f7f7f7"><b><a id="lnkCopyCatalog" class="nav" href="#" onclick="listMDSRC010(document.getElementById('txtCopyCatalog'),null);return false" runat="server">コピー元カタログ番号</a></b></font> 
                      </td> 
                      <td align="left" width="250" bgcolor="#D9FFCC"> 
                        <asp:TextBox ID="txtCopyCatalog" runat="server" MaxLength="17" Width="130px" /><br /> 
                        <asp:RequiredFieldValidator ID="valCopyCatalog1" runat="server" ControlToValidate="txtCopyCatalog" Display="Dynamic" ErrorMessage="複写時は入力して下さい" ValidationGroup="copy" EnableClientScript="False"></asp:RequiredFieldValidator>                        
                          <asp:CustomValidator ID="valCopyCatalog2" runat="server" ControlToValidate="txtCopyCatalog" Display="Dynamic" EnableClientScript="False" ErrorMessage="加工工程マスタに未登録です" ValidationGroup="copy"></asp:CustomValidator>
                      </td> 
                      <td align="left" colspan="2"> 
                        &nbsp;<asp:ImageButton ID="btnCopy" runat="server" ImageUrl="~/image/b_copy.gif" />
                      </td> 
                    </tr> 
                    <tr> 
                      <td></td> 
                      <td align="left" colspan="3">
                          <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                          <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_new.gif" />
                          <asp:ImageButton ID="btnSort" runat="server" ImageUrl="~/image/b_sort.gif" />
                          <asp:ImageButton ID="btnDel" runat="server" ImageUrl="~/image/b_alldel.gif" />
                          <asp:ImageButton ID="btnBack" runat="server" ImageUrl="~/image/b_back.gif" />
                          <asp:ImageButton ID="btnTekiyou" runat="server" ImageUrl="~/image/b_tekiyou.gif" />
                      </td>
                    </tr>
                  </table> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
          </tr> 
          <tr height="20"> 
           <td> 
           </td> 
         </tr> 
          <tr> 
            <td align="left">
              <!-- 一覧 --> 
              <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <asp:table id="tblHeader"  borderwidth="0" cellpadding="2" cellspacing="1" 
                        backcolor="#f7f7f7" runat="server" > 
                    <asp:TableRow Height="25"> 
                      <asp:TableCell width="30" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">訂符</asp:TableCell> 
                      <asp:TableCell width="32" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">基本工順</asp:TableCell> 
                      <asp:TableCell width="32" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">補助工順</asp:TableCell> 
                      <asp:TableCell width="140" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">工程</asp:TableCell> 
                      <asp:TableCell width="140" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">親工程</asp:TableCell> 
                      <asp:TableCell width="170" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">SHOP</asp:TableCell> 
                      <asp:TableCell width="70" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">設備</asp:TableCell> 
                      <asp:TableCell width="34" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">作業標準</asp:TableCell> 
                      <asp:TableCell width="80" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">サイクル<br />タイム(秒)</asp:TableCell> 
                      <asp:TableCell width="92" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">タクトタイム<br />加算(秒)</asp:TableCell> 
                      <asp:TableCell width="38" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">集約<br />区分</asp:TableCell> 
                      <asp:TableCell width="66" HorizontalAlign="Center" backcolor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true">計画対象<br />区分</asp:TableCell> 
                    </asp:TableRow> 
                  </asp:table> 
                  <asp:Panel ID="pnlList" ScrollBars="Auto" Height="480px" runat="server" > 
                    <asp:DataGrid id="grdList" runat="server" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False"> 
                      <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                      <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                      <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                      <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                      <Columns> 
                        <asp:BoundColumn  HeaderText="訂符" DataField="COR_MARK" > 
                          <ItemStyle Width="30px" HorizontalAlign="Left" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="基本工順" DataField="P_ORDER_MAIN" > 
                          <ItemStyle Width="32px" HorizontalAlign="Right" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="補助工順" DataField="P_ORDER_SUB" > 
                          <ItemStyle Width="32px" HorizontalAlign="Right" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="工程" DataField="PROCESS" > 
                          <ItemStyle Width="140px" HorizontalAlign="Left" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="親工程" DataField="PER_PROCESS" > 
                          <ItemStyle Width="140px" HorizontalAlign="Left" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="SHOP" DataField="SHOP" > 
                          <ItemStyle Width="170px" HorizontalAlign="Left" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="設備" DataField="設備" > 
                          <ItemStyle Width="70px" HorizontalAlign="Left" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="作業標準" DataField="WORK_STD" > 
                          <ItemStyle Width="34px" HorizontalAlign="Left" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="サイクル&lt;br /&gt;タイム(秒)" DataField="CYCLE_TIME" > 
                          <ItemStyle Width="80px" HorizontalAlign="Right" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="タクトタイム&lt;br /&gt;加算(秒)" DataField="TACT_TIME" > 
                          <ItemStyle Width="92px" HorizontalAlign="Right" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="集約&lt;br /&gt;区分" DataField="PUT_TOGETHER_FLG" > 
                          <ItemStyle Width="38px" HorizontalAlign="center" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn HeaderText="計画対象&lt;br /&gt;区分" DataField="PLAN_TARGET_FLG" > 
                          <ItemStyle Width="66px" HorizontalAlign="center" /> 
                        </asp:BoundColumn> 
                      </Columns> 
                      <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
                    </asp:DataGrid> 
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
