using ClosedXML.Excel;
using QuanLyCSKH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Nhớ using thư mục chứa file Model/Context của bạn, ví dụ:
// using QuanLyCSKH.Data; 

namespace QuanLyCSKH.Forms
{
    public partial class SanPham : Form
    {
        // Khởi tạo biến CSDL (Thay QLCSKHContext bằng tên class Context thực tế của bạn)
        QLCSKHbContext context = new QLCSKHbContext();
        bool xuLyThem = false;
        int id;

        public SanPham()
        {
            InitializeComponent();
        }

        // 1. Hàm bật/tắt các nút chức năng
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            // Giả sử Tên sản phẩm là ComboBox cboTenSanPham, Đơn giá là NumericUpDown numDonGia
            cboTenSanPham.Enabled = giaTri;
            numDonGia.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTim.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        // 2. Load dữ liệu lên form
        private void SanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvSanPham.AutoGenerateColumns = false; // Thay dataGridView1 bằng tên thực tế của DataGridView

            var sp = context.SanPham.Select(r => new
            {
                ID = r.ID,
                TenSanPham = r.TenSanPham,
                DonGia = r.DonGia
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            // Bind dữ liệu ngược lên các ô nhập liệu
            cboTenSanPham.DataBindings.Clear();
            cboTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            dgvSanPham.DataSource = bindingSource;
        }

        // 3. Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboTenSanPham.Text = "";
            numDonGia.Value = 0;
        }

        // 4. Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["ID"].Value.ToString());
        }

        // 5. Nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập/chọn tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    // Lưu ý: Cần đảm bảo model của bạn là QuanLyCSKH.Data.SanPham
                    var sp = new QuanLyCSKH.Data.SanPham(); // Thay đổi namespace nếu cần
                    sp.TenSanPham = cboTenSanPham.Text;
                    sp.DonGia = Convert.ToInt32(numDonGia.Value);

                    context.SanPham.Add(sp);
                    context.SaveChanges();
                }
                else
                {
                    var sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.TenSanPham = cboTenSanPham.Text;
                        sp.DonGia = Convert.ToInt32(numDonGia.Value);

                        context.SanPham.Update(sp);
                        context.SaveChanges();
                    }
                }
                SanPham_Load(sender, e); // Load lại grid
            }
        }

        // 6. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + cboTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["ID"].Value.ToString());
                var sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                SanPham_Load(sender, e);
            }
        }

        // 7. Nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            SanPham_Load(sender, e);
        }

        // 8. Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 9. Nút Xuất Excel (Đã tinh gọn số cột cho khớp bảng)
        

        // 11. (Optional) Nút Tìm kiếm
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Giả sử tên ô tìm kiếm là txtTimKiem
            /*
            string tuKhoa = txtTimKiem.Text.ToLower();
            var kq = context.SanPham.Where(s => s.TenSanPham.ToLower().Contains(tuKhoa)).ToList();
            dataGridView1.DataSource = kq;
            */
        }
    }
}