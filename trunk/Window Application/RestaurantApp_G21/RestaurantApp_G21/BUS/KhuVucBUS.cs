using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class KhuVucBUS
    {
        public static List<KhuVucDTO> LayDanhSachKhuVuc(int maNhaHang)
        {
            return KhuVucDAO.LayDanhSachKhuVuc(maNhaHang);
        }

        public static List<KhuVucDTO> TimBanTrong(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, string buoi, int soLuong)
        {
            return KhuVucDAO.TimBanTrong(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
        }
    }
}
