using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.BUS;

namespace RestaurantApp_G21
{
    public partial class frmDatBan : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public List<ThongTinBanDTO> listBan = new List<ThongTinBanDTO>();
        private List<LoaiXungDotDTO> LoaiXungDot()
        {
            List<LoaiXungDotDTO> loaiXD = new List<LoaiXungDotDTO>();
            for (int i = -1; i < 4; i++)
            {
                loaiXD.Add(new LoaiXungDotDTO() { MaXungDot = i });
            }
            loaiXD[0].TenXungDot = "Chọn Loại Xung Đột";
            loaiXD[1].TenXungDot = "Đọc Dữ Liệu Rác";
            loaiXD[2].TenXungDot = "Mất Dữ Liệu Cập Nhật";
            loaiXD[3].TenXungDot = "Không Thể Đọc Lại";
            loaiXD[4].TenXungDot = "Bóng Ma";
            return loaiXD;
        }
        public void QuayVeTrangChu()
        {
            frmTrangChu frm = new frmTrangChu();
            frm.DisableCacChucNang(true, 3);
            frm.Show();
        }
        #region Utils Methods

        private void LoadDanhSachBanDat()
        {

            // List<BanDatDTO> listBD = BanDatBUS.ThongTinKhachVaBanDat();
            // dgvDanhSachBanDat.DataSource = listBD;
            //List<BanDatDTO> listBanDat = BanDatBUS.LayDanhSachBanDat();
            //dgvDanhSachBanDat.DataSource = listBanDat;
            SetValue(false, false);
            dgvDanhSachBanDat.DataSource = BanDatBUS.ThongTinKhachVaBanDat();
            //if(dgvDanhSachBanDat.Enabled == true)
            //dgvDanhSachBanDat.Enabled = false;            
            //dgvDanhSachBanDat.Columns["MaNhaHang"].Visible = false;
            //dgvDanhSachBanDat.Columns["TenBuoi"].Visible = false;
            //dgvDanhSachBanDat.Columns["MaLichBan"].Visible = false;
            //dgvDanhSachBanDat.Columns["MaThongTinKhachHang"].Visible = false;
            //dgvDanhSachBanDat.Columns["TinhTrang"].Visible = false;

        }
        public void SetValue(bool clear, bool enable)
        {
            if (clear == true)
            {
                txtCMND.Text = "";
                txtHoTenKhachHang.Text = "";
                txtSoDienThoai.Text = "";
                txtSoLuong.Text = "";
                txtMaBan.Text = "";
                txtKhuVuc.Text = "";
                dtNgayDatBan.Text = "";
                cbbBuoi.Text = "";
            }
            txtCMND.Enabled = txtHoTenKhachHang.Enabled = txtSoDienThoai.Enabled = txtSoLuong.Enabled = enable;
            txtMaBan.Enabled = txtKhuVuc.Enabled = dtNgayDatBan.Enabled = cbbBuoi.Enabled = enable;
        }
        private void LoadNhaHang()
        {
            m_cBoxNhaHang.Items.Clear();
            m_cBoxNhaHang.Items.Add("Chọn nhà hàng");
            List<NhaHangDTO> nhaHang = NhaHangBUS.LayDanhSachNhaHang();
            foreach (NhaHangDTO oNhaHang in nhaHang)
            {
                m_cBoxNhaHang.Items.Add(oNhaHang);
            }
            m_cBoxNhaHang.SelectedIndex = 0;
            m_cBoxNhaHang.ValueMember = "MaNhaHang";
            m_cBoxNhaHang.DisplayMember = "TenNhaHang";
        }

        private void LoadKhuVuc(int maNhaHang)
        {
            m_cBoxKhuVuc.Items.Clear();
            m_cBoxKhuVuc.Items.Add("Chọn khu vực");
            List<KhuVucDTO> khuVuc = KhuVucBUS.LayDanhSachKhuVuc(maNhaHang);
            foreach (KhuVucDTO oKhuVuc in khuVuc)
            {
                m_cBoxKhuVuc.Items.Add(oKhuVuc);
            }
            m_cBoxKhuVuc.SelectedIndex = 0;
            m_cBoxKhuVuc.ValueMember = "MaKhuVuc";
            m_cBoxKhuVuc.DisplayMember = "TenKhuVuc";
        }

