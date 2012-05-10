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

namespace RestaurantApp_G21.GUI.KhoHang.NhaCungCap
{
    public partial class uc_traCuuNCC : UserControl
    {
        public uc_traCuuNCC()
        {
            InitializeComponent();
            accessory.initButtonDockFillInPanel(panel2);
            cb_tinhTrangNo.SelectedIndex = cb_tinTrangGiaoDich.SelectedIndex =0;

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
            bt_chonAll.Click += new EventHandler(bt_boChon_Click);
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

        private void panel2_Resize(object sender, EventArgs e)
        {
            accessory.initButtonDockFillInPanel(panel2);
        }

        private void cb_tinTrangGiaoDich_SelectedIndexChanged()
        {
            grid_ds.Rows.Clear();
            int curIndex = cb_tinTrangGiaoDich.SelectedIndex;
            ArrayList dsNCC = new ArrayList();
            if (curIndex == 0)
            {
                dsNCC = KhoHangBUS.layDanhSachNhaCungCap(GlobalVariables.maNhaHang, txt_ten.Text);
            }
            else
            {
                if (curIndex == 1 || curIndex == 2)
                    dsNCC = KhoHangBUS.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(txt_ten.Text, curIndex, GlobalVariables.maNhaHang);
                if (curIndex == 3)
                    dsNCC = KhoHangBUS.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich(txt_ten.Text, GlobalVariables.maNhaHang);
            }
            for (int i = 0; i < dsNCC.Count; i++)
            {
                NhaCungCapDTO dto = (NhaCungCapDTO)dsNCC[i];
                grid_ds.Rows.Add();
                grid_ds.Rows[i].Cells["cMaNhaCungCap"].Value = dto.MaNhaCungCap;
                grid_ds.Rows[i].Cells["cTenNhaCungCap"].Value = dto;
                grid_ds.Rows[i].Cells["cDienThoai"].Value = dto.DienThoai;
                grid_ds.Rows[i].Cells["cSoTaiKhoan"].Value = dto.SoTaiKhoan;
                grid_ds.Rows[i].Cells["cTongNo"].Value = dto.TongNo;
            }
        }
        private void cb_tinTrangGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_tinTrangGiaoDich_SelectedIndexChanged();
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            cb_tinTrangGiaoDich_SelectedIndexChanged();
        }
    }
}
