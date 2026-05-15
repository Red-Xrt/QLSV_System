USE [QLSV_MRBEAST];
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
