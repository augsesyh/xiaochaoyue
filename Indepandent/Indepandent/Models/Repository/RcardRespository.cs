using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Indepandent.Models.IRepository;
namespace Indepandent.Models.Repository
{
    public class RcardRespository:IRcardRespository
    {
        ProjectEntities db = new ProjectEntities();
        Rcard IRcardRespository.GetRcard(int Blockid)
        {
            var da = db.Rcard.Where(o => o.BlockID == Blockid).OrderBy(c => c.Rcardtime).FirstOrDefault();
            return da;
        }
    }
}