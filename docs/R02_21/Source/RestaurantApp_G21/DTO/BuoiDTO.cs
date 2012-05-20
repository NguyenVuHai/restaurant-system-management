using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    class BuoiDTO
    {
        private int maBuoi;
        private string tenBuoi;

        public int MaBuoi
        {
            get { return maBuoi; }
            set { maBuoi = value; }
        }
        
        public string TenBuoi
        {
            get { return tenBuoi; }
            set { tenBuoi = value; }
        }
    }
}
