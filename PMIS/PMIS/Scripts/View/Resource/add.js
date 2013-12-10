$(function() {
    InitData();
});
function btnOkClick() {
    var options = {
        url: GetUrl() + "Resource/AddResource",
        async: false,
        type: "post",
        beforeSend: function () {
        },
        error: function () {
        },
        success: function (res) {
            if (res != null && res != "") {
                if (res.State == "1") {
                    $.messager.alert('系统提示', res.Msg,'info',function() {
                        window.location.href = GetUrl() + "Resource/Index";
                    });
                } else {
                    $.messager.alert('系统提示', res.Msg, "error");
                }
            }
        }
    };
    $("#fromInfo").ajaxSubmit(options);
}
function InitData() {
    if ($("#pm_TRFid").val() == '0') {
        $("#fatherZy").val("顶级资源");
    }
    var list = GetCodeList('xtzylx,xtzyzt');
    $("#pm_TRType").html(GetOption(list['xtzylx']));
    $("#pm_TRState").html(GetOption(list['xtzyzt']));
    

}
