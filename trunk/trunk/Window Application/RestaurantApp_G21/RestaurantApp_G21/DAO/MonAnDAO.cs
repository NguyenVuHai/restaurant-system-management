using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;
using System.Collections;

namespace RestaurantApp_G21.DAO
{
    class MonAnDAO
    {
        public static ArrayList layDanhSachNguyenLieuTheoMonAn(MonAnDTO monAn)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachNguyenLieuTheoMonAn";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaMonAn";
            param.Value = monAn.MaMonAn;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MonAn_NguyenLieuDTO dto = new MonAn_NguyenLieuDTO();
                    dto.NguyenLieu.MaNguyenLieu = Convert.ToInt32(dt.Rows[i]["MaNguyenLieu"]);
                    dto.NguyenLieu.TenNguyenLieu = dt.Rows[i]["TenNguyenLieu"].ToString();
                    dto.NguyenLieu.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                    dto.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"]);
                    list.Add(dto);
                }
            }
            return list;
        }
    }
}
