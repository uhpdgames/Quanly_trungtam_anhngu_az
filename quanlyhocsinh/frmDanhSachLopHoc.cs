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
    public partial class frmDanhSachLopHoc : Form
    {
        public frmDanhSachLopHoc()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataView dv;
        SqlDataAdapter daDSLop;
        SqlDataAdapter daGiangVien;
        private void frmDanhSachLopHoc_Load(object sender, EventArgs e)
        {
           
        }
    }
}
