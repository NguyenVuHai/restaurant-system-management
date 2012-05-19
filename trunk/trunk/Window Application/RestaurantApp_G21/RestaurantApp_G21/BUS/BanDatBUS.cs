using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;
using System.Data;

namespace RestaurantApp_G21.BUS
{
    class BanDatBUS
    {
        public static void ThemThongTinBanDat(BanDatDTO banDat, int loai)
        {
            BanDatDAO.ThemThongTinBanDat(banDat, loai);
        }

        public static List<BanDatDTO> LayDanhSachBanDat()
        {
            return BanDatDAO.LayDanhSachBanDat();
        }

        public static List<BanDatDTO> TimBan(int maNhaHang, int maBan, string tenBan, DateTime ngay)
        {
            return BanDatDAO.TimBan(maNhaHang, maBan, tenBan, ngay);
        }
        public static DataTable ThongTinKhachVaBanDat()
        {
            return BanDatDAO.ThongTinKhachVaBanDat();
        }
        public static bool CapNhatThongTinBanDat(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            if(BanDatDAO.CapNhatThongTinBanDat(maLichBan,maBuoi,ngay,soLuong))
                return true;
            return false;
        }
        public static bool CapNhatThongTinBanDatLostU(int maLichBan, int maBuoi, DateTime ngay, int soLuong,bool t)
        {
            if (BanDatDAO.CapNhatThongTinBanDatLostU(maLichBan, maBuoi, ngay, soLuong,t))
                return true;
            return false;
        }
        
        public static bool CapNhatThongTinBanDatLostUpdate(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            if (BanDatDAO.CapNhatThongTinBanDatLostUpdate(maLichBan, maBuoi, ngay, soLuong))
                return true;
            return false;
        }
        public static bool CapNhatThongTinBanDatSolvedLostUpdate(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            if (BanDatDAO.CapNhatThongTinBanDatSolvedLostUpdate(maLichBan, maBuoi, ngay, soLuong))
                return true;
            return false;
        }
        public static bool CapNhatThongTinBanDatKoXuLyLostUpdate(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            if (BanDatDAO.CapNhatThongTinKhachBanDatXuLyLostUpdate(maLichBan, maBuoi, ngay, soLuong))
                return true;
            return false;
        }
        public static bool CapNhatThongTinBanDatT1ChuaXuLyLostUpdate(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            if (BanDatDAO.CapNhatThongTinKhachBanDatT1ChuaXLLostUpdate(maLichBan, maBuoi, ngay, soLuong))
                return true;
            return false;
        }
        
        public static bool CapNhatThongTinKhachBanDatUnRRead( int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            if (BanDatDAO.CapNhatThongTinKhachBanDatUnRRead(maLichBan,maBuoi,ngay,soLuong))
                return true;
            return false;
        }
        public static bool CapNhatThongTinKhachBanDatDefault(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            if (BanDatDAO.CapNhatThongTinKhachBanDatDefault(maLichBan, maBuoi, ngay, soLuong))
                return true;
            return false;
        }
        public static bool CapNhatThongTinKhachBanDatPhanTom(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            if (BanDatDAO.CapNhatThongTinKhachBanDatPhanTom(maLichBan, maBuoi, ngay, soLuong))
                return true;
            return false;
        }
        
        public static void ThemThongTinKhachVaBanDatPhanTom(BanDatDTO ban, int loai)
        {
            BanDatDAO.ThemThongTinKhachVaBanDatPhamTom(ban, loai);
        }
        public static bool HuyThongTinKhachVaBanDatUnRRead(int maLich)
        {
            if (BanDatDAO.HuyThongTinKhachVaBanDatUnRRead(maLich))
                return true;
            return false;
        }
    }
}
