using System.Collections.Generic;
using System.Data.SqlClient;
using QLSV.Core.Models;

namespace QLSV.Core.Data
{
    public class DocLichHoc
    {
        public List<LichHocItem> LayTheoSinhVien(string maSv)
        {
            var list = new List<LichHocItem>();
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.LayLichHocSinhVien", conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new LichHocItem
                        {
                            MaMH = r["MaMH"].ToString(),
                            TenMH = r["TenMH"].ToString(),
                            SoTinChi = r["SoTinChi"] != System.DBNull.Value ? (byte)r["SoTinChi"] : (byte)0,
                            ThuTrongTuan = r["ThuTrongTuan"] != System.DBNull.Value ? (byte)r["ThuTrongTuan"] : (byte)0,
                            ThuHoc = r["ThuHoc"].ToString(),
                            GioBatDau = r["GioBatDau"].ToString(),
                            GioKetThuc = r["GioKetThuc"].ToString(),
                            PhongHoc = r["PhongHoc"] == System.DBNull.Value ? null : r["PhongHoc"].ToString(),
                            GiangVienPhuTrach = r["GiangVienPhuTrach"] == System.DBNull.Value ? null : r["GiangVienPhuTrach"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
