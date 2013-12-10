$(document).ready(function() {
    $("#yzmimg").attr('src', '/Login/GetValidateCode');
});

function login() {
    if ($("#pm_UserName").val() == "") {
        alert("请输入用户名");
        $("#pm_UserName").foucs();
        return false;
    }
    if ($("#pm_UserPassword").val() == "") {
        alert("请输入密码");
        $("#pm_UserPassword").foucs();
        return false;
    }
    if ($("#yzm").val() == "") {
        alert("请输入验证码");
        $("#yzm").foucs();
        return false;
    }
    GoLogin();
}

function GoLogin() {
    $.ajax({
        url: GetUrl() + "Login/LoginFun",
        data: 'Name=' + $("#pm_UserName").val() + "&Password=" + $("#pm_UserPassword").val() + "&Yzm=" + $("#yzm").val(),
        type: 'post',
        async: false,
        success: function(res) {
            if (parseInt(res.State) == 1) {
                window.location.href = GetUrl() + res.Msg;
            } else {
                alert(res.Msg);
            }
        }
    });
}