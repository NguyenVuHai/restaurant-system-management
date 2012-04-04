namespace RestaurantApp_G21
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_tenDang = new DevComponents.DotNetBar.LabelX();
            this.m_btnDangNhap = new DevComponents.DotNetBar.ButtonX();
            this.m_btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.m_txtTenDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.m_txtMatKhau = new DevComponents.DotNetBar.LabelX();
            this.m_textMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // m_tenDang
            // 
            this.m_tenDang.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_tenDang.BackgroundStyle.Class = "";
            this.m_tenDang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_tenDang.ForeColor = System.Drawing.Color.Black;
            this.m_tenDang.Location = new System.Drawing.Point(61, 29);
            this.m_tenDang.Name = "m_tenDang";
            this.m_tenDang.Size = new System.Drawing.Size(87, 23);
            this.m_tenDang.TabIndex = 0;
            this.m_tenDang.Text = "Tên Đăng Nhập";
            // 
            // m_btnDangNhap
            // 
            this.m_btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnDangNhap.Location = new System.Drawing.Point(93, 118);
            this.m_btnDangNhap.Name = "m_btnDangNhap";
            this.m_btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.m_btnDangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnDangNhap.TabIndex = 1;
            this.m_btnDangNhap.Text = "Đăng Nhập";
            // 
            // m_btnThoat
            // 
            this.m_btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnThoat.Location = new System.Drawing.Point(194, 118);
            this.m_btnThoat.Name = "m_btnThoat";
            this.m_btnThoat.Size = new System.Drawing.Size(75, 23);
            this.m_btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnThoat.TabIndex = 1;
            this.m_btnThoat.Text = "Thoát";
            // 
            // m_txtTenDangNhap
            // 
            this.m_txtTenDangNhap.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtTenDangNhap.Border.Class = "TextBoxBorder";
            this.m_txtTenDangNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.m_txtTenDangNhap.Location = new System.Drawing.Point(168, 27);
            this.m_txtTenDangNhap.Name = "m_txtTenDangNhap";
            this.m_txtTenDangNhap.Size = new System.Drawing.Size(126, 22);
            this.m_txtTenDangNhap.TabIndex = 2;
            // 
            // m_txtMatKhau
            // 
            this.m_txtMatKhau.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtMatKhau.BackgroundStyle.Class = "";
            this.m_txtMatKhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.m_txtMatKhau.Location = new System.Drawing.Point(65, 55);
            this.m_txtMatKhau.Name = "m_txtMatKhau";
            this.m_txtMatKhau.Size = new System.Drawing.Size(75, 23);
            this.m_txtMatKhau.TabIndex = 0;
            this.m_txtMatKhau.Text = "Mật Khẩu";
            // 
            // m_textMatKhau
            // 
            this.m_textMatKhau.AcceptsReturn = true;
            this.m_textMatKhau.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_textMatKhau.Border.Class = "TextBoxBorder";
            this.m_textMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_textMatKhau.ForeColor = System.Drawing.Color.Black;
            this.m_textMatKhau.Location = new System.Drawing.Point(168, 56);
            this.m_textMatKhau.Name = "m_textMatKhau";
            this.m_textMatKhau.Size = new System.Drawing.Size(126, 22);
            this.m_textMatKhau.TabIndex = 2;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 166);
            this.Controls.Add(this.m_textMatKhau);
            this.Controls.Add(this.m_txtTenDangNhap);
            this.Controls.Add(this.m_btnThoat);
            this.Controls.Add(this.m_btnDangNhap);
            this.Controls.Add(this.m_txtMatKhau);
            this.Controls.Add(this.m_tenDang);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX m_tenDang;
        private DevComponents.DotNetBar.ButtonX m_btnDangNhap;
        private DevComponents.DotNetBar.ButtonX m_btnThoat;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtTenDangNhap;
        private DevComponents.DotNetBar.LabelX m_txtMatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX m_textMatKhau;
    }
}