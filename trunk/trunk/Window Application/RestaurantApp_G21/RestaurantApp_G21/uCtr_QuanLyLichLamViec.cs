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
    public partial class uCtr_QuanLyLichLamViec : UserControl
    {
        public uCtr_QuanLyLichLamViec()
        {
            InitializeComponent();
        }

        private void m_btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FormDSNhanVienTheoCa form = new FormDSNhanVienTheoCa();
            form.Show();
        }
    }
}
