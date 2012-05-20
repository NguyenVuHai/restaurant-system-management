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
        /*public static List<ThongTinNhanVienDTO> TimKiemNhanVien(int maNhanVien, int maNhaHang, int maLoaiNhanVien, string ho, string ten, string cmnd, string diaChi, string dienThoai, DateTime ngayVaoLam)
        {
            return ThongTinNhanVienDAO.TimKiemNhanVien(maNhanVien, maNhaHang, maLoaiNhanVien, ho, ten, cmnd, diaChi, dienThoai, ngayVaoLam);
        }

        public static void ThemNhanVien(ThongTinNhanVienDTO nv)
        {
            ThongTinNhanVienDAO.ThemNhanVien(nv);
        }

        internal static List<ThongTinNhanVienDTO> LoadDanhSachNhanVien()
        {
            
            return ThongTinNhanVienDAO.LoadDanhSachNhanVien();
        }

        internal static void XoaNhanVien(int maNhanVien)
        {
            ThongTinNhanVienDAO.XoaNhanVien(maNhanVien);
        }

        internal static void SuaThongTinNhanVien(int maNhanVien, int maNhaHang, int maLoaiNhanVien, bool isLostUpdate)
        {
            ThongTinNhanVienDAO.SuaThongTinNhanVien(maNhanVien, maNhaHang, maLoaiNhanVien, isLostUpdate);
        }*/
        internal static List<ThongTinNhanVienDTO> LoadDanhSachNhanVien()
        {
            return ThongTinNhanVienDAO.LoadDanhSachNhanVien();
        }


        internal static void EditThongTinNhanVien(ThongTinNhanVienDTO nv, int loaiTruyXuat)
        {
            ThongTinNhanVienDAO.EditThongTinNhanVien(nv, loaiTruyXuat);
        }

        internal static void AddThongTinNhanVien(ThongTinNhanVienDTO nv)
        {
            ThongTinNhanVienDAO.AddThongTinNhanVien(nv);

        }

        internal static List<ThongTinNhanVienDTO> FindNhanVien(ThongTinNhanVienDTO nv, int loaiTruyXuat)
        {
            return ThongTinNhanVienDAO.FindNhanVien(nv, loaiTruyXuat);
        }

        internal static void DeleteThongTinNhanVien(int maNhanVien)
        {
            ThongTinNhanVienDAO.DeleteThongTinNhanVien(maNhanVien);
        }

        internal static int SumNhanVien(int maNH, int loaiTruyXuat)
        {
            return ThongTinNhanVienDAO.SumNhanVien(maNH,loaiTruyXuat);
        }
    }
}
