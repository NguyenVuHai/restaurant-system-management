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
            LoadNhaHang(m_cbxNhaHang);
            LoadNhaHang(m_cbx_nv_nhaHang);
            LoadLoaiNhanVien(m_cbxLoaiNV);
            LoadLoaiNhanVien(m_cbx_nv_loaiNhanVien);
            LoadDanhSachNhanVien(); 
            m_btn_nv_hoanTatSuaNV.Visible = false;

            LoadLichLamViec();
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            this.m_mtTileCongTy.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
        }

        private void LoadNhaHang(ComboBox cbx)
        {
            cbx.Items.Clear();
            cbx.Items.Add("Chọn nhà hàng");
            List<NhaHangDTO> nhaHang = NhaHangBUS.LayDanhSachNhaHang();
            foreach (NhaHangDTO oNhaHang in nhaHang)
            {
                cbx.Items.Add(oNhaHang);
            }
            cbx.SelectedIndex = 0;
            cbx.ValueMember = "MaNhaHang";
            cbx.DisplayMember = "TenNhaHang";
        }

        private void LoadLoaiNhanVien(ComboBox cbx)
        {
            cbx.Items.Clear();
            cbx.Items.Add("Chọn loại nhân viên");
            List<LoaiNhanVienDTO> loaiNhanVien = LoaiNhanVienBUS.LayDanhSachLoaiNhanVien();
            foreach (LoaiNhanVienDTO oLoaiNhanVien in loaiNhanVien)
            {
                cbx.Items.Add(oLoaiNhanVien);
            }
            cbx.SelectedIndex = 0;
            cbx.ValueMember = "MaLoaiNhanVien";
            cbx.DisplayMember = "TenLoaiNhanVien";
        }

        private void LoadDanhSachNhanVien()
        {
            List<ThongTinNhanVienDTO> dt = ThongTinNhanVienBUS.LoadDanhSachNhanVien();

            if (dt.Count > 0)
                m_dgvDanhSachNhanVien.DataSource = dt;
            else
                m_dgvDanhSachNhanVien.DataSource = null;
        }

        private void ResetDuLieuPanelThongTinNhanVien()
        {
            m_txt_nv_maNV.Text = null;
            m_txt_nv_hoNhanVien.Text = null;
            m_txt_nv_tenNhanVien.Text = null;
            m_txt_nv_cmnd.Text = null;
            m_txt_nv_dienThoai.Text = null;
            m_txt_nv_diaChi.Text = null;
            m_cbx_nv_loaiNhanVien.SelectedIndex = 0;
            m_cbx_nv_nhaHang.SelectedIndex = 0;
            m_txt_nv_tinhTrang.Text = null;
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

        private void LoadLichLamViec()
        {
            List<LichLamViecDTO> dt = LichLamViecBUS.LoadLichLamViec();
            if (dt.Count > 0)
                m_dgvLichLamViec.DataSource = dt;
            else
                m_dgvLichLamViec.DataSource = null;
        }

        private void m_btnThemNV_Click(object sender, EventArgs e)
        {
            ResetDuLieuPanelThongTinNhanVien();
            m_btn_nv_hoanTatSuaNV.Visible = false;
            m_titleThongTinNhanVien.Text = "Thêm Thông Tin Nhân Viên";
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

        private void m_dgvDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            
            //Load dữ liệu lên form
            int numRow = m_dgvDanhSachNhanVien.CurrentCell.RowIndex;
            m_txt_nv_maNV.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[0].Value);
            m_cbx_nv_nhaHang.SelectedIndex = Convert.ToInt32(m_dgvDanhSachNhanVien.Rows[numRow].Cells[1].Value);
            m_cbx_nv_loaiNhanVien.SelectedIndex = Convert.ToInt32(m_dgvDanhSachNhanVien.Rows[numRow].Cells[2].Value);
            m_txt_nv_hoNhanVien.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[3].Value);
            m_txt_nv_tenNhanVien.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[4].Value);
            m_txt_nv_cmnd.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[5].Value);
            m_txt_nv_diaChi.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[6].Value);
            m_txt_nv_dienThoai.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells[7].Value);

            //Load label form
            m_titleThongTinNhanVien.Text = "Sửa Thông Tin Nhân Viên";
            m_btn_nv_hoanTatThemNV.Visible = false;
            m_btn_nv_hoanTatSuaNV.Visible = true;
        }

        private void m_btnHuy_Click(object sender, EventArgs e)
        {
            ResetDuLieuPanelThongTinNhanVien();
            m_titleThongTinNhanVien.Text = "Thông Tin Nhân Viên";
            m_btn_nv_hoanTatSuaNV.Visible = false;
            m_btn_nv_hoanTatThemNV.Visible = true;
        }

        private void m_btn_nv_hoanTatThemNV_Click(object sender, EventArgs e)
        {
            ThongTinNhanVienDTO nv = new ThongTinNhanVienDTO()
            {
                //MaNhanVien = Convert.ToInt32(m_txtMaNV.Text),
                Ho = m_txt_nv_hoNhanVien.Text,
                Ten = m_txt_nv_tenNhanVien.Text,
                MaLoaiNhanVien = ((LoaiNhanVienDTO)m_cbx_nv_loaiNhanVien.SelectedItem).MaLoaiNhanVien,
                MaNhaHang = ((NhaHangDTO)m_cbx_nv_nhaHang.SelectedItem).MaNhaHang,
                CMND = m_txt_nv_cmnd.Text,
                DiaChi = m_txt_nv_diaChi.Text,
                DienThoai = m_txt_nv_dienThoai.Text,
                NgayVaoLam = m_dtp_nv_ngayVaolam.Value,
                TinhTrang = m_txt_nv_tinhTrang.Text
            };

            ThongTinNhanVienBUS.ThemNhanVien(nv);
            LoadDanhSachNhanVien();
        }

        private void m_btn_nv_hoanTatSuaNV_Click(object sender, EventArgs e)
        {
            GlobalVariables.bLostUpdate = rbLostUpdate.Checked;
            int maNH = m_cbx_nv_nhaHang.SelectedIndex;
            int maLoai = m_cbx_nv_loaiNhanVien.SelectedIndex;
            ThongTinNhanVienBUS.SuaThongTinNhanVien(Int32.Parse(m_txt_nv_maNV.Text), maNH, maLoai, rbcLostUpdate.Checked);
            LoadDanhSachNhanVien();
        }

        private void m_btnXoaNV_Click(object sender, EventArgs e)
        {
            ThongTinNhanVienBUS.XoaNhanVien(GlobalVariables.maNhanVien);
            LoadDanhSachNhanVien();
        }

        private void m_dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}