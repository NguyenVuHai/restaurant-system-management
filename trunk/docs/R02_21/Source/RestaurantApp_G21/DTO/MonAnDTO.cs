using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace RestaurantApp_G21.DTO
{
    class MonAnDTO
    {
        private int maMonAn;

        public int MaMonAn
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }
        private string tenMonAn;

        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }
        private decimal donGia;

        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }


        private ArrayList dsNguyenLieu;

        public ArrayList DsNguyenLieu
        {
            get { return dsNguyenLieu; }
            set { dsNguyenLieu = value; }
        }
        public MonAnDTO()
        {
            maMonAn = 0;
            tenMonAn = "";
            donGia = 0;
            dsNguyenLieu = new ArrayList();
        }

        public override string ToString()
        {
            return tenMonAn;
        }


    }
}
