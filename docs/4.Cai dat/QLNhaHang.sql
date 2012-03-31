-----------------------------------------------------------------------------------------------
--create DATABASE
CREATE DATABASE QLNHAHANG
GO

USE QLNHAHANG

--create table
CREATE TABLE NHAHANG (
	MaNhaHang smallint identity NOT NULL,
	TenNhaHang nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	DiaChi nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	DienThoai nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PRIMARY KEY (MaNhaHang)
) ON [PRIMARY]
GO

CREATE TABLE LOAINHANVIEN (
	MaLoaiNhanVien smallint identity NOT NULL ,
	TenLoaiNhanVien nvarchar (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	Luong decimal NOT NULL,
	PRIMARY KEY (MaLoaiNhanVien)
) ON [PRIMARY]
GO

CREATE TABLE NHANVIEN (
	MaNhanVien int identity NOT NULL ,
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
	ID int identity NOT NULL , 
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
	PRIMARY KEY (MaNhanVien, Thu, Ca)
) ON [PRIMARY]
GO

CREATE TABLE KHUVUC (
	MaKhuVuc smallint identity NOT NULL ,
	TenKhuVuc nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	MaNhaHang smallint NOT NULL,
	GiaBan decimal NOT NULL,
	PRIMARY KEY (MaKhuVuc)
) ON [PRIMARY]
GO

CREATE TABLE THONGTINBAN (
	MaBan int identity NOT NULL ,
	MaKhuVuc smallint NOT NULL ,
	TenBan nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	SucChua smallint NOT NULL,
	PRIMARY KEY (MaBan)
) ON [PRIMARY]
GO
CREATE TABLE LICHBAN (
	MaBan int NOT NULL,
	NgayDatBan datetime NOT NULL,
	Buoi nvarchar(10) NOT NULL
) ON [PRIMARY]

CREATE TABLE THONGTINBANDAT (
	MaThongTinBanDat int identity NOT NULL ,
	HoTen nvarchar(50) NULL ,
	CMND nvarchar(10) NOT NULL ,
	DienThoai varchar(50) NULL ,
	MaBan int NOT NULL,
	SoLuong smallint NOT NULL,
	NgayDatBan smalldatetime NOT NULL,
	Buoi nvarchar(10) NOT NULL,
	TinhTrang bit,
	PRIMARY KEY (MaThongTinBanDat)
) ON [PRIMARY]
GO

CREATE TABLE NGUYENLIEU (
	MaNguyenLieu int identity NOT NULL,
	TenNguyenLieu nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	DonViTinh nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	PRIMARY KEY (MaNguyenLieu)
) ON [PRIMARY]
GO

CREATE TABLE MONAN (
	MaMonAn int identity NOT NULL , 
	TenMonAn nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	DonGia decimal NOT NULL,
	PRIMARY KEY (MaMonAn)
) ON [PRIMARY]
GO

CREATE TABLE MONAN_NGUYENLIEU (
	MaMonAn int identity NOT NULL,
	MaNguyenLieu int NOT NULL,
	SoLuong decimal NOT NULL,
	PRIMARY KEY (MaMonAn, MaNguyenLieu)
) ON [PRIMARY]
GO

CREATE TABLE LOAIMONAN (
	MaLoaiMonAn smallint identity NOT NULL ,
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
	MaThucDon int identity NOT NULL,
	MaNhaHang smallint NOT NULL,
	NgayApDung smalldatetime NOT NULL,
	PRIMARY KEY (MaThucDon)
) ON [PRIMARY]
GO

CREATE TABLE CHITIETTHUCDON(
	MaChiTietThucDon int identity NOT NULL,
	MaThucDon int NOT NULL,
	MaMonAn int NOT NULL,
	DonGia decimal NOT NULL,
	PRIMARY KEY (MaChiTietThucDon)
) ON [PRIMARY]
GO

CREATE TABLE HOADON (
	MaHoaDon uniqueidentifier NOT NULL ,
	MaThongTinBanDat int NOT NULL,
	NgayLapHoaDon smalldatetime NOT NULL,
	ThanhTien decimal NOT NULL,
	DaThanhToan bit,
	PRIMARY KEY (MaHoaDon)
) ON [PRIMARY]
GO

CREATE TABLE CHITIETHOADON (
	MaChiTietHoaDon int identity NOT NULL ,
	MaHoaDon uniqueidentifier NOT NULL,
	MaChiTietThucDon int NOT NULL,
	DonGia decimal NOT NULL,
	SoLuong int NOT NULL,
	PRIMARY KEY (MaChiTietHoaDon)
) ON [PRIMARY]
GO

CREATE TABLE KHOHANG (
	MaKhoHang smallint identity NOT NULL,
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
	MaThoiDiemThanhToan smallint identity NOT NULL,
	ThoiDiemThanhToan nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	PRIMARY KEY (MaThoiDiemThanhToan)
) ON [PRIMARY]
GO

CREATE TABLE THOIDIEMGUIDS (
	MaThoiDiemGuiDS smallint identity NOT NULL,
	TenThoiDiemGuiDS nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS,
	PRIMARY KEY (MaThoiDiemGuiDS)
) ON [PRIMARY]
GO

CREATE TABLE NHACUNGCAP (
	MaNhaCungCap smallint identity NOT NULL,
	TenNhaCungCap nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS,
	DienThoai nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	SoTaiKhoan nvarchar(20)  COLLATE SQL_Latin1_General_CP1_CI_AS,
	MaThoiDiemThanhToan smallint NOT NULL,
	MaThoiDiemGuiDS smallint NOT NULL,
	PRIMARY KEY (MaNhaCungCap)
) ON [PRIMARY]
GO

CREATE TABLE NHAHANG_NHACUNGCAP (
	MaNhaHang smallint NOT NULL,
	MaNhaCungCap smallint NOT NULL,
	TinhTrang bit,
	PRIMARY KEY (MaNhaHang, MaNhaCungCap)
) ON [PRIMARY]
GO

CREATE TABLE NHACUNGCAP_NGUYENLIEU (
	MaNhaCungCap smallint NOT NULL,
	MaNguyenLieu int NOT NULL,
	DonGia decimal NOT NULL,
	PRIMARY KEY (MaNhaCungCap, MaNguyenLieu)
) ON [PRIMARY]
GO

CREATE TABLE THONGTINHANGNHAP(
	MaThongTinHangNhap int identity NOT NULL,
	MaKhoHang smallint NOT NULL,
	NgayGioNhap smalldatetime,
	PRIMARY KEY (MaThongTinHangNhap)
) ON [PRIMARY]
GO

CREATE TABLE CHITIETHANGNHAP (
	MaChiTietHangNhap int identity NOT NULL,
	MaThongTinHangNhap int NOT NULL,
	MaNhaCungCap smallint NOT NULL,
	MaNguyenLieu int NOT NULL,
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
	ID int identity NOT NULL,
	MaNhaCungCap smallint NOT NULL,
	GiaTriDinhMuc decimal NOT NULL,
	NgayApDung datetime NOT NULL,
	PRIMARY KEY (ID)
) ON [PRIMARY]
GO

CREATE TABLE QUIDINH (
	ID smallint identity NOT NULL,
	ThoiGianSuDungBan smallint NOT NULL,
	PRIMARY KEY (ID)
) ON [PRIMARY]
GO

------------------------------------------------------------
--create FK
--NHAHANG
--LOAINHANVIEN
--NHANVIEN
ALTER TABLE NHANVIEN ADD 
CONSTRAINT [FK_nhanvien_loainhanvien] 
FOREIGN KEY (MaLoaiNhanVien) 
REFERENCES LOAINHANVIEN(MaLoaiNhanVien)
GO
ALTER TABLE NHANVIEN ADD 
CONSTRAINT [FK_nhanvien_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO
--NHANVIEN_LOG
ALTER TABLE NHANVIEN_LOG ADD 
CONSTRAINT [FK_nhanvien_log_nhanvien] 
FOREIGN KEY (MaNhanVien) 
REFERENCES NHANVIEN(MaNhanVien)
GO
--THONGKENHAVIEN
ALTER TABLE THONGKENHANVIEN ADD 
CONSTRAINT [FK_thongkenhanvien_loainhanvien] 
FOREIGN KEY (MaLoaiNhanVien) 
REFERENCES LOAINHANVIEN(MaLoaiNhanVien)
GO
ALTER TABLE THONGKENHANVIEN ADD 
CONSTRAINT [FK_thongkenhanvien_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO
--LICH
ALTER TABLE LICH ADD 
CONSTRAINT [FK_lich_nhanvien] 
FOREIGN KEY (MaNhanVien) 
REFERENCES NHANVIEN(MaNhanVien)
GO
--KHUVUC
ALTER TABLE KHUVUC ADD 
CONSTRAINT [FK_khuvuc_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO
--THONGTINBAN
ALTER TABLE THONGTINBAN ADD 
CONSTRAINT [FK_thongtinban_khuvuc] 
FOREIGN KEY (MaKhuVuc) 
REFERENCES KHUVUC(MaKhuVuc)
GO
--THONGTINBANDAT
ALTER TABLE THONGTINBANDAT ADD 
CONSTRAINT [FK_thongtinbandat_thongtinban] 
FOREIGN KEY (MaBan) 
REFERENCES THONGTINBAN(MaBan)
GO
--HOADON
ALTER TABLE HOADON ADD 
CONSTRAINT [FK_hoadon_thongtinbandat] 
FOREIGN KEY (MaThongTinBanDat) 
REFERENCES THONGTINBANDAT(MaThongTinBanDat)
GO
--CHITIETHOADON
ALTER TABLE CHITIETHOADON ADD 
CONSTRAINT [FK_chitiethoadon_hoadon] 
FOREIGN KEY (MaHoaDon) 
REFERENCES HOADON(MaHoaDon)
GO
ALTER TABLE CHITIETHOADON ADD 
CONSTRAINT [FK_chitiethoadon_chitietthucdon] 
FOREIGN KEY (MaChiTietThucDon) 
REFERENCES CHITIETTHUCDON(MaChiTietThucDon)
GO
--MONAN
--LOAIMONAN
--PHANLOAIMONAN
ALTER TABLE PHANLOAIMONAN ADD 
CONSTRAINT [FK_phanloaimonan_monan] 
FOREIGN KEY (MaMonAn) 
REFERENCES MONAN(MaMonAn)
GO
ALTER TABLE PHANLOAIMONAN ADD 
CONSTRAINT [FK_phanloaimonan_loaimonan] 
FOREIGN KEY (MaLoaiMonAn) 
REFERENCES LOAIMONAN(MaLoaiMonAn)
GO
ALTER TABLE PHANLOAIMONAN ADD 
CONSTRAINT [FK_phanloaimonan_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO
--MONAN_NGUYENLIEU
ALTER TABLE MONAN_NGUYENLIEU ADD 
CONSTRAINT [FK_monan_nguyenlieu_nguyenlieu] 
FOREIGN KEY (MaNguyenLieu) 
REFERENCES NGUYENLIEU(MaNguyenLieu)
GO
ALTER TABLE MONAN_NGUYENLIEU ADD 
CONSTRAINT [FK_monan_nguyenlieu_monan] 
FOREIGN KEY (MaMonAn) 
REFERENCES MONAN(MaMonAn)
GO
--THONGKETHUNHAP
ALTER TABLE THONGKETHUNHAP ADD 
CONSTRAINT [FK_thongkethunhap_monan] 
FOREIGN KEY (MaMonAn) 
REFERENCES MONAN(MaMonAn)
GO
ALTER TABLE THONGKETHUNHAP ADD 
CONSTRAINT [FK_thongkethunhap_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO
--THUCDON
ALTER TABLE THUCDON ADD 
CONSTRAINT [FK_thucdon_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO
--CHITIETTHUCDON
ALTER TABLE CHITIETTHUCDON ADD 
CONSTRAINT [FK_chitietthucdon_thucdon] 
FOREIGN KEY (MaThucDon) 
REFERENCES THUCDON(MaThucDon)
GO
ALTER TABLE CHITIETTHUCDON ADD 
CONSTRAINT [FK_chitietthucdon_monan] 
FOREIGN KEY (MaMonAn) 
REFERENCES MONAN(MaMonAn)
GO
--KHOHANG
ALTER TABLE KHOHANG ADD 
CONSTRAINT [FK_khohang_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO
--THONGTINHANGNHAP
ALTER TABLE THONGTINHANGNHAP ADD 
CONSTRAINT [FK_thongtinhangnhap_khohang] 
FOREIGN KEY (MaKhoHang) 
REFERENCES KHOHANG(MaKhoHang)
GO
--CHITIETHANGNHAP
ALTER TABLE CHITIETHANGNHAP ADD 
CONSTRAINT [FK_chitiethangnhap_nhacungcap] 
FOREIGN KEY (MaNhaCungCap) 
REFERENCES NHACUNGCAP(MaNhaCungCap)
GO
ALTER TABLE CHITIETHANGNHAP 
ADD CONSTRAINT [FK_chitiethangnhap_thongtinhangnhap] 
FOREIGN KEY (MaThongTinHangNhap) 
REFERENCES THONGTINHANGNHAP(MaThongTinHangNhap)
GO
ALTER TABLE CHITIETHANGNHAP ADD 
CONSTRAINT [FK_chitiethangnhap] 
FOREIGN KEY (MaNguyenLieu) 
REFERENCES NGUYENLIEU(MaNguyenLieu)
GO
--KHOHANG_NGUYENLIEU
ALTER TABLE KHOHANG_NGUYENLIEU ADD 
CONSTRAINT [FK_khohang_nguyenlieu_nguyenlieu] 
FOREIGN KEY (MaNguyenLieu) 
REFERENCES NGUYENLIEU(MaNguyenLieu)
GO
ALTER TABLE KHOHANG_NGUYENLIEU ADD 
CONSTRAINT [FK_khohang_nguyenlieu_khohang] 
FOREIGN KEY (MaKhoHang) 
REFERENCES KHOHANG(MaKhoHang)
GO
--NGUYENLIEU
--THONGKEHANGNHAP
ALTER TABLE THONGKEHANGNHAP ADD 
CONSTRAINT [FK_thongkehangnhap_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO

ALTER TABLE THONGKEHANGNHAP ADD 
CONSTRAINT [FK_thongkehangnhap_nguyenlieu] 
FOREIGN KEY (MaNguyenLieu) 
REFERENCES NGUYENLIEU(MaNguyenLieu)
GO
--NHACUNGCAP
ALTER TABLE NHACUNGCAP 
ADD CONSTRAINT [FK_nhacungcap_thoidiemthanhtoan] 
FOREIGN KEY (MaThoiDiemThanhToan) 
REFERENCES THOIDIEMTHANHTOAN (MaThoiDiemThanhToan)
GO
ALTER TABLE NHACUNGCAP 
ADD CONSTRAINT [FK_nhacungcap_thoidiemguids] 
FOREIGN KEY (MaThoiDiemGuiDS) 
REFERENCES THOIDIEMGUIDS(MaThoiDiemGuiDS)
GO
--NHAHANG_NHACUNGCAP
ALTER TABLE NHAHANG_NHACUNGCAP ADD 
CONSTRAINT [FK_nhahang_nhacungcap_nhacungcap] 
FOREIGN KEY (MaNhaCungCap) 
REFERENCES NHACUNGCAP(MaNhaCungCap)
GO
ALTER TABLE NHAHANG_NHACUNGCAP ADD 
CONSTRAINT [FK_nhahang_nhacungcap_nhahang] 
FOREIGN KEY (MaNhaHang) 
REFERENCES NHAHANG(MaNhaHang)
GO
--NHACUNGCAP_NGUYENLIEU
ALTER TABLE NHACUNGCAP_NGUYENLIEU ADD 
CONSTRAINT [FK_nhacungcap_nguyenlieu_nhacungcap] 
FOREIGN KEY (MaNhaCungCap) 
REFERENCES NHACUNGCAP(MaNhaCungCap)
GO
ALTER TABLE NHACUNGCAP_NGUYENLIEU ADD 
CONSTRAINT [FK_nhacungcap_nguyenlieu_nguyenlieu] 
FOREIGN KEY (MaNguyenLieu) 
REFERENCES NGUYENLIEU(MaNguyenLieu)
GO
--THOIDIEMTHANHTOAN
--DINHMUCNO
ALTER TABLE DINHMUCNO ADD 
CONSTRAINT [FK_nhacungcap_dinhmucno] 
FOREIGN KEY (MaNhaCungCap) 
REFERENCES NHACUNGCAP(MaNhaCungCap)
GO
--THOIDIEMGUIDS
--QUYDINH
--DocGia

INSERT INTO NHAHANG (TenNhaHang, DiaChi, DienThoai) VALUES(N'H3L 1',N'325 Nguyễn Trãi Q1',N'(08)32561425')
INSERT INTO NHAHANG (TenNhaHang, DiaChi, DienThoai) VALUES(N'H3L 2',N'114 Hùng Vương Q5',N'(08)38630408')
INSERT INTO NHAHANG (TenNhaHang, DiaChi, DienThoai) VALUES(N'H3L 3',N'61 Lý Thái Tổ Q10',N'(08)32022202')
INSERT INTO NHAHANG (TenNhaHang, DiaChi, DienThoai) VALUES(N'H3L 4',N'21 Nguyễn Tri Phương Q10',N'(08)38941466')
INSERT INTO NHAHANG (TenNhaHang, DiaChi, DienThoai) VALUES(N'H3L 5',N'23B Điện Biên Phủ Q3',N'(08)38181405')
GO

INSERT INTO LOAINHANVIEN (TenLoaiNhanVien, Luong) VALUES(N'Quản lý công ty',10000)
INSERT INTO LOAINHANVIEN (TenLoaiNhanVien, Luong) VALUES(N'Quản lý nhà hàng',8000)
INSERT INTO LOAINHANVIEN (TenLoaiNhanVien, Luong) VALUES(N'Tiếp tân',4000)
INSERT INTO LOAINHANVIEN (TenLoaiNhanVien, Luong) VALUES(N'Thu ngân',5000)
INSERT INTO LOAINHANVIEN (TenLoaiNhanVien, Luong) VALUES(N'Quản lý kho hàng',4000)
GO

INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(1,1,N'Nguyễn',N' Minh Anh',N'024303942',N'182 Thành Thái P12 Q10','0919901614','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,1,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,2,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,3,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,4,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,5,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,1,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,2,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,3,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,4,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,5,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,1,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,2,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,3,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,4,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,5,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(5,1,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(5,2,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(5,3,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang)
VALUES(5,4,N'',N'',N'',N'',N'','',)			   
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(5,5,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,1,N'',N'',N'',N'',N'','',)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,2,N'',N'',N'',N'',N'','',)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,1,N'',N'',N'',N'',N'','',)
GO

INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (,,,,)		      			   
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (,,,,)
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (,,,,)
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (,,,,)
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (,,,,)
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (,,,,)
GO

INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(,'',)
GO

INSERT INTO KHOHANG (TenKhoHang, MaNhaHang) VALUES(N'',)
INSERT INTO KHOHANG (TenKhoHang, MaNhaHang) VALUES(N'',)
INSERT INTO KHOHANG (TenKhoHang, MaNhaHang) VALUES(N'',)
INSERT INTO KHOHANG (TenKhoHang, MaNhaHang) VALUES(N'',)
GO

INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'',N'')
GO

INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(,,,,)
GO

INSERT INTO THOIDIEMTHANHTOAN (ThoiDiemThanhToan) VALUES(N'')
INSERT INTO THOIDIEMTHANHTOAN (ThoiDiemThanhToan) VALUES(N'')
INSERT INTO THOIDIEMTHANHTOAN (ThoiDiemThanhToan) VALUES(N'')
INSERT INTO THOIDIEMTHANHTOAN (ThoiDiemThanhToan) VALUES(N'')
GO

INSERT INTO THOIDIEMGUIDS (TenThoiDiemGuiDS) VALUES(N'')
INSERT INTO THOIDIEMGUIDS (TenThoiDiemGuiDS) VALUES(N'')
INSERT INTO THOIDIEMGUIDS (TenThoiDiemGuiDS) VALUES(N'')
INSERT INTO THOIDIEMGUIDS (TenThoiDiemGuiDS) VALUES(N'')
GO

INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'','','',,)
INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'','','',,)
INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'','','',,)
INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'','','',,)
GO

INSERT INTO DINHMUCNO (MaNhaCungCap, GiaTriDinhMuc, NgayApDung) VALUES(,,'')
INSERT INTO DINHMUCNO (MaNhaCungCap, GiaTriDinhMuc, NgayApDung) VALUES(,,'')
INSERT INTO DINHMUCNO (MaNhaCungCap, GiaTriDinhMuc, NgayApDung) VALUES(,,'')
INSERT INTO DINHMUCNO (MaNhaCungCap, GiaTriDinhMuc, NgayApDung) VALUES(,,'')
GO

INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(,,)
GO

INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(,,)
GO

INSERT INTO THONGTINHANGNHAP (MaThongTinHangNhap, MaKhoHang,NgayGioNhap) VALUES(,,'')
INSERT INTO THONGTINHANGNHAP (MaThongTinHangNhap, MaKhoHang,NgayGioNhap) VALUES(,,'')
INSERT INTO THONGTINHANGNHAP (MaThongTinHangNhap, MaKhoHang,NgayGioNhap) VALUES(,,'')
INSERT INTO THONGTINHANGNHAP (MaThongTinHangNhap, MaKhoHang,NgayGioNhap) VALUES(,,'')
INSERT INTO THONGTINHANGNHAP (MaThongTinHangNhap, MaKhoHang,NgayGioNhap) VALUES(,,'')
GO

INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
INSERT INTO CHITIETHANGNHAP (MaChiTietHangNhap, MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong, TinhTrangGiaoHang, TinhTrangThanhToan) VALUES(,,,,,,,)
GO

INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'',)
INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'',)
INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'',)
INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'',)
INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'',)
GO

INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (,,)
GO

INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'')
INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'')
INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'')
INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'')
INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'')
GO

INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (,,)
GO

INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (,'')
GO

INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (,,)
GO

INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'',,)
GO

INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'',,)
GO

INSERT INTO THONGTINBANDAT (MaThongTinBanDat, HoTen, CMND, DienThoai, SoLuong, TinhTrang, MaBan, NgayDatBan, Buoi) VALUES (,N'','','',,,'',)
INSERT INTO THONGTINBANDAT (MaThongTinBanDat, HoTen, CMND, DienThoai, SoLuong, TinhTrang, MaBan, NgayDatBan, Buoi) VALUES (,N'','','',,,'',)
INSERT INTO THONGTINBANDAT (MaThongTinBanDat, HoTen, CMND, DienThoai, SoLuong, TinhTrang, MaBan, NgayDatBan, Buoi) VALUES (,N'','','',,,'',)
INSERT INTO THONGTINBANDAT (MaThongTinBanDat, HoTen, CMND, DienThoai, SoLuong, TinhTrang, MaBan, NgayDatBan, Buoi) VALUES (,N'','','',,,'',)
INSERT INTO THONGTINBANDAT (MaThongTinBanDat, HoTen, CMND, DienThoai, SoLuong, TinhTrang, MaBan, NgayDatBan, Buoi) VALUES (,N'','','',,,'',)
INSERT INTO THONGTINBANDAT (MaThongTinBanDat, HoTen, CMND, DienThoai, SoLuong, TinhTrang, MaBan, NgayDatBan, Buoi) VALUES (,N'','','',,,'',)
GO

