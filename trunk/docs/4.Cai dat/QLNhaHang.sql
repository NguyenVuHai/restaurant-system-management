-----------------------------------------------------------------------------------------------
--create DATABASE
CREATE DATABASE QLNHAHANG
GO

USE QLNHAHANG

--create table
CREATE TABLE NhaHang (
	MaNhaHang smallint NOT NULL,
	TenNhaHang nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	DiaChi nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	DienThoai nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PRIMARY KEY (MaNhaHang)
) ON [PRIMARY]
GO

CREATE TABLE LoaiNhanVien (
	MaLoaiNhanVien smallint NOT NULL ,
	TenLoaiNhanVien nvarchar (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	Luong decimal NOT NULL,
	PRIMARY KEY (MaLoaiNhanVien)
) ON [PRIMARY]
GO

CREATE TABLE NHANVIEN (
	MaNhanVien int NOT NULL ,
	MaNhaHang smallint NOT NULL,
	MaLoaiNhanVien smallint NOT NULL,
	Ho nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Ten nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CMND nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DiaChi nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DienThoai nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	NgayVaoLam smalldatetime NOT NULL,
	TinhTrang nvarchar(1) NOT NULL,
	PRIMARY KEY (MaNhanVien)
) ON [PRIMARY]
GO

CREATE TABLE NHANVIEN_LOG (
	ID int NOT NULL , 
	MaNhanVien int NOT NULL ,
	Ngay smallint NOT NULL,
	Thang smallint NOT NULL,
	Nam smallint NOT NULL,
	TinhTrang nvarchar(1) NOT NULL,
	PRIMARY KEY (ID)
) ON [PRIMARY]
GO

CREATE TABLE THONGKENHANVIEN (
	Thang smallint NOT NULL ,
	Nam smallint NOT NULL ,
	MaNhaHang smallint NOT NULL,
	MaLoaiNhanVien smallint NOT NULL,
	SoLuong smallint NOT NULL,
	TongLuong decimal NOT NULL,
	PRIMARY KEY (Thang, Nam)
) ON [PRIMARY]
GO

CREATE TABLE LICH (
	MaNhanVien int NOT NULL ,
	Thu nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Ca smallint NOT NULL,
	PRIMARY KEY (MaNhanVien, Thu Ca)
) ON [PRIMARY]
GO

CREATE TABLE KHUVUC (
	MaKhuVuc smallint NOT NULL ,
	TenKhuVuc nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	MaNhaHang smallint NOT NULL,
	GiaBan decimal NOT NULL,
	PRIMARY KEY (MaKhuVuc)
) ON [PRIMARY]
GO

CREATE TABLE THONGTINBAN (
	MaBan int NOT NULL ,
	MaKhuVuc smallint NOT NULL ,
	TenBan nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	SucChua smallint NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE THONGTINBANDAT (
	MaThongTinBanDat int NOT NULL ,
	HoTen nvarchar(50) NULL ,
	CMND nvarchar(10) NOT NULL ,
	DienThoai varchar(50) NULL ,
	MaBan int NOT NULL,
	SoLuong smallint NOT NULL,
	NgayDatBan smalldatetime NOT NULL,
	GioDatBan time NOT NULL,
	ThoiGian smallint NULL,
	TinhTrang bit,
	PRIMARY KEY (MaThongTinBanDat)
) ON [PRIMARY]
GO

CREATE TABLE NGUYENLIEU (
	MaNguyenLieu int NOT NULL,
	TenNguyenLieu nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	DonViTinh nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	PRIMARY KEY (MaNguyenLieu)
) ON [PRIMARY]
GO

CREATE TABLE MONAN (
	MaMonAn int NOT NULL , 
	TenMonAn nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	DonGia decimal NOT NULL,
	PRIMARY KEY (MaMonAn)
) ON [PRIMARY]
GO

CREATE TABLE NGUYENLIEU_MONAN (
	MaMonAn int NOT NULL,
	MaNguyenLieu int NOT NULL,
	SoLuong decimal NOT NULL,
	PRIMARY KEY (MaMonAn, MaNguyenLieu)
) ON [PRIMARY]
GO

CREATE TABLE LOAIMONAN (
	MaLoaiMonAn smallint NOT NULL ,
	TenLoaiMonAn nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	PRIMARY KEY (MaLoaiMonAn)
) ON [PRIMARY]
GO

CREATE TABLE PHANLOAIMONAN(
	MaNhaHang smallint NOT NULL,
	MaLoaiMonAn smallint NOT NULL,
	MaMonAn int NOT NULL,
	PRIMARY KEY (MaNhaHang, MaLoaiMonAn, MaMonAn)
) ON [PRIMARY]
GO

CREATE TABLE THONGKETHUNHAP (
	Tuan smallint NOT NULL,
	Thang smallint NOT NULL,
	Nam smallint NOT NULL,
	MaNhaHang smallint NOT NULL,
	MaMonAn int NOT NULL,
	TongSoTien decimal NOT NULL,
	PRIMARY KEY (Tuan, Thang, Nam)
) ON [PRIMARY]
GO

CREATE TABLE THUCDON(
	MaThucDon int NOT NULL,
	MaNhaHang smallint NOT NULL,
	NgayApDung smalldatetime NOT NULL,
	PRIMARY KEY (MaThucDon)
) ON [PRIMARY]
GO

CREATE TABLE CHITIETTHUCDON(
	MaChiTietThucDon int NOT NULL,
	MaThucDon int NOT NULL,
	MaMonAn int NOT NULL,
	DonGia decimal NOT NULL,
	PRIMARY KEY (MaChiTietThucDon)
) ON [PRIMARY]
GO

CREATE TABLE HOADON (
	MaHoaDon int NOT NULL ,
	MaThongTinBanDat int NOT NULL,
	NgayLapHoaDon smalldatetime NOT NULL,
	ThanhTien decimal NOT NULL,
	DaThanhToan bit,
	PRIMARY KEY (MaHoaDon)
) ON [PRIMARY]
GO

CREATE TABLE CHITIETHOADON (
	MaChiTietHoaDon int NOT NULL ,
	MaHoaDon int NOT NULL,
	MaChiTietThucDon int NOT NULL,
	DonGia decimal NOT NULL,
	SoLuong int NOT NULL,
	PRIMARY KEY (MaChiTietHoaDon)
) ON [PRIMARY]
GO

CREATE TABLE KHOHANG (
	MaKhoHang int NOT NULL,
	TenKhoHang nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS,
	MaNhaHang smallint NOT NULL,
	PRIMARY KEY (MaKhoHang)
) ON [PRIMARY]
GO

CREATE TABLE KHOHANG_NGUYENLIEU(
	MaKhoHang smallint NOT NULL,
	MaNguyenLieu int NOT NULL,
	SoLuongTon decimal NOT NULL,
	SucChua decimal NOT NULL,
	MucChuaToiThieu decimal NOT NULL,
	PRIMARY KEY (MaKhoHang, MaNguyenLieu)
) ON [PRIMARY]
GO

CREATE TABLE THOIDIEMTHANHTOAN (
	MaThoiDiemThanhToan smallint NOT NULL,
	ThoiDiemThanhToan nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	PRIMARY KEY (MaThoiDiemThanhToan)
) ON [PRIMARY]
GO

CREATE TABLE THOIDIEMGUIDS (
	MaThoiDiemGuiDS smallint NOT NULL,
	TenThoiDiemGuiDS nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS,
	PRIMARY KEY (MaThoiDiemGuiDS)
) ON [PRIMARY]
GO

CREATE TABLE NHACUNGCAP (
	MaNhaCungCap smallint NOT NULL,
	TenNhaCungCap nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS,
	DienThoai nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	SoTaiKhoan nvarchar(20)  COLLATE SQL_Latin1_General_CP1_CI_AS,
	MaThoiDiemThanhToan smallint NOT NULL,
	MaThoiDiemGuiDS smallint NOT NULL,
	PRIMARY KEY (MaNhaCungCap)
) ON [PRIMARY]
GO

CREATE TABLE NHACUNGCAP_NHAHANG (
	MaNhaHang smallint NOT NULL,
	MaNhaCungCap smallint NOT NULL,
	TinhTrang bit,
	PRIMARY KEY (MaNhaHang, MaNhaCungCap)
) ON [PRIMARY]
GO

CREATE TABLE NHACUNGCAP_NGUYENLIEU (
	MaNhaCungCap smallint NOT NULL,
	MaNguyenLieu smallint NOT NULL,
	DonGia decimal NOT NULL,
	PRIMARY KEY (MaNhaCungCap, MaNguyenLieu)
) ON [PRIMARY]
GO

CREATE TABLE THONGTINHANGNHAP(
	MaHangNhap int NOT NULL,
	MaKhoHang int NOT NULL,
	NgayGioNhap smalldatetime,
	PRIMARY KEY (MaHangNhap)
) ON [PRIMARY]
GO

CREATE TABLE CHITIETHANGNHAP (
	MaChiTietHangNhap int NOT NULL,
	MaHangNhap int NOT NULL,
	MaNhaCungCap smallint NOT NULL,
	DonGia decimal NOT NULL,
	SoLuong decimal NOT NULL,
	TinhTrangGiaoHang bit,
	TinhTrangThanhToan bit,
	PRIMARY KEY (MaChiTietHangNhap)
) ON [PRIMARY]
GO

CREATE TABLE THONGKEHANGNHAP (
	Tuan smallint NOT NULL,
	Thang smallint NOT NULL,
	Nam smallint NOT NULL,
	MaNhaHang smallint NOT NULL,
	MaNguyenLieu int NOT NULL,
	TongSoLuong decimal NOT NULL,
	ChiPhi decimal NOT NULL,
	PRIMARY KEY (Tuan, Thang, Nam)
) ON [PRIMARY]
GO

CREATE TABLE DINHMUCNO (
	ID int NOT NULL,
	MaNhaCungCap smallint NOT NULL,
	GiaTriDinhMuc decimal NOT NULL,
	NgayApDung datetime NOT NULL,
	PRIMARY KEY (ID)
) ON [PRIMARY]
GO

CREATE TABLE QUIDINH (
	ID smallint NOT NULL,
	ThoiGianSuDungBan smallint NOT NULL,
	PRIMARY KEY (ID)
) ON [PRIMARY]
GO
