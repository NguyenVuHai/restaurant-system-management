using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class HoaDonDAO
    {
        public static void ThemHoaDon(int maLichBan, DateTime ngayLapHoaDon)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThemHoaDon";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaHoaDon";
            param.Value = Guid.NewGuid().ToString();
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@NgayLapHoaDon";
            param.Value = ngayLapHoaDon;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            DataAccessCode.ExecuteNonQuery(command);
        }

        public static bool KiemTraHoaDon(int maLichBan)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.KiemTraHoaDon";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            bool flag = DataAccessCode.ExecuteScalar(command) == "1" ? true : false;
            return flag;
        }
    }
}
