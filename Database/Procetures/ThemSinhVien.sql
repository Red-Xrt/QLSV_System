USE [QLSV_MRBEAST];
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
