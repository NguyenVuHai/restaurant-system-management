using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Controls.Shared
{
    public partial class TraCuuBanTrong : System.Web.UI.UserControl
    {

        private void LoadTables()
        {
            DataTable dt = TableAccess.GetTables();
            lvTables.DataSource = dt;
            lvTables.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTables();
        }
    }
}