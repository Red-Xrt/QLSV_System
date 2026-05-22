using System;
using System.Data;
using System.Data.SqlClient;
using Client.Models;

namespace Client.DuLieu
{
    public class DocDangKy
    {
        public DangKyKetQua DangKy(string maSv, string maMh)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.DangKyMonHocChoSinhVien", conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                cmd.Parameters.AddWithValue("@MaMH", maMh);
                var pOk = new SqlParameter("@ThanhCong", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                var pMsg = new SqlParameter("@ThongBao", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(pOk);
                cmd.Parameters.Add(pMsg);
                conn.Open();
                cmd.ExecuteNonQuery();
                return new DangKyKetQua
                {
                    MaSV = maSv,
                    ThanhCong = pOk.Value != null && pOk.Value != DBNull.Value && (bool)pOk.Value,
                    ThongBao = pMsg.Value?.ToString()
                };
            }
        }
    }
}
