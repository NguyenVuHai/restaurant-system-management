namespace RestaurantApp_G21
{
    partial class frmKhoHang
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
            this.components = new System.ComponentModel.Container();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bt_dong = new System.Windows.Forms.Button();
            this.main_tab_KhoHang = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tab_nguyenLieuCanNhap = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tab_nhapHangDotXuat = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tab_NCC = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tab_NL = new DevComponents.DotNetBar.SuperTabItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_tab_KhoHang)).BeginInit();
            this.main_tab_KhoHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.bt_dong);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(1, 584);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(942, 31);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.InactiveCaption;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 41;
            // 
            // bt_dong
            // 
            this.bt_dong.ForeColor = System.Drawing.Color.Black;
            this.bt_dong.Location = new System.Drawing.Point(865, 0);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(75, 30);
            this.bt_dong.TabIndex = 1;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // main_tab_KhoHang
            // 
            this.main_tab_KhoHang.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.main_tab_KhoHang.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.main_tab_KhoHang.ControlBox.MenuBox.Name = "";
            this.main_tab_KhoHang.ControlBox.Name = "";
            this.main_tab_KhoHang.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.main_tab_KhoHang.ControlBox.MenuBox,
            this.main_tab_KhoHang.ControlBox.CloseBox});
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel4);
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel1);
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel2);
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel3);
            this.main_tab_KhoHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_tab_KhoHang.ForeColor = System.Drawing.Color.Black;
            this.main_tab_KhoHang.Location = new System.Drawing.Point(1, 1);
            this.main_tab_KhoHang.Name = "main_tab_KhoHang";
            this.main_tab_KhoHang.ReorderTabsEnabled = true;
            this.main_tab_KhoHang.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.main_tab_KhoHang.SelectedTabIndex = 0;
            this.main_tab_KhoHang.Size = new System.Drawing.Size(942, 573);
            this.main_tab_KhoHang.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_tab_KhoHang.TabIndex = 43;
            this.main_tab_KhoHang.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tab_NL,
            this.tab_NCC,
            this.tab_nguyenLieuCanNhap,
            this.tab_nhapHangDotXuat});
            this.main_tab_KhoHang.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.main_tab_KhoHang.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(942, 548);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.tab_nguyenLieuCanNhap;
            // 
            // tab_nguyenLieuCanNhap
            // 
            this.tab_nguyenLieuCanNhap.AttachedControl = this.superTabControlPanel1;
            this.tab_nguyenLieuCanNhap.GlobalItem = false;
            this.tab_nguyenLieuCanNhap.Name = "tab_nguyenLieuCanNhap";
            this.tab_nguyenLieuCanNhap.Text = "Nguyên liệu cần nhập hàng";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(942, 548);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.tab_nhapHangDotXuat;
            // 
            // tab_nhapHangDotXuat
            // 
            this.tab_nhapHangDotXuat.AttachedControl = this.superTabControlPanel4;
            this.tab_nhapHangDotXuat.GlobalItem = false;
            this.tab_nhapHangDotXuat.Name = "tab_nhapHangDotXuat";
            this.tab_nhapHangDotXuat.Text = "Nhập hàng đột xuất";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(942, 548);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tab_NCC;
            // 
            // tab_NCC
            // 
            this.tab_NCC.AttachedControl = this.superTabControlPanel2;
            this.tab_NCC.GlobalItem = false;
            this.tab_NCC.Name = "tab_NCC";
            this.tab_NCC.Text = "Nhà Cung Cấp";
            this.tab_NCC.Click += new System.EventHandler(this.m_sTabItmTTBanDat_Click);
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(942, 548);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.tab_NL;
            // 
            // tab_NL
            // 
            this.tab_NL.AttachedControl = this.superTabControlPanel3;
            this.tab_NL.GlobalItem = false;
            this.tab_NL.Name = "tab_NL";
            this.tab_NL.Text = "Nguyên liệu tồn";
            this.tab_NL.Click += new System.EventHandler(this.superTabItem1_Click);
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.ClientSize = new System.Drawing.Size(944, 616);
            this.Controls.Add(this.main_tab_KhoHang);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_tab_KhoHang)).EndInit();
            this.main_tab_KhoHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Button bt_dong;
        private DevComponents.DotNetBar.SuperTabControl main_tab_KhoHang;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tab_NCC;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem tab_NL;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tab_nguyenLieuCanNhap;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem tab_nhapHangDotXuat;

    }
}

