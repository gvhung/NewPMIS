$(function() {
    myLib.progressBar();
    loadResource();
});
$(window).load(function () {
    myLib.stopProgress();
     var lrBarIconData = {
        'app0': {
            'title': '17素材网',
            'url': 'http://www.17sucai.com/',
            'winWidth': 1100,
            'winHeight': 650
        },
        'app1': {
            'title': 'jQuery特效',
            'url': 'http://www.17sucai.com/',
            'winWidth': 1100,
            'winHeight': 650
        },
        'app2': {
            'title': 'javascript特效',
            'url': 'http://www.17sucai.com/',
            'winWidth': 1100,
            'winHeight': 650
        },
        'app3': {
            'title': '资源分享',
            'url': 'ziyuan.html',
            'winWidth': 1100,
            'winHeight': 650
        }
    };
    //存储桌面布局元素的jquery对象
    myLib.desktop.desktopPanel();

    //初始化桌面背景
    myLib.desktop.wallpaper.init("/Scripts/Plugin/windows/images/blue_glow.jpg");

    //初始化任务栏
    myLib.desktop.taskBar.init();

    //初始化桌面图标
    myLib.desktop.deskIcon.init(deskDataStr);

    //初始化桌面导航栏
    myLib.desktop.navBar.init();

    //初始化侧边栏
    myLib.desktop.lrBar.init(lrBarIconData);

    //欢迎窗口
    myLib.desktop.win.newWin({
        WindowTitle: '欢迎窗口',
        iframSrc: "/Resource/Index",
        WindowsId: "welcome",
        WindowAnimation: 'none',
        WindowWidth: 740,
        WindowHeight: 520
    });

});

var deskDataStr ="";
var topRe = new Array();
var reAll;
function loadResource() {
    $.ajax({
        url: GetUrl() + "Home/GetResource",
        data: '',
        async: false,
        type: 'post',
        success: function (res) {
            if (res != null) {
                //reAll = res;
                var htm = "";
                var html = "";
                var n = 0;
                deskDataStr += "{";
                $.each(res, function (i, list) {
                    var currTab = "";
                    var currDesk = "";
                    if (i == 0) {
                        currTab = "currDesktop";
                        currDesk = "deskIcon currDesktop";
                    } else {
                        currTab = "";
                        currDesk = "deskIcon";
                    }
                    htm += "<a class='" + currTab + "' href='#' title='" + list.pm_TRName + "'></a>";
                    topRe.push(list.pm_TRName);
                    html += "<ul class='" + currDesk + "'>";
                    $.each(list.children, function (m, ch) {
                        html += "<li class='desktop_icon' id='" + ch.pm_TRpysx + "'><span class='icon'><img src='" + ch.pm_TRIMG + "'/></span><div class='text'>" + ch.pm_TRName + "<s></s></div>";
                        if (n == 0) {
                            deskDataStr += "'"+
                            ch.pm_TRpysx + "':{'title':'" + ch.pm_TRName + "','url':'" + ch.pm_TRURL + "','winWidth':930,'winHeight':500}";
                        } else {
                            deskDataStr += ",'" + ch.pm_TRpysx + "':{'title':'" + ch.pm_TRName+ "','url':'"+ ch.pm_TRURL+ "','winWidth':930,'winHeight':500}";
                        }
                        n++;
                    });
                    html += "</ul>";
                });
                deskDataStr += "}";
                deskDataStr = eval('('+deskDataStr+')');
                $("#navBar").html(htm);
                $("#desktopInnerPanel").html(html);
               
            }
        }
    });
}	