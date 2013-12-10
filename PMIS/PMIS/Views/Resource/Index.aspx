<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>系统资源管理</title>
    <link href="<%= Url.Content("~/Scripts/Plugin/easyui/themes/metro/easyui.css")%>" rel="stylesheet"type="text/css" />
    <link href="<%= Url.Content("~/Scripts/Plugin/easyui/themes/icon.css")%>" rel="stylesheet" type="text/css" />
</head>
<body class="easyui-layout">
    <div id="toolbar" class="easy-layout" style="padding: 5px; height: auto">
              <div region="north" style="overflow: hidden">
                <div>
                   <%-- <a id="Search" class="easyui-linkbutton" iconcls="icon-search" onclick="SearchInit()">查询</a>--%> <a id="Add" class="easyui-linkbutton" iconcls="icon-add" onclick="add()">添加</a>
                     <a id="Update" class="easyui-linkbutton" iconcls="icon-save" onclick="update()">修改</a> <a id="Delete" class="easyui-linkbutton" iconcls="icon-cut" onclick="deleted()">删除</a>
                </div>
            </div>
        </div>
    <div region="center" style="padding: 5px;" border="false">
        <table id="grid">
        </table>
    </div>
</body>
<script src="<%= Url.Content("~/Scripts/jquery-1.8.3.min.js")%>" type="text/javascript"></script>
<script src="<%= Url.Content("~/Scripts/View/Resource/index.js?t=20131118")%>" type="text/javascript"></script>
<script src="<%= Url.Content("~/Scripts/Plugin/easyui/jquery.easyui.min.js?t=20131118")%>" type="text/javascript"></script>
</html>
