namespace QuanLyCSKH.Forms
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            btnNhap = new Button();
            btnXuat = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvSanPham = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            numDonGia = new NumericUpDown();
            cboTenSanPham = new ComboBox();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            SuspendLayout();
            
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(683, 18);
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
            btnThoat.Location = new Point(683, 69);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(583, 164);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(252, 3);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 7;
            label1.Text = "Bảng sản phẩm";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dgvSanPham);
            groupBox1.Location = new Point(0, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 203);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, DonGia });
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(3, 23);
            dgvSanPham.Margin = new Padding(2, 1, 2, 1);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.Size = new Size(794, 177);
            dgvSanPham.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(cboTenSanPham);
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
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(0, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 259);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(150, 107);
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(309, 27);
            numDonGia.TabIndex = 26;
            // 
            // cboTenSanPham
            // 
            cboTenSanPham.FormattingEnabled = true;
            cboTenSanPham.Items.AddRange(new object[] { "Liệu trình trị mụn chuẩn Y khoa", "Chăm sóc da mặt chuyên sâu", "Phục hồi da mỏng yếu, nổi mao mạch", "Tắm trắng phi thuyền hoàng gia", "Triệt lông nách vĩnh viễn (Trọn gói)", "Triệt lông toàn thân VIP", "Nâng cơ trẻ hóa da công nghệ Hifu", "Massage body đá nóng đả thông kinh lạc", "Phun mày tán bột tự nhiên", "Khử thâm môi Collagen" });
            cboTenSanPham.Location = new Point(150, 50);
            cboTenSanPham.Name = "cboTenSanPham";
            cboTenSanPham.Size = new Size(309, 28);
            cboTenSanPham.TabIndex = 25;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(583, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(583, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(583, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(465, 166);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 16;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(150, 166);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(309, 27);
            txtTimKiem.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 173);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 7;
            label9.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 107);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SanPham";
            Text = "Sản phẩm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboNhomKhachHang;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnLuu;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvSanPham;
        private GroupBox groupBox2;
        private DateTimePicker dtNgaySinh;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnTim;
        private TextBox txtTimKiem;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numDonGia;
        private ComboBox cboTenSanPham;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGia;
    }
}