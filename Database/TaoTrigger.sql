/*
  Chạy trong SSMS nếu Object Explorer không thấy trigger (database QLSV_MRBEAST).
  Hoặc chạy lại toàn bộ CSDL.sql.
*/
USE QLSV_MRBEAST;
GO

IF OBJECT_ID(N'dbo.trg_DiemThi_TinhTongKet', N'TR') IS NOT NULL DROP TRIGGER dbo.trg_DiemThi_TinhTongKet;
IF OBJECT_ID(N'dbo.trg_MonHoc_ValidateLich', N'TR') IS NOT NULL DROP TRIGGER dbo.trg_MonHoc_ValidateLich;
GO

CREATE TRIGGER dbo.trg_DiemThi_TinhTongKet
ON dbo.DiemThi
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dt
    SET TongKet = CAST(dbo.fn_TinhDiemTongKet(i.DiemQuaTrinh, i.DiemGiuaKi, i.DiemCuoiKi) AS TINYINT)
    FROM dbo.DiemThi dt
    INNER JOIN inserted i ON dt.MaSV = i.MaSV AND dt.MaMH = i.MaMH;

    ;WITH DiemTB AS (
        SELECT dt.MaSV, DiemTB = ROUND(SUM(dt.TongKet * mh.SoTinChi) * 1.0 / NULLIF(SUM(mh.SoTinChi), 0), 2)
        FROM dbo.DiemThi dt
        INNER JOIN inserted i ON dt.MaSV = i.MaSV
        INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH
        GROUP BY dt.MaSV
    )
    UPDATE sv SET DiemTB = d.DiemTB, HocLuc = dbo.fn_XepLoaiHocLuc(d.DiemTB)
    FROM dbo.SinhVien sv INNER JOIN DiemTB d ON sv.MaSV = d.MaSV;
END
GO

CREATE TRIGGER dbo.trg_MonHoc_ValidateLich
ON dbo.MonHoc
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM inserted WHERE GioKetThuc <= GioBatDau)
        THROW 51020, N'Giờ kết thúc phải sau giờ bắt đầu', 1;
END
GO

PRINT N'Da tao trigger.';
GO
