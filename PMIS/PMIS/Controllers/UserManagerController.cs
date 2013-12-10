using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMIS.BLL;
using PMIS.BLL.Impl;
using PMIS.Comm;
using PMIS.Model;

namespace PMIS.Controllers
{
    public class UserManagerController : BaseController
    {
        public IUserManager iUserManager { get; set; }

        //
        // GET: /UserRegister/

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult ModifyUser()
        {
            return View();
        }

        public ActionResult LoadUserAll()
        {
           var list= iUserManager.LoadAll();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RegisterFun()
        {
            ReturnObj returnObj=new ReturnObj();

            try
            {
                PM_User pmUser = this.GetPMUserForPage();
                iUserManager.Save(pmUser);
                returnObj.State = 1;
                returnObj.Msg = "注册成功！";
            }
            catch (Exception ex)
            {

                returnObj.State = -1;
                returnObj.Msg = ex.Message;
            }
            return Json(returnObj, JsonRequestBehavior.AllowGet);
        }

        private PM_User GetPMUserForPage()
        {
            PM_User pmUser = new PM_User();
            pmUser.pm_State = "0";
            pmUser.pm_UserLogin = Request.Params["pm_UserLogin"];
            pmUser.pm_UserName = Request.Params["pm_UserName"];
            pmUser.pm_UserPassword = Request.Params["pm_UserPassword"];
            pmUser.pm_UserPassword = MD5Helper.ToString(pmUser.pm_UserPassword);
           
            return pmUser;
        }

        public ActionResult GetUserPager(int page, int rows)
        {
            Pager<PM_User> pager = new Pager<PM_User>();
            try
            {
                pager = this.iUserManager.FinPager(null, page, rows);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                pager = new Pager<PM_User>();
            }
            return Json(pager, JsonRequestBehavior.AllowGet);
        }

    }
}
