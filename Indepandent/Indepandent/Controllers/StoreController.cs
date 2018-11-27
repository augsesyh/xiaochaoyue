using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indepandent.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            if (Session["name"] == null)
            {
                return RedirectToAction("Index", "Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult detail()
        {
            return View();
        }
    }
}