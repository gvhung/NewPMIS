<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>职员管理</title>
 <link href="../../Scripts/Plugin/easyui/themes/default/easyui.css" rel="stylesheet"type="text/css" />
    <link href="../../Scripts/Plugin/easyui/themes/icon.css" rel="stylesheet" type="text/css" />
</head>
<body class="easyui-layout">
    <div region="center" style="padding: 5px;" border="false">
        <table id="grid">
        </table>
    </div>
</body>
<script src="../../Scripts/jquery-1.8.3.min.js" type="text/javascript"></script>
<script src="../../Scripts/View/UserManager/index.js" type="text/javascript"></script>
<script src="../../Scripts/Plugin/easyui/jquery.easyui.min.js" type="text/javascript"></script>
</html>
