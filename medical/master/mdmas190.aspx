<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdmas190" Codebehind="mdmas190.aspx.vb" %>
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
          if (elem[i] != document.getElementById('chkUpOnly')
           && elem[i] != document.getElementById('chkDouZumen')
           && elem[i] != document.getElementById('chkFullFlag')) {
            if (elem[i].checked != chkB.checked) {
              elem[i].click();
            }
          }
        }
      }
    }
    
    // 小窓検索
    function SelectList(imgB, kb) {
    
      var oTable = document.getElementById("grdList");
    
      var parentElem = imgB.parentElement.all;
      var oText;
      var oLabel;
      for (i = 0; i < parentElem.length; i++) {
        if (parentElem[i].tagName == 'INPUT' && parentElem[i].type == 'text') {
          oText = parentElem[i];
        }
        if (parentElem[i].tagName == 'SPAN') {
          oLabel = parentElem[i];
        }
      }
      
      switch (kb) {
        case 'U':
          listMDSRC030(oText, oLabel, '');
          if (oLabel.innerHTML != "") {
            oLabel.style.width = "100";
          }
          break;
        case 'R':
          listMDSRC0801('0','MS034', oText, oLabel);
          if (oLabel.innerHTML != "") {
            oLabel.style.width = "245";
          }
          break;
      }
      
      //ヘッダ固定
      var oTable = document.getElementById('grdList');
      var topPosi = document.getElementById('pnlScroll').scrollTop;
      oTable.rows[0].cells[0].style.top = topPosi;
      oTable.rows[0].cells[1].style.top = topPosi;
      oTable.rows[0].cells[2].style.top = topPosi;
      oTable.rows[0].cells[3].style.top = topPosi;
      oTable.rows[0].cells[4].style.top = topPosi;
      oTable.rows[0].cells[5].style.top = topPosi;
      oText.focus();
    }
    
    // コールバック
    function getInfo(control, kb) {
    
      var parentElem = control.parentElement.all;
      var oLabel;
      for (i = 0; i < parentElem.length; i++) {
        if (parentElem[i].tagName == 'SPAN') {
          oLabel = parentElem[i];
        }
      }
      
      var command = kb + "\t" + control.value + "\t" + oLabel.id;
      var context = new Object();
      context.CommandName = "getInfo"; 
      <%= _sCallBackScript %>;
    }
    
    function getUpdator(txt, lbl, kb) {
      
      var command = kb + "\t" + txt.value + "\t" + lbl.id;
      var context = new Object();
      context.CommandName = "getInfo"; 
      <%= _sCallBackScript %>;
    }
    
    function getInfoCallBack(result, context) {
      if (result=="") return;
      var TAB = String.fromCharCode(9); 
      var results =result.split(TAB);
      var oLabel = document.getElementById(results[1]);
      
      oLabel.innerText = results[0];
      
      if (oLabel.id != "lblFullUpdatorNM") {
        if (oLabel.innerHTML != "") {
          if (oLabel.id.indexOf("lblUpNM",0) > -1) {
            oLabel.style.width = "100";
          } else {
            oLabel.style.width = "245";
          }
        } else {
          oLabel.style.width = "0";
        }
        
        //ヘッダ固定
        var oTable = document.getElementById('grdList');
        var topPosi = document.getElementById('pnlScroll').scrollTop;
        oTable.rows[0].cells[0].style.top = topPosi;
        oTable.rows[0].cells[1].style.top = topPosi;
        oTable.rows[0].cells[2].style.top = topPosi;
        oTable.rows[0].cells[3].style.top = topPosi;
        oTable.rows[0].cells[4].style.top = topPosi;
        oTable.rows[0].cells[5].style.top = topPosi;
      }
    }
    function getInfoCallBackError(result, context) {
    }
  -->
  </script>
  <style>
    .Freezing
    {
      top:expression(document.getElementById('pnlScroll').top);
      z-index: 10;
    }
  </style>
