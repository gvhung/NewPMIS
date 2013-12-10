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
    public class BugManagerController : Controller
    {
        //
        // GET: /BugManager/
        public IBugManager iBugManager { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(String id)
        {
            PM_BUG bug = iBugManager.Get(id);
            ViewData.Model = bug;
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Save(PM_BUG Bug)
        {
            var user = iBugManager.Get(Bug.pm_ID);
            if (user == null)
            {
                iBugManager.Save(Bug);
            }
            else
            {
                iBugManager.Save(Bug);
            }

            iBugManager.Save(Bug);
            return Json(new {IsSuccess = true, Message = "保存成功！"});
        }

        public ActionResult Delete(String id)
        {
            var user = iBugManager.Get(id);
            if (user != null)
            {
                user.pm_Zt = "10";//软删除
                iBugManager.Update(user);
            }
            else
            {
                return Json(new {IsSuccess = true, Message = "找不到数据！"});
            }
            return Json(new {IsSuccess = true, Message = "删除成功！"});
        }

        public ActionResult GetBugPage(int pageIndex, int pageSize)
        {
            Pager<PM_BUG> pager=new Pager<PM_BUG>();
            try
            {
                String cjsj = Request.Params["cjsj"];
                String Czr = Request.Params["Czr"];
                Dictionary<String,object> di=new Dictionary<string, object>();
                if (!String.IsNullOrEmpty(Czr))
                {
                    di.Add("pm_CzrId",Czr);
                }
                if (!String.IsNullOrEmpty(cjsj))
                {
                    di.Add("pm_Cjas",cjsj);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return Json(pager, JsonRequestBehavior.AllowGet);
        }
    }
}
