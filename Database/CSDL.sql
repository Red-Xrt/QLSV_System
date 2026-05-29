/*
  QLSV_System - CSDL.sql
  Single script for SQL Server: create database, schema, seed, functions, views, triggers, procedures.
  Safe to re-run.
*/

IF DB_ID(N'QLSV_MRBEAST') IS NULL
    CREATE DATABASE QLSV_MRBEAST;
GO


USE QLSV_MRBEAST;
GO


/* --- Safe re-run: drop dependent objects --- */
IF OBJECT_ID(N'dbo.trg_DiemThi_TinhTongKet', N'TR') IS NOT NULL DROP TRIGGER dbo.trg_DiemThi_TinhTongKet;
IF OBJECT_ID(N'dbo.trg_MonHoc_ValidateLich', N'TR') IS NOT NULL DROP TRIGGER dbo.trg_MonHoc_ValidateLich;
GO

IF OBJECT_ID(N'dbo.LayTaiKhoanDangNhap', N'P') IS NOT NULL DROP PROCEDURE dbo.LayTaiKhoanDangNhap;
IF OBJECT_ID(N'dbo.TimKiemSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.TimKiemSinhVien;
IF OBJECT_ID(N'dbo.ThemSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.ThemSinhVien;
IF OBJECT_ID(N'dbo.CapNhatSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.CapNhatSinhVien;
IF OBJECT_ID(N'dbo.XoaSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.XoaSinhVien;
IF OBJECT_ID(N'dbo.ThongTinSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.ThongTinSinhVien;
IF OBJECT_ID(N'dbo.ChiTietSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.ChiTietSinhVien;
IF OBJECT_ID(N'dbo.CapNhatDiem', N'P') IS NOT NULL DROP PROCEDURE dbo.CapNhatDiem;
IF OBJECT_ID(N'dbo.LayDanhSachMonHoc', N'P') IS NOT NULL DROP PROCEDURE dbo.LayDanhSachMonHoc;
IF OBJECT_ID(N'dbo.ChiTietMonHoc', N'P') IS NOT NULL DROP PROCEDURE dbo.ChiTietMonHoc;
IF OBJECT_ID(N'dbo.CapNhatMonHoc', N'P') IS NOT NULL DROP PROCEDURE dbo.CapNhatMonHoc;
IF OBJECT_ID(N'dbo.XoaMonHoc', N'P') IS NOT NULL DROP PROCEDURE dbo.XoaMonHoc;
IF OBJECT_ID(N'dbo.DoiMatKhau', N'P') IS NOT NULL DROP PROCEDURE dbo.DoiMatKhau;
IF OBJECT_ID(N'dbo.ThemMonHoc', N'P') IS NOT NULL DROP PROCEDURE dbo.ThemMonHoc;
IF OBJECT_ID(N'dbo.DangKyMonHocChoSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.DangKyMonHocChoSinhVien;
IF OBJECT_ID(N'dbo.LayDanhSachLop', N'P') IS NOT NULL DROP PROCEDURE dbo.LayDanhSachLop;
IF OBJECT_ID(N'dbo.ThemLop', N'P') IS NOT NULL DROP PROCEDURE dbo.ThemLop;
IF OBJECT_ID(N'dbo.CapNhatLop', N'P') IS NOT NULL DROP PROCEDURE dbo.CapNhatLop;
IF OBJECT_ID(N'dbo.XoaLop', N'P') IS NOT NULL DROP PROCEDURE dbo.XoaLop;
IF OBJECT_ID(N'dbo.HuyDangKyMonHoc', N'P') IS NOT NULL DROP PROCEDURE dbo.HuyDangKyMonHoc;
IF OBJECT_ID(N'dbo.LayLichHocSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.LayLichHocSinhVien;
IF OBJECT_ID(N'dbo.ThemLop', N'P') IS NOT NULL DROP PROCEDURE dbo.ThemLop;
IF OBJECT_ID(N'dbo.CapNhatLop', N'P') IS NOT NULL DROP PROCEDURE dbo.CapNhatLop;
IF OBJECT_ID(N'dbo.XoaLop', N'P') IS NOT NULL DROP PROCEDURE dbo.XoaLop;
IF OBJECT_ID(N'dbo.HuyDangKyMonHoc', N'P') IS NOT NULL DROP PROCEDURE dbo.HuyDangKyMonHoc;
IF OBJECT_ID(N'dbo.LayLichHocSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.LayLichHocSinhVien;
IF OBJECT_ID(N'dbo.LayBaoCaoXepHang', N'P') IS NOT NULL DROP PROCEDURE dbo.LayBaoCaoXepHang;
IF OBJECT_ID(N'dbo.ThongKeBaoCao', N'P') IS NOT NULL DROP PROCEDURE dbo.ThongKeBaoCao;
IF OBJECT_ID(N'dbo.LayDanhSachSinhVien', N'P') IS NOT NULL DROP PROCEDURE dbo.LayDanhSachSinhVien;
IF OBJECT_ID(N'dbo.DemSinhVienGioi', N'P') IS NOT NULL DROP PROCEDURE dbo.DemSinhVienGioi;
IF OBJECT_ID(N'dbo.TinhDiemTrungBinh', N'P') IS NOT NULL DROP PROCEDURE dbo.TinhDiemTrungBinh;
GO

IF OBJECT_ID(N'dbo.vw_BangXepHang', N'V') IS NOT NULL DROP VIEW dbo.vw_BangXepHang;
IF OBJECT_ID(N'dbo.vw_MonHocChiTiet', N'V') IS NOT NULL DROP VIEW dbo.vw_MonHocChiTiet;
IF OBJECT_ID(N'dbo.vw_LichHocSinhVien', N'V') IS NOT NULL DROP VIEW dbo.vw_LichHocSinhVien;
IF OBJECT_ID(N'dbo.vw_BaoCaoThanhTich', N'V') IS NOT NULL DROP VIEW dbo.vw_BaoCaoThanhTich;
GO

IF OBJECT_ID(N'dbo.fn_TinhDiemTongKet', N'FN') IS NOT NULL DROP FUNCTION dbo.fn_TinhDiemTongKet;
IF OBJECT_ID(N'dbo.fn_XepLoaiHocLuc', N'FN') IS NOT NULL DROP FUNCTION dbo.fn_XepLoaiHocLuc;
IF OBJECT_ID(N'dbo.fn_ThuTrongTuanText', N'FN') IS NOT NULL DROP FUNCTION dbo.fn_ThuTrongTuanText;
IF OBJECT_ID(N'dbo.fn_CoTrungLichHoc', N'FN') IS NOT NULL DROP FUNCTION dbo.fn_CoTrungLichHoc;
IF OBJECT_ID(N'dbo.fn_KiemTraTrungLich', N'FN') IS NOT NULL DROP FUNCTION dbo.fn_KiemTraTrungLich;
GO

/* --- Bảng --- */
IF OBJECT_ID(N'dbo.DiemThi', N'U') IS NOT NULL DROP TABLE dbo.DiemThi;
IF OBJECT_ID(N'dbo.SinhVien', N'U') IS NOT NULL DROP TABLE dbo.SinhVien;
IF OBJECT_ID(N'dbo.MonHoc', N'U') IS NOT NULL DROP TABLE dbo.MonHoc;
IF OBJECT_ID(N'dbo.LopHoc', N'U') IS NOT NULL DROP TABLE dbo.LopHoc;
IF OBJECT_ID(N'dbo.TaiKhoan', N'U') IS NOT NULL DROP TABLE dbo.TaiKhoan;
GO

CREATE TABLE dbo.LopHoc (
    MaLop   VARCHAR(20)  NOT NULL PRIMARY KEY,
    TenLop  NVARCHAR(100) NOT NULL
);

CREATE TABLE dbo.MonHoc (
    MaMH              VARCHAR(20)   NOT NULL PRIMARY KEY,
    TenMH             NVARCHAR(200) NOT NULL,
    SoTinChi          TINYINT       NOT NULL CHECK (SoTinChi BETWEEN 1 AND 10),
    GiangVienPhuTrach NVARCHAR(100) NULL,
    MoTaMonHoc        NVARCHAR(500) NULL,
    ThuTrongTuan      TINYINT       NOT NULL CHECK (ThuTrongTuan BETWEEN 2 AND 8), /* 2=Thứ 2 ... 8=CN */
    GioBatDau         TIME(0)       NOT NULL,
    GioKetThuc        TIME(0)       NOT NULL,
    PhongHoc          NVARCHAR(50)  NULL,
    CONSTRAINT CK_MonHoc_Gio CHECK (GioKetThuc > GioBatDau)
);

CREATE TABLE dbo.SinhVien (
    MaSV        VARCHAR(20)   NOT NULL PRIMARY KEY,
    HoTen       NVARCHAR(100) NOT NULL,
    NgaySinh    DATE          NULL,
    GioiTinh    NVARCHAR(10)  NULL DEFAULT N'Nam',
    SoDienThoai VARCHAR(15)   NULL,
    Email       VARCHAR(100)  NULL,
    DiaChi      NVARCHAR(255) NULL,
    MaLop       VARCHAR(20)   NOT NULL REFERENCES dbo.LopHoc(MaLop),
    DiemTB      DECIMAL(4,2)  NULL,
    HocLuc      NVARCHAR(30)  NULL
);

CREATE TABLE dbo.DiemThi (
    MaSV         VARCHAR(20) NOT NULL REFERENCES dbo.SinhVien(MaSV),
    MaMH         VARCHAR(20) NOT NULL REFERENCES dbo.MonHoc(MaMH),
    DiemQuaTrinh TINYINT       NULL CHECK (DiemQuaTrinh BETWEEN 0 AND 10),
    DiemGiuaKi   TINYINT       NULL CHECK (DiemGiuaKi BETWEEN 0 AND 10),
    DiemCuoiKi   TINYINT       NULL CHECK (DiemCuoiKi BETWEEN 0 AND 10),
    TongKet      DECIMAL(4,1)  NULL,
    CONSTRAINT PK_DiemThi PRIMARY KEY (MaSV, MaMH)
);

CREATE TABLE dbo.TaiKhoan (
    TenDangNhapHash VARCHAR(64)   NOT NULL PRIMARY KEY,  /* SHA-256 hex của tên đăng nhập */
    MatKhauHash     NVARCHAR(500) NOT NULL,              /* PBKDF2: Base64(salt).Base64(hash) */
    HoTen           NVARCHAR(100) NOT NULL,
    QuyenHan        NVARCHAR(50)  NOT NULL DEFAULT N'Admin',
    TrangThai       BIT           NOT NULL DEFAULT 1
);
GO

DELETE FROM dbo.DiemThi;
DELETE FROM dbo.SinhVien;
DELETE FROM dbo.MonHoc;
DELETE FROM dbo.LopHoc;
DELETE FROM dbo.TaiKhoan;
GO

INSERT INTO dbo.LopHoc (MaLop, TenLop) VALUES
(N'D21CNTT01', N'Công nghệ thông tin K21'),
(N'D21CNTT02', N'Công nghệ thông tin K21 - CLB'),
(N'D22KHMT01', N'Khoa học máy tính K22'),
(N'D22CNTT03', N'Công nghệ thông tin K22 - A'),
(N'D22CNTT04', N'Công nghệ thông tin K22 - B'),
(N'D23KHMT02', N'Khoa học máy tính K23'),
(N'D23HTTT01', N'Hệ thống thông tin K23'),
(N'D23MMT01', N'Mạng máy tính K23');
GO

INSERT INTO dbo.MonHoc (MaMH, TenMH, SoTinChi, GiangVienPhuTrach, MoTaMonHoc, ThuTrongTuan, GioBatDau, GioKetThuc, PhongHoc) VALUES
(N'MH001', N'Lập trình C#', 3, N'Nguyễn Văn A', N'WinForms & ADO.NET', 2, '07:30', '09:30', N'A101'),
(N'MH002', N'Cơ sở dữ liệu', 3, N'Trần Thị B', N'SQL Server', 3, '09:45', '11:45', N'B202'),
(N'MH003', N'Cấu trúc dữ liệu', 4, N'Lê Văn C', N'CTDL & giải thuật', 4, '13:00', '15:30', N'C303'),
(N'MH004', N'Mạng máy tính', 3, N'Phạm Văn D', N'TCP/IP', 5, '15:45', '17:15', N'D104'),
(N'MH005', N'Tiếng Anh chuyên ngành', 2, N'Hoàng Thị E', N'IT English', 6, '07:30', '09:00', N'E105'),
(N'MH006', N'Lập trình Java', 3, N'Ngô Văn F', N'Java Core + OOP', 2, '09:45', '11:45', N'A202'),
(N'MH007', N'Phân tích thiết kế hệ thống', 3, N'Phan Thị G', N'UML, Use case, ERD', 3, '13:00', '15:00', N'B305'),
(N'MH008', N'Trí tuệ nhân tạo', 3, N'Đỗ Minh H', N'AI fundamentals', 4, '15:45', '17:15', N'C402'),
(N'MH009', N'An toàn thông tin', 3, N'Bùi Quốc I', N'Security basics', 5, '07:30', '09:30', N'D210'),
(N'MH010', N'Kiểm thử phần mềm', 2, N'Tạ Thu K', N'Test case, automation', 6, '09:15', '11:15', N'E207'),
(N'MH011', N'Phát triển Web', 3, N'Lý Anh L', N'ASP.NET MVC', 7, '13:00', '15:30', N'F110'),
(N'MH012', N'Đồ án chuyên ngành', 4, N'Nguyễn Trọng M', N'Capstone project', 8, '08:00', '11:00', N'LAB01'),
(N'MH013', N'Xử lý ảnh số', 3, N'Võ Hữu N', N'Image processing', 3, '07:30', '09:00', N'LAB02'),
(N'MH014', N'Cloud Computing', 3, N'Nguyễn Mỹ O', N'Cloud service models', 5, '13:00', '15:00', N'G205'),
(N'MH015', N'Kỹ năng mềm', 2, N'Trương Thanh P', N'Communication & teamwork', 7, '08:00', '09:30', N'H101');
GO

INSERT INTO dbo.SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi, MaLop) VALUES
(N'SV001', N'Nguyễn Minh An', '2003-05-12', N'Nam', '0901111001', 'an.nguyen@student.edu', N'TDMU', N'D21CNTT01'),
(N'SV002', N'Trần Thị Bích', '2003-08-20', N'Nữ', '0901111002', 'bich.tran@student.edu', N'TDMU', N'D21CNTT01'),
(N'SV003', N'Lê Hoàng Cường', '2002-11-03', N'Nam', '0901111003', 'cuong.le@student.edu', N'TDMU', N'D21CNTT02'),
(N'SV004', N'Phạm Thu Dung', '2003-01-15', N'Nữ', '0901111004', 'dung.pham@student.edu', N'TDMU', N'D21CNTT02'),
(N'SV005', N'Võ Quốc Em', '2004-03-28', N'Nam', '0901111005', 'em.vo@student.edu', N'TDMU', N'D22KHMT01'),
(N'SV006', N'Đặng Thị Phương', '2004-07-07', N'Nữ', '0901111006', 'phuong.dang@student.edu', N'TDMU', N'D22KHMT01'),
(N'SV007', N'Nguyễn Thành Long', '2004-04-16', N'Nam', '0901111007', 'long.nguyen@student.edu', N'TDMU', N'D22CNTT03'),
(N'SV008', N'Phan Gia Hân', '2004-12-09', N'Nữ', '0901111008', 'han.phan@student.edu', N'TDMU', N'D22CNTT03'),
(N'SV009', N'Đoàn Minh Khang', '2005-02-19', N'Nam', '0901111009', 'khang.doan@student.edu', N'TDMU', N'D22CNTT04'),
(N'SV010', N'Lưu Bảo Ngọc', '2005-06-22', N'Nữ', '0901111010', 'ngoc.luu@student.edu', N'TDMU', N'D22CNTT04'),
(N'SV011', N'Trịnh Tuấn Kiệt', '2005-09-30', N'Nam', '0901111011', 'kiet.trinh@student.edu', N'TDMU', N'D23KHMT02'),
(N'SV012', N'Huỳnh Diễm My', '2005-11-14', N'Nữ', '0901111012', 'my.huynh@student.edu', N'TDMU', N'D23KHMT02'),
(N'SV013', N'Đinh Nhật Quang', '2004-01-08', N'Nam', '0901111013', 'quang.dinh@student.edu', N'TDMU', N'D23HTTT01'),
(N'SV014', N'Tạ Khánh Linh', '2004-10-03', N'Nữ', '0901111014', 'linh.ta@student.edu', N'TDMU', N'D23HTTT01'),
(N'SV015', N'Bùi Hải Đăng', '2003-12-01', N'Nam', '0901111015', 'dang.bui@student.edu', N'TDMU', N'D23MMT01'),
(N'SV016', N'Ngô Bảo Trâm', '2005-03-11', N'Nữ', '0901111016', 'tram.ngo@student.edu', N'TDMU', N'D23MMT01'),
(N'SV017', N'Phạm Đức Tài', '2003-07-25', N'Nam', '0901111017', 'tai.pham@student.edu', N'TDMU', N'D21CNTT01'),
(N'SV018', N'Lê Thảo Nhi', '2004-08-18', N'Nữ', '0901111018', 'nhi.le@student.edu', N'TDMU', N'D22KHMT01'),
(N'SV019', N'Vũ Quốc Bảo', '2005-05-05', N'Nam', '0901111019', 'bao.vu@student.edu', N'TDMU', N'D22CNTT03'),
(N'SV020', N'Hoàng Minh Châu', '2005-01-27', N'Nữ', '0901111020', 'chau.hoang@student.edu', N'TDMU', N'D23HTTT01');
GO

/* SV001: MH001 + MH002; SV002: MH001 + MH003 (trùng Thứ 2 7:30-9:30 với MH001 nếu đăng ký thêm MH khác cùng giờ) */
INSERT INTO dbo.DiemThi (MaSV, MaMH, DiemQuaTrinh, DiemGiuaKi, DiemCuoiKi) VALUES
(N'SV001', N'MH001', 8, 7, 9),
(N'SV001', N'MH002', 7, 8, 8),
(N'SV002', N'MH001', 9, 9, 10),
(N'SV002', N'MH003', 6, 7, 7),
(N'SV003', N'MH004', 5, 6, 6),
(N'SV005', N'MH005', 8, 8, 9),
(N'SV006', N'MH006', 4, 5, 5),
(N'SV006', N'MH010', 6, 7, 7),
(N'SV007', N'MH001', 10, 9, 10),
(N'SV007', N'MH007', 9, 8, 9),
(N'SV007', N'MH011', 8, 8, 9),
(N'SV008', N'MH002', 8, 7, 8),
(N'SV008', N'MH008', 9, 9, 8),
(N'SV008', N'MH012', NULL, NULL, NULL),
(N'SV009', N'MH003', 3, 4, 4),
(N'SV009', N'MH009', 5, 4, 5),
(N'SV010', N'MH004', 7, 6, 7),
(N'SV010', N'MH013', 8, 9, 8),
(N'SV010', N'MH015', 10, 10, 10),
(N'SV011', N'MH005', 2, 3, 4),
(N'SV011', N'MH014', 5, 5, 5),
(N'SV012', N'MH006', 7, 8, 9),
(N'SV012', N'MH010', 8, 8, 8),
(N'SV013', N'MH007', 6, 6, 7),
(N'SV013', N'MH011', 7, 7, 7),
(N'SV013', N'MH014', 6, 5, 6),
(N'SV014', N'MH008', 9, 9, 9),
(N'SV014', N'MH012', 8, 9, 9),
(N'SV015', N'MH009', 4, 4, 3),
(N'SV015', N'MH013', 5, 6, 5),
(N'SV016', N'MH010', 9, 8, 10),
(N'SV016', N'MH015', 7, 8, 8),
(N'SV017', N'MH001', 6, 6, 6),
(N'SV017', N'MH003', 5, 6, 5),
(N'SV017', N'MH014', 6, 7, 6),
(N'SV018', N'MH002', 9, 10, 10),
(N'SV018', N'MH005', 8, 9, 9),
(N'SV019', N'MH006', 5, 5, 4),
(N'SV019', N'MH011', 6, 5, 6),
(N'SV020', N'MH007', 10, 9, 10),
(N'SV020', N'MH012', 9, 9, 10),
(N'SV020', N'MH015', 8, 8, 9);
GO

/* Hash tên đăng nhập: SHA-256 UTF-8 chữ thường (CryptoHelper.HashUsername). Mật khẩu: PBKDF2. UI: admin/123456, giaovu/123456 */
INSERT INTO dbo.TaiKhoan (TenDangNhapHash, MatKhauHash, HoTen, QuyenHan, TrangThai) VALUES
(N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', N'U0CTjnan+VIVk/sPAJN7HA==.Esfrgy4tDEaPyQmDDzLxyBqDcq6fUAtIdiov/CN4uI0=', N'Quản trị viên', N'Admin', 1),
(N'0f32d16beb826eb92f937d771bd364fb7bb412be4695a8a69f3ebcd3688c9cfd', N'LkNDs7vHfRjQ6Ofb0miPYw==.TfMd/jCbqkvGSf4tCm+oKrUEXYX5JJIfn30AvYPuDFI=', N'Giáo vụ', N'Staff', 1);
GO

CREATE OR ALTER FUNCTION dbo.fn_TinhDiemTongKet
(
    @DiemQuaTrinh TINYINT,
    @DiemGiuaKi   TINYINT,
    @DiemCuoiKi   TINYINT
)
RETURNS DECIMAL(4, 1)
AS
BEGIN
    RETURN ROUND(
        ISNULL(@DiemQuaTrinh, 0) * 0.2
        + ISNULL(@DiemGiuaKi, 0) * 0.3
        + ISNULL(@DiemCuoiKi, 0) * 0.5,
        1
    );
END
GO

CREATE OR ALTER FUNCTION dbo.fn_XepLoaiHocLuc
(
    @Diem DECIMAL(4, 1)
)
RETURNS NVARCHAR(30)
AS
BEGIN
    RETURN CASE
        WHEN @Diem IS NULL THEN N'Chưa xếp loại'
        WHEN @Diem >= 9.0 THEN N'Xuất sắc'
        WHEN @Diem >= 8.0 THEN N'Giỏi'
        WHEN @Diem >= 6.5 THEN N'Khá'
        WHEN @Diem >= 5.0 THEN N'Trung bình'
        ELSE N'Yếu'
    END;
END
GO

CREATE OR ALTER FUNCTION dbo.fn_ThuTrongTuanText(@Thu TINYINT)
RETURNS NVARCHAR(20)
AS
BEGIN
    RETURN CASE @Thu
        WHEN 2 THEN N'Thứ 2'
        WHEN 3 THEN N'Thứ 3'
        WHEN 4 THEN N'Thứ 4'
        WHEN 5 THEN N'Thứ 5'
        WHEN 6 THEN N'Thứ 6'
        WHEN 7 THEN N'Thứ 7'
        WHEN 8 THEN N'Chủ nhật'
        ELSE N'Không xác định'
    END;
END
GO

/* Trả về 1 nếu sinh viên @MaSV bị trùng lịch khi đăng ký môn @MaMH */
CREATE OR ALTER FUNCTION dbo.fn_CoTrungLichHoc
(
    @MaSV VARCHAR(20),
    @MaMH VARCHAR(20)
)
RETURNS BIT
AS
BEGIN
    DECLARE @Thu TINYINT, @BatDau TIME(0), @KetThuc TIME(0);

    SELECT @Thu = ThuTrongTuan, @BatDau = GioBatDau, @KetThuc = GioKetThuc
    FROM dbo.MonHoc WHERE MaMH = @MaMH;

    IF @Thu IS NULL RETURN 0;

    IF EXISTS (
        SELECT 1
        FROM dbo.DiemThi dt
        INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH
        WHERE dt.MaSV = @MaSV
          AND dt.MaMH <> @MaMH
          AND mh.ThuTrongTuan = @Thu
          AND @BatDau < mh.GioKetThuc
          AND mh.GioBatDau < @KetThuc
    )
        RETURN 1;

    RETURN 0;
END
GO

CREATE OR ALTER VIEW dbo.vw_BangXepHang
AS
SELECT
    sv.MaSV,
    sv.HoTen,
    l.TenLop,
    sv.DiemTB AS GPA,
    ISNULL(sv.HocLuc, N'Chưa xếp loại') AS HocLuc,
    CASE
        WHEN sv.DiemTB IS NULL THEN N'Chưa có điểm'
        WHEN sv.DiemTB < 5.0 THEN N'Nguy cơ rớt môn'
        WHEN sv.DiemTB >= 8.0 THEN N'Đủ điều kiện học bổng'
        ELSE N'Ổn định'
    END AS GhiChu
FROM dbo.SinhVien sv
LEFT JOIN dbo.LopHoc l ON sv.MaLop = l.MaLop;
GO

CREATE OR ALTER VIEW dbo.vw_LichHocSinhVien
AS
SELECT
    sv.MaSV,
    sv.HoTen,
    mh.MaMH,
    mh.TenMH,
    mh.ThuTrongTuan,
    dbo.fn_ThuTrongTuanText(mh.ThuTrongTuan) AS ThuHoc,
    CONVERT(VARCHAR(5), mh.GioBatDau, 108) + N' - ' + CONVERT(VARCHAR(5), mh.GioKetThuc, 108) AS KhungGio,
    mh.PhongHoc,
    mh.GiangVienPhuTrach,
    mh.SoTinChi
FROM dbo.DiemThi dt
INNER JOIN dbo.SinhVien sv ON dt.MaSV = sv.MaSV
INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH;
GO

CREATE OR ALTER VIEW dbo.vw_MonHocChiTiet
AS
SELECT
    mh.MaMH,
    mh.TenMH,
    mh.SoTinChi,
    mh.GiangVienPhuTrach,
    mh.MoTaMonHoc,
    mh.ThuTrongTuan,
    dbo.fn_ThuTrongTuanText(mh.ThuTrongTuan) AS ThuHoc,
    CONVERT(VARCHAR(5), mh.GioBatDau, 108) AS GioBatDau,
    CONVERT(VARCHAR(5), mh.GioKetThuc, 108) AS GioKetThuc,
    dbo.fn_ThuTrongTuanText(mh.ThuTrongTuan)
        + N' | '
        + CONVERT(VARCHAR(5), mh.GioBatDau, 108)
        + N' - '
        + CONVERT(VARCHAR(5), mh.GioKetThuc, 108)
        + ISNULL(N' | P.' + mh.PhongHoc, N'') AS LichHocText,
    mh.PhongHoc
FROM dbo.MonHoc mh;
GO

CREATE OR ALTER VIEW dbo.vw_LichHocSinhVien
AS
SELECT
    dt.MaSV,
    sv.HoTen,
    mh.MaMH,
    mh.TenMH,
    mh.SoTinChi,
    mh.ThuTrongTuan,
    dbo.fn_ThuTrongTuanText(mh.ThuTrongTuan) AS ThuHoc,
    CONVERT(VARCHAR(5), mh.GioBatDau, 108) AS GioBatDau,
    CONVERT(VARCHAR(5), mh.GioKetThuc, 108) AS GioKetThuc,
    mh.PhongHoc,
    mh.GiangVienPhuTrach
FROM dbo.DiemThi dt
INNER JOIN dbo.SinhVien sv ON sv.MaSV = dt.MaSV
INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH;
GO

CREATE OR ALTER TRIGGER dbo.trg_DiemThi_TinhTongKet
ON dbo.DiemThi
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dt
    SET TongKet = CAST(dbo.fn_TinhDiemTongKet(i.DiemQuaTrinh, i.DiemGiuaKi, i.DiemCuoiKi) AS TINYINT)
    FROM dbo.DiemThi dt
    INNER JOIN inserted i ON dt.MaSV = i.MaSV AND dt.MaMH = i.MaMH;

    /* Đồng bộ GPA & học lực tổng trên SinhVien */
    ;WITH DiemTB AS (
        SELECT
            dt.MaSV,
            DiemTB = ROUND(SUM(dt.TongKet * mh.SoTinChi) * 1.0 / NULLIF(SUM(mh.SoTinChi), 0), 2)
        FROM dbo.DiemThi dt
        INNER JOIN inserted i ON dt.MaSV = i.MaSV
        INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH
        GROUP BY dt.MaSV
    )
    UPDATE sv
    SET
        DiemTB = d.DiemTB,
        HocLuc = dbo.fn_XepLoaiHocLuc(d.DiemTB)
    FROM dbo.SinhVien sv
    INNER JOIN DiemTB d ON sv.MaSV = d.MaSV;
END
GO

CREATE OR ALTER TRIGGER dbo.trg_MonHoc_ValidateLich
ON dbo.MonHoc
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM inserted WHERE GioKetThuc <= GioBatDau)
        THROW 51020, N'Giờ kết thúc phải sau giờ bắt đầu', 1;
END
GO

/*
  Đăng nhập xác thực mật khẩu tại ứng dụng (PBKDF2).
  Procedure này chỉ tra cứu theo hash tên đăng nhập.
*/
CREATE OR ALTER PROCEDURE dbo.LayTaiKhoanDangNhap
    @TenDangNhapHash VARCHAR(64)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MatKhauHash, HoTen, QuyenHan, TrangThai
    FROM dbo.TaiKhoan
    WHERE TenDangNhapHash = @TenDangNhapHash;
END
GO

CREATE OR ALTER PROCEDURE dbo.TimKiemSinhVien
    @TuKhoa VARCHAR(100) = NULL,
    @MaLop  VARCHAR(20)  = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT
            sv.MaSV,
            sv.HoTen,
            sv.NgaySinh,
            sv.MaLop,
            l.TenLop,
            sv.DiemTB,
            sv.HocLuc
        FROM dbo.SinhVien sv
        LEFT JOIN dbo.LopHoc l ON sv.MaLop = l.MaLop
        WHERE (@MaLop IS NULL OR sv.MaLop = @MaLop)
          AND (
                @TuKhoa IS NULL
                OR sv.MaSV LIKE '%' + @TuKhoa + '%'
                OR sv.HoTen LIKE N'%' + @TuKhoa + '%'
              )
        ORDER BY sv.MaSV;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.ThemSinhVien
    @MaSV        VARCHAR(20),
    @HoTen       NVARCHAR(100),
    @NgaySinh    DATE          = NULL,
    @GioiTinh    NVARCHAR(10)  = N'Nam',
    @SoDienThoai VARCHAR(15)   = NULL,
    @Email       VARCHAR(100)  = NULL,
    @DiaChi      NVARCHAR(255) = NULL,
    @MaLop       VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        IF EXISTS (SELECT 1 FROM dbo.SinhVien WHERE MaSV = @MaSV)
            THROW 51010, N'Mã sinh viên đã tồn tại', 1;

        IF NOT EXISTS (SELECT 1 FROM dbo.LopHoc WHERE MaLop = @MaLop)
            THROW 51011, N'Mã lớp không hợp lệ', 1;

        INSERT INTO dbo.SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi, MaLop)
        VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @SoDienThoai, @Email, @DiaChi, @MaLop);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.CapNhatSinhVien
    @MaSV        VARCHAR(20),
    @HoTen       NVARCHAR(100),
    @NgaySinh    DATE = NULL,
    @GioiTinh    NVARCHAR(10) = NULL,
    @SoDienThoai VARCHAR(15) = NULL,
    @Email       VARCHAR(100) = NULL,
    @DiaChi      NVARCHAR(255) = NULL,
    @MaLop       VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.SinhVien WHERE MaSV = @MaSV)
            THROW 51005, N'Mã sinh viên không tồn tại', 1;
        IF NOT EXISTS (SELECT 1 FROM dbo.LopHoc WHERE MaLop = @MaLop)
            THROW 51011, N'Mã lớp không hợp lệ', 1;

        UPDATE dbo.SinhVien
        SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh,
            SoDienThoai = @SoDienThoai, Email = @Email, DiaChi = @DiaChi, MaLop = @MaLop
        WHERE MaSV = @MaSV;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.XoaSinhVien
    @MaSV VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        IF NOT EXISTS (SELECT 1 FROM dbo.SinhVien WHERE MaSV = @MaSV)
            THROW 51005, N'Mã sinh viên không tồn tại', 1;

        DELETE FROM dbo.DiemThi WHERE MaSV = @MaSV;
        DELETE FROM dbo.SinhVien WHERE MaSV = @MaSV;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.ThongTinSinhVien
    @MaSV VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.SoDienThoai, sv.Email, sv.DiaChi,
           sv.MaLop, l.TenLop, sv.DiemTB, sv.HocLuc
    FROM dbo.SinhVien sv
    LEFT JOIN dbo.LopHoc l ON sv.MaLop = l.MaLop
    WHERE sv.MaSV = @MaSV;
END
GO

CREATE OR ALTER PROCEDURE dbo.ChiTietSinhVien
    @MaSv VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM dbo.SinhVien WHERE MaSV = @MaSv)
        THROW 51005, N'Mã sinh viên không tồn tại', 1;

    SELECT dt.MaMH, m.TenMH, m.SoTinChi,
           dbo.fn_ThuTrongTuanText(m.ThuTrongTuan) AS ThuHoc,
           CONVERT(VARCHAR(5), m.GioBatDau, 108) + N' - ' + CONVERT(VARCHAR(5), m.GioKetThuc, 108) AS KhungGio,
           dt.TongKet,
           dt.DiemQuaTrinh, dt.DiemGiuaKi, dt.DiemCuoiKi
    FROM dbo.DiemThi dt
    JOIN dbo.MonHoc m ON dt.MaMH = m.MaMH
    WHERE dt.MaSV = @MaSv
    ORDER BY m.ThuTrongTuan, m.GioBatDau;
END
GO

CREATE OR ALTER PROCEDURE dbo.CapNhatDiem
    @MaSV         VARCHAR(20),
    @MaMH         VARCHAR(20),
    @DiemQuaTrinh TINYINT,
    @DiemGiuaKi   TINYINT,
    @DiemCuoiKi   TINYINT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        IF NOT EXISTS (SELECT 1 FROM dbo.SinhVien WHERE MaSV = @MaSV)
            THROW 51012, N'Mã sinh viên không tồn tại', 1;

        IF NOT EXISTS (SELECT 1 FROM dbo.MonHoc WHERE MaMH = @MaMH)
            THROW 51013, N'Mã môn học không tồn tại', 1;

        IF EXISTS (SELECT 1 FROM dbo.DiemThi WHERE MaSV = @MaSV AND MaMH = @MaMH)
        BEGIN
            UPDATE dbo.DiemThi
            SET DiemQuaTrinh = @DiemQuaTrinh,
                DiemGiuaKi   = @DiemGiuaKi,
                DiemCuoiKi   = @DiemCuoiKi
            WHERE MaSV = @MaSV AND MaMH = @MaMH;
        END
        ELSE
        BEGIN
            INSERT INTO dbo.DiemThi (MaSV, MaMH, DiemQuaTrinh, DiemGiuaKi, DiemCuoiKi)
            VALUES (@MaSV, @MaMH, @DiemQuaTrinh, @DiemGiuaKi, @DiemCuoiKi);
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.LayDanhSachMonHoc
    @TuKhoa VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MaMH, TenMH, SoTinChi, GiangVienPhuTrach, MoTaMonHoc,
           ThuTrongTuan, ThuHoc, GioBatDau, GioKetThuc, LichHocText, PhongHoc
    FROM dbo.vw_MonHocChiTiet
    WHERE @TuKhoa IS NULL
       OR MaMH LIKE '%' + @TuKhoa + '%'
       OR TenMH LIKE N'%' + @TuKhoa + '%'
       OR GiangVienPhuTrach LIKE N'%' + @TuKhoa + '%'
    ORDER BY MaMH;
END
GO

CREATE OR ALTER PROCEDURE dbo.ChiTietMonHoc
    @MaMH VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MaMH, TenMH, SoTinChi, GiangVienPhuTrach, MoTaMonHoc,
           ThuTrongTuan, ThuHoc, GioBatDau, GioKetThuc, LichHocText, PhongHoc
    FROM dbo.vw_MonHocChiTiet
    WHERE MaMH = @MaMH;
END
GO

CREATE OR ALTER PROCEDURE dbo.CapNhatMonHoc
    @MaMH              VARCHAR(20),
    @TenMH             NVARCHAR(200),
    @SoTinChi          TINYINT,
    @GiangVienPhuTrach NVARCHAR(100) = NULL,
    @MoTaMonHoc        NVARCHAR(500) = NULL,
    @ThuTrongTuan      TINYINT,
    @GioBatDau         TIME(0),
    @GioKetThuc        TIME(0),
    @PhongHoc          NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.MonHoc WHERE MaMH = @MaMH)
            THROW 51016, N'Mã môn học không tồn tại', 1;
        IF @GioKetThuc <= @GioBatDau
            THROW 51015, N'Giờ kết thúc phải sau giờ bắt đầu', 1;

        UPDATE dbo.MonHoc
        SET TenMH = @TenMH,
            SoTinChi = @SoTinChi,
            GiangVienPhuTrach = @GiangVienPhuTrach,
            MoTaMonHoc = @MoTaMonHoc,
            ThuTrongTuan = @ThuTrongTuan,
            GioBatDau = @GioBatDau,
            GioKetThuc = @GioKetThuc,
            PhongHoc = @PhongHoc
        WHERE MaMH = @MaMH;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.DoiMatKhau
    @TenDangNhapHash VARCHAR(64),
    @MatKhauHash     NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.TaiKhoan WHERE TenDangNhapHash = @TenDangNhapHash)
            THROW 51001, N'Tài khoản không tồn tại', 1;
        UPDATE dbo.TaiKhoan SET MatKhauHash = @MatKhauHash WHERE TenDangNhapHash = @TenDangNhapHash;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.XoaMonHoc
    @MaMH VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        IF NOT EXISTS (SELECT 1 FROM dbo.MonHoc WHERE MaMH = @MaMH)
            THROW 51016, N'Mã môn học không tồn tại', 1;
        DELETE FROM dbo.DiemThi WHERE MaMH = @MaMH;
        DELETE FROM dbo.MonHoc WHERE MaMH = @MaMH;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.ThemMonHoc
    @MaMH              VARCHAR(20),
    @TenMH             NVARCHAR(200),
    @SoTinChi          TINYINT,
    @GiangVienPhuTrach NVARCHAR(100) = NULL,
    @MoTaMonHoc        NVARCHAR(500) = NULL,
    @ThuTrongTuan      TINYINT,
    @GioBatDau         TIME(0),
    @GioKetThuc        TIME(0),
    @PhongHoc          NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM dbo.MonHoc WHERE MaMH = @MaMH)
            THROW 51014, N'Mã môn học đã tồn tại', 1;

        IF @GioKetThuc <= @GioBatDau
            THROW 51015, N'Giờ kết thúc phải sau giờ bắt đầu', 1;

        INSERT INTO dbo.MonHoc (MaMH, TenMH, SoTinChi, GiangVienPhuTrach, MoTaMonHoc, ThuTrongTuan, GioBatDau, GioKetThuc, PhongHoc)
        VALUES (@MaMH, @TenMH, @SoTinChi, @GiangVienPhuTrach, @MoTaMonHoc, @ThuTrongTuan, @GioBatDau, @GioKetThuc, @PhongHoc);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.DangKyMonHocChoSinhVien
    @MaSV      VARCHAR(20),
    @MaMH      VARCHAR(20),
    @ThanhCong BIT OUTPUT,
    @ThongBao  NVARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @ThanhCong = 0;
    SET @ThongBao = N'';

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.SinhVien WHERE MaSV = @MaSV)
        BEGIN
            SET @ThongBao = N'Mã sinh viên không tồn tại';
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM dbo.MonHoc WHERE MaMH = @MaMH)
        BEGIN
            SET @ThongBao = N'Mã môn học không tồn tại';
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM dbo.DiemThi WHERE MaSV = @MaSV AND MaMH = @MaMH)
        BEGIN
            SET @ThongBao = N'Sinh viên đã đăng ký môn này';
            RETURN;
        END

        IF dbo.fn_CoTrungLichHoc(@MaSV, @MaMH) = 1
        BEGIN
            DECLARE @TenMH NVARCHAR(200), @Lich NVARCHAR(200);
            SELECT @TenMH = TenMH FROM dbo.MonHoc WHERE MaMH = @MaMH;
            SELECT TOP 1 @Lich = mh.TenMH + N' (' + dbo.fn_ThuTrongTuanText(mh.ThuTrongTuan)
                + N' ' + CONVERT(VARCHAR(5), mh.GioBatDau, 108) + N'-' + CONVERT(VARCHAR(5), mh.GioKetThuc, 108) + N')'
            FROM dbo.DiemThi dt
            INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH
            INNER JOIN dbo.MonHoc mNew ON mNew.MaMH = @MaMH
            WHERE dt.MaSV = @MaSV
              AND mh.ThuTrongTuan = mNew.ThuTrongTuan
              AND mNew.GioBatDau < mh.GioKetThuc
              AND mh.GioBatDau < mNew.GioKetThuc;

            SET @ThongBao = N'Trùng lịch học với môn: ' + ISNULL(@Lich, N'môn đã đăng ký');
            RETURN;
        END

        INSERT INTO dbo.DiemThi (MaSV, MaMH, DiemQuaTrinh, DiemGiuaKi, DiemCuoiKi)
        VALUES (@MaSV, @MaMH, NULL, NULL, NULL);

        SET @ThanhCong = 1;
        SET @ThongBao = N'Đăng ký thành công';
    END TRY
    BEGIN CATCH
        SET @ThongBao = ERROR_MESSAGE();
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.LayDanhSachLop
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        l.MaLop,
        l.TenLop,
        SiSo = ISNULL(COUNT(sv.MaSV), 0)
    FROM dbo.LopHoc l
    LEFT JOIN dbo.SinhVien sv ON sv.MaLop = l.MaLop
    GROUP BY l.MaLop, l.TenLop
    ORDER BY l.MaLop;
