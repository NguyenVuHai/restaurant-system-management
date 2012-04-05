using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Common;

namespace RestaurantApp_G21
{
    public partial class frmTimBan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmTimBan()
        {
            InitializeComponent();
        }

        private void m_btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void m_btnTimBan_Click(object sender, EventArgs e)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "SP_GETTABLES";
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            dgvDanhSachBan.DataSource = dt;
        }

    }
}