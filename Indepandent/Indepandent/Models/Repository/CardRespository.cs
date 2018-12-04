using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Indepandent.Models.IRepository;
namespace Indepandent.Models.Repository
{
    public class CardRespository:ICardRespository
    {
        ProjectEntities db = new ProjectEntities();
        IQueryable<Card> ICardRespository.FindAll(int Blockid)
        {
            var da = db.Card.Where(o => o.BlockID == Blockid).OrderBy(b=>b.priority);
            return da;
        }
    }
}