using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class LoaiNhanVienCNDAO
    {

        public static List<LoaiNhanVienCNDTO> LayLoaiNhanVien()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayLoaiNhanVien";

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<LoaiNhanVienCNDTO> list = new List<LoaiNhanVienCNDTO>();

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //LoaiNhanVienDTO loaiNV = new LoaiNhanVienDTO();
                    int maLoaiNhanVien = Int32.Parse(dt.Rows[i]["MaLoaiNhanVien"].ToString());
                    string tenLoaiNhanVien = dt.Rows[i]["TenLoaiNhanVien"].ToString();
                    double luong = Int32.Parse(dt.Rows[i]["Luong"].ToString());
                    LoaiNhanVienCNDTO loaiNV = new LoaiNhanVienCNDTO(maLoaiNhanVien, tenLoaiNhanVien, luong);
                    list.Add(loaiNV);
                    //NhaHangDTO nhaHang = new NhaHangDTO(maNhaHang, tenNhaHang, diaChi, dienThoai);
                    //list.Add(nhaHang);
                }
            }
            return list;
        }
    }
}
