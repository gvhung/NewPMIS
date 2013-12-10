using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMIS.BLL;
using System.Collections;
using PMIS.Comm;

namespace PMIS.Controllers
{
    public class BmInfoController : Controller
    {
        public IBmInfoManager iBminfoManager { get; set; }

        public ActionResult GetBmCodes(string codes)
        {
            Hashtable ht = new Hashtable();
            string[] str = codes.Split(',');
            foreach (var temp in str)
            {
                switch (temp)
                {
                    case "xtzylx":
                        ht.Add(temp, UtilCodeInfo.xtzylx);
                        break;
                    case "xtzyzt":
                        ht.Add(temp, UtilCodeInfo.xtzyzt);
                        break;
                    case "usRole":
                        ht.Add(temp, UtilCodeInfo.usRole);
                        break;
                    case "usstate":
                        ht.Add(temp, UtilCodeInfo.usstate);
                        break;
                 
                    case "rolestate":
                        ht.Add(temp, UtilCodeInfo.rolestate);
                        break;
                    case "recode":
                        ht.Add(temp, UtilCodeInfo.recode);
                        break;
                }
            }
            return Json(ht, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetBmCode(string code)
        {
            IList<BmInfo> list = new List<BmInfo>();
            switch (code)
            {
                case "xtzylx":
                   list = UtilCodeInfo.xtzylx;
                    break;
                case "xtzyzt":
                   list = UtilCodeInfo.xtzyzt;
                    break;
                case "usRole":
                    list = UtilCodeInfo.usRole;
                    break;
                case "usstate":
                    list = UtilCodeInfo.usstate;
                    break;
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetNextCode()
        {
            string code = Request.Params["code"];
          
            return Json(iBminfoManager.GetNextCode(code), JsonRequestBehavior.AllowGet);
        }
    }
}
