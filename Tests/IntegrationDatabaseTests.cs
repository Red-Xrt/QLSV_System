using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLSV.Core.Data;
using QLSV.Core.Helpers;
using QLSV.Core.Models;
using QLSV.Core.Services;

namespace QLSV.Core.Tests
{
    [TestClass]
    public class IntegrationDatabaseTests
    {
        [TestInitialize]
        public void Init()
        {
            SessionContext.Clear();
            EnsureDatabaseReady();
        }

        [TestCleanup]
        public void Cleanup()
        {
            SessionContext.Clear();
        }

        [TestMethod]
        public void DangNhap_WithSeedAccount_ShouldSucceed()
        {
            var svc = new XuLyDangNhap();
            var tk = svc.DangNhap("admin", "123456");
            Assert.IsNotNull(tk);
            Assert.IsTrue(SessionContext.IsLoggedIn);
        }

        [TestMethod]
        public void DangNhap_WithWrongPassword_ShouldThrow()
        {
            var svc = new XuLyDangNhap();
            var ex = Catch<ArgumentException>(() => svc.DangNhap("admin", "wrong-password"));
            StringAssert.Contains(ex.Message, "không đúng");
        }

        [TestMethod]
        public void LopHoc_CreateUpdateDelete_ShouldWork()
        {
            var svc = new XuLyLop();
            var id = "ITESTL" + DateTime.Now.ToString("HHmmss");
            try
            {
                svc.Them(new LopHoc { MaLop = id, TenLop = "Lop test integration" });
                var all = svc.LayDanhSach();
                Assert.IsTrue(all.Exists(x => x.MaLop == id));

                svc.CapNhat(new LopHoc { MaLop = id, TenLop = "Lop test integration updated" });
                var afterUpdate = svc.LayDanhSach().Find(x => x.MaLop == id);
                Assert.IsNotNull(afterUpdate);
                Assert.AreEqual("Lop test integration updated", afterUpdate.TenLop);
            }
            finally
            {
                TryDeleteLop(id);
            }
        }

        [TestMethod]
        public void SinhVien_CreateUpdateDelete_ShouldWork()
        {
            var lopSvc = new XuLyLop();
            var svSvc = new XuLySinhVien();
            var lopId = "ITESTL" + DateTime.Now.ToString("HHmmss");
            var svId = "ITSV" + DateTime.Now.ToString("HHmmss");

            try
            {
                lopSvc.Them(new LopHoc { MaLop = lopId, TenLop = "Lop cho sinh vien test" });
                svSvc.Them(new SinhVien
                {
                    MaSV = svId,
                    HoTen = "Sinh vien test",
                    NgaySinh = new DateTime(2000, 1, 1),
                    GioiTinh = "Nam",
                    Email = "it.sv@test.edu",
                    MaLop = lopId
                });

                var sv = svSvc.LayChiTiet(svId);
                Assert.IsNotNull(sv);
                Assert.AreEqual("Sinh vien test", sv.HoTen);

                sv.HoTen = "Sinh vien test updated";
                svSvc.CapNhat(sv);

                var svUpdated = svSvc.LayChiTiet(svId);
                Assert.IsNotNull(svUpdated);
                Assert.AreEqual("Sinh vien test updated", svUpdated.HoTen);
            }
            finally
            {
                TryDeleteSinhVien(svId);
                TryDeleteLop(lopId);
            }
        }

        [TestMethod]
        public void MonHoc_CreateUpdateDelete_ShouldWork()
        {
            var svc = new XuLyMonHoc();
            var id = "ITMH" + DateTime.Now.ToString("HHmmss");
            try
            {
                var mh = new MonHoc
                {
                    MaMH = id,
                    TenMH = "Mon hoc integration",
                    SoTinChi = 2,
                    ThuTrongTuan = 7,
                    GiangVienPhuTrach = "GV Test",
                    PhongHoc = "PTEST"
                };
                svc.Them(mh, TimeSpan.FromHours(18), TimeSpan.FromHours(19));

                var detail = svc.LayChiTiet(id);
                Assert.IsNotNull(detail);
                Assert.AreEqual("Mon hoc integration", detail.TenMH);

                detail.TenMH = "Mon hoc integration updated";
                svc.CapNhat(detail, TimeSpan.FromHours(18), TimeSpan.FromHours(20));
                var afterUpdate = svc.LayChiTiet(id);
                Assert.IsNotNull(afterUpdate);
                Assert.AreEqual("Mon hoc integration updated", afterUpdate.TenMH);
            }
            finally
            {
                TryDeleteMonHoc(id);
            }
        }

