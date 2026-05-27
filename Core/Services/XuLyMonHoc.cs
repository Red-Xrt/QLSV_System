using System;
using System.Collections.Generic;
using System.Linq;
using QLSV.Core.Data;
using QLSV.Core.Helpers;
using QLSV.Core.Models;

namespace QLSV.Core.Services
{
    public class XuLyMonHoc
    {
        private readonly DocMonHoc _db = new DocMonHoc();

        public List<MonHoc> LayDanhSach(string tuKhoa = null) => _db.LayDanhSach(tuKhoa);

        public MonHoc LayChiTiet(string maMh)
        {
            if (!ValidationHelper.MaMH(maMh, out var err)) throw new ArgumentException(err);
            return _db.LayChiTiet(maMh.Trim());
        }

        public void Them(MonHoc mh, TimeSpan gioBatDau, TimeSpan gioKetThuc)
        {
            KiemTraMon(mh, gioBatDau, gioKetThuc);
            _db.Them(mh, gioBatDau, gioKetThuc);
        }

        public void CapNhat(MonHoc mh, TimeSpan gioBatDau, TimeSpan gioKetThuc)
        {
            KiemTraMon(mh, gioBatDau, gioKetThuc);
            _db.CapNhat(mh, gioBatDau, gioKetThuc);
        }

        public void Xoa(string maMh)
        {
            if (!ValidationHelper.MaMH(maMh, out var err)) throw new ArgumentException(err);
            _db.Xoa(maMh.Trim());
        }

        public List<DangKyKetQua> CapNhatHangLoat(
            IReadOnlyList<string> danhSachMa,
            string phongHoc,
            bool doiPhong,
            string giangVien,
            bool doiGiangVien,
            byte? thuTrongTuan,
            TimeSpan? gioBatDau,
            TimeSpan? gioKetThuc,
            bool doiLich)
        {
            if (danhSachMa == null || danhSachMa.Count == 0)
                throw new ArgumentException("Chưa có môn học để cập nhật.");
            if (!doiPhong && !doiGiangVien && !doiLich)
                throw new ArgumentException("Chọn ít nhất một thông tin cần đổi.");
            if (doiLich)
            {
                if (!thuTrongTuan.HasValue || thuTrongTuan < 2 || thuTrongTuan > 8)
                    throw new ArgumentException("Chọn thứ trong tuần hợp lệ.");
                if (!gioBatDau.HasValue || !gioKetThuc.HasValue)
                    throw new ArgumentException("Chọn giờ bắt đầu và kết thúc.");
                if (!ValidationHelper.GioHoc(gioBatDau.Value, gioKetThuc.Value, out var errGio))
                    throw new ArgumentException(errGio);
            }

            var ketQua = new List<DangKyKetQua>();
            foreach (var ma in danhSachMa.Distinct(StringComparer.OrdinalIgnoreCase))
            {
                var item = new DangKyKetQua { MaMH = ma };
                try
                {
                    var mh = LayChiTiet(ma);
                    if (mh == null)
                    {
                        item.ThanhCong = false;
                        item.ThongBao = "Không tìm thấy môn học.";
                        ketQua.Add(item);
                        continue;
                    }

                    if (doiPhong) mh.PhongHoc = phongHoc?.Trim();
                    if (doiGiangVien) mh.GiangVienPhuTrach = giangVien?.Trim();
                    if (doiLich)
                    {
                        mh.ThuTrongTuan = thuTrongTuan.Value;
                    }

                    var batDau = doiLich ? gioBatDau.Value : ParseGio(mh.GioBatDau);
                    var ketThuc = doiLich ? gioKetThuc.Value : ParseGio(mh.GioKetThuc);
                    CapNhat(mh, batDau, ketThuc);
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

        private static void KiemTraMon(MonHoc mh, TimeSpan gioBatDau, TimeSpan gioKetThuc)
        {
            if (!ValidationHelper.MaMH(mh.MaMH, out var err)) throw new ArgumentException(err);
            if (!ValidationHelper.Require(mh.TenMH, "Tên môn học", out err)) throw new ArgumentException(err);
            if (mh.SoTinChi < 1 || mh.SoTinChi > 10) throw new ArgumentException("Số tín chỉ từ 1 đến 10.");
            if (mh.ThuTrongTuan < 2 || mh.ThuTrongTuan > 8) throw new ArgumentException("Chọn thứ trong tuần hợp lệ.");
            if (!ValidationHelper.GioHoc(gioBatDau, gioKetThuc, out err)) throw new ArgumentException(err);
        }

        private static TimeSpan ParseGio(string gio)
        {
            if (TimeSpan.TryParse(gio, out var t)) return t;
            return TimeSpan.FromHours(7);
        }
    }
}