        private bool KiemTraKhuVuc(int maKhuVuc)
        {
            foreach (var ban in listBan)
            {
                if (ban.MaKhuVuc == maKhuVuc) return true;
            }
            return false;
        }

        private void LoadBuoi(ComboBox cboxBuoi, int selectIndex)
        {
            try
            {
                cboxBuoi.Items.Clear();
                cboxBuoi.Items.Add("Chọn buổi");
                List<BuoiDTO> buoi = BuoiBUS.LayDanhSachBuoi();
                foreach (BuoiDTO oBuoi in buoi)
                {
                    cboxBuoi.Items.Add(oBuoi);
                }
                cboxBuoi.SelectedIndex = selectIndex;
                cboxBuoi.ValueMember = "MaBuoi";
                cboxBuoi.DisplayMember = "TenBuoi";
            }
            catch
            {
            }
        }
        private void LoadDL()
        {
            cboxLoaiXungDot.DisplayMember = "TenXungDot";
            cboxLoaiXungDot.ValueMember = "MaXungDot";
            cboxLoaiXungDot.DataSource = LoaiXungDot();

            cboChonLoaiXungDot.DisplayMember = "TenXungDot";
            cboChonLoaiXungDot.ValueMember = "MaXungDot";
            cboChonLoaiXungDot.DataSource = LoaiXungDot();
        }
        #endregion

        public frmDatBan()
        {
            InitializeComponent();
            m_mtTileDatBan.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            LoadDanhSachBanDat();
            LoadNhaHang();
            LoadBuoi(m_cboxTimBuoi, 0);
            LoadBuoi(cbbBuoi, 0);
            LoadHoaDon();
            LoadDL();
        }
        private void LoadHoaDon()
        {
            UserControl uc = new frmQuanLyHoaDon();
            uc.Dock = DockStyle.Fill;
            panelQuanLyHoaDOn.Controls.Add(uc);
        }

