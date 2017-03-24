using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.Win32;
using DTO;

namespace QuanLyHocSinh
{
    public partial class frmConnectDatabase : Form
    {
        #region Các biến
        private bool IntegratedSecurity;
        private Server LayTenCSDLCuaServer;
        private ServerConnection ServerConn;
        private string TenServer;
        private string TenCSDL;
        private string TenTaiKhoan;
        private string MatKhau;
        private string ThongTinKetNoiServer;
        private string ThongTinKetNoiCSDL;
        private bool KetQuaKetNoiServer = false;
        private bool KetQuaKetNoiCSDL = false;
        private List<string> DanhSachTenServer;
        #endregion
        public frmConnectDatabase()
        {
            InitializeComponent();
        }

        #region Sự kiện của form
        // Sự kiện Form load
        private void frmConnectDatabase_Load(object sender, EventArgs e)
        {
            cbAuthenticationType.SelectedIndex = 0;
            IntegratedSecurity = true;
            pnConnection.Enabled = true;
            pnStatus.Enabled = false;
            DanhSachTenServer = LayTatCaTenServer();

            foreach (string s in DanhSachTenServer)
                cbServerName.Items.Add(s);

            cbServerName.SelectedIndex = 0;

        }

        // Sự kiện của comboBox # Tên Server
        private void cbServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TenServer = cbServerName.Text;
        }

