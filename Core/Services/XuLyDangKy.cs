using System;
using System.Collections.Generic;
using QLSV.Core.Data;
using QLSV.Core.Helpers;
using QLSV.Core.Models;

namespace QLSV.Core.Services
{
    public class XuLyDangKy
    {
        private readonly DocDangKy _db = new DocDangKy();

        public List<DangKyKetQua> DangKyHangLoat(string maMh, IEnumerable<string> dsMaSv)
        {
            if (!ValidationHelper.MaMH(maMh, out var err)) throw new ArgumentException(err);
            if (dsMaSv == null) throw new ArgumentException("Danh sách sinh viên không được để trống.");

            var ketQua = new List<DangKyKetQua>();
            foreach (var ma in dsMaSv)
            {
                if (string.IsNullOrWhiteSpace(ma)) continue;

                var maSv = ma.Trim();
                var item = new DangKyKetQua { MaSV = maSv, MaMH = maMh.Trim() };
                try
                {
                    if (!ValidationHelper.MaSV(maSv, out err))
                    {
                        item.ThanhCong = false;
                        item.ThongBao = err;
                    }
                    else
                    {
                        item = _db.DangKy(maSv, maMh.Trim());
                    }
                }
                catch (Exception ex)
                {
                    item.ThanhCong = false;
                    item.ThongBao = KetNoi.BaoLoi(ex);
                }

                ketQua.Add(item);
            }
            return ketQua;
        }

        public DangKyKetQua HuyDangKy(string maSv, string maMh)
        {
            if (!ValidationHelper.MaSV(maSv, out var err)) throw new ArgumentException(err);
            if (!ValidationHelper.MaMH(maMh, out err)) throw new ArgumentException(err);
            return _db.HuyDangKy(maSv.Trim(), maMh.Trim());
        }
    }
}
