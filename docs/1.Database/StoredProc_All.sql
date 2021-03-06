CREATE PROCEDURE dbo.xuatNguyenLieu
	(
	@soLuongXuat int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery int
		Declare @maKhoHang int
		Declare @soLuongTonOld int

		Set @maKhoHang = (SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang=@maNhaHang)
		Set @soLuongTonOld = (SELECT SoLuongTon FROM KHOHANG_NGUYENLIEU WHERE MaNguyenLieu=@maNguyenLieu AND MaKhoHang=@maKhoHang)
		
		/*waitfor delay '00:00:05'*/

		UPDATE KHOHANG_NGUYENLIEU 
							SET SoLuongTon=(select @soLuongTonOld - @soLuongXuat)
							 WHERE MaKhoHang=@maKhoHang
									 AND MaNguyenLieu=@maNguyenLieu
	END
	GO
CREATE PROCEDURE dbo.XoaMonAnUnrpeatableRead
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
CREATE PROCEDURE dbo.XoaMonAnDirtyRead
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
CREATE PROCEDURE dbo.XoaMonAn
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
CREATE PROCEDURE dbo.updateChiTietKhoHangNguyenLieuT2
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@soLuongTon int,
	@chuaToiDa int,
	@chuaToiThieu int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION
		Set @SQLQuery = N'UPDATE KHOHANG_NGUYENLIEU 
							SET SoLuongTon='+CONVERT(nvarchar,@soLuongTon)+
								',SucChua='+CONVERT(nvarchar,@chuaToiDa)+
								',MucChuaToiThieu='+CONVERT(nvarchar,@chuaToiThieu)+
							'WHERE MaKhoHang=(SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+')'+
									' AND MaNguyenLieu='+CONVERT(nvarchar,@maNguyenLieu)
		
		
		Execute sp_Executesql @SQLQuery
		COMMIT
		
		
		
	END
	GO
CREATE PROCEDURE dbo.updateChiTietKhoHangNguyenLieu
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@soLuongTon int,
	@chuaToiDa int,
	@chuaToiThieu int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
		Declare @SQLQuery nvarchar(4000)
		Set @SQLQuery = N'UPDATE KHOHANG_NGUYENLIEU 
							SET SoLuongTon='+CONVERT(nvarchar,@soLuongTon)+
								',SucChua='+CONVERT(nvarchar,@chuaToiDa)+
								',MucChuaToiThieu='+CONVERT(nvarchar,@chuaToiThieu)+
							'WHERE MaKhoHang=(SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+')'+
									' AND MaNguyenLieu='+CONVERT(nvarchar,@maNguyenLieu)
		
		
		Execute sp_Executesql @SQLQuery
		
		
		GO
