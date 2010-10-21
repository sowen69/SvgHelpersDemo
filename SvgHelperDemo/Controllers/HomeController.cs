using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SvgHelperDemo.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Structural()
        {
            return View();
        }
        public ActionResult BasicShapes()
        {
            return View();
        }
        public ActionResult Gradients()
        {
            return View();
        }
        public ActionResult OtherStuff()
        {
            return View();
        }
        public ActionResult Download()
        {
            return View();
        }

    }
}
