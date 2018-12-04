using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indepandent.Models;


namespace Indepandent.Models.IRepository
{
    public interface IUserRepository
    {
        void Add(userinfo use);
        Boolean delete(string username);
        IQueryable<userinfo> FindAlluser();
        Boolean Find(string name,string password);

    }
}
