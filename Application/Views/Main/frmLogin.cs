using System;
using System.Windows.Forms;
using QLSV.Core.Services;
using QLSV.App.Helpers;
using QLSV.App.Views;
using QLSV.Core.Helpers;

namespace QLSV.App
{
    public partial class frmLogin : Form
    {
        private readonly XuLyDangNhap _auth = new XuLyDangNhap();

        public frmLogin()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            textError.Text = string.Empty;
            try
            {
                _auth.DangNhap(txtboxUserName.Text, txtboxPass.Text);
                if (!SessionContext.IsLoggedIn)
                    throw new InvalidOperationException("Đăng nhập không thành công.");
                Hide();
                var main = new frmMain();
                main.FormClosed += frmMain_FormClosed;
                main.Show();
            }
            catch (Exception ex)
            {
                textError.Text = Announce.ErrorText(ex);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
