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
        //PHANTOM
        public static int phantomThemMoi(NhaCungCapDTO dto)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThemNhaCungCap";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@tenNhaCungCap";
            param.Value = dto.TenNhaCungCap;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@dienThoai";
            param.Value = dto.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@soTaiKhoan";
            param.Value = dto.SoTaiKhoan;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            return DataAccessCode.ExecuteNonQuery(command);
        }
        //PHANTOM SOLVED
        public static int phantomSolvedThemMoi(NhaCungCapDTO dto)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.PhanTomT2ThemNhaCungCap";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@tenNhaCungCap";
            param.Value = dto.TenNhaCungCap;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@dienThoai";
            param.Value = dto.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@soTaiKhoan";
            param.Value = dto.SoTaiKhoan;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            return DataAccessCode.ExecuteNonQuery(command);
        }
        public static int themMoi(NhaCungCapDTO dto)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThemNhaCungCap";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@tenNhaCungCap";
            param.Value = dto.TenNhaCungCap;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@dienThoai";
            param.Value = dto.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@soTaiKhoan";
            param.Value = dto.SoTaiKhoan;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            return DataAccessCode.ExecuteNonQuery(command);
        }
        //DIRTY READ
        public static int dirtyReadSetNgungGiaoDich(int maNhaCungCap, int maNhaHang, int tinhTrang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            //command.CommandText = "dbo.setNgungGiaoDich";
            command.CommandText = "dbo.DirtyReadT2SetNgungGiaoDich";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@maNhaCungCap";
            param.Value = maNhaCungCap;
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
            param.ParameterName = "@tinhTrang";
            param.Value = tinhTrang;
            param.DbType = DbType.Int16;
            command.Parameters.Add(param);
            //create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@isRollback";
            param.Direction = ParameterDirection.Output;
            param.Value = 0;
            param.DbType = DbType.Int16;
            command.Parameters.Add(param);
            
            return DataAccessCode.ExecuteNonQueryReturnIsRollBackOutputValue(command);
        }
        //DIRTY READ SOLVED
        public static int dirtyReadSolvedSetNgungGiaoDich(int maNhaCungCap, int maNhaHang, int tinhTrang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            //command.CommandText = "dbo.setNgungGiaoDich";
            command.CommandText = "dbo.DirtyReadSolvedT2SetNgungGiaoDich";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@maNhaCungCap";
            param.Value = maNhaCungCap;
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
            param.ParameterName = "@tinhTrang";
            param.Value = tinhTrang;
            param.DbType = DbType.Int16;
            command.Parameters.Add(param);
            //create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@isRollback";
            param.Direction = ParameterDirection.Output;
            param.Value = 0;
            param.DbType = DbType.Int16;
            command.Parameters.Add(param);

            return DataAccessCode.ExecuteNonQueryReturnIsRollBackOutputValue(command);
        }
        public static int setNgungGiaoDich(int maNhaCungCap, int maNhaHang,int tinhTrang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            //command.CommandText = "dbo.setNgungGiaoDich";
            command.CommandText = "dbo.setNgungGiaoDich";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@maNhaCungCap";
            param.Value = maNhaCungCap;
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
            param.ParameterName = "@tinhTrang";
            param.Value = tinhTrang;
            param.DbType = DbType.Int16;
            command.Parameters.Add(param);

            

            return DataAccessCode.ExecuteNonQuery(command);
        }
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
                    dto.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                    dto.DonGia = Convert.ToDecimal(dt.Rows[i]["DonGia"]);
                    
                    list.Add(dto);
                }
            }
            return list;
        }
    }
}
