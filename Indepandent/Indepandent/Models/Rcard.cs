//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Indepandent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rcard
    {
        public int RcardID { get; set; }
        public string Rcard_con { get; set; }
        public string Rcard_img { get; set; }
        public int userid { get; set; }
        public int BlockID { get; set; }
        public int CardID { get; set; }
        public System.DateTime Rcardtime { get; set; }
    
        public virtual Block Block { get; set; }
        public virtual Card Card { get; set; }
        public virtual userinfo userinfo { get; set; }
    }
}
