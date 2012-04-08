using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class KhuVucDAO
    {
        public static List<KhuVucDTO> LayDanhSachKhuVuc(int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachKhuVuc";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            if (maNhaHang == 0)
                param.Value = DBNull.Value;
            else param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<KhuVucDTO> list = new List<KhuVucDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhuVucDTO khuVuc = new KhuVucDTO();
                    khuVuc.MaKhuVuc = Int32.Parse(dt.Rows[i]["MaKhuVuc"].ToString());
                    khuVuc.TenKhuVuc = dt.Rows[i]["TenKhuVuc"].ToString();
                    khuVuc.GiaBan = Decimal.Parse(dt.Rows[i]["GiaBan"].ToString());
                    list.Add(khuVuc);
                }
            }
            return list;
        }

        public static List<KhuVucDTO> TimBanTrong(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, string buoi, int soLuong)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.TimBanTrong";
            // create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            if (maNhaHang == 0)
                param.Value = DBNull.Value;
            else param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaKhuVuc";
            if (maKhuVuc == 0)
                param.Value = DBNull.Value;
            else param.Value = maKhuVuc;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@NgayDatBan";
            if (ngayDatBan == new DateTime())
                param.Value = DBNull.Value;
            else param.Value = ngayDatBan;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Buoi";
            if (buoi == String.Empty)
                param.Value = DBNull.Value;
            else param.Value = buoi;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@SoLuong";
            if (soLuong == 0)
                param.Value = DBNull.Value;
            else param.Value = soLuong;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<KhuVucDTO> list = new List<KhuVucDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhuVucDTO khuVuc = new KhuVucDTO();
                    khuVuc.MaKhuVuc = Int32.Parse(dt.Rows[i]["MaKhuVuc"].ToString());
                    khuVuc.TenKhuVuc = dt.Rows[i]["TenKhuVuc"].ToString();
                    khuVuc.MaNhaHang = Int32.Parse(dt.Rows[i]["MaNhaHang"].ToString());
                    khuVuc.GiaBan = Decimal.Parse(dt.Rows[i]["GiaBan"].ToString());
                    list.Add(khuVuc);
                }
            }
            return list;
        }
    }
}
