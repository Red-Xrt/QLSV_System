USE [QLSV_MRBEAST];
GO

CREATE OR ALTER PROCEDURE dbo.LayDanhSachMonHoc
    @TuKhoa VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT MaMH, TenMH, SoTinChi, GiangVienPhuTrach, MoTaMonHoc
        FROM dbo.MonHoc
        WHERE @TuKhoa IS NULL
           OR MaMH LIKE '%' + @TuKhoa + '%'
           OR TenMH LIKE N'%' + @TuKhoa + '%'
           OR GiangVienPhuTrach LIKE N'%' + @TuKhoa + '%'
        ORDER BY MaMH;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO
