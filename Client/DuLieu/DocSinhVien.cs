using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Client.Models;

namespace Client.DuLieu
{
    public class DocSinhVien
    {
        public List<SinhVien> TimKiem(string tuKhoa, string maLop)
        {
            var list = new List<SinhVien>();
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.TimKiemSinhVien", conn))
            {
                cmd.Parameters.AddWithValue("@TuKhoa", string.IsNullOrWhiteSpace(tuKhoa) ? (object)DBNull.Value : tuKhoa.Trim());
                cmd.Parameters.AddWithValue("@MaLop", string.IsNullOrEmpty(maLop) ? (object)DBNull.Value : maLop);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapSinhVien(r));
            }
            return list;
        }

        public SinhVien LayThongTin(string maSv)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.ThongTinSinhVien", conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                    if (r.Read()) return MapSinhVienFull(r);
            }
            return null;
        }

        public void Them(SinhVien sv) => ExecSv("dbo.ThemSinhVien", sv);
        public void CapNhat(SinhVien sv) => ExecSv("dbo.CapNhatSinhVien", sv);

        public void Xoa(string maSv)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.XoaSinhVien", conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSv);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<KetQuaMon> LayDiem(string maSv)
        {
            var list = new List<KetQuaMon>();
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh("dbo.ChiTietSinhVien", conn))
            {
                cmd.Parameters.AddWithValue("@MaSv", maSv);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new KetQuaMon
                        {
                            MaMH = r["MaMH"].ToString(),
                            TenMH = r["TenMH"].ToString(),
                            SoTinChi = Convert.ToByte(r["SoTinChi"]),
                            ThuHoc = r["ThuHoc"].ToString(),
                            KhungGio = r["KhungGio"].ToString(),
                            TongKet = r["TongKet"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["TongKet"]),
                            DiemQuaTrinh = r["DiemQuaTrinh"] == DBNull.Value ? (byte?)null : Convert.ToByte(r["DiemQuaTrinh"]),
                            DiemGiuaKi = r["DiemGiuaKi"] == DBNull.Value ? (byte?)null : Convert.ToByte(r["DiemGiuaKi"]),
                            DiemCuoiKi = r["DiemCuoiKi"] == DBNull.Value ? (byte?)null : Convert.ToByte(r["DiemCuoiKi"])
                        });
                    }
                }
            }
            return list;
        }

        private static void ExecSv(string proc, SinhVien sv)
        {
            using (var conn = KetNoi.MoKetNoi())
            using (var cmd = KetNoi.TaoLenh(proc, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
                cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh.HasValue ? (object)sv.NgaySinh.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SoDienThoai", sv.SoDienThoai ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", sv.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaChi", sv.DiaChi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static SinhVien MapSinhVien(SqlDataReader r) => new SinhVien
        {
            MaSV = r["MaSV"].ToString(),
            HoTen = r["HoTen"].ToString(),
            NgaySinh = r["NgaySinh"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgaySinh"]),
            MaLop = r["MaLop"].ToString(),
            TenLop = r["TenLop"] == DBNull.Value ? null : r["TenLop"].ToString(),
            DiemTB = r["DiemTB"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["DiemTB"]),
            HocLuc = r["HocLuc"] == DBNull.Value ? null : r["HocLuc"].ToString()
        };

        private static SinhVien MapSinhVienFull(SqlDataReader r)
        {
            var sv = MapSinhVien(r);
            sv.GioiTinh = r["GioiTinh"] == DBNull.Value ? null : r["GioiTinh"].ToString();
            sv.SoDienThoai = r["SoDienThoai"] == DBNull.Value ? null : r["SoDienThoai"].ToString();
            sv.Email = r["Email"] == DBNull.Value ? null : r["Email"].ToString();
            sv.DiaChi = r["DiaChi"] == DBNull.Value ? null : r["DiaChi"].ToString();
            return sv;
        }
    }
}
