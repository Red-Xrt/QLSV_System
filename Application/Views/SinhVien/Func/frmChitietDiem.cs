using System;
using System.Windows.Forms;
using QLSV.Core.Data;
using QLSV.Core.Services;
using QLSV.App.Helpers;
using QLSV.Core.Models;
using QLSV.Core.Helpers;

namespace QLSV.App.Views
{
    public partial class frmChitietDiem : Form
    {
        private readonly string _maSv;
        private readonly string _maMh;
        private readonly string _tenMon;
        private readonly KetQuaMon _kqGoc;
        private readonly XuLyDiem _bll = new XuLyDiem();
        private bool _choPhepSua = true;

        public frmChitietDiem(string maSv, string maMh, string tenMon, KetQuaMon kq)
        {
            _maSv = maSv;
            _maMh = maMh;
            _tenMon = tenMon;
            _kqGoc = kq;
            InitializeComponent();
        }

        private void frmChitietDiem_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Điểm: " + _tenMon;
            lblHocKy.Text = _kqGoc != null && !string.IsNullOrWhiteSpace(_kqGoc.HocKyText)
                ? "Kỳ: " + _kqGoc.HocKyText
                : "Kỳ: chưa xác định";
            if (_kqGoc != null)
            {
                txtDiemQuaTrinh.Text = _kqGoc.DiemQuaTrinh?.ToString() ?? "0";
                txtDiemGiuaKi.Text = _kqGoc.DiemGiuaKi?.ToString() ?? "0";
                txtDiemThi.Text = _kqGoc.DiemCuoiKi?.ToString() ?? "0";
            }
            KiemTraTrangThaiSua();
            CapNhatTong();
        }

        private void KiemTraTrangThaiSua()
        {
            try
            {
                var status = _bll.LayTrangThaiSua(_maSv, _maMh);
                if (status == null) return;

                _choPhepSua = status.CoTheSua;
                if (status.NamHoc > 0 && status.HocKy > 0)
                    lblHocKy.Text = $"Kỳ: {status.NamHoc} - HK{status.HocKy}";

                if (!_choPhepSua)
                {
                    var thongBao = string.IsNullOrWhiteSpace(status.ThongBao)
                        ? "Điểm của kỳ trước hoặc kỳ đã chốt không được chỉnh sửa."
                        : status.ThongBao;

                    txtDiemQuaTrinh.ReadOnly = true;
                    txtDiemGiuaKi.ReadOnly = true;
                    txtDiemThi.ReadOnly = true;
                    btnLuu.Enabled = false;
                    lblTrangThaiSua.Text = thongBao;
                }
                else
                {
                    lblTrangThaiSua.Text = "Có thể chỉnh sửa điểm cho môn học này.";
                }
            }
            catch (Exception ex)
            {
                lblTrangThaiSua.Text = "Không xác định được trạng thái khóa điểm: " + KetNoi.BaoLoi(ex);
            }
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
            CapNhatTong();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_choPhepSua)
                    throw new InvalidOperationException("Điểm của kỳ này đã bị khóa hoặc thuộc kỳ trước, không thể chỉnh sửa.");

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

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
