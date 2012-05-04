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
    }
}
