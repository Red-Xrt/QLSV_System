using System.Collections.Generic;
using Client.DuLieu;
using Client.Models;

namespace Client.XuLy
{
    public class XuLyXepHang
    {
        private readonly DocXepHang _db = new DocXepHang();

        public List<XepHangItem> LayBaoCao(string maLop, string hocLuc, string cheDo) =>
            _db.LayBaoCao(maLop, hocLuc, cheDo);

        public void ThongKe(string maLop, out int tong, out int hocBong, out int canhBao) =>
            _db.ThongKe(maLop, out tong, out hocBong, out canhBao);
    }
}
