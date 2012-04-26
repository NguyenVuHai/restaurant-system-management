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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tinTrangGiaoDich = new System.Windows.Forms.ComboBox();
            this.cb_tinhTrangNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_tim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_ds = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_chonAll = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra cứu thông tin Nhà Cung Cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên/ Mã:";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(151, 45);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(259, 20);
            this.txt_ten.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 46);
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
            "Đã có",
            "Chưa từng"});
            this.cb_tinTrangGiaoDich.Location = new System.Drawing.Point(617, 45);
            this.cb_tinTrangGiaoDich.Name = "cb_tinTrangGiaoDich";
            this.cb_tinTrangGiaoDich.Size = new System.Drawing.Size(175, 21);
            this.cb_tinTrangGiaoDich.TabIndex = 7;
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
            this.cb_tinhTrangNo.Location = new System.Drawing.Point(617, 81);
            this.cb_tinhTrangNo.Name = "cb_tinhTrangNo";
            this.cb_tinhTrangNo.Size = new System.Drawing.Size(175, 21);
            this.cb_tinhTrangNo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tình trạng nợ:";
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Location = new System.Drawing.Point(810, 63);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(51, 39);
            this.bt_tim.TabIndex = 11;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kết quả tìm kiếm:";
            // 
            // grid_ds
            // 
            this.grid_ds.AllowUserToDeleteRows = false;
            this.grid_ds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ds.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.ma,
            this.tenNCC,
            this.soDT,
            this.tongNo,
            this.giaoDich});
            this.grid_ds.Location = new System.Drawing.Point(6, 154);
            this.grid_ds.Name = "grid_ds";
            this.grid_ds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ds.Size = new System.Drawing.Size(928, 331);
            this.grid_ds.TabIndex = 15;
            this.grid_ds.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_ds_CellMouseDoubleClick);
            // 
            // cb
            // 
            this.cb.FillWeight = 50F;
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            // 
            // ma
            // 
            this.ma.FillWeight = 150F;
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // tenNCC
            // 
            this.tenNCC.FillWeight = 150F;
            this.tenNCC.HeaderText = "Tên NCC";
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.ReadOnly = true;
            // 
            // soDT
            // 
            this.soDT.FillWeight = 150F;
            this.soDT.HeaderText = "Số điện thoại";
            this.soDT.Name = "soDT";
            this.soDT.ReadOnly = true;
            // 
            // tongNo
            // 
            this.tongNo.FillWeight = 150F;
            this.tongNo.HeaderText = "Tổng nợ";
            this.tongNo.Name = "tongNo";
            this.tongNo.ReadOnly = true;
            // 
            // giaoDich
            // 
            this.giaoDich.HeaderText = "Giao dịch";
            this.giaoDich.Name = "giaoDich";
            this.giaoDich.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(120, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_chonAll
            // 
            this.bt_chonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chonAll.Location = new System.Drawing.Point(6, 491);
            this.bt_chonAll.Name = "bt_chonAll";
            this.bt_chonAll.Size = new System.Drawing.Size(108, 28);
            this.bt_chonAll.TabIndex = 18;
            this.bt_chonAll.Text = "Chọn tất cả";
            this.toolTip1.SetToolTip(this.bt_chonAll, "Chọn tất cả những dòng để có thể thao tác được.");
            this.bt_chonAll.UseVisualStyleBackColor = true;
            this.bt_chonAll.Click += new System.EventHandler(this.bt_chonAll_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(200, 491);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 28);
            this.bt_sua.TabIndex = 19;
            this.bt_sua.Text = "Sửa";
            this.toolTip1.SetToolTip(this.bt_sua, "Click nút này để những dòng có check có thể thao tác được.\r\n\r\nSửa thông tin trực " +
                    "tiếp trên danh sách đang hiển thị.");
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(280, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 28);
            this.button5.TabIndex = 20;
            this.button5.Text = "Ngừng giao dịch";
            this.toolTip1.SetToolTip(this.button5, "Ngừng giao dịch với những dòng đã chọn");
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(428, 491);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 28);
            this.button6.TabIndex = 21;
            this.button6.Text = "In danh sách";
            this.toolTip1.SetToolTip(this.button6, "In ra danh sách đang hiển thị.");
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox3.Location = new System.Drawing.Point(428, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox5.Location = new System.Drawing.Point(428, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 29);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RestaurantApp_G21.Properties.Resources._1334501745_bullet_toggle_plus;
            this.pictureBox4.Location = new System.Drawing.Point(6, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 29);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RestaurantApp_G21.Properties.Resources._1334501745_bullet_toggle_plus;
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantApp_G21.Properties.Resources._1334501656_bullet_black;
            this.pictureBox1.Location = new System.Drawing.Point(46, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.TabIndex = 1;
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
            // uc_traCuuNCC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_chonAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grid_ds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.cb_tinhTrangNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cb_tinTrangGiaoDich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "uc_traCuuNCC";
            this.Size = new System.Drawing.Size(990, 526);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tinTrangGiaoDich;
        private System.Windows.Forms.ComboBox cb_tinhTrangNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid_ds;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_chonAll;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaoDich;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
