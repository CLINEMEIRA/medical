// JScript ファイル

var oClock;

//if(document.all || document.getElementById){
//	document.onmousedown = RightClick;	//右クリックイベント取得
//}else if(document.layers){
//	window.captureEvents(Event.MOUSEDOWN);
//	window.onmousedown = RightClick;	//右クリックイベント取得
//}

//function RightClick(e){
//	if(document.all || document.getElementById){
//		if(event.button & 2){
//			alert("右クリック不可");	//アラート画面表示
//			return(false);
//		}
//	}else if(document.layers){
//		if(e.which == 3){
//			alert("右クリック不可");	//アラート画面表示
//			return(false);
//		}
//	}
//}

// エラー無効
function TigilError() {
	return true;
}

//window.onerror = TigilError;

// 時計表示
function clock()
{
    oYoubiTbl = new Array("日","月","火","水","木","金","土");
    oDate     = new Date();

    nYear    = oDate.getYear();
    nYear4   = (nYear < 2000) ? nYear+1900 : nYear;
    nMonth   = oDate.getMonth() + 1;
    nDate    = oDate.getDate();
    nDay     = oDate.getDay();
    nHours   = oDate.getHours();
    nMinutes = oDate.getMinutes();
    nSeconds = oDate.getSeconds();

    sMess1 = nYear4 + "年" + nMonth + "月" + nDate + "日" + oYoubiTbl[nDay] + "曜日";
    sMess2 = nHours + "時" + nMinutes + "分" + nSeconds + "秒";
    document.getElementById("pageheader_lblClock").innerText = sMess1 + " " + sMess2;
}

// 時計開始
function startClock()
{
    setInterval('clock()',1000);
}


// Enterキー無効
function checkEnter()
{
    if(event.keyCode == 13){
        switch(window.event.srcElement.type)
        {
            case "image" :
                return true;
                break;
            default :
                return false;
        }
    } else{
        return true;
    }
}

function Trim(text)
{
	var strRet, strFinal;
	strTemp = text;
	//LTRIM
	strRet = LTrim(strTemp);
	//RTRIM
	strFinal = RTrim(strRet);
    return strFinal;
}

function RTrim(strTemp)
{
	var nLoop = 0;
	var strReturn = strTemp;
	while (nLoop < strTemp.length)
	{
		if (strReturn.substring(strReturn.length - 1, strReturn.length) == " ")
		{
			strReturn = strTemp.substring(0, strTemp.length - (nLoop + 1));
		}
		else
		{
			break;
		}
		nLoop++;
	}
	return strReturn;
}

function LTrim(strTemp)
{
	var nLoop = 0;
	var strReturn = strTemp;
	while (nLoop < strTemp.length)
	{
		if (strReturn.substring(0, 1) == " ")
		{
			strReturn = strTemp.substring(nLoop + 1, strTemp.length);
		}
		else
		{
			break;
		}
		nLoop++;
	}
	return strReturn;
}

// メッセージ表示
function confirmMessage(msg)
{
    if (typeof(Page_ClientValidate) != 'function' ||  Page_ClientValidate()) {
        return confirm(msg);		
    } else{
        return false;
    }
}

// エラー表示
function showError(control)
{
    var nWidth  = 260;
    var nHeight = 160;
    var nLeft = (screen.availWidth - nWidth) / 2;
    var nTop  = (screen.availHeight - nHeight) / 2;
	//objw = window.open("ServerPrint.aspx", null, "WIDTH="+nWidth+",HEIGHT="+nHeight+",SCROLLBARS=yes,RESIZABLE=no,TOOLBAR=no,MENUBAR=no,LOCATION=no,STATUS=no,LEFT="+nLeft+",TOP="+nTop);
    objw = window.showModalDialog("../temp.html?control="+control, this, "dialogWidth:"+nWidth+"px;dialogHeight:"+nHeight+"px;status:no;resizable:no;help:no;center:yes");
}

// 日付選択
function listMDSRC000(day)
{
	var sRet;
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc000.aspx", window, "dialogWidth:280px;dialogHeight:340px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( day, sValues[0]);
	}
}

// ファイル選択
function listMDSRC005(file)
{
	var sRet;
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc005.aspx", window, "dialogWidth:420px;dialogHeight:420px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( file, sValues[0]);
	}
}

