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
                List<ChiTietThucDonDTO> list = ChiTietThucDonBUS.LayDanhSachMonAnTrongHoaDon(GlobalVariables.curMaHoaDon, rbBongMa.Checked, rbDirtyRead.Checked, rbKhongTheDocLai.Checked);
                decimal total = 0;
                foreach (var item in list)
                {
                    total += item.SoLuong * item.DonGia;
                }
                m_dtGridDSDatMon.DataSource = list;
                m_txtTongTien.Text = total.ToString();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            LoadMonAn();
        }

        private void txtTimMaBan_Enter(object sender, EventArgs e)
        {
            TimBan();
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
        }

        private void m_dtGirdDSBan_Click(object sender, EventArgs e)
        {
            int index = m_dtGirdDSBan.SelectedCells[0].RowIndex;
            GlobalVariables.maLichBan = Int32.Parse(m_dtGirdDSBan.Rows[index].Cells["MaLichBan"].Value.ToString());
            string maHoaDon = HoaDonBUS.KiemTraHoaDon(GlobalVariables.maLichBan);
            GlobalVariables.bBongMa = rbBiBongMa.Checked;
            GlobalVariables.bDuLieuRac = rbBiDuLieuRac.Checked;
            GlobalVariables.bKhongTheDocLai = rbBiKhongTheDocLai.Checked;
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
            HoaDonBUS.ThemMonAn(GlobalVariables.curMaHoaDon, maChiTietThucDon, donGia, soLuong, rbBongMa.Checked, rbDirtyRead.Checked);
            LoadDanhSachMonAnTrongHoaDon();
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            HoaDonBUS.XoaMonAn(GlobalVariables.maChiTietHoaDon, rbDirtyRead.Checked, rbKhongTheDocLai.Checked);
            LoadDanhSachMonAnTrongHoaDon();
        }

        private void m_dtGridDSDatMon_Click(object sender, EventArgs e)
        {
            if (m_dtGridDSDatMon.Rows.Count > 0)
            {
                GlobalVariables.maChiTietHoaDon.Clear();
                foreach (DataGridViewCell cell in m_dtGridDSDatMon.SelectedCells)
                {
                    int maChiTietHoaDon = Int32.Parse(m_dtGridDSDatMon.Rows[cell.RowIndex].Cells["MaChiTietHoaDon"].Value.ToString());
                    GlobalVariables.maChiTietHoaDon.Add(maChiTietHoaDon);
                }
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVariables.bMacDinh = rbNormal.Checked;
        }
    }
}
