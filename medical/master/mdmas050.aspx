<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas050" Codebehind="mdmas050.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 

<!DOCTYPE html> 

<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script language="JavaScript" src="../include/medical.js"><!-- 
  // --></script> 
  <script type="text/javascript"><!-- 
    function selectGridRow1(teifu,day,kiji,sakuCode,sakuName,shouCode,shouName){ 
        document.getElementById('saveTeifu1').value = teifu 
        document.getElementById('txtTeifu1').value = teifu 
        document.getElementById('txtDay1').value = day 
        document.getElementById('txtTNo1').value = kiji 
        document.getElementById('txtSakusei1').value = sakuCode 
        if (sakuName == "&nbsp;") {
            document.getElementById('lbltxtSakusei1').innerText = "" 
        } else {
            document.getElementById('lbltxtSakusei1').innerText = sakuName 
        }
        document.getElementById('txtShounin1').value = shouCode 
        if (shouName == "&nbsp;") {
            document.getElementById('lbltxtShounin1').innerText = "" 
        } else {
            document.getElementById('lbltxtShounin1').innerText = shouName 
        }
    } 
    
    function selectRow(row,color)
    { 
        var table = document.getElementById('grdList1');
        if(document.frmList.txtPinkRow.value != row){
            table.rows[row].style.backgroundColor = "#FFC0C0";
            if ((document.frmList.txtPinkRow.value % 2) == 1) {
                table.rows[document.frmList.txtPinkRow.value].style.backgroundColor = "#D9FFCC";
            } else {
                table.rows[document.frmList.txtPinkRow.value].style.backgroundColor = "#FFFFFF";
            }
            document.frmList.txtPinkRow.value = row;
        }
    }
    function changeColor(row,color)
    {
        if(document.frmList.txtPinkRow.value != row){
            var table = document.getElementById('grdList1');
            table.rows[row].style.backgroundColor = color;
        } else {
            var table = document.getElementById('grdList1');
            table.rows[row].style.backgroundColor = "#FFC0C0";
        }
    }
     
    function SelectAllCheckboxes(chkB) { 
      elem=chkB.form.elements; 
      for(i=0;i<elem.length;i++) { 
        if(elem[i].type=='checkbox' && elem[i].id!=chkB.id) { 
          if(elem[i].checked!=chkB.checked) 
            elem[i].click(); 
        } 
      } 
    } 
    function getName(mode,control) { 
      var command = control.value; 
      var context = new Object(); 
      context.CommandName = "getName" + mode; 
      <%= _sCallBackScript %> 
    } 
             
    function getNameCallBack(result, context) { 
      var indexofComma = result.indexOf(","); 
      switch (context.CommandName){ 
        case "getName1": 
          document.getElementById('txtSakusei1').value = result.substring(0,indexofComma); 
          document.getElementById('lbltxtSakusei1').innerText = result.substring(indexofComma+1, result.length); 
          break; 
        case "getName2": 
          document.getElementById('txtShounin1').value = result.substring(0,indexofComma); 
          document.getElementById('lbltxtShounin1').innerText = result.substring(indexofComma+1, result.length); 
          break; 
           
        case "getName3": 
          document.getElementById('txtSakusei2').value = result.substring(0,indexofComma); 
          document.getElementById('lbltxtSakusei2').innerText = result.substring(indexofComma+1, result.length); 
          break; 
        case "getName4": 
          document.getElementById('txtShounin2').value = result.substring(0,indexofComma); 
          document.getElementById('lbltxtShounin2').innerText = result.substring(indexofComma+1, result.length); 
          break; 
      } 
    } 
       
    function getNameCallBackError(result, context) { 
    }   
  // --></script> 
    <style type="text/css"><!--  
    div#scroll1{  
        position:absolute;  
        width:100%;  
        height:250px;  
        background:#F7F7F7;  
        overflow-y:auto; 
    }  
    div#scroll2{  
        position:absolute;  
        width:100%;  
        height:100%;  
        background:#F7F7F7;  
        overflow-y:auto; 
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
    <tr> 
      <td align =center> 
        <table border="0" cellpadding="0" cellspacing="0" > 
          <tr> 
            <td> 
              <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional"> 
                <ContentTemplate> 
                <table border="0" cellpadding="0" cellspacing="0" > 
                  <tr> 
                    <td> 
                      <table cellspacing="1" cellpadding="2" border="0"> 
                        <tr> 
                          <td bgcolor="#D9FFCC" colspan="4" style="height: 30px"> 
                            <asp:RadioButton ID="rbtnSinki" runat="server" Checked="True" Text="新規改訂" GroupName="Group1" AutoPostBack="True" OnCheckedChanged="rbtnSinki_CheckedChanged" /> 
                              &nbsp;&nbsp; 
                            <asp:RadioButton ID="rbtnSakujo" runat="server" Text="最新削除" GroupName="Group1" AutoPostBack="True" OnCheckedChanged="rbtnSakujo_CheckedChanged" /> 
                              &nbsp;&nbsp; 
                            <asp:RadioButton ID="rbtnHenkou" runat="server" Text="変更" GroupName="Group1" AutoPostBack="True" OnCheckedChanged="rbtnHenkou_CheckedChanged" /> 
                          </td> 
                        </tr> 
                        <tr> 
                          <td bgcolor="#D9FFCC" colspan="2" style="height: 30px"> 
                            <asp:RadioButton ID="rbtnKoutei" runat="server" text="工程票" GroupName="Group2" AutoPostBack="True" OnCheckedChanged="Catalog_CheckedChanged" Checked="True" /> 
                            <asp:RadioButton ID="rbtnHyoujun" runat="server" text="製品標準書" GroupName="Group2" AutoPostBack="True" OnCheckedChanged="Catalog_CheckedChanged"/> 
                            </td> 
                            <td bgcolor="#D9FFCC" colspan="2" style="height: 30px"> 
                            <asp:RadioButton ID="rbtnKakouzu" runat="server" text="加工図" GroupName="Group2" AutoPostBack="True" OnCheckedChanged="Seikan_CheckedChanged"/> 
                            <asp:RadioButton ID="rbtnZumen" runat="server" text="製品図面" GroupName="Group2" AutoPostBack="True" OnCheckedChanged="Seikan_CheckedChanged"/> 
                            <asp:RadioButton ID="rbtnSiken" runat="server" text="試験・検査票" GroupName="Group2" AutoPostBack="True" OnCheckedChanged="Seikan_CheckedChanged"/> 
                          </td> 
                        </tr> 
                        <tr> 
                          <td bgcolor="#4e7e4a" height="25" width="100" align="center"> 
                            <asp:Label ID="lblHedCatalog1" runat="server" Font-Bold="True" Text="カタログ番号" ForeColor="White" Visible="False"></asp:Label> 
                            <a class="nav" href="#" onclick="listMDSRC011(document.getElementById('txtCatalog'),'');document.getElementById('txtCatalog').focus();return false;"> 
                              <asp:Label ID="lblHedCatalog2" runat="server" Font-Bold="True" Text="カタログ番号"></asp:Label> 
                            </a> 
                          </td> 
                          <td bgcolor="#D9FFCC" height="25" width="220" align="left"> 
                            <asp:TextBox ID="txtCatalog" runat="server" MaxLength="20" Width="200px" BackColor="#FFFFC0"></asp:TextBox><br /> 
                            <asp:RequiredFieldValidator ID="valCatalog1" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="top1"></asp:RequiredFieldValidator> 
                            <asp:CustomValidator ID="valCatalog2" runat="server" ControlToValidate="txtCatalog" Display="Dynamic" EnableClientScript="False" ErrorMessage="部品マスタに未登録です" ValidationGroup="top1"></asp:CustomValidator>
                          </td> 
                          <td bgcolor="#4e7e4a" height="25" width="100" align="center"> 
                            <asp:Label ID="lblHedSeikan1" runat="server" Font-Bold="True" Text="図面管理番号" ForeColor="White"></asp:Label> 
                            <a class="nav" href="#" onclick="listMDSRC011('',document.getElementById('txtSeikan'));document.getElementById('txtSeikan').focus();return false;"> 
                              <asp:Label ID="lblHedSeikan2" runat="server" Font-Bold="True" Text="図面管理番号" Visible="False"></asp:Label> 
                            </a> 
                          </td> 
                          <td bgcolor="#D9FFCC" height="25" width="280" align="left"> 
                            <asp:TextBox ID="txtSeikan" runat="server" MaxLength="15" Width="150px" Enabled="False" BackColor="#E0E0E0"></asp:TextBox><br /> 
                            <asp:RequiredFieldValidator ID="valSeikan1" runat="server" ControlToValidate="txtSeikan" Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="top2"></asp:RequiredFieldValidator> 
                            <asp:RegularExpressionValidator ID="valSeikan2" runat="server" ControlToValidate="txtSeikan" Display="Dynamic" EnableClientScript="False" ErrorMessage="XXXX-XXXX-XX-XXの形式で入力して下さい" ValidationExpression="^\w{4}\-\w{4}\-\w{2}\-\w{2}$" ValidationGroup="top2"></asp:RegularExpressionValidator> 
                            <asp:CustomValidator ID="valSeikan3" runat="server" ControlToValidate="txtSeikan" Display="Dynamic" EnableClientScript="False" ErrorMessage="部品マスタに未登録です" ValidationGroup="top2"></asp:CustomValidator>
                          </td> 
                        </tr> 
                        <tr> 
                          <td colspan="2"> 
                            <INPUT type="hidden" id="txtPinkRow" name="txtPinkRow" runat="server" >
                            <INPUT type="hidden" id="txtMotoPinkRow" name="txtPinkRow" runat="server" >
                          </td> 
                          <td align="center" colspan="2"> 
                            <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                          </td> 
                        </tr> 
                      </table> 
                    </td> 
                  </tr> 
                  <tr> 
                    <td style="height: 15px" align="left"> 
                        &nbsp;<div align=right> 
                        <asp:Label ID="lblZero" runat="server" Visible="False">該当データがありません</asp:Label> 
                      </div> 
                    </td> 
                  </tr> 
                  <tr> 
                    <td> 
                      <asp:Panel ID="pnlMiddle1" runat="server" visible=false>       
                        <table BorderColor="#f7f7f7" CellPadding="2" CellSpacing="1"> 
                          <tr> 
                            <td width=100 align=center style="font-weight: bold; color: white; height: 25px; background-color: #4e7e4a" bgcolor="#f7f7f7"> 
                              訂符 
                            </td> 
                            <td width=150 align=center style="font-weight: bold; color: white; height: 25px; background-color: #4e7e4a" bgcolor="#f7f7f7"> 
                              適用日付 
                            </td> 
                            <td width=200 align=center style="font-weight: bold; color: white; height: 25px; background-color: #4e7e4a" bgcolor="#f7f7f7"> 
                              訂正記事番号 
                            </td> 
                            <td width=200 align=center style="font-weight: bold; color: white; height: 25px; background-color: #4e7e4a" bgcolor="#f7f7f7"> 
                              作成者 
                            </td> 
                            <td width=200 align=center style="font-weight: bold; color: white; height: 25px; background-color: #4e7e4a" bgcolor="#f7f7f7"> 
                              承認者 
                            </td> 
                            <td style="width: 4px"> 
                            </td> 
                          </tr> 
                        </table> 
                        <div align=left> 
                          <div id="scroll1" align=left style="height: 301px;"> 
                            <asp:DataGrid id="grdList1" runat="server" AutoGenerateColumns="False" GridLines="Horizontal" BorderColor="#F7F7F7" BorderStyle="None" BorderWidth="0px" CellPadding="2" CellSpacing="1" ForeColor="MidnightBlue" ShowHeader="False" Width=876 > 
                              <AlternatingItemStyle BackColor="#D9FFCC" /> 
                              <ItemStyle BackColor="White" ForeColor="#4A3C8C" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Left" /> 
                              <HeaderStyle BackColor="#4E7E4A" Font-Bold="True" Font-Underline="False" ForeColor="#F7F7F7" Height="25px" HorizontalAlign="Center" /> 
                              <Columns> 
                                <asp:BoundColumn DataField="COR_MARK" HeaderText="訂符"> 
                                  <ItemStyle width=100px Height=25px HorizontalAlign="Center" /> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="APPLY_DT" Visible=False> 
                                </asp:BoundColumn> 
                                <asp:TemplateColumn HeaderText="適用日付"> 
                                  <ItemStyle width=150px HorizontalAlign="Center" /> 
                                  <ItemTemplate> 
                                    <asp:Label ID="Label1" runat="server" Text='<%# medical.MedicalLib.Common.DateFormat(DataBinder.Eval(Container, "DataItem.APPLY_DT")) %>'></asp:Label>                                      
                                  </ItemTemplate> 
                                </asp:TemplateColumn> 
                                <asp:BoundColumn DataField="COR_ARTICLE_NO" HeaderText="訂正記事番号"> 
                                  <ItemStyle width=200px HorizontalAlign="Left" /> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="CREATOR" HeaderText="作成者"> 
                                  <ItemStyle width=200px HorizontalAlign="Left" /> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="CREATORコード" Visible=False> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="CREATOR_NM" Visible=False> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="RECOGNIZER" HeaderText="承認者"> 
                                  <ItemStyle width=200px HorizontalAlign="Left" /> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="RECOGNIZERコード" Visible=False> 
                                </asp:BoundColumn> 
                                <asp:BoundColumn DataField="RECOGNIZER_NM" Visible=False> 
                                </asp:BoundColumn> 
                              </Columns> 
                                <SelectedItemStyle BackColor="#FFC0C0" /> 
                  　        </asp:DataGrid>
                  　      </div> 
                  　    </div> 
                      </asp:Panel> 
                    </td> 
                  </tr> 
                  <tr> 
                    <td style="height: 301px"></td> 
                  </tr> 
                  <tr> 
                    <td align="right"> 
                        &nbsp; 
                    </td> 
                  </tr> 
                  <tr> 
                    <td style="height: 5px"> 
                    </td> 
                  </tr> 
                  <tr> 
                    <td> 
                      <asp:Panel ID="pnlBottom1" runat="server" visible=false> 
                        <table cellspacing="1" cellpadding="2" border="0"> 
                          <tr> 
                            <td bgcolor="#4e7e4a" style="width: 123px;" height="25"> 
                              <font color="#ffffff"><b>訂符</b></font> 
                            </td> 
                            <td bgcolor="#4e7e4a" style="width: 150px;" height="25"> 
                              <asp:Label ID="lblHedDay11" runat="server" Font-Bold="True" Text="適用日付" ForeColor="White"></asp:Label> 
                              <a class="nav"  href="#" onclick="listMDSRC000(document.getElementById('txtday1'));document.getElementById('txtDay1').focus();return false;"> 
                                <asp:Label ID="lblHedDay12" runat="server" Font-Bold="True" Text="適用日付"></asp:Label> 
                              </a> 
                            </td> 
                            <td bgcolor="#4e7e4a" style="width: 120px;" height="25"> 
                              <font color="#ffffff"><b>訂正記事番号</b></font> 
                            </td> 
                            <td bgcolor="#4e7e4a" style="width: 170px;" height="25"> 
                              <asp:Label ID="lblHedSakusei11" runat="server" Font-Bold="True" Text="作成者" ForeColor="White"></asp:Label> 
                              <a class="nav"  href="#" onclick="listMDSRC030(document.getElementById('txtSakusei1'),'',document.getElementById('lblSakusei1'));document.getElementById('txtSakusei1').focus();return false"> 
                                <asp:Label ID="lblHedSakusei12" runat="server" Font-Bold="True" Text="作成者"></asp:Label> 
                              </a> 
                            </td> 
                            <td bgcolor="#4e7e4a" style="width: 170px;" height="25"> 
                              <asp:Label ID="lblHedShounin11" runat="server" Font-Bold="True" Text="承認者" ForeColor="White"></asp:Label> 
                              <a class="nav"  href="#" onclick="listMDSRC030(document.getElementById('txtShounin1'),'',document.getElementById('lblShounin1'));document.getElementById('txtShounin1').focus();return false"> 
                                <asp:Label ID="lblHedShounin12" runat="server" Font-Bold="True" Text="承認者"></asp:Label> 
                              </a> 
                            </td> 
                          </tr> 
                          <tr> 
                            <td bgcolor="#D9FFCC" style="height: 40px; width: 120px;"> 
                              <asp:TextBox ID="txtTeifu1" runat="server" MaxLength="3" Width="30px" BackColor="#FFFFC0"></asp:TextBox><br /> 
                              <asp:RequiredFieldValidator ID="valTeifu11" runat="server" ControlToValidate="txtTeifu1" 
                                  Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="bottom1"></asp:RequiredFieldValidator> 
                              <asp:RegularExpressionValidator ID="valTeifu12" runat="server" ControlToValidate="txtTeifu1" 
                                Display="Dynamic" EnableClientScript="False" ErrorMessage='半角英数字か"-"で<br>入力してください' 
                                ValidationExpression="^[ \-0-9a-zA-Z]*$" ValidationGroup="bottom1"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valTeifu13" runat="server" 
                                Display="Dynamic" EnableClientScript="False" ErrorMessage="訂符が登録済です" 
                                ValidationGroup="bottom1"></asp:CustomValidator> 
                            </td> 
                            <td bgcolor="#D9FFCC" style="height: 40px; width: 150px;"> 
                              <asp:TextBox ID="txtDay1" runat="server" Width="80px" BackColor="#FFFFC0" MaxLength="8"></asp:TextBox><br /> 
                              <asp:RequiredFieldValidator ID="valDay11" runat="server" ControlToValidate="txtDay1" 
                                Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="bottom1"></asp:RequiredFieldValidator> 
                              <asp:RegularExpressionValidator ID="valDay12" runat="server" ControlToValidate="txtDay1" 
                                Display="Dynamic" EnableClientScript="False" ErrorMessage="日付で入力して下さい" Font-Size="10pt" 
                                ValidationExpression="^(?:\d{4}(?:(?:0[1-9]|1[0-2])(?:0[1-9]|1[0-9]|2[0-8])|(?:0[13-9]|1[0-2])(?:29|30)|(?:0[13578]|1[02])31)|(?:\d{2}(?:0[48]|[2468][048]|[13579][26])|(?:[02468][048]|[13579][26])00)0229)$" ValidationGroup="bottom1"></asp:RegularExpressionValidator> 
                              <asp:CustomValidator ID="valDay13" runat="server" ControlToValidate="txtDay1" Display="Dynamic" 
                                EnableClientScript="False" ErrorMessage="最新の適用日付を<br>入力してください" ValidationGroup="bottom1"></asp:CustomValidator> 
                                <asp:CustomValidator ID="valDay14" runat="server" ControlToValidate="txtDay1" Display="Dynamic" 
                                    EnableClientScript="False" ErrorMessage="日付の大小関係が<br>正しくありません" 
                                    ValidationGroup="bottom1"></asp:CustomValidator> 
                            </td> 
                            <td bgcolor="#D9FFCC" style="height: 40px; width: 120px;"> 
                              <asp:TextBox ID="txtTNo1" runat="server" MaxLength="7" Width="70px" BackColor="#FFFFC0"></asp:TextBox><br /> 
                              <asp:RequiredFieldValidator ID="valTNo11" runat="server" ControlToValidate="txtTNo1" 
                                Display="Dynamic" EnableClientScript="False" ErrorMessage="入力必須項目です" ValidationGroup="bottom1"></asp:RequiredFieldValidator> 
                              <asp:RegularExpressionValidator 
                                ID="valTNo12" runat="server" ControlToValidate="txtTNo1" Display="Dynamic" EnableClientScript="False" 
                                ErrorMessage="半角文字で入力<br />してください" ValidationExpression="^[ -~｡-ﾟ]*$" ValidationGroup="bottom1"></asp:RegularExpressionValidator> 
                            </td> 
                            <td bgcolor="#D9FFCC" style="height: 40px; width: 170px;" align="left"> 
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtSakusei1" runat="server" Width="50px" MaxLength="4" BackColor="#FFFFC0" onChange="getName('1',document.forms[0].elements['txtSakusei1'])"></asp:TextBox>&nbsp; 
                              <asp:Label ID="lbltxtSakusei1" runat="server"></asp:Label><br /> 
                              <asp:CustomValidator ID="valSakusei1" runat="server" ControlToValidate="txtSakusei1" 
                                Display="Dynamic" EnableClientScript="False" ValidationGroup="bottom1" ValidateEmptyText="True"></asp:CustomValidator></td> 
                            <td bgcolor="#D9FFCC" style="height: 40px; width: 170px;" align="left"> 
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtShounin1" runat="server" Width="50px" MaxLength="4" BackColor="#FFFFC0" onChange="getName('2',document.forms[0].elements['txtShounin1'])"></asp:TextBox>&nbsp; 
                              <asp:Label ID="lbltxtShounin1" runat="server"></asp:Label><br /> 
                              <asp:CustomValidator ID="valShounin1" runat="server" ControlToValidate="txtShounin1" 
                                Display="Dynamic" EnableClientScript="False" ValidationGroup="bottom1" ValidateEmptyText="True"></asp:CustomValidator>
                            </td> 
                          </tr> 
                          <tr> 
                            <td colspan=3 style="height: 22px"> 
                              <!-- 隠し項目 --> 
                              <input type="hidden" id="saveTeifu1"  runat="server" /> 
                            </td> 
                            <td colspan=2 style="height: 22px"> 
                                <asp:ImageButton ID="cmdRun1" runat="server" ImageUrl="~/image/b_insert.gif" />
                                <asp:ImageButton ID="cmdClear1" runat="server" ImageUrl="~/image/b_clear.gif" />
                                <asp:ImageButton ID="cmdBack1" runat="server" ImageUrl="~/image/b_back.gif" />
                            </td> 
                          </tr> 
                        </table> 
                      </asp:Panel> 
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
  </table> 
</form> 
</body> 
</html> 
