using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.BUS
{
    class LoaiNhanVienBUS
    {
        public static List<LoaiNhanVienDTO> LayDanhSachLoaiNhanVien()
        {
            return LoaiNhanVienDAO.LayDanhSachLoaiNhanVien();
        }
    }
}
