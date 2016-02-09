<%@ Control Language="VB" AutoEventWireup="false" Inherits="medical.header" Codebehind="header.ascx.vb" %>

<table cellspacing="0" cellpadding="0" width="100%" border="0">
  <tr height="45">
    <td width="60%" valign="bottom" align="left">
      <img src="../image/title.gif" border="0" /> 
    </td>
    <td align="right" valign="middle">
      <asp:Label ID="lblClock" runat="server" Text="" Font-Size="10pt" ForeColor="MidnightBlue" />&nbsp;<br />
      <asp:Label ID="lblUserID" runat="server" Text="XXXX" Font-Size="10pt" ForeColor="MidnightBlue" />
      <asp:Label ID="lblUserName" runat="server" Text="○○部 花木 英寿" Font-Size="10pt" ForeColor="MidnightBlue" />&nbsp;
    </td>
  </tr>
  <tr height="25">
    <td valign="middle" align="left" background="../image/line.gif">
      &nbsp;
      <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Yellow" Text="プログラムタイトル" TabIndex="101" />
    </td>
    <td align="right" background="../image/line.gif">
      <asp:ImageButton ID="imgMenu" runat="server" ImageUrl="~/image/m_menu.gif" AlternateText="メニュー" OnClientClick="location.href='../system/mdclmenu.aspx';return false;" TabIndex="102" CausesValidation="False" ImageAlign="Top" /><asp:ImageButton ID="imgLogout" runat="server" ImageUrl="~/image/m_logout.gif" AlternateText="ログアウト" OnClientClick="location.href='../system/mdcllogout.aspx';return false;" TabIndex="103" ImageAlign="Top" /><asp:ImageButton ID="imgEnd" runat="server" ImageUrl="~/image/m_end.gif" AlternateText="終了" OnClientClick="window.close();return false;" TabIndex="104" ImageAlign="Top" />&nbsp;
    </td>
  </tr>
</table>
