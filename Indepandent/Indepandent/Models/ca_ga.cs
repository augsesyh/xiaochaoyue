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
    
    public partial class ca_ga
    {
        public int ca_ga_id { get; set; }
        public Nullable<int> ca_id { get; set; }
        public Nullable<int> ga_id { get; set; }
    
        public virtual categorys categorys { get; set; }
        public virtual game game { get; set; }
    }
}
