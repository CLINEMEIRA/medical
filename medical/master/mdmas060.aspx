<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas060" Codebehind="mdmas060.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow(code1,code2,key1,key2,key3,page) 
    { 
        var mode = 'i'; 
        if(code1.length > 0) mode = 'u';       
        document.location.href = 'mdmas0601.aspx?mode=' + mode + '&code1=' + code1 + '&code2=' + code2 + '&key1=' + key1 + '&key2=' + key2 + '&key3=' + key3 + '&page=' + page 
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
        <table cellpadding="0" cellspacing="0" border="0" style="margin-right: auto; margin-left: auto"> 
          <tr> 
            <td align="left" style="width: 522px"> 
              <!-- 選択 --> 
              <table cellpadding="2" cellspacing="1" border="0" style="margin-right: auto; margin-left: auto"> 
                <tr> 
                  <td align="center" width="100" bgcolor="#4E7E4A"> 
                    <a class="nav"  href="#" onclick="listMDSRC020('',document.getElementById('txtSCode'),'','');document.getElementById('txtSCode').focus();return false"> 
                      <font color="#F7F7F7"><b>主材料コード</b></font> 
                    </a> 
                  </td> 
                  <td align="left" bgcolor="#D9FFCC" colspan="3"><asp:TextBox ID="txtSCode" runat="server" MaxLength="15" Width="175px"></asp:TextBox></td> 
                </tr> 
                <tr> 
                  <td align="center" bgcolor="#4e7e4a" width="100"><font color="#F7F7F7"><b>材種コード</b></font></td> 
                  <td align="left" bgcolor="#D9FFCC" style="width: 150px"> 
                    <asp:DropDownList ID="ddlZCode" runat="server"> 
                    </asp:DropDownList></td> 
                  <td align="center" bgcolor="#4e7e4a" width="100"><font color="#F7F7F7"><b>形状コード</b></font></td> 
                  <td align="left" bgcolor="#D9FFCC" style="width: 150px"> 
                    <asp:DropDownList ID="ddlKCode" runat="server"> 
                    </asp:DropDownList></td> 
                  </tr> 
                <tr> 
                  <td></td> 
                  <td align="left" style="width: 150px"> 
                    <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                    <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_new.gif" OnClientClick="selectGridRow('','','','','',0);return false;" />
                  </td> 
                  <td align="left" style="width: 100px"> 
                  </td> 
                  <td align="left" style="width: 150px"> 
                  </td> 
                </tr> 
              </table> 
            </td> 
          </tr> 
          <tr> 
            <td> 
              <!-- 一覧 --> 
              <div id="Div1">
              <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <table border="0" cellpadding="0" cellspacing="0" style="width: 100%"> 
                    <tr> 
                      <td align="right"><asp:Label ID="lblCount" runat="server" Text="Label" ForeColor="MidnightBlue"></asp:Label></td> 
                    </tr> 
                  </table>                  
                  <div id="scroll"> 
                  <asp:DataGrid id="grdList" runat="server" AllowPaging="True" PageSize="25" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" Width="1650px"> 
                    <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                    <AlternatingItemStyle backcolor="#D9FFCC" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Wrap="False"></AlternatingItemStyle> 
                    <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></ItemStyle> 
                    <PagerStyle forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages" HorizontalAlign="Justify"></PagerStyle> 
                    <Columns> 
                        <asp:BoundColumn DataField="MATL_CD" HeaderText="主材料コード" SortExpression="MATL_CD"> 
                            <ItemStyle width=120px HorizontalAlign="Left" /> 
                            <headerStyle Width=120px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="REN_NO" HeaderText="連NO" SortExpression="REN_NO"> 
                            <ItemStyle width=50px HorizontalAlign="Left" /> 
                            <headerStyle Width=50px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="MATL_NM" HeaderText="主材料名称" SortExpression="MATL_NM"> 
                            <ItemStyle width=150px HorizontalAlign="Left" /> 
                            <headerStyle Width=150px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="MATL_SPEC" HeaderText="材料SPEC" SortExpression="MATL_SPEC"> 
                            <ItemStyle width=120px HorizontalAlign="Left" /> 
                            <headerStyle Width=120px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="MATL_TYPE_CD" HeaderText="材種コード" SortExpression="MATL_TYPE_CD"> 
                            <ItemStyle width=120px HorizontalAlign="Left" /> 
                            <headerStyle Width=120px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="SHAPE_CD" HeaderText="形状コード" SortExpression="SHAPE_CD"> 
                            <ItemStyle width=100px HorizontalAlign="Left" /> 
                            <headerStyle Width=100px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="MATL_SPFT_NO" HeaderText="材料仕様書No" SortExpression="MATL_SPFT_NO"> 
                            <ItemStyle width=120px HorizontalAlign="Left" /> 
                            <headerStyle Width=120px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="MAGNETISM" HeaderText="磁性" SortExpression="MAGNETISM"> 
                            <ItemStyle width=80px HorizontalAlign="Center" /> 
                            <headerStyle Width=80px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="COEFFICIENT" HeaderText="係数" SortExpression="COEFFICIENT"> 
                            <ItemStyle width=40px HorizontalAlign="Right" /> 
                            <headerStyle Width=40px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="UNIT_KB" HeaderText="単位区分" SortExpression="UNIT_KB"> 
                            <ItemStyle width=70px HorizontalAlign="Left" /> 
                            <headerStyle Width=70px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="UNIT_WAT" DataFormatString="{0:#,##0.#0}" HeaderText="単位重量" SortExpression="UNIT_WAT"> 
                            <ItemStyle width=80px HorizontalAlign="Right" /> 
                            <headerStyle Width=80px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="DELIVER_TERM" HeaderText="納入期間" SortExpression="DELIVER_TERM"> 
                            <ItemStyle width=80px HorizontalAlign="Right" /> 
                            <headerStyle Width=80px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="ORDER_CD1" HeaderText="発注先コード1" SortExpression="ORDER_CD1"> 
                            <ItemStyle width=280px HorizontalAlign="Left" /> 
                            <headerStyle Width=280px /> 
                        </asp:BoundColumn> 
                        <asp:BoundColumn DataField="PERSONAL_MATL" HeaderText="専用材区分" SortExpression="PERSONAL_MATL"> 
                            <ItemStyle width=150px HorizontalAlign="Left" /> 
                            <headerStyle Width=150px /> 
                        </asp:BoundColumn> 
                    </Columns> 
                    <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                        Font-Underline="False" /> 
                    <EditItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                        Font-Underline="False" Wrap="False" /> 
                    <SelectedItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                        Font-Underline="False" Wrap="False" /> 
                  </asp:DataGrid> 
                  </div>                   
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
