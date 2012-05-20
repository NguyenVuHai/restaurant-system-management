-- 1141034
-- DIRTY READ 
-- T1
CREATE PROCEDURE dbo.CapNhatChiTietHoaDonDirtyRead
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
-- T2
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonSolveDirtyRead
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
-- PHANTOM T1
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonSolvePhantom
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
-- T2
CREATE PROCEDURE dbo.CapNhatChiTietHoaDonPhantom
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
		COMMIT
	END
GO
-- UNREPEATABLE READ T1
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonSolveUnRepeatableRead
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
-- T2
CREATE PROCEDURE dbo.XoaMonAnUnrepeatableRead
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
-- LOST UPDATE T1, T2

CREATE PROCEDURE dbo.CapNhatChiTietHoaDonSolveLostUpdate
(
	@MaHoaDon nvarchar(36),
	@MaChiTietThucDon int,
	@DonGia decimal(18,2),
	@SoLuong int,
	@MucCoLap int
)
AS
	BEGIN
		if (@MucCoLap = 1)
			SET TRAN ISOLATION LEVEL READ UNCOMMITTED
		else if (@MucCoLap = 2)
			SET TRAN ISOLATION LEVEL READ COMMITTED
		else if (@MucCoLap = 3)
			SET TRAN ISOLATION LEVEL REPEATABLE READ
		else 
			SET TRAN ISOLATION LEVEL SERIALIZABLE
		Declare @SQLQuery nvarchar(4000)
		Declare @MaChiTietHoaDon int = null
		Declare @SoLuongCu int
		
		RETRY:
		BEGIN TRAN
		BEGIN TRY
			Set @SQLQuery = N'SELECT @MaChiTietHoaDon = MaChiTietHoaDon, @SoLuongCu = SoLuong FROM CHITIETHOADON WHERE MaHoaDon = '''+ @MaHoaDon + ''' AND MaChiTietThucDon = ' + Convert(nvarchar, @MaChiTietThucDon) 
			EXEC sp_Executesql @Query  = @SQLQuery , @Params = N'@MaChiTietHoaDon int OUTPUT, @SoLuongCu int OUTPUT', @MaChiTietHoaDon = @MaChiTietHoaDon OUTPUT, @SoLuongCu = @SoLuongCu OUTPUT

			
			if (@MaChiTietHoaDon is null)
				begin
					Set @SQLQuery = N'INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('''+@MaHoaDon+''','+CONVERT(nvarchar, @MaChiTietThucDon)+','+ CONVERT(nvarchar, @DonGia)+','+ CONVERT(nvarchar, @SoLuong) +')'
					Execute sp_Executesql @SQLQuery
				end
			else
				begin
					WAITFOR DELAY '00:00:10'
					Set @SQLQuery = N'UPDATE CHITIETHOADON  SET MaChiTietThucDon = ' + Convert(nvarchar,@MaChiTietThucDon) + ',DonGia = ' + Convert(nvarchar,@DonGia) + ',SoLuong = ' + Convert(nvarchar,@SoLuong + @SoLuongCu) + ' WHERE MaChiTietHoaDon = ' + Convert(nvarchar,@MaChiTietHoaDon)
					Execute sp_Executesql @SQLQuery
					
				end

		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN IF ERROR_NUMBER()=1205
				BEGIN
					WAITFOR DELAY '00:00:05'
					GOTO RETRY
					END
		END CATCH
	END

