using System;
using System.Windows.Forms;
using QLSV.Core.Services;
using QLSV.App.Helpers;
using QLSV.Core.Models;

namespace QLSV.App.Views
{
    public partial class frmThemSv : Form
    {
        private readonly XuLySinhVien _bll = new XuLySinhVien();
        private readonly XuLyLop _lopBll = new XuLyLop();

        public frmThemSv()
        {
            InitializeComponent();
        }

        private void frmThemSv_Load(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = true;
            txtMaSV.TabStop = false;
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
            try
            {
                txtMaSV.Text = _bll.LayMaSvTiepTheo();
                foreach (var l in _lopBll.LayDanhSach()) cboLop.Items.Add(l);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
                if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp" })
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    picAvatar.ImageLocation = ofd.FileName;
                    Announce.Info("Ảnh chỉ hiển thị trên máy này (chưa lưu database).");
                }
                catch (Exception ex) { Announce.ErrorDatabase(ex); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLop.SelectedItem == null) throw new ArgumentException("Chọn lớp học.");
                var lop = (LopHoc)cboLop.SelectedItem;
                _bll.Them(new SinhVien
                {
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value.Date,
                    GioiTinh = cboGioiTinh.Text,
                    MaLop = lop.MaLop
                });
                Announce.Success("Thêm sinh viên thành công.");
                DialogResult = DialogResult.OK;
                Close();
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
