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
            tab_NL.AttachedControl.Controls.Add(uc_NL);

            GUI.KhoHang.NhaCungCap.uc_traCuuNCC uc_NCC = new GUI.KhoHang.NhaCungCap.uc_traCuuNCC();
            tab_NCC.AttachedControl.Controls.Add(uc_NCC);

            GUI.KhoHang.NguyenLieuTon.uc_phieuDatHang uc_phieuDatHang = new GUI.KhoHang.NguyenLieuTon.uc_phieuDatHang();
            tab_nguyenLieuCanNhap.AttachedControl.Controls.Add(uc_phieuDatHang);
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void m_sTabItmTTBanDat_Click(object sender, EventArgs e)
        {
            
        }

        private void superTabItem1_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}