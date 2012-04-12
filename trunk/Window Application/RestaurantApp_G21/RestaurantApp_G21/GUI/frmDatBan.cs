using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.BUS;

namespace RestaurantApp_G21
{
    public partial class frmDatBan : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        private int m_maNhaHang = 1;

        public frmDatBan()                          
        {
            //int soBan = 50;                        
            InitializeComponent();
            List<KhuVucDTO> dsKhuVuc = KhuVucBUS.LayDanhSachKhuVuc(m_maNhaHang);
           
            foreach(KhuVucDTO kv in dsKhuVuc)            
            {
                TabItem tabI = new TabItem();
                TabControlPanel tabCtrP = new TabControlPanel();
                tabI.Name = "m_tabIKhuVuc" + kv.MaKhuVuc;
                tabI.Text = kv.TenKhuVuc;
                tabCtrP.Name = "m_tabCtrP" + kv.MaKhuVuc;
                tabCtrP.AutoScroll = true;
                tabCtrP.AutoSize = true;
                tabCtrP.Dock = System.Windows.Forms.DockStyle.Fill;                                
                tabCtrP.TabItem = tabI;// chỗ này là gán
                tabI.AttachedControl = tabCtrP;//                
                int soBan = 50;
                uCtr_KhuVuc khuvuc = new uCtr_KhuVuc(this, kv.MaKhuVuc, soBan);
                khuvuc.MaximumSize = new Size(m_tabCtrKhuVuc.Width, 0);                        

                tabCtrP.Controls.Add(khuvuc);
                m_tabCtrKhuVuc.Controls.Add(tabCtrP); // chỗ này là add
                m_tabCtrKhuVuc.Tabs.Add(tabI);
            
            }

        }

        public void tabThongTinDatBan(string maBan, int maKhuVuc)
        {
            m_sTabCtrDatBan.SelectedTab = m_sTabItmTTBanDat;
            m_txtMaBan.Text = maBan;
            m_txtKhuVuc.Text = maKhuVuc.ToString();

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

       
       

       

      

        

        
    }
}