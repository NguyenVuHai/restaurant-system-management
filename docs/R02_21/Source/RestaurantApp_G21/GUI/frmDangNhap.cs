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

    public partial class frmDangNhap : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        #region Login và Phần Quyền
        #endregion

        private void m_btnDangNhap_Click(object sender, EventArgs e)
        {
            // frmTrangChu frm = new frmTrangChu();
            string tenDangNhap = m_txtTenDangNhap.Text;
            string matKhau = m_textMatKhau.Text;

            if (tenDangNhap == "%" || tenDangNhap.IndexOf("'") >= 0 || tenDangNhap.IndexOf("`") >= 0)// tên đăng nhập
            {
                m_lbTrangThaiDangNhap.Text = "Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ 1 !!!";
            }
            if (matKhau == "%" || matKhau.IndexOf("'") >= 0 || matKhau.IndexOf("`") >= 0)
            {
                m_lbTrangThaiDangNhap.Text = "Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ 2 !!!";// sao nó chạy dô đây

            }
            if (tenDangNhap == "" || matKhau == "")
            {
                m_lbTrangThaiDangNhap.Text = "Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ 3 !!!";
                //goto Cont;
            }
            ThongTinTaiKhoanDTO taiKhoan = new ThongTinTaiKhoanDTO();
            taiKhoan = ThongTinTaiKhoanBUS.KiemTraDangNhap(tenDangNhap, matKhau);
            if (taiKhoan == null)
            {
                //MessBox();
                m_lbTrangThaiDangNhap.Text = "Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ 4  !!!";
            }
            else
            {
                frmTrangChu frm = new frmTrangChu();
                frm.Show();
                
                frm.DisableCacChucNang(true, taiKhoan.LoaiNhanVien);
                frm.m_lbHienThiTen.Text = taiKhoan.TenDangNhap;   
            }
            
        }
        private void MessBox()
        {
            MessageBox.Show("ten đăng nhập hoặc mật khẩu không hợp lệ");
        }

        private void m_btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}