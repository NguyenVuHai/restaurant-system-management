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
    class KhoHang_NguyenLieuDAO
    {
        public static int capNhatChiTietKhoHangNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.updateChiTietKhoHangNguyenLieu";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@soLuongTon";
            param.Value = dto.SoLuongTon;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@chuaToiDa";
            param.Value = dto.SucChua;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@chuaToiThieu";
            param.Value = dto.MucTonToiThieu;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@maNguyenLieu";
            param.Value = dto.NguyenLieu.MaNguyenLieu;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@maNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            
            return DataAccessCode.ExecuteNonQuery(command);
        }
        public static int capNhatChiTietKhoHangNguyenLieuT2(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.updateChiTietKhoHangNguyenLieuT2";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@soLuongTon";
            param.Value = dto.SoLuongTon;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@chuaToiDa";
            param.Value = dto.SucChua;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@chuaToiThieu";
            param.Value = dto.MucTonToiThieu;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@maNguyenLieu";
            param.Value = dto.NguyenLieu.MaNguyenLieu;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@maNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            return DataAccessCode.ExecuteNonQuery(command);
        }
    }
}
