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
    public partial class uCtr_KhuVuc : FlowLayoutPanel
    {
        private Label lblTenKhuVuc = new Label();

        public uCtr_KhuVuc(string tenKhuVuc, int soBan)// hàm dựng
        {
            InitializeComponent();
            this.lblTenKhuVuc.Text = tenKhuVuc;
            this.Controls.Add(lblTenKhuVuc);
            for (int i = 0; i < soBan; i++)
            { 
                themBnVaoKhuVuc(new uCtr_BanDat(false)); // Truyền false vì cái khuvuc mới tạo sẽ toàn là bàn chưa đặt
            }
        }

        public void themBnVaoKhuVuc(uCtr_BanDat ban)
        {
            this.Controls.Add(ban);
        }

        private void uCtr_KhuVuc_SizeChanged(object sender, EventArgs e)
        {
            this.lblTenKhuVuc.Width = this.Width;
        }

    }
}
