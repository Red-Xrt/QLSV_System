using System;
using System.Windows.Forms;
using QLSV.Core.Data;
using QLSV.App.Helpers;
using QLSV.Core.Models;
using QLSV.Core.Services;

namespace QLSV.App.Views.LichHoc
{
    public partial class frmLichHocTuan : Form
    {
        private readonly XuLyLichHoc _lichBll = new XuLyLichHoc();
        private readonly XuLySinhVien _svBll = new XuLySinhVien();
        private readonly string _maSvMacDinh;

        public frmLichHocTuan() : this(null) { }

        public frmLichHocTuan(string maSv)
        {
            _maSvMacDinh = maSv;
            InitializeComponent();
        }

        private void frmLichHocTuan_Load(object sender, EventArgs e)
        {
            NapComboSinhVien();
        }

        private void NapComboSinhVien()
        {
            try
            {
                cboSinhVien.Items.Clear();
                foreach (var sv in _svBll.TimKiem(null, null))
                    cboSinhVien.Items.Add(sv);
                cboSinhVien.DisplayMember = "HoTen";
                cboSinhVien.ValueMember = "MaSV";

                if (!string.IsNullOrEmpty(_maSvMacDinh))
                {
                    for (int i = 0; i < cboSinhVien.Items.Count; i++)
                    {
                        if (((SinhVien)cboSinhVien.Items[i]).MaSV == _maSvMacDinh)
                        {
                            cboSinhVien.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else if (cboSinhVien.Items.Count > 0)
                    cboSinhVien.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Announce.Error(KetNoi.BaoLoi(ex));
            }
        }

        private void cboSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapLich();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NapComboSinhVien();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            NapLich();
        }

        private void NapLich()
        {
            if (cboSinhVien.SelectedItem == null)
                return;
            var sv = (SinhVien)cboSinhVien.SelectedItem;
            try
            {
                dgvLich.Rows.Clear();
                var list = _lichBll.LayLichTuan(sv.MaSV);
                foreach (var item in list)
                {
                    dgvLich.Rows.Add(
                        item.ThuHoc,
                        item.MaMH,
                        item.TenMH,
                        item.KhungGio,
                        item.PhongHoc ?? "—",
                        item.GiangVienPhuTrach ?? "—",
                        item.SoTinChi);
                }
                lblTieuDe.Text = $"LỊCH HỌC TUẦN — {sv.MaSV} | {sv.HoTen} ({list.Count} môn)";
            }
            catch (Exception ex)
            {
                Announce.Error(KetNoi.BaoLoi(ex));
            }
        }
    }
}
