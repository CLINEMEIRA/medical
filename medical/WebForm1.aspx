<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="medical.WebForm1" %>

<%@ Register assembly="GrapeCity.ActiveReports.Web.v9, Version=9.2.5098.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" namespace="GrapeCity.ActiveReports.Web" tagprefix="ActiveReportsWeb" %>

<%@ Register assembly="C1.Web.C1WebChart.4" namespace="C1.Web.C1WebChart" tagprefix="C1WebChart" %>

<%@ Register assembly="C1.Web.Wijmo.Controls.4" namespace="C1.Web.Wijmo.Controls.C1Input" tagprefix="wijmo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <ActiveReportsWeb:WebViewer ID="WebViewer1" runat="server" height="46" width="345">
        </ActiveReportsWeb:WebViewer>
    
        <wijmo:C1InputDate ID="C1InputDate1" runat="server" Date="02/04/2016 19:00:50">
        </wijmo:C1InputDate>
        <br />
        <br />
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
        <br />
    
    </div>
    </form>
</body>
</html>
