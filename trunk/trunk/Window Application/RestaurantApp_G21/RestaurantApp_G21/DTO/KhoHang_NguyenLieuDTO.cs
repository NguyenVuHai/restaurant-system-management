using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class KhoHang_NguyenLieuDTO
    {
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
            soLuongTon = 0;
            sucChua = 0;
            mucTonToiThieu = 0;
        }

        public override string ToString()
        {
            return soLuongTon.ToString();
        }
    }
}
