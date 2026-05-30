using System;
using System.Windows.Forms;
using QLSV.Core.Services;
using QLSV.App.Helpers;
using QLSV.App.Views.MonHoc.Func;

namespace QLSV.App.Views
{
    public partial class frmMonHoc : Form
    {
        private readonly XuLyMonHoc _bll = new XuLyMonHoc();
        private const string Placeholder = "Nhập mã hoặc tên môn học..";
        private const string CotChon = "colSelected";

        public frmMonHoc()
        {
            InitializeComponent();
            txtTimKiem.KeyDown += TimKiemEnter;
            GridHelper.DamBaoCotCheckbox(dataGridView1, CotChon);
            GridHelper.GanSuKienCheckbox(dataGridView1, CapNhatDem, CotChon);
            chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
        }

        private void TimKiemEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                NapDuLieu();
            }
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var n = GridHelper.LayMonHocDaChon(dataGridView1, CotChon, "ID", "colName").Count;
            if (n == 0 && dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow) n = 1;
            chỉnhSửaToolStripMenuItem.Text = n > 1
                ? $"Chỉnh sửa hàng loạt ({n} môn)"
                : "Chỉnh sửa / Chi tiết";
        }

        private void MoChinhSuaMon()
        {
            var ds = GridHelper.LayMonHocDaChon(dataGridView1, CotChon, "ID", "colName");
            if (ds.Count == 0)
            {
                MoChiTietMot();
                return;
            }
            if (ds.Count == 1)
            {
                MoChiTietMot(ds[0].MaMH);
                return;
            }
            using (var f = new frmChinhSuaMonHangLoat(ds))
            {
                if (f.ShowDialog() == DialogResult.OK) NapDuLieu();
            }
        }

        private void MoChiTietMot(string maMh = null)
        {
            if (string.IsNullOrEmpty(maMh))
            {
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                {
                    Announce.Info("Chọn một môn (tick cột Chọn hoặc click dòng).");
                    return;
                }
                maMh = dataGridView1.CurrentRow.Cells["ID"]?.Value?.ToString();
            }
            if (string.IsNullOrEmpty(maMh)) return;

            using (var f = new frmChitietMonHoc(maMh))
            {
                if (f.ShowDialog() == DialogResult.OK) NapDuLieu();
            }
        }

        private void MoDangKyMon(string maMh)
        {
            using (var f = new frmThemMonHoc(maMh))
            {
                if (f.ShowDialog() == DialogResult.OK)
                    NapDuLieu();
            }
        }

        private void NapDuLieu()
        {
            try
            {
                var list = _bll.LayDanhSach(GridHelper.GetSearchText(txtTimKiem, Placeholder));
                dataGridView1.Rows.Clear();
                foreach (var m in list)
                    dataGridView1.Rows.Add(false, m.MaMH, m.TenMH, m.LichHocText);

                if (dataGridView1.Columns.Contains("ID"))
                    dataGridView1.Columns["ID"].HeaderText = "Mã môn";
                if (dataGridView1.Columns.Contains("Numbers"))
                    dataGridView1.Columns["Numbers"].HeaderText = "Lịch học";

                CapNhatDem();
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }

        private void CapNhatDem()
        {
            var chon = GridHelper.CountChecked(dataGridView1, CotChon);
            var tong = GridHelper.DemHang(dataGridView1);
            lblDaChon.Text = $"Đã chọn: {chon} / Tổng: {tong} môn học";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            GridHelper.SetAllCheck(dataGridView1, true, CotChon);
            CapNhatDem();
        }

        private void btnUnSellectAll_Click(object sender, EventArgs e)
        {
            GridHelper.SetAllCheck(dataGridView1, false, CotChon);
            CapNhatDem();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var f = new frmThemMonHoc())
            {
                if (f.ShowDialog() == DialogResult.OK) NapDuLieu();
            }
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoChinhSuaMon();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ds = GridHelper.LayMonHocDaChon(dataGridView1, CotChon, "ID", "colName");
            if (ds.Count == 0)
            {
                Announce.Info("Chọn ít nhất một môn cần xóa (tick cột Chọn).");
                return;
            }
            if (!Announce.YesNo($"Xóa {ds.Count} môn học và toàn bộ đăng ký/điểm liên quan?"))
                return;
            try
            {
                foreach (var m in ds) _bll.Xoa(m.MaMH);
                Announce.Success("Đã xóa môn học.");
                NapDuLieu();
            }
            catch (Exception ex) { Announce.ErrorDatabase(ex); }
        }

        private void btnDangKyMon_Click(object sender, EventArgs e)
        {
            var ds = GridHelper.LayMonHocDaChon(dataGridView1, CotChon, "ID", "colName");
            if (ds.Count == 0)
            {
                Announce.Info("Tick cột Chọn ít nhất một môn, hoặc click một dòng rồi bấm Đăng ký SV.");
                return;
            }
            if (ds.Count > 1)
                Announce.Info($"Đang mở đăng ký cho môn {ds[0].MaMH} (môn đầu tiên trong {ds.Count} môn đã chọn).");
            MoDangKyMon(ds[0].MaMH);
        }

        private void mnuDangKySv_Click(object sender, EventArgs e)
        {
            btnDangKyMon_Click(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var ma = dataGridView1.Rows[e.RowIndex].Cells["ID"]?.Value?.ToString();
            MoChiTietMot(ma);
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            GridHelper.ClearPlaceholder(txtTimKiem, Placeholder);
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text)) txtTimKiem.Text = Placeholder;
        }
    }
}
