using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class ThongTinNhanVienCNDTO
    {
        private int maNV;
        private string hoNV;
        private string tenNV;
        private int maNhaH;
        private int maLoaiNV;
        private string cmndNhanVien;
        public ThongTinNhanVienCNDTO(int maNhanVien, int maLoaiNV, int maNhaHang, string hoNV, string tenNV, string cmnd)
        {
            this.MaNV = maNhanVien;
            this.CMND1 = cmnd;
            this.HoNV = hoNV;
            this.TenNV = tenNV;
            this.MaLoaiNV = maLoaiNV;
            this.MaNhaHang1 = maNhaHang;
        }

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string HoNV
        {
            get { return hoNV; }
            set { hoNV = value; }
        }
        

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        

        public int MaNhaHang1
        {
            get { return maNhaH; }
            set { maNhaH = value; }
        }
        

        public int MaLoaiNV
        {
            get { return maLoaiNV; }
            set { maLoaiNV = value; }
        }
       
        public string CMND1
        {
            get { return cmndNhanVien; }
            set { cmndNhanVien = value; }
        }
       
    }
    }

