using Microsoft.EntityFrameworkCore;
using QuanLyCSKH.Data;
using System;

namespace QuanLyCSKH.Data
{
    public class QLCSKHbContext : DbContext
    {
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }
        public DbSet<PhanCongChamSoc> PhanCongChamSoc { get; set; }

        // BẠN THIẾU DÒNG NÀY NHÉ:
        public DbSet<SanPham> SanPham { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-3VDNARNT;Database=QLCSKH;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
    }
}