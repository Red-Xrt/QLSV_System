namespace QLSV.Core.Models
{
    public class TaiKhoan
    {
        /// <summary>Tên đăng nhập gốc (chỉ giữ trong phiên sau khi đăng nhập).</summary>
        public string TenDangNhap { get; set; }
        public string TenDangNhapHash { get; set; }
        public string MatKhauHash { get; set; }
        public string HoTen { get; set; }
        public string QuyenHan { get; set; }
        public bool TrangThai { get; set; }
    }
}
