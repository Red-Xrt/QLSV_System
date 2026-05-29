using System;
using System.Data.SqlClient;
using QLSV.Core.Models;

namespace QLSV.Core.Data
{
    public class DocHocKy
    {
        public HocKyHienTai LayHienTai()
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.LayHocKyHienTai", conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return new HocKyHienTai();
                    return new HocKyHienTai
                    {
                        NamHoc = Convert.ToInt16(r["NamHoc"]),
                        HocKy = Convert.ToByte(r["HocKy"]),
                        KhoaDiem = r["KhoaDiem"] != DBNull.Value && Convert.ToBoolean(r["KhoaDiem"])
                    };
                }
            }
        }
    }
}
