CREATE PROCEDURE dbo.PhantomSolvedTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich
	(
	@ten nvarchar(500),
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL SERIALIZABLE
		BEGIN TRAN
		Set @SQLQuery = N'(SELECT T3.MaNhaCungCap,T4.TenNhaCungCap,T4.DienThoai,T4.SoTaiKhoan,T3.TongNo 
							FROM 
								(SELECT T1.MaNhaCungCap,T2.TongNo 
								  FROM (SELECT MaNhaCungCap 
										FROM NhaCungCap 
										WHERE MaNhaCungCap NOT IN(SELECT NHNCC1.MaNhaCungCap 
																	FROM NHAHANG_NHACUNGCAP NHNCC1 
																	WHERE NHNCC1.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+')) AS T1 
										LEFT JOIN 
											  (SELECT NHNCC2.MaNhaCungCap,NHNCC2.TongNo
												FROM NHAHANG_NHACUNGCAP NHNCC2
												WHERE NHNCC2.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+') AS T2 
										ON T1.MaNhaCungCap=T2.MaNhaCungcap) AS T3 
								JOIN NHACUNGCAP T4 ON T3.MaNhaCungCap=T4.MaNhaCungCap'
		if @ten !=''
			Set @SQLQuery = @SQLQuery + ' WHERE CONVERT(nvarchar,T3.MaNhaCungCap)='''+@ten+''' OR T4.TenNhaCungCap LIKE N''%'+@ten+'%'' '
		Set @SQLQuery = @SQLQuery + ' )'
    Execute sp_Executesql @SQLQuery
	WAITFOR DELAY '00:00:10'
	Execute sp_Executesql @SQLQuery
	COMMIT
	END
GO
CREATE PROCEDURE dbo.lostUpdateSolvedXuatNguyenLieu
	(
	@soLuongXuat int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
	SET TRAN ISOLATION LEVEL READ COMMITTED
	BEGIN TRAN
		Declare @SQLQuery int
		Declare @maKhoHang int
		Declare @soLuongTonOld int

		Set @maKhoHang = (SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang=@maNhaHang)
		Set @soLuongTonOld = (SELECT SoLuongTon FROM KHOHANG_NGUYENLIEU WHERE MaNguyenLieu=@maNguyenLieu AND MaKhoHang=@maKhoHang)
		
		waitfor delay '00:00:05'

		UPDATE KHOHANG_NGUYENLIEU 
							SET SoLuongTon=(select @soLuongTonOld - @soLuongXuat)
							 WHERE MaKhoHang=@maKhoHang
									 AND MaNguyenLieu=@maNguyenLieu
	COMMIT
	END
GO
CREATE PROCEDURE dbo.lostUpdatedSolvedXuatNguyenLieu
	(
	@soLuongXuat int,
	@maNguyenLieu int,
	@maNhaHang int,
	@mucCoLap int
	)
AS
	BEGIN
	IF @mucCoLap=0
		SET TRAN ISOLATION LEVEL SERIALIZABLE
	ELSE IF @mucCoLap=1
		SET TRAN ISOLATION LEVEL READ UNCOMMITTED
	ELSE IF @mucCoLap=2
		SET TRAN ISOLATION LEVEL READ COMMITTED
	ELSE IF @mucCoLap=3
		SET TRAN ISOLATION LEVEL REPEATABLE READ
	ELSE IF @mucCoLap=4
		SET TRAN ISOLATION LEVEL SERIALIZABLE
	
		Declare @SQLQuery int
		Declare @maKhoHang int
		Declare @soLuongTonOld int

		Set @maKhoHang = (SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang=@maNhaHang)
		RETRY:
		BEGIN TRAN
		BEGIN TRY
		Set @soLuongTonOld = (SELECT SoLuongTon FROM KHOHANG_NGUYENLIEU WHERE MaNguyenLieu=@maNguyenLieu AND MaKhoHang=@maKhoHang)
			
		waitfor delay '00:00:03'

		UPDATE KHOHANG_NGUYENLIEU 
							SET SoLuongTon=(select @soLuongTonOld - @soLuongXuat)
							 WHERE MaKhoHang=@maKhoHang
									 AND MaNguyenLieu=@maNguyenLieu
		COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN IF ERROR_NUMBER()=1205
				BEGIN
					WAITFOR DELAY '00:00:03'
					GOTO RETRY
					END
		END CATCH
	END
GO
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
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonSolveLostUpdate
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
CREATE PROCEDURE dbo.DirtyReadSolvedT2SetNgungGiaoDich
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@maNhaCungCap int,
	@maNhaHang int,
	@tinhTrang int,
	@isRollback int output
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Declare @error int
		SET TRAN ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
		Set @SQLQuery = N'UPDATE NHAHANG_NHACUNGCAP 
							SET TinhTrang='+CONVERT(nvarchar,@tinhTrang)+
							'WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+
									' AND MaNhaCungCap='+CONVERT(nvarchar,@maNhaCungCap)
		Execute sp_Executesql @SQLQuery
		WAITFOR DELAY '00:00:07'
		/*Gia su qua trinh truy van toi day thi gap error */
		SET @error=1
		
		/*Neu co error thi rollback*/
		if @error=1
			BEGIN
				ROLLBACK
				/*Gia tri tra ve la -1*/
				SET @isRollback = -1
				RETURN
			END
		/* Nguoc lại*/
		ELSE
			BEGIN
				SET @isRollback = 0
				COMMIT
				RETURN
			END 
END
GO
CREATE PROCEDURE dbo.DirtyReadSolvedT1TimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichNgungGiaoDich
	(
	@ten nvarchar(500),
	@tinhTrangGiaoDich int,
	@maNhaHang int
	)
AS
	
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
		Set @SQLQuery = N'( SELECT NHNCC.MaNhaCungCap,NCC.TenNhaCungCap,NCC.DienThoai,NCC.SoTaiKhoan, NHNCC.TongNo
							FROM NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap
							WHERE NHNCC.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)
		Set @tinhTrangGiaoDich = 1;
		if @ten !=''
			Set @SQLQuery = @SQLQuery + ' AND (CONVERT(nvarchar,NCC.MaNhaCungCap)='''+@ten+''' OR NCC.TenNhaCungCap LIKE N''%'+@ten+'%'') '
		if @tinhTrangGiaoDich=1
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=0)'
		if @tinhTrangGiaoDich=2
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=1)'
    Execute sp_Executesql @SQLQuery
	COMMIT
GO
CREATE PROCEDURE dbo.deadlockSolvedXuatNguyenLieu
	(
	@soLuongXuat int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	BEGIN TRAN
		SET LOCK_TIMEOUT 1800
		Declare @SQLQuery int
		Declare @maKhoHang int
		Declare @soLuongTonOld int

		Set @maKhoHang = (SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang=@maNhaHang)
		Set @soLuongTonOld = (SELECT SoLuongTon FROM KHOHANG_NGUYENLIEU WHERE MaNguyenLieu=@maNguyenLieu AND MaKhoHang=@maKhoHang)
		
		waitfor delay '00:00:05'

		UPDATE KHOHANG_NGUYENLIEU 
							SET SoLuongTon=(select @soLuongTonOld - @soLuongXuat)
							 WHERE MaKhoHang=@maKhoHang
									 AND MaNguyenLieu=@maNguyenLieu
	COMMIT
	END
GO
CREATE PROCEDURE dbo.CnTimBanTrongSolvedUnRRead
(
	@MaNhaHang int = NULL,
	@MaKhuVuc int = NULL,
	@NgayDatBan datetime = NULL,
	@Buoi nvarchar(10) = NULL,
	@SoLuong int = NULL
)
AS
	SET TRANSACTION ISOLATION LEVEL  REPEATABLE READ 
	BEGIN TRANSACTION
	--BEGIN 
		Declare @SQLQuery nvarchar(4000)
		Declare @SQLLichBan nvarchar(4000)
        Set @SQLLichBan = N'(SELECT KV1.MaNhaHang, LB1.MaBan, LB1.MaBuoi, LB1.NgayDatBan, LB1.SoLuong
							FROM  KHUVUC AS KV1 INNER JOIN
									THONGTINBAN AS TB1 ON KV1.MaKhuVuc = TB1.MaKhuVuc INNER JOIN
									LICHBAN AS LB1 ON LB1.MaBan = TB1.MaBan
							WHERE  (THONGTINBAN.MaBan = LB1.MaBan) AND 
									EXISTS
										(SELECT MaLichBan, MaBan, NgayDatBan, MaBuoi, MaThongTinKhachHang, SoLuong, TinhTrangBan
										FROM  LICHBAN
										WHERE (MaBan = THONGTINBAN.MaBan)'
		If @Buoi Is Not Null
		BEGIN
			Set @SQLLichBan = @SQLLichBan + ' AND (MaBuoi = '+ CONVERT(nvarchar, @Buoi)+')'
			If (@NgayDatBan Is Not Null)
				Set @SQLLichBan = @SQLLichBan + ' AND (NgayDatBan = '''+CAST(@NgayDatBan AS nvarchar(20)) +''')'
			If @SoLuong Is Not Null
				Set @SQLLichBan = @SQLLichBan + ' AND (LB1.SoLuong >=  ' + CONVERT(nvarchar,@SoLuong)+')))'
			else 
				Set @SQLLichBan = @SQLLichBan + '))'
		END
		ELSE
		BEGIN
			Set @SQLLichBan = N'SELECT        LICHBAN_1.MaBan, LICHBAN_1.NgayDatBan, COUNT(BUOI.MaBuoi) AS SOBUOI
                               FROM            BUOI INNER JOIN
                                                         LICHBAN AS LICHBAN_1 ON BUOI.MaBuoi = LICHBAN_1.MaBuoi AND BUOI.MaBuoi = LICHBAN_1.MaBuoi
                               WHERE        (LICHBAN_1.MaBan = THONGTINBAN.MaBan)
                               GROUP BY LICHBAN_1.MaBan, LICHBAN_1.NgayDatBan
                               HAVING         (COUNT(BUOI.MaBuoi) =  (SELECT COUNT(*) AS TongSoBuoi
																	  FROM BUOI AS BUOI_1))'
		END

		
		--Set @SQLLichBan = @SQLLichBan + ') GROUP BY KV1.MaNhaHang, LB1.MaBan, LB1.MaBuoi, LB1.NgayDatBan, LB1.SoLuong)'
		
		Set @SQLQuery = N'SELECT KV.MaKhuVuc, LB.MaBan as MaBan, LB.SucChua as SucChua, KV.MaNhaHang as MaNhaHang, GiaBan FROM (SELECT MaBan, MaKhuVuc, SucChua FROM THONGTINBAN WHERE NOT EXISTS (' +@SQLLichBan +')) LB INNER JOIN KHUVUC KV ON LB.MaKhuVuc = KV.MaKhuVuc INNER JOIN NHAHANG NH ON KV.MaNhaHang = NH.MaNhaHang WHERE (1=1)'
				
		If @MaNhaHang Is Not Null 
			Set @SQLQuery = @SQLQuery + ' AND (KV.MaNhaHang = '+ CONVERT(nvarchar, @MaNhaHang)+')'

		If @MaKhuVuc Is Not Null 
			Set @SQLQuery = @SQLQuery + ' AND (KV.MaKhuVuc = '+ CONVERT(nvarchar, @MaKhuVuc)+')'

		Set @SQLQuery = @SQLQuery + ' GROUP BY LB.MaBan, LB.SucChua, KV.MaKhuVuc, KV.MaNhaHang, GiaBan';	
		set @SQLQuery = @SQLQuery +' WAITFOR DELAY ''00:00:20''' +@SQLQuery
    Execute sp_Executesql @SQLQuery
	
		COMMIT
----
GO
CREATE PROCEDURE dbo.CnTimBanTrongSolvedPhanTom
(
	@MaNhaHang int = NULL,
	@MaKhuVuc int = NULL,
	@NgayDatBan datetime = NULL,
	@Buoi nvarchar(10) = NULL,
	@SoLuong int = NULL
)
AS
	SET TRANSACTION ISOLATION LEVEL  SERIALIZABLE
	BEGIN TRANSACTION
	--BEGIN 
		Declare @SQLQuery nvarchar(4000)
		Declare @SQLLichBan nvarchar(4000)
        Set @SQLLichBan = N'(SELECT KV1.MaNhaHang, LB1.MaBan, LB1.MaBuoi, LB1.NgayDatBan, LB1.SoLuong
							FROM  KHUVUC AS KV1 INNER JOIN
									THONGTINBAN AS TB1 ON KV1.MaKhuVuc = TB1.MaKhuVuc INNER JOIN
									LICHBAN AS LB1 ON LB1.MaBan = TB1.MaBan
							WHERE  (THONGTINBAN.MaBan = LB1.MaBan) AND 
									EXISTS
										(SELECT MaLichBan, MaBan, NgayDatBan, MaBuoi, MaThongTinKhachHang, SoLuong, TinhTrangBan
										FROM  LICHBAN
										WHERE (MaBan = THONGTINBAN.MaBan)'
		If @Buoi Is Not Null
		BEGIN
			Set @SQLLichBan = @SQLLichBan + ' AND (MaBuoi = '+ CONVERT(nvarchar, @Buoi)+')'
			If (@NgayDatBan Is Not Null)
				Set @SQLLichBan = @SQLLichBan + ' AND (NgayDatBan = '''+CAST(@NgayDatBan AS nvarchar(20)) +''')'
			If @SoLuong Is Not Null
				Set @SQLLichBan = @SQLLichBan + ' AND (LB1.SoLuong >=  ' + CONVERT(nvarchar,@SoLuong)+')))'
			else 
				Set @SQLLichBan = @SQLLichBan + '))'
		END
		ELSE
		BEGIN
			Set @SQLLichBan = N'SELECT        LICHBAN_1.MaBan, LICHBAN_1.NgayDatBan, COUNT(BUOI.MaBuoi) AS SOBUOI
                               FROM            BUOI INNER JOIN
                                                         LICHBAN AS LICHBAN_1 ON BUOI.MaBuoi = LICHBAN_1.MaBuoi AND BUOI.MaBuoi = LICHBAN_1.MaBuoi
                               WHERE        (LICHBAN_1.MaBan = THONGTINBAN.MaBan)
                               GROUP BY LICHBAN_1.MaBan, LICHBAN_1.NgayDatBan
                               HAVING         (COUNT(BUOI.MaBuoi) =  (SELECT COUNT(*) AS TongSoBuoi
																	  FROM BUOI AS BUOI_1))'
		END

		
		--Set @SQLLichBan = @SQLLichBan + ') GROUP BY KV1.MaNhaHang, LB1.MaBan, LB1.MaBuoi, LB1.NgayDatBan, LB1.SoLuong)'
		
		Set @SQLQuery = N'SELECT KV.MaKhuVuc, LB.MaBan as MaBan, LB.SucChua as SucChua, KV.MaNhaHang as MaNhaHang, GiaBan FROM (SELECT MaBan, MaKhuVuc, SucChua FROM THONGTINBAN WHERE NOT EXISTS (' +@SQLLichBan +')) LB INNER JOIN KHUVUC KV ON LB.MaKhuVuc = KV.MaKhuVuc INNER JOIN NHAHANG NH ON KV.MaNhaHang = NH.MaNhaHang WHERE (1=1)'
				
		If @MaNhaHang Is Not Null 
			Set @SQLQuery = @SQLQuery + ' AND (KV.MaNhaHang = '+ CONVERT(nvarchar, @MaNhaHang)+')'

		If @MaKhuVuc Is Not Null 
			Set @SQLQuery = @SQLQuery + ' AND (KV.MaKhuVuc = '+ CONVERT(nvarchar, @MaKhuVuc)+')'

		Set @SQLQuery = @SQLQuery + ' GROUP BY LB.MaBan, LB.SucChua, KV.MaKhuVuc, KV.MaNhaHang, GiaBan';	
		set @SQLQuery = @SQLQuery +' WAITFOR DELAY ''00:00:20''' +@SQLQuery
    Execute sp_Executesql @SQLQuery
	
		COMMIT
GO
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
GO
