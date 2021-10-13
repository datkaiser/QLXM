namespace NET_DoAn
{
    partial class XuatHoaDon
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
            this.dgv_dskh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdh = new System.Windows.Forms.GroupBox();
            this.txtngayxuat = new System.Windows.Forms.DateTimePicker();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.dgvDonhang = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLapchitietdonhang = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.bttrove = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskh)).BeginInit();
            this.grdh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ XUẤT HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // dgv_dskh
            // 
            this.dgv_dskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dskh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_dskh.Location = new System.Drawing.Point(12, 68);
            this.dgv_dskh.Name = "dgv_dskh";
            this.dgv_dskh.Size = new System.Drawing.Size(643, 171);
            this.dgv_dskh.TabIndex = 0;
            this.dgv_dskh.SelectionChanged += new System.EventHandler(this.dgv_dskh_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên KH";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
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
            this.Column6.DataPropertyName = "Ghichu";
            this.Column6.HeaderText = "Ghi chú";
            this.Column6.Name = "Column6";
            // 
            // grdh
            // 
            this.grdh.Controls.Add(this.txtngayxuat);
            this.grdh.Controls.Add(this.cbManv);
            this.grdh.Controls.Add(this.txtMakh);
            this.grdh.Controls.Add(this.txtmahd);
            this.grdh.Controls.Add(this.dgvDonhang);
            this.grdh.Controls.Add(this.label5);
            this.grdh.Controls.Add(this.label4);
            this.grdh.Controls.Add(this.label3);
            this.grdh.Controls.Add(this.label2);
            this.grdh.Location = new System.Drawing.Point(3, 259);
            this.grdh.Name = "grdh";
            this.grdh.Size = new System.Drawing.Size(675, 343);
            this.grdh.TabIndex = 3;
            this.grdh.TabStop = false;
            this.grdh.Text = "Lập đơn hàng cho khách";
            // 
            // txtngayxuat
            // 
            this.txtngayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngayxuat.Location = new System.Drawing.Point(447, 91);
            this.txtngayxuat.Name = "txtngayxuat";
            this.txtngayxuat.Size = new System.Drawing.Size(170, 20);
            this.txtngayxuat.TabIndex = 6;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(135, 88);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(170, 21);
            this.cbManv.TabIndex = 5;
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(447, 42);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(170, 20);
            this.txtMakh.TabIndex = 3;
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(135, 40);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(170, 20);
            this.txtmahd.TabIndex = 3;
            // 
            // dgvDonhang
            // 
            this.dgvDonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDonhang.Location = new System.Drawing.Point(17, 162);
            this.dgvDonhang.Name = "dgvDonhang";
            this.dgvDonhang.Size = new System.Drawing.Size(643, 175);
            this.dgvDonhang.TabIndex = 2;
            this.dgvDonhang.Click += new System.EventHandler(this.dgvDonhang_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaHDX";
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
            this.Column9.DataPropertyName = "MaKH";
            this.Column9.HeaderText = "Mã KH";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "NgayXuat";
            this.Column10.HeaderText = "Ngày Xuất";
            this.Column10.Name = "Column10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã KH:";
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
            // btLapchitietdonhang
            // 
            this.btLapchitietdonhang.Image = global::NET_DoAn.Properties.Resources.iconfinder_print_printer_1500;
            this.btLapchitietdonhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLapchitietdonhang.Location = new System.Drawing.Point(703, 360);
            this.btLapchitietdonhang.Name = "btLapchitietdonhang";
            this.btLapchitietdonhang.Size = new System.Drawing.Size(246, 29);
            this.btLapchitietdonhang.TabIndex = 16;
            this.btLapchitietdonhang.Text = "Lập chi tiết đơn hàng";
            this.btLapchitietdonhang.UseVisualStyleBackColor = true;
            this.btLapchitietdonhang.Click += new System.EventHandler(this.btLapchitietdonhang_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = global::NET_DoAn.Properties.Resources.iconfinder_exit_3226;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(837, 289);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(109, 29);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::NET_DoAn.Properties.Resources.iconfinder_Remove_27874;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(703, 289);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(109, 29);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::NET_DoAn.Properties.Resources.iconfinder_edit_3218;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(837, 230);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(109, 29);
            this.btSua.TabIndex = 12;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::NET_DoAn.Properties.Resources.iconfinder_add_101239;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(703, 230);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 29);
            this.btThem.TabIndex = 13;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // bttrove
            // 
            this.bttrove.Image = global::NET_DoAn.Properties.Resources.iconfinder_Undo_27885;
            this.bttrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttrove.Location = new System.Drawing.Point(837, 171);
            this.bttrove.Name = "bttrove";
            this.bttrove.Size = new System.Drawing.Size(109, 29);
            this.bttrove.TabIndex = 14;
            this.bttrove.Text = "Trở về";
            this.bttrove.UseVisualStyleBackColor = true;
            this.bttrove.Click += new System.EventHandler(this.bttrove_Click);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Image = global::NET_DoAn.Properties.Resources.search__1_;
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(703, 171);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(109, 29);
            this.btTimkiem.TabIndex = 15;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(703, 103);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(243, 20);
            this.txtten.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nhập tên Khách Hàng:";
            // 
            // XuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 628);
            this.Controls.Add(this.btLapchitietdonhang);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.bttrove);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdh);
            this.Controls.Add(this.dgv_dskh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "XuatHoaDon";
            this.Text = "XuatHoaDon";
            this.Load += new System.EventHandler(this.XuatHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskh)).EndInit();
            this.grdh.ResumeLayout(false);
            this.grdh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dskh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox grdh;
        private System.Windows.Forms.DateTimePicker txtngayxuat;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.DataGridView dgvDonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLapchitietdonhang;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button bttrove;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label6;
    }
}