USE [QLSV_MRBEAST];
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
            HoTen;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO
