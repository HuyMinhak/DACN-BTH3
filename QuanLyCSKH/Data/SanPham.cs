using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCSKH.Data
{
    public class SanPham
    {
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; } // Giá bán chuẩn
        // Xóa hết LoaiSanPhamID, HangSanXuatID, SoLuongKho, HinhAnh đi cho nhẹ!

        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
    }
}