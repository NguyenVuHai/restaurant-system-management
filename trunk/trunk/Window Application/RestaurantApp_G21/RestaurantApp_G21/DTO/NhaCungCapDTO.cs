using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace RestaurantApp_G21.DTO
{
    class NhaCungCapDTO
    {
        private int maNhaCungCap;

        public int MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }
        private string tenNhaCungCap;

        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }
        private string dienThoai;

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        private string soTaiKhoan;

        public string SoTaiKhoan
        {
            get { return soTaiKhoan; }
            set { soTaiKhoan = value; }
        }
        private string thoiDiemThanhToan;

        public string ThoiDiemThanhToan
        {
            get { return thoiDiemThanhToan; }
            set { thoiDiemThanhToan = value; }
        }
        private int maThoiDiemThanhToan;

        public int MaThoiDiemThanhToan
        {
            get { return maThoiDiemThanhToan; }
            set { maThoiDiemThanhToan = value; }
        }
        private int maThoiDiemGuiDS;

        public int MaThoiDiemGuiDS
        {
            get { return maThoiDiemGuiDS; }
            set { maThoiDiemGuiDS = value; }
        }
        private int soLuongNguyenLieuToiDaPhuHopYeuCauDatHang;

        public int SoLuongNguyenLieuToiDaPhuHopYeuCauDatHang
        {
            get { return soLuongNguyenLieuToiDaPhuHopYeuCauDatHang; }
            set { soLuongNguyenLieuToiDaPhuHopYeuCauDatHang = value; }
        }
        private ArrayList dsNguyenLieu;

        public ArrayList DsNguyenLieu
        {
            get { return dsNguyenLieu; }
            set { dsNguyenLieu = value; }
        }

        private decimal tongNo;

        public decimal TongNo
        {
            get { return tongNo; }
            set { tongNo = value; }
        }
        private decimal giaTriDinhMucNo;

        public decimal GiaTriDinhMucNo
        {
            get { return giaTriDinhMucNo; }
            set { giaTriDinhMucNo = value; }
        }
        public NhaCungCapDTO()
        {
            maNhaCungCap = 0;
            tenNhaCungCap = "";
            dienThoai = "";
            soTaiKhoan = "";
            maThoiDiemGuiDS = 0;
            maThoiDiemThanhToan = 0;
            soLuongNguyenLieuToiDaPhuHopYeuCauDatHang = 0;
            dsNguyenLieu = new ArrayList();
            tongNo = 0;
            giaTriDinhMucNo = 0;
            thoiDiemThanhToan = "";
        }
        public override string ToString()
        {
            return tenNhaCungCap;
        }
    }
}
