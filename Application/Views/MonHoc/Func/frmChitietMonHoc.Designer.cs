namespace QLSV.App.Views.MonHoc.Func
{
    partial class frmChitietMonHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.cboThu = new System.Windows.Forms.ComboBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtGiangVien = new System.Windows.Forms.TextBox();
            this.numTinChi = new System.Windows.Forms.NumericUpDown();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTinChi)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(520, 52);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTitle.Text = "CHI TIẾT MÔN HỌC";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.txtMoTa);
            this.pnlBody.Controls.Add(this.label8);
            this.pnlBody.Controls.Add(this.dtpGioKetThuc);
            this.pnlBody.Controls.Add(this.dtpGioBatDau);
            this.pnlBody.Controls.Add(this.cboThu);
            this.pnlBody.Controls.Add(this.txtPhong);
            this.pnlBody.Controls.Add(this.txtGiangVien);
            this.pnlBody.Controls.Add(this.numTinChi);
            this.pnlBody.Controls.Add(this.txtTenMH);
            this.pnlBody.Controls.Add(this.txtMaMH);
            this.pnlBody.Controls.Add(this.label7);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 52);
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 16, 20, 12);
            this.pnlBody.Size = new System.Drawing.Size(520, 388);
            // 
            // labels & inputs
            // 
            this.label1.Text = "Mã môn:"; this.label1.Location = new System.Drawing.Point(20, 20); this.label1.AutoSize = true;
            this.txtMaMH.Location = new System.Drawing.Point(140, 16); this.txtMaMH.Size = new System.Drawing.Size(340, 27); this.txtMaMH.ReadOnly = true;
            this.label2.Text = "Tên môn:"; this.label2.Location = new System.Drawing.Point(20, 58); this.label2.AutoSize = true;
            this.txtTenMH.Location = new System.Drawing.Point(140, 54); this.txtTenMH.Size = new System.Drawing.Size(340, 27);
            this.label3.Text = "Số tín chỉ:"; this.label3.Location = new System.Drawing.Point(20, 96); this.label3.AutoSize = true;
            this.numTinChi.Location = new System.Drawing.Point(140, 92); this.numTinChi.Minimum = 1; this.numTinChi.Maximum = 10; this.numTinChi.Value = 3;
            this.label4.Text = "Giảng viên:"; this.label4.Location = new System.Drawing.Point(20, 134); this.label4.AutoSize = true;
            this.txtGiangVien.Location = new System.Drawing.Point(140, 130); this.txtGiangVien.Size = new System.Drawing.Size(340, 27);
            this.label5.Text = "Phòng:"; this.label5.Location = new System.Drawing.Point(20, 172); this.label5.AutoSize = true;
            this.txtPhong.Location = new System.Drawing.Point(140, 168); this.txtPhong.Size = new System.Drawing.Size(120, 27);
            this.label6.Text = "Thứ:"; this.label6.Location = new System.Drawing.Point(280, 172); this.label6.AutoSize = true;
            this.cboThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThu.Location = new System.Drawing.Point(330, 168); this.cboThu.Size = new System.Drawing.Size(150, 28);
            this.label7.Text = "Giờ học:"; this.label7.Location = new System.Drawing.Point(20, 210); this.label7.AutoSize = true;
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Location = new System.Drawing.Point(140, 206); this.dtpGioBatDau.Size = new System.Drawing.Size(110, 27);
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(280, 206); this.dtpGioKetThuc.Size = new System.Drawing.Size(110, 27);
            this.label8.Text = "Mô tả:"; this.label8.Location = new System.Drawing.Point(20, 248); this.label8.AutoSize = true;
            this.txtMoTa.Location = new System.Drawing.Point(140, 244); this.txtMoTa.Multiline = true;
            this.txtMoTa.Size = new System.Drawing.Size(340, 80); this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Controls.Add(this.btnDong);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Size = new System.Drawing.Size(520, 52);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(280, 8);
            this.btnLuu.Size = new System.Drawing.Size(100, 36);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnDong.BackColor = System.Drawing.Color.DimGray;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(390, 8);
            this.btnDong.Size = new System.Drawing.Size(100, 36);
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // frmChitietMonHoc
            // 
            this.ClientSize = new System.Drawing.Size(520, 492);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết môn học";
            this.Load += new System.EventHandler(this.frmChitietMonHoc_Load);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTinChi)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTinChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiangVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
    }
}