// カタログ番号検索
function listMDSRC010(catalog,syanai)
{
	var sRet;
	var sValue1 = getText(catalog);
	var sValue2 = getText(syanai);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc010.aspx?catalog=" + sValue1 + "@syanai=" + sValue2, window, "dialogWidth:510px;dialogHeight:550px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( catalog, sValues[0]);
	    setValue( syanai,  sValues[1]);
	}
}

// カタログ番号検索(組番付)
function listMDSRC010(catalog,syanai,kumi)
{
	var sRet;
	var sValue1 = getText(catalog);
	var sValue2 = getText(syanai);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc010.aspx?catalog=" + sValue1 + "@syanai=" + sValue2, window, "dialogWidth:510px;dialogHeight:550px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( catalog, sValues[0]);
	    setValue( syanai,  sValues[1]);
	    setValue( kumi,    sValues[2]);
	}
}

// カタログ番号検索(製品)
function listMDSRC0101(assy,catalog,syanai)
{
	var sRet;
	var sValue1 = getText(catalog);
	var sValue2 = getText(syanai);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc010.aspx?assy=" + assy + "@catalog=" + sValue1 + "@syanai=" + sValue2, window, "dialogWidth:510px;dialogHeight:550px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( catalog, sValues[0]);
	    setValue( syanai,  sValues[1]);
	}
}

// カタログ番号検索 mode=gen：源製品
//                  mode=ko ：子部品
function listMDSRC0102(catalog,mode)
{
	var sRet;
	var sValue1 = getText(catalog);
	var sValue2 = getText(mode);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc010.aspx?catalog=" + sValue1 + "@mode=" + mode, window, "dialogWidth:510px;dialogHeight:550px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( catalog, sValues[0]);
	}
}

// カタログ番号検索 全件（これ以外は停止区分='0'）
function listMDSRC0103(catalog,syanai,kumi)
{
	var sRet;
	var sValue1 = getText(catalog);
	var sValue2 = getText(syanai);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc010.aspx?teisi=1@catalog=" + sValue1 + "@syanai=" + sValue2, window, "dialogWidth:510px;dialogHeight:550px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( catalog, sValues[0]);
	    setValue( syanai,  sValues[1]);
	    setValue( kumi,    sValues[2]);
	}
}

// カタログ番号検索 組番='Z9'       2010/08 追加
function listMDSRC0104(catalog) {
    var sRet;
    var sValue1 = getText(catalog);
    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc010.aspx?Z9=1@catalog=" + sValue1, window, "dialogWidth:510px;dialogHeight:550px;help:no;status:no;scroll:no");
    if (sRet != "") {
        var sValues = sRet.split(unescape(","));
        setValue(catalog, sValues[0]);
    }
}

// カタログ番号検索(改訂履歴用 図面管理番号付)
function listMDSRC011(catalog,zumen)
{
	var sRet;
	var sValue = getText(catalog);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc011.aspx?catalog=" + sValue, window, "dialogWidth:560px;dialogHeight:550px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
        setValue( catalog, sValues[0]);
        setValue( zumen,  sValues[1]);
	}
}

// カタログ番号検索(改訂履歴用 図面管理番号付) 停止区分指定なし     2010/07/05 追加
function listMDSRC0111(catalog, zumen) {
    var sRet;
    var sValue = getText(catalog);
    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc011.aspx?catalog=" + sValue + "@mode=teisi", window, "dialogWidth:560px;dialogHeight:550px;help:no;status:no;scroll:no");
    if (sRet != "") {
        var sValues = sRet.split(unescape(","));
        setValue(catalog, sValues[0]);
        setValue(zumen, sValues[1]);
    }
}

// 主材料コード検索(専用材区分指定[ex.012])
function listMDSRC020(kubun,code,renno,name)
{
	var sRet;
	var sValue1 = getText(code);
	var sValue2 = getText(renno);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc020.aspx?kubun=" + kubun + "@zairyo=" + sValue1 + "@renno=" + sValue2, window, "dialogWidth:360px;dialogHeight:490px;help:no;status:no;scroll:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code,  sValues[0]);
	    setValue( renno, sValues[1]);
	    setValue( name,  sValues[2]);
	}
}

