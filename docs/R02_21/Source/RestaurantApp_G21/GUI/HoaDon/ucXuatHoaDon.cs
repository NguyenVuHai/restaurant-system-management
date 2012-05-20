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
    public partial class ucXuatHoaDon : UserControl
    {
        private void LoadThongTinHoaDon()
        {
            decimal total = 0;
            foreach (var item in GlobalVariables.chiTietThucDonDTO)
            {
                total += item.SoLuong * item.DonGia;
            }
            dgvDanhSachMonAnThanhToan.DataSource = GlobalVariables.chiTietThucDonDTO;
            dgvDanhSachMonAnThanhToan.Columns["MaChiTietHoaDon"].Visible = false;
            dgvDanhSachMonAnThanhToan.Columns["MaChiTietThucDon"].Visible = false;
            dgvDanhSachMonAnThanhToan.Columns["MaThucDon"].Visible = false;
            dgvDanhSachMonAnThanhToan.Columns["MaMonAn"].Visible = false;
            dgvDanhSachMonAnThanhToan.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvDanhSachMonAnThanhToan.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDanhSachMonAnThanhToan.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachMonAnThanhToan.Columns["ThanhTien"].HeaderText = "Thành tiền";
            for (int i = 0; i < dgvDanhSachMonAnThanhToan.Columns.Count; i++)
            {
                dgvDanhSachMonAnThanhToan.Columns[i].Width = (dgvDanhSachMonAnThanhToan.Width - 2) / 4 ;
            }
            lblTongCong.Text = total.ToString();
            lbNgayThanhToan.Text = DateTime.Today.ToShortDateString();
            lblNhaHangThanhToan.Text = GlobalVariables.tenNhaHang;
            lblBanThanhToan.Text = GlobalVariables.maBan.ToString();
        }
        public ucXuatHoaDon()
        {
            InitializeComponent();
            LoadThongTinHoaDon();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã in thành công.");
        }
    }
}
