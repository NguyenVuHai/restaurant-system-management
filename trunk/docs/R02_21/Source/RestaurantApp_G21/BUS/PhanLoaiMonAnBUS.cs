using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RestaurantApp_G21.DAO;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.BUS
{
    class PhanLoaiMonAnBUS
    {
        public static ArrayList layDanhSachMonAnTheoPhanLoaiMonAn(LoaiMonAnDTO loaiMonAn,int maNhaHang)
        {
            return PhanLoaiMonAnDAO.layDanhSachMonAnTheoPhanLoaiMonAn(loaiMonAn, maNhaHang);
        }
    }
}
