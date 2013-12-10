$(function () {
    InitData();
});
function InitData() {
    InitGridData();
}

function InitGridData() {
    $('#grid').datagrid({
        title: '系统资源',
        iconCls: 'icon-save',
        nowrap: false,
        striped: true,
        url: '/RoleManager/GetRolePage',
        remoteSort: true,
        fitColumns: true,
        fit: true,
        idField: 'ID',
        frozenColumns: [[
	                { field: 'ID', checkbox: true }
				]],

        columns: [[
                    { field: 'pm_TRNanme', title: '角色名称', width: 80 },
                    { field: 'pm_TRBz', title: '备注', width: 80, align: 'right' },
                    { field: 'pm_TRState', title: '状态', width: 80, align: 'right' }
                ]],
        pagination: true,
        rownumbers: true,
        toolbar: '#toolbar'
    });
}
function add() {
    var row = $("#grid").datagrid('getSelected');
    if (row) {
        window.location.href = "/Resource/AddPage?Fid=" + row.pm_TRId;
    } else {
        window.location.href = "/Resource/AddPage?Fid=0";
    }
}

function update() {
    var row = $('#grid').datagrid('getSelected');
    if (row) {
        window.location.href = "/Resource/ModifyPage?id=" + row.pm_TRId;
        return false;
    }
    else {
        $.messager.alert('提示', '请选择要修改的数据');
        return false;
    }
}

function deleted() {
    var rows = $('#grid').datagrid('getSelections');
    if (!rows || rows.length == 0) {
        $.messager.alert('提示', '请选择要删除的数据');
        return;
    }
    var parm;
    $.each(rows, function (i, n) {
        if (i == 0) {
            parm = "idList=" + n.pm_TReid;
        }
        else {
            parm += "&idList=" + n.pm_TReid;
        }
    });
    $.messager.confirm('提示', '是否删除这些数据?', function (r) {
        if (!r) {
            return;
        }

        $.ajax({
            type: "POST",
            url: "/UserInfo/Delete/",
            data: parm,
            success: function (msg) {
                if (msg.IsSuccess) {
                    $.messager.alert('提示', '删除成功！', "info", function () {
                        $('#grid').datagrid("reload");
                    });
                }
            },
            error: function () {
                $.messager.alert('错误', '删除失败！', "error");
            }
        });
    });
}

function GoReFp() {
    var rows = $('#grid').datagrid('getSelections');
    if (!rows || rows.length == 0) {
        $.messager.alert('提示', '请选择要删除的数据');
        return;
    } else {
        window.location.href = GetUrl() + 'RoleManager/ReFpToRole?Id=' + rows[0].pm_TRId;
    }
}