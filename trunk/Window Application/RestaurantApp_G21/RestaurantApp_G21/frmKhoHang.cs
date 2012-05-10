using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    public partial class frmKhoHang : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmKhoHang()
        {
            InitializeComponent();
            GUI.KhoHang.NguyenLieuTon.uc_traCuuNguyenLieuTon uc_NL = new GUI.KhoHang.NguyenLieuTon.uc_traCuuNguyenLieuTon();
            uc_NL.Dock = DockStyle.Fill;
            tab_NL.AttachedControl.Controls.Add(uc_NL);

            GUI.KhoHang.NhaCungCap.uc_traCuuNCC uc_NCC = new GUI.KhoHang.NhaCungCap.uc_traCuuNCC();
            uc_NCC.Dock = DockStyle.Fill;
            tab_NCC.AttachedControl.Controls.Add(uc_NCC);

            GUI.KhoHang.NguyenLieuTon.uc_phieuDatHang uc_phieuDatHang = new GUI.KhoHang.NguyenLieuTon.uc_phieuDatHang();
            uc_phieuDatHang.Dock = DockStyle.Fill;
            tab_nguyenLieuCanNhap.AttachedControl.Controls.Add(uc_phieuDatHang);

            GUI.KhoHang.NguyenLieuTon.uc_nhapHangDotXuat uc_nhapHangDotXuat = new GUI.KhoHang.NguyenLieuTon.uc_nhapHangDotXuat();
            uc_nhapHangDotXuat.Dock = DockStyle.Fill;
            tab_nhapHangDotXuat.AttachedControl.Controls.Add(uc_nhapHangDotXuat);

            GUI.KhoHang.NhaCungCap.uc_nccToiHanCanThanhToan uc_nccToiHanCanThanhToan = new GUI.KhoHang.NhaCungCap.uc_nccToiHanCanThanhToan();
            uc_nccToiHanCanThanhToan.Dock = DockStyle.Fill;
            tab_noToiHanThanhToan.AttachedControl.Controls.Add(uc_nccToiHanCanThanhToan);
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_sTabItmTTBanDat_Click(object sender, EventArgs e)
        {
            
        }

        private void superTabItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void tab_nguyenLieuCanNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_thuGon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bt_moRong_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panelEx1_SizeChanged(object sender, EventArgs e)
        {
            int w = (panelEx1.Width / 4);
            for (int i = 0; i < panelEx1.Controls.Count; i++)
                panelEx1.Controls[i].Width = w;
        }

        private void bt_anDi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
    }
}