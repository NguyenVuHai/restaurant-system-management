using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class ThongKeNhanVienDTO
    {
        private int maNhaHang;
        private string tenNhaHang;
        private int tongNhanVien;

        public int MaNhaHang
        {
            get { return maNhaHang; }
            set { maNhaHang = value; }
        }

        public string TenNhaHang
        {
            get { return tenNhaHang; }
            set { tenNhaHang = value; }
        }

        public int TongNhanVien
        {
            get { return tongNhanVien; }
            set { tongNhanVien = value; }
        }
    }
}