CREATE PROCEDURE dbo.UnrepeatableReadTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoGiaoDich
	(
	@ten nvarchar(500),
	@tinhTrangGiaoDich int,
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'( SELECT NHNCC.MaNhaCungCap,NCC.TenNhaCungCap,NCC.DienThoai,NCC.SoTaiKhoan, NHNCC.TongNo
							FROM NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap
							WHERE NHNCC.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)
		Set @tinhTrangGiaoDich = 2;
		if @ten !=''
			Set @SQLQuery = @SQLQuery + ' AND (CONVERT(nvarchar,NCC.MaNhaCungCap)='''+@ten+''' OR NCC.TenNhaCungCap LIKE N''%'+@ten+'%'') '
		if @tinhTrangGiaoDich=1
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=0)'
		if @tinhTrangGiaoDich=2
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=1)'
    Execute sp_Executesql @SQLQuery
	WAITFOR DELAY '00:00:05'
	Execute sp_Executesql @SQLQuery
	END

GO
CREATE PROCEDURE dbo.UnrepeatableReadT2setNgungGiaoDich
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@maNhaCungCap int,
	@maNhaHang int,
	@tinhTrang int
	)
AS
	
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
		Set @SQLQuery = N'UPDATE NHAHANG_NHACUNGCAP 
							SET TinhTrang='+CONVERT(nvarchar,@tinhTrang)+
							'WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+
									' AND MaNhaCungCap='+CONVERT(nvarchar,@maNhaCungCap)
		Execute sp_Executesql @SQLQuery
		COMMIT

GO
CREATE PROCEDURE dbo.UnrepeatableReadT1TimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoGiaoDich
	(
	@ten nvarchar(500),
	@tinhTrangGiaoDich int,
	@maNhaHang int
	)
AS
	
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ UNCOMMITTED
	BEGIN TRAN
		Set @SQLQuery = N'( SELECT NHNCC.MaNhaCungCap,NCC.TenNhaCungCap,NCC.DienThoai,NCC.SoTaiKhoan, NHNCC.TongNo
							FROM NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap
							WHERE NHNCC.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)
		Set @tinhTrangGiaoDich = 2;
		if @ten !=''
			Set @SQLQuery = @SQLQuery + ' AND (CONVERT(nvarchar,NCC.MaNhaCungCap)='''+@ten+''' OR NCC.TenNhaCungCap LIKE N''%'+@ten+'%'') '
		if @tinhTrangGiaoDich=1
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=0)'
		if @tinhTrangGiaoDich=2
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=1)'
    Execute sp_Executesql @SQLQuery
	WAITFOR DELAY '00:00:10'
	Execute sp_Executesql @SQLQuery
	COMMIT


GO
CREATE PROCEDURE dbo.UnrepeatableReadSolvedT1TimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoGiaoDich
	(
	@ten nvarchar(500),
	@tinhTrangGiaoDich int,
	@maNhaHang int
	)
AS
	
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL REPEATABLE READ
	BEGIN TRAN
		Set @SQLQuery = N'( SELECT NHNCC.MaNhaCungCap,NCC.TenNhaCungCap,NCC.DienThoai,NCC.SoTaiKhoan, NHNCC.TongNo
							FROM NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap
							WHERE NHNCC.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)
		Set @tinhTrangGiaoDich = 2;
		if @ten !=''
			Set @SQLQuery = @SQLQuery + ' AND (CONVERT(nvarchar,NCC.MaNhaCungCap)='''+@ten+''' OR NCC.TenNhaCungCap LIKE N''%'+@ten+'%'') '
		if @tinhTrangGiaoDich=1
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=0)'
		if @tinhTrangGiaoDich=2
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=1)'
    Execute sp_Executesql @SQLQuery
	WAITFOR DELAY '00:00:10'
	Execute sp_Executesql @SQLQuery
	COMMIT
GO
CREATE PROCEDURE dbo.traCuuNhaCungCapThoaYeuCauNguyenLieuCanDatHang
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@sqlFROM nvarchar(4000)
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)

	Set @SQLQuery = N'(SELECT A.MaNhaCungCap,NCC.TenNhaCungCap, COUNT(A.MaNhaCungCap) AS SoLuongNguyenLieuDapUng FROM ('+@sqlFROM+') AS A JOIN NHACUNGCAP NCC ON A.MaNhaCungCap=NCC.MaNhaCungCap
						GROUP BY A.MaNhaCungCap,NCC.TenNhaCungCap)'
		
END
	Execute sp_Executesql @SQLQuery
	
	RETURN

GO
CREATE PROCEDURE dbo.TinhTongHoaDonPhantom
(
	@MaHoaDon nvarchar(36)
)
AS
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION
		Declare @SQLQuery nvarchar(4000)
		Set @SQLQuery = N'SELECT SUM(HD.DonGia*SoLuong) AS ThanhTien FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
		Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		Execute sp_Executesql @SQLQuery
		WAITFOR DELAY '00:00:10'
		Execute sp_Executesql @SQLQuery
	COMMIT
	GO
CREATE PROCEDURE dbo.TimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang int = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.MaNhaHang, NH.TenNhaHang, NV.MaLoaiNhanVien, LNV.TenLoaiNhanVien, NV.Ho, NV.Ten, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam 
						FROM NHANVIEN AS NV INNER JOIN
							NHAHANG AS NH ON NV.MaNhaHang = NH.MaNhaHang INNER JOIN 
							LOAINHANVIEN LNV ON NV.MaLoaiNhanVien = LNV.MaLoaiNhanVien
						 WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'

		If @MaLoaiNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'

		If @Ho is not null
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten is not null
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = '''+@Ten+ ''')'
			
		If @CMND is not null
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi is not null
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = '''+@DiaChi+''')'

		If @DienThoai is not null
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not null
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '+CONVERT(nvarchar, @NgayVaoLam)+')'

    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung
	(
	@ten nvarchar(500),
	@tinhTrangGiaoDich int,
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'( SELECT NHNCC.MaNhaCungCap,NCC.TenNhaCungCap,NCC.DienThoai,NCC.SoTaiKhoan, NHNCC.TongNo
							FROM NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap
							WHERE NHNCC.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)

		if @ten !=''
			Set @SQLQuery = @SQLQuery + ' AND (CONVERT(nvarchar,NCC.MaNhaCungCap)='''+@ten+''' OR NCC.TenNhaCungCap LIKE N''%'+@ten+'%'') '
		if @tinhTrangGiaoDich=1
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=0)'
		if @tinhTrangGiaoDich=2
			Set @SQLQuery = @SQLQuery + ' AND NHNCC.TinhTrang=1)'
    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich
	(
	@ten nvarchar(500),
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
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
	END
GO
CREATE PROCEDURE dbo.timKiemNhaCungCap
	(
	@ten nvarchar(500),
	@tinhTrangGiaoDich int,
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(

							SELECT T3.MaNhaCungCap, T4.TenNhaCungCap, T4.DienThoai, T4.SoTaiKhoan, T3.TongNo, FROM (SELECT T1.MaNhaCungCap,T2.TongNo
							FROM 

							((SELECT NHNCC.MaNhaCungCap
														FROM NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap
														WHERE NHNCC.MaNhaHang=1) UNION ALL (SELECT MaNhaCungCap FROM NhaCungCap WHERE MaNhaCungCap NOT IN(SELECT MaNhaCungCap FROM NHAHANG_NHACUNGCAP WHERE MaNhaHang=1))) AS T1 LEFT JOIN 
																				(SELECT MaNhaCungCap,TongNo 
																					FROM NHAHANG_NHACUNGCAP 
																					WHERE MaNhaHang=1) AS T2 
																						ON T1.MaNhaCungCap=T2.MaNhaCungCap) AS T3
							JOIN NHACUNGCAP T4 ON T3.MaNhaCungCap=T4.MaNhaCungCap
							

							)'

    Execute sp_Executesql @SQLQuery
	END
GO
----
CREATE PROCEDURE dbo.TimBanTrong
(
	@MaNhaHang int = NULL,
	@MaKhuVuc int = NULL,
	@NgayDatBan datetime = NULL,
	@Buoi nvarchar(10) = NULL,
	@SoLuong int = NULL
)
AS
	BEGIN
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
			
    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.TimBan
(
	@MaNhaHang int,
	@MaBan int  = NULL,
	@TenBan nvarchar(50) = NULL,
	@Ngay datetime = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT MaNhaHang, MaLichBan, LB.MaBan, HoTen, CMND, DienThoai, NgayDatBan, LB.MaBuoi, B.TenBuoi, TinhTrangBan FROM KHUVUC KV JOIN THONGTINBAN TTB ON KV.MaKhuVuc = TTB.MaKhuVuc JOIN LICHBAN LB ON TTB.MaBan = LB.MaBan JOIN THONGTINKHACHHANG KH ON LB.MaThongTinKhachHang = KH.MaThongTinKhachHang JOIN BUOI B ON B.MaBuoi = LB.MaBuoi
						 WHERE (1=1) AND MaNhaHang = ' + CONVERT(nvarchar, @MaNhaHang)
		
		If @MaBan != 0
			Set @SQLQuery = @SQLQuery + ' AND (LB.MaBan like ''%'+CONVERT(nvarchar, @MaBan)+'%'')'

		If @Ngay is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (LB.NgayDatBan = '+CONVERT(nvarchar, @Ngay)+')'

		If @TenBan is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (TTB.TenBan like ''%'+CONVERT(nvarchar, @TenBan)+'%'')'

    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.ThongTinKhachVaBanDat
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	select nh.MaNhaHang , tt.Hoten , tt.CMND, tt.DienThoai , lb.MaBan, lb.NgayDatBan,b.TenBuoi, kv.TenKhuVuc , lb.SoLuong,lb.TinhTrangBan ,lb.MaThongTinKhachHang,lb.MaLichBan , kv.MaKhuVuc 
	From NhaHang nh ,LichBan lb, ThongTinKhachHang tt,Buoi b , ThongTinBan ttb, KhuVuc kv 
	Where lb.MATHONGTINKHACHHANG = tt.MATHONGTINKHACHHANG and b.MaBuoi = lb.MaBuoi and ttb.MaBan = lb.MaBan and kv.MaKhuVuc = ttb.MaKhuVuc and nh.MaNhaHang = kv.MaNhaHang
	--and  MaLichBan = 7
	RETURN
GO
CREATE PROCEDURE dbo.themThongTinHangNhap
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@ngayNhap datetime,
	@maKhoHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'INSERT INTO THONGTINHANGNHAP(NgayGioNhap, MaKhoHang) VALUES ('''+CONVERT(nvarchar,@ngayNhap)+''','+CONVERT(nvarchar,@maKhoHang)+')'
	
    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.ThemThongTinBanDat
(
	@Loai int = 1,
	@HoTen nvarchar(50) = NULL,
	@CMND nvarchar(10) = NULL,
	@DienThoai varchar(50) = NULL,
	@MaBan int,
	@NgayDatBan datetime,
	@Buoi int,
	@SoLuong int,
	@TinhTrangBan bit = false
)
AS
BEGIN
	DECLARE @SQLQuery nvarchar(4000)
		
	-- Them thong tin khach hang
	IF @Loai = 1
	BEGIN
		INSERT INTO THONGTINKHACHHANG (HoTen, CMND, DienThoai) VALUES (''+@HoTen+'',''+@CMND+'',''+@DienThoai+'')
		DECLARE @MaThongTinKhachHang int
		SET @MaThongTinKhachHang = @@Identity
	END
	-- Them thong tin ban dat
	INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi, MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES(@MaBan, ''+@NgayDatBan+'', @Buoi, @MaThongTinKhachHang, @SoLuong, @TinhTrangBan)
END
GO
CREATE PROCEDURE dbo.ThemNhaCungCap
(
	@tenNhaCungCap nvarchar(300),
	@dienThoai nvarchar(300),
	@soTaiKhoan nvarchar(300)
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		/*Set @SQLQuery = N'INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan,MaThoiDiemGuiDS) VALUES ('''+@tenNhaCungCap+''','''+@dienThoai+''','''+@soTaiKhoan+''','+CONVERT(nvarchar,@maThoiDiemThanhToan)+','+CONVERT(nvarchar,@maThoiDiemGuiDS)+')'*/
		Set @SQLQuery = N'INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan,MaThoiDiemGuiDS) VALUES ('''+@tenNhaCungCap+''','''+@dienThoai+''','''+@soTaiKhoan+''',2,1)'
	
    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.ThemHoaDon
(
	@MaHoaDon nvarchar(36),
	@MaLichBan int,
	@NgayLapHoaDon datetime
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'INSERT INTO HOADON (MaHoaDon, MaLichBan, NgayLapHoaDon, DaThanhToan) VALUES ('''+@MaHoaDon+''','+CONVERT(nvarchar, @MaLichBan)+','''+CONVERT(nvarchar, @NgayLapHoaDon)+''',''false'')'
	
    Execute sp_Executesql @SQLQuery
	END

GO
CREATE PROCEDURE dbo.themChiTietHangNhap
	(
	@maNguyenLieu int,
	@maNhaCungCap int,
	@donGia decimal,
	@soLuong decimal,
	@maThongTinHangNhap int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'INSERT INTO CHITIETHANGNHAP(MaNguyenLieu, MaNhaCungCap,DonGia,SoLuong,TinhTrangGiaoHang,TinhTrangThanhToan,MaThongTinHangNhap) VALUES ('+CONVERT(nvarchar,@maNguyenLieu)+','+CONVERT(nvarchar,@maNhaCungCap)+','+CONVERT(nvarchar,@donGia)+','+CONVERT(nvarchar,@soLuong)+',0,0,'+CONVERT(nvarchar,@maThongTinHangNhap)+')'
	
    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.T2
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION

--WAITFOR DELAY '00:00:20'
DECLARE @BUBU INT
SET @BUBU = 1
while @BUBU = 1
begin
UPDATE NHANVIEN SET MaNhaHang = NULL WHERE MaNhanVien = 7

end
IF @@ERROR <> 0
 BEGIN
    ROLLBACK
   Return
 END

COMMIT
GO
CREATE PROCEDURE dbo.T1SolvedDirtyRead
AS
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION
SELECT MaNhanVien, MaNhaHang FROM NHANVIEN WHERE NHANVIEN.MaNhaHang IS NULL

IF @@ERROR <> 0
 BEGIN
    ROLLBACK
   Return
 END

COMMIT
GO
CREATE PROCEDURE dbo.T1DirtyRead
AS
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	BEGIN TRANSACTION
SELECT MaNhanVien, MaNhaHang FROM NHANVIEN WHERE NHANVIEN.MaNhaHang IS NULL

IF @@ERROR <> 0
 BEGIN
    ROLLBACK
   Return
 END

COMMIT
GO	
CREATE PROCEDURE dbo.setNgungGiaoDich
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@maNhaCungCap int,
	@maNhaHang int,
	@tinhTrang int
	)
AS
BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
			Set @SQLQuery = N'UPDATE NHAHANG_NHACUNGCAP 
								SET TinhTrang='+CONVERT(nvarchar,@tinhTrang)+
								'WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+
										' AND MaNhaCungCap='+CONVERT(nvarchar,@maNhaCungCap)
			Execute sp_Executesql @SQLQuery
		COMMIT
END
GO
CREATE PROCEDURE dbo.PhantomTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich
	(
	@ten nvarchar(500),
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		/*SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRANSACTION*/
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
	
	WAITFOR DELAY '00:00:15'

	Execute sp_Executesql @SQLQuery
	
	/*RETURN*/
	END
GO
CREATE PROCEDURE dbo.PhanTomT2ThemNhaCungCap
(
	@tenNhaCungCap nvarchar(300),
	@dienThoai nvarchar(300),
	@soTaiKhoan nvarchar(300)/*,
	@maThoiDiemThanhToan int,
	@maThoiDiemGuiDS int*/
)
AS
	BEGIN
		SET TRAN ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
		Declare @SQLQuery nvarchar(4000)
		
		/*Set @SQLQuery = N'INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan,MaThoiDiemGuiDS) VALUES ('''+@tenNhaCungCap+''','''+@dienThoai+''','''+@soTaiKhoan+''','+CONVERT(nvarchar,@maThoiDiemThanhToan)+','+CONVERT(nvarchar,@maThoiDiemGuiDS)+')'*/
		Set @SQLQuery = N'INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan,MaThoiDiemGuiDS) VALUES ('''+@tenNhaCungCap+''','''+@dienThoai+''','''+@soTaiKhoan+''',2,1)'
	
    Execute sp_Executesql @SQLQuery
	COMMIT
	END
GO
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
CREATE PROCEDURE dbo.lostUpdateXuatNguyenLieu
	(
	@soLuongXuat int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
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
	END
GO
CREATE PROCEDURE dbo.lostUpdateUpdateChiTietKhoHangNguyenLieuT2
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@soLuongTon int,
	@chuaToiDa int,
	@chuaToiThieu int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
		Set @SQLQuery = N'UPDATE KHOHANG_NGUYENLIEU 
							SET SoLuongTon='+CONVERT(nvarchar,@soLuongTon)+
								',SucChua='+CONVERT(nvarchar,@chuaToiDa)+
								',MucChuaToiThieu='+CONVERT(nvarchar,@chuaToiThieu)+
							'WHERE MaKhoHang=(SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+')'+
									' AND MaNguyenLieu='+CONVERT(nvarchar,@maNguyenLieu)
		
		Execute sp_Executesql @SQLQuery
		COMMIT
	END
GO
CREATE PROCEDURE dbo.lostUpdateUpdateChiTietKhoHangNguyenLieuT1
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@soLuongTon int,
	@chuaToiDa int,
	@chuaToiThieu int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
		Set @SQLQuery = N'UPDATE KHOHANG_NGUYENLIEU 
							SET SoLuongTon='+CONVERT(nvarchar,@soLuongTon)+
								',SucChua='+CONVERT(nvarchar,@chuaToiDa)+
								',MucChuaToiThieu='+CONVERT(nvarchar,@chuaToiThieu)+
							'WHERE MaKhoHang=(SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+')'+
									' AND MaNguyenLieu='+CONVERT(nvarchar,@maNguyenLieu)
		
		Execute sp_Executesql @SQLQuery
		WAITFOR DELAY '00:00:07'
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
CREATE PROCEDURE dbo.lostUpdatedXuatNguyenLieu
	(
	@soLuongXuat int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
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
CREATE PROCEDURE dbo.LayThongTinTaiKhoan
	@UserName nvarchar(50) = null,
	@Pass  nvarchar (50) = null
AS
	Begin 
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'Select ngd.ID,ngd.TenDangNhap, ngd.MatKhau,nv.CMND ,nv.MaLoaiNhanVien , nv.MaNhaHang
						  From NGUOIDUNG ngd , NHANVIEN nv , LOAINHANVIEN lnv , NhaHang nh 
						  Where ngd.MaNhanVien = nv.MaNhanVien and nh.MaNhaHang = nv.MaNhaHang
						  and lnv.MaLoaiNhanVien = nv.MaLoaiNhanVien'
		If @Pass is not null
			Set @SQLQuery = @SQLQuery + ' AND (ngd.MatKhau = '''+CONVERT(nvarchar, @Pass)+''')'
		If @UserName is not null
			Set @SQLQuery = @SQLQuery + ' AND (ngd.TenDangNhap = '''+CONVERT(nvarchar, @UserName)+''')'

	Execute sp_Executesql @SQLQuery
	End 	
	GO
CREATE PROCEDURE dbo.layThongTinNguyenLieuTheoNhaCungCap
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@maNguyenLieu int,
	@maNhaCungCap int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(SELECT NCCNL.MaNguyenLieu,NL.TenNguyenLieu,NCCNL.DonGia ,NL.DonViTinh
							FROM NHACUNGCAP_NGUYENLIEU NCCNL JOIN NGUYENLIEU NL ON NCCNL.MaNguyenLieu=NL.MaNguyenLieu 
							WHERE NCCNL.MaNguyenLieu='+CONVERT(nvarchar,@maNguyenLieu)+' AND NCCNL.MaNhaCungCap='+CONVERT(nvarchar,@maNhaCungCap)+')'
    Execute sp_Executesql @SQLQuery
	END
	GO
CREATE PROCEDURE dbo.layThongTinKhoHangTheoNhaHang
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@maNhaHang int
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)

	Set @SQLQuery = N'(SELECT MaKhoHang,TenKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+')'
		
END
	Execute sp_Executesql @SQLQuery
	RETURN
	GO
CREATE PROCEDURE dbo.LayThongTinKhoHangTheoNguyenLieu
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@MaNguyenLieu int,
	@MaNhaHang int
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'(SELECT * 
							FROM KHOHANG_NGUYENLIEU
							WHERE MaKhoHang IN (SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar, @MaNhaHang)+') 
									AND MaNguyenLieu=' +CONVERT(nvarchar, @MaNguyenLieu)+')'
END
	Execute sp_Executesql @SQLQuery
	RETURN
	GO
CREATE PROCEDURE dbo.LayTaiKhoan
AS
	begin
		select TenDangNhap , MatKhau ,MaNhanVien From NguoiDung
	end 
GO
CREATE PROCEDURE dbo.LayNhanVien
AS
	select nv.MaNhaHang, nv.MaNhanVien, nv.Ho, nv.Ten, lnv.TenLoaiNhanVien,nv.MaLoaiNhanVien, nv.CMND From NHANVIEN nv , NHAHANG nh , LOAINHANVIEN lnv 
		   where nv.MaNhaHang = nh.MaNhaHang and
				nv.MaLoaiNhanVien = lnv.MaLoaiNhanVien 
								/*and @maLoaiNhanVien = lnv.MaLoaiNhanVien
				and nv.MaNhanVien not in( select nd.MaNhanVien from NGUOIDUNG nd)*/
			 GO
			 
CREATE PROCEDURE dbo.LayLoaiNhanVien
AS
	begin
		Select MaLoaiNhanVien , TenLoaiNhanVien , Luong From LOAINHANVIEN
	end
GO
CREATE PROCEDURE dbo.layIDThongTinHangNhap
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@ngayGioNhap datetime,
	@maKhoHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(SELECT MaThongTinHangNhap FROM THONGTINHANGNHAP WHERE MaKhoHang='+CONVERT(nvarchar,@maKhoHang)+' AND NgayGioNhap='''+CONVERT(nvarchar,@ngayGioNhap)+''')'
	
    Execute sp_Executesql @SQLQuery
	END
	GO
	----
CREATE PROCEDURE dbo.LayDanhSachThongTinBan
(
	@MaKhuVuc int = 0
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT MaBan, TenBan, MaKhuVuc, SucChua FROM THONGTINBAN WHERE (1=1)'
		
		If @MaKhuVuc != 0
			Set @SQLQuery = @SQLQuery + ' AND (MaKhuVuc = '+CONVERT(nvarchar, @MaKhuVuc)+')'

    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.LayDanhSachNhanVien
/*(
	@maNhaHang int 
	@maLoaiNhanVien int
)*/ 
AS
	select nv.MaNhaHang , nv.MaNhanVien, nv.Ten, lnv.TenLoaiNhanVien, nv.CMND From NHANVIEN nv , NHAHANG nh , LOAINHANVIEN lnv 
		   where nv.MaNhaHang = nh.MaNhaHang and
				nv.MaLoaiNhanVien = lnv.MaLoaiNhanVien 
				/*and @maNhaHang = nh.MaNhaHang
				and @maLoaiNhanVien = lnv.MaLoaiNhanVien*/
				and nv.MaNhanVien not in( select nd.MaNhanVien from NGUOIDUNG nd)

GO
----
CREATE PROCEDURE dbo.LayDanhSachNhaHang
AS
	SELECT MaNhaHang, TenNhaHang, DienThoai, DiaChi FROM NHAHANG
GO
CREATE PROCEDURE dbo.layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoThoiDiemThanhToan
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(SELECT NHNCC.MaNhaCungCap,NCC.TenNhaCungCap,NCC.DienThoai,NCC.SoTaiKhoan,NHNCC.TongNo,TDTT.ThoiDiemThanhToan,NCC.MaThoiDiemThanhToan
							FROM (NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap) JOIN THOIDIEMTHANHTOAN TDTT ON NCC.MaThoiDiemThanhToan=TDTT.MaThoiDiemThanhToan
							WHERE NHNCC.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+' AND 
							(
							(''15:00:00''<=CONVERT(TIME,GETDATE()) AND CONVERT(TIME,GETDATE())<=''23:59:00'' AND NCC.MaThoiDiemThanhToan=2)
							OR 
							(6<=DATEPART(dw,GETDATE()) AND DATEPART(dw,GETDATE())<=7 AND NCC.MaThoiDiemThanhToan=2)
							OR 
							(27<=DAY(GETDATE()) AND DAY(GETDATE())<=DAY(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) AND NCC.MaThoiDiemThanhToan=3)
							) AND NHNCC.TongNo>0)'
		
    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoDinhMucNo
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(SELECT NHNCC.MaNhaCungCap,NCC.TenNhaCungCap,NCC.DienThoai,NCC.SoTaiKhoan,NHNCC.TongNo,TDTT.ThoiDiemThanhToan,NCC.MaThoiDiemThanhToan,T4.IDNgayApDung,T4.GiaTriDinhMuc
							FROM ((NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap) JOIN (SELECT T1.MaNhaCungCap,T1.IDNgayApDung,T2.GiaTriDinhMuc FROM (select MaNhaCungCap,MAX(ID) AS IDNgayApDung FROM DINHMUCNO GROUP BY MaNhaCungCap) AS T1 JOIN DINHMUCNO T2 ON T1.IDNgayApDung=T2.ID) AS T4 ON NCC.MaNhaCungCap=T4.MaNhaCungCap) JOIN THOIDIEMTHANHTOAN TDTT ON NCC.MaThoiDiemThanhToan=TDTT.MaThoiDiemThanhToan
							WHERE NHNCC.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+' AND NCC.MaThoiDiemThanhToan=1 AND NHNCC.TongNo>=T4.GiaTriDinhMuc)'
		
    Execute sp_Executesql @SQLQuery
	END
	GO
CREATE PROCEDURE dbo.layDanhSachNhaCungCapToiHanDuocThanhToanNo
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(SELECT NHNCC.MaNhaCungCap
							FROM NHAHANG_NHACUNGCAP NHNCC
							WHERE NHNCC.MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+' AND NHNCC.TinhTrang=1 )'
		

		Set @SQLQuery = @SQLQuery + ')'
    Execute sp_Executesql @SQLQuery
	END





SELECT NHNCC.MaNhaCungCap
from NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP NCC ON NHNCC.MaNhaCungCap=NCC.MaNhaCungCap
where NHNCC.MaNhaHang=1 AND 
(
('15:00:00'<=CONVERT(TIME,GETDATE()) AND CONVERT(TIME,GETDATE())<='23:59:00' AND NCC.MaThoiDiemThanhToan=2)
OR 
(6<=DATEPART(dw,GETDATE()) AND DATEPART(dw,GETDATE())<=7 AND NCC.MaThoiDiemThanhToan=2)
OR 
(27<=DAY(GETDATE()) AND DAY(GETDATE())<=DAY(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0))) AND NCC.MaThoiDiemThanhToan=3)
) AND NHNCC.TongNo>0


SELECT DAY(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0)))
GO
CREATE PROCEDURE dbo.layDanhSachNhaCungCap
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
	@MaNhaHang int,/*de lay TongNo neu co, nhung NCC khac - ko giao dich voi nha hang nay thi tong no = null*/
	@ten nvarchar(500)
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(SELECT T1.MaNhaCungCap,T1.TenNhaCungCap, T1.DienThoai,T1.SoTaiKhoan,T1.TongNo,T2.TinhTrang FROM (SELECT  NCC.MaNhaCungCap,NCC.TenNhaCungCap,NCC.DienThoai,NCC.SoTaiKhoan,A.TongNo
							FROM NHACUNGCAP NCC 
												LEFT JOIN 
												(SELECT MaNhaCungCap,TongNo 
														FROM NHAHANG_NHACUNGCAP 
														WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+')
												AS A ON NCC.MaNhaCungCap=A.MaNhaCungCap'
		if @ten != ''
			Set @SQLQuery = @SQLQuery + ' WHERE (CONVERT(nvarchar,NCC.MaNhaCungCap)='''+@ten+''' OR NCC.TenNhaCungCap LIKE N''%'+@ten+'%'')'

		Set @SQLQuery = @SQLQuery + ') AS T1 LEFT JOIN (SELECT MaNhaCungCap,TinhTrang FROM NHAHANG_NHACUNGCAP WHERE MaNhaHang='+CONVERT(nvarchar,@maNhaHang)+') AS T2 ON T1.MaNhaCungCap=T2.MaNhaCungCap )'
    Execute sp_Executesql @SQLQuery
	END

GO
CREATE PROCEDURE dbo.LayDanhSachNguyenLieuTheoMonAnGanDung
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@Key nvarchar,
		@MaKhoHang int
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'(SELECT MANL.MaNguyenLieu, NL.TenNguyenLieu, MANL.SoLuong, NL.DonViTinh 
							FROM MONAN_NGUYENLIEU MANL JOIN NGUYENLIEU NL
								ON MANL.MaNguyenLieu = NL.MaNguyenLieu'
	IF @Key!=null
		BEGIN
			Set @SQLQuery = @SQLQuery + ' WHERE MANL.MaKhoHang='+@MaKhoHang+' AND MANL.MaNguyenLieu LIKE %'+@Key +'% OR NL.TenNguyenLieu LIKE %'+@Key+'%)'
		END
	ELSE
		BEGIN
			Set @SQLQuery = @SQLQuery + ')'
		END
		
END
	Execute sp_Executesql @SQLQuery
	RETURN
	GO
CREATE PROCEDURE dbo.LayDanhSachNguyenLieuTheoMonAn
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaMonAn int
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'(SELECT MANL.MaNguyenLieu, NL.TenNguyenLieu, MANL.SoLuong, NL.DonViTinh 
							FROM MONAN_NGUYENLIEU MANL JOIN NGUYENLIEU NL
								ON MANL.MaNguyenLieu = NL.MaNguyenLieu'
	IF @MaMonAn!=0
		BEGIN
			Set @SQLQuery = @SQLQuery + ' WHERE MANL.MaMonAn = '+CONVERT(nvarchar, @MaMonAn) +')'
		END
	ELSE
		BEGIN
			Set @SQLQuery = @SQLQuery + ')'
		END
		
END
	Execute sp_Executesql @SQLQuery
	RETURN
	GO
CREATE PROCEDURE dbo.layDanhSachNguyenLieuNhaCungCapCoTheDapUngTheoDonDatHang
	(
	@maNhaCungCap int,
	@sqlWHEREor nvarchar(3000)
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)

	Set @SQLQuery = N'(SELECT NCCNL.MaNguyenLieu, NL.TenNguyenLieu,NCCNL.DonGia, NL.DonViTinh
						FROM NHACUNGCAP_NGUYENLIEU NCCNL JOIN NGUYENLIEU NL ON NCCNL.MaNguyenLieu=NL.MaNguyenLieu
						WHERE NCCNL.MaNhaCungCap='+CONVERT(nvarchar,@maNhaCungCap)+'
						AND ('+@sqlWHEREor+'))'
		
END
	Execute sp_Executesql @SQLQuery
	RETURN

GO
CREATE PROCEDURE dbo.LayDanhSachNguyenLieuGanDung
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@Key nvarchar
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'(SELECT NL.MaNguyenLieu, NL.TenNguyenLieu, NL.DonViTinh 
							FROM NGUYENLIEU NL'
	IF @Key!=null
		BEGIN
			Set @SQLQuery = @SQLQuery + ' WHERE NL.MaNguyenLieu LIKE %'+@Key +'% OR NL.TenNguyenLieu LIKE %'+@Key+'%)'
		END
	ELSE
		BEGIN
			Set @SQLQuery = @SQLQuery + ')'
		END
		
END
	Execute sp_Executesql @SQLQuery
	RETURN
	GO
CREATE PROCEDURE dbo.layDanhSachNguyenLieuDangOKhoangMucToiThieu
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaNhaHang int
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'(SELECT KHNL.MaNguyenLieu, NL.TenNguyenLieu, KHNL.SucChua, KHNL.SoLuongTon, KHNL.MucChuaToiThieu, NL.DonViTinh 
							FROM KHOHANG_NGUYENLIEU KHNL JOIN NGUYENLIEU NL
								ON KHNL.MaNguyenLieu = NL.MaNguyenLieu
							WHERE KHNL.MaKhoHang=(SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar, @MaNhaHang)+') 
									AND KHNL.SoLuongTon <= KHNL.MucChuaToiThieu)'
		
END
	Execute sp_Executesql @SQLQuery
	RETURN
	GO
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonUnRepeatableRead
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
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonPhantom
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
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonLostUpdate
(
	@MaHoaDon nvarchar(36)
)
AS
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRANSACTION
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
	Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		
	Execute sp_Executesql @SQLQuery
	COMMIT
	GO
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDonDirtyRead
(
	@MaHoaDon nvarchar(36)
)
AS

	Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	BEGIN TRANSACTION
		Set @SQLQuery = N'SELECT MaChiTietHoaDon, TD.MaMonAn, MA.TenMonAn, HD.DonGia, HD.MaChiTietThucDon, SoLuong FROM CHITIETHOADON HD JOIN CHITIETTHUCDON TD ON HD.MaChiTietThucDon = TD.MaChiTietThucDon JOIN MONAN MA ON MA.MaMonAn = TD.MaMonAn WHERE (1=1)'
		Set @SQLQuery = @SQLQuery + ' AND HD.MaHoaDon = ''' + @MaHoaDon + ''''
		
	Execute sp_Executesql @SQLQuery

	RETURN
GO
CREATE PROCEDURE dbo.LayDanhSachMonAnTrongHoaDon
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
	COMMIT
	GO
	CREATE PROCEDURE dbo.LayDanhSachMonAnTheoPhanLoaiMonAn
(
	@MaNhaHang int,
	@MaLoaiMonAn int
)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'(SELECT PLMA.MaNhaHang, PLMA.MaLoaiMonAn, PLMA.MaMonAn, MA.TenMonAn 
							FROM PHANLOAIMONAN PLMA JOIN MONAN MA
								ON PLMA.MaMonAn = MA.MaMonAn
							WHERE PLMA.MaNhaHang = ' + CONVERT(nvarchar, @MaNhaHang)
	IF @MaLoaiMonAn!=0
		BEGIN
			Set @SQLQuery = @SQLQuery + ' AND PLMA.MaLoaiMonAn = '+CONVERT(nvarchar, @MaLoaiMonAn) +')';
		END
	ELSE
		BEGIN
			Set @SQLQuery = @SQLQuery + ')'
		END
		
END
	Execute sp_Executesql @SQLQuery
	RETURN

GO
CREATE PROCEDURE dbo.LayDanhSachMonAnTheoNhaHang
(
	@MaNhaHang int,
	@Ngay datetime
)
AS
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	BEGIN TRANSACTION
	Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'(SELECT TOP 1 MaThucDon FROM THUCDON WHERE (MaNhaHang = ' + CONVERT(nvarchar, @MaNhaHang)+') AND (NgayApDung <= '''+CONVERT(nvarchar, @Ngay)+''')) TD'
		
		Set @SQLQuery = N'SELECT CT.MaMonAn, MA.TenMonAn, CT.DonGia, MaChiTietThucDon FROM '+@SQLQuery+' JOIN CHITIETTHUCDON CT ON TD.MaThucDon = CT.MaThucDon JOIN MONAN MA ON MA.MaMonAn = CT.MaMonAn WHERE (1=1)'
	Execute sp_Executesql @SQLQuery
	COMMIT
GO
CREATE PROCEDURE dbo.LayDanhSachLoaiNhanVien
AS
	SELECT MaLoaiNhanVien, TenLoaiNhanVien, Luong FROM LOAINHANVIEN
GO
CREATE PROCEDURE dbo.LayDanhSachLoaiMonAn
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT * FROM LOAIMONAN
GO
CREATE PROCEDURE dbo.LayDanhSachKhuVuc
(
	@MaNhaHang int = 0
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT MaKhuVuc, TenKhuVuc,  GiaBan FROM KHUVUC KV JOIN NHAHANG NH ON KV.MaNhaHang = NH.MaNhaHang WHERE (1=1)'
		
		If @MaNhaHang != 0
			Set @SQLQuery = @SQLQuery + ' AND (KV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'

    Execute sp_Executesql @SQLQuery
	END
GO
CREATE PROCEDURE dbo.LayDanhSachKhoHangNguyenLieuGanDung
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@Key nvarchar(500),
		@MaNhaHang int
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'(SELECT KHNL.MaNguyenLieu, NL.TenNguyenLieu, KHNL.SucChua, KHNL.SoLuongTon, KHNL.MucChuaToiThieu, NL.DonViTinh 
							FROM KHOHANG_NGUYENLIEU KHNL JOIN NGUYENLIEU NL
								ON KHNL.MaNguyenLieu = NL.MaNguyenLieu'
	IF @Key is not null
		BEGIN
			Set @SQLQuery = @SQLQuery + ' WHERE KHNL.MaKhoHang=(SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar, @MaNhaHang)+') AND (NL.TenNguyenLieu LIKE N''%'+@key+'%'' OR CONVERT(nvarchar,KHNL.MaNguyenLieu) LIKE N''%'+@key+'%''))'
		END
	ELSE
		BEGIN
			Set @SQLQuery = @SQLQuery + ')'
		END
		
END
	Execute sp_Executesql @SQLQuery
	RETURN
GO
CREATE PROCEDURE dbo.LayDanhSachBuoi
AS
	SELECT MaBuoi, TenBuoi FROM BUOI
GO
CREATE PROCEDURE dbo.LayDanhSachBanDat
AS
	SELECT MaLichBan, MaBan, NgayDatBan, MaBuoi, MaThongTinKhachHang, SoLuong, TinhTrangBan FROM LICHBAN
GO
CREATE PROCEDURE dbo.layChiTietKhoHangNguyenLieu
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
	(
		@MaNguyenLieu int,
		@MaNhaHang int
	)
AS
BEGIN
	Declare @SQLQuery nvarchar(4000)
	Set @SQLQuery = N'(SELECT KHNL.MaNguyenLieu, NL.TenNguyenLieu, KHNL.SucChua, KHNL.SoLuongTon, KHNL.MucChuaToiThieu, NL.DonViTinh 
							FROM KHOHANG_NGUYENLIEU KHNL JOIN NGUYENLIEU NL
								ON KHNL.MaNguyenLieu = NL.MaNguyenLieu
							WHERE KHNL.MaKhoHang=(SELECT MaKhoHang FROM KHOHANG WHERE MaNhaHang='+CONVERT(nvarchar, @MaNhaHang)+') '
	IF @MaNguyenLieu is not null
		BEGIN
			Set @SQLQuery = @SQLQuery + ' AND KHNL.MaNguyenLieu='+CONVERT(nvarchar,@MaNguyenLieu)+')'
		END
	ELSE
		BEGIN
			Set @SQLQuery = @SQLQuery + ')'
		END
		
END
	Execute sp_Executesql @SQLQuery
	RETURN
	GO
CREATE PROCEDURE dbo.KiemTraHoaDon
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
CREATE PROCEDURE dbo.DirtyReadT2SetNgungGiaoDich
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
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRANSACTION
		
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
CREATE PROCEDURE dbo.DirtyReadT1TimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichNgungGiaoDich
	(
	@ten nvarchar(500),
	@tinhTrangGiaoDich int,
	@maNhaHang int
	)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRANSACTION
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
	END

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
CREATE PROCEDURE dbo.deadlockXuatNguyenLieu
	(
	@soLuongXuat int,
	@maNguyenLieu int,
	@maNhaHang int
	)
AS
	BEGIN
	SET TRAN ISOLATION LEVEL SERIALIZABLE
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
CREATE PROCEDURE dbo.CnTimBanTrongUnRRead
(
	@MaNhaHang int = NULL,
	@MaKhuVuc int = NULL,
	@NgayDatBan datetime = NULL,
	@Buoi nvarchar(10) = NULL,
	@SoLuong int = NULL
)
AS
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
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
CREATE PROCEDURE dbo.CnTimBanTrongPhanTom
(
	@MaNhaHang int = NULL,
	@MaKhuVuc int = NULL,
	@NgayDatBan datetime = NULL,
	@Buoi nvarchar(10) = NULL,
	@SoLuong int = NULL
)
AS
	SET TRANSACTION ISOLATION LEVEL  Read uncommitted
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
CREATE PROCEDURE dbo.CnThemThongTinKhachVaBanPhamTom
	(
	@Loai int = 1,
	@HoTen nvarchar(50) = NULL,
	@CMND nvarchar(10) = NULL,
	@DienThoai varchar(50) = NULL,
	@MaBan int,
	@NgayDatBan datetime,
	@Buoi int,
	@SoLuong int,
	@TinhTrangBan bit = false
)
AS
		SET TRANSACTION ISOLATION LEVEL  READ COMMITTED
BEGIN TRANSACTION
	DECLARE @SQLQuery nvarchar(4000)
		
	-- Them thong tin khach hang
	IF @Loai = 1
	BEGIN
		INSERT INTO THONGTINKHACHHANG (HoTen, CMND, DienThoai) VALUES (''+@HoTen+'',''+@CMND+'',''+@DienThoai+'')
		DECLARE @MaThongTinKhachHang int
		SET @MaThongTinKhachHang = @@Identity
	END
	-- Them thong tin ban dat
	INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi, MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES(@MaBan, ''+@NgayDatBan+'', @Buoi, @MaThongTinKhachHang, @SoLuong, @TinhTrangBan)
	
	COMMIT
GO
CREATE PROCEDURE dbo.CnSolvedLostUpdate
	(
	@MaLichBan int,
	@NgayDat datetime,
	@SoLuong int,
	@MaBuoi int
	)
AS
	BEGIN TRANSACTION
		Declare @sql nvarchar(4000)
		set @sql = N'UPDATE LICHBAN with (RowLock,HoldLock) SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='''+convert(nvarchar,@NgayDat)+
					''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
		execute sp_Executesql @sql
		waitfor delay '00:00:20'
