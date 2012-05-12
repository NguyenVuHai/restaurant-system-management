using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;


namespace RestaurantApp_G21.DAO
{
    class LichLamViecDAO
    {
        internal static List<LichLamViecDTO> LoadLichLamViec()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachLichLamViec";

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<LichLamViecDTO> list = new List<LichLamViecDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LichLamViecDTO lich = new LichLamViecDTO();
                    lich.MaNhanVien = Int32.Parse(dt.Rows[i]["MaNhanVien"].ToString());
                    lich.HoNhanVien = dt.Rows[i]["HoNhanVien"].ToString();
                    lich.TenNhanVien = dt.Rows[i]["TenNhanVien"].ToString();
                    lich.Thu = Int32.Parse(dt.Rows[i]["Thu"].ToString());
                    lich.Ca = Int32.Parse(dt.Rows[i]["Ca"].ToString());

                    list.Add(lich);
                }
            }
            return list;
        }
    }
}
