namespace QLSV.App.Views
{
    partial class frmChinhSuaHangLoat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpThaoTac = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.chkDoiGioiTinh = new System.Windows.Forms.CheckBox();
            this.cboLopMoi = new System.Windows.Forms.ComboBox();
            this.chkDoiLop = new System.Windows.Forms.CheckBox();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpThaoTac.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(684, 56);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHỈNH SỬA NHIỀU SV";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpThaoTac);
            this.pnlMain.Controls.Add(this.grpDanhSach);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(684, 385);
            this.pnlMain.TabIndex = 1;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lstSinhVien);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(12, 12);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(300, 361);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Sinh viên đã chọn";
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.ItemHeight = 20;
            this.lstSinhVien.Location = new System.Drawing.Point(3, 26);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(294, 332);
            this.lstSinhVien.TabIndex = 0;
            // 
            // grpThaoTac
            // 
            this.grpThaoTac.Controls.Add(this.cboGioiTinh);
            this.grpThaoTac.Controls.Add(this.chkDoiGioiTinh);
            this.grpThaoTac.Controls.Add(this.cboLopMoi);
            this.grpThaoTac.Controls.Add(this.chkDoiLop);
            this.grpThaoTac.Controls.Add(this.lblHuongDan);
            this.grpThaoTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThaoTac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThaoTac.Location = new System.Drawing.Point(312, 12);
            this.grpThaoTac.Name = "grpThaoTac";
            this.grpThaoTac.Padding = new System.Windows.Forms.Padding(12);
            this.grpThaoTac.Size = new System.Drawing.Size(360, 361);
            this.grpThaoTac.TabIndex = 1;
            this.grpThaoTac.TabStop = false;
            this.grpThaoTac.Text = "Cập nhật chung";
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = false;
            this.lblHuongDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
            this.lblHuongDan.Location = new System.Drawing.Point(12, 26);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(336, 72);
            this.lblHuongDan.TabIndex = 0;
            this.lblHuongDan.Text = "Tick mục cần đổi rồi bấm Lưu. Họ tên, ngày sinh, điểm: mở Chi tiết từng sinh viên (1 người).";
            // 
            // chkDoiLop
            // 
            this.chkDoiLop.AutoSize = true;
            this.chkDoiLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkDoiLop.Location = new System.Drawing.Point(16, 110);
            this.chkDoiLop.Name = "chkDoiLop";
            this.chkDoiLop.Size = new System.Drawing.Size(150, 27);
            this.chkDoiLop.TabIndex = 1;
            this.chkDoiLop.Text = "Chuyển sang lớp";
            this.chkDoiLop.UseVisualStyleBackColor = true;
            this.chkDoiLop.CheckedChanged += new System.EventHandler(this.chkDoiLop_CheckedChanged);
            // 
            // cboLopMoi
            // 
            this.cboLopMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopMoi.Enabled = false;
            this.cboLopMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopMoi.Location = new System.Drawing.Point(16, 143);
            this.cboLopMoi.Name = "cboLopMoi";
            this.cboLopMoi.Size = new System.Drawing.Size(320, 31);
            this.cboLopMoi.TabIndex = 2;
            // 
            // chkDoiGioiTinh
            // 
            this.chkDoiGioiTinh.AutoSize = true;
            this.chkDoiGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkDoiGioiTinh.Location = new System.Drawing.Point(16, 195);
            this.chkDoiGioiTinh.Name = "chkDoiGioiTinh";
            this.chkDoiGioiTinh.Size = new System.Drawing.Size(170, 27);
            this.chkDoiGioiTinh.TabIndex = 3;
            this.chkDoiGioiTinh.Text = "Đặt giới tính chung";
            this.chkDoiGioiTinh.UseVisualStyleBackColor = true;
            this.chkDoiGioiTinh.CheckedChanged += new System.EventHandler(this.chkDoiGioiTinh_CheckedChanged);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Enabled = false;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.cboGioiTinh.Location = new System.Drawing.Point(16, 228);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(200, 31);
            this.cboGioiTinh.TabIndex = 4;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 441);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(684, 56);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(432, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 36);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.DimGray;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(562, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // frmChinhSuaHangLoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 497);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChinhSuaHangLoat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa nhiều sinh viên";
            this.Load += new System.EventHandler(this.frmChinhSuaHangLoat_Load);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpThaoTac.ResumeLayout(false);
            this.grpThaoTac.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.GroupBox grpThaoTac;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.CheckBox chkDoiLop;
        private System.Windows.Forms.ComboBox cboLopMoi;
        private System.Windows.Forms.CheckBox chkDoiGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
