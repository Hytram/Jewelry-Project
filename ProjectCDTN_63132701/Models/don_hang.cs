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
    
    public partial class don_hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public don_hang()
        {
            this.chi_tiet_don_hang = new HashSet<chi_tiet_don_hang>();
            this.hoa_don = new HashSet<hoa_don>();
            this.thanh_toan = new HashSet<thanh_toan>();
            this.van_chuyen = new HashSet<van_chuyen>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_khach_hang { get; set; }
        public decimal tong_tien { get; set; }
        public string trang_thai { get; set; }
        public Nullable<System.DateTime> ngay_tao { get; set; }
        public string ma_van_don { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_don_hang> chi_tiet_don_hang { get; set; }
        public virtual khach_hang khach_hang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoa_don> hoa_don { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thanh_toan> thanh_toan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<van_chuyen> van_chuyen { get; set; }
    }
}