        // Sự kiện của comboBox # Kiểu xác thực
        private void cbAuthenticationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthenticationType.SelectedIndex == 0)
            {
                txtPassword.Clear();
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
                txtConnectStatus.Clear();
                txtUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
                IntegratedSecurity = true;
                ckbShowCharacter.Enabled = false;
            }
            else
            {
                txtPassword.Clear();
                txtPassword.Enabled = true;
                txtConnectStatus.Clear();
                txtUserName.Clear();
                txtUserName.Enabled = true;
                IntegratedSecurity = false;
                ckbShowCharacter.Enabled = true;
            }
        }

        // Sự kiện của textBox # Tên tài khoản
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            TenTaiKhoan = txtUserName.Text;
        }

        // Sự kiện của textBox # Mật khẩu
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            MatKhau = txtPassword.Text;
            if (cbAuthenticationType.SelectedIndex == 1)
                txtPassword.UseSystemPasswordChar = true;
        }

        // Sự kiện của checkbox # Hiển thị mật khẩu
        private void ckbShowCharacter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowCharacter.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        // Sự kiện của button # Kết nối
        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAuthenticationType.SelectedIndex == 0)
                {
                    if (KetNoiDenServer(ChuoiKetNoiDenServer(TenServer, "master", IntegratedSecurity)))
                    {
                        KetQuaKetNoiServer = true;
                        ServerConn = new ServerConnection(cbServerName.Text);
                        LayTenCSDLCuaServer = new Server(ServerConn);
                    }
                }
                else
                {
                    if (KetNoiDenServer(ChuoiKetNoiDenServer(TenServer, "master", TenTaiKhoan, MatKhau, IntegratedSecurity)))
                    {
                        KetQuaKetNoiServer = true;
                        ServerConn = new ServerConnection(cbServerName.Text);
                        LayTenCSDLCuaServer = new Server(ServerConn);
                    }
                }
                DanhSachCSDL();
                if (KetQuaKetNoiServer == true)
                {
                    ThongTinKetNoiServer = "\nKết nối đến SQL Server thành công! Tên Server: " + TenServer;
                    pnConnection.Enabled = false;
                    pnStatus.Enabled = true;
                    txtConnectStatus.Text = ThongTinKetNoiServer;

                }
                else
                {
                    ThongTinKetNoiServer = "\nKết nối đến SQL Server thất bại!\nXin kiểm tra lại!";
                    pnConnection.Enabled = true;
                    pnStatus.Enabled = false;
                    txtConnectStatus.Text = ThongTinKetNoiServer;
                }
            }
            catch (Exception ex)
            {
                ThongTinKetNoiServer = "Có lỗi xảy ra: " + ex.Message;
                txtConnectStatus.Text = ThongTinKetNoiServer;
            }

        }

        // Sự kiện của textBox # Thông tin kết nối server
        private void txtConnectStatus_TextChanged(object sender, EventArgs e)
        {
            txtConnectStatus.Text = ThongTinKetNoiServer;
        }

        // Sự kiện của comboBox # Tên cơ sở dữ liệu
        //private void txtDatabaseName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    TenCSDL = txtDatabaseName.Text;
        //    btCheckDb.Enabled = true;
        //    btDeleteDb.Enabled = true;
        //    btCreateDb.Enabled = false;
        //    btnTaoDuLieuMau.Enabled = false;
        //}

        // Sự kiện đánh chữ vào txtDatabaseName
        private void txtDatabaseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TenCSDL = txtDatabaseName.Text;
            btCheckDb.Enabled = false;
            btDeleteDb.Enabled = false;
            btCreateDb.Enabled = true;
            btnTaoDuLieuMau.Enabled = false;
        }

        // Sự kiện của button # Kiểm tra
        private void btCheckDb_Click(object sender, EventArgs e)
        {
            if (KiemTraCSDL(txtDatabaseName.Text) == true)
            {
                btnTaoDuLieuMau.Enabled = true;
                btDeleteDb.Enabled = true;
                btCreateDb.Enabled = false;
                btCheckDb.Enabled = true;
                ThongTinKetNoiCSDL = "Cơ sở dữ liệu hợp lệ! Tên cơ sở dữ liệu: " + txtDatabaseName.Text;
                txtExistDbStatus.Text = ThongTinKetNoiCSDL;
            }
            else
            {
                btCheckDb.Enabled = true;
                btDeleteDb.Enabled = true;
                btCreateDb.Enabled = false;
                btnTaoDuLieuMau.Enabled = false;
                ThongTinKetNoiCSDL = "Cơ sở dữ liệu không hợp lệ! Vui lòng tạo mới hoặc chọn cơ sở dữ liệu khác!";
                txtExistDbStatus.Text = ThongTinKetNoiCSDL;
            }
        }


        // Sự kiện của button # Xóa txtDatabaseName
        private void btDeleteDb_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa cơ sở dữ liệu " + TenCSDL, "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (cbAuthenticationType.SelectedIndex == 0)
                    {
                        string LayChuoiKetNoi = ChuoiKetNoiDenServer(TenServer, "master", IntegratedSecurity);
                        if (XoaCSDL(LayChuoiKetNoi, TenCSDL))
                        {
                            txtExistDbStatus.Clear();
                            txtExistDbStatus.Text = "Đã xóa thành công cơ sở dữ liệu '" + TenCSDL + "' từ SQL Server " + TenServer;
                            btCheckDb.Enabled = true;
                            btDeleteDb.Enabled = false;
                            btCreateDb.Enabled = false;
                            btnTaoDuLieuMau.Enabled = false;
                            txtDatabaseName.Items.Remove(TenCSDL);
                        }
                        else
                        {
                            txtExistDbStatus.Text = "Có lỗi xảy ra! Không thể xóa cơ sở dữ liệu: " + TenCSDL;
                        }

                    }
                    else
                    {
                        string LayChuoiKetNoi = ChuoiKetNoiDenServer(TenServer, "master", TenTaiKhoan, MatKhau, IntegratedSecurity);
                        if (XoaCSDL(LayChuoiKetNoi, TenCSDL))
                        {
                            txtExistDbStatus.Clear();
                            txtExistDbStatus.Text = "Đã xóa thành công cơ sở dữ liệu '" + TenCSDL + "' từ SQL Server " + TenServer;
                            btCheckDb.Enabled = true;
                            btDeleteDb.Enabled = false;
                            btCreateDb.Enabled = false;
                            btnTaoDuLieuMau.Enabled = false;
                        }
                        else
                        {
                            txtExistDbStatus.Text = "Có lỗi xảy ra! Không thể xóa cơ sở dữ liệ: " + TenCSDL;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ThongTinKetNoiCSDL = ex.Message;
                txtExistDbStatus.Text = "Có lỗi xãy ra: " + ThongTinKetNoiCSDL;
            }
        }


        // Sử kiện của button # Tạo mới
        private void btCreateDb_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (cbAuthenticationType.SelectedIndex == 0)
                {
                    string LayChuoiKetNoi = ChuoiKetNoiDenServer(TenServer, "master", IntegratedSecurity);
                    if (TaoMoiCSDL(LayChuoiKetNoi, TenCSDL, @"ScriptFile\\script.sql"))
                    {
                        txtExistDbStatus.Clear();
                        txtExistDbStatus.Text = "Đã tạo thành công cơ sở dữ liệu '" + TenCSDL + "' từ SQL Server " + TenServer;
                        btCheckDb.Enabled = true;
                        btDeleteDb.Enabled = true;
                        btCreateDb.Enabled = false;
                        btnTaoDuLieuMau.Enabled = true;
                        txtDatabaseName.Items.Remove(TenCSDL);
                    }
                    else
                    {
                        txtExistDbStatus.Text = "Có lỗi xảy ra! Không thể tạo cơ sở dữ liệu: " + TenCSDL;
                        this.Cursor = Cursors.Default;
                    }

                }
                else
                {
                    string LayChuoiKetNoi = ChuoiKetNoiDenServer(TenServer, "master", TenTaiKhoan, MatKhau, IntegratedSecurity);
                    if (TaoMoiCSDL(LayChuoiKetNoi, TenCSDL, @"ScriptFile\\script.sql"))
                    {
                        txtExistDbStatus.Clear();
                        txtExistDbStatus.Text = "Đã tạo thành công cơ sở dữ liệu '" + TenCSDL + "' từ SQL Server " + TenServer;
                        btCheckDb.Enabled = true;
                        btDeleteDb.Enabled = false;
                        btCreateDb.Enabled = false;
                        btnTaoDuLieuMau.Enabled = false;
                    }
                    else
                    {
                        txtExistDbStatus.Text = "Có lỗi xảy ra! Không thể tạo cơ sở dữ liệ: " + TenCSDL;
                        this.Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                ThongTinKetNoiCSDL = ex.Message;
                txtExistDbStatus.Text = "Có lỗi xảy ra: " + ThongTinKetNoiCSDL;
                this.Cursor = Cursors.Default;
            }
        }




        // Sự kiện của button # Tạo dữ liệu mẫu





        // Sự kiện của button # Lưu
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion





        #region Hàm chức năng khác
        // Lấy danh sách các server có trong máy
        public static List<string> KiemTraServer()
        {
            List<string> instanceNameArr = new List<string>();

            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        instanceNameArr.Add(instanceName);
                    }
                }
            }
            return instanceNameArr;
        }

        public static List<string> LayTatCaTenServer()
        {
            List<string> listServer = KiemTraServer();
            List<string> listTenServer = new List<string>();
            string macineName = Environment.MachineName;
            listTenServer.Add(macineName);
            foreach (string s in listServer)
            {
                listTenServer.Add(macineName + @"\" + s);
            }
            return listTenServer;
        }

        // Kiểm tra kết nối
        public static bool KetNoiDenServer(string connectionString)
        {

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Kết nối đến cơ sở dữ liệu
        public static bool KetNoiDenCSDL(string connectionString)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Xây dựng cuỗi kết nối
        public static string ChuoiKetNoiDenServer(string server, string db, string UserName, string Password, bool IntegratedSecurity)
        {
            return "Data Source=" + server.Trim() + ";Initial Catalog=" + db.Trim() + ";Integrated Security=" + IntegratedSecurity + ";User ID=" + UserName.Trim() + ";Password=" + Password + ";";
        }

        public static string ChuoiKetNoiDenServer(string server, string db, bool IntegratedSecurity)
        {
            return "Data Source=" + server.Trim() + ";Initial Catalog=" + db.Trim() + ";Integrated Security=" + IntegratedSecurity + ";";
        }

        // Hàm kiểm tra ký tự hợp lệ
        private bool KiemTraKyTuHopLe(char c)
        {
            if ((c >= 65 && c <= 90) || (c >= 48 && c <= 57) || (c >= 97 && c <= 122) || c == '\b')
                return true;
            else
                return false;
        }

        // Lấy danh sách cơ sở dữ liệu có trong máy
        private void DanhSachCSDL()
        {
            cbServerName.Items.Clear();

            foreach (Database db in LayTenCSDLCuaServer.Databases)
            {
                //Check if database is not a system database
                if (!db.IsSystemObject)
                {
                       cbServerName.Items.Add(db.Name);
                }
            }
              cbServerName.SelectedIndex = -1;
        }

        // Kiểm tra cơ sở dữ liệu có hợp lệ hay không
        private bool KiemTraCSDL(string tenCSDL)
        {
            string data = File.ReadAllText(@"ScriptFile\\ee.sql");
            var dsTables = LayTenCSDLCuaServer.Databases[tenCSDL].ExecuteWithResults(data);
            return dsTables.Tables[0].Rows.Count > 0;
        }

        // Xóa cơ sở dữ liệu
        public static bool XoaCSDL(string ChuoiKetNoi, string db)
        {
            SqlConnection connection = new SqlConnection(ChuoiKetNoi);
            try
            {
                SqlCommand cmd = new SqlCommand("ALTER DATABASE " + db + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE", connection);
                cmd.CommandType = CommandType.Text;

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "Drop Database " + db.Trim();

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;

            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return false;
            }
        }

        // Tạo mới cơ sở dữ liệu
        public static bool TaoMoiCSDL(string connectionString, string databaseName, string path)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string strscript = File.ReadAllText(path);
                string[] allCmd = strscript.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = connection;
                connection.Open();

                sqlCmd.CommandText = " USE [master]";
                sqlCmd.ExecuteNonQuery();
                sqlCmd.CommandText = "CREATE DATABASE [" + databaseName + "]";
                sqlCmd.ExecuteNonQuery();
                sqlCmd.CommandText = "USE [" + databaseName + "]";
                sqlCmd.ExecuteNonQuery();

                string ChuoiTruyVan = File.ReadAllText(@"ScriptFile\\ee");
                sqlCmd.CommandText = ChuoiTruyVan;
                sqlCmd.ExecuteNonQuery();
                for (int i = 0; i < allCmd.Length; i++)
                {
                    sqlCmd.CommandText = allCmd[i];
                    sqlCmd.ExecuteNonQuery();
                }
                connection.Close();
                return true;

            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return false;
            }
        }
        #endregion

        private void txtDatabaseName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TenCSDL = txtDatabaseName.Text;
            btCheckDb.Enabled = true;
            btDeleteDb.Enabled = true;
            btCreateDb.Enabled = false;
            btnTaoDuLieuMau.Enabled = false;
        }






    }
}