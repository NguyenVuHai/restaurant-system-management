using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class ChiTietThucDonDAO
    {
        public static List<ChiTietThucDonDTO> LayDanhSachMonAnTheoNhaHang(int maNhaHang, DateTime ngay)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachMonAnTheoNhaHang";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@Ngay";
            param.Value = ngay;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<ChiTietThucDonDTO> list = new List<ChiTietThucDonDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChiTietThucDonDTO chiTietThucDon = new ChiTietThucDonDTO();
                    chiTietThucDon.MaChiTietThucDon = Int32.Parse(dt.Rows[i]["MaChiTietThucDon"].ToString());
                    chiTietThucDon.MaMonAn = Int32.Parse(dt.Rows[i]["MaMonAn"].ToString());
                    chiTietThucDon.TenMonAn = dt.Rows[i]["TenMonAn"].ToString();
                    chiTietThucDon.DonGia = Decimal.Parse(dt.Rows[i]["DonGia"].ToString());
                    list.Add(chiTietThucDon);
                }
            }
            return list;
        }

        public static List<ChiTietThucDonDTO> LayDanhSachMonAnTrongHoaDon(Guid maHoaDon, bool isPhantom, bool isDirtyRead)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            if (isPhantom)
            {
                if (GlobalVariables.bBongMa)
                    command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonPhantom";
                else
                    command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonSolvePhantom";
            }
            else
            {
                if (GlobalVariables.bDuLieuRac)
                    command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonDirtyRead";
                else
                    command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonSolveDirtyRead";
            }
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaHoaDon";
            param.Value = maHoaDon.ToString();
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<ChiTietThucDonDTO> list = new List<ChiTietThucDonDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChiTietThucDonDTO chiTietThucDon = new ChiTietThucDonDTO();
                    chiTietThucDon.MaChiTietThucDon = Int32.Parse(dt.Rows[i]["MaChiTietThucDon"].ToString());
                    chiTietThucDon.MaMonAn = Int32.Parse(dt.Rows[i]["MaMonAn"].ToString());
                    chiTietThucDon.TenMonAn = dt.Rows[i]["TenMonAn"].ToString();
                    chiTietThucDon.DonGia = Decimal.Parse(dt.Rows[i]["DonGia"].ToString());
                    chiTietThucDon.SoLuong = Int32.Parse(dt.Rows[i]["SoLuong"].ToString());
                    chiTietThucDon.MaChiTietHoaDon = Int32.Parse(dt.Rows[i]["MaChiTietHoaDon"].ToString());
                    list.Add(chiTietThucDon);
                }
            }
            return list;
        }
    }
}
