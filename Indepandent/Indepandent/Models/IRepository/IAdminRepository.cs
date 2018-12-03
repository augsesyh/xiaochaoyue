using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indepandent.Models
{
    interface IAdminRepository
    {
        //管理员登录
        void AdminLogin(admin admin);
        //管理员注册
       void AdminRegister(admin admin);
        //显示所有的用户评论
        IQueryable AllComment();
        //评论详情
        void CommentDetail(int? id);
        //删除用户评论
        void Delete(int? id);
        //确认删除评论
        void DeleteConfirmed(int id);
        

        
    }
}
