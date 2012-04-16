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

        private void metroTileItemBatBan_Click(object sender, EventArgs e)
        {
            frmDatBan frm = new frmDatBan();
            frm.ShowDialog();
        }

       
        private void m_mtTileItemNhaHang_Click(object sender, EventArgs e)
        {
            frmNhaHang frm = new frmNhaHang();
            frm.Show();
        }

        private void m_mtTileItemKho_Click(object sender, EventArgs e)
        {
            frmKhoHang frm = new frmKhoHang();
            frm.Show();
        }

        private void m_mtTileItemHeThong_Click(object sender, EventArgs e)
        {
            frmHeThong frm = new frmHeThong();
            frm.Show();
        }
    }
}