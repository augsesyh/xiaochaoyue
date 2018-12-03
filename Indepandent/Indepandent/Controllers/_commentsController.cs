using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Indepandent.Models;

namespace Indepandent.Controllers
{
    public class _commentsController : Controller
    {
        private ProjectEntities db = new ProjectEntities();

        // GET: _comments
        public ActionResult Index()
        {
            var comment = db.comment.Include(c => c.download).Include(c => c.game).Include(c => c.userinfo);
            return View(comment.ToList());
        }

        // GET: _comments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comment comment = db.comment.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // GET: _comments/Create
        public ActionResult Create()
        {
            ViewBag.download_id = new SelectList(db.download, "downloadid", "downloadid");
            ViewBag.game_id = new SelectList(db.game, "gameid", "game_name");
            ViewBag.user_id = new SelectList(db.userinfo, "userid", "username");
            return View();
        }

        // POST: _comments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "commentid,user_id,game_id,download_id,content,comment_time")] comment comment)
        {
            if (ModelState.IsValid)
            {
                db.comment.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.download_id = new SelectList(db.download, "downloadid", "downloadid", comment.download_id);
            ViewBag.game_id = new SelectList(db.game, "gameid", "game_name", comment.game_id);
            ViewBag.user_id = new SelectList(db.userinfo, "userid", "username", comment.user_id);
            return View(comment);
        }

        // GET: _comments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comment comment = db.comment.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            ViewBag.download_id = new SelectList(db.download, "downloadid", "downloadid", comment.download_id);
            ViewBag.game_id = new SelectList(db.game, "gameid", "game_name", comment.game_id);
            ViewBag.user_id = new SelectList(db.userinfo, "userid", "username", comment.user_id);
            return View(comment);
        }

        // POST: _comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "commentid,user_id,game_id,download_id,content,comment_time")] comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.download_id = new SelectList(db.download, "downloadid", "downloadid", comment.download_id);
            ViewBag.game_id = new SelectList(db.game, "gameid", "game_name", comment.game_id);
            ViewBag.user_id = new SelectList(db.userinfo, "userid", "username", comment.user_id);
            return View(comment);
        }

        // GET: _comments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            comment comment = db.comment.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: _comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            comment comment = db.comment.Find(id);
            db.comment.Remove(comment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
