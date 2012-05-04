﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class HoaDonBUS
    {
        public static Guid ThemHoaDon(int maLichBan, DateTime ngayLapHoaDon)
        {
            return HoaDonDAO.ThemHoaDon(maLichBan, ngayLapHoaDon);
        }

        public static void ThemMonAn(Guid maHoaDon, int maChiTietThucDon, decimal donGia, int soLuong)
        {
            HoaDonDAO.ThemMonAn(maHoaDon, maChiTietThucDon, donGia, soLuong);
        }

        public static string KiemTraHoaDon(int maLichBan)
        {
            return HoaDonDAO.KiemTraHoaDon(maLichBan);
        }
    }
}
