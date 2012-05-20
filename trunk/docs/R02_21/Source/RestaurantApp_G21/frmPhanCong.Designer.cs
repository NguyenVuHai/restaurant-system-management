namespace RestaurantApp_G21
{
    partial class frmPhanCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.m_lblNgayVaoLam = new DevComponents.DotNetBar.LabelX();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.m_txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.m_txtHoNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.m_txtTenNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.m_lblTenNV = new DevComponents.DotNetBar.LabelX();
            this.m_lblMaNV = new DevComponents.DotNetBar.LabelX();
            this.m_cbxThu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.m_cbxCa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.m_btnThem = new DevComponents.DotNetBar.ButtonX();
            this.m_dgvLichCongTac = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.itemPanel1.SuspendLayout();
            this.itemPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvLichCongTac)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(36, 36);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(45, 23);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "Thứ:";
            // 
            // m_lblNgayVaoLam
            // 
            this.m_lblNgayVaoLam.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.m_lblNgayVaoLam.BackgroundStyle.Class = "";
            this.m_lblNgayVaoLam.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_lblNgayVaoLam.ForeColor = System.Drawing.Color.Black;
            this.m_lblNgayVaoLam.Location = new System.Drawing.Point(36, 65);
            this.m_lblNgayVaoLam.Name = "m_lblNgayVaoLam";
            this.m_lblNgayVaoLam.Size = new System.Drawing.Size(29, 23);
            this.m_lblNgayVaoLam.TabIndex = 15;
            this.m_lblNgayVaoLam.Text = "Ca:";
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.Text = "Thêm Lịch Công Tác";
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem1.TileSize = new System.Drawing.Size(180, 25);
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.metroTileItem1.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(155)))));
            this.metroTileItem1.TileStyle.BackColorGradientAngle = 45;
            this.metroTileItem1.TileStyle.Class = "";
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TileStyle.PaddingBottom = 4;
            this.metroTileItem1.TileStyle.PaddingLeft = 4;
            this.metroTileItem1.TileStyle.PaddingRight = 4;
            this.metroTileItem1.TileStyle.PaddingTop = 4;
            this.metroTileItem1.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // itemPanel1
            // 
            this.itemPanel1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Controls.Add(this.m_btnThem);
            this.itemPanel1.Controls.Add(this.m_cbxCa);
            this.itemPanel1.Controls.Add(this.m_cbxThu);
            this.itemPanel1.Controls.Add(this.m_lblNgayVaoLam);
            this.itemPanel1.Controls.Add(this.labelX4);
            this.itemPanel1.ForeColor = System.Drawing.Color.Black;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem1});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(8, 168);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(250, 126);
            this.itemPanel1.TabIndex = 28;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemPanel2
            // 
            this.itemPanel2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.itemPanel2.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel2.ContainerControlProcessDialogKey = true;
            this.itemPanel2.Controls.Add(this.m_txtMaNV);
            this.itemPanel2.Controls.Add(this.m_txtHoNV);
            this.itemPanel2.Controls.Add(this.labelX1);
            this.itemPanel2.Controls.Add(this.m_txtTenNV);
            this.itemPanel2.Controls.Add(this.m_lblTenNV);
            this.itemPanel2.Controls.Add(this.m_lblMaNV);
            this.itemPanel2.ForeColor = System.Drawing.Color.Black;
            this.itemPanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem2});
            this.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel2.Location = new System.Drawing.Point(8, 12);
            this.itemPanel2.Name = "itemPanel2";
            this.itemPanel2.Size = new System.Drawing.Size(250, 137);
            this.itemPanel2.TabIndex = 29;
            this.itemPanel2.Text = "itemPanel2";
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.Text = "Thông Tin Nhân Viên";
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem2.TileSize = new System.Drawing.Size(180, 25);
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.metroTileItem2.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(155)))));
            this.metroTileItem2.TileStyle.BackColorGradientAngle = 45;
            this.metroTileItem2.TileStyle.Class = "";
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem2.TileStyle.PaddingBottom = 4;
            this.metroTileItem2.TileStyle.PaddingLeft = 4;
            this.metroTileItem2.TileStyle.PaddingRight = 4;
            this.metroTileItem2.TileStyle.PaddingTop = 4;
            this.metroTileItem2.TileStyle.TextColor = System.Drawing.Color.White;
            // 
            // m_txtMaNV
            // 
            this.m_txtMaNV.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtMaNV.Border.Class = "TextBoxBorder";
            this.m_txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.m_txtMaNV.Location = new System.Drawing.Point(81, 36);
            this.m_txtMaNV.Name = "m_txtMaNV";
            this.m_txtMaNV.Size = new System.Drawing.Size(121, 22);
            this.m_txtMaNV.TabIndex = 32;
            // 
            // m_txtHoNV
            // 
            this.m_txtHoNV.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtHoNV.Border.Class = "TextBoxBorder";
            this.m_txtHoNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtHoNV.ForeColor = System.Drawing.Color.Black;
            this.m_txtHoNV.Location = new System.Drawing.Point(81, 64);
            this.m_txtHoNV.Name = "m_txtHoNV";
            this.m_txtHoNV.Size = new System.Drawing.Size(121, 22);
            this.m_txtHoNV.TabIndex = 33;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(36, 63);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(45, 23);
            this.labelX1.TabIndex = 31;
            this.labelX1.Text = "Họ NV:";
            // 
            // m_txtTenNV
            // 
            this.m_txtTenNV.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtTenNV.Border.Class = "TextBoxBorder";
            this.m_txtTenNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.m_txtTenNV.Location = new System.Drawing.Point(81, 92);
            this.m_txtTenNV.Name = "m_txtTenNV";
            this.m_txtTenNV.Size = new System.Drawing.Size(121, 22);
            this.m_txtTenNV.TabIndex = 30;
            // 
            // m_lblTenNV
            // 
            this.m_lblTenNV.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.m_lblTenNV.BackgroundStyle.Class = "";
            this.m_lblTenNV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_lblTenNV.ForeColor = System.Drawing.Color.Black;
            this.m_lblTenNV.Location = new System.Drawing.Point(36, 92);
            this.m_lblTenNV.Name = "m_lblTenNV";
            this.m_lblTenNV.Size = new System.Drawing.Size(45, 23);
            this.m_lblTenNV.TabIndex = 28;
            this.m_lblTenNV.Text = "Tên NV:";
            // 
            // m_lblMaNV
            // 
            this.m_lblMaNV.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.m_lblMaNV.BackgroundStyle.Class = "";
            this.m_lblMaNV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_lblMaNV.ForeColor = System.Drawing.Color.Black;
            this.m_lblMaNV.Location = new System.Drawing.Point(36, 36);
            this.m_lblMaNV.Name = "m_lblMaNV";
            this.m_lblMaNV.Size = new System.Drawing.Size(45, 23);
            this.m_lblMaNV.TabIndex = 29;
            this.m_lblMaNV.Text = "Mã NV:";
            // 
            // m_cbxThu
            // 
            this.m_cbxThu.DisplayMember = "Text";
            this.m_cbxThu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.m_cbxThu.FormattingEnabled = true;
            this.m_cbxThu.ItemHeight = 16;
            this.m_cbxThu.Location = new System.Drawing.Point(81, 36);
            this.m_cbxThu.Name = "m_cbxThu";
            this.m_cbxThu.Size = new System.Drawing.Size(121, 22);
            this.m_cbxThu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_cbxThu.TabIndex = 16;
            // 
            // m_cbxCa
            // 
            this.m_cbxCa.DisplayMember = "Text";
            this.m_cbxCa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.m_cbxCa.FormattingEnabled = true;
            this.m_cbxCa.ItemHeight = 16;
            this.m_cbxCa.Location = new System.Drawing.Point(81, 65);
            this.m_cbxCa.Name = "m_cbxCa";
            this.m_cbxCa.Size = new System.Drawing.Size(121, 22);
            this.m_cbxCa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_cbxCa.TabIndex = 17;
            // 
            // m_btnThem
            // 
            this.m_btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnThem.Location = new System.Drawing.Point(127, 93);
            this.m_btnThem.Name = "m_btnThem";
            this.m_btnThem.Size = new System.Drawing.Size(75, 23);
            this.m_btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnThem.TabIndex = 18;
            this.m_btnThem.Text = "Thêm";
            // 
            // m_dgvLichCongTac
            // 
            this.m_dgvLichCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_dgvLichCongTac.DefaultCellStyle = dataGridViewCellStyle1;
            this.m_dgvLichCongTac.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.m_dgvLichCongTac.Location = new System.Drawing.Point(274, 12);
            this.m_dgvLichCongTac.Name = "m_dgvLichCongTac";
            this.m_dgvLichCongTac.Size = new System.Drawing.Size(187, 282);
            this.m_dgvLichCongTac.TabIndex = 30;
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 304);
            this.Controls.Add(this.m_dgvLichCongTac);
            this.Controls.Add(this.itemPanel2);
            this.Controls.Add(this.itemPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhanCong";
            this.Text = "Phân Công Nhân Viên";
            this.itemPanel1.ResumeLayout(false);
            this.itemPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvLichCongTac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX m_lblNgayVaoLam;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ButtonX m_btnThem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cbxCa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cbxThu;
        private DevComponents.DotNetBar.ItemPanel itemPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtMaNV;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtHoNV;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtTenNV;
        private DevComponents.DotNetBar.LabelX m_lblTenNV;
        private DevComponents.DotNetBar.LabelX m_lblMaNV;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Controls.DataGridViewX m_dgvLichCongTac;


    }
}