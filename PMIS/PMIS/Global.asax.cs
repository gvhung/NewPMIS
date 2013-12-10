using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Spring.Web.Mvc;

namespace PMIS
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : SpringMvcApplication
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            base.Application_Start(sender, e);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            if (this.Server.GetLastError() == null)
            {
                return;
            }

            Exception ex = this.Server.GetLastError().GetBaseException();
            StringBuilder sb = new StringBuilder();

            sb.Append(ex.Message);
            sb.Append("\r\nSOURCE: " + ex.Source);
            if (Request.Form != null)
            {
                sb.Append("\r\nFORM: " + this.Request.Form.ToString());
            }
            if (Request.QueryString != null)
            {
                sb.Append("\r\nQUERYSTRING: " + this.Request.QueryString.ToString());
            }

            sb.Append("\r\n引发当前异常的原因: " + ex.TargetSite);
            sb.Append("\r\n堆栈跟踪: " + ex.StackTrace);
          Console.WriteLine(sb.ToString());

            var key = System.Configuration.ConfigurationManager.AppSettings["IsDebug"];
            bool isDebug;
            if (!bool.TryParse(key, out isDebug) || !isDebug)
            {
                this.Server.ClearError();
            }
        }
    }
}