<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas025" Codebehind="mdmas025.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!--
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow(key) 
    {        
        //document.frmList.txtSave.value = key;
        frmList.txtSave.value = key;
        //document.frmList.getElementsByName("txtSave").value = key;
        //document.frmList.btnSelect.click();
        frmList.btnSelect.click();
        //document.frmList.getElementsByName("btnSelect").click();
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
                      <!-- プログラムID --> 
                      <td align="center" width="120" bgcolor="#4E7E4A"><font color="#F7F7F7"><b>プログラムID</b></font></td> 
                      <td align="left" width="300" bgcolor="#d9ffcc"> 
                        <asp:TextBox ID="txtCode" runat="server" MaxLength="8" Width="70px" /> 
                      </td> 
                    </tr> 
                    <tr height="25"> 
                      <!-- プログラム名称 --> 
                      <td align="center" bgcolor="#4E7E4A"><font color="#F7F7F7"><b>プログラム名称</b></font></td> 
                      <td align="left" bgcolor="#d9ffcc"> 
                        <asp:TextBox ID="txtName" CssClass="full" runat="server" MaxLength="50" Width="280px" /> 
                      </td> 
                    </tr> 
                    <tr> 
                      <td></td> 
                      <td align="left"> 
                        <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />                        
                        <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_new.gif" />
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
                  <!-- 一覧 --> 
                  <td align="left" valign="top"> 
                    <asp:UpdatePanel ID="udpList" runat="server" UpdateMode="Conditional" > 
                      <ContentTemplate> 
                        <table border="0" width="100%" cellpadding="0" cellspacing="0"> 
                          <tr> 
                            <td align="right"><asp:Label ID="lblCount" runat="server" Text="Label" ForeColor="MidnightBlue"></asp:Label></td> 
                          </tr> 
                        </table> 
                        <asp:DataGrid id="grdList" runat="server" AllowPaging="True" PageSize="15" BorderWidth="0px" BorderStyle="None" BorderColor="#F7F7F7" CellPadding="0" CellSpacing="1" GridLines="Horizontal" AutoGenerateColumns="False" AllowSorting="True" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="MidnightBlue" ItemStyle-Height="20"> 
                          <HeaderStyle font-bold="True" forecolor="#F7F7F7" backcolor="#4E7E4A" horizontalalign="Center" height="25px"></HeaderStyle> 
                          <AlternatingItemStyle backcolor="#d9ffcc"></AlternatingItemStyle> 
                          <ItemStyle forecolor="#4A3C8C" backcolor="White" Wrap="True"></ItemStyle> 
                          <PagerStyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#F7F7F7" position="TopAndBottom" nextpagetext="Next" prevpagetext="Prev" mode="NumericPages"></PagerStyle> 
                          <Columns> 
                            <asp:BoundColumn  HeaderText="プログラムID" SortExpression="PROGRAM_ID" DataField="PROGRAM_ID" > 
                              <ItemStyle Width="100px" HorizontalAlign="Center" /> 
                              <HeaderStyle Width="100px" /> 
                            </asp:BoundColumn> 
                            <asp:BoundColumn HeaderText="プログラム名称" SortExpression="PG_NM" DataField="PG_NM" > 
                              <ItemStyle Width="300px" HorizontalAlign="Left" /> 
                              <HeaderStyle Width="300px" /> 
                            </asp:BoundColumn> 
                          </Columns> 
                          <FooterStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" /> 
                        </asp:DataGrid>
                        <asp:HiddenField ID="txtSave" runat="server" Value="" />
                        <asp:Button ID="btnSelect" runat="server" Text="btnSelect" style="display:none" />
                      </ContentTemplate> 
                      <Triggers> 
                        <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
                      </Triggers> 
                    </asp:UpdatePanel> 
                  </td> 
                  <td width="30"></td> 
                  <!-- 入力 --> 
                  <td width="430" align="left" valign="top"> 
                    <asp:UpdatePanel ID="udpInput" runat="server" UpdateMode="Conditional" > 
                      <ContentTemplate> 
                        <asp:Panel ID="pnlInput" runat="server"> 
                          <table cellpadding="0" cellspacing="1" border="0"> 
                            <tr height="25"> 
                              <!-- プログラムID --> 
                              <td align="center" width="120" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>プログラムID</b></font></td> 
                              <td align="left" width="300" bgcolor="#d9ffcc"> 
                                <asp:TextBox ID="txtProgramID" runat="server" MaxLength="8" Width="70px" BackColor="#FFFFC0" /><br /> 
                                <asp:RequiredFieldValidator ID="valProgramID1" runat="server" ControlToValidate="txtProgramID" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="input" EnableClientScript="False" /> 
                                <asp:RegularExpressionValidator ID="valProgramID2" runat="server" ControlToValidate="txtProgramID" Display="Dynamic" EnableClientScript="False" ErrorMessage="半角英大文字と半角数字で入力してください" ValidationExpression="^[A-Z0-9]+$" ValidationGroup="input" /> 
                                <asp:CustomValidator ID="valProgramID3" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="既に登録されています" ValidationGroup="input" ControlToValidate="txtProgramID" /> 
                              </td> 
                            </tr> 
                            <tr height="25"> 
                              <!-- プログラム名称 --> 
                              <td align="center" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>プログラム名称</b></font></td> 
                              <td align="left" bgcolor="#d9ffcc"> 
                                <asp:TextBox ID="txtProgramName" CssClass="full" runat="server" MaxLength="25" Width="280px" BackColor="#FFFFC0" /><br /> 
                                <asp:RequiredFieldValidator ID="valProgramName1" runat="server" ControlToValidate="txtProgramName" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="input" EnableClientScript="False" /> 
                                <asp:RegularExpressionValidator id="valProgramName2" runat="server" ControlToValidate="txtProgramName" Display="Dynamic" ErrorMessage="全角文字で入力して下さい" ValidationExpression="^[ 　]*[^ -~｡-ﾟ]*[ 　]*$" EnableClientScript="False" ValidationGroup="input" /> 
                              </td> 
                            </tr> 
                            <tr height="36"> 
                              <!-- ファイルパス --> 
                              <td align="center" bgcolor="#4e7e4a"><b><a class="nav" href="#" onclick="listMDSRC005(document.getElementById('txtFilePath'));document.getElementById('txtFilePath').focus();return false;">ファイルパス</a></b></td> 
                              <td align="left" bgcolor="#d9ffcc"> 
                                <asp:TextBox ID="txtFilePath" runat="server" MaxLength="50" Width="280px" BackColor="#FFFFC0" /><br /> 
                                <div><font size="1">※英数小文字、/(スラッシュ)、.(ドット)で入力して下さい</font></div> 
                                <asp:RequiredFieldValidator ID="valFilePath1" runat="server" ControlToValidate="txtFilePath" Display="Dynamic" ErrorMessage="必須入力項目です" ValidationGroup="input" EnableClientScript="False" /> 
                                <asp:RegularExpressionValidator ID="valFilePath2" runat="server" ControlToValidate="txtFilePath" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力形式が違います" ValidationExpression="^[a-z0-9\/\.]+$" ValidationGroup="input" /> 
                                <asp:CustomValidator ID="valFilePath3" runat="server" Display="Dynamic" EnableClientScript="False" ErrorMessage="ファイルが存在しません" ValidationGroup="input" ControlToValidate="txtFilePath" /> 
                              </td> 
                            </tr> 
                            <tr> 
                              <td></td> 
                              <td align="left"> 
                                <asp:ImageButton ID="btnUpdate" runat="server" ImageUrl="~/image/b_insert.gif" />                                
                                <asp:ImageButton ID="btnDelete" runat="server" ImageUrl="~/image/b_delete.gif" />                                
                                <asp:ImageButton ID="btnBack" runat="server" ImageUrl="~/image/b_back.gif" />
                              </td> 
                            </tr> 
                          </table> 
                        </asp:Panel> 
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
