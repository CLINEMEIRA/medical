// webviewer ファイル

//document.write('<ActiveReportsWeb:WebViewer ID="WebViewer1" runat="server" Width="100px" Height="100px" ViewerType="ActiveXViewer" MaxReportRunTime="00:03:00" SlidingExpirationInterval="00:00:10" />')

document.write('<object id="arv" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px; width: 0px; height: 0px;" codeBase="arview2.cab#Version=2,4,1,1280" classid="clsid:8569D715-FF88-44BA-8D1D-AD3E59543DDE">');
document.write('<PARAM NAME="_ExtentX" VALUE="26">');
document.write('<PARAM NAME="_ExtentY" VALUE="26">')
document.write('</object>');
document.write('<script  type="text/javascript" language="JavaScript" for="arv" event="ControlLoaded">')
document.write('loadPrint();')
document.write('</script>')
document.write('<script type="text/javascript" language="JavaScript" for="arv" event="LoadCompleted">')
document.write('startPrint();')
document.write('</script>')