// 作業者コード検索
function listMDSRC030(code,name,rname)
{

	var sRet;
	var Ver = navigator.appVersion; 
    var x = Ver.indexOf("MSIE",0); 
    if (Ver.substring(x+8, x+9) == ";")
        Ver = Ver.substring(x+5,x+8);
    else
        Ver = Ver.substring(x+5, x+9);
    var sValue1 = getText(code);
    if (Ver == 5.5) {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc030_55.aspx?sagyou=" + sValue1, window, "dialogWidth:400px;dialogHeight:530px;help:no;status:no;scroll:no");
    } else {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc030.aspx?sagyou=" + sValue1, window, "dialogWidth:400px;dialogHeight:530px;help:no;status:no;scroll:no");
    }
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code,  sValues[0]);
	    setValue( name,  sValues[1]);
	    setValue( rname, sValues[2]);
	}
}

// 工程コード検索
function listMDSRC040(code,name,shop,setubi,setubiname)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc040.aspx?koutei=" + sValue1, window, "dialogWidth:560px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code,       sValues[0]);
	    setValue( name,       sValues[1]);
	    setValue( shop,       sValues[2]);
	    setValue( setubi,     sValues[3]);
	    setValue( setubiname, sValues[4]);
	}
}

// 工程コード 親工程のみ(FAMILY_KB = 0)
function listMDSRC041(code,name,shop,setubi,setubiname)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc040.aspx?mode=1@koutei=" + sValue1, window, "dialogWidth:560px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code,       sValues[0]);
	    setValue( name,       sValues[1]);
	    setValue( shop,       sValues[2]);
	    setValue( setubi,     sValues[3]);
	    setValue( setubiname, sValues[4]);
	}
}

// SHOPコード検索
function listMDSRC050(code,name)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc050.aspx?shop=" + sValue1, window, "dialogWidth:440px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// SHOPコード検索
function listMDSRC050(code,name,sosiki)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc050.aspx?shop=" + sValue1, window, "dialogWidth:440px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	    setValue( sosiki, sValues[2]);
	}
}

// 設備コード検索
function listMDSRC060(code,name)
{
	var sRet;
	var Ver = navigator.appVersion; 
    var x = Ver.indexOf("MSIE",0); 
    if (Ver.substring(x+8, x+9) == ";")
        Ver = Ver.substring(x+5,x+8);
    else
        Ver = Ver.substring(x+5, x+9); 
    var sValue1 = getText(code);
    if (Ver == 5.5) {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc060_55.aspx?setubi=" + sValue1, window, "dialogWidth:500px;dialogHeight:520px;help:no;status:no;scroll:no");
	} else {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc060.aspx?setubi=" + sValue1, window, "dialogWidth:500px;dialogHeight:520px;help:no;status:no;scroll:no");
	}
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// 設備コード検索(標準稼働形態付き)
function listMDSRC060_2(code, name, no) {
    var sRet;
    var Ver = navigator.appVersion;
    var x = Ver.indexOf("MSIE", 0);
    if (Ver.substring(x + 8, x + 9) == ";")
        Ver = Ver.substring(x + 5, x + 8);
    else
        Ver = Ver.substring(x + 5, x + 9);
    var sValue1 = getText(code);
    if (Ver == 5.5) {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc060_55.aspx?setubi=" + sValue1 + "@sche=1", window, "dialogWidth:500px;dialogHeight:520px;help:no;status:no;scroll:no");
    } else {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc060.aspx?setubi=" + sValue1 + "@sche=1" + sValue1, window, "dialogWidth:500px;dialogHeight:520px;help:no;status:no;scroll:no");
    }
    if (sRet != "") {
        var sValues = sRet.split(unescape(","));
        setValue(code, sValues[0]);
        setValue(name, sValues[1]);
        setValue(no, sValues[2]);
    }
}

// 外注コード検索
function listMDSRC070(code,name)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc070.aspx?gaicyu=" + sValue1, window, "dialogWidth:400px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

function listMDSRC0701(code,name,ryaku)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc070.aspx?gaicyu=" + sValue1, window, "dialogWidth:400px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code,  sValues[0]);
	    setValue( name,  sValues[1]);
	    setValue( ryaku, sValues[2]);
	}
}

// 外注コード検索(加工外注区分=1)
function listMDSRC071(code,name)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc071.aspx?gaicyu=" + sValue1, window, "dialogWidth:400px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// 汎用マスタ検索
function listMDSRC080(info,code,name)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc080.aspx?info=" + info + "@code=" + sValue1, window, "dialogWidth:450px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

