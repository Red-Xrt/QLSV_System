using System.Collections.Generic;
using Client.DuLieu;
using Client.Models;

namespace Client.XuLy
{
    public class XuLyLop
    {
        private readonly DocLop _db = new DocLop();
        public List<LopHoc> LayDanhSach() => _db.LayDanhSach();
    }
}
