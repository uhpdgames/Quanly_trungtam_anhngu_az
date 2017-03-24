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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }
       // int iMaLop;
        DataSet ds;
        DataView dv;
        SqlDataAdapter daDSLop;
       // SqlDataAdapter daK;
        SqlDataAdapter daGiangVien;
       // SqlDataAdapter daTenKhoaHoc;

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            //Chuỗi kết nối 
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();

            //Chuỗi truy vấn
            string sSelectDSLop = @"Select * From dbo.ThongTinLop";

            //Khởi tạo đối tượng SQLDataAdapter thực hiện truy vấn lấy dữ liệu từ database về
            daDSLop = new SqlDataAdapter(sSelectDSLop, sChuoiKetNoi);
            //Khởi tạo Dataset
            ds = new DataSet("DsQuanLyLop");
            //Đổ dữ liệu vào 1 bảng trong dataset
            daDSLop.Fill(ds, "tblLop");
            dv = new DataView(ds.Tables["tblLop"]);
            //dgvDanhSachLop.DataSource = ds.Tables["tblLop"];
            dgvDanhSachLop.DataSource = dv;
            //Đặt tên cột cho datagridview
            dgvDanhSachLop.Columns["MaLop"].HeaderText = "Mã Lớp ";
            //dgvDanhSachLop.Columns["TenLop"].HeaderText = "Tên Lớp";
            dgvDanhSachLop.Columns["NBT"].HeaderText = "Ngày bắt đầu";
            dgvDanhSachLop.Columns["NKT"].HeaderText = "Ngày kết thúc";
            dgvDanhSachLop.Columns["SS"].HeaderText = "Sỉ số";
            // dgvDanhSachLop.Columns["MaLop"].HeaderText = "Tên lớp";
            dgvDanhSachLop.Columns["SBD"].HeaderText = "Số buổi dạy";

            //Đặt lại độ rộng cho các cột trên datagridview học sinh

            dgvDanhSachLop.Columns["MaLop"].Width = 100;
           // dgvDanhSachLop.Columns["TenLop"].Width = 100;
            dgvDanhSachLop.Columns["NBT"].Width = 100;
            dgvDanhSachLop.Columns["NKT"].Width = 100;

            //Lấp danh sách giảng viên dạy
            string sSelectGiangVien = @"Select * From dbo.Giang_Vien";
            daGiangVien = new SqlDataAdapter(sSelectGiangVien, sChuoiKetNoi);
            daGiangVien.Fill(ds, "tblGiangVien");
            cmbGiangVien.DataSource = ds.Tables["tblGiangVien"];
            cmbGiangVien.DisplayMember = "TenGV";
            cmbGiangVien.ValueMember = "MaGV";

            DataGridViewColumn clTenGiangVien = new DataGridViewColumn();
            DataGridViewCell cell_1 = new DataGridViewTextBoxCell();
            clTenGiangVien.CellTemplate = cell_1;
            clTenGiangVien.Name = "TenGV";
            clTenGiangVien.HeaderText = "Giảng viên dạy";
            dgvDanhSachLop.Columns.Add(clTenGiangVien);

            for (int i = 0; i < dgvDanhSachLop.RowCount; i++)
            {
                dgvDanhSachLop.Rows[i].Cells["TenGV"].Value = LayTenGiangVien(dgvDanhSachLop.Rows[i].Cells["MaGV"].Value.ToString());

            }
            //Ẩn cột
            dgvDanhSachLop.Columns["MaGV"].Visible = false;

            dgvDanhSachLop.Columns["TenGV"].Width = 150;

            //KhoaHoc
            string sSelectKhoaHoc = @"Select * From dbo.Khoa_Hoc";
            daGiangVien = new SqlDataAdapter(sSelectKhoaHoc, sChuoiKetNoi);
            daGiangVien.Fill(ds, "tblKhoaHoc");
            combo_KhoaHoc.DataSource = ds.Tables["tblKhoaHoc"];
            combo_KhoaHoc.DisplayMember = "TenKhoaHoc";
            combo_KhoaHoc.ValueMember = "MaKhoaHoc";
            DataGridViewColumn clKhoaHoc = new DataGridViewColumn();
            DataGridViewCell cell_kh = new DataGridViewTextBoxCell();
            clKhoaHoc.CellTemplate = cell_kh;
            clKhoaHoc.Name = "TenKhoaHoc";
            clKhoaHoc.HeaderText = "Khóa học";
            dgvDanhSachLop.Columns.Add(clKhoaHoc);

            for (int i = 0; i < dgvDanhSachLop.RowCount; i++)
            {
                dgvDanhSachLop.Rows[i].Cells["TenKhoaHoc"].Value = LayTenKhoaHoc(dgvDanhSachLop.Rows[i].Cells["MaKhoaHoc"].Value.ToString());

            }

            //Ẩn cột khóa học 
            dgvDanhSachLop.Columns["MaKhoaHoc"].Visible = false;
            //  dgvDanhSachHocVien.Columns["TenLop"].HeaderText = "Tên lớp";
            dgvDanhSachLop.Columns["TenKhoaHoc"].Width = 150;
            //Đổ lớp vào
            string sSelectLopHoc = @"Select * From dbo.Lop_Hoc";
            daGiangVien = new SqlDataAdapter(sSelectLopHoc, sChuoiKetNoi);
            daGiangVien.Fill(ds, "tblLopHoc");
            combo_Lophoc.DataSource = ds.Tables["tblLopHoc"];
            combo_Lophoc.DisplayMember = "TenLop";
            combo_Lophoc.ValueMember = "MaLop";
            DataGridViewColumn clTenLop = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            clTenLop.CellTemplate = cell;
            clTenLop.Name = "TenLop";
            clTenLop.HeaderText = "Tên lớp";
            dgvDanhSachLop.Columns.Add(clTenLop);

            for (int i = 0; i < dgvDanhSachLop.RowCount; i++)
            {
                dgvDanhSachLop.Rows[i].Cells["TenLop"].Value = LayTenLopHoc(dgvDanhSachLop.Rows[i].Cells["MaLop"].Value.ToString());

            }

            //Ẩn cột lớp học 
           // dgvDanhSachLop.Columns["MaLop"].Visible = false;
            //  dgvDanhSachHocVien.Columns["TenLop"].HeaderText = "Tên lớp";
            dgvDanhSachLop.Columns["TenLop"].Width = 150;

             //Add thêm lớp
            string sThemLop = @"Insert into ThongTinLop(NBT,NKT,SS,SBD,MaGV,MaKhoaHoc,MaLop) values(@NBT,@NKT,@SS,@SBD,@MaGV,@MaKhoaHoc,@MaLop)";
            SqlCommand cmThemLop = new SqlCommand(sThemLop, con);
           // cmThemLop.Parameters.Add("@TenLop", SqlDbType.NVarChar, 50, "TenLop");
            cmThemLop.Parameters.Add("@NBT", SqlDbType.DateTime, 10, "NBT");
            cmThemLop.Parameters.Add("@NKT", SqlDbType.DateTime, 10, "NKT");
            cmThemLop.Parameters.Add("@SS", SqlDbType.Int, 99, "SS");
            cmThemLop.Parameters.Add("@SBD", SqlDbType.Int, 99, "SBD");
            cmThemLop.Parameters.Add("@MaGV", SqlDbType.Int, 99, "MaGV");
            cmThemLop.Parameters.Add("@MaKhoaHoc", SqlDbType.Int, 99, "MaKhoaHoc");
            cmThemLop.Parameters.Add("@MaLop", SqlDbType.Int, 99, "MaLop");

            daDSLop.InsertCommand = cmThemLop;

        }
        //duyệt Tên giảng viên
        public string LayTenGiangVien(string sMaGV)
        {
            //Chuỗi kết nối  
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //Chuỗi truy vấn
            string sTenGiangVien = @"Select TenGV From Giang_Vien Where MaGV=" + sMaGV;
            SqlDataAdapter daDSGiangVien = new SqlDataAdapter(sTenGiangVien, sChuoiKetNoi);
            DataTable dt_1 = new DataTable();
            daDSGiangVien.Fill(dt_1);
            if (dt_1.Rows.Count > 0)
            {
                return dt_1.Rows[0][0].ToString();
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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void grbNhapDiem_Enter(object sender, EventArgs e)
        {

        }

        private void picturebox_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            frmDanhSachLopHoc frm = new frmDanhSachLopHoc();
            frm.ShowDialog();
        }

        private void btnNhapLop_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ đầu vào dữ liệu
            if (txtSoBuoiDay.Text == "" || txtSiSo.Text == "")
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            //Thêm 1 dòng vào tblHocVien
            DataRow r = ds.Tables["tblLop"].NewRow();
            //Nhập giá trị vào các trường tương ứng trên Datarow
           // r["TenLop"] = txtHoTen.Text;

            r["SBD"] = txtSoBuoiDay.Text;
            r["SS"] = txtSiSo.Text;
            r["NBT"] = dtpNgaybt.Text;
            r["NKT"] = dtpNgaykt.Text;
            r["MaKhoaHoc"] = combo_KhoaHoc.SelectedValue;
            r["MaGV"] = cmbGiangVien.SelectedValue;
            r["MaLop"] = combo_Lophoc.SelectedValue;
          //  if (iMaLop == 0)
           // {
            //    MaLopCuoi();
          //  }
           // iMaLop++;
           // r["MaLop"] = iMaLop;
            //Add vào tbl
            ds.Tables["tblLop"].Rows.Add(r);
            //ds.Tables["tblKhoaHoc"].Rows.Add(r);
           // ds.Tables["tblGiangVien"].Rows.Add(r);
            //ds.Tables["tblLopHoc"].Rows.Add(r);

            //Thêm tên lớp vào datagridview
            dgvDanhSachLop.Rows[dgvDanhSachLop.RowCount - 1].Cells["TenLop"].Value = LayTenLopHoc(combo_Lophoc.SelectedValue.ToString());
            dgvDanhSachLop.Rows[dgvDanhSachLop.RowCount - 1].Cells["TenKhoaHoc"].Value = LayTenKhoaHoc(combo_KhoaHoc.SelectedValue.ToString());
            dgvDanhSachLop.Rows[dgvDanhSachLop.RowCount - 1].Cells["TenGV"].Value = LayTenGiangVien(cmbGiangVien.SelectedValue.ToString());

        }
        //public void MaLopCuoi()
        //{

        //    //Chuỗi kết nối 
        //    string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        //    //Chuỗi truy vấn
        //    string sMaLop = @"Select MaLop From ThongTinLop";
        //    SqlDataAdapter daDSLop = new SqlDataAdapter(sMaLop, sChuoiKetNoi);
        //    //  SqlDataAdapter daTenKhoaHoc = new SqlDataAdapter(sMaHVCuoiCung, sChuoiKetNoi);
        //    DataTable dt = new DataTable();
        //    daDSLop.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        // Lấy chỉ số phần tử dòng cuối cùng 
        //        int iDongCuoi = dt.Rows.Count - 1;
        //        iMaLop = int.Parse(dt.Rows[iDongCuoi][0].ToString());
        //    }
        //}

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daDSLop.Update(ds, "tblLop");
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblLop"].RejectChanges();
        }

        private void btnThoatRa_Click(object sender, EventArgs e)
        {
            
               this.Close();
        }

        private void dgvDanhSachLop_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachLop.SelectedRows[0];
            txtMaLop.Text = dr.Cells["MaLop"].Value.ToString();
            txtTenLop.Text = dr.Cells["TenLop"].Value.ToString();

            dtpNgaybt.Text = dr.Cells["NBT"].Value.ToString();
            dtpNgaykt.Text = dr.Cells["NKT"].Value.ToString();
            combo_Lophoc.SelectedValue = dr.Cells["MaLop"].Value.ToString();
            combo_KhoaHoc.SelectedValue = dr.Cells["MaKhoaHoc"].Value.ToString();
            txtSoBuoiDay.Text = dr.Cells["SBD"].Value.ToString();
            txtSiSo.Text = dr.Cells["SS"].Value.ToString();

        }

    }
}
