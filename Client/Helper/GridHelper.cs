using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Client.Models;

namespace Client.Helpers
{
    public static class GridHelper
    {
        public static void ClearPlaceholder(TextBox box, string placeholder)
        {
            if (box.Text == placeholder) box.Text = string.Empty;
        }

        public static string GetSearchText(TextBox box, string placeholder)
        {
            var t = box.Text?.Trim();
            return string.IsNullOrEmpty(t) || t == placeholder ? null : t;
        }

        public static string GetSelectedValue(ComboBox cbo)
        {
            if (cbo.SelectedItem == null || cbo.SelectedIndex <= 0) return null;
            if (cbo.SelectedItem is Models.LopHoc l) return l.MaLop;
            var s = cbo.SelectedValue?.ToString();
            return string.IsNullOrEmpty(s) || s == "ALL" ? null : s;
        }

        public static bool DaChon(object giaTri)
        {
            if (giaTri == null || giaTri == DBNull.Value) return false;
            if (giaTri is bool b) return b;
            if (giaTri is CheckState cs) return cs == CheckState.Checked;
            var s = giaTri.ToString().Trim();
            return s.Equals("true", StringComparison.OrdinalIgnoreCase) || s == "1";
        }

        public static int DemHang(DataGridView grid)
        {
            int n = 0;
            foreach (DataGridViewRow row in grid.Rows)
                if (!row.IsNewRow) n++;
            return n;
        }

        public static int CountChecked(DataGridView grid, string colName = "colChon")
        {
            int n = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;
                if (!row.Cells[colName].OwningColumn.Visible) continue;
                if (DaChon(row.Cells[colName].Value)) n++;
            }
            return n;
        }

        public static void SetAllCheck(DataGridView grid, bool check, string colName = "colChon")
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[colName] != null)
                    row.Cells[colName].Value = check;
            }
        }

        public static void GanSuKienCheckbox(DataGridView grid, Action capNhatLabel, string colName = "colChon")
        {
            grid.CurrentCellDirtyStateChanged += (s, e) =>
            {
                var g = (DataGridView)s;
                if (g.IsCurrentCellDirty && g.CurrentCell is DataGridViewCheckBoxCell)
                    g.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            grid.CellValueChanged += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                var g = (DataGridView)s;
                if (g.Columns[e.ColumnIndex].Name == colName)
                    capNhatLabel?.Invoke();
            };
        }

        /// <summary>Lấy danh sách dòng đã tick checkbox + cột mã/tên.</summary>
        public static List<MonHocChon> LayMonHocDaChon(
            DataGridView grid,
            string cotChon = "colSelected",
            string cotMa = "ID",
            string cotTen = "colName")
        {
            var list = new List<MonHocChon>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow || !DaChon(row.Cells[cotChon].Value)) continue;
                var ma = row.Cells[cotMa].Value?.ToString();
                if (string.IsNullOrWhiteSpace(ma)) continue;
                list.Add(new MonHocChon
                {
                    MaMH = ma.Trim(),
                    TenMH = row.Cells[cotTen].Value?.ToString() ?? ma
                });
            }
            return list;
        }

        public static List<SinhVienChon> LaySinhVienDaChon(
            DataGridView grid,
            string cotChon = "colSelected",
            string cotMa = "ID",
            string cotTen = "colName")
        {
            var list = new List<SinhVienChon>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow || !DaChon(row.Cells[cotChon].Value)) continue;
                var ma = row.Cells[cotMa].Value?.ToString();
                if (string.IsNullOrWhiteSpace(ma)) continue;
                list.Add(new SinhVienChon
                {
                    MaSV = ma.Trim(),
                    HoTen = row.Cells[cotTen].Value?.ToString() ?? ma
                });
            }
            return list;
        }

        public static void DamBaoCotCheckbox(DataGridView grid, string colName = "colChon", string tieuDe = "Chọn", int rong = 50)
        {
            if (!grid.Columns.Contains(colName)) return;

            if (!(grid.Columns[colName] is DataGridViewCheckBoxColumn))
            {
                var idx = grid.Columns[colName].Index;
                grid.Columns.Remove(colName);
                grid.Columns.Insert(idx, new DataGridViewCheckBoxColumn
                {
                    Name = colName,
                    HeaderText = tieuDe,
                    Width = rong
                });
            }

            grid.Columns[colName].HeaderText = tieuDe;
            grid.Columns[colName].ReadOnly = false;
            grid.ReadOnly = false;
            foreach (DataGridViewColumn c in grid.Columns)
                if (c.Name != colName) c.ReadOnly = true;
        }
    }
}
