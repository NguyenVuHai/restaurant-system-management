using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantApp_G21.DTO
{
    public class ThongTinBanDTO
    {
        private int maBan;
        private string tenBan;
        private int maKhuVuc;
        private int sucChua;
        private int maNhaHang;
        private decimal giaBan;

        public decimal GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public int MaNhaHang
        {
            get { return maNhaHang; }
            set { maNhaHang = value; }
        }

        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
        
        public string TenBan
        {
            get { return tenBan; }
            set { tenBan = value; }
        }
        
        public int MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }
        
        public int SucChua
        {
            get { return sucChua; }
            set { sucChua = value; }
        }

    }
}
