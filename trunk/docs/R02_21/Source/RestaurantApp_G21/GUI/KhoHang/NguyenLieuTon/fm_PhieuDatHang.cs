using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    public partial class fm_PhieuDatHang : Form
    {
        public fm_PhieuDatHang()
        {
            InitializeComponent();
            uc_phieuDatHang uc = new uc_phieuDatHang();
            this.Controls.Add(uc);
        }
    }
}
