using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indepandent.Models;
using Indepandent.Models.IRepository;
using Indepandent.Models.Repository;

namespace Indepandent.Controllers
{
    public class AdminController : Controller
    {
        IAdminRepository adm = new AdminRepository();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //Get:所有的评论
        public ActionResult AllComment()
        {
            var coms=adm.AllComment();
            return View(coms);
        }
        //管理员登录
        public ActionResult adm_Login(admin admin)
        {
            adm.AdminLogin(admin);
            return View();
        }
    }
}