COMMIT
GO
CREATE PROCEDURE dbo.CnSolvedDirtyRead
(
	@MaNhaHang int = NULL,
	@MaKhuVuc int = NULL,
	@NgayDatBan datetime = NULL,
	@Buoi nvarchar(10) = NULL,
	@SoLuong int = NULL
)
AS
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION
	
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
			
    Execute sp_Executesql @SQLQuery
	
	
	COMMIT
GO
CREATE PROCEDURE dbo.CnLostUpDateT1ChuaXL
(
	@MaLichBan int,
	@NgayDat datetime,
	@SoLuong int,
	@MaBuoi int
	)
AS
	BEGIN TRANSACTION
		Declare @sql nvarchar(4000)
		set @sql = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='''+convert(nvarchar,@NgayDat)+
					''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
		waitfor delay '00:00:20'
		execute sp_Executesql @sql
	COMMIT
GO
CREATE PROCEDURE dbo.CnLostUpdate2
	(
		@MaLichBan int,
		@NgayDat datetime,
		@SoLuong int,
		@MaBuoi int
	)
AS
	/* SET NOCOUNT ON */
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		begin transaction
		declare @SQLQuery nvarchar(4000)
			set @SQLQuery = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='''+convert(nvarchar,@NgayDat)+
					''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
		execute sp_Executesql @SQLQuery
	COMMIT
