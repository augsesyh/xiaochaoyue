using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indepandent.Models;
using Indepandent.Models.IRepository;
using Indepandent.Models.Repository;
using PagedList;

namespace Indepandent.Controllers
{
    public class FrumController : Controller
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
        public ActionResult Block(int? page)
        {
            IBlockRespotory da = new BlockRespository();
            var dt=da.FindAll("游戏");
            int pageNumber = page ?? 1; 
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]); 
            IPagedList<Block> pagedList = dt.ToPagedList(pageNumber, pageSize);
            return View(pagedList);
        }
        [HttpGet]
        public ActionResult Card(int ?page,int id)
        {
            ICardRespository dt = new CardRespository();
            var dc = dt.FindAll(id);
            int pageNumber = page ?? 1;
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);
            IPagedList<Card> pagedList = dc.ToPagedList(pageNumber, pageSize);
            return View(pagedList);
        }
    }
}