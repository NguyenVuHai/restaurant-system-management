using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class MonAn_NguyenLieuDTO
    {
        private NguyenLieuDTO nguyenLieu;

        internal NguyenLieuDTO NguyenLieu
        {
            get { return nguyenLieu; }
            set { nguyenLieu = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public MonAn_NguyenLieuDTO()
        {
            nguyenLieu = new NguyenLieuDTO();
            soLuong = 0;
        }

        public override string ToString()
        {
            return nguyenLieu.TenNguyenLieu;
        }
    }
}
