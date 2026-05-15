USE [QLSV_MRBEAST];
GO

CREATE OR ALTER PROCEDURE dbo.DemSinhVienGioi
    @MaLop      VARCHAR(20),
    @SoLuongGioi INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT @SoLuongGioi = COUNT(*)
        FROM dbo.SinhVien
        WHERE MaLop = @MaLop
          AND DiemTB >= 8.0;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO
