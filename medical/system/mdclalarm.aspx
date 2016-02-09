<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.mdclalarm" Codebehind="mdclalarm.aspx.vb" %> 
 
<%@ Register Assembly="ActiveReports.Web, Version=9.2.5098.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" 
    Namespace="GrapeCity.ActiveReports.Web" TagPrefix="ActiveReportsWeb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
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
</head> 
<body onload="startClock();"> 
<form id="frmList" runat="server"> 
  <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True"></asp:ScriptManager> 
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
            <td align="left"> 
              <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <asp:Panel ID="pnlList" runat="server"> 
                    <table border="0" cellpadding="2" cellspacing="1"> 
                      <tr height="25"> 
                        <td width="20" align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b><asp:CheckBox id="chkAll" onclick="javascript:SelectAllCheckboxes(this);" runat="server" AutoPostBack="false"></asp:CheckBox></b></font></td> 
                        <td width="180" align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>発生日時</b></font></td> 
                        <td width="600" align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>メッセージ</b></font></td> 
                      </tr> 
                    </table> 
                    <div style="overflow:auto; height:520px"> 
                      <asp:DataGrid id="grdList" runat="server" AllowPaging="False" PageSize="37" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False"> 
                        <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px" ></HeaderStyle> 
                        <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                        <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                        <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="Top" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                        <Columns> 
                          <asp:TemplateColumn ItemStyle-Width="20px" ItemStyle-HorizontalAlign="center" HeaderStyle-Width="20px"> 
                            <ItemTemplate> 
                              <asp:CheckBox ID="chkKakunin" Checked='false' runat="server" style="text-align:right" /> 
                            </ItemTemplate> 
                          </asp:TemplateColumn> 
                          <asp:TemplateColumn HeaderText="発生日" HeaderStyle-Width="180px" ItemStyle-Width="180px" ItemStyle-HorizontalAlign="center"> 
                            <ItemTemplate> 
                              <%#GetHasseibi(DataBinder.Eval(Container, "DataItem.OCCUR_DT"), DataBinder.Eval(Container, "DataItem.OCCUR_TIME"))%> 
                            </ItemTemplate> 
                          </asp:TemplateColumn> 
                          <asp:BoundColumn  HeaderText="メッセージ" DataField="MESSAGE" > 
                            <ItemStyle Width="600px" HorizontalAlign="Left" /> 
                            <HeaderStyle Width="600px" /> 
                          </asp:BoundColumn> 
                          <asp:BoundColumn  HeaderText="アラーム連番" DataField="ALN_REN_BAN" Visible="False"> 
                            <ItemStyle Width="10px" HorizontalAlign="Center" /> 
                          </asp:BoundColumn> 
                        </Columns> 
                        <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
                      </asp:DataGrid> 
                    </div> 
                    <br /> 
                    <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
                      <tr> 
                        <td align="center"> 
                          <asp:CustomValidator ID="valRun" runat="server" ControlToValidate="" Display="Dynamic" ErrorMessage="" ValidationGroup="run" EnableClientScript="False" OnServerValidate="valRun_ServerValidate"></asp:CustomValidator> 
                        </td> 
                      </tr> 
                      <tr> 
                        <td align="right"> 
                          <input type="image" src="../image/b_confirm.gif" id="btnConfirm" runat="server" onserverclick="btnConfirm_ServerClick" /> 
                          <input type="image" src="../image/b_back.gif" id="btnBack" runat="server" onserverclick="btnBack_ServerClick" /> 
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
