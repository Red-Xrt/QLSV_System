USE [QLSV_MRBEAST];
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
