using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;
using System.Collections;

namespace RestaurantApp_G21.DAO
{
    class LoaiMonAnDAO
    {
        public static ArrayList layDanhSachLoaiMonAn()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachLoaiMonAn";

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoaiMonAnDTO r = new LoaiMonAnDTO();
                    r.MaLoaiMonAn = Int32.Parse(dt.Rows[i]["MaLoaiMonAn"].ToString());
                    r.TenLoaiMonAn = dt.Rows[i]["TenLoaiMonAn"].ToString();

                    list.Add(r);
                }
            }
            return list;
        }
    }
}
