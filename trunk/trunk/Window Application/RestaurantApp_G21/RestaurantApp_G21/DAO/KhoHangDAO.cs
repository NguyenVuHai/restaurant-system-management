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
    class KhoHangDAO
    {
        public static ArrayList layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoDinhMucNo(int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoDinhMucNo";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@maNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);


            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCapDTO dto = new NhaCungCapDTO();
                    dto.MaNhaCungCap = Convert.ToInt32(dt.Rows[i]["MaNhaCungCap"]);
                    dto.TenNhaCungCap = dt.Rows[i]["TenNhaCungCap"].ToString();
                    dto.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    dto.SoTaiKhoan = dt.Rows[i]["SoTaiKhoan"].ToString();
                    dto.ThoiDiemThanhToan = dt.Rows[i]["ThoiDiemThanhToan"].ToString();
                    dto.MaThoiDiemThanhToan = Convert.ToInt32(dt.Rows[i]["MaThoiDiemThanhToan"]);
                    dto.GiaTriDinhMucNo = Convert.ToDecimal(dt.Rows[i]["GiaTriDinhMuc"]);
                    if (dt.Rows[i]["TongNo"].ToString() != "")
                        dto.TongNo = Convert.ToDecimal(dt.Rows[i]["TongNo"]);

                    list.Add(dto);
                }
            }
            return list;
        }
        public static ArrayList layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoThoiDiemThanhToan(int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoThoiDiemThanhToan";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@maNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);
            

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCapDTO dto = new NhaCungCapDTO();
                    dto.MaNhaCungCap = Convert.ToInt32(dt.Rows[i]["MaNhaCungCap"]);
                    dto.TenNhaCungCap = dt.Rows[i]["TenNhaCungCap"].ToString();
                    dto.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    dto.SoTaiKhoan = dt.Rows[i]["SoTaiKhoan"].ToString();
                    dto.ThoiDiemThanhToan = dt.Rows[i]["ThoiDiemThanhToan"].ToString();
                    dto.MaThoiDiemThanhToan = Convert.ToInt32(dt.Rows[i]["MaThoiDiemThanhToan"]);
                    dto.GiaTriDinhMucNo = 0;//hien thi NULL
                    if (dt.Rows[i]["TongNo"].ToString() != "")
                        dto.TongNo = Convert.ToDecimal(dt.Rows[i]["TongNo"]);

                    list.Add(dto);
                }
            }
            return list;
        }
        public static ArrayList timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich(string ten, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@ten";
            param.Value = ten;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@maNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCapDTO dto = new NhaCungCapDTO();
                    dto.MaNhaCungCap = Convert.ToInt32(dt.Rows[i]["MaNhaCungCap"]);
                    dto.TenNhaCungCap = dt.Rows[i]["TenNhaCungCap"].ToString();
                    dto.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    dto.SoTaiKhoan = dt.Rows[i]["SoTaiKhoan"].ToString();
                    if (dt.Rows[i]["TongNo"].ToString() != "")
                        dto.TongNo = Convert.ToDecimal(dt.Rows[i]["TongNo"]);

                    list.Add(dto);
                }
            }
            return list;
        }
        public static ArrayList timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(string ten, int tinhTrangGiaoDich, int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@ten";
            param.Value = ten;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@tinhTrangGiaoDich";
            param.Value = tinhTrangGiaoDich;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@maNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCapDTO dto = new NhaCungCapDTO();
                    dto.MaNhaCungCap = Convert.ToInt32(dt.Rows[i]["MaNhaCungCap"]);
                    dto.TenNhaCungCap = dt.Rows[i]["TenNhaCungCap"].ToString();
                    dto.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    dto.SoTaiKhoan = dt.Rows[i]["SoTaiKhoan"].ToString();
                    if (dt.Rows[i]["TongNo"].ToString() != "")
                        dto.TongNo = Convert.ToDecimal(dt.Rows[i]["TongNo"]);

                    list.Add(dto);
                }
            }
            return list;
        }
        public static ArrayList layDanhSachNhaCungCap(int maNhaHang, string ten)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.layDanhSachNhaCungCap";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@maNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@ten";
            param.Value = ten;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCapDTO dto = new NhaCungCapDTO();
                    dto.MaNhaCungCap = Convert.ToInt32(dt.Rows[i]["MaNhaCungCap"]);
                    dto.TenNhaCungCap = dt.Rows[i]["TenNhaCungCap"].ToString();
                    dto.DienThoai = dt.Rows[i]["DienThoai"].ToString();
                    dto.SoTaiKhoan = dt.Rows[i]["SoTaiKhoan"].ToString();
                    string a = dt.Rows[i]["TongNo"].ToString();
                    if (dt.Rows[i]["TongNo"].ToString() != "")
                        dto.TongNo = Convert.ToDecimal(dt.Rows[i]["TongNo"]);
                    list.Add(dto);
                }
            }
            return list;
        }
        public static ArrayList traCuuNhaCungCapThoaYeuCauNguyenLieuCanDatHang(string sqlFROM)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.traCuuNhaCungCapThoaYeuCauNguyenLieuCanDatHang";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@sqlFROM";
            param.Value = sqlFROM;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCapDTO dto = new NhaCungCapDTO();
                    dto.MaNhaCungCap = Convert.ToInt32(dt.Rows[i]["MaNhaCungCap"]);
                    dto.SoLuongNguyenLieuToiDaPhuHopYeuCauDatHang = Convert.ToInt32(dt.Rows[i]["SoLuongNguyenLieuDapUng"]);
                    dto.TenNhaCungCap = dt.Rows[i]["TenNhaCungCap"].ToString();
                    list.Add(dto);
                }
            }
            return list;
        }
        public static ArrayList layDanhSachNguyenLieuDangOKhoangMucToiThieu(int maNhaHang)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.layDanhSachNguyenLieuDangOKhoangMucToiThieu";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoHang_NguyenLieuDTO dto = new KhoHang_NguyenLieuDTO();
                    dto.NguyenLieu.MaNguyenLieu = Convert.ToInt32(dt.Rows[i]["MaNguyenLieu"]);
                    dto.NguyenLieu.TenNguyenLieu = dt.Rows[i]["TenNguyenLieu"].ToString();
                    dto.NguyenLieu.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                    dto.SoLuongTon = Convert.ToInt32(dt.Rows[i]["SoLuongTon"]);
                    dto.SucChua = Convert.ToInt32(dt.Rows[i]["SucChua"]);
                    dto.MucTonToiThieu = Convert.ToInt32(dt.Rows[i]["MucChuaToiThieu"]);
                    list.Add(dto);
                }
            }
            return list;
        }
        public static KhoHang_NguyenLieuDTO layChiTietKhoHangNguyenLieu(int maNhaHang, NguyenLieuDTO nguyenLieuCanTim)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.layChiTietKhoHangNguyenLieu";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@MaNguyenLieu";
            param.Value = nguyenLieuCanTim.MaNguyenLieu;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            KhoHang_NguyenLieuDTO dto = new KhoHang_NguyenLieuDTO();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dto.NguyenLieu.MaNguyenLieu = Convert.ToInt32(dt.Rows[i]["MaNguyenLieu"]);
                    dto.NguyenLieu.TenNguyenLieu = dt.Rows[i]["TenNguyenLieu"].ToString();
                    dto.NguyenLieu.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                    dto.SoLuongTon = Convert.ToInt32(dt.Rows[i]["SoLuongTon"]);
                    dto.SucChua = Convert.ToInt32(dt.Rows[i]["SucChua"]);
                    dto.MucTonToiThieu = Convert.ToInt32(dt.Rows[i]["MucChuaToiThieu"]);
                }
            }
            return dto;
        }
        public static ArrayList traCuuKhoHangNguyenLieuGanDung(int maNhaHang, NguyenLieuDTO nguyenLieuCanTim)
        {
            DbCommand command = DataAccessCode.CreateCommand();
            command.CommandText = "dbo.LayDanhSachKhoHangNguyenLieuGanDung";
            DbParameter param = command.CreateParameter();
            param.ParameterName = "@Key";
            param.Value = nguyenLieuCanTim.TenNguyenLieu;
            param.DbType = DbType.String;
            command.Parameters.Add(param);

            param = command.CreateParameter();
            param.ParameterName = "@MaNhaHang";
            param.Value = maNhaHang;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            DataTable dt = DataAccessCode.ExecuteSelectCommand(command);
            ArrayList list = new ArrayList();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhoHang_NguyenLieuDTO dto = new KhoHang_NguyenLieuDTO();
                    dto.NguyenLieu.MaNguyenLieu = Convert.ToInt32(dt.Rows[i]["MaNguyenLieu"]);
                    dto.NguyenLieu.TenNguyenLieu = dt.Rows[i]["TenNguyenLieu"].ToString();
                    dto.NguyenLieu.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                    dto.SoLuongTon = Convert.ToInt32(dt.Rows[i]["SoLuongTon"]);
                    dto.SucChua = Convert.ToInt32(dt.Rows[i]["SucChua"]);
                    dto.MucTonToiThieu = Convert.ToInt32(dt.Rows[i]["MucChuaToiThieu"]);
                    list.Add(dto);
                }
            }
            return list;
        }
    }
}
