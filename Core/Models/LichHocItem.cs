namespace QLSV.Core.Models
{
    public class LichHocItem
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public byte SoTinChi { get; set; }
        public byte ThuTrongTuan { get; set; }
        public string ThuHoc { get; set; }
        public string GioBatDau { get; set; }
        public string GioKetThuc { get; set; }
        public string PhongHoc { get; set; }
        public string GiangVienPhuTrach { get; set; }

        public string KhungGio => $"{GioBatDau} - {GioKetThuc}";
    }
}
