using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class LoaiMonAnDTO
    {
        private int maLoaiMonAn;

        public int MaLoaiMonAn
        {
            get { return maLoaiMonAn; }
            set { maLoaiMonAn = value; }
        }
        private string tenLoaiMonAn;

        public string TenLoaiMonAn
        {
            get { return tenLoaiMonAn; }
            set { tenLoaiMonAn = value; }
        }
        public LoaiMonAnDTO()
        {
            maLoaiMonAn = 0;
            tenLoaiMonAn = "";
        }
        public override string ToString()
        {
            return tenLoaiMonAn;
        }
    }
}
