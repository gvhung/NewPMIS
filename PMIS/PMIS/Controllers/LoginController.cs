using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMIS.BLL;
using PMIS.Comm;
using PMIS.Model;

namespace PMIS.Controllers
{
    public class LoginController : Controller
    {
        public IUserManager iUserManager { get; set; }
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetValidateCode()
        {
            ValidateCode v = new ValidateCode();
            string YhYzm = v.CreateValidateCode_WordAndNumber(4);
            Session["YhYzm"] = YhYzm;
            return File(v.CreateValidateGraphic(YhYzm), "image/jpeg");
        }

        public ActionResult LoginFun()
        {
            ReturnObj returnObj=new ReturnObj();
            try
            {
                String uName = Request.Params["Name"];
                String password = Request.Params["Password"];
                String Yzm = Request.Params["Yzm"];
                if (!Yzm.ToLower().Equals(Session["YhYzm"].ToString().ToLower()))
                {
                    returnObj.State = -1;
                    returnObj.Msg = "验证码输入错误！";
                    return Json(returnObj, JsonRequestBehavior.AllowGet);
                }
                PM_User user = iUserManager.GetUser(uName);
                if (user == null)
                {
                    returnObj.State = -1;
                    returnObj.Msg = "用户名不存在！";
                    return Json(returnObj, JsonRequestBehavior.AllowGet);
                }
                if (!user.pm_UserPassword.Equals(MD5Helper.ToString(password)))
                {
                    returnObj.State = -1;
                    returnObj.Msg = "密码错误请检查您的输入！";
                    return Json(returnObj, JsonRequestBehavior.AllowGet);
                }
                Session["User"] = user;
                returnObj.State = 1;
                returnObj.Msg = "Home/Index";
                return Json(returnObj, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exception)
            {
                returnObj.State= - 1;
                returnObj.Msg = "登陆遇到问题，请重试！";
                return Json(returnObj, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
