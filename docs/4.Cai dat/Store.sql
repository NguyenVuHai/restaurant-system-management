--alter PROC SP_GETTABLES
--AS
--	SELECT * FROM THONGTINBAN
	
--	EXEC SP_GETTABLES

CREATE PROC SP_TIMBANTRONG
(
	@MaNhaHang int = NULL,
	@NgayDatBan datetime = NULL,
	@Buoi nvarchar(10) = NULL,
	@SoLuong int = NULL
)
AS
	BEGIN
		Declare @SQLQuery nvarchar(4000)
		
		Set @SQLQuery = N'SELECT * FROM LICHBAN LB JOIN THONGTINBAN TTB ON LB.MaBan = TTB.MaBan JOIN KHUVUC KV ON TTB.MaKhuVuc = KV.MaKhuVuc JOIN NHAHANG NH ON KV.MaNhaHang = NH.MaNhaHang WHERE (1=1)'
		
		If @MaNhaHang Is Not Null 
			Set @SQLQuery = @SQLQuery + ' AND (KV.MaNhaHang = '+CONVERT(nvarchar, @MaNhaHang)+')'

		If (@NgayDatBan Is Not Null)
			Set @SQLQuery = @SQLQuery + ' AND ( NgayDatBan = '''+ CAST(@NgayDatBan AS nvarchar(20))  +''')'
			
		If @Buoi Is Not Null
			Set @SQLQuery = @SQLQuery + ' And (Buoi =  N'''+ CONVERT(nvarchar, @Buoi)+''')' 
  
		If @SoLuong Is Not Null
			Set @SQLQuery = @SQLQuery + ' And (SoLuong >=  ' +CONVERT(nvarchar,@SoLuong)+')'

    /* Execute the Transact-SQL String with all parameter value's 
       Using sp_executesql Command */
    Execute sp_Executesql @SQLQuery
	END
	GO
	EXEC SP_TIMBANTRONG NULL, '2012-04-17' ,N'Sáng', 1