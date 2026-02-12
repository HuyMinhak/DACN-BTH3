using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCSKH.Data
{
    public class PhanCongChamSoc
    {
        public int ID { get; set; } // Map với MaPC
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayChamSoc { get; set; }
        public string HinhThuc { get; set; }
        public string NoiDung { get; set; }
        public string KetQua { get; set; }
        public DateTime? NgayHenLai { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
    }
}
