using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class BuoiBUS
    {
        public static List<BuoiDTO> LayDanhSachBuoi()
        {
            return BuoiDAO.LayDanhSachBuoi();
        }
    }
}
