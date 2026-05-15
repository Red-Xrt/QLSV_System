USE [QLSV_MRBEAST];
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
