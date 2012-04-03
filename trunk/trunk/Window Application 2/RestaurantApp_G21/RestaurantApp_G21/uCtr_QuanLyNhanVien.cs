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
    public partial class uCtr_QuanLyNhanVien : UserControl
    {
        public uCtr_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void m_btnThem_Click(object sender, EventArgs e)
        {
            FormThongTinNhanVien form = new FormThongTinNhanVien();
            form.Show();
        }

        private void m_btnThayDoi_Click(object sender, EventArgs e)
        {
            FormThongTinNhanVien form = new FormThongTinNhanVien();
            form.Show();
        }

        private void m_btnXepLichLamViec_Click(object sender, EventArgs e)
        {
            FormXepLichLamViec form = new FormXepLichLamViec();
            form.Show();
        }
    }
}
