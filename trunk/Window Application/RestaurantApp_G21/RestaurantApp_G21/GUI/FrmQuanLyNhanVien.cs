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
    public partial class FrmQuanLyNhanVien : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            LoadComboboxNhaHang(m_cbxThongTinNhaHang);
            LoadComboboxLoaiNhanVien(m_cbxThongTinLoaiNhanVien);

            LoadComboboxTimKiemNhaHang(m_cbxTimKiemNhaHang);
            LoadComboboxTimKiemLoaiNhanVien(m_cbxTimKiemLoaiNV);

            LoadDanhSachNhanVien();

            LoadComboboxLoaiTruyXuat();
            int loaiTruyXuat = m_cbxLoaiTruyXuat.SelectedIndex;
            TinhTongNhanVien(-1, loaiTruyXuat);
            
        }

        private void LoadComboboxNhaHang(ComboBox cbx)
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

        private void LoadComboboxTimKiemNhaHang(ComboBox cbx)
        {
            LoadComboboxNhaHang(cbx);
            cbx.Items.Add("Chưa phân công");
        }

        private void LoadComboboxLoaiNhanVien(ComboBox cbx)
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

        private void LoadComboboxTimKiemLoaiNhanVien(ComboBox cbx)
        {
            LoadComboboxLoaiNhanVien(cbx);
            cbx.Items.Add("Chưa phân công");
        }

        private void LoadComboboxLoaiTruyXuat()
        {
            m_cbxLoaiTruyXuat.Items.Add("Không có truy xuất đồng thời");
            m_cbxLoaiTruyXuat.Items.Add("Lost Update");
            m_cbxLoaiTruyXuat.Items.Add("Lost Update Solved");
            m_cbxLoaiTruyXuat.Items.Add("Dirty Read");
            m_cbxLoaiTruyXuat.Items.Add("Dirty Read Solved");
            m_cbxLoaiTruyXuat.Items.Add("Unrepeatable");
            m_cbxLoaiTruyXuat.Items.Add("Unrepeatable Solved");
            m_cbxLoaiTruyXuat.Items.Add("Phantom");
            m_cbxLoaiTruyXuat.Items.Add("Phantom Solved");
            m_cbxLoaiTruyXuat.SelectedIndex = 0;
        }

        private void ResetTruongDuLieuThongTin()
        {
            m_txtThongTinMaNV.Text = "";
            m_txtThongTinHoNhanVien.Text = "";
            m_txtThongTinTenNhanVien.Text = "";
            m_txtThongTinDiaChi.Text = "";
            m_txtThongTinDienThoai.Text = "";
            m_txtThongTinCMND.Text = "";
            m_txtThongTinTinhTrang.Text = "";
            m_cbxThongTinLoaiNhanVien.SelectedIndex = 0;
            m_cbxThongTinNhaHang.SelectedIndex = 0;
            m_dtpThongTinNgayVaolam.ResetValue();
        }

        private void UpdateDatagridviewDSNhanVien()
        {
            List<NhaHangDTO> listNhaHang = NhaHangBUS.LayDanhSachNhaHang();
            List<LoaiNhanVienDTO> listLoaiNhanVien = LoaiNhanVienBUS.LayDanhSachLoaiNhanVien();
            for (int i = 0; i < m_dgvDanhSachNhanVien.Rows.Count; i++)
            {
                int maNhaHang = Int32.Parse(m_dgvDanhSachNhanVien.Rows[i].Cells["MaNhaHang"].Value.ToString());
                int maLoaiNhanVien = Int32.Parse(m_dgvDanhSachNhanVien.Rows[i].Cells["MaLoaiNhanVien"].Value.ToString());
                string tenNhaHang = GetTenNhaHang(listNhaHang, maNhaHang);
                string tenLoaiNhanVien = GetTenLoaiNhanVien(listLoaiNhanVien, maLoaiNhanVien);
                m_dgvDanhSachNhanVien.Rows[i].Cells["TenNhaHang"].Value = tenNhaHang == null ? "Chưa phân công" : tenNhaHang;
                m_dgvDanhSachNhanVien.Rows[i].Cells["TenLoaiNhanVien"].Value = tenLoaiNhanVien == null ? "Chưa phân công" : tenLoaiNhanVien;
            }
            m_dgvDanhSachNhanVien.Columns["MaNhaHang"].Visible = false;
            m_dgvDanhSachNhanVien.Columns["MaLoaiNhanVien"].Visible = false;
        }

        private void LoadDanhSachNhanVien()
        {
            List<ThongTinNhanVienDTO> dt = ThongTinNhanVienBUS.LoadDanhSachNhanVien();

            if (dt.Count > 0)
            {
                m_dgvDanhSachNhanVien.DataSource = dt;
                UpdateDatagridviewDSNhanVien();
            }
            else
                m_dgvDanhSachNhanVien.DataSource = null;


        }

        private string GetTenLoaiNhanVien(List<LoaiNhanVienDTO> listLoaiNhanVien, int maLoaiNhanVien)
        {
            foreach (LoaiNhanVienDTO oLoaiNhanVien in listLoaiNhanVien)
            {
                if (maLoaiNhanVien == oLoaiNhanVien.MaLoaiNhanVien)
                    return oLoaiNhanVien.TenLoaiNhanVien;
            }
            return null;
        }

        private string GetTenNhaHang(List<NhaHangDTO> listNhaHang, int maNhaHang)
        {
            foreach (NhaHangDTO oNhaHang in listNhaHang)
            {
                if (maNhaHang == oNhaHang.MaNhaHang)
                    return oNhaHang.TenNhaHang;
            }
            return null;
        }

        private void TinhTongNhanVien(int maNH, int loaiTruyXuat)
        {
            if (maNH == 0) //null
            {
                int temp = ThongTinNhanVienBUS.SumNhanVien(0, loaiTruyXuat);
                m_lblTimKiemTenNhaHang.Text = "nhân viên chưa được phân công vào nhà hàng nào";
                m_txtThongKeTongNV.Text = temp.ToString();
            }
            else if (maNH == -1)    //tất cả
            {
                int temp = ThongTinNhanVienBUS.SumNhanVien(-1, loaiTruyXuat);
                m_lblTimKiemTenNhaHang.Text = "nhân viên thuộc tổng công ty ";
                m_txtThongKeTongNV.Text = temp.ToString();
            }
            else
            {
                int temp = ThongTinNhanVienBUS.SumNhanVien(maNH, loaiTruyXuat);
                m_lblTimKiemTenNhaHang.Text = "nhân viên thuộc nhà hàng " + ((NhaHangDTO)m_cbxTimKiemNhaHang.SelectedItem).TenNhaHang;
                m_txtThongKeTongNV.Text = temp.ToString();
            }
        }

        /*private void ResetTruongDuLieuThongTin()
        {
            m_txtThongTinMaNV.Text = "";
            m_txtThongTinHoNhanVien.Text = "";
            m_txtThongTinTenNhanVien.Text = "";
            m_txtThongTinCMND.Text = "";
            m_txtThongTinDiaChi.Text = "";
            m_txtThongTinDienThoai.Text = "";
            m_txtThongTinTinhTrang.Text = "";
            m_dtpThongTinNgayVaolam.Value = DateTime.Today;
            m_cbxThongTinLoaiNhanVien.SelectedIndex = 0;
            m_cbxThongTinNhaHang.SelectedIndex = 0;
        }*/

        private void TimKiemNhanVien(ThongTinNhanVienDTO nv)
        {
            nv.MaNhanVien = Int32.Parse(m_txtTimKiemMaNV.Text == "" ? "0" : m_txtTimKiemMaNV.Text);
            nv.Ho = m_txtTimKiemHoNV.Text;
            nv.Ten = m_txtTimKiemTenNV.Text;
            nv.CMND = m_txtTimKiemCMND.Text;
            nv.DienThoai = m_txtTimKiemDienThoai.Text;
            nv.DiaChi = "";
            if (m_cbxTimKiemNhaHang.SelectedIndex == 0)
                nv.MaNhaHang = -1;  //Tất cả
            else if (m_cbxTimKiemNhaHang.SelectedIndex == m_cbxTimKiemNhaHang.Items.Count - 1)
                nv.MaNhaHang = 0;   //= null
            else
                nv.MaNhaHang = ((NhaHangDTO)m_cbxTimKiemNhaHang.SelectedItem).MaNhaHang;

            if (m_cbxTimKiemLoaiNV.SelectedIndex == 0)
                nv.MaLoaiNhanVien = -1;
            else if (m_cbxTimKiemLoaiNV.SelectedIndex == m_cbxTimKiemLoaiNV.Items.Count - 1)
                nv.MaLoaiNhanVien = 0;
            else
                nv.MaLoaiNhanVien = ((LoaiNhanVienDTO)m_cbxTimKiemLoaiNV.SelectedItem).MaLoaiNhanVien;
            nv.NgayVaoLam = m_dtpTimKiemNgayVaoLam.Value;

            int loaiTruyXuat = m_cbxLoaiTruyXuat.SelectedIndex;
            List<ThongTinNhanVienDTO> dt = ThongTinNhanVienBUS.FindNhanVien(nv, loaiTruyXuat);

            if (dt.Count > 0)
            {
                m_dgvDanhSachNhanVien.DataSource = dt;
                UpdateDatagridviewDSNhanVien();
            }
            else
                m_dgvDanhSachNhanVien.DataSource = null;


            TinhTongNhanVien(nv.MaNhaHang, loaiTruyXuat);
        }

        private void m_btnPhanCongNV_Click(object sender, EventArgs e)
        {

        }

        private void m_btnThemNV_Click(object sender, EventArgs e)
        {
            ResetTruongDuLieuThongTin();
            m_btnThongTinHoanTatSuaNV.Visible = false;
        }

        private void m_btnXoaNV_Click(object sender, EventArgs e)
        {
            ThongTinNhanVienBUS.DeleteThongTinNhanVien(Int32.Parse(m_txtThongTinMaNV.Text));
            //LoadDanhSachNhanVien();
            ThongTinNhanVienDTO nvTimKiem = new ThongTinNhanVienDTO();
            TimKiemNhanVien(nvTimKiem);
        }

        private void m_dgvDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            ResetTruongDuLieuThongTin();
            int numRow = m_dgvDanhSachNhanVien.CurrentCell.RowIndex;
            m_txtThongTinMaNV.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells["MaNhanVien"].Value);
            m_cbxThongTinNhaHang.SelectedIndex = Convert.ToInt32(m_dgvDanhSachNhanVien.Rows[numRow].Cells["MaNhaHang"].Value);
            m_cbxThongTinLoaiNhanVien.SelectedIndex = Convert.ToInt32(m_dgvDanhSachNhanVien.Rows[numRow].Cells["MaLoaiNhanVien"].Value);
            m_txtThongTinHoNhanVien.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells["Ho"].Value);
            m_txtThongTinTenNhanVien.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells["Ten"].Value);
            m_txtThongTinCMND.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells["CMND"].Value);
            m_txtThongTinDiaChi.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells["DiaChi"].Value);
            m_txtThongTinDienThoai.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells["DienThoai"].Value);
            m_dtpThongTinNgayVaolam.Value = Convert.ToDateTime(m_dgvDanhSachNhanVien.Rows[numRow].Cells["NgayVaoLam"].Value);
            m_txtThongTinTinhTrang.Text = Convert.ToString(m_dgvDanhSachNhanVien.Rows[numRow].Cells["TinhTrang"].Value);
        }

        private void m_btnThongTinHoanTatSuaNV_Click(object sender, EventArgs e)
        {
            int loaiTruyXuat = m_cbxLoaiTruyXuat.SelectedIndex;

            ThongTinNhanVienDTO nv = new ThongTinNhanVienDTO();
            nv.MaNhanVien = Int32.Parse(m_txtThongTinMaNV.Text.ToString());
            nv.Ho = m_txtThongTinHoNhanVien.Text.ToString();
            nv.Ten = m_txtThongTinTenNhanVien.Text.ToString();
            nv.CMND = m_txtThongTinCMND.Text.ToString();
            nv.DiaChi = m_txtThongTinDiaChi.Text.ToString();
            nv.DienThoai = m_txtThongTinDienThoai.Text.ToString();
            nv.NgayVaoLam = m_dtpThongTinNgayVaolam.Value;
            nv.TinhTrang = m_txtThongTinTinhTrang.Text.ToString();
            if (m_cbxThongTinNhaHang.SelectedIndex == 0)
                nv.MaNhaHang = 0;
            else
                nv.MaNhaHang = ((NhaHangDTO)m_cbxThongTinNhaHang.SelectedItem).MaNhaHang;
            if (m_cbxThongTinLoaiNhanVien.SelectedIndex == 0)
                nv.MaLoaiNhanVien = 0;
            else
                nv.MaLoaiNhanVien = ((LoaiNhanVienDTO)m_cbxThongTinLoaiNhanVien.SelectedItem).MaLoaiNhanVien;

            ThongTinNhanVienBUS.EditThongTinNhanVien(nv, loaiTruyXuat);

            //LoadDanhSachNhanVien();

            ThongTinNhanVienDTO nvTimKiem = new ThongTinNhanVienDTO();
            TimKiemNhanVien(nvTimKiem);
        }

        private void m_btnThongTinHoanTatThemNV_Click(object sender, EventArgs e)
        {
            ThongTinNhanVienDTO nv = new ThongTinNhanVienDTO();
            nv.Ho = m_txtThongTinHoNhanVien.Text.ToString();
            nv.Ten = m_txtThongTinTenNhanVien.Text.ToString();
            nv.CMND = m_txtThongTinCMND.Text.ToString();
            nv.DiaChi = m_txtThongTinDiaChi.Text.ToString();
            nv.DienThoai = m_txtThongTinDienThoai.Text.ToString();
            nv.NgayVaoLam = m_dtpThongTinNgayVaolam.Value;
            nv.TinhTrang = m_txtThongTinTinhTrang.Text.ToString();
            if (m_cbxThongTinNhaHang.SelectedIndex == 0)
                nv.MaNhaHang = -1;
            else
                nv.MaNhaHang = m_cbxThongTinNhaHang.SelectedIndex;
            if (m_cbxThongTinLoaiNhanVien.SelectedIndex == 0)
                nv.MaLoaiNhanVien = -1;
            else
                nv.MaLoaiNhanVien = m_cbxThongTinLoaiNhanVien.SelectedIndex;

            ThongTinNhanVienBUS.AddThongTinNhanVien(nv);
            //LoadDanhSachNhanVien();
            ThongTinNhanVienDTO nvTimKiem = new ThongTinNhanVienDTO();
            TimKiemNhanVien(nvTimKiem);
        }

        private void m_btnTimKiem_Click(object sender, EventArgs e)
        {
            ThongTinNhanVienDTO nv = new ThongTinNhanVienDTO();
            TimKiemNhanVien(nv);
            /*nv.MaNhanVien = Int32.Parse(m_txtTimKiemMaNV.Text == "" ? "0" : m_txtTimKiemMaNV.Text);
            nv.Ho = m_txtTimKiemHoNV.Text;
            nv.Ten = m_txtTimKiemTenNV.Text;
            nv.CMND = m_txtTimKiemCMND.Text;
            nv.DienThoai = m_txtTimKiemDienThoai.Text;
            nv.DiaChi = "";
            if (m_cbxTimKiemNhaHang.SelectedIndex == 0)
                nv.MaNhaHang = -1;  //Tất cả
            else if (m_cbxTimKiemNhaHang.SelectedIndex == m_cbxTimKiemNhaHang.Items.Count - 1)
                nv.MaNhaHang = 0;   //= null
            else
                nv.MaNhaHang = ((NhaHangDTO)m_cbxTimKiemNhaHang.SelectedItem).MaNhaHang;

            if (m_cbxTimKiemLoaiNV.SelectedIndex == 0)
                nv.MaLoaiNhanVien = -1;
            else if (m_cbxTimKiemLoaiNV.SelectedIndex == m_cbxTimKiemLoaiNV.Items.Count - 1)
                nv.MaLoaiNhanVien = 0;
            else
                nv.MaLoaiNhanVien = ((LoaiNhanVienDTO)m_cbxTimKiemLoaiNV.SelectedItem).MaLoaiNhanVien;
            nv.NgayVaoLam = m_dtpTimKiemNgayVaoLam.Value;

            int loaiTruyXuat = m_cbxLoaiTruyXuat.SelectedIndex;
            List<ThongTinNhanVienDTO> dt = ThongTinNhanVienBUS.FindNhanVien(nv, loaiTruyXuat);

            if (dt.Count > 0)
            {
                m_dgvDanhSachNhanVien.DataSource = dt;
                UpdateDatagridviewDSNhanVien();
            }
            else
                m_dgvDanhSachNhanVien.DataSource = null;


            TinhTongNhanVien(nv.MaNhaHang, loaiTruyXuat);
            */
        }

        private void m_iPanelThongTinNV_ItemClick(object sender, EventArgs e)
        {

        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmNhaHang frm = new frmNhaHang();
            frm.ShowDialog();

        }

        private void m_mtTileItmDatBan_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDatBan frm = new frmDatBan();
            frm.ShowDialog();
        }

        private void m_mtTileHome_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmTrangChu frm = new frmTrangChu();
            frm.ShowDialog();
        }

        private void m_mtTileCongTy_Click(object sender, EventArgs e)
        {
        
        }

        private void m_mtHThong_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmHeThong frm = new frmHeThong();
            frm.ShowDialog();
        }

        private void m_mtTieKhoHang_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmKhoHang frm = new frmKhoHang();
            frm.ShowDialog();
        }

        private void panelEx111_Resize(object sender, EventArgs e)
        {
            panelEx100.Location = new Point((panelEx111.Width / 2 - panelEx100.Width / 2), panelEx100.Location.Y);
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            
        }


    }
}