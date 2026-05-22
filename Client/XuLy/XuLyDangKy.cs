using System;
using System.Collections.Generic;
using Client.DuLieu;
using Client.Helpers;
using Client.Models;

namespace Client.XuLy
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
    }
}
