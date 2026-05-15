USE [QLSV_MRBEAST];
GO

CREATE OR ALTER TRIGGER dbo.trg_DiemThi_TinhTongKet
ON dbo.DiemThi
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dt
    SET TongKet = CAST(dbo.fn_TinhDiemTongKet(i.DiemQuaTrinh, i.DiemGiuaKi, i.DiemCuoiKi) AS TINYINT)
    FROM dbo.DiemThi dt
    INNER JOIN inserted i ON dt.MaSV = i.MaSV AND dt.MaMH = i.MaMH;

    /* Đồng bộ GPA & học lực tổng trên SinhVien */
    ;WITH DiemTB AS (
        SELECT
            dt.MaSV,
            DiemTB = ROUND(SUM(dt.TongKet * mh.SoTinChi) * 1.0 / NULLIF(SUM(mh.SoTinChi), 0), 2)
        FROM dbo.DiemThi dt
        INNER JOIN inserted i ON dt.MaSV = i.MaSV
        INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH
        GROUP BY dt.MaSV
    )
    UPDATE sv
    SET
        DiemTB = d.DiemTB,
        HocLuc = dbo.fn_XepLoaiHocLuc(d.DiemTB)
    FROM dbo.SinhVien sv
    INNER JOIN DiemTB d ON sv.MaSV = d.MaSV;
END
GO
