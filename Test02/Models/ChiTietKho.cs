//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test02.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietKho
    {
        public int STT { get; set; }
        public string MaSP { get; set; }
        public string MaKho { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<System.DateTime> NgayXuat { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual Kho Kho { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
