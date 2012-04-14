using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Common;
using RestaurantApp_G21.BUS;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21
{
    public partial class frmTimBan : DevComponents.DotNetBar.Metro.MetroForm
    {

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

        public frmTimBan()
        {
            InitializeComponent();
            LoadNhaHang();
        }

        private void m_btnThoat_Click(object sender, EventArgs e)
        {

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
            List<ThongTinBanDTO> dt = ThongTinBanBUS.TimBanTrong(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
            //NhaHangBUS.LayNhaHang();
            if (dt.Count > 0)
                dgvDanhSachBan.DataSource = dt;
            else dgvDanhSachBan.DataSource = null;
            foreach (var item in dt)
            {
                ((frmDatBan)this.ParentForm).listBan.Add(item);
            }
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