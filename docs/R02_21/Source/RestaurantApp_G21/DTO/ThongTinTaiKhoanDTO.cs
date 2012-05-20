using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class ThongTinTaiKhoanDTO
    {
        private int Id;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        private string tenDangNhap;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private int loaiNhanVien;

        public int LoaiNhanVien
        {
            get { return loaiNhanVien; }
            set { loaiNhanVien = value; }
        }
        private string maNhaHang;

        public string MaNhaHang
        {
            get { return maNhaHang; }
            set { maNhaHang = value; }
        }
        private string cmnd;

        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
    }
}
