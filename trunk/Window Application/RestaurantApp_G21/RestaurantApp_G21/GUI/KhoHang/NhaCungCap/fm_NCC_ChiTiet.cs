using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21.GUI.KhoHang.NhaCungCap
{
    public partial class fm_NCC_ChiTiet : Form
    {
        private bool loaiThaoTac;//true: cap nhat, false: xem

        public bool LoaiThaoTac
        {
            get { return loaiThaoTac; }
            set { loaiThaoTac = value; }
        }
        public fm_NCC_ChiTiet()
        {
            InitializeComponent();
            uc_NCC_ChiTiet uc = new uc_NCC_ChiTiet(LoaiThaoTac);
            pn.Controls.Add(uc);
        }
        
    }
}
