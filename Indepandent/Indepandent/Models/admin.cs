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
    
    public partial class admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public admin()
        {
            this.ban = new HashSet<ban>();
            this.feedback = new HashSet<feedback>();
            this.game_detail = new HashSet<game_detail>();
        }
    
        public int adminid { get; set; }
        public string admin_name { get; set; }
        public string admin_password { get; set; }
        public string admin_email { get; set; }
        public string admin_telephone { get; set; }
        public string admin_img { get; set; }
        public string admin_realname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ban> ban { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<feedback> feedback { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<game_detail> game_detail { get; set; }
    }
}