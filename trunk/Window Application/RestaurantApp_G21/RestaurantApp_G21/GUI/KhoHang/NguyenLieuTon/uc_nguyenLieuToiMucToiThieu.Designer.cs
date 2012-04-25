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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_ds = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuognTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSucChuaToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_ds
            // 
            this.grid_ds.AllowUserToDeleteRows = false;
            this.grid_ds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ds.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.cma,
            this.cten,
            this.cLuognTon,
            this.cConTrong,
            this.cSucChuaToiThieu,
            this.cLuongTon,
            this.cDonVi});
            this.grid_ds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_ds.Location = new System.Drawing.Point(0, 0);
            this.grid_ds.Name = "grid_ds";
            this.grid_ds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ds.Size = new System.Drawing.Size(942, 525);
            this.grid_ds.TabIndex = 77;
            // 
            // cb
            // 
            this.cb.FillWeight = 50F;
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            this.cb.TrueValue = "";
            // 
            // cma
            // 
            this.cma.FillWeight = 150F;
            this.cma.HeaderText = "Mã nguyên liệu";
            this.cma.Name = "cma";
            this.cma.ReadOnly = true;
            // 
            // cten
            // 
            this.cten.FillWeight = 150F;
            this.cten.HeaderText = "Tên nguyên liệu";
            this.cten.Name = "cten";
            this.cten.ReadOnly = true;
            // 
            // cLuognTon
            // 
            this.cLuognTon.FillWeight = 80F;
            this.cLuognTon.HeaderText = "Lượng tồn";
            this.cLuognTon.Name = "cLuognTon";
            this.cLuognTon.ReadOnly = true;
            // 
            // cConTrong
            // 
            this.cConTrong.FillWeight = 80F;
            this.cConTrong.HeaderText = "Còn trống";
            this.cConTrong.Name = "cConTrong";
            this.cConTrong.ReadOnly = true;
            // 
            // cSucChuaToiThieu
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSucChuaToiThieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.cSucChuaToiThieu.HeaderText = "Chứa tối thiểu";
            this.cSucChuaToiThieu.Name = "cSucChuaToiThieu";
            this.cSucChuaToiThieu.ReadOnly = true;
            // 
            // cLuongTon
            // 
            this.cLuongTon.FillWeight = 90F;
            this.cLuongTon.HeaderText = "Lượng đặt";
            this.cLuongTon.Name = "cLuongTon";
            this.cLuongTon.ReadOnly = true;
            // 
            // cDonVi
            // 
            this.cDonVi.FillWeight = 90F;
            this.cDonVi.HeaderText = "Đơn vị";
            this.cDonVi.Name = "cDonVi";
            // 
            // uc_nguyenLieuToiMucToiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grid_ds);
            this.Name = "uc_nguyenLieuToiMucToiThieu";
            this.Size = new System.Drawing.Size(942, 525);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ds;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cma;
        private System.Windows.Forms.DataGridViewTextBoxColumn cten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLuognTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSucChuaToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonVi;
    }
}
