<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>添加系统资源</title>
     <link href="../../Scripts/Plugin/easyui/themes/default/easyui.css" rel="stylesheet"type="text/css" />
    <link href="../../Scripts/Plugin/easyui/themes/icon.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div>
        <center>
            <div>
                <form id="fromInfo" action="#" method="post">
                <table>
                    <tr id="father">
                        <th>
                            父资源：
                        </th>
                        <td >
                            <input type="hidden" id="pm_TRFid" name="pm_TRFid" value="<%=ViewData["Fid"] %>" />
                            <input id="fatherZy" readonly="readonly" />
                        </td>
                    </tr>
                    <tr>
                        <th>
                            资源类型：
                        </th>
                        <td>
                            <select id="pm_TRType" name="pm_TRType">
                            </select>
                        </td>
                        <th>
                            资源状态：
                        </th>
                        <td>
                            <select id="pm_TRState" name="pm_TRState">
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            资源名称：
                        </th>
                        <td>
                            <input id="pm_TRName" name="pm_TRName" type="text" />
                        </td>
                        <th>
                            资源路径：
                        </th>
                        <td>
                            <input type="text" id="pm_TRURL" name="pm_TRURL" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" align="center">
                            <a href="javascript:void(0)" class="easyui-linkbutton" id="btnOk" onclick="btnOkClick();">
                                保存</a> <a href="javascript:void(0)" class="easyui-linkbutton" id="A1" onclick="location.href = document.referrer;">
                                    返回</a>
                        </td>
                    </tr>
                </table>
                </form>
            </div>
        </center>
    </div>
</body>
<script src="../../Scripts/jquery-1.8.3.min.js" type="text/javascript"></script>
<script src="../../Scripts/Plugin/jquery-form.js" type="text/javascript"></script>
<script src="../../Scripts/Util/GetUrl.js" type="text/javascript"></script>
<script src="../../Scripts/Util/Util.js" type="text/javascript"></script>
<script src="../../Scripts/View/Resource/add.js" type="text/javascript"></script>
<script src="../../Scripts/Plugin/easyui/jquery.easyui.min.js" type="text/javascript"></script>
</html>
