using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.BUS
{
    class KhoHang_NguyenLieuBUS
    {
        public static int capNhatChiTietKhoHangNguyenLieuT2(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            if (dto != null && dto.NguyenLieu.MaNguyenLieu != 0 && maNhaHang != 0)
            {
                return KhoHang_NguyenLieuDAO.capNhatChiTietKhoHangNguyenLieuT2(dto, maNhaHang);
            }
            return 0;
        }
        public static int capNhatChiTietKhoHangNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            if (dto != null && dto.NguyenLieu.MaNguyenLieu != 0 && maNhaHang != 0)
            {
                return KhoHang_NguyenLieuDAO.capNhatChiTietKhoHangNguyenLieu(dto, maNhaHang);
            }
            return 0;
        }
        public static int xuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            if (dto != null && dto.NguyenLieu.MaNguyenLieu != 0 && maNhaHang != 0)
            {
                return KhoHang_NguyenLieuDAO.xuatNguyenLieu(dto, maNhaHang);
            }
            return 0;
        }
        //LOST UPDATED
        public static int lostUpdatedXuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            if (dto != null && dto.NguyenLieu.MaNguyenLieu != 0 && maNhaHang != 0)
            {
                return KhoHang_NguyenLieuDAO.lostUpdatedXuatNguyenLieu(dto, maNhaHang);
            }
            return 0;
        }
        //LOST UPDATED SOLVED
        public static int lostUpdatedSolvedXuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang, int mucCoLap)
        {
            if (dto != null && dto.NguyenLieu.MaNguyenLieu != 0 && maNhaHang != 0)
            {
                return KhoHang_NguyenLieuDAO.lostUpdatedSolvedXuatNguyenLieu(dto, maNhaHang, mucCoLap);
            }
            return 0;
        }
        //DEADLOCK
        public static int deadlockXuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            if (dto != null && dto.NguyenLieu.MaNguyenLieu != 0 && maNhaHang != 0)
            {
                return KhoHang_NguyenLieuDAO.deadlockXuatNguyenLieu(dto, maNhaHang);
            }
            return 0;
        }
        //DEADLOCK SOLVED
        public static int deadlockSolvedXuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            if (dto != null && dto.NguyenLieu.MaNguyenLieu != 0 && maNhaHang != 0)
            {
                return KhoHang_NguyenLieuDAO.deadlockSolvedXuatNguyenLieu(dto, maNhaHang);
            }
            return 0;
        }
    }
}
