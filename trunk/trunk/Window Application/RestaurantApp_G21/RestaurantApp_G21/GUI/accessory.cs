using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.BUS;
//using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.GUI
{
    class accessory
    {
        public static void initButtonDockFillInPanelEx(DevComponents.DotNetBar.PanelEx pn)
        {
            int w = pn.Width / pn.Controls.Count;
            for (int i = 0; i < pn.Controls.Count; i++)
                pn.Controls[i].Width = w;
        }
        public static void initButtonDockFillInPanel(Panel pn)
        {
            int w = pn.Width / pn.Controls.Count;
            for (int i = 0; i < pn.Controls.Count; i++)
                pn.Controls[i].Width = w;
        }
        public static void showDanhSachNguyenLieuTheoMonAnLenComboNguyenLieu(MonAnDTO monAn, ComboBox cb)
        {
            ArrayList dsNguyenLieuTheoMon = new ArrayList();
            dsNguyenLieuTheoMon = MonAnBUS.layDanhSachNguyenLieuTheoMonAn(monAn);


            for (int i = 0; i < dsNguyenLieuTheoMon.Count; i++)
            {
                MonAn_NguyenLieuDTO dto = (MonAn_NguyenLieuDTO)dsNguyenLieuTheoMon[i];
                cb.Items.Add(dto);
            }
        }
        public static void cb_monAn_SelectedIndexChangedShowComboNguyenLieu(ComboBox cb_monAn, ComboBox cb_nguyenLieu)
        {
            cb_nguyenLieu.Items.Clear();

            MonAn_NguyenLieuDTO dto = new MonAn_NguyenLieuDTO();
            dto.NguyenLieu.TenNguyenLieu = "Tất cả";
            dto.NguyenLieu.MaNguyenLieu = 0;

            cb_nguyenLieu.Items.Add(dto);
            if (cb_monAn.Items.Count == 0)
                return;
            if (cb_monAn.SelectedIndex != 0)
                showDanhSachNguyenLieuTheoMonAnLenComboNguyenLieu(((PhanLoaiMonAnDTO)cb_monAn.SelectedItem).MonAn, cb_nguyenLieu);
            else if (cb_monAn.SelectedIndex == 0)
            {
                for (int i = 1; i < cb_monAn.Items.Count; i++)
                    showDanhSachNguyenLieuTheoMonAnLenComboNguyenLieu(((PhanLoaiMonAnDTO)cb_monAn.Items[i]).MonAn, cb_nguyenLieu);
            }
            if (cb_nguyenLieu.Items.Count == 0)
            {
                cb_nguyenLieu.Text = "Không có";
                cb_nguyenLieu.Enabled = false;
                return;
            }
            cb_nguyenLieu.Enabled = true;
            cb_nguyenLieu.SelectedIndex = 0;
        }
        public static void initComboMonAnTheoPhanLoai(ComboBox cb_loaiMonAn, ComboBox cb)
        {
            ArrayList ds = new ArrayList();
            ds = PhanLoaiMonAnBUS.layDanhSachMonAnTheoPhanLoaiMonAn((LoaiMonAnDTO)cb_loaiMonAn.SelectedItem, GlobalVariables.maNhaHang);
            cb.Items.Clear();
            if (ds.Count == 0)
            {
                cb.Text = "Không có";
                cb.Enabled = false;
                return;
            }
            cb.Enabled = true;
            PhanLoaiMonAnDTO plMA = new PhanLoaiMonAnDTO();
            plMA.MonAn = new MonAnDTO();
            plMA.MonAn.TenMonAn = "Tất cả";
            plMA.MonAn.MaMonAn = 0;

            cb.Items.Add(plMA);
            for (int i = 0; i < ds.Count; i++)
            {
                plMA = new PhanLoaiMonAnDTO();
                plMA = (PhanLoaiMonAnDTO)ds[i];
                cb.Items.Add(plMA);
            }
            cb.SelectedIndex = 0;
        }
        public static void initComboLoaiMonAn(ComboBox cb)
        {
            ArrayList ds = new ArrayList();
            ds = LoaiMonAnBUS.layDanhSachLoaiMonAn();
            cb.Items.Clear();

            if (ds.Count == 0)
            {
                cb.Text = "Không có";
                cb.Enabled = false;
                return;
            }
            cb.Enabled = true;
            LoaiMonAnDTO loai = new LoaiMonAnDTO();
            loai.TenLoaiMonAn = "Tất cả";
            cb.Items.Add(loai);
            for (int i = 0; i < ds.Count; i++)
            {
                loai = new LoaiMonAnDTO();
                loai = (LoaiMonAnDTO)ds[i];
                cb.Items.Add(loai);
            }
            cb.SelectedIndex = 0;
        }
        public static void removeCheckedRows(DataGridView grid_ds)
        {
            int totalGridRow = grid_ds.RowCount;
            for (int i = 0; i < totalGridRow; i++)
                if (Convert.ToBoolean(grid_ds.Rows[0].Cells[0].Value) == true)
                    grid_ds.Rows.RemoveAt(0);
        }
        public static void checkAllRowsOfGrid(DataGridView grid_ds, bool stt)
        {
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_ds.Rows[i].Cells[0].Value) == true)
                {
                    for (int j = 1; j < grid_ds.ColumnCount; j++)
                        grid_ds.Rows[i].Cells[j].ReadOnly = true;
                }
                grid_ds.Rows[i].Cells[0].Value = stt;
            }
        }
        public static void readOnlyCheckedRows(DataGridView grid_ds, bool stt)
        {
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_ds.Rows[i].Cells[0].Value) == true)
                {
                    for (int j = 1; j < grid_ds.ColumnCount; j++)
                        grid_ds.Rows[i].Cells[j].ReadOnly = stt;
                }
            }
        }
        public static void readOnlyCheckedSomeCells(DataGridView grid_ds, bool stt,int indexColumn)
        {
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_ds.Rows[i].Cells[0].Value) == true)
                {
                    for (int j = 1; j < grid_ds.ColumnCount; j++)
                    {
                        if(j==indexColumn)
                            grid_ds.Rows[i].Cells[j].ReadOnly = stt;
                    }
                }
            }
        }
    }
}
