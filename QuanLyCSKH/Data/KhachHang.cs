using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCSKH.Data
{
    public class KhachHang
    {
        public int ID { get; set; } // Map với MaKH
        public string HoVaTen { get; set; } // Map với TenKhachHang
        public string DienThoai { get; set; } // Map với SoDienThoai
        public string? DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? NhomKhachHang { get; set; }
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
