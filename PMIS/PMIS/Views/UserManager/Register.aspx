<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>注册用户</title>
<script src="../../Scripts/jquery-1.8.3.min.js" type="text/javascript"></script>
<script src="../../Scripts/Util/GetUrl.js" type="text/javascript"></script>
<script src="../../Scripts/View/UserManager/Register.js" type="text/javascript"></script>
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
                <th>密码确认：</th><td><input type="password" id="Password1"/></td>
            </tr>  
               <tr>
                <th>验证码：</th><td><input type="text" id="yzm"/><img src="" id="yzmimg" alt="验证码出错"/></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center"><input type="button" id="btnOk" onclick="Save();" value="注册"/></td>
                <script type="text/javascript">
                    function Save() {
                        $.ajax({
                            url: GetUrl() + "UserManager/RegisterFun",
                            data: "pm_UserLogin=" + $("#pm_UserLogin").val() + "&pm_UserName=" + $("#pm_UserName").val() + "&pm_UserPassword=" + $("#pm_UserPassword").val(),
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
