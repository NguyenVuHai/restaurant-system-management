using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class NhaHangDTO
    {
        private int maNhaHang;
        private string tenNhaHang;
        private string dienThoai;
        private string diaChi;
        
        public NhaHangDTO(int maNhaHang, string tenNhaHang, string dienThoai, string diaChi)
        {
            this.maNhaHang = maNhaHang;
            this.tenNhaHang = tenNhaHang;
            this.dienThoai = dienThoai;
            this.diaChi = diaChi;
        }

        public int MaNhaHang
        {
            get { return maNhaHang; }
            set { maNhaHang = value; }
        }
        
        public string TenNhaHang
        {
            get { return tenNhaHang; }
            set { tenNhaHang = value; }
        }
        
        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
    }
}
