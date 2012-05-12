using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantApp_G21.DTO;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;

namespace RestaurantApp_G21.DAO
{
    class BanDatDAO
    {
        public static List<BanDatDTO> LayDanhSachBanDat()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachBanDat";

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<BanDatDTO> list = new List<BanDatDTO>();
            if (dt != null)
            {
                int maThongTinKhachHang;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BanDatDTO banDat = new BanDatDTO();
                    banDat.MaLichBan = Int32.Parse(dt.Rows[i]["MaLichBan"].ToString());
                    banDat.MaBan = Int32.Parse(dt.Rows[i]["MaBan"].ToString());
                    banDat.NgayDatBan = DateTime.Parse(dt.Rows[i]["NgayDatBan"].ToString());
                    banDat.MaBuoi = Int32.Parse(dt.Rows[i]["MaBuoi"].ToString());
                    if (Int32.TryParse(dt.Rows[i]["MaThongTinKhachHang"].ToString(), out maThongTinKhachHang))
                    {
                        banDat.MaThongTinKhachHang = maThongTinKhachHang;
                    }
                    banDat.SoLuong = Int32.Parse(dt.Rows[i]["SoLuong"].ToString());
                    banDat.TinhTrangBan = Boolean.Parse(dt.Rows[i]["TinhTrangBan"].ToString());

                    list.Add(banDat);
                }
            }
            return list;
        }

        public static void ThemThongTinBanDat(BanDatDTO banDat, int loai)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThemThongTinBanDat";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@Loai";
            param.Value = loai;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@HoTen";
            param.Value = banDat.HoTen;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@CMND";
            param.Value = banDat.Cmnd;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DienThoai";
            param.Value = banDat.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaBan";
            param.Value = banDat.MaBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@NgayDatBan";
            param.Value = banDat.NgayDatBan;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Buoi";
            param.Value = banDat.MaBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@SoLuong";
            param.Value = banDat.SoLuong;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@TinhTrangBan";
            param.Value = banDat.TinhTrangBan;
            param.DbType = DbType.Boolean;
            command.Parameters.Add(param);
            DataAccessCode.ExecuteNonQuery(command);
        }

        public static List<BanDatDTO> TimBan(int maNhaHang, int maBan, string tenBan, DateTime ngay)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.TimBan";
            // create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaBan";
            if (maBan == 0)
                param.Value = DBNull.Value;
            else param.Value = maBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Ngay";
            param.DbType = DbType.DateTime;
            if (ngay == new DateTime())
                param.Value = DBNull.Value;
            else param.Value = ngay;
            command.Parameters.Add(param);
            // create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@TenBan";
            param.Value = tenBan;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            List<BanDatDTO> list = new List<BanDatDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BanDatDTO banDat = new BanDatDTO();
                    banDat.MaNhaHang = Int32.Parse(dt.Rows[i]["MaNhaHang"].ToString());
                    banDat.MaBan = Int32.Parse(dt.Rows[i]["MaBan"].ToString());
                    banDat.HoTen = dt.Rows[i]["HoTen"].ToString();
                    banDat.Cmnd = dt.Rows[i]["CMND"].ToString();
                    banDat.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    banDat.NgayDatBan = DateTime.Parse(dt.Rows[i]["NgayDatBan"].ToString());
                    banDat.MaLichBan = Int32.Parse(dt.Rows[i]["MaLichBan"].ToString());
                    //banDat.MaThongTinKhachHang = Int32.Parse(dt.Rows[i]["MaThongTinKhachHang"].ToString());
                    banDat.TenBuoi = dt.Rows[i]["TenBuoi"].ToString();
                    list.Add(banDat);

                }
            }
            return list;
        }

        public static DataTable ThongTinKhachVaBanDat()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.ThongTinKhachVaBanDat";

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            //List<BanDatDTO> list = new List<BanDatDTO>();
            //if (dt != null)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        BanDatDTO bd = new BanDatDTO();
            //        //bd.MaNhaHang = Int32.Parse(dt.Rows[i]["MaNhaHang"].ToString());
            //        bd.HoTen = dt.Rows[i]["HoTen"].ToString();
            //        bd.Cmnd = dt.Rows[i]["CMND"].ToString();
            //        bd.DienThoai = dt.Rows[i]["DienThoai"].ToString();
            //        bd.MaBan = Int32.Parse(dt.Rows[i]["MaBan"].ToString());
            //        bd.NgayDatBan = DateTime.Parse(dt.Rows[i]["NgayDatBan"].ToString());
            //        bd.MaBuoi = Int32.Parse(dt.Rows[i]["MaBuoi"].ToString());
            //        bd.SoLuong = Int32.Parse(dt.Rows[i]["SoLuong"].ToString());
            //        bd.MaThongTinKhachHang = Int32.Parse(dt.Rows[i]["MaThongTinKhachHang"].ToString());
            //        bd.MaLichBan = Int32.Parse(dt.Rows[i]["MaLichBan"].ToString());
            //        list.Add(bd);
            //    }

            //}
            return dt;
        }
        public static bool CapNhatThongTinBanDat(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.CnCapNhatThongTinBanDat";
            //
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.ParameterName = "@MaBuoi";
            param.Value = maBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = ngay;
            param.ParameterName = "@NgayDat";
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = soLuong;
            param.ParameterName = "@SoLuong";
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            //param = command.CreateParameter();
            //param.ParameterName = "@TinhTrangBan";
            //param.Value = t;
            //param.DbType = DbType.Boolean;
            //command.Parameters.Add(param);
            if (DataAccessCode.ExecuteNonQuery(command) != -1)
            {
                MessageBox.Show("Thay Đổi Thông Tin Bàn Đặt Thành Công - Dirty Read");
                return true;
            }
            return false;
        }
        public static bool CapNhatThongTinBanDatLostU(int maLichBan, int maBuoi, DateTime ngay, int soLuong, bool t)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.CnCapNhatThongTinBanDatLostU";
            //
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.ParameterName = "@MaBuoi";
            param.Value = maBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            //
            param = command.CreateParameter();
            param.ParameterName = "@TinhTrangBan";
            param.Value = t;
            param.DbType = DbType.Boolean;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = ngay;
            param.ParameterName = "@NgayDat";
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = soLuong;
            param.ParameterName = "@SoLuong";
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            if (DataAccessCode.ExecuteNonQuery(command) != -1)
            {
                MessageBox.Show("Thay Đổi Thông Tin Bàn Đặt Thành Công");
                return true;
            }
            return false;
        }
        public static bool CapNhatThongTinBanDatLostUpdate(int maLichBan, int maBuoi, DateTime ngay, int soLuong, Boolean t)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.CnLostUpdate";
            //
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.ParameterName = "@TinhTrangBan";
            param.Value = t;
            param.DbType = DbType.Boolean;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.ParameterName = "@MaBuoi";
            param.Value = maBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = ngay;
            param.ParameterName = "@NgayDat";
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = soLuong;
            param.ParameterName = "@SoLuong";
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            if (DataAccessCode.ExecuteNonQuery(command) != -1)
            {
                MessageBox.Show("Thay Đổi Thông Tin Bàn Đặt Thành Công");
                return true;
            }
            return false;
        }

        public static bool CapNhatThongTinBanDatSolvedLostUpdate(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.CnSolvedLostUpdate";
            //
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.ParameterName = "@MaBuoi";
            param.Value = maBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = ngay;
            param.ParameterName = "@NgayDat";
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = soLuong;
            param.ParameterName = "@SoLuong";
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            if (DataAccessCode.ExecuteNonQuery(command) != -1)
            {
                MessageBox.Show("Thay Đổi Thông Tin Bàn Đặt Thành Công");
                return true;
            }
            return false;
        }
        public static bool CapNhatThongTinKhachBanDatUnRRead(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.CnCapNhatThongTinBanDatUnRRead";
            DbParameter pm = command.CreateParameter();

            //
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            //param = command.CreateParameter();
            //param.ParameterName = "@TinhTrangBan";
            //param.Value = t;
            //param.DbType = DbType.Boolean;
            //command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.ParameterName = "@MaBuoi";
            param.Value = maBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = ngay;
            param.ParameterName = "@NgayDat";
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = soLuong;
            param.ParameterName = "@SoLuong";
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            if (DataAccessCode.ExecuteNonQuery(command) != -1)
            {
                MessageBox.Show("Cập Nhật Thông Tin Khách - Bàn Đặt Thành Công-UnRRead");
                return true;
            }
            return false;
        }
        public static bool CapNhatThongTinKhachBanDatDefault(int maLichBan, int maBuoi, DateTime ngay, int soLuong)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.CnCapNhatThongTinBanDatDefault";
            DbParameter pm = command.CreateParameter();

            //
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaLichBan";
            param.Value = maLichBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            //param = command.CreateParameter();
            //param.ParameterName = "@TinhTrangBan";
            //param.Value = t;
            //param.DbType = DbType.Boolean;
            //command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.ParameterName = "@MaBuoi";
            param.Value = maBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = ngay;
            param.ParameterName = "@NgayDat";
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //
            param = command.CreateParameter();
            param.Value = soLuong;
            param.ParameterName = "@SoLuong";
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            if (DataAccessCode.ExecuteNonQuery(command) != -1)
            {
                MessageBox.Show("Cập Nhật Thông Tin Khách - Bàn Đặt Thành Công-Default");
                return true;
            }
            return false;
        }
        public static bool ThemThongTinKhachVaBanDatPhamTom(BanDatDTO banDat, int loai)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.CnThemThongTinKhachVaBanDatPhanTom";
            //// create a new parameter
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@Loai";
            param.Value = loai;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@HoTen";
            param.Value = banDat.HoTen;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@CMND";
            param.Value = banDat.Cmnd;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@DienThoai";
            param.Value = banDat.DienThoai;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@MaBan";
            param.Value = banDat.MaBan;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@NgayDatBan";
            param.Value = banDat.NgayDatBan;
            param.DbType = DbType.DateTime;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@Buoi";
            param.Value = banDat.MaBuoi;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@SoLuong";
            param.Value = banDat.SoLuong;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            //// create a new parameter
            param = command.CreateParameter();
            param.ParameterName = "@TinhTrangBan";
            param.Value = banDat.TinhTrangBan;
            param.DbType = DbType.Boolean;
            command.Parameters.Add(param);

            if (DataAccessCode.ExecuteNonQuery(command) != -1)
            {
                MessageBox.Show("Thêm Thành Công");
                return true;
            }
            return false;
        }

    }
}
