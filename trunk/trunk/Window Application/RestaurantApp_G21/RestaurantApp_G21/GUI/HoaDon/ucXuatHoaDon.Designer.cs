namespace RestaurantApp_G21
{
    partial class ucXuatHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNgayThanhToan = new System.Windows.Forms.Label();
            this.dgvDanhSachMonAnThanhToan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.btnDaThanhToan = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNhaHangThanhToan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBanThanhToan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAnThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOÁ ĐƠN THANH TOÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // lbNgayThanhToan
            // 
            this.lbNgayThanhToan.AutoSize = true;
            this.lbNgayThanhToan.Location = new System.Drawing.Point(196, 44);
            this.lbNgayThanhToan.Name = "lbNgayThanhToan";
            this.lbNgayThanhToan.Size = new System.Drawing.Size(82, 13);
            this.lbNgayThanhToan.TabIndex = 2;
            this.lbNgayThanhToan.Text = "                         ";
            // 
            // dgvDanhSachMonAnThanhToan
            // 
            this.dgvDanhSachMonAnThanhToan.AllowUserToAddRows = false;
            this.dgvDanhSachMonAnThanhToan.AllowUserToDeleteRows = false;
            this.dgvDanhSachMonAnThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonAnThanhToan.Location = new System.Drawing.Point(4, 94);
            this.dgvDanhSachMonAnThanhToan.Name = "dgvDanhSachMonAnThanhToan";
            this.dgvDanhSachMonAnThanhToan.ReadOnly = true;
            this.dgvDanhSachMonAnThanhToan.RowHeadersVisible = false;
            this.dgvDanhSachMonAnThanhToan.Size = new System.Drawing.Size(432, 290);
            this.dgvDanhSachMonAnThanhToan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng cộng : ";
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(354, 395);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(82, 13);
            this.lblTongCong.TabIndex = 5;
            this.lblTongCong.Text = "                         ";
            // 
            // btnDaThanhToan
            // 
            this.btnDaThanhToan.Location = new System.Drawing.Point(4, 391);
            this.btnDaThanhToan.Name = "btnDaThanhToan";
            this.btnDaThanhToan.Size = new System.Drawing.Size(75, 21);
            this.btnDaThanhToan.TabIndex = 6;
            this.btnDaThanhToan.Text = "Thanh toán";
            this.btnDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(85, 391);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(75, 21);
            this.btnInHoaDon.TabIndex = 6;
            this.btnInHoaDon.Text = "In hoá đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhà hàng: ";
            // 
            // lblNhaHangThanhToan
            // 
            this.lblNhaHangThanhToan.AutoSize = true;
            this.lblNhaHangThanhToan.Location = new System.Drawing.Point(70, 75);
            this.lblNhaHangThanhToan.Name = "lblNhaHangThanhToan";
            this.lblNhaHangThanhToan.Size = new System.Drawing.Size(61, 13);
            this.lblNhaHangThanhToan.TabIndex = 7;
            this.lblNhaHangThanhToan.Text = "                  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bàn : ";
            // 
            // lblBanThanhToan
            // 
            this.lblBanThanhToan.AutoSize = true;
            this.lblBanThanhToan.Location = new System.Drawing.Point(223, 75);
            this.lblBanThanhToan.Name = "lblBanThanhToan";
            this.lblBanThanhToan.Size = new System.Drawing.Size(103, 13);
            this.lblBanThanhToan.TabIndex = 7;
            this.lblBanThanhToan.Text = "                                ";
            // 
            // ucXuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNhaHangThanhToan);
            this.Controls.Add(this.lblBanThanhToan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnDaThanhToan);
            this.Controls.Add(this.lblTongCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDanhSachMonAnThanhToan);
            this.Controls.Add(this.lbNgayThanhToan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucXuatHoaDon";
            this.Size = new System.Drawing.Size(449, 415);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAnThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNgayThanhToan;
        private System.Windows.Forms.DataGridView dgvDanhSachMonAnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Button btnDaThanhToan;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNhaHangThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBanThanhToan;
    }
}