function listMDSRC0801(mode,info,code,name)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc080.aspx?mode=" + mode + "@info=" + info + "@code=" + sValue1, window, "dialogWidth:450px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// 汎用マスタ検索（シリーズ検索専用）20120224追加
function listMDSRC081(info,code,name)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc081.aspx?info=" + info + "@code=" + sValue1, window, "dialogWidth:500px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// 項目名,項目名カナ
function listMDSRC082(info,code,name)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc082.aspx?info=" + info + "@code=" + sValue1, window, "dialogWidth:790px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// 指示NO検索
function listMDSRC090(siji,syanaino,catalog)
{
	var sRet;
	var sValue1 = getText(siji);
	var sValue2 = getText(catalog);
	var sVer = navigator.appVersion; 
    var x = sVer.indexOf("MSIE",0); 
    if (sVer.substring(x+8, x+9) == ";")
        sVer = sVer.substring(x+5,x+8);
    else
        sVer = sVer.substring(x+5, x+9);
    if(sVer == 5.5){
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc090_55.aspx?sijino=" + sValue1 + "@catalog=" + sValue2, window, "dialogWidth:590px;dialogHeight:540px;help:no;status:no;scroll:no");
    } else {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc090.aspx?sijino=" + sValue1 + "@catalog=" + sValue2, window, "dialogWidth:590px;dialogHeight:520px;help:no;status:no;scroll:no");
    }
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( siji,     sValues[0]);
	    setValue( syanaino, sValues[1]);
	    setValue( catalog,  sValues[2]);
	}
}

function listMDSRC090X(siji,syanaino,catalog)
{
	var sRet;
	var sValue1 = getText(siji);
	var sValue2 = getValue(catalog);
	var sVer = navigator.appVersion; 
    var x = sVer.indexOf("MSIE",0); 
    if (sVer.substring(x+8, x+9) == ";")
        sVer = sVer.substring(x+5,x+8);
    else
        sVer = sVer.substring(x+5, x+9);
    if(sVer == 5.5){
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc090_55.aspx?sijino=" + sValue1 + "@catalog=" + sValue2, window, "dialogWidth:590px;dialogHeight:540px;help:no;status:no;scroll:no");
    } else {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc090.aspx?sijino=" + sValue1 + "@catalog=" + sValue2, window, "dialogWidth:590px;dialogHeight:520px;help:no;status:no;scroll:no");
    }
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( siji,     sValues[0]);
	    setValue( syanaino, sValues[1]);
	    //setValue( catalog,  sValues[2]);
	}
}

// 指示NO検索 指示確定フラグ = 'K' AND 削除フラグ = ""
function listMDSRC0901(siji, syanaino, catalog, kumi) {
    var sRet;
    var sValue1 = getText(siji);
    var sValue2 = getText(catalog);
    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc090.aspx?mode=1@sijino=" + sValue1 + "@catalog=" + sValue2 + "@kumi=" + kumi, window, "dialogWidth:590px;dialogHeight:520px;help:no;status:no;scroll:no");
    if (sRet != "") {
        var sValues = sRet.split(unescape(","));
        setValue(siji, sValues[0]);
        setValue(syanaino, sValues[1]);
        setValue(catalog, sValues[2]);
    }
}

// 指示NO検索 指示確定フラグ = 'K' AND 削除フラグ = ""
// 指示NOを画面に戻さない
function listMDSRC09011(siji, syanaino, catalog, kumi) {
    var sRet;
    var sValue1 = getText(siji);
    var sValue2 = getText(catalog);
    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc090.aspx?mode=1@sijino=" + sValue1 + "@catalog=" + sValue2 + "@kumi=" + kumi, window, "dialogWidth:590px;dialogHeight:520px;help:no;status:no;scroll:no");
    if (sRet != "") {
        var sValues = sRet.split(unescape(","));
        //setValue(siji, sValues[0]);
        setValue(syanaino, sValues[1]);
        setValue(catalog, sValues[2]);
    }
}

// 指示NO検索 指示確定フラグ = 'K' AND 削除フラグ = ""
function listMDSRC091(siji,syanaino,kumi,catalog,sikakari)
{
	
	var sRet;
	var Ver = navigator.appVersion; 
    var x = Ver.indexOf("MSIE",0); 
    if (Ver.substring(x+8, x+9) == ";")
        Ver = Ver.substring(x+5,x+8);
    else
        Ver = Ver.substring(x+5, x+9); 
    var sValue1 = getText(siji);
    var sValue2 = getText(syanaino);
    if (Ver == 5.5) {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc091_55.aspx?sijino=" + sValue1 + "@syanaino=" + sValue2, window, "dialogWidth:360px;dialogHeight:550px;help:no;status:no;scroll:no");
	} else {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc091.aspx?sijino=" + sValue1 + "@syanaino=" + sValue2, window, "dialogWidth:360px;dialogHeight:530px;help:no;status:no;scroll:no");
	}
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( siji,     sValues[0]);
	    setValue( syanaino, sValues[1]);
	    setValue( kumi,     sValues[2]);
	    setValue( catalog,  sValues[3]);
	    setValue( sikakari, sValues[4]);
	}
}

