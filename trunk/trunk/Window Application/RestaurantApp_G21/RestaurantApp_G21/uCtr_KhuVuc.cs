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
    public partial class uCtr_KhuVuc : FlowLayoutPanel // kế thừa
    {
        private Label lblTenKhuVuc = new Label();
        private frmDatBan parentForm = null;
        private string maKV;

        public string MaKV
        {
            get { return maKV; }
            set { maKV = value; }
        }

        public uCtr_KhuVuc(frmDatBan parent, string maKhuVuc, int soBan)// hàm dựng, tên khu vực và số bàn
        {
            InitializeComponent();
            
            this.lblTenKhuVuc.Text = maKhuVuc;
            this.maKV = maKhuVuc;
            this.Controls.Add(lblTenKhuVuc);
            this.parentForm = parent;
            for (int i = 0; i < soBan; i++)
            { 
                themBnVaoKhuVuc(new uCtr_BanChuaDat(this,false,"BAN_"+i)); // Truyền false vì cái khuvuc mới tạo sẽ toàn là bàn chưa đặt
            }
        }

        public frmDatBan getParent()
        {
            return this.parentForm;
        }
        public void themBnVaoKhuVuc(uCtr_BanChuaDat ban)
        {
            this.Controls.Add(ban);
        }

        private void uCtr_KhuVuc_SizeChanged(object sender, EventArgs e)
        {
            this.lblTenKhuVuc.Width = this.Width;
        }

    }
}
