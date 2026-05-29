using System;
using System.Data.SqlClient;
using QLSV.Core.Models;

namespace QLSV.Core.Data
{
    public class DocDiem
    {
        public void CapNhat(string maSv, string maMh, byte qt, byte gk, byte ck)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.CapNhatDiem", conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                cmd.Parameters.AddWithValue("@MaMH", maMh);
                cmd.Parameters.AddWithValue("@DiemQuaTrinh", qt);
                cmd.Parameters.AddWithValue("@DiemGiuaKi", gk);
                cmd.Parameters.AddWithValue("@DiemCuoiKi", ck);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public TrangThaiSuaDiem LayTrangThaiSua(string maSv, string maMh)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.KiemTraTrangThaiSuaDiem", conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                cmd.Parameters.AddWithValue("@MaMH", maMh);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    return new TrangThaiSuaDiem
                    {
                        CoTheSua = r["CoTheSua"] != DBNull.Value && (bool)r["CoTheSua"],
                        ThongBao = r["ThongBao"]?.ToString(),
                        NamHoc = r["NamHoc"] == DBNull.Value ? (short)0 : (short)r["NamHoc"],
                        HocKy = r["HocKy"] == DBNull.Value ? (byte)0 : (byte)r["HocKy"],
                        KhoaDiem = r["KhoaDiem"] != DBNull.Value && (bool)r["KhoaDiem"]
                    };
                }
            }
        }
    }
}
