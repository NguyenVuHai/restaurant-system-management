using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace RestaurantApp_G21.DTO
{
    class KhoHangDTO
    {
        private int maKhoHang;

        public int MaKhoHang
        {
            get { return maKhoHang; }
            set { maKhoHang = value; }
        }
        private string tenKhoHang;

        public string TenKhoHang
        {
            get { return tenKhoHang; }
            set { tenKhoHang = value; }
        }
        private NhaHangDTO nhaHang;

        internal NhaHangDTO NhaHang
        {
            get { return nhaHang; }
            set { nhaHang = value; }
        }
        private ArrayList dsKhoHang_NguyenLieu;//thong tin ve so luong luu tru nguyen lieu cua 1 kho hang

        public ArrayList DsKhoHang_NguyenLieu
        {
            get { return dsKhoHang_NguyenLieu; }
            set { dsKhoHang_NguyenLieu = value; }
        }

        
        public KhoHangDTO()
        {
            maKhoHang = 0;
            tenKhoHang = "";
            nhaHang = new NhaHangDTO();
            dsKhoHang_NguyenLieu = new ArrayList();
        }

        public override string ToString()
        {
            return tenKhoHang;
        }
    }
}
