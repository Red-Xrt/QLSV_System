using System;
using System.Windows.Forms;
using QLSV.Core.Services;
using QLSV.App.Controllers;
using QLSV.App.Helpers;
using QLSV.App.Views.LichHoc;
using QLSV.App.Views.QuanLyLop;
using QLSV.App.Views.XepHang;
using QLSV.Core.Helpers;

namespace QLSV.App.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (SessionContext.CurrentUser != null)
                lblXinChao.Text = "Xin chào, " + SessionContext.CurrentUser.HoTen;
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmSv(), "QUẢN LÝ SINH VIÊN", pnlDesktop, lblTitle);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmLopHoc(), "QUẢN LÝ LỚP HỌC", pnlDesktop, lblTitle);
        }

        private void btnLichHoc_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmLichHocTuan(), "LỊCH HỌC TUẦN", pnlDesktop, lblTitle);
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmMonHoc(), "QUẢN LÝ MÔN HỌC", pnlDesktop, lblTitle);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmXepHang(), "BÁO CÁO & XẾP HẠNG", pnlDesktop, lblTitle);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            using (var f = new frmDoiMatKhau())
                f.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (!Announce.YesNo("Bạn có chắc muốn đăng xuất?")) return;
            new XuLyDangNhap().DangXuat();
            Close();
            Application.Restart();
        }
    }
}
