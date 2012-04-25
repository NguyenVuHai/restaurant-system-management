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
            this.m_sTabCtrlDatBan = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.m_sTabItmDBan = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.m_sTabItmTTBanDat = new DevComponents.DotNetBar.SuperTabItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sTabCtrlDatBan)).BeginInit();
            this.m_sTabCtrlDatBan.SuspendLayout();
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
            this.bt_dong.Location = new System.Drawing.Point(865, 0);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(75, 30);
            this.bt_dong.TabIndex = 1;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // m_sTabCtrlDatBan
            // 
            this.m_sTabCtrlDatBan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.m_sTabCtrlDatBan.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.m_sTabCtrlDatBan.ControlBox.MenuBox.Name = "";
            this.m_sTabCtrlDatBan.ControlBox.Name = "";
            this.m_sTabCtrlDatBan.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_sTabCtrlDatBan.ControlBox.MenuBox,
            this.m_sTabCtrlDatBan.ControlBox.CloseBox});
            this.m_sTabCtrlDatBan.Controls.Add(this.superTabControlPanel1);
            this.m_sTabCtrlDatBan.Controls.Add(this.superTabControlPanel2);
            this.m_sTabCtrlDatBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_sTabCtrlDatBan.ForeColor = System.Drawing.Color.Black;
            this.m_sTabCtrlDatBan.Location = new System.Drawing.Point(1, 1);
            this.m_sTabCtrlDatBan.Name = "m_sTabCtrlDatBan";
            this.m_sTabCtrlDatBan.ReorderTabsEnabled = true;
            this.m_sTabCtrlDatBan.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_sTabCtrlDatBan.SelectedTabIndex = 1;
            this.m_sTabCtrlDatBan.Size = new System.Drawing.Size(942, 573);
            this.m_sTabCtrlDatBan.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sTabCtrlDatBan.TabIndex = 43;
            this.m_sTabCtrlDatBan.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_sTabItmDBan,
            this.m_sTabItmTTBanDat});
            this.m_sTabCtrlDatBan.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.m_sTabCtrlDatBan.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.CanvasColor = System.Drawing.Color.DarkGray;
            this.superTabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(942, 548);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.m_sTabItmDBan;
            // 
            // m_sTabItmDBan
            // 
            this.m_sTabItmDBan.AttachedControl = this.superTabControlPanel1;
            this.m_sTabItmDBan.GlobalItem = false;
            this.m_sTabItmDBan.Name = "m_sTabItmDBan";
            this.m_sTabItmDBan.Text = "Quản Lý Nhập Xuất Hàng";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(942, 573);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.m_sTabItmTTBanDat;
            // 
            // m_sTabItmTTBanDat
            // 
            this.m_sTabItmTTBanDat.AttachedControl = this.superTabControlPanel2;
            this.m_sTabItmTTBanDat.GlobalItem = false;
            this.m_sTabItmTTBanDat.Name = "m_sTabItmTTBanDat";
            this.m_sTabItmTTBanDat.Text = "Nhà Cung Cấp";
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.ClientSize = new System.Drawing.Size(944, 616);
            this.Controls.Add(this.m_sTabCtrlDatBan);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_sTabCtrlDatBan)).EndInit();
            this.m_sTabCtrlDatBan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Button bt_dong;
        private DevComponents.DotNetBar.SuperTabControl m_sTabCtrlDatBan;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem m_sTabItmDBan;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem m_sTabItmTTBanDat;

    }
}

