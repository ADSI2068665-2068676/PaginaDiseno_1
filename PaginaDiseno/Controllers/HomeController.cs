using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaDiseno.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Periodicos3()
        {
            return View();
        }
        public ActionResult Buscadores3()
        {
            return View();
        }
        public ActionResult Blogs3()
        {
            return View();
        }
    }
}