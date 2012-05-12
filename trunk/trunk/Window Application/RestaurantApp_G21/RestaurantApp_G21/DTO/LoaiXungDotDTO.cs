using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class LoaiXungDotDTO
    {
        int maXungDot;

        public int MaXungDot
        {
            get { return maXungDot; }
            set { maXungDot = value; }
        }
        string tenXungDot;

        public string TenXungDot
        {
            get { return tenXungDot; }
            set { tenXungDot = value; }
        }
    }
}
