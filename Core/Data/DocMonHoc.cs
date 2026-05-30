using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLSV.Core.Models;

namespace QLSV.Core.Data
{
    public class DocMonHoc
    {
        public List<MonHoc> LayDanhSach(string tuKhoa = null)
        {
            var list = new List<MonHoc>();
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.LayDanhSachMonHoc", conn))
            {
                cmd.Parameters.Add(TaoTuKhoa(tuKhoa));
                conn.Open();
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(Map(r));
            }
            return list;
        }

        private static SqlParameter TaoTuKhoa(string tuKhoa)
        {
            var p = new SqlParameter("@TuKhoa", SqlDbType.NVarChar, 100);
            p.Value = string.IsNullOrWhiteSpace(tuKhoa) ? (object)DBNull.Value : tuKhoa.Trim();
            return p;
        }

        public MonHoc LayChiTiet(string maMh)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.ChiTietMonHoc", conn))
            {
                cmd.Parameters.AddWithValue("@MaMH", maMh);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                    if (r.Read()) return Map(r);
            }
            return null;
        }

        public void Them(MonHoc mh, TimeSpan gioBatDau, TimeSpan gioKetThuc) =>
            ExecMon("dbo.ThemMonHoc", mh, gioBatDau, gioKetThuc);

        public void CapNhat(MonHoc mh, TimeSpan gioBatDau, TimeSpan gioKetThuc) =>
            ExecMon("dbo.CapNhatMonHoc", mh, gioBatDau, gioKetThuc);

        public void Xoa(string maMh)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.XoaMonHoc", conn))
            {
                cmd.Parameters.AddWithValue("@MaMH", maMh);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static void ExecMon(string proc, MonHoc mh, TimeSpan gioBatDau, TimeSpan gioKetThuc)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh(proc, conn))
            {
                cmd.Parameters.AddWithValue("@MaMH", mh.MaMH);
                cmd.Parameters.AddWithValue("@TenMH", mh.TenMH);
                cmd.Parameters.AddWithValue("@SoTinChi", mh.SoTinChi);
                cmd.Parameters.AddWithValue("@GiangVienPhuTrach", mh.GiangVienPhuTrach ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MoTaMonHoc", mh.MoTaMonHoc ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ThuTrongTuan", mh.ThuTrongTuan);
                cmd.Parameters.AddWithValue("@GioBatDau", gioBatDau);
                cmd.Parameters.AddWithValue("@GioKetThuc", gioKetThuc);
                cmd.Parameters.AddWithValue("@PhongHoc", mh.PhongHoc ?? (object)DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static MonHoc Map(SqlDataReader r) => new MonHoc
        {
            MaMH = r["MaMH"].ToString(),
            TenMH = r["TenMH"].ToString(),
            SoTinChi = Convert.ToByte(r["SoTinChi"]),
            GiangVienPhuTrach = r["GiangVienPhuTrach"] == DBNull.Value ? null : r["GiangVienPhuTrach"].ToString(),
            MoTaMonHoc = r["MoTaMonHoc"] == DBNull.Value ? null : r["MoTaMonHoc"].ToString(),
            ThuTrongTuan = Convert.ToByte(r["ThuTrongTuan"]),
            ThuHoc = r["ThuHoc"].ToString(),
            GioBatDau = r["GioBatDau"].ToString(),
            GioKetThuc = r["GioKetThuc"].ToString(),
            LichHocText = r["LichHocText"].ToString(),
            PhongHoc = r["PhongHoc"] == DBNull.Value ? null : r["PhongHoc"].ToString()
        };
    }
}