GO
CREATE PROCEDURE dbo.CnLostUpdate
	(
	@MaLichBan int,
	@NgayDat datetime, -- 12
	@SoLuong int,
	@MaBuoi int -- 2
	)
AS
	/* SET NOCOUNT ON */
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	begin transaction
		declare @ngayDatBan datetime
		declare @Buoi int -- 1
		Declare @SQLQuery nvarchar(4000)
		-- lấy dữ liệu đã đc lưu trước đó lên để  so sánh
		Select @ngayDatBan = NgayDatBan From LichBan Where MaLichBan = ''+convert(nvarchar,@MaLichBan)+''
		Select @Buoi = MaBuoi From LichBan Where MaLichBan = ''+convert(nvarchar,@MaLichBan)+''

		if(@NgayDat <> @ngayDatBan and @Buoi <> @MaBuoi)
			set @SQLQuery = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+' ,SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='''+convert(nvarchar,@ngayDatBan)+
			''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
		execute sp_Executesql @SQLQuery 
	COMMIT 
		--if(@Buoi <> @MaBuoi)
		--begin 
		--	set @SQLQuery = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+' SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='''+convert(nvarchar,@ngayDatBan)+
			--''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
		--end

		--if(@MaBuoi =  @Buoi or @NgayDat = @ngayDatBan)
		--begin
			--set @SQLQuery = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',NgayDatBan ='''+convert(nvarchar,@ngayDatBan)+
				--	''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
		--end
		--execute sp_Executesql @SQLQuery
