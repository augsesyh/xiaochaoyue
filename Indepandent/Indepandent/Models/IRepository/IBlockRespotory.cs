using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indepandent.Models.IRepository
{
    interface IBlockRespotory
    {
        IQueryable<Block> FindAll(string ca);
       
    }
}
