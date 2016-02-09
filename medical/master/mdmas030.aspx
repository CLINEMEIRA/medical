<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas030" Codebehind="mdmas030.aspx.vb" %> 
<%@ Register Tagprefix="win" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title>ログイン</title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <style type="text/css"><!--  
    a:hover { text-decoration:none ; } 
    a { text-decoration:none ; } 
  --></style> 
  <script language="javascript" type="text/javascript"><!-- 
    function showMenu2(key1) 
    { 
        if(!checkChangeMenu()) return; 
        document.getElementById('saveKey1').innerText = key1; 
        document.getElementById('btnLink').click(); 
    } 
    function goNext(key2,program,folder) 
    { 
        document.getElementById('saveKey2').innerText = key2; 
        document.getElementById('saveProgram').innerText = program; 
        document.getElementById('saveFolder').innerText = folder; 
        document.getElementById('btnNext').click(); 
    } 
    function checkChange() { 
        var tbl = document.getElementById('tblMenu2'); 
        var flag = false; 
        for(i = 0; i < tbl.rows.length; ++i){ 
            if(flag) break; 
            for(j = 0; j < tbl.rows[i].cells.length; ++j){ 
                if(tbl.rows[i].cells[j].childNodes.length != 0){ 
                    var chk1 = tbl.rows[i].cells[j].firstChild; 
                    var chk2 = chk1.nextSibling; 
                    var chk3 = chk2.nextSibling; 
                    var pre1 = chk3.nextSibling; 
                    var pre2 = pre1.nextSibling; 
                    var pre3 = pre2.nextSibling; 
                    if(chk1.checked != pre1.value || chk2.checked != pre2.value || chk3.checked != pre3.value){ 
                        flag = true; 
                        break; 
                    } 
                } 
            } 
        } 
        return flag; 
    } 
    function checkChangeSearch(){ 
        var tbl = document.getElementById('tblMenu2'); 
        if( tbl == null) return true; 
        if(checkChange()) 
            return confirm("変更内容が登録されていません、検索してもよろしいですか"); 
        else 
            return true; 
    } 
    function checkChangeBack(){ 
        var tbl = document.getElementById('tblMenu2'); 
        if( tbl == null) return true; 
        if(checkChange()) 
            return confirm("変更内容が登録されていません、戻ってもよろしいですか"); 
        else 
            return true; 
    } 
    function checkChangeMenu(){ 
        var tbl = document.getElementById('tblMenu2'); 
        if( tbl == null) return true; 
        if(checkChange()) 
            return confirm("変更内容が登録されていません、メニューを変更してもよろしいですか"); 
        else 
            return true; 
    } 
  // --></script> 
</head> 
<body onload="startClock();" link="yellow" alink="yellow" vlink="yellow"> 
<form id="frmMenu" runat="server"> 
  <asp:ScriptManager ID="scriptManager" EnablePartialRendering="True" runat="server" /> 
  <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
    <!-- ヘッダー --> 
    <tr><td><win:PageHeader id="pageheader" runat="Server" /></td></tr> 
    <tr height="20"><td></td></tr> 
    <tr> 
      <td align="center"> 
        <!-- 選択 --> 
        <table cellpadding="0" cellspacing="0" border="0" width="950"> 
          <tr> 
            <td align="left"> 
              <asp:UpdatePanel ID="udpKey" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <table cellpadding="0" cellspacing="1" border="0"> 
                    <tr height="25"> 
                      <!-- 管理レベル --> 
                      <td align="center" width="100" bgcolor="#4e7e4a"><font color="#f7f7f7"><b>管理レベル</b></font></td> 
                      <td align="left" width="250" bgcolor="#d9ffcc"><asp:DropDownList ID="cboLevel" runat="server" /></td> 
                      <td align="left">                          
                          <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" OnClientClick="return checkChangeSearch();"/>
                      </td> 
                    </tr> 
                  </table> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
          </tr> 
        </table> 
      </td> 
    </tr> 
    <tr height="20"><td></td></tr> 
    <tr> 
      <td align="center"> 
        <table border="0" cellpadding="0" cellspacing="1"> 
          <tr> 
            <td width="250" align="left" valign="top"> 
              <!-- メニュー1 --> 
              <asp:UpdatePanel ID="udpMenu1" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <asp:Panel ID="pnlMenu1" Height="520" ScrollBars="Auto" runat="server"> 
                    <table ID="tblMenu1" border="0" cellpadding="0" cellspacing="2" runat="server"> 
                    </table> 
                    <!-- 隠し項目 -->                    
                    <asp:HiddenField ID="saveKey1" runat="server" Value="" />
                    <asp:Button ID="btnLink" runat="server" Text="btnSelect" style="display:none" />
                  </asp:Panel>
                </ContentTemplate> 
              </asp:UpdatePanel> 
            </td> 
            <td width="700" align="left" valign="top"> 
              <!-- メニュー2 --> 
              <asp:UpdatePanel ID="udpMenu2" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <asp:Panel ID="pnlMenu2" Height="520" ScrollBars="Auto" runat="server"> 
                    <table ID="tblMenu2" border="0" width="680" cellpadding="0" cellspacing="2" runat="server" atomicselection="false" enableviewstate="true"> 
                    </table> 
                    <!-- 隠し項目 --> 
                    <input type="hidden" id="saveKey2"    runat="server" /> 
                    <input type="hidden" id="saveProgram" runat="server" /> 
                    <input type="hidden" id="saveFolder"  runat="server" /> 
                    <input type="button" id="btnNext" runat="server" onserverclick="btnNext_ServerClick" style="display:none" /> 
                  </asp:Panel> 
                </ContentTemplate> 
              </asp:UpdatePanel> 
              <asp:UpdatePanel ID="udpFunc" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                  <asp:Panel ID="pnlFunc" runat="server"> 
                    <table border="0" cellpadding="0" cellspacing="1" width="680"> 
                      <tr> 
                        <td align="left"> 
                          ※権限は登録、訂正、削除の順です<br /> 
                          ※プログラムによっては機能しない場合があります 
                        </td> 
                        <td align="right">                          
                            <asp:ImageButton ID="btnInsert" runat="server" ImageUrl="~/image/b_insert.gif" />
                            <asp:ImageButton ID="btnBack" runat="server" ImageUrl="~/image/b_back.gif" OnClientClick="return checkChangeBack();" />
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
</form> 
</body> 
</html> 
