using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp_G21.GUI
{
    class accessory
    {
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
                 if (Convert.ToBoolean(grid_ds.Rows[i].Cells[0].Value) == true)
                 {
                     for (int j = 1; j < grid_ds.ColumnCount; j++)
                         grid_ds.Rows[i].Cells[j].ReadOnly = stt;
                 }
             }
         }
    }
}
