using System;
using System.Windows.Forms;
using Client.Controller;
using Client.Helpers;

namespace Client.View
{
    public partial class frmMain : Form
    {
        private Form frmdangmo = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            MainController.FrmCon(new frmSv(), "QUẢN LÝ SINH VIÊN", pnlDesktop, lblTitle);
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            Announce.Info("Chức năng đang được phát triển");
        }

    }
}