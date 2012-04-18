using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class LoaiNhanVienDTO
    {
        private int maLoaiNhanVien;
        private string tenLoaiNhanVien;
        private decimal luong;

        public int MaLoaiNhanVien
        {
            get { return maLoaiNhanVien; }
            set { maLoaiNhanVien = value; }
        }

        public string TenLoaiNhanVien
        {
            get { return tenLoaiNhanVien; }
            set { tenLoaiNhanVien = value; }
        }

        public decimal Luong
        {
            get { return luong; }
            set { luong = value; }
        }
    }
}
