using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class HoaDonBUS
    {
        public static void ThemHoaDon(int maLichBan, DateTime ngayLapHoaDon)
        {
            HoaDonDAO.ThemHoaDon(maLichBan, ngayLapHoaDon);
        }

        public static bool KiemTraHoaDon(int maLichBan)
        {
            return HoaDonDAO.KiemTraHoaDon(maLichBan);
        }
    }
}
