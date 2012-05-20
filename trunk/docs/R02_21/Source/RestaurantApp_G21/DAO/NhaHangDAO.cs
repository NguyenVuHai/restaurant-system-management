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
        public static DataTable LayBangNhaHang()
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachNhaHang";
            return DataAccessCode.ExecuteSelectCommand(command);
        }


        public static bool ThemNhaHang(NhaHangDTO nhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            if (KiemTraTruocKhiLuu(nhaHang))
            {
                string sql = string.Format("INSERT INTO NHAHANG (TenNhaHang, DiaChi, DienThoai)"
                                            + "VALUES(N'{0}',N'{1}',N'{2}')", nhaHang.TenNhaHang, nhaHang.DiaChi, nhaHang.DienThoai);
                if (DataAccessCode.ExecuteQuery(sql, command))
                {
                    MessageBox.Show("Thêm Nhà Hàng Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool SuaNhaHang(NhaHangDTO nhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            string sql = string.Format("UPDATE NHAHANG SET TenNhaHang ={0},DiaChi = {1},DienThoai ={2}", nhaHang.TenNhaHang, nhaHang.DiaChi, nhaHang.DienThoai);
            if (DataAccessCode.ExecuteQuery(sql, command))
            {
                MessageBox.Show("Sửa Nhà Hàng Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool XoaNhaHang(string maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            // string sql = "DELETE FROM NHAHANG WHERE MaNhaHang in ('"++ "')"
            return false;
            //string sql = "DELETE FROM KETQUA WHERE MaSV in ('" + masv + "') "
            //   + "DELETE FROM SINHVIEN WHERE MaSV in ('" + masv + "')";
            //if (connData.ExecuteQuery(sql))
            //{
            //    MessageBox.Show("Xóa sinh viên thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return true;
            //}
            //return false;
        }
        public static bool KiemTraTruocKhiLuu(NhaHangDTO nhaHang)
        {
            if (nhaHang.TenNhaHang == "" || nhaHang.TenNhaHang == "" || nhaHang.TenNhaHang == "")
            {
                MessageBox.Show("Tên Nhà Hàng Không Hợp Lệ");
                return false;
            }
            if (nhaHang.TenNhaHang == "%" || nhaHang.TenNhaHang.IndexOf("'") >= 0 || nhaHang.TenNhaHang.IndexOf("`") >= 0)
            {
                MessageBox.Show("Tên Nhà Hàng Không Hợp Lệ");
                return false;
            }
            if (nhaHang.DiaChi == "%" || nhaHang.DiaChi.IndexOf("'") >= 0 || nhaHang.DiaChi.IndexOf("`") >= 0)
            {
                MessageBox.Show("Địa Chỉ Không Hợp Lệ");
                return false;
            }
            if (nhaHang.DienThoai == "%" || nhaHang.DienThoai.IndexOf("'") >= 0 || nhaHang.DienThoai.IndexOf("`") >= 0)
            {
                MessageBox.Show("Đia Chỉ Không Hợp Lệ");
                return false;
            }
            return true;
        }
    }
}