GO
CREATE PROCEDURE dbo.CnHuyThongTinKhachBanDatUnRRead
(
	@maLichBan int
)
AS
	
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED 
	BEGIN TRANSACTION
	declare @sql nvarchar(4000)
	set @sql = N'update LichBan set MaThongTinKhachHang = null , TinhTrangBan = 0 where MaLichBan = '+convert(nvarchar,@maLichBan)
	execute sp_executesql @sql
	COMMIT
GO
CREATE PROCEDURE dbo.CnDirtyReadT2
(
	@MaNhaHang int = NULL,
	@MaKhuVuc int = NULL,
	@NgayDatBan datetime = NULL,
	@Buoi nvarchar(10) = NULL,
	@SoLuong int = NULL
)
AS
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	BEGIN TRANSACTION
	BEGIN
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
			
    Execute sp_Executesql @SQLQuery
	END
	IF @@ERROR <> 0
	 BEGIN
		ROLLBACK
	   Return
	 END

	COMMIT
GO
CREATE PROCEDURE dbo.CnCapNhatThongTinBanDatUnRRead
	(
	@MaLichBan int,
	@NgayDat datetime,
	@SoLuong int,
	@MaBuoi int
	--@TinhTrangBan bit
	)
AS
	/* SET NOCOUNT ON */
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED  
	
	BEGIN TRANSACTION
	
		Declare @sql nvarchar(4000)
		set @sql = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='''+convert(nvarchar,@NgayDat)+
					''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
	execute sp_Executesql @sql
	
	--Waitfor delay '00:00:30' 
	--IF @@ERROR <> 0
	--BEGIN
	--	ROLLBACK
	--   Return
	-- END
	COMMIT
	GO
CREATE PROCEDURE dbo.CnCapNhatThongTinBanDatPhanTom
	(
	@MaLichBan int,
	@NgayDat datetime,
	@SoLuong int,
	@MaBuoi int
	--@TinhTrangBan bit
	)
AS
	/* SET NOCOUNT ON */
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED  
	
	BEGIN TRANSACTION
	
		Declare @sql nvarchar(4000)
		set @sql = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='''+convert(nvarchar,@NgayDat)+
					''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
	execute sp_Executesql @sql
	COMMIT
	GO
