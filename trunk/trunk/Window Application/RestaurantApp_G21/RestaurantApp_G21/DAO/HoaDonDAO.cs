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
        public static Guid ThemHoaDon(int maLichBan, DateTime ngayLapHoaDon)
        {
            Guid maHoaDon = Guid.NewGuid();
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThemHoaDon";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaHoaDon";
            param.Value = maHoaDon.ToString();
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
            return maHoaDon;
        }

        public static string KiemTraHoaDon(int maLichBan)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.KiemTraHoaDon";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            string flag = DataAccessCode.ExecuteScalar(command);
            return flag;
        }

        public static void ThemMonAn(Guid maHoaDon, int maChiTietThucDon, decimal donGia, int soLuong, bool isPhantom, bool isDirtyRead)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            if (isPhantom)
                command.CommandText = "dbo.ThemMonAnPhantom";
            else if (isDirtyRead)
                command.CommandText = "dbo.ThemMonAnDirtyRead";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaHoaDon";
            param.Value = maHoaDon.ToString();
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaChiTietThucDon";
            param.Value = maChiTietThucDon;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DonGia";
            param.Value = donGia;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@SoLuong";
            param.Value = soLuong;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            DataAccessCode.ExecuteNonQuery(command);
        }
    }
}
