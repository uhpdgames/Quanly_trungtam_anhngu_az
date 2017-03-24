namespace QuanLyHocSinh
{
    partial class frmDanhSachLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachLopHoc));
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.btnThoatRa = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.AllowUserToAddRows = false;
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(12, 85);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvDanhSachLop.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(772, 328);
            this.dgvDanhSachLop.TabIndex = 3;
            // 
            // btnThoatRa
            // 
            this.btnThoatRa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.btnThoatRa.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Thoat;
            this.btnThoatRa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoatRa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoatRa.Location = new System.Drawing.Point(711, 11);
            this.btnThoatRa.Name = "btnThoatRa";
            this.btnThoatRa.Size = new System.Drawing.Size(73, 68);
            this.btnThoatRa.TabIndex = 48;
            this.btnThoatRa.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("UVN Ba Le", 30F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(104, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 54);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "Danh Sách Lớp";
            // 
            // frmDanhSachLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(796, 425);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnThoatRa);
            this.Controls.Add(this.dgvDanhSachLop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDanhSachLopHoc";
            this.Text = "Danh Sách Lớp Học";
            this.Load += new System.EventHandler(this.frmDanhSachLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachLop;
        private System.Windows.Forms.Button btnThoatRa;
        private System.Windows.Forms.Label lblTitle;
    }
}