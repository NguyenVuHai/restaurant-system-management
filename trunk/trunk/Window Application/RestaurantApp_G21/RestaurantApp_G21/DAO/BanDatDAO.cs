﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class BanDatDAO
    {
        public static List<BanDatDTO> LayDanhSachBanDat()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachBanDat";

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<BanDatDTO> list = new List<BanDatDTO>();
            if (dt != null)
            {
                int maThongTinKhachHang;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BanDatDTO banDat = new BanDatDTO();
                    banDat.MaLichBan = Int32.Parse(dt.Rows[i]["MaLichBan"].ToString());
                    banDat.MaBan = Int32.Parse(dt.Rows[i]["MaBan"].ToString());
                    banDat.NgayDatBan = DateTime.Parse(dt.Rows[i]["NgayDatBan"].ToString());
                    banDat.MaBuoi = Int32.Parse(dt.Rows[i]["MaBuoi"].ToString());
                    if (Int32.TryParse(dt.Rows[i]["MaThongTinKhachHang"].ToString(), out maThongTinKhachHang))
                    {
                        banDat.MaThongTinKhachHang = maThongTinKhachHang;
                    }
                    banDat.SoLuong = Int32.Parse(dt.Rows[i]["SoLuong"].ToString());
                    banDat.TinhTrangBan = Boolean.Parse(dt.Rows[i]["TinhTrangBan"].ToString());

                    list.Add(banDat);
                }
            }
            return list;
        }

        public static void ThemThongTinBanDat(BanDatDTO banDat, int loai)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThemThongTinBanDat";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@Loai";
            param.Value = loai;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@HoTen";
            param.Value = banDat.HoTen;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@CMND";
            param.Value = banDat.Cmnd;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DienThoai";
            param.Value = banDat.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaBan";
            param.Value = banDat.MaBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@NgayDatBan";
            param.Value = banDat.NgayDatBan;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Buoi";
            param.Value = banDat.MaBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@SoLuong";
            param.Value = banDat.SoLuong;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@TinhTrangBan";
            param.Value = banDat.TinhTrangBan;
            param.DbType = DbType.Boolean;
            command.Parameters.Add(param);
            DataAccessCode.ExecuteNonQuery(command);
        }
    }
}