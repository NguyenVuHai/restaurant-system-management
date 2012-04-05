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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.m_cBoxNhaHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.m_cBoxKhuVuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.m_cboxGhe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.m_btnTimBan = new DevComponents.DotNetBar.ButtonX();
            this.m_btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.dgvDanhSachBan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
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
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(82, 92);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Ghế";
            // 
            // m_cboxGhe
            // 
            this.m_cboxGhe.DisplayMember = "Text";
            this.m_cboxGhe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.m_cboxGhe.ForeColor = System.Drawing.Color.Black;
            this.m_cboxGhe.FormattingEnabled = true;
            this.m_cboxGhe.ItemHeight = 16;
            this.m_cboxGhe.Location = new System.Drawing.Point(146, 93);
            this.m_cboxGhe.Name = "m_cboxGhe";
            this.m_cboxGhe.Size = new System.Drawing.Size(180, 22);
            this.m_cboxGhe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_cboxGhe.TabIndex = 1;
            // 
            // m_btnTimBan
            // 
            this.m_btnTimBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.m_btnTimBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.m_btnTimBan.Location = new System.Drawing.Point(247, 169);
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
            this.m_btnThoat.Location = new System.Drawing.Point(328, 169);
            this.m_btnThoat.Name = "m_btnThoat";
            this.m_btnThoat.Size = new System.Drawing.Size(75, 23);
            this.m_btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.m_btnThoat.TabIndex = 2;
            this.m_btnThoat.Text = "Thoát";
            this.m_btnThoat.Click += new System.EventHandler(this.m_btnThoat_Click);
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dgvDanhSachBan.Location = new System.Drawing.Point(12, 199);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.Size = new System.Drawing.Size(722, 256);
            this.dgvDanhSachBan.TabIndex = 6;
            // 
            // frmTimBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 467);
            this.Controls.Add(this.dgvDanhSachBan);
            this.Controls.Add(this.m_btnThoat);
            this.Controls.Add(this.m_btnTimBan);
            this.Controls.Add(this.m_cboxGhe);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.m_cBoxKhuVuc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.m_cBoxNhaHang);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTimBan";
            this.Text = "Tìm Bàn Trống";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cBoxNhaHang;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cBoxKhuVuc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx m_cboxGhe;
        private DevComponents.DotNetBar.ButtonX m_btnTimBan;
        private DevComponents.DotNetBar.ButtonX m_btnThoat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDanhSachBan;
    }
}