using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class TinhTrangDTO
    {
        string tenTinhTrang;

        public string TenTinhTrang
        {
            get { return tenTinhTrang; }
            set { tenTinhTrang = value; }
        }
        bool maTinhTrang;

        public bool MaTinhTrang
        {
            get { return maTinhTrang; }
            set { maTinhTrang = value; }
        }
    }
}
