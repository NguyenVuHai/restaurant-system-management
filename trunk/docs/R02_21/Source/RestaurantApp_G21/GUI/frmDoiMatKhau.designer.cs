namespace RestaurantApp_G21
{
    partial class frmDoiMatKhau
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.m_btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.m_txtTenDN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.m_txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.m_txtMatKhauMoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.m_btnDoiPass = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.m_txtNhapLaiMK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(80, 60);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(86, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên Đăng Nhập";
            // 
            // m_btnThoat
            // 
            this.m_btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnThoat.Location = new System.Drawing.Point(326, 252);
            this.m_btnThoat.Name = "m_btnThoat";
            this.m_btnThoat.Size = new System.Drawing.Size(75, 23);
            this.m_btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnThoat.TabIndex = 5;
            this.m_btnThoat.Text = "Thoát";
            this.m_btnThoat.Click += new System.EventHandler(this.m_btnThoat_Click);
            // 
            // m_txtTenDN
            // 
            this.m_txtTenDN.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtTenDN.Border.Class = "TextBoxBorder";
            this.m_txtTenDN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtTenDN.ForeColor = System.Drawing.Color.Black;
            this.m_txtTenDN.Location = new System.Drawing.Point(187, 60);
            this.m_txtTenDN.Name = "m_txtTenDN";
            this.m_txtTenDN.Size = new System.Drawing.Size(214, 22);
            this.m_txtTenDN.TabIndex = 0;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(80, 97);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mật Khẩu Hiện Tại";
            // 
            // m_txtMatKhau
            // 
            this.m_txtMatKhau.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtMatKhau.Border.Class = "TextBoxBorder";
            this.m_txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.m_txtMatKhau.Location = new System.Drawing.Point(187, 97);
            this.m_txtMatKhau.Name = "m_txtMatKhau";
            this.m_txtMatKhau.Size = new System.Drawing.Size(214, 22);
            this.m_txtMatKhau.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(80, 134);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Mật Khẩu Mới";
            // 
            // m_txtMatKhauMoi
            // 
            this.m_txtMatKhauMoi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtMatKhauMoi.Border.Class = "TextBoxBorder";
            this.m_txtMatKhauMoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtMatKhauMoi.ForeColor = System.Drawing.Color.Black;
            this.m_txtMatKhauMoi.Location = new System.Drawing.Point(187, 134);
            this.m_txtMatKhauMoi.Name = "m_txtMatKhauMoi";
            this.m_txtMatKhauMoi.Size = new System.Drawing.Size(214, 22);
            this.m_txtMatKhauMoi.TabIndex = 2;
            // 
            // m_btnDoiPass
            // 
            this.m_btnDoiPass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnDoiPass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnDoiPass.Location = new System.Drawing.Point(229, 252);
            this.m_btnDoiPass.Name = "m_btnDoiPass";
            this.m_btnDoiPass.Size = new System.Drawing.Size(75, 23);
            this.m_btnDoiPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnDoiPass.TabIndex = 4;
            this.m_btnDoiPass.Text = "Thay Đổi";
            this.m_btnDoiPass.Click += new System.EventHandler(this.m_btnDoiPass_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(80, 172);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(101, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Nhập Lai Mật Khẩu";
            // 
            // m_txtNhapLaiMK
            // 
            this.m_txtNhapLaiMK.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtNhapLaiMK.Border.Class = "TextBoxBorder";
            this.m_txtNhapLaiMK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtNhapLaiMK.ForeColor = System.Drawing.Color.Black;
            this.m_txtNhapLaiMK.Location = new System.Drawing.Point(187, 172);
            this.m_txtNhapLaiMK.Name = "m_txtNhapLaiMK";
            this.m_txtNhapLaiMK.Size = new System.Drawing.Size(214, 22);
            this.m_txtNhapLaiMK.TabIndex = 3;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 321);
            this.Controls.Add(this.m_txtNhapLaiMK);
            this.Controls.Add(this.m_txtMatKhauMoi);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.m_txtMatKhau);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.m_txtTenDN);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.m_btnDoiPass);
            this.Controls.Add(this.m_btnThoat);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX m_btnThoat;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtTenDN;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtMatKhau;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtMatKhauMoi;
        private DevComponents.DotNetBar.ButtonX m_btnDoiPass;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtNhapLaiMK;
    }
}