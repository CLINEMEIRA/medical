<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas170" Codebehind="mdmas170.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function SelectAllCheckboxes(chkB) { 
      elem=chkB.form.elements; 
      for(i=0;i<elem.length;i++) { 
        if(elem[i].type=='checkbox' && elem[i].id!=chkB.id) { 
          if(elem[i].checked!=chkB.checked) 
            elem[i].click(); 
        } 
      } 
    } 
    function progressNone(oFrame) 
    { 
        try { 
            document.frmList.imgProgress.style.display = "none"; 
        } catch(e){ 
        } 
    } 
  // --></script> 
    <style type="text/css"><!--  
    div#scroll{  
        position:absolute;  
        width:100%;  
        height:100%;  
        background:#F7F7F7;  
        overflow-x:auto; 
    }  
    --></style> 
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
        <table cellpadding="0" cellspacing="0" border="0"> 
          <tr> 
            <td align="center"> 
              <!-- 選択 --> 
              <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <table cellpadding="2" cellspacing="1" border="0"> 
                    <tr> 
                      <td align="center" bgcolor="#4e7e4a" width="100"><font color="#f7f7f7"><b>更新年月日</b></font> 
                      </td> 
                      <td align="left" bgcolor="#d9ffcc" width=550> 
                        <table cellpadding="0" cellspacing="0" border="0"> 
                          <tr> 
                            <td width="150"> 
                              <asp:TextBox ID="txtFrom" runat="server" MaxLength="8" Width="80px"></asp:TextBox> 
                              <asp:ImageButton ID="btnNoukiFrom" runat="server" ImageUrl="~/image/i_calen.gif" OnClientClick="listMDSRC000(document.getElementById('txtFrom'));document.getElementById('txtFrom').focus();return false" ImageAlign="Middle" /><br /> 
                              <asp:RegularExpressionValidator ID="valFrom" runat="server" ControlToValidate="txtFrom" Display="Dynamic" EnableClientScript="False" ErrorMessage="日付で入力して下さい" Font-Size="10pt" ValidationExpression="^(?:\d{4}(?:(?:0[1-9]|1[0-2])(?:0[1-9]|1[0-9]|2[0-8])|(?:0[13-9]|1[0-2])(?:29|30)|(?:0[13578]|1[02])31)|(?:\d{2}(?:0[48]|[2468][048]|[13579][26])|(?:[02468][048]|[13579][26])00)0229)$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                            </td> 
                            <td align="center" width="20"> 
                              ～ 
                            </td> 
                            <td width="150"> 
                              <asp:TextBox ID="txtTo" runat="server" MaxLength="8" Width="80px"></asp:TextBox> 
                              <asp:ImageButton ID="btnNoukiTo" runat="server" ImageUrl="~/image/i_calen.gif" OnClientClick="listMDSRC000(document.getElementById('txtTo'));document.getElementById('txtTo').focus();return false" ImageAlign="Middle" /><br /> 
                              <asp:RegularExpressionValidator ID="valTo" runat="server" ControlToValidate="txtTo" Display="Dynamic" EnableClientScript="False" ErrorMessage="日付で入力して下さい" Font-Size="10pt" ValidationExpression="^(?:\d{4}(?:(?:0[1-9]|1[0-2])(?:0[1-9]|1[0-9]|2[0-8])|(?:0[13-9]|1[0-2])(?:29|30)|(?:0[13578]|1[02])31)|(?:\d{2}(?:0[48]|[2468][048]|[13579][26])|(?:[02468][048]|[13579][26])00)0229)$" ValidationGroup="check"></asp:RegularExpressionValidator> 
                            </td> 
                          </tr> 
                        </table> 
                        <asp:CustomValidator ID="valFromTo" runat="server" Display="Dynamic" EnableClientScript="False" 
                          ErrorMessage="更新年月日(自)≦更新年月日(至)で入力して下さい" ValidationGroup="check"></asp:CustomValidator> 
                      </td> 
                    </tr> 
                    <tr align="center">
                      <td align="center" bgcolor=#4e7e4a width="100"> 
                        <font color="#ffffff"><b>対象マスタ<br />
                        <asp:CheckBox ID=chkAll runat=server Text="すべて" onclick="javascript:SelectAllCheckboxes(this);" /></b></font>
                      </td> 
                      <td align="left" bgcolor="#d9ffcc">
                        <table border=0 cellpadding=0 cellspacing=0>
                          <tr>
                            <td width=100><asp:CheckBox ID="chkBuhin" runat=server Text="部品Ｍ" /></td>
                            <td width=100><asp:CheckBox ID="chkKakou" runat=server Text="加工工程Ｍ" /></td>
                            <td width=100><asp:CheckBox ID="chkKousei" runat=server Text="部品構成Ｍ" /></td>
                            <td width=100><asp:CheckBox ID="chkShuzai" runat=server Text="主材料Ｍ" /></td>
                            <td width=100><asp:CheckBox ID="chkShop" runat=server Text="ＳＨＯＰ Ｍ" /></td>
                          </tr>
                          <tr>
                            <td width=100><asp:CheckBox ID="chkKoutei" runat=server Text="工程Ｍ" /></td>
                            <td width=100><asp:CheckBox ID="chkSetubi" runat=server Text="設備Ｍ" /></td>
                            <td width=100><asp:CheckBox ID="chkSagyo" runat=server Text="作業者Ｍ" /></td>
                            <td width=100><asp:CheckBox ID="chkGaityu" runat=server Text="外注Ｍ" /></td>
                            <td width=100><asp:CheckBox ID="chkHanyou" runat=server Text="汎用Ｍ" /></td>
                          </tr>
                        </table>
                          <asp:CustomValidator ID="valCheck" runat="server" Display="Dynamic" EnableClientScript="False"
                              ErrorMessage="1つはチェックを入れて下さい" ValidationGroup="check"></asp:CustomValidator></td>
                    </tr>
                    <tr> 
                      <td> 
                      </td> 
                      <td align="left">                        
                          <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                      </td>
                    </tr> 
                  </table> 
              </ContentTemplate> 
            </asp:UpdatePanel> 
          </tr> 
          <tr> 
            <td> 
              <!-- 一覧 --> 
              <div id="Div1" align=center> 
              <asp:UpdatePanel ID="udpInfo" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <table border="0" width="100%" cellpadding="0" cellspacing="0"> 
                    <tr> 
                      <td align="right"><asp:Label ID="lblCount" runat="server" Text="Label" ForeColor="MidnightBlue"></asp:Label></td> 
                    </tr> 
                  </table> 
                  <asp:Panel ID="pnlInfo" width="920" height="465" ScrollBars="Auto" runat="server">
                  <table border="0" cellpadding="0" cellspacing="0" Width=1470>
                    <tr>
                      <td> 
                        <asp:DataGrid id="grdList" runat="server" AllowPaging="True" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue"> 
                          <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                          <AlternatingItemStyle backcolor="#D9FFCC" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Wrap="False"></AlternatingItemStyle> 
                          <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></ItemStyle> 
                          <PagerStyle forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages" HorizontalAlign="Right" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></PagerStyle> 
                          <Columns> 
                            <asp:TemplateColumn HeaderText="更新年月日" SortExpression="CHANGE_DT"> 
                              <ItemStyle Width="80px" HorizontalAlign="Center" /> 
                              <HeaderStyle Width="80px" /> 
                              <ItemTemplate> 
                                <asp:Label runat="server" Text='<%# medical.MedicalLib.Common.DateFormat(DataBinder.Eval(Container, "DataItem.CHANGE_DT")) %>'></asp:Label> 
                              </ItemTemplate> 
                            </asp:TemplateColumn> 
                            <asp:TemplateColumn HeaderText="更新時刻" SortExpression="CHANGE_TIME"> 
                              <ItemStyle Width="80px" HorizontalAlign="Center" /> 
                              <HeaderStyle Width="80px" /> 
                              <ItemTemplate> 
                                <asp:Label runat="server" Text='<%# medical.MedicalLib.Common.TimeFormat(DataBinder.Eval(Container, "DataItem.CHANGE_TIME")) %>'></asp:Label> 
                              </ItemTemplate> 
                            </asp:TemplateColumn> 
                            <asp:BoundColumn DataField="MASTER_NM" HeaderText="マスタ名" SortExpression="MASTER_NM"> 
                              <ItemStyle width=120px HorizontalAlign="Left" /> 
                              <headerStyle Width=120px /> 
                            </asp:BoundColumn> 
                            <asp:BoundColumn DataField="UPD_KEY" HeaderText="更新キー" SortExpression="UPD_KEY"> 
                              <ItemStyle width=280px HorizontalAlign="Left" /> 
                              <headerStyle Width=280px /> 
                            </asp:BoundColumn> 
                            <asp:BoundColumn DataField="UPD_FIELD_NM" HeaderText="更新項目名" SortExpression="UPD_FIELD_NM"> 
                              <ItemStyle width=150px HorizontalAlign="Left" /> 
                              <headerStyle Width=150px /> 
                            </asp:BoundColumn> 
                            <asp:BoundColumn DataField="BEFORE_VALUE" HeaderText="更新前値" SortExpression="BEFORE_VALUE"> 
                              <ItemStyle width=360px HorizontalAlign="Left" /> 
                              <headerStyle Width=360px /> 
                            </asp:BoundColumn> 
                            <asp:BoundColumn DataField="AFTER_VALUE" HeaderText="更新後値" SortExpression="AFTER_VALUE"> 
                              <ItemStyle width=360px HorizontalAlign="Left" /> 
                              <headerStyle Width=360px /> 
                            </asp:BoundColumn>  
                          </Columns> 
                        </asp:DataGrid> 
                      </td>
                    </tr>
                  </table>
                  </asp:Panel> 
                  <asp:ImageButton ID="btnPrint" runat="server" ImageUrl="~/image/b_print.gif" ImageAlign="Top" OnClick="btnPrint_Click" /> 
                  <br />
                  <img id="imgProgress" name="imgProgress" src="../image/loader.gif" runat="server" visible="false" />
                  <br />
                  <iframe id="fraPrint" width="100" height="0" scrolling="auto" runat="server" onReadyStateChange = "progressNone(this);"></iframe> 
                </ContentTemplate> 
                <Triggers> 
                  <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                </Triggers> 
              </asp:UpdatePanel> 
              </div> 
            </td> 
          </tr> 
        </table> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
