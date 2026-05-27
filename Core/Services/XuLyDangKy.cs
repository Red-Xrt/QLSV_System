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
            var ketQua = new List<DangKyKetQua>();
            foreach (var ma in dsMaSv)
            {
                if (string.IsNullOrWhiteSpace(ma)) continue;
                ketQua.Add(_db.DangKy(ma.Trim(), maMh.Trim()));
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
