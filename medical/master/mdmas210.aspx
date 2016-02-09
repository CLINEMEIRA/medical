<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas210" Codebehind="mdmas210.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    var DI_MODE = "";
    function callBack(mode,control) {
        var command = ""; 
        var context = new Object(); 
        command = mode + "\t" + control.value; 
        context.CommandName = mode; 
        <%= _sCallBackScript %>
    } 
  
    function getCallBack(result, context) {
        var results = result.split("\t"); 
        if (results[0] == "c"){
            if (results[1] == ""){
                document.getElementById('lblName1').innerText = ""; 
                document.getElementById('lblName2').innerText = ""; 
            }
            else{
                document.getElementById('lblName1').innerText = results[1]; 
                document.getElementById('lblName2').innerText = results[2]; 
            }            
        }
        if (results[0] == "n"){
            if (results[2] == "DEL"){
                DI_MODE = "DEL";
            }
            else{
                DI_MODE = "INS";
            }
        }
        if (results[0] == "k"){
            document.getElementById(results[2]).innerText = results[1];
            //休日の時は残業を選択できなくする
            var drpK = results[2].replace("lblKei", "drpKei");
            var drpZ1 = results[2].replace("lblKei", "drpZan1");
            var drpZ2 = results[2].replace("lblKei", "drpZan2");
            var drpZ3 = results[2].replace("lblKei", "drpZan3");
            var zan1 = results[2].replace("lblKei", "lblZan1");
            var zan2 = results[2].replace("lblKei", "lblZan2");
            var zan3 = results[2].replace("lblKei", "lblZan3");
            if (document.getElementById(drpK).selectedIndex == 0) {
              document.getElementById(drpZ1).selectedIndex = 0
              document.getElementById(drpZ2).selectedIndex = 0
              document.getElementById(drpZ3).selectedIndex = 0
              document.getElementById(drpZ1).disabled = true;
              document.getElementById(drpZ2).disabled = true;
              document.getElementById(drpZ3).disabled = true;
              document.getElementById(zan1).innerText = "";
              document.getElementById(zan2).innerText = "";
              document.getElementById(zan3).innerText = "";
            } else {
              document.getElementById(drpZ1).disabled = false;
              document.getElementById(drpZ2).disabled = false;
              document.getElementById(drpZ3).disabled = false;
            }
        }
        if (results[0] == "z1"){
            document.getElementById(results[2]).innerText = results[1];
        }        
        if (results[0] == "z2"){
            document.getElementById(results[2]).innerText = results[1];
        } 
        if (results[0] == "z3"){
            document.getElementById(results[2]).innerText = results[1];
        } 
    } 
    function getCallBackError(result, context) { 
    } 
    
    function getmessage(){
        var myRet;
        if (document.getElementById('txtdate').value == '') {
            myRet = true;
        } else {
            if (DI_MODE == "DEL"){
                var msg = document.getElementById("txtdate").value.substring(0, 4) + "年" + document.getElementById("txtdate").value.substring(4,6) + "月の設備カレンダーが存在します。初期化処理をしてもよろしいですか？"
                myRet = confirm(msg);
            }
            else{
                myRet = confirm('初期化処理を実行しますか？');
            }
        }
        return myRet;
    }
    
    function changeText1(c) {
        var id = c.id.replace("drpKei", "lblKei");
        //document.getElementById(id).innerText = c.value;     
        var command = "k\t"+ c.value + "\t" + id; 
        var context = new Object(); 
        context.CommandName = command; 
        <%= _sCallBackScript %> 
    }
    
     function changeText2(c,mode) {
        var id = ""
        if (mode=="1"){
            id = c.id.replace("drpZan1", "lblZan1");
        }
        if (mode=="2"){
            id = c.id.replace("drpZan2", "lblZan2");
        }
        if (mode=="3"){
            id = c.id.replace("drpZan3", "lblZan3");
        }
        //document.getElementById(id).innerText = c.value;
        
        var command = "z"+ mode + "\t" + c.value + "\t" + id; 
        var context = new Object(); 
        context.CommandName = command; 
        <%= _sCallBackScript %> 
    }   
    
  // --></script> 
