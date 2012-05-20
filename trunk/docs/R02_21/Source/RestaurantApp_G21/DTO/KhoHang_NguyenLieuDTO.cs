using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class KhoHang_NguyenLieuDTO
    {
        private NguyenLieuDTO nguyenLieu;

        internal NguyenLieuDTO NguyenLieu
        {
            get { return nguyenLieu; }
            set { nguyenLieu = value; }
        }
        private int soLuongXuat;//tai tung thoi diem

        public int SoLuongXuat
        {
            get { return soLuongXuat; }
            set { soLuongXuat = value; }
        }
        private int soLuongTon;

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }
        private int sucChua;

        public int SucChua
        {
            get { return sucChua; }
            set { sucChua = value; }
        }
        private int mucTonToiThieu;

        public int MucTonToiThieu
        {
            get { return mucTonToiThieu; }
            set { mucTonToiThieu = value; }
        }

        public KhoHang_NguyenLieuDTO()
        {
            nguyenLieu = new NguyenLieuDTO();
            soLuongTon = 0;
            soLuongXuat = 0;
            sucChua = 0;
            mucTonToiThieu = 0;
        }

        public override string ToString()
        {
            //return soLuongTon.ToString();
            return nguyenLieu.MaNguyenLieu.ToString();
        }
    }
}
