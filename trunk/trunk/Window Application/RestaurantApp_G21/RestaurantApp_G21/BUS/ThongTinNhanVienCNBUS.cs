using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class ThongTinNhanVienCNBUS
    {
        public static DataTable TTNhanVien()
        {
            return ThongTinNhanVienCNDAO.TTNhanVien();
        }
        public static DataTable LayThongTinNhanVien(/*,int maNhaHang int maLoaiNhanVien*/)
        {
            return ThongTinNhanVienCNDAO.LayThongTinNhanVien(/*maNhaHang, maLoaiNhanVien*/);
        }
    }
}
