using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indepandent.Models;
using Indepandent.Models.IRepository;
using Indepandent.Models.Repository;
using qwjcode;

namespace Indepandent.Controllers
{
    public class IndexController : Controller
    {
        ProjectEntities db = new ProjectEntities();
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index2()
        {
            IGame_deRepository da = new Game_deRepository();
            var dt = da.FindTop();
            return PartialView(dt);
        }
       
        
        [AllowAnonymous]
        public ActionResult GetValidateCode()
        {
            ValidateCode vCode = new ValidateCode();
            string code = vCode.CreateValidateCode(4);
            Session["ValidateCode"] = code;
            byte[] bytes = vCode.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(userinfo use)
        {
            if (use.valicode != Session["ValidateCode"].ToString())
            {
                return Content("<script>alert('验证码错误');window.location.href='Index';</script>");
            }
            if (ModelState.IsValid)
            {
                IUserRepository da = new UserRepository();
                da.Add(use);
                Session["name"] = use.username;
                return RedirectToAction("Index","Store");
            }
           
            return PartialView(use);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(userinfo user)
        {

            
           if(user.valicode!=Session["ValidateCode"].ToString())
            {
                return Content("<script>alert('验证码错误');window.location.href='Index';</script>");
            }
           
            
                var use = db.userinfo.Where(o => o.username == user.username).Where(o => o.userpassword == user.userpassword);
                if (use.Count() == 0)
                {
                    Session["name"] = null;
                    return Content("<script>alert('用户密码错误');window.location.href='Index';</script>");

                }
                else
                {

                    Session["name"] = user.username;
                    return Content("<script>alert('登录成功');window.location.href='Index';</script>");
                }
            
            
           
        }
        
    }
}