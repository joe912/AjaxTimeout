using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTimeout.Controllers
{

    public class ReportsController : BaseController
    {
        //
        // GET: /Reports/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SummaryExpansion(string blah)
        {
            if (blah == "throw")
            {
                throw new ApplicationException("an unexpected error occurred - pls try again");
            }
            
            System.Threading.Thread.Sleep(5000);

            return PartialView("SummaryGroupExpansion");
        }
    }

    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
