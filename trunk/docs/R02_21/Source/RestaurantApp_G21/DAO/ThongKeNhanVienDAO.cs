using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;


namespace RestaurantApp_G21.DAO
{
    class ThongKeNhanVienDAO
    {
        internal static int TinhTongNhanVien(int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.TinhTongNhanVien";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            return DataAccessCode.ExecuteNonQuery(command);
        }
    }
}
