using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class LoaiNhanVienCNDTO
    {
          private int maLoaiNhanVien;
         private string tenLoaiNhanVien;
         private double luong;   

        public LoaiNhanVienCNDTO(int loai,string ten , double luong)
        {
            this.maLoaiNhanVien = loai;
            this.tenLoaiNhanVien = ten;
            this.luong = luong;
        }
       
        public int MaLoaiNhanVien
        {
            get { return maLoaiNhanVien; }
            set { maLoaiNhanVien = value; }
        }
       

        public string TenLoaiNhanVien
        {
            get { return tenLoaiNhanVien; }
            set { tenLoaiNhanVien = value; }
        }
       

        public double Luong
        {
            get { return luong; }
            set { luong = value; }
        }

    }
}
