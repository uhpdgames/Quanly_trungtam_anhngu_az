using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHocSinh
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }
        int iMaGV;
        DataSet ds;
        DataView dv;
        SqlDataAdapter daGiangVien;
        SqlDataAdapter daTenTrinhDo;
        //SqlDataAdapter daGiangVien_LopHoc;

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            //Chuỗi kết nối 
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();

            //Chuỗi truy vấn
            string sSelectGiangVien = @"Select * From dbo.Giang_Vien";

            //Khởi tạo đối tượng SQLDataAdapter thực hiện truy vấn lấy dữ liệu từ database về
            daGiangVien = new SqlDataAdapter(sSelectGiangVien, sChuoiKetNoi);
            //Khởi tạo Dataset
            ds = new DataSet("DsQuanLyGiangVien");
            //Đổ dữ liệu vào 1 bảng trong dataset
            daGiangVien.Fill(ds, "tblGiangVien");
            dv = new DataView(ds.Tables["tblGiangVien"]);
            dgvDanhSachGiangVien.DataSource = ds.Tables["tblGiangVien"];
            dgvDanhSachGiangVien.DataSource = dv;
            //Đặt tên cột cho datagridview
            dgvDanhSachGiangVien.Columns["MaGV"].HeaderText = "Mã giảng viên";
            dgvDanhSachGiangVien.Columns["TenGV"].HeaderText = "Họ tên";
            dgvDanhSachGiangVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDanhSachGiangVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvDanhSachGiangVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
           // dgvDanhSachGiangVien.Columns["BangCap"].HeaderText = "Bằng Cấp";
            dgvDanhSachGiangVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDanhSachGiangVien.Columns["Email"].HeaderText = "Email";
            //Đặt lại độ rộng cho các cột trên datagridview học sinh

            dgvDanhSachGiangVien.Columns["MaGV"].Width = 100;
            dgvDanhSachGiangVien.Columns["Email"].Width = 150;
            dgvDanhSachGiangVien.Columns["GioiTinh"].Width = 100;
            dgvDanhSachGiangVien.Columns["NgaySinh"].Width = 100;
          //  dgvDanhSachGiangVien.Columns["BangCap"].Width = 80;

            //Lấp thông tin 2 bảng
            //string sSelectHS_LopHoc = @"select Giang_Vien.*,TrinhDo.TrinhDo from dbo.Giang_Vien,dbo.TrinhDo where Giang_Vien.MaGV=TrinhDo.MaTD";
            //daGiangVien_LopHoc = new SqlDataAdapter(sSelectHS_LopHoc, sChuoiKetNoi);
            //daGiangVien_LopHoc.Fill(ds, "tblGiangVien_LopHoc");
            //dgvDanhSachGiangVien.DataSource = ds.Tables["tblGiangVien_LopHoc"];
            ////Ẩn cột lớp học 
            //dgvDanhSachGiangVien.Columns["MaTD"].Visible = false;
            //dgvDanhSachGiangVien.Columns["TrinhDo"].HeaderText = "Trình Độ";
            //dgvDanhSachGiangVien.Columns["TrinhDo"].Width = 150;



            //Đổ dữ liệu lên control combobox
            string sSelectTrinhDo = @"Select * From dbo.TrinhDo";
            daTenTrinhDo = new SqlDataAdapter(sSelectTrinhDo, sChuoiKetNoi);
            daTenTrinhDo.Fill(ds, "tblTrinhDo");
            cmbTrinhDo.DataSource = ds.Tables["tblTrinhDo"];
            cmbTrinhDo.DisplayMember = "TrinhDo";
            cmbTrinhDo.ValueMember = "MaTD";

            DataGridViewColumn clTrinhDo = new DataGridViewColumn();
            DataGridViewCell cell_trinhdo = new DataGridViewTextBoxCell();
            clTrinhDo.CellTemplate = cell_trinhdo;
            clTrinhDo.Name = "TrinhDo";
            clTrinhDo.HeaderText = "Trình Độ";
            dgvDanhSachGiangVien.Columns.Add(clTrinhDo);

            for (int i = 0; i < dgvDanhSachGiangVien.RowCount; i++)
            {
                dgvDanhSachGiangVien.Rows[i].Cells["TrinhDo"].Value = LayTrinhDo(dgvDanhSachGiangVien.Rows[i].Cells["MaTD"].Value.ToString());

            }

            //Ẩn cột lớp học 
            dgvDanhSachGiangVien.Columns["MaTD"].Visible = false;
           // dgvDanhSachGiangVien.Columns["TrinhDo"].HeaderText = "Trình Độ";
            dgvDanhSachGiangVien.Columns["TrinhDo"].Width = 100;


            //Thêm GV
            string sThemGV = @"Insert into Giang_Vien(TenGV,GioiTinh,NgaySinh,DiaChi,SDT,MaTD,Email) values(@TenGV,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@MaTD,@Email)";
            SqlCommand cmThemGV = new SqlCommand(sThemGV, con);
            cmThemGV.Parameters.Add("@TenGV", SqlDbType.NVarChar, 50, "TenGV");
            cmThemGV.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3, "GioiTinh");
            cmThemGV.Parameters.Add("@NgaySinh", SqlDbType.Date, 10, "NgaySinh");
            cmThemGV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "DiaChi");
            cmThemGV.Parameters.Add("@MaTD", SqlDbType.Int, 5, "MaTD");
            cmThemGV.Parameters.Add("@SDT", SqlDbType.NChar, 11, "SDT");
            cmThemGV.Parameters.Add("@Email", SqlDbType.VarChar, 50, "Email");

            daGiangVien.InsertCommand = cmThemGV;

            //sửa
            //Tạo đối tượng command thực thi câu lệnh truy vấn update
            string sSuaGV = @"Update Giang_Vien set TenGV=@HoTen,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,SDT=@SDT,MaTD=@MaTD,Email=@Email where MaGV=@MaGV";
            SqlCommand cmSuaGV = new SqlCommand(sSuaGV, con);
            cmSuaGV.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "TenGV");
            cmSuaGV.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3, "GioiTinh");
            cmSuaGV.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "NgaySinh");
            cmSuaGV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100, "DiaChi");
            cmSuaGV.Parameters.Add("@SDT", SqlDbType.NChar, 11, "SDT");
            cmSuaGV.Parameters.Add("@Email", SqlDbType.VarChar, 50, "Email");
            cmSuaGV.Parameters.Add("@MaTD", SqlDbType.Int, 5, "MaTD");

            cmSuaGV.Parameters.Add("@MaGV", SqlDbType.Int, 5, "MaGV");

            daGiangVien.UpdateCommand = cmSuaGV;

            //xóa / bug
            //Tạo đối tượng command xóa dữ liệu 
            string sXoaGV = @"Delete From Giang_Vien where MaGV=@MaGV";
            SqlCommand cmXoaGV = new SqlCommand(sXoaGV, con);
            cmXoaGV.Parameters.Add("@MaGV", SqlDbType.Int, 5, "MaGV");
            daGiangVien.DeleteCommand = cmXoaGV;
        }

        //duyệt Trình độ GV
        public string LayTrinhDo(string sMaTD)
        {
            //Chuỗi kết nối  
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //Chuỗi truy vấn
            string sTenTD = @"Select TrinhDo From TrinhDo Where MaTD=" + sMaTD;
            SqlDataAdapter daTenTrinhDo = new SqlDataAdapter(sTenTD, sChuoiKetNoi);
            DataTable dt = new DataTable();
            daTenTrinhDo.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return "";
        }

        public void MaGVCuoiCungTruocKhiThem()
        {

            //Chuỗi kết nối 
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //Chuỗi truy vấn
            string sMaHVCuoiCung = @"Select MaGV From Giang_Vien";
            SqlDataAdapter daTenTrinhDo = new SqlDataAdapter(sMaHVCuoiCung, sChuoiKetNoi);
            DataTable dt = new DataTable();
            daTenTrinhDo.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                // Lấy chỉ số phần tử dòng cuối cùng 
                int iDongCuoi = dt.Rows.Count - 1;
                iMaGV = int.Parse(dt.Rows[iDongCuoi][0].ToString());
            }

        }
        private void gbThongTinHocSinh_2_Enter(object sender, EventArgs e)
        {

        }
        private void dgvDanhSachGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_2_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ đầu vào dữ liệu
            if (txtHoTen_2.Text == "" || txtDiaChi_2.Text == "")
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            //Thêm 1 dòng vào tblGiangVien
            DataRow r = ds.Tables["tblGiangVien"].NewRow();
            //Nhập giá trị vào các trường tương ứng trên Datarow
            r["TenGV"] = txtHoTen_2.Text;
            if (rdbGioiTinhNam_2.Checked == true)
            {
                r["GioiTinh"] = "Nam";
            }
            else
            {
                r["GioiTinh"] = "Nữ";
            }
            r["NgaySinh"] = dtpNgaySinh_2.Text;
            r["DiaChi"] = txtDiaChi_2.Text;
            r["SDT"] = txtsdt_2.Text;
            r["Email"] = txtEmail.Text;
           // r["MaLop"] = cmbTrinhDo.SelectedValue;
            r["MaTD"] = cmbTrinhDo.SelectedValue;
            if (iMaGV == 0)
            {
                MaGVCuoiCungTruocKhiThem();
            }
            iMaGV++;
            r["MaGV"] = iMaGV;
            //Add vào tblGiangVien 
            ds.Tables["tblGiangVien"].Rows.Add(r);
            //Thêm tên lớp vào datagridview
            dgvDanhSachGiangVien.Rows[dgvDanhSachGiangVien.RowCount - 1].Cells["TrinhDo"].Value = LayTrinhDo(cmbTrinhDo.SelectedValue.ToString());
        }

        private void btnLuu_2_Click(object sender, EventArgs e)
        {
            try
            {
                daGiangVien.Update(ds, "tblGiangVien");
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnSua_2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng này bị lỗi!", "Thông báo");
            DataGridViewRow dr = dgvDanhSachGiangVien.SelectedRows[0];
            dgvDanhSachGiangVien.BeginEdit(true);
            dr.Cells["MaGV"].Value = txtMaGV.Text;
            dr.Cells["TenGV"].Value = txtHoTen_2.Text;
            if (rdbGioiTinhNam_2.Checked == true)
            {
                dr.Cells["GioiTinh"].Value = "Nam";
            }
            else
            {
                dr.Cells["GioiTinh"].Value = "Nữ";
            }
            dr.Cells["NgaySinh"].Value = dtpNgaySinh_2.Text;
            dr.Cells["DiaChi"].Value = txtDiaChi_2.Text;
            dr.Cells["SDT"].Value = txtsdt_2.Text;
            dr.Cells["MaTD"].Value = cmbTrinhDo.SelectedValue;
            dr.Cells["Email"].Value = txtEmail.Text;
            dgvDanhSachGiangVien.EndEdit();
            MessageBox.Show("Cập nhật dữ liệu thành công !", "Thông báo");
        }
        //edit click
        private void dgvDanhSachGiangVien_Click(object sender, EventArgs e)
        {
            

        }

        private void btnXoa_2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr2 = dgvDanhSachGiangVien.SelectedRows[0];
                dgvDanhSachGiangVien.Rows.Remove(dr2);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }

        private void btnHuy_2_Click(object sender, EventArgs e)
        {
            ds.Tables["tblGiangVien"].RejectChanges();

        }

        private void btnThoat_2_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnTimKiem_2_Click(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("TenGV like '%{0}%'", txtTimKiem_2.Text);
        }

        private void txtTimKiem_2_TextChanged(object sender, EventArgs e)
        {
            txtTimKiem_2.Text = "";
        }

        private void lblTieuDe_2_Click(object sender, EventArgs e)
        {

        }

        private void gbTimKiem_2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachGiangVien_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachGiangVien.SelectedRows[0];
            txtMaGV.Text = dr.Cells["MaGV"].Value.ToString();
            txtHoTen_2.Text = dr.Cells["TenGV"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                rdbGioiTinhNam_2.Checked = true;
            }
            else
            {
                rdbGioiTinhNu_2.Checked = false;
            }
            dtpNgaySinh_2.Text = dr.Cells["NgaySinh"].Value.ToString();
            txtDiaChi_2.Text = dr.Cells["DiaChi"].Value.ToString();
            cmbTrinhDo.SelectedValue = dr.Cells["MaTD"].Value.ToString();
            txtEmail.Text = dr.Cells["Email"].Value.ToString();
            txtsdt_2.Text = dr.Cells["SDT"].Value.ToString();
        }
    }
}
