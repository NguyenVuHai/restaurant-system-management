﻿using System;
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
