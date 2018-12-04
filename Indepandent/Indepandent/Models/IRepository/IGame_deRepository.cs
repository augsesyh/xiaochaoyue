using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indepandent.Models.IRepository
{
    interface IGame_deRepository
    {
       IQueryable<game_detail> FindTop();
    }
}
