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
    class NhaCungCapDAO
    {
        public static ArrayList layDanhSachNguyenLieuNhaCungCapCoTheDapUngTheoDonDatHang(int maNhaCungCap, string sqlWHEREor)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.layDanhSachNguyenLieuNhaCungCapCoTheDapUngTheoDonDatHang";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@maNhaCungCap";
            param.Value = maNhaCungCap;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@sqlWHEREor";
            param.Value = sqlWHEREor;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NguyenLieuDTO dto = new NguyenLieuDTO();
                    dto.MaNguyenLieu = Convert.ToInt32(dt.Rows[i]["MaNguyenLieu"]);
                    dto.TenNguyenLieu = dt.Rows[i]["TenNguyenLieu"].ToString();
                    list.Add(dto);
                }
            }
            return list;
        }
    }
}
