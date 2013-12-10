<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Index</title>
    <link href="../../Scripts/Plugin/easyui/themes/metro/easyui.css" rel="stylesheet"type="text/css" />
    <link href="../../Scripts/Plugin/easyui/themes/icon.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div>
        <div id="toolbar">
            <div>
                <div>
                    <label>
                        项 目：</label><input type="text" id="pm_TPName" /><label>解决方案名：</label>
                        <input type="text"id="pm_TPJjfaName" /></div>
                <div>
                    <label>
                        负责人：</label><input type="text" id="pm_TPLead" /><label>创 建时 间：</label>
                        <input type="text"id="pm_TPAddtime" /></div>
                <div>
                    <a id="Search" class="easyui-linkbutton" iconcls="icon-search" onclick="SearchInit()">查询</a> <a id="Add" class="easyui-linkbutton" iconcls="icon-add" onclick="btnSave()">添加</a>
                     <a id="Update" class="easyui-linkbutton" iconcls="icon-save" onclick="btnUpdate()">修改</a> <a id="Delete" class="easyui-linkbutton" iconcls="icon-cut" onclick="btnDelete()">删除</a>
                </div>
            </div>
        </div>
        <div region="center" style="padding: 5px;" border="false">
            <table id="grid">
            </table>
        </div>
    </div>
</body>
<script src="../../Scripts/jquery-1.8.3.min.js" type="text/javascript"></script>
<script src="../../Scripts/View/ProductManager/index.js" type="text/javascript"></script>
<script src="../../Scripts/Plugin/easyui/jquery.easyui.min.js" type="text/javascript"></script>
</html>
