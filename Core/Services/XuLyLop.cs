using System;
using System.Collections.Generic;
using QLSV.Core.Data;
using QLSV.Core.Helpers;
using QLSV.Core.Models;

namespace QLSV.Core.Services
{
    public class XuLyLop
    {
        private readonly DocLop _db = new DocLop();

        public List<LopHoc> LayDanhSach() => _db.LayDanhSach();

        public void Them(LopHoc lop)
        {
            KiemTra(lop);
            _db.Them(lop);
        }

        public void CapNhat(LopHoc lop)
        {
            KiemTra(lop);
            _db.CapNhat(lop);
        }

        public void Xoa(string maLop)
        {
            if (!ValidationHelper.Require(maLop, "Mã lớp", out var err))
                throw new ArgumentException(err);
            _db.Xoa(maLop.Trim());
        }

        private static void KiemTra(LopHoc lop)
        {
            if (lop == null) throw new ArgumentNullException(nameof(lop));
            if (!ValidationHelper.Require(lop.MaLop, "Mã lớp", out var err))
                throw new ArgumentException(err);
            if (!ValidationHelper.Require(lop.TenLop, "Tên lớp", out err))
                throw new ArgumentException(err);
            lop.MaLop = lop.MaLop.Trim();
            lop.TenLop = lop.TenLop.Trim();
            if (lop.MaLop.Length > 20)
                throw new ArgumentException("Mã lớp tối đa 20 ký tự.");
        }
    }
}
