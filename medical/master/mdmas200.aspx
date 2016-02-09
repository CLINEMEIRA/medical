<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdmas200" Codebehind="mdmas200.aspx.vb" %>
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
  <link href="../include/medical.css" rel="stylesheet" type="text/css" />
  <script type="text/javascript" src="../include/medical.js"><!--
  // --></script>
  <script type="text/javascript"><!--  
    function callBack(control) {
      var command = control.value;
      var context = new Object();
      <%= _sCallBackScript %>
    }
    function getKeyCallBack(result, context) {
      document.getElementById('lblOya').innerText = result;
    }
    function getKeyCallBackError(result, context) {
    }
    
    function selectGridRow(row, seihin) {
      
      var tbl = document.getElementById('grdList');
      
      for(i = 0; i < tbl.rows.length; ++i){
        if (row == tbl.rows[i]) {
          changeRowType(tbl.rows[i], "#FFC0C0", true);
        } else {
          if (i % 2 == 1) {
            changeRowType(tbl.rows[i], "#D9FFCC", false);
          } else {
            changeRowType(tbl.rows[i], "#FFFFFF", false);
          }
        }
      }
      
      document.getElementById('saveSeihin').value = seihin;
      document.getElementById('btnSelect').click();
    }
    
    function changeRowType(row, color, selected) {
      row.style.backgroundColor = color;
      row.onmouseover = function(){
        if (selected == true) {
          row.style.backgroundColor = color;
        } else{
          row.style.backgroundColor = "#FFD700";
        }
      };
      row.onmouseout = function(){
        row.style.backgroundColor = color;
      };
    }
    
  // --></script>
</head>
<body onload="startClock();"> 
  <form id="frmList" runat="server">
    <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
    <div>
      <medical:PageHeader id="pageheader" runat="Server" />
    </div>
    <div style="height:25px;"></div>
    <div align="center">
      
      <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
        
          <table border="0" cellpadding="2" cellspacing="1">
            <tr>
              <td class="head" width="100">
                <a class="nav" href="#" onclick="listMDSRC0103(document.getElementById('txtBuhin'),document.getElementById('lblOya'),null);return false;">部品番号</a>
              </td>
              <td class="detail" width="220">
                <asp:TextBox ID="txtBuhin" runat="server" MaxLength="17" BackColor="#FFFFC0" onChange="callBack(this);" Width="140px"></asp:TextBox><br />
                <asp:CustomValidator ID="valBuhin" runat="server" Display="Dynamic" EnableClientScript="False" ValidationGroup="buhin"></asp:CustomValidator>
              </td>
              <td class="head" width="100">
                親社内No
              </td>
              <td class="detail" width="120">
                <asp:Label ID="lblOya" runat="server"></asp:Label>
              </td>
            </tr>
            <tr>
              <td></td>
              <td colspan="3" align="left">
                <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/image/b_search.gif" />
              </td>
            </tr>
          </table>
        
        </ContentTemplate>
      </asp:UpdatePanel>
      
      <div style="height:15px;"></div>
      
      <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
          
          <asp:Panel ID="pnlList" runat="server" HorizontalAlign="Left" Width="330">
          
            <table border="0" cellpadding="2" cellspacing="1">
              <tr class="head" height="20">
                <td width="200">源製品番号</td>
                <td width="100">優先順位</td>
              </tr>
            </table>
            
            <asp:Panel ID="pnlScroll" runat="server" ScrollBars="Auto" Height="251">
            
              <asp:DataGrid id="grdList" runat="server" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False"> 
                <Columns>
                  <asp:BoundColumn DataField="O_PARTS_NO" > 
                    <ItemStyle Width="200px" HorizontalAlign="Left" /> 
                  </asp:BoundColumn> 
                  <asp:BoundColumn DataField="PRIORITY" > 
                    <ItemStyle Width="100px" HorizontalAlign="Right" /> 
                  </asp:BoundColumn> 
                </Columns>
                <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True" Height="20"></ItemStyle> 
                <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
              </asp:DataGrid> 
              
            </asp:Panel>
            
            <div style="height:5px;"></div>
            <div align="right">
              <asp:ImageButton ID="imgNew" runat="server" ImageUrl="~/image/b_new.gif" />
            </div>
            
          </asp:Panel>
          
        </ContentTemplate>
      </asp:UpdatePanel>
      
      <div style="height:30px"></div>
      
      <asp:UpdatePanel ID="udpBottom" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
          
            <input type="hidden" id="saveSeihin" runat="server"/>
            <input type="button" id="btnSelect" name="btnSelect" runat="server" onserverclick="btnSelect_ServerClick" style="display:none" /> 
            
          <asp:Panel ID="pnlBottom" runat="server">
          
            <table border="0" cellpadding="2" cellspacing="1">
              <tr>
                <td class="head" width="120">
                  <asp:Panel ID="pnlGenLink" runat="server">
                    <a class="nav" href="#" onclick="listMDSRC0104(document.getElementById('txtGen'),null,null);return false;">源製品番号</a></asp:Panel>
                  <asp:Panel ID="pnlGen" runat="server">
                    源製品番号</asp:Panel>
                </td>
                <td class="detail" width="250">
                  <asp:TextBox ID="txtGen" runat="server" MaxLength="17" BackColor="#FFFFC0" Width="140px"></asp:TextBox><br />
                  <asp:CustomValidator ID="valGen" runat="server" Display="Dynamic" EnableClientScript="False" ValidationGroup="bottom"></asp:CustomValidator>
                </td>
              </tr>
              <tr>
                <td class="head" width="120">
                  優先順位
                </td>
                <td class="detail" width="250">
                  <asp:TextBox ID="txtJunni" runat="server" MaxLength="3" BackColor="#FFFFC0" Width="40px" Style="text-align:right"></asp:TextBox><br />
                  <asp:CustomValidator ID="valJunni" runat="server" Display="Dynamic" EnableClientScript="False" ValidationGroup="bottom"></asp:CustomValidator>
                </td>
              </tr>
              <tr>
                <td></td>
                <td align="left">
                  <asp:ImageButton ID="imgInsert" runat="server" ImageUrl="~/image/b_insert.gif" />
                  <asp:ImageButton ID="imgUpdate" runat="server" ImageUrl="~/image/b_update.gif" />
                  <asp:ImageButton ID="imgDelete" runat="server" ImageUrl="~/image/b_delete.gif" />
                </td>
              </tr>
            </table>
          
          </asp:Panel>
        
        </ContentTemplate>
      </asp:UpdatePanel>
    </div>
  </form>
</body>
</html>
