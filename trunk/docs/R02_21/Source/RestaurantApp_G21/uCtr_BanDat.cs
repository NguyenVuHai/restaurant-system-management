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
    public partial class uCtr_BanDat : UserControl
    {
        private bool bIsDaDat = false;// tinnh trang dat ban
        private int iWidth = 113;
        private int iHeight = 117;
        public uCtr_BanDat(bool bDaDat = false)
        {
            InitializeComponent();
            this.Width = iWidth;
            this.Height = iHeight;

            bIsDaDat = bDaDat;

            pDatOi.Visible = bIsDaDat; //Cho nay co nghia la neu ban da dat thi cai itemlist daoi no hien ra
            pChuaDat.Visible = !bIsDaDat;  //Cai nay thi pChuaDat se nguoc voi cai pDaDat tuc la pDaDat hien len thi pChuaDat se an di
        }

        private void m_btnDatBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon dat cai ban này không ?","Dat Ban?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bIsDaDat = true;
                pDatOi.Visible = true;
                pChuaDat.Visible = false;
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
    }
}