CREATE PROCEDURE dbo.CnCapNhatThongTinBanDatLostU
(
	@MaLichBan int,
	@NgayDat datetime,
	@SoLuong int,
	@MaBuoi int
)
AS
	/* SET NOCOUNT ON */
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED  
	
	BEGIN TRANSACTION
	
		Declare @sql nvarchar(4000)
		set @sql = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='+convert(nvarchar,@NgayDat,103)+
					' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
	execute sp_Executesql @sql
	
	Waitfor delay '00:00:30' 
	--IF @@ERROR <> 0
	BEGIN
		ROLLBACK
	   Return
	 END
	COMMIT
	GO
CREATE PROCEDURE dbo.CnCapNhatThongTinBanDatDefault
	(
	@MaLichBan int,
	@NgayDat datetime,
	@SoLuong int,
	@MaBuoi int
	--@TinhTrangBan bit
	)
AS
	/* SET NOCOUNT ON */
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  
	
	BEGIN TRANSACTION
	
		Declare @sql nvarchar(4000)
		set @sql = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan ='''+convert(nvarchar,@NgayDat)+
					''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
	execute sp_Executesql @sql
	COMMIT
	GO
CREATE PROCEDURE dbo.CnCapNhatThongTinBanDat
	(
	@MaLichBan int,
	@NgayDat datetime,
	@SoLuong int,
	@MaBuoi int
	--@TinhTrangBan bit
	)
AS
	/* SET NOCOUNT ON */
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED  
	BEGIN TRANSACTION
	
		Declare @sql nvarchar(4000)		
		--declare @tam datetime = new 
		set @sql = N'UPDATE LICHBAN SET MaBuoi = '+convert(nvarchar,@MaBuoi)+',SoLuong = '+convert(nvarchar,@SoLuong)+',NgayDatBan = '''+convert(nvarchar, @NgayDat) +--',TinhTrangBan ='+convert(nvarchar,@TinhTrangBan)+
					''' WHERE MaLichBan = ' + convert(nvarchar,@MaLichBan)
	execute sp_Executesql @sql
	
	Waitfor delay '00:00:20' 
	--IF @@ERROR <> 0
	BEGIN
		ROLLBACK
	   Return
	END
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
CREATE PROCEDURE dbo.CapNhatChiTietHoaDonLostUpdate
(
	@MaHoaDon nvarchar(36),
	@MaChiTietThucDon int,
	@DonGia decimal(18,2),
	@SoLuong int
)
AS
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
					WAITFOR DELAY '00:00:10'
					Set @SQLQuery = N'UPDATE CHITIETHOADON SET MaChiTietThucDon = ' + Convert(nvarchar,@MaChiTietThucDon) + ',DonGia = ' + Convert(nvarchar,@DonGia) + ',SoLuong =' + Convert(nvarchar,@SoLuong+@SoLuongCu) + ' WHERE MaChiTietHoaDon = ' + Convert(nvarchar,@MaChiTietHoaDon)
					Execute sp_Executesql @SQLQuery
				end
				
				GO
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
CREATE PROCEDURE dbo.CapNhatChiTietHoaDon
(
	@MaHoaDon nvarchar(36),
	@MaChiTietThucDon int,
	@DonGia decimal,
	@SoLuong int
)
AS
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	BEGIN TRANSACTION
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
	COMMIT
	GO
	CREATE PROCEDURE dbo.T58UnrepeatableTimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRAN
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    
	Execute sp_Executesql @SQLQuery
	WAITFOR DELAY '00:00:15'
	Execute sp_Executesql @SQLQuery
	COMMIT
	
	END
	
	GO
CREATE PROCEDURE dbo.T58UnrepeatableSolvedTimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL REPEATABLE READ
		BEGIN TRAN
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    
	Execute sp_Executesql @SQLQuery
	WAITFOR DELAY '00:00:15'
	Execute sp_Executesql @SQLQuery
	COMMIT
	
	END
	
	GO
CREATE PROCEDURE dbo.T58UnrepeatableEditThongTinNhanVien
	@MaNhanVien int,
	@MaNhaHang int,
	@MaLoaiNhanVien int,
	@Ho nvarchar(50) = null,
	@Ten nvarchar(20) = null,
	@CMND nvarchar(10) = null,
	@DiaChi nvarchar(50) = null,
	@DienThoai nvarchar(50) = null,
	@NgayVaoLam date,
	@TinhTrang nvarchar(1) = null
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN

		Set @SQLQuery = N'UPDATE NHANVIEN SET Ho = N'''+CONVERT(nvarchar,@Ho)+''', Ten = N'''+CONVERT(nvarchar,@Ten)+''', CMND = '''+CONVERT(nvarchar,@CMND)+''', DiaChi = N'''+CONVERT(nvarchar,@DiaChi)+''', DienThoai = '''+CONVERT(nvarchar,@DienThoai)+''', NgayVaoLam = '''+CONVERT(nvarchar,@NgayVaoLam)+''', TinhTrang = '''+CONVERT(nvarchar,@TinhTrang)+''''
		If @MaNhaHang != 0
			Set @SQLQuery = @SQLQuery + ', MaNhaHang =' + CONVERT(nvarchar,@MaNhaHang)
		Else
			Set @SQLQuery = @SQLQuery + ', MaNhaHang = NULL'
		If @MaLoaiNhanVien != 0
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien =' + CONVERT(nvarchar,@MaLoaiNhanVien)
		Else
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien = NULL'
			  
		Set @SQLQuery = @SQLQuery + ' WHERE MaNhanVien = '+CONVERT(nvarchar,@MaNhanVien)
			
		Execute sp_Executesql @SQLQuery
		COMMIT
	END
GO
CREATE PROCEDURE dbo.T58TimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    
	Execute sp_Executesql @SQLQuery

	
	END
	
	
GO
CREATE PROCEDURE dbo.T58SumNhanVien
	@MaNhaHang int
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Set @SQLQuery = N'SELECT COUNT(*) as Tong FROM NHANVIEN'
		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang is null'
		Else If @MaNhaHang = -1
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang like ''%'''
		Else
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang='+CONVERT(nvarchar,@MaNhaHang)
		Execute sp_Executesql @SQLQuery
		RETURN
	END
