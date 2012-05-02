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
    public partial class ucQuanLyHoaDon : UserControl
    {
        public ucQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void txtTimMaBan_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
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
            } else {
                ngay = new DateTime();
            }

            tenBan = txtTimTenBan.Text;

            List<BanDatDTO> list = BanDatBUS.TimBan(maBan, tenBan, ngay);
            m_dtGirdDSBan.DataSource = list;
        }

        private void m_dtGirdDSBan_Click(object sender, EventArgs e)
        {
            int index = m_dtGirdDSBan.SelectedCells[0].RowIndex;
            lblHoTenKhachHang.Text = m_dtGirdDSBan.Rows[index].Cells["HoTen"].Value.ToString();
            lblCMND.Text = m_dtGirdDSBan.Rows[index].Cells["CMND"].Value.ToString();
            lblDienThoai.Text = m_dtGirdDSBan.Rows[index].Cells["DienThoai"].Value.ToString();
            lblMaBan.Text = m_dtGirdDSBan.Rows[index].Cells["MaBan"].Value.ToString();
            lblNgayLapHoaDon.Text = ((DateTime)m_dtGirdDSBan.Rows[index].Cells["NgayDatBan"].Value).ToShortDateString();
            lblMaLichBan.Text = m_dtGirdDSBan.Rows[index].Cells["MaLichBan"].Value.ToString();
        }

        private void btnTaoMoiHoaDon_Click(object sender, EventArgs e)
        {
            int maLichBan = Int32.Parse(lblMaLichBan.Text);
            
        }

    }
}
