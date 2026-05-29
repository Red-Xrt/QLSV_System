namespace QLSV.App.Views.LichHoc
{
    partial class frmLichHocTuan
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cboSinhVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLich = new System.Windows.Forms.DataGridView();
            this.colThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lblTieuDe);
            this.pnlTop.Controls.Add(this.btnDong);
            this.pnlTop.Controls.Add(this.btnLamMoi);
            this.pnlTop.Controls.Add(this.btnXem);
            this.pnlTop.Controls.Add(this.cboSinhVien);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 72);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(16, 8);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(968, 28);
            this.lblTieuDe.TabIndex = 4;
            this.lblTieuDe.Text = "LỊCH HỌC TUẦN";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.BackColor = System.Drawing.Color.IndianRed;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(884, 8);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 28);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Visible = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(884, 40);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(768, 40);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 28);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem lịch";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cboSinhVien
            // 
            this.cboSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSinhVien.FormattingEnabled = true;
            this.cboSinhVien.Location = new System.Drawing.Point(120, 40);
            this.cboSinhVien.Name = "cboSinhVien";
            this.cboSinhVien.Size = new System.Drawing.Size(632, 31);
            this.cboSinhVien.TabIndex = 1;
            this.cboSinhVien.SelectedIndexChanged += new System.EventHandler(this.cboSinhVien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh viên:";
            // 
            // dgvLich
            // 
            this.dgvLich.AllowUserToAddRows = false;
            this.dgvLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLich.BackgroundColor = System.Drawing.Color.White;
            this.dgvLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThu,
            this.colMaMH,
            this.colTenMH,
            this.colGio,
            this.colPhong,
            this.colGiangVien,
            this.colTinChi});
            this.dgvLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLich.Location = new System.Drawing.Point(0, 72);
            this.dgvLich.Name = "dgvLich";
            this.dgvLich.ReadOnly = true;
            this.dgvLich.RowHeadersWidth = 51;
            this.dgvLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLich.Size = new System.Drawing.Size(1000, 428);
            this.dgvLich.TabIndex = 1;
            // 
            // colThu
            // 
            this.colThu.FillWeight = 70F;
            this.colThu.HeaderText = "Thứ";
            this.colThu.Name = "colThu";
            this.colThu.ReadOnly = true;
            // 
            // colMaMH
            // 
            this.colMaMH.FillWeight = 70F;
            this.colMaMH.HeaderText = "Mã môn";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.ReadOnly = true;
            // 
            // colTenMH
            // 
            this.colTenMH.HeaderText = "Tên môn học";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.ReadOnly = true;
            // 
            // colGio
            // 
            this.colGio.FillWeight = 90F;
            this.colGio.HeaderText = "Giờ học";
            this.colGio.Name = "colGio";
            this.colGio.ReadOnly = true;
            // 
            // colPhong
            // 
            this.colPhong.FillWeight = 60F;
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            // 
            // colGiangVien
            // 
            this.colGiangVien.FillWeight = 90F;
            this.colGiangVien.HeaderText = "Giảng viên";
            this.colGiangVien.Name = "colGiangVien";
            this.colGiangVien.ReadOnly = true;
            // 
            // colTinChi
            // 
            this.colTinChi.FillWeight = 50F;
            this.colTinChi.HeaderText = "TC";
            this.colTinChi.Name = "colTinChi";
            this.colTinChi.ReadOnly = true;
            // 
            // frmLichHocTuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.dgvLich);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLichHocTuan";
            this.Text = "Lịch học tuần";
            this.Load += new System.EventHandler(this.frmLichHocTuan_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSinhVien;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinChi;
    }
}
