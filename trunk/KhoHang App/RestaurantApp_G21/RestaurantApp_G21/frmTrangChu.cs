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
            panelEx1.Location = new Point((Screen.PrimaryScreen.Bounds.Width - panelEx1.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - panelEx1.Height) / 2);
        }

        private void m_mtTileItemKho_Click(object sender, EventArgs e)
        {
            frmKhoHang frm = new frmKhoHang();
            frm.Show();
        }


    }
}