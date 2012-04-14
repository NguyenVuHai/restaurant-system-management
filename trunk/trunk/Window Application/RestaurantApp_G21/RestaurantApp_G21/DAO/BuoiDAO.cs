using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.DAO
{
    class BuoiDAO
    {
        public static List<BuoiDTO> LayDanhSachBuoi()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachBuoi";
            
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<BuoiDTO> list = new List<BuoiDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BuoiDTO buoi = new BuoiDTO();
                    buoi.MaBuoi = Int32.Parse(dt.Rows[i]["MaBuoi"].ToString());
                    buoi.TenBuoi = dt.Rows[i]["TenBuoi"].ToString();

                    list.Add(buoi);
                }
            }
            return list;
        }
    }
}
