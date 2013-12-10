using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMIS.Controllers.Filter
{
    /// <summary>
    /// 权限拦截
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class AuthorizeFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            string path = filterContext.HttpContext.Request.Path.ToLower();
            if (path == "/" || path == "/Login/index".ToLower() || path == "/Login/GetValidateCode".ToLower()
               ||path == "/Login/LoginFun".ToLower())
            {
                return; //忽略权限判定
            }

            if (!CheckLogin(filterContext))
            {
                string rawUrl = filterContext.HttpContext.Request.RawUrl;
                string allUrl = filterContext.HttpContext.Request.Url.ToString();
                int index = allUrl.IndexOf(rawUrl);
                string url = allUrl.Substring(0, index);
                if (filterContext.HttpContext.Request.IsAjaxRequest()) //若为ajax请求手动写http状态 不可与现有http状态相同
                {
                    filterContext.HttpContext.Response.StatusCode = 499;

                }
                filterContext.Result = new ContentResult
                {
                    Content =
                        "<script language =\"javascript\" type =\"text/javascript\" >alert(\"登录超时!\");window.top.location.href = \"" +
                        url + "/Login/index\";</script>"
                };
            }
        }

        private bool CheckLogin(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["User"] == null)
              
            {
                return false;
            }

            return true;
        }
    }
}