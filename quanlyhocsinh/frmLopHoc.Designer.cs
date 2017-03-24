namespace QuanLyHocSinh
{
    partial class frmLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopHoc));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbNhapLop = new System.Windows.Forms.GroupBox();
            this.combo_Lophoc = new System.Windows.Forms.ComboBox();
            this.combo_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbThongTinLop = new System.Windows.Forms.GroupBox();
            this.dtpNgaykt = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaybt = new System.Windows.Forms.DateTimePicker();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtSoBuoiDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGiangVien = new System.Windows.Forms.ComboBox();
            this.btnThoatRa = new System.Windows.Forms.Button();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.btnNhapLop = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.grbNhapLop.SuspendLayout();
            this.grbThongTinLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("UVN Ba Le", 30F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(132, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 54);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Nhập Danh Sách Lớp";
            // 
            // grbNhapLop
            // 
            this.grbNhapLop.Controls.Add(this.combo_Lophoc);
            this.grbNhapLop.Controls.Add(this.combo_KhoaHoc);
            this.grbNhapLop.Controls.Add(this.label3);
            this.grbNhapLop.Controls.Add(this.label1);
            this.grbNhapLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbNhapLop.ForeColor = System.Drawing.Color.White;
            this.grbNhapLop.Location = new System.Drawing.Point(12, 126);
            this.grbNhapLop.Name = "grbNhapLop";
            this.grbNhapLop.Size = new System.Drawing.Size(206, 197);
            this.grbNhapLop.TabIndex = 29;
            this.grbNhapLop.TabStop = false;
            this.grbNhapLop.Text = "Chọn lớp học của khóa học";
            // 
            // combo_Lophoc
            // 
            this.combo_Lophoc.FormattingEnabled = true;
            this.combo_Lophoc.Location = new System.Drawing.Point(18, 152);
            this.combo_Lophoc.Name = "combo_Lophoc";
            this.combo_Lophoc.Size = new System.Drawing.Size(154, 23);
            this.combo_Lophoc.TabIndex = 55;
            // 
            // combo_KhoaHoc
            // 
            this.combo_KhoaHoc.FormattingEnabled = true;
            this.combo_KhoaHoc.Location = new System.Drawing.Point(18, 72);
            this.combo_KhoaHoc.Name = "combo_KhoaHoc";
            this.combo_KhoaHoc.Size = new System.Drawing.Size(154, 23);
            this.combo_KhoaHoc.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 127);
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
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khóa học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ngày bắt đầu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(297, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(360, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sỉ số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(40, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Số buổi dạy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(40, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "Giảng viên dạy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UVN Ba Le", 30F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(165, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 54);
            this.label7.TabIndex = 41;
            this.label7.Text = "Phân Công Giảng Dạy";
            // 
            // grbThongTinLop
            // 
            this.grbThongTinLop.Controls.Add(this.dtpNgaykt);
            this.grbThongTinLop.Controls.Add(this.dtpNgaybt);
            this.grbThongTinLop.Controls.Add(this.txtMaLop);
            this.grbThongTinLop.Controls.Add(this.txtTenLop);
            this.grbThongTinLop.Controls.Add(this.txtSiSo);
            this.grbThongTinLop.Controls.Add(this.txtSoBuoiDay);
            this.grbThongTinLop.Controls.Add(this.label10);
            this.grbThongTinLop.Controls.Add(this.label9);
            this.grbThongTinLop.Controls.Add(this.cmbGiangVien);
            this.grbThongTinLop.Controls.Add(this.label2);
            this.grbThongTinLop.Controls.Add(this.label4);
            this.grbThongTinLop.Controls.Add(this.label5);
            this.grbThongTinLop.Controls.Add(this.label6);
            this.grbThongTinLop.Controls.Add(this.label8);
            this.grbThongTinLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbThongTinLop.ForeColor = System.Drawing.Color.White;
            this.grbThongTinLop.Location = new System.Drawing.Point(239, 126);
            this.grbThongTinLop.Name = "grbThongTinLop";
            this.grbThongTinLop.Size = new System.Drawing.Size(545, 197);
            this.grbThongTinLop.TabIndex = 46;
            this.grbThongTinLop.TabStop = false;
            this.grbThongTinLop.Text = "Thông tin lớp học";
            // 
            // dtpNgaykt
            // 
            this.dtpNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykt.Location = new System.Drawing.Point(409, 72);
            this.dtpNgaykt.Name = "dtpNgaykt";
            this.dtpNgaykt.Size = new System.Drawing.Size(109, 23);
            this.dtpNgaykt.TabIndex = 53;
            // 
            // dtpNgaybt
            // 
            this.dtpNgaybt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybt.Location = new System.Drawing.Point(149, 75);
            this.dtpNgaybt.Name = "dtpNgaybt";
            this.dtpNgaybt.Size = new System.Drawing.Size(138, 23);
            this.dtpNgaybt.TabIndex = 52;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(409, 39);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(109, 23);
            this.txtMaLop.TabIndex = 51;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(149, 39);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.ReadOnly = true;
            this.txtTenLop.Size = new System.Drawing.Size(138, 23);
            this.txtTenLop.TabIndex = 50;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(409, 111);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(109, 23);
            this.txtSiSo.TabIndex = 49;
            // 
            // txtSoBuoiDay
            // 
            this.txtSoBuoiDay.Location = new System.Drawing.Point(152, 112);
            this.txtSoBuoiDay.Name = "txtSoBuoiDay";
            this.txtSoBuoiDay.Size = new System.Drawing.Size(138, 23);
            this.txtSoBuoiDay.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(344, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "Mã lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(40, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tên lớp học";
            // 
            // cmbGiangVien
            // 
            this.cmbGiangVien.FormattingEnabled = true;
            this.cmbGiangVien.Location = new System.Drawing.Point(153, 150);
            this.cmbGiangVien.Name = "cmbGiangVien";
            this.cmbGiangVien.Size = new System.Drawing.Size(137, 23);
            this.cmbGiangVien.TabIndex = 4;
            // 
            // btnThoatRa
            // 
            this.btnThoatRa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.btnThoatRa.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Thoat;
            this.btnThoatRa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoatRa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoatRa.Location = new System.Drawing.Point(711, 403);
            this.btnThoatRa.Name = "btnThoatRa";
            this.btnThoatRa.Size = new System.Drawing.Size(73, 68);
            this.btnThoatRa.TabIndex = 47;
            this.btnThoatRa.UseVisualStyleBackColor = false;
            this.btnThoatRa.Click += new System.EventHandler(this.btnThoatRa_Click);
            // 
            // picturebox
            // 
            this.picturebox.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.lop;
            this.picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturebox.ErrorImage = global::QuanLyHocSinh.Properties.Resources.icon1;
            this.picturebox.Location = new System.Drawing.Point(4, 7);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(122, 101);
            this.picturebox.TabIndex = 32;
            this.picturebox.TabStop = false;
            // 
            // btnNhapLop
            // 
            this.btnNhapLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnNhapLop.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.btnNhapDiem;
            this.btnNhapLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhapLop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhapLop.Location = new System.Drawing.Point(632, 329);
            this.btnNhapLop.Name = "btnNhapLop";
            this.btnNhapLop.Size = new System.Drawing.Size(73, 68);
            this.btnNhapLop.TabIndex = 40;
            this.btnNhapLop.UseVisualStyleBackColor = false;
            this.btnNhapLop.Click += new System.EventHandler(this.btnNhapLop_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.btnThoat.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Thoat;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Location = new System.Drawing.Point(1334, 430);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(73, 68);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(156)))));
            this.btnHuy.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Huy;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Location = new System.Drawing.Point(632, 403);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 68);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Luu;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Location = new System.Drawing.Point(711, 329);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 68);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.AllowUserToAddRows = false;
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(12, 329);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvDanhSachLop.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(614, 142);
            this.dgvDanhSachLop.TabIndex = 48;
            this.dgvDanhSachLop.Click += new System.EventHandler(this.dgvDanhSachLop_Click);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(796, 479);
            this.Controls.Add(this.dgvDanhSachLop);
            this.Controls.Add(this.btnThoatRa);
            this.Controls.Add(this.grbThongTinLop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.btnNhapLop);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbNhapLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLopHoc";
            this.Text = "Quản lý Lớp";
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            this.grbNhapLop.ResumeLayout(false);
            this.grbNhapLop.PerformLayout();
            this.grbThongTinLop.ResumeLayout(false);
            this.grbThongTinLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button btnNhapLop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbNhapLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbThongTinLop;
        private System.Windows.Forms.ComboBox cmbGiangVien;
        private System.Windows.Forms.Button btnThoatRa;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtSoBuoiDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.DateTimePicker dtpNgaykt;
        private System.Windows.Forms.DateTimePicker dtpNgaybt;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;
        private System.Windows.Forms.ComboBox combo_KhoaHoc;
        private System.Windows.Forms.ComboBox combo_Lophoc;


    }
}