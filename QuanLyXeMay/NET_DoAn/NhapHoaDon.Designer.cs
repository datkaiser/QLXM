namespace NET_DoAn
{
    partial class NhapHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsncc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdh = new System.Windows.Forms.GroupBox();
            this.txtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtmahdn = new System.Windows.Forms.TextBox();
            this.dgvhoadonnhap = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btLapchitietdonhang = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.bttrove = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsncc)).BeginInit();
            this.grdh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ NHẬP HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsncc);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 202);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhà cung cấp";
            // 
            // dgv_dsncc
            // 
            this.dgv_dsncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_dsncc.Location = new System.Drawing.Point(17, 25);
            this.dgv_dsncc.Name = "dgv_dsncc";
            this.dgv_dsncc.Size = new System.Drawing.Size(643, 171);
            this.dgv_dsncc.TabIndex = 0;
            this.dgv_dsncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsncc_CellContentClick);
            this.dgv_dsncc.SelectionChanged += new System.EventHandler(this.dgv_dsncc_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNCC";
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diachi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SDT";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Email";
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            // 
            // grdh
            // 
            this.grdh.Controls.Add(this.txtngaynhap);
            this.grdh.Controls.Add(this.cbManv);
            this.grdh.Controls.Add(this.txtMaNCC);
            this.grdh.Controls.Add(this.txtmahdn);
            this.grdh.Controls.Add(this.dgvhoadonnhap);
            this.grdh.Controls.Add(this.label5);
            this.grdh.Controls.Add(this.label4);
            this.grdh.Controls.Add(this.label3);
            this.grdh.Controls.Add(this.label2);
            this.grdh.Location = new System.Drawing.Point(12, 247);
            this.grdh.Name = "grdh";
            this.grdh.Size = new System.Drawing.Size(675, 321);
            this.grdh.TabIndex = 11;
            this.grdh.TabStop = false;
            this.grdh.Text = "Lập đơn hàng nhập";
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaynhap.Location = new System.Drawing.Point(447, 91);
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(170, 20);
            this.txtngaynhap.TabIndex = 6;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(135, 88);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(170, 21);
            this.cbManv.TabIndex = 5;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(447, 42);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(170, 20);
            this.txtMaNCC.TabIndex = 3;
            // 
            // txtmahdn
            // 
            this.txtmahdn.Location = new System.Drawing.Point(135, 40);
            this.txtmahdn.Name = "txtmahdn";
            this.txtmahdn.Size = new System.Drawing.Size(170, 20);
            this.txtmahdn.TabIndex = 3;
            // 
            // dgvhoadonnhap
            // 
            this.dgvhoadonnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadonnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvhoadonnhap.Location = new System.Drawing.Point(17, 134);
            this.dgvhoadonnhap.Name = "dgvhoadonnhap";
            this.dgvhoadonnhap.Size = new System.Drawing.Size(643, 175);
            this.dgvhoadonnhap.TabIndex = 2;
            this.dgvhoadonnhap.Click += new System.EventHandler(this.dgvhoadonnhap_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaHDN";
            this.Column7.HeaderText = "Mã Hóa Đơn";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaNV";
            this.Column8.HeaderText = "Mã Nhân Viên";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaNCC";
            this.Column9.HeaderText = "Mã NCC";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "NgayNhap";
            this.Column10.HeaderText = "Ngày Nhập";
            this.Column10.Name = "Column10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(788, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nhập tên NCC";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(718, 70);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(214, 20);
            this.txtten.TabIndex = 13;
            // 
            // btLapchitietdonhang
            // 
            this.btLapchitietdonhang.Image = global::NET_DoAn.Properties.Resources.iconfinder_print_printer_1500;
            this.btLapchitietdonhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLapchitietdonhang.Location = new System.Drawing.Point(718, 299);
            this.btLapchitietdonhang.Name = "btLapchitietdonhang";
            this.btLapchitietdonhang.Size = new System.Drawing.Size(224, 29);
            this.btLapchitietdonhang.TabIndex = 26;
            this.btLapchitietdonhang.Text = "Lập chi tiết đơn hàng";
            this.btLapchitietdonhang.UseVisualStyleBackColor = true;
            this.btLapchitietdonhang.Click += new System.EventHandler(this.btLapchitietdonhang_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::NET_DoAn.Properties.Resources.iconfinder_Remove_27874;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(718, 229);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(103, 29);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::NET_DoAn.Properties.Resources.iconfinder_edit_32182;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(840, 173);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(102, 29);
            this.btSua.TabIndex = 21;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::NET_DoAn.Properties.Resources.iconfinder_add_101239;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(718, 173);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(103, 29);
            this.btThem.TabIndex = 22;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // bttrove
            // 
            this.bttrove.Image = global::NET_DoAn.Properties.Resources.iconfinder_Undo_27885;
            this.bttrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttrove.Location = new System.Drawing.Point(840, 114);
            this.bttrove.Name = "bttrove";
            this.bttrove.Size = new System.Drawing.Size(102, 29);
            this.bttrove.TabIndex = 23;
            this.bttrove.Text = "Trở về";
            this.bttrove.UseVisualStyleBackColor = true;
            this.bttrove.Click += new System.EventHandler(this.bttrove_Click);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Image = global::NET_DoAn.Properties.Resources.search__1_;
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(718, 114);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(103, 29);
            this.btTimkiem.TabIndex = 24;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = global::NET_DoAn.Properties.Resources.iconfinder_exit_3226;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(840, 229);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(102, 29);
            this.btThoat.TabIndex = 25;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // NhapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.btLapchitietdonhang);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.bttrove);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "NhapHoaDon";
            this.Text = "NhapHoaDon";
            this.Load += new System.EventHandler(this.NhapHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsncc)).EndInit();
            this.grdh.ResumeLayout(false);
            this.grdh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox grdh;
        private System.Windows.Forms.DateTimePicker txtngaynhap;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtmahdn;
        private System.Windows.Forms.DataGridView dgvhoadonnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btLapchitietdonhang;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button bttrove;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btThoat;

    }
}