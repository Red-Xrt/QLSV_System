using System;
using System.Data;
using System.Data.SqlClient;
using Client.Models;

namespace Client.DuLieu
{
    public class DocTaiKhoan
    {
        public TaiKhoan LayTheoTenHash(string tenHash)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.LayTaiKhoanDangNhap", conn))
            {
                cmd.Parameters.AddWithValue("@TenDangNhapHash", tenHash);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    return new TaiKhoan
                    {
                        TenDangNhapHash = tenHash,
                        MatKhauHash = r["MatKhauHash"].ToString(),
                        HoTen = r["HoTen"].ToString(),
                        QuyenHan = r["QuyenHan"].ToString(),
                        TrangThai = r["TrangThai"] != DBNull.Value && Convert.ToBoolean(r["TrangThai"])
                    };
                }
            }
        }

        public void DoiMatKhau(string tenHash, string matKhauHashMoi)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.DoiMatKhau", conn))
            {
                cmd.Parameters.AddWithValue("@TenDangNhapHash", tenHash);
                cmd.Parameters.AddWithValue("@MatKhauHash", matKhauHashMoi);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
