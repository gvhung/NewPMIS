<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>修改系统资源</title>
</head>
<body>
   <div>
        <center>
            <div>
                <input type="hidden" id="state" value="<%=((dynamic)ViewData["resource"]).FResource.pm_TRState %>"/>
                <input type="hidden" id="type" value="<%=((dynamic)ViewData["resource"]).FResource.pm_TRType %>"/>
                <form id="fromInfo" action="#" method="post">
                    <input type="hidden" id="pm_TReid" name="pm_TReid" value="<%=((dynamic)ViewData["resource"]).pm_TReid %>"/>
                <table>
                    <tr id="father">
                        <th>
                            父资源：
                        </th>
                        <td >
                            <input type="hidden" id="pm_TRFid" name="pm_TRFid" value="<%=((dynamic)ViewData["resource"]).pm_TRFid %>" />
                            <input id="fatherZy" readonly="readonly" value="<%=((dynamic)ViewData["resource"]).FResource.pm_TRName %>" />
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
                            <select id="pm_TRState" name="pm_TRState" >
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            资源名称：
                        </th>
                        <td>
                            <input id="pm_TRName" name="pm_TRName" type="text" value="<%=((dynamic)ViewData["resource"]).pm_TRName %>" />
                        </td>
                        <th>
                            资源路径：
                        </th>
                        <td>
                            <input type="text" id="pm_TRURL" name="pm_TRURL" value="<%=((dynamic)ViewData["resource"]).pm_TRURL %>" />
                        </td>
                    </tr>
                    <tr>
                        <th>图片：</th>
                        <%--<td><img id="pm_TRIMG" src="<%=((dynamic)ViewData["resource"]).pm_TRURL %>" alt="<%=((dynamic)ViewData["resource"]).pm_TRName %>"/></td>
                --%>    </tr>
                    <tr>
                        <td colspan="4" align="center">
                            <a href="javascript:void(0)" class="easyui-linkbutton" id="btnOk" onclick="btnOkClick();">保存</a> 
                            <a href="javascript:void(0)" class="easyui-linkbutton" id="A1" onclick="location.href = document.referrer;">返回</a>
                        </td>
                    </tr>
                </table>
                </form>
            </div>
        </center>
    </div>
</body>
<script src="<%= Url.Content("~/Scripts/jquery-1.8.3.min.js")%>" type="text/javascript"></script>
<script src="<%= Url.Content("~/Scripts/Util/GetUrl.js?t=20131118")%>" type="text/javascript"></script>
<script src="<%= Url.Content("~/Scripts/Util/Util.js?t=20131118")%>" type="text/javascript"></script>
<script src="<%= Url.Content("~/Scripts/View/Resource/modify.js?t=20131118")%>" type="text/javascript"></script>
</html>
