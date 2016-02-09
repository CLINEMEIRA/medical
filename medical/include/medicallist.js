// JScript ファイル

function moveCursorLast(obj)
{
//    var elm = document.getElementById('text'); // テキストエリアのelement取得
    var elm = obj;
    elm.focus();

    if (elm.createTextRange) {
        var range = elm.createTextRange();
        range.move('character', elm.value.length);
        range.select();
    } else if (elm.setSelectionRange) {
        elm.setSelectionRange(elm.value.length, elm.value.length);
    }
}