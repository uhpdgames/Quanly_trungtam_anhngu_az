namespace QuanLyHocSinh
{
    partial class frmConnectDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectDatabase));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbServerName = new System.Windows.Forms.ComboBox();
            this.cbAuthenticationType = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ckbShowCharacter = new System.Windows.Forms.CheckBox();
            this.txtConnectStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExistDbStatus = new System.Windows.Forms.TextBox();
            this.btCheckDb = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btDeleteDb = new System.Windows.Forms.Button();
            this.btCreateDb = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.pnConnection = new System.Windows.Forms.Panel();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.txtDatabaseName = new System.Windows.Forms.ComboBox();
            this.btnTaoDuLieuMau = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnConnection.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("UVN Ba Le", 30F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 54);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "SQL Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên máy chủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Kiểu xác thực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(41, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(41, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mật khẩu";
            // 
            // cbServerName
            // 
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.Location = new System.Drawing.Point(161, 99);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(202, 21);
            this.cbServerName.TabIndex = 55;
            this.cbServerName.SelectedIndexChanged += new System.EventHandler(this.cbServerName_SelectedIndexChanged);
            // 
            // cbAuthenticationType
            // 
            this.cbAuthenticationType.FormattingEnabled = true;
            this.cbAuthenticationType.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbAuthenticationType.Location = new System.Drawing.Point(161, 138);
            this.cbAuthenticationType.Name = "cbAuthenticationType";
            this.cbAuthenticationType.Size = new System.Drawing.Size(202, 21);
            this.cbAuthenticationType.TabIndex = 56;
            this.cbAuthenticationType.SelectedIndexChanged += new System.EventHandler(this.cbAuthenticationType_SelectedIndexChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(161, 192);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(202, 20);
            this.txtUserName.TabIndex = 57;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(161, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 20);
            this.txtPassword.TabIndex = 58;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // ckbShowCharacter
            // 
            this.ckbShowCharacter.AutoSize = true;
            this.ckbShowCharacter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.ckbShowCharacter.ForeColor = System.Drawing.SystemColors.Window;
            this.ckbShowCharacter.Location = new System.Drawing.Point(378, 231);
            this.ckbShowCharacter.Name = "ckbShowCharacter";
            this.ckbShowCharacter.Size = new System.Drawing.Size(127, 21);
            this.ckbShowCharacter.TabIndex = 60;
            this.ckbShowCharacter.Text = "Hiển thị mật khẩu";
            this.ckbShowCharacter.UseVisualStyleBackColor = true;
            this.ckbShowCharacter.CheckedChanged += new System.EventHandler(this.ckbShowCharacter_CheckedChanged);
            // 
            // txtConnectStatus
            // 
            this.txtConnectStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtConnectStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConnectStatus.Location = new System.Drawing.Point(6, 19);
            this.txtConnectStatus.Multiline = true;
            this.txtConnectStatus.Name = "txtConnectStatus";
            this.txtConnectStatus.Size = new System.Drawing.Size(312, 57);
            this.txtConnectStatus.TabIndex = 62;
            this.txtConnectStatus.TextChanged += new System.EventHandler(this.txtConnectStatus_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConnectStatus);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(45, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 82);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhật ký trạng thái kết nối đến SQL Server:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Ba Le", 30F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 54);
            this.label5.TabIndex = 64;
            this.label5.Text = "Cơ Sở Dữ Liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(38, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Tên cơ sở dữ liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExistDbStatus);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(45, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 85);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhật ký trạng thái kết nối đến cơ sở dữ liệu:";
            // 
            // txtExistDbStatus
            // 
            this.txtExistDbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtExistDbStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtExistDbStatus.Location = new System.Drawing.Point(6, 19);
            this.txtExistDbStatus.Multiline = true;
            this.txtExistDbStatus.Name = "txtExistDbStatus";
            this.txtExistDbStatus.Size = new System.Drawing.Size(312, 60);
            this.txtExistDbStatus.TabIndex = 62;
            // 
            // btCheckDb
            // 
            this.btCheckDb.BackColor = System.Drawing.Color.Olive;
            this.btCheckDb.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.server_check;
            this.btCheckDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCheckDb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheckDb.Location = new System.Drawing.Point(458, 5);
            this.btCheckDb.Name = "btCheckDb";
            this.btCheckDb.Size = new System.Drawing.Size(73, 66);
            this.btCheckDb.TabIndex = 72;
            this.btCheckDb.UseVisualStyleBackColor = false;
            this.btCheckDb.Click += new System.EventHandler(this.btCheckDb_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Orange;
            this.btSave.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Luu;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Location = new System.Drawing.Point(460, 83);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(73, 68);
            this.btSave.TabIndex = 71;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDeleteDb
            // 
            this.btDeleteDb.BackColor = System.Drawing.Color.Teal;
            this.btDeleteDb.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Xoa;
            this.btDeleteDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDeleteDb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeleteDb.Location = new System.Drawing.Point(381, 157);
            this.btDeleteDb.Name = "btDeleteDb";
            this.btDeleteDb.Size = new System.Drawing.Size(73, 68);
            this.btDeleteDb.TabIndex = 70;
            this.btDeleteDb.UseVisualStyleBackColor = false;
            this.btDeleteDb.Click += new System.EventHandler(this.btDeleteDb_Click);
            // 
            // btCreateDb
            // 
            this.btCreateDb.BackColor = System.Drawing.Color.Green;
            this.btCreateDb.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Them;
            this.btCreateDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCreateDb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCreateDb.Location = new System.Drawing.Point(381, 83);
            this.btCreateDb.Name = "btCreateDb";
            this.btCreateDb.Size = new System.Drawing.Size(73, 68);
            this.btCreateDb.TabIndex = 69;
            this.btCreateDb.UseVisualStyleBackColor = false;
            this.btCreateDb.Click += new System.EventHandler(this.btCreateDb_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.btExit.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Thoat;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExit.Location = new System.Drawing.Point(460, 157);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(73, 68);
            this.btExit.TabIndex = 67;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.Color.OliveDrab;
            this.btConnect.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.server;
            this.btConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConnect.Location = new System.Drawing.Point(381, 270);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(73, 66);
            this.btConnect.TabIndex = 61;
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // pnConnection
            // 
            this.pnConnection.BackColor = System.Drawing.Color.Transparent;
            this.pnConnection.Controls.Add(this.lblTitle);
            this.pnConnection.Controls.Add(this.label1);
            this.pnConnection.Controls.Add(this.label2);
            this.pnConnection.Controls.Add(this.label3);
            this.pnConnection.Controls.Add(this.label4);
            this.pnConnection.Controls.Add(this.cbServerName);
            this.pnConnection.Controls.Add(this.cbAuthenticationType);
            this.pnConnection.Controls.Add(this.txtUserName);
            this.pnConnection.Controls.Add(this.txtPassword);
            this.pnConnection.Controls.Add(this.ckbShowCharacter);
            this.pnConnection.Controls.Add(this.groupBox1);
            this.pnConnection.Controls.Add(this.btConnect);
            this.pnConnection.Location = new System.Drawing.Point(-3, -27);
            this.pnConnection.Name = "pnConnection";
            this.pnConnection.Size = new System.Drawing.Size(536, 353);
            this.pnConnection.TabIndex = 73;
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnStatus.Controls.Add(this.btnTaoDuLieuMau);
            this.pnStatus.Controls.Add(this.btCheckDb);
            this.pnStatus.Controls.Add(this.txtDatabaseName);
            this.pnStatus.Controls.Add(this.label5);
            this.pnStatus.Controls.Add(this.label6);
            this.pnStatus.Controls.Add(this.btSave);
            this.pnStatus.Controls.Add(this.btDeleteDb);
            this.pnStatus.Controls.Add(this.groupBox2);
            this.pnStatus.Controls.Add(this.btCreateDb);
            this.pnStatus.Controls.Add(this.btExit);
            this.pnStatus.Location = new System.Drawing.Point(-3, 331);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(536, 238);
            this.pnStatus.TabIndex = 74;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.FormattingEnabled = true;
            this.txtDatabaseName.Location = new System.Drawing.Point(161, 86);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(202, 21);
            this.txtDatabaseName.TabIndex = 72;
            this.txtDatabaseName.SelectedIndexChanged += new System.EventHandler(this.txtDatabaseName_SelectedIndexChanged_1);
            // 
            // btnTaoDuLieuMau
            // 
            this.btnTaoDuLieuMau.BackColor = System.Drawing.Color.Green;
            this.btnTaoDuLieuMau.BackgroundImage = global::QuanLyHocSinh.Properties.Resources.Them;
            this.btnTaoDuLieuMau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTaoDuLieuMau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaoDuLieuMau.Location = new System.Drawing.Point(381, 3);
            this.btnTaoDuLieuMau.Name = "btnTaoDuLieuMau";
            this.btnTaoDuLieuMau.Size = new System.Drawing.Size(73, 68);
            this.btnTaoDuLieuMau.TabIndex = 73;
            this.btnTaoDuLieuMau.UseVisualStyleBackColor = false;
            // 
            // frmConnectDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(540, 575);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.pnConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConnectDatabase";
            this.Text = "Kết Nối Đến SQL Server";
            this.Load += new System.EventHandler(this.frmConnectDatabase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnConnection.ResumeLayout(false);
            this.pnConnection.PerformLayout();
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbServerName;
        private System.Windows.Forms.ComboBox cbAuthenticationType;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox ckbShowCharacter;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txtConnectStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExistDbStatus;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCreateDb;
        private System.Windows.Forms.Button btDeleteDb;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCheckDb;
        private System.Windows.Forms.Panel pnConnection;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.ComboBox txtDatabaseName;
        private System.Windows.Forms.Button btnTaoDuLieuMau;
    }
}