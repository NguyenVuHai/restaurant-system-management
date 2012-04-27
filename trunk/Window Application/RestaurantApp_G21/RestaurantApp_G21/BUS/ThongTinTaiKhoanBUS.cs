using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;
using System.Data;

namespace RestaurantApp_G21.BUS
{
    class ThongTinTaiKhoanBUS
    {
        public static List<ThongTinTaiKhoanDTO> LayThongTinTaiKhoan(string userName, string pass)
        {
            return ThongTinTaiKhoanDAO.LayThongTinTaiKhoan(userName, pass);
        }
        public static ThongTinTaiKhoanDTO KiemTraDangNhap(string userName, string pass)
        {

            return ThongTinTaiKhoanDAO.KiemTraDangNhap(userName, pass);
        }
        public static bool DoiMatKhau(string userName, string pass)
        {
            if (ThongTinTaiKhoanDAO.DoiMatKhau(userName, pass))
                return true;
            return false;
        }
        public static DataTable LayBangNguoiDung()
        {
            return ThongTinTaiKhoanDAO.LayBangNguoiDung();
        }
        public static bool ThemTaiKhoan(int maNhanVien, string tenDangNhap, string matKhau)
        {
            if (ThongTinTaiKhoanDAO.ThemTaiKhoan(maNhanVien, tenDangNhap, matKhau))
                return true;
            return false;
        }
    }
}
