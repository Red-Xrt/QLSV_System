using System;

using System.Collections.Generic;

using System.Linq;

using System.Windows.Forms;

using Client.DuLieu;

using Client.XuLy;

using Client.Helpers;

using Client.Models;

namespace Client.View

{

    public partial class frmSv : Form

    {

        private readonly XuLySinhVien _bll = new XuLySinhVien();

        private readonly XuLyLop _lopBll = new XuLyLop();

        private const string Placeholder = "Nhập mã hoặc tên SV...";

        private const string CotChon = "colSelected";



        public frmSv()

        {

            InitializeComponent();

            GridHelper.GanSuKienCheckbox(dataGridView1, CapNhatDem, CotChon);

            Load += FrmSv_Load;

            btnTimKiem.Click += (_, __) => NapDuLieu();

            btnThem.Click += BtnThem_Click;

            btnCheckAll.Click += BtnChonTatCa_Click;

            btnUnSellectAll.Click += BtnBoChonTatCa_Click;

            cboLocLop.SelectedIndexChanged += (_, __) => NapDuLieu();

            dataGridView1.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) MoChiTietMot(); };

            sửaSinhViênToolStripMenuItem.Click += (_, __) => MoChinhSua();

            xóaToolStripMenuItem.Click += BtnXoa_Click;

            contextMenuStrip1.Opening += ContextMenuStrip1_Opening;

            txtTimKiem.Enter += (_, __) => GridHelper.ClearPlaceholder(txtTimKiem, Placeholder);

            txtTimKiem.Leave += (_, __) => { if (string.IsNullOrWhiteSpace(txtTimKiem.Text)) txtTimKiem.Text = Placeholder; };

        }



        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)

        {

            var n = GridHelper.LaySinhVienDaChon(dataGridView1, CotChon, "ID", "colName").Count;

            if (n == 0 && dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow) n = 1;

            sửaSinhViênToolStripMenuItem.Text = n > 1

                ? $"Chỉnh sửa hàng loạt ({n} SV)"

                : "Chỉnh sửa / Chi tiết";

        }



        private void FrmSv_Load(object sender, EventArgs e)

        {

            NapComboLop();

            NapDuLieu();

        }



        private void NapComboLop()

        {

            try

            {

                cboLocLop.Items.Clear();

                cboLocLop.Items.Add(new LopHoc { MaLop = "", TenLop = "Tất cả lớp" });

                foreach (var l in _lopBll.LayDanhSach()) cboLocLop.Items.Add(l);

                cboLocLop.DisplayMember = "TenLop";

                cboLocLop.ValueMember = "MaLop";

                cboLocLop.SelectedIndex = 0;

            }

            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }

        }



        private void NapDuLieu()

        {

            try

            {

                var list = _bll.TimKiem(GridHelper.GetSearchText(txtTimKiem, Placeholder), GridHelper.GetSelectedValue(cboLocLop));

                dataGridView1.Rows.Clear();

                foreach (var sv in list)

                {

                    dataGridView1.Rows.Add(false, sv.MaSV, sv.HoTen,

                        sv.NgaySinh?.ToString("dd/MM/yyyy"), sv.TenLop ?? sv.MaLop);

                }

                CapNhatDem();

            }

            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }

        }



        private void CapNhatDem()

        {

            var chon = GridHelper.CountChecked(dataGridView1, CotChon);

            var tong = GridHelper.DemHang(dataGridView1);

            lblDaChon.Text = $"Đã chọn: {chon} / Tổng: {tong} sinh viên";

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

            using (var f = new frmThemSv())

            {

                if (f.ShowDialog() == DialogResult.OK) NapDuLieu();

            }

        }



        private void MoChinhSua()

        {

            var ds = GridHelper.LaySinhVienDaChon(dataGridView1, CotChon, "ID", "colName");



            if (ds.Count == 0)

            {

                MoChiTietMot();

                return;

            }



            if (ds.Count == 1)

            {

                MoChiTietMot(ds[0].MaSV);

                return;

            }



            using (var f = new frmChinhSuaHangLoat(ds))

            {

                if (f.ShowDialog() == DialogResult.OK) NapDuLieu();

            }

        }



        private void MoChiTietMot(string maSv = null)

        {

            if (string.IsNullOrEmpty(maSv))

            {

                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)

                {

                    Announce.Info("Chọn một sinh viên (tick cột Chọn hoặc click dòng).");

                    return;

                }

                maSv = dataGridView1.CurrentRow.Cells["ID"].Value?.ToString();

            }



            if (string.IsNullOrEmpty(maSv)) return;



            using (var f = new frmChitietSinhVien(maSv))

            {

                if (f.ShowDialog() == DialogResult.OK) NapDuLieu();

            }

        }



        private void BtnXoa_Click(object sender, EventArgs e)

        {

            var ds = GridHelper.LaySinhVienDaChon(dataGridView1, CotChon, "ID", "colName");

            if (ds.Count == 0)

            {

                Announce.Info("Chọn ít nhất một sinh viên cần xóa (tick cột Chọn).");

                return;

            }

            if (!Announce.YesNo($"Xóa {ds.Count} sinh viên đã chọn?")) return;

            try

            {

                foreach (var sv in ds) _bll.Xoa(sv.MaSV);

                Announce.Success("Đã xóa sinh viên.");

                NapDuLieu();

            }

            catch (Exception ex) { Announce.Error(KetNoi.BaoLoi(ex)); }

        }

    }

}


