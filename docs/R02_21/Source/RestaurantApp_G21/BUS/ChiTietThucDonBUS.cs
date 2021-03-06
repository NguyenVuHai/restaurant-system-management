﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class ChiTietThucDonBUS
    {
        public static List<ChiTietThucDonDTO> LayDanhSachMonAnTheoNhaHang(int maNhaHang, DateTime ngay)
        {
            return ChiTietThucDonDAO.LayDanhSachMonAnTheoNhaHang(maNhaHang,ngay);
        }

        public static List<ChiTietThucDonDTO> LayDanhSachMonAnTrongHoaDon(Guid maHoaDon, bool isPhantom, bool isDirtyRead, bool isUnrepeatableRead, bool isLostUpdate)
        {
            return ChiTietThucDonDAO.LayDanhSachMonAnTrongHoaDon(maHoaDon, isPhantom, isDirtyRead, isUnrepeatableRead, isLostUpdate);
        }
    }
}
