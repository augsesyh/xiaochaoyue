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
    
    public partial class game_detail
    {
        public int game_detailis { get; set; }
        public int game_id { get; set; }
        public int admin_id { get; set; }
        public string content { get; set; }
        public string video { get; set; }
        public string picture { get; set; }
        public string audit { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual game game { get; set; }
    }
}