using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Indepandent.Models.IRepository;

namespace Indepandent.Models.Repository
{
    public class UserRepository:IUserRepository
    {
        protected ProjectEntities db = new ProjectEntities();
        void IUserRepository.Add(userinfo use)
        {
            db.userinfo.Add(use);
            db.SaveChanges();
        }
        Boolean IUserRepository.delete(string username)
        {
            userinfo use = db.userinfo.Where(b => b.username == username).FirstOrDefault();
            if(use!=null)
            {
                db.userinfo.Remove(use);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        IQueryable<userinfo> IUserRepository.FindAlluser()
        {
            var da = db.userinfo;
            return da;
        }
        Boolean IUserRepository.Find(string name, string password)
        {
            var da = db.userinfo.Where(o => o.username == name).Where(b => b.userpassword == password);
            if(da==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}