<%@ Page Language="VB" AutoEventWireup="true" Inherits="medical.master_mdmas130" Codebehind="mdmas130.aspx.vb" %> 
<%@ Register Tagprefix="medical" Tagname="PageHeader" Src="../include/header.ascx" %> 
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <link href="../include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="../include/medical.js"><!-- 
  // --></script> 
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
        <table cellpadding="0" width=100% cellspacing="0" border="0"> 
          <tr> 
            <td align="left"> 
            <!-- 選択 --> 
              <table cellpadding="0" cellspacing="0" border="0" height=40> 
                <tr align=center> 
                  <td width=40></td> 
                  <td width=200 bgcolor="#d9ffcc"> 
                    <asp:DropDownList ID="ddlNendo" runat="server" BackColor="#FFFFC0"> 
                    </asp:DropDownList> 
                    &nbsp;年度 
                  </td> 
                  <td width=80 bgcolor="#d9ffcc"> 
                    <asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/image/b_search.gif" />
                  </td> 
                  <td width=250 bgcolor="#d9ffcc"> 
                      (休日をチェックしてください。) 
                  </td> 
                </tr> 
              </table> 
            </td> 
          </tr> 
          <tr height=20><td></td></tr> 
          <tr> 
            <td> 
              <!-- 一覧 --> 
              <asp:UpdatePanel ID="udpTree" runat="server"> 
                   <ContentTemplate> 
                      <asp:Panel ID="Panel1" runat="server" Visible="false"> 
                        <table cellpadding="2" cellspacing="1" border="0"> 
                        <tr bgcolor="#4e7e4a" style="color:white" height=25> 
                          <th></th> 
                          <th>1</th><th>2</th><th>3</th><th>4</th><th>5</th> 
                          <th>6</th><th>7</th><th>8</th><th>9</th><th>10</th> 
                          <th>11</th><th>12</th><th>13</th><th>14</th><th>15</th> 
                          <th>16</th><th>17</th><th>18</th><th>19</th><th>20</th> 
                          <th>21</th><th>22</th><th>23</th><th>24</th><th>25</th> 
                          <th>26</th><th>27</th><th>28</th><th>29</th><th>30</th> 
                          <th>31</th> 
                        </tr> 
                        <tr bgcolor="#ffffff" height="30"> 
                          <td><asp:Label ID="lbl04" runat="server"></asp:Label>／04</td> 
                          <td width=25><asp:CheckBox ID="chk0401" runat="server" /></td><td width=25><asp:CheckBox ID="chk0402" runat="server" /></td><td width=25><asp:CheckBox ID="chk0403" runat="server" /></td><td width=25><asp:CheckBox ID="chk0404" runat="server" /></td><td width=25><asp:CheckBox ID="chk0405" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0406" runat="server" /></td><td width=25><asp:CheckBox ID="chk0407" runat="server" /></td><td width=25><asp:CheckBox ID="chk0408" runat="server" /></td><td width=25><asp:CheckBox ID="chk0409" runat="server" /></td><td width=25><asp:CheckBox ID="chk0410" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0411" runat="server" /></td><td width=25><asp:CheckBox ID="chk0412" runat="server" /></td><td width=25><asp:CheckBox ID="chk0413" runat="server" /></td><td width=25><asp:CheckBox ID="chk0414" runat="server" /></td><td width=25><asp:CheckBox ID="chk0415" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0416" runat="server" /></td><td width=25><asp:CheckBox ID="chk0417" runat="server" /></td><td width=25><asp:CheckBox ID="chk0418" runat="server" /></td><td width=25><asp:CheckBox ID="chk0419" runat="server" /></td><td width=25><asp:CheckBox ID="chk0420" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0421" runat="server" /></td><td width=25><asp:CheckBox ID="chk0422" runat="server" /></td><td width=25><asp:CheckBox ID="chk0423" runat="server" /></td><td width=25><asp:CheckBox ID="chk0424" runat="server" /></td><td width=25><asp:CheckBox ID="chk0425" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0426" runat="server" /></td><td width=25><asp:CheckBox ID="chk0427" runat="server" /></td><td width=25><asp:CheckBox ID="chk0428" runat="server" /></td><td width=25><asp:CheckBox ID="chk0429" runat="server" /></td><td width=25><asp:CheckBox ID="chk0430" runat="server" /></td> 
                          <td width=25></td> 
                        </tr> 
                        <tr bgcolor="#D9FFCC" height="30"> 
                          <td align="right">05</td> 
                          <td width=25><asp:CheckBox ID="chk0501" runat="server" /></td><td width=25><asp:CheckBox ID="chk0502" runat="server" /></td><td width=25><asp:CheckBox ID="chk0503" runat="server" /></td><td width=25><asp:CheckBox ID="chk0504" runat="server" /></td><td width=25><asp:CheckBox ID="chk0505" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0506" runat="server" /></td><td width=25><asp:CheckBox ID="chk0507" runat="server" /></td><td width=25><asp:CheckBox ID="chk0508" runat="server" /></td><td width=25><asp:CheckBox ID="chk0509" runat="server" /></td><td width=25><asp:CheckBox ID="chk0510" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0511" runat="server" /></td><td width=25><asp:CheckBox ID="chk0512" runat="server" /></td><td width=25><asp:CheckBox ID="chk0513" runat="server" /></td><td width=25><asp:CheckBox ID="chk0514" runat="server" /></td><td width=25><asp:CheckBox ID="chk0515" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0516" runat="server" /></td><td width=25><asp:CheckBox ID="chk0517" runat="server" /></td><td width=25><asp:CheckBox ID="chk0518" runat="server" /></td><td width=25><asp:CheckBox ID="chk0519" runat="server" /></td><td width=25><asp:CheckBox ID="chk0520" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0521" runat="server" /></td><td width=25><asp:CheckBox ID="chk0522" runat="server" /></td><td width=25><asp:CheckBox ID="chk0523" runat="server" /></td><td width=25><asp:CheckBox ID="chk0524" runat="server" /></td><td width=25><asp:CheckBox ID="chk0525" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0526" runat="server" /></td><td width=25><asp:CheckBox ID="chk0527" runat="server" /></td><td width=25><asp:CheckBox ID="chk0528" runat="server" /></td><td width=25><asp:CheckBox ID="chk0529" runat="server" /></td><td width=25><asp:CheckBox ID="chk0530" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0531" runat="server" /></td> 
                        </tr> 
                        <tr bgcolor="#ffffff" height="30"> 
                          <td align="right">06</td> 
                          <td width=25><asp:CheckBox ID="chk0601" runat="server" /></td><td width=25><asp:CheckBox ID="chk0602" runat="server" /></td><td width=25><asp:CheckBox ID="chk0603" runat="server" /></td><td width=25><asp:CheckBox ID="chk0604" runat="server" /></td><td width=25><asp:CheckBox ID="chk0605" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0606" runat="server" /></td><td width=25><asp:CheckBox ID="chk0607" runat="server" /></td><td width=25><asp:CheckBox ID="chk0608" runat="server" /></td><td width=25><asp:CheckBox ID="chk0609" runat="server" /></td><td width=25><asp:CheckBox ID="chk0610" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0611" runat="server" /></td><td width=25><asp:CheckBox ID="chk0612" runat="server" /></td><td width=25><asp:CheckBox ID="chk0613" runat="server" /></td><td width=25><asp:CheckBox ID="chk0614" runat="server" /></td><td width=25><asp:CheckBox ID="chk0615" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0616" runat="server" /></td><td width=25><asp:CheckBox ID="chk0617" runat="server" /></td><td width=25><asp:CheckBox ID="chk0618" runat="server" /></td><td width=25><asp:CheckBox ID="chk0619" runat="server" /></td><td width=25><asp:CheckBox ID="chk0620" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0621" runat="server" /></td><td width=25><asp:CheckBox ID="chk0622" runat="server" /></td><td width=25><asp:CheckBox ID="chk0623" runat="server" /></td><td width=25><asp:CheckBox ID="chk0624" runat="server" /></td><td width=25><asp:CheckBox ID="chk0625" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0626" runat="server" /></td><td width=25><asp:CheckBox ID="chk0627" runat="server" /></td><td width=25><asp:CheckBox ID="chk0628" runat="server" /></td><td width=25><asp:CheckBox ID="chk0629" runat="server" /></td><td width=25><asp:CheckBox ID="chk0630" runat="server" /></td> 
                          <td width=25></td> 
                        </tr> 
                        <tr bgcolor="#D9FFCC" height="30"> 
                          <td align="right">07</td> 
                          <td width=25><asp:CheckBox ID="chk0701" runat="server" /></td><td width=25><asp:CheckBox ID="chk0702" runat="server" /></td><td width=25><asp:CheckBox ID="chk0703" runat="server" /></td><td width=25><asp:CheckBox ID="chk0704" runat="server" /></td><td width=25><asp:CheckBox ID="chk0705" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0706" runat="server" /></td><td width=25><asp:CheckBox ID="chk0707" runat="server" /></td><td width=25><asp:CheckBox ID="chk0708" runat="server" /></td><td width=25><asp:CheckBox ID="chk0709" runat="server" /></td><td width=25><asp:CheckBox ID="chk0710" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0711" runat="server" /></td><td width=25><asp:CheckBox ID="chk0712" runat="server" /></td><td width=25><asp:CheckBox ID="chk0713" runat="server" /></td><td width=25><asp:CheckBox ID="chk0714" runat="server" /></td><td width=25><asp:CheckBox ID="chk0715" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0716" runat="server" /></td><td width=25><asp:CheckBox ID="chk0717" runat="server" /></td><td width=25><asp:CheckBox ID="chk0718" runat="server" /></td><td width=25><asp:CheckBox ID="chk0719" runat="server" /></td><td width=25><asp:CheckBox ID="chk0720" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0721" runat="server" /></td><td width=25><asp:CheckBox ID="chk0722" runat="server" /></td><td width=25><asp:CheckBox ID="chk0723" runat="server" /></td><td width=25><asp:CheckBox ID="chk0724" runat="server" /></td><td width=25><asp:CheckBox ID="chk0725" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0726" runat="server" /></td><td width=25><asp:CheckBox ID="chk0727" runat="server" /></td><td width=25><asp:CheckBox ID="chk0728" runat="server" /></td><td width=25><asp:CheckBox ID="chk0729" runat="server" /></td><td width=25><asp:CheckBox ID="chk0730" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0731" runat="server" /></td> 
                        </tr> 
                        <tr bgcolor="#ffffff" height="30"> 
                          <td align="right">08</td> 
                          <td width=25><asp:CheckBox ID="chk0801" runat="server" /></td><td width=25><asp:CheckBox ID="chk0802" runat="server" /></td><td width=25><asp:CheckBox ID="chk0803" runat="server" /></td><td width=25><asp:CheckBox ID="chk0804" runat="server" /></td><td width=25><asp:CheckBox ID="chk0805" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0806" runat="server" /></td><td width=25><asp:CheckBox ID="chk0807" runat="server" /></td><td width=25><asp:CheckBox ID="chk0808" runat="server" /></td><td width=25><asp:CheckBox ID="chk0809" runat="server" /></td><td width=25><asp:CheckBox ID="chk0810" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0811" runat="server" /></td><td width=25><asp:CheckBox ID="chk0812" runat="server" /></td><td width=25><asp:CheckBox ID="chk0813" runat="server" /></td><td width=25><asp:CheckBox ID="chk0814" runat="server" /></td><td width=25><asp:CheckBox ID="chk0815" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0816" runat="server" /></td><td width=25><asp:CheckBox ID="chk0817" runat="server" /></td><td width=25><asp:CheckBox ID="chk0818" runat="server" /></td><td width=25><asp:CheckBox ID="chk0819" runat="server" /></td><td width=25><asp:CheckBox ID="chk0820" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0821" runat="server" /></td><td width=25><asp:CheckBox ID="chk0822" runat="server" /></td><td width=25><asp:CheckBox ID="chk0823" runat="server" /></td><td width=25><asp:CheckBox ID="chk0824" runat="server" /></td><td width=25><asp:CheckBox ID="chk0825" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0826" runat="server" /></td><td width=25><asp:CheckBox ID="chk0827" runat="server" /></td><td width=25><asp:CheckBox ID="chk0828" runat="server" /></td><td width=25><asp:CheckBox ID="chk0829" runat="server" /></td><td width=25><asp:CheckBox ID="chk0830" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0831" runat="server" /></td> 
                        </tr> 
                        <tr bgcolor="#D9FFCC" height="30"> 
                          <td align="right">09</td> 
                          <td width=25><asp:CheckBox ID="chk0901" runat="server" /></td><td width=25><asp:CheckBox ID="chk0902" runat="server" /></td><td width=25><asp:CheckBox ID="chk0903" runat="server" /></td><td width=25><asp:CheckBox ID="chk0904" runat="server" /></td><td width=25><asp:CheckBox ID="chk0905" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0906" runat="server" /></td><td width=25><asp:CheckBox ID="chk0907" runat="server" /></td><td width=25><asp:CheckBox ID="chk0908" runat="server" /></td><td width=25><asp:CheckBox ID="chk0909" runat="server" /></td><td width=25><asp:CheckBox ID="chk0910" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0911" runat="server" /></td><td width=25><asp:CheckBox ID="chk0912" runat="server" /></td><td width=25><asp:CheckBox ID="chk0913" runat="server" /></td><td width=25><asp:CheckBox ID="chk0914" runat="server" /></td><td width=25><asp:CheckBox ID="chk0915" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0916" runat="server" /></td><td width=25><asp:CheckBox ID="chk0917" runat="server" /></td><td width=25><asp:CheckBox ID="chk0918" runat="server" /></td><td width=25><asp:CheckBox ID="chk0919" runat="server" /></td><td width=25><asp:CheckBox ID="chk0920" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0921" runat="server" /></td><td width=25><asp:CheckBox ID="chk0922" runat="server" /></td><td width=25><asp:CheckBox ID="chk0923" runat="server" /></td><td width=25><asp:CheckBox ID="chk0924" runat="server" /></td><td width=25><asp:CheckBox ID="chk0925" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0926" runat="server" /></td><td width=25><asp:CheckBox ID="chk0927" runat="server" /></td><td width=25><asp:CheckBox ID="chk0928" runat="server" /></td><td width=25><asp:CheckBox ID="chk0929" runat="server" /></td><td width=25><asp:CheckBox ID="chk0930" runat="server" /></td> 
                          <td width=25></td> 
                        </tr> 
                        <tr bgcolor="#ffffff" height="30"> 
                          <td align="right">10</td> 
                          <td width=25><asp:CheckBox ID="chk1001" runat="server" /></td><td width=25><asp:CheckBox ID="chk1002" runat="server" /></td><td width=25><asp:CheckBox ID="chk1003" runat="server" /></td><td width=25><asp:CheckBox ID="chk1004" runat="server" /></td><td width=25><asp:CheckBox ID="chk1005" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1006" runat="server" /></td><td width=25><asp:CheckBox ID="chk1007" runat="server" /></td><td width=25><asp:CheckBox ID="chk1008" runat="server" /></td><td width=25><asp:CheckBox ID="chk1009" runat="server" /></td><td width=25><asp:CheckBox ID="chk1010" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1011" runat="server" /></td><td width=25><asp:CheckBox ID="chk1012" runat="server" /></td><td width=25><asp:CheckBox ID="chk1013" runat="server" /></td><td width=25><asp:CheckBox ID="chk1014" runat="server" /></td><td width=25><asp:CheckBox ID="chk1015" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1016" runat="server" /></td><td width=25><asp:CheckBox ID="chk1017" runat="server" /></td><td width=25><asp:CheckBox ID="chk1018" runat="server" /></td><td width=25><asp:CheckBox ID="chk1019" runat="server" /></td><td width=25><asp:CheckBox ID="chk1020" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1021" runat="server" /></td><td width=25><asp:CheckBox ID="chk1022" runat="server" /></td><td width=25><asp:CheckBox ID="chk1023" runat="server" /></td><td width=25><asp:CheckBox ID="chk1024" runat="server" /></td><td width=25><asp:CheckBox ID="chk1025" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1026" runat="server" /></td><td width=25><asp:CheckBox ID="chk1027" runat="server" /></td><td width=25><asp:CheckBox ID="chk1028" runat="server" /></td><td width=25><asp:CheckBox ID="chk1029" runat="server" /></td><td width=25><asp:CheckBox ID="chk1030" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1031" runat="server" /></td> 
                        </tr> 
                        <tr bgcolor="#D9FFCC" height="30"> 
                          <td align="right">11</td> 
                          <td width=25><asp:CheckBox ID="chk1101" runat="server" /></td><td width=25><asp:CheckBox ID="chk1102" runat="server" /></td><td width=25><asp:CheckBox ID="chk1103" runat="server" /></td><td width=25><asp:CheckBox ID="chk1104" runat="server" /></td><td width=25><asp:CheckBox ID="chk1105" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1106" runat="server" /></td><td width=25><asp:CheckBox ID="chk1107" runat="server" /></td><td width=25><asp:CheckBox ID="chk1108" runat="server" /></td><td width=25><asp:CheckBox ID="chk1109" runat="server" /></td><td width=25><asp:CheckBox ID="chk1110" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1111" runat="server" /></td><td width=25><asp:CheckBox ID="chk1112" runat="server" /></td><td width=25><asp:CheckBox ID="chk1113" runat="server" /></td><td width=25><asp:CheckBox ID="chk1114" runat="server" /></td><td width=25><asp:CheckBox ID="chk1115" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1116" runat="server" /></td><td width=25><asp:CheckBox ID="chk1117" runat="server" /></td><td width=25><asp:CheckBox ID="chk1118" runat="server" /></td><td width=25><asp:CheckBox ID="chk1119" runat="server" /></td><td width=25><asp:CheckBox ID="chk1120" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1121" runat="server" /></td><td width=25><asp:CheckBox ID="chk1122" runat="server" /></td><td width=25><asp:CheckBox ID="chk1123" runat="server" /></td><td width=25><asp:CheckBox ID="chk1124" runat="server" /></td><td width=25><asp:CheckBox ID="chk1125" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1126" runat="server" /></td><td width=25><asp:CheckBox ID="chk1127" runat="server" /></td><td width=25><asp:CheckBox ID="chk1128" runat="server" /></td><td width=25><asp:CheckBox ID="chk1129" runat="server" /></td><td width=25><asp:CheckBox ID="chk1130" runat="server" /></td> 
                          <td width=25></td> 
                        </tr> 
                        <tr bgcolor="#ffffff" height="30"> 
                          <td align="right">12</td> 
                          <td width=25><asp:CheckBox ID="chk1201" runat="server" /></td><td width=25><asp:CheckBox ID="chk1202" runat="server" /></td><td width=25><asp:CheckBox ID="chk1203" runat="server" /></td><td width=25><asp:CheckBox ID="chk1204" runat="server" /></td><td width=25><asp:CheckBox ID="chk1205" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1206" runat="server" /></td><td width=25><asp:CheckBox ID="chk1207" runat="server" /></td><td width=25><asp:CheckBox ID="chk1208" runat="server" /></td><td width=25><asp:CheckBox ID="chk1209" runat="server" /></td><td width=25><asp:CheckBox ID="chk1210" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1211" runat="server" /></td><td width=25><asp:CheckBox ID="chk1212" runat="server" /></td><td width=25><asp:CheckBox ID="chk1213" runat="server" /></td><td width=25><asp:CheckBox ID="chk1214" runat="server" /></td><td width=25><asp:CheckBox ID="chk1215" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1216" runat="server" /></td><td width=25><asp:CheckBox ID="chk1217" runat="server" /></td><td width=25><asp:CheckBox ID="chk1218" runat="server" /></td><td width=25><asp:CheckBox ID="chk1219" runat="server" /></td><td width=25><asp:CheckBox ID="chk1220" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1221" runat="server" /></td><td width=25><asp:CheckBox ID="chk1222" runat="server" /></td><td width=25><asp:CheckBox ID="chk1223" runat="server" /></td><td width=25><asp:CheckBox ID="chk1224" runat="server" /></td><td width=25><asp:CheckBox ID="chk1225" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1226" runat="server" /></td><td width=25><asp:CheckBox ID="chk1227" runat="server" /></td><td width=25><asp:CheckBox ID="chk1228" runat="server" /></td><td width=25><asp:CheckBox ID="chk1229" runat="server" /></td><td width=25><asp:CheckBox ID="chk1230" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk1231" runat="server" /></td> 
                        </tr> 
                        <tr bgcolor="#D9FFCC" height="30"> 
                          <td align="right"> 
                              <asp:Label ID="lbl01" runat="server"></asp:Label>／01</td> 
                          <td width=25><asp:CheckBox ID="chk0101" runat="server" /></td><td width=25><asp:CheckBox ID="chk0102" runat="server" /></td><td width=25><asp:CheckBox ID="chk0103" runat="server" /></td><td width=25><asp:CheckBox ID="chk0104" runat="server" /></td><td width=25><asp:CheckBox ID="chk0105" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0106" runat="server" /></td><td width=25><asp:CheckBox ID="chk0107" runat="server" /></td><td width=25><asp:CheckBox ID="chk0108" runat="server" /></td><td width=25><asp:CheckBox ID="chk0109" runat="server" /></td><td width=25><asp:CheckBox ID="chk0110" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0111" runat="server" /></td><td width=25><asp:CheckBox ID="chk0112" runat="server" /></td><td width=25><asp:CheckBox ID="chk0113" runat="server" /></td><td width=25><asp:CheckBox ID="chk0114" runat="server" /></td><td width=25><asp:CheckBox ID="chk0115" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0116" runat="server" /></td><td width=25><asp:CheckBox ID="chk0117" runat="server" /></td><td width=25><asp:CheckBox ID="chk0118" runat="server" /></td><td width=25><asp:CheckBox ID="chk0119" runat="server" /></td><td width=25><asp:CheckBox ID="chk0120" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0121" runat="server" /></td><td width=25><asp:CheckBox ID="chk0122" runat="server" /></td><td width=25><asp:CheckBox ID="chk0123" runat="server" /></td><td width=25><asp:CheckBox ID="chk0124" runat="server" /></td><td width=25><asp:CheckBox ID="chk0125" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0126" runat="server" /></td><td width=25><asp:CheckBox ID="chk0127" runat="server" /></td><td width=25><asp:CheckBox ID="chk0128" runat="server" /></td><td width=25><asp:CheckBox ID="chk0129" runat="server" /></td><td width=25><asp:CheckBox ID="chk0130" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0131" runat="server" /></td> 
                        </tr> 
                        <tr bgcolor="#ffffff" height="30"> 
                          <td align="right">02</td> 
                          <td width=25><asp:CheckBox ID="chk0201" runat="server" /></td><td width=25><asp:CheckBox ID="chk0202" runat="server" /></td><td width=25><asp:CheckBox ID="chk0203" runat="server" /></td><td width=25><asp:CheckBox ID="chk0204" runat="server" /></td><td width=25><asp:CheckBox ID="chk0205" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0206" runat="server" /></td><td width=25><asp:CheckBox ID="chk0207" runat="server" /></td><td width=25><asp:CheckBox ID="chk0208" runat="server" /></td><td width=25><asp:CheckBox ID="chk0209" runat="server" /></td><td width=25><asp:CheckBox ID="chk0210" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0211" runat="server" /></td><td width=25><asp:CheckBox ID="chk0212" runat="server" /></td><td width=25><asp:CheckBox ID="chk0213" runat="server" /></td><td width=25><asp:CheckBox ID="chk0214" runat="server" /></td><td width=25><asp:CheckBox ID="chk0215" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0216" runat="server" /></td><td width=25><asp:CheckBox ID="chk0217" runat="server" /></td><td width=25><asp:CheckBox ID="chk0218" runat="server" /></td><td width=25><asp:CheckBox ID="chk0219" runat="server" /></td><td width=25><asp:CheckBox ID="chk0220" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0221" runat="server" /></td><td width=25><asp:CheckBox ID="chk0222" runat="server" /></td><td width=25><asp:CheckBox ID="chk0223" runat="server" /></td><td width=25><asp:CheckBox ID="chk0224" runat="server" /></td><td width=25><asp:CheckBox ID="chk0225" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0226" runat="server" /></td><td width=25><asp:CheckBox ID="chk0227" runat="server" /></td><td width=25><asp:CheckBox ID="chk0228" runat="server" /></td><td width=25><asp:CheckBox ID="chk0229" runat="server" /></td><td width=25></td> 
                          <td width=25></td> 
                        </tr> 
                        <tr bgcolor="#D9FFCC" height="30"> 
                          <td align="right">03</td> 
                          <td width=25><asp:CheckBox ID="chk0301" runat="server" /></td><td width=25><asp:CheckBox ID="chk0302" runat="server" /></td><td width=25><asp:CheckBox ID="chk0303" runat="server" /></td><td width=25><asp:CheckBox ID="chk0304" runat="server" /></td><td width=25><asp:CheckBox ID="chk0305" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0306" runat="server" /></td><td width=25><asp:CheckBox ID="chk0307" runat="server" /></td><td width=25><asp:CheckBox ID="chk0308" runat="server" /></td><td width=25><asp:CheckBox ID="chk0309" runat="server" /></td><td width=25><asp:CheckBox ID="chk0310" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0311" runat="server" /></td><td width=25><asp:CheckBox ID="chk0312" runat="server" /></td><td width=25><asp:CheckBox ID="chk0313" runat="server" /></td><td width=25><asp:CheckBox ID="chk0314" runat="server" /></td><td width=25><asp:CheckBox ID="chk0315" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0316" runat="server" /></td><td width=25><asp:CheckBox ID="chk0317" runat="server" /></td><td width=25><asp:CheckBox ID="chk0318" runat="server" /></td><td width=25><asp:CheckBox ID="chk0319" runat="server" /></td><td width=25><asp:CheckBox ID="chk0320" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0321" runat="server" /></td><td width=25><asp:CheckBox ID="chk0322" runat="server" /></td><td width=25><asp:CheckBox ID="chk0323" runat="server" /></td><td width=25><asp:CheckBox ID="chk0324" runat="server" /></td><td width=25><asp:CheckBox ID="chk0325" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0326" runat="server" /></td><td width=25><asp:CheckBox ID="chk0327" runat="server" /></td><td width=25><asp:CheckBox ID="chk0328" runat="server" /></td><td width=25><asp:CheckBox ID="chk0329" runat="server" /></td><td width=25><asp:CheckBox ID="chk0330" runat="server" /></td> 
                          <td width=25><asp:CheckBox ID="chk0331" runat="server" /></td> 
                        </tr> 
                      </table> 
                      <br /> 
                      <table border="0" cellpadding="0" cellspacing="0" width="100%"> 
                      <tr> 
                        <td align=right> 
                          <asp:ImageButton ID="cmdRun" runat="server" ImageUrl="~/image/b_insert.gif" />&nbsp; 
                          <asp:ImageButton ID="cmdClear" runat="server" ImageUrl="~/image/b_clear.gif" />
                        </td> 
                      </tr> 
                      </table> 
                    </asp:Panel> 
                  </ContentTemplate> 
                  <Triggers> 
                    <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" /> 
                  </Triggers> 
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
