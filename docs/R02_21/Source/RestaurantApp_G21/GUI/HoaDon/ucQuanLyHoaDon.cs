using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurantApp_G21.BUS;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21
{
    public partial class frmQuanLyHoaDon : UserControl
    {
        #region Utils Methods
        private void LoadMonAn()
        {
            try
            {
                int maNhaHang = GlobalVariables.maNhaHang;
                DateTime ngay = DateTime.Today;
                List<ChiTietThucDonDTO> list = ChiTietThucDonBUS.LayDanhSachMonAnTheoNhaHang(maNhaHang, ngay);
                cbbDanhSachMonAn.DataSource = list;
                cbbDanhSachMonAn.DisplayMember = "TenMonAn";
            }
            catch (Exception ex)
            {
            }
        }

        private void LoadDanhSachMonAnTrongHoaDon()
        {
            try
            {
                List<ChiTietThucDonDTO> list = ChiTietThucDonBUS.LayDanhSachMonAnTrongHoaDon(GlobalVariables.curMaHoaDon, rbBongMa.Checked, rbDirtyRead.Checked, rbKhongTheDocLai.Checked, rbLostUpdate.Checked);
                GridViewDisplay(list);
            }
            catch (Exception ex)
            {
            }
        }

        private void GridViewDisplay(List<ChiTietThucDonDTO> list)
        {
            decimal total = 0;
            foreach (var item in list)
            {
                total += item.SoLuong * item.DonGia;
            }
            m_dtGridDSDatMon.DataSource = list;
            m_dtGridDSDatMon.Columns["MaChiTietHoaDon"].Visible = false;
            m_dtGridDSDatMon.Columns["MaChiTietThucDon"].Visible = false;
            m_dtGridDSDatMon.Columns["MaThucDon"].Visible = false;
            m_dtGridDSDatMon.Columns["MaMonAn"].Visible = false;
            m_dtGridDSDatMon.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            m_dtGridDSDatMon.Columns["DonGia"].HeaderText = "Đơn giá";
            m_dtGridDSDatMon.Columns["SoLuong"].HeaderText = "Số lượng";
            m_dtGridDSDatMon.Columns["ThanhTien"].HeaderText = "Tổng";
            for (int i = 0; i < m_dtGridDSDatMon.Columns.Count; i++)
            {
                m_dtGridDSDatMon.Columns[i].Width = m_dtGridDSDatMon.Width / 4;
            }
            m_txtTongTien.Text = total.ToString();
        }

        private void LoadMucCoLap()
        {
            cbMucCoLap.Items.Add("Mặc định");
            cbMucCoLap.Items.Add("Read Uncommitted");
            cbMucCoLap.Items.Add("Read Committed");
            cbMucCoLap.Items.Add("Repeatable Read");
            cbMucCoLap.Items.Add("Serializable");
            cbMucCoLap.SelectedIndex = 0;
        }
        #endregion
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            LoadMonAn();
            LoadMucCoLap();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimBan();
        }

        private void TimBan()
        {
            int maBan;
            string tenBan;
            DateTime ngay;
            if (txtTimMaBan.Text != "")
            {
                if (!Int32.TryParse(txtTimMaBan.Text, out maBan))
                {
                    MessageBox.Show("Mã bàn không hợp lệ.");
                    return;
                }
            }
            else
            {
                maBan = 0;
            }

            if (dtNgayDatBan.Text != "")
            {
                if (!DateTime.TryParse(dtNgayDatBan.Text, out ngay))
                {
                    MessageBox.Show("Ngày không hợp lệ.");
                    return;
                }
            }
            else
            {
                ngay = new DateTime();
            }

            tenBan = txtTimTenBan.Text;

            List<BanDatDTO> list = BanDatBUS.TimBan(GlobalVariables.maNhaHang, maBan, tenBan, ngay);
            m_dtGirdDSBan.DataSource = list;
            for (int i = 0; i < m_dtGirdDSBan.Columns.Count; i++)
            {
                m_dtGirdDSBan.Columns[i].Width = m_dtGirdDSBan.Width / 4;
            }
            m_dtGirdDSBan.Columns["TinhTrangBan"].HeaderText = "Đã đặt";
            m_dtGirdDSBan.Columns["TenBuoi"].HeaderText = "Buổi";
            m_dtGirdDSBan.Columns["MaBan"].HeaderText = "Mã bàn";
            m_dtGirdDSBan.Columns["NgayDatBan"].HeaderText = "Ngày đặt bàn";
            m_dtGirdDSBan.Columns["MaNhaHang"].Visible = false;
            m_dtGirdDSBan.Columns["HoTen"].Visible = false;
            m_dtGirdDSBan.Columns["Cmnd"].Visible = false;
            m_dtGirdDSBan.Columns["DienThoai"].Visible = false;
            m_dtGirdDSBan.Columns["MaLichBan"].Visible = false;
            m_dtGirdDSBan.Columns["MaThongTinKhachHang"].Visible = false;
            m_dtGirdDSBan.Columns["SoLuong"].Visible = false;
            m_dtGirdDSBan.Columns["MaLichBan"].Visible = false;
            m_dtGirdDSBan.Columns["MaBuoi"].Visible = false;
        }

        private void LoadThongTinHoaDon(int index)
        {
            lblNhaHang.Text = m_dtGirdDSBan.Rows[index].Cells["MaNhaHang"].Value.ToString();
            lblHoTenKhachHang.Text = m_dtGirdDSBan.Rows[index].Cells["HoTen"].Value.ToString();
            lblCMND.Text = m_dtGirdDSBan.Rows[index].Cells["CMND"].Value.ToString();
            lblDienThoai.Text = m_dtGirdDSBan.Rows[index].Cells["DienThoai"].Value.ToString();
            lblMaBan.Text = m_dtGirdDSBan.Rows[index].Cells["MaBan"].Value.ToString();
            lblNgayLapHoaDon.Text = ((DateTime)m_dtGirdDSBan.Rows[index].Cells["NgayDatBan"].Value).ToShortDateString();
            lblBuoi.Text = m_dtGirdDSBan.Rows[index].Cells["TenBuoi"].Value.ToString();
        }

        private void btnTaoMoiHoaDon_Click(object sender, EventArgs e)
        {
            int maLichBan = GlobalVariables.maLichBan;
            HoaDonBUS.ThemHoaDon(maLichBan, DateTime.Today);
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if (!Guid.TryParse(HoaDonBUS.KiemTraHoaDon(GlobalVariables.maLichBan), out GlobalVariables.curMaHoaDon))
            {
                MessageBox.Show("Vui lòng tạo hóa đơn.");
                return;
            }
            if (txtSoLuong.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            int maChiTietThucDon = ((ChiTietThucDonDTO)cbbDanhSachMonAn.SelectedItem).MaChiTietThucDon;
            decimal donGia;
            if (txtDonGia.Text.Equals(""))
                donGia = ((ChiTietThucDonDTO)cbbDanhSachMonAn.SelectedItem).DonGia;
            else
                donGia = Decimal.Parse(txtDonGia.Text);
            int soLuong = Int32.Parse(txtSoLuong.Text);
            //m_dtGridDSDatMon
            HoaDonBUS.CapNhatChiTietHoaDon(GlobalVariables.curMaHoaDon, maChiTietThucDon, donGia, soLuong, rbBongMa.Checked, rbDirtyRead.Checked, rbLostUpdate.Checked);
            LoadDanhSachMonAnTrongHoaDon();
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            HoaDonBUS.XoaMonAn(GlobalVariables.maChiTietHoaDon, rbDirtyRead.Checked, rbKhongTheDocLai.Checked);
            LoadDanhSachMonAnTrongHoaDon();
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bMacDinh = rbNormal.Checked;
        }

        private void rbBiBongMa_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bBongMa = rbBiBongMa.Checked;
        }

        private void rbKhongBongMa_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bBongMa = rbBiBongMa.Checked;
        }

        private void rbBiDuLieuRac_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bDuLieuRac = rbBiDuLieuRac.Checked;
        }

        private void rbKhongDuLieuRac_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bDuLieuRac = rbBiDuLieuRac.Checked;
        }

        private void rbBiKhongTheDocLai_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bKhongTheDocLai = rbBiKhongTheDocLai.Checked;

        }

        private void rbKhongBiKhongTheDocLai_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bKhongTheDocLai = rbBiKhongTheDocLai.Checked;
        }

        private void rbBiLostUpdate_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bLostUpdate = rbBiLostUpdate.Checked;
        }

        private void rbKhongLostUpdate_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bLostUpdate = rbBiLostUpdate.Checked;
            cbMucCoLap.Enabled = rbLostUpdate.Checked && rbKhongLostUpdate.Checked;
        }

        private void rbBongMa_CheckedChanged(object sender, EventArgs e)
        {
        GlobalVariables.bMacDinh = rbNormal.Checked;
        }

        private void rbDirtyRead_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bMacDinh = rbNormal.Checked;
        }

        private void rbKhongTheDocLai_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bMacDinh = rbNormal.Checked;
        }

        private void rbLostUpdate_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bMacDinh = rbNormal.Checked;
            cbMucCoLap.Enabled = rbLostUpdate.Checked && rbKhongLostUpdate.Checked;
        }

        private void m_btnThanhToan_Click(object sender, EventArgs e)
        {
            GlobalVariables.chiTietThucDonDTO = ChiTietThucDonBUS.LayDanhSachMonAnTrongHoaDon(GlobalVariables.curMaHoaDon, rbBongMa.Checked, rbDirtyRead.Checked, rbKhongTheDocLai.Checked, rbLostUpdate.Checked);
            decimal thanhtien = 0;
            foreach (ChiTietThucDonDTO item in GlobalVariables.chiTietThucDonDTO)
            {
                thanhtien += item.ThanhTien;
            }
            //MessageBox.Show(String.Format("Tổng số dòng lần 1: {2}\nTổng số dòng lần 2: {1}\nTổng hóa đơn: {0}",thanhtien,list.Count,m_dtGridDSDatMon.Rows.Count),"Demo Phantom");
            GlobalVariables.maBan = Int32.Parse(lblMaBan.Text);
            GlobalVariables.tenNhaHang = lblNhaHang.Text;
            GridViewDisplay(GlobalVariables.chiTietThucDonDTO);
            frmXuatHoaDon frm = new frmXuatHoaDon();
            frm.ShowDialog();
        }

        private void m_dtGirdDSBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = m_dtGirdDSBan.SelectedCells[0].RowIndex;
            GlobalVariables.maLichBan = Int32.Parse(m_dtGirdDSBan.Rows[index].Cells["MaLichBan"].Value.ToString());
            string maHoaDon = HoaDonBUS.KiemTraHoaDon(GlobalVariables.maLichBan);
            GlobalVariables.bBongMa = rbBiBongMa.Checked;
            GlobalVariables.bDuLieuRac = rbBiDuLieuRac.Checked;
            GlobalVariables.bKhongTheDocLai = rbBiKhongTheDocLai.Checked;
            GlobalVariables.bLostUpdate = rbBiLostUpdate.Checked;
            if (Guid.TryParse(maHoaDon, out GlobalVariables.curMaHoaDon))
            {
                LoadThongTinHoaDon(index);
                LoadDanhSachMonAnTrongHoaDon();
            }
            else
            {
                if (MessageBox.Show("Hóa đơn chưa tồn tại. Bạn có muốn tạo mới hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maLichBan = GlobalVariables.maLichBan;
                    GlobalVariables.curMaHoaDon = HoaDonBUS.ThemHoaDon(maLichBan, DateTime.Today);
                    LoadThongTinHoaDon(index);
                    LoadDanhSachMonAnTrongHoaDon();
                }
            }
        }

        private void txtTimMaBan_TextChanged(object sender, EventArgs e)
        {
            TimBan();
        }

        private void m_dtGridDSDatMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (m_dtGridDSDatMon.Rows.Count > 0)
            {
                GlobalVariables.maChiTietHoaDon.Clear();
                foreach (DataGridViewCell cell in m_dtGridDSDatMon.SelectedCells)
                {
                    int maChiTietHoaDon = Int32.Parse(m_dtGridDSDatMon.Rows[cell.RowIndex].Cells["MaChiTietHoaDon"].Value.ToString());
                    GlobalVariables.maChiTietHoaDon.Add(maChiTietHoaDon);
                    txtDonGia.Text = m_dtGridDSDatMon.Rows[cell.RowIndex].Cells["DonGia"].Value.ToString();
                    txtSoLuong.Text = m_dtGridDSDatMon.Rows[cell.RowIndex].Cells["SoLuong"].Value.ToString();
                    for (int i = 0; i < cbbDanhSachMonAn.Items.Count; i++)
                    {
                        if (((ChiTietThucDonDTO)cbbDanhSachMonAn.Items[i]).MaChiTietThucDon.Equals(m_dtGridDSDatMon.Rows[cell.RowIndex].Cells["MaChiTietThucDon"].Value))
                        {
                            cbbDanhSachMonAn.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void cbMucCoLap_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVariables.mucCoLap = cbMucCoLap.SelectedIndex;
        }
    }
}
