using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class ChiTietHangNhapDTO
    {
        private int maChiTietHangNhap;

        public int MaChiTietHangNhap
        {
            get { return maChiTietHangNhap; }
            set { maChiTietHangNhap = value; }
        }
        private NguyenLieuDTO nguyenLieu;

        internal NguyenLieuDTO NguyenLieu
        {
            get { return nguyenLieu; }
            set { nguyenLieu = value; }
        }
        private NhaCungCapDTO nhaCungCap;

        internal NhaCungCapDTO NhaCungCap
        {
            get { return nhaCungCap; }
            set { nhaCungCap = value; }
        }
        private decimal donGia;

        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private decimal soLuong;

        public decimal SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private bool tinhTrangGiaoDich;

        public bool TinhTrangGiaoDich
        {
            get { return tinhTrangGiaoDich; }
            set { tinhTrangGiaoDich = value; }
        }
        private bool tinhTrangThanhToan;

        public bool TinhTrangThanhToan
        {
            get { return tinhTrangThanhToan; }
            set { tinhTrangThanhToan = value; }
        }

        private int maThongTinHangNhap;

        public int MaThongTinHangNhap
        {
            get { return maThongTinHangNhap; }
            set { maThongTinHangNhap = value; }
        }
        public ChiTietHangNhapDTO()
        {
            maThongTinHangNhap = 0;
            maChiTietHangNhap = 0;
            nguyenLieu = new NguyenLieuDTO();
            nhaCungCap = new NhaCungCapDTO();
            donGia = 0;
            soLuong = 0;
            tinhTrangGiaoDich = false;
            tinhTrangThanhToan = false;
        }
        public override string ToString()
        {
            return nguyenLieu.TenNguyenLieu;
        }
    }
}
