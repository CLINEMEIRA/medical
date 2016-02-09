<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdmas152" Codebehind="mdmas152.aspx.vb" %>
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title></title>
  <link href="../include/medical.css" rel="stylesheet" type="text/css" />
  <script language="JavaScript" src="../include/medical.js"><!--
  // --></script>
  <script language="javascript">
  <!--
    // 全チェックボックス変更
    function SelectAllCheckboxes(chkB) {
      var elem = chkB.form.elements;
      for (i = 0; i < elem.length; i++) {
        if (elem[i].type == 'checkbox' && elem[i].id != chkB.id) {
          if (elem[i].checked != chkB.checked) {
            elem[i].click();
          }
        }
      }
    }
  -->
  </script>
</head>
<body onload="startClock();">
  <form id="form1" runat="server">
    <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" />
    <!-- ヘッダー -->
    <div>
      <win:PageHeader id="pageheader" runat="Server" />
    </div>
    
    <div style="height:20px;"></div>
    
    <div align="center">
      <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
          
          <asp:Panel ID="pnlList" runat="server" HorizontalAlign="Center" Width="700">
            
            <table border="0" cellpadding="2" cellspacing="1">
              <tr class="head" height="25">
                <td width= "30">
                  <input type="checkbox" id="chkAll" onclick="SelectAllCheckboxes(this);" />
                </td>
                <td width= "80">指示NO</td>
                <td width= "80">社内NO</td>
                <td width="120">カタログ番号</td>
                <td width="200">現在工程</td>
                <td width= "80">現仕掛数</td>
              </tr>
            </table>
            
            <asp:Panel ID="pnlScroll" runat="server">
            
              <asp:DataGrid id="grdList" runat="server" PageSize="15" 
                BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" 
                CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" 
                Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False" >
                <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle>
                <AlternatingItemStyle backcolor="#d9ffcc"></AlternatingItemStyle>
                <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle>
                <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle>
                
                <Columns>
                  <asp:TemplateColumn>
                    <HeaderStyle Width="30px" />
                    <ItemStyle Width="30px" HorizontalAlign="Center" /> 
                    <ItemTemplate>
                      <asp:CheckBox ID="chkBox" runat="server" Checked="false" />
                    </ItemTemplate>
                  </asp:TemplateColumn>
                  <asp:BoundColumn HeaderText="指示NO" DataField="INDICATE_NO" SortExpression="INDICATE_NO">
                    <HeaderStyle Width="80px" Font-Size="9" />
                    <ItemStyle Width="80px" HorizontalAlign="Center" />
                  </asp:BoundColumn>
                  <asp:BoundColumn HeaderText="社内NO" DataField="COMPANY_NO" SortExpression="COMPANY_NO">
                    <HeaderStyle Width="80px" Font-Size="9pt" />
                    <ItemStyle Width="80px" HorizontalAlign="Center" />
                  </asp:BoundColumn>
                  <asp:BoundColumn HeaderText="カタログ番号" DataField="CATALOG_NO" SortExpression="CATALOG_NO">
                    <HeaderStyle Width="120px" Font-Size="9pt" />
                    <ItemStyle Width="120px" HorizontalAlign="Left" />
                  </asp:BoundColumn>
                  <asp:BoundColumn HeaderText="現在工程" DataField="KOUTEI" SortExpression="KOUTEI">
                    <HeaderStyle Width="200px" Font-Size="9pt" />
                    <ItemStyle Width="200px" HorizontalAlign="Left" />
                  </asp:BoundColumn>
                  <asp:BoundColumn HeaderText="現仕掛数" DataField="PW_AMT" SortExpression="PW_AMT">
                    <HeaderStyle Width="80px" Font-Size="9pt" />
                    <ItemStyle Width="80px" HorizontalAlign="Right" />
                  </asp:BoundColumn>
                </Columns>
                
              </asp:DataGrid> 
            
            </asp:Panel>
            
            <div style="height:3px"></div>
            <div align="right">
              <asp:CustomValidator ID="valInput" runat="server" Display="Dynamic" EnableClientScript="False"></asp:CustomValidator><br />
              <asp:ImageButton ID="imgUpdate" runat="server" ImageUrl="~/image/b_change.gif" />
              <asp:ImageButton ID="imgBack" runat="server" ImageUrl="~/image/b_back.gif" />
            </div>
          </asp:Panel>
          
        </ContentTemplate>
      </asp:UpdatePanel>
    </div>
  </form>
</body>
</html>
