//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCDTN_63132701.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hoa_don
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoa_don()
        {
            this.chi_tiet_hoa_don = new HashSet<chi_tiet_hoa_don>();
        }
    
        public int id { get; set; }
        public int id_khach_hang { get; set; }
        public int id_don_hang { get; set; }
        public decimal tong_tien { get; set; }
        public Nullable<System.DateTime> ngay_tao { get; set; }
        public string trang_thai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_hoa_don> chi_tiet_hoa_don { get; set; }
        public virtual don_hang don_hang { get; set; }
        public virtual khach_hang khach_hang { get; set; }
    }
}
