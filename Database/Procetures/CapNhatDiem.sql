USE [QLSV_MRBEAST];
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
