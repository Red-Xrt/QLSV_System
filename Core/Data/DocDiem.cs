using System.Data.SqlClient;

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
    }
}
