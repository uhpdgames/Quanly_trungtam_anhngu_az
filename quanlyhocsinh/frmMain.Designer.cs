namespace QuanLyHocSinh
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmNhapDiem = new System.Windows.Forms.Timer(this.components);
            this.btnQuiDinh = new System.Windows.Forms.Button();
            this.btnPhanLop = new System.Windows.Forms.Button();
            this.btnLopHoc = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnChungchi = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.btnHocSinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(358, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PHẦN MỀM QUẢN LÝ TRUNG TÂM ANH NGỮ A-Z";
            // 
            // tmNhapDiem
            // 
            this.tmNhapDiem.Interval = 1;
            this.tmNhapDiem.Tick += new System.EventHandler(this.tmNhapDiem_Tick);
            // 
            // btnQuiDinh
            // 
            this.btnQuiDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.btnQuiDinh.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.quidinh;
            this.btnQuiDinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuiDinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuiDinh.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiDinh.ForeColor = System.Drawing.Color.White;
            this.btnQuiDinh.Location = new System.Drawing.Point(771, 234);
            this.btnQuiDinh.Name = "btnQuiDinh";
            this.btnQuiDinh.Size = new System.Drawing.Size(236, 113);
            this.btnQuiDinh.TabIndex = 10;
            this.btnQuiDinh.Text = "Quy định";
            this.btnQuiDinh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuiDinh.UseVisualStyleBackColor = false;
            this.btnQuiDinh.Click += new System.EventHandler(this.btnQuiDinh_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnPhanLop.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.PhanLop;
            this.btnPhanLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPhanLop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhanLop.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanLop.ForeColor = System.Drawing.Color.White;
            this.btnPhanLop.Location = new System.Drawing.Point(596, 353);
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.Size = new System.Drawing.Size(411, 113);
            this.btnPhanLop.TabIndex = 9;
            this.btnPhanLop.Text = "Thoát chương trình";
            this.btnPhanLop.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPhanLop.UseVisualStyleBackColor = false;
            this.btnPhanLop.Click += new System.EventHandler(this.btnPhanLop_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnLopHoc.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.lophoc;
            this.btnLopHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLopHoc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopHoc.ForeColor = System.Drawing.Color.White;
            this.btnLopHoc.Location = new System.Drawing.Point(771, 95);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(236, 133);
            this.btnLopHoc.TabIndex = 8;
            this.btnLopHoc.Text = "Lớp học";
            this.btnLopHoc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLopHoc.UseVisualStyleBackColor = false;
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(26)))), ((int)(((byte)(63)))));
            this.btnGiaoVien.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.GiaoVien;
            this.btnGiaoVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiaoVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiaoVien.Location = new System.Drawing.Point(596, 95);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(169, 252);
            this.btnGiaoVien.TabIndex = 7;
            this.btnGiaoVien.Text = "Giảng Viên";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGiaoVien.UseVisualStyleBackColor = false;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnThongke.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.ThongKe;
            this.btnThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Location = new System.Drawing.Point(345, 353);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(169, 110);
            this.btnThongke.TabIndex = 6;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click_1);
            // 
            // btnDiem
            // 
            this.btnDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(68)))), ((int)(((byte)(30)))));
            this.btnDiem.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.NhapDiem;
            this.btnDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.Location = new System.Drawing.Point(162, 234);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(177, 110);
            this.btnDiem.TabIndex = 5;
            this.btnDiem.Text = "Điểm thi";
            this.btnDiem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDiem.UseVisualStyleBackColor = false;
            this.btnDiem.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnChungchi
            // 
            this.btnChungchi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(1)))), ((int)(((byte)(168)))));
            this.btnChungchi.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.NhapDiem1;
            this.btnChungchi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChungchi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChungchi.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChungchi.ForeColor = System.Drawing.Color.White;
            this.btnChungchi.Location = new System.Drawing.Point(345, 234);
            this.btnChungchi.Name = "btnChungchi";
            this.btnChungchi.Size = new System.Drawing.Size(169, 113);
            this.btnChungchi.TabIndex = 4;
            this.btnChungchi.Text = "Chứng chỉ";
            this.btnChungchi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnChungchi.UseVisualStyleBackColor = false;
            this.btnChungchi.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.btnMonHoc.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.MonHoc1;
            this.btnMonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonHoc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnMonHoc.Location = new System.Drawing.Point(162, 353);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(177, 113);
            this.btnMonHoc.TabIndex = 3;
            this.btnMonHoc.Text = "Khóa học";
            this.btnMonHoc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMonHoc.UseVisualStyleBackColor = false;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // picturebox
            // 
            this.picturebox.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.United_Kingdom_Flag_2_icon;
            this.picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturebox.ErrorImage = global::QuanLyHocSinh.Properties.Resources.icon1;
            this.picturebox.Location = new System.Drawing.Point(9, 5);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(34, 35);
            this.picturebox.TabIndex = 2;
            this.picturebox.TabStop = false;
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(54)))), ((int)(((byte)(177)))));
            this.btnHocSinh.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.HocSinh;
            this.btnHocSinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHocSinh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocSinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHocSinh.Location = new System.Drawing.Point(162, 94);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(352, 134);
            this.btnHocSinh.TabIndex = 0;
            this.btnHocSinh.Text = "Học Viên";
            this.btnHocSinh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHocSinh.UseVisualStyleBackColor = false;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1109, 612);
            this.Controls.Add(this.btnQuiDinh);
            this.Controls.Add(this.btnPhanLop);
            this.Controls.Add(this.btnLopHoc);
            this.Controls.Add(this.btnGiaoVien);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.btnDiem);
            this.Controls.Add(this.btnChungchi);
            this.Controls.Add(this.btnMonHoc);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnHocSinh);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Danh Mục";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnChungchi;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnLopHoc;
        private System.Windows.Forms.Button btnPhanLop;
        private System.Windows.Forms.Button btnQuiDinh;
        private System.Windows.Forms.Timer tmNhapDiem;

    }
}