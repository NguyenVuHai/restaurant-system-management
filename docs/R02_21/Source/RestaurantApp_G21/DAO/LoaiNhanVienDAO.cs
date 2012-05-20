using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;

namespace RestaurantApp_G21.DAO
{
    class LoaiNhanVienDAO
    {
        public static List<LoaiNhanVienDTO> LayDanhSachLoaiNhanVien()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachLoaiNhanVien";

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<LoaiNhanVienDTO> list = new List<LoaiNhanVienDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoaiNhanVienDTO loaiNhanVien = new LoaiNhanVienDTO();
                    loaiNhanVien.MaLoaiNhanVien = Int32.Parse(dt.Rows[i]["MaLoaiNhanVien"].ToString());
                    loaiNhanVien.TenLoaiNhanVien = dt.Rows[i]["TenLoaiNhanVien"].ToString();
                    loaiNhanVien.Luong = Decimal.Parse(dt.Rows[i]["Luong"].ToString());

                    list.Add(loaiNhanVien);
                }
            }
            return list;
        }
    }
}
