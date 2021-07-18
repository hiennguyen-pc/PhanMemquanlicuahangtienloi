﻿namespace GUI
{
    partial class UCNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNhapHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.MAHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTT = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhaphang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHang);
            this.groupBox1.Controls.Add(this.cboTT);
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(26, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 254);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHG,
            this.TENHG,
            this.DVT,
            this.SoLuong,
            this.MANCC1,
            this.DonGia,
            this.TinhTrang});
            this.dgvHang.Location = new System.Drawing.Point(13, 68);
            this.dgvHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHang.MultiSelect = false;
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.ReadOnly = true;
            this.dgvHang.RowTemplate.Height = 24;
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHang.Size = new System.Drawing.Size(1057, 174);
            this.dgvHang.TabIndex = 14;
            // 
            // MAHG
            // 
            this.MAHG.DataPropertyName = "MAHG";
            this.MAHG.HeaderText = "Mã Hàng";
            this.MAHG.Name = "MAHG";
            this.MAHG.ReadOnly = true;
            // 
            // TENHG
            // 
            this.TENHG.DataPropertyName = "TENHG";
            this.TENHG.HeaderText = "Tên Hàng";
            this.TENHG.Name = "TENHG";
            this.TENHG.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SOLUONG";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // MANCC1
            // 
            this.MANCC1.DataPropertyName = "MANCC";
            this.MANCC1.HeaderText = "MÃ NCC";
            this.MANCC1.Name = "MANCC1";
            this.MANCC1.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DONGIA";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TINHTRANG";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // cboTT
            // 
            this.cboTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTT.FormattingEnabled = true;
            this.cboTT.Location = new System.Drawing.Point(833, 25);
            this.cboTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTT.Name = "cboTT";
            this.cboTT.Size = new System.Drawing.Size(221, 31);
            this.cboTT.TabIndex = 13;
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(165, 25);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(519, 31);
            this.cboNCC.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_PhieuNhap);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(26, 407);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1079, 223);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng thông tin phiếu nhập";
            // 
            // dgv_PhieuNhap
            // 
            this.dgv_PhieuNhap.AllowUserToAddRows = false;
            this.dgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.TENHANG,
            this.DVTinh,
            this.SL,
            this.MANCC,
            this.DonGia1,
            this.TinhTrang1});
            this.dgv_PhieuNhap.Location = new System.Drawing.Point(4, 23);
            this.dgv_PhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PhieuNhap.MultiSelect = false;
            this.dgv_PhieuNhap.Name = "dgv_PhieuNhap";
            this.dgv_PhieuNhap.Size = new System.Drawing.Size(1067, 192);
            this.dgv_PhieuNhap.TabIndex = 0;
            // 
            // MAHANG
            // 
            this.MAHANG.DataPropertyName = "MAHG";
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.Name = "MAHANG";
            // 
            // TENHANG
            // 
            this.TENHANG.DataPropertyName = "TENHG";
            this.TENHANG.HeaderText = "Tên Hàng";
            this.TENHANG.Name = "TENHANG";
            // 
            // DVTinh
            // 
            this.DVTinh.DataPropertyName = "DVT";
            this.DVTinh.HeaderText = "Đơn vị tính";
            this.DVTinh.Name = "DVTinh";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SOLUONG";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "MÃ NCC";
            this.MANCC.Name = "MANCC";
            // 
            // DonGia1
            // 
            this.DonGia1.DataPropertyName = "DONGIA";
            this.DonGia1.HeaderText = "Đơn giá";
            this.DonGia1.Name = "DonGia1";
            // 
            // TinhTrang1
            // 
            this.TinhTrang1.DataPropertyName = "TINHTRANG";
            this.TinhTrang1.HeaderText = "Tình Trạng";
            this.TinhTrang1.Name = "TinhTrang1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 48);
            this.label1.TabIndex = 78;
            this.label1.Text = "NHẬP HÀNG";
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.BackColor = System.Drawing.Color.Transparent;
            this.btnNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaphang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNhaphang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaphang.Image")));
            this.btnNhaphang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaphang.Location = new System.Drawing.Point(722, 15);
            this.btnNhaphang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(243, 76);
            this.btnNhaphang.TabIndex = 80;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhaphang.UseVisualStyleBackColor = false;
            // 
            // UCNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhaphang);
            this.Name = "UCNhapHang";
            this.Size = new System.Drawing.Size(1147, 678);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.ComboBox cboTT;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_PhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhaphang;
    }
}
