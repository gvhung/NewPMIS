$(function() {
    InitDataGridTree();
});
function InitData() {
    $.ajax({        
       utl:GetUrl()+"RoleManager/",
       data:'',
       type:'post',
       async:false,
       success:function(res) {
           if (res.count > 0) {
               InitDataGridTree(res);
           }
       }
    });
}
function InitDataGridTree() {
    $("#datatree").treegrid({
        url: GetUrl() + "RoleManager/GetYfpZy?Id="+$("#Id").val(),
        idField: 'pm_TReid',
        rownumbers:true,
        treeField: 'pm_TRName',       
        columns: [[
                    { title: '资源名称', field: 'pm_TRName', width: 300 },
                    { field: 'pm_TRURL', title: '资源路径', width: 150 },
                    { field: 'pm_TRType', title: '资源类型', width: 170 },
                    { field: 'pm_TRState', title: '资源状态', width: 160 }
                 ]],toolbar:"#toolbar"
    });
}
