namespace QLSV.App.Views
{
    partial class frmChitietSinhVien
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
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnLichTuan = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblHocLuc = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvDiemThi = new System.Windows.Forms.DataGridView();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiuaKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuoiKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colHuyDangKy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1172, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỒ SƠ CHI TIẾT SINH VIÊN";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeft.Controls.Add(this.btnLichTuan);
            this.pnlLeft.Controls.Add(this.btnLuu);
            this.pnlLeft.Controls.Add(this.lblHocLuc);
            this.pnlLeft.Controls.Add(this.lblGPA);
            this.pnlLeft.Controls.Add(this.dtpNgaySinh);
            this.pnlLeft.Controls.Add(this.cboLop);
            this.pnlLeft.Controls.Add(this.txtHoTen);
            this.pnlLeft.Controls.Add(this.txtMaSV);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.picAvatar);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 60);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(320, 569);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnLichTuan
            // 
            this.btnLichTuan.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLichTuan.FlatAppearance.BorderSize = 0;
            this.btnLichTuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichTuan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLichTuan.ForeColor = System.Drawing.Color.White;
            this.btnLichTuan.Location = new System.Drawing.Point(26, 472);
            this.btnLichTuan.Name = "btnLichTuan";
            this.btnLichTuan.Size = new System.Drawing.Size(264, 36);
            this.btnLichTuan.TabIndex = 12;
            this.btnLichTuan.Text = "LỊCH HỌC TUẦN";
            this.btnLichTuan.UseVisualStyleBackColor = false;
            this.btnLichTuan.Click += new System.EventHandler(this.btnLichTuan_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(26, 516);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(264, 40);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "LƯU THAY ĐỔI";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblHocLuc
            // 
            this.lblHocLuc.AutoSize = true;
            this.lblHocLuc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHocLuc.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblHocLuc.Location = new System.Drawing.Point(20, 432);
            this.lblHocLuc.Name = "lblHocLuc";
            this.lblHocLuc.Size = new System.Drawing.Size(270, 32);
            this.lblHocLuc.TabIndex = 1;
            this.lblHocLuc.Text = "Học lực: Chưa xếp loại";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblGPA.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblGPA.Location = new System.Drawing.Point(20, 386);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(134, 41);
            this.lblGPA.TabIndex = 2;
            this.lblGPA.Text = "GPA: 0.0";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(118, 297);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(182, 30);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.Location = new System.Drawing.Point(118, 347);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(182, 31);
            this.cboLop.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(118, 247);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 30);
            this.txtHoTen.TabIndex = 5;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaSV.Location = new System.Drawing.Point(118, 197);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(182, 30);
            this.txtMaSV.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(16, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lớp Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(16, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(16, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ và Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(16, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã SV:";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Gainsboro;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(100, 20);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(120, 150);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvDiemThi);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(320, 60);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRight.Size = new System.Drawing.Size(852, 569);
            this.pnlRight.TabIndex = 2;
            // 
            // dgvDiemThi
            // 
            this.dgvDiemThi.AllowUserToAddRows = false;
            this.dgvDiemThi.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colHocKy,
            this.colTinChi,
            this.colQuaTrinh,
            this.colGiuaKi,
            this.colCuoiKi,
            this.colTongKet,
            this.colChiTiet,
            this.colHuyDangKy});
            this.dgvDiemThi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDiemThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemThi.Location = new System.Drawing.Point(10, 10);
            this.dgvDiemThi.Name = "dgvDiemThi";
            this.dgvDiemThi.RowHeadersWidth = 51;
            this.dgvDiemThi.RowTemplate.Height = 30;
            this.dgvDiemThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiemThi.Size = new System.Drawing.Size(832, 549);
            this.dgvDiemThi.TabIndex = 0;
            this.dgvDiemThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemThi_CellContentClick);
            // 
            // colMaMH
            // 
            this.colMaMH.HeaderText = "Mã Môn";
            this.colMaMH.MinimumWidth = 6;
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.ReadOnly = true;
            this.colMaMH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaMH.Width = 125;
            // 
            // colTenMH
            // 
            this.colTenMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenMH.HeaderText = "Tên Môn Học";
            this.colTenMH.MinimumWidth = 6;
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.ReadOnly = true;
            // 
            // colHocKy
            // 
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.MinimumWidth = 6;
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.ReadOnly = true;
            this.colHocKy.Width = 95;
            // 
            // colTinChi
            // 
            this.colTinChi.HeaderText = "TC";
            this.colTinChi.MinimumWidth = 6;
            this.colTinChi.Name = "colTinChi";
            this.colTinChi.ReadOnly = true;
            this.colTinChi.Width = 45;
            // 
            // colQuaTrinh
            // 
            this.colQuaTrinh.HeaderText = "QT (20%)";
            this.colQuaTrinh.MinimumWidth = 6;
            this.colQuaTrinh.Name = "colQuaTrinh";
            this.colQuaTrinh.ReadOnly = true;
            this.colQuaTrinh.Width = 72;
            // 
            // colGiuaKi
            // 
            this.colGiuaKi.HeaderText = "Giữa (30%)";
            this.colGiuaKi.MinimumWidth = 6;
            this.colGiuaKi.Name = "colGiuaKi";
            this.colGiuaKi.ReadOnly = true;
            this.colGiuaKi.Width = 72;
            // 
            // colCuoiKi
            // 
            this.colCuoiKi.HeaderText = "Thi CK (50%)";
            this.colCuoiKi.MinimumWidth = 6;
            this.colCuoiKi.Name = "colCuoiKi";
            this.colCuoiKi.ReadOnly = true;
            this.colCuoiKi.Width = 82;
            // 
            // colTongKet
            // 
            this.colTongKet.HeaderText = "Tổng kết";
            this.colTongKet.MinimumWidth = 6;
            this.colTongKet.Name = "colTongKet";
            this.colTongKet.ReadOnly = true;
            this.colTongKet.Width = 65;
            // 
            // colChiTiet
            // 
            this.colChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colChiTiet.HeaderText = "Chi Tiết";
            this.colChiTiet.MinimumWidth = 6;
            this.colChiTiet.Name = "colChiTiet";
            this.colChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colChiTiet.Text = "≡";
            this.colChiTiet.UseColumnTextForButtonValue = true;
            this.colChiTiet.Width = 90;
            // 
            // colHuyDangKy
            // 
            this.colHuyDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colHuyDangKy.HeaderText = "Hủy ĐK";
            this.colHuyDangKy.MinimumWidth = 6;
            this.colHuyDangKy.Name = "colHuyDangKy";
            this.colHuyDangKy.Text = "Hủy";
            this.colHuyDangKy.UseColumnTextForButtonValue = true;
            this.colHuyDangKy.Width = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themMonToolStripMenuItem,
            this.xoaMonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // themMonToolStripMenuItem
            // 
            this.themMonToolStripMenuItem.Name = "themMonToolStripMenuItem";
            this.themMonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.themMonToolStripMenuItem.Text = "Thêm môn (đăng ký)";
            this.themMonToolStripMenuItem.Click += new System.EventHandler(this.themMonToolStripMenuItem_Click);
            // 
            // xoaMonToolStripMenuItem
            // 
            this.xoaMonToolStripMenuItem.Name = "xoaMonToolStripMenuItem";
            this.xoaMonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xoaMonToolStripMenuItem.Text = "Xóa môn (hủy đăng ký)";
            this.xoaMonToolStripMenuItem.Click += new System.EventHandler(this.xoaMonToolStripMenuItem_Click);
            // 
            // frmChitietSinhVien
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 629);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmChitietSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChitietSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frmChitietSinhVien_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblHocLuc;
        private System.Windows.Forms.Button btnLichTuan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiuaKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuoiKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongKet;
        private System.Windows.Forms.DataGridViewButtonColumn colChiTiet;
        private System.Windows.Forms.DataGridViewButtonColumn colHuyDangKy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themMonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaMonToolStripMenuItem;
    }
}