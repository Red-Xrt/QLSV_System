USE [QLSV_MRBEAST];
GO

/* Thay thế view cũ (tham chiếu KetQuaHocTap không tồn tại) */
CREATE OR ALTER VIEW dbo.vw_BaoCaoThanhTich
AS
SELECT
    sv.MaSV,
    sv.HoTen,
    l.TenLop,
    mh.TenMH,
    dt.DiemQuaTrinh,
    dt.DiemGiuaKi AS DiemGiuaKy,
    dt.DiemCuoiKi AS DiemCuoiKy,
    dbo.fn_TinhDiemTongKet(dt.DiemQuaTrinh, dt.DiemGiuaKi, dt.DiemCuoiKi) AS DiemTongKet,
    dbo.fn_XepLoaiHocLuc(
        dbo.fn_TinhDiemTongKet(dt.DiemQuaTrinh, dt.DiemGiuaKi, dt.DiemCuoiKi)
    ) AS HocLucMon,
    dt.TongKet
FROM dbo.DiemThi dt
INNER JOIN dbo.SinhVien sv ON dt.MaSV = sv.MaSV
INNER JOIN dbo.LopHoc l ON sv.MaLop = l.MaLop
INNER JOIN dbo.MonHoc mh ON dt.MaMH = mh.MaMH;
GO
