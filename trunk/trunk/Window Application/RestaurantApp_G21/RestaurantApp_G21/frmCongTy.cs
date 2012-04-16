using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    public partial class frmCongTy : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            this.m_mtTileCongTy.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
        }

    }
}