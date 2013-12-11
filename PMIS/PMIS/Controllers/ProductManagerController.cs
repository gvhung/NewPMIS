using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMIS.BLL;
using PMIS.Comm;
using PMIS.Model;

namespace PMIS.Controllers
{
    public class ProductManagerController : BaseController
    {
        //
        // GET: /Product/
        public  IProductManager iProductManager { get; set; }
        public IUserManager iUserManager { get; set; }
        public IFjManager iFjManager { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Modify()
        {
            return View();
        }

        public string Upload()
        {
            string res = "";
            try
            {
                string uploadPath = Server.MapPath("~/file/productfile/");
                HttpPostedFileBase fileData = Request.Files["fileToUpload"];
                //string type = fileData.FileName.Substring(fileData.FileName.LastIndexOf("."));
                string fileName ;
                if (fileData != null)
                {
                    fileName = fileData.FileName;
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }
                    fileData.SaveAs(uploadPath + fileName);
                    ViewData["fileName"] = fileName;
                    res = "state:1,msg:上传成功！,path:/file/productfile/" + fileName + "";

                }
                else
                {
                    res = "state:'-1',msg:'请选择文件！'";
                }
            }
            catch (Exception ex)
            {

                res = "state:'-1',msg:'上传错误'" + ex.Message + "";
            }
            return res;
        }

        public ActionResult GetProductPage(int page, int rows)
        {
            Pager<PM_Product> pager=new Pager<PM_Product>();
            try
            {
                String sort = Request.Params["sort"];
                String order = Request.Params["order"];
                String pm_TPName = Request.Params["pm_TPName"];
                String pm_TPJjfaName = Request.Params["pm_TPJjfaName"];
                String pm_TPLead = Request.Params["pm_TPLead"];
                String pm_TPAddtime = Request.Params["pm_TPAddtime"];
                
                Dictionary<String,Object> di=new Dictionary<string, object>();
                di.Add("pm_TPName", pm_TPName);
                di.Add("pm_TPJjfaName", pm_TPJjfaName);
                di.Add("pm_TPLead", pm_TPLead);
                di.Add("pm_TPAddtime", pm_TPAddtime);
                pager = this.iProductManager.FinPager(di, page, rows);

            }
            catch (Exception)
            {
                pager=new Pager<PM_Product>();
            }
            return Json(pager, JsonRequestBehavior.AllowGet);
        }



        public ActionResult AddFun()
        {
            ReturnObj returnObj = new ReturnObj();
            try
            {
                PM_Product pmProduct = this.GetProductBeanComm();
                pmProduct.pm_TPAddUser = Convert.ToString((Session["User"] as PM_User).pm_UserID);
                pmProduct.pm_TPAddtime = DateTime.Now;
                pmProduct.pm_TPState = "0";
                pmProduct.pm_TPModifyTime = DateTime.Now;
                pmProduct.pm_TPModifyUser = "";
                pmProduct.pm_TPGuid = Guid.NewGuid();
                String filePath = Request.Params["filePath"];
                iProductManager.Save(pmProduct);
                if (!string.IsNullOrEmpty(filePath))
                {
                    PM_Fj fj = new PM_Fj();
                    fj.filename = filePath.Substring(filePath.LastIndexOf('/'));
                    fj.fullname = Server.MapPath("~/file/productfile/");
                    fj.guid = pmProduct.pm_TPGuid;
                    fj.relative_path = filePath;
                    iFjManager.Save(fj);
                }
                returnObj.State = 1;
                returnObj.Msg = "添加成功！";
            }
            catch (Exception)
            {
                returnObj.State = -1;
                returnObj.Msg = "添加失败！";
            }
            return Json(returnObj, JsonRequestBehavior.AllowGet);
        }



        private PM_Product GetProductBeanComm()
        {
            PM_Product pmProduct=new PM_Product();
            pmProduct.pm_TPFId =Convert.ToInt16(Request.Params["pm_TPFId"]);
            pmProduct.pm_TPJjfaName = Request.Params["pm_TPJjfaName"];
            pmProduct.pm_TPLead = Request.Params["pm_TPLead"];
            pmProduct.pm_TPName = Request.Params["pm_TPName"];
            pmProduct.pm_TPWd = Request.Params["pm_TPWd"];
            pmProduct.pm_TPVersion = Request.Params["pm_TPVersion"];
            pmProduct.pm_TPCreateTime =Convert.ToDateTime(Request.Params["pm_TPCreateTime"]);
            return pmProduct;
        }

        public ActionResult GetUserId()
        {
            ReturnObjBean<IList<PM_User>> returnObjBean = new ReturnObjBean<IList<PM_User>>();
            try
            {
                String strName = Request.Params["Name"];
                returnObjBean.Bean = iUserManager.GetUserList(strName);
                if (returnObjBean.Bean != null)
                {
                    if (returnObjBean.Bean.Count == 1)
                    {
                        returnObjBean.State = 0;
                    }
                    else
                    {
                        returnObjBean.State = 1;
                        returnObjBean.Msg = "公司有重名者请从列表中选择一个人员以确定！";
                    }
                }
                else
                {
                    returnObjBean.State = 2;
                    returnObjBean.Msg = "请确认姓名是否正确！";
                }
            }
            catch (Exception)
            {
                returnObjBean.State =-1;
                returnObjBean.Msg = "呀我被这个名字搞崩溃了！";
            }
            return Json(returnObjBean, JsonRequestBehavior.AllowGet);
        }

    }
}
