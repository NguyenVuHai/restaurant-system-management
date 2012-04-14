using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class ThongTinBanDAO
    {
        public static List<ThongTinBanDTO> LayDanhSachThongTinBan(int maKhuVuc)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachThongTinBan";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaKhuVuc";
            if (maKhuVuc == 0)
                param.Value = DBNull.Value;
            else param.Value = maKhuVuc;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<ThongTinBanDTO> list = new List<ThongTinBanDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinBanDTO thongTinBan = new ThongTinBanDTO();
                    thongTinBan.MaBan = Int32.Parse(dt.Rows[i]["MaBan"].ToString());
                    thongTinBan.MaKhuVuc = Int32.Parse(dt.Rows[i]["MaKhuVuc"].ToString());
                    thongTinBan.TenBan = dt.Rows[i]["TenBan"].ToString();
                    thongTinBan.SucChua = Int32.Parse(dt.Rows[i]["SucChua"].ToString());
                    list.Add(thongTinBan);
                }
            }
            return list;
        }


        public static List<ThongTinBanDTO> TimBanTrong(int maNhaHang, int maKhuVuc, DateTime ngayDatBan, string buoi, int soLuong)
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
            param.DbType = DbType.DateTime;
            if (ngayDatBan == new DateTime())
                param.Value = DBNull.Value;
            else param.Value = ngayDatBan;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Buoi";
            if (buoi == String.Empty)
                param.Value = DBNull.Value;
            else param.Value = buoi;
            param.DbType = DbType.Int32;
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
            List<ThongTinBanDTO> list = new List<ThongTinBanDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinBanDTO thongTinBan = new ThongTinBanDTO();
                    thongTinBan.MaBan = Int32.Parse(dt.Rows[i]["MaBan"].ToString());
                    thongTinBan.SucChua = Int32.Parse(dt.Rows[i]["SucChua"].ToString());
                    thongTinBan.MaNhaHang = Int32.Parse(dt.Rows[i]["MaNhaHang"].ToString());
                    thongTinBan.GiaBan = Decimal.Parse(dt.Rows[i]["GiaBan"].ToString());
                    list.Add(thongTinBan);
                }
            }
            return list;
        }
    }
}
