using System.Collections.Generic;
using System.Data.SqlClient;
using QLSV.Core.Models;

namespace QLSV.Core.Data
{
    public class DocLop
    {
        public List<LopHoc> LayDanhSach()
        {
            var list = new List<LopHoc>();
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.LayDanhSachLop", conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new LopHoc
                        {
                            MaLop = r["MaLop"].ToString(),
                            TenLop = r["TenLop"].ToString(),
                            SiSo = r["SiSo"] != System.DBNull.Value ? System.Convert.ToInt32(r["SiSo"]) : 0
                        });
            }
            return list;
        }

        public void Them(LopHoc lop)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.ThemLop", conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CapNhat(LopHoc lop)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.CapNhatLop", conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Xoa(string maLop)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.XoaLop", conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
