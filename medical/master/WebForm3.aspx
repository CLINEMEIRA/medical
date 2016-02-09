<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="medical.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            width: 222px;
        }
        .auto-style3 {
            height: 20px;
            width: 222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center; z-index: 1; left: 10px; top: 15px; position: absolute; height: 39px; width: 690px">
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/b_run.gif" />
        <br />
        <br />
    
    </div>
    </form>
    <table style="border-style: solid; border-width: 1px; width: 100%;" border="1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
    </table>
</body>
</html>
