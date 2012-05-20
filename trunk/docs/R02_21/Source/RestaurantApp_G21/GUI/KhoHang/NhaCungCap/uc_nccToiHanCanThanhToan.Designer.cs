namespace RestaurantApp_G21.GUI.KhoHang.NhaCungCap
{
    partial class uc_nccToiHanCanThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_ds = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThoiDiemThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDinhMucNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_ds
            // 
            this.grid_ds.AllowUserToAddRows = false;
            this.grid_ds.AllowUserToDeleteRows = false;
            this.grid_ds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ds.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_ds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.cMaNhaCungCap,
            this.cTenNhaCungCap,
            this.cTongNo,
            this.cThoiDiemThanhToan,
            this.cDinhMucNo,
            this.cDienThoai,
            this.cSoTaiKhoan});
            this.grid_ds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_ds.Location = new System.Drawing.Point(0, 0);
            this.grid_ds.Name = "grid_ds";
            this.grid_ds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ds.Size = new System.Drawing.Size(990, 526);
            this.grid_ds.TabIndex = 78;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            // 
            // cb
            // 
            this.cb.FillWeight = 50F;
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            this.cb.TrueValue = "";
            // 
            // cMaNhaCungCap
            // 
            this.cMaNhaCungCap.FillWeight = 150F;
            this.cMaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            this.cMaNhaCungCap.Name = "cMaNhaCungCap";
            this.cMaNhaCungCap.ReadOnly = true;
            // 
            // cTenNhaCungCap
            // 
            this.cTenNhaCungCap.FillWeight = 150F;
            this.cTenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            this.cTenNhaCungCap.Name = "cTenNhaCungCap";
            this.cTenNhaCungCap.ReadOnly = true;
            // 
            // cTongNo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cTongNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.cTongNo.HeaderText = "Tổng nợ";
            this.cTongNo.Name = "cTongNo";
            this.cTongNo.ReadOnly = true;
            // 
            // cThoiDiemThanhToan
            // 
            this.cThoiDiemThanhToan.FillWeight = 90F;
            this.cThoiDiemThanhToan.HeaderText = "Thời điểm thanh toán";
            this.cThoiDiemThanhToan.Name = "cThoiDiemThanhToan";
            this.cThoiDiemThanhToan.ReadOnly = true;
            // 
            // cDinhMucNo
            // 
            this.cDinhMucNo.FillWeight = 90F;
            this.cDinhMucNo.HeaderText = "Định mức nợ";
            this.cDinhMucNo.Name = "cDinhMucNo";
            this.cDinhMucNo.ReadOnly = true;
            // 
            // cDienThoai
            // 
            this.cDienThoai.FillWeight = 80F;
            this.cDienThoai.HeaderText = "Điện thoại";
            this.cDienThoai.Name = "cDienThoai";
            this.cDienThoai.ReadOnly = true;
            // 
            // cSoTaiKhoan
            // 
            this.cSoTaiKhoan.FillWeight = 80F;
            this.cSoTaiKhoan.HeaderText = "Số tài khoản";
            this.cSoTaiKhoan.Name = "cSoTaiKhoan";
            this.cSoTaiKhoan.ReadOnly = true;
            // 
            // uc_nccToiHanCanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grid_ds);
            this.Name = "uc_nccToiHanCanThanhToan";
            this.Size = new System.Drawing.Size(990, 526);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThoiDiemThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDinhMucNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoTaiKhoan;

    }
}
