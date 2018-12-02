using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indepandent.Models;

namespace Indepandent.Controllers
{
    public class developerController : Controller
    {
        private ProjectEntities db = new ProjectEntities();
        // GET: developer首页
        public ActionResult deve_Index()
        {
            return View();
        }

        //GET:开发者登录
        [HttpGet]
        public ActionResult deve_login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult deve_login(developer dinfo)
        {
            var de = db.developer.Where(a => a.DeveloperName == dinfo.DeveloperName).Where(b => b.DevelpoerPassword == dinfo.DevelpoerPassword).First();
            if (de == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("deve_Index");
            }
        }

        [HttpGet]
        public ActionResult register()
        {
            return View();
        }

    }
}