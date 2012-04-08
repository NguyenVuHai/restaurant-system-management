using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class ThongTinBanDAO
    {
        public static List<ThongTinBanDTO> LayDanhSachThongTinBan(int maKhuVuc)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachThongTinBan";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaKhuVuc";
            if (maKhuVuc == 0)
                param.Value = DBNull.Value;
            else param.Value = maKhuVuc;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<ThongTinBanDTO> list = new List<ThongTinBanDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinBanDTO thongTinBan = new ThongTinBanDTO();
                    thongTinBan.MaBan = Int32.Parse(dt.Rows[i]["MaBan"].ToString());
                    thongTinBan.MaKhuVuc = Int32.Parse(dt.Rows[i]["MaKhuVuc"].ToString());
                    thongTinBan.TenBan = dt.Rows[i]["TenBan"].ToString();
                    thongTinBan.SucChua = Int32.Parse(dt.Rows[i]["SucChua"].ToString());
                    list.Add(thongTinBan);
                }
            }
            return list;
        }
    }
}
