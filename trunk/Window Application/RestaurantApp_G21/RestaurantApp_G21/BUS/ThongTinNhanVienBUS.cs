using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class ThongTinNhanVienBUS
    {
        public static List<ThongTinNhanVienDTO> TimKiemNhanVien(int maNhanVien, int maNhaHang, int maLoaiNhanVien, string ho, string ten, string cmnd, string diaChi, string dienThoai, DateTime ngayVaoLam)
        {
            return ThongTinNhanVienDAO.TimKiemNhanVien(maNhanVien, maNhaHang, maLoaiNhanVien, ho, ten, cmnd, diaChi, dienThoai, ngayVaoLam);
        }

        public static void ThemNhanVien(ThongTinNhanVienDTO nv)
        {
            ThongTinNhanVienDAO.ThemNhanVien(nv);
        }

        internal static List<ThongTinNhanVienDTO> LoadDanhSachNhanVien()
        {
            //throw new NotImplementedException();
            return ThongTinNhanVienDAO.LoadDanhSachNhanVien();
        }

        internal static void XoaNhanVien(int maNhanVien)
        {
            ThongTinNhanVienDAO.XoaNhanVien(maNhanVien);
        }

        internal static void SuaThongTinNhanVien(int maNhanVien, int maNhaHang, int maLoaiNhanVien, bool isLostUpdate)
        {
            ThongTinNhanVienDAO.SuaThongTinNhanVien(maNhanVien, maNhaHang, maLoaiNhanVien, isLostUpdate);
        }
    }
}
