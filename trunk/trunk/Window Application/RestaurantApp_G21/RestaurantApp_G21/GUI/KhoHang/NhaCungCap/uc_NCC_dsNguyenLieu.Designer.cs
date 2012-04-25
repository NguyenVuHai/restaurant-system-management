namespace RestaurantApp_G21.GUI.KhoHang.NhaCungCap
{
    partial class uc_NCC_dsNguyenLieu
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
            this.label6 = new System.Windows.Forms.Label();
            this.bt_inDanhSach = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_chonTatCa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.lb_tongSo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gv_nguyenLieuCC = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_nguyenLieuCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tổng số:";
            // 
            // bt_inDanhSach
            // 
            this.bt_inDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inDanhSach.Location = new System.Drawing.Point(256, 293);
            this.bt_inDanhSach.Name = "bt_inDanhSach";
            this.bt_inDanhSach.Size = new System.Drawing.Size(105, 28);
            this.bt_inDanhSach.TabIndex = 29;
            this.bt_inDanhSach.Text = "In danh sách";
            this.bt_inDanhSach.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(198, 293);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(52, 28);
            this.bt_xoa.TabIndex = 27;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // bt_chonTatCa
            // 
            this.bt_chonTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chonTatCa.Location = new System.Drawing.Point(33, 293);
            this.bt_chonTatCa.Name = "bt_chonTatCa";
            this.bt_chonTatCa.Size = new System.Drawing.Size(94, 28);
            this.bt_chonTatCa.TabIndex = 26;
            this.bt_chonTatCa.Text = "Chọn tất cả";
            this.bt_chonTatCa.UseVisualStyleBackColor = true;
            this.bt_chonTatCa.Click += new System.EventHandler(this.bt_chonTatCa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(133, 293);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(59, 28);
            this.bt_them.TabIndex = 25;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // lb_tongSo
            // 
            this.lb_tongSo.AutoSize = true;
            this.lb_tongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongSo.Location = new System.Drawing.Point(422, 299);
            this.lb_tongSo.Name = "lb_tongSo";
            this.lb_tongSo.Size = new System.Drawing.Size(15, 16);
            this.lb_tongSo.TabIndex = 30;
            this.lb_tongSo.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 35);
            this.panel1.TabIndex = 31;
            // 
            // gv_nguyenLieuCC
            // 
            this.gv_nguyenLieuCC.AllowUserToDeleteRows = false;
            this.gv_nguyenLieuCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_nguyenLieuCC.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gv_nguyenLieuCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_nguyenLieuCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_nguyenLieuCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_nguyenLieuCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.stt,
            this.ma,
            this.tenNL});
            this.gv_nguyenLieuCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gv_nguyenLieuCC.Location = new System.Drawing.Point(0, 0);
            this.gv_nguyenLieuCC.Name = "gv_nguyenLieuCC";
            this.gv_nguyenLieuCC.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.gv_nguyenLieuCC.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_nguyenLieuCC.Size = new System.Drawing.Size(518, 283);
            this.gv_nguyenLieuCC.TabIndex = 22;
            // 
            // cb
            // 
            this.cb.FillWeight = 50F;
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            this.cb.ReadOnly = true;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // tenNL
            // 
            this.tenNL.FillWeight = 150F;
            this.tenNL.HeaderText = "Tên Nguyên Liệu";
            this.tenNL.Name = "tenNL";
            this.tenNL.ReadOnly = true;
            // 
            // uc_NCC_dsNguyenLieu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_tongSo);
            this.Controls.Add(this.bt_inDanhSach);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_chonTatCa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gv_nguyenLieuCC);
            this.Controls.Add(this.panel1);
            this.Name = "uc_NCC_dsNguyenLieu";
            this.Size = new System.Drawing.Size(518, 324);
            ((System.ComponentModel.ISupportInitialize)(this.gv_nguyenLieuCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_inDanhSach;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_chonTatCa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label lb_tongSo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gv_nguyenLieuCC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNL;
    }
}
