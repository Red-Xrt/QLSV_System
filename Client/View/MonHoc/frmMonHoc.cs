using System;
using System.Linq;
using System.Windows.Forms;
using Client.DuLieu;
using Client.XuLy;
using Client.Helpers;
using Client.View.MonHoc.Func;

namespace Client.View
{
    public partial class frmMonHoc : Form
    {
        private readonly XuLyMonHoc _bll = new XuLyMonHoc();
        private const string Placeholder = "Nhập mã hoặc tên môn học..";
        private const string CotChon = "colSelected";
        private Button _btnDangKyMon;
        private ToolStripMenuItem _mnuDangKySv;

        public frmMonHoc()
        {
            InitializeComponent();
            GridHelper.DamBaoCotCheckbox(dataGridView1, CotChon);
            GridHelper.GanSuKienCheckbox(dataGridView1, CapNhatDem, CotChon);
            TaoNutDangKyMon();
            TaoMenuDangKy();

            Load += (_, __) => NapDuLieu();
            btnTimKiem.Click += (_, __) => NapDuLieu();
            btnThem.Click += BtnThem_Click;
            btnCheckAll.Click += BtnChonTatCa_Click;
            btnUnSellectAll.Click += BtnBoChonTatCa_Click;

            chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            chỉnhSửaToolStripMenuItem.Click += (_, __) => MoChinhSuaMon();
            xóaToolStripMenuItem.Click += (_, __) => BtnXoaMon_Click();
            contextMenuStrip1.Opening += ContextMenuStrip1_Opening;

            dataGridView1.CellDoubleClick += (_, e) =>
            {
                if (e.RowIndex < 0) return;
                var ma = dataGridView1.Rows[e.RowIndex].Cells["ID"]?.Value?.ToString();
                MoChiTietMot(ma);
            };

            txtTimKiem.Enter += (_, __) => GridHelper.ClearPlaceholder(txtTimKiem, Placeholder);
            txtTimKiem.Leave += (_, __) => { if (string.IsNullOrWhiteSpace(txtTimKiem.Text)) txtTimKiem.Text = Placeholder; };
        }

        private void TaoMenuDangKy()
        {
            _mnuDangKySv = new ToolStripMenuItem("Đăng ký cho sinh viên");
            _mnuDangKySv.Click += (_, __) => BtnDangKyMon_Click();
            contextMenuStrip1.Items.Insert(1, _mnuDangKySv);
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var n = GridHelper.LayMonHocDaChon(dataGridView1, CotChon, "ID", "colName").Count;
            if (n == 0 && dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow) n = 1;
            chỉnhSửaToolStripMenuItem.Text = n > 1
                ? $"Chỉnh sửa hàng loạt ({n} môn)"
                : "Chỉnh sửa / Chi tiết";
        }

        private void TaoNutDangKyMon()
        {
            _btnDangKyMon = new Button
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = System.Drawing.Color.SteelBlue,
                FlatStyle = FlatStyle.Flat,
                ForeColor = System.Drawing.Color.White,
                Font = btnThem.Font,
                Location = new System.Drawing.Point(btnThem.Left - 130, btnThem.Top),
                Size = new System.Drawing.Size(120, btnThem.Height),
                Text = "Đăng ký SV",
                UseVisualStyleBackColor = false
            };
            _btnDangKyMon.FlatAppearance.BorderSize = 0;
            _btnDangKyMon.Click += (_, __) => BtnDangKyMon_Click();
            pnlTopBar.Controls.Add(_btnDangKyMon);
            _btnDangKyMon.BringToFront();
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
                f.ShowDialog();
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
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void CapNhatDem()
        {
            var chon = GridHelper.CountChecked(dataGridView1, CotChon);
            var tong = GridHelper.DemHang(dataGridView1);
            lblDaChon.Text = $"Đã chọn: {chon} / Tổng: {tong} môn học";
        }

        private void BtnChonTatCa_Click(object sender, EventArgs e)
        {
            GridHelper.SetAllCheck(dataGridView1, true, CotChon);
            CapNhatDem();
        }

        private void BtnBoChonTatCa_Click(object sender, EventArgs e)
        {
            GridHelper.SetAllCheck(dataGridView1, false, CotChon);
            CapNhatDem();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            using (var f = new frmThemMonHoc())
            {
                if (f.ShowDialog() == DialogResult.OK) NapDuLieu();
            }
        }

        private void BtnXoaMon_Click()
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
            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }
        }

        private void BtnDangKyMon_Click()
        {
            var ds = GridHelper.LayMonHocDaChon(dataGridView1, CotChon, "ID", "colName");
            if (ds.Count == 0)
            {
                Announce.Info("Tick cột Chọn ít nhất một môn, hoặc click một dòng rồi bấm Đăng ký SV.");
                return;
            }
            MoDangKyMon(ds[0].MaMH);
        }
    }
}
