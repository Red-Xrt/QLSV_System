using System.Collections.Generic;
using System.Data.SqlClient;
using Client.Models;

namespace Client.DuLieu
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
                        list.Add(new LopHoc { MaLop = r["MaLop"].ToString(), TenLop = r["TenLop"].ToString() });
            }
            return list;
        }
    }
}
