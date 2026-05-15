CREATE PROCEDURE XacThucDangNhap
	@TenDangNhap nvarchar(50),
	@MatKhau nvarchar(200),
	@HoTen nvarchar(100) OUT,
	@QuyenHan nvarchar(50) OUT,
	@TrangThai bit OUT
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		SELECT
			@HoTen = HoTen,
			@QuyenHan = QuyenHan,
			@TrangThai = TrangThai,
			@MatKhau = MatKhau
		FROM TaiKhoan
		WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau;
		
		--Kiểm tra xem tên tài khoản/mật khẩu có hợp lệ ko
		IF @HoTen IS NULL
		BEGIN
			;THROW 51000, N'Tên đăng nhập hoặc mật khẩu ko chính xác', 1
		END
		
		IF @MatKhau IS NULL
		BEGIN
			;THROW 51001, N'Tên đăng nhập hoặc mật khẩu ko chính xác', 1
		END

		--Kiểm tra có đang bị timeout ko
		IF @TrangThai = 0
		BEGIN
			SET @HoTen = NULL;
			SET @QuyenHan = NULL;
			;THROW 51002, N'Tài khoản hiện đang bị khóa', 1
		END
	END TRY
	BEGIN CATCH
		THROW
	END CATCH
END
GO
