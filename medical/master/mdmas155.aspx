<%@ Page Language="VB" SmartNavigation="true" AutoEventWireup="true" Inherits="medical.master_mdmas155" Codebehind="mdmas155.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
  // --></script> 
</head> 
<body onload="startClock();"> 
<form id="frmList" runat="server" enctype="multipart/form-data" method="post"> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr> 
      <td style="height: 84px;"><medical:PageHeader id="pageheader" runat="Server" /></td> 
    </tr> 
    <tr height="20"><td ></td></tr> 
    <!-- 入力フォーム --> 
    <tr> 
      <td align="center" style="height: 320px; "> 
        <table cellpadding="0" cellspacing="0" border="0"> 
          <tr> 
            <td align="center" style="height: 217px;"> 
              <table cellpadding="2" cellspacing="1" border="0" style="height: 221px"> 
                <!-- 最上位列 --> 
                <tr height="40"> 
                    <td align="center" bgcolor="#4e7e4a" style="height: 20px; width: 144px;">
                        <font color="#f7f7f7"><b>加工工程マスタ<br />取込データ</b></font>
                    </td> 
                    <td align="left" bgcolor="#D9FFCC" style="height: 20px; width: 363px;">
                        <asp:FileUpload ID="filZaiko" runat="server" BackColor="#FFFFC0" Height="19px"  Width="400" />
                        <font size="2">※入力ファイルはCSV形式（カンマ区切り）
                        <br/>
                        <asp:RequiredFieldValidator ID="valCheck01" runat="server" ControlToValidate="filZaiko" Display="Dynamic" EnableClientScript="False" ErrorMessage="ファイルを選択してください" ValidationGroup="Group1"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="valCheck02" runat="server" ControlToValidate="filZaiko" Display="Dynamic" EnableClientScript="False" ValidationGroup="Group1"></asp:CustomValidator>
                       </font>
                    </td> 
                </tr> 
                <!-- 中央列 --> 
                <tr height="20"> 
                    <td align="center" style="height: 123px;" colspan = "2" bgcolor="#d9ffcc">
                      
                        <asp:ImageButton ID="Image1" runat="server" ImageUrl="~/image/b_import.gif" OnClientClick="document.getElementById('lblCSVError').innerText = '　';document.getElementById('imgProgress').style.display = '';document.getElementById('lblCom').style.display = 'none'; " />
<%--                        <input type=image ID="Image1" runat="server" src="../image/b_import.gif" TabIndex="1" onclick="document.getElementById('imgProgress').style.display = '' "/>  --%>
                    </td> 
                </tr >
                <!--  最下位列 -->
                <tr height = "20">
                    <td align="center" style="height: 50px;" bgcolor="#d9ffcc" colspan =2 >
                        <br />
                        <img id="imgProgress" name="imgProgress" src="../image/loader.gif" runat="server" style="display:none;" />
<%--                        <asp:Image ID="Image2" runat="server" ImageAlign="Middle" ImageUrl="../image/loader.gif"  />  --%>                        
                        <br>
                        <font size ="2">
                        <asp:Label  ID="lblCom" Visible=false Text="データの取り込みが完了しました。"  runat="server" Height="25px" Width="300px" ForeColor="black" ></asp:Label>
                        <asp:Panel ID="Panel1" runat="server" width = "450px" Height="100px" HorizontalAlign="Left" Wrap="False"  ScrollBars =auto >
                            <asp:Label  ID="lblCSVError" runat="server" Height="25px" Width="300px" ForeColor="Red" ></asp:Label>
                        </asp:Panel>
                        </font><br/>
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
