using System;
using System.Windows.Forms;
using Client.DuLieu;
using Client.Helpers;
using Client.XuLy;
using MonHocInfo = Client.Models.MonHoc;

namespace Client.View.MonHoc.Func
{
    public partial class frmChitietMonHoc : Form
    {
        private readonly string _maMh;
        private readonly XuLyMonHoc _bll = new XuLyMonHoc();

        public frmChitietMonHoc(string maMh)
        {
            _maMh = maMh?.Trim();
            InitializeComponent();
            NapComboThu();
            Load += FrmChitietMonHoc_Load;
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += (_, __) => { DialogResult = DialogResult.Cancel; Close(); };
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
        }

        private void FrmChitietMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                var mh = _bll.LayChiTiet(_maMh);
                if (mh == null) { Announce.Error("Không tìm thấy môn học."); Close(); return; }

                txtMaMH.Text = mh.MaMH;
                txtTenMH.Text = mh.TenMH;
                numTinChi.Value = mh.SoTinChi;
                txtGiangVien.Text = mh.GiangVienPhuTrach ?? "";
                txtPhong.Text = mh.PhongHoc ?? "";
                txtMoTa.Text = mh.MoTaMonHoc ?? "";
                ChonThu(mh.ThuTrongTuan);
                dtpGioBatDau.Value = DateTime.Today.Add(ParseGio(mh.GioBatDau));
                dtpGioKetThuc.Value = DateTime.Today.Add(ParseGio(mh.GioKetThuc));
                lblTitle.Text = "MÔN: " + mh.MaMH;
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void ChonThu(byte thu)
        {
            for (int i = 0; i < cboThu.Items.Count; i++)
                if (cboThu.Items[i] is ThuItem t && t.Value == thu)
                {
                    cboThu.SelectedIndex = i;
                    return;
                }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var thu = (ThuItem)cboThu.SelectedItem;
                _bll.CapNhat(new MonHocInfo
                {
                    MaMH = txtMaMH.Text.Trim(),
                    TenMH = txtTenMH.Text.Trim(),
                    SoTinChi = (byte)numTinChi.Value,
                    GiangVienPhuTrach = txtGiangVien.Text.Trim(),
                    PhongHoc = txtPhong.Text.Trim(),
                    MoTaMonHoc = txtMoTa.Text.Trim(),
                    ThuTrongTuan = thu.Value
                }, dtpGioBatDau.Value.TimeOfDay, dtpGioKetThuc.Value.TimeOfDay);

                Announce.Success("Đã cập nhật môn học.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private static TimeSpan ParseGio(string gio) =>
            TimeSpan.TryParse(gio, out var t) ? t : new TimeSpan(7, 30, 0);

        private sealed class ThuItem
        {
            public byte Value { get; }
            public string Text { get; }
            public ThuItem(byte v, string t) { Value = v; Text = t; }
            public override string ToString() => Text;
        }
    }
}
