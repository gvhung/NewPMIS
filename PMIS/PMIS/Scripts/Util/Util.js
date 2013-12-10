
function GetOption(list, code) {
    var html = new Array();
    html.push("<option value=\"\">----------请选择----------</option>");
    $.each(list, function (i, item) {
        if (item.Code == code) {
            html.push("<option value=\"" + item.Code + "\" selected='selected'>" + item.Name + "</option>");
        } else {
            html.push("<option value=\"" + item.Code + "\">" + item.Name + "</option>");
        }
    });
    return html.join("");
}

function GetCodeInfo(type, code) {
    var html = new Array();
    $.ajax({
        url: GetUrl() + "BmInfo/GetBmCode",
        data: "type=" + type,
        tryp: 'post',
        async: false,
        success: function (list) {
            html.push("<option value=\"\"></option>");
            $.each(list, function (i, item) {
                if (item.Code == code) {
                    html.push("<option value=\"" + item.Code + "\" selected='selected'>" + item.c_name + "</option>");
                } else {
                    html.push("<option value=\"" + item.Code + "\">" + item.Name + "</option>");
                }
            });
        }
    });

    return html.join("");
}

function GetCode(list, id) {
    var html = new Array();
    html.push("<select id='lb" + id + "' onchange='GetNextType($(this).val()," + id + ")'>");
    html.push("<option value=\"\">----------请选择----------</option>");
    $.each(list, function (i, item) {
        html.push("<option value=\"" + item.Code + "\">" + item.Name + "</option>");
    });
    html.push("</select><span id='span" + id + "'></span>");
    return html.join('');
}

function GetCodeList(codes) {
    var json;
    $.ajax({
        url: GetUrl() + "BmInfo/GetBmCodes",
        data: "codes=" + codes,
        tryp: 'post',
        async: false,
        success: function (list) {
            json = list;
        }
    });
    return json;
}