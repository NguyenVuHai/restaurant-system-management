using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    public partial class uc_phieuDatHang : UserControl
    {
        public uc_phieuDatHang()
        {
            InitializeComponent();
            uc_nguyenLieuToiMucToiThieu uc_1 = new uc_nguyenLieuToiMucToiThieu();
            tabPage_danhSach.AttachedControl.Controls.Add(uc_1);

            uc_nhapHangDotXuat uc_2 = new uc_nhapHangDotXuat();
            tabPage_lapPhieuDatHang.AttachedControl.Controls.Add(uc_2);
        }

        private void bt_chonTatCa_Click(object sender, EventArgs e)
        {
            //GUI.accessory.checkAllRowsOfGrid(grid_ds, true);
            //bt_chonTatCa.Text = "Bỏ chọn";
            
            //bt_chonTatCa.Click += new EventHandler(bt_boChonTatCa_Click);
        }
        private void bt_boChonTatCa_Click(object sender, EventArgs e)
        {
            //GUI.accessory.checkAllRowsOfGrid(grid_ds, false);
            //bt_chonTatCa.Text = "Chọn tất cả";
            //bt_chonTatCa.Click += new EventHandler(bt_chonTatCa_Click);
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {

        }

        private void bt_tienHanhLapPhieu_Click(object sender, EventArgs e)
        {

        }

    }
}
