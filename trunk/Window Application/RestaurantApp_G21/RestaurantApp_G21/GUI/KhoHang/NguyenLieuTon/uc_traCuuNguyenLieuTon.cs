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
    public partial class uc_traCuuNguyenLieuTon : UserControl
    {
        public uc_traCuuNguyenLieuTon()
        {
            InitializeComponent();

            //load combo loai mon an
            accessory.initComboLoaiMonAn(cb_loaiMonAn);

            accessory.initButtonDockFillInPanelEx(panelEx1);
            
            showComboMonAn();
        }

        public void showComboMonAn()
        {
            //ArrayList dsMonAnTheoPhanLoaiMonAn = new ArrayList();
            //dsMonAnTheoPhanLoaiMonAn = PhanLoaiMonAnBUS.layDanhSachMonAnTheoPhanLoaiMonAn((LoaiMonAnDTO)cb_loaiMonAn.SelectedItem, GlobalVariables.maNhaHang);
            //cb_monAn.Items.Clear();
            accessory.initComboMonAnTheoPhanLoai(cb_loaiMonAn, cb_monAn);
        }

        private void bt_lapPhieuDatHang_Click(object sender, EventArgs e)
        {
            fm_PhieuDatHang fm = new fm_PhieuDatHang();
            fm.Show();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            fm_nguyenLieu fm = new fm_nguyenLieu();
            //fm.NgLieu = null;
            fm.Show();
        }

        private void layChiTietKhoHangNguyenLieuDTO(KhoHang_NguyenLieuDTO dto, int rowOfGrid)
        {
            //dto.NguyenLieu.TenNguyenLieu = grid_ds.Rows[rowOfGrid].Cells["cTenNguyenLieu"].Value.ToString();
            //quan ly kho ko dc sua ten nguyen lieu, anh huong toi nhung nha hang khac
            dto.SoLuongTon = Convert.ToInt32(grid_ds.Rows[rowOfGrid].Cells["cLuongTon"].Value);
            dto.SucChua = Convert.ToInt32(grid_ds.Rows[rowOfGrid].Cells["cToiDa"].Value);
            dto.MucTonToiThieu = Convert.ToInt32(grid_ds.Rows[rowOfGrid].Cells["cToiThieu"].Value);
            //dto.NguyenLieu.DonViTinh = grid_ds.Rows[rowOfGrid].Cells["cDonViTinh"].Value.ToString();
            //ko dc sua, anh huong toi nha hang khac
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            GUI.accessory.readOnlyCheckedRows(grid_ds, false);
            GUI.accessory.readOnlyCheckedSomeCells(grid_ds, true,1);//ma nguyen lieu
            GUI.accessory.readOnlyCheckedSomeCells(grid_ds, true,4);//con trong
            bt_sua.Text = "Cập nhật";
            bt_sua.Click += new EventHandler(bt_capNhat_Click);
        }
        private void bt_capNhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_ds.Rows[i].Cells[0].Value) == true)
                {
                    KhoHang_NguyenLieuDTO updateDTO = (KhoHang_NguyenLieuDTO)grid_ds.Rows[i].Cells["cMaNguyenLieu"].Value;
                    layChiTietKhoHangNguyenLieuDTO(updateDTO, i);
                    int kq = KhoHang_NguyenLieuBUS.capNhatChiTietKhoHangNguyenLieu(updateDTO, GlobalVariables.maNhaHang);
                    if (kq == 0)
                    {
                        MessageBox.Show("Không cập nhật được dòng thứ " + (i + 1).ToString(), "[!]Thông báo");
                        return;
                    }
                }
            }
            //lam tuoi danh sach sau khi da cap nhat thanh cong
            lamTuoiDanhSachTraCuuNguyenLieu();

            GUI.accessory.readOnlyCheckedRows(grid_ds, true);
            bt_sua.Text = "Sửa";
            bt_sua.Click += new EventHandler(bt_sua_Click);
        }

        private void bt_chonTatCa_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_ds, true);
            bt_chonTatCa.Text = "Bỏ chọn";
            bt_chonTatCa.Click += new EventHandler(bt_boChon_Click);

        }
        private void bt_boChon_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_ds, false);
            bt_chonTatCa.Text = "Chọn tất cả";
            bt_chonTatCa.Click += new EventHandler(bt_chonTatCa_Click);
        }

        private void cb_loaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            showComboMonAn();
            cb_monAn_SelectedIndexChangedShowGridKetQua();
        }

        private void cb_monAn_SelectedIndexChangedShowGridKetQua()
        {
            grid_ds.Rows.Clear();
            if (cb_monAn.Items.Count == 0)
                return;
            if (cb_monAn.SelectedIndex != 0)
                showDanhSachNguyenLieuTheoMonAn(((PhanLoaiMonAnDTO)cb_monAn.SelectedItem).MonAn);
            else if(cb_monAn.SelectedIndex == 0)
            {
                for(int i=1;i<cb_monAn.Items.Count;i++)
                    showDanhSachNguyenLieuTheoMonAn(((PhanLoaiMonAnDTO)cb_monAn.Items[i]).MonAn);
            }
            lb_soLuongKQ.Text = grid_ds.RowCount.ToString();
        }
        private void cb_monAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_monAn_SelectedIndexChangedShowGridKetQua();
            
        }
        private void showDanhSachNguyenLieuTheoMonAn(MonAnDTO monAn)
        {
            ArrayList dsNguyenLieuTheoMon = new ArrayList();
            dsNguyenLieuTheoMon = MonAnBUS.layDanhSachNguyenLieuTheoMonAn(monAn);


            for (int i = 0; i < dsNguyenLieuTheoMon.Count; i++)
            {
                ArrayList dsKQ = new ArrayList();
                dsKQ = KhoHangBUS.layDSKhoHang_NguyenLieu(GlobalVariables.maNhaHang, ((MonAn_NguyenLieuDTO)dsNguyenLieuTheoMon[i]).NguyenLieu);

                for (int j = 0; j < dsKQ.Count; j++)
                {
                    KhoHang_NguyenLieuDTO dto = (KhoHang_NguyenLieuDTO)dsKQ[j];
                    if (!ingrid_dsOrNot(dto))
                    {
                        grid_ds.Rows.Add();
                        showThongTinKhoHang_NguyenLieuDTOLenGrid(grid_ds.RowCount - 1, dto);
                    }
                }
            }
            
        }

        private void timKiemNguyenLieuGanDung(NguyenLieuDTO nl)
        {
            ArrayList ds = new ArrayList();
            ds = KhoHangBUS.layDSKhoHang_NguyenLieu(GlobalVariables.maNhaHang, nl);
            //MessageBox.Show(ds.Count.ToString());
            for (int i = 0; i < ds.Count; i++)
            {
                KhoHang_NguyenLieuDTO dto = (KhoHang_NguyenLieuDTO)ds[i];
                if (!ingrid_dsOrNot(dto))
                {
                    grid_ds.Rows.Add();
                    showThongTinKhoHang_NguyenLieuDTOLenGrid(grid_ds.RowCount - 1, dto);
                }
            }
        }
        private bool ingrid_dsOrNot(KhoHang_NguyenLieuDTO dto)
        {
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                if (dto.NguyenLieu.MaNguyenLieu == ((KhoHang_NguyenLieuDTO)grid_ds.Rows[i].Cells["cMaNguyenLieu"].Value).NguyenLieu.MaNguyenLieu)
                    return true;
            }
            return false;
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
            grid_ds.Rows[row].Cells["cToiDa"].Value = dto.SucChua;
            
        }
        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            if (txt_ten.Text != "")
            {
                NguyenLieuDTO nguyenLieuCanTim = new NguyenLieuDTO();
                nguyenLieuCanTim.TenNguyenLieu = txt_ten.Text;
                
                grid_ds.Rows.Clear();
                timKiemNguyenLieuGanDung(nguyenLieuCanTim);
            }
            else
            {
                cb_monAn_SelectedIndexChangedShowGridKetQua();
            }
            lb_soLuongKQ.Text = grid_ds.RowCount.ToString();
        }

        private void lamTuoiDanhSachTraCuuNguyenLieu()
        {
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                KhoHang_NguyenLieuDTO dto = new KhoHang_NguyenLieuDTO();
                //dto.NguyenLieu.MaNguyenLieu = ((KhoHang_NguyenLieuDTO)grid_ds.Rows[i].Cells["cTenNguyenLieu"].Value).NguyenLieu.MaNguyenLieu;
                dto.NguyenLieu.MaNguyenLieu = Convert.ToInt32(grid_ds.Rows[i].Cells["cMaNguyenLieu"].Value.ToString());
                dto = KhoHangBUS.layChiTietKhoHang_NguyenLieu(GlobalVariables.maNhaHang, dto.NguyenLieu);
                if (dto != null)
                {
                    //gan lai gia tri moi(neu co thay doi) len dong hien tai
                    showThongTinKhoHang_NguyenLieuDTOLenGrid(i, dto);
                }
            }
        }
        private void bt_lamTuoi_Click(object sender, EventArgs e)
        {
            lamTuoiDanhSachTraCuuNguyenLieu();
            GUI.accessory.readOnlyCheckedRows(grid_ds, true);
            bt_sua.Text = "Sửa";
            bt_sua.Click += new EventHandler(bt_sua_Click);
            accessory.readOnlyCheckedRows(grid_ds, true);
        }

        private void grid_ds_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_ds_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void grid_ds_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (grid_ds.SelectedRows.Count == 0)
                return;
            KhoHang_NguyenLieuDTO dtoPre = (KhoHang_NguyenLieuDTO)grid_ds.CurrentRow.Cells["cMaNguyenLieu"].Value;
            try
            {
                int luongTonPre = dtoPre.SoLuongTon;
                int conTrong = Convert.ToInt32(grid_ds.CurrentRow.Cells["cToiDa"].Value) - Convert.ToInt32(grid_ds.CurrentRow.Cells["cLuongTon"].Value);
                if (conTrong < 0)
                {
                    MessageBox.Show("Lượng tồn vượt quá Sức Chứa.", "[!]Thông Báo");
                    bt_sua.Enabled = false;
                    grid_ds.CurrentCell.Value = luongTonPre;
                    return;
                }
                else
                {
                    grid_ds.CurrentRow.Cells["cConTrong"].Value = conTrong;
                    bt_sua.Enabled = true;
                }

            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return;
            }
        }

        private void panelEx1_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void panelEx1_Resize(object sender, EventArgs e)
        {
            accessory.initButtonDockFillInPanelEx(panelEx1);
        }

    }
}
