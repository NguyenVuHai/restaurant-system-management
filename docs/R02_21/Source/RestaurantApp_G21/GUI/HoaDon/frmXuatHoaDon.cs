using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace RestaurantApp_G21
{
    public partial class frmXuatHoaDon : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmXuatHoaDon()
        {
            InitializeComponent();
            UserControl uc = new ucXuatHoaDon();
            panelXuatHoaDon.Controls.Add(uc);
            this.Width = uc.Width  + 15;
            this.Height = uc.Height +38;
        }
    }
}