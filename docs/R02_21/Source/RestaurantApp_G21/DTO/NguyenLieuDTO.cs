using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class NguyenLieuDTO
    {
        int maNguyenLieu;

        public int MaNguyenLieu
        {
            get { return maNguyenLieu; }
            set { maNguyenLieu = value; }
        }
        string tenNguyenLieu;

        public string TenNguyenLieu
        {
            get { return tenNguyenLieu; }
            set { tenNguyenLieu = value; }
        }
        string donViTinh;

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        public NguyenLieuDTO()
        {
            maNguyenLieu = 0;
            tenNguyenLieu = "";
            donViTinh = "";
            donGia = 0;
        }

        private decimal donGia;

        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public override string ToString()
        {
            return tenNguyenLieu;
        }
    }
}
