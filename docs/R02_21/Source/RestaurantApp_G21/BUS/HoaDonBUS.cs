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

        public static string KiemTraHoaDon(int maLichBan)
        {
            return HoaDonDAO.KiemTraHoaDon(maLichBan);
        }

        public static void XoaMonAn(List<int> maChiTietHoaDon, bool isDirtyRead, bool isUnrepeatableRead)
        {
            StringBuilder strChiTietHoaDon = new StringBuilder();
            foreach (var oMaChiTietHoaDon in maChiTietHoaDon)
            {
                strChiTietHoaDon.AppendFormat("{0},", oMaChiTietHoaDon);
            }
            HoaDonDAO.XoaMonAn(strChiTietHoaDon.ToString().Substring(0, strChiTietHoaDon.Length - 1), isDirtyRead, isUnrepeatableRead);
        }

        public static void CapNhatChiTietHoaDon(Guid maHoaDon, int maChiTietThucDon, decimal donGia, int soLuong, bool isPhantom, bool isDirtyRead, bool isLostUpdate)
        {
            HoaDonDAO.CapNhatChiTietHoaDon(maHoaDon, maChiTietThucDon, donGia, soLuong, isPhantom, isDirtyRead, isLostUpdate);
        }

    }
}
