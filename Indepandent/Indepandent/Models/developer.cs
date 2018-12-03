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
    using System.ComponentModel.DataAnnotations;

    public partial class developer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public developer()
        {
            this.game = new HashSet<game>();
        }
    
        public int DeveloperID { get; set; }

        [Required(ErrorMessage =("用户名不能为空"))]
        public string DeveloperName { get; set; }

        [Required(ErrorMessage = "不能为空")]
        [StringLength(20,MinimumLength =6, ErrorMessage = "密码不能小于6个字符")]
        public string DevelpoerPassword { get; set; }
        public string DeveloperEmail { get; set; }
        public string Developertelephone { get; set; }
        public string DeveloperImg { get; set; }
        public string DeveloperRealName { get; set; }
        public string DeveloperIntro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<game> game { get; set; }
    }
}
