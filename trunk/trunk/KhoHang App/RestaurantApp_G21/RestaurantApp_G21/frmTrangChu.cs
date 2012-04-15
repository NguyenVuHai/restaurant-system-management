using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    public partial class frmTrangChu : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
           
        }

        private void m_mtTileItemKho_Click(object sender, EventArgs e)
        {
            frmKhoHang frm = new frmKhoHang();
            frm.Show();
        }


    }
}