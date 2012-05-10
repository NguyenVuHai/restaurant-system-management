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

namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    public partial class uc_nguyenLieuToiMucToiThieu : UserControl
    {
        public uc_nguyenLieuToiMucToiThieu()
        {
            InitializeComponent();
            initGrid_ds();
        }
        private void showThongTinKhoHang_NguyenLieuDTOLenGrid(int row, KhoHang_NguyenLieuDTO dto)
        {
            grid_ds.Rows[row].Cells[0].ReadOnly = false;
            grid_ds.Rows[row].Cells["cMaNguyenLieu"].Value = dto;
            grid_ds.Rows[row].Cells["cTenNguyenLieu"].Value = dto.NguyenLieu.TenNguyenLieu;
            grid_ds.Rows[row].Cells["cDonViTinh"].Value = dto.NguyenLieu.DonViTinh;
            grid_ds.Rows[row].Cells["cLuongTon"].Value = dto.SoLuongTon;
            grid_ds.Rows[row].Cells["cConTrong"].Value = Convert.ToInt32(dto.SucChua) - Convert.ToInt32(dto.SoLuongTon);
            grid_ds.Rows[row].Cells["cToiThieu"].Value = dto.MucTonToiThieu;

        }
        private void initGrid_ds()
        {
            ArrayList ds = new ArrayList();
            ds = KhoHangBUS.layDanhSachNguyenLieuDangOKhoangMucToiThieu(GlobalVariables.maNhaHang);
            KhoHang_NguyenLieuDTO dto;
            if (ds.Count < grid_ds.RowCount)
            {
                for(int i=0;i<(grid_ds.RowCount-ds.Count);i++)
                {
                    grid_ds.Rows.RemoveAt(i);
                }
            }
                
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                dto = (KhoHang_NguyenLieuDTO)ds[i];
                showThongTinKhoHang_NguyenLieuDTOLenGrid(i, dto);
                grid_ds.Rows[i].Cells["cLuongDat"].ReadOnly = false;
            }
            //grid_ds.Rows.Clear();
            for (int i = grid_ds.RowCount; i < ds.Count; i++)
            {
                dto = (KhoHang_NguyenLieuDTO)ds[i];
                grid_ds.Rows.Add();
                showThongTinKhoHang_NguyenLieuDTOLenGrid(i, dto);
                grid_ds.Rows[i].Cells["cLuongDat"].ReadOnly = false;
            }
        }

        private void uc_nguyenLieuToiMucToiThieu_Load(object sender, EventArgs e)
        {
            //initGrid_ds();
        }

        private void uc_nguyenLieuToiMucToiThieu_Enter(object sender, EventArgs e)
        {
            
        }

        private void grid_ds_Enter(object sender, EventArgs e)
        {
            
        }

        private void grid_ds_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void grid_ds_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            initGrid_ds();
        }
    }
}
