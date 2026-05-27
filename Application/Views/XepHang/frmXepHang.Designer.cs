namespace QLSV.App.Views.XepHang
{
    partial class frmXepHang
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.grpBoLoc = new System.Windows.Forms.GroupBox();
            this.btnApDungLoc = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHocLuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.grpXepHang = new System.Windows.Forms.GroupBox();
            this.btnCanhBao = new System.Windows.Forms.Button();
            this.btnHocBong = new System.Windows.Forms.Button();
            this.btnTopGPA = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblStatCanhBao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblStatHocBong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblStatTong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.grpBoLoc.SuspendLayout();
            this.grpXepHang.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1387, 74);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(461, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO & XẾP HẠNG THÀNH TÍCH";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSidebar.Controls.Add(this.btnXuatExcel);
            this.pnlSidebar.Controls.Add(this.grpBoLoc);
            this.pnlSidebar.Controls.Add(this.grpXepHang);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 74);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.pnlSidebar.Size = new System.Drawing.Size(347, 670);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXuatExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(20, 597);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(307, 55);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "XUẤT BÁO CÁO EXCEL";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // grpBoLoc
            // 
            this.grpBoLoc.Controls.Add(this.btnApDungLoc);
            this.grpBoLoc.Controls.Add(this.btnLamMoi);
            this.grpBoLoc.Controls.Add(this.label2);
            this.grpBoLoc.Controls.Add(this.cboHocLuc);
            this.grpBoLoc.Controls.Add(this.label1);
            this.grpBoLoc.Controls.Add(this.cboLop);
            this.grpBoLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoLoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBoLoc.Location = new System.Drawing.Point(20, 240);
            this.grpBoLoc.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoLoc.Name = "grpBoLoc";
            this.grpBoLoc.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoLoc.Size = new System.Drawing.Size(307, 296);
            this.grpBoLoc.TabIndex = 1;
            this.grpBoLoc.TabStop = false;
            this.grpBoLoc.Text = "Lọc Tuỳ Chỉnh";
            // 
            // btnApDungLoc
            // 
            this.btnApDungLoc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApDungLoc.FlatAppearance.BorderSize = 0;
            this.btnApDungLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApDungLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApDungLoc.ForeColor = System.Drawing.Color.White;
            this.btnApDungLoc.Location = new System.Drawing.Point(20, 188);
            this.btnApDungLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnApDungLoc.Name = "btnApDungLoc";
            this.btnApDungLoc.Size = new System.Drawing.Size(267, 43);
            this.btnApDungLoc.TabIndex = 5;
            this.btnApDungLoc.Text = "Áp dụng lọc";
            this.btnApDungLoc.UseVisualStyleBackColor = false;
            this.btnApDungLoc.Click += new System.EventHandler(this.btnApDungLoc_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightGray;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(20, 241);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(267, 43);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xếp loại học lực:";
            // 
            // cboHocLuc
            // 
            this.cboHocLuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocLuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocLuc.Items.AddRange(new object[] {
            "Tất cả",
            "Xuất sắc",
            "Giỏi",
            "Khá",
            "Trung bình",
            "Yếu"});
            this.cboHocLuc.Location = new System.Drawing.Point(20, 148);
            this.cboHocLuc.Margin = new System.Windows.Forms.Padding(4);
            this.cboHocLuc.Name = "cboHocLuc";
            this.cboHocLuc.Size = new System.Drawing.Size(265, 31);
            this.cboHocLuc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Theo Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.Location = new System.Drawing.Point(20, 74);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(265, 31);
            this.cboLop.TabIndex = 8;
            // 
            // grpXepHang
            // 
            this.grpXepHang.Controls.Add(this.btnCanhBao);
            this.grpXepHang.Controls.Add(this.btnHocBong);
            this.grpXepHang.Controls.Add(this.btnTopGPA);
            this.grpXepHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpXepHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpXepHang.Location = new System.Drawing.Point(20, 18);
            this.grpXepHang.Margin = new System.Windows.Forms.Padding(4);
            this.grpXepHang.Name = "grpXepHang";
            this.grpXepHang.Padding = new System.Windows.Forms.Padding(4);
            this.grpXepHang.Size = new System.Drawing.Size(307, 222);
            this.grpXepHang.TabIndex = 0;
            this.grpXepHang.TabStop = false;
            this.grpXepHang.Text = "Thống Kê Nhanh";
            // 
            // btnCanhBao
            // 
            this.btnCanhBao.BackColor = System.Drawing.Color.IndianRed;
            this.btnCanhBao.FlatAppearance.BorderSize = 0;
            this.btnCanhBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanhBao.ForeColor = System.Drawing.Color.White;
            this.btnCanhBao.Location = new System.Drawing.Point(20, 154);
            this.btnCanhBao.Margin = new System.Windows.Forms.Padding(4);
            this.btnCanhBao.Name = "btnCanhBao";
            this.btnCanhBao.Size = new System.Drawing.Size(267, 43);
            this.btnCanhBao.TabIndex = 2;
            this.btnCanhBao.Text = "Cảnh báo học vụ (< 5)";
            this.btnCanhBao.UseVisualStyleBackColor = false;
            // 
            // btnHocBong
            // 
            this.btnHocBong.BackColor = System.Drawing.Color.Goldenrod;
            this.btnHocBong.FlatAppearance.BorderSize = 0;
            this.btnHocBong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocBong.ForeColor = System.Drawing.Color.White;
            this.btnHocBong.Location = new System.Drawing.Point(20, 98);
            this.btnHocBong.Margin = new System.Windows.Forms.Padding(4);
            this.btnHocBong.Name = "btnHocBong";
            this.btnHocBong.Size = new System.Drawing.Size(267, 43);
            this.btnHocBong.TabIndex = 1;
            this.btnHocBong.Text = "Danh sách Học bổng";
            this.btnHocBong.UseVisualStyleBackColor = false;
            // 
            // btnTopGPA
            // 
            this.btnTopGPA.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTopGPA.FlatAppearance.BorderSize = 0;
            this.btnTopGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopGPA.ForeColor = System.Drawing.Color.White;
            this.btnTopGPA.Location = new System.Drawing.Point(20, 43);
            this.btnTopGPA.Margin = new System.Windows.Forms.Padding(4);
            this.btnTopGPA.Name = "btnTopGPA";
            this.btnTopGPA.Size = new System.Drawing.Size(267, 43);
            this.btnTopGPA.TabIndex = 0;
            this.btnTopGPA.Text = "Top Điểm Cao Nhất";
            this.btnTopGPA.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvBaoCao);
            this.pnlMain.Controls.Add(this.pnlStats);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(347, 74);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.pnlMain.Size = new System.Drawing.Size(1040, 670);
            this.pnlMain.TabIndex = 2;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaSV,
            this.colTenSV,
            this.colLop,
            this.colGPA,
            this.colHocLuc,
            this.colGhiChu});
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.Location = new System.Drawing.Point(20, 116);
            this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(1000, 536);
            this.dgvBaoCao.TabIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "Hạng";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 60;
            // 
            // colMaSV
            // 
            this.colMaSV.HeaderText = "Mã Sinh Viên";
            this.colMaSV.MinimumWidth = 6;
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            this.colMaSV.Width = 120;
            // 
            // colTenSV
            // 
            this.colTenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSV.HeaderText = "Họ và Tên";
            this.colTenSV.MinimumWidth = 6;
            this.colTenSV.Name = "colTenSV";
            this.colTenSV.ReadOnly = true;
            // 
            // colLop
            // 
            this.colLop.HeaderText = "Lớp";
            this.colLop.MinimumWidth = 6;
            this.colLop.Name = "colLop";
            this.colLop.ReadOnly = true;
            this.colLop.Width = 125;
            // 
            // colGPA
            // 
            this.colGPA.HeaderText = "Điểm GPA";
            this.colGPA.MinimumWidth = 6;
            this.colGPA.Name = "colGPA";
            this.colGPA.ReadOnly = true;
            this.colGPA.Width = 80;
            // 
            // colHocLuc
            // 
            this.colHocLuc.HeaderText = "Học Lực";
            this.colHocLuc.MinimumWidth = 6;
            this.colHocLuc.Name = "colHocLuc";
            this.colHocLuc.ReadOnly = true;
            this.colHocLuc.Width = 125;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            this.colGhiChu.Width = 120;
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.pnlCard3);
            this.pnlStats.Controls.Add(this.pnlCard2);
            this.pnlStats.Controls.Add(this.pnlCard1);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(20, 18);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1000, 98);
            this.pnlStats.TabIndex = 0;
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.IndianRed;
            this.pnlCard3.Controls.Add(this.lblStatCanhBao);
            this.pnlCard3.Controls.Add(this.label5);
            this.pnlCard3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCard3.Location = new System.Drawing.Point(672, 0);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(320, 86);
            this.pnlCard3.TabIndex = 0;
            // 
            // lblStatCanhBao
            // 
            this.lblStatCanhBao.AutoSize = true;
            this.lblStatCanhBao.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatCanhBao.ForeColor = System.Drawing.Color.White;
            this.lblStatCanhBao.Location = new System.Drawing.Point(13, 37);
            this.lblStatCanhBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatCanhBao.Name = "lblStatCanhBao";
            this.lblStatCanhBao.Size = new System.Drawing.Size(40, 46);
            this.lblStatCanhBao.TabIndex = 0;
            this.lblStatCanhBao.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "NGUY CƠ RỚT";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlCard2.Controls.Add(this.lblStatHocBong);
            this.pnlCard2.Controls.Add(this.label4);
            this.pnlCard2.Location = new System.Drawing.Point(336, 0);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(320, 86);
            this.pnlCard2.TabIndex = 1;
            // 
            // lblStatHocBong
            // 
            this.lblStatHocBong.AutoSize = true;
            this.lblStatHocBong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatHocBong.ForeColor = System.Drawing.Color.White;
            this.lblStatHocBong.Location = new System.Drawing.Point(13, 37);
            this.lblStatHocBong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatHocBong.Name = "lblStatHocBong";
            this.lblStatHocBong.Size = new System.Drawing.Size(40, 46);
            this.lblStatHocBong.TabIndex = 0;
            this.lblStatHocBong.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ĐẠT HỌC BỔNG";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCard1.Controls.Add(this.lblStatTong);
            this.pnlCard1.Controls.Add(this.label3);
            this.pnlCard1.Location = new System.Drawing.Point(0, 0);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(320, 86);
            this.pnlCard1.TabIndex = 2;
            // 
            // lblStatTong
            // 
            this.lblStatTong.AutoSize = true;
            this.lblStatTong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatTong.ForeColor = System.Drawing.Color.White;
            this.lblStatTong.Location = new System.Drawing.Point(13, 37);
            this.lblStatTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatTong.Name = "lblStatTong";
            this.lblStatTong.Size = new System.Drawing.Size(40, 46);
            this.lblStatTong.TabIndex = 0;
            this.lblStatTong.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "TỔNG SỐ HIỂN THỊ";
            // 
            // frmXepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 744);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXepHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê";
            this.Load += new System.EventHandler(this.frmXepHang_Load);
            this.btnTopGPA.Click += new System.EventHandler(this.btnTopGPA_Click);
            this.btnHocBong.Click += new System.EventHandler(this.btnHocBong_Click);
            this.btnCanhBao.Click += new System.EventHandler(this.btnCanhBao_Click);
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            this.cboHocLuc.SelectedIndexChanged += new System.EventHandler(this.cboHocLuc_SelectedIndexChanged);
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.grpBoLoc.ResumeLayout(false);
            this.grpBoLoc.PerformLayout();
            this.grpXepHang.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.GroupBox grpXepHang;
        private System.Windows.Forms.Button btnTopGPA;
        private System.Windows.Forms.Button btnHocBong;
        private System.Windows.Forms.Button btnCanhBao;
        private System.Windows.Forms.GroupBox grpBoLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHocLuc;
        private System.Windows.Forms.Button btnApDungLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblStatTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblStatCanhBao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblStatHocBong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}