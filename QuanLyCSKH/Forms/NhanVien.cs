using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyCSKH.Data; // Thêm đúng namespace chứa file QLCSKH.cs và NhanVien.cs (model)
using ClosedXML.Excel;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyCSKH.Forms
{
    public partial class NhanVien : Form
    {
        // Khởi tạo DbContext dựa trên file QLCSKH.cs trong thư mục Data của bạn
        // Đổi từ QLCSKH thành QLCSKHbContext
        QLCSKHbContext context = new QLCSKHbContext();
        bool xuLyThem = false;
        int idNhanVien;

        public NhanVien()
        {
            InitializeComponent();
        }

        // Hàm bật/tắt các điều khiển để tránh bấm nhầm
        private void BatTatChucNang(bool giaTri)
        {
            // Các ô nhập liệu
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboTrangThai.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            // Các nút bấm
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTim.Enabled = !giaTri;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            // Tải lại danh sách từ Database
            dgvNhanVien.AutoGenerateColumns = false;

            // Tải lại danh sách từ Database
            dgvNhanVien.DataSource = context.NhanVien.ToList();
        }




        private void XoaTrangO()
        {
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboTrangThai.SelectedIndex = -1;
            cboQuyenHan.SelectedIndex = -1;
        }


        // Chức năng Xuất Excel mẫu


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            XoaTrangO();
            txtHoVaTen.Focus();
        }

       

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            if (dgvNhanVien.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            // Lấy ID từ dòng đang chọn trong DataGridView
            idNhanVien = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value);
            var nv = context.NhanVien.Find(idNhanVien);

            if (nv != null)
            {
                txtHoVaTen.Text = nv.HoVaTen;
                txtDienThoai.Text = nv.DienThoai;
                txtEmail.Text = nv.Email;
                txtTenDangNhap.Text = nv.TenDangNhap;
                cboTrangThai.Text = nv.TrangThai;
                cboQuyenHan.SelectedIndex = nv.QuyenHan ? 0 : 1;
            }

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                idNhanVien = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value);
                var nv = context.NhanVien.Find(idNhanVien);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                return;
            }

            if (xuLyThem)
            {
                // Thêm mới
                var nv = new Data.NhanVien // Chỉ định rõ Data.NhanVien để tránh trùng tên với Form
                {
                    HoVaTen = txtHoVaTen.Text,
                    DienThoai = txtDienThoai.Text,
                    Email = txtEmail.Text,
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = BC.HashPassword(txtMatKhau.Text),
                    TrangThai = cboTrangThai.Text,
                    QuyenHan = cboQuyenHan.SelectedIndex == 0
                };
                context.NhanVien.Add(nv);
            }
            else
            {
                // Cập nhật
                var nv = context.NhanVien.Find(idNhanVien);
                if (nv != null)
                {
                    nv.HoVaTen = txtHoVaTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.Email = txtEmail.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.TrangThai = cboTrangThai.Text;
                    nv.QuyenHan = cboQuyenHan.SelectedIndex == 0;

                    if (!string.IsNullOrEmpty(txtMatKhau.Text))
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                }
            }

            context.SaveChanges();
            BatTatChucNang(false);
            LoadData();
            MessageBox.Show("Lưu dữ liệu thành công!");
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {

            string search = txtTimKiem.Text.ToLower();
            var result = context.NhanVien
                .Where(x => x.HoVaTen.ToLower().Contains(search) || x.TenDangNhap.Contains(search))
                .ToList();
            dgvNhanVien.DataSource = result;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {

            BatTatChucNang(false);
            XoaTrangO();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        

    }
}





