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
    public partial class frmThongTinNhanVien : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmThongTinNhanVien()
        {
            InitializeComponent();

            m_cbxNhaHang.Items.Clear();
            m_cbxNhaHang.Items.Add("Chọn nhà hàng");
            List<NhaHangDTO> nhaHang = NhaHangBUS.LayDanhSachNhaHang();
            foreach (NhaHangDTO oNhaHang in nhaHang)
            {
                m_cbxNhaHang.Items.Add(oNhaHang);
            }
            m_cbxNhaHang.SelectedIndex = 0;
            m_cbxNhaHang.ValueMember = "MaNhaHang";
            m_cbxNhaHang.DisplayMember = "TenNhaHang";

            m_cbxLoaiNV.Items.Clear();
            m_cbxLoaiNV.Items.Add("Chọn loại nhân viên");
            List<LoaiNhanVienDTO> loaiNhanVien = LoaiNhanVienBUS.LayDanhSachLoaiNhanVien();
            foreach (LoaiNhanVienDTO oLoaiNhanVien in loaiNhanVien)
            {
                m_cbxLoaiNV.Items.Add(oLoaiNhanVien);
            }
            m_cbxLoaiNV.SelectedIndex = 0;
            m_cbxLoaiNV.ValueMember = "MaLoaiNhanVien";
            m_cbxLoaiNV.DisplayMember = "TenLoaiNhanVien";

            m_btnSuaNV.Visible = false;
        }

        public frmThongTinNhanVien(string maNV, int nh, int loaiNV, string hoNV, string tenNV, string cmnd, string diaChi, string dienThoai)
        {
            InitializeComponent();

            List<NhaHangDTO> nhaHang = NhaHangBUS.LayDanhSachNhaHang();
            foreach (NhaHangDTO oNhaHang in nhaHang)
            {
                m_cbxNhaHang.Items.Add(oNhaHang);
            }
            m_cbxNhaHang.SelectedIndex = nh - 1;
            m_cbxNhaHang.ValueMember = "MaNhaHang";
            m_cbxNhaHang.DisplayMember = "TenNhaHang";

            List<LoaiNhanVienDTO> loaiNhanVien = LoaiNhanVienBUS.LayDanhSachLoaiNhanVien();
            foreach (LoaiNhanVienDTO oLoaiNhanVien in loaiNhanVien)
            {
                m_cbxLoaiNV.Items.Add(oLoaiNhanVien);
            }
            m_cbxLoaiNV.SelectedIndex = loaiNV - 1;
            m_cbxLoaiNV.ValueMember = "MaLoaiNhanVien";
            m_cbxLoaiNV.DisplayMember = "TenLoaiNhanVien";

            this.m_txtMaNV.Text = maNV;
            this.m_txtHoNV.Text = hoNV;
            this.m_txtTenNV.Text = tenNV;
            this.m_txtCMND.Text = cmnd;
            this.m_txtDienThoai.Text = dienThoai;
            this.m_txtDiaChi.Text = diaChi;
            //this.m_dateTimeInputNgayVaoLam = ngayVaoLam;
            this.m_txtMaNV.Enabled = false;

            this.m_btnThemNV.Visible = false;
        }


        private void m_btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btnSuaNV_Click(object sender, EventArgs e)
        {

        }

        private void m_btnThemNV_Click(object sender, EventArgs e)
        {
            ThongTinNhanVienDTO nv = new ThongTinNhanVienDTO()
            {
                MaNhanVien = Convert.ToInt32(m_txtMaNV.Text),
                Ho = m_txtHoNV.Text,
                Ten = m_txtTenNV.Text,
                MaLoaiNhanVien = Convert.ToInt32(m_cbxLoaiNV.SelectedItem),
                MaNhaHang = Convert.ToInt32(m_cbxNhaHang.SelectedItem),
                CMND = m_txtCMND.Text,
                DiaChi = m_txtDiaChi.Text,
                DienThoai = m_txtDienThoai.Text,
                NgayVaoLam = m_dateTimeInputNgayVaoLam.Value
            };
            
            ThongTinNhanVienBUS.ThemNhanVien(nv);
           
        }

    }
}