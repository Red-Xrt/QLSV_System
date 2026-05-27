using System;
using System.Collections.Generic;
using System.Linq;
using QLSV.Core.Data;
using QLSV.Core.Helpers;
using QLSV.Core.Models;

namespace QLSV.Core.Services
{
    public class XuLySinhVien
    {
        private readonly DocSinhVien _db = new DocSinhVien();

        public List<SinhVien> TimKiem(string tuKhoa, string maLop) => _db.TimKiem(tuKhoa, maLop);

        public SinhVien LayChiTiet(string maSv)
        {
            if (!ValidationHelper.MaSV(maSv, out var err)) throw new ArgumentException(err);
            return _db.LayThongTin(maSv.Trim());
        }

        public List<KetQuaMon> LayDiem(string maSv) => _db.LayDiem(maSv?.Trim());

        public void Them(SinhVien sv) { KiemTra(sv); _db.Them(sv); }
        public void CapNhat(SinhVien sv) { KiemTra(sv); _db.CapNhat(sv); }

        public void Xoa(string maSv)
        {
            if (!ValidationHelper.MaSV(maSv, out var err)) throw new ArgumentException(err);
            _db.Xoa(maSv.Trim());
        }

        /// <summary>Cập nhật lớp / giới tính cho nhiều SV (giữ nguyên các trường khác).</summary>
        public List<DangKyKetQua> CapNhatHangLoat(
            IReadOnlyList<string> danhSachMa,
            string maLopMoi,
            bool doiLop,
            string gioiTinhMoi,
            bool doiGioiTinh)
        {
            if (danhSachMa == null || danhSachMa.Count == 0)
                throw new ArgumentException("Chưa có sinh viên để cập nhật.");
            if (!doiLop && !doiGioiTinh)
                throw new ArgumentException("Chọn ít nhất một thông tin cần đổi.");

            if (doiLop && !ValidationHelper.Require(maLopMoi, "Lớp học", out var errLop))
                throw new ArgumentException(errLop);

            var ketQua = new List<DangKyKetQua>();
            foreach (var ma in danhSachMa.Distinct(StringComparer.OrdinalIgnoreCase))
            {
                var item = new DangKyKetQua { MaSV = ma };
                try
                {
                    var sv = LayChiTiet(ma);
                    if (sv == null)
                    {
                        item.ThanhCong = false;
                        item.ThongBao = "Không tìm thấy sinh viên.";
                        ketQua.Add(item);
                        continue;
                    }

                    if (doiLop) sv.MaLop = maLopMoi;
                    if (doiGioiTinh) sv.GioiTinh = gioiTinhMoi;

                    CapNhat(sv);
                    item.ThanhCong = true;
                    item.ThongBao = "OK";
                }
                catch (Exception ex)
                {
                    item.ThanhCong = false;
                    item.ThongBao = ex is ArgumentException ? ex.Message : KetNoi.BaoLoi(ex);
                }
                ketQua.Add(item);
            }
            return ketQua;
        }

        private static void KiemTra(SinhVien sv)
        {
            if (!ValidationHelper.MaSV(sv.MaSV, out var err)) throw new ArgumentException(err);
            if (!ValidationHelper.Require(sv.HoTen, "Họ tên", out err)) throw new ArgumentException(err);
            if (!ValidationHelper.Require(sv.MaLop, "Lớp học", out err)) throw new ArgumentException(err);
            if (!ValidationHelper.Email(sv.Email, out err)) throw new ArgumentException(err);
            if (sv.NgaySinh.HasValue && sv.NgaySinh.Value > DateTime.Today.AddYears(-15))
                throw new ArgumentException("Ngày sinh không hợp lệ.");
        }
    }
}
