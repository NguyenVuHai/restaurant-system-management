using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21
{
    public partial class frmDirtyReadNhanVien : Form
    {
        public bool isDirtyRead = false;
        public frmDirtyReadNhanVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestaurantConfiguration.command = DataAccessCode.CreateCommand();
            RestaurantConfiguration.command.CommandText = "dbo.T2";
            //DataAccessCode.ExecuteNonQuery();
            //command = DataAccessCode.CreateCommand();
            //command.CommandText = "dbo.T2";
            //DataAccessCode.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantConfiguration.command = DataAccessCode.CreateCommand();
            if (isDirtyRead)
            {
                RestaurantConfiguration.command.CommandText = "dbo.T1DirtyRead";
            }
            else
            {
                RestaurantConfiguration.command.CommandText = "dbo.T1ResolvedDirtyRead";
            }

            DataTable dt = DataAccessCode.ExecuteSelectCommand(RestaurantConfiguration.command);
            List<ThongTinNhanVienDTO> list = new List<ThongTinNhanVienDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinNhanVienDTO thongTinNhanVien = new ThongTinNhanVienDTO();
                    thongTinNhanVien.MaNhanVien = Int32.Parse(dt.Rows[i]["MaNhanVien"].ToString());
                    //thongTinNhanVien.MaNhaHang = Int32.Parse(dt.Rows[i]["MaNhaHang"].ToString());
                    list.Add(thongTinNhanVien);
                }
            }
            dgvData.DataSource = list;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isDirtyRead = checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestaurantConfiguration.command.Connection.Close();
        }
    }
}
