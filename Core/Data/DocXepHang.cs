using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLSV.Core.Models;

namespace QLSV.Core.Data
{
    public class DocXepHang
    {
        public List<XepHangItem> LayBaoCao(string maLop, string hocLuc, string cheDo)
        {
            var list = new List<XepHangItem>();
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.LayBaoCaoXepHang", conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", string.IsNullOrEmpty(maLop) ? (object)DBNull.Value : maLop);
                cmd.Parameters.AddWithValue("@HocLuc", string.IsNullOrEmpty(hocLuc) ? (object)DBNull.Value : hocLuc);
                cmd.Parameters.AddWithValue("@CheDo", string.IsNullOrEmpty(cheDo) ? (object)DBNull.Value : cheDo);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new XepHangItem
                        {
                            MaSV = r["MaSV"].ToString(),
                            HoTen = r["HoTen"].ToString(),
                            TenLop = r["TenLop"] == DBNull.Value ? null : r["TenLop"].ToString(),
                            GPA = r["GPA"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["GPA"]),
                            HocLuc = r["HocLuc"].ToString(),
                            GhiChu = r["GhiChu"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public void ThongKe(string maLop, out int tong, out int hocBong, out int canhBao)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.ThongKeBaoCao", conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", string.IsNullOrEmpty(maLop) ? (object)DBNull.Value : maLop);
                var pTong = new SqlParameter("@TongSV", SqlDbType.Int) { Direction = ParameterDirection.Output };
                var pHb = new SqlParameter("@SoHocBong", SqlDbType.Int) { Direction = ParameterDirection.Output };
                var pCb = new SqlParameter("@SoCanhBao", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(pTong);
                cmd.Parameters.Add(pHb);
                cmd.Parameters.Add(pCb);
                conn.Open();
                cmd.ExecuteNonQuery();
                tong = pTong.Value == DBNull.Value ? 0 : Convert.ToInt32(pTong.Value);
                hocBong = pHb.Value == DBNull.Value ? 0 : Convert.ToInt32(pHb.Value);
                canhBao = pCb.Value == DBNull.Value ? 0 : Convert.ToInt32(pCb.Value);
            }
        }
    }
}
