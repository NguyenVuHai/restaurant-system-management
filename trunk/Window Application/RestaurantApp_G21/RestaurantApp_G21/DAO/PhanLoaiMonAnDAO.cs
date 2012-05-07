using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;
using System.Collections;
using RestaurantApp_G21.DTO;
namespace RestaurantApp_G21.DAO
{
    class PhanLoaiMonAnDAO
    {
        public static ArrayList layDanhSachMonAnTheoPhanLoaiMonAn(LoaiMonAnDTO loaiMonAn, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachMonAnTheoPhanLoaiMonAn";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@MaLoaiMonAn";
            param.Value = loaiMonAn.MaLoaiMonAn;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhanLoaiMonAnDTO plMA = new PhanLoaiMonAnDTO();
                    plMA.LoaiMonAn.MaLoaiMonAn = Convert.ToInt32(dt.Rows[i]["MaLoaiMonAn"]);
                    plMA.MonAn.MaMonAn = Convert.ToInt32(dt.Rows[i]["MaMonAn"]);
                    plMA.MonAn.TenMonAn = dt.Rows[i]["TenMonAn"].ToString();
                    plMA.NhaHang.MaNhaHang = maNhaHang;
                    list.Add(plMA);
                }
            }
            return list;
        }
    }
}
