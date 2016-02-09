<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas020" Codebehind="mdmas020.aspx.vb" %>
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %>
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    var backRow; 
    var backColor; 
    function selectGridRow1(row,key,color) 
    { 
        var table = document.getElementById('grdList1'); 
        if(backRow != null){ 
            if(backRow != -1){ 
                table.rows[backRow].style.backgroundColor = backColor; 
            } 
        } 
        backRow = row; 
        backColor = color; 
        table.rows[row].style.backgroundColor = "#FFC0C0"; 
        //document.frmList.txtRow.value = row;
        frmList.txtRow.value = row;
        //document.frmList.txtMenuID.value = key;
        frmList.txtMenuID.value = key;
        //document.frmList.btnSelect1.click();
        frmList.btnSelect1.click();
    } 
    function changeColor(row,color) 
    { 
        //if(document.frmList.txtRow.value != row){ 
        if (frmList.txtRow.value != row) {
            var table = document.getElementById('grdList1'); 
            table.rows[row].style.backgroundColor = color; 
        } 
    } 
    function selectGridRow2(key) 
    { 
        //document.frmList.txtSaveID.value = key;
        frmList.txtSaveID.value = key;
        //document.frmList.btnSelect2.click();
        frmList.btnSelect2.click();
    } 
    function callBack(control) { 
      var command = control.value; 
      var context = new Object(); 
      context.CommandName = "p"; 
      <%= _sCallBackScript %> 
    } 
    function getCallBack(result, context) { 
        var results = result.split("\t"); 
        document.getElementById('lblProgramName').innerText = results[0];        
        //getElementById('lblProgramName').innerText = results[0];
    } 
    function getCallBackError(result, context) { 
    } 
  // --></script> 
