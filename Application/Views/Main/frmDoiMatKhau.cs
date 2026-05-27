using System;
using System.Windows.Forms;
using QLSV.Core.Data;
using QLSV.App.Helpers;
using QLSV.Core.Services;

namespace QLSV.App.Views
{
    public partial class frmDoiMatKhau : Form
    {
        private readonly XuLyDangNhap _auth = new XuLyDangNhap();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
