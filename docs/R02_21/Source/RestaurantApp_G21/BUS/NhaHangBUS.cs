using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;
using System.Data;

namespace RestaurantApp_G21.BUS
{
    class NhaHangBUS
    {
        public static List<NhaHangDTO> LayDanhSachNhaHang()
        {
            return NhaHangDAO.LayDanhSachNhaHang();
        }
        public static DataTable LayBangNhaHang()
        {
            return NhaHangDAO.LayBangNhaHang();
        }
        public static bool ThemNhaHang(NhaHangDTO nhaHang)
        {
            if (NhaHangDAO.ThemNhaHang(nhaHang))
                return true;
            return false;
        }
        public static bool XoaNhaHang(string maNhaHang)
        {
            if (NhaHangDAO.XoaNhaHang(maNhaHang))
                return true;
            return false;
        }
        public static bool SuaNhaHang(NhaHangDTO nhaHang)
        {
            if (NhaHangDAO.SuaNhaHang(nhaHang))
                return true;
            return false;
        }
    }
}
