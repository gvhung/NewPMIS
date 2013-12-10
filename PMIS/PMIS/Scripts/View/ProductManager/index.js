$(function () {
    InitData();
});
function InitData() {
    //InitGridData();
}
function SearchInit() {
    //var data = Search();
    $("#grid").datagrid('load', {
        pm_TPJjfaName: $("#pm_TPJjfaName").val(),
        pm_TPName: $("#pm_TPName").val(),
        pm_TPLead: $("#pm_TPLead").val(),
        pm_TPAddtime: $("#pm_TPAddtime").val()
    });
}
function InitGridData() {
    $('#grid').datagrid({
        title: '系统资源',
        iconCls: 'icon-save',nowrap: false,
        striped: true,
        url: '/ProductManager/GetProductPage',
        remoteSort: true,
        fitColumns: true,
        fit: true,
        idField: 'ID',
        frozenColumns: [[
	                { field: 'pm_TPId', checkbox: true }
				]],
        columns: [[
                    { field: 'pm_TPName', title: '项目', width: 80 }
                    , { field: 'pm_TPJjfaName', title: '解决方案', width: 80, align: 'right' }
                    , { field: 'pm_TPVersion', title: '版本', width: 80, align: 'right' }
                    ,{ field: 'pm_TPLead', title: '负责人', width: 80, align: 'right' }
                    ,{ field: 'pm_TPAddtime', title: '添加时间', width: 80, align: 'right' }
                    , { field: 'pm_TPState', title: '状态', width: 80, align: 'right' }
                 
                ]],
        pagination: true,rownumbers: true,toolbar: '#toolbar'
    });
}

function btnDelete() {
    var rows = $('#grid').datagrid('getSelections');
    if (!rows || rows.length == 0) {
        $.messager.alert('提示', '请选择要删除的数据');
        return;
    }
    var parm;
    $.each(rows, function(i, n) {
        if (i == 0) {
            parm = "idList=" + n.pm_TPId;
        } else {
            parm += "&idList=" + n.pm_TPId;
        }
    });
    $.messager.confirm('提示', '是否删除这些数据?', function(r) {
        if (!r) {
            return;
        }

        $.ajax({
            type: "POST",
            url: "/ProductManager/Delete/",
            data: parm,
            success: function(msg) {
                if (msg.IsSuccess) {
                    $.messager.alert('提示', '删除成功！', "info", function() {
                        $('#grid').datagrid("reload");
                    });
                }
            },
            error: function() {
                $.messager.alert('错误', '删除失败！', "error");
            }
        });
    });
}

function btnUpdate() {
    var row = $('#grid').datagrid('getSelected');
    if (row) {
        window.location.href = "/ProductManager/ModifygPage/" + row.pm_TPId;
    } else {
        $.messager.alert('提示', '请选择要修改的数据');
        return;
    }
}

function btnSave() {
    var row = $("#grid").datagrid('getSelected');
    if (row) {
        window.location.href = "/ProductManager/Add?Fid=" + row.pm_TPFId;
    } else {
        window.location.href = "/ProductManager/Modify?Fid=0";
    }
}