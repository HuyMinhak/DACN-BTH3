using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCSKH.Data
{
    public class NhanVien
    {
        public int ID { get; set; } // Map với MaNV
        public string HoVaTen { get; set; } // Map với TenNhanVien
        public string? DienThoai { get; set; } // Map với SoDienThoai
        public string? Email { get; set; }
        public string? TrangThai { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool QuyenHan { get; set; }
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}