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
    public class ResourceController : BaseController
    {
        public  IResourceManager iResourceManager { get; set; }
        //
        // GET: /Resource/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPage()
        {
            ViewData["Fid"] = Request.Params["Fid"];
            return View();
        }
        public ActionResult ModifyPage()
        {
            PM_Resource resource = null;
            int id =Convert.ToInt16(Request.Params["id"]);
           resource= iResourceManager.Get(id);
            if (resource != null)
            {
                ViewData["resource"] = resource;
            }
            return View();
        }

        public ActionResult AddResource()
        {
            ReturnObj returnObj=new ReturnObj();
            try
            {
                PM_Resource resource = this.GetResourceForPage();
                iResourceManager.Save(resource);
                returnObj.State = 1;
                returnObj.Msg = "添加成功！";
            }
            catch (Exception exception)
            {
                returnObj.State = -1;
                returnObj.Msg = "添加失败！" + exception.Message;
            }
            return Json(returnObj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetResourcePage(int page, int rows)
        {
            Pager<PM_Resource> pager = new Pager<PM_Resource>();
            try
            {
                pager = this.iResourceManager.FinPager(null, page, rows);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
               pager=new Pager<PM_Resource>();
            }
            return Json(pager, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetResourceById()
        {
            ReturnObjBean<PM_Resource> returnObj = new ReturnObjBean<PM_Resource>();
            try
            {
                int id = Convert.ToInt16(Request.Params["Id"]);
                returnObj.Bean = this.GetResourceForDb(id);
                returnObj.State = 1;

            }
            catch
            {
                returnObj.Bean = new PM_Resource();
                returnObj.State = -1;
                returnObj.Msg = "获取数据失败！";
            }
            return Json(returnObj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ModifyResource()
        {
            ReturnObj returnObj = new ReturnObj();
            try
            {
                PM_Resource resource = this.GetResourceForPage();
                iResourceManager.Update(resource);
                returnObj.State = 1;
                returnObj.Msg = "修改成功！";
            }
            catch (Exception exception)
            {
                returnObj.State = -1;
                returnObj.Msg = "修改失败！" + exception.Message;
            }
            return Json(returnObj, JsonRequestBehavior.AllowGet);
        }

        private PM_Resource GetResourceForDb(int id)
        {
            return iResourceManager.Get(id);
        }

        private PM_Resource GetResourceForPage()
        {
            PM_Resource resource=new PM_Resource();
            resource.pm_TReid = Convert.ToInt16(Request.Params["pm_TReid"]);
            resource.pm_TRURL = Request.Params["pm_TRURL"];
            resource.pm_TRType = Request.Params["pm_TRType"];
            resource.pm_TRState = Request.Params["pm_TRState"];
            resource.pm_TRName = Request.Params["pm_TRName"];
            resource.pm_TRIMG = Request.Params["pm_TRIMG"];
            resource.pm_TRFid =Convert.ToInt16(Request.Params["pm_TRFid"]);
            return resource;
        }

    }
}
