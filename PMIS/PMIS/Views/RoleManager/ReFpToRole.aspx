<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>ReFpToRole</title>
    <link href="<%= Url.Content("~/Scripts/Plugin/easyui/themes/metro/easyui.css")%>" rel="stylesheet"type="text/css" />
    <link href="<%= Url.Content("~/Scripts/Plugin/easyui/themes/icon.css")%>" rel="stylesheet" type="text/css" />
</head>
<body class="easyui-layout">
    <input type="hidden" id="Id" value="<%=ViewData["Id"] %>"/>
<div id="toolbar">
        
    </div>
    <div region="center" style="padding: 5px;" border="false">
        <table id="datatree"></table>
    </div>
</body>
<script src="<%= Url.Content("~/Scripts/jquery-1.8.3.min.js")%>" type="text/javascript"></script>
<script src="<%= Url.Content("~/Scripts/Util/GetUrl.js?t=20131125")%>" type="text/javascript"></script>
<script src="<%= Url.Content("~/Scripts/View/RoleManager/refptorole.js?=20131125")%>" type="text/javascript"></script>
<script src="<%= Url.Content("~/Scripts/Plugin/easyui/jquery.easyui.min.js?t=20131118")%>" type="text/javascript"></script>
</html>