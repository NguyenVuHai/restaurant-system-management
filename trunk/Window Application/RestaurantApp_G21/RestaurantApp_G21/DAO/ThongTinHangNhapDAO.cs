using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;
namespace RestaurantApp_G21.DAO
{
    class ThongTinHangNhapDAO
    {
        public static int layMaThongTinHangNhap(DateTime ngayGioNhap,int maKhoHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.layIDThongTinHangNhap";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@ngayGioNhap";
            param.Value = ngayGioNhap;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            
            param = command.CreateParameter();
            param.ParameterName = "@maKhoHang";
            param.Value = maKhoHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);


            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            int id=-1;
            if (dt != null)
            {
                id = Convert.ToInt32(dt.Rows[0]["MaThongTinHangNhap"]);
            }
            return id;
        }
        public static int themThongTinHangNhap(ThongTinHangNhapDTO ttNhap)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            command.CommandText = "dbo.themThongTinHangNhap";
            param.ParameterName = "@ngayNhap";
            param.Value = ttNhap.NgayNhap;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@maKhoHang";
            param.Value = ttNhap.KhoHang.MaKhoHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            
            int kq = DataAccessCode.ExecuteNonQuery(command);
            if (kq == 1)
            {
                for (int i = 0; i < ttNhap.ChiTietHangNhap.Count; i++)
                {
                    ((ChiTietHangNhapDTO)ttNhap.ChiTietHangNhap[i]).MaThongTinHangNhap = layMaThongTinHangNhap(ttNhap.NgayNhap,ttNhap.KhoHang.MaKhoHang);
                    
                    themChiTietHangNhap((ChiTietHangNhapDTO)ttNhap.ChiTietHangNhap[i]);
                }
            }
            return 1;
        }

        public static int themChiTietHangNhap(ChiTietHangNhapDTO chiTiet)
        {
            DbCommand command = DataAccessCode.CreateCommand();

            //// create a new parameter
            DbParameter param = command.CreateParameter();
            command.CommandText = "dbo.themChiTietHangNhap";
            param.ParameterName = "@maNguyenLieu";
            param.Value = chiTiet.NguyenLieu.MaNguyenLieu;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@maNhaCungCap";
            param.Value = chiTiet.NhaCungCap.MaNhaCungCap;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@donGia";
            param.Value = chiTiet.DonGia;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@soLuong";
            param.Value = chiTiet.SoLuong;
            param.DbType = DbType.Decimal;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@maThongTinHangNhap";
            param.Value = chiTiet.MaThongTinHangNhap;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            return DataAccessCode.ExecuteNonQuery(command);
        }
    }
}
