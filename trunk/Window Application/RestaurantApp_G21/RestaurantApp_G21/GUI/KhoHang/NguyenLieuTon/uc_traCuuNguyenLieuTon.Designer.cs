namespace RestaurantApp_G21.GUI.KhoHang.NguyenLieuTon
{
    partial class uc_traCuuNguyenLieuTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_traCuuNguyenLieuTon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_inDanhSach = new System.Windows.Forms.Button();
            this.bt_chonTatCa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_ds = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_loaiMonAn = new System.Windows.Forms.ComboBox();
            this.cb_monAn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bt_lamTuoi = new System.Windows.Forms.Button();
            this.lb_soLuongKQ = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cMaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_inDanhSach
            // 
            this.bt_inDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inDanhSach.Location = new System.Drawing.Point(410, 491);
            this.bt_inDanhSach.Name = "bt_inDanhSach";
            this.bt_inDanhSach.Size = new System.Drawing.Size(109, 28);
            this.bt_inDanhSach.TabIndex = 41;
            this.bt_inDanhSach.Text = "In danh sách";
            this.bt_inDanhSach.UseVisualStyleBackColor = true;
            // 
            // bt_chonTatCa
            // 
            this.bt_chonTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chonTatCa.Location = new System.Drawing.Point(3, 491);
            this.bt_chonTatCa.Name = "bt_chonTatCa";
            this.bt_chonTatCa.Size = new System.Drawing.Size(108, 28);
            this.bt_chonTatCa.TabIndex = 38;
            this.bt_chonTatCa.Text = "Chọn tất cả";
            this.bt_chonTatCa.UseVisualStyleBackColor = true;
            this.bt_chonTatCa.Click += new System.EventHandler(this.bt_chonTatCa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(117, 491);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(85, 28);
            this.bt_them.TabIndex = 37;
            this.bt_them.Text = "Thêm";
            this.toolTip1.SetToolTip(this.bt_them, resources.GetString("bt_them.ToolTip"));
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(208, 491);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(91, 28);
            this.bt_sua.TabIndex = 39;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tra cứu lượng tồn:";
            // 
            // grid_ds
            // 
            this.grid_ds.AllowUserToAddRows = false;
            this.grid_ds.AllowUserToDeleteRows = false;
            this.grid_ds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ds.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.cMaNguyenLieu,
            this.cTenNguyenLieu,
            this.cLuongTon,
            this.cConTrong,
            this.cToiDa,
            this.cToiThieu,
            this.cDonViTinh});
            this.grid_ds.Location = new System.Drawing.Point(3, 191);
            this.grid_ds.Name = "grid_ds";
            this.grid_ds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ds.Size = new System.Drawing.Size(928, 294);
            this.grid_ds.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Kết quả tìm kiếm:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(829, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 39);
            this.button1.TabIndex = 32;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên/ Mã:";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(148, 45);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(259, 20);
            this.txt_ten.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Theo loại món ăn:";
            // 
            // cb_loaiMonAn
            // 
            this.cb_loaiMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaiMonAn.FormattingEnabled = true;
            this.cb_loaiMonAn.Location = new System.Drawing.Point(595, 45);
            this.cb_loaiMonAn.Name = "cb_loaiMonAn";
            this.cb_loaiMonAn.Size = new System.Drawing.Size(225, 21);
            this.cb_loaiMonAn.TabIndex = 31;
            this.cb_loaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cb_loaiMonAn_SelectedIndexChanged);
            // 
            // cb_monAn
            // 
            this.cb_monAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_monAn.FormattingEnabled = true;
            this.cb_monAn.Location = new System.Drawing.Point(595, 81);
            this.cb_monAn.Name = "cb_monAn";
            this.cb_monAn.Size = new System.Drawing.Size(225, 21);
            this.cb_monAn.TabIndex = 44;
            this.cb_monAn.SelectedIndexChanged += new System.EventHandler(this.cb_monAn_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Theo món ăn:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox6.Location = new System.Drawing.Point(425, 74);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 29);
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox5.Location = new System.Drawing.Point(425, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 29);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RestaurantApp_G21.Properties.Resources._1334501745_bullet_toggle_plus;
            this.pictureBox4.Location = new System.Drawing.Point(3, 156);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 29);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RestaurantApp_G21.Properties.Resources._1334501745_bullet_toggle_plus;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox1.Location = new System.Drawing.Point(43, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 200;
            this.toolTip1.ShowAlways = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "(Nếu có (*) thì bắt buột nhập)";
            // 
            // bt_lamTuoi
            // 
            this.bt_lamTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lamTuoi.Location = new System.Drawing.Point(305, 491);
            this.bt_lamTuoi.Name = "bt_lamTuoi";
            this.bt_lamTuoi.Size = new System.Drawing.Size(99, 28);
            this.bt_lamTuoi.TabIndex = 47;
            this.bt_lamTuoi.Text = "Làm tươi";
            this.bt_lamTuoi.UseVisualStyleBackColor = true;
            // 
            // lb_soLuongKQ
            // 
            this.lb_soLuongKQ.AutoSize = true;
            this.lb_soLuongKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soLuongKQ.Location = new System.Drawing.Point(164, 164);
            this.lb_soLuongKQ.Name = "lb_soLuongKQ";
            this.lb_soLuongKQ.Size = new System.Drawing.Size(16, 16);
            this.lb_soLuongKQ.TabIndex = 48;
            this.lb_soLuongKQ.Text = "0";
            // 
            // cb
            // 
            this.cb.FillWeight = 50F;
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
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
            // cToiDa
            // 
            this.cToiDa.FillWeight = 90F;
            this.cToiDa.HeaderText = "Chứa tối đa";
            this.cToiDa.Name = "cToiDa";
            this.cToiDa.ReadOnly = true;
            // 
            // cToiThieu
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cToiThieu.DefaultCellStyle = dataGridViewCellStyle4;
            this.cToiThieu.HeaderText = "Chứa tối thiểu";
            this.cToiThieu.Name = "cToiThieu";
            this.cToiThieu.ReadOnly = true;
            // 
            // cDonViTinh
            // 
            this.cDonViTinh.FillWeight = 90F;
            this.cDonViTinh.HeaderText = "Đơn vị";
            this.cDonViTinh.Name = "cDonViTinh";
            this.cDonViTinh.ReadOnly = true;
            // 
            // uc_traCuuNguyenLieuTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_soLuongKQ);
            this.Controls.Add(this.bt_lamTuoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cb_monAn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_inDanhSach);
            this.Controls.Add(this.bt_chonTatCa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_ds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_loaiMonAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.pictureBox1);
            this.Name = "uc_traCuuNguyenLieuTon";
            this.Size = new System.Drawing.Size(990, 526);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_inDanhSach;
        private System.Windows.Forms.Button bt_chonTatCa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_ds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_loaiMonAn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cb_monAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_lamTuoi;
        private System.Windows.Forms.Label lb_soLuongKQ;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonViTinh;
    }
}
