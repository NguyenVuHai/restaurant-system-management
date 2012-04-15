using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class NhaHangDAO
    {
        public static List<NhaHangDTO> LayDanhSachNhaHang()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachNhaHang";
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<NhaHangDTO> list = new List<NhaHangDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    int maNhaHang = Int32.Parse(dt.Rows[i]["MaNhaHang"].ToString());
                    string tenNhaHang = dt.Rows[i]["TenNhaHang"].ToString();
                    string diaChi = dt.Rows[i]["DiaChi"].ToString();
                    string dienThoai = dt.Rows[i]["DienThoai"].ToString();
                    NhaHangDTO nhaHang = new NhaHangDTO(maNhaHang, tenNhaHang, diaChi, dienThoai);
                    list.Add(nhaHang);
                }
            }
            return list;
        }
    }
}
