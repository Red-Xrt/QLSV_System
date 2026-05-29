using System;
using System.Windows.Forms;
using QLSV.App.Helpers;
using QLSV.Core.Models;
using QLSV.Core.Services;

namespace QLSV.App.Views.QuanLyLop
{
    public partial class frmLopHoc : Form
    {
        private readonly XuLyLop _bll = new XuLyLop();
        private bool _cheDoThem;

        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            NapDanhSach();
            DatCheDoThem(true);
        }

        private void NapDanhSach()
        {
            try
            {
                dgvLop.Rows.Clear();
                foreach (var l in _bll.LayDanhSach())
                    dgvLop.Rows.Add(l.MaLop, l.TenLop, l.SiSo);
                lblTong.Text = $"Tổng: {dgvLop.Rows.Count} lớp";
            }
            catch (Exception ex)
            {
                Announce.ErrorDatabase(ex);
            }
        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null || dgvLop.CurrentRow.IsNewRow)
                return;
            txtMaLop.Text = dgvLop.CurrentRow.Cells["colMaLop"].Value?.ToString();
            txtTenLop.Text = dgvLop.CurrentRow.Cells["colTenLop"].Value?.ToString();
            lblSiSo.Text = "Sĩ số: " + dgvLop.CurrentRow.Cells["colSiSo"].Value;
            DatCheDoThem(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            lblSiSo.Text = "Sĩ số: 0";
            DatCheDoThem(true);
            txtMaLop.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var lop = new LopHoc
                {
                    MaLop = txtMaLop.Text.Trim(),
                    TenLop = txtTenLop.Text.Trim()
                };
                if (_cheDoThem)
                    _bll.Them(lop);
                else
                    _bll.CapNhat(lop);
                Announce.Success(_cheDoThem ? "Thêm lớp thành công." : "Cập nhật lớp thành công.");
                NapDanhSach();
                DatCheDoThem(true);
            }
            catch (Exception ex)
            {
                Announce.ErrorDatabase(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var ma = txtMaLop.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                Announce.Info("Chọn lớp cần xóa.");
                return;
            }
            if (!Announce.YesNo($"Xóa lớp {ma}? Chỉ xóa được khi lớp không còn sinh viên."))
                return;
            try
            {
                _bll.Xoa(ma);
                Announce.Success("Đã xóa lớp.");
                NapDanhSach();
                btnThem_Click(sender, e);
            }
            catch (Exception ex)
            {
                Announce.ErrorDatabase(ex);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NapDanhSach();
            btnThem_Click(sender, e);
        }

        private void DatCheDoThem(bool them)
        {
            _cheDoThem = them;
            txtMaLop.ReadOnly = !them;
            btnLuu.Text = them ? "Thêm lớp" : "Cập nhật";
        }
    }
}
