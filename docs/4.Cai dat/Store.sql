CREATE PROCEDURE dbo.LayDanhSachKhuVuc
(
	@MaNhaHang int
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT MaKhuVuc, TenKhuVuc,  GiaBan FROM KHUVUC KV JOIN NHAHANG NH ON KV.MaNhaHang = NH.MaNhaHang WHERE (1=1)'
		
		If @MaNhaHang Is Not Null 
			Set @SQLQuery = @SQLQuery + ' AND (KV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'

    Execute sp_Executesql @SQLQuery
	END
GO
----
CREATE PROCEDURE dbo.LayDanhSachNhaHang
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT MaNhaHang, TenNhaHang, DienThoai, DiaChi FROM NHAHANG WHERE (1=1)'
		
    Execute sp_Executesql @SQLQuery
GO
----
CREATE PROCEDURE dbo.LayDanhSachThongTinBan
(
	@MaKhuVuc int
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT MaBan, TenBan, MaKhuVuc, SucChua FROM THONGTINBAN WHERE (1=1)'
		
		If @MaKhuVuc Is Not Null 
			Set @SQLQuery = @SQLQuery + ' AND (MaKhuVuc = '+CONVERT(nvarchar, @MaKhuVuc)+')'

    Execute sp_Executesql @SQLQuery
	END
GO
----
----
ALTER PROCEDURE dbo.TimBanTrong
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
----
CREATE PROCEDURE dbo.TempLayDanhSachBan
	(
	@MaNhaHang int
	)
AS
	Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT MaBan, TenBan, SucChua FROM THONGTINBAN TTB JOIN KHUVUC KV ON TTB.MaKhuVuc = KV.MaKhuVuc WHERE (1=1)'
		Set @SQLQuery = @SQLQuery + ' AND MaNhaHang = ' + Convert(nvarchar, @MaNhaHang)
    /* Execute the Transact-SQL String with all parameter value's 
       Using sp_executesql Command */
    Execute sp_Executesql @SQLQuery