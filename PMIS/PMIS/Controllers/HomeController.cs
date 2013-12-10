using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMIS.Comm;
using PMIS.BLL;
using PMIS.Model;

namespace PMIS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public IUserManager iUserManager { get; set; }

        public IResourceManager iResourceManager { get; set; }

        public  IRoleFpManager iRoleFpManager { get; set; }

        public  IRoleManager iRoleManager { get; set; }



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetResource()
        {
            PM_User user =  Session["User"] as PM_User ;
            int pm_UserId = user.pm_UserID;
            IList<PM_Role> listRole = iRoleManager.GetRoleList(pm_UserId);
            if (listRole == null || listRole.Count < 1)
            {
                ReturnObj returnObj=new ReturnObj();
                returnObj.State = -1;
                returnObj.Msg="您的访问权限出现问题请联系管理员！";
                return Json(returnObj, JsonRequestBehavior.AllowGet);
            }
            IList<PM_Resource> listResource = iResourceManager.GetResource(listRole);
            return Json(listResource, JsonRequestBehavior.AllowGet);
        }
        

    }
}
