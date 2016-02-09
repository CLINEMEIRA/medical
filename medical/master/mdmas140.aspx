<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas140" Codebehind="mdmas140.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow(code1,code2,key,page) 
    { 
        var mode = 'i'; 
        if(code1.length > 0) mode = 'u';       
        document.location.href = 'mdmas1401.aspx?mode=' + mode + '&code1=' + code1 + '&code2=' + code2 + '&key=' + key + '&page=' + page 
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
              <table cellpadding="2" cellspacing="1" border="0" align="center"> 
                <tr> 
                  <td align="center" width="100" bgcolor="#4E7E4A"><font color="#F7F7F7"><b>情報区分</b></font></td> 
                  <td align="left" width="300" bgcolor="#D9FFCC"> 
                      <asp:DropDownList ID="ddlKubun" runat="server"> 
                      </asp:DropDownList></td> 
                </tr> 
                <tr> 
                  <td></td> 
                  <td align="left"> 
                    <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                    <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_new.gif" />
                  </td> 
                </tr> 
              </table> 
            </td> 
          </tr> 
          <tr> 
            <td> 
              <!-- 一覧 --> 
              <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" > 
                <ContentTemplate> 
                  <table border="0" width="100%" cellpadding="0" cellspacing="0"> 
                    <tr> 
                      <td align="right"><asp:Label ID="lblCount" runat="server" Text="Label" ForeColor="MidnightBlue"></asp:Label></td> 
                    </tr> 
                  </table> 
                  <asp:DataGrid id="grdList" runat="server" AllowPaging="True" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue"> 
                    <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                    <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                    <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                    <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                    <Columns> 
                        <asp:BoundColumn DataField="INFO_KB" HeaderText="情報区分" SortExpression="INFO_KB"> 
                            <ItemStyle Width="60px" HorizontalAlign="Center" /> 
                            <HeaderStyle Width="60px" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="TELL_CD" HeaderText="識別コード" SortExpression="TELL_CD"> 
                        <ItemStyle Width="80px" HorizontalAlign="Center" /> 
                            <HeaderStyle Width="80px" /> 
                            </asp:BoundColumn> 
                        <asp:BoundColumn DataField="INFO_KB_NM" HeaderText="情報区分名" SortExpression="INFO_KB_NM"> 
                            <ItemStyle Width="150px" HorizontalAlign="Left" /> 
                            <HeaderStyle Width="150px" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="ITEM_NM" HeaderText="項目名漢字" SortExpression="ITEM_NM"> 
                            <ItemStyle Width="320px" HorizontalAlign="Left" Font-Size="9pt" /> 
                            <HeaderStyle Width="320px" /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="ITEM_KN" HeaderText="項目名カナ" SortExpression="ITEM_KN"> 
                            <ItemStyle Width="320px" HorizontalAlign="Left" Font-Size="9pt" /> 
                            <HeaderStyle Width="320px" /> 
                        </asp:BoundColumn> 
                    </Columns> 
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
