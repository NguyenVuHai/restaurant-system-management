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

        private bool KiemTraKhuVuc(int maKhuVuc)
        {
            foreach (var ban in listBan)
            {
                if (ban.MaKhuVuc == maKhuVuc) return true;
            }
            return false;
        }

        private void LoadBuoi(ComboBox cboxBuoi, int selectIndex)
        {
            try
            {
                cboxBuoi.Items.Clear();
                cboxBuoi.Items.Add("Chọn buổi");
                List<BuoiDTO> buoi = BuoiBUS.LayDanhSachBuoi();
                foreach (BuoiDTO oBuoi in buoi)
                {
                    cboxBuoi.Items.Add(oBuoi);
                }
                cboxBuoi.SelectedIndex = selectIndex;
                cboxBuoi.ValueMember = "MaBuoi";
                cboxBuoi.DisplayMember = "TenBuoi";
            }
            catch
            {
            }
        }
        #endregion

        public frmDatBan()                          
        {                     
            InitializeComponent();
            LoadNhaHang();
            LoadBuoi(m_cboxTimBuoi,0);
            LoadBuoi(m_cboxBuoi,0);
        }

        public void LoadBanTrongKhuVuc()
        {
            m_tabCtrKhuVuc.Tabs.Clear();
            int maNhaHang = m_cBoxNhaHang.SelectedIndex == 0 ? 0 : ((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang;
            List<KhuVucDTO> dsKhuVuc = KhuVucBUS.LayDanhSachKhuVuc(maNhaHang);

            foreach (KhuVucDTO kv in dsKhuVuc)
            {
                if (KiemTraKhuVuc(kv.MaKhuVuc))
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
                    tabI.AttachedControl = tabCtrP;            

                    uCtr_KhuVuc khuvuc = new uCtr_KhuVuc(this, kv.MaKhuVuc);
                    khuvuc.MaximumSize = new Size(m_tabCtrKhuVuc.Width, 0);

                    tabCtrP.Controls.Add(khuvuc);
                    m_tabCtrKhuVuc.Controls.Add(tabCtrP); // chỗ này là add
                    m_tabCtrKhuVuc.Tabs.Add(tabI);
                }

            }
        }


        public void tabThongTinDatBan(string maBan, int maKhuVuc)
        {
            m_sTabCtrDatBan.SelectedTab = m_sTabItmTTBanDat;
            m_txtMaBan.Text = maBan;
            m_txtKhuVuc.Text = maKhuVuc.ToString();
            LoadBuoi(m_cboxBuoi, m_cboxTimBuoi.SelectedIndex);
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
            int buoi = 0;
            int soLuong = 0;

            maNhaHang = m_cBoxNhaHang.SelectedIndex == 0 ? 0 : ((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang;
            maKhuVuc = m_cBoxKhuVuc.SelectedIndex == 0 ? 0 : ((KhuVucDTO)m_cBoxKhuVuc.SelectedItem).MaKhuVuc;
            ngayDatBan = m_dateTimeInputNgayDatBan.Value;
            buoi = m_cboxBuoi.SelectedIndex == 0 ? 0 : ((BuoiDTO)m_cboxBuoi.SelectedItem).MaBuoi;
            
            listBan = ThongTinBanBUS.TimBanTrong(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
            LoadBanTrongKhuVuc();
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