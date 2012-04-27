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
    public partial class frmDoiMatKhau : DevComponents.DotNetBar.Metro.MetroForm
    {
        frmDangNhap frm = new frmDangNhap();
        public frmDoiMatKhau()
        {
            InitializeComponent();
            
            //m_txtTenDN.Text = frm.m_txtTenDangNhap.Text;
        }

        private void m_btnDoiPass_Click(object sender, EventArgs e)
        {
            string oldPass = m_txtMatKhau.Text;
            string newPass = m_txtMatKhauMoi.Text;
            string tenDangNhap = m_txtTenDN.Text;
            string rePass = m_txtNhapLaiMK.Text;
            ThongTinTaiKhoanDTO taiKhoan = new ThongTinTaiKhoanDTO();
            if (tenDangNhap == "%" || tenDangNhap.IndexOf("'") >= 0 || tenDangNhap.IndexOf("`") >= 0)
            {
                //m_lbTrangThaiDangNhap.Text = "Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ !!!";
                MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ 1");
                //MessageBoxButtons.YesNoCancel.ToString(

            }
            if (oldPass == "%" || oldPass.IndexOf("'") >= 0 || oldPass.IndexOf("`") >= 0)
            {
                MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ 2");

            }
            if (newPass == "%" || newPass.IndexOf("'") >= 0 || newPass.IndexOf("`") >= 0)
            {
                MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ 3 ");

               // m_lbTrangThaiDangNhap.Text = "Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ !!!";

            }
            if (rePass == "%" || rePass.IndexOf("'") >= 0 || rePass.IndexOf("`") >= 0)
            {
                MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu Không hợp Lệ 4");

            }

            if (oldPass.Equals("") || newPass.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
            }
            if (newPass != rePass)
            {
                MessageBox.Show("Mật Khẩu hem trùng khớp");
            }
            // thỏa tất cả
            if (ThongTinTaiKhoanBUS.DoiMatKhau(tenDangNhap, newPass))
            {
                MessageBox.Show("Đổi Pass thành công");
            }

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }

        private void m_btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //private void itemHeThongDoimatKhau_Click(object sender, EventArgs e)
        //{
        //// Tạo biến continues
        //Cont:
        //    if (fcp == null || fcp.IsDisposed)
        //        fcp = new frmChangePassword();
        //    if (fcp.ShowDialog() == DialogResult.OK)
        //    {
        //        
        //    }
        //}



    }
}