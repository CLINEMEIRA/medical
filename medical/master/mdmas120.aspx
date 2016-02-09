<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas120" Codebehind="mdmas120.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow(code,key,page) 
    { 
        var mode = 'i'; 
        if(code.length > 0) mode = 'u';       
        document.location.href = 'mdmas1201.aspx?mode=' + mode + '&code=' + code + '&key=' + key + '&page=' + page 
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
        <table cellpadding="0" cellspacing="0" border="0"> 
          <tr> 
            <td align="left"> 
              <!-- 選択 --> 
              <table cellpadding="2" cellspacing="1" border="0"> 
                <tr> 
                  <td align="center" width="100" bgcolor="#4E7E4A"><font color="#F7F7F7"><b>外注名称</b></font></td> 
                  <td align="left" width="300" bgcolor="#d9ffcc"><asp:TextBox ID="txtName" CssClass="full" runat="server" MaxLength="30" Width="250px"></asp:TextBox></td> 
                </tr> 
                <tr> 
                  <td></td> 
                  <td align="left"> 
                    <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                    <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_new.gif" OnClientClick="selectGridRow('','',0);return false;" />
                  </td> 
                </tr> 
              </table> 
            </td> 
          </tr> 
          <tr> 
            <td> 
              <!-- 一覧 --> 
              <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional" > 
                <ContentTemplate> 
                  <table border="0" width="100%" cellpadding="0" cellspacing="0"> 
                    <tr> 
                      <td align="right"><asp:Label ID="lblCount" runat="server" Text="Label" ForeColor="MidnightBlue"></asp:Label></td> 
                    </tr> 
                  </table> 
                  <asp:DataGrid id="grdList" runat="server" AllowPaging="True" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue"> 
                    <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                    <AlternatingItemStyle backcolor="#d9ffcc"></AlternatingItemStyle> 
                    <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                    <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                    <Columns> 
                      <asp:BoundColumn  HeaderText="外注C" SortExpression="CONTRACTOUT_CD" DataField="CONTRACTOUT_CD" > 
                          <ItemStyle Width="45px" HorizontalAlign="Center" /> 
                          <HeaderStyle Width="45px" /> 
                      </asp:BoundColumn> 
                      <asp:BoundColumn HeaderText="外注名称" SortExpression="CONTRACTOUT_NM" DataField="CONTRACTOUT_NM" > 
                          <ItemStyle Width="210px" HorizontalAlign="Left" /> 
                          <HeaderStyle Width="210px" /> 
                      </asp:BoundColumn> 
                      <asp:BoundColumn DataField="CONTRACTOUT_OMIS" HeaderText="略号" SortExpression="CONTRACTOUT_OMIS"> 
                          <ItemStyle Width="35px" HorizontalAlign="center" /> 
                          <HeaderStyle Width="35px" /> 
                      </asp:BoundColumn> 
                      <asp:BoundColumn HeaderText="郵便番号" SortExpression="POST_NO" DataField="POST_NO" > 
                          <ItemStyle Width="70px" HorizontalAlign="Center" /> 
                          <HeaderStyle Width="70px" /> 
                      </asp:BoundColumn> 
                      <asp:BoundColumn HeaderText="住所" SortExpression="ADDR1" DataField="ADDR1" > 
                          <ItemStyle Width="210px" HorizontalAlign="Left" /> 
                          <HeaderStyle Width="210px" /> 
                      </asp:BoundColumn> 
                      <asp:BoundColumn HeaderText="電話番号" SortExpression="TEL" DataField="TEL" > 
                          <ItemStyle Width="90px" HorizontalAlign="Center" /> 
                          <HeaderStyle Width="90px" /> 
                      </asp:BoundColumn> 
                      <asp:BoundColumn HeaderText="FAX番号" SortExpression="FAX_NO" DataField="FAX_NO" > 
                          <ItemStyle Width="90px" HorizontalAlign="Center" /> 
                          <HeaderStyle Width="90px" /> 
                      </asp:BoundColumn> 
                      <asp:BoundColumn HeaderText="担当者" SortExpression="PERSON_CHARGE" DataField="PERSON_CHARGE" > 
                          <ItemStyle Width="90px" HorizontalAlign="Left" /> 
                          <HeaderStyle Width="90px" /> 
                      </asp:BoundColumn> 
                      <asp:BoundColumn HeaderText="加工外注区分" SortExpression="CONTRACTOUT_KB" DataField="CONTRACTOUT_KB" > 
                          <ItemStyle Width="80px" HorizontalAlign="Center" /> 
                          <HeaderStyle Width="80px" Font-Size="9" /> 
                      </asp:BoundColumn> 
                    </Columns> 
                      <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                          Font-Underline="False" /> 
                  </asp:DataGrid> 
                </ContentTemplate> 
                <Triggers> 
                  <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                </Triggers> 
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
