using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace RestaurantApp_G21.DTO
{
    class ThongTinHangNhapDTO
    {
        private int maThongTinHangNhap;

        public int MaThongTinHangNhap
        {
            get { return maThongTinHangNhap; }
            set { maThongTinHangNhap = value; }
        }
        private DateTime ngayNhap;

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        private KhoHangDTO khoHang;

        internal KhoHangDTO KhoHang
        {
            get { return khoHang; }
            set { khoHang = value; }
        }

        private ArrayList chiTietHangNhap;

        public ArrayList ChiTietHangNhap
        {
            get { return chiTietHangNhap; }
            set { chiTietHangNhap = value; }
        }
        public ThongTinHangNhapDTO()
        {
            maThongTinHangNhap = 0;
            ngayNhap = new DateTime();
            khoHang = new KhoHangDTO();
            chiTietHangNhap = new ArrayList();
        }
        public override string ToString()
        {
            return maThongTinHangNhap.ToString();
        }

    }
}