END
GO

CREATE OR ALTER PROCEDURE dbo.ThemLop
    @MaLop  VARCHAR(20),
    @TenLop NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM dbo.LopHoc WHERE MaLop = @MaLop)
            THROW 51030, N'Mã lớp đã tồn tại', 1;
        INSERT INTO dbo.LopHoc (MaLop, TenLop) VALUES (@MaLop, @TenLop);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.CapNhatLop
    @MaLop  VARCHAR(20),
    @TenLop NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.LopHoc WHERE MaLop = @MaLop)
            THROW 51031, N'Mã lớp không tồn tại', 1;
        UPDATE dbo.LopHoc SET TenLop = @TenLop WHERE MaLop = @MaLop;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.XoaLop
    @MaLop VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.LopHoc WHERE MaLop = @MaLop)
            THROW 51032, N'Mã lớp không tồn tại', 1;
        IF EXISTS (SELECT 1 FROM dbo.SinhVien WHERE MaLop = @MaLop)
            THROW 51033, N'Không thể xóa lớp đang có sinh viên', 1;
        DELETE FROM dbo.LopHoc WHERE MaLop = @MaLop;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.HuyDangKyMonHoc
    @MaSV      VARCHAR(20),
    @MaMH      VARCHAR(20),
    @ThanhCong BIT OUTPUT,
    @ThongBao  NVARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @ThanhCong = 0;
    SET @ThongBao = N'';

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.DiemThi WHERE MaSV = @MaSV AND MaMH = @MaMH)
        BEGIN
            SET @ThongBao = N'Sinh viên chưa đăng ký môn này';
            RETURN;
        END

        DELETE FROM dbo.DiemThi WHERE MaSV = @MaSV AND MaMH = @MaMH;
        SET @ThanhCong = 1;
        SET @ThongBao = N'Đã hủy đăng ký môn học';
    END TRY
    BEGIN CATCH
        SET @ThongBao = ERROR_MESSAGE();
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.LayLichHocSinhVien
    @MaSV VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT
            MaMH,
            TenMH,
            SoTinChi,
            ThuTrongTuan,
            ThuHoc,
            GioBatDau,
            GioKetThuc,
            PhongHoc,
            GiangVienPhuTrach
        FROM dbo.vw_LichHocSinhVien
        WHERE MaSV = @MaSV
        ORDER BY ThuTrongTuan, GioBatDau;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

