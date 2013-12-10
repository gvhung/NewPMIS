function Save() {
    var con = CKEDITOR.instances.cs.getData();
    con = encodeURI(con);
    con = con.replace(/&/g, '%^&');
    var params = "pm_TPName=" + $("#pm_TPName").val() + "&pm_TPLead=" + $("#pm_TPLead").val()
        + "&pm_TPJjfaName=" + $("#pm_TPJjfaName").val() + "&pm_TPVersion=" + $("#pm_TPVersion").val()
        + "&pm_TPWd=" + con;
    $.ajax({
        url: GetUrl() + "",
        data: params,
        type: 'post',
        async: false,
        success: function (res) {
            $("#pm_TPName").val(res.pm_TPName);
            $("#pm_TPLeadH").val(res.pm_TPLead);
            $("#pm_TPLead").val(res.pm_TPLead);
            $("#pm_TPJjfaName").val(res.pm_TPJjfaName);
            $("#pm_TPVersion").val(res.pm_TPVersion);
            $("#pm_TPCreateTime").val(res.pm_TPCreateTime);
            CKEDITOR.instances.cs.setData(decodeURI(res.pm_TPWd));
        }
    });
}