using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indepandent.Models
{
    public class AdminRepository:IAdminRepository
    {
        ProjectEntities db = new ProjectEntities();
        //管理员登录
        void IAdminRepository.AdminLogin(admin admin)
        {
            var adm = db.admin.Where(o => o.admin_name == admin.admin_name).Where(o => o.admin_password == admin.admin_password);
            
        }
        //管理员注册
        void IAdminRepository.AdminRegister(admin admin)
        {
            db.admin.Add(admin);
        }
        //显示所有的用户评论

        IQueryable IAdminRepository.AllComment()
        {
            var com = from c in db.comment
                      join u in db.userinfo on c.user_id equals u.userid
                      join g in db.game on c.game_id equals g.gameid
                      select new
                      {
                          u.username,
                          c.content,
                          g.game_name,
                          c.comment_time
                      };
            return com;
        }
        //评论详情

        void IAdminRepository.CommentDetail(int? id)
        {
            comment comment = db.comment.Find(id);
        }
        //删除用户评论
        void IAdminRepository.Delete(int? id)
        {
            comment comment = db.comment.Find(id);
        }
        //确认删除评论
        void IAdminRepository.DeleteConfirmed(int id)
        {
            comment comment = db.comment.Find(id);
            db.comment.Remove(comment);
            db.SaveChanges();
        }

    }
}