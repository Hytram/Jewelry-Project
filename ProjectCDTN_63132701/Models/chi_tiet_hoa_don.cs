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
    
    public partial class chi_tiet_hoa_don
    {
        public int id { get; set; }
        public int id_hoa_don { get; set; }
        public int id_san_pham { get; set; }
        public int so_luong { get; set; }
        public decimal gia { get; set; }
    
        public virtual hoa_don hoa_don { get; set; }
        public virtual san_pham san_pham { get; set; }
    }
}
