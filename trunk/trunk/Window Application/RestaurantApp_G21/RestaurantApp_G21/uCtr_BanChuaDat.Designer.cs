namespace RestaurantApp_G21
{
    partial class uCtr_BanChuaDat
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
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.m_labelItemMaBan = new DevComponents.DotNetBar.LabelItem();
            this.m_btnDatBan = new DevComponents.DotNetBar.ButtonX();
            this.itemPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.itemPanel1.BackgroundStyle.BackColorGradientAngle = 90;
            this.itemPanel1.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.itemPanel1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderBottomWidth = 5;
            this.itemPanel1.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.itemPanel1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanel1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanel1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel1.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanel1.BackgroundStyle.Class = "";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Controls.Add(this.m_btnDatBan);
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.m_labelItemMaBan});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(0, 0);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(126, 122);
            this.itemPanel1.TabIndex = 0;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // m_labelItemMaBan
            // 
            this.m_labelItemMaBan.Name = "m_labelItemMaBan";
            this.m_labelItemMaBan.PaddingBottom = 5;
            this.m_labelItemMaBan.PaddingLeft = 5;
            this.m_labelItemMaBan.PaddingTop = 5;
            this.m_labelItemMaBan.Text = "Mã Bàn:";
            // 
            // m_btnDatBan
            // 
            this.m_btnDatBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnDatBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnDatBan.Image = global::RestaurantApp_G21.Properties.Resources.hBlue_;
            this.m_btnDatBan.Location = new System.Drawing.Point(9, 73);
            this.m_btnDatBan.Name = "m_btnDatBan";
            this.m_btnDatBan.Size = new System.Drawing.Size(44, 47);
            this.m_btnDatBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnDatBan.TabIndex = 0;
            // 
            // uCtr_BanChuaDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemPanel1);
            this.Name = "uCtr_BanChuaDat";
            this.Size = new System.Drawing.Size(126, 122);
            this.itemPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.LabelItem m_labelItemMaBan;
        private DevComponents.DotNetBar.ButtonX m_btnDatBan;
    }
}