// 指示NO検索 指示確定フラグ = 'K' AND 削除フラグ <> "D"
function listMDSRC0911(siji,syanaino)
{
	var sRet;
	var sValue1 = getText(siji);
	var sValue2 = getText(syanaino);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc091.aspx?sijino=" + sValue1 + "@syanaino=" + sValue2 + "@mode=1", window, "dialogWidth:360px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( siji,     sValues[0]);
	    setValue( syanaino, sValues[1]);
	}
}

// 材料ロットNO検索
function listMDSRC100(zairyo,lotno,renno)
{
	var sRet;
	var sValue1 = getValue(zairyo);
	var sValue2 = getText(lotno);
	if(sValue1.length > 0){
	    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc100.aspx?zairyo=" + sValue1 + "@lotno=" + sValue2, window, "dialogWidth:390px;dialogHeight:520px;help:no;status:no;scroll:no");
	    if(sRet != ""){
	        var sValues = sRet.split(unescape(","));
	        setValue( lotno, sValues[0]);
	        setValue( renno, sValues[1]);
	    }
	} else{
	    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc1001.aspx?zairyo=" + sValue1 + "@lotno=" + sValue2, window, "dialogWidth:510px;dialogHeight:520px;help:no;status:no;scroll:no");
	    if(sRet != ""){
	        var sValues = sRet.split(unescape(","));
	        setValue( zairyo, sValues[0]);
	        setValue( lotno,  sValues[1]);
	        setValue( renno,  sValues[2]);
	    }
	}
}

// 材料ロットNO検索(引当)
function listMDSRC101(zairyo,lotno,renno)
{
	var sRet;
	var sValue1 = getValue(zairyo);
	var sValue2 = getText(lotno);
	if(sValue1.length > 0){
	    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc101.aspx?zairyo=" + sValue1 + "@lotno=" + sValue2, window, "dialogWidth:480px;dialogHeight:520px;help:no;status:no;scroll:no");
	    if(sRet != ""){
	        var sValues = sRet.split(unescape(","));
	        setValue( lotno, sValues[0]);
	        setValue( renno, sValues[1]);
	    }
	} else{
	    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc1011.aspx?zairyo=" + sValue1 + "@lotno=" + sValue2, window, "dialogWidth:600px;dialogHeight:520px;help:no;status:no;scroll:no");
	    if(sRet != ""){
	        var sValues = sRet.split(unescape(","));
	        setValue( zairyo, sValues[0]);
	        setValue( lotno,  sValues[1]);
	        setValue( renno,  sValues[2]);
	    }
	}
}


// 材料ロットNO検索(引当)(在庫=0も)
function listMDSRC102(zairyo, lotno, renno) {
    var sRet;
    var sValue1 = getValue(zairyo);
    var sValue2 = getText(lotno);
    if (sValue1.length > 0) {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc101.aspx?zairyo=" + sValue1 + "@lotno=" + sValue2 + "@IsZero=1", window, "dialogWidth:480px;dialogHeight:520px;help:no;status:no;scroll:no");
        if (sRet != "") {
            var sValues = sRet.split(unescape(","));
            setValue(lotno, sValues[0]);
            setValue(renno, sValues[1]);
        }
    } else {
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc1011.aspx?zairyo=" + sValue1 + "@lotno=" + sValue2, window, "dialogWidth:600px;dialogHeight:520px;help:no;status:no;scroll:no");
        if (sRet != "") {
            var sValues = sRet.split(unescape(","));
            setValue(zairyo, sValues[0]);
            setValue(lotno, sValues[1]);
            setValue(renno, sValues[2]);
        }
    }
}


// 注文NO検索(主材料発注)
function listMDSRC120(chumon,code,renno)
{
	var sRet;
	var sValue1 = getText(chumon);
	var sValue2 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc120.aspx?cyumon=" + sValue1 + "@zairyo=" + sValue2, window, "dialogWidth:360px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( chumon, sValues[0]);
	    setValue( code,   sValues[1]);
	    setValue( renno,  sValues[2]);
	}
}

