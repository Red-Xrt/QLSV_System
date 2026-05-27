namespace QLSV.Core.Models
{
    public class DangKyKetQua
    {
        public string MaSV { get; set; }
        public string MaMH { get; set; }
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }
        public string MaHienThi => MaMH ?? MaSV;
    }
}
