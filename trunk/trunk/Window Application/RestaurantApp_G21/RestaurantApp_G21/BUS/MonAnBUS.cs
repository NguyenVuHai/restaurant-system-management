using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;
namespace RestaurantApp_G21.BUS
{
    class MonAnBUS
    {
        public static ArrayList layDanhSachNguyenLieuTheoMonAn(MonAnDTO monAn)
        {
            return MonAnDAO.layDanhSachNguyenLieuTheoMonAn(monAn);
        }
    }
}
