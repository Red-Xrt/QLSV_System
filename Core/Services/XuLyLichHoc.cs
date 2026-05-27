using System;
using System.Collections.Generic;
using QLSV.Core.Data;
using QLSV.Core.Helpers;
using QLSV.Core.Models;

namespace QLSV.Core.Services
{
    public class XuLyLichHoc
    {
        private readonly DocLichHoc _db = new DocLichHoc();

        public List<LichHocItem> LayLichTuan(string maSv)
        {
            if (!ValidationHelper.MaSV(maSv, out var err))
                throw new ArgumentException(err);
            return _db.LayTheoSinhVien(maSv.Trim());
        }
    }
}
