namespace QLSV.Core.Models
{
    public class HocKyHienTai
    {
        public short NamHoc { get; set; }
        public byte HocKy { get; set; }
        public bool KhoaDiem { get; set; }
        public string HocKyText => NamHoc > 0 ? $"{NamHoc} - HK{HocKy}" : "Chưa cấu hình";
    }
}