        public void LoadBanTrongKhuVuc()
        {
            m_tabCtrKhuVuc.Tabs.Clear();
            int maNhaHang = m_cBoxNhaHang.SelectedIndex == 0 ? 0 : ((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang;
            List<KhuVucDTO> dsKhuVuc = KhuVucBUS.LayDanhSachKhuVuc(maNhaHang);

            foreach (KhuVucDTO kv in dsKhuVuc)
            {
                if (KiemTraKhuVuc(kv.MaKhuVuc))
                {
                    TabItem tabI = new TabItem();
                    TabControlPanel tabCtrP = new TabControlPanel();
                    tabI.Name = "m_tabIKhuVuc" + kv.MaKhuVuc;
                    tabI.Text = kv.TenKhuVuc;
                    tabCtrP.Name = "m_tabCtrP" + kv.MaKhuVuc;
                    tabCtrP.AutoScroll = true;
                    tabCtrP.AutoSize = true;
                    tabCtrP.Dock = System.Windows.Forms.DockStyle.Fill;
                    tabCtrP.TabItem = tabI;// chỗ này là gán
                    tabI.AttachedControl = tabCtrP;

                    uCtr_KhuVuc khuvuc = new uCtr_KhuVuc(this, kv.MaKhuVuc);
                    khuvuc.MaximumSize = new Size(m_tabCtrKhuVuc.Width, 0);

                    tabCtrP.Controls.Add(khuvuc);
                    m_tabCtrKhuVuc.Controls.Add(tabCtrP); // chỗ này là add
                    m_tabCtrKhuVuc.Tabs.Add(tabI);
                }

            }
        }

        public void tabThongTinDatBan(string maBan, int maKhuVuc)
        {
            m_sTabItmTTBanDat.Visible = true;
            m_sTabCtrDatBan.SelectedTab = m_sTabItmTTBanDat;
            txtMaBan.Text = maBan;
            txtKhuVuc.Text = maKhuVuc.ToString();
            txtCMND.Text = "";
            txtHoTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtSoLuong.Text = "";
            dtNgayDatBan.Text = "";
            btnLuuThongTinDatBan.Enabled = true;
            LoadBuoi(cbbBuoi, m_cboxTimBuoi.SelectedIndex);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void m_btnTimNhaHang_Click(object sender, EventArgs e)
        {
            Form frm = new frmTimBan();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Show();
            LoadBanTrongKhuVuc();
        }

        private void m_btnTimBan_Click(object sender, EventArgs e)
        {
            try
            {
                int maNhaHang = 0;
                int maKhuVuc = 0;
                DateTime ngayDatBan = new DateTime();
                int buoi = 0;
                int soLuong = -1;

                maNhaHang = m_cBoxNhaHang.SelectedIndex == 0 ? 0 : ((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang;
                maKhuVuc = m_cBoxKhuVuc.SelectedIndex == 0 ? 0 : ((KhuVucDTO)m_cBoxKhuVuc.SelectedItem).MaKhuVuc;
                DateTime.TryParse(m_dateTimeInputNgayDatBan.Text, out ngayDatBan);
                buoi = cbbBuoi.SelectedIndex == 0 ? 0 : ((BuoiDTO)cbbBuoi.SelectedItem).MaBuoi;
                Int32.TryParse(m_txtTimSoLuong.Text, out soLuong);
                if (m_txtTimSoLuong.Text != "" && soLuong < 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ.");
                    m_txtTimSoLuong.Focus();
                    m_txtTimSoLuong.SelectAll();
                    return;
                }
                if (ngayDatBan == new DateTime() && m_dateTimeInputNgayDatBan.Text != "")
                {
                    MessageBox.Show("Ngày đặt bàn không hợp lệ.");
                    m_dateTimeInputNgayDatBan.Focus();
                    return;
                }
                switch (Convert.ToInt32(cboxLoaiXungDot.SelectedValue))
                {
                    case 0:

                        if (chkDirtyRead.Checked)
                        {
                            // Solved Dirty Read

                            listBan = ThongTinBanBUS.TimBanTrongSolvedDirtyRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                            LoadBanTrongKhuVuc();
                        }
                        else
                        {
                            // Dirty Read
                            listBan = ThongTinBanBUS.TimBanTrongDirtyRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                            LoadBanTrongKhuVuc();
                        }
                        break;
                    case 2:
                        if (chkUnRead.Checked)
                        {
                            // Solved UnRRead
                            listBan = ThongTinBanBUS.TimBanTrongSolvedUnRRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                            LoadBanTrongKhuVuc();
                        }
                        else
                        {
                            // UnRRead
                            listBan = ThongTinBanBUS.TimBanTrongUnRRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                            LoadBanTrongKhuVuc();
                        }
                        break;
                    case 3:
                        if (chhkBongMa.Checked)
                        {
                            listBan = ThongTinBanBUS.TimBanTrongSolvedPhanTom(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                            LoadBanTrongKhuVuc();
                        }
                        else
                        {
                            listBan = ThongTinBanBUS.TimBanTrongPhanTom(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                            LoadBanTrongKhuVuc();
                        }
                        break;
                    default:
                        listBan = ThongTinBanBUS.TimBanTrong(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                        LoadBanTrongKhuVuc();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_cBoxNhaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maNhaHang = 0;
            if (m_cBoxNhaHang.SelectedIndex != 0)
            {
                maNhaHang = ((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang;
            }
            LoadKhuVuc(maNhaHang);
        }

        private void btnLuuThongTinDatBan_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Thêm mới thông tin khách click check Đặt Bàn - Cập Nhật Thông Tin Khách bỏ Check Đặt Bàn");
            try
            {
                int loai = chkDatBan.Checked == true ? 1 : 0;
                btnThem.Enabled = true;
                if (chkDatBan.Checked)
                {
                    if (txtCMND.Text == String.Empty || txtHoTenKhachHang.Text == string.Empty || txtSoDienThoai.Text == string.Empty || dtNgayDatBan.Text == string.Empty || cbbBuoi.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin");
                    }
                    if (txtCMND.Text == "%" || txtCMND.Text.IndexOf("'") >= 0 || txtCMND.Text.IndexOf("`") >= 0)
                    {
                        MessageBox.Show("Không Hợp Lệ");
                    }
                    if (txtHoTenKhachHang.Text == "%" || txtHoTenKhachHang.Text.IndexOf("'") >= 0 || txtHoTenKhachHang.Text.IndexOf("`") >= 0)
                    {
                        MessageBox.Show("Không Hợp Lệ");
                    }
                    if (txtSoDienThoai.Text == "%" || txtSoDienThoai.Text.IndexOf("'") >= 0 || txtSoDienThoai.Text.IndexOf("`") >= 0)
                    {
                        MessageBox.Show("Không Hợp Lệ");
                    }

                    BanDatDTO banDat = new BanDatDTO()
                    {
                        HoTen = txtHoTenKhachHang.Text,
                        Cmnd = txtCMND.Text,
                        DienThoai = txtSoDienThoai.Text,
                        MaBan = Int32.Parse(txtMaBan.Text),
                        MaBuoi = (int)((BuoiDTO)cbbBuoi.SelectedItem).MaBuoi,
                        NgayDatBan = dtNgayDatBan.Value,
                        SoLuong = Int32.Parse(txtSoLuong.Text),
                        TinhTrangBan = !chkDatBan.Checked
                    };
                    if (Convert.ToInt32(cboChonLoaiXungDot.SelectedValue) == 3)
                    {
                        if (chkXLBongMa.Checked)
                        {
                            BanDatBUS.ThemThongTinKhachVaBanDatPhanTom(banDat, loai);
                        }
                        //LoadDanhSachBanDat();
                    }
                    BanDatBUS.ThemThongTinBanDat(banDat, loai);
                }
                else
                {
                    //Cap nhat thong tin ban dat
                    int maBuoi = (int)((BuoiDTO)cbbBuoi.SelectedItem).MaBuoi;
                    int soLuong = Int32.Parse(txtSoLuong.Text);
                    DateTime ngay = dtNgayDatBan.Value;
                    // BanDatBUS.CapNhatThongTinKhachBanDatUnRRead(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                    switch (Convert.ToInt32(cboChonLoaiXungDot.SelectedValue))
                    {
                        case 0:
                            BanDatBUS.CapNhatThongTinBanDat(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                            //LoadDanhSachBanDat();
                            break;
                        case 1: // trường hợp mất dữ liệu cập nhật
                            if (chkXLMatDLCapNhat.Checked)
                            {
                                // xử lý
                                BanDatBUS.CapNhatThongTinBanDatSolvedLostUpdate(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                            }
                            else
                            {
                                if (chkDocMatDLCapNhat.Checked)
                                {
                                    // đọc dữ liệu sai , stored t2 chưa giải quyết
                                    BanDatBUS.CapNhatThongTinBanDatKoXuLyLostUpdate(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                                }
                                // T2 đã giải quyết
                                BanDatBUS.CapNhatThongTinBanDatLostUpdate(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                            }
                            break;
                        case 2:
                            BanDatBUS.CapNhatThongTinKhachBanDatUnRRead(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                            // LoadDanhSachBanDat();
                            break;
                        case 3:
                            BanDatBUS.CapNhatThongTinKhachBanDatPhanTom(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                            break;

                        default:
                            BanDatBUS.CapNhatThongTinKhachBanDatDefault(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                            // LoadDanhSachBanDat();
                            break;
                    }
                }
                LoadDanhSachBanDat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Chức Năng Này Chưa Hoàn Thiện");
            //BanDatBUS.HuyThongTinKhachVaBanDatUnRRead(GlobalVariables.maLichBan);
            //m_sTabItmTTBanDat.Visible = false;
            //m_sTabCtrDatBan.SelectedTab = m_sTabItmTTBanDat;

        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            dgvDanhSachBanDat.Enabled = true;
            btnThem.Enabled = false;
            btnLuuThongTinDatBan.Enabled = true;
            //dgvDanhSachBanDat.Rows[0].Selected = true;
            //this.Refresh();
            //dgvDanhSachBanDat.DataSource = BanDatBUS.ThongTinKhachVaBanDat();
        }

        // Tranh Chấp Đồng Thời

        private void btnLostUpDate_Click(object sender, EventArgs e)
        {
            try
            {
                int loai = chkDatBan.Checked == true ? 1 : 0;
                int maBuoi = (int)((BuoiDTO)cbbBuoi.SelectedItem).MaBuoi;
                int soLuong = Int32.Parse(txtSoLuong.Text);
                DateTime ngay = dtNgayDatBan.Value;
                if (chkDatBan.Checked)
                {
                    if (txtCMND.Text == String.Empty)
                    {
                        MessageBox.Show("Nhập chứng minh nhân dân.");
                        return;
                    }

                    BanDatDTO banDat = new BanDatDTO()
                    {
                        HoTen = txtHoTenKhachHang.Text,
                        Cmnd = txtCMND.Text,
                        DienThoai = txtSoDienThoai.Text,
                        MaBan = Int32.Parse(txtMaBan.Text),
                        MaBuoi = (int)((BuoiDTO)cbbBuoi.SelectedItem).MaBuoi,
                        NgayDatBan = dtNgayDatBan.Value,
                        SoLuong = Int32.Parse(txtSoLuong.Text),
                        TinhTrangBan = !chkDatBan.Checked
                    };
                    BanDatBUS.ThemThongTinBanDat(banDat, loai);
                }
                else
                {
                    //Cap nhat thong tin ban dat T1
                    if (chkXLMatDLCapNhat.Checked)
                    {
                        BanDatBUS.CapNhatThongTinBanDatSolvedLostUpdate(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                    }
                    if (chkXLMatDLCapNhat.Checked)
                    {
                        // BanDatBUS.CapNhatThongTinBanDatLostUpdate(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                    }
                    // BanDatBUS.CapNhatThongTinBanDatLostU(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                }
                LoadDanhSachBanDat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuyBanDat_Click(object sender, EventArgs e)
        {
            int maBuoi = (int)((BuoiDTO)cbbBuoi.SelectedItem).MaBuoi;
            int soLuong = Int32.Parse(txtSoLuong.Text);
            DateTime ngay = dtNgayDatBan.Value;
            try
            {
                BanDatBUS.CapNhatThongTinKhachBanDatUnRRead(GlobalVariables.maLichBan, maBuoi, ngay, soLuong);
                LoadDanhSachBanDat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void superTabControlPanel2_Click(object sender, EventArgs e)
        {

        }
        // UnRRead đã xóa
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                int maNhaHang = 0;
                int maKhuVuc = 0;
                DateTime ngayDatBan = new DateTime();
                int buoi = 0;
                int soLuong = -1;

                maNhaHang = m_cBoxNhaHang.SelectedIndex == 0 ? 0 : ((NhaHangDTO)m_cBoxNhaHang.SelectedItem).MaNhaHang;
                maKhuVuc = m_cBoxKhuVuc.SelectedIndex == 0 ? 0 : ((KhuVucDTO)m_cBoxKhuVuc.SelectedItem).MaKhuVuc;
                DateTime.TryParse(m_dateTimeInputNgayDatBan.Text, out ngayDatBan);
                buoi = cbbBuoi.SelectedIndex == 0 ? 0 : ((BuoiDTO)cbbBuoi.SelectedItem).MaBuoi;
                Int32.TryParse(m_txtTimSoLuong.Text, out soLuong);
                if (m_txtTimSoLuong.Text != "" && soLuong < 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ.");
                    m_txtTimSoLuong.Focus();
                    m_txtTimSoLuong.SelectAll();
                    return;
                }
                if (ngayDatBan == new DateTime() && m_dateTimeInputNgayDatBan.Text != "")
                {
                    MessageBox.Show("Ngày đặt bàn không hợp lệ.");
                    m_dateTimeInputNgayDatBan.Focus();
                    return;
                }
                if (chkXLKoDocLai.Checked)
                {
                    // Solved UnRRead

                    listBan = ThongTinBanBUS.TimBanTrongSolvedUnRRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                    LoadBanTrongKhuVuc();
                }
                else
                {
                    // UnRRead
                    listBan = ThongTinBanBUS.TimBanTrongUnRRead(maNhaHang, maKhuVuc, ngayDatBan, buoi, soLuong);
                    LoadBanTrongKhuVuc();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxLoaiXungDot_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (Convert.ToInt32(cboxLoaiXungDot.SelectedValue))
            {
                case 0:
                    chkUnRead.Enabled = chhkBongMa.Enabled = false;
                    chkUnRead.Checked = chhkBongMa.Checked = false;
                    chkDirtyRead.Enabled = true;
                    chkDirtyRead.Checked = true;
                    break;
                //         loaiXD[0].TenXungDot = "Chọn Loại Xung Đột";
                //loaiXD[1].TenXungDot = "Đọc Dữ Liệu Rác";
                //loaiXD[2].TenXungDot = "Mất Dữ Liệu Cập Nhật";
                //loaiXD[3].TenXungDot = "Không Thể Đọc Lại";
                //loaiXD[4].TenXungDot = "Bóng Ma";
                case 2:
                    chkDirtyRead.Enabled = chhkBongMa.Enabled = false;
                    chkDirtyRead.Checked = chhkBongMa.Checked = false;
                    chkUnRead.Enabled = true;
                    chkUnRead.Checked = true;
                    break;

                case 3:
                    chkDirtyRead.Enabled = chkUnRead.Enabled = false;
                    chkDirtyRead.Checked = chkUnRead.Checked = false;
                    chhkBongMa.Enabled = true;
                    chhkBongMa.Checked = true;
                    break;

                default:
                    chkDirtyRead.Enabled = chkUnRead.Enabled = chhkBongMa.Enabled = false;
                    chkDirtyRead.Checked = chkUnRead.Checked = chhkBongMa.Checked = false;
                    break;



            }
            // MessageBox.Show(cboxLoaiXungDot.SelectedValue.ToString());
        }

        private void cboChonLoaiXungDot_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(cboChonLoaiXungDot.SelectedValue))
            {   // rác
                case 0:
                    chkXLBongMa.Enabled = chkXLKoDocLai.Enabled = chkXLMatDLCapNhat.Enabled = false;
                    chkXLRac.Enabled = true;
                    chkXLBongMa.Checked = chkXLKoDocLai.Checked = chkXLMatDLCapNhat.Checked = false;
                    chkXLRac.Checked = true;
                    break;
                // mất dữ cập nhật
                case 1:
                    chkXLBongMa.Enabled = chkXLKoDocLai.Enabled = chkXLRac.Enabled = false;
                    chkXLMatDLCapNhat.Enabled = true;

                    chkXLBongMa.Checked = chkXLKoDocLai.Checked = chkXLRac.Checked = false;
                    chkXLMatDLCapNhat.Checked = true;
                    break;
                // Không thể đọc lại
                case 2:
                    chkXLBongMa.Enabled = chkXLMatDLCapNhat.Enabled = chkXLRac.Enabled = false;
                    chkXLKoDocLai.Enabled = true;

                    chkXLBongMa.Checked = chkXLMatDLCapNhat.Checked = chkXLRac.Checked = false;
                    chkXLKoDocLai.Checked = true;
                    break;
                // Bóng ma
                case 3:
                    chkXLKoDocLai.Enabled = chkXLMatDLCapNhat.Enabled = chkXLRac.Enabled = false;
                    chkXLBongMa.Enabled = true;

                    chkXLKoDocLai.Checked = chkXLMatDLCapNhat.Checked = chkXLRac.Checked = false;
                    chkXLBongMa.Checked = true;
                    break;
                default:
                    chkXLKoDocLai.Enabled = chkXLMatDLCapNhat.Enabled = chkXLRac.Enabled = false;
                    chkXLBongMa.Enabled = false;

                    // chkXLKoDocLai.Checked = chkXLMatDLCapNhat.Checked = chkXLRac.Checked = false;
                    //  chkXLBongMa.Checked = true;
                    break;

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetValue(true, true);
            txtMaBan.Enabled = true;
            txtKhuVuc.Enabled = true;
            btnLuuThongTinDatBan.Enabled = true;

        }
        private void EnableEditing(bool editing1)
        {
            // button
            // Khi đang thêm thì nút thêm cũng sẽ ẩn đi
            btnThem.Enabled = !editing1;
            //FbtnThayDoi.Enabled = !editing1;
            btnHuy.Enabled = !editing1;
            btnLuuThongTinDatBan.Enabled = editing1;
            //m_txtDiaChi.Enabled = editing1;
            //m_txtMaNH.Enabled = !editing;
            //m_txtSoDT.Enabled = editing1;
            // m_txtTenNH.Enabled = editing1;

            // m_dtGNhaHang.Enabled = !editing1;
        }

        private void frmDatBan_Load(object sender, EventArgs e)
        {
            EnableEditing(false);
            SetValue(false, false);
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            SetValue(false, true);
            //dgvDanhSachBanDat.Enabled = true;
            btnThem.Enabled = false;
            btnLuuThongTinDatBan.Enabled = true;
        }

        private void m_mtTileHome_Click(object sender, EventArgs e)
        {
            QuayVeTrangChu();
        }

        private void dgvDanhSachBanDat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachBanDat_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dong = dgvDanhSachBanDat.CurrentRow;
            if (dong == null)
                return;
            try
            {
                if (dong.DataBoundItem != null)
                {

                    txtHoTenKhachHang.Text = dong.Cells["HoTen"].Value.ToString();
                    txtCMND.Text = dong.Cells["CMND"].Value.ToString();
                    txtSoDienThoai.Text = dong.Cells["DienThoai"].Value.ToString();
                    dtNgayDatBan.Text = dong.Cells["NgayDatBan"].Value.ToString();
                    cbbBuoi.Text = dong.Cells["TenBuoi"].Value.ToString();
                    txtSoLuong.Text = dong.Cells["SoLuong"].Value.ToString();
                    txtMaBan.Text = dong.Cells["MaBan"].Value.ToString();
                    txtKhuVuc.Text = dong.Cells["MaKhuVuc"].Value.ToString();
                    //txtTinhTrang.Text = dgvDanhSachBanDat.Rows[dong].Cells["TinhTrangBan"].Value.ToString();

                    GlobalVariables.maLichBan = Int32.Parse(dong.Cells["MaLichBan"].Value.ToString());
                    GlobalVariables.maKhachHang = Int32.Parse(dong.Cells["MaThongTinKhachHang"].Value.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmNhaHang frm = new frmNhaHang();
            frm.ShowDialog();

        }
        private void m_mtTileCongTy_Click(object sender, EventArgs e)
        {

        }

        private void m_mtHThong_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmHeThong frm = new frmHeThong();
            frm.ShowDialog();
        }

        private void m_mtTieKhoHang_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmKhoHang frm = new frmKhoHang();
            frm.ShowDialog();
        }

        private void m_mtTileNhaHang_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmQuanLyNhanVien frm = new FrmQuanLyNhanVien();
            frm.ShowDialog();
        }

        private void panelEx1_Resize(object sender, EventArgs e)
        {
            panelEx2.Location = new Point((panelEx1.Width / 2 - panelEx2.Width / 2), panelEx2.Location.Y);
        }

    }
}
