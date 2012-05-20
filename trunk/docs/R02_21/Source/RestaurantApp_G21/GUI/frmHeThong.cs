using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestaurantApp_G21.DTO;
using RestaurantApp_G21.BUS;

namespace RestaurantApp_G21
{
    public partial class frmHeThong : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        List<NhaHangDTO>  list = new List<NhaHangDTO>();
        private DataView dtV = new DataView();
        public frmHeThong()
        {
            InitializeComponent();
            m_mtHThong.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
        }
        private void loadNhaHang()
        {

            m_cboxMaNH.Items.Clear();
            NhaHangDTO nh = new NhaHangDTO(0,"","","");
            //NhaHangDTO nh = new NhaHangDTO()
            nh.MaNhaHang = 0;
            nh.TenNhaHang = "Tất cả";
            //m_cboxMaNH.Items.Add("Chọn Nhà Hàng");
            
            List<NhaHangDTO> list = new List<NhaHangDTO>();
            list = NhaHangBUS.LayDanhSachNhaHang();
            list.Insert(0, nh);                      
            m_cboxMaNH.ValueMember = "MaNhaHang";
            m_cboxMaNH.DisplayMember = "TenNhaHang";
            //m_colMaNH
            m_cboxMaNH.DataSource = list;
            m_cboxMaNH.SelectedIndex = 0;            
        }
        private void loadLoaiNhanVien()
        {
            m_cboxMaLoai.Items.Clear();
            //m_cboxMaLoai.Items.Add("Chon Loại Nhân Viên");
            LoaiNhanVienCNDTO lnv = new LoaiNhanVienCNDTO(0,"Tất cả",0);

            List<LoaiNhanVienCNDTO> list = new List<LoaiNhanVienCNDTO>();
            list = LoaiNhanVienCNBUS.LayLoaiNhanVien();
            list.Insert(0, lnv);
            m_cboxMaLoai.ValueMember = "MaLoaiNhanVien";
            m_cboxMaLoai.DisplayMember = "TenLoaiNhanVien";
            m_cboxMaLoai.DataSource = list;
            m_cboxMaLoai.SelectedIndex = 0;
        }
        private void loadTenTaiKhoan()
        { 
            
        }
        #region Quan Ly Tai Khoan Nha Hang
        private void m_btnLuu_Click(object sender, EventArgs e)
        {
            //int maNhaHang =  m_txtTenMaNH;
            NhaHangDTO nhaHangD = new NhaHangDTO(0,"","","");
            string tenNhaHang = m_txtTenNH.Text;
            string diaChi = m_txtDiaChi.Text;
            string dienThoai = m_txtSoDT.Text;

            //nhaHangD.MaNhaHang = maNhaHang;
            nhaHangD.TenNhaHang = tenNhaHang;
            nhaHangD.DiaChi = diaChi;
            nhaHangD.DienThoai = dienThoai;
            //NhaHangBUS nhaHangB = new NhaHangBUS();
            if (NhaHangBUS.ThemNhaHang(nhaHangD) == false)
            {
                MessageBox.Show("Thêm Không Thành Công");
            }
            else
            {
                m_dtGNhaHang.DataSource = NhaHangBUS.LayBangNhaHang();

            }
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {

            loadNhaHang();
            loadLoaiNhanVien();
            DataTable dtb = ThongTinNhanVienCNBUS.LayThongTinNhanVien() ;
            m_dataGNhanVien.DataSource = dtb;
            m_dataGTaiKhoan.DataSource = ThongTinTaiKhoanBUS.LayBangNguoiDung();
            m_dtGNhaHang.DataSource = NhaHangBUS.LayBangNhaHang();
            dtV = new DataView(dtb);
            // m_dataGNhanVien.Columns[5].Visible = false;
            
            
            EnableEditing(false);
            //m_dtGNhaHang.Enabled = false;
            m_txtMaNH.Enabled = false;
        }

        private void m_dtGNhaHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int dong = e.RowIndex;
            if (m_dtGNhaHang.Rows[dong].DataBoundItem != null)
            {
                // thực hiện blinding data lên ctr khi click vào một row
                m_txtMaNH.Text = m_dtGNhaHang.Rows[dong].Cells["m_colMaNhaHang"].Value.ToString();
                m_txtTenNH.Text = m_dtGNhaHang.Rows[dong].Cells["m_colTenNhaHang"].Value.ToString();
                m_txtDiaChi.Text = m_dtGNhaHang.Rows[dong].Cells["m_colDiaChi"].Value.ToString();
                m_txtSoDT.Text = m_dtGNhaHang.Rows[dong].Cells["m_colDienThoai"].Value.ToString();
            }
        }
        private void ResetTextValue()
        {
            m_txtMaNH.Text = "";
            m_txtTenNH.Text = "";
            m_txtSoDT.Text = "";
            m_txtDiaChi.Text = "";
        }
        private void m_dtGNhaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void m_btnThem_Click(object sender, EventArgs e)
        {
            EnabledMaNH();
            EnableEditing(true);
            ResetTextValue();
        }
        private void EnableEditing(bool editing1)
        {
            // button
            // Khi đang thêm thì nút thêm cũng sẽ ẩn đi
            m_btnThem.Enabled = !editing1;
            m_btnThayDoi.Enabled = !editing1;
            m_btnXoa.Enabled = !editing1;
            m_btnLuu.Enabled = editing1;
            m_txtDiaChi.Enabled = editing1;
            //m_txtMaNH.Enabled = !editing;
            m_txtSoDT.Enabled = editing1;
            m_txtTenNH.Enabled = editing1;

            m_dtGNhaHang.Enabled = !editing1;
        }
        private void EnabledMaNH()
        {
            m_txtMaNH.Enabled = false;
        }


