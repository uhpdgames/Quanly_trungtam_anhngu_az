namespace QuanLyHocSinh
{
    partial class frmQuanLyHocVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHocVien));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.gbThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cmbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.rdbGioiTinhNu = new System.Windows.Forms.RadioButton();
            this.rdbGioiTinhNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblKhoahoc = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.dgvDanhSachHocVien = new System.Windows.Forms.DataGridView();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbThongTinHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).BeginInit();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("UVN Ba Le", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(52, -10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(248, 54);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Quản lý học viên";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // gbThongTinHocSinh
            // 
            this.gbThongTinHocSinh.Controls.Add(this.txtsdt);
            this.gbThongTinHocSinh.Controls.Add(this.cmbLop);
            this.gbThongTinHocSinh.Controls.Add(this.lblLop);
            this.gbThongTinHocSinh.Controls.Add(this.lblsdt);
            this.gbThongTinHocSinh.Controls.Add(this.txtDiaChi);
            this.gbThongTinHocSinh.Controls.Add(this.cmbKhoaHoc);
            this.gbThongTinHocSinh.Controls.Add(this.rdbGioiTinhNu);
            this.gbThongTinHocSinh.Controls.Add(this.rdbGioiTinhNam);
            this.gbThongTinHocSinh.Controls.Add(this.dtpNgaySinh);
            this.gbThongTinHocSinh.Controls.Add(this.txtHoTen);
            this.gbThongTinHocSinh.Controls.Add(this.txtMaHV);
            this.gbThongTinHocSinh.Controls.Add(this.lblDiachi);
            this.gbThongTinHocSinh.Controls.Add(this.lblKhoahoc);
            this.gbThongTinHocSinh.Controls.Add(this.lblGioiTinh);
            this.gbThongTinHocSinh.Controls.Add(this.lblNgaySinh);
            this.gbThongTinHocSinh.Controls.Add(this.lblHoTen);
            this.gbThongTinHocSinh.Controls.Add(this.lblMaHS);
            this.gbThongTinHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbThongTinHocSinh.ForeColor = System.Drawing.Color.White;
            this.gbThongTinHocSinh.Location = new System.Drawing.Point(36, 59);
            this.gbThongTinHocSinh.Name = "gbThongTinHocSinh";
            this.gbThongTinHocSinh.Size = new System.Drawing.Size(642, 225);
            this.gbThongTinHocSinh.TabIndex = 1;
            this.gbThongTinHocSinh.TabStop = false;
            this.gbThongTinHocSinh.Text = "Thông tin học viên";
            this.gbThongTinHocSinh.Enter += new System.EventHandler(this.gbThongTinHocSinh_Enter);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(117, 122);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(147, 23);
            this.txtsdt.TabIndex = 14;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(460, 123);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(139, 23);
            this.cmbLop.TabIndex = 13;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(355, 123);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(71, 23);
            this.lblLop.TabIndex = 12;
            this.lblLop.Text = "Lớp học";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.Location = new System.Drawing.Point(14, 123);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(89, 23);
            this.lblsdt.TabIndex = 11;
            this.lblsdt.Text = "Điện thoại";
            this.lblsdt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(460, 160);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(139, 45);
            this.txtDiaChi.TabIndex = 10;
            // 
            // cmbKhoaHoc
            // 
            this.cmbKhoaHoc.FormattingEnabled = true;
            this.cmbKhoaHoc.Location = new System.Drawing.Point(460, 80);
            this.cmbKhoaHoc.Name = "cmbKhoaHoc";
            this.cmbKhoaHoc.Size = new System.Drawing.Size(139, 23);
            this.cmbKhoaHoc.TabIndex = 9;
            this.cmbKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cmbKhoaHoc_SelectedIndexChanged);
            // 
            // rdbGioiTinhNu
            // 
            this.rdbGioiTinhNu.AutoSize = true;
            this.rdbGioiTinhNu.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGioiTinhNu.Location = new System.Drawing.Point(548, 27);
            this.rdbGioiTinhNu.Name = "rdbGioiTinhNu";
            this.rdbGioiTinhNu.Size = new System.Drawing.Size(51, 27);
            this.rdbGioiTinhNu.TabIndex = 8;
            this.rdbGioiTinhNu.TabStop = true;
            this.rdbGioiTinhNu.Text = "Nữ";
            this.rdbGioiTinhNu.UseVisualStyleBackColor = true;
            // 
            // rdbGioiTinhNam
            // 
            this.rdbGioiTinhNam.AutoSize = true;
            this.rdbGioiTinhNam.Checked = true;
            this.rdbGioiTinhNam.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGioiTinhNam.Location = new System.Drawing.Point(460, 27);
            this.rdbGioiTinhNam.Name = "rdbGioiTinhNam";
            this.rdbGioiTinhNam.Size = new System.Drawing.Size(65, 27);
            this.rdbGioiTinhNam.TabIndex = 8;
            this.rdbGioiTinhNam.TabStop = true;
            this.rdbGioiTinhNam.Text = "Nam";
            this.rdbGioiTinhNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(117, 170);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(147, 23);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(117, 77);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(147, 23);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(117, 32);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(147, 23);
            this.txtMaHV.TabIndex = 6;
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(355, 170);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(62, 23);
            this.lblDiachi.TabIndex = 5;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblKhoahoc
            // 
            this.lblKhoahoc.AutoSize = true;
            this.lblKhoahoc.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoahoc.Location = new System.Drawing.Point(355, 80);
            this.lblKhoahoc.Name = "lblKhoahoc";
            this.lblKhoahoc.Size = new System.Drawing.Size(82, 23);
            this.lblKhoahoc.TabIndex = 4;
            this.lblKhoahoc.Text = "Khóa học";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(355, 31);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(75, 23);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(14, 169);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(86, 23);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(14, 76);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(107, 23);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Tên học viên";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(14, 31);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(103, 23);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã học viên";
            // 
            // dgvDanhSachHocVien
            // 
            this.dgvDanhSachHocVien.AllowUserToAddRows = false;
            this.dgvDanhSachHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocVien.Location = new System.Drawing.Point(36, 370);
            this.dgvDanhSachHocVien.Name = "dgvDanhSachHocVien";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvDanhSachHocVien.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHocVien.Size = new System.Drawing.Size(484, 216);
            this.dgvDanhSachHocVien.TabIndex = 2;
            this.dgvDanhSachHocVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHocVien_CellContentClick);
            this.dgvDanhSachHocVien.Click += new System.EventHandler(this.dgvDanhSachHocVien_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnTimKiem);
            this.gbTimKiem.Controls.Add(this.txtTimKiem);
            this.gbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimKiem.ForeColor = System.Drawing.Color.White;
            this.gbTimKiem.Location = new System.Drawing.Point(36, 290);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(642, 64);
            this.gbTimKiem.TabIndex = 7;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Location = new System.Drawing.Point(307, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(3, 33);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(298, 23);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "Nhập vào tên học viên cần tìm ...";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // picturebox
            // 
            this.picturebox.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Supervisor_icon1;
            this.picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturebox.ErrorImage = global::QuanLyHocSinh.Properties.Resources.icon1;
            this.picturebox.Location = new System.Drawing.Point(11, 6);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(35, 38);
            this.picturebox.TabIndex = 8;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.picturebox_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Thoat;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Location = new System.Drawing.Point(605, 518);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(73, 68);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Blue;
            this.btnHuy.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Huy;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Location = new System.Drawing.Point(606, 444);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 68);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Orange;
            this.btnLuu.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Luu;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Location = new System.Drawing.Point(606, 370);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 68);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Purple;
            this.btnSua.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.sua;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(526, 518);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 68);
            this.btnSua.TabIndex = 3;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(526, 444);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 68);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Them;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(526, 370);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 68);
            this.btnThem.TabIndex = 3;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(710, 596);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSachHocVien);
            this.Controls.Add(this.gbThongTinHocSinh);
            this.Controls.Add(this.lblTieuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyHocVien";
            this.Text = "Quản Lý Học Viên";
            this.Load += new System.EventHandler(this.frmQuanLyHocSinh_Load);
            this.gbThongTinHocSinh.ResumeLayout(false);
            this.gbThongTinHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).EndInit();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox gbThongTinHocSinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cmbKhoaHoc;
        private System.Windows.Forms.RadioButton rdbGioiTinhNu;
        private System.Windows.Forms.RadioButton rdbGioiTinhNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblKhoahoc;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.DataGridView dgvDanhSachHocVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}

