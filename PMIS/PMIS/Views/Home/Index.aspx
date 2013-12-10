<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
	<title>项目管理系统</title>
    <script src="../../Scripts/Plugin/windows/jquery-1.7.1.min.js" type="text/javascript"></script>
    <link href="../../Scripts/Plugin/windows/css/desktop.css" rel="stylesheet" type="text/css" />
    <link href="../../Scripts/Plugin/windows/css/jquery-ui-1.8.18.custom.css" rel="stylesheet"
        type="text/css" />
    <link href="../../Scripts/Plugin/windows/css/smartMenu.css" rel="stylesheet" type="text/css" />
    <script src="../../Scripts/Plugin/windows/myLib.js" type="text/javascript"></script>
    <script src="../../Scripts/Util/GetUrl.js" type="text/javascript"></script>
<script src="../../Scripts/View/Home/Index.js" type="text/javascript"></script>
    <script src="../../Scripts/Plugin/windows/jquery-ui-1.8.18.custom.min.js" type="text/javascript"></script>
    <script src="../../Scripts/Plugin/windows/jquery.winResize.js" type="text/javascript"></script>
    <script src="../../Scripts/Plugin/windows/jquery-smartMenu-min.js" type="text/javascript"></script>
    <script src="../../Scripts/Plugin/windows/desktop.js" type="text/javascript"></script>
<script type="text/javascript">
</script>
</head>
<body>

<div id="wallpapers"></div>

<div id="navBar"><a href="#" class="currTab" title="桌面1"></a><a href="#"  title="桌面2"></a><a href="#"  title="桌面3"></a><a href="#"  title="桌面4"></a></div>

<div id="desktopPanel">
	<div id="desktopInnerPanel">
		<ul class="deskIcon currDesktop">
			<li class="desktop_icon" id="leshiwang"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon4.png"/></span><div class="text">乐视网<s></s></div></li>
			<li class="desktop_icon" id="Pixlr"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon6.png"/></span><div class="text">Pixlr<s></s></div></li>
			<li class="desktop_icon" id="dubianFim"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon7.png"/></span><div class="text">豆瓣FIM<s></s></div></li>
			<li class="desktop_icon" id="kuwoMusic"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon8.png"/></span><div class="text">酷我音乐盒<s></s></div></li>
			<li class="desktop_icon" id="qidian"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon9.png"/></span><div class="text">起点中文<s></s></div></li>
			<li class="desktop_icon" id="hudong"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon10.png"/></span><div class="text">互动百科<s></s></div></li>
			<li class="desktop_icon" id="qianqianMusic"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon5.png"/></span><div class="text">千千音乐<s></s></div></li>
			<li class="desktop_icon add_icon"><span class="icon"><img src="/Scripts/Plugin/windows/images/add_icon.png"/></span><div class="text">添加<s></s></div></li>
		</ul>
		<ul class="deskIcon">
			<li class="desktop_icon" id="zfMeishi"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon13.png"/></span><div class="text">主妇美食<s></s></div></li>
			<li class="desktop_icon" id="mglvyou"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon12.png"/></span><div class="text">芒果旅游<s></s></div></li>
			<li class="desktop_icon" id="taobao"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon14.png"/></span><div class="text">淘宝网<s></s></div></li>
			<li class="desktop_icon" id="qingshu"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon15.png"/></span><div class="text">情书<s></s></div></li>
			<li class="desktop_icon" id="fenghuang"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon16.png"/></span><div class="text">凤凰网<s></s></div></li>
			<li class="desktop_icon" id="zhongguancun"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon17.png"/></span><div class="text">中关村在线<s></s></div></li>
			<li class="desktop_icon add_icon"><span class="icon"><img src="/Scripts/Plugin/windows/images/add_icon.png"/></span><div class="text">添加<s></s></div></li>
		</ul>
		<ul class="deskIcon">
			<li class="desktop_icon" id="win35"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon18.png"/></span><div class="text">搜狐汽车<s></s></div></li>
			<li class="desktop_icon" id="win36"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon19.png"/></span><div class="text">布丁电影票<s></s></div></li>
			<li class="desktop_icon" id="win37"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon8.png"/></span><div class="text">中国数学资源网<s></s></div></li>
			<li class="desktop_icon add_icon"><span class="icon"><img src="/Scripts/Plugin/windows/images/add_icon.png"/></span><div class="text">添加<s></s></div></li>
		</ul>
		<ul class="deskIcon">
			<li class="desktop_icon" id="win38"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon20.png"/></span><div class="text">火影忍者漫画动画<s></s></div></li>
			<li class="desktop_icon" id="win39"><span class="icon"><img src="/Scripts/Plugin/windows/icon/icon21.png"/></span><div class="text">潇湘书院<s></s></div></li>
			<li class="desktop_icon add_icon"><span class="icon"><img src="/Scripts/Plugin/windows/images/add_icon.png"/></span><div class="text">添加<s></s></div></li>
		</ul>
	</div>
</div><!--desktopPanel end-->

<div id="taskBarWrap">
	<div id="taskBar">
		<div id="leftBtn"><a href="#" class="upBtn"></a></div>
		<div id="rightBtn"><a href="#" class="downBtn"></a></div>
		<div id="task_lb_wrap"><div id="task_lb"></div></div>
	</div>
</div><!--taskBarWrap end-->

<div id="lr_bar">
	<ul id="default_app">
		<li id="app0"><span><img src="/Scripts/Plugin/windows/icon/icon1.png" title="我的博客"/></span><div class="text">我的博客<s></s></div></li>
		<li id="app1"><span><img src="/Scripts/Plugin/windows/icon/icon2.png" title="关于我"/></span><div class="text">关于我<s></s></div></li>
		<li id="app2"><span><img src="/Scripts/Plugin/windows/icon/icon3.png" title="作品"/></span><div class="text">作品<s></s></div></li>
		<li id="app3"><span><img src="/Scripts/Plugin/windows/icon/icon11.png" title="资源分享"/></span><div class="text">资源分享<s></s></div></li>
	</ul>
	
	<div id="default_tools"><span id="showZm_btn" title="全屏"></span><span id="shizhong_btn" title="时钟"></span><span id="weather_btn" title="天气"></span><span id="them_btn" title="主题"></span></div>
	
	<div id="start_block">
		<a title="开始" id="start_btn"></a>
		<div id="start_item">
			<ul class="item admin">
				<li><span class="adminImg"></span> jsfoot</li>
			</ul>
			<ul class="item">
				<li><span class="sitting_btn"></span>系统设置</li>
				<li><span class="help_btn"></span>使用指南 <b></b></li>
				<li><span class="about_btn"></span>关于我们</li>
				<li><span class="logout_btn"></span>退出系统</li>
			</ul>
		</div>
	</div>
	
</div><!--lr_bar end-->
	
</body>
</html>
