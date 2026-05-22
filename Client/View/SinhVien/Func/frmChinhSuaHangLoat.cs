using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Client.DuLieu;
using Client.Helpers;
using Client.Models;
using Client.XuLy;

namespace Client.View
{
    public partial class frmChinhSuaHangLoat : Form
    {
        private readonly IReadOnlyList<SinhVienChon> _danhSach;
        private readonly XuLySinhVien _bll = new XuLySinhVien();
        private readonly XuLyLop _lopBll = new XuLyLop();

        public frmChinhSuaHangLoat(IReadOnlyList<SinhVienChon> danhSach)
        {
            _danhSach = danhSach ?? throw new ArgumentNullException(nameof(danhSach));
            if (_danhSach.Count < 2)
                throw new ArgumentException("Form hàng loạt cần từ 2 sinh viên trở lên.");

            InitializeComponent();
            lblTitle.Text = $"CHỈNH SỬA {_danhSach.Count} SINH VIÊN";
            Text = $"Chỉnh sửa hàng loạt ({_danhSach.Count} SV)";

            foreach (var sv in _danhSach)
                lstSinhVien.Items.Add($"{sv.MaSV} — {sv.HoTen}");

            Load += FrmChinhSuaHangLoat_Load;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (_, __) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void FrmChinhSuaHangLoat_Load(object sender, EventArgs e)
        {
            try
            {
                cboLopMoi.Items.Clear();
                foreach (var l in _lopBll.LayDanhSach()) cboLopMoi.Items.Add(l);
                cboLopMoi.DisplayMember = "TenLop";
                if (cboLopMoi.Items.Count > 0) cboLopMoi.SelectedIndex = 0;
                if (cboGioiTinh.Items.Count > 0) cboGioiTinh.SelectedIndex = 0;
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void ChkDoiLop_CheckedChanged(object sender, EventArgs e) =>
            cboLopMoi.Enabled = chkDoiLop.Checked;

        private void ChkDoiGioiTinh_CheckedChanged(object sender, EventArgs e) =>
            cboGioiTinh.Enabled = chkDoiGioiTinh.Checked;

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!chkDoiLop.Checked && !chkDoiGioiTinh.Checked)
            {
                Announce.Info("Tick ít nhất một mục: chuyển lớp hoặc giới tính.");
                return;
            }

            string maLop = null;
            if (chkDoiLop.Checked)
            {
                if (cboLopMoi.SelectedItem == null)
                {
                    Announce.Info("Chọn lớp mới.");
                    return;
                }
                maLop = ((LopHoc)cboLopMoi.SelectedItem).MaLop;
            }

            string gioiTinh = chkDoiGioiTinh.Checked ? cboGioiTinh.Text : null;

            if (!Announce.YesNo($"Cập nhật {_danhSach.Count} sinh viên đã chọn?"))
                return;

            try
            {
                var maList = _danhSach.Select(x => x.MaSV).ToList();
                var ketQua = _bll.CapNhatHangLoat(maList, maLop, chkDoiLop.Checked, gioiTinh, chkDoiGioiTinh.Checked);
                var ok = ketQua.Count(x => x.ThanhCong);
                var loi = ketQua.Where(x => !x.ThanhCong).ToList();

                if (loi.Count == 0)
                {
                    Announce.Success($"Đã cập nhật {ok} sinh viên.");
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                var msg = string.Join(Environment.NewLine, loi.Take(6).Select(x => $"{x.MaHienThi}: {x.ThongBao}"));
                if (loi.Count > 6) msg += Environment.NewLine + "...";
                Announce.Error($"Thành công: {ok}. Lỗi ({loi.Count}):\n{msg}");
                if (ok > 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

    }
}
