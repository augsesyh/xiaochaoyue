using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indepandent.Models.IRepository
{
    interface IRcardRespository
    {
        Rcard GetRcard(int Blockid);
    }
}
