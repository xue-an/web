//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebUI.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamTure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamTure()
        {
            this.Subject = new HashSet<Subject>();
        }
    
        public int Id { get; set; }
        public short Extype { get; set; }
        public string title { get; set; }
        public string quesA { get; set; }
        public string quesB { get; set; }
        public string quesC { get; set; }
        public string quesD { get; set; }
        public string quesTion { get; set; }
        public string jieshi { get; set; }
        public string soure { get; set; }
        public short DelFlag { get; set; }
        public int FenShu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject> Subject { get; set; }
    }
}