<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>欢迎登陆本系统</title>
    <link href="../../Scripts/Plugin/bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <center>
   <div class="container">
       <table >
           <tr><th>用户名：</th><td><input type="text" id="pm_UserName"/></td></tr>
           <tr><th>密  码：</th><td><input type="password" id="pm_UserPassword"/></td></tr>
           <tr><th>验证码：</th><td><input type="text" id="yzm"/><img id="yzmimg" alt="图片失败"/></td></tr>
           <tr><td><a class="btn" onclick="login()">登陆</a></td></tr>
       </table>

   </div>
   </center>
</body>
<script src="../../Scripts/jquery-1.8.3.min.js" type="text/javascript"></script>
<script src="../../Scripts/Util/GetUrl.js" type="text/javascript"></script>
<script src="../../Scripts/View/Login/index.js" type="text/javascript"></script>
<script src="../../Scripts/Plugin/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
</html>
