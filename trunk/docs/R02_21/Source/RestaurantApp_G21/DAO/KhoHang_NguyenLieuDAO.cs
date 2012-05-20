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
        public static int capNhatChiTietKhoHangNguyenLieuT2(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.lostUpdateUpdateChiTietKhoHangNguyenLieuT2";
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
        //LOST UPDATED
        public static int lostUpdatedXuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            DbParameter param = command.CreateParameter();
            command.CommandText = "dbo.lostUpdatedXuatNguyenLieu";
            //// create a new parameter
            param.ParameterName = "@soLuongXuat";
            param.Value = dto.SoLuongXuat;
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
        //LOST UPDATED SOLVED
        public static int lostUpdatedSolvedXuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang, int mucCoLap)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            DbParameter param = command.CreateParameter();
            command.CommandText = "dbo.lostUpdatedSolvedXuatNguyenLieu";
            //// create a new parameter
            param.ParameterName = "@soLuongXuat";
            param.Value = dto.SoLuongXuat;
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
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@mucCoLap";
            param.Value = mucCoLap;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            return DataAccessCode.ExecuteNonQuery(command);
        }
        //DEADLOCK
        public static int deadlockXuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            DbParameter param = command.CreateParameter();
            command.CommandText = "dbo.deadlockXuatNguyenLieu";
            //// create a new parameter
            param.ParameterName = "@soLuongXuat";
            param.Value = dto.SoLuongXuat;
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
        //DEADLOCK SOLVED
        public static int deadlockSolvedXuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            DbParameter param = command.CreateParameter();
            command.CommandText = "dbo.deadlockSolvedXuatNguyenLieu";
            //// create a new parameter
            param.ParameterName = "@soLuongXuat";
            param.Value = dto.SoLuongXuat;
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
        public static int xuatNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            DbParameter param = command.CreateParameter();
            command.CommandText = "dbo.xuatNguyenLieu";
            //// create a new parameter
            param.ParameterName = "@soLuongXuat";
            param.Value = dto.SoLuongXuat;
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
        public static int capNhatChiTietKhoHangNguyenLieu(KhoHang_NguyenLieuDTO dto, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            DbParameter param = command.CreateParameter();
            command.CommandText = "dbo.updateChiTietKhoHangNguyenLieu";
            //// create a new parameter
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
