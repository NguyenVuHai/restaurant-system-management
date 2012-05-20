using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class KhuVucDTO
    {
        private int maKhuVuc;
        private string tenKhuVuc;
        private int maNhaHang;
        private decimal giaBan;

        public int MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }

        public string TenKhuVuc
        {
            get { return tenKhuVuc; }
            set { tenKhuVuc = value; }
        }

        public int MaNhaHang
        {
            get { return maNhaHang; }
            set { maNhaHang = value; }
        }

        public decimal GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
    }
}
