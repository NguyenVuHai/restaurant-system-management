﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;
namespace RestaurantApp_G21.BUS
{
    class ThongTinHangNhapBUS
    {
        public static int themThongTinHangNhap(ThongTinHangNhapDTO ttNhap)
        {
            return ThongTinHangNhapDAO.themThongTinHangNhap(ttNhap);
        }
    }
}
