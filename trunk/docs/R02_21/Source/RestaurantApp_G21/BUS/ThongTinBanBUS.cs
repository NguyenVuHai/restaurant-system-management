using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class ThongTinBanBUS
    {
        public static List<ThongTinBanDTO> LayDanhSachThongTinBan(int maKhuVuc)
        {
            return ThongTinBanDAO.LayDanhSachThongTinBan(maKhuVuc);
        }


        public static List<ThongTinBanDTO> TimBanTrong(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, int buoi, int soLuong)
        {
            return ThongTinBanDAO.TimBanTrong(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
        public static List<ThongTinBanDTO> TimBanTrongDirtyRead(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, int buoi, int soLuong)
        {
            return ThongTinBanDAO.TimBanTrongDirtyRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
        public static List<ThongTinBanDTO> TimBanTrongSolvedDirtyRead(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, int buoi, int soLuong)
        {
            return ThongTinBanDAO.TimBanTrongSolvedDirtyRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
        public static List<ThongTinBanDTO> TimBanTrongSolvedUnRRead(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, int buoi, int soLuong)
        {
            return ThongTinBanDAO.TimBanTrongSolvedUnRRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
        public static List<ThongTinBanDTO> TimBanTrongUnRRead(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, int buoi, int soLuong)
        {
            return ThongTinBanDAO.TimBanTrongUnRRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
        public static List<ThongTinBanDTO> TimBanTrongPhanTom(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, int buoi, int soLuong)
        {
            return ThongTinBanDAO.TimBanTrongPhanTom(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
        public static List<ThongTinBanDTO> TimBanTrongSolvedPhanTom(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, int buoi, int soLuong)
        {
            return ThongTinBanDAO.TimBanTrongSolvedPhanTom(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
    }
}