GO
CREATE PROCEDURE dbo.T58PhantomTimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    
	Execute sp_Executesql @SQLQuery

	
	WAITFOR DELAY '00:00:15'

	Execute sp_Executesql @SQLQuery

	END
	
	
GO
CREATE PROCEDURE dbo.T58PhantomSolvedTimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL SERIALIZABLE
		BEGIN TRAN
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    
	Execute sp_Executesql @SQLQuery
	WAITFOR DELAY '00:00:15'
	Execute sp_Executesql @SQLQuery
	COMMIT
	
	END
	
	
GO
CREATE PROCEDURE dbo.T58PhantomEditThongTinNhanVien
	@MaNhanVien int,
	@MaNhaHang int,
	@MaLoaiNhanVien int,
	@Ho nvarchar(50) = null,
	@Ten nvarchar(20) = null,
	@CMND nvarchar(10) = null,
	@DiaChi nvarchar(50) = null,
	@DienThoai nvarchar(50) = null,
	@NgayVaoLam date,
	@TinhTrang nvarchar(1) = null
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
		Set @SQLQuery = N'UPDATE NHANVIEN SET Ho = N'''+CONVERT(nvarchar,@Ho)+''', Ten = N'''+CONVERT(nvarchar,@Ten)+''', CMND = '''+CONVERT(nvarchar,@CMND)+''', DiaChi = N'''+CONVERT(nvarchar,@DiaChi)+''', DienThoai = '''+CONVERT(nvarchar,@DienThoai)+''', NgayVaoLam = '''+CONVERT(nvarchar,@NgayVaoLam)+''', TinhTrang = '''+CONVERT(nvarchar,@TinhTrang)+''''
		If @MaNhaHang != 0
			Set @SQLQuery = @SQLQuery + ', MaNhaHang =' + CONVERT(nvarchar,@MaNhaHang)
		Else
			Set @SQLQuery = @SQLQuery + ', MaNhaHang = NULL'
		If @MaLoaiNhanVien != 0
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien =' + CONVERT(nvarchar,@MaLoaiNhanVien)
		Else
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien = NULL'
			  
		Set @SQLQuery = @SQLQuery + ' WHERE MaNhanVien = '+CONVERT(nvarchar,@MaNhanVien)
			
		Execute sp_Executesql @SQLQuery
		COMMIT
	END
GO
CREATE PROCEDURE dbo.T58LostUpdateTimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRANSACTION
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    
	Execute sp_Executesql @SQLQuery
	COMMIT
	
	END
	
GO
CREATE PROCEDURE dbo.T58LostUpdateSolvedTimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    
	Execute sp_Executesql @SQLQuery

	
	END
	
GO
CREATE PROCEDURE dbo.T58LostUpdateSolvedEditThongTinNhanVien
	@MaNhanVien int,
	@MaNhaHang int,
	@MaLoaiNhanVien int,
	@Ho nvarchar(50) = null,
	@Ten nvarchar(20) = null,
	@CMND nvarchar(10) = null,
	@DiaChi nvarchar(50) = null,
	@DienThoai nvarchar(50) = null,
	@NgayVaoLam date,
	@TinhTrang nvarchar(1) = null
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ COMMITTED
		BEGIN TRAN
		WAITFOR DELAY '00:00:15'

		Set @SQLQuery = N'UPDATE NHANVIEN SET Ho = N'''+CONVERT(nvarchar,@Ho)+''', Ten = N'''+CONVERT(nvarchar,@Ten)+''', CMND = '''+CONVERT(nvarchar,@CMND)+''', DiaChi = N'''+CONVERT(nvarchar,@DiaChi)+''', DienThoai = '''+CONVERT(nvarchar,@DienThoai)+''', NgayVaoLam = '''+CONVERT(nvarchar,@NgayVaoLam)+''', TinhTrang = '''+CONVERT(nvarchar,@TinhTrang)+''''
		If @MaNhaHang != 0
			Set @SQLQuery = @SQLQuery + ', MaNhaHang =' + CONVERT(nvarchar,@MaNhaHang)
		Else
			Set @SQLQuery = @SQLQuery + ', MaNhaHang = NULL'
		If @MaLoaiNhanVien != 0
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien =' + CONVERT(nvarchar,@MaLoaiNhanVien)
		Else
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien = NULL'
			  
		Set @SQLQuery = @SQLQuery + ' WHERE MaNhanVien = '+CONVERT(nvarchar,@MaNhanVien)
			
		Execute sp_Executesql @SQLQuery
		COMMIT
	END
GO
CREATE PROCEDURE dbo.T58LostUpdateEditThongTinNhanVien
	@MaNhanVien int,
	@MaNhaHang int,
	@MaLoaiNhanVien int,
	@Ho nvarchar(50) = null,
	@Ten nvarchar(20) = null,
	@CMND nvarchar(10) = null,
	@DiaChi nvarchar(50) = null,
	@DienThoai nvarchar(50) = null,
	@NgayVaoLam date,
	@TinhTrang nvarchar(1) = null
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)

		WAITFOR DELAY '00:00:15'

		Set @SQLQuery = N'UPDATE NHANVIEN SET Ho = N'''+CONVERT(nvarchar,@Ho)+''', Ten = N'''+CONVERT(nvarchar,@Ten)+''', CMND = '''+CONVERT(nvarchar,@CMND)+''', DiaChi = N'''+CONVERT(nvarchar,@DiaChi)+''', DienThoai = '''+CONVERT(nvarchar,@DienThoai)+''', NgayVaoLam = '''+CONVERT(nvarchar,@NgayVaoLam)+''', TinhTrang = '''+CONVERT(nvarchar,@TinhTrang)+''''
		If @MaNhaHang != 0
			Set @SQLQuery = @SQLQuery + ', MaNhaHang =' + CONVERT(nvarchar,@MaNhaHang)
		Else
			Set @SQLQuery = @SQLQuery + ', MaNhaHang = NULL'
		If @MaLoaiNhanVien != 0
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien =' + CONVERT(nvarchar,@MaLoaiNhanVien)
		Else
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien = NULL'
			  
		Set @SQLQuery = @SQLQuery + ' WHERE MaNhanVien = '+CONVERT(nvarchar,@MaNhanVien)
			
		Execute sp_Executesql @SQLQuery
		
	END
GO
CREATE PROCEDURE dbo.T58LoadDanhSachNhanVien
	
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Set @SQLQuery = N'(SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang  FROM NHANVIEN NV WHERE (1=1))'
		Execute sp_Executesql @SQLQuery
	END



GO
CREATE PROCEDURE dbo.T58EditThongTinNhanVien
	@MaNhanVien int,
	@MaNhaHang int,
	@MaLoaiNhanVien int,
	@Ho nvarchar(50) = null,
	@Ten nvarchar(20) = null,
	@CMND nvarchar(10) = null,
	@DiaChi nvarchar(50) = null,
	@DienThoai nvarchar(50) = null,
	@NgayVaoLam date,
	@TinhTrang nvarchar(1) = null
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)

		Set @SQLQuery = N'UPDATE NHANVIEN SET Ho = N'''+CONVERT(nvarchar,@Ho)+''', Ten = N'''+CONVERT(nvarchar,@Ten)+''', CMND = '''+CONVERT(nvarchar,@CMND)+''', DiaChi = N'''+CONVERT(nvarchar,@DiaChi)+''', DienThoai = '''+CONVERT(nvarchar,@DienThoai)+''', NgayVaoLam = '''+CONVERT(nvarchar,@NgayVaoLam)+''', TinhTrang = '''+CONVERT(nvarchar,@TinhTrang)+''''
		If @MaNhaHang != 0
			Set @SQLQuery = @SQLQuery + ', MaNhaHang =' + CONVERT(nvarchar,@MaNhaHang)
		Else
			Set @SQLQuery = @SQLQuery + ', MaNhaHang = NULL'
		If @MaLoaiNhanVien != 0
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien =' + CONVERT(nvarchar,@MaLoaiNhanVien)
		Else
			Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien = NULL'
			  
		Set @SQLQuery = @SQLQuery + ' WHERE MaNhanVien = '+CONVERT(nvarchar,@MaNhanVien)
			
		Execute sp_Executesql @SQLQuery
		--COMMIT
	END
GO
CREATE PROCEDURE dbo.T58DirtyReadTimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ UNCOMMITTED		
		BEGIN TRAN
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.Ho, NV.Ten, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang =0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien !=-1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'


		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    Execute sp_Executesql @SQLQuery
	COMMIT
	END

GO
CREATE PROCEDURE dbo.T58DirtyReadSumNhanVien
	@MaNhaHang int
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
		BEGIN TRANSACTION
		Set @SQLQuery = N'SELECT COUNT(*) as Tong FROM NHANVIEN'
		If @MaNhaHang =  0
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang is null'
		Else If @MaNhaHang = -1
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang like ''%'''
		Else
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang='+CONVERT(nvarchar,@MaNhaHang)
		Execute sp_Executesql @SQLQuery
		COMMIT
	END
