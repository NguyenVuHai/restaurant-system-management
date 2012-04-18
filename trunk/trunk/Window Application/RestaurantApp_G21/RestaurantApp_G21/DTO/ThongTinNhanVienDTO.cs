﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class ThongTinNhanVienDTO
    {
        private int maNhanVien;
        private int maNhaHang;
        private string tenNhaHang;
        private int maLoaiNhanVien;
        private string tenLoaiNhanVien;
        private string ho;
        private string ten;
        private string cmnd;
        private string diaChi;
        private string dienThoai;
        private DateTime ngayVaoLam;
        private int tinhTrang;

        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public int MaNhaHang
        {
            get { return maNhaHang; }
            set { maNhaHang = value; }
        }

        public int MaLoaiNhanVien
        {
            get { return maLoaiNhanVien; }
            set { maLoaiNhanVien = value; }
        }

        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        public DateTime NgayVaoLam
        {
            get { return ngayVaoLam; }
            set { ngayVaoLam = value; }
        }

        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
    }
}
