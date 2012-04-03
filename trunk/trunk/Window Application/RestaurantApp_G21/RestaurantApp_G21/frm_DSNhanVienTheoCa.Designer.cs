namespace RestaurantApp_G21
{
    partial class FormDSNhanVienTheoCa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_lblQuanLyNhanVien = new DevComponents.DotNetBar.LabelX();
            this.m_btnPhanCongThem = new DevComponents.DotNetBar.ButtonX();
            this.m_cbxLoaiNhanVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.m_cbxMaNhaHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.m_lblCa = new DevComponents.DotNetBar.LabelX();
            this.m_lblThu = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.m_colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colNhaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lblQuanLyNhanVien
            // 
            // 
            // 
            // 
            this.m_lblQuanLyNhanVien.BackgroundStyle.Class = "";
            this.m_lblQuanLyNhanVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_lblQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblQuanLyNhanVien.Location = new System.Drawing.Point(58, 0);
            this.m_lblQuanLyNhanVien.Name = "m_lblQuanLyNhanVien";
            this.m_lblQuanLyNhanVien.Size = new System.Drawing.Size(499, 44);
            this.m_lblQuanLyNhanVien.TabIndex = 26;
            this.m_lblQuanLyNhanVien.Text = "DANH SÁCH NHÂN VIÊN THEO CA";
            // 
            // m_btnPhanCongThem
            // 
            this.m_btnPhanCongThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnPhanCongThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnPhanCongThem.Location = new System.Drawing.Point(425, 83);
            this.m_btnPhanCongThem.Name = "m_btnPhanCongThem";
            this.m_btnPhanCongThem.Size = new System.Drawing.Size(162, 23);
            this.m_btnPhanCongThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnPhanCongThem.TabIndex = 31;
            this.m_btnPhanCongThem.Text = "Phân công thêm nhân viên";
            this.m_btnPhanCongThem.Click += new System.EventHandler(this.m_btnPhanCongThem_Click);
            // 
            // m_cbxLoaiNhanVien
            // 
            this.m_cbxLoaiNhanVien.DisplayMember = "Text";
            this.m_cbxLoaiNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.m_cbxLoaiNhanVien.FormattingEnabled = true;
            this.m_cbxLoaiNhanVien.ItemHeight = 16;
            this.m_cbxLoaiNhanVien.Location = new System.Drawing.Point(224, 84);
            this.m_cbxLoaiNhanVien.Name = "m_cbxLoaiNhanVien";
            this.m_cbxLoaiNhanVien.Size = new System.Drawing.Size(121, 22);
            this.m_cbxLoaiNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_cbxLoaiNhanVien.TabIndex = 29;
            // 
            // m_cbxMaNhaHang
            // 
            this.m_cbxMaNhaHang.DisplayMember = "Text";
            this.m_cbxMaNhaHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.m_cbxMaNhaHang.FormattingEnabled = true;
            this.m_cbxMaNhaHang.ItemHeight = 16;
            this.m_cbxMaNhaHang.Location = new System.Drawing.Point(58, 86);
            this.m_cbxMaNhaHang.Name = "m_cbxMaNhaHang";
            this.m_cbxMaNhaHang.Size = new System.Drawing.Size(121, 22);
            this.m_cbxMaNhaHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_cbxMaNhaHang.TabIndex = 30;
            // 
            // m_lblCa
            // 
            // 
            // 
            // 
            this.m_lblCa.BackgroundStyle.Class = "";
            this.m_lblCa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_lblCa.Location = new System.Drawing.Point(193, 84);
            this.m_lblCa.Name = "m_lblCa";
            this.m_lblCa.Size = new System.Drawing.Size(25, 23);
            this.m_lblCa.TabIndex = 27;
            this.m_lblCa.Text = "Ca:";
            // 
            // m_lblThu
            // 
            // 
            // 
            // 
            this.m_lblThu.BackgroundStyle.Class = "";
            this.m_lblThu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.m_lblThu.Location = new System.Drawing.Point(27, 85);
            this.m_lblThu.Name = "m_lblThu";
            this.m_lblThu.Size = new System.Drawing.Size(25, 23);
            this.m_lblThu.TabIndex = 28;
            this.m_lblThu.Text = "Thứ:";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colMaNV,
            this.m_colTenNV,
            this.m_colLoaiNV,
            this.m_colNhaHang,
            this.m_colDienThoai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(27, 130);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX1.Size = new System.Drawing.Size(560, 203);
            this.dataGridViewX1.TabIndex = 32;
            // 
            // m_colMaNV
            // 
            this.m_colMaNV.HeaderText = "Mã NV";
            this.m_colMaNV.Name = "m_colMaNV";
            // 
            // m_colTenNV
            // 
            this.m_colTenNV.HeaderText = "Tên NV";
            this.m_colTenNV.Name = "m_colTenNV";
            // 
            // m_colLoaiNV
            // 
            this.m_colLoaiNV.HeaderText = "Loại NV";
            this.m_colLoaiNV.Name = "m_colLoaiNV";
            // 
            // m_colNhaHang
            // 
            this.m_colNhaHang.HeaderText = "Nhà Hàng";
            this.m_colNhaHang.Name = "m_colNhaHang";
            // 
            // m_colDienThoai
            // 
            this.m_colDienThoai.HeaderText = "Điện thoại";
            this.m_colDienThoai.Name = "m_colDienThoai";
            // 
            // FormDSNhanVienTheoCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.m_lblQuanLyNhanVien);
            this.Controls.Add(this.m_btnPhanCongThem);
            this.Controls.Add(this.m_cbxLoaiNhanVien);
            this.Controls.Add(this.m_cbxMaNhaHang);
            this.Controls.Add(this.m_lblCa);
            this.Controls.Add(this.m_lblThu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDSNhanVienTheoCa";
            this.Text = "MetroForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX m_lblQuanLyNhanVien;
        private DevComponents.DotNetBar.ButtonX m_btnPhanCongThem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cbxLoaiNhanVien;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cbxMaNhaHang;
        private DevComponents.DotNetBar.LabelX m_lblCa;
        private DevComponents.DotNetBar.LabelX m_lblThu;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colNhaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colDienThoai;
    }
}