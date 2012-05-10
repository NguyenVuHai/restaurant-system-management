using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class ChiTietThucDonDTO
    {
        private int maChiTietHoaDon;

        public int MaChiTietHoaDon
        {
            get { return maChiTietHoaDon; }
            set { maChiTietHoaDon = value; }
        }
        private int maChiTietThucDon;

        public int MaChiTietThucDon
        {
            get { return maChiTietThucDon; }
            set { maChiTietThucDon = value; }
        }
        private int maThucDon;

        public int MaThucDon
        {
            get { return maThucDon; }
            set { maThucDon = value; }
        }
        private string tenMonAn;

        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }
        private decimal donGia;

        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private int maMonAn;

        public int MaMonAn
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private decimal thanhTien;

        public decimal ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

    }
}
