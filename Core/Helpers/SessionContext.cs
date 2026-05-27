using QLSV.Core.Models;

namespace QLSV.Core.Helpers
{
    public static class SessionContext
    {
        public static TaiKhoan CurrentUser { get; set; }

        public static void Clear() => CurrentUser = null;

        public static bool IsLoggedIn => CurrentUser != null;
    }
}
