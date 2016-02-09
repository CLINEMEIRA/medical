<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas070" Codebehind="mdmas070.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <meta http-equiv="X-UA-Compatible" content="IE=5"/>
  <title></title>  
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script  type="text/javascript" language="JavaScript" src="../include/medical.js"><!-- 
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
  // --></script> 
  <style type="text/css"><!--  
    div#scroll{  
        position:absolute;  
        width:100%;  
        height:100%;  
        background:#F7F7F7;  
        overflow:auto; 
    }  
    --></style>  
</head> 
<body onload="startClock();"> 
<form id="frmList" runat="server"> 
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True"> 
    </asp:ScriptManager> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td><medical:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr><td height="20"></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center"> 
        <table cellpadding="0" cellspacing="0" border="0"> 
          <tr> 
            <td align="left"> 
              <!-- 検索 --> 
              <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <table cellpadding="2" cellspacing="1" border="0"> 
                    <tr> 
                      <td align="center" width="120" bgcolor="#4e7e4a"> 
                        <font color="#f7f7f7"><b><a class="nav" href="#" onclick="listMDSRC010(document.getElementById('txtCatalog'),document.getElementById('lblSyanai'));return false">カタログ番号</a></b></font> 
                      </td> 
                      <td align="left" width="230" bgcolor="#D9FFCC"> 
                        <asp:TextBox ID="txtCatalog" runat="server" MaxLength="17" Width="129px" BackColor="#FFFFC0">XXXXXXXXXXXXXXXXX</asp:TextBox><br /> 
                        <asp:RequiredFieldValidator ID="valCtalog1" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="key" EnableClientScript="False"></asp:RequiredFieldValidator> 
                        <asp:CustomValidator ID="valCatalog2" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" ErrorMessage="部品マスタに登録されていません" ValidationGroup="key" EnableClientScript="False"></asp:CustomValidator> 
                      </td> 
                      <td align="center" width="120" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>社内NO</b></font></td> 
                      <td align="left" width="100" bgcolor="#D9FFCC"> 
                          <asp:Label ID="lblSyanai" runat="server" Width="50px"></asp:Label></td> 
                    </tr> 
                    <tr> 
                      <td></td> 
                      <td align="left" colspan="3"> 
                        <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                      </td> 
                    </tr> 
                  </table> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
          </tr> 
          <tr> 
            <td>              
              <!-- 入力 --> 
              <table border="0" cellpadding="0" cellspacing="0"> 
                <tr> 
                  <td width="300" align="left" valign="top" bgcolor="#D9FFCC" height="540"> 
                    <div id="scroll"> 
                      <asp:UpdatePanel ID="udpTree" runat="server"> 
                          <ContentTemplate> 
                              <asp:TreeView ID="trvList" runat="server" ImageSet="Simple" NodeIndent="10" ShowLines="True" Width="290px" ForeColor="MidnightBlue"> 
                                  <ParentNodeStyle Font-Bold="False" /> 
                                  <HoverNodeStyle Font-Underline="True" ForeColor="#DD5555" /> 
                                  <SelectedNodeStyle Font-Underline="True" ForeColor="#DD5555" HorizontalPadding="0px" 
                                      VerticalPadding="0px" /> 
                                  <NodeStyle Font-Names="Verdana" Font-Size="10pt" ForeColor="Black" HorizontalPadding="0px" 
                                      NodeSpacing="0px" VerticalPadding="0px" /> 
                              </asp:TreeView> 
                          </ContentTemplate>
                          <Triggers> 
                              <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                          </Triggers> 
                      </asp:UpdatePanel> 
                    </div> 
                  </td> 
                  <td width="20"></td> 
                  <td width="500" align="left" valign="top">
                    <asp:UpdatePanel ID="udpInfo" runat="server" UpdateMode="Conditional" RenderMode="Inline"> 
                      <ContentTemplate> 
                        <asp:Panel ID="pnlInfo" runat="server" Wrap="False">
                          <table border="0" cellpadding="0" cellspacing="0"> 
                            <tr> 
                              <td align="left" style="height: 22px;"> 
                                <!-- 親部品 --> 
                                <table border="0" cellpadding="2" cellspacing="1"> 
                                  <tr> 
                                    <td width="1" bgcolor="#f7f7f7" height="20"></td> 
                                    <td align="center" width="100" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>親部品番号</b></font></td> 
                                    <td align="left" bgcolor="#D9FFCC" style="width: 250px;"><asp:Label ID="lblOya" runat="server" Text="Label" Font-Size="10pt"></asp:Label></td> 
                                  </tr> 
                                </table> 
                              </td> 
                            </tr> 
                            <tr><td height="10"></td></tr> 
                            <tr> 
                              <td align="left" valign="top" height="60"> 
                                <!-- 新規・削除ボタン --> 
                                <table border="0" cellpadding="0" cellspacing="0"> 
                                  <tr> 
                                    <td>                                      
                                        <asp:ImageButton ID="btnNew" runat="server" ImageUrl="~/image/b_new.gif" />　                                      
                                        <asp:ImageButton ID="btnSelDel" runat="server" ImageUrl="~/image/b_delete.gif" />
                                    </td> 
                                    <td width="10"></td> 
                                    <td> 
                                      <asp:CustomValidator ID="valSelDel" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="削除対象行がチェックされていません" ValidationGroup="seldel"></asp:CustomValidator>
                                    </td> 
                                  </tr> 
                                </table> 
                              </td>
                            </tr>
                            <tr> 
                              <td align="left" valign="top" height="25"> 
                                <!-- 一覧 --> 
                                <table border="0" cellpadding="2" cellspacing="1" bgcolor="#f7f7f7"> 
                                  <tr> 
                                    <td width="1" bgcolor="#f7f7f7"></td> 
                                    <td bgcolor="#4e7e4a"><asp:CheckBox id="chkAll" onclick="javascript:SelectAllCheckboxes(this);" runat="server" AutoPostBack="false"></asp:CheckBox></td> 
                                    <td align="center" width="250" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>子部品番号</b></font></td> 
                                    <td align="center" width="150" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>子部品使用数量</b></font></td> 
                                  </tr> 
                                </table> 
                              </td>
                            </tr>
                            <tr> 
                              <td align="left" valign="top" height="180"> 
                                <div style="position:relative; vertical-align: top; height:295px; overflow:auto;"> 
                                  <asp:DataGrid id="grdList" runat="server" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False" Font-Size="10pt"> 
                                    <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                                    <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                                    <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                                    <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                                    <Columns> 
                                      <asp:TemplateColumn> 
                                        <ItemTemplate > 
                                          <asp:LinkButton id="btnLink" runat="server" CausesValidation="false" CommandName="Select" Text=""></asp:LinkButton> 
                                        </ItemTemplate> 
                                        <ItemStyle Width="1px" BackColor="#F7F7F7"/> 
                                        <HeaderStyle Width="1px" BackColor="#F7F7F7" /> 
                                      </asp:TemplateColumn> 
                                      <asp:TemplateColumn> 
                                        <ItemStyle horizontalalign="Center"></ItemStyle> 
                                        <HeaderTemplate> 
                                          <asp:CheckBox id="chkAll" onclick="javascript:SelectAllCheckboxes(this);" runat="server" AutoPostBack="false" ToolTip="Select/Deselect All"></asp:CheckBox> 
                                        </HeaderTemplate> 
                                        <ItemTemplate> 
                                          <asp:CheckBox id="chkSelect" runat="server" AutoPostBack="false"></asp:CheckBox> 
                                        </ItemTemplate> 
                                      </asp:TemplateColumn> 
                                      <asp:BoundColumn  HeaderText="子部品番号" DataField="CHD_CATALOG_NO" > 
                                        <ItemStyle Width="250px" HorizontalAlign="Left" /> 
                                        <HeaderStyle Width="250px" /> 
                                      </asp:BoundColumn> 
                                      <asp:BoundColumn HeaderText="子部品使用数量" DataField="USE_AMT" > 
                                        <ItemStyle Width="150px" HorizontalAlign="Right" /> 
                                        <HeaderStyle Width="150px" /> 
                                      </asp:BoundColumn> 
                                      <asp:BoundColumn HeaderText="更新" DataField="更新" Visible="false"> 
                                        <ItemStyle Width="10px" HorizontalAlign="Center" /> 
                                        <HeaderStyle Width="10px" /> 
                                      </asp:BoundColumn> 
                                    </Columns> 
                                    <SelectedItemStyle BackColor="#FFC0C0" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                      Font-Strikeout="False" Font-Underline="False" /> 
                                  </asp:DataGrid> 
                                </div> 
                              </td> 
                            </tr> 
                            <tr><td height="20"></td></tr> 
                            <tr> 
                              <td align="center" valign="top" height="120"> 
                                <!-- 入力 --> 
                                <table border="0" cellpadding="2" cellspacing="1" bgcolor="#f7f7f7"> 
                                  <tr> 
                                    <td width="1" bgcolor="#f7f7f7"></td> 
                                    <td align="center" width="120" bgcolor="#4e7e4a"><font color="#f7f7f7"><b><a id="lnkKo" class="nav" href="#" onclick="listMDSRC0101('1',document.getElementById('txtKo'),null);return false" runat="server">子部品番号</a></b></font><asp:Label ID="lblKo" Text="子部品番号" ForeColor="#f7f7f7" Font-Bold="true" runat="server" /></td> 
                                    <td align="left" width="250" bgcolor="#D9FFCC"> 
                                      <asp:TextBox ID="txtKo" runat="server" BackColor="#FFFFC0" MaxLength="17" Width="140px"></asp:TextBox><br /> 
                                      <asp:RequiredFieldValidator ID="valKo1" runat="server" ControlToValidate="txtKo" EnableClientScript="False" ErrorMessage="必須入力項目です" ValidationGroup="run" Display="Dynamic"></asp:RequiredFieldValidator> 
                                      <asp:CustomValidator ID="valKo2" runat="server" ControlToValidate="txtKo" Display="Dynamic" ErrorMessage="" ValidationGroup="run" EnableClientScript="False"></asp:CustomValidator>
                                      <asp:CustomValidator ID="valDel" runat="server" Display="Dynamic" ErrorMessage="親部品が作業指示中です" ValidationGroup="del" EnableClientScript="False"></asp:CustomValidator>
                                    </td> 
                                  </tr> 
                                  <tr> 
                                    <td width="1" bgcolor="#f7f7f7"></td> 
                                    <td align="center" width="120" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>子部品使用数量</b></font></td> 
                                    <td align="left" width="250" bgcolor="#D9FFCC"> 
                                      <asp:TextBox ID="txtSu" runat="server" BackColor="#FFFFC0" style="text-align:right" MaxLength="3" Width="40px"></asp:TextBox><br /> 
                                      <asp:RequiredFieldValidator ID="valSu1" runat="server" ControlToValidate="txtSu" Display="Dynamic" EnableClientScript="False" ErrorMessage="必須入力項目です" ValidationGroup="run"></asp:RequiredFieldValidator> 
                                      <asp:RegularExpressionValidator ID="valSu2" runat="server" ControlToValidate="txtSu" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+$" ValidationGroup="run"></asp:RegularExpressionValidator> 
                                    </td> 
                                  </tr> 
                                  <tr> 
                                    <td colspan="3" align="center"> 
                                      <asp:CustomValidator ID="valDate" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="update"></asp:CustomValidator> 
                                    </td> 
                                  </tr> 
                                  <tr> 
                                    <td width="1" bgcolor="#f7f7f7"></td> 
                                    <td width="120" bgcolor="#f7f7f7"></td> 
                                    <td width="250" bgcolor="#f7f7f7" align="left">
                                      <asp:ImageButton ID="btnRun" runat="server" ImageUrl="~/image/b_update.gif" />
                                      <asp:ImageButton ID="btnDel" runat="server" ImageUrl="~/image/b_delete.gif" />
                                    </td> 
                                  </tr> 
                                </table> 
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
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
