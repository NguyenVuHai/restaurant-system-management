using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class GlobalVariables
    {
        public static int maNhaHang = 1;
        public static int maNhanVien = 1;
        public static Guid curMaHoaDon;
        public static int maLichBan;
        public static bool bBongMa = false;
        public static bool bDuLieuRac = false;
        public static bool bKhongTheDocLai = false;
        public static bool bLostUpdate = false;
        public static bool bMacDinh = true;
        public static int maKhachHang;
        public static List<int> maChiTietHoaDon = new List<int>();
    }
}
