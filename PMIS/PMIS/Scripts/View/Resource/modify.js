$(function() {
    InitData();
});

function InitData() {
    var list = GetCodeList('xtzylx,xtzyzt');
    $("#pm_TRType").html(GetOption(list['xtzylx'], $("#type").val()));
    $("#pm_TRState").html(GetOption(list['xtzyzt'], $("#state").val()));
}
