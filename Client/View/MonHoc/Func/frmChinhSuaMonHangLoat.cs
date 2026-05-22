using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Client.DuLieu;
using Client.Helpers;
using Client.Models;
using Client.XuLy;

namespace Client.View.MonHoc.Func
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

            NapComboThu();
            dtpGioBatDau.Value = DateTime.Today.AddHours(7).AddMinutes(30);
            dtpGioKetThuc.Value = DateTime.Today.AddHours(9).AddMinutes(30);

            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (_, __) => { DialogResult = DialogResult.Cancel; Close(); };
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

        private void ChkDoiPhong_CheckedChanged(object sender, EventArgs e) =>
            txtPhong.Enabled = chkDoiPhong.Checked;

        private void ChkDoiGiangVien_CheckedChanged(object sender, EventArgs e) =>
            txtGiangVien.Enabled = chkDoiGiangVien.Checked;

        private void ChkDoiLich_CheckedChanged(object sender, EventArgs e)
        {
            var on = chkDoiLich.Checked;
            cboThu.Enabled = on;
            dtpGioBatDau.Enabled = on;
            dtpGioKetThuc.Enabled = on;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!chkDoiPhong.Checked && !chkDoiGiangVien.Checked && !chkDoiLich.Checked)
            {
                Announce.Info("Tick ít nhất một mục: phòng, giảng viên hoặc lịch học.");
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
                    txtPhong.Text,
                    chkDoiPhong.Checked,
                    txtGiangVien.Text,
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

        private sealed class ThuItem
        {
            public byte Value { get; }
            public string Text { get; }
            public ThuItem(byte v, string t) { Value = v; Text = t; }
            public override string ToString() => Text;
        }
    }
}
