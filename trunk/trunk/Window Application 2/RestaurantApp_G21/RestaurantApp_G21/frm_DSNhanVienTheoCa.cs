using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace RestaurantApp_G21
{
    public partial class FormDSNhanVienTheoCa : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormDSNhanVienTheoCa()
        {
            InitializeComponent();
        }

        private void m_btnPhanCongThem_Click(object sender, EventArgs e)
        {
            FormXepLichLamViec form = new FormXepLichLamViec();
            form.Show();
        }
    }
}