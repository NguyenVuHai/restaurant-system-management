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
    public partial class uc_traCuuNCC : UserControl
    {
        public uc_traCuuNCC()
        {
            InitializeComponent();
            accessory.initButtonDockFillInPanel(panel2);
            cb_tinhTrangNo.SelectedIndex = cb_tinTrangGiaoDich.SelectedIndex =0;
            cb_demoXungDot.SelectedIndex = cb_demoXungDot.Items.Count - 1;
        }

        private void gv_ds_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showFormNCC_ChiTiet(false);
        }
        private void showFormNCC_ChiTiet(bool loaiThaoTac)
        {
            fm_NCC_ChiTiet fm = new fm_NCC_ChiTiet();
            fm.LoaiThaoTac = loaiThaoTac;
            fm.Show();
        }
        private void layThongTinNhaCungCapDTO(NhaCungCapDTO dto, int indexRow)
        {
            dto.TenNhaCungCap = grid_ds.Rows[indexRow].Cells["cTenNhaCungCap"].Value.ToString();
            dto.DienThoai = grid_ds.Rows[indexRow].Cells["cDienThoai"].Value.ToString();
            dto.SoTaiKhoan = grid_ds.Rows[indexRow].Cells["cSoTaiKhoan"].Value.ToString();
        }
        private void bt_sua_Click(object sender, EventArgs e)//tam thoi chi dung de them ncc moi
        {
            //int totalSelectedRows = grid_ds.SelectedRows.Count;
            //if (totalSelectedRows != 1)
            //{
            //    MessageBox.Show("Mỗi lần chỉ được sửa thông tin của 1 NCC", "[!]Thông báo");
            //    return;
            //}
            //showFormNCC_ChiTiet(true);
            if (bt_them.Enabled == true)
                return;
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                if (Convert.ToBoolean(grid_ds.Rows[i].Cells[0].Value) == true)
                {
                    //NhaCungCapDTO updateDTO = (NhaCungCapDTO)grid_ds.Rows[i].Cells["cMaNguyenLieu"].Value;
                    NhaCungCapDTO updateDTO = new NhaCungCapDTO();
                    layThongTinNhaCungCapDTO(updateDTO, i);
                    int kq=0;

                    if(cb_demoXungDot.SelectedIndex==4)//PHANTOM
                        kq = NhaCungCapBUS.phantomThemMoi(updateDTO);
                    if (cb_demoXungDot.SelectedIndex == 5)//PHANTOM SOLVED
                        kq = NhaCungCapBUS.phantomSolvedThemMoi(updateDTO);
                    else
                        kq = NhaCungCapBUS.themMoi(updateDTO);

                    if (kq != 1)
                    {
                        MessageBox.Show("Không thành công được dòng thứ " + (i + 1).ToString(), "[!]Thông báo");
                        return;
                    }
                    bt_them.Enabled = true;
                }
            }
            //lam tuoi danh sach
        }

        private void bt_chonAll_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_ds, true);
            bt_chonAll.Text = "Bỏ chọn";
            bt_chonAll.Click += new EventHandler(bt_boChon_Click);
        }
        private void bt_boChon_Click(object sender, EventArgs e)
        {
            GUI.accessory.checkAllRowsOfGrid(grid_ds, false);
            bt_chonAll.Text = "Chọn tất cả";
            bt_chonAll.Click += new EventHandler(bt_chonAll_Click);
        }
        private void checkAllRowsOfGrid(bool stt)
        {

        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            accessory.initButtonDockFillInPanel(panel2);
        }

        private void cb_tinTrangGiaoDich_SelectedIndexChanged()
        {
            grid_ds.Rows.Clear();
            
            int curIndex = cb_tinTrangGiaoDich.SelectedIndex;
            ArrayList dsNCC = new ArrayList();
            if (curIndex == 0)
            {
                dsNCC = KhoHangBUS.layDanhSachNhaCungCap(GlobalVariables.maNhaHang, txt_ten.Text);
            }
            else
            {
                if (curIndex == 1 || curIndex == 2)
                {
                    //dsNCC = KhoHangBUS.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(txt_ten.Text, curIndex, GlobalVariables.maNhaHang);
                    if (cb_demoXungDot.SelectedIndex == 0)//unrepeat
                        dsNCC = KhoHangBUS.unrepeatableTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(txt_ten.Text, curIndex, GlobalVariables.maNhaHang);
                    else if (cb_demoXungDot.SelectedIndex == 1)//unrepeat solved
                        dsNCC = KhoHangBUS.unrepeatableSolvedTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(txt_ten.Text, curIndex, GlobalVariables.maNhaHang);
                    else if (cb_demoXungDot.SelectedIndex == 2)//dirty read
                        dsNCC = KhoHangBUS.dirtyReadTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(txt_ten.Text, curIndex, GlobalVariables.maNhaHang);
                    else if (cb_demoXungDot.SelectedIndex == 3)//dirty read solved
                        dsNCC = KhoHangBUS.dirtyReadSolvedTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(txt_ten.Text, curIndex, GlobalVariables.maNhaHang);
                    else
                        dsNCC = KhoHangBUS.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichCoHoacNgung(txt_ten.Text, curIndex, GlobalVariables.maNhaHang);
                }
                if (curIndex == 3)
                {
                    if(cb_demoXungDot.SelectedIndex==4)//phantom
                        dsNCC = KhoHangBUS.phantomTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich(txt_ten.Text, GlobalVariables.maNhaHang);
                    else if (cb_demoXungDot.SelectedIndex == 5)//phantom solved 
                        dsNCC = KhoHangBUS.phantomSolvedTimKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich(txt_ten.Text, GlobalVariables.maNhaHang);
                    else
                        dsNCC = KhoHangBUS.timKiemNhaCungCapTheoTenVaTheoTinhTrangGiaoDichChuaTungGiaoDich(txt_ten.Text, GlobalVariables.maNhaHang);

                }
            }
            if (cb_tinTrangGiaoDich.SelectedIndex == 0)
            {
                for (int i = 0; i < dsNCC.Count; i++)
                {
                    NhaCungCapDTO dto = (NhaCungCapDTO)dsNCC[i];
                    grid_ds.Rows.Add();
                    grid_ds.Rows[i].Cells["cMaNhaCungCap"].Value = dto.MaNhaCungCap;
                    grid_ds.Rows[i].Cells["cTenNhaCungCap"].Value = dto;
                    grid_ds.Rows[i].Cells["cDienThoai"].Value = dto.DienThoai;
                    grid_ds.Rows[i].Cells["cSoTaiKhoan"].Value = dto.SoTaiKhoan;
                    grid_ds.Rows[i].Cells["cTongNo"].Value = dto.TongNo;
                    if (dto.TinhTrangGiaoDich == 1)
                        grid_ds.Rows[i].Cells["cGiaoDich"].Value = "Có";
                    else if (dto.TinhTrangGiaoDich == 0)
                        grid_ds.Rows[i].Cells["cGiaoDich"].Value = "Ngừng";
                    else
                        grid_ds.Rows[i].Cells["cGiaoDich"].Value = "Chưa từng";
                }
            }
            else
            {
                for (int i = 0; i < dsNCC.Count; i++)
                {
                    NhaCungCapDTO dto = (NhaCungCapDTO)dsNCC[i];
                    grid_ds.Rows.Add();
                    grid_ds.Rows[i].Cells["cMaNhaCungCap"].Value = dto.MaNhaCungCap;
                    grid_ds.Rows[i].Cells["cTenNhaCungCap"].Value = dto;
                    grid_ds.Rows[i].Cells["cDienThoai"].Value = dto.DienThoai;
                    grid_ds.Rows[i].Cells["cSoTaiKhoan"].Value = dto.SoTaiKhoan;
                    grid_ds.Rows[i].Cells["cTongNo"].Value = dto.TongNo;
                    grid_ds.Rows[i].Cells["cGiaoDich"].Value = cb_tinTrangGiaoDich.Text;
                }
            }
        }
        private void cb_tinTrangGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_tinTrangGiaoDich_SelectedIndexChanged();
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            cb_tinTrangGiaoDich_SelectedIndexChanged();
        }

        private void bt_ngungGiaoDich_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_ds.RowCount; i++)
            {
                decimal tongNo = Convert.ToDecimal(grid_ds.Rows[i].Cells["cTongNo"].Value);
                if (Convert.ToBoolean(grid_ds.Rows[i].Cells["cb"].Value) == true && tongNo == 0)
                {
                    int kq = 0;
                    int maNhaCungCap = Convert.ToInt32(grid_ds.Rows[i].Cells["cMaNhaCungCap"].Value);
                    
                    if(cb_demoXungDot.SelectedIndex==2)//DIRTY READ
                        kq = NhaCungCapBUS.dirtyReadSetNgungGiaoDich(maNhaCungCap, GlobalVariables.maNhaHang, 0);
                    else if (cb_demoXungDot.SelectedIndex == 3)//DIRTY READ SOLVED
                        kq = NhaCungCapBUS.dirtyReadSolvedSetNgungGiaoDich(maNhaCungCap, GlobalVariables.maNhaHang, 0);
                    else //KHONG DUNG XUNG DOT
                        kq = NhaCungCapBUS.setNgungGiaoDich(maNhaCungCap, GlobalVariables.maNhaHang, 0);
                    
                    if (kq == -1)
                    {
                        MessageBox.Show("Có lỗi trong khi cập nhật dữ liệu.\nThao tác bị ROLLBACK!");
                        return;
                    }
                    if (kq==0 )
                    {
                        MessageBox.Show("Thao tác không thành công tại\nNhà cung cấp Mã: " + maNhaCungCap.ToString(), "[!] Thông báo");
                        return;
                    }
                    grid_ds.Rows[i].Cells["cGiaoDich"].Value = "Ngừng";
                    //MessageBox.Show("Ngừng giao dịch thành công!");
                }
                
            }
            cb_tinTrangGiaoDich_SelectedIndexChanged();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            grid_ds.Rows.Clear();
            bt_them.Enabled = false;
            grid_ds.Rows.Add();
            grid_ds.Rows[0].Cells[0].Value = true;
            grid_ds.Rows[0].Cells["cTenNhaCungCap"].ReadOnly = false;
            grid_ds.Rows[0].Cells["cDienThoai"].ReadOnly = false;
            grid_ds.Rows[0].Cells["cSoTaiKhoan"].ReadOnly = false;
        }

        private void grid_ds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void solvedTypeChanged()
        {

        }
        private void rad_unrepeatedSolved_CheckedChanged(object sender, EventArgs e)
        {
            solvedTypeChanged();
        }

        private void cb_demoXungDot_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loaiXungDot = cb_demoXungDot.SelectedIndex;

            if (loaiXungDot == 0)//repeat
            {
                //lay danh sach nha cung cap co giao dich
                //cb_tinTrangGiaoDich.SelectedIndex = 2;
                //cb_tinTrangGiaoDich_SelectedIndexChanged();
            }
            if (loaiXungDot == 1)//repeat solved
            {
                //lay danh sach nha cung cap co giao dich
                //cb_tinTrangGiaoDich.SelectedIndex = 2;
                //cb_tinTrangGiaoDich_SelectedIndexChanged();
            }
            if (loaiXungDot == 2)//dirty
            {
            }
            if (loaiXungDot == 3)//dirty solved
            {
            }
            if (loaiXungDot == 4 )//phantom
            {
                //cb_tinTrangGiaoDich.SelectedIndex = 3;
                //cb_tinTrangGiaoDich_SelectedIndexChanged();
            }
            if (loaiXungDot == 5)//phantom solved
            {
                //lay danh sach nha cung cap chua tung giao dich
                //cb_tinTrangGiaoDich.SelectedIndex = 3;
                //cb_tinTrangGiaoDich_SelectedIndexChanged();
            }
        }
    }
}
