using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using QLSV.Core.Services;
using QLSV.App.Helpers;
using QLSV.App.Views.LichHoc;
using QLSV.Core.Models;

namespace QLSV.App.Views
{
    public partial class frmChitietSinhVien : Form
    {
        private readonly string _maSv;
        private readonly XuLySinhVien _bll = new XuLySinhVien();
        private readonly XuLyLop _lopBll = new XuLyLop();
        private readonly XuLyDangKy _dangKyBll = new XuLyDangKy();
        private readonly XuLyMonHoc _monBll = new XuLyMonHoc();
        private SinhVien _svGoc;
        private bool _coThayDoi;
        private List<KetQuaMon> _dsDiem = new List<KetQuaMon>();
        private HocKyHienTai _kyHienTai = new HocKyHienTai();

        public frmChitietSinhVien(string maSv)
        {
            _maSv = maSv;
            InitializeComponent();
        }

        private void frmChitietSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                _kyHienTai = _dangKyBll.LayHocKyHienTai();

                cboLop.Items.Clear();
                foreach (var l in _lopBll.LayDanhSach()) cboLop.Items.Add(l);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";

                _svGoc = _bll.LayChiTiet(_maSv);
                if (_svGoc == null) { Announce.Error("Không tìm thấy sinh viên."); Close(); return; }
                txtMaSV.Text = _svGoc.MaSV;
                txtHoTen.Text = _svGoc.HoTen;
                if (_svGoc.NgaySinh.HasValue) dtpNgaySinh.Value = _svGoc.NgaySinh.Value;
                for (int i = 0; i < cboLop.Items.Count; i++)
                    if (((LopHoc)cboLop.Items[i]).MaLop == _svGoc.MaLop) { cboLop.SelectedIndex = i; break; }
                lblGPA.Text = _svGoc.DiemTB.HasValue ? $"GPA: {_svGoc.DiemTB:0.00}" : "GPA: —";
                lblHocLuc.Text = "Học lực: " + (_svGoc.HocLuc ?? "Chưa xếp loại");

                NapBangDiem();
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }

        private void NapBangDiem()
        {
            dgvDiemThi.Rows.Clear();
            _dsDiem = _bll.LayDiem(_maSv) ?? new List<KetQuaMon>();
            foreach (var kq in _dsDiem)
            {
                dgvDiemThi.Rows.Add(
                    kq.MaMH,
                    $"{kq.TenMH} — {kq.ThuHoc} {kq.KhungGio}",
                    string.IsNullOrWhiteSpace(kq.HocKyText) ? "—" : kq.HocKyText,
                    kq.SoTinChi,
                    HienDiem(kq.DiemQuaTrinh),
                    HienDiem(kq.DiemGiuaKi),
                    HienDiem(kq.DiemCuoiKi),
                    kq.TongKet?.ToString("0.0") ?? "—");
            }
        }

        private static string HienDiem(byte? diem) => diem.HasValue ? diem.Value.ToString() : "—";

