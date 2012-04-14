﻿using System;
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
        public List<ThongTinBanDTO> listBan = new List<ThongTinBanDTO>();
        private int m_maNhaHang = 1;

        #region Utils Methods

        private void LoadNhaHang()
        {
            m_cBoxNhaHang.Items.Clear();
            m_cBoxNhaHang.Items.Add("Chọn nhà hàng");
            List<NhaHangDTO> nhaHang = NhaHangBUS.LayDanhSachNhaHang();
            foreach (NhaHangDTO oNhaHang in nhaHang)
            {
                m_cBoxNhaHang.Items.Add(oNhaHang);
            }
            m_cBoxNhaHang.SelectedIndex = 0;
            m_cBoxNhaHang.ValueMember = "MaNhaHang";
            m_cBoxNhaHang.DisplayMember = "TenNhaHang";
        }

        private void LoadKhuVuc(int maNhaHang)
        {
            m_cBoxKhuVuc.Items.Clear();
            m_cBoxKhuVuc.Items.Add("Chọn khu vực");
            List<KhuVucDTO> khuVuc = KhuVucBUS.LayDanhSachKhuVuc(maNhaHang);
            foreach (KhuVucDTO oKhuVuc in khuVuc)
            {
                m_cBoxKhuVuc.Items.Add(oKhuVuc);
            }
            m_cBoxKhuVuc.SelectedIndex = 0;
            m_cBoxKhuVuc.ValueMember = "MaKhuVuc";
            m_cBoxKhuVuc.DisplayMember = "TenKhuVuc";
        }

        #endregion

        public frmDatBan()                          
        {
            //int soBan = 50;                        
            InitializeComponent();
            LoadNhaHang();
            //LoadBanTrongKhuVuc();
        }

        public void LoadBanTrongKhuVuc()
        {
            m_tabCtrKhuVuc.Tabs.Clear();
            List<KhuVucDTO> dsKhuVuc = KhuVucBUS.LayDanhSachKhuVuc(((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang);

            foreach (KhuVucDTO kv in dsKhuVuc)
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

        private void m_btnTimNhaHang_Click(object sender, EventArgs e)
        {
            Form frm = new frmTimBan();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Show();
            LoadBanTrongKhuVuc();
        }


        private void m_btnTimBan_Click(object sender, EventArgs e)
        {
            int maNhaHang = 0;
            int maKhuVuc = 0;
            DateTime ngayDatBan = new DateTime();
            string buoi = String.Empty;
            int soLuong = 0;

            maNhaHang = m_cBoxNhaHang.SelectedIndex == 0 ? 0 : ((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang;
            maKhuVuc = m_cBoxKhuVuc.SelectedIndex == 0 ? 0 : ((KhuVucDTO)m_cBoxKhuVuc.SelectedItem).MaKhuVuc;
            ngayDatBan = m_dateTimeInputNgayDatBan.Value;
            buoi = m_textBoxBuoi.Text;
            //maNhaHang = m_cBoxNhaHang
            listBan = ThongTinBanBUS.TimBanTrong(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
            LoadBanTrongKhuVuc();
            //NhaHangBUS.LayNhaHang();
            //if (dt.Count > 0)
            //    dgvDanhSachBan.DataSource = dt;
            //else dgvDanhSachBan.DataSource = null;
            
        }

        private void m_cBoxNhaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maNhaHang = 0;
            if (m_cBoxNhaHang.SelectedIndex != 0)
            {

                maNhaHang = ((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang;
            }
            LoadKhuVuc(maNhaHang);
        }
       

       

      

        

        
    }
}