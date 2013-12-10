<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Create</title>
</head>
<body>
    <div>
     
        <fieldset>
            <legend>PM_BUG</legend>
            <table id="BugBean">
                <tr>
                    <th>ID:</th><td colspan="3"><input type="text" id="pm_ID"/></td>
                </tr>
                <tr>
                    <th>标题：</th><td colspan="3"><input type="text" id="pm_Title"/></td>
                </tr>
                <tr>
                    <th>产品名称：</th><td colspan="3"><input type="text" id="pm_PrName"/><input type="hidden" id="pm_PID"/></td>
                </tr>
                <tr>
                    <th>主功能模块名：</th><td><input type="text" id="MainMoud"/></td>
                    <th>子功能模块名：</th><td><input type="text" id="pm_MID"/></td>
                </tr>
                <tr>
                    <th>产品版本：</th><td><input type="text" readonly="readonly" id="pm_Ver"/></td>
                    <th>测试环境：</th><td><input type="text" id="pm_Cshj"/></td>
                </tr>
                <tr>
                    <th>测试人员：</th><td><input type="text" readonly="readonly" id="Csry"/><input type="hidden" id="pm_CsrId"/></td>
                    <th>BUG状态：</th><td><select id="pm_Zt"></select></td>
                </tr>
                <tr>
                    <th>前提条件：</th><td colspan="3"><input type="text" id="pm_Qttj"/></td>
                </tr>
                <tr>
                    <th>BUG严重程度：</th><td colspan="3"><select id="pm_Yzcd"></select></td>
                </tr>
                <tr>
                    <th>问题优先级：</th><td colspan="3"><select id="pm_Yxj"></select></td>
                </tr>
                <tr>
                    <th>操作步骤：</th><td colspan="3"><textarea id="pm_Czbz"></textarea></td>
                </tr>
                <tr>
                    <th>实际结果：</th><td colspan="3"><textarea id="pm_Sjjg"></textarea></td>
                </tr>
                   <tr>
                    <th>期望结果：</th><td colspan="3"><textarea id="pm_Qwjg"></textarea></td>
                </tr>
                <tr>
                    <th>出现频率：</th><td colspan="3"><select id="pm_Cxpl"></select></td>
                </tr>
                <tr>
                    <th>文字注释和附图：</th><td colspan="3"><textarea id="pm_Bz"></textarea>
                    <script type="text/javascript">
                        CKEDITOR.replace('pm_Bz');
                    </script>
                    </td>
                </tr>
            </table>
          
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.pm_Lead) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.pm_Lead) %>
                <%: Html.ValidationMessageFor(model => model.pm_Lead) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.pm_Pc) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.pm_Pc) %>
                <%: Html.ValidationMessageFor(model => model.pm_Pc) %>
            </div>
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>
   
    </div>
</body>
</html>
