using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indepandent.Models;

namespace Indepandent.Controllers
{
    public class frumController : Controller
    {
        ProjectEntities db = new ProjectEntities();
        // GET: frum
        [HttpGet]
        public ActionResult Index()
        {
            var dt = db.Block.Where(o => o.Block_ca == "服务");
            return View(dt);
        }
        [HttpGet]
        public ActionResult Index2()
        {
            var da = db.Block.Where(o => o.Block_ca == "游戏").Take(6);
            return  PartialView(da);
        }
        [HttpGet]
        public ActionResult Block()
        {
            return View();
        }
    }
}