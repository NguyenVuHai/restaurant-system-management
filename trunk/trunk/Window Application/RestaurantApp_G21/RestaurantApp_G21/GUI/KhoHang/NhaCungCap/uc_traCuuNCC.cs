using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21.GUI.KhoHang.NhaCungCap
{
    public partial class uc_traCuuNCC : UserControl
    {
        public uc_traCuuNCC()
        {
            InitializeComponent();
        }

        private void gv_ds_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showFormNCC_ChiTiet(false);
        }
        private void showFormNCC_ChiTiet(bool loaiThaoTac)
        {
            fm_NCC_ChiTiet fm = new fm_NCC_ChiTiet();
            fm.LoaiThaoTac = loaiThaoTac;
            fm.Show();
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            int totalSelectedRows = grid_ds.SelectedRows.Count;
            if (totalSelectedRows != 1)
            {
                MessageBox.Show("Mỗi lần chỉ được sửa thông tin của 1 NCC", "[!]Thông báo");
                return;
            }
            showFormNCC_ChiTiet(true);
        }

        private void bt_chonAll_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_ds, true);
            bt_chonAll.Text = "Bỏ chọn";
            bt_chonAll.Click += new EventHandler(bt_chonAll_Click);
        }
        private void bt_boChon_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_ds, false);
            bt_chonAll.Text = "Chọn tất cả";
            bt_chonAll.Click += new EventHandler(bt_chonAll_Click);
        }
        private void checkAllRowsOfGrid(bool stt)
        {

        }




    }
}