</head> 
<body onload="startClock();"> 
<form id="frmList" runat="server"> 
  <asp:ScriptManager ID="scrManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td><medical:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="20"><td></td></tr> 
    <tr> 
      <td align="center"> 
        <table cellpadding="0" cellspacing="0" border="0"> 
          <tr> 
            <td align="left"> 
              <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional" > 
                <ContentTemplate> 
                  <table cellpadding="0" cellspacing="1" border="0"> 
                    <tr height="25"> 
                      <!-- 管理レベル --> 
                      <td align="center" width="120" bgcolor="#4E7E4A"><font color="#F7F7F7"><b>管理レベル</b></font></td> 
                      <td align="left" width="250" bgcolor="#d9ffcc"> 
                        <asp:DropDownList ID="cboLevel" runat="server" /> 
                      </td> 
                      <td width="5"></td> 
                      <td align="left">
                        <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                      </td> 
                    </tr> 
                  </table> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
          </tr> 
          <tr height="15"><td></td></tr> 
          <tr> 
            <td> 
              <table border="0" cellpadding="0" cellspacing="0"> 
                <tr> 
                  <!-- レベル1 --> 
                  <td align="left" valign="top" width="400"> 
                    <!-- 一覧 --> 
                    <asp:UpdatePanel ID="udpList1" runat="server" UpdateMode="Conditional" > 
                      <ContentTemplate> 
                        <asp:Panel ID="pnlList1" runat="server"> 
                          <table border="0" cellpadding="0" cellspacing="1"> 
                            <tr height="25"> 
                              <td align="center" width="300" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>メニュー名称</b></font></td> 
                              <td align="center" width="60" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>表示順</b></font></td> 
                            </tr> 
                          </table> 
                          <asp:Panel ID="pnlScroll1" Width="380" Height="380" ScrollBars="Vertical" runat="server"> 
                            <asp:DataGrid id="grdList1" runat="server" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="0" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False" ItemStyle-height="20"> 
                              <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                              <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                              <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                              <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                              <Columns> 
                                <asp:BoundColumn DataField="MENU_ID" Visible="false"> 
                                  <ItemStyle Width="10px" HorizontalAlign="Left" /> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="PG_NM" > 
                                  <ItemStyle Width="300px" HorizontalAlign="Left" /> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="DSP_TURN" DataFormatString="{0:##0}"> 
                                  <ItemStyle Width="60px" HorizontalAlign="Right"/> 
                                </asp:BoundColumn> 
                              </Columns> 
                              <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
                            </asp:DataGrid> 
                          </asp:Panel>                          
                            <asp:ImageButton ID="btnNew1" runat="server" ImageUrl="~/image/b_new.gif" />                          
                            <asp:ImageButton ID="btnBack1" runat="server" ImageUrl="~/image/b_back.gif" />
                        </asp:Panel>
                        <input type="hidden" id="txtRow" name="txtRow" runat="server" /> 
                      </ContentTemplate> 
                    </asp:UpdatePanel> 
                    <br /> 
                    <!-- 入力 --> 
                    <asp:UpdatePanel ID="udpInput1" runat="server" UpdateMode="Conditional" > 
                      <ContentTemplate> 
                        <asp:Panel ID="pnlInput1" runat="server"> 
                          <table cellpadding="0" cellspacing="1" border="0"> 
                            <tr height="25"> 
                              <!-- メニュー名称 --> 
                              <td width="120" align="center" bgcolor="#4e7e4a"><b><a id="lnkMenuName" class="nav" href="#" onclick="listMDSRC220(document.getElementById('txtMenuID'),document.getElementById('txtMenuName'));document.getElementById('txtMenuName').focus();return false;" runat="server">メニュー名称</a><asp:Label ID="lblMenuName" Text="メニュー名称" ForeColor="#F7F7F7" runat="server" /></b></td> 
                              <td width="280" align="left" bgcolor="#d9ffcc"> 
                                <asp:TextBox ID="txtMenuName" CssClass="full" runat="server" MaxLength="25" Width="270px" BackColor="#FFFFC0" /><br /> 
                                <asp:RequiredFieldValidator ID="valMenuName1" runat="server" ControlToValidate="txtMenuName" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="input1" EnableClientScript="False" /> 
                                <asp:RegularExpressionValidator id="valMenuName2" runat="server" ControlToValidate="txtMenuName" Display="Dynamic" ErrorMessage="全角文字で入力して下さい" ValidationExpression="^[ 　]*[^ -~｡-ﾟ]*[ 　]*$" EnableClientScript="False" ValidationGroup="input1" /> 
                                <asp:CustomValidator ID="valMenuName3" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="" ValidationGroup="input1" ControlToValidate="txtMenuName" /> 
                              </td> 
                            </tr> 
                            <tr height="25"> 
                              <!-- 表示順 --> 
                              <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>表示順</b></font></td> 
                              <td align="left" bgcolor="#d9ffcc"> 
                                <asp:TextBox ID="txtMenuNumber" runat="server" MaxLength="3" Width="30px" style="text-align:right" /><br /> 
                                <asp:RegularExpressionValidator ID="valMenuNumber1" runat="server" ControlToValidate="txtMenuNumber" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+$" ValidationGroup="input1" /> 
                              </td> 
                            </tr> 
                            <tr> 
                              <td></td> 
                              <td align="left">                                
                                  <asp:ImageButton ID="btnUpdate1" runat="server" ImageUrl="~/image/b_insert.gif" />
                                  <asp:ImageButton ID="btnDelete1" runat="server" ImageUrl="~/image/b_delete.gif" />
                              </td> 
                            </tr> 
                          </table> 
                        </asp:Panel>                        
                        <asp:HiddenField ID="txtMenuID" runat="server" Value="" />
                        <asp:Button ID="btnSelect1" runat="server" Text="btnSelect1" style="display:none" />
                      </ContentTemplate> 
                    </asp:UpdatePanel> 
                  </td> 
                  <td width="20"></td> 
                  <!-- レベル2 --> 
                  <td align="left" valign="top" width="500"> 
                    <!-- 一覧 --> 
                    <asp:UpdatePanel ID="udpList2" runat="server" UpdateMode="Conditional" > 
                      <ContentTemplate> 
                        <asp:Panel ID="pnlList2" runat="server"> 
                          <table border="0" cellpadding="0" cellspacing="1"> 
                            <tr height="25"> 
                              <td align="center" width="100" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>プログラムID</b></font></td> 
                              <td align="center" width="300" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>プログラム名称</b></font></td> 
                              <td align="center" width="60" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>表示順</b></font></td> 
                            </tr> 
                          </table> 
                          <asp:Panel ID="pnlScroll2" Width="480" Height="380" ScrollBars="Vertical" runat="server"> 
                            <asp:DataGrid id="grdList2" runat="server" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="0" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ShowHeader="False" ItemStyle-height="20"> 
                              <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                              <AlternatingItemStyle backcolor="#D9FFCC"></AlternatingItemStyle> 
                              <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                              <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                              <Columns> 
                                <asp:BoundColumn DataField="PROGRAM_ID"> 
                                  <ItemStyle Width="100px" HorizontalAlign="Center" /> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="PG_NM" > 
                                  <ItemStyle Width="300px" HorizontalAlign="Left" /> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="DSP_TURN" DataFormatString="{0:##0}"> 
                                  <ItemStyle Width="60px" HorizontalAlign="Right"/> 
                                </asp:BoundColumn> 
                              </Columns> 
                              <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
                            </asp:DataGrid> 
                          </asp:Panel> 
                            <asp:ImageButton ID="btnNew2" runat="server" ImageUrl="~/image/b_new.gif" />
                            <asp:ImageButton ID="btnBack2" runat="server" ImageUrl="~/image/b_back.gif" />
                        </asp:Panel> 
                        <input type="hidden" id="Hidden1" name="txtRow" runat="server" /> 
                      </ContentTemplate> 
                    </asp:UpdatePanel> 
                    <br /> 
                    <!-- 入力 --> 
                    <asp:UpdatePanel ID="udpInput2" runat="server" UpdateMode="Conditional" > 
                      <ContentTemplate> 
                        <asp:Panel ID="pnlInput2" runat="server"> 
                          <table cellpadding="0" cellspacing="1" border="0"> 
                            <tr height="25"> 
                              <!-- プログラムID --> 
                              <td width="120" align="center" bgcolor="#4e7e4a"><b><a id="lnkProgramID" class="nav" href="#" onclick="listMDSRC230(document.getElementById('txtProgramID'),document.getElementById('lblProgramName'));document.getElementById('txtProgramID').focus();return false;" runat="server">プログラムID</a><asp:Label ID="lblProgramID" Text="プログラムID" ForeColor="#F7F7F7" runat="server" /></b></td> 
                              <td width="280" align="left" bgcolor="#d9ffcc"> 
                                <asp:TextBox ID="txtProgramID" runat="server" MaxLength="8" Width="70px" BackColor="#FFFFC0"  onChange="callBack(this);" /><br /> 
                                <asp:RequiredFieldValidator ID="valProgramID1" runat="server" ControlToValidate="txtProgramID" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="input2" EnableClientScript="False" /> 
                                <asp:RegularExpressionValidator ID="valProgramID2" runat="server" ControlToValidate="txtProgramID" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英大文字と半角数字で入力してください" ValidationExpression="^[A-Z0-9\&]+$" ValidationGroup="input2" /> 
                                <asp:CustomValidator ID="valProgramID3" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="既に登録されています" ValidationGroup="input2" ControlToValidate="txtProgramID" /> 
                              </td> 
                            </tr> 
                            <tr height="25"> 
                              <!-- プログラム名称 --> 
                              <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>プログラム名称</b></font></td> 
                              <td width="280" align="left" bgcolor="#d9ffcc"> 
                                <asp:Label ID="lblProgramName" runat="server" /> 
                              </td> 
                            </tr> 
                            <tr height="25"> 
                              <!-- 表示順 --> 
                              <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>表示順</b></font></td> 
                              <td align="left" bgcolor="#d9ffcc"> 
                                <asp:TextBox ID="txtProgramNumber" runat="server" MaxLength="3" Width="30px" style="text-align:right" /><br /> 
                                <asp:RegularExpressionValidator ID="valProgramNumber1" runat="server" ControlToValidate="txtProgramNumber" Display="Dynamic" EnableClientScript="False" ErrorMessage="数値で入力して下さい" ValidationExpression="^[0-9]+$" ValidationGroup="input2" /> 
                              </td> 
                            </tr> 
                            <tr> 
                              <td></td> 
                              <td align="left"> 
                                  <asp:ImageButton ID="btnUpdate2" runat="server" ImageUrl="~/image/b_insert.gif" />
                                  <asp:ImageButton ID="btnDelete2" runat="server" ImageUrl="~/image/b_delete.gif" />
                              </td> 
                            </tr> 
                          </table> 
                        </asp:Panel>
                        <asp:HiddenField ID="txtSaveID" runat="server" Value="" />
                        <asp:Button ID="btnSelect2" runat="server" Text="btnSelect2" style="display:none" />
                      </ContentTemplate>
                    </asp:UpdatePanel> 
                  </td> 
                </tr> 
              </table> 
            </td> 
          </tr> 
        </table> 
      </td> 
    </tr> 
  </table> 
</form> 
</body> 
</html> 
