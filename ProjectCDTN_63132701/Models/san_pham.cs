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
    
    public partial class san_pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public san_pham()
        {
            this.chi_tiet_don_hang = new HashSet<chi_tiet_don_hang>();
            this.chi_tiet_hoa_don = new HashSet<chi_tiet_hoa_don>();
            this.lich_su_truy_cap = new HashSet<lich_su_truy_cap>();
            this.yeu_thich = new HashSet<yeu_thich>();
            this.gio_hang = new HashSet<gio_hang>();
        }
    
        public int id { get; set; }
        public string ten_san_pham { get; set; }
        public string mo_ta { get; set; }
        public decimal gia { get; set; }
        public int so_luong { get; set; }
        public Nullable<int> id_danh_muc { get; set; }
        public string anh_san_pham { get; set; }
        public string loai_bac { get; set; }
        public Nullable<System.DateTime> ngay_tao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_don_hang> chi_tiet_don_hang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_hoa_don> chi_tiet_hoa_don { get; set; }
        public virtual danh_muc danh_muc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lich_su_truy_cap> lich_su_truy_cap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yeu_thich> yeu_thich { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gio_hang> gio_hang { get; set; }
    }
}
