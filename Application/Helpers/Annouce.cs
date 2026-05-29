using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLSV.Core.Helpers;

namespace QLSV.App.Helpers
{
    public static class Announce
    {
        public static bool YesNo(string message, string title = "Xác nhận")
        {
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public static void Success(string message)
        {
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Info(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string message)
        {
            MessageBox.Show(message ?? "Có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string ErrorText(Exception ex) => Err.GiaiThich(ex);

        public static void ErrorDatabase(Exception ex)
        {
            if (ex == null)
            {
                Error("Có lỗi không xác định.");
                return;
            }
            Err.GhiLog(ex);
            Error(Err.GiaiThich(ex));
        }

        /// <summary>Thông báo kết quả thao tác hàng loạt (một phần thành công).</summary>
        public static void KetQuaHangLoat(int thanhCong, IEnumerable<string> thongBaoLoi, int gioiHanDong = 6)
        {
            var loi = thongBaoLoi?.Where(x => !string.IsNullOrWhiteSpace(x)).ToList() ?? new List<string>();
            if (loi.Count == 0)
            {
                Success($"Đã xử lý {thanhCong} bản ghi.");
                return;
            }
            var msg = string.Join(Environment.NewLine, loi.Take(gioiHanDong));
            if (loi.Count > gioiHanDong) msg += Environment.NewLine + "...";
            Error($"Thành công: {thanhCong}. Lỗi ({loi.Count}):\n{msg}");
        }
    }
}
