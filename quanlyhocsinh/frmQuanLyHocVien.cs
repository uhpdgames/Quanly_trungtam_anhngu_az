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
    public partial class frmQuanLyHocVien : Form
    {
        public frmQuanLyHocVien()
        {
            InitializeComponent();
        }
        int iMaHV;
        DataSet ds;
        DataView dv;
        SqlDataAdapter daHocVien;
        SqlDataAdapter daLopHoc;
        SqlDataAdapter daHocVien_LopHoc;
        private void frmQuanLyHocSinh_Load(object sender, EventArgs e)
        {

            //Chuỗi kết nối 
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();

            //Chuỗi truy vấn
            string sSelectHocVien = @"Select * From dbo.Hoc_Vien";

            //Khởi tạo đối tượng SQLDataAdapter thực hiện truy vấn lấy dữ liệu từ database về
            daHocVien = new SqlDataAdapter(sSelectHocVien, sChuoiKetNoi);
            //Khởi tạo Dataset
            ds = new DataSet("DsQuanLyHocVien");
            //Đổ dữ liệu vào 1 bảng trong dataset
            daHocVien.Fill(ds, "tblHocVien");
            dv = new DataView(ds.Tables["tblHocVien"]);
            //dgvDanhSachHocVien.DataSource = ds.Tables["tblHocVien"];
            dgvDanhSachHocVien.DataSource = dv;
            //Đặt tên cột cho datagridview
            dgvDanhSachHocVien.Columns["MaHV"].HeaderText = "Mã học viên";
            dgvDanhSachHocVien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvDanhSachHocVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDanhSachHocVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvDanhSachHocVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
           // dgvDanhSachHocVien.Columns["MaLop"].HeaderText = "Tên lớp";
            dgvDanhSachHocVien.Columns["SDT"].HeaderText = "Số điện thoại";

            //Đặt lại độ rộng cho các cột trên datagridview học sinh

            dgvDanhSachHocVien.Columns["MaHV"].Width = 100;
            dgvDanhSachHocVien.Columns["GioiTinh"].Width = 100;
            dgvDanhSachHocVien.Columns["NgaySinh"].Width = 100;
            dgvDanhSachHocVien.Columns["MaLop"].Width = 80;
      

            //Đổ dữ liệu lên control combobox
            string sSelectLopHoc = @"Select * From dbo.Lop_Hoc";
            daLopHoc = new SqlDataAdapter(sSelectLopHoc, sChuoiKetNoi);
            daLopHoc.Fill(ds, "tblLopHoc");
            cmbLop.DataSource = ds.Tables["tblLopHoc"];
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
            //tạo chuỗi truy vấn lấy thông tin cả 2 bảng 
            //string sSelectHS_LopHoc = @"select Hoc_Vien.*,Lop_Hoc.TenLop from dbo.Hoc_Vien,dbo.Lop_Hoc where Hoc_Vien.MaLop=Lop_Hoc.MaLop";
            //daHocVien_LopHoc = new SqlDataAdapter(sSelectHS_LopHoc, sChuoiKetNoi);
            //daHocVien_LopHoc.Fill(ds, "tblHocVien_LopHoc");
            //dgvDanhSachHocVien.DataSource = ds.Tables["tblHocVien_LopHoc"];
            ////Ẩn cột lớp học 
            //dgvDanhSachHocVien.Columns["MaLop"].Visible = false;
            //dgvDanhSachHocVien.Columns["TenLop"].HeaderText = "Tên lớp";
            //dgvDanhSachHocVien.Columns["TenLop"].Width = 150;

            //C2 : 
            //tạo chuỗi truy vấn lấy thông tin cả 2 bảng 
            DataGridViewColumn clTenLop = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            clTenLop.CellTemplate = cell;
            clTenLop.Name = "TenLop";
            clTenLop.HeaderText = "Tên lớp";
            dgvDanhSachHocVien.Columns.Add(clTenLop);

            for (int i = 0; i < dgvDanhSachHocVien.RowCount; i++)
            {
                dgvDanhSachHocVien.Rows[i].Cells["TenLop"].Value = LayTenLopHoc(dgvDanhSachHocVien.Rows[i].Cells["MaLop"].Value.ToString());

            }

            //Ẩn cột lớp học 
            dgvDanhSachHocVien.Columns["MaLop"].Visible = false;
          //  dgvDanhSachHocVien.Columns["TenLop"].HeaderText = "Tên lớp";
            dgvDanhSachHocVien.Columns["TenLop"].Width = 150;

            //KhoaHoc
            string sSelectKhoaHoc = @"Select * From dbo.Khoa_Hoc";
            daLopHoc = new SqlDataAdapter(sSelectKhoaHoc, sChuoiKetNoi);
            daLopHoc.Fill(ds, "tblKhoaHoc");
            cmbKhoaHoc.DataSource = ds.Tables["tblKhoaHoc"];
            cmbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cmbKhoaHoc.ValueMember = "MaKhoaHoc";
            DataGridViewColumn clKhoaHoc = new DataGridViewColumn();
            DataGridViewCell cell_kh = new DataGridViewTextBoxCell();
            clKhoaHoc.CellTemplate = cell_kh;
            clKhoaHoc.Name = "TenKhoaHoc";
            clKhoaHoc.HeaderText = "Khóa học";
            dgvDanhSachHocVien.Columns.Add(clKhoaHoc);

            for (int i = 0; i < dgvDanhSachHocVien.RowCount; i++)
            {
                dgvDanhSachHocVien.Rows[i].Cells["TenKhoaHoc"].Value = LayTenKhoaHoc(dgvDanhSachHocVien.Rows[i].Cells["MaKhoaHoc"].Value.ToString());

            }

            //Ẩn cột lớp học 
            dgvDanhSachHocVien.Columns["MaKhoaHoc"].Visible = false;
            //  dgvDanhSachHocVien.Columns["TenLop"].HeaderText = "Tên lớp";
            dgvDanhSachHocVien.Columns["TenKhoaHoc"].Width = 150;
            //Tạo đối tượng kết nối đến Database
            //SqlConnection con = new SqlConnection(sChuoiKetNoi);
            //Tạo đối tượng command thực thi câu lệnh truy vấn insert

            //end khoahoc
            //Thêm HV
            string sThemHV = @"Insert into Hoc_Vien(HoTen,GioiTinh,NgaySinh,DiaChi,SDT,MaLop,MaKhoaHoc) values(@HoTen,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@MaLop,@MaKhoaHoc)";
            SqlCommand cmThemHV = new SqlCommand(sThemHV, con);
            cmThemHV.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "HoTen");
            cmThemHV.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3, "GioiTinh");
            cmThemHV.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "NgaySinh");
            cmThemHV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100, "DiaChi");
            cmThemHV.Parameters.Add("@SDT", SqlDbType.Char, 11, "SDT");
            cmThemHV.Parameters.Add("@MaLop", SqlDbType.Int, 5, "MaLop");
            cmThemHV.Parameters.Add("@MaKhoaHoc", SqlDbType.Int, 5, "MaKhoaHoc");

            daHocVien.InsertCommand = cmThemHV;

            //Tạo đối tượng command thực thi câu lệnh truy vấn update
            string sSuaHV = @"Update Hoc_Vien set HoTen=@HoTen,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,SDT=@SDT,MaLop=@MaLop,MaKhoaHoc=@MaKhoaHoc where MaHV=@MaHV";
            SqlCommand cmSuaHV = new SqlCommand(sSuaHV, con);
            cmSuaHV.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50, "HoTen");
            cmSuaHV.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3, "GioiTinh");
            cmSuaHV.Parameters.Add("@NgaySinh", SqlDbType.DateTime, 10, "NgaySinh");
            cmSuaHV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100, "DiaChi");
            cmSuaHV.Parameters.Add("@SDT", SqlDbType.Char, 11, "SDT");
            cmSuaHV.Parameters.Add("@MaLop", SqlDbType.Int, 5, "MaLop");
            cmSuaHV.Parameters.Add("@MaKhoaHoc", SqlDbType.Int, 5, "MaKhoaHoc");

            cmSuaHV.Parameters.Add("@MaHV", SqlDbType.Int, 5, "MaHV");

            daHocVien.UpdateCommand = cmSuaHV;
            //Tạo đối tượng command xóa dữ liệu 
            string sXoaHS = @"Delete From Hoc_Vien where MaHV=@MaHV";
            SqlCommand cmXoaHV = new SqlCommand(sXoaHS, con);
            cmXoaHV.Parameters.Add("@MaHV", SqlDbType.Int, 5, "MaHV");
            daHocVien.DeleteCommand = cmXoaHV;


        }
        //duyệt Tên lớp
        public string LayTenLopHoc(string sMaLop)
        { 
            //Chuỗi kết nối  
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //Chuỗi truy vấn
            string sTenLop = @"Select TenLop From Lop_Hoc Where MaLop=" + sMaLop;
            SqlDataAdapter daTenLop = new SqlDataAdapter(sTenLop, sChuoiKetNoi);
            DataTable dt = new DataTable();
            daTenLop.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return "";
        }

        //duyệt khóa học
        public string LayTenKhoaHoc(string sMaKhoaHoc)
        {
            //Chuỗi kết nối  
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //Chuỗi truy vấn
            string sTenKhoaHoc = @"Select TenKhoaHoc From Khoa_Hoc Where MaKhoaHoc=" + sMaKhoaHoc;
            SqlDataAdapter daTenKhoaHoc = new SqlDataAdapter(sTenKhoaHoc, sChuoiKetNoi);
            DataTable dt2 = new DataTable();
            daTenKhoaHoc.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                return dt2.Rows[0][0].ToString();
            }
            return "";
        }
        //Add nút THÊM 
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ đầu vào dữ liệu
            if (txtHoTen.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            //Thêm 1 dòng vào tblHocVien
            DataRow r = ds.Tables["tblHocVien"].NewRow();
            //Nhập giá trị vào các trường tương ứng trên Datarow
            r["HoTen"] = txtHoTen.Text;
            if (rdbGioiTinhNam.Checked == true)
            {
                r["GioiTinh"] = "Nam";
            }
            else
            {
                r["GioiTinh"] = "Nữ";
            }
            r["NgaySinh"] = dtpNgaySinh.Text;
            r["DiaChi"] = txtDiaChi.Text;
            r["SDT"] = txtsdt.Text;
            r["MaLop"] = cmbLop.SelectedValue;
            r["MaKhoaHoc"] = cmbKhoaHoc.SelectedValue;
            if (iMaHV == 0)
            {
                MaHVCuoiCungTruocKhiThem();
            }
            iMaHV++;
            r["MaHV"] = iMaHV;
            //Add vào tblHocVien 
            ds.Tables["tblHocVien"].Rows.Add(r);
           // ds.Tables["tblLopHoc"].Rows.Add(r);

            //Thêm tên lớp vào datagridview
            dgvDanhSachHocVien.Rows[dgvDanhSachHocVien.RowCount - 1].Cells["TenLop"].Value = LayTenLopHoc(cmbLop.SelectedValue.ToString());
            dgvDanhSachHocVien.Rows[dgvDanhSachHocVien.RowCount - 1].Cells["TenKhoaHoc"].Value = LayTenKhoaHoc(cmbKhoaHoc.SelectedValue.ToString());

            //fix add
            // MessageBox.Show("Thêm thành công, ấn Lưu và thoát chương trình để cập nhật!", "Thông báo");

        }
        public void MaHVCuoiCungTruocKhiThem()
        {

            //Chuỗi kết nối 
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //Chuỗi truy vấn
            string sMaHVCuoiCung = @"Select MaHV From Hoc_Vien";
            SqlDataAdapter daTenLop = new SqlDataAdapter(sMaHVCuoiCung, sChuoiKetNoi);
          //  SqlDataAdapter daTenKhoaHoc = new SqlDataAdapter(sMaHVCuoiCung, sChuoiKetNoi);
            DataTable dt = new DataTable();
            daTenLop.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                // Lấy chỉ số phần tử dòng cuối cùng 
                int iDongCuoi = dt.Rows.Count - 1;
                iMaHV = int.Parse(dt.Rows[iDongCuoi][0].ToString());
            }
            //daTenKhoaHoc.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    // Lấy chỉ số phần tử dòng cuối cùng 
            //    int iDongCuoi = dt.Rows.Count - 1;
            //    iMaHV = int.Parse(dt.Rows[iDongCuoi][0].ToString());
            //}

        }
        //Add lưu dữ liệu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daHocVien.Update(ds, "tblHocVien");
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                return;
            }
        }
        //sự kiện sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachHocVien.SelectedRows[0];
            dgvDanhSachHocVien.BeginEdit(true);
            dr.Cells["MaHV"].Value = txtMaHV.Text;
            dr.Cells["HoTen"].Value = txtHoTen.Text;
            if (rdbGioiTinhNam.Checked == true)
            {
                dr.Cells["GioiTinh"].Value = "Nam";
            }
            else
            {
                dr.Cells["GioiTinh"].Value = "Nữ";
            }
            dr.Cells["NgaySinh"].Value = dtpNgaySinh.Text;
            dr.Cells["DiaChi"].Value = txtDiaChi.Text;
            dr.Cells["SDT"].Value = txtsdt.Text;
            dr.Cells["MaLop"].Value = cmbLop.SelectedValue;
            dr.Cells["MaKhoaHoc"].Value = cmbKhoaHoc.SelectedValue;
            dgvDanhSachHocVien.EndEdit();
            MessageBox.Show("Cập nhật dữ liệu thành công !", "Thông báo");
        }
        //edit click
        private void dgvDanhSachHocVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachHocVien.SelectedRows[0];
            txtMaHV.Text = dr.Cells["MaHV"].Value.ToString();
            txtHoTen.Text = dr.Cells["HoTen"].Value.ToString();
            if (dr.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                rdbGioiTinhNam.Checked = true;
            }
            else
            {
                rdbGioiTinhNu.Checked = false;
            }
            dtpNgaySinh.Text = dr.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            cmbLop.SelectedValue = dr.Cells["MaLop"].Value.ToString();
            cmbKhoaHoc.SelectedValue = dr.Cells["MaKhoaHoc"].Value.ToString();
            txtsdt.Text = dr.Cells["SDT"].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDanhSachHocVien.SelectedRows[0];
                dgvDanhSachHocVien.Rows.Remove(dr);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblHocVien"].RejectChanges();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
       
              dv.RowFilter = string.Format("HoTen like '%{0}%'", txtTimKiem.Text);
            //dv.RowFilter = "HoTen like '%" + txtTimKiem.Text + "%'";
            
        }

        private void gbThongTinHocSinh_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void picturebox_Click(object sender, EventArgs e)
        {

        }

        private void cmbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
