using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Client.Helpers;

namespace Client.DuLieu
{
    public static class KetNoi
    {
        private const string MacDinh =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV_MRBEAST;Integrated Security=True;TrustServerCertificate=True";

        public static string ChuoiKetNoi
        {
            get
            {
                try
                {
                    var raw = ConfigurationManager.ConnectionStrings["QLSV"]?.ConnectionString;
                    if (string.IsNullOrWhiteSpace(raw)) return MacDinh;
                    return CryptoHelper.ResolveConnectionString(raw.Trim());
                }
                catch (Exception ex)
                {
                    LoiTiengViet.GhiLog(ex, "Giải mã connection string");
                    return MacDinh;
                }
            }
        }

        public static SqlConnection MoKetNoi() => new SqlConnection(ChuoiKetNoi);

        public static SqlCommand TaoLenh(string tenProc, SqlConnection conn, CommandType kieu = CommandType.StoredProcedure)
            => new SqlCommand(tenProc, conn) { CommandType = kieu };

        public static string BaoLoi(Exception ex)
        {
            LoiTiengViet.GhiLog(ex);
            return LoiTiengViet.GiaiThich(ex);
        }

        /// <summary>Kiểm tra kết nối trước khi đăng nhập.</summary>
        public static void KiemTraKetNoi()
        {
            try
            {
                using (var conn = MoKetNoi())
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(BaoLoi(ex), ex);
            }
        }
    }
}
