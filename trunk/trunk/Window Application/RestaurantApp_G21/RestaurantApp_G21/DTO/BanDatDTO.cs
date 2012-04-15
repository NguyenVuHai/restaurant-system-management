using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class BanDatDTO
    {
        private string hoTen;
        private string cmnd;
        private string dienThoai;
        private int maBan;
        private DateTime ngayDatBan;
        private int maBuoi;
        private int maThongTinKhachHang;
        private int soLuong;
        private bool tinhTrangBan;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }

        public DateTime NgayDatBan
        {
            get { return ngayDatBan; }
            set { ngayDatBan = value; }
        }

        public int MaBuoi
        {
            get { return maBuoi; }
            set { maBuoi = value; }
        }

        public int MaThongTinKhachHang
        {
            get { return maThongTinKhachHang; }
            set { maThongTinKhachHang = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public bool TinhTrangBan
        {
            get { return tinhTrangBan; }
            set { tinhTrangBan = value; }
        }
    }
}
