using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    public partial class frmMain : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            mainMetro.SelectedTab = m_tabDatBan;
        }

        private void m_mtTileItemNhaHang_Click(object sender, EventArgs e)
        {
            mainMetro.SelectedTab = m_mtTabItemNhaHang ;
       
        }

        private void m_mtTileItemCongTy_Click(object sender, EventArgs e)
        {
            mainMetro.SelectedTab = m_mtTabItemCongTy;
        }

        private void m_mtTileItemKho_Click(object sender, EventArgs e)
        {
            mainMetro.SelectedTab = m_mtTabItemKhoKhang;
        }

        private void m_mtTileItemHeThong_Click(object sender, EventArgs e)
        {
            mainMetro.SelectedTab = m_mtTabItemQuanTri; 
        }

       
        

       

       

       

        

       
       
       
    }
}