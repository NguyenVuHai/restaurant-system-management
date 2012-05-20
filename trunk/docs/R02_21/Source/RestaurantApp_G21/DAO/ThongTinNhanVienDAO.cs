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
        internal static List<ThongTinNhanVienDTO> LoadDanhSachNhanVien()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.T58LoadDanhSachNhanVien";
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<ThongTinNhanVienDTO> list = new List<ThongTinNhanVienDTO>();
            if (dt != null)
            {
                int maNH;
                int maLoai;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinNhanVienDTO thongTinNhanVien = new ThongTinNhanVienDTO();
                    thongTinNhanVien.MaNhanVien = Int32.Parse(dt.Rows[i]["MaNhanVien"].ToString());
                    if (Int32.TryParse(dt.Rows[i]["MaNhaHang"].ToString(), out maNH))
                        thongTinNhanVien.MaNhaHang = maNH;
                    if (Int32.TryParse(dt.Rows[i]["MaLoaiNhanVien"].ToString(), out maLoai))
                        thongTinNhanVien.MaLoaiNhanVien = maLoai;
                    thongTinNhanVien.Ho = dt.Rows[i]["Ho"].ToString();
                    thongTinNhanVien.Ten = dt.Rows[i]["Ten"].ToString();
                    thongTinNhanVien.CMND = dt.Rows[i]["CMND"].ToString();
                    thongTinNhanVien.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    thongTinNhanVien.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    thongTinNhanVien.NgayVaoLam = DateTime.Parse(dt.Rows[i]["NgayVaoLam"].ToString());
                    thongTinNhanVien.TinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                    list.Add(thongTinNhanVien);
                }
            }
            return list;
        }

        internal static void EditThongTinNhanVien(ThongTinNhanVienDTO nv, int loaiTruyXuat)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            
            if(loaiTruyXuat == 1)
                command.CommandText = "dbo.T58LostUpdateEditThongTinNhanVien";
            else if(loaiTruyXuat == 2)
                command.CommandText = "dbo.T58LostUpdateSolvedEditThongTinNhanVien";
            else if(loaiTruyXuat == 3)
                command.CommandText = "dbo.T58DirtyReadEditThongTinNhanVien";
            else if(loaiTruyXuat == 4)
                command.CommandText = "dbo.T58DirtyReadSolvedEditThongTinNhanVien";
            else if (loaiTruyXuat == 5 || loaiTruyXuat == 6)
                command.CommandText = "dbo.T58UnrepeatableEditThongTinNhanVien";
            else if(loaiTruyXuat == 7 || loaiTruyXuat == 8)
                command.CommandText = "dbo.T58PhantomEditThongTinNhanVien";
            else
                command.CommandText = "dbo.T58EditThongTinNhanVien";

            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhanVien";
            param.Value = nv.MaNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            if (nv.MaNhaHang == 0)
                param.Value = 0;
            else
                param.Value = nv.MaNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@MaLoaiNhanVien";
            if (nv.MaLoaiNhanVien == 0)
                param.Value = 0;
            else
                param.Value = nv.MaLoaiNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@Ho";
            if (nv.Ho == null)
                param.Value = DBNull.Value;
            else
                param.Value = nv.Ho;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@Ten";
            param.Value = nv.Ten;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@CMND";
            param.Value = nv.CMND;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@DiaChi";
            param.Value = nv.DiaChi;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@DienThoai";
            param.Value = nv.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@NgayVaoLam";
            param.Value = nv.NgayVaoLam;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@TinhTrang";
            if (nv.TinhTrang == "")
                param.Value = DBNull.Value;
            else
                param.Value = nv.TinhTrang;
            param.DbType = DbType.String;
            command.Parameters.Add(param); 

            DataAccessCode.ExecuteNonQuery(command);
        }

        internal static void AddThongTinNhanVien(ThongTinNhanVienDTO nv)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.T58AddThongTinNhanVien";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            if (nv.MaNhaHang == -1)
                param.Value = DBNull.Value;
            else
                param.Value = nv.MaNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaLoaiNhanVien";
            if (nv.MaLoaiNhanVien == -1)
                param.Value = DBNull.Value;
            else
                param.Value = nv.MaLoaiNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Ho";
            if (nv.Ho == null)
                param.Value = DBNull.Value;
            else
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
            param.ParameterName = "@CMND";
            param.Value = nv.CMND;
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
            param.ParameterName = "@DienThoai";
            param.Value = nv.DienThoai;
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
            if (nv.TinhTrang == "")
                param.Value = DBNull.Value;
            else
                param.Value = nv.TinhTrang;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            
            DataAccessCode.ExecuteNonQuery(command);
        }

        internal static List<ThongTinNhanVienDTO> FindNhanVien(ThongTinNhanVienDTO nv, int loaiTruyXuat)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            if (loaiTruyXuat == 1)
                command.CommandText = "dbo.T58LostUpdateTimKiemNhanVien";
            else if (loaiTruyXuat == 2)
                command.CommandText = "dbo.T58LostUpdateSolvedTimKiemNhanVien";
            else if(loaiTruyXuat == 3)
                command.CommandText = "dbo.T58DirtyReadTimKiemNhanVien";
            else if (loaiTruyXuat == 4)
                command.CommandText = "dbo.T58DirtyReadSolvedTimKiemNhanVien";
            else if (loaiTruyXuat == 5)
                command.CommandText = "dbo.T58UnrepeatableTimKiemNhanVien";
            else if (loaiTruyXuat == 6)
                command.CommandText = "dbo.T58UnrepeatableSolvedTimKiemNhanVien";
            else if (loaiTruyXuat == 7)
                command.CommandText = "dbo.T58PhantomTimKiemNhanVien";
            else if (loaiTruyXuat == 8)
                command.CommandText = "dbo.T58PhantomSolvedTimKiemNhanVien";
            else
                command.CommandText = "dbo.T58TimKiemNhanVien";
                
            // create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhanVien";
            if (nv.MaNhanVien == 0)
                param.Value = 0;
            else param.Value = nv.MaNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            if (nv.MaNhaHang == 0)
                param.Value = 0;//DBNull.Value;
            else if (nv.MaNhaHang == -1)
                param.Value = -1;
            else
                param.Value = nv.MaNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaLoaiNhanVien";
            if (nv.MaLoaiNhanVien == 0)
                param.Value = 0;
            else if (nv.MaLoaiNhanVien == -1)
                param.Value = -1;
            else
                param.Value = nv.MaLoaiNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Ho";
            if (nv.Ho == "")
                param.Value = "";
            else param.Value = nv.Ho;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Ten";
            if (nv.Ten == "")
                param.Value = "";
            else param.Value = nv.Ten;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@CMND";
            if (nv.CMND == "")
                param.Value = "";
            else param.Value = nv.CMND;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DiaChi";
            if (nv.DiaChi == "")
                param.Value = "";
            else param.Value = nv.DiaChi;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DienThoai";
            if (nv.DienThoai == "")
                param.Value = "";
            else param.Value = nv.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@NgayVaoLam";
            param.DbType = DbType.DateTime;
            if (nv.NgayVaoLam == new DateTime())
                param.Value = DBNull.Value;
            else param.Value = nv.NgayVaoLam;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@TinhTrang";
            if (nv.TinhTrang == "")
                param.Value = "";
            else param.Value = nv.TinhTrang;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<ThongTinNhanVienDTO> list = new List<ThongTinNhanVienDTO>();
            if (dt != null)
            {
                int temp;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinNhanVienDTO thongTinNhanVien = new ThongTinNhanVienDTO();
                    if (Int32.TryParse(dt.Rows[i]["MaNhanVien"].ToString(), out temp))
                        thongTinNhanVien.MaNhanVien = temp;
                    else
                        thongTinNhanVien.MaNhanVien = 0;

                    if (Int32.TryParse(dt.Rows[i]["MaNhaHang"].ToString(), out temp))
                        thongTinNhanVien.MaNhaHang = temp;
                    else
                        thongTinNhanVien.MaNhaHang = 0;

                    if (Int32.TryParse(dt.Rows[i]["MaLoaiNhanVien"].ToString(), out temp))
                        thongTinNhanVien.MaLoaiNhanVien = temp;
                    else
                        thongTinNhanVien.MaLoaiNhanVien = 0;

                    thongTinNhanVien.Ho = dt.Rows[i]["Ho"].ToString();
                    thongTinNhanVien.Ten = dt.Rows[i]["Ten"].ToString();
                    thongTinNhanVien.CMND = dt.Rows[i]["CMND"].ToString();
                    thongTinNhanVien.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    thongTinNhanVien.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    thongTinNhanVien.NgayVaoLam = DateTime.Parse(dt.Rows[i]["NgayVaoLam"].ToString());
                    thongTinNhanVien.TinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                    list.Add(thongTinNhanVien);
                }
            }
            return list;
        }

        internal static void DeleteThongTinNhanVien(int maNhanVien)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.DeleteThongTinNhanVien";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhanVien";
            param.Value = maNhanVien;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            DataAccessCode.ExecuteNonQuery(command);
        }

        internal static int SumNhanVien(int maNH, int loaiTruyXuat)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            
            if (loaiTruyXuat == 3)
                command.CommandText = "dbo.T58DirtyReadSumNhanVien";
            else if (loaiTruyXuat == 4)
                command.CommandText = "dbo.T58DirtyReadSolvedSumNhanVien";
            else
                command.CommandText = "dbo.T58SumNhanVien";
            
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            if (maNH == 0)
                param.Value = 0;
            else if (maNH == -1)
                param.Value = -1;
            else
                param.Value = maNH;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);


            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            return Int32.Parse(dt.Rows[0]["Tong"].ToString());
        }
    }
}
