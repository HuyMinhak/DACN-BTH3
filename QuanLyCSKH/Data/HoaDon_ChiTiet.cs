using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCSKH.Data
{
    public class HoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
        [NotMapped]
        public class DanhSachHoaDon_ChiTiet
        {
            public int ID { get; set; }
            public int HoaDonID { get; set; }
            public int SanPhamID { get; set; }
            public string TenSanPham { get; set; } // Thêm
            public short SoLuongBan { get; set; }
            public int DonGiaBan { get; set; }
            public int ThanhTien { get; set; } // Thêm
        }
    }
}
