using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data;
using System.Data.Common;


namespace RestaurantApp_G21.DAO
{
    class ThongTinNhanVienCNDAO
    {
        public static DataTable TTNhanVien()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayNhanVien";
            return DataAccessCode.ExecuteSelectCommand(command);
        }
        public static DataTable LayThongTinNhanVien(/*int maNhaHang*/)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachNhanVien";

            //DbParameter para = command.CreateParameter();
            //para.ParameterName = "@maNhaHang";
            //para.Value = maNhaHang;
            //para.DbType = DbType.Int32;
            //command.Parameters.Add(para);

            //para = command.CreateParameter();
            //para.ParameterName = "@maLoaiNhanVien";
            //para.Value = maLoaiNhanVien;
            //para.DbType = DbType.Int32;
            //command.Parameters.Add(para);
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            return dt;
        }
    }
}
