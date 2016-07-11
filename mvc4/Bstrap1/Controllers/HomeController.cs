using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Bstrap1.Models;
using Bstrap1.Clases;


namespace Bstrap1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Grid()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var res = Badjunto.all();
            ViewBag.res = res;
            return View(res);
        }
    }
}
