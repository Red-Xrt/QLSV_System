CREATE PROCEDURE ChiTietSinhVien
	@MaSv varchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
		IF NOT EXISTS (SELECT 1 FROM SinhVien WHERE @MaSv = SinhVien.MaSV)
		BEGIN
			;THROW 51005, N'Mã sinh viên ko tồn tại', 1
		END

		SELECT dt.MaMH, m.TenMH, m.SoTinChi, TongKet
		FROM DiemThi dt
		JOIN MonHoc m ON dt.MaMH = m.MaMH
		WHERE dt.MaSV = @MaSv
	END TRY

	BEGIN CATCH
		THROW
	END CATCH
END
GO
