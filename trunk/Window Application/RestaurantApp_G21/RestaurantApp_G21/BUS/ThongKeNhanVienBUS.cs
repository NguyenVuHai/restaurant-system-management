using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class ThongKeNhanVienBUS
    {
        internal static int TinhTongNhanVien(int maNhaHang)
        {
            return ThongKeNhanVienDAO.TinhTongNhanVien(maNhaHang);
        }
    }
}
