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
        url: '/UserManager/GetUserPager',
        remoteSort: true,
        fitColumns: true,
        fit: true,
        idField: 'ID',
        frozenColumns: [[
	                { field: 'ID', checkbox: true }
				]],

        columns: [[
                    { field: 'pm_UserName', title: '姓名', width: 80 },
                    { field: 'pm_UserLogin', title: '登陆名', width: 80, align: 'right' },
                    { field: 'pm_State', title: '状态', width: 80, align: 'right' }
                ]],
        pagination: true,
        rownumbers: true,
        toolbar: ['-', {
            id: 'btnSave',
            text: '添加',
            iconCls: 'icon-add',
            handler: function () {
                var row = $("#grid").datagrid('getSelected');
                if (row) {
                    window.location.href = "/Resource/AddPage?Fid=" + row.pm_TReid;
                } else {
                    window.location.href = "/Resource/AddPage?Fid=0";
                }
            }
        }, '-', {
            id: 'btnUpdate',
            text: '修改',
            iconCls: 'icon-save',
            handler: function () {

                var row = $('#grid').datagrid('getSelected');
                if (row) {
                    window.location.href = "/UserInfo/View/" + row.ID;
                }
                else {
                    $.messager.alert('提示', '请选择要修改的数据');
                    return;
                }

            }
        }, '-', {
            id: 'btnDelete',
            text: '删除',
            disabled: false,
            iconCls: 'icon-cut',
            handler: function () {

                var rows = $('#grid').datagrid('getSelections');
                if (!rows || rows.length == 0) {
                    $.messager.alert('提示', '请选择要删除的数据');
                    return;
                }
                var parm;
                $.each(rows, function (i, n) {
                    if (i == 0) {
                        parm = "idList=" + n.ID;
                    }
                    else {
                        parm += "&idList=" + n.ID;
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
        }, '-']
    });
}