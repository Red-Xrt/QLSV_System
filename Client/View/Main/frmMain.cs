using System;
using System.Windows.Forms;
using Client.XuLy;
using Client.Controller;
using Client.Helpers;
using Client.View.XepHang;

namespace Client.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (SessionContext.CurrentUser != null)
                lblXinChao.Text = "Xin chào, " + SessionContext.CurrentUser.HoTen;

            btnBaoCao.Click += BtnBaoCao_Click;
            btnDangXuat.Click += BtnDangXuat_Click;
            btnTaiKhoan.Click += BtnTaiKhoan_Click;
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmSv(), "QUẢN LÝ SINH VIÊN", pnlDesktop, lblTitle);
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmMonHoc(), "QUẢN LÝ MÔN HỌC", pnlDesktop, lblTitle);
        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmXepHang(), "BÁO CÁO & XẾP HẠNG", pnlDesktop, lblTitle);
        }

        private void BtnTaiKhoan_Click(object sender, EventArgs e)
        {
            using (var f = new frmDoiMatKhau())
                f.ShowDialog();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            if (!Announce.YesNo("Bạn có chắc muốn đăng xuất?")) return;
            new XuLyDangNhap().DangXuat();
            Close();
            Application.Restart();
        }
    }
}