        private void m_btnXoa_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn xóa Nhà Hàng: " + m_txtTenNH.Text + " không?", "Hỏi",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{

            //    if (NhaHangBUS.XoaNhaHang(txtMaSV.Text))
            //        // load lại form
            //        frmSinhVien_Load(sender, e);

            //}
            //EnableEditing(true);
        }

        private void m_btnKhongLuu_Click(object sender, EventArgs e)
        {
            ResetTextValue();
            EnableEditing(false);
        }

        private void m_btnThayDoi_Click(object sender, EventArgs e)
        {
            EnableEditing(true);

        }

        private void superTabControlPanel6_Click(object sender, EventArgs e)
        {

        }

        //private void m_sTabItmQLTaiKhoan_Click(object sender, EventArgs e)
        //{
        //   // loadNhaHang();
        //    //loadLoaiNhanVien();
        //    //int nhaHang = Int32.Parse(m_cboxLoaiNV.Text);
        //    //int loaiNV = Int32.Parse(m_cboxMaNH.ValueMember);

        //}
        private void LoadNhanVienTheoMaNH()
        {
            m_dtGNhaHang.DataSource = ThongTinNhanVienCNBUS.LayThongTinNhanVien();

        }
        private void doFilter()
        {
            if (dtV != null)
            {
                string s = "";
                if (Convert.ToInt32(m_cboxMaNH.SelectedValue) != 0)
                {
                    s = "MaNhaHang='" + m_cboxMaNH.SelectedValue + "'";
                }
                if (Convert.ToInt32(m_cboxMaLoai.SelectedValue) != 0)
                {
                    if(s == "")
                        s = "MaLoaiNhanVien='" + m_cboxMaLoai.SelectedValue + "'";
                    else
                        s += " AND MaLoaiNhanVien='" + m_cboxMaLoai.SelectedValue + "'";

                }
                dtV.RowFilter = s;
                m_dataGNhanVien.DataSource = dtV;
            }            
        }
        private void m_cboxMaNH_SelectedIndexChanged(object sender, EventArgs e)
        {
            doFilter();
        }

        private void m_dataGNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // int dong = e.RowIndex;
            int dong = e.RowIndex;
            if (m_dataGNhanVien.Rows[dong].DataBoundItem != null)
            {
                m_txtMatKhau.Text = m_dataGNhanVien.Rows[dong].Cells["m_colCMND"].Value.ToString();
                m_txtMaNV.Text = m_dataGNhanVien.Rows[dong].Cells["m_colMaNhanVien"].Value.ToString();
            }

        }

        private void m_cboxMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            doFilter();
        }

        private void panelEx1_Resize(object sender, EventArgs e)
        {
            panelEx10.Location = new Point((panelEx1.Width / 2 - panelEx10.Width / 2), panelEx10.Location.Y);
        }


    }
#endregion
    


}
