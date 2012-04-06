using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    public partial class uCtr_BanChuaDat : UserControl
    {
        private bool bIsDaDat = false;// tinnh trang dat ban
        private int iWidth = 113;
        private int iHeight = 117;
        private uCtr_KhuVuc parentKhuVuc = null;
        private string maBan;

        public string MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }

        public uCtr_BanChuaDat(uCtr_KhuVuc kv, bool bDaDat = false, string ma="")
        {
            InitializeComponent();
            this.Width = iWidth;
            this.Height = iHeight;
            this.parentKhuVuc = kv;
            this.maBan = ma;
            bIsDaDat = bDaDat;

            pDatOi.Visible = bIsDaDat; //Cho nay co nghia la neu ban da dat thi cai itemlist daoi no hien ra
            pChuaDat.Visible = !bIsDaDat;  //Cai nay thi pChuaDat se nguoc voi cai pDaDat tuc la pDaDat hien len thi pChuaDat se an di
        }

        public void moveTab()
        {
            frmDatBan frm = this.parentKhuVuc.getParent();
            frm.tabThongTinDatBan(this.MaBan, this.parentKhuVuc.MaKV);
        }

        private void m_btnDatBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon dat ban nay khong ?","Dat Ban?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bIsDaDat = true;
                pDatOi.Visible = true;
                pChuaDat.Visible = false;
                moveTab();
            }            
        }

        private void m_btnHuyDatBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon huy dat ban?", "Huy Dat Ban?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bIsDaDat = false;
                pDatOi.Visible = false;
                pChuaDat.Visible = true;
            }                        
        }

        private void m_btnNhapThongKhach_Click(object sender, EventArgs e)
        {
            moveTab();
        }
    }
}
