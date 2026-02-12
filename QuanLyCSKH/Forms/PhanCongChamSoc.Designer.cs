namespace QuanLyCSKH.Forms
{
    partial class PhanCongChamSoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCongChamSoc));
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            dgvPhanCong = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnNhap = new Button();
            btnXuat = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            txtNoiDung = new TextBox();
            label7 = new Label();
            cboKetQua = new ComboBox();
            label3 = new Label();
            cboHinhThuc = new ComboBox();
            label4 = new Label();
            dtpNgayChamSoc = new DateTimePicker();
            label5 = new Label();
            cboKhachHang = new ComboBox();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            label6 = new Label();
            ID = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            NgayChamSoc = new DataGridViewTextBoxColumn();
            HinhThuc = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(203, 186);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 186);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(103, 186);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dgvPhanCong
            // 
            dgvPhanCong.AllowUserToAddRows = false;
            dgvPhanCong.AllowUserToDeleteRows = false;
            dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhanCong.Columns.AddRange(new DataGridViewColumn[] { ID, TenNhanVien, TenKhachHang, NgayChamSoc, HinhThuc, NoiDung });
            dgvPhanCong.Dock = DockStyle.Fill;
            dgvPhanCong.Location = new Point(3, 23);
            dgvPhanCong.Margin = new Padding(2, 1, 2, 1);
            dgvPhanCong.MultiSelect = false;
            dgvPhanCong.Name = "dgvPhanCong";
            dgvPhanCong.ReadOnly = true;
            dgvPhanCong.RowHeadersWidth = 82;
            dgvPhanCong.Size = new Size(794, 177);
            dgvPhanCong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(253, 3);
            label1.Name = "label1";
            label1.Size = new Size(276, 46);
            label1.TabIndex = 10;
            label1.Text = "Bảng phân công";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dgvPhanCong);
            groupBox1.Location = new Point(1, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 203);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phân công";
            
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(403, 186);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 22;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(703, 186);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(303, 186);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(txtNoiDung);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cboKetQua);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboHinhThuc);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtpNgayChamSoc);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboKhachHang);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cboNhanVien);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnNhap);
            groupBox2.Controls.Add(btnXuat);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Location = new Point(1, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(803, 259);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phân công";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(557, 140);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(199, 34);
            txtNoiDung.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(419, 140);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 41;
            label7.Text = "Nội dung:";
            // 
            // cboKetQua
            // 
            cboKetQua.FormattingEnabled = true;
            cboKetQua.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboKetQua.Location = new Point(557, 93);
            cboKetQua.Name = "cboKetQua";
            cboKetQua.Size = new Size(199, 28);
            cboKetQua.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 96);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 39;
            label3.Text = "Kết quả:";
            // 
            // cboHinhThuc
            // 
            cboHinhThuc.FormattingEnabled = true;
            cboHinhThuc.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboHinhThuc.Location = new Point(181, 93);
            cboHinhThuc.Name = "cboHinhThuc";
            cboHinhThuc.Size = new Size(199, 28);
            cboHinhThuc.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 96);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 37;
            label4.Text = "Hình thức:";
            // 
            // dtpNgayChamSoc
            // 
            dtpNgayChamSoc.Location = new Point(181, 135);
            dtpNgayChamSoc.Name = "dtpNgayChamSoc";
            dtpNgayChamSoc.Size = new Size(199, 27);
            dtpNgayChamSoc.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 135);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 35;
            label5.Text = "Ngày chăm sóc:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboKhachHang.Location = new Point(557, 45);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(199, 28);
            cboKhachHang.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 48);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 33;
            label2.Text = "Khách hàng (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboNhanVien.Location = new Point(181, 45);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(199, 28);
            cboNhanVien.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 48);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 31;
            label6.Text = "Nhân viên lập (*):";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân Viên Chăm Sóc";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Khách Hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.ReadOnly = true;
            // 
            // NgayChamSoc
            // 
            NgayChamSoc.DataPropertyName = "NgayChamSoc";
            NgayChamSoc.HeaderText = "Ngày Chăm Sóc";
            NgayChamSoc.MinimumWidth = 6;
            NgayChamSoc.Name = "NgayChamSoc";
            NgayChamSoc.ReadOnly = true;
            // 
            // HinhThuc
            // 
            HinhThuc.DataPropertyName = "HinhThuc";
            HinhThuc.HeaderText = "Hình Thức";
            HinhThuc.MinimumWidth = 6;
            HinhThuc.Name = "HinhThuc";
            HinhThuc.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.DataPropertyName = "NoiDung";
            NoiDung.HeaderText = "Nội Dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // PhanCongChamSoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PhanCongChamSoc";
            Text = "PhanCongChamSoc";
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private DataGridView dgvPhanCong;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnLuu;
        private GroupBox groupBox2;
        private ComboBox cboKhachHang;
        private Label label2;
        private ComboBox cboNhanVien;
        private Label label6;
        private DateTimePicker dtpNgayChamSoc;
        private Label label5;
        private TextBox txtNoiDung;
        private Label label7;
        private ComboBox cboKetQua;
        private Label label3;
        private ComboBox cboHinhThuc;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn NgayChamSoc;
        private DataGridViewTextBoxColumn HinhThuc;
        private DataGridViewTextBoxColumn NoiDung;
    }
}