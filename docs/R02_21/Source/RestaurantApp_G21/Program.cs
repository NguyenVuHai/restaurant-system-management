﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap ());
            //Application.Run(new frmDirtyReadNhanVien());
            //Application.Run(new frmCongTy());
            //Application.Run(new FrmQuanLyNhanVien());
            //Application.Run(new frmKhoHang());
        }
    }
}
