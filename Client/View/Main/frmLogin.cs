using System;
using System.Windows.Forms;
using Client.DuLieu;
using Client.XuLy;
using Client.Helpers;
using Client.View;

namespace Client
{
    public partial class frmLogin : Form
    {
        private readonly XuLyDangNhap _auth = new XuLyDangNhap();

        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnExit.Click += (_, __) => Application.Exit();
            AcceptButton = btnLogin;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            textError.Text = string.Empty;
            try
            {
                _auth.DangNhap(txtboxUserName.Text, txtboxPass.Text);
                if (!SessionContext.IsLoggedIn)
                    throw new InvalidOperationException("Đăng nhập không thành công.");
                Hide();
                var main = new frmMain();
                main.FormClosed += (_, __) => Close();
                main.Show();
            }
            catch (Exception ex)
            {
                textError.Text = KetNoi.BaoLoi(ex);
            }
        }
    }
}
