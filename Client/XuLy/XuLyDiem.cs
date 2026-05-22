using System;
using Client.DuLieu;
using Client.Helpers;

namespace Client.XuLy
{
    public class XuLyDiem
    {
        private readonly DocDiem _db = new DocDiem();

        public void CapNhat(string maSv, string maMh, byte qt, byte gk, byte ck)
        {
            if (!ValidationHelper.MaSV(maSv, out var err)) throw new ArgumentException(err);
            if (!ValidationHelper.MaMH(maMh, out err)) throw new ArgumentException(err);
            if (!ValidationHelper.Diem(qt, out err)) throw new ArgumentException(err);
            if (!ValidationHelper.Diem(gk, out err)) throw new ArgumentException(err);
            if (!ValidationHelper.Diem(ck, out err)) throw new ArgumentException(err);
            _db.CapNhat(maSv.Trim(), maMh.Trim(), qt, gk, ck);
        }

        public decimal TinhTong(byte qt, byte gk, byte ck) =>
            Math.Round(qt * 0.2m + gk * 0.3m + ck * 0.5m, 1);
    }
}
