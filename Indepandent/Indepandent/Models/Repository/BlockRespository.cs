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
        IQueryable<Block> IBlockRespotory.FindAll()
        {
            var da = db.Block;
            return da;
        }
    }
}