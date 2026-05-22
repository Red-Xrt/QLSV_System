using System;
using System.Linq;
using System.Windows.Forms;
using Client.DuLieu;
using Client.XuLy;
using Client.Helpers;
using Client.Models;

namespace Client.View
{
    public partial class frmThemSv : Form
    {
        private readonly XuLySinhVien _bll = new XuLySinhVien();
        private readonly XuLyLop _lopBll = new XuLyLop();

        public frmThemSv()
        {
            InitializeComponent();
            Load += FrmThemSv_Load;
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += (_, __) => { DialogResult = DialogResult.Cancel; Close(); };
            btnChonAnh.Click += BtnChonAnh_Click;
        }

        private void FrmThemSv_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
            try
            {
                foreach (var l in _lopBll.LayDanhSach()) cboLop.Items.Add(l);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
                if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp" })
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    picAvatar.ImageLocation = ofd.FileName;
                    Announce.Info("Ảnh chỉ hiển thị trên máy này (chưa lưu database).");
                }
                catch (Exception ex) { Announce.Error("Không mở được ảnh: " + ex.Message); }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboLop.SelectedItem == null) throw new ArgumentException("Chọn lớp học.");
                var lop = (LopHoc)cboLop.SelectedItem;
                _bll.Them(new SinhVien
                {
                    MaSV = txtMaSV.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value.Date,
                    GioiTinh = cboGioiTinh.Text,
                    MaLop = lop.MaLop
                });
                Announce.Success("Thêm sinh viên thành công.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }
    }
}
