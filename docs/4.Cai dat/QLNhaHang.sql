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
	MaNhaHang smallint NULL,
	MaLoaiNhanVien smallint NULL,
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

CREATE TABLE NGUOIDUNG(
	ID int identity NOT NULL,
	MaNhanVien int NOT NULL,
	TenDangNhap nvarchar(20) NOT NULL,
	MatKhau nvarchar(20) NOT NULL,
	PRIMARY KEY (ID)
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
	Thu smallint NOT NULL,
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

CREATE TABLE BUOI (
	MaBuoi int identity NOT NULL,
	TenBuoi nvarchar(10),
	PRIMARY KEY (MaBuoi)
)
GO

CREATE TABLE LICHBAN (
	MaLichBan int identity NOT NULL,
	MaBan int NOT NULL,
	NgayDatBan datetime NOT NULL,
	MaBuoi int NOT NULL,
	MaThongTinKhachHang int,
	SoLuong int NOT NULL,
	TinhTrangBan bit,
	PRIMARY KEY (MaLichBan)
) ON [PRIMARY]

CREATE TABLE THONGTINKHACHHANG (
	MaThongTinKhachHang int identity NOT NULL ,
	HoTen nvarchar(50) NULL ,
	CMND nvarchar(10) NOT NULL ,
	DienThoai varchar(50) NULL ,
	PRIMARY KEY (MaThongTinKhachHang)
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
	MaMonAn int NOT NULL,
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
	MaLichBan int NOT NULL,
	NgayLapHoaDon smalldatetime NOT NULL,
	ThanhTien decimal,
	DaThanhToan bit,
	MaThongTinBanDat int NOT NULL,
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
	TongNo decimal,
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
--NGUOIDUNG
ALTER TABLE NGUOIDUNG ADD 
CONSTRAINT [FK_nguoidung_nhanvien] 
FOREIGN KEY (MaNhanVien) 
REFERENCES NHANVIEN(MaNhanVien)
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
--LICHBAN
ALTER TABLE LICHBAN ADD 
CONSTRAINT [FK_lichban_thongtinban] 
FOREIGN KEY (MaBan) 
REFERENCES THONGTINBAN(MaBan)
GO
ALTER TABLE LICHBAN ADD 
CONSTRAINT [FK_lichban_buoi] 
FOREIGN KEY (MaBuoi) 
REFERENCES BUOI(MaBuoi)
GO


ALTER TABLE LICHBAN ADD 
CONSTRAINT [FK_lichban_thongtinkhachhang] 
FOREIGN KEY (MaThongTinKhachHang) 
REFERENCES THONGTINKHACHHANG(MaThongTinKhachHang)
GO
--HOADON
ALTER TABLE HOADON ADD 
CONSTRAINT [FK_hoadon_thongtinkhachhang] 
FOREIGN KEY (MaThongTinBanDat) 
REFERENCES THONGTINKHACHHANG(MaThongTinKhachHang)
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
VALUES(2,1,N'Trần',N' Văn A',N'123456789',N'112 Thành Thái P12 Q1',N'01234567891','2012-01-14',1)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,2,N'Nguyễn',N' Văn B',N'357914682',N'282 Nguyễn Tri Phương P12 Q1',N'0985632145','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,3,N'Trần',N' Văn C',N'012563478',N'162 Nguyễn Chí Thanh P12 Q1',N'0985476321','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,4,N'Nguyễn',N' Văn D',N'256314789',N'14 Hùng Vương P12 Q1',N'09325632147','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,5,N'Trần',N' Văn E',N'012534785',N'214 Phạm Ngọc Thạch P12 Q1',N'09456321523','2012-01-14',1)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,1,N'Nguyễn',N' Văn T',N'012014523',N'654 Đinh Tiên Hoàng P12 Q1',N'09586325965','2012-01-14',3)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,2,N'Trần',N' Văn G',N'120145896',N'76 Ngô Gia Tự P12 Q1',N'09145213652','2012-01-14',3)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,3,N'Nguyễn',N' Văn H',N'012541230',N'4/3 Tô Hiến Thành P12 QTN',N'09145242524','2012-01-14',2)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,4,N'Trần',N' Văn Y',N'010254632',N'32/1 Vĩnh Viễn P12 QPN',N'09745864851','2012-01-14',1)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,5,N'Nguyễn',N' Văn X',N'201201204',N'123 Lê Hồng Phong P12 QGV',N'09125213141','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,1,N'Trần',N' Văn K',N'102436501',N'182 Nguyễn Thị Minh Khai P12 QBT',N'09325632632','2012-01-14',1)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,2,N'Nguyễn',N' Văn L',N'015234125',N'182 Võ Thị Sáu P12 QTB',N'09548547125','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,3,N'Trần',N' Văn M',N'012045214',N'182 Nguyễn Hữu Thọ P12 Q1',N'09142587462','2012-01-14',1)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,4,N'Nguyễn',N' Thị N',N'102452102',N'182 Nguyễn Văn Linh P12 Q3',N'09415217854','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(4,5,N'Trần',N' Thị O',N'102412536',N'182 Võ Văn Tần P12 Q4',N'09145235125','2012-01-14',1)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(5,1,N'Nguyễn',N' Thị P',N'102145213',N'182 Nguyễn TRãi P12 Q5',N'09586542563','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(5,2,N'Trần',N' Thị Q',N'012101452',N'182 Lê Đại Hành P12 Q6',N'09145214785','2012-01-14',1)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(5,3,N'Nguyễn',N' Thị R',N'124521014',N'182 Âu Cơ P12 Q7',N'09436541253','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang)
VALUES(5,4,N'Trần',N' Thị S',N'102101452',N'182 Phan Châu Trinh P12 Q8',N'012341523647','2012-01-14',1)			   
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(5,5,N'Nguyễn',N' Thị T',N'104521471',N'182 Nguyễn Văn Thủ P12 Q2',N'01245632541','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,1,N'Trần',N' Thị U',N'012452152',N'182 Nguyễn Du P12 Q9',N'012525632541','2012-01-14',1)
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(2,2,N'Nguyễn',N' Thị V',N'011211245',N'182 Trương Định P12 Q11',N'09199658541','2012-01-14',1)	
INSERT INTO NHANVIEN (MaLoaiNhanVien, MaNhaHang, Ho, Ten, CMND, DiaChi, DienThoai, NgayVaoLam, TinhTrang) 
VALUES(3,1,N'Trần',N' Thị Z',N'012125698',N'182 Đinh Bộ Lĩnh P12 Q12',N'0948563214','2012-01-14',1)
GO

INSERT INTO NGUOIDUNG (MaNhanVien, TenDangNhap, MatKhau) VALUES (1,'qlct1','1234567;')
INSERT INTO NGUOIDUNG (MaNhanVien, TenDangNhap, MatKhau) VALUES (2,'qlnh1','1234567;')
INSERT INTO NGUOIDUNG (MaNhanVien, TenDangNhap, MatKhau) VALUES (7,'tieptan1','1234567;')
INSERT INTO NGUOIDUNG (MaNhanVien, TenDangNhap, MatKhau) VALUES (12,'thungan1','1234567;')
INSERT INTO NGUOIDUNG (MaNhanVien, TenDangNhap, MatKhau) VALUES (17,'qlkho1','1234567;')
GO

INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (7,14,3,2012,3)		      			   
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (8,14,2,2012,3)
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (9,30,3,2012,2)
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (9,31,3,2012,2)
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (9,1,4,2012,2)
INSERT INTO NHANVIEN_LOG (MaNhanVien, Ngay, Thang, Nam, TinhTrang) VALUES (9,2,4,2012,2)
GO

INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(7,1,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(7,2,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(7,3,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(7,4,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(7,5,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(7,6,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(7,7,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(9,1,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(9,2,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(9,3,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(9,4,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(9,5,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(9,6,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(9,7,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(5,1,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(5,2,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(5,3,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(5,4,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(5,5,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(5,6,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(5,7,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(3,1,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(3,2,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(3,3,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(3,4,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(3,5,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(3,6,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(3,7,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(11,1,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(11,2,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(11,3,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(11,4,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(11,5,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(11,6,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(11,7,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(13,1,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(13,2,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(13,3,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(13,4,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(13,5,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(13,6,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(13,7,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(15,1,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(15,2,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(15,3,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(15,4,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(15,5,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(15,6,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(15,7,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(12,1,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(12,2,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(12,3,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(12,4,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(12,5,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(12,6,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(12,7,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(14,1,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(14,2,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(14,3,1)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(14,4,2)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(14,5,3)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(14,6,4)
INSERT INTO LICH (MaNhanVien, Thu, Ca) VALUES(14,7,1)
GO

INSERT INTO KHOHANG (TenKhoHang, MaNhaHang) VALUES(N'Kho hang 1',1)
INSERT INTO KHOHANG (TenKhoHang, MaNhaHang) VALUES(N'Kho hang 2',2)
INSERT INTO KHOHANG (TenKhoHang, MaNhaHang) VALUES(N'Kho hang 3',3)
INSERT INTO KHOHANG (TenKhoHang, MaNhaHang) VALUES(N'Kho hang 3',4)
GO

INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Nước mắm',N'Lít')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Nước tương',N'Lít')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Dấm',N'Lít')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Dầu mè',N'Lít')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Dầu phộng',N'Lít')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Dầu chuối',N'Lít')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Tương ớt',N'Thùng')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Tương cà',N'Thùng')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Tương xí muội',N'Thùng')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Tương đen',N'Thùng')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Dầu hào',N'Thùng')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Ớt',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Tỏi',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Tiêu',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Hành tím',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Đường',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Muối',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Bột ngọt',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Bột bắp',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Bột gạo',N'Kg')
INSERT INTO NGUYENLIEU (TenNguyenLieu, DonViTinh) VALUES(N'Bột mì',N'Kg')
GO

INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,1,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,2,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,3,5,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,4,5,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,5,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,6,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,7,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,8,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,9,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,10,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,11,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,12,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,13,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,14,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,15,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(1,16,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(2,7,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(2,8,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(2,9,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(2,1,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(2,2,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(2,3,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(3,4,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(3,5,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(3,6,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(3,7,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(3,8,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(3,9,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(4,1,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(4,2,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(4,3,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(4,4,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(4,5,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(4,6,10,15,5)
INSERT INTO KHOHANG_NGUYENLIEU (MaKhoHang, MaNguyenLieu, SoLuongTon, SucChua, MucChuaToiThieu) VALUES(4,7,10,15,5)
GO

INSERT INTO THOIDIEMTHANHTOAN (ThoiDiemThanhToan) VALUES(N'Theo mức nợ')
INSERT INTO THOIDIEMTHANHTOAN (ThoiDiemThanhToan) VALUES(N'Cuối ngày')
INSERT INTO THOIDIEMTHANHTOAN (ThoiDiemThanhToan) VALUES(N'Cuối tuần')
INSERT INTO THOIDIEMTHANHTOAN (ThoiDiemThanhToan) VALUES(N'Cuối tháng')
GO

INSERT INTO THOIDIEMGUIDS (TenThoiDiemGuiDS) VALUES(N'Thỏa thuận ban đầu')
INSERT INTO THOIDIEMGUIDS (TenThoiDiemGuiDS) VALUES(N'Cuối ngày')
INSERT INTO THOIDIEMGUIDS (TenThoiDiemGuiDS) VALUES(N'Cuối tuần')
INSERT INTO THOIDIEMGUIDS (TenThoiDiemGuiDS) VALUES(N'Cuối tháng')
GO

INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'Nước mắm hảo hạn','0836525638','151142536521',1,1)
INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'Vườn rau','0825362415','125324526984',2,2)
INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'Thủy hải sản','0812563241','124211252365',3,3)
INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'Vựa trái cây','0841523621','151145142563',4,4)
INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'NCC Nông Sản miền Nam','0841414141','090909090909',1,1)
INSERT INTO NHACUNGCAP (TenNhaCungCap, DienThoai, SoTaiKhoan, MaThoiDiemThanhToan, MaThoiDiemGuiDS) VALUES(N'NCC Mới VN','081234567','081234567',2,1)
GO

INSERT INTO DINHMUCNO (MaNhaCungCap, GiaTriDinhMuc, NgayApDung) VALUES(1,20000,'2011-1-1')
INSERT INTO DINHMUCNO (MaNhaCungCap, GiaTriDinhMuc, NgayApDung) VALUES(1,15000,'2011-6-1')
INSERT INTO DINHMUCNO (MaNhaCungCap, GiaTriDinhMuc, NgayApDung) VALUES(1,30000,'2011-12-1')
INSERT INTO DINHMUCNO (MaNhaCungCap, GiaTriDinhMuc, NgayApDung) VALUES(1,10000,'2012-4-1')
GO

INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang,TongNo) VALUES(1,1,1,5000)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(2,1,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(3,1,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(4,1,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang,TongNo) VALUES(1,2,1,5000)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(2,2,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(3,2,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(4,2,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(1,3,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(2,3,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(3,3,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(4,3,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(1,4,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang,TongNo) VALUES(1,5,1,50000)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(2,4,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(3,4,1)
INSERT INTO NHAHANG_NHACUNGCAP (MaNhaCungCap, MaNhaHang,TinhTrang) VALUES(4,4,1)
GO

INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,1,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,2,22)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,3,33)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,4,44)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(2,2,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(3,3,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(4,4,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,5,10)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(2,6,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(3,7,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(4,8,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,9,25)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,10,12)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(2,1,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(3,11,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(4,12,21)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,13,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(2,14,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(3,15,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(4,16,14)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(1,17,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(2,18,20)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(3,19,27)
INSERT INTO NHACUNGCAP_NGUYENLIEU (MaNhaCungCap, MaNguyenLieu,DonGia) VALUES(4,20,20)
GO

INSERT INTO THONGTINHANGNHAP (MaKhoHang, NgayGioNhap) VALUES(1,'2012-03-31')
INSERT INTO THONGTINHANGNHAP (MaKhoHang, NgayGioNhap) VALUES(1,'2012-04-1')
INSERT INTO THONGTINHANGNHAP (MaKhoHang, NgayGioNhap) VALUES(1,'2012-04-2')
INSERT INTO THONGTINHANGNHAP (MaKhoHang, NgayGioNhap) VALUES(2,'2012-04-1')
INSERT INTO THONGTINHANGNHAP (MaKhoHang, NgayGioNhap) VALUES(3,'2012-04-2')
GO

INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(1,1,1,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(1,2,2,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(1,3,7,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia,SoLuong) VALUES(1,4,12,21,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(2,1,5,10,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(2,2,6,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(2,3,11,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(2,4,16,14,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(3,1,9,25,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(3,2,1,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(3,3,15,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(4,1,13,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(4,2,14,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(4,3,3,20,10)
INSERT INTO CHITIETHANGNHAP (MaThongTinHangNhap ,MaNhaCungCap, MaNguyenLieu, DonGia, SoLuong) VALUES(4,4,20,20,10)
GO

INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'Gà tiềm thuốc bắc',200)
INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'Bò bít tết',75)
INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'Bò nhúng dấm',60)
INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'Bánh canh',35)
INSERT INTO MONAN (TenMonAn, DonGia) VALUES (N'Bò lá lốt mỡ chài',25)
GO

INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (1,1,05)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (1,2,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (1,3,0.5)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (1,4,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (2,5,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (2,6,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (2,7,2)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (2,8,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (3,9,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (3,10,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (3,11,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (3,12,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (4,13,2)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (4,14,0.5)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (4,15,0.5)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (4,16,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (5,17,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (5,18,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (5,19,1)
INSERT INTO MONAN_NGUYENLIEU (MaMonAn, MaNguyenLieu, SoLuong) VALUES (5,20,1)
GO

INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'Nướng')
INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'Luộc')
INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'Chiên')
INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'Quay')
INSERT INTO LOAIMONAN (TenLoaiMonAn) VALUES (N'Xào')
GO

INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (1,1,1)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (1,2,2)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (1,3,3)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (1,4,4)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (2,5,5)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (2,1,5)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (2,2,4)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (2,3,3)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (2,4,2)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (3,5,1)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (3,1,1)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (3,2,2)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (3,3,3)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (3,4,4)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (4,5,5)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (4,1,5)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (4,2,4)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (4,3,3)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (4,4,2)
INSERT INTO PHANLOAIMONAN (MaNhaHang, MaLoaiMonAn, MaMonAn) VALUES (4,5,1)

GO

INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (1,'2012-4-1')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (2,'2012-2-1')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (3,'2012-1-5')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (4,'2012-4-1')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (1,'2012-4-2')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (2,'2012-4-1')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (3,'2012-4-2')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (4,'2012-4-2')
INSERT INTO THUCDON(MaNhaHang, NgayApDung) VALUES (1,'2012-4-3')
GO

INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (1,1,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (1,2,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (1,3,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (2,4,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (2,5,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (3,1,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (3,2,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (4,3,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (4,4,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (5,5,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (5,1,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (6,2,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (6,3,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (7,4,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (7,5,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (8,1,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (8,2,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (9,3,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (9,4,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (9,5,50)
INSERT INTO CHITIETTHUCDON(MaThucDon, MaMonAn, DonGia) VALUES (9,1,50)
GO

INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Trệt',1,30)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Gác lửng',1,25)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Lầu 1',1,35)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Trệt',2,30)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Lầu 1',2,35)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Lầu 2',2,35)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Ngoài vườn',3,40)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Phòng máy lạnh',3,40)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Lầu 1',3,35)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Trệt',4,30)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Sân thượng',4,45)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Máy lạnh',4,40)
INSERT INTO KHUVUC (TenKhuVuc, MaNhaHang, GiaBan) VALUES (N'Vườn',4,40)
GO

INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',1,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',1,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',1,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',1,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',1,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',1,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',1,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',2,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',2,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',2,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',2,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',2,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',2,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',2,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',3,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',3,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',3,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',3,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',3,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',3,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',3,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',4,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',4,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',4,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',4,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',4,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',4,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',4,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',5,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',5,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',5,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',5,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',5,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',5,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',5,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',6,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',6,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',6,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',6,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',6,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',6,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',6,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',7,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',7,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',7,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',7,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',7,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',7,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',7,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',8,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',8,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',8,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',8,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',8,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',8,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',9,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',9,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',9,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',9,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',9,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',9,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',10,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',10,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',10,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',10,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',10,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',10,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',11,1)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',11,1)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',11,1)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',11,1)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',11,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',11,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',12,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',12,3)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',12,3)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',12,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',12,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',12,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',12,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 1',13,3)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 2',13,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 3',13,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 4',13,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 5',13,2)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 6',13,4)
INSERT INTO THONGTINBAN (TenBan, MaKhuVuc, SucChua) VALUES (N'Bàn 7',13,4)
GO

INSERT INTO THONGTINKHACHHANG (HoTen, CMND, DienThoai) VALUES (N'Đinh Văn Hưng','024152361','0919965412')
INSERT INTO THONGTINKHACHHANG (HoTen, CMND, DienThoai) VALUES (N'Võ Quang Lộc','012365214','0974854786')
INSERT INTO THONGTINKHACHHANG (HoTen, CMND, DienThoai) VALUES (N'Nguyễn Thị Huệ','0214125214','0965852145')
INSERT INTO THONGTINKHACHHANG (HoTen, CMND, DienThoai) VALUES (N'Lê Bá Ngọc','0214136985','0963258769')
INSERT INTO THONGTINKHACHHANG (HoTen, CMND, DienThoai) VALUES (N'Phạm Thị Thanh','0125201423','0912512391')
INSERT INTO THONGTINKHACHHANG (HoTen, CMND, DienThoai) VALUES (N'Trần Minh Hải','102141520','09968668522')
GO

INSERT INTO BUOI (TenBuoi) VALUES (N'Sáng')
INSERT INTO BUOI (TenBuoi) VALUES (N'Trưa')
INSERT INTO BUOI (TenBuoi) VALUES (N'Chiều')
INSERT INTO BUOI (TenBuoi) VALUES (N'Tối')

GO
INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi,MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES (1,'2012-04-15',1,1,2,1)
INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi,MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES (1,'2012-04-16',1,2,4,0)
INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi,MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES (3,'2012-04-16',2,3,3,1)
INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi,MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES (7,'2012-04-17',1,4,2,1)
INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi,MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES (8,'2012-04-16',4,5,5,0)
INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi,MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES (11,'2012-04-17',3,6,8,0)
INSERT INTO LICHBAN (MaBan, NgayDatBan, MaBuoi,MaThongTinKhachHang, SoLuong, TinhTrangBan) VALUES (21,'2012-04-06',4,NULL,3,1)
GO

INSERT INTO HOADON (MaHoaDon, MaLichBan, NgayLapHoaDon, MaThongTinBanDat) VALUES ('21EC2020-3AEA-1069-A2DD-08002B30309D',1,'2012-04-15',1)
GO

INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('21EC2020-3AEA-1069-A2DD-08002B30309D',1,30,1)
INSERT INTO CHITIETHOADON (MaHoaDon, MaChiTietThucDon, DonGia, SoLuong) VALUES ('21EC2020-3AEA-1069-A2DD-08002B30309D',3,45,1)
GO

INSERT INTO QUIDINH (ThoiGianSuDungBan) VALUES (4)