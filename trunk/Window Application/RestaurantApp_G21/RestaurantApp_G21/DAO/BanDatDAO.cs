using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;

namespace RestaurantApp_G21.DAO
{
    class BanDatDAO
    {
        public static void ThemThongTinBanDat(BanDatDTO banDat, int loai)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThemThongTinBanDat";
            //// create a new parameter
            //DbParameter param = command.CreateParameter();
            //param.ParameterName = "@MaNhaHang";
            //if (maNhaHang == 0)
            //    param.Value = DBNull.Value;
            //else param.Value = maNhaHang;
            //param.DbType = DbType.Int32;
            //command.Parameters.Add(param);
            //// create a new parameter
            //param = command.CreateParameter();
            //param.ParameterName = "@MaKhuVuc";
            //if (maKhuVuc == 0)
            //    param.Value = DBNull.Value;
            //else param.Value = maKhuVuc;
            //param.DbType = DbType.Int32;
            //command.Parameters.Add(param);
            //// create a new parameter
            //param = command.CreateParameter();
            //param.ParameterName = "@NgayDatBan";
            //param.DbType = DbType.DateTime;
            //if (ngayDatBan == new DateTime())
            //    param.Value = DBNull.Value;
            //else param.Value = ngayDatBan;
            //command.Parameters.Add(param);
            //// create a new parameter
            //param = command.CreateParameter();
            //param.ParameterName = "@Buoi";
            //if (buoi == 0)
            //    param.Value = DBNull.Value;
            //else param.Value = buoi;
            //param.DbType = DbType.Int32;
            //command.Parameters.Add(param);
            //// create a new parameter
            //param = command.CreateParameter();
            //param.ParameterName = "@SoLuong";
            //if (soLuong == 0)
            //    param.Value = DBNull.Value;
            //else param.Value = soLuong;
            //param.DbType = DbType.Int32;
            //command.Parameters.Add(param);
            DataAccessCode.ExecuteNonQuery(command);
            
        }
    }
}