</head> 
<body onload="startClock();"> 
<form id="frmList" runat="server"> 
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
  <div style="width: 100%" align=center> 
    <!-- ヘッダー --> 
    <medical:PageHeader id="pageheader" runat="Server" />
    <div style="height: 20px"></div>
    <!-- 入力フォーム --> 
    <div align=left style="width: 995px">
      
      <!-- 設備コード &　年月度--> 
      <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional" > 
        <ContentTemplate> 
          <table id="tblSelect" cellpadding="2" cellspacing="1" border="0" runat="server"> 
            <tr>
              <td align="center" bgcolor="#4e7e4a" width="120"> 
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#F7F7F7">処理選択</asp:Label>
              </td>
              <td align="left" bgcolor="#d9ffcc" width="300"> 
                <asp:RadioButton ID=rdoSel1 Text="通常" runat=server GroupName=shori Checked="True" OnCheckedChanged="rdoSel_CheckedChanged" AutoPostBack="True" />
                <asp:RadioButton ID=rdoSel2 Text="初期化" runat=server GroupName=shori OnCheckedChanged="rdoSel_CheckedChanged" AutoPostBack="True"/>
              </td>
            </tr>
            <tr> 
              <td align="center" bgcolor="#4e7e4a" width="120"> 
                <font color="#f7f7f7"><b><a id="lnkSetubi" runat="server" class="nav" href="#" onclick="listMDSRC060_2(document.getElementById('txtCode'),document.getElementById('lblName1'),document.getElementById('lblName2'));document.getElementById('txtCode').focus();return false;">設備コード</a></b></font>
              </td> 
              <td width="300" bgcolor="#d9ffcc" align="left"> 
                <asp:TextBox id="txtCode" runat="server" Font-Size="10pt" BackColor="#FFFFC0" Width="50px" MaxLength="4" onChange="callBack('c',this);" onFocus="this.select();"></asp:TextBox> 
                <br /> 
                <asp:RequiredFieldValidator id="valCode1" runat="server" Display="Dynamic" 
                  ControlToValidate="txtCode" ErrorMessage="入力必須項目です" EnableClientScript="False" 
                  ValidationGroup="key1"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="valCode2" runat="server" ControlToValidate="txtCode" 
                  Display="Dynamic" ErrorMessage="設備マスターに未登録です" ValidationGroup="key1" 
                  EnableClientScript="False" OnServerValidate="valCode1_ServerValidate"/>
             </td> 
            </tr> 
            <tr> 
              <td align="center" bgcolor="#4e7e4a" height="29" width="120"> 
                <asp:Label id="Label2" runat="server" font-bold="True" font-size="10pt" forecolor="#F7F7F7">設備名称</asp:Label> 
              </td> 
              <td bgcolor="#d9ffcc" align="left"> 
                <asp:Label ID="lblName1" runat="server" /><br />
                <asp:Label ID="lblName2" runat="server" />
              </td> 
            </tr>     
            <tr>
              <td align="center" bgcolor="#4e7e4a" width="120"> 
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#F7F7F7">年月度</asp:Label>
              </td>
              <td align="left" bgcolor="#d9ffcc"> 
                <asp:TextBox ID="txtdate" runat="server" MaxLength="6" Width="60px" BackColor="#FFFFC0" Text="YYYYMM" onChange="callBack('n',this);" />
                <br /> 
                <asp:RequiredFieldValidator ID="valDate1" runat="server" 
                  ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="入力必須項目です" 
                  ValidationGroup="key2" EnableClientScript="False" />
                <asp:CustomValidator ID="valDate2" runat="server" ControlToValidate="txtDate" 
                  Display="Dynamic" ErrorMessage="" ValidationGroup="key2" 
                  EnableClientScript="False" OnServerValidate="valDate2_ServerValidate"/>
              </td> 
            </tr>
            <tr> 
              <td width="120"></td> 
              <td align="left"> 
                <asp:ImageButton id="btnSearch" runat="server" ImageUrl="../image/b_search.gif" />
                <asp:ImageButton id="btnRun" runat="server" ImageUrl="../image/b_run.gif" OnClientClick="return getmessage();" />
              </td> 
            </tr> 
            <tr>
              <td width="120"></td>
              <td align="left"> 
                <asp:Label ID="lblMessage1" runat="server" /><br />
                <asp:Label ID="lblMessage2" runat="server" />
              </td>
            </tr>
          </table> 
        </ContentTemplate> 
      </asp:UpdatePanel>
      <div style="height: 5px"></div>
              
      <!-- 一覧 --> 
      <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional" > 
        <ContentTemplate> 
          <asp:Panel ID="pnlList" runat="server" HorizontalAlign="Left">
              <table border="0" cellpadding="2" cellspacing="1">
                <tr height="25">
                  <td class="head" width="31">日</td>
                  <td class="head" width="31">曜</td>
                  <td class="head" width="61">形態</td>
                  <td class="head" width="290">稼働時間</td>
                  <td class="head" width="176">残業1</td>
                  <td class="head" width="176">残業2</td>
                  <td class="head" width="176">残業3</td>
                </tr>
              </table>
              <asp:Panel ID="pnlList1" runat="server" Height="360px" ScrollBars="Vertical"> 
                <asp:DataGrid id="grdList" runat="server" PageSize="31" BorderStyle="None" BorderColor="#F7F7F7" BorderWidth="0px" CellPadding="2" CellSpacing="1" GridLines="Vertical" AutoGenerateColumns="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False"> 
                  <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                  <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                  <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                  <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                  <Columns> 
                    <asp:BoundColumn  HeaderText="日" DataField="HIZUKE"> 
                        <ItemStyle Width="31px" HorizontalAlign="Center" /> 
                    </asp:BoundColumn> 
                    <asp:BoundColumn HeaderText="曜" DataField="YOUBI" > 
                        <ItemStyle Width="31px" HorizontalAlign="Center" /> 
                    </asp:BoundColumn>  
                    <asp:TemplateColumn ItemStyle-Width="61px" ItemStyle-HorizontalAlign="center">
                        <ItemTemplate >
                            <asp:DropDownList ID="drpKei" DataValueField="CODE" DataTextField="NAME" DataSource="<%#GetKeitai()%>" OnChange="changeText1(this);" SelectedIndex='<%# GetSelectedIndex(DataBinder.Eval(Container, "DataItem.KEI")) %>' runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    
                    <asp:TemplateColumn ItemStyle-Width="290px" ItemStyle-HorizontalAlign="Left">
                        <ItemTemplate>
                            <asp:Label ID="lblKei" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn ItemStyle-Width="61px" ItemStyle-HorizontalAlign="center"> 
                         <ItemTemplate>
                            <asp:DropDownList ID="drpZan1" DataValueField="Z_CODE" DataTextField="Z_NAME" DataSource="<%#GetZangyou()%>" OnChange="changeText2(this,1);" SelectedIndex='<%# GetSelectedIndex(DataBinder.Eval(Container, "DataItem.ZAN1")) %>' runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn ItemStyle-Width="110px" ItemStyle-HorizontalAlign="Left">
                        <ItemTemplate>
                            <asp:Label ID="lblZan1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    
                    <asp:TemplateColumn ItemStyle-Width="61px" ItemStyle-HorizontalAlign="center"> 
                         <ItemTemplate>
                            <asp:DropDownList ID="drpZan2" DataValueField="Z_CODE" DataTextField="Z_NAME" DataSource="<%#GetZangyou()%>" OnChange="changeText2(this,2);" SelectedIndex='<%# GetSelectedIndex(DataBinder.Eval(Container, "DataItem.ZAN2")) %>' runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn ItemStyle-Width="110px" ItemStyle-HorizontalAlign="Left">
                        <ItemTemplate>
                            <asp:Label ID="lblZan2" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
      
                   <asp:TemplateColumn ItemStyle-Width="61px" ItemStyle-HorizontalAlign="center"> 
                         <ItemTemplate>
                            <asp:DropDownList ID="drpZan3" DataValueField="Z_CODE" DataTextField="Z_NAME" DataSource="<%#GetZangyou()%>" OnChange="changeText2(this,3);" SelectedIndex='<%# GetSelectedIndex(DataBinder.Eval(Container, "DataItem.ZAN3")) %>' runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                     <asp:TemplateColumn ItemStyle-Width="110px" ItemStyle-HorizontalAlign="Left">
                        <ItemTemplate>
                            <asp:Label ID="lblZan3" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:BoundColumn DataField="PLAN_CNT" Visible =false> 
                    </asp:BoundColumn> 
                  </Columns>
                </asp:DataGrid>
              </asp:Panel> 
              <asp:Panel ID="pnlList2" ScrollBars="None" Height="150" runat="server" HorizontalAlign="Center"> 
                <table width="100%">
                  <tr> 
                    <td align="center">
                      <asp:CustomValidator ID="valInput" runat="server" Display="Dynamic" EnableClientScript="False" ValidationGroup="run" OnServerValidate="valInput_ServerValidate"></asp:CustomValidator>
                    </td> 
                  </tr>
                  <tr>
                    <td bgcolor="#f7f7f7" align="right">
                      <asp:ImageButton id="btnInsert" ImageUrl="../image/b_insert.gif" runat="server" />
                      <asp:ImageButton id="btnUpdate" ImageUrl="../image/b_update.gif" runat="server" />
                      <asp:ImageButton id="btnDel" ImageUrl="../image/b_delete.gif" runat="server" />
                      <asp:ImageButton id="btnClear" ImageUrl="../image/b_clear.gif" runat="server" />
                      <asp:ImageButton id="btnBack" ImageUrl="../image/b_back.gif" runat="server" />
                    </td>
                  </tr>
                </table>
              </asp:Panel>
           </asp:Panel>
        </ContentTemplate>
      </asp:UpdatePanel>
    </div>
  </div>
</form> 
</body> 
</html> 
