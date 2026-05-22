using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Client.DuLieu;
using Client.XuLy;
using Client.Helpers;
using Client.Models;
using MonHocInfo = Client.Models.MonHoc;

namespace Client.View.MonHoc.Func
{
    public partial class frmThemMonHoc : Form
    {
        private readonly XuLyMonHoc _monBll = new XuLyMonHoc();
        private readonly XuLySinhVien _svBll = new XuLySinhVien();
        private readonly XuLyDangKy _dkBll = new XuLyDangKy();
        private readonly XuLyLop _lopBll = new XuLyLop();

        private ComboBox cboThuTrongTuan;
        private DateTimePicker dtpGioBatDau;
        private DateTimePicker dtpGioKetThuc;
        private TextBox txtPhongHoc;
        private TextBox txtGiangVien;
        private Label lblLichMon;

        private const string PlaceholderSv = "Nhập mã, tên SV...";
        private List<MonHocInfo> _danhSachMon = new List<MonHocInfo>();

        private const string CotChonSv = "colChon";
        private readonly string _maMhMoDangKy;

        public frmThemMonHoc(string maMhMoDangKy = null)
        {
            _maMhMoDangKy = maMhMoDangKy;
            InitializeComponent();
            TaoControlLichHoc();
            GridHelper.GanSuKienCheckbox(dgvSinhVien, CapNhatDem, CotChonSv);
            Load += FrmThemMonHoc_Load;
            btnLuuHeThong.Click += BtnLuuHeThong_Click;
            btnLuuDangKy.Click += BtnLuuDangKy_Click;
            btnTimKiem.Click += (_, __) => NapSinhVien();
            cboLocLop.SelectedIndexChanged += (_, __) => NapSinhVien();
            cboChonMon.SelectedIndexChanged += CboChonMon_SelectedIndexChanged;
            btnCheckAll.Click += BtnChonTatCa_Click;
            btnUnSellectAll.Click += BtnBoChonTatCa_Click;
            txtTimKiem.Enter += (_, __) => GridHelper.ClearPlaceholder(txtTimKiem, PlaceholderSv);
            txtTimKiem.Leave += (_, __) => { if (string.IsNullOrWhiteSpace(txtTimKiem.Text)) txtTimKiem.Text = PlaceholderSv; };
            mnuExportExcel.Click += MnuExportExcel_Click;
            mnuImportExcel.Click += MnuImportExcel_Click;
        }

        private void TaoControlLichHoc()
        {
            var y = 200;
            var lblThu = new Label { Text = "Thứ trong tuần:", Location = new Point(40, y), AutoSize = true, Font = label1.Font };
            cboThuTrongTuan = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(150, y - 2),
                Size = new Size(250, 25),
                Font = txtMaMH.Font
            };
            cboThuTrongTuan.Items.AddRange(new object[]
            {
                new ThuItem(2, "Thứ 2"), new ThuItem(3, "Thứ 3"), new ThuItem(4, "Thứ 4"),
                new ThuItem(5, "Thứ 5"), new ThuItem(6, "Thứ 6"), new ThuItem(7, "Thứ 7"),
                new ThuItem(8, "Chủ nhật")
            });
            cboThuTrongTuan.DisplayMember = "Text";
            cboThuTrongTuan.SelectedIndex = 0;

            y += 55;
            var lblGio = new Label { Text = "Giờ học:", Location = new Point(40, y), AutoSize = true, Font = label1.Font };
            dtpGioBatDau = new DateTimePicker { Format = DateTimePickerFormat.Time, ShowUpDown = true, Location = new Point(150, y - 2), Size = new Size(110, 25), Value = DateTime.Today.AddHours(7).AddMinutes(30) };
            dtpGioKetThuc = new DateTimePicker { Format = DateTimePickerFormat.Time, ShowUpDown = true, Location = new Point(290, y - 2), Size = new Size(110, 25), Value = DateTime.Today.AddHours(9).AddMinutes(30) };

            y += 55;
            var lblPhong = new Label { Text = "Phòng học:", Location = new Point(40, y), AutoSize = true, Font = label1.Font };
            txtPhongHoc = new TextBox { Location = new Point(150, y - 2), Size = new Size(120, 25), Font = txtMaMH.Font };
            var lblGv = new Label { Text = "Giảng viên:", Location = new Point(290, y), AutoSize = true, Font = label1.Font };
            txtGiangVien = new TextBox { Location = new Point(380, y - 2), Size = new Size(150, 25), Font = txtMaMH.Font };

