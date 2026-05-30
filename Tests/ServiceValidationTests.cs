using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLSV.Core.Helpers;
using QLSV.Core.Models;
using QLSV.Core.Services;

namespace QLSV.Core.Tests
{
    [TestClass]
    public class ServiceValidationTests
    {
        [TestCleanup]
        public void Cleanup()
        {
            SessionContext.Clear();
        }

        [TestMethod]
        public void XuLyDiem_TinhTong_ComputesWeightedAverage()
        {
            var svc = new XuLyDiem();
            var tong = svc.TinhTong(10, 8, 6);
            Assert.AreEqual(7.4m, tong);
        }

        [TestMethod]
        public void XuLyDiem_CapNhat_WithInvalidMaSV_Throws()
        {
            var svc = new XuLyDiem();
            var ex = Catch<ArgumentException>(() => svc.CapNhat("?", "MH001", 8, 8, 8));
            StringAssert.Contains(ex.Message, "Mã sinh viên");
        }

        [TestMethod]
        public void KetQuaMon_DaCoDiem_OnlyComponentScores()
        {
            var kq = new KetQuaMon { TongKet = 0m };
            Assert.IsFalse(kq.DaCoDiem());

            kq.DiemCuoiKi = 0;
            Assert.IsTrue(kq.DaCoDiem(), "Điểm 0 thật vẫn được coi là đã nhập.");
        }

        [TestMethod]
        public void XuLySinhVien_LayDiem_WithInvalidMaSV_Throws()
        {
            var svc = new XuLySinhVien();
            var ex = Catch<ArgumentException>(() => svc.LayDiem("bad-id"));
            StringAssert.Contains(ex.Message, "Mã sinh viên");
        }

        [TestMethod]
        public void XuLyDangKy_DangKyHangLoat_WithNullList_Throws()
        {
            var svc = new XuLyDangKy();
            var ex = Catch<ArgumentException>(() => svc.DangKyHangLoat("MH001", null));
            StringAssert.Contains(ex.Message, "Danh sách sinh viên");
        }

        [TestMethod]
        public void XuLySinhVien_Them_WithNullStudent_Throws()
        {
            var svc = new XuLySinhVien();
            Catch<ArgumentNullException>(() => svc.Them(null));
        }

        [TestMethod]
        public void XuLyMonHoc_Them_WithNullMonHoc_Throws()
        {
            var svc = new XuLyMonHoc();
            Catch<ArgumentNullException>(() => svc.Them(null, TimeSpan.FromHours(7), TimeSpan.FromHours(9)));
        }

        [TestMethod]
        public void XuLyMonHoc_Them_WithInvalidThuTrongTuan_Throws()
        {
            var svc = new XuLyMonHoc();
            var mh = new MonHoc { MaMH = "MH001", TenMH = "Lap trinh", SoTinChi = 3, ThuTrongTuan = 1 };
            var ex = Catch<ArgumentException>(() => svc.Them(mh, TimeSpan.FromHours(7), TimeSpan.FromHours(9)));
            StringAssert.Contains(ex.Message, "thứ trong tuần");
        }

        [TestMethod]
        public void XuLyLop_Them_WithNullLop_Throws()
        {
            var svc = new XuLyLop();
            Catch<ArgumentNullException>(() => svc.Them(null));
        }

        [TestMethod]
        public void XuLyLop_Them_WithOverlengthMaLop_Throws()
        {
            var svc = new XuLyLop();
            var lop = new LopHoc { MaLop = "ABCDEFGHIJKLMNOPQRSTU", TenLop = "CNTT K1" };
            var ex = Catch<ArgumentException>(() => svc.Them(lop));
            StringAssert.Contains(ex.Message, "tối đa 20");
        }

        [TestMethod]
        public void XuLyDangNhap_DoiMatKhau_WithoutSession_Throws()
        {
            var svc = new XuLyDangNhap();
            var ex = Catch<InvalidOperationException>(() => svc.DoiMatKhau("old", "newpass", "newpass"));
            StringAssert.Contains(ex.Message, "Phiên đăng nhập");
        }

        private static T Catch<T>(Action action) where T : Exception
        {
            try
            {
                action();
            }
            catch (T ex)
            {
                return ex;
            }

            Assert.Fail("Expected exception: " + typeof(T).Name);
            return null;
        }
    }
}
