using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class PhanLoaiMonAnDTO
    {
        private NhaHangDTO nhaHang;

        internal NhaHangDTO NhaHang
        {
            get { return nhaHang; }
            set { nhaHang = value; }
        }
        private LoaiMonAnDTO loaiMonAn;

        internal LoaiMonAnDTO LoaiMonAn
        {
            get { return loaiMonAn; }
            set { loaiMonAn = value; }
        }

        private MonAnDTO monAn;

        internal MonAnDTO MonAn
        {
            get { return monAn; }
            set { monAn = value; }
        }

        public PhanLoaiMonAnDTO()
        {
            monAn = new MonAnDTO();
            loaiMonAn = new LoaiMonAnDTO();
            nhaHang = new NhaHangDTO();
        }

        public override string ToString()
        {
            return monAn.TenMonAn;
        }
    }
}
