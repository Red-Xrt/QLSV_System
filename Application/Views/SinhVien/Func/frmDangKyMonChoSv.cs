using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLSV.App.Helpers;
using QLSV.Core.Models;
using QLSV.Core.Services;

namespace QLSV.App.Views
{
    public partial class frmDangKyMonChoSv : Form
    {
        private readonly string _maSv;
        private readonly XuLyDangKy _dangKyBll = new XuLyDangKy();
        private readonly List<QLSV.Core.Models.MonHoc> _danhSachMon;

        public frmDangKyMonChoSv(string maSv, List<QLSV.Core.Models.MonHoc> monChuaDangKy)
        {
            _maSv = maSv;
            _danhSachMon = monChuaDangKy ?? new List<QLSV.Core.Models.MonHoc>();
            InitializeComponent();
            Shown += frmDangKyMonChoSv_Shown;
        }

        private void frmDangKyMonChoSv_Load(object sender, EventArgs e)
        {
            cboMon.DisplayMember = "TenMH";
            cboMon.ValueMember = "MaMH";
            cboMon.DataSource = _danhSachMon;
            cboMon.FormattingEnabled = true;
            cboMon.Format += CboMon_Format;
        }

        private void frmDangKyMonChoSv_Shown(object sender, EventArgs e)
        {
            if (_danhSachMon.Count == 0)
            {
                Announce.Info("Sinh viên đã đăng ký hết môn trong học kỳ hiện tại.");
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private static void CboMon_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is QLSV.Core.Models.MonHoc mh)
                e.Value = $"{mh.MaMH} — {mh.TenMH} ({mh.SoTinChi} TC)";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMon.SelectedItem == null)
            {
                Announce.Info("Chọn môn học cần đăng ký.");
                return;
            }

            var mh = (QLSV.Core.Models.MonHoc)cboMon.SelectedItem;
            try
            {
                var kq = _dangKyBll.DangKyMot(_maSv, mh.MaMH);
                if (kq.ThanhCong)
                {
                    Announce.Success(kq.ThongBao ?? "Đăng ký môn thành công.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    Announce.Error(kq.ThongBao ?? "Đăng ký không thành công.");
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
