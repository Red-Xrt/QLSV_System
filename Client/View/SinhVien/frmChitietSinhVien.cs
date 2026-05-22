using System;
using System.Windows.Forms;
using Client.DuLieu;
using Client.XuLy;
using Client.Helpers;
using Client.Models;

namespace Client.View
{
    public partial class frmChitietSinhVien : Form
    {
        private readonly string _maSv;
        private readonly XuLySinhVien _bll = new XuLySinhVien();
        private readonly XuLyLop _lopBll = new XuLyLop();
        private SinhVien _svGoc;
        private bool _coThayDoi;

        public frmChitietSinhVien(string maSv)
        {
            _maSv = maSv;
            InitializeComponent();
            Load += FrmChitietSinhVien_Load;
            FormClosing += FrmChitietSinhVien_FormClosing;
            btnLuu.Click += BtnLuu_Click;
            dgvDiemThi.CellContentClick += DgvDiemThi_CellContentClick;
        }

        private void FrmChitietSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void NapBangDiem()
        {
            dgvDiemThi.Rows.Clear();
            foreach (var kq in _bll.LayDiem(_maSv))
            {
                dgvDiemThi.Rows.Add(kq.MaMH,
                    $"{kq.TenMH} — {kq.ThuHoc} {kq.KhungGio}",
                    kq.SoTinChi,
                    kq.TongKet?.ToString("0.0") ?? "—",
                    "Sửa điểm");
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
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
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void DgvDiemThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvDiemThi.Columns[e.ColumnIndex].Name != "colChiTiet") return;
            var maMh = dgvDiemThi.Rows[e.RowIndex].Cells["colMaMH"].Value?.ToString();
            var ten = dgvDiemThi.Rows[e.RowIndex].Cells["colTenMH"].Value?.ToString();
            var kq = _bll.LayDiem(_maSv).Find(x => x.MaMH == maMh);
            using (var f = new frmChitietDiem(_maSv, maMh, ten, kq))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _coThayDoi = true;
                    _svGoc = _bll.LayChiTiet(_maSv);
                    if (_svGoc != null)
                    {
                        lblGPA.Text = _svGoc.DiemTB.HasValue ? $"GPA: {_svGoc.DiemTB:0.00}" : "GPA: —";
                        lblHocLuc.Text = "Học lực: " + (_svGoc.HocLuc ?? "Chưa xếp loại");
                    }
                    NapBangDiem();
                }
            }
        }

        private void FrmChitietSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None && _coThayDoi)
                DialogResult = DialogResult.OK;
        }
    }
}
