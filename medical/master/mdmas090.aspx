﻿<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas090" Codebehind="mdmas090.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow(code,key1,key2,page) 
    { 
        var mode = 'i'; 
        if(code.length > 0) mode = 'u';       
        document.location.href = 'mdmas0901.aspx?mode=' + mode + '&code=' + code + '&key1=' + key1 + '&key2=' + key2 + '&page=' + page 
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
    <tr height="20"> 
        <td> 
        </td> 
    </tr> 
    <!-- 入力フォーム --> 
      <tr height="20"> 
          <td align=center> 
              <table> 
                  <tr> 
                  <td align=center> 
                    <table border="0" cellpadding="2" cellspacing="1"> 
                      <tr> 
                        <td style="width: 100px" bgcolor="#4E7E4A"><font color="#F7F7F7"><b>組織コード</b></font></td> 
                        <td align="left" bgcolor="#D9FFCC" bordercolor="#a6eb8f" style="border-right: #a6eb8f 0px solid; border-top: #a6eb8f 0px solid; border-left: #a6eb8f 0px solid; border-bottom: #a6eb8f 0px solid;"> 
                            <asp:DropDownList ID="ddlCode" runat="server"> 
                            </asp:DropDownList></td> 
                      </tr> 
                        <tr> 
                            <td style="width: 100px"bgcolor="#4E7E4A"><font color="#F7F7F7"><b>SHOP名称</b></font></td> 
                            <td align="left" bgcolor="#D9FFCC" bordercolor="#a6eb8f" style="border-right: #a6eb8f 0px solid; border-top: #a6eb8f 0px solid; border-left: #a6eb8f 0px solid; border-bottom: #a6eb8f 0px solid; width: 250px;"> 
                            <asp:TextBox ID="txtName" CssClass="full" runat="server" MaxLength="15" Width="200px"></asp:TextBox></td> 
                        </tr> 
                      <tr> 
                        <td style="width: 100px"></td> 
                        <td style="width: 250px" align="left">                          
                          <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                          <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_new.gif" OnClientClick="selectGridRow('','','',0);return false;" />
                        </td> 
                      </tr> 
                    </table> 
                  </td> 
                  </tr> 
                  <tr> 
                  <td> 
                      <asp:UpdatePanel ID="UpdatePanel1" runat="server"> 
                        <ContentTemplate> 
                          <table border="0" width="100%" cellpadding="0" cellspacing="0"> 
                          <tr> 
                            <td align="right"><asp:Label ID="lblCount" runat="server" Text="Label" ForeColor="MidnightBlue"></asp:Label></td> 
                          </tr> 
                          </table> 
                          <asp:DataGrid id="grdList" runat="server" AllowPaging="True" AutoGenerateColumns="False" AllowSorting="True" BorderColor="#F7F7F7" BorderStyle="None" BorderWidth="0px" CellPadding="2" CellSpacing="1" ForeColor="MidnightBlue"> 
                              <PagerStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                  Font-Underline="False" HorizontalAlign="Right" Mode="NumericPages" Position="TopAndBottom" /> 
                              <AlternatingItemStyle BackColor="#D9FFCC" /> 
                              <ItemStyle BackColor="White" ForeColor="#4A3C8C" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Left" /> 
                              <HeaderStyle BackColor="#4E7E4A" Font-Bold="True" Font-Underline="True" ForeColor="#F7F7F7" 
                                  Height="25px" HorizontalAlign="Center" /> 
                              <Columns> 
                                  <asp:BoundColumn DataField="SHOP" HeaderText="SHOP" SortExpression="SHOP"> 
                                      <ItemStyle Width="50px" HorizontalAlign="Center" /> 
                                      <HeaderStyle Width="50px" /> 
                                  </asp:BoundColumn> 
                                  <asp:BoundColumn DataField="SHOP_NM" HeaderText="SHOP名称" SortExpression="SHOP_NM"> 
                                      <ItemStyle Width="220px" horizontalalign=Left/> 
                                      <HeaderStyle Width="220px" /> 
                                  </asp:BoundColumn> 
                                  <asp:BoundColumn DataField="ORGANIZE_CD" HeaderText="組織コード" SortExpression="ORGANIZE_CD"> 
                                      <ItemStyle width="220px" HorizontalAlign="Left" /> 
                                      <HeaderStyle Width="220px" /> 
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
