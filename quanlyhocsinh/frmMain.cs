using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmMain : Form
    {
        //Tạo đối tượng panl
        public static Panel pnl;
        //Lấy độ rộng của form main
        public static int iDoRongFormMain;
        public static int iDoRongFormMainBanDau;
        public frmMain()
        {
            //Đưa panel vào formMain
            pnl = new Panel();
            pnl.Name = "pnl";
            pnl.Size = new Size(0, 0);
            this.Controls.Add(pnl);
            InitializeComponent();
            //Gán độ rộng form vào biến
            iDoRongFormMain = this.Width;
            //Gán độ rộng ban đầu
            iDoRongFormMainBanDau = this.Width;
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            frmQuanLyHocVien frm = new frmQuanLyHocVien();
            frm.ShowDialog();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa có!", "Thông báo");

            ////Khởi tao form nhập điểm
            //frmNhapDiem frm = new frmNhapDiem();
            //frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.Show();
            ////Add frm vào panel
            //pnl.Size = frm.Size;
            //pnl.Controls.Add(frm);
            ////Gán location của panel ra khỏi form main
            //pnl.Location = new Point(iDoRongFormMain,50);
            ////Chạy timer
            //tmNhapDiem.Start();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa có!", "Thông báo");
        }

        private void tmNhapDiem_Tick(object sender, EventArgs e)
        {
            //Giảm độ rộng và thực hiện timer chạy
            if (iDoRongFormMain > 150)
            {
                iDoRongFormMain -= 10;
                pnl.Location = new Point(iDoRongFormMain, 50);
                if (iDoRongFormMain == 150)
                {
                    tmNhapDiem.Stop();
                }
            }
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiangVien frm2 = new frmGiangVien(); 
            frm2.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            return;
        }

        private void btnQuiDinh_Click(object sender, EventArgs e)
        {
            frmBanQuyen frm = new frmBanQuyen();
            frm.ShowDialog();
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            frmLopHoc frm = new frmLopHoc();

            //frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.Show();
            ////Add frm vào panel
            //pnl.Size = frm.Size;
            //pnl.Controls.Add(frm);
            ////Gán location của panel ra khỏi form main
            //pnl.Location = new Point(iDoRongFormMain, 50);
            ////Chạy timer
            //tmNhapDiem.Start();
           
           frm.ShowDialog();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng này bị lỗi!", "Thông báo");
           // MessageBox.Show("Ấn thoát bằng icon x đỏ!", "Thông báo");
            frmKhoaHoc frm = new frmKhoaHoc();
           
            //frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.Show();
            ////Add frm vào panel
            //pnl.Size = frm.Size;
            //pnl.Controls.Add(frm);
            ////Gán location của panel ra khỏi form main
            //pnl.Location = new Point(iDoRongFormMain, 50);
            ////Chạy timer
            //tmNhapDiem.Start();
            
            frm.ShowDialog();
        }

        private void btnThongke_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng này chưa có!", "Thông báo");
            frmConnectDatabase frm = new frmConnectDatabase();
            frm.ShowDialog();
        }
    }
}
