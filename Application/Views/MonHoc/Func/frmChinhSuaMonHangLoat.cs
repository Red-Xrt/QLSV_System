using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLSV.Core.Data;
using QLSV.App.Helpers;
using QLSV.Core.Models;
using QLSV.Core.Services;

namespace QLSV.App.Views.MonHoc.Func
{
    public partial class frmChinhSuaMonHangLoat : Form
    {
        private readonly IReadOnlyList<MonHocChon> _danhSach;
        private readonly XuLyMonHoc _bll = new XuLyMonHoc();

        public frmChinhSuaMonHangLoat(IReadOnlyList<MonHocChon> danhSach)
        {
            _danhSach = danhSach ?? throw new ArgumentNullException(nameof(danhSach));
            if (_danhSach.Count < 2)
                throw new ArgumentException("Form hàng loạt cần từ 2 môn học trở lên.");

            InitializeComponent();
            lblTitle.Text = $"CHỈNH SỬA {_danhSach.Count} MÔN HỌC";
            Text = $"Chỉnh sửa hàng loạt ({_danhSach.Count} môn)";

            foreach (var m in _danhSach)
                lstMonHoc.Items.Add($"{m.MaMH} — {m.TenMH}");
        }

        private void frmChinhSuaMonHangLoat_Load(object sender, EventArgs e)
        {
            NapComboThu();
            NapComboPhongVaGiangVien();
            dtpGioBatDau.Value = DateTime.Today.AddHours(7).AddMinutes(30);
            dtpGioKetThuc.Value = DateTime.Today.AddHours(9).AddMinutes(30);
        }

        private void NapComboPhongVaGiangVien()
        {
            var tatCaMon = _bll.LayDanhSach();
            var dsPhong = tatCaMon.Select(x => x.PhongHoc).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct().OrderBy(x => x).ToList();
            var dsGiangVien = tatCaMon.Select(x => x.GiangVienPhuTrach).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct().OrderBy(x => x).ToList();

            cboPhong.Items.Clear();
            cboGiangVien.Items.Clear();

            foreach (var phong in dsPhong) cboPhong.Items.Add(phong);
            foreach (var gv in dsGiangVien) cboGiangVien.Items.Add(gv);

            if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;
            if (cboGiangVien.Items.Count > 0) cboGiangVien.SelectedIndex = 0;
        }

        private void NapComboThu()
        {
            cboThu.Items.Clear();
            cboThu.Items.AddRange(new object[]
            {
                new ThuItem(2, "Thứ 2"), new ThuItem(3, "Thứ 3"), new ThuItem(4, "Thứ 4"),
                new ThuItem(5, "Thứ 5"), new ThuItem(6, "Thứ 6"), new ThuItem(7, "Thứ 7"),
                new ThuItem(8, "Chủ nhật")
            });
            cboThu.DisplayMember = "Text";
            cboThu.SelectedIndex = 0;
        }

        private void chkDoiPhong_CheckedChanged(object sender, EventArgs e)
        {
            cboPhong.Enabled = chkDoiPhong.Checked;
        }

        private void chkDoiGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            cboGiangVien.Enabled = chkDoiGiangVien.Checked;
        }

        private void chkDoiLich_CheckedChanged(object sender, EventArgs e)
        {
            var on = chkDoiLich.Checked;
            cboThu.Enabled = on;
            dtpGioBatDau.Enabled = on;
            dtpGioKetThuc.Enabled = on;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!chkDoiPhong.Checked && !chkDoiGiangVien.Checked && !chkDoiLich.Checked)
            {
                Announce.Info("Tick ít nhất một mục: phòng, giảng viên hoặc lịch học.");
                return;
            }
            if (chkDoiPhong.Checked && cboPhong.SelectedItem == null)
            {
                Announce.Info("Chọn phòng học trong danh sách.");
                return;
            }
            if (chkDoiGiangVien.Checked && cboGiangVien.SelectedItem == null)
            {
                Announce.Info("Chọn giảng viên trong danh sách.");
                return;
            }

            byte? thu = null;
            TimeSpan? gioBd = null, gioKt = null;
            if (chkDoiLich.Checked)
            {
                thu = ((ThuItem)cboThu.SelectedItem).Value;
                gioBd = dtpGioBatDau.Value.TimeOfDay;
                gioKt = dtpGioKetThuc.Value.TimeOfDay;
            }

            if (!Announce.YesNo($"Cập nhật {_danhSach.Count} môn học đã chọn?"))
                return;

            try
            {
                var ketQua = _bll.CapNhatHangLoat(
                    _danhSach.Select(x => x.MaMH).ToList(),
                    chkDoiPhong.Checked ? cboPhong.Text : null,
                    chkDoiPhong.Checked,
                    chkDoiGiangVien.Checked ? cboGiangVien.Text : null,
                    chkDoiGiangVien.Checked,
                    thu,
                    gioBd,
                    gioKt,
                    chkDoiLich.Checked);

                var ok = ketQua.Count(x => x.ThanhCong);
                var loi = ketQua.Where(x => !x.ThanhCong).ToList();

                if (loi.Count == 0)
                {
                    Announce.Success($"Đã cập nhật {ok} môn học.");
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                var msg = string.Join(Environment.NewLine, loi.Take(6).Select(x => $"{x.MaHienThi}: {x.ThongBao}"));
                if (loi.Count > 6) msg += Environment.NewLine + "...";
                Announce.Error($"Thành công: {ok}. Lỗi ({loi.Count}):\n{msg}");
                if (ok > 0) { DialogResult = DialogResult.OK; Close(); }
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private sealed class ThuItem
        {
            public byte Value { get; }
            public string Text { get; }
            public ThuItem(byte v, string t) { Value = v; Text = t; }
            public override string ToString() => Text;
        }
    }
}
