using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RestaurantApp_G21.BUS;
using RestaurantApp_G21.DTO;

namespace RestaurantApp_G21.GUI.KhoHang.NhaCungCap
{
    public partial class uc_nccToiHanCanThanhToan : UserControl
    {
        public uc_nccToiHanCanThanhToan()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            grid_ds.Rows.Clear();
            ArrayList ds1 = KhoHangBUS.layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoThoiDiemThanhToan(GlobalVariables.maNhaHang);
            ArrayList ds2 = KhoHangBUS.layDanhSachNhaCungCapToiHanDuocThanhToanNoTheoDinhMucNo(GlobalVariables.maNhaHang);
            for (int i = 0; i < ds1.Count; i++)
            {
                NhaCungCapDTO dto1 = (NhaCungCapDTO)ds1[i];
                grid_ds.Rows.Add();
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cMaNhaCungCap"].Value = dto1.MaNhaCungCap;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cTenNhaCungCap"].Value = dto1;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cDienThoai"].Value = dto1.DienThoai;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cSoTaiKhoan"].Value = dto1.SoTaiKhoan;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cTongNo"].Value = dto1.TongNo;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cThoiDiemThanhToan"].Value = dto1.ThoiDiemThanhToan;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cDinhMucNo"].Value = "Không có";
            }

            for (int i = 0; i < ds2.Count; i++)
            {
                NhaCungCapDTO dto2 = (NhaCungCapDTO)ds2[i];
                grid_ds.Rows.Add();
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cMaNhaCungCap"].Value = dto2.MaNhaCungCap;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cTenNhaCungCap"].Value = dto2;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cDienThoai"].Value = dto2.DienThoai;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cSoTaiKhoan"].Value = dto2.SoTaiKhoan;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cTongNo"].Value = dto2.TongNo;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cThoiDiemThanhToan"].Value = dto2.ThoiDiemThanhToan;
                grid_ds.Rows[grid_ds.RowCount - 1].Cells["cDinhMucNo"].Value = dto2.GiaTriDinhMucNo;
            }
        }
    }
}
