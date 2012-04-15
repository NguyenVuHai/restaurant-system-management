using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21
{
    public partial class frmKhoHang : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmKhoHang()
        {
            InitializeComponent();
          //  frmKhoHang frm = new frmKhoHang();
            GUI.KhoHang.NhaCungCap.uc_traCuuNCC uc = new GUI.KhoHang.NhaCungCap.uc_traCuuNCC();
            m_sTabItmTTBanDat.AttachedControl.Controls.Add(uc);
        }

        
    }
}