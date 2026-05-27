using System;
using System.Text.RegularExpressions;

namespace QLSV.Core.Helpers
{
    public static class ValidationHelper
    {
        public static bool Require(string value, string fieldName, out string error)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                error = $"{fieldName} không được để trống.";
                return false;
            }
            error = null;
            return true;
        }

        public static bool MaSV(string ma, out string error)
        {
            if (!Require(ma, "Mã sinh viên", out error)) return false;
            if (!Regex.IsMatch(ma.Trim(), @"^[A-Za-z0-9]{3,20}$"))
            {
                error = "Mã sinh viên chỉ gồm chữ và số (3-20 ký tự).";
                return false;
            }
            error = null;
            return true;
        }

        public static bool MaMH(string ma, out string error)
        {
            if (!Require(ma, "Mã môn học", out error)) return false;
            if (!Regex.IsMatch(ma.Trim(), @"^[A-Za-z0-9]{3,20}$"))
            {
                error = "Mã môn học chỉ gồm chữ và số (3-20 ký tự).";
                return false;
            }
            error = null;
            return true;
        }

        public static bool Diem(byte value, out string error)
        {
            if (value > 10)
            {
                error = "Điểm phải từ 0 đến 10.";
                return false;
            }
            error = null;
            return true;
        }

        public static bool TryDiem(string text, out byte value, out string error)
        {
            if (!byte.TryParse(text?.Trim(), out value))
            {
                error = "Điểm phải là số nguyên.";
                return false;
            }
            return Diem(value, out error);
        }

        public static bool Email(string email, out string error)
        {
            if (string.IsNullOrWhiteSpace(email)) { error = null; return true; }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                error = "Email không hợp lệ.";
                return false;
            }
            error = null;
            return true;
        }

        public static bool GioHoc(TimeSpan batDau, TimeSpan ketThuc, out string error)
        {
            if (ketThuc <= batDau)
            {
                error = "Giờ kết thúc phải sau giờ bắt đầu.";
                return false;
            }
            error = null;
            return true;
        }
    }
}
