function Save() {
    $.ajax({
        url: GetUrl() + "UserManager/RegisterFun",
        data: "pm_UserLogin=" + $("#pm_UserLogin").val() + "&pm_UserName=" + $("#pm_UserName").val() + "&pm_UserPassword=" + $("#pm_UserPassword").val(),
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