        private KetQuaMon LayKqTheoDong(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _dsDiem.Count) return null;
            return _dsDiem[rowIndex];
        }

        private bool CoTheHuyDangKy(KetQuaMon kq, out string lyDo)
        {
            lyDo = null;
            if (kq == null) { lyDo = "Chọn một môn trong danh sách."; return false; }
            if (_kyHienTai.NamHoc <= 0) { lyDo = "Chưa cấu hình học kỳ hiện tại."; return false; }
            if (!kq.LaKyHienTai(_kyHienTai.NamHoc, _kyHienTai.HocKy))
            {
                lyDo = "Chỉ hủy đăng ký môn ở học kỳ hiện tại (" + _kyHienTai.HocKyText + ").";
                return false;
            }
            if (_kyHienTai.KhoaDiem) { lyDo = "Học kỳ hiện tại đã khóa điểm."; return false; }
            if (kq.DaCoDiem()) { lyDo = "Môn đã có điểm, không thể hủy đăng ký."; return false; }
            return true;
        }

        private List<QLSV.Core.Models.MonHoc> LayMonChuaDangKy()
        {
            var daDk = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var kq in _dsDiem)
            {
                if (kq.LaKyHienTai(_kyHienTai.NamHoc, _kyHienTai.HocKy))
                    daDk.Add(kq.MaMH);
            }
            return _monBll.LayDanhSach()
                .Where(m => !daDk.Contains(m.MaMH))
                .OrderBy(m => m.MaMH)
                .ToList();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLop.SelectedItem == null) throw new ArgumentException("Chọn lớp học.");
                if (_svGoc == null) throw new InvalidOperationException("Không có dữ liệu sinh viên.");

                _svGoc.HoTen = txtHoTen.Text.Trim();
                _svGoc.NgaySinh = dtpNgaySinh.Value.Date;
                _svGoc.MaLop = ((LopHoc)cboLop.SelectedItem).MaLop;

                _bll.CapNhat(_svGoc);
                Announce.Success("Cập nhật hồ sơ thành công.");
                _coThayDoi = true;
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }

        private void btnLichTuan_Click(object sender, EventArgs e)
        {
            using (var f = new frmLichHocTuan(_maSv))
                f.ShowDialog(this);
        }

        private void dgvDiemThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var kq = LayKqTheoDong(e.RowIndex);
            if (kq == null) return;

            if (dgvDiemThi.Columns[e.ColumnIndex].Name == "colChiTiet")
            {
                var ten = dgvDiemThi.Rows[e.RowIndex].Cells["colTenMH"].Value?.ToString();
                using (var f = new frmChitietDiem(_maSv, kq.MaMH, ten, kq))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                        CapNhatSauDiem();
                }
                return;
            }

            if (dgvDiemThi.Columns[e.ColumnIndex].Name == "colHuyDangKy")
                HuyDangKyMon(kq);
        }

        private void HuyDangKyMon(KetQuaMon kq)
        {
            if (!CoTheHuyDangKy(kq, out var lyDo))
            {
                Announce.Error(lyDo);
                return;
            }

            if (!Announce.YesNo($"Hủy đăng ký môn {kq.MaMH} ({kq.TenMH}) cho sinh viên {_maSv}?"))
                return;

            try
            {
                var ketQua = _dangKyBll.HuyDangKy(_maSv, kq.MaMH);
                if (ketQua.ThanhCong)
                {
                    Announce.Success(ketQua.ThongBao);
                    _coThayDoi = true;
                    CapNhatSauDiem();
                }
                else
                    Announce.Error(ketQua.ThongBao);
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }

        private void CapNhatSauDiem()
        {
            _svGoc = _bll.LayChiTiet(_maSv);
            if (_svGoc != null)
            {
                lblGPA.Text = _svGoc.DiemTB.HasValue ? $"GPA: {_svGoc.DiemTB:0.00}" : "GPA: —";
                lblHocLuc.Text = "Học lực: " + (_svGoc.HocLuc ?? "Chưa xếp loại");
            }
            NapBangDiem();
        }

        private void frmChitietSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None && _coThayDoi)
                DialogResult = DialogResult.OK;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var kq = dgvDiemThi.CurrentRow != null ? LayKqTheoDong(dgvDiemThi.CurrentRow.Index) : null;
            xoaMonToolStripMenuItem.Enabled = CoTheHuyDangKy(kq, out _);

            var monCon = LayMonChuaDangKy();
            themMonToolStripMenuItem.Enabled = _kyHienTai.NamHoc > 0 && !_kyHienTai.KhoaDiem && monCon.Count > 0;
        }

        private void themMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_kyHienTai.NamHoc <= 0)
            {
                Announce.Error("Chưa cấu hình học kỳ hiện tại.");
                return;
            }
            if (_kyHienTai.KhoaDiem)
            {
                Announce.Error("Học kỳ hiện tại đã khóa điểm, không đăng ký thêm môn.");
                return;
            }

            using (var f = new frmDangKyMonChoSv(_maSv, LayMonChuaDangKy()))
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    _coThayDoi = true;
                    CapNhatSauDiem();
                }
            }
        }

        private void xoaMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDiemThi.CurrentRow == null)
            {
                Announce.Info("Chọn một dòng môn học trước.");
                return;
            }
            HuyDangKyMon(LayKqTheoDong(dgvDiemThi.CurrentRow.Index));
        }
    }
}
