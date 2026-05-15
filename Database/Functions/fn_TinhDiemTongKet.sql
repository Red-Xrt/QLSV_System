USE [QLSV_MRBEAST];
GO

CREATE OR ALTER FUNCTION dbo.fn_TinhDiemTongKet
(
    @DiemQuaTrinh TINYINT,
    @DiemGiuaKi   TINYINT,
    @DiemCuoiKi   TINYINT
)
RETURNS DECIMAL(4, 1)
AS
BEGIN
    RETURN ROUND(
        ISNULL(@DiemQuaTrinh, 0) * 0.2
        + ISNULL(@DiemGiuaKi, 0) * 0.3
        + ISNULL(@DiemCuoiKi, 0) * 0.5,
        1
    );
END
GO