GO
CREATE PROCEDURE dbo.T58DirtyReadSolvedTimKiemNhanVien
(
	@MaNhanVien int  = NULL,
	@MaNhaHang int = NULL,
	@MaLoaiNhanVien int = NULL,
	@Ho nvarchar(50) = NULL,
	@Ten nvarchar(20) = NULL,
	@CMND nvarchar(10) = NULL,
	@DiaChi nvarchar(100) = NULL,
	@DienThoai nvarchar(50) = NULL,
	@NgayVaoLam datetime = NULL,
	@TinhTrang nvarchar(1) = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRAN ISOLATION LEVEL READ COMMITTED		
		BEGIN TRAN
		Set @SQLQuery = N'SELECT NV.MaNhanVien, NV.MaNhaHang, NV.MaLoaiNhanVien, NV.Ho, NV.Ten, NV.CMND, NV.DiaChi, NV.DienThoai, NV.NgayVaoLam, NV.TinhTrang
						FROM NHANVIEN AS NV
						WHERE (1=1)'
		
		If @MaNhanVien != 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhanVien = '+CONVERT(nvarchar, @MaNhanVien)+')'

		If @MaNhaHang =0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang is null )'
		else if @MaNhaHang != -1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'
		else
			Set @SQLQuery = @SQLQuery

		If @MaLoaiNhanVien = 0
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien is null )'
		else if @MaLoaiNhanVien !=-1
			Set @SQLQuery = @SQLQuery + ' AND (NV.MaLoaiNhanVien = '+CONVERT(nvarchar, @MaLoaiNhanVien)+')'


		If @Ho != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ho = N'''+@Ho+''')'
			
		If @Ten != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.Ten = N'''+@Ten+ ''')'
			
		If @CMND != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.CMND = '''+@CMND+''')'

		If @DiaChi != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DiaChi = N'''+@DiaChi+''')'

		If @DienThoai != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.DienThoai = '''+@DienThoai+''')'

		If @NgayVaoLam is not NULL
			Set @SQLQuery = @SQLQuery + ' AND (NV.NgayVaoLam = '''+CONVERT(nvarchar, @NgayVaoLam)+''')'

		If @TinhTrang != ''
			Set @SQLQuery = @SQLQuery + ' AND (NV.TinhTrang = '+@TinhTrang+')'
    Execute sp_Executesql @SQLQuery
	COMMIT
	END

GO
CREATE PROCEDURE dbo.T58DirtyReadSolvedSumNhanVien
	@MaNhaHang int
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION
		Set @SQLQuery = N'SELECT COUNT(*) as Tong FROM NHANVIEN'
		If @MaNhaHang = 0
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang is null'
		Else If @MaNhaHang = -1
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang like ''%'''
		Else
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhaHang='+CONVERT(nvarchar,@MaNhaHang)
		Execute sp_Executesql @SQLQuery
		COMMIT
	END
GO
CREATE PROCEDURE dbo.T58DirtyReadSolvedEditThongTinNhanVien
	@MaNhanVien int,
	@MaNhaHang int,
	@MaLoaiNhanVien int,
	@Ho nvarchar(50) = null,
	@Ten nvarchar(20) = null,
	@CMND nvarchar(10) = null,
	@DiaChi nvarchar(50) = null,
	@DienThoai nvarchar(50) = null,
	@NgayVaoLam date,
	@TinhTrang nvarchar(1) = null
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION
			Set @SQLQuery = N'UPDATE NHANVIEN SET Ho = N'''+CONVERT(nvarchar,@Ho)+''', Ten = N'''+CONVERT(nvarchar,@Ten)+''', CMND = '''+CONVERT(nvarchar,@CMND)+''', DiaChi = N'''+CONVERT(nvarchar,@DiaChi)+''', DienThoai = '''+CONVERT(nvarchar,@DienThoai)+''', NgayVaoLam = '''+CONVERT(nvarchar,@NgayVaoLam)+''', TinhTrang = '''+CONVERT(nvarchar,@TinhTrang)+''''
			If @MaNhaHang != 0
				Set @SQLQuery = @SQLQuery + ', MaNhaHang =' + CONVERT(nvarchar,@MaNhaHang)
			Else
				Set @SQLQuery = @SQLQuery + ', MaNhaHang = NULL'
			If @MaLoaiNhanVien != 0
				Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien =' + CONVERT(nvarchar,@MaLoaiNhanVien)
			Else
				Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien = NULL'
			  
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhanVien = '+CONVERT(nvarchar,@MaNhanVien)
			Execute sp_Executesql @SQLQuery
		WAITFOR DELAY '00:00:15'
		ROLLBACK
	END
GO
CREATE PROCEDURE dbo.T58DirtyReadEditThongTinNhanVien
	@MaNhanVien int,
	@MaNhaHang int,
	@MaLoaiNhanVien int,
	@Ho nvarchar(50) = null,
	@Ten nvarchar(20) = null,
	@CMND nvarchar(10) = null,
	@DiaChi nvarchar(50) = null,
	@DienThoai nvarchar(50) = null,
	@NgayVaoLam date,
	@TinhTrang nvarchar(1) = null
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION
			Set @SQLQuery = N'UPDATE NHANVIEN SET Ho = N'''+CONVERT(nvarchar,@Ho)+''', Ten = N'''+CONVERT(nvarchar,@Ten)+''', CMND = '''+CONVERT(nvarchar,@CMND)+''', DiaChi = N'''+CONVERT(nvarchar,@DiaChi)+''', DienThoai = '''+CONVERT(nvarchar,@DienThoai)+''', NgayVaoLam = '''+CONVERT(nvarchar,@NgayVaoLam)+''', TinhTrang = '''+CONVERT(nvarchar,@TinhTrang)+''''
			If @MaNhaHang != 0
				Set @SQLQuery = @SQLQuery + ', MaNhaHang =' + CONVERT(nvarchar,@MaNhaHang)
			Else
				Set @SQLQuery = @SQLQuery + ', MaNhaHang = NULL'
			If @MaLoaiNhanVien != 0
				Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien =' + CONVERT(nvarchar,@MaLoaiNhanVien)
			Else
				Set @SQLQuery = @SQLQuery + ', MaLoaiNhanVien = NULL'
			  
			Set @SQLQuery = @SQLQuery + ' WHERE MaNhanVien = '+CONVERT(nvarchar,@MaNhanVien)
			Execute sp_Executesql @SQLQuery
		WAITFOR DELAY '00:00:15'
		ROLLBACK
	END
GO
CREATE PROCEDURE dbo.T58AddThongTinNhanVien
(
	@MaNhaHang smallint = -1,
	@MaLoaiNhanVien smallint = -1,
	@Ho nvarchar(50),
	@Ten nvarchar(20),
	@CMND nvarchar(10),
	@DiaChi nvarchar(100),
	@DienThoai nvarchar(50),
	@NgayVaoLam smalldatetime,
	@TinhTrang nvarchar(1)
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		Declare @MaNhanVien int
		If @MaNhaHang = -1
			If @MaLoaiNhanVien = -1
				Set @SQLQuery = N'INSERT INTO NHANVIEN (Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) VALUES ('+' N'''+CONVERT(nvarchar, @Ho)+''', N'''+CONVERT(nvarchar, @Ten)+''', N'''+CONVERT(nvarchar, @CMND)+''', N'''+CONVERT(nvarchar, @DiaChi)+''', N'''+CONVERT(nvarchar, @DienThoai)+''', N'''+CONVERT(nvarchar, @NgayVaoLam)+''', N'''+CONVERT(nvarchar, @TinhTrang)+''')'
			Else
				Set @SQLQuery = N'INSERT INTO NHANVIEN (MaLoaiNhanVien, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) VALUES ('+CONVERT(nvarchar, @MaLoaiNhanVien)+', N'''+CONVERT(nvarchar, @Ho)+''', N'''+CONVERT(nvarchar, @Ten)+''', N'''+CONVERT(nvarchar, @CMND)+''', N'''+CONVERT(nvarchar, @DiaChi)+''', N'''+CONVERT(nvarchar, @DienThoai)+''', N'''+CONVERT(nvarchar, @NgayVaoLam)+''', N'''+CONVERT(nvarchar, @TinhTrang)+''')'
		Else
			If @MaLoaiNhanVien = -1
				Set @SQLQuery = N'INSERT INTO NHANVIEN (MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) VALUES ('+CONVERT(nvarchar, @MaNhaHang)+', N'''+CONVERT(nvarchar, @Ho)+''', N'''+CONVERT(nvarchar, @Ten)+''', N'''+CONVERT(nvarchar, @CMND)+''', N'''+CONVERT(nvarchar, @DiaChi)+''', N'''+CONVERT(nvarchar, @DienThoai)+''', N'''+CONVERT(nvarchar, @NgayVaoLam)+''', N'''+CONVERT(nvarchar, @TinhTrang)+''')'
			Else
				Set @SQLQuery = N'INSERT INTO NHANVIEN (MaNhaHang, MaLoaiNhanVien, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) VALUES ('+CONVERT(nvarchar, @MaNhaHang)+', '+CONVERT(nvarchar, @MaLoaiNhanVien)+', N'''+CONVERT(nvarchar, @Ho)+''', N'''+CONVERT(nvarchar, @Ten)+''', N'''+CONVERT(nvarchar, @CMND)+''', N'''+CONVERT(nvarchar, @DiaChi)+''', N'''+CONVERT(nvarchar, @DienThoai)+''', N'''+CONVERT(nvarchar, @NgayVaoLam)+''', N'''+CONVERT(nvarchar, @TinhTrang)+''')'
		SET @MaNhanVien = @@Identity
    Execute sp_Executesql @SQLQuery
	END
GO