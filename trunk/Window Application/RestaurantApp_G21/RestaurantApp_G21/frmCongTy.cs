using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.BUS;

namespace RestaurantApp_G21
{
    public partial class frmCongTy : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmCongTy()
        {
            InitializeComponent();
            LoadNhaHang();
            LoadLoaiNhanVien();
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            this.m_mtTileCongTy.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
        }

        private void LoadNhaHang()
        {
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
        }

        private void LoadLoaiNhanVien()
        {
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
        }

        private void m_btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            int maNhanVien = 0;
            int maNhaHang = 0;
            int maLoaiNhanVien = 0;
            string ho = string.Empty;
            string ten = string.Empty;
            string cmnd = string.Empty;
            string diaChi = string.Empty;
            string dienThoai = string.Empty;
            int loaiNhanVien = 0;
            DateTime ngayVaoLam = new DateTime();

            maNhanVien = Int32.Parse(m_txtMaNV.Text == "" ? "0" : m_txtMaNV.Text);
            ho = m_txtHoNV.Text;
            ten = m_txtTenNV.Text;
            cmnd = m_txtCMND.Text;
            dienThoai = m_txtDienThoai.Text;
            maNhaHang = m_cbxNhaHang.SelectedIndex == 0 ? 0 : ((NhaHangDTO)m_cbxNhaHang.SelectedItem).MaNhaHang;
            loaiNhanVien = m_cbxLoaiNV.SelectedIndex == 0 ? 0 : ((LoaiNhanVienDTO)m_cbxLoaiNV.SelectedItem).MaLoaiNhanVien;
            ngayVaoLam = m_dateTimeInputNgayVaoLam.Value;

            List<ThongTinNhanVienDTO> dt = ThongTinNhanVienBUS.TimKiemNhanVien(maNhanVien, maNhaHang, maLoaiNhanVien, ho, ten, cmnd, diaChi, dienThoai, ngayVaoLam);
 
            if (dt.Count > 0)
                m_dgvDanhSachNhanVien.DataSource = dt;
            else 
                m_dgvDanhSachNhanVien.DataSource = null;
        }

        private void m_btnThemNV_Click(object sender, EventArgs e)
        {
            Form frm = new frmThongTinNhanVien();
            frm.ShowDialog();
        }

        private void m_btnSuaNV_Click(object sender, EventArgs e)
        {
            if (m_dgvDanhSachNhanVien.CurrentCell.RowIndex == null)
            {
                MessageBox.Show("Chọn một nhân viên cần thay đổi thông tin.");
            }
            else
            {
                int numRow = m_dgvDanhSachNhanVien.CurrentCell.RowIndex;
                string maNV = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[0].Value);
                int nh = Convert.ToInt32(m_dgvDanhSachNhanVien.Rows[numRow].Cells[1].Value);
                int loaiNV = Convert.ToInt32(m_dgvDanhSachNhanVien.Rows[numRow].Cells[2].Value);
                string hoNV = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[3].Value);
                string tenNV = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[4].Value);
                string cmnd = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[5].Value);
                string diaChi = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[6].Value);
                string dienThoai = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[7].Value);
                //DateTime.DateTime ngayVaoLam = Convert.ToDateTime(m_dgvDanhSachNhanVien.Rows[numRow].Cells[8].Value);
                //MessageBox.Show(nh.ToString());

                Form frm = new frmThongTinNhanVien(maNV, nh, loaiNV, hoNV, tenNV, cmnd, diaChi, dienThoai);
                frm.ShowDialog();
            }
        }

    }
}