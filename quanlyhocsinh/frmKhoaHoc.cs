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
    public partial class frmKhoaHoc : Form
    {
        public frmKhoaHoc()
        {
            InitializeComponent();
        }
        int iMaKhoaHoc;
        DataSet ds;
        DataView dv;
        SqlDataAdapter daKhoaHoc;

        private void frmKhoaHoc_Load(object sender, EventArgs e)
        {
            //Chuỗi kết nối 
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();

            //Chuỗi truy vấn
            string sSelectKhoaHoc = @"Select * From dbo.Khoa_Hoc";

            //Khởi tạo đối tượng SQLDataAdapter thực hiện truy vấn lấy dữ liệu từ database về
            daKhoaHoc = new SqlDataAdapter(sSelectKhoaHoc, sChuoiKetNoi);
            //Khởi tạo Dataset
            ds = new DataSet("DsQuanLyKhoaHoc");
            //Đổ dữ liệu vào 1 bảng trong dataset
            daKhoaHoc.Fill(ds, "tblKhoaHoc");
            dv = new DataView(ds.Tables["tblKhoaHoc"]);
            //dgvDanhSachHocVien.DataSource = ds.Tables["tblHocVien"];
            dgvDanhSachKhoaHoc.DataSource = dv;
            //Đặt tên cột cho datagridview
            dgvDanhSachKhoaHoc.Columns["MaKhoaHoc"].HeaderText = "Mã khóa học";
            dgvDanhSachKhoaHoc.Columns["TenKhoaHoc"].HeaderText = "Tên khóa học";
            //Đặt lại độ rộng cho các cột trên datagridview
            dgvDanhSachKhoaHoc.Columns["MaKhoaHoc"].Width = 100;
            dgvDanhSachKhoaHoc.Columns["TenKhoaHoc"].Width = 240;

            //Thêm Khoa hoc
            string sThemKhoaHoc = @"Insert into Khoa_Hoc(TenKhoaHoc) values(@TenKhoaHoc)";
            SqlCommand cmThemKhoaHoc = new SqlCommand(sThemKhoaHoc, con);
            cmThemKhoaHoc.Parameters.Add("@TenKhoaHoc", SqlDbType.NVarChar, 50, "TenKhoaHoc");
            daKhoaHoc.InsertCommand = cmThemKhoaHoc;

            //Sữa khóa học
            //string sSuaHV = @"Update Khoa_Hoc set TenKhoaHoc=@TenKhoaHoc where MaKhoaHoc=@MaKhoaHoc";
            //SqlCommand cmSuaKhoaHoc = new SqlCommand(sSuaHV, con);
           // cmSuaKhoaHoc.Parameters.Add("@TenKhoaHoc", SqlDbType.NVarChar, 50, "TenKhoaHoc");


           // cmSuaKhoaHoc.Parameters.Add("@MaKhoaHoc", SqlDbType.Int, 5, "MaKhoaHoc");

           // daKhoaHoc.UpdateCommand = cmSuaKhoaHoc;
            //Xóa khoác học
            string sXoaKhoaHoc = @"Delete From Khoa_Hoc where MaKhoaHoc=@MaKhoaHoc";
            SqlCommand cmXoaKhoaHoc = new SqlCommand(sXoaKhoaHoc, con);
            cmXoaKhoaHoc.Parameters.Add("@MaKhoaHoc", SqlDbType.Int, 5, "MaKhoaHoc");
            daKhoaHoc.DeleteCommand = cmXoaKhoaHoc;
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKhoaHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTenKhoaHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ đầu vào dữ liệu
            if (txtTenKhoaHoc.Text == "")
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            //Thêm 1 dòng vào tblHocVien
            DataRow r = ds.Tables["tblKhoaHoc"].NewRow();
            //Nhập giá trị vào các trường tương ứng trên Datarow
            r["TenKhoaHoc"] = txtTenKhoaHoc.Text;
            if (iMaKhoaHoc == 0)
            {
                MaKHOA();
            }
            iMaKhoaHoc++;
            //Add Database
            ds.Tables["tblKhoaHoc"].Rows.Add(r);

        }
        public void MaKHOA()
        {

            //Chuỗi kết nối 
            string sChuoiKetNoi = @"Data Source=DANG-PC\SQLEXPRESS;Initial Catalog=Trung_Tam_Anh_Ngu_A_Z;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //Chuỗi truy vấn
            string sMaHVCuoiCung = @"Select MaKhoaHoc From Khoa_Hoc";
            SqlDataAdapter daKhoaHoc = new SqlDataAdapter(sMaHVCuoiCung, sChuoiKetNoi);
            //  SqlDataAdapter daTenKhoaHoc = new SqlDataAdapter(sMaHVCuoiCung, sChuoiKetNoi);
            DataTable dt = new DataTable();
            daKhoaHoc.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                // Lấy chỉ số phần tử dòng cuối cùng 
                int iDongCuoi = dt.Rows.Count - 1;
                iMaKhoaHoc = int.Parse(dt.Rows[iDongCuoi][0].ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daKhoaHoc.Update(ds, "tblKhoaHoc");
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void dgvDanhSachKhoaHoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachKhoaHoc.SelectedRows[0];
            txtMaKhoaHoc.Text = dr.Cells["MaKhoaHoc"].Value.ToString();
            txtTenKhoaHoc.Text = dr.Cells["TenKhoaHoc"].Value.ToString();
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDanhSachKhoaHoc.SelectedRows[0];
                dgvDanhSachKhoaHoc.Rows.Remove(dr);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblKhoaHoc"].RejectChanges();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
          
              this.Close();
        }
    }
}
