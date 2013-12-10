<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>AddUser</title>
</head>
<body>
   <div>
        <table>
            <tr>
               <th>姓    名：</th> <td><input type="text" id="pm_UserName"/></td>
            </tr>
            <tr>
                <th>用 户 名：</th><td><input type="text" id="pm_UserLogin"/></td>
            </tr>
            <tr>
                 <th>密    码：</th><td><input type="password" id="pm_UserPassword"/></td>
            </tr>
              <tr>
                <th>状  态：</th><td><select id="State"></select></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center"><input type="button" id="btnOk" onclick="Save();" value="添加"/></td>
                <script type="text/javascript">
                    function Save() {
                        $.ajax({
                            url: GetUrl() + "UserManager/RegisterFun",
                            data: "pm_UserLogin=" + $("#pm_UserLogin").val() + "&pm_UserName=" + $("#pm_UserName").val() + "&pm_UserPassword=" + $("#pm_UserPassword").val()+"&pm_State="+$("#State").val(),
                            type: 'post',
                            async: false,
                            success: function (res) {
                                if (parseInt(res.State) == 1) {
                                    window.location.href = GetUrl() + res.Msg;
                                } else {
                                    alert(res.Msg);
                                }
                            }
                        });
                    }
                </script>
            </tr>
        </table>
    </div>
</body>
</html>
