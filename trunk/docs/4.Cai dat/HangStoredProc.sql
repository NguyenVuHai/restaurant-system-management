CREATE PROCEDURE dbo.CapNhatChiTietHoaDon
(
	@MaHoaDon nvarchar(36),
	@MaChiTietThucDon int,
	@DonGia decimal,
	@SoLuong int
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Declare @MaChiTietHoaDon int = null
		Declare @SoLuongCu int
		Set @SQLQuery = N'SELECT @MaChiTietHoaDon = MaChiTietHoaDon, @SoLuongCu = SoLuong FROM CHITIETHOADON WHERE MaHoaDon = '''+ @MaHoaDon + ''' AND MaChiTietThucDon = ' + Convert(nvarchar, @MaChiTietThucDon) 
			EXEC sp_Executesql @Query  = @SQLQuery , @Params = N'@MaChiTietHoaDon int OUTPUT, @SoLuongCu int OUTPUT', @MaChiTietHoaDon = @MaChiTietHoaDon OUTPUT, @SoLuongCu = @SoLuongCu OUTPUT

			if (@MaChiTietHoaDon is null)
				begin
					Set @SQLQuery = N'INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('''+@MaHoaDon+''','+CONVERT(nvarchar, @MaChiTietThucDon)+','+ CONVERT(nvarchar, @DonGia)+','+ CONVERT(nvarchar, @SoLuong) +')'
					Execute sp_Executesql @SQLQuery
				end
			else
				begin
					Set @SQLQuery = N'UPDATE CHITIETHOADON SET MaChiTietThucDon = ' + Convert(nvarchar,@MaChiTietThucDon) + ',DonGia = ' + Convert(nvarchar,@DonGia) + ',SoLuong = ' + Convert(nvarchar,@SoLuong + @SoLuongCu) + ' WHERE MaChiTietHoaDon = ' + Convert(nvarchar,@MaChiTietHoaDon)
					Execute sp_Executesql @SQLQuery
				end
	END
GO
ALTER PROCEDURE dbo.CapNhatChiTietHoaDonDirtyRead
(
	@MaHoaDon nvarchar(36),
	@MaChiTietThucDon int,
	@DonGia decimal(18,2),
	@SoLuong int
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Declare @MaChiTietHoaDon int = null
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION
		Set @SQLQuery = N'SELECT @MaChiTietHoaDon = MaChiTietHoaDon FROM CHITIETHOADON WHERE MaHoaDon = '''+ @MaHoaDon + ''' AND MaChiTietThucDon = ' + Convert(nvarchar, @MaChiTietThucDon) 
			EXEC sp_Executesql @Query  = @SQLQuery , @Params = N'@MaChiTietHoaDon int OUTPUT', @MaChiTietHoaDon = @MaChiTietHoaDon OUTPUT

			if (@MaChiTietHoaDon is null)
				begin
					Set @SQLQuery = N'INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('''+@MaHoaDon+''','+CONVERT(nvarchar, @MaChiTietThucDon)+','+ CONVERT(nvarchar, @DonGia)+','+ CONVERT(nvarchar, @SoLuong) +')'
					Execute sp_Executesql @SQLQuery
				end
			else
				begin
					Set @SQLQuery = N'UPDATE CHITIETHOADON SET MaChiTietThucDon = ' + Convert(nvarchar,@MaChiTietThucDon) + ',DonGia = ' + Convert(nvarchar,@DonGia) + ',SoLuong = ' + Convert(nvarchar,@SoLuong) + ' WHERE MaChiTietHoaDon = ' + Convert(nvarchar,@MaChiTietHoaDon)
					Execute sp_Executesql @SQLQuery
				end
	WAITFOR DELAY '00:00:20'
	ROLLBACK
	END
GO
ALTER PROCEDURE dbo.CapNhatChiTietHoaDonLostUpdate
(
	@MaHoaDon nvarchar(36),
	@MaChiTietThucDon int,
	@DonGia decimal(18,2),
	@SoLuong int
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Declare @MaChiTietHoaDon int = null
		Declare @SoLuongCu int
		BEGIN TRANSACTION
			Set @SQLQuery = N'SELECT @MaChiTietHoaDon = MaChiTietHoaDon, @SoLuong = SoLuongCu FROM CHITIETHOADON WHERE MaHoaDon = '''+ @MaHoaDon + ''' AND MaChiTietThucDon = ' + Convert(nvarchar, @MaChiTietThucDon) 
			EXEC sp_Executesql @Query  = @SQLQuery , @Params = N'@MaChiTietHoaDon int OUTPUT, @SoLuongCu int OUTPUT', @MaChiTietHoaDon = @MaChiTietHoaDon OUTPUT, @SoLuongCu = @SoLuongCu OUTPUT
			
			WAITFOR DELAY '00:00:10'
			if (@MaChiTietHoaDon is null)
				begin
					Set @SQLQuery = N'INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('''+@MaHoaDon+''','+CONVERT(nvarchar, @MaChiTietThucDon)+','+ CONVERT(nvarchar, @DonGia)+','+ CONVERT(nvarchar, @SoLuong) +')'
					Execute sp_Executesql @SQLQuery
				end
			else
				begin
					Set @SQLQuery = N'UPDATE CHITIETHOADON SET MaChiTietThucDon = ' + Convert(nvarchar,@MaChiTietThucDon) + ',DonGia = ' + Convert(nvarchar,@DonGia) + ',SoLuong = ' + Convert(nvarchar,@SoLuong + @SoLuongCu) + ' WHERE MaChiTietHoaDon = ' + Convert(nvarchar,@MaChiTietHoaDon)
					Execute sp_Executesql @SQLQuery
				end
		COMMIT
	END
GO
ALTER PROCEDURE dbo.CapNhatChiTietHoaDonPhantom
(
	@MaHoaDon nvarchar(36),
	@MaChiTietThucDon int,
	@DonGia decimal(18,2),
	@SoLuong int
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Declare @MaChiTietHoaDon int = null
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRANSACTION
			Set @SQLQuery = N'SELECT @MaChiTietHoaDon = MaChiTietHoaDon FROM CHITIETHOADON WHERE MaHoaDon = '''+ @MaHoaDon + ''' AND MaChiTietThucDon = ' + Convert(nvarchar, @MaChiTietThucDon) 
			EXEC sp_Executesql @Query  = @SQLQuery , @Params = N'@MaChiTietHoaDon int OUTPUT', @MaChiTietHoaDon = @MaChiTietHoaDon OUTPUT

			if (@MaChiTietHoaDon is null)
				begin
					Set @SQLQuery = N'INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('''+@MaHoaDon+''','+CONVERT(nvarchar, @MaChiTietThucDon)+','+ CONVERT(nvarchar, @DonGia)+','+ CONVERT(nvarchar, @SoLuong) +')'
					Execute sp_Executesql @SQLQuery
				end
			else
				begin
					Set @SQLQuery = N'UPDATE CHITIETHOADON SET MaChiTietThucDon = ' + Convert(nvarchar,@MaChiTietThucDon) + ',DonGia = ' + Convert(nvarchar,@DonGia) + ',SoLuong = ' + Convert(nvarchar,@SoLuong) + ' WHERE MaChiTietHoaDon = ' + Convert(nvarchar,@MaChiTietHoaDon)
					Execute sp_Executesql @SQLQuery
				end
		COMMIT
	END
GO
ALTER PROCEDURE dbo.CapNhatChiTietHoaDonSolveLostUpdate
(
	@MaHoaDon nvarchar(36),
	@MaChiTietThucDon int,
	@DonGia decimal(18,2),
	@SoLuong int
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Declare @MaChiTietHoaDon int = null
		Declare @SoLuongCu int
		BEGIN TRANSACTION
			Set @SQLQuery = N'SELECT @MaChiTietHoaDon = MaChiTietHoaDon, @SoLuongCu = SoLuong FROM CHITIETHOADON WITH (UPDLOCK, HOLDLOCK) WHERE MaHoaDon = '''+ @MaHoaDon + ''' AND MaChiTietThucDon = ' + Convert(nvarchar, @MaChiTietThucDon) 
			EXEC sp_Executesql @Query  = @SQLQuery , @Params = N'@MaChiTietHoaDon int OUTPUT, @SoLuongCu int OUTPUT', @MaChiTietHoaDon = @MaChiTietHoaDon OUTPUT, @SoLuongCu = @SoLuongCu OUTPUT

			WAITFOR DELAY '00:00:10'
			if (@MaChiTietHoaDon is null)
				begin
					Set @SQLQuery = N'INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('''+@MaHoaDon+''','+CONVERT(nvarchar, @MaChiTietThucDon)+','+ CONVERT(nvarchar, @DonGia)+','+ CONVERT(nvarchar, @SoLuong) +')'
					Execute sp_Executesql @SQLQuery
				end
			else
				begin
					Set @SQLQuery = N'UPDATE CHITIETHOADON SET MaChiTietThucDon = ' + Convert(nvarchar,@MaChiTietThucDon) + ',DonGia = ' + Convert(nvarchar,@DonGia) + ',SoLuong = ' + Convert(nvarchar,@SoLuong + @SoLuongCu) + ' WHERE MaChiTietHoaDon = ' + Convert(nvarchar,@MaChiTietHoaDon)
					Execute sp_Executesql @SQLQuery
				end

		COMMIT
	END
GO
ALTER PROCEDURE dbo.KiemTraHoaDon
(
	@MaLichBan int
)
AS
	DECLARE @MaHoaDon uniqueidentifier
	SELECT @MaHoaDon = MaHoaDon FROM HOADON WHERE HOADON.MaLichBan = @MaLichBan
	Print @MaHoaDon
	IF (@MaHoaDon is not null)
	BEGIN
		SELECT @MaHoaDon
	END
	ELSE
		SELECT 0
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTheoNhaHang
(
	@MaNhaHang int,
	@Ngay datetime
)
AS
	Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(SELECT TOP 1 MaThucDon FROM THUCDON WHERE (MaNhaHang = ' + CONVERT(nvarchar, @MaNhaHang)+') AND (NgayApDung <= '''+CONVERT(nvarchar, @Ngay)+''')) TD'
		
		Set @SQLQuery = N'SELECT CT.MaMonAn, MA.TenMonAn, CT.DonGia, MaChiTietThucDon FROM '+@SQLQuery+' JOIN CHITIETTHUCDON CT ON TD.MaThucDon = CT.MaThucDon JOIN MONAN MA ON MA.MaMonAn = CT.MaMonAn WHERE (1=1)'
	Execute sp_Executesql @SQLQuery
	RETURN
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDon
(
	@MaHoaDon nvarchar(36)
)
AS

	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
	Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		
	Execute sp_Executesql @SQLQuery

	RETURN
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDon
(
	@MaHoaDon nvarchar(36)
)
AS

	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
	Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		
	Execute sp_Executesql @SQLQuery

	RETURN
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonLostUpdate
(
	@MaHoaDon nvarchar(36)
)
AS

	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
	Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		
	Execute sp_Executesql @SQLQuery

	RETURN
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonPhantom
(
	@MaHoaDon nvarchar(36)
)
AS
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION
		Declare @SQLQuery nvarchar(4000)
		Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
		Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		Execute sp_Executesql @SQLQuery
		WAITFOR DELAY '00:00:10'
		Execute sp_Executesql @SQLQuery
	COMMIT

GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonSolveDirtyRead
(
	@MaHoaDon nvarchar(36)
)
AS

	Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION
		Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
		Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		
	Execute sp_Executesql @SQLQuery

	RETURN
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonSolveLostUpdate
(
	@MaHoaDon nvarchar(36)
)
AS

	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
	Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''' WITH (UDPLOCK)'
		
	Execute sp_Executesql @SQLQuery

	RETURN
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonSolvePhantom
(
	@MaHoaDon nvarchar(36)
)
AS
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	BEGIN TRANSACTION
		Declare @SQLQuery nvarchar(4000)
		Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
		Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		Execute sp_Executesql @SQLQuery
		WAITFOR DELAY '00:00:10'
		Execute sp_Executesql @SQLQuery
	COMMIT
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonSolveUnRepeatableRead
(
	@MaHoaDon nvarchar(36)
)
AS

	Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	BEGIN TRANSACTION
		Set @SQLQuery = N'SELECT MaChiTietHoaDon,  TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
		Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		Set @SQLQuery = @SQLQuery + ' WAITFOR DELAY ''00:00:20'' ' + @SQLQuery
	Execute sp_Executesql @SQLQuery
	COMMIT
GO
ALTER PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonUnRepeatableRead
(
	@MaHoaDon nvarchar(36)
)
AS

	Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	BEGIN TRANSACTION
		Set @SQLQuery = N'SELECT MaChiTietHoaDon,  TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
		Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		Set @SQLQuery = @SQLQuery + ' WAITFOR DELAY ''00:00:20'' ' + @SQLQuery
	Execute sp_Executesql @SQLQuery
	COMMIT
GO
ALTER PROCEDURE dbo.XoaMonAn
(
	@MaChiTietHoaDon nvarchar(500)
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Set @SQLQuery = N'DELETE FROM CHITIETHOADON WHERE MaChiTietHoaDon IN (' + convert(nvarchar,@MaChiTietHoaDon) + ')'
		Execute sp_Executesql @SQLQuery
	END
	GO
ALTER PROCEDURE dbo.XoaMonAnDirtyRead
(
	@MaChiTietHoaDon nvarchar(500)
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION
		Set @SQLQuery = N'DELETE FROM CHITIETHOADON WHERE MaChiTietHoaDon IN (' + convert(nvarchar,@MaChiTietHoaDon) + ')'
		Execute sp_Executesql @SQLQuery
	WAITFOR DELAY '00:00:20'
	ROLLBACK
	END
	GO
ALTER PROCEDURE dbo.XoaMonAnUnrepeatableRead
(
	@MaChiTietHoaDon nvarchar(500)
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION
		Set @SQLQuery = N'DELETE FROM CHITIETHOADON WHERE MaChiTietHoaDon IN (' + convert(nvarchar,@MaChiTietHoaDon) + ')'
		Execute sp_Executesql @SQLQuery
		COMMIT
	END
	GO
	ALTER PROCEDURE dbo.XoaMonAnUnrepeatableRead
(
	@MaChiTietHoaDon nvarchar(500)
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION
		Set @SQLQuery = N'DELETE FROM CHITIETHOADON WHERE MaChiTietHoaDon IN (' + convert(nvarchar,@MaChiTietHoaDon) + ')'
		Execute sp_Executesql @SQLQuery
		COMMIT
	END