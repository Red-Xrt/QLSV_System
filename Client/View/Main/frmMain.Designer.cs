namespace Client.View
{
    partial class frmMain
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnTaiKhoan);
            this.pnlSidebar.Controls.Add(this.btnBaoCao);
            this.pnlSidebar.Controls.Add(this.btnMonHoc);
            this.pnlSidebar.Controls.Add(this.btnSinhVien);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(293, 638);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 564);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(293, 74);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 320);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(293, 74);
            this.btnTaiKhoan.TabIndex = 5;
            this.btnTaiKhoan.Text = "Đổi Mật Khẩu";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 246);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(293, 74);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Báo Cáo & Xếp Hạng";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonHoc.FlatAppearance.BorderSize = 0;
            this.btnMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonHoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonHoc.Location = new System.Drawing.Point(0, 172);
            this.btnMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMonHoc.Size = new System.Drawing.Size(293, 74);
            this.btnMonHoc.TabIndex = 2;
            this.btnMonHoc.Text = "Quản Lý Môn Học";
            this.btnMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinhVien.FlatAppearance.BorderSize = 0;
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 98);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSinhVien.Size = new System.Drawing.Size(293, 74);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "Quản Lý Sinh Viên";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(293, 98);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(67, 37);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(141, 28);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "TDMU - QLSV";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlHeader.Controls.Add(this.lblXinChao);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(293, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1099, 98);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblXinChao
            // 
            this.lblXinChao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblXinChao.Location = new System.Drawing.Point(686, 39);
            this.lblXinChao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(373, 25);
            this.lblXinChao.TabIndex = 1;
            this.lblXinChao.Text = "Xin chào, Test1";
            this.lblXinChao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRANG CHỦ";
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(293, 98);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1099, 540);
            this.pnlDesktop.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 638);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Sinh Viên - TDMU";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblXinChao;
    }
}