        [TestMethod]
        public void DangKy_Then_HuyDangKy_ShouldWork()
        {
            var monSvc = new XuLyMonHoc();
            var dkSvc = new XuLyDangKy();
            var mhId = "ITMH" + DateTime.Now.ToString("HHmmss");
            const string maSv = "SV001";

            try
            {
                monSvc.Them(new MonHoc
                {
                    MaMH = mhId,
                    TenMH = "Mon hoc dang ky test",
                    SoTinChi = 2,
                    ThuTrongTuan = 8,
                    GiangVienPhuTrach = "GV DK",
                    PhongHoc = "PDK"
                }, TimeSpan.FromHours(18), TimeSpan.FromHours(19));

                var dk = dkSvc.DangKyHangLoat(mhId, new[] { maSv });
                Assert.AreEqual(1, dk.Count);
                Assert.IsTrue(dk[0].ThanhCong, dk[0].ThongBao);

                var huy = dkSvc.HuyDangKy(maSv, mhId);
                Assert.IsTrue(huy.ThanhCong, huy.ThongBao);
            }
            finally
            {
                TryDeleteMonHoc(mhId);
            }
        }

        [TestMethod]
        public void CapNhatDiem_ShouldUpdateTongKetAndHocLuc()
        {
            var lopSvc = new XuLyLop();
            var svSvc = new XuLySinhVien();
            var mhSvc = new XuLyMonHoc();
            var diemSvc = new XuLyDiem();

            var lopId = "ITESTL" + DateTime.Now.ToString("HHmmss");
            var svId = "ITSV" + DateTime.Now.ToString("HHmmss");
            var mhId = "ITMH" + DateTime.Now.ToString("HHmmss");

            try
            {
                lopSvc.Them(new LopHoc { MaLop = lopId, TenLop = "Lop diem test" });
                svSvc.Them(new SinhVien
                {
                    MaSV = svId,
                    HoTen = "SV Diem test",
                    NgaySinh = new DateTime(2000, 1, 1),
                    GioiTinh = "Nam",
                    Email = "sv.diem@test.edu",
                    MaLop = lopId
                });
                mhSvc.Them(new MonHoc
                {
                    MaMH = mhId,
                    TenMH = "Mon diem test",
                    SoTinChi = 3,
                    ThuTrongTuan = 8,
                    GiangVienPhuTrach = "GV Diem",
                    PhongHoc = "PDIEM"
                }, TimeSpan.FromHours(19), TimeSpan.FromHours(20));

                diemSvc.CapNhat(svId, mhId, 8, 8, 8);
                var sv = svSvc.LayChiTiet(svId);
                Assert.IsNotNull(sv);
                Assert.IsTrue(sv.DiemTB.HasValue);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(sv.HocLuc));
            }
            finally
            {
                TryDeleteSinhVien(svId);
                TryDeleteMonHoc(mhId);
                TryDeleteLop(lopId);
            }
        }

        [TestMethod]
        public void LichHoc_SeedStudent_ShouldReturnRows()
        {
            var svc = new XuLyLichHoc();
            var lich = svc.LayLichTuan("SV001");
            Assert.IsTrue(lich.Count > 0);
        }

        [TestMethod]
        public void XepHang_ThongKe_ShouldReturnNonNegativeValues()
        {
            var svc = new XuLyXepHang();
            svc.ThongKe(null, out var tong, out var hocBong, out var canhBao);
            Assert.IsTrue(tong >= 0);
            Assert.IsTrue(hocBong >= 0);
            Assert.IsTrue(canhBao >= 0);
        }

        private static void EnsureDatabaseReady()
        {
            try
            {
                using (var conn = KetNoi.MoKetNoi())
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT COUNT(1) FROM dbo.SinhVien";
                    cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Assert.Inconclusive("Database chưa sẵn sàng để chạy integration test: " + Err.GiaiThich(ex));
            }
        }

        private static void TryDeleteSinhVien(string maSv)
        {
            if (string.IsNullOrWhiteSpace(maSv)) return;
            ExecuteIgnoreError("DELETE FROM dbo.DiemThi WHERE MaSV = @id; DELETE FROM dbo.SinhVien WHERE MaSV = @id;", maSv);
        }

        private static void TryDeleteMonHoc(string maMh)
        {
            if (string.IsNullOrWhiteSpace(maMh)) return;
            ExecuteIgnoreError("DELETE FROM dbo.DiemThi WHERE MaMH = @id; DELETE FROM dbo.MonHoc WHERE MaMH = @id;", maMh);
        }

        private static void TryDeleteLop(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop)) return;
            ExecuteIgnoreError("DELETE FROM dbo.LopHoc WHERE MaLop = @id;", maLop);
        }

        private static void ExecuteIgnoreError(string sql, string id)
        {
            try
            {
                using (var conn = KetNoi.MoKetNoi())
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                // best-effort cleanup for integration tests
            }
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
