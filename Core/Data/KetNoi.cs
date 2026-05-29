using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using QLSV.Core.Helpers;

namespace QLSV.Core.Data
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
                catch
                {
                    return MacDinh;
                }
            }
        }

        public static SqlConnection MoKetNoi() => new SqlConnection(ChuoiKetNoi);

        public static SqlCommand TaoLenh(string tenProc, SqlConnection conn, CommandType kieu = CommandType.StoredProcedure)
            => new SqlCommand(tenProc, conn) { CommandType = kieu };

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
                throw new InvalidOperationException(Err.GiaiThich(ex), ex);
            }
        }
    }
}
