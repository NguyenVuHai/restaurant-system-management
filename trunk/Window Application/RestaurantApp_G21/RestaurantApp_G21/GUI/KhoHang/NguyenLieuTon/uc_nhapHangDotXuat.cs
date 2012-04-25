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
    public partial class uc_nhapHangDotXuat : UserControl
    {
        public uc_nhapHangDotXuat()
        {
            InitializeComponent();
        }

        private void bt_loaiBoKhoiDanhSachCanDat_Click(object sender, EventArgs e)
        {
            accessory.removeCheckedRows(grid_nguyenLieuCanDatHang);
        }

        private void bt_tabPage_CTPhieuDat_chonTatCa_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_chiTietPhieuDat, true);
            bt_tabPage_CTPhieuDat_chonTatCa.Text = "Bỏ chọn";
            bt_tabPage_CTPhieuDat_chonTatCa.Click += new EventHandler(bt_tabPage_CTPhieuDat_boChonTatCa_Click);
        }
        private void bt_tabPage_CTPhieuDat_boChonTatCa_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_chiTietPhieuDat, false);
            bt_tabPage_CTPhieuDat_chonTatCa.Text = "Chọn tất cả";
            bt_tabPage_CTPhieuDat_chonTatCa.Click += new EventHandler(bt_tabPage_CTPhieuDat_chonTatCa_Click);
        }

        private void bt_tabPage_boRa_Click(object sender, EventArgs e)
        {
            accessory.removeCheckedRows(grid_chiTietPhieuDat);
            /*them nhung nguyen lieu bi loai bo khoi danh sach grid_chiTietPhieuDat 
             * vào danh sach grid_nguyenLieuCanDatHang 
             * .....*/

        }
    }
}