// 注文NO検索(主材料発注) [入庫完了フラグ IS NULL OR 空白 & 入庫完了日 = 00000000 & キャンセルコード IS NULL OR 空白 & 発注確定区分 = '1']
function listMDSRC121(chumon,code,renno)
{
	var sRet;
	var sValue1 = getText(chumon);
	var sValue2 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc121.aspx?cyumon=" + sValue1 + "@zairyo=" + sValue2, window, "dialogWidth:360px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( chumon, sValues[0]);
	    setValue( code,   sValues[1]);
	    setValue( renno,  sValues[2]);
	}
}

// 注文NO検索(主材料発注) [入庫完了フラグ = 0 & 入庫完了日 = 00000000 & キャンセルコード IS NULL OR 空白 & 発注書出力フラグ = '1']
function listMDSRC122(chumon,code,renno)
{
	var sRet;
	var sValue1 = getText(chumon);
	var sValue2 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc122.aspx?cyumon=" + sValue1 + "@zairyo=" + sValue2, window, "dialogWidth:360px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( chumon, sValues[0]);
	    setValue( code,   sValues[1]);
	    setValue( renno,  sValues[2]);
	}
}

// 製品グループ検索(L1、LV2)
function listMDSRC140(lv,kumi,rcode,rname,rkumi)
{
	var sRet;
	switch(lv){
	    case '1' :
	        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc140.aspx", window, "dialogWidth:340px;dialogHeight:490px;help:no;status:no;scroll:no");
	        if(sRet != ""){
	            var sValues = sRet.split(unescape(","));
	            setValue( rcode, sValues[0]);
	            setValue( rname, sValues[1]);
	        }
	        break;
	    case '2' :
	        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc141.aspx?kumi=" + kumi, window, "dialogWidth:380px;dialogHeight:490px;help:no;status:no;scroll:no");
	        if(sRet != ""){
	            var sValues = sRet.split(unescape(","));
	            setValue( rcode, sValues[0]);
	            setValue( rname, sValues[1]);
	            setValue( rkumi, sValues[2]);
	        }
	        break;
	    default :
	        break;
    }
}

// 製品グループ検索(L3)
function listMDSRC150(kumi,gcode1,gname1,gcode2,gname2,kumi2)
{
	var sRet;
	var sValue = getValue( gcode1);
	if(sValue.length > 0){
	    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc141.aspx?kumi=" + kumi + "@g1=" + sValue, window, "dialogWidth:380px;dialogHeight:520px;help:no;status:no;scroll:no");
        if(sRet != ""){
            var sValues = sRet.split(unescape(","));
            setValue( gcode2, sValues[0]);
            setValue( gname2, sValues[1]);
            setValue( kumi2 , sValues[2]);
        }
    } else{
        sRet = window.showModalDialog("../list/list.aspx?page=mdsrc150.aspx?kumi=" + kumi, window, "dialogWidth:680px;dialogHeight:530px;help:no;status:no;scroll:no");
	    if(sRet != ""){
	        var sValues = sRet.split(unescape(","));
	        setValue( gcode1, sValues[0]);
	        setValue( gname1, sValues[1]);
	        setValue( gcode2, sValues[2]);
	        setValue( gname2, sValues[3]);
	        setValue( kumi2,  sValues[4]);
	    }
    }
}

// 部品在庫検索
function listMDSRC160(siji,syanai,catalog)
{
	var sRet;
	var sValue1 = getText(siji);
	var sValue2 = getText(catalog);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc160.aspx?sijino=" + sValue1 + "@catalog=" + sValue2, window, "dialogWidth:470px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( siji,    sValues[0]);
	    setValue( syanai,  sValues[1]);
	    setValue( catalog, sValues[2]);
	}
}

// 部品在庫検索
function listMDSRC161(catalog,siji,syanai,tanaban)
{
	var sRet;
	var sValue = getValue(catalog);
	var sValue1 = getText(siji);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc161.aspx?catalog=" + sValue + "@sijino=" + sValue1, window, "dialogWidth:490px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( siji,    sValues[0]);
	    setValue( syanai,  sValues[1]);
	    setValue( tanaban, sValues[2]);
	}
}

// 部品在庫検索 実在庫 > 0
function listMDSRC162(catalog,siji,syanai,jituzai)
{
	var sRet;
	var sValue = getValue( catalog);
	var sValue1 = getText(siji);
	if(sValue == "" ){
	    alert("カタログ番号を入力して下さい")
	    return
	}
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc161.aspx?mode=1@catalog=" + sValue + "@sijino=" + sValue1, window, "dialogWidth:490px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( siji,    sValues[0]);
	    setValue( jituzai,  sValues[1]);
	}
}

