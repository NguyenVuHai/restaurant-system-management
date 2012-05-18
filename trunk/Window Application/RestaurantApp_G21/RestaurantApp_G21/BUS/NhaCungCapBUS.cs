using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.BUS
{
    class NhaCungCapBUS
    {
        //PHANTOM
        public static int phantomThemMoi(NhaCungCapDTO dto)
        {
            return NhaCungCapDAO.phantomThemMoi(dto);
        }
        //PHANTOM SOLVED
        public static int phantomSolvedThemMoi(NhaCungCapDTO dto)
        {
            return NhaCungCapDAO.phantomSolvedThemMoi(dto);
        }
        public static int themMoi(NhaCungCapDTO dto)
        {
            return NhaCungCapDAO.themMoi(dto);
        }
        //DIRTY READ
        public static int dirtyReadSetNgungGiaoDich(int maNhaCungCap, int maNhaHang, int tinhTrang)
        {
            return NhaCungCapDAO.dirtyReadSetNgungGiaoDich(maNhaCungCap, maNhaHang, tinhTrang);
        }
        //DIRTY READ SOLVED
        public static int dirtyReadSolvedSetNgungGiaoDich(int maNhaCungCap, int maNhaHang, int tinhTrang)
        {
            return NhaCungCapDAO.dirtyReadSolvedSetNgungGiaoDich(maNhaCungCap, maNhaHang, tinhTrang);
        }

        public static int setNgungGiaoDich(int maNhaCungCap, int maNhaHang, int tinhTrang)
        {
            return NhaCungCapDAO.setNgungGiaoDich(maNhaCungCap,maNhaHang,tinhTrang);
        }
        public static ArrayList layDanhSachNguyenLieuNhaCungCapCoTheDapUngTheoDonDatHang(int maNhaCungCap, string sqlWHEREor)
        {
            return NhaCungCapDAO.layDanhSachNguyenLieuNhaCungCapCoTheDapUngTheoDonDatHang(maNhaCungCap, sqlWHEREor);
        }
    }
}
