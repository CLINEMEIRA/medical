<%@ Page Language="VB" AutoEventWireup="false" Inherits="medical.master_mdmas1701" Codebehind="mdmas1701.aspx.vb" %> 

<%@ Register assembly="GrapeCity.ActiveReports.Web.v9, Version=9.2.5098.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" namespace="GrapeCity.ActiveReports.Web" tagprefix="ActiveReportsWeb" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
  <title></title> 
  <meta http-equiv="cache-control" content="no-cache">  
  <script type="text/javascript" src="../include/AC_OETags.js"></script> 
  <script type="text/javascript">
      var viewer;
      function init() {
          GrapeCity.ActiveReports.Viewer.OnLoad("WebViewer1", function () {
              viewer = GrapeCity.ActiveReports.Viewer.Attach("WebViewer1");
              viewer.setEventsHandler({
              OnLoadProgress: function(e) {
                  alert("Event")
                      if (e.State == "Completed") {
                          var objFrame = parent.document.all("imgProgress")
                          objFrame.style.display = "none"
                      }
                  }
              })
          });
      }
  </script>
</head>
<body onload="return init()"> 
    <script type="text/javascript">
    <!--
        // Flashのバージョンをチェックします。
        // 通常は、Flashビューワ自身によりメッセージが表示されますが、
        // このページでは、Flashビューワをブラウザ画面いっぱいに表示
        // させている都合上、以下のスクリプトにより手動でバージョンチェック
        // を行います。
        var hasReqestedVersion = DetectFlashVer(11, 0, 0);
        if (!hasReqestedVersion) {
            // インストールされているFlashのバージョンが古いため、メッセージを表示します。
            var alternateContent = '適切なバージョンのFlash Playerがインストールされていません。'
	                         + 'Flashビューワを表示するには、Adobe Flash Player 10 が必要です。'
	                         + '<a href=http://www.adobe.com/go/getflash/>Flash Player を入手する。</a>';
            document.write(alternateContent);
        }
    // -->
    </script>
<form id="frmPrint" runat="server"> 
    <ActiveReportsWeb:WebViewer ID="WebViewer1" runat="server" height="100%"
            ViewerType="FlashViewer" 
            width="100%">
        <flashvieweroptions multipageviewcolumns="1" multipageviewrows="1" 
            useclientapi="True" HyperLinkUnderline="False"></flashvieweroptions>
    </ActiveReportsWeb:WebViewer>
</form> 
</body> 
</html> 

