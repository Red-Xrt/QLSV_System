namespace QLSV.Core.Models
{
    public class KetQuaMon
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public byte SoTinChi { get; set; }
        public string ThuHoc { get; set; }
        public string KhungGio { get; set; }
        public short NamHoc { get; set; }
        public byte HocKy { get; set; }
        public string HocKyText { get; set; }
        public bool KhoaDiem { get; set; }
        public decimal? TongKet { get; set; }
        public byte? DiemQuaTrinh { get; set; }
        public byte? DiemGiuaKi { get; set; }
        public byte? DiemCuoiKi { get; set; }

        public bool LaKyHienTai(short namHoc, byte hocKy) => NamHoc == namHoc && HocKy == hocKy;

        /// <summary>Đã nhập ít nhất một thành phần điểm (không tính TongKet tự tính từ trigger).</summary>
        public bool DaCoDiem() =>
            DiemQuaTrinh.HasValue || DiemGiuaKi.HasValue || DiemCuoiKi.HasValue;
    }
}