            btnLuuHeThong.Location = new Point(150, y + 50);
            tabHeThong.Controls.AddRange(new Control[] { lblThu, cboThuTrongTuan, lblGio, dtpGioBatDau, dtpGioKetThuc, lblPhong, txtPhongHoc, lblGv, txtGiangVien });

            lblLichMon = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                ForeColor = Color.DimGray,
                Location = new Point(470, 22),
                MaximumSize = new Size(350, 0)
            };
            pnlTopSV.Controls.Add(lblLichMon);
        }

        /// <summary>Mở tab đăng ký và chọn môn (từ frmMonHoc).</summary>
        public void MoTabDangKy(string maMh = null)
        {
            tabMain.SelectedTab = tabSinhVien;
            if (string.IsNullOrEmpty(maMh) || cboChonMon.Items.Count == 0) return;
            for (var i = 0; i < cboChonMon.Items.Count; i++)
            {
                if (cboChonMon.Items[i] is MonHocItem item &&
                    string.Equals(item.Mon.MaMH, maMh, StringComparison.OrdinalIgnoreCase))
                {
                    cboChonMon.SelectedIndex = i;
                    return;
                }
            }
        }

        private void FrmThemMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                cboLocLop.Items.Clear();
                cboLocLop.Items.Add(new LopHoc { MaLop = "", TenLop = "Tất cả lớp" });
                foreach (var l in _lopBll.LayDanhSach()) cboLocLop.Items.Add(l);
                cboLocLop.DisplayMember = "TenLop";
                cboLocLop.SelectedIndex = 0;

                _danhSachMon = _monBll.LayDanhSach();
                cboChonMon.Items.Clear();
                foreach (var m in _danhSachMon)
                    cboChonMon.Items.Add(new MonHocItem(m));
                cboChonMon.DisplayMember = "Display";
                if (cboChonMon.Items.Count > 0 && string.IsNullOrEmpty(_maMhMoDangKy))
                    cboChonMon.SelectedIndex = 0;

                NapSinhVien();
                if (!string.IsNullOrEmpty(_maMhMoDangKy))
                    MoTabDangKy(_maMhMoDangKy);
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void CboChonMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonMon.SelectedItem is MonHocItem item)
                lblLichMon.Text = "Lịch: " + item.Mon.LichHocText;
            else lblLichMon.Text = string.Empty;
            CapNhatDem();
        }

        private void NapSinhVien()
        {
            try
            {
                var list = _svBll.TimKiem(GridHelper.GetSearchText(txtTimKiem, PlaceholderSv), GridHelper.GetSelectedValue(cboLocLop));
                dgvSinhVien.Rows.Clear();
                foreach (var sv in list)
                    dgvSinhVien.Rows.Add(false, sv.MaSV, sv.HoTen, sv.TenLop ?? sv.MaLop);
                CapNhatDem();
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void CapNhatDem()
        {
            var chon = GridHelper.CountChecked(dgvSinhVien, CotChonSv);
            var tong = GridHelper.DemHang(dgvSinhVien);
            string mon = "chưa chọn môn";
            if (cboChonMon.SelectedItem is MonHocItem item)
                mon = item.Mon.MaMH;
            lblDaChon.Text = $"Đã chọn: {chon} / {tong} sinh viên | Môn: {mon}";
        }

        private void BtnChonTatCa_Click(object sender, EventArgs e)
        {
            GridHelper.SetAllCheck(dgvSinhVien, true, CotChonSv);
            CapNhatDem();
        }

        private void BtnBoChonTatCa_Click(object sender, EventArgs e)
        {
            GridHelper.SetAllCheck(dgvSinhVien, false, CotChonSv);
            CapNhatDem();
        }

        private void BtnLuuHeThong_Click(object sender, EventArgs e)
        {
            try
            {
                var thu = (ThuItem)cboThuTrongTuan.SelectedItem;
                _monBll.Them(new MonHocInfo
                {
                    MaMH = txtMaMH.Text.Trim(),
                    TenMH = txtTenMH.Text.Trim(),
                    SoTinChi = (byte)numTinChi.Value,
                    GiangVienPhuTrach = txtGiangVien.Text.Trim(),
                    ThuTrongTuan = thu.Value,
                    PhongHoc = txtPhongHoc.Text.Trim()
                }, dtpGioBatDau.Value.TimeOfDay, dtpGioKetThuc.Value.TimeOfDay);

                Announce.Success("Thêm môn học thành công.");
                DialogResult = DialogResult.OK;
                txtMaMH.Clear();
                txtTenMH.Clear();
                FrmThemMonHoc_Load(sender, e);
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void BtnLuuDangKy_Click(object sender, EventArgs e)
        {
            if (!(cboChonMon.SelectedItem is MonHocItem monItem))
            {
                Announce.Error("Chọn môn học cần đăng ký.");
                return;
            }

            var dsMaSv = dgvSinhVien.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && GridHelper.DaChon(r.Cells[CotChonSv].Value))
                .Select(r => r.Cells["colMaSV"].Value?.ToString())
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList();

            if (dsMaSv.Count == 0)
            {
                Announce.Info("Chọn ít nhất một sinh viên.");
                return;
            }

            try
            {
                var ketQua = _dkBll.DangKyHangLoat(monItem.Mon.MaMH, dsMaSv);
                var thanhCong = ketQua.Count(x => x.ThanhCong);
                var thatBai = ketQua.Where(x => !x.ThanhCong).ToList();

                if (thatBai.Count == 0)
                    Announce.Success($"Đăng ký thành công cho {thanhCong} sinh viên.");
                else
                {
                    var msg = string.Join(Environment.NewLine, thatBai.Take(8).Select(x => $"{x.MaSV}: {x.ThongBao}"));
                    if (thatBai.Count > 8) msg += Environment.NewLine + "...";
                    Announce.Error($"Thành công: {thanhCong}. Lỗi ({thatBai.Count}):\n{msg}");
                }
                if (thanhCong > 0) DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void MnuExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.Rows.Count == 0) { Announce.Info("Không có dữ liệu để xuất."); return; }
            using (var sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "DanhSachSinhVien.csv" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                var lines = new System.Collections.Generic.List<string> { "MaSV,HoTen,Lop" };
                foreach (DataGridViewRow row in dgvSinhVien.Rows)
                {
                    if (row.IsNewRow) continue;
                    lines.Add($"{row.Cells["colMaSV"].Value},{row.Cells["colTenSV"].Value},{row.Cells["colLop"].Value}");
                }
                System.IO.File.WriteAllLines(sfd.FileName, lines, System.Text.Encoding.UTF8);
                Announce.Success("Đã xuất CSV.");
            }
        }

        private void MnuImportExcel_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "CSV|*.csv" })
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                var maSet = new System.Collections.Generic.HashSet<string>(StringComparer.OrdinalIgnoreCase);
                foreach (var line in System.IO.File.ReadAllLines(ofd.FileName))
                {
                    var t = line.Trim();
                    if (string.IsNullOrEmpty(t) || t.StartsWith("MaSV", StringComparison.OrdinalIgnoreCase)) continue;
                    var parts = t.Split(',');
                    if (parts.Length > 0 && !string.IsNullOrWhiteSpace(parts[0]))
                        maSet.Add(parts[0].Trim());
                }
                if (maSet.Count == 0) { Announce.Info("File không có mã sinh viên."); return; }
                int tick = 0;
                foreach (DataGridViewRow row in dgvSinhVien.Rows)
                {
                    if (row.IsNewRow) continue;
                    var ma = row.Cells["colMaSV"].Value?.ToString();
                    if (ma != null && maSet.Contains(ma))
                    {
                        row.Cells[CotChonSv].Value = true;
                        tick++;
                    }
                }
                CapNhatDem();
                Announce.Success($"Đã chọn {tick} sinh viên từ file.");
            }
        }

        private sealed class ThuItem
        {
            public byte Value { get; }
            public string Text { get; }
            public ThuItem(byte v, string t) { Value = v; Text = t; }
            public override string ToString() => Text;
        }

        private sealed class MonHocItem
        {
            public MonHocInfo Mon { get; }
            public string Display => $"{Mon.MaMH} - {Mon.TenMH} ({Mon.LichHocText})";
            public MonHocItem(MonHocInfo m) { Mon = m; }
            public override string ToString() => Display;
        }
    }
}
