namespace QuanLyHocSinh
{
    partial class Diem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.cmbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grbNhapLop = new System.Windows.Forms.GroupBox();
            this.combo_Lophoc = new System.Windows.Forms.ComboBox();
            this.combo_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.rdbGioiTinhNam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.dgvDanhSachHocVien = new System.Windows.Forms.DataGridView();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.gbThongTinHocSinh.SuspendLayout();
            this.grbNhapLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinHocSinh
            // 
            this.gbThongTinHocSinh.Controls.Add(this.comboBox1);
            this.gbThongTinHocSinh.Controls.Add(this.radioButton1);
            this.gbThongTinHocSinh.Controls.Add(this.label2);
            this.gbThongTinHocSinh.Controls.Add(this.rdbGioiTinhNam);
            this.gbThongTinHocSinh.Controls.Add(this.txtsdt);
            this.gbThongTinHocSinh.Controls.Add(this.lblsdt);
            this.gbThongTinHocSinh.Controls.Add(this.cmbKhoaHoc);
            this.gbThongTinHocSinh.Controls.Add(this.dtpNgaySinh);
            this.gbThongTinHocSinh.Controls.Add(this.txtMaHV);
            this.gbThongTinHocSinh.Controls.Add(this.lblDiachi);
            this.gbThongTinHocSinh.Controls.Add(this.lblNgaySinh);
            this.gbThongTinHocSinh.Controls.Add(this.lblHoTen);
            this.gbThongTinHocSinh.Controls.Add(this.lblMaHS);
            this.gbThongTinHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbThongTinHocSinh.ForeColor = System.Drawing.Color.White;
            this.gbThongTinHocSinh.Location = new System.Drawing.Point(222, 81);
            this.gbThongTinHocSinh.Name = "gbThongTinHocSinh";
            this.gbThongTinHocSinh.Size = new System.Drawing.Size(663, 201);
            this.gbThongTinHocSinh.TabIndex = 2;
            this.gbThongTinHocSinh.TabStop = false;
            this.gbThongTinHocSinh.Text = "Thông tin điểm thi của học viên";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(127, 91);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(147, 23);
            this.txtsdt.TabIndex = 14;
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.Location = new System.Drawing.Point(14, 91);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(75, 23);
            this.lblsdt.TabIndex = 11;
            this.lblsdt.Text = "Điểm thi";
            // 
            // cmbKhoaHoc
            // 
            this.cmbKhoaHoc.FormattingEnabled = true;
            this.cmbKhoaHoc.Location = new System.Drawing.Point(127, 48);
            this.cmbKhoaHoc.Name = "cmbKhoaHoc";
            this.cmbKhoaHoc.Size = new System.Drawing.Size(147, 23);
            this.cmbKhoaHoc.TabIndex = 9;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(484, 48);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(152, 23);
            this.txtMaHV.TabIndex = 6;
            this.txtMaHV.TextChanged += new System.EventHandler(this.txtMaHV_TextChanged);
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(357, 95);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(79, 23);
            this.lblDiachi.TabIndex = 5;
            this.lblDiachi.Text = "Đánh giá";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblHoTen.Location = new System.Drawing.Point(14, 48);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(107, 23);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Tên học viên";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(357, 48);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(103, 23);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã học viên";
            this.lblMaHS.Click += new System.EventHandler(this.lblMaHS_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("UVN Ba Le", 30F);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(59, 8);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(319, 54);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Điểm thi cấp chứng chỉ";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // grbNhapLop
            // 
            this.grbNhapLop.Controls.Add(this.combo_Lophoc);
            this.grbNhapLop.Controls.Add(this.combo_KhoaHoc);
            this.grbNhapLop.Controls.Add(this.label3);
            this.grbNhapLop.Controls.Add(this.label1);
            this.grbNhapLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbNhapLop.ForeColor = System.Drawing.Color.White;
            this.grbNhapLop.Location = new System.Drawing.Point(16, 81);
            this.grbNhapLop.Name = "grbNhapLop";
            this.grbNhapLop.Size = new System.Drawing.Size(189, 201);
            this.grbNhapLop.TabIndex = 30;
            this.grbNhapLop.TabStop = false;
            this.grbNhapLop.Text = "Thông tin khóa học - lớp học";
            // 
            // combo_Lophoc
            // 
            this.combo_Lophoc.FormattingEnabled = true;
            this.combo_Lophoc.Location = new System.Drawing.Point(18, 137);
            this.combo_Lophoc.Name = "combo_Lophoc";
            this.combo_Lophoc.Size = new System.Drawing.Size(137, 23);
            this.combo_Lophoc.TabIndex = 55;
            // 
            // combo_KhoaHoc
            // 
            this.combo_KhoaHoc.FormattingEnabled = true;
            this.combo_KhoaHoc.Location = new System.Drawing.Point(18, 63);
            this.combo_KhoaHoc.Name = "combo_KhoaHoc";
            this.combo_KhoaHoc.Size = new System.Drawing.Size(137, 23);
            this.combo_KhoaHoc.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khóa học";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(127, 137);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(147, 23);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(14, 137);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(75, 23);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày thi";
            // 
            // rdbGioiTinhNam
            // 
            this.rdbGioiTinhNam.AutoSize = true;
            this.rdbGioiTinhNam.Checked = true;
            this.rdbGioiTinhNam.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGioiTinhNam.Location = new System.Drawing.Point(470, 93);
            this.rdbGioiTinhNam.Name = "rdbGioiTinhNam";
            this.rdbGioiTinhNam.Size = new System.Drawing.Size(55, 27);
            this.rdbGioiTinhNam.TabIndex = 15;
            this.rdbGioiTinhNam.TabStop = true;
            this.rdbGioiTinhNam.Text = "Đạt";
            this.rdbGioiTinhNam.UseVisualStyleBackColor = true;
            this.rdbGioiTinhNam.CheckedChanged += new System.EventHandler(this.rdbGioiTinhNam_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Loại chứng chỉ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(535, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 27);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Không đạt";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(484, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 23);
            this.comboBox1.TabIndex = 56;
            // 
            // picturebox
            // 
            this.picturebox.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.korganizer_icon;
            this.picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturebox.ErrorImage = null;
            this.picturebox.Location = new System.Drawing.Point(12, 12);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(53, 50);
            this.picturebox.TabIndex = 9;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.picturebox_Click);
            // 
            // dgvDanhSachHocVien
            // 
            this.dgvDanhSachHocVien.AllowUserToAddRows = false;
            this.dgvDanhSachHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocVien.Location = new System.Drawing.Point(16, 301);
            this.dgvDanhSachHocVien.Name = "dgvDanhSachHocVien";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvDanhSachHocVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHocVien.Size = new System.Drawing.Size(715, 216);
            this.dgvDanhSachHocVien.TabIndex = 31;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnNhapDiem.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.btnNhapDiem;
            this.btnNhapDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhapDiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhapDiem.Location = new System.Drawing.Point(737, 301);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(73, 68);
            this.btnNhapDiem.TabIndex = 36;
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTinhDiem.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.btnTinhDiem2;
            this.btnTinhDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinhDiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTinhDiem.Location = new System.Drawing.Point(737, 375);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(73, 68);
            this.btnTinhDiem.TabIndex = 35;
            this.btnTinhDiem.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.btnThoat.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Thoat;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Location = new System.Drawing.Point(816, 449);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(73, 68);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(156)))));
            this.btnHuy.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Huy;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Location = new System.Drawing.Point(816, 375);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 68);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Luu;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Location = new System.Drawing.Point(816, 301);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 68);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.BackColor = System.Drawing.Color.BlueViolet;
            this.btnXemDiem.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.btnXemDiem;
            this.btnXemDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemDiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXemDiem.Location = new System.Drawing.Point(737, 449);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(73, 68);
            this.btnXemDiem.TabIndex = 37;
            this.btnXemDiem.UseVisualStyleBackColor = false;
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(919, 538);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.btnTinhDiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDanhSachHocVien);
            this.Controls.Add(this.grbNhapLop);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.gbThongTinHocSinh);
            this.Name = "Diem";
            this.Text = "Điểm thi cấp chứng chỉ";
            this.Load += new System.EventHandler(this.Diem_Load);
            this.gbThongTinHocSinh.ResumeLayout(false);
            this.gbThongTinHocSinh.PerformLayout();
            this.grbNhapLop.ResumeLayout(false);
            this.grbNhapLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinHocSinh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.ComboBox cmbKhoaHoc;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.GroupBox grbNhapLop;
        private System.Windows.Forms.ComboBox combo_Lophoc;
        private System.Windows.Forms.ComboBox combo_KhoaHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbGioiTinhNam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachHocVien;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXemDiem;
    }
}