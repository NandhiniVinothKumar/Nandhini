using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleAPISolution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TestAPIController test = new TestAPIController();
            test.Get();
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
