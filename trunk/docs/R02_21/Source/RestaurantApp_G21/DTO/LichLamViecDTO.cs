using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class LichLamViecDTO
    {
        private int maNhanVien;
        private string hoNhanVien;
        private string tenNhanVien;
        private int thu;
        private int ca;

        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string HoNhanVien
        {
            get { return hoNhanVien; }
            set { hoNhanVien = value; }
        }

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        public int Thu
        {
            get { return thu; }
            set { thu = value; }
        }

        public int Ca
        {
            get { return ca; }
            set { ca = value; }
        }
    }
}