</head>
<body onload="startClock();"> 
  <form id="frmList" runat="server">
    <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
    <div>
      <medical:PageHeader id="pageheader" runat="Server" />
    </div>
    <div style="height:15px;"></div>
    <div align="center">
      <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
          <table cellpadding="2" cellspacing="1" border="0">
            <tr height="25">
              <td class="head" width="100">カタログ番号</td>
              <td class="detail" width="450">
                <table border="0" cellpadding="0" cellspacing="0">
                  <tr>
                    <td><asp:TextBox ID="txtCatalogFrom" runat="server" MaxLength="17" Width="140px"></asp:TextBox></td>
                    <td width="25" align="center">
                      <asp:ImageButton ID="imgCatalogFrom" runat="server" ImageUrl="~/image/i_list.gif" OnClientClick="listMDSRC0103(document.getElementById('txtCatalogFrom'),null,null);return false;" ImageAlign="middle" />
                    </td>
                    <td width="30" align="center">～</td>
                    <td><asp:TextBox ID="txtCatalogTo" runat="server" MaxLength="17" Width="140px"></asp:TextBox></td>
                    <td width="25" align="center">
                      <asp:ImageButton ID="imgCatalogTo" runat="server" ImageUrl="~/image/i_list.gif" OnClientClick="listMDSRC0103(document.getElementById('txtCatalogTo'),null,'1');return false;" ImageAlign="middle" />
                    </td>
                  </tr>
                </table>
                <asp:CustomValidator ID="valCatalog" runat="server" Display="Dynamic" 
                  EnableClientScript="False" ValidationGroup="key"></asp:CustomValidator>
              </td>
            </tr>
            <tr height="25">
              <td class="head"> 
                <a class="nav" href="#" onclick="listMDSRC0111('', document.getElementById('txtZumen'));document.getElementById('txtZumen').focus;return false;">図面管理番号</a>
              </td>
              <td class="detail">
                <asp:TextBox ID="txtZumen" runat="server" MaxLength="15" Width="120px"></asp:TextBox>
              </td>
            </tr>
            <tr height="25">
              <td class="head"></td>
              <td class="detail">
                <asp:CheckBox ID="chkDouZumen" runat="server" Text="同一図面番号の部品も出力する" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="chkUpOnly" runat="server" Text="修正中のみ" />
              </td>
            </tr>
            <tr>
              <td>
              </td>
              <td align="left">
                
                <asp:CustomValidator ID="valInput" runat="server" Display="Dynamic" 
                  EnableClientScript="False" ErrorMessage="カタログ番号か図面管理番号を入力してください&lt;br /&gt;" 
                  ValidationGroup="input"></asp:CustomValidator>
                
                <asp:ImageButton ID="imgSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                
              </td>
            </tr>
          </table>
        </ContentTemplate>
      </asp:UpdatePanel>
      <div style="height:1px;"></div>
      <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
          <asp:Panel ID="pnlList" runat="server" ScrollBars="Auto" Visible="false" Width="918" HorizontalAlign="Left">
            
            <asp:Panel ID="pnlScroll" runat="server" ScrollBars="Auto" Width="918" Height="321">
              <asp:DataGrid ID="grdList" runat="server" BorderWidth="0px" 
                BorderStyle="None" BorderColor="#F7F7F7" CellPadding="2" CellSpacing="1" 
                GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" 
                Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue"> 
                <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"
                 CssClass="Freezing"></HeaderStyle> 
                <AlternatingItemStyle backcolor="#D9FFCC" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Wrap="False"></AlternatingItemStyle> 
                <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></ItemStyle> 
                <PagerStyle forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages" HorizontalAlign="Right" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></PagerStyle> 
                
                <Columns>
                  <asp:TemplateColumn HeaderStyle-Width="25px">
                    <ItemStyle HorizontalAlign="Right" BackColor="#4e7e4a" ForeColor="#f7f7f7" Font-Bold="true" />
                  </asp:TemplateColumn>
                  <asp:BoundColumn DataField="CATALOG_NO" HeaderText="カタログ番号" HeaderStyle-Width="140px" SortExpression="CATALOG_NO">
                    <HeaderStyle Width="140px" />
                    <ItemStyle Width="140px" HorizontalAlign="Left" /> 
                  </asp:BoundColumn>
                  <asp:BoundColumn DataField="WORK_STD_NO" HeaderText="図面管理番号" HeaderStyle-Width="120px" SortExpression="WORK_STD_NO">
                    <HeaderStyle Width="120px" />
                    <ItemStyle Width="120px" HorizontalAlign="Left" /> 
                  </asp:BoundColumn>
                  <asp:TemplateColumn HeaderText="修正者" HeaderStyle-Width="170px" SortExpression="UPDATOR">
                    <HeaderStyle Width="170px" />
                    <ItemStyle Width="170px" HorizontalAlign="Left" /> 
                    <ItemTemplate>
                      <asp:TextBox ID="txtUpdator" runat="server" MaxLength="4" Width="35" Text='<%#DataBinder.Eval(Container, "DataItem.UPDATOR").toString %>' onChange="getInfo(this, 'U');" ></asp:TextBox>
                      <asp:Label ID="lblUpNM" runat="server" Width="100" Text='<%#DataBinder.Eval(Container, "DataItem.WORKER_NM").toString.Trim%>'></asp:Label><asp:ImageButton ID="btnSelect1" runat="server" ImageUrl="~/image/i_list.gif" OnClientClick="SelectList(this, 'U');return false;" />
                    </ItemTemplate>
                  </asp:TemplateColumn>
                  <asp:TemplateColumn  HeaderText="修正理由" HeaderStyle-Width="300px" SortExpression="UPDATE_REASON">
                    <HeaderStyle Width="300px" />
                    <ItemStyle Width="300px" HorizontalAlign="Left" /> 
                    <ItemTemplate>
                      <asp:TextBox ID="txtReason" runat="server" MaxLength="2" Width="20" Text='<%#DataBinder.Eval(Container, "DataItem.UPDATE_REASON").toString %>' onChange="getInfo(this, 'R');"></asp:TextBox>
                      <asp:Label ID="lblReason" runat="server" Width="245" Text='<%#DataBinder.Eval(Container, "DataItem.ITEM_NM").toString%>'></asp:Label><asp:ImageButton ID="btnSelect2" runat="server" ImageUrl="~/image/i_list.gif" OnClientClick="SelectList(this, 'R');return false;" />
                    </ItemTemplate>
                  </asp:TemplateColumn>
                  <asp:TemplateColumn HeaderText="修正フラグ" HeaderStyle-Width="110px">
                    <HeaderStyle Width="110px" />
                    <ItemStyle Width="110px" HorizontalAlign="Center" /> 
                    <ItemTemplate>
                      <asp:CheckBox ID="chkBox" runat="server" Checked='<%#NOT DataBinder.Eval(Container, "DataItem.UPD_KB").trim.equals("0")%>' />
                    </ItemTemplate>
                  </asp:TemplateColumn>
                  <asp:BoundColumn DataField="UPDATOR" Visible="false">
                  </asp:BoundColumn>
                  <asp:BoundColumn DataField="UPDATE_REASON" Visible="false">
                  </asp:BoundColumn>
                  <asp:BoundColumn DataField="UPD_KB" Visible="false">
                  </asp:BoundColumn>
                </Columns>
                
              </asp:DataGrid>
              
            </asp:Panel>
          </asp:Panel>
        </ContentTemplate>
      </asp:UpdatePanel>
      <asp:UpdatePanel ID="udpBottom" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
          <asp:Panel ID="pnlBottom" runat="server" Visible="false" HorizontalAlign="Center">
            <div style="height:10px;"></div>
            <div>
              <asp:CustomValidator ID="valUpdate" runat="server" Display="Dynamic" 
                EnableClientScript="False" ValidationGroup="update"></asp:CustomValidator>
            </div>
            <div>
              
              <asp:ImageButton ID="imgUpdate" runat="server" ImageUrl="~/image/b_update.gif" />
              <asp:ImageButton ID="imgBack" runat="server" ImageUrl="~/image/b_Back.gif" />
              
            </div>
            
            <div style="height:10px;"></div>
            
            <asp:Panel ID="pnlFull" runat="server">
              <table cellpadding="2" cellspacing="1" border="0">
                <tr height="20">
                  <td class="head" colspan="3">一括入力</td>
                </tr>
                <tr>
                  <td class="head" width="100">
                    <a class="nav" href="#" onclick="listMDSRC030(document.getElementById('txtFullUpdator'), document.getElementById('lblFullUpdatorNM'), '');document.getElementById('txtFullUpdator').focus;return false;">修正者</a>
                  </td>
                  <td class="detail" width="450">
                    <asp:TextBox ID="txtFullUpdator" runat="server" MaxLength="4" Width="35" onChange="getUpdator(this, document.getElementById('lblFullUpdatorNM'), 'U');"></asp:TextBox>
                    <asp:Label ID="lblFullUpdatorNM" runat="server"></asp:Label><br />
                    <asp:CustomValidator ID="valUpdator" runat="server" Display="Dynamic" 
                      EnableClientScript="False" ValidationGroup="full"></asp:CustomValidator>
                  </td>
                  <td width="80" rowspan="3">
                    <asp:ImageButton ID="btnFullUpdate" runat="server" 
                      ImageUrl="~/image/b_update.gif" style="height: 20px" />
                  </td>
                </tr>
                <tr>
                  <td class="head">修正理由</td>
                  <td class="detail">
                    <asp:DropDownList ID="ddlFullReason" runat="server"></asp:DropDownList><br />
                    <asp:CustomValidator ID="valFullReason" runat="server" Display="Dynamic" 
                      EnableClientScript="False" ValidationGroup="full"></asp:CustomValidator>
                  </td>
                </tr>
                <tr>
                  <td class="head">修正フラグ</td>
                  <td class="detail">
                    <asp:CheckBox ID="chkFullFlag" runat="server" />
                  </td>
                </tr>
              </table>
            
            </asp:Panel>
          </asp:Panel>
        </ContentTemplate>
      </asp:UpdatePanel>
    </div>
  </form>
</body>
</html>
