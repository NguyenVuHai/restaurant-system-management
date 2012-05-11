namespace RestaurantApp_G21.GUI.KhoHang.NhaCungCap
{
    partial class uc_traCuuNCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt_chonAll = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_ngungGiaoDich = new System.Windows.Forms.Button();
            this.bt_inDanhSach = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_ds = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tinTrangGiaoDich = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tinhTrangNo = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_them = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // bt_chonAll
            // 
            this.bt_chonAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_chonAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chonAll.Location = new System.Drawing.Point(0, 0);
            this.bt_chonAll.Name = "bt_chonAll";
            this.bt_chonAll.Size = new System.Drawing.Size(108, 30);
            this.bt_chonAll.TabIndex = 23;
            this.bt_chonAll.Text = "Chọn tất cả";
            this.toolTip1.SetToolTip(this.bt_chonAll, "Chọn tất cả những dòng để có thể thao tác được.");
            this.bt_chonAll.UseVisualStyleBackColor = true;
            this.bt_chonAll.Click += new System.EventHandler(this.bt_chonAll_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_sua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(108, 0);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 30);
            this.bt_sua.TabIndex = 24;
            this.bt_sua.Text = "Sửa";
            this.toolTip1.SetToolTip(this.bt_sua, "Click nút này để những dòng có check có thể thao tác được.\r\n\r\nSửa thông tin trực " +
                    "tiếp trên danh sách đang hiển thị.");
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_ngungGiaoDich
            // 
            this.bt_ngungGiaoDich.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_ngungGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ngungGiaoDich.Location = new System.Drawing.Point(258, 0);
            this.bt_ngungGiaoDich.Name = "bt_ngungGiaoDich";
            this.bt_ngungGiaoDich.Size = new System.Drawing.Size(142, 30);
            this.bt_ngungGiaoDich.TabIndex = 26;
            this.bt_ngungGiaoDich.Text = "Ngừng giao dịch";
            this.toolTip1.SetToolTip(this.bt_ngungGiaoDich, "Ngừng giao dịch với những dòng đã chọn");
            this.bt_ngungGiaoDich.UseVisualStyleBackColor = true;
            this.bt_ngungGiaoDich.Click += new System.EventHandler(this.bt_ngungGiaoDich_Click);
            // 
            // bt_inDanhSach
            // 
            this.bt_inDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_inDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inDanhSach.Location = new System.Drawing.Point(400, 0);
            this.bt_inDanhSach.Name = "bt_inDanhSach";
            this.bt_inDanhSach.Size = new System.Drawing.Size(109, 30);
            this.bt_inDanhSach.TabIndex = 27;
            this.bt_inDanhSach.Text = "In danh sách";
            this.toolTip1.SetToolTip(this.bt_inDanhSach, "In ra danh sách đang hiển thị.");
            this.bt_inDanhSach.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RestaurantApp_G21.Properties.Resources._1334501745_bullet_toggle_plus;
            this.pictureBox4.Location = new System.Drawing.Point(3, 87);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 29);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kết quả tra cứu:";
            // 
            // grid_ds
            // 
            this.grid_ds.AllowUserToAddRows = false;
            this.grid_ds.AllowUserToDeleteRows = false;
            this.grid_ds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ds.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grid_ds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.cMaNhaCungCap,
            this.cTenNhaCungCap,
            this.cDienThoai,
            this.cSoTaiKhoan,
            this.cTongNo,
            this.cGiaoDich});
            this.grid_ds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_ds.Location = new System.Drawing.Point(0, 0);
            this.grid_ds.Name = "grid_ds";
            this.grid_ds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ds.Size = new System.Drawing.Size(990, 370);
            this.grid_ds.TabIndex = 15;
            this.grid_ds.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_ds_CellMouseDoubleClick);
            // 
            // cb
            // 
            this.cb.FillWeight = 50F;
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            // 
            // cMaNhaCungCap
            // 
            this.cMaNhaCungCap.FillWeight = 150F;
            this.cMaNhaCungCap.HeaderText = "Mã";
            this.cMaNhaCungCap.Name = "cMaNhaCungCap";
            this.cMaNhaCungCap.ReadOnly = true;
            // 
            // cTenNhaCungCap
            // 
            this.cTenNhaCungCap.FillWeight = 150F;
            this.cTenNhaCungCap.HeaderText = "Tên NCC";
            this.cTenNhaCungCap.Name = "cTenNhaCungCap";
            this.cTenNhaCungCap.ReadOnly = true;
            // 
            // cDienThoai
            // 
            this.cDienThoai.FillWeight = 150F;
            this.cDienThoai.HeaderText = "Số điện thoại";
            this.cDienThoai.Name = "cDienThoai";
            this.cDienThoai.ReadOnly = true;
            // 
            // cSoTaiKhoan
            // 
            this.cSoTaiKhoan.HeaderText = "Số Tài Khoản";
            this.cSoTaiKhoan.Name = "cSoTaiKhoan";
            // 
            // cTongNo
            // 
            this.cTongNo.FillWeight = 150F;
            this.cTongNo.HeaderText = "Tổng nợ";
            this.cTongNo.Name = "cTongNo";
            this.cTongNo.ReadOnly = true;
            // 
            // cGiaoDich
            // 
            this.cGiaoDich.HeaderText = "Giao dịch";
            this.cGiaoDich.Name = "cGiaoDich";
            this.cGiaoDich.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra cứu thông tin Nhà Cung Cấp:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox1.Location = new System.Drawing.Point(43, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RestaurantApp_G21.Properties.Resources._1334501745_bullet_toggle_plus;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên/ Mã:";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(148, 45);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(259, 20);
            this.txt_ten.TabIndex = 4;
            this.txt_ten.TextChanged += new System.EventHandler(this.txt_ten_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tình trạng giao dịch:";
            // 
            // cb_tinTrangGiaoDich
            // 
            this.cb_tinTrangGiaoDich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tinTrangGiaoDich.FormattingEnabled = true;
            this.cb_tinTrangGiaoDich.Items.AddRange(new object[] {
            "Tất cả",
            "Ngừng",
            "Có",
            "Chưa từng"});
            this.cb_tinTrangGiaoDich.Location = new System.Drawing.Point(614, 45);
            this.cb_tinTrangGiaoDich.Name = "cb_tinTrangGiaoDich";
            this.cb_tinTrangGiaoDich.Size = new System.Drawing.Size(175, 21);
            this.cb_tinTrangGiaoDich.TabIndex = 7;
            this.cb_tinTrangGiaoDich.SelectedIndexChanged += new System.EventHandler(this.cb_tinTrangGiaoDich_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tình trạng nợ:";
            this.label4.Visible = false;
            // 
            // cb_tinhTrangNo
            // 
            this.cb_tinhTrangNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tinhTrangNo.FormattingEnabled = true;
            this.cb_tinhTrangNo.Items.AddRange(new object[] {
            "Tất cả",
            "Có",
            "Không",
            "Đến hạn"});
            this.cb_tinhTrangNo.Location = new System.Drawing.Point(614, 9);
            this.cb_tinhTrangNo.Name = "cb_tinhTrangNo";
            this.cb_tinhTrangNo.Size = new System.Drawing.Size(175, 21);
            this.cb_tinhTrangNo.TabIndex = 10;
            this.cb_tinhTrangNo.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox5.Location = new System.Drawing.Point(425, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 29);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox3.Location = new System.Drawing.Point(425, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ten);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_tinTrangGiaoDich);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.cb_tinhTrangNo);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 126);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_inDanhSach);
            this.panel2.Controls.Add(this.bt_ngungGiaoDich);
            this.panel2.Controls.Add(this.bt_them);
            this.panel2.Controls.Add(this.bt_sua);
            this.panel2.Controls.Add(this.bt_chonAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 30);
            this.panel2.TabIndex = 23;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // bt_them
            // 
            this.bt_them.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(183, 0);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 30);
            this.bt_them.TabIndex = 25;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid_ds);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 370);
            this.panel3.TabIndex = 24;
            // 
            // uc_traCuuNCC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_traCuuNCC";
            this.Size = new System.Drawing.Size(990, 526);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid_ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tinTrangGiaoDich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tinhTrangNo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_inDanhSach;
        private System.Windows.Forms.Button bt_ngungGiaoDich;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_chonAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGiaoDich;
    }
}
