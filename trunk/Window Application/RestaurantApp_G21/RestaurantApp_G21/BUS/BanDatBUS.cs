using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.BUS
{
    class BanDatBUS
    {
        public static void ThemThongTinBanDat(BanDatDTO banDat, int loai)
        {
            BanDatDAO.ThemThongTinBanDat(banDat, loai);
        }

        public static List<BanDatDTO> LayDanhSachBanDat()
        {
            return BanDatDAO.LayDanhSachBanDat();
        }
    }
}
