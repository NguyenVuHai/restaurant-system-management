﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RestaurantApp_G21.DTO;
//using RestaurantApp_G21.DAO;

namespace RestaurantApp_G21.GUI
{
    class accessory
    {
        public static void initComboMonAnTheoPhanLoai(ArrayList ds, ComboBox cb)
        {
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
        public static void initComboLoaiMonAn(ArrayList ds, ComboBox cb)
        {
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
            for (int i = 0; i < grid_ds.RowCount; i++)
                if (Convert.ToBoolean(grid_ds.Rows[i].Cells[0].Value) == true)
                    grid_ds.Rows.RemoveAt(i);
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
                 //if (Convert.ToBoolean(grid_ds.Rows[i].Cells[0].Value) == true)
                 //{
                     for (int j = 1; j < grid_ds.ColumnCount; j++)
                         grid_ds.Rows[i].Cells[j].ReadOnly = stt;
                 //}
             }
         }
    }
}