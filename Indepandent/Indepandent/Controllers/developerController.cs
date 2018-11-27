using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indepandent.Controllers
{
    public class developerController : Controller
    {
        // GET: developer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
    }
}