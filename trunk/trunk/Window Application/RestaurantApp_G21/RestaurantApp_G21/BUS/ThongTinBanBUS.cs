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


        public static List<ThongTinBanDTO> TimBanTrong(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, string buoi, int soLuong)
        {
            return ThongTinBanDAO.TimBanTrong(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
    }
}
