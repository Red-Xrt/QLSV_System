using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSV.Core.Services;
using QLSV.App.Helpers;
using QLSV.Core.Models;

namespace QLSV.App.Views.XepHang
{
    public partial class frmXepHang : Form
    {
        private readonly XuLyXepHang _bll = new XuLyXepHang();
        private readonly XuLyLop _lopBll = new XuLyLop();
        private string _cheDo = "ALL";

        public frmXepHang()
        {
            InitializeComponent();
        }

        private void frmXepHang_Load(object sender, EventArgs e)
        {
            try
            {
                cboLop.Items.Clear();
                cboLop.Items.Add(new LopHoc { MaLop = "", TenLop = "Tất cả lớp" });
                foreach (var l in _lopBll.LayDanhSach()) cboLop.Items.Add(l);
                cboLop.DisplayMember = "TenLop";
                cboLop.SelectedIndex = 0;
                cboHocLuc.SelectedIndex = 0;
                _cheDo = "ALL";
                DatNutThongKeNhanh();
                NapDuLieu();
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboLop.SelectedIndex = 0;
            cboHocLuc.SelectedIndex = 0;
            _cheDo = "ALL";
            DatNutThongKeNhanh();
            NapDuLieu();
        }

        private void btnApDungLoc_Click(object sender, EventArgs e)
        {
            _cheDo = "ALL";
            DatNutThongKeNhanh();
            NapDuLieu();
        }

        private void btnTopGPA_Click(object sender, EventArgs e)
        {
            _cheDo = "TOP";
            DatNutThongKeNhanh(btnTopGPA);
            NapDuLieu();
        }

        private void btnHocBong_Click(object sender, EventArgs e)
        {
            _cheDo = "HOCBONG";
            DatNutThongKeNhanh(btnHocBong);
            NapDuLieu();
        }

        private void btnCanhBao_Click(object sender, EventArgs e)
        {
            _cheDo = "CANHBAO";
            DatNutThongKeNhanh(btnCanhBao);
            NapDuLieu();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void cboHocLuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count == 0) { Announce.Info("Không có dữ liệu để xuất."); return; }
            using (var sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "BaoCaoXepHang.csv" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("STT,MaSV,HoTen,Lop,GPA,HocLuc,GhiChu");
                    foreach (DataGridViewRow row in dgvBaoCao.Rows)
                    {
                        if (row.IsNewRow) continue;
                        sb.AppendLine(string.Join(",",
                            Csv(row.Cells["colSTT"]?.Value),
                            Csv(row.Cells["colMaSV"]?.Value),
                            Csv(row.Cells["colHoTen"]?.Value),
                            Csv(row.Cells["colLop"]?.Value),
                            Csv(row.Cells["colGPA"]?.Value),
                            Csv(row.Cells["colHocLuc"]?.Value),
                            Csv(row.Cells["colGhiChu"]?.Value)));
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    Announce.Success("Đã xuất file CSV (mở bằng Excel).");
                }
                catch (Exception ex) { Announce.ErrorDatabase(ex); }
            }
        }

        private static string Csv(object value)
        {
            var s = value?.ToString() ?? "";
            if (s.Contains(",") || s.Contains("\""))
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        private void DatNutThongKeNhanh(Button nutDangChon = null)
        {
            foreach (var b in new[] { btnTopGPA, btnHocBong, btnCanhBao })
                b.Font = new Font(b.Font, FontStyle.Regular);
            if (nutDangChon != null)
                nutDangChon.Font = new Font(nutDangChon.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void NapDuLieu()
        {
            try
            {
                string hocLuc = null;
                if (cboHocLuc.SelectedIndex > 0)
                    hocLuc = cboHocLuc.Text;

                var list = _bll.LayBaoCao(GridHelper.GetSelectedValue(cboLop), hocLuc, _cheDo ?? "ALL");
                dgvBaoCao.Rows.Clear();
                int stt = 1;
                foreach (var x in list)
                {
                    dgvBaoCao.Rows.Add(stt++, x.MaSV, x.HoTen, x.TenLop,
                        x.GPA?.ToString("0.00") ?? "—", x.HocLuc, x.GhiChu);
                }

                int tong = list.Count;
                int hb = list.Count(x => x.GPA.HasValue && x.GPA >= 8.0m);
                int cb = list.Count(x => x.GPA.HasValue && x.GPA < 5.0m);
                lblStatTong.Text = tong.ToString();
                lblStatHocBong.Text = hb.ToString();
                lblStatCanhBao.Text = cb.ToString();

                var cheDoText = _cheDo == "ALL" ? "Tất cả" :
                    _cheDo == "TOP" ? "Top 20 GPA" :
                    _cheDo == "HOCBONG" ? "Học bổng" : "Cảnh báo";
                lblTitle.Text = $"BÁO CÁO & XẾP HẠNG — {cheDoText} ({list.Count} SV)";
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }
    }
}