/* Phục vụ frmXepHang: lọc theo lớp, học lực; hỗ trợ Top GPA / cảnh báo / học bổng */
CREATE OR ALTER PROCEDURE dbo.LayBaoCaoXepHang
    @MaLop   VARCHAR(20)  = NULL,
    @HocLuc  NVARCHAR(30) = NULL,
    @CheDo   VARCHAR(20)  = NULL  /* ALL | TOP | CANHBAO | HOCBONG */
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT
            MaSV,
            HoTen,
            TenLop,
            GPA,
            HocLuc,
            GhiChu
        FROM dbo.vw_BangXepHang
        WHERE (@MaLop IS NULL OR MaSV IN (
                SELECT MaSV FROM dbo.SinhVien WHERE MaLop = @MaLop
            ))
          AND (@HocLuc IS NULL OR HocLuc = @HocLuc)
          AND (
                @CheDo IS NULL OR @CheDo = 'ALL'
                OR (@CheDo = 'TOP'     AND GPA IS NOT NULL)
                OR (@CheDo = 'CANHBAO' AND GPA < 5.0)
                OR (@CheDo = 'HOCBONG' AND GPA >= 8.0)
              )
        ORDER BY
            CASE WHEN GPA IS NULL THEN 1 ELSE 0 END,
            GPA DESC,
            HoTen
        OFFSET 0 ROWS
        FETCH NEXT CASE WHEN @CheDo = 'TOP' THEN 20 ELSE 2147483647 END ROWS ONLY;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE dbo.ThongKeBaoCao
    @MaLop VARCHAR(20) = NULL,
    @TongSV INT OUTPUT,
    @SoHocBong INT OUTPUT,
    @SoCanhBao INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT @TongSV = COUNT(*)
    FROM dbo.SinhVien sv
    WHERE @MaLop IS NULL OR sv.MaLop = @MaLop;

    SELECT @SoHocBong = COUNT(*)
    FROM dbo.SinhVien sv
    WHERE (@MaLop IS NULL OR sv.MaLop = @MaLop) AND sv.DiemTB >= 8.0;

    SELECT @SoCanhBao = COUNT(*)
    FROM dbo.SinhVien sv
    WHERE (@MaLop IS NULL OR sv.MaLop = @MaLop) AND sv.DiemTB IS NOT NULL AND sv.DiemTB < 5.0;
END
GO

/* Kiểm tra trigger sau khi chạy script */
IF OBJECT_ID(N'dbo.trg_DiemThi_TinhTongKet', N'TR') IS NULL
    RAISERROR(N'THIEU trigger dbo.trg_DiemThi_TinhTongKet — chay lai toan bo CSDL.sql.', 16, 1);
IF OBJECT_ID(N'dbo.trg_MonHoc_ValidateLich', N'TR') IS NULL
    RAISERROR(N'THIEU trigger dbo.trg_MonHoc_ValidateLich — chay lai toan bo CSDL.sql.', 16, 1);

PRINT N'CSDL QLSV_MRBEAST: Tao va cap nhat thanh cong.';
PRINT N'Trigger: trg_DiemThi_TinhTongKet, trg_MonHoc_ValidateLich';
GO


