<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="medical.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  <link href="include/medical.css" rel="stylesheet" type="text/css" /> 
  <script type="text/javascript" src="include/medical.js"><!-- 
  // --></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="margin: 0px; padding: 0px; width: 100%; border-collapse: collapse;">
            <!-- ヘッダー --> 
            <tr> 
              <td>ヘッダー</td> 
            </tr> 
            <tr style="height: 20px"> 
                <td> 
                </td> 
            </tr> 
        </table>
    <br />
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator id="valName1" runat="server" Font-Size="10pt" Display="Dynamic" ControlToValidate="TextBox1" ErrorMessage="入力必須項目です" EnableClientScript="False" ValidationGroup="check" ForeColor="Red"></asp:RequiredFieldValidator><br />
        <asp:RegularExpressionValidator ID="valStock" runat="server" ErrorMessage="整数5桁以内、少数2桁以内で入力してください" ControlToValidate="TextBox1" Display="Dynamic" EnableClientScript="False" ValidationExpression="^[0-9]{1,5}(\.[0-9]{0,2})?" ValidationGroup="check" ForeColor="Red"></asp:RegularExpressionValidator>
        <table border="1" style="width: 50%; margin-right: auto; margin-left: auto;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx">リンクです</asp:HyperLink>
                </td>
                <td style="text-align: center">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/b_run.gif" />
                </td>
            </tr>
            <tr>
                <td ></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>        
        <br />
    </form>
</body>
</html>

