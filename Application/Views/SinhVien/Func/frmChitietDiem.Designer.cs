namespace QLSV.App.Views
{
    partial class frmChitietDiem
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemQuaTrinh = new System.Windows.Forms.TextBox();
            this.txtDiemGiuaKi = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.lblDiemTong = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(350, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chi Tiết Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Điểm Quá Trình (20%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Điểm Giữa Kỳ (30%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(30, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Điểm Thi Cuối Kỳ (50%):";
            // 
            // txtDiemQuaTrinh
            // 
            this.txtDiemQuaTrinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiemQuaTrinh.Location = new System.Drawing.Point(210, 77);
            this.txtDiemQuaTrinh.Name = "txtDiemQuaTrinh";
            this.txtDiemQuaTrinh.Size = new System.Drawing.Size(100, 27);
            this.txtDiemQuaTrinh.TabIndex = 11;
            this.txtDiemQuaTrinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiemGiuaKi
            // 
            this.txtDiemGiuaKi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiemGiuaKi.Location = new System.Drawing.Point(210, 127);
            this.txtDiemGiuaKi.Name = "txtDiemGiuaKi";
            this.txtDiemGiuaKi.Size = new System.Drawing.Size(100, 27);
            this.txtDiemGiuaKi.TabIndex = 10;
            this.txtDiemGiuaKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiemThi.Location = new System.Drawing.Point(210, 177);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(100, 27);
            this.txtDiemThi.TabIndex = 9;
            this.txtDiemThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiemTong
            // 
            this.lblDiemTong.AutoSize = true;
            this.lblDiemTong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDiemTong.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDiemTong.Location = new System.Drawing.Point(30, 230);
            this.lblDiemTong.Name = "lblDiemTong";
            this.lblDiemTong.Size = new System.Drawing.Size(191, 25);
            this.lblDiemTong.TabIndex = 6;
            this.lblDiemTong.Text = "TỔNG KẾT: 0.0 (Rớt)";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(180, 280);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 35);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu Điểm";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.Location = new System.Drawing.Point(34, 280);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // frmChitietDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 340);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblDiemTong);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.txtDiemGiuaKi);
            this.Controls.Add(this.txtDiemQuaTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChitietDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật điểm";
            this.Load += new System.EventHandler(this.frmChitietDiem_Load);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.txtDiemQuaTrinh.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            this.txtDiemGiuaKi.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            this.txtDiemThi.TextChanged += new System.EventHandler(this.txtDiem_TextChanged);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemQuaTrinh;
        private System.Windows.Forms.TextBox txtDiemGiuaKi;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label lblDiemTong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
    }
}