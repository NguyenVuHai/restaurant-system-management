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
            this.BackColor = SystemColors.InactiveCaptionText;
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
            this.BackColor = SystemColors.InactiveCaptionText;
        }

        private void frmTrangChu_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = SystemColors.InactiveCaptionText;
        }
    }
}