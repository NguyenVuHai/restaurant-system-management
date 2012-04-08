using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    public partial class frmDatBan : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmDatBan()                          
        {
            //int soBan = 50;
            InitializeComponent();
            m_flowLPanelDSKhuVuc.HorizontalScroll.Enabled = false;
            
            uCtr_KhuVuc khuvuc1 = new uCtr_KhuVuc(this,"Khu vuc 1", 20);
            khuvuc1.MaximumSize = new Size(m_flowLPanelDSKhuVuc.Width - 20, 0); //Anh cho kich thuoc no === cai flow de no to het chieu ngang lun, dzi moi giong cai hinh cua em            
            uCtr_KhuVuc khuvuc2 = new uCtr_KhuVuc(this,"Khu vuc 2", 50);
            khuvuc2.MaximumSize = new Size(m_flowLPanelDSKhuVuc.Width-20, 0);
            uCtr_KhuVuc khuvuc3 = new uCtr_KhuVuc(this, "Khu vuc 3", 15);
            khuvuc3.MaximumSize = new Size(m_flowLPanelDSKhuVuc.Width - 20, 0);                        

            m_flowLPanelDSKhuVuc.Controls.Add(khuvuc1);                        
            m_flowLPanelDSKhuVuc.Controls.Add(khuvuc2);            
            m_flowLPanelDSKhuVuc.Controls.Add(khuvuc3);

        }

        public void tabThongTinDatBan(string maBan, string khuVuc)
        {
            m_sTabCtrDatBan.SelectedTab = m_sTabItmTTBanDat;
            m_txtMaBan.Text = maBan;
            m_txtKhuVuc.Text = khuVuc;

        }
       

       

      

        

        
    }
}