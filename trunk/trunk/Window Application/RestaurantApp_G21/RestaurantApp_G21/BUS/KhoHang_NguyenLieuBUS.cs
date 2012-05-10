using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.BUS
{
    class KhoHang_NguyenLieuBUS
    {
        public static int capNhatChiTietKhoHangNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            if (dto != null && dto.NguyenLieu.MaNguyenLieu != 0 && maNhaHang != 0)
            {
                return KhoHang_NguyenLieuDAO.capNhatChiTietKhoHangNguyenLieu(dto, maNhaHang);
            }
            return 0;
        }
    }
}
