namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    partial class uc_nguyenLieuToiMucToiThieu
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
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.cMaNguyenLieu,
            this.cTenNguyenLieu,
            this.cLuongTon,
            this.cConTrong,
            this.cToiThieu,
            this.cLuongDat,
            this.cDonViTinh});
            this.grid_ds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_ds.Location = new System.Drawing.Point(0, 0);
            this.grid_ds.Name = "grid_ds";
            this.grid_ds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ds.Size = new System.Drawing.Size(942, 525);
            this.grid_ds.TabIndex = 77;
            this.grid_ds.Paint += new System.Windows.Forms.PaintEventHandler(this.grid_ds_Paint);
            this.grid_ds.Enter += new System.EventHandler(this.grid_ds_Enter);
            this.grid_ds.Layout += new System.Windows.Forms.LayoutEventHandler(this.grid_ds_Layout);
            // 
            // cb
            // 
            this.cb.FillWeight = 50F;
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            this.cb.TrueValue = "";
            // 
            // cMaNguyenLieu
            // 
            this.cMaNguyenLieu.FillWeight = 150F;
            this.cMaNguyenLieu.HeaderText = "Mã nguyên liệu";
            this.cMaNguyenLieu.Name = "cMaNguyenLieu";
            this.cMaNguyenLieu.ReadOnly = true;
            // 
            // cTenNguyenLieu
            // 
            this.cTenNguyenLieu.FillWeight = 150F;
            this.cTenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.cTenNguyenLieu.Name = "cTenNguyenLieu";
            this.cTenNguyenLieu.ReadOnly = true;
            // 
            // cLuongTon
            // 
            this.cLuongTon.FillWeight = 80F;
            this.cLuongTon.HeaderText = "Lượng tồn";
            this.cLuongTon.Name = "cLuongTon";
            this.cLuongTon.ReadOnly = true;
            // 
            // cConTrong
            // 
            this.cConTrong.FillWeight = 80F;
            this.cConTrong.HeaderText = "Còn trống";
            this.cConTrong.Name = "cConTrong";
            this.cConTrong.ReadOnly = true;
            // 
            // cToiThieu
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cToiThieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.cToiThieu.HeaderText = "Chứa tối thiểu";
            this.cToiThieu.Name = "cToiThieu";
            this.cToiThieu.ReadOnly = true;
            // 
            // cLuongDat
            // 
            this.cLuongDat.FillWeight = 90F;
            this.cLuongDat.HeaderText = "Lượng đặt";
            this.cLuongDat.Name = "cLuongDat";
            this.cLuongDat.ReadOnly = true;
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.FillWeight = 90F;
            this.cDonViTinh.HeaderText = "Đơn vị";
            this.cDonViTinh.Name = "cDonViTinh";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uc_nguyenLieuToiMucToiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grid_ds);
            this.Name = "uc_nguyenLieuToiMucToiThieu";
            this.Size = new System.Drawing.Size(942, 525);
            this.Load += new System.EventHandler(this.uc_nguyenLieuToiMucToiThieu_Load);
            this.Enter += new System.EventHandler(this.uc_nguyenLieuToiMucToiThieu_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ds;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonViTinh;
        private System.Windows.Forms.Timer timer1;
    }
}