INSERT INTO LICHBAN (MaBan, NgayDatBan, Buoi) VALUES (,'',N'')
INSERT INTO LICHBAN (MaBan, NgayDatBan, Buoi) VALUES (,'',N'')
INSERT INTO LICHBAN (MaBan, NgayDatBan, Buoi) VALUES (,'',N'')
INSERT INTO LICHBAN (MaBan, NgayDatBan, Buoi) VALUES (,'',N'')
INSERT INTO LICHBAN (MaBan, NgayDatBan, Buoi) VALUES (,'',N'')
INSERT INTO LICHBAN (MaBan, NgayDatBan, Buoi) VALUES (,'',N'')
GO

INSERT INTO HOADON (MaHoaDon, MaThongTinBanDat, NgayLapHoaDon, ThanhTien, DaThanhToan) VALUES ('',,'',,)
INSERT INTO HOADON (MaHoaDon, MaThongTinBanDat, NgayLapHoaDon, ThanhTien, DaThanhToan) VALUES ('',,'',,)
INSERT INTO HOADON (MaHoaDon, MaThongTinBanDat, NgayLapHoaDon, ThanhTien, DaThanhToan) VALUES ('',,'',,)
INSERT INTO HOADON (MaHoaDon, MaThongTinBanDat, NgayLapHoaDon, ThanhTien, DaThanhToan) VALUES ('',,'',,)
INSERT INTO HOADON (MaHoaDon, MaThongTinBanDat, NgayLapHoaDon, ThanhTien, DaThanhToan) VALUES ('',,'',,)
GO

INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('',,,)
INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('',,,)
INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('',,,)
INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('',,,)
INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('',,,)
INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('',,,)
INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('',,,)
INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('',,,)
GO

INSERT INTO QUIDINH (ThoiGianSuDungBan) VALUES ()