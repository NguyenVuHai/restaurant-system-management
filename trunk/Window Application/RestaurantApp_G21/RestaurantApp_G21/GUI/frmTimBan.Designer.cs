namespace RestaurantApp_G21
{
    partial class frmTimBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.m_cBoxNhaHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.m_cBoxKhuVuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.m_btnTimBan = new DevComponents.DotNetBar.ButtonX();
            this.m_btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.dgvDanhSachBan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.m_txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.m_textBoxBuoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.m_dateTimeInputNgayDatBan = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dateTimeInputNgayDatBan)).BeginInit();
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
            this.labelX1.Location = new System.Drawing.Point(82, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nhà Hàng";
            // 
            // m_cBoxNhaHang
            // 
            this.m_cBoxNhaHang.DisplayMember = "Text";
            this.m_cBoxNhaHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.m_cBoxNhaHang.ForeColor = System.Drawing.Color.Black;
            this.m_cBoxNhaHang.FormattingEnabled = true;
            this.m_cBoxNhaHang.ItemHeight = 16;
            this.m_cBoxNhaHang.Location = new System.Drawing.Point(146, 37);
            this.m_cBoxNhaHang.Name = "m_cBoxNhaHang";
            this.m_cBoxNhaHang.Size = new System.Drawing.Size(180, 22);
            this.m_cBoxNhaHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_cBoxNhaHang.TabIndex = 1;
            this.m_cBoxNhaHang.SelectedIndexChanged += new System.EventHandler(this.m_cBoxNhaHang_SelectedIndexChanged);
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
            this.labelX2.Location = new System.Drawing.Point(82, 64);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Khu Vực";
            // 
            // m_cBoxKhuVuc
            // 
            this.m_cBoxKhuVuc.DisplayMember = "Text";
            this.m_cBoxKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.m_cBoxKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.m_cBoxKhuVuc.FormattingEnabled = true;
            this.m_cBoxKhuVuc.ItemHeight = 16;
            this.m_cBoxKhuVuc.Location = new System.Drawing.Point(146, 65);
            this.m_cBoxKhuVuc.Name = "m_cBoxKhuVuc";
            this.m_cBoxKhuVuc.Size = new System.Drawing.Size(180, 22);
            this.m_cBoxKhuVuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_cBoxKhuVuc.TabIndex = 1;
            // 
            // m_btnTimBan
            // 
            this.m_btnTimBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnTimBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnTimBan.Location = new System.Drawing.Point(249, 170);
            this.m_btnTimBan.Name = "m_btnTimBan";
            this.m_btnTimBan.Size = new System.Drawing.Size(75, 23);
            this.m_btnTimBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnTimBan.TabIndex = 2;
            this.m_btnTimBan.Text = "Tìm Bàn";
            this.m_btnTimBan.Click += new System.EventHandler(this.m_btnTimBan_Click);
            // 
            // m_btnThoat
            // 
            this.m_btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnThoat.Location = new System.Drawing.Point(330, 170);
            this.m_btnThoat.Name = "m_btnThoat";
            this.m_btnThoat.Size = new System.Drawing.Size(75, 23);
            this.m_btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnThoat.TabIndex = 2;
            this.m_btnThoat.Text = "Thoát";
            this.m_btnThoat.Click += new System.EventHandler(this.m_btnThoat_Click);
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachBan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dgvDanhSachBan.Location = new System.Drawing.Point(12, 199);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachBan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachBan.Size = new System.Drawing.Size(722, 256);
            this.dgvDanhSachBan.TabIndex = 6;
            // 
            // m_txtSoLuong
            // 
            this.m_txtSoLuong.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_txtSoLuong.Border.Class = "TextBoxBorder";
            this.m_txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.m_txtSoLuong.Location = new System.Drawing.Point(462, 36);
            this.m_txtSoLuong.Name = "m_txtSoLuong";
            this.m_txtSoLuong.Size = new System.Drawing.Size(233, 22);
            this.m_txtSoLuong.TabIndex = 7;
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
            this.labelX4.Location = new System.Drawing.Point(381, 33);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Số lượng";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(381, 65);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Ngày đặt bàn";
            // 
            // m_textBoxBuoi
            // 
            this.m_textBoxBuoi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_textBoxBuoi.Border.Class = "TextBoxBorder";
            this.m_textBoxBuoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_textBoxBuoi.ForeColor = System.Drawing.Color.Black;
            this.m_textBoxBuoi.Location = new System.Drawing.Point(462, 93);
            this.m_textBoxBuoi.Name = "m_textBoxBuoi";
            this.m_textBoxBuoi.Size = new System.Drawing.Size(233, 22);
            this.m_textBoxBuoi.TabIndex = 7;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(381, 94);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "Buổi";
            // 
            // m_dateTimeInputNgayDatBan
            // 
            this.m_dateTimeInputNgayDatBan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.m_dateTimeInputNgayDatBan.BackgroundStyle.Class = "DateTimeInputBackground";
            this.m_dateTimeInputNgayDatBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_dateTimeInputNgayDatBan.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.m_dateTimeInputNgayDatBan.ButtonDropDown.Visible = true;
            this.m_dateTimeInputNgayDatBan.ForeColor = System.Drawing.Color.Black;
            this.m_dateTimeInputNgayDatBan.IsPopupCalendarOpen = false;
            this.m_dateTimeInputNgayDatBan.Location = new System.Drawing.Point(462, 64);
            // 
            // 
            // 
            this.m_dateTimeInputNgayDatBan.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.m_dateTimeInputNgayDatBan.MonthCalendar.BackgroundStyle.Class = "";
            this.m_dateTimeInputNgayDatBan.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.m_dateTimeInputNgayDatBan.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.m_dateTimeInputNgayDatBan.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.DisplayMonth = new System.DateTime(2012, 4, 1, 0, 0, 0, 0);
            this.m_dateTimeInputNgayDatBan.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.m_dateTimeInputNgayDatBan.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.m_dateTimeInputNgayDatBan.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.m_dateTimeInputNgayDatBan.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.TodayButtonVisible = true;
            this.m_dateTimeInputNgayDatBan.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.m_dateTimeInputNgayDatBan.Name = "m_dateTimeInputNgayDatBan";
            this.m_dateTimeInputNgayDatBan.Size = new System.Drawing.Size(200, 22);
            this.m_dateTimeInputNgayDatBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_dateTimeInputNgayDatBan.TabIndex = 23;
            // 
            // frmTimBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 467);
            this.Controls.Add(this.m_dateTimeInputNgayDatBan);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.m_textBoxBuoi);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.m_txtSoLuong);
            this.Controls.Add(this.dgvDanhSachBan);
            this.Controls.Add(this.m_btnThoat);
            this.Controls.Add(this.m_btnTimBan);
            this.Controls.Add(this.m_cBoxKhuVuc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.m_cBoxNhaHang);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTimBan";
            this.Text = "Tìm Bàn Trống";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dateTimeInputNgayDatBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cBoxNhaHang;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cBoxKhuVuc;
        private DevComponents.DotNetBar.ButtonX m_btnTimBan;
        private DevComponents.DotNetBar.ButtonX m_btnThoat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDanhSachBan;
        private DevComponents.DotNetBar.Controls.TextBoxX m_txtSoLuong;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX m_textBoxBuoi;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput m_dateTimeInputNgayDatBan;
    }
}