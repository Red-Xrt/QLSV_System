using System;
using System.Windows.Forms;
using Client.DuLieu;
using Client.XuLy;
using Client.Helpers;
using Client.Models;

namespace Client.View
{
    public partial class frmChitietDiem : Form
    {
        private readonly string _maSv, _maMh;
        private readonly XuLyDiem _bll = new XuLyDiem();

        public frmChitietDiem(string maSv, string maMh, string tenMon, KetQuaMon kq)
        {
            _maSv = maSv;
            _maMh = maMh;
            InitializeComponent();
            lblTitle.Text = "Điểm: " + tenMon;
            if (kq != null)
            {
                txtDiemQuaTrinh.Text = kq.DiemQuaTrinh?.ToString() ?? "0";
                txtDiemGiuaKi.Text = kq.DiemGiuaKi?.ToString() ?? "0";
                txtDiemThi.Text = kq.DiemCuoiKi?.ToString() ?? "0";
            }
            CapNhatTong();
            txtDiemQuaTrinh.TextChanged += (_, __) => CapNhatTong();
            txtDiemGiuaKi.TextChanged += (_, __) => CapNhatTong();
            txtDiemThi.TextChanged += (_, __) => CapNhatTong();
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += (_, __) => Close();
        }

        private void CapNhatTong()
        {
            if (ValidationHelper.TryDiem(txtDiemQuaTrinh.Text, out var qt, out _) &&
                ValidationHelper.TryDiem(txtDiemGiuaKi.Text, out var gk, out _) &&
                ValidationHelper.TryDiem(txtDiemThi.Text, out var ck, out _))
            {
                var tong = _bll.TinhTong(qt, gk, ck);
                lblDiemTong.Text = $"TỔNG KẾT: {tong:0.0} ({(tong >= 5 ? "Đậu" : "Rớt")})";
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidationHelper.TryDiem(txtDiemQuaTrinh.Text, out var qt, out var err)) throw new ArgumentException(err);
                if (!ValidationHelper.TryDiem(txtDiemGiuaKi.Text, out var gk, out err)) throw new ArgumentException(err);
                if (!ValidationHelper.TryDiem(txtDiemThi.Text, out var ck, out err)) throw new ArgumentException(err);
                _bll.CapNhat(_maSv, _maMh, qt, gk, ck);
                Announce.Success("Cập nhật điểm thành công.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }
    }
}
