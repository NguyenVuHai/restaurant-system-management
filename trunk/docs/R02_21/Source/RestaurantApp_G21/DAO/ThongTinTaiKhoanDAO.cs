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
    class ThongTinTaiKhoanDAO
    {
        public static List<ThongTinTaiKhoanDTO> LayThongTinTaiKhoan(string user, string pass)
        {
            // using Data.Common 
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayThongTinTaiKhoan";
            // create parameter UserName
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@UserName";
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            // create Parameter Pass
            param = command.CreateParameter();
            param.ParameterName = "@Pass";
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            // tạo ra list thông tài khoản để lưu các thông tin :
            List<ThongTinTaiKhoanDTO> list = new List<ThongTinTaiKhoanDTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongTinTaiKhoanDTO taiKhoan = new ThongTinTaiKhoanDTO();
                    taiKhoan.ID = Int32.Parse(dt.Rows[i]["ID"].ToString());
                    taiKhoan.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                    taiKhoan.MatKhau = dt.Rows[i]["MatKhau"].ToString();
                    taiKhoan.LoaiNhanVien = Int32.Parse(dt.Rows[i]["LoaiNhanVien"].ToString());
                    taiKhoan.MaNhaHang = (dt.Rows[i]["MaNhaHang"].ToString());
                }
            }
            return list;
        }
        public static ThongTinTaiKhoanDTO KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayThongTinTaiKhoan";
            // create parameter UserName
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@UserName";
            param.Value = tenDangNhap;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            //create Parameter Pass
            param = command.CreateParameter();
            param.ParameterName = "@Pass";
            param.Value = matKhau;
            param.DbType = DbType.String;
            command.Parameters.Add(param);
            DataTable dt = DataAccessCode.ExecuteSelectCommand(command); //Cho nay ne, neu nhu username hoac pass ko dung thi no tra ve null ak
            ThongTinTaiKhoanDTO taiKhoan = new ThongTinTaiKhoanDTO();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    taiKhoan.ID = Int32.Parse(dt.Rows[i]["ID"].ToString());
                    taiKhoan.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                    taiKhoan.MatKhau = dt.Rows[i]["MatKhau"].ToString();
                    taiKhoan.LoaiNhanVien = Int32.Parse(dt.Rows[i]["MaLoaiNhanVien"].ToString());
                    taiKhoan.MaNhaHang = dt.Rows[i]["MaNhaHang"].ToString();
                    //taiKhoan.CMND = (dt.Rows[i]["CMND"].ToString());
                }
                return taiKhoan;
            }
            return null;
            //Tuc la neu user no nhap ko dung pass hoac username thi minh se tra ve null
            //=> cai form dang nhap ak,  if kq == null thi xa messsagebox ra thui

        }
        public static bool DoiMatKhau(string userName, string pass)
        {


            DbCommand command = DataAccessCode.CreateCommand();
            string sql = "UPDATE NguoiDung SET MatKhau = '" + pass + "' WHERE TenDangNhap = '" + userName + "' ";
            System.Windows.Forms.MessageBox.Show(sql);
            if (DataAccessCode.ExecuteQuery(sql, command))
                return true;
            return false;
        }
        // cấp phát 
        public static DataTable LayBangNguoiDung()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayTaiKhoan";
            return DataAccessCode.ExecuteSelectCommand(command);
        }
        public static bool ThemTaiKhoan(int maNhanVien, string taiKhoan, string matKhau)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            string sql = string.Format("INSERT INTO NGUOIDUNG(MaNhanVien, TenDangNhap , MatKhau)" +
                                        "VALUES(N'{0}',N{1},N{2})", maNhanVien, taiKhoan, matKhau);
            if (DataAccessCode.ExecuteQuery(sql, command))
            {
                MessageBox.Show("Thêm Mới Một Tài Khoản Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        public static bool ThayDoiTaiKhoan(int maNhanVien, string taiKhoan, string matKhau)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            string sql = string.Format("UPDATE NGUOIDUNG SET('N{0}','N{1}',N'{2}')", maNhanVien, taiKhoan, matKhau);
            if (DataAccessCode.ExecuteQuery(sql, command))
            {
                MessageBox.Show("Thay Đổi Một Tài Khoản Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}

