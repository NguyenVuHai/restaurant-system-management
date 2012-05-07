using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RestaurantApp_G21.BUS;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    public partial class uc_traCuuNguyenLieuTon : UserControl
    {
        public uc_traCuuNguyenLieuTon()
        {
            InitializeComponent();

            //load combo loai mon an
            ArrayList dsLoaiMonAn = new ArrayList();
            dsLoaiMonAn = LoaiMonAnBUS.layDanhSachLoaiMonAn();
            cb_loaiMonAn.Items.Clear();
            accessory.initComboLoaiMonAn(dsLoaiMonAn, cb_loaiMonAn);
            
            
            showComboMonAn();
            

        }

        public void showComboMonAn()
        {
            ArrayList dsMonAnTheoPhanLoaiMonAn = new ArrayList();
            dsMonAnTheoPhanLoaiMonAn = PhanLoaiMonAnBUS.layDanhSachMonAnTheoPhanLoaiMonAn((LoaiMonAnDTO)cb_loaiMonAn.SelectedItem, GlobalVariables.maNhaHang);
            cb_monAn.Items.Clear();
            accessory.initComboMonAnTheoPhanLoai(dsMonAnTheoPhanLoaiMonAn, cb_monAn);
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

        private void cb_loaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            showComboMonAn();
        }

        private void cb_monAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid_ds.Rows.Clear();
            if (cb_monAn.SelectedIndex != 0)
                showDanhSachNguyenLieuTheoMonAn(((PhanLoaiMonAnDTO)cb_monAn.SelectedItem).MonAn);
            else
            {
                for (int i = 1; i < cb_monAn.Items.Count; i++)
                {
                    showDanhSachNguyenLieuTheoMonAn(((PhanLoaiMonAnDTO)cb_monAn.Items[i]).MonAn);
                }
            }
        }
        private void showDanhSachNguyenLieuTheoMonAn(MonAnDTO monAn)
        {
            ArrayList ds = new ArrayList();
            ds = MonAnBUS.layDanhSachNguyenLieuTheoMonAn(monAn);

            for (int i = 0; i < ds.Count; i++)
            {
                grid_ds.Rows.Add();
                grid_ds.Rows[grid_ds.RowCount - 1].ReadOnly = true;
                grid_ds.Rows[grid_ds.RowCount-1].Cells["cMaNguyenLieu"].Value = ((MonAn_NguyenLieuDTO)ds[i]).NguyenLieu.MaNguyenLieu;
                grid_ds.Rows[grid_ds.RowCount-1].Cells["cTenNguyenLieu"].Value = ((MonAn_NguyenLieuDTO)ds[i]).NguyenLieu;
                grid_ds.Rows[grid_ds.RowCount-1].Cells["cDonViTinh"].Value = ((MonAn_NguyenLieuDTO)ds[i]).NguyenLieu.DonViTinh;
            }
            lb_soLuongKQ.Text = grid_ds.RowCount.ToString();
        }

    }
}
