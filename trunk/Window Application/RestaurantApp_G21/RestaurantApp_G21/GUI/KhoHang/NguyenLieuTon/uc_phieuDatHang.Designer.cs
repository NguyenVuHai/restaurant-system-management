namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    partial class uc_phieuDatHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tab_nguyenLieuOKhoangMucToiThieu = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabPage_danhSach = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabPage_lapPhieuDatHang = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.tab_nguyenLieuOKhoangMucToiThieu)).BeginInit();
            this.tab_nguyenLieuOKhoangMucToiThieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 200;
            this.toolTip1.ShowAlways = true;
            // 
            // tab_nguyenLieuOKhoangMucToiThieu
            // 
            this.tab_nguyenLieuOKhoangMucToiThieu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tab_nguyenLieuOKhoangMucToiThieu.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tab_nguyenLieuOKhoangMucToiThieu.ControlBox.MenuBox.Name = "";
            this.tab_nguyenLieuOKhoangMucToiThieu.ControlBox.Name = "";
            this.tab_nguyenLieuOKhoangMucToiThieu.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tab_nguyenLieuOKhoangMucToiThieu.ControlBox.MenuBox,
            this.tab_nguyenLieuOKhoangMucToiThieu.ControlBox.CloseBox});
            this.tab_nguyenLieuOKhoangMucToiThieu.Controls.Add(this.superTabControlPanel1);
            this.tab_nguyenLieuOKhoangMucToiThieu.Controls.Add(this.superTabControlPanel2);
            this.tab_nguyenLieuOKhoangMucToiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_nguyenLieuOKhoangMucToiThieu.ForeColor = System.Drawing.Color.Black;
            this.tab_nguyenLieuOKhoangMucToiThieu.Location = new System.Drawing.Point(0, 0);
            this.tab_nguyenLieuOKhoangMucToiThieu.Name = "tab_nguyenLieuOKhoangMucToiThieu";
            this.tab_nguyenLieuOKhoangMucToiThieu.ReorderTabsEnabled = true;
            this.tab_nguyenLieuOKhoangMucToiThieu.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tab_nguyenLieuOKhoangMucToiThieu.SelectedTabIndex = 2;
            this.tab_nguyenLieuOKhoangMucToiThieu.Size = new System.Drawing.Size(942, 548);
            this.tab_nguyenLieuOKhoangMucToiThieu.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Bottom;
            this.tab_nguyenLieuOKhoangMucToiThieu.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_nguyenLieuOKhoangMucToiThieu.TabIndex = 0;
            this.tab_nguyenLieuOKhoangMucToiThieu.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabPage_danhSach,
            this.tabPage_lapPhieuDatHang});
            this.tab_nguyenLieuOKhoangMucToiThieu.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.tab_nguyenLieuOKhoangMucToiThieu.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(942, 525);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabPage_danhSach;
            // 
            // tabPage_danhSach
            // 
            this.tabPage_danhSach.AttachedControl = this.superTabControlPanel1;
            this.tabPage_danhSach.GlobalItem = false;
            this.tabPage_danhSach.Name = "tabPage_danhSach";
            this.tabPage_danhSach.Text = "Danh sách";
            this.tabPage_danhSach.Click += new System.EventHandler(this.tabPage_danhSach_Click);
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(942, 525);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabPage_lapPhieuDatHang;
            // 
            // tabPage_lapPhieuDatHang
            // 
            this.tabPage_lapPhieuDatHang.AttachedControl = this.superTabControlPanel2;
            this.tabPage_lapPhieuDatHang.GlobalItem = false;
            this.tabPage_lapPhieuDatHang.Name = "tabPage_lapPhieuDatHang";
            this.tabPage_lapPhieuDatHang.Text = "Lập phiếu đặt hàng";
            // 
            // uc_phieuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tab_nguyenLieuOKhoangMucToiThieu);
            this.Name = "uc_phieuDatHang";
            this.Size = new System.Drawing.Size(942, 548);
            ((System.ComponentModel.ISupportInitialize)(this.tab_nguyenLieuOKhoangMucToiThieu)).EndInit();
            this.tab_nguyenLieuOKhoangMucToiThieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.SuperTabControl tab_nguyenLieuOKhoangMucToiThieu;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabPage_lapPhieuDatHang;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabPage_danhSach;


    }
}
