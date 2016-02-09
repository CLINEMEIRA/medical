<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas080" Codebehind="mdmas080.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow(code,key1,key2,page) 
    { 
        var mode = 'i'; 
        if(code.length > 0) mode = 'u';       
        document.location.href = 'mdmas0801.aspx?mode=' + mode + '&code=' + code + '&key1=' + key1 + '&key2=' + key2 + '&page=' + page 
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
    <tr height="20"> 
        <td> 
        </td> 
    </tr> 
    <!-- 入力フォーム --> 
      <tr height="20"> 
        <td align=center> 
          <table cellpadding="0" cellspacing="0"> 
            <tr> 
              <td> 
                <table cellspacing="1" cellpadding="2" border="0"> 
                  <tr> 
                    <td style="width: 100px" bgcolor="#4E7E4A"><font color="#F7F7F7"><b>SHOP</b></font></td> 
                    <td align="left" bgcolor="#D9FFCC" bordercolor="#a6eb8f" style="border-right: #a6eb8f 0px solid; border-top: #a6eb8f 0px solid; border-left: #a6eb8f 0px solid; border-bottom: #a6eb8f 0px solid;" width="280"> 
                        <asp:DropDownList ID="ddlShop" runat="server"> 
                        </asp:DropDownList> 
                    </td> 
                  </tr> 
                  <tr> 
                    <td style="width: 100px"bgcolor="#4E7E4A"><font color="#F7F7F7"><b>工程名称</b></font></td> 
                    <td align="left" bgcolor="#D9FFCC" bordercolor="#a6eb8f" style="border-right: #a6eb8f 0px solid; border-top: #a6eb8f 0px solid; border-left: #a6eb8f 0px solid; border-bottom: #a6eb8f 0px solid; width: 250px;"> 
                        <asp:TextBox ID="txtName" CssClass="full" runat="server" MaxLength="20" Width="250px"></asp:TextBox> 
                    </td> 
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
                    <table cellpadding="0" cellspacing="0"> 
                      <tr> 
                        <td> 
                          <asp:DataGrid id="grdList" runat="server" AllowPaging="True" AutoGenerateColumns="False" GridLines="Horizontal" AllowSorting="True" BorderColor="#F7F7F7" BorderStyle="None" BorderWidth="0px" CellPadding="2" CellSpacing="1" ForeColor="MidnightBlue"> 
                            <PagerStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                              Font-Underline="False" HorizontalAlign="Right" Mode="NumericPages" Position="TopAndBottom" /> 
                            <AlternatingItemStyle BackColor="#D9FFCC" /> 
                            <ItemStyle BackColor="White" ForeColor="#4A3C8C" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Left" /> 
                            <HeaderStyle BackColor="#4E7E4A" Font-Bold="True" Font-Underline="True" ForeColor="#F7F7F7" 
                              Height="25px" HorizontalAlign="Center" /> 
                            <Columns> 
                              <asp:BoundColumn DataField="PROCESS_CD" HeaderText="工程ＣＤ" SortExpression="PROCESS_CD"> 
                                  <ItemStyle Width="60px" HorizontalAlign="Center" /> 
                                  <HeaderStyle Width="60px" /> 
                              </asp:BoundColumn> 
                              <asp:BoundColumn DataField="P_ORDER_NM" HeaderText="工程名称" SortExpression="P_ORDER_NM"> 
                                  <ItemStyle Width="140px" HorizontalAlign="Left" /> 
                                  <HeaderStyle Width="140px" /> 
                              </asp:BoundColumn> 
                              <asp:BoundColumn DataField="SHOP" HeaderText="SHOP" SortExpression="SHOP"> 
                                  <ItemStyle Width="240px" HorizontalAlign="Left" /> 
                                  <HeaderStyle Width="240px" /> 
                              </asp:BoundColumn> 
                              <asp:BoundColumn DataField="UNIT_TIME_REQUIRED" HeaderText="単位時間(分)" SortExpression="UNIT_TIME_REQUIRED" DataFormatString="{0:#,##0}"> 
                              <ItemStyle Width="60px" HorizontalAlign="Right" /> 
                                  <HeaderStyle Width="60px" /> 
                              </asp:BoundColumn> 
                              <asp:BoundColumn DataField="WORK_STD" HeaderText="作業標準" SortExpression="WORK_STD"> 
                                  <ItemStyle Width="170px" HorizontalAlign="Left" /> 
                                  <HeaderStyle Width="170px" /> 
                              </asp:BoundColumn> 
                              <asp:BoundColumn DataField="FACILITIES_G_CD" HeaderText="設備集約ＣＤ" SortExpression="FACILITIES_G_CD"> 
                                  <ItemStyle Width="170px" HorizontalAlign="Left" /> 
                                  <HeaderStyle Width="170px" /> 
                              </asp:BoundColumn> 
                              <asp:BoundColumn DataField="親子" HeaderText="親子" SortExpression="親子"> 
                                  <ItemStyle Width="40px" HorizontalAlign="Center" /> 
                                  <HeaderStyle Width="40px" /> 
                              </asp:BoundColumn>
                              <asp:BoundColumn DataField="STD_SETUP_TIME" HeaderText="標準段取(分)" SortExpression="STD_SETUP_TIME" DataFormatString="{0:#0.##}"> 
                                  <ItemStyle Width="60px" HorizontalAlign="Right" /> 
                                  <HeaderStyle Width="60px" /> 
                              </asp:BoundColumn> 
                            </Columns> 
                          </asp:DataGrid> 
                        </td> 
                      </tr> 
                    </table> 
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
