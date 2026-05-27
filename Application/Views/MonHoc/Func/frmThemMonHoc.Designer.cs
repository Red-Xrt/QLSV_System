namespace QLSV.App.Views.MonHoc.Func
{
    partial class frmThemMonHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabHeThong = new System.Windows.Forms.TabPage();
            this.btnLuuHeThong = new System.Windows.Forms.Button();
            this.numTinChi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSinhVien = new System.Windows.Forms.TabPage();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenuExcel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuImportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopSV = new System.Windows.Forms.Panel();
            this.cboLocLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboChonMon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBotSV = new System.Windows.Forms.Panel();
            this.lblDaChon = new System.Windows.Forms.Label();
            this.btnLuuDangKy = new System.Windows.Forms.Button();
            this.btnUnSellectAll = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabHeThong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTinChi)).BeginInit();
            this.tabSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.ctxMenuExcel.SuspendLayout();
            this.pnlTopSV.SuspendLayout();
            this.pnlBotSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabHeThong);
            this.tabMain.Controls.Add(this.tabSinhVien);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(847, 560);
            this.tabMain.TabIndex = 0;
            // 
            // tabHeThong
            // 
            this.tabHeThong.BackColor = System.Drawing.Color.White;
            this.tabHeThong.Controls.Add(this.btnLuuHeThong);
            this.tabHeThong.Controls.Add(this.numTinChi);
            this.tabHeThong.Controls.Add(this.label3);
            this.tabHeThong.Controls.Add(this.txtTenMH);
            this.tabHeThong.Controls.Add(this.label2);
            this.tabHeThong.Controls.Add(this.txtMaMH);
            this.tabHeThong.Controls.Add(this.label1);
            this.tabHeThong.Location = new System.Drawing.Point(4, 26);
            this.tabHeThong.Name = "tabHeThong";
            this.tabHeThong.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeThong.Size = new System.Drawing.Size(839, 530);
            this.tabHeThong.TabIndex = 0;
            this.tabHeThong.Text = "Tạo Môn Học Mới";
            // 
            // btnLuuHeThong
            // 
            this.btnLuuHeThong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuuHeThong.FlatAppearance.BorderSize = 0;
            this.btnLuuHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHeThong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuuHeThong.ForeColor = System.Drawing.Color.White;
            this.btnLuuHeThong.Location = new System.Drawing.Point(150, 240);
            this.btnLuuHeThong.Name = "btnLuuHeThong";
            this.btnLuuHeThong.Size = new System.Drawing.Size(250, 40);
            this.btnLuuHeThong.TabIndex = 6;
            this.btnLuuHeThong.Text = "+ Thêm Môn Vào Hệ Thống";
            this.btnLuuHeThong.UseVisualStyleBackColor = false;
            // 
            // numTinChi
            // 
            this.numTinChi.Location = new System.Drawing.Point(150, 168);
            this.numTinChi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTinChi.Name = "numTinChi";
            this.numTinChi.Size = new System.Drawing.Size(100, 25);
            this.numTinChi.TabIndex = 7;
            this.numTinChi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Tín Chỉ:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(150, 107);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(283, 25);
            this.txtTenMH.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Môn Học:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(150, 47);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(250, 25);
            this.txtMaMH.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Môn Học:";
            // 
            // tabSinhVien
            // 
            this.tabSinhVien.BackColor = System.Drawing.Color.White;
            this.tabSinhVien.Controls.Add(this.dgvSinhVien);
            this.tabSinhVien.Controls.Add(this.pnlTopSV);
            this.tabSinhVien.Controls.Add(this.pnlBotSV);
            this.tabSinhVien.Location = new System.Drawing.Point(4, 26);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabSinhVien.Size = new System.Drawing.Size(839, 530);
            this.tabSinhVien.TabIndex = 1;
            this.tabSinhVien.Text = "Đăng Ký Môn Cho Sinh Viên";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChon,
            this.colMaSV,
            this.colTenSV,
            this.colLop});
            this.dgvSinhVien.ContextMenuStrip = this.ctxMenuExcel;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(3, 113);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowTemplate.Height = 28;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(833, 354);
            this.dgvSinhVien.TabIndex = 1;
            // 
            // colChon
            // 
            this.colChon.HeaderText = "Chọn";
            this.colChon.Name = "colChon";
            this.colChon.Width = 60;
            // 
            // colMaSV
            // 
            this.colMaSV.HeaderText = "Mã Sinh Viên";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            this.colMaSV.Width = 150;
            // 
            // colTenSV
            // 
            this.colTenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSV.HeaderText = "Tên Sinh Viên";
            this.colTenSV.Name = "colTenSV";
            this.colTenSV.ReadOnly = true;
            // 
            // colLop
            // 
            this.colLop.HeaderText = "Lớp";
            this.colLop.Name = "colLop";
            this.colLop.ReadOnly = true;
            this.colLop.Width = 120;
            // 
            // ctxMenuExcel
            // 
            this.ctxMenuExcel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportExcel,
            this.mnuExportExcel});
            this.ctxMenuExcel.Name = "ctxMenuExcel";
            this.ctxMenuExcel.Size = new System.Drawing.Size(164, 48);
            // 
            // mnuImportExcel
            // 
            this.mnuImportExcel.Name = "mnuImportExcel";
            this.mnuImportExcel.Size = new System.Drawing.Size(163, 22);
            this.mnuImportExcel.Text = "Import từ Excel...";
            // 
            // mnuExportExcel
            // 
            this.mnuExportExcel.Name = "mnuExportExcel";
            this.mnuExportExcel.Size = new System.Drawing.Size(163, 22);
            this.mnuExportExcel.Text = "Export ra Excel...";
            // 
            // pnlTopSV
            // 
            this.pnlTopSV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopSV.Controls.Add(this.btnUnSellectAll);
            this.pnlTopSV.Controls.Add(this.cboLocLop);
            this.pnlTopSV.Controls.Add(this.label5);
            this.pnlTopSV.Controls.Add(this.btnCheckAll);
            this.pnlTopSV.Controls.Add(this.btnTimKiem);
            this.pnlTopSV.Controls.Add(this.txtTimKiem);
            this.pnlTopSV.Controls.Add(this.cboChonMon);
            this.pnlTopSV.Controls.Add(this.label4);
            this.pnlTopSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSV.Location = new System.Drawing.Point(3, 3);
            this.pnlTopSV.Name = "pnlTopSV";
            this.pnlTopSV.Size = new System.Drawing.Size(833, 110);
            this.pnlTopSV.TabIndex = 0;
            // 
            // cboLocLop
            // 
            this.cboLocLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLop.Location = new System.Drawing.Point(85, 65);
            this.cboLocLop.Name = "cboLocLop";
            this.cboLocLop.Size = new System.Drawing.Size(150, 25);
            this.cboLocLop.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lọc Lớp:";
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckAll.FlatAppearance.BorderSize = 0;
            this.btnCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAll.ForeColor = System.Drawing.Color.White;
            this.btnCheckAll.Location = new System.Drawing.Point(568, 62);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(117, 28);
            this.btnCheckAll.TabIndex = 2;
            this.btnCheckAll.Text = "Chọn tất cả";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(460, 64);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 27);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm SV";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(250, 65);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 25);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.Text = "Nhập mã, tên SV...";
            // 
            // cboChonMon
            // 
            this.cboChonMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChonMon.Location = new System.Drawing.Point(160, 20);
            this.cboChonMon.Name = "cboChonMon";
            this.cboChonMon.Size = new System.Drawing.Size(300, 25);
            this.cboChonMon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn Môn Học";
            // 
            // pnlBotSV
            // 
            this.pnlBotSV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBotSV.Controls.Add(this.lblDaChon);
            this.pnlBotSV.Controls.Add(this.btnLuuDangKy);
            this.pnlBotSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotSV.Location = new System.Drawing.Point(3, 467);
            this.pnlBotSV.Name = "pnlBotSV";
            this.pnlBotSV.Size = new System.Drawing.Size(833, 60);
            this.pnlBotSV.TabIndex = 2;
            // 
            // lblDaChon
            // 
            this.lblDaChon.AutoSize = true;
            this.lblDaChon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDaChon.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDaChon.Location = new System.Drawing.Point(20, 20);
            this.lblDaChon.Name = "lblDaChon";
            this.lblDaChon.Size = new System.Drawing.Size(149, 20);
            this.lblDaChon.TabIndex = 1;
            this.lblDaChon.Text = "Đã chọn: 0 sinh viên";
            // 
            // btnLuuDangKy
            // 
            this.btnLuuDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuDangKy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuuDangKy.FlatAppearance.BorderSize = 0;
            this.btnLuuDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDangKy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuuDangKy.ForeColor = System.Drawing.Color.White;
            this.btnLuuDangKy.Location = new System.Drawing.Point(619, 10);
            this.btnLuuDangKy.Name = "btnLuuDangKy";
            this.btnLuuDangKy.Size = new System.Drawing.Size(200, 40);
            this.btnLuuDangKy.TabIndex = 0;
            this.btnLuuDangKy.Text = "Lưu Đăng Ký";
            this.btnLuuDangKy.UseVisualStyleBackColor = false;
            // 
            // btnUnSellectAll
            // 
            this.btnUnSellectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnSellectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUnSellectAll.FlatAppearance.BorderSize = 0;
            this.btnUnSellectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnSellectAll.ForeColor = System.Drawing.Color.White;
            this.btnUnSellectAll.Location = new System.Drawing.Point(695, 62);
            this.btnUnSellectAll.Name = "btnUnSellectAll";
            this.btnUnSellectAll.Size = new System.Drawing.Size(118, 28);
            this.btnUnSellectAll.TabIndex = 7;
            this.btnUnSellectAll.Text = "Bỏ chọn tất cả";
            this.btnUnSellectAll.UseVisualStyleBackColor = false;
            // 
            // frmThemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 560);
            this.Controls.Add(this.tabMain);
            this.Name = "frmThemMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thêm Môn Học";
            this.Load += new System.EventHandler(this.frmThemMonHoc_Load);
            this.btnLuuHeThong.Click += new System.EventHandler(this.btnLuuHeThong_Click);
            this.btnLuuDangKy.Click += new System.EventHandler(this.btnLuuDangKy_Click);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.cboLocLop.SelectedIndexChanged += new System.EventHandler(this.cboLocLop_SelectedIndexChanged);
            this.cboChonMon.SelectedIndexChanged += new System.EventHandler(this.cboChonMon_SelectedIndexChanged);
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            this.btnUnSellectAll.Click += new System.EventHandler(this.btnUnSellectAll_Click);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            this.mnuExportExcel.Click += new System.EventHandler(this.mnuExportExcel_Click);
            this.mnuImportExcel.Click += new System.EventHandler(this.mnuImportExcel_Click);
            this.tabMain.ResumeLayout(false);
            this.tabHeThong.ResumeLayout(false);
            this.tabHeThong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTinChi)).EndInit();
            this.tabSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ctxMenuExcel.ResumeLayout(false);
            this.pnlTopSV.ResumeLayout(false);
            this.pnlTopSV.PerformLayout();
            this.pnlBotSV.ResumeLayout(false);
            this.pnlBotSV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabHeThong;
        private System.Windows.Forms.TabPage tabSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTinChi;
        private System.Windows.Forms.Button btnLuuHeThong;
        private System.Windows.Forms.Panel pnlTopSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboChonMon;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.Panel pnlBotSV;
        private System.Windows.Forms.Button btnLuuDangKy;
        private System.Windows.Forms.ComboBox cboLocLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDaChon;
        private System.Windows.Forms.ContextMenuStrip ctxMenuExcel;
        private System.Windows.Forms.ToolStripMenuItem mnuImportExcel;
        private System.Windows.Forms.ToolStripMenuItem mnuExportExcel;
        private System.Windows.Forms.Button btnUnSellectAll;
    }
}