// 部品在庫検索
function listMDSRC163(catalog,lotno)
{
	var sRet;
	var sValue1 = getText(catalog);
	var sValue2 = getText(lotno);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc163.aspx?catalog=" + sValue1 + "@sijino=" + sValue2, window, "dialogWidth:510px;dialogHeight:560px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( catalog, sValues[0]);
	    setValue( lotno,   sValues[1]);
	}
}

// 分割元指示ＮＯ検索
function listMDSRC170(catalog,syanai,siji,koujun,koutei,catalog2,catalog3)
{
	var sRet;
	var sValue = getValue(catalog);
	var sValue1 = getText(siji);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc170.aspx?catalog=" + sValue + "@sijino=" + sValue1, window, "dialogWidth:950px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( syanai, sValues[0]);
	    setValue( siji,   sValues[1]);
	    setValue( koujun, sValues[2]);
	    setValue( koutei, sValues[3]);
	    setValue( catalog2, sValues[4]);
	    setValue( catalog3, sValues[5]);
	}
}

// 分割先工程順序検索
function listMDSRC175(catalog,kihon,hojo,koutei,kbn)
{
	var sRet;
	var sValue = getValue(catalog);
	var skbn = getValue(kbn);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc175.aspx?catalog=" + sValue + "@kbn=" + skbn, window, "dialogWidth:400px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( kihon,  sValues[0]);
	    setValue( hojo,   sValues[1]);
	    setValue( koutei, sValues[2]);
	}
}

// 注文NO番号検索  mode=0：[入荷日='00000000' AND 発注確定区分=''] 
//                 mode=1：[入荷日='00000000' AND 発注確定区分='1' AND 解約理由='' 発注書出力フラグ='']
//                 mode=2：[入荷日='00000000' AND 発注確定区分='1' AND 解約理由='']
//                 mode=3：[解約理由='' AND 出荷数 > 0 AND ホスト出力済みフラグ='' AND 発注確定区分='1']
function listMDSRC180(mode,Tyumon)
{
	var sRet;
	var sValue1 = getText(Tyumon);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc180.aspx?mode=" + mode + "@chumon=" + sValue1, window, "dialogWidth:400px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( Tyumon, sValues[0]);
	}
}

// 注文NO番号検索  mode=0：[入荷日='00000000' AND 発注確定区分=''] 
function listMDSRC181(mode,Tyumon,siji,shanai)
{
	var sRet;
	var sValue1 = getText(Tyumon);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc180.aspx?mode=" + mode + "@chumon=" + sValue1, window, "dialogWidth:400px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( Tyumon, sValues[0]);
	    setValue( siji  , sValues[1]);
	    setValue( shanai, sValues[2]);
	}
}

// 工程順序検索(mode=0：全て[実績無] mode=1:全て[実績有] mode=2:補助工順=0[実績無] mode=3:補助工順=0[実績有])
function listMDSRC190(mode,siji,syanaino,catalog,kihon,hojo)
{
	var sRet;
	var sValue1 = getValue(siji);
	var sValue2 = getValue(syanaino);
	var sValue3 = getValue(catalog);
	if(sValue1 == "" || sValue2 == ""){
	    alert("指示NO、社内NOを入力して下さい")
	    return
	}
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc190.aspx?mode=" + mode + "@siji=" + sValue1 + "@syanai=" + sValue2 + "@catalog=" + sValue3, window, "dialogWidth:400px;dialogHeight:550px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( kihon, sValues[0]);
	    setValue( hojo,  sValues[1]);
	}
}

// 工程順序検索 全部
function listMDSRC191(siji,syanaino,catalog,kihon,hojo)
{
	var sRet;
	var sValue1 = getValue(siji);
	var sValue2 = getValue(syanaino);
	var sValue3 = getValue(catalog);
	if(sValue1 == "" || sValue2 == ""){
	    alert("指示NO、社内NOを入力して下さい")
	    return
	}
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc191.aspx?siji=" + sValue1 + "@syanai=" + sValue2 + "@catalog=" + sValue3, window, "dialogWidth:400px;dialogHeight:540px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( kihon, sValues[0]);
	    setValue( hojo,  sValues[1]);
	}
}

