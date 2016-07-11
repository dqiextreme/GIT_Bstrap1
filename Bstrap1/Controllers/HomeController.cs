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

        public ActionResult Grid2()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //var res = Badjunto.all().Select(x=> new { x.Archivo, x.ID}).ToList();
            var res = Badjunto.all();

            ViewBag.res = res;
            return View(res);
        }

        public ActionResult Grid3()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //var res = Badjunto.all().Select(x=> new { x.Archivo, x.ID}).ToList();
            var res = Badjunto.all();

            ViewBag.res = res;
            return View(res);
        }

        public ActionResult _test_partial3(int id, string id2)
        {
            var res2 = Badjunto.all().ToList();
            if (id2 == "1")
            {
                res2 = res2.OrderBy(x => x.ID).ToList();
            }
            else
            {
                res2 = res2.OrderByDescending(x => x.ID).ToList();
            }

            ViewBag.res2 = res2;
            return PartialView();
        }

        public ActionResult _test_partial32(int id2)
        {
            var res2 = Badjunto.all().ToList();
            
            return PartialView();
        }
    }
}
