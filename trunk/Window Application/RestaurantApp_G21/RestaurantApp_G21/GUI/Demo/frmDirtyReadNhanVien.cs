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
        public frmDirtyReadNhanVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.T2";
            DataAccessCode.ExecuteNonQuery(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.T1";
            
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
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
    }
}
