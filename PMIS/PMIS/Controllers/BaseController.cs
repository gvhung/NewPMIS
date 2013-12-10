using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMIS.Controllers.Filter;

namespace PMIS.Controllers
{
    [AuthorizeFilter]
    public class BaseController : Controller
    {
       

    }
}
