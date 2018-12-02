using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Indepandent.Models.IRepository;
namespace Indepandent.Models.Repository
{
    public class Game_deRepository:IGame_deRepository
    {
        ProjectEntities db = new ProjectEntities();
        public IQueryable<game_detail> FindTop()
        {
            var da = db.game_detail.Include("game").OrderBy(o => o.game.game_download_num).Take(8);
            return da;
        }
    }
}