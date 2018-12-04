using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indepandent.Models;
using System.IO;

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
        public ActionResult deve_register()
        {
            return View();
        }

        public ActionResult upload()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SavaAs(HttpPostedFileBase MyFileimg, HttpPostedFileBase MyFilevideo)
        {
            var strLocalFullpathName = MyFileimg.FileName;
            var strFileName = Path.GetFileName(strLocalFullpathName);
            var strServerFilePath = Server.MapPath("/developer_upload/deve_upload_images");
            MyFileimg.SaveAs(Path.Combine(strServerFilePath, strFileName));


            //var strLocalFullpathName1 = MyFilevideo.FileName;
            //var strFileName1 = Path.GetFileName(strLocalFullpathName);
            //var strServerFilePath1 = Server.MapPath("/developer_upload/deve_upload_videos");
            //MyFilevideo.SaveAs(Path.Combine(strServerFilePath, strFileName));


            ViewBag.strLocalFullpathName = strLocalFullpathName;
            ViewBag.strFileName = strFileName;
            ViewBag.strServerFilePath = strServerFilePath;

            //ViewBag.strLocalFullpathName1 = strLocalFullpathName1;
            //ViewBag.strFileName1 = strFileName1;
            //ViewBag.strServerFilePath1 = strServerFilePath1;
            return View();
        }

    }
}