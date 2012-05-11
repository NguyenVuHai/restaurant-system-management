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
        public static int setNgungGiaoDich(int maNhaCungCap, int maNhaHang,int tinhTrang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
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
