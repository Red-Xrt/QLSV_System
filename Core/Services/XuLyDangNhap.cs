using System;
using QLSV.Core.Data;
using QLSV.Core.Helpers;
using QLSV.Core.Models;

namespace QLSV.Core.Services
{
    public class XuLyDangNhap
    {
        private readonly DocTaiKhoan _db = new DocTaiKhoan();

        public TaiKhoan DangNhap(string user, string pass)
        {
            if (!ValidationHelper.Require(user, "Tên đăng nhập", out var err))
                throw new ArgumentException(err);
            if (!ValidationHelper.Require(pass, "Mật khẩu", out err))
                throw new ArgumentException(err);

            KetNoi.KiemTraKetNoi();

            var tk = _db.LayTheoTenHash(CryptoHelper.HashUsername(user));
            if (tk == null || !CryptoHelper.VerifyPassword(pass, tk.MatKhauHash))
                throw new ArgumentException("Tên đăng nhập hoặc mật khẩu không đúng.");

            if (!tk.TrangThai)
                throw new ArgumentException("Tài khoản đang bị khóa, liên hệ quản trị.");

            tk.TenDangNhap = user.Trim();
            SessionContext.CurrentUser = tk;
            return tk;
        }

        public void DangXuat() => SessionContext.Clear();

        public void DoiMatKhau(string matKhauCu, string matKhauMoi, string xacNhan)
        {
            if (!SessionContext.IsLoggedIn)
                throw new InvalidOperationException("Phiên đăng nhập đã hết. Đăng nhập lại.");
            if (!ValidationHelper.Require(matKhauCu, "Mật khẩu cũ", out var err))
                throw new ArgumentException(err);
            if (!ValidationHelper.Require(matKhauMoi, "Mật khẩu mới", out err))
                throw new ArgumentException(err);
            if (matKhauMoi.Length < 6)
                throw new ArgumentException("Mật khẩu mới tối thiểu 6 ký tự.");
            if (matKhauMoi != xacNhan)
                throw new ArgumentException("Mật khẩu xác nhận không khớp.");

            var user = SessionContext.CurrentUser;
            if (!CryptoHelper.VerifyPassword(matKhauCu, user.MatKhauHash))
                throw new ArgumentException("Mật khẩu cũ không đúng.");

            _db.DoiMatKhau(user.TenDangNhapHash, CryptoHelper.HashPassword(matKhauMoi));
            user.MatKhauHash = CryptoHelper.HashPassword(matKhauMoi);
        }
    }
}
