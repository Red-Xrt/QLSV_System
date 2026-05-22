using System;
using System.Windows.Forms;
using Client.DuLieu;
using Client.Helpers;
using Client.XuLy;

namespace Client.View
{
    public partial class frmDoiMatKhau : Form
    {
        private readonly XuLyDangNhap _auth = new XuLyDangNhap();

        public frmDoiMatKhau()
        {
            InitializeComponent();
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (_, __) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                _auth.DoiMatKhau(txtCu.Text, txtMoi.Text, txtXacNhan.Text);
                Announce.Success("Đổi mật khẩu thành công.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }
    }
}
