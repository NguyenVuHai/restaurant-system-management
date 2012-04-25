using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    public partial class uc_traCuuNguyenLieuTon : UserControl
    {
        public uc_traCuuNguyenLieuTon()
        {
            InitializeComponent();
        }

        private void bt_lapPhieuDatHang_Click(object sender, EventArgs e)
        {
            fm_PhieuDatHang fm = new fm_PhieuDatHang();
            fm.Show();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            fm_nguyenLieu_info fm = new fm_nguyenLieu_info();
            fm.NgLieu = null;
            fm.Show();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            GUI.accessory.readOnlyCheckedRows(grid_ds, false);
            bt_sua.Text = "Cập nhật";
            bt_sua.Click += new EventHandler(bt_capNhat_Click);
        }
        private void bt_capNhat_Click(object sender, EventArgs e)
        {
            GUI.accessory.readOnlyCheckedRows(grid_ds, true);
            bt_sua.Text = "Sửa";
            bt_sua.Click += new EventHandler(bt_sua_Click);
        }

        private void bt_chonTatCa_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_ds, true);
            bt_chonTatCa.Text = "Bỏ chọn";
            bt_chonTatCa.Click += new EventHandler(bt_boChon_Click);

        }
        private void bt_boChon_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_ds, false);
            bt_chonTatCa.Text = "Chọn tất cả";
            bt_chonTatCa.Click += new EventHandler(bt_chonTatCa_Click);
        } 

    }
}
