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
            this.bt_anDi = new System.Windows.Forms.Button();
            this.bt_moRong = new System.Windows.Forms.Button();
            this.bt_thuGon = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.main_tab_KhoHang = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tab_NCC = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tab_noToiHanThanhToan = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroAppButton1 = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.metroTabItem1 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabItem2 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.tab_NL = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tab_nhapHangDotXuat = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tab_nguyenLieuCanNhap = new DevComponents.DotNetBar.SuperTabItem();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_tab_KhoHang)).BeginInit();
            this.main_tab_KhoHang.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.metroShell1.SuspendLayout();
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
            this.panelEx1.Controls.Add(this.bt_anDi);
            this.panelEx1.Controls.Add(this.bt_moRong);
            this.panelEx1.Controls.Add(this.bt_thuGon);
            this.panelEx1.Controls.Add(this.bt_dong);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(1, 585);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(942, 30);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.InactiveCaption;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 41;
            this.panelEx1.SizeChanged += new System.EventHandler(this.panelEx1_SizeChanged);
            // 
            // bt_anDi
            // 
            this.bt_anDi.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_anDi.ForeColor = System.Drawing.Color.Black;
            this.bt_anDi.Location = new System.Drawing.Point(162, 0);
            this.bt_anDi.Name = "bt_anDi";
            this.bt_anDi.Size = new System.Drawing.Size(60, 30);
            this.bt_anDi.TabIndex = 4;
            this.bt_anDi.Text = "- Ẩn đi";
            this.bt_anDi.UseVisualStyleBackColor = true;
            this.bt_anDi.Click += new System.EventHandler(this.bt_anDi_Click);
            // 
            // bt_moRong
            // 
            this.bt_moRong.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_moRong.ForeColor = System.Drawing.Color.Black;
            this.bt_moRong.Location = new System.Drawing.Point(81, 0);
            this.bt_moRong.Name = "bt_moRong";
            this.bt_moRong.Size = new System.Drawing.Size(81, 30);
            this.bt_moRong.TabIndex = 3;
            this.bt_moRong.Text = "[ ] Mở rộng";
            this.bt_moRong.UseVisualStyleBackColor = true;
            this.bt_moRong.Click += new System.EventHandler(this.bt_moRong_Click);
            // 
            // bt_thuGon
            // 
            this.bt_thuGon.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_thuGon.ForeColor = System.Drawing.Color.Black;
            this.bt_thuGon.Location = new System.Drawing.Point(0, 0);
            this.bt_thuGon.Name = "bt_thuGon";
            this.bt_thuGon.Size = new System.Drawing.Size(81, 30);
            this.bt_thuGon.TabIndex = 2;
            this.bt_thuGon.Text = "[] Thu gọn";
            this.bt_thuGon.UseVisualStyleBackColor = true;
            this.bt_thuGon.Click += new System.EventHandler(this.bt_thuGon_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_dong.ForeColor = System.Drawing.Color.Black;
            this.bt_dong.Location = new System.Drawing.Point(877, 0);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(65, 30);
            this.bt_dong.TabIndex = 1;
            this.bt_dong.Text = "[X] Đóng";
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
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel2);
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel5);
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel4);
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel1);
            this.main_tab_KhoHang.Controls.Add(this.superTabControlPanel3);
            this.main_tab_KhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tab_KhoHang.ForeColor = System.Drawing.Color.Black;
            this.main_tab_KhoHang.Location = new System.Drawing.Point(1, 1);
            this.main_tab_KhoHang.Name = "main_tab_KhoHang";
            this.main_tab_KhoHang.ReorderTabsEnabled = true;
            this.main_tab_KhoHang.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.main_tab_KhoHang.SelectedTabIndex = 0;
            this.main_tab_KhoHang.Size = new System.Drawing.Size(942, 584);
            this.main_tab_KhoHang.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_tab_KhoHang.TabIndex = 43;
            this.main_tab_KhoHang.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tab_NL,
            this.tab_nguyenLieuCanNhap,
            this.tab_nhapHangDotXuat,
            this.tab_NCC,
            this.tab_noToiHanThanhToan});
            this.main_tab_KhoHang.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.main_tab_KhoHang.Text = "superTabControl1";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(942, 559);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tab_NCC;
            // 
            // tab_NCC
            // 
            this.tab_NCC.AttachedControl = this.superTabControlPanel2;
            this.tab_NCC.GlobalItem = false;
            this.tab_NCC.Name = "tab_NCC";
            this.tab_NCC.Text = "Thông tin Nhà Cung Cấp";
            this.tab_NCC.Click += new System.EventHandler(this.m_sTabItmTTBanDat_Click);
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(942, 559);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.tab_noToiHanThanhToan;
            // 
            // tab_noToiHanThanhToan
            // 
            this.tab_noToiHanThanhToan.AttachedControl = this.superTabControlPanel5;
            this.tab_noToiHanThanhToan.GlobalItem = false;
            this.tab_noToiHanThanhToan.Name = "tab_noToiHanThanhToan";
            this.tab_noToiHanThanhToan.Text = "Nhà Cung Cấp tới hạn được thanh toán nợ";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.AutoSize = true;
            this.superTabControlPanel3.Controls.Add(this.metroShell1);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(942, 559);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.tab_NL;
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.Class = "";
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroAppButton1,
            this.metroTabItem1,
            this.metroTabItem2});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(3, 114);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.metroShell1.Size = new System.Drawing.Size(238, 19);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 44;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(238, 0);
            // 
            // 
            // 
            this.metroTabPanel1.Style.Class = "";
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.Class = "";
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.Class = "";
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(200, 100);
            // 
            // 
            // 
            this.metroTabPanel2.Style.Class = "";
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.Class = "";
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.Class = "";
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            // 
            // metroAppButton1
            // 
            this.metroAppButton1.AutoExpandOnClick = true;
            this.metroAppButton1.CanCustomize = false;
            this.metroAppButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.metroAppButton1.ImagePaddingHorizontal = 0;
            this.metroAppButton1.ImagePaddingVertical = 0;
            this.metroAppButton1.Name = "metroAppButton1";
            this.metroAppButton1.ShowSubItems = false;
            this.metroAppButton1.Text = "&File";
            // 
            // metroTabItem1
            // 
            this.metroTabItem1.Checked = true;
            this.metroTabItem1.Name = "metroTabItem1";
            this.metroTabItem1.Panel = this.metroTabPanel1;
            this.metroTabItem1.Text = "&HOME";
            // 
            // metroTabItem2
            // 
            this.metroTabItem2.Name = "metroTabItem2";
            this.metroTabItem2.Panel = this.metroTabPanel2;
            this.metroTabItem2.Text = "&VIEW";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.BeginGroup = true;
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // tab_NL
            // 
            this.tab_NL.AttachedControl = this.superTabControlPanel3;
            this.tab_NL.GlobalItem = false;
            this.tab_NL.Name = "tab_NL";
            this.tab_NL.Text = "Nguyên liệu tồn kho";
            this.tab_NL.Click += new System.EventHandler(this.superTabItem1_Click);
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(942, 559);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.tab_nhapHangDotXuat;
            // 
            // tab_nhapHangDotXuat
            // 
            this.tab_nhapHangDotXuat.AttachedControl = this.superTabControlPanel4;
            this.tab_nhapHangDotXuat.GlobalItem = false;
            this.tab_nhapHangDotXuat.Name = "tab_nhapHangDotXuat";
            this.tab_nhapHangDotXuat.Text = "Quản lý nhập hàng";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(942, 559);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.tab_nguyenLieuCanNhap;
            // 
            // tab_nguyenLieuCanNhap
            // 
            this.tab_nguyenLieuCanNhap.AttachedControl = this.superTabControlPanel1;
            this.tab_nguyenLieuCanNhap.GlobalItem = false;
            this.tab_nguyenLieuCanNhap.Name = "tab_nguyenLieuCanNhap";
            this.tab_nguyenLieuCanNhap.Text = "Nguyên liệu đang ở khoảng mức tối thiểu";
            this.tab_nguyenLieuCanNhap.Click += new System.EventHandler(this.tab_nguyenLieuCanNhap_Click);
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_tab_KhoHang)).EndInit();
            this.main_tab_KhoHang.ResumeLayout(false);
            this.main_tab_KhoHang.PerformLayout();
            this.superTabControlPanel3.ResumeLayout(false);
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
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
        private System.Windows.Forms.Button bt_anDi;
        private System.Windows.Forms.Button bt_moRong;
        private System.Windows.Forms.Button bt_thuGon;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.SuperTabItem tab_noToiHanThanhToan;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem2;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem1;
        private DevComponents.DotNetBar.Metro.MetroAppButton metroAppButton1;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;

    }
}

