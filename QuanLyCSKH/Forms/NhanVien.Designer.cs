namespace QuanLyCSKH.Forms
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            groupBox2 = new GroupBox();
            cboTrangThai = new ComboBox();
            cboQuyenHan = new ComboBox();
            btnNhap = new Button();
            btnXuat = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            txtMatKhau = new TextBox();
            txtDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtTenDangNhap = new TextBox();
            txtHoVaTen = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvNhanVien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(cboTrangThai);
            groupBox2.Controls.Add(cboQuyenHan);
            groupBox2.Controls.Add(btnNhap);
            groupBox2.Controls.Add(btnXuat);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(txtMatKhau);
            groupBox2.Controls.Add(txtDienThoai);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtTenDangNhap);
            groupBox2.Controls.Add(txtHoVaTen);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(1, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 263);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin nhân viên";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Thử việc", "Đang nghỉ phép", "Thực tập" });
            cboTrangThai.Location = new Point(95, 174);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 26;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(356, 132);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(211, 28);
            cboQuyenHan.TabIndex = 25;
            
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(700, 27);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 22;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(700, 78);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(600, 173);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(600, 124);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(600, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(600, 77);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(500, 173);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 16;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click_1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(356, 175);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(125, 27);
            txtTimKiem.TabIndex = 15;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(356, 82);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(211, 27);
            txtMatKhau.TabIndex = 13;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(112, 79);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(125, 27);
            txtDienThoai.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(356, 39);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(211, 27);
            txtTenDangNhap.TabIndex = 9;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(112, 36);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(125, 27);
            txtHoVaTen.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(252, 178);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 7;
            label9.Text = "Tìm kiếm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(252, 127);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 6;
            label8.Text = "Quyền hạn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 85);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 5;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 182);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 4;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 39);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 3;
            label5.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 132);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 81);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(253, 4);
            label1.Name = "label1";
            label1.Size = new Size(267, 46);
            label1.TabIndex = 1;
            label1.Text = "Bảng nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dgvNhanVien);
            groupBox1.Location = new Point(1, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 203);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, Email, TrangThai, TenDangNhap, QuyenHan });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 23);
            dgvNhanVien.Margin = new Padding(2, 1, 2, 1);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 82;
            dgvNhanVien.Size = new Size(794, 177);
            dgvNhanVien.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và Tên";
            HoVaTen.MinimumWidth = 10;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 10;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 10;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 10;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(803, 444);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NhanVien";
            Text = "NhanVien";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnTim;
        private TextBox txtTimKiem;
        private TextBox txtMatKhau;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private TextBox txtTenDangNhap;
        private TextBox txtHoVaTen;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnLuu;
        private ComboBox cboTrangThai;
        private ComboBox cboQuyenHan;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}