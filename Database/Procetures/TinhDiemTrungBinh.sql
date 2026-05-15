USE [QLSV_MRBEAST];
GO

CREATE OR ALTER PROCEDURE dbo.TinhDiemTrungBinh
    @MaSV   VARCHAR(20),
    @DiemTB DECIMAL(4, 2) OUTPUT,
    @HocLuc NVARCHAR(30)   OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM dbo.SinhVien WHERE MaSV = @MaSV)
            THROW 51014, N'Mã sinh viên không tồn tại', 1;

        SELECT @DiemTB = ROUND(SUM(dt.TongKet * mh.SoTinChi) * 1.0 / NULLIF(SUM(mh.SoTinChi), 0), 2)
        FROM dbo.DiemThi dt
        INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH
        WHERE dt.MaSV = @MaSV;

        SET @HocLuc = dbo.fn_XepLoaiHocLuc(@DiemTB);

        UPDATE dbo.SinhVien
        SET DiemTB = @DiemTB, HocLuc = @HocLuc
        WHERE MaSV = @MaSV;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO
