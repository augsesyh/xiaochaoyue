using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Indepandent.Models.IRepository;

namespace Indepandent.Models.Repository
{
    public class BlockRespository:IBlockRespotory
    {
        ProjectEntities db = new ProjectEntities();
        IQueryable<Block> IBlockRespotory.FindAll(string ca)
        {
            var da = db.Block.Where(o => o.Block_ca == ca).OrderBy(o => o.BlockID);
            return da;
        }
       
    }
}