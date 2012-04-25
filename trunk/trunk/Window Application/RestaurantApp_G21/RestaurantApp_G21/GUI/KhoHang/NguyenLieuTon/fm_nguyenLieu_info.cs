using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    public partial class fm_nguyenLieu_info : Form
    {
        private DTO.NguyenLieuDTO ngLieu;

        internal DTO.NguyenLieuDTO NgLieu
        {
            get { return ngLieu; }
            set { ngLieu = value; }
        }
        public fm_nguyenLieu_info()
        {
            InitializeComponent();
            if (NgLieu != null)
            {
                lb_title.Text = "[+] Thêm nguyên liệu vào kho";
            }else
            {
                lb_title.Text = "[+] Cập nhật thông tin";
            }
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