// 修正工程着工指示検索
function listMDSRC200(sijino,syanaino,kaisu)
{
	var sRet;
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc200.aspx", window, "dialogWidth:590px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( sijino,   sValues[0]);
	    setValue( syanaino, sValues[1]);
	    setValue( kaisu,    sValues[2]);
	}
}

// 主材料引当明細検索
function listMDSRC210(zairyo,renno,sijino,syanaino)
{
    var sRet;
	var sValue1 = getValue(zairyo);
	var sValue2 = getValue(renno);
	if(sValue2 == ""){
	    alert("連NOを入力して下さい");
	    return;
	}
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc210.aspx?zairyo=" + sValue1 + "@renno=" + sValue2, window, "dialogWidth:720px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( sijino,   sValues[0]);
	    setValue( syanaino, sValues[1]);
	}
}

// メニュー検索
function listMDSRC220(code,name)
{
	var sRet;
	var sValue1 = getText(name);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc220.aspx?name=" + sValue1, window, "dialogWidth:460px;dialogHeight:500px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// プログラム検索
function listMDSRC230(code,name)
{
	var sRet;
	var sValue1 = getText(code);
	var sValue2 = getText(name);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc230.aspx?pid=" + sValue1 + "@pname=" + sValue2, window, "dialogWidth:460px;dialogHeight:530px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// 工程票で使用する一覧
function listMDSRC240(mode,syanai,siji,syusei)
{
    var sRet;
    var nWidth;
    if( mode == 0){
        nWidth = 430;
    } else{
        nWidth = 510;
    }
    var sValue1 = getText(siji);
    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc240.aspx?mode=" + mode + "@sijino=" + sValue1, window, "dialogWidth:" + nWidth + "px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( syanai, sValues[0]);
	    setValue( siji,   sValues[1]);
	    setValue( syusei, sValues[2]);
	}
}

// 指示検索（主材料使用&着工中）
function listMDSRC250(syanai,siji)
{
    var sRet;
    var sValue1 = getText(siji);
    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc250.aspx?sijino=" + sValue1, window, "dialogWidth:545px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( syanai, sValues[0]);
	    setValue( siji,   sValues[1]);
	}
}

// セット構成検索
function listMDSRC260(code,name)
{
	var sRet;
	var sValue1 = getText(code);
	sRet = window.showModalDialog("../list/list.aspx?page=mdsrc260.aspx?setid=" + sValue1, window, "dialogWidth:440px;dialogHeight:520px;help:no;status:no;scroll:no");
	if(sRet != ""){
	    var sValues = sRet.split(unescape(","));
	    setValue( code, sValues[0]);
	    setValue( name, sValues[1]);
	}
}

// 源製品在庫検索   2010/08 追加
function listMDSRC270(oya, shanai, siji, catalog) {
    var sRet;
    var sValue1 = getValue(oya);
    var sValue2 = getText(siji);
    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc270.aspx?oya=" + sValue1 + "@siji=" + sValue2, window, "dialogWidth:580px;dialogHeight:580px;help:no;status:no;scroll:no");
    if (sRet != "") {
        var sValues = sRet.split(unescape(","));
        setValue(shanai,  sValues[0]);
        setValue(siji,    sValues[1]);
        setValue(catalog, sValues[2]);
    }
}

// セットID カタログ番号検索   2010/08 追加
function listMDSRC285(setid, name, catalog) {
    var sRet;
    var sValue1 = getValue(setid);
    var sValue2 = getValue(catalog);
    sRet = window.showModalDialog("../list/list.aspx?page=mdsrc285.aspx?setid=" + sValue1 + "@catalog=" + sValue2, window, "dialogWidth:550px;dialogHeight:510px;help:no;status:no;scroll:no");
    if (sRet != "") {
        var sValues = sRet.split(unescape(","));
        setValue(catalog, sValues[0]);
    }
}

// 値取得
function getValue(obj)
{
    if(obj == null) return '';
    switch(obj.type)
    {
        case "text" :
            return obj.value;
            break;
        case "hidden" :
            return obj.value;
            break;
        default :
            return obj.innerText;
            break;
    }
}

function getText(obj)
{
    if(obj == null) return '';
    switch(obj.type)
    {
        case "text" :
            return obj.value;
            break;
        default :
            return '';
            break;
    }
}

// 値セット
function setValue(obj,text)
{
    if(obj == null) return;
    switch(obj.type)
    {
        case "text" :
            //object.value = text;
            obj.innerText = text;
            break;
        default :
            obj.innerText = text;
            break;
    }
}
