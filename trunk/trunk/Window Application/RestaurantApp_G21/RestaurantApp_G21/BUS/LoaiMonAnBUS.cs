using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
//using RestaurantApp_G21.DTO;
using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.BUS
{
    class LoaiMonAnBUS
    {
        public static ArrayList layDanhSachLoaiMonAn()
        {
            return LoaiMonAnDAO.layDanhSachLoaiMonAn();
        }
    }
}
