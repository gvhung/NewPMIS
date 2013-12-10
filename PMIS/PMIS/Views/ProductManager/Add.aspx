<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Add</title>
    <link href="../../Scripts/Plugin/jquery.ajaxfileupload/ajaxfileupload.css"rel="stylesheet" type="text/css" />
    <link href="../../Scripts/Plugin/pickdate/skin/WdatePicker.css" rel="stylesheet"type="text/css" />
    <script src="../../Scripts/Plugin/ckeditor/ckeditor.js" type="text/javascript"></script>
    <script src="../../Scripts/Plugin/ckfinder/ckfinder.js" type="text/javascript"></script>
</head>
<body>
    
    <input type="hidden" id="pm_TPFId" name="pm_TPFId" value="<%=ViewData["Fid"] %>" />
    <div>
        <table>
            <tr>
                <th>项目名：</th><td><input type="text" id="pm_TPName" name="pm_TPName" /></td>
                <th>负责人：</th><td><input type="text" id="pm_TPLeadH"  onchange="IzXmEq()" />
                <input type="hidden" id="pm_TPLead" name="pm_TPLead"/>
                </td>
            </tr>
            <tr>
                <th>解决方案：</th><td><input type="text" id="pm_TPJjfaName" /></td>
                <th>版本号：</th><td><input type="text" id="pm_TPVersion" /></td>
            </tr>
            <tr>
                <th>创建时间：</th><td><input id="pm_TPCreateTime" type="text" onclick="WdatePicker()"/></td>
                <th>附件：</th><td colspan=""><img id="loading " src="../../Scripts/Plugin/jquery.ajaxfileupload/loading.gif" style="display:none;"/>
                                <input id="fileToUpload " type="file" size="20" name="fileToUpload " />
<a class="button" id="buttonUpload" onclick="ajaxFileUpload();">上传</a><input type="hidden" id="filePath"/></td>
                </tr>
                <tr>
                <th>说明：</th>
                <td colspan="3">
                    <textarea id="cs"></textarea>
                     <script type="text/javascript">
                         CKEDITOR.replace('cs');
                    </script>
                </td>
            </tr>
            <tr>
                <td><a class="easyui-linkbutton" iconcls="icon-save" href="javascript:void(0)" onclick="Save()">保存</a>
                    <a  class="easyui-linkbutton" iconcls="icon-cancel" onclick="location.href = document.referrer;">返回</a>
                </td>
            </tr>
        </table>
    </div>
    <div id="dlg" style="display: none">
        <div id="content"></div>
        <div><a id="Ok" class="easyui-linkbutton" iconcls="icon-save" onclick="btnOkClick()">确定</a><a  class="easyui-linkbutton" iconcls="icon-cancel" onclick="">关闭</a></div>
    </div>
      
</body>
<script src="../../Scripts/jquery-1.8.3.min.js" type="text/javascript"></script>
<script src="../../Scripts/Util/GetUrl.js" type="text/javascript"></script>
<script src="../../Scripts/Plugin/jquery.ajaxfileupload/ajaxfileupload.js"type="text/javascript"></script>
<script src="../../Scripts/Plugin/easyui/jquery.easyui.min.js" type="text/javascript"></script>
<script src="../../Scripts/Plugin/pickdate/WdatePicker.js" type="text/javascript"></script>
<script src="../../Scripts/View/ProductManager/add.js" type="text/javascript"></script>
</html>
