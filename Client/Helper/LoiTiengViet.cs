using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Client.Helpers
{
    public static class LoiTiengViet
    {
        public static string GiaiThich(Exception ex)
        {
            if (ex == null) return "Có lỗi không xác định.";

            var sql = TimSqlException(ex);
            if (sql != null) return GiaiThichSql(sql);

            var msg = (ex.InnerException?.Message ?? ex.Message ?? "").Trim();

            if (ex is ArgumentException) return msg;

            if (msg.IndexOf("cannot find the file specified", StringComparison.OrdinalIgnoreCase) >= 0
                || msg.IndexOf("could not open a connection", StringComparison.OrdinalIgnoreCase) >= 0
                || msg.IndexOf("network-related", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return "Không kết nối được SQL Server. Bật SQL Server (SQLEXPRESS hoặc LocalDB), chạy file Database/CSDL.sql, rồi sửa Data Source trong App.config cho đúng máy bạn.";
            }

            if (msg.IndexOf("connection string", StringComparison.OrdinalIgnoreCase) >= 0
                || msg.IndexOf("mã hóa", StringComparison.OrdinalIgnoreCase) >= 0)
                return "Lỗi cấu hình kết nối database. Kiểm tra lại App.config.";

            if (msg.IndexOf("Login failed", StringComparison.OrdinalIgnoreCase) >= 0)
                return "Đăng nhập SQL thất bại. Thử dùng Windows Authentication trong connection string.";

            return string.IsNullOrEmpty(msg) ? "Có lỗi xảy ra. Thử lại sau." : msg;
        }

        public static void GhiLog(Exception ex, string nguCan = null)
        {
            var text = string.IsNullOrEmpty(nguCan)
                ? GiaiThich(ex)
                : nguCan + ": " + GiaiThich(ex);
            Debug.WriteLine("[QLSV] " + text);
        }

        private static SqlException TimSqlException(Exception ex)
        {
            while (ex != null)
            {
                if (ex is SqlException s) return s;
                ex = ex.InnerException;
            }
            return null;
        }

        private static string GiaiThichSql(SqlException sql)
        {
            if (sql.Number >= 50000) return sql.Message;

            switch (sql.Number)
            {
                case 2:
                case 40:
                case 53:
                    return "Không tìm thấy máy chủ SQL. Kiểm tra SQL Server đã cài và đang chạy (thường là .\\SQLEXPRESS hoặc (localdb)\\MSSQLLocalDB).";
                case 4060:
                    return "Chưa có database QLSV_MRBEAST. Mở SSMS, chạy file Database/CSDL.sql (Execute một lần).";
                case 18456:
                    return "SQL Server từ chối đăng nhập. Dùng Integrated Security=True trong App.config.";
                case 547:
                    return "Dữ liệu liên quan chưa đúng (khóa ngoại). Kiểm tra mã lớp, mã môn trước khi lưu.";
                case 2627:
                case 2601:
                    return "Mã đã tồn tại trong hệ thống, không thêm trùng được.";
                default:
                    return "Lỗi database (mã " + sql.Number + "): " + sql.Message;
            }
        }
    }
}
