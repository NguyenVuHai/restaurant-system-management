using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    public partial class frmTrangChu : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
            panelEx1.Location = new Point((Screen.PrimaryScreen.Bounds.Width - panelEx1.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - panelEx1.Height) / 2);
            this.BackColor = Color.AliceBlue;
        }

        private void metroTileItemBatBan_Click(object sender, EventArgs e)
        {
            frmDatBan frm = new frmDatBan();
            frm.ShowDialog();
        }

       
        private void m_mtTileItemNhaHang_Click(object sender, EventArgs e)
        {
            frmNhaHang frm = new frmNhaHang();
            frm.Show();
        }

        private void m_mtTileItemKho_Click(object sender, EventArgs e)
        {
            //GUI.KhoHang.uc_main uc = new GUI.KhoHang.uc_main();
            //this.panelEx1.Controls.Clear();
            //this.panelEx1.Controls.Add(uc);

            frmKhoHang frm = new frmKhoHang();
            frm.Show();
        }

        private void m_mtTileItemHeThong_Click(object sender, EventArgs e)
        {
            frmHeThong frm = new frmHeThong();
            frm.Show();
        }

        private void m_mtTileItemCongTy_Click(object sender, EventArgs e)
        {
            frmCongTy frm = new frmCongTy();
            frm.Show();
        }

        private void frmTrangChu_Resize(object sender, EventArgs e)
        {
            panelEx1.Location = new Point((this.Width - panelEx1.Width) / 2, (this.Height - panelEx1.Height) / 2);
            this.BackColor = Color.AliceBlue;
        }

        private void frmTrangChu_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }
        #region Puppy

        public void DisableCacChucNang(bool trangThai, int loaiNhanVien)
        {
            frmDangNhap fDangNhap = new frmDangNhap();
            fDangNhap.Enabled = !trangThai;
            // nếu đăng nhập thành công mặc định là bật hết các chức năng
            m_mtTileItemCongTy.Enabled = trangThai;
            m_mtTileItemHeThong.Enabled = trangThai;
            m_mtTileItemKho.Enabled = trangThai;
            m_mtTileItemNhaHang.Enabled = trangThai;
            m_mtTileItemBatBan.Enabled = trangThai;
            switch (loaiNhanVien)
            {
                case 1: CongTy(); break;// cong ty
                case 2: break;// nhà hàng
                case 3: TienTanThuNgan(); break;// tiếp tân
                case 4: TienTanThuNgan(); break;//thu ngân
                case 5: KhoHang(); break; // kho hàng
            }

        }
        public void CongTy()
        {
            m_mtTileItemBatBan.Enabled = false;
            m_mtTileItemNhaHang.Enabled = false;
            m_mtTileItemHeThong.Enabled = false;
            m_mtTileItemKho.Enabled = false;
        }
        public void TienTanThuNgan()
        {
            m_mtTileItemCongTy.Enabled = false;
            m_mtTileItemHeThong.Enabled = false;
            m_mtTileItemKho.Enabled = false;
            m_mtTileItemNhaHang.Enabled = false;
            m_mtTileItemHeThong.Enabled = false;

        }
        public void KhoHang()
        {
            m_mtTileItemCongTy.Enabled = false;
            m_mtTileItemHeThong.Enabled = false;
            m_mtTileItemBatBan.Enabled = false;
            m_mtTileItemNhaHang.Enabled = false;
            m_mtTileItemHeThong.Enabled = false;

        }

        private void m_lbThayDoiMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoiMatKhau fDoiMatKhau = new frmDoiMatKhau();
            fDoiMatKhau.Show();
        }
        #endregion
        
    }
}