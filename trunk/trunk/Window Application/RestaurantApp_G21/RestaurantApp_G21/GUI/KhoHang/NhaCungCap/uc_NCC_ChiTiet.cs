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
    public partial class uc_NCC_ChiTiet : UserControl
    {
        public uc_NCC_ChiTiet(bool loaiThaoTac)
        {
            InitializeComponent();
            uc_NCC_dsNguyenLieu dsNL = new uc_NCC_dsNguyenLieu();
            pn_ds_nguyenLieu.Controls.Add(dsNL);
            if (!loaiThaoTac)
                initGiaoDienXem();
            else
                initGiaoDienCapNhat();
        }

        private void initGiaoDienXem()
        {
            txt_diaChi.Enabled = false;
            txt_soDienThoai.Enabled = false;
            txt_ten.Enabled = false;
            date_ngayKyHopDong.Enabled = false;
            bt_ngungGiaoDich.Enabled = false;
            bt_dong.Text = "Thoát";
            bt_suaNCC.Text = "Sửa";
        }
        private void initGiaoDienCapNhat()
        {
            txt_diaChi.Enabled = true;
            txt_soDienThoai.Enabled = true;
            txt_ten.Enabled = true;
            date_ngayKyHopDong.Enabled = true;
            bt_ngungGiaoDich.Enabled = true;
            bt_dong.Text = "Hủy";
            bt_suaNCC.Text = "Lưu lại";
        }
        private void bt_suaNCC_Click(object sender, EventArgs e)
        {
            initGiaoDienCapNhat();
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

    }
}
