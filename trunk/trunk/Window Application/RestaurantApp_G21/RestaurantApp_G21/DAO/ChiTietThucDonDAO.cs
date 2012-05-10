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

        public static List<ChiTietThucDonDTO> LayDanhSachMonAnTrongHoaDon(Guid maHoaDon, bool isPhantom, bool isDirtyRead, bool isUnrepeatableRead, bool isLostUpdate)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            bool isSecond = false;
            if (GlobalVariables.bMacDinh || isLostUpdate)
            {
                command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDon";
            }
            else
            {
                if (isPhantom)
                {
                    isSecond = true;
                    if (GlobalVariables.bBongMa)
                        command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonPhantom";

                    else
                        command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonSolvePhantom";
                }
                else if (isDirtyRead)
                {
                    if (GlobalVariables.bDuLieuRac)
                        command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonDirtyRead";
                    else
                        command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonSolveDirtyRead";
                }
                else if (isUnrepeatableRead)
                {
                    isSecond = true;
                    if (GlobalVariables.bKhongTheDocLai)
                        command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonUnRepeatableRead";
                    else
                        command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonSolveUnRepeatableRead";
                }
                else if (isLostUpdate)
                {
                    if (GlobalVariables.bLostUpdate)
                        command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonLostUpdate";
                    else
                        command.CommandText = "dbo.LayDanhSachMonAnTrongHoaDonSolveLostUpdate";
                }
            }
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaHoaDon";
            param.Value = maHoaDon.ToString();
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            DataTable dt;
            if (isSecond)
            {
                dt = DataAccessCode.ExecuteSecondSelectCommand(command);
            }
            else dt = DataAccessCode.ExecuteSelectCommand(command);

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
                    chiTietThucDon.ThanhTien = chiTietThucDon.SoLuong * chiTietThucDon.DonGia;
                    list.Add(chiTietThucDon);
                }
            }
            return list;
        }
    }
}
