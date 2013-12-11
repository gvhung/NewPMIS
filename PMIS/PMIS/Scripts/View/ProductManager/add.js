function Save() {
    var con = CKEDITOR.instances.cs.getData();
    con = encodeURI(con);
    con = con.replace(/&/g, '%^&');
    var params = "pm_TPName=" + $("#pm_TPName").val() + "&pm_TPLead=" + $("#pm_TPLeadH").val()
        + "&pm_TPJjfaName=" + $("#pm_TPJjfaName").val() + "&pm_TPVersion=" + $("#pm_TPVersion").val()
        + "&pm_TPWd=" + con+"&pm_TPCreateTime="+$("#pm_TPCreateTime").val();
    params = encodeURI(params);
    $.ajax({        
       url:GetUrl()+"ProductManager/AddFun",
       data:params,
       type:'post',
       async:false,
       success:function(res) {
           $.message.alert(res.Msg);
       }
    });
}
 

function ajaxFileUpload() {
    $.ajaxFileUpload(
        {
            url: '/ProductManager/Upload',            //需要链接到服务器地址
            secureuri: false,
            fileElementId: 'fileToUpload',                        //文件选择框的id属性
            dataType: 'text',                                     //服务器返回的格式，可以是json
            success: function(data, status)            //相当于java中try语句块的用法
            {
                var strs = data.split(',');
                var state = strs[0].split(':');
                var msg = strs[1].split(':');
                var path = strs[2].split(':');
                if (state[1] / 1 == 1) {
                    $("#filePath").val(path[1]);
                    $("#result").html("上传成功");
                } else {
                    $.messager.alert('系统提示', msg[1], 'error');
                }
            },
            error: function(data, status, e)            //相当于java中catch语句块的用法
            {
                $('#result').html('添加失败');
            }
        }
    );

}

function IzXmEq() {
    $.ajax({
        url: GetUrl() + "ProductManager/GetUserId?Name=" + $("#pm_TPLead").val(),
        data: '',
        type: 'post',
        async: false,
        success: function(res) {
            if (parseInt(res.State) == 0) {
                $("#pm_TPLeadH").val(res.Bean[0].pm_UserID);
            } else if (parseInt(res.State) == 1) {
                Buid(res.Bean);
                $('#dlg').dialog('open');
            } else {
                alert(res.Msg);
            }
        }
    });
}
function Buid(data) {
    var html = new Array();
    html.push("<table><tr><th>姓名</th><th>隶属于</th><th>选择</th>");
    $.each(data, function(i, bean) {
        if (bean.RoleFpList.count == 1) {
            html.push("<td>" + bean.pm_UserName + "</td><td>" + bean.RoleFpList[0].Role.pm_TRNanme + "</td>");
        } else {
            var rname = "";
            $.each(bean.RoleFpList, function(i, data) {
                rname += data.Role.pm_TRNanme;
            });
            html.push("<td>" + bean.pm_UserName + "</td><td>" + rname + "</td><td><input type='checkbox' value=" + bean.pm_UserID + " /></td>");
        }
    });
    html = html.join('');
    $("#content").html(html);
}
function btnOkClick() {
    var id = $("#content").find("input[type='checkbox']");
    var dd;
    $.each(id, function(i, data) {
        if ($(data).attr('checked') == "checked") {
            if (i > 0) {
                $.message.alert("只能选择一个！");
                return dd;
            }
            dd = $(data).val();
        }
    });
    $("#pm_TPLeadH").val(dd);
}
function Save() {
    var sm = CKEDITOR.cs.getData();
    sm = encodeURI(sm);
    var params = "pm_TPFId=" + $("#pm_TPFId").val() + "&pm_TPName=" + $("#pm_TPName").val()
        + "&pm_TPLead=" + $("#pm_TPLead").val() + "&pm_TPJjfaName=" + $("#pm_TPJjfaName").val()
        + "&pm_TPVersion=" + $("#pm_TPVersion").val() + "&pm_TPCreateTime=" + $("#pm_TPCreateTime").val()
        + "&filePath=" + $("#filePath").val() + "&sm=" + sm;
    params = encodeURI(params);
    $.ajax({
        url: "/ProductManager/AddFun",
        data: params,
        type: 'post',
        async: false,
        success: function(res) {
            if (parseInt(res.State) == 1) {
                window.location.href = document.referrer;
            } else {
                $.message.alert(res.Msg);
            }
        }
    });
}


