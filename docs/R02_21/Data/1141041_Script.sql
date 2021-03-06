-- 1141041
-- DIRTY READ T1
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
-- T2
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
-- LOST UPDATE 
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
-- PHANTOM T1
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
-- T2
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
-- UNREPEATABLE READ T1
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
-- T2
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


