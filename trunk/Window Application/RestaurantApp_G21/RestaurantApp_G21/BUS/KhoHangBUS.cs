using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;
namespace RestaurantApp_G21.BUS
{
    class KhoHangBUS
    {
        public static KhoHangDTO layThongTinKhoHangTheoNhaHang(int maNhaHang)
        {
            return KhoHangDAO.layThongTinKhoHangTheoNhaHang(maNhaHang);
        }
        public static ArrayList layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoThoiDiemThanhToan(int maNhaHang)
        {
            return KhoHangDAO.layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoThoiDiemThanhToan(maNhaHang);
        }
        public static ArrayList layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoDinhMucNo(int maNhaHang)
        {
            return KhoHangDAO.layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoDinhMucNo(maNhaHang);
        }
        public static ArrayList timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich(string ten, int maNhaHang)
        {
            return KhoHangDAO.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich(ten, maNhaHang);
        }
        public static ArrayList timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(string ten, int tinhTrangGiaoDich, int maNhaHang)
        {
            return KhoHangDAO.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(ten, tinhTrangGiaoDich, maNhaHang);
        }
        public static ArrayList layDanhSachNhaCungCap(int maNhaHang, string ten)
        {
            return KhoHangDAO.layDanhSachNhaCungCap(maNhaHang, ten);
        }
        public static ArrayList traCuuNhaCungCapThoaYeuCauNguyenLieuCanDatHang(string sqlFROM)
        {
            return KhoHangDAO.traCuuNhaCungCapThoaYeuCauNguyenLieuCanDatHang(sqlFROM);
        }
        public static ArrayList layDSKhoHang_NguyenLieu(int maNhaHang, NguyenLieuDTO nguyenLieuCanTim)
        {
            return KhoHangDAO.traCuuKhoHangNguyenLieuGanDung(maNhaHang,nguyenLieuCanTim);
        }

        public static KhoHang_NguyenLieuDTO layChiTietKhoHang_NguyenLieu(int maNhaHang, NguyenLieuDTO nguyenLieuCanTim)
        {
            return KhoHangDAO.layChiTietKhoHangNguyenLieu(maNhaHang, nguyenLieuCanTim);
        }
        public static ArrayList layDanhSachNguyenLieuDangOKhoangMucToiThieu(int maNhaHang)
        {
            return KhoHangDAO.layDanhSachNguyenLieuDangOKhoangMucToiThieu(maNhaHang);
        }
    }
}
