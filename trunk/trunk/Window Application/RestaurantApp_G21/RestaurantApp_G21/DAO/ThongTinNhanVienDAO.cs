using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class ThongTinNhanVienDAO
    {
        public static List<ThongTinNhanVienDTO> TimKiemNhanVien(int maNhanVien, int maNhaHang, int maLoaiNhanVien, string ho, string ten, string cmnd, string diaChi, string dienThoai, DateTime ngayVaoLam)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.TimKiemNhanVien";
            // create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhanVien";
            if (maNhanVien == 0)
                param.Value = DBNull.Value;
            else param.Value = maNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            if (maNhaHang == 0)
                param.Value = DBNull.Value;
            else param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaLoaiNhanVien";
            if (maLoaiNhanVien == 0)
                param.Value = DBNull.Value;
            else param.Value = maLoaiNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Ho";
            if (ho == "")
                param.Value = DBNull.Value;
            else param.Value = ho;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Ten";
            if (ten == "")
                param.Value = DBNull.Value;
            else param.Value = ten;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@CMND";
            if (cmnd == "")
                param.Value = DBNull.Value;
            else param.Value = cmnd;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DiaChi";
            if (diaChi == "")
                param.Value = DBNull.Value;
            else param.Value = diaChi;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DienThoai";
            if (dienThoai == "")
                param.Value = DBNull.Value;
            else param.Value = dienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@NgayVaoLam";
            param.DbType = DbType.DateTime;
            if (ngayVaoLam == new DateTime())
                param.Value = DBNull.Value;
            else param.Value = ngayVaoLam;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<ThongTinNhanVienDTO> list = new List<ThongTinNhanVienDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinNhanVienDTO thongTinNhanVien = new ThongTinNhanVienDTO();
                    thongTinNhanVien.MaNhanVien = Int32.Parse(dt.Rows[i]["MaNhanVien"].ToString());
                    thongTinNhanVien.MaNhaHang = Int32.Parse(dt.Rows[i]["MaNhaHang"].ToString());
                    thongTinNhanVien.MaLoaiNhanVien = Int32.Parse(dt.Rows[i]["MaLoaiNhanVien"].ToString());
                    thongTinNhanVien.Ho = dt.Rows[i]["Ho"].ToString();
                    thongTinNhanVien.Ten = dt.Rows[i]["Ten"].ToString();
                    thongTinNhanVien.CMND = dt.Rows[i]["CMND"].ToString();
                    thongTinNhanVien.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    thongTinNhanVien.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    thongTinNhanVien.NgayVaoLam = DateTime.Parse(dt.Rows[i]["NgayVaoLam"].ToString());
                    list.Add(thongTinNhanVien);
                }
            }
            return list;
        }

        internal static void ThemNhanVien(ThongTinNhanVienDTO nv)
        {
            
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThemNhanVien";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            /*param.ParameterName = "@MaNhanVien";
            param.Value = nv.MaNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);*/
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Ho";
            param.Value = nv.Ho;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Ten";
            param.Value = nv.Ten;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DienThoai";
            param.Value = nv.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DiaChi";
            param.Value = nv.DiaChi;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaLoaiNhanVien";
            param.Value = nv.MaLoaiNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            param.Value = nv.MaNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@CMND";
            param.Value = nv.CMND;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@NgayVaoLam";
            param.Value = nv.NgayVaoLam;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@TinhTrang";
            param.Value = nv.TinhTrang;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            DataAccessCode.ExecuteNonQuery(command);
            //return maNV;
        }



        internal static List<ThongTinNhanVienDTO> LoadDanhSachNhanVien()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachNhanVienFull";
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<ThongTinNhanVienDTO> list = new List<ThongTinNhanVienDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinNhanVienDTO thongTinNhanVien = new ThongTinNhanVienDTO();
                    thongTinNhanVien.MaNhanVien = Int32.Parse(dt.Rows[i]["MaNhanVien"].ToString());
                    thongTinNhanVien.MaNhaHang = Int32.Parse(dt.Rows[i]["MaNhaHang"].ToString());
                    thongTinNhanVien.MaLoaiNhanVien = Int32.Parse(dt.Rows[i]["MaLoaiNhanVien"].ToString());
                    thongTinNhanVien.Ho = dt.Rows[i]["Ho"].ToString();
                    thongTinNhanVien.Ten = dt.Rows[i]["Ten"].ToString();
                    thongTinNhanVien.CMND = dt.Rows[i]["CMND"].ToString();
                    thongTinNhanVien.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    thongTinNhanVien.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    thongTinNhanVien.NgayVaoLam = DateTime.Parse(dt.Rows[i]["NgayVaoLam"].ToString());
                    list.Add(thongTinNhanVien);
                }
            }
            return list;
        }
    }
}
