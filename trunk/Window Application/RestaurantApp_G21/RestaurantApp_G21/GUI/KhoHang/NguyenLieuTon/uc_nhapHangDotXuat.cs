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
    public partial class uc_nhapHangDotXuat : UserControl
    {
        public uc_nhapHangDotXuat()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //load combo danh sach loai mon an
            accessory.initComboLoaiMonAn(cb_loaiMonAn);
            //load combo danh sach mon an theo loai mon an
            accessory.initComboMonAnTheoPhanLoai(cb_loaiMonAn, cb_monAn);
        }
        private void bt_loaiBoKhoiDanhSachCanDat_Click(object sender, EventArgs e)
        {
            accessory.removeCheckedRows(grid_nguyenLieuCanDatHang);
        }

        private void bt_tabPage_CTPhieuDat_chonTatCa_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_chiTietPhieuDat, true);
            bt_tabPage_CTPhieuDat_chonTatCa.Text = "Bỏ chọn";
            bt_tabPage_CTPhieuDat_chonTatCa.Click += new EventHandler(bt_tabPage_CTPhieuDat_boChonTatCa_Click);
        }
        private void bt_tabPage_CTPhieuDat_boChonTatCa_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_chiTietPhieuDat, false);
            bt_tabPage_CTPhieuDat_chonTatCa.Text = "Chọn tất cả";
            bt_tabPage_CTPhieuDat_chonTatCa.Click += new EventHandler(bt_tabPage_CTPhieuDat_chonTatCa_Click);
        }

        private void bt_tabPage_boRa_Click(object sender, EventArgs e)
        {
            accessory.removeCheckedRows(grid_chiTietPhieuDat);
            /*them nhung nguyen lieu bi loai bo khoi danh sach grid_chiTietPhieuDat 
             * vào danh sach grid_nguyenLieuCanDatHang 
             * .....*/

        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            int w = (panel1.Width / 4);
            for (int i = 0; i < panel1.Controls.Count; i++)
                panel1.Controls[i].Width = w;
        }

        private void cb_loaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            accessory.initComboMonAnTheoPhanLoai(cb_loaiMonAn, cb_monAn);
        }

        private void cb_monAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            accessory.cb_monAn_SelectedIndexChangedShowComboNguyenLieu(cb_monAn, cb_nguyenLieu);
        }

        private bool isIngrid_nguyenLieuCanDatHangOrNot(MonAn_NguyenLieuDTO dto)
        {
            for (int i = 0; i < grid_nguyenLieuCanDatHang.RowCount; i++)
            {
                if (((MonAn_NguyenLieuDTO)grid_nguyenLieuCanDatHang.Rows[i].Cells["grid_nguyenLieuCanDatHang_cNguyenLieu"].Value).NguyenLieu.MaNguyenLieu == dto.NguyenLieu.MaNguyenLieu)
                    return true;
            }
            return false;
        }
        private void them1DongVaoGrid_nguyenLieuCanDatHang(MonAn_NguyenLieuDTO item)
        {
            grid_nguyenLieuCanDatHang.Rows.Add();
            grid_nguyenLieuCanDatHang.Rows[grid_nguyenLieuCanDatHang.RowCount-1].Cells["grid_nguyenLieuCanDatHang_cNguyenLieu"].Value = item;
            grid_nguyenLieuCanDatHang.Rows[grid_nguyenLieuCanDatHang.RowCount-1].Cells["grid_nguyenLieuCanDatHang_cDonVi"].Value = item.NguyenLieu.DonViTinh;
        }
        private void bt_themVaoDanhSachNguyenLieuCanDatHang_Click(object sender, EventArgs e)
        {
            MonAn_NguyenLieuDTO curItem = (MonAn_NguyenLieuDTO)cb_nguyenLieu.SelectedItem;
            if (curItem.NguyenLieu.MaNguyenLieu == 0)
            {
                for (int i = 1; i < cb_nguyenLieu.Items.Count; i++)
                {
                    curItem = (MonAn_NguyenLieuDTO)cb_nguyenLieu.Items[i];
                    if (!isIngrid_nguyenLieuCanDatHangOrNot(curItem))
                    {
                        them1DongVaoGrid_nguyenLieuCanDatHang(curItem);
                    }
                }
            }
            else
            {
                if (!isIngrid_nguyenLieuCanDatHangOrNot(curItem))
                {
                    them1DongVaoGrid_nguyenLieuCanDatHang(curItem);
                }
            }
        }

        private void bt_chonTatCa_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_nguyenLieuCanDatHang, true);
            bt_chonTatCa.Text = "Bỏ chọn";
            bt_chonTatCa.Click += new EventHandler(bt_boChonTatCa_Click);
        }
        private void bt_boChonTatCa_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_nguyenLieuCanDatHang, false);
            bt_chonTatCa.Text = "Chọn tất cả";
            bt_chonTatCa.Click += new EventHandler(bt_chonTatCa_Click);
        }

        private void grid_nguyenLieuCanDatHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grid_nguyenLieuCanDatHang_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grid_nguyenLieuCanDatHang_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grid_nguyenLieuCanDatHang_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            label4.Text = grid_nguyenLieuCanDatHang.CurrentRow.Index.ToString();
        }

        private void grid_nguyenLieuCanDatHang_Validated(object sender, EventArgs e)
        {
            
        }

        private void bt_timNCCPhuHop_Click(object sender, EventArgs e)
        {
            string sqlFROM = "";
            for (int i = 0; i < grid_nguyenLieuCanDatHang.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_nguyenLieuCanDatHang.Rows[i].Cells[0].Value) == true)
                {
                    MonAn_NguyenLieuDTO dto = (MonAn_NguyenLieuDTO)grid_nguyenLieuCanDatHang.Rows[i].Cells["grid_nguyenLieuCanDatHang_cNguyenLieu"].Value;
                    sqlFROM += "(SELECT NHNCC.MaNhaCungCap, NCCNL.DonGia "
                            + " FROM NHAHANG_NHACUNGCAP NHNCC JOIN NHACUNGCAP_NGUYENLIEU NCCNL ON NHNCC.MaNhaCungCap=NCCNL.MaNhaCungCap"
                            + " WHERE NCCNL.MaNguyenLieu=" + dto.NguyenLieu.MaNguyenLieu.ToString() + " AND NHNCC.MaNhaHang=" + GlobalVariables.maNhaHang.ToString() + ")";
                    int j = i + 1;
                    
                    sqlFROM += " UNION ALL ";
                }
            }
            sqlFROM = sqlFROM.Substring(0, sqlFROM.Length - 10);
            ArrayList dsNCC = KhoHangBUS.traCuuNhaCungCapThoaYeuCauNguyenLieuCanDatHang(sqlFROM);
            if (dsNCC.Count == 0)
                return;
            grid_tabPage_NCC_nhaCungCapPhuHop.Rows.Clear();
            for (int i = 0; i < dsNCC.Count; i++)
            {
                NhaCungCapDTO dto = (NhaCungCapDTO)dsNCC[i];
                grid_tabPage_NCC_nhaCungCapPhuHop.Rows.Add();
                grid_tabPage_NCC_nhaCungCapPhuHop.Rows[i].Cells["grid_NCCPhuHop_cMaNhaCungCap"].Value = dto.MaNhaCungCap;
                grid_tabPage_NCC_nhaCungCapPhuHop.Rows[i].Cells["grid_NCCPhuHop_cTenNhaCungCap"].Value = dto;
                grid_tabPage_NCC_nhaCungCapPhuHop.Rows[i].Cells["grid_NCCPhuHop_cSoLuongNguyenLieuThoaYeuCau"].Value = dto.SoLuongNguyenLieuToiDaPhuHopYeuCauDatHang;
            }
            grid_tabPage_NCC_nhaCungCapPhuHop.Sort(grid_tabPage_NCC_nhaCungCapPhuHop.Columns["grid_NCCPhuHop_cSoLuongNguyenLieuThoaYeuCau"],ListSortDirection.Descending);
            grid_tabPage_NCC_nhaCungCapPhuHop.Columns["grid_NCCPhuHop_cSoLuongNguyenLieuThoaYeuCau"].ReadOnly = false;
        }

        private void grid_tabPage_NCC_nhaCungCapPhuHop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grid_tabPage_NCC_nhaCungCapPhuHop_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        private void grid_tabPage_NCC_nhaCungCapPhuHop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_tabPage_NCC_nhaCungCapPhuHop_CellDoubleClick(int indexSelectedRow)
        {
            //grid_tabPage_NCC_nhaCungCapPhuHop.Rows[indexSelectedRow].Cells[0].Value = !Convert.ToBoolean(grid_tabPage_NCC_nhaCungCapPhuHop.Rows[indexSelectedRow].Cells[0].Value);

            NhaCungCapDTO curNCC = (NhaCungCapDTO)grid_tabPage_NCC_nhaCungCapPhuHop.Rows[indexSelectedRow].Cells["grid_NCCPhuHop_cTenNhaCungCap"].Value;

            string sqlWHEREor = "";
            for (int i = 0; i < grid_nguyenLieuCanDatHang.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_nguyenLieuCanDatHang.Rows[i].Cells[0].Value) == true)
                {
                    MonAn_NguyenLieuDTO dto = (MonAn_NguyenLieuDTO)grid_nguyenLieuCanDatHang.Rows[i].Cells["grid_nguyenLieuCanDatHang_cNguyenLieu"].Value;
                    sqlWHEREor += "NCCNL.MaNguyenLieu=" + dto.NguyenLieu.MaNguyenLieu.ToString();
                    int j = i + 1;
                    sqlWHEREor += " OR ";
                }
            }
            sqlWHEREor = sqlWHEREor.Substring(0, sqlWHEREor.Length - 3);
            ArrayList dsNguyenLieuPhuHopTheoNCC = NhaCungCapBUS.layDanhSachNguyenLieuNhaCungCapCoTheDapUngTheoDonDatHang(curNCC.MaNhaCungCap, sqlWHEREor);
            curNCC.DsNguyenLieu = dsNguyenLieuPhuHopTheoNCC;//grid_nguyenLieuCanDatHang
            highlightNguyenLieuDaChonDuocNhaCungCapDapUng(curNCC);
        }
        private void grid_tabPage_NCC_nhaCungCapPhuHop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < grid_nguyenLieuCanDatHang.RowCount; i++)
                grid_nguyenLieuCanDatHang.Rows[i].DefaultCellStyle.BackColor = Color.White;
            
            grid_tabPage_NCC_nhaCungCapPhuHop.CurrentRow.Cells[0].Value = !Convert.ToBoolean(grid_tabPage_NCC_nhaCungCapPhuHop.CurrentRow.Cells[0].Value);
            for (int i = 0; i < grid_tabPage_NCC_nhaCungCapPhuHop.RowCount; i++)
            {

                if (Convert.ToBoolean(grid_tabPage_NCC_nhaCungCapPhuHop.Rows[i].Cells[0].Value) == true)
                    grid_tabPage_NCC_nhaCungCapPhuHop_CellDoubleClick(i);
            }
        }
        private void highlightNguyenLieuDaChonDuocNhaCungCapDapUng(NhaCungCapDTO dto)
        {
            ArrayList temp = dto.DsNguyenLieu;
            int soDongGrid_nguyenLieuCanDatHang = grid_nguyenLieuCanDatHang.RowCount;
            for (int i = 0; i < soDongGrid_nguyenLieuCanDatHang; i++)
            {
                if (Convert.ToBoolean(grid_nguyenLieuCanDatHang.Rows[i].Cells[0].Value) == true)
                {
                    for (int j = 0; j < temp.Count; j++)
                    {
                        NguyenLieuDTO nlNCC = (NguyenLieuDTO)temp[j];
                        MonAn_NguyenLieuDTO nlCanDatHang = (MonAn_NguyenLieuDTO)grid_nguyenLieuCanDatHang.Rows[i].Cells["grid_nguyenLieuCanDatHang_cNguyenLieu"].Value;

                        if (nlNCC.MaNguyenLieu == nlCanDatHang.NguyenLieu.MaNguyenLieu)
                        {
                            grid_nguyenLieuCanDatHang.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                        }
                    }
                }
            }
        }
        private void grid_tabPage_NCC_nhaCungCapPhuHop_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid_chiTietPhieuDat.Rows.Clear();
            for (int i = 0; i < grid_tabPage_NCC_nhaCungCapPhuHop.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_tabPage_NCC_nhaCungCapPhuHop.Rows[i].Cells[0].Value) == true)
                {
                    NhaCungCapDTO nccDTO = (NhaCungCapDTO)grid_tabPage_NCC_nhaCungCapPhuHop.Rows[i].Cells["grid_NCCPhuHop_cTenNhaCungCap"].Value;
                    for (int j = 0; j < nccDTO.DsNguyenLieu.Count; j++)
                    {
                        NguyenLieuDTO nlDTO = (NguyenLieuDTO)nccDTO.DsNguyenLieu[j];
                        if (!inGrid_chiTietPhieuDatOrNot(nlDTO))
                        {
                            grid_chiTietPhieuDat.Rows.Add();

                            grid_chiTietPhieuDat.Rows[grid_chiTietPhieuDat.RowCount - 1].Cells["gridCTPhieuDatHang_cNCC"].Value = nccDTO;
                            grid_chiTietPhieuDat.Rows[grid_chiTietPhieuDat.RowCount - 1].Cells["gridCTPhieuDatHang_cNguyenLieu"].Value = nlDTO;
                        }
                    }
                }
            }
        }
        private bool inGrid_chiTietPhieuDatOrNot(NguyenLieuDTO dto)
        {
            for (int i = 0; i < grid_chiTietPhieuDat.RowCount; i++)
            {
                if (dto.MaNguyenLieu == ((NguyenLieuDTO)(grid_chiTietPhieuDat.Rows[i].Cells["gridCTPhieuDatHang_cNguyenLieu"].Value)).MaNguyenLieu)
                    return true;
            }
            return false;
        }
    }
}

