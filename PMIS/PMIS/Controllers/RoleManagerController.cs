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
    public class RoleManagerController : BaseController
    {
        public IRoleManager iRoleManager { get; set; }

        public IResourceManager iResourceManager { get; set; }

        #region 角色相关

        public ActionResult RoleIndex()
        {
            return View();
        }

        public ActionResult AddRole()
        {
            return View();
        }

        public ActionResult ModifyRole()
        {
            return View();
        }

        public ActionResult GetRolePage()
        {
            Pager<PM_Role> pager=new Pager<PM_Role>();
            try
            {
                int page = Convert.ToInt16(Request.Params["page"]);
                int rows = Convert.ToInt16(Request.Params["rows"]);
                String pm_TRNanme = Request.Params["pm_TRNanme"];
                Dictionary<String,Object> di=null;
                if (!string.IsNullOrEmpty(pm_TRNanme))
                {
                    di=new Dictionary<string, object>();
                     di.Add("pm_TRNanme",pm_TRNanme);
                }

               pager= iRoleManager.FinPager(di, page, rows);
            }
            catch (Exception)
            {
                pager = new Pager<PM_Role>();
            }
            return Json(pager, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 权限相关
        public ActionResult ReFpToRole()
        {
            ViewData["Id"] = Request.Params["Id"];
            return View();
        }

        public ActionResult GetYfpZy()
        {
            IList<PM_Resource> list = new List<PM_Resource>();
            try
            {
                int id =Convert.ToInt16(Request.Params["Id"]);
                PM_Role role= iRoleManager.Get(id);
                //list = role.ReFpList;
                foreach (var pmResource in role.ReFpList)
                {
                    list.Add(pmResource.Resource);
                }
              list=iResourceManager.GetResourceTrddList(list);
            }
            catch
            {
                list=new List<PM_Resource>();
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        #endregion

    }
}
