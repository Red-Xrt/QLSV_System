using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLSV.Core.Helpers;

namespace QLSV.Core.Tests
{
    [TestClass]
    public class ValidationHelperTests
    {
        [TestMethod]
        public void MaSV_WithValidValue_ReturnsTrue()
        {
            var ok = ValidationHelper.MaSV("SV123", out var error);
            Assert.IsTrue(ok);
            Assert.IsNull(error);
        }

        [TestMethod]
        public void MaSV_WithInvalidChars_ReturnsFalse()
        {
            var ok = ValidationHelper.MaSV("SV-123", out var error);
            Assert.IsFalse(ok);
            StringAssert.Contains(error, "Mã sinh viên");
        }

        [TestMethod]
        public void MaMH_WithBlankValue_ReturnsFalse()
        {
            var ok = ValidationHelper.MaMH(" ", out var error);
            Assert.IsFalse(ok);
            StringAssert.Contains(error, "Mã môn học");
        }

        [TestMethod]
        public void Diem_WithValueOver10_ReturnsFalse()
        {
            var ok = ValidationHelper.Diem(11, out var error);
            Assert.IsFalse(ok);
            StringAssert.Contains(error, "0 đến 10");
        }

        [TestMethod]
        public void TryDiem_WithNonNumericValue_ReturnsFalse()
        {
            var ok = ValidationHelper.TryDiem("abc", out var value, out var error);
            Assert.IsFalse(ok);
            Assert.AreEqual(0, value);
            StringAssert.Contains(error, "số nguyên");
        }

        [TestMethod]
        public void Email_WithValidValue_ReturnsTrue()
        {
            var ok = ValidationHelper.Email("demo@student.edu", out var error);
            Assert.IsTrue(ok);
            Assert.IsNull(error);
        }

        [TestMethod]
        public void Email_WithInvalidValue_ReturnsFalse()
        {
            var ok = ValidationHelper.Email("demo@bad", out var error);
            Assert.IsFalse(ok);
            StringAssert.Contains(error, "không hợp lệ");
        }

        [TestMethod]
        public void GioHoc_WithEndBeforeStart_ReturnsFalse()
        {
            var ok = ValidationHelper.GioHoc(TimeSpan.FromHours(9), TimeSpan.FromHours(8), out var error);
            Assert.IsFalse(ok);
            StringAssert.Contains(error, "kết thúc");
        }
    }
}
