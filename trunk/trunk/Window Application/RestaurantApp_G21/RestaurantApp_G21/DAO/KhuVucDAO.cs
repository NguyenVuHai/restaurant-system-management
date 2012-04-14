using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class KhuVucDAO
    {
        public static List<KhuVucDTO> LayDanhSachKhuVuc(int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachKhuVuc";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            if (maNhaHang == 0)
                param.Value = DBNull.Value;
            else param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<KhuVucDTO> list = new List<KhuVucDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhuVucDTO khuVuc = new KhuVucDTO();
                    khuVuc.MaKhuVuc = Int32.Parse(dt.Rows[i]["MaKhuVuc"].ToString());
                    khuVuc.TenKhuVuc = dt.Rows[i]["TenKhuVuc"].ToString();
                    khuVuc.GiaBan = Decimal.Parse(dt.Rows[i]["GiaBan"].ToString());
                    list.Add(khuVuc);
                }
            }
            return list;
        }

    }
}
